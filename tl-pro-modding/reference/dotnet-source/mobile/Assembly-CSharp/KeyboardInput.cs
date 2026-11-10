using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000058 RID: 88
[Token(Token = "0x2000058")]
internal static class KeyboardInput
{
	// Token: 0x060001DA RID: 474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x4AA228", Offset = "0x4AA228", VA = "0x4AA228")]
	public static void KeyboardUpdate()
	{
	}

	// Token: 0x060001DB RID: 475 RVA: 0x00002B38 File Offset: 0x00000D38
	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x4AA22C", Offset = "0x4AA22C", VA = "0x4AA22C")]
	public static bool KeyPressed(int keyCode)
	{
		return default(bool);
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x4AA234", Offset = "0x4AA234", VA = "0x4AA234")]
	public static void Update()
	{
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00002B50 File Offset: 0x00000D50
	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x4AAD2C", Offset = "0x4AAD2C", VA = "0x4AAD2C")]
	public static bool GetKey(KeyCode keycode)
	{
		return default(bool);
	}

	// Token: 0x060001DE RID: 478 RVA: 0x00002B68 File Offset: 0x00000D68
	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x49DD64", Offset = "0x49DD64", VA = "0x49DD64")]
	public static bool GetKeyUp(KeyCode keycode)
	{
		return default(bool);
	}

	// Token: 0x060001DF RID: 479 RVA: 0x00002B80 File Offset: 0x00000D80
	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x49DE34", Offset = "0x49DE34", VA = "0x49DE34")]
	public static bool GetKeyDown(KeyCode keycode)
	{
		return default(bool);
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x4AADFC", Offset = "0x4AADFC", VA = "0x4AADFC")]
	public static void KeyboardInitialise()
	{
	}

	// Token: 0x040003AC RID: 940
	[Token(Token = "0x40003AC")]
	[FieldOffset(Offset = "0x0")]
	private static KeyboardInput.KeyCodeMapping[] keyMappings;

	// Token: 0x040003AD RID: 941
	[Token(Token = "0x40003AD")]
	[FieldOffset(Offset = "0x4")]
	private static bool[] KeyStates;

	// Token: 0x040003AE RID: 942
	[Token(Token = "0x40003AE")]
	[FieldOffset(Offset = "0x8")]
	private static bool[] KeyStatesOld;

	// Token: 0x040003AF RID: 943
	[Token(Token = "0x40003AF")]
	[FieldOffset(Offset = "0xC")]
	private static AndroidJavaObject pressedStateArray;

	// Token: 0x040003B0 RID: 944
	[Token(Token = "0x40003B0")]
	[FieldOffset(Offset = "0x10")]
	private static IntPtr pressedStateArracyValues;

	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	public enum VirtualKey
	{
		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		None,
		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		LeftButton,
		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		RightButton,
		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40003B5")]
		Cancel,
		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		MiddleButton,
		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		XButton1,
		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		XButton2,
		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x40003B9")]
		Back = 8,
		// Token: 0x040003BA RID: 954
		[Token(Token = "0x40003BA")]
		Tab,
		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		Clear = 12,
		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		Enter,
		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40003BD")]
		Shift = 16,
		// Token: 0x040003BE RID: 958
		[Token(Token = "0x40003BE")]
		Control,
		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		Menu,
		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		Pause,
		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		CapitalLock,
		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		Kana,
		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		Hangul = 21,
		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		Junja = 23,
		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		Final,
		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		Hanja,
		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		Kanji = 25,
		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		Escape = 27,
		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		Convert,
		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		NonConvert,
		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		Accept,
		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		ModeChange,
		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		Space,
		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		PageUp,
		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		PageDown,
		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		End,
		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		Home,
		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		Left,
		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		Up,
		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		Right,
		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		Down,
		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		Select,
		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		Print,
		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		Execute,
		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		Snapshot,
		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		Insert,
		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		Delete,
		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		Help,
		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		Number0,
		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		Number1,
		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		Number2,
		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		Number3,
		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		Number4,
		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		Number5,
		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		Number6,
		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		Number7,
		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		Number8,
		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		Number9,
		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		A = 65,
		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		B,
		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		C,
		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		D,
		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		E,
		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		F,
		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		G,
		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		H,
		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		I,
		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		J,
		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		K,
		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		L,
		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		M,
		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		N,
		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		O,
		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x40003F6")]
		P,
		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		Q,
		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		R,
		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		S,
		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		T,
		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		U,
		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		V,
		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		W,
		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		X,
		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		Y,
		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		Z,
		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		LeftWindows,
		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		RightWindows,
		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		Application,
		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		Sleep = 95,
		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		NumberPad0,
		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		NumberPad1,
		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		NumberPad2,
		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		NumberPad3,
		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		NumberPad4,
		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		NumberPad5,
		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		NumberPad6,
		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		NumberPad7,
		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		NumberPad8,
		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		NumberPad9,
		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		Multiply,
		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		Add,
		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		Separator,
		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		Subtract,
		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		Decimal,
		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		Divide,
		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		F1,
		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		F2,
		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		F3,
		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		F4,
		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		F5,
		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		F6,
		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		F7,
		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		F8,
		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		F9,
		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		F10,
		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		F11,
		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		F12,
		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		F13,
		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		F14,
		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		F15,
		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		F16,
		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		F17,
		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		F18,
		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		F19,
		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		F20,
		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		F21,
		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		F22,
		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		F23,
		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		F24,
		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		NumberKeyLock = 144,
		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		Scroll,
		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		LeftShift = 160,
		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		RightShift,
		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		LeftControl,
		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		RightControl,
		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		LeftMenu,
		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		RightMenu,
		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		Semicolon = 186,
		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		Equals,
		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		Comma,
		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		Minus,
		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		Period,
		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		Slash,
		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		BackQuote,
		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		LeftBracket = 219,
		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		RightBracket = 221,
		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		Quote,
		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		Backslash = 226
	}

	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	public struct KeyCodeMapping
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x4AC448", Offset = "0x4AC448", VA = "0x4AC448")]
		public KeyCodeMapping(KeyboardInput.VirtualKey vKey, KeyCode code)
		{
		}

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x0")]
		public KeyCode keyCode;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x4")]
		public KeyboardInput.VirtualKey virtualKey;
	}
}
