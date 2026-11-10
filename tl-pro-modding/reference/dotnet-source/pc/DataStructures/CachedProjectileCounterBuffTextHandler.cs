// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.CachedProjectileCounterBuffTextHandler
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public class CachedProjectileCounterBuffTextHandler : IBuffTextHandler
{
  private int[] projectilesToLookFor;

  public CachedProjectileCounterBuffTextHandler(params int[] projectileTypesToLookFor)
  {
    this.projectilesToLookFor = projectileTypesToLookFor;
  }

  public string HandleBuffText()
  {
    if (this.projectilesToLookFor == null)
      return (string) null;
    int[] projectileCounts = Main.LocalPlayer.ownedProjectileCounts;
    float num = 0.0f;
    foreach (int index in this.projectilesToLookFor)
      num += (float) projectileCounts[index];
    return (double) num > 0.0 ? "x" + (object) num : (string) null;
  }
}
