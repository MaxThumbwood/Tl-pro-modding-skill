// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Drawing.ParticleOrchestraSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.IO;

#nullable disable
namespace Terraria.GameContent.Drawing;

public struct ParticleOrchestraSettings
{
  public Vector2 PositionInWorld;
  public Vector2 MovementVector;
  public int UniqueInfoPiece;
  public byte IndexOfPlayerWhoInvokedThis;

  public void Serialize(BinaryWriter writer)
  {
    writer.WriteVector2(this.PositionInWorld);
    writer.WriteVector2(this.MovementVector);
    writer.Write(this.UniqueInfoPiece);
    writer.Write(this.IndexOfPlayerWhoInvokedThis);
  }

  public void DeserializeFrom(BinaryReader reader)
  {
    this.PositionInWorld = reader.ReadVector2();
    this.MovementVector = reader.ReadVector2();
    this.UniqueInfoPiece = reader.ReadInt32();
    this.IndexOfPlayerWhoInvokedThis = reader.ReadByte();
  }
}
