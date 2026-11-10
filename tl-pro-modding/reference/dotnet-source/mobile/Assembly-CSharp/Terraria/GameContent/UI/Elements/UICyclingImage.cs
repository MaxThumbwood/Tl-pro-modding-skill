using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D7B RID: 3451
	[Token(Token = "0x2000D7B")]
	public class UICyclingImage : UIImage
	{
		// Token: 0x0600660B RID: 26123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600660B")]
		[Address(RVA = "0xB59AC4", Offset = "0xB59AC4", VA = "0xB59AC4")]
		public UICyclingImage(List<Asset<Texture2D>> textureAssets)
		{
		}

		// Token: 0x0600660C RID: 26124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600660C")]
		[Address(RVA = "0xB59B58", Offset = "0xB59B58", VA = "0xB59B58", Slot = "9")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x0400A353 RID: 41811
		[Token(Token = "0x400A353")]
		[FieldOffset(Offset = "0x128")]
		public int FramesPerCycle;

		// Token: 0x0400A354 RID: 41812
		[Token(Token = "0x400A354")]
		[FieldOffset(Offset = "0x12C")]
		private List<Asset<Texture2D>> _textureAssets;

		// Token: 0x0400A355 RID: 41813
		[Token(Token = "0x400A355")]
		[FieldOffset(Offset = "0x130")]
		private int _currentTextureIndex;

		// Token: 0x0400A356 RID: 41814
		[Token(Token = "0x400A356")]
		[FieldOffset(Offset = "0x134")]
		private int _framesCounted;
	}
}
