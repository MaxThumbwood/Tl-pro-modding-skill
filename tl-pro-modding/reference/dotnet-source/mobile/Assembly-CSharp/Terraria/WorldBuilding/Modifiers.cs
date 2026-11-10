using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000578 RID: 1400
	[Token(Token = "0x2000578")]
	public static class Modifiers
	{
		// Token: 0x02000579 RID: 1401
		[Token(Token = "0x2000579")]
		public class ShapeScale : GenAction
		{
			// Token: 0x06003A68 RID: 14952 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A68")]
			[Address(RVA = "0x1E01BAC", Offset = "0x1E01BAC", VA = "0x1E01BAC")]
			public ShapeScale(int scale)
			{
			}

			// Token: 0x06003A69 RID: 14953 RVA: 0x0001D670 File Offset: 0x0001B870
			[Token(Token = "0x6003A69")]
			[Address(RVA = "0x1E01BD4", Offset = "0x1E01BD4", VA = "0x1E01BD4", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x04004605 RID: 17925
			[Token(Token = "0x4004605")]
			[FieldOffset(Offset = "0x14")]
			private int _scale;
		}

		// Token: 0x0200057A RID: 1402
		[Token(Token = "0x200057A")]
		public class Expand : GenAction
		{
			// Token: 0x06003A6A RID: 14954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A6A")]
			[Address(RVA = "0x1E01D74", Offset = "0x1E01D74", VA = "0x1E01D74")]
			public Expand(int expansion)
			{
			}

			// Token: 0x06003A6B RID: 14955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A6B")]
			[Address(RVA = "0x1E01DA0", Offset = "0x1E01DA0", VA = "0x1E01DA0")]
			public Expand(int xExpansion, int yExpansion)
			{
			}

			// Token: 0x06003A6C RID: 14956 RVA: 0x0001D688 File Offset: 0x0001B888
			[Token(Token = "0x6003A6C")]
			[Address(RVA = "0x1E01DD0", Offset = "0x1E01DD0", VA = "0x1E01DD0", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x04004606 RID: 17926
			[Token(Token = "0x4004606")]
			[FieldOffset(Offset = "0x14")]
			private int _xExpansion;

			// Token: 0x04004607 RID: 17927
			[Token(Token = "0x4004607")]
			[FieldOffset(Offset = "0x18")]
			private int _yExpansion;
		}

		// Token: 0x0200057B RID: 1403
		[Token(Token = "0x200057B")]
		public class RadialDither : GenAction
		{
			// Token: 0x06003A6D RID: 14957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A6D")]
			[Address(RVA = "0x1E01EC8", Offset = "0x1E01EC8", VA = "0x1E01EC8")]
			public RadialDither(double innerRadius, double outerRadius)
			{
			}

			// Token: 0x06003A6E RID: 14958 RVA: 0x0001D6A0 File Offset: 0x0001B8A0
			[Token(Token = "0x6003A6E")]
			[Address(RVA = "0x1E01F00", Offset = "0x1E01F00", VA = "0x1E01F00", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x04004608 RID: 17928
			[Token(Token = "0x4004608")]
			[FieldOffset(Offset = "0x18")]
			private double _innerRadius;

			// Token: 0x04004609 RID: 17929
			[Token(Token = "0x4004609")]
			[FieldOffset(Offset = "0x20")]
			private double _outerRadius;
		}

		// Token: 0x0200057C RID: 1404
		[Token(Token = "0x200057C")]
		public class Blotches : GenAction
		{
			// Token: 0x06003A6F RID: 14959 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A6F")]
			[Address(RVA = "0x1E02130", Offset = "0x1E02130", VA = "0x1E02130")]
			public Blotches(int scale = 2, double chance = 0.3)
			{
			}

			// Token: 0x06003A70 RID: 14960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A70")]
			[Address(RVA = "0x1E0216C", Offset = "0x1E0216C", VA = "0x1E0216C")]
			public Blotches(int xScale, int yScale, double chance = 0.3)
			{
			}

			// Token: 0x06003A71 RID: 14961 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A71")]
			[Address(RVA = "0x1E021AC", Offset = "0x1E021AC", VA = "0x1E021AC")]
			public Blotches(int leftScale, int upScale, int rightScale, int downScale, double chance = 0.3)
			{
			}

			// Token: 0x06003A72 RID: 14962 RVA: 0x0001D6B8 File Offset: 0x0001B8B8
			[Token(Token = "0x6003A72")]
			[Address(RVA = "0x1E021F4", Offset = "0x1E021F4", VA = "0x1E021F4", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x0400460A RID: 17930
			[Token(Token = "0x400460A")]
			[FieldOffset(Offset = "0x14")]
			private int _minX;

			// Token: 0x0400460B RID: 17931
			[Token(Token = "0x400460B")]
			[FieldOffset(Offset = "0x18")]
			private int _minY;

			// Token: 0x0400460C RID: 17932
			[Token(Token = "0x400460C")]
			[FieldOffset(Offset = "0x1C")]
			private int _maxX;

			// Token: 0x0400460D RID: 17933
			[Token(Token = "0x400460D")]
			[FieldOffset(Offset = "0x20")]
			private int _maxY;

			// Token: 0x0400460E RID: 17934
			[Token(Token = "0x400460E")]
			[FieldOffset(Offset = "0x28")]
			private double _chance;
		}

		// Token: 0x0200057D RID: 1405
		[Token(Token = "0x200057D")]
		public class InShape : GenAction
		{
			// Token: 0x06003A73 RID: 14963 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A73")]
			[Address(RVA = "0x1E02470", Offset = "0x1E02470", VA = "0x1E02470")]
			public InShape(ShapeData shapeData)
			{
			}

			// Token: 0x06003A74 RID: 14964 RVA: 0x0001D6D0 File Offset: 0x0001B8D0
			[Token(Token = "0x6003A74")]
			[Address(RVA = "0x1E02498", Offset = "0x1E02498", VA = "0x1E02498", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x0400460F RID: 17935
			[Token(Token = "0x400460F")]
			[FieldOffset(Offset = "0x14")]
			private readonly ShapeData _shapeData;
		}

		// Token: 0x0200057E RID: 1406
		[Token(Token = "0x200057E")]
		public class NotInShape : GenAction
		{
			// Token: 0x06003A75 RID: 14965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A75")]
			[Address(RVA = "0x1E02654", Offset = "0x1E02654", VA = "0x1E02654")]
			public NotInShape(ShapeData shapeData)
			{
			}

			// Token: 0x06003A76 RID: 14966 RVA: 0x0001D6E8 File Offset: 0x0001B8E8
			[Token(Token = "0x6003A76")]
			[Address(RVA = "0x1E0267C", Offset = "0x1E0267C", VA = "0x1E0267C", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x04004610 RID: 17936
			[Token(Token = "0x4004610")]
			[FieldOffset(Offset = "0x14")]
			private readonly ShapeData _shapeData;
		}

		// Token: 0x0200057F RID: 1407
		[Token(Token = "0x200057F")]
		public class Conditions : GenAction
		{
			// Token: 0x06003A77 RID: 14967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A77")]
			[Address(RVA = "0x1E027A4", Offset = "0x1E027A4", VA = "0x1E027A4")]
			public Conditions(GenCondition[] conditions)
			{
			}

			// Token: 0x06003A78 RID: 14968 RVA: 0x0001D700 File Offset: 0x0001B900
			[Token(Token = "0x6003A78")]
			[Address(RVA = "0x1E027CC", Offset = "0x1E027CC", VA = "0x1E027CC", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x04004611 RID: 17937
			[Token(Token = "0x4004611")]
			[FieldOffset(Offset = "0x14")]
			private readonly GenCondition[] _conditions;
		}

		// Token: 0x02000580 RID: 1408
		[Token(Token = "0x2000580")]
		public class OnlyWalls : GenAction
		{
			// Token: 0x06003A79 RID: 14969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A79")]
			[Address(RVA = "0x1E028CC", Offset = "0x1E028CC", VA = "0x1E028CC")]
			public OnlyWalls(ushort[] types)
			{
			}

			// Token: 0x06003A7A RID: 14970 RVA: 0x0001D718 File Offset: 0x0001B918
			[Token(Token = "0x6003A7A")]
			[Address(RVA = "0x1E028F4", Offset = "0x1E028F4", VA = "0x1E028F4", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x04004612 RID: 17938
			[Token(Token = "0x4004612")]
			[FieldOffset(Offset = "0x14")]
			private ushort[] _types;
		}

		// Token: 0x02000581 RID: 1409
		[Token(Token = "0x2000581")]
		public class OnlyTiles : GenAction
		{
			// Token: 0x06003A7B RID: 14971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A7B")]
			[Address(RVA = "0x1E02B24", Offset = "0x1E02B24", VA = "0x1E02B24")]
			public OnlyTiles(ushort[] types)
			{
			}

			// Token: 0x06003A7C RID: 14972 RVA: 0x0001D730 File Offset: 0x0001B930
			[Token(Token = "0x6003A7C")]
			[Address(RVA = "0x1E02B4C", Offset = "0x1E02B4C", VA = "0x1E02B4C", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x04004613 RID: 17939
			[Token(Token = "0x4004613")]
			[FieldOffset(Offset = "0x14")]
			private ushort[] _types;
		}

		// Token: 0x02000582 RID: 1410
		[Token(Token = "0x2000582")]
		public class Checkerboard : GenAction
		{
			// Token: 0x06003A7D RID: 14973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A7D")]
			[Address(RVA = "0x1E02EB8", Offset = "0x1E02EB8", VA = "0x1E02EB8")]
			public Checkerboard(int percentile)
			{
			}

			// Token: 0x06003A7E RID: 14974 RVA: 0x0001D748 File Offset: 0x0001B948
			[Token(Token = "0x6003A7E")]
			[Address(RVA = "0x1E02EE0", Offset = "0x1E02EE0", VA = "0x1E02EE0", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x04004614 RID: 17940
			[Token(Token = "0x4004614")]
			[FieldOffset(Offset = "0x14")]
			private int _percentile;
		}

		// Token: 0x02000583 RID: 1411
		[Token(Token = "0x2000583")]
		public class IsTouching : GenAction
		{
			// Token: 0x06003A7F RID: 14975 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A7F")]
			[Address(RVA = "0x1E02F98", Offset = "0x1E02F98", VA = "0x1E02F98")]
			public IsTouching(bool useDiagonals, ushort[] tileIds)
			{
			}

			// Token: 0x06003A80 RID: 14976 RVA: 0x0001D760 File Offset: 0x0001B960
			[Token(Token = "0x6003A80")]
			[Address(RVA = "0x1E02FC8", Offset = "0x1E02FC8", VA = "0x1E02FC8", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x04004615 RID: 17941
			[Token(Token = "0x4004615")]
			[FieldOffset(Offset = "0x0")]
			private static readonly int[] DIRECTIONS;

			// Token: 0x04004616 RID: 17942
			[Token(Token = "0x4004616")]
			[FieldOffset(Offset = "0x11")]
			private bool _useDiagonals;

			// Token: 0x04004617 RID: 17943
			[Token(Token = "0x4004617")]
			[FieldOffset(Offset = "0x14")]
			private ushort[] _tileIds;
		}

		// Token: 0x02000584 RID: 1412
		[Token(Token = "0x2000584")]
		public class NotTouching : GenAction
		{
			// Token: 0x06003A82 RID: 14978 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A82")]
			[Address(RVA = "0x1E03414", Offset = "0x1E03414", VA = "0x1E03414")]
			public NotTouching(bool useDiagonals, ushort[] tileIds)
			{
			}

			// Token: 0x06003A83 RID: 14979 RVA: 0x0001D778 File Offset: 0x0001B978
			[Token(Token = "0x6003A83")]
			[Address(RVA = "0x1E03444", Offset = "0x1E03444", VA = "0x1E03444", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x04004618 RID: 17944
			[Token(Token = "0x4004618")]
			[FieldOffset(Offset = "0x0")]
			private static readonly int[] DIRECTIONS;

			// Token: 0x04004619 RID: 17945
			[Token(Token = "0x4004619")]
			[FieldOffset(Offset = "0x11")]
			private bool _useDiagonals;

			// Token: 0x0400461A RID: 17946
			[Token(Token = "0x400461A")]
			[FieldOffset(Offset = "0x14")]
			private ushort[] _tileIds;
		}

		// Token: 0x02000585 RID: 1413
		[Token(Token = "0x2000585")]
		public class IsTouchingAir : GenAction
		{
			// Token: 0x06003A85 RID: 14981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A85")]
			[Address(RVA = "0x1E03890", Offset = "0x1E03890", VA = "0x1E03890")]
			public IsTouchingAir(bool useDiagonals = false)
			{
			}

			// Token: 0x06003A86 RID: 14982 RVA: 0x0001D790 File Offset: 0x0001B990
			[Token(Token = "0x6003A86")]
			[Address(RVA = "0x1E038B8", Offset = "0x1E038B8", VA = "0x1E038B8", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x0400461B RID: 17947
			[Token(Token = "0x400461B")]
			[FieldOffset(Offset = "0x0")]
			private static readonly int[] DIRECTIONS;

			// Token: 0x0400461C RID: 17948
			[Token(Token = "0x400461C")]
			[FieldOffset(Offset = "0x11")]
			private bool _useDiagonals;
		}

		// Token: 0x02000586 RID: 1414
		[Token(Token = "0x2000586")]
		public class SkipTiles : GenAction
		{
			// Token: 0x06003A88 RID: 14984 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A88")]
			[Address(RVA = "0x1E03C10", Offset = "0x1E03C10", VA = "0x1E03C10")]
			public SkipTiles(ushort[] types)
			{
			}

			// Token: 0x06003A89 RID: 14985 RVA: 0x0001D7A8 File Offset: 0x0001B9A8
			[Token(Token = "0x6003A89")]
			[Address(RVA = "0x1E03C38", Offset = "0x1E03C38", VA = "0x1E03C38", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x0400461D RID: 17949
			[Token(Token = "0x400461D")]
			[FieldOffset(Offset = "0x14")]
			private ushort[] _types;
		}

		// Token: 0x02000587 RID: 1415
		[Token(Token = "0x2000587")]
		public class HasLiquid : GenAction
		{
			// Token: 0x06003A8A RID: 14986 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A8A")]
			[Address(RVA = "0x1E03FF0", Offset = "0x1E03FF0", VA = "0x1E03FF0")]
			public HasLiquid(int liquidLevel = -1, int liquidType = -1)
			{
			}

			// Token: 0x06003A8B RID: 14987 RVA: 0x0001D7C0 File Offset: 0x0001B9C0
			[Token(Token = "0x6003A8B")]
			[Address(RVA = "0x1E04020", Offset = "0x1E04020", VA = "0x1E04020", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x0400461E RID: 17950
			[Token(Token = "0x400461E")]
			[FieldOffset(Offset = "0x14")]
			private int _liquidType;

			// Token: 0x0400461F RID: 17951
			[Token(Token = "0x400461F")]
			[FieldOffset(Offset = "0x18")]
			private int _liquidLevel;
		}

		// Token: 0x02000588 RID: 1416
		[Token(Token = "0x2000588")]
		public class NoLiquid : GenAction
		{
			// Token: 0x06003A8C RID: 14988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A8C")]
			[Address(RVA = "0x1E04318", Offset = "0x1E04318", VA = "0x1E04318")]
			public NoLiquid(int liquidType = -1)
			{
			}

			// Token: 0x06003A8D RID: 14989 RVA: 0x0001D7D8 File Offset: 0x0001B9D8
			[Token(Token = "0x6003A8D")]
			[Address(RVA = "0x1E04340", Offset = "0x1E04340", VA = "0x1E04340", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x04004620 RID: 17952
			[Token(Token = "0x4004620")]
			[FieldOffset(Offset = "0x14")]
			private int _liquidType;
		}

		// Token: 0x02000589 RID: 1417
		[Token(Token = "0x2000589")]
		public class SkipWalls : GenAction
		{
			// Token: 0x06003A8E RID: 14990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A8E")]
			[Address(RVA = "0x1E04590", Offset = "0x1E04590", VA = "0x1E04590")]
			public SkipWalls(ushort[] types)
			{
			}

			// Token: 0x06003A8F RID: 14991 RVA: 0x0001D7F0 File Offset: 0x0001B9F0
			[Token(Token = "0x6003A8F")]
			[Address(RVA = "0x1E045B8", Offset = "0x1E045B8", VA = "0x1E045B8", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x04004621 RID: 17953
			[Token(Token = "0x4004621")]
			[FieldOffset(Offset = "0x14")]
			private ushort[] _types;
		}

		// Token: 0x0200058A RID: 1418
		[Token(Token = "0x200058A")]
		public class SkipUnbreakableWalledTiles : GenAction
		{
			// Token: 0x06003A90 RID: 14992 RVA: 0x0001D808 File Offset: 0x0001BA08
			[Token(Token = "0x6003A90")]
			[Address(RVA = "0x1E047E8", Offset = "0x1E047E8", VA = "0x1E047E8", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x06003A91 RID: 14993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A91")]
			[Address(RVA = "0x1E04AB8", Offset = "0x1E04AB8", VA = "0x1E04AB8")]
			public SkipUnbreakableWalledTiles()
			{
			}
		}

		// Token: 0x0200058B RID: 1419
		[Token(Token = "0x200058B")]
		public class IsAboveHeight : GenAction
		{
			// Token: 0x06003A92 RID: 14994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A92")]
			[Address(RVA = "0x1E04AC8", Offset = "0x1E04AC8", VA = "0x1E04AC8")]
			public IsAboveHeight(int y, bool inclusive = false)
			{
			}

			// Token: 0x06003A93 RID: 14995 RVA: 0x0001D820 File Offset: 0x0001BA20
			[Token(Token = "0x6003A93")]
			[Address(RVA = "0x1E04AF8", Offset = "0x1E04AF8", VA = "0x1E04AF8", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x04004622 RID: 17954
			[Token(Token = "0x4004622")]
			[FieldOffset(Offset = "0x14")]
			private int _y;

			// Token: 0x04004623 RID: 17955
			[Token(Token = "0x4004623")]
			[FieldOffset(Offset = "0x18")]
			private bool _inclusive;
		}

		// Token: 0x0200058C RID: 1420
		[Token(Token = "0x200058C")]
		public class IsBelowHeight : GenAction
		{
			// Token: 0x06003A94 RID: 14996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A94")]
			[Address(RVA = "0x1E04BB0", Offset = "0x1E04BB0", VA = "0x1E04BB0")]
			public IsBelowHeight(int y, bool inclusive = false)
			{
			}

			// Token: 0x06003A95 RID: 14997 RVA: 0x0001D838 File Offset: 0x0001BA38
			[Token(Token = "0x6003A95")]
			[Address(RVA = "0x1E04BE0", Offset = "0x1E04BE0", VA = "0x1E04BE0", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x04004624 RID: 17956
			[Token(Token = "0x4004624")]
			[FieldOffset(Offset = "0x14")]
			private int _y;

			// Token: 0x04004625 RID: 17957
			[Token(Token = "0x4004625")]
			[FieldOffset(Offset = "0x18")]
			private bool _inclusive;
		}

		// Token: 0x0200058D RID: 1421
		[Token(Token = "0x200058D")]
		public class IsEmpty : GenAction
		{
			// Token: 0x06003A96 RID: 14998 RVA: 0x0001D850 File Offset: 0x0001BA50
			[Token(Token = "0x6003A96")]
			[Address(RVA = "0x1E04C98", Offset = "0x1E04C98", VA = "0x1E04C98", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x06003A97 RID: 14999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A97")]
			[Address(RVA = "0x1E04E7C", Offset = "0x1E04E7C", VA = "0x1E04E7C")]
			public IsEmpty()
			{
			}
		}

		// Token: 0x0200058E RID: 1422
		[Token(Token = "0x200058E")]
		public class IsSolid : GenAction
		{
			// Token: 0x06003A98 RID: 15000 RVA: 0x0001D868 File Offset: 0x0001BA68
			[Token(Token = "0x6003A98")]
			[Address(RVA = "0x1E04E8C", Offset = "0x1E04E8C", VA = "0x1E04E8C", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x06003A99 RID: 15001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A99")]
			[Address(RVA = "0x1E050BC", Offset = "0x1E050BC", VA = "0x1E050BC")]
			public IsSolid()
			{
			}
		}

		// Token: 0x0200058F RID: 1423
		[Token(Token = "0x200058F")]
		public class IsNotSolid : GenAction
		{
			// Token: 0x06003A9A RID: 15002 RVA: 0x0001D880 File Offset: 0x0001BA80
			[Token(Token = "0x6003A9A")]
			[Address(RVA = "0x1E050CC", Offset = "0x1E050CC", VA = "0x1E050CC", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x06003A9B RID: 15003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A9B")]
			[Address(RVA = "0x1E052FC", Offset = "0x1E052FC", VA = "0x1E052FC")]
			public IsNotSolid()
			{
			}
		}

		// Token: 0x02000590 RID: 1424
		[Token(Token = "0x2000590")]
		public class RectangleMask : GenAction
		{
			// Token: 0x06003A9C RID: 15004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A9C")]
			[Address(RVA = "0x1E0530C", Offset = "0x1E0530C", VA = "0x1E0530C")]
			public RectangleMask(int xMin, int xMax, int yMin, int yMax)
			{
			}

			// Token: 0x06003A9D RID: 15005 RVA: 0x0001D898 File Offset: 0x0001BA98
			[Token(Token = "0x6003A9D")]
			[Address(RVA = "0x1E0534C", Offset = "0x1E0534C", VA = "0x1E0534C", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x04004626 RID: 17958
			[Token(Token = "0x4004626")]
			[FieldOffset(Offset = "0x14")]
			private int _xMin;

			// Token: 0x04004627 RID: 17959
			[Token(Token = "0x4004627")]
			[FieldOffset(Offset = "0x18")]
			private int _yMin;

			// Token: 0x04004628 RID: 17960
			[Token(Token = "0x4004628")]
			[FieldOffset(Offset = "0x1C")]
			private int _xMax;

			// Token: 0x04004629 RID: 17961
			[Token(Token = "0x4004629")]
			[FieldOffset(Offset = "0x20")]
			private int _yMax;
		}

		// Token: 0x02000591 RID: 1425
		[Token(Token = "0x2000591")]
		public class Offset : GenAction
		{
			// Token: 0x06003A9E RID: 15006 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A9E")]
			[Address(RVA = "0x1E05418", Offset = "0x1E05418", VA = "0x1E05418")]
			public Offset(int x, int y)
			{
			}

			// Token: 0x06003A9F RID: 15007 RVA: 0x0001D8B0 File Offset: 0x0001BAB0
			[Token(Token = "0x6003A9F")]
			[Address(RVA = "0x1E05448", Offset = "0x1E05448", VA = "0x1E05448", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x0400462A RID: 17962
			[Token(Token = "0x400462A")]
			[FieldOffset(Offset = "0x14")]
			private int _xOffset;

			// Token: 0x0400462B RID: 17963
			[Token(Token = "0x400462B")]
			[FieldOffset(Offset = "0x18")]
			private int _yOffset;
		}

		// Token: 0x02000592 RID: 1426
		[Token(Token = "0x2000592")]
		public class Dither : GenAction
		{
			// Token: 0x06003AA0 RID: 15008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AA0")]
			[Address(RVA = "0x1E054CC", Offset = "0x1E054CC", VA = "0x1E054CC")]
			public Dither(double failureChance = 0.5)
			{
			}

			// Token: 0x06003AA1 RID: 15009 RVA: 0x0001D8C8 File Offset: 0x0001BAC8
			[Token(Token = "0x6003AA1")]
			[Address(RVA = "0x1E054FC", Offset = "0x1E054FC", VA = "0x1E054FC", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x0400462C RID: 17964
			[Token(Token = "0x400462C")]
			[FieldOffset(Offset = "0x18")]
			private double _failureChance;
		}

		// Token: 0x02000593 RID: 1427
		[Token(Token = "0x2000593")]
		public class Flip : GenAction
		{
			// Token: 0x06003AA2 RID: 15010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AA2")]
			[Address(RVA = "0x1E055BC", Offset = "0x1E055BC", VA = "0x1E055BC")]
			public Flip(bool flipX, bool flipY)
			{
			}

			// Token: 0x06003AA3 RID: 15011 RVA: 0x0001D8E0 File Offset: 0x0001BAE0
			[Token(Token = "0x6003AA3")]
			[Address(RVA = "0x1E055EC", Offset = "0x1E055EC", VA = "0x1E055EC", Slot = "4")]
			public override bool Apply(Point origin, int x, int y, object[] args)
			{
				return default(bool);
			}

			// Token: 0x0400462D RID: 17965
			[Token(Token = "0x400462D")]
			[FieldOffset(Offset = "0x11")]
			private bool _flipX;

			// Token: 0x0400462E RID: 17966
			[Token(Token = "0x400462E")]
			[FieldOffset(Offset = "0x12")]
			private bool _flipY;
		}
	}
}
