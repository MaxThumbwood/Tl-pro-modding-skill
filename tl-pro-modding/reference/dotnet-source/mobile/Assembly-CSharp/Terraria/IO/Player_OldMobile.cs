using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.IO
{
	// Token: 0x0200067E RID: 1662
	[Token(Token = "0x200067E")]
	public static class Player_OldMobile
	{
		// Token: 0x06003FF4 RID: 16372 RVA: 0x0001F6B0 File Offset: 0x0001D8B0
		[Token(Token = "0x6003FF4")]
		[Address(RVA = "0x1E9011C", Offset = "0x1E9011C", VA = "0x1E9011C")]
		public static bool LoadPlayer(string playerPath, PlayerFileData playerData)
		{
			return default(bool);
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF5")]
		[Address(RVA = "0x1E91B3C", Offset = "0x1E91B3C", VA = "0x1E91B3C")]
		private static void DecryptPlayerData(long offset, long encryptedSize)
		{
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x0001F6C8 File Offset: 0x0001D8C8
		[Token(Token = "0x6003FF6")]
		[Address(RVA = "0x1E91D58", Offset = "0x1E91D58", VA = "0x1E91D58")]
		private static bool IsValidBuff(int buffType)
		{
			return default(bool);
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF7")]
		[Address(RVA = "0x1E91E9C", Offset = "0x1E91E9C", VA = "0x1E91E9C")]
		private static void GivePlayerCoins(Player player, int value)
		{
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x0001F6E0 File Offset: 0x0001D8E0
		[Token(Token = "0x6003FF8")]
		[Address(RVA = "0x1E92688", Offset = "0x1E92688", VA = "0x1E92688")]
		private static bool LoadOld(BinaryReader reader, int release, ref Player player)
		{
			return default(bool);
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x0001F6F8 File Offset: 0x0001D8F8
		[Token(Token = "0x6003FF9")]
		[Address(RVA = "0x1E905EC", Offset = "0x1E905EC", VA = "0x1E905EC")]
		private static bool Load(BinaryReader reader, ref Player player)
		{
			return default(bool);
		}

		// Token: 0x04004B50 RID: 19280
		[Token(Token = "0x4004B50")]
		private const int VERSION_1 = 1;

		// Token: 0x04004B51 RID: 19281
		[Token(Token = "0x4004B51")]
		private const int VERSION_2 = 2;

		// Token: 0x04004B52 RID: 19282
		[Token(Token = "0x4004B52")]
		private const int VERSION_3 = 3;

		// Token: 0x04004B53 RID: 19283
		[Token(Token = "0x4004B53")]
		private const int VERSION_4 = 4;

		// Token: 0x04004B54 RID: 19284
		[Token(Token = "0x4004B54")]
		private const int VERSION_7 = 7;

		// Token: 0x04004B55 RID: 19285
		[Token(Token = "0x4004B55")]
		private const int VERSION_9 = 9;

		// Token: 0x04004B56 RID: 19286
		[Token(Token = "0x4004B56")]
		private const int VERSION_10 = 10;

		// Token: 0x04004B57 RID: 19287
		[Token(Token = "0x4004B57")]
		private const int VERSION_11 = 11;

		// Token: 0x04004B58 RID: 19288
		[Token(Token = "0x4004B58")]
		private const int VERSION_12 = 12;

		// Token: 0x04004B59 RID: 19289
		[Token(Token = "0x4004B59")]
		private const int VERSION_13 = 13;

		// Token: 0x04004B5A RID: 19290
		[Token(Token = "0x4004B5A")]
		private const int VERSION_14 = 14;

		// Token: 0x04004B5B RID: 19291
		[Token(Token = "0x4004B5B")]
		private const int VERSION_15 = 15;

		// Token: 0x04004B5C RID: 19292
		[Token(Token = "0x4004B5C")]
		private const int VERSION_16 = 16;

		// Token: 0x04004B5D RID: 19293
		[Token(Token = "0x4004B5D")]
		private const int VERSION_17 = 17;

		// Token: 0x04004B5E RID: 19294
		[Token(Token = "0x4004B5E")]
		private const int VERSION_18 = 18;

		// Token: 0x04004B5F RID: 19295
		[Token(Token = "0x4004B5F")]
		private const int VERSION_19 = 19;

		// Token: 0x04004B60 RID: 19296
		[Token(Token = "0x4004B60")]
		private const int VERSION_20 = 20;

		// Token: 0x04004B61 RID: 19297
		[Token(Token = "0x4004B61")]
		private const int VERSION_21 = 21;

		// Token: 0x04004B62 RID: 19298
		[Token(Token = "0x4004B62")]
		private const int VERSION_22 = 22;

		// Token: 0x04004B63 RID: 19299
		[Token(Token = "0x4004B63")]
		private const int VERSION_23 = 23;

		// Token: 0x04004B64 RID: 19300
		[Token(Token = "0x4004B64")]
		private const int VERSION_24 = 24;

		// Token: 0x04004B65 RID: 19301
		[Token(Token = "0x4004B65")]
		private const int VERSION_CURRENT = 24;

		// Token: 0x04004B66 RID: 19302
		[Token(Token = "0x4004B66")]
		private const int PLAYER_DATA_VERSION = 24;

		// Token: 0x04004B67 RID: 19303
		[Token(Token = "0x4004B67")]
		[FieldOffset(Offset = "0x0")]
		private static BlowFish playerDecrypter;

		// Token: 0x04004B68 RID: 19304
		[Token(Token = "0x4004B68")]
		[FieldOffset(Offset = "0x4")]
		private static byte[] inputData;
	}
}
