using System;
using Controller;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000AA RID: 170
[Token(Token = "0x20000AA")]
public class GUIControllerNavigationController
{
	// Token: 0x17000081 RID: 129
	// (get) Token: 0x06000441 RID: 1089 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000081")]
	public Cursor UICursor
	{
		[Token(Token = "0x6000441")]
		[Address(RVA = "0xD60C40", Offset = "0xD60C40", VA = "0xD60C40")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000442")]
	[Address(RVA = "0xD60C54", Offset = "0xD60C54", VA = "0xD60C54")]
	public void SetupMappings()
	{
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000443")]
	[Address(RVA = "0xD620F8", Offset = "0xD620F8", VA = "0xD620F8")]
	public void Activate()
	{
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x06000444 RID: 1092 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000082")]
	public ControllerActionVector NavigationAxis
	{
		[Token(Token = "0x6000444")]
		[Address(RVA = "0xD621F8", Offset = "0xD621F8", VA = "0xD621F8")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000445")]
	[Address(RVA = "0xD62878", Offset = "0xD62878", VA = "0xD62878")]
	public void UpdateUINavigation(float elapsedTime)
	{
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000446")]
	[Address(RVA = "0xD63F10", Offset = "0xD63F10", VA = "0xD63F10")]
	public void UpdateCursorPosition()
	{
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x06000447 RID: 1095 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000448 RID: 1096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000083")]
	public GUIControllerItem CurrentNavigationItem
	{
		[Token(Token = "0x6000447")]
		[Address(RVA = "0xD64264", Offset = "0xD64264", VA = "0xD64264")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000448")]
		[Address(RVA = "0xD63F00", Offset = "0xD63F00", VA = "0xD63F00")]
		set
		{
		}
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000449")]
	[Address(RVA = "0xD6426C", Offset = "0xD6426C", VA = "0xD6426C")]
	public void DisableNavigationFromAxis(int fromAxis = -1)
	{
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x000033F0 File Offset: 0x000015F0
	[Token(Token = "0x600044A")]
	[Address(RVA = "0xD6427C", Offset = "0xD6427C", VA = "0xD6427C")]
	public bool Pressed(GUIControllerInputButton.LinkedControlType action)
	{
		return default(bool);
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00003408 File Offset: 0x00001608
	[Token(Token = "0x600044B")]
	[Address(RVA = "0xD642A0", Offset = "0xD642A0", VA = "0xD642A0")]
	public bool Pressed(int action)
	{
		return default(bool);
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x00003420 File Offset: 0x00001620
	[Token(Token = "0x600044C")]
	[Address(RVA = "0xD642C4", Offset = "0xD642C4", VA = "0xD642C4")]
	public bool PressedTriggered(GUIControllerInputButton.LinkedControlType action)
	{
		return default(bool);
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600044D")]
	[Address(RVA = "0xD6436C", Offset = "0xD6436C", VA = "0xD6436C")]
	public void ClearUIPressed()
	{
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00003438 File Offset: 0x00001638
	[Token(Token = "0x600044E")]
	[Address(RVA = "0xD64318", Offset = "0xD64318", VA = "0xD64318")]
	public bool PressedTriggered(int action)
	{
		return default(bool);
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x00003450 File Offset: 0x00001650
	[Token(Token = "0x600044F")]
	[Address(RVA = "0xD64508", Offset = "0xD64508", VA = "0xD64508")]
	public bool PressedReleased(GUIControllerInputButton.LinkedControlType action)
	{
		return default(bool);
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x00003468 File Offset: 0x00001668
	[Token(Token = "0x6000450")]
	[Address(RVA = "0xD64560", Offset = "0xD64560", VA = "0xD64560")]
	public bool PressedReleased(int action)
	{
		return default(bool);
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x00003480 File Offset: 0x00001680
	[Token(Token = "0x6000451")]
	[Address(RVA = "0xD645B8", Offset = "0xD645B8", VA = "0xD645B8")]
	public bool NextPagePressed()
	{
		return default(bool);
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x00003498 File Offset: 0x00001698
	[Token(Token = "0x6000452")]
	[Address(RVA = "0xD64648", Offset = "0xD64648", VA = "0xD64648")]
	public bool PreviousPagePressed()
	{
		return default(bool);
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x000034B0 File Offset: 0x000016B0
	[Token(Token = "0x6000453")]
	[Address(RVA = "0xD646D8", Offset = "0xD646D8", VA = "0xD646D8")]
	public bool SettingsPressed()
	{
		return default(bool);
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000454")]
	[Address(RVA = "0xD64768", Offset = "0xD64768", VA = "0xD64768")]
	public GUIControllerNavigationController()
	{
	}

	// Token: 0x04000629 RID: 1577
	[Token(Token = "0x4000629")]
	[FieldOffset(Offset = "0x8")]
	private Cursor EmulatedCursor;

	// Token: 0x0400062A RID: 1578
	[Token(Token = "0x400062A")]
	[FieldOffset(Offset = "0xC")]
	public float NavigationRepeatDelay;

	// Token: 0x0400062B RID: 1579
	[Token(Token = "0x400062B")]
	[FieldOffset(Offset = "0x10")]
	public float NavigationDelay;

	// Token: 0x0400062C RID: 1580
	[Token(Token = "0x400062C")]
	[FieldOffset(Offset = "0x14")]
	public float NavigationDelayToUse;

	// Token: 0x0400062D RID: 1581
	[Token(Token = "0x400062D")]
	[FieldOffset(Offset = "0x18")]
	public bool InitialNavigationMovement;

	// Token: 0x0400062E RID: 1582
	[Token(Token = "0x400062E")]
	[FieldOffset(Offset = "0x19")]
	public bool previousInteractionDownState;

	// Token: 0x0400062F RID: 1583
	[Token(Token = "0x400062F")]
	[FieldOffset(Offset = "0x1C")]
	private Point lastPoint;

	// Token: 0x04000630 RID: 1584
	[Token(Token = "0x4000630")]
	[FieldOffset(Offset = "0x24")]
	public bool DisableNavigation;

	// Token: 0x04000631 RID: 1585
	[Token(Token = "0x4000631")]
	[FieldOffset(Offset = "0x28")]
	public int DisableNavigationAxis;

	// Token: 0x04000632 RID: 1586
	[Token(Token = "0x4000632")]
	[FieldOffset(Offset = "0x30")]
	public DateTime NavigationTick;

	// Token: 0x04000633 RID: 1587
	[Token(Token = "0x4000633")]
	[FieldOffset(Offset = "0x38")]
	public ControllerActionVector UINavigationAxis;

	// Token: 0x04000634 RID: 1588
	[Token(Token = "0x4000634")]
	[FieldOffset(Offset = "0x3C")]
	public ControllerActionVector UIScrollAxis;

	// Token: 0x04000635 RID: 1589
	[Token(Token = "0x4000635")]
	[FieldOffset(Offset = "0x40")]
	public ControllerActionButton[] UIAction;

	// Token: 0x04000636 RID: 1590
	[Token(Token = "0x4000636")]
	[FieldOffset(Offset = "0x44")]
	public ControllerActionButton NextPage;

	// Token: 0x04000637 RID: 1591
	[Token(Token = "0x4000637")]
	[FieldOffset(Offset = "0x48")]
	public ControllerActionButton PreviousPage;

	// Token: 0x04000638 RID: 1592
	[Token(Token = "0x4000638")]
	[FieldOffset(Offset = "0x4C")]
	public ControllerActionButton PlayFile;

	// Token: 0x04000639 RID: 1593
	[Token(Token = "0x4000639")]
	[FieldOffset(Offset = "0x50")]
	public ControllerActionButton DeleteFile;

	// Token: 0x0400063A RID: 1594
	[Token(Token = "0x400063A")]
	[FieldOffset(Offset = "0x54")]
	public ControllerActionButton CloudFile;

	// Token: 0x0400063B RID: 1595
	[Token(Token = "0x400063B")]
	[FieldOffset(Offset = "0x58")]
	public ControllerActionButton FavouriteFile;

	// Token: 0x0400063C RID: 1596
	[Token(Token = "0x400063C")]
	[FieldOffset(Offset = "0x5C")]
	public ControllerActionButton NewFile;

	// Token: 0x0400063D RID: 1597
	[Token(Token = "0x400063D")]
	[FieldOffset(Offset = "0x60")]
	public ControllerActionButton CloseFileMenu;

	// Token: 0x0400063E RID: 1598
	[Token(Token = "0x400063E")]
	[FieldOffset(Offset = "0x64")]
	public ControllerActionButton Settings;

	// Token: 0x0400063F RID: 1599
	[Token(Token = "0x400063F")]
	[FieldOffset(Offset = "0x68")]
	public ControllerActionButton Share;

	// Token: 0x04000640 RID: 1600
	[Token(Token = "0x4000640")]
	[FieldOffset(Offset = "0x6C")]
	public ControllerActionButton CycleLeftPage;

	// Token: 0x04000641 RID: 1601
	[Token(Token = "0x4000641")]
	[FieldOffset(Offset = "0x70")]
	public ControllerActionButton CycleRightPage;

	// Token: 0x04000642 RID: 1602
	[Token(Token = "0x4000642")]
	[FieldOffset(Offset = "0x74")]
	public ControllerActionButton Debug;

	// Token: 0x04000643 RID: 1603
	[Token(Token = "0x4000643")]
	[FieldOffset(Offset = "0x78")]
	public ControllerActionButton DebugToggleUI;

	// Token: 0x04000644 RID: 1604
	[Token(Token = "0x4000644")]
	[FieldOffset(Offset = "0x7C")]
	public bool[] UIActionWasPressed;

	// Token: 0x04000645 RID: 1605
	[Token(Token = "0x4000645")]
	[FieldOffset(Offset = "0x80")]
	public bool[] UIActionPressed;

	// Token: 0x04000646 RID: 1606
	[Token(Token = "0x4000646")]
	[FieldOffset(Offset = "0x84")]
	private GUIControllerItem _currentNavigationItem;

	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	public enum InteractionMode
	{

	}
}
