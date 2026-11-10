// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.FishDropRules.FishingContext
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.DataStructures;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.FishDropRules;

public class FishingContext
{
  public UnifiedRandom Random = new UnifiedRandom();
  public FishingAttempt Fisher;
  public Player Player;
  public bool RolledCorruption;
  public bool RolledCrimson;
  public bool RolledJungle;
  public bool RolledSnow;
  public bool RolledDesert;
  public bool RolledInfectedDesert;
  public bool RolledRemixOcean;
}
