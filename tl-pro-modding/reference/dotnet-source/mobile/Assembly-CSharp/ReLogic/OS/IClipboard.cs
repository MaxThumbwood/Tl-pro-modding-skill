using System;
using Il2CppDummyDll;

namespace ReLogic.OS
{
	// Token: 0x02000DE8 RID: 3560
	[Token(Token = "0x2000DE8")]
	public interface IClipboard
	{
		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x0600688D RID: 26765
		// (set) Token: 0x0600688E RID: 26766
		[Token(Token = "0x17000B24")]
		string Value
		{
			[Token(Token = "0x600688D")]
			get;
			[Token(Token = "0x600688E")]
			set;
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x0600688F RID: 26767
		[Token(Token = "0x17000B25")]
		string MultiLineValue
		{
			[Token(Token = "0x600688F")]
			get;
		}
	}
}
