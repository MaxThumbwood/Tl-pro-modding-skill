using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200041D RID: 1053
	[Token(Token = "0x200041D")]
	public class SamplerState : GraphicsResource
	{
		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x0000DB00 File Offset: 0x0000BD00
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038C")]
		public TextureAddressMode AddressU
		{
			[Token(Token = "0x6001D2E")]
			[Address(RVA = "0xE90660", Offset = "0xE90660", VA = "0xE90660")]
			get
			{
				return TextureAddressMode.Wrap;
			}
			[Token(Token = "0x6001D2F")]
			[Address(RVA = "0xE90668", Offset = "0xE90668", VA = "0xE90668")]
			set
			{
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x0000DB18 File Offset: 0x0000BD18
		// (set) Token: 0x06001D31 RID: 7473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038D")]
		public TextureAddressMode AddressV
		{
			[Token(Token = "0x6001D30")]
			[Address(RVA = "0xE90724", Offset = "0xE90724", VA = "0xE90724")]
			get
			{
				return TextureAddressMode.Wrap;
			}
			[Token(Token = "0x6001D31")]
			[Address(RVA = "0xE9072C", Offset = "0xE9072C", VA = "0xE9072C")]
			set
			{
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x0000DB30 File Offset: 0x0000BD30
		// (set) Token: 0x06001D33 RID: 7475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038E")]
		public TextureAddressMode AddressW
		{
			[Token(Token = "0x6001D32")]
			[Address(RVA = "0xE90744", Offset = "0xE90744", VA = "0xE90744")]
			get
			{
				return TextureAddressMode.Wrap;
			}
			[Token(Token = "0x6001D33")]
			[Address(RVA = "0xE9074C", Offset = "0xE9074C", VA = "0xE9074C")]
			set
			{
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x0000DB48 File Offset: 0x0000BD48
		// (set) Token: 0x06001D35 RID: 7477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038F")]
		public Color BorderColor
		{
			[Token(Token = "0x6001D34")]
			[Address(RVA = "0xE90764", Offset = "0xE90764", VA = "0xE90764")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6001D35")]
			[Address(RVA = "0xE9076C", Offset = "0xE9076C", VA = "0xE9076C")]
			set
			{
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x0000DB60 File Offset: 0x0000BD60
		// (set) Token: 0x06001D37 RID: 7479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000390")]
		public TextureFilter Filter
		{
			[Token(Token = "0x6001D36")]
			[Address(RVA = "0xE90784", Offset = "0xE90784", VA = "0xE90784")]
			get
			{
				return TextureFilter.Linear;
			}
			[Token(Token = "0x6001D37")]
			[Address(RVA = "0xE9078C", Offset = "0xE9078C", VA = "0xE9078C")]
			set
			{
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x0000DB78 File Offset: 0x0000BD78
		// (set) Token: 0x06001D39 RID: 7481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000391")]
		public int MaxAnisotropy
		{
			[Token(Token = "0x6001D38")]
			[Address(RVA = "0xE907A4", Offset = "0xE907A4", VA = "0xE907A4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D39")]
			[Address(RVA = "0xE907AC", Offset = "0xE907AC", VA = "0xE907AC")]
			set
			{
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x0000DB90 File Offset: 0x0000BD90
		// (set) Token: 0x06001D3B RID: 7483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000392")]
		public int MaxMipLevel
		{
			[Token(Token = "0x6001D3A")]
			[Address(RVA = "0xE907C4", Offset = "0xE907C4", VA = "0xE907C4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D3B")]
			[Address(RVA = "0xE907CC", Offset = "0xE907CC", VA = "0xE907CC")]
			set
			{
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
		// (set) Token: 0x06001D3D RID: 7485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000393")]
		public float MipMapLevelOfDetailBias
		{
			[Token(Token = "0x6001D3C")]
			[Address(RVA = "0xE907E4", Offset = "0xE907E4", VA = "0xE907E4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001D3D")]
			[Address(RVA = "0xE907EC", Offset = "0xE907EC", VA = "0xE907EC")]
			set
			{
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001D3E RID: 7486 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		// (set) Token: 0x06001D3F RID: 7487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000394")]
		public CompareFunction ComparisonFunction
		{
			[Token(Token = "0x6001D3E")]
			[Address(RVA = "0xE90804", Offset = "0xE90804", VA = "0xE90804")]
			get
			{
				return CompareFunction.Always;
			}
			[Token(Token = "0x6001D3F")]
			[Address(RVA = "0xE9080C", Offset = "0xE9080C", VA = "0xE9080C")]
			set
			{
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000395")]
		public TextureFilterMode FilterMode
		{
			[Token(Token = "0x6001D40")]
			[Address(RVA = "0xE90824", Offset = "0xE90824", VA = "0xE90824")]
			get
			{
				return TextureFilterMode.Default;
			}
			[Token(Token = "0x6001D41")]
			[Address(RVA = "0xE9082C", Offset = "0xE9082C", VA = "0xE9082C")]
			set
			{
			}
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D42")]
		[Address(RVA = "0xE90844", Offset = "0xE90844", VA = "0xE90844")]
		internal void BindToGraphicsDevice(GraphicsDevice device)
		{
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D43")]
		[Address(RVA = "0xE90680", Offset = "0xE90680", VA = "0xE90680")]
		internal void ThrowIfBound()
		{
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D44")]
		[Address(RVA = "0xE908F8", Offset = "0xE908F8", VA = "0xE908F8")]
		public SamplerState()
		{
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D45")]
		[Address(RVA = "0xE90628", Offset = "0xE90628", VA = "0xE90628")]
		private SamplerState(string name, TextureFilter filter, TextureAddressMode addressMode)
		{
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D46")]
		[Address(RVA = "0xE909F0", Offset = "0xE909F0", VA = "0xE909F0")]
		private SamplerState(SamplerState cloneSource)
		{
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D47")]
		[Address(RVA = "0xE90B10", Offset = "0xE90B10", VA = "0xE90B10")]
		internal SamplerState Clone()
		{
			return null;
		}

		// Token: 0x040030BC RID: 12476
		[Token(Token = "0x40030BC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SamplerState AnisotropicClamp;

		// Token: 0x040030BD RID: 12477
		[Token(Token = "0x40030BD")]
		[FieldOffset(Offset = "0x4")]
		public static readonly SamplerState AnisotropicWrap;

		// Token: 0x040030BE RID: 12478
		[Token(Token = "0x40030BE")]
		[FieldOffset(Offset = "0x8")]
		public static readonly SamplerState LinearClamp;

		// Token: 0x040030BF RID: 12479
		[Token(Token = "0x40030BF")]
		[FieldOffset(Offset = "0xC")]
		public static readonly SamplerState LinearWrap;

		// Token: 0x040030C0 RID: 12480
		[Token(Token = "0x40030C0")]
		[FieldOffset(Offset = "0x10")]
		public static readonly SamplerState PointClamp;

		// Token: 0x040030C1 RID: 12481
		[Token(Token = "0x40030C1")]
		[FieldOffset(Offset = "0x14")]
		public static readonly SamplerState PointWrap;

		// Token: 0x040030C2 RID: 12482
		[Token(Token = "0x40030C2")]
		[FieldOffset(Offset = "0x18")]
		private readonly bool _defaultStateObject;

		// Token: 0x040030C3 RID: 12483
		[Token(Token = "0x40030C3")]
		[FieldOffset(Offset = "0x1C")]
		private TextureAddressMode _addressU;

		// Token: 0x040030C4 RID: 12484
		[Token(Token = "0x40030C4")]
		[FieldOffset(Offset = "0x20")]
		private TextureAddressMode _addressV;

		// Token: 0x040030C5 RID: 12485
		[Token(Token = "0x40030C5")]
		[FieldOffset(Offset = "0x24")]
		private TextureAddressMode _addressW;

		// Token: 0x040030C6 RID: 12486
		[Token(Token = "0x40030C6")]
		[FieldOffset(Offset = "0x28")]
		private Color _borderColor;

		// Token: 0x040030C7 RID: 12487
		[Token(Token = "0x40030C7")]
		[FieldOffset(Offset = "0x2C")]
		private TextureFilter _filter;

		// Token: 0x040030C8 RID: 12488
		[Token(Token = "0x40030C8")]
		[FieldOffset(Offset = "0x30")]
		private int _maxAnisotropy;

		// Token: 0x040030C9 RID: 12489
		[Token(Token = "0x40030C9")]
		[FieldOffset(Offset = "0x34")]
		private int _maxMipLevel;

		// Token: 0x040030CA RID: 12490
		[Token(Token = "0x40030CA")]
		[FieldOffset(Offset = "0x38")]
		private float _mipMapLevelOfDetailBias;

		// Token: 0x040030CB RID: 12491
		[Token(Token = "0x40030CB")]
		[FieldOffset(Offset = "0x3C")]
		private TextureFilterMode _filterMode;

		// Token: 0x040030CC RID: 12492
		[Token(Token = "0x40030CC")]
		[FieldOffset(Offset = "0x40")]
		private CompareFunction _comparisonFunction;
	}
}
