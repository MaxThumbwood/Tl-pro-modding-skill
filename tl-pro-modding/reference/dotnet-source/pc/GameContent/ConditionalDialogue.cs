// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ConditionalDialogue
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;

#nullable disable
namespace Terraria.GameContent;

public abstract class ConditionalDialogue
{
  private static List<ConditionalDialogue>[] _registry = new List<ConditionalDialogue>[(int) NPCID.Count];
  public readonly Predicate<NPC> ConditionsMet;

  private static void Register(int npcType, ConditionalDialogue dialogue)
  {
    List<ConditionalDialogue> conditionalDialogueList = ConditionalDialogue._registry[npcType];
    if (conditionalDialogueList == null)
      ConditionalDialogue._registry[npcType] = conditionalDialogueList = new List<ConditionalDialogue>();
    conditionalDialogueList.Add(dialogue);
  }

  public static bool TryGetPendingDialogue(NPC npc, out ConditionalDialogue dialogue)
  {
    dialogue = (ConditionalDialogue) null;
    List<ConditionalDialogue> conditionalDialogueList = ConditionalDialogue._registry[npc.type];
    if (conditionalDialogueList == null)
      return false;
    foreach (ConditionalDialogue conditionalDialogue in conditionalDialogueList)
    {
      if (conditionalDialogue.ConditionsMet(npc))
      {
        dialogue = conditionalDialogue;
        return true;
      }
    }
    return false;
  }

  public bool ShowIndicator { get; private set; }

  public ConditionalDialogue(Predicate<NPC> condition = null)
  {
    this.ShowIndicator = true;
    this.ConditionsMet = condition ?? (Predicate<NPC>) (_ => true);
  }

  public void HideIndicator() => this.ShowIndicator = false;

  public abstract string GetChatAndClearCondition(NPC npc);

  public void Register(int npcType) => ConditionalDialogue.Register(npcType, this);

  internal static void Init() => new ConditionalDialogue.FreeCakeDialogue().Register(208 /*0xD0*/);

  public static Predicate<NPC> CreateInventoryCondition(RecipeGroup item, int stack)
  {
    return ConditionalDialogue.CreateInventoryCondition(new Recipe.RequiredItemEntry(item, stack));
  }

  public static Predicate<NPC> CreateInventoryCondition(
    params Recipe.RequiredItemEntry[] requiredItems)
  {
    return (Predicate<NPC>) (_ => Recipe.CollectedEnoughItemsToCraft(requiredItems));
  }

  public static class ItemGroups
  {
    public static RecipeGroup Ore = new RecipeGroup("RecipeGroups.Ore", new int[8]
    {
      699,
      12,
      11,
      700,
      14,
      701,
      13,
      702
    });
    public static RecipeGroup Bars = new RecipeGroup("RecipeGroups.Bar", new int[8]
    {
      703,
      20,
      22,
      704,
      21,
      705,
      19,
      706
    });
    public static RecipeGroup Anvils = new RecipeGroup("ItemName.IronAnvil", new int[2]
    {
      35,
      716
    });
    public static RecipeGroup Whips = new RecipeGroup("RecipeGroups.Whip", new int[0]);
    public static RecipeGroup Mounts = new RecipeGroup("RecipeGroups.Mount", new int[0]);

    internal static void PostSetupContent()
    {
      foreach (Item obj in ContentSamples.ItemsByType.Values)
      {
        if (ProjectileID.Sets.IsAWhip[obj.shoot])
          ConditionalDialogue.ItemGroups.Whips.Add(obj.type);
      }
      foreach (Item obj in ContentSamples.ItemsByType.Values)
      {
        if (obj.mountType != -1)
          ConditionalDialogue.ItemGroups.Mounts.Add(obj.type);
      }
    }
  }

  private class FreeCakeDialogue : ConditionalDialogue
  {
    public FreeCakeDialogue()
      : base((Predicate<NPC>) (_ => NPC.freeCake))
    {
    }

    public override string GetChatAndClearCondition(NPC npc)
    {
      NPC.freeCake = false;
      NetMessage.SendData(51, number2: 10f);
      Item obj = new Item();
      obj.SetDefaults(3750);
      Main.LocalPlayer.QuickSpawnItem((IEntitySource) new EntitySource_Gift((Entity) npc), obj, GetItemSettings.GiftRecieved);
      return Language.GetTextValue("PartyGirlSpecialText.Cake" + (object) Main.rand.Next(1, 4));
    }
  }
}
