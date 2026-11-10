using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B70 RID: 2928
	[Token(Token = "0x2000B70")]
	public class DungeonGlobalLights : GlobalDungeonFeature
	{
		// Token: 0x060059FA RID: 23034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059FA")]
		[Address(RVA = "0x8D5EE4", Offset = "0x8D5EE4", VA = "0x8D5EE4")]
		public DungeonGlobalLights(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x060059FB RID: 23035 RVA: 0x0002A1E0 File Offset: 0x000283E0
		[Token(Token = "0x60059FB")]
		[Address(RVA = "0x8D5FF8", Offset = "0x8D5FF8", VA = "0x8D5FF8", Slot = "4")]
		public override bool GenerateFeature(DungeonData data)
		{
			return default(bool);
		}

		// Token: 0x060059FC RID: 23036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059FC")]
		[Address(RVA = "0x8D6020", Offset = "0x8D6020", VA = "0x8D6020")]
		public void Lights(DungeonData data)
		{
		}

		// Token: 0x060059FD RID: 23037 RVA: 0x0002A1F8 File Offset: 0x000283F8
		[Token(Token = "0x60059FD")]
		[Address(RVA = "0x8D7B60", Offset = "0x8D7B60", VA = "0x8D7B60")]
		private Point Lights_GenerateSwitch(int x, int y)
		{
			return default(Point);
		}
	}
}
