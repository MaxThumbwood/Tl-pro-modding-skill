using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000CA6 RID: 3238
	[Token(Token = "0x2000CA6")]
	public class BackgroundGradientDrawer
	{
		// Token: 0x06006027 RID: 24615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006027")]
		[Address(RVA = "0xA9568C", Offset = "0xA9568C", VA = "0xA9568C")]
		public BackgroundGradientDrawer(Color gradientColor, GetBackgroundDrawWeightMethod weightGetter, BackgroundArrayGetterMethod textureGetter, int[] textureIndexesToCheck)
		{
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006028")]
		[Address(RVA = "0xA914D0", Offset = "0xA914D0", VA = "0xA914D0")]
		public void Draw()
		{
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x0002C568 File Offset: 0x0002A768
		[Token(Token = "0x6006029")]
		[Address(RVA = "0xA963B8", Offset = "0xA963B8", VA = "0xA963B8")]
		private static Rectangle GetGradientRect()
		{
			return default(Rectangle);
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x0002C580 File Offset: 0x0002A780
		[Token(Token = "0x600602A")]
		[Address(RVA = "0xA9630C", Offset = "0xA9630C", VA = "0xA9630C")]
		private bool ShouldDrawForTextures()
		{
			return default(bool);
		}

		// Token: 0x04009EE1 RID: 40673
		[Token(Token = "0x4009EE1")]
		[FieldOffset(Offset = "0x8")]
		private Color _color;

		// Token: 0x04009EE2 RID: 40674
		[Token(Token = "0x4009EE2")]
		[FieldOffset(Offset = "0xC")]
		private GetBackgroundDrawWeightMethod _weightGetter;

		// Token: 0x04009EE3 RID: 40675
		[Token(Token = "0x4009EE3")]
		[FieldOffset(Offset = "0x10")]
		private BackgroundArrayGetterMethod _textureGetter;

		// Token: 0x04009EE4 RID: 40676
		[Token(Token = "0x4009EE4")]
		[FieldOffset(Offset = "0x14")]
		private int[] _textureIndexesToCheck;
	}
}
