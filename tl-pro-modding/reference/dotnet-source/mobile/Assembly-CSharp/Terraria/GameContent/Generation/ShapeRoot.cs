using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x02000B0C RID: 2828
	[Token(Token = "0x2000B0C")]
	public class ShapeRoot : GenShape
	{
		// Token: 0x06005825 RID: 22565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005825")]
		[Address(RVA = "0x86221C", Offset = "0x86221C", VA = "0x86221C")]
		public ShapeRoot(double angle, double distance = 10.0, double startingSize = 4.0, double endingSize = 1.0)
		{
		}

		// Token: 0x06005826 RID: 22566 RVA: 0x00028F80 File Offset: 0x00027180
		[Token(Token = "0x6005826")]
		[Address(RVA = "0x862258", Offset = "0x862258", VA = "0x862258")]
		private bool DoRoot(Point origin, GenAction action, double angle, double distance, double startingSize)
		{
			return default(bool);
		}

		// Token: 0x06005827 RID: 22567 RVA: 0x00028F98 File Offset: 0x00027198
		[Token(Token = "0x6005827")]
		[Address(RVA = "0x862684", Offset = "0x862684", VA = "0x862684", Slot = "4")]
		public override bool Perform(Point origin, GenAction action)
		{
			return default(bool);
		}

		// Token: 0x0400997A RID: 39290
		[Token(Token = "0x400997A")]
		[FieldOffset(Offset = "0x10")]
		private double _angle;

		// Token: 0x0400997B RID: 39291
		[Token(Token = "0x400997B")]
		[FieldOffset(Offset = "0x18")]
		private double _startingSize;

		// Token: 0x0400997C RID: 39292
		[Token(Token = "0x400997C")]
		[FieldOffset(Offset = "0x20")]
		private double _endingSize;

		// Token: 0x0400997D RID: 39293
		[Token(Token = "0x400997D")]
		[FieldOffset(Offset = "0x28")]
		private double _distance;
	}
}
