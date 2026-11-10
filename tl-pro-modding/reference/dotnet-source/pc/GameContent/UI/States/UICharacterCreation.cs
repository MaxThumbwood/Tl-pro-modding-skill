// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.States.UICharacterCreation
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using ReLogic.Content;
using ReLogic.OS;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.GameContent.UI.Elements;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.Initializers;
using Terraria.IO;
using Terraria.Localization;
using Terraria.UI;
using Terraria.UI.Gamepad;

#nullable disable
namespace Terraria.GameContent.UI.States;

public class UICharacterCreation : UIState, IHaveBackButtonCommand
{
  private int[] _validClothStyles = new int[10]
  {
    0,
    2,
    1,
    3,
    8,
    9,
    7,
    5,
    6,
    4
  };
  private Dictionary<int, int> _defaultHairstylesForClothStyle = new Dictionary<int, int>()
  {
    {
      0,
      0
    },
    {
      2,
      1
    },
    {
      1,
      12
    },
    {
      3,
      2
    },
    {
      8,
      28
    },
    {
      9,
      68
    },
    {
      7,
      18
    },
    {
      5,
      22
    },
    {
      6,
      81
    },
    {
      4,
      5
    }
  };
  private int[] _validVoiceStyles = new int[3]{ 1, 2, 3 };
  private readonly Player _player;
  private UIColoredImageButton[] _colorPickers;
  private UICharacterCreation.CategoryId _selectedPicker;
  private Vector3 _currentColorHSL;
  private UIColoredImageButton _clothingStylesCategoryButton;
  private UIColoredImageButton _hairStylesCategoryButton;
  private UIColoredImageButton _charInfoCategoryButton;
  private UIElement _topContainer;
  private UIElement _middleContainer;
  private UIElement _hslContainer;
  private UIElement _hairstylesContainer;
  private UIElement _clothStylesContainer;
  private UIElement _infoContainer;
  private UIText _hslHexText;
  private UIText _difficultyDescriptionText;
  private UIElement _copyHexButton;
  private UIElement _pasteHexButton;
  private UIElement _randomColorButton;
  private UIElement _copyTemplateButton;
  private UIElement _pasteTemplateButton;
  private UIElement _randomizePlayerButton;
  private UIElement _pitchSlider;
  private UIElement _voiceNext;
  private UIElement _voicePrevious;
  private UIElement _voicePlay;
  private float _pitchAmount;
  private UIElement[] _previewArmorButton = new UIElement[0];
  private UICharacterNameButton _charName;
  private UIText _helpGlyphLeft;
  private UIText _helpGlyphRight;
  private bool _oldMaleForVoiceAutoSwitch = true;
  private int? _lastSelectedHairstyle;
  private UIImageFramed[] _characterPreviewLayers = new UIImageFramed[7];
  public const int MAX_NAME_LENGTH = 20;
  private bool _playedVoicePreviewThisFrame;
  private UICharacterCreation.ArmorAssignments _maleArmor;
  private UICharacterCreation.ArmorAssignments _femaleArmor;
  private GameTipsDisplay _tips;
  public static UIState BackupConfirmationState;
  private static bool dirty;
  private string initialState;
  private bool _pitchChanged;
  private int _pitchChangedCooldown;
  private UIGamepadHelper _helper;
  private List<int> _foundPoints = new List<int>();

  public UICharacterCreation(Player player)
  {
    this._player = player;
    this._player.difficulty = (byte) 0;
    this._tips = new GameTipsDisplay((ITipProvider) new CharacterCreationTipsProvider());
    this.BuildPage();
    this.initialState = this.GetPlayerTemplateValues();
    UICharacterCreation.dirty = false;
  }

  public override void Update(GameTime gameTime)
  {
    this._playedVoicePreviewThisFrame = false;
    base.Update(gameTime);
  }

  private void BuildPage()
  {
    this.RemoveAllChildren();
    int num = 4;
    UIElement uiElement1 = new UIElement()
    {
      Width = StyleDimension.FromPixels(500f),
      Height = StyleDimension.FromPixels((float) (380 + num)),
      Top = StyleDimension.FromPixels(220f),
      HAlign = 0.5f,
      VAlign = 0.0f
    };
    uiElement1.SetPadding(0.0f);
    this.Append(uiElement1);
    UIPanel uiPanel1 = new UIPanel();
    uiPanel1.Width = StyleDimension.FromPercent(1f);
    uiPanel1.Height = StyleDimension.FromPixels(uiElement1.Height.Pixels - 150f - (float) num);
    uiPanel1.Top = StyleDimension.FromPixels(50f);
    uiPanel1.BackgroundColor = new Color(33, 43, 79) * 0.8f;
    UIPanel uiPanel2 = uiPanel1;
    uiPanel2.SetPadding(0.0f);
    uiElement1.Append((UIElement) uiPanel2);
    this.MakeBackAndCreatebuttons(uiElement1);
    this.MakeCharPreview(uiPanel2);
    UIElement uiElement2 = new UIElement()
    {
      Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f),
      Height = StyleDimension.FromPixelsAndPercent(50f, 0.0f)
    };
    uiElement2.SetPadding(0.0f);
    uiElement2.PaddingTop = 4f;
    uiElement2.PaddingBottom = 0.0f;
    uiPanel2.Append(uiElement2);
    UIElement uiElement3 = new UIElement()
    {
      Top = StyleDimension.FromPixelsAndPercent(uiElement2.Height.Pixels + 6f, 0.0f),
      Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f),
      Height = StyleDimension.FromPixelsAndPercent(uiPanel2.Height.Pixels - 70f, 0.0f)
    };
    uiElement3.SetPadding(0.0f);
    uiElement3.PaddingTop = 3f;
    uiElement3.PaddingBottom = 0.0f;
    uiPanel2.Append(uiElement3);
    this._topContainer = uiElement2;
    this._middleContainer = uiElement3;
    this.MakeInfoMenu(uiElement3);
    this.MakeHSLMenu(uiElement3);
    this.MakeHairsylesMenu(uiElement3);
    this.MakeClothStylesMenu(uiElement3);
    this.MakeCategoriesBar(uiElement2);
    this.Click_CharInfo((UIMouseEvent) null, (UIElement) null);
  }

  private void MakeCharPreview(UIPanel container)
  {
    float num1 = 70f;
    for (float num2 = 0.0f; (double) num2 < 1.0; ++num2)
    {
      UICharacter uiCharacter = new UICharacter(this._player, true, false, 1.5f);
      uiCharacter.Width = StyleDimension.FromPixels(80f);
      uiCharacter.Height = StyleDimension.FromPixelsAndPercent(80f, 0.0f);
      uiCharacter.Top = StyleDimension.FromPixelsAndPercent(-num1, 0.0f);
      uiCharacter.VAlign = 0.0f;
      uiCharacter.HAlign = 0.5f;
      UICharacter element = uiCharacter;
      element.PrepareAction = new Action(this.PreparePreview_Main);
      container.Append((UIElement) element);
    }
  }

  private void MakeHairsylesMenu(UIElement middleInnerPanel)
  {
    Main.Hairstyles.UpdateUnlocks();
    UIElement element1 = new UIElement()
    {
      Width = StyleDimension.FromPixelsAndPercent(-10f, 1f),
      Height = StyleDimension.FromPixelsAndPercent(0.0f, 1f),
      HAlign = 0.5f,
      VAlign = 0.5f,
      Top = StyleDimension.FromPixels(6f)
    };
    middleInnerPanel.Append(element1);
    element1.SetPadding(0.0f);
    UIList uiList = new UIList();
    uiList.Width = StyleDimension.FromPixelsAndPercent(-18f, 1f);
    uiList.Height = StyleDimension.FromPixelsAndPercent(-6f, 1f);
    UIList element2 = uiList;
    element2.SetPadding(4f);
    element1.Append((UIElement) element2);
    UIScrollbar uiScrollbar1 = new UIScrollbar();
    uiScrollbar1.HAlign = 1f;
    uiScrollbar1.Height = StyleDimension.FromPixelsAndPercent(-30f, 1f);
    uiScrollbar1.Top = StyleDimension.FromPixels(10f);
    UIScrollbar uiScrollbar2 = uiScrollbar1;
    uiScrollbar2.SetView(100f, 1000f);
    element2.SetScrollbar(uiScrollbar2);
    element1.Append((UIElement) uiScrollbar2);
    int count = Main.Hairstyles.AvailableHairstyles.Count;
    UIElement uiElement = new UIElement()
    {
      Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f),
      Height = StyleDimension.FromPixelsAndPercent((float) (48 /*0x30*/ * (count / 10 + (count % 10 == 0 ? 0 : 1))), 0.0f)
    };
    element2.Add(uiElement);
    uiElement.SetPadding(0.0f);
    for (int index = 0; index < count; ++index)
    {
      UIHairStyleButton uiHairStyleButton = new UIHairStyleButton(this._player, Main.Hairstyles.AvailableHairstyles[index]);
      uiHairStyleButton.Left = StyleDimension.FromPixels((float) ((double) (index % 10) * 46.0 + 6.0));
      uiHairStyleButton.Top = StyleDimension.FromPixels((float) ((double) (index / 10) * 48.0 + 1.0));
      UIHairStyleButton element3 = uiHairStyleButton;
      element3.SetSnapPoint("Middle", index);
      element3.SkipRenderingContent(index);
      element3.OnLeftMouseDown += new UIElement.MouseEvent(this.RecordThatHairWasSelected);
      uiElement.Append((UIElement) element3);
    }
    this._hairstylesContainer = element1;
  }

  private void RecordThatHairWasSelected(UIMouseEvent evt, UIElement listeningElement)
  {
    this._lastSelectedHairstyle = new int?(this._player.hair);
  }

  private void MakeClothStylesMenu(UIElement middleInnerPanel)
  {
    UIElement element1 = new UIElement()
    {
      Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f),
      Height = StyleDimension.FromPixelsAndPercent(0.0f, 1f),
      HAlign = 0.5f,
      VAlign = 0.5f
    };
    middleInnerPanel.Append(element1);
    element1.SetPadding(0.0f);
    int pixels1 = 0;
    for (int id = 0; id < this._validClothStyles.Length; ++id)
    {
      int num1 = 19;
      int num2 = id < this._validClothStyles.Length / 2 ? num1 - 8 : num1 + 10;
      UIClothStyleButton clothStyleButton = new UIClothStyleButton(this._player, this._validClothStyles[id], new Action(this.PreparePreview_ClothStyle));
      clothStyleButton.Left = StyleDimension.FromPixels((float) id * 46f + (float) num2);
      clothStyleButton.Top = StyleDimension.FromPixels((float) pixels1);
      UIClothStyleButton element2 = clothStyleButton;
      element2.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_CharClothStyle);
      element2.SetSnapPoint("Middle", id);
      element1.Append((UIElement) element2);
    }
    int num = 15;
    int pixels2 = 60;
    UIElement element3 = new UIElement()
    {
      Width = StyleDimension.FromPixels(170f),
      Height = StyleDimension.FromPixels(50f),
      HAlign = 0.0f,
      Left = new StyleDimension((float) pixels2 - 34f, 0.5f),
      VAlign = 1f,
      Top = StyleDimension.FromPixels((float) (-num - 7))
    };
    element1.Append(element3);
    UIColoredImageButton coloredImageButton1 = new UIColoredImageButton(Main.Assets.Request<Texture2D>("Images/Item_" + (object) (short) 271, (AssetRequestMode) 1), true);
    coloredImageButton1.VAlign = 0.5f;
    coloredImageButton1.HAlign = 0.0f;
    coloredImageButton1.Left = StyleDimension.FromPixelsAndPercent(0.0f, 0.0f);
    UIColoredImageButton element4 = coloredImageButton1;
    element4.SetColor(this._player.hairColor);
    element4.OnLeftMouseDown += new UIElement.MouseEvent(this.EquipArmorNone);
    element3.Append((UIElement) element4);
    UIColoredImageButton coloredImageButton2 = new UIColoredImageButton(Main.Assets.Request<Texture2D>("Images/Item_" + (object) (short) 5660, (AssetRequestMode) 1), true);
    coloredImageButton2.VAlign = 0.5f;
    coloredImageButton2.HAlign = 0.5f;
    UIColoredImageButton element5 = coloredImageButton2;
    element5.OnLeftMouseDown += new UIElement.MouseEvent(this.EquipArmorHallowed);
    element3.Append((UIElement) element5);
    UIColoredImageButton coloredImageButton3 = new UIColoredImageButton(Main.Assets.Request<Texture2D>("Images/Item_" + (object) (short) 91, (AssetRequestMode) 1), true);
    coloredImageButton3.VAlign = 0.5f;
    coloredImageButton3.HAlign = 0.25f;
    UIColoredImageButton element6 = coloredImageButton3;
    element6.OnLeftMouseDown += new UIElement.MouseEvent(this.EquipArmorSilver);
    element3.Append((UIElement) element6);
    UIColoredImageButton coloredImageButton4 = new UIColoredImageButton(Main.Assets.Request<Texture2D>("Images/Item_" + (object) (short) 239, (AssetRequestMode) 1), true);
    coloredImageButton4.VAlign = 0.5f;
    coloredImageButton4.HAlign = 0.75f;
    UIColoredImageButton element7 = coloredImageButton4;
    element7.OnLeftMouseDown += new UIElement.MouseEvent(this.EquipArmorFormal);
    element3.Append((UIElement) element7);
    UIColoredImageButton coloredImageButton5 = new UIColoredImageButton(Main.Assets.Request<Texture2D>("Images/Item_" + (object) (short) 237, (AssetRequestMode) 1), true);
    coloredImageButton5.VAlign = 0.5f;
    coloredImageButton5.HAlign = 1f;
    UIColoredImageButton element8 = coloredImageButton5;
    element8.OnLeftMouseDown += new UIElement.MouseEvent(this.EquipArmorSwimming);
    element3.Append((UIElement) element8);
    this._previewArmorButton = new UIElement[5];
    this._previewArmorButton[0] = (UIElement) element4;
    this._previewArmorButton[1] = (UIElement) element5;
    this._previewArmorButton[2] = (UIElement) element6;
    this._previewArmorButton[3] = (UIElement) element7;
    this._previewArmorButton[4] = (UIElement) element8;
    this._previewArmorButton[0].SetSnapPoint("Preview", 0);
    this._previewArmorButton[2].SetSnapPoint("Preview", 1);
    this._previewArmorButton[1].SetSnapPoint("Preview", 2);
    this._previewArmorButton[3].SetSnapPoint("Preview", 3);
    this._previewArmorButton[4].SetSnapPoint("Preview", 4);
    UIElement element9 = new UIElement()
    {
      Width = StyleDimension.FromPixels(100f),
      Height = StyleDimension.FromPixels(50f),
      HAlign = 0.0f,
      Left = new StyleDimension((float) pixels2, 0.5f),
      VAlign = 1f,
      Top = StyleDimension.FromPixels((float) (-num + 38 - 9))
    };
    element1.Append(element9);
    UIColoredImageButton coloredImageButton6 = new UIColoredImageButton(Main.Assets.Request<Texture2D>("Images/UI/CharCreation/Copy", (AssetRequestMode) 1), true);
    coloredImageButton6.VAlign = 0.5f;
    coloredImageButton6.HAlign = 0.0f;
    coloredImageButton6.Left = StyleDimension.FromPixelsAndPercent(0.0f, 0.0f);
    UIColoredImageButton element10 = coloredImageButton6;
    element10.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_CopyPlayerTemplate);
    element9.Append((UIElement) element10);
    this._copyTemplateButton = (UIElement) element10;
    UIColoredImageButton coloredImageButton7 = new UIColoredImageButton(Main.Assets.Request<Texture2D>("Images/UI/CharCreation/Paste", (AssetRequestMode) 1), true);
    coloredImageButton7.VAlign = 0.5f;
    coloredImageButton7.HAlign = 0.5f;
    UIColoredImageButton element11 = coloredImageButton7;
    element11.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_PastePlayerTemplate);
    element9.Append((UIElement) element11);
    this._pasteTemplateButton = (UIElement) element11;
    UIColoredImageButton coloredImageButton8 = new UIColoredImageButton(Main.Assets.Request<Texture2D>("Images/UI/CharCreation/Randomize", (AssetRequestMode) 1), true);
    coloredImageButton8.VAlign = 0.5f;
    coloredImageButton8.HAlign = 1f;
    UIColoredImageButton element12 = coloredImageButton8;
    element12.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_RandomizePlayer);
    element9.Append((UIElement) element12);
    this._randomizePlayerButton = (UIElement) element12;
    UIElement element13 = new UIElement()
    {
      Width = StyleDimension.FromPixels(90f),
      Height = StyleDimension.FromPixels(50f),
      HAlign = 1f,
      Left = new StyleDimension((float) -pixels2, -0.5f),
      VAlign = 1f,
      Top = StyleDimension.FromPixels((float) -num)
    };
    element1.Append(element13);
    UIHorizontalSeparator horizontalSeparator = new UIHorizontalSeparator();
    horizontalSeparator.Width = StyleDimension.FromPixelsAndPercent(-38f, 1f);
    horizontalSeparator.HAlign = 0.5f;
    horizontalSeparator.VAlign = 1f;
    horizontalSeparator.Top = StyleDimension.FromPixelsAndPercent((float) (-52 - num), 0.0f);
    horizontalSeparator.Left = new StyleDimension(-3f, 0.0f);
    horizontalSeparator.Color = Color.Lerp(Color.White, new Color(63 /*0x3F*/, 65, 151, (int) byte.MaxValue), 0.85f) * 0.9f;
    UIHorizontalSeparator element14 = horizontalSeparator;
    element1.Append((UIElement) element14);
    Asset<Texture2D> asset1 = Main.Assets.Request<Texture2D>("Images/UI/TexturePackButtons", (AssetRequestMode) 1);
    Asset<Texture2D> asset2 = Main.Assets.Request<Texture2D>("Images/UI/TexturePackButtonsOutline", (AssetRequestMode) 1);
    UIImageButton uiImageButton1 = new UIImageButton(asset1, new Rectangle?(asset1.Frame(2, 2, frameY: 1)));
    uiImageButton1.VAlign = 0.5f;
    uiImageButton1.HAlign = 0.0f;
    uiImageButton1.Left = StyleDimension.FromPixelsAndPercent(0.0f, 0.0f);
    uiImageButton1.BorderColor = Main.OurFavoriteColor;
    UIImageButton element15 = uiImageButton1;
    element15.SetVisibility(1f, 1f);
    element15.SetHoverImage(asset2, new Rectangle?(asset2.Frame(2, 2, frameY: 1)));
    element15.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_VoiceCycleBack);
    element13.Append((UIElement) element15);
    UIImageButton uiImageButton2 = new UIImageButton(asset1, new Rectangle?(asset1.Frame(2, 2, 1, 1)));
    uiImageButton2.VAlign = 0.5f;
    uiImageButton2.HAlign = 1f;
    uiImageButton2.Left = StyleDimension.FromPixelsAndPercent(0.0f, 0.0f);
    uiImageButton2.BorderColor = Main.OurFavoriteColor;
    UIImageButton element16 = uiImageButton2;
    element16.SetVisibility(1f, 1f);
    element16.SetHoverImage(asset2, new Rectangle?(asset2.Frame(2, 2, 1, 1)));
    element16.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_VoiceCycleForward);
    element13.Append((UIElement) element16);
    UIColoredImageButton coloredImageButton9 = new UIColoredImageButton((Asset<Texture2D>) null);
    coloredImageButton9.VAlign = 0.5f;
    coloredImageButton9.HAlign = 0.5f;
    coloredImageButton9.Left = StyleDimension.FromPixelsAndPercent(0.0f, 0.0f);
    coloredImageButton9.Width = StyleDimension.FromPixels(52f);
    coloredImageButton9.Height = StyleDimension.FromPixels(52f);
    UIColoredImageButton element17 = coloredImageButton9;
    UIImage uiImage = new UIImage(Main.Assets.Request<Texture2D>("Images/UI/CharCreation/Voice", (AssetRequestMode) 1));
    uiImage.VAlign = 0.5f;
    uiImage.HAlign = 0.5f;
    uiImage.IgnoresMouseInteraction = true;
    uiImage.Color = Main.OurFavoriteColor;
    UIImage element18 = uiImage;
    element18.OnUpdate += new UIElement.ElementEvent(this.voiceIcon_OnUpdate);
    element17.Append((UIElement) element18);
    UIText uiText = new UIText("", 0.85f);
    uiText.VAlign = 1f;
    uiText.HAlign = 1f;
    uiText.TextOriginX = 0.5f;
    uiText.TextOriginY = 1f;
    uiText.Top = StyleDimension.FromPixels(-6f);
    uiText.Left = StyleDimension.FromPixels(-12f);
    uiText.ShadowColor = Color.Black * 0.3f;
    UIText element19 = uiText;
    element19.OnUpdate += new UIElement.ElementEvent(this.voiceNumber_OnUpdate);
    element17.Append((UIElement) element19);
    element17.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_VoicePlay);
    element13.Append((UIElement) element17);
    UIColoredSlider uiColoredSlider = new UIColoredSlider(LocalizedText.Empty, new Func<float>(this.GetPitchSlider), new Action<float>(this.SetPitchSlider_Keyboard), new Action(this.SetPitchSlider_GamePad), new Func<float, Color>(this.GetVoicePitchColorAt), Color.Transparent);
    uiColoredSlider.VAlign = 1f;
    uiColoredSlider.HAlign = 0.5f;
    uiColoredSlider.Width = StyleDimension.FromPixelsAndPercent(187f, 0.0f);
    uiColoredSlider.Top = StyleDimension.FromPixels(-10f);
    uiColoredSlider.Left = StyleDimension.FromPixels(55f);
    UIColoredSlider element20 = uiColoredSlider;
    element20.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_VoicePitch);
    element20.OnUpdate += new UIElement.ElementEvent(this.PitchSliderUpdate);
    element20.SetSnapPoint("pitch", 0, offset: new Vector2?(new Vector2(-93f, 16f)));
    element13.Append((UIElement) element20);
    this._pitchSlider = (UIElement) element20;
    element15.SetSnapPoint("Low", 1);
    element17.SetSnapPoint("Low", 2);
    element16.SetSnapPoint("Low", 3);
    this._voicePrevious = (UIElement) element15;
    this._voiceNext = (UIElement) element16;
    this._voicePlay = (UIElement) element17;
    element10.SetSnapPoint("Low", 4);
    element11.SetSnapPoint("Low", 5);
    element12.SetSnapPoint("Low", 6);
    this._clothStylesContainer = element1;
  }

  private void EquipArmorNone(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    this._femaleArmor = this._maleArmor = new UICharacterCreation.ArmorAssignments();
  }

  private void EquipArmorGold(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    this._femaleArmor = this._maleArmor = new UICharacterCreation.ArmorAssignments()
    {
      HeadItem = 92,
      BodyItem = 83,
      LegItem = 79
    };
  }

  private void EquipArmorSilver(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    this._femaleArmor = this._maleArmor = new UICharacterCreation.ArmorAssignments()
    {
      HeadItem = 91,
      BodyItem = 82,
      LegItem = 78
    };
  }

  private void EquipArmorFuneral(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    this._femaleArmor = this._maleArmor = new UICharacterCreation.ArmorAssignments()
    {
      HeadItem = 4704,
      BodyItem = 4705,
      LegItem = 4706
    };
  }

  private void EquipArmorHallowed(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    this._femaleArmor = this._maleArmor = new UICharacterCreation.ArmorAssignments()
    {
      HeadItem = 5660,
      BodyItem = 551,
      LegItem = 552
    };
  }

  private void EquipArmorFormal(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    this._maleArmor = new UICharacterCreation.ArmorAssignments()
    {
      HeadItem = 239,
      BodyItem = 240 /*0xF0*/,
      LegItem = 241
    };
    this._femaleArmor = new UICharacterCreation.ArmorAssignments()
    {
      HeadItem = 3478,
      BodyItem = 3479,
      LegItem = 0
    };
  }

  private void EquipArmorSwimming(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    this._maleArmor = new UICharacterCreation.ArmorAssignments()
    {
      HeadItem = 237,
      BodyItem = 3785,
      LegItem = 5649
    };
    this._femaleArmor = new UICharacterCreation.ArmorAssignments()
    {
      HeadItem = 237,
      BodyItem = 5646,
      LegItem = 5647,
      Accessory1Item = 208 /*0xD0*/
    };
  }

  private void PreparePreview_Main()
  {
    this._player.direction = 1;
    this.TryAutoAssigningHair();
    this.UpdatePreviewItems();
  }

  private void PreparePreview_ClothStyle()
  {
    this._player.direction = this._player.Male ? 1 : -1;
    this.TryAutoAssigningHair();
    this.UpdatePreviewItems();
  }

  private void TryAutoAssigningHair()
  {
    int num;
    if (this._lastSelectedHairstyle.HasValue || !this._defaultHairstylesForClothStyle.TryGetValue(this._player.skinVariant, out num))
      return;
    this._player.hair = num;
  }

  private void UpdatePreviewItems()
  {
    UICharacterCreation.ArmorAssignments armorAssignments = this._femaleArmor;
    if (this._player.Male)
      armorAssignments = this._maleArmor;
    this._player.armor[0].SetDefaults(armorAssignments.HeadItem);
    this._player.armor[1].SetDefaults(armorAssignments.BodyItem);
    this._player.armor[2].SetDefaults(armorAssignments.LegItem);
  }

  private void PitchSliderUpdate(UIElement affectedElement)
  {
    if (!this._pitchChanged || --this._pitchChangedCooldown > 0)
      return;
    this._pitchChanged = false;
    this.PlayVoicePreview();
  }

  private void PitchChanged()
  {
    this._pitchChanged = true;
    this._pitchChangedCooldown = 3;
  }

  private void SetPitchSlider_GamePad()
  {
    if (!PlayerInput.UsingGamepad)
      return;
    double pitchAmount1 = (double) this._pitchAmount;
    float num = UILinksInitializer.HandleSliderHorizontalInput(Utils.Remap(this._pitchAmount, -1f, 1f, 0.0f, 1f), 0.0f, 1f, PlayerInput.CurrentProfile.InterfaceDeadzoneX, 0.35f);
    this._pitchAmount = Utils.Remap(num, 0.0f, 1f, -1f, 1f);
    this._player.voicePitchOffset = Utils.Remap(this.RemapPitchSliderKnob(num), 0.0f, 1f, -1f, 1f);
    double pitchAmount2 = (double) this._pitchAmount;
    if (pitchAmount1 == pitchAmount2)
      return;
    this.PitchChanged();
  }

  private float RemapPitchSliderKnob(float pitchSliderValue)
  {
    int num = 20;
    return (float) Math.Round((double) pitchSliderValue * (double) num) / (float) num;
  }

  private void SetPitchSlider_Keyboard(float amount)
  {
    amount = this.RemapPitchSliderKnob(amount);
    double voicePitchOffset1 = (double) this._player.voicePitchOffset;
    this._pitchAmount = this._player.voicePitchOffset = Utils.Remap(amount, 0.0f, 1f, -1f, 1f);
    this._pitchChangedCooldown = 3;
    double voicePitchOffset2 = (double) this._player.voicePitchOffset;
    if (voicePitchOffset1 == voicePitchOffset2)
      return;
    this.PitchChanged();
  }

  private float GetPitchSlider()
  {
    return Utils.Remap(this.RemapPitchSliderKnob(this._pitchAmount), -1f, 1f, 0.0f, 1f);
  }

  private Color GetVoicePitchColorAt(float x)
  {
    float fromValue = (float) (((double) x * 4.0 + 0.5) % 1.0);
    float num = Utils.Remap(fromValue, 0.0f, 0.5f, 0.0f, 1f) * Utils.Remap(fromValue, 0.5f, 1f, 1f, 0.0f);
    return Color.Lerp(new Color(90, 90, 120), Color.White, num * num * num * num * num);
  }

  private void voiceNumber_OnUpdate(UIElement affectedElement)
  {
    int num = 0;
    int[] variantOrder = PlayerVoiceID.VariantOrder;
    for (int index = 0; index < variantOrder.Length; ++index)
    {
      if (variantOrder[index] == this._player.voiceVariant)
      {
        num = index;
        break;
      }
    }
    (affectedElement as UIText).SetText((num + 1).ToString());
  }

  private void voiceIcon_OnUpdate(UIElement affectedElement)
  {
    (affectedElement as UIImage).Color = PlayerVoiceID.Sets.Colors[this._player.voiceVariant];
  }

  private void MakeCategoriesBar(UIElement categoryContainer)
  {
    float xPositionStart = -240f;
    float xPositionPerId = 48f;
    this._colorPickers = new UIColoredImageButton[10];
    categoryContainer.Append((UIElement) this.CreateColorPicker(UICharacterCreation.CategoryId.HairColor, "Images/UI/CharCreation/ColorHair", xPositionStart, xPositionPerId));
    categoryContainer.Append((UIElement) this.CreateColorPicker(UICharacterCreation.CategoryId.Eye, "Images/UI/CharCreation/ColorEye", xPositionStart, xPositionPerId));
    categoryContainer.Append((UIElement) this.CreateColorPicker(UICharacterCreation.CategoryId.Skin, "Images/UI/CharCreation/ColorSkin", xPositionStart, xPositionPerId));
    categoryContainer.Append((UIElement) this.CreateColorPicker(UICharacterCreation.CategoryId.Shirt, "Images/UI/CharCreation/ColorShirt", xPositionStart, xPositionPerId));
    categoryContainer.Append((UIElement) this.CreateColorPicker(UICharacterCreation.CategoryId.Undershirt, "Images/UI/CharCreation/ColorUndershirt", xPositionStart, xPositionPerId));
    categoryContainer.Append((UIElement) this.CreateColorPicker(UICharacterCreation.CategoryId.Pants, "Images/UI/CharCreation/ColorPants", xPositionStart, xPositionPerId));
    categoryContainer.Append((UIElement) this.CreateColorPicker(UICharacterCreation.CategoryId.Shoes, "Images/UI/CharCreation/ColorShoes", xPositionStart, xPositionPerId));
    this._colorPickers[4].SetMiddleTexture(Main.Assets.Request<Texture2D>("Images/UI/CharCreation/ColorEyeBack", (AssetRequestMode) 1));
    this._clothingStylesCategoryButton = this.CreatePickerWithoutClick(UICharacterCreation.CategoryId.Clothing, "Images/UI/CharCreation/ClothStyleMale", xPositionStart, xPositionPerId);
    this._clothingStylesCategoryButton.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_ClothStyles);
    this._clothingStylesCategoryButton.SetSnapPoint("Top", 1);
    categoryContainer.Append((UIElement) this._clothingStylesCategoryButton);
    Asset<Texture2D> asset = Main.Assets.Request<Texture2D>("Images/UI/CharCreation/ColorCharacter", (AssetRequestMode) 1);
    this._clothingStylesCategoryButton.SetColor(Color.Transparent);
    for (int frameY = 0; frameY < this._characterPreviewLayers.Length; ++frameY)
    {
      UIImageFramed uiImageFramed = new UIImageFramed(asset, asset.Frame(verticalFrames: 7, frameY: frameY));
      uiImageFramed.HAlign = 0.5f;
      uiImageFramed.VAlign = 0.5f;
      UIImageFramed element = uiImageFramed;
      this._characterPreviewLayers[frameY] = element;
      this._clothingStylesCategoryButton.Append((UIElement) element);
      this._clothingStylesCategoryButton.OnUpdate += new UIElement.ElementEvent(this._clothingStylesCategoryButton_OnUpdate);
    }
    this._hairStylesCategoryButton = this.CreatePickerWithoutClick(UICharacterCreation.CategoryId.HairStyle, "Images/UI/CharCreation/HairStyle_Hair", xPositionStart, xPositionPerId);
    this._hairStylesCategoryButton.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_HairStyles);
    this._hairStylesCategoryButton.SetMiddleTexture(Main.Assets.Request<Texture2D>("Images/UI/CharCreation/HairStyle_Arrow", (AssetRequestMode) 1));
    this._hairStylesCategoryButton.SetSnapPoint("Top", 2);
    categoryContainer.Append((UIElement) this._hairStylesCategoryButton);
    this._charInfoCategoryButton = this.CreatePickerWithoutClick(UICharacterCreation.CategoryId.CharInfo, "Images/UI/CharCreation/CharInfo", xPositionStart, xPositionPerId);
    this._charInfoCategoryButton.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_CharInfo);
    this._charInfoCategoryButton.SetSnapPoint("Top", 0);
    categoryContainer.Append((UIElement) this._charInfoCategoryButton);
    this.UpdateColorPickers();
    UIHorizontalSeparator horizontalSeparator = new UIHorizontalSeparator();
    horizontalSeparator.Width = StyleDimension.FromPixelsAndPercent(-25f, 1f);
    horizontalSeparator.Top = StyleDimension.FromPixels(6f);
    horizontalSeparator.Left = new StyleDimension(-2.5f, 0.0f);
    horizontalSeparator.VAlign = 1f;
    horizontalSeparator.HAlign = 0.5f;
    horizontalSeparator.Color = Color.Lerp(Color.White, new Color(63 /*0x3F*/, 65, 151, (int) byte.MaxValue), 0.85f) * 0.9f;
    UIHorizontalSeparator element1 = horizontalSeparator;
    categoryContainer.Append((UIElement) element1);
    int num = 21;
    UIText uiText1 = new UIText(PlayerInput.GenerateInputTag_ForCurrentGamemode(false, "HotbarMinus"));
    uiText1.Left = new StyleDimension((float) -num, 0.0f);
    uiText1.VAlign = 0.5f;
    uiText1.Top = new StyleDimension(-4f, 0.0f);
    UIText element2 = uiText1;
    categoryContainer.Append((UIElement) element2);
    UIText uiText2 = new UIText(PlayerInput.GenerateInputTag_ForCurrentGamemode(false, "HotbarMinus"));
    uiText2.HAlign = 1f;
    uiText2.Left = new StyleDimension((float) (12 + num), 0.0f);
    uiText2.VAlign = 0.5f;
    uiText2.Top = new StyleDimension(-4f, 0.0f);
    UIText element3 = uiText2;
    categoryContainer.Append((UIElement) element3);
    this._helpGlyphLeft = element2;
    this._helpGlyphRight = element3;
    categoryContainer.OnUpdate += new UIElement.ElementEvent(this.UpdateHelpGlyphs);
  }

  private void _clothingStylesCategoryButton_OnUpdate(UIElement affectedElement)
  {
    this._characterPreviewLayers[0].Color = this._player.hairColor;
    this._characterPreviewLayers[1].Color = this._player.eyeColor;
    this._characterPreviewLayers[2].Color = this._player.skinColor;
    this._characterPreviewLayers[3].Color = this._player.shirtColor;
    this._characterPreviewLayers[4].Color = this._player.underShirtColor;
    this._characterPreviewLayers[5].Color = this._player.pantsColor;
    this._characterPreviewLayers[6].Color = this._player.shoeColor;
  }

  private void UpdateHelpGlyphs(UIElement element)
  {
    string text1 = "";
    string text2 = "";
    if (PlayerInput.UsingGamepad)
    {
      text1 = PlayerInput.GenerateInputTag_ForCurrentGamemode(false, "HotbarMinus");
      text2 = PlayerInput.GenerateInputTag_ForCurrentGamemode(false, "HotbarPlus");
    }
    this._helpGlyphLeft.SetText(text1);
    this._helpGlyphRight.SetText(text2);
  }

  private UIColoredImageButton CreateColorPicker(
    UICharacterCreation.CategoryId id,
    string texturePath,
    float xPositionStart,
    float xPositionPerId)
  {
    UIColoredImageButton colorPicker = new UIColoredImageButton(Main.Assets.Request<Texture2D>(texturePath, (AssetRequestMode) 1));
    this._colorPickers[(int) id] = colorPicker;
    colorPicker.VAlign = 0.0f;
    colorPicker.HAlign = 0.0f;
    colorPicker.Left.Set(xPositionStart + (float) id * xPositionPerId, 0.5f);
    colorPicker.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_ColorPicker);
    colorPicker.SetSnapPoint("Top", (int) id);
    return colorPicker;
  }

  private UIColoredImageButton CreatePickerWithoutClick(
    UICharacterCreation.CategoryId id,
    string texturePath,
    float xPositionStart,
    float xPositionPerId)
  {
    UIColoredImageButton pickerWithoutClick = new UIColoredImageButton(Main.Assets.Request<Texture2D>(texturePath, (AssetRequestMode) 1));
    pickerWithoutClick.VAlign = 0.0f;
    pickerWithoutClick.HAlign = 0.0f;
    pickerWithoutClick.Left.Set(xPositionStart + (float) id * xPositionPerId, 0.5f);
    return pickerWithoutClick;
  }

  private void MakeInfoMenu(UIElement parentContainer)
  {
    UIElement element1 = new UIElement()
    {
      Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f),
      Height = StyleDimension.FromPixelsAndPercent(0.0f, 1f),
      HAlign = 0.5f,
      VAlign = 0.0f
    };
    element1.SetPadding(10f);
    element1.PaddingBottom = 0.0f;
    element1.PaddingTop = 0.0f;
    parentContainer.Append(element1);
    UICharacterNameButton element2 = new UICharacterNameButton(Language.GetText("UI.WorldCreationName"), Language.GetText("UI.PlayerEmptyName"));
    element2.Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f);
    element2.HAlign = 0.5f;
    element1.Append((UIElement) element2);
    this._charName = element2;
    element2.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_Naming);
    element2.SetSnapPoint("Middle", 0);
    float num1 = 4f;
    float num2 = 0.0f;
    float percent = 0.4f;
    UIElement element3 = new UIElement()
    {
      HAlign = 0.0f,
      VAlign = 1f,
      Width = StyleDimension.FromPixelsAndPercent(-num1, percent),
      Height = StyleDimension.FromPixelsAndPercent(-50f, 1f)
    };
    element3.SetPadding(0.0f);
    element1.Append(element3);
    UISlicedImage uiSlicedImage = new UISlicedImage(Main.Assets.Request<Texture2D>("Images/UI/CharCreation/CategoryPanelHighlight", (AssetRequestMode) 1));
    uiSlicedImage.HAlign = 1f;
    uiSlicedImage.VAlign = 1f;
    uiSlicedImage.Width = StyleDimension.FromPixelsAndPercent((float) (-(double) num1 * 2.0), 1f - percent);
    uiSlicedImage.Left = StyleDimension.FromPixels(-num1);
    uiSlicedImage.Height = StyleDimension.FromPixelsAndPercent(element3.Height.Pixels, element3.Height.Precent);
    UISlicedImage element4 = uiSlicedImage;
    element4.SetSliceDepths(10);
    element4.Color = Color.LightGray * 0.7f;
    element1.Append((UIElement) element4);
    float num3 = 4f;
    UIDifficultyButton difficultyButton1 = new UIDifficultyButton(this._player, Lang.menu[26], Lang.menu[31 /*0x1F*/], (byte) 0, Color.Cyan);
    difficultyButton1.HAlign = 0.0f;
    difficultyButton1.VAlign = (float) (1.0 / ((double) num3 - 1.0));
    difficultyButton1.Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f);
    difficultyButton1.Height = StyleDimension.FromPixelsAndPercent(-num2, 1f / num3);
    UIDifficultyButton element5 = difficultyButton1;
    UIDifficultyButton difficultyButton2 = new UIDifficultyButton(this._player, Lang.menu[25], Lang.menu[30], (byte) 1, Main.mcColor);
    difficultyButton2.HAlign = 0.0f;
    difficultyButton2.VAlign = (float) (2.0 / ((double) num3 - 1.0));
    difficultyButton2.Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f);
    difficultyButton2.Height = StyleDimension.FromPixelsAndPercent(-num2, 1f / num3);
    UIDifficultyButton element6 = difficultyButton2;
    UIDifficultyButton difficultyButton3 = new UIDifficultyButton(this._player, Lang.menu[24], Lang.menu[29], (byte) 2, Main.hcColor);
    difficultyButton3.HAlign = 0.0f;
    difficultyButton3.VAlign = 1f;
    difficultyButton3.Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f);
    difficultyButton3.Height = StyleDimension.FromPixelsAndPercent(-num2, 1f / num3);
    UIDifficultyButton element7 = difficultyButton3;
    UIDifficultyButton difficultyButton4 = new UIDifficultyButton(this._player, Language.GetText("UI.Creative"), Language.GetText("UI.CreativeDescriptionPlayer"), (byte) 3, Main.creativeModeColor);
    difficultyButton4.HAlign = 0.0f;
    difficultyButton4.VAlign = 0.0f;
    difficultyButton4.Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f);
    difficultyButton4.Height = StyleDimension.FromPixelsAndPercent(-num2, 1f / num3);
    UIDifficultyButton element8 = difficultyButton4;
    UIText uiText = new UIText(Lang.menu[26]);
    uiText.HAlign = 0.0f;
    uiText.VAlign = 0.5f;
    uiText.Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f);
    uiText.Height = StyleDimension.FromPixelsAndPercent(0.0f, 1f);
    uiText.Top = StyleDimension.FromPixelsAndPercent(15f, 0.0f);
    uiText.IsWrapped = true;
    UIText element9 = uiText;
    element9.PaddingLeft = 20f;
    element9.PaddingRight = 20f;
    element4.Append((UIElement) element9);
    element3.Append((UIElement) element8);
    element3.Append((UIElement) element5);
    element3.Append((UIElement) element6);
    element3.Append((UIElement) element7);
    this._infoContainer = element1;
    this._difficultyDescriptionText = element9;
    element8.OnLeftMouseDown += new UIElement.MouseEvent(this.UpdateDifficultyDescription);
    element5.OnLeftMouseDown += new UIElement.MouseEvent(this.UpdateDifficultyDescription);
    element6.OnLeftMouseDown += new UIElement.MouseEvent(this.UpdateDifficultyDescription);
    element7.OnLeftMouseDown += new UIElement.MouseEvent(this.UpdateDifficultyDescription);
    this.UpdateDifficultyDescription((UIMouseEvent) null, (UIElement) null);
    element8.SetSnapPoint("Middle", 1);
    element5.SetSnapPoint("Middle", 2);
    element6.SetSnapPoint("Middle", 3);
    element7.SetSnapPoint("Middle", 4);
  }

  private void UpdateDifficultyDescription(UIMouseEvent evt, UIElement listeningElement)
  {
    LocalizedText text = Lang.menu[31 /*0x1F*/];
    switch (this._player.difficulty)
    {
      case 0:
        text = Lang.menu[31 /*0x1F*/];
        break;
      case 1:
        text = Lang.menu[30];
        break;
      case 2:
        text = Lang.menu[29];
        break;
      case 3:
        text = Language.GetText("UI.CreativeDescriptionPlayer");
        break;
    }
    this._difficultyDescriptionText.SetText(text);
  }

  private void MakeHSLMenu(UIElement parentContainer)
  {
    UIElement element1 = new UIElement()
    {
      Width = StyleDimension.FromPixelsAndPercent(220f, 0.0f),
      Height = StyleDimension.FromPixelsAndPercent(158f, 0.0f),
      HAlign = 0.5f,
      VAlign = 0.0f
    };
    element1.SetPadding(0.0f);
    parentContainer.Append(element1);
    UIPanel uiPanel1 = new UIPanel();
    uiPanel1.Width = StyleDimension.FromPixelsAndPercent(220f, 0.0f);
    uiPanel1.Height = StyleDimension.FromPixelsAndPercent(104f, 0.0f);
    uiPanel1.HAlign = 0.5f;
    uiPanel1.VAlign = 0.0f;
    uiPanel1.Top = StyleDimension.FromPixelsAndPercent(10f, 0.0f);
    UIElement element2 = (UIElement) uiPanel1;
    element2.SetPadding(0.0f);
    element2.PaddingTop = 3f;
    element1.Append(element2);
    element2.Append((UIElement) this.CreateHSLSlider(UICharacterCreation.HSLSliderId.Hue));
    element2.Append((UIElement) this.CreateHSLSlider(UICharacterCreation.HSLSliderId.Saturation));
    element2.Append((UIElement) this.CreateHSLSlider(UICharacterCreation.HSLSliderId.Luminance));
    UIPanel uiPanel2 = new UIPanel();
    uiPanel2.VAlign = 1f;
    uiPanel2.HAlign = 1f;
    uiPanel2.Width = StyleDimension.FromPixelsAndPercent(100f, 0.0f);
    uiPanel2.Height = StyleDimension.FromPixelsAndPercent(32f, 0.0f);
    UIPanel element3 = uiPanel2;
    UIText uiText = new UIText("FFFFFF");
    uiText.VAlign = 0.5f;
    uiText.HAlign = 0.5f;
    UIText element4 = uiText;
    element3.Append((UIElement) element4);
    element1.Append((UIElement) element3);
    UIColoredImageButton coloredImageButton1 = new UIColoredImageButton(Main.Assets.Request<Texture2D>("Images/UI/CharCreation/Copy", (AssetRequestMode) 1), true);
    coloredImageButton1.VAlign = 1f;
    coloredImageButton1.HAlign = 0.0f;
    coloredImageButton1.Left = StyleDimension.FromPixelsAndPercent(0.0f, 0.0f);
    UIColoredImageButton element5 = coloredImageButton1;
    element5.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_CopyHex);
    element1.Append((UIElement) element5);
    this._copyHexButton = (UIElement) element5;
    UIColoredImageButton coloredImageButton2 = new UIColoredImageButton(Main.Assets.Request<Texture2D>("Images/UI/CharCreation/Paste", (AssetRequestMode) 1), true);
    coloredImageButton2.VAlign = 1f;
    coloredImageButton2.HAlign = 0.0f;
    coloredImageButton2.Left = StyleDimension.FromPixelsAndPercent(40f, 0.0f);
    UIColoredImageButton element6 = coloredImageButton2;
    element6.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_PasteHex);
    element1.Append((UIElement) element6);
    this._pasteHexButton = (UIElement) element6;
    UIColoredImageButton coloredImageButton3 = new UIColoredImageButton(Main.Assets.Request<Texture2D>("Images/UI/CharCreation/Randomize", (AssetRequestMode) 1), true);
    coloredImageButton3.VAlign = 1f;
    coloredImageButton3.HAlign = 0.0f;
    coloredImageButton3.Left = StyleDimension.FromPixelsAndPercent(80f, 0.0f);
    UIColoredImageButton element7 = coloredImageButton3;
    element7.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_RandomizeSingleColor);
    element1.Append((UIElement) element7);
    this._randomColorButton = (UIElement) element7;
    this._hslContainer = element1;
    this._hslHexText = element4;
    element5.SetSnapPoint("Low", 0);
    element6.SetSnapPoint("Low", 1);
    element7.SetSnapPoint("Low", 2);
  }

  private void Click_VoicePitch(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
  }

  private UIColoredSlider CreateHSLSlider(UICharacterCreation.HSLSliderId id)
  {
    UIColoredSlider sliderButtonBase = this.CreateHSLSliderButtonBase(id);
    sliderButtonBase.VAlign = 0.0f;
    sliderButtonBase.HAlign = 0.0f;
    sliderButtonBase.Width = StyleDimension.FromPixelsAndPercent(-10f, 1f);
    sliderButtonBase.Top.Set((float) (30 * (int) id), 0.0f);
    sliderButtonBase.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_ColorPicker);
    sliderButtonBase.SetSnapPoint("Middle", (int) id, offset: new Vector2?(new Vector2(0.0f, 20f)));
    return sliderButtonBase;
  }

  private UIColoredSlider CreateHSLSliderButtonBase(UICharacterCreation.HSLSliderId id)
  {
    UIColoredSlider sliderButtonBase;
    switch (id)
    {
      case UICharacterCreation.HSLSliderId.Saturation:
        sliderButtonBase = new UIColoredSlider(LocalizedText.Empty, (Func<float>) (() => this.GetHSLSliderPosition(UICharacterCreation.HSLSliderId.Saturation)), (Action<float>) (x => this.UpdateHSLValue(UICharacterCreation.HSLSliderId.Saturation, x)), new Action(this.UpdateHSL_S), (Func<float, Color>) (x => this.GetHSLSliderColorAt(UICharacterCreation.HSLSliderId.Saturation, x)), Color.Transparent);
        break;
      case UICharacterCreation.HSLSliderId.Luminance:
        sliderButtonBase = new UIColoredSlider(LocalizedText.Empty, (Func<float>) (() => this.GetHSLSliderPosition(UICharacterCreation.HSLSliderId.Luminance)), (Action<float>) (x => this.UpdateHSLValue(UICharacterCreation.HSLSliderId.Luminance, x)), new Action(this.UpdateHSL_L), (Func<float, Color>) (x => this.GetHSLSliderColorAt(UICharacterCreation.HSLSliderId.Luminance, x)), Color.Transparent);
        break;
      default:
        sliderButtonBase = new UIColoredSlider(LocalizedText.Empty, (Func<float>) (() => this.GetHSLSliderPosition(UICharacterCreation.HSLSliderId.Hue)), (Action<float>) (x => this.UpdateHSLValue(UICharacterCreation.HSLSliderId.Hue, x)), new Action(this.UpdateHSL_H), (Func<float, Color>) (x => this.GetHSLSliderColorAt(UICharacterCreation.HSLSliderId.Hue, x)), Color.Transparent);
        break;
    }
    return sliderButtonBase;
  }

  private void UpdateHSL_H()
  {
    this.UpdateHSLValue(UICharacterCreation.HSLSliderId.Hue, UILinksInitializer.HandleSliderHorizontalInput(this._currentColorHSL.X, 0.0f, 1f, PlayerInput.CurrentProfile.InterfaceDeadzoneX, 0.35f));
  }

  private void UpdateHSL_S()
  {
    this.UpdateHSLValue(UICharacterCreation.HSLSliderId.Saturation, UILinksInitializer.HandleSliderHorizontalInput(this._currentColorHSL.Y, 0.0f, 1f, PlayerInput.CurrentProfile.InterfaceDeadzoneX, 0.35f));
  }

  private void UpdateHSL_L()
  {
    this.UpdateHSLValue(UICharacterCreation.HSLSliderId.Luminance, UILinksInitializer.HandleSliderHorizontalInput(this._currentColorHSL.Z, 0.0f, 1f, PlayerInput.CurrentProfile.InterfaceDeadzoneX, 0.35f));
  }

  private float GetHSLSliderPosition(UICharacterCreation.HSLSliderId id)
  {
    switch (id)
    {
      case UICharacterCreation.HSLSliderId.Hue:
        return this._currentColorHSL.X;
      case UICharacterCreation.HSLSliderId.Saturation:
        return this._currentColorHSL.Y;
      case UICharacterCreation.HSLSliderId.Luminance:
        return this._currentColorHSL.Z;
      default:
        return 1f;
    }
  }

  private void UpdateHSLValue(UICharacterCreation.HSLSliderId id, float value)
  {
    switch (id)
    {
      case UICharacterCreation.HSLSliderId.Hue:
        this._currentColorHSL.X = value;
        break;
      case UICharacterCreation.HSLSliderId.Saturation:
        this._currentColorHSL.Y = value;
        break;
      case UICharacterCreation.HSLSliderId.Luminance:
        this._currentColorHSL.Z = value;
        break;
    }
    Color rgb = UICharacterCreation.ScaledHslToRgb(this._currentColorHSL.X, this._currentColorHSL.Y, this._currentColorHSL.Z);
    this.ApplyPendingColor(rgb);
    this._colorPickers[(int) this._selectedPicker]?.SetColor(rgb);
    if (this._selectedPicker == UICharacterCreation.CategoryId.HairColor)
      this._hairStylesCategoryButton.SetColor(rgb);
    this.UpdateHexText(rgb);
  }

  private Color GetHSLSliderColorAt(UICharacterCreation.HSLSliderId id, float pointAt)
  {
    switch (id)
    {
      case UICharacterCreation.HSLSliderId.Hue:
        return UICharacterCreation.ScaledHslToRgb(pointAt, 1f, 0.5f);
      case UICharacterCreation.HSLSliderId.Saturation:
        return UICharacterCreation.ScaledHslToRgb(this._currentColorHSL.X, pointAt, this._currentColorHSL.Z);
      case UICharacterCreation.HSLSliderId.Luminance:
        return UICharacterCreation.ScaledHslToRgb(this._currentColorHSL.X, this._currentColorHSL.Y, pointAt);
      default:
        return Color.White;
    }
  }

  private void ApplyPendingColor(Color pendingColor)
  {
    switch (this._selectedPicker)
    {
      case UICharacterCreation.CategoryId.HairColor:
        this._player.hairColor = pendingColor;
        break;
      case UICharacterCreation.CategoryId.Eye:
        this._player.eyeColor = pendingColor;
        break;
      case UICharacterCreation.CategoryId.Skin:
        this._player.skinColor = pendingColor;
        break;
      case UICharacterCreation.CategoryId.Shirt:
        this._player.shirtColor = pendingColor;
        break;
      case UICharacterCreation.CategoryId.Undershirt:
        this._player.underShirtColor = pendingColor;
        break;
      case UICharacterCreation.CategoryId.Pants:
        this._player.pantsColor = pendingColor;
        break;
      case UICharacterCreation.CategoryId.Shoes:
        this._player.shoeColor = pendingColor;
        break;
    }
  }

  private void UpdateHexText(Color pendingColor)
  {
    this._hslHexText.SetText(UICharacterCreation.GetHexText(pendingColor));
  }

  private static string GetHexText(Color pendingColor) => "#" + pendingColor.Hex3().ToUpper();

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
    UICharacterCreation.GoBack();
  }

  private static void GoBack()
  {
    SoundEngine.PlaySound(11);
    if (UICharacterCreation.dirty)
    {
      UICharacterCreation.BackupConfirmationState = Main.MenuUI.CurrentState;
      Main.menuMode = 40;
    }
    else
      Main.OpenCharacterSelectUI();
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

  private void Click_ColorPicker(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    for (int selection = 0; selection < this._colorPickers.Length; ++selection)
    {
      if (this._colorPickers[selection] == evt.Target)
      {
        this.SelectColorPicker((UICharacterCreation.CategoryId) selection);
        break;
      }
    }
  }

  private void Click_ClothStyles(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    this.UnselectAllCategories();
    this._selectedPicker = UICharacterCreation.CategoryId.Clothing;
    this._middleContainer.Append(this._clothStylesContainer);
    this._clothingStylesCategoryButton.SetSelected(true);
  }

  private void Click_HairStyles(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    this.UnselectAllCategories();
    this._selectedPicker = UICharacterCreation.CategoryId.HairStyle;
    this._middleContainer.Append(this._hairstylesContainer);
    this._hairStylesCategoryButton.SetSelected(true);
  }

  private void Click_CharInfo(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    this.UnselectAllCategories();
    this._selectedPicker = UICharacterCreation.CategoryId.CharInfo;
    this._middleContainer.Append(this._infoContainer);
    this._charInfoCategoryButton.SetSelected(true);
  }

  private void Click_CharClothStyle(UIMouseEvent evt, UIElement listeningElement)
  {
    if (this._maleArmor.HeadItem != 0 || this._maleArmor.BodyItem != 0 || this._maleArmor.LegItem != 0)
    {
      this.EquipArmorNone(evt, listeningElement);
    }
    else
    {
      if (listeningElement is UIClothStyleButton clothStyleButton)
        this._player.skinVariant = clothStyleButton.ClothStyleId;
      SoundEngine.PlaySound(12);
      this._clothingStylesCategoryButton.SetImageWithoutSettingSize(Main.Assets.Request<Texture2D>("Images/UI/CharCreation/" + (this._player.Male ? "ClothStyleMale" : "ClothStyleFemale"), (AssetRequestMode) 1));
      this.UpdateSelectedGender();
    }
  }

  private void TryChangingVoice()
  {
    if (this._player.Male && this._player.voiceVariant == 2)
      this._player.voiceVariant = 1;
    if (this._player.Male || this._player.voiceVariant != 1)
      return;
    this._player.voiceVariant = 2;
  }

  private void UpdateSelectedGender()
  {
    if (this._oldMaleForVoiceAutoSwitch == this._player.Male)
    {
      this.PlayVoicePreview();
    }
    else
    {
      switch (this._player.voiceVariant)
      {
        case 1:
          if (this._oldMaleForVoiceAutoSwitch)
          {
            this._player.voiceVariant = 2;
            break;
          }
          break;
        case 2:
          if (!this._oldMaleForVoiceAutoSwitch)
          {
            this._player.voiceVariant = 1;
            break;
          }
          break;
      }
      this._oldMaleForVoiceAutoSwitch = this._player.Male;
      this.PlayVoicePreview();
    }
  }

  private void Click_CopyHex(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    Platform.Get<IClipboard>().Value = this._hslHexText.Text;
  }

  private void Click_PasteHex(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    Vector3 hsl;
    if (!this.GetHexColor(Platform.Get<IClipboard>().Value, out hsl))
      return;
    this.ApplyPendingColor(UICharacterCreation.ScaledHslToRgb(hsl.X, hsl.Y, hsl.Z));
    this._currentColorHSL = hsl;
    this.UpdateHexText(UICharacterCreation.ScaledHslToRgb(hsl.X, hsl.Y, hsl.Z));
    this.UpdateColorPickers();
  }

  private string GetPlayerTemplateValues()
  {
    string text = JsonConvert.SerializeObject((object) new Dictionary<string, object>()
    {
      {
        "version",
        (object) 1
      },
      {
        "hairStyle",
        (object) this._player.hair
      },
      {
        "clothingStyle",
        (object) this._player.skinVariant
      },
      {
        "voiceStyle",
        (object) this._player.voiceVariant
      },
      {
        "voicePitch",
        (object) this._player.voicePitchOffset
      },
      {
        "hairColor",
        (object) UICharacterCreation.GetHexText(this._player.hairColor)
      },
      {
        "eyeColor",
        (object) UICharacterCreation.GetHexText(this._player.eyeColor)
      },
      {
        "skinColor",
        (object) UICharacterCreation.GetHexText(this._player.skinColor)
      },
      {
        "shirtColor",
        (object) UICharacterCreation.GetHexText(this._player.shirtColor)
      },
      {
        "underShirtColor",
        (object) UICharacterCreation.GetHexText(this._player.underShirtColor)
      },
      {
        "pantsColor",
        (object) UICharacterCreation.GetHexText(this._player.pantsColor)
      },
      {
        "shoeColor",
        (object) UICharacterCreation.GetHexText(this._player.shoeColor)
      }
    }, new JsonSerializerSettings()
    {
      TypeNameHandling = (TypeNameHandling) 4,
      MetadataPropertyHandling = (MetadataPropertyHandling) 1,
      Formatting = (Formatting) 1
    });
    PlayerInput.PrettyPrintProfiles(ref text);
    return text;
  }

  private void Click_CopyPlayerTemplate(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    Platform.Get<IClipboard>().Value = this.GetPlayerTemplateValues();
  }

  private void Click_PastePlayerTemplate(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    try
    {
      string str1 = Platform.Get<IClipboard>().Value;
      int startIndex = str1.IndexOf("{");
      if (startIndex == -1)
        return;
      string str2 = str1.Substring(startIndex);
      int num1 = str2.LastIndexOf("}");
      if (num1 == -1)
        return;
      Dictionary<string, object> dictionary1 = JsonConvert.DeserializeObject<Dictionary<string, object>>(str2.Substring(0, num1 + 1));
      if (dictionary1 == null)
        return;
      Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
      foreach (KeyValuePair<string, object> keyValuePair in dictionary1)
        dictionary2[keyValuePair.Key.ToLower()] = keyValuePair.Value;
      object hexString;
      if (dictionary2.TryGetValue("version", out hexString))
      {
        long num2 = (long) hexString;
      }
      if (dictionary2.TryGetValue("hairstyle", out hexString))
      {
        int num3 = (int) (long) hexString;
        if (Main.Hairstyles.AvailableHairstyles.Contains(num3))
        {
          this._player.hair = num3;
          this._lastSelectedHairstyle = new int?(num3);
        }
      }
      if (dictionary2.TryGetValue("clothingstyle", out hexString))
      {
        int num4 = (int) (long) hexString;
        if (((IEnumerable<int>) this._validClothStyles).Contains<int>(num4))
          this._player.skinVariant = num4;
      }
      if (dictionary2.TryGetValue("voicestyle", out hexString))
      {
        int num5 = (int) (long) hexString;
        if (((IEnumerable<int>) this._validVoiceStyles).Contains<int>(num5))
          this._player.voiceVariant = num5;
      }
      if (dictionary2.TryGetValue("voicepitch", out hexString))
      {
        float num6 = (float) (double) hexString;
        this._player.voicePitchOffset = num6;
        this._pitchAmount = num6;
      }
      Vector3 hsl;
      if (dictionary2.TryGetValue("haircolor", out hexString) && this.GetHexColor((string) hexString, out hsl))
        this._player.hairColor = UICharacterCreation.ScaledHslToRgb(hsl);
      if (dictionary2.TryGetValue("eyecolor", out hexString) && this.GetHexColor((string) hexString, out hsl))
        this._player.eyeColor = UICharacterCreation.ScaledHslToRgb(hsl);
      if (dictionary2.TryGetValue("skincolor", out hexString) && this.GetHexColor((string) hexString, out hsl))
        this._player.skinColor = UICharacterCreation.ScaledHslToRgb(hsl);
      if (dictionary2.TryGetValue("shirtcolor", out hexString) && this.GetHexColor((string) hexString, out hsl))
        this._player.shirtColor = UICharacterCreation.ScaledHslToRgb(hsl);
      if (dictionary2.TryGetValue("undershirtcolor", out hexString) && this.GetHexColor((string) hexString, out hsl))
        this._player.underShirtColor = UICharacterCreation.ScaledHslToRgb(hsl);
      if (dictionary2.TryGetValue("pantscolor", out hexString) && this.GetHexColor((string) hexString, out hsl))
        this._player.pantsColor = UICharacterCreation.ScaledHslToRgb(hsl);
      if (dictionary2.TryGetValue("shoecolor", out hexString) && this.GetHexColor((string) hexString, out hsl))
        this._player.shoeColor = UICharacterCreation.ScaledHslToRgb(hsl);
      this.Click_CharClothStyle((UIMouseEvent) null, (UIElement) null);
      this.UpdateColorPickers();
    }
    catch
    {
    }
  }

  private void Click_VoicePlay(UIMouseEvent evt, UIElement listeningElement)
  {
    this.PlayVoicePreview();
  }

  private void PlayVoicePreview()
  {
    if (this._playedVoicePreviewThisFrame)
      return;
    this._playedVoicePreviewThisFrame = true;
    Vector2 position = this._player.position;
    this._player.position = new Vector2(-1f, -1f);
    this._player.PlayHurtSound();
    this._player.position = position;
  }

  private void Click_VoiceCycleBack(UIMouseEvent evt, UIElement listeningElement)
  {
    Main.CycleVoiceStyle(this._player, -1);
    this.PlayVoicePreview();
  }

  private void Click_VoiceCycleForward(UIMouseEvent evt, UIElement listeningElement)
  {
    Main.CycleVoiceStyle(this._player, 1);
    this.PlayVoicePreview();
  }

  private void Update_VoiceIconColor()
  {
  }

  private void Click_RandomizePlayer(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    Player player = this._player;
    int index = Main.rand.Next(Main.Hairstyles.AvailableHairstyles.Count);
    player.hair = Main.Hairstyles.AvailableHairstyles[index];
    this._lastSelectedHairstyle = new int?(player.hair);
    player.eyeColor = UICharacterCreation.ScaledHslToRgb(UICharacterCreation.GetRandomColorVector());
    while ((int) player.eyeColor.R + (int) player.eyeColor.G + (int) player.eyeColor.B > 300)
      player.eyeColor = UICharacterCreation.ScaledHslToRgb(UICharacterCreation.GetRandomColorVector());
    float num1 = (float) Main.rand.Next(60, 120) * 0.01f;
    if ((double) num1 > 1.0)
      num1 = 1f;
    player.skinColor.R = (byte) ((double) Main.rand.Next(240 /*0xF0*/, (int) byte.MaxValue) * (double) num1);
    player.skinColor.G = (byte) ((double) Main.rand.Next(110, 140) * (double) num1);
    player.skinColor.B = (byte) ((double) Main.rand.Next(75, 110) * (double) num1);
    player.hairColor = UICharacterCreation.ScaledHslToRgb(UICharacterCreation.GetRandomColorVector());
    player.shirtColor = UICharacterCreation.ScaledHslToRgb(UICharacterCreation.GetRandomColorVector());
    player.underShirtColor = UICharacterCreation.ScaledHslToRgb(UICharacterCreation.GetRandomColorVector());
    player.pantsColor = UICharacterCreation.ScaledHslToRgb(UICharacterCreation.GetRandomColorVector());
    player.shoeColor = UICharacterCreation.ScaledHslToRgb(UICharacterCreation.GetRandomColorVector());
    player.skinVariant = this._validClothStyles[Main.rand.Next(this._validClothStyles.Length)];
    player.voiceVariant = player.Male ? 1 : 2;
    if (Main.rand.Next(2) == 0)
      player.voiceVariant = 3;
    int num2 = player.hair + 1;
    if (num2 <= 135)
    {
      if (num2 <= 124)
      {
        switch (num2 - 5)
        {
          case 0:
          case 1:
          case 2:
          case 5:
          case 7:
          case 14:
          case 17:
          case 18:
          case 21:
          case 22:
          case 25:
          case 28:
          case 29:
          case 30:
          case 32 /*0x20*/:
          case 33:
          case 34:
          case 35:
          case 36:
          case 39:
          case 40:
          case 41:
          case 42:
          case 43:
          case 44:
          case 46:
          case 51:
          case 60:
          case 61:
          case 62:
          case 63 /*0x3F*/:
          case 64 /*0x40*/:
          case 65:
          case 66:
          case 67:
          case 68:
          case 69:
          case 74:
          case 75:
          case 76:
          case 77:
          case 79:
          case 80 /*0x50*/:
          case 81:
          case 82:
          case 83:
          case 85:
          case 86:
          case 87:
          case 88:
          case 90:
          case 91:
          case 93:
          case 95:
          case 97:
          case 99:
          case 102:
          case 103:
          case 108:
            break;
          case 3:
          case 4:
          case 6:
          case 8:
          case 9:
          case 10:
          case 11:
          case 12:
          case 13:
          case 15:
          case 16 /*0x10*/:
          case 19:
          case 20:
          case 23:
          case 24:
          case 26:
          case 27:
          case 31 /*0x1F*/:
          case 37:
          case 38:
          case 45:
          case 47:
          case 48 /*0x30*/:
          case 49:
          case 50:
          case 52:
          case 53:
          case 54:
          case 55:
          case 56:
          case 57:
          case 58:
          case 59:
          case 70:
          case 71:
          case 72:
          case 73:
          case 78:
          case 84:
          case 89:
          case 92:
          case 94:
          case 96 /*0x60*/:
          case 98:
          case 100:
          case 101:
          case 104:
          case 105:
          case 106:
          case 107:
            goto label_16;
          default:
            if (num2 == 124)
              break;
            goto label_16;
        }
      }
      else if (num2 != 126 && (uint) (num2 - 133) > 2U)
        goto label_16;
    }
    else if (num2 <= 147)
    {
      if (num2 != 144 /*0x90*/ && (uint) (num2 - 146) > 1U)
        goto label_16;
    }
    else if (num2 != 163 && num2 != 165)
      goto label_16;
    player.Male = false;
    goto label_17;
label_16:
    player.Male = true;
label_17:
    this._femaleArmor = this._maleArmor = new UICharacterCreation.ArmorAssignments();
    this.Click_CharClothStyle((UIMouseEvent) null, (UIElement) null);
    this.UpdateSelectedGender();
    this.UpdateColorPickers();
  }

  private void Click_Naming(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(10);
    this._player.name = "";
    Main.clrInput();
    UIVirtualKeyboard state = new UIVirtualKeyboard(Lang.menu[45].Value, "", new UIVirtualKeyboard.KeyboardSubmitEvent(this.OnFinishedNaming), new Action(this.OnCanceledNaming), allowEmpty: true);
    Main.MenuUI.SetState((UIState) state);
  }

  private void Click_NamingAndCreating(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(10);
    if (string.IsNullOrEmpty(this._player.name))
    {
      this._player.name = "";
      Main.clrInput();
      UIVirtualKeyboard state = new UIVirtualKeyboard(Lang.menu[45].Value, "", new UIVirtualKeyboard.KeyboardSubmitEvent(this.OnFinishedNamingAndCreating), new Action(this.OnCanceledNaming));
      Main.MenuUI.SetState((UIState) state);
    }
    else
      this.FinishCreatingCharacter();
  }

  private void OnFinishedNaming(string name)
  {
    this._player.name = name.Trim();
    Main.MenuUI.SetState((UIState) this);
    this._charName.SetContents(this._player.name);
  }

  private void OnCanceledNaming() => Main.MenuUI.SetState((UIState) this);

  private void OnFinishedNamingAndCreating(string name)
  {
    this._player.name = name.Trim();
    Main.MenuUI.SetState((UIState) this);
    this._charName.SetContents(this._player.name);
    this.FinishCreatingCharacter();
  }

  private void FinishCreatingCharacter()
  {
    this.TryAutoAssigningHair();
    this.SetupPlayerStatsAndInventoryBasedOnDifficulty();
    PlayerFileData.CreateAndSave(this._player);
    Main.LoadPlayers();
    Main.menuMode = 1;
  }

  private void SetupPlayerStatsAndInventoryBasedOnDifficulty()
  {
    this._femaleArmor = this._maleArmor = new UICharacterCreation.ArmorAssignments();
    this.UpdatePreviewItems();
    int index1 = 0;
    int num1;
    if (this._player.difficulty == (byte) 3)
    {
      this._player.statLife = this._player.statLifeMax = 100;
      this._player.statMana = this._player.statManaMax = 20;
      this._player.inventory[index1].SetDefaults(6);
      Item[] inventory1 = this._player.inventory;
      int index2 = index1;
      int index3 = index2 + 1;
      inventory1[index2].Prefix(-1);
      this._player.inventory[index3].SetDefaults(1);
      Item[] inventory2 = this._player.inventory;
      int index4 = index3;
      int index5 = index4 + 1;
      inventory2[index4].Prefix(-1);
      this._player.inventory[index5].SetDefaults(10);
      Item[] inventory3 = this._player.inventory;
      int index6 = index5;
      int index7 = index6 + 1;
      inventory3[index6].Prefix(-1);
      this._player.inventory[index7].SetDefaults(7);
      Item[] inventory4 = this._player.inventory;
      int index8 = index7;
      int index9 = index8 + 1;
      inventory4[index8].Prefix(-1);
      this._player.inventory[index9].SetDefaults(4281);
      Item[] inventory5 = this._player.inventory;
      int index10 = index9;
      int index11 = index10 + 1;
      inventory5[index10].Prefix(-1);
      this._player.inventory[index11].SetDefaults(8);
      Item[] inventory6 = this._player.inventory;
      int index12 = index11;
      int index13 = index12 + 1;
      inventory6[index12].stack = 100;
      this._player.inventory[index13].SetDefaults(965);
      Item[] inventory7 = this._player.inventory;
      int index14 = index13;
      int num2 = index14 + 1;
      inventory7[index14].stack = 100;
      Item[] inventory8 = this._player.inventory;
      int index15 = num2;
      int num3 = index15 + 1;
      inventory8[index15].SetDefaults(50);
      Item[] inventory9 = this._player.inventory;
      int index16 = num3;
      num1 = index16 + 1;
      inventory9[index16].SetDefaults(84);
      this._player.armor[3].SetDefaults(4978);
      this._player.armor[3].Prefix(-1);
      string lower = this._player.name.ToLower();
      if (lower == "wolf pet" || lower == "wolfpet")
        this._player.miscEquips[3].SetDefaults(5130);
      this._player.AddBuff(216, 3600);
    }
    else
    {
      this._player.inventory[index1].SetDefaults(3507);
      Item[] inventory10 = this._player.inventory;
      int index17 = index1;
      int index18 = index17 + 1;
      inventory10[index17].Prefix(-1);
      this._player.inventory[index18].SetDefaults(3509);
      Item[] inventory11 = this._player.inventory;
      int index19 = index18;
      int index20 = index19 + 1;
      inventory11[index19].Prefix(-1);
      this._player.inventory[index20].SetDefaults(3506);
      Item[] inventory12 = this._player.inventory;
      int index21 = index20;
      num1 = index21 + 1;
      inventory12[index21].Prefix(-1);
    }
    if (Main.runningCollectorsEdition)
    {
      Item[] inventory = this._player.inventory;
      int index22 = num1;
      int num4 = index22 + 1;
      inventory[index22].SetDefaults(603);
    }
    this._player.savedPerPlayerFieldsThatArentInThePlayerClass = new Player.SavedPlayerDataWithAnnoyingRules();
    CreativePowerManager.Instance.ResetDataForNewPlayer(this._player);
  }

  private bool GetHexColor(string hexString, out Vector3 hsl)
  {
    if (hexString.StartsWith("#"))
      hexString = hexString.Substring(1);
    uint result;
    if (hexString.Length <= 6 && uint.TryParse(hexString, NumberStyles.HexNumber, (IFormatProvider) CultureInfo.CurrentCulture, out result))
    {
      uint b = result & (uint) byte.MaxValue;
      uint g = result >> 8 & (uint) byte.MaxValue;
      uint r = result >> 16 /*0x10*/ & (uint) byte.MaxValue;
      hsl = UICharacterCreation.RgbToScaledHsl(new Color((int) r, (int) g, (int) b));
      return true;
    }
    hsl = Vector3.Zero;
    return false;
  }

  private void Click_RandomizeSingleColor(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    Vector3 randomColorVector = UICharacterCreation.GetRandomColorVector();
    this.ApplyPendingColor(UICharacterCreation.ScaledHslToRgb(randomColorVector.X, randomColorVector.Y, randomColorVector.Z));
    this._currentColorHSL = randomColorVector;
    this.UpdateHexText(UICharacterCreation.ScaledHslToRgb(randomColorVector.X, randomColorVector.Y, randomColorVector.Z));
    this.UpdateColorPickers();
  }

  private static Vector3 GetRandomColorVector()
  {
    return new Vector3(Main.rand.NextFloat(), Main.rand.NextFloat(), Main.rand.NextFloat());
  }

  private void UnselectAllCategories()
  {
    foreach (UIColoredImageButton colorPicker in this._colorPickers)
      colorPicker?.SetSelected(false);
    this._clothingStylesCategoryButton.SetSelected(false);
    this._hairStylesCategoryButton.SetSelected(false);
    this._charInfoCategoryButton.SetSelected(false);
    this._hslContainer.Remove();
    this._hairstylesContainer.Remove();
    this._clothStylesContainer.Remove();
    this._infoContainer.Remove();
  }

  private void SelectColorPicker(UICharacterCreation.CategoryId selection)
  {
    this._selectedPicker = selection;
    switch (selection)
    {
      case UICharacterCreation.CategoryId.CharInfo:
        this.Click_CharInfo((UIMouseEvent) null, (UIElement) null);
        break;
      case UICharacterCreation.CategoryId.Clothing:
        this.Click_ClothStyles((UIMouseEvent) null, (UIElement) null);
        break;
      case UICharacterCreation.CategoryId.HairStyle:
        this.Click_HairStyles((UIMouseEvent) null, (UIElement) null);
        break;
      default:
        this.UnselectAllCategories();
        this._middleContainer.Append(this._hslContainer);
        for (int index = 0; index < this._colorPickers.Length; ++index)
        {
          if (this._colorPickers[index] != null)
            this._colorPickers[index].SetSelected((UICharacterCreation.CategoryId) index == selection);
        }
        Vector3 vector3 = Vector3.One;
        switch (this._selectedPicker)
        {
          case UICharacterCreation.CategoryId.HairColor:
            vector3 = UICharacterCreation.RgbToScaledHsl(this._player.hairColor);
            break;
          case UICharacterCreation.CategoryId.Eye:
            vector3 = UICharacterCreation.RgbToScaledHsl(this._player.eyeColor);
            break;
          case UICharacterCreation.CategoryId.Skin:
            vector3 = UICharacterCreation.RgbToScaledHsl(this._player.skinColor);
            break;
          case UICharacterCreation.CategoryId.Shirt:
            vector3 = UICharacterCreation.RgbToScaledHsl(this._player.shirtColor);
            break;
          case UICharacterCreation.CategoryId.Undershirt:
            vector3 = UICharacterCreation.RgbToScaledHsl(this._player.underShirtColor);
            break;
          case UICharacterCreation.CategoryId.Pants:
            vector3 = UICharacterCreation.RgbToScaledHsl(this._player.pantsColor);
            break;
          case UICharacterCreation.CategoryId.Shoes:
            vector3 = UICharacterCreation.RgbToScaledHsl(this._player.shoeColor);
            break;
        }
        this._currentColorHSL = vector3;
        this.UpdateHexText(UICharacterCreation.ScaledHslToRgb(vector3.X, vector3.Y, vector3.Z));
        break;
    }
  }

  private void UpdateColorPickers()
  {
    int selectedPicker = (int) this._selectedPicker;
    this._colorPickers[3].SetColor(this._player.hairColor);
    this._hairStylesCategoryButton.SetColor(this._player.hairColor);
    this._colorPickers[4].SetColor(this._player.eyeColor);
    this._colorPickers[5].SetColor(this._player.skinColor);
    this._colorPickers[6].SetColor(this._player.shirtColor);
    this._colorPickers[7].SetColor(this._player.underShirtColor);
    this._colorPickers[8].SetColor(this._player.pantsColor);
    this._colorPickers[9].SetColor(this._player.shoeColor);
  }

  public override void Draw(SpriteBatch spriteBatch)
  {
    base.Draw(spriteBatch);
    string text = (string) null;
    if (this._copyHexButton.IsMouseHovering)
      text = Language.GetTextValue("UI.CopyColorToClipboard");
    if (this._pasteHexButton.IsMouseHovering)
      text = Language.GetTextValue("UI.PasteColorFromClipboard");
    if (this._randomColorButton.IsMouseHovering)
      text = Language.GetTextValue("UI.RandomizeColor");
    if (this._copyTemplateButton.IsMouseHovering)
      text = Language.GetTextValue("UI.CopyPlayerToClipboard");
    if (this._pasteTemplateButton.IsMouseHovering)
      text = Language.GetTextValue("UI.PastePlayerFromClipboard");
    if (this._randomizePlayerButton.IsMouseHovering)
      text = Language.GetTextValue("UI.RandomizePlayer");
    if (this._previewArmorButton[0].IsMouseHovering)
      text = Language.GetTextValue("UI.PreviewArmorNone");
    if (this._previewArmorButton[1].IsMouseHovering)
      text = Language.GetTextValue("UI.PreviewArmorHallowed");
    if (this._previewArmorButton[2].IsMouseHovering)
      text = Language.GetTextValue("UI.PreviewArmorSilver");
    if (this._previewArmorButton[3].IsMouseHovering)
      text = Language.GetTextValue("UI.PreviewArmorFormal");
    if (this._previewArmorButton[4].IsMouseHovering)
      text = Language.GetTextValue("UI.PreviewArmorSwimming");
    if (UISliderBase.CurrentAimedSlider == this._pitchSlider)
      text = Language.GetTextValue("UI.PlayerCreateVoicePitch");
    if (this._voicePrevious.IsMouseHovering)
      text = Language.GetTextValue("UI.PlayerCreateVoicePrev");
    if (this._voiceNext.IsMouseHovering)
      text = Language.GetTextValue("UI.PlayerCreateVoiceNext");
    if (this._voicePlay.IsMouseHovering)
      text = Language.GetTextValue("UI.PlayerCreateVoicePlay");
    if (this._charInfoCategoryButton.IsMouseHovering)
      text = Language.GetTextValue("UI.PlayerCreateCategoryInfo");
    if (this._clothingStylesCategoryButton.IsMouseHovering)
      text = Language.GetTextValue("UI.PlayerCreateCategoryBodyStyle");
    if (this._hairStylesCategoryButton.IsMouseHovering)
      text = Language.GetTextValue("UI.PlayerCreateCategoryHairStyle");
    if (this._colorPickers[3].IsMouseHovering)
      text = Language.GetTextValue("UI.PlayerCreateCategoryHairColor");
    if (this._colorPickers[4].IsMouseHovering)
      text = Language.GetTextValue("UI.PlayerCreateCategoryEyeColor");
    if (this._colorPickers[5].IsMouseHovering)
      text = Language.GetTextValue("UI.PlayerCreateCategorySkinColor");
    if (this._colorPickers[6].IsMouseHovering)
      text = Language.GetTextValue("UI.PlayerCreateCategoryShirtColor");
    if (this._colorPickers[7].IsMouseHovering)
      text = Language.GetTextValue("UI.PlayerCreateCategoryUndershirtColor");
    if (this._colorPickers[8].IsMouseHovering)
      text = Language.GetTextValue("UI.PlayerCreateCategoryPantsColor");
    if (this._colorPickers[9].IsMouseHovering)
      text = Language.GetTextValue("UI.PlayerCreateCategoryShoesColor");
    if (text != null)
    {
      float x = FontAssets.MouseText.Value.MeasureString(text).X;
      Vector2 vector2 = new Vector2((float) Main.mouseX, (float) Main.mouseY) + new Vector2(16f);
      if ((double) vector2.Y > (double) (Main.screenHeight - 30))
        vector2.Y = (float) (Main.screenHeight - 30);
      if ((double) vector2.X > (double) Main.screenWidth - (double) x)
        vector2.X = (float) (Main.screenWidth - 460);
      Utils.DrawBorderStringFourWay(spriteBatch, FontAssets.MouseText.Value, text, vector2.X, vector2.Y, new Color((int) Main.mouseTextColor, (int) Main.mouseTextColor, (int) Main.mouseTextColor, (int) Main.mouseTextColor), Color.Black, Vector2.Zero);
    }
    this.SetupGamepadPoints(spriteBatch);
    this._tips.Update();
    int num1 = Main.screenHeight - 560;
    if (num1 < 0)
      num1 = 0;
    int num2 = 150;
    if (num1 < 300)
      num2 = num1 / 2;
    if (num1 > 30)
    {
      this._tips.TipOffsetY = (float) -num2;
      this._tips.Draw();
    }
    if (UICharacterCreation.dirty)
      return;
    if (!string.IsNullOrEmpty(this._player.name))
      UICharacterCreation.dirty = true;
    if (!(this.GetPlayerTemplateValues() != this.initialState))
      return;
    UICharacterCreation.dirty = true;
  }

  private void SetupGamepadPoints(SpriteBatch spriteBatch)
  {
    UILinkPointNavigator.Shortcuts.BackButtonCommand = 7;
    int num1 = 3000;
    int num2 = num1 + 20;
    int num3 = num1;
    List<SnapPoint> snapPoints = this.GetSnapPoints();
    SnapPoint snapPoint1 = snapPoints.First<SnapPoint>((Func<SnapPoint, bool>) (a => a.Name == "Back"));
    SnapPoint snapPoint2 = snapPoints.First<SnapPoint>((Func<SnapPoint, bool>) (a => a.Name == "Create"));
    UILinkPoint point1 = UILinkPointNavigator.Points[num3];
    point1.Unlink();
    UILinkPointNavigator.SetPosition(num3, snapPoint1.Position);
    int num4 = num3 + 1;
    UILinkPoint point2 = UILinkPointNavigator.Points[num4];
    point2.Unlink();
    UILinkPointNavigator.SetPosition(num4, snapPoint2.Position);
    int num5 = num4 + 1;
    point1.Right = point2.ID;
    point2.Left = point1.ID;
    this._foundPoints.Clear();
    this._foundPoints.Add(point1.ID);
    this._foundPoints.Add(point2.ID);
    List<SnapPoint> list1 = snapPoints.Where<SnapPoint>((Func<SnapPoint, bool>) (a => a.Name == "Top")).ToList<SnapPoint>();
    list1.Sort(new Comparison<SnapPoint>(this.SortPoints));
    for (int index = 0; index < list1.Count; ++index)
    {
      UILinkPoint point3 = UILinkPointNavigator.Points[num5];
      point3.Unlink();
      UILinkPointNavigator.SetPosition(num5, list1[index].Position);
      point3.Left = num5 - 1;
      point3.Right = num5 + 1;
      point3.Down = num2;
      if (index == 0)
        point3.Left = -3;
      if (index == list1.Count - 1)
        point3.Right = -4;
      if (this._selectedPicker == UICharacterCreation.CategoryId.HairStyle || this._selectedPicker == UICharacterCreation.CategoryId.Clothing)
        point3.Down = num2 + index;
      this._foundPoints.Add(num5);
      ++num5;
    }
    List<SnapPoint> list2 = snapPoints.Where<SnapPoint>((Func<SnapPoint, bool>) (a => a.Name == "Middle")).ToList<SnapPoint>();
    list2.Sort(new Comparison<SnapPoint>(this.SortPoints));
    int ptid1 = num2;
    switch (this._selectedPicker)
    {
      case UICharacterCreation.CategoryId.CharInfo:
        for (int index = 0; index < list2.Count; ++index)
        {
          UILinkPoint andSet = this.GetAndSet(ptid1, list2[index]);
          andSet.Up = andSet.ID - 1;
          andSet.Down = andSet.ID + 1;
          if (index == 0)
            andSet.Up = num1 + 2;
          if (index == list2.Count - 1)
          {
            andSet.Down = point1.ID;
            point1.Up = andSet.ID;
            point2.Up = andSet.ID;
          }
          this._foundPoints.Add(ptid1);
          ++ptid1;
        }
        break;
      case UICharacterCreation.CategoryId.Clothing:
        List<SnapPoint> list3 = snapPoints.Where<SnapPoint>((Func<SnapPoint, bool>) (a => a.Name == "Preview")).ToList<SnapPoint>();
        list3.Sort(new Comparison<SnapPoint>(this.SortPoints));
        List<SnapPoint> list4 = snapPoints.Where<SnapPoint>((Func<SnapPoint, bool>) (a => a.Name == "Low")).ToList<SnapPoint>();
        list4.Sort(new Comparison<SnapPoint>(this.SortPoints));
        int num6 = -2;
        SnapPoint point4 = (SnapPoint) null;
        UILinkPoint uiLinkPoint1 = (UILinkPoint) null;
        if (this._pitchSlider.GetSnapPoint(out point4))
        {
          uiLinkPoint1 = this.GetAndSet(num2 + 40, point4);
          this._foundPoints.Add(uiLinkPoint1.ID);
        }
        uiLinkPoint1.Down = point1.ID;
        int num7 = num2 + 20;
        int ptid2 = num2 + 20;
        int num8 = ptid2 + list4.Count;
        UILinkPoint uiLinkPoint2 = (UILinkPoint) null;
        for (int index = 0; index < list4.Count; ++index)
        {
          UILinkPoint andSet = this.GetAndSet(ptid2, list4[index]);
          andSet.Up = num2 + index + 2;
          andSet.Down = uiLinkPoint1.ID;
          if (index >= 3)
          {
            andSet.Up = num8 + (index - 3) + 1;
            andSet.Down = point2.ID;
          }
          andSet.Left = andSet.ID - 1;
          andSet.Right = andSet.ID + 1;
          if (index == 0)
          {
            num6 = andSet.ID;
            andSet.Left = andSet.ID + 5;
            point1.Up = andSet.ID;
          }
          if (index == list4.Count - 1)
          {
            int id = andSet.ID;
            andSet.Right = andSet.ID - 5;
            point2.Up = andSet.ID;
          }
          if (index == 1)
            uiLinkPoint2 = andSet;
          this._foundPoints.Add(ptid2);
          ++ptid2;
        }
        for (int index = 0; index < list3.Count; ++index)
        {
          UILinkPoint andSet = this.GetAndSet(ptid2, list3[index]);
          andSet.Up = num2 + index + 5;
          andSet.Down = num7 + ((int) MathHelper.Clamp((float) index, 1f, 4f) - 1) + 3;
          andSet.Left = andSet.ID - 1;
          andSet.Right = andSet.ID + 1;
          if (index == 0)
            andSet.Left = num7 + 2;
          if (index == list3.Count - 1)
            andSet.Right = num7;
          this._foundPoints.Add(ptid2);
          ++ptid2;
        }
        if (list4.Count > 1)
          uiLinkPoint1.Up = uiLinkPoint2.ID;
        point1.Up = uiLinkPoint1.ID;
        int ptid3 = num2;
        for (int index = 0; index < list2.Count; ++index)
        {
          UILinkPoint andSet = this.GetAndSet(ptid3, list2[index]);
          andSet.Up = num1 + 2 + index;
          andSet.Left = andSet.ID - 1;
          andSet.Right = andSet.ID + 1;
          if (index == 0)
            andSet.Left = andSet.ID + 9;
          if (index == list2.Count - 1)
            andSet.Right = andSet.ID - 9;
          andSet.Down = num6;
          if (index >= 5)
            andSet.Down = num8 + index - 5;
          this._foundPoints.Add(ptid3);
          ++ptid3;
        }
        break;
      case UICharacterCreation.CategoryId.HairStyle:
        if (list2.Count != 0)
        {
          this._helper.CullPointsOutOfElementArea(spriteBatch, list2, this._hairstylesContainer);
          SnapPoint snapPoint3 = list2[list2.Count - 1];
          int num9 = snapPoint3.Id / 10;
          int num10 = snapPoint3.Id % 10;
          int count = Main.Hairstyles.AvailableHairstyles.Count;
          for (int index = 0; index < list2.Count; ++index)
          {
            SnapPoint snap = list2[index];
            UILinkPoint andSet = this.GetAndSet(ptid1, snap);
            andSet.Left = andSet.ID - 1;
            if (snap.Id == 0)
              andSet.Left = -3;
            andSet.Right = andSet.ID + 1;
            if (snap.Id == count - 1)
              andSet.Right = -4;
            andSet.Up = andSet.ID - 10;
            if (index < 10)
              andSet.Up = num1 + 2 + index;
            andSet.Down = andSet.ID + 10;
            if (snap.Id + 10 > snapPoint3.Id)
              andSet.Down = snap.Id % 10 >= 5 ? point2.ID : point1.ID;
            if (index == list2.Count - 1)
            {
              point1.Up = andSet.ID;
              point2.Up = andSet.ID;
            }
            this._foundPoints.Add(ptid1);
            ++ptid1;
          }
          break;
        }
        break;
      default:
        List<SnapPoint> list5 = snapPoints.Where<SnapPoint>((Func<SnapPoint, bool>) (a => a.Name == "Low")).ToList<SnapPoint>();
        list5.Sort(new Comparison<SnapPoint>(this.SortPoints));
        int ptid4 = num2 + 20;
        for (int index = 0; index < list5.Count; ++index)
        {
          UILinkPoint andSet = this.GetAndSet(ptid4, list5[index]);
          andSet.Up = num2 + 2;
          andSet.Down = point1.ID;
          andSet.Left = andSet.ID - 1;
          andSet.Right = andSet.ID + 1;
          if (index == 0)
          {
            andSet.Left = andSet.ID + 2;
            point1.Up = andSet.ID;
          }
          if (index == list5.Count - 1)
          {
            andSet.Right = andSet.ID - 2;
            point2.Up = andSet.ID;
          }
          this._foundPoints.Add(ptid4);
          ++ptid4;
        }
        int ptid5 = num2;
        for (int index = 0; index < list2.Count; ++index)
        {
          UILinkPoint andSet = this.GetAndSet(ptid5, list2[index]);
          andSet.Up = andSet.ID - 1;
          andSet.Down = andSet.ID + 1;
          if (index == 0)
            andSet.Up = num1 + 2 + 5;
          if (index == list2.Count - 1)
            andSet.Down = num2 + 20 + 2;
          this._foundPoints.Add(ptid5);
          ++ptid5;
        }
        break;
    }
    if (!PlayerInput.UsingGamepadUI || this._foundPoints.Contains(UILinkPointNavigator.CurrentPoint))
      return;
    this.MoveToVisuallyClosestPoint();
  }

  private void MoveToVisuallyClosestPoint()
  {
    Dictionary<int, UILinkPoint> points = UILinkPointNavigator.Points;
    Vector2 mouseScreen = Main.MouseScreen;
    UILinkPoint uiLinkPoint1 = (UILinkPoint) null;
    foreach (int foundPoint in this._foundPoints)
    {
      UILinkPoint uiLinkPoint2;
      if (!points.TryGetValue(foundPoint, out uiLinkPoint2))
        return;
      if (uiLinkPoint1 == null || (double) Vector2.Distance(mouseScreen, uiLinkPoint1.Position) > (double) Vector2.Distance(mouseScreen, uiLinkPoint2.Position))
        uiLinkPoint1 = uiLinkPoint2;
    }
    if (uiLinkPoint1 == null)
      return;
    UILinkPointNavigator.ChangePoint(uiLinkPoint1.ID);
  }

  public void TryMovingCategory(int direction)
  {
    int selection = (int) (this._selectedPicker + direction) % 10;
    if (selection < 0)
      selection += 10;
    this.SelectColorPicker((UICharacterCreation.CategoryId) selection);
  }

  private UILinkPoint GetAndSet(int ptid, SnapPoint snap)
  {
    UILinkPoint point = UILinkPointNavigator.Points[ptid];
    point.Unlink();
    UILinkPointNavigator.SetPosition(point.ID, snap.Position);
    return point;
  }

  private bool PointWithName(SnapPoint a, string comp) => a.Name == comp;

  private int SortPoints(SnapPoint a, SnapPoint b) => a.Id.CompareTo(b.Id);

  private static Color ScaledHslToRgb(Vector3 hsl)
  {
    return UICharacterCreation.ScaledHslToRgb(hsl.X, hsl.Y, hsl.Z);
  }

  private static Color ScaledHslToRgb(float hue, float saturation, float luminosity)
  {
    return Main.hslToRgb(hue, saturation, (float) ((double) luminosity * 0.85000002384185791 + 0.15000000596046448));
  }

  private static Vector3 RgbToScaledHsl(Color color)
  {
    Vector3 hsl = Main.rgbToHsl(color);
    hsl.Z = (float) (((double) hsl.Z - 0.15000000596046448) / 0.85000002384185791);
    return Vector3.Clamp(hsl, Vector3.Zero, Vector3.One);
  }

  public void HandleBackButtonUsage()
  {
    if (this._selectedPicker != UICharacterCreation.CategoryId.CharInfo)
    {
      SoundEngine.PlaySound(12);
      this.UnselectAllCategories();
      this._selectedPicker = UICharacterCreation.CategoryId.CharInfo;
      this._middleContainer.Append(this._infoContainer);
      this._charInfoCategoryButton.SetSelected(true);
    }
    else
      UICharacterCreation.GoBack();
  }

  private enum CategoryId
  {
    CharInfo,
    Clothing,
    HairStyle,
    HairColor,
    Eye,
    Skin,
    Shirt,
    Undershirt,
    Pants,
    Shoes,
    Count,
  }

  private enum HSLSliderId
  {
    Hue,
    Saturation,
    Luminance,
  }

  private struct ArmorAssignments
  {
    public int HeadItem;
    public int BodyItem;
    public int LegItem;
    public int Accessory1Item;
  }
}
