using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;

namespace Terraria.UI
{
	// Token: 0x02000835 RID: 2101
	[Token(Token = "0x2000835")]
	public class IngameFancyUI
	{
		// Token: 0x060048BF RID: 18623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048BF")]
		[Address(RVA = "0x5E8760", Offset = "0x5E8760", VA = "0x5E8760")]
		public static void CoverNextFrame()
		{
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x00022AD0 File Offset: 0x00020CD0
		[Token(Token = "0x60048C0")]
		[Address(RVA = "0x5E87B4", Offset = "0x5E87B4", VA = "0x5E87B4")]
		public static bool CanCover()
		{
			return default(bool);
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C1")]
		[Address(RVA = "0x5E8850", Offset = "0x5E8850", VA = "0x5E8850")]
		public static void OpenAchievements()
		{
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C2")]
		[Address(RVA = "0x5E8A5C", Offset = "0x5E8A5C", VA = "0x5E8A5C")]
		public static void OpenAchievementsAndGoto(Achievement achievement)
		{
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C3")]
		[Address(RVA = "0x5E8AF4", Offset = "0x5E8AF4", VA = "0x5E8AF4")]
		private static void ClearChat()
		{
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C4")]
		[Address(RVA = "0x5E8B7C", Offset = "0x5E8B7C", VA = "0x5E8B7C")]
		public static void OpenKeybinds()
		{
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C5")]
		[Address(RVA = "0x5E8B80", Offset = "0x5E8B80", VA = "0x5E8B80")]
		public static void OpenUIState(UIState uiState)
		{
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x00022AE8 File Offset: 0x00020CE8
		[Token(Token = "0x60048C6")]
		[Address(RVA = "0x5E8CF0", Offset = "0x5E8CF0", VA = "0x5E8CF0")]
		public static bool CanShowVirtualKeyboard(int context)
		{
			return default(bool);
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C7")]
		[Address(RVA = "0x5E8D58", Offset = "0x5E8D58", VA = "0x5E8D58")]
		public static void Close(bool quiet = false)
		{
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x00022B00 File Offset: 0x00020D00
		[Token(Token = "0x60048C8")]
		[Address(RVA = "0x5E8FB8", Offset = "0x5E8FB8", VA = "0x5E8FB8")]
		public static bool Draw(SpriteBatch spriteBatch, GameTime gameTime)
		{
			return default(bool);
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C9")]
		[Address(RVA = "0x5E96B4", Offset = "0x5E96B4", VA = "0x5E96B4")]
		public static void MouseOver()
		{
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048CA")]
		[Address(RVA = "0x5E9780", Offset = "0x5E9780", VA = "0x5E9780")]
		public IngameFancyUI()
		{
		}

		// Token: 0x04008EDD RID: 36573
		[Token(Token = "0x4008EDD")]
		[FieldOffset(Offset = "0x0")]
		private static bool CoverForOneUIFrame;
	}
}
