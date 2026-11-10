using System;
using System.Xml;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E59 RID: 3673
	[Token(Token = "0x2000E59")]
	internal abstract class ResponseMessageBase
	{
		// Token: 0x06006ABE RID: 27326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ABE")]
		[Address(RVA = "0xB9FD90", Offset = "0xB9FD90", VA = "0xB9FD90")]
		protected ResponseMessageBase(XmlDocument response, string serviceType, string typeName)
		{
		}

		// Token: 0x06006ABF RID: 27327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ABF")]
		[Address(RVA = "0xB9FDBC", Offset = "0xB9FDBC", VA = "0xB9FDBC")]
		protected XmlNode GetNode()
		{
			return null;
		}

		// Token: 0x0400A82F RID: 43055
		[Token(Token = "0x400A82F")]
		[FieldOffset(Offset = "0x8")]
		private readonly XmlDocument _document;

		// Token: 0x0400A830 RID: 43056
		[Token(Token = "0x400A830")]
		[FieldOffset(Offset = "0xC")]
		protected string ServiceType;

		// Token: 0x0400A831 RID: 43057
		[Token(Token = "0x400A831")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _typeName;
	}
}
