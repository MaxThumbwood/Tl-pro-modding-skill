using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D8E RID: 3470
	[Token(Token = "0x2000D8E")]
	public class UIList : UIElement, FileAPI, GUIControllerItem
	{
		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06006666 RID: 26214 RVA: 0x0002E4D0 File Offset: 0x0002C6D0
		[Token(Token = "0x17000AF4")]
		public int Count
		{
			[Token(Token = "0x6006666")]
			[Address(RVA = "0xB614D8", Offset = "0xB614D8", VA = "0xB614D8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06006667 RID: 26215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006667")]
		[Address(RVA = "0xB61530", Offset = "0xB61530", VA = "0xB61530")]
		public UIList()
		{
		}

		// Token: 0x06006668 RID: 26216 RVA: 0x0002E4E8 File Offset: 0x0002C6E8
		[Token(Token = "0x6006668")]
		[Address(RVA = "0xB617B0", Offset = "0xB617B0", VA = "0xB617B0")]
		public float GetTotalHeight()
		{
			return 0f;
		}

		// Token: 0x06006669 RID: 26217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006669")]
		[Address(RVA = "0xB617B8", Offset = "0xB617B8", VA = "0xB617B8")]
		public void Goto(UIList.ElementSearchMethod searchMethod)
		{
		}

		// Token: 0x0600666A RID: 26218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600666A")]
		[Address(RVA = "0xB61930", Offset = "0xB61930", VA = "0xB61930", Slot = "32")]
		public virtual void Add(UIElement item)
		{
		}

		// Token: 0x0600666B RID: 26219 RVA: 0x0002E500 File Offset: 0x0002C700
		[Token(Token = "0x600666B")]
		[Address(RVA = "0xB61B80", Offset = "0xB61B80", VA = "0xB61B80", Slot = "33")]
		public virtual bool Remove(UIElement item)
		{
			return default(bool);
		}

		// Token: 0x0600666C RID: 26220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600666C")]
		[Address(RVA = "0xB61C14", Offset = "0xB61C14", VA = "0xB61C14", Slot = "34")]
		public virtual void Clear()
		{
		}

		// Token: 0x0600666D RID: 26221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600666D")]
		[Address(RVA = "0xB61CB0", Offset = "0xB61CB0", VA = "0xB61CB0", Slot = "11")]
		public override void Recalculate()
		{
		}

		// Token: 0x0600666E RID: 26222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600666E")]
		[Address(RVA = "0xB61D7C", Offset = "0xB61D7C", VA = "0xB61D7C", Slot = "25")]
		public override void ScrollWheel(UIScrollWheelEvent evt)
		{
		}

		// Token: 0x0600666F RID: 26223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600666F")]
		[Address(RVA = "0xB61DE8", Offset = "0xB61DE8", VA = "0xB61DE8", Slot = "14")]
		public override void RecalculateChildren()
		{
		}

		// Token: 0x06006670 RID: 26224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006670")]
		[Address(RVA = "0xB61D1C", Offset = "0xB61D1C", VA = "0xB61D1C")]
		private void UpdateScrollbar()
		{
		}

		// Token: 0x06006671 RID: 26225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006671")]
		[Address(RVA = "0xB61FF8", Offset = "0xB61FF8", VA = "0xB61FF8")]
		public void SetScrollbar(UIScrollbar scrollbar)
		{
		}

		// Token: 0x06006672 RID: 26226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006672")]
		[Address(RVA = "0xB61A38", Offset = "0xB61A38", VA = "0xB61A38")]
		public void UpdateOrder()
		{
		}

		// Token: 0x06006673 RID: 26227 RVA: 0x0002E518 File Offset: 0x0002C718
		[Token(Token = "0x6006673")]
		[Address(RVA = "0xB6205C", Offset = "0xB6205C", VA = "0xB6205C")]
		public int SortMethod(UIElement item1, UIElement item2)
		{
			return 0;
		}

		// Token: 0x06006674 RID: 26228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006674")]
		[Address(RVA = "0xB62090", Offset = "0xB62090", VA = "0xB62090", Slot = "10")]
		public override List<SnapPoint> GetSnapPoints()
		{
			return null;
		}

		// Token: 0x06006675 RID: 26229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006675")]
		[Address(RVA = "0xB6237C", Offset = "0xB6237C", VA = "0xB6237C", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006676 RID: 26230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006676")]
		[Address(RVA = "0xB62440", Offset = "0xB62440", VA = "0xB62440", Slot = "30")]
		public IEnumerator<UIElement> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06006677 RID: 26231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006677")]
		[Address(RVA = "0xB624F8", Offset = "0xB624F8", VA = "0xB624F8", Slot = "31")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400A3A7 RID: 41895
		[Token(Token = "0x400A3A7")]
		[FieldOffset(Offset = "0xF4")]
		protected List<UIElement> _items;

		// Token: 0x0400A3A8 RID: 41896
		[Token(Token = "0x400A3A8")]
		[FieldOffset(Offset = "0xF8")]
		protected UIScrollbar _scrollbar;

		// Token: 0x0400A3A9 RID: 41897
		[Token(Token = "0x400A3A9")]
		[FieldOffset(Offset = "0xFC")]
		private UIElement _innerList;

		// Token: 0x0400A3AA RID: 41898
		[Token(Token = "0x400A3AA")]
		[FieldOffset(Offset = "0x100")]
		private float _innerListHeight;

		// Token: 0x0400A3AB RID: 41899
		[Token(Token = "0x400A3AB")]
		[FieldOffset(Offset = "0x104")]
		public float ListPadding;

		// Token: 0x0400A3AC RID: 41900
		[Token(Token = "0x400A3AC")]
		[FieldOffset(Offset = "0x108")]
		public Action<List<UIElement>> ManualSortMethod;

		// Token: 0x02000D8F RID: 3471
		// (Invoke) Token: 0x06006679 RID: 26233
		[Token(Token = "0x2000D8F")]
		public delegate bool ElementSearchMethod(UIElement element);

		// Token: 0x02000D90 RID: 3472
		[Token(Token = "0x2000D90")]
		private class UIInnerList : UIElement
		{
			// Token: 0x0600667C RID: 26236 RVA: 0x0002E530 File Offset: 0x0002C730
			[Token(Token = "0x600667C")]
			[Address(RVA = "0xB62774", Offset = "0xB62774", VA = "0xB62774", Slot = "12")]
			public override bool ContainsPoint(Vector2 point)
			{
				return default(bool);
			}

			// Token: 0x0600667D RID: 26237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600667D")]
			[Address(RVA = "0xB6277C", Offset = "0xB6277C", VA = "0xB6277C", Slot = "7")]
			protected override void DrawChildren(SpriteBatch spriteBatch)
			{
			}

			// Token: 0x0600667E RID: 26238 RVA: 0x0002E548 File Offset: 0x0002C748
			[Token(Token = "0x600667E")]
			[Address(RVA = "0xB62AE8", Offset = "0xB62AE8", VA = "0xB62AE8", Slot = "13")]
			public override Rectangle GetViewCullingArea()
			{
				return default(Rectangle);
			}

			// Token: 0x0600667F RID: 26239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600667F")]
			[Address(RVA = "0xB61748", Offset = "0xB61748", VA = "0xB61748")]
			public UIInnerList()
			{
			}
		}
	}
}
