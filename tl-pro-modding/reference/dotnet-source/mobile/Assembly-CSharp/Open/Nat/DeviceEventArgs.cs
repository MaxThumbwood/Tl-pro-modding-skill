using System;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E32 RID: 3634
	[Token(Token = "0x2000E32")]
	internal class DeviceEventArgs : EventArgs
	{
		// Token: 0x06006A0F RID: 27151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A0F")]
		[Address(RVA = "0xB93DAC", Offset = "0xB93DAC", VA = "0xB93DAC")]
		public DeviceEventArgs(NatDevice device)
		{
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06006A10 RID: 27152 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006A11 RID: 27153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B68")]
		public NatDevice Device
		{
			[Token(Token = "0x6006A10")]
			[Address(RVA = "0xB9460C", Offset = "0xB9460C", VA = "0xB9460C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A11")]
			[Address(RVA = "0xB94614", Offset = "0xB94614", VA = "0xB94614")]
			private set
			{
			}
		}

		// Token: 0x0400A79F RID: 42911
		[Token(Token = "0x400A79F")]
		[FieldOffset(Offset = "0x8")]
		private NatDevice <Device>k__BackingField;
	}
}
