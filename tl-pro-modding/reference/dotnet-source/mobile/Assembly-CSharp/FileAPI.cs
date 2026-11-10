using System;
using System.IO;
using Il2CppDummyDll;

// Token: 0x02000073 RID: 115
[Token(Token = "0x2000073")]
public interface FileAPI
{
	// Token: 0x06000272 RID: 626
	[Token(Token = "0x6000272")]
	string GetUserSavePath();

	// Token: 0x06000273 RID: 627
	[Token(Token = "0x6000273")]
	void LegacySync();

	// Token: 0x06000274 RID: 628
	[Token(Token = "0x6000274")]
	void Mount(bool forSync);

	// Token: 0x06000275 RID: 629
	[Token(Token = "0x6000275")]
	void Unmount(bool forSync);

	// Token: 0x06000276 RID: 630
	[Token(Token = "0x6000276")]
	void CreateDirectory(string directory);

	// Token: 0x06000277 RID: 631
	[Token(Token = "0x6000277")]
	void WriteFile(string filename, byte[] fileData);

	// Token: 0x06000278 RID: 632
	[Token(Token = "0x6000278")]
	void Delete(string filename);

	// Token: 0x06000279 RID: 633
	[Token(Token = "0x6000279")]
	byte[] ReadFile(string filename);

	// Token: 0x0600027A RID: 634
	[Token(Token = "0x600027A")]
	bool Exists(string filename);

	// Token: 0x0600027B RID: 635
	[Token(Token = "0x600027B")]
	string[] GetFiles(string filename, string searchPattern);

	// Token: 0x0600027C RID: 636
	[Token(Token = "0x600027C")]
	string[] GetFolders(string filename);

	// Token: 0x0600027D RID: 637
	[Token(Token = "0x600027D")]
	DateTime GetFileTime(string filename);

	// Token: 0x0600027E RID: 638
	[Token(Token = "0x600027E")]
	void SetAttributes(string filename, FileAttributes fileAttributes);

	// Token: 0x0600027F RID: 639
	[Token(Token = "0x600027F")]
	void Shutdown();
}
