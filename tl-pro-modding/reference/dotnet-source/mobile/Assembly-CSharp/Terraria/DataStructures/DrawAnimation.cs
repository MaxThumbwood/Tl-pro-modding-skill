using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000751 RID: 1873
	[Token(Token = "0x2000751")]
	public class DrawAnimation
	{
		// Token: 0x060042B1 RID: 17073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B1")]
		[Address(RVA = "0x4F898C", Offset = "0x4F898C", VA = "0x4F898C", Slot = "4")]
		public virtual void Update()
		{
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x00020490 File Offset: 0x0001E690
		[Token(Token = "0x60042B2")]
		[Address(RVA = "0x4F8990", Offset = "0x4F8990", VA = "0x4F8990", Slot = "5")]
		public virtual Rectangle GetFrame(Texture2D texture, int frameCounterOverride = -1)
		{
			return default(Rectangle);
		}

		// Token: 0x060042B3 RID: 17075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B3")]
		[Address(RVA = "0x4F8A30", Offset = "0x4F8A30", VA = "0x4F8A30")]
		public DrawAnimation()
		{
		}

		// Token: 0x04008A32 RID: 35378
		[Token(Token = "0x4008A32")]
		[FieldOffset(Offset = "0x8")]
		public int Frame;

		// Token: 0x04008A33 RID: 35379
		[Token(Token = "0x4008A33")]
		[FieldOffset(Offset = "0xC")]
		public int FrameCount;

		// Token: 0x04008A34 RID: 35380
		[Token(Token = "0x4008A34")]
		[FieldOffset(Offset = "0x10")]
		public int TicksPerFrame;

		// Token: 0x04008A35 RID: 35381
		[Token(Token = "0x4008A35")]
		[FieldOffset(Offset = "0x14")]
		public int FrameCounter;
	}
}
