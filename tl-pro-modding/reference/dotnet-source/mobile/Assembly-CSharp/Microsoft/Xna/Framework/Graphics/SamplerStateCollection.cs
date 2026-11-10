using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000404 RID: 1028
	[Token(Token = "0x2000404")]
	public sealed class SamplerStateCollection
	{
		// Token: 0x06001C41 RID: 7233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C41")]
		[Address(RVA = "0xE850A8", Offset = "0xE850A8", VA = "0xE850A8")]
		internal SamplerStateCollection(GraphicsDevice device, int maxSamplers, bool applyToVertexStage)
		{
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035D")]
		public SamplerState Item
		{
			[Token(Token = "0x6001C42")]
			[Address(RVA = "0xE853B0", Offset = "0xE853B0", VA = "0xE853B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C43")]
			[Address(RVA = "0xE853D4", Offset = "0xE853D4", VA = "0xE853D4")]
			set
			{
			}
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C44")]
		[Address(RVA = "0xE85258", Offset = "0xE85258", VA = "0xE85258")]
		internal void Clear()
		{
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C45")]
		[Address(RVA = "0xE85678", Offset = "0xE85678", VA = "0xE85678")]
		internal void Dirty()
		{
		}

		// Token: 0x04002FDE RID: 12254
		[Token(Token = "0x4002FDE")]
		[FieldOffset(Offset = "0x8")]
		private readonly GraphicsDevice _graphicsDevice;

		// Token: 0x04002FDF RID: 12255
		[Token(Token = "0x4002FDF")]
		[FieldOffset(Offset = "0xC")]
		private readonly SamplerState _samplerStateAnisotropicClamp;

		// Token: 0x04002FE0 RID: 12256
		[Token(Token = "0x4002FE0")]
		[FieldOffset(Offset = "0x10")]
		private readonly SamplerState _samplerStateAnisotropicWrap;

		// Token: 0x04002FE1 RID: 12257
		[Token(Token = "0x4002FE1")]
		[FieldOffset(Offset = "0x14")]
		private readonly SamplerState _samplerStateLinearClamp;

		// Token: 0x04002FE2 RID: 12258
		[Token(Token = "0x4002FE2")]
		[FieldOffset(Offset = "0x18")]
		private readonly SamplerState _samplerStateLinearWrap;

		// Token: 0x04002FE3 RID: 12259
		[Token(Token = "0x4002FE3")]
		[FieldOffset(Offset = "0x1C")]
		private readonly SamplerState _samplerStatePointClamp;

		// Token: 0x04002FE4 RID: 12260
		[Token(Token = "0x4002FE4")]
		[FieldOffset(Offset = "0x20")]
		private readonly SamplerState _samplerStatePointWrap;

		// Token: 0x04002FE5 RID: 12261
		[Token(Token = "0x4002FE5")]
		[FieldOffset(Offset = "0x24")]
		private readonly SamplerState[] _samplers;

		// Token: 0x04002FE6 RID: 12262
		[Token(Token = "0x4002FE6")]
		[FieldOffset(Offset = "0x28")]
		private readonly SamplerState[] _actualSamplers;

		// Token: 0x04002FE7 RID: 12263
		[Token(Token = "0x4002FE7")]
		[FieldOffset(Offset = "0x2C")]
		private readonly bool _applyToVertexStage;
	}
}
