using System;
using Il2CppDummyDll;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x020009FE RID: 2558
	[Token(Token = "0x20009FE")]
	public class TEKiteAnchor : TELeashedEntityAnchorWithItem
	{
		// Token: 0x0600533E RID: 21310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600533E")]
		[Address(RVA = "0x7F7420", Offset = "0x7F7420", VA = "0x7F7420")]
		public TEKiteAnchor()
		{
		}

		// Token: 0x0600533F RID: 21311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600533F")]
		[Address(RVA = "0x7F74D4", Offset = "0x7F74D4", VA = "0x7F74D4", Slot = "13")]
		public override void RegisterTileEntityID(int assignedID)
		{
		}

		// Token: 0x06005340 RID: 21312 RVA: 0x00026C10 File Offset: 0x00024E10
		[Token(Token = "0x6005340")]
		[Address(RVA = "0x7F7530", Offset = "0x7F7530", VA = "0x7F7530", Slot = "15")]
		public override bool IsTileValidForEntity(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005341 RID: 21313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005341")]
		[Address(RVA = "0x7F76F8", Offset = "0x7F76F8", VA = "0x7F76F8", Slot = "16")]
		public override TileEntity GenerateInstance()
		{
			return null;
		}

		// Token: 0x06005342 RID: 21314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005342")]
		[Address(RVA = "0x7F77F4", Offset = "0x7F77F4", VA = "0x7F77F4")]
		public static void Kill(int x, int y)
		{
		}

		// Token: 0x06005343 RID: 21315 RVA: 0x00026C28 File Offset: 0x00024E28
		[Token(Token = "0x6005343")]
		[Address(RVA = "0x7F7890", Offset = "0x7F7890", VA = "0x7F7890")]
		public static int Hook_AfterPlacement(int x, int y, int type, int style, int direction, int alternate)
		{
			return 0;
		}

		// Token: 0x06005344 RID: 21316 RVA: 0x00026C40 File Offset: 0x00024E40
		[Token(Token = "0x6005344")]
		[Address(RVA = "0x7F78F4", Offset = "0x7F78F4", VA = "0x7F78F4", Slot = "19")]
		public override bool FitsItem(int itemType)
		{
			return default(bool);
		}

		// Token: 0x06005345 RID: 21317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005345")]
		[Address(RVA = "0x7F7970", Offset = "0x7F7970", VA = "0x7F7970", Slot = "18")]
		public override LeashedEntity CreateLeashedEntity()
		{
			return null;
		}

		// Token: 0x06005346 RID: 21318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005346")]
		[Address(RVA = "0x7F7B00", Offset = "0x7F7B00", VA = "0x7F7B00")]
		public static void DebugPlace(int x, int y, int itemType)
		{
		}

		// Token: 0x04009741 RID: 38721
		[Token(Token = "0x4009741")]
		[FieldOffset(Offset = "0x0")]
		private static byte _myEntityID;
	}
}
