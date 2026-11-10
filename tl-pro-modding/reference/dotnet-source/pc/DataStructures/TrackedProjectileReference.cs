// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.TrackedProjectileReference
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.IO;

#nullable disable
namespace Terraria.DataStructures;

public struct TrackedProjectileReference
{
  public int ProjectileLocalIndex { get; private set; }

  public int ProjectileOwnerIndex { get; private set; }

  public int ProjectileIdentity { get; private set; }

  public int ProjectileType { get; private set; }

  public bool IsTrackingSomething { get; private set; }

  public void Set(Projectile proj)
  {
    this.ProjectileLocalIndex = proj.whoAmI;
    this.ProjectileOwnerIndex = proj.owner;
    this.ProjectileIdentity = proj.identity;
    this.ProjectileType = proj.type;
    this.IsTrackingSomething = true;
  }

  public void Clear()
  {
    this.ProjectileLocalIndex = -1;
    this.ProjectileOwnerIndex = -1;
    this.ProjectileIdentity = -1;
    this.ProjectileType = -1;
    this.IsTrackingSomething = false;
  }

  public void Write(BinaryWriter writer)
  {
    writer.Write((short) this.ProjectileOwnerIndex);
    if (this.ProjectileOwnerIndex == -1)
      return;
    writer.Write((short) this.ProjectileIdentity);
    writer.Write((short) this.ProjectileType);
  }

  public bool IsTracking(Projectile proj) => proj.whoAmI == this.ProjectileLocalIndex;

  public void TryReading(BinaryReader reader)
  {
    int expectedOwner = (int) reader.ReadInt16();
    if (expectedOwner == -1)
    {
      this.Clear();
    }
    else
    {
      int expectedIdentity = (int) reader.ReadInt16();
      int expectedType = (int) reader.ReadInt16();
      Projectile matchingProjectile = this.FindMatchingProjectile(expectedOwner, expectedIdentity, expectedType);
      if (matchingProjectile == null)
        this.Clear();
      else
        this.Set(matchingProjectile);
    }
  }

  private Projectile FindMatchingProjectile(
    int expectedOwner,
    int expectedIdentity,
    int expectedType)
  {
    if (expectedOwner == -1)
      return (Projectile) null;
    for (int index = 0; index < 1000; ++index)
    {
      Projectile matchingProjectile = Main.projectile[index];
      if (matchingProjectile.type == expectedType && matchingProjectile.owner == expectedOwner && matchingProjectile.identity == expectedIdentity)
        return matchingProjectile;
    }
    return (Projectile) null;
  }

  public override bool Equals(object obj)
  {
    return obj is TrackedProjectileReference other && this.Equals(other);
  }

  public bool Equals(TrackedProjectileReference other)
  {
    return this.ProjectileLocalIndex == other.ProjectileLocalIndex && this.ProjectileOwnerIndex == other.ProjectileOwnerIndex && this.ProjectileIdentity == other.ProjectileIdentity && this.ProjectileType == other.ProjectileType;
  }

  public override int GetHashCode()
  {
    return ((this.ProjectileLocalIndex * 397 ^ this.ProjectileOwnerIndex) * 397 ^ this.ProjectileIdentity) * 397 ^ this.ProjectileType;
  }

  public static bool operator ==(TrackedProjectileReference c1, TrackedProjectileReference c2)
  {
    return c1.Equals(c2);
  }

  public static bool operator !=(TrackedProjectileReference c1, TrackedProjectileReference c2)
  {
    return !c1.Equals(c2);
  }
}
