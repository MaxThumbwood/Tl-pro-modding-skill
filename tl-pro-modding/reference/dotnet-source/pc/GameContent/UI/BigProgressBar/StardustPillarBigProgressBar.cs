// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.BigProgressBar.StardustPillarBigProgressBar
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.UI.BigProgressBar;

public class StardustPillarBigProgressBar : LunarPillarBigProgessBar
{
  internal override float GetCurrentShieldValue() => (float) NPC.ShieldStrengthTowerStardust;

  internal override float GetMaxShieldValue() => (float) NPC.ShieldStrengthTowerMax;

  internal override bool IsPlayerInCombatArea() => Main.LocalPlayer.ZoneTowerStardust;
}
