using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes
{
	// Token: 0x02000A4C RID: 2636
	[Token(Token = "0x2000A4C")]
	public class StackedConditionSetter : FileAPI
	{
		// Token: 0x0600548E RID: 21646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600548E")]
		[Address(RVA = "0x816B64", Offset = "0x816B64", VA = "0x816B64")]
		public StackedConditionSetter(ISimulationConditionSetter[] setters)
		{
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600548F")]
		[Address(RVA = "0x817524", Offset = "0x817524", VA = "0x817524", Slot = "5")]
		public void Setup(SimulatorInfo info)
		{
		}

		// Token: 0x06005490 RID: 21648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005490")]
		[Address(RVA = "0x817624", Offset = "0x817624", VA = "0x817624", Slot = "6")]
		public void TearDown(SimulatorInfo info)
		{
		}

		// Token: 0x06005491 RID: 21649 RVA: 0x00027318 File Offset: 0x00025518
		[Token(Token = "0x6005491")]
		[Address(RVA = "0x817724", Offset = "0x817724", VA = "0x817724", Slot = "4")]
		public int GetTimesToRunMultiplier(SimulatorInfo info)
		{
			return 0;
		}

		// Token: 0x0400980C RID: 38924
		[Token(Token = "0x400980C")]
		[FieldOffset(Offset = "0x8")]
		private ISimulationConditionSetter[] _setters;
	}
}
