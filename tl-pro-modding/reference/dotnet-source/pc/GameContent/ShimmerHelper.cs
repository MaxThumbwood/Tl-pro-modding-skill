// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ShimmerHelper
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent;

public class ShimmerHelper
{
  public static Vector2? FindSpotWithoutShimmer(
    Entity entity,
    int startX,
    int startY,
    int expand,
    bool allowSolidTop)
  {
    Vector2 vector2 = new Vector2((float) (-entity.width / 2), (float) -entity.height);
    for (int index = 0; index < expand; ++index)
    {
      int num1 = startX - index;
      int num2 = startY - expand;
      Vector2 landingPosition1 = new Vector2((float) (num1 * 16 /*0x10*/), (float) (num2 * 16 /*0x10*/)) + vector2;
      if (ShimmerHelper.IsSpotShimmerFree(entity, landingPosition1, allowSolidTop))
        return new Vector2?(landingPosition1);
      Vector2 landingPosition2 = new Vector2((float) ((startX + index) * 16 /*0x10*/), (float) (num2 * 16 /*0x10*/)) + vector2;
      if (ShimmerHelper.IsSpotShimmerFree(entity, landingPosition2, allowSolidTop))
        return new Vector2?(landingPosition2);
      int num3 = startX - index;
      int num4 = startY + expand;
      Vector2 landingPosition3 = new Vector2((float) (num3 * 16 /*0x10*/), (float) (num4 * 16 /*0x10*/)) + vector2;
      if (ShimmerHelper.IsSpotShimmerFree(entity, landingPosition3, allowSolidTop))
        return new Vector2?(landingPosition3);
      Vector2 landingPosition4 = new Vector2((float) ((startX + index) * 16 /*0x10*/), (float) (num4 * 16 /*0x10*/)) + vector2;
      if (ShimmerHelper.IsSpotShimmerFree(entity, landingPosition4, allowSolidTop))
        return new Vector2?(landingPosition4);
    }
    for (int index = 0; index < expand; ++index)
    {
      int num5 = startX - expand;
      int num6 = startY - index;
      Vector2 landingPosition5 = new Vector2((float) (num5 * 16 /*0x10*/), (float) (num6 * 16 /*0x10*/)) + vector2;
      if (ShimmerHelper.IsSpotShimmerFree(entity, landingPosition5, allowSolidTop))
        return new Vector2?(landingPosition5);
      Vector2 landingPosition6 = new Vector2((float) ((startX + expand) * 16 /*0x10*/), (float) (num6 * 16 /*0x10*/)) + vector2;
      if (ShimmerHelper.IsSpotShimmerFree(entity, landingPosition6, allowSolidTop))
        return new Vector2?(landingPosition6);
      int num7 = startX - expand;
      int num8 = startY + index;
      Vector2 landingPosition7 = new Vector2((float) (num7 * 16 /*0x10*/), (float) (num8 * 16 /*0x10*/)) + vector2;
      if (ShimmerHelper.IsSpotShimmerFree(entity, landingPosition7, allowSolidTop))
        return new Vector2?(landingPosition7);
      Vector2 landingPosition8 = new Vector2((float) ((startX + expand) * 16 /*0x10*/), (float) (num8 * 16 /*0x10*/)) + vector2;
      if (ShimmerHelper.IsSpotShimmerFree(entity, landingPosition8, allowSolidTop))
        return new Vector2?(landingPosition8);
    }
    return new Vector2?();
  }

  private static bool IsSpotShimmerFree(Entity entity, Vector2 landingPosition, bool allowSolidTop)
  {
    return !Collision.SolidCollision(landingPosition, entity.width, entity.height) && Collision.SolidCollision(landingPosition + new Vector2(0.0f, (float) entity.height), entity.width, 100, allowSolidTop) && (!Collision.WetCollision(landingPosition, entity.width, entity.height + 100) || !Collision.shimmer);
  }
}
