// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.RainbowRodDrawer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Runtime.InteropServices;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

#nullable disable
namespace Terraria.Graphics;

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct RainbowRodDrawer
{
  private static VertexStrip _vertexStrip = new VertexStrip();

  public void Draw(Projectile proj)
  {
    MiscShaderData miscShaderData = GameShaders.Misc["RainbowRod"];
    miscShaderData.UseSaturation(-2.8f);
    miscShaderData.UseOpacity(4f);
    miscShaderData.Apply(new DrawData?());
    RainbowRodDrawer._vertexStrip.PrepareStripWithProceduralPadding(proj.oldPos, proj.oldRot, new VertexStrip.StripColorFunction(this.StripColors), new VertexStrip.StripHalfWidthFunction(this.StripWidth), -Main.screenPosition + proj.Size / 2f);
    RainbowRodDrawer._vertexStrip.DrawTrail();
    Main.pixelShader.CurrentTechnique.Passes[0].Apply();
  }

  private Color StripColors(float progressOnStrip)
  {
    return (Color.Lerp(Color.White, Main.hslToRgb((float) (((double) progressOnStrip * 1.6000000238418579 - (double) Main.GlobalTimeWrappedHourly) % 1.0), 1f, 0.5f), Utils.GetLerpValue(-0.2f, 0.5f, progressOnStrip, true)) * (1f - Utils.GetLerpValue(0.0f, 0.98f, progressOnStrip))) with
    {
      A = 0
    };
  }

  private float StripWidth(float progressOnStrip)
  {
    float num = 1f;
    float lerpValue = Utils.GetLerpValue(0.0f, 0.2f, progressOnStrip, true);
    return MathHelper.Lerp(0.0f, 32f, num * (float) (1.0 - (1.0 - (double) lerpValue) * (1.0 - (double) lerpValue)));
  }
}
