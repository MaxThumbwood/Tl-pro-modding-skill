using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000273 RID: 627
[Token(Token = "0x2000273")]
[Serializable]
public class VirtualControlsHardwareConfiguration_Layout
{
	// Token: 0x06000EB1 RID: 3761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB1")]
	[Address(RVA = "0xC9AAF0", Offset = "0xC9AAF0", VA = "0xC9AAF0")]
	public void Copy(VirtualControlsHardwareConfiguration_Layout other)
	{
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00007A28 File Offset: 0x00005C28
	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0xC9ACD8", Offset = "0xC9ACD8", VA = "0xC9ACD8")]
	public bool IsSame(VirtualControlsHardwareConfiguration_Layout other)
	{
		return default(bool);
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0xC9ADC4", Offset = "0xC9ADC4", VA = "0xC9ADC4")]
	public void LoadControlPositions()
	{
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB4")]
	[Address(RVA = "0xC9ADC8", Offset = "0xC9ADC8", VA = "0xC9ADC8")]
	public string GetDisplayName()
	{
		return null;
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB5")]
	[Address(RVA = "0xC9AE90", Offset = "0xC9AE90", VA = "0xC9AE90")]
	public VirtualControlsHardwareConfiguration_Layout()
	{
	}

	// Token: 0x04001E2E RID: 7726
	[Token(Token = "0x4001E2E")]
	[FieldOffset(Offset = "0x8")]
	public string Id;

	// Token: 0x04001E2F RID: 7727
	[Token(Token = "0x4001E2F")]
	[FieldOffset(Offset = "0xC")]
	public string EditedName;

	// Token: 0x04001E30 RID: 7728
	[Token(Token = "0x4001E30")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 LeftControlsPosition;

	// Token: 0x04001E31 RID: 7729
	[Token(Token = "0x4001E31")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 RightControlsPosition;

	// Token: 0x04001E32 RID: 7730
	[Token(Token = "0x4001E32")]
	[FieldOffset(Offset = "0x20")]
	public VirtualControlsHardwareConfigurationMapping_Layout[] Slots;
}
