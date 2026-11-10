// Decompiled with JetBrains decompiler
// Type: Terraria.Chat.ChatCommandId
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Utilities;
using System.IO;
using System.Text;
using Terraria.Chat.Commands;

#nullable disable
namespace Terraria.Chat;

public struct ChatCommandId
{
  private readonly string _name;

  private ChatCommandId(string name) => this._name = name;

  public static ChatCommandId FromType<T>() where T : IChatCommand
  {
    ChatCommandAttribute cacheableAttribute = AttributeUtilities.GetCacheableAttribute<T, ChatCommandAttribute>();
    return cacheableAttribute != null ? new ChatCommandId(cacheableAttribute.Name) : new ChatCommandId((string) null);
  }

  public void Serialize(BinaryWriter writer) => writer.Write(this._name ?? "");

  public static ChatCommandId Deserialize(BinaryReader reader)
  {
    return new ChatCommandId(reader.ReadString());
  }

  public int GetMaxSerializedSize() => 4 + Encoding.UTF8.GetByteCount(this._name ?? "");
}
