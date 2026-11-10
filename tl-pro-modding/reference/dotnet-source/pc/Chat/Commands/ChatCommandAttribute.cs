// Decompiled with JetBrains decompiler
// Type: Terraria.Chat.Commands.ChatCommandAttribute
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;

#nullable disable
namespace Terraria.Chat.Commands;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false)]
public sealed class ChatCommandAttribute : Attribute
{
  public readonly string Name;

  public ChatCommandAttribute(string name) => this.Name = name;
}
