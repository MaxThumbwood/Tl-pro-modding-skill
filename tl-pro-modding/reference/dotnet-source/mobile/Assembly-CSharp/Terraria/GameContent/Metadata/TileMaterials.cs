using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.Metadata
{
	// Token: 0x02000A41 RID: 2625
	[Token(Token = "0x2000A41")]
	public static class TileMaterials
	{
		// Token: 0x0600544E RID: 21582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544E")]
		private static T DeserializeEmbeddedResource<T>(string path)
		{
			return null;
		}

		// Token: 0x0600544F RID: 21583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600544F")]
		[Address(RVA = "0x81352C", Offset = "0x81352C", VA = "0x81352C")]
		public static void SetForTileId(ushort tileId, TileMaterial material)
		{
		}

		// Token: 0x06005450 RID: 21584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005450")]
		[Address(RVA = "0x8135E4", Offset = "0x8135E4", VA = "0x8135E4")]
		public static TileMaterial GetByTileId(ushort tileId)
		{
			return null;
		}

		// Token: 0x040097DE RID: 38878
		[Token(Token = "0x40097DE")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, TileMaterial> _materialsByName;

		// Token: 0x040097DF RID: 38879
		[Token(Token = "0x40097DF")]
		[FieldOffset(Offset = "0x4")]
		private static readonly TileMaterial[] MaterialsByTileId;
	}
}
