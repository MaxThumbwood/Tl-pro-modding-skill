using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes
{
	// Token: 0x02000A4D RID: 2637
	[Token(Token = "0x2000A4D")]
	public class SlimeStaffConditionSetter : FileAPI
	{
		// Token: 0x06005492 RID: 21650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005492")]
		[Address(RVA = "0x816B80", Offset = "0x816B80", VA = "0x816B80")]
		public SlimeStaffConditionSetter(int timesToRunMultiplier)
		{
		}

		// Token: 0x06005493 RID: 21651 RVA: 0x00027330 File Offset: 0x00025530
		[Token(Token = "0x6005493")]
		[Address(RVA = "0x81772C", Offset = "0x81772C", VA = "0x81772C", Slot = "4")]
		public int GetTimesToRunMultiplier(SimulatorInfo info)
		{
			return 0;
		}

		// Token: 0x06005494 RID: 21652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005494")]
		[Address(RVA = "0x817868", Offset = "0x817868", VA = "0x817868", Slot = "5")]
		public void Setup(SimulatorInfo info)
		{
		}

		// Token: 0x06005495 RID: 21653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005495")]
		[Address(RVA = "0x81786C", Offset = "0x81786C", VA = "0x81786C", Slot = "6")]
		public void TearDown(SimulatorInfo info)
		{
		}

		// Token: 0x0400980D RID: 38925
		[Token(Token = "0x400980D")]
		[FieldOffset(Offset = "0x8")]
		private int _timesToRun;
	}
}
