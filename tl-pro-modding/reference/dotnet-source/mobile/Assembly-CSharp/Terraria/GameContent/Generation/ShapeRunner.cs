using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x02000B0D RID: 2829
	[Token(Token = "0x2000B0D")]
	public class ShapeRunner : GenShape
	{
		// Token: 0x06005828 RID: 22568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005828")]
		[Address(RVA = "0x8626B0", Offset = "0x8626B0", VA = "0x8626B0")]
		public ShapeRunner(double strength, int steps, Vector2D velocity)
		{
		}

		// Token: 0x06005829 RID: 22569 RVA: 0x00028FB0 File Offset: 0x000271B0
		[Token(Token = "0x6005829")]
		[Address(RVA = "0x862700", Offset = "0x862700", VA = "0x862700", Slot = "4")]
		public override bool Perform(Point origin, GenAction action)
		{
			return default(bool);
		}

		// Token: 0x0400997E RID: 39294
		[Token(Token = "0x400997E")]
		[FieldOffset(Offset = "0x10")]
		private double _startStrength;

		// Token: 0x0400997F RID: 39295
		[Token(Token = "0x400997F")]
		[FieldOffset(Offset = "0x18")]
		private int _steps;

		// Token: 0x04009980 RID: 39296
		[Token(Token = "0x4009980")]
		[FieldOffset(Offset = "0x20")]
		private Vector2D _startVelocity;
	}
}
