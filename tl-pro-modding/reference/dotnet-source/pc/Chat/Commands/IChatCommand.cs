// Decompiled with JetBrains decompiler
// Type: Terraria.Chat.Commands.IChatCommand
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Chat.Commands;

public interface IChatCommand
{
  void ProcessIncomingMessage(string text, byte clientId);

  void ProcessOutgoingMessage(ChatMessage message);
}
