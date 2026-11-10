using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020002DA RID: 730
[Token(Token = "0x20002DA")]
public class GUIToggleSetting : GUISettingEntry
{
	// Token: 0x06001217 RID: 4631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001217")]
	[Address(RVA = "0xD7CA28", Offset = "0xD7CA28", VA = "0xD7CA28")]
	public static void LoadContent(ContentManager content)
	{
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001218")]
	[Address(RVA = "0xD7CB68", Offset = "0xD7CB68", VA = "0xD7CB68")]
	public GUIToggleSetting(GUISettingID id)
	{
	}

	// Token: 0x06001219 RID: 4633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001219")]
	[Address(RVA = "0xD7CB84", Offset = "0xD7CB84", VA = "0xD7CB84", Slot = "7")]
	protected virtual SettingsOverlayToggle_Layout GetLayout()
	{
		return null;
	}

	// Token: 0x0600121A RID: 4634 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600121A")]
	[Address(RVA = "0xD7CBEC", Offset = "0xD7CBEC", VA = "0xD7CBEC", Slot = "8")]
	protected virtual SettingsOverlayToggle_Layout GetDisabledLayout()
	{
		return null;
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x00008700 File Offset: 0x00006900
	[Token(Token = "0x600121B")]
	[Address(RVA = "0xD7CC54", Offset = "0xD7CC54", VA = "0xD7CC54", Slot = "9")]
	protected virtual bool IsDisabled()
	{
		return default(bool);
	}

	// Token: 0x0600121C RID: 4636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121C")]
	[Address(RVA = "0xD7CDB0", Offset = "0xD7CDB0", VA = "0xD7CDB0", Slot = "4")]
	public override void Draw()
	{
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121D")]
	[Address(RVA = "0xD7D64C", Offset = "0xD7D64C", VA = "0xD7D64C")]
	private static void ScaleLabelToFit(String_Layout layout, float buttonWidth, float Pad, ref float MaxScale, ref float OrigTextX, string text)
	{
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x00008718 File Offset: 0x00006918
	[Token(Token = "0x600121E")]
	[Address(RVA = "0xD7D7E4", Offset = "0xD7D7E4", VA = "0xD7D7E4", Slot = "5")]
	public override float GetElementHeight()
	{
		return 0f;
	}

	// Token: 0x0600121F RID: 4639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600121F")]
	[Address(RVA = "0xD7D818", Offset = "0xD7D818", VA = "0xD7D818", Slot = "10")]
	protected virtual string GetOptionOn()
	{
		return null;
	}

	// Token: 0x06001220 RID: 4640 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001220")]
	[Address(RVA = "0xD7DADC", Offset = "0xD7DADC", VA = "0xD7DADC", Slot = "11")]
	protected virtual string GetOptionOff()
	{
		return null;
	}

	// Token: 0x06001221 RID: 4641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001221")]
	[Address(RVA = "0xD7DDA0", Offset = "0xD7DDA0", VA = "0xD7DDA0", Slot = "12")]
	protected virtual string GetOption()
	{
		return null;
	}

	// Token: 0x06001222 RID: 4642 RVA: 0x00008730 File Offset: 0x00006930
	[Token(Token = "0x6001222")]
	[Address(RVA = "0xD7EF40", Offset = "0xD7EF40", VA = "0xD7EF40", Slot = "13")]
	protected virtual bool GetSelected()
	{
		return default(bool);
	}

	// Token: 0x06001223 RID: 4643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001223")]
	[Address(RVA = "0xD80324", Offset = "0xD80324", VA = "0xD80324", Slot = "14")]
	public virtual void Toggle()
	{
	}

	// Token: 0x04002385 RID: 9093
	[Token(Token = "0x4002385")]
	[FieldOffset(Offset = "0x0")]
	private static Texture2D ToggleOff;

	// Token: 0x04002386 RID: 9094
	[Token(Token = "0x4002386")]
	[FieldOffset(Offset = "0x4")]
	private static Texture2D ToggleOn;

	// Token: 0x04002387 RID: 9095
	[Token(Token = "0x4002387")]
	[FieldOffset(Offset = "0x14")]
	private float scale;

	// Token: 0x020002DB RID: 731
	[Token(Token = "0x20002DB")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001225 RID: 4645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001225")]
		[Address(RVA = "0xD81D24", Offset = "0xD81D24", VA = "0xD81D24")]
		public <>c()
		{
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001226")]
		[Address(RVA = "0xD81D2C", Offset = "0xD81D2C", VA = "0xD81D2C")]
		internal void <Toggle>b__15_0()
		{
		}

		// Token: 0x04002388 RID: 9096
		[Token(Token = "0x4002388")]
		[FieldOffset(Offset = "0x0")]
		public static readonly GUIToggleSetting.<>c <>9;

		// Token: 0x04002389 RID: 9097
		[Token(Token = "0x4002389")]
		[FieldOffset(Offset = "0x4")]
		public static Action <>9__15_0;
	}
}
