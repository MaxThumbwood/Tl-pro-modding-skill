// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ObjectInteractions.AHoverInteractionChecker
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameInput;

#nullable disable
namespace Terraria.GameContent.ObjectInteractions;

public abstract class AHoverInteractionChecker
{
  internal AHoverInteractionChecker.HoverStatus AttemptInteraction(Player player, Rectangle Hitbox)
  {
    Point tileCoordinates = Hitbox.ClosestPointInRect(player.Center).ToTileCoordinates();
    if (!player.IsInTileInteractionRange(tileCoordinates.X, tileCoordinates.Y, TileReachCheckSettings.Simple))
      return AHoverInteractionChecker.HoverStatus.NotSelectable;
    Vector2 v = Main.ReverseGravitySupport(Main.MouseScreen) + Main.screenPosition;
    bool flag1 = Hitbox.Contains(v.ToPoint());
    bool flag2 = flag1;
    bool? nullable = this.AttemptOverridingHoverStatus(player, Hitbox);
    if (nullable.HasValue)
      flag2 = nullable.Value;
    bool flag3 = flag2 & !player.lastMouseInterface;
    bool flag4 = !Main.SmartCursorIsUsed && !PlayerInput.UsingGamepad;
    if (!flag3)
      return !flag4 ? AHoverInteractionChecker.HoverStatus.SelectableButNotSelected : AHoverInteractionChecker.HoverStatus.NotSelectable;
    Main.HasInteractableObjectThatIsNotATile = true;
    if (flag1)
      this.DoHoverEffect(player, Hitbox);
    if (PlayerInput.UsingGamepad)
      player.GamepadEnableGrappleCooldown();
    bool flag5 = this.ShouldBlockInteraction(player, Hitbox);
    if (Main.mouseRight && Main.mouseRightRelease && !flag5)
    {
      Main.mouseRightRelease = false;
      player.tileInteractAttempted = true;
      player.tileInteractionHappened = true;
      player.releaseUseTile = false;
      this.PerformInteraction(player, Hitbox);
    }
    return !Main.SmartCursorIsUsed && !PlayerInput.UsingGamepad || flag4 ? AHoverInteractionChecker.HoverStatus.NotSelectable : AHoverInteractionChecker.HoverStatus.Selected;
  }

  internal abstract bool? AttemptOverridingHoverStatus(Player player, Rectangle rectangle);

  internal abstract void DoHoverEffect(Player player, Rectangle hitbox);

  internal abstract bool ShouldBlockInteraction(Player player, Rectangle hitbox);

  internal abstract void PerformInteraction(Player player, Rectangle hitbox);

  internal enum HoverStatus
  {
    NotSelectable,
    SelectableButNotSelected,
    Selected,
  }
}
