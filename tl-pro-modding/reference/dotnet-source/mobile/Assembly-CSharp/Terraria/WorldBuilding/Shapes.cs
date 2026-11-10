using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria.WorldBuilding
{
	// Token: 0x020005A7 RID: 1447
	[Token(Token = "0x20005A7")]
	public static class Shapes
	{
		// Token: 0x020005A8 RID: 1448
		[Token(Token = "0x20005A8")]
		public class Circle : GenShape
		{
			// Token: 0x06003ADD RID: 15069 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003ADD")]
			[Address(RVA = "0x1E078C4", Offset = "0x1E078C4", VA = "0x1E078C4")]
			public Circle(int radius)
			{
			}

			// Token: 0x06003ADE RID: 15070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003ADE")]
			[Address(RVA = "0x1E078E4", Offset = "0x1E078E4", VA = "0x1E078E4")]
			public Circle(int horizontalRadius, int verticalRadius)
			{
			}

			// Token: 0x06003ADF RID: 15071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003ADF")]
			[Address(RVA = "0x1E07908", Offset = "0x1E07908", VA = "0x1E07908")]
			public void SetRadius(int radius)
			{
			}

			// Token: 0x06003AE0 RID: 15072 RVA: 0x0001DA78 File Offset: 0x0001BC78
			[Token(Token = "0x6003AE0")]
			[Address(RVA = "0x1E07918", Offset = "0x1E07918", VA = "0x1E07918", Slot = "4")]
			public override bool Perform(Point origin, GenAction action)
			{
				return default(bool);
			}

			// Token: 0x0400464C RID: 17996
			[Token(Token = "0x400464C")]
			[FieldOffset(Offset = "0x10")]
			private int _verticalRadius;

			// Token: 0x0400464D RID: 17997
			[Token(Token = "0x400464D")]
			[FieldOffset(Offset = "0x14")]
			private int _horizontalRadius;
		}

		// Token: 0x020005A9 RID: 1449
		[Token(Token = "0x20005A9")]
		public class HalfCircle : GenShape
		{
			// Token: 0x06003AE1 RID: 15073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AE1")]
			[Address(RVA = "0x1E07B5C", Offset = "0x1E07B5C", VA = "0x1E07B5C")]
			public HalfCircle(int radius, bool bottomHalf = false)
			{
			}

			// Token: 0x06003AE2 RID: 15074 RVA: 0x0001DA90 File Offset: 0x0001BC90
			[Token(Token = "0x6003AE2")]
			[Address(RVA = "0x1E07B80", Offset = "0x1E07B80", VA = "0x1E07B80", Slot = "4")]
			public override bool Perform(Point origin, GenAction action)
			{
				return default(bool);
			}

			// Token: 0x0400464E RID: 17998
			[Token(Token = "0x400464E")]
			[FieldOffset(Offset = "0x10")]
			private int _radius;

			// Token: 0x0400464F RID: 17999
			[Token(Token = "0x400464F")]
			[FieldOffset(Offset = "0x14")]
			private bool _bottomHalf;
		}

		// Token: 0x020005AA RID: 1450
		[Token(Token = "0x20005AA")]
		public class Slime : GenShape
		{
			// Token: 0x06003AE3 RID: 15075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AE3")]
			[Address(RVA = "0x1E07DD4", Offset = "0x1E07DD4", VA = "0x1E07DD4")]
			public Slime(int radius)
			{
			}

			// Token: 0x06003AE4 RID: 15076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AE4")]
			[Address(RVA = "0x1E07E0C", Offset = "0x1E07E0C", VA = "0x1E07E0C")]
			public Slime(int radius, double xScale, double yScale)
			{
			}

			// Token: 0x06003AE5 RID: 15077 RVA: 0x0001DAA8 File Offset: 0x0001BCA8
			[Token(Token = "0x6003AE5")]
			[Address(RVA = "0x1E07E40", Offset = "0x1E07E40", VA = "0x1E07E40", Slot = "4")]
			public override bool Perform(Point origin, GenAction action)
			{
				return default(bool);
			}

			// Token: 0x04004650 RID: 18000
			[Token(Token = "0x4004650")]
			[FieldOffset(Offset = "0x10")]
			private int _radius;

			// Token: 0x04004651 RID: 18001
			[Token(Token = "0x4004651")]
			[FieldOffset(Offset = "0x18")]
			private double _xScale;

			// Token: 0x04004652 RID: 18002
			[Token(Token = "0x4004652")]
			[FieldOffset(Offset = "0x20")]
			private double _yScale;
		}

		// Token: 0x020005AB RID: 1451
		[Token(Token = "0x20005AB")]
		public class Rectangle : GenShape
		{
			// Token: 0x06003AE6 RID: 15078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AE6")]
			[Address(RVA = "0x1E082A4", Offset = "0x1E082A4", VA = "0x1E082A4")]
			public Rectangle(Microsoft.Xna.Framework.Rectangle area)
			{
			}

			// Token: 0x06003AE7 RID: 15079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AE7")]
			[Address(RVA = "0x1E082D8", Offset = "0x1E082D8", VA = "0x1E082D8")]
			public Rectangle(int width, int height)
			{
			}

			// Token: 0x06003AE8 RID: 15080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AE8")]
			[Address(RVA = "0x1E08330", Offset = "0x1E08330", VA = "0x1E08330")]
			public void SetArea(Microsoft.Xna.Framework.Rectangle area)
			{
			}

			// Token: 0x06003AE9 RID: 15081 RVA: 0x0001DAC0 File Offset: 0x0001BCC0
			[Token(Token = "0x6003AE9")]
			[Address(RVA = "0x1E08340", Offset = "0x1E08340", VA = "0x1E08340", Slot = "4")]
			public override bool Perform(Point origin, GenAction action)
			{
				return default(bool);
			}

			// Token: 0x04004653 RID: 18003
			[Token(Token = "0x4004653")]
			[FieldOffset(Offset = "0x10")]
			private Microsoft.Xna.Framework.Rectangle _area;
		}

		// Token: 0x020005AC RID: 1452
		[Token(Token = "0x20005AC")]
		public class Tail : GenShape
		{
			// Token: 0x06003AEA RID: 15082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AEA")]
			[Address(RVA = "0x1E08564", Offset = "0x1E08564", VA = "0x1E08564")]
			public Tail(double width, Vector2D endOffset)
			{
			}

			// Token: 0x06003AEB RID: 15083 RVA: 0x0001DAD8 File Offset: 0x0001BCD8
			[Token(Token = "0x6003AEB")]
			[Address(RVA = "0x1E08640", Offset = "0x1E08640", VA = "0x1E08640", Slot = "4")]
			public override bool Perform(Point origin, GenAction action)
			{
				return default(bool);
			}

			// Token: 0x04004654 RID: 18004
			[Token(Token = "0x4004654")]
			[FieldOffset(Offset = "0x10")]
			private double _width;

			// Token: 0x04004655 RID: 18005
			[Token(Token = "0x4004655")]
			[FieldOffset(Offset = "0x18")]
			private Vector2D _endOffset;

			// Token: 0x020005AD RID: 1453
			[Token(Token = "0x20005AD")]
			private sealed class <>c__DisplayClass3_0
			{
				// Token: 0x06003AEC RID: 15084 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6003AEC")]
				[Address(RVA = "0x1E088D8", Offset = "0x1E088D8", VA = "0x1E088D8")]
				public <>c__DisplayClass3_0()
				{
				}

				// Token: 0x06003AED RID: 15085 RVA: 0x0001DAF0 File Offset: 0x0001BCF0
				[Token(Token = "0x6003AED")]
				[Address(RVA = "0x1E088E0", Offset = "0x1E088E0", VA = "0x1E088E0")]
				internal bool <Perform>b__0(int x, int y)
				{
					return default(bool);
				}

				// Token: 0x04004656 RID: 18006
				[Token(Token = "0x4004656")]
				[FieldOffset(Offset = "0x8")]
				public Shapes.Tail <>4__this;

				// Token: 0x04004657 RID: 18007
				[Token(Token = "0x4004657")]
				[FieldOffset(Offset = "0xC")]
				public GenAction action;

				// Token: 0x04004658 RID: 18008
				[Token(Token = "0x4004658")]
				[FieldOffset(Offset = "0x10")]
				public Point origin;
			}
		}

		// Token: 0x020005AE RID: 1454
		[Token(Token = "0x20005AE")]
		public class Mound : GenShape
		{
			// Token: 0x06003AEE RID: 15086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AEE")]
			[Address(RVA = "0x1E08A10", Offset = "0x1E08A10", VA = "0x1E08A10")]
			public Mound(int halfWidth, int height)
			{
			}

			// Token: 0x06003AEF RID: 15087 RVA: 0x0001DB08 File Offset: 0x0001BD08
			[Token(Token = "0x6003AEF")]
			[Address(RVA = "0x1E08A38", Offset = "0x1E08A38", VA = "0x1E08A38", Slot = "4")]
			public override bool Perform(Point origin, GenAction action)
			{
				return default(bool);
			}

			// Token: 0x04004659 RID: 18009
			[Token(Token = "0x4004659")]
			[FieldOffset(Offset = "0x10")]
			private int _halfWidth;

			// Token: 0x0400465A RID: 18010
			[Token(Token = "0x400465A")]
			[FieldOffset(Offset = "0x14")]
			private int _height;
		}
	}
}
