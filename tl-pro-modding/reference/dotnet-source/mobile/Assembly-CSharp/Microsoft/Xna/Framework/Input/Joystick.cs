using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x020003B8 RID: 952
	[Token(Token = "0x20003B8")]
	public static class Joystick
	{
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		[Token(Token = "0x170002A4")]
		public static bool IsSupported
		{
			[Token(Token = "0x600195D")]
			[Address(RVA = "0xE26854", Offset = "0xE26854", VA = "0xE26854")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		[Token(Token = "0x600195E")]
		[Address(RVA = "0xE2685C", Offset = "0xE2685C", VA = "0xE2685C")]
		public static JoystickCapabilities GetCapabilities(int index)
		{
			return default(JoystickCapabilities);
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x0000C300 File Offset: 0x0000A500
		[Token(Token = "0x600195F")]
		[Address(RVA = "0xE26894", Offset = "0xE26894", VA = "0xE26894")]
		public static JoystickState GetState(int index)
		{
			return default(JoystickState);
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x0000C318 File Offset: 0x0000A518
		[Token(Token = "0x6001960")]
		[Address(RVA = "0xE26878", Offset = "0xE26878", VA = "0xE26878")]
		private static JoystickCapabilities PlatformGetCapabilities(int index)
		{
			return default(JoystickCapabilities);
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x0000C330 File Offset: 0x0000A530
		[Token(Token = "0x6001961")]
		[Address(RVA = "0xE26950", Offset = "0xE26950", VA = "0xE26950")]
		private static JoystickState PlatformGetState(int index)
		{
			return default(JoystickState);
		}

		// Token: 0x04002BC2 RID: 11202
		[Token(Token = "0x4002BC2")]
		private const bool PlatformIsSupported = false;
	}
}
