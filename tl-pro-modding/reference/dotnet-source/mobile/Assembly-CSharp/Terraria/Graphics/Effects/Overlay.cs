using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects
{
	// Token: 0x0200090B RID: 2315
	[Token(Token = "0x200090B")]
	public abstract class Overlay : GameEffect
	{
		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06004DB0 RID: 19888 RVA: 0x00024618 File Offset: 0x00022818
		[Token(Token = "0x17000962")]
		public RenderLayers Layer
		{
			[Token(Token = "0x6004DB0")]
			[Address(RVA = "0x725698", Offset = "0x725698", VA = "0x725698")]
			get
			{
				return RenderLayers.Sky;
			}
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB1")]
		[Address(RVA = "0x7256A0", Offset = "0x7256A0", VA = "0x7256A0")]
		public Overlay(EffectPriority priority, RenderLayers layer)
		{
		}

		// Token: 0x06004DB2 RID: 19890
		[Token(Token = "0x6004DB2")]
		public abstract void Draw(SpriteBatch spriteBatch);

		// Token: 0x06004DB3 RID: 19891
		[Token(Token = "0x6004DB3")]
		public abstract void Update(GameTime gameTime);

		// Token: 0x040092BE RID: 37566
		[Token(Token = "0x40092BE")]
		[FieldOffset(Offset = "0x14")]
		public OverlayMode Mode;

		// Token: 0x040092BF RID: 37567
		[Token(Token = "0x40092BF")]
		[FieldOffset(Offset = "0x18")]
		private RenderLayers _layer;
	}
}
