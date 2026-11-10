using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation.Dungeon
{
	// Token: 0x02000B2A RID: 2858
	[Token(Token = "0x2000B2A")]
	public class DungeonShapes
	{
		// Token: 0x060058A7 RID: 22695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058A7")]
		[Address(RVA = "0x87B91C", Offset = "0x87B91C", VA = "0x87B91C")]
		public DungeonShapes()
		{
		}

		// Token: 0x02000B2B RID: 2859
		[Token(Token = "0x2000B2B")]
		public class CircleRoom : GenShape
		{
			// Token: 0x170009FB RID: 2555
			// (get) Token: 0x060058A8 RID: 22696 RVA: 0x00029520 File Offset: 0x00027720
			[Token(Token = "0x170009FB")]
			public int VerticalRadius
			{
				[Token(Token = "0x60058A8")]
				[Address(RVA = "0x87B924", Offset = "0x87B924", VA = "0x87B924")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170009FC RID: 2556
			// (get) Token: 0x060058A9 RID: 22697 RVA: 0x00029538 File Offset: 0x00027738
			[Token(Token = "0x170009FC")]
			public int HorizontalRadius
			{
				[Token(Token = "0x60058A9")]
				[Address(RVA = "0x87B92C", Offset = "0x87B92C", VA = "0x87B92C")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060058AA RID: 22698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058AA")]
			[Address(RVA = "0x87B934", Offset = "0x87B934", VA = "0x87B934")]
			public CircleRoom(int radius)
			{
			}

			// Token: 0x060058AB RID: 22699 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058AB")]
			[Address(RVA = "0x87B954", Offset = "0x87B954", VA = "0x87B954")]
			public CircleRoom(int horizontalRadius, int verticalRadius)
			{
			}

			// Token: 0x060058AC RID: 22700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058AC")]
			[Address(RVA = "0x87B978", Offset = "0x87B978", VA = "0x87B978")]
			public void SetRadius(int radius)
			{
			}

			// Token: 0x060058AD RID: 22701 RVA: 0x00029550 File Offset: 0x00027750
			[Token(Token = "0x60058AD")]
			[Address(RVA = "0x87B988", Offset = "0x87B988", VA = "0x87B988", Slot = "4")]
			public override bool Perform(Point origin, GenAction action)
			{
				return default(bool);
			}

			// Token: 0x04009A70 RID: 39536
			[Token(Token = "0x4009A70")]
			[FieldOffset(Offset = "0x10")]
			private int _verticalRadius;

			// Token: 0x04009A71 RID: 39537
			[Token(Token = "0x4009A71")]
			[FieldOffset(Offset = "0x14")]
			private int _horizontalRadius;
		}

		// Token: 0x02000B2C RID: 2860
		[Token(Token = "0x2000B2C")]
		public class MoundRoom : GenShape
		{
			// Token: 0x060058AE RID: 22702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058AE")]
			[Address(RVA = "0x87BB84", Offset = "0x87BB84", VA = "0x87BB84")]
			public MoundRoom(int halfWidth, int height)
			{
			}

			// Token: 0x060058AF RID: 22703 RVA: 0x00029568 File Offset: 0x00027768
			[Token(Token = "0x60058AF")]
			[Address(RVA = "0x87BBA8", Offset = "0x87BBA8", VA = "0x87BBA8", Slot = "4")]
			public override bool Perform(Point origin, GenAction action)
			{
				return default(bool);
			}

			// Token: 0x04009A72 RID: 39538
			[Token(Token = "0x4009A72")]
			[FieldOffset(Offset = "0x10")]
			private int _halfWidth;

			// Token: 0x04009A73 RID: 39539
			[Token(Token = "0x4009A73")]
			[FieldOffset(Offset = "0x14")]
			private int _height;
		}

		// Token: 0x02000B2D RID: 2861
		[Token(Token = "0x2000B2D")]
		public class HourglassRoom : GenShape
		{
			// Token: 0x060058B0 RID: 22704 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058B0")]
			[Address(RVA = "0x87BDA8", Offset = "0x87BDA8", VA = "0x87BDA8")]
			public HourglassRoom(int width, int height, float percentileAddon)
			{
			}

			// Token: 0x060058B1 RID: 22705 RVA: 0x00029580 File Offset: 0x00027780
			[Token(Token = "0x60058B1")]
			[Address(RVA = "0x87BDD4", Offset = "0x87BDD4", VA = "0x87BDD4", Slot = "4")]
			public override bool Perform(Point origin, GenAction action)
			{
				return default(bool);
			}

			// Token: 0x04009A74 RID: 39540
			[Token(Token = "0x4009A74")]
			[FieldOffset(Offset = "0x10")]
			private int _width;

			// Token: 0x04009A75 RID: 39541
			[Token(Token = "0x4009A75")]
			[FieldOffset(Offset = "0x14")]
			private int _height;

			// Token: 0x04009A76 RID: 39542
			[Token(Token = "0x4009A76")]
			[FieldOffset(Offset = "0x18")]
			private float _percentileAddon;
		}

		// Token: 0x02000B2E RID: 2862
		[Token(Token = "0x2000B2E")]
		public class QuadCircleRoom : GenShape
		{
			// Token: 0x170009FD RID: 2557
			// (get) Token: 0x060058B2 RID: 22706 RVA: 0x00029598 File Offset: 0x00027798
			[Token(Token = "0x170009FD")]
			public int Radius
			{
				[Token(Token = "0x60058B2")]
				[Address(RVA = "0x87C0A8", Offset = "0x87C0A8", VA = "0x87C0A8")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060058B3 RID: 22707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058B3")]
			[Address(RVA = "0x87C0B0", Offset = "0x87C0B0", VA = "0x87C0B0")]
			public QuadCircleRoom(int radius, int distanceBetweenSpheres)
			{
			}

			// Token: 0x060058B4 RID: 22708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058B4")]
			[Address(RVA = "0x87C0D4", Offset = "0x87C0D4", VA = "0x87C0D4")]
			public void SetRadius(int radius)
			{
			}

			// Token: 0x060058B5 RID: 22709 RVA: 0x000295B0 File Offset: 0x000277B0
			[Token(Token = "0x60058B5")]
			[Address(RVA = "0x87C0E0", Offset = "0x87C0E0", VA = "0x87C0E0", Slot = "4")]
			public override bool Perform(Point origin, GenAction action)
			{
				return default(bool);
			}

			// Token: 0x04009A77 RID: 39543
			[Token(Token = "0x4009A77")]
			[FieldOffset(Offset = "0x10")]
			private int _radius;

			// Token: 0x04009A78 RID: 39544
			[Token(Token = "0x4009A78")]
			[FieldOffset(Offset = "0x14")]
			private int _distanceBetweenSpheres;
		}
	}
}
