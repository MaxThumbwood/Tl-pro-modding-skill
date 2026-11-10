// Decompiled with JetBrains decompiler
// Type: Terraria.Chat.Commands.EmoteCommand
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.Localization;

#nullable disable
namespace Terraria.Chat.Commands;

[ChatCommand("Emote")]
public class EmoteCommand : IChatCommand
{
  private static readonly Color RESPONSE_COLOR = new Color(200, 100, 0);

  public void ProcessIncomingMessage(string text, byte clientId)
  {
    if (!(text != ""))
      return;
    text = $"*{Main.player[(int) clientId].name} {text}";
    ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral(text), EmoteCommand.RESPONSE_COLOR);
  }

  public void ProcessOutgoingMessage(ChatMessage message)
  {
  }
}
