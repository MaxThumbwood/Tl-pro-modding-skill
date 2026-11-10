using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Controller;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000145 RID: 325
[Token(Token = "0x2000145")]
public class GUIControlsBanner
{
	// Token: 0x0600089C RID: 2204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089C")]
	[Address(RVA = "0x4E0BAC", Offset = "0x4E0BAC", VA = "0x4E0BAC")]
	public GUIControlsBanner(bool ignoreRequiredStates = false)
	{
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x00005898 File Offset: 0x00003A98
	[Token(Token = "0x600089D")]
	[Address(RVA = "0x4E0CA4", Offset = "0x4E0CA4", VA = "0x4E0CA4")]
	private float ItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089E")]
	[Address(RVA = "0x4E0CAC", Offset = "0x4E0CAC", VA = "0x4E0CAC")]
	private void ItemOver(int index)
	{
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x000058B0 File Offset: 0x00003AB0
	[Token(Token = "0x600089F")]
	[Address(RVA = "0x4E0CB0", Offset = "0x4E0CB0", VA = "0x4E0CB0")]
	public static GUIControllerInputButton.LinkedControlType FromButton(Buttons button)
	{
		return GUIControllerInputButton.LinkedControlType.Action1;
	}

	// Token: 0x060008A0 RID: 2208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008A0")]
	[Address(RVA = "0x4E0CCC", Offset = "0x4E0CCC", VA = "0x4E0CCC")]
	public string GetControlTag(ControllerActionVector action)
	{
		return null;
	}

	// Token: 0x060008A1 RID: 2209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008A1")]
	[Address(RVA = "0x4DEF18", Offset = "0x4DEF18", VA = "0x4DEF18")]
	public string GetControlTag(ControllerActionButton action)
	{
		return null;
	}

	// Token: 0x060008A2 RID: 2210 RVA: 0x000058C8 File Offset: 0x00003AC8
	[Token(Token = "0x60008A2")]
	[Address(RVA = "0x4E0F5C", Offset = "0x4E0F5C", VA = "0x4E0F5C")]
	public static GUIControllerInputButton.AxisControl FromAxis(Axis axis, float threshold)
	{
		return GUIControllerInputButton.AxisControl.DPad;
	}

	// Token: 0x060008A3 RID: 2211 RVA: 0x000058E0 File Offset: 0x00003AE0
	[Token(Token = "0x60008A3")]
	[Address(RVA = "0x4E1074", Offset = "0x4E1074", VA = "0x4E1074")]
	private bool AddAction(GUIControlsBanner.Action action, int maxWidth)
	{
		return default(bool);
	}

	// Token: 0x060008A4 RID: 2212 RVA: 0x000058F8 File Offset: 0x00003AF8
	[Token(Token = "0x60008A4")]
	[Address(RVA = "0x4E165C", Offset = "0x4E165C", VA = "0x4E165C")]
	private bool AddMore(int maxWidth)
	{
		return default(bool);
	}

	// Token: 0x060008A5 RID: 2213 RVA: 0x00005910 File Offset: 0x00003B10
	[Token(Token = "0x60008A5")]
	[Address(RVA = "0x4E1BEC", Offset = "0x4E1BEC", VA = "0x4E1BEC")]
	public int SortActionByDisplayPriority(GUIControlsBanner.Action x, GUIControlsBanner.Action y)
	{
		return 0;
	}

	// Token: 0x060008A6 RID: 2214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A6")]
	[Address(RVA = "0x4E1D18", Offset = "0x4E1D18", VA = "0x4E1D18")]
	public static void DrawPageToolBanner(ControllerActionButton mapping)
	{
	}

	// Token: 0x060008A7 RID: 2215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A7")]
	[Address(RVA = "0x4E2184", Offset = "0x4E2184", VA = "0x4E2184")]
	public static void DrawPageToolBanner(ControllerActionVector mapping)
	{
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A8")]
	[Address(RVA = "0x4E25F0", Offset = "0x4E25F0", VA = "0x4E25F0")]
	public void DrawHorizontalControlsBanner(int widthModifier)
	{
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A9")]
	[Address(RVA = "0x4E3000", Offset = "0x4E3000", VA = "0x4E3000")]
	public void Draw([Optional] ControlsBanner_Layout layout, int widthModifier = 0)
	{
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008AA")]
	[Address(RVA = "0x4E32CC", Offset = "0x4E32CC", VA = "0x4E32CC")]
	public void Clear()
	{
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008AB")]
	[Address(RVA = "0x4E33F0", Offset = "0x4E33F0", VA = "0x4E33F0")]
	public void AddAction(ControllerActionVector action, string label, bool disabled = false)
	{
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x4D4F60", Offset = "0x4D4F60", VA = "0x4D4F60")]
	public void AddOverloadAction(ControllerActionButton action, string label, bool disabled = false)
	{
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008AD")]
	[Address(RVA = "0x4D2044", Offset = "0x4D2044", VA = "0x4D2044")]
	public void AddAction(ControllerActionButton action, string label, bool disabled = false, bool hideMapping = false)
	{
	}

	// Token: 0x04000980 RID: 2432
	[Token(Token = "0x4000980")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private Vector2 itemSize;

	// Token: 0x04000981 RID: 2433
	[Token(Token = "0x4000981")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<GUIControlsBanner.Action> currentActions;

	// Token: 0x04000982 RID: 2434
	[Token(Token = "0x4000982")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private List<GUIControlsBanner.Action> AvailableActions;

	// Token: 0x04000983 RID: 2435
	[Token(Token = "0x4000983")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<GUIControlsBanner.Action> AllActions;

	// Token: 0x04000984 RID: 2436
	[Token(Token = "0x4000984")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private List<GUIControlsBanner.Action> OverrideActions;

	// Token: 0x04000985 RID: 2437
	[Token(Token = "0x4000985")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool MoreLeftActions;

	// Token: 0x04000986 RID: 2438
	[Token(Token = "0x4000986")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool MoreRightActions;

	// Token: 0x04000987 RID: 2439
	[Token(Token = "0x4000987")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	private readonly bool IgnoreRequiredStates;

	// Token: 0x04000988 RID: 2440
	[Token(Token = "0x4000988")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool ShowBanner;

	// Token: 0x04000989 RID: 2441
	[Token(Token = "0x4000989")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int DisplayingLines;

	// Token: 0x0400098A RID: 2442
	[Token(Token = "0x400098A")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool secondLine;

	// Token: 0x0400098B RID: 2443
	[Token(Token = "0x400098B")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Rectangle lastDrawRegion;

	// Token: 0x0400098C RID: 2444
	[Token(Token = "0x400098C")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Rectangle lastDrawRegion2;

	// Token: 0x0400098D RID: 2445
	[Token(Token = "0x400098D")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private TransactionButton_Layout ActionStyle;

	// Token: 0x0400098E RID: 2446
	[Token(Token = "0x400098E")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private TransactionButton_Layout ActionStyleMultiple;

	// Token: 0x0400098F RID: 2447
	[Token(Token = "0x400098F")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool OnlyDisplayStateActions;

	// Token: 0x04000990 RID: 2448
	[Token(Token = "0x4000990")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float ActionTagLengthOffset;

	// Token: 0x04000991 RID: 2449
	[Token(Token = "0x4000991")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool StatusBanner;

	// Token: 0x04000992 RID: 2450
	[Token(Token = "0x4000992")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public GUIControlsBanner RedirectedBanner;

	// Token: 0x04000993 RID: 2451
	[Token(Token = "0x4000993")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float leftMoreScale;

	// Token: 0x04000994 RID: 2452
	[Token(Token = "0x4000994")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float rightMoreScale;

	// Token: 0x02000146 RID: 326
	[Token(Token = "0x2000146")]
	public class Action
	{
		// Token: 0x060008AE RID: 2222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x4E3940", Offset = "0x4E3940", VA = "0x4E3940")]
		public void Set(ControllerActionVector action, string name, bool disabled, int displayPriorityOffset)
		{
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x4E3A58", Offset = "0x4E3A58", VA = "0x4E3A58")]
		public void Set(ControllerActionButton action, string name, bool disabled, int displayPriorityOffset, bool hideMapping = false)
		{
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x4E3938", Offset = "0x4E3938", VA = "0x4E3938")]
		public Action()
		{
		}

		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4000995")]
		public const GUIControlsBanner.Action.ControlPriority MinRightControl = GUIControlsBanner.Action.ControlPriority.RightTrigger;

		// Token: 0x04000996 RID: 2454
		[Token(Token = "0x4000996")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ControllerActionVector Axis;

		// Token: 0x04000997 RID: 2455
		[Token(Token = "0x4000997")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ControllerActionButton Button;

		// Token: 0x04000998 RID: 2456
		[Token(Token = "0x4000998")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4000999")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int InputPriority;

		// Token: 0x0400099A RID: 2458
		[Token(Token = "0x400099A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Disabled;

		// Token: 0x0400099B RID: 2459
		[Token(Token = "0x400099B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int DisplayPriorityOffset;

		// Token: 0x0400099C RID: 2460
		[Token(Token = "0x400099C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool HideMapping;

		// Token: 0x02000147 RID: 327
		[Token(Token = "0x2000147")]
		public enum ControlPriority
		{
			// Token: 0x0400099E RID: 2462
			[Token(Token = "0x400099E")]
			LeftTrigger,
			// Token: 0x0400099F RID: 2463
			[Token(Token = "0x400099F")]
			LeftShoulder,
			// Token: 0x040009A0 RID: 2464
			[Token(Token = "0x40009A0")]
			DPadDown,
			// Token: 0x040009A1 RID: 2465
			[Token(Token = "0x40009A1")]
			DPadUp,
			// Token: 0x040009A2 RID: 2466
			[Token(Token = "0x40009A2")]
			DPadLeft,
			// Token: 0x040009A3 RID: 2467
			[Token(Token = "0x40009A3")]
			DPadRight,
			// Token: 0x040009A4 RID: 2468
			[Token(Token = "0x40009A4")]
			LSDown,
			// Token: 0x040009A5 RID: 2469
			[Token(Token = "0x40009A5")]
			LSUp,
			// Token: 0x040009A6 RID: 2470
			[Token(Token = "0x40009A6")]
			LSLeft,
			// Token: 0x040009A7 RID: 2471
			[Token(Token = "0x40009A7")]
			LSRight,
			// Token: 0x040009A8 RID: 2472
			[Token(Token = "0x40009A8")]
			LSClick,
			// Token: 0x040009A9 RID: 2473
			[Token(Token = "0x40009A9")]
			ViewButton,
			// Token: 0x040009AA RID: 2474
			[Token(Token = "0x40009AA")]
			LeftMore,
			// Token: 0x040009AB RID: 2475
			[Token(Token = "0x40009AB")]
			RightTrigger,
			// Token: 0x040009AC RID: 2476
			[Token(Token = "0x40009AC")]
			RightShoulder,
			// Token: 0x040009AD RID: 2477
			[Token(Token = "0x40009AD")]
			Action2,
			// Token: 0x040009AE RID: 2478
			[Token(Token = "0x40009AE")]
			Action4,
			// Token: 0x040009AF RID: 2479
			[Token(Token = "0x40009AF")]
			Action3,
			// Token: 0x040009B0 RID: 2480
			[Token(Token = "0x40009B0")]
			Action1,
			// Token: 0x040009B1 RID: 2481
			[Token(Token = "0x40009B1")]
			RSDown,
			// Token: 0x040009B2 RID: 2482
			[Token(Token = "0x40009B2")]
			RSUp,
			// Token: 0x040009B3 RID: 2483
			[Token(Token = "0x40009B3")]
			RSLeft,
			// Token: 0x040009B4 RID: 2484
			[Token(Token = "0x40009B4")]
			RSRight,
			// Token: 0x040009B5 RID: 2485
			[Token(Token = "0x40009B5")]
			RSClick,
			// Token: 0x040009B6 RID: 2486
			[Token(Token = "0x40009B6")]
			Settings,
			// Token: 0x040009B7 RID: 2487
			[Token(Token = "0x40009B7")]
			RightMore
		}
	}
}
