using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003D5 RID: 981
	[Token(Token = "0x20003D5")]
	public class DisplayMode
	{
		// Token: 0x06001AB0 RID: 6832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB0")]
		[Address(RVA = "0xE44DAC", Offset = "0xE44DAC", VA = "0xE44DAC")]
		public void UpdateSize(int newWidth, int newHeight)
		{
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x0000CC90 File Offset: 0x0000AE90
		[Token(Token = "0x170002E2")]
		public float AspectRatio
		{
			[Token(Token = "0x6001AB1")]
			[Address(RVA = "0xE44DB8", Offset = "0xE44DB8", VA = "0xE44DB8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		[Token(Token = "0x170002E3")]
		public SurfaceFormat Format
		{
			[Token(Token = "0x6001AB2")]
			[Address(RVA = "0xE44DD4", Offset = "0xE44DD4", VA = "0xE44DD4")]
			get
			{
				return SurfaceFormat.Color;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		[Token(Token = "0x170002E4")]
		public int Height
		{
			[Token(Token = "0x6001AB3")]
			[Address(RVA = "0xE44DDC", Offset = "0xE44DDC", VA = "0xE44DDC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		[Token(Token = "0x170002E5")]
		public int Width
		{
			[Token(Token = "0x6001AB4")]
			[Address(RVA = "0xE44DE4", Offset = "0xE44DE4", VA = "0xE44DE4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		[Token(Token = "0x170002E6")]
		public Rectangle TitleSafeArea
		{
			[Token(Token = "0x6001AB5")]
			[Address(RVA = "0xE44DEC", Offset = "0xE44DEC", VA = "0xE44DEC")]
			get
			{
				return default(Rectangle);
			}
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB6")]
		[Address(RVA = "0xE44E88", Offset = "0xE44E88", VA = "0xE44E88")]
		internal DisplayMode(int width, int height, SurfaceFormat format)
		{
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0000CD08 File Offset: 0x0000AF08
		[Token(Token = "0x6001AB7")]
		[Address(RVA = "0xE44EB0", Offset = "0xE44EB0", VA = "0xE44EB0")]
		public static bool operator !=(DisplayMode left, DisplayMode right)
		{
			return default(bool);
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0000CD20 File Offset: 0x0000AF20
		[Token(Token = "0x6001AB8")]
		[Address(RVA = "0xE44F08", Offset = "0xE44F08", VA = "0xE44F08")]
		public static bool operator ==(DisplayMode left, DisplayMode right)
		{
			return default(bool);
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0000CD38 File Offset: 0x0000AF38
		[Token(Token = "0x6001AB9")]
		[Address(RVA = "0xE44F64", Offset = "0xE44F64", VA = "0xE44F64", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0000CD50 File Offset: 0x0000AF50
		[Token(Token = "0x6001ABA")]
		[Address(RVA = "0xE45038", Offset = "0xE45038", VA = "0xE45038", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ABB")]
		[Address(RVA = "0xE45074", Offset = "0xE45074", VA = "0xE45074", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04002E1E RID: 11806
		[Token(Token = "0x4002E1E")]
		[FieldOffset(Offset = "0x8")]
		private SurfaceFormat format;

		// Token: 0x04002E1F RID: 11807
		[Token(Token = "0x4002E1F")]
		[FieldOffset(Offset = "0xC")]
		private int height;

		// Token: 0x04002E20 RID: 11808
		[Token(Token = "0x4002E20")]
		[FieldOffset(Offset = "0x10")]
		private int width;
	}
}
