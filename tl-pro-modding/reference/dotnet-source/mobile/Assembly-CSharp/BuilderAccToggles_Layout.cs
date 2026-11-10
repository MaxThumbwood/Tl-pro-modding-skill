using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001AD RID: 429
[Token(Token = "0x20001AD")]
public class BuilderAccToggles_Layout : LayoutDefinition
{
	// Token: 0x1700012B RID: 299
	// (get) Token: 0x06000C82 RID: 3202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700012B")]
	public static BuilderAccToggles_Layout Instance
	{
		[Token(Token = "0x6000C82")]
		[Address(RVA = "0xC66FFC", Offset = "0xC66FFC", VA = "0xC66FFC")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x06000C83 RID: 3203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700012C")]
	public ItemGrid_Layout ToggleOptionsGrid
	{
		[Token(Token = "0x6000C83")]
		[Address(RVA = "0xC670B0", Offset = "0xC670B0", VA = "0xC670B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C84")]
	[Address(RVA = "0xC67150", Offset = "0xC67150", VA = "0xC67150")]
	private void Awake()
	{
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C85")]
	[Address(RVA = "0xC671D8", Offset = "0xC671D8", VA = "0xC671D8")]
	public BuilderAccToggles_Layout()
	{
	}

	// Token: 0x04001043 RID: 4163
	[Token(Token = "0x4001043")]
	[FieldOffset(Offset = "0x0")]
	public static BuilderAccToggles_Layout InstanceNormal;

	// Token: 0x04001044 RID: 4164
	[Token(Token = "0x4001044")]
	[FieldOffset(Offset = "0x4")]
	public static BuilderAccToggles_Layout Instance4Page;

	// Token: 0x04001045 RID: 4165
	[Token(Token = "0x4001045")]
	[FieldOffset(Offset = "0xC")]
	public TransactionButton_Layout ControllerToggleBuilderAccessories;

	// Token: 0x04001046 RID: 4166
	[Token(Token = "0x4001046")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout ToggleBuilderAccessories;

	// Token: 0x04001047 RID: 4167
	[Token(Token = "0x4001047")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout ToggleBuilderAccessories_Horizontal;

	// Token: 0x04001048 RID: 4168
	[Token(Token = "0x4001048")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 BackingTLOffset;

	// Token: 0x04001049 RID: 4169
	[Token(Token = "0x4001049")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 BackingBROffset;

	// Token: 0x0400104A RID: 4170
	[Token(Token = "0x400104A")]
	[FieldOffset(Offset = "0x28")]
	public Panel_Layout Backing;

	// Token: 0x0400104B RID: 4171
	[Token(Token = "0x400104B")]
	[FieldOffset(Offset = "0x2C")]
	public float ToggleScale;

	// Token: 0x0400104C RID: 4172
	[Token(Token = "0x400104C")]
	[FieldOffset(Offset = "0x30")]
	public float ToggleIconScale;

	// Token: 0x0400104D RID: 4173
	[Token(Token = "0x400104D")]
	[FieldOffset(Offset = "0x34")]
	public ItemGrid_Layout ToggleOptions;

	// Token: 0x0400104E RID: 4174
	[Token(Token = "0x400104E")]
	[FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout ToggleOptions_Horizontal;

	// Token: 0x0400104F RID: 4175
	[Token(Token = "0x400104F")]
	[FieldOffset(Offset = "0x3C")]
	public TransactionButton_Layout ToggleEntry;

	// Token: 0x04001050 RID: 4176
	[Token(Token = "0x4001050")]
	[FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout ToggleSmartStackEntry;

	// Token: 0x04001051 RID: 4177
	[Token(Token = "0x4001051")]
	[FieldOffset(Offset = "0x44")]
	public Texture_Layout SmartStackOn;

	// Token: 0x04001052 RID: 4178
	[Token(Token = "0x4001052")]
	[FieldOffset(Offset = "0x48")]
	public Texture_Layout SmartStackOff;

	// Token: 0x04001053 RID: 4179
	[Token(Token = "0x4001053")]
	[FieldOffset(Offset = "0x4C")]
	public Texture_Layout ChestCraftOn;

	// Token: 0x04001054 RID: 4180
	[Token(Token = "0x4001054")]
	[FieldOffset(Offset = "0x50")]
	public Texture_Layout ChestCraftOff;

	// Token: 0x04001055 RID: 4181
	[Token(Token = "0x4001055")]
	[FieldOffset(Offset = "0x54")]
	public TransactionButton_Layout ToggleChestCraftEntry;

	// Token: 0x04001056 RID: 4182
	[Token(Token = "0x4001056")]
	[FieldOffset(Offset = "0x58")]
	public Texture_Layout AccBackingTexture;

	// Token: 0x04001057 RID: 4183
	[Token(Token = "0x4001057")]
	[FieldOffset(Offset = "0x5C")]
	public Color AccBackingColour;

	// Token: 0x04001058 RID: 4184
	[Token(Token = "0x4001058")]
	[FieldOffset(Offset = "0x60")]
	public Texture_Layout AccHighlightTexture;

	// Token: 0x04001059 RID: 4185
	[Token(Token = "0x4001059")]
	[FieldOffset(Offset = "0x64")]
	public Color AccHighlightColour;

	// Token: 0x0400105A RID: 4186
	[Token(Token = "0x400105A")]
	[FieldOffset(Offset = "0x68")]
	public FadeString_Layout TooltipDisplay;
}
