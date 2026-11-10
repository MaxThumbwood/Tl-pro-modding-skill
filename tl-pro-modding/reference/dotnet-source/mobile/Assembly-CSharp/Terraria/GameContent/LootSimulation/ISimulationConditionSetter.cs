using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.LootSimulation
{
	// Token: 0x02000A48 RID: 2632
	[Token(Token = "0x2000A48")]
	public interface ISimulationConditionSetter
	{
		// Token: 0x0600546F RID: 21615
		[Token(Token = "0x600546F")]
		int GetTimesToRunMultiplier(SimulatorInfo info);

		// Token: 0x06005470 RID: 21616
		[Token(Token = "0x6005470")]
		void Setup(SimulatorInfo info);

		// Token: 0x06005471 RID: 21617
		[Token(Token = "0x6005471")]
		void TearDown(SimulatorInfo info);
	}
}
