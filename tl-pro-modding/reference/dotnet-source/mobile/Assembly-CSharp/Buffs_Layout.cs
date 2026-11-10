using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001AC RID: 428
[Token(Token = "0x20001AC")]
public class Buffs_Layout : LayoutDefinition
{
	// Token: 0x1700012A RID: 298
	// (get) Token: 0x06000C7F RID: 3199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700012A")]
	public static Buffs_Layout Instance
	{
		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0xC66D64", Offset = "0xC66D64", VA = "0xC66D64")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C80")]
	[Address(RVA = "0xC66E18", Offset = "0xC66E18", VA = "0xC66E18")]
	private void Awake()
	{
	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C81")]
	[Address(RVA = "0xC66EA0", Offset = "0xC66EA0", VA = "0xC66EA0")]
	public Buffs_Layout()
	{
	}

	// Token: 0x04001036 RID: 4150
	[Token(Token = "0x4001036")]
	[FieldOffset(Offset = "0x0")]
	public static Buffs_Layout InstanceNormal;

	// Token: 0x04001037 RID: 4151
	[Token(Token = "0x4001037")]
	[FieldOffset(Offset = "0x4")]
	public static Buffs_Layout Instance4Page;

	// Token: 0x04001038 RID: 4152
	[Token(Token = "0x4001038")]
	[FieldOffset(Offset = "0xC")]
	public ItemGrid_Layout BuffsGrid;

	// Token: 0x04001039 RID: 4153
	[Token(Token = "0x4001039")]
	[FieldOffset(Offset = "0x10")]
	public ItemGrid_Layout HorizontalBuffsGrid;

	// Token: 0x0400103A RID: 4154
	[Token(Token = "0x400103A")]
	[FieldOffset(Offset = "0x14")]
	public float ItemScale;

	// Token: 0x0400103B RID: 4155
	[Token(Token = "0x400103B")]
	[FieldOffset(Offset = "0x18")]
	public float SelectedScale;

	// Token: 0x0400103C RID: 4156
	[Token(Token = "0x400103C")]
	[FieldOffset(Offset = "0x1C")]
	public float BaseTextScale;

	// Token: 0x0400103D RID: 4157
	[Token(Token = "0x400103D")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 TextOffset;

	// Token: 0x0400103E RID: 4158
	[Token(Token = "0x400103E")]
	[FieldOffset(Offset = "0x28")]
	public Color SelectedColour;

	// Token: 0x0400103F RID: 4159
	[Token(Token = "0x400103F")]
	[FieldOffset(Offset = "0x2C")]
	public Color NormalColour;

	// Token: 0x04001040 RID: 4160
	[Token(Token = "0x4001040")]
	[FieldOffset(Offset = "0x30")]
	public Color SelectedTextColour;

	// Token: 0x04001041 RID: 4161
	[Token(Token = "0x4001041")]
	[FieldOffset(Offset = "0x34")]
	public Color NormalTextColour;

	// Token: 0x04001042 RID: 4162
	[Token(Token = "0x4001042")]
	[FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout ApplyBuff;
}
