using System;
using Controller;
using Il2CppDummyDll;
using InControl;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020000C3 RID: 195
[Token(Token = "0x20000C3")]
public class GUIControllerHardwareProfileEntry : GUIControllerMappingEntryBase
{
	// Token: 0x060004CA RID: 1226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CA")]
	[Address(RVA = "0xE5979C", Offset = "0xE5979C", VA = "0xE5979C")]
	public GUIControllerHardwareProfileEntry(GUIControllerHardwareProfileEntry.BindingId id, ControllerDevice device)
	{
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CB")]
	[Address(RVA = "0xE57A44", Offset = "0xE57A44", VA = "0xE57A44")]
	public void CloseOptions()
	{
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004CC")]
	[Address(RVA = "0xE59AF4", Offset = "0xE59AF4", VA = "0xE59AF4")]
	private string GetMappingName()
	{
		return null;
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x000037C8 File Offset: 0x000019C8
	[Token(Token = "0x60004CD")]
	[Address(RVA = "0xE59AD0", Offset = "0xE59AD0", VA = "0xE59AD0")]
	private InputControlType GetMappingType()
	{
		return InputControlType.None;
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x060004CE RID: 1230 RVA: 0x000037E0 File Offset: 0x000019E0
	[Token(Token = "0x17000085")]
	public bool HasMapping
	{
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xE59274", Offset = "0xE59274", VA = "0xE59274")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CF")]
	[Address(RVA = "0xE59EFC", Offset = "0xE59EFC", VA = "0xE59EFC", Slot = "6")]
	public override void DrawOverlay()
	{
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D0")]
	[Address(RVA = "0xE59F2C", Offset = "0xE59F2C", VA = "0xE59F2C")]
	public void RemoveBinding()
	{
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D1")]
	[Address(RVA = "0xE59F38", Offset = "0xE59F38", VA = "0xE59F38")]
	private void RemapToAnalogue(int index, float restingValue, float usedValue)
	{
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D2")]
	[Address(RVA = "0xE5A108", Offset = "0xE5A108", VA = "0xE5A108")]
	private void RemapToButton(int index)
	{
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D3")]
	[Address(RVA = "0xE5A250", Offset = "0xE5A250", VA = "0xE5A250")]
	private Texture2D GetTexure(out Rectangle buttonRegion)
	{
		return null;
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D4")]
	[Address(RVA = "0xE5A80C", Offset = "0xE5A80C", VA = "0xE5A80C", Slot = "4")]
	public override void Draw()
	{
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x000037F8 File Offset: 0x000019F8
	[Token(Token = "0x60004D5")]
	[Address(RVA = "0xE5B548", Offset = "0xE5B548", VA = "0xE5B548", Slot = "5")]
	public override float GetElementHeight()
	{
		return 0f;
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x00003810 File Offset: 0x00001A10
	[Token(Token = "0x60004D6")]
	[Address(RVA = "0xE5B5C0", Offset = "0xE5B5C0", VA = "0xE5B5C0")]
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x040006BD RID: 1725
	[Token(Token = "0x40006BD")]
	[FieldOffset(Offset = "0x1C")]
	private readonly ControllerDevice _device;

	// Token: 0x040006BE RID: 1726
	[Token(Token = "0x40006BE")]
	[FieldOffset(Offset = "0x20")]
	public new readonly GUIControllerHardwareProfileEntry.BindingId _id;

	// Token: 0x040006BF RID: 1727
	[Token(Token = "0x40006BF")]
	[FieldOffset(Offset = "0x24")]
	public InputControlMapping Binding;

	// Token: 0x040006C0 RID: 1728
	[Token(Token = "0x40006C0")]
	[FieldOffset(Offset = "0x28")]
	private float buttonScale;

	// Token: 0x040006C1 RID: 1729
	[Token(Token = "0x40006C1")]
	[FieldOffset(Offset = "0x2C")]
	private float scale;

	// Token: 0x040006C2 RID: 1730
	[Token(Token = "0x40006C2")]
	[FieldOffset(Offset = "0x30")]
	private bool drawingOverlay;

	// Token: 0x040006C3 RID: 1731
	[Token(Token = "0x40006C3")]
	[FieldOffset(Offset = "0x0")]
	private static int LastButtonMapped;

	// Token: 0x040006C4 RID: 1732
	[Token(Token = "0x40006C4")]
	private const float inputTollerance = 0.1f;

	// Token: 0x040006C5 RID: 1733
	[Token(Token = "0x40006C5")]
	[FieldOffset(Offset = "0x4")]
	private static float[] InitialInputRange;

	// Token: 0x040006C6 RID: 1734
	[Token(Token = "0x40006C6")]
	[FieldOffset(Offset = "0x31")]
	public bool displayOptions;

	// Token: 0x040006C7 RID: 1735
	[Token(Token = "0x40006C7")]
	[FieldOffset(Offset = "0x34")]
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x040006C8 RID: 1736
	[Token(Token = "0x40006C8")]
	[FieldOffset(Offset = "0x38")]
	public new KeyboardMappingsCategories_Layout.Category Category;

	// Token: 0x040006C9 RID: 1737
	[Token(Token = "0x40006C9")]
	[FieldOffset(Offset = "0x3C")]
	public new int SortOrder;

	// Token: 0x020000C4 RID: 196
	[Token(Token = "0x20000C4")]
	public enum BindingId
	{
		// Token: 0x040006CB RID: 1739
		[Token(Token = "0x40006CB")]
		LeftStickUp,
		// Token: 0x040006CC RID: 1740
		[Token(Token = "0x40006CC")]
		LeftStickDown,
		// Token: 0x040006CD RID: 1741
		[Token(Token = "0x40006CD")]
		LeftStickLeft,
		// Token: 0x040006CE RID: 1742
		[Token(Token = "0x40006CE")]
		LeftStickRight,
		// Token: 0x040006CF RID: 1743
		[Token(Token = "0x40006CF")]
		RightStickUp,
		// Token: 0x040006D0 RID: 1744
		[Token(Token = "0x40006D0")]
		RightStickDown,
		// Token: 0x040006D1 RID: 1745
		[Token(Token = "0x40006D1")]
		RightStickLeft,
		// Token: 0x040006D2 RID: 1746
		[Token(Token = "0x40006D2")]
		RightStickRight,
		// Token: 0x040006D3 RID: 1747
		[Token(Token = "0x40006D3")]
		DPadUp,
		// Token: 0x040006D4 RID: 1748
		[Token(Token = "0x40006D4")]
		DPadDown,
		// Token: 0x040006D5 RID: 1749
		[Token(Token = "0x40006D5")]
		DPadLeft,
		// Token: 0x040006D6 RID: 1750
		[Token(Token = "0x40006D6")]
		DPadRight,
		// Token: 0x040006D7 RID: 1751
		[Token(Token = "0x40006D7")]
		Action1,
		// Token: 0x040006D8 RID: 1752
		[Token(Token = "0x40006D8")]
		Action2,
		// Token: 0x040006D9 RID: 1753
		[Token(Token = "0x40006D9")]
		Action3,
		// Token: 0x040006DA RID: 1754
		[Token(Token = "0x40006DA")]
		Action4,
		// Token: 0x040006DB RID: 1755
		[Token(Token = "0x40006DB")]
		Options,
		// Token: 0x040006DC RID: 1756
		[Token(Token = "0x40006DC")]
		Switch,
		// Token: 0x040006DD RID: 1757
		[Token(Token = "0x40006DD")]
		LeftShoulder,
		// Token: 0x040006DE RID: 1758
		[Token(Token = "0x40006DE")]
		LeftTrigger,
		// Token: 0x040006DF RID: 1759
		[Token(Token = "0x40006DF")]
		LeftStickClick,
		// Token: 0x040006E0 RID: 1760
		[Token(Token = "0x40006E0")]
		RightShoulder,
		// Token: 0x040006E1 RID: 1761
		[Token(Token = "0x40006E1")]
		RightTrigger,
		// Token: 0x040006E2 RID: 1762
		[Token(Token = "0x40006E2")]
		RightStickClick,
		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x40006E3")]
		Count
	}
}
