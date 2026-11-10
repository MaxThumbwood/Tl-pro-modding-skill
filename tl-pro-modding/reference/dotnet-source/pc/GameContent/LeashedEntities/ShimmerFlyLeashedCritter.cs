// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.ShimmerFlyLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.IO;

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class ShimmerFlyLeashedCritter : FlyLeashedCritter
{
  public static ShimmerFlyLeashedCritter Prototype = new ShimmerFlyLeashedCritter();
  private byte oldPositionsLength;
  private Vector2[] oldPositions;

  protected override void SetDefaults(Item sample)
  {
    base.SetDefaults(sample);
    if (Main.netMode == 0)
      this.oldPositions = LeashedCritter._dummy.oldPos;
    this.oldPositionsLength = (byte) LeashedCritter._dummy.oldPos.Length;
  }

  public override void NetSend(BinaryWriter writer, bool full)
  {
    base.NetSend(writer, full);
    if (!full)
      return;
    writer.Write(this.oldPositionsLength);
  }

  public override void NetReceive(BinaryReader reader, bool full)
  {
    base.NetReceive(reader, full);
    if (!full)
      return;
    this.oldPositionsLength = reader.ReadByte();
    this.oldPositions = new Vector2[(int) this.oldPositionsLength];
  }

  protected override void VisualEffects()
  {
    base.VisualEffects();
    if (this.oldPositions == null)
      return;
    for (int index = this.oldPositions.Length - 1; index > 0; --index)
      this.oldPositions[index] = this.oldPositions[index - 1];
    this.oldPositions[0] = this.position + this.netOffset;
  }

  public override void Draw()
  {
    Vector2[] oldPos = LeashedCritter._dummy.oldPos;
    LeashedCritter._dummy.oldPos = this.oldPositions;
    base.Draw();
    LeashedCritter._dummy.oldPos = oldPos;
  }
}
