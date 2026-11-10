using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes
{
	// Token: 0x02000A4E RID: 2638
	[Token(Token = "0x2000A4E")]
	public class LuckyCoinConditionSetter : FileAPI
	{
		// Token: 0x06005496 RID: 21654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005496")]
		[Address(RVA = "0x816B9C", Offset = "0x816B9C", VA = "0x816B9C")]
		public LuckyCoinConditionSetter(int timesToRunMultiplier)
		{
		}

		// Token: 0x06005497 RID: 21655 RVA: 0x00027348 File Offset: 0x00025548
		[Token(Token = "0x6005497")]
		[Address(RVA = "0x817870", Offset = "0x817870", VA = "0x817870", Slot = "4")]
		public int GetTimesToRunMultiplier(SimulatorInfo info)
		{
			return 0;
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005498")]
		[Address(RVA = "0x8178B4", Offset = "0x8178B4", VA = "0x8178B4", Slot = "5")]
		public void Setup(SimulatorInfo info)
		{
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005499")]
		[Address(RVA = "0x8178B8", Offset = "0x8178B8", VA = "0x8178B8", Slot = "6")]
		public void TearDown(SimulatorInfo info)
		{
		}

		// Token: 0x0400980E RID: 38926
		[Token(Token = "0x400980E")]
		[FieldOffset(Offset = "0x8")]
		private int _timesToRun;
	}
}
