using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

// Token: 0x02000023 RID: 35
[Token(Token = "0x2000023")]
public class CursorManager
{
	// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009D")]
	[Address(RVA = "0x49A514", Offset = "0x49A514", VA = "0x49A514")]
	public static CursorManager Create()
	{
		return null;
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x49A588", Offset = "0x49A588", VA = "0x49A588")]
	public CursorManager()
	{
	}

	// Token: 0x0600009F RID: 159 RVA: 0x000024F0 File Offset: 0x000006F0
	[Token(Token = "0x600009F")]
	[Address(RVA = "0x49A7FC", Offset = "0x49A7FC", VA = "0x49A7FC")]
	public bool IsCursorActive()
	{
		return default(bool);
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00002508 File Offset: 0x00000708
	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x49A9F4", Offset = "0x49A9F4", VA = "0x49A9F4")]
	public int GetNumCursors()
	{
		return 0;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x49AA4C", Offset = "0x49AA4C", VA = "0x49AA4C")]
	public global::Cursor GetCursor(int index)
	{
		return null;
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x49AAB8", Offset = "0x49AAB8", VA = "0x49AAB8")]
	public void UpdateCursors()
	{
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002520 File Offset: 0x00000720
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x49A854", Offset = "0x49A854", VA = "0x49A854")]
	private bool IsMouseActive(int index)
	{
		return default(bool);
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00002538 File Offset: 0x00000738
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x49BDA4", Offset = "0x49BDA4", VA = "0x49BDA4")]
	private bool IsTouchScrollOnly(int touchIndex)
	{
		return default(bool);
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00002550 File Offset: 0x00000750
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x49BFF8", Offset = "0x49BFF8", VA = "0x49BFF8")]
	public int GetRealTouchCount()
	{
		return 0;
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00002568 File Offset: 0x00000768
	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x49C050", Offset = "0x49C050", VA = "0x49C050")]
	public int GetTouchCount()
	{
		return 0;
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00002580 File Offset: 0x00000780
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x49BF54", Offset = "0x49BF54", VA = "0x49BF54")]
	private int GetTouchId(int touchIndex)
	{
		return 0;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00002598 File Offset: 0x00000798
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x49C190", Offset = "0x49C190", VA = "0x49C190")]
	private int GetTouchIndex(int touchId)
	{
		return 0;
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060000A9 RID: 169 RVA: 0x000025B0 File Offset: 0x000007B0
	[Token(Token = "0x17000034")]
	public bool EmuMouseModeActive
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x49C2DC", Offset = "0x49C2DC", VA = "0x49C2DC")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060000AA RID: 170 RVA: 0x000025C8 File Offset: 0x000007C8
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x49C2F8", Offset = "0x49C2F8", VA = "0x49C2F8")]
	public bool GetEMUMouseButton(int index)
	{
		return default(bool);
	}

	// Token: 0x060000AB RID: 171 RVA: 0x000025E0 File Offset: 0x000007E0
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x49C364", Offset = "0x49C364", VA = "0x49C364")]
	public bool GetEMUMouseButtonDown(int index)
	{
		return default(bool);
	}

	// Token: 0x060000AC RID: 172 RVA: 0x000025F8 File Offset: 0x000007F8
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x49C3F8", Offset = "0x49C3F8", VA = "0x49C3F8")]
	public bool GetEMUMouseButtonUp(int index)
	{
		return default(bool);
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002610 File Offset: 0x00000810
	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x49C480", Offset = "0x49C480", VA = "0x49C480")]
	private TouchPhase GetTouchPhase(int touchIndex)
	{
		return TouchPhase.Began;
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00002628 File Offset: 0x00000828
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x49C80C", Offset = "0x49C80C", VA = "0x49C80C")]
	private bool ShouldIgnoreTouch(int touchIndex)
	{
		return default(bool);
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00002640 File Offset: 0x00000840
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x49C870", Offset = "0x49C870", VA = "0x49C870")]
	private Vector2 GetTouchPosition(int touchIndex)
	{
		return default(Vector2);
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002658 File Offset: 0x00000858
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x49CA08", Offset = "0x49CA08", VA = "0x49CA08")]
	private Vector2 GetTouchScroll(int touchIndex)
	{
		return default(Vector2);
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00002670 File Offset: 0x00000870
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x49CA98", Offset = "0x49CA98", VA = "0x49CA98")]
	private bool ShouldIgnoreForWorld(Vector2 position)
	{
		return default(bool);
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x49CC44", Offset = "0x49CC44", VA = "0x49CC44")]
	private void UpdateMouseEMUTouches()
	{
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x49B0A0", Offset = "0x49B0A0", VA = "0x49B0A0")]
	private void UpdateCursorList()
	{
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x49D03C", Offset = "0x49D03C", VA = "0x49D03C")]
	public void DrawCursorOverlay(SpriteBatch batch)
	{
	}

	// Token: 0x040002C7 RID: 711
	[Token(Token = "0x40002C7")]
	[FieldOffset(Offset = "0x0")]
	public static CursorManager Instance;

	// Token: 0x040002C8 RID: 712
	[Token(Token = "0x40002C8")]
	[FieldOffset(Offset = "0x8")]
	private int _touchCount;

	// Token: 0x040002C9 RID: 713
	[Token(Token = "0x40002C9")]
	[FieldOffset(Offset = "0xC")]
	public bool ActivateMouseMode;

	// Token: 0x040002CA RID: 714
	[Token(Token = "0x40002CA")]
	[FieldOffset(Offset = "0xD")]
	private bool emuTouchFromMouse;

	// Token: 0x040002CB RID: 715
	[Token(Token = "0x40002CB")]
	[FieldOffset(Offset = "0xE")]
	private bool fakeMouseActive;

	// Token: 0x040002CC RID: 716
	[Token(Token = "0x40002CC")]
	[FieldOffset(Offset = "0xF")]
	private bool mouseActive;

	// Token: 0x040002CD RID: 717
	[Token(Token = "0x40002CD")]
	[FieldOffset(Offset = "0x10")]
	private Vector2 fakeMousePosition;

	// Token: 0x040002CE RID: 718
	[Token(Token = "0x40002CE")]
	[FieldOffset(Offset = "0x18")]
	private bool updatingSwitchTouches;

	// Token: 0x040002CF RID: 719
	[Token(Token = "0x40002CF")]
	[FieldOffset(Offset = "0x1C")]
	private List<CursorManager.TouchInput> UserSwitchTouches;

	// Token: 0x040002D0 RID: 720
	[Token(Token = "0x40002D0")]
	[FieldOffset(Offset = "0x20")]
	private bool emuMouseModeActive;

	// Token: 0x040002D1 RID: 721
	[Token(Token = "0x40002D1")]
	[FieldOffset(Offset = "0x21")]
	private bool updatingEMUMouseTouches;

	// Token: 0x040002D2 RID: 722
	[Token(Token = "0x40002D2")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 emuMouseLastHWMousePosition;

	// Token: 0x040002D3 RID: 723
	[Token(Token = "0x40002D3")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 EmuMousePosition;

	// Token: 0x040002D4 RID: 724
	[Token(Token = "0x40002D4")]
	[FieldOffset(Offset = "0x38")]
	private List<CursorManager.TouchInput> EMUMouseTouches;

	// Token: 0x040002D5 RID: 725
	[Token(Token = "0x40002D5")]
	[FieldOffset(Offset = "0x3C")]
	private List<CursorManager.TouchInput> PreviousEMUMouseTouches;

	// Token: 0x040002D6 RID: 726
	[Token(Token = "0x40002D6")]
	[FieldOffset(Offset = "0x40")]
	private List<global::Cursor> _cursors;

	// Token: 0x040002D7 RID: 727
	[Token(Token = "0x40002D7")]
	[FieldOffset(Offset = "0x44")]
	private List<CursorManager.CursorFirstContact> _cursorsInpacts;

	// Token: 0x040002D8 RID: 728
	[Token(Token = "0x40002D8")]
	[FieldOffset(Offset = "0x48")]
	public List<CursorInputLayer> Layers;

	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	public struct TouchInput
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x49D030", Offset = "0x49D030", VA = "0x49D030")]
		public TouchInput(int id, Vector2 position, TouchPhase phase)
		{
		}

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x0")]
		public readonly int TouchId;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x4")]
		public readonly Vector2 TouchPosition;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0xC")]
		public readonly TouchPhase TouchPhase;
	}

	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	private struct CursorFirstContact
	{
		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 position;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x8")]
		public DateTime time;
	}
}
