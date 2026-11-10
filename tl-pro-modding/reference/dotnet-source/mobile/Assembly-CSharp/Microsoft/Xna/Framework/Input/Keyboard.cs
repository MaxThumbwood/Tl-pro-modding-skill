using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x020003BC RID: 956
	[Token(Token = "0x20003BC")]
	public static class Keyboard
	{
		// Token: 0x0600198D RID: 6541 RVA: 0x0000C558 File Offset: 0x0000A758
		[Token(Token = "0x600198D")]
		[Address(RVA = "0xE27C70", Offset = "0xE27C70", VA = "0xE27C70")]
		public static KeyboardState GetState()
		{
			return default(KeyboardState);
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x0000C570 File Offset: 0x0000A770
		[Token(Token = "0x600198E")]
		[Address(RVA = "0xE282A8", Offset = "0xE282A8", VA = "0xE282A8")]
		public static KeyboardState GetState(PlayerIndex playerIndex)
		{
			return default(KeyboardState);
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x0000C588 File Offset: 0x0000A788
		[Token(Token = "0x600198F")]
		[Address(RVA = "0xE27D04", Offset = "0xE27D04", VA = "0xE27D04")]
		private static KeyboardState PlatformGetState()
		{
			return default(KeyboardState);
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001990")]
		[Address(RVA = "0xE285F4", Offset = "0xE285F4", VA = "0xE285F4")]
		internal static void SetKeys(List<Keys> keys)
		{
		}

		// Token: 0x04002BD1 RID: 11217
		[Token(Token = "0x4002BD1")]
		[FieldOffset(Offset = "0x0")]
		public static KeyCode[] keyCodes;

		// Token: 0x04002BD2 RID: 11218
		[Token(Token = "0x4002BD2")]
		[FieldOffset(Offset = "0x4")]
		public static Keys[] keys;

		// Token: 0x04002BD3 RID: 11219
		[Token(Token = "0x4002BD3")]
		[FieldOffset(Offset = "0x8")]
		public static bool keyboardActive;

		// Token: 0x04002BD4 RID: 11220
		[Token(Token = "0x4002BD4")]
		[FieldOffset(Offset = "0xC")]
		private static List<Keys> _keys;

		// Token: 0x04002BD5 RID: 11221
		[Token(Token = "0x4002BD5")]
		[FieldOffset(Offset = "0x10")]
		public static List<KeyCode> UnityKeys;

		// Token: 0x04002BD6 RID: 11222
		[Token(Token = "0x4002BD6")]
		[FieldOffset(Offset = "0x14")]
		public static List<KeyCode> LastUnityKeys;

		// Token: 0x04002BD7 RID: 11223
		[Token(Token = "0x4002BD7")]
		[FieldOffset(Offset = "0x18")]
		public static bool IgnoreEnterUntilClear;
	}
}
