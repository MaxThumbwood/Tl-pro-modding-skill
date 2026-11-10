using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x020003B7 RID: 951
	[Token(Token = "0x20003B7")]
	internal class GamepadTranslator
	{
		// Token: 0x06001957 RID: 6487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001957")]
		[Address(RVA = "0xE261C4", Offset = "0xE261C4", VA = "0xE261C4")]
		public GamepadTranslator(string config)
		{
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001958")]
		[Address(RVA = "0xE26414", Offset = "0xE26414", VA = "0xE26414")]
		public ButtonType Read(string button)
		{
			return null;
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x0000C270 File Offset: 0x0000A470
		[Token(Token = "0x6001959")]
		[Address(RVA = "0xE26528", Offset = "0xE26528", VA = "0xE26528")]
		public bool ButtonPressed(string button, JoystickState state)
		{
			return default(bool);
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x0000C288 File Offset: 0x0000A488
		[Token(Token = "0x600195A")]
		[Address(RVA = "0xE265C0", Offset = "0xE265C0", VA = "0xE265C0")]
		public float AxisPressed(string axis, JoystickState state)
		{
			return 0f;
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		[Token(Token = "0x600195B")]
		[Address(RVA = "0xE26618", Offset = "0xE26618", VA = "0xE26618")]
		public bool DpadPressed(string dpad, JoystickState state)
		{
			return default(bool);
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
		[Token(Token = "0x600195C")]
		[Address(RVA = "0xE26754", Offset = "0xE26754", VA = "0xE26754")]
		public float TriggerPressed(string trigger, JoystickState state)
		{
			return 0f;
		}

		// Token: 0x04002BC1 RID: 11201
		[Token(Token = "0x4002BC1")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, ButtonType> Data;
	}
}
