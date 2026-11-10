// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.TileSnapshot
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Threading;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.IO;

#nullable disable
namespace Terraria.Utilities;

public static class TileSnapshot
{
  private static WorldFileData _worldFile;
  private static TileSnapshot.TileStruct[] _tiles;
  private static List<TileEntity> _tileEntities;
  private static List<Chest> _chests;
  private static MemoryStream _tempStream = new MemoryStream();
  private static BinaryWriter _tempWriter = new BinaryWriter((Stream) TileSnapshot._tempStream);
  private static BinaryReader _tempReader = new BinaryReader((Stream) TileSnapshot._tempStream);

  public static object Context { get; private set; }

  public static void Create(object context = null)
  {
    TileSnapshot.Context = context;
    TileSnapshot._worldFile = Main.ActiveWorldFileData;
    TileSnapshot.SaveTiles();
    TileSnapshot.SaveTileEntities(true);
    TileSnapshot.SaveChests(true);
  }

  private static void SaveTiles()
  {
    Array.Resize<TileSnapshot.TileStruct>(ref TileSnapshot._tiles, Main.maxTilesX * Main.maxTilesY);
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: method pointer
    FastParallel.For(0, Main.maxTilesX, TileSnapshot.\u003C\u003Ec.\u003C\u003E9__10_0 ?? (TileSnapshot.\u003C\u003Ec.\u003C\u003E9__10_0 = new ParallelForAction((object) TileSnapshot.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CSaveTiles\u003Eb__10_0))), (object) null);
  }

  private static void SaveTileEntities(bool clone)
  {
    if (TileSnapshot._tileEntities == null)
      TileSnapshot._tileEntities = new List<TileEntity>(TileEntity.ByID.Count);
    TileSnapshot._tileEntities.Clear();
    lock (TileEntity.EntityCreationLock)
    {
      foreach (TileEntity ent in TileEntity.ByID.Values)
        TileSnapshot._tileEntities.Add(clone ? TileSnapshot.Clone(ent) : ent);
    }
  }

  private static void SaveChests(bool clone)
  {
    if (TileSnapshot._chests == null)
      TileSnapshot._chests = new List<Chest>(8000);
    TileSnapshot._chests.Clear();
    foreach (Chest chest in Main.chest)
    {
      if (chest != null)
        TileSnapshot._chests.Add(clone ? chest.CloneWithSeparateItems() : chest);
    }
  }

  public static bool IsCreated => TileSnapshot._tiles != null;

  public static bool SizeMatches
  {
    get
    {
      return TileSnapshot._worldFile.WorldSizeX == Main.ActiveWorldFileData.WorldSizeX && TileSnapshot._worldFile.WorldSizeY == Main.ActiveWorldFileData.WorldSizeY;
    }
  }

  public static IEnumerable<Point> Compare()
  {
    bool any = false;
    for (int x = 0; x < Main.maxTilesX; ++x)
    {
      for (int y = 0; y < Main.maxTilesY; ++y)
      {
        TileSnapshot.TileStruct tileStruct = TileSnapshot.TileStruct.From(Main.tile[x, y]);
        TileSnapshot.TileStruct tile = TileSnapshot._tiles[x * Main.maxTilesY + y];
        if (!(tileStruct == tile))
        {
          any = true;
          Main.NewText($"Mismatch at {(object) x}, {(object) y} world vs snap");
          Main.NewText(tileStruct.ToString());
          Main.NewText(tile.ToString());
          yield return new Point(x, y);
        }
      }
    }
    Main.NewText(any ? "No more differences" : "Snapshot matches identically");
  }

  private static TileEntity Clone(TileEntity ent)
  {
    TileSnapshot._tempStream.Position = 0L;
    TileEntity.Write(TileSnapshot._tempWriter, ent);
    TileSnapshot._tempStream.Position = 0L;
    return TileEntity.Read(TileSnapshot._tempReader, 318);
  }

  public static void Restore()
  {
    TileSnapshot.RestoreTiles();
    TileSnapshot.RestoreTileEntities(TileSnapshot._tileEntities, true);
    TileSnapshot.RestoreChests(TileSnapshot._chests, true);
    if (Main.dedServ)
      NetMessage.ResyncTiles(new Rectangle(0, 0, Main.maxTilesX, Main.maxTilesY));
    else
      Main.sectionManager.SetAllSectionsLoaded();
  }

  private static void RestoreTiles()
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: method pointer
    FastParallel.For(0, Main.maxTilesX, TileSnapshot.\u003C\u003Ec.\u003C\u003E9__23_0 ?? (TileSnapshot.\u003C\u003Ec.\u003C\u003E9__23_0 = new ParallelForAction((object) TileSnapshot.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CRestoreTiles\u003Eb__23_0))), (object) null);
  }

  private static void RestoreTileEntities(List<TileEntity> entities, bool clone)
  {
    lock (TileEntity.EntityCreationLock)
    {
      LeashedEntity.Clear(true);
      TileEntity.Clear();
      foreach (TileEntity entity in entities)
        TileSnapshot.Restore(clone ? TileSnapshot.Clone(entity) : entity);
    }
  }

  private static void Restore(TileEntity ent)
  {
    ent.ID = TileEntity.TileEntitiesNextID++;
    TileEntity.Add(ent);
    ent.OnWorldLoaded();
  }

  private static void RestoreChests(List<Chest> chests, bool clone)
  {
    Chest.Clear();
    foreach (Chest chest in chests)
      Chest.Assign(clone ? chest.CloneWithSeparateItems() : chest);
  }

  public static void Swap()
  {
    TileSnapshot._worldFile = Main.ActiveWorldFileData;
    TileSnapshot.SwapTiles();
    List<TileEntity> tileEntities = TileSnapshot._tileEntities;
    TileSnapshot._tileEntities = (List<TileEntity>) null;
    TileSnapshot.SaveTileEntities(false);
    TileSnapshot.RestoreTileEntities(tileEntities, false);
    List<Chest> chests = TileSnapshot._chests;
    TileSnapshot._chests = (List<Chest>) null;
    TileSnapshot.SaveChests(false);
    TileSnapshot.RestoreChests(chests, false);
    if (Main.dedServ)
      NetMessage.ResyncTiles(new Rectangle(0, 0, Main.maxTilesX, Main.maxTilesY));
    else
      Main.sectionManager.SetAllSectionsLoaded();
  }

  private static void SwapTiles()
  {
    Array.Resize<TileSnapshot.TileStruct>(ref TileSnapshot._tiles, Main.maxTilesX * Main.maxTilesY);
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: method pointer
    FastParallel.For(0, Main.maxTilesX, TileSnapshot.\u003C\u003Ec.\u003C\u003E9__28_0 ?? (TileSnapshot.\u003C\u003Ec.\u003C\u003E9__28_0 = new ParallelForAction((object) TileSnapshot.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CSwapTiles\u003Eb__28_0))), (object) null);
  }

  public static void Clear()
  {
    TileSnapshot._tiles = (TileSnapshot.TileStruct[]) null;
    TileSnapshot._tileEntities = (List<TileEntity>) null;
    TileSnapshot._chests = (List<Chest>) null;
    GC.Collect();
  }

  public static void Save(BinaryWriter writer)
  {
    writer.Write(Marshal.SizeOf(typeof (TileSnapshot.TileStruct)));
    foreach (TileSnapshot.TileStruct tile in TileSnapshot._tiles)
      tile.Write(writer);
    writer.Write(TileSnapshot._tileEntities.Count);
    foreach (TileEntity tileEntity in TileSnapshot._tileEntities)
      TileEntity.Write(writer, tileEntity);
    writer.Write(TileSnapshot._chests.Count);
    foreach (Chest chest in TileSnapshot._chests)
    {
      writer.Write(chest.index);
      writer.Write(chest.x);
      writer.Write(chest.y);
      writer.Write(chest.maxItems);
      writer.Write(chest.name);
      for (int index = 0; index < chest.maxItems; ++index)
      {
        Item obj = chest.item[index];
        if (obj.IsAir)
        {
          writer.Write((ushort) 0);
        }
        else
        {
          writer.Write((ushort) obj.type);
          writer.Write((ushort) obj.stack);
          writer.Write(obj.prefix);
        }
      }
    }
  }

  public static void Load(BinaryReader reader, object context = null)
  {
    if (reader.ReadInt32() != Marshal.SizeOf(typeof (TileSnapshot.TileStruct)))
      throw new Exception("TileSnapshot was saved with a different value of #define SNAPSHOT_RUNTIME_DATA");
    TileSnapshot.Context = context;
    TileSnapshot._worldFile = Main.ActiveWorldFileData;
    Array.Resize<TileSnapshot.TileStruct>(ref TileSnapshot._tiles, Main.maxTilesX * Main.maxTilesY);
    for (int index = 0; index < TileSnapshot._tiles.Length; ++index)
      TileSnapshot._tiles[index] = TileSnapshot.TileStruct.Read(reader);
    if (TileSnapshot._tileEntities == null)
      TileSnapshot._tileEntities = new List<TileEntity>();
    TileSnapshot._tileEntities.Clear();
    int num1 = reader.ReadInt32();
    for (int index = 0; index < num1; ++index)
      TileSnapshot._tileEntities.Add(TileEntity.Read(reader, 318));
    if (TileSnapshot._chests == null)
      TileSnapshot._chests = new List<Chest>();
    TileSnapshot._chests.Clear();
    int num2 = reader.ReadInt32();
    for (int index1 = 0; index1 < num2; ++index1)
    {
      Chest outOfArray = Chest.CreateOutOfArray(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32());
      outOfArray.name = reader.ReadString();
      outOfArray.FillWithEmptyInstances();
      for (int index2 = 0; index2 < outOfArray.maxItems; ++index2)
      {
        int Type = (int) reader.ReadUInt16();
        if (Type != 0)
        {
          Item obj = outOfArray.item[index2];
          obj.SetDefaults(Type);
          obj.stack = (int) reader.ReadUInt16();
          obj.Prefix((int) reader.ReadByte());
        }
      }
      TileSnapshot._chests.Add(outOfArray);
    }
  }

  public static void Save(string path)
  {
    using (BinaryWriter writer = new BinaryWriter((Stream) File.Create(path)))
      TileSnapshot.Save(writer);
  }

  public static void Load(string path, object context = null)
  {
    using (BinaryReader reader = new BinaryReader((Stream) File.OpenRead(path)))
      TileSnapshot.Load(reader, context);
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct TileStruct
  {
    [FieldOffset(0)]
    private ushort _type;
    [FieldOffset(2)]
    private ushort _wall_bTileHeader3_packed;
    [FieldOffset(4)]
    private ushort _sTileHeader;
    [FieldOffset(6)]
    private short _frameX;
    [FieldOffset(8)]
    private short _frameY;
    [FieldOffset(10)]
    private byte _liquid;
    [FieldOffset(11)]
    private byte _bTileHeader;
    [FieldOffset(0)]
    private int _i0;
    [FieldOffset(4)]
    private int _i1;
    [FieldOffset(8)]
    private int _i2;
    private static string[] _liquidNames = new string[4]
    {
      "water",
      "lava",
      "honey",
      "shimmer"
    };

    public static TileSnapshot.TileStruct From(Tile tile)
    {
      TileSnapshot.TileStruct tileStruct = new TileSnapshot.TileStruct();
      tileStruct._type = tile.type;
      ushort wall = tile.wall;
      tileStruct._sTileHeader = tile.sTileHeader;
      tileStruct._liquid = tile.liquid;
      tileStruct._bTileHeader = tile.bTileHeader;
      tileStruct._wall_bTileHeader3_packed = (ushort) ((uint) wall | (uint) (((int) tile.bTileHeader3 & 224 /*0xE0*/) << 8));
      if (((int) tileStruct._sTileHeader & 32 /*0x20*/) == 0)
      {
        tileStruct._type = (ushort) 0;
        tileStruct._sTileHeader &= (ushort) 35808;
      }
      else
      {
        if (Main.tileFrameImportant[(int) tileStruct._type])
        {
          tileStruct._frameX = tile.frameX;
          tileStruct._frameY = tile.frameY;
        }
        if (((int) tileStruct._sTileHeader & 29696) != 0 && !TileID.Sets.SaveSlopes[(int) tileStruct._type])
          tileStruct._sTileHeader &= (ushort) 35839;
      }
      if (wall == (ushort) 0)
        tileStruct._bTileHeader &= (byte) 224 /*0xE0*/;
      if (tileStruct._liquid == (byte) 0)
        tileStruct._bTileHeader &= (byte) 159;
      return tileStruct;
    }

    public void Apply(Tile tile)
    {
      tile.type = this._type;
      tile.wall = (ushort) ((uint) this._wall_bTileHeader3_packed & 8191U /*0x1FFF*/);
      tile.sTileHeader = this._sTileHeader;
      tile.frameX = this._frameX;
      tile.frameY = this._frameY;
      tile.liquid = this._liquid;
      tile.bTileHeader = this._bTileHeader;
      tile.bTileHeader2 = (byte) 0;
      tile.bTileHeader3 = (byte) ((int) this._wall_bTileHeader3_packed >> 8 & 224 /*0xE0*/);
    }

    public static bool operator ==(TileSnapshot.TileStruct lhs, TileSnapshot.TileStruct rhs)
    {
      return lhs._i0 == rhs._i0 && lhs._i1 == rhs._i1 && lhs._i2 == rhs._i2;
    }

    public static bool operator !=(TileSnapshot.TileStruct lhs, TileSnapshot.TileStruct rhs)
    {
      return !(lhs == rhs);
    }

    public override bool Equals(object obj)
    {
      return obj is TileSnapshot.TileStruct tileStruct && tileStruct == this;
    }

    public override int GetHashCode() => this._i0 ^ this._i1 ^ this._i2;

    public override string ToString()
    {
      int num1 = ((uint) this._sTileHeader & 32U /*0x20*/) > 0U ? 1 : 0;
      int num2 = (int) this._sTileHeader & 31 /*0x1F*/;
      bool flag1 = ((uint) this._sTileHeader & 1024U /*0x0400*/) > 0U;
      int num3 = ((int) this._sTileHeader & 28672 /*0x7000*/) >> 12;
      int num4 = (int) this._wall_bTileHeader3_packed & 8191 /*0x1FFF*/;
      int num5 = (int) this._bTileHeader & 31 /*0x1F*/;
      int index = ((int) this._bTileHeader & 96 /*0x60*/) >> 5;
      bool flag2 = ((uint) this._sTileHeader & 128U /*0x80*/) > 0U;
      bool flag3 = ((uint) this._sTileHeader & 256U /*0x0100*/) > 0U;
      bool flag4 = ((uint) this._sTileHeader & 512U /*0x0200*/) > 0U;
      bool flag5 = ((uint) this._bTileHeader & 128U /*0x80*/) > 0U;
      bool flag6 = ((uint) this._sTileHeader & 2048U /*0x0800*/) > 0U;
      bool flag7 = ((uint) this._sTileHeader & 64U /*0x40*/) > 0U;
      bool flag8 = ((uint) this._wall_bTileHeader3_packed & 8192U /*0x2000*/) > 0U;
      bool flag9 = ((uint) this._wall_bTileHeader3_packed & 16384U /*0x4000*/) > 0U;
      bool flag10 = ((uint) this._sTileHeader & 32768U /*0x8000*/) > 0U;
      bool flag11 = ((uint) this._wall_bTileHeader3_packed & 32768U /*0x8000*/) > 0U;
      string str1 = "!tile";
      if (num1 != 0)
      {
        str1 = "tile:" + (object) this._type;
        if (num2 > 0)
          str1 = $"{str1}c{(object) num2}";
        if (flag1)
          str1 += "h";
        if (num3 != 0)
          str1 = $"{str1}s{(object) num3}";
        if (Main.tileFrameImportant[(int) this._type])
          str1 = $"{str1} f{(object) this._frameX},{(object) this._frameY}";
      }
      string str2 = "!wall";
      if (num4 > 0)
      {
        str2 = "wall:" + (object) num4;
        if (num5 > 0)
          str2 = $"{str2}c{(object) num5}";
      }
      string str3 = "!liquid";
      if (this._liquid > (byte) 0)
        str3 = $"{TileSnapshot.TileStruct._liquidNames[index]}:{(object) this._liquid}";
      return $"{str1} {str2} {str3} flags:{(ValueType) (char) (flag6 ? 97 : 48 /*0x30*/)}{(ValueType) (char) (flag7 ? 120 : 48 /*0x30*/)} {(ValueType) (char) (flag8 ? 69 : 48 /*0x30*/)}{(ValueType) (char) (flag9 ? 101 : 48 /*0x30*/)} {(ValueType) (char) (flag11 ? 70 : 48 /*0x30*/)}{(ValueType) (char) (flag10 ? 102 : 48 /*0x30*/)} {(ValueType) (char) (flag2 ? 114 : 48 /*0x30*/)}{(ValueType) (char) (flag3 ? 98 : 48 /*0x30*/)}{(ValueType) (char) (flag4 ? 103 : 48 /*0x30*/)}{(ValueType) (char) (flag5 ? 121 : 48 /*0x30*/)}";
    }

    public void Write(BinaryWriter writer)
    {
      writer.Write(this._i0);
      writer.Write(this._i1);
      writer.Write(this._i2);
    }

    public static TileSnapshot.TileStruct Read(BinaryReader reader)
    {
      return new TileSnapshot.TileStruct()
      {
        _i0 = reader.ReadInt32(),
        _i1 = reader.ReadInt32(),
        _i2 = reader.ReadInt32()
      };
    }
  }
}
