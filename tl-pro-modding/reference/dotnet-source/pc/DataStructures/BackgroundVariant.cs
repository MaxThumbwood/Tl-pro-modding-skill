// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.BackgroundVariant
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public class BackgroundVariant
{
  private readonly int[] _backgrounds = new int[3]
  {
    -1,
    -1,
    -1
  };

  public int[] Backgrounds => this._backgrounds;

  public void Set(int far, int middle, int near)
  {
    this._backgrounds[0] = far;
    this._backgrounds[1] = middle;
    this._backgrounds[2] = near;
  }

  public void Clear() => this.Set(-1, -1, -1);

  public bool HasAny
  {
    get => this._backgrounds[0] != -1 || this._backgrounds[1] != -1 || this._backgrounds[2] != -1;
  }
}
