// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.TileEntity
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria.Audio;
using Terraria.GameInput;
using Terraria.UI;

#nullable disable
namespace Terraria.DataStructures;

public abstract class TileEntity
{
  public static TileEntitiesManager manager;
  public const int MaxEntitiesPerChunk = 1000;
  public static object EntityCreationLock = new object();
  public static List<TileEntity> UpdateEntities = new List<TileEntity>();
  public static Dictionary<int, TileEntity> ByID = new Dictionary<int, TileEntity>();
  public static Dictionary<Point16, TileEntity> ByPosition = new Dictionary<Point16, TileEntity>();
  public static int TileEntitiesNextID;
  public int ID;
  public Point16 Position;
  public byte type;
  public bool RequiresUpdates;

  public static int AssignNewID() => TileEntity.TileEntitiesNextID++;

  public static event Action _UpdateStart;

  public static event Action _UpdateEnd;

  public static void Clear()
  {
    TileEntity.ByID.Clear();
    TileEntity.ByPosition.Clear();
    TileEntity.UpdateEntities.Clear();
    TileEntity.TileEntitiesNextID = 0;
  }

  public static void PerformUpdates()
  {
    TileEntity.UpdateStart();
    foreach (TileEntity updateEntity in TileEntity.UpdateEntities)
      updateEntity.Update();
    TileEntity.UpdateEnd();
  }

  private static void UpdateStart()
  {
    if (TileEntity._UpdateStart == null)
      return;
    TileEntity._UpdateStart();
  }

  private static void UpdateEnd()
  {
    if (TileEntity._UpdateEnd == null)
      return;
    TileEntity._UpdateEnd();
  }

  public static void Add(TileEntity ent)
  {
    lock (TileEntity.EntityCreationLock)
    {
      TileEntity.ByID[ent.ID] = ent;
      TileEntity.ByPosition[ent.Position] = ent;
      if (!ent.RequiresUpdates)
        return;
      TileEntity.UpdateEntities.Add(ent);
    }
  }

  public virtual void OnPlaced()
  {
  }

  public virtual void OnRemoved()
  {
  }

  protected static int Place(int x, int y, int type)
  {
    TileEntity instance = TileEntity.manager.GenerateInstance(type);
    instance.Position = new Point16(x, y);
    instance.ID = TileEntity.AssignNewID();
    instance.type = (byte) type;
    TileEntity.Add(instance);
    instance.OnPlaced();
    return instance.ID;
  }

  public static void Kill(int x, int y, int type)
  {
    TileEntity entity;
    if (!TileEntity.ByPosition.TryGetValue(new Point16(x, y), out entity) || (int) entity.type != type)
      return;
    TileEntity.Remove(entity);
  }

  public static void Remove(TileEntity entity, bool ignorePosition = false)
  {
    lock (TileEntity.EntityCreationLock)
    {
      if (entity.RequiresUpdates)
        TileEntity.UpdateEntities.Remove(entity);
      TileEntity.ByID.Remove(entity.ID);
      if (!ignorePosition)
        TileEntity.ByPosition.Remove(entity.Position);
    }
    entity.OnRemoved();
  }

  public static void InitializeAll()
  {
    TileEntity.manager = new TileEntitiesManager();
    TileEntity.manager.RegisterAll();
  }

  public static void PlaceEntityNet(int x, int y, int type)
  {
    if (!WorldGen.InWorld(x, y) || TileEntity.ByPosition.ContainsKey(new Point16(x, y)))
      return;
    TileEntity.manager.NetPlaceEntity(type, x, y);
  }

  public static bool TryGetAt<T>(int x, int y, out T result) where T : TileEntity
  {
    result = default (T);
    TileEntity tileEntity;
    if (TileEntity.ByPosition.TryGetValue(new Point16(x, y), out tileEntity))
      result = tileEntity as T;
    return (object) result != null;
  }

  public static bool TryGet<T>(int id, out T result) where T : TileEntity
  {
    result = default (T);
    TileEntity tileEntity;
    if (TileEntity.ByID.TryGetValue(id, out tileEntity))
      result = tileEntity as T;
    return (object) result != null;
  }

  public virtual void Update()
  {
  }

  public static void Write(BinaryWriter writer, TileEntity ent, bool networkSend = false)
  {
    writer.Write(ent.type);
    ent.WriteInner(writer, networkSend);
  }

  public static TileEntity Read(BinaryReader reader, int gameVersion, bool networkSend = false)
  {
    byte id = reader.ReadByte();
    TileEntity instance = TileEntity.manager.GenerateInstance((int) id);
    instance.type = id;
    instance.ReadInner(reader, gameVersion, networkSend);
    return instance;
  }

  private void WriteInner(BinaryWriter writer, bool networkSend)
  {
    if (!networkSend)
      writer.Write(this.ID);
    writer.Write(this.Position.X);
    writer.Write(this.Position.Y);
    this.WriteExtraData(writer, networkSend);
  }

  private void ReadInner(BinaryReader reader, int gameVersion, bool networkSend)
  {
    if (!networkSend)
      this.ID = reader.ReadInt32();
    this.Position = new Point16(reader.ReadInt16(), reader.ReadInt16());
    this.ReadExtraData(reader, gameVersion, networkSend);
  }

  public virtual void WriteExtraData(BinaryWriter writer, bool networkSend)
  {
  }

  public virtual void ReadExtraData(BinaryReader reader, int gameVersion, bool networkSend)
  {
  }

  public virtual void OnPlayerUpdate(Player player)
  {
  }

  public static bool IsOccupied(int id, out int interactingPlayer)
  {
    interactingPlayer = -1;
    for (int index = 0; index < (int) byte.MaxValue; ++index)
    {
      Player player = Main.player[index];
      if (player.active && !player.dead && player.tileEntityAnchor.interactEntityID == id)
      {
        interactingPlayer = index;
        return true;
      }
    }
    return false;
  }

  public virtual void OnInventoryDraw(Player player, SpriteBatch spriteBatch)
  {
  }

  public virtual ItemSlot.AlternateClickAction? GetShiftClickAction(
    Item[] inv,
    int context = 0,
    int slot = 0)
  {
    return new ItemSlot.AlternateClickAction?();
  }

  public virtual bool PerformShiftClickAction(Item[] inv, int context = 0, int slot = 0) => false;

  public static void BasicOpenCloseInteraction(Player player, int x, int y, int id)
  {
    player.CloseSign();
    if (Main.netMode != 1)
    {
      Main.stackSplit = 600;
      player.GamepadEnableGrappleCooldown();
      int interactingPlayer;
      if (TileEntity.IsOccupied(id, out interactingPlayer))
      {
        if (interactingPlayer != player.whoAmI)
          return;
        SoundEngine.PlaySound(11);
        player.tileEntityAnchor.Clear();
      }
      else
        TileEntity.SetInteractionAnchor(player, x, y, id);
    }
    else
    {
      Main.stackSplit = 600;
      player.GamepadEnableGrappleCooldown();
      int interactingPlayer;
      if (TileEntity.IsOccupied(id, out interactingPlayer))
      {
        if (interactingPlayer != player.whoAmI)
          return;
        SoundEngine.PlaySound(11);
        player.tileEntityAnchor.Clear();
        NetMessage.SendData(122, number: -1, number2: (float) Main.myPlayer);
      }
      else
        NetMessage.SendData(122, number: id, number2: (float) Main.myPlayer);
    }
  }

  public static void SetInteractionAnchor(Player player, int x, int y, int id)
  {
    player.chest = -1;
    player.SetTalkNPC(-1);
    if (player.whoAmI == Main.myPlayer)
    {
      int num = player.tileEntityAnchor.interactEntityID == -1 ? 1 : 0;
      IngameUIWindows.CloseAll(true);
      Main.playerInventory = true;
      Main.PipsUseGrid = false;
      if (PlayerInput.GrappleAndInteractAreShared)
        PlayerInput.Triggers.JustPressed.Grapple = false;
      if (num == 0)
        SoundEngine.PlaySound(12);
      else
        SoundEngine.PlaySound(10);
    }
    player.tileEntityAnchor.Set(id, x, y);
  }

  public virtual void RegisterTileEntityID(int assignedID)
  {
  }

  public virtual void NetPlaceEntityAttempt(int x, int y)
  {
  }

  public virtual bool IsTileValidForEntity(int x, int y) => false;

  public virtual TileEntity GenerateInstance() => (TileEntity) null;

  public virtual void OnWorldLoaded()
  {
  }
}
