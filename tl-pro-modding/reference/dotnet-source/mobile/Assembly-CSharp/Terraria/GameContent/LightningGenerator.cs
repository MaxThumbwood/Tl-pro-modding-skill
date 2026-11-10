using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Utilities.Terraria.Utilities;

namespace Terraria.GameContent
{
	// Token: 0x0200099A RID: 2458
	[Token(Token = "0x200099A")]
	public class LightningGenerator
	{
		// Token: 0x060050D5 RID: 20693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D5")]
		[Address(RVA = "0x772384", Offset = "0x772384", VA = "0x772384")]
		public LightningGenerator.Bolt Generate(List<LightningGenerator.Bolt> bolts, uint seed, Vector2 targetPosition, Vector2 direction, bool calcPositions, bool calcRotations)
		{
			return null;
		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D6")]
		[Address(RVA = "0x7726EC", Offset = "0x7726EC", VA = "0x7726EC")]
		private LightningGenerator.Bolt GenerateBolt(List<LightningGenerator.Bolt> bolts, uint seed, int depth, bool calcPositions, Vector2 startPos, Vector2 targetPos, float rotationStrength, float stepSize, FloatRange progressRange)
		{
			return null;
		}

		// Token: 0x060050D7 RID: 20695 RVA: 0x00025938 File Offset: 0x00023B38
		[Token(Token = "0x60050D7")]
		[Address(RVA = "0x77355C", Offset = "0x77355C", VA = "0x77355C")]
		private bool TileCollision(Vector2 pos)
		{
			return default(bool);
		}

		// Token: 0x060050D8 RID: 20696 RVA: 0x00025950 File Offset: 0x00023B50
		[Token(Token = "0x60050D8")]
		[Address(RVA = "0x7737F0", Offset = "0x7737F0", VA = "0x7737F0")]
		private bool PickLayerToReroll(double r, float chance, out int layer)
		{
			return default(bool);
		}

		// Token: 0x060050D9 RID: 20697 RVA: 0x00025968 File Offset: 0x00023B68
		[Token(Token = "0x60050D9")]
		[Address(RVA = "0x773860", Offset = "0x773860", VA = "0x773860")]
		private bool PickHighLayerToReroll(double r, float chance, out int layer)
		{
			return default(bool);
		}

		// Token: 0x060050DA RID: 20698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050DA")]
		[Address(RVA = "0x7734B0", Offset = "0x7734B0", VA = "0x7734B0")]
		private static float[] CalcRotations(Vector2[] positions)
		{
			return null;
		}

		// Token: 0x060050DB RID: 20699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050DB")]
		[Address(RVA = "0x7738F4", Offset = "0x7738F4", VA = "0x7738F4")]
		public static void CalcRotations(Vector2[] positions, float[] rotations)
		{
		}

		// Token: 0x060050DC RID: 20700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050DC")]
		[Address(RVA = "0x773BD0", Offset = "0x773BD0", VA = "0x773BD0")]
		private static void SmoothRotations(float[] rotations)
		{
		}

		// Token: 0x060050DD RID: 20701 RVA: 0x00025980 File Offset: 0x00023B80
		[Token(Token = "0x60050DD")]
		[Address(RVA = "0x773C6C", Offset = "0x773C6C", VA = "0x773C6C")]
		public bool CanHitTarget(uint seed, Vector2 targetPosition, [Optional] Vector2? direction)
		{
			return default(bool);
		}

		// Token: 0x060050DE RID: 20702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050DE")]
		[Address(RVA = "0x773E04", Offset = "0x773E04", VA = "0x773E04")]
		public LightningGenerator.Bolt GenerateMainBoltPath(uint seed, Vector2 targetPosition, [Optional] Vector2? direction)
		{
			return null;
		}

		// Token: 0x060050DF RID: 20703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050DF")]
		[Address(RVA = "0x773CC8", Offset = "0x773CC8", VA = "0x773CC8")]
		public LightningGenerator.Bolt Generate(List<LightningGenerator.Bolt> bolts, uint seed, Vector2 targetPosition, [Optional] Vector2? direction, bool calcPositions = true, bool calcRotations = true)
		{
			return null;
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050E0")]
		[Address(RVA = "0x773E50", Offset = "0x773E50", VA = "0x773E50")]
		public static LightningGenerator GetArcSurgeWeaponGenerator(Vector2 start, Vector2 end)
		{
			return null;
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E1")]
		[Address(RVA = "0x77411C", Offset = "0x77411C", VA = "0x77411C")]
		public LightningGenerator()
		{
		}

		// Token: 0x040094A3 RID: 38051
		[Token(Token = "0x40094A3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SolidTileCollision;

		// Token: 0x040094A4 RID: 38052
		[Token(Token = "0x40094A4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float SourceRotationLimit;

		// Token: 0x040094A5 RID: 38053
		[Token(Token = "0x40094A5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Length;

		// Token: 0x040094A6 RID: 38054
		[Token(Token = "0x40094A6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float RotationStrength;

		// Token: 0x040094A7 RID: 38055
		[Token(Token = "0x40094A7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int StepSize;

		// Token: 0x040094A8 RID: 38056
		[Token(Token = "0x40094A8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Layers;

		// Token: 0x040094A9 RID: 38057
		[Token(Token = "0x40094A9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LayerStrengthFactor;

		// Token: 0x040094AA RID: 38058
		[Token(Token = "0x40094AA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float PerpendicularDeviationFactor;

		// Token: 0x040094AB RID: 38059
		[Token(Token = "0x40094AB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ReduceRandomnessAfter;

		// Token: 0x040094AC RID: 38060
		[Token(Token = "0x40094AC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float ForkGenerationThresholdAngleFraction;

		// Token: 0x040094AD RID: 38061
		[Token(Token = "0x40094AD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float ForkReflectAngleMultiplier;

		// Token: 0x040094AE RID: 38062
		[Token(Token = "0x40094AE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float ForkRotationStrengthMultiplier;

		// Token: 0x040094AF RID: 38063
		[Token(Token = "0x40094AF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float ForkStepSizeMultiplier;

		// Token: 0x040094B0 RID: 38064
		[Token(Token = "0x40094B0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float ForkLengthMultiplier;

		// Token: 0x040094B1 RID: 38065
		[Token(Token = "0x40094B1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int MaxForksPerBolt;

		// Token: 0x040094B2 RID: 38066
		[Token(Token = "0x40094B2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int MaxForkDepth;

		// Token: 0x040094B3 RID: 38067
		[Token(Token = "0x40094B3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FloatRange ForkProgressRange;

		// Token: 0x040094B4 RID: 38068
		[Token(Token = "0x40094B4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LightningGenerator StormLightning;

		// Token: 0x040094B5 RID: 38069
		[Token(Token = "0x40094B5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static LightningGenerator LightningStrikeWeapon;

		// Token: 0x0200099B RID: 2459
		[Token(Token = "0x200099B")]
		public class Bolt
		{
			// Token: 0x17000998 RID: 2456
			// (get) Token: 0x060050E3 RID: 20707 RVA: 0x00025998 File Offset: 0x00023B98
			[Token(Token = "0x17000998")]
			public bool IsMainBolt
			{
				[Token(Token = "0x60050E3")]
				[Address(RVA = "0x7738E4", Offset = "0x7738E4", VA = "0x7738E4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060050E4 RID: 20708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050E4")]
			[Address(RVA = "0x773554", Offset = "0x773554", VA = "0x773554")]
			public Bolt()
			{
			}

			// Token: 0x040094B6 RID: 38070
			[Token(Token = "0x40094B6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector2[] positions;

			// Token: 0x040094B7 RID: 38071
			[Token(Token = "0x40094B7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float[] rotations;

			// Token: 0x040094B8 RID: 38072
			[Token(Token = "0x40094B8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FloatRange progressRange;

			// Token: 0x040094B9 RID: 38073
			[Token(Token = "0x40094B9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int forkDepth;

			// Token: 0x040094BA RID: 38074
			[Token(Token = "0x40094BA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool collidedWithTile;
		}
	}
}
