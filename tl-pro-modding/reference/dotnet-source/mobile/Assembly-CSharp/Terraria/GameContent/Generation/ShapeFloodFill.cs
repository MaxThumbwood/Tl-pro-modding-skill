using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x02000B0B RID: 2827
	[Token(Token = "0x2000B0B")]
	public class ShapeFloodFill : GenShape
	{
		// Token: 0x06005822 RID: 22562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005822")]
		[Address(RVA = "0x8615B4", Offset = "0x8615B4", VA = "0x8615B4")]
		public ShapeFloodFill(int maximumActions = 100)
		{
		}

		// Token: 0x06005823 RID: 22563 RVA: 0x00028F68 File Offset: 0x00027168
		[Token(Token = "0x6005823")]
		[Address(RVA = "0x8615D0", Offset = "0x8615D0", VA = "0x8615D0", Slot = "4")]
		public override bool Perform(Point origin, GenAction action)
		{
			return default(bool);
		}

		// Token: 0x04009978 RID: 39288
		[Token(Token = "0x4009978")]
		[FieldOffset(Offset = "0x10")]
		private int _maximumActions;

		// Token: 0x04009979 RID: 39289
		[Token(Token = "0x4009979")]
		[FieldOffset(Offset = "0x0")]
		private static Queue<Point> checkQueue;
	}
}
