// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Items.WhipTagEffect_Kaleidoscope
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.GameContent.Drawing;

#nullable disable
namespace Terraria.GameContent.Items;

public class WhipTagEffect_Kaleidoscope : WhipTagEffect
{
  public override void OnTaggedHit(
    Player owner,
    Projectile optionalProjectile,
    NPC npcHit,
    int calcDamage)
  {
    ParticleOrchestrator.RequestParticleSpawn(false, ParticleOrchestraType.RainbowRodHit, new ParticleOrchestraSettings()
    {
      PositionInWorld = optionalProjectile.Center
    });
  }
}
