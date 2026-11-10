using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200038C RID: 908
	[Token(Token = "0x200038C")]
	public enum BatteryChargeStatus
	{
		// Token: 0x04002AC0 RID: 10944
		[Token(Token = "0x4002AC0")]
		Charging = 8,
		// Token: 0x04002AC1 RID: 10945
		[Token(Token = "0x4002AC1")]
		Critical = 4,
		// Token: 0x04002AC2 RID: 10946
		[Token(Token = "0x4002AC2")]
		High = 1,
		// Token: 0x04002AC3 RID: 10947
		[Token(Token = "0x4002AC3")]
		Low,
		// Token: 0x04002AC4 RID: 10948
		[Token(Token = "0x4002AC4")]
		NoSystemBattery = 128,
		// Token: 0x04002AC5 RID: 10949
		[Token(Token = "0x4002AC5")]
		Unknown = 255
	}
}
