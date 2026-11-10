// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.States.UIWorldCreation
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.UI.Elements;
using Terraria.Graphics;
using Terraria.Graphics.Renderers;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Social;
using Terraria.Testing;
using Terraria.UI;
using Terraria.UI.Gamepad;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.UI.States;

public class UIWorldCreation : UIState, IHaveBackButtonCommand
{
  private string _optionwWorldName;
  private string _optionSeed;
  private bool _isSpecialSeedText;
  private List<string> _secretSeedTextsEntered = new List<string>();
  private List<string> _disabledSecretSeedTextsEntered = new List<string>();
  private ParticleRenderer SeedParticleSystem = new ParticleRenderer();
  private UIDust SeedDust = new UIDust();
  private GroupOptionButton<bool> _advancedSeedButton;
  private UICharacterNameButton _namePlate;
  private UICharacterNameButton _seedPlate;
  private UIWorldCreationPreview _previewPlate;
  private GroupOptionButton<UIWorldCreation.WorldSizeId>[] _sizeButtons;
  private GroupOptionButton<UIWorldCreation.WorldDifficultyId>[] _difficultyButtons;
  private GroupOptionButton<UIWorldCreation.WorldEvilId>[] _evilButtons;
  private UIText _descriptionText;
  public const int MAX_NAME_LENGTH = 27;
  private UIState _goBackTarget;
  public UIWorldCreation.SubmitSeedEvent SubmitSeed;
  private float ringPoint;
  private const int numSteps = 61;
  private Vector2[] oldPos = new Vector2[61];
  private Vector2[] oldTangent = new Vector2[61];
  private int specialSeedIndex;
  private static VertexStrip _vertexStrip = new VertexStrip();
  private float opacity = 0.6f;
  private float opacity2 = 0.5f;
  private float trial;
  private float animationSpeed = 0.5f;
  private float saturation = 0.5f;

  private UIWorldCreation.WorldSizeId _optionSize
  {
    get => (UIWorldCreation.WorldSizeId) WorldGen.GetWorldSize();
    set => WorldGen.SetWorldSize((int) value);
  }

  private UIWorldCreation.WorldDifficultyId _optionDifficulty
  {
    get => (UIWorldCreation.WorldDifficultyId) Main.GameMode;
    set => Main.GameMode = (int) value;
  }

  private UIWorldCreation.WorldEvilId _optionEvil
  {
    get => (UIWorldCreation.WorldEvilId) (WorldGen.WorldGenParam_Evil + 1);
    set => WorldGen.WorldGenParam_Evil = (int) (value - 1);
  }

  public UIWorldCreation()
  {
    this._goBackTarget = (UIState) this;
    this.BuildPage();
    this.SeedDust.Clear();
    this.SeedParticleSystem.Clear();
    this.ResetSpecialSeedRing();
  }

  public void SetGoBackTarget(UIState state) => this._goBackTarget = state;

  private void BuildPage()
  {
    int num = 18;
    this.RemoveAllChildren();
    UIElement uiElement1 = new UIElement()
    {
      Width = StyleDimension.FromPixels(500f),
      Height = StyleDimension.FromPixels(434f + (float) num),
      Top = StyleDimension.FromPixels(170f - (float) num),
      HAlign = 0.5f,
      VAlign = 0.0f
    };
    uiElement1.SetPadding(0.0f);
    this.Append(uiElement1);
    UIPanel uiPanel = new UIPanel();
    uiPanel.Width = StyleDimension.FromPercent(1f);
    uiPanel.Height = StyleDimension.FromPixels((float) (280 + num));
    uiPanel.Top = StyleDimension.FromPixels(50f);
    uiPanel.BackgroundColor = new Color(33, 43, 79) * 0.8f;
    UIPanel element = uiPanel;
    element.SetPadding(0.0f);
    uiElement1.Append((UIElement) element);
    this.MakeBackAndCreatebuttons(uiElement1);
    UIElement uiElement2 = new UIElement()
    {
      Top = StyleDimension.FromPixelsAndPercent(0.0f, 0.0f),
      Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f),
      Height = StyleDimension.FromPixelsAndPercent(0.0f, 1f),
      HAlign = 1f
    };
    uiElement2.SetPadding(0.0f);
    uiElement2.PaddingTop = 8f;
    uiElement2.PaddingBottom = 12f;
    element.Append(uiElement2);
    this.MakeInfoMenu(uiElement2);
  }

  private void PreparePreviouslyUnlockedSecretSeeds() => SecretSeedsTracker.PrepareInterface();

  private void MakeInfoMenu(UIElement parentContainer)
  {
    UIElement uiElement = new UIElement()
    {
      Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f),
      Height = StyleDimension.FromPixelsAndPercent(0.0f, 1f),
      HAlign = 0.5f,
      VAlign = 0.0f
    };
    uiElement.SetPadding(10f);
    uiElement.PaddingBottom = 0.0f;
    uiElement.PaddingTop = 0.0f;
    parentContainer.Append(uiElement);
    float pixels1 = 0.0f;
    float num1 = 44f;
    float num2 = (float) (88.0 + (double) num1);
    float pixels2 = num1;
    GroupOptionButton<bool> groupOptionButton1 = new GroupOptionButton<bool>(true, (LocalizedText) null, Language.GetText("UI.WorldCreationRandomizeNameDescription"), Color.White, "Images/UI/WorldCreation/IconRandomName");
    groupOptionButton1.Width = StyleDimension.FromPixelsAndPercent(40f, 0.0f);
    groupOptionButton1.Height = new StyleDimension(40f, 0.0f);
    groupOptionButton1.HAlign = 0.0f;
    groupOptionButton1.Top = StyleDimension.FromPixelsAndPercent(pixels1, 0.0f);
    groupOptionButton1.ShowHighlightWhenSelected = false;
    GroupOptionButton<bool> element1 = groupOptionButton1;
    element1.OnLeftMouseDown += new UIElement.MouseEvent(this.ClickRandomizeName);
    element1.OnMouseOver += new UIElement.MouseEvent(this.ShowOptionDescription);
    element1.OnMouseOut += new UIElement.MouseEvent(this.ClearOptionDescription);
    element1.SetSnapPoint("RandomizeName", 0);
    uiElement.Append((UIElement) element1);
    UICharacterNameButton characterNameButton1 = new UICharacterNameButton(Language.GetText("UI.WorldCreationName"), Language.GetText("UI.WorldCreationNameEmpty"), Language.GetText("UI.WorldDescriptionName"));
    characterNameButton1.Width = StyleDimension.FromPixelsAndPercent(-num2, 1f);
    characterNameButton1.HAlign = 0.0f;
    characterNameButton1.Left = new StyleDimension(pixels2, 0.0f);
    characterNameButton1.Top = StyleDimension.FromPixelsAndPercent(pixels1, 0.0f);
    UICharacterNameButton element2 = characterNameButton1;
    element2.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_SetName);
    element2.OnMouseOver += new UIElement.MouseEvent(this.ShowOptionDescription);
    element2.OnMouseOut += new UIElement.MouseEvent(this.ClearOptionDescription);
    element2.SetSnapPoint("Name", 0);
    uiElement.Append((UIElement) element2);
    this._namePlate = element2;
    CalculatedStyle dimensions1 = element2.GetDimensions();
    float pixels3 = pixels1 + (dimensions1.Height + 4f);
    GroupOptionButton<bool> groupOptionButton2 = new GroupOptionButton<bool>(true, (LocalizedText) null, Language.GetText("UI.WorldCreationSeedMenuDescription"), Color.White, "Images/UI/WorldCreation/IconRandomSeed");
    groupOptionButton2.Width = StyleDimension.FromPixelsAndPercent(40f, 0.0f);
    groupOptionButton2.Height = new StyleDimension(40f, 0.0f);
    groupOptionButton2.HAlign = 0.0f;
    groupOptionButton2.Top = StyleDimension.FromPixelsAndPercent(pixels3, 0.0f);
    groupOptionButton2.ShowHighlightWhenSelected = false;
    this._advancedSeedButton = groupOptionButton2;
    this._advancedSeedButton.OnLeftMouseDown += new UIElement.MouseEvent(this.ClickAdvancedSeedMenu);
    this._advancedSeedButton.OnMouseOver += new UIElement.MouseEvent(this.ShowOptionDescription);
    this._advancedSeedButton.OnMouseOut += new UIElement.MouseEvent(this.ClearOptionDescription);
    this._advancedSeedButton.SetSnapPoint("RandomizeSeed", 0);
    this._advancedSeedButton.OnDraw += new UIElement.DrawEvent(this.DrawSpecialSeedRingCallback);
    uiElement.Append((UIElement) this._advancedSeedButton);
    UICharacterNameButton characterNameButton2 = new UICharacterNameButton(Language.GetText("UI.WorldCreationSeed"), Language.GetText("UI.WorldCreationSeedEmpty"), Language.GetText("UI.WorldDescriptionSeed"));
    characterNameButton2.Width = StyleDimension.FromPixelsAndPercent(-num2, 1f);
    characterNameButton2.HAlign = 0.0f;
    characterNameButton2.Left = new StyleDimension(pixels2, 0.0f);
    characterNameButton2.Top = StyleDimension.FromPixelsAndPercent(pixels3, 0.0f);
    characterNameButton2.DistanceFromTitleToOption = 29f;
    UICharacterNameButton element3 = characterNameButton2;
    element3.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_SetSeed);
    element3.OnMouseOver += new UIElement.MouseEvent(this.ShowOptionDescription);
    element3.OnMouseOut += new UIElement.MouseEvent(this.ClearOptionDescription);
    element3.SetSnapPoint("Seed", 0);
    uiElement.Append((UIElement) element3);
    this._seedPlate = element3;
    UIWorldCreationPreview worldCreationPreview = new UIWorldCreationPreview();
    worldCreationPreview.Width = StyleDimension.FromPixels(84f);
    worldCreationPreview.Height = StyleDimension.FromPixels(84f);
    worldCreationPreview.HAlign = 1f;
    worldCreationPreview.VAlign = 0.0f;
    UIWorldCreationPreview element4 = worldCreationPreview;
    uiElement.Append((UIElement) element4);
    this._previewPlate = element4;
    CalculatedStyle dimensions2 = element3.GetDimensions();
    float accumualtedHeight1 = pixels3 + (dimensions2.Height + 10f);
    UIWorldCreation.AddHorizontalSeparator(uiElement, accumualtedHeight1 + 2f);
    float usableWidthPercent = 1f;
    this.AddWorldSizeOptions(uiElement, accumualtedHeight1, new UIElement.MouseEvent(this.ClickSizeOption), "size", usableWidthPercent);
    float accumualtedHeight2 = accumualtedHeight1 + 48f;
    UIWorldCreation.AddHorizontalSeparator(uiElement, accumualtedHeight2);
    this.AddWorldDifficultyOptions(uiElement, accumualtedHeight2, new UIElement.MouseEvent(this.ClickDifficultyOption), "difficulty", usableWidthPercent);
    float accumualtedHeight3 = accumualtedHeight2 + 48f;
    UIWorldCreation.AddHorizontalSeparator(uiElement, accumualtedHeight3);
    this.AddWorldEvilOptions(uiElement, accumualtedHeight3, new UIElement.MouseEvent(this.ClickEvilOption), "evil", usableWidthPercent);
    float num3 = accumualtedHeight3 + 48f;
    UIWorldCreation.AddHorizontalSeparator(uiElement, num3);
    this.AddDescriptionPanel(uiElement, num3, "desc");
    this.SetDefaultOptions();
  }

  private static void AddHorizontalSeparator(UIElement Container, float accumualtedHeight)
  {
    UIHorizontalSeparator horizontalSeparator = new UIHorizontalSeparator();
    horizontalSeparator.Width = StyleDimension.FromPercent(1f);
    horizontalSeparator.Top = StyleDimension.FromPixels(accumualtedHeight - 8f);
    horizontalSeparator.Color = Color.Lerp(Color.White, new Color(63 /*0x3F*/, 65, 151, (int) byte.MaxValue), 0.85f) * 0.9f;
    UIHorizontalSeparator element = horizontalSeparator;
    Container.Append((UIElement) element);
  }

  private void SetDefaultOptions()
  {
    Main.ActiveWorldFileData = new WorldFileData();
    this.AssignRandomWorldName();
    this.ClearSeed();
    this._optionSize = UIWorldCreation.WorldSizeId.Medium;
    if (Main.ActivePlayerFileData.Player.difficulty == (byte) 3)
      this._optionDifficulty = UIWorldCreation.WorldDifficultyId.Creative;
    this._optionEvil = UIWorldCreation.WorldEvilId.Random;
    this.UpdateSliders();
    this.UpdatePreviewPlate();
  }

  private void AddDescriptionPanel(UIElement container, float accumulatedHeight, string tagGroup)
  {
    float num = 0.0f;
    UISlicedImage uiSlicedImage = new UISlicedImage(Main.Assets.Request<Texture2D>("Images/UI/CharCreation/CategoryPanelHighlight", (AssetRequestMode) 1));
    uiSlicedImage.HAlign = 0.5f;
    uiSlicedImage.VAlign = 1f;
    uiSlicedImage.Width = StyleDimension.FromPixelsAndPercent((float) (-(double) num * 2.0), 1f);
    uiSlicedImage.Left = StyleDimension.FromPixels(-num);
    uiSlicedImage.Height = StyleDimension.FromPixelsAndPercent(40f, 0.0f);
    uiSlicedImage.Top = StyleDimension.FromPixels(2f);
    UISlicedImage element1 = uiSlicedImage;
    element1.SetSliceDepths(10);
    element1.Color = Color.LightGray * 0.7f;
    container.Append((UIElement) element1);
    UIText uiText = new UIText(Language.GetText("UI.WorldDescriptionDefault"), 0.82f);
    uiText.HAlign = 0.0f;
    uiText.VAlign = 0.0f;
    uiText.Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f);
    uiText.Height = StyleDimension.FromPixelsAndPercent(0.0f, 1f);
    uiText.Top = StyleDimension.FromPixelsAndPercent(5f, 0.0f);
    UIText element2 = uiText;
    element2.PaddingLeft = 20f;
    element2.PaddingRight = 20f;
    element2.PaddingTop = 6f;
    element1.Append((UIElement) element2);
    this._descriptionText = element2;
  }

  private void AddWorldSizeOptions(
    UIElement container,
    float accumualtedHeight,
    UIElement.MouseEvent clickEvent,
    string tagGroup,
    float usableWidthPercent)
  {
    UIWorldCreation.WorldSizeId[] worldSizeIdArray = new UIWorldCreation.WorldSizeId[3]
    {
      UIWorldCreation.WorldSizeId.Small,
      UIWorldCreation.WorldSizeId.Medium,
      UIWorldCreation.WorldSizeId.Large
    };
    LocalizedText[] localizedTextArray1 = new LocalizedText[3]
    {
      Lang.menu[92],
      Lang.menu[93],
      Lang.menu[94]
    };
    LocalizedText[] localizedTextArray2 = new LocalizedText[3]
    {
      Language.GetText("UI.WorldDescriptionSizeSmall"),
      Language.GetText("UI.WorldDescriptionSizeMedium"),
      Language.GetText("UI.WorldDescriptionSizeLarge")
    };
    Color[] colorArray = new Color[3]
    {
      Color.Cyan,
      Color.Lerp(Color.Cyan, Color.LimeGreen, 0.5f),
      Color.LimeGreen
    };
    string[] strArray = new string[3]
    {
      "Images/UI/WorldCreation/IconSizeSmall",
      "Images/UI/WorldCreation/IconSizeMedium",
      "Images/UI/WorldCreation/IconSizeLarge"
    };
    GroupOptionButton<UIWorldCreation.WorldSizeId>[] groupOptionButtonArray = new GroupOptionButton<UIWorldCreation.WorldSizeId>[worldSizeIdArray.Length];
    for (int id = 0; id < groupOptionButtonArray.Length; ++id)
    {
      GroupOptionButton<UIWorldCreation.WorldSizeId> element = new GroupOptionButton<UIWorldCreation.WorldSizeId>(worldSizeIdArray[id], localizedTextArray1[id], localizedTextArray2[id], colorArray[id], strArray[id], titleAlignmentX: 1f, titleWidthReduction: 16f);
      element.Width = StyleDimension.FromPixelsAndPercent((float) (-4 * (groupOptionButtonArray.Length - 1)), 1f / (float) groupOptionButtonArray.Length * usableWidthPercent);
      element.Left = StyleDimension.FromPercent(1f - usableWidthPercent);
      element.HAlign = (float) id / (float) (groupOptionButtonArray.Length - 1);
      element.Top.Set(accumualtedHeight, 0.0f);
      element.OnLeftMouseDown += clickEvent;
      element.OnMouseOver += new UIElement.MouseEvent(this.ShowOptionDescription);
      element.OnMouseOut += new UIElement.MouseEvent(this.ClearOptionDescription);
      element.SetSnapPoint(tagGroup, id);
      container.Append((UIElement) element);
      groupOptionButtonArray[id] = element;
    }
    this._sizeButtons = groupOptionButtonArray;
  }

  private void AddWorldDifficultyOptions(
    UIElement container,
    float accumualtedHeight,
    UIElement.MouseEvent clickEvent,
    string tagGroup,
    float usableWidthPercent)
  {
    UIWorldCreation.WorldDifficultyId[] worldDifficultyIdArray = new UIWorldCreation.WorldDifficultyId[4]
    {
      UIWorldCreation.WorldDifficultyId.Creative,
      UIWorldCreation.WorldDifficultyId.Normal,
      UIWorldCreation.WorldDifficultyId.Expert,
      UIWorldCreation.WorldDifficultyId.Master
    };
    LocalizedText[] localizedTextArray1 = new LocalizedText[4]
    {
      Language.GetText("UI.Creative"),
      Language.GetText("UI.Normal"),
      Language.GetText("UI.Expert"),
      Language.GetText("UI.Master")
    };
    LocalizedText[] localizedTextArray2 = new LocalizedText[4]
    {
      Language.GetText("UI.WorldDescriptionCreative"),
      Language.GetText("UI.WorldDescriptionNormal"),
      Language.GetText("UI.WorldDescriptionExpert"),
      Language.GetText("UI.WorldDescriptionMaster")
    };
    Color[] colorArray = new Color[4]
    {
      Main.creativeModeColor,
      Color.White,
      Main.mcColor,
      Main.hcColor
    };
    string[] strArray = new string[4]
    {
      "Images/UI/WorldCreation/IconDifficultyCreative",
      "Images/UI/WorldCreation/IconDifficultyNormal",
      "Images/UI/WorldCreation/IconDifficultyExpert",
      "Images/UI/WorldCreation/IconDifficultyMaster"
    };
    GroupOptionButton<UIWorldCreation.WorldDifficultyId>[] groupOptionButtonArray = new GroupOptionButton<UIWorldCreation.WorldDifficultyId>[worldDifficultyIdArray.Length];
    for (int id = 0; id < groupOptionButtonArray.Length; ++id)
    {
      GroupOptionButton<UIWorldCreation.WorldDifficultyId> element = new GroupOptionButton<UIWorldCreation.WorldDifficultyId>(worldDifficultyIdArray[id], localizedTextArray1[id], localizedTextArray2[id], colorArray[id], strArray[id], titleAlignmentX: 1f, titleWidthReduction: 16f);
      element.Width = StyleDimension.FromPixelsAndPercent((float) (-1 * (groupOptionButtonArray.Length - 1)), 1f / (float) groupOptionButtonArray.Length * usableWidthPercent);
      element.Left = StyleDimension.FromPercent(1f - usableWidthPercent);
      element.HAlign = (float) id / (float) (groupOptionButtonArray.Length - 1);
      element.Top.Set(accumualtedHeight, 0.0f);
      element.OnLeftMouseDown += clickEvent;
      element.OnMouseOver += new UIElement.MouseEvent(this.ShowOptionDescription);
      element.OnMouseOut += new UIElement.MouseEvent(this.ClearOptionDescription);
      element.SetSnapPoint(tagGroup, id);
      container.Append((UIElement) element);
      groupOptionButtonArray[id] = element;
    }
    this._difficultyButtons = groupOptionButtonArray;
  }

  private void AddWorldEvilOptions(
    UIElement container,
    float accumualtedHeight,
    UIElement.MouseEvent clickEvent,
    string tagGroup,
    float usableWidthPercent)
  {
    UIWorldCreation.WorldEvilId[] worldEvilIdArray = new UIWorldCreation.WorldEvilId[3]
    {
      UIWorldCreation.WorldEvilId.Random,
      UIWorldCreation.WorldEvilId.Corruption,
      UIWorldCreation.WorldEvilId.Crimson
    };
    LocalizedText[] localizedTextArray1 = new LocalizedText[3]
    {
      Lang.misc[103],
      Lang.misc[101],
      Lang.misc[102]
    };
    LocalizedText[] localizedTextArray2 = new LocalizedText[3]
    {
      Language.GetText("UI.WorldDescriptionEvilRandom"),
      Language.GetText("UI.WorldDescriptionEvilCorrupt"),
      Language.GetText("UI.WorldDescriptionEvilCrimson")
    };
    Color[] colorArray = new Color[3]
    {
      Color.White,
      Color.MediumPurple,
      Color.IndianRed
    };
    string[] strArray = new string[3]
    {
      "Images/UI/WorldCreation/IconEvilRandom",
      "Images/UI/WorldCreation/IconEvilCorruption",
      "Images/UI/WorldCreation/IconEvilCrimson"
    };
    GroupOptionButton<UIWorldCreation.WorldEvilId>[] groupOptionButtonArray = new GroupOptionButton<UIWorldCreation.WorldEvilId>[worldEvilIdArray.Length];
    for (int id = 0; id < groupOptionButtonArray.Length; ++id)
    {
      GroupOptionButton<UIWorldCreation.WorldEvilId> element = new GroupOptionButton<UIWorldCreation.WorldEvilId>(worldEvilIdArray[id], localizedTextArray1[id], localizedTextArray2[id], colorArray[id], strArray[id], titleAlignmentX: 1f, titleWidthReduction: 16f);
      element.Width = StyleDimension.FromPixelsAndPercent((float) (-4 * (groupOptionButtonArray.Length - 1)), 1f / (float) groupOptionButtonArray.Length * usableWidthPercent);
      element.Left = StyleDimension.FromPercent(1f - usableWidthPercent);
      element.HAlign = (float) id / (float) (groupOptionButtonArray.Length - 1);
      element.Top.Set(accumualtedHeight, 0.0f);
      element.OnLeftMouseDown += clickEvent;
      element.OnMouseOver += new UIElement.MouseEvent(this.ShowOptionDescription);
      element.OnMouseOut += new UIElement.MouseEvent(this.ClearOptionDescription);
      element.SetSnapPoint(tagGroup, id);
      container.Append((UIElement) element);
      groupOptionButtonArray[id] = element;
    }
    this._evilButtons = groupOptionButtonArray;
  }

  private void ClickRandomizeName(UIMouseEvent evt, UIElement listeningElement)
  {
    this.AssignRandomWorldName();
    this.UpdateInputFields();
    this.UpdateSliders();
    this.UpdatePreviewPlate();
  }

  private void ClickAdvancedSeedMenu(UIMouseEvent evt, UIElement listeningElement)
  {
    this.ResetSpecialSeedRing();
    UIWorldCreationAdvanced state = new UIWorldCreationAdvanced(this);
    this.SetGoBackTarget((UIState) state);
    Main.MenuUI.SetState((UIState) state);
  }

  public void ClearSeedText()
  {
    this._optionSeed = "";
    this._isSpecialSeedText = false;
    this.UpdateInputFields();
  }

  public void ClearSeed()
  {
    this._optionSeed = string.Empty;
    this._isSpecialSeedText = false;
    this._secretSeedTextsEntered.Clear();
    this._disabledSecretSeedTextsEntered.Clear();
    WorldGenerationOptions.Reset();
    WorldGen.SecretSeed.ClearAllSeeds();
    this.PreparePreviouslyUnlockedSecretSeeds();
    this.UpdateInputFields();
  }

  public void RandomizeSeed()
  {
    this._optionSeed = Main.rand.Next().ToString();
    this._isSpecialSeedText = false;
    this.UpdateInputFields();
    this.UpdateSliders();
    this.UpdatePreviewPlate();
  }

  private void ClickSizeOption(UIMouseEvent evt, UIElement listeningElement)
  {
    GroupOptionButton<UIWorldCreation.WorldSizeId> groupOptionButton = (GroupOptionButton<UIWorldCreation.WorldSizeId>) listeningElement;
    this._optionSize = groupOptionButton.OptionValue;
    foreach (GroupOptionButton<UIWorldCreation.WorldSizeId> sizeButton in this._sizeButtons)
      sizeButton.SetCurrentOption(groupOptionButton.OptionValue);
    this.UpdatePreviewPlate();
  }

  private void ClickDifficultyOption(UIMouseEvent evt, UIElement listeningElement)
  {
    GroupOptionButton<UIWorldCreation.WorldDifficultyId> groupOptionButton = (GroupOptionButton<UIWorldCreation.WorldDifficultyId>) listeningElement;
    this._optionDifficulty = groupOptionButton.OptionValue;
    foreach (GroupOptionButton<UIWorldCreation.WorldDifficultyId> difficultyButton in this._difficultyButtons)
      difficultyButton.SetCurrentOption(groupOptionButton.OptionValue);
    this.UpdatePreviewPlate();
  }

  private void ClickEvilOption(UIMouseEvent evt, UIElement listeningElement)
  {
    GroupOptionButton<UIWorldCreation.WorldEvilId> groupOptionButton = (GroupOptionButton<UIWorldCreation.WorldEvilId>) listeningElement;
    this._optionEvil = groupOptionButton.OptionValue;
    foreach (GroupOptionButton<UIWorldCreation.WorldEvilId> evilButton in this._evilButtons)
      evilButton.SetCurrentOption(groupOptionButton.OptionValue);
    this.UpdatePreviewPlate();
  }

  private void UpdatePreviewPlate()
  {
    this._previewPlate.UpdateOption((byte) this._optionDifficulty, (byte) this._optionEvil, (byte) this._optionSize);
  }

  private void UpdateSliders()
  {
    foreach (GroupOptionButton<UIWorldCreation.WorldSizeId> sizeButton in this._sizeButtons)
      sizeButton.SetCurrentOption(this._optionSize);
    foreach (GroupOptionButton<UIWorldCreation.WorldDifficultyId> difficultyButton in this._difficultyButtons)
      difficultyButton.SetCurrentOption(this._optionDifficulty);
    foreach (GroupOptionButton<UIWorldCreation.WorldEvilId> evilButton in this._evilButtons)
      evilButton.SetCurrentOption(this._optionEvil);
  }

  public void ShowOptionDescription(UIMouseEvent evt, UIElement listeningElement)
  {
    LocalizedText text = (LocalizedText) null;
    if (listeningElement is GroupOptionButton<UIWorldCreation.WorldSizeId> groupOptionButton1)
      text = groupOptionButton1.Description;
    if (listeningElement is GroupOptionButton<UIWorldCreation.WorldDifficultyId> groupOptionButton2)
      text = groupOptionButton2.Description;
    if (listeningElement is GroupOptionButton<UIWorldCreation.WorldEvilId> groupOptionButton3)
      text = groupOptionButton3.Description;
    if (listeningElement is UICharacterNameButton characterNameButton)
      text = characterNameButton.Description;
    if (listeningElement is GroupOptionButton<bool> groupOptionButton4)
      text = groupOptionButton4.Description;
    if (text == null)
      return;
    this._descriptionText.SetText(text);
  }

  public void ClearOptionDescription(UIMouseEvent evt, UIElement listeningElement)
  {
    this._descriptionText.SetText(Language.GetText("UI.WorldDescriptionDefault"));
  }

  private void MakeBackAndCreatebuttons(UIElement outerContainer)
  {
    UITextPanel<LocalizedText> uiTextPanel1 = new UITextPanel<LocalizedText>(Language.GetText("UI.Back"), 0.7f, true);
    uiTextPanel1.Width = StyleDimension.FromPixelsAndPercent(-10f, 0.5f);
    uiTextPanel1.Height = StyleDimension.FromPixels(50f);
    uiTextPanel1.VAlign = 1f;
    uiTextPanel1.HAlign = 0.0f;
    uiTextPanel1.Top = StyleDimension.FromPixels(-45f);
    UITextPanel<LocalizedText> element1 = uiTextPanel1;
    element1.OnMouseOver += new UIElement.MouseEvent(this.FadedMouseOver);
    element1.OnMouseOut += new UIElement.MouseEvent(this.FadedMouseOut);
    element1.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_GoBack);
    element1.SetSnapPoint("Back", 0);
    outerContainer.Append((UIElement) element1);
    UITextPanel<LocalizedText> uiTextPanel2 = new UITextPanel<LocalizedText>(Language.GetText("UI.Create"), 0.7f, true);
    uiTextPanel2.Width = StyleDimension.FromPixelsAndPercent(-10f, 0.5f);
    uiTextPanel2.Height = StyleDimension.FromPixels(50f);
    uiTextPanel2.VAlign = 1f;
    uiTextPanel2.HAlign = 1f;
    uiTextPanel2.Top = StyleDimension.FromPixels(-45f);
    UITextPanel<LocalizedText> element2 = uiTextPanel2;
    element2.OnMouseOver += new UIElement.MouseEvent(this.FadedMouseOver);
    element2.OnMouseOut += new UIElement.MouseEvent(this.FadedMouseOut);
    element2.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_NamingAndCreating);
    element2.SetSnapPoint("Create", 0);
    outerContainer.Append((UIElement) element2);
  }

  private void Click_GoBack(UIMouseEvent evt, UIElement listeningElement)
  {
    UIWorldCreation.GoBack();
  }

  private static void GoBack()
  {
    SoundEngine.PlaySound(11);
    Main.OpenWorldSelectUI();
  }

  private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    ((UIPanel) evt.Target).BackgroundColor = new Color(73, 94, 171);
    ((UIPanel) evt.Target).BorderColor = Colors.FancyUIFatButtonMouseOver;
  }

  private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
  {
    ((UIPanel) evt.Target).BackgroundColor = new Color(63 /*0x3F*/, 82, 151) * 0.8f;
    ((UIPanel) evt.Target).BorderColor = Color.Black;
  }

  private void Click_SetName(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(10);
    Main.clrInput();
    UIVirtualKeyboard state = new UIVirtualKeyboard(Lang.menu[48 /*0x30*/].Value, "", new UIVirtualKeyboard.KeyboardSubmitEvent(this.OnFinishedSettingName), new Action(this.GoBackHere), allowEmpty: true, maxLength: 27);
    Main.MenuUI.SetState((UIState) state);
  }

  private void Click_SetSeed(UIMouseEvent evt, UIElement listeningElement)
  {
    this.OpenSeedInputMenu();
  }

  public void OpenSeedInputMenu()
  {
    SoundEngine.PlaySound(10);
    Main.clrInput();
    UIVirtualKeyboard state = new UIVirtualKeyboard(Language.GetTextValue("UI.EnterSeed"), "", new UIVirtualKeyboard.KeyboardSubmitEvent(this.OnFinishedSettingSeed), new Action(this.GoBackHere), allowEmpty: true, maxLength: int.MaxValue);
    Main.MenuUI.SetState((UIState) state);
  }

  private void Click_NamingAndCreating(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(10);
    if (string.IsNullOrEmpty(this._optionwWorldName))
    {
      this._optionwWorldName = "";
      Main.clrInput();
      UIVirtualKeyboard state = new UIVirtualKeyboard(Lang.menu[48 /*0x30*/].Value, "", new UIVirtualKeyboard.KeyboardSubmitEvent(this.OnFinishedNamingAndCreating), new Action(this.GoBackHere), maxLength: 27);
      Main.MenuUI.SetState((UIState) state);
    }
    else
      this.FinishCreatingWorld();
  }

  private void OnFinishedSettingName(string name)
  {
    this._optionwWorldName = name.Trim();
    this.UpdateInputFields();
    this.GoBackHere();
  }

  private void UpdateInputFields()
  {
    this._namePlate.SetContents(this._optionwWorldName);
    this._namePlate.Recalculate();
    this._namePlate.TrimDisplayIfOverElementDimensions(27);
    this._namePlate.Recalculate();
    this.FillSeedContent(this._seedPlate);
  }

  public void FillSeedContent(UICharacterNameButton button)
  {
    button.SetContents(this._optionSeed);
    button.Recalculate();
    button.TrimDisplayIfOverElementDimensions(WorldFileData.MAX_USER_SEED_TEXT_LENGTH);
    button.Recalculate();
  }

  public void ToggleSeedOption(AWorldGenerationOption seedOption)
  {
    if (this._isSpecialSeedText)
    {
      this._optionSeed = string.Empty;
      this._isSpecialSeedText = false;
      this.UpdateInputFields();
      this.UpdateSliders();
      this.UpdatePreviewPlate();
    }
    seedOption.Enabled = !seedOption.Enabled;
  }

  public bool HasEnteredSpecialSeed => this._secretSeedTextsEntered.Count > 0;

  public bool HasDisabledSecretSeed => this._disabledSecretSeedTextsEntered.Count > 0;

  public void EnableSecretSeedOptions(bool enabled)
  {
    if (enabled)
    {
      for (int index = 0; index < this._disabledSecretSeedTextsEntered.Count; ++index)
      {
        WorldGen.SecretSeed secretSeed;
        if (WorldGen.SecretSeed.CheckInputForSecretSeed(this._disabledSecretSeedTextsEntered[index], out secretSeed) && !secretSeed.Enabled)
        {
          this._secretSeedTextsEntered.Add(this._disabledSecretSeedTextsEntered[index]);
          WorldGen.SecretSeed.Enable(secretSeed, false);
        }
      }
      this._disabledSecretSeedTextsEntered.Clear();
    }
    else
    {
      this._disabledSecretSeedTextsEntered.Clear();
      this._disabledSecretSeedTextsEntered.AddRange((IEnumerable<string>) this._secretSeedTextsEntered);
      WorldGen.SecretSeed.ClearAllSeeds();
      this._secretSeedTextsEntered.Clear();
    }
  }

  public string GetJoinedSecretSeedString(DynamicSpriteFont font, float maxWidth, float maxHeight)
  {
    float num = 0.0f;
    string secretSeedString = string.Empty;
    List<string> stringList = this.HasEnteredSpecialSeed ? this._secretSeedTextsEntered : this._disabledSecretSeedTextsEntered;
    if (stringList.Count == 0)
      return "-";
    string str1 = stringList[0];
    for (int index = 1; index < stringList.Count; ++index)
    {
      string str2 = $"{str1}|{stringList[index]}";
      if ((double) font.MeasureString(str2).X >= (double) maxWidth)
      {
        if ((double) num <= (double) maxHeight)
          secretSeedString = $"{secretSeedString}{str1}\n";
        num += (float) font.LineSpacing;
        str2 = stringList[index];
      }
      str1 = str2;
    }
    if ((double) num <= (double) maxHeight)
      secretSeedString += str1;
    return secretSeedString;
  }

  private void OnFinishedSettingSeed(string seed)
  {
    this._optionSeed = seed.Trim();
    string processedSeed;
    List<string> secretSeedTexts;
    if (WorldFileData.TryApplyingCopiedSeed(this._optionSeed, true, out processedSeed, out string _, out secretSeedTexts))
    {
      this._optionSeed = processedSeed;
      this._secretSeedTextsEntered = secretSeedTexts;
      this._disabledSecretSeedTextsEntered.Clear();
    }
    else
    {
      this._optionSeed = Utils.TrimUserString(this._optionSeed, WorldFileData.MAX_USER_SEED_TEXT_LENGTH);
      AWorldGenerationOption optionFromSeedText = WorldGenerationOptions.GetOptionFromSeedText(this._optionSeed);
      this._isSpecialSeedText = optionFromSeedText != null;
      if (this._isSpecialSeedText)
      {
        WorldGenerationOptions.SelectOption(optionFromSeedText);
        SoundEngine.PlaySound(24);
      }
      WorldGen.SecretSeed secretSeed;
      if (WorldGen.SecretSeed.CheckInputForSecretSeed(this._optionSeed, out secretSeed))
      {
        if (!secretSeed.Enabled)
        {
          this._secretSeedTextsEntered.Add(this._optionSeed);
          WorldGen.SecretSeed.Enable(secretSeed);
          this.EnableSecretSeedOptions(true);
          CalculatedStyle dimensions = this._advancedSeedButton.GetDimensions();
          if (this._goBackTarget != this && this._goBackTarget is UIWorldCreationAdvanced goBackTarget)
          {
            goBackTarget.RefreshSecretSeedButton();
            dimensions = goBackTarget.GetSecretSeedButton().GetDimensions();
            goBackTarget.GetSecretSeedButton().SetCurrentOption(this.HasEnteredSpecialSeed);
          }
          Vector2 vector2_1 = dimensions.Center();
          Vector2 vector2_2 = Main.rand.NextVector2Circular(5f, 5f);
          ParticleOrchestraSettings settings = new ParticleOrchestraSettings();
          settings.PositionInWorld = vector2_1;
          settings.MovementVector = new Vector2(16f, 0.0f) + vector2_2;
          this.Spawn_RainbowRodHit(settings);
          if (this._goBackTarget != this)
          {
            settings = new ParticleOrchestraSettings();
            settings.PositionInWorld = vector2_1;
            settings.MovementVector = new Vector2(16f, 0.0f) - vector2_2;
            this.Spawn_RainbowRodHit(settings);
          }
          Vector2 vector2_3 = Main.rand.NextVector2Circular(5f, 5f);
          settings = new ParticleOrchestraSettings();
          settings.PositionInWorld = vector2_1;
          settings.MovementVector = new Vector2(0.0f, 16f) + vector2_3;
          this.Spawn_RainbowRodHit(settings);
          if (this._goBackTarget != this)
          {
            settings = new ParticleOrchestraSettings();
            settings.PositionInWorld = vector2_1;
            settings.MovementVector = new Vector2(0.0f, 16f) - vector2_3;
            this.Spawn_RainbowRodHit(settings);
          }
          for (int index = 0; index < 3; ++index)
          {
            settings = new ParticleOrchestraSettings();
            settings.PositionInWorld = vector2_1 + new Vector2(dimensions.Width * 0.25f * (float) (index - 1), 0.0f);
            this.Spawn_BestReforge(settings);
          }
        }
        this.ClearSeedText();
      }
    }
    this.UpdateInputFields();
    this.UpdateSliders();
    this.UpdatePreviewPlate();
    if (this.SubmitSeed != null)
      this.SubmitSeed();
    this.GoBackHere();
  }

  private void Spawn_BestReforge(ParticleOrchestraSettings settings)
  {
    Vector2 vector2_1 = new Vector2(0.0f, 0.163500011f);
    Asset<Texture2D> textureAsset = Main.Assets.Request<Texture2D>("Images/UI/Creative/Research_Spark", (AssetRequestMode) 1);
    for (int index = 0; index < 8; ++index)
    {
      Vector2 vector2_2 = Main.rand.NextVector2Circular(3f, 4f);
      this.SeedParticleSystem.Add((IParticle) new CreativeSacrificeParticle(textureAsset, new Microsoft.Xna.Framework.Rectangle?(), settings.MovementVector + vector2_2, settings.PositionInWorld)
      {
        AccelerationPerFrame = vector2_1,
        ScaleOffsetPerFrame = -0.0166666675f
      });
    }
  }

  private void Spawn_RainbowRodHit(ParticleOrchestraSettings settings)
  {
    float num1 = Main.rand.NextFloat() * 6.28318548f;
    float num2 = 6f;
    float num3 = Main.rand.NextFloat();
    for (float num4 = 0.0f; (double) num4 < 1.0; num4 += 1f / num2)
    {
      Vector2 vector2_1 = settings.MovementVector * Main.rand.NextFloatDirection() * 0.15f;
      Vector2 vector2_2 = new Vector2((float) ((double) Main.rand.NextFloat() * 0.40000000596046448 + 0.40000000596046448));
      float f = num1 + Main.rand.NextFloat() * 6.28318548f;
      float num5 = 1.57079637f;
      Vector2 vector2_3 = 1.5f * vector2_2;
      float num6 = 60f;
      Vector2 vector2_4 = Main.rand.NextVector2Circular(8f, 8f) * vector2_2;
      PrettySparkleParticle prettySparkleParticle1 = new PrettySparkleParticle();
      prettySparkleParticle1.Velocity = f.ToRotationVector2() * vector2_3 + vector2_1;
      prettySparkleParticle1.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_3 / num6) - vector2_1 * 1f / 60f;
      prettySparkleParticle1.ColorTint = Main.hslToRgb((float) (((double) num3 + (double) Main.rand.NextFloat() * 0.33000001311302185) % 1.0), 1f, (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.25));
      prettySparkleParticle1.ColorTint.A = (byte) 0;
      prettySparkleParticle1.LocalPosition = settings.PositionInWorld + vector2_4;
      prettySparkleParticle1.Rotation = num5;
      prettySparkleParticle1.Scale = vector2_2;
      this.SeedParticleSystem.Add((IParticle) prettySparkleParticle1);
      PrettySparkleParticle prettySparkleParticle2 = new PrettySparkleParticle();
      prettySparkleParticle2.Velocity = f.ToRotationVector2() * vector2_3 + vector2_1;
      prettySparkleParticle2.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_3 / num6) - vector2_1 * 1f / 60f;
      prettySparkleParticle2.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
      prettySparkleParticle2.LocalPosition = settings.PositionInWorld + vector2_4;
      prettySparkleParticle2.Rotation = num5;
      prettySparkleParticle2.Scale = vector2_2 * 0.6f;
      this.SeedParticleSystem.Add((IParticle) prettySparkleParticle2);
    }
    for (int index = 0; index < 12; ++index)
    {
      Color rgb = Main.hslToRgb((float) (((double) num3 + (double) Main.rand.NextFloat() * 0.11999999731779099) % 1.0), 1f, (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.25));
      Dust rf = this.SeedDust.NewDust(settings.PositionInWorld, 0, 0, 267, newColor: rgb);
      rf.velocity = Main.rand.NextVector2Circular(1f, 1f);
      rf.velocity += settings.MovementVector * Main.rand.NextFloatDirection() * 0.5f;
      rf.noGravity = true;
      rf.scale = (float) (0.60000002384185791 + (double) Main.rand.NextFloat() * 0.89999997615814209);
      rf.fadeIn = (float) (0.699999988079071 + (double) Main.rand.NextFloat() * 0.800000011920929);
      if (rf.dustIndex != 200)
      {
        Dust dust = this.SeedDust.CloneDust(rf);
        dust.scale /= 2f;
        dust.fadeIn *= 0.75f;
        dust.color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      }
    }
  }

  private void GoBackHere() => Main.MenuUI.SetState(this._goBackTarget);

  private void OnFinishedNamingAndCreating(string name)
  {
    this.OnFinishedSettingName(name);
    this.FinishCreatingWorld();
  }

  private void FinishCreatingWorld()
  {
    string name;
    Main.worldName = name = this._optionwWorldName.Trim();
    UIWorldCreation.WorldDifficultyId optionDifficulty = this._optionDifficulty;
    int num = SocialAPI.Cloud == null ? 0 : (SocialAPI.Cloud.EnabledByDefault ? 1 : 0);
    int gameMode = Main.GameMode;
    Main.ActiveWorldFileData = WorldFile.CreateMetadata(name, num != 0, gameMode);
    this._optionDifficulty = optionDifficulty;
    if (this._optionSeed.Length == 0 || this._isSpecialSeedText)
      Main.ActiveWorldFileData.SetSeedToRandomWithCurrentEvents();
    else
      Main.ActiveWorldFileData.SetSeed(this._optionSeed);
    if (this._secretSeedTextsEntered.Count > 0)
    {
      string seedText = $"{string.Join("|", (IEnumerable<string>) this._secretSeedTextsEntered)}|{Main.ActiveWorldFileData.SeedText}";
      Main.ActiveWorldFileData.SetSeed(seedText);
    }
    WorldGen.CreateNewWorld(controller: new WorldGenerator.Controller()
    {
      Paused = DebugOptions.enableDebugCommands && Main.keyState.PressingControl()
    });
  }

  private void AssignRandomWorldName()
  {
    do
    {
      LocalizedText localizedText = Language.SelectRandom(Lang.CreateDialogFilter("RandomWorldName_Composition.", false));
      var data = new
      {
        Adjective = Language.SelectRandom(Lang.CreateDialogFilter("RandomWorldName_Adjective.")).Value,
        Location = Language.SelectRandom(Lang.CreateDialogFilter("RandomWorldName_Location.")).Value,
        Noun = Language.SelectRandom(Lang.CreateDialogFilter("RandomWorldName_Noun.")).Value
      };
      this._optionwWorldName = localizedText.FormatWith((object) data);
      if (Main.rand.Next(10000) == 0)
        this._optionwWorldName = Language.GetTextValue("SpecialWorldName.TheConstant");
    }
    while (this._optionwWorldName.Length > 27);
  }

  public override void Draw(SpriteBatch spriteBatch)
  {
    if (this._goBackTarget != this)
      this._goBackTarget = (UIState) this;
    base.Draw(spriteBatch);
    this.SetupGamepadPoints(spriteBatch);
    this.DrawSeedSystems(spriteBatch);
  }

  public void ResetSpecialSeedRing()
  {
    this.ringPoint = 0.0f;
    Array.Clear((Array) this.oldPos, 0, this.oldPos.Length);
    Array.Clear((Array) this.oldTangent, 0, this.oldTangent.Length);
  }

  public void DrawSpecialSeedRingCallback(UIElement element, SpriteBatch spriteBatch)
  {
    if (!this.HasEnteredSpecialSeed)
      return;
    spriteBatch.End();
    spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.AnisotropicClamp, DepthStencilState.None, RasterizerState.CullCounterClockwise, (Effect) null, Main.UIScaleMatrix);
    if (this.oldPos[0] == Vector2.Zero)
    {
      for (int index = 0; index < 61; ++index)
        this.UpdateSpecialSeedRing(element);
    }
    else
    {
      this.specialSeedIndex = (this.specialSeedIndex + 1) % 4;
      if (this.specialSeedIndex % 4 == 0)
        this.UpdateSpecialSeedRing(element);
    }
    this.DrawSpecialSeedRing();
    spriteBatch.End();
    spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.AnisotropicClamp, DepthStencilState.None, RasterizerState.CullCounterClockwise, (Effect) null, Main.UIScaleMatrix);
  }

  public void DrawSpecialSeedRingCallbackWithoutCondition(
    UIElement element,
    SpriteBatch spriteBatch)
  {
    spriteBatch.End();
    spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.AnisotropicClamp, DepthStencilState.None, RasterizerState.CullCounterClockwise, (Effect) null, Main.UIScaleMatrix);
    if (this.oldPos[0] == Vector2.Zero)
    {
      for (int index = 0; index < 61; ++index)
        this.UpdateSpecialSeedRing(element);
    }
    else
      this.UpdateSpecialSeedRing(element);
    this.DrawSpecialSeedRing();
    spriteBatch.End();
    spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.AnisotropicClamp, DepthStencilState.None, RasterizerState.CullCounterClockwise, (Effect) null, Main.UIScaleMatrix);
  }

  private void UpdateSpecialSeedRing(UIElement element)
  {
    CalculatedStyle dimensions = this._advancedSeedButton.GetDimensions();
    if (this._goBackTarget != this && this._goBackTarget is UIWorldCreationAdvanced goBackTarget)
    {
      goBackTarget.RefreshSecretSeedButton();
      dimensions = goBackTarget.GetSecretSeedButton().GetDimensions();
    }
    if (element is GroupOptionButton<WorldGen.SecretSeed>)
      dimensions = element.GetDimensions();
    Microsoft.Xna.Framework.Rectangle rectangle = dimensions.ToRectangle();
    rectangle.Inflate(-1, -1);
    int num1 = rectangle.Width * 2 + rectangle.Height * 2;
    this.ringPoint += (float) num1 / 60f;
    if ((double) this.ringPoint >= (double) num1)
      this.ringPoint -= (float) num1;
    float num2 = (float) Math.Sqrt((double) (rectangle.Width / 2 * rectangle.Width / 2 + rectangle.Height / 2 * rectangle.Height / 2));
    float num3 = 6.28318548f * this.ringPoint / (float) num1;
    Vector2 vector2_1 = new Vector2((float) Math.Cos((double) num3), (float) Math.Sin((double) num3));
    Vector2 vector2_2 = vector2_1 * num2;
    float num4 = Math.Abs(vector2_2.X) / ((float) rectangle.Width / 2f);
    float num5 = Math.Abs(vector2_2.Y) / ((float) rectangle.Height / 2f);
    Vector2 vector2_3;
    Vector2 vector2_4;
    if ((double) num4 > (double) num5)
    {
      vector2_3 = vector2_2 / num4;
      vector2_4 = vector2_1 / num4;
    }
    else
    {
      vector2_3 = vector2_2 / num5;
      vector2_4 = vector2_1 / num5;
    }
    Vector2 vector2_5 = vector2_3 + rectangle.Center.ToVector2();
    for (int index = this.oldPos.Length - 1; index > 0; --index)
    {
      this.oldPos[index] = this.oldPos[index - 1];
      this.oldTangent[index] = this.oldTangent[index - 1];
    }
    this.oldPos[0] = vector2_5;
    this.oldTangent[0] = vector2_4;
  }

  private void DrawSpecialSeedRing()
  {
    MiscShaderData miscShaderData = GameShaders.Misc["RainbowRod"];
    miscShaderData.UseSaturation(this.trial);
    miscShaderData.UseOpacity(this._goBackTarget != this ? this.opacity2 : this.opacity);
    miscShaderData.UseSpriteTransformMatrix(new Matrix?(Main.UIScaleMatrix));
    miscShaderData.Apply(new DrawData?());
    float num1 = 4f;
    if (this._goBackTarget != this)
      num1 = 5f;
    int length = this.oldPos.Length;
    UIWorldCreation._vertexStrip.Reset(length * 2);
    int num2 = length;
    for (int index = 0; index < length && !(this.oldPos[index] == Vector2.Zero); ++index)
    {
      Vector2 oldPo = this.oldPos[index];
      float num3 = (float) index / (float) (num2 - 1) * 0.6f;
      Color vertexColor = this.StripColors(num3);
      float z = this.StripWidth(num3);
      Vector2 vector2 = this.oldTangent[index] * num1;
      Vector3 uvA = new Vector3(num3, z / 2f, z);
      Vector3 uvB = new Vector3(num3, z / 2f, z);
      UIWorldCreation._vertexStrip.AddVertexPair(oldPo + vector2, oldPo, uvA, uvB, vertexColor);
    }
    UIWorldCreation._vertexStrip.PrepareIndices(true);
    UIWorldCreation._vertexStrip.DrawTrail();
    Main.pixelShader.CurrentTechnique.Passes[0].Apply();
    miscShaderData.UseSpriteTransformMatrix(new Matrix?());
  }

  private Color StripColors(float progressOnStrip)
  {
    return Main.hslToRgb((float) (((double) progressOnStrip - (double) Main.GlobalTimeWrappedHourly * (double) this.animationSpeed) % 1.0), this.saturation, 0.5f) with
    {
      A = 0
    };
  }

  private float StripWidth(float progressOnStrip)
  {
    return 24f * Utils.GetLerpValue(0.0f, 0.2f, progressOnStrip, true);
  }

  public void DrawSeedSystems(SpriteBatch spriteBatch)
  {
    this.SeedDust.UpdateDust();
    this.SeedDust.DrawDust();
    this.SeedParticleSystem.Update();
    this.SeedParticleSystem.Draw(spriteBatch);
  }

  private void SetupGamepadPoints(SpriteBatch spriteBatch)
  {
    UILinkPointNavigator.Shortcuts.BackButtonCommand = 7;
    int num1 = 3000;
    List<SnapPoint> snapPoints = this.GetSnapPoints();
    SnapPoint snapPoint1 = (SnapPoint) null;
    SnapPoint snapPoint2 = (SnapPoint) null;
    SnapPoint snapPoint3 = (SnapPoint) null;
    SnapPoint snapPoint4 = (SnapPoint) null;
    SnapPoint snapPoint5 = (SnapPoint) null;
    SnapPoint snapPoint6 = (SnapPoint) null;
    for (int index = 0; index < snapPoints.Count; ++index)
    {
      SnapPoint snapPoint7 = snapPoints[index];
      switch (snapPoint7.Name)
      {
        case "Back":
          snapPoint1 = snapPoint7;
          break;
        case "Create":
          snapPoint2 = snapPoint7;
          break;
        case "Name":
          snapPoint3 = snapPoint7;
          break;
        case "Seed":
          snapPoint4 = snapPoint7;
          break;
        case "RandomizeName":
          snapPoint5 = snapPoint7;
          break;
        case "RandomizeSeed":
          snapPoint6 = snapPoint7;
          break;
      }
    }
    List<SnapPoint> snapGroup1 = this.GetSnapGroup(snapPoints, "size");
    List<SnapPoint> snapGroup2 = this.GetSnapGroup(snapPoints, "difficulty");
    List<SnapPoint> snapGroup3 = this.GetSnapGroup(snapPoints, "evil");
    UILinkPointNavigator.SetPosition(num1, snapPoint1.Position);
    UILinkPoint point1 = UILinkPointNavigator.Points[num1];
    point1.Unlink();
    UILinkPoint uiLinkPoint1 = point1;
    int num2 = num1 + 1;
    UILinkPointNavigator.SetPosition(num2, snapPoint2.Position);
    UILinkPoint point2 = UILinkPointNavigator.Points[num2];
    point2.Unlink();
    UILinkPoint uiLinkPoint2 = point2;
    int num3 = num2 + 1;
    UILinkPointNavigator.SetPosition(num3, snapPoint5.Position);
    UILinkPoint point3 = UILinkPointNavigator.Points[num3];
    point3.Unlink();
    UILinkPoint uiLinkPoint3 = point3;
    int num4 = num3 + 1;
    UILinkPointNavigator.SetPosition(num4, snapPoint3.Position);
    UILinkPoint point4 = UILinkPointNavigator.Points[num4];
    point4.Unlink();
    UILinkPoint uiLinkPoint4 = point4;
    int num5 = num4 + 1;
    UILinkPointNavigator.SetPosition(num5, snapPoint6.Position);
    UILinkPoint point5 = UILinkPointNavigator.Points[num5];
    point5.Unlink();
    UILinkPoint uiLinkPoint5 = point5;
    int num6 = num5 + 1;
    UILinkPointNavigator.SetPosition(num6, snapPoint4.Position);
    UILinkPoint point6 = UILinkPointNavigator.Points[num6];
    point6.Unlink();
    UILinkPoint uiLinkPoint6 = point6;
    int num7 = num6 + 1;
    UILinkPoint[] uiLinkPointArray1 = new UILinkPoint[snapGroup1.Count];
    for (int index = 0; index < snapGroup1.Count; ++index)
    {
      UILinkPointNavigator.SetPosition(num7, snapGroup1[index].Position);
      UILinkPoint point7 = UILinkPointNavigator.Points[num7];
      point7.Unlink();
      uiLinkPointArray1[index] = point7;
      ++num7;
    }
    UILinkPoint[] uiLinkPointArray2 = new UILinkPoint[snapGroup2.Count];
    for (int index = 0; index < snapGroup2.Count; ++index)
    {
      UILinkPointNavigator.SetPosition(num7, snapGroup2[index].Position);
      UILinkPoint point8 = UILinkPointNavigator.Points[num7];
      point8.Unlink();
      uiLinkPointArray2[index] = point8;
      ++num7;
    }
    UILinkPoint[] uiLinkPointArray3 = new UILinkPoint[snapGroup3.Count];
    for (int index = 0; index < snapGroup3.Count; ++index)
    {
      UILinkPointNavigator.SetPosition(num7, snapGroup3[index].Position);
      UILinkPoint point9 = UILinkPointNavigator.Points[num7];
      point9.Unlink();
      uiLinkPointArray3[index] = point9;
      ++num7;
    }
    this.LoopHorizontalLineLinks(uiLinkPointArray1);
    this.LoopHorizontalLineLinks(uiLinkPointArray2);
    this.EstablishUpDownRelationship(uiLinkPointArray1, uiLinkPointArray2);
    for (int index = 0; index < uiLinkPointArray1.Length; ++index)
      uiLinkPointArray1[index].Up = uiLinkPoint6.ID;
    if (true)
    {
      this.LoopHorizontalLineLinks(uiLinkPointArray3);
      this.EstablishUpDownRelationship(uiLinkPointArray2, uiLinkPointArray3);
      for (int index = 0; index < uiLinkPointArray3.Length; ++index)
        uiLinkPointArray3[index].Down = uiLinkPoint1.ID;
      uiLinkPointArray3[uiLinkPointArray3.Length - 1].Down = uiLinkPoint2.ID;
      uiLinkPoint2.Up = uiLinkPointArray3[uiLinkPointArray3.Length - 1].ID;
      uiLinkPoint1.Up = uiLinkPointArray3[0].ID;
    }
    else
    {
      for (int index = 0; index < uiLinkPointArray2.Length; ++index)
        uiLinkPointArray2[index].Down = uiLinkPoint1.ID;
      uiLinkPointArray2[uiLinkPointArray2.Length - 1].Down = uiLinkPoint2.ID;
      uiLinkPoint2.Up = uiLinkPointArray2[uiLinkPointArray2.Length - 1].ID;
      uiLinkPoint1.Up = uiLinkPointArray2[0].ID;
    }
    uiLinkPoint2.Left = uiLinkPoint1.ID;
    uiLinkPoint1.Right = uiLinkPoint2.ID;
    uiLinkPoint4.Down = uiLinkPoint6.ID;
    uiLinkPoint4.Left = uiLinkPoint3.ID;
    uiLinkPoint3.Right = uiLinkPoint4.ID;
    uiLinkPoint6.Up = uiLinkPoint4.ID;
    uiLinkPoint6.Down = uiLinkPointArray1[0].ID;
    uiLinkPoint6.Left = uiLinkPoint5.ID;
    uiLinkPoint5.Right = uiLinkPoint6.ID;
    uiLinkPoint5.Up = uiLinkPoint3.ID;
    uiLinkPoint5.Down = uiLinkPointArray1[0].ID;
    uiLinkPoint3.Down = uiLinkPoint5.ID;
  }

  private void EstablishUpDownRelationship(UILinkPoint[] topSide, UILinkPoint[] bottomSide)
  {
    int num = Math.Max(topSide.Length, bottomSide.Length);
    for (int val1 = 0; val1 < num; ++val1)
    {
      int index1 = Math.Min(val1, topSide.Length - 1);
      int index2 = Math.Min(val1, bottomSide.Length - 1);
      topSide[index1].Down = bottomSide[index2].ID;
      bottomSide[index2].Up = topSide[index1].ID;
    }
  }

  private void LoopHorizontalLineLinks(UILinkPoint[] pointsLine)
  {
    for (int index = 1; index < pointsLine.Length - 1; ++index)
    {
      pointsLine[index - 1].Right = pointsLine[index].ID;
      pointsLine[index].Left = pointsLine[index - 1].ID;
      pointsLine[index].Right = pointsLine[index + 1].ID;
      pointsLine[index + 1].Left = pointsLine[index].ID;
    }
  }

  private List<SnapPoint> GetSnapGroup(List<SnapPoint> ptsOnPage, string groupName)
  {
    List<SnapPoint> list = ptsOnPage.Where<SnapPoint>((Func<SnapPoint, bool>) (a => a.Name == groupName)).ToList<SnapPoint>();
    list.Sort(new Comparison<SnapPoint>(this.SortPoints));
    return list;
  }

  private int SortPoints(SnapPoint a, SnapPoint b) => a.Id.CompareTo(b.Id);

  public void AddSeedFromSeedmenu(string seed) => this._secretSeedTextsEntered.Add(seed);

  public void RemoveSeedFromSeedMenu(string seed) => this._secretSeedTextsEntered.Remove(seed);

  public void HandleBackButtonUsage() => UIWorldCreation.GoBack();

  private enum WorldSizeId
  {
    Small,
    Medium,
    Large,
  }

  private enum WorldDifficultyId
  {
    Normal,
    Expert,
    Master,
    Creative,
  }

  private enum WorldEvilId
  {
    Random,
    Corruption,
    Crimson,
  }

  public delegate void SubmitSeedEvent();
}
