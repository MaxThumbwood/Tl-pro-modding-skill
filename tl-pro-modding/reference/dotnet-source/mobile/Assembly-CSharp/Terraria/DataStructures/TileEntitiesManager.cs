using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007CA RID: 1994
	[Token(Token = "0x20007CA")]
	public class TileEntitiesManager
	{
		// Token: 0x0600449A RID: 17562 RVA: 0x00020D30 File Offset: 0x0001EF30
		[Token(Token = "0x600449A")]
		[Address(RVA = "0x55AA6C", Offset = "0x55AA6C", VA = "0x55AA6C")]
		private int AssignNewID()
		{
			return 0;
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x00020D48 File Offset: 0x0001EF48
		[Token(Token = "0x600449B")]
		[Address(RVA = "0x55AA80", Offset = "0x55AA80", VA = "0x55AA80")]
		private bool InvalidEntityID(int id)
		{
			return default(bool);
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449C")]
		[Address(RVA = "0x55AAA0", Offset = "0x55AAA0", VA = "0x55AAA0")]
		public void RegisterAll()
		{
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449D")]
		[Address(RVA = "0x55B2CC", Offset = "0x55B2CC", VA = "0x55B2CC")]
		public void Register(TileEntity entity)
		{
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x00020D60 File Offset: 0x0001EF60
		[Token(Token = "0x600449E")]
		[Address(RVA = "0x55B36C", Offset = "0x55B36C", VA = "0x55B36C")]
		public bool CheckValidTile(int id, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449F")]
		[Address(RVA = "0x55B428", Offset = "0x55B428", VA = "0x55B428")]
		public void NetPlaceEntity(int id, int x, int y)
		{
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044A0")]
		[Address(RVA = "0x55B534", Offset = "0x55B534", VA = "0x55B534")]
		public TileEntity GenerateInstance(int id)
		{
			return null;
		}

		// Token: 0x060044A1 RID: 17569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A1")]
		[Address(RVA = "0x55B5E0", Offset = "0x55B5E0", VA = "0x55B5E0")]
		public TileEntitiesManager()
		{
		}

		// Token: 0x04008C45 RID: 35909
		[Token(Token = "0x4008C45")]
		[FieldOffset(Offset = "0x8")]
		private int _nextEntityID;

		// Token: 0x04008C46 RID: 35910
		[Token(Token = "0x4008C46")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<int, TileEntity> _types;
	}
}
