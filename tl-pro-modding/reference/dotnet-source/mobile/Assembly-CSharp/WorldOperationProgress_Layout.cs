using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200027D RID: 637
[Token(Token = "0x200027D")]
public class WorldOperationProgress_Layout : LayoutDefinition
{
	// Token: 0x06000ED7 RID: 3799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED7")]
	[Address(RVA = "0xC9E8F4", Offset = "0xC9E8F4", VA = "0xC9E8F4")]
	private void Awake()
	{
	}

	// Token: 0x06000ED8 RID: 3800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED8")]
	[Address(RVA = "0xC9E948", Offset = "0xC9E948", VA = "0xC9E948")]
	public WorldOperationProgress_Layout()
	{
	}

	// Token: 0x04001EBC RID: 7868
	[Token(Token = "0x4001EBC")]
	[FieldOffset(Offset = "0x0")]
	public static WorldOperationProgress_Layout Instance;

	// Token: 0x04001EBD RID: 7869
	[Token(Token = "0x4001EBD")]
	[FieldOffset(Offset = "0xC")]
	public bool Enabled;

	// Token: 0x04001EBE RID: 7870
	[Token(Token = "0x4001EBE")]
	[FieldOffset(Offset = "0xD")]
	public bool FullHMStatus;

	// Token: 0x04001EBF RID: 7871
	[Token(Token = "0x4001EBF")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	// Token: 0x04001EC0 RID: 7872
	[Token(Token = "0x4001EC0")]
	[FieldOffset(Offset = "0x14")]
	public Button_Layout ProgressIcon;

	// Token: 0x04001EC1 RID: 7873
	[Token(Token = "0x4001EC1")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve HMIconScale;

	// Token: 0x04001EC2 RID: 7874
	[Token(Token = "0x4001EC2")]
	[FieldOffset(Offset = "0x1C")]
	public AnimationCurve HMIconAlpha;

	// Token: 0x04001EC3 RID: 7875
	[Token(Token = "0x4001EC3")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout HMConversionIcon;
}
