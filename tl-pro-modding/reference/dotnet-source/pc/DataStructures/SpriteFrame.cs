// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.SpriteFrame
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.DataStructures;

public struct SpriteFrame
{
  public int PaddingX;
  public int PaddingY;
  private byte _currentColumn;
  private byte _currentRow;
  public readonly byte ColumnCount;
  public readonly byte RowCount;

  public byte CurrentColumn
  {
    get => this._currentColumn;
    set => this._currentColumn = value;
  }

  public byte CurrentRow
  {
    get => this._currentRow;
    set => this._currentRow = value;
  }

  public SpriteFrame(byte columns, byte rows)
  {
    this.PaddingX = 2;
    this.PaddingY = 2;
    this._currentColumn = (byte) 0;
    this._currentRow = (byte) 0;
    this.ColumnCount = columns;
    this.RowCount = rows;
  }

  public SpriteFrame(byte columns, byte rows, byte currentColumn, byte currentRow)
  {
    this.PaddingX = 2;
    this.PaddingY = 2;
    this._currentColumn = currentColumn;
    this._currentRow = currentRow;
    this.ColumnCount = columns;
    this.RowCount = rows;
  }

  public SpriteFrame With(byte columnToUse, byte rowToUse)
  {
    return this with
    {
      CurrentColumn = columnToUse,
      CurrentRow = rowToUse
    };
  }

  public Rectangle GetSourceRectangle(Texture2D texture)
  {
    int num1 = texture.Width / (int) this.ColumnCount;
    int num2 = texture.Height / (int) this.RowCount;
    return new Rectangle((int) this.CurrentColumn * num1, (int) this.CurrentRow * num2, num1 - (this.ColumnCount == (byte) 1 ? 0 : this.PaddingX), num2 - (this.RowCount == (byte) 1 ? 0 : this.PaddingY));
  }
}
