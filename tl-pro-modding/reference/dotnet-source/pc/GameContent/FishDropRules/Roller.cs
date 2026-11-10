// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.FishDropRules.Roller
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.DataStructures;

#nullable disable
namespace Terraria.GameContent.FishDropRules;

public class Roller
{
  private FishingContext _context = new FishingContext();
  private FishDropRuleList _ruleList = new FishDropRuleList();

  public void Roll(Projectile projectile, FishingAttempt fisher)
  {
    FishingContext context = this._context;
    context.Player = Main.player[projectile.owner];
    context.Fisher = fisher;
  }
}
