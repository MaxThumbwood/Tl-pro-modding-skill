using System;
using Controller;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000116 RID: 278
[Token(Token = "0x2000116")]
public static class GUIControllerInputButton
{
	// Token: 0x06000732 RID: 1842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000732")]
	[Address(RVA = "0x12920D8", Offset = "0x12920D8", VA = "0x12920D8")]
	public static void LoadContent(ContentManager content)
	{
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000733")]
	[Address(RVA = "0x12922C0", Offset = "0x12922C0", VA = "0x12922C0")]
	public static Texture2D GetShoulderButtonTexureInformation(GUIControllerInputButton.ShoulderButtonControl controlType, out Rectangle srcRegion, int overloadedControlType = -1)
	{
		return null;
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000734")]
	[Address(RVA = "0x12923DC", Offset = "0x12923DC", VA = "0x12923DC")]
	public static Texture2D GetAxisTexureInformation(GUIControllerInputButton.AxisControl controlType, out Rectangle srcRegion, int overloadedControlType = -1)
	{
		return null;
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000735")]
	[Address(RVA = "0x1292598", Offset = "0x1292598", VA = "0x1292598")]
	public static Texture2D GetButtonTexureInformation(GUIControllerInputButton.LinkedControlType controlType, out Rectangle srcRegion, int overloadedControlType = -1)
	{
		return null;
	}

	// Token: 0x040007DD RID: 2013
	[Token(Token = "0x40007DD")]
	private const ControllerDevice.ControlScheme defaultScheme = ControllerDevice.ControlScheme.CONTROLS_ABXY_XBOX;

	// Token: 0x040007DE RID: 2014
	[Token(Token = "0x40007DE")]
	[FieldOffset(Offset = "0x0")]
	private static Texture2D ButtonControls;

	// Token: 0x040007DF RID: 2015
	[Token(Token = "0x40007DF")]
	[FieldOffset(Offset = "0x4")]
	private static Texture2D ShoulderButtonControls;

	// Token: 0x040007E0 RID: 2016
	[Token(Token = "0x40007E0")]
	[FieldOffset(Offset = "0x8")]
	private static Texture2D AxisControls;

	// Token: 0x040007E1 RID: 2017
	[Token(Token = "0x40007E1")]
	[FieldOffset(Offset = "0xC")]
	private static Texture2D PS4TouchPad;

	// Token: 0x02000117 RID: 279
	[Token(Token = "0x2000117")]
	public enum LinkedControlType
	{
		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		Action1,
		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x40007E4")]
		Action2,
		// Token: 0x040007E5 RID: 2021
		[Token(Token = "0x40007E5")]
		Action3,
		// Token: 0x040007E6 RID: 2022
		[Token(Token = "0x40007E6")]
		Action4,
		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x40007E7")]
		LB,
		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x40007E8")]
		RB,
		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x40007E9")]
		LT,
		// Token: 0x040007EA RID: 2026
		[Token(Token = "0x40007EA")]
		RT,
		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x40007EB")]
		View,
		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x40007EC")]
		Options,
		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x40007ED")]
		LeftStick,
		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		RightStick
	}

	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000118")]
	public enum ShoulderButtonControl
	{
		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x40007F0")]
		LB,
		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x40007F1")]
		RB,
		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		LT,
		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		RT,
		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x40007F4")]
		View,
		// Token: 0x040007F5 RID: 2037
		[Token(Token = "0x40007F5")]
		Options
	}

	// Token: 0x02000119 RID: 281
	[Token(Token = "0x2000119")]
	public enum AxisControl
	{
		// Token: 0x040007F7 RID: 2039
		[Token(Token = "0x40007F7")]
		DPad,
		// Token: 0x040007F8 RID: 2040
		[Token(Token = "0x40007F8")]
		DPadLeft,
		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		DPadRight,
		// Token: 0x040007FA RID: 2042
		[Token(Token = "0x40007FA")]
		DPadUp,
		// Token: 0x040007FB RID: 2043
		[Token(Token = "0x40007FB")]
		DPadDown,
		// Token: 0x040007FC RID: 2044
		[Token(Token = "0x40007FC")]
		DPadDummy,
		// Token: 0x040007FD RID: 2045
		[Token(Token = "0x40007FD")]
		LS,
		// Token: 0x040007FE RID: 2046
		[Token(Token = "0x40007FE")]
		LSLeft,
		// Token: 0x040007FF RID: 2047
		[Token(Token = "0x40007FF")]
		LSRight,
		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000800")]
		LSUp,
		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4000801")]
		LSDown,
		// Token: 0x04000802 RID: 2050
		[Token(Token = "0x4000802")]
		LSClick,
		// Token: 0x04000803 RID: 2051
		[Token(Token = "0x4000803")]
		RS,
		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x4000804")]
		RSLeft,
		// Token: 0x04000805 RID: 2053
		[Token(Token = "0x4000805")]
		RSRight,
		// Token: 0x04000806 RID: 2054
		[Token(Token = "0x4000806")]
		RSUp,
		// Token: 0x04000807 RID: 2055
		[Token(Token = "0x4000807")]
		RSDown,
		// Token: 0x04000808 RID: 2056
		[Token(Token = "0x4000808")]
		RSClick
	}
}
