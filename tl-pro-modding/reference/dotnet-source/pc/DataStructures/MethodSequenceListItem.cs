// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.MethodSequenceListItem
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace Terraria.DataStructures;

public class MethodSequenceListItem
{
  public string Name;
  public MethodSequenceListItem Parent;
  public Func<bool> Method;
  public bool Skip;

  public MethodSequenceListItem(string name, Func<bool> method, MethodSequenceListItem parent = null)
  {
    this.Name = name;
    this.Method = method;
    this.Parent = parent;
  }

  public bool ShouldAct(List<MethodSequenceListItem> sequence)
  {
    if (this.Skip || !sequence.Contains(this))
      return false;
    return this.Parent == null || this.Parent.ShouldAct(sequence);
  }

  public bool Act() => this.Method();

  public static void ExecuteSequence(List<MethodSequenceListItem> sequence)
  {
    foreach (MethodSequenceListItem sequenceListItem in sequence)
    {
      if (sequenceListItem.ShouldAct(sequence) && !sequenceListItem.Act())
        break;
    }
  }

  public override string ToString()
  {
    return $"name: {this.Name} skip: {this.Skip.ToString()} parent: {(object) this.Parent}";
  }
}
