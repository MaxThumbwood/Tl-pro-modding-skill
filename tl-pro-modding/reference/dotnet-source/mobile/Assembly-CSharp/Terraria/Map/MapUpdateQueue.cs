using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.Map
{
	// Token: 0x02000814 RID: 2068
	[Token(Token = "0x2000814")]
	public class MapUpdateQueue
	{
		// Token: 0x060046BA RID: 18106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BA")]
		[Address(RVA = "0x5A125C", Offset = "0x5A125C", VA = "0x5A125C")]
		public static void Add(Rectangle area)
		{
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BB")]
		[Address(RVA = "0x5A1644", Offset = "0x5A1644", VA = "0x5A1644")]
		public static void Add(int x, int y)
		{
		}

		// Token: 0x060046BC RID: 18108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BC")]
		[Address(RVA = "0x5A16B8", Offset = "0x5A16B8", VA = "0x5A16B8")]
		public MapUpdateQueue()
		{
		}

		// Token: 0x04008DA1 RID: 36257
		[Token(Token = "0x4008DA1")]
		private const int MAX_QUEUED_UPDATES = 262144;

		// Token: 0x04008DA2 RID: 36258
		[Token(Token = "0x4008DA2")]
		[FieldOffset(Offset = "0x0")]
		private static List<Rectangle> _areaUpdateQueue;

		// Token: 0x04008DA3 RID: 36259
		[Token(Token = "0x4008DA3")]
		[FieldOffset(Offset = "0x4")]
		private static Point16[] _updateQueue;

		// Token: 0x04008DA4 RID: 36260
		[Token(Token = "0x4008DA4")]
		[FieldOffset(Offset = "0x8")]
		private static int _updateCount;

		// Token: 0x04008DA5 RID: 36261
		[Token(Token = "0x4008DA5")]
		[FieldOffset(Offset = "0xC")]
		private static readonly object _lock;
	}
}
