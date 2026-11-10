// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.AssetSourceController
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Content;
using ReLogic.Content.Sources;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.Audio;
using Terraria.IO;
using Terraria.Localization;

#nullable disable
namespace Terraria.GameContent;

public class AssetSourceController
{
  private readonly List<IContentSource> _staticSources;
  private readonly IAssetRepository _assetRepository;

  public event Action<ResourcePackList> OnResourcePackChange;

  public ResourcePackList ActiveResourcePackList { get; private set; }

  public AssetSourceController(
    IAssetRepository assetRepository,
    IEnumerable<IContentSource> staticSources)
  {
    this._assetRepository = assetRepository;
    this._staticSources = staticSources.ToList<IContentSource>();
    this.ActiveResourcePackList = new ResourcePackList();
  }

  public void Refresh()
  {
    foreach (ResourcePack allPack in this.ActiveResourcePackList.AllPacks)
      allPack.GetContentSource().Refresh();
    this.UseResourcePacks(this.ActiveResourcePackList);
  }

  public void UseResourcePacks(ResourcePackList resourcePacks)
  {
    if (this.OnResourcePackChange != null)
      this.OnResourcePackChange(resourcePacks);
    this.ActiveResourcePackList = resourcePacks;
    List<IContentSource> icontentSourceList1 = new List<IContentSource>(resourcePacks.EnabledPacks.OrderBy<ResourcePack, int>((Func<ResourcePack, int>) (pack => pack.SortingOrder)).Select<ResourcePack, IContentSource>((Func<ResourcePack, IContentSource>) (pack => pack.GetContentSource())));
    icontentSourceList1.AddRange((IEnumerable<IContentSource>) this._staticSources);
    foreach (IContentSource icontentSource in icontentSourceList1)
      icontentSource.ClearRejections();
    List<IContentSource> icontentSourceList2 = new List<IContentSource>();
    for (int index = icontentSourceList1.Count - 1; index >= 0; --index)
      icontentSourceList2.Add(icontentSourceList1[index]);
    this._assetRepository.SetSources((IEnumerable<IContentSource>) icontentSourceList1, (AssetRequestMode) 1);
    LanguageManager.Instance.UseSources(icontentSourceList2);
    Main.audioSystem.UseSources(icontentSourceList2);
    SoundEngine.Reload();
    Main.changeTheTitle = true;
  }
}
