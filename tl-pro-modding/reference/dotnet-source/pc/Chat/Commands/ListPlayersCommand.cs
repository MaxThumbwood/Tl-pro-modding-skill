// Decompiled with JetBrains decompiler
// Type: Terraria.Chat.Commands.ListPlayersCommand
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.Localization;

#nullable disable
namespace Terraria.Chat.Commands;

[ChatCommand("Playing")]
public class ListPlayersCommand : IChatCommand
{
  private static readonly Color RESPONSE_COLOR = new Color((int) byte.MaxValue, 240 /*0xF0*/, 20);

  public void ProcessIncomingMessage(string text, byte clientId)
  {
    ChatHelper.SendChatMessageToClient(NetworkText.FromLiteral(string.Join(", ", ((IEnumerable<Player>) Main.player).Where<Player>((Func<Player, bool>) (player => player.active)).Select<Player, string>((Func<Player, string>) (player => player.name)))), ListPlayersCommand.RESPONSE_COLOR, (int) clientId);
  }

  public void ProcessOutgoingMessage(ChatMessage message)
  {
  }
}
