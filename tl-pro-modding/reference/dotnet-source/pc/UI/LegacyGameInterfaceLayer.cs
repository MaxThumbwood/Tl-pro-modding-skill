// Decompiled with JetBrains decompiler
// Type: Terraria.UI.LegacyGameInterfaceLayer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.UI;

public class LegacyGameInterfaceLayer : GameInterfaceLayer
{
  private GameInterfaceDrawMethod _drawMethod;

  public LegacyGameInterfaceLayer(
    string name,
    GameInterfaceDrawMethod drawMethod,
    InterfaceScaleType scaleType = InterfaceScaleType.Game)
    : base(name, scaleType)
  {
    this._drawMethod = drawMethod;
  }

  protected override bool DrawSelf() => this._drawMethod();
}
