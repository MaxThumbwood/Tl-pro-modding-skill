// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.OneTimeDialogue
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using Terraria.DataStructures;
using Terraria.Localization;

#nullable disable
namespace Terraria.GameContent;

public class OneTimeDialogue : ConditionalDialogue
{
  public readonly LocalizedText ChatText;
  public readonly List<Item> Rewards = new List<Item>();

  public OneTimeDialogue(string key, Predicate<NPC> condition = null)
    : base((Predicate<NPC>) (npc =>
    {
      if (Main.LocalPlayer.oneTimeDialoguesSeen.Contains(key))
        return false;
      return condition == null || condition(npc);
    }))
  {
    this.ChatText = Language.GetText(key);
  }

  public override string GetChatAndClearCondition(NPC npc)
  {
    Player localPlayer = Main.LocalPlayer;
    localPlayer.oneTimeDialoguesSeen.Add(this.ChatText.Key);
    foreach (Item reward in this.Rewards)
      localPlayer.QuickSpawnItem((IEntitySource) new EntitySource_Gift((Entity) npc), reward, GetItemSettings.GiftRecieved);
    return this.ChatText.Value;
  }

  public OneTimeDialogue WithReward(int itemId, int stack = 1)
  {
    Item obj = new Item();
    obj.SetDefaults(itemId);
    obj.stack = stack;
    return this.WithRewards(obj);
  }

  public OneTimeDialogue WithRewards(params Item[] rewards)
  {
    this.Rewards.AddRange((IEnumerable<Item>) rewards);
    return this;
  }
}
