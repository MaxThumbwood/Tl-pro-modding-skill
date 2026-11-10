using System;
using System.Collections.Generic;
using System.Globalization;
using Il2CppDummyDll;

namespace Terraria.Localization
{
	// Token: 0x0200065A RID: 1626
	[Token(Token = "0x200065A")]
	public class GameCulture
	{
		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06003EFA RID: 16122 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003EFB RID: 16123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007ED")]
		public static GameCulture DefaultCulture
		{
			[Token(Token = "0x6003EFA")]
			[Address(RVA = "0x1E7A61C", Offset = "0x1E7A61C", VA = "0x1E7A61C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EFB")]
			[Address(RVA = "0x1E7A680", Offset = "0x1E7A680", VA = "0x1E7A680")]
			set
			{
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06003EFC RID: 16124 RVA: 0x0001F200 File Offset: 0x0001D400
		[Token(Token = "0x170007EE")]
		public bool IsActive
		{
			[Token(Token = "0x6003EFC")]
			[Address(RVA = "0x1E7A6E8", Offset = "0x1E7A6E8", VA = "0x1E7A6E8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06003EFD RID: 16125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007EF")]
		public string Name
		{
			[Token(Token = "0x6003EFD")]
			[Address(RVA = "0x1E7A838", Offset = "0x1E7A838", VA = "0x1E7A838")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EFE")]
		[Address(RVA = "0x1E7A864", Offset = "0x1E7A864", VA = "0x1E7A864")]
		public static GameCulture FromCultureName(GameCulture.CultureName name)
		{
			return null;
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EFF")]
		[Address(RVA = "0x1E7A9C4", Offset = "0x1E7A9C4", VA = "0x1E7A9C4")]
		public static GameCulture FromLegacyId(int id)
		{
			return null;
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F00")]
		[Address(RVA = "0x1E7AB2C", Offset = "0x1E7AB2C", VA = "0x1E7AB2C")]
		public static GameCulture FromName(string name)
		{
			return null;
		}

		// Token: 0x06003F02 RID: 16130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F02")]
		[Address(RVA = "0x1E7B33C", Offset = "0x1E7B33C", VA = "0x1E7B33C")]
		public GameCulture(string name, int legacyId)
		{
		}

		// Token: 0x06003F03 RID: 16131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F03")]
		[Address(RVA = "0x1E7B404", Offset = "0x1E7B404", VA = "0x1E7B404")]
		private static void RegisterLegacyCulture(GameCulture culture, int legacyId)
		{
		}

		// Token: 0x04004923 RID: 18723
		[Token(Token = "0x4004923")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<GameCulture.CultureName, GameCulture> _NamedCultures;

		// Token: 0x04004924 RID: 18724
		[Token(Token = "0x4004924")]
		[FieldOffset(Offset = "0x4")]
		private static GameCulture <DefaultCulture>k__BackingField;

		// Token: 0x04004925 RID: 18725
		[Token(Token = "0x4004925")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<int, GameCulture> _legacyCultures;

		// Token: 0x04004926 RID: 18726
		[Token(Token = "0x4004926")]
		[FieldOffset(Offset = "0x8")]
		public readonly CultureInfo CultureInfo;

		// Token: 0x04004927 RID: 18727
		[Token(Token = "0x4004927")]
		[FieldOffset(Offset = "0xC")]
		public readonly int LegacyId;

		// Token: 0x0200065B RID: 1627
		[Token(Token = "0x200065B")]
		public enum CultureName
		{
			// Token: 0x04004929 RID: 18729
			[Token(Token = "0x4004929")]
			English = 1,
			// Token: 0x0400492A RID: 18730
			[Token(Token = "0x400492A")]
			German,
			// Token: 0x0400492B RID: 18731
			[Token(Token = "0x400492B")]
			Italian,
			// Token: 0x0400492C RID: 18732
			[Token(Token = "0x400492C")]
			French,
			// Token: 0x0400492D RID: 18733
			[Token(Token = "0x400492D")]
			Spanish,
			// Token: 0x0400492E RID: 18734
			[Token(Token = "0x400492E")]
			Russian,
			// Token: 0x0400492F RID: 18735
			[Token(Token = "0x400492F")]
			Chinese,
			// Token: 0x04004930 RID: 18736
			[Token(Token = "0x4004930")]
			Portuguese,
			// Token: 0x04004931 RID: 18737
			[Token(Token = "0x4004931")]
			Polish,
			// Token: 0x04004932 RID: 18738
			[Token(Token = "0x4004932")]
			Japanese,
			// Token: 0x04004933 RID: 18739
			[Token(Token = "0x4004933")]
			Korean,
			// Token: 0x04004934 RID: 18740
			[Token(Token = "0x4004934")]
			ChineseTraditional,
			// Token: 0x04004935 RID: 18741
			[Token(Token = "0x4004935")]
			Unknown = 9999
		}

		// Token: 0x0200065C RID: 1628
		[Token(Token = "0x200065C")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06003F04 RID: 16132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003F04")]
			[Address(RVA = "0x1E7AD24", Offset = "0x1E7AD24", VA = "0x1E7AD24")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06003F05 RID: 16133 RVA: 0x0001F218 File Offset: 0x0001D418
			[Token(Token = "0x6003F05")]
			[Address(RVA = "0x1E7B54C", Offset = "0x1E7B54C", VA = "0x1E7B54C")]
			internal bool <FromName>b__0(GameCulture culture)
			{
				return default(bool);
			}

			// Token: 0x04004936 RID: 18742
			[Token(Token = "0x4004936")]
			[FieldOffset(Offset = "0x8")]
			public string name;
		}
	}
}
