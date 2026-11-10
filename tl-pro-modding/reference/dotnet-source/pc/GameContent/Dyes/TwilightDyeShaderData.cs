// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Dyes.TwilightDyeShaderData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

#nullable disable
namespace Terraria.GameContent.Dyes;

public class TwilightDyeShaderData(Asset<Effect> shader, string passName) : ArmorShaderData(shader, passName)
{
  public override void Apply(Entity entity, DrawData? drawData)
  {
    if (drawData.HasValue)
    {
      switch (entity)
      {
        case Player player when !player.isDisplayDollOrInanimate && !player.isHatRackDoll:
          this.UseTargetPosition(Main.screenPosition + drawData.Value.position);
          break;
        case Projectile _:
          this.UseTargetPosition(Main.screenPosition + drawData.Value.position);
          break;
        default:
          this.UseTargetPosition(drawData.Value.position);
          break;
      }
    }
    base.Apply(entity, drawData);
  }
}
