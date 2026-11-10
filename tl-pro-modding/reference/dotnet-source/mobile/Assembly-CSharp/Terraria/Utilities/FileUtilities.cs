using System;
using System.IO;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace Terraria.Utilities
{
	// Token: 0x020005CF RID: 1487
	[Token(Token = "0x20005CF")]
	public static class FileUtilities
	{
		// Token: 0x06003BB7 RID: 15287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB7")]
		[Address(RVA = "0x1E13A48", Offset = "0x1E13A48", VA = "0x1E13A48")]
		public static string WildcardToRegex(string pattern)
		{
			return null;
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB8")]
		[Address(RVA = "0x1E13BB4", Offset = "0x1E13BB4", VA = "0x1E13BB4")]
		public static string CleanSwitchPath(string path)
		{
			return null;
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB9")]
		[Address(RVA = "0x1E13C80", Offset = "0x1E13C80", VA = "0x1E13C80")]
		public static string[] GetFiles(string path, string searchPattern)
		{
			return null;
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBA")]
		[Address(RVA = "0x1E13C88", Offset = "0x1E13C88", VA = "0x1E13C88")]
		public static void SetAttributes(string path, FileAttributes fileAttributes)
		{
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBB")]
		[Address(RVA = "0x1E13C90", Offset = "0x1E13C90", VA = "0x1E13C90")]
		public static void CreateDirectory(string path)
		{
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x0001E1F8 File Offset: 0x0001C3F8
		[Token(Token = "0x6003BBC")]
		[Address(RVA = "0x1E13C98", Offset = "0x1E13C98", VA = "0x1E13C98")]
		public static bool Exists(string path, bool cloud = false)
		{
			return default(bool);
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBD")]
		[Address(RVA = "0x1E13D34", Offset = "0x1E13D34", VA = "0x1E13D34")]
		public static void Delete(string path, bool cloud = false)
		{
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBE")]
		[Address(RVA = "0x1E13DCC", Offset = "0x1E13DCC", VA = "0x1E13DCC")]
		public static string GetFullPath(string path, bool cloud)
		{
			return null;
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBF")]
		[Address(RVA = "0x1E13DD0", Offset = "0x1E13DD0", VA = "0x1E13DD0")]
		public static void Copy(string source, string destination, bool cloud = false, bool overwrite = true)
		{
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC0")]
		[Address(RVA = "0x1E14140", Offset = "0x1E14140", VA = "0x1E14140")]
		public static void Move(string source, string destination, bool cloud, bool overwrite = true)
		{
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC1")]
		[Address(RVA = "0x1E14254", Offset = "0x1E14254", VA = "0x1E14254")]
		public static void WriteAllText(string path, string data)
		{
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC2")]
		[Address(RVA = "0x1E14354", Offset = "0x1E14354", VA = "0x1E14354")]
		public static string ReadAllText(string path)
		{
			return null;
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC3")]
		[Address(RVA = "0x1E14020", Offset = "0x1E14020", VA = "0x1E14020")]
		public static byte[] ReadAllBytes(string path, bool cloud = false)
		{
			return null;
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC4")]
		[Address(RVA = "0x1E140B4", Offset = "0x1E140B4", VA = "0x1E140B4")]
		public static void WriteAllBytes(string path, byte[] data, bool cloud = false)
		{
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC5")]
		[Address(RVA = "0x1E14420", Offset = "0x1E14420", VA = "0x1E14420")]
		public static void Write(string path, byte[] data, int length, bool cloud)
		{
		}

		// Token: 0x06003BC6 RID: 15302 RVA: 0x0001E210 File Offset: 0x0001C410
		[Token(Token = "0x6003BC6")]
		[Address(RVA = "0x1E147F4", Offset = "0x1E147F4", VA = "0x1E147F4")]
		public static bool MoveToCloud(string localPath, string cloudPath)
		{
			return default(bool);
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x0001E228 File Offset: 0x0001C428
		[Token(Token = "0x6003BC7")]
		[Address(RVA = "0x1E14978", Offset = "0x1E14978", VA = "0x1E14978")]
		public static bool MoveToLocal(string cloudPath, string localPath)
		{
			return default(bool);
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC8")]
		[Address(RVA = "0x1E14B38", Offset = "0x1E14B38", VA = "0x1E14B38")]
		public static string GetFileName(string path, bool includeExtension = true)
		{
			return null;
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC9")]
		[Address(RVA = "0x1E14698", Offset = "0x1E14698", VA = "0x1E14698")]
		public static string GetParentFolderPath(string path, bool includeExtension = true)
		{
			return null;
		}

		// Token: 0x04004759 RID: 18265
		[Token(Token = "0x4004759")]
		[FieldOffset(Offset = "0x0")]
		private static Regex FileNameRegex;
	}
}
