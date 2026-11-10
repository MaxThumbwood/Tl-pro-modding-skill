// Decompiled with JetBrains decompiler
// Type: Terraria.Chat.Commands.EmojiCommand
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using Terraria.GameContent.UI;
using Terraria.Localization;

#nullable disable
namespace Terraria.Chat.Commands;

[ChatCommand("Emoji")]
public class EmojiCommand : IChatCommand, ICommandAliasProvider
{
  public const int PlayerEmojiDuration = 360;
  private readonly Dictionary<LocalizedText, int> _byName = new Dictionary<LocalizedText, int>();

  public EmojiCommand() => this.Initialize();

  public void Initialize()
  {
    this._byName.Clear();
    for (int id = 0; id < EmoteID.Count; ++id)
    {
      LocalizedText emojiName = Lang.GetEmojiName(id);
      if (emojiName != LocalizedText.Empty)
        this._byName[emojiName] = id;
    }
  }

  public void PrepareAliases(ChatCommandProcessor commandProcessor)
  {
    for (int index = 0; index < EmoteID.Count; ++index)
    {
      string name = EmoteID.Search.GetName(index);
      commandProcessor.AddAlias(Language.GetText("EmojiCommand." + name), (Func<string>) (() => $"{Language.GetTextValue("ChatCommand.Emoji_1")} {Language.GetTextValue("EmojiName." + name)}"));
    }
  }

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
      int result = -1;
      if (int.TryParse(message.Text, out result))
      {
        if (result < 0 || result >= EmoteID.Count)
          return;
      }
      else
        result = -1;
      if (result == -1)
      {
        foreach (LocalizedText key in this._byName.Keys)
        {
          if (key.EqualsCommand(message.Text))
          {
            result = this._byName[key];
            break;
          }
        }
      }
      if (result != -1)
      {
        if (Main.netMode == 0)
        {
          EmoteBubble.NewBubble(result, new WorldUIAnchor((Entity) Main.LocalPlayer), 360);
          EmoteBubble.CheckForNPCsToReactToEmoteBubble(result, Main.LocalPlayer);
        }
        else
          NetMessage.SendData(120, number: Main.myPlayer, number2: (float) result);
      }
      message.Consume();
    }
  }

  public void PrintWarning(string text) => throw new Exception("This needs localized text!");
}
