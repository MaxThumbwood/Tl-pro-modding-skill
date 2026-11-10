using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003F8 RID: 1016
	[Token(Token = "0x20003F8")]
	public abstract class GraphicsResource
	{
		// Token: 0x06001BED RID: 7149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BED")]
		[Address(RVA = "0xE844EC", Offset = "0xE844EC", VA = "0xE844EC")]
		internal GraphicsResource()
		{
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEE")]
		[Address(RVA = "0xE844F4", Offset = "0xE844F4", VA = "0xE844F4")]
		public void Dispose()
		{
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEF")]
		[Address(RVA = "0xE844F8", Offset = "0xE844F8", VA = "0xE844F8", Slot = "4")]
		protected internal virtual void GraphicsDeviceResetting()
		{
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06001BF0 RID: 7152 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001BF1 RID: 7153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000019")]
		public event EventHandler<EventArgs> Disposing
		{
			[Token(Token = "0x6001BF0")]
			[Address(RVA = "0xE844FC", Offset = "0xE844FC", VA = "0xE844FC")]
			add
			{
			}
			[Token(Token = "0x6001BF1")]
			[Address(RVA = "0xE845C4", Offset = "0xE845C4", VA = "0xE845C4")]
			remove
			{
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000341")]
		public GraphicsDevice GraphicsDevice
		{
			[Token(Token = "0x6001BF2")]
			[Address(RVA = "0xE8468C", Offset = "0xE8468C", VA = "0xE8468C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BF3")]
			[Address(RVA = "0xE84694", Offset = "0xE84694", VA = "0xE84694")]
			internal set
			{
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BF5 RID: 7157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000342")]
		public string Name
		{
			[Token(Token = "0x6001BF4")]
			[Address(RVA = "0xE846A4", Offset = "0xE846A4", VA = "0xE846A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BF5")]
			[Address(RVA = "0xE846AC", Offset = "0xE846AC", VA = "0xE846AC")]
			set
			{
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BF7 RID: 7159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000343")]
		public object Tag
		{
			[Token(Token = "0x6001BF6")]
			[Address(RVA = "0xE846B4", Offset = "0xE846B4", VA = "0xE846B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BF7")]
			[Address(RVA = "0xE846BC", Offset = "0xE846BC", VA = "0xE846BC")]
			set
			{
			}
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF8")]
		[Address(RVA = "0xE846C4", Offset = "0xE846C4", VA = "0xE846C4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04002FBA RID: 12218
		[Token(Token = "0x4002FBA")]
		[FieldOffset(Offset = "0x8")]
		private GraphicsDevice graphicsDevice;

		// Token: 0x04002FBC RID: 12220
		[Token(Token = "0x4002FBC")]
		[FieldOffset(Offset = "0x10")]
		private string <Name>k__BackingField;

		// Token: 0x04002FBD RID: 12221
		[Token(Token = "0x4002FBD")]
		[FieldOffset(Offset = "0x14")]
		private object <Tag>k__BackingField;
	}
}
