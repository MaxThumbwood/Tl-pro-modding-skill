using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.GameContent
{
	// Token: 0x0200093C RID: 2364
	[Token(Token = "0x200093C")]
	public class AmbientWindSystem
	{
		// Token: 0x06004EFA RID: 20218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EFA")]
		[Address(RVA = "0x743BFC", Offset = "0x743BFC", VA = "0x743BFC")]
		public AmbientWindSystem()
		{
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EFB")]
		[Address(RVA = "0x743CE0", Offset = "0x743CE0", VA = "0x743CE0")]
		public void Update()
		{
		}

		// Token: 0x06004EFC RID: 20220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EFC")]
		[Address(RVA = "0x7445CC", Offset = "0x7445CC", VA = "0x7445CC")]
		private void SpawnAirborneWind()
		{
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x00024C60 File Offset: 0x00022E60
		[Token(Token = "0x6004EFD")]
		[Address(RVA = "0x744000", Offset = "0x744000", VA = "0x744000")]
		private Rectangle GetTileWorkSpace()
		{
			return default(Rectangle);
		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EFE")]
		[Address(RVA = "0x7442E0", Offset = "0x7442E0", VA = "0x7442E0")]
		private void TrySpawningWind(int x, int y)
		{
		}

		// Token: 0x06004EFF RID: 20223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EFF")]
		[Address(RVA = "0x7447A8", Offset = "0x7447A8", VA = "0x7447A8")]
		private void SpawnAirborneCloud(int x, int y)
		{
		}

		// Token: 0x06004F00 RID: 20224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F00")]
		[Address(RVA = "0x744E1C", Offset = "0x744E1C", VA = "0x744E1C")]
		private void SpawnFloorCloud(int x, int y)
		{
		}

		// Token: 0x06004F01 RID: 20225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F01")]
		[Address(RVA = "0x744108", Offset = "0x744108", VA = "0x744108")]
		private void TestAirCloud(int x, int y)
		{
		}

		// Token: 0x06004F02 RID: 20226 RVA: 0x00024C78 File Offset: 0x00022E78
		[Token(Token = "0x6004F02")]
		[Address(RVA = "0x745120", Offset = "0x745120", VA = "0x745120")]
		private bool DoesTileAllowWind(Tile t)
		{
			return default(bool);
		}

		// Token: 0x04009352 RID: 37714
		[Token(Token = "0x4009352")]
		[FieldOffset(Offset = "0x8")]
		private UnifiedRandom _random;

		// Token: 0x04009353 RID: 37715
		[Token(Token = "0x4009353")]
		[FieldOffset(Offset = "0xC")]
		private List<Point> _spotsForAirboneWind;

		// Token: 0x04009354 RID: 37716
		[Token(Token = "0x4009354")]
		[FieldOffset(Offset = "0x10")]
		private int _updatesCounter;

		// Token: 0x04009355 RID: 37717
		[Token(Token = "0x4009355")]
		[FieldOffset(Offset = "0x14")]
		private int _lastFrame;

		// Token: 0x04009356 RID: 37718
		[Token(Token = "0x4009356")]
		[FieldOffset(Offset = "0x18")]
		private float _airSpaceTests;

		// Token: 0x04009357 RID: 37719
		[Token(Token = "0x4009357")]
		[FieldOffset(Offset = "0x1C")]
		private float _floorSpaceTests;
	}
}
