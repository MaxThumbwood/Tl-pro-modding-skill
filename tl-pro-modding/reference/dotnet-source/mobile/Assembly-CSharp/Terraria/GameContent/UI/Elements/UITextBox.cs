using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D9C RID: 3484
	[Token(Token = "0x2000D9C")]
	internal class UITextBox : UITextPanel<string>
	{
		// Token: 0x060066D9 RID: 26329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D9")]
		[Address(RVA = "0xB65714", Offset = "0xB65714", VA = "0xB65714")]
		public UITextBox(string text, float textScale = 1f, bool large = false)
		{
		}

		// Token: 0x060066DA RID: 26330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DA")]
		[Address(RVA = "0xB67244", Offset = "0xB67244", VA = "0xB67244")]
		public void Write(string text)
		{
		}

		// Token: 0x060066DB RID: 26331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DB")]
		[Address(RVA = "0xB6730C", Offset = "0xB6730C", VA = "0xB6730C", Slot = "30")]
		public override void SetText(string text, float textScale, bool large)
		{
		}

		// Token: 0x060066DC RID: 26332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DC")]
		[Address(RVA = "0xB67474", Offset = "0xB67474", VA = "0xB67474")]
		public void SetTextMaxLength(int maxLength)
		{
		}

		// Token: 0x060066DD RID: 26333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DD")]
		[Address(RVA = "0xB6747C", Offset = "0xB6747C", VA = "0xB6747C")]
		public void Backspace()
		{
		}

		// Token: 0x060066DE RID: 26334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DE")]
		[Address(RVA = "0xB6754C", Offset = "0xB6754C", VA = "0xB6754C")]
		public void CursorLeft()
		{
		}

		// Token: 0x060066DF RID: 26335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DF")]
		[Address(RVA = "0xB67560", Offset = "0xB67560", VA = "0xB67560")]
		public void CursorRight()
		{
		}

		// Token: 0x060066E0 RID: 26336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E0")]
		[Address(RVA = "0xB675DC", Offset = "0xB675DC", VA = "0xB675DC", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0400A3EA RID: 41962
		[Token(Token = "0x400A3EA")]
		[FieldOffset(Offset = "0x130")]
		private int _cursor;

		// Token: 0x0400A3EB RID: 41963
		[Token(Token = "0x400A3EB")]
		[FieldOffset(Offset = "0x134")]
		private int _frameCount;

		// Token: 0x0400A3EC RID: 41964
		[Token(Token = "0x400A3EC")]
		[FieldOffset(Offset = "0x138")]
		private int _maxLength;

		// Token: 0x0400A3ED RID: 41965
		[Token(Token = "0x400A3ED")]
		[FieldOffset(Offset = "0x13C")]
		public bool ShowInputTicker;

		// Token: 0x0400A3EE RID: 41966
		[Token(Token = "0x400A3EE")]
		[FieldOffset(Offset = "0x13D")]
		public bool HideSelf;
	}
}
