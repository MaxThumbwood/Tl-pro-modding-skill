// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.GenPassResult
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.WorldBuilding;

public class GenPassResult
{
  public string Name { get; set; }

  public int DurationMs { get; set; }

  public int RandNext { get; set; }

  public uint? Hash { get; set; }

  public bool Skipped { get; set; }

  public override string ToString()
  {
    if (this.Skipped)
      return $"Pass - {this.Name}: Skipped";
    return $"Pass - {this.Name}: {this.DurationMs}ms, rand: {this.RandNext:X8}, hash: {this.Hash:X8}";
  }

  public bool Matches(GenPassResult other)
  {
    if (!(this.Name == other.Name) || this.RandNext != other.RandNext || this.Skipped != other.Skipped)
      return false;
    if (!this.Hash.HasValue || !other.Hash.HasValue)
      return true;
    uint? hash1 = this.Hash;
    uint? hash2 = other.Hash;
    return (int) hash1.GetValueOrDefault() == (int) hash2.GetValueOrDefault() & hash1.HasValue == hash2.HasValue;
  }
}
