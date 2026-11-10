// Decompiled with JetBrains decompiler
// Type: Terraria.ID.GameModeID
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.ID;

internal class GameModeID
{
  public const short Normal = 0;
  public const short Expert = 1;
  public const short Master = 2;
  public const short Creative = 3;
  public const short Count = 4;

  public static bool IsValid(int gameMode) => gameMode >= 0 && gameMode < 4;
}
