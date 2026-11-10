// Decompiled with JetBrains decompiler
// Type: Terraria.Social.Steam.PlatformSocialModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Steamworks;
using Terraria.GameInput;
using Terraria.UI.Gamepad;

#nullable disable
namespace Terraria.Social.Steam;

public class PlatformSocialModule : Terraria.Social.Base.PlatformSocialModule
{
  public override void Initialize()
  {
    if (Main.dedServ)
      return;
    int num;
    PlayerInput.UseSteamDeckIfPossible = (num = SteamUtils.IsSteamRunningOnSteamDeck() ? 1 : 0) != 0;
    if (num != 0)
    {
      PlayerInput.SettingsForUI.SetCursorMode(CursorMode.Gamepad);
      PlayerInput.CurrentInputMode = InputMode.XBoxGamepadUI;
      GamepadMainMenuHandler.MoveCursorOnNextRun = true;
      PlayerInput.PreventFirstMousePositionGrab = true;
    }
    if (num == 0)
      return;
    Main.graphics.PreferredBackBufferWidth = Main.screenWidth = 1280 /*0x0500*/;
    Main.graphics.PreferredBackBufferHeight = Main.screenHeight = 800;
    Main.startFullscreen = true;
    Main.toggleFullscreen = true;
    Main.screenBorderless = false;
    Main.screenMaximized = false;
    Main.InitialMapScale = Main.MapScale = 0.73f;
    Main.UIScale = 1.07f;
  }

  public override void Shutdown()
  {
  }
}
