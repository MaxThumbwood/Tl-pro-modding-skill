// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UIDebugCommandItem
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System.Collections.Generic;
using Terraria.Enums;
using Terraria.Localization;
using Terraria.Testing.ChatCommands;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UIDebugCommandItem : UIPanel
{
  public readonly IDebugCommand Command;
  private readonly Asset<Texture2D> _dividerTexture;
  private readonly Asset<Texture2D> _innerPanelTexture;
  private readonly UIText _hoverInfoLabel;
  private ItemTooltip _preparedTooltip;

  public int Order { get; set; }

  public UIDebugCommandItem(IDebugCommand command, int order)
  {
    this.Command = command;
    this.Order = order;
    this.Height.Set(30f, 0.0f);
    this.Width.Set(0.0f, 1f);
    this.SetPadding(6f);
    this.BorderColor = Color.Transparent;
    this.BackgroundColor = Color.Transparent;
    this._dividerTexture = Main.Assets.Request<Texture2D>("Images/UI/Divider", (AssetRequestMode) 1);
    this._innerPanelTexture = Main.Assets.Request<Texture2D>("Images/UI/InnerPanelBackground", (AssetRequestMode) 1);
    this._hoverInfoLabel = new UIText("");
    this._hoverInfoLabel.VAlign = 1f;
    this._hoverInfoLabel.Left.Set(80f, 0.0f);
    this._hoverInfoLabel.Top.Set(-3f, 0.0f);
    this.Append((UIElement) this._hoverInfoLabel);
  }

  protected override void DrawSelf(SpriteBatch spriteBatch)
  {
    string name = this.Command.Name;
    string text = this.Command.Description ?? "";
    string helpText = this.Command.HelpText;
    string str = "Authority:  " + (object) this.Command.Requirements;
    base.DrawSelf(spriteBatch);
    if (this.IsMouseHovering)
    {
      Item fakeItem = Main.DisplayAndGetFakeItem(ItemRarityColor.StrongRed10);
      fakeItem.SetNameOverride(name);
      fakeItem.ToolTip = this._preparedTooltip;
    }
    CalculatedStyle innerDimensions = this.GetInnerDimensions();
    Vector2 vector2 = innerDimensions.Position() - innerDimensions.Position();
    float num1 = 6f;
    float num2 = vector2.X + num1;
    float num3 = 21f;
    FontAssets.MouseText.Value.MeasureString(name);
    Color color1 = Color.White;
    Color color2 = Color.Gold;
    if (!this.CanCurrentlyBeUsed())
    {
      color1 = Color.DarkGray;
      color2 = Color.DarkGray;
    }
    Utils.DrawBorderString(spriteBatch, name, innerDimensions.Position() + new Vector2(num2 + 6f, vector2.Y - 2f), color1, 1.1f);
    Utils.DrawBorderString(spriteBatch, text, innerDimensions.Position() + new Vector2((float) ((double) num2 + 6.0 + 180.0 + 16.0), vector2.Y + 2f + num3), color2, 0.8f, anchory: 1f);
  }

  private bool CanCurrentlyBeUsed()
  {
    return (this.Command.Requirements & ~CommandRequirement.SinglePlayer) != (CommandRequirement) 0 || Main.netMode == 0;
  }

  public override int CompareTo(object obj)
  {
    return this.Order.CompareTo(((UIDebugCommandItem) obj).Order);
  }

  public override void MouseOver(UIMouseEvent evt)
  {
    base.MouseOver(evt);
    this.BackgroundColor = new Color(76, 90, 149);
    this.BorderColor = new Color(50, 60, 86);
    ItemTooltip preparedTooltip = this._preparedTooltip;
    List<string> stringList = new List<string>()
    {
      FontAssets.ItemStack.Value.CreateWrappedText((this.Command.Description ?? "").Replace("\n", " "), 480f, Language.ActiveCulture.CultureInfo)
    };
    stringList.Add(" ");
    stringList.Add("Authority:  " + (object) this.Command.Requirements);
    this._preparedTooltip = ItemTooltip.FromHardcodedText(stringList.ToArray());
  }

  public override void MouseOut(UIMouseEvent evt)
  {
    base.MouseOut(evt);
    this.BackgroundColor = this.BorderColor = Color.Transparent;
  }

  public override void LeftClick(UIMouseEvent evt)
  {
    IngameFancyUI.Close();
    Main.drawingPlayerChat = true;
    Main.chatText = $"/{this.Command.Name.ToLower()} ";
    Main.NewText($"Chat has been set to \"{Main.chatText}\"", B: (byte) 0);
  }

  private void DrawPanel(SpriteBatch spriteBatch, Vector2 position, float width)
  {
    spriteBatch.Draw(this._innerPanelTexture.Value, position, new Rectangle?(new Rectangle(0, 0, 8, this._innerPanelTexture.Height())), Color.White);
    spriteBatch.Draw(this._innerPanelTexture.Value, new Vector2(position.X + 8f, position.Y), new Rectangle?(new Rectangle(8, 0, 8, this._innerPanelTexture.Height())), Color.White, 0.0f, Vector2.Zero, new Vector2((float) (((double) width - 16.0) / 8.0), 1f), SpriteEffects.None, 0.0f);
    spriteBatch.Draw(this._innerPanelTexture.Value, new Vector2((float) ((double) position.X + (double) width - 8.0), position.Y), new Rectangle?(new Rectangle(16 /*0x10*/, 0, 8, this._innerPanelTexture.Height())), Color.White);
  }
}
