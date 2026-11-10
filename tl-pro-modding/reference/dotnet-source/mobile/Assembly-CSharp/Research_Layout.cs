using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000259 RID: 601
[Token(Token = "0x2000259")]
public class Research_Layout : LayoutDefinition
{
	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700017E")]
	public static Research_Layout Instance
	{
		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0xC949D0", Offset = "0xC949D0", VA = "0xC949D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E6C")]
	[Address(RVA = "0xC94A84", Offset = "0xC94A84", VA = "0xC94A84")]
	private void Awake()
	{
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E6D")]
	[Address(RVA = "0xC94B0C", Offset = "0xC94B0C", VA = "0xC94B0C")]
	public Research_Layout()
	{
	}

	// Token: 0x04001C26 RID: 7206
	[Token(Token = "0x4001C26")]
	[FieldOffset(Offset = "0x0")]
	public static Research_Layout InstanceNormal;

	// Token: 0x04001C27 RID: 7207
	[Token(Token = "0x4001C27")]
	[FieldOffset(Offset = "0x4")]
	public static Research_Layout Instance4Page;

	// Token: 0x04001C28 RID: 7208
	[Token(Token = "0x4001C28")]
	[FieldOffset(Offset = "0xC")]
	public TransactionButton_Layout InventoryResearch;

	// Token: 0x04001C29 RID: 7209
	[Token(Token = "0x4001C29")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout InventoryResearchController;

	// Token: 0x04001C2A RID: 7210
	[Token(Token = "0x4001C2A")]
	[FieldOffset(Offset = "0x14")]
	public Vector2 InventoryResearchControllerWiringOffset;

	// Token: 0x04001C2B RID: 7211
	[Token(Token = "0x4001C2B")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout Backing;

	// Token: 0x04001C2C RID: 7212
	[Token(Token = "0x4001C2C")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout BackingController;

	// Token: 0x04001C2D RID: 7213
	[Token(Token = "0x4001C2D")]
	[FieldOffset(Offset = "0x24")]
	public Panel_Layout ImageBacking;

	// Token: 0x04001C2E RID: 7214
	[Token(Token = "0x4001C2E")]
	[FieldOffset(Offset = "0x28")]
	public Panel_Layout ResearchItem;

	// Token: 0x04001C2F RID: 7215
	[Token(Token = "0x4001C2F")]
	[FieldOffset(Offset = "0x2C")]
	public Panel_Layout ResearchItemBacking;

	// Token: 0x04001C30 RID: 7216
	[Token(Token = "0x4001C30")]
	[FieldOffset(Offset = "0x30")]
	public Panel_Layout ResearchCogLeft1;

	// Token: 0x04001C31 RID: 7217
	[Token(Token = "0x4001C31")]
	[FieldOffset(Offset = "0x34")]
	public Panel_Layout ResearchCogLeft2;

	// Token: 0x04001C32 RID: 7218
	[Token(Token = "0x4001C32")]
	[FieldOffset(Offset = "0x38")]
	public Panel_Layout ResearchCogLeft3;

	// Token: 0x04001C33 RID: 7219
	[Token(Token = "0x4001C33")]
	[FieldOffset(Offset = "0x3C")]
	public Panel_Layout ResearchCogRight1;

	// Token: 0x04001C34 RID: 7220
	[Token(Token = "0x4001C34")]
	[FieldOffset(Offset = "0x40")]
	public Panel_Layout ResearchCogRight2;

	// Token: 0x04001C35 RID: 7221
	[Token(Token = "0x4001C35")]
	[FieldOffset(Offset = "0x44")]
	public Panel_Layout ResearchCogRight3;

	// Token: 0x04001C36 RID: 7222
	[Token(Token = "0x4001C36")]
	[FieldOffset(Offset = "0x48")]
	public Panel_Layout Divider;

	// Token: 0x04001C37 RID: 7223
	[Token(Token = "0x4001C37")]
	[FieldOffset(Offset = "0x4C")]
	public Panel_Layout Divider2;

	// Token: 0x04001C38 RID: 7224
	[Token(Token = "0x4001C38")]
	[FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Close;

	// Token: 0x04001C39 RID: 7225
	[Token(Token = "0x4001C39")]
	[FieldOffset(Offset = "0x54")]
	public TransactionButton_Layout ActionResearch;

	// Token: 0x04001C3A RID: 7226
	[Token(Token = "0x4001C3A")]
	[FieldOffset(Offset = "0x58")]
	public String_Layout ItemName;

	// Token: 0x04001C3B RID: 7227
	[Token(Token = "0x4001C3B")]
	[FieldOffset(Offset = "0x5C")]
	public String_Layout Description;

	// Token: 0x04001C3C RID: 7228
	[Token(Token = "0x4001C3C")]
	[FieldOffset(Offset = "0x60")]
	public Panel_Layout BarBacking;

	// Token: 0x04001C3D RID: 7229
	[Token(Token = "0x4001C3D")]
	[FieldOffset(Offset = "0x64")]
	public Panel_Layout CurrentProgress;

	// Token: 0x04001C3E RID: 7230
	[Token(Token = "0x4001C3E")]
	[FieldOffset(Offset = "0x68")]
	public Panel_Layout NewProgress;

	// Token: 0x04001C3F RID: 7231
	[Token(Token = "0x4001C3F")]
	[FieldOffset(Offset = "0x6C")]
	public String_Layout Progress;

	// Token: 0x04001C40 RID: 7232
	[Token(Token = "0x4001C40")]
	[FieldOffset(Offset = "0x70")]
	public String_Layout StackCount;
}
