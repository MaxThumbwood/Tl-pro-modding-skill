// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Drawing.EmptyHorizonRenderer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

#nullable disable
namespace Terraria.GameContent.Drawing;

public class EmptyHorizonRenderer : IHorizonRenderer
{
  public void DrawHorizon()
  {
    if (!Main.ShouldDrawSurfaceBackground())
      return;
    foreach (BackgroundGradientDrawer backgroundDrawer in SunGradients.BackgroundDrawers)
      backgroundDrawer.Draw();
  }

  public void DrawLensFlare()
  {
  }

  public void ModifyHorizonLight(ref Color color)
  {
  }

  public void DrawSun(Vector2 sunPosition)
  {
  }

  public void DrawSurfaceLayer(int layerIndex)
  {
  }

  public void CloudsStart()
  {
  }

  public void DrawCloud(float globalCloudAlpha, Cloud theCloud, int cloudPass, float cY)
  {
    Asset<Texture2D> tex = TextureAssets.Cloud[theCloud.type];
    Color color = theCloud.cloudColor(Main.ColorOfTheSkies);
    if (cloudPass == 1)
    {
      float num1 = theCloud.scale * 0.8f;
      float num2 = (float) (((double) theCloud.scale + 1.0) / 2.0 * 0.89999997615814209);
      color.R = (byte) ((double) color.R * (double) num1);
      color.G = (byte) ((double) color.G * (double) num2);
    }
    if ((double) Main.atmo < 1.0)
      color *= Main.atmo;
    Main.spriteBatch.Draw(tex.Value, new Vector2(theCloud.position.X, cY) + tex.Size() / 2f, new Rectangle?(), color * globalCloudAlpha, theCloud.rotation, tex.Size() / 2f, theCloud.scale, theCloud.spriteDir, 0.0f);
  }

  public void CloudsEnd()
  {
  }
}
