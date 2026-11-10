using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.IO
{
	// Token: 0x0200066D RID: 1645
	[Token(Token = "0x200066D")]
	public class FileMetadata
	{
		// Token: 0x06003F8E RID: 16270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F8E")]
		[Address(RVA = "0x1E85F78", Offset = "0x1E85F78", VA = "0x1E85F78")]
		private FileMetadata()
		{
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F8F")]
		[Address(RVA = "0x1E85F80", Offset = "0x1E85F80", VA = "0x1E85F80")]
		public void Write(BinaryWriter writer)
		{
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F90")]
		[Address(RVA = "0x1E86084", Offset = "0x1E86084", VA = "0x1E86084")]
		public void IncrementAndWrite(BinaryWriter writer)
		{
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F91")]
		[Address(RVA = "0x1E86094", Offset = "0x1E86094", VA = "0x1E86094")]
		public static FileMetadata FromCurrentSettings(FileType type)
		{
			return null;
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F92")]
		[Address(RVA = "0x1E86148", Offset = "0x1E86148", VA = "0x1E86148")]
		public static FileMetadata Read(BinaryReader reader, FileType expectedType)
		{
			return null;
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F93")]
		[Address(RVA = "0x1E8640C", Offset = "0x1E8640C", VA = "0x1E8640C")]
		private void Read(BinaryReader reader)
		{
		}

		// Token: 0x04004974 RID: 18804
		[Token(Token = "0x4004974")]
		public const ulong MAGIC_NUMBER = 27981915666277746UL;

		// Token: 0x04004975 RID: 18805
		[Token(Token = "0x4004975")]
		public const int SIZE = 20;

		// Token: 0x04004976 RID: 18806
		[Token(Token = "0x4004976")]
		[FieldOffset(Offset = "0x8")]
		public FileType Type;

		// Token: 0x04004977 RID: 18807
		[Token(Token = "0x4004977")]
		[FieldOffset(Offset = "0xC")]
		public uint Revision;

		// Token: 0x04004978 RID: 18808
		[Token(Token = "0x4004978")]
		[FieldOffset(Offset = "0x10")]
		public bool IsFavorite;
	}
}
