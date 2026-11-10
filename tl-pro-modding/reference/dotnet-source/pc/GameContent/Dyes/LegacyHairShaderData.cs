// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Dyes.LegacyHairShaderData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Shaders;

#nullable disable
namespace Terraria.GameContent.Dyes;

public class LegacyHairShaderData : HairShaderData
{
  private LegacyHairShaderData.ColorProcessingMethod _colorProcessor;

  public LegacyHairShaderData()
    : base((Asset<Effect>) null, (string) null)
  {
    this._shaderDisabled = true;
  }

  public override Color GetColor(Player player, Color lightColor)
  {
    bool lighting = true;
    Color color = this._colorProcessor(player, player.hairColor, ref lighting);
    return lighting ? new Color(color.ToVector4() * lightColor.ToVector4()) : color;
  }

  public LegacyHairShaderData UseLegacyMethod(
    LegacyHairShaderData.ColorProcessingMethod colorProcessor)
  {
    this._colorProcessor = colorProcessor;
    return this;
  }

  public delegate Color ColorProcessingMethod(Player player, Color color, ref bool lighting);
}
