// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Drawing.TileDrawing
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using System.Collections.Generic;
using Terraria.DataStructures;
using Terraria.GameContent.Events;
using Terraria.GameContent.Liquid;
using Terraria.GameContent.Tile_Entities;
using Terraria.Graphics;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Effects;
using Terraria.ID;
using Terraria.Testing;
using Terraria.UI;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Drawing;

public class TileDrawing : TileDrawingBase
{
  public static readonly uint Layer_LiquidBehindTiles = 0;
  public static readonly uint Layer_BehindTiles = 1;
  public static readonly uint Layer_Tiles = 2;
  public static readonly uint Layer_OverTiles = 3;
  private const int MAX_SPECIALS = 9000;
  private const int MAX_SPECIALS_LEGACY = 1000;
  private const float FORCE_FOR_MIN_WIND = 0.08f;
  private const float FORCE_FOR_MAX_WIND = 1.2f;
  private int _leafFrequency = 100000;
  private int[] _specialsCount = new int[11];
  private Point[][] _specialPositions = new Point[11][];
  private Dictionary<Point, int> _displayDollTileEntityPositions = new Dictionary<Point, int>();
  private Dictionary<Point, int> _hatRackTileEntityPositions = new Dictionary<Point, int>();
  private Dictionary<Point, int> _trainingDummyTileEntityPositions = new Dictionary<Point, int>();
  private Dictionary<Point, int> _itemFrameTileEntityPositions = new Dictionary<Point, int>();
  private Dictionary<Point, int> _deadCellsDisplayJarTileEntityPositions = new Dictionary<Point, int>();
  private Dictionary<Point, int> _foodPlatterTileEntityPositions = new Dictionary<Point, int>();
  private Dictionary<Point, int> _weaponRackTileEntityPositions = new Dictionary<Point, int>();
  private Dictionary<Point, int> _chestPositions = new Dictionary<Point, int>();
  private int _specialTilesCount;
  private int[] _specialTileX = new int[1000];
  private int[] _specialTileY = new int[1000];
  private UnifiedRandom _rand;
  private double _treeWindCounter;
  private double _grassWindCounter;
  private double _sunflowerWindCounter;
  private double _vineWindCounter;
  private WindGrid _windGrid = new WindGrid();
  private bool _shouldShowInvisibleBlocks;
  private bool _shouldShowInvisibleBlocks_LastFrame;
  private List<Point> _vineRootsPositions = new List<Point>();
  private List<Point> _reverseVineRootsPositions = new List<Point>();
  private TilePaintSystemV2 _paintSystem;
  private INatureRenderer _natureRenderer = (INatureRenderer) new NextNatureRenderer();
  private Color _martianGlow = new Color(0, 0, 0, 0);
  private Color _meteorGlow = new Color(100, 100, 100, 0);
  private Color _lavaMossGlow = new Color(150, 100, 50, 0);
  private Color _kryptonMossGlow = new Color(0, 200, 0, 0);
  private Color _xenonMossGlow = new Color(0, 180, 250, 0);
  private Color _argonMossGlow = new Color(225, 0, 125, 0);
  private Color _violetMossGlow = new Color(150, 0, 250, 0);
  private bool _isActiveAndNotPaused;
  private Player _perspectivePlayer = new Player();
  private Color _highQualityLightingRequirement;
  private Color _mediumQualityLightingRequirement;
  private static readonly Vector2 _zero = new Vector2();
  private static float[] noise = new float[256 /*0x0100*/];
  private TilePaintSystemV2.TileVariationkey _lastPaintLookupKey;
  private Texture2D _lastPaintLookupTexture;
  private Vector3[] _glowPaintColorSlices = new Vector3[9]
  {
    Vector3.One,
    Vector3.One,
    Vector3.One,
    Vector3.One,
    Vector3.One,
    Vector3.One,
    Vector3.One,
    Vector3.One,
    Vector3.One
  };
  private List<DrawData> _voidLensData = new List<DrawData>();

  private void AddSpecialPoint(int x, int y, TileDrawing.TileCounterType type)
  {
    this._specialPositions[(int) type][this._specialsCount[(int) type]++] = new Point(x, y);
  }

  private bool[] _tileSolid => Main.tileSolid;

  private bool[] _tileSolidTop => Main.tileSolidTop;

  private Dust[] _dust => Main.dust;

  private Gore[] _gore => Main.gore;

  public TileDrawing(TilePaintSystemV2 paintSystem)
  {
    this._paintSystem = paintSystem;
    this._rand = new UnifiedRandom();
    for (int index = 0; index < this._specialPositions.Length; ++index)
      this._specialPositions[index] = new Point[9000];
  }

  public void PreparePaintForTilesOnScreen()
  {
    if (Main.GameUpdateCount % 6U > 0U)
      return;
    int firstTileX;
    int lastTileX;
    int firstTileY;
    int lastTileY;
    TileDrawing.GetScreenDrawArea(!Main.drawToScreen, out Vector2 _, out firstTileX, out lastTileX, out firstTileY, out lastTileY);
    this.PrepareForAreaDrawing(firstTileX, lastTileX, firstTileY, lastTileY, true);
  }

  public void PrepareForAreaDrawing(
    int firstTileX,
    int lastTileX,
    int firstTileY,
    int lastTileY,
    bool prepareLazily)
  {
    TimeLogger.StartTimestamp fromTimestamp = TimeLogger.Start();
    TilePaintSystemV2.TileVariationkey lookupKey1 = new TilePaintSystemV2.TileVariationkey();
    TilePaintSystemV2.WallVariationKey lookupKey2 = new TilePaintSystemV2.WallVariationKey();
    for (int index1 = firstTileY; index1 < lastTileY + 4; ++index1)
    {
      for (int index2 = firstTileX - 2; index2 < lastTileX + 2; ++index2)
      {
        Tile tile = Main.tile[index2, index1];
        if (tile != null)
        {
          if (tile.active())
          {
            Main.instance.LoadTiles((int) tile.type);
            lookupKey1.TileType = (int) tile.type;
            lookupKey1.PaintColor = (int) tile.color();
            int num = 0;
            switch (tile.type)
            {
              case 5:
                num = TileDrawing.GetTreeBiome(index2, index1, (int) tile.frameX, (int) tile.frameY);
                break;
              case 323:
                num = this.GetPalmTreeBiome(index2, index1);
                break;
            }
            lookupKey1.TileStyle = num;
            if (lookupKey1.PaintColor != 0)
              this._paintSystem.RequestTile(ref lookupKey1);
          }
          if (tile.wall != (ushort) 0)
          {
            Main.instance.LoadWall((int) tile.wall);
            lookupKey2.WallType = (int) tile.wall;
            lookupKey2.PaintColor = (int) tile.wallColor();
            if (lookupKey2.PaintColor != 0)
              this._paintSystem.RequestWall(ref lookupKey2);
          }
          if (!prepareLazily)
            this.MakeExtraPreparations(tile, index2, index1);
        }
      }
    }
    TimeLogger.FindPaintedTiles.AddTime(fromTimestamp);
  }

  private void MakeExtraPreparations(Tile tile, int x, int y)
  {
    switch (tile.type)
    {
      case 5:
        int treeFrame1 = 0;
        int floorY1 = 0;
        int topTextureFrameWidth1 = 0;
        int topTextureFrameHeight1 = 0;
        int treeStyle1 = 0;
        int xoffset1 = (tile.frameX == (short) 44).ToInt() - (tile.frameX == (short) 66).ToInt();
        if (!WorldGen.GetCommonTreeFoliageData(x, y, xoffset1, ref treeFrame1, ref treeStyle1, out floorY1, out topTextureFrameWidth1, out topTextureFrameHeight1))
          break;
        TilePaintSystemV2.TreeFoliageVariantKey lookupKey1 = new TilePaintSystemV2.TreeFoliageVariantKey()
        {
          TextureIndex = treeStyle1,
          PaintColor = (int) tile.color()
        };
        this._paintSystem.RequestTreeTop(ref lookupKey1);
        this._paintSystem.RequestTreeBranch(ref lookupKey1);
        break;
      case 323:
        int num = 15;
        if (x >= WorldGen.beachDistance && x <= Main.maxTilesX - WorldGen.beachDistance)
          num = 21;
        TilePaintSystemV2.TreeFoliageVariantKey lookupKey2 = new TilePaintSystemV2.TreeFoliageVariantKey()
        {
          TextureIndex = num,
          PaintColor = (int) tile.color()
        };
        this._paintSystem.RequestTreeTop(ref lookupKey2);
        this._paintSystem.RequestTreeBranch(ref lookupKey2);
        break;
      case 583:
      case 584:
      case 585:
      case 586:
      case 587:
      case 588:
      case 589:
        int treeFrame2 = 0;
        int floorY2 = 0;
        int topTextureFrameWidth2 = 0;
        int topTextureFrameHeight2 = 0;
        int treeStyle2 = 0;
        int xoffset2 = (tile.frameX == (short) 44).ToInt() - (tile.frameX == (short) 66).ToInt();
        if (!WorldGen.GetGemTreeFoliageData(x, y, xoffset2, ref treeFrame2, ref treeStyle2, out floorY2, out topTextureFrameWidth2, out topTextureFrameHeight2))
          break;
        TilePaintSystemV2.TreeFoliageVariantKey lookupKey3 = new TilePaintSystemV2.TreeFoliageVariantKey()
        {
          TextureIndex = treeStyle2,
          PaintColor = (int) tile.color()
        };
        this._paintSystem.RequestTreeTop(ref lookupKey3);
        this._paintSystem.RequestTreeBranch(ref lookupKey3);
        break;
      case 596:
      case 616:
        int treeFrame3 = 0;
        int floorY3 = 0;
        int topTextureFrameWidth3 = 0;
        int topTextureFrameHeight3 = 0;
        int treeStyle3 = 0;
        int xoffset3 = (tile.frameX == (short) 44).ToInt() - (tile.frameX == (short) 66).ToInt();
        if (!WorldGen.GetVanityTreeFoliageData(x, y, xoffset3, ref treeFrame3, ref treeStyle3, out floorY3, out topTextureFrameWidth3, out topTextureFrameHeight3))
          break;
        TilePaintSystemV2.TreeFoliageVariantKey lookupKey4 = new TilePaintSystemV2.TreeFoliageVariantKey()
        {
          TextureIndex = treeStyle3,
          PaintColor = (int) tile.color()
        };
        this._paintSystem.RequestTreeTop(ref lookupKey4);
        this._paintSystem.RequestTreeBranch(ref lookupKey4);
        break;
      case 634:
        int treeFrame4 = 0;
        int floorY4 = 0;
        int topTextureFrameWidth4 = 0;
        int topTextureFrameHeight4 = 0;
        int treeStyle4 = 0;
        int xoffset4 = (tile.frameX == (short) 44).ToInt() - (tile.frameX == (short) 66).ToInt();
        if (!WorldGen.GetAshTreeFoliageData(x, y, xoffset4, ref treeFrame4, ref treeStyle4, out floorY4, out topTextureFrameWidth4, out topTextureFrameHeight4))
          break;
        TilePaintSystemV2.TreeFoliageVariantKey lookupKey5 = new TilePaintSystemV2.TreeFoliageVariantKey()
        {
          TextureIndex = treeStyle4,
          PaintColor = (int) tile.color()
        };
        this._paintSystem.RequestTreeTop(ref lookupKey5);
        this._paintSystem.RequestTreeBranch(ref lookupKey5);
        break;
    }
  }

  public void Update()
  {
    if (Main.dedServ)
      return;
    double lerpValue = (double) Utils.GetLerpValue(0.08f, 1.2f, Math.Abs(Main.WindForVisuals), true);
    this._treeWindCounter += 1.0 / 240.0 + 1.0 / 240.0 * lerpValue * 2.0;
    this._grassWindCounter += 1.0 / 180.0 + 1.0 / 180.0 * lerpValue * 4.0;
    this._sunflowerWindCounter += 1.0 / 420.0 + 1.0 / 420.0 * lerpValue * 5.0;
    this._vineWindCounter += 1.0 / 120.0 + 1.0 / 120.0 * lerpValue * 0.40000000596046448;
    this.UpdateLeafFrequency();
    this.EnsureWindGridSize();
    this._windGrid.Update();
    this._shouldShowInvisibleBlocks = Main.ShouldShowInvisibleBlocksAndWalls();
    if (this._shouldShowInvisibleBlocks_LastFrame == this._shouldShowInvisibleBlocks)
      return;
    this._shouldShowInvisibleBlocks_LastFrame = this._shouldShowInvisibleBlocks;
    Main.sectionManager.SetAllFramedSectionsAsNeedingRefresh();
  }

  public void SpecificHacksForCapture()
  {
    Main.sectionManager.SetAllFramedSectionsAsNeedingRefresh();
    this.ClearSpecialBlockCounts();
  }

  public void PreDrawTiles(bool solidLayer, bool intoRenderTargets = false)
  {
    bool flag = intoRenderTargets || Lighting.UpdateEveryFrame;
    if (!(!solidLayer & flag))
      return;
    this.ClearSpecialBlockCounts();
  }

  public void ClearSpecialBlockCounts()
  {
    this._specialsCount[3] = 0;
    this._specialsCount[2] = 0;
    this._specialsCount[6] = 0;
    this._specialsCount[4] = 0;
    this._specialsCount[1] = 0;
    this._specialsCount[10] = 0;
    this._specialsCount[0] = 0;
    this._specialsCount[7] = 0;
    this._specialsCount[8] = 0;
    this._specialsCount[9] = 0;
  }

  private void DrawNature(
    Texture2D texture,
    Vector2 position,
    Rectangle sourceRectangle,
    Color color,
    float rotation,
    Vector2 origin,
    float scale,
    SpriteEffects effects,
    float layerDepth,
    SideFlags seams = SideFlags.None)
  {
    this._natureRenderer.DrawNature(texture, position, sourceRectangle, color, rotation, origin, scale, effects, layerDepth, seams);
  }

  private void DrawNatureGlowmask(
    Texture2D texture,
    Vector2 position,
    Rectangle? sourceRectangle,
    Color color,
    float rotation,
    Vector2 origin,
    float scale,
    SpriteEffects effects,
    float layerDepth)
  {
    this._natureRenderer.DrawGlowmask(texture, position, sourceRectangle, color, rotation, origin, scale, effects, layerDepth);
  }

  public void PostDrawTiles(bool solidLayer)
  {
    if (!solidLayer)
    {
      TimeLogger.StartTimestamp fromTimestamp = TimeLogger.Start();
      SpriteBatchBeginner beginner = new SpriteBatchBeginner(SpriteSortMode.Deferred, BlendState.AlphaBlend, Main.DefaultSamplerState, DepthStencilState.None, Main.Rasterizer, (Effect) null, Main.Transform);
      beginner.Begin(Main.spriteBatch);
      this.DrawMultiTileVines();
      this.DrawMultiTileGrass();
      this.DrawVoidLenses();
      this.DrawTeleportationPylons();
      this.DrawMasterTrophies();
      this.DrawGrass();
      this.DrawAnyDirectionalGrass();
      this.DrawTrees();
      this.DrawVines();
      this.DrawReverseVines();
      Main.spriteBatch.End();
      TimeLogger.TileExtras.AddTime(fromTimestamp);
      this._natureRenderer.DrawAfterAllObjects(beginner);
    }
    if (!solidLayer)
      return;
    TimeLogger.StartTimestamp fromTimestamp1 = TimeLogger.Start();
    this.DrawEntities_HatRacks();
    this.DrawEntities_DisplayDolls();
    TimeLogger.ClothingRacks.AddTime(fromTimestamp1);
  }

  public void DrawLiquidBehindTiles(int waterStyleOverride = -1)
  {
    Main.tileBatch.Restart();
    Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
    Vector2 drawOffSet;
    int firstTileX;
    int lastTileX;
    int firstTileY;
    int lastTileY;
    TileDrawing.GetScreenDrawArea(!Main.drawToScreen, out drawOffSet, out firstTileX, out lastTileX, out firstTileY, out lastTileY);
    for (int tileY = firstTileY; tileY < lastTileY + 4; ++tileY)
    {
      for (int tileX = firstTileX - 2; tileX < lastTileX + 2; ++tileX)
      {
        Tile tileCache = Main.tile[tileX, tileY];
        if (tileCache != null)
        {
          Main.tileBatch.SetLayer(0U);
          this.DrawTile_LiquidBehindTile(false, waterStyleOverride, unscaledPosition, drawOffSet, tileX, tileY, tileCache);
        }
      }
    }
    int num = Main.tileBatch.End();
    TimeLogger.LiquidBackgroundDrawCalls.Add(num);
  }

  public void Draw(bool solidLayer, bool intoRenderTargets, int waterStyleOverride = -1)
  {
    this.FlushLogData = solidLayer ? TimeLogger.FlushSolidTiles : TimeLogger.FlushNonSolidTiles;
    this.DrawCallLogData = solidLayer ? TimeLogger.SolidDrawCalls : TimeLogger.NonSolidDrawCalls;
    this._isActiveAndNotPaused = FocusHelper.AllowTileDrawingToEmitEffects;
    this._perspectivePlayer = Main.SceneMetrics.PerspectivePlayer;
    Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
    if (!solidLayer)
      Main.critterCage = false;
    this.EnsureWindGridSize();
    this.ClearLegacyCachedDraws();
    this.ClearCachedTileDraws(solidLayer);
    float num1 = (float) ((double) byte.MaxValue * (1.0 - (double) Main.gfxQuality) + 30.0 * (double) Main.gfxQuality);
    this._highQualityLightingRequirement.R = (byte) num1;
    this._highQualityLightingRequirement.G = (byte) ((double) num1 * 1.1);
    this._highQualityLightingRequirement.B = (byte) ((double) num1 * 1.2);
    float num2 = (float) (50.0 * (1.0 - (double) Main.gfxQuality) + 2.0 * (double) Main.gfxQuality);
    this._mediumQualityLightingRequirement.R = (byte) num2;
    this._mediumQualityLightingRequirement.G = (byte) ((double) num2 * 1.1);
    this._mediumQualityLightingRequirement.B = (byte) ((double) num2 * 1.2);
    if (DebugOptions.devLightTilesCheat)
    {
      this._highQualityLightingRequirement.R = byte.MaxValue;
      this._highQualityLightingRequirement.G = byte.MaxValue;
      this._highQualityLightingRequirement.B = byte.MaxValue;
      this._mediumQualityLightingRequirement.R = byte.MaxValue;
      this._mediumQualityLightingRequirement.G = byte.MaxValue;
      this._mediumQualityLightingRequirement.B = byte.MaxValue;
    }
    Vector2 drawOffSet;
    int firstTileX;
    int lastTileX;
    int firstTileY;
    int lastTileY;
    TileDrawing.GetScreenDrawArea(!Main.drawToScreen, out drawOffSet, out firstTileX, out lastTileX, out firstTileY, out lastTileY);
    byte num3 = (byte) (100.0 + 150.0 * (double) Main.martianLight);
    this._martianGlow = new Color((int) num3, (int) num3, (int) num3, 0);
    this._lastPaintLookupKey = new TilePaintSystemV2.TileVariationkey()
    {
      TileType = -1
    };
    for (int index1 = firstTileY; index1 < lastTileY + 4; ++index1)
    {
      for (int index2 = firstTileX - 2; index2 < lastTileX + 2; ++index2)
      {
        Tile tileCache = Main.tile[index2, index1];
        if (tileCache == null)
        {
          Tile tile = new Tile();
          Main.tile[index2, index1] = tile;
          Main.mapTime += 60;
        }
        else if (tileCache.active() && this.IsTileDrawLayerSolid(tileCache.type) == solidLayer && (!DebugOptions.ShowUnbreakableWall || tileCache.wall != (ushort) 350))
        {
          if (solidLayer)
          {
            Main.tileBatch.SetLayer(TileDrawing.Layer_LiquidBehindTiles);
            this.DrawTile_LiquidBehindTile(solidLayer, waterStyleOverride, unscaledPosition, drawOffSet, index2, index1, tileCache);
          }
          Main.tileBatch.SetLayer(TileDrawing.Layer_Tiles);
          ushort type = tileCache.type;
          short frameX = tileCache.frameX;
          short frameY = tileCache.frameY;
          if (!TextureAssets.Tile[(int) type].IsLoaded)
            Main.instance.LoadTiles((int) type);
          switch (type)
          {
            case 27:
              if ((int) frameX % 36 == 0 && frameY == (short) 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileGrass);
                continue;
              }
              continue;
            case 34:
              if ((int) frameX % 54 == 0 && (int) frameY % 54 == 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileVine);
                continue;
              }
              continue;
            case 42:
            case 270:
            case 271:
            case 572:
            case 581:
            case 660:
              if ((int) frameX % 18 == 0 && (int) frameY % 36 == 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileVine);
                continue;
              }
              continue;
            case 52:
            case 62:
            case 115:
            case 205:
            case 382:
            case 528:
            case 636:
            case 638:
              this.CrawlToTopOfVineAndAddSpecialPoint(index1, index2);
              continue;
            case 91:
              if ((int) frameX % 18 == 0 && (int) frameY % 54 == 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileVine);
                continue;
              }
              continue;
            case 95:
            case 126:
            case 444:
              if ((int) frameX % 36 == 0 && (int) frameY % 36 == 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileVine);
                continue;
              }
              continue;
            case 184:
              this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.AnyDirectionalGrass);
              continue;
            case 233:
              if (frameY == (short) 0 && (int) frameX % 54 == 0)
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileGrass);
              if (frameY == (short) 36 && (int) frameX % 36 == 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileGrass);
                continue;
              }
              continue;
            case 236:
            case 238:
            case 702:
              if ((int) frameX % 36 == 0 && frameY == (short) 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileGrass);
                continue;
              }
              continue;
            case 373:
            case 374:
            case 375:
            case 461:
            case 709:
              this.EmitLiquidDrops(index1, index2, tileCache, type);
              continue;
            case 454:
              if ((int) frameX % 72 == 0 && (int) frameY % 54 == 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileVine);
                continue;
              }
              continue;
            case 465:
            case 591:
            case 592:
              if ((int) frameX % 36 == 0 && (int) frameY % 54 == 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileVine);
                continue;
              }
              continue;
            case 485:
            case 489:
            case 490:
              if (frameY == (short) 0 && (int) frameX % 36 == 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileGrass);
                continue;
              }
              continue;
            case 491:
              if (frameX == (short) 18 && frameY == (short) 18)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.VoidLens);
                break;
              }
              break;
            case 493:
              if (frameY == (short) 0 && (int) frameX % 18 == 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileGrass);
                continue;
              }
              continue;
            case 519:
              if ((int) frameX / 18 <= 4)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileGrass);
                continue;
              }
              continue;
            case 521:
            case 522:
            case 523:
            case 524:
            case 525:
            case 526:
            case 527:
              if (frameY == (short) 0 && (int) frameX % 36 == 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileGrass);
                continue;
              }
              continue;
            case 530:
              if (frameX < (short) 270)
              {
                if ((int) frameX % 54 == 0 && frameY == (short) 0)
                {
                  this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileGrass);
                  continue;
                }
                continue;
              }
              break;
            case 549:
              this.CrawlToBottomOfReverseVineAndAddSpecialPoint(index1, index2);
              continue;
            case 597:
              if ((int) frameX % 54 == 0 && frameY == (short) 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.TeleportationPylon);
                break;
              }
              break;
            case 617:
              if ((int) frameX % 54 == 0 && (int) frameY % 72 == 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MasterTrophy);
                break;
              }
              break;
            case 651:
              if ((int) frameX % 54 == 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileGrass);
                continue;
              }
              continue;
            case 652:
              if ((int) frameX % 36 == 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileGrass);
                continue;
              }
              continue;
            case 698:
              if ((int) frameX % 18 == 0 && frameY == (short) 0)
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileVine);
                continue;
              }
              continue;
            case 705:
              if ((int) frameX % 486 < 270)
              {
                if ((int) frameX % 54 == 0 && (int) frameY % 36 == 0)
                {
                  this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.MultiTileGrass);
                  continue;
                }
                continue;
              }
              break;
            default:
              if (this.ShouldSwayInWind(index2, index1, tileCache))
              {
                this.AddSpecialPoint(index2, index1, TileDrawing.TileCounterType.WindyGrass);
                continue;
              }
              break;
          }
          this.DrawSingleTile(unscaledPosition, drawOffSet, index2, index1);
        }
      }
    }
    this.RestartLayeredBatch();
    if (solidLayer)
    {
      Main.instance.DrawTileCracks(1, Main.player[Main.myPlayer].hitReplace);
      Main.instance.DrawTileCracks(1, Main.player[Main.myPlayer].hitTile);
      this.RestartSpriteBatch();
    }
    this.DrawSpecialTilesLegacy(unscaledPosition, drawOffSet);
    if (!TileObject.objectPreview.Active || !Main.LocalPlayer.cursorItemIconEnabled || !Main.placementPreview || CaptureManager.Instance.Active)
      return;
    Main.instance.LoadTiles((int) TileObject.objectPreview.Type);
    float placementPreviewOpacity = Main.LocalPlayer.GetPlacementPreviewOpacity();
    TileObject.DrawPreview(Main.spriteBatch, TileObject.objectPreview, unscaledPosition - drawOffSet, placementPreviewOpacity);
  }

  private void CrawlToTopOfVineAndAddSpecialPoint(int j, int i)
  {
    int y = j;
    for (int j1 = j - 1; j1 > 0; --j1)
    {
      Tile tile = Main.tile[i, j1];
      if (WorldGen.BottomEdgeCanBeAttachedTo(i, j1) || !tile.active())
      {
        y = j1 + 1;
        break;
      }
    }
    Point point = new Point(i, y);
    if (this._vineRootsPositions.Contains(point))
      return;
    this._vineRootsPositions.Add(point);
    this.AddSpecialPoint(i, y, TileDrawing.TileCounterType.Vine);
  }

  private void CrawlToBottomOfReverseVineAndAddSpecialPoint(int j, int i)
  {
    int y = j;
    for (int j1 = j; j1 < Main.maxTilesY; ++j1)
    {
      Tile tile = Main.tile[i, j1];
      if (WorldGen.TopEdgeCanBeAttachedTo(i, j1) || !tile.active())
      {
        y = j1 - 1;
        break;
      }
    }
    Point point = new Point(i, y);
    if (this._reverseVineRootsPositions.Contains(point))
      return;
    this._reverseVineRootsPositions.Add(point);
    this.AddSpecialPoint(i, y, TileDrawing.TileCounterType.ReverseVine);
  }

  private static float SmoothStep(float x)
  {
    return (float) ((double) x * (double) x * (3.0 - 2.0 * (double) x));
  }

  static TileDrawing()
  {
    Random random = new Random(0);
    for (int index = 0; index < TileDrawing.noise.Length; ++index)
      TileDrawing.noise[index] = (float) (random.NextDouble() * 2.0 - 1.0);
  }

  private static float LinearNoise(float x)
  {
    int num1 = (int) x;
    if ((double) x < 0.0)
      --num1;
    int num2 = num1 + 1;
    float num3 = x - (float) num1;
    double num4 = (double) TileDrawing.noise[num1 & (int) byte.MaxValue];
    float num5 = TileDrawing.noise[num2 & (int) byte.MaxValue];
    float num6 = num3;
    double num7 = 1.0 - (double) num6;
    return (float) (num4 * num7 + (double) num5 * (double) num6);
  }

  private static uint Hash(uint x)
  {
    x ^= x >> 16 /*0x10*/;
    x *= 2146121005U;
    x ^= x >> 15;
    x *= 2221713035U;
    x ^= x >> 16 /*0x10*/;
    return x;
  }

  private static uint Hash2(uint x)
  {
    x ^= x >> 15;
    x *= 3513297581U;
    x ^= x >> 15;
    x *= 2943497623U;
    x ^= x >> 15;
    return x;
  }

  private static float DistToWanderingCircle(
    Point pos,
    int gridSize,
    float wanderDist,
    float cyclesPerTick,
    uint seed)
  {
    Point point = new Point(pos.X / gridSize, pos.Y / gridSize);
    Vector2 vector2 = new Vector2(((float) point.X + 0.5f) * (float) gridSize, ((float) point.Y + 0.5f) * (float) gridSize);
    float forVisualEffects = (float) Main.timeForVisualEffects;
    uint num1 = (uint) (((int) TileDrawing.Hash((uint) point.X) ^ (int) TileDrawing.Hash2((uint) point.Y) ^ (int) seed) & 16777215 /*0xFFFFFF*/);
    uint num2 = (uint) (((int) TileDrawing.Hash2((uint) point.X) ^ (int) TileDrawing.Hash((uint) point.Y) ^ (int) seed) & 16777215 /*0xFFFFFF*/);
    vector2.X += TileDrawing.LinearNoise(((float) num1 + forVisualEffects) * cyclesPerTick) * wanderDist;
    vector2.Y += TileDrawing.LinearNoise(((float) num2 + forVisualEffects) * cyclesPerTick) * wanderDist;
    return Vector2.Distance(pos.ToVector2(), vector2);
  }

  private static float LavaLightA(int tileX, int tileY)
  {
    double wanderingCircle1 = (double) TileDrawing.DistToWanderingCircle(new Point(tileX, tileY), 7, 2f, 0.025f, 2221713035U);
    float wanderingCircle2 = TileDrawing.DistToWanderingCircle(new Point(tileX + 3, tileY), 7, 2f, 0.025f, 657044585U);
    float wanderingCircle3 = TileDrawing.DistToWanderingCircle(new Point(tileX, tileY + 3), 7, 2f, 0.025f, 741521833U);
    float wanderingCircle4 = TileDrawing.DistToWanderingCircle(new Point(tileX + 3, tileY + 3), 7, 2f, 0.025f, 56936621U);
    double val2 = (double) wanderingCircle2;
    float fromValue = TileDrawing.SmoothStep(1f - Utils.GetLerpValue(0.0f, 3.5f, Math.Min(Math.Min((float) wanderingCircle1, (float) val2), Math.Min(wanderingCircle3, wanderingCircle4)), true));
    float toMin = 0.0f;
    if (!WorldGen.SolidTile(tileX, tileY - 1))
      toMin = 0.8f;
    return Utils.Remap(fromValue, 0.7f, 1f, toMin, 1f);
  }

  private void DrawSingleTile(Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY)
  {
    TileDrawInfo drawData = new TileDrawInfo()
    {
      tileCache = Main.tile[tileX, tileY]
    };
    drawData.typeCache = drawData.tileCache.type;
    drawData.tileFrameX = drawData.tileCache.frameX;
    drawData.tileFrameY = drawData.tileCache.frameY;
    drawData.tileLight = Lighting.GetColor(tileX, tileY);
    if (drawData.tileCache.liquid > (byte) 0 && drawData.tileCache.type == (ushort) 518)
      return;
    this.GetTileDrawData(tileX, tileY, drawData.tileCache, drawData.typeCache, ref drawData.tileFrameX, ref drawData.tileFrameY, out drawData.tileWidth, out drawData.tileHeight, out drawData.tileTop, out drawData.halfBrickHeight, out drawData.addFrX, out drawData.addFrY, out drawData.tileSpriteEffect, out drawData.glowTexture, out drawData.glowSourceRect, out drawData.glowColor);
    if (drawData.tileTop < 0)
      Main.tileBatch.SetLayer(TileDrawing.Layer_OverTiles);
    else if (drawData.tileTop + drawData.tileHeight <= 16 /*0x10*/)
      Main.tileBatch.SetLayer(TileDrawing.Layer_Tiles);
    else
      Main.tileBatch.SetLayer(TileDrawing.Layer_BehindTiles);
    drawData.drawTexture = this.GetTileDrawTexture(drawData.tileCache, tileX, tileY);
    Texture2D highlightTexture = (Texture2D) null;
    Rectangle rectangle = Rectangle.Empty;
    Color transparent = Color.Transparent;
    if (TileID.Sets.HasOutlines[(int) drawData.typeCache])
      this.GetTileOutlineInfo(tileX, tileY, drawData.typeCache, ref drawData.tileLight, ref highlightTexture, ref transparent);
    if (this._perspectivePlayer.dangerSense && TileDrawing.IsTileDangerous(this._perspectivePlayer, drawData.tileCache, drawData.typeCache))
    {
      if (drawData.tileLight.R < byte.MaxValue)
        drawData.tileLight.R = byte.MaxValue;
      if (drawData.tileLight.G < (byte) 50)
        drawData.tileLight.G = (byte) 50;
      if (drawData.tileLight.B < (byte) 50)
        drawData.tileLight.B = (byte) 50;
      if (this._isActiveAndNotPaused && this._rand.Next(30) == 0)
      {
        int index = Dust.NewDust(new Vector2((float) (tileX * 16 /*0x10*/), (float) (tileY * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 60, Alpha: 100, Scale: 0.3f);
        this._dust[index].fadeIn = 1f;
        this._dust[index].velocity *= 0.1f;
        this._dust[index].noLight = true;
        this._dust[index].noGravity = true;
      }
    }
    if (this._perspectivePlayer.findTreasure && Main.IsTileSpelunkable(drawData.typeCache, drawData.tileFrameX, drawData.tileFrameY))
    {
      if (drawData.tileLight.R < (byte) 200)
        drawData.tileLight.R = (byte) 200;
      if (drawData.tileLight.G < (byte) 170)
        drawData.tileLight.G = (byte) 170;
      if (this._isActiveAndNotPaused && this._rand.Next(60) == 0)
      {
        int index = Dust.NewDust(new Vector2((float) (tileX * 16 /*0x10*/), (float) (tileY * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 204, Alpha: 150, Scale: 0.3f);
        this._dust[index].fadeIn = 1f;
        this._dust[index].velocity *= 0.1f;
        this._dust[index].noLight = true;
      }
    }
    if (this._perspectivePlayer.biomeSight)
    {
      Color white = Color.White;
      if (Main.IsTileBiomeSightable(drawData.typeCache, drawData.tileFrameX, drawData.tileFrameY, ref white))
      {
        if ((int) drawData.tileLight.R < (int) white.R)
          drawData.tileLight.R = white.R;
        if ((int) drawData.tileLight.G < (int) white.G)
          drawData.tileLight.G = white.G;
        if ((int) drawData.tileLight.B < (int) white.B)
          drawData.tileLight.B = white.B;
        if (this._isActiveAndNotPaused && this._rand.Next(480) == 0)
        {
          Color newColor = white;
          int index = Dust.NewDust(new Vector2((float) (tileX * 16 /*0x10*/), (float) (tileY * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 267, Alpha: 150, newColor: newColor, Scale: 0.3f);
          this._dust[index].noGravity = true;
          this._dust[index].fadeIn = 1f;
          this._dust[index].velocity *= 0.1f;
          this._dust[index].noLightEmittence = true;
        }
      }
    }
    if (this._isActiveAndNotPaused)
    {
      if (Lighting.UpdateEveryFrame)
      {
        FastRandom fastRandom = new FastRandom(Main.TileFrameSeed);
        fastRandom = fastRandom.WithModifier(tileX, tileY);
        if (fastRandom.Next(4) != 0)
          goto label_39;
      }
      this.DrawTiles_EmitParticles(tileY, tileX, drawData.tileCache, drawData.typeCache, drawData.tileFrameX, drawData.tileFrameY, drawData.tileLight);
label_39:
      drawData.tileLight = this.DrawTiles_GetLightOverride(tileY, tileX, drawData.tileCache, drawData.typeCache, drawData.tileFrameX, drawData.tileFrameY, drawData.tileLight);
    }
    bool flag1 = false;
    if (drawData.glowTexture != null || Main.tileGlowMask[(int) drawData.typeCache] != (short) -1 || Main.tileFlame[(int) drawData.typeCache])
      flag1 = true;
    if (drawData.tileLight.R >= (byte) 1 || drawData.tileLight.G >= (byte) 1 || drawData.tileLight.B >= (byte) 1 || TileID.Sets.IgnoreDrawLightConditions[(int) drawData.typeCache])
      flag1 = true;
    if (drawData.tileCache.wall > (ushort) 0 && (drawData.tileCache.wall == (ushort) 318 || drawData.tileCache.fullbrightWall()))
      flag1 = true;
    bool flag2 = flag1 & this.IsVisible(drawData.tileCache);
    this.CacheSpecialDraws_Part1(tileX, tileY, (int) drawData.typeCache, (int) drawData.tileFrameX, (int) drawData.tileFrameY, !flag2);
    this.CacheSpecialDraws_Part2(tileX, tileY, drawData, !flag2);
    if (drawData.typeCache == (ushort) 72 && drawData.tileFrameX >= (short) 36)
    {
      int num = 0;
      if (drawData.tileFrameY == (short) 18)
        num = 1;
      else if (drawData.tileFrameY == (short) 36)
        num = 2;
      Main.tileBatch.Draw(TextureAssets.ShroomCap.Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X - 22), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y - 26)) + screenOffset, new Rectangle?(new Rectangle(num * 62, 0, 60, 42)), (VertexColors) Lighting.GetColor(tileX, tileY), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    }
    Rectangle normalTileRect = new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight - drawData.halfBrickHeight);
    float num1 = (float) (((double) drawData.tileWidth - 16.0) / 2.0);
    if (drawData.typeCache >= (ushort) 0 && TileID.Sets.DoNotAdjustDrawPositionBasedOnTileWidth[(int) drawData.typeCache])
      num1 = 0.0f;
    Vector2 vector2 = new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - num1, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop + drawData.halfBrickHeight)) + screenOffset;
    if (!flag2)
      return;
    drawData.colorTint = Color.White;
    drawData.finalColor = TileDrawing.GetFinalLight(drawData.tileCache, drawData.typeCache, drawData.tileLight, drawData.colorTint);
    switch (drawData.typeCache)
    {
      case 51:
      case 697:
        drawData.finalColor = drawData.tileLight * 0.5f;
        break;
      case 80 /*0x50*/:
        bool evil;
        bool good;
        bool crimson;
        WorldGen.GetCactusType(tileX, tileY, (int) drawData.tileFrameX, (int) drawData.tileFrameY, out evil, out good, out crimson);
        if (evil)
          normalTileRect.Y += 54;
        if (good)
          normalTileRect.Y += 108;
        if (crimson)
        {
          normalTileRect.Y += 162;
          break;
        }
        break;
      case 83:
        drawData.drawTexture = this.GetTileDrawTexture(drawData.tileCache, tileX, tileY);
        break;
      case 114:
        if (drawData.tileFrameY > (short) 0)
        {
          normalTileRect.Height += 2;
          break;
        }
        break;
      case 129:
        drawData.finalColor = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 100);
        int num2 = 2;
        if (drawData.tileFrameX >= (short) 324)
          drawData.finalColor = Color.Transparent;
        if (drawData.tileFrameY < (short) 36)
        {
          vector2.Y += (float) (num2 * (drawData.tileFrameY == (short) 0).ToDirectionInt());
          break;
        }
        vector2.X += (float) (num2 * (drawData.tileFrameY == (short) 36).ToDirectionInt());
        break;
      case 136:
        switch ((int) drawData.tileFrameX / 18)
        {
          case 1:
            vector2.X += -2f;
            break;
          case 2:
            vector2.X += 2f;
            break;
        }
        break;
      case 160 /*0xA0*/:
      case 692:
        Color oldColor = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB, (int) byte.MaxValue);
        if (drawData.tileCache.inActive())
          oldColor = drawData.tileCache.actColor(oldColor);
        drawData.finalColor = oldColor;
        break;
      case 272:
        int num3 = (Main.tileFrame[(int) drawData.typeCache] + tileX % 2 + tileY % 2 + tileX % 3 + tileY % 3) % 2 * 90;
        drawData.addFrY += num3;
        normalTileRect.Y += num3;
        break;
      case 323:
        if (drawData.tileCache.frameX <= (short) 132 && drawData.tileCache.frameX >= (short) 88)
          return;
        vector2.X += (float) drawData.tileCache.frameY;
        break;
      case 442:
        if ((int) drawData.tileFrameX / 22 == 3)
        {
          vector2.X += 2f;
          break;
        }
        break;
      case 723:
      case 724:
        switch ((int) drawData.tileFrameX / 18)
        {
          case 0:
            vector2 += new Vector2(0.0f, 2f);
            break;
          case 1:
            vector2 += new Vector2(0.0f, -2f);
            break;
          case 2:
            vector2 += new Vector2(-2f, 0.0f);
            break;
          case 3:
            vector2 += new Vector2(2f, 0.0f);
            break;
        }
        break;
      case 726:
        vector2.X -= 2f;
        switch (drawData.tileCache.blockType())
        {
          case 2:
            vector2.X += 6f;
            vector2.Y += 2f;
            break;
          case 3:
            vector2.X -= 6f;
            vector2.Y += 2f;
            break;
          case 4:
            vector2.X += 6f;
            break;
          case 5:
            vector2.X -= 6f;
            break;
        }
        break;
      case 751:
        if (drawData.tileFrameX != (short) 0 || drawData.tileCache.frameY != (short) 0)
          return;
        vector2.X += 11f;
        vector2.Y -= 8f;
        break;
      case 752:
        if (drawData.tileFrameX != (short) 0 || drawData.tileFrameY != (short) 0)
          return;
        vector2.X += 8f;
        break;
    }
    if (drawData.typeCache == (ushort) 314)
      this.DrawTile_MinecartTrack(screenPosition, screenOffset, tileX, tileY, drawData);
    else if (drawData.typeCache == (ushort) 171)
      this.DrawXmasTree(screenPosition, screenOffset, tileX, tileY, drawData);
    else
      this.DrawBasicTile(screenPosition, screenOffset, tileX, tileY, drawData, normalTileRect, vector2);
    if (Main.tileGlowMask[(int) drawData.tileCache.type] != (short) -1)
    {
      short index1 = Main.tileGlowMask[(int) drawData.tileCache.type];
      if (TextureAssets.GlowMask.IndexInRange<Asset<Texture2D>>((int) index1))
        drawData.drawTexture = TextureAssets.GlowMask[(int) index1].Value;
      double num4 = Main.timeForVisualEffects * 0.08;
      Color colors = Color.White;
      bool flag3 = false;
      switch (drawData.tileCache.type)
      {
        case 129:
          if (drawData.tileFrameX < (short) 324)
          {
            flag3 = true;
            break;
          }
          drawData.drawTexture = this.GetTileDrawTexture(drawData.tileCache, tileX, tileY);
          Color rgb = Main.hslToRgb((float) (0.699999988079071 + Math.Sin(6.2831854820251465 * (double) Main.GlobalTimeWrappedHourly * 0.15999999642372131 + (double) tileX * 0.30000001192092896 + (double) tileY * 0.699999988079071) * 0.15999999642372131), 1f, 0.5f);
          rgb.A /= (byte) 2;
          colors = rgb * 0.3f;
          int num5 = 72;
          for (float f = 0.0f; (double) f < 6.2831854820251465; f += 1.57079637f)
            Main.tileBatch.Draw(drawData.drawTexture, vector2 + f.ToRotationVector2() * 2f, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY + num5, drawData.tileWidth, drawData.tileHeight)), (VertexColors) colors, Vector2.Zero, 1f, SpriteEffects.None);
          colors = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 100);
          break;
        case 209:
          colors = PortalHelper.GetPortalColor(Main.myPlayer, drawData.tileCache.frameX >= (short) 288 ? 1 : 0);
          break;
        case 350:
          colors = new Color(new Vector4((float) (-Math.Cos((int) (num4 / 6.283) % 3 == 1 ? num4 : 0.0) * 0.2 + 0.2)));
          break;
        case 370:
        case 390:
          colors = this._meteorGlow;
          break;
        case 381:
        case 517:
        case 687:
          colors = this._lavaMossGlow;
          break;
        case 391:
          colors = new Color(250, 250, 250, 200);
          break;
        case 429:
        case 445:
          drawData.drawTexture = this.GetTileDrawTexture(drawData.tileCache, tileX, tileY);
          drawData.addFrY = 18;
          break;
        case 534:
        case 535:
        case 689:
          colors = this._kryptonMossGlow;
          break;
        case 536:
        case 537:
        case 690:
          colors = this._xenonMossGlow;
          break;
        case 539:
        case 540:
        case 688:
          colors = this._argonMossGlow;
          break;
        case 625:
        case 626:
        case 691:
          colors = this._violetMossGlow;
          break;
        case 627:
        case 628:
        case 692:
          colors = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB);
          break;
        case 633:
          colors = Color.Lerp(Color.White, drawData.finalColor, 0.75f);
          break;
        case 659:
        case 667:
        case 708:
          colors = LiquidRenderer.GetShimmerGlitterColor(true, (float) tileX, (float) tileY);
          break;
        case 699:
          colors = Color.White;
          break;
        case 717:
          float num6 = TileDrawing.LavaLightA(tileX, tileY);
          colors = new Color(num6, num6, num6, num6 / 2f);
          break;
        case 718:
          colors = new Color(0, 0, 0, 0);
          break;
        case 725:
          float opacity = Filters.Scene["Noir"].Opacity;
          if ((double) opacity > 0.0 && (int) drawData.tileFrameX % 36 == 0 && drawData.tileFrameY == (short) 54)
          {
            Vector2 position = vector2 + new Vector2(16f, 24f);
            SpriteEffects effects = drawData.tileFrameX >= (short) 36 ? SpriteEffects.FlipHorizontally : SpriteEffects.None;
            colors = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 100) * opacity;
            Main.tileBatch.Draw(drawData.drawTexture, position, new Rectangle?(drawData.drawTexture.Frame()), (VertexColors) colors, drawData.drawTexture.Frame().Center.ToVector2(), 1f, effects);
          }
          flag3 = true;
          break;
      }
      if (!flag3)
      {
        if (drawData.tileCache.slope() == (byte) 0 && !drawData.tileCache.halfBrick())
          Main.tileBatch.Draw(drawData.drawTexture, vector2, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) colors, Vector2.Zero, 1f, SpriteEffects.None);
        else if (drawData.tileCache.halfBrick())
          Main.tileBatch.Draw(drawData.drawTexture, vector2, new Rectangle?(normalTileRect), (VertexColors) colors, TileDrawing._zero, 1f, SpriteEffects.None);
        else if (TileID.Sets.HasSlopeFrames[(int) drawData.tileCache.type])
        {
          Main.tileBatch.Draw(drawData.drawTexture, vector2, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, 16 /*0x10*/, 16 /*0x10*/)), (VertexColors) colors, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        }
        else
        {
          int num7 = (int) drawData.tileCache.slope();
          int width = 2;
          for (int index2 = 0; index2 < 8; ++index2)
          {
            int num8 = index2 * -2;
            int height = 16 /*0x10*/ - index2 * 2;
            int num9 = 16 /*0x10*/ - height;
            int x;
            switch (num7)
            {
              case 1:
                num8 = 0;
                x = index2 * 2;
                height = 14 - index2 * 2;
                num9 = 0;
                break;
              case 2:
                num8 = 0;
                x = 16 /*0x10*/ - index2 * 2 - 2;
                height = 14 - index2 * 2;
                num9 = 0;
                break;
              case 3:
                x = index2 * 2;
                break;
              default:
                x = 16 /*0x10*/ - index2 * 2 - 2;
                break;
            }
            Main.tileBatch.Draw(drawData.drawTexture, vector2 + new Vector2((float) x, (float) (index2 * width + num8)), new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX + x, (int) drawData.tileFrameY + drawData.addFrY + num9, width, height)), (VertexColors) colors, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
          }
          int y = num7 > 2 ? 0 : 14;
          Main.tileBatch.Draw(drawData.drawTexture, vector2 + new Vector2(0.0f, (float) y), new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY + y, 16 /*0x10*/, 2)), (VertexColors) colors, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        }
      }
    }
    if (drawData.glowTexture != null)
    {
      if (drawData.typeCache == (ushort) 412)
      {
        int num10 = Main.tileFrame[(int) drawData.typeCache] / 60;
        int num11 = (num10 + 1) % 4;
        float num12 = (float) (Main.tileFrame[(int) drawData.typeCache] % 60) / 60f;
        Rectangle glowSourceRect1 = drawData.glowSourceRect;
        glowSourceRect1.Y += num10 * 18 * 3;
        Rectangle glowSourceRect2 = drawData.glowSourceRect;
        glowSourceRect2.Y += num11 * 18 * 3;
        Vector2 position = new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset;
        Main.tileBatch.Draw(drawData.glowTexture, position, new Rectangle?(glowSourceRect1), (VertexColors) (drawData.glowColor * (1f - num12)), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        Main.tileBatch.Draw(drawData.glowTexture, position, new Rectangle?(glowSourceRect2), (VertexColors) (drawData.glowColor * num12), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
      }
      else
      {
        Vector2 position = new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset;
        if (TileID.Sets.Platforms[(int) drawData.typeCache])
          position = vector2;
        Main.tileBatch.SetLayer(TileDrawing.Layer_Tiles, (ushort) 1);
        Main.tileBatch.Draw(drawData.glowTexture, position, new Rectangle?(drawData.glowSourceRect), (VertexColors) drawData.glowColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        if (TileID.Sets.Platforms[(int) drawData.typeCache] && drawData.tileCache.slope() != (byte) 0)
        {
          Tile tile1 = Main.tile[tileX, tileY + 1];
          Tile tile2 = Main.tile[tileX - 1, tileY + 1];
          Tile tile3 = Main.tile[tileX + 1, tileY + 1];
          bool showInvisibleBlocks = this._shouldShowInvisibleBlocks;
          if (drawData.tileCache.slope() == (byte) 1 && tile3.active() && (showInvisibleBlocks || !tile3.invisibleBlock()) && Main.tileSolid[(int) tile3.type] && tile3.slope() != (byte) 2 && !tile3.halfBrick() && (!tile1.active() || !showInvisibleBlocks && tile1.invisibleBlock() || tile1.blockType() != 0 && tile1.blockType() != 5 || !TileID.Sets.BlocksStairs[(int) tile1.type]))
          {
            Rectangle glowSourceRect = drawData.glowSourceRect with
            {
              X = !TileID.Sets.Platforms[(int) tile3.type] || tile3.slope() != (byte) 0 ? 198 : 324
            };
            Main.tileBatch.SetLayer(TileDrawing.Layer_BehindTiles, (ushort) 1);
            Main.tileBatch.Draw(drawData.glowTexture, position + new Vector2(0.0f, 16f), new Rectangle?(glowSourceRect), (VertexColors) drawData.glowColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
          }
          else if (drawData.tileCache.slope() == (byte) 2 && tile2.active() && (showInvisibleBlocks || !tile2.invisibleBlock()) && Main.tileSolid[(int) tile2.type] && tile2.slope() != (byte) 1 && !tile2.halfBrick() && (!tile1.active() || !showInvisibleBlocks && tile1.invisibleBlock() || tile1.blockType() != 0 && tile1.blockType() != 4 || !TileID.Sets.BlocksStairs[(int) tile1.type]))
          {
            Rectangle glowSourceRect = drawData.glowSourceRect with
            {
              X = !TileID.Sets.Platforms[(int) tile2.type] || tile2.slope() != (byte) 0 ? 162 : 306
            };
            Main.tileBatch.SetLayer(TileDrawing.Layer_BehindTiles, (ushort) 1);
            Main.tileBatch.Draw(drawData.glowTexture, position + new Vector2(0.0f, 16f), new Rectangle?(glowSourceRect), (VertexColors) drawData.glowColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
          }
        }
      }
    }
    if (highlightTexture == null)
      return;
    rectangle = new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight);
    int num13 = 0;
    int num14 = 0;
    Main.tileBatch.Draw(highlightTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + (float) num13, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop + num14)) + screenOffset, new Rectangle?(rectangle), (VertexColors) transparent, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
  }

  private bool IsVisible(Tile tile)
  {
    bool flag = tile.invisibleBlock();
    switch (tile.type)
    {
      case 19:
        if ((int) tile.frameY / 18 == 48 /*0x30*/)
        {
          flag = true;
          break;
        }
        break;
      case 541:
      case 631:
        flag = true;
        break;
    }
    return !flag || this._shouldShowInvisibleBlocks;
  }

  public Texture2D GetTileDrawTexture(Tile tile, int tileX, int tileY)
  {
    TilePaintSystemV2.TileVariationkey key = new TilePaintSystemV2.TileVariationkey()
    {
      TileType = (int) tile.type,
      TileStyle = 0,
      PaintColor = (int) tile.color()
    };
    switch (tile.type)
    {
      case 5:
        key.TileStyle = TileDrawing.GetTreeBiome(tileX, tileY, (int) tile.frameX, (int) tile.frameY);
        break;
      case 83:
        if (WorldGen.IsAlchemyPlantHarvestable((int) tile.frameX / 18, tileY))
        {
          key.TileType = 84;
          break;
        }
        break;
      case 323:
        key.TileStyle = this.GetPalmTreeBiome(tileX, tileY);
        break;
    }
    return this.GetTileDrawTexture(key);
  }

  public Texture2D GetTileDrawTexture(int tileType, int paintColor)
  {
    return this.GetTileDrawTexture(new TilePaintSystemV2.TileVariationkey()
    {
      TileType = tileType,
      PaintColor = paintColor
    });
  }

  public Texture2D GetTileDrawTexture(TilePaintSystemV2.TileVariationkey key)
  {
    if (this._lastPaintLookupKey == key)
      return this._lastPaintLookupTexture;
    this._lastPaintLookupKey = key;
    this._lastPaintLookupTexture = this.LookupTileDrawTexture(key);
    return this._lastPaintLookupTexture;
  }

  private Texture2D LookupTileDrawTexture(TilePaintSystemV2.TileVariationkey key)
  {
    Main.instance.LoadTiles(key.TileType);
    if (key.PaintColor != 0 || key.TileStyle != 0)
    {
      Texture2D requestIfNotReady = this._paintSystem.TryGetTileAndRequestIfNotReady(key.TileType, key.TileStyle, key.PaintColor);
      if (requestIfNotReady != null)
        return requestIfNotReady;
    }
    return TextureAssets.Tile[key.TileType].Value;
  }

  private Texture2D LookupCageTopDrawTexture(TilePaintSystemV2.CageTopVariationkey key)
  {
    if (key.PaintColor != 0)
    {
      Texture2D requestIfNotReady = this._paintSystem.TryGetCageTopAndRequestIfNotReady(key.CageStyle, key.PaintColor);
      if (requestIfNotReady != null)
        return requestIfNotReady;
    }
    return TextureAssets.CageTop[key.CageStyle].Value;
  }

  private void DrawBasicTile(
    Vector2 screenPosition,
    Vector2 screenOffset,
    int tileX,
    int tileY,
    TileDrawInfo drawData,
    Rectangle normalTileRect,
    Vector2 normalTilePosition)
  {
    bool flag1 = !TileID.Sets.DontDrawTileSliced[(int) drawData.tileCache.type];
    bool flag2 = !TileID.Sets.DontDrawTileSlopes[(int) drawData.tileCache.type];
    if (drawData.typeCache == (ushort) 380 || TileID.Sets.Platforms[(int) drawData.typeCache])
      this.DrawTile_BackRope(screenPosition, screenOffset, tileX, tileY, drawData);
    if (flag2 && drawData.tileCache.slope() > (byte) 0)
    {
      if (TileID.Sets.Platforms[(int) drawData.tileCache.type])
      {
        Tile tile1 = Main.tile[tileX, tileY + 1];
        Tile tile2 = Main.tile[tileX - 1, tileY + 1];
        Tile tile3 = Main.tile[tileX + 1, tileY + 1];
        bool showInvisibleBlocks = this._shouldShowInvisibleBlocks;
        Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition, new Rectangle?(normalTileRect), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        if (drawData.tileCache.slope() == (byte) 1 && tile3.active() && (showInvisibleBlocks || !tile3.invisibleBlock()) && Main.tileSolid[(int) tile3.type] && tile3.slope() != (byte) 2 && !tile3.halfBrick() && (!tile1.active() || !showInvisibleBlocks && tile1.invisibleBlock() || tile1.blockType() != 0 && tile1.blockType() != 5 || !TileID.Sets.BlocksStairs[(int) tile1.type]))
        {
          Main.tileBatch.SetLayer(TileDrawing.Layer_BehindTiles);
          Rectangle rectangle = new Rectangle(198, (int) drawData.tileFrameY, 16 /*0x10*/, 16 /*0x10*/);
          if (TileID.Sets.Platforms[(int) tile3.type] && tile3.slope() == (byte) 0)
            rectangle.X = 324;
          Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition + new Vector2(0.0f, 16f), new Rectangle?(rectangle), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        }
        else
        {
          if (drawData.tileCache.slope() != (byte) 2 || !tile2.active() || !showInvisibleBlocks && tile2.invisibleBlock() || !Main.tileSolid[(int) tile2.type] || tile2.slope() == (byte) 1 || tile2.halfBrick() || tile1.active() && (showInvisibleBlocks || !tile1.invisibleBlock()) && (tile1.blockType() == 0 || tile1.blockType() == 4) && TileID.Sets.BlocksStairs[(int) tile1.type])
            return;
          Main.tileBatch.SetLayer(TileDrawing.Layer_BehindTiles);
          Rectangle rectangle = new Rectangle(162, (int) drawData.tileFrameY, 16 /*0x10*/, 16 /*0x10*/);
          if (TileID.Sets.Platforms[(int) tile2.type] && tile2.slope() == (byte) 0)
            rectangle.X = 306;
          Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition + new Vector2(0.0f, 16f), new Rectangle?(rectangle), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        }
      }
      else if (TileID.Sets.HasSlopeFrames[(int) drawData.tileCache.type])
      {
        Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, 16 /*0x10*/, 16 /*0x10*/)), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
      }
      else
      {
        int num1 = (int) drawData.tileCache.slope();
        int width = 2;
        for (int index = 0; index < 8; ++index)
        {
          int num2 = index * -2;
          int height = 16 /*0x10*/ - index * 2;
          int num3 = 16 /*0x10*/ - height;
          int x;
          switch (num1)
          {
            case 1:
              num2 = 0;
              x = index * 2;
              height = 14 - index * 2;
              num3 = 0;
              break;
            case 2:
              num2 = 0;
              x = 16 /*0x10*/ - index * 2 - 2;
              height = 14 - index * 2;
              num3 = 0;
              break;
            case 3:
              x = index * 2;
              break;
            default:
              x = 16 /*0x10*/ - index * 2 - 2;
              break;
          }
          Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition + new Vector2((float) x, (float) (index * width + num2)), new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX + x, (int) drawData.tileFrameY + drawData.addFrY + num3, width, height)), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        }
        int y = num1 > 2 ? 0 : 14;
        Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition + new Vector2(0.0f, (float) y), new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY + y, 16 /*0x10*/, 2)), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
      }
    }
    else if (flag2 && !TileID.Sets.Platforms[(int) drawData.typeCache] && !TileID.Sets.IgnoresNearbyHalfbricksWhenDrawn[(int) drawData.typeCache] && this._tileSolid[(int) drawData.typeCache] && !TileID.Sets.NotReallySolid[(int) drawData.typeCache] && !drawData.tileCache.halfBrick() && (Main.tile[tileX - 1, tileY].halfBrick() || Main.tile[tileX + 1, tileY].halfBrick()))
    {
      if (Main.tile[tileX - 1, tileY].halfBrick() && Main.tile[tileX + 1, tileY].halfBrick())
      {
        Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition + new Vector2(0.0f, 8f), new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, drawData.addFrY + (int) drawData.tileFrameY + 8, drawData.tileWidth, 8)), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        Rectangle rectangle = new Rectangle(126 + drawData.addFrX, drawData.addFrY, 16 /*0x10*/, 8);
        if (Main.tile[tileX, tileY - 1].active() && !Main.tile[tileX, tileY - 1].bottomSlope() && (int) Main.tile[tileX, tileY - 1].type == (int) drawData.typeCache)
          rectangle = new Rectangle(90 + drawData.addFrX, drawData.addFrY, 16 /*0x10*/, 8);
        Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition, new Rectangle?(rectangle), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
      }
      else if (Main.tile[tileX - 1, tileY].halfBrick())
      {
        int num = 4;
        if (TileID.Sets.AllBlocksWithSmoothBordersToResolveHalfBlockIssue[(int) drawData.typeCache])
          num = 2;
        Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition + new Vector2(0.0f, 8f), new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, drawData.addFrY + (int) drawData.tileFrameY + 8, drawData.tileWidth, 8)), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition + new Vector2((float) num, 0.0f), new Rectangle?(new Rectangle((int) drawData.tileFrameX + num + drawData.addFrX, drawData.addFrY + (int) drawData.tileFrameY, drawData.tileWidth - num, drawData.tileHeight)), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition, new Rectangle?(new Rectangle(144 /*0x90*/ + drawData.addFrX, drawData.addFrY, num, 8)), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        if (num != 2)
          return;
        Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition, new Rectangle?(new Rectangle(148 + drawData.addFrX, drawData.addFrY, 2, 2)), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
      }
      else
      {
        if (!Main.tile[tileX + 1, tileY].halfBrick())
          return;
        int width = 4;
        if (TileID.Sets.AllBlocksWithSmoothBordersToResolveHalfBlockIssue[(int) drawData.typeCache])
          width = 2;
        Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition + new Vector2(0.0f, 8f), new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, drawData.addFrY + (int) drawData.tileFrameY + 8, drawData.tileWidth, 8)), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, drawData.addFrY + (int) drawData.tileFrameY, drawData.tileWidth - width, drawData.tileHeight)), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition + new Vector2((float) (16 /*0x10*/ - width), 0.0f), new Rectangle?(new Rectangle(144 /*0x90*/ + (16 /*0x10*/ - width), 0, width, 8)), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        if (width != 2)
          return;
        Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition + new Vector2(14f, 0.0f), new Rectangle?(new Rectangle(156, 0, 2, 2)), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
      }
    }
    else if (flag1 && Lighting.NotRetro && this._tileSolid[(int) drawData.typeCache] && !drawData.tileCache.halfBrick())
    {
      this.DrawSingleTile_SlicedBlock(normalTilePosition, tileX, tileY, drawData);
    }
    else
    {
      if (drawData.halfBrickHeight == 8 && (!Main.tile[tileX, tileY + 1].active() || !this._tileSolid[(int) Main.tile[tileX, tileY + 1].type] || Main.tile[tileX, tileY + 1].halfBrick()))
      {
        if (TileID.Sets.Platforms[(int) drawData.typeCache])
        {
          Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition, new Rectangle?(normalTileRect), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        }
        else
        {
          Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition, new Rectangle?(normalTileRect.Modified(0, 0, 0, -4)), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
          Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition + new Vector2(0.0f, 4f), new Rectangle?(new Rectangle(144 /*0x90*/ + drawData.addFrX, 66 + drawData.addFrY, drawData.tileWidth, 4)), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        }
      }
      else if (TileID.Sets.CritterCageLidStyle[(int) drawData.typeCache] >= 0)
      {
        int num = TileID.Sets.CritterCageLidStyle[(int) drawData.typeCache];
        if (num < 3 && normalTileRect.Y % 54 == 0 || num >= 3 && normalTileRect.Y % 36 == 0)
        {
          Vector2 position1 = normalTilePosition;
          position1.Y += 8f;
          Rectangle rectangle1 = normalTileRect;
          rectangle1.Y += 8;
          rectangle1.Height -= 8;
          Main.tileBatch.Draw(drawData.drawTexture, position1, new Rectangle?(rectangle1), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
          Vector2 position2 = normalTilePosition;
          position2.Y -= 2f;
          Rectangle rectangle2 = normalTileRect;
          if (num == 0)
            rectangle2.X = normalTileRect.X % 108;
          rectangle2.Y = 0;
          rectangle2.Height = 10;
          Texture2D texture = this.LookupCageTopDrawTexture(new TilePaintSystemV2.CageTopVariationkey()
          {
            CageStyle = num,
            PaintColor = (int) drawData.tileCache.color()
          });
          Main.tileBatch.Draw(texture, position2, new Rectangle?(rectangle2), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        }
        else
          Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition, new Rectangle?(normalTileRect), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
      }
      else if (drawData.typeCache == (ushort) 711)
      {
        Rectangle rectangle3 = new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight);
        if (normalTileRect.X == 0 && normalTileRect.Y == 0)
        {
          Rectangle rectangle4 = rectangle3;
          rectangle4.X += 38;
          for (float num4 = 0.0f; (double) num4 < 1.0; num4 += 0.333333343f)
          {
            float num5 = (float) ((double) Main.GlobalTimeWrappedHourly % 2.0 / 2.0);
            Color colors = Main.hslToRgb((float) (((double) num5 + (double) num4) % 1.0), 1f, 0.5f) with
            {
              A = (byte) 0
            } * 0.3f;
            for (int index1 = 0; index1 < 2; ++index1)
            {
              rectangle4.Width = index1 != 1 ? rectangle3.Width : rectangle3.Width + 2;
              for (int index2 = 0; index2 < 2; ++index2)
              {
                rectangle4.Height = index2 != 1 ? rectangle3.Height : rectangle3.Height + 2;
                Main.tileBatch.Draw(drawData.drawTexture, (normalTilePosition + new Vector2((float) (index1 * 16 /*0x10*/), (float) (index2 * 16 /*0x10*/)) + ((float) (((double) num5 + (double) num4) * 6.2831854820251465)).ToRotationVector2() * 4f).Floor(), new Rectangle?(new Rectangle(rectangle4.X + index1 * 18, rectangle4.Y + index2 * 18, rectangle4.Width, rectangle4.Height)), (VertexColors) colors, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
            }
          }
        }
        Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition, new Rectangle?(rectangle3), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
      }
      else
        Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition, new Rectangle?(normalTileRect), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
      this.DrawSingleTile_Flames(screenPosition, screenOffset, tileX, tileY, drawData);
    }
  }

  private int GetPalmTreeBiome(int tileX, int tileY)
  {
    int x = tileX;
    int y = tileY;
    while (Main.tile[x, y].active() && Main.tile[x, y].type == (ushort) 323)
      ++y;
    return this.GetPalmTreeVariant(x, y);
  }

  private static int GetTreeBiome(int tileX, int tileY, int tileFrameX, int tileFrameY)
  {
    int x = tileX;
    int y = tileY;
    int type = (int) Main.tile[x, y].type;
    if (tileFrameX == 66 && tileFrameY <= 45)
      ++x;
    if (tileFrameX == 88 && tileFrameY >= 66 && tileFrameY <= 110)
      --x;
    if (tileFrameY >= 198)
    {
      switch (tileFrameX)
      {
        case 44:
          ++x;
          break;
        case 66:
          --x;
          break;
      }
    }
    else if (tileFrameY >= 132)
    {
      switch (tileFrameX)
      {
        case 22:
          --x;
          break;
        case 44:
          ++x;
          break;
      }
    }
    while (Main.tile[x, y].active() && (int) Main.tile[x, y].type == type)
      ++y;
    return TileDrawing.GetTreeVariant(x, y);
  }

  public static int GetTreeVariant(int x, int y)
  {
    if (Main.tile[x, y] == null || !Main.tile[x, y].active())
      return -1;
    switch (Main.tile[x, y].type)
    {
      case 23:
      case 661:
        return 0;
      case 60:
        return (double) y <= Main.worldSurface ? 1 : 5;
      case 70:
        return 6;
      case 109:
      case 492:
        return 2;
      case 147:
        return 3;
      case 199:
      case 662:
        return 4;
      default:
        return -1;
    }
  }

  private Color GetFallenStarFurnitureFlameColor()
  {
    int num = (int) (150.0 * (double) Utils.WrappedLerp(0.5f, 1f, Main.GlobalTimeWrappedHourly % 2f / 2f));
    return new Color(150, num, num, 50);
  }

  private Color GetHallowedFurnitureFlameColor()
  {
    int num = (int) (170.0 * (double) Utils.WrappedLerp(0.5f, 1f, Main.GlobalTimeWrappedHourly % 2f / 2f));
    return new Color(170, num, num, 75);
  }

  private Color GetCloudFurnitureFlameColor()
  {
    return this.GetWrappedFurnitureFlameColor(new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0));
  }

  private Color GetLibrarianFurnitureFlameColor()
  {
    return this.GetWrappedFurnitureFlameColor(new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0), 0.25f);
  }

  private Color GetForbiddenFurnitureFlameColor()
  {
    return this.GetWrappedFurnitureFlameColor(new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0), 0.25f);
  }

  private Color GetBoulderFurnitureFlameColor()
  {
    return this.GetWrappedFurnitureFlameColor(new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0), 0.25f);
  }

  private Color GetWrappedFurnitureFlameColor(Color baseColor, float min = 0.75f, float max = 1f)
  {
    float num = Utils.WrappedLerp(min, max, Main.GlobalTimeWrappedHourly % 2f / 2f);
    return baseColor * num;
  }

  private TileDrawing.TileFlameData GetTileFlameData(
    int tileX,
    int tileY,
    int type,
    int tileFrameY)
  {
    switch (type)
    {
      case 270:
        return new TileDrawing.TileFlameData()
        {
          flameTexture = TextureAssets.FireflyJar.Value,
          flameColor = new Color(200, 200, 200, 0),
          flameCount = 1
        };
      case 271:
        return new TileDrawing.TileFlameData()
        {
          flameTexture = TextureAssets.LightningbugJar.Value,
          flameColor = new Color(200, 200, 200, 0),
          flameCount = 1
        };
      case 581:
        return new TileDrawing.TileFlameData()
        {
          flameTexture = TextureAssets.GlowMask[291].Value,
          flameColor = new Color(200, 100, 100, 0),
          flameCount = 1
        };
      default:
        if (!Main.tileFlame[type])
          return new TileDrawing.TileFlameData();
        ulong num1 = Main.TileFrameSeed ^ ((ulong) tileX << 32 /*0x20*/ | (ulong) (uint) tileY);
        int index = 0;
        switch (type)
        {
          case 4:
            index = 0;
            break;
          case 33:
          case 174:
            index = 1;
            break;
          case 34:
            index = 3;
            break;
          case 35:
            index = 7;
            break;
          case 42:
            index = 13;
            break;
          case 49:
            index = 5;
            break;
          case 93:
            index = 4;
            break;
          case 98:
            index = 6;
            break;
          case 100:
          case 173:
            index = 2;
            break;
          case 372:
            index = 16 /*0x10*/;
            break;
          case 646:
            index = 17;
            break;
        }
        TileDrawing.TileFlameData tileFlameData = new TileDrawing.TileFlameData()
        {
          flameTexture = TextureAssets.Flames[index].Value,
          flameSeed = num1
        };
        switch (index)
        {
          case 1:
            switch ((int) Main.tile[tileX, tileY].frameY / 22)
            {
              case 5:
              case 6:
              case 7:
              case 10:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.075f;
                tileFlameData.flameRangeMultY = 0.075f;
                break;
              case 8:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.3f;
                tileFlameData.flameRangeMultY = 0.3f;
                break;
              case 12:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.1f;
                tileFlameData.flameRangeMultY = 0.15f;
                break;
              case 14:
                tileFlameData.flameCount = 8;
                tileFlameData.flameColor = new Color(75, 75, 75, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.1f;
                tileFlameData.flameRangeMultY = 0.1f;
                break;
              case 16 /*0x10*/:
                tileFlameData.flameCount = 4;
                tileFlameData.flameColor = new Color(75, 75, 75, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.15f;
                tileFlameData.flameRangeMultY = 0.15f;
                break;
              case 27:
              case 28:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = new Color(75, 75, 75, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 43:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetFallenStarFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 44:
                tileFlameData.flameCount = 3;
                tileFlameData.flameColor = new Color(200, 200, 200, 150);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.15f;
                tileFlameData.flameRangeMultY = 0.35f;
                break;
              case 45:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetHallowedFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 47:
              case 48 /*0x30*/:
              case 49:
              case 51:
              case 52:
              case 54:
                tileFlameData.flameCount = 0;
                break;
              case 56:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetCloudFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 57:
              case 60:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = new Color(200, 200, 200, 150);
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 58:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetLibrarianFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 61:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetForbiddenFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 63 /*0x3F*/:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetBoulderFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              default:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(100, 100, 100, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.15f;
                tileFlameData.flameRangeMultY = 0.35f;
                break;
            }
            break;
          case 2:
            switch ((int) Main.tile[tileX, tileY].frameY / 36)
            {
              case 3:
                tileFlameData.flameCount = 3;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.05f;
                tileFlameData.flameRangeMultY = 0.15f;
                break;
              case 6:
                tileFlameData.flameCount = 5;
                tileFlameData.flameColor = new Color(75, 75, 75, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.15f;
                tileFlameData.flameRangeMultY = 0.15f;
                break;
              case 9:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(100, 100, 100, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.3f;
                tileFlameData.flameRangeMultY = 0.3f;
                break;
              case 11:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.1f;
                tileFlameData.flameRangeMultY = 0.15f;
                break;
              case 13:
                tileFlameData.flameCount = 8;
                tileFlameData.flameColor = new Color(75, 75, 75, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.1f;
                tileFlameData.flameRangeMultY = 0.1f;
                break;
              case 28:
              case 29:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = new Color(75, 75, 75, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 44:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetFallenStarFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 45:
                tileFlameData.flameCount = 3;
                tileFlameData.flameColor = new Color(200, 200, 200, 150);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.15f;
                tileFlameData.flameRangeMultY = 0.35f;
                break;
              case 46:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetHallowedFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 48 /*0x30*/:
              case 49:
              case 50:
              case 52:
              case 53:
              case 55:
                tileFlameData.flameCount = 0;
                break;
              case 57:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetCloudFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 58:
              case 61:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = new Color(200, 200, 200, 150);
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 59:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetLibrarianFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 62:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetForbiddenFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 64 /*0x40*/:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetBoulderFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              default:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(100, 100, 100, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.15f;
                tileFlameData.flameRangeMultY = 0.35f;
                break;
            }
            break;
          case 3:
            int num2 = (int) Main.tile[tileX, tileY].frameY / 54;
            if (Main.tile[tileX, tileY].frameX >= (short) 108)
              num2 += 37 * ((int) Main.tile[tileX, tileY].frameX / 108);
            switch (num2)
            {
              case 8:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.075f;
                tileFlameData.flameRangeMultY = 0.075f;
                break;
              case 9:
                tileFlameData.flameCount = 3;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -1;
                tileFlameData.flameRangeXMax = 1;
                tileFlameData.flameRangeYMin = -1;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 2f;
                tileFlameData.flameRangeMultY = 2f;
                break;
              case 11:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.3f;
                tileFlameData.flameRangeMultY = 0.3f;
                break;
              case 15:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.1f;
                tileFlameData.flameRangeMultY = 0.15f;
                break;
              case 17:
              case 20:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.075f;
                tileFlameData.flameRangeMultY = 0.075f;
                break;
              case 18:
                tileFlameData.flameCount = 8;
                tileFlameData.flameColor = new Color(75, 75, 75, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.1f;
                tileFlameData.flameRangeMultY = 0.1f;
                break;
              case 34:
              case 35:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = new Color(75, 75, 75, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 50:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetFallenStarFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 51:
                tileFlameData.flameCount = 3;
                tileFlameData.flameColor = new Color(200, 200, 200, 150);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.15f;
                tileFlameData.flameRangeMultY = 0.35f;
                break;
              case 52:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetHallowedFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 54:
              case 55:
              case 56:
              case 58:
              case 59:
              case 61:
                tileFlameData.flameCount = 0;
                break;
              case 63 /*0x3F*/:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetCloudFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 64 /*0x40*/:
              case 67:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = new Color(200, 200, 200, 150);
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 65:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetLibrarianFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 68:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetForbiddenFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 70:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetBoulderFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              default:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(100, 100, 100, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.15f;
                tileFlameData.flameRangeMultY = 0.35f;
                break;
            }
            break;
          case 4:
            switch ((int) Main.tile[tileX, tileY].frameY / 54)
            {
              case 1:
                tileFlameData.flameCount = 3;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.15f;
                tileFlameData.flameRangeMultY = 0.15f;
                break;
              case 2:
              case 4:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.075f;
                tileFlameData.flameRangeMultY = 0.075f;
                break;
              case 3:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(100, 100, 100, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -20;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.2f;
                tileFlameData.flameRangeMultY = 0.35f;
                break;
              case 5:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.3f;
                tileFlameData.flameRangeMultY = 0.3f;
                break;
              case 9:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.1f;
                tileFlameData.flameRangeMultY = 0.15f;
                break;
              case 12:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = new Color(100, 100, 100, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.01f;
                tileFlameData.flameRangeMultY = 0.01f;
                break;
              case 13:
                tileFlameData.flameCount = 8;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.1f;
                tileFlameData.flameRangeMultY = 0.1f;
                break;
              case 28:
              case 29:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = new Color(75, 75, 75, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 44:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetFallenStarFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 45:
                tileFlameData.flameCount = 3;
                tileFlameData.flameColor = new Color(200, 200, 200, 150);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.15f;
                tileFlameData.flameRangeMultY = 0.35f;
                break;
              case 46:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetHallowedFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 48 /*0x30*/:
              case 49:
              case 50:
              case 52:
              case 53:
              case 55:
                tileFlameData.flameCount = 0;
                break;
              case 57:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetCloudFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 58:
              case 61:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = new Color(200, 200, 200, 150);
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 59:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetLibrarianFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 62:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetForbiddenFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 64 /*0x40*/:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetBoulderFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              default:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(100, 100, 100, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.15f;
                tileFlameData.flameRangeMultY = 0.35f;
                break;
            }
            break;
          case 7:
            tileFlameData.flameCount = 4;
            tileFlameData.flameColor = new Color(50, 50, 50, 0);
            tileFlameData.flameRangeXMin = -10;
            tileFlameData.flameRangeXMax = 11;
            tileFlameData.flameRangeYMin = -10;
            tileFlameData.flameRangeYMax = 10;
            tileFlameData.flameRangeMultX = 0.0f;
            tileFlameData.flameRangeMultY = 0.0f;
            break;
          case 13:
            switch (tileFrameY / 36)
            {
              case 1:
              case 3:
              case 6:
              case 8:
              case 19:
              case 27:
              case 29:
              case 30:
              case 31 /*0x1F*/:
              case 32 /*0x20*/:
              case 36:
              case 39:
              case 53:
              case 57:
              case 60:
              case 62:
              case 66:
              case 69:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(100, 100, 100, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.15f;
                tileFlameData.flameRangeMultY = 0.35f;
                break;
              case 2:
              case 16 /*0x10*/:
              case 25:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.15f;
                tileFlameData.flameRangeMultY = 0.1f;
                break;
              case 11:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(50, 50, 50, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 11;
                tileFlameData.flameRangeMultX = 0.075f;
                tileFlameData.flameRangeMultY = 0.075f;
                break;
              case 34:
              case 35:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = new Color(75, 75, 75, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 44:
                tileFlameData.flameCount = 7;
                tileFlameData.flameColor = new Color(100, 100, 100, 0);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.15f;
                tileFlameData.flameRangeMultY = 0.35f;
                break;
              case 50:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetFallenStarFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 51:
                tileFlameData.flameCount = 3;
                tileFlameData.flameColor = new Color(200, 200, 200, 150);
                tileFlameData.flameRangeXMin = -10;
                tileFlameData.flameRangeXMax = 11;
                tileFlameData.flameRangeYMin = -10;
                tileFlameData.flameRangeYMax = 1;
                tileFlameData.flameRangeMultX = 0.15f;
                tileFlameData.flameRangeMultY = 0.35f;
                break;
              case 52:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetHallowedFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 54:
              case 55:
              case 56:
              case 58:
              case 59:
              case 61:
                tileFlameData.flameCount = 0;
                break;
              case 63 /*0x3F*/:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetCloudFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 64 /*0x40*/:
              case 67:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = new Color(200, 200, 200, 150);
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 65:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetLibrarianFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 68:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetForbiddenFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              case 70:
                tileFlameData.flameCount = 1;
                tileFlameData.flameColor = this.GetBoulderFurnitureFlameColor();
                tileFlameData.flameRangeMultX = 0.0f;
                tileFlameData.flameRangeMultY = 0.0f;
                break;
              default:
                tileFlameData.flameCount = 0;
                break;
            }
            break;
          default:
            tileFlameData.flameCount = 7;
            tileFlameData.flameColor = new Color(100, 100, 100, 0);
            if (tileFrameY / 22 == 14)
              tileFlameData.flameColor = new Color((float) Main.DiscoR / (float) byte.MaxValue, (float) Main.DiscoG / (float) byte.MaxValue, (float) Main.DiscoB / (float) byte.MaxValue, 0.0f);
            tileFlameData.flameRangeXMin = -10;
            tileFlameData.flameRangeXMax = 11;
            tileFlameData.flameRangeYMin = -10;
            tileFlameData.flameRangeYMax = 1;
            tileFlameData.flameRangeMultX = 0.15f;
            tileFlameData.flameRangeMultY = 0.35f;
            break;
        }
        return tileFlameData;
    }
  }

  private void DrawSingleTile_Flames(
    Vector2 screenPosition,
    Vector2 screenOffset,
    int tileX,
    int tileY,
    TileDrawInfo drawData)
  {
    if (drawData.typeCache == (ushort) 548 && (int) drawData.tileFrameX / 54 > 6)
      Main.tileBatch.Draw(TextureAssets.GlowMask[297].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) Color.White, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    if (drawData.typeCache == (ushort) 613)
      Main.tileBatch.Draw(TextureAssets.GlowMask[298].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) Color.White, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    if (drawData.typeCache == (ushort) 614)
      Main.tileBatch.Draw(TextureAssets.GlowMask[299].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) Color.White, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    if (drawData.typeCache == (ushort) 593)
      Main.tileBatch.Draw(TextureAssets.GlowMask[295].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) Color.White, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    if (drawData.typeCache == (ushort) 594)
      Main.tileBatch.Draw(TextureAssets.GlowMask[296].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) Color.White, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    if (drawData.typeCache == (ushort) 215 && drawData.tileFrameY < (short) 36)
    {
      int index = 15;
      Color colors = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
      switch ((int) drawData.tileFrameX / 54)
      {
        case 5:
          colors = new Color((float) Main.DiscoR / (float) byte.MaxValue, (float) Main.DiscoG / (float) byte.MaxValue, (float) Main.DiscoB / (float) byte.MaxValue, 0.0f);
          break;
        case 14:
          colors = new Color(50, 50, 100, 20);
          break;
        case 15:
          colors = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 200);
          break;
      }
      Main.tileBatch.Draw(TextureAssets.Flames[index].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) colors, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    }
    if (drawData.typeCache == (ushort) 85)
    {
      float graveyardVisualIntensity = Main.GraveyardVisualIntensity;
      if ((double) graveyardVisualIntensity > 0.0)
      {
        ulong num1 = Main.TileFrameSeed ^ ((ulong) tileX << 32 /*0x20*/ | (ulong) (uint) tileY);
        TileDrawing.TileFlameData tileFlameData = this.GetTileFlameData(tileX, tileY, (int) drawData.typeCache, (int) drawData.tileFrameY);
        if (num1 == 0UL)
          num1 = tileFlameData.flameSeed;
        tileFlameData.flameSeed = num1;
        Vector2 position = new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset;
        Rectangle rectangle = new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight);
        for (int index = 0; index < tileFlameData.flameCount; ++index)
        {
          Color colors = tileFlameData.flameColor * graveyardVisualIntensity;
          float x = (float) Utils.RandomInt(ref tileFlameData.flameSeed, tileFlameData.flameRangeXMin, tileFlameData.flameRangeXMax) * tileFlameData.flameRangeMultX;
          float y = (float) Utils.RandomInt(ref tileFlameData.flameSeed, tileFlameData.flameRangeYMin, tileFlameData.flameRangeYMax) * tileFlameData.flameRangeMultY;
          for (float num2 = 0.0f; (double) num2 < 1.0; num2 += 0.25f)
            Main.tileBatch.Draw(tileFlameData.flameTexture, position + new Vector2(x, y) + Vector2.UnitX.RotatedBy((double) num2 * 6.2831854820251465) * 2f, new Rectangle?(rectangle), (VertexColors) colors, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
          Main.tileBatch.Draw(tileFlameData.flameTexture, position, new Rectangle?(rectangle), (VertexColors) (Color.White * graveyardVisualIntensity), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
        }
      }
    }
    if (drawData.typeCache == (ushort) 356 && Main.sundialCooldown == 0)
    {
      Texture2D texture = TextureAssets.GlowMask[325].Value;
      Rectangle rectangle = new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight);
      Color colors = new Color(100, 100, 100, 0);
      int num3 = tileX - (int) drawData.tileFrameX / 18;
      int num4 = tileY - (int) drawData.tileFrameY / 18;
      ulong seed = Main.TileFrameSeed ^ ((ulong) num3 << 32 /*0x20*/ | (ulong) (uint) num4);
      for (int index = 0; index < 7; ++index)
      {
        float num5 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
        float num6 = (float) Utils.RandomInt(ref seed, -10, 1) * 0.35f;
        Main.tileBatch.Draw(texture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num5, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num6) + screenOffset, new Rectangle?(rectangle), (VertexColors) colors, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
      }
    }
    if (drawData.typeCache == (ushort) 663 && Main.moondialCooldown == 0)
    {
      Texture2D texture = TextureAssets.GlowMask[335].Value;
      Rectangle rectangle = new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight);
      rectangle.Y += 54 * Main.moonPhase;
      Main.tileBatch.Draw(texture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(rectangle), (VertexColors) (Color.White * ((float) Main.mouseTextColor / (float) byte.MaxValue)), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    }
    if (drawData.typeCache == (ushort) 286)
      Main.tileBatch.Draw(TextureAssets.GlowSnail.Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(75, 100, (int) byte.MaxValue, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    if (drawData.typeCache == (ushort) 582)
      Main.tileBatch.Draw(TextureAssets.GlowMask[293].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(200, 100, 100, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    if (drawData.typeCache == (ushort) 391)
      Main.tileBatch.Draw(TextureAssets.GlowMask[131].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(250, 250, 250, 200), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    if (drawData.typeCache == (ushort) 619)
      Main.tileBatch.Draw(TextureAssets.GlowMask[300].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(75, 100, (int) byte.MaxValue, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    if (drawData.typeCache == (ushort) 270)
      Main.tileBatch.Draw(TextureAssets.FireflyJar.Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(200, 200, 200, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    if (drawData.typeCache == (ushort) 271)
      Main.tileBatch.Draw(TextureAssets.LightningbugJar.Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(200, 200, 200, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    if (drawData.typeCache == (ushort) 581)
      Main.tileBatch.Draw(TextureAssets.GlowMask[291].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(200, 200, 200, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    if (drawData.typeCache == (ushort) 316 || drawData.typeCache == (ushort) 317 || drawData.typeCache == (ushort) 318)
      Main.tileBatch.Draw(TextureAssets.JellyfishBowl[(int) drawData.typeCache - 316].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(200, 200, 200, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    if (drawData.typeCache == (ushort) 149 && drawData.tileFrameX < (short) 54)
      Main.tileBatch.Draw(TextureAssets.XmasLight.Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(200, 200, 200, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    if (drawData.typeCache == (ushort) 300 || drawData.typeCache == (ushort) 302 || drawData.typeCache == (ushort) 303 || drawData.typeCache == (ushort) 306)
    {
      int index = 9;
      if (drawData.typeCache == (ushort) 302)
        index = 10;
      if (drawData.typeCache == (ushort) 303)
        index = 11;
      if (drawData.typeCache == (ushort) 306)
        index = 12;
      Main.tileBatch.Draw(TextureAssets.Flames[index].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(200, 200, 200, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    }
    else if (Main.tileFlame[(int) drawData.typeCache])
    {
      ulong seed = Main.TileFrameSeed ^ ((ulong) tileX << 32 /*0x20*/ | (ulong) (uint) tileY);
      int typeCache = (int) drawData.typeCache;
      int index1 = 0;
      switch (typeCache)
      {
        case 4:
          index1 = 0;
          break;
        case 33:
        case 174:
          index1 = 1;
          break;
        case 34:
          index1 = 3;
          break;
        case 35:
          index1 = 7;
          break;
        case 42:
          index1 = 13;
          break;
        case 49:
          index1 = 5;
          break;
        case 93:
          index1 = 4;
          break;
        case 98:
          index1 = 6;
          break;
        case 100:
        case 173:
          index1 = 2;
          break;
        case 372:
          index1 = 16 /*0x10*/;
          break;
        case 646:
          index1 = 17;
          break;
      }
      switch (index1)
      {
        case 1:
          int num7 = (int) Main.tile[tileX, tileY].frameY / 22;
          bool flag1 = num7 >= 44;
          switch (num7)
          {
            case 5:
            case 6:
            case 7:
            case 10:
              for (int index2 = 0; index2 < 7; ++index2)
              {
                float num8 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.075f;
                float num9 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.075f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num8, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num9) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(50, 50, 50, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 8:
              for (int index3 = 0; index3 < 7; ++index3)
              {
                float num10 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.3f;
                float num11 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.3f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num10, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num11) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(50, 50, 50, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 12:
              for (int index4 = 0; index4 < 7; ++index4)
              {
                float num12 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.1f;
                float num13 = (float) Utils.RandomInt(ref seed, -10, 1) * 0.15f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num12, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num13) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(50, 50, 50, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 14:
              for (int index5 = 0; index5 < 8; ++index5)
              {
                float num14 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.1f;
                float num15 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.1f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num14, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num15) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(75, 75, 75, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 16 /*0x10*/:
              for (int index6 = 0; index6 < 4; ++index6)
              {
                float num16 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
                float num17 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num16, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num17) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(75, 75, 75, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 27:
            case 28:
              Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(75, 75, 75, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              break;
            case 43:
              TileDrawing.TileFlameData tileFlameData1 = this.GetTileFlameData(tileX, tileY, (int) drawData.typeCache, (int) drawData.tileFrameY);
              if (seed == 0UL)
                seed = tileFlameData1.flameSeed;
              tileFlameData1.flameSeed = seed;
              for (int index7 = 0; index7 < tileFlameData1.flameCount; ++index7)
              {
                float num18 = (float) Utils.RandomInt(ref tileFlameData1.flameSeed, tileFlameData1.flameRangeXMin, tileFlameData1.flameRangeXMax) * tileFlameData1.flameRangeMultX;
                float num19 = (float) Utils.RandomInt(ref tileFlameData1.flameSeed, tileFlameData1.flameRangeYMin, tileFlameData1.flameRangeYMax) * tileFlameData1.flameRangeMultY;
                Main.tileBatch.Draw(tileFlameData1.flameTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num18, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num19) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) tileFlameData1.flameColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            default:
              if (flag1)
              {
                TileDrawing.TileFlameData tileFlameData2 = this.GetTileFlameData(tileX, tileY, (int) drawData.typeCache, (int) drawData.tileFrameY);
                if (seed == 0UL)
                  seed = tileFlameData2.flameSeed;
                tileFlameData2.flameSeed = seed;
                for (int index8 = 0; index8 < tileFlameData2.flameCount; ++index8)
                {
                  float num20 = (float) Utils.RandomInt(ref tileFlameData2.flameSeed, tileFlameData2.flameRangeXMin, tileFlameData2.flameRangeXMax) * tileFlameData2.flameRangeMultX;
                  float num21 = (float) Utils.RandomInt(ref tileFlameData2.flameSeed, tileFlameData2.flameRangeYMin, tileFlameData2.flameRangeYMax) * tileFlameData2.flameRangeMultY;
                  Main.tileBatch.Draw(tileFlameData2.flameTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num20, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num21) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) tileFlameData2.flameColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
                }
                break;
              }
              for (int index9 = 0; index9 < 7; ++index9)
              {
                float num22 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
                float num23 = (float) Utils.RandomInt(ref seed, -10, 1) * 0.35f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num22, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num23) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(100, 100, 100, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
          }
          break;
        case 2:
          int num24 = (int) Main.tile[tileX, tileY].frameY / 36;
          bool flag2 = num24 >= 45;
          switch (num24)
          {
            case 3:
              for (int index10 = 0; index10 < 3; ++index10)
              {
                float num25 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.05f;
                float num26 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num25, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num26) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(50, 50, 50, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 6:
              for (int index11 = 0; index11 < 5; ++index11)
              {
                float num27 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
                float num28 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num27, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num28) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(75, 75, 75, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 9:
              for (int index12 = 0; index12 < 7; ++index12)
              {
                float num29 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.3f;
                float num30 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.3f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num29, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num30) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(100, 100, 100, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 11:
              for (int index13 = 0; index13 < 7; ++index13)
              {
                float num31 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.1f;
                float num32 = (float) Utils.RandomInt(ref seed, -10, 1) * 0.15f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num31, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num32) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(50, 50, 50, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 13:
              for (int index14 = 0; index14 < 8; ++index14)
              {
                float num33 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.1f;
                float num34 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.1f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num33, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num34) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(75, 75, 75, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 28:
            case 29:
              Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(75, 75, 75, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              break;
            case 44:
              TileDrawing.TileFlameData tileFlameData3 = this.GetTileFlameData(tileX, tileY, (int) drawData.typeCache, (int) drawData.tileFrameY);
              if (seed == 0UL)
                seed = tileFlameData3.flameSeed;
              tileFlameData3.flameSeed = seed;
              for (int index15 = 0; index15 < tileFlameData3.flameCount; ++index15)
              {
                float num35 = (float) Utils.RandomInt(ref tileFlameData3.flameSeed, tileFlameData3.flameRangeXMin, tileFlameData3.flameRangeXMax) * tileFlameData3.flameRangeMultX;
                float num36 = (float) Utils.RandomInt(ref tileFlameData3.flameSeed, tileFlameData3.flameRangeYMin, tileFlameData3.flameRangeYMax) * tileFlameData3.flameRangeMultY;
                Main.tileBatch.Draw(tileFlameData3.flameTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num35, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num36) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) tileFlameData3.flameColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            default:
              if (flag2)
              {
                TileDrawing.TileFlameData tileFlameData4 = this.GetTileFlameData(tileX, tileY, (int) drawData.typeCache, (int) drawData.tileFrameY);
                if (seed == 0UL)
                  seed = tileFlameData4.flameSeed;
                tileFlameData4.flameSeed = seed;
                for (int index16 = 0; index16 < tileFlameData4.flameCount; ++index16)
                {
                  float num37 = (float) Utils.RandomInt(ref tileFlameData4.flameSeed, tileFlameData4.flameRangeXMin, tileFlameData4.flameRangeXMax) * tileFlameData4.flameRangeMultX;
                  float num38 = (float) Utils.RandomInt(ref tileFlameData4.flameSeed, tileFlameData4.flameRangeYMin, tileFlameData4.flameRangeYMax) * tileFlameData4.flameRangeMultY;
                  Main.tileBatch.Draw(tileFlameData4.flameTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num37, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num38) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) tileFlameData4.flameColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
                }
                break;
              }
              for (int index17 = 0; index17 < 7; ++index17)
              {
                float num39 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
                float num40 = (float) Utils.RandomInt(ref seed, -10, 1) * 0.35f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num39, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num40) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(100, 100, 100, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
          }
          break;
        case 3:
          int num41 = (int) Main.tile[tileX, tileY].frameY / 54;
          if (Main.tile[tileX, tileY].frameX >= (short) 108)
            num41 += 37 * ((int) Main.tile[tileX, tileY].frameX / 108);
          bool flag3 = num41 >= 51;
          switch (num41)
          {
            case 8:
              for (int index18 = 0; index18 < 7; ++index18)
              {
                float num42 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.075f;
                float num43 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.075f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num42, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num43) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(50, 50, 50, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 9:
              for (int index19 = 0; index19 < 3; ++index19)
              {
                float num44 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.05f;
                float num45 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num44, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num45) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(50, 50, 50, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 11:
              for (int index20 = 0; index20 < 7; ++index20)
              {
                float num46 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.3f;
                float num47 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.3f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num46, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num47) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(50, 50, 50, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 15:
              for (int index21 = 0; index21 < 7; ++index21)
              {
                float num48 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.1f;
                float num49 = (float) Utils.RandomInt(ref seed, -10, 1) * 0.15f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num48, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num49) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(50, 50, 50, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 17:
            case 20:
              for (int index22 = 0; index22 < 7; ++index22)
              {
                float num50 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.075f;
                float num51 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.075f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num50, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num51) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(50, 50, 50, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 18:
              for (int index23 = 0; index23 < 8; ++index23)
              {
                float num52 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.1f;
                float num53 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.1f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num52, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num53) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(75, 75, 75, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 34:
            case 35:
              Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(75, 75, 75, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              break;
            case 50:
              TileDrawing.TileFlameData tileFlameData5 = this.GetTileFlameData(tileX, tileY, (int) drawData.typeCache, (int) drawData.tileFrameY);
              if (seed == 0UL)
                seed = tileFlameData5.flameSeed;
              tileFlameData5.flameSeed = seed;
              for (int index24 = 0; index24 < tileFlameData5.flameCount; ++index24)
              {
                float num54 = (float) Utils.RandomInt(ref tileFlameData5.flameSeed, tileFlameData5.flameRangeXMin, tileFlameData5.flameRangeXMax) * tileFlameData5.flameRangeMultX;
                float num55 = (float) Utils.RandomInt(ref tileFlameData5.flameSeed, tileFlameData5.flameRangeYMin, tileFlameData5.flameRangeYMax) * tileFlameData5.flameRangeMultY;
                Main.tileBatch.Draw(tileFlameData5.flameTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num54, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num55) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) tileFlameData5.flameColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            default:
              if (flag3)
              {
                TileDrawing.TileFlameData tileFlameData6 = this.GetTileFlameData(tileX, tileY, (int) drawData.typeCache, (int) drawData.tileFrameY);
                if (seed == 0UL)
                  seed = tileFlameData6.flameSeed;
                tileFlameData6.flameSeed = seed;
                for (int index25 = 0; index25 < tileFlameData6.flameCount; ++index25)
                {
                  float num56 = (float) Utils.RandomInt(ref tileFlameData6.flameSeed, tileFlameData6.flameRangeXMin, tileFlameData6.flameRangeXMax) * tileFlameData6.flameRangeMultX;
                  float num57 = (float) Utils.RandomInt(ref tileFlameData6.flameSeed, tileFlameData6.flameRangeYMin, tileFlameData6.flameRangeYMax) * tileFlameData6.flameRangeMultY;
                  Main.tileBatch.Draw(tileFlameData6.flameTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num56, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num57) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) tileFlameData6.flameColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
                }
                break;
              }
              for (int index26 = 0; index26 < 7; ++index26)
              {
                float num58 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
                float num59 = (float) Utils.RandomInt(ref seed, -10, 1) * 0.35f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num58, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num59) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(100, 100, 100, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
          }
          break;
        case 4:
          int num60 = (int) Main.tile[tileX, tileY].frameY / 54;
          bool flag4 = num60 >= 45;
          switch (num60)
          {
            case 1:
              for (int index27 = 0; index27 < 3; ++index27)
              {
                float num61 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
                float num62 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num61, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num62) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(50, 50, 50, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 2:
            case 4:
              for (int index28 = 0; index28 < 7; ++index28)
              {
                float num63 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.075f;
                float num64 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.075f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num63, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num64) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(50, 50, 50, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 3:
              for (int index29 = 0; index29 < 7; ++index29)
              {
                float num65 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.2f;
                float num66 = (float) Utils.RandomInt(ref seed, -20, 1) * 0.35f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num65, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num66) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(100, 100, 100, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 5:
              for (int index30 = 0; index30 < 7; ++index30)
              {
                float num67 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.3f;
                float num68 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.3f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num67, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num68) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(50, 50, 50, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 9:
              for (int index31 = 0; index31 < 7; ++index31)
              {
                float num69 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.1f;
                float num70 = (float) Utils.RandomInt(ref seed, -10, 1) * 0.15f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num69, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num70) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(50, 50, 50, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 12:
              float num71 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.01f;
              float num72 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.01f;
              Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num71, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num72) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(Utils.RandomInt(ref seed, 90, 111), Utils.RandomInt(ref seed, 90, 111), Utils.RandomInt(ref seed, 90, 111), 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              break;
            case 13:
              for (int index32 = 0; index32 < 8; ++index32)
              {
                float num73 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.1f;
                float num74 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.1f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num73, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num74) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(75, 75, 75, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            case 28:
            case 29:
              Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(75, 75, 75, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              break;
            case 44:
              TileDrawing.TileFlameData tileFlameData7 = this.GetTileFlameData(tileX, tileY, (int) drawData.typeCache, (int) drawData.tileFrameY);
              if (seed == 0UL)
                seed = tileFlameData7.flameSeed;
              tileFlameData7.flameSeed = seed;
              for (int index33 = 0; index33 < tileFlameData7.flameCount; ++index33)
              {
                float num75 = (float) Utils.RandomInt(ref tileFlameData7.flameSeed, tileFlameData7.flameRangeXMin, tileFlameData7.flameRangeXMax) * tileFlameData7.flameRangeMultX;
                float num76 = (float) Utils.RandomInt(ref tileFlameData7.flameSeed, tileFlameData7.flameRangeYMin, tileFlameData7.flameRangeYMax) * tileFlameData7.flameRangeMultY;
                Main.tileBatch.Draw(tileFlameData7.flameTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num75, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num76) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) tileFlameData7.flameColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
            default:
              if (flag4)
              {
                TileDrawing.TileFlameData tileFlameData8 = this.GetTileFlameData(tileX, tileY, (int) drawData.typeCache, (int) drawData.tileFrameY);
                if (seed == 0UL)
                  seed = tileFlameData8.flameSeed;
                tileFlameData8.flameSeed = seed;
                for (int index34 = 0; index34 < tileFlameData8.flameCount; ++index34)
                {
                  float num77 = (float) Utils.RandomInt(ref tileFlameData8.flameSeed, tileFlameData8.flameRangeXMin, tileFlameData8.flameRangeXMax) * tileFlameData8.flameRangeMultX;
                  float num78 = (float) Utils.RandomInt(ref tileFlameData8.flameSeed, tileFlameData8.flameRangeYMin, tileFlameData8.flameRangeYMax) * tileFlameData8.flameRangeMultY;
                  Main.tileBatch.Draw(tileFlameData8.flameTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num77, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num78) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) tileFlameData8.flameColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
                }
                break;
              }
              for (int index35 = 0; index35 < 7; ++index35)
              {
                float num79 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
                float num80 = (float) Utils.RandomInt(ref seed, -10, 1) * 0.35f;
                Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num79, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num80) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(100, 100, 100, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
              }
              break;
          }
          break;
        case 7:
          for (int index36 = 0; index36 < 4; ++index36)
          {
            float num81 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
            float num82 = (float) Utils.RandomInt(ref seed, -10, 10) * 0.15f;
            float num83 = 0.0f;
            float num84 = 0.0f;
            Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num83, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num84) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(50, 50, 50, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
          }
          break;
        case 13:
          int num85 = (int) drawData.tileFrameY / 36;
          bool flag5 = num85 >= 51;
          if (num85 == 1 || num85 == 3 || num85 == 6 || num85 == 8 || num85 == 19 || num85 == 27 || num85 == 29 || num85 == 30 || num85 == 31 /*0x1F*/ || num85 == 32 /*0x20*/ || num85 == 36 || num85 == 39)
          {
            for (int index37 = 0; index37 < 7; ++index37)
            {
              float num86 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
              float num87 = (float) Utils.RandomInt(ref seed, -10, 1) * 0.35f;
              Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num86, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num87) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(100, 100, 100, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
            }
            break;
          }
          if (num85 == 25 || num85 == 16 /*0x10*/ || num85 == 2)
          {
            for (int index38 = 0; index38 < 7; ++index38)
            {
              float num88 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
              float num89 = (float) Utils.RandomInt(ref seed, -10, 1) * 0.1f;
              Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num88, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num89) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(50, 50, 50, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
            }
            break;
          }
          if (num85 == 29)
          {
            for (int index39 = 0; index39 < 7; ++index39)
            {
              float num90 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
              float num91 = (float) Utils.RandomInt(ref seed, -10, 1) * 0.15f;
              Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num90, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num91) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(25, 25, 25, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
            }
            break;
          }
          if (num85 == 34 || num85 == 35)
          {
            Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(75, 75, 75, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
            break;
          }
          if (num85 == 50)
          {
            TileDrawing.TileFlameData tileFlameData9 = this.GetTileFlameData(tileX, tileY, (int) drawData.typeCache, (int) drawData.tileFrameY);
            if (seed == 0UL)
              seed = tileFlameData9.flameSeed;
            tileFlameData9.flameSeed = seed;
            for (int index40 = 0; index40 < tileFlameData9.flameCount; ++index40)
            {
              float num92 = (float) Utils.RandomInt(ref tileFlameData9.flameSeed, tileFlameData9.flameRangeXMin, tileFlameData9.flameRangeXMax) * tileFlameData9.flameRangeMultX;
              float num93 = (float) Utils.RandomInt(ref tileFlameData9.flameSeed, tileFlameData9.flameRangeYMin, tileFlameData9.flameRangeYMax) * tileFlameData9.flameRangeMultY;
              Main.tileBatch.Draw(tileFlameData9.flameTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num92, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num93) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) tileFlameData9.flameColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
            }
            break;
          }
          if (flag5)
          {
            TileDrawing.TileFlameData tileFlameData10 = this.GetTileFlameData(tileX, tileY, (int) drawData.typeCache, (int) drawData.tileFrameY);
            if (seed == 0UL)
              seed = tileFlameData10.flameSeed;
            tileFlameData10.flameSeed = seed;
            for (int index41 = 0; index41 < tileFlameData10.flameCount; ++index41)
            {
              float num94 = (float) Utils.RandomInt(ref tileFlameData10.flameSeed, tileFlameData10.flameRangeXMin, tileFlameData10.flameRangeXMax) * tileFlameData10.flameRangeMultX;
              float num95 = (float) Utils.RandomInt(ref tileFlameData10.flameSeed, tileFlameData10.flameRangeYMin, tileFlameData10.flameRangeYMax) * tileFlameData10.flameRangeMultY;
              Main.tileBatch.Draw(tileFlameData10.flameTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num94, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num95) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) tileFlameData10.flameColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
            }
            break;
          }
          break;
        default:
          Color colors = new Color(100, 100, 100, 0);
          if (drawData.tileCache.type == (ushort) 4)
          {
            switch ((int) drawData.tileCache.frameY / 22)
            {
              case 14:
                colors = new Color((float) Main.DiscoR / (float) byte.MaxValue, (float) Main.DiscoG / (float) byte.MaxValue, (float) Main.DiscoB / (float) byte.MaxValue, 0.0f);
                break;
              case 22:
                colors = new Color(50, 50, 100, 20);
                break;
              case 23:
                colors = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 200);
                break;
            }
          }
          if (drawData.tileCache.type == (ushort) 646)
            colors = new Color(100, 100, 100, 150);
          for (int index42 = 0; index42 < 7; ++index42)
          {
            float num96 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.15f;
            float num97 = (float) Utils.RandomInt(ref seed, -10, 1) * 0.35f;
            Main.tileBatch.Draw(TextureAssets.Flames[index1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0) + num96, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop) + num97) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) colors, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
          }
          break;
      }
    }
    if (drawData.typeCache == (ushort) 144 /*0x90*/)
      Main.tileBatch.Draw(TextureAssets.Timer.Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color(200, 200, 200, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    if (drawData.typeCache == (ushort) 237)
      Main.tileBatch.Draw(TextureAssets.SunAltar.Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset, new Rectangle?(new Rectangle((int) drawData.tileFrameX, (int) drawData.tileFrameY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) new Color((int) Main.mouseTextColor / 2, (int) Main.mouseTextColor / 2, (int) Main.mouseTextColor / 2, 0), TileDrawing._zero, 1f, drawData.tileSpriteEffect);
    if (drawData.typeCache != (ushort) 658 || (int) drawData.tileFrameX % 36 != 0 || (int) drawData.tileFrameY % 54 != 0)
      return;
    int num = (int) drawData.tileFrameY / 54;
    if (num == 2)
      return;
    Texture2D texture2D = TextureAssets.GlowMask[334].Value;
    Vector2 vector2 = new Vector2(0.0f, -10f);
    Vector2 position1 = new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) drawData.tileWidth / 2f, (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop)) + screenOffset + vector2;
    Rectangle rectangle1 = texture2D.Frame();
    Color colors1 = new Color((int) Main.mouseTextColor, (int) Main.mouseTextColor, (int) Main.mouseTextColor, 0);
    if (num == 0)
      colors1 *= 0.75f;
    Main.tileBatch.Draw(texture2D, position1, new Rectangle?(rectangle1), (VertexColors) colors1, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
  }

  private int GetPalmTreeVariant(int x, int y)
  {
    int palmTreeVariant = -1;
    if (Main.tile[x, y].active() && Main.tile[x, y].type == (ushort) 53)
      palmTreeVariant = 0;
    if (Main.tile[x, y].active() && Main.tile[x, y].type == (ushort) 234)
      palmTreeVariant = 1;
    if (Main.tile[x, y].active() && Main.tile[x, y].type == (ushort) 116)
      palmTreeVariant = 2;
    if (Main.tile[x, y].active() && Main.tile[x, y].type == (ushort) 112 /*0x70*/)
      palmTreeVariant = 3;
    if (WorldGen.IsPalmOasisTree(x))
      palmTreeVariant += 4;
    return palmTreeVariant;
  }

  private void DrawSingleTile_SlicedBlock(
    Vector2 normalTilePosition,
    int tileX,
    int tileY,
    TileDrawInfo drawData)
  {
    Color colors = new Color();
    Vector2 origin = new Vector2();
    if ((int) drawData.tileLight.R > (int) this._highQualityLightingRequirement.R || (int) drawData.tileLight.G > (int) this._highQualityLightingRequirement.G || (int) drawData.tileLight.B > (int) this._highQualityLightingRequirement.B)
    {
      Vector3[] slices = drawData.colorSlices;
      Lighting.GetColor9Slice(tileX, tileY, ref slices);
      Vector3 vector3_1 = drawData.tileLight.ToVector3();
      Vector3 vector3_2 = drawData.colorTint.ToVector3();
      if (drawData.tileCache.fullbrightBlock())
        slices = this._glowPaintColorSlices;
      for (int index = 0; index < 9; ++index)
      {
        Rectangle rectangle;
        rectangle.X = 0;
        rectangle.Y = 0;
        rectangle.Width = 4;
        rectangle.Height = 4;
        switch (index)
        {
          case 1:
            rectangle.Width = 8;
            rectangle.X = 4;
            break;
          case 2:
            rectangle.X = 12;
            break;
          case 3:
            rectangle.Height = 8;
            rectangle.Y = 4;
            break;
          case 4:
            rectangle.Width = 8;
            rectangle.Height = 8;
            rectangle.X = 4;
            rectangle.Y = 4;
            break;
          case 5:
            rectangle.X = 12;
            rectangle.Y = 4;
            rectangle.Height = 8;
            break;
          case 6:
            rectangle.Y = 12;
            break;
          case 7:
            rectangle.Width = 8;
            rectangle.Height = 4;
            rectangle.X = 4;
            rectangle.Y = 12;
            break;
          case 8:
            rectangle.X = 12;
            rectangle.Y = 12;
            break;
        }
        Vector3 tileLight;
        tileLight.X = (float) (((double) slices[index].X + (double) vector3_1.X) * 0.5);
        tileLight.Y = (float) (((double) slices[index].Y + (double) vector3_1.Y) * 0.5);
        tileLight.Z = (float) (((double) slices[index].Z + (double) vector3_1.Z) * 0.5);
        TileDrawing.GetFinalLight(drawData.tileCache, drawData.typeCache, ref tileLight, ref vector3_2);
        Vector2 position;
        position.X = normalTilePosition.X + (float) rectangle.X;
        position.Y = normalTilePosition.Y + (float) rectangle.Y;
        rectangle.X += (int) drawData.tileFrameX + drawData.addFrX;
        rectangle.Y += (int) drawData.tileFrameY + drawData.addFrY;
        int num1 = (int) ((double) tileLight.X * (double) byte.MaxValue);
        int num2 = (int) ((double) tileLight.Y * (double) byte.MaxValue);
        int num3 = (int) ((double) tileLight.Z * (double) byte.MaxValue);
        if (num1 > (int) byte.MaxValue)
          num1 = (int) byte.MaxValue;
        if (num2 > (int) byte.MaxValue)
          num2 = (int) byte.MaxValue;
        if (num3 > (int) byte.MaxValue)
          num3 = (int) byte.MaxValue;
        int num4 = num3 << 16 /*0x10*/;
        int num5 = num2 << 8;
        colors.PackedValue = (uint) (num1 | num5 | num4 | -16777216 /*0xFF000000*/);
        Main.tileBatch.Draw(drawData.drawTexture, position, new Rectangle?(rectangle), (VertexColors) colors, origin, 1f, drawData.tileSpriteEffect);
      }
    }
    else if ((int) drawData.tileLight.R > (int) this._mediumQualityLightingRequirement.R || (int) drawData.tileLight.G > (int) this._mediumQualityLightingRequirement.G || (int) drawData.tileLight.B > (int) this._mediumQualityLightingRequirement.B)
    {
      Vector3[] slices = drawData.colorSlices;
      Lighting.GetColor4Slice(tileX, tileY, ref slices);
      Vector3 vector3_3 = drawData.tileLight.ToVector3();
      Vector3 vector3_4 = drawData.colorTint.ToVector3();
      if (drawData.tileCache.fullbrightBlock())
        slices = this._glowPaintColorSlices;
      Rectangle rectangle;
      rectangle.Width = 8;
      rectangle.Height = 8;
      for (int index = 0; index < 4; ++index)
      {
        rectangle.X = 0;
        rectangle.Y = 0;
        switch (index)
        {
          case 1:
            rectangle.X = 8;
            break;
          case 2:
            rectangle.Y = 8;
            break;
          case 3:
            rectangle.X = 8;
            rectangle.Y = 8;
            break;
        }
        Vector3 tileLight;
        tileLight.X = (float) (((double) slices[index].X + (double) vector3_3.X) * 0.5);
        tileLight.Y = (float) (((double) slices[index].Y + (double) vector3_3.Y) * 0.5);
        tileLight.Z = (float) (((double) slices[index].Z + (double) vector3_3.Z) * 0.5);
        TileDrawing.GetFinalLight(drawData.tileCache, drawData.typeCache, ref tileLight, ref vector3_4);
        Vector2 position;
        position.X = normalTilePosition.X + (float) rectangle.X;
        position.Y = normalTilePosition.Y + (float) rectangle.Y;
        rectangle.X += (int) drawData.tileFrameX + drawData.addFrX;
        rectangle.Y += (int) drawData.tileFrameY + drawData.addFrY;
        int num6 = (int) ((double) tileLight.X * (double) byte.MaxValue);
        int num7 = (int) ((double) tileLight.Y * (double) byte.MaxValue);
        int num8 = (int) ((double) tileLight.Z * (double) byte.MaxValue);
        if (num6 > (int) byte.MaxValue)
          num6 = (int) byte.MaxValue;
        if (num7 > (int) byte.MaxValue)
          num7 = (int) byte.MaxValue;
        if (num8 > (int) byte.MaxValue)
          num8 = (int) byte.MaxValue;
        int num9 = num8 << 16 /*0x10*/;
        int num10 = num7 << 8;
        colors.PackedValue = (uint) (num6 | num10 | num9 | -16777216 /*0xFF000000*/);
        Main.tileBatch.Draw(drawData.drawTexture, position, new Rectangle?(rectangle), (VertexColors) colors, origin, 1f, drawData.tileSpriteEffect);
      }
    }
    else
      Main.tileBatch.Draw(drawData.drawTexture, normalTilePosition, new Rectangle?(new Rectangle((int) drawData.tileFrameX + drawData.addFrX, (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight)), (VertexColors) drawData.finalColor, TileDrawing._zero, 1f, drawData.tileSpriteEffect);
  }

  private void DrawXmasTree(
    Vector2 screenPosition,
    Vector2 screenOffset,
    int tileX,
    int tileY,
    TileDrawInfo drawData)
  {
    int num1 = 2;
    if (tileY - (int) drawData.tileFrameY > 0 && drawData.tileFrameY == (short) 7 && Main.tile[tileX, tileY - (int) drawData.tileFrameY] != null)
    {
      drawData.tileTop -= 16 /*0x10*/ * (int) drawData.tileFrameY;
      drawData.tileFrameX = Main.tile[tileX, tileY - (int) drawData.tileFrameY].frameX;
      drawData.tileFrameY = Main.tile[tileX, tileY - (int) drawData.tileFrameY].frameY;
    }
    if (drawData.tileFrameX < (short) 10)
      return;
    int num2 = 0;
    if (((int) drawData.tileFrameY & 1) == 1)
      ++num2;
    if (((int) drawData.tileFrameY & 2) == 2)
      num2 += 2;
    if (((int) drawData.tileFrameY & 4) == 4)
      num2 += 4;
    int num3 = 0;
    if (((int) drawData.tileFrameY & 8) == 8)
      ++num3;
    if (((int) drawData.tileFrameY & 16 /*0x10*/) == 16 /*0x10*/)
      num3 += 2;
    if (((int) drawData.tileFrameY & 32 /*0x20*/) == 32 /*0x20*/)
      num3 += 4;
    int num4 = 0;
    if (((int) drawData.tileFrameY & 64 /*0x40*/) == 64 /*0x40*/)
      ++num4;
    if (((int) drawData.tileFrameY & 128 /*0x80*/) == 128 /*0x80*/)
      num4 += 2;
    if (((int) drawData.tileFrameY & 256 /*0x0100*/) == 256 /*0x0100*/)
      num4 += 4;
    if (((int) drawData.tileFrameY & 512 /*0x0200*/) == 512 /*0x0200*/)
      num4 += 8;
    int num5 = 0;
    if (((int) drawData.tileFrameY & 1024 /*0x0400*/) == 1024 /*0x0400*/)
      ++num5;
    if (((int) drawData.tileFrameY & 2048 /*0x0800*/) == 2048 /*0x0800*/)
      num5 += 2;
    if (((int) drawData.tileFrameY & 4096 /*0x1000*/) == 4096 /*0x1000*/)
      num5 += 4;
    if (((int) drawData.tileFrameY & 8192 /*0x2000*/) == 8192 /*0x2000*/)
      num5 += 8;
    Color color = Lighting.GetColor(tileX + 1, tileY - 3);
    Main.tileBatch.Draw(TextureAssets.XmasTree[0].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop + num1)) + screenOffset, new Rectangle?(new Rectangle(0, 0, 64 /*0x40*/, 128 /*0x80*/)), (VertexColors) color, TileDrawing._zero, 1f, SpriteEffects.None);
    if (num2 > 0)
    {
      int num6 = num2 - 1;
      Color colors = color;
      if (num6 != 3)
        colors = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      Main.tileBatch.Draw(TextureAssets.XmasTree[3].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop + num1)) + screenOffset, new Rectangle?(new Rectangle(66 * num6, 0, 64 /*0x40*/, 128 /*0x80*/)), (VertexColors) colors, TileDrawing._zero, 1f, SpriteEffects.None);
    }
    if (num3 > 0)
    {
      int num7 = num3 - 1;
      Main.tileBatch.Draw(TextureAssets.XmasTree[1].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop + num1)) + screenOffset, new Rectangle?(new Rectangle(66 * num7, 0, 64 /*0x40*/, 128 /*0x80*/)), (VertexColors) color, TileDrawing._zero, 1f, SpriteEffects.None);
    }
    if (num4 > 0)
    {
      int num8 = num4 - 1;
      Main.tileBatch.Draw(TextureAssets.XmasTree[2].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop + num1)) + screenOffset, new Rectangle?(new Rectangle(66 * num8, 0, 64 /*0x40*/, 128 /*0x80*/)), (VertexColors) color, TileDrawing._zero, 1f, SpriteEffects.None);
    }
    if (num5 <= 0)
      return;
    int num9 = num5 - 1;
    Main.tileBatch.Draw(TextureAssets.XmasTree[4].Value, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X) - (float) (((double) drawData.tileWidth - 16.0) / 2.0), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y + drawData.tileTop + num1)) + screenOffset, new Rectangle?(new Rectangle(66 * num9, 130 * Main.tileFrame[171], 64 /*0x40*/, 128 /*0x80*/)), (VertexColors) new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue), TileDrawing._zero, 1f, SpriteEffects.None);
  }

  private void DrawTile_BackRope(
    Vector2 screenPosition,
    Vector2 screenOffset,
    int tileX,
    int tileY,
    TileDrawInfo drawData)
  {
    if (!WorldGen.InWorld(tileX, tileY, 1))
      return;
    int topRopeY = tileX;
    int bottomRopeY = tileY;
    if (!WorldGen.IsRope(tileX, tileY, out topRopeY, out bottomRopeY))
      return;
    Tile tile = Main.tile[tileX, topRopeY];
    if (tile == null)
      return;
    int y = (tileY + tileX) % 3 * 18;
    Texture2D tileDrawTexture = this.GetTileDrawTexture(tile, tileX, tileY);
    Main.tileBatch.Draw(tileDrawTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y)) + screenOffset, new Rectangle?(new Rectangle(90, y, 16 /*0x10*/, 16 /*0x10*/)), (VertexColors) drawData.tileLight, new Vector2(), 1f, drawData.tileSpriteEffect);
  }

  private void DrawTile_MinecartTrack(
    Vector2 screenPosition,
    Vector2 screenOffset,
    int tileX,
    int tileY,
    TileDrawInfo drawData)
  {
    drawData.tileLight = TileDrawing.GetFinalLight(drawData.tileCache, drawData.typeCache, drawData.tileLight, drawData.colorTint);
    int frontColor;
    int backColor;
    Minecart.TrackColors(tileX, tileY, drawData.tileCache, out frontColor, out backColor);
    drawData.drawTexture = this.GetTileDrawTexture((int) drawData.tileCache.type, frontColor);
    Texture2D tileDrawTexture = this.GetTileDrawTexture((int) drawData.tileCache.type, backColor);
    this.DrawTile_BackRope(screenPosition, screenOffset, tileX, tileY, drawData);
    if (drawData.tileFrameY != (short) -1)
      Main.tileBatch.Draw(tileDrawTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y)) + screenOffset, new Rectangle?(Minecart.GetSourceRect((int) drawData.tileFrameY, Main.tileFrame[314])), (VertexColors) drawData.tileLight, new Vector2(), 1f, drawData.tileSpriteEffect);
    Main.tileBatch.Draw(drawData.drawTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X), (float) (tileY * 16 /*0x10*/ - (int) screenPosition.Y)) + screenOffset, new Rectangle?(Minecart.GetSourceRect((int) drawData.tileFrameX, Main.tileFrame[314])), (VertexColors) drawData.tileLight, new Vector2(), 1f, drawData.tileSpriteEffect);
    if (Minecart.DrawLeftDecoration((int) drawData.tileFrameY))
      Main.tileBatch.Draw(tileDrawTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X), (float) ((tileY + 1) * 16 /*0x10*/ - (int) screenPosition.Y)) + screenOffset, new Rectangle?(Minecart.GetSourceRect(36)), (VertexColors) drawData.tileLight, new Vector2(), 1f, drawData.tileSpriteEffect);
    if (Minecart.DrawLeftDecoration((int) drawData.tileFrameX))
      Main.tileBatch.Draw(drawData.drawTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X), (float) ((tileY + 1) * 16 /*0x10*/ - (int) screenPosition.Y)) + screenOffset, new Rectangle?(Minecart.GetSourceRect(36)), (VertexColors) drawData.tileLight, new Vector2(), 1f, drawData.tileSpriteEffect);
    if (Minecart.DrawRightDecoration((int) drawData.tileFrameY))
      Main.tileBatch.Draw(tileDrawTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X), (float) ((tileY + 1) * 16 /*0x10*/ - (int) screenPosition.Y)) + screenOffset, new Rectangle?(Minecart.GetSourceRect(37, Main.tileFrame[314])), (VertexColors) drawData.tileLight, new Vector2(), 1f, drawData.tileSpriteEffect);
    if (Minecart.DrawRightDecoration((int) drawData.tileFrameX))
      Main.tileBatch.Draw(drawData.drawTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X), (float) ((tileY + 1) * 16 /*0x10*/ - (int) screenPosition.Y)) + screenOffset, new Rectangle?(Minecart.GetSourceRect(37)), (VertexColors) drawData.tileLight, new Vector2(), 1f, drawData.tileSpriteEffect);
    if (Minecart.DrawBumper((int) drawData.tileFrameX))
    {
      Main.tileBatch.Draw(drawData.drawTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X), (float) ((tileY - 1) * 16 /*0x10*/ - (int) screenPosition.Y)) + screenOffset, new Rectangle?(Minecart.GetSourceRect(39)), (VertexColors) drawData.tileLight, new Vector2(), 1f, drawData.tileSpriteEffect);
    }
    else
    {
      if (!Minecart.DrawBouncyBumper((int) drawData.tileFrameX))
        return;
      Main.tileBatch.Draw(drawData.drawTexture, new Vector2((float) (tileX * 16 /*0x10*/ - (int) screenPosition.X), (float) ((tileY - 1) * 16 /*0x10*/ - (int) screenPosition.Y)) + screenOffset, new Rectangle?(Minecart.GetSourceRect(38)), (VertexColors) drawData.tileLight, new Vector2(), 1f, drawData.tileSpriteEffect);
    }
  }

  private void DrawTile_LiquidBehindTile(
    bool solidLayer,
    int waterStyleOverride,
    Vector2 screenPosition,
    Vector2 screenOffset,
    int tileX,
    int tileY,
    Tile tileCache)
  {
    Tile tile1 = Main.tile[tileX + 1, tileY];
    Tile tile2 = Main.tile[tileX - 1, tileY];
    Tile tile3 = Main.tile[tileX, tileY - 1];
    Tile tile4 = Main.tile[tileX, tileY + 1];
    if (tile1 == null)
    {
      tile1 = new Tile();
      Main.tile[tileX + 1, tileY] = tile1;
    }
    if (tile2 == null)
    {
      tile2 = new Tile();
      Main.tile[tileX - 1, tileY] = tile2;
    }
    if (tile3 == null)
    {
      tile3 = new Tile();
      Main.tile[tileX, tileY - 1] = tile3;
    }
    if (tile4 == null)
    {
      tile4 = new Tile();
      Main.tile[tileX, tileY + 1] = tile4;
    }
    if (tile1.type == (ushort) 379)
      tile1 = new Tile();
    if (tile2.type == (ushort) 379)
      tile2 = new Tile();
    if (tile3.type == (ushort) 379)
      tile3 = new Tile();
    if (tile4.type == (ushort) 379)
      tile4 = new Tile();
    if (DebugOptions.hideWater || !tileCache.active() || tileCache.inActive() || this._tileSolidTop[(int) tileCache.type] || tileCache.halfBrick() && (tile2.liquid > (byte) 160 /*0xA0*/ || tile1.liquid > (byte) 160 /*0xA0*/) && Main.instance.waterfallManager.CheckForWaterfall(tileX, tileY) || TileID.Sets.BlocksWaterDrawingBehindSelf[(int) tileCache.type] && tileCache.slope() == (byte) 0)
      return;
    int num1 = 0;
    bool flag1 = false;
    bool flag2 = false;
    bool flag3 = false;
    bool flag4 = false;
    bool flag5 = false;
    int liquidType = 0;
    bool flag6 = false;
    int num2 = (int) tileCache.slope();
    int num3 = tileCache.blockType();
    if (tileCache.type == (ushort) 379 && tileCache.liquid > (byte) 0)
      return;
    if (tileCache.type == (ushort) 546 && tileCache.liquid > (byte) 0)
    {
      flag5 = true;
      flag4 = true;
      flag1 = true;
      flag2 = true;
      switch (tileCache.liquidType())
      {
        case 0:
          flag6 = true;
          break;
        case 1:
          liquidType = 1;
          break;
        case 2:
          liquidType = 11;
          break;
        case 3:
          liquidType = 14;
          break;
      }
      num1 = (int) tileCache.liquid;
    }
    else
    {
      if (tileCache.liquid > (byte) 0)
      {
        switch (num3)
        {
          case 0:
            goto label_37;
          case 1:
            if (tileCache.liquid <= (byte) 160 /*0xA0*/)
              goto label_37;
            break;
        }
        flag5 = true;
        switch (tileCache.liquidType())
        {
          case 0:
            flag6 = true;
            break;
          case 1:
            liquidType = 1;
            break;
          case 2:
            liquidType = 11;
            break;
          case 3:
            liquidType = 14;
            break;
        }
        if ((int) tileCache.liquid > num1)
          num1 = (int) tileCache.liquid;
      }
label_37:
      if (tile2.liquid > (byte) 0 && num2 != 1 && num2 != 3)
      {
        flag1 = true;
        switch (tile2.liquidType())
        {
          case 0:
            flag6 = true;
            break;
          case 1:
            liquidType = 1;
            break;
          case 2:
            liquidType = 11;
            break;
          case 3:
            liquidType = 14;
            break;
        }
        if ((int) tile2.liquid > num1)
          num1 = (int) tile2.liquid;
      }
      if (tile1.liquid > (byte) 0 && num2 != 2 && num2 != 4)
      {
        flag2 = true;
        switch (tile1.liquidType())
        {
          case 0:
            flag6 = true;
            break;
          case 1:
            liquidType = 1;
            break;
          case 2:
            liquidType = 11;
            break;
          case 3:
            liquidType = 14;
            break;
        }
        if ((int) tile1.liquid > num1)
          num1 = (int) tile1.liquid;
      }
      if (tile3.liquid > (byte) 0 && num2 != 3 && num2 != 4)
      {
        flag3 = true;
        switch (tile3.liquidType())
        {
          case 0:
            flag6 = true;
            break;
          case 1:
            liquidType = 1;
            break;
          case 2:
            liquidType = 11;
            break;
          case 3:
            liquidType = 14;
            break;
        }
      }
      if (tile4.liquid > (byte) 0 && num2 != 1 && num2 != 2)
      {
        if (tile4.liquid > (byte) 240 /*0xF0*/)
          flag4 = true;
        switch (tile4.liquidType())
        {
          case 0:
            flag6 = true;
            break;
          case 1:
            liquidType = 1;
            break;
          case 2:
            liquidType = 11;
            break;
          case 3:
            liquidType = 14;
            break;
        }
      }
    }
    if (!flag3 && !flag4 && !flag1 && !flag2 && !flag5)
      return;
    if (waterStyleOverride != -1)
      Main.waterStyle = waterStyleOverride;
    if (liquidType == 0)
      liquidType = Main.waterStyle;
    VertexColors vertices;
    Lighting.GetCornerColors(tileX, tileY, out vertices);
    Vector2 vector2 = new Vector2((float) (tileX * 16 /*0x10*/), (float) (tileY * 16 /*0x10*/));
    Rectangle liquidSize = new Rectangle(0, 4, 16 /*0x10*/, 16 /*0x10*/);
    if (flag4 && flag1 | flag2)
    {
      flag1 = true;
      flag2 = true;
    }
    if ((!tileCache.active() ? 0 : (Main.tileSolidTop[(int) tileCache.type] ? 1 : (!Main.tileSolid[(int) tileCache.type] ? 1 : 0))) != 0)
      return;
    if ((!flag3 || !(flag1 | flag2)) && !(flag4 & flag3))
    {
      if (flag3)
      {
        liquidSize = new Rectangle(0, 4, 16 /*0x10*/, 4);
        if (tileCache.halfBrick() || tileCache.slope() != (byte) 0)
          liquidSize = new Rectangle(0, 4, 16 /*0x10*/, 12);
      }
      else if (flag4 && !flag1 && !flag2)
      {
        vector2 = new Vector2((float) (tileX * 16 /*0x10*/), (float) (tileY * 16 /*0x10*/ + 12));
        liquidSize = new Rectangle(0, 4, 16 /*0x10*/, 4);
      }
      else
      {
        double num4 = (double) (256 /*0x0100*/ - num1) / 32.0;
        int y1 = 4;
        if (tile3.liquid == (byte) 0 && (num3 != 0 || !WorldGen.SolidTile(tileX, tileY - 1)))
          y1 = 0;
        int y2 = (int) num4 * 2;
        if (tileCache.slope() != (byte) 0)
        {
          vector2 = new Vector2((float) (tileX * 16 /*0x10*/), (float) (tileY * 16 /*0x10*/ + y2));
          liquidSize = new Rectangle(0, y2, 16 /*0x10*/, 16 /*0x10*/ - y2);
        }
        else if (flag1 & flag2 || tileCache.halfBrick())
        {
          vector2 = new Vector2((float) (tileX * 16 /*0x10*/), (float) (tileY * 16 /*0x10*/ + y2));
          liquidSize = new Rectangle(0, y1, 16 /*0x10*/, 16 /*0x10*/ - y2);
        }
        else if (flag1)
        {
          vector2 = new Vector2((float) (tileX * 16 /*0x10*/), (float) (tileY * 16 /*0x10*/ + y2));
          liquidSize = new Rectangle(0, y1, 4, 16 /*0x10*/ - y2);
        }
        else
        {
          vector2 = new Vector2((float) (tileX * 16 /*0x10*/ + 12), (float) (tileY * 16 /*0x10*/ + y2));
          liquidSize = new Rectangle(0, y1, 4, 16 /*0x10*/ - y2);
        }
      }
    }
    Vector2 position = vector2 - screenPosition + screenOffset;
    float num5 = 0.5f;
    switch (liquidType)
    {
      case 1:
        num5 = Main.player[Main.myPlayer].lavaOpacity;
        break;
      case 11:
        num5 = Math.Max(num5 * 1.7f, 1f);
        break;
    }
    if ((liquidType != 1 || (double) Main.player[Main.myPlayer].lavaOpacity >= 1.0) && ((double) tileY <= Main.worldSurface || (double) num5 > 1.0))
    {
      num5 = 1f;
      if (tileCache.wall == (ushort) 21)
        num5 = 0.9f;
      else if (tileCache.wall > (ushort) 0)
        num5 = 0.6f;
    }
    if (tileCache.halfBrick() && tile3.liquid > (byte) 0 && tileCache.wall > (ushort) 0)
      num5 = 0.0f;
    if (num2 == 4 && tile2.liquid == (byte) 0 && !WorldGen.SolidTile(tileX - 1, tileY))
      num5 = 0.0f;
    if (num2 == 3 && tile1.liquid == (byte) 0 && !WorldGen.SolidTile(tileX + 1, tileY))
      num5 = 0.0f;
    vertices.BottomLeftColor *= num5;
    vertices.BottomRightColor *= num5;
    vertices.TopLeftColor *= num5;
    vertices.TopRightColor *= num5;
    if (tileCache.halfBrick() && tile3.liquid > (byte) 0 && (double) tileY > Main.worldSurface)
    {
      vertices.TopLeftColor *= 0.0f;
      vertices.TopRightColor *= 0.0f;
    }
    bool flag7 = false;
    if (flag6)
    {
      for (int index = 0; index < 15; ++index)
      {
        if (Main.IsLiquidStyleWater(index) && (double) Main.liquidAlpha[index] > 0.0 && index != liquidType)
        {
          this.DrawPartialLiquid(!solidLayer, tileCache, ref position, ref liquidSize, index, ref vertices);
          flag7 = true;
          break;
        }
      }
    }
    VertexColors colors = vertices;
    float num6 = flag7 ? Main.liquidAlpha[liquidType] : 1f;
    colors.BottomLeftColor *= num6;
    colors.BottomRightColor *= num6;
    colors.TopLeftColor *= num6;
    colors.TopRightColor *= num6;
    if (liquidType == 14)
      LiquidRenderer.SetShimmerVertexColors(ref colors, solidLayer ? 0.75f : 1f, tileX, tileY);
    this.DrawPartialLiquid(!solidLayer, tileCache, ref position, ref liquidSize, liquidType, ref colors);
  }

  private void CacheSpecialDraws_Part1(
    int tileX,
    int tileY,
    int tileType,
    int drawDataTileFrameX,
    int drawDataTileFrameY,
    bool skipDraw)
  {
    if (tileType == 395)
    {
      Point point = new Point(tileX, tileY);
      if (drawDataTileFrameX % 36 != 0)
        --point.X;
      if (drawDataTileFrameY % 36 != 0)
        --point.Y;
      if (!this._itemFrameTileEntityPositions.ContainsKey(point))
      {
        this._itemFrameTileEntityPositions[point] = TileEntityType<TEItemFrame>.Find(point.X, point.Y);
        if (this._itemFrameTileEntityPositions[point] != -1)
          this.AddSpecialLegacyPoint(point);
      }
    }
    if (tileType == 698)
    {
      Point point = new Point(tileX, tileY);
      if (drawDataTileFrameX % 18 != 0)
        --point.X;
      if (drawDataTileFrameY % 36 != 0)
        --point.Y;
      if (!this._deadCellsDisplayJarTileEntityPositions.ContainsKey(point))
      {
        this._deadCellsDisplayJarTileEntityPositions[point] = TileEntityType<TEDeadCellsDisplayJar>.Find(point.X, point.Y);
        if (this._deadCellsDisplayJarTileEntityPositions[point] != -1)
          this.AddSpecialLegacyPoint(point);
      }
    }
    if (tileType == 520)
    {
      Point point = new Point(tileX, tileY);
      if (!this._foodPlatterTileEntityPositions.ContainsKey(point))
      {
        this._foodPlatterTileEntityPositions[point] = TileEntityType<TEFoodPlatter>.Find(point.X, point.Y);
        if (this._foodPlatterTileEntityPositions[point] != -1)
          this.AddSpecialLegacyPoint(point);
      }
    }
    if (tileType == 471)
    {
      Point point = new Point(tileX, tileY);
      point.X -= drawDataTileFrameX % 54 / 18;
      point.Y -= drawDataTileFrameY % 54 / 18;
      if (!this._weaponRackTileEntityPositions.ContainsKey(point))
      {
        this._weaponRackTileEntityPositions[point] = TileEntityType<TEWeaponsRack>.Find(point.X, point.Y);
        if (this._weaponRackTileEntityPositions[point] != -1)
          this.AddSpecialLegacyPoint(point);
      }
    }
    if (tileType == 470)
    {
      Point point = new Point(tileX, tileY);
      point.X -= drawDataTileFrameX % 36 / 18;
      point.Y -= drawDataTileFrameY % 54 / 18;
      if (!this._displayDollTileEntityPositions.ContainsKey(point))
      {
        this._displayDollTileEntityPositions[point] = TileEntityType<TEDisplayDoll>.Find(point.X, point.Y);
        if (this._displayDollTileEntityPositions[point] != -1)
          this.AddSpecialLegacyPoint(point);
      }
    }
    if (tileType == 475)
    {
      Point point = new Point(tileX, tileY);
      point.X -= drawDataTileFrameX % 54 / 18;
      point.Y -= drawDataTileFrameY % 72 / 18;
      if (!this._hatRackTileEntityPositions.ContainsKey(point))
      {
        this._hatRackTileEntityPositions[point] = TileEntityType<TEHatRack>.Find(point.X, point.Y);
        if (this._hatRackTileEntityPositions[point] != -1)
          this.AddSpecialLegacyPoint(point);
      }
    }
    if (tileType == 620 && drawDataTileFrameX == 0 && drawDataTileFrameY == 0)
      this.AddSpecialLegacyPoint(tileX, tileY);
    if (tileType == 237 && drawDataTileFrameX == 18 && drawDataTileFrameY == 0)
      this.AddSpecialLegacyPoint(tileX, tileY);
    if (skipDraw)
      return;
    switch (tileType)
    {
      case 5:
      case 583:
      case 584:
      case 585:
      case 586:
      case 587:
      case 588:
      case 589:
      case 596:
      case 616:
      case 634:
        if (drawDataTileFrameY < 198 || drawDataTileFrameX < 22)
          break;
        this.AddSpecialPoint(tileX, tileY, TileDrawing.TileCounterType.Tree);
        break;
      case 323:
        if (drawDataTileFrameX > 132 || drawDataTileFrameX < 88)
          break;
        this.AddSpecialPoint(tileX, tileY, TileDrawing.TileCounterType.Tree);
        break;
    }
  }

  private void CacheSpecialDraws_Part2(int tileX, int tileY, TileDrawInfo drawData, bool skipDraw)
  {
    if (TileID.Sets.BasicChest[(int) drawData.typeCache])
    {
      Point key = new Point(tileX, tileY);
      if ((int) drawData.tileFrameX % 36 != 0)
        --key.X;
      if ((int) drawData.tileFrameY % 36 != 0)
        --key.Y;
      if (!this._chestPositions.ContainsKey(key))
        this._chestPositions[key] = Chest.FindChest(key.X, key.Y);
      int num1 = (int) drawData.tileFrameX / 18;
      int num2 = (int) drawData.tileFrameY / 18;
      int num3 = (int) drawData.tileFrameX / 36;
      int num4 = num1 * 18;
      drawData.addFrX = num4 - (int) drawData.tileFrameX;
      int num5 = num2 * 18;
      if (this._chestPositions[key] != -1)
      {
        int frame = Main.chest[this._chestPositions[key]].frame;
        if (frame == 1)
          num5 += 38;
        if (frame == 2)
          num5 += 76;
      }
      drawData.addFrY = num5 - (int) drawData.tileFrameY;
      if (num2 != 0)
        drawData.tileHeight = 18;
      if (drawData.typeCache == (ushort) 21 && (num3 == 48 /*0x30*/ || num3 == 49))
        drawData.glowSourceRect = new Rectangle(16 /*0x10*/ * (num1 % 2), (int) drawData.tileFrameY + drawData.addFrY, drawData.tileWidth, drawData.tileHeight);
    }
    if (drawData.typeCache != (ushort) 378)
      return;
    Point key1 = new Point(tileX, tileY);
    if ((int) drawData.tileFrameX % 36 != 0)
      --key1.X;
    if ((int) drawData.tileFrameY % 54 != 0)
      key1.Y -= (int) drawData.tileFrameY / 18;
    if (!this._trainingDummyTileEntityPositions.ContainsKey(key1))
      this._trainingDummyTileEntityPositions[key1] = TileEntityType<TETrainingDummy>.Find(key1.X, key1.Y);
    TETrainingDummy result;
    if (this._trainingDummyTileEntityPositions[key1] == -1 || !TileEntity.TryGet<TETrainingDummy>(this._trainingDummyTileEntityPositions[key1], out result))
      return;
    int npc = result.npc;
    if (npc == -1)
      return;
    int num = Main.npc[npc].frame.Y / 55 * 54 + (int) drawData.tileFrameY;
    drawData.addFrY = num - (int) drawData.tileFrameY;
  }

  private static Color GetFinalLight(
    Tile tileCache,
    ushort typeCache,
    Color tileLight,
    Color tint)
  {
    int num1 = (int) ((double) ((int) tileLight.R * (int) tint.R) / (double) byte.MaxValue);
    int num2 = (int) ((double) ((int) tileLight.G * (int) tint.G) / (double) byte.MaxValue);
    int num3 = (int) ((double) ((int) tileLight.B * (int) tint.B) / (double) byte.MaxValue);
    if (num1 > (int) byte.MaxValue)
      num1 = (int) byte.MaxValue;
    if (num2 > (int) byte.MaxValue)
      num2 = (int) byte.MaxValue;
    if (num3 > (int) byte.MaxValue)
      num3 = (int) byte.MaxValue;
    int num4 = num3 << 16 /*0x10*/;
    int num5 = num2 << 8;
    tileLight.PackedValue = (uint) (num1 | num5 | num4 | -16777216 /*0xFF000000*/);
    if (tileCache.fullbrightBlock())
      tileLight = Color.White;
    if (tileCache.inActive())
      tileLight = tileCache.actColor(tileLight);
    else if (TileDrawing.ShouldTileShine(typeCache, tileCache.frameX))
      tileLight = Main.shine(tileLight, (int) typeCache);
    return tileLight;
  }

  private static void GetFinalLight(
    Tile tileCache,
    ushort typeCache,
    ref Vector3 tileLight,
    ref Vector3 tint)
  {
    tileLight *= tint;
    if (tileCache.inActive())
    {
      tileCache.actColor(ref tileLight);
    }
    else
    {
      if (!TileDrawing.ShouldTileShine(typeCache, tileCache.frameX))
        return;
      Main.shine(ref tileLight, (int) typeCache);
    }
  }

  private static bool ShouldTileShine(ushort type, short frameX)
  {
    if ((double) Main.shimmerAlpha > 0.0 && Main.tileSolid[(int) type] || type == (ushort) 165)
      return true;
    if (!Main.tileShine2[(int) type])
      return false;
    switch (type)
    {
      case 21:
      case 441:
        return frameX >= (short) 36 && frameX < (short) 178;
      case 467:
      case 468:
        return frameX >= (short) 144 /*0x90*/ && frameX < (short) 178;
      default:
        return true;
    }
  }

  private static bool IsTileDangerous(Player localPlayer, Tile tileCache, ushort typeCache)
  {
    int num;
    if (typeCache != (ushort) 135 && typeCache != (ushort) 137 && !TileID.Sets.Boulders[(int) typeCache])
    {
      switch (typeCache)
      {
        case 85:
        case 141:
        case 210:
        case 411:
        case 442:
        case 443:
        case 444:
        case 485:
        case 654:
          break;
        case 314:
          num = Minecart.IsPressurePlate(tileCache) ? 1 : 0;
          goto label_5;
        default:
          num = 0;
          goto label_5;
      }
    }
    num = 1;
label_5:
    bool flag = ((((num != 0 ? 1 : 0) | (!Main.getGoodWorld ? 0 : (typeCache == (ushort) 230 ? 1 : 0))) != 0 ? 1 : 0) | (!Main.dontStarveWorld ? 0 : (typeCache == (ushort) 80 /*0x50*/ ? 1 : 0))) != 0;
    if (tileCache.slope() == (byte) 0 && !tileCache.inActive())
    {
      flag = flag || typeCache == (ushort) 32 /*0x20*/ || typeCache == (ushort) 69 || typeCache == (ushort) 48 /*0x30*/ || typeCache == (ushort) 232 || typeCache == (ushort) 352 || typeCache == (ushort) 483 || typeCache == (ushort) 482 || typeCache == (ushort) 481 || typeCache == (ushort) 51 || typeCache == (ushort) 229;
      if (!localPlayer.fireWalk)
        flag = flag || typeCache == (ushort) 37 || typeCache == (ushort) 58 || typeCache == (ushort) 76;
      if (!localPlayer.iceSkate)
        flag = flag || typeCache == (ushort) 162;
    }
    return flag;
  }

  private bool IsTileDrawLayerSolid(ushort typeCache)
  {
    return TileID.Sets.DrawTileInSolidLayer[(int) typeCache].HasValue ? TileID.Sets.DrawTileInSolidLayer[(int) typeCache].Value : this._tileSolid[(int) typeCache];
  }

  private void GetTileOutlineInfo(
    int x,
    int y,
    ushort typeCache,
    ref Color tileLight,
    ref Texture2D highlightTexture,
    ref Color highlightColor)
  {
    bool actuallySelected;
    if (!Main.InSmartCursorHighlightArea(x, y, out actuallySelected))
      return;
    int averageTileLighting = ((int) tileLight.R + (int) tileLight.G + (int) tileLight.B) / 3;
    if (averageTileLighting <= 10)
      return;
    highlightTexture = TextureAssets.HighlightMask[(int) typeCache].Value;
    highlightColor = Colors.GetSelectionGlowColor(actuallySelected, averageTileLighting);
  }

  private void DrawPartialLiquid(
    bool behindBlocks,
    Tile tileCache,
    ref Vector2 position,
    ref Rectangle liquidSize,
    int liquidType,
    ref VertexColors colors)
  {
    int num = (int) tileCache.slope();
    bool flag = !TileID.Sets.BlocksWaterDrawingBehindSelf[(int) tileCache.type];
    if (!behindBlocks)
      flag = false;
    if (flag || num == 0)
    {
      Main.tileBatch.Draw(TextureAssets.Liquid[liquidType].Value, position, new Rectangle?(liquidSize), colors, new Vector2(), 1f, SpriteEffects.None);
    }
    else
    {
      liquidSize.X += 18 * (num - 1);
      switch (num)
      {
        case 1:
          Main.tileBatch.Draw(TextureAssets.LiquidSlope[liquidType].Value, position, new Rectangle?(liquidSize), colors, Vector2.Zero, 1f, SpriteEffects.None);
          break;
        case 2:
          Main.tileBatch.Draw(TextureAssets.LiquidSlope[liquidType].Value, position, new Rectangle?(liquidSize), colors, Vector2.Zero, 1f, SpriteEffects.None);
          break;
        case 3:
          Main.tileBatch.Draw(TextureAssets.LiquidSlope[liquidType].Value, position, new Rectangle?(liquidSize), colors, Vector2.Zero, 1f, SpriteEffects.None);
          break;
        case 4:
          Main.tileBatch.Draw(TextureAssets.LiquidSlope[liquidType].Value, position, new Rectangle?(liquidSize), colors, Vector2.Zero, 1f, SpriteEffects.None);
          break;
      }
    }
  }

  private bool InAPlaceWithWind(int x, int y, int width, int height)
  {
    return WorldGen.InAPlaceWithWind(x, y, width, height);
  }

  private void GetTileDrawData(
    int x,
    int y,
    Tile tileCache,
    ushort typeCache,
    ref short tileFrameX,
    ref short tileFrameY,
    out int tileWidth,
    out int tileHeight,
    out int tileTop,
    out int halfBrickHeight,
    out int addFrX,
    out int addFrY,
    out SpriteEffects tileSpriteEffect,
    out Texture2D glowTexture,
    out Rectangle glowSourceRect,
    out Color glowColor)
  {
    tileTop = 0;
    tileWidth = 16 /*0x10*/;
    tileHeight = 16 /*0x10*/;
    halfBrickHeight = 0;
    addFrY = Main.tileFrame[(int) typeCache] * 38;
    addFrX = 0;
    tileSpriteEffect = SpriteEffects.None;
    glowTexture = (Texture2D) null;
    glowSourceRect = Rectangle.Empty;
    glowColor = Color.Transparent;
    Color color = Lighting.GetColor(x, y);
    switch (typeCache)
    {
      case 3:
      case 24:
      case 61:
      case 71:
      case 110:
      case 201:
      case 637:
      case 703:
        tileHeight = 20;
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 4:
        tileWidth = 20;
        tileHeight = 20;
        if (WorldGen.SolidTile(x, y - 1))
        {
          tileTop = 4;
          break;
        }
        break;
      case 5:
        tileWidth = 20;
        tileHeight = 20;
        int treeBiome = TileDrawing.GetTreeBiome(x, y, (int) tileFrameX, (int) tileFrameY);
        tileFrameX += (short) (176 /*0xB0*/ * (treeBiome + 1));
        break;
      case 12:
      case 31 /*0x1F*/:
      case 96 /*0x60*/:
      case 639:
      case 665:
      case 696:
        addFrY = Main.tileFrame[(int) typeCache] * 36;
        break;
      case 14:
      case 21:
      case 411:
      case 467:
      case 469:
        if (tileFrameY == (short) 18)
        {
          tileHeight = 18;
          break;
        }
        break;
      case 15:
      case 497:
        if ((int) tileFrameY % 40 == 18)
        {
          tileHeight = 18;
          break;
        }
        break;
      case 16 /*0x10*/:
      case 17:
      case 26:
      case 32 /*0x20*/:
      case 69:
      case 72:
      case 77:
      case 124:
      case 137:
      case 138:
      case 352:
      case 462:
      case 487:
      case 488:
      case 574:
      case 575:
      case 576:
      case 577:
      case 578:
      case 664:
      case 695:
      case 704:
      case 712:
      case 713:
      case 714:
      case 715:
      case 716:
        tileHeight = 18;
        break;
      case 18:
        int num1 = (int) tileFrameX / 2016;
        addFrX -= 2016 * num1;
        addFrY += 20 * num1;
        break;
      case 20:
      case 590:
      case 595:
        tileHeight = 18;
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 27:
        if ((int) tileFrameY % 74 == 54)
        {
          tileHeight = 18;
          break;
        }
        break;
      case 28:
      case 105:
      case 470:
      case 475:
      case 506:
      case 547:
      case 548:
      case 552:
      case 560:
      case 597:
      case 613:
      case 621:
      case 622:
      case 623:
      case 653:
      case 699:
        tileTop = 2;
        break;
      case 33:
      case 49:
      case 174:
      case 372:
      case 646:
        tileHeight = 20;
        tileTop = -4;
        break;
      case 36:
        tileTop = 2;
        break;
      case 52:
      case 62:
      case 115:
      case 205:
      case 382:
      case 528:
      case 636:
      case 638:
        tileTop = -2;
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 73:
      case 74:
      case 113:
        tileTop = -12;
        tileHeight = 32 /*0x20*/;
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 78:
      case 85:
      case 133:
      case 134:
      case 173:
      case 210:
      case 233:
      case 254:
      case 283:
      case 378:
      case 457:
      case 466:
      case 520:
      case 651:
      case 652:
        tileTop = 2;
        break;
      case 79:
        tileHeight = 18;
        int num2 = (int) tileFrameY / 2016;
        addFrY -= 2016 * num2;
        addFrX += 144 /*0x90*/ * num2;
        break;
      case 80 /*0x50*/:
      case 142:
      case 143:
        tileTop = 2;
        break;
      case 81:
        tileTop -= 8;
        tileHeight = 26;
        tileWidth = 24;
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 82:
      case 83:
      case 84:
        tileHeight = 20;
        tileTop = -2;
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 89:
        tileTop = 2;
        break;
      case 90:
        int num3 = (int) tileFrameY / 2016;
        addFrY -= 2016 * num3;
        addFrX += 144 /*0x90*/ * num3;
        break;
      case 100:
        tileTop = 2;
        int num4 = (int) tileFrameY / 2016;
        addFrY -= 2016 * num4;
        addFrX += 72 * num4;
        break;
      case 102:
        tileTop = 2;
        break;
      case 106:
        addFrY = Main.tileFrame[(int) typeCache] * 54;
        break;
      case 129:
        addFrY = 0;
        if (tileFrameX >= (short) 324)
        {
          int num5 = ((int) tileFrameX - 324) / 18;
          int num6 = (num5 + Main.tileFrame[(int) typeCache]) % 6 - num5;
          addFrX = num6 * 18;
          break;
        }
        break;
      case 132:
      case 135:
        tileTop = 2;
        tileHeight = 18;
        break;
      case 136:
        if (tileFrameX == (short) 0)
        {
          tileTop = 2;
          break;
        }
        break;
      case 139:
        tileTop = 2;
        int num7 = (int) tileFrameY / 2016;
        addFrY -= 2016 * num7;
        addFrX += 72 * num7;
        break;
      case 172:
      case 376:
        if ((int) tileFrameY % 38 == 18)
        {
          tileHeight = 18;
          break;
        }
        break;
      case 178:
        if (tileFrameY <= (short) 36)
        {
          tileTop = 2;
          break;
        }
        break;
      case 184:
        tileWidth = 20;
        if (tileFrameY <= (short) 36)
        {
          tileTop = 2;
          break;
        }
        if (tileFrameY <= (short) 108)
        {
          tileTop = -2;
          break;
        }
        break;
      case 185:
      case 186:
      case 187:
        tileTop = 2;
        switch (typeCache)
        {
          case 185:
            Main.tileShine2[185] = tileFrameY == (short) 18 && tileFrameX >= (short) 576 && tileFrameX <= (short) 882;
            if (tileFrameY == (short) 18)
            {
              int num8 = (int) tileFrameX / 1908;
              addFrX -= 1908 * num8;
              addFrY += 18 * num8;
              break;
            }
            break;
          case 186:
            Main.tileShine2[186] = tileFrameX >= (short) 864 && tileFrameX <= (short) 1170;
            break;
          case 187:
            int num9 = (int) tileFrameX / 1890;
            addFrX -= 1890 * num9;
            addFrY += 36 * num9;
            break;
        }
        break;
      case 207:
        tileTop = 2;
        if (tileFrameY >= (short) 72)
        {
          addFrY = Main.tileFrame[(int) typeCache];
          int num10 = x;
          if ((int) tileFrameX % 36 != 0)
            --num10;
          addFrY += num10 % 6;
          if (addFrY >= 6)
            addFrY -= 6;
          addFrY *= 72;
          break;
        }
        addFrY = 0;
        break;
      case 217:
      case 218:
      case 564:
        addFrY = Main.tileFrame[(int) typeCache] * 36;
        tileTop = 2;
        break;
      case 219:
      case 220:
      case 642:
        addFrY = Main.tileFrame[(int) typeCache] * 54;
        tileTop = 2;
        break;
      case 227:
        tileWidth = 32 /*0x20*/;
        tileHeight = 38;
        if (tileFrameX == (short) 238)
          tileTop -= 6;
        else
          tileTop -= 20;
        if (tileFrameX == (short) 204)
        {
          bool evil;
          bool good;
          bool crimson;
          WorldGen.GetCactusType(x, y, (int) tileFrameX, (int) tileFrameY, out evil, out good, out crimson);
          if (good)
            tileFrameX += (short) 238;
          if (evil)
            tileFrameX += (short) 204;
          if (crimson)
            tileFrameX += (short) 272;
        }
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 228:
      case 231:
      case 243:
      case 247:
        tileTop = 2;
        addFrY = Main.tileFrame[(int) typeCache] * 54;
        break;
      case 235:
        addFrY = Main.tileFrame[(int) typeCache] * 18;
        break;
      case 238:
        tileTop = 2;
        addFrY = Main.tileFrame[(int) typeCache] * 36;
        break;
      case 244:
        tileTop = 2;
        addFrY = tileFrameX >= (short) 54 ? 0 : Main.tileFrame[(int) typeCache] * 36;
        break;
      case 270:
      case 271:
      case 581:
        int num11 = Main.tileFrame[(int) typeCache] + x % 6;
        if (x % 2 == 0)
          num11 += 3;
        if (x % 3 == 0)
          num11 += 3;
        if (x % 4 == 0)
          num11 += 3;
        while (num11 > 5)
          num11 -= 6;
        addFrX = num11 * 18;
        addFrY = 0;
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 272:
        addFrY = 0;
        break;
      case 275:
      case 276:
      case 277:
      case 278:
      case 279:
      case 280:
      case 281:
      case 296:
      case 297:
      case 309:
      case 358:
      case 359:
      case 413:
      case 414:
      case 542:
      case 550:
      case 551:
      case 553:
      case 554:
      case 558:
      case 559:
      case 599:
      case 600:
      case 601:
      case 602:
      case 603:
      case 604:
      case 605:
      case 606:
      case 607:
      case 608:
      case 609:
      case 610:
      case 611:
      case 612:
      case 632:
      case 640:
      case 643:
      case 644:
      case 645:
      case 710:
        tileTop = 2;
        Main.critterCage = true;
        int bigAnimalCageFrame = this.GetBigAnimalCageFrame(x, y, (int) tileFrameX, (int) tileFrameY);
        if (typeCache <= (ushort) 542)
        {
          if (typeCache <= (ushort) 309)
          {
            switch ((int) typeCache - 275)
            {
              case 0:
                goto label_272;
              case 1:
                goto label_275;
              case 2:
                addFrY = Main.mallardCageFrame[bigAnimalCageFrame] * 54;
                goto label_344;
              case 3:
                addFrY = Main.duckCageFrame[bigAnimalCageFrame] * 54;
                goto label_344;
              case 4:
                break;
              case 5:
                addFrY = Main.blueBirdCageFrame[bigAnimalCageFrame] * 54;
                goto label_344;
              case 6:
                addFrY = Main.redBirdCageFrame[bigAnimalCageFrame] * 54;
                goto label_344;
              default:
                if ((uint) typeCache - 296U > 1U)
                {
                  if (typeCache == (ushort) 309)
                  {
                    addFrY = Main.penguinCageFrame[bigAnimalCageFrame] * 54;
                    goto label_344;
                  }
                  goto label_344;
                }
                addFrY = Main.scorpionCageFrame[0, bigAnimalCageFrame] * 54;
                goto label_344;
            }
          }
          else if (typeCache <= (ushort) 359)
          {
            if (typeCache != (ushort) 358)
            {
              if (typeCache == (ushort) 359)
                goto label_272;
              break;
            }
          }
          else
          {
            if ((uint) typeCache - 413U > 1U)
            {
              if (typeCache == (ushort) 542)
              {
                addFrY = Main.owlCageFrame[bigAnimalCageFrame] * 54;
                break;
              }
              break;
            }
            goto label_275;
          }
          addFrY = Main.birdCageFrame[bigAnimalCageFrame] * 54;
          break;
        }
        if (typeCache <= (ushort) 612)
        {
          switch ((int) typeCache - 550)
          {
            case 0:
            case 1:
              addFrY = Main.turtleCageFrame[bigAnimalCageFrame] * 54;
              goto label_344;
            case 2:
            case 5:
            case 6:
            case 7:
              goto label_344;
            case 3:
              addFrY = Main.grebeCageFrame[bigAnimalCageFrame] * 54;
              goto label_344;
            case 4:
              addFrY = Main.seagullCageFrame[bigAnimalCageFrame] * 54;
              goto label_344;
            case 8:
            case 9:
              addFrY = Main.seahorseCageFrame[bigAnimalCageFrame] * 54;
              goto label_344;
            default:
              if ((uint) typeCache - 599U > 6U)
              {
                if ((uint) typeCache - 606U <= 6U)
                  goto label_275;
                goto label_344;
              }
              break;
          }
        }
        else
        {
          if (typeCache <= (ushort) 640)
          {
            if (typeCache != (ushort) 632 && typeCache != (ushort) 640)
              break;
          }
          else if ((uint) typeCache - 643U > 2U)
          {
            if (typeCache == (ushort) 710)
            {
              int num12 = Main.pufferfishCageFrame[bigAnimalCageFrame] / 33;
              addFrX = 108 * num12;
              addFrY = (Main.pufferfishCageFrame[bigAnimalCageFrame] - num12 * 33) * 54;
              break;
            }
            break;
          }
          addFrY = Main.macawCageFrame[bigAnimalCageFrame] * 54;
          break;
        }
label_272:
        addFrY = Main.bunnyCageFrame[bigAnimalCageFrame] * 54;
        break;
label_275:
        addFrY = Main.squirrelCageFrame[bigAnimalCageFrame] * 54;
        break;
      case 282:
      case 505:
      case 543:
        tileTop = 2;
        Main.critterCage = true;
        int waterAnimalCageFrame1 = this.GetWaterAnimalCageFrame(x, y, (int) tileFrameX, (int) tileFrameY);
        addFrY = Main.fishBowlFrame[waterAnimalCageFrame1] * 36;
        break;
      case 285:
      case 286:
      case 298:
      case 299:
      case 310:
      case 339:
      case 361:
      case 362:
      case 363:
      case 364:
      case 391:
      case 392:
      case 393:
      case 394:
      case 532:
      case 533:
      case 538:
      case 544:
      case 555:
      case 556:
      case 582:
      case 619:
      case 629:
        tileTop = 2;
        Main.critterCage = true;
        int smallAnimalCageFrame1 = this.GetSmallAnimalCageFrame(x, y, (int) tileFrameX, (int) tileFrameY);
        switch (typeCache)
        {
          case 285:
            addFrY = Main.snailCageFrame[smallAnimalCageFrame1] * 36;
            break;
          case 286:
          case 582:
            addFrY = Main.snail2CageFrame[smallAnimalCageFrame1] * 36;
            break;
          case 298:
          case 361:
            addFrY = Main.frogCageFrame[smallAnimalCageFrame1] * 36;
            break;
          case 299:
          case 363:
            addFrY = Main.mouseCageFrame[smallAnimalCageFrame1] * 36;
            break;
          case 310:
          case 364:
          case 391:
          case 619:
            addFrY = Main.wormCageFrame[smallAnimalCageFrame1] * 36;
            break;
          case 339:
          case 362:
            addFrY = Main.grasshopperCageFrame[smallAnimalCageFrame1] * 36;
            break;
          case 392:
          case 393:
          case 394:
            addFrY = Main.slugCageFrame[(int) typeCache - 392, smallAnimalCageFrame1] * 36;
            break;
          case 532:
            addFrY = Main.maggotCageFrame[smallAnimalCageFrame1] * 36;
            break;
          case 533:
            addFrY = Main.ratCageFrame[smallAnimalCageFrame1] * 36;
            break;
          case 538:
          case 544:
          case 629:
            addFrY = Main.ladybugCageFrame[smallAnimalCageFrame1] * 36;
            break;
          case 555:
          case 556:
            addFrY = Main.waterStriderCageFrame[smallAnimalCageFrame1] * 36;
            break;
        }
        break;
      case 288:
      case 289:
      case 290:
      case 291:
      case 292:
      case 293:
      case 294:
      case 295:
      case 360:
      case 580:
      case 620:
        tileTop = 2;
        Main.critterCage = true;
        int waterAnimalCageFrame2 = this.GetWaterAnimalCageFrame(x, y, (int) tileFrameX, (int) tileFrameY);
        int index1 = (int) typeCache - 288;
        if (typeCache == (ushort) 360 || typeCache == (ushort) 580 || typeCache == (ushort) 620)
          index1 = 8;
        addFrY = Main.butterflyCageFrame[index1, waterAnimalCageFrame2] * 36;
        break;
      case 300:
      case 301:
      case 302:
      case 303:
      case 304:
      case 305:
      case 306:
      case 307:
      case 308:
      case 354:
      case 355:
      case 499:
        addFrY = Main.tileFrame[(int) typeCache] * 54;
        tileTop = 2;
        break;
      case 316:
      case 317:
      case 318:
        tileTop = 2;
        Main.critterCage = true;
        int smallAnimalCageFrame2 = this.GetSmallAnimalCageFrame(x, y, (int) tileFrameX, (int) tileFrameY);
        int index2 = (int) typeCache - 316;
        addFrY = Main.jellyfishCageFrame[index2, smallAnimalCageFrame2] * 36;
        break;
      case 323:
        tileWidth = 20;
        tileHeight = 20;
        int palmTreeBiome = this.GetPalmTreeBiome(x, y);
        tileFrameY = (short) (22 * palmTreeBiome);
        break;
      case 324:
        tileWidth = 20;
        tileHeight = 20;
        tileTop = -2;
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 326:
      case 327:
      case 328:
      case 329:
      case 345:
      case 351:
      case 421:
      case 422:
      case 458:
      case 459:
      case 708:
        addFrY = Main.tileFrame[(int) typeCache] * 90;
        break;
      case 330:
      case 331:
      case 332:
      case 333:
        tileTop += 2;
        break;
      case 336:
      case 340:
      case 341:
      case 342:
      case 343:
      case 344:
        addFrY = Main.tileFrame[(int) typeCache] * 90;
        tileTop = 2;
        break;
      case 349:
        tileTop = 2;
        int num13 = (int) tileFrameX % 36;
        int num14 = (int) tileFrameY % 54;
        int frameData1;
        if (Animation.GetTemporaryFrame(x - num13 / 18, y - num14 / 18, out frameData1))
        {
          tileFrameX = (short) (36 * frameData1 + num13);
          break;
        }
        break;
      case 377:
        addFrY = Main.tileFrame[(int) typeCache] * 38;
        tileTop = 2;
        break;
      case 379:
        addFrY = Main.tileFrame[(int) typeCache] * 90;
        break;
      case 388:
      case 389:
        int num15 = 94;
        tileTop = -2;
        if ((int) tileFrameY == num15 - 20 || (int) tileFrameY == num15 * 2 - 20 || tileFrameY == (short) 0 || (int) tileFrameY == num15)
          tileHeight = 18;
        if (tileFrameY != (short) 0 && (int) tileFrameY != num15)
        {
          tileTop = 0;
          break;
        }
        break;
      case 390:
        addFrY = Main.tileFrame[(int) typeCache] * 36;
        break;
      case 405:
        tileHeight = 16 /*0x10*/;
        if (tileFrameY > (short) 0)
          tileHeight = 18;
        int num16 = Main.tileFrame[(int) typeCache];
        if (tileFrameX >= (short) 54)
          num16 = 0;
        addFrY = num16 * 38;
        break;
      case 406:
        tileHeight = 16 /*0x10*/;
        if ((int) tileFrameY % 54 >= 36)
          tileHeight = 18;
        int num17 = Main.tileFrame[(int) typeCache];
        if (tileFrameY >= (short) 108)
          num17 = 6 - (int) tileFrameY / 54;
        else if (tileFrameY >= (short) 54)
          num17 = Main.tileFrame[(int) typeCache] - 1;
        addFrY = num17 * 56;
        addFrY += (int) tileFrameY / 54 * 2;
        break;
      case 410:
        if (tileFrameY == (short) 36)
          tileHeight = 18;
        if (tileFrameY >= (short) 56)
        {
          addFrY = Main.tileFrame[(int) typeCache];
          addFrY *= 56;
          break;
        }
        addFrY = 0;
        break;
      case 412:
        addFrY = 0;
        tileTop = 2;
        break;
      case 428:
        tileTop += 4;
        if (PressurePlateHelper.PressurePlatesPressed.ContainsKey(new Point(x, y)))
        {
          addFrX += 18;
          break;
        }
        break;
      case 441:
      case 468:
        if (tileFrameY == (short) 18)
          tileHeight = 18;
        int num18 = (int) tileFrameX % 36;
        int num19 = (int) tileFrameY % 38;
        int frameData2;
        if (Animation.GetTemporaryFrame(x - num18 / 18, y - num19 / 18, out frameData2))
        {
          tileFrameY = (short) (38 * frameData2 + num19);
          break;
        }
        break;
      case 442:
        tileWidth = 20;
        tileHeight = 20;
        switch ((int) tileFrameX / 22)
        {
          case 1:
            tileTop = -4;
            break;
          case 2:
            tileTop = -2;
            tileWidth = 24;
            break;
          case 3:
            tileTop = -2;
            break;
        }
        break;
      case 443:
        tileTop = (int) tileFrameX / 36 < 2 ? 2 : -2;
        break;
      case 452:
        int num20 = Main.tileFrame[(int) typeCache];
        if (tileFrameX >= (short) 54)
          num20 = 0;
        addFrY = num20 * 54;
        break;
      case 453:
        int num21 = (Main.tileFrameCounter[(int) typeCache] / 20 + (y - (int) tileFrameY / 18 + x)) % 3;
        addFrY = num21 * 54;
        break;
      case 454:
        addFrY = Main.tileFrame[(int) typeCache] * 54;
        break;
      case 455:
        addFrY = 0;
        tileTop = 2;
        int num22 = 1 + Main.tileFrame[(int) typeCache];
        if (!BirthdayParty.PartyIsUp)
          num22 = 0;
        addFrY = num22 * 54;
        break;
      case 456:
        int num23 = (Main.tileFrameCounter[(int) typeCache] / 20 + (y - (int) tileFrameY / 18 + (x - (int) tileFrameX / 18))) % 4;
        addFrY = num23 * 54;
        break;
      case 463:
      case 464:
        addFrY = Main.tileFrame[(int) typeCache] * 72;
        tileTop = 2;
        break;
      case 476:
        tileWidth = 20;
        tileHeight = 18;
        break;
      case 480:
      case 509:
      case 657:
      case 720:
      case 721:
      case 725:
        tileTop = 2;
        if (tileFrameY >= (short) 54)
        {
          addFrY = Main.tileFrame[(int) typeCache];
          addFrY *= 54;
          break;
        }
        addFrY = 0;
        break;
      case 485:
        tileTop = 2;
        int num24 = (Main.tileFrameCounter[(int) typeCache] / 5 + (y - (int) tileFrameY / 18 + (x - (int) tileFrameX / 18))) % 4;
        addFrY = num24 * 36;
        break;
      case 489:
        tileTop = 2;
        int y1 = y - (int) tileFrameY / 18;
        int x1 = x - (int) tileFrameX / 18;
        if (this.InAPlaceWithWind(x1, y1, 2, 3))
        {
          int num25 = (Main.tileFrameCounter[(int) typeCache] / 5 + (y1 + x1)) % 16 /*0x10*/;
          addFrY = num25 * 54;
          break;
        }
        break;
      case 490:
        tileTop = 2;
        int y2 = y - (int) tileFrameY / 18;
        int num26 = this.InAPlaceWithWind(x - (int) tileFrameX / 18, y2, 2, 2) ? 1 : 0;
        int num27 = num26 != 0 ? Main.tileFrame[(int) typeCache] : 0;
        int num28 = 0;
        if (num26 != 0)
        {
          if ((double) Math.Abs(Main.WindForVisuals) > 0.5)
          {
            switch (Main.weatherVaneBobframe)
            {
              case 0:
                num28 = 0;
                break;
              case 1:
                num28 = 1;
                break;
              case 2:
                num28 = 2;
                break;
              case 3:
                num28 = 1;
                break;
              case 4:
                num28 = 0;
                break;
              case 5:
                num28 = -1;
                break;
              case 6:
                num28 = -2;
                break;
              case 7:
                num28 = -1;
                break;
            }
          }
          else
          {
            switch (Main.weatherVaneBobframe)
            {
              case 0:
                num28 = 0;
                break;
              case 1:
                num28 = 1;
                break;
              case 2:
                num28 = 0;
                break;
              case 3:
                num28 = -1;
                break;
              case 4:
                num28 = 0;
                break;
              case 5:
                num28 = 1;
                break;
              case 6:
                num28 = 0;
                break;
              case 7:
                num28 = -1;
                break;
            }
          }
        }
        int num29 = num27 + num28;
        if (num29 < 0)
          num29 += 12;
        int num30 = num29 % 12;
        addFrY = num30 * 36;
        break;
      case 491:
        tileTop = 2;
        addFrX = 54;
        break;
      case 493:
        if (tileFrameY == (short) 0)
        {
          int num31 = Main.tileFrameCounter[(int) typeCache];
          float num32 = Math.Abs(Main.WindForVisuals);
          int y3 = y - (int) tileFrameY / 18;
          int num33 = x - (int) tileFrameX / 18;
          if (!this.InAPlaceWithWind(x, y3, 1, 1))
            num32 = 0.0f;
          if ((double) num32 >= 0.10000000149011612)
          {
            if ((double) num32 < 0.5)
            {
              int num34 = (num31 / 20 + (y3 + num33)) % 6;
              int num35 = (double) Main.WindForVisuals >= 0.0 ? num34 + 1 : 6 - num34;
              addFrY = num35 * 36;
            }
            else
            {
              int num36 = (num31 / 10 + (y3 + num33)) % 6;
              int num37 = (double) Main.WindForVisuals >= 0.0 ? num36 + 7 : 12 - num36;
              addFrY = num37 * 36;
            }
          }
        }
        tileTop = 2;
        break;
      case 494:
        tileTop = 2;
        break;
      case 507:
      case 508:
        int num38 = 20;
        int num39 = (Main.tileFrameCounter[(int) typeCache] + x * 11 + y * 27) % (num38 * 8);
        addFrY = 90 * (num39 / num38);
        break;
      case 518:
        int num40 = (int) tileCache.liquid / 16 /*0x10*/ - 3;
        if (WorldGen.SolidTile(x, y - 1) && num40 > 8)
          num40 = 8;
        if (tileCache.liquid == (byte) 0)
        {
          Tile tileSafely = Framing.GetTileSafely(x, y + 1);
          if (tileSafely.nactive())
          {
            switch (tileSafely.blockType())
            {
              case 1:
                num40 = Math.Max(8, (int) tileSafely.liquid / 16 /*0x10*/) - 16 /*0x10*/;
                break;
              case 2:
              case 3:
                num40 -= 4;
                break;
            }
          }
        }
        tileTop -= num40;
        break;
      case 519:
        tileTop = 2;
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 521:
      case 522:
      case 523:
      case 524:
      case 525:
      case 526:
      case 527:
        tileTop = 2;
        Main.critterCage = true;
        int waterAnimalCageFrame3 = this.GetWaterAnimalCageFrame(x, y, (int) tileFrameX, (int) tileFrameY);
        int index3 = (int) typeCache - 521;
        addFrY = Main.dragonflyJarFrame[index3, waterAnimalCageFrame3] * 36;
        break;
      case 529:
        int num41 = y + 1;
        int num42 = x;
        int corruptCount1;
        int crimsonCount1;
        int hallowedCount1;
        WorldGen.GetBiomeInfluence(num42, num42, num41, num41, out corruptCount1, out crimsonCount1, out hallowedCount1);
        int num43 = corruptCount1;
        if (num43 < crimsonCount1)
          num43 = crimsonCount1;
        if (num43 < hallowedCount1)
          num43 = hallowedCount1;
        int num44 = corruptCount1 != 0 || crimsonCount1 != 0 || hallowedCount1 != 0 ? (hallowedCount1 != num43 ? (crimsonCount1 != num43 ? 4 : 3) : 2) : (x < WorldGen.beachDistance || x > Main.maxTilesX - WorldGen.beachDistance ? 1 : 0);
        addFrY += 34 * num44 - (int) tileFrameY;
        tileHeight = 32 /*0x20*/;
        tileTop = -14;
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 530:
        int num45 = y - (int) tileFrameY % 36 / 18 + 2;
        int startX = x - (int) tileFrameX % 54 / 18;
        int corruptCount2;
        int crimsonCount2;
        int hallowedCount2;
        WorldGen.GetBiomeInfluence(startX, startX + 3, num45, num45, out corruptCount2, out crimsonCount2, out hallowedCount2);
        int num46 = corruptCount2;
        if (num46 < crimsonCount2)
          num46 = crimsonCount2;
        if (num46 < hallowedCount2)
          num46 = hallowedCount2;
        int num47 = corruptCount2 != 0 || crimsonCount2 != 0 || hallowedCount2 != 0 ? (hallowedCount2 != num46 ? (crimsonCount2 != num46 ? 3 : 2) : 1) : 0;
        addFrY += 36 * num47;
        tileTop = 2;
        break;
      case 541:
        addFrY = this._shouldShowInvisibleBlocks ? 0 : 90;
        break;
      case 561:
        tileTop -= 2;
        tileHeight = 20;
        addFrY = (int) tileFrameY / 18 * 4;
        break;
      case 565:
        tileTop = 2;
        addFrY = tileFrameX >= (short) 36 ? 0 : Main.tileFrame[(int) typeCache] * 36;
        break;
      case 567:
        tileWidth = 26;
        tileHeight = 18;
        if (tileFrameY == (short) 0)
          tileTop = -2;
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 568:
      case 569:
      case 570:
        tileTop = 2;
        Main.critterCage = true;
        int waterAnimalCageFrame4 = this.GetWaterAnimalCageFrame(x, y, (int) tileFrameX, (int) tileFrameY);
        addFrY = Main.fairyJarFrame[waterAnimalCageFrame4] * 36;
        break;
      case 571:
        if (x % 2 == 0)
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
        tileTop = 2;
        break;
      case 572:
        int num48 = Main.tileFrame[(int) typeCache] + x % 4;
        while (num48 > 3)
          num48 -= 4;
        addFrX = num48 * 18;
        addFrY = 0;
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 579:
        tileWidth = 20;
        tileHeight = 20;
        tileTop -= 2;
        bool flag = (double) (x * 16 /*0x10*/ + 8) > (double) Main.LocalPlayer.Center.X;
        addFrY = tileFrameX <= (short) 0 ? (!flag ? 22 : 0) : (!flag ? 0 : 22);
        break;
      case 583:
      case 584:
      case 585:
      case 586:
      case 587:
      case 588:
      case 589:
      case 596:
      case 616:
      case 634:
        tileWidth = 20;
        tileHeight = 20;
        break;
      case 592:
        addFrY = Main.tileFrame[(int) typeCache] * 54;
        break;
      case 593:
        if (tileFrameX >= (short) 18)
          addFrX = -18;
        tileTop = 2;
        int frameData3;
        addFrY = !Animation.GetTemporaryFrame(x, y, out frameData3) ? (tileFrameX >= (short) 18 ? 0 : Main.tileFrame[(int) typeCache] * 18) : (int) (short) (18 * frameData3);
        break;
      case 594:
        if (tileFrameX >= (short) 36)
          addFrX = -36;
        tileTop = 2;
        int num49 = (int) tileFrameX % 36;
        int num50 = (int) tileFrameY % 36;
        int frameData4;
        addFrY = !Animation.GetTemporaryFrame(x - num49 / 18, y - num50 / 18, out frameData4) ? (tileFrameX >= (short) 36 ? 0 : Main.tileFrame[(int) typeCache] * 36) : (int) (short) (36 * frameData4);
        break;
      case 598:
        tileTop = 2;
        Main.critterCage = true;
        int waterAnimalCageFrame5 = this.GetWaterAnimalCageFrame(x, y, (int) tileFrameX, (int) tileFrameY);
        addFrY = Main.lavaFishBowlFrame[waterAnimalCageFrame5] * 36;
        break;
      case 614:
        addFrX = Main.tileFrame[(int) typeCache] * 54;
        addFrY = 0;
        tileTop = 2;
        break;
      case 615:
        tileHeight = 18;
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 617:
        tileTop = 2;
        tileFrameY %= (short) 144 /*0x90*/;
        tileFrameX %= (short) 54;
        break;
      case 624:
      case 700:
        tileWidth = 20;
        tileHeight = 16 /*0x10*/;
        tileTop += 2;
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 647:
      case 706:
        tileTop = 2;
        break;
      case 648:
        tileTop = 2;
        int num51 = (int) tileFrameX / 1890;
        addFrX -= 1890 * num51;
        addFrY += 36 * num51;
        break;
      case 649:
        tileTop = 2;
        int num52 = (int) tileFrameX / 1908;
        addFrX -= 1908 * num52;
        addFrY += 18 * num52;
        break;
      case 650:
        tileTop = 2;
        break;
      case 654:
        tileTop += 2;
        break;
      case 656:
      case 701:
        tileWidth = 24;
        tileHeight = 34;
        tileTop -= 16 /*0x10*/;
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 658:
        tileTop = 2;
        switch ((int) tileFrameY / 54)
        {
          case 1:
            addFrY = Main.tileFrame[(int) typeCache];
            addFrY *= 54;
            addFrY += 486;
            break;
          case 2:
            addFrY = Main.tileFrame[(int) typeCache];
            addFrY *= 54;
            addFrY += 972;
            break;
          default:
            addFrY = Main.tileFrame[(int) typeCache];
            addFrY *= 54;
            break;
        }
        break;
      case 660:
        int num53 = Main.tileFrame[(int) typeCache] + x % 5;
        if (x % 2 == 0)
          num53 += 3;
        if (x % 3 == 0)
          num53 += 3;
        if (x % 4 == 0)
          num53 += 3;
        while (num53 > 4)
          num53 -= 5;
        addFrX = num53 * 18;
        addFrY = 0;
        if (x % 2 == 0)
        {
          tileSpriteEffect = SpriteEffects.FlipHorizontally;
          break;
        }
        break;
      case 698:
        tileWidth = 36;
        int num54 = (int) tileFrameX / 18;
        tileFrameX = (short) (num54 * 38);
        tileHeight = 44;
        break;
      case 705:
        tileTop = 2;
        break;
      case 711:
        if (tileFrameX > (short) 0)
          tileWidth = 18;
        tileHeight = 20;
        glowTexture = TextureAssets.Tile[711].Value;
        glowSourceRect = new Rectangle((int) tileFrameX + addFrX, (int) tileFrameY + addFrY, tileWidth, tileHeight);
        break;
      case 719:
        int num55 = (x + y + (int) ((double) Main.GlobalTimeWrappedHourly * 15.0)) % 14;
        int num56 = num55 / 4;
        int num57 = num55 % 4;
        addFrX += 288 * num56;
        addFrY += 270 * num57;
        break;
      case 726:
        tileFrameX = (short) 0;
        tileFrameY = (short) 0;
        tileWidth = 20;
        tileHeight = 20;
        break;
      case 733:
        tileTop = 2;
        if (tileFrameY < (short) 54)
          addFrX += 54;
        tileFrameX %= (short) 54;
        tileFrameY %= (short) 54;
        break;
      case 739:
      case 748:
        int num58 = Main.tileFrame[(int) typeCache];
        addFrY = num58 * 90;
        break;
      case 751:
        tileHeight = 46;
        tileWidth = 56;
        int num59 = (x + y * 2) % 7;
        tileFrameY += (short) (num59 * 46);
        break;
      case 752:
        tileHeight = 38;
        tileWidth = 36;
        tileTop = 2;
        break;
    }
label_344:
    if (TileID.Sets.Campfires[(int) tileCache.type])
    {
      addFrY = tileFrameY >= (short) 36 ? 252 : Main.tileFrame[(int) typeCache] * 36;
      tileTop = 2;
    }
    if (tileCache.halfBrick())
      halfBrickHeight = 8;
    switch (typeCache)
    {
      case 10:
        int num60 = (int) tileFrameY / 54;
        if (tileFrameX >= (short) 54 || num60 != 32 /*0x20*/)
          break;
        glowTexture = TextureAssets.GlowMask[57].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 54, tileWidth, tileHeight);
        glowColor = this._martianGlow;
        break;
      case 11:
        int num61 = (int) tileFrameY / 54;
        if (tileFrameX >= (short) 54)
          break;
        if (num61 == 32 /*0x20*/)
        {
          glowTexture = TextureAssets.GlowMask[58].Value;
          glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 54, tileWidth, tileHeight);
          glowColor = this._martianGlow;
        }
        if (num61 != 33)
          break;
        glowTexture = TextureAssets.GlowMask[119].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 54, tileWidth, tileHeight);
        glowColor = this._meteorGlow;
        break;
      case 14:
        int num62 = (int) tileFrameX / 54;
        if (num62 == 31 /*0x1F*/)
        {
          glowTexture = TextureAssets.GlowMask[67].Value;
          glowSourceRect = new Rectangle((int) tileFrameX % 54, (int) tileFrameY, tileWidth, tileHeight);
          glowColor = this._martianGlow;
        }
        if (num62 != 32 /*0x20*/)
          break;
        glowTexture = TextureAssets.GlowMask[124].Value;
        glowSourceRect = new Rectangle((int) tileFrameX % 54, (int) tileFrameY, tileWidth, tileHeight);
        glowColor = this._meteorGlow;
        break;
      case 15:
      case 497:
        int num63 = (int) tileFrameY / 40;
        int num64 = num63 / 51;
        addFrY -= 2040 * num64;
        addFrX += 36 * num64;
        if (typeCache != (ushort) 15)
          break;
        if (num63 == 32 /*0x20*/)
        {
          glowTexture = TextureAssets.GlowMask[54].Value;
          glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 40, tileWidth, tileHeight);
          glowColor = this._martianGlow;
        }
        if (num63 != 33)
          break;
        glowTexture = TextureAssets.GlowMask[116].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 40, tileWidth, tileHeight);
        glowColor = this._meteorGlow;
        break;
      case 18:
        int num65 = (int) tileFrameX / 36;
        if (num65 == 27)
        {
          glowTexture = TextureAssets.GlowMask[69].Value;
          glowSourceRect = new Rectangle((int) tileFrameX % 36, (int) tileFrameY, tileWidth, tileHeight);
          glowColor = this._martianGlow;
        }
        if (num65 != 28)
          break;
        glowTexture = TextureAssets.GlowMask[125].Value;
        glowSourceRect = new Rectangle((int) tileFrameX % 36, (int) tileFrameY, tileWidth, tileHeight);
        glowColor = this._meteorGlow;
        break;
      case 19:
        int num66 = (int) tileFrameY / 18;
        if (num66 == 26)
        {
          glowTexture = TextureAssets.GlowMask[65].Value;
          glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 18, tileWidth, tileHeight);
          glowColor = this._martianGlow;
        }
        if (num66 != 27)
          break;
        glowTexture = TextureAssets.GlowMask[112 /*0x70*/].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 18, tileWidth, tileHeight);
        glowColor = this._meteorGlow;
        break;
      case 21:
      case 467:
        int num67 = (int) tileFrameX / 36;
        if (num67 == 48 /*0x30*/)
        {
          glowTexture = TextureAssets.GlowMask[56].Value;
          glowSourceRect = new Rectangle((int) tileFrameX % 36, (int) tileFrameY, tileWidth, tileHeight);
          glowColor = this._martianGlow;
        }
        if (num67 != 49)
          break;
        glowTexture = TextureAssets.GlowMask[117].Value;
        glowSourceRect = new Rectangle((int) tileFrameX % 36, (int) tileFrameY, tileWidth, tileHeight);
        glowColor = this._meteorGlow;
        break;
      case 33:
        if ((int) tileFrameX / 18 != 0 || (int) tileFrameY / 22 != 26)
          break;
        glowTexture = TextureAssets.GlowMask[61].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 22, tileWidth, tileHeight);
        glowColor = this._martianGlow;
        break;
      case 34:
        if ((int) tileFrameX / 54 != 0 || (int) tileFrameY / 54 != 33)
          break;
        glowTexture = TextureAssets.GlowMask[55].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 54, tileWidth, tileHeight);
        glowColor = this._martianGlow;
        break;
      case 42:
        int num68 = (int) tileFrameY / 36;
        int num69 = (int) tileFrameY / 2016;
        addFrY -= 2016 * num69;
        addFrX += 36 * num69;
        if (num68 != 33)
          break;
        glowTexture = TextureAssets.GlowMask[63 /*0x3F*/].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 36, tileWidth, tileHeight);
        glowColor = this._martianGlow;
        break;
      case 79:
        int num70 = (int) tileFrameY / 36;
        if (num70 == 27)
        {
          glowTexture = TextureAssets.GlowMask[53].Value;
          glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 36, tileWidth, tileHeight);
          glowColor = this._martianGlow;
        }
        if (num70 != 28)
          break;
        glowTexture = TextureAssets.GlowMask[114].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 36, tileWidth, tileHeight);
        glowColor = this._meteorGlow;
        break;
      case 87:
        int num71 = (int) tileFrameX / 54;
        int num72 = (int) tileFrameX / 1998;
        addFrX -= 1998 * num72;
        addFrY += 36 * num72;
        if (num71 == 26)
        {
          glowTexture = TextureAssets.GlowMask[64 /*0x40*/].Value;
          glowSourceRect = new Rectangle((int) tileFrameX % 54, (int) tileFrameY, tileWidth, tileHeight);
          glowColor = this._martianGlow;
        }
        if (num71 != 27)
          break;
        glowTexture = TextureAssets.GlowMask[121].Value;
        glowSourceRect = new Rectangle((int) tileFrameX % 54, (int) tileFrameY, tileWidth, tileHeight);
        glowColor = this._meteorGlow;
        break;
      case 88:
        int num73 = (int) tileFrameX / 54;
        int num74 = (int) tileFrameX / 1998;
        addFrX -= 1998 * num74;
        addFrY += 36 * num74;
        if (num73 == 24)
        {
          glowTexture = TextureAssets.GlowMask[59].Value;
          glowSourceRect = new Rectangle((int) tileFrameX % 54, (int) tileFrameY, tileWidth, tileHeight);
          glowColor = this._martianGlow;
        }
        if (num73 != 25)
          break;
        glowTexture = TextureAssets.GlowMask[120].Value;
        glowSourceRect = new Rectangle((int) tileFrameX % 54, (int) tileFrameY, tileWidth, tileHeight);
        glowColor = this._meteorGlow;
        break;
      case 89:
        int num75 = (int) tileFrameX / 54;
        int num76 = (int) tileFrameX / 1998;
        addFrX -= 1998 * num76;
        addFrY += 36 * num76;
        if (num75 == 29)
        {
          glowTexture = TextureAssets.GlowMask[66].Value;
          glowSourceRect = new Rectangle((int) tileFrameX % 54, (int) tileFrameY, tileWidth, tileHeight);
          glowColor = this._martianGlow;
        }
        if (num75 != 30)
          break;
        glowTexture = TextureAssets.GlowMask[123].Value;
        glowSourceRect = new Rectangle((int) tileFrameX % 54, (int) tileFrameY, tileWidth, tileHeight);
        glowColor = this._meteorGlow;
        break;
      case 90:
        int num77 = (int) tileFrameY / 36;
        if (num77 == 27)
        {
          glowTexture = TextureAssets.GlowMask[52].Value;
          glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 36, tileWidth, tileHeight);
          glowColor = this._martianGlow;
        }
        if (num77 != 28)
          break;
        glowTexture = TextureAssets.GlowMask[113].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 36, tileWidth, tileHeight);
        glowColor = this._meteorGlow;
        break;
      case 93:
        int num78 = (int) tileFrameY / 54;
        int num79 = (int) tileFrameY / 1998;
        addFrY -= 1998 * num79;
        addFrX += 36 * num79;
        tileTop += 2;
        if (num78 != 27)
          break;
        glowTexture = TextureAssets.GlowMask[62].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 54, tileWidth, tileHeight);
        glowColor = this._martianGlow;
        break;
      case 100:
        if ((int) tileFrameX / 36 != 0 || (int) tileFrameY / 36 != 27)
          break;
        glowTexture = TextureAssets.GlowMask[68].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 36, tileWidth, tileHeight);
        glowColor = this._martianGlow;
        break;
      case 101:
        int num80 = (int) tileFrameX / 54;
        int num81 = (int) tileFrameX / 1998;
        addFrX -= 1998 * num81;
        addFrY += 72 * num81;
        if (num80 == 28)
        {
          glowTexture = TextureAssets.GlowMask[60].Value;
          glowSourceRect = new Rectangle((int) tileFrameX % 54, (int) tileFrameY, tileWidth, tileHeight);
          glowColor = this._martianGlow;
        }
        if (num80 != 29)
          break;
        glowTexture = TextureAssets.GlowMask[115].Value;
        glowSourceRect = new Rectangle((int) tileFrameX % 54, (int) tileFrameY, tileWidth, tileHeight);
        glowColor = this._meteorGlow;
        break;
      case 104:
        int num82 = (int) tileFrameX / 36;
        int num83 = (int) tileFrameX / 2016;
        addFrX -= 2016 * num83;
        addFrY += 90 * num83;
        tileTop = 2;
        if (num82 == 24)
        {
          glowTexture = TextureAssets.GlowMask[51].Value;
          glowSourceRect = new Rectangle((int) tileFrameX % 36, (int) tileFrameY, tileWidth, tileHeight);
          glowColor = this._martianGlow;
        }
        if (num82 != 25)
          break;
        glowTexture = TextureAssets.GlowMask[118].Value;
        glowSourceRect = new Rectangle((int) tileFrameX % 36, (int) tileFrameY, tileWidth, tileHeight);
        glowColor = this._meteorGlow;
        break;
      case 172:
        int num84 = (int) tileFrameY / 38;
        int num85 = (int) tileFrameY / 2014;
        addFrY -= 2014 * num85;
        addFrX += 36 * num85;
        if (num84 == 28)
        {
          glowTexture = TextureAssets.GlowMask[88].Value;
          glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 38, tileWidth, tileHeight);
          glowColor = this._martianGlow;
        }
        if (num84 != 29)
          break;
        glowTexture = TextureAssets.GlowMask[122].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY % 38, tileWidth, tileHeight);
        glowColor = this._meteorGlow;
        break;
      case 184:
        if (tileCache.frameX == (short) 110)
        {
          glowTexture = TextureAssets.GlowMask[(int) sbyte.MaxValue].Value;
          glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY, tileWidth, tileHeight);
          glowColor = this._lavaMossGlow;
        }
        if (tileCache.frameX == (short) 132)
        {
          glowTexture = TextureAssets.GlowMask[(int) sbyte.MaxValue].Value;
          glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY, tileWidth, tileHeight);
          glowColor = this._kryptonMossGlow;
        }
        if (tileCache.frameX == (short) 154)
        {
          glowTexture = TextureAssets.GlowMask[(int) sbyte.MaxValue].Value;
          glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY, tileWidth, tileHeight);
          glowColor = this._xenonMossGlow;
        }
        if (tileCache.frameX == (short) 176 /*0xB0*/)
        {
          glowTexture = TextureAssets.GlowMask[(int) sbyte.MaxValue].Value;
          glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY, tileWidth, tileHeight);
          glowColor = this._argonMossGlow;
        }
        if (tileCache.frameX == (short) 198)
        {
          glowTexture = TextureAssets.GlowMask[(int) sbyte.MaxValue].Value;
          glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY, tileWidth, tileHeight);
          glowColor = this._violetMossGlow;
        }
        if (tileCache.frameX != (short) 220)
          break;
        glowTexture = TextureAssets.GlowMask[(int) sbyte.MaxValue].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY, tileWidth, tileHeight);
        glowColor = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB);
        break;
      case 412:
        glowTexture = TextureAssets.GlowMask[202].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY + addFrY, tileWidth, tileHeight);
        glowColor = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        break;
      case 441:
      case 468:
        int num86 = (int) tileFrameX / 36;
        if (num86 == 48 /*0x30*/)
        {
          glowTexture = TextureAssets.GlowMask[56].Value;
          glowSourceRect = new Rectangle((int) tileFrameX % 36, (int) tileFrameY, tileWidth, tileHeight);
          glowColor = this._martianGlow;
        }
        if (num86 != 49)
          break;
        glowTexture = TextureAssets.GlowMask[117].Value;
        glowSourceRect = new Rectangle((int) tileFrameX % 36, (int) tileFrameY, tileWidth, tileHeight);
        glowColor = this._meteorGlow;
        break;
      case 463:
        glowTexture = TextureAssets.GlowMask[243].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY + addFrY, tileWidth, tileHeight);
        glowColor = new Color((int) sbyte.MaxValue, (int) sbyte.MaxValue, (int) sbyte.MaxValue, 0);
        break;
      case 564:
        if (tileCache.frameX < (short) 36)
        {
          glowTexture = TextureAssets.GlowMask[267].Value;
          glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY + addFrY, tileWidth, tileHeight);
          glowColor = new Color(200, 200, 200, 0) * ((float) Main.mouseTextColor / (float) byte.MaxValue);
        }
        addFrY = 0;
        break;
      case 568:
        glowTexture = TextureAssets.GlowMask[268].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY + addFrY, tileWidth, tileHeight);
        glowColor = Color.White;
        break;
      case 569:
        glowTexture = TextureAssets.GlowMask[269].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY + addFrY, tileWidth, tileHeight);
        glowColor = Color.White;
        break;
      case 570:
        glowTexture = TextureAssets.GlowMask[270].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY + addFrY, tileWidth, tileHeight);
        glowColor = Color.White;
        break;
      case 580:
        glowTexture = TextureAssets.GlowMask[289].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY + addFrY, tileWidth, tileHeight);
        glowColor = new Color(225, 110, 110, 0);
        break;
      case 634:
        glowTexture = TextureAssets.GlowMask[315].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY + addFrY, tileWidth, tileHeight);
        glowColor = Color.White;
        break;
      case 637:
        glowTexture = this.GetTileDrawTexture(tileCache, x, y);
        glowSourceRect = new Rectangle((int) tileFrameX + addFrX, (int) tileFrameY + addFrY, tileWidth, tileHeight);
        glowColor = Color.Lerp(Color.White, color, 0.75f);
        break;
      case 638:
        glowTexture = TextureAssets.GlowMask[327].Value;
        glowSourceRect = new Rectangle((int) tileFrameX + addFrX, (int) tileFrameY + addFrY, tileWidth, tileHeight - halfBrickHeight);
        glowColor = Color.Lerp(Color.White, color, 0.75f);
        break;
      case 656:
      case 701:
        glowTexture = TextureAssets.GlowMask[329].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY + addFrY, tileWidth, tileHeight);
        glowColor = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * ((float) Main.mouseTextColor / (float) byte.MaxValue);
        break;
      case 657:
        if (tileFrameY < (short) 54)
          break;
        glowTexture = TextureAssets.GlowMask[330].Value;
        glowSourceRect = new Rectangle((int) tileFrameX, (int) tileFrameY + addFrY, tileWidth, tileHeight);
        glowColor = Color.White;
        break;
    }
  }

  private bool IsWindBlocked(int x, int y)
  {
    Tile tile = Main.tile[x, y];
    return tile == null || tile.wall > (ushort) 0 && !WallID.Sets.AllowsWind[(int) tile.wall] || (double) y > Main.worldSurface;
  }

  private int GetWaterAnimalCageFrame(int x, int y, int tileFrameX, int tileFrameY)
  {
    return (x - tileFrameX / 18) / 2 * ((y - tileFrameY / 18) / 3) % Main.cageFrames;
  }

  private int GetSmallAnimalCageFrame(int x, int y, int tileFrameX, int tileFrameY)
  {
    return (x - tileFrameX / 18) / 3 * ((y - tileFrameY / 18) / 3) % Main.cageFrames;
  }

  private int GetBigAnimalCageFrame(int x, int y, int tileFrameX, int tileFrameY)
  {
    return (x - tileFrameX / 18) / 6 * ((y - tileFrameY / 18) / 4) % Main.cageFrames;
  }

  public static void GetScreenDrawArea(
    bool useOffscreenRange,
    out Vector2 drawOffSet,
    out int firstTileX,
    out int lastTileX,
    out int firstTileY,
    out int lastTileY)
  {
    Vector2 scaledPosition = Main.Camera.ScaledPosition;
    Vector2 scaledSize = Main.Camera.ScaledSize;
    drawOffSet = useOffscreenRange ? new Vector2((float) Main.offScreenRange, (float) Main.offScreenRange) : Vector2.Zero;
    firstTileX = (int) (((double) scaledPosition.X - (double) drawOffSet.X) / 16.0 - 1.0);
    lastTileX = (int) (((double) scaledPosition.X + (double) scaledSize.X + (double) drawOffSet.X) / 16.0) + 2;
    firstTileY = (int) (((double) scaledPosition.Y - (double) drawOffSet.Y) / 16.0 - 1.0);
    lastTileY = (int) (((double) scaledPosition.Y + (double) scaledSize.Y + (double) drawOffSet.Y) / 16.0) + 5;
    if (firstTileX < 4)
      firstTileX = 4;
    if (lastTileX > Main.maxTilesX - 4)
      lastTileX = Main.maxTilesX - 4;
    if (firstTileY < 4)
      firstTileY = 4;
    if (lastTileY > Main.maxTilesY - 4)
      lastTileY = Main.maxTilesY - 4;
    if (Main.sectionManager.AnyUnfinishedSections)
    {
      TimeLogger.StartTimestamp fromTimestamp = TimeLogger.Start();
      WorldGen.SectionTileFrameWithCheck(firstTileX, firstTileY, lastTileX, lastTileY);
      TimeLogger.SectionFraming.AddTime(fromTimestamp);
    }
    if (!Main.sectionManager.AnyNeedRefresh)
      return;
    TimeLogger.StartTimestamp fromTimestamp1 = TimeLogger.Start();
    WorldGen.RefreshSections(firstTileX, firstTileY, lastTileX, lastTileY);
    TimeLogger.SectionRefresh.AddTime(fromTimestamp1);
  }

  public void ClearCachedTileDraws(bool solidLayer)
  {
    if (!solidLayer)
      return;
    this._displayDollTileEntityPositions.Clear();
    this._hatRackTileEntityPositions.Clear();
    this._vineRootsPositions.Clear();
    this._reverseVineRootsPositions.Clear();
  }

  private void AddSpecialLegacyPoint(Point p) => this.AddSpecialLegacyPoint(p.X, p.Y);

  private void AddSpecialLegacyPoint(int x, int y)
  {
    this._specialTileX[this._specialTilesCount] = x;
    this._specialTileY[this._specialTilesCount] = y;
    ++this._specialTilesCount;
  }

  private void ClearLegacyCachedDraws()
  {
    this._chestPositions.Clear();
    this._trainingDummyTileEntityPositions.Clear();
    this._foodPlatterTileEntityPositions.Clear();
    this._itemFrameTileEntityPositions.Clear();
    this._deadCellsDisplayJarTileEntityPositions.Clear();
    this._weaponRackTileEntityPositions.Clear();
    this._specialTilesCount = 0;
  }

  private Color DrawTiles_GetLightOverride(
    int j,
    int i,
    Tile tileCache,
    ushort typeCache,
    short tileFrameX,
    short tileFrameY,
    Color tileLight)
  {
    if (tileCache.fullbrightBlock())
      return Color.White;
    switch (typeCache)
    {
      case 19:
        if ((int) tileFrameY / 18 == 48 /*0x30*/)
          return Color.White;
        break;
      case 61:
      case 703:
        if (tileFrameX == (short) 144 /*0x90*/)
        {
          tileLight.A = tileLight.R = tileLight.G = tileLight.B = (byte) (245.0 - (double) Main.mouseTextColor * 1.5);
          break;
        }
        break;
      case 83:
        int style = (int) tileFrameX / 18;
        if (WorldGen.IsAlchemyPlantHarvestable(style, j) && style == 5)
        {
          tileLight.A = (byte) ((uint) Main.mouseTextColor / 2U);
          tileLight.G = Main.mouseTextColor;
          tileLight.B = Main.mouseTextColor;
          break;
        }
        break;
      case 84:
        if ((int) tileFrameX / 18 == 6)
        {
          byte num1 = (byte) (((int) Main.mouseTextColor + (int) tileLight.G * 2) / 3);
          byte num2 = (byte) (((int) Main.mouseTextColor + (int) tileLight.B * 2) / 3);
          if ((int) num1 > (int) tileLight.G)
            tileLight.G = num1;
          if ((int) num2 > (int) tileLight.B)
          {
            tileLight.B = num2;
            break;
          }
          break;
        }
        break;
      case 481:
      case 482:
      case 483:
        float num = (float) (1.0 + Math.Sin((double) Main.GlobalTimeWrappedHourly / 1.5 * 6.2831854820251465) * 0.15000000596046448);
        byte a = tileLight.A;
        tileLight *= num;
        tileLight.A = a;
        break;
      case 541:
      case 631:
        return Color.White;
    }
    return tileLight;
  }

  private void DrawTiles_EmitParticles(
    int j,
    int i,
    Tile tileCache,
    ushort typeCache,
    short tileFrameX,
    short tileFrameY,
    Color tileLight)
  {
    bool flag1 = this.IsVisible(tileCache);
    int maxValue = this._leafFrequency / 4;
    if (typeCache == (ushort) 718 && !Main.dayTime && this._rand.Next(3) == 0 && !WorldGen.SolidTile3(i, j - 1))
    {
      if (Main.player[Main.myPlayer].RollLuck(100) == 0)
      {
        int index1 = Gore.NewGore(new Vector2((float) (i * 16 /*0x10*/ + this._rand.Next(16 /*0x10*/)), (float) (j * 16 /*0x10*/ - 12)), new Vector2(), 16 /*0x10*/);
        Main.gore[index1].scale *= (float) ((double) this._rand.NextFloat() * 0.5 + 0.75);
        Main.gore[index1].velocity *= 0.2f;
        Main.gore[index1].velocity.Y -= (float) this._rand.Next(5, 31 /*0x1F*/) * 0.1f;
        if (this._rand.Next(5) == 0)
          Main.gore[index1].velocity.Y -= (float) this._rand.Next(5, 41) * 0.1f;
        if (this._rand.Next(3) == 0)
          Main.gore[index1].velocity *= 0.5f;
        Main.gore[index1].velocity /= Main.gore[index1].scale;
        int index2 = Gore.NewGore(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), new Vector2(), 16 /*0x10*/);
        Main.gore[index2].scale = Main.gore[index1].scale;
        Main.gore[index2].position = Main.gore[index1].position;
        Main.gore[index2].velocity = Main.gore[index1].velocity;
      }
      if (Main.player[Main.myPlayer].RollLuck(60) == 0)
      {
        int index3 = Gore.NewGore(new Vector2((float) (i * 16 /*0x10*/ + this._rand.Next(16 /*0x10*/)), (float) (j * 16 /*0x10*/ - 12)), new Vector2(), 17);
        Main.gore[index3].scale *= (float) ((double) this._rand.NextFloat() * 0.5 + 0.75);
        Main.gore[index3].velocity *= 0.2f;
        Main.gore[index3].velocity.Y -= (float) this._rand.Next(5, 41) * 0.1f;
        if (this._rand.Next(5) == 0)
          Main.gore[index3].velocity.Y -= (float) this._rand.Next(5, 51) * 0.1f;
        if (this._rand.Next(3) == 0)
          Main.gore[index3].velocity *= 0.5f;
        Main.gore[index3].velocity /= Main.gore[index3].scale;
        int index4 = Gore.NewGore(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), new Vector2(), 17);
        Main.gore[index4].scale = Main.gore[index3].scale;
        Main.gore[index4].position = Main.gore[index3].position;
        Main.gore[index4].velocity = Main.gore[index3].velocity;
      }
      if (Main.player[Main.myPlayer].RollLuck(30) == 0)
      {
        int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/ - 2)), 1, 1, 58, Alpha: 150);
        Main.dust[index].scale *= (float) ((double) this._rand.NextFloat() * 0.5 + 0.75);
        Main.dust[index].color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
        Main.dust[index].velocity *= 0.2f;
        Main.dust[index].velocity.Y -= (float) this._rand.Next(5, 51) * 0.1f;
        if (this._rand.Next(5) == 0)
          Main.dust[index].velocity.Y -= (float) this._rand.Next(5, 61) * 0.1f;
        if (this._rand.Next(3) == 0)
          Main.dust[index].velocity *= 0.5f;
        Main.dust[index].velocity /= Main.dust[index].scale;
      }
    }
    if (typeCache == (ushort) 244 && tileFrameX == (short) 18 && tileFrameY == (short) 18 && this._rand.Next(2) == 0)
    {
      if (this._rand.Next(500) == 0)
        Gore.NewGore(new Vector2((float) (i * 16 /*0x10*/ + 8), (float) (j * 16 /*0x10*/ + 8)), new Vector2(), 415, (float) this._rand.Next(51, 101) * 0.01f);
      else if (this._rand.Next(250) == 0)
        Gore.NewGore(new Vector2((float) (i * 16 /*0x10*/ + 8), (float) (j * 16 /*0x10*/ + 8)), new Vector2(), 414, (float) this._rand.Next(51, 101) * 0.01f);
      else if (this._rand.Next(80 /*0x50*/) == 0)
        Gore.NewGore(new Vector2((float) (i * 16 /*0x10*/ + 8), (float) (j * 16 /*0x10*/ + 8)), new Vector2(), 413, (float) this._rand.Next(51, 101) * 0.01f);
      else if (this._rand.Next(10) == 0)
        Gore.NewGore(new Vector2((float) (i * 16 /*0x10*/ + 8), (float) (j * 16 /*0x10*/ + 8)), new Vector2(), 412, (float) this._rand.Next(51, 101) * 0.01f);
      else if (this._rand.Next(3) == 0)
        Gore.NewGore(new Vector2((float) (i * 16 /*0x10*/ + 8), (float) (j * 16 /*0x10*/ + 8)), new Vector2(), 411, (float) this._rand.Next(51, 101) * 0.01f);
    }
    if (typeCache == (ushort) 565 && tileFrameX == (short) 0 && tileFrameY == (short) 18 && this._rand.Next(3) == 0)
    {
      Vector2 worldCoordinates = new Point(i, j).ToWorldCoordinates();
      int Type = 1202;
      float Scale = (float) (8.0 + (double) Main.rand.NextFloat() * 1.6000000238418579);
      Vector2 vector2 = new Vector2(0.0f, -18f);
      Gore.NewGorePerfect(worldCoordinates + vector2, (Main.rand.NextVector2Circular(0.7f, 0.25f) * 0.4f + Main.rand.NextVector2CircularEdge(1f, 0.4f) * 0.1f) * 4f, Type, Scale);
    }
    if (typeCache == (ushort) 215 && tileFrameY < (short) 36 && this._rand.Next(3) == 0 && tileFrameY == (short) 0)
    {
      int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/ + 2), (float) (j * 16 /*0x10*/ - 4)), 4, 8, 31 /*0x1F*/, Alpha: 100);
      if (tileFrameX == (short) 0)
        this._dust[index].position.X += (float) this._rand.Next(8);
      if (tileFrameX == (short) 36)
        this._dust[index].position.X -= (float) this._rand.Next(8);
      this._dust[index].alpha += this._rand.Next(100);
      this._dust[index].velocity *= 0.2f;
      this._dust[index].velocity.Y -= (float) (0.5 + (double) this._rand.Next(10) * 0.10000000149011612);
      this._dust[index].fadeIn = (float) (0.5 + (double) this._rand.Next(10) * 0.10000000149011612);
    }
    if (typeCache == (ushort) 592 && tileFrameY == (short) 18 && this._rand.Next(3) == 0)
    {
      int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/ + 2), (float) (j * 16 /*0x10*/ + 4)), 4, 8, 31 /*0x1F*/, Alpha: 100);
      if (tileFrameX == (short) 0)
        this._dust[index].position.X += (float) this._rand.Next(8);
      if (tileFrameX == (short) 36)
        this._dust[index].position.X -= (float) this._rand.Next(8);
      this._dust[index].alpha += this._rand.Next(100);
      this._dust[index].velocity *= 0.2f;
      this._dust[index].velocity.Y -= (float) (0.5 + (double) this._rand.Next(10) * 0.10000000149011612);
      this._dust[index].fadeIn = (float) (0.5 + (double) this._rand.Next(10) * 0.10000000149011612);
    }
    else if (typeCache == (ushort) 406 && tileFrameY == (short) 54 && tileFrameX == (short) 0 && this._rand.Next(3) == 0)
    {
      Vector2 Position = new Vector2((float) (i * 16 /*0x10*/ + 16 /*0x10*/), (float) (j * 16 /*0x10*/ + 8));
      Vector2 Velocity = new Vector2(0.0f, 0.0f);
      if ((double) Main.WindForVisuals < 0.0)
        Velocity.X = -Main.WindForVisuals;
      int Type = this._rand.Next(825, 828);
      if (this._rand.Next(4) == 0)
        Gore.NewGore(Position, Velocity, Type, (float) ((double) this._rand.NextFloat() * 0.20000000298023224 + 0.20000000298023224));
      else if (this._rand.Next(2) == 0)
        Gore.NewGore(Position, Velocity, Type, (float) ((double) this._rand.NextFloat() * 0.30000001192092896 + 0.30000001192092896));
      else
        Gore.NewGore(Position, Velocity, Type, (float) ((double) this._rand.NextFloat() * 0.40000000596046448 + 0.40000000596046448));
    }
    else if (typeCache == (ushort) 452 && tileFrameY == (short) 0 && tileFrameX == (short) 0 && this._rand.Next(3) == 0)
    {
      Vector2 Position = new Vector2((float) (i * 16 /*0x10*/ + 16 /*0x10*/), (float) (j * 16 /*0x10*/ + 8));
      Vector2 Velocity = new Vector2(0.0f, 0.0f);
      if ((double) Main.WindForVisuals < 0.0)
        Velocity.X = -Main.WindForVisuals;
      int Type = 907 + Main.tileFrame[(int) typeCache] / 5;
      if (this._rand.Next(2) == 0)
        Gore.NewGore(Position, Velocity, Type, (float) ((double) this._rand.NextFloat() * 0.40000000596046448 + 0.40000000596046448));
    }
    if (typeCache == (ushort) 192 /*0xC0*/ && this._rand.Next(maxValue) == 0)
      this.EmitLivingTreeLeaf(i, j, 910);
    if (typeCache == (ushort) 384 && this._rand.Next(maxValue) == 0)
      this.EmitLivingTreeLeaf(i, j, 914);
    if ((typeCache == (ushort) 666 || typeCache == (ushort) 712) && tileCache.liquid <= (byte) 0 && j - 1 > 0 && this._rand.Next(100) == 0 && !WorldGen.ActiveAndWalkableTile(i, j - 1) && !WorldGen.AnyLiquidAt(i, j - 1))
      ParticleOrchestrator.RequestParticleSpawn(true, ParticleOrchestraType.PooFly, new ParticleOrchestraSettings()
      {
        PositionInWorld = new Vector2((float) (i * 16 /*0x10*/ + 8), (float) (j * 16 /*0x10*/ - 8))
      });
    if (typeCache == (ushort) 711 && tileFrameX == (short) 0 && tileFrameY == (short) 0)
    {
      if (this._rand.Next(45) == 0)
        ParticleOrchestrator.RequestParticleSpawn(true, ParticleOrchestraType.RainbowBoulder3, new ParticleOrchestraSettings()
        {
          PositionInWorld = new Vector2((float) (i * 16 /*0x10*/ + 16 /*0x10*/), (float) (j * 16 /*0x10*/ + 16 /*0x10*/))
        });
      if (this._rand.Next(3) != 0)
        ParticleOrchestrator.RequestParticleSpawn(true, ParticleOrchestraType.RainbowBoulder2, new ParticleOrchestraSettings()
        {
          PositionInWorld = new Vector2((float) (i * 16 /*0x10*/ + 16 /*0x10*/), (float) (j * 16 /*0x10*/ + 16 /*0x10*/)) + this._rand.NextVector2Circular(16f, 16f),
          MovementVector = this._rand.NextVector2Circular(1f, 0.5f) * 0.5f
        });
    }
    if (TileID.Sets.SpawnsNatureFlies[(int) typeCache] && tileCache.liquid <= (byte) 0)
    {
      float num1 = Utils.GetLerpValue(0.08f, 0.18f, Math.Abs(Main.WindForVisuals), true) + 0.3f;
      if ((double) this._rand.NextFloat() < (double) num1)
      {
        bool flag2 = this._rand.Next(600) == 0;
        if (!flag2)
        {
          int windTimeLeft;
          int num2;
          this._windGrid.GetWindTime(i, j, 8, out windTimeLeft, out num2, out num2);
          flag2 = windTimeLeft > 0 && this._rand.Next(48 /*0x30*/) == 0;
        }
        if (flag2)
          ParticleOrchestrator.RequestParticleSpawn(true, ParticleOrchestraType.NatureFly, new ParticleOrchestraSettings()
          {
            PositionInWorld = new Vector2((float) (i * 16 /*0x10*/ + 8), (float) (j * 16 /*0x10*/))
          });
      }
    }
    if (this._rand.Next(1200) == 0)
    {
      bool flag3 = j + 1 < 0;
      bool flag4 = false;
      int num = 3;
      if ((double) j < Main.worldSurface)
      {
        if (this._rand.Next(10) != 0)
        {
          flag3 = true;
        }
        else
        {
          --num;
          flag4 = true;
        }
      }
      if (!TileID.Sets.MakesRubbleDust[(int) typeCache])
        flag3 = true;
      if (!flag3 && WorldGen.ActiveAndWalkableTile(i, j + 1))
        flag3 = true;
      if (!flag3 && !WallID.Sets.AllowsWind[(int) Main.tile[i, j].wall])
      {
        if (this._rand.Next(2) == 0)
          flag3 = true;
        else
          --num;
      }
      if (!flag3)
      {
        for (int index5 = 0; index5 < num; ++index5)
        {
          int index6 = WorldGen.KillTile_MakeTileDust(i, j, tileCache);
          Dust dust = Main.dust[index6];
          dust.position.Y += 8f;
          dust.velocity *= 0.1f;
          if (flag4)
            dust.scale -= 0.3f;
        }
      }
    }
    if (!flag1)
      return;
    if (typeCache == (ushort) 238 && this._rand.Next(10) == 0)
    {
      int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 168);
      this._dust[index].noGravity = true;
      this._dust[index].alpha = 200;
    }
    switch (typeCache)
    {
      case 139:
        if (tileCache.frameX == (short) 36 && (int) tileCache.frameY % 36 == 0 && (int) Main.timeForVisualEffects % 7 == 0 && this._rand.Next(3) == 0)
        {
          int Type = this._rand.Next(570, 573);
          Vector2 Position = new Vector2((float) (i * 16 /*0x10*/ + 8), (float) (j * 16 /*0x10*/ - 8));
          Vector2 Velocity = new Vector2(Main.WindForVisuals * 2f, -0.5f);
          Velocity.X *= (float) (1.0 + (double) this._rand.Next(-50, 51) * 0.0099999997764825821);
          Velocity.Y *= (float) (1.0 + (double) this._rand.Next(-50, 51) * 0.0099999997764825821);
          if (Type == 572)
            Position.X -= 8f;
          if (Type == 571)
            Position.X -= 4f;
          Gore.NewGore(Position, Velocity, Type, 0.8f);
          break;
        }
        break;
      case 463:
        if (tileFrameY == (short) 54 && tileFrameX == (short) 0)
        {
          for (int index = 0; index < 4; ++index)
          {
            if (this._rand.Next(2) != 0)
            {
              Dust dust = Dust.NewDustDirect(new Vector2((float) (i * 16 /*0x10*/ + 4), (float) (j * 16 /*0x10*/)), 36, 8, 16 /*0x10*/);
              dust.noGravity = true;
              dust.alpha = 140;
              dust.fadeIn = 1.2f;
              dust.velocity = Vector2.Zero;
            }
          }
        }
        if (tileFrameY == (short) 18 && (tileFrameX == (short) 0 || tileFrameX == (short) 36))
        {
          for (int index = 0; index < 1; ++index)
          {
            if (this._rand.Next(13) == 0)
            {
              Dust dust = Dust.NewDustDirect(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 8, 8, 274);
              dust.position = new Vector2((float) (i * 16 /*0x10*/ + 8), (float) (j * 16 /*0x10*/ + 8));
              dust.position.X += tileFrameX == (short) 36 ? 4f : -4f;
              dust.noGravity = true;
              dust.alpha = 128 /*0x80*/;
              dust.fadeIn = 1.2f;
              dust.noLight = true;
              dust.velocity = new Vector2(0.0f, this._rand.NextFloatDirection() * 1.2f);
            }
          }
          break;
        }
        break;
      case 497:
        if ((int) tileCache.frameY / 40 == 31 /*0x1F*/ && (int) tileCache.frameY % 40 == 0)
        {
          for (int index = 0; index < 1; ++index)
          {
            if (this._rand.Next(10) == 0)
            {
              Dust dust = Dust.NewDustDirect(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/ + 8)), 16 /*0x10*/, 12, 43);
              dust.noGravity = true;
              dust.alpha = 254;
              dust.color = Color.White;
              dust.scale = 0.7f;
              dust.velocity = Vector2.Zero;
              dust.noLight = true;
            }
          }
          break;
        }
        break;
      default:
        if (typeCache == (ushort) 165 && tileFrameX >= (short) 162 && tileFrameX <= (short) 214 && tileFrameY == (short) 72)
        {
          if (this._rand.Next(60) == 0)
          {
            int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/ + 2), (float) (j * 16 /*0x10*/ + 6)), 8, 4, 153);
            this._dust[index].scale -= (float) this._rand.Next(3) * 0.1f;
            this._dust[index].velocity.Y = 0.0f;
            this._dust[index].velocity.X *= 0.05f;
            this._dust[index].alpha = 100;
            break;
          }
          break;
        }
        if (typeCache == (ushort) 42 && tileFrameX == (short) 0)
        {
          int num = (int) tileFrameY / 36;
          if ((int) tileFrameY / 18 % 2 == 1)
          {
            switch (num)
            {
              case 7:
                if (this._rand.Next(50) == 0)
                  this._dust[Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/ + 4), (float) (j * 16 /*0x10*/ + 4)), 8, 8, 58, Alpha: 150)].velocity *= 0.5f;
                if (this._rand.Next(100) == 0)
                {
                  int index = Gore.NewGore(new Vector2((float) (i * 16 /*0x10*/ - 2), (float) (j * 16 /*0x10*/ - 4)), new Vector2(), this._rand.Next(16 /*0x10*/, 18));
                  this._gore[index].scale *= 0.7f;
                  this._gore[index].velocity *= 0.25f;
                  break;
                }
                break;
              case 29:
                if (this._rand.Next(40) == 0)
                {
                  int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/ + 4), (float) (j * 16 /*0x10*/)), 8, 8, 59, Alpha: 100);
                  if (this._rand.Next(3) != 0)
                    this._dust[index].noGravity = true;
                  this._dust[index].velocity *= 0.3f;
                  this._dust[index].velocity.Y -= 1.5f;
                  break;
                }
                break;
              case 50:
                if (this._rand.Next(10) == 0)
                {
                  int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/ + 4), (float) (j * 16 /*0x10*/)), 8, 8, 57, Alpha: 100);
                  if (this._rand.Next(3) != 0)
                    this._dust[index].noGravity = true;
                  this._dust[index].velocity *= 0.3f;
                  this._dust[index].velocity.Y -= 1.5f;
                  break;
                }
                break;
              case 51:
                if (this._rand.Next(40) == 0)
                {
                  int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/ + 4), (float) (j * 16 /*0x10*/ + 2)), 4, 4, 242, Alpha: 100);
                  if (this._rand.Next(3) != 0)
                    this._dust[index].noGravity = true;
                  this._dust[index].velocity *= 0.3f;
                  this._dust[index].velocity.Y -= 1.5f;
                  break;
                }
                break;
            }
          }
          else
            break;
        }
        else
          break;
        break;
    }
    if (typeCache == (ushort) 4 && this._rand.Next(40) == 0 && tileFrameX < (short) 66)
    {
      int index7 = (int) MathHelper.Clamp((float) ((int) tileCache.frameY / 22), 0.0f, (float) ((int) TorchID.Count - 1));
      int Type = TorchID.Dust[index7];
      int index8;
      switch (tileFrameX)
      {
        case 22:
          index8 = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/ + 6), (float) (j * 16 /*0x10*/)), 4, 4, Type, Alpha: 100);
          break;
        case 44:
          index8 = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/ + 2), (float) (j * 16 /*0x10*/)), 4, 4, Type, Alpha: 100);
          break;
        default:
          index8 = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/ + 4), (float) (j * 16 /*0x10*/)), 4, 4, Type, Alpha: 100);
          break;
      }
      if (this._rand.Next(3) != 0)
        this._dust[index8].noGravity = true;
      this._dust[index8].velocity *= 0.3f;
      this._dust[index8].velocity.Y -= 1.5f;
      if (Type == 66)
      {
        this._dust[index8].color = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB);
        this._dust[index8].noGravity = true;
      }
    }
    if (typeCache == (ushort) 93 && this._rand.Next(40) == 0 && tileFrameX == (short) 0)
    {
      int num = (int) tileFrameY / 54;
      if ((int) tileFrameY / 18 % 3 == 0)
      {
        int Type;
        switch (num)
        {
          case 0:
          case 6:
          case 7:
          case 8:
          case 10:
          case 14:
          case 15:
          case 16 /*0x10*/:
            Type = 6;
            break;
          case 20:
            Type = 59;
            break;
          case 44:
            Type = 57;
            break;
          case 45:
            Type = 242;
            break;
          default:
            Type = -1;
            break;
        }
        if (Type != -1)
        {
          int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/ + 4), (float) (j * 16 /*0x10*/ + 2)), 4, 4, Type, Alpha: 100);
          if (this._rand.Next(3) != 0)
            this._dust[index].noGravity = true;
          this._dust[index].velocity *= 0.3f;
          this._dust[index].velocity.Y -= 1.5f;
        }
      }
    }
    if (typeCache == (ushort) 100 && this._rand.Next(40) == 0 && tileFrameX < (short) 36)
    {
      int num = (int) tileFrameY / 36;
      if ((int) tileFrameY / 18 % 2 == 0)
      {
        int Type;
        switch (num)
        {
          case 0:
          case 5:
          case 7:
          case 8:
          case 10:
          case 12:
          case 14:
          case 15:
          case 16 /*0x10*/:
            Type = 6;
            break;
          case 20:
            Type = 59;
            break;
          case 44:
            Type = 57;
            break;
          case 45:
            Type = 242;
            break;
          default:
            Type = -1;
            break;
        }
        if (Type != -1)
        {
          int index = Dust.NewDust(tileFrameX != (short) 0 ? (this._rand.Next(3) != 0 ? new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/ + 2)) : new Vector2((float) (i * 16 /*0x10*/ + 6), (float) (j * 16 /*0x10*/ + 2))) : (this._rand.Next(3) != 0 ? new Vector2((float) (i * 16 /*0x10*/ + 14), (float) (j * 16 /*0x10*/ + 2)) : new Vector2((float) (i * 16 /*0x10*/ + 4), (float) (j * 16 /*0x10*/ + 2))), 4, 4, Type, Alpha: 100);
          if (this._rand.Next(3) != 0)
            this._dust[index].noGravity = true;
          this._dust[index].velocity *= 0.3f;
          this._dust[index].velocity.Y -= 1.5f;
        }
      }
    }
    if (typeCache == (ushort) 98 && this._rand.Next(40) == 0 && tileFrameY == (short) 0 && tileFrameX == (short) 0)
    {
      int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/ + 12), (float) (j * 16 /*0x10*/ + 2)), 4, 4, 6, Alpha: 100);
      if (this._rand.Next(3) != 0)
        this._dust[index].noGravity = true;
      this._dust[index].velocity *= 0.3f;
      this._dust[index].velocity.Y -= 1.5f;
    }
    if (typeCache == (ushort) 49 && tileFrameX == (short) 0 && this._rand.Next(2) == 0)
    {
      int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/ + 4), (float) (j * 16 /*0x10*/ - 4)), 4, 4, 172, Alpha: 100);
      if (this._rand.Next(3) == 0)
      {
        this._dust[index].scale = 0.5f;
      }
      else
      {
        this._dust[index].scale = 0.9f;
        this._dust[index].noGravity = true;
      }
      this._dust[index].velocity *= 0.3f;
      this._dust[index].velocity.Y -= 1.5f;
    }
    if (typeCache == (ushort) 372 && tileFrameX == (short) 0 && this._rand.Next(2) == 0)
    {
      int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/ + 4), (float) (j * 16 /*0x10*/ - 4)), 4, 4, 242, Alpha: 100);
      if (this._rand.Next(3) == 0)
      {
        this._dust[index].scale = 0.5f;
      }
      else
      {
        this._dust[index].scale = 0.9f;
        this._dust[index].noGravity = true;
      }
      this._dust[index].velocity *= 0.3f;
      this._dust[index].velocity.Y -= 1.5f;
    }
    if (typeCache == (ushort) 646 && tileFrameX == (short) 0)
      this._rand.Next(2);
    if (typeCache == (ushort) 34 && this._rand.Next(40) == 0 && (int) tileFrameX % 108 < 54)
    {
      int num3 = (int) tileFrameY / 54;
      if (tileFrameX >= (short) 108)
        num3 += 37 * ((int) tileFrameX / 108);
      int num4 = (int) tileFrameX / 18 % 3;
      if ((int) tileFrameY / 18 % 3 == 1 && num4 != 1)
      {
        int Type;
        switch (num3)
        {
          case 0:
          case 1:
          case 2:
          case 3:
          case 4:
          case 5:
          case 12:
          case 13:
          case 16 /*0x10*/:
          case 19:
          case 21:
            Type = 6;
            break;
          case 25:
            Type = 59;
            break;
          case 50:
            Type = 57;
            break;
          case 51:
            Type = 242;
            break;
          default:
            Type = -1;
            break;
        }
        if (Type != -1)
        {
          int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/ + 2)), 14, 6, Type, Alpha: 100);
          if (this._rand.Next(3) != 0)
            this._dust[index].noGravity = true;
          this._dust[index].velocity *= 0.3f;
          this._dust[index].velocity.Y -= 1.5f;
        }
      }
    }
    if (typeCache == (ushort) 83)
    {
      int style = (int) tileFrameX / 18;
      if (WorldGen.IsAlchemyPlantHarvestable(style, j))
        this.EmitAlchemyHerbParticles(j, i, style);
    }
    if (typeCache == (ushort) 22 && this._rand.Next(400) == 0)
      Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 14);
    else if ((typeCache == (ushort) 23 || typeCache == (ushort) 24 || typeCache == (ushort) 32 /*0x20*/) && this._rand.Next(500) == 0)
      Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 14);
    else if (typeCache == (ushort) 25 && this._rand.Next(700) == 0)
      Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 14);
    else if (typeCache == (ushort) 112 /*0x70*/ && this._rand.Next(700) == 0)
      Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 14);
    else if ((typeCache == (ushort) 31 /*0x1F*/ || typeCache == (ushort) 696) && this._rand.Next(20) == 0)
    {
      if (tileFrameX >= (short) 36)
      {
        int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 5, Alpha: 100);
        this._dust[index].velocity.Y = 0.0f;
        this._dust[index].velocity.X *= 0.3f;
      }
      else
        Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 14, Alpha: 100);
    }
    else if ((typeCache == (ushort) 26 || typeCache == (ushort) 695) && this._rand.Next(20) == 0)
    {
      if (tileFrameX >= (short) 54)
      {
        int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 5, Alpha: 100);
        this._dust[index].scale = 1.5f;
        this._dust[index].noGravity = true;
        this._dust[index].velocity *= 0.75f;
      }
      else
        Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 14, Alpha: 100);
    }
    else if ((typeCache == (ushort) 71 || typeCache == (ushort) 72) && tileCache.color() == (byte) 0 && this._rand.Next(500) == 0)
      Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 41, Alpha: 250, Scale: 0.8f);
    else if ((typeCache == (ushort) 17 || typeCache == (ushort) 77 || typeCache == (ushort) 133) && this._rand.Next(40) == 0)
    {
      if (!(tileFrameX == (short) 18 & tileFrameY == (short) 18))
        return;
      int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/ - 4), (float) (j * 16 /*0x10*/ - 6)), 8, 6, 6, Alpha: 100);
      if (this._rand.Next(3) == 0)
        return;
      this._dust[index].noGravity = true;
    }
    else if (typeCache == (ushort) 405 && this._rand.Next(20) == 0)
    {
      if (!(tileFrameX == (short) 18 & tileFrameY == (short) 18))
        return;
      int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/ - 4), (float) (j * 16 /*0x10*/ - 6)), 24, 10, 6, Alpha: 100);
      if (this._rand.Next(5) == 0)
        return;
      this._dust[index].noGravity = true;
    }
    else if (typeCache == (ushort) 37 && this._rand.Next(250) == 0)
    {
      int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 6, Scale: (float) this._rand.Next(3));
      if ((double) this._dust[index].scale <= 1.0)
        return;
      this._dust[index].noGravity = true;
    }
    else if ((typeCache == (ushort) 58 || typeCache == (ushort) 76 || typeCache == (ushort) 684) && this._rand.Next(250) == 0)
    {
      int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 6, Scale: (float) this._rand.Next(3));
      if ((double) this._dust[index].scale > 1.0)
        this._dust[index].noGravity = true;
      this._dust[index].noLight = true;
    }
    else if (typeCache == (ushort) 61 || typeCache == (ushort) 703)
    {
      if (tileFrameX != (short) 144 /*0x90*/ || this._rand.Next(60) != 0)
        return;
      this._dust[Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 44, Alpha: 250, Scale: 0.4f)].fadeIn = 0.7f;
    }
    else if (Main.tileShine[(int) typeCache] > 0)
    {
      if (tileLight.R <= (byte) 20 && tileLight.B <= (byte) 20 && tileLight.G <= (byte) 20)
        return;
      int num5 = (int) tileLight.R;
      if ((int) tileLight.G > num5)
        num5 = (int) tileLight.G;
      if ((int) tileLight.B > num5)
        num5 = (int) tileLight.B;
      int num6 = num5 / 30;
      if (this._rand.Next(Main.tileShine[(int) typeCache]) >= num6 || (typeCache == (ushort) 21 || typeCache == (ushort) 441) && (tileFrameX < (short) 36 || tileFrameX >= (short) 180) && (tileFrameX < (short) 396 || tileFrameX > (short) 409) || (typeCache == (ushort) 467 || typeCache == (ushort) 468) && (tileFrameX < (short) 144 /*0x90*/ || tileFrameX >= (short) 180))
        return;
      Color newColor = Color.White;
      if (typeCache == (ushort) 617)
      {
        int x = i;
        int y = j;
        WorldGen.GetTopLeftAndStyles(ref x, ref y, 3, 4, 18, 18);
        int num7 = y;
        if (!this.IsVisible(Main.tile[x + 1, y + 1]))
          num7 = y + 3;
        if (j < num7)
          return;
        this._dust[Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 43, Alpha: 254, newColor: newColor, Scale: 0.5f)].velocity *= 0.0f;
      }
      else if (typeCache == (ushort) 178)
      {
        switch ((int) tileFrameX / 18)
        {
          case 0:
            newColor = new Color((int) byte.MaxValue, 0, (int) byte.MaxValue, (int) byte.MaxValue);
            break;
          case 1:
            newColor = new Color((int) byte.MaxValue, (int) byte.MaxValue, 0, (int) byte.MaxValue);
            break;
          case 2:
            newColor = new Color(0, 0, (int) byte.MaxValue, (int) byte.MaxValue);
            break;
          case 3:
            newColor = new Color(0, (int) byte.MaxValue, 0, (int) byte.MaxValue);
            break;
          case 4:
            newColor = new Color((int) byte.MaxValue, 0, 0, (int) byte.MaxValue);
            break;
          case 5:
            newColor = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
            break;
          case 6:
            newColor = new Color((int) byte.MaxValue, (int) byte.MaxValue, 0, (int) byte.MaxValue);
            break;
        }
        this._dust[Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 43, Alpha: 254, newColor: newColor, Scale: 0.5f)].velocity *= 0.0f;
      }
      else
      {
        if (typeCache == (ushort) 63 /*0x3F*/)
          newColor = new Color(0, 0, (int) byte.MaxValue, (int) byte.MaxValue);
        if (typeCache == (ushort) 64 /*0x40*/)
          newColor = new Color((int) byte.MaxValue, 0, 0, (int) byte.MaxValue);
        if (typeCache == (ushort) 65)
          newColor = new Color(0, (int) byte.MaxValue, 0, (int) byte.MaxValue);
        if (typeCache == (ushort) 66)
          newColor = new Color((int) byte.MaxValue, (int) byte.MaxValue, 0, (int) byte.MaxValue);
        if (typeCache == (ushort) 67)
          newColor = new Color((int) byte.MaxValue, 0, (int) byte.MaxValue, (int) byte.MaxValue);
        if (typeCache == (ushort) 68)
          newColor = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        if (typeCache == (ushort) 566)
          newColor = new Color((int) byte.MaxValue, (int) byte.MaxValue, 0, (int) byte.MaxValue);
        if (typeCache == (ushort) 12 || typeCache == (ushort) 665)
          newColor = new Color((int) byte.MaxValue, 0, 0, (int) byte.MaxValue);
        if (typeCache == (ushort) 639)
          newColor = new Color(0, 0, (int) byte.MaxValue, (int) byte.MaxValue);
        if (typeCache == (ushort) 204)
          newColor = new Color((int) byte.MaxValue, 0, 0, (int) byte.MaxValue);
        if (typeCache == (ushort) 211)
          newColor = new Color(50, (int) byte.MaxValue, 100, (int) byte.MaxValue);
        this._dust[Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 43, Alpha: 254, newColor: newColor, Scale: 0.5f)].velocity *= 0.0f;
      }
    }
    else
    {
      if (!Main.tileSolid[(int) tileCache.type] || (double) Main.shimmerAlpha <= 0.0 || tileLight.R <= (byte) 20 && tileLight.B <= (byte) 20 && tileLight.G <= (byte) 20)
        return;
      int num = (int) tileLight.R;
      if ((int) tileLight.G > num)
        num = (int) tileLight.G;
      if ((int) tileLight.B > num)
        num = (int) tileLight.B;
      if ((double) this._rand.Next(500) >= 2.0 * (double) Main.shimmerAlpha)
        return;
      Color white = Color.White;
      float Scale = (float) (((double) num / (double) byte.MaxValue + 1.0) / 2.0);
      this._dust[Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 43, Alpha: 254, newColor: white, Scale: Scale)].velocity *= 0.0f;
    }
  }

  private void EmitLivingTreeLeaf(int i, int j, int leafGoreType)
  {
    this.EmitLivingTreeLeaf_Below(i, j, leafGoreType);
    if (this._rand.Next(2) != 0)
      return;
    this.EmitLivingTreeLeaf_Sideways(i, j, leafGoreType);
  }

  private void EmitLivingTreeLeaf_Below(int x, int y, int leafGoreType)
  {
    Tile testTile = Main.tile[x, y + 1];
    if (WorldGen.SolidTile(testTile) || testTile.liquid > (byte) 0)
      return;
    float windForVisuals = Main.WindForVisuals;
    if ((double) windForVisuals < -0.20000000298023224 && (WorldGen.SolidTile(Main.tile[x - 1, y + 1]) || WorldGen.SolidTile(Main.tile[x - 2, y + 1])) || (double) windForVisuals > 0.20000000298023224 && (WorldGen.SolidTile(Main.tile[x + 1, y + 1]) || WorldGen.SolidTile(Main.tile[x + 2, y + 1])))
      return;
    Gore.NewGorePerfect(new Vector2((float) (x * 16 /*0x10*/), (float) (y * 16 /*0x10*/ + 16 /*0x10*/)), Vector2.Zero, leafGoreType).Frame.CurrentColumn = Main.tile[x, y].color();
  }

  private void EmitLivingTreeLeaf_Sideways(int x, int y, int leafGoreType)
  {
    int num1 = 0;
    if ((double) Main.WindForVisuals > 0.20000000298023224)
      num1 = 1;
    else if ((double) Main.WindForVisuals < -0.20000000298023224)
      num1 = -1;
    Tile testTile = Main.tile[x + num1, y];
    if (WorldGen.SolidTile(testTile) || testTile.liquid > (byte) 0)
      return;
    int num2 = 0;
    if (num1 == -1)
      num2 = -10;
    Gore.NewGorePerfect(new Vector2((float) (x * 16 /*0x10*/ + 8 + 4 * num1 + num2), (float) (y * 16 /*0x10*/ + 8)), Vector2.Zero, leafGoreType).Frame.CurrentColumn = Main.tile[x, y].color();
  }

  private void EmitLiquidDrops(int j, int i, Tile tileCache, ushort typeCache)
  {
    int num1 = 60;
    switch (typeCache)
    {
      case 374:
        num1 = 120;
        break;
      case 375:
        num1 = 180;
        break;
      case 461:
        num1 = 180;
        break;
    }
    if (tileCache.liquid != (byte) 0 || this._rand.Next(num1 * 2) != 0)
      return;
    Rectangle rectangle1 = new Rectangle(i * 16 /*0x10*/, j * 16 /*0x10*/, 16 /*0x10*/, 16 /*0x10*/);
    rectangle1.X -= 34;
    rectangle1.Width += 68;
    rectangle1.Y -= 100;
    rectangle1.Height = 400;
    for (int index = 0; index < 600; ++index)
    {
      Gore gore = this._gore[index];
      if (gore.active && gore.type >= 0 && gore.type < GoreID.Count && GoreID.Sets.IsDrip[gore.type])
      {
        Rectangle rectangle2 = new Rectangle((int) gore.position.X, (int) gore.position.Y, 16 /*0x10*/, 16 /*0x10*/);
        if (rectangle1.Intersects(rectangle2))
          return;
      }
    }
    Vector2 Position = new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/));
    int num2 = 706;
    switch (Main.waterStyle)
    {
      case 12:
        num2 = 1147;
        break;
      case 13:
        num2 = 706;
        break;
      case 14:
        num2 = 706;
        break;
      default:
        if (Main.waterStyle > 1)
        {
          num2 = 706 + Main.waterStyle - 1;
          break;
        }
        break;
    }
    if (typeCache == (ushort) 374)
      num2 = 716;
    if (typeCache == (ushort) 375)
      num2 = 717;
    if (typeCache == (ushort) 461)
    {
      num2 = 943;
      if (Main.SceneMetrics.ZoneCorrupt)
        num2 = 1160;
      if (Main.SceneMetrics.ZoneCrimson)
        num2 = 1161;
      if (Main.SceneMetrics.ZoneHallow)
        num2 = 1162;
    }
    if (typeCache == (ushort) 709)
      num2 = 1383;
    Vector2 Velocity = new Vector2();
    int Type = num2;
    this._gore[Gore.NewGore(Position, Velocity, Type)].velocity *= 0.0f;
  }

  private float GetWindCycle(int x, int y, double windCounter)
  {
    if (!Main.SettingsEnabled_TilesSwayInWind)
      return 0.0f;
    float num1 = (float) ((double) x * 0.5 + (double) (y / 100) * 0.5);
    float num2 = (float) Math.Cos(windCounter * 6.2831854820251465 + (double) num1) * 0.5f;
    float num3;
    if (Main.remixWorld)
    {
      if ((double) y <= Main.worldSurface)
        return 0.0f;
      num3 = num2 + Main.WindForVisuals;
    }
    else
    {
      if ((double) y >= Main.worldSurface)
        return 0.0f;
      num3 = num2 + Main.WindForVisuals;
    }
    float lerpValue = Utils.GetLerpValue(0.08f, 0.18f, Math.Abs(Main.WindForVisuals), true);
    return num3 * lerpValue;
  }

  private bool ShouldSwayInWind(int x, int y, Tile tileCache)
  {
    return Main.SettingsEnabled_TilesSwayInWind && TileID.Sets.SwaysInWindBasic[(int) tileCache.type] && (tileCache.type != (ushort) 227 || tileCache.frameX != (short) 204 && tileCache.frameX != (short) 238 && tileCache.frameX != (short) 408 && tileCache.frameX != (short) 442 && tileCache.frameX != (short) 476);
  }

  private void UpdateLeafFrequency()
  {
    float num = Math.Abs(Main.WindForVisuals);
    this._leafFrequency = (double) num > 0.10000000149011612 ? ((double) num > 0.20000000298023224 ? ((double) num > 0.30000001192092896 ? ((double) num > 0.40000000596046448 ? ((double) num > 0.5 ? ((double) num > 0.60000002384185791 ? ((double) num > 0.699999988079071 ? ((double) num > 0.800000011920929 ? ((double) num > 0.89999997615814209 ? ((double) num > 1.0 ? ((double) num > 1.1000000238418579 ? 10 : 20) : 30) : 40) : 50) : 75) : 130) : 200) : 300) : 450) : 1000) : 2000;
    this._leafFrequency *= 7;
  }

  private void EnsureWindGridSize()
  {
    int firstTileX;
    int lastTileX;
    int firstTileY;
    int lastTileY;
    TileDrawing.GetScreenDrawArea(!Main.drawToScreen, out Vector2 _, out firstTileX, out lastTileX, out firstTileY, out lastTileY);
    this._windGrid.SetSize(lastTileX - firstTileX, lastTileY - firstTileY);
  }

  private void EmitTreeLeaves(int tilePosX, int tilePosY, int grassPosX, int grassPosY)
  {
    if (!this._isActiveAndNotPaused)
      return;
    int treeHeight = grassPosY - tilePosY;
    Tile topTile = Main.tile[tilePosX, tilePosY];
    if (topTile.liquid > (byte) 0)
      return;
    int passStyle;
    WorldGen.GetTreeLeaf(tilePosX, topTile, Main.tile[grassPosX, grassPosY], ref treeHeight, out int _, out passStyle);
    if (passStyle == -1 || passStyle == 912 || passStyle == 913 || passStyle == 1278)
      return;
    bool flag1 = passStyle >= 917 && passStyle <= 925 || passStyle >= 1113 && passStyle <= 1121;
    int maxValue = this._leafFrequency;
    bool flag2 = tilePosX - grassPosX != 0;
    if (flag1)
      maxValue /= 2;
    if (!WorldGen.DoesWindBlowAtThisHeight(tilePosY))
      maxValue = 10000;
    if (flag2)
      maxValue *= 3;
    if (this._rand.Next(maxValue) != 0)
      return;
    int max = 2;
    Vector2 vector2 = new Vector2((float) (tilePosX * 16 /*0x10*/ + 8), (float) (tilePosY * 16 /*0x10*/ + 8));
    if (flag2)
    {
      int num1 = tilePosX - grassPosX;
      vector2.X += (float) (num1 * 12);
      int num2 = 0;
      if (topTile.frameY == (short) 220)
        num2 = 1;
      else if (topTile.frameY == (short) 242)
        num2 = 2;
      if (topTile.frameX == (short) 66)
      {
        switch (num2)
        {
          case 0:
            vector2 += new Vector2(0.0f, -6f);
            break;
          case 1:
            vector2 += new Vector2(0.0f, -6f);
            break;
          case 2:
            vector2 += new Vector2(0.0f, 8f);
            break;
        }
      }
      else
      {
        switch (num2)
        {
          case 0:
            vector2 += new Vector2(0.0f, 4f);
            break;
          case 1:
            vector2 += new Vector2(2f, -6f);
            break;
          case 2:
            vector2 += new Vector2(6f, -6f);
            break;
        }
      }
    }
    else
    {
      vector2 += new Vector2(-16f, -16f);
      if (flag1)
        vector2.Y -= (float) (Main.rand.Next(0, 28) * 4);
    }
    if (WorldGen.SolidTile(vector2.ToTileCoordinates()))
      return;
    Gore.NewGoreDirect(vector2, Utils.RandomVector2(Main.rand, (float) -max, (float) max), passStyle, (float) (0.699999988079071 + (double) Main.rand.NextFloat() * 0.60000002384185791)).Frame.CurrentColumn = Main.tile[tilePosX, tilePosY].color();
  }

  private void DrawSpecialTilesLegacy(Vector2 screenPosition, Vector2 offSet)
  {
    if (this._specialTilesCount == 0)
      return;
    this.RestartLayeredBatch();
    for (int index1 = 0; index1 < this._specialTilesCount; ++index1)
    {
      int x = this._specialTileX[index1];
      int y = this._specialTileY[index1];
      Tile tile = Main.tile[x, y];
      ushort type1 = tile.type;
      short frameX1 = tile.frameX;
      short frameY = tile.frameY;
      Main.tileBatch.SetLayer(0U);
      if (type1 == (ushort) 237)
        Main.tileBatch.Draw(TextureAssets.SunOrb.Value, new Vector2((float) (x * 16 /*0x10*/ - (int) screenPosition.X) + 8f, (float) (y * 16 /*0x10*/ - (int) screenPosition.Y - 36)) + offSet, new Rectangle?(new Rectangle(0, 0, TextureAssets.SunOrb.Width(), TextureAssets.SunOrb.Height())), (VertexColors) new Color((int) Main.mouseTextColor, (int) Main.mouseTextColor, (int) Main.mouseTextColor, 0), new Vector2((float) (TextureAssets.SunOrb.Width() / 2), (float) (TextureAssets.SunOrb.Height() / 2)), 1f, SpriteEffects.None);
      if (type1 == (ushort) 334 && frameX1 >= (short) 5000)
      {
        int num1 = (int) frameX1;
        int num2 = 0;
        int type2 = num1 % 5000 - 100;
        for (; num1 >= 5000; num1 -= 5000)
          ++num2;
        int frameX2 = (int) Main.tile[x + 1, y].frameX;
        int prefixWeWant = frameX2 < 25000 ? frameX2 - 10000 : frameX2 - 25000;
        Item obj = new Item();
        obj.netDefaults(type2);
        obj.Prefix(prefixWeWant);
        Main.instance.LoadItem(obj.type);
        Texture2D texture2D = TextureAssets.Item[obj.type].Value;
        Rectangle rectangle = Main.itemAnimations[obj.type] == null ? texture2D.Frame() : Main.itemAnimations[obj.type].GetFrame(texture2D);
        int width = rectangle.Width;
        int height = rectangle.Height;
        float num3 = 1f;
        if (width > 40 || height > 40)
          num3 = width <= height ? 40f / (float) height : 40f / (float) width;
        float scale = num3 * obj.scale;
        SpriteEffects effects = SpriteEffects.None;
        if (num2 >= 3)
          effects = SpriteEffects.FlipHorizontally;
        Color color = Lighting.GetColor(x, y);
        Main.tileBatch.Draw(texture2D, new Vector2((float) (x * 16 /*0x10*/ - (int) screenPosition.X + 24), (float) (y * 16 /*0x10*/ - (int) screenPosition.Y + 8)) + offSet, new Rectangle?(rectangle), (VertexColors) Lighting.GetColor(x, y), new Vector2((float) (width / 2), (float) (height / 2)), scale, effects);
        if (obj.color != new Color())
          Main.tileBatch.Draw(texture2D, new Vector2((float) (x * 16 /*0x10*/ - (int) screenPosition.X + 24), (float) (y * 16 /*0x10*/ - (int) screenPosition.Y + 8)) + offSet, new Rectangle?(rectangle), (VertexColors) obj.GetColor(color), new Vector2((float) (width / 2), (float) (height / 2)), scale, effects);
      }
      TEItemFrame result1;
      if (type1 == (ushort) 395 && TileEntity.TryGetAt<TEItemFrame>(x, y, out result1))
      {
        Item obj = result1.item;
        if (!obj.IsAir)
        {
          Vector2 screenPositionForItemCenter = new Vector2((float) (x * 16 /*0x10*/ - (int) screenPosition.X + 16 /*0x10*/), (float) (y * 16 /*0x10*/ - (int) screenPosition.Y + 16 /*0x10*/)) + offSet;
          Color color = Lighting.GetColor(x, y);
          double num = (double) ItemSlot.DrawItemIcon(obj, 40, Main.spriteBatch, screenPositionForItemCenter, obj.scale, 20f, color);
        }
      }
      TEFoodPlatter result2;
      if (type1 == (ushort) 520 && TileEntity.TryGetAt<TEFoodPlatter>(x, y, out result2))
      {
        Item obj = result2.item;
        if (!obj.IsAir)
        {
          Main.instance.LoadItem(obj.type);
          Texture2D texture2D = TextureAssets.Item[obj.type].Value;
          Rectangle rectangle = !ItemID.Sets.IsFood[obj.type] ? texture2D.Frame() : texture2D.Frame(verticalFrames: 3, frameY: 2);
          int width = rectangle.Width;
          int height = rectangle.Height;
          float num = 1f;
          SpriteEffects effects = tile.frameX == (short) 0 ? SpriteEffects.FlipHorizontally : SpriteEffects.None;
          Color color = Lighting.GetColor(x, y);
          Color currentColor = color;
          float scale1 = 1f;
          ItemSlot.GetItemLight(ref currentColor, ref scale1, obj);
          float scale2 = num * scale1;
          Vector2 position = new Vector2((float) (x * 16 /*0x10*/ - (int) screenPosition.X + 8), (float) (y * 16 /*0x10*/ - (int) screenPosition.Y + 16 /*0x10*/)) + offSet;
          position.Y += 2f;
          Vector2 origin = new Vector2((float) (width / 2), (float) height);
          Main.tileBatch.Draw(texture2D, position, new Rectangle?(rectangle), (VertexColors) currentColor, origin, scale2, effects);
          if (obj.color != new Color())
            Main.tileBatch.Draw(texture2D, position, new Rectangle?(rectangle), (VertexColors) obj.GetColor(color), origin, scale2, effects);
        }
      }
      TEWeaponsRack result3;
      if (type1 == (ushort) 471 && TileEntity.TryGetAt<TEWeaponsRack>(x, y, out result3))
      {
        Item obj = result3.item;
        if (!obj.IsAir)
        {
          Vector2 screenPositionForItemCenter = new Vector2((float) (x * 16 /*0x10*/ - (int) screenPosition.X + 24), (float) (y * 16 /*0x10*/ - (int) screenPosition.Y + 24)) + offSet;
          Color color = Lighting.GetColor(x, y);
          bool flip = true;
          if (tile.frameX < (short) 54)
            flip = false;
          double num = (double) ItemSlot.DrawItemIcon(obj, 40, Main.spriteBatch, screenPositionForItemCenter, obj.scale, 40f, color, flip: flip);
        }
      }
      if (type1 == (ushort) 620)
      {
        Texture2D texture = TextureAssets.Extra[202].Value;
        int num4 = 2;
        Main.critterCage = true;
        int waterAnimalCageFrame = this.GetWaterAnimalCageFrame(x, y, (int) frameX1, (int) frameY);
        int index2 = 8;
        int num5 = Main.butterflyCageFrame[index2, waterAnimalCageFrame];
        int num6 = 6;
        float num7 = 1f;
        Rectangle rectangle = new Rectangle(0, 34 * num5, 32 /*0x20*/, 32 /*0x20*/);
        Vector2 position1 = new Vector2((float) (x * 16 /*0x10*/ - (int) screenPosition.X), (float) (y * 16 /*0x10*/ - (int) screenPosition.Y + num4)) + offSet;
        Main.tileBatch.Draw(texture, position1, new Rectangle?(rectangle), (VertexColors) new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue), Vector2.Zero, 1f, SpriteEffects.None);
        for (int index3 = 0; index3 < num6; ++index3)
        {
          Color colors = (new Color((int) sbyte.MaxValue, (int) sbyte.MaxValue, (int) sbyte.MaxValue, 0).MultiplyRGBA(Main.hslToRgb((float) (((double) Main.GlobalTimeWrappedHourly + (double) index3 / (double) num6) % 1.0), 1f, 0.5f)) * (float) (1.0 - (double) num7 * 0.5)) with
          {
            A = 0
          };
          int num8 = 2;
          Vector2 position2 = position1 + ((float) ((double) index3 / (double) num6 * 6.2831854820251465)).ToRotationVector2() * (float) ((double) num8 * (double) num7 + 2.0);
          Main.tileBatch.Draw(texture, position2, new Rectangle?(rectangle), (VertexColors) colors, Vector2.Zero, 1f, SpriteEffects.None);
        }
        Main.tileBatch.Draw(texture, position1, new Rectangle?(rectangle), (VertexColors) (new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * 0.1f), Vector2.Zero, 1f, SpriteEffects.None);
      }
    }
  }

  private void DrawEntities_DisplayDolls()
  {
    Main.spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, Main.DefaultSamplerState, DepthStencilState.None, Main.Rasterizer, (Effect) null, Main.Transform);
    foreach (KeyValuePair<Point, int> tileEntityPosition in this._displayDollTileEntityPositions)
    {
      TEDisplayDoll result;
      if (tileEntityPosition.Value != -1 && TileEntity.TryGetAt<TEDisplayDoll>(tileEntityPosition.Key.X, tileEntityPosition.Key.Y, out result))
        result.Draw(tileEntityPosition.Key.X, tileEntityPosition.Key.Y);
    }
    Main.spriteBatch.End();
  }

  private void DrawEntities_HatRacks()
  {
    Main.spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, Main.DefaultSamplerState, DepthStencilState.None, Main.Rasterizer, (Effect) null, Main.Transform);
    foreach (KeyValuePair<Point, int> tileEntityPosition in this._hatRackTileEntityPositions)
    {
      TEHatRack result;
      if (tileEntityPosition.Value != -1 && TileEntity.TryGetAt<TEHatRack>(tileEntityPosition.Key.X, tileEntityPosition.Key.Y, out result))
        result.Draw(tileEntityPosition.Key.X, tileEntityPosition.Key.Y);
    }
    Main.spriteBatch.End();
  }

  private void DrawTrees()
  {
    Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
    Vector2 zero = Vector2.Zero;
    int index1 = 0;
    int num1 = this._specialsCount[index1];
    float num2 = 0.08f;
    float num3 = 0.06f;
    for (int index2 = 0; index2 < num1; ++index2)
    {
      Point point = this._specialPositions[index1][index2];
      int x = point.X;
      int y1 = point.Y;
      Tile t = Main.tile[x, y1];
      if (t != null && t.active())
      {
        ushort type = t.type;
        short frameX = t.frameX;
        short frameY1 = t.frameY;
        bool flag1 = t.wall > (ushort) 0;
        WorldGen.GetTreeFoliageDataMethod foliageDataMethod = (WorldGen.GetTreeFoliageDataMethod) null;
        try
        {
          bool flag2 = false;
          switch (type)
          {
            case 5:
              flag2 = true;
              foliageDataMethod = new WorldGen.GetTreeFoliageDataMethod(WorldGen.GetCommonTreeFoliageData);
              break;
            case 583:
            case 584:
            case 585:
            case 586:
            case 587:
            case 588:
            case 589:
              flag2 = true;
              foliageDataMethod = new WorldGen.GetTreeFoliageDataMethod(WorldGen.GetGemTreeFoliageData);
              break;
            case 596:
            case 616:
              flag2 = true;
              foliageDataMethod = new WorldGen.GetTreeFoliageDataMethod(WorldGen.GetVanityTreeFoliageData);
              break;
            case 634:
              flag2 = true;
              foliageDataMethod = new WorldGen.GetTreeFoliageDataMethod(WorldGen.GetAshTreeFoliageData);
              break;
          }
          if (flag2 && frameY1 >= (short) 198 && frameX >= (short) 22)
          {
            int treeFrame = WorldGen.GetTreeFrame(t);
            switch (frameX)
            {
              case 22:
                int treeStyle1 = 0;
                int topTextureFrameWidth1 = 80 /*0x50*/;
                int topTextureFrameHeight1 = 80 /*0x50*/;
                int xoffset1 = 0;
                int grassPosX = x + xoffset1;
                int floorY1 = y1;
                if (foliageDataMethod(x, y1, xoffset1, ref treeFrame, ref treeStyle1, out floorY1, out topTextureFrameWidth1, out topTextureFrameHeight1))
                {
                  this.EmitTreeLeaves(x, y1, grassPosX, floorY1);
                  if (treeStyle1 == 14)
                  {
                    float num4 = (float) this._rand.Next(28, 42) * 0.005f + (float) (270 - (int) Main.mouseTextColor) / 1000f;
                    if (t.color() == (byte) 0)
                    {
                      Lighting.AddLight(x, y1, 0.1f, (float) (0.20000000298023224 + (double) num4 / 2.0), 0.7f + num4);
                    }
                    else
                    {
                      Color color = WorldGen.paintColor((int) t.color());
                      float r = (float) color.R / (float) byte.MaxValue;
                      float g = (float) color.G / (float) byte.MaxValue;
                      float b = (float) color.B / (float) byte.MaxValue;
                      Lighting.AddLight(x, y1, r, g, b);
                    }
                  }
                  byte tileColor = t.color();
                  Texture2D treeTopTexture = this.GetTreeTopTexture(treeStyle1, 0, tileColor);
                  Vector2 vector2;
                  Vector2 position = vector2 = new Vector2((float) (x * 16 /*0x10*/ - (int) unscaledPosition.X + 8), (float) (y1 * 16 /*0x10*/ - (int) unscaledPosition.Y + 16 /*0x10*/)) + zero;
                  float num5 = 0.0f;
                  if (!flag1)
                    num5 = this.GetWindCycle(x, y1, this._treeWindCounter);
                  position.X += num5 * 2f;
                  position.Y += Math.Abs(num5) * 2f;
                  Color color1 = Lighting.GetColor(x, y1);
                  if (t.fullbrightBlock())
                    color1 = Color.White;
                  this.DrawNature(treeTopTexture, position, new Rectangle(treeFrame * (topTextureFrameWidth1 + 2), 0, topTextureFrameWidth1, topTextureFrameHeight1), color1, num5 * num2, new Vector2((float) (topTextureFrameWidth1 / 2), (float) topTextureFrameHeight1), 1f, SpriteEffects.None, 0.0f);
                  if (type == (ushort) 634)
                  {
                    Texture2D texture = TextureAssets.GlowMask[316].Value;
                    Color white = Color.White;
                    this.DrawNatureGlowmask(texture, position, new Rectangle?(new Rectangle(treeFrame * (topTextureFrameWidth1 + 2), 0, topTextureFrameWidth1, topTextureFrameHeight1)), white, num5 * num2, new Vector2((float) (topTextureFrameWidth1 / 2), (float) topTextureFrameHeight1), 1f, SpriteEffects.None, 0.0f);
                    break;
                  }
                  break;
                }
                continue;
              case 44:
                int treeStyle2 = 0;
                int num6 = x;
                int floorY2 = y1;
                int xoffset2 = 1;
                int topTextureFrameWidth2;
                int topTextureFrameHeight2;
                if (foliageDataMethod(x, y1, xoffset2, ref treeFrame, ref treeStyle2, out floorY2, out topTextureFrameWidth2, out topTextureFrameHeight2))
                {
                  this.EmitTreeLeaves(x, y1, num6 + xoffset2, floorY2);
                  if (treeStyle2 == 14)
                  {
                    float num7 = (float) this._rand.Next(28, 42) * 0.005f + (float) (270 - (int) Main.mouseTextColor) / 1000f;
                    if (t.color() == (byte) 0)
                    {
                      Lighting.AddLight(x, y1, 0.1f, (float) (0.20000000298023224 + (double) num7 / 2.0), 0.7f + num7);
                    }
                    else
                    {
                      Color color = WorldGen.paintColor((int) t.color());
                      float r = (float) color.R / (float) byte.MaxValue;
                      float g = (float) color.G / (float) byte.MaxValue;
                      float b = (float) color.B / (float) byte.MaxValue;
                      Lighting.AddLight(x, y1, r, g, b);
                    }
                  }
                  byte tileColor = t.color();
                  Texture2D treeBranchTexture = this.GetTreeBranchTexture(treeStyle2, 0, tileColor);
                  Vector2 position = new Vector2((float) (x * 16 /*0x10*/), (float) (y1 * 16 /*0x10*/)) - unscaledPosition.Floor() + zero + new Vector2(16f, 12f);
                  float num8 = 0.0f;
                  if (!flag1)
                    num8 = this.GetWindCycle(x, y1, this._treeWindCounter);
                  if ((double) num8 > 0.0)
                    position.X += num8;
                  position.X += Math.Abs(num8) * 2f;
                  Color color2 = Lighting.GetColor(x, y1);
                  if (t.fullbrightBlock())
                    color2 = Color.White;
                  this.DrawNature(treeBranchTexture, position, new Rectangle(0, treeFrame * 42, 40, 40), color2, num8 * num3, new Vector2(40f, 24f), 1f, SpriteEffects.None, 0.0f);
                  if (type == (ushort) 634)
                  {
                    Texture2D texture = TextureAssets.GlowMask[317].Value;
                    Color white = Color.White;
                    this.DrawNatureGlowmask(texture, position, new Rectangle?(new Rectangle(0, treeFrame * 42, 40, 40)), white, num8 * num3, new Vector2(40f, 24f), 1f, SpriteEffects.None, 0.0f);
                    break;
                  }
                  break;
                }
                continue;
              case 66:
                int treeStyle3 = 0;
                int num9 = x;
                int floorY3 = y1;
                int xoffset3 = -1;
                int topTextureFrameWidth3;
                int topTextureFrameHeight3;
                if (foliageDataMethod(x, y1, xoffset3, ref treeFrame, ref treeStyle3, out floorY3, out topTextureFrameWidth3, out topTextureFrameHeight3))
                {
                  this.EmitTreeLeaves(x, y1, num9 + xoffset3, floorY3);
                  if (treeStyle3 == 14)
                  {
                    float num10 = (float) this._rand.Next(28, 42) * 0.005f + (float) (270 - (int) Main.mouseTextColor) / 1000f;
                    if (t.color() == (byte) 0)
                    {
                      Lighting.AddLight(x, y1, 0.1f, (float) (0.20000000298023224 + (double) num10 / 2.0), 0.7f + num10);
                    }
                    else
                    {
                      Color color = WorldGen.paintColor((int) t.color());
                      float r = (float) color.R / (float) byte.MaxValue;
                      float g = (float) color.G / (float) byte.MaxValue;
                      float b = (float) color.B / (float) byte.MaxValue;
                      Lighting.AddLight(x, y1, r, g, b);
                    }
                  }
                  byte tileColor = t.color();
                  Texture2D treeBranchTexture = this.GetTreeBranchTexture(treeStyle3, 0, tileColor);
                  Vector2 position = new Vector2((float) (x * 16 /*0x10*/), (float) (y1 * 16 /*0x10*/)) - unscaledPosition.Floor() + zero + new Vector2(0.0f, 18f);
                  float num11 = 0.0f;
                  if (!flag1)
                    num11 = this.GetWindCycle(x, y1, this._treeWindCounter);
                  if ((double) num11 < 0.0)
                    position.X += num11;
                  position.X -= Math.Abs(num11) * 2f;
                  Color color3 = Lighting.GetColor(x, y1);
                  if (t.fullbrightBlock())
                    color3 = Color.White;
                  this.DrawNature(treeBranchTexture, position, new Rectangle(42, treeFrame * 42, 40, 40), color3, num11 * num3, new Vector2(0.0f, 30f), 1f, SpriteEffects.None, 0.0f);
                  if (type == (ushort) 634)
                  {
                    Texture2D texture = TextureAssets.GlowMask[317].Value;
                    Color white = Color.White;
                    this.DrawNatureGlowmask(texture, position, new Rectangle?(new Rectangle(42, treeFrame * 42, 40, 40)), white, num11 * num3, new Vector2(0.0f, 30f), 1f, SpriteEffects.None, 0.0f);
                    break;
                  }
                  break;
                }
                continue;
            }
          }
          if (type == (ushort) 323)
          {
            if (frameX >= (short) 88)
            {
              if (frameX <= (short) 132)
              {
                int num12 = 0;
                if (frameX == (short) 110)
                  num12 = 1;
                else if (frameX == (short) 132)
                  num12 = 2;
                int treeTextureIndex = 15;
                int width = 80 /*0x50*/;
                int num13 = 80 /*0x50*/;
                int num14 = 32 /*0x20*/;
                int num15 = 0;
                int palmTreeBiome = this.GetPalmTreeBiome(x, y1);
                int y2 = palmTreeBiome * 82;
                if (palmTreeBiome >= 4 && palmTreeBiome <= 7)
                {
                  treeTextureIndex = 21;
                  width = 114;
                  num13 = 98;
                  y2 = (palmTreeBiome - 4) * 98;
                  num14 = 48 /*0x30*/;
                  num15 = 2;
                }
                int frameY2 = (int) Main.tile[x, y1].frameY;
                byte tileColor = t.color();
                Texture2D treeTopTexture = this.GetTreeTopTexture(treeTextureIndex, palmTreeBiome, tileColor);
                Vector2 position = new Vector2((float) (x * 16 /*0x10*/ - (int) unscaledPosition.X - num14 + frameY2 + width / 2), (float) (y1 * 16 /*0x10*/ - (int) unscaledPosition.Y + 16 /*0x10*/ + num15)) + zero;
                float num16 = 0.0f;
                if (!flag1)
                  num16 = this.GetWindCycle(x, y1, this._treeWindCounter);
                position.X += num16 * 2f;
                position.Y += Math.Abs(num16) * 2f;
                Color color = Lighting.GetColor(x, y1);
                if (t.fullbrightBlock())
                  color = Color.White;
                this.DrawNature(treeTopTexture, position, new Rectangle(num12 * (width + 2), y2, width, num13), color, num16 * num2, new Vector2((float) (width / 2), (float) num13), 1f, SpriteEffects.None, 0.0f);
              }
            }
          }
        }
        catch
        {
        }
      }
    }
  }

  private Texture2D GetTreeTopTexture(int treeTextureIndex, int treeTextureStyle, byte tileColor)
  {
    return this._paintSystem.TryGetTreeTopAndRequestIfNotReady(treeTextureIndex, treeTextureStyle, (int) tileColor) ?? TextureAssets.TreeTop[treeTextureIndex].Value;
  }

  private Texture2D GetTreeBranchTexture(
    int treeTextureIndex,
    int treeTextureStyle,
    byte tileColor)
  {
    return this._paintSystem.TryGetTreeBranchAndRequestIfNotReady(treeTextureIndex, treeTextureStyle, (int) tileColor) ?? TextureAssets.TreeBranch[treeTextureIndex].Value;
  }

  private void DrawGrass()
  {
    Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
    Vector2 zero = Vector2.Zero;
    int index1 = 1;
    int num1 = this._specialsCount[index1];
    for (int index2 = 0; index2 < num1; ++index2)
    {
      Point point = this._specialPositions[index1][index2];
      int x = point.X;
      int y = point.Y;
      Tile tile = Main.tile[x, y];
      if (tile != null && tile.active() && this.IsVisible(tile))
      {
        ushort type = tile.type;
        short frameX = tile.frameX;
        short frameY = tile.frameY;
        int tileWidth;
        int tileHeight;
        int tileTop;
        int halfBrickHeight;
        int addFrX;
        int addFrY;
        SpriteEffects tileSpriteEffect;
        Texture2D glowTexture;
        Rectangle glowSourceRect;
        Color glowColor;
        this.GetTileDrawData(x, y, tile, type, ref frameX, ref frameY, out tileWidth, out tileHeight, out tileTop, out halfBrickHeight, out addFrX, out addFrY, out tileSpriteEffect, out glowTexture, out glowSourceRect, out glowColor);
        bool canDoDust = this._rand.Next(4) == 0;
        Color tileLight = Lighting.GetColor(x, y);
        this.DrawAnimatedTile_AdjustForVisionChangers(x, y, tile, type, frameX, frameY, ref tileLight, canDoDust);
        tileLight = this.DrawTiles_GetLightOverride(y, x, tile, type, frameX, frameY, tileLight);
        if (this._isActiveAndNotPaused & canDoDust)
          this.DrawTiles_EmitParticles(y, x, tile, type, frameX, frameY, tileLight);
        if (type == (ushort) 83 && WorldGen.IsAlchemyPlantHarvestable((int) frameX / 18, y))
        {
          ushort i = 84;
          Main.instance.LoadTiles((int) i);
        }
        Vector2 position = new Vector2((float) (x * 16 /*0x10*/ - (int) unscaledPosition.X + 8), (float) (y * 16 /*0x10*/ - (int) unscaledPosition.Y + 16 /*0x10*/)) + zero;
        float num2 = this.GetWindCycle(x, y, this._grassWindCounter);
        if (!WallID.Sets.AllowsWind[(int) tile.wall])
          num2 = 0.0f;
        if (!this.InAPlaceWithWind(x, y, 1, 1))
          num2 = 0.0f;
        float num3 = num2 + this.GetWindGridPush(x, y, 20, 0.35f);
        position.X += num3 * 1f;
        position.Y += Math.Abs(num3) * 1f;
        Texture2D tileDrawTexture = this.GetTileDrawTexture(tile, x, y);
        if (tileDrawTexture != null)
        {
          this.DrawNature(tileDrawTexture, position, new Rectangle((int) frameX + addFrX, (int) frameY + addFrY, tileWidth, tileHeight - halfBrickHeight), tileLight, num3 * 0.1f, new Vector2((float) (tileWidth / 2), (float) (16 /*0x10*/ - halfBrickHeight - tileTop)), 1f, tileSpriteEffect, 0.0f);
          if (glowTexture != null)
            this.DrawNatureGlowmask(glowTexture, position, new Rectangle?(glowSourceRect), glowColor, num3 * 0.1f, new Vector2((float) (tileWidth / 2), (float) (16 /*0x10*/ - halfBrickHeight - tileTop)), 1f, tileSpriteEffect, 0.0f);
        }
      }
    }
  }

  private void DrawAnyDirectionalGrass()
  {
    Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
    Vector2 zero = Vector2.Zero;
    int index1 = 10;
    int num1 = this._specialsCount[index1];
    for (int index2 = 0; index2 < num1; ++index2)
    {
      Point point = this._specialPositions[index1][index2];
      int x = point.X;
      int y = point.Y;
      Tile tile = Main.tile[x, y];
      if (tile != null && tile.active() && this.IsVisible(tile))
      {
        ushort type = tile.type;
        short frameX = tile.frameX;
        short frameY = tile.frameY;
        int tileWidth;
        int tileHeight;
        int tileTop;
        int halfBrickHeight;
        int addFrX;
        int addFrY;
        SpriteEffects tileSpriteEffect;
        Texture2D glowTexture;
        Color glowColor;
        this.GetTileDrawData(x, y, tile, type, ref frameX, ref frameY, out tileWidth, out tileHeight, out tileTop, out halfBrickHeight, out addFrX, out addFrY, out tileSpriteEffect, out glowTexture, out Rectangle _, out glowColor);
        bool canDoDust = this._rand.Next(4) == 0;
        Color tileLight = Lighting.GetColor(x, y);
        this.DrawAnimatedTile_AdjustForVisionChangers(x, y, tile, type, frameX, frameY, ref tileLight, canDoDust);
        tileLight = this.DrawTiles_GetLightOverride(y, x, tile, type, frameX, frameY, tileLight);
        if (this._isActiveAndNotPaused & canDoDust)
          this.DrawTiles_EmitParticles(y, x, tile, type, frameX, frameY, tileLight);
        if (type == (ushort) 83 && WorldGen.IsAlchemyPlantHarvestable((int) frameX / 18, y))
        {
          ushort i = 84;
          Main.instance.LoadTiles((int) i);
        }
        Vector2 position = new Vector2((float) (x * 16 /*0x10*/ - (int) unscaledPosition.X), (float) (y * 16 /*0x10*/ - (int) unscaledPosition.Y)) + zero;
        float num2 = this.GetWindCycle(x, y, this._grassWindCounter);
        if (!WallID.Sets.AllowsWind[(int) tile.wall])
          num2 = 0.0f;
        if (!this.InAPlaceWithWind(x, y, 1, 1))
          num2 = 0.0f;
        float pushX;
        float pushY;
        this.GetWindGridPush2Axis(x, y, 20, 0.35f, out pushX, out pushY);
        int num3 = 1;
        int num4 = 0;
        Vector2 origin = new Vector2((float) (tileWidth / 2), (float) (16 /*0x10*/ - halfBrickHeight - tileTop));
        switch ((int) frameY / 54)
        {
          case 0:
            num3 = 1;
            num4 = 0;
            origin = new Vector2((float) (tileWidth / 2), (float) (16 /*0x10*/ - halfBrickHeight - tileTop));
            position.X += 8f;
            position.Y += 16f;
            position.X += num2;
            position.Y += Math.Abs(num2);
            break;
          case 1:
            num2 *= -1f;
            num3 = -1;
            num4 = 0;
            origin = new Vector2((float) (tileWidth / 2), (float) -tileTop);
            position.X += 8f;
            position.X += -num2;
            position.Y += -Math.Abs(num2);
            break;
          case 2:
            num3 = 0;
            num4 = 1;
            origin = new Vector2(2f, (float) ((16 /*0x10*/ - halfBrickHeight - tileTop) / 2));
            position.Y += 8f;
            position.Y += num2;
            position.X += -Math.Abs(num2);
            break;
          case 3:
            num2 *= -1f;
            num3 = 0;
            num4 = -1;
            origin = new Vector2(14f, (float) ((16 /*0x10*/ - halfBrickHeight - tileTop) / 2));
            position.X += 16f;
            position.Y += 8f;
            position.Y += -num2;
            position.X += Math.Abs(num2);
            break;
        }
        float num5 = num2 + (float) ((double) pushX * (double) num3 + (double) pushY * (double) num4);
        Texture2D tileDrawTexture = this.GetTileDrawTexture(tile, x, y);
        if (tileDrawTexture != null)
        {
          this.DrawNature(tileDrawTexture, position, new Rectangle((int) frameX + addFrX, (int) frameY + addFrY, tileWidth, tileHeight - halfBrickHeight), tileLight, num5 * 0.1f, origin, 1f, tileSpriteEffect, 0.0f);
          if (glowTexture != null)
            this.DrawNatureGlowmask(glowTexture, position, new Rectangle?(new Rectangle((int) frameX + addFrX, (int) frameY + addFrY, tileWidth, tileHeight - halfBrickHeight)), glowColor, num5 * 0.1f, origin, 1f, tileSpriteEffect, 0.0f);
        }
      }
    }
  }

  private void DrawAnimatedTile_AdjustForVisionChangers(
    int i,
    int j,
    Tile tileCache,
    ushort typeCache,
    short tileFrameX,
    short tileFrameY,
    ref Color tileLight,
    bool canDoDust)
  {
    if (this._perspectivePlayer.dangerSense && TileDrawing.IsTileDangerous(this._perspectivePlayer, tileCache, typeCache))
    {
      if (tileLight.R < byte.MaxValue)
        tileLight.R = byte.MaxValue;
      if (tileLight.G < (byte) 50)
        tileLight.G = (byte) 50;
      if (tileLight.B < (byte) 50)
        tileLight.B = (byte) 50;
      if (this._isActiveAndNotPaused & canDoDust && this._rand.Next(30) == 0)
      {
        int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 60, Alpha: 100, Scale: 0.3f);
        this._dust[index].fadeIn = 1f;
        this._dust[index].velocity *= 0.1f;
        this._dust[index].noLight = true;
        this._dust[index].noGravity = true;
      }
    }
    if (this._perspectivePlayer.findTreasure && Main.IsTileSpelunkable(typeCache, tileFrameX, tileFrameY))
    {
      if (tileLight.R < (byte) 200)
        tileLight.R = (byte) 200;
      if (tileLight.G < (byte) 170)
        tileLight.G = (byte) 170;
      if (this._isActiveAndNotPaused && this._rand.Next(60) == 0 & canDoDust)
      {
        int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 204, Alpha: 150, Scale: 0.3f);
        this._dust[index].fadeIn = 1f;
        this._dust[index].velocity *= 0.1f;
        this._dust[index].noLight = true;
      }
    }
    if (!this._perspectivePlayer.biomeSight)
      return;
    Color white = Color.White;
    if (!Main.IsTileBiomeSightable(typeCache, tileFrameX, tileFrameY, ref white))
      return;
    if ((int) tileLight.R < (int) white.R)
      tileLight.R = white.R;
    if ((int) tileLight.G < (int) white.G)
      tileLight.G = white.G;
    if ((int) tileLight.B < (int) white.B)
      tileLight.B = white.B;
    if (!(this._isActiveAndNotPaused & canDoDust) || this._rand.Next(480) != 0)
      return;
    Color newColor = white;
    int index1 = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 267, Alpha: 150, newColor: newColor, Scale: 0.3f);
    this._dust[index1].noGravity = true;
    this._dust[index1].fadeIn = 1f;
    this._dust[index1].velocity *= 0.1f;
    this._dust[index1].noLightEmittence = true;
  }

  private float GetWindGridPush(int i, int j, int pushAnimationTimeTotal, float pushForcePerFrame)
  {
    int windTimeLeft;
    int directionX;
    this._windGrid.GetWindTime(i, j, pushAnimationTimeTotal, out windTimeLeft, out directionX, out int _);
    return windTimeLeft >= pushAnimationTimeTotal / 2 ? (float) (pushAnimationTimeTotal - windTimeLeft) * pushForcePerFrame * (float) directionX : (float) windTimeLeft * pushForcePerFrame * (float) directionX;
  }

  private void GetWindGridPush2Axis(
    int i,
    int j,
    int pushAnimationTimeTotal,
    float pushForcePerFrame,
    out float pushX,
    out float pushY)
  {
    int windTimeLeft;
    int directionX;
    int directionY;
    this._windGrid.GetWindTime(i, j, pushAnimationTimeTotal, out windTimeLeft, out directionX, out directionY);
    if (windTimeLeft >= pushAnimationTimeTotal / 2)
    {
      pushX = (float) (pushAnimationTimeTotal - windTimeLeft) * pushForcePerFrame * (float) directionX;
      pushY = (float) (pushAnimationTimeTotal - windTimeLeft) * pushForcePerFrame * (float) directionY;
    }
    else
    {
      pushX = (float) windTimeLeft * pushForcePerFrame * (float) directionX;
      pushY = (float) windTimeLeft * pushForcePerFrame * (float) directionY;
    }
  }

  private float GetWindGridPushComplex(
    int i,
    int j,
    int pushAnimationTimeTotal,
    float totalPushForce,
    int loops,
    bool flipDirectionPerLoop)
  {
    int windTimeLeft;
    int directionX;
    this._windGrid.GetWindTime(i, j, pushAnimationTimeTotal, out windTimeLeft, out directionX, out int _);
    double num1 = (double) windTimeLeft / (double) pushAnimationTimeTotal;
    int num2 = (int) (num1 * (double) loops);
    float num3 = (float) (num1 * (double) loops % 1.0);
    double num4 = 1.0 / (double) loops;
    if (flipDirectionPerLoop && num2 % 2 == 1)
      directionX *= -1;
    return num1 * (double) loops % 1.0 > 0.5 ? (1f - num3) * totalPushForce * (float) directionX * (float) (loops - num2) : num3 * totalPushForce * (float) directionX * (float) (loops - num2);
  }

  private void DrawMasterTrophies()
  {
    int index1 = 9;
    int num1 = this._specialsCount[index1];
    for (int index2 = 0; index2 < num1; ++index2)
    {
      Point p = this._specialPositions[index1][index2];
      Tile tile1 = Main.tile[p.X, p.Y];
      if (tile1 != null && tile1.active())
      {
        Tile tile2 = Main.tile[p.X + 1, p.Y + 1];
        if (tile2 != null && tile2.active() && this.IsVisible(tile2))
        {
          Texture2D texture2D = TextureAssets.Extra[198].Value;
          int frameY = (int) tile1.frameX / 54;
          int num2 = (uint) tile1.frameY / 72U > 0U ? 1 : 0;
          int horizontalFrames = 1;
          int verticalFrames = 28;
          Rectangle r = texture2D.Frame(horizontalFrames, verticalFrames, frameY: frameY);
          Vector2 origin = r.Size() / 2f;
          Vector2 worldCoordinates = p.ToWorldCoordinates(24f, 64f);
          float num3 = (float) Math.Sin((double) Main.GlobalTimeWrappedHourly * 6.2831854820251465 / 5.0);
          Vector2 vector2_1 = new Vector2(0.0f, -40f);
          Vector2 vector2_2 = worldCoordinates + vector2_1 + new Vector2(0.0f, num3 * 4f);
          Color color1 = Lighting.GetColor(p.X, p.Y);
          if (tile2.fullbrightBlock())
            color1 = Color.White;
          SpriteEffects effects = num2 != 0 ? SpriteEffects.FlipHorizontally : SpriteEffects.None;
          Main.spriteBatch.Draw(texture2D, vector2_2 - Main.screenPosition, new Rectangle?(r), color1, 0.0f, origin, 1f, effects, 0.0f);
          float num4 = (float) (Math.Sin((double) Main.GlobalTimeWrappedHourly * 6.2831854820251465 / 2.0) * 0.30000001192092896 + 0.699999988079071);
          Color color2 = color1 with { A = 0 };
          color2 = color2 * 0.1f * num4;
          for (float num5 = 0.0f; (double) num5 < 1.0; num5 += 0.166666672f)
            Main.spriteBatch.Draw(texture2D, vector2_2 - Main.screenPosition + (6.28318548f * num5).ToRotationVector2() * (float) (6.0 + (double) num3 * 2.0), new Rectangle?(r), color2, 0.0f, origin, 1f, effects, 0.0f);
        }
      }
    }
  }

  private void DrawTeleportationPylons()
  {
    int index1 = 8;
    int num1 = this._specialsCount[index1];
    for (int index2 = 0; index2 < num1; ++index2)
    {
      Point p = this._specialPositions[index1][index2];
      Tile tile1 = Main.tile[p.X, p.Y];
      if (tile1 != null && tile1.active())
      {
        Tile tile2 = Main.tile[p.X + 1, p.Y + 1];
        if (tile2 != null && tile2.active() && this.IsVisible(tile2))
        {
          Texture2D texture2D = TextureAssets.Extra[181].Value;
          int tileStyle = (int) tile1.frameX / 54;
          int num2 = 3;
          int horizontalFrames = num2 + 11;
          int verticalFrames = 8;
          int frameY = (Main.tileFrameCounter[597] + p.X + p.Y) % 64 /*0x40*/ / 8;
          Rectangle r = texture2D.Frame(horizontalFrames, verticalFrames, num2 + tileStyle, frameY);
          Rectangle rectangle = texture2D.Frame(horizontalFrames, verticalFrames, 2, frameY);
          texture2D.Frame(horizontalFrames, verticalFrames, frameY: frameY);
          Vector2 origin = r.Size() / 2f;
          Vector2 worldCoordinates = p.ToWorldCoordinates(24f, 64f);
          float num3 = (float) Math.Sin((double) Main.GlobalTimeWrappedHourly * 6.2831854820251465 / 5.0);
          Vector2 vector2 = new Vector2(0.0f, -40f);
          Vector2 center = worldCoordinates + vector2 + new Vector2(0.0f, num3 * 4f);
          if (this._isActiveAndNotPaused & this._rand.Next(4) == 0 && this._rand.Next(10) == 0)
          {
            Rectangle dustBox = Utils.CenteredRectangle(center, r.Size());
            TeleportPylonsSystem.SpawnInWorldDust(tileStyle, dustBox);
          }
          Color color1 = Lighting.GetColor(p.X, p.Y);
          if (tile2.fullbrightBlock())
            color1 = Color.White;
          Color color2 = Color.Lerp(color1, Color.White, 0.8f);
          Main.spriteBatch.Draw(texture2D, center - Main.screenPosition, new Rectangle?(r), color2 * 0.7f, 0.0f, origin, 1f, SpriteEffects.None, 0.0f);
          Color color3 = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * 0.1f * (float) (Math.Sin((double) Main.GlobalTimeWrappedHourly * 6.2831854820251465 / 1.0) * 0.20000000298023224 + 0.800000011920929);
          for (float num4 = 0.0f; (double) num4 < 1.0; num4 += 0.166666672f)
            Main.spriteBatch.Draw(texture2D, center - Main.screenPosition + (6.28318548f * num4).ToRotationVector2() * (float) (6.0 + (double) num3 * 2.0), new Rectangle?(r), color3, 0.0f, origin, 1f, SpriteEffects.None, 0.0f);
          int num5 = 0;
          bool actuallySelected;
          if (Main.InSmartCursorHighlightArea(p.X, p.Y, out actuallySelected))
          {
            num5 = 1;
            if (actuallySelected)
              num5 = 2;
          }
          if (num5 != 0)
          {
            int averageTileLighting = ((int) color2.R + (int) color2.G + (int) color2.B) / 3;
            if (averageTileLighting > 10)
            {
              Color selectionGlowColor = Colors.GetSelectionGlowColor(num5 == 2, averageTileLighting);
              Main.spriteBatch.Draw(texture2D, center - Main.screenPosition, new Rectangle?(rectangle), selectionGlowColor, 0.0f, origin, 1f, SpriteEffects.None, 0.0f);
            }
          }
        }
      }
    }
  }

  private void DrawVoidLenses()
  {
    int index1 = 6;
    int num = this._specialsCount[index1];
    this._voidLensData.Clear();
    for (int index2 = 0; index2 < num; ++index2)
    {
      Point p = this._specialPositions[index1][index2];
      VoidLensHelper voidLensHelper = new VoidLensHelper(p.ToWorldCoordinates(), 1f);
      if (!Main.gamePaused)
        voidLensHelper.Update();
      int selectionMode = 0;
      bool actuallySelected;
      if (Main.InSmartCursorHighlightArea(p.X, p.Y, out actuallySelected))
      {
        selectionMode = 1;
        if (actuallySelected)
          selectionMode = 2;
      }
      voidLensHelper.DrawToDrawData(this._voidLensData, selectionMode);
    }
    foreach (DrawData drawData in this._voidLensData)
      drawData.Draw(Main.spriteBatch);
  }

  private void DrawMultiTileGrass()
  {
    Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
    Vector2 zero = Vector2.Zero;
    int index1 = 2;
    int num = this._specialsCount[index1];
    for (int index2 = 0; index2 < num; ++index2)
    {
      Point point = this._specialPositions[index1][index2];
      int x = point.X;
      int y = point.Y;
      int sizeX = 1;
      int sizeY = 1;
      Tile tile = Main.tile[x, y];
      if (tile != null && tile.active())
      {
        switch (Main.tile[x, y].type)
        {
          case 27:
            sizeX = 2;
            sizeY = 5;
            break;
          case 233:
            sizeX = Main.tile[x, y].frameY != (short) 0 ? 2 : 3;
            sizeY = 2;
            break;
          case 236:
          case 238:
          case 702:
            sizeX = sizeY = 2;
            break;
          case 485:
          case 490:
          case 521:
          case 522:
          case 523:
          case 524:
          case 525:
          case 526:
          case 527:
          case 652:
            sizeX = 2;
            sizeY = 2;
            break;
          case 489:
            sizeX = 2;
            sizeY = 3;
            break;
          case 493:
            sizeX = 1;
            sizeY = 2;
            break;
          case 519:
            sizeX = 1;
            sizeY = this.ClimbCatTail(x, y);
            y -= sizeY - 1;
            break;
          case 530:
          case 651:
          case 705:
            sizeX = 3;
            sizeY = 2;
            break;
        }
        this.DrawMultiTileGrassInWind(unscaledPosition, zero, x, y, sizeX, sizeY);
      }
    }
  }

  private int ClimbCatTail(int originx, int originy)
  {
    int num = 0;
    int index = originy;
    while (index > 10)
    {
      Tile tile = Main.tile[originx, index];
      if (tile.active() && tile.type == (ushort) 519)
      {
        if (tile.frameX >= (short) 180)
        {
          ++num;
          break;
        }
        --index;
        ++num;
      }
      else
        break;
    }
    return num;
  }

  private void DrawMultiTileVines()
  {
    Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
    Vector2 zero = Vector2.Zero;
    int index1 = 3;
    int num = this._specialsCount[index1];
    for (int index2 = 0; index2 < num; ++index2)
    {
      Point point = this._specialPositions[index1][index2];
      int x = point.X;
      int y = point.Y;
      int sizeX = 1;
      int sizeY = 1;
      Tile tile = Main.tile[x, y];
      if (tile != null && tile.active())
      {
        switch (Main.tile[x, y].type)
        {
          case 34:
            sizeX = 3;
            sizeY = 3;
            break;
          case 42:
          case 270:
          case 271:
          case 572:
          case 581:
          case 660:
            sizeX = 1;
            sizeY = 2;
            break;
          case 91:
            sizeX = 1;
            sizeY = 3;
            break;
          case 95:
          case 126:
          case 444:
            sizeX = 2;
            sizeY = 2;
            break;
          case 454:
            sizeX = 4;
            sizeY = 3;
            break;
          case 465:
          case 591:
          case 592:
            sizeX = 2;
            sizeY = 3;
            break;
          case 698:
            sizeX = 1;
            sizeY = 1;
            break;
        }
        this.DrawMultiTileVinesInWind(unscaledPosition, zero, x, y, sizeX, sizeY);
      }
    }
  }

  private void DrawVines()
  {
    Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
    Vector2 zero = Vector2.Zero;
    int index1 = 4;
    int num = this._specialsCount[index1];
    for (int index2 = 0; index2 < num; ++index2)
    {
      Point point = this._specialPositions[index1][index2];
      int x = point.X;
      int y = point.Y;
      this.DrawVineStrip(unscaledPosition, zero, x, y);
    }
  }

  private void DrawReverseVines()
  {
    Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
    Vector2 zero = Vector2.Zero;
    int index1 = 7;
    int num = this._specialsCount[index1];
    for (int index2 = 0; index2 < num; ++index2)
    {
      Point point = this._specialPositions[index1][index2];
      int x = point.X;
      int y = point.Y;
      this.DrawRisingVineStrip(unscaledPosition, zero, x, y);
    }
  }

  private void DrawMultiTileGrassInWind(
    Vector2 screenPosition,
    Vector2 offSet,
    int topLeftX,
    int topLeftY,
    int sizeX,
    int sizeY)
  {
    float windCycle = this.GetWindCycle(topLeftX, topLeftY, this._sunflowerWindCounter);
    Vector2 vector2_1 = new Vector2((float) (topLeftX * 16 /*0x10*/ - (int) screenPosition.X) + (float) ((double) sizeX * 16.0 * 0.5), (float) (topLeftY * 16 /*0x10*/ - (int) screenPosition.Y + 16 /*0x10*/ * sizeY)) + offSet;
    float num1 = 0.07f;
    int type1 = (int) Main.tile[topLeftX, topLeftY].type;
    Texture2D texture = (Texture2D) null;
    Color color1 = Color.Transparent;
    bool flag1 = this.InAPlaceWithWind(topLeftX, topLeftY, sizeX, sizeY);
    bool flag2 = false;
    int num2 = 0;
    switch (type1)
    {
      case 27:
        color1 = Color.White;
        flag2 = true;
        num2 = 74;
        break;
      case 519:
        flag1 = this.InAPlaceWithWind(topLeftX, topLeftY, sizeX, 1);
        break;
      case 521:
      case 522:
      case 523:
      case 524:
      case 525:
      case 526:
      case 527:
        num1 = 0.0f;
        flag1 = false;
        break;
      default:
        num1 = 0.15f;
        break;
    }
    for (int index1 = topLeftX; index1 < topLeftX + sizeX; ++index1)
    {
      for (int index2 = topLeftY; index2 < topLeftY + sizeY; ++index2)
      {
        Tile tile = Main.tile[index1, index2];
        ushort type2 = tile.type;
        if ((int) type2 == type1 && this.IsVisible(tile))
        {
          double num3 = (double) Math.Abs((float) (((double) (index1 - topLeftX) + 0.5) / (double) sizeX - 0.5));
          short frameX = tile.frameX;
          short frameY = tile.frameY;
          float num4 = (float) (1.0 - (double) (index2 - topLeftY + 1) / (double) sizeY);
          if ((double) num4 == 0.0)
            num4 = 0.1f;
          if (!flag1)
            num4 = 0.0f;
          int tileWidth;
          int tileHeight;
          int tileTop;
          int halfBrickHeight;
          int addFrX;
          int addFrY;
          SpriteEffects tileSpriteEffect;
          this.GetTileDrawData(index1, index2, tile, type2, ref frameX, ref frameY, out tileWidth, out tileHeight, out tileTop, out halfBrickHeight, out addFrX, out addFrY, out tileSpriteEffect, out Texture2D _, out Rectangle _, out Color _);
          bool canDoDust = this._rand.Next(4) == 0;
          Color color2 = Lighting.GetColor(index1, index2);
          this.DrawAnimatedTile_AdjustForVisionChangers(index1, index2, tile, type2, frameX, frameY, ref color2, canDoDust);
          Color lightOverride = this.DrawTiles_GetLightOverride(index2, index1, tile, type2, frameX, frameY, color2);
          if (this._isActiveAndNotPaused & canDoDust)
            this.DrawTiles_EmitParticles(index2, index1, tile, type2, frameX, frameY, lightOverride);
          Vector2 vector2_2 = new Vector2((float) (index1 * 16 /*0x10*/ - (int) screenPosition.X), (float) (index2 * 16 /*0x10*/ - (int) screenPosition.Y + tileTop)) + offSet;
          if (tile.type == (ushort) 493 && tile.frameY == (short) 0)
          {
            if ((double) Main.WindForVisuals >= 0.0)
              tileSpriteEffect ^= SpriteEffects.FlipHorizontally;
            if ((tileSpriteEffect & SpriteEffects.FlipHorizontally) == SpriteEffects.None)
              vector2_2.X -= 6f;
            else
              vector2_2.X += 6f;
          }
          Vector2 vector2_3 = new Vector2(windCycle * 1f, Math.Abs(windCycle) * 2f * num4);
          Vector2 origin = vector2_1 - vector2_2;
          Texture2D tileDrawTexture = this.GetTileDrawTexture(tile, index1, index2);
          if (tileDrawTexture != null)
          {
            if (flag2)
              texture = tileDrawTexture;
            SideFlags seams = SideFlags.None;
            if (index1 > topLeftX)
              seams |= SideFlags.Left;
            if (index1 < topLeftX + sizeX - 1)
              seams |= SideFlags.Right;
            if (index2 > topLeftY)
              seams |= SideFlags.Top;
            if (index2 < topLeftY + sizeY - 1)
              seams |= SideFlags.Bottom;
            this.DrawNature(tileDrawTexture, vector2_1 + new Vector2(0.0f, vector2_3.Y), new Rectangle((int) frameX + addFrX, (int) frameY + addFrY, tileWidth, tileHeight - halfBrickHeight), lightOverride, windCycle * num1 * num4, origin, 1f, tileSpriteEffect, 0.0f, seams);
            if (texture != null)
              this.DrawNatureGlowmask(texture, vector2_1 + new Vector2(0.0f, vector2_3.Y), new Rectangle?(new Rectangle((int) frameX + addFrX, (int) frameY + addFrY + num2, tileWidth, tileHeight - halfBrickHeight)), color1, windCycle * num1 * num4, origin, 1f, tileSpriteEffect, 0.0f);
          }
        }
      }
    }
  }

  private void DrawVineStrip(Vector2 screenPosition, Vector2 offSet, int x, int startY)
  {
    int num1 = 0;
    int num2 = 0;
    Vector2 vector2 = new Vector2((float) (x * 16 /*0x10*/ + 8), (float) (startY * 16 /*0x10*/ - 2));
    float num3 = MathHelper.Lerp(0.2f, 1f, Math.Abs(Main.WindForVisuals) / 1.2f);
    float num4 = -0.08f * num3;
    float windCycle = this.GetWindCycle(x, startY, this._vineWindCounter);
    float num5 = 0.0f;
    float num6 = 0.0f;
    for (int index1 = startY; index1 < Main.maxTilesY - 10; ++index1)
    {
      Tile tile1 = Main.tile[x, index1];
      if (tile1 == null)
        break;
      ushort type = tile1.type;
      if (!tile1.active() || !TileID.Sets.VineThreads[(int) type])
        break;
      ++num1;
      if (num2 >= 5)
        num4 += 0.0075f * num3;
      if (num2 >= 2)
        num4 += 1f / 400f;
      if (Main.remixWorld)
      {
        if (WallID.Sets.AllowsWind[(int) tile1.wall] && (double) index1 > Main.worldSurface)
          ++num2;
      }
      else if (WallID.Sets.AllowsWind[(int) tile1.wall] && (double) index1 < Main.worldSurface)
        ++num2;
      float windGridPush = this.GetWindGridPush(x, index1, 20, 0.01f);
      if ((double) windGridPush == 0.0 && (double) num6 != 0.0)
        num5 *= -0.78f;
      else
        num5 -= windGridPush;
      num6 = windGridPush;
      short frameX = tile1.frameX;
      short frameY = tile1.frameY;
      Color color = Lighting.GetColor(x, index1);
      int tileWidth;
      int tileHeight;
      int tileTop;
      int halfBrickHeight;
      int addFrX;
      int addFrY;
      SpriteEffects tileSpriteEffect;
      Texture2D glowTexture;
      Rectangle glowSourceRect;
      Color glowColor;
      this.GetTileDrawData(x, index1, tile1, type, ref frameX, ref frameY, out tileWidth, out tileHeight, out tileTop, out halfBrickHeight, out addFrX, out addFrY, out tileSpriteEffect, out glowTexture, out glowSourceRect, out glowColor);
      Vector2 position = new Vector2((float) -(int) screenPosition.X, (float) -(int) screenPosition.Y) + offSet + vector2;
      if (tile1.fullbrightBlock())
        color = Color.White;
      float rotation = (float) num2 * num4 * windCycle + num5;
      if (this._perspectivePlayer.biomeSight)
      {
        Color white = Color.White;
        if (Main.IsTileBiomeSightable(type, frameX, frameY, ref white))
        {
          if ((int) color.R < (int) white.R)
            color.R = white.R;
          if ((int) color.G < (int) white.G)
            color.G = white.G;
          if ((int) color.B < (int) white.B)
            color.B = white.B;
          if (this._isActiveAndNotPaused && this._rand.Next(480) == 0)
          {
            Color newColor = white;
            int index2 = Dust.NewDust(new Vector2((float) (x * 16 /*0x10*/), (float) (index1 * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 267, Alpha: 150, newColor: newColor, Scale: 0.3f);
            this._dust[index2].noGravity = true;
            this._dust[index2].fadeIn = 1f;
            this._dust[index2].velocity *= 0.1f;
            this._dust[index2].noLightEmittence = true;
          }
        }
      }
      Texture2D tileDrawTexture = this.GetTileDrawTexture(tile1, x, index1);
      if (tileDrawTexture == null)
        break;
      if (this.IsVisible(tile1))
      {
        Tile tile2 = Main.tile[x, index1 + 1];
        bool flag = tile2.active() && TileID.Sets.VineThreads[(int) tile2.type];
        this.DrawNature(tileDrawTexture, position, new Rectangle((int) frameX + addFrX, (int) frameY + addFrY, tileWidth, tileHeight - halfBrickHeight), color, rotation, new Vector2((float) (tileWidth / 2), (float) (halfBrickHeight - tileTop)), 1f, tileSpriteEffect, 0.0f, flag ? SideFlags.Bottom : SideFlags.None);
        if (glowTexture != null)
          this.DrawNatureGlowmask(glowTexture, position, new Rectangle?(glowSourceRect), glowColor, rotation, new Vector2((float) (tileWidth / 2), (float) (halfBrickHeight - tileTop)), 1f, tileSpriteEffect, 0.0f);
      }
      vector2 += (rotation + 1.57079637f).ToRotationVector2() * 16f;
    }
  }

  private void DrawRisingVineStrip(Vector2 screenPosition, Vector2 offSet, int x, int startY)
  {
    int num1 = 0;
    int num2 = 0;
    Vector2 vector2 = new Vector2((float) (x * 16 /*0x10*/ + 8), (float) (startY * 16 /*0x10*/ + 16 /*0x10*/ + 2));
    float num3 = MathHelper.Lerp(0.2f, 1f, Math.Abs(Main.WindForVisuals) / 1.2f);
    float num4 = -0.08f * num3;
    float windCycle = this.GetWindCycle(x, startY, this._vineWindCounter);
    float num5 = 0.0f;
    float num6 = 0.0f;
    for (int index = startY; index > 10; --index)
    {
      Tile tile1 = Main.tile[x, index];
      if (tile1 != null)
      {
        ushort type = tile1.type;
        if (!tile1.active() || !TileID.Sets.ReverseVineThreads[(int) type])
          break;
        ++num1;
        if (num2 >= 5)
          num4 += 0.0075f * num3;
        if (num2 >= 2)
          num4 += 1f / 400f;
        if (WallID.Sets.AllowsWind[(int) tile1.wall] && (double) index < Main.worldSurface)
          ++num2;
        float windGridPush = this.GetWindGridPush(x, index, 40, -0.004f);
        if ((double) windGridPush == 0.0 && (double) num6 != 0.0)
          num5 *= -0.78f;
        else
          num5 -= windGridPush;
        num6 = windGridPush;
        short frameX = tile1.frameX;
        short frameY = tile1.frameY;
        Color color = Lighting.GetColor(x, index);
        int tileWidth;
        int tileHeight;
        int tileTop;
        int halfBrickHeight;
        int addFrX;
        int addFrY;
        SpriteEffects tileSpriteEffect;
        this.GetTileDrawData(x, index, tile1, type, ref frameX, ref frameY, out tileWidth, out tileHeight, out tileTop, out halfBrickHeight, out addFrX, out addFrY, out tileSpriteEffect, out Texture2D _, out Rectangle _, out Color _);
        Vector2 position = new Vector2((float) -(int) screenPosition.X, (float) -(int) screenPosition.Y) + offSet + vector2;
        if (tile1.fullbrightBlock())
          color = Color.White;
        float rotation = (float) num2 * -num4 * windCycle + num5;
        Texture2D tileDrawTexture = this.GetTileDrawTexture(tile1, x, index);
        if (tileDrawTexture == null)
          break;
        if (this.IsVisible(tile1))
        {
          Tile tile2 = Main.tile[x, index - 1];
          bool flag = tile2.active() && TileID.Sets.ReverseVineThreads[(int) tile2.type];
          this.DrawNature(tileDrawTexture, position, new Rectangle((int) frameX + addFrX, (int) frameY + addFrY, tileWidth, tileHeight - halfBrickHeight), color, rotation, new Vector2((float) (tileWidth / 2), (float) (halfBrickHeight - tileTop + tileHeight)), 1f, tileSpriteEffect, 0.0f, flag ? SideFlags.Top : SideFlags.None);
        }
        vector2 += (rotation - 1.57079637f).ToRotationVector2() * 16f;
      }
    }
  }

  private float GetAverageWindGridPush(
    int topLeftX,
    int topLeftY,
    int sizeX,
    int sizeY,
    int totalPushTime,
    float pushForcePerFrame)
  {
    float num1 = 0.0f;
    int num2 = 0;
    for (int index1 = 0; index1 < sizeX; ++index1)
    {
      for (int index2 = 0; index2 < sizeY; ++index2)
      {
        float windGridPush = this.GetWindGridPush(topLeftX + index1, topLeftY + index2, totalPushTime, pushForcePerFrame);
        if ((double) windGridPush != 0.0)
        {
          num1 += windGridPush;
          ++num2;
        }
      }
    }
    return num2 == 0 ? 0.0f : num1 / (float) num2;
  }

  private float GetHighestWindGridPushComplex(
    int topLeftX,
    int topLeftY,
    int sizeX,
    int sizeY,
    int totalPushTime,
    float pushForcePerFrame,
    int loops,
    bool swapLoopDir)
  {
    float windGridPushComplex1 = 0.0f;
    int num = int.MaxValue;
    for (int index1 = 0; index1 < 1; ++index1)
    {
      for (int index2 = 0; index2 < sizeY; ++index2)
      {
        int windTimeLeft;
        this._windGrid.GetWindTime(topLeftX + index1 + sizeX / 2, topLeftY + index2, totalPushTime, out windTimeLeft, out int _, out int _);
        float windGridPushComplex2 = this.GetWindGridPushComplex(topLeftX + index1, topLeftY + index2, totalPushTime, pushForcePerFrame, loops, swapLoopDir);
        if (windTimeLeft < num && windTimeLeft != 0)
        {
          windGridPushComplex1 = windGridPushComplex2;
          num = windTimeLeft;
        }
      }
    }
    return windGridPushComplex1;
  }

  private void DrawMultiTileVinesInWind(
    Vector2 screenPosition,
    Vector2 offSet,
    int topLeftX,
    int topLeftY,
    int sizeX,
    int sizeY)
  {
    float windCycle = this.GetWindCycle(topLeftX, topLeftY, this._sunflowerWindCounter);
    float num1 = windCycle;
    int totalPushTime = 60;
    float pushForcePerFrame = 1.26f;
    float windGridPushComplex = this.GetHighestWindGridPushComplex(topLeftX, topLeftY, sizeX, sizeY, totalPushTime, pushForcePerFrame, 3, true);
    float num2 = windCycle + windGridPushComplex;
    Vector2 vector2_1 = new Vector2((float) (topLeftX * 16 /*0x10*/ - (int) screenPosition.X) + (float) ((double) sizeX * 16.0 * 0.5), (float) (topLeftY * 16 /*0x10*/ - (int) screenPosition.Y)) + offSet;
    Tile tile1 = Main.tile[topLeftX, topLeftY];
    int type1 = (int) tile1.type;
    Vector2 vector2_2 = new Vector2(0.0f, -2f);
    Vector2 vector2_3 = vector2_1 + vector2_2;
    bool flag1;
    switch (type1)
    {
      case 465:
      case 591:
      case 592:
        flag1 = WorldGen.IsBelowANonHammeredPlatform(topLeftX, topLeftY) && WorldGen.IsBelowANonHammeredPlatform(topLeftX + 1, topLeftY);
        break;
      default:
        flag1 = sizeX == 1 && WorldGen.IsBelowANonHammeredPlatform(topLeftX, topLeftY);
        break;
    }
    if (flag1)
    {
      vector2_3.Y -= 8f;
      vector2_2.Y -= 8f;
    }
    Texture2D texture1 = (Texture2D) null;
    Color color1 = Color.Transparent;
    float? nullable = new float?();
    float num3 = 1f;
    float num4 = -4f;
    bool flag2 = false;
    bool flag3 = false;
    float num5 = 0.15f;
    switch (type1)
    {
      case 34:
      case 126:
        nullable = new float?(1f);
        num4 = 0.0f;
        switch ((int) tile1.frameY / 54 + (int) tile1.frameX / 108 * 37)
        {
          case 9:
            nullable = new float?();
            num4 = -1f;
            flag2 = true;
            num5 *= 0.3f;
            break;
          case 11:
            num5 *= 0.5f;
            break;
          case 12:
            nullable = new float?();
            num4 = -1f;
            break;
          case 18:
            nullable = new float?();
            num4 = -1f;
            break;
          case 21:
            nullable = new float?();
            num4 = -1f;
            break;
          case 23:
            nullable = new float?(0.0f);
            break;
          case 25:
            nullable = new float?();
            num4 = -1f;
            flag2 = true;
            break;
          case 32 /*0x20*/:
            num5 *= 0.5f;
            break;
          case 33:
            num5 *= 0.5f;
            break;
          case 35:
            nullable = new float?(0.0f);
            break;
          case 36:
            nullable = new float?();
            num4 = -1f;
            flag2 = true;
            break;
          case 37:
            nullable = new float?();
            num4 = -1f;
            flag2 = true;
            num5 *= 0.5f;
            break;
          case 39:
            nullable = new float?();
            num4 = -1f;
            flag2 = true;
            break;
          case 40:
          case 41:
          case 42:
          case 43:
            nullable = new float?();
            num4 = -2f;
            flag2 = true;
            num5 *= 0.5f;
            break;
          case 44:
            nullable = new float?();
            num4 = -3f;
            break;
          case 54:
          case 55:
          case 60:
          case 65:
          case 67:
          case 68:
          case 70:
            nullable = new float?(0.0f);
            break;
        }
        break;
      case 42:
        nullable = new float?(1f);
        num4 = 0.0f;
        switch ((int) tile1.frameY / 36)
        {
          case 0:
            nullable = new float?();
            num4 = -1f;
            break;
          case 9:
            nullable = new float?(0.0f);
            break;
          case 12:
            nullable = new float?();
            num4 = -1f;
            break;
          case 14:
            nullable = new float?();
            num4 = -1f;
            break;
          case 28:
            nullable = new float?();
            num4 = -1f;
            break;
          case 30:
            nullable = new float?(0.0f);
            break;
          case 32 /*0x20*/:
            nullable = new float?(0.0f);
            break;
          case 33:
            nullable = new float?(0.0f);
            break;
          case 34:
            nullable = new float?();
            num4 = -1f;
            break;
          case 35:
            nullable = new float?(0.0f);
            break;
          case 38:
            nullable = new float?();
            num4 = -1f;
            break;
          case 39:
            nullable = new float?();
            num4 = -1f;
            flag2 = true;
            break;
          case 40:
          case 41:
          case 42:
          case 43:
            nullable = new float?(0.0f);
            nullable = new float?();
            num4 = -1f;
            flag2 = true;
            break;
          case 54:
          case 55:
          case 60:
          case 65:
          case 67:
          case 70:
            nullable = new float?(0.0f);
            break;
        }
        break;
      case 95:
      case 270:
      case 271:
      case 444:
      case 454:
      case 572:
      case 581:
      case 660:
        nullable = new float?(1f);
        num4 = 0.0f;
        break;
      case 591:
        num3 = 0.5f;
        num4 = -2f;
        break;
      case 592:
        num3 = 0.5f;
        num4 = -2f;
        texture1 = TextureAssets.GlowMask[294].Value;
        color1 = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
        break;
      case 698:
        num3 = 0.5f;
        num4 = -1f;
        offSet.X -= 10f;
        flag3 = true;
        break;
    }
    if (flag2)
      vector2_3 += new Vector2(0.0f, 16f);
    float num6 = num5 * -1f;
    bool flag4 = this.InAPlaceWithWind(topLeftX, topLeftY, sizeX, sizeY);
    if (flag3 || !flag4)
      num2 -= num1;
    ulong num7 = 0;
    for (int index1 = topLeftX; index1 < topLeftX + sizeX; ++index1)
    {
      for (int index2 = topLeftY; index2 < topLeftY + sizeY; ++index2)
      {
        Tile tile2 = Main.tile[index1, index2];
        ushort type2 = tile2.type;
        if ((int) type2 == type1 && this.IsVisible(tile2))
        {
          double num8 = (double) Math.Abs((float) (((double) (index1 - topLeftX) + 0.5) / (double) sizeX - 0.5));
          short frameX = tile2.frameX;
          short frameY = tile2.frameY;
          float num9 = (float) (index2 - topLeftY + 1) / (float) sizeY;
          if ((double) num9 == 0.0)
            num9 = 0.1f;
          if (nullable.HasValue)
            num9 = nullable.Value;
          if (flag2 && index2 == topLeftY)
            num9 = 0.0f;
          int tileWidth;
          int tileHeight;
          int tileTop;
          int halfBrickHeight;
          int addFrX;
          int addFrY;
          SpriteEffects tileSpriteEffect;
          this.GetTileDrawData(index1, index2, tile2, type2, ref frameX, ref frameY, out tileWidth, out tileHeight, out tileTop, out halfBrickHeight, out addFrX, out addFrY, out tileSpriteEffect, out Texture2D _, out Rectangle _, out Color _);
          bool canDoDust = this._rand.Next(4) == 0;
          Color color2 = Lighting.GetColor(index1, index2);
          this.DrawAnimatedTile_AdjustForVisionChangers(index1, index2, tile2, type2, frameX, frameY, ref color2, canDoDust);
          Color lightOverride = this.DrawTiles_GetLightOverride(index2, index1, tile2, type2, frameX, frameY, color2);
          if (this._isActiveAndNotPaused & canDoDust)
            this.DrawTiles_EmitParticles(index2, index1, tile2, type2, frameX, frameY, lightOverride);
          Vector2 vector2_4 = new Vector2((float) (index1 * 16 /*0x10*/ - (int) screenPosition.X), (float) (index2 * 16 /*0x10*/ - (int) screenPosition.Y + tileTop)) + offSet + vector2_2;
          Vector2 vector2_5 = new Vector2(num2 * num3, Math.Abs(num2) * num4 * num9);
          Vector2 origin1 = vector2_3 - vector2_4;
          Texture2D tileDrawTexture = this.GetTileDrawTexture(tile2, index1, index2);
          if (tileDrawTexture != null)
          {
            Vector2 position1 = vector2_3 + new Vector2(0.0f, vector2_5.Y);
            Rectangle rectangle1 = new Rectangle((int) frameX + addFrX, (int) frameY + addFrY, tileWidth, tileHeight - halfBrickHeight);
            float num10 = num2 * num6 * num9;
            if (type2 == (ushort) 660 && index2 == topLeftY + sizeY - 1)
            {
              Texture2D texture2 = TextureAssets.Extra[260].Value;
              double num11 = ((double) ((index1 + index2) % 200) * 0.10999999940395355 + Main.timeForVisualEffects / 360.0) % 1.0;
              Color white = Color.White;
              Main.spriteBatch.Draw(texture2, position1, new Rectangle?(rectangle1), white, num10, origin1, 1f, tileSpriteEffect, 0.0f);
            }
            Main.spriteBatch.Draw(tileDrawTexture, position1, new Rectangle?(rectangle1), lightOverride, num10, origin1, 1f, tileSpriteEffect, 0.0f);
            if (type2 == (ushort) 660 && index2 == topLeftY + sizeY - 1)
            {
              Texture2D texture3 = TextureAssets.Extra[260].Value;
              Color rgb = Main.hslToRgb((float) (((double) ((index1 + index2) % 200) * 0.10999999940395355 + Main.timeForVisualEffects / 360.0) % 1.0), 1f, 0.8f) with
              {
                A = 127 /*0x7F*/
              };
              Rectangle rectangle2 = rectangle1;
              Vector2 position2 = position1;
              Vector2 origin2 = origin1;
              Main.spriteBatch.Draw(texture3, position2, new Rectangle?(rectangle2), rgb, num10, origin2, 1f, tileSpriteEffect, 0.0f);
            }
            TEDeadCellsDisplayJar result;
            if (type2 == (ushort) 698 && TileEntity.TryGetAt<TEDeadCellsDisplayJar>(topLeftX, topLeftY, out result))
            {
              Item obj = result.item;
              short num12 = (short) ((int) frameX / 38);
              int num13 = 0;
              int sizeLimit;
              switch (num12)
              {
                case 1:
                  sizeLimit = 18;
                  break;
                case 2:
                  sizeLimit = 20;
                  break;
                default:
                  sizeLimit = 22;
                  num13 = -1;
                  break;
              }
              Rectangle rectangle3 = rectangle1;
              rectangle3.Y += 46;
              Rectangle rectangle4 = rectangle3;
              rectangle4.Y += 46;
              int num14 = 1;
              Color color3 = new Color(150, 150, (int) byte.MaxValue);
              if (!obj.IsAir)
              {
                num14 = obj.rare;
                if (obj.expert)
                  num14 = -12;
                switch (num14)
                {
                  case -13:
                    color3 = new Color((int) byte.MaxValue, (int) (byte) ((double) Main.masterColor * 200.0), 0);
                    break;
                  case -12:
                    color3 = new Color((int) (byte) Main.DiscoR, (int) (byte) Main.DiscoG, (int) (byte) Main.DiscoB);
                    break;
                  default:
                    color3 = obj.GetPopupRarityColor();
                    break;
                }
              }
              Vector3 hsl = Main.rgbToHsl(color3);
              float x = hsl.X;
              Color color4 = color3;
              color3 *= 0.25f;
              if (num14 != -1)
                color4 = Main.hslToRgb(x, MathHelper.Clamp(hsl.Y + 0.5f, 0.0f, 1f), MathHelper.Clamp(hsl.Z, 0.0f, 1f), (byte) 127 /*0x7F*/);
              Main.spriteBatch.Draw(tileDrawTexture, position1, new Rectangle?(rectangle4), color3, num10, origin1, 1f, tileSpriteEffect, 0.0f);
              if (!obj.IsAir)
              {
                Vector2 spinningpoint = new Vector2(-2f, (float) (24 + num13));
                switch ((int) frameX / 38)
                {
                  case 1:
                    spinningpoint.Y += 4f;
                    break;
                  case 2:
                    spinningpoint.Y += 6f;
                    break;
                }
                Vector2 screenPositionForItemCenter = position1 + spinningpoint.RotatedBy((double) num10) + new Vector2(2f, 0.0f);
                Color environmentColor = Color.Lerp(lightOverride, Color.White, 0.5f);
                double num15 = (double) ItemSlot.DrawItemIcon(obj, 40, Main.spriteBatch, screenPositionForItemCenter, obj.scale, (float) sizeLimit, environmentColor);
              }
              color3.A = byte.MaxValue;
              Main.spriteBatch.Draw(tileDrawTexture, position1, new Rectangle?(rectangle3), color4, num10, origin1, 1f, tileSpriteEffect, 0.0f);
            }
            if (texture1 != null)
              Main.spriteBatch.Draw(texture1, position1, new Rectangle?(rectangle1), color1, num10, origin1, 1f, tileSpriteEffect, 0.0f);
            TileDrawing.TileFlameData tileFlameData = this.GetTileFlameData(index1, index2, (int) type2, (int) frameY);
            if (num7 == 0UL)
              num7 = tileFlameData.flameSeed;
            tileFlameData.flameSeed = num7;
            for (int index3 = 0; index3 < tileFlameData.flameCount; ++index3)
            {
              float x = (float) Utils.RandomInt(ref tileFlameData.flameSeed, tileFlameData.flameRangeXMin, tileFlameData.flameRangeXMax) * tileFlameData.flameRangeMultX;
              float y = (float) Utils.RandomInt(ref tileFlameData.flameSeed, tileFlameData.flameRangeYMin, tileFlameData.flameRangeYMax) * tileFlameData.flameRangeMultY;
              Main.spriteBatch.Draw(tileFlameData.flameTexture, position1 + new Vector2(x, y), new Rectangle?(rectangle1), tileFlameData.flameColor, num10, origin1, 1f, tileSpriteEffect, 0.0f);
            }
          }
        }
      }
    }
  }

  private void EmitAlchemyHerbParticles(int j, int i, int style)
  {
    if (style == 0 && this._rand.Next(100) == 0)
    {
      int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/ - 4)), 16 /*0x10*/, 16 /*0x10*/, 19, Alpha: 160 /*0xA0*/, Scale: 0.1f);
      this._dust[index].velocity.X /= 2f;
      this._dust[index].velocity.Y /= 2f;
      this._dust[index].noGravity = true;
      this._dust[index].fadeIn = 1f;
    }
    if (style == 1 && this._rand.Next(100) == 0)
      Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 41, Alpha: 250, Scale: 0.8f);
    if (style == 3)
    {
      if (this._rand.Next(200) == 0)
        this._dust[Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 14, Alpha: 100, Scale: 0.2f)].fadeIn = 1.2f;
      if (this._rand.Next(75) == 0)
      {
        int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 27, Alpha: 100);
        this._dust[index].velocity.X /= 2f;
        this._dust[index].velocity.Y /= 2f;
      }
    }
    if (style == 4 && this._rand.Next(150) == 0)
    {
      int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 8, 16 /*0x10*/);
      this._dust[index].velocity.X /= 3f;
      this._dust[index].velocity.Y /= 3f;
      this._dust[index].velocity.Y -= 0.7f;
      this._dust[index].alpha = 50;
      this._dust[index].scale *= 0.1f;
      this._dust[index].fadeIn = 0.9f;
      this._dust[index].noGravity = true;
    }
    if (style == 5 && this._rand.Next(40) == 0)
    {
      int index = Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/ - 6)), 16 /*0x10*/, 16 /*0x10*/, 6, Scale: 1.5f);
      this._dust[index].velocity.Y -= 2f;
      this._dust[index].noGravity = true;
    }
    if (style != 6 || this._rand.Next(30) != 0)
      return;
    Color newColor = new Color(50, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    this._dust[Dust.NewDust(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 43, Alpha: 254, newColor: newColor, Scale: 0.5f)].velocity *= 0.0f;
  }

  private enum TileCounterType
  {
    Tree,
    WindyGrass,
    MultiTileGrass,
    MultiTileVine,
    Vine,
    BiomeGrass,
    VoidLens,
    ReverseVine,
    TeleportationPylon,
    MasterTrophy,
    AnyDirectionalGrass,
    Count,
  }

  private struct TileFlameData
  {
    public Texture2D flameTexture;
    public ulong flameSeed;
    public int flameCount;
    public Color flameColor;
    public int flameRangeXMin;
    public int flameRangeXMax;
    public int flameRangeYMin;
    public int flameRangeYMax;
    public float flameRangeMultX;
    public float flameRangeMultY;
  }
}
