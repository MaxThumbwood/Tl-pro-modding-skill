using System;
using Controller;
using Il2CppDummyDll;
using Terraria.GameContent.Liquid;
using Terraria.Graphics.Effects;
using UnityEngine;

// Token: 0x02000313 RID: 787
[Token(Token = "0x2000313")]
public class LocalUser
{
	// Token: 0x06001388 RID: 5000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001388")]
	[Address(RVA = "0xDA2444", Offset = "0xDA2444", VA = "0xDA2444")]
	public LocalUser(int userIndex, PlatformUser user)
	{
	}

	// Token: 0x06001389 RID: 5001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001389")]
	[Address(RVA = "0xDA4E60", Offset = "0xDA4E60", VA = "0xDA4E60")]
	public void SetupState()
	{
	}

	// Token: 0x0600138A RID: 5002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138A")]
	[Address(RVA = "0xDA5AC4", Offset = "0xDA5AC4", VA = "0xDA5AC4")]
	public void LoadThreadstate()
	{
	}

	// Token: 0x0600138B RID: 5003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138B")]
	[Address(RVA = "0xDA5688", Offset = "0xDA5688", VA = "0xDA5688")]
	public void LoadState()
	{
	}

	// Token: 0x0600138C RID: 5004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138C")]
	[Address(RVA = "0xDA5B58", Offset = "0xDA5B58", VA = "0xDA5B58")]
	public static void UnloadState()
	{
	}

	// Token: 0x0600138D RID: 5005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138D")]
	[Address(RVA = "0xDA5BD0", Offset = "0xDA5BD0", VA = "0xDA5BD0")]
	public void LoadPersistantData()
	{
	}

	// Token: 0x0600138E RID: 5006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138E")]
	[Address(RVA = "0xDA693C", Offset = "0xDA693C", VA = "0xDA693C")]
	public void SavePersistantData()
	{
	}

	// Token: 0x170001D3 RID: 467
	// (get) Token: 0x06001390 RID: 5008 RVA: 0x00008D60 File Offset: 0x00006F60
	// (set) Token: 0x0600138F RID: 5007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001D3")]
	public Rect ViewportRegion
	{
		[Token(Token = "0x6001390")]
		[Address(RVA = "0xDA72D8", Offset = "0xDA72D8", VA = "0xDA72D8")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x600138F")]
		[Address(RVA = "0xDA7244", Offset = "0xDA7244", VA = "0xDA7244")]
		set
		{
		}
	}

	// Token: 0x06001391 RID: 5009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001391")]
	[Address(RVA = "0xDA7328", Offset = "0xDA7328", VA = "0xDA7328")]
	private static Camera GetCamera(string name)
	{
		return null;
	}

	// Token: 0x06001392 RID: 5010 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001392")]
	[Address(RVA = "0xDA4A9C", Offset = "0xDA4A9C", VA = "0xDA4A9C")]
	public static Camera GetWorldCamera(int index)
	{
		return null;
	}

	// Token: 0x06001393 RID: 5011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001393")]
	[Address(RVA = "0xDA46D8", Offset = "0xDA46D8", VA = "0xDA46D8")]
	public static Camera GetUICamera(int index)
	{
		return null;
	}

	// Token: 0x04002595 RID: 9621
	[Token(Token = "0x4002595")]
	[FieldOffset(Offset = "0x0")]
	public static LocalUser Active;

	// Token: 0x04002596 RID: 9622
	[Token(Token = "0x4002596")]
	[FieldOffset(Offset = "0x8")]
	public SkyManager SkyManager;

	// Token: 0x04002597 RID: 9623
	[Token(Token = "0x4002597")]
	[FieldOffset(Offset = "0xC")]
	public FilterManager FilterManager;

	// Token: 0x04002598 RID: 9624
	[Token(Token = "0x4002598")]
	[FieldOffset(Offset = "0x10")]
	public OverlayManager OverlayManager;

	// Token: 0x04002599 RID: 9625
	[Token(Token = "0x4002599")]
	[FieldOffset(Offset = "0x14")]
	private bool usingKeyboardMouse;

	// Token: 0x0400259A RID: 9626
	[Token(Token = "0x400259A")]
	[FieldOffset(Offset = "0x18")]
	public ControllerDevice ActiveController;

	// Token: 0x0400259B RID: 9627
	[Token(Token = "0x400259B")]
	[FieldOffset(Offset = "0x1C")]
	public GUIInstance GUIInstance;

	// Token: 0x0400259C RID: 9628
	[Token(Token = "0x400259C")]
	[FieldOffset(Offset = "0x20")]
	public CursorManager cursorManager;

	// Token: 0x0400259D RID: 9629
	[Token(Token = "0x400259D")]
	[FieldOffset(Offset = "0x24")]
	public ControllerActionManager controllerActionManager;

	// Token: 0x0400259E RID: 9630
	[Token(Token = "0x400259E")]
	[FieldOffset(Offset = "0x28")]
	public GUIInputRegionManager guiInputRegionManager;

	// Token: 0x0400259F RID: 9631
	[Token(Token = "0x400259F")]
	[FieldOffset(Offset = "0x2C")]
	public MPSessionManager mpSessionManager;

	// Token: 0x040025A0 RID: 9632
	[Token(Token = "0x40025A0")]
	[FieldOffset(Offset = "0x30")]
	public XNAUIInputLayer xnaUIInputLayer;

	// Token: 0x040025A1 RID: 9633
	[Token(Token = "0x40025A1")]
	[FieldOffset(Offset = "0x34")]
	public FileManager fileManager;

	// Token: 0x040025A2 RID: 9634
	[Token(Token = "0x40025A2")]
	[FieldOffset(Offset = "0x38")]
	public LiquidRenderer liquidRenderer;

	// Token: 0x040025A3 RID: 9635
	[Token(Token = "0x40025A3")]
	[FieldOffset(Offset = "0x3C")]
	public int UserIndex;

	// Token: 0x040025A4 RID: 9636
	[Token(Token = "0x40025A4")]
	[FieldOffset(Offset = "0x40")]
	public PlatformUser UserId;

	// Token: 0x040025A5 RID: 9637
	[Token(Token = "0x40025A5")]
	[FieldOffset(Offset = "0x48")]
	public IPlatformAwardNotifier PlatformAwards;

	// Token: 0x040025A6 RID: 9638
	[Token(Token = "0x40025A6")]
	[FieldOffset(Offset = "0x4C")]
	public PersistentUserData PersistentUserData;

	// Token: 0x040025A7 RID: 9639
	[Token(Token = "0x40025A7")]
	[FieldOffset(Offset = "0x50")]
	public XNAUICameraSettings UICameraSettings;

	// Token: 0x040025A8 RID: 9640
	[Token(Token = "0x40025A8")]
	[FieldOffset(Offset = "0x54")]
	public XNAWorldCameraSettings WorldCameraSettings;

	// Token: 0x040025A9 RID: 9641
	[Token(Token = "0x40025A9")]
	[FieldOffset(Offset = "0x58")]
	public LocalUserGameState GameState;

	// Token: 0x040025AA RID: 9642
	[Token(Token = "0x40025AA")]
	[FieldOffset(Offset = "0x5C")]
	public LocalUserXNAState XNAState;

	// Token: 0x040025AB RID: 9643
	[Token(Token = "0x40025AB")]
	[FieldOffset(Offset = "0x60")]
	public InterfaceProfile_Layout[] CustomProfiles;

	// Token: 0x040025AC RID: 9644
	[Token(Token = "0x40025AC")]
	[FieldOffset(Offset = "0x4")]
	private static Camera _worldCam2;

	// Token: 0x040025AD RID: 9645
	[Token(Token = "0x40025AD")]
	[FieldOffset(Offset = "0x8")]
	private static Camera _worldCam3;

	// Token: 0x040025AE RID: 9646
	[Token(Token = "0x40025AE")]
	[FieldOffset(Offset = "0xC")]
	private static Camera _worldCam4;

	// Token: 0x040025AF RID: 9647
	[Token(Token = "0x40025AF")]
	[FieldOffset(Offset = "0x10")]
	private static Camera _uiCam2;

	// Token: 0x040025B0 RID: 9648
	[Token(Token = "0x40025B0")]
	[FieldOffset(Offset = "0x14")]
	private static Camera _uiCam3;

	// Token: 0x040025B1 RID: 9649
	[Token(Token = "0x40025B1")]
	[FieldOffset(Offset = "0x18")]
	private static Camera _uiCam4;
}
