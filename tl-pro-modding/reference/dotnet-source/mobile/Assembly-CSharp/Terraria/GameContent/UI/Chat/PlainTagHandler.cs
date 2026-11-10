using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x02000DAE RID: 3502
	[Token(Token = "0x2000DAE")]
	public class PlainTagHandler : FileAPI
	{
		// Token: 0x0600673B RID: 26427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673B")]
		[Address(RVA = "0xB6EFA8", Offset = "0xB6EFA8", VA = "0xB6EFA8", Slot = "4")]
		private TextSnippet Terraria.UI.Chat.ITagHandler.Parse(string text, Color baseColor, string options)
		{
			return null;
		}

		// Token: 0x0600673C RID: 26428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600673C")]
		[Address(RVA = "0xB6F024", Offset = "0xB6F024", VA = "0xB6F024")]
		public PlainTagHandler()
		{
		}

		// Token: 0x02000DAF RID: 3503
		[Token(Token = "0x2000DAF")]
		public class PlainSnippet : TextSnippet
		{
			// Token: 0x0600673D RID: 26429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600673D")]
			[Address(RVA = "0xB6F01C", Offset = "0xB6F01C", VA = "0xB6F01C")]
			public PlainSnippet(string text = "")
			{
			}

			// Token: 0x0600673E RID: 26430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600673E")]
			[Address(RVA = "0xB6F02C", Offset = "0xB6F02C", VA = "0xB6F02C")]
			public PlainSnippet(string text, Color color, float scale)
			{
			}

			// Token: 0x0600673F RID: 26431 RVA: 0x0002E890 File Offset: 0x0002CA90
			[Token(Token = "0x600673F")]
			[Address(RVA = "0xB6F048", Offset = "0xB6F048", VA = "0xB6F048", Slot = "7")]
			public override Color GetVisibleColor()
			{
				return default(Color);
			}
		}
	}
}
