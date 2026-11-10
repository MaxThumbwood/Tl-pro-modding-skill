using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x0200043B RID: 1083
	[Token(Token = "0x200043B")]
	public struct Rgba64 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
		// (set) Token: 0x06001E5C RID: 7772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BF")]
		public ulong PackedValue
		{
			[Token(Token = "0x6001E5B")]
			[Address(RVA = "0xE98A14", Offset = "0xE98A14", VA = "0xE98A14", Slot = "4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001E5C")]
			[Address(RVA = "0xE98A1C", Offset = "0xE98A1C", VA = "0xE98A1C", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E5D")]
		[Address(RVA = "0xE98A2C", Offset = "0xE98A2C", VA = "0xE98A2C")]
		public Rgba64(float x, float y, float z, float w)
		{
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E5E")]
		[Address(RVA = "0xE98E9C", Offset = "0xE98E9C", VA = "0xE98E9C")]
		public Rgba64(Vector4 vector)
		{
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x0000EA00 File Offset: 0x0000CC00
		[Token(Token = "0x6001E5F")]
		[Address(RVA = "0xE98ECC", Offset = "0xE98ECC", VA = "0xE98ECC", Slot = "7")]
		public Vector4 ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E60")]
		[Address(RVA = "0xE98F84", Offset = "0xE98F84", VA = "0xE98F84", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x0000EA18 File Offset: 0x0000CC18
		[Token(Token = "0x6001E61")]
		[Address(RVA = "0xE98FB4", Offset = "0xE98FB4", VA = "0xE98FB4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x0000EA30 File Offset: 0x0000CC30
		[Token(Token = "0x6001E62")]
		[Address(RVA = "0xE99040", Offset = "0xE99040", VA = "0xE99040", Slot = "8")]
		public bool Equals(Rgba64 other)
		{
			return default(bool);
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E63")]
		[Address(RVA = "0xE9905C", Offset = "0xE9905C", VA = "0xE9905C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x0000EA48 File Offset: 0x0000CC48
		[Token(Token = "0x6001E64")]
		[Address(RVA = "0xE99184", Offset = "0xE99184", VA = "0xE99184", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x0000EA60 File Offset: 0x0000CC60
		[Token(Token = "0x6001E65")]
		[Address(RVA = "0xE9918C", Offset = "0xE9918C", VA = "0xE9918C")]
		public static bool operator ==(Rgba64 lhs, Rgba64 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x0000EA78 File Offset: 0x0000CC78
		[Token(Token = "0x6001E66")]
		[Address(RVA = "0xE991A4", Offset = "0xE991A4", VA = "0xE991A4")]
		public static bool operator !=(Rgba64 lhs, Rgba64 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x0000EA90 File Offset: 0x0000CC90
		[Token(Token = "0x6001E67")]
		[Address(RVA = "0xE98A5C", Offset = "0xE98A5C", VA = "0xE98A5C")]
		private static ulong Pack(float x, float y, float z, float w)
		{
			return 0UL;
		}

		// Token: 0x0400314B RID: 12619
		[Token(Token = "0x400314B")]
		[FieldOffset(Offset = "0x0")]
		private ulong packedValue;
	}
}
