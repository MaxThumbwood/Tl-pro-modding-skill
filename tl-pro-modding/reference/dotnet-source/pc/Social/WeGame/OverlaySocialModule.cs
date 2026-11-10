// Decompiled with JetBrains decompiler
// Type: Terraria.Social.WeGame.OverlaySocialModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Social.WeGame;

public class OverlaySocialModule : Terraria.Social.Base.OverlaySocialModule
{
  private bool _gamepadTextInputActive;

  public override void Initialize()
  {
  }

  public override void Shutdown()
  {
  }

  public override bool IsGamepadTextInputActive() => this._gamepadTextInputActive;

  public override bool ShowGamepadTextInput(
    string description,
    uint maxLength,
    bool multiLine = false,
    string existingText = "",
    bool password = false)
  {
    return false;
  }

  public override string GetGamepadText() => "";
}
