using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x02000435 RID: 1077
	[Token(Token = "0x2000435")]
	public struct NormalizedByte2 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x06001E0A RID: 7690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E0A")]
		[Address(RVA = "0xE9693C", Offset = "0xE9693C", VA = "0xE9693C")]
		public NormalizedByte2(Vector2 vector)
		{
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E0B")]
		[Address(RVA = "0xE96B70", Offset = "0xE96B70", VA = "0xE96B70")]
		public NormalizedByte2(float x, float y)
		{
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x0000E520 File Offset: 0x0000C720
		[Token(Token = "0x6001E0C")]
		[Address(RVA = "0xE96B8C", Offset = "0xE96B8C", VA = "0xE96B8C")]
		public static bool operator !=(NormalizedByte2 a, NormalizedByte2 b)
		{
			return default(bool);
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x0000E538 File Offset: 0x0000C738
		[Token(Token = "0x6001E0D")]
		[Address(RVA = "0xE96BA0", Offset = "0xE96BA0", VA = "0xE96BA0")]
		public static bool operator ==(NormalizedByte2 a, NormalizedByte2 b)
		{
			return default(bool);
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x0000E550 File Offset: 0x0000C750
		// (set) Token: 0x06001E0F RID: 7695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B9")]
		public ushort PackedValue
		{
			[Token(Token = "0x6001E0E")]
			[Address(RVA = "0xE96BB4", Offset = "0xE96BB4", VA = "0xE96BB4", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E0F")]
			[Address(RVA = "0xE96BBC", Offset = "0xE96BBC", VA = "0xE96BBC", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x0000E568 File Offset: 0x0000C768
		[Token(Token = "0x6001E10")]
		[Address(RVA = "0xE96BC4", Offset = "0xE96BC4", VA = "0xE96BC4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x0000E580 File Offset: 0x0000C780
		[Token(Token = "0x6001E11")]
		[Address(RVA = "0xE96C48", Offset = "0xE96C48", VA = "0xE96C48", Slot = "8")]
		public bool Equals(NormalizedByte2 other)
		{
			return default(bool);
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x0000E598 File Offset: 0x0000C798
		[Token(Token = "0x6001E12")]
		[Address(RVA = "0xE96C60", Offset = "0xE96C60", VA = "0xE96C60", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E13")]
		[Address(RVA = "0xE96C68", Offset = "0xE96C68", VA = "0xE96C68", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		[Token(Token = "0x6001E14")]
		[Address(RVA = "0xE96958", Offset = "0xE96958", VA = "0xE96958")]
		private static ushort Pack(float x, float y)
		{
			return 0;
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E15")]
		[Address(RVA = "0xE96CC0", Offset = "0xE96CC0", VA = "0xE96CC0", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		[Token(Token = "0x6001E16")]
		[Address(RVA = "0xE96CDC", Offset = "0xE96CDC", VA = "0xE96CDC", Slot = "7")]
		private Vector4 Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		[Token(Token = "0x6001E17")]
		[Address(RVA = "0xE96D60", Offset = "0xE96D60", VA = "0xE96D60")]
		public Vector2 ToVector2()
		{
			return default(Vector2);
		}

		// Token: 0x04003145 RID: 12613
		[Token(Token = "0x4003145")]
		[FieldOffset(Offset = "0x0")]
		private ushort _packed;
	}
}
