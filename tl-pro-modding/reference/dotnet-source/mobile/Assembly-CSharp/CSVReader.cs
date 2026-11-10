using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

// Token: 0x02000056 RID: 86
[Token(Token = "0x2000056")]
public class CSVReader
{
	// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x4A8C18", Offset = "0x4A8C18", VA = "0x4A8C18")]
	public static CSVReader Load(string file)
	{
		return null;
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x4A8EC8", Offset = "0x4A8EC8", VA = "0x4A8EC8")]
	public static CSVReader LoadFromFile(string file)
	{
		return null;
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x4A9010", Offset = "0x4A9010", VA = "0x4A9010")]
	public static CSVReader Load(byte[] fileData)
	{
		return null;
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x4A8D20", Offset = "0x4A8D20", VA = "0x4A8D20")]
	public CSVReader()
	{
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x4A8DB8", Offset = "0x4A8DB8", VA = "0x4A8DB8")]
	public void Begin(string file)
	{
	}

	// Token: 0x060001CA RID: 458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x4A8FEC", Offset = "0x4A8FEC", VA = "0x4A8FEC")]
	public void Begin(byte[] fileData)
	{
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x4A92B4", Offset = "0x4A92B4", VA = "0x4A92B4", Slot = "1")]
	protected override void Finalize()
	{
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x4A92BC", Offset = "0x4A92BC", VA = "0x4A92BC")]
	public string GetRawLine()
	{
		return null;
	}

	// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x4A9124", Offset = "0x4A9124", VA = "0x4A9124")]
	public string[] ReadLine()
	{
		return null;
	}

	// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x4A9454", Offset = "0x4A9454", VA = "0x4A9454")]
	private string[] DecodeLine(string line)
	{
		return null;
	}

	// Token: 0x040003A1 RID: 929
	[Token(Token = "0x40003A1")]
	[FieldOffset(Offset = "0x0")]
	private static StringBuilder builder;

	// Token: 0x040003A2 RID: 930
	[Token(Token = "0x40003A2")]
	[FieldOffset(Offset = "0x8")]
	private byte[] _fileData;

	// Token: 0x040003A3 RID: 931
	[Token(Token = "0x40003A3")]
	[FieldOffset(Offset = "0xC")]
	private int _fileOffset;

	// Token: 0x040003A4 RID: 932
	[Token(Token = "0x40003A4")]
	[FieldOffset(Offset = "0x10")]
	private string _filename;

	// Token: 0x040003A5 RID: 933
	[Token(Token = "0x40003A5")]
	[FieldOffset(Offset = "0x14")]
	private List<string> _tokens;

	// Token: 0x040003A6 RID: 934
	[Token(Token = "0x40003A6")]
	[FieldOffset(Offset = "0x18")]
	public string[] Headers;
}
