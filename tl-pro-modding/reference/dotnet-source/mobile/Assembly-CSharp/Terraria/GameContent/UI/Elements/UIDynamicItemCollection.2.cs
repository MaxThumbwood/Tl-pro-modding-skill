using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D7F RID: 3455
	[Token(Token = "0x2000D7F")]
	public abstract class UIDynamicItemCollection<TEntry> : UIDynamicItemCollection
	{
		// Token: 0x0600661E RID: 26142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600661E")]
		public UIDynamicItemCollection()
		{
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x0600661F RID: 26143 RVA: 0x0002E440 File Offset: 0x0002C640
		[Token(Token = "0x17000AEF")]
		public int Count
		{
			[Token(Token = "0x600661F")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06006620 RID: 26144
		[Token(Token = "0x6006620")]
		protected abstract Item GetItem(TEntry entry);

		// Token: 0x06006621 RID: 26145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006621")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006622 RID: 26146
		[Token(Token = "0x6006622")]
		protected abstract void DrawSlot(SpriteBatch spriteBatch, TEntry entry, Vector2 pos, bool hovering);

		// Token: 0x06006623 RID: 26147 RVA: 0x0002E458 File Offset: 0x0002C658
		[Token(Token = "0x6006623")]
		private Rectangle GetItemSlotHitbox(int startX, int startY, int startItemIndex, int i)
		{
			return default(Rectangle);
		}

		// Token: 0x06006624 RID: 26148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006624")]
		private void GetGridParameters(out int startX, out int startY, out int startItemIndex, out int endItemIndex)
		{
		}

		// Token: 0x06006625 RID: 26149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006625")]
		public override void Recalculate()
		{
		}

		// Token: 0x06006626 RID: 26150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006626")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06006627 RID: 26151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006627")]
		public void SetContentsToShow(List<TEntry> itemsToShow)
		{
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x0002E470 File Offset: 0x0002C670
		[Token(Token = "0x6006628")]
		public int GetItemsPerLine()
		{
			return 0;
		}

		// Token: 0x06006629 RID: 26153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006629")]
		public override List<SnapPoint> GetSnapPoints()
		{
			return null;
		}

		// Token: 0x0600662A RID: 26154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600662A")]
		public void UpdateSize()
		{
		}

		// Token: 0x0400A366 RID: 41830
		[Token(Token = "0x400A366")]
		[FieldOffset(Offset = "0x0")]
		private List<TEntry> _contents;

		// Token: 0x0400A367 RID: 41831
		[Token(Token = "0x400A367")]
		[FieldOffset(Offset = "0x0")]
		private int _itemsPerLine;

		// Token: 0x0400A368 RID: 41832
		[Token(Token = "0x400A368")]
		private const int sizePerEntryX = 44;

		// Token: 0x0400A369 RID: 41833
		[Token(Token = "0x400A369")]
		private const int sizePerEntryY = 44;

		// Token: 0x0400A36A RID: 41834
		[Token(Token = "0x400A36A")]
		[FieldOffset(Offset = "0x0")]
		private List<SnapPoint> _dummySnapPoints;
	}
}
