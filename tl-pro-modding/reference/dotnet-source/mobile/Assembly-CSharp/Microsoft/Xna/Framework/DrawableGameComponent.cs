using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200038A RID: 906
	[Token(Token = "0x200038A")]
	public class DrawableGameComponent : GameComponent, FileAPI
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06001652 RID: 5714 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001653 RID: 5715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000006")]
		public event EventHandler<EventArgs> DrawOrderChanged
		{
			[Token(Token = "0x6001652")]
			[Address(RVA = "0xE0CEAC", Offset = "0xE0CEAC", VA = "0xE0CEAC", Slot = "19")]
			add
			{
			}
			[Token(Token = "0x6001653")]
			[Address(RVA = "0xE0CF74", Offset = "0xE0CF74", VA = "0xE0CF74", Slot = "20")]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06001654 RID: 5716 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001655 RID: 5717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000007")]
		public event EventHandler<EventArgs> VisibleChanged
		{
			[Token(Token = "0x6001654")]
			[Address(RVA = "0xE0D03C", Offset = "0xE0D03C", VA = "0xE0D03C", Slot = "21")]
			add
			{
			}
			[Token(Token = "0x6001655")]
			[Address(RVA = "0xE0D104", Offset = "0xE0D104", VA = "0xE0D104", Slot = "22")]
			remove
			{
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001656")]
		[Address(RVA = "0xE0D1CC", Offset = "0xE0D1CC", VA = "0xE0D1CC")]
		public DrawableGameComponent(Game game)
		{
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001657")]
		[Address(RVA = "0xE0D2CC", Offset = "0xE0D2CC", VA = "0xE0D2CC", Slot = "13")]
		public override void Initialize()
		{
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001658")]
		[Address(RVA = "0xE0D2F0", Offset = "0xE0D2F0", VA = "0xE0D2F0", Slot = "24")]
		protected virtual void LoadContent()
		{
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001659")]
		[Address(RVA = "0xE0D2F4", Offset = "0xE0D2F4", VA = "0xE0D2F4", Slot = "25")]
		protected virtual void UnloadContent()
		{
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x00009E70 File Offset: 0x00008070
		// (set) Token: 0x0600165B RID: 5723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000223")]
		public int DrawOrder
		{
			[Token(Token = "0x600165A")]
			[Address(RVA = "0xE0D2F8", Offset = "0xE0D2F8", VA = "0xE0D2F8", Slot = "17")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600165B")]
			[Address(RVA = "0xE0D300", Offset = "0xE0D300", VA = "0xE0D300")]
			set
			{
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x00009E88 File Offset: 0x00008088
		// (set) Token: 0x0600165D RID: 5725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000224")]
		public bool Visible
		{
			[Token(Token = "0x600165C")]
			[Address(RVA = "0xE0D350", Offset = "0xE0D350", VA = "0xE0D350", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600165D")]
			[Address(RVA = "0xE0D1EC", Offset = "0xE0D1EC", VA = "0xE0D1EC")]
			set
			{
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165E")]
		[Address(RVA = "0xE0D358", Offset = "0xE0D358", VA = "0xE0D358", Slot = "26")]
		public virtual void Draw(GameTime gameTime)
		{
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165F")]
		[Address(RVA = "0xE0D35C", Offset = "0xE0D35C", VA = "0xE0D35C", Slot = "27")]
		protected virtual void OnVisibleChanged(object sender, EventArgs args)
		{
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001660")]
		[Address(RVA = "0xE0D360", Offset = "0xE0D360", VA = "0xE0D360", Slot = "28")]
		protected virtual void OnDrawOrderChanged(object sender, EventArgs args)
		{
		}

		// Token: 0x04002AB6 RID: 10934
		[Token(Token = "0x4002AB6")]
		[FieldOffset(Offset = "0x1C")]
		private bool _isInitialized;

		// Token: 0x04002AB7 RID: 10935
		[Token(Token = "0x4002AB7")]
		[FieldOffset(Offset = "0x1D")]
		private bool _isVisible;

		// Token: 0x04002AB8 RID: 10936
		[Token(Token = "0x4002AB8")]
		[FieldOffset(Offset = "0x20")]
		private int _drawOrder;
	}
}
