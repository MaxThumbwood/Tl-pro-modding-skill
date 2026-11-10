using System;
using Il2CppDummyDll;

namespace Terraria.Physics
{
	// Token: 0x0200064D RID: 1613
	[Token(Token = "0x200064D")]
	public class PhysicsProperties
	{
		// Token: 0x06003E62 RID: 15970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E62")]
		[Address(RVA = "0x1E6E0B0", Offset = "0x1E6E0B0", VA = "0x1E6E0B0")]
		public PhysicsProperties(float gravity, float drag)
		{
		}

		// Token: 0x040048B9 RID: 18617
		[Token(Token = "0x40048B9")]
		[FieldOffset(Offset = "0x8")]
		public readonly float Gravity;

		// Token: 0x040048BA RID: 18618
		[Token(Token = "0x40048BA")]
		[FieldOffset(Offset = "0xC")]
		public readonly float Drag;
	}
}
