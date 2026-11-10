using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x02000346 RID: 838
[Token(Token = "0x2000346")]
public static class nativefiledialog
{
	// Token: 0x060014A7 RID: 5287 RVA: 0x000091C8 File Offset: 0x000073C8
	[Token(Token = "0x60014A7")]
	[Address(RVA = "0xDEC498", Offset = "0xDEC498", VA = "0xDEC498")]
	private static int Utf8Size(string str)
	{
		return 0;
	}

	// Token: 0x060014A8 RID: 5288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014A8")]
	[Address(RVA = "0xDEC4BC", Offset = "0xDEC4BC", VA = "0xDEC4BC")]
	private unsafe static byte* Utf8EncodeNullable(string str)
	{
		return null;
	}

	// Token: 0x060014A9 RID: 5289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014A9")]
	[Address(RVA = "0xDEC5B0", Offset = "0xDEC5B0", VA = "0xDEC5B0")]
	private static string UTF8_ToManaged(IntPtr s, bool freePtr = false)
	{
		return null;
	}

	// Token: 0x060014AA RID: 5290
	[Token(Token = "0x60014AA")]
	[Address(RVA = "0xDEC830", Offset = "0xDEC830", VA = "0xDEC830")]
	[PreserveSig]
	private static extern void free(IntPtr ptr);

	// Token: 0x060014AB RID: 5291
	[Token(Token = "0x60014AB")]
	[Address(RVA = "0xDEC8D0", Offset = "0xDEC8D0", VA = "0xDEC8D0")]
	[PreserveSig]
	private unsafe static extern nativefiledialog.nfdresult_t INTERNAL_NFD_OpenDialog(byte* filterList, byte* defaultPath, out IntPtr outPath);

	// Token: 0x060014AC RID: 5292 RVA: 0x000091E0 File Offset: 0x000073E0
	[Token(Token = "0x60014AC")]
	[Address(RVA = "0xDEC980", Offset = "0xDEC980", VA = "0xDEC980")]
	public static nativefiledialog.nfdresult_t NFD_OpenDialog(string filterList, string defaultPath, out string outPath)
	{
		return nativefiledialog.nfdresult_t.NFD_ERROR;
	}

	// Token: 0x060014AD RID: 5293
	[Token(Token = "0x60014AD")]
	[Address(RVA = "0xDECAF0", Offset = "0xDECAF0", VA = "0xDECAF0")]
	[PreserveSig]
	private unsafe static extern nativefiledialog.nfdresult_t INTERNAL_NFD_OpenDialogMultiple(byte* filterList, byte* defaultPath, out nativefiledialog.nfdpathset_t outPaths);

	// Token: 0x060014AE RID: 5294 RVA: 0x000091F8 File Offset: 0x000073F8
	[Token(Token = "0x60014AE")]
	[Address(RVA = "0xDECBA0", Offset = "0xDECBA0", VA = "0xDECBA0")]
	public static nativefiledialog.nfdresult_t NFD_OpenDialogMultiple(string filterList, string defaultPath, out nativefiledialog.nfdpathset_t outPaths)
	{
		return nativefiledialog.nfdresult_t.NFD_ERROR;
	}

	// Token: 0x060014AF RID: 5295
	[Token(Token = "0x60014AF")]
	[Address(RVA = "0xDECCF0", Offset = "0xDECCF0", VA = "0xDECCF0")]
	[PreserveSig]
	private unsafe static extern nativefiledialog.nfdresult_t INTERNAL_NFD_SaveDialog(byte* filterList, byte* defaultPath, out IntPtr outPath);

	// Token: 0x060014B0 RID: 5296 RVA: 0x00009210 File Offset: 0x00007410
	[Token(Token = "0x60014B0")]
	[Address(RVA = "0xDECDA0", Offset = "0xDECDA0", VA = "0xDECDA0")]
	public static nativefiledialog.nfdresult_t NFD_SaveDialog(string filterList, string defaultPath, out string outPath)
	{
		return nativefiledialog.nfdresult_t.NFD_ERROR;
	}

	// Token: 0x060014B1 RID: 5297
	[Token(Token = "0x60014B1")]
	[Address(RVA = "0xDECF10", Offset = "0xDECF10", VA = "0xDECF10")]
	[PreserveSig]
	private unsafe static extern nativefiledialog.nfdresult_t INTERNAL_NFD_PickFolder(byte* defaultPath, out IntPtr outPath);

	// Token: 0x060014B2 RID: 5298 RVA: 0x00009228 File Offset: 0x00007428
	[Token(Token = "0x60014B2")]
	[Address(RVA = "0xDECFB0", Offset = "0xDECFB0", VA = "0xDECFB0")]
	public static nativefiledialog.nfdresult_t NFD_PickFolder(string defaultPath, out string outPath)
	{
		return nativefiledialog.nfdresult_t.NFD_ERROR;
	}

	// Token: 0x060014B3 RID: 5299
	[Token(Token = "0x60014B3")]
	[Address(RVA = "0xDED0F0", Offset = "0xDED0F0", VA = "0xDED0F0")]
	[PreserveSig]
	private static extern IntPtr INTERNAL_NFD_GetError();

	// Token: 0x060014B4 RID: 5300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014B4")]
	[Address(RVA = "0xDED180", Offset = "0xDED180", VA = "0xDED180")]
	public static string NFD_GetError()
	{
		return null;
	}

	// Token: 0x060014B5 RID: 5301
	[Token(Token = "0x60014B5")]
	[Address(RVA = "0xDED220", Offset = "0xDED220", VA = "0xDED220")]
	[PreserveSig]
	public static extern IntPtr NFD_PathSet_GetCount(ref nativefiledialog.nfdpathset_t pathset);

	// Token: 0x060014B6 RID: 5302
	[Token(Token = "0x60014B6")]
	[Address(RVA = "0xDED2C0", Offset = "0xDED2C0", VA = "0xDED2C0")]
	[PreserveSig]
	private static extern IntPtr INTERNAL_NFD_PathSet_GetPath(ref nativefiledialog.nfdpathset_t pathset, IntPtr index);

	// Token: 0x060014B7 RID: 5303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014B7")]
	[Address(RVA = "0xDED360", Offset = "0xDED360", VA = "0xDED360")]
	public static string NFD_PathSet_GetPath(ref nativefiledialog.nfdpathset_t pathset, IntPtr index)
	{
		return null;
	}

	// Token: 0x060014B8 RID: 5304
	[Token(Token = "0x60014B8")]
	[Address(RVA = "0xDED410", Offset = "0xDED410", VA = "0xDED410")]
	[PreserveSig]
	public static extern void NFD_PathSet_Free(ref nativefiledialog.nfdpathset_t pathset);

	// Token: 0x0400294E RID: 10574
	[Token(Token = "0x400294E")]
	private const string nativeLibName = "nfd";

	// Token: 0x02000347 RID: 839
	[Token(Token = "0x2000347")]
	public enum nfdresult_t
	{
		// Token: 0x04002950 RID: 10576
		[Token(Token = "0x4002950")]
		NFD_ERROR,
		// Token: 0x04002951 RID: 10577
		[Token(Token = "0x4002951")]
		NFD_OKAY,
		// Token: 0x04002952 RID: 10578
		[Token(Token = "0x4002952")]
		NFD_CANCEL
	}

	// Token: 0x02000348 RID: 840
	[Token(Token = "0x2000348")]
	public struct nfdpathset_t
	{
		// Token: 0x04002953 RID: 10579
		[Token(Token = "0x4002953")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr buf;

		// Token: 0x04002954 RID: 10580
		[Token(Token = "0x4002954")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private IntPtr indices;

		// Token: 0x04002955 RID: 10581
		[Token(Token = "0x4002955")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr count;
	}
}
