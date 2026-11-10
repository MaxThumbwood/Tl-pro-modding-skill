using System;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Net;

namespace Terraria.GameContent
{
	// Token: 0x020009E9 RID: 2537
	[Token(Token = "0x20009E9")]
	public static class UnbreakableWallScan
	{
		// Token: 0x060052AE RID: 21166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052AE")]
		[Address(RVA = "0x7E2C24", Offset = "0x7E2C24", VA = "0x7E2C24")]
		public static void Update(Player player)
		{
		}

		// Token: 0x060052AF RID: 21167 RVA: 0x00026820 File Offset: 0x00024A20
		[Token(Token = "0x60052AF")]
		[Address(RVA = "0x7E2C7C", Offset = "0x7E2C7C", VA = "0x7E2C7C")]
		public static bool InsideUnbreakableWalls(Point pt)
		{
			return default(bool);
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x00026838 File Offset: 0x00024A38
		[Token(Token = "0x60052B0")]
		[Address(RVA = "0x7E2DDC", Offset = "0x7E2DDC", VA = "0x7E2DDC")]
		public static bool LineScan(Point pt, Point dir)
		{
			return default(bool);
		}

		// Token: 0x040096F1 RID: 38641
		[Token(Token = "0x40096F1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int ScanDistance;

		// Token: 0x040096F2 RID: 38642
		[Token(Token = "0x40096F2")]
		[FieldOffset(Offset = "0x4")]
		public static readonly Point[] Directions;

		// Token: 0x020009EA RID: 2538
		[Token(Token = "0x20009EA")]
		public class NetModule : Terraria.Net.NetModule
		{
			// Token: 0x060052B2 RID: 21170 RVA: 0x00026850 File Offset: 0x00024A50
			[Token(Token = "0x60052B2")]
			[Address(RVA = "0x7E32B0", Offset = "0x7E32B0", VA = "0x7E32B0", Slot = "4")]
			public override bool Deserialize(BinaryReader reader, int userId)
			{
				return default(bool);
			}

			// Token: 0x060052B3 RID: 21171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60052B3")]
			[Address(RVA = "0x7E33A8", Offset = "0x7E33A8", VA = "0x7E33A8")]
			internal static void BroadcastChange(Player player)
			{
			}

			// Token: 0x060052B4 RID: 21172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60052B4")]
			[Address(RVA = "0x7E3520", Offset = "0x7E3520", VA = "0x7E3520")]
			public NetModule()
			{
			}
		}
	}
}
