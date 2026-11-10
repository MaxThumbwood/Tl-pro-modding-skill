using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000400 RID: 1024
	[Token(Token = "0x2000400")]
	public struct RenderTargetBinding
	{
		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000357")]
		public Texture RenderTarget
		{
			[Token(Token = "0x6001C34")]
			[Address(RVA = "0xE84EFC", Offset = "0xE84EFC", VA = "0xE84EFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x0000D500 File Offset: 0x0000B700
		[Token(Token = "0x17000358")]
		public int ArraySlice
		{
			[Token(Token = "0x6001C35")]
			[Address(RVA = "0xE84F04", Offset = "0xE84F04", VA = "0xE84F04")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x0000D518 File Offset: 0x0000B718
		[Token(Token = "0x17000359")]
		internal DepthFormat DepthFormat
		{
			[Token(Token = "0x6001C36")]
			[Address(RVA = "0xE84F0C", Offset = "0xE84F0C", VA = "0xE84F0C")]
			get
			{
				return DepthFormat.None;
			}
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C37")]
		[Address(RVA = "0xE84F14", Offset = "0xE84F14", VA = "0xE84F14")]
		public RenderTargetBinding(RenderTarget2D renderTarget)
		{
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x0000D530 File Offset: 0x0000B730
		[Token(Token = "0x6001C38")]
		[Address(RVA = "0xE84F8C", Offset = "0xE84F8C", VA = "0xE84F8C")]
		public static implicit operator RenderTargetBinding(RenderTarget2D renderTarget)
		{
			return default(RenderTargetBinding);
		}

		// Token: 0x04002FD4 RID: 12244
		[Token(Token = "0x4002FD4")]
		[FieldOffset(Offset = "0x0")]
		private readonly Texture _renderTarget;

		// Token: 0x04002FD5 RID: 12245
		[Token(Token = "0x4002FD5")]
		[FieldOffset(Offset = "0x4")]
		private readonly int _arraySlice;

		// Token: 0x04002FD6 RID: 12246
		[Token(Token = "0x4002FD6")]
		[FieldOffset(Offset = "0x8")]
		private DepthFormat _depthFormat;
	}
}
