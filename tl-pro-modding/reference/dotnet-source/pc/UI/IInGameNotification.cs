// Decompiled with JetBrains decompiler
// Type: Terraria.UI.IInGameNotification
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.UI;

public interface IInGameNotification
{
  object CreationObject { get; }

  bool ShouldBeRemoved { get; }

  void Update();

  void DrawInGame(SpriteBatch spriteBatch, Vector2 bottomAnchorPosition);

  void PushAnchor(ref Vector2 positionAnchorBottom);

  void DrawInNotificationsArea(
    SpriteBatch spriteBatch,
    Rectangle area,
    ref int gamepadPointLocalIndexTouse);
}
