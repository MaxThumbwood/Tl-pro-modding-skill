// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.LightDiscDrawer
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
public struct LightDiscDrawer
{
  private static VertexStrip _vertexStrip = new VertexStrip();

  public void Draw(Projectile proj)
  {
    MiscShaderData miscShaderData = GameShaders.Misc["LightDisc"];
    miscShaderData.UseSaturation(-2.8f);
    miscShaderData.UseOpacity(2f);
    miscShaderData.Apply(new DrawData?());
    LightDiscDrawer._vertexStrip.PrepareStripWithProceduralPadding(proj.oldPos, proj.oldRot, new VertexStrip.StripColorFunction(this.StripColors), new VertexStrip.StripHalfWidthFunction(this.StripWidth), -Main.screenPosition + proj.Size / 2f);
    LightDiscDrawer._vertexStrip.DrawTrail();
    Main.pixelShader.CurrentTechnique.Passes[0].Apply();
  }

  private Color StripColors(float progressOnStrip)
  {
    float num = 1f - progressOnStrip;
    return (new Color(48 /*0x30*/, 63 /*0x3F*/, 150) * (num * num * num * num) * 0.5f) with
    {
      A = 0
    };
  }

  private float StripWidth(float progressOnStrip) => 16f;
}
