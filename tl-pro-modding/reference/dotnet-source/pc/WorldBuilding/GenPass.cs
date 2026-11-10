// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.GenPass
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.IO;

#nullable disable
namespace Terraria.WorldBuilding;

public abstract class GenPass : GenBase
{
  public string Name;
  public double Weight;

  public bool Enabled { get; private set; }

  public void Disable() => this.Enabled = false;

  internal void Enable() => this.Enabled = true;

  public GenPass(string name, double loadWeight)
  {
    this.Name = name;
    this.Weight = loadWeight;
    this.Enabled = true;
  }

  protected abstract void ApplyPass(GenerationProgress progress, GameConfiguration configuration);

  public void Apply(GenerationProgress progress, GameConfiguration configuration)
  {
    this.ApplyPass(progress, configuration);
  }
}
