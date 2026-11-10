using System;
using System.IO;
using Il2CppDummyDll;

// Token: 0x02000072 RID: 114
[Token(Token = "0x2000072")]
public class DefaultFileAPI : FileAPI
{
	// Token: 0x06000263 RID: 611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000263")]
	[Address(RVA = "0x4B6138", Offset = "0x4B6138", VA = "0x4B6138")]
	public DefaultFileAPI(PlatformUser user)
	{
	}

	// Token: 0x06000264 RID: 612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000264")]
	[Address(RVA = "0x4B61D8", Offset = "0x4B61D8", VA = "0x4B61D8", Slot = "17")]
	public void Shutdown()
	{
	}

	// Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000265")]
	[Address(RVA = "0x4B61DC", Offset = "0x4B61DC", VA = "0x4B61DC", Slot = "4")]
	public string GetUserSavePath()
	{
		return null;
	}

	// Token: 0x06000266 RID: 614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000266")]
	[Address(RVA = "0x4B6520", Offset = "0x4B6520", VA = "0x4B6520", Slot = "5")]
	public void LegacySync()
	{
	}

	// Token: 0x06000267 RID: 615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000267")]
	[Address(RVA = "0x4B6524", Offset = "0x4B6524", VA = "0x4B6524", Slot = "6")]
	public void Mount(bool forSync)
	{
	}

	// Token: 0x06000268 RID: 616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000268")]
	[Address(RVA = "0x4B65A0", Offset = "0x4B65A0", VA = "0x4B65A0", Slot = "7")]
	public void Unmount(bool forSync)
	{
	}

	// Token: 0x06000269 RID: 617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000269")]
	[Address(RVA = "0x4B65A4", Offset = "0x4B65A4", VA = "0x4B65A4", Slot = "8")]
	public void CreateDirectory(string directory)
	{
	}

	// Token: 0x0600026A RID: 618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026A")]
	[Address(RVA = "0x4B65B0", Offset = "0x4B65B0", VA = "0x4B65B0", Slot = "9")]
	public void WriteFile(string filename, byte[] fileData)
	{
	}

	// Token: 0x0600026B RID: 619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026B")]
	[Address(RVA = "0x4B664C", Offset = "0x4B664C", VA = "0x4B664C", Slot = "10")]
	public void Delete(string filename)
	{
	}

	// Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026C")]
	[Address(RVA = "0x4B6658", Offset = "0x4B6658", VA = "0x4B6658", Slot = "11")]
	public byte[] ReadFile(string filename)
	{
		return null;
	}

	// Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026D")]
	[Address(RVA = "0x4B6664", Offset = "0x4B6664", VA = "0x4B6664", Slot = "13")]
	public string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}

	// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026E")]
	[Address(RVA = "0x4B66E4", Offset = "0x4B66E4", VA = "0x4B66E4", Slot = "14")]
	public string[] GetFolders(string path)
	{
		return null;
	}

	// Token: 0x0600026F RID: 623 RVA: 0x00002D30 File Offset: 0x00000F30
	[Token(Token = "0x600026F")]
	[Address(RVA = "0x4B675C", Offset = "0x4B675C", VA = "0x4B675C", Slot = "12")]
	public bool Exists(string filename)
	{
		return default(bool);
	}

	// Token: 0x06000270 RID: 624 RVA: 0x00002D48 File Offset: 0x00000F48
	[Token(Token = "0x6000270")]
	[Address(RVA = "0x4B6768", Offset = "0x4B6768", VA = "0x4B6768", Slot = "15")]
	public DateTime GetFileTime(string filename)
	{
		return default(DateTime);
	}

	// Token: 0x06000271 RID: 625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000271")]
	[Address(RVA = "0x4B6794", Offset = "0x4B6794", VA = "0x4B6794", Slot = "16")]
	public void SetAttributes(string filename, FileAttributes fileAttributes)
	{
	}

	// Token: 0x0400048F RID: 1167
	[Token(Token = "0x400048F")]
	[FieldOffset(Offset = "0x8")]
	private int mountCount;

	// Token: 0x04000490 RID: 1168
	[Token(Token = "0x4000490")]
	[FieldOffset(Offset = "0xC")]
	private string _userSavePath;

	// Token: 0x04000491 RID: 1169
	[Token(Token = "0x4000491")]
	[FieldOffset(Offset = "0x10")]
	private PlatformUser platformUser;
}
