// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.TreePaintingSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.GameContent;

public class TreePaintingSettings
{
  public float SpecialGroupMinimalHueValue;
  public float SpecialGroupMaximumHueValue;
  public float SpecialGroupMinimumSaturationValue;
  public float SpecialGroupMaximumSaturationValue;
  public float HueTestOffset;
  public bool UseSpecialGroups;
  public bool UseWallShaderHacks;
  public bool InvertSpecialGroupResult;

  public void ApplyShader(int paintColor, Effect shader)
  {
    shader.Parameters["leafHueTestOffset"].SetValue(this.HueTestOffset);
    shader.Parameters["leafMinHue"].SetValue(this.SpecialGroupMinimalHueValue);
    shader.Parameters["leafMaxHue"].SetValue(this.SpecialGroupMaximumHueValue);
    shader.Parameters["leafMinSat"].SetValue(this.SpecialGroupMinimumSaturationValue);
    shader.Parameters["leafMaxSat"].SetValue(this.SpecialGroupMaximumSaturationValue);
    shader.Parameters["invertSpecialGroupResult"].SetValue(this.InvertSpecialGroupResult);
    int tileShaderIndex = Main.ConvertPaintIdToTileShaderIndex(paintColor, this.UseSpecialGroups, this.UseWallShaderHacks);
    shader.CurrentTechnique.Passes[tileShaderIndex].Apply();
  }
}
