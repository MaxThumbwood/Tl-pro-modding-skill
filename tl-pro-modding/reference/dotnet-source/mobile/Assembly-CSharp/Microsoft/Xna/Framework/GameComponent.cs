using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework
{
	// Token: 0x020003A5 RID: 933
	[Token(Token = "0x20003A5")]
	public class GameComponent : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600188D RID: 6285 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600188E RID: 6286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000A")]
		public event EventHandler<EventArgs> UpdateOrderChanged
		{
			[Token(Token = "0x600188D")]
			[Address(RVA = "0xE20880", Offset = "0xE20880", VA = "0xE20880", Slot = "8")]
			add
			{
			}
			[Token(Token = "0x600188E")]
			[Address(RVA = "0xE20948", Offset = "0xE20948", VA = "0xE20948", Slot = "9")]
			remove
			{
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600188F RID: 6287 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001890 RID: 6288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000B")]
		public event EventHandler<EventArgs> EnabledChanged
		{
			[Token(Token = "0x600188F")]
			[Address(RVA = "0xE20A10", Offset = "0xE20A10", VA = "0xE20A10", Slot = "6")]
			add
			{
			}
			[Token(Token = "0x6001890")]
			[Address(RVA = "0xE20AD8", Offset = "0xE20AD8", VA = "0xE20AD8", Slot = "7")]
			remove
			{
			}
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001891")]
		[Address(RVA = "0xE20BA0", Offset = "0xE20BA0", VA = "0xE20BA0")]
		public GameComponent(Game game)
		{
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000263")]
		public Game Game
		{
			[Token(Token = "0x6001892")]
			[Address(RVA = "0xE20D20", Offset = "0xE20D20", VA = "0xE20D20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001893")]
		[Address(RVA = "0xE20D28", Offset = "0xE20D28", VA = "0xE20D28", Slot = "13")]
		public virtual void Initialize()
		{
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001894")]
		[Address(RVA = "0xE20D2C", Offset = "0xE20D2C", VA = "0xE20D2C", Slot = "14")]
		public virtual void Update(GameTime gameTime)
		{
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000264")]
		public GraphicsDevice GraphicsDevice
		{
			[Token(Token = "0x6001895")]
			[Address(RVA = "0xE20D30", Offset = "0xE20D30", VA = "0xE20D30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x0000B940 File Offset: 0x00009B40
		// (set) Token: 0x06001897 RID: 6295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000265")]
		public bool Enabled
		{
			[Token(Token = "0x6001896")]
			[Address(RVA = "0xE20DC4", Offset = "0xE20DC4", VA = "0xE20DC4", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001897")]
			[Address(RVA = "0xE20C68", Offset = "0xE20C68", VA = "0xE20C68")]
			set
			{
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x0000B958 File Offset: 0x00009B58
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000266")]
		public int UpdateOrder
		{
			[Token(Token = "0x6001898")]
			[Address(RVA = "0xE20DF8", Offset = "0xE20DF8", VA = "0xE20DF8", Slot = "11")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001899")]
			[Address(RVA = "0xE20E00", Offset = "0xE20E00", VA = "0xE20E00")]
			set
			{
			}
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600189A")]
		[Address(RVA = "0xE20DCC", Offset = "0xE20DCC", VA = "0xE20DCC")]
		private void Raise(EventHandler<EventArgs> handler, EventArgs e)
		{
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600189B")]
		[Address(RVA = "0xE20EB8", Offset = "0xE20EB8", VA = "0xE20EB8", Slot = "15")]
		protected virtual void OnUpdateOrderChanged(object sender, EventArgs args)
		{
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600189C")]
		[Address(RVA = "0xE20EBC", Offset = "0xE20EBC", VA = "0xE20EBC", Slot = "16")]
		protected virtual void OnEnabledChanged(object sender, EventArgs args)
		{
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600189D")]
		[Address(RVA = "0xE20EC0", Offset = "0xE20EC0", VA = "0xE20EC0")]
		public void Dispose()
		{
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x0000B970 File Offset: 0x00009B70
		[Token(Token = "0x600189E")]
		[Address(RVA = "0xE20EC4", Offset = "0xE20EC4", VA = "0xE20EC4", Slot = "12")]
		public int CompareTo(GameComponent other)
		{
			return 0;
		}

		// Token: 0x04002B5C RID: 11100
		[Token(Token = "0x4002B5C")]
		[FieldOffset(Offset = "0x8")]
		private Game _game;

		// Token: 0x04002B5D RID: 11101
		[Token(Token = "0x4002B5D")]
		[FieldOffset(Offset = "0xC")]
		private int _updateOrder;

		// Token: 0x04002B5E RID: 11102
		[Token(Token = "0x4002B5E")]
		[FieldOffset(Offset = "0x10")]
		private bool _enabled;
	}
}
