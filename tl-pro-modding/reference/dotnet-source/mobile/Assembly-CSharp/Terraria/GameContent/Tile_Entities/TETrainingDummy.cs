using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x02000A03 RID: 2563
	[Token(Token = "0x2000A03")]
	public class TETrainingDummy : TileEntityType<TETrainingDummy>
	{
		// Token: 0x06005376 RID: 21366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005376")]
		[Address(RVA = "0x7FD67C", Offset = "0x7FD67C", VA = "0x7FD67C", Slot = "13")]
		public override void RegisterTileEntityID(int assignedID)
		{
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005377")]
		[Address(RVA = "0x7FD778", Offset = "0x7FD778", VA = "0x7FD778", Slot = "14")]
		public override void NetPlaceEntityAttempt(int x, int y)
		{
		}

		// Token: 0x06005378 RID: 21368 RVA: 0x00026DF0 File Offset: 0x00024FF0
		[Token(Token = "0x6005378")]
		[Address(RVA = "0x7FD7D4", Offset = "0x7FD7D4", VA = "0x7FD7D4", Slot = "15")]
		public override bool IsTileValidForEntity(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005379 RID: 21369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005379")]
		[Address(RVA = "0x7FDBF4", Offset = "0x7FDBF4", VA = "0x7FDBF4")]
		public static void ClearBoxes()
		{
		}

		// Token: 0x0600537A RID: 21370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600537A")]
		[Address(RVA = "0x7FDC94", Offset = "0x7FDC94", VA = "0x7FDC94", Slot = "6")]
		public override void Update()
		{
		}

		// Token: 0x0600537B RID: 21371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600537B")]
		[Address(RVA = "0x7FE2C8", Offset = "0x7FE2C8", VA = "0x7FE2C8")]
		private static void FillPlayerHitboxes()
		{
		}

		// Token: 0x0600537C RID: 21372 RVA: 0x00026E08 File Offset: 0x00025008
		[Token(Token = "0x600537C")]
		[Address(RVA = "0x7FD840", Offset = "0x7FD840", VA = "0x7FD840")]
		public static bool ValidTile(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600537D")]
		[Address(RVA = "0x7FE888", Offset = "0x7FE888", VA = "0x7FE888")]
		public TETrainingDummy()
		{
		}

		// Token: 0x0600537E RID: 21374 RVA: 0x00026E20 File Offset: 0x00025020
		[Token(Token = "0x600537E")]
		[Address(RVA = "0x7FE8EC", Offset = "0x7FE8EC", VA = "0x7FE8EC")]
		public static int Hook_AfterPlacement(int x, int y, int type = 378, int style = 0, int direction = 1, int alternate = 0)
		{
			return 0;
		}

		// Token: 0x0600537F RID: 21375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600537F")]
		[Address(RVA = "0x7FEA84", Offset = "0x7FEA84", VA = "0x7FEA84", Slot = "7")]
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
		}

		// Token: 0x06005380 RID: 21376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005380")]
		[Address(RVA = "0x7FEAB8", Offset = "0x7FEAB8", VA = "0x7FEAB8", Slot = "8")]
		public override void ReadExtraData(BinaryReader reader, int gameVersion, bool networkSend)
		{
		}

		// Token: 0x06005381 RID: 21377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005381")]
		[Address(RVA = "0x7FE5A0", Offset = "0x7FE5A0", VA = "0x7FE5A0")]
		private void Activate()
		{
		}

		// Token: 0x06005382 RID: 21378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005382")]
		[Address(RVA = "0x7FE15C", Offset = "0x7FE15C", VA = "0x7FE15C")]
		public void Deactivate()
		{
		}

		// Token: 0x06005383 RID: 21379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005383")]
		[Address(RVA = "0x7FEAEC", Offset = "0x7FEAEC", VA = "0x7FEAEC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04009758 RID: 38744
		[Token(Token = "0x4009758")]
		[FieldOffset(Offset = "0x0")]
		private static List<Rectangle> playerBoxes;

		// Token: 0x04009759 RID: 38745
		[Token(Token = "0x4009759")]
		[FieldOffset(Offset = "0x4")]
		private static bool playerBoxFilled;

		// Token: 0x0400975A RID: 38746
		[Token(Token = "0x400975A")]
		[FieldOffset(Offset = "0x5")]
		private static bool npcSlotsFull;

		// Token: 0x0400975B RID: 38747
		[Token(Token = "0x400975B")]
		[FieldOffset(Offset = "0x14")]
		public int npc;

		// Token: 0x0400975C RID: 38748
		[Token(Token = "0x400975C")]
		[FieldOffset(Offset = "0x18")]
		public int activationRetryCooldown;
	}
}
