using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200041A RID: 1050
	[Token(Token = "0x200041A")]
	public class DepthStencilState : GraphicsResource
	{
		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
		// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000375")]
		public bool DepthBufferEnable
		{
			[Token(Token = "0x6001CF1")]
			[Address(RVA = "0xE8F4DC", Offset = "0xE8F4DC", VA = "0xE8F4DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001CF2")]
			[Address(RVA = "0xE8F4E4", Offset = "0xE8F4E4", VA = "0xE8F4E4")]
			set
			{
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
		// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000376")]
		public bool DepthBufferWriteEnable
		{
			[Token(Token = "0x6001CF3")]
			[Address(RVA = "0xE8F5A0", Offset = "0xE8F5A0", VA = "0xE8F5A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001CF4")]
			[Address(RVA = "0xE8F5A8", Offset = "0xE8F5A8", VA = "0xE8F5A8")]
			set
			{
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x0000D908 File Offset: 0x0000BB08
		// (set) Token: 0x06001CF6 RID: 7414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000377")]
		public StencilOperation CounterClockwiseStencilDepthBufferFail
		{
			[Token(Token = "0x6001CF5")]
			[Address(RVA = "0xE8F5C0", Offset = "0xE8F5C0", VA = "0xE8F5C0")]
			get
			{
				return StencilOperation.Keep;
			}
			[Token(Token = "0x6001CF6")]
			[Address(RVA = "0xE8F5C8", Offset = "0xE8F5C8", VA = "0xE8F5C8")]
			set
			{
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x0000D920 File Offset: 0x0000BB20
		// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000378")]
		public StencilOperation CounterClockwiseStencilFail
		{
			[Token(Token = "0x6001CF7")]
			[Address(RVA = "0xE8F5E0", Offset = "0xE8F5E0", VA = "0xE8F5E0")]
			get
			{
				return StencilOperation.Keep;
			}
			[Token(Token = "0x6001CF8")]
			[Address(RVA = "0xE8F5E8", Offset = "0xE8F5E8", VA = "0xE8F5E8")]
			set
			{
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x0000D938 File Offset: 0x0000BB38
		// (set) Token: 0x06001CFA RID: 7418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000379")]
		public CompareFunction CounterClockwiseStencilFunction
		{
			[Token(Token = "0x6001CF9")]
			[Address(RVA = "0xE8F600", Offset = "0xE8F600", VA = "0xE8F600")]
			get
			{
				return CompareFunction.Always;
			}
			[Token(Token = "0x6001CFA")]
			[Address(RVA = "0xE8F608", Offset = "0xE8F608", VA = "0xE8F608")]
			set
			{
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x0000D950 File Offset: 0x0000BB50
		// (set) Token: 0x06001CFC RID: 7420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037A")]
		public StencilOperation CounterClockwiseStencilPass
		{
			[Token(Token = "0x6001CFB")]
			[Address(RVA = "0xE8F620", Offset = "0xE8F620", VA = "0xE8F620")]
			get
			{
				return StencilOperation.Keep;
			}
			[Token(Token = "0x6001CFC")]
			[Address(RVA = "0xE8F628", Offset = "0xE8F628", VA = "0xE8F628")]
			set
			{
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x0000D968 File Offset: 0x0000BB68
		// (set) Token: 0x06001CFE RID: 7422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037B")]
		public CompareFunction DepthBufferFunction
		{
			[Token(Token = "0x6001CFD")]
			[Address(RVA = "0xE8F640", Offset = "0xE8F640", VA = "0xE8F640")]
			get
			{
				return CompareFunction.Always;
			}
			[Token(Token = "0x6001CFE")]
			[Address(RVA = "0xE8F648", Offset = "0xE8F648", VA = "0xE8F648")]
			set
			{
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x0000D980 File Offset: 0x0000BB80
		// (set) Token: 0x06001D00 RID: 7424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037C")]
		public int ReferenceStencil
		{
			[Token(Token = "0x6001CFF")]
			[Address(RVA = "0xE8F660", Offset = "0xE8F660", VA = "0xE8F660")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D00")]
			[Address(RVA = "0xE8F668", Offset = "0xE8F668", VA = "0xE8F668")]
			set
			{
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x0000D998 File Offset: 0x0000BB98
		// (set) Token: 0x06001D02 RID: 7426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037D")]
		public StencilOperation StencilDepthBufferFail
		{
			[Token(Token = "0x6001D01")]
			[Address(RVA = "0xE8F680", Offset = "0xE8F680", VA = "0xE8F680")]
			get
			{
				return StencilOperation.Keep;
			}
			[Token(Token = "0x6001D02")]
			[Address(RVA = "0xE8F688", Offset = "0xE8F688", VA = "0xE8F688")]
			set
			{
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x0000D9B0 File Offset: 0x0000BBB0
		// (set) Token: 0x06001D04 RID: 7428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037E")]
		public bool StencilEnable
		{
			[Token(Token = "0x6001D03")]
			[Address(RVA = "0xE8F6A0", Offset = "0xE8F6A0", VA = "0xE8F6A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D04")]
			[Address(RVA = "0xE8F6A8", Offset = "0xE8F6A8", VA = "0xE8F6A8")]
			set
			{
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		// (set) Token: 0x06001D06 RID: 7430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037F")]
		public StencilOperation StencilFail
		{
			[Token(Token = "0x6001D05")]
			[Address(RVA = "0xE8F6C0", Offset = "0xE8F6C0", VA = "0xE8F6C0")]
			get
			{
				return StencilOperation.Keep;
			}
			[Token(Token = "0x6001D06")]
			[Address(RVA = "0xE8F6C8", Offset = "0xE8F6C8", VA = "0xE8F6C8")]
			set
			{
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		// (set) Token: 0x06001D08 RID: 7432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000380")]
		public CompareFunction StencilFunction
		{
			[Token(Token = "0x6001D07")]
			[Address(RVA = "0xE8F6E0", Offset = "0xE8F6E0", VA = "0xE8F6E0")]
			get
			{
				return CompareFunction.Always;
			}
			[Token(Token = "0x6001D08")]
			[Address(RVA = "0xE8F6E8", Offset = "0xE8F6E8", VA = "0xE8F6E8")]
			set
			{
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000381")]
		public int StencilMask
		{
			[Token(Token = "0x6001D09")]
			[Address(RVA = "0xE8F700", Offset = "0xE8F700", VA = "0xE8F700")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D0A")]
			[Address(RVA = "0xE8F708", Offset = "0xE8F708", VA = "0xE8F708")]
			set
			{
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x0000DA10 File Offset: 0x0000BC10
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000382")]
		public StencilOperation StencilPass
		{
			[Token(Token = "0x6001D0B")]
			[Address(RVA = "0xE8F720", Offset = "0xE8F720", VA = "0xE8F720")]
			get
			{
				return StencilOperation.Keep;
			}
			[Token(Token = "0x6001D0C")]
			[Address(RVA = "0xE8F728", Offset = "0xE8F728", VA = "0xE8F728")]
			set
			{
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x0000DA28 File Offset: 0x0000BC28
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000383")]
		public int StencilWriteMask
		{
			[Token(Token = "0x6001D0D")]
			[Address(RVA = "0xE8F740", Offset = "0xE8F740", VA = "0xE8F740")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D0E")]
			[Address(RVA = "0xE8F748", Offset = "0xE8F748", VA = "0xE8F748")]
			set
			{
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x0000DA40 File Offset: 0x0000BC40
		// (set) Token: 0x06001D10 RID: 7440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000384")]
		public bool TwoSidedStencilMode
		{
			[Token(Token = "0x6001D0F")]
			[Address(RVA = "0xE8F760", Offset = "0xE8F760", VA = "0xE8F760")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D10")]
			[Address(RVA = "0xE8F768", Offset = "0xE8F768", VA = "0xE8F768")]
			set
			{
			}
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D11")]
		[Address(RVA = "0xE8F780", Offset = "0xE8F780", VA = "0xE8F780")]
		internal void BindToGraphicsDevice(GraphicsDevice device)
		{
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D12")]
		[Address(RVA = "0xE8F4FC", Offset = "0xE8F4FC", VA = "0xE8F4FC")]
		internal void ThrowIfBound()
		{
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D13")]
		[Address(RVA = "0xE8F834", Offset = "0xE8F834", VA = "0xE8F834")]
		public DepthStencilState()
		{
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D14")]
		[Address(RVA = "0xE8F918", Offset = "0xE8F918", VA = "0xE8F918")]
		private DepthStencilState(string name, bool depthBufferEnable, bool depthBufferWriteEnable)
		{
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D15")]
		[Address(RVA = "0xE8F948", Offset = "0xE8F948", VA = "0xE8F948")]
		private DepthStencilState(DepthStencilState cloneSource)
		{
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D17")]
		[Address(RVA = "0xE8FC2C", Offset = "0xE8FC2C", VA = "0xE8FC2C")]
		internal DepthStencilState Clone()
		{
			return null;
		}

		// Token: 0x0400309A RID: 12442
		[Token(Token = "0x400309A")]
		[FieldOffset(Offset = "0x18")]
		private readonly bool _defaultStateObject;

		// Token: 0x0400309B RID: 12443
		[Token(Token = "0x400309B")]
		[FieldOffset(Offset = "0x19")]
		private bool _depthBufferEnable;

		// Token: 0x0400309C RID: 12444
		[Token(Token = "0x400309C")]
		[FieldOffset(Offset = "0x1A")]
		private bool _depthBufferWriteEnable;

		// Token: 0x0400309D RID: 12445
		[Token(Token = "0x400309D")]
		[FieldOffset(Offset = "0x1C")]
		private StencilOperation _counterClockwiseStencilDepthBufferFail;

		// Token: 0x0400309E RID: 12446
		[Token(Token = "0x400309E")]
		[FieldOffset(Offset = "0x20")]
		private StencilOperation _counterClockwiseStencilFail;

		// Token: 0x0400309F RID: 12447
		[Token(Token = "0x400309F")]
		[FieldOffset(Offset = "0x24")]
		private CompareFunction _counterClockwiseStencilFunction;

		// Token: 0x040030A0 RID: 12448
		[Token(Token = "0x40030A0")]
		[FieldOffset(Offset = "0x28")]
		private StencilOperation _counterClockwiseStencilPass;

		// Token: 0x040030A1 RID: 12449
		[Token(Token = "0x40030A1")]
		[FieldOffset(Offset = "0x2C")]
		private CompareFunction _depthBufferFunction;

		// Token: 0x040030A2 RID: 12450
		[Token(Token = "0x40030A2")]
		[FieldOffset(Offset = "0x30")]
		private int _referenceStencil;

		// Token: 0x040030A3 RID: 12451
		[Token(Token = "0x40030A3")]
		[FieldOffset(Offset = "0x34")]
		private StencilOperation _stencilDepthBufferFail;

		// Token: 0x040030A4 RID: 12452
		[Token(Token = "0x40030A4")]
		[FieldOffset(Offset = "0x38")]
		private bool _stencilEnable;

		// Token: 0x040030A5 RID: 12453
		[Token(Token = "0x40030A5")]
		[FieldOffset(Offset = "0x3C")]
		private StencilOperation _stencilFail;

		// Token: 0x040030A6 RID: 12454
		[Token(Token = "0x40030A6")]
		[FieldOffset(Offset = "0x40")]
		private CompareFunction _stencilFunction;

		// Token: 0x040030A7 RID: 12455
		[Token(Token = "0x40030A7")]
		[FieldOffset(Offset = "0x44")]
		private int _stencilMask;

		// Token: 0x040030A8 RID: 12456
		[Token(Token = "0x40030A8")]
		[FieldOffset(Offset = "0x48")]
		private StencilOperation _stencilPass;

		// Token: 0x040030A9 RID: 12457
		[Token(Token = "0x40030A9")]
		[FieldOffset(Offset = "0x4C")]
		private int _stencilWriteMask;

		// Token: 0x040030AA RID: 12458
		[Token(Token = "0x40030AA")]
		[FieldOffset(Offset = "0x50")]
		private bool _twoSidedStencilMode;

		// Token: 0x040030AB RID: 12459
		[Token(Token = "0x40030AB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DepthStencilState Default;

		// Token: 0x040030AC RID: 12460
		[Token(Token = "0x40030AC")]
		[FieldOffset(Offset = "0x4")]
		public static readonly DepthStencilState DepthRead;

		// Token: 0x040030AD RID: 12461
		[Token(Token = "0x40030AD")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DepthStencilState None;
	}
}
