using System;
using Il2CppDummyDll;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x02000A02 RID: 2562
	[Token(Token = "0x2000A02")]
	public class TETeleportationPylon : TileEntityType<TETeleportationPylon>
	{
		// Token: 0x06005367 RID: 21351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005367")]
		[Address(RVA = "0x7FBFE4", Offset = "0x7FBFE4", VA = "0x7FBFE4")]
		public TETeleportationPylon()
		{
		}

		// Token: 0x06005368 RID: 21352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005368")]
		[Address(RVA = "0x7FC038", Offset = "0x7FC038", VA = "0x7FC038", Slot = "14")]
		public override void NetPlaceEntityAttempt(int x, int y)
		{
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x00026D30 File Offset: 0x00024F30
		[Token(Token = "0x6005369")]
		[Address(RVA = "0x7FC4DC", Offset = "0x7FC4DC", VA = "0x7FC4DC")]
		public bool TryGetPylonType(out TeleportPylonType pylonType)
		{
			return default(bool);
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600536A")]
		[Address(RVA = "0x7FC39C", Offset = "0x7FC39C", VA = "0x7FC39C")]
		private static void RejectPlacementFromNet(int x, int y)
		{
		}

		// Token: 0x0600536B RID: 21355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600536B")]
		[Address(RVA = "0x7FC4FC", Offset = "0x7FC4FC", VA = "0x7FC4FC", Slot = "4")]
		public override void OnPlaced()
		{
		}

		// Token: 0x0600536C RID: 21356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600536C")]
		[Address(RVA = "0x7FC578", Offset = "0x7FC578", VA = "0x7FC578", Slot = "5")]
		public override void OnRemoved()
		{
		}

		// Token: 0x0600536D RID: 21357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536D")]
		[Address(RVA = "0x7FC5F4", Offset = "0x7FC5F4", VA = "0x7FC5F4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600536E RID: 21358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600536E")]
		[Address(RVA = "0x7FC698", Offset = "0x7FC698", VA = "0x7FC698")]
		public static void Framing_CheckTile(int callX, int callY)
		{
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x00026D48 File Offset: 0x00024F48
		[Token(Token = "0x600536F")]
		[Address(RVA = "0x7FCF00", Offset = "0x7FCF00", VA = "0x7FCF00")]
		public static int GetPylonStyleFromTile(Tile tile)
		{
			return 0;
		}

		// Token: 0x06005370 RID: 21360 RVA: 0x00026D60 File Offset: 0x00024F60
		[Token(Token = "0x6005370")]
		[Address(RVA = "0x7FCFE0", Offset = "0x7FCFE0", VA = "0x7FCFE0")]
		public static int GetPylonItemTypeFromTileStyle(int style)
		{
			return 0;
		}

		// Token: 0x06005371 RID: 21361 RVA: 0x00026D78 File Offset: 0x00024F78
		[Token(Token = "0x6005371")]
		[Address(RVA = "0x7FD004", Offset = "0x7FD004", VA = "0x7FD004", Slot = "15")]
		public override bool IsTileValidForEntity(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005372 RID: 21362 RVA: 0x00026D90 File Offset: 0x00024F90
		[Token(Token = "0x6005372")]
		[Address(RVA = "0x7FD3B8", Offset = "0x7FD3B8", VA = "0x7FD3B8")]
		public static int PlacementPreviewHook_AfterPlacement(int x, int y, int type = 597, int style = 0, int direction = 1, int alternate = 0)
		{
			return 0;
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x00026DA8 File Offset: 0x00024FA8
		[Token(Token = "0x6005373")]
		[Address(RVA = "0x7FD5F0", Offset = "0x7FD5F0", VA = "0x7FD5F0")]
		public static int PlacementPreviewHook_CheckIfCanPlace(int x, int y, int type = 597, int style = 0, int direction = 1, int alternate = 0)
		{
			return 0;
		}

		// Token: 0x06005374 RID: 21364 RVA: 0x00026DC0 File Offset: 0x00024FC0
		[Token(Token = "0x6005374")]
		[Address(RVA = "0x7FC13C", Offset = "0x7FC13C", VA = "0x7FC13C")]
		private bool TryGetPylonTypeFromTileCoords(int x, int y, out TeleportPylonType pylonType)
		{
			return default(bool);
		}

		// Token: 0x06005375 RID: 21365 RVA: 0x00026DD8 File Offset: 0x00024FD8
		[Token(Token = "0x6005375")]
		[Address(RVA = "0x7FD674", Offset = "0x7FD674", VA = "0x7FD674")]
		private static TeleportPylonType GetPylonTypeFromPylonTileStyle(int pylonStyle)
		{
			return TeleportPylonType.SurfacePurity;
		}

		// Token: 0x04009755 RID: 38741
		[Token(Token = "0x4009755")]
		private const int MyTileID = 597;

		// Token: 0x04009756 RID: 38742
		[Token(Token = "0x4009756")]
		public const int entityTileWidth = 3;

		// Token: 0x04009757 RID: 38743
		[Token(Token = "0x4009757")]
		public const int entityTileHeight = 4;
	}
}
