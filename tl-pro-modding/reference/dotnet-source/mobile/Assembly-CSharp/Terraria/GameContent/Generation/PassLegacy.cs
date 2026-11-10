using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.IO;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x02000B08 RID: 2824
	[Token(Token = "0x2000B08")]
	public class PassLegacy : GenPass
	{
		// Token: 0x06005815 RID: 22549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005815")]
		[Address(RVA = "0x85D03C", Offset = "0x85D03C", VA = "0x85D03C")]
		public PassLegacy(string name, WorldGenLegacyMethod method)
		{
		}

		// Token: 0x06005816 RID: 22550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005816")]
		[Address(RVA = "0x85D1A8", Offset = "0x85D1A8", VA = "0x85D1A8")]
		public PassLegacy(string name, WorldGenLegacyMethod method, double weight)
		{
		}

		// Token: 0x06005817 RID: 22551 RVA: 0x00028F08 File Offset: 0x00027108
		[Token(Token = "0x6005817")]
		[Address(RVA = "0x85D0D4", Offset = "0x85D0D4", VA = "0x85D0D4")]
		private static float GetWeight(string name)
		{
			return 0f;
		}

		// Token: 0x06005818 RID: 22552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005818")]
		[Address(RVA = "0x85D1DC", Offset = "0x85D1DC", VA = "0x85D1DC", Slot = "4")]
		protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
		{
		}

		// Token: 0x0400996F RID: 39279
		[Token(Token = "0x400996F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, float> _weightMap_135;

		// Token: 0x04009970 RID: 39280
		[Token(Token = "0x4009970")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Dictionary<string, float> _weightMap;

		// Token: 0x04009971 RID: 39281
		[Token(Token = "0x4009971")]
		[FieldOffset(Offset = "0x18")]
		private readonly WorldGenLegacyMethod _method;
	}
}
