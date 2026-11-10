using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.IO
{
	// Token: 0x02000681 RID: 1665
	[Token(Token = "0x2000681")]
	public class TilInfo_OldMobile
	{
		// Token: 0x06004000 RID: 16384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004000")]
		[Address(RVA = "0x1EB66F0", Offset = "0x1EB66F0", VA = "0x1EB66F0")]
		private void PatchFrameY(int release, int type, ref short frameY)
		{
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x0001F740 File Offset: 0x0001D940
		[Token(Token = "0x6004001")]
		[Address(RVA = "0x1EB6718", Offset = "0x1EB6718", VA = "0x1EB6718")]
		private byte ConverTileColor(byte input)
		{
			return 0;
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x0001F758 File Offset: 0x0001D958
		[Token(Token = "0x6004002")]
		[Address(RVA = "0x1EB6728", Offset = "0x1EB6728", VA = "0x1EB6728")]
		public bool Load(BinaryReader reader, int release)
		{
			return default(bool);
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004003")]
		[Address(RVA = "0x1EB7C50", Offset = "0x1EB7C50", VA = "0x1EB7C50")]
		private void CleanItemsStoredInTiles()
		{
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004004")]
		[Address(RVA = "0x1EB8E28", Offset = "0x1EB8E28", VA = "0x1EB8E28")]
		private void FixChairFrame(int i, int j)
		{
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004005")]
		[Address(RVA = "0x1EB7E40", Offset = "0x1EB7E40", VA = "0x1EB7E40")]
		private void CheckWeaponsRack(int i, int j)
		{
		}

		// Token: 0x06004006 RID: 16390 RVA: 0x0001F770 File Offset: 0x0001D970
		[Token(Token = "0x6004006")]
		[Address(RVA = "0x1EB8FEC", Offset = "0x1EB8FEC", VA = "0x1EB8FEC")]
		public bool ItemFitsWeaponRack(Item i)
		{
			return default(bool);
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004007")]
		[Address(RVA = "0x1EB9070", Offset = "0x1EB9070", VA = "0x1EB9070")]
		public void PlaceWeapon(int x, int y, Item item)
		{
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004008")]
		[Address(RVA = "0x1EB82CC", Offset = "0x1EB82CC", VA = "0x1EB82CC")]
		private void CheckMannequin(int i, int j)
		{
		}

		// Token: 0x06004009 RID: 16393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004009")]
		[Address(RVA = "0x1EB97C4", Offset = "0x1EB97C4", VA = "0x1EB97C4")]
		public TilInfo_OldMobile()
		{
		}
	}
}
