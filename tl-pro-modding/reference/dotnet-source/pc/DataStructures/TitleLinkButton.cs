// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.TitleLinkButton
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ReLogic.OS;
using System;
using Terraria.Audio;
using Terraria.GameInput;
using Terraria.Localization;

#nullable disable
namespace Terraria.DataStructures;

public class TitleLinkButton
{
  private static Item _fakeItem = new Item();
  public string TooltipTextKey;
  public string LinkUrl;
  public Asset<Texture2D> Image;
  public Rectangle? FrameWhenNotSelected;
  public Rectangle? FrameWehnSelected;

  public void Draw(SpriteBatch spriteBatch, Vector2 anchorPosition)
  {
    Rectangle r1 = this.Image.Frame();
    if (this.FrameWhenNotSelected.HasValue)
      r1 = this.FrameWhenNotSelected.Value;
    Vector2 vector2 = r1.Size();
    Vector2 minimum = anchorPosition - vector2 / 2f;
    bool flag = false;
    if (Main.MouseScreen.Between(minimum, minimum + vector2))
    {
      Main.LocalPlayer.mouseInterface = true;
      flag = true;
      this.DrawTooltip();
      this.TryClicking();
    }
    Rectangle? nullable = flag ? this.FrameWehnSelected : this.FrameWhenNotSelected;
    Rectangle r2 = this.Image.Frame();
    if (nullable.HasValue)
      r2 = nullable.Value;
    Texture2D texture = this.Image.Value;
    spriteBatch.Draw(texture, anchorPosition, new Rectangle?(r2), Color.White, 0.0f, r2.Size() / 2f, 1f, SpriteEffects.None, 0.0f);
  }

  private void DrawTooltip()
  {
    Item fakeItem = TitleLinkButton._fakeItem;
    fakeItem.SetDefaults(0);
    fakeItem.SetNameOverride(Language.GetTextValue(this.TooltipTextKey));
    fakeItem.type = 1;
    fakeItem.scale = 0.0f;
    fakeItem.rare = 8;
    fakeItem.value = -1;
    Main.HoverItem = TitleLinkButton._fakeItem;
    Main.instance.MouseText("");
    Main.mouseText = true;
  }

  private void TryClicking()
  {
    if (PlayerInput.IgnoreMouseInterface || !Main.mouseLeft || !Main.mouseLeftRelease)
      return;
    SoundEngine.PlaySound(10);
    Main.mouseLeftRelease = false;
    this.OpenLink();
  }

  private void OpenLink()
  {
    try
    {
      Platform.Get<IPathService>().OpenURL(this.LinkUrl);
    }
    catch
    {
      Console.WriteLine("Failed to open link?!");
    }
  }
}
