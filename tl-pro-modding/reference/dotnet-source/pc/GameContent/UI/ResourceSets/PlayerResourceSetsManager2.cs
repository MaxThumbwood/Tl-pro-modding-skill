// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.ResourceSets.PlayerResourceSetsManager2
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.IO;

#nullable disable
namespace Terraria.GameContent.UI.ResourceSets;

public class PlayerResourceSetsManager2 : SelectionHolder<IPlayerResourcesDisplaySet>
{
  protected override void Configuration_Save(Preferences obj)
  {
    obj.Put("PlayerResourcesSet", (object) this.ActiveSelectionConfigKey);
  }

  protected override void Configuration_OnLoad(Preferences obj)
  {
    this.ActiveSelectionConfigKey = Main.Configuration.Get<string>("PlayerResourcesSet", "New");
  }

  protected override void PopulateOptionsAndLoadContent(AssetRequestMode mode)
  {
    this.Options["New"] = (IPlayerResourcesDisplaySet) new FancyClassicPlayerResourcesDisplaySet("New", "New", "FancyClassic", mode);
    this.Options["Default"] = (IPlayerResourcesDisplaySet) new ClassicPlayerResourcesDisplaySet("Default", "Default");
    this.Options["HorizontalBarsWithFullText"] = (IPlayerResourcesDisplaySet) new HorizontalBarsPlayerResourcesDisplaySet("HorizontalBarsWithFullText", "HorizontalBarsWithFullText", "HorizontalBars", mode);
    this.Options["HorizontalBarsWithText"] = (IPlayerResourcesDisplaySet) new HorizontalBarsPlayerResourcesDisplaySet("HorizontalBarsWithText", "HorizontalBarsWithText", "HorizontalBars", mode);
    this.Options["HorizontalBars"] = (IPlayerResourcesDisplaySet) new HorizontalBarsPlayerResourcesDisplaySet("HorizontalBars", "HorizontalBars", "HorizontalBars", mode);
    this.Options["NewWithText"] = (IPlayerResourcesDisplaySet) new FancyClassicPlayerResourcesDisplaySet("NewWithText", "NewWithText", "FancyClassic", mode);
  }

  public void TryToHoverOverResources() => this.ActiveSelection.TryToHover();

  public void Draw() => this.ActiveSelection.Draw();
}
