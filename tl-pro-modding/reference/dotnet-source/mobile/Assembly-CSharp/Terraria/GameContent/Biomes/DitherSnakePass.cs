using System;
using Il2CppDummyDll;
using Terraria.IO;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x02000B9A RID: 2970
	[Token(Token = "0x2000B9A")]
	public class DitherSnakePass : GenPass
	{
		// Token: 0x06005AA5 RID: 23205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA5")]
		[Address(RVA = "0x92A65C", Offset = "0x92A65C", VA = "0x92A65C")]
		public DitherSnakePass(string passName)
		{
		}

		// Token: 0x06005AA6 RID: 23206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA6")]
		[Address(RVA = "0x92A680", Offset = "0x92A680", VA = "0x92A680", Slot = "4")]
		protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
		{
		}

		// Token: 0x06005AA7 RID: 23207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA7")]
		[Address(RVA = "0x92BA4C", Offset = "0x92BA4C", VA = "0x92BA4C")]
		private void GenerateDungeonDitherSnake(GenerationProgress progress, double progressMin, double progressMax)
		{
		}

		// Token: 0x06005AA8 RID: 23208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AA8")]
		[Address(RVA = "0x92A848", Offset = "0x92A848", VA = "0x92A848")]
		private DitherSnake CalculateDungeonDitherSnake(GenerationProgress progress, double progressMin, double progressMax)
		{
			return null;
		}

		// Token: 0x04009BD5 RID: 39893
		[Token(Token = "0x4009BD5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly double[,] _bayerDither;
	}
}
