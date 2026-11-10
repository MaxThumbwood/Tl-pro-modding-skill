using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

// Token: 0x02000057 RID: 87
[Token(Token = "0x2000057")]
public class CSVWriter
{
	// Token: 0x060001D0 RID: 464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x4A9C4C", Offset = "0x4A9C4C", VA = "0x4A9C4C")]
	public CSVWriter(string file, string[] headers)
	{
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x4A9E78", Offset = "0x4A9E78", VA = "0x4A9E78")]
	public CSVWriter(string file, string[] headers, UTF8Encoding enc)
	{
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x4A9FAC", Offset = "0x4A9FAC", VA = "0x4A9FAC")]
	public CSVWriter(string[] headers)
	{
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x4A9CB0", Offset = "0x4A9CB0", VA = "0x4A9CB0")]
	private void SetupStreams()
	{
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x4A9EE4", Offset = "0x4A9EE4", VA = "0x4A9EE4")]
	private void SetupStreams(UTF8Encoding enc)
	{
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x4A9FD8", Offset = "0x4A9FD8", VA = "0x4A9FD8")]
	private void CloseStreams()
	{
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x4AA084", Offset = "0x4AA084", VA = "0x4AA084", Slot = "1")]
	protected override void Finalize()
	{
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x4AA114", Offset = "0x4AA114", VA = "0x4AA114")]
	private string EncodeValue(string stringValue)
	{
		return null;
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x4A9D70", Offset = "0x4A9D70", VA = "0x4A9D70")]
	public void WriteLine(string[] values)
	{
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x4AA224", Offset = "0x4AA224", VA = "0x4AA224")]
	public void Close()
	{
	}

	// Token: 0x040003A7 RID: 935
	[Token(Token = "0x40003A7")]
	[FieldOffset(Offset = "0x8")]
	public byte[] SaveData;

	// Token: 0x040003A8 RID: 936
	[Token(Token = "0x40003A8")]
	[FieldOffset(Offset = "0xC")]
	private string _outputFile;

	// Token: 0x040003A9 RID: 937
	[Token(Token = "0x40003A9")]
	[FieldOffset(Offset = "0x10")]
	private bool _open;

	// Token: 0x040003AA RID: 938
	[Token(Token = "0x40003AA")]
	[FieldOffset(Offset = "0x14")]
	private StreamWriter _writer;

	// Token: 0x040003AB RID: 939
	[Token(Token = "0x40003AB")]
	[FieldOffset(Offset = "0x18")]
	private MemoryStream _memoryStream;
}
