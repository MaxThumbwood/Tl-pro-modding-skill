// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.DebugOverrides
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using System.Diagnostics;

#nullable disable
namespace Terraria.Testing;

public class DebugOverrides
{
  public static Dictionary<string, double> Overrides = new Dictionary<string, double>();

  [Conditional("DEBUG")]
  public static void Replace(string key, ref int value)
  {
    double num;
    if (!DebugOverrides.Overrides.TryGetValue(key, out num))
      return;
    value = (int) num;
  }

  [Conditional("DEBUG")]
  public static void Replace(string key, ref float value)
  {
    double num;
    if (!DebugOverrides.Overrides.TryGetValue(key, out num))
      return;
    value = (float) num;
  }

  [Conditional("DEBUG")]
  public static void Set(string key, double value) => DebugOverrides.Overrides[key] = value;
}
