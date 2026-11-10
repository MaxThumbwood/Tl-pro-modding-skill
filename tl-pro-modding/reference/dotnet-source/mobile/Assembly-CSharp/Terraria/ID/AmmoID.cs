using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.ID
{
	// Token: 0x020006A1 RID: 1697
	[Token(Token = "0x20006A1")]
	public static class AmmoID
	{
		// Token: 0x04004EE6 RID: 20198
		[Token(Token = "0x4004EE6")]
		[FieldOffset(Offset = "0x0")]
		public static int None;

		// Token: 0x04004EE7 RID: 20199
		[Token(Token = "0x4004EE7")]
		[FieldOffset(Offset = "0x4")]
		public static int Gel;

		// Token: 0x04004EE8 RID: 20200
		[Token(Token = "0x4004EE8")]
		[FieldOffset(Offset = "0x8")]
		public static int Arrow;

		// Token: 0x04004EE9 RID: 20201
		[Token(Token = "0x4004EE9")]
		[FieldOffset(Offset = "0xC")]
		public static int Coin;

		// Token: 0x04004EEA RID: 20202
		[Token(Token = "0x4004EEA")]
		[FieldOffset(Offset = "0x10")]
		public static int FallenStar;

		// Token: 0x04004EEB RID: 20203
		[Token(Token = "0x4004EEB")]
		[FieldOffset(Offset = "0x14")]
		public static int Bullet;

		// Token: 0x04004EEC RID: 20204
		[Token(Token = "0x4004EEC")]
		[FieldOffset(Offset = "0x18")]
		public static int Sand;

		// Token: 0x04004EED RID: 20205
		[Token(Token = "0x4004EED")]
		[FieldOffset(Offset = "0x1C")]
		public static int Dart;

		// Token: 0x04004EEE RID: 20206
		[Token(Token = "0x4004EEE")]
		[FieldOffset(Offset = "0x20")]
		public static int Rocket;

		// Token: 0x04004EEF RID: 20207
		[Token(Token = "0x4004EEF")]
		[FieldOffset(Offset = "0x24")]
		public static int Solution;

		// Token: 0x04004EF0 RID: 20208
		[Token(Token = "0x4004EF0")]
		[FieldOffset(Offset = "0x28")]
		public static int Flare;

		// Token: 0x04004EF1 RID: 20209
		[Token(Token = "0x4004EF1")]
		[FieldOffset(Offset = "0x2C")]
		public static int Snowball;

		// Token: 0x04004EF2 RID: 20210
		[Token(Token = "0x4004EF2")]
		[FieldOffset(Offset = "0x30")]
		public static int StyngerBolt;

		// Token: 0x04004EF3 RID: 20211
		[Token(Token = "0x4004EF3")]
		[FieldOffset(Offset = "0x34")]
		public static int CandyCorn;

		// Token: 0x04004EF4 RID: 20212
		[Token(Token = "0x4004EF4")]
		[FieldOffset(Offset = "0x38")]
		public static int JackOLantern;

		// Token: 0x04004EF5 RID: 20213
		[Token(Token = "0x4004EF5")]
		[FieldOffset(Offset = "0x3C")]
		public static int Stake;

		// Token: 0x04004EF6 RID: 20214
		[Token(Token = "0x4004EF6")]
		[FieldOffset(Offset = "0x40")]
		public static int NailFriendly;

		// Token: 0x04004EF7 RID: 20215
		[Token(Token = "0x4004EF7")]
		[FieldOffset(Offset = "0x44")]
		public static int Acorn;

		// Token: 0x020006A2 RID: 1698
		[Token(Token = "0x20006A2")]
		public class Sets
		{
			// Token: 0x060040F5 RID: 16629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040F5")]
			[Address(RVA = "0x1EF2E6C", Offset = "0x1EF2E6C", VA = "0x1EF2E6C")]
			public Sets()
			{
			}

			// Token: 0x04004EF8 RID: 20216
			[Token(Token = "0x4004EF8")]
			[FieldOffset(Offset = "0x0")]
			public static SetFactory Factory;

			// Token: 0x04004EF9 RID: 20217
			[Token(Token = "0x4004EF9")]
			[FieldOffset(Offset = "0x4")]
			public static Dictionary<int, Dictionary<int, int>> SpecificLauncherAmmoProjectileMatches;

			// Token: 0x04004EFA RID: 20218
			[Token(Token = "0x4004EFA")]
			[FieldOffset(Offset = "0x8")]
			public static bool[] IsArrow;

			// Token: 0x04004EFB RID: 20219
			[Token(Token = "0x4004EFB")]
			[FieldOffset(Offset = "0xC")]
			public static bool[] IsBullet;

			// Token: 0x04004EFC RID: 20220
			[Token(Token = "0x4004EFC")]
			[FieldOffset(Offset = "0x10")]
			public static bool[] IsSpecialist;
		}
	}
}
