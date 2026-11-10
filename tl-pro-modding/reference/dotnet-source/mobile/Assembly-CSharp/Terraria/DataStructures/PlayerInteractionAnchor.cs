using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x02000792 RID: 1938
	[Token(Token = "0x2000792")]
	public struct PlayerInteractionAnchor
	{
		// Token: 0x0600440C RID: 17420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440C")]
		[Address(RVA = "0x5581DC", Offset = "0x5581DC", VA = "0x5581DC")]
		public PlayerInteractionAnchor(int entityID, int x = -1, int y = -1)
		{
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x0600440D RID: 17421 RVA: 0x000209D0 File Offset: 0x0001EBD0
		[Token(Token = "0x17000833")]
		public bool InUse
		{
			[Token(Token = "0x600440D")]
			[Address(RVA = "0x5581E4", Offset = "0x5581E4", VA = "0x5581E4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440E")]
		[Address(RVA = "0x5581F8", Offset = "0x5581F8", VA = "0x5581F8")]
		public void Clear()
		{
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440F")]
		[Address(RVA = "0x55820C", Offset = "0x55820C", VA = "0x55820C")]
		public void Set(int entityID, int x, int y)
		{
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x000209E8 File Offset: 0x0001EBE8
		[Token(Token = "0x6004410")]
		[Address(RVA = "0x558214", Offset = "0x558214", VA = "0x558214")]
		public bool IsInValidUseTileEntity()
		{
			return default(bool);
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004411")]
		[Address(RVA = "0x5582C4", Offset = "0x5582C4", VA = "0x5582C4")]
		public TileEntity GetTileEntity()
		{
			return null;
		}

		// Token: 0x04008BAC RID: 35756
		[Token(Token = "0x4008BAC")]
		[FieldOffset(Offset = "0x0")]
		public int interactEntityID;

		// Token: 0x04008BAD RID: 35757
		[Token(Token = "0x4008BAD")]
		[FieldOffset(Offset = "0x4")]
		public int X;

		// Token: 0x04008BAE RID: 35758
		[Token(Token = "0x4008BAE")]
		[FieldOffset(Offset = "0x8")]
		public int Y;
	}
}
