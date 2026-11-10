// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ObjectInteractions.PotionOfReturnHelper
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent.ObjectInteractions;

public class PotionOfReturnHelper
{
  public static bool TryGetGateHitbox(Player player, out Rectangle homeHitbox)
  {
    homeHitbox = Rectangle.Empty;
    if (!player.PotionOfReturnHomePosition.HasValue)
      return false;
    Vector2 vector2 = new Vector2(0.0f, -21f);
    Vector2 center = player.PotionOfReturnHomePosition.Value + vector2;
    homeHitbox = Utils.CenteredRectangle(center, new Vector2(24f, 40f));
    return true;
  }
}
