// Decompiled with JetBrains decompiler
// Type: Terraria.Social.WeGame.CurrentThreadRunner
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Windows.Threading;

#nullable disable
namespace Terraria.Social.WeGame;

public class CurrentThreadRunner
{
  private Dispatcher _dsipatcher;

  public CurrentThreadRunner() => this._dsipatcher = Dispatcher.CurrentDispatcher;

  public void Run(Action f) => this._dsipatcher.BeginInvoke((Delegate) f);
}
