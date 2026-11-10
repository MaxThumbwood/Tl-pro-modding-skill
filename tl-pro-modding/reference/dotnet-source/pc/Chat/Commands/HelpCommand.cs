// Decompiled with JetBrains decompiler
// Type: Terraria.Chat.Commands.HelpCommand
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.Localization;

#nullable disable
namespace Terraria.Chat.Commands;

[ChatCommand("Help")]
public class HelpCommand : IChatCommand
{
  private static readonly Color RESPONSE_COLOR = new Color((int) byte.MaxValue, 240 /*0xF0*/, 20);

  public void ProcessIncomingMessage(string text, byte clientId)
  {
    ChatHelper.SendChatMessageToClient(HelpCommand.ComposeMessage(HelpCommand.GetCommandAliasesByID()), HelpCommand.RESPONSE_COLOR, (int) clientId);
  }

  private static Dictionary<string, List<LocalizedText>> GetCommandAliasesByID()
  {
    LocalizedText[] all = Language.FindAll(Lang.CreateDialogFilter("ChatCommandDescription."));
    Dictionary<string, List<LocalizedText>> commandAliasesById = new Dictionary<string, List<LocalizedText>>();
    foreach (LocalizedText localizedText in all)
    {
      string key = localizedText.Key.Replace("ChatCommandDescription.", "");
      int length = key.IndexOf('_');
      if (length != -1)
        key = key.Substring(0, length);
      List<LocalizedText> localizedTextList;
      if (!commandAliasesById.TryGetValue(key, out localizedTextList))
      {
        localizedTextList = new List<LocalizedText>();
        commandAliasesById[key] = localizedTextList;
      }
      localizedTextList.Add(localizedText);
    }
    return commandAliasesById;
  }

  private static NetworkText ComposeMessage(Dictionary<string, List<LocalizedText>> aliases)
  {
    string text = "";
    for (int index = 0; index < aliases.Count; ++index)
      text = $"{text}{{{(object) index}}}\n";
    List<NetworkText> networkTextList = new List<NetworkText>();
    foreach (KeyValuePair<string, List<LocalizedText>> alias in aliases)
      networkTextList.Add(Language.GetText("ChatCommandDescription." + alias.Key).ToNetworkText());
    return NetworkText.FromFormattable(text, (object[]) networkTextList.ToArray());
  }

  public void ProcessOutgoingMessage(ChatMessage message)
  {
  }
}
