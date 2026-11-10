// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.GameNotificationType
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;

#nullable disable
namespace Terraria.GameContent;

[Flags]
public enum GameNotificationType
{
  None = 0,
  Damage = 1,
  SpawnOrDeath = 2,
  WorldGen = 4,
  All = WorldGen | SpawnOrDeath | Damage, // 0x00000007
}
