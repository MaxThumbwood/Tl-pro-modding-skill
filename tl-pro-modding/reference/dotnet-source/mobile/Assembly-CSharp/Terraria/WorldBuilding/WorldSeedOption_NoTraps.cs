using System;
using Il2CppDummyDll;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000540 RID: 1344
	[Token(Token = "0x2000540")]
	public class WorldSeedOption_NoTraps : AWorldGenerationOption
	{
		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060039D3 RID: 14803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700074A")]
		protected override string KeyName
		{
			[Token(Token = "0x60039D3")]
			[Address(RVA = "0x1DFA074", Offset = "0x1DFA074", VA = "0x1DFA074", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060039D4 RID: 14804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700074B")]
		public override string ServerConfigName
		{
			[Token(Token = "0x60039D4")]
			[Address(RVA = "0x1DFA0BC", Offset = "0x1DFA0BC", VA = "0x1DFA0BC", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D5")]
		[Address(RVA = "0x1DFA104", Offset = "0x1DFA104", VA = "0x1DFA104")]
		public WorldSeedOption_NoTraps()
		{
		}
	}
}
