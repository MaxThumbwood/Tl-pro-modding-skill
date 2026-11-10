// Decompiled with JetBrains decompiler
// Type: Terraria.Audio.ProjectileAudioTracker
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Audio;

public class ProjectileAudioTracker
{
  private int _expectedType;
  private int _expectedIndex;

  public ProjectileAudioTracker(Projectile proj)
  {
    this._expectedIndex = proj.whoAmI;
    this._expectedType = proj.type;
  }

  public bool IsActiveAndInGame()
  {
    if (Main.gameMenu)
      return false;
    Projectile projectile = Main.projectile[this._expectedIndex];
    return projectile.active && projectile.type == this._expectedType;
  }
}
