// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ObjectInteractions.PotionOfReturnGateInteractionChecker
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent.ObjectInteractions;

public class PotionOfReturnGateInteractionChecker : AHoverInteractionChecker
{
  internal override bool? AttemptOverridingHoverStatus(Player player, Rectangle rectangle)
  {
    return Main.SmartInteractPotionOfReturn ? new bool?(true) : new bool?();
  }

  internal override void DoHoverEffect(Player player, Rectangle hitbox)
  {
    player.noThrow = 2;
    player.cursorItemIconEnabled = true;
    player.cursorItemIconID = 4870;
  }

  internal override bool ShouldBlockInteraction(Player player, Rectangle hitbox)
  {
    return Player.BlockInteractionWithProjectiles != 0;
  }

  internal override void PerformInteraction(Player player, Rectangle hitbox)
  {
    player.DoPotionOfReturnReturnToOriginalUsePosition();
  }
}
