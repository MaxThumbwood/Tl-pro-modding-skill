using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.UI
{
	// Token: 0x02000836 RID: 2102
	[Token(Token = "0x2000836")]
	public struct Alignment
	{
		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x060048CB RID: 18635 RVA: 0x00022B18 File Offset: 0x00020D18
		[Token(Token = "0x170008FD")]
		public Vector2 OffsetMultiplier
		{
			[Token(Token = "0x60048CB")]
			[Address(RVA = "0x5E9788", Offset = "0x5E9788", VA = "0x5E9788")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048CC")]
		[Address(RVA = "0x5E97AC", Offset = "0x5E97AC", VA = "0x5E97AC")]
		private Alignment(float horizontal, float vertical)
		{
		}

		// Token: 0x04008EDE RID: 36574
		[Token(Token = "0x4008EDE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Alignment TopLeft;

		// Token: 0x04008EDF RID: 36575
		[Token(Token = "0x4008EDF")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Alignment Top;

		// Token: 0x04008EE0 RID: 36576
		[Token(Token = "0x4008EE0")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Alignment TopRight;

		// Token: 0x04008EE1 RID: 36577
		[Token(Token = "0x4008EE1")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Alignment Left;

		// Token: 0x04008EE2 RID: 36578
		[Token(Token = "0x4008EE2")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Alignment Center;

		// Token: 0x04008EE3 RID: 36579
		[Token(Token = "0x4008EE3")]
		[FieldOffset(Offset = "0x28")]
		public static readonly Alignment Right;

		// Token: 0x04008EE4 RID: 36580
		[Token(Token = "0x4008EE4")]
		[FieldOffset(Offset = "0x30")]
		public static readonly Alignment BottomLeft;

		// Token: 0x04008EE5 RID: 36581
		[Token(Token = "0x4008EE5")]
		[FieldOffset(Offset = "0x38")]
		public static readonly Alignment Bottom;

		// Token: 0x04008EE6 RID: 36582
		[Token(Token = "0x4008EE6")]
		[FieldOffset(Offset = "0x40")]
		public static readonly Alignment BottomRight;

		// Token: 0x04008EE7 RID: 36583
		[Token(Token = "0x4008EE7")]
		[FieldOffset(Offset = "0x0")]
		public readonly float VerticalOffsetMultiplier;

		// Token: 0x04008EE8 RID: 36584
		[Token(Token = "0x4008EE8")]
		[FieldOffset(Offset = "0x4")]
		public readonly float HorizontalOffsetMultiplier;
	}
}
