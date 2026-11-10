// Decompiled with JetBrains decompiler
// Type: Terraria.Social.Base.WorkshopSocialModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using Terraria.IO;

#nullable disable
namespace Terraria.Social.Base;

public abstract class WorkshopSocialModule : ISocialModule
{
  public WorkshopBranding Branding { get; protected set; }

  public AWorkshopProgressReporter ProgressReporter { get; protected set; }

  public AWorkshopTagsCollection SupportedTags { get; protected set; }

  public WorkshopIssueReporter IssueReporter { get; protected set; }

  public abstract void Initialize();

  public abstract void Shutdown();

  public abstract void PublishWorld(WorldFileData world, WorkshopItemPublishSettings settings);

  public abstract void PublishResourcePack(
    ResourcePack resourcePack,
    WorkshopItemPublishSettings settings);

  public abstract bool TryGetInfoForWorld(WorldFileData world, out FoundWorkshopEntryInfo info);

  public abstract bool TryGetInfoForResourcePack(
    ResourcePack resourcePack,
    out FoundWorkshopEntryInfo info);

  public abstract void LoadEarlyContent();

  public abstract List<string> GetListOfSubscribedResourcePackPaths();

  public abstract List<string> GetListOfSubscribedWorldPaths();

  public abstract bool TryGetPath(string pathEnd, out string fullPathFound);

  public abstract void ImportDownloadedWorldToLocalSaves(
    WorldFileData world,
    string newDisplayName,
    Action onCompleted);
}
