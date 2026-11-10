// Decompiled with JetBrains decompiler
// Type: Terraria.WorldItem
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Events;
using Terraria.ID;

#nullable disable
namespace Terraria;

public class WorldItem : Entity
{
  public Item inner = new Item();
  public int ownTime;
  public int playerIndexTheItemIsReservedFor = (int) byte.MaxValue;
  public int noGrabDelay;
  public bool shimmered;
  public float shimmerTime;
  public bool instanced;
  public int ownIgnore = -1;
  public int timeSinceTheItemHasBeenReservedForSomeone;
  public int timeLeftInWhichTheItemCannotBeTakenByEnemies;
  public int timeSinceItemSpawned;
  public bool beingGrabbed;
  public bool onConveyor;
  public int keepTime;
  private static SceneMetrics _sceneMetrics = new SceneMetrics();

  static WorldItem()
  {
    RemoteClient.NetSectionActivated += new Action<int, Point>(WorldItem.SyncItemsInSection);
  }

  public override string ToString() => $"[{(object) this.whoAmI}]{(object) this.inner}";

  public void ClearOut() => this.TurnToAir();

  public void OverrideWith(Item item) => this.inner = item;

  public void ResetStats(int Type)
  {
    this.SetDefaultsBringOver();
    this.inner.ResetStats(Type);
    this.wet = false;
    this.wetCount = (byte) 0;
    this.lavaWet = false;
    this.timeSinceTheItemHasBeenReservedForSomeone = 0;
    this.instanced = false;
    this.UpdateEntityFields();
  }

  public void SetDefaultsBringOver()
  {
    if (Main.netMode == 1 || Main.netMode == 2)
      this.playerIndexTheItemIsReservedFor = (int) byte.MaxValue;
    else
      this.playerIndexTheItemIsReservedFor = Main.myPlayer;
  }

  public bool active => this.inner.active;

  public int type
  {
    get => this.inner.type;
    set => this.inner.type = value;
  }

  public int stack
  {
    get => this.inner.stack;
    set => this.inner.stack = value;
  }

  public bool newAndShiny
  {
    get => this.inner.newAndShiny;
    set => this.inner.newAndShiny = value;
  }

  public Color color
  {
    get => this.inner.color;
    set => this.inner.color = value;
  }

  public bool favorited
  {
    get => this.inner.favorited;
    set => this.inner.favorited = value;
  }

  public short makeNPC
  {
    get => this.inner.makeNPC;
    set => this.inner.makeNPC = value;
  }

  public int value => this.inner.value;

  public int useTime => this.inner.useTime;

  public int useAnimation => this.inner.useAnimation;

  public int useAmmo => this.inner.useAmmo;

  public int maxStack => this.inner.maxStack;

  public int damage => this.inner.damage;

  public float knockBack => this.inner.knockBack;

  public float shootSpeed => this.inner.shootSpeed;

  public float scale => this.inner.scale;

  public int ammo => this.inner.ammo;

  public bool notAmmo => this.inner.notAmmo;

  public int shoot => this.inner.shoot;

  public int rare => this.inner.rare;

  public int placeStyle => this.inner.placeStyle;

  public int createTile => this.inner.createTile;

  public int glowMask => (int) this.inner.glowMask;

  public bool expert => this.inner.expert;

  public string Name => this.inner.Name;

  public int alpha => this.inner.alpha;

  public int buffType => this.inner.buffType;

  public bool IsACoin => this.inner.IsACoin;

  public bool IsAir => this.inner.IsAir;

  public void SetDefaults(int type)
  {
    this.ResetStats(type);
    this.inner.SetDefaults(type);
    this.UpdateEntityFields();
  }

  public void TurnToAir(bool fullReset = false)
  {
    this.inner.TurnToAir(fullReset);
    this.UpdateEntityFields();
  }

  public void Prefix(int prefix)
  {
    this.inner.Prefix(prefix);
    this.UpdateEntityFields();
  }

  public bool OnlyNeedOneInInventory() => this.inner.OnlyNeedOneInInventory();

  public Color GetColor(Color newColor) => this.inner.GetColor(newColor);

  public Color GetAlpha(Color newColor) => this.inner.GetAlpha(newColor);

  public string AffixName() => this.inner.AffixName();

  public void TryCombiningIntoNearbyItems(int myItemIndex)
  {
    if (this.playerIndexTheItemIsReservedFor != Main.myPlayer || !this.inner.CanPassivelyStackInWorld() || this.stack >= this.maxStack)
      return;
    int num1 = 30;
    for (int number = myItemIndex + 1; number < 400; ++number)
    {
      WorldItem worldItem = Main.item[number];
      if (!worldItem.IsAir && Item.CanStack(this.inner, worldItem.inner) && worldItem.shimmered == this.shimmered && worldItem.playerIndexTheItemIsReservedFor == this.playerIndexTheItemIsReservedFor && (double) Math.Abs(this.position.X - worldItem.position.X) + (double) Math.Abs(this.position.Y - worldItem.position.Y) <= (double) num1)
      {
        int num2 = Math.Min(worldItem.stack, this.maxStack - this.stack);
        worldItem.stack -= num2;
        this.stack += num2;
        float amount = (float) num2 / (float) this.stack;
        this.position = Vector2.Lerp(worldItem.position, this.position, amount);
        this.velocity = Vector2.Lerp(worldItem.velocity, this.velocity, amount);
        if (worldItem.stack <= 0)
          worldItem.TurnToAir();
        if (Main.netMode != 0)
        {
          NetMessage.SendData(21, number: myItemIndex);
          NetMessage.SendData(21, number: number);
        }
      }
    }
  }

  public void FindOwner()
  {
    if (Main.netMode == 1 && (double) this.shimmerTime > 0.0)
      this.keepTime = 0;
    if (this.keepTime > 0)
      return;
    int itemIsReservedFor = this.playerIndexTheItemIsReservedFor;
    int index1 = (int) byte.MaxValue;
    bool flag = true;
    if (this.type == 267 && this.ownIgnore != -1)
      flag = false;
    if (EmergencyStacking.HasPendingTransferInvolving(this))
      index1 = (int) byte.MaxValue;
    else if ((double) this.shimmerTime > 0.0)
      index1 = (int) byte.MaxValue;
    else if (flag)
    {
      float num1 = (float) NPC.sWidth;
      for (int index2 = 0; index2 < (int) byte.MaxValue; ++index2)
      {
        if (this.ownIgnore != index2)
        {
          Player player = Main.player[index2];
          if (player.active && !player.dead)
          {
            Player.ItemSpaceStatus status = player.ItemSpace(Main.item[this.whoAmI]);
            if (player.CanPullItem(Main.item[this.whoAmI], status))
            {
              float num2 = Math.Abs(player.position.X + (float) (player.width / 2) - this.position.X - (float) (this.width / 2)) + Math.Abs(player.position.Y + (float) (player.height / 2) - this.position.Y - (float) this.height);
              if (player.manaMagnet && (this.type == 184 || this.type == 1735 || this.type == 1868))
                num2 -= (float) Item.manaGrabRange;
              if (player.lifeMagnet && (this.type == 58 || this.type == 1734 || this.type == 1867))
                num2 -= (float) Item.lifeGrabRange;
              if (this.type == 4143)
                num2 -= (float) Item.manaGrabRange;
              if ((double) num1 > (double) num2)
              {
                num1 = num2;
                index1 = index2;
              }
            }
          }
        }
      }
      if (Main.netMode != 0 && index1 != (int) byte.MaxValue)
      {
        Player player = Main.player[index1];
        int itemGrabRange = player.GetItemGrabRange(this);
        Rectangle hitbox = player.Hitbox;
        hitbox.Inflate(itemGrabRange, itemGrabRange);
        if (!hitbox.Intersects(this.Hitbox) && Wiring.IsHopperInRangeOf(this))
          index1 = (int) byte.MaxValue;
      }
    }
    if (index1 == itemIsReservedFor)
      return;
    if (Main.netMode == 1)
    {
      this.playerIndexTheItemIsReservedFor = (int) byte.MaxValue;
      NetMessage.SendData(39, number: this.whoAmI);
    }
    else if (itemIsReservedFor != Main.myPlayer && Main.player[itemIsReservedFor].active)
    {
      this.playerIndexTheItemIsReservedFor = itemIsReservedFor;
      if (this.timeSinceTheItemHasBeenReservedForSomeone < 0)
        return;
      this.timeSinceTheItemHasBeenReservedForSomeone = -1;
      NetMessage.SendData(39, itemIsReservedFor, number: this.whoAmI);
    }
    else
    {
      this.playerIndexTheItemIsReservedFor = index1;
      this.timeSinceTheItemHasBeenReservedForSomeone = 0;
      NetMessage.SendData(22, number: this.whoAmI);
    }
  }

  private void UpdateEntityFields() => this.width = this.height = 16 /*0x10*/;

  public void UpdateItem(int i)
  {
    this.UpdateEntityFields();
    this.whoAmI = i;
    if (Main.timeItemSlotCannotBeReusedFor[i] > 0)
    {
      if (Main.netMode == 2)
      {
        --Main.timeItemSlotCannotBeReusedFor[i];
        return;
      }
      Main.timeItemSlotCannotBeReusedFor[i] = 0;
    }
    if (!this.active)
      return;
    if (this.instanced)
    {
      if (Main.netMode == 2)
      {
        this.TurnToAir();
        return;
      }
      this.keepTime = 6000;
      this.ownTime = 0;
      this.noGrabDelay = 0;
      this.playerIndexTheItemIsReservedFor = Main.myPlayer;
    }
    if (Main.netMode == 0)
      this.playerIndexTheItemIsReservedFor = Main.myPlayer;
    float gravity = 0.1f;
    float maxFallSpeed = 7f;
    if (Main.netMode == 1)
    {
      Point tileCoordinates = this.Bottom.ToTileCoordinates();
      if (WorldGen.InWorld(tileCoordinates) && Main.tile[tileCoordinates.X, tileCoordinates.Y] == null)
      {
        gravity = 0.0f;
        this.velocity = Vector2.Zero;
        if (this.instanced && Main.GameUpdateCount % 10U == 0U)
          NetMessage.SendData(159, number: tileCoordinates.X / 200, number2: (float) (tileCoordinates.Y / 150));
      }
    }
    Vector2 wetVelocity = this.velocity * 0.5f;
    if (this.shimmerWet)
    {
      gravity = 0.065f;
      maxFallSpeed = 4f;
      wetVelocity = this.velocity * 0.375f;
    }
    else if (this.honeyWet)
    {
      gravity = 0.05f;
      maxFallSpeed = 3f;
      wetVelocity = this.velocity * 0.25f;
    }
    else if (this.wet)
    {
      gravity = 0.08f;
      maxFallSpeed = 5f;
    }
    if (this.ownTime > 0)
      --this.ownTime;
    else
      this.ownIgnore = -1;
    if (this.keepTime > 0)
      --this.keepTime;
    if (!this.beingGrabbed)
    {
      if (this.type == 205 && this.playerIndexTheItemIsReservedFor == Main.myPlayer && Main.raining && (Main.isThereAWorldSurface || Main.remixWorld) && WorldGen.IsSurfaceForAtmospherics(this.position.ToTileCoordinates()))
      {
        int x = (int) this.Center.X / 16 /*0x10*/;
        int y = (int) this.Center.Y / 16 /*0x10*/;
        if (WorldGen.InWorld(x, y) && WallID.Sets.AllowsWind[(int) Main.tile[x, y].wall])
        {
          int maxValue = 600;
          if (Main.dayRate > 0 && Main.dayRate < maxValue)
            maxValue /= Main.dayRate;
          if (Main.rand.Next(maxValue) == 0 && (double) Main.rand.NextFloat() < (double) Main.maxRaining)
          {
            int stack = this.stack;
            this.SetDefaults(206);
            this.playerIndexTheItemIsReservedFor = Main.myPlayer;
            this.stack = stack;
            NetMessage.SendData(21, number: i);
          }
        }
      }
      if (this.shimmered)
      {
        if (Main.rand.Next(30) == 0)
        {
          int index = Dust.NewDust(this.position, this.width, this.height, 309);
          Main.dust[index].position.X += (float) Main.rand.Next(-8, 5);
          Main.dust[index].position.Y += (float) Main.rand.Next(-8, 5);
          Main.dust[index].scale *= 1.1f;
          Main.dust[index].velocity *= 0.3f;
          switch (Main.rand.Next(6))
          {
            case 0:
              Main.dust[index].color = new Color((int) byte.MaxValue, (int) byte.MaxValue, 210);
              break;
            case 1:
              Main.dust[index].color = new Color(190, 245, (int) byte.MaxValue);
              break;
            case 2:
              Main.dust[index].color = new Color((int) byte.MaxValue, 150, (int) byte.MaxValue);
              break;
            default:
              Main.dust[index].color = new Color(190, 175, (int) byte.MaxValue);
              break;
          }
        }
        Lighting.AddLight(this.Center, (float) ((1.0 - (double) this.shimmerTime) * 0.800000011920929), (float) ((1.0 - (double) this.shimmerTime) * 0.800000011920929), (float) ((1.0 - (double) this.shimmerTime) * 0.800000011920929));
        gravity = 0.0f;
        if (this.shimmerWet)
        {
          if ((double) this.velocity.Y > -4.0)
            this.velocity.Y -= 0.05f;
        }
        else
        {
          int num1 = 2;
          int x = (int) ((double) this.Center.X / 16.0);
          int num2 = (int) ((double) this.Center.Y / 16.0);
          bool flag = false;
          for (int y = num2; y < num2 + num1; ++y)
          {
            if (WorldGen.InWorld(x, y) && Main.tile[x, y] != null && Main.tile[x, y].shimmer() && Main.tile[x, y].liquid > (byte) 0)
            {
              flag = true;
              break;
            }
          }
          if (flag)
          {
            if ((double) this.velocity.Y > -4.0)
              this.velocity.Y -= 0.05f;
          }
          else
            this.velocity.Y *= 0.9f;
        }
      }
      if (this.shimmerWet && !this.shimmered)
        this.Shimmering();
      else if ((double) this.shimmerTime > 0.0)
      {
        this.shimmerTime -= 0.01f;
        if ((double) this.shimmerTime < 0.0)
          this.shimmerTime = 0.0f;
      }
      if ((double) this.shimmerTime == 0.0)
        this.TryCombiningIntoNearbyItems(i);
      if (this.timeLeftInWhichTheItemCannotBeTakenByEnemies > 0)
        --this.timeLeftInWhichTheItemCannotBeTakenByEnemies;
      if (this.timeLeftInWhichTheItemCannotBeTakenByEnemies == 0 && this.playerIndexTheItemIsReservedFor == Main.myPlayer)
      {
        this.GetPickedUpByMonsters_Special(i);
        if (Main.expertMode && this.IsACoin)
          this.GetPickedUpByMonsters_Money(i);
      }
      this.MoveInWorld(gravity, maxFallSpeed, ref wetVelocity, i);
      if (this.lavaWet)
        this.CheckLavaDeath(i);
      this.CheckInWorld(i);
      this.DespawnIfMeetingConditions(i);
      if (this.type == 74)
        this.TryGrantingMakeAWishSet();
    }
    else
    {
      this.wet = false;
      this.wetCount = (byte) 0;
      this.lavaWet = false;
      this.honeyWet = false;
      this.shimmerWet = false;
      this.beingGrabbed = false;
      this.onConveyor = false;
      this.ApplyMovement(ref wetVelocity);
    }
    this.UpdateItem_VisualEffects();
    if (this.timeSinceItemSpawned < 2147483547)
      ++this.timeSinceItemSpawned;
    if (this.noGrabDelay <= 0)
      return;
    --this.noGrabDelay;
  }

  private void CheckInWorld(int i)
  {
    if (WorldGen.InWorld(this.position.ToTileCoordinates(), 20))
      return;
    if (ItemID.Sets.RecoverableImportantItem[this.type])
    {
      this.Center = (!this.instanced && Main.netMode != 0 || Main.LocalPlayer.SpawnX < 0 ? new Point(Main.spawnTileX, Main.spawnTileY) : new Point(Main.LocalPlayer.SpawnX, Main.LocalPlayer.SpawnY)).ToWorldCoordinates();
      this.velocity = Vector2.Zero;
    }
    else
      this.TurnToAir();
    if (Main.netMode != 2)
      return;
    NetMessage.SendData(21, number: i);
  }

  private void TryGrantingMakeAWishSet()
  {
    if (this.playerIndexTheItemIsReservedFor != Main.myPlayer || !this.wet || this.stack != 1 || (this.ownIgnore != 1 ? 1 : (this.noGrabDelay > 0 ? 1 : 0)) == 0)
      return;
    byte closest = Player.FindClosest(this.position, this.width, this.height);
    if (closest == byte.MaxValue || !Main.player[(int) closest].ZoneDesert)
      return;
    this.TurnToAir();
    if (Main.netMode != 0)
      NetMessage.SendData(21, number: this.whoAmI);
    bool splitToSides = true;
    int numberOfItems = 5;
    this.SpawnShimmeredItem((short) 5655, splitToSides, numberOfItems);
    this.SpawnShimmeredItem((short) 5656, splitToSides, numberOfItems);
    this.SpawnShimmeredItem((short) 5657, splitToSides, numberOfItems);
    this.SpawnShimmeredItem((short) 5658, splitToSides, numberOfItems);
    this.SpawnShimmeredItem((short) 5661, splitToSides, numberOfItems);
    ParticleOrchestrator.BroadcastOrRequestParticleSpawn(ParticleOrchestraType.HeroicisSetSpawnSound, new ParticleOrchestraSettings()
    {
      PositionInWorld = this.Center
    });
  }

  private void SpawnShimmeredItem(short idToCheck, bool splitToSides, int numberOfItems)
  {
    int number = Item.NewItem(this.GetItemSource_Misc(ItemSourceID.Shimmer), (int) this.position.X, (int) this.position.Y, this.width, this.height, (int) idToCheck);
    WorldItem worldItem1 = Main.item[number];
    worldItem1.stack = 1;
    worldItem1.shimmerTime = 1f;
    worldItem1.shimmered = true;
    worldItem1.shimmerWet = true;
    worldItem1.wet = true;
    WorldItem worldItem2 = worldItem1;
    worldItem2.velocity = worldItem2.velocity * 0.1f;
    worldItem1.playerIndexTheItemIsReservedFor = Main.myPlayer;
    if (splitToSides)
    {
      worldItem1.velocity.X = 1f * (float) numberOfItems;
      worldItem1.velocity.X *= (float) (1.0 + (double) numberOfItems * 0.05000000074505806);
      if (numberOfItems % 2 == 0)
        worldItem1.velocity.X *= -1f;
    }
    NetMessage.SendData(145, number: number, number2: 1f);
  }

  private void DespawnIfMeetingConditions(int i)
  {
    if (this.type == 75 && Main.dayTime && !Main.remixWorld && !this.shimmered && !this.beingGrabbed)
    {
      for (int index = 0; index < 10; ++index)
        Dust.NewDust(this.position, this.width, this.height, 15, this.velocity.X, this.velocity.Y, 150, Scale: 1.2f);
      for (int index = 0; index < 3; ++index)
        Gore.NewGore(this.position, new Vector2(this.velocity.X, this.velocity.Y), Main.rand.Next(16 /*0x10*/, 18));
      this.TurnToAir();
      if (Main.netMode == 2)
        NetMessage.SendData(21, number: i);
    }
    if (this.type == 4143 && this.timeSinceItemSpawned > 300)
    {
      for (int index = 0; index < 20; ++index)
        Dust.NewDust(this.position, this.width, this.height, 15, this.velocity.X, this.velocity.Y, 150, Color.Lerp(Color.CornflowerBlue, Color.Indigo, Main.rand.NextFloat()), 1.2f);
      this.TurnToAir();
      if (Main.netMode == 2)
        NetMessage.SendData(21, number: i);
    }
    if (this.type != 3822 || DD2Event.Ongoing)
      return;
    int num = Main.rand.Next(18, 24);
    for (int index1 = 0; index1 < num; ++index1)
    {
      int index2 = Dust.NewDust(this.Center, 0, 0, 61, Scale: 1.7f);
      Main.dust[index2].velocity *= 8f;
      --Main.dust[index2].velocity.Y;
      Main.dust[index2].position = Vector2.Lerp(Main.dust[index2].position, this.Center, 0.5f);
      Main.dust[index2].noGravity = true;
      Main.dust[index2].noLight = true;
    }
    this.TurnToAir();
    if (Main.netMode != 2)
      return;
    NetMessage.SendData(21, number: i);
  }

  private void CheckLavaDeath(int i)
  {
    if (this.type == 267)
    {
      if (Main.netMode == 1)
        return;
      int stack = this.stack;
      this.TurnToAir();
      bool flag = false;
      for (int number = 0; number < Main.maxNPCs; ++number)
      {
        if (Main.npc[number].active && Main.npc[number].type == 22)
        {
          int num = -Main.npc[number].direction;
          if (Main.npc[number].IsNPCValidForBestiaryKillCredit())
            Main.BestiaryTracker.Kills.RegisterKill(Main.npc[number]);
          Main.npc[number].StrikeNPCNoInteraction(9999, 10f, -num);
          --stack;
          flag = true;
          if (Main.netMode == 2)
            NetMessage.SendData(28, number: number, number2: 9999f, number3: 10f, number4: (float) -num);
          NPC.SpawnWOF(this.position);
        }
      }
      if (flag)
      {
        List<int> intList = new List<int>();
        for (int index = 0; index < Main.maxNPCs && stack > 0; ++index)
        {
          NPC npc = Main.npc[index];
          if (npc.active && npc.isLikeATownNPC)
            intList.Add(index);
        }
        while (stack > 0 && intList.Count > 0)
        {
          int index = Main.rand.Next(intList.Count);
          int number = intList[index];
          intList.RemoveAt(index);
          int num = -Main.npc[number].direction;
          if (Main.npc[number].IsNPCValidForBestiaryKillCredit())
            Main.BestiaryTracker.Kills.RegisterKill(Main.npc[number]);
          Main.npc[number].StrikeNPCNoInteraction(9999, 10f, -num);
          --stack;
          if (Main.netMode == 2)
            NetMessage.SendData(28, number: number, number2: 9999f, number3: 10f, number4: (float) -num);
        }
      }
      NetMessage.SendData(21, number: i);
    }
    else
    {
      if (this.playerIndexTheItemIsReservedFor != Main.myPlayer || this.type <= 0 && this.type >= (int) ItemID.Count || (this.rare == 0 ? 0 : (this.rare != -1 ? 1 : 0)) != 0 || ItemID.Sets.IsLavaImmuneRegardlessOfRarity[this.type])
        return;
      this.TurnToAir();
      if (Main.netMode == 0)
        return;
      NetMessage.SendData(21, number: i);
    }
  }

  private void Shimmering()
  {
    if (this.inner.CanShimmer())
    {
      int x = (int) ((double) this.Center.X / 16.0);
      int y = (int) ((double) this.position.Y / 16.0 - 1.0);
      Tile tile = Main.tile[x, y];
      if (WorldGen.InWorld(x, y) && tile != null && tile.liquid > (byte) 0 && tile.shimmer())
      {
        if (this.playerIndexTheItemIsReservedFor == Main.myPlayer && Main.netMode != 1)
        {
          this.shimmerTime += 0.01f;
          if ((double) this.shimmerTime <= 0.89999997615814209)
            return;
          this.shimmerTime = 0.9f;
          this.GetShimmered();
          return;
        }
        this.shimmerTime += 0.01f;
        if ((double) this.shimmerTime <= 1.0)
          return;
        this.shimmerTime = 1f;
        return;
      }
    }
    if ((double) this.shimmerTime <= 0.0)
      return;
    this.shimmerTime -= 0.01f;
    if ((double) this.shimmerTime >= 0.0)
      return;
    this.shimmerTime = 0.0f;
  }

  private void MoveInWorld(float gravity, float maxFallSpeed, ref Vector2 wetVelocity, int i)
  {
    if (!this.shimmered && ItemID.Sets.ItemNoGravity[this.type])
    {
      this.velocity.X *= 0.95f;
      if ((double) this.velocity.X < 0.1 && (double) this.velocity.X > -0.1)
        this.velocity.X = 0.0f;
      this.velocity.Y *= 0.95f;
      if ((double) this.velocity.Y < 0.1 && (double) this.velocity.Y > -0.1)
        this.velocity.Y = 0.0f;
    }
    else
    {
      bool flag = false;
      if (this.shimmered && this.active)
      {
        int num1 = 50;
        for (int index = 0; index < 400; ++index)
        {
          if (i != index && Main.item[index].active && Main.item[index].shimmered)
          {
            if (num1-- > 0)
            {
              float num2 = (float) ((this.width + Main.item[index].width) / 2);
              if ((double) Math.Abs(this.Center.X - Main.item[index].Center.X) <= (double) num2 && (double) Math.Abs(this.Center.Y - Main.item[index].Center.Y) <= (double) num2)
              {
                flag = true;
                float num3 = Vector2.Distance(this.Center, Main.item[index].Center);
                float num4 = num2 / num3;
                if ((double) num4 > 10.0)
                  num4 = 10f;
                if ((double) this.Center.X < (double) Main.item[index].Center.X)
                {
                  if ((double) this.velocity.X > -3.0 * (double) num4)
                    this.velocity.X -= 0.1f * num4;
                  if ((double) Main.item[index].velocity.X < 3.0)
                    Main.item[index].velocity.X += 0.1f * num4;
                }
                else if ((double) this.Center.X > (double) Main.item[index].Center.X)
                {
                  if ((double) this.velocity.X < 3.0 * (double) num4)
                    this.velocity.X += 0.1f * num4;
                  if ((double) Main.item[index].velocity.X > -3.0)
                    Main.item[index].velocity.X -= 0.1f * num4;
                }
                else if (i < index)
                {
                  if ((double) this.velocity.X > -3.0 * (double) num4)
                    this.velocity.X -= 0.1f * num4;
                  if ((double) Main.item[index].velocity.X < 3.0 * (double) num4)
                    Main.item[index].velocity.X += 0.1f * num4;
                }
              }
            }
            else
              break;
          }
        }
      }
      this.velocity.Y += gravity;
      if ((double) this.velocity.Y > (double) maxFallSpeed)
        this.velocity.Y = maxFallSpeed;
      this.velocity.X *= 0.95f;
      if ((double) this.velocity.X < 0.1 && (double) this.velocity.X > -0.1)
        this.velocity.X = 0.0f;
      if (flag)
        this.velocity.X *= 0.8f;
    }
    this.onConveyor = Collision.ApplyConveyorBeltMovementToVelocity(this, ref this.velocity);
    bool flag1 = Collision.LavaCollision(this.position, this.width, this.height);
    if (flag1)
      this.lavaWet = true;
    int num = Collision.WetCollision(this.position, this.width, this.height) ? 1 : 0;
    if (Collision.honey)
      this.honeyWet = true;
    if (Collision.shimmer)
      this.shimmerWet = true;
    if (num != 0)
    {
      if (!this.wet)
      {
        if (this.wetCount == (byte) 0)
        {
          this.wetCount = (byte) 20;
          if (!flag1)
          {
            if (this.shimmerWet)
            {
              for (int index1 = 0; index1 < 10; ++index1)
              {
                int index2 = Dust.NewDust(new Vector2(this.position.X - 6f, (float) ((double) this.position.Y + (double) (this.height / 2) - 8.0)), this.width + 12, 24, 308);
                Main.dust[index2].velocity.Y -= 4f;
                Main.dust[index2].velocity.X *= 2.5f;
                Main.dust[index2].scale = 0.8f;
                Main.dust[index2].noGravity = true;
                switch (Main.rand.Next(6))
                {
                  case 0:
                    Main.dust[index2].color = new Color((int) byte.MaxValue, (int) byte.MaxValue, 210);
                    break;
                  case 1:
                    Main.dust[index2].color = new Color(190, 245, (int) byte.MaxValue);
                    break;
                  case 2:
                    Main.dust[index2].color = new Color((int) byte.MaxValue, 150, (int) byte.MaxValue);
                    break;
                  default:
                    Main.dust[index2].color = new Color(190, 175, (int) byte.MaxValue);
                    break;
                }
              }
              SoundEngine.PlaySound(19, (int) this.position.X, (int) this.position.Y, 4);
            }
            else if (this.honeyWet)
            {
              for (int index3 = 0; index3 < 5; ++index3)
              {
                int index4 = Dust.NewDust(new Vector2(this.position.X - 6f, (float) ((double) this.position.Y + (double) (this.height / 2) - 8.0)), this.width + 12, 24, 152);
                --Main.dust[index4].velocity.Y;
                Main.dust[index4].velocity.X *= 2.5f;
                Main.dust[index4].scale = 1.3f;
                Main.dust[index4].alpha = 100;
                Main.dust[index4].noGravity = true;
              }
              SoundEngine.PlaySound(19, (int) this.position.X, (int) this.position.Y);
            }
            else
            {
              for (int index5 = 0; index5 < 10; ++index5)
              {
                int index6 = Dust.NewDust(new Vector2(this.position.X - 6f, (float) ((double) this.position.Y + (double) (this.height / 2) - 8.0)), this.width + 12, 24, Dust.dustWater());
                Main.dust[index6].velocity.Y -= 4f;
                Main.dust[index6].velocity.X *= 2.5f;
                Main.dust[index6].scale *= 0.8f;
                Main.dust[index6].alpha = 100;
                Main.dust[index6].noGravity = true;
              }
              SoundEngine.PlaySound(19, (int) this.position.X, (int) this.position.Y);
            }
          }
          else
          {
            for (int index7 = 0; index7 < 5; ++index7)
            {
              int index8 = Dust.NewDust(new Vector2(this.position.X - 6f, (float) ((double) this.position.Y + (double) (this.height / 2) - 8.0)), this.width + 12, 24, 35);
              Main.dust[index8].velocity.Y -= 1.5f;
              Main.dust[index8].velocity.X *= 2.5f;
              Main.dust[index8].scale = 1.3f;
              Main.dust[index8].alpha = 100;
              Main.dust[index8].noGravity = true;
            }
            SoundEngine.PlaySound(19, (int) this.position.X, (int) this.position.Y);
          }
        }
        this.wet = true;
      }
    }
    else if (this.wet)
    {
      this.wet = false;
      if (this.wetCount == (byte) 0)
      {
        this.wetCount = (byte) 20;
        if (!this.lavaWet)
        {
          if (this.shimmerWet)
          {
            for (int index9 = 0; index9 < 10; ++index9)
            {
              int index10 = Dust.NewDust(new Vector2(this.position.X - 6f, (float) ((double) this.position.Y + (double) (this.height / 2) - 8.0)), this.width + 12, 24, 308);
              Main.dust[index10].velocity.Y -= 4f;
              Main.dust[index10].velocity.X *= 2.5f;
              Main.dust[index10].scale = 0.8f;
              Main.dust[index10].noGravity = true;
              switch (Main.rand.Next(6))
              {
                case 0:
                  Main.dust[index10].color = new Color((int) byte.MaxValue, (int) byte.MaxValue, 210);
                  break;
                case 1:
                  Main.dust[index10].color = new Color(190, 245, (int) byte.MaxValue);
                  break;
                case 2:
                  Main.dust[index10].color = new Color((int) byte.MaxValue, 150, (int) byte.MaxValue);
                  break;
                default:
                  Main.dust[index10].color = new Color(190, 175, (int) byte.MaxValue);
                  break;
              }
            }
            SoundEngine.PlaySound(19, (int) this.position.X, (int) this.position.Y, 5);
          }
          else if (this.honeyWet)
          {
            for (int index11 = 0; index11 < 5; ++index11)
            {
              int index12 = Dust.NewDust(new Vector2(this.position.X - 6f, (float) ((double) this.position.Y + (double) (this.height / 2) - 8.0)), this.width + 12, 24, 152);
              --Main.dust[index12].velocity.Y;
              Main.dust[index12].velocity.X *= 2.5f;
              Main.dust[index12].scale = 1.3f;
              Main.dust[index12].alpha = 100;
              Main.dust[index12].noGravity = true;
            }
            SoundEngine.PlaySound(19, (int) this.position.X, (int) this.position.Y);
          }
          else
          {
            for (int index13 = 0; index13 < 10; ++index13)
            {
              int index14 = Dust.NewDust(new Vector2(this.position.X - 6f, this.position.Y + (float) (this.height / 2)), this.width + 12, 24, Dust.dustWater());
              Main.dust[index14].velocity.Y -= 4f;
              Main.dust[index14].velocity.X *= 2.5f;
              Main.dust[index14].scale *= 0.8f;
              Main.dust[index14].alpha = 100;
              Main.dust[index14].noGravity = true;
            }
            SoundEngine.PlaySound(19, (int) this.position.X, (int) this.position.Y);
          }
        }
        else
        {
          for (int index15 = 0; index15 < 5; ++index15)
          {
            int index16 = Dust.NewDust(new Vector2(this.position.X - 6f, (float) ((double) this.position.Y + (double) (this.height / 2) - 8.0)), this.width + 12, 24, 35);
            Main.dust[index16].velocity.Y -= 1.5f;
            Main.dust[index16].velocity.X *= 2.5f;
            Main.dust[index16].scale = 1.3f;
            Main.dust[index16].alpha = 100;
            Main.dust[index16].noGravity = true;
          }
          SoundEngine.PlaySound(19, (int) this.position.X, (int) this.position.Y);
        }
      }
    }
    if (!this.wet)
    {
      this.lavaWet = false;
      this.honeyWet = false;
      this.shimmerWet = false;
    }
    if (this.wetCount > (byte) 0)
      --this.wetCount;
    if (this.wet)
    {
      if (this.wet)
      {
        Vector2 velocity = this.velocity;
        this.velocity = Collision.TileCollision(this.position, this.velocity, this.width, this.height, ignoreAetheriumPlatforms: true);
        if ((double) this.velocity.X != (double) velocity.X)
          wetVelocity.X = this.velocity.X;
        if ((double) this.velocity.Y != (double) velocity.Y)
          wetVelocity.Y = this.velocity.Y;
      }
    }
    else
      this.velocity = Collision.TileCollision(this.position, this.velocity, this.width, this.height, ignoreAetheriumPlatforms: true);
    this.ApplyMovement(ref wetVelocity);
    Vector4 vector4 = Collision.SlopeCollision(this.position, this.velocity, this.width, this.height, gravity, ignoreAetheriumPlatforms: true);
    this.position.X = vector4.X;
    this.position.Y = vector4.Y;
    this.velocity.X = vector4.Z;
    this.velocity.Y = vector4.W;
  }

  private void ApplyMovement(ref Vector2 wetVelocity)
  {
    if (this.wet)
      this.position = this.position + wetVelocity;
    else
      this.position = this.position + this.velocity;
  }

  private void GetPickedUpByMonsters_Special(int i)
  {
    bool flag1 = false;
    bool flag2 = false;
    switch (this.type)
    {
      case 89:
      case 3507:
        if (!NPC.unlockedSlimeCopperSpawn)
        {
          flag1 = true;
          flag2 = true;
          break;
        }
        break;
    }
    if (!flag2)
      return;
    bool flag3 = false;
    Rectangle hitbox = this.Hitbox;
    for (int npcIndex = 0; npcIndex < Main.maxNPCs; ++npcIndex)
    {
      NPC npc = Main.npc[npcIndex];
      if (npc.active && flag1 && npc.type >= 0 && npc.type < (int) NPCID.Count && NPCID.Sets.CanConvertIntoCopperSlimeTownNPC[npc.type] && hitbox.Intersects(npc.Hitbox))
      {
        flag3 = true;
        NPC.TransformCopperSlime(npcIndex);
        break;
      }
    }
    if (!flag3)
      return;
    this.TurnToAir(true);
    NetMessage.SendData(21, number: i);
  }

  private void GetPickedUpByMonsters_Money(int i)
  {
    Rectangle rectangle1 = new Rectangle((int) this.position.X, (int) this.position.Y, this.width, this.height);
    for (int index1 = 0; index1 < Main.maxNPCs; ++index1)
    {
      NPC npc1 = Main.npc[index1];
      if (npc1.active && npc1.lifeMax > 5 && !npc1.friendly && !npc1.immortal && !npc1.dontTakeDamage && !NPCID.Sets.CantTakeLunchMoney[npc1.type])
      {
        float stack = (float) this.stack;
        float num1 = 1f;
        if (this.type == 72)
          num1 = 100f;
        if (this.type == 73)
          num1 = 10000f;
        if (this.type == 74)
          num1 = 1000000f;
        float num2 = stack * num1;
        float extraValue = (float) npc1.extraValue;
        int index2 = npc1.realLife;
        NPC npc2 = npc1;
        if (index2 >= 0 && Main.npc[index2].active)
        {
          npc2 = Main.npc[index2];
          extraValue = (float) npc2.extraValue;
        }
        else
          index2 = -1;
        if ((double) extraValue < (double) num2 && (double) extraValue + (double) num2 < 999000000.0)
        {
          Rectangle rectangle2 = new Rectangle((int) npc1.position.X, (int) npc1.position.Y, npc1.width, npc1.height);
          if (rectangle1.Intersects(rectangle2))
          {
            float num3 = (float) Main.rand.Next(50, 76) * 0.01f;
            if (this.type == 71)
              num3 += (float) Main.rand.Next(51) * 0.01f;
            if (this.type == 72)
              num3 += (float) Main.rand.Next(26) * 0.01f;
            if ((double) num3 > 1.0)
              num3 = 1f;
            int num4 = (int) ((double) this.stack * (double) num3);
            if (num4 < 1)
              num4 = 1;
            if (num4 > this.stack)
              num4 = this.stack;
            this.stack -= num4;
            int number2 = (int) ((double) num4 * (double) num1);
            int number = index1;
            if (index2 >= 0)
              number = index2;
            npc2.extraValue += number2;
            if (Main.netMode == 0)
              npc2.moneyPing(this.position);
            else
              NetMessage.SendData(92, number: number, number2: (float) number2, number3: this.position.X, number4: this.position.Y);
            if (this.stack <= 0)
              this.TurnToAir(true);
            NetMessage.SendData(21, number: i);
          }
        }
      }
    }
  }

  private void UpdateItem_VisualEffects()
  {
    if (this.type == 5043)
    {
      float num = (float) Main.rand.Next(90, 111) * 0.01f * (float) (((double) Main.essScale + 0.5) / 2.0);
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.25f * num, 0.25f * num, 0.25f * num);
    }
    else if (this.type == 116)
    {
      float num = (float) Main.rand.Next(95, 106) * 0.01f;
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.56f * num, 0.43f * num, 0.15f * num);
      if (Main.rand.Next(250) != 0)
        return;
      int index = Dust.NewDust(this.position, this.width, this.height, 6, Scale: (float) Main.rand.Next(3));
      if ((double) Main.dust[index].scale <= 1.0)
        return;
      Main.dust[index].noGravity = true;
    }
    else if (this.type == 3191)
    {
      float num = (float) Main.rand.Next(90, 111) * 0.01f * (float) (((double) Main.essScale + 0.5) / 2.0);
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.3f * num, 0.1f * num, 0.25f * num);
    }
    else if (this.type == 520 || this.type == 3454)
    {
      float num = (float) Main.rand.Next(90, 111) * 0.01f * Main.essScale;
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.5f * num, 0.1f * num, 0.25f * num);
    }
    else if (this.type == 521 || this.type == 3455)
    {
      float num = (float) Main.rand.Next(90, 111) * 0.01f * Main.essScale;
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.25f * num, 0.1f * num, 0.5f * num);
    }
    else if (this.type == 547 || this.type == 3453)
    {
      float num = (float) Main.rand.Next(90, 111) * 0.01f * Main.essScale;
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.5f * num, 0.3f * num, 0.05f * num);
    }
    else if (this.type == 548)
    {
      float num = (float) Main.rand.Next(90, 111) * 0.01f * Main.essScale;
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.1f * num, 0.1f * num, 0.6f * num);
    }
    else if (this.type == 575)
    {
      float num = (float) Main.rand.Next(90, 111) * 0.01f * Main.essScale;
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.1f * num, 0.3f * num, 0.5f * num);
    }
    else if (this.type == 549)
    {
      float num = (float) Main.rand.Next(90, 111) * 0.01f * Main.essScale;
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.1f * num, 0.5f * num, 0.2f * num);
    }
    else if (this.type == 58 || this.type == 1734 || this.type == 1867)
    {
      float num = (float) Main.rand.Next(90, 111) * 0.01f * (Main.essScale * 0.5f);
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.5f * num, 0.1f * num, 0.1f * num);
    }
    else if (this.type == 184 || this.type == 1735 || this.type == 1868 || this.type == 4143)
    {
      float num = (float) Main.rand.Next(90, 111) * 0.01f * (Main.essScale * 0.5f);
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.1f * num, 0.1f * num, 0.5f * num);
    }
    else if (this.type == 522)
    {
      float num = (float) Main.rand.Next(90, 111) * 0.01f * (Main.essScale * 0.2f);
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.5f * num, 1f * num, 0.1f * num);
    }
    else if (this.type == 1332)
    {
      float num = (float) Main.rand.Next(90, 111) * 0.01f * (Main.essScale * 0.2f);
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 1f * num, 1f * num, 0.1f * num);
    }
    else if (this.type == 3456)
      Lighting.AddLight(this.Center, new Vector3(0.2f, 0.4f, 0.5f) * Main.essScale);
    else if (this.type == 3457)
      Lighting.AddLight(this.Center, new Vector3(0.4f, 0.2f, 0.5f) * Main.essScale);
    else if (this.type == 3458)
      Lighting.AddLight(this.Center, new Vector3(0.5f, 0.4f, 0.2f) * Main.essScale);
    else if (this.type == 3459)
      Lighting.AddLight(this.Center, new Vector3(0.2f, 0.2f, 0.5f) * Main.essScale);
    else if (this.type == 501)
    {
      if (Main.rand.Next(6) != 0)
        return;
      int index = Dust.NewDust(this.position, this.width, this.height, 55, Alpha: 200, newColor: this.color);
      Main.dust[index].velocity *= 0.3f;
      Main.dust[index].scale *= 0.5f;
    }
    else if (this.type == 3822)
      Lighting.AddLight(this.Center, 0.1f, 0.3f, 0.1f);
    else if (this.type == 1970)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.75f, 0.0f, 0.75f);
    else if (this.type == 1972)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.0f, 0.0f, 0.75f);
    else if (this.type == 1971)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.75f, 0.75f, 0.0f);
    else if (this.type == 1973)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.0f, 0.75f, 0.0f);
    else if (this.type == 1974)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.75f, 0.0f, 0.0f);
    else if (this.type == 1975)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.75f, 0.75f, 0.75f);
    else if (this.type == 1976)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.75f, 0.375f, 0.0f);
    else if (this.type == 2679)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.6f, 0.0f, 0.6f);
    else if (this.type == 2687)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.0f, 0.0f, 0.6f);
    else if (this.type == 2689)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.6f, 0.6f, 0.0f);
    else if (this.type == 2683)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.0f, 0.6f, 0.0f);
    else if (this.type == 2685)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.6f, 0.0f, 0.0f);
    else if (this.type == 2681)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.6f, 0.6f, 0.6f);
    else if (this.type == 2677)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.6f, 0.375f, 0.0f);
    else if (this.type == 105)
    {
      if (this.wet)
        return;
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 1f, 0.95f, 0.8f);
    }
    else if (this.type == 2701)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.7f, 0.65f, 0.55f);
    else if (this.createTile == 4)
    {
      int placeStyle = this.placeStyle;
      if ((this.wet || !ItemID.Sets.Torches[this.type]) && !ItemID.Sets.WaterTorches[this.type])
        return;
      Lighting.AddLight(this.Center, placeStyle);
    }
    else if (this.type == 3114)
    {
      if (this.wet)
        return;
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 1f, 0.0f, 1f);
    }
    else if (this.type == 1245)
    {
      if (this.wet)
        return;
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 1f, 0.5f, 0.0f);
    }
    else if (this.type == 433)
    {
      if (this.wet)
        return;
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), (float) (0.5 * (double) Main.demonTorch + 1.0 * (1.0 - (double) Main.demonTorch)), 0.3f, (float) (1.0 * (double) Main.demonTorch + 0.5 * (1.0 - (double) Main.demonTorch)));
    }
    else if (this.type == 523)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.85f, 1.2f, 0.7f);
    else if (this.type == 974)
    {
      if (this.wet)
        return;
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.75f, 0.85f, 1.4f);
    }
    else if (this.type == 1333)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 1.25f, 1.25f, 0.7f);
    else if (this.type == 4383)
    {
      if (this.wet)
        return;
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 1.4f, 0.85f, 0.55f);
    }
    else if (this.type == 5293)
    {
      if (this.wet)
        return;
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.25f, 0.65f, 1f);
    }
    else if (this.type == 5353)
    {
      if (this.wet)
        return;
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.81f, 0.72f, 1f);
    }
    else if (this.type == 4384)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.25f, 1.3f, 0.8f);
    else if (this.type == 3045)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), (float) Main.DiscoR / (float) byte.MaxValue, (float) Main.DiscoG / (float) byte.MaxValue, (float) Main.DiscoB / (float) byte.MaxValue);
    else if (this.type == 3004)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.95f, 0.65f, 1.3f);
    else if (this.type == 2274)
    {
      float r = 0.75f;
      float g = 1.3499999f;
      float b = 1.5f;
      if (this.wet)
        return;
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), r, g, b);
    }
    else if (this.type >= 427 && this.type <= 432)
    {
      if (this.wet)
        return;
      float r = 0.0f;
      float g = 0.0f;
      float b = 0.0f;
      int num = this.type - 426;
      if (num == 1)
      {
        r = 0.1f;
        g = 0.2f;
        b = 1.1f;
      }
      if (num == 2)
      {
        r = 1f;
        g = 0.1f;
        b = 0.1f;
      }
      if (num == 3)
      {
        r = 0.0f;
        g = 1f;
        b = 0.1f;
      }
      if (num == 4)
      {
        r = 0.9f;
        g = 0.0f;
        b = 0.9f;
      }
      if (num == 5)
      {
        r = 1.3f;
        g = 1.3f;
        b = 1.3f;
      }
      if (num == 6)
      {
        r = 0.9f;
        g = 0.9f;
        b = 0.0f;
      }
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), r, g, b);
    }
    else if (this.type == 2777 || this.type == 2778 || this.type == 2779 || this.type == 2780 || this.type == 2781 || this.type == 2760 || this.type == 2761 || this.type == 2762 || this.type == 3524)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.4f, 0.16f, 0.36f);
    else if (this.type == 2772 || this.type == 2773 || this.type == 2774 || this.type == 2775 || this.type == 2776 || this.type == 2757 || this.type == 2758 || this.type == 2759 || this.type == 3523)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.0f, 0.36f, 0.4f);
    else if (this.type == 2782 || this.type == 2783 || this.type == 2784 || this.type == 2785 || this.type == 2786 || this.type == 2763 || this.type == 2764 || this.type == 2765 || this.type == 3522)
      Lighting.AddLight((int) (((double) this.position.X + (double) (this.width / 2)) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.5f, 0.25f, 0.05f);
    else if (this.type == 3462 || this.type == 3463 || this.type == 3464 || this.type == 3465 || this.type == 3466 || this.type == 3381 || this.type == 3382 || this.type == 3383 || this.type == 3525)
      Lighting.AddLight(this.Center, 0.3f, 0.3f, 0.2f);
    else if (this.type == 41)
    {
      if (this.wet)
        return;
      Lighting.AddLight((int) (((double) this.position.X + (double) this.width) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 1f, 0.75f, 0.55f);
    }
    else if (this.type == 988)
    {
      if (this.wet)
        return;
      Lighting.AddLight((int) (((double) this.position.X + (double) this.width) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.35f, 0.65f, 1f);
    }
    else if (this.type == 1326)
      Lighting.AddLight((int) this.Center.X / 16 /*0x10*/, (int) this.Center.Y / 16 /*0x10*/, 1f, 0.1f, 0.8f);
    else if (this.type == 5335)
      Lighting.AddLight((int) this.Center.X / 16 /*0x10*/, (int) this.Center.Y / 16 /*0x10*/, 0.85f, 0.1f, 0.8f);
    else if (this.type >= 5140 && this.type <= 5146)
    {
      float r = 1f;
      float g = 1f;
      float b = 1f;
      switch (this.type)
      {
        case 5140:
          r *= 0.9f;
          g *= 0.8f;
          b *= 0.1f;
          break;
        case 5141:
          r *= 0.25f;
          g *= 0.1f;
          b *= 0.0f;
          break;
        case 5142:
          r *= 0.0f;
          g *= 0.25f;
          b *= 0.0f;
          break;
        case 5143:
          r *= 0.0f;
          g *= 0.16f;
          b *= 0.34f;
          break;
        case 5144:
          r *= 0.3f;
          g *= 0.0f;
          b *= 0.17f;
          break;
        case 5145:
          r *= 0.3f;
          g *= 0.0f;
          b *= 0.35f;
          break;
        case 5146:
          r *= (float) Main.DiscoR / (float) byte.MaxValue;
          g *= (float) Main.DiscoG / (float) byte.MaxValue;
          b *= (float) Main.DiscoB / (float) byte.MaxValue;
          break;
      }
      Lighting.AddLight((int) (((double) this.position.X + (double) this.width) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), r, g, b);
    }
    else if (this.type == 282)
      Lighting.AddLight((int) (((double) this.position.X + (double) this.width) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.7f, 1f, 0.8f);
    else if (this.type == 286)
      Lighting.AddLight((int) (((double) this.position.X + (double) this.width) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.7f, 0.8f, 1f);
    else if (this.type == 3112)
      Lighting.AddLight((int) (((double) this.position.X + (double) this.width) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 1f, 0.6f, 0.85f);
    else if (this.type == 4776)
      Lighting.AddLight((int) (((double) this.position.X + (double) this.width) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.7f, 0.0f, 1f);
    else if (this.type == 3002)
      Lighting.AddLight((int) (((double) this.position.X + (double) this.width) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 1.05f, 0.95f, 0.55f);
    else if (this.type == 5643)
      Lighting.AddLight((int) (((double) this.position.X + (double) this.width) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), (float) Main.DiscoR / (float) byte.MaxValue, (float) Main.DiscoG / (float) byte.MaxValue, (float) Main.DiscoB / (float) byte.MaxValue);
    else if (this.type == 331)
      Lighting.AddLight((int) (((double) this.position.X + (double) this.width) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.55f, 0.75f, 0.6f);
    else if (this.type == 183)
      Lighting.AddLight((int) (((double) this.position.X + (double) this.width) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.15f, 0.45f, 0.9f);
    else if (this.type == 75)
    {
      Lighting.AddLight((int) (((double) this.position.X + (double) this.width) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.8f, 0.7f, 0.1f);
      if (this.timeSinceItemSpawned % 12 != 0)
        return;
      Dust dust = Dust.NewDustPerfect(this.Center + new Vector2(0.0f, (float) this.height * 0.2f) + Main.rand.NextVector2CircularEdge((float) this.width, (float) this.height * 0.6f) * (float) (0.30000001192092896 + (double) Main.rand.NextFloat() * 0.5), 228, new Vector2?(new Vector2(0.0f, (float) (-(double) Main.rand.NextFloat() * 0.30000001192092896 - 1.5))), (int) sbyte.MaxValue);
      dust.scale = 0.5f;
      dust.fadeIn = 1.1f;
      dust.noGravity = true;
      dust.noLight = true;
    }
    else
    {
      if (!ItemID.Sets.BossBag[this.type])
        return;
      Lighting.AddLight((int) (((double) this.position.X + (double) this.width) / 16.0), (int) (((double) this.position.Y + (double) (this.height / 2)) / 16.0), 0.4f, 0.4f, 0.4f);
      if (this.timeSinceItemSpawned % 12 != 0)
        return;
      Dust dust = Dust.NewDustPerfect(this.Center + new Vector2(0.0f, (float) this.height * -0.1f) + Main.rand.NextVector2CircularEdge((float) this.width * 0.6f, (float) this.height * 0.6f) * (float) (0.30000001192092896 + (double) Main.rand.NextFloat() * 0.5), 279, new Vector2?(new Vector2(0.0f, (float) (-(double) Main.rand.NextFloat() * 0.30000001192092896 - 1.5))), (int) sbyte.MaxValue);
      dust.scale = 0.5f;
      dust.fadeIn = 1.1f;
      dust.noGravity = true;
      dust.noLight = true;
      dust.alpha = 0;
    }
  }

  public IEntitySource GetNPCSource_FromThis()
  {
    return (IEntitySource) new EntitySource_Parent((IEntitySourceTarget) this);
  }

  public IEntitySource GetItemSource_Misc(int itemSourceId)
  {
    return (IEntitySource) new EntitySource_ByItemSourceId((IEntitySourceTarget) this, itemSourceId);
  }

  public static void ShimmerEffect(Vector2 shimmerPositon)
  {
    SoundEngine.PlaySound(SoundID.Item176, (int) shimmerPositon.X, (int) shimmerPositon.Y);
    for (int index1 = 0; index1 < 20; ++index1)
    {
      int index2 = Dust.NewDust(shimmerPositon, 1, 1, 309);
      Main.dust[index2].scale *= 1.2f;
      switch (Main.rand.Next(6))
      {
        case 0:
          Main.dust[index2].color = new Color((int) byte.MaxValue, (int) byte.MaxValue, 210);
          break;
        case 1:
          Main.dust[index2].color = new Color(190, 245, (int) byte.MaxValue);
          break;
        case 2:
          Main.dust[index2].color = new Color((int) byte.MaxValue, 150, (int) byte.MaxValue);
          break;
        default:
          Main.dust[index2].color = new Color(190, 175, (int) byte.MaxValue);
          break;
      }
    }
  }

  public void GetShimmered()
  {
    int shimmerEquivalentType = this.inner.GetShimmerEquivalentType();
    int decraftingRecipeIndex = ShimmerTransforms.GetDecraftingRecipeIndex(this.inner.GetShimmerEquivalentType(true));
    int transformToItem = ShimmerTransforms.GetTransformToItem(shimmerEquivalentType);
    if (ItemID.Sets.CommonCoin[shimmerEquivalentType])
    {
      switch (shimmerEquivalentType)
      {
        case 72:
          this.stack *= 100;
          break;
        case 73:
          this.stack *= 10000;
          break;
        case 74:
          if (this.stack > 1)
            this.stack = 1;
          this.stack *= 1000000;
          break;
      }
      Main.player[Main.myPlayer].AddCoinLuck(this.Center, this.stack);
      NetMessage.SendData(146, number: 1, number2: (float) (int) this.Center.X, number3: (float) (int) this.Center.Y, number4: (float) this.stack);
      this.type = 0;
      this.stack = 0;
    }
    else if (transformToItem > 0)
    {
      int stack = this.stack;
      this.SetDefaults(transformToItem);
      this.stack = stack;
      this.shimmered = true;
    }
    else if (this.type == 4986)
    {
      if (NPC.unlockedSlimeRainbowSpawn)
        return;
      NPC.unlockedSlimeRainbowSpawn = true;
      NetMessage.SendData(7);
      int index = NPC.NewNPC(this.GetNPCSource_FromThis(), (int) this.Center.X + 4, (int) this.Center.Y, 681);
      if (index >= 0)
      {
        NPC npc = Main.npc[index];
        npc.velocity = this.velocity;
        npc.shimmerTransparency = 1f;
      }
      WorldGen.CheckAchievement_RealEstateAndTownSlimes();
      --this.stack;
      if (this.stack <= 0)
        this.type = 0;
    }
    else if (this.type == 560)
    {
      if (Main.slimeRain)
        return;
      Main.StartSlimeRain();
      --this.stack;
      if (this.stack <= 0)
        this.type = 0;
      else
        this.shimmered = true;
    }
    else if (this.makeNPC > (short) 0)
    {
      int num = 50;
      int csToSpawnUpToSlot = NPC.GetAvailableAmountOfNPCsToSpawnUpToSlot(this.stack, Main.maxNPCs);
      while (num > 0 && csToSpawnUpToSlot > 0 && this.stack > 0)
      {
        --num;
        --csToSpawnUpToSlot;
        --this.stack;
        int index = NPCID.Sets.ShimmerTransformToNPC[(int) this.makeNPC] < 0 ? NPC.ReleaseNPC((int) this.Center.X, (int) this.Bottom.Y, (int) this.makeNPC, this.placeStyle, Main.myPlayer) : NPC.ReleaseNPC((int) this.Center.X, (int) this.Bottom.Y, NPCID.Sets.ShimmerTransformToNPC[(int) this.makeNPC], 0, Main.myPlayer);
        if (index >= 0)
          Main.npc[index].shimmerTransparency = 1f;
      }
      this.shimmered = true;
      if (this.stack <= 0)
        this.type = 0;
    }
    else if (decraftingRecipeIndex >= 0)
    {
      int decraftAmount = this.inner.FindDecraftAmount();
      Recipe recipe = Main.recipe[decraftingRecipeIndex];
      bool flag = recipe.requiredItem[1].stack > 0;
      IEnumerable<Recipe.RequiredItemEntry> requiredItemEntries = (IEnumerable<Recipe.RequiredItemEntry>) recipe.requiredItemQuickLookup;
      if (recipe.customShimmerResults != null)
        requiredItemEntries = recipe.customShimmerResults.Select<Item, Recipe.RequiredItemEntry>((Func<Item, Recipe.RequiredItemEntry>) (item => new Recipe.RequiredItemEntry()
        {
          itemIdOrRecipeGroup = item.type,
          stack = item.stack
        }));
      int num1 = 0;
      foreach (Recipe.RequiredItemEntry requiredItemEntry in requiredItemEntries)
      {
        if (requiredItemEntry.itemIdOrRecipeGroup > 0)
        {
          ++num1;
          int num2 = decraftAmount * requiredItemEntry.stack;
          int Type = requiredItemEntry.IsRecipeGroup ? requiredItemEntry.RecipeGroup.DecraftItemId : requiredItemEntry.itemIdOrRecipeGroup;
          if (recipe.alchemy)
          {
            for (int index = num2; index > 0; --index)
            {
              if (Main.rand.Next(3) == 0)
                --num2;
            }
          }
          while (num2 > 0)
          {
            int num3 = num2;
            if (num3 > 9999)
              num3 = 9999;
            num2 -= num3;
            int number = Item.NewItem(this.GetItemSource_Misc(ItemSourceID.Shimmer), (int) this.position.X, (int) this.position.Y, this.width, this.height, Type);
            WorldItem worldItem1 = Main.item[number];
            worldItem1.stack = num3;
            worldItem1.shimmerTime = 1f;
            worldItem1.shimmered = true;
            worldItem1.shimmerWet = true;
            worldItem1.wet = true;
            WorldItem worldItem2 = worldItem1;
            worldItem2.velocity = worldItem2.velocity * 0.1f;
            worldItem1.playerIndexTheItemIsReservedFor = Main.myPlayer;
            if (flag)
            {
              worldItem1.velocity.X = 1f * (float) num1;
              worldItem1.velocity.X *= (float) (1.0 + (double) num1 * 0.05000000074505806);
              if (num1 % 2 == 0)
                worldItem1.velocity.X *= -1f;
            }
            NetMessage.SendData(145, number: number, number2: 1f);
          }
        }
        else
          break;
      }
      this.stack -= decraftAmount * recipe.createItem.stack;
      if (this.stack <= 0)
      {
        this.stack = 0;
        this.type = 0;
      }
    }
    this.shimmerTime = this.stack <= 0 ? 0.0f : 1f;
    this.shimmerWet = true;
    this.wet = true;
    this.velocity = this.velocity * 0.1f;
    if (Main.netMode == 0)
    {
      WorldItem.ShimmerEffect(this.Center);
    }
    else
    {
      NetMessage.SendData(146, number2: (float) (int) this.Center.X, number3: (float) (int) this.Center.Y);
      NetMessage.SendData(145, number: this.whoAmI, number2: 1f);
    }
    AchievementsHelper.NotifyProgressionEvent(27);
    if (this.stack != 0)
      return;
    this.makeNPC = (short) -1;
    this.TurnToAir();
  }

  private static void SyncItemsInSection(int toClient, Point sectionCoordinates)
  {
    Rectangle rectangle = new Rectangle(sectionCoordinates.X * 200 * 16 /*0x10*/, sectionCoordinates.Y * 150 * 16 /*0x10*/, 3200, 2400);
    rectangle.Inflate(16 /*0x10*/, 16 /*0x10*/);
    for (int number = 0; number < 400; ++number)
    {
      WorldItem worldItem = Main.item[number];
      if (worldItem.active && rectangle.Contains(worldItem.Center.ToPoint()))
        NetMessage.SendData(160 /*0xA0*/, toClient, number: number);
    }
  }
}
