// Decompiled with JetBrains decompiler
// Type: Terraria.Chat.Commands.BossDamageCommand
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.GameContent;

#nullable disable
namespace Terraria.Chat.Commands;

[ChatCommand("BossDamage")]
public class BossDamageCommand : IChatCommand
{
  private static readonly Color RESPONSE_COLOR = new Color(50, (int) byte.MaxValue, 130);

  public void ProcessIncomingMessage(string text, byte clientId)
  {
    foreach (NPCDamageTracker recentAttempt in NPCDamageTracker.RecentAttempts())
    {
      for (int playerId = 0; playerId < (int) byte.MaxValue; ++playerId)
      {
        if (Main.player[playerId].active)
          ChatHelper.SendChatMessageToClient(recentAttempt.GetReport(Main.player[playerId]), BossDamageCommand.RESPONSE_COLOR, playerId);
      }
    }
  }

  public void ProcessOutgoingMessage(ChatMessage message)
  {
  }
}
