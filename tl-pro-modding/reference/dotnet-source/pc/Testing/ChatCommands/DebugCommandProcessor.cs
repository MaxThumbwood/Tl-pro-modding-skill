// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.ChatCommands.DebugCommandProcessor
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Terraria.Chat;
using Terraria.GameContent.NetModules;
using Terraria.Localization;
using Terraria.Net;

#nullable disable
namespace Terraria.Testing.ChatCommands;

public class DebugCommandProcessor
{
  private readonly Dictionary<string, IDebugCommand> _commands = new Dictionary<string, IDebugCommand>();
  private static string MemoCommandsPath = Path.Combine(Main.SavePath, "MemoCommands");

  public IEnumerable<IDebugCommand> Commands => (IEnumerable<IDebugCommand>) this._commands.Values;

  public DebugCommandProcessor()
  {
    if (!DebugOptions.enableDebugCommands)
      return;
    this.AddAttributeCommandsFromType(typeof (ToolkitDebugCommands));
  }

  public void AddAttributeCommandsFromType(Type type)
  {
    foreach (MethodInfo method in type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
    {
      DebugCommandAttribute attribute = AttributeUtilities.GetAttribute<DebugCommandAttribute>((MethodBase) method);
      if (attribute != null)
        this.AddCommand(attribute.ToDebugCommand(method));
    }
  }

  public void AddCommand(IDebugCommand debugCommand)
  {
    this._commands[debugCommand.Name.ToLower()] = debugCommand;
  }

  public bool Process(byte playerId, string message)
  {
    return this.Process(new DebugMessage(playerId, message));
  }

  public bool Process(DebugMessage message)
  {
    if (!DebugOptions.enableDebugCommands && !message.CommandName.Equals("toggledebugcommands"))
      return false;
    IDebugCommand debugCommand;
    if (!this._commands.TryGetValue(message.CommandName, out debugCommand))
      return (int) message.Author == Main.myPlayer && this.TryProcessMemo(message);
    if ((debugCommand.Requirements & CommandRequirement.MultiplayerRPC) != (CommandRequirement) 0 && Main.netMode == 1)
    {
      NetPacket packet = NetDebugModule.Serialize(message);
      NetManager.Instance.SendToServer(packet);
      return true;
    }
    if (!DebugCommandProcessor.CanRunCommandLocally((int) message.Author, debugCommand.Requirements))
      return false;
    bool flag = debugCommand.Process(message);
    if (!flag && debugCommand.HelpText != null)
      message.Reply(debugCommand.HelpText);
    if (((DebugOptions.Shared_ReportCommandUsage ? 1 : (debugCommand.Name == "showdebug" ? 1 : 0)) & (flag ? 1 : 0)) != 0 && Main.netMode != 0)
    {
      string str = $"{(message.Author == byte.MaxValue ? (object) "server" : (object) Main.player[(int) message.Author].name)} debugged: /{message.CommandName} {message.Arguments}";
      if (Main.netMode != 1)
        ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral(str), new Color(250, 250, 0));
      else
        ChatHelper.SendChatMessageFromClient(new ChatMessage(str));
    }
    return true;
  }

  public bool ExecuteSubMessage(DebugMessage baseMessage, string newMessage)
  {
    return this.Process(baseMessage.CreateSubMessage(newMessage));
  }

  private static bool CanRunCommandLocally(int playerId, CommandRequirement requirements)
  {
    if (Main.netMode == 0 && (requirements & CommandRequirement.SinglePlayer) != (CommandRequirement) 0 || Main.netMode == 1 && (requirements & CommandRequirement.MultiplayerClient) != (CommandRequirement) 0 || Main.netMode == 2 && (requirements & CommandRequirement.LocalServer) != (CommandRequirement) 0 && playerId == (int) byte.MaxValue)
      return true;
    return Main.netMode == 2 && (requirements & CommandRequirement.MultiplayerRPC) != (CommandRequirement) 0 && playerId < (int) byte.MaxValue;
  }

  private bool TryProcessMemo(DebugMessage message)
  {
    string path = Path.Combine(DebugCommandProcessor.MemoCommandsPath, message.CommandName.ToLower() + ".txt");
    if (!File.Exists(path))
      return false;
    try
    {
      string[] strArray = message.Arguments.Split(' ');
      foreach (string readAllLine in File.ReadAllLines(path))
        this.ExecuteSubMessage(message, string.Format(readAllLine, (object[]) strArray));
    }
    catch (FormatException ex)
    {
      message.ReplyError("Memo formatting error. Perhaps you forgot to pass arguments?");
    }
    return true;
  }

  public static void OpenMemo(string name)
  {
    Utils.TryCreatingDirectory(DebugCommandProcessor.MemoCommandsPath);
    string str = Path.Combine(DebugCommandProcessor.MemoCommandsPath, name.ToLower() + ".txt");
    if (!File.Exists(str))
      File.WriteAllBytes(str, new byte[0]);
    System.Diagnostics.Process.Start(new ProcessStartInfo(str)
    {
      UseShellExecute = true
    });
  }
}
