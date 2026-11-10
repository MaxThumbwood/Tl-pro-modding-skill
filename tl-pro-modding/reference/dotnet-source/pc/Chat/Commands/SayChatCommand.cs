// Decompiled with JetBrains decompiler
// Type: Terraria.Chat.Commands.SayChatCommand
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using Terraria.Localization;

#nullable disable
namespace Terraria.Chat.Commands;

[ChatCommand("Say")]
public class SayChatCommand : IChatCommand
{
  public void ProcessIncomingMessage(string text, byte clientId)
  {
    ChatHelper.BroadcastChatMessageAs(clientId, NetworkText.FromLiteral(text), Main.player[(int) clientId].ChatColor());
    if (!Main.dedServ)
      return;
    Console.WriteLine("<{0}> {1}", (object) Main.player[(int) clientId].name, (object) text);
  }

  public void ProcessOutgoingMessage(ChatMessage message)
  {
  }
}
