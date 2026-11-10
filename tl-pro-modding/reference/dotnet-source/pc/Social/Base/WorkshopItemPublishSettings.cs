// Decompiled with JetBrains decompiler
// Type: Terraria.Social.Base.WorkshopItemPublishSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Terraria.Social.Base;

public class WorkshopItemPublishSettings
{
  public WorkshopTagOption[] UsedTags = new WorkshopTagOption[0];
  public WorkshopItemPublicSettingId Publicity;
  public string PreviewImagePath;

  public string[] GetUsedTagsInternalNames()
  {
    return ((IEnumerable<WorkshopTagOption>) this.UsedTags).Select<WorkshopTagOption, string>((Func<WorkshopTagOption, string>) (x => x.InternalNameForAPIs)).ToArray<string>();
  }
}
