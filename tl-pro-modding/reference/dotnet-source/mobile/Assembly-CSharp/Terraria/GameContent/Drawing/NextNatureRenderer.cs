using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000CAC RID: 3244
	[Token(Token = "0x2000CAC")]
	public class NextNatureRenderer : FileAPI
	{
		// Token: 0x0600604A RID: 24650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604A")]
		[Address(RVA = "0xA9B8C4", Offset = "0xA9B8C4", VA = "0xA9B8C4", Slot = "5")]
		public void DrawNature(Texture2D texture, ref Vector2 position, ref Rectangle sourceRectangle, Color color, float rotation, ref Vector2 origin, SpriteEffects effects, SideFlags seams = SideFlags.None)
		{
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x0002C628 File Offset: 0x0002A828
		[Token(Token = "0x600604B")]
		[Address(RVA = "0xA9BA80", Offset = "0xA9BA80", VA = "0xA9BA80")]
		private static SideFlags GetOriginSides(ref Rectangle sourceRectangle, ref Vector2 origin)
		{
			return SideFlags.None;
		}

		// Token: 0x0600604C RID: 24652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604C")]
		[Address(RVA = "0xA9BAE8", Offset = "0xA9BAE8", VA = "0xA9BAE8", Slot = "4")]
		public void Begin()
		{
		}

		// Token: 0x0600604D RID: 24653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604D")]
		[Address(RVA = "0xA9C298", Offset = "0xA9C298", VA = "0xA9C298", Slot = "6")]
		public void DrawAfterAllObjects()
		{
		}

		// Token: 0x0600604E RID: 24654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604E")]
		[Address(RVA = "0xA9C338", Offset = "0xA9C338", VA = "0xA9C338")]
		public NextNatureRenderer()
		{
		}

		// Token: 0x04009EF8 RID: 40696
		[Token(Token = "0x4009EF8")]
		[FieldOffset(Offset = "0x8")]
		private EffectPass defaultEffect;
	}
}
