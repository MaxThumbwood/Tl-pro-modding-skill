using System;
using Il2CppDummyDll;
using Telepathy;

// Token: 0x02000328 RID: 808
[Token(Token = "0x2000328")]
public class SaveSynchronisationHost
{
	// Token: 0x060013FA RID: 5114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013FA")]
	[Address(RVA = "0xDB40B8", Offset = "0xDB40B8", VA = "0xDB40B8")]
	public void Start()
	{
	}

	// Token: 0x060013FB RID: 5115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013FB")]
	[Address(RVA = "0xDB40E0", Offset = "0xDB40E0", VA = "0xDB40E0")]
	public void Close()
	{
	}

	// Token: 0x060013FC RID: 5116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013FC")]
	[Address(RVA = "0xDB4104", Offset = "0xDB4104", VA = "0xDB4104")]
	private void SendDataFunction(byte[] messageData, int length)
	{
	}

	// Token: 0x060013FD RID: 5117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013FD")]
	[Address(RVA = "0xDB4280", Offset = "0xDB4280", VA = "0xDB4280")]
	public void RequestFile(string filename)
	{
	}

	// Token: 0x060013FE RID: 5118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013FE")]
	[Address(RVA = "0xDB4750", Offset = "0xDB4750", VA = "0xDB4750")]
	public void SendFile(string filename)
	{
	}

	// Token: 0x060013FF RID: 5119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013FF")]
	[Address(RVA = "0xDB48D4", Offset = "0xDB48D4", VA = "0xDB48D4")]
	public void Update()
	{
	}

	// Token: 0x06001400 RID: 5120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001400")]
	[Address(RVA = "0xDB534C", Offset = "0xDB534C", VA = "0xDB534C")]
	public SaveSynchronisationHost()
	{
	}

	// Token: 0x040027B0 RID: 10160
	[Token(Token = "0x40027B0")]
	[FieldOffset(Offset = "0x8")]
	public Server Server;

	// Token: 0x040027B1 RID: 10161
	[Token(Token = "0x40027B1")]
	[FieldOffset(Offset = "0xC")]
	public SaveSynchronisationOperation CurrentOperation;

	// Token: 0x040027B2 RID: 10162
	[Token(Token = "0x40027B2")]
	[FieldOffset(Offset = "0x10")]
	public int connectedClient;
}
