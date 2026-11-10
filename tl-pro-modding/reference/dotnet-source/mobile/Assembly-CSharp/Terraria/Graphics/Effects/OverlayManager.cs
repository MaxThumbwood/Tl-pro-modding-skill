using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects
{
	// Token: 0x0200090C RID: 2316
	[Token(Token = "0x200090C")]
	public class OverlayManager : EffectManager<Overlay>
	{
		// Token: 0x06004DB4 RID: 19892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB4")]
		[Address(RVA = "0x7256D8", Offset = "0x7256D8", VA = "0x7256D8")]
		public OverlayManager()
		{
		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB5")]
		[Address(RVA = "0x7258DC", Offset = "0x7258DC", VA = "0x7258DC", Slot = "4")]
		public override void OnActivate(Overlay overlay, Vector2 position)
		{
		}

		// Token: 0x06004DB6 RID: 19894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB6")]
		[Address(RVA = "0x725B70", Offset = "0x725B70", VA = "0x725B70")]
		public void Update(GameTime gameTime)
		{
		}

		// Token: 0x06004DB7 RID: 19895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB7")]
		[Address(RVA = "0x725EEC", Offset = "0x725EEC", VA = "0x725EEC")]
		public void Draw(SpriteBatch spriteBatch, RenderLayers layer)
		{
		}

		// Token: 0x040092C0 RID: 37568
		[Token(Token = "0x40092C0")]
		private const float OPACITY_RATE = 1f;

		// Token: 0x040092C1 RID: 37569
		[Token(Token = "0x40092C1")]
		[FieldOffset(Offset = "0x10")]
		private LinkedList<Overlay>[] _activeOverlays;

		// Token: 0x040092C2 RID: 37570
		[Token(Token = "0x40092C2")]
		[FieldOffset(Offset = "0x14")]
		private int _overlayCount;
	}
}
