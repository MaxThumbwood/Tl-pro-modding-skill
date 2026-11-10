using System;
using System.IO;
using Il2CppDummyDll;

// Token: 0x02000076 RID: 118
[Token(Token = "0x2000076")]
public class FileManager
{
	// Token: 0x06000286 RID: 646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000286")]
	[Address(RVA = "0x4B7018", Offset = "0x4B7018", VA = "0x4B7018")]
	public FileManager(PlatformUser user, bool primaryUser)
	{
	}

	// Token: 0x06000287 RID: 647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000287")]
	[Address(RVA = "0x4B71B0", Offset = "0x4B71B0", VA = "0x4B71B0")]
	public static void SynchroniseFiles()
	{
	}

	// Token: 0x06000288 RID: 648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000288")]
	[Address(RVA = "0x4B72DC", Offset = "0x4B72DC", VA = "0x4B72DC")]
	public void Shutdown()
	{
	}

	// Token: 0x06000289 RID: 649 RVA: 0x00002D90 File Offset: 0x00000F90
	[Token(Token = "0x6000289")]
	[Address(RVA = "0x4B73A8", Offset = "0x4B73A8", VA = "0x4B73A8")]
	public static bool Exists(string path)
	{
		return default(bool);
	}

	// Token: 0x0600028A RID: 650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028A")]
	[Address(RVA = "0x4B7528", Offset = "0x4B7528", VA = "0x4B7528")]
	public static void Delete(string path)
	{
	}

	// Token: 0x0600028B RID: 651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028B")]
	[Address(RVA = "0x4B7818", Offset = "0x4B7818", VA = "0x4B7818")]
	public static void CreateDirectory(string path)
	{
	}

	// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600028C")]
	[Address(RVA = "0x4B7998", Offset = "0x4B7998", VA = "0x4B7998")]
	public static byte[] ReadAllBytes(string path)
	{
		return null;
	}

	// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600028D")]
	[Address(RVA = "0x4B7B18", Offset = "0x4B7B18", VA = "0x4B7B18")]
	public static string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}

	// Token: 0x0600028E RID: 654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028E")]
	[Address(RVA = "0x4B7CA4", Offset = "0x4B7CA4", VA = "0x4B7CA4")]
	public static void WriteAllBytes(string path, byte[] fileData)
	{
	}

	// Token: 0x0600028F RID: 655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028F")]
	[Address(RVA = "0x4B7EC4", Offset = "0x4B7EC4", VA = "0x4B7EC4")]
	public static void SetAttributes(string path, FileAttributes fileAttributes)
	{
	}

	// Token: 0x06000290 RID: 656 RVA: 0x00002DA8 File Offset: 0x00000FA8
	[Token(Token = "0x6000290")]
	[Address(RVA = "0x4B7FE0", Offset = "0x4B7FE0", VA = "0x4B7FE0")]
	public static DateTime GetFileTime(string filename)
	{
		return default(DateTime);
	}

	// Token: 0x04000498 RID: 1176
	[Token(Token = "0x4000498")]
	public static FileManager Instance;

	// Token: 0x04000499 RID: 1177
	[Token(Token = "0x4000499")]
	[FieldOffset(Offset = "0x8")]
	public bool CacheFiles;

	// Token: 0x0400049A RID: 1178
	[Token(Token = "0x400049A")]
	[FieldOffset(Offset = "0xC")]
	public FileAPI fileAPI;

	// Token: 0x0400049B RID: 1179
	[Token(Token = "0x400049B")]
	[FieldOffset(Offset = "0x10")]
	public CacheFileManager FileCache;

	// Token: 0x0400049C RID: 1180
	[Token(Token = "0x400049C")]
	[FieldOffset(Offset = "0x14")]
	public bool IsSyncingUserFiles;

	// Token: 0x0400049D RID: 1181
	[Token(Token = "0x400049D")]
	[FieldOffset(Offset = "0x15")]
	public bool IsWritingFiles;

	// Token: 0x0400049E RID: 1182
	[Token(Token = "0x400049E")]
	[FieldOffset(Offset = "0x18")]
	public SyncStatus syncStatus;
}
