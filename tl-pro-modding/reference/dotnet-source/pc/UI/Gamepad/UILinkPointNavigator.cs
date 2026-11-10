// Decompiled with JetBrains decompiler
// Type: Terraria.UI.Gamepad.UILinkPointNavigator
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using Terraria.Testing;

#nullable disable
namespace Terraria.UI.Gamepad;

public class UILinkPointNavigator
{
  public static Dictionary<int, UILinkPage> Pages = new Dictionary<int, UILinkPage>();
  public static Dictionary<int, UILinkPoint> Points = new Dictionary<int, UILinkPoint>();
  public static int CurrentPage = 1000;
  public static int OldPage = 1000;
  private static int XCooldown;
  private static int YCooldown;
  private static Vector2 LastInput;
  private static int PageLeftCD;
  private static int PageRightCD;
  public static bool InUse;
  public static int OverridePoint = -1;
  private static int? _suggestedPointID;
  private static int? _preSuggestionPoint;
  private static HashSet<UILinkPoint> _visited = new HashSet<UILinkPoint>();
  private static Queue<UILinkPoint> _queue = new Queue<UILinkPoint>();

  public static int CurrentPoint
  {
    get => UILinkPointNavigator.Pages[UILinkPointNavigator.CurrentPage].CurrentPoint;
  }

  public static bool Available
  {
    get
    {
      return Main.playerInventory || Main.ingameOptionsWindow || Main.player[Main.myPlayer].talkNPC != -1 || Main.player[Main.myPlayer].sign != -1 || Main.mapFullscreen || Main.clothesWindow || Main.MenuUI.IsVisible || Main.InGameUI.IsVisible;
    }
  }

  public static void SuggestUsage(int PointID)
  {
    if (!UILinkPointNavigator.Points.ContainsKey(PointID))
      return;
    UILinkPointNavigator._suggestedPointID = new int?(PointID);
  }

  public static void ConsumeSuggestion()
  {
    if (!UILinkPointNavigator._suggestedPointID.HasValue)
      return;
    int key = UILinkPointNavigator._suggestedPointID.Value;
    UILinkPointNavigator.ClearSuggestion();
    UILinkPointNavigator.CurrentPage = UILinkPointNavigator.Points[key].Page;
    UILinkPointNavigator.OverridePoint = key;
    UILinkPointNavigator.ProcessChanges();
    PlayerInput.Triggers.Current.UsedMovementKey = true;
  }

  public static void ClearSuggestion() => UILinkPointNavigator._suggestedPointID = new int?();

  public static void GoToDefaultPage(int specialFlag = 0)
  {
    TileEntity tileEntity = Main.LocalPlayer.tileEntityAnchor.GetTileEntity();
    if (Main.MenuUI.IsVisible)
      UILinkPointNavigator.CurrentPage = 1004;
    else if (Main.InGameUI.IsVisible || specialFlag == 1)
      UILinkPointNavigator.CurrentPage = 1004;
    else if (Main.gameMenu)
      UILinkPointNavigator.CurrentPage = 1000;
    else if (Main.ingameOptionsWindow)
      UILinkPointNavigator.CurrentPage = 1001;
    else if (Main.CreativeMenu.Enabled)
      UILinkPointNavigator.CurrentPage = 1005;
    else if (NewCraftingUI.Visible)
      UILinkPointNavigator.CurrentPage = 24;
    else if (Main.hairWindow)
      UILinkPointNavigator.CurrentPage = 12;
    else if (Main.clothesWindow)
      UILinkPointNavigator.CurrentPage = 15;
    else if (Main.npcShop != 0)
      UILinkPointNavigator.CurrentPage = 13;
    else if (Main.InGuideCraftMenu)
      UILinkPointNavigator.CurrentPage = 0;
    else if (Main.InReforgeMenu)
      UILinkPointNavigator.CurrentPage = 0;
    else if (Main.player[Main.myPlayer].chest != -1)
      UILinkPointNavigator.CurrentPage = 4;
    else if (tileEntity is TEDisplayDoll)
      UILinkPointNavigator.CurrentPage = 20;
    else if (tileEntity is TEHatRack)
      UILinkPointNavigator.CurrentPage = 21;
    else if (Main.player[Main.myPlayer].talkNPC != -1 || Main.player[Main.myPlayer].sign != -1)
      UILinkPointNavigator.CurrentPage = 1003;
    else
      UILinkPointNavigator.CurrentPage = 0;
  }

  public static void Update()
  {
    bool inUse = UILinkPointNavigator.InUse;
    UILinkPointNavigator.InUse = false;
    bool flag1 = true;
    if (flag1)
    {
      switch (PlayerInput.CurrentInputMode)
      {
        case InputMode.Keyboard:
        case InputMode.KeyboardUI:
        case InputMode.Mouse:
          if (!Main.gameMenu)
          {
            flag1 = false;
            break;
          }
          break;
      }
    }
    if (flag1 && PlayerInput.NavigatorRebindingLock > 0)
      flag1 = false;
    if (flag1 && !Main.gameMenu && !PlayerInput.UsingGamepadUI)
      flag1 = false;
    if (flag1 && !Main.gameMenu && PlayerInput.InBuildingMode)
      flag1 = false;
    if (flag1 && !Main.gameMenu && !UILinkPointNavigator.Available)
      flag1 = false;
    if (flag1 && Main.gameMenu && Main.MenuUI.IsVisible && Main.MenuUI.CurrentState != null && Main.MenuUI.CurrentState.NoGamepadSupport)
      flag1 = false;
    bool flag2 = false;
    UILinkPage uiLinkPage;
    if (!UILinkPointNavigator.Pages.TryGetValue(UILinkPointNavigator.CurrentPage, out uiLinkPage))
      flag2 = true;
    else if (!uiLinkPage.IsValid())
      flag2 = true;
    if (flag2)
    {
      UILinkPointNavigator.GoToDefaultPage();
      UILinkPointNavigator.ProcessChanges();
      flag1 = false;
    }
    if (inUse != flag1)
    {
      if (!flag1)
      {
        uiLinkPage.Leave();
        UILinkPointNavigator.GoToDefaultPage();
        UILinkPointNavigator.ProcessChanges();
      }
      else
      {
        UILinkPointNavigator.GoToDefaultPage();
        UILinkPointNavigator.ProcessChanges();
        UILinkPointNavigator.ConsumeSuggestion();
        uiLinkPage.Enter();
      }
      if (flag1)
      {
        if (!PlayerInput.SteamDeckIsUsed || PlayerInput.PreventCursorModeSwappingToGamepad)
          Main.player[Main.myPlayer].releaseInventory = false;
        Main.player[Main.myPlayer].releaseUseTile = false;
        PlayerInput.LockGamepadTileUseButton = true;
      }
      if (!Main.gameMenu)
      {
        if (flag1)
          PlayerInput.NavigatorCachePosition();
        else
          PlayerInput.NavigatorUnCachePosition();
      }
    }
    UILinkPointNavigator.ClearSuggestion();
    if (!flag1)
      return;
    UILinkPointNavigator.InUse = true;
    UILinkPointNavigator.OverridePoint = -1;
    if (UILinkPointNavigator.PageLeftCD > 0)
      --UILinkPointNavigator.PageLeftCD;
    if (UILinkPointNavigator.PageRightCD > 0)
      --UILinkPointNavigator.PageRightCD;
    Vector2 navigatorDirections = PlayerInput.Triggers.Current.GetNavigatorDirections();
    int num1 = !PlayerInput.Triggers.Current.HotbarMinus ? 0 : (!PlayerInput.Triggers.Current.HotbarPlus ? 1 : 0);
    bool flag3 = PlayerInput.Triggers.Current.HotbarPlus && !PlayerInput.Triggers.Current.HotbarMinus;
    if (num1 == 0)
      UILinkPointNavigator.PageLeftCD = 0;
    if (!flag3)
      UILinkPointNavigator.PageRightCD = 0;
    int num2 = num1 == 0 ? 0 : (UILinkPointNavigator.PageLeftCD == 0 ? 1 : 0);
    bool flag4 = flag3 && UILinkPointNavigator.PageRightCD == 0;
    if ((double) UILinkPointNavigator.LastInput.X != (double) navigatorDirections.X)
      UILinkPointNavigator.XCooldown = 0;
    if ((double) UILinkPointNavigator.LastInput.Y != (double) navigatorDirections.Y)
      UILinkPointNavigator.YCooldown = 0;
    if (UILinkPointNavigator.XCooldown > 0)
      --UILinkPointNavigator.XCooldown;
    if (UILinkPointNavigator.YCooldown > 0)
      --UILinkPointNavigator.YCooldown;
    UILinkPointNavigator.LastInput = navigatorDirections;
    if (num2 != 0)
      UILinkPointNavigator.PageLeftCD = 16 /*0x10*/;
    if (flag4)
      UILinkPointNavigator.PageRightCD = 16 /*0x10*/;
    UILinkPointNavigator.Pages[UILinkPointNavigator.CurrentPage].Update();
    int num3 = 10;
    if (!Main.gameMenu && Main.playerInventory && !Main.ingameOptionsWindow && !Main.inFancyUI && (UILinkPointNavigator.CurrentPage == 0 || UILinkPointNavigator.CurrentPage == 4 || UILinkPointNavigator.CurrentPage == 2 || UILinkPointNavigator.CurrentPage == 1 || UILinkPointNavigator.CurrentPage == 20 || UILinkPointNavigator.CurrentPage == 21))
      num3 = PlayerInput.CurrentProfile.InventoryMoveCD;
    if ((double) navigatorDirections.X == -1.0 && UILinkPointNavigator.XCooldown == 0)
    {
      UILinkPointNavigator.XCooldown = num3;
      UILinkPointNavigator.Pages[UILinkPointNavigator.CurrentPage].TravelLeft();
    }
    if ((double) navigatorDirections.X == 1.0 && UILinkPointNavigator.XCooldown == 0)
    {
      UILinkPointNavigator.XCooldown = num3;
      UILinkPointNavigator.Pages[UILinkPointNavigator.CurrentPage].TravelRight();
    }
    if ((double) navigatorDirections.Y == -1.0 && UILinkPointNavigator.YCooldown == 0)
    {
      UILinkPointNavigator.YCooldown = num3;
      UILinkPointNavigator.Pages[UILinkPointNavigator.CurrentPage].TravelUp();
    }
    if ((double) navigatorDirections.Y == 1.0 && UILinkPointNavigator.YCooldown == 0)
    {
      UILinkPointNavigator.YCooldown = num3;
      UILinkPointNavigator.Pages[UILinkPointNavigator.CurrentPage].TravelDown();
    }
    UILinkPointNavigator.XCooldown = UILinkPointNavigator.YCooldown = Math.Max(UILinkPointNavigator.XCooldown, UILinkPointNavigator.YCooldown);
    if (num2 != 0)
      UILinkPointNavigator.Pages[UILinkPointNavigator.CurrentPage].SwapPageLeft();
    if (flag4)
      UILinkPointNavigator.Pages[UILinkPointNavigator.CurrentPage].SwapPageRight();
    if (PlayerInput.Triggers.Current.UsedMovementKey)
    {
      Vector2 position = UILinkPointNavigator.Points[UILinkPointNavigator.CurrentPoint].Position;
      Vector2 vector2_1 = new Vector2((float) PlayerInput.MouseX, (float) PlayerInput.MouseY);
      float num4 = 0.3f;
      if (PlayerInput.InvisibleGamepadInMenus)
        num4 = 1f;
      Vector2 vector2_2 = position;
      double amount = (double) num4;
      Vector2 vector2_3 = Vector2.Lerp(vector2_1, vector2_2, (float) amount);
      if (Main.gameMenu)
      {
        if ((double) Math.Abs(vector2_3.X - position.X) <= 5.0)
          vector2_3.X = position.X;
        if ((double) Math.Abs(vector2_3.Y - position.Y) <= 5.0)
          vector2_3.Y = position.Y;
      }
      PlayerInput.MouseX = (int) vector2_3.X;
      PlayerInput.MouseY = (int) vector2_3.Y;
    }
    UILinkPointNavigator.ResetFlagsEnd();
    if (!DebugOptions.DrawLinkPoints)
      return;
    UILinkPointNavigator.DrawLinks();
  }

  public static void ResetFlagsEnd()
  {
    UILinkPointNavigator.Shortcuts.OPTIONS_BUTTON_SPECIALFEATURE = 0;
    UILinkPointNavigator.Shortcuts.BackButtonLock = false;
    UILinkPointNavigator.Shortcuts.BackButtonCommand = 0;
  }

  public static string GetInstructions()
  {
    UILinkPage page = UILinkPointNavigator.Pages[UILinkPointNavigator.CurrentPage];
    UILinkPoint point = UILinkPointNavigator.Points[UILinkPointNavigator.CurrentPoint];
    if (UILinkPointNavigator._suggestedPointID.HasValue)
    {
      UILinkPointNavigator.SwapToSuggestion();
      point = UILinkPointNavigator.Points[UILinkPointNavigator._suggestedPointID.Value];
      page = UILinkPointNavigator.Pages[point.Page];
      UILinkPointNavigator.CurrentPage = page.ID;
      page.CurrentPoint = UILinkPointNavigator._suggestedPointID.Value;
    }
    string str = page.SpecialInteractions();
    if ((PlayerInput.SettingsForUI.CurrentCursorMode != CursorMode.Gamepad || !PlayerInput.Triggers.Current.UsedMovementKey || !UILinkPointNavigator.InUse ? (UILinkPointNavigator._suggestedPointID.HasValue ? 1 : 0) : 1) != 0)
      str += point.SpecialInteractions();
    string instructions = str + page.SpecialInteractionsLate();
    UILinkPointNavigator.ConsumeSuggestionSwap();
    return instructions;
  }

  public static void SwapToSuggestion()
  {
    UILinkPointNavigator._preSuggestionPoint = new int?(UILinkPointNavigator.CurrentPoint);
  }

  public static void ConsumeSuggestionSwap()
  {
    if (UILinkPointNavigator._preSuggestionPoint.HasValue)
    {
      int key = UILinkPointNavigator._preSuggestionPoint.Value;
      UILinkPointNavigator.CurrentPage = UILinkPointNavigator.Points[key].Page;
      UILinkPointNavigator.Pages[UILinkPointNavigator.CurrentPage].CurrentPoint = key;
    }
    UILinkPointNavigator._preSuggestionPoint = new int?();
  }

  public static void ForceMovementCooldown(int time)
  {
    UILinkPointNavigator.LastInput = PlayerInput.Triggers.Current.GetNavigatorDirections();
    UILinkPointNavigator.XCooldown = time;
    UILinkPointNavigator.YCooldown = time;
  }

  public static void SetPosition(int ID, Vector2 Position)
  {
    UILinkPointNavigator.Points[ID].Position = Position * Main.UIScale;
  }

  public static Vector2 GetPosition(int ID)
  {
    UILinkPoint uiLinkPoint;
    Vector2 vector2 = UILinkPointNavigator.Points.TryGetValue(ID, out uiLinkPoint) ? uiLinkPoint.Position : Vector2.Zero;
    if (vector2 == Vector2.Zero)
    {
      if (ID >= 180 && ID <= 184)
        vector2 = UILinkPointNavigator.GetPosition(ID - 180 + 100);
      else if (ID >= 185 && ID <= 189)
        vector2 = UILinkPointNavigator.GetPosition(ID - 185 + 110);
    }
    return vector2 / Main.UIScale;
  }

  public static void RegisterPage(UILinkPage page, int ID, bool automatedDefault = true)
  {
    if (automatedDefault)
      page.DefaultPoint = page.LinkMap.Keys.First<int>();
    page.CurrentPoint = page.DefaultPoint;
    page.ID = ID;
    UILinkPointNavigator.Pages.Add(page.ID, page);
    foreach (KeyValuePair<int, UILinkPoint> link in page.LinkMap)
    {
      link.Value.SetPage(ID);
      UILinkPointNavigator.Points.Add(link.Key, link.Value);
    }
  }

  public static void ChangePage(int PageID)
  {
    if (!UILinkPointNavigator.Pages.ContainsKey(PageID) || !UILinkPointNavigator.Pages[PageID].CanEnter())
      return;
    SoundEngine.PlaySound(12);
    UILinkPointNavigator.CurrentPage = PageID;
    UILinkPointNavigator.ProcessChanges();
  }

  public static void ChangePoint(int PointID)
  {
    if (!UILinkPointNavigator.Points.ContainsKey(PointID))
      return;
    UILinkPointNavigator.CurrentPage = UILinkPointNavigator.Points[PointID].Page;
    UILinkPointNavigator.OverridePoint = PointID;
    UILinkPointNavigator.ProcessChanges();
  }

  public static void ProcessChanges()
  {
    UILinkPage page = UILinkPointNavigator.Pages[UILinkPointNavigator.OldPage];
    if (UILinkPointNavigator.OldPage != UILinkPointNavigator.CurrentPage)
    {
      page.Leave();
      if (!UILinkPointNavigator.Pages.TryGetValue(UILinkPointNavigator.CurrentPage, out page))
      {
        UILinkPointNavigator.GoToDefaultPage();
        UILinkPointNavigator.ProcessChanges();
        UILinkPointNavigator.OverridePoint = -1;
      }
      page.CurrentPoint = page.DefaultPoint;
      page.Enter();
      page.Update();
      UILinkPointNavigator.OldPage = UILinkPointNavigator.CurrentPage;
    }
    if (UILinkPointNavigator.OverridePoint == -1 || !page.LinkMap.ContainsKey(UILinkPointNavigator.OverridePoint))
      return;
    page.CurrentPoint = UILinkPointNavigator.OverridePoint;
  }

  private static void DrawLinks()
  {
    UILinkPoint uiLinkPoint;
    if (!UILinkPointNavigator.Points.TryGetValue(UILinkPointNavigator.CurrentPoint, out uiLinkPoint))
      return;
    UILinkPointNavigator._visited.Clear();
    UILinkPointNavigator._visited.Add(uiLinkPoint);
    UILinkPointNavigator._queue.Clear();
    UILinkPointNavigator._queue.Enqueue(uiLinkPoint);
    while (UILinkPointNavigator._queue.Any<UILinkPoint>())
    {
      UILinkPoint src = UILinkPointNavigator._queue.Dequeue();
      UILinkPointNavigator.DrawLink(src, src.Up, new Vector2(0.0f, -1f), new Color(120, 0, 20), new Color((int) byte.MaxValue, 0, (int) byte.MaxValue));
      UILinkPointNavigator.DrawLink(src, src.Down, new Vector2(0.0f, 1f), new Color(0, 0, (int) byte.MaxValue), new Color(0, (int) byte.MaxValue, (int) byte.MaxValue));
      UILinkPointNavigator.DrawLink(src, src.Left, new Vector2(-1f, 0.0f), new Color(0, 100, 0), new Color(50, 205, 50));
      UILinkPointNavigator.DrawLink(src, src.Right, new Vector2(1f, 0.0f), new Color(100, 100, 0), new Color((int) byte.MaxValue, 215, 0));
    }
  }

  private static void DrawLink(
    UILinkPoint src,
    int targetId,
    Vector2 dir,
    Color colorStart,
    Color colorEnd)
  {
    UILinkPoint uiLinkPoint;
    if (!UILinkPointNavigator.Points.TryGetValue(targetId, out uiLinkPoint) || uiLinkPoint.Position == Vector2.Zero)
      return;
    if (UILinkPointNavigator._visited.Add(uiLinkPoint))
      UILinkPointNavigator._queue.Enqueue(uiLinkPoint);
    Vector2 vector2_1 = dir.RotatedBy(Math.PI / 2.0);
    Vector2 start = src.Position / Main.UIScale + vector2_1 * 2f;
    Vector2 vector2_2 = uiLinkPoint.Position / Main.UIScale + vector2_1 * 2f;
    if ((double) Vector2.Dot(vector2_2 - start, dir) < 0.0)
    {
      DebugLineDraw.UI.AddLine(start, start += (vector2_1 + dir * 2f) * 2f * 2f, colorStart);
      DebugLineDraw.UI.AddLine(vector2_2, vector2_2 += (vector2_1 - dir * 2f) * 2f * 2f, colorEnd);
    }
    DebugLineDraw.UI.AddLine(start, vector2_2, colorStart, colorEnd);
  }

  public static class Shortcuts
  {
    public static int NPCS_IconsPerColumn = 100;
    public static int NPCS_IconsTotal = 0;
    public static int NPCS_HoveredBanner = -2;
    public static int NPCS_SelectedNPC = -2;
    public static bool NPCS_IconsDisplay = false;
    public static int CRAFT_IconsPerRow = 100;
    public static int CRAFT_IconsPerColumn = 100;
    public static int CRAFT_CurrentIngredientsCount = 0;
    public static int CRAFT_CurrentRecipeBig = 0;
    public static int CRAFT_CurrentRecipeSmall = 0;
    public static int NewCraftingUI_MaterialIndex = 0;
    public static bool NPCCHAT_ButtonsNew = false;
    public static int NPCCHAT_ButtonsCount = 1;
    public static bool NPCCHAT_ButtonsLeft = false;
    public static bool NPCCHAT_ButtonsMiddle = false;
    public static bool NPCCHAT_ButtonsRight = false;
    public static bool NPCCHAT_ButtonsRight2 = false;
    public static int INGAMEOPTIONS_BUTTONS_LEFT = 0;
    public static int INGAMEOPTIONS_BUTTONS_RIGHT = 0;
    public static bool ItemSlotShouldHighlightAsSelected = false;
    public static bool ItemSlotShouldHighlightAsPreviouslySelected = false;
    public static int OPTIONS_BUTTON_SPECIALFEATURE;
    public static int BackButtonCommand;
    public static bool BackButtonInUse = false;
    public static bool BackButtonLock;
    public static int FANCYUI_HIGHEST_INDEX = 1;
    public static int FANCYUI_SPECIAL_INSTRUCTIONS = 0;
    public static int INFOACCCOUNT = 0;
    public static int BUILDERACCCOUNT = 0;
    public static int BUFFS_PER_COLUMN = 0;
    public static int BUFFS_DRAWN = 0;
    public static int INV_MOVE_OPTION_CD = 0;
  }
}
