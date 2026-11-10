using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000416 RID: 1046
	[Token(Token = "0x2000416")]
	public class BlendState : GraphicsResource
	{
		// Token: 0x06001CCF RID: 7375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCF")]
		[Address(RVA = "0xE8E1E8", Offset = "0xE8E1E8", VA = "0xE8E1E8")]
		internal void BindToGraphicsDevice(GraphicsDevice device)
		{
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD0")]
		[Address(RVA = "0xE8E29C", Offset = "0xE8E29C", VA = "0xE8E29C")]
		internal void ThrowIfBound()
		{
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001CD1 RID: 7377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000367")]
		public TargetBlendState Item
		{
			[Token(Token = "0x6001CD1")]
			[Address(RVA = "0xE8E340", Offset = "0xE8E340", VA = "0xE8E340")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x0000D7A0 File Offset: 0x0000B9A0
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000368")]
		public BlendFunction AlphaBlendFunction
		{
			[Token(Token = "0x6001CD2")]
			[Address(RVA = "0xE8E364", Offset = "0xE8E364", VA = "0xE8E364")]
			get
			{
				return BlendFunction.Add;
			}
			[Token(Token = "0x6001CD3")]
			[Address(RVA = "0xE8E398", Offset = "0xE8E398", VA = "0xE8E398")]
			set
			{
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000369")]
		public Blend AlphaDestinationBlend
		{
			[Token(Token = "0x6001CD4")]
			[Address(RVA = "0xE8E414", Offset = "0xE8E414", VA = "0xE8E414")]
			get
			{
				return Blend.One;
			}
			[Token(Token = "0x6001CD5")]
			[Address(RVA = "0xE8E448", Offset = "0xE8E448", VA = "0xE8E448")]
			set
			{
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036A")]
		public Blend AlphaSourceBlend
		{
			[Token(Token = "0x6001CD6")]
			[Address(RVA = "0xE8E4C4", Offset = "0xE8E4C4", VA = "0xE8E4C4")]
			get
			{
				return Blend.One;
			}
			[Token(Token = "0x6001CD7")]
			[Address(RVA = "0xE8E4F8", Offset = "0xE8E4F8", VA = "0xE8E4F8")]
			set
			{
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
		// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036B")]
		public BlendFunction ColorBlendFunction
		{
			[Token(Token = "0x6001CD8")]
			[Address(RVA = "0xE8E574", Offset = "0xE8E574", VA = "0xE8E574")]
			get
			{
				return BlendFunction.Add;
			}
			[Token(Token = "0x6001CD9")]
			[Address(RVA = "0xE8E5A8", Offset = "0xE8E5A8", VA = "0xE8E5A8")]
			set
			{
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x0000D800 File Offset: 0x0000BA00
		// (set) Token: 0x06001CDB RID: 7387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036C")]
		public Blend ColorDestinationBlend
		{
			[Token(Token = "0x6001CDA")]
			[Address(RVA = "0xE8E624", Offset = "0xE8E624", VA = "0xE8E624")]
			get
			{
				return Blend.One;
			}
			[Token(Token = "0x6001CDB")]
			[Address(RVA = "0xE8E658", Offset = "0xE8E658", VA = "0xE8E658")]
			set
			{
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x0000D818 File Offset: 0x0000BA18
		// (set) Token: 0x06001CDD RID: 7389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036D")]
		public Blend ColorSourceBlend
		{
			[Token(Token = "0x6001CDC")]
			[Address(RVA = "0xE8E6D4", Offset = "0xE8E6D4", VA = "0xE8E6D4")]
			get
			{
				return Blend.One;
			}
			[Token(Token = "0x6001CDD")]
			[Address(RVA = "0xE8E708", Offset = "0xE8E708", VA = "0xE8E708")]
			set
			{
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x0000D830 File Offset: 0x0000BA30
		// (set) Token: 0x06001CDF RID: 7391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036E")]
		public ColorWriteChannels ColorWriteChannels
		{
			[Token(Token = "0x6001CDE")]
			[Address(RVA = "0xE8E784", Offset = "0xE8E784", VA = "0xE8E784")]
			get
			{
				return ColorWriteChannels.None;
			}
			[Token(Token = "0x6001CDF")]
			[Address(RVA = "0xE8E7B8", Offset = "0xE8E7B8", VA = "0xE8E7B8")]
			set
			{
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x0000D848 File Offset: 0x0000BA48
		// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036F")]
		public ColorWriteChannels ColorWriteChannels1
		{
			[Token(Token = "0x6001CE0")]
			[Address(RVA = "0xE8E834", Offset = "0xE8E834", VA = "0xE8E834")]
			get
			{
				return ColorWriteChannels.None;
			}
			[Token(Token = "0x6001CE1")]
			[Address(RVA = "0xE8E868", Offset = "0xE8E868", VA = "0xE8E868")]
			set
			{
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x0000D860 File Offset: 0x0000BA60
		// (set) Token: 0x06001CE3 RID: 7395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000370")]
		public ColorWriteChannels ColorWriteChannels2
		{
			[Token(Token = "0x6001CE2")]
			[Address(RVA = "0xE8E8B8", Offset = "0xE8E8B8", VA = "0xE8E8B8")]
			get
			{
				return ColorWriteChannels.None;
			}
			[Token(Token = "0x6001CE3")]
			[Address(RVA = "0xE8E8EC", Offset = "0xE8E8EC", VA = "0xE8E8EC")]
			set
			{
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x0000D878 File Offset: 0x0000BA78
		// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000371")]
		public ColorWriteChannels ColorWriteChannels3
		{
			[Token(Token = "0x6001CE4")]
			[Address(RVA = "0xE8E93C", Offset = "0xE8E93C", VA = "0xE8E93C")]
			get
			{
				return ColorWriteChannels.None;
			}
			[Token(Token = "0x6001CE5")]
			[Address(RVA = "0xE8E970", Offset = "0xE8E970", VA = "0xE8E970")]
			set
			{
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x0000D890 File Offset: 0x0000BA90
		// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000372")]
		public Color BlendFactor
		{
			[Token(Token = "0x6001CE6")]
			[Address(RVA = "0xE8E9C0", Offset = "0xE8E9C0", VA = "0xE8E9C0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6001CE7")]
			[Address(RVA = "0xE8E9C8", Offset = "0xE8E9C8", VA = "0xE8E9C8")]
			set
			{
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
		// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000373")]
		public int MultiSampleMask
		{
			[Token(Token = "0x6001CE8")]
			[Address(RVA = "0xE8E9E0", Offset = "0xE8E9E0", VA = "0xE8E9E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001CE9")]
			[Address(RVA = "0xE8E9E8", Offset = "0xE8E9E8", VA = "0xE8E9E8")]
			set
			{
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		// (set) Token: 0x06001CEB RID: 7403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000374")]
		public bool IndependentBlendEnable
		{
			[Token(Token = "0x6001CEA")]
			[Address(RVA = "0xE8EA00", Offset = "0xE8EA00", VA = "0xE8EA00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001CEB")]
			[Address(RVA = "0xE8EA08", Offset = "0xE8EA08", VA = "0xE8EA08")]
			set
			{
			}
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEC")]
		[Address(RVA = "0xE8EA20", Offset = "0xE8EA20", VA = "0xE8EA20")]
		public BlendState()
		{
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CED")]
		[Address(RVA = "0xE8EDA4", Offset = "0xE8EDA4", VA = "0xE8EDA4")]
		private BlendState(string name, Blend sourceBlend, Blend destinationBlend)
		{
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEE")]
		[Address(RVA = "0xE8EEDC", Offset = "0xE8EEDC", VA = "0xE8EEDC")]
		private BlendState(BlendState cloneSource)
		{
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF0")]
		[Address(RVA = "0xE8F46C", Offset = "0xE8F46C", VA = "0xE8F46C")]
		internal BlendState Clone()
		{
			return null;
		}

		// Token: 0x0400307F RID: 12415
		[Token(Token = "0x400307F")]
		[FieldOffset(Offset = "0x18")]
		private readonly TargetBlendState[] _targetBlendState;

		// Token: 0x04003080 RID: 12416
		[Token(Token = "0x4003080")]
		[FieldOffset(Offset = "0x1C")]
		private readonly bool _defaultStateObject;

		// Token: 0x04003081 RID: 12417
		[Token(Token = "0x4003081")]
		[FieldOffset(Offset = "0x1D")]
		private Color _blendFactor;

		// Token: 0x04003082 RID: 12418
		[Token(Token = "0x4003082")]
		[FieldOffset(Offset = "0x24")]
		private int _multiSampleMask;

		// Token: 0x04003083 RID: 12419
		[Token(Token = "0x4003083")]
		[FieldOffset(Offset = "0x28")]
		private bool _independentBlendEnable;

		// Token: 0x04003084 RID: 12420
		[Token(Token = "0x4003084")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BlendState Additive;

		// Token: 0x04003085 RID: 12421
		[Token(Token = "0x4003085")]
		[FieldOffset(Offset = "0x4")]
		public static readonly BlendState AlphaBlend;

		// Token: 0x04003086 RID: 12422
		[Token(Token = "0x4003086")]
		[FieldOffset(Offset = "0x8")]
		public static readonly BlendState NonPremultiplied;

		// Token: 0x04003087 RID: 12423
		[Token(Token = "0x4003087")]
		[FieldOffset(Offset = "0xC")]
		public static readonly BlendState Opaque;
	}
}
