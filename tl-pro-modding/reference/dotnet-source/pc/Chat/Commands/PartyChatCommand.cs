// Decompiled with JetBrains decompiler
// Type: Terraria.Chat.Commands.PartyChatCommand
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.Localization;

#nullable disable
namespace Terraria.Chat.Commands;

[ChatCommand("Party")]
public class PartyChatCommand : IChatCommand
{
  private static readonly Color ERROR_COLOR = new Color((int) byte.MaxValue, 240 /*0xF0*/, 20);

  public void ProcessIncomingMessage(string text, byte clientId)
  {
    int team = Main.player[(int) clientId].team;
    Color color = Main.teamColor[team];
    if (team == 0 || Main.netMode == 0)
    {
      this.SendNoTeamError(clientId);
    }
    else
    {
      if (text == "")
        return;
      for (int playerId = 0; playerId < (int) byte.MaxValue; ++playerId)
      {
        if (Main.player[playerId].team == team)
          ChatHelper.SendChatMessageToClientAs(clientId, NetworkText.FromLiteral(text), color, playerId);
      }
    }
  }

  public void ProcessOutgoingMessage(ChatMessage message)
  {
  }

  private void SendNoTeamError(byte clientId)
  {
    ChatHelper.SendChatMessageToClient(Lang.mp[10].ToNetworkText(), PartyChatCommand.ERROR_COLOR, (int) clientId);
  }
}
