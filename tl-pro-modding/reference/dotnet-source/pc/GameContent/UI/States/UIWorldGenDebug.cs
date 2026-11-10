// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.States.UIWorldGenDebug
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Newtonsoft.Json;
using ReLogic.Content;
using ReLogic.Graphics;
using ReLogic.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent.UI.Elements;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Testing;
using Terraria.UI;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.UI.States;

public class UIWorldGenDebug : UIState
{
  private UIWrappedSearchBar searchBar;
  private string lastSearchText;
  private string searchText;
  private bool showMap;
  private bool hideChat;
  private bool hideUI;
  private bool disableDebugOnClose;
  private bool disableLightOnClose;
  private IEnumerator<object> TestEnumerator;
  private UIElement controlListArea;
  private UIPanel controlPanel;
  private UIPanel scrollPanel;
  private UIScrollbar scrollbar;
  private UIList GenPassList;
  private GroupOptionButton<bool> SearchButton;
  private List<UIWorldGenDebug.GenPassElement> allPasses = new List<UIWorldGenDebug.GenPassElement>();
  private bool searchVisible = true;
  private int LassPassIndex;
  private Tuple<UIWorldGenDebug.GenPassElement, Action<UIWorldGenDebug.GenPassElement>> _previousRangePassClickEvent;
  private int ignoreEscapeAttempt;
  private Point nextMapSection;
  private TimeSpan fullMapScanPeriod;
  private Stopwatch fullMapScanTimer;
  private Stopwatch lastScanRateUpdate = Stopwatch.StartNew();

  private static void SetButtonState(
    UIWorldGenDebug.UIImageButtonWithExtraIcon button,
    UIWorldGenDebug.ButtonState state)
  {
    switch (state)
    {
      case UIWorldGenDebug.ButtonState.Enabled:
        button.SetVisibility(1f, 0.4f);
        break;
      case UIWorldGenDebug.ButtonState.NotVisible:
        button.SetVisibility(0.0f, 0.0f);
        break;
    }
    button.IgnoresMouseInteraction = state != 0;
  }

  public static UIWorldGenDebug ActiveInstance
  {
    get => UserInterface.ActiveInstance.CurrentState as UIWorldGenDebug;
  }

  public static bool IsActive
  {
    get
    {
      return (Main.gameMenu ? Main.MenuUI.CurrentState : Main.InGameUI.CurrentState) is UIWorldGenDebug;
    }
  }

  public static void Open()
  {
    if (Main.gameMenu)
      Main.MenuUI.SetState((UIState) new UIWorldGenDebug());
    else
      IngameFancyUI.OpenUIState((UIState) new UIWorldGenDebug());
  }

  public static void Close()
  {
    if (UIWorldGenDebug.ActiveInstance == null)
      return;
    if (Main.gameMenu)
      Main.MenuUI.SetState((UIState) new UIWorldLoad());
    else
      IngameFancyUI.Close();
  }

  private static WorldGenerator.Controller Controller => WorldGenerator.CurrentController;

  private static bool CanSubmitActions
  {
    get => UIWorldGenDebug.Controller.Paused && UIWorldGenDebug.Controller.CurrentPass == null;
  }

  public static GenPass CurrentTargetOrLatestPass
  {
    get
    {
      return (UIWorldGenDebug.Controller.PauseAfterPass ?? UIWorldGenDebug.Controller.CurrentPass) ?? UIWorldGenDebug.Controller.LastCompletedPass;
    }
  }

  public static GenPass CurrentTargetPass
  {
    get
    {
      GenPass currentTargetPass = UIWorldGenDebug.Controller.PauseAfterPass;
      if (currentTargetPass == UIWorldGenDebug.Controller.LastCompletedPass)
        currentTargetPass = (GenPass) null;
      return currentTargetPass;
    }
  }

  public UIWorldGenDebug()
  {
    this.NoGamepadSupport = true;
    this.IgnoresMouseInteraction = true;
    UIGenProgressBar uiGenProgressBar = new UIGenProgressBar();
    uiGenProgressBar.VAlign = 0.0f;
    uiGenProgressBar.HAlign = 0.5f;
    uiGenProgressBar.Top = StyleDimension.FromPixels(20f);
    uiGenProgressBar.IgnoresMouseInteraction = true;
    UIGenProgressBar progressBar = uiGenProgressBar;
    this.Append((UIElement) progressBar);
    UIHeader uiHeader = new UIHeader();
    uiHeader.VAlign = 0.0f;
    uiHeader.HAlign = 0.5f;
    uiHeader.IgnoresMouseInteraction = true;
    UIHeader progressMessage = uiHeader;
    this.Append((UIElement) progressMessage);
    this.OnUpdate += (UIElement.ElementEvent) (e =>
    {
      progressBar.SetProgress((float) WorldGenerator.CurrentGenerationProgress.TotalProgress, (float) WorldGenerator.CurrentGenerationProgress.Value);
      progressMessage.Text = WorldGenerator.CurrentGenerationProgress.Message;
      if (WorldGenerator.CurrentController.QueuedAbort)
        progressMessage.Text = Language.GetTextValue("UI.Canceling");
      if (WorldGen.Manifest.GenPassResults.Count == this.LassPassIndex)
        return;
      this.LassPassIndex = WorldGen.Manifest.GenPassResults.Count;
      this.EnsurePassVisible(this.LassPassIndex);
    });
    this.controlListArea = new UIElement()
    {
      Width = StyleDimension.FromPixels(450f),
      Height = StyleDimension.FromPixelsAndPercent(-60f, 1f),
      Top = StyleDimension.FromPixels(30f),
      Left = StyleDimension.FromPixels(10f)
    };
    this.Append(this.controlListArea);
    UIPanel uiPanel1 = new UIPanel();
    uiPanel1.Height = StyleDimension.FromPixels(50f);
    this.controlPanel = uiPanel1;
    this.controlPanel.SetPadding(8f);
    this.controlPanel.BackgroundColor = new Color(73, 94, 171) * 0.9f;
    GroupOptionButton<bool> groupOptionButton1 = this.AddButton(this.controlPanel, "Images/UI/Camera_0", (Action) (() => UIWorldGenDebug.Controller.DeleteAllSnapshots()), (Func<string>) (() => "Delete all snapshots"), (Func<string>) (() => $"Click to clear all snapshots\nEstimated Disk Usage: {(object) (WorldGenSnapshot.EstimatedDiskUsage / 1024L /*0x0400*/ / 1024L /*0x0400*/)}MB{(UIWorldGenDebug.CanSubmitActions ? (object) "" : (object) "\n[c/FFA500:Must be paused to manipulate snapshots]")}"));
    UIImage uiImage = new UIImage(Main.Assets.Request<Texture2D>("Images/CoolDown", (AssetRequestMode) 1));
    uiImage.ScaleToFit = true;
    uiImage.Width = new StyleDimension(28f, 0.0f);
    uiImage.Height = new StyleDimension(28f, 0.0f);
    uiImage.Left = new StyleDimension(3f, 0.0f);
    uiImage.Top = new StyleDimension(3f, 0.0f);
    UIImage element1 = uiImage;
    groupOptionButton1.Append((UIElement) element1);
    GroupOptionButton<bool> groupOptionButton2 = this.AddButton(this.controlPanel, "Images/UI/IconReset", (Action) (() => UIWorldGenDebug.Controller.TryReset()), (Func<string>) (() => "Reset"), (Func<string>) (() => !UIWorldGenDebug.CanSubmitActions ? "[c/FFA500:Must be paused to reset]" : (string) null));
    groupOptionButton2.IconScale = 28f / (float) groupOptionButton2.Icon.Width;
    groupOptionButton2.IconOffset = new Vector2(2f, 3f);
    GroupOptionButton<bool> groupOptionButton3 = this.AddButton(this.controlPanel, "Images/UI/IconPrev", new Action(this.StepBack), (Func<string>) (() => "Step Back"), (Func<string>) (() => "Hotkey: Up/Left"));
    groupOptionButton3.IconScale = 28f / (float) groupOptionButton3.Icon.Width;
    groupOptionButton3.IconOffset = new Vector2(2f, 3f);
    GroupOptionButton<bool> playPauseButton = this.AddButton(this.controlPanel, "Images/UI/IconPlayPause", (Action) (() =>
    {
      WorldGenerator.Controller controller = UIWorldGenDebug.Controller;
      controller.Paused = !controller.Paused;
    }), (Func<string>) (() => !WorldGenerator.CurrentController.Paused ? "Pause" : "Play"), (Func<string>) (() => "Hotkey: Space"));
    playPauseButton.IconScale = 28f / (float) playPauseButton.Icon.Width;
    playPauseButton.IconOffset = new Vector2(3f, 3f);
    playPauseButton.OnUpdate += (UIElement.ElementEvent) (e => playPauseButton.SetIconFrame(playPauseButton.Icon.Frame(verticalFrames: 2, frameY: UIWorldGenDebug.Controller.Paused ? 0 : 1)));
    GroupOptionButton<bool> groupOptionButton4 = this.AddButton(this.controlPanel, "Images/UI/IconNext", new Action(this.StepForward), (Func<string>) (() => "Step Forward"), (Func<string>) (() => "Hotkey: Down/Right"));
    groupOptionButton4.IconScale = 28f / (float) groupOptionButton4.Icon.Width;
    groupOptionButton4.IconOffset = new Vector2(2f, 3f);
    this.AddButton(this.controlPanel, "Images/Map_0", (Action) (() => this.ToggleMap()), (Func<string>) (() => "Toggle Map"), (Func<string>) (() => "Left click to toggle the map display")).IconOffset = new Vector2(4f, 5f);
    GroupOptionButton<bool> groupOptionButton5 = this.AddButton(this.controlPanel, "Images/Extra_" + (object) (short) 48 /*0x30*/, (Action) (() => this.hideChat = !this.hideChat), (Func<string>) (() => "Toggle Chat"), (Func<string>) (() => "Left click to toggle the chat log"));
    Asset<Texture2D> asset = Main.Assets.Request<Texture2D>("Images/Extra_" + (object) (short) 48 /*0x30*/, (AssetRequestMode) 1);
    Microsoft.Xna.Framework.Rectangle region = asset.Frame(8, EmoteBubble.EMOTE_SHEET_VERTICAL_FRAMES, 1);
    groupOptionButton5.IconScale = 28f / (float) region.Width;
    groupOptionButton5.IconOffset = new Vector2(3f, 5f);
    groupOptionButton5.SetIconFrame(region);
    Microsoft.Xna.Framework.Rectangle rectangle = asset.Frame(8, EmoteBubble.EMOTE_SHEET_VERTICAL_FRAMES, 4, 3);
    UIImage element2 = new UIImage(asset);
    element2.Frame = new Microsoft.Xna.Framework.Rectangle?(rectangle);
    element2.ScaleToFit = true;
    element2.Width = new StyleDimension(28f, 0.0f);
    element2.Height = new StyleDimension(28f, 0.0f);
    element2.Left = new StyleDimension(2f, 0.0f);
    element2.Top = new StyleDimension(6f, 0.0f);
    groupOptionButton5.Append((UIElement) element2);
    GroupOptionButton<bool> snapshotFrequencyButton = this.AddButton(this.controlPanel, "Images/UI/IconSnapshotFrequency", new Action(this.CycleSnapshotMode), new Func<string>(this.GetSnapshotModeButtonTitle));
    snapshotFrequencyButton.OnUpdate += (UIElement.ElementEvent) (e => snapshotFrequencyButton.SetIconFrame(snapshotFrequencyButton.Icon.Frame(verticalFrames: 3, frameY: (int) WorldGenerator.CurrentController.SnapshotFrequency)));
    GroupOptionButton<bool> mismatchPauseButton = this.AddButton(this.controlPanel, "Images/UI/IconMismatchPause", (Action) (() =>
    {
      WorldGenerator.Controller controller = UIWorldGenDebug.Controller;
      controller.PauseOnHashMismatch = !controller.PauseOnHashMismatch;
    }), (Func<string>) (() => "Pause on gen pass change: " + (WorldGenerator.CurrentController.PauseOnHashMismatch ? "On" : "Off")), (Func<string>) (() => "Stop the generator when the output of a pass is different\nto the last time it was run in the save, or current session"));
    mismatchPauseButton.SetColorsBasedOnSelectionState(new Color(152, 175, 235), Colors.InventoryDefaultColor, 1f, 0.7f);
    mismatchPauseButton.OnUpdate += (UIElement.ElementEvent) (e => mismatchPauseButton.SetCurrentOption(WorldGenerator.CurrentController.PauseOnHashMismatch));
    string quickLoadCommand = Main.gameMenu ? "/quickload-regen" : "/quickload";
    this.AddButton(this.controlPanel, "Images/UI/IconQuickload", (Action) (() => DebugUtils.QuickSPMessage(quickLoadCommand)), (Func<string>) (() => "Save current settings to " + quickLoadCommand), (Func<string>) (() => "Future launches of the game will automatically load the world\nfrom the most recent snapshot, and run to the current pass"));
    GroupOptionButton<bool> groupOptionButton6 = this.AddButton(this.controlPanel, "Images/UI/Bestiary/Icon_Locked", (Action) (() => { }), (Func<string>) (() => "Controls"), (Func<string>) (() => this.GetControls()));
    groupOptionButton6.IconScale = 24f / (float) groupOptionButton6.Icon.Height;
    groupOptionButton6.IconOffset = new Vector2((float) ((28.0 - (double) groupOptionButton6.IconScale * (double) groupOptionButton6.Icon.Width) / 2.0 + 3.0), 3f);
    this.AddButton(this.controlPanel, "Images/UI/Camera_5", (Action) (() => UIWorldGenDebug.Controller.QueuedAbort = true), (Func<string>) (() => "Cancel")).IconOffset = new Vector2(4f, 4f);
    this.controlListArea.Append((UIElement) this.controlPanel);
    float pixels1 = this.controlPanel.Height.Pixels + 2f;
    UIPanel uiPanel2 = new UIPanel();
    uiPanel2.Width = StyleDimension.FromPixelsAndPercent(300f, 0.0f);
    uiPanel2.Height = StyleDimension.FromPixelsAndPercent(-pixels1, 1f);
    uiPanel2.Top = StyleDimension.FromPixels(pixels1);
    uiPanel2.Left = this.controlPanel.Left;
    uiPanel2.HAlign = 0.0f;
    uiPanel2.VAlign = 0.0f;
    this.scrollPanel = uiPanel2;
    this.scrollPanel.PaddingTop = 8f;
    this.scrollPanel.PaddingBottom = 8f;
    this.scrollPanel.PaddingLeft = 4f;
    this.scrollPanel.PaddingRight = 4f;
    this.controlListArea.Append((UIElement) this.scrollPanel);
    UIWrappedSearchBar wrappedSearchBar = new UIWrappedSearchBar((Action) (() => UserInterface.ActiveInstance.SetState((UIState) this)));
    wrappedSearchBar.Left = StyleDimension.FromPixels(-2f);
    wrappedSearchBar.Top = StyleDimension.FromPixels(-2f);
    wrappedSearchBar.Height = StyleDimension.FromPixels(28f);
    wrappedSearchBar.Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f);
    wrappedSearchBar.HAlign = 0.0f;
    this.searchBar = wrappedSearchBar;
    this.searchBar.OnSearchContentsChanged += (Action<string>) (s => this.searchText = s);
    this.searchBar.HideSearchButton();
    this.scrollPanel.Append((UIElement) this.searchBar);
    float pixels2 = 30f;
    UIList uiList = new UIList();
    uiList.Top = StyleDimension.FromPixels(pixels2);
    uiList.Width = StyleDimension.FromPixelsAndPercent(-20f, 1f);
    uiList.Height = StyleDimension.FromPixelsAndPercent(-pixels2, 1f);
    uiList.ListPadding = 0.0f;
    uiList.ManualSortMethod = (Action<List<UIElement>>) (_ => { });
    this.GenPassList = uiList;
    this.scrollPanel.Append((UIElement) this.GenPassList);
    foreach (GenPass pass in UIWorldGenDebug.Controller.Passes)
    {
      UIWorldGenDebug.GenPassElement genPassElement1 = new UIWorldGenDebug.GenPassElement(this, pass);
      genPassElement1.Width = new StyleDimension(-4f, 1f);
      genPassElement1.Height = StyleDimension.FromPixels(32f);
      genPassElement1.PaddingLeft = 7f;
      UIWorldGenDebug.GenPassElement genPassElement2 = genPassElement1;
      this.allPasses.Add(genPassElement2);
      this.GenPassList.Add((UIElement) genPassElement2);
    }
    UIScrollbar uiScrollbar = new UIScrollbar();
    uiScrollbar.Top = StyleDimension.FromPixels(34f);
    uiScrollbar.Height = StyleDimension.FromPixelsAndPercent(-38f, 1f);
    uiScrollbar.Left = StyleDimension.FromPixels(-1f);
    uiScrollbar.HAlign = 1f;
    this.scrollbar = uiScrollbar;
    this.scrollbar.SetView(100f, 1000f);
    this.GenPassList.SetScrollbar(this.scrollbar);
    this.scrollPanel.Append((UIElement) this.scrollbar);
    this.RefreshControlsPosition();
  }

  private void EnsurePassVisible(int passIndex)
  {
    if (passIndex >= this.allPasses.Count)
      return;
    UIWorldGenDebug.GenPassElement allPass = this.allPasses[passIndex];
    if (this.searchVisible && !string.IsNullOrEmpty(this.searchText) && !this.MatchesSearch(allPass.Pass))
      return;
    float height = this.scrollPanel.GetDimensions().Height;
    if ((double) allPass.Height.Pixels + (double) allPass.Top.Pixels > (double) this.scrollbar.ViewPosition + (double) height - 8.0)
    {
      this.scrollbar.ViewPosition = allPass.Top.Pixels - (height - 8f) + allPass.Height.Pixels;
    }
    else
    {
      if ((double) allPass.Top.Pixels >= (double) this.scrollbar.ViewPosition)
        return;
      this.scrollbar.ViewPosition = allPass.Top.Pixels;
    }
  }

  private void RefreshControlsPosition()
  {
  }

  private string GetControls()
  {
    return "[c/FFF014:Space] to pause/resume\n[c/FFF014:R] to rerun current step\n[c/FFF014:Up]/[c/FFF014:Down] or [c/FFF014:Left]/[c/FFF014:Right] to step back/forward\n[c/FFF014:H] to hide UI\n[c/FFF014:M] to toggle map\n[c/FFF014:C] to hide chat log\n";
  }

  private GroupOptionButton<bool> AddButton(
    UIPanel controlPanel,
    string assetPath,
    Action onClick,
    Func<string> getTitle,
    Func<string> getDescription = null)
  {
    GroupOptionButton<bool> groupOptionButton = new GroupOptionButton<bool>(true, (LocalizedText) null, (LocalizedText) null, Color.White, assetPath);
    groupOptionButton.Width = new StyleDimension(34f, 0.0f);
    groupOptionButton.Height = new StyleDimension(34f, 0.0f);
    groupOptionButton.Left = StyleDimension.FromPixelsAndPercent((float) (36 * controlPanel.Children.Count<UIElement>()), 0.0f);
    groupOptionButton.ShowHighlightWhenSelected = false;
    GroupOptionButton<bool> element = groupOptionButton;
    element.IconScale = 24f / (float) element.Icon.Width;
    element.IconOffset = new Vector2(3f, 3f);
    element.OnLeftClick += (UIElement.MouseEvent) ((evt, e) => onClick());
    element.Append((UIElement) new UIWorldGenDebug.TooltipElement(getTitle, getDescription));
    controlPanel.Append((UIElement) element);
    controlPanel.Width = StyleDimension.FromPixelsAndPercent((float) (36 * controlPanel.Children.Count<UIElement>() - 2) + controlPanel.PaddingLeft + controlPanel.PaddingRight, 0.0f);
    return element;
  }

  private void RangePassClickEvent(
    UIWorldGenDebug.GenPassElement target,
    Action<UIWorldGenDebug.GenPassElement> evt)
  {
    if (this._previousRangePassClickEvent != null && this._previousRangePassClickEvent.Item2.Method == evt.Method && this._previousRangePassClickEvent.Item1 != target && this._previousRangePassClickEvent.Item1.Parent == target.Parent && Main.keyState.PressingShift())
    {
      IEnumerable<UIWorldGenDebug.GenPassElement> genPassElements = ((IEnumerable) target.Parent.Parent).Cast<UIWorldGenDebug.GenPassElement>();
      UIWorldGenDebug.GenPassElement genPassElement1 = this._previousRangePassClickEvent.Item1;
      int num = 0;
      foreach (UIWorldGenDebug.GenPassElement genPassElement2 in genPassElements)
      {
        if (genPassElement2 == genPassElement1 || genPassElement2 == target)
          ++num;
        if (num > 0)
          evt(genPassElement2);
        if (num == 2)
          break;
      }
    }
    else
      evt(target);
    this._previousRangePassClickEvent = new Tuple<UIWorldGenDebug.GenPassElement, Action<UIWorldGenDebug.GenPassElement>>(target, evt);
  }

  private void RangePassClickEventCheckHistory_OnElementClicked(UIElement clicked)
  {
    if (this._previousRangePassClickEvent == null || clicked == this._previousRangePassClickEvent.Item1)
      return;
    this._previousRangePassClickEvent = (Tuple<UIWorldGenDebug.GenPassElement, Action<UIWorldGenDebug.GenPassElement>>) null;
  }

  public override void OnActivate()
  {
    UIWorldGenDebug.Config.Load();
    if (UIWorldGenDebug.Controller.SnapshotFrequency == WorldGenerator.SnapshotFrequency.None)
      UIWorldGenDebug.Controller.SnapshotFrequency = WorldGenerator.SnapshotFrequency.Automatic;
    Main.menuChat = true;
    if (Main.gameMenu)
    {
      PlayerInput.SetZoom_World();
      Main.mapFullscreenPos = new Vector2((float) (Main.maxTilesX / 2), (float) (Main.maxTilesY / 2));
      Main.mapFullscreenScale = (float) Main.screenWidth / (float) Main.maxTilesX;
    }
    else
    {
      Main.mapFullscreenScale = 2.5f;
      Main.mapFullscreenPos = Main.Camera.Center / 16f;
    }
    this.ToggleMap();
    if (Main.gameMenu || DebugOptions.devLightTilesCheat)
      return;
    DebugOptions.devLightTilesCheat = true;
    this.disableLightOnClose = true;
  }

  public override void OnDeactivate() => Main.menuChat = false;

  public override void Update(GameTime gameTime)
  {
    Main.starGame = false;
    Main.LocalPlayer.dead = true;
    if (UIWorldGenDebug.Controller.Paused && this.TestEnumerator != null)
    {
      while (!UIWorldGenDebug.Controller.TryOperateInControlLock((Action) (() => { })))
        Thread.Yield();
      if (!this.TestEnumerator.MoveNext())
        this.TestEnumerator = (IEnumerator<object>) null;
    }
    base.Update(gameTime);
    if (Main.drawingPlayerChat || this.searchBar.IsWritingText)
    {
      this.ignoreEscapeAttempt = 3;
    }
    else
    {
      if (this.ignoreEscapeAttempt-- <= 0 && PlayerInput.Triggers.JustPressed.Inventory)
        UIWorldGenDebug.Controller.QueuedAbort = true;
      if (UIWorldGenDebug.KeyPressed(Keys.Space))
      {
        WorldGenerator.Controller controller = UIWorldGenDebug.Controller;
        controller.Paused = !controller.Paused;
      }
      if (UIWorldGenDebug.KeyPressed(Keys.R) && UIWorldGenDebug.CanSubmitActions && UIWorldGenDebug.Controller.LastCompletedPass != null)
        UIWorldGenDebug.Controller.TryRunToEndOfPass(UIWorldGenDebug.Controller.LastCompletedPass, !Main.keyState.PressingShift());
      if (UIWorldGenDebug.KeyPressed(Keys.Up) || UIWorldGenDebug.KeyPressed(Keys.Left))
        this.StepBack();
      if (UIWorldGenDebug.KeyPressed(Keys.Down) || UIWorldGenDebug.KeyPressed(Keys.Right))
        this.StepForward();
      if (UIWorldGenDebug.KeyPressed(Keys.C))
        this.hideChat = !this.hideChat;
      if (UIWorldGenDebug.KeyPressed(Keys.H))
        this.ToggleUI();
      if (UIWorldGenDebug.KeyPressed(Keys.M))
        this.ToggleMap();
      PlayerInput.SetZoom_World();
      if (this.showMap)
      {
        if (PlayerInput.Triggers.Current.Up && !Main.oldKeyState.IsKeyDown(Keys.Up))
          Main.mapFullscreenPos.Y -= (float) (1.0 * (16.0 / (double) Main.mapFullscreenScale));
        if (PlayerInput.Triggers.Current.Down && !Main.oldKeyState.IsKeyDown(Keys.Down))
          Main.mapFullscreenPos.Y += (float) (1.0 * (16.0 / (double) Main.mapFullscreenScale));
        if (PlayerInput.Triggers.Current.Left && !Main.oldKeyState.IsKeyDown(Keys.Left))
          Main.mapFullscreenPos.X -= (float) (1.0 * (16.0 / (double) Main.mapFullscreenScale));
        if (PlayerInput.Triggers.Current.Right && !Main.oldKeyState.IsKeyDown(Keys.Right))
          Main.mapFullscreenPos.X += (float) (1.0 * (16.0 / (double) Main.mapFullscreenScale));
        if (!UserInterface.ActiveInstance.IsElementUnderMouse())
          Main.mapFullscreenScale *= (float) (1.0 + (double) (PlayerInput.ScrollWheelDelta / 120) * 0.30000001192092896);
        Main.screenPosition = Main.mapFullscreenPos * 16f - Main.Camera.UnscaledSize / 2f;
      }
      else if (!Main.gameMenu)
        Main.DebugCameraPan(PlayerInput.Triggers.Current.Left, PlayerInput.Triggers.Current.Right, PlayerInput.Triggers.Current.Up, PlayerInput.Triggers.Current.Down);
      if (!Main.gameMenu)
      {
        Main.ClampScreenPositionToWorld();
        Player localPlayer = Main.LocalPlayer;
        localPlayer.position = localPlayer.position + (Main.screenPosition - Main.PlayerFocusedScreenPosition());
        Main.mapFullscreenPos = Main.Camera.Center / 16f;
      }
      PlayerInput.SetZoom_UI();
    }
  }

  private void ToggleUI()
  {
    this.hideUI = !this.hideUI;
    foreach (UIElement element in this.Elements)
      element.IgnoresMouseInteraction = this.hideUI;
  }

  public void UnhideChat() => this.hideChat = false;

  private void StepBack()
  {
    if (UIWorldGenDebug.CurrentTargetOrLatestPass == null)
      return;
    UIWorldGenDebug.Controller.TryResetToPreviousPass(UIWorldGenDebug.CurrentTargetOrLatestPass);
  }

  private void StepForward()
  {
    GenPass pass = UIWorldGenDebug.Controller.Passes.Skip<GenPass>(UIWorldGenDebug.Controller.Passes.IndexOf(UIWorldGenDebug.CurrentTargetOrLatestPass) + 1).FirstOrDefault<GenPass>((Func<GenPass, bool>) (p => p.Enabled));
    if (pass == null)
      return;
    UIWorldGenDebug.Controller.TryRunToEndOfPass(pass);
  }

  private void CycleSnapshotMode()
  {
    UIWorldGenDebug.Controller.SnapshotFrequency = (WorldGenerator.SnapshotFrequency) ((int) (UIWorldGenDebug.Controller.SnapshotFrequency + 1) % 3);
  }

  private string GetSnapshotModeButtonTitle()
  {
    switch (WorldGenerator.CurrentController.SnapshotFrequency)
    {
      case WorldGenerator.SnapshotFrequency.Manual:
        return "Create snaphots: Manually";
      case WorldGenerator.SnapshotFrequency.Automatic:
        return "Create snaphots: Automatically";
      case WorldGenerator.SnapshotFrequency.Always:
        return "Create snaphots: After every pass";
      default:
        return "";
    }
  }

  private static bool KeyPressed(Keys key)
  {
    return Main.keyState.IsKeyDown(key) && !Main.oldKeyState.IsKeyDown(key);
  }

  private bool MatchesSearch(GenPass pass)
  {
    return string.IsNullOrWhiteSpace(this.searchText) || pass.Name.ToLowerInvariant().Contains(this.searchText.Trim().ToLowerInvariant());
  }

  private void UpdateFilter()
  {
    if (this.searchVisible && !string.IsNullOrEmpty(this.searchText))
    {
      if (!(this.lastSearchText != this.searchText))
        return;
      this.GenPassList.Clear();
      this.lastSearchText = this.searchText;
      foreach (UIWorldGenDebug.GenPassElement allPass in this.allPasses)
      {
        if (this.MatchesSearch(allPass.Pass))
          this.GenPassList.Add((UIElement) allPass);
      }
    }
    else
    {
      if (this.allPasses.Count == this.GenPassList.Count)
        return;
      this.lastSearchText = (string) null;
      this.GenPassList.Clear();
      foreach (UIElement allPass in this.allPasses)
        this.GenPassList.Add(allPass);
    }
  }

  public override void Recalculate()
  {
    if (Main.gameMenu)
    {
      Main.UIScale = Main.UIScaleWanted;
      PlayerInput.SetZoom_UI();
    }
    base.Recalculate();
  }

  protected override void DrawChildren(SpriteBatch spriteBatch)
  {
    if (this.hideUI)
      return;
    base.DrawChildren(spriteBatch);
  }

  protected override void DrawSelf(SpriteBatch spriteBatch)
  {
    Main.starGame = false;
    Main.onlyDrawFancyUI = this.showMap;
    if (this.showMap)
    {
      Main.alreadyGrabbingSunOrMoon = false;
      this.UpdateAndDrawMap();
      Main.instance.DrawFPS();
    }
    if (this.hideChat && !Main.drawingPlayerChat)
      return;
    spriteBatch.End();
    spriteBatch.Begin(SpriteSortMode.Deferred, (BlendState) null, (SamplerState) null, (DepthStencilState) null, (RasterizerState) null, (Effect) null, Matrix.CreateTranslation(250f, 0.0f, 0.0f) * Main.UIScaleMatrix);
    Main.instance.DrawPlayerChat();
    spriteBatch.End();
    spriteBatch.Begin(SpriteSortMode.Deferred, (BlendState) null, (SamplerState) null, (DepthStencilState) null, (RasterizerState) null, (Effect) null, Main.UIScaleMatrix);
  }

  public override void Draw(SpriteBatch spriteBatch)
  {
    this.UpdateFilter();
    if (Main.gameMenu)
    {
      Main.UIScale = Main.UIScaleWanted;
      PlayerInput.SetZoom_UI();
      Main.spriteBatch.End();
      Main.spriteBatch.Begin(SpriteSortMode.Deferred, (BlendState) null, (SamplerState) null, (DepthStencilState) null, (RasterizerState) null, (Effect) null, Main.UIScaleMatrix);
    }
    base.Draw(spriteBatch);
    if (this.showMap)
      return;
    Main.DrawInterface_37_DebugStuff();
  }

  private void ToggleMap()
  {
    this.showMap = !this.showMap;
    Main.onlyDrawFancyUI = this.showMap;
    if (!this.showMap)
      return;
    this.nextMapSection = Point.Zero;
    this.fullMapScanTimer = Stopwatch.StartNew();
  }

  private void UpdateAndDrawMap()
  {
    Main.spriteBatch.End();
    if (Main.clearMap)
    {
      Main.Map.Clear();
      MapRenderer.DrawToMap(new Microsoft.Xna.Framework.Rectangle());
    }
    PlayerInput.SetZoom_Unscaled();
    Microsoft.Xna.Framework.Rectangle tileRectangle = Utils.CenteredRectangle(Main.mapFullscreenPos.ToPoint(), (Main.ScreenSize.ToVector2() / Main.mapFullscreenScale).ToPoint());
    tileRectangle.Inflate(2, 2);
    tileRectangle = WorldUtils.ClampToWorld(tileRectangle, 40);
    Stopwatch stopwatch = Stopwatch.StartNew();
    Point nextMapSection = this.nextMapSection;
    while (stopwatch.ElapsedMilliseconds < 10L)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      UIWorldGenDebug.\u003C\u003Ec__DisplayClass68_0 cDisplayClass680 = new UIWorldGenDebug.\u003C\u003Ec__DisplayClass68_0()
      {
        sectionStripRect = new Microsoft.Xna.Framework.Rectangle(this.nextMapSection.X * 200, 0, 200, Main.maxTilesY)
      };
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      cDisplayClass680.sectionStripRect = Microsoft.Xna.Framework.Rectangle.Intersect(cDisplayClass680.sectionStripRect, tileRectangle);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass680.mapUpdate = false;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      FastParallel.For(cDisplayClass680.sectionStripRect.Left, cDisplayClass680.sectionStripRect.Right, new ParallelForAction((object) cDisplayClass680, __methodptr(\u003CUpdateAndDrawMap\u003Eb__0)), (object) null);
      // ISSUE: reference to a compiler-generated field
      for (this.nextMapSection.Y = 0; this.nextMapSection.Y < Main.maxSectionsY & cDisplayClass680.mapUpdate; ++this.nextMapSection.Y)
      {
        if (new Microsoft.Xna.Framework.Rectangle(this.nextMapSection.X * 200, this.nextMapSection.Y * 150, 200, 150).Intersects(tileRectangle))
          MapRenderer.DrawToMap_Section(this.nextMapSection.X, this.nextMapSection.Y);
      }
      ++this.nextMapSection.X;
      if (this.nextMapSection.X >= Main.maxSectionsX)
      {
        if (this.lastScanRateUpdate.Elapsed > TimeSpan.FromMilliseconds(200.0))
        {
          this.lastScanRateUpdate.Restart();
          this.fullMapScanPeriod = this.fullMapScanTimer.Elapsed;
        }
        this.fullMapScanTimer.Restart();
        this.nextMapSection.X = 0;
      }
      if (this.nextMapSection.X == nextMapSection.X)
        break;
    }
    Main.instance.GraphicsDevice.Clear(new Color(100, 100, (int) byte.MaxValue));
    Main.spriteBatch.Begin();
    Main.mapReady = true;
    Main.MapPylonTile = new Point16(-1, -1);
    Main.mapFullscreen = true;
    bool flag = UserInterface.ActiveInstance.MouseCaptured() || UserInterface.ActiveInstance.IsElementUnderMouse();
    bool t2_1 = Main.mouseLeft && !flag;
    bool t2_2 = Main.mouseRight && !flag;
    Utils.Swap<bool>(ref Main.mouseLeft, ref t2_1);
    Utils.Swap<bool>(ref Main.mouseRight, ref t2_2);
    Main.instance.DrawMap(new GameTime());
    Utils.Swap<bool>(ref Main.mouseLeft, ref t2_1);
    Utils.Swap<bool>(ref Main.mouseRight, ref t2_2);
    Main.mapFullscreen = false;
    PlayerInput.SetZoom_UI();
    Main.spriteBatch.End();
    Main.spriteBatch.Begin(SpriteSortMode.Deferred, (BlendState) null, (SamplerState) null, (DepthStencilState) null, (RasterizerState) null, (Effect) null, Main.UIScaleMatrix);
    if (!Main.showFrameRate)
      return;
    double num = Math.Min(1.0 / this.fullMapScanPeriod.TotalSeconds, 60.0);
    string str = string.Format(num >= 10.0 ? "{0:0}" : "{0:0.0}", (object) num) + " map scans/s";
    DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, FontAssets.MouseText.Value, str, new Vector2((float) (Main.screenWidth - (int) FontAssets.MouseText.Value.MeasureString(str).X), 4f), new Color((int) Main.mouseTextColor, (int) Main.mouseTextColor, (int) Main.mouseTextColor, (int) Main.mouseTextColor));
  }

  public void RunTest(IEnumerable<object> test) => this.TestEnumerator = test.GetEnumerator();

  private static IEnumerable<bool> TestSetupResetAndCreateSnapshots()
  {
    UIWorldGenDebug.Controller.TryReset();
    UIWorldGenDebug.Controller.SnapshotFrequency = WorldGenerator.SnapshotFrequency.Always;
    UIWorldGenDebug.Controller.PauseOnHashMismatch = true;
    Main.NewText("Creating Snapshots", G: (byte) 100, B: (byte) 0);
    GenPass lastPass = UIWorldGenDebug.Controller.Passes.Last<GenPass>();
    UIWorldGenDebug.Controller.TryRunToEndOfPass(lastPass, false);
    yield return true;
    if (UIWorldGenDebug.Controller.LastCompletedPass != lastPass || UIWorldGenDebug.Controller.PausedDueToHashMismatch)
    {
      Main.NewText("Test aborted", G: (byte) 0, B: (byte) 0);
      yield return false;
    }
    UIWorldGenDebug.Controller.SnapshotFrequency = WorldGenerator.SnapshotFrequency.Manual;
  }

  public static IEnumerable<object> TestResetFromPassesAndRegen()
  {
    foreach (bool snapshot in UIWorldGenDebug.TestSetupResetAndCreateSnapshots())
    {
      if (snapshot)
        yield return (object) null;
      else
        yield break;
    }
    GenPass lastPass = UIWorldGenDebug.Controller.Passes.Last<GenPass>();
    List<GenPass> passes = UIWorldGenDebug.Controller.Passes.Where<GenPass>((Func<GenPass, bool>) (p => p.Enabled)).ToList<GenPass>();
    for (int i = 0; i < passes.Count; ++i)
    {
      GenPass pass = passes[i];
      UIWorldGenDebug.Controller.TryReset();
      Main.NewText($"[{i + 1}/{passes.Count}] Running to {pass.Name}", G: (byte) 100, B: (byte) 0);
      UIWorldGenDebug.Controller.TryRunToEndOfPass(pass, false);
      yield return (object) null;
      if (UIWorldGenDebug.Controller.LastCompletedPass != pass || UIWorldGenDebug.Controller.PausedDueToHashMismatch)
      {
        Main.NewText("Test aborted", G: (byte) 0, B: (byte) 0);
        yield break;
      }
      UIWorldGenDebug.Controller.TryReset();
      UIWorldGenDebug.Controller.TryRunToEndOfPass(lastPass, false);
      yield return (object) null;
      if (UIWorldGenDebug.Controller.LastCompletedPass != lastPass || UIWorldGenDebug.Controller.PausedDueToHashMismatch)
      {
        Main.NewText("Test aborted", G: (byte) 0, B: (byte) 0);
        yield break;
      }
      pass = (GenPass) null;
    }
    Main.NewText("Test Completed Successfully", (byte) 0, B: (byte) 0);
  }

  public static IEnumerable<object> TestHiddenTileData()
  {
    foreach (bool snapshot in UIWorldGenDebug.TestSetupResetAndCreateSnapshots())
    {
      if (snapshot)
        yield return (object) null;
      else
        yield break;
    }
    UIWorldGenDebug.Controller.TryReset();
    foreach (GenPass genPass in UIWorldGenDebug.Controller.Passes.Where<GenPass>((Func<GenPass, bool>) (p => p.Enabled)))
    {
      GenPass pass = genPass;
      TileSnapshot.Create();
      TileSnapshot.Restore();
      UIWorldGenDebug.Controller.TryRunToEndOfPass(pass, false);
      yield return (object) null;
      if (UIWorldGenDebug.Controller.LastCompletedPass != pass || UIWorldGenDebug.Controller.PausedDueToHashMismatch)
      {
        Main.NewText("Test aborted", G: (byte) 0, B: (byte) 0);
        yield break;
      }
      pass = (GenPass) null;
    }
    Main.NewText("Test Completed Successfully", (byte) 0, B: (byte) 0);
  }

  public static IEnumerable<object> TestResumeFromSnapshots()
  {
    foreach (bool snapshot in UIWorldGenDebug.TestSetupResetAndCreateSnapshots())
    {
      if (snapshot)
        yield return (object) null;
      else
        yield break;
    }
    GenPass lastPass = UIWorldGenDebug.Controller.Passes.Last<GenPass>();
    foreach (GenPass genPass in UIWorldGenDebug.Controller.Passes.Where<GenPass>((Func<GenPass, bool>) (p => p.Enabled)).Reverse<GenPass>())
    {
      GenPass pass = genPass;
      UIWorldGenDebug.Controller.TryRunToEndOfPass(pass);
      yield return (object) null;
      if (UIWorldGenDebug.Controller.LastCompletedPass != pass || UIWorldGenDebug.Controller.PausedDueToHashMismatch)
      {
        Main.NewText("Test aborted", G: (byte) 0, B: (byte) 0);
        yield break;
      }
      pass = (GenPass) null;
    }
    Main.NewText("Single pass rerun test completed successfully", (byte) 0, B: (byte) 0);
    foreach (GenPass pass in UIWorldGenDebug.Controller.Passes.Where<GenPass>((Func<GenPass, bool>) (p => p.Enabled)))
    {
      UIWorldGenDebug.Controller.TryResetToSnapshot(pass);
      UIWorldGenDebug.Controller.TryRunToEndOfPass(lastPass, false);
      yield return (object) null;
      if (UIWorldGenDebug.Controller.LastCompletedPass != lastPass || UIWorldGenDebug.Controller.PausedDueToHashMismatch)
      {
        Main.NewText("Test aborted", G: (byte) 0, B: (byte) 0);
        yield break;
      }
    }
    Main.NewText("Load snapshot and run to end test completed successfully", (byte) 0, B: (byte) 0);
    foreach (GenPass pass in UIWorldGenDebug.Controller.Passes.Where<GenPass>((Func<GenPass, bool>) (p => p.Enabled)))
    {
      UIWorldGenDebug.Controller.TryReset();
      UIWorldGenDebug.Controller.TryResetToSnapshot(pass);
      UIWorldGenDebug.Controller.TryRunToEndOfPass(lastPass, false);
      yield return (object) null;
      if (UIWorldGenDebug.Controller.LastCompletedPass != lastPass || UIWorldGenDebug.Controller.PausedDueToHashMismatch)
      {
        Main.NewText("Test aborted", G: (byte) 0, B: (byte) 0);
        yield break;
      }
    }
    Main.NewText("Clean load snapshot and run to end test completed successfully", (byte) 0, B: (byte) 0);
  }

  private class TooltipElement : UIElement
  {
    private Func<string> _getTitle;
    private Func<string> _getDescription;

    public TooltipElement(Func<string> getTitle, Func<string> getDescription = null)
    {
      this._getTitle = getTitle;
      this._getDescription = getDescription;
      this.IgnoresMouseInteraction = true;
    }

    protected override void DrawSelf(SpriteBatch spriteBatch)
    {
      if (!this.Parent.IsMouseHovering)
        return;
      string name = this._getTitle();
      string str = (this._getDescription == null ? (string) null : this._getDescription()) ?? string.Empty;
      Item fakeItem = Main.DisplayAndGetFakeItem(ItemRarityColor.StrongRed10);
      fakeItem.SetNameOverride(name);
      fakeItem.ToolTip = ItemTooltip.FromHardcodedText(str);
    }
  }

  private class Config
  {
    private static readonly string FilePath = Path.Combine(Main.SavePath, "dev-worldgen.json");
    public static UIWorldGenDebug.Config Instance = new UIWorldGenDebug.Config();
    public HashSet<string> HighlightedPassNames = new HashSet<string>();

    public static void Save()
    {
      File.WriteAllText(UIWorldGenDebug.Config.FilePath, JsonConvert.SerializeObject((object) UIWorldGenDebug.Config.Instance));
    }

    public static void Load()
    {
      try
      {
        if (!File.Exists(UIWorldGenDebug.Config.FilePath))
          return;
        UIWorldGenDebug.Config.Instance = JsonConvert.DeserializeObject<UIWorldGenDebug.Config>(File.ReadAllText(UIWorldGenDebug.Config.FilePath));
      }
      catch (Exception ex)
      {
      }
    }
  }

  private class UIImageButtonWithExtraIcon(Asset<Texture2D> texture, Microsoft.Xna.Framework.Rectangle? frame = null) : 
    UIImageButton(texture, frame)
  {
    private Microsoft.Xna.Framework.Rectangle? _iconFrame;
    private Asset<Texture2D> _iconTexture;
    public Color IconColor = Color.White;

    protected override void DrawSelf(SpriteBatch spriteBatch)
    {
      base.DrawSelf(spriteBatch);
      if (this._iconTexture == null)
        return;
      Microsoft.Xna.Framework.Rectangle rectangle = this.GetDimensions().ToRectangle();
      rectangle.Inflate(-2, -2);
      int width;
      int height;
      if (this._iconFrame.HasValue)
      {
        width = this._iconFrame.Value.Width;
        height = this._iconFrame.Value.Height;
      }
      else
      {
        width = this._iconTexture.Value.Width;
        height = this._iconTexture.Value.Height;
      }
      if (width != height)
      {
        if (width < height)
        {
          float num1 = (float) width / (float) height;
          int num2 = rectangle.Width - (int) ((double) rectangle.Width * (double) num1);
          rectangle.Width -= num2;
          rectangle.X += num2 / 2;
        }
        else
        {
          float num3 = (float) height / (float) width;
          int num4 = rectangle.Height - (int) ((double) rectangle.Height * (double) num3);
          rectangle.Height -= num4;
          rectangle.Y += num4 / 2;
        }
      }
      spriteBatch.Draw(this._iconTexture.Value, rectangle, this._iconFrame, this.IconColor * (this.IsMouseHovering ? this._visibilityActive : this._visibilityInactive));
    }

    public void SetIcon(string iconTexturePath)
    {
      if (iconTexturePath != null)
        this._iconTexture = Main.Assets.Request<Texture2D>(iconTexturePath, (AssetRequestMode) 1);
      else
        this._iconTexture = (Asset<Texture2D>) null;
    }

    public void SetIconFrame(Microsoft.Xna.Framework.Rectangle region)
    {
      this._iconFrame = new Microsoft.Xna.Framework.Rectangle?(region);
    }

    public Texture2D Icon => this._iconTexture == null ? (Texture2D) null : this._iconTexture.Value;
  }

  private class GenPassElement : UIPanel
  {
    public readonly GenPass Pass;
    private bool Hovered;
    private static Dictionary<string, UIWorldGenDebug.GenPassElement.PassIconEntry> passIcons = new Dictionary<string, UIWorldGenDebug.GenPassElement.PassIconEntry>();

    private UIWorldGenDebug.UIImageButtonWithExtraIcon AddButton(
      string assetPath,
      string iconAsset,
      float x,
      float y,
      Action onClick,
      Func<string> getTitle,
      Func<string> getDescription = null)
    {
      UIWorldGenDebug.UIImageButtonWithExtraIcon buttonWithExtraIcon = new UIWorldGenDebug.UIImageButtonWithExtraIcon(Main.Assets.Request<Texture2D>(assetPath, (AssetRequestMode) 1));
      buttonWithExtraIcon.Left = StyleDimension.FromPixelsAndPercent(x, 0.0f);
      buttonWithExtraIcon.Top = StyleDimension.FromPixelsAndPercent(y, 0.0f);
      UIWorldGenDebug.UIImageButtonWithExtraIcon element = buttonWithExtraIcon;
      if (!string.IsNullOrEmpty(iconAsset))
        element.SetIcon(iconAsset);
      element.OnLeftClick += (UIElement.MouseEvent) ((evt, e) => onClick());
      if (getTitle != null)
        element.Append((UIElement) new UIWorldGenDebug.TooltipElement(getTitle, getDescription));
      this.Append((UIElement) element);
      return element;
    }

    protected override void DrawSelf(SpriteBatch spriteBatch)
    {
      this.RefreshColors();
      base.DrawSelf(spriteBatch);
    }

    private static void InitPassIcons()
    {
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Terrain, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(1));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Skyblock, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(26));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.DunesAndPyramidLocations, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(4));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.OceanSand, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(28));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.SandPatches, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(169));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Tunnels, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4501));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.MountainCaves, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4510));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.DirtWallBackgrounds, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(30));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.RocksInDirt, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(3));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.DirtInRocks, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(2));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Clay, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(133));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.SmallHoles, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4538));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.DirtLayerCaves, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4510));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.RockLayerCaves, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4512));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.SurfaceCaves, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4501));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.WavyCaves, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4537));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.IceBiome, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(6));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Grass, UIWorldGenDebug.GenPassElement.PassIconEntry.FromImageFrame("Images/Tiles_3", 5, 45, 1));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Jungle, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(22));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.MudCavesToJungleGrass, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(745));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.DesertBiome, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(3));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.GlowingMushroomPatches, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(24));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Marble, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(29));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Granite, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(30));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.FloatingIslands, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(26));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.DirtToMud, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(176 /*0xB0*/));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Silt, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(424));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.OresAndShinies, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(19));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Webs, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(150));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Underworld, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(33));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.CorruptionAndCrimson, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(7));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Lakes, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(28));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.StoneToIceAndSiltPlusMudIntoSlush, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(1103));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.DualDungeonsDitherSnake, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(32 /*0x20*/));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Dungeon, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(32 /*0x20*/));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.MountainCaveOpenings, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(2));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.BeachesAndOceanCleanup, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(27));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Gems, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(178));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.GravitatingSandCleanup, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(169));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.OceanCaves, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(28));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Shimmer, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(5340));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.DirtWallCleanup, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(2));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Pyramids, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(607));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.DirtRockWallRunner, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4501));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.LivingTrees, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(0));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.LivingTreeWalls, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(1723));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.DemonAndCrimsonAltars, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(5467));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.SurfaceWaterInJungle, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(22));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.LihzahrdTemple, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(31 /*0x1F*/));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Beehives, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(1126));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.JungleShrines, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(680));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.SettleLiquids, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(28));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.RemoveSurfaceWaterAboveSand, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(169));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Oasis, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(27));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.ShellPilesMarblePilesAndSpikePits, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4090));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.SmoothWorld, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(1));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Waterfalls, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(2169));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.FragileIceOverIceBiomeWater, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(664));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.CaveWallVariety, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4540));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.LifeCrystals, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(29));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Statues, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(52));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.UndergroundHousesAndBuriedChests, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(306));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.SurfaceChests, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(48 /*0x30*/));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.ChestsInJungleShrines, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(680));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.UnderwaterChests, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(1298));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.SpiderCaves, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(34));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.GemCaves, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4644));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.MossAndMossCaves, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4496));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.LihzahrdTemplePart2, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(31 /*0x1F*/));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.CaveWallsInEnclosedSpaces, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4510));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.UndergroundJungleTrees, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(23));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.FloatingIslandHouses, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(26));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.QuickCleanup, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(41));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.PotsGraveyardsAndBoulderPiles, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(222));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Hellforges, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(221));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.SpreadingGrassOnSurfaceSunflowersEvilsOnSurfaceAndLavaCleanup, UIWorldGenDebug.GenPassElement.PassIconEntry.FromImageFrame("Images/Tiles_3", 5, 45, 1));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.SurfaceOreAndStone, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(19));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.FallenLogsAndWaterFeatures, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(0));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Traps, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(580));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Piles, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(1));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.SpawnPoint, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(224 /*0xE0*/));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.SurfaceDirtWallsToGrassWalls, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(745));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.SpawnStarterNPCs, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(867));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.SunflowersPart2, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(63 /*0x3F*/));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Trees, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(0));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.AlchemyHerbs, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(3093));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.DyePlants, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(1109));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.WebsInSpiderCavesAndHoneyPlusSpeleothemsInBeehives, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(150));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.GrassPlantsEvilPlantsAndPumpkinsOnSurface, UIWorldGenDebug.GenPassElement.PassIconEntry.FromImageFrame("Images/Tiles_3", 5, 45, 1));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.GlowingMushroomPlantsUndergroundAndJunglePlants, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(25));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.JunglePlantsPart2, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(23));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Vines, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(3005));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Flowers, UIWorldGenDebug.GenPassElement.PassIconEntry.FromImageFrame("Images/Tiles_3", 33, 45, 1));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.Mushrooms, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(5));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.ExposedGemsInIceBiome, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(182));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.ExposedGemsUnderground, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4400));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.LongMoss, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4496));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.DirtWallsIntoMudWallsInJungleAndJungleMinMax, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4487));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.BeeLarvaInBeehives, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(2108));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.SettleLiquidsPart2AndNotTheBees, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(28));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.CactusPalmTreesAndCoral, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(3));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.TileCleanup, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(41));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.LihzahrdAltar, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(31 /*0x1F*/));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.MicroBiomes, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(0));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.LilypadsCattailsBambooAndSeaweed, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(4564));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.SpeleothemsAndGemTrees, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(6));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.BrokenTrapCleanup, UIWorldGenDebug.GenPassElement.PassIconEntry.FromItem(580));
      UIWorldGenDebug.GenPassElement.passIcons.Add(GenPassNameID.FinalCleanup, UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(41));
    }

    private UIWorldGenDebug.GenPassElement.PassIconEntry GetPassIcon(GenPass pass)
    {
      if (UIWorldGenDebug.GenPassElement.passIcons.Count == 0)
        UIWorldGenDebug.GenPassElement.InitPassIcons();
      UIWorldGenDebug.GenPassElement.PassIconEntry passIcon;
      if (!UIWorldGenDebug.GenPassElement.passIcons.TryGetValue(pass.Name, out passIcon))
        passIcon = UIWorldGenDebug.GenPassElement.PassIconEntry.FromBestiaryIcon(64 /*0x40*/);
      return passIcon;
    }

    private UIImage AddIcon()
    {
      UIWorldGenDebug.GenPassElement.PassIconEntry passIcon = this.GetPassIcon(this.Pass);
      UIImage uiImage = new UIImage(Main.Assets.Request<Texture2D>(passIcon.Icon, (AssetRequestMode) 1));
      uiImage.Width = new StyleDimension((float) passIcon.Width, 0.0f);
      uiImage.Height = new StyleDimension((float) passIcon.Height, 0.0f);
      uiImage.Top = new StyleDimension((float) ((26 - passIcon.Height) / 2), 0.0f);
      uiImage.Left = new StyleDimension((float) ((26 - passIcon.Width) / 2), 0.0f);
      uiImage.Frame = new Microsoft.Xna.Framework.Rectangle?(passIcon.Region);
      uiImage.ScaleToFit = true;
      return uiImage;
    }

    public GenPassElement(UIWorldGenDebug parent, GenPass pass)
    {
      UIWorldGenDebug.GenPassElement target = this;
      this.Pass = pass;
      this.SetPadding(2f);
      this.Height.Set(96f, 0.0f);
      this.Append((UIElement) new UIWorldGenDebug.TooltipElement(new Func<string>(this.GetTitle), new Func<string>(this.GetDescription)));
      UIImage element = this.AddIcon();
      element.IgnoresMouseInteraction = true;
      this.Append((UIElement) element);
      UIText uiText1 = new UIText(this.Index.ToString(), 0.5f);
      uiText1.Left = StyleDimension.FromPixels(2f);
      uiText1.Top = StyleDimension.FromPixels(2f);
      uiText1.IgnoresMouseInteraction = true;
      UIText indexText = uiText1;
      this.Append((UIElement) indexText);
      UIText uiText2 = new UIText(pass.Name);
      uiText2.Left = StyleDimension.FromPixels(32f);
      uiText2.Top = StyleDimension.FromPixels(4f);
      uiText2.IgnoresMouseInteraction = true;
      UIText text = uiText2;
      text.OnUpdate += (UIElement.ElementEvent) (e =>
      {
        text.TextColor = closure_0.IsRunning ? Color.Yellow : (closure_0.Skipped ? Color.DarkGray : (closure_0.HasCompleted ? new Color(0, 230, 0) : (!pass.Enabled ? Color.DarkGray : Color.White)));
        text.TextColor *= parent.MatchesSearch(pass) ? 1f : 0.6f;
        indexText.TextColor = text.TextColor;
      });
      this.Append((UIElement) text);
      this.SetColorsToNotHovered();
      UIWorldGenDebug.UIImageButtonWithExtraIcon snapshotIcon = this.AddButton("Images/UI/ButtonBacking", "Images/UI/Camera_4", 72f, 3f, (Action) (() =>
      {
        if (Main.keyState.PressingAlt())
          return;
        if (target.Snapshot == null)
        {
          UIWorldGenDebug.Controller.TryCreateSnapshot();
        }
        else
        {
          if (target.Snapshot.Outdated)
            return;
          UIWorldGenDebug.Controller.TryResetToSnapshot(pass);
        }
      }), new Func<string>(this.GetSnapshotButtonTitle), new Func<string>(this.GetSnapshotButtonDescription));
      snapshotIcon.OnUpdate += (UIElement.ElementEvent) (e =>
      {
        if (closure_0.Snapshot != null)
          snapshotIcon.SetIcon("Images/UI/Camera_4");
        else if (UIWorldGenDebug.Controller.LastCompletedPass == closure_0.Pass)
          snapshotIcon.SetIcon("Images/UI/Camera_7");
        UIWorldGenDebug.SetButtonState(snapshotIcon, !closure_0.Pass.Enabled || closure_0.Snapshot == null && UIWorldGenDebug.Controller.LastCompletedPass != closure_0.Pass ? UIWorldGenDebug.ButtonState.NotVisible : UIWorldGenDebug.ButtonState.Enabled);
        if (closure_0.Snapshot != null && closure_0.Snapshot.Outdated)
          snapshotIcon.IconColor = Color.PaleVioletRed;
        else
          snapshotIcon.IconColor = Color.White;
      });
      snapshotIcon.OnRightClick += (UIElement.MouseEvent) ((evt, e) =>
      {
        if (target.Snapshot == null)
          return;
        UIWorldGenDebug.Controller.DeleteSnapshot(pass);
        UserInterface.ActiveInstance.ClearPointers();
      });
      snapshotIcon.Left = new StyleDimension(-28f, 1f);
      this.OnLeftClick += (UIElement.MouseEvent) ((evt, e) =>
      {
        if (target != evt.Target)
          return;
        if (Main.keyState.PressingAlt())
        {
          target.ToggleHighlight();
          target.SetColorsToHovered();
        }
        else if (Main.keyState.PressingControl())
        {
          if (pass.Enabled)
            return;
          parent.RangePassClickEvent(target, (Action<UIWorldGenDebug.GenPassElement>) (x =>
          {
            x.Enable();
            x.RefreshColors();
          }));
        }
        else
        {
          if (!pass.Enabled)
            return;
          UIWorldGenDebug.Controller.TryRunToEndOfPass(pass, !Main.keyState.PressingShift());
        }
      });
      this.OnRightClick += (UIElement.MouseEvent) ((evt, e) =>
      {
        if (!Main.keyState.PressingControl() || !pass.Enabled)
          return;
        parent.RangePassClickEvent(target, (Action<UIWorldGenDebug.GenPassElement>) (x =>
        {
          x.Disable();
          x.RefreshColors();
        }));
      });
    }

    private void RefreshColors()
    {
      if (this.Hovered)
        this.SetColorsToHovered();
      else
        this.SetColorsToNotHovered();
    }

    private void SetColorsToHovered()
    {
      this.BackgroundColor = new Color(73, 94, 171);
      this.BorderColor = new Color(89, 116, 213);
      if (this.IsHighlighted)
      {
        this.BackgroundColor = new Color(110, 30, 150);
        this.BorderColor = new Color(171, 53, (int) byte.MaxValue);
      }
      if (UIWorldGenDebug.CurrentTargetPass == this.Pass)
        this.BorderColor = new Color((int) byte.MaxValue, 231, 69);
      if (this.Pass.Enabled)
        return;
      this.BorderColor = new Color(150, 150, 150) * 1f;
      this.BackgroundColor = Color.Lerp(this.BackgroundColor, new Color(120, 120, 120), 0.5f) * 1f;
    }

    private void SetColorsToNotHovered()
    {
      this.BackgroundColor = new Color(63 /*0x3F*/, 82, 151) * 0.7f;
      this.BorderColor = new Color(89, 116, 213) * 0.7f;
      if (this.IsHighlighted)
      {
        this.BackgroundColor = new Color(110, 30, 150) * 0.7f;
        this.BorderColor = new Color(171, 53, (int) byte.MaxValue) * 0.7f;
      }
      if (UIWorldGenDebug.CurrentTargetPass == this.Pass)
        this.BorderColor = new Color((int) byte.MaxValue, 231, 69);
      if (this.Pass.Enabled)
        return;
      this.BorderColor = new Color((int) sbyte.MaxValue, (int) sbyte.MaxValue, (int) sbyte.MaxValue) * 0.7f;
      this.BackgroundColor = Color.Lerp(this.BackgroundColor, new Color(80 /*0x50*/, 80 /*0x50*/, 80 /*0x50*/), 0.5f) * 0.7f;
    }

    public override void MouseOver(UIMouseEvent evt)
    {
      this.Hovered = true;
      base.MouseOver(evt);
      this.SetColorsToHovered();
    }

    public override void MouseOut(UIMouseEvent evt)
    {
      this.Hovered = false;
      base.MouseOut(evt);
      this.SetColorsToNotHovered();
    }

    private string GetTitle()
    {
      if (this.Skipped)
        return "Skipped: " + this.Pass.Name;
      return !this.Pass.Enabled ? "Disabled: " + this.Pass.Name : $"{(!this.HasCompleted ? "Run" : "Rerun")} to {this.Pass.Name}";
    }

    private string GetDescription()
    {
      string str = string.Empty;
      if (this.Pass.Enabled)
      {
        str += "Hold shift to ignore snapshots\n";
        if (!UIWorldGenDebug.CanSubmitActions && (this.HasCompleted || Main.keyState.PressingShift()))
          str += "\n[c/FFA500:Must be paused to rerun or load snapshots]\n";
      }
      if (!this.HasCompleted && !this.Skipped)
        str = str + "Crtl Left click to enable\n" + "Crtl Right click to disable\n" + "Crtl & Shift to edit ranges\n";
      return str + "Alt click to toggle highlight\n";
    }

    private string GetSnapshotButtonTitle()
    {
      if (this.Snapshot != null && this.Snapshot.Outdated)
        return "Snapshot is outdated and will only be used for comparison when the pass is run again";
      if (this.Snapshot != null)
        return "Reset to snapshot";
      return UIWorldGenDebug.Controller.LastCompletedPass == this.Pass ? "Take snapshot" : (string) null;
    }

    private string GetSnapshotButtonDescription()
    {
      if (this.Snapshot != null)
      {
        string buttonDescription = "Left click to load snapshot\n" + "Right click to delete snapshot\n";
        if (!UIWorldGenDebug.CanSubmitActions)
          buttonDescription += "\n[c/FFA500:Must be paused to load a snapshot]";
        return buttonDescription;
      }
      return UIWorldGenDebug.Controller.LastCompletedPass == this.Pass ? "Left click to take snapshot\n" : (string) null;
    }

    private void Enable()
    {
      Utils.TryOperateInLock((object) this.Pass, (Action) (() =>
      {
        if (this.HasCompleted)
          return;
        this.Pass.Enable();
        UIWorldGenDebug.Controller.ForceUpdateProgress();
      }));
    }

    private void Disable()
    {
      Utils.TryOperateInLock((object) this.Pass, (Action) (() =>
      {
        if (this.HasCompleted)
          return;
        this.Pass.Disable();
        UIWorldGenDebug.Controller.ForceUpdateProgress();
        UIWorldGenDebug.Controller.DeleteSnapshot(this.Pass);
      }));
    }

    private void ToggleHighlight()
    {
      if (this.IsHighlighted)
        UIWorldGenDebug.Config.Instance.HighlightedPassNames.Remove(this.Pass.Name);
      else
        UIWorldGenDebug.Config.Instance.HighlightedPassNames.Add(this.Pass.Name);
      UIWorldGenDebug.Config.Save();
    }

    public int Index => UIWorldGenDebug.Controller.Passes.IndexOf(this.Pass);

    public bool IsRunning => UIWorldGenDebug.Controller.CurrentPass == this.Pass;

    public bool HasCompleted => WorldGen.Manifest.GenPassResults.Count > this.Index;

    public bool Skipped
    {
      get => this.HasCompleted && WorldGen.Manifest.GenPassResults[this.Index].Skipped;
    }

    public WorldGenSnapshot Snapshot => UIWorldGenDebug.Controller.GetSnapshot(this.Pass);

    public bool IsPausedAfterThisPass
    {
      get
      {
        return UIWorldGenDebug.CanSubmitActions && this.HasCompleted && !this.Skipped && WorldGen.Manifest.GenPassResults.Count == this.Index + 1;
      }
    }

    public bool IsHighlighted
    {
      get => UIWorldGenDebug.Config.Instance.HighlightedPassNames.Contains(this.Pass.Name);
    }

    internal struct PassIconEntry
    {
      internal string Icon;
      internal Microsoft.Xna.Framework.Rectangle Region;
      internal int Width;
      internal int Height;

      internal static UIWorldGenDebug.GenPassElement.PassIconEntry FromBestiaryIcon(int index)
      {
        string str = "Images/UI/Bestiary/Icon_Tags_Shadow";
        Asset<Texture2D> tex = Main.Assets.Request<Texture2D>(str, (AssetRequestMode) 1);
        return new UIWorldGenDebug.GenPassElement.PassIconEntry()
        {
          Icon = str,
          Region = tex.Frame(16 /*0x10*/, 5, index % 16 /*0x10*/, index / 16 /*0x10*/),
          Width = 26,
          Height = 26
        };
      }

      internal static UIWorldGenDebug.GenPassElement.PassIconEntry FromItem(int index)
      {
        string str = "Images/Item_" + index.ToString();
        Asset<Texture2D> asset = Main.Assets.Request<Texture2D>(str, (AssetRequestMode) 1);
        Microsoft.Xna.Framework.Rectangle rectangle = asset.Frame();
        float num = 20f / (rectangle.Width > rectangle.Height ? (float) rectangle.Width : (float) asset.Height());
        if ((double) num > 1.2000000476837158)
          num = 1.2f;
        return new UIWorldGenDebug.GenPassElement.PassIconEntry()
        {
          Icon = str,
          Region = rectangle,
          Width = (int) ((double) rectangle.Width * (double) num),
          Height = (int) ((double) rectangle.Height * (double) num)
        };
      }

      internal static UIWorldGenDebug.GenPassElement.PassIconEntry FromImageFrame(
        string image,
        int index,
        int rowCount,
        int lineCount)
      {
        Asset<Texture2D> asset = Main.Assets.Request<Texture2D>(image, (AssetRequestMode) 1);
        Microsoft.Xna.Framework.Rectangle rectangle = asset.Frame(rowCount, lineCount, index % rowCount, index / rowCount);
        float num = 20f / (rectangle.Width > rectangle.Height ? (float) rectangle.Width : (float) asset.Height());
        if ((double) num > 1.2000000476837158)
          num = 1.2f;
        return new UIWorldGenDebug.GenPassElement.PassIconEntry()
        {
          Icon = image,
          Region = rectangle,
          Width = (int) ((double) rectangle.Width * (double) num),
          Height = (int) ((double) rectangle.Height * (double) num)
        };
      }
    }
  }

  private enum ButtonState
  {
    Enabled,
    NotVisible,
  }
}
