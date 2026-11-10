using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000CA8 RID: 3240
	[Token(Token = "0x2000CA8")]
	public struct LensFlareElement
	{
		// Token: 0x06006042 RID: 24642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006042")]
		[Address(RVA = "0xA9AD1C", Offset = "0xA9AD1C", VA = "0xA9AD1C")]
		public void Draw(SpriteBatch spriteBatch, Vector2 sunPosition, Vector2 screenCenterPosition, float intensity)
		{
		}

		// Token: 0x04009EE9 RID: 40681
		[Token(Token = "0x4009EE9")]
		[FieldOffset(Offset = "0x0")]
		public string TextureAssetPath;

		// Token: 0x04009EEA RID: 40682
		[Token(Token = "0x4009EEA")]
		[FieldOffset(Offset = "0x4")]
		public int RepeatTimes;

		// Token: 0x04009EEB RID: 40683
		[Token(Token = "0x4009EEB")]
		[FieldOffset(Offset = "0x8")]
		public float ScaleStart;

		// Token: 0x04009EEC RID: 40684
		[Token(Token = "0x4009EEC")]
		[FieldOffset(Offset = "0xC")]
		public float ScaleOverIndex;

		// Token: 0x04009EED RID: 40685
		[Token(Token = "0x4009EED")]
		[FieldOffset(Offset = "0x10")]
		public float DistanceStart;

		// Token: 0x04009EEE RID: 40686
		[Token(Token = "0x4009EEE")]
		[FieldOffset(Offset = "0x14")]
		public float DistanceAlongIndex;

		// Token: 0x04009EEF RID: 40687
		[Token(Token = "0x4009EEF")]
		[FieldOffset(Offset = "0x18")]
		public Color Color;

		// Token: 0x04009EF0 RID: 40688
		[Token(Token = "0x4009EF0")]
		[FieldOffset(Offset = "0x1C")]
		public float IntensityOverIndex;

		// Token: 0x04009EF1 RID: 40689
		[Token(Token = "0x4009EF1")]
		[FieldOffset(Offset = "0x20")]
		public float Rotation;
	}
}
