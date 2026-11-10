// Decompiled with JetBrains decompiler
// Type: Terraria.Map.WorldMap
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.IO;
using Terraria.IO;
using Terraria.Social;
using Terraria.Testing;
using Terraria.Utilities;

#nullable disable
namespace Terraria.Map;

public class WorldMap
{
  public readonly int MaxWidth;
  public readonly int MaxHeight;
  public const int BlackEdgeWidth = 40;
  private MapTile[,] _tiles;

  public MapTile this[int x, int y] => this._tiles[x, y];

  public WorldMap(int maxWidth, int maxHeight)
  {
    this.MaxWidth = maxWidth;
    this.MaxHeight = maxHeight;
    this._tiles = new MapTile[this.MaxWidth, this.MaxHeight];
  }

  public void ConsumeUpdate(int x, int y) => this._tiles[x, y].IsChanged = false;

  public void Update(int x, int y, byte light)
  {
    this._tiles[x, y] = MapHelper.CreateMapTile(x, y, light);
  }

  public void SetTile(int x, int y, ref MapTile tile) => this._tiles[x, y] = tile;

  public bool IsRevealed(int x, int y) => this._tiles[x, y].Light > (byte) 0;

  public bool UpdateLighting(int x, int y, byte light)
  {
    MapTile tile = this._tiles[x, y];
    if (light == (byte) 0 && tile.Light == (byte) 0)
      return false;
    MapTile mapTile = MapHelper.CreateMapTile(x, y, Math.Max(tile.Light, light));
    if (mapTile.Equals(tile))
      return false;
    this._tiles[x, y] = mapTile;
    return true;
  }

  public bool UpdateType(int x, int y) => this.UpdateType(x, y, ref this._tiles.Address(x, y));

  private bool UpdateType(int x, int y, ref MapTile mapTile)
  {
    if (!mapTile.UpdateQueued)
      return false;
    mapTile.UpdateQueued = false;
    if (mapTile.Light == (byte) 0 || !Main.sectionManager.TileLoaded(x, y))
      return false;
    bool flag = MapHelper.IsBackground((int) mapTile.Type);
    MapTile mapTile1 = MapHelper.CreateMapTile(x, y, mapTile.Light, flag ? (int) mapTile.Type : 0);
    if (mapTile1.Equals(mapTile))
      return false;
    mapTile = mapTile1;
    return true;
  }

  internal bool QueueUpdate(int x, int y) => this.QueueUpdate(ref this._tiles.Address(x, y));

  private bool QueueUpdate(ref MapTile mapTile)
  {
    if (mapTile.Light == (byte) 0 || mapTile.UpdateQueued)
      return false;
    mapTile.UpdateQueued = true;
    return true;
  }

  public void UnlockMapSection(int sectionX, int sectionY)
  {
    int num1 = sectionX * 200;
    int num2 = num1 + 200;
    int num3 = sectionY * 150;
    int num4 = num3 + 150;
    int min = 40;
    int num5 = Utils.Clamp<int>(num1, min, Main.maxTilesX - min);
    int num6 = Utils.Clamp<int>(num2, min, Main.maxTilesX - min);
    int num7 = Utils.Clamp<int>(num3, min, Main.maxTilesY - min);
    int num8 = Utils.Clamp<int>(num4, min, Main.maxTilesY - min);
    if (DebugOptions.unlockMap == 2)
    {
      for (int x = num5; x < num6; ++x)
      {
        for (int y = num7; y < num8; ++y)
          this.UnlockMapTilePretty(x, y);
      }
    }
    else
    {
      for (int x = num5; x < num6; ++x)
      {
        for (int y = num7; y < num8; ++y)
          this.UpdateLighting(x, y, byte.MaxValue);
      }
    }
  }

  public void UnlockMapTilePretty(int x, int y)
  {
    if (!WorldGen.InWorld(x, y, 12) || WorldGen.SolidTile(x, y))
      return;
    int num1 = 5;
    float maxValue = (float) byte.MaxValue;
    Tile tileSafely = Framing.GetTileSafely(x, y);
    if (tileSafely.liquid > (byte) 0 && !tileSafely.lava())
      return;
    if (tileSafely.wall > (ushort) 0)
      maxValue *= 0.8f;
    if ((double) y >= Main.worldSurface)
      maxValue *= 0.7f;
    for (int index1 = -num1; index1 <= num1; ++index1)
    {
      for (int index2 = -num1; index2 <= num1; ++index2)
      {
        int x1 = x + index1;
        int y1 = y + index2;
        float num2 = (float) (num1 - Math.Abs(index1) - Math.Abs(index2));
        if ((double) num2 >= 0.0)
          this.UpdateLighting(x1, y1, (byte) ((double) maxValue * ((double) num2 / (double) num1)));
      }
    }
  }

  public void Load()
  {
    Lighting.Clear();
    bool isCloudSave = Main.ActivePlayerFileData.IsCloudSave;
    if (isCloudSave && SocialAPI.Cloud == null || !Main.mapEnabled)
      return;
    string mapPath;
    if (!WorldMap.TryGetMapPath(Main.ActivePlayerFileData, Main.ActiveWorldFileData, out mapPath))
    {
      Main.MapFileMetadata = FileMetadata.FromCurrentSettings(FileType.Map);
    }
    else
    {
      using (MemoryStream input = new MemoryStream(FileUtilities.ReadAllBytes(mapPath, isCloudSave)))
      {
        using (BinaryReader fileIO = new BinaryReader((Stream) input))
        {
          try
          {
            int num = fileIO.ReadInt32();
            bool flag = (num & 32768 /*0x8000*/) == 32768 /*0x8000*/;
            int release = num & -32769;
            if (release > 318)
              return;
            if (flag)
              MapHelper.LoadMapVersionCompressed(fileIO, release);
            else if (release <= 91)
              MapHelper.LoadMapVersion1(fileIO, release);
            else
              MapHelper.LoadMapVersion2(fileIO, release);
            this.ClearEdges();
            Main.clearMap = true;
            Main.loadMap = true;
            Main.loadMapLock = true;
            Main.refreshMap = false;
          }
          catch (Exception ex)
          {
            using (StreamWriter streamWriter = new StreamWriter("client-crashlog.txt", true))
            {
              streamWriter.WriteLine((object) DateTime.Now);
              streamWriter.WriteLine((object) ex);
              streamWriter.WriteLine("");
            }
            if (!isCloudSave)
              File.Copy(mapPath, mapPath + ".bad", true);
            this.Clear();
          }
        }
      }
    }
  }

  public static bool TryGetMapPath(
    PlayerFileData playerFileData,
    WorldFileData worldFileData,
    out string mapPath)
  {
    string str = playerFileData.Path.Substring(0, playerFileData.Path.Length - 4);
    mapPath = $"{str}{Path.DirectorySeparatorChar.ToString()}{worldFileData.MapFileName}.map";
    if (worldFileData.UseGuidAsMapName && !FileUtilities.Exists(mapPath, playerFileData.IsCloudSave))
      mapPath = $"{str}{Path.DirectorySeparatorChar.ToString()}{(object) worldFileData.WorldId}.map";
    return FileUtilities.Exists(mapPath, playerFileData.IsCloudSave);
  }

  public void Save() => MapHelper.SaveMap();

  public void Clear()
  {
    for (int index1 = 0; index1 < this.MaxWidth; ++index1)
    {
      for (int index2 = 0; index2 < this.MaxHeight; ++index2)
        this._tiles[index1, index2].Clear();
    }
  }

  public void ClearEdges()
  {
    for (int index1 = 0; index1 < this.MaxWidth; ++index1)
    {
      for (int index2 = 0; index2 < 40; ++index2)
        this._tiles[index1, index2].Clear();
    }
    for (int index3 = 0; index3 < this.MaxWidth; ++index3)
    {
      for (int index4 = this.MaxHeight - 40; index4 < this.MaxHeight; ++index4)
        this._tiles[index3, index4].Clear();
    }
    for (int index5 = 0; index5 < 40; ++index5)
    {
      for (int index6 = 40; index6 < this.MaxHeight - 40; ++index6)
        this._tiles[index5, index6].Clear();
    }
    for (int index7 = this.MaxWidth - 40; index7 < this.MaxWidth; ++index7)
    {
      for (int index8 = 40; index8 < this.MaxHeight - 40; ++index8)
        this._tiles[index7, index8].Clear();
    }
  }
}
