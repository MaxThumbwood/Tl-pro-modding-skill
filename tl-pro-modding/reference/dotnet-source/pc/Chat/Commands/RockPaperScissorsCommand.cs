// Decompiled with JetBrains decompiler
// Type: Terraria.Chat.Commands.RockPaperScissorsCommand
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.GameContent.UI;

#nullable disable
namespace Terraria.Chat.Commands;

[ChatCommand("RPS")]
public class RockPaperScissorsCommand : IChatCommand
{
  public void ProcessIncomingMessage(string text, byte clientId)
  {
  }

  public void ProcessOutgoingMessage(ChatMessage message)
  {
    if (Main.netMode != 2 && Main.LocalPlayer.dead)
    {
      message.Consume();
    }
    else
    {
      int num = Main.rand.NextFromList<int>(37, 38, 36);
      if (Main.netMode == 0)
      {
        EmoteBubble.NewBubble(num, new WorldUIAnchor((Entity) Main.LocalPlayer), 360);
        EmoteBubble.CheckForNPCsToReactToEmoteBubble(num, Main.LocalPlayer);
      }
      else
        NetMessage.SendData(120, number: Main.myPlayer, number2: (float) num);
      message.Consume();
    }
  }
}
