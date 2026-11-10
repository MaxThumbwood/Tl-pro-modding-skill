using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.IO;

namespace Terraria.Map
{
	// Token: 0x0200081B RID: 2075
	[Token(Token = "0x200081B")]
	public class WorldMap
	{
		// Token: 0x060046CD RID: 18125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046CD")]
		[Address(RVA = "0x5A3DCC", Offset = "0x5A3DCC", VA = "0x5A3DCC")]
		public void LoadChunkRegions(int minMapX, int minMapY, int maxMapX, int maxMapY)
		{
		}

		// Token: 0x060046CE RID: 18126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046CE")]
		[Address(RVA = "0x5A40C4", Offset = "0x5A40C4", VA = "0x5A40C4")]
		public unsafe MapTile* GetChunkTileNoLoad(int mapX, int mapY, out WorldMapChunk chunk)
		{
			return null;
		}

		// Token: 0x060046CF RID: 18127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046CF")]
		[Address(RVA = "0x5A4138", Offset = "0x5A4138", VA = "0x5A4138")]
		public unsafe MapTile* GetChunkTile(int mapX, int mapY, out WorldMapChunk chunk)
		{
			return null;
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046D0")]
		[Address(RVA = "0x5A4238", Offset = "0x5A4238", VA = "0x5A4238")]
		public unsafe MapTile* GetChunkTile(int mapX, int mapY, bool utilLoad, out WorldMapChunk chunk)
		{
			return null;
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x060046D1 RID: 18129 RVA: 0x000218B8 File Offset: 0x0001FAB8
		[Token(Token = "0x17000874")]
		public int NumChunksAvailable
		{
			[Token(Token = "0x60046D1")]
			[Address(RVA = "0x5A4334", Offset = "0x5A4334", VA = "0x5A4334")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060046D2 RID: 18130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D2")]
		[Address(RVA = "0x5A4444", Offset = "0x5A4444", VA = "0x5A4444")]
		public void UnloadChunk()
		{
		}

		// Token: 0x060046D3 RID: 18131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046D3")]
		[Address(RVA = "0x5A491C", Offset = "0x5A491C", VA = "0x5A491C")]
		public unsafe MapTile* GetTileStorage(WorldMapChunk chunk, bool utilLoad = false)
		{
			return null;
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D4")]
		[Address(RVA = "0x5A516C", Offset = "0x5A516C", VA = "0x5A516C")]
		public void ReleaseTileStorage(WorldMapChunk chunk)
		{
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D5")]
		[Address(RVA = "0x5A5348", Offset = "0x5A5348", VA = "0x5A5348")]
		public void UpdateChunks()
		{
		}

		// Token: 0x060046D6 RID: 18134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D6")]
		[Address(RVA = "0x5A5638", Offset = "0x5A5638", VA = "0x5A5638")]
		public void Allocate(int maxWidth, int maxHeight)
		{
		}

		// Token: 0x060046D7 RID: 18135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D7")]
		[Address(RVA = "0x5A5D3C", Offset = "0x5A5D3C", VA = "0x5A5D3C")]
		public void ConsumeUpdate(int x, int y)
		{
		}

		// Token: 0x060046D8 RID: 18136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D8")]
		[Address(RVA = "0x5A5D88", Offset = "0x5A5D88", VA = "0x5A5D88")]
		public void Update(int x, int y, byte light)
		{
		}

		// Token: 0x060046D9 RID: 18137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D9")]
		[Address(RVA = "0x5A5E48", Offset = "0x5A5E48", VA = "0x5A5E48")]
		public void SetTile(int x, int y, ref MapTile tile)
		{
		}

		// Token: 0x060046DA RID: 18138 RVA: 0x000218D0 File Offset: 0x0001FAD0
		[Token(Token = "0x60046DA")]
		[Address(RVA = "0x5A3D88", Offset = "0x5A3D88", VA = "0x5A3D88")]
		public bool IsRevealed(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x000218E8 File Offset: 0x0001FAE8
		[Token(Token = "0x60046DB")]
		[Address(RVA = "0x59E064", Offset = "0x59E064", VA = "0x59E064")]
		public bool UpdateLighting(int x, int y, byte light)
		{
			return default(bool);
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x00021900 File Offset: 0x0001FB00
		[Token(Token = "0x60046DC")]
		[Address(RVA = "0x5A5E8C", Offset = "0x5A5E8C", VA = "0x5A5E8C")]
		public bool UpdateType(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DD")]
		[Address(RVA = "0x5A5F98", Offset = "0x5A5F98", VA = "0x5A5F98")]
		public void UnlockMapSection(int sectionX, int sectionY)
		{
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x00021918 File Offset: 0x0001FB18
		[Token(Token = "0x60046DE")]
		[Address(RVA = "0x5A5F9C", Offset = "0x5A5F9C", VA = "0x5A5F9C")]
		public static bool TryGetMapPath(PlayerFileData playerFileData, WorldFileData worldFileData, out string mapPath)
		{
			return default(bool);
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DF")]
		[Address(RVA = "0x5A6274", Offset = "0x5A6274", VA = "0x5A6274")]
		public void Load()
		{
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E0")]
		[Address(RVA = "0x5A71EC", Offset = "0x5A71EC", VA = "0x5A71EC")]
		public void Save(bool forceSave = false)
		{
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E1")]
		[Address(RVA = "0x5A5CAC", Offset = "0x5A5CAC", VA = "0x5A5CAC")]
		public void Clear()
		{
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E2")]
		[Address(RVA = "0x5A6FD4", Offset = "0x5A6FD4", VA = "0x5A6FD4")]
		public void ClearEdges()
		{
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E3")]
		[Address(RVA = "0x5A73F0", Offset = "0x5A73F0", VA = "0x5A73F0")]
		public WorldMap()
		{
		}

		// Token: 0x04008DAC RID: 36268
		[Token(Token = "0x4008DAC")]
		[FieldOffset(Offset = "0x8")]
		public int MaxWidth;

		// Token: 0x04008DAD RID: 36269
		[Token(Token = "0x4008DAD")]
		[FieldOffset(Offset = "0xC")]
		public int MaxHeight;

		// Token: 0x04008DAE RID: 36270
		[Token(Token = "0x4008DAE")]
		[FieldOffset(Offset = "0x10")]
		public int MaxChunkWidth;

		// Token: 0x04008DAF RID: 36271
		[Token(Token = "0x4008DAF")]
		[FieldOffset(Offset = "0x14")]
		public int MaxChunkHeight;

		// Token: 0x04008DB0 RID: 36272
		[Token(Token = "0x4008DB0")]
		public const int BlackEdgeWidth = 40;

		// Token: 0x04008DB1 RID: 36273
		[Token(Token = "0x4008DB1")]
		[FieldOffset(Offset = "0x18")]
		public WorldMapChunk[] _chunks;

		// Token: 0x04008DB2 RID: 36274
		[Token(Token = "0x4008DB2")]
		[FieldOffset(Offset = "0x1C")]
		public int MaxChunkMapped;

		// Token: 0x04008DB3 RID: 36275
		[Token(Token = "0x4008DB3")]
		public const int ReservedForPlayer = 64;

		// Token: 0x04008DB4 RID: 36276
		[Token(Token = "0x4008DB4")]
		[FieldOffset(Offset = "0x20")]
		private unsafe MapTile* TileData;

		// Token: 0x04008DB5 RID: 36277
		[Token(Token = "0x4008DB5")]
		[FieldOffset(Offset = "0x24")]
		private unsafe byte* TileCompressedData;

		// Token: 0x04008DB6 RID: 36278
		[Token(Token = "0x4008DB6")]
		[FieldOffset(Offset = "0x28")]
		public object LockObject;

		// Token: 0x04008DB7 RID: 36279
		[Token(Token = "0x4008DB7")]
		[FieldOffset(Offset = "0x2C")]
		private List<IntPtr> TileChunksAvailable;

		// Token: 0x04008DB8 RID: 36280
		[Token(Token = "0x4008DB8")]
		[FieldOffset(Offset = "0x30")]
		private List<WorldMapChunk> TileChunksInUse;
	}
}
