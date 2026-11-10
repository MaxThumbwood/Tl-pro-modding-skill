using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Controller;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020002D3 RID: 723
[Token(Token = "0x20002D3")]
public class GUIPulldownSetting : GUISettingEntry
{
	// Token: 0x060011E8 RID: 4584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E8")]
	[Address(RVA = "0xD6C758", Offset = "0xD6C758", VA = "0xD6C758")]
	public GUIPulldownSetting(GUISettingID id, [Optional] GUIPulldownSetting.ActivateOverlayCallback activateOverlayCallbackOverload, [Optional] GUIPulldownSetting.DeactivateOverlayCallback deactivateOverlayCallbackOverload, [Optional] GUIPulldownSetting.RegisterOverlay registerOverlayOverload)
	{
	}

	// Token: 0x060011E9 RID: 4585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E9")]
	[Address(RVA = "0xD6C7B4", Offset = "0xD6C7B4", VA = "0xD6C7B4")]
	public void CloseOptions()
	{
	}

	// Token: 0x060011EA RID: 4586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011EA")]
	[Address(RVA = "0xD6C8D8", Offset = "0xD6C8D8", VA = "0xD6C8D8", Slot = "6")]
	public override void DrawOverlay()
	{
	}

	// Token: 0x060011EB RID: 4587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011EB")]
	[Address(RVA = "0xD6C908", Offset = "0xD6C908", VA = "0xD6C908")]
	private void DrawFaceButtons()
	{
	}

	// Token: 0x060011EC RID: 4588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011EC")]
	[Address(RVA = "0xD6CE94", Offset = "0xD6CE94", VA = "0xD6CE94")]
	private void DrawOptionFaceButtons(ControllerDevice.ControlScheme scheme)
	{
	}

	// Token: 0x060011ED RID: 4589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011ED")]
	[Address(RVA = "0xD6D2F0", Offset = "0xD6D2F0", VA = "0xD6D2F0")]
	public void RefreshInputRegion()
	{
	}

	// Token: 0x060011EE RID: 4590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011EE")]
	[Address(RVA = "0xD6E320", Offset = "0xD6E320", VA = "0xD6E320", Slot = "7")]
	public virtual SettingsOverlayPulldown_Layout GetLayout()
	{
		return null;
	}

	// Token: 0x060011EF RID: 4591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011EF")]
	[Address(RVA = "0xD6E388", Offset = "0xD6E388", VA = "0xD6E388", Slot = "4")]
	public override void Draw()
	{
	}

	// Token: 0x060011F0 RID: 4592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F0")]
	[Address(RVA = "0xD716D4", Offset = "0xD716D4", VA = "0xD716D4")]
	public void DisablePulldown()
	{
	}

	// Token: 0x060011F1 RID: 4593 RVA: 0x00008628 File Offset: 0x00006828
	[Token(Token = "0x60011F1")]
	[Address(RVA = "0xD71800", Offset = "0xD71800", VA = "0xD71800", Slot = "5")]
	public override float GetElementHeight()
	{
		return 0f;
	}

	// Token: 0x060011F2 RID: 4594 RVA: 0x00008640 File Offset: 0x00006840
	[Token(Token = "0x60011F2")]
	[Address(RVA = "0xD71834", Offset = "0xD71834", VA = "0xD71834", Slot = "8")]
	protected virtual bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x060011F3 RID: 4595 RVA: 0x00008658 File Offset: 0x00006858
	[Token(Token = "0x60011F3")]
	[Address(RVA = "0xD719C4", Offset = "0xD719C4", VA = "0xD719C4", Slot = "9")]
	public virtual int GetNumberOfOptions()
	{
		return 0;
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x060011F4 RID: 4596 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001B3")]
	protected static List<int> optionRedirection
	{
		[Token(Token = "0x60011F4")]
		[Address(RVA = "0xD6E2A4", Offset = "0xD6E2A4", VA = "0xD6E2A4")]
		get
		{
			return null;
		}
	}

	// Token: 0x060011F5 RID: 4597 RVA: 0x00008670 File Offset: 0x00006870
	[Token(Token = "0x60011F5")]
	[Address(RVA = "0xD71E1C", Offset = "0xD71E1C", VA = "0xD71E1C", Slot = "10")]
	protected virtual bool OptionDisabled(int index)
	{
		return default(bool);
	}

	// Token: 0x060011F6 RID: 4598 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011F6")]
	[Address(RVA = "0xD71E7C", Offset = "0xD71E7C", VA = "0xD71E7C", Slot = "11")]
	protected virtual string GetOption(int index)
	{
		return null;
	}

	// Token: 0x060011F7 RID: 4599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F7")]
	[Address(RVA = "0xD73F8C", Offset = "0xD73F8C", VA = "0xD73F8C", Slot = "12")]
	protected virtual void SetOption(int index)
	{
	}

	// Token: 0x060011F8 RID: 4600 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011F8")]
	[Address(RVA = "0xD7085C", Offset = "0xD7085C", VA = "0xD7085C")]
	private string GetTitle()
	{
		return null;
	}

	// Token: 0x060011F9 RID: 4601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011F9")]
	[Address(RVA = "0xD73C00", Offset = "0xD73C00", VA = "0xD73C00")]
	private string GetLanguageFromLegacyId(int legacyId)
	{
		return null;
	}

	// Token: 0x060011FA RID: 4602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011FA")]
	[Address(RVA = "0xD75D7C", Offset = "0xD75D7C", VA = "0xD75D7C", Slot = "13")]
	protected virtual string GetValue()
	{
		return null;
	}

	// Token: 0x040022B1 RID: 8881
	[Token(Token = "0x40022B1")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	protected GUIPulldownSetting.ActivateOverlayCallback activateOverlayCallback;

	// Token: 0x040022B2 RID: 8882
	[Token(Token = "0x40022B2")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected GUIPulldownSetting.DeactivateOverlayCallback deactivateOverlayCallback;

	// Token: 0x040022B3 RID: 8883
	[Token(Token = "0x40022B3")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected GUIPulldownSetting.RegisterOverlay registerOverlayCallback;

	// Token: 0x040022B4 RID: 8884
	[Token(Token = "0x40022B4")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected float scale;

	// Token: 0x040022B5 RID: 8885
	[Token(Token = "0x40022B5")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool drawingOverlay;

	// Token: 0x040022B6 RID: 8886
	[Token(Token = "0x40022B6")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int selectedPosition;

	// Token: 0x040022B7 RID: 8887
	[Token(Token = "0x40022B7")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	protected float _offset;

	// Token: 0x040022B8 RID: 8888
	[Token(Token = "0x40022B8")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected int TextWrapOffset;

	// Token: 0x040022B9 RID: 8889
	[Token(Token = "0x40022B9")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool displayOptions;

	// Token: 0x040022BA RID: 8890
	[Token(Token = "0x40022BA")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x040022BB RID: 8891
	[Token(Token = "0x40022BB")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int[] LanguageMappingIndices;

	// Token: 0x020002D4 RID: 724
	// (Invoke) Token: 0x060011FD RID: 4605
	[Token(Token = "0x20002D4")]
	public delegate void ActivateOverlayCallback(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset);

	// Token: 0x020002D5 RID: 725
	// (Invoke) Token: 0x06001201 RID: 4609
	[Token(Token = "0x20002D5")]
	public delegate void RegisterOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion);

	// Token: 0x020002D6 RID: 726
	// (Invoke) Token: 0x06001205 RID: 4613
	[Token(Token = "0x20002D6")]
	public delegate void DeactivateOverlayCallback();
}
