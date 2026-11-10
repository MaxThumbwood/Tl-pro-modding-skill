using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020002E3 RID: 739
[Token(Token = "0x20002E3")]
public class GUISaveSynchronisation_Join
{
	// Token: 0x06001258 RID: 4696 RVA: 0x000087C0 File Offset: 0x000069C0
	[Token(Token = "0x6001258")]
	[Address(RVA = "0xD8ABE8", Offset = "0xD8ABE8", VA = "0xD8ABE8")]
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06001259 RID: 4697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001259")]
	[Address(RVA = "0xD840F0", Offset = "0xD840F0", VA = "0xD840F0")]
	public void Draw()
	{
	}

	// Token: 0x0600125A RID: 4698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125A")]
	[Address(RVA = "0xD8BF10", Offset = "0xD8BF10", VA = "0xD8BF10")]
	private void DrawServerIP()
	{
	}

	// Token: 0x0600125B RID: 4699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125B")]
	[Address(RVA = "0xD8CD1C", Offset = "0xD8CD1C", VA = "0xD8CD1C")]
	private void EnterServerIP()
	{
	}

	// Token: 0x0600125C RID: 4700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125C")]
	[Address(RVA = "0xD8CED8", Offset = "0xD8CED8", VA = "0xD8CED8")]
	private void CloseServerIPEdit()
	{
	}

	// Token: 0x0600125D RID: 4701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125D")]
	[Address(RVA = "0xD8B0D0", Offset = "0xD8B0D0", VA = "0xD8B0D0")]
	private void DrawServerPort()
	{
	}

	// Token: 0x0600125E RID: 4702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125E")]
	[Address(RVA = "0xD8CFAC", Offset = "0xD8CFAC", VA = "0xD8CFAC")]
	private void EnterServerPort()
	{
	}

	// Token: 0x0600125F RID: 4703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125F")]
	[Address(RVA = "0xD8D0F0", Offset = "0xD8D0F0", VA = "0xD8D0F0")]
	private void CloseServerPortEdit()
	{
	}

	// Token: 0x06001260 RID: 4704 RVA: 0x000087D8 File Offset: 0x000069D8
	[Token(Token = "0x6001260")]
	[Address(RVA = "0xD8D1C4", Offset = "0xD8D1C4", VA = "0xD8D1C4")]
	private int ParsePort(string port)
	{
		return 0;
	}

	// Token: 0x06001261 RID: 4705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001261")]
	[Address(RVA = "0xD8ABF0", Offset = "0xD8ABF0", VA = "0xD8ABF0")]
	private void DrawMainButtons()
	{
	}

	// Token: 0x06001262 RID: 4706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001262")]
	[Address(RVA = "0xD8D26C", Offset = "0xD8D26C", VA = "0xD8D26C")]
	private void Back()
	{
	}

	// Token: 0x06001263 RID: 4707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001263")]
	[Address(RVA = "0xD8D2FC", Offset = "0xD8D2FC", VA = "0xD8D2FC")]
	public GUISaveSynchronisation_Join()
	{
	}

	// Token: 0x040023B5 RID: 9141
	[Token(Token = "0x40023B5")]
	[FieldOffset(Offset = "0x8")]
	private float joinButtonScale;

	// Token: 0x040023B6 RID: 9142
	[Token(Token = "0x40023B6")]
	[FieldOffset(Offset = "0xC")]
	private float backButtonScale;

	// Token: 0x040023B7 RID: 9143
	[Token(Token = "0x40023B7")]
	[FieldOffset(Offset = "0x10")]
	private float TitleScale;

	// Token: 0x040023B8 RID: 9144
	[Token(Token = "0x40023B8")]
	[FieldOffset(Offset = "0x14")]
	private Rectangle SelectedItemRegion;

	// Token: 0x040023B9 RID: 9145
	[Token(Token = "0x40023B9")]
	[FieldOffset(Offset = "0x24")]
	private GUIControllerMultiplayerJoin _controllerInput;

	// Token: 0x040023BA RID: 9146
	[Token(Token = "0x40023BA")]
	[FieldOffset(Offset = "0x28")]
	private string _serverIP;

	// Token: 0x040023BB RID: 9147
	[Token(Token = "0x40023BB")]
	[FieldOffset(Offset = "0x2C")]
	private string _serverPort;

	// Token: 0x040023BC RID: 9148
	[Token(Token = "0x40023BC")]
	[FieldOffset(Offset = "0x30")]
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x040023BD RID: 9149
	[Token(Token = "0x40023BD")]
	[FieldOffset(Offset = "0x34")]
	public bool editingServerIP;

	// Token: 0x040023BE RID: 9150
	[Token(Token = "0x40023BE")]
	[FieldOffset(Offset = "0x35")]
	public bool editingServerPort;

	// Token: 0x040023BF RID: 9151
	[Token(Token = "0x40023BF")]
	private const int defaultPort = 5555;
}
