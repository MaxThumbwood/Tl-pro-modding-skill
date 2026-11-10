// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Personalities.AShoppingBiome
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.Personalities;

public abstract class AShoppingBiome
{
  public string NameKey { get; protected set; }

  public abstract bool IsInBiome(Player player);
}
