using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200075F RID: 1887
	[Token(Token = "0x200075F")]
	public static class GameDifficultyData
	{
		// Token: 0x04008A5E RID: 35422
		[Token(Token = "0x4008A5E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly GameDifficultyData.LinearCurve EnemyMaxLifeMultiplier;

		// Token: 0x04008A5F RID: 35423
		[Token(Token = "0x4008A5F")]
		[FieldOffset(Offset = "0x4")]
		public static readonly GameDifficultyData.LinearCurve EnemyDamageMultiplier;

		// Token: 0x04008A60 RID: 35424
		[Token(Token = "0x4008A60")]
		[FieldOffset(Offset = "0x8")]
		public static readonly GameDifficultyData.LinearCurve HostileProjectileDamageMultiplier;

		// Token: 0x04008A61 RID: 35425
		[Token(Token = "0x4008A61")]
		[FieldOffset(Offset = "0xC")]
		public static readonly GameDifficultyData.LinearCurve KnockbackToEnemiesMultiplier;

		// Token: 0x04008A62 RID: 35426
		[Token(Token = "0x4008A62")]
		[FieldOffset(Offset = "0x10")]
		public static readonly GameDifficultyData.LinearCurve EnemyMoneyDropMultiplier;

		// Token: 0x04008A63 RID: 35427
		[Token(Token = "0x4008A63")]
		[FieldOffset(Offset = "0x14")]
		public static readonly GameDifficultyData.LinearCurve TownNPCDamageMultiplier;

		// Token: 0x04008A64 RID: 35428
		[Token(Token = "0x4008A64")]
		[FieldOffset(Offset = "0x18")]
		public static readonly GameDifficultyData.LinearCurve DebuffTimeMultiplier;

		// Token: 0x04008A65 RID: 35429
		[Token(Token = "0x4008A65")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly GameDifficultyData.LinearCurve LightningPlayerDamageScaling;

		// Token: 0x04008A66 RID: 35430
		[Token(Token = "0x4008A66")]
		[FieldOffset(Offset = "0x20")]
		public static readonly GameDifficultyData.LinearCurve NoDifficultyPlayerDamageScaling;

		// Token: 0x02000760 RID: 1888
		[Token(Token = "0x2000760")]
		public struct LinearCurve
		{
			// Token: 0x060042E2 RID: 17122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042E2")]
			[Address(RVA = "0x4FA1C0", Offset = "0x4FA1C0", VA = "0x4FA1C0")]
			public LinearCurve(GameDifficultyData.LinearCurve.Key[] keys)
			{
			}

			// Token: 0x060042E3 RID: 17123 RVA: 0x00020550 File Offset: 0x0001E750
			[Token(Token = "0x60042E3")]
			[Address(RVA = "0x4FA208", Offset = "0x4FA208", VA = "0x4FA208")]
			public float Sample(float value)
			{
				return 0f;
			}

			// Token: 0x060042E4 RID: 17124 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60042E4")]
			[Address(RVA = "0x4FA2D4", Offset = "0x4FA2D4", VA = "0x4FA2D4", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04008A67 RID: 35431
			[Token(Token = "0x4008A67")]
			[FieldOffset(Offset = "0x0")]
			public readonly GameDifficultyData.LinearCurve.Key[] keys;

			// Token: 0x02000761 RID: 1889
			[Token(Token = "0x2000761")]
			public struct Key
			{
				// Token: 0x060042E5 RID: 17125 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60042E5")]
				[Address(RVA = "0x4FA1B8", Offset = "0x4FA1B8", VA = "0x4FA1B8")]
				public Key(float input, float output)
				{
				}

				// Token: 0x060042E6 RID: 17126 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60042E6")]
				[Address(RVA = "0x4FA348", Offset = "0x4FA348", VA = "0x4FA348", Slot = "3")]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x04008A68 RID: 35432
				[Token(Token = "0x4008A68")]
				[FieldOffset(Offset = "0x0")]
				public readonly float input;

				// Token: 0x04008A69 RID: 35433
				[Token(Token = "0x4008A69")]
				[FieldOffset(Offset = "0x4")]
				public readonly float output;
			}
		}
	}
}
