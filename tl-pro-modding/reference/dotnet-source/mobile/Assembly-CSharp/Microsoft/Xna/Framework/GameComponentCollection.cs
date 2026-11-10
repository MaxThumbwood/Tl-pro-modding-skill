using System;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework
{
	// Token: 0x020003A6 RID: 934
	[Token(Token = "0x20003A6")]
	public sealed class GameComponentCollection : Collection<IGameComponent>
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600189F RID: 6303 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060018A0 RID: 6304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000C")]
		public event EventHandler<GameComponentCollectionEventArgs> ComponentAdded
		{
			[Token(Token = "0x600189F")]
			[Address(RVA = "0xE20EEC", Offset = "0xE20EEC", VA = "0xE20EEC")]
			add
			{
			}
			[Token(Token = "0x60018A0")]
			[Address(RVA = "0xE20FB4", Offset = "0xE20FB4", VA = "0xE20FB4")]
			remove
			{
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060018A1 RID: 6305 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060018A2 RID: 6306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000D")]
		public event EventHandler<GameComponentCollectionEventArgs> ComponentRemoved
		{
			[Token(Token = "0x60018A1")]
			[Address(RVA = "0xE2107C", Offset = "0xE2107C", VA = "0xE2107C")]
			add
			{
			}
			[Token(Token = "0x60018A2")]
			[Address(RVA = "0xE21144", Offset = "0xE21144", VA = "0xE21144")]
			remove
			{
			}
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A3")]
		[Address(RVA = "0xE2120C", Offset = "0xE2120C", VA = "0xE2120C", Slot = "35")]
		protected override void ClearItems()
		{
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A4")]
		[Address(RVA = "0xE21370", Offset = "0xE21370", VA = "0xE21370", Slot = "36")]
		protected override void InsertItem(int index, IGameComponent item)
		{
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A5")]
		[Address(RVA = "0xE214D8", Offset = "0xE214D8", VA = "0xE214D8")]
		private void OnComponentAdded(GameComponentCollectionEventArgs eventArgs)
		{
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A6")]
		[Address(RVA = "0xE2134C", Offset = "0xE2134C", VA = "0xE2134C")]
		private void OnComponentRemoved(GameComponentCollectionEventArgs eventArgs)
		{
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A7")]
		[Address(RVA = "0xE214FC", Offset = "0xE214FC", VA = "0xE214FC", Slot = "37")]
		protected override void RemoveItem(int index)
		{
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A8")]
		[Address(RVA = "0xE215FC", Offset = "0xE215FC", VA = "0xE215FC", Slot = "38")]
		protected override void SetItem(int index, IGameComponent item)
		{
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A9")]
		[Address(RVA = "0xE1E5C0", Offset = "0xE1E5C0", VA = "0xE1E5C0")]
		public GameComponentCollection()
		{
		}
	}
}
