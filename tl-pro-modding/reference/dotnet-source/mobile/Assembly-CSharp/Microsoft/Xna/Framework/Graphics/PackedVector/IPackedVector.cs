using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x02000433 RID: 1075
	[Token(Token = "0x2000433")]
	public interface IPackedVector
	{
		// Token: 0x06001E06 RID: 7686
		[Token(Token = "0x6001E06")]
		void PackFromVector4(Vector4 vector);

		// Token: 0x06001E07 RID: 7687
		[Token(Token = "0x6001E07")]
		Vector4 ToVector4();
	}
}
