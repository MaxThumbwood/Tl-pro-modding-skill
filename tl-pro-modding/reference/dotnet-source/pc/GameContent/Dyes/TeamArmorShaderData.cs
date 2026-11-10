// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Dyes.TeamArmorShaderData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

#nullable disable
namespace Terraria.GameContent.Dyes;

public class TeamArmorShaderData : ArmorShaderData
{
  private static bool isInitialized;
  private static ArmorShaderData[] dustShaderData;

  public TeamArmorShaderData(Asset<Effect> shader, string passName)
    : base(shader, passName)
  {
    if (TeamArmorShaderData.isInitialized)
      return;
    TeamArmorShaderData.isInitialized = true;
    TeamArmorShaderData.dustShaderData = new ArmorShaderData[Main.teamColor.Length];
    for (int index = 1; index < Main.teamColor.Length; ++index)
      TeamArmorShaderData.dustShaderData[index] = new ArmorShaderData(shader, passName).UseColor(Main.teamColor[index]);
    TeamArmorShaderData.dustShaderData[0] = new ArmorShaderData(shader, "Default");
  }

  public override void Apply(Entity entity, DrawData? drawData)
  {
    if (!(entity is Player player) && entity is Projectile projectile && projectile.OwnedBySomeone)
      player = Main.player[projectile.owner];
    if (player == null || player.team == 0 || Main.netMode == 0)
    {
      TeamArmorShaderData.dustShaderData[0].Apply((Entity) player, drawData);
    }
    else
    {
      this.UseColor(Main.teamColor[player.team]);
      base.Apply((Entity) player, drawData);
    }
  }

  public override ArmorShaderData GetSecondaryShader(Entity entity)
  {
    Player player = entity as Player;
    return TeamArmorShaderData.dustShaderData[player.team];
  }
}
