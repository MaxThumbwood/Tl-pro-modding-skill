// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.States.WorkshopPublishInfoStateForResourcePack
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using Terraria.IO;
using Terraria.Social;
using Terraria.Social.Base;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.States;

public class WorkshopPublishInfoStateForResourcePack : AWorkshopPublishInfoState<ResourcePack>
{
  public WorkshopPublishInfoStateForResourcePack(UIState stateToGoBackTo, ResourcePack resourcePack)
    : base(stateToGoBackTo, resourcePack)
  {
    this._instructionsTextKey = "Workshop.ResourcePackPublishDescription";
    this._publishedObjectNameDescriptorTexKey = "Workshop.ResourcePackName";
  }

  protected override string GetPublishedObjectDisplayName()
  {
    return this._dataObject == null ? "null" : this._dataObject.Name;
  }

  protected override void GoToPublishConfirmation()
  {
    if (SocialAPI.Workshop != null && this._dataObject != null)
      SocialAPI.Workshop.PublishResourcePack(this._dataObject, this.GetPublishSettings());
    Main.menuMode = 888;
    Main.MenuUI.SetState(this._previousUIState);
  }

  protected override List<WorkshopTagOption> GetTagsToShow()
  {
    return SocialAPI.Workshop.SupportedTags.ResourcePackTags;
  }

  protected override bool TryFindingTags(out FoundWorkshopEntryInfo info)
  {
    return SocialAPI.Workshop.TryGetInfoForResourcePack(this._dataObject, out info);
  }
}
