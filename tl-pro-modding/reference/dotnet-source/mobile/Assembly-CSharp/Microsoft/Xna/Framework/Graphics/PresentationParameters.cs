using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003FD RID: 1021
	[Token(Token = "0x20003FD")]
	public class PresentationParameters
	{
		// Token: 0x06001C09 RID: 7177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C09")]
		[Address(RVA = "0xE812B0", Offset = "0xE812B0", VA = "0xE812B0")]
		public PresentationParameters()
		{
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x0000D368 File Offset: 0x0000B568
		// (set) Token: 0x06001C0B RID: 7179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000347")]
		public SurfaceFormat BackBufferFormat
		{
			[Token(Token = "0x6001C0A")]
			[Address(RVA = "0xE848F8", Offset = "0xE848F8", VA = "0xE848F8")]
			get
			{
				return SurfaceFormat.Color;
			}
			[Token(Token = "0x6001C0B")]
			[Address(RVA = "0xE84900", Offset = "0xE84900", VA = "0xE84900")]
			set
			{
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x0000D380 File Offset: 0x0000B580
		// (set) Token: 0x06001C0D RID: 7181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000348")]
		public int BackBufferHeight
		{
			[Token(Token = "0x6001C0C")]
			[Address(RVA = "0xE84908", Offset = "0xE84908", VA = "0xE84908")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C0D")]
			[Address(RVA = "0xE84910", Offset = "0xE84910", VA = "0xE84910")]
			set
			{
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x0000D398 File Offset: 0x0000B598
		// (set) Token: 0x06001C0F RID: 7183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000349")]
		public int BackBufferWidth
		{
			[Token(Token = "0x6001C0E")]
			[Address(RVA = "0xE84918", Offset = "0xE84918", VA = "0xE84918")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C0F")]
			[Address(RVA = "0xE84920", Offset = "0xE84920", VA = "0xE84920")]
			set
			{
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		[Token(Token = "0x1700034A")]
		public Rectangle Bounds
		{
			[Token(Token = "0x6001C10")]
			[Address(RVA = "0xE84928", Offset = "0xE84928", VA = "0xE84928")]
			get
			{
				return default(Rectangle);
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001C11 RID: 7185 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		// (set) Token: 0x06001C12 RID: 7186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700034B")]
		public IntPtr DeviceWindowHandle
		{
			[Token(Token = "0x6001C11")]
			[Address(RVA = "0xE84960", Offset = "0xE84960", VA = "0xE84960")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C12")]
			[Address(RVA = "0xE84968", Offset = "0xE84968", VA = "0xE84968")]
			set
			{
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001C13 RID: 7187 RVA: 0x0000D3E0 File Offset: 0x0000B5E0
		// (set) Token: 0x06001C14 RID: 7188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700034C")]
		public DepthFormat DepthStencilFormat
		{
			[Token(Token = "0x6001C13")]
			[Address(RVA = "0xE84970", Offset = "0xE84970", VA = "0xE84970")]
			get
			{
				return DepthFormat.None;
			}
			[Token(Token = "0x6001C14")]
			[Address(RVA = "0xE84978", Offset = "0xE84978", VA = "0xE84978")]
			set
			{
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
		// (set) Token: 0x06001C16 RID: 7190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700034D")]
		public bool IsFullScreen
		{
			[Token(Token = "0x6001C15")]
			[Address(RVA = "0xE84980", Offset = "0xE84980", VA = "0xE84980")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C16")]
			[Address(RVA = "0xE84988", Offset = "0xE84988", VA = "0xE84988")]
			set
			{
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x0000D410 File Offset: 0x0000B610
		// (set) Token: 0x06001C18 RID: 7192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700034E")]
		public bool HardwareModeSwitch
		{
			[Token(Token = "0x6001C17")]
			[Address(RVA = "0xE84990", Offset = "0xE84990", VA = "0xE84990")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C18")]
			[Address(RVA = "0xE84998", Offset = "0xE84998", VA = "0xE84998")]
			set
			{
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x0000D428 File Offset: 0x0000B628
		// (set) Token: 0x06001C1A RID: 7194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700034F")]
		public int MultiSampleCount
		{
			[Token(Token = "0x6001C19")]
			[Address(RVA = "0xE849A0", Offset = "0xE849A0", VA = "0xE849A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C1A")]
			[Address(RVA = "0xE849A8", Offset = "0xE849A8", VA = "0xE849A8")]
			set
			{
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x0000D440 File Offset: 0x0000B640
		// (set) Token: 0x06001C1C RID: 7196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000350")]
		public PresentInterval PresentationInterval
		{
			[Token(Token = "0x6001C1B")]
			[Address(RVA = "0xE849B0", Offset = "0xE849B0", VA = "0xE849B0")]
			get
			{
				return PresentInterval.Default;
			}
			[Token(Token = "0x6001C1C")]
			[Address(RVA = "0xE849B8", Offset = "0xE849B8", VA = "0xE849B8")]
			set
			{
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x0000D458 File Offset: 0x0000B658
		// (set) Token: 0x06001C1E RID: 7198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000351")]
		public DisplayOrientation DisplayOrientation
		{
			[Token(Token = "0x6001C1D")]
			[Address(RVA = "0xE849C0", Offset = "0xE849C0", VA = "0xE849C0")]
			get
			{
				return DisplayOrientation.Default;
			}
			[Token(Token = "0x6001C1E")]
			[Address(RVA = "0xE849C8", Offset = "0xE849C8", VA = "0xE849C8")]
			set
			{
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x0000D470 File Offset: 0x0000B670
		// (set) Token: 0x06001C20 RID: 7200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000352")]
		public RenderTargetUsage RenderTargetUsage
		{
			[Token(Token = "0x6001C1F")]
			[Address(RVA = "0xE849D0", Offset = "0xE849D0", VA = "0xE849D0")]
			get
			{
				return RenderTargetUsage.DiscardContents;
			}
			[Token(Token = "0x6001C20")]
			[Address(RVA = "0xE849D8", Offset = "0xE849D8", VA = "0xE849D8")]
			set
			{
			}
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C21")]
		[Address(RVA = "0xE84854", Offset = "0xE84854", VA = "0xE84854")]
		public void Clear()
		{
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C22")]
		[Address(RVA = "0xE849E0", Offset = "0xE849E0", VA = "0xE849E0")]
		public PresentationParameters Clone()
		{
			return null;
		}

		// Token: 0x04002FBF RID: 12223
		[Token(Token = "0x4002FBF")]
		public const int DefaultPresentRate = 60;

		// Token: 0x04002FC0 RID: 12224
		[Token(Token = "0x4002FC0")]
		[FieldOffset(Offset = "0x8")]
		private DepthFormat depthStencilFormat;

		// Token: 0x04002FC1 RID: 12225
		[Token(Token = "0x4002FC1")]
		[FieldOffset(Offset = "0xC")]
		private SurfaceFormat backBufferFormat;

		// Token: 0x04002FC2 RID: 12226
		[Token(Token = "0x4002FC2")]
		[FieldOffset(Offset = "0x10")]
		private int backBufferHeight;

		// Token: 0x04002FC3 RID: 12227
		[Token(Token = "0x4002FC3")]
		[FieldOffset(Offset = "0x14")]
		private int backBufferWidth;

		// Token: 0x04002FC4 RID: 12228
		[Token(Token = "0x4002FC4")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr deviceWindowHandle;

		// Token: 0x04002FC5 RID: 12229
		[Token(Token = "0x4002FC5")]
		[FieldOffset(Offset = "0x1C")]
		private int multiSampleCount;

		// Token: 0x04002FC6 RID: 12230
		[Token(Token = "0x4002FC6")]
		[FieldOffset(Offset = "0x20")]
		private bool isFullScreen;

		// Token: 0x04002FC7 RID: 12231
		[Token(Token = "0x4002FC7")]
		[FieldOffset(Offset = "0x21")]
		private bool hardwareModeSwitch;

		// Token: 0x04002FC8 RID: 12232
		[Token(Token = "0x4002FC8")]
		[FieldOffset(Offset = "0x24")]
		private PresentInterval <PresentationInterval>k__BackingField;

		// Token: 0x04002FC9 RID: 12233
		[Token(Token = "0x4002FC9")]
		[FieldOffset(Offset = "0x28")]
		private DisplayOrientation <DisplayOrientation>k__BackingField;

		// Token: 0x04002FCA RID: 12234
		[Token(Token = "0x4002FCA")]
		[FieldOffset(Offset = "0x2C")]
		private RenderTargetUsage <RenderTargetUsage>k__BackingField;
	}
}
