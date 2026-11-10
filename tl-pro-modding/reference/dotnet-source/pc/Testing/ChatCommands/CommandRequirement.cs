// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.ChatCommands.CommandRequirement
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;

#nullable disable
namespace Terraria.Testing.ChatCommands;

[Flags]
public enum CommandRequirement
{
  SinglePlayer = 1,
  MultiplayerClient = 2,
  MultiplayerRPC = 4,
  LocalServer = 8,
  ClientAuthority = MultiplayerRPC | SinglePlayer, // 0x00000005
  AnyAuthority = ClientAuthority | LocalServer, // 0x0000000D
  Client = MultiplayerClient | SinglePlayer, // 0x00000003
  All = Client | LocalServer | MultiplayerRPC, // 0x0000000F
}
