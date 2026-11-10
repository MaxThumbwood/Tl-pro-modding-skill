// Decompiled with JetBrains decompiler
// Type: Terraria.Chat.Commands.AllDeathCommand
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

[ChatCommand("AllDeath")]
public class AllDeathCommand : IChatCommand
{
  private static readonly Color RESPONSE_COLOR = new Color((int) byte.MaxValue, 25, 25);

  public void ProcessIncomingMessage(string text, byte clientId)
  {
    foreach (Player player in (IEnumerable<Player>) ((IEnumerable<Player>) Main.player).Where<Player>((Func<Player, bool>) (x => x != null && x.active)).OrderByDescending<Player, int>((Func<Player, int>) (x => x.numberOfDeathsPVE)))
    {
      NetworkText text1 = NetworkText.FromKey("LegacyMultiplayer.23", (object) player.name, (object) player.numberOfDeathsPVE);
      if (player.numberOfDeathsPVE == 1)
        text1 = NetworkText.FromKey("LegacyMultiplayer.25", (object) player.name, (object) player.numberOfDeathsPVE);
      ChatHelper.BroadcastChatMessage(text1, AllDeathCommand.RESPONSE_COLOR);
    }
  }

  public void ProcessOutgoingMessage(ChatMessage message)
  {
  }
}
