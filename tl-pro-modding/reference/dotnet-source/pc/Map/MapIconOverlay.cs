// Decompiled with JetBrains decompiler
// Type: Terraria.Map.MapIconOverlay
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;

#nullable disable
namespace Terraria.Map;

public class MapIconOverlay
{
  private readonly List<IMapLayer> _layers = new List<IMapLayer>();

  public MapIconOverlay AddLayer(IMapLayer layer)
  {
    this._layers.Add(layer);
    return this;
  }

  public void Draw(
    Vector2 mapPosition,
    Vector2 mapOffset,
    Rectangle? clippingRect,
    float mapScale,
    float drawScale,
    int alpha,
    ref string text)
  {
    MapOverlayDrawContext context = new MapOverlayDrawContext(mapPosition, mapOffset, clippingRect, mapScale, drawScale, (float) alpha / (float) byte.MaxValue);
    foreach (IMapLayer layer in this._layers)
      layer.Draw(ref context, ref text);
  }
}
