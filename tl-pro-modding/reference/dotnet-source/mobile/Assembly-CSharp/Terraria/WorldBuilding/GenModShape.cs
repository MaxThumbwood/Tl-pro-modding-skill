using System;
using Il2CppDummyDll;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000594 RID: 1428
	[Token(Token = "0x2000594")]
	public abstract class GenModShape : GenShape
	{
		// Token: 0x06003AA4 RID: 15012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AA4")]
		[Address(RVA = "0x1E0567C", Offset = "0x1E0567C", VA = "0x1E0567C")]
		public GenModShape(ShapeData data)
		{
		}

		// Token: 0x0400462F RID: 17967
		[Token(Token = "0x400462F")]
		[FieldOffset(Offset = "0x10")]
		protected ShapeData _data;
	}
}
