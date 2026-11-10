// Decompiled with JetBrains decompiler
// Type: Terraria.RecipeGroup
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.ID;
using Terraria.Localization;

#nullable disable
namespace Terraria;

public class RecipeGroup
{
  public static readonly int FakeItemIdOffset = 1000000;
  public static LocalizedText DefaultCombineFormat = Language.GetText("CombineFormat.RecipeGroup");
  public Func<string> GetText;
  public HashSet<int> ValidItems = new HashSet<int>();
  public List<int> Items = new List<int>();
  public int DecraftItemId;
  public static Dictionary<int, RecipeGroup> recipeGroups = new Dictionary<int, RecipeGroup>();
  public static int nextRecipeGroupIndex;

  private static Func<string> WithDefaultCombineFormat(string key)
  {
    LocalizedText text = Language.GetText(key);
    return (Func<string>) (() => RecipeGroup.DefaultCombineFormat.Format((object) text));
  }

  public int RegisteredId { get; private set; }

  public RecipeGroup(string groupDescriptorKey, params int[] validItems)
    : this(RecipeGroup.WithDefaultCombineFormat(groupDescriptorKey), validItems)
  {
  }

  public RecipeGroup(Func<string> getName, params int[] validItems)
  {
    this.RegisteredId = -1;
    this.GetText = getName;
    foreach (int validItem in validItems)
      this.Add(validItem);
  }

  public RecipeGroup Add(int itemID, Func<bool> isPreferred = null)
  {
    this.ValidItems.Add(itemID);
    this.Items.Add(itemID);
    return this;
  }

  internal void SortDecraftingEntries()
  {
    this.DecraftItemId = this.Items.OrderBy<int, int>((Func<int, int>) (e => ContentSamples.ItemsByType[e].value)).First<int>();
  }

  public override string ToString() => this.GetText();

  public RecipeGroup Register()
  {
    if (this.RegisteredId >= 0)
      throw new Exception("Already registered");
    int key = RecipeGroup.nextRecipeGroupIndex++;
    this.RegisteredId = key;
    RecipeGroup.recipeGroups.Add(key, this);
    return this;
  }

  public int CountUsableItems(Dictionary<int, int> itemStacksAvailable)
  {
    int num1 = 0;
    foreach (int validItem in this.ValidItems)
    {
      int num2;
      if (itemStacksAvailable.TryGetValue(validItem, out num2))
        num1 += num2;
    }
    return num1;
  }

  public int GetGroupFakeItemId() => this.RegisteredId + RecipeGroup.FakeItemIdOffset;

  public bool Contains(int itemType) => this.ValidItems.Contains(itemType);

  public int GetPlaceholderItemType() => this.Items[0];
}
