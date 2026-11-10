using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using UnityEngine;

// Token: 0x02000373 RID: 883
[Token(Token = "0x2000373")]
public class XNAUnityRunner : MonoBehaviour
{
	// Token: 0x170001FE RID: 510
	// (get) Token: 0x060015BD RID: 5565 RVA: 0x000098E8 File Offset: 0x00007AE8
	[Token(Token = "0x170001FE")]
	public bool DisableCrossplayFeature
	{
		[Token(Token = "0x60015BD")]
		[Address(RVA = "0xDFFF88", Offset = "0xDFFF88", VA = "0xDFFF88")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001FF RID: 511
	// (get) Token: 0x060015BE RID: 5566 RVA: 0x00009900 File Offset: 0x00007B00
	[Token(Token = "0x170001FF")]
	public static XNAUnityRunner.ForcedInputMode CurrentInputMode
	{
		[Token(Token = "0x60015BE")]
		[Address(RVA = "0xDFFFA4", Offset = "0xDFFFA4", VA = "0xDFFFA4")]
		get
		{
			return XNAUnityRunner.ForcedInputMode.None;
		}
	}

	// Token: 0x17000200 RID: 512
	// (get) Token: 0x060015BF RID: 5567 RVA: 0x00009918 File Offset: 0x00007B18
	[Token(Token = "0x17000200")]
	public static XNAUnityRunner.ForcedInputMode PrimaryInputMode
	{
		[Token(Token = "0x60015BF")]
		[Address(RVA = "0xE00080", Offset = "0xE00080", VA = "0xE00080")]
		get
		{
			return XNAUnityRunner.ForcedInputMode.None;
		}
	}

	// Token: 0x060015C0 RID: 5568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C0")]
	[Address(RVA = "0xE00358", Offset = "0xE00358", VA = "0xE00358")]
	private static void SetupStaticClasses()
	{
	}

	// Token: 0x060015C1 RID: 5569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C1")]
	[Address(RVA = "0xE0035C", Offset = "0xE0035C", VA = "0xE0035C")]
	private void UpdateSleepMode()
	{
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C2")]
	[Address(RVA = "0xE004FC", Offset = "0xE004FC", VA = "0xE004FC")]
	private void Awake()
	{
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C3")]
	[Address(RVA = "0xE01254", Offset = "0xE01254", VA = "0xE01254")]
	private void Start()
	{
	}

	// Token: 0x060015C4 RID: 5572 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C4")]
	[Address(RVA = "0xE0142C", Offset = "0xE0142C", VA = "0xE0142C")]
	private IEnumerator PlayVideo()
	{
		return null;
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C5")]
	[Address(RVA = "0xE01388", Offset = "0xE01388", VA = "0xE01388")]
	private void StartGame()
	{
	}

	// Token: 0x060015C6 RID: 5574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C6")]
	[Address(RVA = "0xE014E4", Offset = "0xE014E4", VA = "0xE014E4")]
	private void Application_lowMemory()
	{
	}

	// Token: 0x060015C7 RID: 5575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C7")]
	[Address(RVA = "0xE01550", Offset = "0xE01550", VA = "0xE01550")]
	private void OnDisable()
	{
	}

	// Token: 0x060015C8 RID: 5576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C8")]
	[Address(RVA = "0xE015D4", Offset = "0xE015D4", VA = "0xE015D4")]
	private void OnGUI()
	{
	}

	// Token: 0x060015C9 RID: 5577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C9")]
	[Address(RVA = "0xE015D8", Offset = "0xE015D8", VA = "0xE015D8")]
	public void OnApplicationQuit()
	{
	}

	// Token: 0x060015CA RID: 5578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015CA")]
	[Address(RVA = "0xE01A08", Offset = "0xE01A08", VA = "0xE01A08")]
	private void OnApplicationFocus(bool focus)
	{
	}

	// Token: 0x060015CB RID: 5579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015CB")]
	[Address(RVA = "0xE01A18", Offset = "0xE01A18", VA = "0xE01A18")]
	private void OnApplicationPause(bool pause)
	{
	}

	// Token: 0x060015CC RID: 5580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015CC")]
	[Address(RVA = "0xE01DE8", Offset = "0xE01DE8", VA = "0xE01DE8")]
	private string GetNextScreenshotFilename()
	{
		return null;
	}

	// Token: 0x17000201 RID: 513
	// (get) Token: 0x060015CD RID: 5581 RVA: 0x00009930 File Offset: 0x00007B30
	[Token(Token = "0x17000201")]
	public static int ScreenWidth
	{
		[Token(Token = "0x60015CD")]
		[Address(RVA = "0xDFF3FC", Offset = "0xDFF3FC", VA = "0xDFF3FC")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000202 RID: 514
	// (get) Token: 0x060015CE RID: 5582 RVA: 0x00009948 File Offset: 0x00007B48
	[Token(Token = "0x17000202")]
	public static int ScreenHeight
	{
		[Token(Token = "0x60015CE")]
		[Address(RVA = "0xDFF404", Offset = "0xDFF404", VA = "0xDFF404")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060015CF RID: 5583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015CF")]
	[Address(RVA = "0xE0200C", Offset = "0xE0200C", VA = "0xE0200C")]
	private void Update()
	{
	}

	// Token: 0x17000203 RID: 515
	// (get) Token: 0x060015D0 RID: 5584 RVA: 0x00009960 File Offset: 0x00007B60
	[Token(Token = "0x17000203")]
	public static global::UnityEngine.Vector3 MousePosition
	{
		[Token(Token = "0x60015D0")]
		[Address(RVA = "0xE03850", Offset = "0xE03850", VA = "0xE03850")]
		get
		{
			return default(global::UnityEngine.Vector3);
		}
	}

	// Token: 0x17000204 RID: 516
	// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00009978 File Offset: 0x00007B78
	[Token(Token = "0x17000204")]
	public static global::UnityEngine.Vector3 MousePositionReal
	{
		[Token(Token = "0x60015D1")]
		[Address(RVA = "0xE039A8", Offset = "0xE039A8", VA = "0xE039A8")]
		get
		{
			return default(global::UnityEngine.Vector3);
		}
	}

	// Token: 0x060015D2 RID: 5586 RVA: 0x00009990 File Offset: 0x00007B90
	[Token(Token = "0x60015D2")]
	[Address(RVA = "0xE03A24", Offset = "0xE03A24", VA = "0xE03A24")]
	public static float GetMouseScrollDelta(bool ignoreEditor = false)
	{
		return 0f;
	}

	// Token: 0x060015D3 RID: 5587 RVA: 0x000099A8 File Offset: 0x00007BA8
	[Token(Token = "0x60015D3")]
	[Address(RVA = "0xE03B40", Offset = "0xE03B40", VA = "0xE03B40")]
	public static bool GetMouseButton(int index, bool ignoreEditor = false)
	{
		return default(bool);
	}

	// Token: 0x060015D4 RID: 5588 RVA: 0x000099C0 File Offset: 0x00007BC0
	[Token(Token = "0x60015D4")]
	[Address(RVA = "0xE03C54", Offset = "0xE03C54", VA = "0xE03C54")]
	public static bool GetMouseButtonUp(int index, bool ignoreEditor = false)
	{
		return default(bool);
	}

	// Token: 0x060015D5 RID: 5589 RVA: 0x000099D8 File Offset: 0x00007BD8
	[Token(Token = "0x60015D5")]
	[Address(RVA = "0xE03DF8", Offset = "0xE03DF8", VA = "0xE03DF8")]
	public static bool GetMouseButtonDown(int index, bool ignoreEditor = false)
	{
		return default(bool);
	}

	// Token: 0x17000205 RID: 517
	// (get) Token: 0x060015D6 RID: 5590 RVA: 0x000099F0 File Offset: 0x00007BF0
	// (set) Token: 0x060015D7 RID: 5591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000205")]
	public static bool MobileKeyboardLocked
	{
		[Token(Token = "0x60015D6")]
		[Address(RVA = "0xE03FA0", Offset = "0xE03FA0", VA = "0xE03FA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60015D7")]
		[Address(RVA = "0xE04004", Offset = "0xE04004", VA = "0xE04004")]
		set
		{
		}
	}

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00009A08 File Offset: 0x00007C08
	[Token(Token = "0x17000206")]
	public static bool KeyboardModeLocked
	{
		[Token(Token = "0x60015D8")]
		[Address(RVA = "0xE04160", Offset = "0xE04160", VA = "0xE04160")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x060015D9 RID: 5593 RVA: 0x00009A20 File Offset: 0x00007C20
	// (set) Token: 0x060015DA RID: 5594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000207")]
	public static bool MobileControllerLocked
	{
		[Token(Token = "0x60015D9")]
		[Address(RVA = "0xE0422C", Offset = "0xE0422C", VA = "0xE0422C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60015DA")]
		[Address(RVA = "0xE0408C", Offset = "0xE0408C", VA = "0xE0408C")]
		set
		{
		}
	}

	// Token: 0x17000208 RID: 520
	// (get) Token: 0x060015DB RID: 5595 RVA: 0x00009A38 File Offset: 0x00007C38
	[Token(Token = "0x17000208")]
	public static bool ControllerModeLocked
	{
		[Token(Token = "0x60015DB")]
		[Address(RVA = "0xE00200", Offset = "0xE00200", VA = "0xE00200")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000209 RID: 521
	// (get) Token: 0x060015DC RID: 5596 RVA: 0x00009A50 File Offset: 0x00007C50
	// (set) Token: 0x060015DD RID: 5597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000209")]
	public static bool MobileTouchLocked
	{
		[Token(Token = "0x60015DC")]
		[Address(RVA = "0xE04290", Offset = "0xE04290", VA = "0xE04290")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60015DD")]
		[Address(RVA = "0xE042F4", Offset = "0xE042F4", VA = "0xE042F4")]
		set
		{
		}
	}

	// Token: 0x1700020A RID: 522
	// (get) Token: 0x060015DE RID: 5598 RVA: 0x00009A68 File Offset: 0x00007C68
	[Token(Token = "0x1700020A")]
	public static bool TouchInputKeyboardLocked
	{
		[Token(Token = "0x60015DE")]
		[Address(RVA = "0xE04414", Offset = "0xE04414", VA = "0xE04414")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700020B RID: 523
	// (get) Token: 0x060015DF RID: 5599 RVA: 0x00009A80 File Offset: 0x00007C80
	[Token(Token = "0x1700020B")]
	public static bool TouchModeLocked
	{
		[Token(Token = "0x60015DF")]
		[Address(RVA = "0xE044B0", Offset = "0xE044B0", VA = "0xE044B0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060015E0 RID: 5600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E0")]
	[Address(RVA = "0xE0457C", Offset = "0xE0457C", VA = "0xE0457C")]
	private void SetMobileMouseMode(int mode)
	{
	}

	// Token: 0x060015E1 RID: 5601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E1")]
	[Address(RVA = "0xE00814", Offset = "0xE00814", VA = "0xE00814")]
	public void SetAndroidSurfaceRate(float fps)
	{
	}

	// Token: 0x060015E2 RID: 5602 RVA: 0x00009A98 File Offset: 0x00007C98
	[Token(Token = "0x60015E2")]
	[Address(RVA = "0xE04958", Offset = "0xE04958", VA = "0xE04958")]
	public bool GetAndroidTouchScreen()
	{
		return default(bool);
	}

	// Token: 0x060015E3 RID: 5603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E3")]
	[Address(RVA = "0xE04D24", Offset = "0xE04D24", VA = "0xE04D24")]
	public void ApplyPendingSurfaceRate()
	{
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x00009AB0 File Offset: 0x00007CB0
	[Token(Token = "0x60015E4")]
	[Address(RVA = "0xE050F8", Offset = "0xE050F8", VA = "0xE050F8")]
	public static bool RunningBigScreen()
	{
		return default(bool);
	}

	// Token: 0x060015E5 RID: 5605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E5")]
	[Address(RVA = "0xE05100", Offset = "0xE05100", VA = "0xE05100")]
	public void EnsureCorrectUIProfile()
	{
	}

	// Token: 0x060015E6 RID: 5606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E6")]
	[Address(RVA = "0xE02094", Offset = "0xE02094", VA = "0xE02094")]
	private void ExecuteFrame(float timeDelta)
	{
	}

	// Token: 0x060015E7 RID: 5607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E7")]
	[Address(RVA = "0xE056DC", Offset = "0xE056DC", VA = "0xE056DC")]
	private void RefreshMobileMouseCursor()
	{
	}

	// Token: 0x1700020C RID: 524
	// (get) Token: 0x060015E8 RID: 5608 RVA: 0x00009AC8 File Offset: 0x00007CC8
	[Token(Token = "0x1700020C")]
	public static bool RenderingUI
	{
		[Token(Token = "0x60015E8")]
		[Address(RVA = "0xE058D4", Offset = "0xE058D4", VA = "0xE058D4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700020D RID: 525
	// (get) Token: 0x060015E9 RID: 5609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700020D")]
	private static XNAUnityRunner.MouseStateBackup _uiMouseState
	{
		[Token(Token = "0x60015E9")]
		[Address(RVA = "0xE05938", Offset = "0xE05938", VA = "0xE05938")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700020E RID: 526
	// (get) Token: 0x060015EA RID: 5610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700020E")]
	private static XNAUnityRunner.MouseStateBackup _worldMouseState
	{
		[Token(Token = "0x60015EA")]
		[Address(RVA = "0xE059A0", Offset = "0xE059A0", VA = "0xE059A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700020F RID: 527
	// (get) Token: 0x060015EB RID: 5611 RVA: 0x00009AE0 File Offset: 0x00007CE0
	// (set) Token: 0x060015EC RID: 5612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700020F")]
	private static int _lastUIFrame
	{
		[Token(Token = "0x60015EB")]
		[Address(RVA = "0xE05A08", Offset = "0xE05A08", VA = "0xE05A08")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60015EC")]
		[Address(RVA = "0xE05A70", Offset = "0xE05A70", VA = "0xE05A70")]
		set
		{
		}
	}

	// Token: 0x060015ED RID: 5613 RVA: 0x00009AF8 File Offset: 0x00007CF8
	[Token(Token = "0x60015ED")]
	[Address(RVA = "0xE05ADC", Offset = "0xE05ADC", VA = "0xE05ADC")]
	public static Microsoft.Xna.Framework.Vector2 AdjustRealScreenForUI(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	// Token: 0x060015EE RID: 5614 RVA: 0x00009B10 File Offset: 0x00007D10
	[Token(Token = "0x60015EE")]
	[Address(RVA = "0xE05C98", Offset = "0xE05C98", VA = "0xE05C98")]
	public static Microsoft.Xna.Framework.Vector2 AdjustWorldForRealScreen(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	// Token: 0x060015EF RID: 5615 RVA: 0x00009B28 File Offset: 0x00007D28
	[Token(Token = "0x60015EF")]
	[Address(RVA = "0xE05E0C", Offset = "0xE05E0C", VA = "0xE05E0C")]
	public static Microsoft.Xna.Framework.Vector2 AdjustUIForRealScreen(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	// Token: 0x060015F0 RID: 5616 RVA: 0x00009B40 File Offset: 0x00007D40
	[Token(Token = "0x60015F0")]
	[Address(RVA = "0xE05FA4", Offset = "0xE05FA4", VA = "0xE05FA4")]
	public static Microsoft.Xna.Framework.Vector2 AdjustWorldPositionForUI(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	// Token: 0x060015F1 RID: 5617 RVA: 0x00009B58 File Offset: 0x00007D58
	[Token(Token = "0x60015F1")]
	[Address(RVA = "0xE06200", Offset = "0xE06200", VA = "0xE06200")]
	public static Microsoft.Xna.Framework.Vector2 ScaleUIDirectionForRealScreen(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	// Token: 0x060015F2 RID: 5618 RVA: 0x00009B70 File Offset: 0x00007D70
	[Token(Token = "0x60015F2")]
	[Address(RVA = "0xE0634C", Offset = "0xE0634C", VA = "0xE0634C")]
	public static Microsoft.Xna.Framework.Vector2 ScaleScreenDirectionForWorld(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x00009B88 File Offset: 0x00007D88
	[Token(Token = "0x60015F3")]
	[Address(RVA = "0xE064D8", Offset = "0xE064D8", VA = "0xE064D8")]
	public static Microsoft.Xna.Framework.Vector2 ScaleWorldDirectionForScreen(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x00009BA0 File Offset: 0x00007DA0
	[Token(Token = "0x60015F4")]
	[Address(RVA = "0xE06664", Offset = "0xE06664", VA = "0xE06664")]
	public static Microsoft.Xna.Framework.Vector2 AdjustScreenPositionForWorld(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	// Token: 0x060015F5 RID: 5621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F5")]
	[Address(RVA = "0xE068C4", Offset = "0xE068C4", VA = "0xE068C4")]
	public static void SetupRenderingUI(bool renderingUI)
	{
	}

	// Token: 0x060015F6 RID: 5622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F6")]
	[Address(RVA = "0xE074E0", Offset = "0xE074E0", VA = "0xE074E0")]
	public XNAUnityRunner()
	{
	}

	// Token: 0x04002A26 RID: 10790
	[Token(Token = "0x4002A26")]
	[FieldOffset(Offset = "0x0")]
	public static XNAUnityRunner _instance;

	// Token: 0x04002A27 RID: 10791
	[Token(Token = "0x4002A27")]
	[FieldOffset(Offset = "0xC")]
	public XNAWorldCameraSettings WorldCameraSettings;

	// Token: 0x04002A28 RID: 10792
	[Token(Token = "0x4002A28")]
	[FieldOffset(Offset = "0x10")]
	public XNAUICameraSettings UICameraSettings;

	// Token: 0x04002A29 RID: 10793
	[Token(Token = "0x4002A29")]
	[FieldOffset(Offset = "0x14")]
	public bool DisableConsoleCrossplay;

	// Token: 0x04002A2A RID: 10794
	[Token(Token = "0x4002A2A")]
	[FieldOffset(Offset = "0x15")]
	public bool IncrementalBatching;

	// Token: 0x04002A2B RID: 10795
	[Token(Token = "0x4002A2B")]
	[FieldOffset(Offset = "0x16")]
	public bool LogMaterialCreation;

	// Token: 0x04002A2C RID: 10796
	[Token(Token = "0x4002A2C")]
	[FieldOffset(Offset = "0x17")]
	public bool DisableVariableUpdate;

	// Token: 0x04002A2D RID: 10797
	[Token(Token = "0x4002A2D")]
	[FieldOffset(Offset = "0x18")]
	public Microsoft.Xna.Framework.Vector2 IncrementalBatchingOffset;

	// Token: 0x04002A2E RID: 10798
	[Token(Token = "0x4002A2E")]
	[FieldOffset(Offset = "0x20")]
	public bool EnableBatching;

	// Token: 0x04002A2F RID: 10799
	[Token(Token = "0x4002A2F")]
	[FieldOffset(Offset = "0x21")]
	public bool DumpMemory;

	// Token: 0x04002A30 RID: 10800
	[Token(Token = "0x4002A30")]
	[FieldOffset(Offset = "0x24")]
	public string ReleaseVersion;

	// Token: 0x04002A31 RID: 10801
	[Token(Token = "0x4002A31")]
	[FieldOffset(Offset = "0x28")]
	public int BuildNumber;

	// Token: 0x04002A32 RID: 10802
	[Token(Token = "0x4002A32")]
	[FieldOffset(Offset = "0x2C")]
	public bool DumpGeometryStats;

	// Token: 0x04002A33 RID: 10803
	[Token(Token = "0x4002A33")]
	[FieldOffset(Offset = "0x30")]
	public float DefaultUITabletMode;

	// Token: 0x04002A34 RID: 10804
	[Token(Token = "0x4002A34")]
	[FieldOffset(Offset = "0x34")]
	public Texture2D WaterMask;

	// Token: 0x04002A35 RID: 10805
	[Token(Token = "0x4002A35")]
	[FieldOffset(Offset = "0x38")]
	public int WorldInputEdgeRange;

	// Token: 0x04002A36 RID: 10806
	[Token(Token = "0x4002A36")]
	[FieldOffset(Offset = "0x40")]
	public long SimulatedDiskSpace;

	// Token: 0x04002A37 RID: 10807
	[Token(Token = "0x4002A37")]
	[FieldOffset(Offset = "0x48")]
	public long SimulatedDeviceMemory;

	// Token: 0x04002A38 RID: 10808
	[Token(Token = "0x4002A38")]
	[FieldOffset(Offset = "0x50")]
	public bool SimulatedCloudRequired;

	// Token: 0x04002A39 RID: 10809
	[Token(Token = "0x4002A39")]
	[FieldOffset(Offset = "0x51")]
	public bool SimulatedCloudAvailable;

	// Token: 0x04002A3A RID: 10810
	[Token(Token = "0x4002A3A")]
	[FieldOffset(Offset = "0x52")]
	public bool SimulatedCloudConnected;

	// Token: 0x04002A3B RID: 10811
	[Token(Token = "0x4002A3B")]
	[FieldOffset(Offset = "0x54")]
	public float SimulatedCloudSyncTime;

	// Token: 0x04002A3C RID: 10812
	[Token(Token = "0x4002A3C")]
	[FieldOffset(Offset = "0x58")]
	public XNAUnityRunner.ForcedInputMode ForcedInput;

	// Token: 0x04002A3D RID: 10813
	[Token(Token = "0x4002A3D")]
	[FieldOffset(Offset = "0x5C")]
	private Game _game;

	// Token: 0x04002A3E RID: 10814
	[Token(Token = "0x4002A3E")]
	[FieldOffset(Offset = "0x60")]
	public bool isStarted;

	// Token: 0x04002A3F RID: 10815
	[Token(Token = "0x4002A3F")]
	[FieldOffset(Offset = "0x61")]
	public bool HasPlayedAppleArcadeVideo;

	// Token: 0x04002A40 RID: 10816
	[Token(Token = "0x4002A40")]
	[FieldOffset(Offset = "0x4")]
	public static Dictionary<string, string> LaunchParameters;

	// Token: 0x04002A41 RID: 10817
	[Token(Token = "0x4002A41")]
	[FieldOffset(Offset = "0x62")]
	private bool allowSleepTimeout;

	// Token: 0x04002A42 RID: 10818
	[Token(Token = "0x4002A42")]
	[FieldOffset(Offset = "0x63")]
	private bool allowSystemGestures;

	// Token: 0x04002A43 RID: 10819
	[Token(Token = "0x4002A43")]
	[FieldOffset(Offset = "0x8")]
	private static bool broadcastTest;

	// Token: 0x04002A44 RID: 10820
	[Token(Token = "0x4002A44")]
	[FieldOffset(Offset = "0x9")]
	private static bool firstUpdate;

	// Token: 0x04002A45 RID: 10821
	[Token(Token = "0x4002A45")]
	[FieldOffset(Offset = "0xC")]
	private static global::UnityEngine.Vector3 LastMousePosition;

	// Token: 0x04002A46 RID: 10822
	[Token(Token = "0x4002A46")]
	[FieldOffset(Offset = "0x64")]
	private global::UnityEngine.Vector3 lastMousePosition;

	// Token: 0x04002A47 RID: 10823
	[Token(Token = "0x4002A47")]
	[FieldOffset(Offset = "0x70")]
	private bool KeyboardOpen;

	// Token: 0x04002A48 RID: 10824
	[Token(Token = "0x4002A48")]
	[FieldOffset(Offset = "0x71")]
	private bool lastFrameSplitHorizontal;

	// Token: 0x04002A49 RID: 10825
	[Token(Token = "0x4002A49")]
	[FieldOffset(Offset = "0x74")]
	private int lastSplitPlayerCount;

	// Token: 0x04002A4A RID: 10826
	[Token(Token = "0x4002A4A")]
	[FieldOffset(Offset = "0x78")]
	public bool SplitscreenOrientationChanged;

	// Token: 0x04002A4B RID: 10827
	[Token(Token = "0x4002A4B")]
	[FieldOffset(Offset = "0x79")]
	private bool switchNextFrame;

	// Token: 0x04002A4C RID: 10828
	[Token(Token = "0x4002A4C")]
	[FieldOffset(Offset = "0x18")]
	public static bool _mobileKeyboardLocked;

	// Token: 0x04002A4D RID: 10829
	[Token(Token = "0x4002A4D")]
	[FieldOffset(Offset = "0x1C")]
	public static int DelayInputSwitch;

	// Token: 0x04002A4E RID: 10830
	[Token(Token = "0x4002A4E")]
	[FieldOffset(Offset = "0x20")]
	public static bool _mobileControllerLocked;

	// Token: 0x04002A4F RID: 10831
	[Token(Token = "0x4002A4F")]
	[FieldOffset(Offset = "0x21")]
	public static bool _mobileTouchLocked;

	// Token: 0x04002A50 RID: 10832
	[Token(Token = "0x4002A50")]
	[FieldOffset(Offset = "0x7C")]
	private int mobileMouseMode;

	// Token: 0x04002A51 RID: 10833
	[Token(Token = "0x4002A51")]
	[FieldOffset(Offset = "0x80")]
	public float TargetSurfaceRate;

	// Token: 0x04002A52 RID: 10834
	[Token(Token = "0x4002A52")]
	[FieldOffset(Offset = "0x84")]
	public int InitialSurfaceRate;

	// Token: 0x04002A53 RID: 10835
	[Token(Token = "0x4002A53")]
	[FieldOffset(Offset = "0x88")]
	public bool PendingTargetSurfaceRate;

	// Token: 0x04002A54 RID: 10836
	[Token(Token = "0x4002A54")]
	[FieldOffset(Offset = "0x22")]
	private static bool _renderingUI;

	// Token: 0x04002A55 RID: 10837
	[Token(Token = "0x4002A55")]
	[FieldOffset(Offset = "0x24")]
	public static int _frame;

	// Token: 0x04002A56 RID: 10838
	[Token(Token = "0x4002A56")]
	[FieldOffset(Offset = "0x8C")]
	public AnimationCurve FireAxisRemap;

	// Token: 0x04002A57 RID: 10839
	[Token(Token = "0x4002A57")]
	[FieldOffset(Offset = "0x90")]
	public AnimationCurve RadialAnimation;

	// Token: 0x02000374 RID: 884
	[Token(Token = "0x2000374")]
	public enum ForcedInputMode
	{
		// Token: 0x04002A59 RID: 10841
		[Token(Token = "0x4002A59")]
		None,
		// Token: 0x04002A5A RID: 10842
		[Token(Token = "0x4002A5A")]
		Touch,
		// Token: 0x04002A5B RID: 10843
		[Token(Token = "0x4002A5B")]
		Controller,
		// Token: 0x04002A5C RID: 10844
		[Token(Token = "0x4002A5C")]
		KeyboardMouse
	}

	// Token: 0x02000375 RID: 885
	[Token(Token = "0x2000375")]
	public class MouseStateBackup
	{
		// Token: 0x060015F8 RID: 5624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F8")]
		[Address(RVA = "0xE071A8", Offset = "0xE071A8", VA = "0xE071A8")]
		public void Capture()
		{
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F9")]
		[Address(RVA = "0xE073B4", Offset = "0xE073B4", VA = "0xE073B4")]
		public void Restore()
		{
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FA")]
		[Address(RVA = "0xE0727C", Offset = "0xE0727C", VA = "0xE0727C")]
		public void UpdateState()
		{
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FB")]
		[Address(RVA = "0xE07724", Offset = "0xE07724", VA = "0xE07724")]
		public MouseStateBackup()
		{
		}

		// Token: 0x04002A5D RID: 10845
		[Token(Token = "0x4002A5D")]
		[FieldOffset(Offset = "0x8")]
		private int _mouseX;

		// Token: 0x04002A5E RID: 10846
		[Token(Token = "0x4002A5E")]
		[FieldOffset(Offset = "0xC")]
		private int _mouseY;

		// Token: 0x04002A5F RID: 10847
		[Token(Token = "0x4002A5F")]
		[FieldOffset(Offset = "0x10")]
		private int _lastMouseX;

		// Token: 0x04002A60 RID: 10848
		[Token(Token = "0x4002A60")]
		[FieldOffset(Offset = "0x14")]
		private int _lastMouseY;

		// Token: 0x04002A61 RID: 10849
		[Token(Token = "0x4002A61")]
		[FieldOffset(Offset = "0x18")]
		private int _worldMouseX;

		// Token: 0x04002A62 RID: 10850
		[Token(Token = "0x4002A62")]
		[FieldOffset(Offset = "0x1C")]
		private int _worldMouseY;

		// Token: 0x04002A63 RID: 10851
		[Token(Token = "0x4002A63")]
		[FieldOffset(Offset = "0x20")]
		public bool _mouseLeft;

		// Token: 0x04002A64 RID: 10852
		[Token(Token = "0x4002A64")]
		[FieldOffset(Offset = "0x21")]
		public bool _mouseRight;

		// Token: 0x04002A65 RID: 10853
		[Token(Token = "0x4002A65")]
		[FieldOffset(Offset = "0x22")]
		private bool _mouseLeftRelease;

		// Token: 0x04002A66 RID: 10854
		[Token(Token = "0x4002A66")]
		[FieldOffset(Offset = "0x23")]
		private bool _mouseRightRelease;
	}

	// Token: 0x02000376 RID: 886
	[Token(Token = "0x2000376")]
	private sealed class <PlayVideo>d__40 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x060015FC RID: 5628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FC")]
		[Address(RVA = "0xE014C8", Offset = "0xE014C8", VA = "0xE014C8")]
		public <PlayVideo>d__40(int <>1__state)
		{
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FD")]
		[Address(RVA = "0xE0772C", Offset = "0xE0772C", VA = "0xE0772C", Slot = "5")]
		private void System.IDisposable.Dispose()
		{
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00009BB8 File Offset: 0x00007DB8
		[Token(Token = "0x60015FE")]
		[Address(RVA = "0xE07730", Offset = "0xE07730", VA = "0xE07730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000210")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60015FF")]
			[Address(RVA = "0xE078B4", Offset = "0xE078B4", VA = "0xE078B4", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001600")]
		[Address(RVA = "0xE078BC", Offset = "0xE078BC", VA = "0xE078BC", Slot = "8")]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000211")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6001601")]
			[Address(RVA = "0xE07908", Offset = "0xE07908", VA = "0xE07908", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002A67 RID: 10855
		[Token(Token = "0x4002A67")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04002A68 RID: 10856
		[Token(Token = "0x4002A68")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04002A69 RID: 10857
		[Token(Token = "0x4002A69")]
		[FieldOffset(Offset = "0x10")]
		public XNAUnityRunner <>4__this;
	}
}
