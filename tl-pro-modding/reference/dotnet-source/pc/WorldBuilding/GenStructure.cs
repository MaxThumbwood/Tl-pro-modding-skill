// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.GenStructure
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.WorldBuilding;

public abstract class GenStructure : GenBase
{
  public virtual bool Place(Point origin, StructureMap structures)
  {
    return this.Place(origin, structures, (GenerationProgress) null);
  }

  public abstract bool Place(Point origin, StructureMap structures, GenerationProgress progress);
}
