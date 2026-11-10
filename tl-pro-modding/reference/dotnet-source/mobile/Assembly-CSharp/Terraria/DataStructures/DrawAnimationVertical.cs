using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000752 RID: 1874
	[Token(Token = "0x2000752")]
	public class DrawAnimationVertical : DrawAnimation
	{
		// Token: 0x060042B4 RID: 17076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B4")]
		[Address(RVA = "0x4F8A38", Offset = "0x4F8A38", VA = "0x4F8A38")]
		public DrawAnimationVertical(int ticksperframe, int frameCount, bool pingPong = false)
		{
		}

		// Token: 0x060042B5 RID: 17077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B5")]
		[Address(RVA = "0x4F8A6C", Offset = "0x4F8A6C", VA = "0x4F8A6C", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x060042B6 RID: 17078 RVA: 0x000204A8 File Offset: 0x0001E6A8
		[Token(Token = "0x60042B6")]
		[Address(RVA = "0x4F8ACC", Offset = "0x4F8ACC", VA = "0x4F8ACC", Slot = "5")]
		public override Rectangle GetFrame(Texture2D texture, int frameCounterOverride = -1)
		{
			return default(Rectangle);
		}

		// Token: 0x04008A36 RID: 35382
		[Token(Token = "0x4008A36")]
		[FieldOffset(Offset = "0x18")]
		public bool PingPong;

		// Token: 0x04008A37 RID: 35383
		[Token(Token = "0x4008A37")]
		[FieldOffset(Offset = "0x19")]
		public bool NotActuallyAnimating;
	}
}
