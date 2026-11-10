using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics;
using Terraria.Utilities;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000CAF RID: 3247
	[Token(Token = "0x2000CAF")]
	public class TileDrawing
	{
		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06006051 RID: 24657 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006052 RID: 24658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A7A")]
		private int[] _specialsCount
		{
			[Token(Token = "0x6006051")]
			[Address(RVA = "0xA26280", Offset = "0xA26280", VA = "0xA26280")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006052")]
			[Address(RVA = "0xA262E8", Offset = "0xA262E8", VA = "0xA262E8")]
			set
			{
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06006053 RID: 24659 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006054 RID: 24660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A7B")]
		private Point[][] _specialPositions
		{
			[Token(Token = "0x6006053")]
			[Address(RVA = "0xA26354", Offset = "0xA26354", VA = "0xA26354")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006054")]
			[Address(RVA = "0xA263BC", Offset = "0xA263BC", VA = "0xA263BC")]
			set
			{
			}
		}

		// Token: 0x06006055 RID: 24661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006055")]
		[Address(RVA = "0xA26428", Offset = "0xA26428", VA = "0xA26428")]
		private void AddSpecialPoint(int x, int y, TileDrawing.TileCounterType type)
		{
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06006056 RID: 24662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A7C")]
		private Dictionary<Point, int> _displayDollTileEntityPositions
		{
			[Token(Token = "0x6006056")]
			[Address(RVA = "0xA26554", Offset = "0xA26554", VA = "0xA26554")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06006057 RID: 24663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A7D")]
		private Dictionary<Point, int> _hatRackTileEntityPositions
		{
			[Token(Token = "0x6006057")]
			[Address(RVA = "0xA2668C", Offset = "0xA2668C", VA = "0xA2668C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06006058 RID: 24664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A7E")]
		private Dictionary<Point, int> _trainingDummyTileEntityPositions
		{
			[Token(Token = "0x6006058")]
			[Address(RVA = "0xA2675C", Offset = "0xA2675C", VA = "0xA2675C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06006059 RID: 24665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A7F")]
		private Dictionary<Point, int> _itemFrameTileEntityPositions
		{
			[Token(Token = "0x6006059")]
			[Address(RVA = "0xA2682C", Offset = "0xA2682C", VA = "0xA2682C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x0600605A RID: 24666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A80")]
		private Dictionary<Point, int> _deadCellsDisplayJarTileEntityPositions
		{
			[Token(Token = "0x600605A")]
			[Address(RVA = "0xA268FC", Offset = "0xA268FC", VA = "0xA268FC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x0600605B RID: 24667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A81")]
		private Dictionary<Point, int> _foodPlatterTileEntityPositions
		{
			[Token(Token = "0x600605B")]
			[Address(RVA = "0xA269CC", Offset = "0xA269CC", VA = "0xA269CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x0600605C RID: 24668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A82")]
		private Dictionary<Point, int> _weaponRackTileEntityPositions
		{
			[Token(Token = "0x600605C")]
			[Address(RVA = "0xA26A9C", Offset = "0xA26A9C", VA = "0xA26A9C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x0600605D RID: 24669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A83")]
		private Dictionary<Point, int> _chestPositions
		{
			[Token(Token = "0x600605D")]
			[Address(RVA = "0xA26B6C", Offset = "0xA26B6C", VA = "0xA26B6C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x0600605E RID: 24670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A84")]
		private UnifiedRandom _rand
		{
			[Token(Token = "0x600605E")]
			[Address(RVA = "0xA26C3C", Offset = "0xA26C3C", VA = "0xA26C3C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x0600605F RID: 24671 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006060 RID: 24672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A85")]
		private WindGrid _windGrid
		{
			[Token(Token = "0x600605F")]
			[Address(RVA = "0xA26D0C", Offset = "0xA26D0C", VA = "0xA26D0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006060")]
			[Address(RVA = "0xA26D74", Offset = "0xA26D74", VA = "0xA26D74")]
			set
			{
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06006061 RID: 24673 RVA: 0x0002C640 File Offset: 0x0002A840
		// (set) Token: 0x06006062 RID: 24674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A86")]
		private bool _shouldShowInvisibleBlocks
		{
			[Token(Token = "0x6006061")]
			[Address(RVA = "0xA26DE0", Offset = "0xA26DE0", VA = "0xA26DE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006062")]
			[Address(RVA = "0xA26E48", Offset = "0xA26E48", VA = "0xA26E48")]
			set
			{
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06006063 RID: 24675 RVA: 0x0002C658 File Offset: 0x0002A858
		// (set) Token: 0x06006064 RID: 24676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A87")]
		private bool _shouldShowInvisibleBlocks_LastFrame
		{
			[Token(Token = "0x6006063")]
			[Address(RVA = "0xA26EB4", Offset = "0xA26EB4", VA = "0xA26EB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006064")]
			[Address(RVA = "0xA26F1C", Offset = "0xA26F1C", VA = "0xA26F1C")]
			set
			{
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06006065 RID: 24677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A88")]
		private bool[] _tileSolid
		{
			[Token(Token = "0x6006065")]
			[Address(RVA = "0xA26F88", Offset = "0xA26F88", VA = "0xA26F88")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06006066 RID: 24678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A89")]
		private bool[] _tileSolidTop
		{
			[Token(Token = "0x6006066")]
			[Address(RVA = "0xA26FEC", Offset = "0xA26FEC", VA = "0xA26FEC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06006067 RID: 24679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A8A")]
		private Dust[] _dust
		{
			[Token(Token = "0x6006067")]
			[Address(RVA = "0xA27050", Offset = "0xA27050", VA = "0xA27050")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06006068 RID: 24680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A8B")]
		private Gore[] _gore
		{
			[Token(Token = "0x6006068")]
			[Address(RVA = "0xA270B4", Offset = "0xA270B4", VA = "0xA270B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006069 RID: 24681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006069")]
		[Address(RVA = "0xA27118", Offset = "0xA27118", VA = "0xA27118")]
		public TileDrawing(TilePaintSystemV2 paintSystem)
		{
		}

		// Token: 0x0600606A RID: 24682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606A")]
		[Address(RVA = "0xA27A64", Offset = "0xA27A64", VA = "0xA27A64")]
		public void PreparePaintForTilesOnScreen()
		{
		}

		// Token: 0x0600606B RID: 24683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606B")]
		[Address(RVA = "0xA280F0", Offset = "0xA280F0", VA = "0xA280F0")]
		public void PrepareForAreaDrawing(int firstTileX, int lastTileX, int firstTileY, int lastTileY, bool prepareLazily)
		{
		}

		// Token: 0x0600606C RID: 24684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606C")]
		[Address(RVA = "0xA282F8", Offset = "0xA282F8", VA = "0xA282F8")]
		public void Update()
		{
		}

		// Token: 0x0600606D RID: 24685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606D")]
		[Address(RVA = "0xA28E14", Offset = "0xA28E14", VA = "0xA28E14")]
		public void PreDrawTiles(bool solidLayer, bool forRenderTargets, bool intoRenderTargets)
		{
		}

		// Token: 0x0600606E RID: 24686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606E")]
		[Address(RVA = "0xA291F4", Offset = "0xA291F4", VA = "0xA291F4")]
		private void DrawNature(Texture2D texture, ref Vector2 position, ref Rectangle sourceRectangle, Color color, float rotation, ref Vector2 origin, SpriteEffects effects, SideFlags seams = SideFlags.None)
		{
		}

		// Token: 0x0600606F RID: 24687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606F")]
		[Address(RVA = "0xA29310", Offset = "0xA29310", VA = "0xA29310")]
		public void PostDrawTiles(bool solidLayer, bool forRenderTargets, bool intoRenderTargets)
		{
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06006070 RID: 24688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A8C")]
		public ThreadLocal<TileDrawInfo> _currentTileDrawInfo
		{
			[Token(Token = "0x6006070")]
			[Address(RVA = "0xA26624", Offset = "0xA26624", VA = "0xA26624")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006071 RID: 24689 RVA: 0x0002C670 File Offset: 0x0002A870
		[Token(Token = "0x6006071")]
		[Address(RVA = "0xA344C4", Offset = "0xA344C4", VA = "0xA344C4")]
		private int DrawTilesThreaded(Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY, bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
		{
			return 0;
		}

		// Token: 0x06006072 RID: 24690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006072")]
		[Address(RVA = "0xA408CC", Offset = "0xA408CC", VA = "0xA408CC")]
		private void ProcessBatchFinished(int index)
		{
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06006073 RID: 24691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A8D")]
		private ThreadedRenderManager.BatchProcessCallback ProcessBatchFinishedCallback
		{
			[Token(Token = "0x6006073")]
			[Address(RVA = "0xA409D4", Offset = "0xA409D4", VA = "0xA409D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006074 RID: 24692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006074")]
		[Address(RVA = "0xA40A80", Offset = "0xA40A80", VA = "0xA40A80")]
		private void MergeDictionary(Dictionary<Point, int> dest, Dictionary<Point, int> src)
		{
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006075")]
		[Address(RVA = "0xA40C90", Offset = "0xA40C90", VA = "0xA40C90")]
		private void WaitDrawThreads(int numThreads)
		{
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006076")]
		[Address(RVA = "0xA34C00", Offset = "0xA34C00", VA = "0xA34C00")]
		public void DrawTiles(Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY, bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
		{
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006077")]
		[Address(RVA = "0xA647F8", Offset = "0xA647F8", VA = "0xA647F8")]
		public void DrawLiquidBehindTiles(int waterStyleOverride = -1)
		{
		}

		// Token: 0x06006078 RID: 24696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006078")]
		[Address(RVA = "0xA64ED4", Offset = "0xA64ED4", VA = "0xA64ED4")]
		public void Draw(bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
		{
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006079")]
		[Address(RVA = "0xA43260", Offset = "0xA43260", VA = "0xA43260")]
		private void CrawlToTopOfVineAndAddSpecialPoint(int j, int i)
		{
		}

		// Token: 0x0600607A RID: 24698 RVA: 0x0002C688 File Offset: 0x0002A888
		[Token(Token = "0x600607A")]
		[Address(RVA = "0xA67A68", Offset = "0xA67A68", VA = "0xA67A68")]
		private bool PlatformProperTopFrame(short frameX, int platformFrameWidth)
		{
			return default(bool);
		}

		// Token: 0x0600607B RID: 24699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600607B")]
		[Address(RVA = "0xA434BC", Offset = "0xA434BC", VA = "0xA434BC")]
		private void CrawlToBottomOfReverseVineAndAddSpecialPoint(int j, int i)
		{
		}

		// Token: 0x0600607C RID: 24700 RVA: 0x0002C6A0 File Offset: 0x0002A8A0
		[Token(Token = "0x600607C")]
		[Address(RVA = "0xA67AB0", Offset = "0xA67AB0", VA = "0xA67AB0")]
		private static float SmoothStep(float x)
		{
			return 0f;
		}

		// Token: 0x0600607E RID: 24702 RVA: 0x0002C6B8 File Offset: 0x0002A8B8
		[Token(Token = "0x600607E")]
		[Address(RVA = "0xA67DA4", Offset = "0xA67DA4", VA = "0xA67DA4")]
		private static float LinearNoise(float x)
		{
			return 0f;
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x0002C6D0 File Offset: 0x0002A8D0
		[Token(Token = "0x600607F")]
		[Address(RVA = "0xA67EA0", Offset = "0xA67EA0", VA = "0xA67EA0")]
		private static uint Hash(uint x)
		{
			return 0U;
		}

		// Token: 0x06006080 RID: 24704 RVA: 0x0002C6E8 File Offset: 0x0002A8E8
		[Token(Token = "0x6006080")]
		[Address(RVA = "0xA67EC8", Offset = "0xA67EC8", VA = "0xA67EC8")]
		private static uint Hash2(uint x)
		{
			return 0U;
		}

		// Token: 0x06006081 RID: 24705 RVA: 0x0002C700 File Offset: 0x0002A900
		[Token(Token = "0x6006081")]
		[Address(RVA = "0xA67EF0", Offset = "0xA67EF0", VA = "0xA67EF0")]
		private static float DistToWanderingCircle(Point pos, int gridSize, float wanderDist, float cyclesPerTick, uint seed)
		{
			return 0f;
		}

		// Token: 0x06006082 RID: 24706 RVA: 0x0002C718 File Offset: 0x0002A918
		[Token(Token = "0x6006082")]
		[Address(RVA = "0xA644E8", Offset = "0xA644E8", VA = "0xA644E8")]
		private static float LavaLightA(int tileX, int tileY)
		{
			return 0f;
		}

		// Token: 0x06006083 RID: 24707 RVA: 0x0002C730 File Offset: 0x0002A930
		[Token(Token = "0x6006083")]
		[Address(RVA = "0xA681EC", Offset = "0xA681EC", VA = "0xA681EC")]
		private bool IsVisible(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x06006084 RID: 24708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006084")]
		[Address(RVA = "0xA54194", Offset = "0xA54194", VA = "0xA54194")]
		public Texture2D GetTileDrawTexture(TileDrawInfo drawInfo, int tileX, int tileY, out EffectPass pass)
		{
			return null;
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006085")]
		[Address(RVA = "0xA689C8", Offset = "0xA689C8", VA = "0xA689C8")]
		public Texture2D GetTileDrawTexture(int tileX, int tileY, ushort tileType, short frameX, short frameY, byte tileColor, out EffectPass pass)
		{
			return null;
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006086")]
		[Address(RVA = "0xA5626C", Offset = "0xA5626C", VA = "0xA5626C")]
		private Texture2D GetTileDrawTexture(Tile tile, int tileX, int tileY, out EffectPass pass, bool nature = false)
		{
			return null;
		}

		// Token: 0x06006087 RID: 24711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006087")]
		[Address(RVA = "0xA68AD8", Offset = "0xA68AD8", VA = "0xA68AD8")]
		private Texture2D GetTileDrawTexture(Tile tile, int tileX, int tileY, int paintOverride, out EffectPass pass)
		{
			return null;
		}

		// Token: 0x06006088 RID: 24712 RVA: 0x0002C748 File Offset: 0x0002A948
		[Token(Token = "0x6006088")]
		[Address(RVA = "0xA4C97C", Offset = "0xA4C97C", VA = "0xA4C97C")]
		private int GetPalmTreeBiome(TileDrawInfo drawInfo, int worldWidth)
		{
			return 0;
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x0002C760 File Offset: 0x0002A960
		[Token(Token = "0x6006089")]
		[Address(RVA = "0xA687B4", Offset = "0xA687B4", VA = "0xA687B4")]
		private int GetPalmTreeBiome(int tileX, int tileY)
		{
			return 0;
		}

		// Token: 0x0600608A RID: 24714 RVA: 0x0002C778 File Offset: 0x0002A978
		[Token(Token = "0x600608A")]
		[Address(RVA = "0xA4C784", Offset = "0xA4C784", VA = "0xA4C784")]
		private int GetTreeBiome(TileDrawInfo drawInfo, int worldWidth)
		{
			return 0;
		}

		// Token: 0x0600608B RID: 24715 RVA: 0x0002C790 File Offset: 0x0002A990
		[Token(Token = "0x600608B")]
		[Address(RVA = "0xA6842C", Offset = "0xA6842C", VA = "0xA6842C")]
		private static int GetTreeBiome(int tileX, int tileY, int tileFrameX, int tileFrameY)
		{
			return 0;
		}

		// Token: 0x0600608C RID: 24716 RVA: 0x0002C7A8 File Offset: 0x0002A9A8
		[Token(Token = "0x600608C")]
		[Address(RVA = "0xA696A0", Offset = "0xA696A0", VA = "0xA696A0")]
		public static int GetTreeVariant(int x, int y)
		{
			return 0;
		}

		// Token: 0x0600608D RID: 24717 RVA: 0x0002C7C0 File Offset: 0x0002A9C0
		[Token(Token = "0x600608D")]
		[Address(RVA = "0xA698C8", Offset = "0xA698C8", VA = "0xA698C8")]
		private Color GetFallenStarFurnitureFlameColor()
		{
			return default(Color);
		}

		// Token: 0x0600608E RID: 24718 RVA: 0x0002C7D8 File Offset: 0x0002A9D8
		[Token(Token = "0x600608E")]
		[Address(RVA = "0xA699F0", Offset = "0xA699F0", VA = "0xA699F0")]
		private Color GetHallowedFurnitureFlameColor()
		{
			return default(Color);
		}

		// Token: 0x0600608F RID: 24719 RVA: 0x0002C7F0 File Offset: 0x0002A9F0
		[Token(Token = "0x600608F")]
		[Address(RVA = "0xA69B18", Offset = "0xA69B18", VA = "0xA69B18")]
		private Color GetCloudFurnitureFlameColor()
		{
			return default(Color);
		}

		// Token: 0x06006090 RID: 24720 RVA: 0x0002C808 File Offset: 0x0002AA08
		[Token(Token = "0x6006090")]
		[Address(RVA = "0xA69C78", Offset = "0xA69C78", VA = "0xA69C78")]
		private Color GetLibrarianFurnitureFlameColor()
		{
			return default(Color);
		}

		// Token: 0x06006091 RID: 24721 RVA: 0x0002C820 File Offset: 0x0002AA20
		[Token(Token = "0x6006091")]
		[Address(RVA = "0xA69CBC", Offset = "0xA69CBC", VA = "0xA69CBC")]
		private Color GetForbiddenFurnitureFlameColor()
		{
			return default(Color);
		}

		// Token: 0x06006092 RID: 24722 RVA: 0x0002C838 File Offset: 0x0002AA38
		[Token(Token = "0x6006092")]
		[Address(RVA = "0xA69D00", Offset = "0xA69D00", VA = "0xA69D00")]
		private Color GetBoulderFurnitureFlameColor()
		{
			return default(Color);
		}

		// Token: 0x06006093 RID: 24723 RVA: 0x0002C850 File Offset: 0x0002AA50
		[Token(Token = "0x6006093")]
		[Address(RVA = "0xA69B5C", Offset = "0xA69B5C", VA = "0xA69B5C")]
		private Color GetWrappedFurnitureFlameColor(Color baseColor, float min = 0.75f, float max = 1f)
		{
			return default(Color);
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x0002C868 File Offset: 0x0002AA68
		[Token(Token = "0x6006094")]
		[Address(RVA = "0xA69D50", Offset = "0xA69D50", VA = "0xA69D50")]
		private TileDrawing.TileFlameData GetTileFlameData(int tileX, int tileY, int type, int tileFrameY)
		{
			return default(TileDrawing.TileFlameData);
		}

		// Token: 0x06006095 RID: 24725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006095")]
		[Address(RVA = "0xA56780", Offset = "0xA56780", VA = "0xA56780")]
		private void DrawSingleTile_Flames(Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY, TileDrawInfo drawData)
		{
		}

		// Token: 0x06006096 RID: 24726 RVA: 0x0002C880 File Offset: 0x0002AA80
		[Token(Token = "0x6006096")]
		[Address(RVA = "0xA68F90", Offset = "0xA68F90", VA = "0xA68F90")]
		private int GetPalmTreeVariant(int x, int y)
		{
			return 0;
		}

		// Token: 0x06006097 RID: 24727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006097")]
		[Address(RVA = "0xA554B8", Offset = "0xA554B8", VA = "0xA554B8")]
		private void DrawXmasTree(Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY, TileDrawInfo drawData)
		{
		}

		// Token: 0x06006098 RID: 24728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006098")]
		[Address(RVA = "0xA542B0", Offset = "0xA542B0", VA = "0xA542B0")]
		private void DrawTile_MinecartTrack(Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY, TileDrawInfo drawData)
		{
		}

		// Token: 0x06006099 RID: 24729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006099")]
		[Address(RVA = "0xA413A8", Offset = "0xA413A8", VA = "0xA413A8")]
		private void DrawTile_LiquidBehindTile(bool solidLayer, bool inFrontOfPlayers, int waterStyleOverride, Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY, TileDrawInfo drawData)
		{
		}

		// Token: 0x0600609A RID: 24730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600609A")]
		[Address(RVA = "0xA6B75C", Offset = "0xA6B75C", VA = "0xA6B75C")]
		private void CacheSpecialDraws(int tileX, int tileY, ushort typeCache, short tileFrameX, short tileFrameY)
		{
		}

		// Token: 0x0600609B RID: 24731 RVA: 0x0002C898 File Offset: 0x0002AA98
		[Token(Token = "0x600609B")]
		[Address(RVA = "0xA6B3EC", Offset = "0xA6B3EC", VA = "0xA6B3EC")]
		private static Color GetFinalLight(TileDrawInfo tileDrawInfo, ushort typeCache, Color tileLight)
		{
			return default(Color);
		}

		// Token: 0x0600609C RID: 24732 RVA: 0x0002C8B0 File Offset: 0x0002AAB0
		[Token(Token = "0x600609C")]
		[Address(RVA = "0xA6C2B4", Offset = "0xA6C2B4", VA = "0xA6C2B4")]
		private static bool ShouldTileShine(ushort type, short frameX)
		{
			return default(bool);
		}

		// Token: 0x0600609D RID: 24733 RVA: 0x0002C8C8 File Offset: 0x0002AAC8
		[Token(Token = "0x600609D")]
		[Address(RVA = "0xA43E58", Offset = "0xA43E58", VA = "0xA43E58")]
		private static bool IsTileDangerous(Player localPlayer, short sTileHeader, ushort typeCache, short tileFrameX)
		{
			return default(bool);
		}

		// Token: 0x0600609E RID: 24734 RVA: 0x0002C8E0 File Offset: 0x0002AAE0
		[Token(Token = "0x600609E")]
		[Address(RVA = "0xA6C3F8", Offset = "0xA6C3F8", VA = "0xA6C3F8")]
		private static bool IsTileDangerous_CheckTouchDamage(Player localPlayer, ushort typeCache)
		{
			return default(bool);
		}

		// Token: 0x0600609F RID: 24735 RVA: 0x0002C8F8 File Offset: 0x0002AAF8
		[Token(Token = "0x600609F")]
		[Address(RVA = "0xA6C4D0", Offset = "0xA6C4D0", VA = "0xA6C4D0")]
		private static bool IsTileDangerous_CheckHot(Player localPlayer, ushort typeCache)
		{
			return default(bool);
		}

		// Token: 0x060060A0 RID: 24736 RVA: 0x0002C910 File Offset: 0x0002AB10
		[Token(Token = "0x60060A0")]
		[Address(RVA = "0xA6C574", Offset = "0xA6C574", VA = "0xA6C574")]
		private bool IsTileDrawLayerSolid(ushort typeCache)
		{
			return default(bool);
		}

		// Token: 0x060060A1 RID: 24737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A1")]
		[Address(RVA = "0xA6C630", Offset = "0xA6C630", VA = "0xA6C630")]
		private void GetTileOutlineInfo(int x, int y, ushort typeCache, ref Color tileLight, ref Texture2D highlightTexture, ref Color highlightColor)
		{
		}

		// Token: 0x060060A2 RID: 24738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A2")]
		[Address(RVA = "0xA6B574", Offset = "0xA6B574", VA = "0xA6B574")]
		private void DrawPartialLiquid(SpriteBatch spriteBatch, bool behindBlocks, TileDrawInfo tileCache, ref Vector2 position, ref Rectangle liquidSize, int liquidType, ref VertexColors colors)
		{
		}

		// Token: 0x060060A3 RID: 24739 RVA: 0x0002C928 File Offset: 0x0002AB28
		[Token(Token = "0x60060A3")]
		[Address(RVA = "0xA6C7AC", Offset = "0xA6C7AC", VA = "0xA6C7AC")]
		private bool InAPlaceWithWind(int x, int y, int width, int height)
		{
			return default(bool);
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A4")]
		[Address(RVA = "0xA4CB1C", Offset = "0xA4CB1C", VA = "0xA4CB1C")]
		private void GetTileDrawData(int x, int y, TileDrawInfo tileCache, ushort typeCache, ref short tileFrameX, ref short tileFrameY, out int tileWidth, out int tileHeight, out int tileTop, out int halfBrickHeight, out int addFrX, out int addFrY, out SpriteEffects tileSpriteEffect, out Texture2D glowTexture, ref Rectangle glowSourceRect, ref Color glowColor)
		{
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A5")]
		[Address(RVA = "0xA6CA7C", Offset = "0xA6CA7C", VA = "0xA6CA7C")]
		private void GetTileDrawData(int x, int y, bool halfBrick, ushort typeCache, ref short tileFrameX, ref short tileFrameY, out int tileWidth, out int tileHeight, out int tileTop, out int halfBrickHeight, out int addFrX, out int addFrY, out SpriteEffects tileSpriteEffect, out Texture2D glowTexture, out Rectangle glowSourceRect, out Color glowColor, out EffectPass glowEffect)
		{
		}

		// Token: 0x060060A6 RID: 24742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A6")]
		[Address(RVA = "0xA74550", Offset = "0xA74550", VA = "0xA74550")]
		private void GetTileDrawData(int x, int y, Tile tileCache, ushort typeCache, ref short tileFrameX, ref short tileFrameY, out int tileWidth, out int tileHeight, out int tileTop, out int halfBrickHeight, out int addFrX, out int addFrY, out SpriteEffects tileSpriteEffect, out Texture2D glowTexture, out Rectangle glowSourceRect, out Color glowColor)
		{
		}

		// Token: 0x060060A7 RID: 24743 RVA: 0x0002C940 File Offset: 0x0002AB40
		[Token(Token = "0x60060A7")]
		[Address(RVA = "0xA7B7E0", Offset = "0xA7B7E0", VA = "0xA7B7E0")]
		private bool IsWindBlocked(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060060A8 RID: 24744 RVA: 0x0002C958 File Offset: 0x0002AB58
		[Token(Token = "0x60060A8")]
		[Address(RVA = "0xA6C9BC", Offset = "0xA6C9BC", VA = "0xA6C9BC")]
		private int GetWaterAnimalCageFrame(int x, int y, int tileFrameX, int tileFrameY)
		{
			return 0;
		}

		// Token: 0x060060A9 RID: 24745 RVA: 0x0002C970 File Offset: 0x0002AB70
		[Token(Token = "0x60060A9")]
		[Address(RVA = "0xA6C8FC", Offset = "0xA6C8FC", VA = "0xA6C8FC")]
		private int GetSmallAnimalCageFrame(int x, int y, int tileFrameX, int tileFrameY)
		{
			return 0;
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x0002C988 File Offset: 0x0002AB88
		[Token(Token = "0x60060AA")]
		[Address(RVA = "0xA6C838", Offset = "0xA6C838", VA = "0xA6C838")]
		private int GetBigAnimalCageFrame(int x, int y, int tileFrameX, int tileFrameY)
		{
			return 0;
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AB")]
		[Address(RVA = "0xA27D90", Offset = "0xA27D90", VA = "0xA27D90")]
		private void GetScreenDrawArea(Vector2 screenPosition, Vector2 offSet, out int firstTileX, out int lastTileX, out int firstTileY, out int lastTileY)
		{
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AC")]
		[Address(RVA = "0xA65910", Offset = "0xA65910", VA = "0xA65910")]
		public void ClearCachedTileDraws(bool solidLayer)
		{
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AD")]
		[Address(RVA = "0xA43DA8", Offset = "0xA43DA8", VA = "0xA43DA8")]
		private void AddSpecialLegacyPoint(Point p)
		{
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AE")]
		[Address(RVA = "0xA43E00", Offset = "0xA43E00", VA = "0xA43E00")]
		private void AddSpecialLegacyPoint(int x, int y)
		{
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AF")]
		[Address(RVA = "0xA65800", Offset = "0xA65800", VA = "0xA65800")]
		private void ClearLegacyCachedDraws()
		{
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x0002C9A0 File Offset: 0x0002ABA0
		[Token(Token = "0x60060B0")]
		[Address(RVA = "0xA7BA0C", Offset = "0xA7BA0C", VA = "0xA7BA0C")]
		private Color DrawTiles_GetLightOverride(int j, int i, short sTileHeader, ushort typeCache, short tileFrameX, short tileFrameY, Color tileLight, bool fullBrightBlock)
		{
			return default(Color);
		}

		// Token: 0x060060B1 RID: 24753 RVA: 0x0002C9B8 File Offset: 0x0002ABB8
		[Token(Token = "0x60060B1")]
		[Address(RVA = "0xA4C498", Offset = "0xA4C498", VA = "0xA4C498")]
		private bool QuickNextCheck(uint chance)
		{
			return default(bool);
		}

		// Token: 0x060060B2 RID: 24754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B2")]
		[Address(RVA = "0xA4C4BC", Offset = "0xA4C4BC", VA = "0xA4C4BC")]
		private void DrawTiles_EmitShimmerParticles(int j, int i, ref Color tileLight)
		{
		}

		// Token: 0x060060B3 RID: 24755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B3")]
		[Address(RVA = "0xA44138", Offset = "0xA44138", VA = "0xA44138")]
		private void DrawTiles_EmitParticles(int j, int i, ushort typeCache, short tileFrameX, short tileFrameY, ref Color tileLight, bool visible)
		{
		}

		// Token: 0x060060B4 RID: 24756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B4")]
		[Address(RVA = "0xA7BDD0", Offset = "0xA7BDD0", VA = "0xA7BDD0")]
		private void EmitLivingTreeLeaf(int i, int j, int leafGoreType)
		{
		}

		// Token: 0x060060B5 RID: 24757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B5")]
		[Address(RVA = "0xA7CC68", Offset = "0xA7CC68", VA = "0xA7CC68")]
		private void EmitLivingTreeLeaf_Below(int x, int y, int leafGoreType)
		{
		}

		// Token: 0x060060B6 RID: 24758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B6")]
		[Address(RVA = "0xA7D238", Offset = "0xA7D238", VA = "0xA7D238")]
		private void EmitLivingTreeLeaf_Sideways(int x, int y, int leafGoreType)
		{
		}

		// Token: 0x060060B7 RID: 24759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B7")]
		[Address(RVA = "0xA4371C", Offset = "0xA4371C", VA = "0xA4371C")]
		private void EmitLiquidDrops(int j, int i, byte liquid, ushort typeCache)
		{
		}

		// Token: 0x060060B8 RID: 24760 RVA: 0x0002C9D0 File Offset: 0x0002ABD0
		[Token(Token = "0x60060B8")]
		[Address(RVA = "0xA7D6B0", Offset = "0xA7D6B0", VA = "0xA7D6B0")]
		private float GetWindCycle(int x, int y, double windCounter)
		{
			return 0f;
		}

		// Token: 0x060060B9 RID: 24761 RVA: 0x0002C9E8 File Offset: 0x0002ABE8
		[Token(Token = "0x60060B9")]
		[Address(RVA = "0xA7D9A4", Offset = "0xA7D9A4", VA = "0xA7D9A4")]
		private bool ShouldSwayInWind(int x, int y, ushort tileType, short frameX)
		{
			return default(bool);
		}

		// Token: 0x060060BA RID: 24762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060BA")]
		[Address(RVA = "0xA288B8", Offset = "0xA288B8", VA = "0xA288B8")]
		private void UpdateLeafFrequency()
		{
		}

		// Token: 0x060060BB RID: 24763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060BB")]
		[Address(RVA = "0xA28B40", Offset = "0xA28B40", VA = "0xA28B40")]
		private void EnsureWindGridSize()
		{
		}

		// Token: 0x060060BC RID: 24764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060BC")]
		[Address(RVA = "0xA7DAB4", Offset = "0xA7DAB4", VA = "0xA7DAB4")]
		private void EmitTreeLeaves(int tilePosX, int tilePosY, int grassPosX, int grassPosY)
		{
		}

		// Token: 0x060060BD RID: 24765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060BD")]
		[Address(RVA = "0xA659E0", Offset = "0xA659E0", VA = "0xA659E0")]
		private void DrawSpecialTilesLegacy(Vector2 screenPosition, Vector2 offSet)
		{
		}

		// Token: 0x060060BE RID: 24766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060BE")]
		[Address(RVA = "0xA33FE0", Offset = "0xA33FE0", VA = "0xA33FE0")]
		private void DrawEntities_DisplayDolls()
		{
		}

		// Token: 0x060060BF RID: 24767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060BF")]
		[Address(RVA = "0xA33B00", Offset = "0xA33B00", VA = "0xA33B00")]
		private void DrawEntities_HatRacks()
		{
		}

		// Token: 0x060060C0 RID: 24768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C0")]
		[Address(RVA = "0xA30004", Offset = "0xA30004", VA = "0xA30004")]
		private void DrawTrees()
		{
		}

		// Token: 0x060060C1 RID: 24769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060C1")]
		[Address(RVA = "0xA7E424", Offset = "0xA7E424", VA = "0xA7E424")]
		private Texture2D GetTreeTopTexture(int treeTextureIndex, int treeTextureStyle, byte tileColor, out EffectPass pass)
		{
			return null;
		}

		// Token: 0x060060C2 RID: 24770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060C2")]
		[Address(RVA = "0xA7E4FC", Offset = "0xA7E4FC", VA = "0xA7E4FC")]
		private Texture2D GetTreeBranchTexture(int treeTextureIndex, int treeTextureStyle, byte tileColor, out EffectPass pass)
		{
			return null;
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C3")]
		[Address(RVA = "0xA2D74C", Offset = "0xA2D74C", VA = "0xA2D74C")]
		private void DrawGrass()
		{
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C4")]
		[Address(RVA = "0xA2E9E4", Offset = "0xA2E9E4", VA = "0xA2E9E4")]
		private void DrawAnyDirectionalGrass()
		{
		}

		// Token: 0x060060C5 RID: 24773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C5")]
		[Address(RVA = "0xA7E5D4", Offset = "0xA7E5D4", VA = "0xA7E5D4")]
		private void DrawAnimatedTile_AdjustForVisionChangers(int i, int j, short tileSHeader, ushort typeCache, short tileFrameX, short tileFrameY, ref Color tileLight, bool canDoDust)
		{
		}

		// Token: 0x060060C6 RID: 24774 RVA: 0x0002CA00 File Offset: 0x0002AC00
		[Token(Token = "0x60060C6")]
		[Address(RVA = "0xA7F0B4", Offset = "0xA7F0B4", VA = "0xA7F0B4")]
		private float GetWindGridPush(int i, int j, int pushAnimationTimeTotal, float pushForcePerFrame)
		{
			return 0f;
		}

		// Token: 0x060060C7 RID: 24775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C7")]
		[Address(RVA = "0xA7F1B0", Offset = "0xA7F1B0", VA = "0xA7F1B0")]
		private void GetWindGridPush2Axis(int i, int j, int pushAnimationTimeTotal, float pushForcePerFrame, out float pushX, out float pushY)
		{
		}

		// Token: 0x060060C8 RID: 24776 RVA: 0x0002CA18 File Offset: 0x0002AC18
		[Token(Token = "0x60060C8")]
		[Address(RVA = "0xA7F2C8", Offset = "0xA7F2C8", VA = "0xA7F2C8")]
		private float GetWindGridPushComplex(int i, int j, int pushAnimationTimeTotal, float totalPushForce, int loops, bool flipDirectionPerLoop)
		{
			return 0f;
		}

		// Token: 0x060060C9 RID: 24777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C9")]
		[Address(RVA = "0xA2CB48", Offset = "0xA2CB48", VA = "0xA2CB48")]
		private void DrawMasterTrophies()
		{
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CA")]
		[Address(RVA = "0xA2BBA0", Offset = "0xA2BBA0", VA = "0xA2BBA0")]
		private void DrawTeleportationPylons()
		{
		}

		// Token: 0x060060CB RID: 24779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CB")]
		[Address(RVA = "0xA2B6A0", Offset = "0xA2B6A0", VA = "0xA2B6A0")]
		private void DrawVoidLenses()
		{
		}

		// Token: 0x060060CC RID: 24780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CC")]
		[Address(RVA = "0xA29CE4", Offset = "0xA29CE4", VA = "0xA29CE4")]
		private void DrawMultiTileGrass()
		{
		}

		// Token: 0x060060CD RID: 24781 RVA: 0x0002CA30 File Offset: 0x0002AC30
		[Token(Token = "0x60060CD")]
		[Address(RVA = "0xA7F44C", Offset = "0xA7F44C", VA = "0xA7F44C")]
		private int ClimbCatTail(int originx, int originy)
		{
			return 0;
		}

		// Token: 0x060060CE RID: 24782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CE")]
		[Address(RVA = "0xA29790", Offset = "0xA29790", VA = "0xA29790")]
		private void DrawMultiTileVines()
		{
		}

		// Token: 0x060060CF RID: 24783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CF")]
		[Address(RVA = "0xA3256C", Offset = "0xA3256C", VA = "0xA3256C")]
		private void DrawVines()
		{
		}

		// Token: 0x060060D0 RID: 24784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D0")]
		[Address(RVA = "0xA3388C", Offset = "0xA3388C", VA = "0xA3388C")]
		private void DrawReverseVines()
		{
		}

		// Token: 0x060060D1 RID: 24785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D1")]
		[Address(RVA = "0xA82FB4", Offset = "0xA82FB4", VA = "0xA82FB4")]
		private void DrawMultiTileGrassInWind(Vector2 screenPosition, Vector2 offSet, int topLeftX, int topLeftY, int sizeX, int sizeY)
		{
		}

		// Token: 0x060060D2 RID: 24786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D2")]
		[Address(RVA = "0xA84548", Offset = "0xA84548", VA = "0xA84548")]
		private void DrawVineStrip(Vector2 screenPosition, Vector2 offSet, int x, int startY)
		{
		}

		// Token: 0x060060D3 RID: 24787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D3")]
		[Address(RVA = "0xA82324", Offset = "0xA82324", VA = "0xA82324")]
		private void DrawRisingVineStrip(Vector2 screenPosition, Vector2 offSet, int x, int startY)
		{
		}

		// Token: 0x060060D4 RID: 24788 RVA: 0x0002CA48 File Offset: 0x0002AC48
		[Token(Token = "0x60060D4")]
		[Address(RVA = "0xA85690", Offset = "0xA85690", VA = "0xA85690")]
		private float GetAverageWindGridPush(int topLeftX, int topLeftY, int sizeX, int sizeY, int totalPushTime, float pushForcePerFrame)
		{
			return 0f;
		}

		// Token: 0x060060D5 RID: 24789 RVA: 0x0002CA60 File Offset: 0x0002AC60
		[Token(Token = "0x60060D5")]
		[Address(RVA = "0xA85778", Offset = "0xA85778", VA = "0xA85778")]
		private float GetHighestWindGridPushComplex(int topLeftX, int topLeftY, int sizeX, int sizeY, int totalPushTime, float pushForcePerFrame, int loops, bool swapLoopDir)
		{
			return 0f;
		}

		// Token: 0x060060D6 RID: 24790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D6")]
		[Address(RVA = "0xA7F6C8", Offset = "0xA7F6C8", VA = "0xA7F6C8")]
		private void DrawMultiTileVinesInWind(Vector2 screenPosition, Vector2 offSet, int topLeftX, int topLeftY, int sizeX, int sizeY)
		{
		}

		// Token: 0x060060D7 RID: 24791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D7")]
		[Address(RVA = "0xA7BE34", Offset = "0xA7BE34", VA = "0xA7BE34")]
		private void EmitAlchemyHerbParticles(int j, int i, int style)
		{
		}

		// Token: 0x04009F51 RID: 40785
		[Token(Token = "0x4009F51")]
		public const int MAX_SPECIALS = 9000;

		// Token: 0x04009F52 RID: 40786
		[Token(Token = "0x4009F52")]
		private const int MAX_SPECIALS_LEGACY = 1000;

		// Token: 0x04009F53 RID: 40787
		[Token(Token = "0x4009F53")]
		private const float FORCE_FOR_MIN_WIND = 0.08f;

		// Token: 0x04009F54 RID: 40788
		[Token(Token = "0x4009F54")]
		private const float FORCE_FOR_MAX_WIND = 1.2f;

		// Token: 0x04009F55 RID: 40789
		[Token(Token = "0x4009F55")]
		[FieldOffset(Offset = "0x8")]
		private bool[] cacheSpecialDrawTree;

		// Token: 0x04009F56 RID: 40790
		[Token(Token = "0x4009F56")]
		[FieldOffset(Offset = "0xC")]
		private int _leafFrequency;

		// Token: 0x04009F57 RID: 40791
		[Token(Token = "0x4009F57")]
		[FieldOffset(Offset = "0x10")]
		private object specialLock;

		// Token: 0x04009F58 RID: 40792
		[Token(Token = "0x4009F58")]
		[FieldOffset(Offset = "0x14")]
		private int _specialTilesCount;

		// Token: 0x04009F59 RID: 40793
		[Token(Token = "0x4009F59")]
		[FieldOffset(Offset = "0x18")]
		private int[] _specialTileX;

		// Token: 0x04009F5A RID: 40794
		[Token(Token = "0x4009F5A")]
		[FieldOffset(Offset = "0x1C")]
		private int[] _specialTileY;

		// Token: 0x04009F5B RID: 40795
		[Token(Token = "0x4009F5B")]
		[FieldOffset(Offset = "0x20")]
		private object _specialLock;

		// Token: 0x04009F5C RID: 40796
		[Token(Token = "0x4009F5C")]
		[FieldOffset(Offset = "0x28")]
		private double _treeWindCounter;

		// Token: 0x04009F5D RID: 40797
		[Token(Token = "0x4009F5D")]
		[FieldOffset(Offset = "0x30")]
		private double _grassWindCounter;

		// Token: 0x04009F5E RID: 40798
		[Token(Token = "0x4009F5E")]
		[FieldOffset(Offset = "0x38")]
		private double _sunflowerWindCounter;

		// Token: 0x04009F5F RID: 40799
		[Token(Token = "0x4009F5F")]
		[FieldOffset(Offset = "0x40")]
		private double _vineWindCounter;

		// Token: 0x04009F60 RID: 40800
		[Token(Token = "0x4009F60")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<long, bool> _vineRootsPositions;

		// Token: 0x04009F61 RID: 40801
		[Token(Token = "0x4009F61")]
		[FieldOffset(Offset = "0x4C")]
		private TilePaintSystemV2 _paintSystem;

		// Token: 0x04009F62 RID: 40802
		[Token(Token = "0x4009F62")]
		[FieldOffset(Offset = "0x50")]
		private INatureRenderer _nextNatureRenderer;

		// Token: 0x04009F63 RID: 40803
		[Token(Token = "0x4009F63")]
		[FieldOffset(Offset = "0x54")]
		private INatureRenderer _oldNatureRenderer;

		// Token: 0x04009F64 RID: 40804
		[Token(Token = "0x4009F64")]
		[FieldOffset(Offset = "0x58")]
		private INatureRenderer _natureRenderer;

		// Token: 0x04009F65 RID: 40805
		[Token(Token = "0x4009F65")]
		[FieldOffset(Offset = "0x5C")]
		private Color _martianGlow;

		// Token: 0x04009F66 RID: 40806
		[Token(Token = "0x4009F66")]
		[FieldOffset(Offset = "0x60")]
		private Color _meteorGlow;

		// Token: 0x04009F67 RID: 40807
		[Token(Token = "0x4009F67")]
		[FieldOffset(Offset = "0x64")]
		private Color _lavaMossGlow;

		// Token: 0x04009F68 RID: 40808
		[Token(Token = "0x4009F68")]
		[FieldOffset(Offset = "0x68")]
		private Color _kryptonMossGlow;

		// Token: 0x04009F69 RID: 40809
		[Token(Token = "0x4009F69")]
		[FieldOffset(Offset = "0x6C")]
		private Color _xenonMossGlow;

		// Token: 0x04009F6A RID: 40810
		[Token(Token = "0x4009F6A")]
		[FieldOffset(Offset = "0x70")]
		private Color _argonMossGlow;

		// Token: 0x04009F6B RID: 40811
		[Token(Token = "0x4009F6B")]
		[FieldOffset(Offset = "0x74")]
		private Color _violetMossGlow;

		// Token: 0x04009F6C RID: 40812
		[Token(Token = "0x4009F6C")]
		[FieldOffset(Offset = "0x78")]
		private bool _isActiveAndNotPaused;

		// Token: 0x04009F6D RID: 40813
		[Token(Token = "0x4009F6D")]
		[FieldOffset(Offset = "0x7C")]
		private Player _perspectivePlayer;

		// Token: 0x04009F6E RID: 40814
		[Token(Token = "0x4009F6E")]
		[FieldOffset(Offset = "0x80")]
		private Color _highQualityLightingRequirement;

		// Token: 0x04009F6F RID: 40815
		[Token(Token = "0x4009F6F")]
		[FieldOffset(Offset = "0x84")]
		private Color _mediumQualityLightingRequirement;

		// Token: 0x04009F70 RID: 40816
		[Token(Token = "0x4009F70")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 _zero;

		// Token: 0x04009F71 RID: 40817
		[Token(Token = "0x4009F71")]
		[FieldOffset(Offset = "0x88")]
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

		// Token: 0x04009F72 RID: 40818
		[Token(Token = "0x4009F72")]
		[FieldOffset(Offset = "0x8")]
		private static float[] noise;

		// Token: 0x04009F73 RID: 40819
		[Token(Token = "0x4009F73")]
		[FieldOffset(Offset = "0x8C")]
		private Vector3[] _glowPaintColorSlices;

		// Token: 0x04009F74 RID: 40820
		[Token(Token = "0x4009F74")]
		[FieldOffset(Offset = "0x90")]
		private VertexColors LiquidBehindTileColors;

		// Token: 0x04009F75 RID: 40821
		[Token(Token = "0x4009F75")]
		[FieldOffset(Offset = "0xA0")]
		private VertexColors LiquidBehindTileColors2;

		// Token: 0x04009F76 RID: 40822
		[Token(Token = "0x4009F76")]
		[FieldOffset(Offset = "0xB0")]
		private uint randVal;

		// Token: 0x04009F77 RID: 40823
		[Token(Token = "0x4009F77")]
		[FieldOffset(Offset = "0xC")]
		private static WorldGen.GetTreeFoliageDataMethod GetCommonTreeFoliageDataInstance;

		// Token: 0x04009F78 RID: 40824
		[Token(Token = "0x4009F78")]
		[FieldOffset(Offset = "0x10")]
		private static WorldGen.GetTreeFoliageDataMethod GetGemTreeFoliageDataInstance;

		// Token: 0x04009F79 RID: 40825
		[Token(Token = "0x4009F79")]
		[FieldOffset(Offset = "0x14")]
		private static WorldGen.GetTreeFoliageDataMethod GetVanityTreeFoliageDataInstance;

		// Token: 0x04009F7A RID: 40826
		[Token(Token = "0x4009F7A")]
		[FieldOffset(Offset = "0x18")]
		private static WorldGen.GetTreeFoliageDataMethod GetAshTreeFoliageDataInstance;

		// Token: 0x04009F7B RID: 40827
		[Token(Token = "0x4009F7B")]
		[FieldOffset(Offset = "0xB4")]
		private List<DrawData> _voidLensData;

		// Token: 0x04009F7C RID: 40828
		[Token(Token = "0x4009F7C")]
		[FieldOffset(Offset = "0xB8")]
		private Item _defaultItem;

		// Token: 0x02000CB0 RID: 3248
		[Token(Token = "0x2000CB0")]
		public enum TileCounterType
		{
			// Token: 0x04009F7E RID: 40830
			[Token(Token = "0x4009F7E")]
			Tree,
			// Token: 0x04009F7F RID: 40831
			[Token(Token = "0x4009F7F")]
			DisplayDoll,
			// Token: 0x04009F80 RID: 40832
			[Token(Token = "0x4009F80")]
			HatRack,
			// Token: 0x04009F81 RID: 40833
			[Token(Token = "0x4009F81")]
			WindyGrass,
			// Token: 0x04009F82 RID: 40834
			[Token(Token = "0x4009F82")]
			MultiTileGrass,
			// Token: 0x04009F83 RID: 40835
			[Token(Token = "0x4009F83")]
			MultiTileVine,
			// Token: 0x04009F84 RID: 40836
			[Token(Token = "0x4009F84")]
			Vine,
			// Token: 0x04009F85 RID: 40837
			[Token(Token = "0x4009F85")]
			BiomeGrass,
			// Token: 0x04009F86 RID: 40838
			[Token(Token = "0x4009F86")]
			VoidLens,
			// Token: 0x04009F87 RID: 40839
			[Token(Token = "0x4009F87")]
			ReverseVine,
			// Token: 0x04009F88 RID: 40840
			[Token(Token = "0x4009F88")]
			TeleportationPylon,
			// Token: 0x04009F89 RID: 40841
			[Token(Token = "0x4009F89")]
			MasterTrophy,
			// Token: 0x04009F8A RID: 40842
			[Token(Token = "0x4009F8A")]
			AnyDirectionalGrass,
			// Token: 0x04009F8B RID: 40843
			[Token(Token = "0x4009F8B")]
			Count
		}

		// Token: 0x02000CB1 RID: 3249
		[Token(Token = "0x2000CB1")]
		private struct TileFlameData
		{
			// Token: 0x04009F8C RID: 40844
			[Token(Token = "0x4009F8C")]
			[FieldOffset(Offset = "0x0")]
			public Texture2D flameTexture;

			// Token: 0x04009F8D RID: 40845
			[Token(Token = "0x4009F8D")]
			[FieldOffset(Offset = "0x8")]
			public ulong flameSeed;

			// Token: 0x04009F8E RID: 40846
			[Token(Token = "0x4009F8E")]
			[FieldOffset(Offset = "0x10")]
			public int flameCount;

			// Token: 0x04009F8F RID: 40847
			[Token(Token = "0x4009F8F")]
			[FieldOffset(Offset = "0x14")]
			public Color flameColor;

			// Token: 0x04009F90 RID: 40848
			[Token(Token = "0x4009F90")]
			[FieldOffset(Offset = "0x18")]
			public int flameRangeXMin;

			// Token: 0x04009F91 RID: 40849
			[Token(Token = "0x4009F91")]
			[FieldOffset(Offset = "0x1C")]
			public int flameRangeXMax;

			// Token: 0x04009F92 RID: 40850
			[Token(Token = "0x4009F92")]
			[FieldOffset(Offset = "0x20")]
			public int flameRangeYMin;

			// Token: 0x04009F93 RID: 40851
			[Token(Token = "0x4009F93")]
			[FieldOffset(Offset = "0x24")]
			public int flameRangeYMax;

			// Token: 0x04009F94 RID: 40852
			[Token(Token = "0x4009F94")]
			[FieldOffset(Offset = "0x28")]
			public float flameRangeMultX;

			// Token: 0x04009F95 RID: 40853
			[Token(Token = "0x4009F95")]
			[FieldOffset(Offset = "0x2C")]
			public float flameRangeMultY;
		}
	}
}
