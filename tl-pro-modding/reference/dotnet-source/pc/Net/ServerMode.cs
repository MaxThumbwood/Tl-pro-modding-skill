// Decompiled with JetBrains decompiler
// Type: Terraria.Net.ServerMode
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;

#nullable disable
namespace Terraria.Net;

[Flags]
public enum ServerMode : byte
{
  None = 0,
  Lobby = 1,
  FriendsCanJoin = 2,
  FriendsOfFriends = 4,
}
