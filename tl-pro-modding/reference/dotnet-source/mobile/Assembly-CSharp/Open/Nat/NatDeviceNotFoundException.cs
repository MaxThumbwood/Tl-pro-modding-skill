using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E34 RID: 3636
	[Token(Token = "0x2000E34")]
	[Serializable]
	public class NatDeviceNotFoundException : Exception
	{
		// Token: 0x06006A1C RID: 27164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A1C")]
		[Address(RVA = "0xB94A1C", Offset = "0xB94A1C", VA = "0xB94A1C")]
		public NatDeviceNotFoundException()
		{
		}

		// Token: 0x06006A1D RID: 27165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A1D")]
		[Address(RVA = "0xB94A84", Offset = "0xB94A84", VA = "0xB94A84")]
		public NatDeviceNotFoundException(string message)
		{
		}

		// Token: 0x06006A1E RID: 27166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A1E")]
		[Address(RVA = "0xB94AF4", Offset = "0xB94AF4", VA = "0xB94AF4")]
		public NatDeviceNotFoundException(string message, Exception innerException)
		{
		}

		// Token: 0x06006A1F RID: 27167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A1F")]
		[Address(RVA = "0xB94B6C", Offset = "0xB94B6C", VA = "0xB94B6C")]
		protected NatDeviceNotFoundException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
