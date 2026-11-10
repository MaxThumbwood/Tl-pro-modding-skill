using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Il2CppDummyDll;

// Token: 0x02000071 RID: 113
[Token(Token = "0x2000071")]
public class CacheFileManager : FileAPI
{
	// Token: 0x0600024A RID: 586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024A")]
	[Address(RVA = "0x4B2D40", Offset = "0x4B2D40", VA = "0x4B2D40")]
	public CacheFileManager(FileManager fileMan, FileAPI api, bool primaryUser, PlatformUser user)
	{
	}

	// Token: 0x0600024B RID: 587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024B")]
	[Address(RVA = "0x4B2F80", Offset = "0x4B2F80", VA = "0x4B2F80", Slot = "17")]
	public void Shutdown()
	{
	}

	// Token: 0x0600024C RID: 588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024C")]
	[Address(RVA = "0x4B305C", Offset = "0x4B305C", VA = "0x4B305C")]
	public void ResyncFiles()
	{
	}

	// Token: 0x0600024D RID: 589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024D")]
	[Address(RVA = "0x4B3168", Offset = "0x4B3168", VA = "0x4B3168")]
	public void FileSyncInternal(object threadContext)
	{
	}

	// Token: 0x0600024E RID: 590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024E")]
	[Address(RVA = "0x4B3734", Offset = "0x4B3734", VA = "0x4B3734")]
	private void SyncFolder(string folderPath, bool recursive = false)
	{
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024F")]
	[Address(RVA = "0x4B3CF0", Offset = "0x4B3CF0", VA = "0x4B3CF0")]
	private CachedFile GetFile(string path, bool create = true)
	{
		return null;
	}

	// Token: 0x06000250 RID: 592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000250")]
	[Address(RVA = "0x4B3AC8", Offset = "0x4B3AC8", VA = "0x4B3AC8")]
	public void SyncFile(string filePath)
	{
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000251")]
	[Address(RVA = "0x4B4244", Offset = "0x4B4244", VA = "0x4B4244")]
	private void FileUpload(object threadContext)
	{
	}

	// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000252")]
	[Address(RVA = "0x4B4D78", Offset = "0x4B4D78", VA = "0x4B4D78", Slot = "4")]
	public string GetUserSavePath()
	{
		return null;
	}

	// Token: 0x06000253 RID: 595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000253")]
	[Address(RVA = "0x4B4D80", Offset = "0x4B4D80", VA = "0x4B4D80", Slot = "5")]
	public void LegacySync()
	{
	}

	// Token: 0x06000254 RID: 596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000254")]
	[Address(RVA = "0x4B4D84", Offset = "0x4B4D84", VA = "0x4B4D84", Slot = "6")]
	public void Mount(bool forSync)
	{
	}

	// Token: 0x06000255 RID: 597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000255")]
	[Address(RVA = "0x4B4D88", Offset = "0x4B4D88", VA = "0x4B4D88", Slot = "7")]
	public void Unmount(bool forSync)
	{
	}

	// Token: 0x06000256 RID: 598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000256")]
	[Address(RVA = "0x4B4D8C", Offset = "0x4B4D8C", VA = "0x4B4D8C", Slot = "8")]
	public void CreateDirectory(string directory)
	{
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000257")]
	[Address(RVA = "0x4B3990", Offset = "0x4B3990", VA = "0x4B3990")]
	public void InSync()
	{
	}

	// Token: 0x06000258 RID: 600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000258")]
	[Address(RVA = "0x4B4D90", Offset = "0x4B4D90", VA = "0x4B4D90", Slot = "9")]
	public void WriteFile(string filename, byte[] fileData)
	{
	}

	// Token: 0x06000259 RID: 601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000259")]
	[Address(RVA = "0x4B50B4", Offset = "0x4B50B4", VA = "0x4B50B4", Slot = "10")]
	public void Delete(string filename)
	{
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025A")]
	[Address(RVA = "0x4B53C4", Offset = "0x4B53C4", VA = "0x4B53C4")]
	public void ResyncCacheForFolder(string path, string searchPattern)
	{
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025B")]
	[Address(RVA = "0x4B5954", Offset = "0x4B5954", VA = "0x4B5954", Slot = "11")]
	public byte[] ReadFile(string filename)
	{
		return null;
	}

	// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025C")]
	[Address(RVA = "0x4B415C", Offset = "0x4B415C", VA = "0x4B415C")]
	public string CleanPath(string path)
	{
		return null;
	}

	// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025D")]
	[Address(RVA = "0x4B5BF4", Offset = "0x4B5BF4", VA = "0x4B5BF4", Slot = "13")]
	public string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025E")]
	[Address(RVA = "0x4B6074", Offset = "0x4B6074", VA = "0x4B6074", Slot = "14")]
	public string[] GetFolders(string path)
	{
		return null;
	}

	// Token: 0x0600025F RID: 607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025F")]
	[Address(RVA = "0x4B4BE0", Offset = "0x4B4BE0", VA = "0x4B4BE0")]
	public void GetFileModifications(List<CachedFile> files)
	{
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00002D00 File Offset: 0x00000F00
	[Token(Token = "0x6000260")]
	[Address(RVA = "0x4B60C4", Offset = "0x4B60C4", VA = "0x4B60C4", Slot = "12")]
	public bool Exists(string filename)
	{
		return default(bool);
	}

	// Token: 0x06000261 RID: 609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000261")]
	[Address(RVA = "0x4B6108", Offset = "0x4B6108", VA = "0x4B6108", Slot = "16")]
	public void SetAttributes(string filename, FileAttributes fileAttributes)
	{
	}

	// Token: 0x06000262 RID: 610 RVA: 0x00002D18 File Offset: 0x00000F18
	[Token(Token = "0x6000262")]
	[Address(RVA = "0x4B610C", Offset = "0x4B610C", VA = "0x4B610C", Slot = "15")]
	public DateTime GetFileTime(string filename)
	{
		return default(DateTime);
	}

	// Token: 0x04000483 RID: 1155
	[Token(Token = "0x4000483")]
	[FieldOffset(Offset = "0x8")]
	public bool UploadingFiles;

	// Token: 0x04000484 RID: 1156
	[Token(Token = "0x4000484")]
	[FieldOffset(Offset = "0xC")]
	private object fileStructureLock;

	// Token: 0x04000485 RID: 1157
	[Token(Token = "0x4000485")]
	[FieldOffset(Offset = "0x10")]
	private List<CachedFile> allFiles;

	// Token: 0x04000486 RID: 1158
	[Token(Token = "0x4000486")]
	[FieldOffset(Offset = "0x14")]
	private List<CachedFile> modifications;

	// Token: 0x04000487 RID: 1159
	[Token(Token = "0x4000487")]
	[FieldOffset(Offset = "0x18")]
	private ManualResetEvent uploadPending;

	// Token: 0x04000488 RID: 1160
	[Token(Token = "0x4000488")]
	[FieldOffset(Offset = "0x1C")]
	private readonly FileManager fileManager;

	// Token: 0x04000489 RID: 1161
	[Token(Token = "0x4000489")]
	[FieldOffset(Offset = "0x20")]
	private readonly FileAPI fileAPI;

	// Token: 0x0400048A RID: 1162
	[Token(Token = "0x400048A")]
	[FieldOffset(Offset = "0x24")]
	private readonly bool PrimaryUser;

	// Token: 0x0400048B RID: 1163
	[Token(Token = "0x400048B")]
	[FieldOffset(Offset = "0x28")]
	private readonly PlatformUser User;

	// Token: 0x0400048C RID: 1164
	[Token(Token = "0x400048C")]
	[FieldOffset(Offset = "0x30")]
	private ManagedThread UploadThread;

	// Token: 0x0400048D RID: 1165
	[Token(Token = "0x400048D")]
	[FieldOffset(Offset = "0x34")]
	private ManagedThread SyncThread;

	// Token: 0x0400048E RID: 1166
	[Token(Token = "0x400048E")]
	[FieldOffset(Offset = "0x38")]
	private string _userSavePath;
}
