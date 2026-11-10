// Decompiled with JetBrains decompiler
// Type: Terraria.Chat.Commands.RollCommand
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.Localization;

#nullable disable
namespace Terraria.Chat.Commands;

[ChatCommand("Roll")]
public class RollCommand : IChatCommand
{
  private static readonly Color RESPONSE_COLOR = new Color((int) byte.MaxValue, 240 /*0xF0*/, 20);

  public void ProcessIncomingMessage(string text, byte clientId)
  {
    int num = Main.rand.Next(1, 101);
    ChatHelper.BroadcastChatMessage(NetworkText.FromFormattable("*{0} {1} {2}", (object) Main.player[(int) clientId].name, (object) Lang.mp[9].ToNetworkText(), (object) num), RollCommand.RESPONSE_COLOR);
  }

  public void ProcessOutgoingMessage(ChatMessage message)
  {
  }
}
