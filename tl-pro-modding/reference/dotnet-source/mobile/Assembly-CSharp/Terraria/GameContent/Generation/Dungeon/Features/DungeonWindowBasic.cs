using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B80 RID: 2944
	[Token(Token = "0x2000B80")]
	public class DungeonWindowBasic : DungeonWindow
	{
		// Token: 0x06005A28 RID: 23080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A28")]
		[Address(RVA = "0x8ECB6C", Offset = "0x8ECB6C", VA = "0x8ECB6C")]
		public DungeonWindowBasic(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x0002A3D8 File Offset: 0x000285D8
		[Token(Token = "0x6005A29")]
		[Address(RVA = "0x8ECB70", Offset = "0x8ECB70", VA = "0x8ECB70", Slot = "4")]
		public override bool GenerateFeature(DungeonData data, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005A2A RID: 23082 RVA: 0x0002A3F0 File Offset: 0x000285F0
		[Token(Token = "0x6005A2A")]
		[Address(RVA = "0x8ECC70", Offset = "0x8ECC70", VA = "0x8ECC70")]
		public bool Window(DungeonData data, int placeX, int placeY, DungeonGenerationStyleData style, bool generating = false)
		{
			return default(bool);
		}

		// Token: 0x06005A2B RID: 23083 RVA: 0x0002A408 File Offset: 0x00028608
		[Token(Token = "0x6005A2B")]
		[Address(RVA = "0x8EDE0C", Offset = "0x8EDE0C", VA = "0x8EDE0C")]
		private bool Window_ValidWindowSpot(int x, int y, int width, int height)
		{
			return default(bool);
		}
	}
}
