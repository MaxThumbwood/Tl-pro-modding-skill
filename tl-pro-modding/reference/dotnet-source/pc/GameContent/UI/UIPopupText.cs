// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.UIPopupText
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent.UI;

public class UIPopupText
{
  public Vector2 position;
  public Vector2 velocity;
  public float alpha;
  public int alphaDir = 1;
  public string name;
  public string displayText;
  public float scale = 1f;
  public float rotation;
  public Color color;
  public bool active;
  public int lifeTime;
  public int framesSinceSpawn;
  public static int activeTime = 60;
  public UIPopupTextContext context;

  public float TargetScale => 1f;

  public void PrepareDisplayText() => this.displayText = this.name;

  public void Update(int whoAmI, UIPopupTextManager manager)
  {
    if (!this.active)
      return;
    ++this.framesSinceSpawn;
    float targetScale = this.TargetScale;
    this.alpha += (float) this.alphaDir * 0.01f;
    if ((double) this.alpha <= 0.7)
    {
      this.alpha = 0.7f;
      this.alphaDir = 1;
    }
    if ((double) this.alpha >= 1.0)
    {
      this.alpha = 1f;
      this.alphaDir = -1;
    }
    bool flag = false;
    Vector2 textHitbox1 = this.GetTextHitbox();
    Rectangle rectangle1 = new Rectangle((int) ((double) this.position.X - (double) textHitbox1.X / 2.0), (int) ((double) this.position.Y - (double) textHitbox1.Y / 2.0), (int) textHitbox1.X, (int) textHitbox1.Y);
    for (int index = 0; index < 20; ++index)
    {
      UIPopupText uiPopupText = manager.popupText[index];
      if (uiPopupText.active && index != whoAmI)
      {
        Vector2 textHitbox2 = uiPopupText.GetTextHitbox();
        Rectangle rectangle2 = new Rectangle((int) ((double) uiPopupText.position.X - (double) textHitbox2.X / 2.0), (int) ((double) uiPopupText.position.Y - (double) textHitbox2.Y / 2.0), (int) textHitbox2.X, (int) textHitbox2.Y);
        if (rectangle1.Intersects(rectangle2) && ((double) this.position.Y < (double) uiPopupText.position.Y || (double) this.position.Y == (double) uiPopupText.position.Y && whoAmI < index))
        {
          flag = true;
          int num = manager.numActive;
          if (num > 3)
            num = 3;
          uiPopupText.lifeTime = UIPopupText.activeTime + 15 * num;
          this.lifeTime = UIPopupText.activeTime + 15 * num;
        }
      }
    }
    if (!flag)
    {
      if (this.context != UIPopupTextContext.SpecialSeed || (double) this.scale != (double) targetScale && this.lifeTime > 0)
      {
        this.velocity.Y *= 0.86f;
        if ((double) this.scale == (double) targetScale)
          this.velocity.Y *= 0.4f;
      }
    }
    else if ((double) this.velocity.Y > -6.0)
      this.velocity.Y -= 0.2f;
    else
      this.velocity.Y *= 0.86f;
    this.velocity.X *= 0.93f;
    this.position += this.velocity;
    --this.lifeTime;
    if (this.lifeTime <= 0)
    {
      this.scale -= 0.03f * targetScale;
      if ((double) this.scale < 0.1 * (double) targetScale)
        this.active = false;
      this.lifeTime = 0;
    }
    else
    {
      if ((double) this.scale < (double) targetScale)
        this.scale += 0.1f * targetScale;
      if ((double) this.scale <= (double) targetScale)
        return;
      this.scale = targetScale;
    }
  }

  public Vector2 GetTextHitbox()
  {
    string displayText = this.displayText;
    Vector2 textHitbox = FontAssets.MouseText.Value.MeasureString(displayText) * this.scale;
    textHitbox.Y *= 0.8f;
    return textHitbox;
  }
}
