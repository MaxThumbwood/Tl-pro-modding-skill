// Decompiled with JetBrains decompiler
// Type: Terraria.Social.Base.OverlaySocialModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Social.Base;

public abstract class OverlaySocialModule : ISocialModule
{
  public abstract void Initialize();

  public abstract void Shutdown();

  public abstract bool IsGamepadTextInputActive();

  public abstract bool ShowGamepadTextInput(
    string description,
    uint maxLength,
    bool multiLine = false,
    string existingText = "",
    bool password = false);

  public abstract string GetGamepadText();
}
