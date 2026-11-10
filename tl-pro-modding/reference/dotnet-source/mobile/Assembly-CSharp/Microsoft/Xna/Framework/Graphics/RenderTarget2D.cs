using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003FF RID: 1023
	[Token(Token = "0x20003FF")]
	public class RenderTarget2D : Texture2D, FileAPI
	{
		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x0000D488 File Offset: 0x0000B688
		// (set) Token: 0x06001C24 RID: 7204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000353")]
		public DepthFormat DepthStencilFormat
		{
			[Token(Token = "0x6001C23")]
			[Address(RVA = "0xE84B44", Offset = "0xE84B44", VA = "0xE84B44")]
			get
			{
				return DepthFormat.None;
			}
			[Token(Token = "0x6001C24")]
			[Address(RVA = "0xE84B4C", Offset = "0xE84B4C", VA = "0xE84B4C")]
			private set
			{
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		// (set) Token: 0x06001C26 RID: 7206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000354")]
		public int MultiSampleCount
		{
			[Token(Token = "0x6001C25")]
			[Address(RVA = "0xE84B54", Offset = "0xE84B54", VA = "0xE84B54")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C26")]
			[Address(RVA = "0xE84B5C", Offset = "0xE84B5C", VA = "0xE84B5C")]
			private set
			{
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		// (set) Token: 0x06001C28 RID: 7208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000355")]
		public RenderTargetUsage RenderTargetUsage
		{
			[Token(Token = "0x6001C27")]
			[Address(RVA = "0xE84B64", Offset = "0xE84B64", VA = "0xE84B64", Slot = "5")]
			get
			{
				return RenderTargetUsage.DiscardContents;
			}
			[Token(Token = "0x6001C28")]
			[Address(RVA = "0xE84B6C", Offset = "0xE84B6C", VA = "0xE84B6C")]
			private set
			{
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		[Token(Token = "0x17000356")]
		public bool IsContentLost
		{
			[Token(Token = "0x6001C29")]
			[Address(RVA = "0xE84B74", Offset = "0xE84B74", VA = "0xE84B74")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06001C2A RID: 7210 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001C2B RID: 7211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001E")]
		public event EventHandler<EventArgs> ContentLost
		{
			[Token(Token = "0x6001C2A")]
			[Address(RVA = "0xE84B7C", Offset = "0xE84B7C", VA = "0xE84B7C")]
			add
			{
			}
			[Token(Token = "0x6001C2B")]
			[Address(RVA = "0xE84C44", Offset = "0xE84C44", VA = "0xE84C44")]
			remove
			{
			}
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		[Token(Token = "0x6001C2C")]
		[Address(RVA = "0xE84D0C", Offset = "0xE84D0C", VA = "0xE84D0C")]
		private bool SuppressEventHandlerWarningsUntilEventsAreProperlyImplemented()
		{
			return default(bool);
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2D")]
		[Address(RVA = "0xE84D1C", Offset = "0xE84D1C", VA = "0xE84D1C")]
		public RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat, int preferredMultiSampleCount, RenderTargetUsage usage, bool shared, int arraySize)
		{
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2E")]
		[Address(RVA = "0xE84D70", Offset = "0xE84D70", VA = "0xE84D70")]
		public RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat, int preferredMultiSampleCount, RenderTargetUsage usage, bool shared)
		{
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2F")]
		[Address(RVA = "0xE84DC4", Offset = "0xE84DC4", VA = "0xE84DC4")]
		public RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat, int preferredMultiSampleCount, RenderTargetUsage usage)
		{
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C30")]
		[Address(RVA = "0xE84E18", Offset = "0xE84E18", VA = "0xE84E18")]
		public RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat)
		{
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C31")]
		[Address(RVA = "0xE84E64", Offset = "0xE84E64", VA = "0xE84E64")]
		public RenderTarget2D(GraphicsDevice device, int width, int height)
		{
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C32")]
		[Address(RVA = "0xE84EA8", Offset = "0xE84EA8", VA = "0xE84EA8")]
		protected RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat format, DepthFormat depthFormat, int preferredMultiSampleCount, RenderTargetUsage usage, Texture2D.SurfaceType surfaceType)
		{
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C33")]
		[Address(RVA = "0xE84EF4", Offset = "0xE84EF4", VA = "0xE84EF4", Slot = "4")]
		protected internal override void GraphicsDeviceResetting()
		{
		}

		// Token: 0x04002FD0 RID: 12240
		[Token(Token = "0x4002FD0")]
		[FieldOffset(Offset = "0x70")]
		private DepthFormat <DepthStencilFormat>k__BackingField;

		// Token: 0x04002FD1 RID: 12241
		[Token(Token = "0x4002FD1")]
		[FieldOffset(Offset = "0x74")]
		private int <MultiSampleCount>k__BackingField;

		// Token: 0x04002FD2 RID: 12242
		[Token(Token = "0x4002FD2")]
		[FieldOffset(Offset = "0x78")]
		private RenderTargetUsage <RenderTargetUsage>k__BackingField;
	}
}
