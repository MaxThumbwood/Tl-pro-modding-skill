using System;
using Il2CppDummyDll;
using Terraria.DataStructures;
using Terraria.GameContent.LeashedEntities;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x020009FF RID: 2559
	[Token(Token = "0x20009FF")]
	public class TECritterAnchor : TELeashedEntityAnchorWithItem
	{
		// Token: 0x06005347 RID: 21319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005347")]
		[Address(RVA = "0x7F7D80", Offset = "0x7F7D80", VA = "0x7F7D80")]
		public TECritterAnchor()
		{
		}

		// Token: 0x06005348 RID: 21320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005348")]
		[Address(RVA = "0x7F7E48", Offset = "0x7F7E48", VA = "0x7F7E48", Slot = "13")]
		public override void RegisterTileEntityID(int assignedID)
		{
		}

		// Token: 0x06005349 RID: 21321 RVA: 0x00026C58 File Offset: 0x00024E58
		[Token(Token = "0x6005349")]
		[Address(RVA = "0x7F7EB8", Offset = "0x7F7EB8", VA = "0x7F7EB8", Slot = "15")]
		public override bool IsTileValidForEntity(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600534A RID: 21322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600534A")]
		[Address(RVA = "0x7F807C", Offset = "0x7F807C", VA = "0x7F807C", Slot = "16")]
		public override TileEntity GenerateInstance()
		{
			return null;
		}

		// Token: 0x0600534B RID: 21323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600534B")]
		[Address(RVA = "0x7F80E4", Offset = "0x7F80E4", VA = "0x7F80E4")]
		public static void Kill(int x, int y)
		{
		}

		// Token: 0x0600534C RID: 21324 RVA: 0x00026C70 File Offset: 0x00024E70
		[Token(Token = "0x600534C")]
		[Address(RVA = "0x7F8198", Offset = "0x7F8198", VA = "0x7F8198")]
		public static int Hook_AfterPlacement(int x, int y, int type, int style, int direction, int alternate)
		{
			return 0;
		}

		// Token: 0x0600534D RID: 21325 RVA: 0x00026C88 File Offset: 0x00024E88
		[Token(Token = "0x600534D")]
		[Address(RVA = "0x7F8210", Offset = "0x7F8210", VA = "0x7F8210", Slot = "19")]
		public override bool FitsItem(int itemType)
		{
			return default(bool);
		}

		// Token: 0x0600534E RID: 21326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600534E")]
		[Address(RVA = "0x7F82D0", Offset = "0x7F82D0", VA = "0x7F82D0", Slot = "18")]
		public override LeashedEntity CreateLeashedEntity()
		{
			return null;
		}

		// Token: 0x06005350 RID: 21328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005350")]
		[Address(RVA = "0x7F9000", Offset = "0x7F9000", VA = "0x7F9000")]
		public static void SetPrototypeCollection(LeashedCritter instance, int[] targetIds)
		{
		}

		// Token: 0x06005351 RID: 21329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005351")]
		[Address(RVA = "0x7F83F4", Offset = "0x7F83F4", VA = "0x7F83F4")]
		public static LeashedCritter GetLeashedCritterPrototype(int itemType)
		{
			return null;
		}

		// Token: 0x04009742 RID: 38722
		[Token(Token = "0x4009742")]
		[FieldOffset(Offset = "0x0")]
		private static byte _myEntityID;

		// Token: 0x04009743 RID: 38723
		[Token(Token = "0x4009743")]
		[FieldOffset(Offset = "0x4")]
		public static LeashedCritter[] CritterPrototypes;
	}
}
