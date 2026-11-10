using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007AF RID: 1967
	[Token(Token = "0x20007AF")]
	public class EntitySource_Gift : FileAPI
	{
		// Token: 0x0600444E RID: 17486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444E")]
		[Address(RVA = "0x559010", Offset = "0x559010", VA = "0x559010")]
		public EntitySource_Gift(Entity entity)
		{
		}

		// Token: 0x04008BDB RID: 35803
		[Token(Token = "0x4008BDB")]
		[FieldOffset(Offset = "0x8")]
		public readonly IEntitySourceTarget Entity;
	}
}
