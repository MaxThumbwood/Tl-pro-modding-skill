// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.NormalButterflyLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.IO;

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class NormalButterflyLeashedCritter : FlyLeashedCritter
{
  public static NormalButterflyLeashedCritter Prototype = new NormalButterflyLeashedCritter();
  protected byte variant;

  protected override void SetDefaults(Item sample)
  {
    base.SetDefaults(sample);
    this.variant = (byte) sample.placeStyle;
  }

  protected override void CopyToDummy()
  {
    base.CopyToDummy();
    LeashedCritter._dummy.ai[2] = (float) this.variant;
  }

  public override void NetSend(BinaryWriter writer, bool full)
  {
    base.NetSend(writer, full);
    if (!full)
      return;
    writer.Write(this.variant);
  }

  public override void NetReceive(BinaryReader reader, bool full)
  {
    base.NetReceive(reader, full);
    if (!full)
      return;
    this.variant = reader.ReadByte();
  }
}
