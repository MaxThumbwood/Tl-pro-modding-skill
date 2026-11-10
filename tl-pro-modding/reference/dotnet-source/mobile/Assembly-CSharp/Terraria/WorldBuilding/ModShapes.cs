using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000595 RID: 1429
	[Token(Token = "0x2000595")]
	public static class ModShapes
	{
		// Token: 0x02000596 RID: 1430
		[Token(Token = "0x2000596")]
		public class All : GenModShape
		{
			// Token: 0x06003AA5 RID: 15013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AA5")]
			[Address(RVA = "0x1E056A0", Offset = "0x1E056A0", VA = "0x1E056A0")]
			public All(ShapeData data)
			{
			}

			// Token: 0x06003AA6 RID: 15014 RVA: 0x0001D8F8 File Offset: 0x0001BAF8
			[Token(Token = "0x6003AA6")]
			[Address(RVA = "0x1E056BC", Offset = "0x1E056BC", VA = "0x1E056BC", Slot = "4")]
			public override bool Perform(Point origin, GenAction action)
			{
				return default(bool);
			}
		}

		// Token: 0x02000597 RID: 1431
		[Token(Token = "0x2000597")]
		public class OuterOutline : GenModShape
		{
			// Token: 0x06003AA7 RID: 15015 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AA7")]
			[Address(RVA = "0x1E059B4", Offset = "0x1E059B4", VA = "0x1E059B4")]
			public OuterOutline(ShapeData data, bool useDiagonals = true, bool useInterior = false)
			{
			}

			// Token: 0x06003AA8 RID: 15016 RVA: 0x0001D910 File Offset: 0x0001BB10
			[Token(Token = "0x6003AA8")]
			[Address(RVA = "0x1E059E0", Offset = "0x1E059E0", VA = "0x1E059E0", Slot = "4")]
			public override bool Perform(Point origin, GenAction action)
			{
				return default(bool);
			}

			// Token: 0x04004630 RID: 17968
			[Token(Token = "0x4004630")]
			[FieldOffset(Offset = "0x0")]
			private static readonly int[] POINT_OFFSETS;

			// Token: 0x04004631 RID: 17969
			[Token(Token = "0x4004631")]
			[FieldOffset(Offset = "0x14")]
			private bool _useDiagonals;

			// Token: 0x04004632 RID: 17970
			[Token(Token = "0x4004632")]
			[FieldOffset(Offset = "0x15")]
			private bool _useInterior;
		}

		// Token: 0x02000598 RID: 1432
		[Token(Token = "0x2000598")]
		public class InnerOutline : GenModShape
		{
			// Token: 0x06003AAA RID: 15018 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AAA")]
			[Address(RVA = "0x1E06010", Offset = "0x1E06010", VA = "0x1E06010")]
			public InnerOutline(ShapeData data, bool useDiagonals = true)
			{
			}

			// Token: 0x06003AAB RID: 15019 RVA: 0x0001D928 File Offset: 0x0001BB28
			[Token(Token = "0x6003AAB")]
			[Address(RVA = "0x1E06034", Offset = "0x1E06034", VA = "0x1E06034", Slot = "4")]
			public override bool Perform(Point origin, GenAction action)
			{
				return default(bool);
			}

			// Token: 0x04004633 RID: 17971
			[Token(Token = "0x4004633")]
			[FieldOffset(Offset = "0x0")]
			private static readonly int[] POINT_OFFSETS;

			// Token: 0x04004634 RID: 17972
			[Token(Token = "0x4004634")]
			[FieldOffset(Offset = "0x14")]
			private bool _useDiagonals;
		}
	}
}
