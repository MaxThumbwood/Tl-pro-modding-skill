using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x02000DA8 RID: 3496
	[Token(Token = "0x2000DA8")]
	public interface IChatMonitor
	{
		// Token: 0x06006715 RID: 26389
		[Token(Token = "0x6006715")]
		void NewText(string newText, byte R = 255, byte G = 255, byte B = 255);

		// Token: 0x06006716 RID: 26390
		[Token(Token = "0x6006716")]
		void NewTextMultiline(string text, bool force = false, [Optional] Color c, int WidthLimit = -1);

		// Token: 0x06006717 RID: 26391
		[Token(Token = "0x6006717")]
		void Clear();

		// Token: 0x06006718 RID: 26392
		[Token(Token = "0x6006718")]
		void Update();

		// Token: 0x06006719 RID: 26393
		[Token(Token = "0x6006719")]
		void Offset(int linesOffset);

		// Token: 0x0600671A RID: 26394
		[Token(Token = "0x600671A")]
		void ResetOffset();
	}
}
