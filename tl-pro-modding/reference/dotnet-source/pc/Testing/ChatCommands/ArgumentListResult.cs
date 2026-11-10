// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.ChatCommands.ArgumentListResult
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Terraria.Testing.ChatCommands;

public class ArgumentListResult : IEnumerable<string>, IEnumerable
{
  public static readonly ArgumentListResult Empty = new ArgumentListResult(true);
  public static readonly ArgumentListResult Invalid = new ArgumentListResult(false);
  public readonly bool IsValid;
  private readonly List<string> _results;

  public int Count => this._results.Count;

  public string this[int index] => this._results[index];

  public ArgumentListResult(IEnumerable<string> results)
  {
    this._results = results.ToList<string>();
    this.IsValid = true;
  }

  private ArgumentListResult(bool isValid)
  {
    this._results = new List<string>();
    this.IsValid = isValid;
  }

  public IEnumerator<string> GetEnumerator() => (IEnumerator<string>) this._results.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();
}
