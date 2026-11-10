// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Events.ScreenDarkness
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.GameContent.Events;

public class ScreenDarkness
{
  public static float screenObstruction;
  public static Color frontColor = new Color(0, 0, 120);

  public static void Update(SceneState sceneState, SceneMetrics metrics)
  {
    float target = 0.0f;
    float amount = 0.0166666675f;
    Vector2 center = metrics.Center;
    for (int index = 0; index < Main.maxNPCs; ++index)
    {
      if (Main.npc[index].active && Main.npc[index].type == 370 && (double) Main.npc[index].Distance(center) < 3000.0 && ((double) Main.npc[index].ai[0] >= 10.0 || (double) Main.npc[index].ai[0] == 9.0 && (double) Main.npc[index].ai[2] > 120.0))
      {
        target = 0.95f;
        ScreenDarkness.frontColor = new Color(0, 0, 120) * 0.3f;
        amount = 0.03f;
      }
      if (Main.npc[index].active && Main.npc[index].type == 113 && (double) Main.npc[index].Distance(center) < 3000.0)
      {
        float num = Utils.Remap(Main.npc[index].Distance(center), 2000f, 3000f, 1f, 0.0f);
        target = Main.npc[index].localAI[1] * num;
        amount = 1f;
        ScreenDarkness.frontColor = Color.Black;
      }
    }
    sceneState.MoveTowards(ref ScreenDarkness.screenObstruction, target, amount);
  }

  public static void DrawBack(SpriteBatch spriteBatch)
  {
    if ((double) ScreenDarkness.screenObstruction == 0.0)
      return;
    Color color = Color.Black * ScreenDarkness.screenObstruction;
    spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(-2, -2, Main.screenWidth + 4, Main.screenHeight + 4), new Rectangle?(new Rectangle(0, 0, 1, 1)), color);
  }

  public static void DrawFront(SpriteBatch spriteBatch)
  {
    if ((double) ScreenDarkness.screenObstruction == 0.0)
      return;
    Color color = ScreenDarkness.frontColor * ScreenDarkness.screenObstruction;
    spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(-2, -2, Main.screenWidth + 4, Main.screenHeight + 4), new Rectangle?(new Rectangle(0, 0, 1, 1)), color);
  }
}
