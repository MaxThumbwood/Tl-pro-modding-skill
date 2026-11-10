using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020002D9 RID: 729
[Token(Token = "0x20002D9")]
public class GUISliderSetting : GUISettingEntry
{
	// Token: 0x0600120C RID: 4620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120C")]
	[Address(RVA = "0xD78B10", Offset = "0xD78B10", VA = "0xD78B10")]
	public GUISliderSetting(GUISettingID id)
	{
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600120D")]
	[Address(RVA = "0xD78BA0", Offset = "0xD78BA0", VA = "0xD78BA0", Slot = "7")]
	protected virtual SettingsOverlaySlider_Layout GetLayout()
	{
		return null;
	}

	// Token: 0x0600120E RID: 4622 RVA: 0x000086A0 File Offset: 0x000068A0
	[Token(Token = "0x600120E")]
	[Address(RVA = "0xD78C08", Offset = "0xD78C08", VA = "0xD78C08")]
	private Vector3 GetHSL()
	{
		return default(Vector3);
	}

	// Token: 0x0600120F RID: 4623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120F")]
	[Address(RVA = "0xD7937C", Offset = "0xD7937C", VA = "0xD7937C")]
	private void SetHSL(Vector3 hsl)
	{
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001210")]
	[Address(RVA = "0xD796E8", Offset = "0xD796E8", VA = "0xD796E8", Slot = "4")]
	public override void Draw()
	{
	}

	// Token: 0x06001211 RID: 4625 RVA: 0x000086B8 File Offset: 0x000068B8
	[Token(Token = "0x6001211")]
	[Address(RVA = "0xD7A2B4", Offset = "0xD7A2B4", VA = "0xD7A2B4", Slot = "5")]
	public override float GetElementHeight()
	{
		return 0f;
	}

	// Token: 0x06001212 RID: 4626 RVA: 0x000086D0 File Offset: 0x000068D0
	[Token(Token = "0x6001212")]
	[Address(RVA = "0xD7A2E8", Offset = "0xD7A2E8", VA = "0xD7A2E8", Slot = "8")]
	public virtual float GetValue()
	{
		return 0f;
	}

	// Token: 0x06001213 RID: 4627 RVA: 0x000086E8 File Offset: 0x000068E8
	[Token(Token = "0x6001213")]
	[Address(RVA = "0xD7AB4C", Offset = "0xD7AB4C", VA = "0xD7AB4C", Slot = "9")]
	public virtual int GetMaxValue()
	{
		return 0;
	}

	// Token: 0x06001214 RID: 4628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001214")]
	[Address(RVA = "0xD7AC10", Offset = "0xD7AC10", VA = "0xD7AC10", Slot = "10")]
	public virtual void SetValue(float value)
	{
	}

	// Token: 0x06001215 RID: 4629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001215")]
	[Address(RVA = "0xD7B648", Offset = "0xD7B648", VA = "0xD7B648", Slot = "11")]
	public virtual string GetStringValue()
	{
		return null;
	}

	// Token: 0x06001216 RID: 4630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001216")]
	[Address(RVA = "0xD7C104", Offset = "0xD7C104", VA = "0xD7C104", Slot = "12")]
	public virtual string GetTitle()
	{
		return null;
	}

	// Token: 0x04002380 RID: 9088
	[Token(Token = "0x4002380")]
	[FieldOffset(Offset = "0x14")]
	private float scale;

	// Token: 0x04002381 RID: 9089
	[Token(Token = "0x4002381")]
	[FieldOffset(Offset = "0x18")]
	protected float sliderValue;

	// Token: 0x04002382 RID: 9090
	[Token(Token = "0x4002382")]
	[FieldOffset(Offset = "0x1C")]
	private float TimeSinceModified;

	// Token: 0x04002383 RID: 9091
	[Token(Token = "0x4002383")]
	[FieldOffset(Offset = "0x20")]
	protected GUISlider.DragState dragState;

	// Token: 0x04002384 RID: 9092
	[Token(Token = "0x4002384")]
	[FieldOffset(Offset = "0x24")]
	protected GUISlider.DrawBackingHandler backingHandler;
}
