// Decompiled with JetBrains decompiler
// Type: Terraria.FocusHelper
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.OS;
using System.Windows.Forms;

#nullable disable
namespace Terraria;

public static class FocusHelper
{
  public static bool IsSelectedApplication;

  public static bool GameplayActive => FocusHelper.IsSelectedApplication && !Main.gamePaused;

  public static bool AllowAudioUnfocused => Main.SettingPlayWhenUnfocused;

  public static bool AllowSkyMovement => FocusHelper.GameplayActive;

  public static bool AllowTileDrawingToEmitEffects => FocusHelper.GameplayActive;

  public static bool AllowPlayerToEmitEffects => FocusHelper.GameplayActive;

  public static bool AllowWorldItemsToEmitEffects => FocusHelper.GameplayActive;

  public static bool PauseSkies => !FocusHelper.GameplayActive;

  public static bool UpdateVisualEffects => FocusHelper.GameplayActive;

  public static bool PauseLiquidRenderer => !FocusHelper.GameplayActive;

  public static bool AllowMiscDustEffects => FocusHelper.GameplayActive;

  public static bool PausePlayerBalloonAnimations
  {
    get
    {
      if (!FocusHelper.IsSelectedApplication)
        return true;
      return Main.ingameOptionsWindow && Main.autoPause;
    }
  }

  public static bool AllowRain => FocusHelper.GameplayActive;

  public static bool AllowCountingPlayerTime
  {
    get
    {
      bool flag = Main.gamePaused && !FocusHelper.IsSelectedApplication;
      bool countingPlayerTime = Main.instance.IsActive && !flag;
      if (Main.gameMenu)
        countingPlayerTime = false;
      return countingPlayerTime;
    }
  }

  public static bool UpdateBackgroundThunder
  {
    get => FocusHelper.IsSelectedApplication || Main.SettingPlayWhenUnfocused;
  }

  public static bool AllowMusic
  {
    get => FocusHelper.IsSelectedApplication || FocusHelper.AllowAudioUnfocused;
  }

  public static bool PauseSounds => !FocusHelper.GameplayActive && Main.netMode == 0;

  public static bool QuietAmbientSounds => !FocusHelper.IsSelectedApplication;

  public static bool AllowInputProcessing => FocusHelper.IsSelectedApplication;

  public static bool AllowInputProcessingForGamepad
  {
    get => FocusHelper.IsSelectedApplication || Main.AllowUnfocusedInputOnGamepad;
  }

  public static bool AllowUIInputs => FocusHelper.IsSelectedApplication;

  public static bool AllowGameplayInputs => FocusHelper.IsSelectedApplication;

  public static bool LetStarsFallInMenu => FocusHelper.IsSelectedApplication;

  public static bool AllowDontStarveDarknessDamage => FocusHelper.IsSelectedApplication;

  public static bool AllowChroma => FocusHelper.IsSelectedApplication;

  public static bool AllowTaskbarFlash => !FocusHelper.IsSelectedApplication;

  public static void UpdateFocus(out bool wantsToPause)
  {
    wantsToPause = false;
    bool flag1 = !Main.SettingPlayWhenUnfocused;
    FocusHelper.IsSelectedApplication = Main.instance.IsActive;
    if (Platform.IsWindows)
    {
      Form form = Control.FromHandle(Main.instance.Window.Handle) as Form;
      int num = form.WindowState == FormWindowState.Minimized ? 1 : 0;
      bool flag2 = Form.ActiveForm == form;
      FocusHelper.IsSelectedApplication |= flag2;
      if (num != 0)
        FocusHelper.IsSelectedApplication = false;
    }
    if (((FocusHelper.IsSelectedApplication ? 0 : (Main.netMode == 0 ? 1 : 0)) & (flag1 ? 1 : 0)) != 0)
    {
      if (!Platform.IsOSX)
        Main.instance.IsMouseVisible = true;
      wantsToPause = true;
    }
    else
    {
      if (!Platform.IsOSX)
        Main.instance.IsMouseVisible = false;
      if (!Platform.IsWindows || !Main.instance.ReHideCursor)
        return;
      Main.instance.IsMouseVisible = false;
      Main.instance.ReHideCursor = false;
      Platform.Get<IMouseNotifier>()?.ForceCursorHidden();
    }
  }
}
