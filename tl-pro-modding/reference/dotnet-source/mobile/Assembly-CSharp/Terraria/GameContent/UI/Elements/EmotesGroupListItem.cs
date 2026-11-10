using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D5A RID: 3418
	[Token(Token = "0x2000D5A")]
	public class EmotesGroupListItem : UIElement
	{
		// Token: 0x06006556 RID: 25942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006556")]
		[Address(RVA = "0xB46A5C", Offset = "0xB46A5C", VA = "0xB46A5C")]
		public EmotesGroupListItem(LocalizedText groupTitle, int groupIndex, int maxEmotesPerRow, int[] emotes)
		{
		}

		// Token: 0x06006557 RID: 25943 RVA: 0x0002E188 File Offset: 0x0002C388
		[Token(Token = "0x6006557")]
		[Address(RVA = "0xB47240", Offset = "0xB47240", VA = "0xB47240", Slot = "29")]
		public override int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0400A2AE RID: 41646
		[Token(Token = "0x400A2AE")]
		private const int TITLE_HEIGHT = 20;

		// Token: 0x0400A2AF RID: 41647
		[Token(Token = "0x400A2AF")]
		private const int SEPARATOR_HEIGHT = 10;

		// Token: 0x0400A2B0 RID: 41648
		[Token(Token = "0x400A2B0")]
		private const int SIZE_PER_EMOTE = 36;

		// Token: 0x0400A2B1 RID: 41649
		[Token(Token = "0x400A2B1")]
		[FieldOffset(Offset = "0xF4")]
		private Asset<Texture2D> _tempTex;

		// Token: 0x0400A2B2 RID: 41650
		[Token(Token = "0x400A2B2")]
		[FieldOffset(Offset = "0xF8")]
		private int _groupIndex;

		// Token: 0x0400A2B3 RID: 41651
		[Token(Token = "0x400A2B3")]
		[FieldOffset(Offset = "0xFC")]
		private int _maxEmotesPerRow;
	}
}
