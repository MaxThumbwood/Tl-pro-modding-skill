using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x02000B05 RID: 2821
	[Token(Token = "0x2000B05")]
	public class ActionVines : GenAction
	{
		// Token: 0x0600580F RID: 22543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600580F")]
		[Address(RVA = "0x85CB2C", Offset = "0x85CB2C", VA = "0x85CB2C")]
		public ActionVines(int minLength = 6, int maxLength = 10, int vineId = 52)
		{
		}

		// Token: 0x06005810 RID: 22544 RVA: 0x00028EF0 File Offset: 0x000270F0
		[Token(Token = "0x6005810")]
		[Address(RVA = "0x85CB58", Offset = "0x85CB58", VA = "0x85CB58", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, object[] args)
		{
			return default(bool);
		}

		// Token: 0x0400996A RID: 39274
		[Token(Token = "0x400996A")]
		[FieldOffset(Offset = "0x14")]
		private int _minLength;

		// Token: 0x0400996B RID: 39275
		[Token(Token = "0x400996B")]
		[FieldOffset(Offset = "0x18")]
		private int _maxLength;

		// Token: 0x0400996C RID: 39276
		[Token(Token = "0x400996C")]
		[FieldOffset(Offset = "0x1C")]
		private int _vineId;
	}
}
