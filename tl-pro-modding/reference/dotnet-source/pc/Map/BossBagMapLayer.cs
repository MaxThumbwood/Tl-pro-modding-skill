// Decompiled with JetBrains decompiler
// Type: Terraria.Map.BossBagMapLayer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;
using Terraria.UI;

#nullable disable
namespace Terraria.Map;

public class BossBagMapLayer : IMapLayer
{
  public void Draw(ref MapOverlayDrawContext context, ref string text)
  {
    for (int index = 0; index < 400; ++index)
    {
      WorldItem worldItem = Main.item[index];
      if (worldItem != null && worldItem.active && ItemID.Sets.BossBag[worldItem.type])
      {
        Main.instance.LoadItem(worldItem.type);
        RenderTarget2D renderTarget;
        if (Main.ItemMapIconRenderer.RequestAndTryGet(worldItem.type, out renderTarget) && context.Draw((Texture2D) renderTarget, worldItem.Center.ToTileCoordinates().ToVector2() + new Vector2(0.5f, 0.5f), Alignment.Center).IsMouseOver)
          text = worldItem.Name;
      }
    }
  }
}
