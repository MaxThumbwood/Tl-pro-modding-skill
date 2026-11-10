using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.Testing.Cloning
{
	// Token: 0x02000605 RID: 1541
	[Token(Token = "0x2000605")]
	internal sealed class RefEqualityComparer : EqualityComparer<object>
	{
		// Token: 0x06003CF0 RID: 15600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF0")]
		[Address(RVA = "0x1E6133C", Offset = "0x1E6133C", VA = "0x1E6133C")]
		private RefEqualityComparer()
		{
		}

		// Token: 0x06003CF1 RID: 15601 RVA: 0x0001E870 File Offset: 0x0001CA70
		[Token(Token = "0x6003CF1")]
		[Address(RVA = "0x1E61390", Offset = "0x1E61390", VA = "0x1E61390", Slot = "8")]
		public override bool Equals(object x, object y)
		{
			return default(bool);
		}

		// Token: 0x06003CF2 RID: 15602 RVA: 0x0001E888 File Offset: 0x0001CA88
		[Token(Token = "0x6003CF2")]
		[Address(RVA = "0x1E613A0", Offset = "0x1E613A0", VA = "0x1E613A0", Slot = "9")]
		public override int GetHashCode(object obj)
		{
			return 0;
		}

		// Token: 0x040047F6 RID: 18422
		[Token(Token = "0x40047F6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RefEqualityComparer Instance;
	}
}
