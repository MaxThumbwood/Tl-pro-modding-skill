using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.IO;

namespace Terraria.WorldBuilding
{
	// Token: 0x0200059A RID: 1434
	[Token(Token = "0x200059A")]
	public static class Passes
	{
		// Token: 0x0200059B RID: 1435
		[Token(Token = "0x200059B")]
		public class Clear : GenPass
		{
			// Token: 0x06003AB4 RID: 15028 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AB4")]
			[Address(RVA = "0x1E06554", Offset = "0x1E06554", VA = "0x1E06554")]
			public Clear()
			{
			}

			// Token: 0x06003AB5 RID: 15029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AB5")]
			[Address(RVA = "0x1E065CC", Offset = "0x1E065CC", VA = "0x1E065CC", Slot = "4")]
			protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
			{
			}
		}

		// Token: 0x0200059C RID: 1436
		[Token(Token = "0x200059C")]
		public class ScatterCustom : GenPass
		{
			// Token: 0x06003AB6 RID: 15030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AB6")]
			[Address(RVA = "0x1E067D0", Offset = "0x1E067D0", VA = "0x1E067D0")]
			public ScatterCustom(string name, double loadWeight, int count, [Optional] GenBase.CustomPerUnitAction perUnit)
			{
			}

			// Token: 0x06003AB7 RID: 15031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AB7")]
			[Address(RVA = "0x1E06814", Offset = "0x1E06814", VA = "0x1E06814")]
			public void SetCustomAction(GenBase.CustomPerUnitAction perUnit)
			{
			}

			// Token: 0x06003AB8 RID: 15032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AB8")]
			[Address(RVA = "0x1E0681C", Offset = "0x1E0681C", VA = "0x1E0681C", Slot = "4")]
			protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
			{
			}

			// Token: 0x04004638 RID: 17976
			[Token(Token = "0x4004638")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private GenBase.CustomPerUnitAction _perUnit;

			// Token: 0x04004639 RID: 17977
			[Token(Token = "0x4004639")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int _count;
		}
	}
}
