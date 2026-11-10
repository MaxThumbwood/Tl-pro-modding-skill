using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200041C RID: 1052
	[Token(Token = "0x200041C")]
	public class RasterizerState : GraphicsResource
	{
		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x0000DA58 File Offset: 0x0000BC58
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000385")]
		public CullMode CullMode
		{
			[Token(Token = "0x6001D18")]
			[Address(RVA = "0xE8FC9C", Offset = "0xE8FC9C", VA = "0xE8FC9C")]
			get
			{
				return CullMode.None;
			}
			[Token(Token = "0x6001D19")]
			[Address(RVA = "0xE8FCA4", Offset = "0xE8FCA4", VA = "0xE8FCA4")]
			set
			{
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x0000DA70 File Offset: 0x0000BC70
		// (set) Token: 0x06001D1B RID: 7451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000386")]
		public float DepthBias
		{
			[Token(Token = "0x6001D1A")]
			[Address(RVA = "0xE8FD60", Offset = "0xE8FD60", VA = "0xE8FD60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001D1B")]
			[Address(RVA = "0xE8FD68", Offset = "0xE8FD68", VA = "0xE8FD68")]
			set
			{
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x0000DA88 File Offset: 0x0000BC88
		// (set) Token: 0x06001D1D RID: 7453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000387")]
		public FillMode FillMode
		{
			[Token(Token = "0x6001D1C")]
			[Address(RVA = "0xE8FD80", Offset = "0xE8FD80", VA = "0xE8FD80")]
			get
			{
				return FillMode.Solid;
			}
			[Token(Token = "0x6001D1D")]
			[Address(RVA = "0xE8FD88", Offset = "0xE8FD88", VA = "0xE8FD88")]
			set
			{
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
		// (set) Token: 0x06001D1F RID: 7455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000388")]
		public bool MultiSampleAntiAlias
		{
			[Token(Token = "0x6001D1E")]
			[Address(RVA = "0xE8FDA0", Offset = "0xE8FDA0", VA = "0xE8FDA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D1F")]
			[Address(RVA = "0xE8FDA8", Offset = "0xE8FDA8", VA = "0xE8FDA8")]
			set
			{
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000389")]
		public bool ScissorTestEnable
		{
			[Token(Token = "0x6001D20")]
			[Address(RVA = "0xE8FDC0", Offset = "0xE8FDC0", VA = "0xE8FDC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D21")]
			[Address(RVA = "0xE8FDC8", Offset = "0xE8FDC8", VA = "0xE8FDC8")]
			set
			{
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		// (set) Token: 0x06001D23 RID: 7459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038A")]
		public float SlopeScaleDepthBias
		{
			[Token(Token = "0x6001D22")]
			[Address(RVA = "0xE8FDE0", Offset = "0xE8FDE0", VA = "0xE8FDE0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001D23")]
			[Address(RVA = "0xE8FDE8", Offset = "0xE8FDE8", VA = "0xE8FDE8")]
			set
			{
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038B")]
		public bool DepthClipEnable
		{
			[Token(Token = "0x6001D24")]
			[Address(RVA = "0xE8FE00", Offset = "0xE8FE00", VA = "0xE8FE00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D25")]
			[Address(RVA = "0xE8FE08", Offset = "0xE8FE08", VA = "0xE8FE08")]
			set
			{
			}
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D26")]
		[Address(RVA = "0xE8FE20", Offset = "0xE8FE20", VA = "0xE8FE20")]
		internal void BindToGraphicsDevice(GraphicsDevice device)
		{
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D27")]
		[Address(RVA = "0xE8FCBC", Offset = "0xE8FCBC", VA = "0xE8FCBC")]
		internal void ThrowIfBound()
		{
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D28")]
		[Address(RVA = "0xE8FED4", Offset = "0xE8FED4", VA = "0xE8FED4")]
		public RasterizerState()
		{
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D29")]
		[Address(RVA = "0xE8FF48", Offset = "0xE8FF48", VA = "0xE8FF48")]
		private RasterizerState(string name, CullMode cullMode)
		{
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D2A")]
		[Address(RVA = "0xE8FFD0", Offset = "0xE8FFD0", VA = "0xE8FFD0")]
		private RasterizerState(RasterizerState cloneSource)
		{
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2C")]
		[Address(RVA = "0xE90310", Offset = "0xE90310", VA = "0xE90310")]
		internal RasterizerState Clone()
		{
			return null;
		}

		// Token: 0x040030B1 RID: 12465
		[Token(Token = "0x40030B1")]
		[FieldOffset(Offset = "0x18")]
		private readonly bool _defaultStateObject;

		// Token: 0x040030B2 RID: 12466
		[Token(Token = "0x40030B2")]
		[FieldOffset(Offset = "0x1C")]
		private CullMode _cullMode;

		// Token: 0x040030B3 RID: 12467
		[Token(Token = "0x40030B3")]
		[FieldOffset(Offset = "0x20")]
		private float _depthBias;

		// Token: 0x040030B4 RID: 12468
		[Token(Token = "0x40030B4")]
		[FieldOffset(Offset = "0x24")]
		private FillMode _fillMode;

		// Token: 0x040030B5 RID: 12469
		[Token(Token = "0x40030B5")]
		[FieldOffset(Offset = "0x28")]
		private bool _multiSampleAntiAlias;

		// Token: 0x040030B6 RID: 12470
		[Token(Token = "0x40030B6")]
		[FieldOffset(Offset = "0x29")]
		private bool _scissorTestEnable;

		// Token: 0x040030B7 RID: 12471
		[Token(Token = "0x40030B7")]
		[FieldOffset(Offset = "0x2C")]
		private float _slopeScaleDepthBias;

		// Token: 0x040030B8 RID: 12472
		[Token(Token = "0x40030B8")]
		[FieldOffset(Offset = "0x30")]
		private bool _depthClipEnable;

		// Token: 0x040030B9 RID: 12473
		[Token(Token = "0x40030B9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RasterizerState CullClockwise;

		// Token: 0x040030BA RID: 12474
		[Token(Token = "0x40030BA")]
		[FieldOffset(Offset = "0x4")]
		public static readonly RasterizerState CullCounterClockwise;

		// Token: 0x040030BB RID: 12475
		[Token(Token = "0x40030BB")]
		[FieldOffset(Offset = "0x8")]
		public static readonly RasterizerState CullNone;
	}
}
