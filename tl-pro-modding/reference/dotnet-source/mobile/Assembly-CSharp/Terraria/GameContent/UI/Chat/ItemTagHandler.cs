using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x02000DAB RID: 3499
	[Token(Token = "0x2000DAB")]
	public class ItemTagHandler : FileAPI
	{
		// Token: 0x0600672E RID: 26414 RVA: 0x0002E830 File Offset: 0x0002CA30
		[Token(Token = "0x600672E")]
		[Address(RVA = "0xB6CF8C", Offset = "0xB6CF8C", VA = "0xB6CF8C")]
		public static bool PrintInline(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
		{
			return default(bool);
		}

		// Token: 0x0600672F RID: 26415 RVA: 0x0002E848 File Offset: 0x0002CA48
		[Token(Token = "0x600672F")]
		[Address(RVA = "0xB6D9C8", Offset = "0xB6D9C8", VA = "0xB6D9C8")]
		public static bool MeasureInline(ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
		{
			return default(bool);
		}

		// Token: 0x06006730 RID: 26416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006730")]
		[Address(RVA = "0xB6DF94", Offset = "0xB6DF94", VA = "0xB6DF94", Slot = "4")]
		private TextSnippet Terraria.UI.Chat.ITagHandler.Parse(string text, Color baseColor, string options)
		{
			return null;
		}

		// Token: 0x06006731 RID: 26417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006731")]
		[Address(RVA = "0xB6E4D4", Offset = "0xB6E4D4", VA = "0xB6E4D4")]
		public static string GenerateTag(Item I)
		{
			return null;
		}

		// Token: 0x06006732 RID: 26418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006732")]
		[Address(RVA = "0xB6E674", Offset = "0xB6E674", VA = "0xB6E674")]
		public ItemTagHandler()
		{
		}

		// Token: 0x0400A431 RID: 42033
		[Token(Token = "0x400A431")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Item displayItem;

		// Token: 0x02000DAC RID: 3500
		[Token(Token = "0x2000DAC")]
		private class ItemSnippet : TextSnippet
		{
			// Token: 0x06006734 RID: 26420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006734")]
			[Address(RVA = "0xB6E340", Offset = "0xB6E340", VA = "0xB6E340")]
			public ItemSnippet(Item item)
			{
			}

			// Token: 0x06006735 RID: 26421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006735")]
			[Address(RVA = "0xB6E70C", Offset = "0xB6E70C", VA = "0xB6E70C", Slot = "5")]
			public override void OnHover()
			{
			}

			// Token: 0x06006736 RID: 26422 RVA: 0x0002E860 File Offset: 0x0002CA60
			[Token(Token = "0x6006736")]
			[Address(RVA = "0xB6E814", Offset = "0xB6E814", VA = "0xB6E814", Slot = "8")]
			public override bool UniqueDraw(bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
			{
				return default(bool);
			}

			// Token: 0x06006737 RID: 26423 RVA: 0x0002E878 File Offset: 0x0002CA78
			[Token(Token = "0x6006737")]
			[Address(RVA = "0xB6ECF4", Offset = "0xB6ECF4", VA = "0xB6ECF4", Slot = "10")]
			public override float GetStringLength(SpriteFont font)
			{
				return 0f;
			}

			// Token: 0x0400A432 RID: 42034
			[Token(Token = "0x400A432")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Item _item;
		}
	}
}
