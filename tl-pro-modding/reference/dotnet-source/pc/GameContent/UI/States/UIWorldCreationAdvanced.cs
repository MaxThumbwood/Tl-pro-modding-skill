// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.States.UIWorldCreationAdvanced
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using System.Collections.Generic;
using Terraria.Audio;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.Localization;
using Terraria.UI;
using Terraria.UI.Gamepad;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.UI.States;

public class UIWorldCreationAdvanced : UIState, IHaveBackButtonCommand
{
  private UIWorldCreation _creationState;
  private UIText _descriptionText;
  private UIText _titleText;
  private UICharacterNameButton _seedPlate;
  private UIElement _backButton;
  private UIElement _optionList;
  private UIElement _randomButton;
  private GroupOptionButton<AWorldGenerationOption>[] _seedButtons;
  private UIElement _seedButtonRegion;
  private GroupOptionButton<bool> _secretSeedButton;
  private bool _allowScrolling;
  private UIGamepadHelper _helper;

  public UIWorldCreationAdvanced(UIWorldCreation state, bool allowScrolling = false)
  {
    this._creationState = state;
    this._creationState.SubmitSeed = new UIWorldCreation.SubmitSeedEvent(this.UpdateContents);
    this._allowScrolling = allowScrolling;
    this.BuildPage();
    this.Prepare();
  }

  private void Prepare() => this.UpdateContents();

  private void UpdateContents()
  {
    this._creationState.FillSeedContent(this._seedPlate);
    foreach (GroupOptionButton<AWorldGenerationOption> seedButton in this._seedButtons)
      seedButton.SetCurrentOption(seedButton.OptionValue.Enabled ? seedButton.OptionValue : (AWorldGenerationOption) null);
  }

  private void BuildPage()
  {
    this.RemoveAllChildren();
    UIElement uiElement1 = new UIElement()
    {
      Width = StyleDimension.FromPixels(500f),
      Height = StyleDimension.FromPixelsAndPercent(-200f, 1f),
      Top = StyleDimension.FromPixels(202f),
      HAlign = 0.5f,
      VAlign = 0.0f
    };
    if (!this._allowScrolling)
      uiElement1.MaxHeight = StyleDimension.FromPixels(400f);
    uiElement1.SetPadding(0.0f);
    this.Append(uiElement1);
    UIPanel uiPanel = new UIPanel();
    uiPanel.Width = StyleDimension.FromPercent(1f);
    uiPanel.Height = StyleDimension.FromPixelsAndPercent(-102f, 1f);
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
    this.AddSeedButtons(uiElement);
    this.AddListArea(uiElement);
    this.AddDescriptionPanel(uiElement);
  }

  private void AddListArea(UIElement infoContainer)
  {
    int num1 = 0;
    UIList uiList1 = new UIList();
    uiList1.Width = StyleDimension.FromPixelsAndPercent(-48f, 1f);
    uiList1.Height = StyleDimension.FromPixelsAndPercent((float) (-138 - num1 * 2), 1f);
    uiList1.HAlign = 0.0f;
    uiList1.VAlign = 0.0f;
    uiList1.Top = StyleDimension.FromPixels((float) (44 + num1));
    uiList1.Left = StyleDimension.FromPixels(24f);
    UIList uiList2 = uiList1;
    int num2 = 4;
    UIScrollbar uiScrollbar1 = new UIScrollbar();
    uiScrollbar1.Height = StyleDimension.FromPixelsAndPercent((float) (-138 - num2 * 2), 1f);
    uiScrollbar1.Top = StyleDimension.FromPixels((float) (44 + num2));
    uiScrollbar1.HAlign = 1f;
    UIScrollbar uiScrollbar2 = uiScrollbar1;
    uiList2.SetScrollbar(uiScrollbar2);
    infoContainer.Append((UIElement) uiList2);
    if (this._allowScrolling)
      infoContainer.Append((UIElement) uiScrollbar2);
    this.AddSpecialSeedOptions(uiList2);
    this._optionList = (UIElement) uiList2;
  }

  public void RefreshSecretSeedButton()
  {
    bool flag = SecretSeedsTracker.SeedsForInterface.Count > 0 || this._creationState.HasEnteredSpecialSeed || this._creationState.HasDisabledSecretSeed;
    if (this._secretSeedButton == null & flag)
    {
      int length = this._seedButtons.Length;
      int num1 = length % 6;
      int num2 = length / 6;
      GroupOptionButton<bool> groupOptionButton = new GroupOptionButton<bool>(true, (LocalizedText) null, (LocalizedText) null, Color.White, (string) null);
      groupOptionButton.Width = StyleDimension.FromPixels(60f);
      groupOptionButton.Height = StyleDimension.FromPixels(60f);
      groupOptionButton.InnerHighlightRim = 4;
      groupOptionButton.HAlign = (float) num1 / 5f;
      groupOptionButton.Top = StyleDimension.FromPixelsAndPercent((float) (num2 * 67 + 3), 0.0f);
      groupOptionButton.ShowHighlightWhenSelected = true;
      this._secretSeedButton = groupOptionButton;
      this._secretSeedButton.SetCurrentOption(this._creationState.HasEnteredSpecialSeed);
      UIImage uiImage = new UIImage(Main.Assets.Request<Texture2D>("Images/UI/WorldCreation/Seed_Secret", (AssetRequestMode) 1).Value);
      uiImage.Left = StyleDimension.FromPixels(-1f);
      UIImage element = uiImage;
      element.OnUpdate += new UIElement.ElementEvent(this.UpdateIconOpacity);
      this._secretSeedButton.Append((UIElement) element);
      this._secretSeedButton.SetSnapPoint("seeds", length);
      this._secretSeedButton.OnMouseOver += new UIElement.MouseEvent(this.ShowSecretSeedDescription);
      this._secretSeedButton.OnMouseOut += new UIElement.MouseEvent(this.ClearOptionDescription);
      this._secretSeedButton.OnDraw += new UIElement.DrawEvent(this._creationState.DrawSpecialSeedRingCallback);
      this._secretSeedButton.OnLeftClick += new UIElement.MouseEvent(this.SecretSeedButton_OnLeftClick);
      this._seedButtonRegion.Append((UIElement) this._secretSeedButton);
    }
    else if (this._secretSeedButton != null && !flag)
    {
      this._seedButtonRegion.RemoveChild((UIElement) this._secretSeedButton);
      this._secretSeedButton = (GroupOptionButton<bool>) null;
    }
    else
    {
      if (this._secretSeedButton == null)
        return;
      this._secretSeedButton.SetCurrentOption(this._creationState.HasEnteredSpecialSeed);
    }
  }

  private void SecretSeedButton_OnLeftClick(UIMouseEvent evt, UIElement listeningElement)
  {
    UIWorldCreationAdvancedSecretSeedsList state = new UIWorldCreationAdvancedSecretSeedsList(this, this._creationState);
    Main.MenuUI.SetState((UIState) state);
    SoundEngine.PlaySound(12);
  }

  private void AddSpecialSeedOptions(UIList listArea)
  {
    int num1 = 6;
    GroupOptionButton<AWorldGenerationOption>[] groupOptionButtonArray = this.PrepareSeedButtons();
    this._seedButtons = groupOptionButtonArray;
    this._seedButtonRegion = new UIElement()
    {
      Width = StyleDimension.FromPercent(1f),
      Height = StyleDimension.FromPixels((float) (Math.Ceiling((double) groupOptionButtonArray.Length / (double) num1) * 70.0 - 10.0))
    };
    listArea.Add(this._seedButtonRegion);
    for (int id = 0; id < groupOptionButtonArray.Length; ++id)
    {
      GroupOptionButton<AWorldGenerationOption> element = groupOptionButtonArray[id];
      int num2 = id % 6;
      int num3 = id / 6;
      element.HAlign = (float) num2 / 5f;
      element.Top.Set((float) (num3 * 67 + 3), 0.0f);
      element.OnLeftMouseDown += new UIElement.MouseEvent(this.ClickSeedOption);
      element.SetSnapPoint("seeds", id);
      this._seedButtonRegion.Append((UIElement) element);
      groupOptionButtonArray[id] = element;
    }
    this.RefreshSecretSeedButton();
  }

  private GroupOptionButton<AWorldGenerationOption>[] PrepareSeedButtons()
  {
    List<GroupOptionButton<AWorldGenerationOption>> groupOptionButtonList = new List<GroupOptionButton<AWorldGenerationOption>>();
    foreach (AWorldGenerationOption option in WorldGenerationOptions.Options)
    {
      option.Load();
      groupOptionButtonList.Add(this.CreateButton(new UIWorldCreationAdvanced.WorldSpecialSeedOption()
      {
        Seed = option,
        Description = option.Description,
        Title = option.Title,
        Element = option.ProvideUIElement()
      }));
    }
    return groupOptionButtonList.ToArray();
  }

  private void ClickSeedOption(UIMouseEvent evt, UIElement listeningElement)
  {
    this._creationState.ToggleSeedOption(((GroupOptionButton<AWorldGenerationOption>) listeningElement).OptionValue);
    this.UpdateContents();
  }

  private GroupOptionButton<AWorldGenerationOption> CreateButton(
    UIWorldCreationAdvanced.WorldSpecialSeedOption option)
  {
    GroupOptionButton<AWorldGenerationOption> groupOptionButton = new GroupOptionButton<AWorldGenerationOption>(option.Seed, (LocalizedText) null, option.Description, Color.White, (string) null, titleAlignmentX: 1f, titleWidthReduction: 16f);
    groupOptionButton.Width = StyleDimension.FromPixels(60f);
    groupOptionButton.Height = StyleDimension.FromPixels(60f);
    groupOptionButton.InnerHighlightRim = 4;
    GroupOptionButton<AWorldGenerationOption> button = groupOptionButton;
    button.OnMouseOver += (UIElement.MouseEvent) ((evt, elem) => this.ShowOptionDescription(option.Description, option.Title));
    button.OnMouseOut += new UIElement.MouseEvent(this.ClearOptionDescription);
    UIElement element1 = option.Element;
    element1.OnUpdate += new UIElement.ElementEvent(this.UpdateIconOpacity);
    button.Append(element1);
    if (false)
    {
      UIImage uiImage = new UIImage(Main.Assets.Request<Texture2D>("Images/UI/IconCompletion", (AssetRequestMode) 1));
      uiImage.HAlign = 0.5f;
      uiImage.VAlign = 0.5f;
      uiImage.Top = new StyleDimension(-9f, 0.0f);
      uiImage.Left = new StyleDimension(-3f, 0.0f);
      uiImage.IgnoresMouseInteraction = true;
      UIImage element2 = uiImage;
      button.Append((UIElement) element2);
    }
    return button;
  }

  private void UpdateIconOpacity(UIElement affectedElement)
  {
    if (!(affectedElement.Parent is GroupOptionButton<AWorldGenerationOption> parent))
      return;
    float num = 0.5f;
    bool flag = parent.IsSelected || parent.IsMouseHovering;
    if (affectedElement is UIImage uiImage)
    {
      Color color = flag ? Color.White : Color.White * num;
      uiImage.Color = color;
    }
    if (!(affectedElement is UIImageFramed uiImageFramed))
      return;
    Color color1 = flag ? Color.White : Color.White * num;
    uiImageFramed.Color = color1;
  }

  private void AddDescriptionPanel(UIElement container)
  {
    float num = 0.0f;
    UISlicedImage uiSlicedImage = new UISlicedImage(Main.Assets.Request<Texture2D>("Images/UI/CharCreation/CategoryPanelHighlight", (AssetRequestMode) 1));
    uiSlicedImage.HAlign = 0.5f;
    uiSlicedImage.VAlign = 1f;
    uiSlicedImage.Width = StyleDimension.FromPixelsAndPercent((float) (-(double) num * 2.0), 1f);
    uiSlicedImage.Left = StyleDimension.FromPixels(-num);
    uiSlicedImage.Height = StyleDimension.FromPixelsAndPercent(88f, 0.0f);
    uiSlicedImage.Top = StyleDimension.FromPixels(2f);
    UISlicedImage element1 = uiSlicedImage;
    element1.SetSliceDepths(10);
    element1.Color = Color.LightGray * 0.7f;
    container.Append((UIElement) element1);
    UIText uiText1 = new UIText(Language.GetText("UI.WorldDescriptionDefault"), 0.82f);
    uiText1.HAlign = 0.0f;
    uiText1.VAlign = 0.0f;
    uiText1.Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f);
    uiText1.Height = StyleDimension.FromPixelsAndPercent(24f, 0.0f);
    uiText1.Top = StyleDimension.FromPixelsAndPercent(0.0f, 0.0f);
    uiText1.PaddingLeft = 20f;
    uiText1.PaddingRight = 20f;
    uiText1.PaddingTop = 6f;
    UIText element2 = uiText1;
    element1.Append((UIElement) element2);
    this._titleText = element2;
    UIHorizontalSeparator horizontalSeparator = new UIHorizontalSeparator();
    horizontalSeparator.Width = StyleDimension.FromPercent(1f);
    horizontalSeparator.Top = StyleDimension.FromPixels(22f);
    horizontalSeparator.VAlign = 0.0f;
    horizontalSeparator.Color = new Color(131, 135, 183, (int) byte.MaxValue);
    UIHorizontalSeparator element3 = horizontalSeparator;
    element1.Append((UIElement) element3);
    UIText uiText2 = new UIText(Language.GetText("UI.WorldDescriptionDefault"), 0.7f);
    uiText2.HAlign = 0.0f;
    uiText2.VAlign = 0.0f;
    uiText2.Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f);
    uiText2.Height = StyleDimension.FromPixelsAndPercent(-30f, 1f);
    uiText2.Top = StyleDimension.FromPixelsAndPercent(25f, 0.0f);
    uiText2.PaddingLeft = 20f;
    uiText2.PaddingRight = 20f;
    uiText2.PaddingTop = 6f;
    uiText2.IsWrapped = true;
    UIText element4 = uiText2;
    element1.Append((UIElement) element4);
    this._descriptionText = element4;
  }

  private void ShowOptionDescription(UIMouseEvent evt, UIElement listeningElement)
  {
    LocalizedText description = (LocalizedText) null;
    if (listeningElement is UICharacterNameButton characterNameButton)
      description = characterNameButton.Description;
    if (listeningElement is GroupOptionButton<bool> groupOptionButton)
      description = groupOptionButton.Description;
    if (description == null)
      return;
    this.ShowOptionDescription(description, Language.Exists(description.Key + "_Title") ? Language.GetText(description.Key + "_Title") : (LocalizedText) null);
  }

  private void ShowSecretSeedDescription(UIMouseEvent evt, UIElement listeningElement)
  {
    this._descriptionText.SetText(this._creationState.GetJoinedSecretSeedString(FontAssets.MouseText.Value, this._descriptionText.GetInnerDimensions().Width / 0.7f, this._descriptionText.GetInnerDimensions().Height / 0.7f));
    this._titleText.SetText(Language.GetText("UI.WorldDescriptionSecretSeeds_Title"));
  }

  private void ShowOptionDescription(LocalizedText description, LocalizedText title)
  {
    this._descriptionText.SetText(description);
    if (title == null)
      return;
    this._titleText.SetText(title);
  }

  private void ClearOptionDescription(UIMouseEvent evt, UIElement listeningElement)
  {
    this.ShowOptionDescription(Language.GetText("UI.WorldDescriptionDefault"), Language.GetText("UI.WorldDescriptionDefault_Title"));
  }

  private void AddSeedButtons(UIElement infoContainer)
  {
    float num1 = 44f;
    float num2 = (float) (0.0 + (double) num1);
    float pixels1 = num1;
    float pixels2 = 0.0f;
    GroupOptionButton<bool> groupOptionButton = new GroupOptionButton<bool>(true, (LocalizedText) null, Language.GetText("UI.WorldCreationRandomizeSeedDescription"), Color.White, (string) null);
    groupOptionButton.Width = StyleDimension.FromPixelsAndPercent(40f, 0.0f);
    groupOptionButton.Height = new StyleDimension(40f, 0.0f);
    groupOptionButton.HAlign = 0.0f;
    groupOptionButton.Top = StyleDimension.FromPixelsAndPercent(pixels2, 0.0f);
    groupOptionButton.ShowHighlightWhenSelected = false;
    GroupOptionButton<bool> element1 = groupOptionButton;
    UIImage uiImage = new UIImage(Main.Assets.Request<Texture2D>("Images/UI/WorldCreation/IconEvilRandom", (AssetRequestMode) 1));
    uiImage.IgnoresMouseInteraction = true;
    uiImage.HAlign = 0.5f;
    uiImage.VAlign = 0.5f;
    UIImage element2 = uiImage;
    element1.Append((UIElement) element2);
    element1.OnLeftMouseDown += new UIElement.MouseEvent(this.ClickRandomizeSeed);
    element1.OnMouseOver += new UIElement.MouseEvent(this.ShowOptionDescription);
    element1.OnMouseOut += new UIElement.MouseEvent(this.ClearOptionDescription);
    element1.SetSnapPoint("RandomizeSeed", 0);
    infoContainer.Append((UIElement) element1);
    this._randomButton = (UIElement) element1;
    UICharacterNameButton characterNameButton = new UICharacterNameButton(Language.GetText("UI.WorldCreationSeed"), Language.GetText("UI.WorldCreationSeedEmpty"), Language.GetText("UI.WorldDescriptionSeed"));
    characterNameButton.Width = StyleDimension.FromPixelsAndPercent(-num2, 1f);
    characterNameButton.HAlign = 0.0f;
    characterNameButton.Left = new StyleDimension(pixels1, 0.0f);
    characterNameButton.Top = StyleDimension.FromPixelsAndPercent(pixels2, 0.0f);
    characterNameButton.DistanceFromTitleToOption = 29f;
    UICharacterNameButton element3 = characterNameButton;
    element3.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_SetSeed);
    element3.OnMouseOver += new UIElement.MouseEvent(this.ShowOptionDescription);
    element3.OnMouseOut += new UIElement.MouseEvent(this.ClearOptionDescription);
    element3.SetSnapPoint("Seed", 0);
    infoContainer.Append((UIElement) element3);
    this._seedPlate = element3;
  }

  private void ClickRandomizeSeed(UIMouseEvent evt, UIElement listeningElement)
  {
    this._creationState.RandomizeSeed();
    this.UpdateContents();
  }

  private void Click_SetSeed(UIMouseEvent evt, UIElement listeningElement)
  {
    this._creationState.OpenSeedInputMenu();
  }

  private void MakeBackAndCreatebuttons(UIElement outerContainer)
  {
    UITextPanel<LocalizedText> uiTextPanel = new UITextPanel<LocalizedText>(Language.GetText("UI.Apply"), 0.65f, true);
    uiTextPanel.Width = StyleDimension.FromPixelsAndPercent(-10f, 0.5f);
    uiTextPanel.Height = StyleDimension.FromPixels(50f);
    uiTextPanel.VAlign = 1f;
    uiTextPanel.HAlign = 0.5f;
    uiTextPanel.Top = StyleDimension.FromPixels(-43f);
    UITextPanel<LocalizedText> element = uiTextPanel;
    element.OnMouseOver += new UIElement.MouseEvent(this.FadedMouseOver);
    element.OnMouseOut += new UIElement.MouseEvent(this.FadedMouseOut);
    element.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_GoBack);
    element.SetSnapPoint("Back", 0);
    outerContainer.Append((UIElement) element);
    this._backButton = (UIElement) element;
  }

  private void Click_GoBack(UIMouseEvent evt, UIElement listeningElement) => this.GoBack();

  private void GoBack()
  {
    this._creationState.ResetSpecialSeedRing();
    this._creationState.SetGoBackTarget((UIState) this._creationState);
    SoundEngine.PlaySound(11);
    Main.MenuUI.SetState((UIState) this._creationState);
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

  public override void Draw(SpriteBatch spriteBatch)
  {
    base.Draw(spriteBatch);
    this.SetupGamepadPoints(spriteBatch);
    this._creationState.DrawSeedSystems(spriteBatch);
  }

  private void SetupGamepadPoints(SpriteBatch spriteBatch)
  {
    UILinkPointNavigator.Shortcuts.BackButtonCommand = 7;
    int idRangeStartInclusive = 3000;
    int num1 = idRangeStartInclusive;
    this.GetSnapPoints();
    ref UIGamepadHelper local1 = ref this._helper;
    int id1 = num1;
    int num2 = id1 + 1;
    UIElement backButton = this._backButton;
    UILinkPoint linkPoint1 = local1.GetLinkPoint(id1, backButton);
    ref UIGamepadHelper local2 = ref this._helper;
    int id2 = num2;
    int num3 = id2 + 1;
    UICharacterNameButton seedPlate = this._seedPlate;
    UILinkPoint linkPoint2 = local2.GetLinkPoint(id2, (UIElement) seedPlate);
    ref UIGamepadHelper local3 = ref this._helper;
    int id3 = num3;
    int currentID = id3 + 1;
    UIElement randomButton = this._randomButton;
    UILinkPoint linkPoint3 = local3.GetLinkPoint(id3, randomButton);
    List<SnapPoint> snapPoints = this._optionList.GetSnapPoints();
    UILinkPoint[,] uiLinkPointGrid = this._helper.CreateUILinkPointGrid(ref currentID, snapPoints, 6, linkPoint2, (UILinkPoint) null, (UILinkPoint) null, linkPoint1);
    this._helper.PairLeftRight(linkPoint3, linkPoint2);
    UILinkPoint downSide = uiLinkPointGrid[0, 0];
    this._helper.PairUpDown(linkPoint3, downSide);
    this._helper.PairUpDown(linkPoint2, downSide);
    this._helper.PairUpDown(uiLinkPointGrid[0, uiLinkPointGrid.GetLength(1) - 1], linkPoint1);
    this._helper.MoveToVisuallyClosestPoint(idRangeStartInclusive, currentID);
  }

  public GroupOptionButton<bool> GetSecretSeedButton() => this._secretSeedButton;

  public void HandleBackButtonUsage() => this.GoBack();

  private struct WorldSpecialSeedOption
  {
    public AWorldGenerationOption Seed;
    public UIElement Element;
    public LocalizedText Description;
    public LocalizedText Title;
  }
}
