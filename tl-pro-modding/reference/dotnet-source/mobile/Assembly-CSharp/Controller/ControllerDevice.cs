using System;
using Il2CppDummyDll;
using InControl;

namespace Controller
{
	// Token: 0x02000E2A RID: 3626
	[Token(Token = "0x2000E2A")]
	public class ControllerDevice
	{
		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x060069E1 RID: 27105 RVA: 0x0002FE38 File Offset: 0x0002E038
		// (set) Token: 0x060069E2 RID: 27106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B67")]
		public static bool SwapBumpersTriggers
		{
			[Token(Token = "0x60069E1")]
			[Address(RVA = "0xB9203C", Offset = "0xB9203C", VA = "0xB9203C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60069E2")]
			[Address(RVA = "0xB920A4", Offset = "0xB920A4", VA = "0xB920A4")]
			set
			{
			}
		}

		// Token: 0x060069E3 RID: 27107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069E3")]
		[Address(RVA = "0xB90B14", Offset = "0xB90B14", VA = "0xB90B14")]
		public ControllerDevice(InputDevice device)
		{
		}

		// Token: 0x060069E4 RID: 27108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069E4")]
		[Address(RVA = "0xB92110", Offset = "0xB92110", VA = "0xB92110")]
		public ControllerDevice(InputDevice leftDevice, InputDevice rightDevice)
		{
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069E5")]
		[Address(RVA = "0xB92258", Offset = "0xB92258", VA = "0xB92258")]
		public ControllerDevice()
		{
		}

		// Token: 0x060069E6 RID: 27110 RVA: 0x0002FE50 File Offset: 0x0002E050
		[Token(Token = "0x60069E6")]
		[Address(RVA = "0xB8AD98", Offset = "0xB8AD98", VA = "0xB8AD98")]
		public bool HasAxis(Axis axis)
		{
			return default(bool);
		}

		// Token: 0x060069E7 RID: 27111 RVA: 0x0002FE68 File Offset: 0x0002E068
		[Token(Token = "0x60069E7")]
		[Address(RVA = "0xB8AE8C", Offset = "0xB8AE8C", VA = "0xB8AE8C")]
		public bool HasButton(Buttons button)
		{
			return default(bool);
		}

		// Token: 0x060069E8 RID: 27112 RVA: 0x0002FE80 File Offset: 0x0002E080
		[Token(Token = "0x60069E8")]
		[Address(RVA = "0xB8ADA0", Offset = "0xB8ADA0", VA = "0xB8ADA0")]
		public float GetAxis(Axis axis)
		{
			return 0f;
		}

		// Token: 0x060069E9 RID: 27113 RVA: 0x0002FE98 File Offset: 0x0002E098
		[Token(Token = "0x60069E9")]
		[Address(RVA = "0xB898B4", Offset = "0xB898B4", VA = "0xB898B4")]
		public float GetAxisTime(Axis axis)
		{
			return 0f;
		}

		// Token: 0x060069EA RID: 27114 RVA: 0x0002FEB0 File Offset: 0x0002E0B0
		[Token(Token = "0x60069EA")]
		[Address(RVA = "0xB8AE68", Offset = "0xB8AE68", VA = "0xB8AE68")]
		public float GetAxisScaled(Axis axis)
		{
			return 0f;
		}

		// Token: 0x060069EB RID: 27115 RVA: 0x0002FEC8 File Offset: 0x0002E0C8
		[Token(Token = "0x60069EB")]
		[Address(RVA = "0xB8ADC4", Offset = "0xB8ADC4", VA = "0xB8ADC4")]
		public float GetPreviousAxis(Axis axis)
		{
			return 0f;
		}

		// Token: 0x060069EC RID: 27116 RVA: 0x0002FEE0 File Offset: 0x0002E0E0
		[Token(Token = "0x60069EC")]
		[Address(RVA = "0xB923A8", Offset = "0xB923A8", VA = "0xB923A8")]
		public float GetPreviousAxisScaled(Axis axis)
		{
			return 0f;
		}

		// Token: 0x060069ED RID: 27117 RVA: 0x0002FEF8 File Offset: 0x0002E0F8
		[Token(Token = "0x60069ED")]
		[Address(RVA = "0xB8BAA4", Offset = "0xB8BAA4", VA = "0xB8BAA4")]
		public float ButtonTime(Buttons key)
		{
			return 0f;
		}

		// Token: 0x060069EE RID: 27118 RVA: 0x0002FF10 File Offset: 0x0002E110
		[Token(Token = "0x60069EE")]
		[Address(RVA = "0xB8E4B8", Offset = "0xB8E4B8", VA = "0xB8E4B8")]
		public float ButtonReleaseTime(Buttons key)
		{
			return 0f;
		}

		// Token: 0x060069EF RID: 27119 RVA: 0x0002FF28 File Offset: 0x0002E128
		[Token(Token = "0x60069EF")]
		[Address(RVA = "0xB8E2E8", Offset = "0xB8E2E8", VA = "0xB8E2E8")]
		public bool ButtonConsumed(Buttons key)
		{
			return default(bool);
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069F0")]
		[Address(RVA = "0xB8E4DC", Offset = "0xB8E4DC", VA = "0xB8E4DC")]
		public void SetButtonConsumed(Buttons key)
		{
		}

		// Token: 0x060069F1 RID: 27121 RVA: 0x0002FF40 File Offset: 0x0002E140
		[Token(Token = "0x60069F1")]
		[Address(RVA = "0xB8AE94", Offset = "0xB8AE94", VA = "0xB8AE94")]
		public bool ButtonState(Buttons key)
		{
			return default(bool);
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x0002FF58 File Offset: 0x0002E158
		[Token(Token = "0x60069F2")]
		[Address(RVA = "0xB8C744", Offset = "0xB8C744", VA = "0xB8C744")]
		public bool PreviousButtonState(Buttons key)
		{
			return default(bool);
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x0002FF70 File Offset: 0x0002E170
		[Token(Token = "0x60069F3")]
		[Address(RVA = "0xB8E2C4", Offset = "0xB8E2C4", VA = "0xB8E2C4")]
		public bool ButtonUp(Buttons key)
		{
			return default(bool);
		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x0002FF88 File Offset: 0x0002E188
		[Token(Token = "0x60069F4")]
		[Address(RVA = "0xB8D1CC", Offset = "0xB8D1CC", VA = "0xB8D1CC")]
		public bool ButtonDown(Buttons key)
		{
			return default(bool);
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069F5")]
		[Address(RVA = "0xB923CC", Offset = "0xB923CC", VA = "0xB923CC")]
		public void SetFakedButton(Buttons key)
		{
		}

		// Token: 0x060069F6 RID: 27126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069F6")]
		[Address(RVA = "0xB923F4", Offset = "0xB923F4", VA = "0xB923F4")]
		public void SetFakedAxis(Axis axis, float value)
		{
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069F7")]
		[Address(RVA = "0xB912B8", Offset = "0xB912B8", VA = "0xB912B8")]
		public void ResetState()
		{
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x0002FFA0 File Offset: 0x0002E1A0
		[Token(Token = "0x60069F8")]
		[Address(RVA = "0xB91724", Offset = "0xB91724", VA = "0xB91724")]
		public bool Update(float elapsedTime)
		{
			return default(bool);
		}

		// Token: 0x060069F9 RID: 27129 RVA: 0x0002FFB8 File Offset: 0x0002E1B8
		[Token(Token = "0x60069F9")]
		[Address(RVA = "0xB92424", Offset = "0xB92424", VA = "0xB92424")]
		private float GetAxisRaw(Axis axis)
		{
			return 0f;
		}

		// Token: 0x060069FA RID: 27130 RVA: 0x0002FFD0 File Offset: 0x0002E1D0
		[Token(Token = "0x60069FA")]
		[Address(RVA = "0xB92568", Offset = "0xB92568", VA = "0xB92568")]
		private float GetAxisRaw2(Axis axis)
		{
			return 0f;
		}

		// Token: 0x060069FB RID: 27131 RVA: 0x0002FFE8 File Offset: 0x0002E1E8
		[Token(Token = "0x60069FB")]
		[Address(RVA = "0xB92774", Offset = "0xB92774", VA = "0xB92774")]
		private bool GetKeyRaw(Buttons key)
		{
			return default(bool);
		}

		// Token: 0x060069FC RID: 27132 RVA: 0x00030000 File Offset: 0x0002E200
		[Token(Token = "0x60069FC")]
		[Address(RVA = "0xB92CA0", Offset = "0xB92CA0", VA = "0xB92CA0")]
		private bool GetKeyRaw2(Buttons key)
		{
			return default(bool);
		}

		// Token: 0x0400A775 RID: 42869
		[Token(Token = "0x400A775")]
		[FieldOffset(Offset = "0x8")]
		public ControllerDevice.ControlScheme Controls;

		// Token: 0x0400A776 RID: 42870
		[Token(Token = "0x400A776")]
		[FieldOffset(Offset = "0xC")]
		public InputDevice Device;

		// Token: 0x0400A777 RID: 42871
		[Token(Token = "0x400A777")]
		[FieldOffset(Offset = "0x10")]
		public InputDevice Device2;

		// Token: 0x0400A778 RID: 42872
		[Token(Token = "0x400A778")]
		[FieldOffset(Offset = "0x14")]
		private readonly float[] AxisValue;

		// Token: 0x0400A779 RID: 42873
		[Token(Token = "0x400A779")]
		[FieldOffset(Offset = "0x18")]
		private readonly float[] AxisValueScaled;

		// Token: 0x0400A77A RID: 42874
		[Token(Token = "0x400A77A")]
		[FieldOffset(Offset = "0x1C")]
		private readonly float[] PreviousAxisValue;

		// Token: 0x0400A77B RID: 42875
		[Token(Token = "0x400A77B")]
		[FieldOffset(Offset = "0x20")]
		private readonly float[] PreviousAxisValueScaled;

		// Token: 0x0400A77C RID: 42876
		[Token(Token = "0x400A77C")]
		[FieldOffset(Offset = "0x24")]
		private readonly float[] _AxisTime;

		// Token: 0x0400A77D RID: 42877
		[Token(Token = "0x400A77D")]
		[FieldOffset(Offset = "0x28")]
		private readonly float[] _KeyReleaseTime;

		// Token: 0x0400A77E RID: 42878
		[Token(Token = "0x400A77E")]
		[FieldOffset(Offset = "0x2C")]
		private readonly float[] _KeyTime;

		// Token: 0x0400A77F RID: 42879
		[Token(Token = "0x400A77F")]
		[FieldOffset(Offset = "0x30")]
		private readonly bool[] _KeyState;

		// Token: 0x0400A780 RID: 42880
		[Token(Token = "0x400A780")]
		[FieldOffset(Offset = "0x34")]
		private readonly bool[] _KeyConsumed;

		// Token: 0x0400A781 RID: 42881
		[Token(Token = "0x400A781")]
		[FieldOffset(Offset = "0x38")]
		private readonly bool[] _PreviousKeyState;

		// Token: 0x0400A782 RID: 42882
		[Token(Token = "0x400A782")]
		[FieldOffset(Offset = "0x3C")]
		private readonly bool[] _KeyStateUp;

		// Token: 0x0400A783 RID: 42883
		[Token(Token = "0x400A783")]
		[FieldOffset(Offset = "0x40")]
		private readonly bool[] _KeyStateDown;

		// Token: 0x0400A784 RID: 42884
		[Token(Token = "0x400A784")]
		[FieldOffset(Offset = "0x44")]
		private readonly float[] _fakedAxisValues;

		// Token: 0x0400A785 RID: 42885
		[Token(Token = "0x400A785")]
		[FieldOffset(Offset = "0x48")]
		private readonly bool[] _fakedDeviceButtons;

		// Token: 0x02000E2B RID: 3627
		[Token(Token = "0x2000E2B")]
		public enum ControlScheme
		{
			// Token: 0x0400A787 RID: 42887
			[Token(Token = "0x400A787")]
			CONTROLS_1234,
			// Token: 0x0400A788 RID: 42888
			[Token(Token = "0x400A788")]
			CONTROLS_ABXY_GREY,
			// Token: 0x0400A789 RID: 42889
			[Token(Token = "0x400A789")]
			CONTROLS_ABXY_XBOX,
			// Token: 0x0400A78A RID: 42890
			[Token(Token = "0x400A78A")]
			CONTROLS_OUYA,
			// Token: 0x0400A78B RID: 42891
			[Token(Token = "0x400A78B")]
			CONTROLS_PS4,
			// Token: 0x0400A78C RID: 42892
			[Token(Token = "0x400A78C")]
			CONTROLS_ABXY_STEELSERIES,
			// Token: 0x0400A78D RID: 42893
			[Token(Token = "0x400A78D")]
			CONTROLS_SWITCH,
			// Token: 0x0400A78E RID: 42894
			[Token(Token = "0x400A78E")]
			CONTROLS_STADIA
		}
	}
}
