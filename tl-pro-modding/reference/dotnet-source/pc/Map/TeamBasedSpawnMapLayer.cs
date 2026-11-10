// Decompiled with JetBrains decompiler
// Type: Terraria.Map.TeamBasedSpawnMapLayer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.Localization;
using Terraria.UI;

#nullable disable
namespace Terraria.Map;

public class TeamBasedSpawnMapLayer : IMapLayer
{
  public void Draw(ref MapOverlayDrawContext context, ref string text)
  {
    if (!Main.teamBasedSpawnsSeed)
      return;
    int team = Main.LocalPlayer.team;
    Point spawnPoint = Point.Zero;
    if (!ExtraSpawnPointManager.TryGetExtraSpawnPointForTeam(team, out spawnPoint) || !context.Draw(TextureAssets.Extra[282].Value, spawnPoint.ToVector2(), new SpriteFrame((byte) 6, (byte) 1, (byte) team, (byte) 0), Alignment.Bottom).IsMouseOver)
      return;
    text = Language.GetTextValue("UI.TeamSpawnPoint");
  }
}
