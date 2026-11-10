using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D89 RID: 3465
	[Token(Token = "0x2000D89")]
	public class UIItemSlot : UIElement
	{
		// Token: 0x06006658 RID: 26200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006658")]
		[Address(RVA = "0xB5FFA8", Offset = "0xB5FFA8", VA = "0xB5FFA8")]
		public UIItemSlot(Item[] itemArray, int itemIndex, int itemSlotContext)
		{
		}

		// Token: 0x06006659 RID: 26201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006659")]
		[Address(RVA = "0xB60090", Offset = "0xB60090", VA = "0xB60090")]
		private void HandleItemSlotLogic()
		{
		}

		// Token: 0x0600665A RID: 26202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600665A")]
		[Address(RVA = "0xB6016C", Offset = "0xB6016C", VA = "0xB6016C", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0400A399 RID: 41881
		[Token(Token = "0x400A399")]
		[FieldOffset(Offset = "0xF4")]
		private Item[] _itemArray;

		// Token: 0x0400A39A RID: 41882
		[Token(Token = "0x400A39A")]
		[FieldOffset(Offset = "0xF8")]
		private int _itemIndex;

		// Token: 0x0400A39B RID: 41883
		[Token(Token = "0x400A39B")]
		[FieldOffset(Offset = "0xFC")]
		private int _itemSlotContext;
	}
}
