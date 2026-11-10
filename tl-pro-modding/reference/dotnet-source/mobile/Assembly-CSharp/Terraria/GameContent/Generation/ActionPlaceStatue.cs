using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x02000B03 RID: 2819
	[Token(Token = "0x2000B03")]
	public class ActionPlaceStatue : GenAction
	{
		// Token: 0x0600580B RID: 22539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600580B")]
		[Address(RVA = "0x85C8DC", Offset = "0x85C8DC", VA = "0x85C8DC")]
		public ActionPlaceStatue(int index = -1)
		{
		}

		// Token: 0x0600580C RID: 22540 RVA: 0x00028EC0 File Offset: 0x000270C0
		[Token(Token = "0x600580C")]
		[Address(RVA = "0x85C8F8", Offset = "0x85C8F8", VA = "0x85C8F8", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, object[] args)
		{
			return default(bool);
		}

		// Token: 0x04009969 RID: 39273
		[Token(Token = "0x4009969")]
		[FieldOffset(Offset = "0x14")]
		private int _statueIndex;
	}
}
