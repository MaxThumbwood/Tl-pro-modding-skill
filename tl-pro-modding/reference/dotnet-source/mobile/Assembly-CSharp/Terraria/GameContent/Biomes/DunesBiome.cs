using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes.Desert;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x02000B9B RID: 2971
	[Token(Token = "0x2000B9B")]
	public class DunesBiome : MicroBiome
	{
		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06005AAA RID: 23210 RVA: 0x0002A840 File Offset: 0x00028A40
		[Token(Token = "0x17000A0C")]
		public int MaximumWidth
		{
			[Token(Token = "0x6005AAA")]
			[Address(RVA = "0x92BE14", Offset = "0x92BE14", VA = "0x92BE14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005AAB RID: 23211 RVA: 0x0002A858 File Offset: 0x00028A58
		[Token(Token = "0x6005AAB")]
		[Address(RVA = "0x92BE40", Offset = "0x92BE40", VA = "0x92BE40", Slot = "5")]
		public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
		{
			return default(bool);
		}

		// Token: 0x06005AAC RID: 23212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AAC")]
		[Address(RVA = "0x92C240", Offset = "0x92C240", VA = "0x92C240")]
		private void PlaceSingle(DunesBiome.DunesDescription description, StructureMap structures)
		{
		}

		// Token: 0x06005AAD RID: 23213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AAD")]
		[Address(RVA = "0x92C638", Offset = "0x92C638", VA = "0x92C638")]
		private static void PlaceHill(int startX, int endX, double scale, DunesBiome.DunesDescription description)
		{
		}

		// Token: 0x06005AAE RID: 23214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AAE")]
		[Address(RVA = "0x92C980", Offset = "0x92C980", VA = "0x92C980")]
		private static void PlaceCurvedLine(Point startPoint, Point endPoint, Point anchorOffset, DunesBiome.DunesDescription description)
		{
		}

		// Token: 0x06005AAF RID: 23215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AAF")]
		[Address(RVA = "0x92D258", Offset = "0x92D258", VA = "0x92D258")]
		public DunesBiome()
		{
		}

		// Token: 0x04009BD6 RID: 39894
		[Token(Token = "0x4009BD6")]
		[FieldOffset(Offset = "0x8")]
		private WorldGenRange _singleDunesWidth;

		// Token: 0x04009BD7 RID: 39895
		[Token(Token = "0x4009BD7")]
		[FieldOffset(Offset = "0x10")]
		private double _heightScale;

		// Token: 0x02000B9C RID: 2972
		[Token(Token = "0x2000B9C")]
		private class DunesDescription
		{
			// Token: 0x17000A0D RID: 2573
			// (get) Token: 0x06005AB0 RID: 23216 RVA: 0x0002A870 File Offset: 0x00028A70
			// (set) Token: 0x06005AB1 RID: 23217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A0D")]
			public bool IsValid
			{
				[Token(Token = "0x6005AB0")]
				[Address(RVA = "0x92D2E4", Offset = "0x92D2E4", VA = "0x92D2E4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6005AB1")]
				[Address(RVA = "0x92D2EC", Offset = "0x92D2EC", VA = "0x92D2EC")]
				private set
				{
				}
			}

			// Token: 0x17000A0E RID: 2574
			// (get) Token: 0x06005AB2 RID: 23218 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005AB3 RID: 23219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A0E")]
			public SurfaceMap Surface
			{
				[Token(Token = "0x6005AB2")]
				[Address(RVA = "0x92D2F4", Offset = "0x92D2F4", VA = "0x92D2F4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6005AB3")]
				[Address(RVA = "0x92D2FC", Offset = "0x92D2FC", VA = "0x92D2FC")]
				private set
				{
				}
			}

			// Token: 0x17000A0F RID: 2575
			// (get) Token: 0x06005AB4 RID: 23220 RVA: 0x0002A888 File Offset: 0x00028A88
			// (set) Token: 0x06005AB5 RID: 23221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A0F")]
			public Rectangle Area
			{
				[Token(Token = "0x6005AB4")]
				[Address(RVA = "0x92D304", Offset = "0x92D304", VA = "0x92D304")]
				get
				{
					return default(Rectangle);
				}
				[Token(Token = "0x6005AB5")]
				[Address(RVA = "0x92D314", Offset = "0x92D314", VA = "0x92D314")]
				private set
				{
				}
			}

			// Token: 0x17000A10 RID: 2576
			// (get) Token: 0x06005AB6 RID: 23222 RVA: 0x0002A8A0 File Offset: 0x00028AA0
			// (set) Token: 0x06005AB7 RID: 23223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A10")]
			public DunesBiome.WindDirection WindDirection
			{
				[Token(Token = "0x6005AB6")]
				[Address(RVA = "0x92D324", Offset = "0x92D324", VA = "0x92D324")]
				get
				{
					return DunesBiome.WindDirection.Left;
				}
				[Token(Token = "0x6005AB7")]
				[Address(RVA = "0x92D32C", Offset = "0x92D32C", VA = "0x92D32C")]
				private set
				{
				}
			}

			// Token: 0x06005AB8 RID: 23224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AB8")]
			[Address(RVA = "0x92D334", Offset = "0x92D334", VA = "0x92D334")]
			private DunesDescription()
			{
			}

			// Token: 0x06005AB9 RID: 23225 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AB9")]
			[Address(RVA = "0x92C030", Offset = "0x92C030", VA = "0x92C030")]
			public static DunesBiome.DunesDescription CreateFromPlacement(Point origin, int width, int height)
			{
				return null;
			}

			// Token: 0x04009BD8 RID: 39896
			[Token(Token = "0x4009BD8")]
			[FieldOffset(Offset = "0x8")]
			private bool <IsValid>k__BackingField;

			// Token: 0x04009BD9 RID: 39897
			[Token(Token = "0x4009BD9")]
			[FieldOffset(Offset = "0xC")]
			private SurfaceMap <Surface>k__BackingField;

			// Token: 0x04009BDA RID: 39898
			[Token(Token = "0x4009BDA")]
			[FieldOffset(Offset = "0x10")]
			private Rectangle <Area>k__BackingField;

			// Token: 0x04009BDB RID: 39899
			[Token(Token = "0x4009BDB")]
			[FieldOffset(Offset = "0x20")]
			private DunesBiome.WindDirection <WindDirection>k__BackingField;
		}

		// Token: 0x02000B9D RID: 2973
		[Token(Token = "0x2000B9D")]
		private enum WindDirection
		{
			// Token: 0x04009BDD RID: 39901
			[Token(Token = "0x4009BDD")]
			Left,
			// Token: 0x04009BDE RID: 39902
			[Token(Token = "0x4009BDE")]
			Right
		}
	}
}
