// Decompiled with JetBrains decompiler
// Type: Terraria.Lang
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Terraria.DataStructures;
using Terraria.GameContent.Events;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Map;
using Terraria.UI;
using Terraria.Utilities;

#nullable disable
namespace Terraria;

public class Lang
{
  [Old("Lang arrays have been replaced with the new Language.GetText system.")]
  public static LocalizedText[] menu = new LocalizedText[254];
  [Old("Lang arrays have been replaced with the new Language.GetText system.")]
  public static LocalizedText[] gen = new LocalizedText[94];
  [Old("Lang arrays have been replaced with the new Language.GetText system.")]
  public static LocalizedText[] misc = new LocalizedText[201];
  [Old("Lang arrays have been replaced with the new Language.GetText system.")]
  public static LocalizedText[] inter = new LocalizedText[129];
  [Old("Lang arrays have been replaced with the new Language.GetText system.")]
  public static LocalizedText[] tip = new LocalizedText[62];
  [Old("Lang arrays have been replaced with the new Language.GetText system.")]
  public static LocalizedText[] mp = new LocalizedText[27];
  [Old("Lang arrays have been replaced with the new Language.GetText system.")]
  public static LocalizedText[] chestType = new LocalizedText[52];
  [Old("Lang arrays have been replaced with the new Language.GetText system.")]
  public static LocalizedText[] dresserType = new LocalizedText[65];
  [Old("Lang arrays have been replaced with the new Language.GetText system.")]
  public static LocalizedText[] chestType2 = new LocalizedText[38];
  public static LocalizedText[] prefix = new LocalizedText[PrefixID.Count];
  public static LocalizedText[] _mapLegendCache;
  private static LocalizedText[] _itemNameCache = new LocalizedText[(int) ItemID.Count];
  private static LocalizedText[] _projectileNameCache = new LocalizedText[(int) ProjectileID.Count];
  private static LocalizedText[] _npcNameCache = new LocalizedText[(int) NPCID.Count];
  private static LocalizedText[] _negativeNpcNameCache = new LocalizedText[65];
  private static LocalizedText[] _buffNameCache = new LocalizedText[BuffID.Count];
  private static LocalizedText[] _buffDescriptionCache = new LocalizedText[BuffID.Count];
  private static ItemTooltip[] _itemTooltipCache = new ItemTooltip[(int) ItemID.Count];
  private static LocalizedText[] _emojiNameCache = new LocalizedText[EmoteID.Count];
  private static Dictionary<string, Func<object>> _globalSubstitutions = new Dictionary<string, Func<object>>();
  private static LocalizedText _prefixFormatText = Language.GetText("CombineFormat.Prefix");

  public static string GetMapObjectName(int id)
  {
    return Lang._mapLegendCache != null ? Lang._mapLegendCache[id].Value : string.Empty;
  }

  public static void RegisterGlobalSubstitution(string key, Func<object> getValue)
  {
    Lang._globalSubstitutions[key] = getValue;
  }

  public static object GetGlobalSubstitution(string key)
  {
    Func<object> func;
    return !Lang._globalSubstitutions.TryGetValue(key, out func) ? (object) null : func();
  }

  private static void InitGlobalSubstitutions()
  {
    Lang.RegisterGlobalSubstitution("Nurse", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(18)));
    Lang.RegisterGlobalSubstitution("Merchant", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(17)));
    Lang.RegisterGlobalSubstitution("ArmsDealer", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(19)));
    Lang.RegisterGlobalSubstitution("Dryad", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(20)));
    Lang.RegisterGlobalSubstitution("Demolitionist", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(38)));
    Lang.RegisterGlobalSubstitution("Clothier", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(54)));
    Lang.RegisterGlobalSubstitution("Guide", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(22)));
    Lang.RegisterGlobalSubstitution("Wizard", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(108)));
    Lang.RegisterGlobalSubstitution("GoblinTinkerer", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(107)));
    Lang.RegisterGlobalSubstitution("Mechanic", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(124)));
    Lang.RegisterGlobalSubstitution("Truffle", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(160 /*0xA0*/)));
    Lang.RegisterGlobalSubstitution("Steampunker", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(178)));
    Lang.RegisterGlobalSubstitution("DyeTrader", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(207)));
    Lang.RegisterGlobalSubstitution("PartyGirl", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(208 /*0xD0*/)));
    Lang.RegisterGlobalSubstitution("Cyborg", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(209)));
    Lang.RegisterGlobalSubstitution("Painter", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(227)));
    Lang.RegisterGlobalSubstitution("WitchDoctor", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(228)));
    Lang.RegisterGlobalSubstitution("Pirate", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(229)));
    Lang.RegisterGlobalSubstitution("Stylist", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(353)));
    Lang.RegisterGlobalSubstitution("TravelingMerchant", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(368)));
    Lang.RegisterGlobalSubstitution("Angler", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(369)));
    Lang.RegisterGlobalSubstitution("Bartender", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(550)));
    Lang.RegisterGlobalSubstitution("WorldName", (Func<object>) (() => (object) Main.worldName));
    Lang.RegisterGlobalSubstitution("Day", (Func<object>) (() => (object) Main.dayTime));
    Lang.RegisterGlobalSubstitution("BloodMoon", (Func<object>) (() => (object) Main.bloodMoon));
    Lang.RegisterGlobalSubstitution("Eclipse", (Func<object>) (() => (object) Main.eclipse));
    Lang.RegisterGlobalSubstitution("MoonLordDefeated", (Func<object>) (() => (object) NPC.downedMoonlord));
    Lang.RegisterGlobalSubstitution("GolemDefeated", (Func<object>) (() => (object) NPC.downedGolemBoss));
    Lang.RegisterGlobalSubstitution("DukeFishronDefeated", (Func<object>) (() => (object) NPC.downedFishron));
    Lang.RegisterGlobalSubstitution("FrostLegionDefeated", (Func<object>) (() => (object) NPC.downedFrost));
    Lang.RegisterGlobalSubstitution("MartiansDefeated", (Func<object>) (() => (object) NPC.downedMartians));
    Lang.RegisterGlobalSubstitution("PumpkingDefeated", (Func<object>) (() => (object) NPC.downedHalloweenKing));
    Lang.RegisterGlobalSubstitution("IceQueenDefeated", (Func<object>) (() => (object) NPC.downedChristmasIceQueen));
    Lang.RegisterGlobalSubstitution("HardMode", (Func<object>) (() => (object) Main.hardMode));
    Lang.RegisterGlobalSubstitution("Homeless", (Func<object>) (() => Main.LocalPlayer.talkNPC < 0 ? (object) false : (Main.npc[Main.LocalPlayer.talkNPC].homeless ? (object) true : (object) false)));
    Lang.RegisterGlobalSubstitution("InventoryKey", (Func<object>) (() => (object) Main.cInv));
    Lang.RegisterGlobalSubstitution("PlayerName", (Func<object>) (() => (object) Main.player[Main.myPlayer].name));
    Lang.RegisterGlobalSubstitution("GolfGuy", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(588)));
    Lang.RegisterGlobalSubstitution("TaxCollector", (Func<object>) (() => (object) NPC.GetFirstNPCNameOrNull(441)));
    Lang.RegisterGlobalSubstitution("Rain", (Func<object>) (() => (object) Main.raining));
    Lang.RegisterGlobalSubstitution("Graveyard", (Func<object>) (() => (object) Main.LocalPlayer.ZoneGraveyard));
    Lang.RegisterGlobalSubstitution("AnglerCompletedQuestsCount", (Func<object>) (() => (object) Main.LocalPlayer.anglerQuestsFinished));
    Lang.RegisterGlobalSubstitution("TotalDeathsCount", (Func<object>) (() => (object) Main.LocalPlayer.numberOfDeathsPVE));
    Lang.RegisterGlobalSubstitution("WorldEvilStone", (Func<object>) (() => !WorldGen.crimson ? (object) Language.GetTextValue("Misc.Ebonstone") : (object) Language.GetTextValue("Misc.Crimstone")));
    Lang.RegisterGlobalSubstitution("InputTriggerUI_BuildFromInventory", (Func<object>) (() => (object) PlayerInput.GenerateInputTag_ForCurrentGamemode(false, "QuickMount")));
    Lang.RegisterGlobalSubstitution("InputTriggerUI_TrashEnabled", (Func<object>) (() => (object) !ItemSlot.Options.DisableQuickTrash));
    Lang.RegisterGlobalSubstitution("InputTriggerUI_Trash", (Func<object>) (() => !PlayerInput.UsingGamepad ? (object) Language.GetTextValue(ItemSlot.Options.DisableLeftShiftTrashCan ? "Controls.Control" : "Controls.Shift") : (object) PlayerInput.GenerateInputTag_ForCurrentGamemode(false, "SmartSelect")));
    Lang.RegisterGlobalSubstitution("InputTriggerUI_FavoriteItem", (Func<object>) (() => !PlayerInput.UsingGamepad ? (object) Main.FavoriteKey.ToString() : (object) PlayerInput.GenerateInputTag_ForCurrentGamemode(false, "SmartCursor")));
    Lang.RegisterGlobalSubstitution("InputTrigger_QuickEquip", (Func<object>) (() => (object) PlayerInput.GenerateInputTag_ForCurrentGamemode(false, "Grapple")));
    Lang.RegisterGlobalSubstitution("InputTrigger_Grapple", (Func<object>) (() => (object) PlayerInput.GenerateInputTag_ForCurrentGamemode(true, "Grapple")));
    Lang.RegisterGlobalSubstitution("InputTrigger_LockOn", (Func<object>) (() => (object) PlayerInput.GenerateInputTag_ForCurrentGamemode(true, "LockOn")));
    Lang.RegisterGlobalSubstitution("InputTrigger_RadialQuickbar", (Func<object>) (() => (object) PlayerInput.GenerateInputTag_ForCurrentGamemode(true, "HotbarMinus")));
    Lang.RegisterGlobalSubstitution("InputTrigger_RadialHotbar", (Func<object>) (() => (object) PlayerInput.GenerateInputTag_ForCurrentGamemode(true, "HotbarPlus")));
    Lang.RegisterGlobalSubstitution("InputTrigger_SmartCursor", (Func<object>) (() => (object) PlayerInput.GenerateInputTag_ForCurrentGamemode(true, "SmartCursor")));
    Lang.RegisterGlobalSubstitution("InputTrigger_UseOrAttack", (Func<object>) (() => (object) PlayerInput.GenerateInputTag_ForCurrentGamemode(true, "MouseLeft")));
    Lang.RegisterGlobalSubstitution("InputTrigger_InteractWithTile", (Func<object>) (() => (object) PlayerInput.GenerateInputTag_ForCurrentGamemode(true, "MouseRight")));
    Lang.RegisterGlobalSubstitution("InputTrigger_InteractWithTileUI", (Func<object>) (() => (object) PlayerInput.GenerateInputTag_ForCurrentGamemode(false, "MouseRight")));
    Lang.RegisterGlobalSubstitution("InputTrigger_ToggleOrOpen", (Func<object>) (() => !PlayerInput.UsingGamepad ? (object) PlayerInput.GenerateInputTag_ForCurrentGamemode(true, "MouseRight") : (object) PlayerInput.GenerateInputTag_ForCurrentGamemode(false, "Grapple")));
    Lang.RegisterGlobalSubstitution("InputTrigger_SmartSelect", (Func<object>) (() => (object) PlayerInput.GenerateInputTag_ForCurrentGamemode(true, "SmartSelect")));
    Lang.RegisterGlobalSubstitution("ToggleArmorSetBonusKey", (Func<object>) (() => (object) Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN")));
  }

  [Old("dialog is deprecated. Please use Language.GetText instead.")]
  public static string dialog(int l, bool english = false)
  {
    return Language.GetTextValue("LegacyDialog." + (object) l);
  }

  public static string GetNPCNameValue(int netID) => Lang.GetNPCName(netID).Value;

  public static LocalizedText GetNPCName(int netID)
  {
    if (netID > 0 && netID < (int) NPCID.Count)
      return Lang._npcNameCache[netID];
    return netID < 0 && -netID - 1 < Lang._negativeNpcNameCache.Length ? Lang._negativeNpcNameCache[-netID - 1] : LocalizedText.Empty;
  }

  public static ItemTooltip GetTooltip(int itemId) => Lang._itemTooltipCache[itemId];

  public static LocalizedText GetItemName(int id)
  {
    if (id < 0)
      id = (int) ItemID.FromNetId((short) id);
    return id > 0 && id < (int) ItemID.Count && Lang._itemNameCache[id] != null ? Lang._itemNameCache[id] : LocalizedText.Empty;
  }

  public static LocalizedText GetEmojiName(int id)
  {
    return id >= 0 && id < EmoteID.Count && Lang._emojiNameCache[id] != null ? Lang._emojiNameCache[id] : LocalizedText.Empty;
  }

  public static string GetItemNameValue(int id) => Lang.GetItemName(id).Value;

  public static string GetPrefixedItemName(int id, int prefixType)
  {
    LocalizedText itemName = Lang.GetItemName(id);
    LocalizedText localizedText = Lang.prefix[prefixType];
    string str1 = localizedText.Value;
    string variant;
    string str2;
    if (Language.TryGetVariation(itemName.Key, "Gender", out variant) && Language.TryGetVariation(localizedText.Key, variant, out str2))
      str1 = str2;
    return Lang._prefixFormatText.FormatWith((object) new Lang.ItemPrefixCombiner()
    {
      PrefixName = str1,
      ItemName = itemName.Value
    });
  }

  public static string GetBuffName(int id) => Lang._buffNameCache[id].Value;

  public static string GetBuffDescription(int id) => Lang._buffDescriptionCache[id].Value;

  public static string GetDryadWorldStatusDialog(out bool worldIsEntirelyPure)
  {
    worldIsEntirelyPure = false;
    int tGood = (int) WorldGen.tGood;
    int tEvil = (int) WorldGen.tEvil;
    int tBlood = (int) WorldGen.tBlood;
    string textValue1;
    if (tGood > 0 && tEvil > 0 && tBlood > 0)
      textValue1 = Language.GetTextValue("DryadSpecialText.WorldStatusAll", (object) Main.worldName, (object) tGood, (object) tEvil, (object) tBlood);
    else if (tGood > 0 && tEvil > 0)
      textValue1 = Language.GetTextValue("DryadSpecialText.WorldStatusHallowCorrupt", (object) Main.worldName, (object) tGood, (object) tEvil);
    else if (tGood > 0 && tBlood > 0)
      textValue1 = Language.GetTextValue("DryadSpecialText.WorldStatusHallowCrimson", (object) Main.worldName, (object) tGood, (object) tBlood);
    else if (tEvil > 0 && tBlood > 0)
      textValue1 = Language.GetTextValue("DryadSpecialText.WorldStatusCorruptCrimson", (object) Main.worldName, (object) tEvil, (object) tBlood);
    else if (tEvil > 0)
      textValue1 = Language.GetTextValue("DryadSpecialText.WorldStatusCorrupt", (object) Main.worldName, (object) tEvil);
    else if (tBlood > 0)
      textValue1 = Language.GetTextValue("DryadSpecialText.WorldStatusCrimson", (object) Main.worldName, (object) tBlood);
    else if (tGood > 0)
    {
      textValue1 = Language.GetTextValue("DryadSpecialText.WorldStatusHallow", (object) Main.worldName, (object) tGood);
    }
    else
    {
      string textValue2 = Language.GetTextValue("DryadSpecialText.WorldStatusPure", (object) Main.worldName);
      worldIsEntirelyPure = true;
      return textValue2;
    }
    string str = (double) tGood * 1.2 < (double) (tEvil + tBlood) || (double) tGood * 0.8 > (double) (tEvil + tBlood) ? (tGood < tEvil + tBlood ? (tEvil + tBlood <= tGood + 20 ? (tEvil + tBlood <= 5 ? Language.GetTextValue("DryadSpecialText.WorldDescriptionClose") : Language.GetTextValue("DryadSpecialText.WorldDescriptionWork")) : Language.GetTextValue("DryadSpecialText.WorldDescriptionGrim")) : Language.GetTextValue("DryadSpecialText.WorldDescriptionFairyTale")) : Language.GetTextValue("DryadSpecialText.WorldDescriptionBalanced");
    return $"{textValue1} {str}";
  }

  public static string GetRandomGameTitle() => Language.RandomFromCategory("GameTitle").Value;

  public static string DyeTraderQuestChat(bool gotDye = false)
  {
    LocalizedText[] all = Language.FindAll(Lang.CreateDialogFilter(gotDye ? "DyeTraderSpecialText.HasPlant" : "DyeTraderSpecialText.NoPlant"));
    return all[Main.rand.Next(all.Length)].Value;
  }

  public static string AnglerQuestCountChat()
  {
    return Language.SelectRandom(Lang.CreateDialogFilter("AnglerQuestChatter.")).Value;
  }

  public static string BartenderHelpText(NPC npc)
  {
    Player player = Main.player[Main.myPlayer];
    if (player.bartenderQuestLog == 0)
    {
      ++player.bartenderQuestLog;
      Item obj = new Item();
      obj.SetDefaults(3817);
      obj.stack = 10;
      player.QuickSpawnItem((IEntitySource) new EntitySource_Gift((Entity) npc), obj, GetItemSettings.GiftRecieved);
      return Language.GetTextValue("BartenderSpecialText.FirstHelp");
    }
    LocalizedText[] all = Language.FindAll(Lang.CreateDialogFilter("BartenderHelpText."));
    if (Main.BartenderHelpTextIndex >= all.Length)
      Main.BartenderHelpTextIndex = 0;
    return all[Main.BartenderHelpTextIndex++].Value;
  }

  public static string BartenderChat()
  {
    return Main.rand.Next(5) == 0 ? Language.GetTextValue(!DD2Event.DownedInvasionT3 ? (!DD2Event.DownedInvasionT2 ? (!DD2Event.DownedInvasionT1 ? "BartenderSpecialText.BeforeDD2Tier1" : "BartenderSpecialText.AfterDD2Tier1") : "BartenderSpecialText.AfterDD2Tier2") : "BartenderSpecialText.AfterDD2Tier3") : Language.SelectRandom(Lang.CreateDialogFilter("BartenderChatter.")).Value;
  }

  public static string GolferChat()
  {
    return Language.SelectRandom(Lang.CreateDialogFilter("GolferChatter.")).Value;
  }

  public static string BestiaryGirlChat()
  {
    string startsWith = "BestiaryGirlChatter.";
    if (NPC.ShouldBestiaryGirlBeLycantrope())
      startsWith = "BestiaryGirlLycantropeChatter.";
    return Language.SelectRandom(Lang.CreateDialogFilter(startsWith)).Value;
  }

  public static string PrincessChat()
  {
    return Language.SelectRandom(Lang.CreateDialogFilter("PrincessChatter.")).Value;
  }

  public static string CatChat()
  {
    return Language.SelectRandom(Lang.CreateDialogFilter("CatChatter.Chatter")).Value;
  }

  public static string DogChat()
  {
    return Language.SelectRandom(Lang.CreateDialogFilter("DogChatter.Chatter")).Value;
  }

  public static string BunnyChat()
  {
    return Language.SelectRandom(Lang.CreateDialogFilter("BunnyChatter.Chatter")).Value;
  }

  public static string GetSlimeType(NPC npc)
  {
    string slimeType = "Blue";
    switch (npc.type)
    {
      case 670:
        slimeType = "Blue";
        break;
      case 678:
        slimeType = "Green";
        break;
      case 679:
        slimeType = "Old";
        break;
      case 680:
        slimeType = "Purple";
        break;
      case 681:
        slimeType = "Rainbow";
        break;
      case 682:
        slimeType = "Red";
        break;
      case 683:
        slimeType = "Yellow";
        break;
      case 684:
        slimeType = "Copper";
        break;
    }
    return slimeType;
  }

  public static string SlimeChat(NPC npc)
  {
    return Language.SelectRandom(Lang.CreateDialogFilter($"Slime{Lang.GetSlimeType(npc)}Chatter.Chatter")).Value;
  }

  public static string GetNPCHouseBannerText(NPC npc, int bannerStyle)
  {
    return bannerStyle == 1 ? Language.GetTextValue("Game.ReservedForNPC", (object) npc.FullName) : npc.FullName;
  }

  public static LanguageSearchFilter CreateDialogFilter(string startsWith, object substitutions)
  {
    return (LanguageSearchFilter) ((key, text) => key.StartsWith(startsWith) && text.ConditionsMetWith(substitutions));
  }

  public static LanguageSearchFilter CreateDialogFilter(string startsWith, bool checkConditions = true)
  {
    return (LanguageSearchFilter) ((key, text) =>
    {
      if (!key.StartsWith(startsWith))
        return false;
      return !checkConditions || text.ConditionsMet;
    });
  }

  public static string AnglerQuestChat(bool turnIn = false)
  {
    if (turnIn)
      return Language.SelectRandom(Lang.CreateDialogFilter("AnglerQuestText.TurnIn_")).Value;
    if (Main.anglerQuestFinished)
      return Language.SelectRandom(Lang.CreateDialogFilter("AnglerQuestText.NoQuest_")).Value;
    int anglerQuestItemNetId = Main.anglerQuestItemNetIDs[Main.anglerQuest];
    Main.npcChatCornerItem = anglerQuestItemNetId;
    return Language.GetTextValue("AnglerQuestText.Quest_" + ItemID.Search.GetName(anglerQuestItemNetId));
  }

  public static LocalizedText GetProjectileName(int type)
  {
    return type >= 0 && type < Lang._projectileNameCache.Length && Lang._projectileNameCache[type] != null ? Lang._projectileNameCache[type] : LocalizedText.Empty;
  }

  private static void FillNameCacheArray<IdClass, IdType>(
    string category,
    LocalizedText[] nameCache,
    bool leaveMissingEntriesBlank = false)
    where IdType : IConvertible
  {
    for (int index = 0; index < nameCache.Length; ++index)
      nameCache[index] = LocalizedText.Empty;
    ((IEnumerable<FieldInfo>) typeof (IdClass).GetFields(BindingFlags.Static | BindingFlags.Public)).Where<FieldInfo>((Func<FieldInfo, bool>) (f => f.FieldType == typeof (IdType))).ToList<FieldInfo>().ForEach((Action<FieldInfo>) (field =>
    {
      long int64 = Convert.ToInt64((object) (IdType) field.GetValue((object) null));
      if (int64 >= 0L && int64 < (long) nameCache.Length)
      {
        nameCache[(IntPtr) int64] = !leaveMissingEntriesBlank || Language.Exists($"{category}.{field.Name}") ? Language.GetText($"{category}.{field.Name}") : LocalizedText.Empty;
      }
      else
      {
        if (!(field.Name == "None"))
          return;
        nameCache[int64] = LocalizedText.Empty;
      }
    }));
  }

  public static void InitializeLegacyLocalization()
  {
    Lang.FillNameCacheArray<PrefixID, int>("Prefix", Lang.prefix);
    for (int index = 0; index < Lang.gen.Length; ++index)
      Lang.gen[index] = Language.GetText("LegacyWorldGen." + (object) index);
    for (int index = 0; index < Lang.menu.Length; ++index)
      Lang.menu[index] = Language.GetText("LegacyMenu." + (object) index);
    for (int index = 0; index < Lang.inter.Length; ++index)
      Lang.inter[index] = Language.GetText("LegacyInterface." + (object) index);
    for (int index = 0; index < Lang.misc.Length; ++index)
      Lang.misc[index] = Language.GetText("LegacyMisc." + (object) index);
    for (int index = 0; index < Lang.mp.Length; ++index)
      Lang.mp[index] = Language.GetText("LegacyMultiplayer." + (object) index);
    for (int index = 0; index < Lang.tip.Length; ++index)
      Lang.tip[index] = Language.GetText("LegacyTooltip." + (object) index);
    for (int index = 0; index < Lang.chestType.Length; ++index)
      Lang.chestType[index] = Language.GetText("LegacyChestType." + (object) index);
    for (int index = 0; index < Lang.chestType2.Length; ++index)
      Lang.chestType2[index] = Language.GetText("LegacyChestType2." + (object) index);
    for (int index = 0; index < Lang.dresserType.Length; ++index)
      Lang.dresserType[index] = Language.GetText("LegacyDresserType." + (object) index);
    Lang.FillNameCacheArray<ItemID, short>("ItemName", Lang._itemNameCache);
    Lang.FillNameCacheArray<ProjectileID, short>("ProjectileName", Lang._projectileNameCache);
    Lang.FillNameCacheArray<NPCID, short>("NPCName", Lang._npcNameCache);
    Lang.FillNameCacheArray<BuffID, int>("BuffName", Lang._buffNameCache);
    Lang.FillNameCacheArray<BuffID, int>("BuffDescription", Lang._buffDescriptionCache);
    Lang.FillNameCacheArray<EmoteID, int>("EmojiName", Lang._emojiNameCache, true);
    for (int id = -65; id < 0; ++id)
      Lang._negativeNpcNameCache[-id - 1] = Lang._npcNameCache[NPCID.FromNetId(id)];
    Lang._negativeNpcNameCache[0] = Language.GetText("NPCName.Slimeling");
    Lang._negativeNpcNameCache[1] = Language.GetText("NPCName.Slimer2");
    Lang._negativeNpcNameCache[2] = Language.GetText("NPCName.GreenSlime");
    Lang._negativeNpcNameCache[3] = Language.GetText("NPCName.Pinky");
    Lang._negativeNpcNameCache[4] = Language.GetText("NPCName.BabySlime");
    Lang._negativeNpcNameCache[5] = Language.GetText("NPCName.BlackSlime");
    Lang._negativeNpcNameCache[6] = Language.GetText("NPCName.PurpleSlime");
    Lang._negativeNpcNameCache[7] = Language.GetText("NPCName.RedSlime");
    Lang._negativeNpcNameCache[8] = Language.GetText("NPCName.YellowSlime");
    Lang._negativeNpcNameCache[9] = Language.GetText("NPCName.JungleSlime");
    Lang._negativeNpcNameCache[53] = Language.GetText("NPCName.SmallRainZombie");
    Lang._negativeNpcNameCache[54] = Language.GetText("NPCName.BigRainZombie");
    for (int index = 0; index < Lang._itemTooltipCache.Length; ++index)
      Lang._itemTooltipCache[index] = ItemTooltip.None;
    ((IEnumerable<FieldInfo>) typeof (ItemID).GetFields(BindingFlags.Static | BindingFlags.Public)).Where<FieldInfo>((Func<FieldInfo, bool>) (f => f.FieldType == typeof (short))).ToList<FieldInfo>().ForEach((Action<FieldInfo>) (field =>
    {
      short index = (short) field.GetValue((object) null);
      if (index <= (short) 0 || (int) index >= Lang._itemTooltipCache.Length)
        return;
      Lang._itemTooltipCache[(int) index] = ItemTooltip.FromLanguageKey("ItemTooltip." + field.Name);
    }));
    Lang.InitGlobalSubstitutions();
  }

  public static void BuildMapAtlas()
  {
    if (Main.dedServ)
      return;
    Lang._mapLegendCache = new LocalizedText[MapHelper.LookupCount()];
    for (int index = 0; index < Lang._mapLegendCache.Length; ++index)
      Lang._mapLegendCache[index] = LocalizedText.Empty;
    for (int tileType = 0; tileType < TileID.Sets.IsATreeTrunk.Length; ++tileType)
    {
      if (TileID.Sets.IsATreeTrunk[tileType])
        Lang._mapLegendCache[MapHelper.TileToLookup(tileType, 0)] = Language.GetText("MapObject.Tree");
    }
    LocalizedText[] itemNameCache = Lang._itemNameCache;
    Lang._mapLegendCache[MapHelper.TileToLookup(4, 0)] = itemNameCache[8];
    Lang._mapLegendCache[MapHelper.TileToLookup(4, 1)] = itemNameCache[8];
    Lang._mapLegendCache[MapHelper.TileToLookup(6, 0)] = Language.GetText("MapObject.Iron");
    Lang._mapLegendCache[MapHelper.TileToLookup(7, 0)] = Language.GetText("MapObject.Copper");
    Lang._mapLegendCache[MapHelper.TileToLookup(8, 0)] = Language.GetText("MapObject.Gold");
    Lang._mapLegendCache[MapHelper.TileToLookup(9, 0)] = Language.GetText("MapObject.Silver");
    Lang._mapLegendCache[MapHelper.TileToLookup(10, 0)] = Language.GetText("MapObject.Door");
    Lang._mapLegendCache[MapHelper.TileToLookup(11, 0)] = Language.GetText("MapObject.Door");
    Lang._mapLegendCache[MapHelper.TileToLookup(12, 0)] = itemNameCache[29];
    Lang._mapLegendCache[MapHelper.TileToLookup(665, 0)] = itemNameCache[29];
    Lang._mapLegendCache[MapHelper.TileToLookup(711, 0)] = itemNameCache[540];
    Lang._mapLegendCache[MapHelper.TileToLookup(664, 0)] = itemNameCache[540];
    Lang._mapLegendCache[MapHelper.TileToLookup(712, 0)] = itemNameCache[540];
    Lang._mapLegendCache[MapHelper.TileToLookup(713, 0)] = itemNameCache[540];
    Lang._mapLegendCache[MapHelper.TileToLookup(714, 0)] = itemNameCache[540];
    Lang._mapLegendCache[MapHelper.TileToLookup(715, 0)] = itemNameCache[540];
    Lang._mapLegendCache[MapHelper.TileToLookup(716, 0)] = itemNameCache[540];
    Lang._mapLegendCache[MapHelper.TileToLookup(639, 0)] = itemNameCache[109];
    Lang._mapLegendCache[MapHelper.TileToLookup(630, 0)] = itemNameCache[5137];
    Lang._mapLegendCache[MapHelper.TileToLookup(631, 0)] = itemNameCache[5138];
    Lang._mapLegendCache[MapHelper.TileToLookup(13, 0)] = itemNameCache[31 /*0x1F*/];
    Lang._mapLegendCache[MapHelper.TileToLookup(14, 0)] = Language.GetText("MapObject.Table");
    Lang._mapLegendCache[MapHelper.TileToLookup(469, 0)] = Language.GetText("MapObject.Table");
    Lang._mapLegendCache[MapHelper.TileToLookup(486, 0)] = itemNameCache[4063];
    Lang._mapLegendCache[MapHelper.TileToLookup(487, 0)] = itemNameCache[4064];
    Lang._mapLegendCache[MapHelper.TileToLookup(487, 1)] = itemNameCache[4065];
    Lang._mapLegendCache[MapHelper.TileToLookup(489, 0)] = itemNameCache[4074];
    Lang._mapLegendCache[MapHelper.TileToLookup(490, 0)] = itemNameCache[4075];
    Lang._mapLegendCache[MapHelper.TileToLookup(15, 0)] = Language.GetText("MapObject.Chair");
    Lang._mapLegendCache[MapHelper.TileToLookup(15, 1)] = Language.GetText("MapObject.Toilet");
    Lang._mapLegendCache[MapHelper.TileToLookup(16 /*0x10*/, 0)] = Language.GetText("MapObject.Anvil");
    Lang._mapLegendCache[MapHelper.TileToLookup(17, 0)] = itemNameCache[33];
    Lang._mapLegendCache[MapHelper.TileToLookup(18, 0)] = itemNameCache[36];
    Lang._mapLegendCache[MapHelper.TileToLookup(20, 0)] = Language.GetText("MapObject.Sapling");
    Lang._mapLegendCache[MapHelper.TileToLookup(590, 0)] = Language.GetText("MapObject.Sapling");
    Lang._mapLegendCache[MapHelper.TileToLookup(595, 0)] = Language.GetText("MapObject.Sapling");
    Lang._mapLegendCache[MapHelper.TileToLookup(615, 0)] = Language.GetText("MapObject.Sapling");
    Lang._mapLegendCache[MapHelper.TileToLookup(21, 0)] = itemNameCache[48 /*0x30*/];
    Lang._mapLegendCache[MapHelper.TileToLookup(467, 0)] = itemNameCache[48 /*0x30*/];
    Lang._mapLegendCache[MapHelper.TileToLookup(22, 0)] = Language.GetText("MapObject.Demonite");
    Lang._mapLegendCache[MapHelper.TileToLookup(26, 0)] = Language.GetText("MapObject.DemonAltar");
    Lang._mapLegendCache[MapHelper.TileToLookup(26, 1)] = Language.GetText("MapObject.CrimsonAltar");
    Lang._mapLegendCache[MapHelper.TileToLookup(27, 0)] = itemNameCache[63 /*0x3F*/];
    Lang._mapLegendCache[MapHelper.TileToLookup(407, 0)] = Language.GetText("MapObject.Fossil");
    Lang._mapLegendCache[MapHelper.TileToLookup(412, 0)] = itemNameCache[3549];
    Lang._mapLegendCache[MapHelper.TileToLookup(441, 0)] = itemNameCache[48 /*0x30*/];
    Lang._mapLegendCache[MapHelper.TileToLookup(468, 0)] = itemNameCache[48 /*0x30*/];
    Lang._mapLegendCache[MapHelper.TileToLookup(404, 0)] = Language.GetText("MapObject.DesertFossil");
    Lang._mapLegendCache[MapHelper.TileToLookup(654, 0)] = itemNameCache[5327];
    Lang._mapLegendCache[MapHelper.TileToLookup(695, 0)] = itemNameCache[5467];
    Lang._mapLegendCache[MapHelper.TileToLookup(695, 1)] = itemNameCache[5468];
    Lang._mapLegendCache[MapHelper.TileToLookup(696, 0)] = itemNameCache[5469];
    Lang._mapLegendCache[MapHelper.TileToLookup(696, 1)] = itemNameCache[5470];
    for (int option = 0; option < 9; ++option)
    {
      Lang._mapLegendCache[MapHelper.TileToLookup(28, option)] = Language.GetText("MapObject.Pot");
      Lang._mapLegendCache[MapHelper.TileToLookup(653, option)] = Language.GetText("MapObject.Pot");
    }
    Lang._mapLegendCache[MapHelper.TileToLookup(37, 0)] = itemNameCache[116];
    Lang._mapLegendCache[MapHelper.TileToLookup(29, 0)] = itemNameCache[87];
    Lang._mapLegendCache[MapHelper.TileToLookup(31 /*0x1F*/, 0)] = itemNameCache[115];
    Lang._mapLegendCache[MapHelper.TileToLookup(31 /*0x1F*/, 1)] = itemNameCache[3062];
    Lang._mapLegendCache[MapHelper.TileToLookup(32 /*0x20*/, 0)] = Language.GetText("MapObject.Thorns");
    Lang._mapLegendCache[MapHelper.TileToLookup(33, 0)] = itemNameCache[105];
    Lang._mapLegendCache[MapHelper.TileToLookup(34, 0)] = Language.GetText("MapObject.Chandelier");
    Lang._mapLegendCache[MapHelper.TileToLookup(35, 0)] = itemNameCache[1813];
    Lang._mapLegendCache[MapHelper.TileToLookup(36, 0)] = itemNameCache[1869];
    Lang._mapLegendCache[MapHelper.TileToLookup(476, 0)] = itemNameCache[4040];
    Lang._mapLegendCache[MapHelper.TileToLookup(42, 0)] = Language.GetText("MapObject.Lantern");
    Lang._mapLegendCache[MapHelper.TileToLookup(48 /*0x30*/, 0)] = itemNameCache[147];
    Lang._mapLegendCache[MapHelper.TileToLookup(49, 0)] = itemNameCache[148];
    Lang._mapLegendCache[MapHelper.TileToLookup(50, 0)] = itemNameCache[149];
    Lang._mapLegendCache[MapHelper.TileToLookup(707, 0)] = itemNameCache[149];
    Lang._mapLegendCache[MapHelper.TileToLookup(51, 0)] = Language.GetText("MapObject.Web");
    Lang._mapLegendCache[MapHelper.TileToLookup(697, 0)] = Language.GetText("MapObject.Web");
    Lang._mapLegendCache[MapHelper.TileToLookup(55, 0)] = itemNameCache[171];
    Lang._mapLegendCache[MapHelper.TileToLookup(454, 0)] = itemNameCache[3746];
    Lang._mapLegendCache[MapHelper.TileToLookup(455, 0)] = itemNameCache[3747];
    Lang._mapLegendCache[MapHelper.TileToLookup(452, 0)] = itemNameCache[3742];
    Lang._mapLegendCache[MapHelper.TileToLookup(456, 0)] = itemNameCache[3748];
    Lang._mapLegendCache[MapHelper.TileToLookup(453, 0)] = itemNameCache[3744];
    Lang._mapLegendCache[MapHelper.TileToLookup(453, 1)] = itemNameCache[3745];
    Lang._mapLegendCache[MapHelper.TileToLookup(453, 2)] = itemNameCache[3743];
    Lang._mapLegendCache[MapHelper.TileToLookup(573, 0)] = itemNameCache[4710];
    Lang._mapLegendCache[MapHelper.TileToLookup(63 /*0x3F*/, 0)] = itemNameCache[177];
    Lang._mapLegendCache[MapHelper.TileToLookup(64 /*0x40*/, 0)] = itemNameCache[178];
    Lang._mapLegendCache[MapHelper.TileToLookup(65, 0)] = itemNameCache[179];
    Lang._mapLegendCache[MapHelper.TileToLookup(66, 0)] = itemNameCache[180];
    Lang._mapLegendCache[MapHelper.TileToLookup(67, 0)] = itemNameCache[181];
    Lang._mapLegendCache[MapHelper.TileToLookup(68, 0)] = itemNameCache[182];
    Lang._mapLegendCache[MapHelper.TileToLookup(566, 0)] = itemNameCache[999];
    Lang._mapLegendCache[MapHelper.TileToLookup(69, 0)] = Language.GetText("MapObject.Thorn");
    Lang._mapLegendCache[MapHelper.TileToLookup(72, 0)] = Language.GetText("MapObject.GiantMushroom");
    Lang._mapLegendCache[MapHelper.TileToLookup(77, 0)] = itemNameCache[221];
    Lang._mapLegendCache[MapHelper.TileToLookup(78, 0)] = itemNameCache[222];
    Lang._mapLegendCache[MapHelper.TileToLookup(79, 0)] = itemNameCache[224 /*0xE0*/];
    Lang._mapLegendCache[MapHelper.TileToLookup(80 /*0x50*/, 0)] = itemNameCache[276];
    Lang._mapLegendCache[MapHelper.TileToLookup(81, 0)] = itemNameCache[275];
    Lang._mapLegendCache[MapHelper.TileToLookup(82, 0)] = itemNameCache[313];
    Lang._mapLegendCache[MapHelper.TileToLookup(82, 1)] = itemNameCache[314];
    Lang._mapLegendCache[MapHelper.TileToLookup(82, 2)] = itemNameCache[315];
    Lang._mapLegendCache[MapHelper.TileToLookup(82, 3)] = itemNameCache[316];
    Lang._mapLegendCache[MapHelper.TileToLookup(82, 4)] = itemNameCache[317];
    Lang._mapLegendCache[MapHelper.TileToLookup(82, 5)] = itemNameCache[318];
    Lang._mapLegendCache[MapHelper.TileToLookup(82, 6)] = itemNameCache[2358];
    Lang._mapLegendCache[MapHelper.TileToLookup(83, 0)] = itemNameCache[313];
    Lang._mapLegendCache[MapHelper.TileToLookup(83, 1)] = itemNameCache[314];
    Lang._mapLegendCache[MapHelper.TileToLookup(83, 2)] = itemNameCache[315];
    Lang._mapLegendCache[MapHelper.TileToLookup(83, 3)] = itemNameCache[316];
    Lang._mapLegendCache[MapHelper.TileToLookup(83, 4)] = itemNameCache[317];
    Lang._mapLegendCache[MapHelper.TileToLookup(83, 5)] = itemNameCache[318];
    Lang._mapLegendCache[MapHelper.TileToLookup(83, 6)] = itemNameCache[2358];
    Lang._mapLegendCache[MapHelper.TileToLookup(84, 0)] = itemNameCache[313];
    Lang._mapLegendCache[MapHelper.TileToLookup(84, 1)] = itemNameCache[314];
    Lang._mapLegendCache[MapHelper.TileToLookup(84, 2)] = itemNameCache[315];
    Lang._mapLegendCache[MapHelper.TileToLookup(84, 3)] = itemNameCache[316];
    Lang._mapLegendCache[MapHelper.TileToLookup(84, 4)] = itemNameCache[317];
    Lang._mapLegendCache[MapHelper.TileToLookup(84, 5)] = itemNameCache[318];
    Lang._mapLegendCache[MapHelper.TileToLookup(84, 6)] = itemNameCache[2358];
    Lang._mapLegendCache[MapHelper.TileToLookup(85, 0)] = itemNameCache[321];
    Lang._mapLegendCache[MapHelper.TileToLookup(86, 0)] = itemNameCache[332];
    Lang._mapLegendCache[MapHelper.TileToLookup(87, 0)] = itemNameCache[333];
    Lang._mapLegendCache[MapHelper.TileToLookup(88, 0)] = itemNameCache[334];
    Lang._mapLegendCache[MapHelper.TileToLookup(89, 0)] = itemNameCache[335];
    Lang._mapLegendCache[MapHelper.TileToLookup(89, 1)] = itemNameCache[2397];
    Lang._mapLegendCache[MapHelper.TileToLookup(89, 2)] = itemNameCache[4993];
    Lang._mapLegendCache[MapHelper.TileToLookup(90, 0)] = itemNameCache[336];
    Lang._mapLegendCache[MapHelper.TileToLookup(91, 0)] = Language.GetText("MapObject.Banner");
    Lang._mapLegendCache[MapHelper.TileToLookup(92, 0)] = itemNameCache[341];
    Lang._mapLegendCache[MapHelper.TileToLookup(93, 0)] = Language.GetText("MapObject.FloorLamp");
    Lang._mapLegendCache[MapHelper.TileToLookup(94, 0)] = itemNameCache[352];
    Lang._mapLegendCache[MapHelper.TileToLookup(95, 0)] = itemNameCache[344];
    Lang._mapLegendCache[MapHelper.TileToLookup(96 /*0x60*/, 0)] = itemNameCache[345];
    Lang._mapLegendCache[MapHelper.TileToLookup(97, 0)] = itemNameCache[346];
    Lang._mapLegendCache[MapHelper.TileToLookup(98, 0)] = itemNameCache[347];
    Lang._mapLegendCache[MapHelper.TileToLookup(100, 0)] = itemNameCache[349];
    Lang._mapLegendCache[MapHelper.TileToLookup(101, 0)] = itemNameCache[354];
    Lang._mapLegendCache[MapHelper.TileToLookup(102, 0)] = itemNameCache[355];
    Lang._mapLegendCache[MapHelper.TileToLookup(103, 0)] = itemNameCache[356];
    Lang._mapLegendCache[MapHelper.TileToLookup(104, 0)] = itemNameCache[359];
    Lang._mapLegendCache[MapHelper.TileToLookup(105, 0)] = Language.GetText("MapObject.Statue");
    Lang._mapLegendCache[MapHelper.TileToLookup(105, 2)] = Language.GetText("MapObject.Vase");
    Lang._mapLegendCache[MapHelper.TileToLookup(106, 0)] = itemNameCache[363];
    Lang._mapLegendCache[MapHelper.TileToLookup(107, 0)] = Language.GetText("MapObject.Cobalt");
    Lang._mapLegendCache[MapHelper.TileToLookup(108, 0)] = Language.GetText("MapObject.Mythril");
    Lang._mapLegendCache[MapHelper.TileToLookup(111, 0)] = Language.GetText("MapObject.Adamantite");
    Lang._mapLegendCache[MapHelper.TileToLookup(114, 0)] = itemNameCache[398];
    Lang._mapLegendCache[MapHelper.TileToLookup(125, 0)] = itemNameCache[487];
    Lang._mapLegendCache[MapHelper.TileToLookup(128 /*0x80*/, 0)] = itemNameCache[498];
    Lang._mapLegendCache[MapHelper.TileToLookup(129, 0)] = itemNameCache[502];
    Lang._mapLegendCache[MapHelper.TileToLookup(129, 1)] = itemNameCache[4988];
    Lang._mapLegendCache[MapHelper.TileToLookup(132, 0)] = itemNameCache[513];
    Lang._mapLegendCache[MapHelper.TileToLookup(411, 0)] = itemNameCache[3545];
    Lang._mapLegendCache[MapHelper.TileToLookup(133, 0)] = itemNameCache[524];
    Lang._mapLegendCache[MapHelper.TileToLookup(133, 1)] = itemNameCache[1221];
    Lang._mapLegendCache[MapHelper.TileToLookup(134, 0)] = itemNameCache[525];
    Lang._mapLegendCache[MapHelper.TileToLookup(134, 1)] = itemNameCache[1220];
    Lang._mapLegendCache[MapHelper.TileToLookup(136, 0)] = itemNameCache[538];
    Lang._mapLegendCache[MapHelper.TileToLookup(137, 0)] = Language.GetText("MapObject.Trap");
    Lang._mapLegendCache[MapHelper.TileToLookup(138, 0)] = itemNameCache[540];
    Lang._mapLegendCache[MapHelper.TileToLookup(139, 0)] = itemNameCache[576];
    Lang._mapLegendCache[MapHelper.TileToLookup(142, 0)] = itemNameCache[581];
    Lang._mapLegendCache[MapHelper.TileToLookup(143, 0)] = itemNameCache[582];
    Lang._mapLegendCache[MapHelper.TileToLookup(144 /*0x90*/, 0)] = Language.GetText("MapObject.Timer");
    Lang._mapLegendCache[MapHelper.TileToLookup(149, 0)] = Language.GetText("MapObject.ChristmasLight");
    Lang._mapLegendCache[MapHelper.TileToLookup(166, 0)] = Language.GetText("MapObject.Tin");
    Lang._mapLegendCache[MapHelper.TileToLookup(167, 0)] = Language.GetText("MapObject.Lead");
    Lang._mapLegendCache[MapHelper.TileToLookup(168, 0)] = Language.GetText("MapObject.Tungsten");
    Lang._mapLegendCache[MapHelper.TileToLookup(169, 0)] = Language.GetText("MapObject.Platinum");
    Lang._mapLegendCache[MapHelper.TileToLookup(170, 0)] = Language.GetText("MapObject.PineTree");
    Lang._mapLegendCache[MapHelper.TileToLookup(171, 0)] = itemNameCache[1873];
    Lang._mapLegendCache[MapHelper.TileToLookup(172, 0)] = Language.GetText("MapObject.Sink");
    Lang._mapLegendCache[MapHelper.TileToLookup(173, 0)] = itemNameCache[349];
    Lang._mapLegendCache[MapHelper.TileToLookup(174, 0)] = itemNameCache[713];
    Lang._mapLegendCache[MapHelper.TileToLookup(178, 0)] = itemNameCache[181];
    Lang._mapLegendCache[MapHelper.TileToLookup(178, 1)] = itemNameCache[180];
    Lang._mapLegendCache[MapHelper.TileToLookup(178, 2)] = itemNameCache[177];
    Lang._mapLegendCache[MapHelper.TileToLookup(178, 3)] = itemNameCache[179];
    Lang._mapLegendCache[MapHelper.TileToLookup(178, 4)] = itemNameCache[178];
    Lang._mapLegendCache[MapHelper.TileToLookup(178, 5)] = itemNameCache[182];
    Lang._mapLegendCache[MapHelper.TileToLookup(178, 6)] = itemNameCache[999];
    Lang._mapLegendCache[MapHelper.TileToLookup(191, 0)] = Language.GetText("MapObject.LivingWood");
    Lang._mapLegendCache[MapHelper.TileToLookup(204, 0)] = Language.GetText("MapObject.Crimtane");
    Lang._mapLegendCache[MapHelper.TileToLookup(207, 0)] = Language.GetText("MapObject.WaterFountain");
    Lang._mapLegendCache[MapHelper.TileToLookup(209, 0)] = itemNameCache[928];
    Lang._mapLegendCache[MapHelper.TileToLookup(211, 0)] = Language.GetText("MapObject.Chlorophyte");
    Lang._mapLegendCache[MapHelper.TileToLookup(212, 0)] = Language.GetText("MapObject.Turret");
    Lang._mapLegendCache[MapHelper.TileToLookup(213, 0)] = itemNameCache[965];
    Lang._mapLegendCache[MapHelper.TileToLookup(214, 0)] = itemNameCache[85];
    Lang._mapLegendCache[MapHelper.TileToLookup(215, 0)] = itemNameCache[966];
    Lang._mapLegendCache[MapHelper.TileToLookup(216, 0)] = Language.GetText("MapObject.Rocket");
    Lang._mapLegendCache[MapHelper.TileToLookup(217, 0)] = itemNameCache[995];
    Lang._mapLegendCache[MapHelper.TileToLookup(218, 0)] = itemNameCache[996];
    Lang._mapLegendCache[MapHelper.TileToLookup(219, 0)] = Language.GetText("MapObject.SiltExtractinator");
    Lang._mapLegendCache[MapHelper.TileToLookup(642, 0)] = Language.GetText("MapObject.ChlorophyteExtractinator");
    Lang._mapLegendCache[MapHelper.TileToLookup(220, 0)] = itemNameCache[998];
    Lang._mapLegendCache[MapHelper.TileToLookup(221, 0)] = Language.GetText("MapObject.Palladium");
    Lang._mapLegendCache[MapHelper.TileToLookup(222, 0)] = Language.GetText("MapObject.Orichalcum");
    Lang._mapLegendCache[MapHelper.TileToLookup(223, 0)] = Language.GetText("MapObject.Titanium");
    Lang._mapLegendCache[MapHelper.TileToLookup(227, 0)] = itemNameCache[1107];
    Lang._mapLegendCache[MapHelper.TileToLookup(227, 1)] = itemNameCache[1108];
    Lang._mapLegendCache[MapHelper.TileToLookup(227, 2)] = itemNameCache[1109];
    Lang._mapLegendCache[MapHelper.TileToLookup(227, 3)] = itemNameCache[1110];
    Lang._mapLegendCache[MapHelper.TileToLookup(227, 4)] = itemNameCache[1111];
    Lang._mapLegendCache[MapHelper.TileToLookup(227, 5)] = itemNameCache[1112];
    Lang._mapLegendCache[MapHelper.TileToLookup(227, 6)] = itemNameCache[1113];
    Lang._mapLegendCache[MapHelper.TileToLookup(227, 7)] = itemNameCache[1114];
    Lang._mapLegendCache[MapHelper.TileToLookup(227, 8)] = itemNameCache[3385];
    Lang._mapLegendCache[MapHelper.TileToLookup(227, 9)] = itemNameCache[3386];
    Lang._mapLegendCache[MapHelper.TileToLookup(227, 10)] = itemNameCache[3387];
    Lang._mapLegendCache[MapHelper.TileToLookup(227, 11)] = itemNameCache[3388];
    Lang._mapLegendCache[MapHelper.TileToLookup(228, 0)] = itemNameCache[1120];
    Lang._mapLegendCache[MapHelper.TileToLookup(231, 0)] = Language.GetText("MapObject.Larva");
    Lang._mapLegendCache[MapHelper.TileToLookup(232, 0)] = itemNameCache[1150];
    Lang._mapLegendCache[MapHelper.TileToLookup(235, 0)] = itemNameCache[1263];
    Lang._mapLegendCache[MapHelper.TileToLookup(624, 0)] = itemNameCache[5114];
    Lang._mapLegendCache[MapHelper.TileToLookup(700, 0)] = itemNameCache[5114];
    Lang._mapLegendCache[MapHelper.TileToLookup(656, 0)] = itemNameCache[5333];
    Lang._mapLegendCache[MapHelper.TileToLookup(701, 0)] = itemNameCache[5333];
    Lang._mapLegendCache[MapHelper.TileToLookup(236, 0)] = itemNameCache[1291];
    Lang._mapLegendCache[MapHelper.TileToLookup(237, 0)] = itemNameCache[1292];
    Lang._mapLegendCache[MapHelper.TileToLookup(238, 0)] = Language.GetText("MapObject.PlanterasBulb");
    Lang._mapLegendCache[MapHelper.TileToLookup(239, 0)] = Language.GetText("MapObject.MetalBar");
    Lang._mapLegendCache[MapHelper.TileToLookup(240 /*0xF0*/, 0)] = Language.GetText("MapObject.Trophy");
    Lang._mapLegendCache[MapHelper.TileToLookup(240 /*0xF0*/, 1)] = Language.GetText("MapObject.Painting");
    Lang._mapLegendCache[MapHelper.TileToLookup(240 /*0xF0*/, 2)] = Lang._npcNameCache[21];
    Lang._mapLegendCache[MapHelper.TileToLookup(240 /*0xF0*/, 3)] = Language.GetText("MapObject.ItemRack");
    Lang._mapLegendCache[MapHelper.TileToLookup(240 /*0xF0*/, 4)] = itemNameCache[2442];
    Lang._mapLegendCache[MapHelper.TileToLookup(241, 0)] = itemNameCache[1417];
    Lang._mapLegendCache[MapHelper.TileToLookup(242, 0)] = Language.GetText("MapObject.Painting");
    Lang._mapLegendCache[MapHelper.TileToLookup(242, 1)] = Language.GetText("MapObject.AnimalSkin");
    Lang._mapLegendCache[MapHelper.TileToLookup(243, 0)] = itemNameCache[1430];
    Lang._mapLegendCache[MapHelper.TileToLookup(244, 0)] = itemNameCache[1449];
    Lang._mapLegendCache[MapHelper.TileToLookup(245, 0)] = Language.GetText("MapObject.Picture");
    Lang._mapLegendCache[MapHelper.TileToLookup(246, 0)] = Language.GetText("MapObject.Picture");
    Lang._mapLegendCache[MapHelper.TileToLookup(247, 0)] = itemNameCache[1551];
    Lang._mapLegendCache[MapHelper.TileToLookup(254, 0)] = itemNameCache[1725];
    Lang._mapLegendCache[MapHelper.TileToLookup(269, 0)] = itemNameCache[1989];
    Lang._mapLegendCache[MapHelper.TileToLookup(475, 0)] = itemNameCache[3977];
    Lang._mapLegendCache[MapHelper.TileToLookup(597, 0)] = itemNameCache[4876];
    Lang._mapLegendCache[MapHelper.TileToLookup(597, 1)] = itemNameCache[4875];
    Lang._mapLegendCache[MapHelper.TileToLookup(597, 2)] = itemNameCache[4916];
    Lang._mapLegendCache[MapHelper.TileToLookup(597, 3)] = itemNameCache[4917];
    Lang._mapLegendCache[MapHelper.TileToLookup(597, 4)] = itemNameCache[4918];
    Lang._mapLegendCache[MapHelper.TileToLookup(597, 5)] = itemNameCache[4919];
    Lang._mapLegendCache[MapHelper.TileToLookup(597, 6)] = itemNameCache[4920];
    Lang._mapLegendCache[MapHelper.TileToLookup(597, 7)] = itemNameCache[4921];
    Lang._mapLegendCache[MapHelper.TileToLookup(597, 8)] = itemNameCache[4951];
    Lang._mapLegendCache[MapHelper.TileToLookup(597, 9)] = itemNameCache[5652];
    Lang._mapLegendCache[MapHelper.TileToLookup(597, 10)] = itemNameCache[5653];
    Lang._mapLegendCache[MapHelper.TileToLookup(617, 0)] = Language.GetText("MapObject.Relic");
    Lang._mapLegendCache[MapHelper.TileToLookup(621, 0)] = itemNameCache[3750];
    Lang._mapLegendCache[MapHelper.TileToLookup(622, 0)] = itemNameCache[5008];
    Lang._mapLegendCache[MapHelper.TileToLookup(270, 0)] = itemNameCache[1993];
    Lang._mapLegendCache[MapHelper.TileToLookup(271, 0)] = itemNameCache[2005];
    Lang._mapLegendCache[MapHelper.TileToLookup(581, 0)] = itemNameCache[4848];
    Lang._mapLegendCache[MapHelper.TileToLookup(660, 0)] = itemNameCache[5351];
    Lang._mapLegendCache[MapHelper.TileToLookup(275, 0)] = itemNameCache[2162];
    Lang._mapLegendCache[MapHelper.TileToLookup(276, 0)] = itemNameCache[2163];
    Lang._mapLegendCache[MapHelper.TileToLookup(277, 0)] = itemNameCache[2164];
    Lang._mapLegendCache[MapHelper.TileToLookup(278, 0)] = itemNameCache[2165];
    Lang._mapLegendCache[MapHelper.TileToLookup(279, 0)] = itemNameCache[2166];
    Lang._mapLegendCache[MapHelper.TileToLookup(280, 0)] = itemNameCache[2167];
    Lang._mapLegendCache[MapHelper.TileToLookup(281, 0)] = itemNameCache[2168];
    Lang._mapLegendCache[MapHelper.TileToLookup(632, 0)] = itemNameCache[5213];
    Lang._mapLegendCache[MapHelper.TileToLookup(640, 0)] = itemNameCache[5301];
    Lang._mapLegendCache[MapHelper.TileToLookup(643, 0)] = itemNameCache[5314];
    Lang._mapLegendCache[MapHelper.TileToLookup(644, 0)] = itemNameCache[5315];
    Lang._mapLegendCache[MapHelper.TileToLookup(645, 0)] = itemNameCache[5316];
    Lang._mapLegendCache[MapHelper.TileToLookup(282, 0)] = itemNameCache[250];
    Lang._mapLegendCache[MapHelper.TileToLookup(543, 0)] = itemNameCache[4398];
    Lang._mapLegendCache[MapHelper.TileToLookup(598, 0)] = itemNameCache[4880];
    Lang._mapLegendCache[MapHelper.TileToLookup(413, 0)] = itemNameCache[3565];
    Lang._mapLegendCache[MapHelper.TileToLookup(710, 0)] = itemNameCache[5512];
    Lang._mapLegendCache[MapHelper.TileToLookup(283, 0)] = itemNameCache[2172];
    Lang._mapLegendCache[MapHelper.TileToLookup(285, 0)] = itemNameCache[2174];
    Lang._mapLegendCache[MapHelper.TileToLookup(286, 0)] = itemNameCache[2175];
    Lang._mapLegendCache[MapHelper.TileToLookup(582, 0)] = itemNameCache[4850];
    Lang._mapLegendCache[MapHelper.TileToLookup(287, 0)] = itemNameCache[2177];
    Lang._mapLegendCache[MapHelper.TileToLookup(288, 0)] = itemNameCache[2178];
    Lang._mapLegendCache[MapHelper.TileToLookup(289, 0)] = itemNameCache[2179];
    Lang._mapLegendCache[MapHelper.TileToLookup(290, 0)] = itemNameCache[2180];
    Lang._mapLegendCache[MapHelper.TileToLookup(291, 0)] = itemNameCache[2181];
    Lang._mapLegendCache[MapHelper.TileToLookup(292, 0)] = itemNameCache[2182];
    Lang._mapLegendCache[MapHelper.TileToLookup(293, 0)] = itemNameCache[2183];
    Lang._mapLegendCache[MapHelper.TileToLookup(294, 0)] = itemNameCache[2184];
    Lang._mapLegendCache[MapHelper.TileToLookup(295, 0)] = itemNameCache[2185];
    Lang._mapLegendCache[MapHelper.TileToLookup(580, 0)] = itemNameCache[4846];
    Lang._mapLegendCache[MapHelper.TileToLookup(620, 0)] = itemNameCache[4964];
    Lang._mapLegendCache[MapHelper.TileToLookup(619, 0)] = itemNameCache[4963];
    Lang._mapLegendCache[MapHelper.TileToLookup(296, 0)] = itemNameCache[2186];
    Lang._mapLegendCache[MapHelper.TileToLookup(297, 0)] = itemNameCache[2187];
    Lang._mapLegendCache[MapHelper.TileToLookup(298, 0)] = itemNameCache[2190];
    Lang._mapLegendCache[MapHelper.TileToLookup(299, 0)] = itemNameCache[2191];
    Lang._mapLegendCache[MapHelper.TileToLookup(300, 0)] = itemNameCache[2192];
    Lang._mapLegendCache[MapHelper.TileToLookup(301, 0)] = itemNameCache[2193];
    Lang._mapLegendCache[MapHelper.TileToLookup(302, 0)] = itemNameCache[2194];
    Lang._mapLegendCache[MapHelper.TileToLookup(303, 0)] = itemNameCache[2195];
    Lang._mapLegendCache[MapHelper.TileToLookup(304, 0)] = itemNameCache[2196];
    Lang._mapLegendCache[MapHelper.TileToLookup(305, 0)] = itemNameCache[2197];
    Lang._mapLegendCache[MapHelper.TileToLookup(306, 0)] = itemNameCache[2198];
    Lang._mapLegendCache[MapHelper.TileToLookup(307, 0)] = itemNameCache[2203];
    Lang._mapLegendCache[MapHelper.TileToLookup(308, 0)] = itemNameCache[2204];
    Lang._mapLegendCache[MapHelper.TileToLookup(309, 0)] = itemNameCache[2206];
    Lang._mapLegendCache[MapHelper.TileToLookup(310, 0)] = itemNameCache[2207];
    Lang._mapLegendCache[MapHelper.TileToLookup(391, 0)] = itemNameCache[3254];
    Lang._mapLegendCache[MapHelper.TileToLookup(316, 0)] = itemNameCache[2439];
    Lang._mapLegendCache[MapHelper.TileToLookup(317, 0)] = itemNameCache[2440];
    Lang._mapLegendCache[MapHelper.TileToLookup(318, 0)] = itemNameCache[2441];
    Lang._mapLegendCache[MapHelper.TileToLookup(319, 0)] = itemNameCache[2490];
    Lang._mapLegendCache[MapHelper.TileToLookup(320, 0)] = itemNameCache[2496];
    Lang._mapLegendCache[MapHelper.TileToLookup(323, 0)] = Language.GetText("MapObject.PalmTree");
    Lang._mapLegendCache[MapHelper.TileToLookup(314, 0)] = itemNameCache[2340];
    Lang._mapLegendCache[MapHelper.TileToLookup(353, 0)] = itemNameCache[2996];
    Lang._mapLegendCache[MapHelper.TileToLookup(354, 0)] = itemNameCache[2999];
    Lang._mapLegendCache[MapHelper.TileToLookup(355, 0)] = itemNameCache[3000];
    Lang._mapLegendCache[MapHelper.TileToLookup(464, 0)] = itemNameCache[3814];
    Lang._mapLegendCache[MapHelper.TileToLookup(699, 0)] = itemNameCache[5482];
    Lang._mapLegendCache[MapHelper.TileToLookup(356, 0)] = itemNameCache[3064];
    Lang._mapLegendCache[MapHelper.TileToLookup(663, 0)] = itemNameCache[5381];
    Lang._mapLegendCache[MapHelper.TileToLookup(567, 0)] = itemNameCache[4609];
    Lang._mapLegendCache[MapHelper.TileToLookup(358, 0)] = itemNameCache[3070];
    Lang._mapLegendCache[MapHelper.TileToLookup(359, 0)] = itemNameCache[3071 /*0x0BFF*/];
    Lang._mapLegendCache[MapHelper.TileToLookup(360, 0)] = itemNameCache[3072 /*0x0C00*/];
    Lang._mapLegendCache[MapHelper.TileToLookup(361, 0)] = itemNameCache[3073];
    Lang._mapLegendCache[MapHelper.TileToLookup(362, 0)] = itemNameCache[3074];
    Lang._mapLegendCache[MapHelper.TileToLookup(363, 0)] = itemNameCache[3075];
    Lang._mapLegendCache[MapHelper.TileToLookup(364, 0)] = itemNameCache[3076];
    Lang._mapLegendCache[MapHelper.TileToLookup(414, 0)] = itemNameCache[3566];
    Lang._mapLegendCache[MapHelper.TileToLookup(521, 0)] = itemNameCache[4327];
    Lang._mapLegendCache[MapHelper.TileToLookup(522, 0)] = itemNameCache[4328];
    Lang._mapLegendCache[MapHelper.TileToLookup(523, 0)] = itemNameCache[4329];
    Lang._mapLegendCache[MapHelper.TileToLookup(524, 0)] = itemNameCache[4330];
    Lang._mapLegendCache[MapHelper.TileToLookup(525, 0)] = itemNameCache[4331];
    Lang._mapLegendCache[MapHelper.TileToLookup(526, 0)] = itemNameCache[4332];
    Lang._mapLegendCache[MapHelper.TileToLookup(527, 0)] = itemNameCache[4333];
    Lang._mapLegendCache[MapHelper.TileToLookup(542, 0)] = itemNameCache[4396];
    Lang._mapLegendCache[MapHelper.TileToLookup(365, 0)] = itemNameCache[3077];
    Lang._mapLegendCache[MapHelper.TileToLookup(366, 0)] = itemNameCache[3078];
    Lang._mapLegendCache[MapHelper.TileToLookup(373, 0)] = Language.GetText("MapObject.DrippingWater");
    Lang._mapLegendCache[MapHelper.TileToLookup(374, 0)] = Language.GetText("MapObject.DrippingLava");
    Lang._mapLegendCache[MapHelper.TileToLookup(375, 0)] = Language.GetText("MapObject.DrippingHoney");
    Lang._mapLegendCache[MapHelper.TileToLookup(709, 0)] = Language.GetText("MapObject.DrippingShimmer");
    Lang._mapLegendCache[MapHelper.TileToLookup(461, 0)] = Language.GetText("MapObject.SandFlow");
    Lang._mapLegendCache[MapHelper.TileToLookup(461, 1)] = Language.GetText("MapObject.SandFlow");
    Lang._mapLegendCache[MapHelper.TileToLookup(461, 2)] = Language.GetText("MapObject.SandFlow");
    Lang._mapLegendCache[MapHelper.TileToLookup(461, 3)] = Language.GetText("MapObject.SandFlow");
    Lang._mapLegendCache[MapHelper.TileToLookup(377, 0)] = itemNameCache[3198];
    Lang._mapLegendCache[MapHelper.TileToLookup(372, 0)] = itemNameCache[3117];
    Lang._mapLegendCache[MapHelper.TileToLookup(646, 0)] = itemNameCache[5322];
    Lang._mapLegendCache[MapHelper.TileToLookup(425, 0)] = itemNameCache[3617];
    Lang._mapLegendCache[MapHelper.TileToLookup(420, 0)] = itemNameCache[3603];
    Lang._mapLegendCache[MapHelper.TileToLookup(420, 1)] = itemNameCache[3604];
    Lang._mapLegendCache[MapHelper.TileToLookup(420, 2)] = itemNameCache[3605];
    Lang._mapLegendCache[MapHelper.TileToLookup(420, 3)] = itemNameCache[3606];
    Lang._mapLegendCache[MapHelper.TileToLookup(420, 4)] = itemNameCache[3607];
    Lang._mapLegendCache[MapHelper.TileToLookup(420, 5)] = itemNameCache[3608];
    Lang._mapLegendCache[MapHelper.TileToLookup(423, 0)] = itemNameCache[3613];
    Lang._mapLegendCache[MapHelper.TileToLookup(423, 1)] = itemNameCache[3614];
    Lang._mapLegendCache[MapHelper.TileToLookup(423, 2)] = itemNameCache[3615];
    Lang._mapLegendCache[MapHelper.TileToLookup(423, 3)] = itemNameCache[3726];
    Lang._mapLegendCache[MapHelper.TileToLookup(423, 4)] = itemNameCache[3727];
    Lang._mapLegendCache[MapHelper.TileToLookup(423, 5)] = itemNameCache[3728];
    Lang._mapLegendCache[MapHelper.TileToLookup(423, 6)] = itemNameCache[3729];
    Lang._mapLegendCache[MapHelper.TileToLookup(440, 0)] = itemNameCache[3644];
    Lang._mapLegendCache[MapHelper.TileToLookup(440, 1)] = itemNameCache[3645];
    Lang._mapLegendCache[MapHelper.TileToLookup(440, 2)] = itemNameCache[3646];
    Lang._mapLegendCache[MapHelper.TileToLookup(440, 3)] = itemNameCache[3647];
    Lang._mapLegendCache[MapHelper.TileToLookup(440, 4)] = itemNameCache[3648];
    Lang._mapLegendCache[MapHelper.TileToLookup(440, 5)] = itemNameCache[3649];
    Lang._mapLegendCache[MapHelper.TileToLookup(440, 6)] = itemNameCache[3650];
    Lang._mapLegendCache[MapHelper.TileToLookup(443, 0)] = itemNameCache[3722];
    Lang._mapLegendCache[MapHelper.TileToLookup(429, 0)] = itemNameCache[3629];
    Lang._mapLegendCache[MapHelper.TileToLookup(424, 0)] = itemNameCache[3616];
    Lang._mapLegendCache[MapHelper.TileToLookup(444, 0)] = Language.GetText("MapObject.BeeHive");
    Lang._mapLegendCache[MapHelper.TileToLookup(466, 0)] = itemNameCache[3816];
    Lang._mapLegendCache[MapHelper.TileToLookup(463, 0)] = itemNameCache[3813];
    Lang._mapLegendCache[MapHelper.TileToLookup(491, 0)] = itemNameCache[4076];
    Lang._mapLegendCache[MapHelper.TileToLookup(494, 0)] = itemNameCache[4089];
    Lang._mapLegendCache[MapHelper.TileToLookup(499, 0)] = itemNameCache[4142];
    Lang._mapLegendCache[MapHelper.TileToLookup(488, 0)] = Language.GetText("MapObject.FallenLog");
    Lang._mapLegendCache[MapHelper.TileToLookup(704, 0)] = Language.GetText("MapObject.FallenLog");
    Lang._mapLegendCache[MapHelper.TileToLookup(505, 0)] = itemNameCache[4275];
    Lang._mapLegendCache[MapHelper.TileToLookup(521, 0)] = itemNameCache[4327];
    Lang._mapLegendCache[MapHelper.TileToLookup(522, 0)] = itemNameCache[4328];
    Lang._mapLegendCache[MapHelper.TileToLookup(523, 0)] = itemNameCache[4329];
    Lang._mapLegendCache[MapHelper.TileToLookup(524, 0)] = itemNameCache[4330];
    Lang._mapLegendCache[MapHelper.TileToLookup(525, 0)] = itemNameCache[4331];
    Lang._mapLegendCache[MapHelper.TileToLookup(526, 0)] = itemNameCache[4332];
    Lang._mapLegendCache[MapHelper.TileToLookup(527, 0)] = itemNameCache[4333];
    Lang._mapLegendCache[MapHelper.TileToLookup(531, 0)] = Language.GetText("MapObject.Statue");
    Lang._mapLegendCache[MapHelper.TileToLookup(349, 0)] = Language.GetText("MapObject.Statue");
    Lang._mapLegendCache[MapHelper.TileToLookup(532, 0)] = itemNameCache[4364];
    Lang._mapLegendCache[MapHelper.TileToLookup(538, 0)] = itemNameCache[4380];
    Lang._mapLegendCache[MapHelper.TileToLookup(544, 0)] = itemNameCache[4399];
    Lang._mapLegendCache[MapHelper.TileToLookup(629, 0)] = itemNameCache[5133];
    Lang._mapLegendCache[MapHelper.TileToLookup(506, 0)] = itemNameCache[4276];
    Lang._mapLegendCache[MapHelper.TileToLookup(545, 0)] = itemNameCache[4420];
    Lang._mapLegendCache[MapHelper.TileToLookup(550, 0)] = itemNameCache[4461];
    Lang._mapLegendCache[MapHelper.TileToLookup(551, 0)] = itemNameCache[4462];
    Lang._mapLegendCache[MapHelper.TileToLookup(533, 0)] = itemNameCache[4376];
    Lang._mapLegendCache[MapHelper.TileToLookup(553, 0)] = itemNameCache[4473];
    Lang._mapLegendCache[MapHelper.TileToLookup(554, 0)] = itemNameCache[4474];
    Lang._mapLegendCache[MapHelper.TileToLookup(555, 0)] = itemNameCache[4475];
    Lang._mapLegendCache[MapHelper.TileToLookup(556, 0)] = itemNameCache[4476];
    Lang._mapLegendCache[MapHelper.TileToLookup(558, 0)] = itemNameCache[4481];
    Lang._mapLegendCache[MapHelper.TileToLookup(559, 0)] = itemNameCache[4483];
    Lang._mapLegendCache[MapHelper.TileToLookup(599, 0)] = itemNameCache[4882];
    Lang._mapLegendCache[MapHelper.TileToLookup(600, 0)] = itemNameCache[4883];
    Lang._mapLegendCache[MapHelper.TileToLookup(601, 0)] = itemNameCache[4884];
    Lang._mapLegendCache[MapHelper.TileToLookup(602, 0)] = itemNameCache[4885];
    Lang._mapLegendCache[MapHelper.TileToLookup(603, 0)] = itemNameCache[4886];
    Lang._mapLegendCache[MapHelper.TileToLookup(604, 0)] = itemNameCache[4887];
    Lang._mapLegendCache[MapHelper.TileToLookup(605, 0)] = itemNameCache[4888];
    Lang._mapLegendCache[MapHelper.TileToLookup(606, 0)] = itemNameCache[4889];
    Lang._mapLegendCache[MapHelper.TileToLookup(607, 0)] = itemNameCache[4890];
    Lang._mapLegendCache[MapHelper.TileToLookup(608, 0)] = itemNameCache[4891];
    Lang._mapLegendCache[MapHelper.TileToLookup(609, 0)] = itemNameCache[4892];
    Lang._mapLegendCache[MapHelper.TileToLookup(610, 0)] = itemNameCache[4893];
    Lang._mapLegendCache[MapHelper.TileToLookup(611, 0)] = itemNameCache[4894];
    Lang._mapLegendCache[MapHelper.TileToLookup(612, 0)] = itemNameCache[4895];
    Lang._mapLegendCache[MapHelper.TileToLookup(560, 0)] = itemNameCache[4599];
    Lang._mapLegendCache[MapHelper.TileToLookup(560, 1)] = itemNameCache[4600];
    Lang._mapLegendCache[MapHelper.TileToLookup(560, 2)] = itemNameCache[4601];
    Lang._mapLegendCache[MapHelper.TileToLookup(568, 0)] = itemNameCache[4655];
    Lang._mapLegendCache[MapHelper.TileToLookup(569, 0)] = itemNameCache[4656];
    Lang._mapLegendCache[MapHelper.TileToLookup(570, 0)] = itemNameCache[4657];
    Lang._mapLegendCache[MapHelper.TileToLookup(572, 0)] = itemNameCache[4695];
    Lang._mapLegendCache[MapHelper.TileToLookup(572, 1)] = itemNameCache[4696];
    Lang._mapLegendCache[MapHelper.TileToLookup(572, 2)] = itemNameCache[4697];
    Lang._mapLegendCache[MapHelper.TileToLookup(572, 3)] = itemNameCache[4698];
    Lang._mapLegendCache[MapHelper.TileToLookup(572, 4)] = itemNameCache[4699];
    Lang._mapLegendCache[MapHelper.TileToLookup(572, 5)] = itemNameCache[4700];
    Lang._mapLegendCache[MapHelper.TileToLookup(497, 0)] = Language.GetText("MapObject.Toilet");
    Lang._mapLegendCache[MapHelper.TileToLookup(751, 0)] = itemNameCache[5667];
    Lang._mapLegendCache[MapHelper.TileToLookup(752, 0)] = itemNameCache[6142];
  }

  public static NetworkText CreateDeathMessage(
    string deadPlayerName,
    int plr = -1,
    int npc = -1,
    int proj = -1,
    int other = -1,
    int projType = 0,
    int plrItemType = 0)
  {
    NetworkText networkText1 = NetworkText.Empty;
    NetworkText networkText2 = NetworkText.Empty;
    NetworkText networkText3 = NetworkText.Empty;
    NetworkText networkText4 = NetworkText.Empty;
    if (proj >= 0)
      networkText1 = NetworkText.FromKey(Lang.GetProjectileName(projType).Key);
    if (npc >= 0)
      networkText2 = Main.npc[npc].GetGivenOrTypeNetName();
    if (plr >= 0 && plr < (int) byte.MaxValue)
      networkText3 = NetworkText.FromLiteral(Main.player[plr].name);
    if (plrItemType >= 0)
      networkText4 = NetworkText.FromKey(Lang.GetItemName(plrItemType).Key);
    bool flag1 = networkText1 != NetworkText.Empty;
    bool flag2 = plr >= 0 && plr < (int) byte.MaxValue;
    bool flag3 = networkText2 != NetworkText.Empty;
    NetworkText deathMessage = NetworkText.Empty;
    NetworkText empty = NetworkText.Empty;
    NetworkText networkText5 = NetworkText.FromKey(Language.RandomFromCategory("DeathTextGeneric").Key, (object) deadPlayerName, (object) Main.worldName);
    if (flag2)
      deathMessage = NetworkText.FromKey("DeathSource.Player", (object) networkText5, (object) networkText3, flag1 ? (object) networkText1 : (object) networkText4);
    else if (flag3)
      deathMessage = NetworkText.FromKey("DeathSource.NPC", (object) networkText5, (object) networkText2);
    else if (flag1)
    {
      deathMessage = NetworkText.FromKey("DeathSource.Projectile", (object) networkText5, (object) networkText1);
    }
    else
    {
      switch (other)
      {
        case 0:
          deathMessage = NetworkText.FromKey("DeathText.Fell_" + (object) (Main.rand.Next(9) + 1), (object) deadPlayerName);
          break;
        case 1:
          deathMessage = NetworkText.FromKey("DeathText.Drowned_" + (object) (Main.rand.Next(7) + 1), (object) deadPlayerName);
          break;
        case 2:
          deathMessage = NetworkText.FromKey("DeathText.Lava_" + (object) (Main.rand.Next(5) + 1), (object) deadPlayerName);
          break;
        case 3:
          deathMessage = NetworkText.FromKey("DeathText.Default", (object) networkText5);
          break;
        case 4:
          deathMessage = NetworkText.FromKey("DeathText.Slain", (object) deadPlayerName);
          break;
        case 5:
          deathMessage = NetworkText.FromKey("DeathText.Petrified_" + (object) (Main.rand.Next(4) + 1), (object) deadPlayerName);
          break;
        case 6:
          deathMessage = NetworkText.FromKey("DeathText.Stabbed", (object) deadPlayerName);
          break;
        case 7:
          deathMessage = NetworkText.FromKey("DeathText.Suffocated_" + (object) (Main.rand.Next(2) + 1), (object) deadPlayerName);
          break;
        case 8:
          deathMessage = NetworkText.FromKey("DeathText.Burned_" + (object) (Main.rand.Next(4) + 1), (object) deadPlayerName);
          break;
        case 9:
          deathMessage = NetworkText.FromKey("DeathText.Poisoned", (object) deadPlayerName);
          break;
        case 10:
          deathMessage = NetworkText.FromKey("DeathText.Electrocuted_" + (object) (Main.rand.Next(4) + 1), (object) deadPlayerName);
          break;
        case 11:
          deathMessage = NetworkText.FromKey("DeathText.TriedToEscape", (object) deadPlayerName);
          break;
        case 12:
          deathMessage = NetworkText.FromKey("DeathText.WasLicked_" + (object) (Main.rand.Next(2) + 1), (object) deadPlayerName);
          break;
        case 13:
          deathMessage = NetworkText.FromKey("DeathText.Teleport_1", (object) deadPlayerName);
          break;
        case 14:
          deathMessage = NetworkText.FromKey("DeathText.Teleport_2_Male", (object) deadPlayerName);
          break;
        case 15:
          deathMessage = NetworkText.FromKey("DeathText.Teleport_2_Female", (object) deadPlayerName);
          break;
        case 16 /*0x10*/:
          deathMessage = NetworkText.FromKey("DeathText.Inferno", (object) deadPlayerName);
          break;
        case 17:
          deathMessage = NetworkText.FromKey("DeathText.DiedInTheDark", (object) deadPlayerName);
          break;
        case 18:
          deathMessage = NetworkText.FromKey("DeathText.Starved_" + (object) (Main.rand.Next(3) + 1), (object) deadPlayerName);
          break;
        case 19:
          deathMessage = NetworkText.FromKey("DeathText.Space_" + (object) (Main.rand.Next(5) + 1), (object) deadPlayerName, (object) Main.worldName);
          break;
        case 20:
          deathMessage = NetworkText.FromKey("DeathText.TeamTank", (object) deadPlayerName);
          break;
        case 21:
          deathMessage = NetworkText.FromKey("DeathText.Underground_" + (object) (Main.rand.Next(5) + 1), (object) deadPlayerName, (object) Main.worldName);
          break;
        case 22:
          deathMessage = NetworkText.FromKey("DeathText.VampireBurningInDaylight_" + (object) (Main.rand.Next(6) + 1), (object) deadPlayerName, (object) Main.worldName);
          break;
        case (int) byte.MaxValue:
          deathMessage = NetworkText.FromKey("DeathText.Slain", (object) deadPlayerName);
          break;
      }
    }
    return deathMessage;
  }

  public static NetworkText GetInvasionWaveText(int wave, params short[] npcIds)
  {
    NetworkText[] networkTextArray = new NetworkText[npcIds.Length + 1];
    for (int index = 0; index < npcIds.Length; ++index)
      networkTextArray[index + 1] = NetworkText.FromKey(Lang.GetNPCName((int) npcIds[index]).Key);
    switch (wave)
    {
      case -1:
        networkTextArray[0] = NetworkText.FromKey("Game.FinalWave");
        break;
      case 1:
        networkTextArray[0] = NetworkText.FromKey("Game.FirstWave");
        break;
      default:
        networkTextArray[0] = NetworkText.FromKey("Game.Wave", (object) wave);
        break;
    }
    return NetworkText.FromKey("Game.InvasionWave_Type" + (object) npcIds.Length, (object[]) networkTextArray);
  }

  public static string LocalizedDuration(
    TimeSpan time,
    bool abbreviated,
    bool showAllAvailableUnits)
  {
    string str1 = "";
    abbreviated |= !GameCulture.FromCultureName(GameCulture.CultureName.English).IsActive;
    if (time.Days > 0)
    {
      int days = time.Days;
      if (!showAllAvailableUnits && time > TimeSpan.FromDays(1.0))
        ++days;
      string str2 = str1 + (object) days + (abbreviated ? (object) (" " + Language.GetTextValue("Misc.ShortDays")) : (days == 1 ? (object) " day" : (object) " days"));
      if (!showAllAvailableUnits)
        return str2;
      str1 = str2 + " ";
    }
    if (time.Hours > 0)
    {
      int hours = time.Hours;
      if (!showAllAvailableUnits && time > TimeSpan.FromHours(1.0))
        ++hours;
      string str3 = str1 + (object) hours + (abbreviated ? (object) (" " + Language.GetTextValue("Misc.ShortHours")) : (hours == 1 ? (object) " hour" : (object) " hours"));
      if (!showAllAvailableUnits)
        return str3;
      str1 = str3 + " ";
    }
    if (time.Minutes > 0)
    {
      int minutes = time.Minutes;
      if (!showAllAvailableUnits && time > TimeSpan.FromMinutes(1.0))
        ++minutes;
      string str4 = str1 + (object) minutes + (abbreviated ? (object) (" " + Language.GetTextValue("Misc.ShortMinutes")) : (minutes == 1 ? (object) " minute" : (object) " minutes"));
      if (!showAllAvailableUnits)
        return str4;
      str1 = str4 + " ";
    }
    return str1 + (object) time.Seconds + (abbreviated ? (object) (" " + Language.GetTextValue("Misc.ShortSeconds")) : (time.Seconds == 1 ? (object) " second" : (object) " seconds"));
  }

  private class ItemPrefixCombiner
  {
    public string ItemName { get; set; }

    public string PrefixName { get; set; }
  }
}
