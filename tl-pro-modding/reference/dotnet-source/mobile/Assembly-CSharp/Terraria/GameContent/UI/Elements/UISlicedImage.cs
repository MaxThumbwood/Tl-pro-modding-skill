using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D9A RID: 3482
	[Token(Token = "0x2000D9A")]
	public class UISlicedImage : UIElement
	{
		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x060066B9 RID: 26297 RVA: 0x0002E620 File Offset: 0x0002C820
		// (set) Token: 0x060066BA RID: 26298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AFC")]
		public Color Color
		{
			[Token(Token = "0x60066B9")]
			[Address(RVA = "0xB663C8", Offset = "0xB663C8", VA = "0xB663C8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60066BA")]
			[Address(RVA = "0xB663D0", Offset = "0xB663D0", VA = "0xB663D0")]
			set
			{
			}
		}

		// Token: 0x060066BB RID: 26299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BB")]
		[Address(RVA = "0xB663D8", Offset = "0xB663D8", VA = "0xB663D8")]
		public UISlicedImage(Asset<Texture2D> texture)
		{
		}

		// Token: 0x060066BC RID: 26300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BC")]
		[Address(RVA = "0xB66500", Offset = "0xB66500", VA = "0xB66500")]
		public void SetImage(Asset<Texture2D> texture)
		{
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BD")]
		[Address(RVA = "0xB66508", Offset = "0xB66508", VA = "0xB66508", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BE")]
		[Address(RVA = "0xB66638", Offset = "0xB66638", VA = "0xB66638")]
		public void SetSliceDepths(int top, int bottom, int left, int right)
		{
		}

		// Token: 0x060066BF RID: 26303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BF")]
		[Address(RVA = "0xB66650", Offset = "0xB66650", VA = "0xB66650")]
		public void SetSliceDepths(int fluff)
		{
		}

		// Token: 0x0400A3D6 RID: 41942
		[Token(Token = "0x400A3D6")]
		[FieldOffset(Offset = "0xF4")]
		private Asset<Texture2D> _texture;

		// Token: 0x0400A3D7 RID: 41943
		[Token(Token = "0x400A3D7")]
		[FieldOffset(Offset = "0xF8")]
		private Color _color;

		// Token: 0x0400A3D8 RID: 41944
		[Token(Token = "0x400A3D8")]
		[FieldOffset(Offset = "0xFC")]
		private int _leftSliceDepth;

		// Token: 0x0400A3D9 RID: 41945
		[Token(Token = "0x400A3D9")]
		[FieldOffset(Offset = "0x100")]
		private int _rightSliceDepth;

		// Token: 0x0400A3DA RID: 41946
		[Token(Token = "0x400A3DA")]
		[FieldOffset(Offset = "0x104")]
		private int _topSliceDepth;

		// Token: 0x0400A3DB RID: 41947
		[Token(Token = "0x400A3DB")]
		[FieldOffset(Offset = "0x108")]
		private int _bottomSliceDepth;
	}
}
