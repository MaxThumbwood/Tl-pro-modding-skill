using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x02000DA3 RID: 3491
	[Token(Token = "0x2000DA3")]
	public class AchievementTagHandler : FileAPI
	{
		// Token: 0x06006703 RID: 26371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006703")]
		[Address(RVA = "0xB69F58", Offset = "0xB69F58", VA = "0xB69F58", Slot = "4")]
		private TextSnippet Terraria.UI.Chat.ITagHandler.Parse(string text, Color baseColor, string options)
		{
			return null;
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006704")]
		[Address(RVA = "0xB6A130", Offset = "0xB6A130", VA = "0xB6A130")]
		public static string GenerateTag(Achievement achievement)
		{
			return null;
		}

		// Token: 0x06006705 RID: 26373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006705")]
		[Address(RVA = "0xB6A1B4", Offset = "0xB6A1B4", VA = "0xB6A1B4")]
		public AchievementTagHandler()
		{
		}

		// Token: 0x02000DA4 RID: 3492
		[Token(Token = "0x2000DA4")]
		private class AchievementSnippet : TextSnippet
		{
			// Token: 0x06006706 RID: 26374 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006706")]
			[Address(RVA = "0xB6A078", Offset = "0xB6A078", VA = "0xB6A078")]
			public AchievementSnippet(Achievement achievement)
			{
			}

			// Token: 0x06006707 RID: 26375 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006707")]
			[Address(RVA = "0xB6A1BC", Offset = "0xB6A1BC", VA = "0xB6A1BC", Slot = "6")]
			public override void OnClick()
			{
			}

			// Token: 0x0400A41F RID: 42015
			[Token(Token = "0x400A41F")]
			[FieldOffset(Offset = "0x1C")]
			private Achievement _achievement;
		}
	}
}
