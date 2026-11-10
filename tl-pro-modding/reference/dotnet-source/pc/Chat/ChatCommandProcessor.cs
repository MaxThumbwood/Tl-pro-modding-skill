// Decompiled with JetBrains decompiler
// Type: Terraria.Chat.ChatCommandProcessor
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using Terraria.Chat.Commands;
using Terraria.Localization;

#nullable disable
namespace Terraria.Chat;

public class ChatCommandProcessor : IChatProcessor
{
  private readonly Dictionary<LocalizedText, ChatCommandId> _localizedCommands = new Dictionary<LocalizedText, ChatCommandId>();
  private readonly Dictionary<ChatCommandId, IChatCommand> _commands = new Dictionary<ChatCommandId, IChatCommand>();
  private Dictionary<LocalizedText, Func<string>> _aliases = new Dictionary<LocalizedText, Func<string>>();
  private IChatCommand _defaultCommand;

  public ChatCommandProcessor AddCommand<T>() where T : IChatCommand, new()
  {
    string commandKey = "ChatCommand." + AttributeUtilities.GetCacheableAttribute<T, ChatCommandAttribute>().Name;
    ChatCommandId key1 = ChatCommandId.FromType<T>();
    this._commands[key1] = (IChatCommand) new T();
    if (Language.Exists(commandKey))
    {
      this._localizedCommands.Add(Language.GetText(commandKey), key1);
    }
    else
    {
      commandKey += "_";
      foreach (LocalizedText key2 in Language.FindAll((LanguageSearchFilter) ((key, text) => key.StartsWith(commandKey))))
        this._localizedCommands.Add(key2, key1);
    }
    return this;
  }

  public void AddAlias(LocalizedText alias, Func<string> result) => this._aliases[alias] = result;

  public void PrepareAliases()
  {
    foreach (IChatCommand chatCommand in this._commands.Values)
    {
      if (chatCommand is ICommandAliasProvider)
        ((ICommandAliasProvider) chatCommand).PrepareAliases(this);
    }
  }

  public ChatCommandProcessor AddDefaultCommand<T>() where T : IChatCommand, new()
  {
    this.AddCommand<T>();
    this._defaultCommand = this._commands[ChatCommandId.FromType<T>()];
    return this;
  }

  private static bool ParseCommandPrefix<T>(
    string text,
    Dictionary<LocalizedText, T> commands,
    out string remainder,
    out T value)
  {
    foreach (KeyValuePair<LocalizedText, T> command in commands)
    {
      if (command.Key.ParseCommandPrefix(text, out remainder))
      {
        value = command.Value;
        return true;
      }
    }
    remainder = "";
    value = default (T);
    return false;
  }

  public ChatMessage CreateOutgoingMessage(string text)
  {
    ChatMessage message = new ChatMessage(text);
    string remainder;
    ChatCommandId chatCommandId;
    if (ChatCommandProcessor.ParseCommandPrefix<ChatCommandId>(message.Text, this._localizedCommands, out remainder, out chatCommandId))
    {
      message.Text = remainder;
      message.SetCommand(chatCommandId);
      this._commands[chatCommandId].ProcessOutgoingMessage(message);
      return message;
    }
    Func<string> func;
    return ChatCommandProcessor.ParseCommandPrefix<Func<string>>(message.Text, this._aliases, out remainder, out func) ? this.CreateOutgoingMessage(func()) : message;
  }

  public void ProcessIncomingMessage(ChatMessage message, int clientId)
  {
    IChatCommand chatCommand;
    if (this._commands.TryGetValue(message.CommandId, out chatCommand))
    {
      chatCommand.ProcessIncomingMessage(message.Text, (byte) clientId);
      message.Consume();
    }
    else
    {
      if (this._defaultCommand == null)
        return;
      this._defaultCommand.ProcessIncomingMessage(message.Text, (byte) clientId);
      message.Consume();
    }
  }
}
