using System;
using Il2CppDummyDll;
using Telepathy;

// Token: 0x02000325 RID: 805
[Token(Token = "0x2000325")]
public class SaveSynchronisationClient
{
	// Token: 0x060013ED RID: 5101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013ED")]
	[Address(RVA = "0xDB0C5C", Offset = "0xDB0C5C", VA = "0xDB0C5C")]
	public void Connect(string hostName)
	{
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013EE")]
	[Address(RVA = "0xDB0C8C", Offset = "0xDB0C8C", VA = "0xDB0C8C")]
	public void Close()
	{
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013EF")]
	[Address(RVA = "0xDB0CB0", Offset = "0xDB0CB0", VA = "0xDB0CB0")]
	private void SendDataFunction(byte[] messageData, int length)
	{
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F0")]
	[Address(RVA = "0xDB0E20", Offset = "0xDB0E20", VA = "0xDB0E20")]
	public void RequestFile(string filename)
	{
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F1")]
	[Address(RVA = "0xDB1420", Offset = "0xDB1420", VA = "0xDB1420")]
	public void SendFile(string filename)
	{
	}

	// Token: 0x060013F2 RID: 5106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F2")]
	[Address(RVA = "0xDB1C48", Offset = "0xDB1C48", VA = "0xDB1C48")]
	public void Update()
	{
	}

	// Token: 0x060013F3 RID: 5107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F3")]
	[Address(RVA = "0xDB2704", Offset = "0xDB2704", VA = "0xDB2704")]
	public SaveSynchronisationClient()
	{
	}

	// Token: 0x040027A2 RID: 10146
	[Token(Token = "0x40027A2")]
	[FieldOffset(Offset = "0x8")]
	public Client Client;

	// Token: 0x040027A3 RID: 10147
	[Token(Token = "0x40027A3")]
	[FieldOffset(Offset = "0xC")]
	public SaveSynchronisationOperation CurrentOperation;
}
