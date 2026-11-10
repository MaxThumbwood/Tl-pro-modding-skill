using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x0200043A RID: 1082
	[Token(Token = "0x200043A")]
	public struct Rgba1010102 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x0000E928 File Offset: 0x0000CB28
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BE")]
		public uint PackedValue
		{
			[Token(Token = "0x6001E4E")]
			[Address(RVA = "0xE98370", Offset = "0xE98370", VA = "0xE98370", Slot = "4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E4F")]
			[Address(RVA = "0xE98378", Offset = "0xE98378", VA = "0xE98378", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E50")]
		[Address(RVA = "0xE98380", Offset = "0xE98380", VA = "0xE98380")]
		public Rgba1010102(float x, float y, float z, float w)
		{
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E51")]
		[Address(RVA = "0xE98750", Offset = "0xE98750", VA = "0xE98750")]
		public Rgba1010102(Vector4 vector)
		{
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x0000E940 File Offset: 0x0000CB40
		[Token(Token = "0x6001E52")]
		[Address(RVA = "0xE98780", Offset = "0xE98780", VA = "0xE98780", Slot = "7")]
		public Vector4 ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E53")]
		[Address(RVA = "0xE98818", Offset = "0xE98818", VA = "0xE98818", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x0000E958 File Offset: 0x0000CB58
		[Token(Token = "0x6001E54")]
		[Address(RVA = "0xE98848", Offset = "0xE98848", VA = "0xE98848", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x0000E970 File Offset: 0x0000CB70
		[Token(Token = "0x6001E55")]
		[Address(RVA = "0xE988CC", Offset = "0xE988CC", VA = "0xE988CC", Slot = "8")]
		public bool Equals(Rgba1010102 other)
		{
			return default(bool);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E56")]
		[Address(RVA = "0xE988E0", Offset = "0xE988E0", VA = "0xE988E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x0000E988 File Offset: 0x0000CB88
		[Token(Token = "0x6001E57")]
		[Address(RVA = "0xE989F0", Offset = "0xE989F0", VA = "0xE989F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
		[Token(Token = "0x6001E58")]
		[Address(RVA = "0xE989F8", Offset = "0xE989F8", VA = "0xE989F8")]
		public static bool operator ==(Rgba1010102 lhs, Rgba1010102 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
		[Token(Token = "0x6001E59")]
		[Address(RVA = "0xE98A08", Offset = "0xE98A08", VA = "0xE98A08")]
		public static bool operator !=(Rgba1010102 lhs, Rgba1010102 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		[Token(Token = "0x6001E5A")]
		[Address(RVA = "0xE983B0", Offset = "0xE983B0", VA = "0xE983B0")]
		private static uint Pack(float x, float y, float z, float w)
		{
			return 0U;
		}

		// Token: 0x0400314A RID: 12618
		[Token(Token = "0x400314A")]
		[FieldOffset(Offset = "0x0")]
		private uint packedValue;
	}
}
