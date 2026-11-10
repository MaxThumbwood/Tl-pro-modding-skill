// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.ChatCommands.DebugMessage
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.IO;
using Terraria.Chat;
using Terraria.Localization;

#nullable disable
namespace Terraria.Testing.ChatCommands;

public class DebugMessage
{
  private const char COMMAND_PREFIX = '/';
  public readonly byte Author;
  public readonly string CommandName = "";
  public readonly string Arguments = "";
  public readonly Vector2 MousePosition;

  public DebugMessage(byte author, string message)
    : this(author, message, new Vector2((float) Main.mouseX, (float) Main.mouseY) + Main.screenPosition)
  {
  }

  private DebugMessage(byte author, string message, Vector2 mousePosition)
  {
    this.MousePosition = mousePosition;
    this.Author = author;
    if (message[0] != '/')
      return;
    string lower = message.ToLower();
    int num = lower.Length;
    for (int index = 0; index < lower.Length; ++index)
    {
      if (lower[index] == ' ')
      {
        num = index;
        break;
      }
    }
    string str = lower.Substring(1, num - 1);
    this.CommandName = str;
    if (str.Length == 0 || num >= message.Length - 1)
      return;
    this.Arguments = message.Substring(num + 1);
  }

  private DebugMessage(byte author, string commandName, string arguments, Vector2 mousePosition)
  {
    this.Author = author;
    this.CommandName = commandName;
    this.Arguments = arguments;
    this.MousePosition = mousePosition;
  }

  public void Reply(string message)
  {
    ChatHelper.DisplayMessageOnClient(NetworkText.FromLiteral(message), new Color(250, 250, 0), (int) this.Author);
  }

  public void ReplyError(string message)
  {
    ChatHelper.DisplayMessageOnClient(NetworkText.FromLiteral(message), new Color(250, 0, 0), (int) this.Author);
  }

  public void Serialize(BinaryWriter writer)
  {
    writer.Write(this.CommandName);
    writer.Write(this.Arguments);
    writer.WriteVector2(this.MousePosition);
  }

  public static DebugMessage Deserialize(byte author, BinaryReader reader)
  {
    string commandName = reader.ReadString();
    string arguments = reader.ReadString();
    Vector2 mousePosition = reader.ReadVector2();
    return new DebugMessage(author, commandName, arguments, mousePosition);
  }

  public DebugMessage CreateSubMessage(string newMessage)
  {
    return new DebugMessage(this.Author, newMessage, this.MousePosition);
  }
}
