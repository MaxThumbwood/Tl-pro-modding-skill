// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.NPCKillAttempt
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public struct NPCKillAttempt
{
  public readonly NPC npc;
  public readonly int netId;
  public readonly bool active;

  public NPCKillAttempt(NPC target)
  {
    this.npc = target;
    this.netId = target.netID;
    this.active = target.active;
  }

  public bool DidNPCDie() => !this.npc.active;

  public bool DidNPCDieOrTransform() => this.DidNPCDie() || this.npc.netID != this.netId;
}
