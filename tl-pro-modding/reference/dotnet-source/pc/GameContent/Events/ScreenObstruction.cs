// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Events.ScreenObstruction
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.GameContent.Events;

public class ScreenObstruction
{
  public static float lastSpeed = 0.1f;
  public static float screenObstruction;

  public static void Update(SceneState sceneState, SceneMetrics metrics)
  {
    float target = 0.0f;
    float amount = 0.1f;
    if (metrics.PerspectivePlayer.insideUnbreakableWalls)
    {
      int playerCanSafelyMatch = DangerousDungeonCurse.GetProgressPlayerCanSafelyMatch();
      int num = DangerousDungeonCurse.GetProgressPlayerNeedsToMatch(metrics.PerspectivePlayer) - playerCanSafelyMatch;
      if (num > 0)
      {
        float max = 0.9f;
        target = Utils.Clamp<float>(0.4f * (float) num, 0.0f, max);
        ScreenObstruction.lastSpeed = amount = 0.01f;
      }
    }
    if (metrics.PerspectivePlayer.headcovered)
    {
      target = 0.95f;
      ScreenObstruction.lastSpeed = amount = 0.3f;
    }
    if ((double) target == 0.0 && (double) ScreenObstruction.screenObstruction != 0.0)
      amount = ScreenObstruction.lastSpeed;
    else
      ScreenObstruction.lastSpeed = amount;
    sceneState.MoveTowards(ref ScreenObstruction.screenObstruction, target, amount);
  }

  public static void Draw(SpriteBatch spriteBatch)
  {
    if ((double) ScreenObstruction.screenObstruction == 0.0)
      return;
    Color color = Color.Black * ScreenObstruction.screenObstruction;
    int num1 = TextureAssets.Extra[49].Width();
    int num2 = 10;
    Rectangle rect = Main.SceneMetrics.PerspectivePlayer.getRect();
    rect.Inflate((num1 - rect.Width) / 2, (num1 - rect.Height) / 2 + num2 / 2);
    rect.Offset(-(int) Main.screenPosition.X, -(int) Main.screenPosition.Y + (int) Main.player[Main.myPlayer].gfxOffY - num2);
    Rectangle destinationRectangle1 = Rectangle.Union(new Rectangle(0, 0, 1, 1), new Rectangle(rect.Right - 1, rect.Top - 1, 1, 1));
    Rectangle destinationRectangle2 = Rectangle.Union(new Rectangle(Main.screenWidth - 1, 0, 1, 1), new Rectangle(rect.Right, rect.Bottom - 1, 1, 1));
    Rectangle destinationRectangle3 = Rectangle.Union(new Rectangle(Main.screenWidth - 1, Main.screenHeight - 1, 1, 1), new Rectangle(rect.Left, rect.Bottom, 1, 1));
    Rectangle destinationRectangle4 = Rectangle.Union(new Rectangle(0, Main.screenHeight - 1, 1, 1), new Rectangle(rect.Left - 1, rect.Top, 1, 1));
    spriteBatch.Draw(TextureAssets.MagicPixel.Value, destinationRectangle1, new Rectangle?(new Rectangle(0, 0, 1, 1)), color);
    spriteBatch.Draw(TextureAssets.MagicPixel.Value, destinationRectangle2, new Rectangle?(new Rectangle(0, 0, 1, 1)), color);
    spriteBatch.Draw(TextureAssets.MagicPixel.Value, destinationRectangle3, new Rectangle?(new Rectangle(0, 0, 1, 1)), color);
    spriteBatch.Draw(TextureAssets.MagicPixel.Value, destinationRectangle4, new Rectangle?(new Rectangle(0, 0, 1, 1)), color);
    spriteBatch.Draw(TextureAssets.Extra[49].Value, rect, color);
  }
}
