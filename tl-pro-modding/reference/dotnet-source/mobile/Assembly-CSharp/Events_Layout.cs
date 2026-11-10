using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001F0 RID: 496
[Token(Token = "0x20001F0")]
public class Events_Layout : LayoutDefinition
{
	// Token: 0x17000162 RID: 354
	// (get) Token: 0x06000D4F RID: 3407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000162")]
	public static Events_Layout Instance
	{
		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0xC7CC98", Offset = "0xC7CC98", VA = "0xC7CC98")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000D50 RID: 3408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D50")]
	[Address(RVA = "0xC7CD54", Offset = "0xC7CD54", VA = "0xC7CD54")]
	private void Awake()
	{
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D51")]
	[Address(RVA = "0xC7CDEC", Offset = "0xC7CDEC", VA = "0xC7CDEC")]
	public Events_Layout()
	{
	}

	// Token: 0x040014EA RID: 5354
	[Token(Token = "0x40014EA")]
	[FieldOffset(Offset = "0x0")]
	public static Events_Layout _instance;

	// Token: 0x040014EB RID: 5355
	[Token(Token = "0x40014EB")]
	[FieldOffset(Offset = "0x4")]
	public static Events_Layout _instanceMobile;

	// Token: 0x040014EC RID: 5356
	[Token(Token = "0x40014EC")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Backing;

	// Token: 0x040014ED RID: 5357
	[Token(Token = "0x40014ED")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout InvasionTitle;

	// Token: 0x040014EE RID: 5358
	[Token(Token = "0x40014EE")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout InvasionIcon;

	// Token: 0x040014EF RID: 5359
	[Token(Token = "0x40014EF")]
	[FieldOffset(Offset = "0x18")]
	public Panel_Layout BarBacking;

	// Token: 0x040014F0 RID: 5360
	[Token(Token = "0x40014F0")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout BarFill;

	// Token: 0x040014F1 RID: 5361
	[Token(Token = "0x40014F1")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout InfiniteBarBacking;

	// Token: 0x040014F2 RID: 5362
	[Token(Token = "0x40014F2")]
	[FieldOffset(Offset = "0x24")]
	public Panel_Layout InfiniteBarFill;

	// Token: 0x040014F3 RID: 5363
	[Token(Token = "0x40014F3")]
	[FieldOffset(Offset = "0x28")]
	public String_Layout Waves;

	// Token: 0x040014F4 RID: 5364
	[Token(Token = "0x40014F4")]
	[FieldOffset(Offset = "0x2C")]
	public Color MaxWaveColour;

	// Token: 0x040014F5 RID: 5365
	[Token(Token = "0x40014F5")]
	[FieldOffset(Offset = "0x30")]
	public String_Layout Progress;
}
