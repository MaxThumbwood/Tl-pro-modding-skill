// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Tile_Entities.TETrainingDummy
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

public class TETrainingDummy : TileEntityType<TETrainingDummy>
{
  private static List<Rectangle> playerBoxes = new List<Rectangle>();
  private static bool playerBoxFilled;
  private static bool npcSlotsFull;
  public int npc;
  public int activationRetryCooldown;

  public override void RegisterTileEntityID(int assignedID)
  {
    base.RegisterTileEntityID(assignedID);
    TileEntity._UpdateStart += new Action(TETrainingDummy.ClearBoxes);
  }

  public override void NetPlaceEntityAttempt(int x, int y)
  {
    TileEntityType<TETrainingDummy>.Place(x, y);
  }

  public override bool IsTileValidForEntity(int x, int y) => TETrainingDummy.ValidTile(x, y);

  public static void ClearBoxes()
  {
    TETrainingDummy.playerBoxes.Clear();
    TETrainingDummy.playerBoxFilled = false;
    TETrainingDummy.npcSlotsFull = false;
  }

  public override void Update()
  {
    if (this.npc != -1)
    {
      if (Main.npc[this.npc].active && Main.npc[this.npc].type == 488 && (double) Main.npc[this.npc].ai[0] == (double) this.Position.X && (double) Main.npc[this.npc].ai[1] == (double) this.Position.Y)
        return;
      this.Deactivate();
    }
    else
    {
      if (TETrainingDummy.npcSlotsFull)
        return;
      TETrainingDummy.FillPlayerHitboxes();
      Rectangle rectangle = new Rectangle((int) this.Position.X * 16 /*0x10*/, (int) this.Position.Y * 16 /*0x10*/, 32 /*0x20*/, 48 /*0x30*/);
      rectangle.Inflate(1600, 1600);
      bool flag = false;
      foreach (Rectangle playerBox in TETrainingDummy.playerBoxes)
      {
        if (playerBox.Intersects(rectangle))
        {
          flag = true;
          break;
        }
      }
      if (!flag)
        return;
      this.Activate();
    }
  }

  private static void FillPlayerHitboxes()
  {
    if (TETrainingDummy.playerBoxFilled)
      return;
    for (int index = 0; index < (int) byte.MaxValue; ++index)
    {
      if (Main.player[index].active)
        TETrainingDummy.playerBoxes.Add(Main.player[index].getRect());
    }
    TETrainingDummy.playerBoxFilled = true;
  }

  public static bool ValidTile(int x, int y)
  {
    return Main.tile[x, y].active() && Main.tile[x, y].type == (ushort) 378 && Main.tile[x, y].frameY == (short) 0 && (int) Main.tile[x, y].frameX % 36 == 0;
  }

  public TETrainingDummy()
  {
    this.npc = -1;
    this.RequiresUpdates = true;
  }

  public static int Hook_AfterPlacement(
    int x,
    int y,
    int type = 378,
    int style = 0,
    int direction = 1,
    int alternate = 0)
  {
    if (Main.netMode != 1)
      return TileEntityType<TETrainingDummy>.Place(x - 1, y - 2);
    NetMessage.SendTileSquare(Main.myPlayer, x - 1, y - 2, 2, 3);
    NetMessage.SendData(87, number: x - 1, number2: (float) (y - 2), number3: (float) TileEntityType<TETrainingDummy>.EntityTypeID);
    return -1;
  }

  public override void WriteExtraData(BinaryWriter writer, bool networkSend)
  {
    writer.Write((short) this.npc);
  }

  public override void ReadExtraData(BinaryReader reader, int gameVersion, bool networkSend)
  {
    this.npc = (int) reader.ReadInt16();
  }

  private void Activate()
  {
    int index = NPC.NewNPC((IEntitySource) new EntitySource_TileEntity((TileEntity) this), (int) this.Position.X * 16 /*0x10*/ + 16 /*0x10*/, (int) this.Position.Y * 16 /*0x10*/ + 48 /*0x30*/, 488, 100);
    if (index == Main.maxNPCs)
    {
      TETrainingDummy.npcSlotsFull = true;
    }
    else
    {
      Main.npc[index].ai[0] = (float) this.Position.X;
      Main.npc[index].ai[1] = (float) this.Position.Y;
      Main.npc[index].netUpdate = true;
      this.npc = index;
      if (Main.netMode == 1)
        return;
      NetMessage.SendData(86, number: this.ID, number2: (float) this.Position.X, number3: (float) this.Position.Y);
    }
  }

  public void Deactivate()
  {
    if (this.npc != -1)
      Main.npc[this.npc].active = false;
    this.npc = -1;
    if (Main.netMode == 1)
      return;
    NetMessage.SendData(86, number: this.ID, number2: (float) this.Position.X, number3: (float) this.Position.Y);
  }

  public override string ToString()
  {
    return $"{(object) this.Position.X}x  {(object) this.Position.Y}y npc: {(object) this.npc}";
  }
}
