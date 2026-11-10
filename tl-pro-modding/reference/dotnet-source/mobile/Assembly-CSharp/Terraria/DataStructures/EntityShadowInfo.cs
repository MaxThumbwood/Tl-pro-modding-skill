using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x02000758 RID: 1880
	[Token(Token = "0x2000758")]
	public struct EntityShadowInfo
	{
		// Token: 0x060042CB RID: 17099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042CB")]
		[Address(RVA = "0x4F9A14", Offset = "0x4F9A14", VA = "0x4F9A14")]
		public void CopyPlayer(Player player)
		{
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x060042CC RID: 17100 RVA: 0x000204F0 File Offset: 0x0001E6F0
		[Token(Token = "0x17000820")]
		public Vector2 HeadgearOffset
		{
			[Token(Token = "0x60042CC")]
			[Address(RVA = "0x4F9B10", Offset = "0x4F9B10", VA = "0x4F9B10")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x04008A4D RID: 35405
		[Token(Token = "0x4008A4D")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 Position;

		// Token: 0x04008A4E RID: 35406
		[Token(Token = "0x4008A4E")]
		[FieldOffset(Offset = "0x8")]
		public float Rotation;

		// Token: 0x04008A4F RID: 35407
		[Token(Token = "0x4008A4F")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 Origin;

		// Token: 0x04008A50 RID: 35408
		[Token(Token = "0x4008A50")]
		[FieldOffset(Offset = "0x14")]
		public int Direction;

		// Token: 0x04008A51 RID: 35409
		[Token(Token = "0x4008A51")]
		[FieldOffset(Offset = "0x18")]
		public int GravityDirection;

		// Token: 0x04008A52 RID: 35410
		[Token(Token = "0x4008A52")]
		[FieldOffset(Offset = "0x1C")]
		public int BodyFrameIndex;
	}
}
