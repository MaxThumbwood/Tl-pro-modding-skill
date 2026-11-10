// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.GroupOptionButton`1
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System.Collections.Generic;
using Terraria.Audio;
using Terraria.ID;
using Terraria.Localization;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class GroupOptionButton<T> : UIElement, IGroupOptionButton
{
  private T _currentOption;
  private readonly Asset<Texture2D> _BasePanelTexture;
  private readonly Asset<Texture2D> _selectedBorderTexture;
  private readonly Asset<Texture2D> _hoveredBorderTexture;
  private Asset<Texture2D> _iconTexture;
  private readonly T _myOption;
  private Color _color;
  private Color _borderColor;
  public float FadeFromBlack = 1f;
  public int InnerHighlightRim = 7;
  private float _whiteLerp = 0.7f;
  private float _opacity = 0.7f;
  private bool _hovered;
  private bool _soundedHover;
  public bool ShowHighlightWhenSelected = true;
  private bool _UseOverrideColors;
  private Color _overrideUnpickedColor = Color.White;
  private Color _overridePickedColor = Color.White;
  private float _overrideOpacityPicked;
  private float _overrideOpacityUnpicked;
  public readonly LocalizedText Description;
  private UIText _title;
  private float _iconScale = 1f;
  private Vector2 _iconOffset;
  private Rectangle? _iconFrame;
  private Color _iconColor = Color.White;

  public T OptionValue => this._myOption;

  public bool IsSelected => EqualityComparer<T>.Default.Equals(this._currentOption, this._myOption);

  public GroupOptionButton(
    T option,
    LocalizedText title,
    LocalizedText description,
    Color textColor,
    string iconTexturePath,
    float textSize = 1f,
    float titleAlignmentX = 0.5f,
    float titleWidthReduction = 10f)
  {
    this._borderColor = Color.White;
    this._currentOption = option;
    this._myOption = option;
    this.Description = description;
    this.Width = StyleDimension.FromPixels(44f);
    this.Height = StyleDimension.FromPixels(34f);
    this._BasePanelTexture = Main.Assets.Request<Texture2D>("Images/UI/CharCreation/PanelGrayscale", (AssetRequestMode) 1);
    this._selectedBorderTexture = Main.Assets.Request<Texture2D>("Images/UI/CharCreation/CategoryPanelHighlight", (AssetRequestMode) 1);
    this._hoveredBorderTexture = Main.Assets.Request<Texture2D>("Images/UI/CharCreation/CategoryPanelBorder", (AssetRequestMode) 1);
    if (iconTexturePath != null)
      this._iconTexture = Main.Assets.Request<Texture2D>(iconTexturePath, (AssetRequestMode) 1);
    this._color = Colors.InventoryDefaultColor;
    if (title == null)
      return;
    UIText uiText = new UIText(title, textSize);
    uiText.HAlign = titleAlignmentX;
    uiText.VAlign = 0.5f;
    uiText.Width = StyleDimension.FromPixelsAndPercent(-titleWidthReduction, 1f);
    uiText.Top = StyleDimension.FromPixels(0.0f);
    UIText element = uiText;
    element.TextColor = textColor;
    this.Append((UIElement) element);
    this._title = element;
  }

  public void SetText(LocalizedText text, float textSize, Color color)
  {
    if (this._title != null)
      this._title.Remove();
    UIText uiText = new UIText(text, textSize);
    uiText.HAlign = 0.5f;
    uiText.VAlign = 0.5f;
    uiText.Width = StyleDimension.FromPixelsAndPercent(-10f, 1f);
    uiText.Top = StyleDimension.FromPixels(0.0f);
    UIText element = uiText;
    element.TextColor = color;
    this.Append((UIElement) element);
    this._title = element;
  }

  public void SetTextWithoutLocalization(
    string text,
    float textSize,
    Color color,
    float hAlign,
    float left)
  {
    if (this._title != null)
      this._title.Remove();
    UIText uiText = new UIText(text, textSize);
    uiText.HAlign = 0.5f;
    uiText.VAlign = 0.5f;
    uiText.Width = StyleDimension.FromPixelsAndPercent(-10f, 1f);
    uiText.Top = StyleDimension.FromPixels(0.0f);
    uiText.IgnoresMouseInteraction = true;
    UIText element = uiText;
    element.TextOriginX = hAlign;
    element.Left.Pixels = left;
    element.TextColor = color;
    this.Append((UIElement) element);
    this._title = element;
  }

  public void SetCurrentOption(T option) => this._currentOption = option;

  public Texture2D Icon => this._iconTexture == null ? (Texture2D) null : this._iconTexture.Value;

  public void SetIcon(string iconTexturePath)
  {
    if (iconTexturePath != null)
      this._iconTexture = Main.Assets.Request<Texture2D>(iconTexturePath, (AssetRequestMode) 1);
    else
      this._iconTexture = (Asset<Texture2D>) null;
  }

  public void SetIconFrame(Rectangle region) => this._iconFrame = new Rectangle?(region);

  public float IconScale
  {
    get => this._iconScale;
    set => this._iconScale = value;
  }

  public Vector2 IconOffset
  {
    get => this._iconOffset;
    set => this._iconOffset = value;
  }

  public Color IconColor
  {
    get => this._iconColor;
    set => this._iconColor = value;
  }

  protected override void DrawSelf(SpriteBatch spriteBatch)
  {
    if (this._hovered)
    {
      if (!this._soundedHover)
        SoundEngine.PlaySound(12);
      this._soundedHover = true;
    }
    else
      this._soundedHover = false;
    CalculatedStyle dimensions = this.GetDimensions();
    Color color1 = this._color;
    float num = this._opacity;
    bool isSelected = this.IsSelected;
    if (this._UseOverrideColors)
    {
      color1 = isSelected ? this._overridePickedColor : this._overrideUnpickedColor;
      num = isSelected ? this._overrideOpacityPicked : this._overrideOpacityUnpicked;
    }
    Utils.DrawSplicedPanel(spriteBatch, this._BasePanelTexture.Value, (int) dimensions.X, (int) dimensions.Y, (int) dimensions.Width, (int) dimensions.Height, 10, 10, 10, 10, Color.Lerp(Color.Black, color1, this.FadeFromBlack) * num);
    if (isSelected && this.ShowHighlightWhenSelected)
      Utils.DrawSplicedPanel(spriteBatch, this._selectedBorderTexture.Value, (int) dimensions.X + this.InnerHighlightRim, (int) dimensions.Y + this.InnerHighlightRim, (int) dimensions.Width - this.InnerHighlightRim * 2, (int) dimensions.Height - this.InnerHighlightRim * 2, 10, 10, 10, 10, Color.Lerp(color1, Color.White, this._whiteLerp) * num);
    if (this._hovered)
      Utils.DrawSplicedPanel(spriteBatch, this._hoveredBorderTexture.Value, (int) dimensions.X, (int) dimensions.Y, (int) dimensions.Width, (int) dimensions.Height, 10, 10, 10, 10, this._borderColor);
    if (this._iconTexture == null)
      return;
    Color color2 = this.IconColor;
    if (!this._hovered && !isSelected)
      color2 = Color.Lerp(color1, color2, this._whiteLerp) * num;
    spriteBatch.Draw(this._iconTexture.Value, new Vector2(dimensions.X + 1f, dimensions.Y + 1f) + this._iconOffset, this._iconFrame, color2, 0.0f, Vector2.Zero, this._iconScale, SpriteEffects.None, 0.0f);
  }

  public override void LeftMouseDown(UIMouseEvent evt)
  {
    SoundEngine.PlaySound(12);
    base.LeftMouseDown(evt);
  }

  public override void MouseOver(UIMouseEvent evt)
  {
    base.MouseOver(evt);
    this._hovered = true;
  }

  public override void MouseOut(UIMouseEvent evt)
  {
    base.MouseOut(evt);
    this._hovered = false;
  }

  public void SetColor(Color color, float opacity)
  {
    this._color = color;
    this._opacity = opacity;
  }

  public void SetColorsBasedOnSelectionState(
    Color pickedColor,
    Color unpickedColor,
    float opacityPicked,
    float opacityNotPicked)
  {
    this._UseOverrideColors = true;
    this._overridePickedColor = pickedColor;
    this._overrideUnpickedColor = unpickedColor;
    this._overrideOpacityPicked = opacityPicked;
    this._overrideOpacityUnpicked = opacityNotPicked;
  }

  public void SetBorderColor(Color color) => this._borderColor = color;
}
