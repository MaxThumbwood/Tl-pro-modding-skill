using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002D RID: 45
[Token(Token = "0x200002D")]
public class Alert : Singleton<Alert>
{
	// Token: 0x060000D5 RID: 213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x49E26C", Offset = "0x49E26C", VA = "0x49E26C", Slot = "4")]
	public override void Init()
	{
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x49E270", Offset = "0x49E270", VA = "0x49E270", Slot = "5")]
	public override void Shutdown()
	{
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x49E274", Offset = "0x49E274", VA = "0x49E274")]
	private void PCDismissCallback(int index)
	{
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x49E290", Offset = "0x49E290", VA = "0x49E290")]
	public void InternalShowDelayed(Alert.AlertShownReason reason, string title, string message, string button, string hapticId = "")
	{
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x49E29C", Offset = "0x49E29C", VA = "0x49E29C")]
	public void InternalShowDelayed(Alert.AlertShownReason reason, string title, string message, string button1, string button2, string buttonDefault, string hapticId = "")
	{
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x49E2A8", Offset = "0x49E2A8", VA = "0x49E2A8")]
	private AlertDelayer GetAlertDelayObject()
	{
		return null;
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x49E40C", Offset = "0x49E40C", VA = "0x49E40C")]
	public void Show(Alert.AlertShownReason reason, string title, string message, string button, string hapticId = "")
	{
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x49E49C", Offset = "0x49E49C", VA = "0x49E49C")]
	public void Show(Alert.AlertShownReason reason, string title, string message, string button1, string button2, string buttonDefault, string hapticId = "")
	{
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x060000DD RID: 221 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x060000DE RID: 222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000001")]
	public event Action<int> DismissedWithButton
	{
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x49E55C", Offset = "0x49E55C", VA = "0x49E55C")]
		add
		{
		}
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x49E624", Offset = "0x49E624", VA = "0x49E624")]
		remove
		{
		}
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x49E6EC", Offset = "0x49E6EC", VA = "0x49E6EC")]
	private void AlertButtonClicked(string button)
	{
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x49ECD4", Offset = "0x49ECD4", VA = "0x49ECD4")]
	private void AlertCancelled()
	{
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x49ECFC", Offset = "0x49ECFC", VA = "0x49ECFC")]
	public Alert()
	{
	}

	// Token: 0x040002E8 RID: 744
	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x10")]
	private string[] _buttons;

	// Token: 0x040002E9 RID: 745
	[Token(Token = "0x40002E9")]
	[FieldOffset(Offset = "0x14")]
	private string _defaultButton;

	// Token: 0x040002EA RID: 746
	[Token(Token = "0x40002EA")]
	[FieldOffset(Offset = "0x18")]
	private GameObject _delayObject;

	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public enum AlertShownReason
	{
		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		PlatformError,
		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		NetworkingIssue,
		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		DebugIAP,
		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		ToolsMistake,
		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		AppRating
	}
}
