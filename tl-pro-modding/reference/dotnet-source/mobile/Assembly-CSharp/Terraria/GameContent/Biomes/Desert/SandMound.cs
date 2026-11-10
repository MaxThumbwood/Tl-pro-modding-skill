using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.Desert
{
	// Token: 0x02000BBA RID: 3002
	[Token(Token = "0x2000BBA")]
	public static class SandMound
	{
		// Token: 0x06005B31 RID: 23345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B31")]
		[Address(RVA = "0x97C048", Offset = "0x97C048", VA = "0x97C048")]
		public static void Place(DesertDescription description, GenerationProgress progress, float progressMin, float progressMax)
		{
		}

		// Token: 0x06005B32 RID: 23346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B32")]
		[Address(RVA = "0x97C8B4", Offset = "0x97C8B4", VA = "0x97C8B4")]
		internal static void <Place>g__PlaceSandColumn|0_0(int startX, int startY, int height, ref SandMound.<>c__DisplayClass0_0 A_3)
		{
		}

		// Token: 0x02000BBB RID: 3003
		[Token(Token = "0x2000BBB")]
		[StructLayout(3)]
		private struct <>c__DisplayClass0_0
		{
			// Token: 0x04009C0F RID: 39951
			[Token(Token = "0x4009C0F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int Main_maxTilesX;

			// Token: 0x04009C10 RID: 39952
			[Token(Token = "0x4009C10")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public unsafe byte* TileData_TileLiquid;

			// Token: 0x04009C11 RID: 39953
			[Token(Token = "0x4009C11")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public unsafe uint* TileData_TileLookup;

			// Token: 0x04009C12 RID: 39954
			[Token(Token = "0x4009C12")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public unsafe short* TileData_TileSHeader;
		}
	}
}
