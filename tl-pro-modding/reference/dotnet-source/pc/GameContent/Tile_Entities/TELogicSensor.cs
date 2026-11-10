// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Tile_Entities.TELogicSensor
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.GameContent.Tile_Entities;

public class TELogicSensor : TileEntityType<TELogicSensor>
{
  private static Dictionary<int, Rectangle> playerBox = new Dictionary<int, Rectangle>();
  private static List<Tuple<Point16, bool>> tripPoints = new List<Tuple<Point16, bool>>();
  private static List<int> markedIDsForRemoval = new List<int>();
  private static bool inUpdateLoop;
  private static bool playerBoxFilled;
  public TELogicSensor.LogicCheckType logicCheck;
  public bool On;
  public int CountedData;

  public override void RegisterTileEntityID(int assignedID)
  {
    base.RegisterTileEntityID(assignedID);
    TileEntity._UpdateStart += new Action(TELogicSensor.UpdateStartInternal);
    TileEntity._UpdateEnd += new Action(TELogicSensor.UpdateEndInternal);
  }

  public override void OnPlaced() => this.FigureCheckState();

  public override bool IsTileValidForEntity(int x, int y) => TELogicSensor.ValidTile(x, y);

  private static void UpdateStartInternal()
  {
    TELogicSensor.inUpdateLoop = true;
    TELogicSensor.markedIDsForRemoval.Clear();
    TELogicSensor.playerBox.Clear();
    TELogicSensor.playerBoxFilled = false;
    TELogicSensor.FillPlayerHitboxes();
  }

  private static void FillPlayerHitboxes()
  {
    if (TELogicSensor.playerBoxFilled)
      return;
    for (int key = 0; key < (int) byte.MaxValue; ++key)
    {
      Player player = Main.player[key];
      if (player.active && !player.dead && !player.ghost)
        TELogicSensor.playerBox[key] = player.getRect();
    }
    TELogicSensor.playerBoxFilled = true;
  }

  private static void UpdateEndInternal()
  {
    TELogicSensor.inUpdateLoop = false;
    foreach (Tuple<Point16, bool> tripPoint in TELogicSensor.tripPoints)
    {
      Wiring.blockPlayerTeleportationForOneIteration = tripPoint.Item2;
      Wiring.HitSwitch((int) tripPoint.Item1.X, (int) tripPoint.Item1.Y);
      if (Main.netMode == 2)
        NetMessage.SendData(59, number: (int) tripPoint.Item1.X, number2: (float) tripPoint.Item1.Y);
    }
    Wiring.blockPlayerTeleportationForOneIteration = false;
    TELogicSensor.tripPoints.Clear();
    foreach (int id in TELogicSensor.markedIDsForRemoval)
    {
      TELogicSensor result;
      if (TileEntity.TryGet<TELogicSensor>(id, out result))
        TileEntity.Remove((TileEntity) result);
    }
    TELogicSensor.markedIDsForRemoval.Clear();
  }

  public override void Update()
  {
    bool state = TELogicSensor.GetState((int) this.Position.X, (int) this.Position.Y, this.logicCheck, this);
    switch (this.logicCheck)
    {
      case TELogicSensor.LogicCheckType.Day:
      case TELogicSensor.LogicCheckType.Night:
        if (!this.On & state)
          this.ChangeState(true, true);
        if (!this.On || state)
          break;
        this.ChangeState(false, false);
        break;
      case TELogicSensor.LogicCheckType.PlayerAbove:
      case TELogicSensor.LogicCheckType.Water:
      case TELogicSensor.LogicCheckType.Lava:
      case TELogicSensor.LogicCheckType.Honey:
      case TELogicSensor.LogicCheckType.Liquid:
        if (this.On == state)
          break;
        this.ChangeState(state, true);
        break;
    }
  }

  public void ChangeState(bool onState, bool TripWire)
  {
    if (onState != this.On && !TELogicSensor.SanityCheck((int) this.Position.X, (int) this.Position.Y))
      return;
    Main.tile[(int) this.Position.X, (int) this.Position.Y].frameX = onState ? (short) 18 : (short) 0;
    this.On = onState;
    if (Main.netMode == 2)
      NetMessage.SendTileSquare(-1, (int) this.Position.X, (int) this.Position.Y);
    if (!TripWire || Main.netMode == 1)
      return;
    TELogicSensor.tripPoints.Add(Tuple.Create<Point16, bool>(this.Position, this.logicCheck == TELogicSensor.LogicCheckType.PlayerAbove));
  }

  public static bool ValidTile(int x, int y)
  {
    return Main.tile[x, y].active() && Main.tile[x, y].type == (ushort) 423 && (int) Main.tile[x, y].frameY % 18 == 0 && (int) Main.tile[x, y].frameX % 18 == 0;
  }

  public TELogicSensor()
  {
    this.logicCheck = TELogicSensor.LogicCheckType.None;
    this.On = false;
    this.RequiresUpdates = true;
  }

  public static TELogicSensor.LogicCheckType FigureCheckType(int x, int y, out bool on)
  {
    on = false;
    if (!WorldGen.InWorld(x, y))
      return TELogicSensor.LogicCheckType.None;
    Tile tile = Main.tile[x, y];
    if (tile == null)
      return TELogicSensor.LogicCheckType.None;
    TELogicSensor.LogicCheckType type = TELogicSensor.LogicCheckType.None;
    switch ((int) tile.frameY / 18)
    {
      case 0:
        type = TELogicSensor.LogicCheckType.Day;
        break;
      case 1:
        type = TELogicSensor.LogicCheckType.Night;
        break;
      case 2:
        type = TELogicSensor.LogicCheckType.PlayerAbove;
        break;
      case 3:
        type = TELogicSensor.LogicCheckType.Water;
        break;
      case 4:
        type = TELogicSensor.LogicCheckType.Lava;
        break;
      case 5:
        type = TELogicSensor.LogicCheckType.Honey;
        break;
      case 6:
        type = TELogicSensor.LogicCheckType.Liquid;
        break;
    }
    on = TELogicSensor.GetState(x, y, type);
    return type;
  }

  public static bool GetState(
    int x,
    int y,
    TELogicSensor.LogicCheckType type,
    TELogicSensor instance = null)
  {
    switch (type)
    {
      case TELogicSensor.LogicCheckType.Day:
        return Main.dayTime;
      case TELogicSensor.LogicCheckType.Night:
        return !Main.dayTime;
      case TELogicSensor.LogicCheckType.PlayerAbove:
        bool state1 = false;
        Rectangle rectangle = new Rectangle(x * 16 /*0x10*/ - 32 /*0x20*/ - 1, y * 16 /*0x10*/ - 160 /*0xA0*/ - 1, 82, 162);
        foreach (KeyValuePair<int, Rectangle> keyValuePair in TELogicSensor.playerBox)
        {
          if (keyValuePair.Value.Intersects(rectangle))
          {
            state1 = true;
            break;
          }
        }
        return state1;
      case TELogicSensor.LogicCheckType.Water:
      case TELogicSensor.LogicCheckType.Lava:
      case TELogicSensor.LogicCheckType.Honey:
      case TELogicSensor.LogicCheckType.Liquid:
        if (instance == null)
          return false;
        Tile tile = Main.tile[x, y];
        bool state2 = true;
        if (tile == null || tile.liquid == (byte) 0)
          state2 = false;
        if (!tile.lava() && type == TELogicSensor.LogicCheckType.Lava)
          state2 = false;
        if (!tile.honey() && type == TELogicSensor.LogicCheckType.Honey)
          state2 = false;
        if ((tile.honey() || tile.lava() || tile.shimmer()) && type == TELogicSensor.LogicCheckType.Water)
          state2 = false;
        if (!state2 && instance.On)
        {
          if (instance.CountedData == 0)
            instance.CountedData = 15;
          else if (instance.CountedData > 0)
            --instance.CountedData;
          state2 = instance.CountedData > 0;
        }
        return state2;
      default:
        return false;
    }
  }

  public void FigureCheckState()
  {
    this.logicCheck = TELogicSensor.FigureCheckType((int) this.Position.X, (int) this.Position.Y, out this.On);
    TELogicSensor.GetFrame((int) this.Position.X, (int) this.Position.Y, this.logicCheck, this.On);
  }

  public static void GetFrame(int x, int y, TELogicSensor.LogicCheckType type, bool on)
  {
    Main.tile[x, y].frameX = on ? (short) 18 : (short) 0;
    switch (type)
    {
      case TELogicSensor.LogicCheckType.Day:
        Main.tile[x, y].frameY = (short) 0;
        break;
      case TELogicSensor.LogicCheckType.Night:
        Main.tile[x, y].frameY = (short) 18;
        break;
      case TELogicSensor.LogicCheckType.PlayerAbove:
        Main.tile[x, y].frameY = (short) 36;
        break;
      case TELogicSensor.LogicCheckType.Water:
        Main.tile[x, y].frameY = (short) 54;
        break;
      case TELogicSensor.LogicCheckType.Lava:
        Main.tile[x, y].frameY = (short) 72;
        break;
      case TELogicSensor.LogicCheckType.Honey:
        Main.tile[x, y].frameY = (short) 90;
        break;
      case TELogicSensor.LogicCheckType.Liquid:
        Main.tile[x, y].frameY = (short) 108;
        break;
      default:
        Main.tile[x, y].frameY = (short) 0;
        break;
    }
  }

  public static bool SanityCheck(int x, int y)
  {
    if (Main.tile[x, y].active() && Main.tile[x, y].type == (ushort) 423)
      return true;
    TELogicSensor.Kill(x, y);
    return false;
  }

  public static int Hook_AfterPlacement(
    int x,
    int y,
    int type = 423,
    int style = 0,
    int direction = 1,
    int alternate = 0)
  {
    bool on;
    TELogicSensor.LogicCheckType type1 = TELogicSensor.FigureCheckType(x, y, out on);
    TELogicSensor.GetFrame(x, y, type1, on);
    if (Main.netMode != 1)
      return TileEntityType<TELogicSensor>.Place(x, y);
    NetMessage.SendTileSquare(Main.myPlayer, x, y);
    NetMessage.SendData(87, number: x, number2: (float) y, number3: (float) TileEntityType<TELogicSensor>.EntityTypeID);
    return -1;
  }

  public new static void Kill(int x, int y)
  {
    TELogicSensor result;
    if (!TileEntity.TryGetAt<TELogicSensor>(x, y, out result))
      return;
    Wiring.blockPlayerTeleportationForOneIteration = result.logicCheck == TELogicSensor.LogicCheckType.PlayerAbove;
    bool flag = false;
    if (result.logicCheck == TELogicSensor.LogicCheckType.PlayerAbove && result.On)
      flag = true;
    else if (result.logicCheck == TELogicSensor.LogicCheckType.Water && result.On)
      flag = true;
    else if (result.logicCheck == TELogicSensor.LogicCheckType.Lava && result.On)
      flag = true;
    else if (result.logicCheck == TELogicSensor.LogicCheckType.Honey && result.On)
      flag = true;
    else if (result.logicCheck == TELogicSensor.LogicCheckType.Liquid && result.On)
      flag = true;
    if (flag)
    {
      Wiring.HitSwitch((int) result.Position.X, (int) result.Position.Y);
      NetMessage.SendData(59, number: (int) result.Position.X, number2: (float) result.Position.Y);
    }
    Wiring.blockPlayerTeleportationForOneIteration = false;
    if (TELogicSensor.inUpdateLoop)
      TELogicSensor.markedIDsForRemoval.Add(result.ID);
    else
      TileEntity.Remove((TileEntity) result);
  }

  public override void WriteExtraData(BinaryWriter writer, bool networkSend)
  {
    if (networkSend)
      return;
    writer.Write((byte) this.logicCheck);
    writer.Write(this.On);
  }

  public override void ReadExtraData(BinaryReader reader, int gameVersion, bool networkSend)
  {
    if (networkSend)
      return;
    this.logicCheck = (TELogicSensor.LogicCheckType) reader.ReadByte();
    this.On = reader.ReadBoolean();
  }

  public override string ToString()
  {
    return $"{(object) this.Position.X}x  {(object) this.Position.Y}y {(object) this.logicCheck}";
  }

  public enum LogicCheckType
  {
    None,
    Day,
    Night,
    PlayerAbove,
    Water,
    Lava,
    Honey,
    Liquid,
  }
}
