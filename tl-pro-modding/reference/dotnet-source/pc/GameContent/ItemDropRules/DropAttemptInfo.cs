// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.DropAttemptInfo
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public struct DropAttemptInfo
{
  public NPC npc;
  public Player player;
  public UnifiedRandom rng;
  public bool IsInSimulation;
  public bool IsExpertMode;
  public bool IsMasterMode;
}
