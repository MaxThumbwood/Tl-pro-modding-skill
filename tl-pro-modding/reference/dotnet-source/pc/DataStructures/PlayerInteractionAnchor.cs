// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.PlayerInteractionAnchor
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public struct PlayerInteractionAnchor(int entityID, int x = -1, int y = -1)
{
  public int interactEntityID = entityID;
  public int X = x;
  public int Y = y;

  public bool InUse => this.interactEntityID != -1;

  public void Clear()
  {
    this.interactEntityID = -1;
    this.X = -1;
    this.Y = -1;
  }

  public void Set(int entityID, int x, int y)
  {
    this.interactEntityID = entityID;
    this.X = x;
    this.Y = y;
  }

  public bool IsInValidUseTileEntity() => this.GetTileEntity() != null;

  public TileEntity GetTileEntity()
  {
    TileEntity result = (TileEntity) null;
    if (this.InUse)
      TileEntity.TryGet<TileEntity>(this.interactEntityID, out result);
    return result;
  }
}
