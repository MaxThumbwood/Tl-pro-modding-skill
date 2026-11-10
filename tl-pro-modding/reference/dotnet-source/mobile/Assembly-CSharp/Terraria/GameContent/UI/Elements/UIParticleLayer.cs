using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Renderers;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D92 RID: 3474
	[Token(Token = "0x2000D92")]
	public class UIParticleLayer : UIElement
	{
		// Token: 0x06006684 RID: 26244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006684")]
		[Address(RVA = "0xB63968", Offset = "0xB63968", VA = "0xB63968")]
		public UIParticleLayer()
		{
		}

		// Token: 0x06006685 RID: 26245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006685")]
		[Address(RVA = "0xB63A90", Offset = "0xB63A90", VA = "0xB63A90")]
		private void ParticleSystemUpdate(UIElement affectedElement)
		{
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006686")]
		[Address(RVA = "0xB63AB4", Offset = "0xB63AB4", VA = "0xB63AB4", Slot = "11")]
		public override void Recalculate()
		{
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006687")]
		[Address(RVA = "0xB63C54", Offset = "0xB63C54", VA = "0xB63C54", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006688")]
		[Address(RVA = "0xB63C80", Offset = "0xB63C80", VA = "0xB63C80")]
		public void AddParticle(IParticle particle)
		{
		}

		// Token: 0x06006689 RID: 26249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006689")]
		[Address(RVA = "0xB63CAC", Offset = "0xB63CAC", VA = "0xB63CAC")]
		public void ClearParticles()
		{
		}

		// Token: 0x0400A3B3 RID: 41907
		[Token(Token = "0x400A3B3")]
		[FieldOffset(Offset = "0xF4")]
		public ParticleRenderer ParticleSystem;

		// Token: 0x0400A3B4 RID: 41908
		[Token(Token = "0x400A3B4")]
		[FieldOffset(Offset = "0xF8")]
		public Vector2 AnchorPositionOffsetByPercents;

		// Token: 0x0400A3B5 RID: 41909
		[Token(Token = "0x400A3B5")]
		[FieldOffset(Offset = "0x100")]
		public Vector2 AnchorPositionOffsetByPixels;
	}
}
