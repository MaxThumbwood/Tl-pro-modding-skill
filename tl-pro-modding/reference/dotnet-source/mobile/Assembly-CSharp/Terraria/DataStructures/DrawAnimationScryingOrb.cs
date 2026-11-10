using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000753 RID: 1875
	[Token(Token = "0x2000753")]
	public class DrawAnimationScryingOrb : DrawAnimation
	{
		// Token: 0x060042B7 RID: 17079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B7")]
		[Address(RVA = "0x4F8C7C", Offset = "0x4F8C7C", VA = "0x4F8C7C", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x060042B8 RID: 17080 RVA: 0x000204C0 File Offset: 0x0001E6C0
		[Token(Token = "0x60042B8")]
		[Address(RVA = "0x4F8E74", Offset = "0x4F8E74", VA = "0x4F8E74", Slot = "5")]
		public override Rectangle GetFrame(Texture2D texture, int frameCounterOverride = -1)
		{
			return default(Rectangle);
		}

		// Token: 0x060042B9 RID: 17081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B9")]
		[Address(RVA = "0x4F8F38", Offset = "0x4F8F38", VA = "0x4F8F38")]
		public DrawAnimationScryingOrb()
		{
		}

		// Token: 0x04008A38 RID: 35384
		[Token(Token = "0x4008A38")]
		[FieldOffset(Offset = "0x18")]
		private DrawAnimationScryingOrb.State _state;

		// Token: 0x04008A39 RID: 35385
		[Token(Token = "0x4008A39")]
		[FieldOffset(Offset = "0x1C")]
		private int _nextStateCounter;

		// Token: 0x04008A3A RID: 35386
		[Token(Token = "0x4008A3A")]
		[FieldOffset(Offset = "0x20")]
		private int _dir;

		// Token: 0x02000754 RID: 1876
		[Token(Token = "0x2000754")]
		private enum State
		{
			// Token: 0x04008A3C RID: 35388
			[Token(Token = "0x4008A3C")]
			Moving,
			// Token: 0x04008A3D RID: 35389
			[Token(Token = "0x4008A3D")]
			Frozen,
			// Token: 0x04008A3E RID: 35390
			[Token(Token = "0x4008A3E")]
			FrozenCenter
		}
	}
}
