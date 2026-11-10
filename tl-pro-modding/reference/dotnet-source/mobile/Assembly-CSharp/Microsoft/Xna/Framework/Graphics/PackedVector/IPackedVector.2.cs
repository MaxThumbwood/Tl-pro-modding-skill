using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x02000434 RID: 1076
	[Token(Token = "0x2000434")]
	public interface IPackedVector<TPacked> : FileAPI
	{
		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001E08 RID: 7688
		// (set) Token: 0x06001E09 RID: 7689
		[Token(Token = "0x170003B8")]
		TPacked PackedValue
		{
			[Token(Token = "0x6001E08")]
			get;
			[Token(Token = "0x6001E09")]
			set;
		}
	}
}
