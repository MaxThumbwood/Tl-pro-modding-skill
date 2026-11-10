// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.CraftingRequests
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria.DataStructures;
using Terraria.Net;

#nullable disable
namespace Terraria.GameContent;

public static class CraftingRequests
{
  private static Queue<CraftingRequests.RemoteCraftRequest> _pendingCrafts = new Queue<CraftingRequests.RemoteCraftRequest>();

  public static bool HasPendingRequests => CraftingRequests._pendingCrafts.Count > 0;

  public static void Clear() => CraftingRequests._pendingCrafts.Clear();

  public static void CraftItem(Recipe recipe, int qty = 1, bool quickCraft = false)
  {
    Player localPlayer = Main.LocalPlayer;
    List<Chest> chests = Recipe._recipeChests;
    List<Recipe.RequiredItemEntry> requiredItemEntryList = new List<Recipe.RequiredItemEntry>();
    for (int index = 0; index < qty && (index <= 0 || Recipe.CollectedEnoughItemsToCraft(recipe) && Main.CursorHasSpaceToCraftRecipe(recipe)); ++index)
    {
      requiredItemEntryList.Clear();
      recipe.GetIngredientsForOneCraft(localPlayer, requiredItemEntryList);
      if (Main.netMode == 0 || requiredItemEntryList.All<Recipe.RequiredItemEntry>((Func<Recipe.RequiredItemEntry, bool>) (req => CraftingRequests.CanCraftLocally(req, chests))))
        CraftingRequests.CraftLocally(recipe, quickCraft, chests, requiredItemEntryList);
      else
        CraftingRequests.CraftViaRequest(recipe, quickCraft, chests, requiredItemEntryList);
      foreach (Recipe.RequiredItemEntry req in requiredItemEntryList)
        Recipe.SubtractOwnedItem(req);
    }
    CraftingEffects.OnCraft(recipe, quickCraft);
  }

  private static Item CreateResult(Recipe recipe)
  {
    Item result = recipe.createItem.Clone();
    result.OnCreated((ItemCreationContext) new RecipeItemCreationContext(recipe));
    if (result.stack <= 1)
      result.Prefix(-1);
    return result;
  }

  private static void CraftLocally(
    Recipe recipe,
    bool quickCraft,
    List<Chest> chests,
    List<Recipe.RequiredItemEntry> ingredients)
  {
    foreach (Recipe.RequiredItemEntry ingredient in ingredients)
      CraftingRequests.Consume(ingredient, chests, (List<Item>) null, true);
    Main.CraftItem_GrantItem(recipe, CraftingRequests.CreateResult(recipe), quickCraft);
  }

  private static void CraftViaRequest(
    Recipe recipe,
    bool quickCraft,
    List<Chest> chests,
    List<Recipe.RequiredItemEntry> ingredients)
  {
    List<Item> consumedItems = new List<Item>();
    List<Recipe.RequiredItemEntry> items = new List<Recipe.RequiredItemEntry>();
    foreach (Recipe.RequiredItemEntry ingredient in ingredients)
    {
      int num = CraftingRequests.Consume(ingredient, chests, consumedItems, false);
      if (num > 0)
        items.Add(new Recipe.RequiredItemEntry()
        {
          itemIdOrRecipeGroup = ingredient.itemIdOrRecipeGroup,
          stack = num
        });
    }
    Item result = CraftingRequests.CreateResult(recipe);
    if (!quickCraft)
      FakeCursorItem.Add(result);
    CraftingRequests._pendingCrafts.Enqueue(new CraftingRequests.RemoteCraftRequest()
    {
      recipe = recipe,
      result = result,
      consumed = consumedItems,
      requested = items,
      quickCraft = quickCraft
    });
    NetManager.Instance.SendToServer(CraftingRequests.NetCraftingRequestsModule.WriteRequest(items, chests));
  }

  private static bool IsLocallyAccessible(Chest chest)
  {
    return chest.bankChest || chest.index == Main.LocalPlayer.chest;
  }

  private static bool CanCraftLocally(Recipe.RequiredItemEntry req, List<Chest> chests)
  {
    int num = 0 + CraftingRequests.CountMatches(req, Main.LocalPlayer.inventory, 58);
    foreach (Chest chest in chests)
    {
      if (CraftingRequests.IsLocallyAccessible(chest))
        num += CraftingRequests.CountMatches(req, chest.item, chest.maxItems);
    }
    return num >= req.stack;
  }

  private static int CountMatches(Recipe.RequiredItemEntry req, List<Chest> chests)
  {
    int num = 0;
    foreach (Chest chest in chests)
      num += CraftingRequests.CountMatches(req, chest.item, chest.maxItems);
    return num;
  }

  private static int CountMatches(Recipe.RequiredItemEntry req, Item[] inv, int maxItems)
  {
    int num = 0;
    for (int index = 0; index < maxItems; ++index)
    {
      Item obj = inv[index];
      if (req.Matches(obj.type))
        num += obj.stack;
    }
    return num;
  }

  private static int Consume(
    Recipe.RequiredItemEntry req,
    List<Chest> chests,
    List<Item> consumedItems,
    bool fromChests)
  {
    int stack = req.stack;
    if (Main.netMode != 2)
      CraftingRequests.ConsumeItemsFrom(Main.LocalPlayer.inventory, 58, req, ref stack, consumedItems);
    foreach (Chest chest in chests)
    {
      if (chest.bankChest | fromChests)
        CraftingRequests.ConsumeItemsFrom(chest, req, ref stack, consumedItems);
    }
    return stack;
  }

  private static void ConsumeItemsFrom(
    Chest chest,
    Recipe.RequiredItemEntry req,
    ref int toConsume,
    List<Item> consumedItems = null)
  {
    CraftingRequests.ConsumeItemsFrom(chest.item, chest.maxItems, req, ref toConsume, consumedItems, chest.bankChest ? -1 : chest.index);
  }

  private static void ConsumeItemsFrom(
    Item[] inventory,
    int maxItems,
    Recipe.RequiredItemEntry req,
    ref int toConsume,
    List<Item> consumedItems = null,
    int chestIndex = -1)
  {
    if (toConsume <= 0)
      return;
    int netMode1 = Main.netMode;
    int netMode2 = Main.netMode;
    for (int number2 = 0; number2 < maxItems; ++number2)
    {
      Item obj1 = inventory[number2];
      if (req.Matches(obj1.type))
      {
        if (obj1.stack > toConsume)
        {
          if (consumedItems != null)
          {
            Item obj2 = obj1.Clone();
            obj2.stack = toConsume;
            consumedItems.Add(obj2);
          }
          obj1.stack -= toConsume;
          toConsume = 0;
        }
        else
        {
          toConsume -= obj1.stack;
          consumedItems?.Add(obj1);
          inventory[number2] = new Item();
        }
        if (chestIndex >= 0)
          NetMessage.SendData(32 /*0x20*/, number: chestIndex, number2: (float) number2);
        if (toConsume <= 0)
          break;
      }
    }
  }

  public static bool CanCraftFromChest(Chest chest, int whoAmI)
  {
    if (Chest.IsLocked(chest.x, chest.y))
      return false;
    int num = Chest.UsingChest(chest.index);
    return num < 0 || num == whoAmI;
  }

  private static void HandleRequest(
    int whoAmI,
    List<Recipe.RequiredItemEntry> items,
    List<Chest> chests)
  {
    chests.RemoveAll((Predicate<Chest>) (chest => chest == null || !CraftingRequests.CanCraftFromChest(chest, whoAmI)));
    if (!items.All<Recipe.RequiredItemEntry>((Func<Recipe.RequiredItemEntry, bool>) (req => CraftingRequests.CountMatches(req, chests) >= req.stack)))
    {
      NetManager.Instance.SendToClient(CraftingRequests.NetCraftingRequestsModule.WriteResponse(false), whoAmI);
    }
    else
    {
      foreach (Recipe.RequiredItemEntry req in items)
        CraftingRequests.Consume(req, chests, (List<Item>) null, true);
      NetManager.Instance.SendToClient(CraftingRequests.NetCraftingRequestsModule.WriteResponse(true), whoAmI);
    }
  }

  private static void HandleResponse(bool approved)
  {
    CraftingRequests.RemoteCraftRequest remoteCraftRequest = CraftingRequests._pendingCrafts.Dequeue();
    FakeCursorItem.Remove(remoteCraftRequest.result.type, remoteCraftRequest.result.stack);
    if (approved)
    {
      Main.CraftItem_GrantItem(remoteCraftRequest.recipe, remoteCraftRequest.result, remoteCraftRequest.quickCraft);
    }
    else
    {
      foreach (Item obj in remoteCraftRequest.consumed)
        CraftingRequests.Refund(obj);
    }
  }

  public static void Refund(Item item)
  {
    Main.LocalPlayer.GetOrDropItem(item, GetItemSettings.RefundConsumedItem);
  }

  public static void SubtractPendingRequests()
  {
    foreach (CraftingRequests.RemoteCraftRequest pendingCraft in CraftingRequests._pendingCrafts)
    {
      foreach (Recipe.RequiredItemEntry req in pendingCraft.requested)
        Recipe.SubtractOwnedItem(req);
    }
  }

  public static void SavePossibleRefunds(BinaryWriter writer)
  {
    int num = CraftingRequests._pendingCrafts.Sum<CraftingRequests.RemoteCraftRequest>((Func<CraftingRequests.RemoteCraftRequest, int>) (c => c.consumed.Count));
    writer.Write(num);
    foreach (CraftingRequests.RemoteCraftRequest pendingCraft in CraftingRequests._pendingCrafts)
    {
      foreach (Item obj in pendingCraft.consumed)
        obj.Serialize(writer, ItemSerializationContext.SavingAndLoading);
    }
  }

  public struct RemoteCraftRequest
  {
    public Recipe recipe;
    public Item result;
    public List<Item> consumed;
    public List<Recipe.RequiredItemEntry> requested;
    public bool quickCraft;
  }

  public class NetCraftingRequestsModule : Terraria.Net.NetModule
  {
    public static NetPacket WriteRequest(List<Recipe.RequiredItemEntry> items, List<Chest> chests)
    {
      NetPacket packet = Terraria.Net.NetModule.CreatePacket<CraftingRequests.NetCraftingRequestsModule>();
      packet.Writer.Write7BitEncodedInt(items.Count);
      foreach (Recipe.RequiredItemEntry requiredItemEntry in items)
      {
        packet.Writer.Write(requiredItemEntry.itemIdOrRecipeGroup);
        packet.Writer.Write7BitEncodedInt(requiredItemEntry.stack);
      }
      packet.Writer.Write7BitEncodedInt(chests.Count);
      foreach (Chest chest in chests)
        packet.Writer.Write7BitEncodedInt(chest.index);
      return packet;
    }

    public static NetPacket WriteResponse(bool approved)
    {
      NetPacket packet = Terraria.Net.NetModule.CreatePacket<CraftingRequests.NetCraftingRequestsModule>();
      packet.Writer.Write(approved);
      return packet;
    }

    public void DeserializeRequest(BinaryReader reader, int userId)
    {
      int capacity1 = reader.Read7BitEncodedInt();
      List<Recipe.RequiredItemEntry> items = new List<Recipe.RequiredItemEntry>(capacity1);
      for (int index = 0; index < capacity1; ++index)
        items.Add(new Recipe.RequiredItemEntry(reader.ReadInt32(), reader.Read7BitEncodedInt()));
      int capacity2 = reader.Read7BitEncodedInt();
      List<Chest> chests = new List<Chest>(capacity2);
      for (int index1 = 0; index1 < capacity2; ++index1)
      {
        int index2 = reader.Read7BitEncodedInt();
        chests.Add(index2 < 0 ? (Chest) null : Main.chest[index2]);
      }
      CraftingRequests.HandleRequest(userId, items, chests);
    }

    public void DeserializeResponse(BinaryReader reader)
    {
      CraftingRequests.HandleResponse(reader.ReadBoolean());
    }

    public override bool Deserialize(BinaryReader reader, int userId)
    {
      if (Main.netMode == 2)
        this.DeserializeRequest(reader, userId);
      else
        this.DeserializeResponse(reader);
      return true;
    }
  }
}
