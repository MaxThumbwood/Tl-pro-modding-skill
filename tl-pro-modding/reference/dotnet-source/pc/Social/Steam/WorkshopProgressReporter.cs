// Decompiled with JetBrains decompiler
// Type: Terraria.Social.Steam.WorkshopProgressReporter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using Terraria.Social.Base;

#nullable disable
namespace Terraria.Social.Steam;

public class WorkshopProgressReporter : AWorkshopProgressReporter
{
  private List<WorkshopHelper.UGCBased.APublisherInstance> _publisherInstances;

  public WorkshopProgressReporter(
    List<WorkshopHelper.UGCBased.APublisherInstance> publisherInstances)
  {
    this._publisherInstances = publisherInstances;
  }

  public override bool HasOngoingTasks => this._publisherInstances.Count > 0;

  public override bool TryGetProgress(out float progress)
  {
    float num1 = 0.0f;
    float num2 = 0.0f;
    for (int index = 0; index < this._publisherInstances.Count; ++index)
    {
      float progress1;
      if (this._publisherInstances[index].TryGetProgress(out progress1))
      {
        num1 += progress1;
        ++num2;
      }
    }
    progress = 0.0f;
    if ((double) num2 == 0.0)
      return false;
    progress = num1 / num2;
    return true;
  }
}
