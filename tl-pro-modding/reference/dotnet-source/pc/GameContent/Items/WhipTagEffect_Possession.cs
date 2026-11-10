// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Items.WhipTagEffect_Possession
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.Items;

public class WhipTagEffect_Possession : WhipTagEffect
{
  public override void OnProcHit(
    Player owner,
    Projectile optionalProjectile,
    NPC npcHit,
    int calcDamage)
  {
    Projectile.SpawnMoonLordWhipProc(optionalProjectile, npcHit, 20, 0);
  }
}
