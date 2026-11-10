using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes
{
	// Token: 0x02000A4B RID: 2635
	[Token(Token = "0x2000A4B")]
	public class FastConditionSetter : FileAPI
	{
		// Token: 0x0600548A RID: 21642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600548A")]
		[Address(RVA = "0x816B40", Offset = "0x816B40", VA = "0x816B40")]
		public FastConditionSetter(Action<SimulatorInfo> setup, Action<SimulatorInfo> tearDown)
		{
		}

		// Token: 0x0600548B RID: 21643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600548B")]
		[Address(RVA = "0x8174E4", Offset = "0x8174E4", VA = "0x8174E4", Slot = "5")]
		public void Setup(SimulatorInfo info)
		{
		}

		// Token: 0x0600548C RID: 21644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600548C")]
		[Address(RVA = "0x817500", Offset = "0x817500", VA = "0x817500", Slot = "6")]
		public void TearDown(SimulatorInfo info)
		{
		}

		// Token: 0x0600548D RID: 21645 RVA: 0x00027300 File Offset: 0x00025500
		[Token(Token = "0x600548D")]
		[Address(RVA = "0x81751C", Offset = "0x81751C", VA = "0x81751C", Slot = "4")]
		public int GetTimesToRunMultiplier(SimulatorInfo info)
		{
			return 0;
		}

		// Token: 0x0400980A RID: 38922
		[Token(Token = "0x400980A")]
		[FieldOffset(Offset = "0x8")]
		private Action<SimulatorInfo> _setup;

		// Token: 0x0400980B RID: 38923
		[Token(Token = "0x400980B")]
		[FieldOffset(Offset = "0xC")]
		private Action<SimulatorInfo> _tearDown;
	}
}
