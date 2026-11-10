using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x020007C4 RID: 1988
	[Token(Token = "0x20007C4")]
	public struct SpriteFrame
	{
		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06004487 RID: 17543 RVA: 0x00020CA0 File Offset: 0x0001EEA0
		// (set) Token: 0x06004488 RID: 17544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700083B")]
		public byte CurrentColumn
		{
			[Token(Token = "0x6004487")]
			[Address(RVA = "0x559F48", Offset = "0x559F48", VA = "0x559F48")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004488")]
			[Address(RVA = "0x559F50", Offset = "0x559F50", VA = "0x559F50")]
			set
			{
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06004489 RID: 17545 RVA: 0x00020CB8 File Offset: 0x0001EEB8
		// (set) Token: 0x0600448A RID: 17546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700083C")]
		public byte CurrentRow
		{
			[Token(Token = "0x6004489")]
			[Address(RVA = "0x559F58", Offset = "0x559F58", VA = "0x559F58")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600448A")]
			[Address(RVA = "0x559F60", Offset = "0x559F60", VA = "0x559F60")]
			set
			{
			}
		}

		// Token: 0x0600448B RID: 17547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600448B")]
		[Address(RVA = "0x559F68", Offset = "0x559F68", VA = "0x559F68")]
		public SpriteFrame(byte columns, byte rows)
		{
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600448C")]
		[Address(RVA = "0x559F88", Offset = "0x559F88", VA = "0x559F88")]
		public SpriteFrame(byte columns, byte rows, byte currentColumn, byte currentRow)
		{
		}

		// Token: 0x0600448D RID: 17549 RVA: 0x00020CD0 File Offset: 0x0001EED0
		[Token(Token = "0x600448D")]
		[Address(RVA = "0x559FAC", Offset = "0x559FAC", VA = "0x559FAC")]
		public SpriteFrame With(byte columnToUse, byte rowToUse)
		{
			return default(SpriteFrame);
		}

		// Token: 0x0600448E RID: 17550 RVA: 0x00020CE8 File Offset: 0x0001EEE8
		[Token(Token = "0x600448E")]
		[Address(RVA = "0x559FCC", Offset = "0x559FCC", VA = "0x559FCC")]
		public Rectangle GetSourceRectangle(Texture2D texture)
		{
			return default(Rectangle);
		}

		// Token: 0x04008BFC RID: 35836
		[Token(Token = "0x4008BFC")]
		[FieldOffset(Offset = "0x0")]
		public int PaddingX;

		// Token: 0x04008BFD RID: 35837
		[Token(Token = "0x4008BFD")]
		[FieldOffset(Offset = "0x4")]
		public int PaddingY;

		// Token: 0x04008BFE RID: 35838
		[Token(Token = "0x4008BFE")]
		[FieldOffset(Offset = "0x8")]
		private byte _currentColumn;

		// Token: 0x04008BFF RID: 35839
		[Token(Token = "0x4008BFF")]
		[FieldOffset(Offset = "0x9")]
		private byte _currentRow;

		// Token: 0x04008C00 RID: 35840
		[Token(Token = "0x4008C00")]
		[FieldOffset(Offset = "0xA")]
		public readonly byte ColumnCount;

		// Token: 0x04008C01 RID: 35841
		[Token(Token = "0x4008C01")]
		[FieldOffset(Offset = "0xB")]
		public readonly byte RowCount;
	}
}
