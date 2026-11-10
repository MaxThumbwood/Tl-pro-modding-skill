using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent
{
	// Token: 0x02000981 RID: 2433
	[Token(Token = "0x2000981")]
	public class PlayerTitaniumStormBuffTextureContent : ARenderTargetContentByRequest
	{
		// Token: 0x0600505A RID: 20570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505A")]
		[Address(RVA = "0x769970", Offset = "0x769970", VA = "0x769970")]
		public PlayerTitaniumStormBuffTextureContent()
		{
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600505B")]
		[Address(RVA = "0x769ABC", Offset = "0x769ABC", VA = "0x769ABC")]
		public EffectPass GetRenderEffect()
		{
			return null;
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505C")]
		[Address(RVA = "0x769CDC", Offset = "0x769CDC", VA = "0x769CDC", Slot = "7")]
		protected override void HandleUseRequest(GraphicsDevice device, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0600505D RID: 20573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505D")]
		[Address(RVA = "0x769C64", Offset = "0x769C64", VA = "0x769C64")]
		public void UpdateSettingsForRendering(float gradientContributionFromOriginalTexture, float gradientScrollingSpeed, float flatGradientOffset, float gradientColorDominance)
		{
		}

		// Token: 0x04009434 RID: 37940
		[Token(Token = "0x4009434")]
		[FieldOffset(Offset = "0x10")]
		private EffectPass renderEffect;

		// Token: 0x04009435 RID: 37941
		[Token(Token = "0x4009435")]
		[FieldOffset(Offset = "0x14")]
		private MiscShaderData _shaderData;
	}
}
