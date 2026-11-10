using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Animations
{
	// Token: 0x02000C55 RID: 3157
	[Token(Token = "0x2000C55")]
	public class StardewValleyAnimation
	{
		// Token: 0x06005DC3 RID: 24003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC3")]
		[Address(RVA = "0x9B0510", Offset = "0x9B0510", VA = "0x9B0510")]
		public StardewValleyAnimation()
		{
		}

		// Token: 0x06005DC4 RID: 24004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC4")]
		[Address(RVA = "0x9B05B0", Offset = "0x9B05B0", VA = "0x9B05B0")]
		private void ComposeAnimation()
		{
		}

		// Token: 0x06005DC5 RID: 24005 RVA: 0x0002BB48 File Offset: 0x00029D48
		[Token(Token = "0x6005DC5")]
		[Address(RVA = "0x9B16CC", Offset = "0x9B16CC", VA = "0x9B16CC")]
		private Matrix GetMatrixForAnimation()
		{
			return default(Matrix);
		}

		// Token: 0x06005DC6 RID: 24006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC6")]
		[Address(RVA = "0x9B1778", Offset = "0x9B1778", VA = "0x9B1778")]
		public void Draw(SpriteBatch spriteBatch, int timeInAnimation, Vector2 positionInScreen)
		{
		}

		// Token: 0x04009DB8 RID: 40376
		[Token(Token = "0x4009DB8")]
		[FieldOffset(Offset = "0x8")]
		private List<IAnimationSegment> _segments;
	}
}
