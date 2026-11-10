// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.NPCDebuffImmunityData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.ID;

#nullable disable
namespace Terraria.DataStructures;

public class NPCDebuffImmunityData
{
  public bool ImmuneToWhips;
  public bool ImmuneToAllBuffsThatAreNotWhips;
  public int[] SpecificallyImmuneTo;

  public void ApplyToNPC(NPC npc)
  {
    if (this.ImmuneToWhips || this.ImmuneToAllBuffsThatAreNotWhips)
    {
      for (int index = 1; index < BuffID.Count; ++index)
      {
        bool flag1 = BuffID.Sets.IsAnNPCWhipDebuff[index];
        bool flag2 = ((((false ? 1 : 0) | (!flag1 ? 0 : (this.ImmuneToWhips ? 1 : 0))) != 0 ? 1 : 0) | (flag1 ? 0 : (this.ImmuneToAllBuffsThatAreNotWhips ? 1 : 0))) != 0;
        npc.buffImmune[index] = flag2;
      }
    }
    if (this.SpecificallyImmuneTo == null)
      return;
    for (int index1 = 0; index1 < this.SpecificallyImmuneTo.Length; ++index1)
    {
      int index2 = this.SpecificallyImmuneTo[index1];
      npc.buffImmune[index2] = true;
    }
  }
}
