// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UIClothStyleButton
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using Terraria.Audio;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UIClothStyleButton : UIElement
{
  private readonly Player _player;
  public readonly int ClothStyleId;
  private readonly Asset<Texture2D> _BasePanelTexture;
  private readonly Asset<Texture2D> _selectedBorderTexture;
  private readonly Asset<Texture2D> _hoveredBorderTexture;
  private readonly UICharacter _char;
  private bool _hovered;
  private bool _soundedHover;
  private int _realSkinVariant;
  private Action PrepareAction;

  public UIClothStyleButton(Player player, int clothStyleId, Action prepareAction = null)
  {
    this._player = player;
    this.ClothStyleId = clothStyleId;
    this.PrepareAction = prepareAction;
    this.Width = StyleDimension.FromPixels(44f);
    this.Height = StyleDimension.FromPixels(80f);
    this._BasePanelTexture = Main.Assets.Request<Texture2D>("Images/UI/CharCreation/CategoryPanel", (AssetRequestMode) 1);
    this._selectedBorderTexture = Main.Assets.Request<Texture2D>("Images/UI/CharCreation/CategoryPanelHighlight", (AssetRequestMode) 1);
    this._hoveredBorderTexture = Main.Assets.Request<Texture2D>("Images/UI/CharCreation/CategoryPanelBorder", (AssetRequestMode) 1);
    UICharacter uiCharacter = new UICharacter(this._player, hasBackPanel: false);
    uiCharacter.HAlign = 0.5f;
    uiCharacter.VAlign = 0.5f;
    this._char = uiCharacter;
    this.Append((UIElement) this._char);
  }

  public override void Draw(SpriteBatch spriteBatch)
  {
    this._realSkinVariant = this._player.skinVariant;
    this._player.skinVariant = this.ClothStyleId;
    int hair = this._player.hair;
    if (this.PrepareAction != null)
      this.PrepareAction();
    this._player.PlayerFrame();
    base.Draw(spriteBatch);
    this._player.skinVariant = this._realSkinVariant;
    this._player.hair = hair;
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
    Utils.DrawSplicedPanel(spriteBatch, this._BasePanelTexture.Value, (int) dimensions.X, (int) dimensions.Y, (int) dimensions.Width, (int) dimensions.Height, 10, 10, 10, 10, Color.White * 0.5f);
    if (this._realSkinVariant == this.ClothStyleId)
      Utils.DrawSplicedPanel(spriteBatch, this._selectedBorderTexture.Value, (int) dimensions.X + 3, (int) dimensions.Y + 3, (int) dimensions.Width - 6, (int) dimensions.Height - 6, 10, 10, 10, 10, Color.White);
    if (!this._hovered)
      return;
    Utils.DrawSplicedPanel(spriteBatch, this._hoveredBorderTexture.Value, (int) dimensions.X, (int) dimensions.Y, (int) dimensions.Width, (int) dimensions.Height, 10, 10, 10, 10, Color.White);
  }

  public override void LeftMouseDown(UIMouseEvent evt) => base.LeftMouseDown(evt);

  public override void MouseOver(UIMouseEvent evt)
  {
    base.MouseOver(evt);
    this._hovered = true;
    this._char.SetAnimated(true);
  }

  public override void MouseOut(UIMouseEvent evt)
  {
    base.MouseOut(evt);
    this._hovered = false;
    this._char.SetAnimated(false);
  }
}
