// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.PlayerPettingInfo
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent;

public struct PlayerPettingInfo
{
  public bool isPetting;
  public int npc;
  public int proj;
  public int type;
  public bool mount;
  public Vector2 offsetFromPet;
  public bool isPetSmall;

  public PlayerPettingInfo(NPC npc, Vector2 offsetFromPet, bool isPetSmall)
  {
    this.isPetting = false;
    this.npc = npc.whoAmI;
    this.proj = -1;
    this.type = npc.type;
    this.offsetFromPet = offsetFromPet;
    this.isPetSmall = isPetSmall;
    this.mount = false;
  }

  public PlayerPettingInfo(Projectile proj, Vector2 offsetFromPet, bool isPetSmall)
  {
    this.isPetting = false;
    this.npc = -1;
    this.proj = proj.whoAmI;
    this.type = proj.type;
    this.offsetFromPet = offsetFromPet;
    this.isPetSmall = isPetSmall;
    this.mount = false;
  }

  public PlayerPettingInfo(int mountId, bool isPetSmall)
  {
    this.isPetting = false;
    this.npc = -1;
    this.proj = -1;
    this.type = mountId;
    this.offsetFromPet = Vector2.Zero;
    this.isPetSmall = isPetSmall;
    this.mount = true;
  }

  public bool TryGetTarget(out Entity target)
  {
    if (this.npc >= 0)
    {
      NPC npc = Main.npc[this.npc];
      target = (Entity) npc;
      return npc.active && npc.type == this.type;
    }
    if (this.mount)
    {
      target = (Entity) null;
      return true;
    }
    Projectile projectile = Main.projectile[this.proj];
    target = (Entity) projectile;
    return projectile.active && projectile.type == this.type;
  }
}
