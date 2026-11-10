using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007CB RID: 1995
	[Token(Token = "0x20007CB")]
	public abstract class TileEntityType<T> : TileEntity where T : TileEntity, new()
	{
		// Token: 0x060044A2 RID: 17570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A2")]
		public override void RegisterTileEntityID(int assignedID)
		{
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044A3")]
		public override TileEntity GenerateInstance()
		{
			return null;
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A4")]
		public override void NetPlaceEntityAttempt(int x, int y)
		{
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x00020D78 File Offset: 0x0001EF78
		[Token(Token = "0x60044A5")]
		public static int Place(int x, int y)
		{
			return 0;
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A6")]
		public static void Kill(int x, int y)
		{
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x00020D90 File Offset: 0x0001EF90
		[Token(Token = "0x60044A7")]
		public static int Find(int x, int y)
		{
			return 0;
		}

		// Token: 0x060044A8 RID: 17576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A8")]
		protected TileEntityType()
		{
		}

		// Token: 0x04008C47 RID: 35911
		[Token(Token = "0x4008C47")]
		[FieldOffset(Offset = "0x0")]
		protected static byte EntityTypeID;
	}
}
