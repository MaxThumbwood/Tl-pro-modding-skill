// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.ChatCommands.ArgumentHelper
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Terraria.Testing.ChatCommands;

public static class ArgumentHelper
{
  public static ArgumentListResult ParseList(string arguments)
  {
    return new ArgumentListResult(((IEnumerable<string>) arguments.Split(' ')).Select<string, string>((Func<string, string>) (arg => arg.Trim())).Where<string>((Func<string, bool>) (arg => arg.Length != 0)));
  }
}
