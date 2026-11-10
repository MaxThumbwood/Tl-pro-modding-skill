// Decompiled with JetBrains decompiler
// Type: Terraria.Social.Base.RichPresenceState
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using Terraria.GameContent.UI.States;

#nullable disable
namespace Terraria.Social.Base;

public class RichPresenceState : IEquatable<RichPresenceState>
{
  public RichPresenceState.GameModeState GameMode;

  public bool Equals(RichPresenceState other) => this.GameMode == other.GameMode;

  public static RichPresenceState GetCurrentState()
  {
    RichPresenceState currentState = new RichPresenceState();
    if (Main.gameMenu)
    {
      int num = Main.MenuUI.CurrentState is UICharacterCreation ? 1 : 0;
      bool flag = Main.MenuUI.CurrentState is UIWorldCreation;
      currentState.GameMode = num == 0 ? (!flag ? RichPresenceState.GameModeState.InMainMenu : RichPresenceState.GameModeState.CreatingWorld) : RichPresenceState.GameModeState.CreatingPlayer;
    }
    else
      currentState.GameMode = Main.netMode != 0 ? RichPresenceState.GameModeState.PlayingMulti : RichPresenceState.GameModeState.PlayingSingle;
    return currentState;
  }

  public enum GameModeState
  {
    InMainMenu,
    CreatingPlayer,
    CreatingWorld,
    PlayingSingle,
    PlayingMulti,
  }
}
