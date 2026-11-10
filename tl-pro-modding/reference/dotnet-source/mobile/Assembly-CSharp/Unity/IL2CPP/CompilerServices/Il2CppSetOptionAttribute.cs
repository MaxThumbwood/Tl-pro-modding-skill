using System;
using Il2CppDummyDll;

namespace Unity.IL2CPP.CompilerServices
{
	// Token: 0x02000E71 RID: 3697
	[Token(Token = "0x2000E71")]
	public class Il2CppSetOptionAttribute : Attribute
	{
		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06006B1B RID: 27419 RVA: 0x000302D0 File Offset: 0x0002E4D0
		// (set) Token: 0x06006B1C RID: 27420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B89")]
		public Option Option
		{
			[Token(Token = "0x6006B1B")]
			[Address(RVA = "0xBABAC4", Offset = "0xBABAC4", VA = "0xBABAC4")]
			get
			{
				return (Option)0;
			}
			[Token(Token = "0x6006B1C")]
			[Address(RVA = "0xBABACC", Offset = "0xBABACC", VA = "0xBABACC")]
			private set
			{
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06006B1D RID: 27421 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006B1E RID: 27422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B8A")]
		public object Value
		{
			[Token(Token = "0x6006B1D")]
			[Address(RVA = "0xBABAD4", Offset = "0xBABAD4", VA = "0xBABAD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006B1E")]
			[Address(RVA = "0xBABADC", Offset = "0xBABADC", VA = "0xBABADC")]
			private set
			{
			}
		}

		// Token: 0x06006B1F RID: 27423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1F")]
		[Address(RVA = "0xBABAE4", Offset = "0xBABAE4", VA = "0xBABAE4")]
		public Il2CppSetOptionAttribute(Option option, object value)
		{
		}

		// Token: 0x0400A898 RID: 43160
		[Token(Token = "0x400A898")]
		[FieldOffset(Offset = "0x8")]
		private Option <Option>k__BackingField;

		// Token: 0x0400A899 RID: 43161
		[Token(Token = "0x400A899")]
		[FieldOffset(Offset = "0xC")]
		private object <Value>k__BackingField;
	}
}
