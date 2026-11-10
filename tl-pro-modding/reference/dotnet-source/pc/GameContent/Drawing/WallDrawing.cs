// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Drawing.WallDrawing
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Liquid;
using Terraria.Graphics;
using Terraria.ID;
using Terraria.Testing;

#nullable disable
namespace Terraria.GameContent.Drawing;

public class WallDrawing : TileDrawingBase
{
  public static bool QuickPaintLookup = true;
  private static VertexColors _glowPaintColors = new VertexColors(Color.White);
  private Tile[,] _tileArray;
  private TilePaintSystemV2 _paintSystem;
  private bool _shouldShowInvisibleWalls;
  private TilePaintSystemV2.WallVariationKey _lastPaintLookupKey;
  private Texture2D _lastPaintLookupTexture;

  public void LerpVertexColorsWithColor(ref VertexColors colors, Color lerpColor, float percent)
  {
    colors.TopLeftColor = Color.Lerp(colors.TopLeftColor, lerpColor, percent);
    colors.TopRightColor = Color.Lerp(colors.TopRightColor, lerpColor, percent);
    colors.BottomLeftColor = Color.Lerp(colors.BottomLeftColor, lerpColor, percent);
    colors.BottomRightColor = Color.Lerp(colors.BottomRightColor, lerpColor, percent);
  }

  public WallDrawing(TilePaintSystemV2 paintSystem) => this._paintSystem = paintSystem;

  public void Update()
  {
    if (Main.dedServ)
      return;
    this._shouldShowInvisibleWalls = Main.ShouldShowInvisibleBlocksAndWalls();
  }

  public static void DrawOutline(
    Texture2D texture,
    Vector2 position,
    Rectangle sourceRectangle,
    Color color)
  {
    Main.spriteBatch.Draw(texture, position, new Rectangle?(sourceRectangle), color, 0.0f, Vector2.Zero, 1f, SpriteEffects.None, 0.0f);
  }

  public void DrawWalls()
  {
    this.FlushLogData = TimeLogger.FlushWallTiles;
    this.DrawCallLogData = TimeLogger.WallDrawCalls;
    if (DebugOptions.hideWalls)
      return;
    float gfxQuality = Main.gfxQuality;
    Vector2 screenPosition = Main.screenPosition;
    int[] wallBlend = Main.wallBlend;
    this._tileArray = Main.tile;
    int num1 = (int) (120.0 * (1.0 - (double) gfxQuality) + 40.0 * (double) gfxQuality);
    if (DebugOptions.devLightTilesCheat)
      num1 = 1000;
    int num2 = (int) ((double) num1 * 0.40000000596046448);
    int num3 = (int) ((double) num1 * 0.34999999403953552);
    int num4 = (int) ((double) num1 * 0.30000001192092896);
    Vector2 drawOffSet;
    int firstTileX;
    int lastTileX;
    int firstTileY;
    int lastTileY;
    TileDrawing.GetScreenDrawArea(!Main.drawToScreen, out drawOffSet, out firstTileX, out lastTileX, out firstTileY, out lastTileY);
    VertexColors vertices = new VertexColors();
    Rectangle rectangle = new Rectangle(0, 0, 32 /*0x20*/, 32 /*0x20*/);
    int underworldLayer = Main.UnderworldLayer;
    this._lastPaintLookupKey = new TilePaintSystemV2.WallVariationKey();
    for (int index1 = firstTileY; index1 < lastTileY; ++index1)
    {
      for (int index2 = firstTileX; index2 < lastTileX; ++index2)
      {
        Tile tile = this._tileArray[index2, index1];
        if (tile == null)
        {
          tile = new Tile();
          this._tileArray[index2, index1] = tile;
        }
        ushort wall = tile.wall;
        if (wall > (ushort) 0 && !this.FullTile(index2, index1) && (wall != (ushort) 318 || this._shouldShowInvisibleWalls) && (!tile.invisibleWall() || this._shouldShowInvisibleWalls))
        {
          Color color1 = Lighting.GetColor(index2, index1);
          if (tile.fullbrightWall())
            color1 = Color.White;
          if (wall == (ushort) 318)
            color1 = Color.White;
          if (color1.R != (byte) 0 || color1.G != (byte) 0 || color1.B != (byte) 0 || index1 >= underworldLayer)
          {
            Main.instance.LoadWall((int) wall);
            Texture2D wallDrawTexture = this.GetWallDrawTexture(tile);
            Main.tileBatch.SetLayer((uint) wall | (uint) tile.wallColor() << 11);
            rectangle.X = tile.wallFrameX();
            rectangle.Y = tile.wallFrameY() + (int) Main.wallFrame[(int) wall] * 180;
            switch (tile.wall)
            {
              case 242:
              case 243:
                int num5 = 20;
                int num6 = ((int) Main.wallFrameCounter[(int) wall] + index2 * 11 + index1 * 27) % (num5 * 8);
                rectangle.Y = tile.wallFrameY() + 180 * (num6 / num5);
                break;
            }
            if (Lighting.NotRetro && !Main.wallLight[(int) wall] && tile.wall != (ushort) 241 && (tile.wall < (ushort) 88 || tile.wall > (ushort) 93) && !WorldGen.SolidTile(tile))
            {
              if (tile.wall == (ushort) 346)
              {
                Color color2 = new Color((int) (byte) Main.DiscoR, (int) (byte) Main.DiscoG, (int) (byte) Main.DiscoB);
                vertices.BottomLeftColor = color2;
                vertices.BottomRightColor = color2;
                vertices.TopLeftColor = color2;
                vertices.TopRightColor = color2;
              }
              else if (tile.wall == (ushort) 44)
              {
                Color color3 = new Color((int) (byte) Main.DiscoR, (int) (byte) Main.DiscoG, (int) (byte) Main.DiscoB);
                vertices.BottomLeftColor = color3;
                vertices.BottomRightColor = color3;
                vertices.TopLeftColor = color3;
                vertices.TopRightColor = color3;
              }
              else
              {
                Lighting.GetCornerColors(index2, index1, out vertices);
                switch (tile.wall)
                {
                  case 341:
                  case 342:
                  case 343:
                  case 344:
                  case 345:
                    this.LerpVertexColorsWithColor(ref vertices, Color.White, 0.5f);
                    break;
                }
                if (tile.fullbrightWall())
                  vertices = WallDrawing._glowPaintColors;
              }
              Main.tileBatch.Draw(wallDrawTexture, new Vector2((float) (index2 * 16 /*0x10*/ - (int) screenPosition.X - 8), (float) (index1 * 16 /*0x10*/ - (int) screenPosition.Y - 8)) + drawOffSet, new Rectangle?(rectangle), vertices, Vector2.Zero, 1f, SpriteEffects.None);
              if (tile.wall == (ushort) 347)
              {
                Texture2D texture = TextureAssets.GlowMask[361].Value;
                LiquidRenderer.SetShimmerVertexColors_Sparkle(ref vertices, 0.7f, index2, index1, true);
                Main.tileBatch.Draw(texture, new Vector2((float) (index2 * 16 /*0x10*/ - (int) screenPosition.X - 8), (float) (index1 * 16 /*0x10*/ - (int) screenPosition.Y - 8)) + drawOffSet, new Rectangle?(rectangle), vertices, Vector2.Zero, 1f, SpriteEffects.None);
              }
            }
            else
            {
              Color colors1 = color1;
              if (wall == (ushort) 44 || wall == (ushort) 346)
                colors1 = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB);
              switch (wall)
              {
                case 341:
                case 342:
                case 343:
                case 344:
                case 345:
                  colors1 = Color.Lerp(colors1, Color.White, 0.5f);
                  break;
              }
              Main.tileBatch.Draw(wallDrawTexture, new Vector2((float) (index2 * 16 /*0x10*/ - (int) screenPosition.X - 8), (float) (index1 * 16 /*0x10*/ - (int) screenPosition.Y - 8)) + drawOffSet, new Rectangle?(rectangle), (VertexColors) colors1, Vector2.Zero, 1f, SpriteEffects.None);
              if (tile.wall == (ushort) 347)
              {
                Texture2D texture = TextureAssets.GlowMask[361].Value;
                Color colors2 = LiquidRenderer.GetShimmerGlitterColor(true, (float) index2, (float) index1) * 0.7f;
                Main.tileBatch.Draw(texture, new Vector2((float) (index2 * 16 /*0x10*/ - (int) screenPosition.X - 8), (float) (index1 * 16 /*0x10*/ - (int) screenPosition.Y - 8)) + drawOffSet, new Rectangle?(rectangle), (VertexColors) colors2, Vector2.Zero, 1f, SpriteEffects.None);
              }
            }
            if ((int) color1.R > num2 || (int) color1.G > num3 || (int) color1.B > num4)
            {
              int num7 = this._tileArray[index2 - 1, index1].wall <= (ushort) 0 ? 0 : (wallBlend[(int) this._tileArray[index2 - 1, index1].wall] != wallBlend[(int) tile.wall] ? 1 : 0);
              bool flag1 = this._tileArray[index2 + 1, index1].wall > (ushort) 0 && wallBlend[(int) this._tileArray[index2 + 1, index1].wall] != wallBlend[(int) tile.wall];
              bool flag2 = this._tileArray[index2, index1 - 1].wall > (ushort) 0 && wallBlend[(int) this._tileArray[index2, index1 - 1].wall] != wallBlend[(int) tile.wall];
              bool flag3 = this._tileArray[index2, index1 + 1].wall > (ushort) 0 && wallBlend[(int) this._tileArray[index2, index1 + 1].wall] != wallBlend[(int) tile.wall];
              if (num7 != 0)
                WallDrawing.DrawOutline(TextureAssets.WallOutline.Value, new Vector2((float) (index2 * 16 /*0x10*/ - (int) screenPosition.X), (float) (index1 * 16 /*0x10*/ - (int) screenPosition.Y)) + drawOffSet, new Rectangle(0, 0, 2, 16 /*0x10*/), color1);
              if (flag1)
                WallDrawing.DrawOutline(TextureAssets.WallOutline.Value, new Vector2((float) (index2 * 16 /*0x10*/ - (int) screenPosition.X + 14), (float) (index1 * 16 /*0x10*/ - (int) screenPosition.Y)) + drawOffSet, new Rectangle(14, 0, 2, 16 /*0x10*/), color1);
              if (flag2)
                WallDrawing.DrawOutline(TextureAssets.WallOutline.Value, new Vector2((float) (index2 * 16 /*0x10*/ - (int) screenPosition.X), (float) (index1 * 16 /*0x10*/ - (int) screenPosition.Y)) + drawOffSet, new Rectangle(0, 0, 16 /*0x10*/, 2), color1);
              if (flag3)
                WallDrawing.DrawOutline(TextureAssets.WallOutline.Value, new Vector2((float) (index2 * 16 /*0x10*/ - (int) screenPosition.X), (float) (index1 * 16 /*0x10*/ - (int) screenPosition.Y + 14)) + drawOffSet, new Rectangle(0, 14, 16 /*0x10*/, 2), color1);
            }
          }
        }
      }
    }
    this.RestartLayeredBatch();
    Main.instance.DrawTileCracks(2, Main.LocalPlayer.hitReplace);
    Main.instance.DrawTileCracks(2, Main.LocalPlayer.hitTile);
  }

  public Texture2D GetWallDrawTexture(Tile tile)
  {
    return this.GetWallDrawTexture((int) tile.wall, (int) tile.wallColor());
  }

  public Texture2D GetWallDrawTexture(int wallType, int paintColor)
  {
    TilePaintSystemV2.WallVariationKey key = new TilePaintSystemV2.WallVariationKey()
    {
      WallType = wallType,
      PaintColor = paintColor
    };
    if (this._lastPaintLookupKey == key)
      return this._lastPaintLookupTexture;
    this._lastPaintLookupKey = key;
    this._lastPaintLookupTexture = this.LookupWallDrawTexture(key);
    return this._lastPaintLookupTexture;
  }

  private Texture2D LookupWallDrawTexture(TilePaintSystemV2.WallVariationKey key)
  {
    if (key.PaintColor != 0)
    {
      Texture2D requestIfNotReady = this._paintSystem.TryGetWallAndRequestIfNotReady(key.WallType, key.PaintColor);
      if (requestIfNotReady != null)
        return requestIfNotReady;
    }
    return TextureAssets.Wall[key.WallType].Value;
  }

  protected bool FullTile(int x, int y)
  {
    if (this._tileArray[x - 1, y] == null || this._tileArray[x - 1, y].blockType() != 0 || this._tileArray[x + 1, y] == null || this._tileArray[x + 1, y].blockType() != 0)
      return false;
    Tile tile = this._tileArray[x, y];
    if (tile == null || !tile.active() || Main.tileFrameImportant[(int) tile.type] || TileID.Sets.DrawsWalls[(int) tile.type] || tile.invisibleBlock() && !this._shouldShowInvisibleWalls || DebugOptions.ShowUnbreakableWall && tile.wall == (ushort) 350 || !Main.tileSolid[(int) tile.type] || Main.tileSolidTop[(int) tile.type])
      return false;
    int frameX = (int) tile.frameX;
    int frameY = (int) tile.frameY;
    if (Main.tileLargeFrames[(int) tile.type] > (byte) 0)
    {
      if ((frameY == 18 || frameY == 108) && (frameX >= 18 && frameX <= 54 || frameX >= 108 && frameX <= 144 /*0x90*/))
        return true;
    }
    else
    {
      switch (frameY)
      {
        case 0:
          if (frameX >= 180 && frameX <= 198)
            return true;
          break;
        case 18:
          if (frameX >= 18 && frameX <= 54 || frameX >= 108 && frameX <= 144 /*0x90*/ || frameX >= 180 && frameX <= 198)
            return true;
          break;
        case 36:
          if (frameX >= 108 && frameX <= 144 /*0x90*/ || frameX >= 180 && frameX <= 198)
            return true;
          break;
        default:
          if (frameY >= 90 && frameY <= 180)
          {
            if (frameX <= 54 || frameX >= 144 /*0x90*/ && frameX <= 216)
              return true;
            break;
          }
          if (frameY == 198 && frameX >= 108 && frameX <= 144 /*0x90*/)
            return true;
          break;
      }
    }
    return false;
  }
}
