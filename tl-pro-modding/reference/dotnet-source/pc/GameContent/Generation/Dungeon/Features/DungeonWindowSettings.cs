// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonWindowSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public abstract class DungeonWindowSettings : DungeonFeatureSettings
{
  public DungeonGenerationStyleData Style;
  public int OverrideGlassPaint = -1;
  public int OverrideGlassType = -1;
  public bool Closed;
}
