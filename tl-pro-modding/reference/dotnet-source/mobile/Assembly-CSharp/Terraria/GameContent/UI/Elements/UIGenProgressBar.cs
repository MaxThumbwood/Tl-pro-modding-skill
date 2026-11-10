using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D80 RID: 3456
	[Token(Token = "0x2000D80")]
	public class UIGenProgressBar : UIElement
	{
		// Token: 0x0600662B RID: 26155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600662B")]
		[Address(RVA = "0xB5BB28", Offset = "0xB5BB28", VA = "0xB5BB28")]
		public UIGenProgressBar()
		{
		}

		// Token: 0x0600662C RID: 26156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600662C")]
		[Address(RVA = "0xB5BF40", Offset = "0xB5BF40", VA = "0xB5BF40", Slot = "11")]
		public override void Recalculate()
		{
		}

		// Token: 0x0600662D RID: 26157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600662D")]
		[Address(RVA = "0xB5BF70", Offset = "0xB5BF70", VA = "0xB5BF70")]
		public void SetProgress(float overallProgress, float currentProgress)
		{
		}

		// Token: 0x0600662E RID: 26158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600662E")]
		[Address(RVA = "0xB5BF7C", Offset = "0xB5BF7C", VA = "0xB5BF7C", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0600662F RID: 26159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600662F")]
		[Address(RVA = "0xB5CABC", Offset = "0xB5CABC", VA = "0xB5CABC")]
		private void DrawFilling(SpriteBatch spritebatch, Texture2D tex, Texture2D texShadow, Vector2 topLeft, int completedWidth, int totalWidth, Color separator, Color empty)
		{
		}

		// Token: 0x06006630 RID: 26160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006630")]
		[Address(RVA = "0xB5C6C4", Offset = "0xB5C6C4", VA = "0xB5C6C4")]
		private void DrawFilling2(SpriteBatch spritebatch, Vector2 topLeft, int height, int completedWidth, int totalWidth, Color filled, Color separator, Color empty)
		{
		}

		// Token: 0x0400A36B RID: 41835
		[Token(Token = "0x400A36B")]
		[FieldOffset(Offset = "0xF4")]
		private Asset<Texture2D> _texOuterCrimson;

		// Token: 0x0400A36C RID: 41836
		[Token(Token = "0x400A36C")]
		[FieldOffset(Offset = "0xF8")]
		private Asset<Texture2D> _texOuterCorrupt;

		// Token: 0x0400A36D RID: 41837
		[Token(Token = "0x400A36D")]
		[FieldOffset(Offset = "0xFC")]
		private Asset<Texture2D> _texOuterRandom;

		// Token: 0x0400A36E RID: 41838
		[Token(Token = "0x400A36E")]
		[FieldOffset(Offset = "0x100")]
		private Asset<Texture2D> _texOuterLower;

		// Token: 0x0400A36F RID: 41839
		[Token(Token = "0x400A36F")]
		[FieldOffset(Offset = "0x104")]
		private float _visualOverallProgress;

		// Token: 0x0400A370 RID: 41840
		[Token(Token = "0x400A370")]
		[FieldOffset(Offset = "0x108")]
		private float _targetOverallProgress;

		// Token: 0x0400A371 RID: 41841
		[Token(Token = "0x400A371")]
		[FieldOffset(Offset = "0x10C")]
		private float _visualCurrentProgress;

		// Token: 0x0400A372 RID: 41842
		[Token(Token = "0x400A372")]
		[FieldOffset(Offset = "0x110")]
		private float _targetCurrentProgress;

		// Token: 0x0400A373 RID: 41843
		[Token(Token = "0x400A373")]
		[FieldOffset(Offset = "0x114")]
		private int _smallBarWidth;

		// Token: 0x0400A374 RID: 41844
		[Token(Token = "0x400A374")]
		[FieldOffset(Offset = "0x118")]
		private int _longBarWidth;
	}
}
