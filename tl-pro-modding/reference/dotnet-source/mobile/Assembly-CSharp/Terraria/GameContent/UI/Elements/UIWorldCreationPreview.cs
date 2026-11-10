using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000DA2 RID: 3490
	[Token(Token = "0x2000DA2")]
	public class UIWorldCreationPreview : UIElement
	{
		// Token: 0x06006700 RID: 26368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006700")]
		[Address(RVA = "0xB68F3C", Offset = "0xB68F3C", VA = "0xB68F3C")]
		public UIWorldCreationPreview()
		{
		}

		// Token: 0x06006701 RID: 26369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006701")]
		[Address(RVA = "0xB69AFC", Offset = "0xB69AFC", VA = "0xB69AFC")]
		public void UpdateOption(byte difficulty, byte evil, byte size)
		{
		}

		// Token: 0x06006702 RID: 26370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006702")]
		[Address(RVA = "0xB69B0C", Offset = "0xB69B0C", VA = "0xB69B0C", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0400A40E RID: 41998
		[Token(Token = "0x400A40E")]
		[FieldOffset(Offset = "0xF4")]
		private readonly Asset<Texture2D> _BorderTexture;

		// Token: 0x0400A40F RID: 41999
		[Token(Token = "0x400A40F")]
		[FieldOffset(Offset = "0xF8")]
		private readonly Asset<Texture2D> _BackgroundExpertTexture;

		// Token: 0x0400A410 RID: 42000
		[Token(Token = "0x400A410")]
		[FieldOffset(Offset = "0xFC")]
		private readonly Asset<Texture2D> _BackgroundNormalTexture;

		// Token: 0x0400A411 RID: 42001
		[Token(Token = "0x400A411")]
		[FieldOffset(Offset = "0x100")]
		private readonly Asset<Texture2D> _BackgroundMasterTexture;

		// Token: 0x0400A412 RID: 42002
		[Token(Token = "0x400A412")]
		[FieldOffset(Offset = "0x104")]
		private readonly Asset<Texture2D> _BunnyExpertTexture;

		// Token: 0x0400A413 RID: 42003
		[Token(Token = "0x400A413")]
		[FieldOffset(Offset = "0x108")]
		private readonly Asset<Texture2D> _BunnyNormalTexture;

		// Token: 0x0400A414 RID: 42004
		[Token(Token = "0x400A414")]
		[FieldOffset(Offset = "0x10C")]
		private readonly Asset<Texture2D> _BunnyCreativeTexture;

		// Token: 0x0400A415 RID: 42005
		[Token(Token = "0x400A415")]
		[FieldOffset(Offset = "0x110")]
		private readonly Asset<Texture2D> _BunnyMasterTexture;

		// Token: 0x0400A416 RID: 42006
		[Token(Token = "0x400A416")]
		[FieldOffset(Offset = "0x114")]
		private readonly Asset<Texture2D> _EvilRandomTexture;

		// Token: 0x0400A417 RID: 42007
		[Token(Token = "0x400A417")]
		[FieldOffset(Offset = "0x118")]
		private readonly Asset<Texture2D> _EvilCorruptionTexture;

		// Token: 0x0400A418 RID: 42008
		[Token(Token = "0x400A418")]
		[FieldOffset(Offset = "0x11C")]
		private readonly Asset<Texture2D> _EvilCrimsonTexture;

		// Token: 0x0400A419 RID: 42009
		[Token(Token = "0x400A419")]
		[FieldOffset(Offset = "0x120")]
		private readonly Asset<Texture2D> _SizeSmallTexture;

		// Token: 0x0400A41A RID: 42010
		[Token(Token = "0x400A41A")]
		[FieldOffset(Offset = "0x124")]
		private readonly Asset<Texture2D> _SizeMediumTexture;

		// Token: 0x0400A41B RID: 42011
		[Token(Token = "0x400A41B")]
		[FieldOffset(Offset = "0x128")]
		private readonly Asset<Texture2D> _SizeLargeTexture;

		// Token: 0x0400A41C RID: 42012
		[Token(Token = "0x400A41C")]
		[FieldOffset(Offset = "0x12C")]
		private byte _difficulty;

		// Token: 0x0400A41D RID: 42013
		[Token(Token = "0x400A41D")]
		[FieldOffset(Offset = "0x12D")]
		private byte _evil;

		// Token: 0x0400A41E RID: 42014
		[Token(Token = "0x400A41E")]
		[FieldOffset(Offset = "0x12E")]
		private byte _size;
	}
}
