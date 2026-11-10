// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.DontStarveDarknessDamageDealer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;

#nullable disable
namespace Terraria.GameContent;

public class DontStarveDarknessDamageDealer
{
  public const int DARKNESS_HIT_TIMER_MAX_BEFORE_HIT = 60;
  public static int darknessTimer = -1;
  public static int darknessHitTimer = 0;
  public static bool saidMessage = false;
  public static bool lastFrameWasTooBright = true;

  public static void Reset()
  {
    DontStarveDarknessDamageDealer.ResetTimer();
    DontStarveDarknessDamageDealer.saidMessage = false;
    DontStarveDarknessDamageDealer.lastFrameWasTooBright = true;
  }

  private static void ResetTimer()
  {
    DontStarveDarknessDamageDealer.darknessTimer = -1;
    DontStarveDarknessDamageDealer.darknessHitTimer = 0;
  }

  private static int GetDarknessDamagePerHit() => 250;

  private static int GetDarknessTimeBeforeStartingHits() => 120;

  private static int GetDarknessTimeForMessage() => 60;

  public static void Update(Player player)
  {
    if (player.dead || !FocusHelper.AllowDontStarveDarknessDamage || player.shimmering || Main.disableDontStarveDarknessDamage)
    {
      DontStarveDarknessDamageDealer.ResetTimer();
    }
    else
    {
      DontStarveDarknessDamageDealer.UpdateDarknessState(player);
      int beforeStartingHits = DontStarveDarknessDamageDealer.GetDarknessTimeBeforeStartingHits();
      if (DontStarveDarknessDamageDealer.darknessTimer < beforeStartingHits)
        return;
      DontStarveDarknessDamageDealer.darknessTimer = beforeStartingHits;
      ++DontStarveDarknessDamageDealer.darknessHitTimer;
      if (DontStarveDarknessDamageDealer.darknessHitTimer <= 60 || player.immune)
        return;
      int darknessDamagePerHit = DontStarveDarknessDamageDealer.GetDarknessDamagePerHit();
      SoundEngine.PlaySound(SoundID.Item1, player.Center);
      player.Hurt(PlayerDeathReason.ByOther(17), darknessDamagePerHit, 0);
      DontStarveDarknessDamageDealer.darknessHitTimer = 0;
    }
  }

  private static void UpdateDarknessState(Player player)
  {
    if (DontStarveDarknessDamageDealer.IsPlayerSafe(player))
    {
      if (DontStarveDarknessDamageDealer.saidMessage)
      {
        if (!Main.getGoodWorld)
          Main.NewText(Language.GetTextValue("Game.DarknessSafe"), (byte) 50, (byte) 200, (byte) 50);
        DontStarveDarknessDamageDealer.saidMessage = false;
      }
      DontStarveDarknessDamageDealer.ResetTimer();
    }
    else
    {
      int darknessTimeForMessage = DontStarveDarknessDamageDealer.GetDarknessTimeForMessage();
      if (DontStarveDarknessDamageDealer.darknessTimer >= darknessTimeForMessage && !DontStarveDarknessDamageDealer.saidMessage)
      {
        if (!Main.getGoodWorld)
          Main.NewText(Language.GetTextValue("Game.DarknessDanger"), (byte) 200, (byte) 50, (byte) 50);
        DontStarveDarknessDamageDealer.saidMessage = true;
      }
      ++DontStarveDarknessDamageDealer.darknessTimer;
    }
  }

  private static bool IsPlayerSafe(Player player)
  {
    return (double) Lighting.GetColor((int) player.Center.X / 16 /*0x10*/, (int) player.Center.Y / 16 /*0x10*/).ToVector3().Length() >= 0.10000000149011612;
  }
}
