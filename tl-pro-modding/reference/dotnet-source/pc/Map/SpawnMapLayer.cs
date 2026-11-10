// Decompiled with JetBrains decompiler
// Type: Terraria.Map.SpawnMapLayer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.GameContent;
using Terraria.Localization;
using Terraria.UI;

#nullable disable
namespace Terraria.Map;

public class SpawnMapLayer : IMapLayer
{
  public void Draw(ref MapOverlayDrawContext context, ref string text)
  {
    Player localPlayer = Main.LocalPlayer;
    Vector2 position1 = new Vector2((float) localPlayer.SpawnX + 0.5f, (float) localPlayer.SpawnY);
    Vector2 position2 = new Vector2((float) Main.spawnTileX + 0.5f, (float) Main.spawnTileY);
    if (!Main.teamBasedSpawnsSeed && context.Draw(TextureAssets.SpawnPoint.Value, position2, Alignment.Bottom).IsMouseOver)
      text = Language.GetTextValue("UI.SpawnPoint");
    if (localPlayer.SpawnX == -1 || !context.Draw(TextureAssets.SpawnBed.Value, position1, Alignment.Bottom).IsMouseOver)
      return;
    text = Language.GetTextValue("UI.SpawnBed");
  }
}
