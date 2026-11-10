// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.TileEntityType`1
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public abstract class TileEntityType<T> : TileEntity where T : TileEntity, new()
{
  protected static byte EntityTypeID;

  public override void RegisterTileEntityID(int assignedID)
  {
    TileEntityType<T>.EntityTypeID = (byte) assignedID;
  }

  public override TileEntity GenerateInstance() => (TileEntity) new T();

  public override void NetPlaceEntityAttempt(int x, int y)
  {
    NetMessage.SendData(86, number: TileEntityType<T>.Place(x, y), number2: (float) x, number3: (float) y);
  }

  public static int Place(int x, int y)
  {
    return TileEntity.Place(x, y, (int) TileEntityType<T>.EntityTypeID);
  }

  public static void Kill(int x, int y)
  {
    TileEntity.Kill(x, y, (int) TileEntityType<T>.EntityTypeID);
  }

  public static int Find(int x, int y)
  {
    T result;
    return !TileEntity.TryGetAt<T>(x, y, out result) ? -1 : result.ID;
  }
}
