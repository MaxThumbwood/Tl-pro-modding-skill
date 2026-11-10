using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x0200042F RID: 1071
	[Token(Token = "0x200042F")]
	internal class HalfTypeHelper
	{
		// Token: 0x06001DE7 RID: 7655 RVA: 0x0000E340 File Offset: 0x0000C540
		[Token(Token = "0x6001DE7")]
		[Address(RVA = "0xE95C04", Offset = "0xE95C04", VA = "0xE95C04")]
		internal static ushort Convert(float f)
		{
			return 0;
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x0000E358 File Offset: 0x0000C558
		[Token(Token = "0x6001DE8")]
		[Address(RVA = "0xE95FB8", Offset = "0xE95FB8", VA = "0xE95FB8")]
		internal static ushort Convert(int i)
		{
			return 0;
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x0000E370 File Offset: 0x0000C570
		[Token(Token = "0x6001DE9")]
		[Address(RVA = "0xE95C8C", Offset = "0xE95C8C", VA = "0xE95C8C")]
		internal static float Convert(ushort value)
		{
			return 0f;
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DEA")]
		[Address(RVA = "0xE96090", Offset = "0xE96090", VA = "0xE96090")]
		public HalfTypeHelper()
		{
		}

		// Token: 0x02000430 RID: 1072
		[Token(Token = "0x2000430")]
		[StructLayout(2)]
		private struct uif
		{
			// Token: 0x04003140 RID: 12608
			[Token(Token = "0x4003140")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float f;

			// Token: 0x04003141 RID: 12609
			[Token(Token = "0x4003141")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i;

			// Token: 0x04003142 RID: 12610
			[Token(Token = "0x4003142")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint u;
		}
	}
}
