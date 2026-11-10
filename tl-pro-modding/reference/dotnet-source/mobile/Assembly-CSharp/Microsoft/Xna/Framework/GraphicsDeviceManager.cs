using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework
{
	// Token: 0x020003A3 RID: 931
	[Token(Token = "0x20003A3")]
	public class GraphicsDeviceManager
	{
		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025D")]
		public GraphicsDevice GraphicsDevice
		{
			[Token(Token = "0x600187F")]
			[Address(RVA = "0xE2067C", Offset = "0xE2067C", VA = "0xE2067C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001880")]
		[Address(RVA = "0xE20710", Offset = "0xE20710", VA = "0xE20710")]
		public GraphicsDeviceManager(Game game)
		{
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		[Token(Token = "0x1700025E")]
		public bool IsFullScreen
		{
			[Token(Token = "0x6001881")]
			[Address(RVA = "0xE2072C", Offset = "0xE2072C", VA = "0xE2072C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001882")]
		[Address(RVA = "0xE20734", Offset = "0xE20734", VA = "0xE20734")]
		public void ApplyChanges()
		{
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001883")]
		[Address(RVA = "0xE20738", Offset = "0xE20738", VA = "0xE20738")]
		public void ToggleFullScreen()
		{
		}

		// Token: 0x04002B56 RID: 11094
		[Token(Token = "0x4002B56")]
		[FieldOffset(Offset = "0x8")]
		private Game game;

		// Token: 0x04002B57 RID: 11095
		[Token(Token = "0x4002B57")]
		[FieldOffset(Offset = "0xC")]
		public bool SynchronizeWithVerticalRetrace;

		// Token: 0x04002B58 RID: 11096
		[Token(Token = "0x4002B58")]
		[FieldOffset(Offset = "0x10")]
		public int PreferredBackBufferWidth;

		// Token: 0x04002B59 RID: 11097
		[Token(Token = "0x4002B59")]
		[FieldOffset(Offset = "0x14")]
		public int PreferredBackBufferHeight;

		// Token: 0x04002B5A RID: 11098
		[Token(Token = "0x4002B5A")]
		[FieldOffset(Offset = "0x0")]
		public static int DefaultBackBufferWidth;

		// Token: 0x04002B5B RID: 11099
		[Token(Token = "0x4002B5B")]
		[FieldOffset(Offset = "0x4")]
		public static int DefaultBackBufferHeight;
	}
}
