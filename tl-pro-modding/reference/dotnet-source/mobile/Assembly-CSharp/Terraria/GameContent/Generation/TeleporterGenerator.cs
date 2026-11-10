using System;
using Il2CppDummyDll;
using Terraria.Utilities;

namespace Terraria.GameContent.Generation
{
	// Token: 0x02000B0E RID: 2830
	[Token(Token = "0x2000B0E")]
	public class TeleporterGenerator
	{
		// Token: 0x0600582A RID: 22570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600582A")]
		[Address(RVA = "0x863084", Offset = "0x863084", VA = "0x863084")]
		public TeleporterGenerator(UnifiedRandom genRand, int pairsToPlace, int minDistanceBetweenTeleporters, int totalAttempts)
		{
		}

		// Token: 0x0600582B RID: 22571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600582B")]
		[Address(RVA = "0x8630C4", Offset = "0x8630C4", VA = "0x8630C4")]
		public void PlaceTeleporters()
		{
		}

		// Token: 0x0600582C RID: 22572 RVA: 0x00028FC8 File Offset: 0x000271C8
		[Token(Token = "0x600582C")]
		[Address(RVA = "0x86323C", Offset = "0x86323C", VA = "0x86323C")]
		private bool TryPlaceTeleporterPair()
		{
			return default(bool);
		}

		// Token: 0x0600582D RID: 22573 RVA: 0x00028FE0 File Offset: 0x000271E0
		[Token(Token = "0x600582D")]
		[Address(RVA = "0x863490", Offset = "0x863490", VA = "0x863490")]
		private bool TryFindTeleporterSpot(out int x, out int y)
		{
			return default(bool);
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x00028FF8 File Offset: 0x000271F8
		[Token(Token = "0x600582E")]
		[Address(RVA = "0x8641AC", Offset = "0x8641AC", VA = "0x8641AC")]
		private bool CanPutTeleporterHere(int tileX, int tileY)
		{
			return default(bool);
		}

		// Token: 0x0600582F RID: 22575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600582F")]
		[Address(RVA = "0x863DEC", Offset = "0x863DEC", VA = "0x863DEC")]
		private void ClearAreaAboveTeleporter(int tileX, int tileY)
		{
		}

		// Token: 0x06005830 RID: 22576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005830")]
		[Address(RVA = "0x8639C4", Offset = "0x8639C4", VA = "0x8639C4")]
		private void CleanUpSupport(int x, int y)
		{
		}

		// Token: 0x06005831 RID: 22577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005831")]
		[Address(RVA = "0x86500C", Offset = "0x86500C", VA = "0x86500C")]
		private void PlaceSupport(Tile tile, ushort fallbackType)
		{
		}

		// Token: 0x06005832 RID: 22578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005832")]
		[Address(RVA = "0x864D78", Offset = "0x864D78", VA = "0x864D78")]
		private void ClearTile(int x, int y, out Tile tile)
		{
		}

		// Token: 0x06005833 RID: 22579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005833")]
		[Address(RVA = "0x863E60", Offset = "0x863E60", VA = "0x863E60")]
		private void PlaceTeleporter(int x, int y)
		{
		}

		// Token: 0x04009981 RID: 39297
		[Token(Token = "0x4009981")]
		[FieldOffset(Offset = "0x8")]
		private UnifiedRandom _genRand;

		// Token: 0x04009982 RID: 39298
		[Token(Token = "0x4009982")]
		[FieldOffset(Offset = "0xC")]
		private int _pairsToPlace;

		// Token: 0x04009983 RID: 39299
		[Token(Token = "0x4009983")]
		[FieldOffset(Offset = "0x10")]
		private int _minDistanceBetweenTeleporters;

		// Token: 0x04009984 RID: 39300
		[Token(Token = "0x4009984")]
		[FieldOffset(Offset = "0x14")]
		private int _totalAttempts;

		// Token: 0x04009985 RID: 39301
		[Token(Token = "0x4009985")]
		[FieldOffset(Offset = "0x18")]
		private int _totalPlaced;

		// Token: 0x04009986 RID: 39302
		[Token(Token = "0x4009986")]
		[FieldOffset(Offset = "0x1C")]
		private int _wireColor;

		// Token: 0x04009987 RID: 39303
		[Token(Token = "0x4009987")]
		[FieldOffset(Offset = "0x20")]
		private TeleporterGenerator.PlacementFlags _placementFlags;

		// Token: 0x02000B0F RID: 2831
		[Token(Token = "0x2000B0F")]
		private enum PlacementFlags
		{
			// Token: 0x04009989 RID: 39305
			[Token(Token = "0x4009989")]
			None,
			// Token: 0x0400998A RID: 39306
			[Token(Token = "0x400998A")]
			ForceSupports,
			// Token: 0x0400998B RID: 39307
			[Token(Token = "0x400998B")]
			ClearTiles
		}
	}
}
