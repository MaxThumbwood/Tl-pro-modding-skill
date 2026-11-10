using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x02000505 RID: 1285
	[Token(Token = "0x2000505")]
	public struct TileObject
	{
		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600336A RID: 13162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006EF")]
		public static TileObjectPreviewData objectPreview
		{
			[Token(Token = "0x600336A")]
			[Address(RVA = "0x1A163D0", Offset = "0x1A163D0", VA = "0x1A163D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x00019038 File Offset: 0x00017238
		[Token(Token = "0x600336B")]
		[Address(RVA = "0x1A16438", Offset = "0x1A16438", VA = "0x1A16438")]
		public static bool Place(TileObject toBePlaced)
		{
			return default(bool);
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x00019050 File Offset: 0x00017250
		[Token(Token = "0x600336C")]
		[Address(RVA = "0x1A17A80", Offset = "0x1A17A80", VA = "0x1A17A80")]
		public static bool CanPlace(int x, int y, int type, int style, int dir, out TileObject objectData, bool onlyCheck = false, [Optional] int? forcedRandom)
		{
			return default(bool);
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600336D")]
		[Address(RVA = "0x1A1E984", Offset = "0x1A1E984", VA = "0x1A1E984")]
		public static void DrawPreview(SpriteBatch sb, TileObjectPreviewData op, Vector2 position, float opacity)
		{
		}

		// Token: 0x04004335 RID: 17205
		[Token(Token = "0x4004335")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int xCoord;

		// Token: 0x04004336 RID: 17206
		[Token(Token = "0x4004336")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int yCoord;

		// Token: 0x04004337 RID: 17207
		[Token(Token = "0x4004337")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int type;

		// Token: 0x04004338 RID: 17208
		[Token(Token = "0x4004338")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int style;

		// Token: 0x04004339 RID: 17209
		[Token(Token = "0x4004339")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int alternate;

		// Token: 0x0400433A RID: 17210
		[Token(Token = "0x400433A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int random;

		// Token: 0x0400433B RID: 17211
		[Token(Token = "0x400433B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static TileObject Empty;
	}
}
