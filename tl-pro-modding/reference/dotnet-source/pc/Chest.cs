// Decompiled with JetBrains decompiler
// Type: Terraria.Chest
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Events;
using Terraria.Graphics.Renderers;
using Terraria.ID;
using Terraria.ObjectData;

#nullable disable
namespace Terraria;

public class Chest : IFixLoadedData
{
  public const float chestStackRange = 600f;
  public const int maxChestTypes = 52;
  public static int[] chestTypeToIcon = new int[52];
  public const int maxChestTypes2 = 38;
  public static int[] chestTypeToIcon2 = new int[38];
  public const int maxDresserTypes = 65;
  public static int[] dresserTypeToIcon = new int[65];
  public const int DefaultMaxItems = 40;
  public const int AbsoluteMaxItemsWeCanEverReachInAChestForNow = 200;
  public int maxItems;
  public const int MaxNameLength = 20;
  public Item[] item;
  public readonly int x;
  public readonly int y;
  public readonly int index;
  public bool bankChest;
  public string name;
  public int frameCounter;
  public int frame;
  public int eatingAnimationTime;
  private bool _itemsGotSet;
  private static Dictionary<Point, Chest> _chestsByCoords = new Dictionary<Point, Chest>();
  private static ParticlePool<RoomCheckParticle> _particlePool = new ParticlePool<RoomCheckParticle>(100, new ParticlePool<RoomCheckParticle>.ParticleInstantiator(Chest.GetNewParticle));
  private static HashSet<int> _chestInUse = new HashSet<int>();

  public static void Clear()
  {
    Array.Clear((Array) Main.chest, 0, Main.chest.Length);
    Chest._chestsByCoords.Clear();
  }

  public static Chest CreateWorldChest(int index, int x, int y)
  {
    Chest chest = new Chest(index, x, y);
    chest.FillWithEmptyInstances();
    Chest.Assign(chest);
    return chest;
  }

  public static void Assign(Chest chest)
  {
    Main.chest[chest.index] = chest;
    Chest._chestsByCoords[new Point(chest.x, chest.y)] = chest;
  }

  public void Resize(int newSize)
  {
    int maxItems = this.maxItems;
    this.maxItems = newSize;
    Array.Resize<Item>(ref this.item, newSize);
    if (!this._itemsGotSet)
      return;
    for (int index = maxItems; index < newSize; ++index)
      this.item[index] = new Item();
  }

  public static void RemoveChest(int chestIndex)
  {
    Chest chest = Main.chest[chestIndex];
    if (chest != null)
      Chest._chestsByCoords.Remove(new Point(chest.x, chest.y));
    Main.chest[chestIndex] = (Chest) null;
  }

  public static Chest CreateBank(int index) => new Chest(index, bank: true);

  public static Chest CreateShop() => new Chest();

  public static Chest CreateOutOfArray(int index, int x, int y, int maxItems)
  {
    return new Chest(index, x, y, maxItems: maxItems);
  }

  public void FillWithEmptyInstances()
  {
    for (int index = 0; index < this.maxItems; ++index)
      this.item[index] = new Item();
    this._itemsGotSet = true;
  }

  public bool IsEmpty()
  {
    for (int index = 0; index < this.maxItems; ++index)
    {
      if (!this.item[index].IsAir)
        return false;
    }
    return true;
  }

  public bool IsLockedOrInUse()
  {
    if (this.bankChest)
      return false;
    return Chest.IsPlayerInChest(this.index) || Chest.IsLocked(this.x, this.y);
  }

  private Chest(int index = 0, int x = 0, int y = 0, bool bank = false, int maxItems = 40)
  {
    this.maxItems = maxItems;
    this.item = new Item[maxItems];
    this.index = index;
    this.x = x;
    this.y = y;
    this.bankChest = bank;
    this.name = string.Empty;
  }

  public override string ToString()
  {
    int num = 0;
    for (int index = 0; index < this.item.Length; ++index)
    {
      if (this.item[index].stack > 0)
        ++num;
    }
    return $"{{X: {this.x}, Y: {this.y}, Count: {num}}}";
  }

  public Chest CloneWithSeparateItems()
  {
    Chest chest = new Chest(this.index, this.x, this.y, this.bankChest, this.maxItems)
    {
      name = this.name
    };
    for (int index = 0; index < this.maxItems; ++index)
    {
      chest.item[index] = this.item[index].Clone();
      chest._itemsGotSet = true;
    }
    return chest;
  }

  public static void Initialize()
  {
    int[] chestTypeToIcon = Chest.chestTypeToIcon;
    for (int style = 0; style < chestTypeToIcon.Length; ++style)
      chestTypeToIcon[style] = WorldGen.GetItemDrop_Chests(style, false);
    chestTypeToIcon[2] = 327;
    chestTypeToIcon[4] = 329;
    chestTypeToIcon[23] = 1533;
    chestTypeToIcon[24] = 1534;
    chestTypeToIcon[25] = 1535 /*0x05FF*/;
    chestTypeToIcon[26] = 1536 /*0x0600*/;
    chestTypeToIcon[27] = 1537;
    chestTypeToIcon[36] = 327;
    chestTypeToIcon[38] = 327;
    chestTypeToIcon[40] = 327;
    int[] chestTypeToIcon2 = Chest.chestTypeToIcon2;
    for (int style = 0; style < chestTypeToIcon2.Length; ++style)
      chestTypeToIcon2[style] = WorldGen.GetItemDrop_Chests(style, true);
    chestTypeToIcon2[13] = 4714;
    int[] dresserTypeToIcon = Chest.dresserTypeToIcon;
    for (int style = 0; style < Chest.dresserTypeToIcon.Length; ++style)
      dresserTypeToIcon[style] = WorldGen.GetItemDrop_Dressers(style);
  }

  public static bool IsPlayerInChest(int i)
  {
    for (int index = 0; index < (int) byte.MaxValue; ++index)
    {
      if (Main.player[index].chest == i)
        return true;
    }
    return false;
  }

  public static List<int> GetCurrentlyOpenChests()
  {
    List<int> currentlyOpenChests = new List<int>();
    for (int index = 0; index < (int) byte.MaxValue; ++index)
    {
      if (Main.player[index].chest > -1)
        currentlyOpenChests.Add(Main.player[index].chest);
    }
    return currentlyOpenChests;
  }

  public static bool IsLocked(int x, int y) => Chest.IsLocked(Main.tile[x, y]);

  public static bool IsLocked(Tile t)
  {
    if (t == null || t.type == (ushort) 21 && (t.frameX >= (short) 72 && t.frameX <= (short) 106 || t.frameX >= (short) 144 /*0x90*/ && t.frameX <= (short) 178 || t.frameX >= (short) 828 && t.frameX <= (short) 1006 || t.frameX >= (short) 1296 && t.frameX <= (short) 1330 || t.frameX >= (short) 1368 && t.frameX <= (short) 1402 || t.frameX >= (short) 1440 && t.frameX <= (short) 1474))
      return true;
    return t.type == (ushort) 467 && (int) t.frameX / 36 == 13;
  }

  public static void VisualizeChestTransfer(
    Vector2 position,
    Vector2 chestPosition,
    int itemType,
    Chest.ItemTransferVisualizationSettings settings)
  {
    BitsByte bitsByte = new BitsByte(settings.RandomizeStartPosition, settings.RandomizeEndPosition, settings.TransitionIn, settings.Fullbright);
    ParticleOrchestrator.BroadcastOrRequestParticleSpawn(ParticleOrchestraType.ItemTransfer, new ParticleOrchestraSettings()
    {
      PositionInWorld = position,
      MovementVector = chestPosition - position,
      UniqueInfoPiece = itemType | (int) (byte) bitsByte << 24
    });
  }

  public static void VisualizeChestTransfer_CoinsBatch(
    Vector2 position,
    Vector2 chestPosition,
    long coinsMoved,
    Chest.ItemTransferVisualizationSettings settings)
  {
    int[] numArray = Utils.CoinsSplit(coinsMoved);
    for (int index = 0; index < numArray.Length; ++index)
    {
      if (numArray[index] >= 1)
        Chest.VisualizeChestTransfer(position, chestPosition, 71 + index, settings);
    }
  }

  public object Clone() => this.MemberwiseClone();

  public static bool Unlock(int X, int Y)
  {
    if (Main.tile[X, Y] == null || Main.tile[X + 1, Y] == null || Main.tile[X, Y + 1] == null || Main.tile[X + 1, Y + 1] == null)
      return false;
    short num1 = 0;
    int Type = 0;
    Tile tileSafely1 = Framing.GetTileSafely(X, Y);
    int type = (int) tileSafely1.type;
    int num2 = (int) tileSafely1.frameX / 36;
    switch (type)
    {
      case 21:
        switch (num2)
        {
          case 2:
            num1 = (short) 36;
            Type = 11;
            AchievementsHelper.NotifyProgressionEvent(19);
            break;
          case 4:
            num1 = (short) 36;
            Type = 11;
            break;
          case 23:
          case 24:
          case 25:
          case 26:
          case 27:
            if (!NPC.downedPlantBoss)
              return false;
            num1 = (short) 180;
            Type = 11;
            AchievementsHelper.NotifyProgressionEvent(20);
            break;
          case 36:
          case 38:
          case 40:
            num1 = (short) 36;
            Type = 11;
            break;
          default:
            return false;
        }
        break;
      case 467:
        if (num2 != 13 || !NPC.downedPlantBoss)
          return false;
        num1 = (short) 36;
        Type = 11;
        AchievementsHelper.NotifyProgressionEvent(20);
        break;
    }
    SoundEngine.PlaySound(22, X * 16 /*0x10*/, Y * 16 /*0x10*/);
    for (int i = X; i <= X + 1; ++i)
    {
      for (int j = Y; j <= Y + 1; ++j)
      {
        Tile tileSafely2 = Framing.GetTileSafely(i, j);
        if ((int) tileSafely2.type == type)
        {
          tileSafely2.frameX -= num1;
          Main.tile[i, j] = tileSafely2;
          for (int index = 0; index < 4; ++index)
            Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, Type);
        }
      }
    }
    return true;
  }

  public static bool Lock(int X, int Y)
  {
    if (Main.tile[X, Y] == null || Main.tile[X + 1, Y] == null || Main.tile[X, Y + 1] == null || Main.tile[X + 1, Y + 1] == null)
      return false;
    short num1 = 0;
    Tile tileSafely1 = Framing.GetTileSafely(X, Y);
    int type = (int) tileSafely1.type;
    int num2 = (int) tileSafely1.frameX / 36;
    switch (type)
    {
      case 21:
        switch (num2)
        {
          case 1:
            num1 = (short) 36;
            break;
          case 3:
            num1 = (short) 36;
            break;
          case 18:
          case 19:
          case 20:
          case 21:
          case 22:
            if (!NPC.downedPlantBoss)
              return false;
            num1 = (short) 180;
            break;
          case 35:
          case 37:
          case 39:
            num1 = (short) 36;
            break;
          default:
            return false;
        }
        break;
      case 467:
        if (num2 != 12 || !NPC.downedPlantBoss)
          return false;
        num1 = (short) 36;
        AchievementsHelper.NotifyProgressionEvent(20);
        break;
    }
    SoundEngine.PlaySound(22, X * 16 /*0x10*/, Y * 16 /*0x10*/);
    for (int i = X; i <= X + 1; ++i)
    {
      for (int j = Y; j <= Y + 1; ++j)
      {
        Tile tileSafely2 = Framing.GetTileSafely(i, j);
        if ((int) tileSafely2.type == type)
        {
          tileSafely2.frameX += num1;
          Main.tile[i, j] = tileSafely2;
        }
      }
    }
    return true;
  }

  public static int UsingChest(int i)
  {
    if (Main.chest[i] != null)
    {
      for (int index = 0; index < (int) byte.MaxValue; ++index)
      {
        if (Main.player[index].active && Main.player[index].chest == i)
          return index;
      }
    }
    return -1;
  }

  public static int FindChest(int X, int Y)
  {
    Chest chest;
    return Chest._chestsByCoords.TryGetValue(new Point(X, Y), out chest) ? chest.index : -1;
  }

  public static int FindEmptyChest(
    int x,
    int y,
    int type = 21,
    int style = 0,
    int direction = 1,
    int alternate = 0)
  {
    int emptyChest = -1;
    for (int index = 0; index < 8000; ++index)
    {
      Chest chest = Main.chest[index];
      if (chest != null)
      {
        if (chest.x == x && chest.y == y)
          return -1;
      }
      else if (emptyChest == -1)
        emptyChest = index;
    }
    return emptyChest;
  }

  public static bool NearOtherChests(int x, int y)
  {
    for (int i = x - 25; i < x + 25; ++i)
    {
      for (int j = y - 8; j < y + 8; ++j)
      {
        Tile tileSafely = Framing.GetTileSafely(i, j);
        if (tileSafely.active() && TileID.Sets.BasicChest[(int) tileSafely.type])
          return true;
      }
    }
    return false;
  }

  public static int AfterPlacement_Hook(
    int x,
    int y,
    int type = 21,
    int style = 0,
    int direction = 1,
    int alternate = 0)
  {
    Point16 baseCoords = new Point16(x, y);
    TileObjectData.OriginToTopLeft(type, style, ref baseCoords);
    int emptyChest = Chest.FindEmptyChest((int) baseCoords.X, (int) baseCoords.Y);
    if (emptyChest == -1)
      return -1;
    if (Main.netMode != 1)
    {
      Chest.CreateWorldChest(emptyChest, (int) baseCoords.X, (int) baseCoords.Y);
    }
    else
    {
      switch (type)
      {
        case 21:
          NetMessage.SendData(34, number2: (float) x, number3: (float) y, number4: (float) style);
          break;
        case 467:
          NetMessage.SendData(34, number: 4, number2: (float) x, number3: (float) y, number4: (float) style);
          break;
        default:
          NetMessage.SendData(34, number: 2, number2: (float) x, number3: (float) y, number4: (float) style);
          break;
      }
    }
    return emptyChest;
  }

  public static int CreateChest(int X, int Y, int id = -1)
  {
    int index = id;
    if (index == -1)
    {
      index = Chest.FindEmptyChest(X, Y);
      if (index == -1)
        return -1;
      if (Main.netMode == 1)
        return index;
    }
    Chest.CreateWorldChest(index, X, Y);
    return index;
  }

  public static bool CanDestroyChest(int X, int Y)
  {
    Chest chest;
    if (!Chest._chestsByCoords.TryGetValue(new Point(X, Y), out chest))
      return true;
    for (int index = 0; index < chest.maxItems; ++index)
    {
      if (chest.item[index] != null && chest.item[index].type > 0 && chest.item[index].stack > 0)
        return false;
    }
    return true;
  }

  public static bool DestroyChest(int X, int Y)
  {
    Chest chest;
    if (!Chest._chestsByCoords.TryGetValue(new Point(X, Y), out chest))
      return true;
    for (int index = 0; index < chest.maxItems; ++index)
    {
      if (chest.item[index] != null && chest.item[index].type > 0 && chest.item[index].stack > 0)
        return false;
    }
    int index1 = chest.index;
    Chest.RemoveChest(index1);
    if (Main.player[Main.myPlayer].chest == index1)
      Main.player[Main.myPlayer].chest = -1;
    return true;
  }

  public static void DestroyChestDirect(int X, int Y, int id)
  {
    if (id < 0)
      return;
    if (id >= Main.chest.Length)
      return;
    try
    {
      Chest chest = Main.chest[id];
      if (chest == null || chest.x != X || chest.y != Y)
        return;
      Chest.RemoveChest(id);
      if (Main.player[Main.myPlayer].chest != id)
        return;
      Main.player[Main.myPlayer].chest = -1;
    }
    catch
    {
    }
  }

  public void AddItemToShop(Item newItem)
  {
    int num1 = Main.shopSellbackHelper.Remove(newItem);
    if (num1 >= newItem.stack)
      return;
    for (int index = 0; index < 39; ++index)
    {
      if (this.item[index] == null || this.item[index].type == 0)
      {
        this.item[index] = newItem.Clone();
        this.item[index].favorited = false;
        this.item[index].buyOnce = true;
        this.item[index].stack -= num1;
        int num2 = this.item[index].value;
        break;
      }
    }
  }

  public static void SetupTravelShop_AddToShop(int itemID, ref int added, ref int count)
  {
    if (itemID == 0)
      return;
    ++added;
    Main.travelShop[count] = itemID;
    ++count;
    if (itemID == 2260)
    {
      Main.travelShop[count] = 2261;
      ++count;
      Main.travelShop[count] = 2262;
      ++count;
    }
    if (itemID == 5680)
    {
      Main.travelShop[count] = 5681;
      ++count;
      Main.travelShop[count] = 5682;
      ++count;
    }
    if (itemID == 4555)
    {
      Main.travelShop[count] = 4556;
      ++count;
      Main.travelShop[count] = 4557;
      ++count;
    }
    if (itemID == 4321)
    {
      Main.travelShop[count] = 4322;
      ++count;
    }
    if (itemID == 4323)
    {
      Main.travelShop[count] = 4324;
      ++count;
      Main.travelShop[count] = 4365;
      ++count;
    }
    if (itemID == 5390)
    {
      Main.travelShop[count] = 5386;
      ++count;
      Main.travelShop[count] = 5387;
      ++count;
    }
    if (itemID == 4666)
    {
      Main.travelShop[count] = 4664;
      ++count;
      Main.travelShop[count] = 4665;
      ++count;
    }
    if (itemID != 3637)
      return;
    --count;
    switch (Main.rand.Next(6))
    {
      case 0:
        Main.travelShop[count++] = 3637;
        Main.travelShop[count++] = 3642;
        break;
      case 1:
        Main.travelShop[count++] = 3621;
        Main.travelShop[count++] = 3622;
        break;
      case 2:
        Main.travelShop[count++] = 3634;
        Main.travelShop[count++] = 3639;
        break;
      case 3:
        Main.travelShop[count++] = 3633;
        Main.travelShop[count++] = 3638;
        break;
      case 4:
        Main.travelShop[count++] = 3635;
        Main.travelShop[count++] = 3640;
        break;
      case 5:
        Main.travelShop[count++] = 3636;
        Main.travelShop[count++] = 3641;
        break;
    }
  }

  public static bool SetupTravelShop_CanAddItemToShop(int it)
  {
    if (it == 0)
      return false;
    for (int index = 0; index < Main.travelShop.Length; ++index)
    {
      if (Main.travelShop[index] == it)
        return false;
      if (it == 3637)
      {
        switch (Main.travelShop[index])
        {
          case 3621:
          case 3622:
          case 3633:
          case 3634:
          case 3635:
          case 3636:
          case 3637:
          case 3638:
          case 3639:
          case 3640:
          case 3641:
          case 3642:
            return false;
          default:
            continue;
        }
      }
    }
    return true;
  }

  public static void SetupTravelShop_GetPainting(
    Player playerWithHighestLuck,
    int[] rarity,
    ref int it,
    int minimumRarity = 0)
  {
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0 && !Main.dontStarveWorld)
      it = 5121;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0 && !Main.dontStarveWorld)
      it = 5122;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0 && !Main.dontStarveWorld)
      it = 5124;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0 && !Main.dontStarveWorld)
      it = 5123;
    if (minimumRarity > 2)
      return;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0 && Main.hardMode && NPC.downedMoonlord)
      it = 3596;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0 && Main.hardMode && NPC.downedMartians)
      it = 2865;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0 && Main.hardMode && NPC.downedMartians)
      it = 2866;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0 && Main.hardMode && NPC.downedMartians)
      it = 2867;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0 && NPC.downedFrost)
      it = 3055;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0 && NPC.downedFrost)
      it = 3056;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0 && NPC.downedFrost)
      it = 3057;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0 && NPC.downedFrost)
      it = 3058;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0 && NPC.downedFrost)
      it = 3059;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0 && Main.hardMode && NPC.downedMoonlord)
      it = 5243;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 5530;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 5633;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 5636;
    if (minimumRarity > 1)
      return;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0 && Main.dontStarveWorld)
      it = 5121;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0 && Main.dontStarveWorld)
      it = 5122;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0 && Main.dontStarveWorld)
      it = 5124;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0 && Main.dontStarveWorld)
      it = 5123;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 5225;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 5229;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 5232;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 5389;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 5233;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 5241;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 5244;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 5487;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 5242;
    if (playerWithHighestLuck.RollLuck(rarity[1]) != 0)
      return;
    it = 5531;
  }

  public static void SetupTravelShop_AdjustSlotRarities(int slotItemAttempts, ref int[] rarity)
  {
    if (rarity[5] > 1 && slotItemAttempts > 4700)
      rarity[5] = 1;
    if (rarity[4] > 1 && slotItemAttempts > 4600)
      rarity[4] = 1;
    if (rarity[3] > 1 && slotItemAttempts > 4500)
      rarity[3] = 1;
    if (rarity[2] > 1 && slotItemAttempts > 4400)
      rarity[2] = 1;
    if (rarity[1] > 1 && slotItemAttempts > 4300)
      rarity[1] = 1;
    if (rarity[0] <= 1 || slotItemAttempts <= 4200)
      return;
    rarity[0] = 1;
  }

  public static void SetupTravelShop_GetItem(
    Player playerWithHighestLuck,
    int[] rarity,
    ref int it,
    int minimumRarity = 0)
  {
    if (minimumRarity <= 4 && playerWithHighestLuck.RollLuck(rarity[4]) == 0)
      it = 3309;
    if (minimumRarity <= 3 && playerWithHighestLuck.RollLuck(rarity[3]) == 0)
      it = 3314;
    if (playerWithHighestLuck.RollLuck(rarity[5]) == 0)
      it = 1987;
    if (minimumRarity > 4)
      return;
    if (playerWithHighestLuck.RollLuck(rarity[4]) == 0 && Main.hardMode)
      it = 2270;
    if (playerWithHighestLuck.RollLuck(rarity[4]) == 0 && Main.hardMode)
      it = 4760;
    if (playerWithHighestLuck.RollLuck(rarity[4]) == 0)
      it = 2278;
    if (playerWithHighestLuck.RollLuck(rarity[4]) == 0)
      it = 2271;
    if (minimumRarity > 3)
      return;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0 && Main.hardMode && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
      it = 2223;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0)
      it = 2272;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0)
      it = 2276;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0)
      it = 2284;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0)
      it = 2285;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0)
      it = 2286;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0)
      it = 2287;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0)
      it = 4744;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0 && NPC.downedBoss3)
      it = 2296;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0)
      it = 3628;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0 && Main.hardMode)
      it = 4091;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0)
      it = 4603;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0)
      it = 4604;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0)
      it = 5297;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0)
      it = 4605;
    if (playerWithHighestLuck.RollLuck(rarity[3]) == 0)
      it = 4550;
    if (minimumRarity > 2)
      return;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 5680;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 2268;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0 && WorldGen.shadowOrbSmashed)
      it = 2269;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 1988;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 2275;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 2279;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 2277;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 4555;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 4321;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 4323;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 5390;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 4549;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 4561;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 4774;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 5136;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 5305;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 4562;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 4558;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 4559;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 4563;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0)
      it = 4666;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0 && (NPC.downedDeerclops || NPC.downedSlimeKing || NPC.downedBoss1 || NPC.downedBoss2 || NPC.downedBoss3 || NPC.downedQueenBee || Main.hardMode))
    {
      it = 4347;
      if (Main.hardMode)
        it = 4348;
    }
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0 && NPC.downedBoss1)
      it = 3262;
    if (playerWithHighestLuck.RollLuck(rarity[2]) == 0 && NPC.downedMechBossAny)
      it = 3284;
    if (minimumRarity > 1)
      return;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 5600;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 2267;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 2214;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 2215;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 2216;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 2217;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 3624;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 2273;
    if (playerWithHighestLuck.RollLuck(rarity[1]) == 0)
      it = 2274;
    if (minimumRarity > 0)
      return;
    if (playerWithHighestLuck.RollLuck(rarity[0]) == 0)
      it = 2266;
    if (playerWithHighestLuck.RollLuck(rarity[0]) == 0)
      it = 2281 + Main.rand.Next(3);
    if (playerWithHighestLuck.RollLuck(rarity[0]) == 0)
      it = 2258;
    if (playerWithHighestLuck.RollLuck(rarity[0]) == 0)
      it = 2242;
    if (playerWithHighestLuck.RollLuck(rarity[0]) == 0)
      it = 2260;
    if (playerWithHighestLuck.RollLuck(rarity[0]) == 0)
      it = 3637;
    if (playerWithHighestLuck.RollLuck(rarity[0]) == 0)
      it = 4420;
    if (playerWithHighestLuck.RollLuck(rarity[0]) == 0)
      it = 3119;
    if (playerWithHighestLuck.RollLuck(rarity[0]) == 0)
      it = 3118;
    if (playerWithHighestLuck.RollLuck(rarity[0]) != 0)
      return;
    it = 3099;
  }

  public static void SetupTravelShop()
  {
    for (int index = 0; index < Main.travelShop.Length; ++index)
      Main.travelShop[index] = 0;
    Player playerWithHighestLuck = Player.GetPlayerWithHighestLuck();
    int num = Main.rand.Next(4, 7);
    if (playerWithHighestLuck.RollLuck(4) == 0)
      ++num;
    if (playerWithHighestLuck.RollLuck(8) == 0)
      ++num;
    if (playerWithHighestLuck.RollLuck(16 /*0x10*/) == 0)
      ++num;
    if (playerWithHighestLuck.RollLuck(32 /*0x20*/) == 0)
      ++num;
    if (Main.expertMode && playerWithHighestLuck.RollLuck(2) == 0)
      ++num;
    if (NPC.peddlersSatchelWasUsed)
      ++num;
    if (Main.tenthAnniversaryWorld)
    {
      if (!Main.getGoodWorld)
        ++num;
      ++num;
    }
    int count = 0;
    int added = 0;
    int[] rarity1 = new int[6]
    {
      100,
      200,
      300,
      400,
      500,
      600
    };
    int[] rarity2 = rarity1;
    int slotItemAttempts1 = 0;
    if (Main.hardMode)
    {
      int it = 0;
      while (slotItemAttempts1 < 5000)
      {
        ++slotItemAttempts1;
        Chest.SetupTravelShop_AdjustSlotRarities(slotItemAttempts1, ref rarity2);
        Chest.SetupTravelShop_GetItem(playerWithHighestLuck, rarity2, ref it, 2);
        if (Chest.SetupTravelShop_CanAddItemToShop(it))
        {
          Chest.SetupTravelShop_AddToShop(it, ref added, ref count);
          break;
        }
      }
    }
    while (added < num)
    {
      int it = 0;
      Chest.SetupTravelShop_GetItem(playerWithHighestLuck, rarity1, ref it);
      if (Chest.SetupTravelShop_CanAddItemToShop(it))
        Chest.SetupTravelShop_AddToShop(it, ref added, ref count);
    }
    int[] rarity3 = rarity1;
    int slotItemAttempts2 = 0;
    int it1 = 0;
    while (slotItemAttempts2 < 5000)
    {
      ++slotItemAttempts2;
      Chest.SetupTravelShop_AdjustSlotRarities(slotItemAttempts2, ref rarity3);
      Chest.SetupTravelShop_GetPainting(playerWithHighestLuck, rarity3, ref it1);
      if (Chest.SetupTravelShop_CanAddItemToShop(it1))
      {
        Chest.SetupTravelShop_AddToShop(it1, ref added, ref count);
        break;
      }
    }
  }

  public void SetupShop(int type)
  {
    ShoppingSettings shoppingSettings = Main.LocalPlayer.currentShoppingSettings;
    Item[] objArray1 = this.item;
    for (int index = 0; index < this.maxItems; ++index)
      objArray1[index] = new Item();
    int index1 = 0;
    switch (type)
    {
      case 1:
        objArray1[index1].SetDefaults(88);
        int index2 = index1 + 1;
        objArray1[index2].SetDefaults(87);
        int index3 = index2 + 1;
        objArray1[index3].SetDefaults(35);
        int index4 = index3 + 1;
        objArray1[index4].SetDefaults(1991);
        int index5 = index4 + 1;
        objArray1[index5].SetDefaults(3509);
        int index6 = index5 + 1;
        objArray1[index6].SetDefaults(3506);
        int index7 = index6 + 1;
        objArray1[index7].SetDefaults(8);
        int index8 = index7 + 1;
        if (Main.notTheBeesWorld && !Main.remixWorld)
        {
          objArray1[index8].SetDefaults(4388);
          ++index8;
        }
        objArray1[index8].SetDefaults(28);
        int index9 = index8 + 1;
        if (Main.hardMode)
        {
          objArray1[index9].SetDefaults(188);
          ++index9;
        }
        objArray1[index9].SetDefaults(110);
        int index10 = index9 + 1;
        if (Main.hardMode)
        {
          objArray1[index10].SetDefaults(189);
          ++index10;
        }
        objArray1[index10].SetDefaults(40);
        int index11 = index10 + 1;
        objArray1[index11].SetDefaults(42);
        int index12 = index11 + 1;
        objArray1[index12].SetDefaults(965);
        int index13 = index12 + 1;
        if (Main.player[Main.myPlayer].ZoneSnow)
        {
          objArray1[index13].SetDefaults(967);
          ++index13;
        }
        if (Main.player[Main.myPlayer].ZoneJungle || Main.tenthAnniversaryWorld && Main.notTheBeesWorld && !Main.remixWorld)
        {
          objArray1[index13].SetDefaults(33);
          ++index13;
        }
        if (Main.dayTime && Main.IsItAHappyWindyDay)
          objArray1[index13++].SetDefaults(4074);
        if (Main.bloodMoon)
        {
          objArray1[index13].SetDefaults(279);
          ++index13;
        }
        if (!Main.dayTime)
          objArray1[index13++].SetDefaults(282);
        if (BirthdayParty.PartyIsUp)
          objArray1[index13++].SetDefaults(5643);
        if (NPC.downedBoss3)
        {
          objArray1[index13].SetDefaults(346);
          ++index13;
        }
        if (Main.hardMode)
        {
          objArray1[index13].SetDefaults(488);
          ++index13;
        }
        for (int index14 = 0; index14 < 58; ++index14)
        {
          if (Main.player[Main.myPlayer].inventory[index14].type == 930)
          {
            objArray1[index13].SetDefaults(931);
            int index15 = index13 + 1;
            objArray1[index15].SetDefaults(1614);
            index13 = index15 + 1;
            break;
          }
        }
        objArray1[index13].SetDefaults(1786);
        index1 = index13 + 1;
        if (Main.hardMode)
        {
          objArray1[index1].SetDefaults(1348);
          ++index1;
        }
        if (Main.hardMode)
        {
          objArray1[index1].SetDefaults(3198);
          ++index1;
        }
        if (NPC.downedBoss2 || NPC.downedBoss3 || Main.hardMode)
        {
          Item[] objArray2 = objArray1;
          int index16 = index1;
          int num = index16 + 1;
          objArray2[index16].SetDefaults(4063);
          Item[] objArray3 = objArray1;
          int index17 = num;
          index1 = index17 + 1;
          objArray3[index17].SetDefaults(4673);
        }
        if (Main.player[Main.myPlayer].HasItem(3107))
        {
          objArray1[index1].SetDefaults(3108);
          ++index1;
          break;
        }
        break;
      case 2:
        objArray1[index1].SetDefaults(97);
        int index18 = index1 + 1;
        if (Main.bloodMoon || Main.hardMode)
        {
          if (WorldGen.SavedOreTiers.Silver == 168)
          {
            objArray1[index18].SetDefaults(4915);
            ++index18;
          }
          else
          {
            objArray1[index18].SetDefaults(278);
            ++index18;
          }
        }
        if (NPC.downedBoss2 && !Main.dayTime || Main.hardMode)
        {
          objArray1[index18].SetDefaults(47);
          ++index18;
        }
        objArray1[index18].SetDefaults(95);
        int index19 = index18 + 1;
        objArray1[index19].SetDefaults(98);
        index1 = index19 + 1;
        if (Main.player[Main.myPlayer].ZoneGraveyard && NPC.downedBoss3)
          objArray1[index1++].SetDefaults(4703);
        if (!Main.dayTime)
        {
          objArray1[index1].SetDefaults(324);
          ++index1;
        }
        if (Main.hardMode)
        {
          objArray1[index1].SetDefaults(534);
          ++index1;
        }
        if (Main.hardMode)
        {
          objArray1[index1].SetDefaults(1432);
          ++index1;
        }
        if (Main.hardMode)
        {
          objArray1[index1].SetDefaults(2177);
          ++index1;
        }
        if (Main.player[Main.myPlayer].HasItem(1258))
        {
          objArray1[index1].SetDefaults(1261);
          ++index1;
        }
        if (Main.player[Main.myPlayer].HasItem(1835))
        {
          objArray1[index1].SetDefaults(1836);
          ++index1;
        }
        if (Main.player[Main.myPlayer].HasItem(3107))
        {
          objArray1[index1].SetDefaults(3108);
          ++index1;
        }
        if (Main.player[Main.myPlayer].HasItem(1782))
        {
          objArray1[index1].SetDefaults(1783);
          ++index1;
        }
        if (Main.player[Main.myPlayer].HasItem(1784))
        {
          objArray1[index1].SetDefaults(1785);
          ++index1;
        }
        if (Main.halloween)
        {
          objArray1[index1].SetDefaults(1736);
          int index20 = index1 + 1;
          objArray1[index20].SetDefaults(1737);
          int index21 = index20 + 1;
          objArray1[index21].SetDefaults(1738);
          index1 = index21 + 1;
          break;
        }
        break;
      case 3:
        int index22;
        if (Main.bloodMoon)
        {
          if (WorldGen.crimson)
          {
            if (!Main.remixWorld || Main.tenthAnniversaryWorld && !Main.getGoodWorld)
            {
              objArray1[index1].SetDefaults(2886);
              ++index1;
            }
            objArray1[index1].SetDefaults(2171);
            int index23 = index1 + 1;
            objArray1[index23].SetDefaults(4508);
            index22 = index23 + 1;
          }
          else
          {
            if (!Main.remixWorld || Main.tenthAnniversaryWorld && !Main.getGoodWorld)
            {
              objArray1[index1].SetDefaults(67);
              ++index1;
            }
            objArray1[index1].SetDefaults(59);
            int index24 = index1 + 1;
            objArray1[index24].SetDefaults(4504);
            index22 = index24 + 1;
          }
        }
        else
        {
          if (!Main.remixWorld || Main.infectedSeed || Main.tenthAnniversaryWorld && !Main.getGoodWorld)
          {
            objArray1[index1].SetDefaults(66);
            ++index1;
          }
          objArray1[index1].SetDefaults(62);
          int index25 = index1 + 1;
          objArray1[index25].SetDefaults(63 /*0x3F*/);
          int index26 = index25 + 1;
          objArray1[index26].SetDefaults(745);
          index22 = index26 + 1;
        }
        if (Main.hardMode && Main.player[Main.myPlayer].ZoneGraveyard)
        {
          if (WorldGen.crimson)
            objArray1[index22].SetDefaults(59);
          else
            objArray1[index22].SetDefaults(2171);
          ++index22;
        }
        objArray1[index22].SetDefaults(27);
        int index27 = index22 + 1;
        objArray1[index27].SetDefaults(5309);
        int index28 = index27 + 1;
        objArray1[index28].SetDefaults(114);
        int index29 = index28 + 1;
        objArray1[index29].SetDefaults(1828);
        int index30 = index29 + 1;
        objArray1[index30].SetDefaults(747);
        int index31 = index30 + 1;
        if (Main.hardMode)
        {
          objArray1[index31].SetDefaults(746);
          ++index31;
        }
        if (Main.hardMode)
        {
          objArray1[index31].SetDefaults(369);
          ++index31;
        }
        if (Main.hardMode)
        {
          objArray1[index31].SetDefaults(4505);
          ++index31;
        }
        if (Main.player[Main.myPlayer].ZoneUnderworldHeight)
          objArray1[index31++].SetDefaults(5214);
        else if (Main.player[Main.myPlayer].ZoneGlowshroom)
          objArray1[index31++].SetDefaults(194);
        if (Main.halloween)
        {
          objArray1[index31].SetDefaults(1853);
          int index32 = index31 + 1;
          objArray1[index32].SetDefaults(1854);
          index31 = index32 + 1;
        }
        Item[] objArray4 = objArray1;
        int index33 = index31;
        int num1 = index33 + 1;
        objArray4[index33].SetDefaults(3215);
        Item[] objArray5 = objArray1;
        int index34 = num1;
        int num2 = index34 + 1;
        objArray5[index34].SetDefaults(3216);
        Item[] objArray6 = objArray1;
        int index35 = num2;
        int num3 = index35 + 1;
        objArray6[index35].SetDefaults(3219);
        int num4;
        if (WorldGen.crimson)
        {
          Item[] objArray7 = objArray1;
          int index36 = num3;
          num4 = index36 + 1;
          objArray7[index36].SetDefaults(3218);
        }
        else
        {
          Item[] objArray8 = objArray1;
          int index37 = num3;
          num4 = index37 + 1;
          objArray8[index37].SetDefaults(3217);
        }
        Item[] objArray9 = objArray1;
        int index38 = num4;
        int num5 = index38 + 1;
        objArray9[index38].SetDefaults(3220);
        Item[] objArray10 = objArray1;
        int index39 = num5;
        int num6 = index39 + 1;
        objArray10[index39].SetDefaults(3221);
        Item[] objArray11 = objArray1;
        int index40 = num6;
        int num7 = index40 + 1;
        objArray11[index40].SetDefaults(3222);
        Item[] objArray12 = objArray1;
        int index41 = num7;
        int num8 = index41 + 1;
        objArray12[index41].SetDefaults(4047);
        Item[] objArray13 = objArray1;
        int index42 = num8;
        int num9 = index42 + 1;
        objArray13[index42].SetDefaults(4045);
        Item[] objArray14 = objArray1;
        int index43 = num9;
        int num10 = index43 + 1;
        objArray14[index43].SetDefaults(4044);
        Item[] objArray15 = objArray1;
        int index44 = num10;
        int num11 = index44 + 1;
        objArray15[index44].SetDefaults(4043);
        Item[] objArray16 = objArray1;
        int index45 = num11;
        int num12 = index45 + 1;
        objArray16[index45].SetDefaults(4042);
        Item[] objArray17 = objArray1;
        int index46 = num12;
        int num13 = index46 + 1;
        objArray17[index46].SetDefaults(4046);
        Item[] objArray18 = objArray1;
        int index47 = num13;
        int num14 = index47 + 1;
        objArray18[index47].SetDefaults(4041);
        Item[] objArray19 = objArray1;
        int index48 = num14;
        int num15 = index48 + 1;
        objArray19[index48].SetDefaults(4241);
        Item[] objArray20 = objArray1;
        int index49 = num15;
        int num16 = index49 + 1;
        objArray20[index49].SetDefaults(4048);
        if (Main.hardMode)
        {
          switch (Main.moonPhase / 2)
          {
            case 0:
              Item[] objArray21 = objArray1;
              int index50 = num16;
              int num17 = index50 + 1;
              objArray21[index50].SetDefaults(4430);
              Item[] objArray22 = objArray1;
              int index51 = num17;
              int num18 = index51 + 1;
              objArray22[index51].SetDefaults(4431);
              Item[] objArray23 = objArray1;
              int index52 = num18;
              index1 = index52 + 1;
              objArray23[index52].SetDefaults(4432);
              break;
            case 1:
              Item[] objArray24 = objArray1;
              int index53 = num16;
              int num19 = index53 + 1;
              objArray24[index53].SetDefaults(4433);
              Item[] objArray25 = objArray1;
              int index54 = num19;
              int num20 = index54 + 1;
              objArray25[index54].SetDefaults(4434);
              Item[] objArray26 = objArray1;
              int index55 = num20;
              index1 = index55 + 1;
              objArray26[index55].SetDefaults(4435);
              break;
            case 2:
              Item[] objArray27 = objArray1;
              int index56 = num16;
              int num21 = index56 + 1;
              objArray27[index56].SetDefaults(4436);
              Item[] objArray28 = objArray1;
              int index57 = num21;
              int num22 = index57 + 1;
              objArray28[index57].SetDefaults(4437);
              Item[] objArray29 = objArray1;
              int index58 = num22;
              index1 = index58 + 1;
              objArray29[index58].SetDefaults(4438);
              break;
            default:
              Item[] objArray30 = objArray1;
              int index59 = num16;
              int num23 = index59 + 1;
              objArray30[index59].SetDefaults(4439);
              Item[] objArray31 = objArray1;
              int index60 = num23;
              int num24 = index60 + 1;
              objArray31[index60].SetDefaults(4440);
              Item[] objArray32 = objArray1;
              int index61 = num24;
              index1 = index61 + 1;
              objArray32[index61].SetDefaults(4441);
              break;
          }
        }
        else
        {
          switch (Main.moonPhase / 2)
          {
            case 0:
              Item[] objArray33 = objArray1;
              int index62 = num16;
              int num25 = index62 + 1;
              objArray33[index62].SetDefaults(4430);
              Item[] objArray34 = objArray1;
              int index63 = num25;
              index1 = index63 + 1;
              objArray34[index63].SetDefaults(4431);
              break;
            case 1:
              Item[] objArray35 = objArray1;
              int index64 = num16;
              int num26 = index64 + 1;
              objArray35[index64].SetDefaults(4433);
              Item[] objArray36 = objArray1;
              int index65 = num26;
              index1 = index65 + 1;
              objArray36[index65].SetDefaults(4434);
              break;
            case 2:
              Item[] objArray37 = objArray1;
              int index66 = num16;
              int num27 = index66 + 1;
              objArray37[index66].SetDefaults(4436);
              Item[] objArray38 = objArray1;
              int index67 = num27;
              index1 = index67 + 1;
              objArray38[index67].SetDefaults(4437);
              break;
            default:
              Item[] objArray39 = objArray1;
              int index68 = num16;
              int num28 = index68 + 1;
              objArray39[index68].SetDefaults(4439);
              Item[] objArray40 = objArray1;
              int index69 = num28;
              index1 = index69 + 1;
              objArray40[index69].SetDefaults(4440);
              break;
          }
        }
        if (!Main.hardMode && Main.vampireSeed && Main.infectedSeed)
        {
          Item[] objArray41 = objArray1;
          int index70 = index1;
          int num29 = index70 + 1;
          objArray41[index70].SetDefaults(8);
          if (WorldGen.crimson)
          {
            Item[] objArray42 = objArray1;
            int index71 = num29;
            index1 = index71 + 1;
            objArray42[index71].SetDefaults(4386);
            break;
          }
          Item[] objArray43 = objArray1;
          int index72 = num29;
          index1 = index72 + 1;
          objArray43[index72].SetDefaults(4385);
          break;
        }
        break;
      case 4:
        objArray1[index1].SetDefaults(168);
        int index73 = index1 + 1;
        objArray1[index73].SetDefaults(166);
        int index74 = index73 + 1;
        if ((NPC.downedBoss1 || NPC.downedSlimeKing) && !Main.dayTime)
        {
          objArray1[index74].SetDefaults(5542);
          ++index74;
        }
        objArray1[index74].SetDefaults(167);
        int index75 = index74 + 1;
        if (Main.hardMode)
        {
          objArray1[index75].SetDefaults(265);
          ++index75;
        }
        Item[] objArray44 = objArray1;
        int index76 = index75;
        int num30 = index76 + 1;
        objArray44[index76].SetDefaults(5481);
        Item[] objArray45 = objArray1;
        int index77 = num30;
        index1 = index77 + 1;
        objArray45[index77].SetDefaults(5464);
        if (Main.hardMode && NPC.downedPlantBoss && NPC.downedPirates)
        {
          objArray1[index1].SetDefaults(937);
          ++index1;
        }
        if (Main.hardMode)
        {
          objArray1[index1].SetDefaults(1347);
          ++index1;
        }
        for (int index78 = 0; index78 < 58; ++index78)
        {
          if (Main.player[Main.myPlayer].inventory[index78].type == 4827)
          {
            objArray1[index1].SetDefaults(4827);
            ++index1;
            break;
          }
        }
        for (int index79 = 0; index79 < 58; ++index79)
        {
          if (Main.player[Main.myPlayer].inventory[index79].type == 4824)
          {
            objArray1[index1].SetDefaults(4824);
            ++index1;
            break;
          }
        }
        for (int index80 = 0; index80 < 58; ++index80)
        {
          if (Main.player[Main.myPlayer].inventory[index80].type == 4825)
          {
            objArray1[index1].SetDefaults(4825);
            ++index1;
            break;
          }
        }
        for (int index81 = 0; index81 < 58; ++index81)
        {
          if (Main.player[Main.myPlayer].inventory[index81].type == 4826)
          {
            objArray1[index1].SetDefaults(4826);
            ++index1;
            break;
          }
        }
        break;
      case 5:
        objArray1[index1].SetDefaults(254);
        int index82 = index1 + 1;
        objArray1[index82].SetDefaults(981);
        int index83 = index82 + 1;
        if (Main.player[Main.myPlayer].ZoneGraveyard)
        {
          objArray1[index83].SetDefaults(5577);
          ++index83;
        }
        else if (Main.dayTime)
        {
          objArray1[index83].SetDefaults(242);
          ++index83;
        }
        switch (Main.moonPhase)
        {
          case 0:
            objArray1[index83].SetDefaults(245);
            int index84 = index83 + 1;
            objArray1[index84].SetDefaults(246);
            index83 = index84 + 1;
            if (!Main.dayTime)
            {
              Item[] objArray46 = objArray1;
              int index85 = index83;
              int num31 = index85 + 1;
              objArray46[index85].SetDefaults(1288);
              Item[] objArray47 = objArray1;
              int index86 = num31;
              index83 = index86 + 1;
              objArray47[index86].SetDefaults(1289);
              break;
            }
            break;
          case 1:
            objArray1[index83].SetDefaults(325);
            int index87 = index83 + 1;
            objArray1[index87].SetDefaults(326);
            index83 = index87 + 1;
            break;
        }
        objArray1[index83].SetDefaults(269);
        int index88 = index83 + 1;
        objArray1[index88].SetDefaults(270);
        int index89 = index88 + 1;
        objArray1[index89].SetDefaults(271);
        int index90 = index89 + 1;
        if (NPC.downedClown)
        {
          objArray1[index90].SetDefaults(503);
          int index91 = index90 + 1;
          objArray1[index91].SetDefaults(504);
          int index92 = index91 + 1;
          objArray1[index92].SetDefaults(505);
          index90 = index92 + 1;
        }
        if (Main.bloodMoon)
        {
          objArray1[index90].SetDefaults(322);
          ++index90;
          if (!Main.dayTime)
          {
            Item[] objArray48 = objArray1;
            int index93 = index90;
            int num32 = index93 + 1;
            objArray48[index93].SetDefaults(3362);
            Item[] objArray49 = objArray1;
            int index94 = num32;
            index90 = index94 + 1;
            objArray49[index94].SetDefaults(3363);
          }
        }
        if (NPC.downedAncientCultist)
        {
          if (Main.dayTime)
          {
            Item[] objArray50 = objArray1;
            int index95 = index90;
            int num33 = index95 + 1;
            objArray50[index95].SetDefaults(2856);
            Item[] objArray51 = objArray1;
            int index96 = num33;
            index90 = index96 + 1;
            objArray51[index96].SetDefaults(2858);
          }
          else
          {
            Item[] objArray52 = objArray1;
            int index97 = index90;
            int num34 = index97 + 1;
            objArray52[index97].SetDefaults(2857);
            Item[] objArray53 = objArray1;
            int index98 = num34;
            index90 = index98 + 1;
            objArray53[index98].SetDefaults(2859);
          }
        }
        if (NPC.AnyNPCs(441))
        {
          Item[] objArray54 = objArray1;
          int index99 = index90;
          int num35 = index99 + 1;
          objArray54[index99].SetDefaults(3242);
          Item[] objArray55 = objArray1;
          int index100 = num35;
          int num36 = index100 + 1;
          objArray55[index100].SetDefaults(3243);
          Item[] objArray56 = objArray1;
          int index101 = num36;
          index90 = index101 + 1;
          objArray56[index101].SetDefaults(3244);
        }
        if (Main.player[Main.myPlayer].ZoneGraveyard)
        {
          Item[] objArray57 = objArray1;
          int index102 = index90;
          int num37 = index102 + 1;
          objArray57[index102].SetDefaults(4685);
          Item[] objArray58 = objArray1;
          int index103 = num37;
          int num38 = index103 + 1;
          objArray58[index103].SetDefaults(4686);
          Item[] objArray59 = objArray1;
          int index104 = num38;
          int num39 = index104 + 1;
          objArray59[index104].SetDefaults(4704);
          Item[] objArray60 = objArray1;
          int index105 = num39;
          int num40 = index105 + 1;
          objArray60[index105].SetDefaults(4705);
          Item[] objArray61 = objArray1;
          int index106 = num40;
          int num41 = index106 + 1;
          objArray61[index106].SetDefaults(4706);
          Item[] objArray62 = objArray1;
          int index107 = num41;
          int num42 = index107 + 1;
          objArray62[index107].SetDefaults(4707);
          Item[] objArray63 = objArray1;
          int index108 = num42;
          int num43 = index108 + 1;
          objArray63[index108].SetDefaults(4708);
          Item[] objArray64 = objArray1;
          int index109 = num43;
          index90 = index109 + 1;
          objArray64[index109].SetDefaults(4709);
        }
        if (Main.player[Main.myPlayer].ZoneSnow)
        {
          objArray1[index90].SetDefaults(1429);
          ++index90;
        }
        if (Main.halloween)
        {
          objArray1[index90].SetDefaults(1740);
          ++index90;
        }
        if (Main.hardMode)
        {
          if (Main.moonPhase == 2)
          {
            objArray1[index90].SetDefaults(869);
            ++index90;
          }
          if (Main.moonPhase == 3)
          {
            objArray1[index90].SetDefaults(4994);
            int index110 = index90 + 1;
            objArray1[index110].SetDefaults(4997);
            index90 = index110 + 1;
          }
          if (Main.moonPhase == 4)
          {
            objArray1[index90].SetDefaults(864);
            int index111 = index90 + 1;
            objArray1[index111].SetDefaults(865);
            index90 = index111 + 1;
          }
          if (Main.moonPhase == 5)
          {
            objArray1[index90].SetDefaults(4995);
            int index112 = index90 + 1;
            objArray1[index112].SetDefaults(4998);
            index90 = index112 + 1;
          }
          if (Main.moonPhase == 6)
          {
            objArray1[index90].SetDefaults(873);
            int index113 = index90 + 1;
            objArray1[index113].SetDefaults(874);
            int index114 = index113 + 1;
            objArray1[index114].SetDefaults(875);
            index90 = index114 + 1;
          }
          if (Main.moonPhase == 7)
          {
            objArray1[index90].SetDefaults(4996);
            int index115 = index90 + 1;
            objArray1[index115].SetDefaults(4999);
            index90 = index115 + 1;
          }
        }
        if (NPC.downedFrost)
        {
          if (Main.dayTime)
          {
            objArray1[index90].SetDefaults(1275);
            ++index90;
          }
          else
          {
            objArray1[index90].SetDefaults(1276);
            ++index90;
          }
        }
        if (Main.halloween)
        {
          Item[] objArray65 = objArray1;
          int index116 = index90;
          int num44 = index116 + 1;
          objArray65[index116].SetDefaults(3246);
          Item[] objArray66 = objArray1;
          int index117 = num44;
          index90 = index117 + 1;
          objArray66[index117].SetDefaults(3247);
        }
        if (BirthdayParty.PartyIsUp)
        {
          Item[] objArray67 = objArray1;
          int index118 = index90;
          int num45 = index118 + 1;
          objArray67[index118].SetDefaults(3730);
          Item[] objArray68 = objArray1;
          int index119 = num45;
          int num46 = index119 + 1;
          objArray68[index119].SetDefaults(3731);
          Item[] objArray69 = objArray1;
          int index120 = num46;
          int num47 = index120 + 1;
          objArray69[index120].SetDefaults(3733);
          Item[] objArray70 = objArray1;
          int index121 = num47;
          int num48 = index121 + 1;
          objArray70[index121].SetDefaults(3734);
          Item[] objArray71 = objArray1;
          int index122 = num48;
          index90 = index122 + 1;
          objArray71[index122].SetDefaults(3735);
        }
        int scoreAccumulated1 = Main.LocalPlayer.golferScoreAccumulated;
        if (index90 < 38 && scoreAccumulated1 >= 2000)
          objArray1[index90++].SetDefaults(4744);
        Item[] objArray72 = objArray1;
        int index123 = index90;
        index1 = index123 + 1;
        objArray72[index123].SetDefaults(5308);
        if (index1 < 38)
        {
          objArray1[index1++].SetDefaults(5630);
          break;
        }
        break;
      case 6:
        objArray1[index1].SetDefaults(128 /*0x80*/);
        int index124 = index1 + 1;
        objArray1[index124].SetDefaults(486);
        int index125 = index124 + 1;
        objArray1[index125].SetDefaults(398);
        int index126 = index125 + 1;
        objArray1[index126].SetDefaults(84);
        int index127 = index126 + 1;
        objArray1[index127].SetDefaults(407);
        int index128 = index127 + 1;
        objArray1[index128].SetDefaults(161);
        int num49 = index128 + 1;
        Item[] objArray73 = objArray1;
        int index129 = num49;
        index1 = index129 + 1;
        objArray73[index129].SetDefaults(5324);
        break;
      case 7:
        objArray1[index1].SetDefaults(487);
        int index130 = index1 + 1;
        objArray1[index130].SetDefaults(496);
        int index131 = index130 + 1;
        objArray1[index131].SetDefaults(500);
        int index132 = index131 + 1;
        objArray1[index132].SetDefaults(507);
        int index133 = index132 + 1;
        objArray1[index133].SetDefaults(508);
        int index134 = index133 + 1;
        objArray1[index134].SetDefaults(531);
        int index135 = index134 + 1;
        objArray1[index135].SetDefaults(149);
        int index136 = index135 + 1;
        objArray1[index136].SetDefaults(576);
        int index137 = index136 + 1;
        objArray1[index137].SetDefaults(3186);
        index1 = index137 + 1;
        if (Main.hardMode && Main.bloodMoon)
          objArray1[index1++].SetDefaults(5461);
        if (Main.halloween)
        {
          objArray1[index1].SetDefaults(1739);
          ++index1;
          break;
        }
        break;
      case 8:
        objArray1[index1].SetDefaults(509);
        int index138 = index1 + 1;
        objArray1[index138].SetDefaults(850);
        int index139 = index138 + 1;
        objArray1[index139].SetDefaults(851);
        int index140 = index139 + 1;
        objArray1[index140].SetDefaults(3612);
        int index141 = index140 + 1;
        objArray1[index141].SetDefaults(510);
        int index142 = index141 + 1;
        objArray1[index142].SetDefaults(530);
        int index143 = index142 + 1;
        objArray1[index143].SetDefaults(513);
        int index144 = index143 + 1;
        objArray1[index144].SetDefaults(538);
        int index145 = index144 + 1;
        objArray1[index145].SetDefaults(529);
        int index146 = index145 + 1;
        objArray1[index146].SetDefaults(541);
        int index147 = index146 + 1;
        objArray1[index147].SetDefaults(542);
        int index148 = index147 + 1;
        objArray1[index148].SetDefaults(543);
        int index149 = index148 + 1;
        objArray1[index149].SetDefaults(852);
        int index150 = index149 + 1;
        objArray1[index150].SetDefaults(853);
        int num50 = index150 + 1;
        Item[] objArray74 = objArray1;
        int index151 = num50;
        int num51 = index151 + 1;
        objArray74[index151].SetDefaults(4261);
        Item[] objArray75 = objArray1;
        int index152 = num51;
        int index153 = index152 + 1;
        objArray75[index152].SetDefaults(3707);
        objArray1[index153].SetDefaults(2739);
        int index154 = index153 + 1;
        objArray1[index154].SetDefaults(849);
        int num52 = index154 + 1;
        Item[] objArray76 = objArray1;
        int index155 = num52;
        int num53 = index155 + 1;
        objArray76[index155].SetDefaults(1263);
        Item[] objArray77 = objArray1;
        int index156 = num53;
        int num54 = index156 + 1;
        objArray77[index156].SetDefaults(3616);
        Item[] objArray78 = objArray1;
        int index157 = num54;
        int num55 = index157 + 1;
        objArray78[index157].SetDefaults(3725);
        Item[] objArray79 = objArray1;
        int index158 = num55;
        int num56 = index158 + 1;
        objArray79[index158].SetDefaults(2799);
        Item[] objArray80 = objArray1;
        int index159 = num56;
        int num57 = index159 + 1;
        objArray80[index159].SetDefaults(3619);
        Item[] objArray81 = objArray1;
        int index160 = num57;
        int num58 = index160 + 1;
        objArray81[index160].SetDefaults(3627);
        Item[] objArray82 = objArray1;
        int index161 = num58;
        int num59 = index161 + 1;
        objArray82[index161].SetDefaults(3629);
        Item[] objArray83 = objArray1;
        int index162 = num59;
        int num60 = index162 + 1;
        objArray83[index162].SetDefaults(585);
        Item[] objArray84 = objArray1;
        int index163 = num60;
        int num61 = index163 + 1;
        objArray84[index163].SetDefaults(584);
        Item[] objArray85 = objArray1;
        int index164 = num61;
        int num62 = index164 + 1;
        objArray85[index164].SetDefaults(583);
        Item[] objArray86 = objArray1;
        int index165 = num62;
        int num63 = index165 + 1;
        objArray86[index165].SetDefaults(4484);
        Item[] objArray87 = objArray1;
        int index166 = num63;
        index1 = index166 + 1;
        objArray87[index166].SetDefaults(4485);
        if (Main.player[Main.myPlayer].ZoneGraveyard)
        {
          objArray1[index1].SetDefaults(4409);
          ++index1;
        }
        if (NPC.AnyNPCs(369) && (Main.moonPhase == 1 || Main.moonPhase == 3 || Main.moonPhase == 5 || Main.moonPhase == 7))
        {
          objArray1[index1].SetDefaults(2295);
          ++index1;
          break;
        }
        break;
      case 9:
        objArray1[index1].SetDefaults(588);
        int index167 = index1 + 1;
        objArray1[index167].SetDefaults(589);
        int index168 = index167 + 1;
        objArray1[index168].SetDefaults(590);
        int index169 = index168 + 1;
        objArray1[index169].SetDefaults(597);
        int index170 = index169 + 1;
        objArray1[index170].SetDefaults(598);
        int index171 = index170 + 1;
        objArray1[index171].SetDefaults(596);
        index1 = index171 + 1;
        for (int Type = 1873; Type < 1906; ++Type)
        {
          objArray1[index1].SetDefaults(Type);
          ++index1;
        }
        break;
      case 10:
        if (NPC.downedMechBossAny)
        {
          objArray1[index1].SetDefaults(756);
          int index172 = index1 + 1;
          objArray1[index172].SetDefaults(787);
          index1 = index172 + 1;
        }
        objArray1[index1].SetDefaults(868);
        int index173 = index1 + 1;
        if (NPC.downedPlantBoss)
        {
          objArray1[index173].SetDefaults(1551);
          ++index173;
        }
        objArray1[index173].SetDefaults(1181);
        int num64 = index173 + 1;
        Item[] objArray88 = objArray1;
        int index174 = num64;
        index1 = index174 + 1;
        objArray88[index174].SetDefaults(5231);
        if (!Main.remixWorld || Main.tenthAnniversaryWorld && !Main.getGoodWorld)
        {
          objArray1[index1++].SetDefaults(783);
          break;
        }
        break;
      case 11:
        if (!Main.remixWorld || Main.tenthAnniversaryWorld && !Main.getGoodWorld)
          objArray1[index1++].SetDefaults(779);
        int num65;
        if (Main.moonPhase >= 4 && Main.hardMode)
        {
          Item[] objArray89 = objArray1;
          int index175 = index1;
          num65 = index175 + 1;
          objArray89[index175].SetDefaults(748);
        }
        else
        {
          Item[] objArray90 = objArray1;
          int index176 = index1;
          int num66 = index176 + 1;
          objArray90[index176].SetDefaults(839);
          Item[] objArray91 = objArray1;
          int index177 = num66;
          int num67 = index177 + 1;
          objArray91[index177].SetDefaults(840);
          Item[] objArray92 = objArray1;
          int index178 = num67;
          num65 = index178 + 1;
          objArray92[index178].SetDefaults(841);
        }
        if (NPC.downedGolemBoss)
          objArray1[num65++].SetDefaults(948);
        if (Main.hardMode)
          objArray1[num65++].SetDefaults(3623);
        Item[] objArray93 = objArray1;
        int index179 = num65;
        int num68 = index179 + 1;
        objArray93[index179].SetDefaults(3603);
        Item[] objArray94 = objArray1;
        int index180 = num68;
        int num69 = index180 + 1;
        objArray94[index180].SetDefaults(3604);
        Item[] objArray95 = objArray1;
        int index181 = num69;
        int num70 = index181 + 1;
        objArray95[index181].SetDefaults(3607);
        Item[] objArray96 = objArray1;
        int index182 = num70;
        int num71 = index182 + 1;
        objArray96[index182].SetDefaults(3605);
        Item[] objArray97 = objArray1;
        int index183 = num71;
        int num72 = index183 + 1;
        objArray97[index183].SetDefaults(3606);
        Item[] objArray98 = objArray1;
        int index184 = num72;
        int num73 = index184 + 1;
        objArray98[index184].SetDefaults(3608);
        Item[] objArray99 = objArray1;
        int index185 = num73;
        int num74 = index185 + 1;
        objArray99[index185].SetDefaults(3618);
        Item[] objArray100 = objArray1;
        int index186 = num74;
        int num75 = index186 + 1;
        objArray100[index186].SetDefaults(3602);
        Item[] objArray101 = objArray1;
        int index187 = num75;
        int num76 = index187 + 1;
        objArray101[index187].SetDefaults(3663);
        Item[] objArray102 = objArray1;
        int index188 = num76;
        int num77 = index188 + 1;
        objArray102[index188].SetDefaults(3609);
        Item[] objArray103 = objArray1;
        int index189 = num77;
        int num78 = index189 + 1;
        objArray103[index189].SetDefaults(3610);
        if (Main.hardMode || !Main.getGoodWorld)
          objArray1[num78++].SetDefaults(995);
        if (NPC.downedBoss1 && NPC.downedBoss2 && NPC.downedBoss3)
          objArray1[num78++].SetDefaults(2203);
        if (WorldGen.crimson)
        {
          Item[] objArray104 = objArray1;
          int index190 = num78;
          index1 = index190 + 1;
          objArray104[index190].SetDefaults(2193);
        }
        else
        {
          Item[] objArray105 = objArray1;
          int index191 = num78;
          index1 = index191 + 1;
          objArray105[index191].SetDefaults(4142);
        }
        if (Main.player[Main.myPlayer].ZoneGraveyard)
          objArray1[index1++].SetDefaults(2192);
        int num79 = Main.player[Main.myPlayer].ZoneJungle ? 1 : 0;
        if (num79 != 0)
          objArray1[index1++].SetDefaults(2204);
        if (num79 != 0 && NPC.downedGolemBoss)
          objArray1[index1++].SetDefaults(2195);
        if (Main.player[Main.myPlayer].ZoneSnow)
          objArray1[index1++].SetDefaults(2198);
        if ((double) Main.player[Main.myPlayer].position.Y / 16.0 < Main.worldSurface * 0.34999999403953552)
          objArray1[index1++].SetDefaults(2197);
        if (!Main.remixWorld || Main.tenthAnniversaryWorld && !Main.getGoodWorld)
        {
          if (Main.eclipse || Main.bloodMoon)
          {
            if (WorldGen.crimson)
              objArray1[index1++].SetDefaults(784);
            else
              objArray1[index1++].SetDefaults(782);
          }
          else if (Main.player[Main.myPlayer].ZoneHallow)
            objArray1[index1++].SetDefaults(781);
          else
            objArray1[index1++].SetDefaults(780);
          if (NPC.downedMoonlord)
          {
            Item[] objArray106 = objArray1;
            int index192 = index1;
            int num80 = index192 + 1;
            objArray106[index192].SetDefaults(5392);
            Item[] objArray107 = objArray1;
            int index193 = num80;
            int num81 = index193 + 1;
            objArray107[index193].SetDefaults(5393);
            Item[] objArray108 = objArray1;
            int index194 = num81;
            index1 = index194 + 1;
            objArray108[index194].SetDefaults(5394);
          }
        }
        if (Main.hardMode)
        {
          Item[] objArray109 = objArray1;
          int index195 = index1;
          int num82 = index195 + 1;
          objArray109[index195].SetDefaults(1344);
          Item[] objArray110 = objArray1;
          int index196 = num82;
          index1 = index196 + 1;
          objArray110[index196].SetDefaults(4472);
        }
        if (Main.halloween)
        {
          objArray1[index1++].SetDefaults(1742);
          break;
        }
        break;
      case 12:
        Item[] objArray111 = objArray1;
        int index197 = index1;
        int num83 = index197 + 1;
        objArray111[index197].SetDefaults(1120);
        Item[] objArray112 = objArray1;
        int index198 = num83;
        int num84 = index198 + 1;
        objArray112[index198].SetDefaults(5920);
        if (Main.halloween)
        {
          Item[] objArray113 = objArray1;
          int index199 = num84;
          int num85 = index199 + 1;
          objArray113[index199].SetDefaults(3248);
          Item[] objArray114 = objArray1;
          int index200 = num85;
          num84 = index200 + 1;
          objArray114[index200].SetDefaults(1741);
        }
        Item[] objArray115 = objArray1;
        int index201 = num84;
        int num86 = index201 + 1;
        objArray115[index201].SetDefaults(1037);
        Item[] objArray116 = objArray1;
        int index202 = num86;
        index1 = index202 + 1;
        objArray116[index202].SetDefaults(2874);
        if (Main.netMode == 1)
          objArray1[index1++].SetDefaults(1969);
        if (Main.moonPhase == 0)
        {
          Item[] objArray117 = objArray1;
          int index203 = index1;
          int num87 = index203 + 1;
          objArray117[index203].SetDefaults(2871);
          Item[] objArray118 = objArray1;
          int index204 = num87;
          index1 = index204 + 1;
          objArray118[index204].SetDefaults(2872);
        }
        if (!Main.dayTime && Main.bloodMoon)
          objArray1[index1++].SetDefaults(4663);
        if (Main.player[Main.myPlayer].ZoneGraveyard)
        {
          objArray1[index1++].SetDefaults(4662);
          break;
        }
        break;
      case 13:
        objArray1[index1].SetDefaults(859);
        int index205 = index1 + 1;
        if (Main.LocalPlayer.golferScoreAccumulated > 500)
          objArray1[index205++].SetDefaults(4743);
        objArray1[index205].SetDefaults(1000);
        int index206 = index205 + 1;
        objArray1[index206].SetDefaults(1168);
        int index207 = index206 + 1;
        int index208;
        if (Main.dayTime)
        {
          objArray1[index207].SetDefaults(1449);
          index208 = index207 + 1;
        }
        else
        {
          objArray1[index207].SetDefaults(4552);
          index208 = index207 + 1;
        }
        objArray1[index208].SetDefaults(1345);
        int index209 = index208 + 1;
        objArray1[index209].SetDefaults(1450);
        int num88 = index209 + 1;
        Item[] objArray119 = objArray1;
        int index210 = num88;
        int num89 = index210 + 1;
        objArray119[index210].SetDefaults(3253);
        Item[] objArray120 = objArray1;
        int index211 = num89;
        int num90 = index211 + 1;
        objArray120[index211].SetDefaults(4553);
        Item[] objArray121 = objArray1;
        int index212 = num90;
        int num91 = index212 + 1;
        objArray121[index212].SetDefaults(2700);
        Item[] objArray122 = objArray1;
        int index213 = num91;
        int num92 = index213 + 1;
        objArray122[index213].SetDefaults(2738);
        Item[] objArray123 = objArray1;
        int index214 = num92;
        int num93 = index214 + 1;
        objArray123[index214].SetDefaults(4470);
        Item[] objArray124 = objArray1;
        int index215 = num93;
        int index216 = index215 + 1;
        objArray124[index215].SetDefaults(4681);
        if (Main.player[Main.myPlayer].ZoneGraveyard)
          objArray1[index216++].SetDefaults(4682);
        if (LanternNight.LanternsUp)
          objArray1[index216++].SetDefaults(4702);
        if (Main.player[Main.myPlayer].HasItem(3548))
        {
          objArray1[index216].SetDefaults(3548);
          ++index216;
        }
        if (NPC.AnyNPCs(229))
          objArray1[index216++].SetDefaults(3369);
        if (NPC.downedGolemBoss)
          objArray1[index216++].SetDefaults(3546);
        if (Main.hardMode)
        {
          objArray1[index216].SetDefaults(3214);
          int index217 = index216 + 1;
          objArray1[index217].SetDefaults(2868);
          int index218 = index217 + 1;
          objArray1[index218].SetDefaults(970);
          int index219 = index218 + 1;
          objArray1[index219].SetDefaults(971);
          int index220 = index219 + 1;
          objArray1[index220].SetDefaults(972);
          int index221 = index220 + 1;
          objArray1[index221].SetDefaults(973);
          index216 = index221 + 1;
        }
        Item[] objArray125 = objArray1;
        int index222 = index216;
        int num94 = index222 + 1;
        objArray125[index222].SetDefaults(4791);
        Item[] objArray126 = objArray1;
        int index223 = num94;
        int num95 = index223 + 1;
        objArray126[index223].SetDefaults(3747);
        Item[] objArray127 = objArray1;
        int index224 = num95;
        int num96 = index224 + 1;
        objArray127[index224].SetDefaults(3732);
        Item[] objArray128 = objArray1;
        int index225 = num96;
        index1 = index225 + 1;
        objArray128[index225].SetDefaults(3742);
        if (BirthdayParty.PartyIsUp)
        {
          Item[] objArray129 = objArray1;
          int index226 = index1;
          int num97 = index226 + 1;
          objArray129[index226].SetDefaults(3749);
          Item[] objArray130 = objArray1;
          int index227 = num97;
          int num98 = index227 + 1;
          objArray130[index227].SetDefaults(3746);
          Item[] objArray131 = objArray1;
          int index228 = num98;
          int num99 = index228 + 1;
          objArray131[index228].SetDefaults(3739);
          Item[] objArray132 = objArray1;
          int index229 = num99;
          int num100 = index229 + 1;
          objArray132[index229].SetDefaults(3740);
          Item[] objArray133 = objArray1;
          int index230 = num100;
          int num101 = index230 + 1;
          objArray133[index230].SetDefaults(3741);
          Item[] objArray134 = objArray1;
          int index231 = num101;
          int num102 = index231 + 1;
          objArray134[index231].SetDefaults(3737);
          Item[] objArray135 = objArray1;
          int index232 = num102;
          int num103 = index232 + 1;
          objArray135[index232].SetDefaults(3738);
          Item[] objArray136 = objArray1;
          int index233 = num103;
          int num104 = index233 + 1;
          objArray136[index233].SetDefaults(3736);
          Item[] objArray137 = objArray1;
          int index234 = num104;
          int num105 = index234 + 1;
          objArray137[index234].SetDefaults(3745);
          Item[] objArray138 = objArray1;
          int index235 = num105;
          int num106 = index235 + 1;
          objArray138[index235].SetDefaults(3744);
          Item[] objArray139 = objArray1;
          int index236 = num106;
          index1 = index236 + 1;
          objArray139[index236].SetDefaults(3743);
          break;
        }
        break;
      case 14:
        objArray1[index1].SetDefaults(771);
        int index237 = index1 + 1;
        if (Main.bloodMoon)
        {
          objArray1[index237].SetDefaults(772);
          ++index237;
        }
        if (!Main.dayTime || Main.eclipse)
        {
          objArray1[index237].SetDefaults(773);
          ++index237;
        }
        if (Main.eclipse)
        {
          objArray1[index237].SetDefaults(774);
          ++index237;
        }
        if (NPC.downedMartians)
        {
          objArray1[index237++].SetDefaults(4445);
          if (Main.bloodMoon || Main.eclipse)
            objArray1[index237++].SetDefaults(4446);
        }
        if (Main.hardMode)
        {
          objArray1[index237].SetDefaults(4459);
          ++index237;
        }
        if (Main.hardMode)
        {
          objArray1[index237].SetDefaults(760);
          ++index237;
        }
        if (Main.hardMode)
        {
          objArray1[index237].SetDefaults(1346);
          ++index237;
        }
        if (Main.hardMode)
        {
          Item[] objArray140 = objArray1;
          int index238 = index237;
          int num107 = index238 + 1;
          objArray140[index238].SetDefaults(5452);
          Item[] objArray141 = objArray1;
          int index239 = num107;
          int num108 = index239 + 1;
          objArray141[index239].SetDefaults(5451);
          Item[] objArray142 = objArray1;
          int index240 = num108;
          index237 = index240 + 1;
          objArray142[index240].SetDefaults(5738);
        }
        objArray1[index237].SetDefaults(5598);
        int index241 = index237 + 1;
        objArray1[index241].SetDefaults(5599);
        int index242 = index241 + 1;
        if (Main.player[Main.myPlayer].ZoneGraveyard)
        {
          objArray1[index242].SetDefaults(4409);
          ++index242;
        }
        if (Main.player[Main.myPlayer].ZoneGraveyard)
        {
          objArray1[index242].SetDefaults(4392);
          ++index242;
        }
        if (Main.halloween)
        {
          objArray1[index242].SetDefaults(1743);
          int index243 = index242 + 1;
          objArray1[index243].SetDefaults(1744);
          int index244 = index243 + 1;
          objArray1[index244].SetDefaults(1745);
          index242 = index244 + 1;
        }
        if (NPC.downedMartians)
        {
          Item[] objArray143 = objArray1;
          int index245 = index242;
          int num109 = index245 + 1;
          objArray143[index245].SetDefaults(2862);
          Item[] objArray144 = objArray1;
          int index246 = num109;
          index242 = index246 + 1;
          objArray144[index246].SetDefaults(3109);
        }
        if (Main.player[Main.myPlayer].HasItem(3384) || Main.player[Main.myPlayer].HasItem(3664))
        {
          objArray1[index242].SetDefaults(3664);
          ++index242;
        }
        objArray1[index242].SetDefaults(5928);
        index1 = index242 + 1;
        break;
      case 15:
        objArray1[index1].SetDefaults(1071);
        int index247 = index1 + 1;
        objArray1[index247].SetDefaults(1072);
        int index248 = index247 + 1;
        objArray1[index248].SetDefaults(1100);
        int index249 = index248 + 1;
        for (int Type = 1073; Type <= 1084; ++Type)
        {
          objArray1[index249].SetDefaults(Type);
          ++index249;
        }
        objArray1[index249].SetDefaults(1097);
        int index250 = index249 + 1;
        objArray1[index250].SetDefaults(1099);
        int index251 = index250 + 1;
        objArray1[index251].SetDefaults(1098);
        int index252 = index251 + 1;
        objArray1[index252].SetDefaults(1966);
        index1 = index252 + 1;
        if (Main.hardMode)
        {
          objArray1[index1].SetDefaults(1967);
          int index253 = index1 + 1;
          objArray1[index253].SetDefaults(1968);
          index1 = index253 + 1;
        }
        if (Main.player[Main.myPlayer].ZoneGraveyard)
        {
          objArray1[index1].SetDefaults(4668);
          ++index1;
          if (NPC.downedPlantBoss || NPC.AnyNPCs(124))
          {
            objArray1[index1].SetDefaults(5344);
            ++index1;
            break;
          }
          break;
        }
        break;
      case 16 /*0x10*/:
        Item[] objArray145 = objArray1;
        int index254 = index1;
        int num110 = index254 + 1;
        objArray145[index254].SetDefaults(1430);
        Item[] objArray146 = objArray1;
        int index255 = num110;
        int num111 = index255 + 1;
        objArray146[index255].SetDefaults(986);
        if (NPC.AnyNPCs(108))
          objArray1[num111++].SetDefaults(2999);
        if (!Main.dayTime)
          objArray1[num111++].SetDefaults(1158);
        if (Main.hardMode && NPC.downedPlantBoss)
        {
          Item[] objArray147 = objArray1;
          int index256 = num111;
          int num112 = index256 + 1;
          objArray147[index256].SetDefaults(1159);
          Item[] objArray148 = objArray1;
          int index257 = num112;
          int num113 = index257 + 1;
          objArray148[index257].SetDefaults(1160);
          Item[] objArray149 = objArray1;
          int index258 = num113;
          int num114 = index258 + 1;
          objArray149[index258].SetDefaults(1161);
          if (Main.player[Main.myPlayer].ZoneJungle)
            objArray1[num114++].SetDefaults(1167);
          Item[] objArray150 = objArray1;
          int index259 = num114;
          num111 = index259 + 1;
          objArray150[index259].SetDefaults(1339);
        }
        if (Main.hardMode && Main.player[Main.myPlayer].ZoneJungle)
        {
          objArray1[num111++].SetDefaults(1171);
          if (!Main.dayTime && NPC.downedPlantBoss)
            objArray1[num111++].SetDefaults(1162);
        }
        Item[] objArray151 = objArray1;
        int index260 = num111;
        int num115 = index260 + 1;
        objArray151[index260].SetDefaults(909);
        Item[] objArray152 = objArray1;
        int index261 = num115;
        int num116 = index261 + 1;
        objArray152[index261].SetDefaults(910);
        Item[] objArray153 = objArray1;
        int index262 = num116;
        int num117 = index262 + 1;
        objArray153[index262].SetDefaults(940);
        Item[] objArray154 = objArray1;
        int index263 = num117;
        int num118 = index263 + 1;
        objArray154[index263].SetDefaults(941);
        Item[] objArray155 = objArray1;
        int index264 = num118;
        int num119 = index264 + 1;
        objArray155[index264].SetDefaults(942);
        Item[] objArray156 = objArray1;
        int index265 = num119;
        int num120 = index265 + 1;
        objArray156[index265].SetDefaults(943);
        Item[] objArray157 = objArray1;
        int index266 = num120;
        int num121 = index266 + 1;
        objArray157[index266].SetDefaults(944);
        Item[] objArray158 = objArray1;
        int index267 = num121;
        int num122 = index267 + 1;
        objArray158[index267].SetDefaults(945);
        Item[] objArray159 = objArray1;
        int index268 = num122;
        int num123 = index268 + 1;
        objArray159[index268].SetDefaults(4922);
        Item[] objArray160 = objArray1;
        int index269 = num123;
        index1 = index269 + 1;
        objArray160[index269].SetDefaults(4417);
        if (Main.player[Main.myPlayer].HasItem(1835))
          objArray1[index1++].SetDefaults(1836);
        if (Main.player[Main.myPlayer].HasItem(1258))
          objArray1[index1++].SetDefaults(1261);
        if (Main.halloween)
        {
          objArray1[index1++].SetDefaults(1791 /*0x06FF*/);
          break;
        }
        break;
      case 17:
        objArray1[index1].SetDefaults(928);
        int index270 = index1 + 1;
        objArray1[index270].SetDefaults(929);
        int index271 = index270 + 1;
        objArray1[index271].SetDefaults(876);
        int index272 = index271 + 1;
        objArray1[index272].SetDefaults(877);
        int index273 = index272 + 1;
        objArray1[index273].SetDefaults(878);
        int num124 = index273 + 1;
        Item[] objArray161 = objArray1;
        int index274 = num124;
        index1 = index274 + 1;
        objArray161[index274].SetDefaults(2434);
        if (Main.player[Main.myPlayer].ZoneGraveyard)
          objArray1[index1++].SetDefaults(5926);
        int num125 = (int) (((double) Main.screenPosition.X + (double) (Main.screenWidth / 2)) / 16.0);
        if ((double) Main.screenPosition.Y / 16.0 < Main.worldSurface + 10.0 && (num125 < 380 || num125 > Main.maxTilesX - 380))
        {
          objArray1[index1].SetDefaults(1180);
          ++index1;
        }
        if (Main.hardMode && NPC.downedMechBossAny && NPC.AnyNPCs(208 /*0xD0*/))
        {
          objArray1[index1].SetDefaults(1337);
          ++index1;
          break;
        }
        break;
      case 18:
        objArray1[index1].SetDefaults(1990);
        int index275 = index1 + 1;
        objArray1[index275].SetDefaults(1979);
        int index276 = index275 + 1;
        if (Main.player[Main.myPlayer].statLifeMax >= 400)
        {
          objArray1[index276].SetDefaults(1977);
          ++index276;
        }
        if (Main.player[Main.myPlayer].statManaMax >= 200)
        {
          objArray1[index276].SetDefaults(1978);
          ++index276;
        }
        long num126 = 0;
        for (int index277 = 0; index277 < 54; ++index277)
        {
          if (Main.player[Main.myPlayer].inventory[index277].type == 71)
            num126 += (long) Main.player[Main.myPlayer].inventory[index277].stack;
          if (Main.player[Main.myPlayer].inventory[index277].type == 72)
            num126 += (long) (Main.player[Main.myPlayer].inventory[index277].stack * 100);
          if (Main.player[Main.myPlayer].inventory[index277].type == 73)
            num126 += (long) (Main.player[Main.myPlayer].inventory[index277].stack * 10000);
          if (Main.player[Main.myPlayer].inventory[index277].type == 74)
            num126 += (long) (Main.player[Main.myPlayer].inventory[index277].stack * 1000000);
        }
        if (num126 >= 1000000L)
        {
          objArray1[index276].SetDefaults(1980);
          ++index276;
        }
        if (Main.moonPhase % 2 == 0 && Main.dayTime || Main.moonPhase % 2 == 1 && !Main.dayTime)
        {
          objArray1[index276].SetDefaults(1981);
          ++index276;
        }
        if (Main.player[Main.myPlayer].team != 0 && Main.netMode == 1)
        {
          objArray1[index276].SetDefaults(1982);
          ++index276;
        }
        if (Main.hardMode)
        {
          objArray1[index276].SetDefaults(1983);
          ++index276;
        }
        if (NPC.AnyNPCs(208 /*0xD0*/))
        {
          objArray1[index276].SetDefaults(1984);
          ++index276;
        }
        if (Main.hardMode && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
        {
          objArray1[index276].SetDefaults(1985);
          ++index276;
        }
        if (Main.hardMode && NPC.downedMechBossAny)
        {
          objArray1[index276].SetDefaults(1986);
          ++index276;
        }
        if (Main.hardMode && NPC.downedMartians)
        {
          objArray1[index276].SetDefaults(2863);
          int index278 = index276 + 1;
          objArray1[index278].SetDefaults(3259);
          index276 = index278 + 1;
        }
        Item[] objArray162 = objArray1;
        int index279 = index276;
        index1 = index279 + 1;
        objArray162[index279].SetDefaults(5104);
        break;
      case 19:
        Player localPlayer = Main.LocalPlayer;
        if ((localPlayer.HasItemInAnyInventory(5667) || localPlayer.HasItemInAnyInventory(5663) || localPlayer.HasItemInAnyInventory(5664) || localPlayer.HasItemInAnyInventory(5665) ? 1 : (localPlayer.HasItemInAnyInventory(5666) ? 1 : 0)) != 0)
        {
          objArray1[index1].SetDefaults(5735);
          int index280 = index1 + 1;
          objArray1[index280].SetDefaults(5736);
          index1 = index280 + 1;
        }
        for (int index281 = 0; index281 < this.maxItems; ++index281)
        {
          if (Main.travelShop[index281] != 0)
          {
            objArray1[index1].SetDefaults(Main.travelShop[index281]);
            ++index1;
          }
        }
        break;
      case 20:
        if (Main.moonPhase == 0)
        {
          objArray1[index1].SetDefaults(284);
          ++index1;
        }
        if (Main.moonPhase == 1)
        {
          objArray1[index1].SetDefaults(946);
          ++index1;
        }
        if (Main.moonPhase == 2 && !Main.remixWorld)
        {
          objArray1[index1].SetDefaults(3069);
          ++index1;
        }
        if (Main.moonPhase == 2 && Main.remixWorld)
        {
          objArray1[index1].SetDefaults(517);
          ++index1;
        }
        if (Main.moonPhase == 3)
        {
          objArray1[index1].SetDefaults(4341);
          ++index1;
        }
        if (Main.moonPhase == 4)
        {
          objArray1[index1].SetDefaults(285);
          ++index1;
        }
        if (Main.moonPhase == 5)
        {
          objArray1[index1].SetDefaults(953);
          ++index1;
        }
        if (Main.moonPhase == 6)
        {
          objArray1[index1].SetDefaults(3068);
          ++index1;
        }
        if (Main.moonPhase == 7)
        {
          objArray1[index1].SetDefaults(3084);
          ++index1;
        }
        if (Main.moonPhase % 2 == 0)
        {
          objArray1[index1].SetDefaults(3001);
          ++index1;
        }
        if (Main.moonPhase % 2 != 0)
        {
          objArray1[index1].SetDefaults(28);
          ++index1;
        }
        if (Main.moonPhase % 2 != 0 && Main.hardMode)
        {
          objArray1[index1].SetDefaults(188);
          ++index1;
        }
        if (!Main.dayTime || Main.moonPhase == 0)
        {
          objArray1[index1].SetDefaults(3002);
          ++index1;
          if (Main.player[Main.myPlayer].HasItem(930))
          {
            objArray1[index1].SetDefaults(5377);
            ++index1;
          }
        }
        else if (Main.dayTime && Main.moonPhase != 0)
        {
          objArray1[index1].SetDefaults(282);
          ++index1;
        }
        if (Main.time % 60.0 * 60.0 * 6.0 <= 10800.0)
          objArray1[index1].SetDefaults(3004);
        else
          objArray1[index1].SetDefaults(8);
        int index282 = index1 + 1;
        if (Main.moonPhase == 0 || Main.moonPhase == 1 || Main.moonPhase == 4 || Main.moonPhase == 5)
          objArray1[index282].SetDefaults(3003);
        else
          objArray1[index282].SetDefaults(40);
        int num127 = index282 + 1;
        int index283;
        if (Main.moonPhase % 4 == 0)
        {
          Item[] objArray163 = objArray1;
          int index284 = num127;
          index283 = index284 + 1;
          objArray163[index284].SetDefaults(3310);
        }
        else if (Main.moonPhase % 4 == 1)
        {
          Item[] objArray164 = objArray1;
          int index285 = num127;
          index283 = index285 + 1;
          objArray164[index285].SetDefaults(3313);
        }
        else if (Main.moonPhase % 4 == 2)
        {
          Item[] objArray165 = objArray1;
          int index286 = num127;
          index283 = index286 + 1;
          objArray165[index286].SetDefaults(3312);
        }
        else
        {
          Item[] objArray166 = objArray1;
          int index287 = num127;
          index283 = index287 + 1;
          objArray166[index287].SetDefaults(3311);
        }
        switch (Main.moonPhase)
        {
          case 1:
          case 2:
            objArray1[index283++].SetDefaults(5640);
            break;
          case 3:
          case 5:
            objArray1[index283++].SetDefaults(5641);
            break;
          case 6:
          case 7:
            objArray1[index283++].SetDefaults(5642);
            break;
        }
        objArray1[index283].SetDefaults(166);
        int index288 = index283 + 1;
        objArray1[index288].SetDefaults(965);
        index1 = index288 + 1;
        if (Main.hardMode)
        {
          if (Main.moonPhase < 4)
            objArray1[index1].SetDefaults(3316);
          else
            objArray1[index1].SetDefaults(3315);
          int index289 = index1 + 1;
          objArray1[index289].SetDefaults(3334);
          index1 = index289 + 1;
          if (NPC.downedMechBossAny)
          {
            objArray1[index1].SetDefaults(5540);
            ++index1;
          }
          if (Main.bloodMoon)
          {
            objArray1[index1].SetDefaults(3258);
            ++index1;
          }
        }
        if (Main.moonPhase == 0 && !Main.dayTime)
        {
          objArray1[index1].SetDefaults(3043);
          ++index1;
        }
        if (!Main.player[Main.myPlayer].ateArtisanBread && Main.moonPhase >= 3 && Main.moonPhase <= 5)
        {
          objArray1[index1].SetDefaults(5326);
          ++index1;
          break;
        }
        break;
      case 21:
        bool flag1 = Main.hardMode && NPC.downedMechBossAny;
        int num128 = !Main.hardMode ? 0 : (NPC.downedGolemBoss ? 1 : 0);
        objArray1[index1].SetDefaults(353);
        int index290 = index1 + 1;
        objArray1[index290].SetDefaults(3828);
        objArray1[index290].shopCustomPrice = num128 == 0 ? (!flag1 ? new int?(Item.buyPrice(silver: 25)) : new int?(Item.buyPrice(gold: 1))) : new int?(Item.buyPrice(gold: 4));
        int index291 = index290 + 1;
        objArray1[index291].SetDefaults(3816);
        int index292 = index291 + 1;
        objArray1[index292].SetDefaults(3813);
        objArray1[index292].shopCustomPrice = new int?(50);
        objArray1[index292].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
        int num129 = index292 + 1;
        int index293 = 10;
        objArray1[index293].SetDefaults(3818);
        objArray1[index293].shopCustomPrice = new int?(5);
        objArray1[index293].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
        int index294 = index293 + 1;
        objArray1[index294].SetDefaults(3824);
        objArray1[index294].shopCustomPrice = new int?(5);
        objArray1[index294].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
        int index295 = index294 + 1;
        objArray1[index295].SetDefaults(3832);
        objArray1[index295].shopCustomPrice = new int?(5);
        objArray1[index295].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
        int index296 = index295 + 1;
        objArray1[index296].SetDefaults(3829);
        objArray1[index296].shopCustomPrice = new int?(5);
        objArray1[index296].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
        if (flag1)
        {
          int index297 = 20;
          objArray1[index297].SetDefaults(3819);
          objArray1[index297].shopCustomPrice = new int?(15);
          objArray1[index297].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index298 = index297 + 1;
          objArray1[index298].SetDefaults(3825);
          objArray1[index298].shopCustomPrice = new int?(15);
          objArray1[index298].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index299 = index298 + 1;
          objArray1[index299].SetDefaults(3833);
          objArray1[index299].shopCustomPrice = new int?(15);
          objArray1[index299].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index300 = index299 + 1;
          objArray1[index300].SetDefaults(3830);
          objArray1[index300].shopCustomPrice = new int?(15);
          objArray1[index300].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
        }
        if (num128 != 0)
        {
          int index301 = 30;
          objArray1[index301].SetDefaults(3820);
          objArray1[index301].shopCustomPrice = new int?(60);
          objArray1[index301].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index302 = index301 + 1;
          objArray1[index302].SetDefaults(3826);
          objArray1[index302].shopCustomPrice = new int?(60);
          objArray1[index302].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index303 = index302 + 1;
          objArray1[index303].SetDefaults(3834);
          objArray1[index303].shopCustomPrice = new int?(60);
          objArray1[index303].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index304 = index303 + 1;
          objArray1[index304].SetDefaults(3831);
          objArray1[index304].shopCustomPrice = new int?(60);
          objArray1[index304].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
        }
        if (flag1)
        {
          int index305 = 4;
          objArray1[index305].SetDefaults(3800);
          objArray1[index305].shopCustomPrice = new int?(15);
          objArray1[index305].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index306 = index305 + 1;
          objArray1[index306].SetDefaults(3801);
          objArray1[index306].shopCustomPrice = new int?(15);
          objArray1[index306].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index307 = index306 + 1;
          objArray1[index307].SetDefaults(3802);
          objArray1[index307].shopCustomPrice = new int?(15);
          objArray1[index307].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num129 = index307 + 1;
          int index308 = 14;
          objArray1[index308].SetDefaults(3797);
          objArray1[index308].shopCustomPrice = new int?(15);
          objArray1[index308].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index309 = index308 + 1;
          objArray1[index309].SetDefaults(3798);
          objArray1[index309].shopCustomPrice = new int?(15);
          objArray1[index309].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index310 = index309 + 1;
          objArray1[index310].SetDefaults(3799);
          objArray1[index310].shopCustomPrice = new int?(15);
          objArray1[index310].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num129 = index310 + 1;
          int index311 = 24;
          objArray1[index311].SetDefaults(3803);
          objArray1[index311].shopCustomPrice = new int?(15);
          objArray1[index311].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index312 = index311 + 1;
          objArray1[index312].SetDefaults(3804);
          objArray1[index312].shopCustomPrice = new int?(15);
          objArray1[index312].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index313 = index312 + 1;
          objArray1[index313].SetDefaults(3805);
          objArray1[index313].shopCustomPrice = new int?(15);
          objArray1[index313].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num129 = index313 + 1;
          int index314 = 34;
          objArray1[index314].SetDefaults(3806);
          objArray1[index314].shopCustomPrice = new int?(15);
          objArray1[index314].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index315 = index314 + 1;
          objArray1[index315].SetDefaults(3807);
          objArray1[index315].shopCustomPrice = new int?(15);
          objArray1[index315].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index316 = index315 + 1;
          objArray1[index316].SetDefaults(3808);
          objArray1[index316].shopCustomPrice = new int?(15);
          objArray1[index316].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num129 = index316 + 1;
        }
        if (num128 != 0)
        {
          int index317 = 7;
          objArray1[index317].SetDefaults(3871);
          objArray1[index317].shopCustomPrice = new int?(50);
          objArray1[index317].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index318 = index317 + 1;
          objArray1[index318].SetDefaults(3872);
          objArray1[index318].shopCustomPrice = new int?(50);
          objArray1[index318].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index319 = index318 + 1;
          objArray1[index319].SetDefaults(3873);
          objArray1[index319].shopCustomPrice = new int?(50);
          objArray1[index319].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num129 = index319 + 1;
          int index320 = 17;
          objArray1[index320].SetDefaults(3874);
          objArray1[index320].shopCustomPrice = new int?(50);
          objArray1[index320].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index321 = index320 + 1;
          objArray1[index321].SetDefaults(3875);
          objArray1[index321].shopCustomPrice = new int?(50);
          objArray1[index321].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index322 = index321 + 1;
          objArray1[index322].SetDefaults(3876);
          objArray1[index322].shopCustomPrice = new int?(50);
          objArray1[index322].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num129 = index322 + 1;
          int index323 = 27;
          objArray1[index323].SetDefaults(3877);
          objArray1[index323].shopCustomPrice = new int?(50);
          objArray1[index323].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index324 = index323 + 1;
          objArray1[index324].SetDefaults(3878);
          objArray1[index324].shopCustomPrice = new int?(50);
          objArray1[index324].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index325 = index324 + 1;
          objArray1[index325].SetDefaults(3879);
          objArray1[index325].shopCustomPrice = new int?(50);
          objArray1[index325].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num129 = index325 + 1;
          int index326 = 37;
          objArray1[index326].SetDefaults(3880);
          objArray1[index326].shopCustomPrice = new int?(50);
          objArray1[index326].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index327 = index326 + 1;
          objArray1[index327].SetDefaults(3881);
          objArray1[index327].shopCustomPrice = new int?(50);
          objArray1[index327].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          int index328 = index327 + 1;
          objArray1[index328].SetDefaults(3882);
          objArray1[index328].shopCustomPrice = new int?(50);
          objArray1[index328].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
          num129 = index328 + 1;
        }
        index1 = num128 == 0 ? (!flag1 ? 4 : 30) : 40;
        break;
      case 22:
        Item[] objArray167 = objArray1;
        int index329 = index1;
        int num130 = index329 + 1;
        objArray167[index329].SetDefaults(4587);
        Item[] objArray168 = objArray1;
        int index330 = num130;
        int num131 = index330 + 1;
        objArray168[index330].SetDefaults(4590);
        Item[] objArray169 = objArray1;
        int index331 = num131;
        int num132 = index331 + 1;
        objArray169[index331].SetDefaults(4589);
        Item[] objArray170 = objArray1;
        int index332 = num132;
        int num133 = index332 + 1;
        objArray170[index332].SetDefaults(4588);
        Item[] objArray171 = objArray1;
        int index333 = num133;
        int num134 = index333 + 1;
        objArray171[index333].SetDefaults(4083);
        Item[] objArray172 = objArray1;
        int index334 = num134;
        int num135 = index334 + 1;
        objArray172[index334].SetDefaults(4084);
        Item[] objArray173 = objArray1;
        int index335 = num135;
        int num136 = index335 + 1;
        objArray173[index335].SetDefaults(4085);
        Item[] objArray174 = objArray1;
        int index336 = num136;
        int num137 = index336 + 1;
        objArray174[index336].SetDefaults(4086);
        Item[] objArray175 = objArray1;
        int index337 = num137;
        int num138 = index337 + 1;
        objArray175[index337].SetDefaults(4087);
        Item[] objArray176 = objArray1;
        int index338 = num138;
        int index339 = index338 + 1;
        objArray176[index338].SetDefaults(4088);
        int scoreAccumulated2 = Main.LocalPlayer.golferScoreAccumulated;
        if (scoreAccumulated2 > 500)
        {
          objArray1[index339].SetDefaults(4039);
          int index340 = index339 + 1;
          objArray1[index340].SetDefaults(4094);
          int index341 = index340 + 1;
          objArray1[index341].SetDefaults(4093);
          int index342 = index341 + 1;
          objArray1[index342].SetDefaults(4092);
          index339 = index342 + 1;
        }
        Item[] objArray177 = objArray1;
        int index343 = index339;
        int num139 = index343 + 1;
        objArray177[index343].SetDefaults(4089);
        Item[] objArray178 = objArray1;
        int index344 = num139;
        int num140 = index344 + 1;
        objArray178[index344].SetDefaults(3989);
        Item[] objArray179 = objArray1;
        int index345 = num140;
        int num141 = index345 + 1;
        objArray179[index345].SetDefaults(4095 /*0x0FFF*/);
        Item[] objArray180 = objArray1;
        int index346 = num141;
        int num142 = index346 + 1;
        objArray180[index346].SetDefaults(4040);
        Item[] objArray181 = objArray1;
        int index347 = num142;
        int num143 = index347 + 1;
        objArray181[index347].SetDefaults(4319);
        Item[] objArray182 = objArray1;
        int index348 = num143;
        int index349 = index348 + 1;
        objArray182[index348].SetDefaults(4320);
        if (scoreAccumulated2 > 1000)
        {
          objArray1[index349].SetDefaults(4591);
          int index350 = index349 + 1;
          objArray1[index350].SetDefaults(4594);
          int index351 = index350 + 1;
          objArray1[index351].SetDefaults(4593);
          int index352 = index351 + 1;
          objArray1[index352].SetDefaults(4592);
          index349 = index352 + 1;
        }
        Item[] objArray183 = objArray1;
        int index353 = index349;
        int num144 = index353 + 1;
        objArray183[index353].SetDefaults(4135);
        Item[] objArray184 = objArray1;
        int index354 = num144;
        int num145 = index354 + 1;
        objArray184[index354].SetDefaults(4138);
        Item[] objArray185 = objArray1;
        int index355 = num145;
        int num146 = index355 + 1;
        objArray185[index355].SetDefaults(4136);
        Item[] objArray186 = objArray1;
        int index356 = num146;
        int num147 = index356 + 1;
        objArray186[index356].SetDefaults(4137);
        Item[] objArray187 = objArray1;
        int index357 = num147;
        index1 = index357 + 1;
        objArray187[index357].SetDefaults(4049);
        if (scoreAccumulated2 > 500)
        {
          objArray1[index1].SetDefaults(4265);
          ++index1;
        }
        if (scoreAccumulated2 > 2000)
        {
          objArray1[index1].SetDefaults(4595);
          int index358 = index1 + 1;
          objArray1[index358].SetDefaults(4598);
          int index359 = index358 + 1;
          objArray1[index359].SetDefaults(4597);
          int index360 = index359 + 1;
          objArray1[index360].SetDefaults(4596);
          index1 = index360 + 1;
          if (NPC.downedBoss3)
          {
            objArray1[index1].SetDefaults(4264);
            ++index1;
          }
        }
        if (scoreAccumulated2 > 500)
        {
          objArray1[index1].SetDefaults(4599);
          ++index1;
        }
        if (scoreAccumulated2 >= 1000)
        {
          objArray1[index1].SetDefaults(4600);
          ++index1;
        }
        if (scoreAccumulated2 >= 2000)
        {
          objArray1[index1].SetDefaults(4601);
          ++index1;
        }
        if (scoreAccumulated2 >= 2000)
        {
          switch (Main.moonPhase)
          {
            case 0:
            case 1:
              objArray1[index1].SetDefaults(4658);
              ++index1;
              break;
            case 2:
            case 3:
              objArray1[index1].SetDefaults(4659);
              ++index1;
              break;
            case 4:
            case 5:
              objArray1[index1].SetDefaults(4660);
              ++index1;
              break;
            case 6:
            case 7:
              objArray1[index1].SetDefaults(4661);
              ++index1;
              break;
          }
        }
        else
          break;
        break;
      case 23:
        BestiaryUnlockProgressReport bestiaryProgressReport = Main.GetBestiaryProgressReport();
        if (Chest.BestiaryGirl_IsFairyTorchAvailable())
          objArray1[index1++].SetDefaults(4776);
        Item[] objArray188 = objArray1;
        int index361 = index1;
        int num148 = index361 + 1;
        objArray188[index361].SetDefaults(4767);
        if (Main.moonPhase == 0 && !Main.dayTime)
          objArray1[num148++].SetDefaults(5253);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.44999998807907104)
          objArray1[num148++].SetDefaults(5635);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.10000000149011612)
          objArray1[num148++].SetDefaults(4759);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.029999999329447746)
          objArray1[num148++].SetDefaults(4672);
        Item[] objArray189 = objArray1;
        int index362 = num148;
        index1 = index362 + 1;
        objArray189[index362].SetDefaults(4829);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.25)
          objArray1[index1++].SetDefaults(4830);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.44999998807907104)
          objArray1[index1++].SetDefaults(4910);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.30000001192092896)
          objArray1[index1++].SetDefaults(4871);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.30000001192092896)
          objArray1[index1++].SetDefaults(4907);
        if (NPC.downedTowerSolar)
          objArray1[index1++].SetDefaults(4677);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.10000000149011612)
          objArray1[index1++].SetDefaults(4676);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.30000001192092896)
          objArray1[index1++].SetDefaults(4762);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.25)
          objArray1[index1++].SetDefaults(4716);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.30000001192092896)
          objArray1[index1++].SetDefaults(4785);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.30000001192092896)
          objArray1[index1++].SetDefaults(4786);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.30000001192092896)
          objArray1[index1++].SetDefaults(4787);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.30000001192092896 && Main.hardMode)
          objArray1[index1++].SetDefaults(4788);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.25)
          objArray1[index1++].SetDefaults(4763);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.40000000596046448)
          objArray1[index1++].SetDefaults(4955);
        if (Main.hardMode && Main.bloodMoon)
          objArray1[index1++].SetDefaults(4736);
        if (NPC.downedPlantBoss)
          objArray1[index1++].SetDefaults(4701);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.5)
          objArray1[index1++].SetDefaults(4765);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.5)
          objArray1[index1++].SetDefaults(4766);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.5)
          objArray1[index1++].SetDefaults(5285);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.5)
          objArray1[index1++].SetDefaults(4777);
        if ((double) bestiaryProgressReport.CompletionPercent >= 0.699999988079071)
          objArray1[index1++].SetDefaults(4735);
        if ((double) bestiaryProgressReport.CompletionPercent >= 1.0)
          objArray1[index1++].SetDefaults(4951);
        if (BirthdayParty.PartyIsUp)
          objArray1[index1++].SetDefaults(5466);
        switch (Main.moonPhase)
        {
          case 0:
          case 1:
            Item[] objArray190 = objArray1;
            int index363 = index1;
            int num149 = index363 + 1;
            objArray190[index363].SetDefaults(4768);
            Item[] objArray191 = objArray1;
            int index364 = num149;
            index1 = index364 + 1;
            objArray191[index364].SetDefaults(4769);
            break;
          case 2:
          case 3:
            Item[] objArray192 = objArray1;
            int index365 = index1;
            int num150 = index365 + 1;
            objArray192[index365].SetDefaults(4770);
            Item[] objArray193 = objArray1;
            int index366 = num150;
            index1 = index366 + 1;
            objArray193[index366].SetDefaults(4771);
            break;
          case 4:
          case 5:
            Item[] objArray194 = objArray1;
            int index367 = index1;
            int num151 = index367 + 1;
            objArray194[index367].SetDefaults(4772);
            Item[] objArray195 = objArray1;
            int index368 = num151;
            index1 = index368 + 1;
            objArray195[index368].SetDefaults(4773);
            break;
          case 6:
          case 7:
            Item[] objArray196 = objArray1;
            int index369 = index1;
            int num152 = index369 + 1;
            objArray196[index369].SetDefaults(4560);
            Item[] objArray197 = objArray1;
            int index370 = num152;
            index1 = index370 + 1;
            objArray197[index370].SetDefaults(4775);
            break;
        }
        if (Main.vampireSeed && !Main.infectedSeed)
        {
          objArray1[index1++].SetDefaults(8);
          break;
        }
        break;
      case 24:
        Item[] objArray198 = objArray1;
        int index371 = index1;
        int num153 = index371 + 1;
        objArray198[index371].SetDefaults(5071);
        Item[] objArray199 = objArray1;
        int index372 = num153;
        int num154 = index372 + 1;
        objArray199[index372].SetDefaults(5072);
        Item[] objArray200 = objArray1;
        int index373 = num154;
        int num155 = index373 + 1;
        objArray200[index373].SetDefaults(5073);
        Item[] objArray201 = objArray1;
        int index374 = num155;
        int num156 = index374 + 1;
        objArray201[index374].SetDefaults(5076);
        Item[] objArray202 = objArray1;
        int index375 = num156;
        int num157 = index375 + 1;
        objArray202[index375].SetDefaults(5077);
        Item[] objArray203 = objArray1;
        int index376 = num157;
        int num158 = index376 + 1;
        objArray203[index376].SetDefaults(5078);
        Item[] objArray204 = objArray1;
        int index377 = num158;
        int num159 = index377 + 1;
        objArray204[index377].SetDefaults(5079);
        Item[] objArray205 = objArray1;
        int index378 = num159;
        int num160 = index378 + 1;
        objArray205[index378].SetDefaults(5080);
        Item[] objArray206 = objArray1;
        int index379 = num160;
        int num161 = index379 + 1;
        objArray206[index379].SetDefaults(5081);
        Item[] objArray207 = objArray1;
        int index380 = num161;
        int num162 = index380 + 1;
        objArray207[index380].SetDefaults(5082);
        Item[] objArray208 = objArray1;
        int index381 = num162;
        int num163 = index381 + 1;
        objArray208[index381].SetDefaults(5083);
        Item[] objArray209 = objArray1;
        int index382 = num163;
        int num164 = index382 + 1;
        objArray209[index382].SetDefaults(5084);
        Item[] objArray210 = objArray1;
        int index383 = num164;
        int num165 = index383 + 1;
        objArray210[index383].SetDefaults(5085);
        Item[] objArray211 = objArray1;
        int index384 = num165;
        int num166 = index384 + 1;
        objArray211[index384].SetDefaults(5086);
        Item[] objArray212 = objArray1;
        int index385 = num166;
        int num167 = index385 + 1;
        objArray212[index385].SetDefaults(5087);
        Item[] objArray213 = objArray1;
        int index386 = num167;
        int num168 = index386 + 1;
        objArray213[index386].SetDefaults(5310);
        Item[] objArray214 = objArray1;
        int index387 = num168;
        int num169 = index387 + 1;
        objArray214[index387].SetDefaults(5222);
        Item[] objArray215 = objArray1;
        int index388 = num169;
        int num170 = index388 + 1;
        objArray215[index388].SetDefaults(5228);
        if (NPC.downedSlimeKing && NPC.downedQueenSlime)
          objArray1[num170++].SetDefaults(5266);
        if (Main.hardMode && NPC.downedMoonlord)
          objArray1[num170++].SetDefaults(5044);
        if (Main.tenthAnniversaryWorld)
        {
          Item[] objArray216 = objArray1;
          int index389 = num170;
          int num171 = index389 + 1;
          objArray216[index389].SetDefaults(1309);
          Item[] objArray217 = objArray1;
          int index390 = num171;
          int num172 = index390 + 1;
          objArray217[index390].SetDefaults(1859);
          Item[] objArray218 = objArray1;
          int index391 = num172;
          num170 = index391 + 1;
          objArray218[index391].SetDefaults(1358);
          if (Main.player[Main.myPlayer].ZoneDesert)
            objArray1[num170++].SetDefaults(857);
          if (Main.bloodMoon)
            objArray1[num170++].SetDefaults(4144);
          if (Main.hardMode && NPC.downedPirates)
          {
            if (Main.moonPhase == 0 || Main.moonPhase == 1)
              objArray1[num170++].SetDefaults(2584);
            if (Main.moonPhase == 2 || Main.moonPhase == 3)
              objArray1[num170++].SetDefaults(854);
            if (Main.moonPhase == 4 || Main.moonPhase == 5)
              objArray1[num170++].SetDefaults(855);
            if (Main.moonPhase == 6 || Main.moonPhase == 7)
              objArray1[num170++].SetDefaults(905);
          }
        }
        Item[] objArray219 = objArray1;
        int index392 = num170;
        index1 = index392 + 1;
        objArray219[index392].SetDefaults(5088);
        break;
      case 25:
        if (Main.xMas)
        {
          for (int Type = 1948; Type <= 1957 && index1 < 39; ++index1)
          {
            objArray1[index1].SetDefaults(Type);
            ++Type;
          }
        }
        for (int Type = 2158; Type <= 2160 && index1 < 39; ++index1)
        {
          objArray1[index1].SetDefaults(Type);
          ++Type;
        }
        for (int Type = 2008; Type <= 2014 && index1 < 39; ++index1)
        {
          objArray1[index1].SetDefaults(Type);
          ++Type;
        }
        if (!Main.player[Main.myPlayer].ZoneGraveyard)
        {
          objArray1[index1].SetDefaults(1490);
          int index393 = index1 + 1;
          if (Main.moonPhase <= 1)
          {
            objArray1[index393].SetDefaults(1481);
            index1 = index393 + 1;
          }
          else if (Main.moonPhase <= 3)
          {
            objArray1[index393].SetDefaults(1482);
            index1 = index393 + 1;
          }
          else if (Main.moonPhase <= 5)
          {
            objArray1[index393].SetDefaults(1483);
            index1 = index393 + 1;
          }
          else
          {
            objArray1[index393].SetDefaults(1484);
            index1 = index393 + 1;
          }
        }
        if (Main.player[Main.myPlayer].ShoppingZone_Forest)
        {
          objArray1[index1].SetDefaults(5245);
          ++index1;
        }
        if (Main.player[Main.myPlayer].ZoneCrimson)
        {
          objArray1[index1].SetDefaults(1492);
          ++index1;
        }
        if (Main.player[Main.myPlayer].ZoneCorrupt)
        {
          objArray1[index1].SetDefaults(1488);
          ++index1;
        }
        if (Main.player[Main.myPlayer].ZoneHallow)
        {
          objArray1[index1].SetDefaults(1489);
          ++index1;
        }
        if (Main.player[Main.myPlayer].ZoneJungle)
        {
          objArray1[index1].SetDefaults(1486);
          ++index1;
        }
        if (Main.player[Main.myPlayer].ZoneSnow)
        {
          objArray1[index1].SetDefaults(5491);
          int index394 = index1 + 1;
          objArray1[index394].SetDefaults(1487);
          index1 = index394 + 1;
        }
        if (Main.player[Main.myPlayer].ZoneDesert)
        {
          objArray1[index1].SetDefaults(1491);
          ++index1;
        }
        if (Main.bloodMoon)
        {
          objArray1[index1].SetDefaults(1493);
          ++index1;
        }
        if (!Main.player[Main.myPlayer].ZoneGraveyard)
        {
          if ((double) Main.player[Main.myPlayer].position.Y / 16.0 < Main.worldSurface * 0.34999999403953552)
          {
            objArray1[index1].SetDefaults(1485);
            ++index1;
          }
          if ((double) Main.player[Main.myPlayer].position.Y / 16.0 < Main.worldSurface * 0.34999999403953552 && Main.hardMode)
          {
            objArray1[index1].SetDefaults(1494);
            ++index1;
          }
        }
        if (Main.IsItStorming)
        {
          objArray1[index1].SetDefaults(5251);
          ++index1;
        }
        if (Main.player[Main.myPlayer].ZoneGraveyard)
        {
          objArray1[index1].SetDefaults(4723);
          int index395 = index1 + 1;
          objArray1[index395].SetDefaults(4724);
          int index396 = index395 + 1;
          objArray1[index396].SetDefaults(4725);
          int index397 = index396 + 1;
          objArray1[index397].SetDefaults(4726);
          int index398 = index397 + 1;
          objArray1[index398].SetDefaults(4727);
          int index399 = index398 + 1;
          objArray1[index399].SetDefaults(5257);
          int index400 = index399 + 1;
          objArray1[index400].SetDefaults(4728);
          int index401 = index400 + 1;
          objArray1[index401].SetDefaults(4729);
          index1 = index401 + 1;
          break;
        }
        break;
    }
    if (((type == 19 || type == 20 ? 0 : (type != 21 ? 1 : 0)) & (TeleportPylonsSystem.DoesPositionHaveEnoughNPCs(2, Main.LocalPlayer.Center.ToTileCoordinates16()) ? 1 : 0)) != 0 && !Main.player[Main.myPlayer].ZoneCorrupt && !Main.player[Main.myPlayer].ZoneCrimson)
    {
      if (!Main.player[Main.myPlayer].ZoneSnow && !Main.player[Main.myPlayer].ZoneDesert && !Main.player[Main.myPlayer].ZoneBeach && !Main.player[Main.myPlayer].ZoneJungle && !Main.player[Main.myPlayer].ZoneHallow && !Main.player[Main.myPlayer].ZoneGlowshroom)
      {
        if (Main.remixWorld)
        {
          if ((double) Main.player[Main.myPlayer].Center.Y / 16.0 > Main.rockLayer && (double) Main.player[Main.myPlayer].Center.Y / 16.0 < (double) (Main.maxTilesY - 350) && index1 < 39)
            objArray1[index1++].SetDefaults(4876);
        }
        else if ((double) Main.player[Main.myPlayer].Center.Y / 16.0 < Main.worldSurface && index1 < 39)
          objArray1[index1++].SetDefaults(4876);
      }
      if (Main.player[Main.myPlayer].ZoneSnow && index1 < 39)
        objArray1[index1++].SetDefaults(4920);
      if (Main.player[Main.myPlayer].ZoneDesert && index1 < 39)
        objArray1[index1++].SetDefaults(4919);
      if (Main.player[Main.myPlayer].ZoneUnderworldHeight)
      {
        if (index1 < 39)
          objArray1[index1++].SetDefaults(5652);
      }
      else if (Main.remixWorld)
      {
        if (!Main.player[Main.myPlayer].ZoneSnow && !Main.player[Main.myPlayer].ZoneDesert && !Main.player[Main.myPlayer].ZoneBeach && !Main.player[Main.myPlayer].ZoneJungle && !Main.player[Main.myPlayer].ZoneHallow && (double) Main.player[Main.myPlayer].Center.Y / 16.0 >= Main.worldSurface && index1 < 39)
          objArray1[index1++].SetDefaults(4917);
      }
      else if (!Main.player[Main.myPlayer].ZoneSnow && !Main.player[Main.myPlayer].ZoneDesert && !Main.player[Main.myPlayer].ZoneBeach && !Main.player[Main.myPlayer].ZoneJungle && !Main.player[Main.myPlayer].ZoneHallow && !Main.player[Main.myPlayer].ZoneGlowshroom && (double) Main.player[Main.myPlayer].Center.Y / 16.0 >= Main.worldSurface && index1 < 39)
        objArray1[index1++].SetDefaults(4917);
      bool flag2 = Main.player[Main.myPlayer].ZoneBeach && (double) Main.player[Main.myPlayer].position.Y < Main.worldSurface * 16.0;
      if (Main.remixWorld)
      {
        float num173 = Main.player[Main.myPlayer].position.X / 16f;
        float num174 = Main.player[Main.myPlayer].position.Y / 16f;
        flag2 = ((flag2 ? 1 : 0) | ((double) num173 < (double) Main.maxTilesX * 0.43 || (double) num173 > (double) Main.maxTilesX * 0.57 ? ((double) num174 <= Main.rockLayer ? 0 : ((double) num174 < (double) (Main.maxTilesY - 350) ? 1 : 0)) : 0)) != 0;
      }
      if (flag2 && index1 < 39)
        objArray1[index1++].SetDefaults(4918);
      if (Main.player[Main.myPlayer].ZoneJungle && index1 < 39)
        objArray1[index1++].SetDefaults(4875);
      if (Main.player[Main.myPlayer].ZoneHallow && index1 < 39)
        objArray1[index1++].SetDefaults(4916);
      if (Main.player[Main.myPlayer].ZoneGlowshroom && (!Main.remixWorld || (double) Main.player[Main.myPlayer].Center.Y / 16.0 < (double) (Main.maxTilesY - 200)) && index1 < 39)
        objArray1[index1++].SetDefaults(4921);
    }
    for (int index402 = 0; index402 < index1; ++index402)
      objArray1[index402].isAShopItem = true;
  }

  private static bool BestiaryGirl_IsFairyTorchAvailable()
  {
    return Chest.DidDiscoverBestiaryEntry(585) && Chest.DidDiscoverBestiaryEntry(584) && Chest.DidDiscoverBestiaryEntry(583);
  }

  private static bool DidDiscoverBestiaryEntry(int npcId)
  {
    return Main.BestiaryDB.FindEntryByNPCID(npcId).UIInfoProvider.GetEntryUICollectionInfo().UnlockState > BestiaryEntryUnlockState.NotKnownAtAll_0;
  }

  public static void AskForChestToEatItem(Vector2 worldPosition, int duration)
  {
    Point tileCoordinates = worldPosition.ToTileCoordinates();
    int chest1 = Chest.FindChest(tileCoordinates.X, tileCoordinates.Y);
    if (chest1 == -1)
      return;
    Chest chest2 = Main.chest[chest1];
    chest2.eatingAnimationTime = Math.Max(duration, chest2.eatingAnimationTime);
  }

  private static RoomCheckParticle GetNewParticle() => new RoomCheckParticle();

  public static void IndicateBlockedChest(int chestIndex)
  {
    Chest chest = Main.chest[chestIndex];
    if (chest == null)
      return;
    RoomCheckParticle roomCheckParticle = Chest._particlePool.RequestParticle();
    roomCheckParticle.SetBasicInfo(TextureAssets.Cd, new Rectangle?(), Vector2.Zero, new Vector2((float) (chest.x * 16 /*0x10*/ + 16 /*0x10*/), (float) (chest.y * 16 /*0x10*/ + 16 /*0x10*/)));
    float fromMax = 60f;
    roomCheckParticle.Delay = 0;
    float timeToLive = fromMax - (float) roomCheckParticle.Delay;
    roomCheckParticle.SetTypeInfo(timeToLive, false);
    roomCheckParticle.FadeInNormalizedTime = Utils.Remap(fromMax - 55f, (float) roomCheckParticle.Delay, fromMax, 0.0f, 1f);
    roomCheckParticle.FadeOutNormalizedTime = Utils.Remap(fromMax - 20f, (float) roomCheckParticle.Delay, fromMax, 0.0f, 1f);
    roomCheckParticle.ColorTint = new Color((int) byte.MaxValue, 40, 40, (int) byte.MaxValue);
    roomCheckParticle.Scale = Vector2.One * 1f;
    roomCheckParticle.Velocity = Vector2.UnitY * 0.1f;
    roomCheckParticle.AccelerationPerFrame = Vector2.UnitY * -0.4f / timeToLive;
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) roomCheckParticle);
  }

  public static void UpdateChestFrames()
  {
    int num = 8000;
    Chest._chestInUse.Clear();
    for (int index = 0; index < (int) byte.MaxValue; ++index)
    {
      if (Main.player[index].active && Main.player[index].chest >= 0 && Main.player[index].chest < num)
        Chest._chestInUse.Add(Main.player[index].chest);
    }
    for (int index = 0; index < num; ++index)
    {
      Chest chest = Main.chest[index];
      if (chest != null)
      {
        if (Chest._chestInUse.Contains(index))
          ++chest.frameCounter;
        else
          --chest.frameCounter;
        if (chest.eatingAnimationTime == 9 && chest.frame == 1)
          SoundEngine.PlaySound(7, new Vector2((float) (chest.x * 16 /*0x10*/ + 16 /*0x10*/), (float) (chest.y * 16 /*0x10*/ + 16 /*0x10*/)));
        if (chest.eatingAnimationTime > 0)
          --chest.eatingAnimationTime;
        if (chest.frameCounter < chest.eatingAnimationTime)
          chest.frameCounter = chest.eatingAnimationTime;
        if (chest.frameCounter < 0)
          chest.frameCounter = 0;
        if (chest.frameCounter > 10)
          chest.frameCounter = 10;
        chest.frame = chest.frameCounter != 0 ? (chest.frameCounter != 10 ? 1 : 2) : 0;
      }
    }
  }

  public void FixLoadedData()
  {
    foreach (Item obj in this.item)
      obj.FixAgainstExploit();
  }

  public struct ItemTransferVisualizationSettings
  {
    public bool RandomizeStartPosition;
    public bool RandomizeEndPosition;
    public bool TransitionIn;
    public bool Fullbright;
    public static Chest.ItemTransferVisualizationSettings PlayerToChest = new Chest.ItemTransferVisualizationSettings()
    {
      RandomizeStartPosition = true,
      RandomizeEndPosition = true,
      TransitionIn = true,
      Fullbright = true
    };
    public static Chest.ItemTransferVisualizationSettings Hopper = new Chest.ItemTransferVisualizationSettings()
    {
      RandomizeEndPosition = true
    };
  }
}
