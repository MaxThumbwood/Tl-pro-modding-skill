// Decompiled with JetBrains decompiler
// Type: Terraria.Social.WeGame.AsyncTaskHelper
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Threading.Tasks;

#nullable disable
namespace Terraria.Social.WeGame;

public class AsyncTaskHelper
{
  private CurrentThreadRunner _currentThreadRunner;

  private AsyncTaskHelper() => this._currentThreadRunner = new CurrentThreadRunner();

  public void RunAsyncTaskAndReply(Action task, Action replay)
  {
    Task.Factory.StartNew((Action) (() =>
    {
      task();
      this._currentThreadRunner.Run(replay);
    }));
  }

  public void RunAsyncTask(Action task) => Task.Factory.StartNew(task);
}
