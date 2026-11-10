// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.PortableStoolUsage
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public struct PortableStoolUsage
{
  public bool HasAStool;
  public bool IsInUse;
  public int HeightBoost;
  public int VisualYOffset;
  public int MapYOffset;

  public void Reset()
  {
    this.HasAStool = false;
    this.IsInUse = false;
    this.HeightBoost = 0;
    this.VisualYOffset = 0;
    this.MapYOffset = 0;
  }

  public void SetStats(int heightBoost, int visualYOffset, int mapYOffset)
  {
    this.HasAStool = true;
    this.HeightBoost = heightBoost;
    this.VisualYOffset = visualYOffset;
    this.MapYOffset = mapYOffset;
  }
}
