using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x020007CE RID: 1998
	[Token(Token = "0x20007CE")]
	public struct TileReachCheckSettings
	{
		// Token: 0x060044EB RID: 17643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044EB")]
		[Address(RVA = "0x55E08C", Offset = "0x55E08C", VA = "0x55E08C")]
		public void GetRanges(out int x, out int y)
		{
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044EC")]
		[Address(RVA = "0x55E1F4", Offset = "0x55E1F4", VA = "0x55E1F4")]
		public void GetTileRegion(Player player, out int LX, out int LY, out int HX, out int HY, int TB = 0)
		{
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x00020F70 File Offset: 0x0001F170
		[Token(Token = "0x60044ED")]
		[Address(RVA = "0x55E3D0", Offset = "0x55E3D0", VA = "0x55E3D0")]
		public Rectangle GetTileRegion(Player player, int TB = 0)
		{
			return default(Rectangle);
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044EE")]
		[Address(RVA = "0x55E4A4", Offset = "0x55E4A4", VA = "0x55E4A4")]
		public void GetWorldRegion(Player player, out int LX, out int LY, out int HX, out int HY, int TB = 0)
		{
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x00020F88 File Offset: 0x0001F188
		[Token(Token = "0x60044EF")]
		[Address(RVA = "0x55E584", Offset = "0x55E584", VA = "0x55E584")]
		public Rectangle GetWorldRegion(Player player, int TB = 0)
		{
			return default(Rectangle);
		}

		// Token: 0x04008C65 RID: 35941
		[Token(Token = "0x4008C65")]
		[FieldOffset(Offset = "0x0")]
		public int TileRangeMultiplier;

		// Token: 0x04008C66 RID: 35942
		[Token(Token = "0x4008C66")]
		[FieldOffset(Offset = "0x4")]
		public int? TileReachLimit;

		// Token: 0x04008C67 RID: 35943
		[Token(Token = "0x4008C67")]
		[FieldOffset(Offset = "0xC")]
		public int? OverrideXReach;

		// Token: 0x04008C68 RID: 35944
		[Token(Token = "0x4008C68")]
		[FieldOffset(Offset = "0x14")]
		public int? OverrideYReach;

		// Token: 0x04008C69 RID: 35945
		[Token(Token = "0x4008C69")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TileReachCheckSettings Simple;

		// Token: 0x04008C6A RID: 35946
		[Token(Token = "0x4008C6A")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly TileReachCheckSettings Pylons;
	}
}
