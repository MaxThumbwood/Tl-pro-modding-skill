using System;
using Il2CppDummyDll;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x020009FC RID: 2556
	[Token(Token = "0x20009FC")]
	public abstract class TELeashedEntityAnchor : TileEntity
	{
		// Token: 0x0600532E RID: 21294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600532E")]
		[Address(RVA = "0x7F6908", Offset = "0x7F6908", VA = "0x7F6908", Slot = "14")]
		public override void NetPlaceEntityAttempt(int x, int y)
		{
		}

		// Token: 0x0600532F RID: 21295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600532F")]
		[Address(RVA = "0x7F6A08", Offset = "0x7F6A08", VA = "0x7F6A08", Slot = "5")]
		public override void OnRemoved()
		{
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x00026BE0 File Offset: 0x00024DE0
		[Token(Token = "0x6005330")]
		[Address(RVA = "0x7F6A30", Offset = "0x7F6A30", VA = "0x7F6A30")]
		protected static int PlaceFromPlayerPlacementHook(int x, int y, int type)
		{
			return 0;
		}

		// Token: 0x06005331 RID: 21297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005331")]
		[Address(RVA = "0x7F6BAC", Offset = "0x7F6BAC", VA = "0x7F6BAC", Slot = "17")]
		public override void OnWorldLoaded()
		{
		}

		// Token: 0x06005332 RID: 21298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005332")]
		[Address(RVA = "0x7F6A1C", Offset = "0x7F6A1C", VA = "0x7F6A1C")]
		protected void DespawnLeashedEntity()
		{
		}

		// Token: 0x06005333 RID: 21299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005333")]
		[Address(RVA = "0x7F6C48", Offset = "0x7F6C48", VA = "0x7F6C48")]
		protected void RespawnLeashedEntity()
		{
		}

		// Token: 0x06005334 RID: 21300
		[Token(Token = "0x6005334")]
		public abstract LeashedEntity CreateLeashedEntity();

		// Token: 0x06005335 RID: 21301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005335")]
		[Address(RVA = "0x7F6CE4", Offset = "0x7F6CE4", VA = "0x7F6CE4")]
		protected TELeashedEntityAnchor()
		{
		}

		// Token: 0x0400973F RID: 38719
		[Token(Token = "0x400973F")]
		[FieldOffset(Offset = "0x14")]
		private LeashedEntity leashedEntity;
	}
}
