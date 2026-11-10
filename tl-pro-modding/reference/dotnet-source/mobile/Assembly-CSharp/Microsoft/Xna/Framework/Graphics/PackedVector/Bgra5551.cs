using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x0200042C RID: 1068
	[Token(Token = "0x200042C")]
	public struct Bgra5551 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x0000E100 File Offset: 0x0000C300
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B3")]
		public ushort PackedValue
		{
			[Token(Token = "0x6001DC1")]
			[Address(RVA = "0xE94F40", Offset = "0xE94F40", VA = "0xE94F40", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001DC2")]
			[Address(RVA = "0xE94F48", Offset = "0xE94F48", VA = "0xE94F48", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC3")]
		[Address(RVA = "0xE94F50", Offset = "0xE94F50", VA = "0xE94F50")]
		public Bgra5551(float x, float y, float z, float w)
		{
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC4")]
		[Address(RVA = "0xE9530C", Offset = "0xE9530C", VA = "0xE9530C")]
		public Bgra5551(Vector4 vector)
		{
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x0000E118 File Offset: 0x0000C318
		[Token(Token = "0x6001DC5")]
		[Address(RVA = "0xE9533C", Offset = "0xE9533C", VA = "0xE9533C", Slot = "7")]
		public Vector4 ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC6")]
		[Address(RVA = "0xE953B4", Offset = "0xE953B4", VA = "0xE953B4", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x0000E130 File Offset: 0x0000C330
		[Token(Token = "0x6001DC7")]
		[Address(RVA = "0xE953E4", Offset = "0xE953E4", VA = "0xE953E4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x0000E148 File Offset: 0x0000C348
		[Token(Token = "0x6001DC8")]
		[Address(RVA = "0xE95468", Offset = "0xE95468", VA = "0xE95468", Slot = "8")]
		public bool Equals(Bgra5551 other)
		{
			return default(bool);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC9")]
		[Address(RVA = "0xE95480", Offset = "0xE95480", VA = "0xE95480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x0000E160 File Offset: 0x0000C360
		[Token(Token = "0x6001DCA")]
		[Address(RVA = "0xE95570", Offset = "0xE95570", VA = "0xE95570", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x0000E178 File Offset: 0x0000C378
		[Token(Token = "0x6001DCB")]
		[Address(RVA = "0xE95578", Offset = "0xE95578", VA = "0xE95578")]
		public static bool operator ==(Bgra5551 lhs, Bgra5551 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x0000E190 File Offset: 0x0000C390
		[Token(Token = "0x6001DCC")]
		[Address(RVA = "0xE9558C", Offset = "0xE9558C", VA = "0xE9558C")]
		public static bool operator !=(Bgra5551 lhs, Bgra5551 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		[Token(Token = "0x6001DCD")]
		[Address(RVA = "0xE94F80", Offset = "0xE94F80", VA = "0xE94F80")]
		private static ushort Pack(float x, float y, float z, float w)
		{
			return 0;
		}

		// Token: 0x0400313D RID: 12605
		[Token(Token = "0x400313D")]
		[FieldOffset(Offset = "0x0")]
		private ushort packedValue;
	}
}
