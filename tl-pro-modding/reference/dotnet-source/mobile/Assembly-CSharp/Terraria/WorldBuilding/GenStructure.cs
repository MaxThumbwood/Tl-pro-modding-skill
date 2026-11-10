using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x020005AF RID: 1455
	[Token(Token = "0x20005AF")]
	public abstract class GenStructure : GenBase
	{
		// Token: 0x06003AF0 RID: 15088 RVA: 0x0001DB20 File Offset: 0x0001BD20
		[Token(Token = "0x6003AF0")]
		[Address(RVA = "0x1E08C6C", Offset = "0x1E08C6C", VA = "0x1E08C6C", Slot = "4")]
		public virtual bool Place(Point origin, StructureMap structures)
		{
			return default(bool);
		}

		// Token: 0x06003AF1 RID: 15089
		[Token(Token = "0x6003AF1")]
		public abstract bool Place(Point origin, StructureMap structures, GenerationProgress progress);

		// Token: 0x06003AF2 RID: 15090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF2")]
		[Address(RVA = "0x1E08C94", Offset = "0x1E08C94", VA = "0x1E08C94")]
		protected GenStructure()
		{
		}
	}
}
