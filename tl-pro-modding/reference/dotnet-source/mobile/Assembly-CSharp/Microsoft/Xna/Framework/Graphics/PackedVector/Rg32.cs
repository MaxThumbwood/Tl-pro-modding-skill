using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x02000439 RID: 1081
	[Token(Token = "0x2000439")]
	public struct Rg32 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x0000E850 File Offset: 0x0000CA50
		// (set) Token: 0x06001E41 RID: 7745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BD")]
		public uint PackedValue
		{
			[Token(Token = "0x6001E40")]
			[Address(RVA = "0xE97E94", Offset = "0xE97E94", VA = "0xE97E94", Slot = "4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E41")]
			[Address(RVA = "0xE97E9C", Offset = "0xE97E9C", VA = "0xE97E9C", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E42")]
		[Address(RVA = "0xE97EA4", Offset = "0xE97EA4", VA = "0xE97EA4")]
		public Rg32(float x, float y)
		{
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E43")]
		[Address(RVA = "0xE980C8", Offset = "0xE980C8", VA = "0xE980C8")]
		public Rg32(Vector2 vector)
		{
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x0000E868 File Offset: 0x0000CA68
		[Token(Token = "0x6001E44")]
		[Address(RVA = "0xE980E4", Offset = "0xE980E4", VA = "0xE980E4")]
		public Vector2 ToVector2()
		{
			return default(Vector2);
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E45")]
		[Address(RVA = "0xE9813C", Offset = "0xE9813C", VA = "0xE9813C", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x0000E880 File Offset: 0x0000CA80
		[Token(Token = "0x6001E46")]
		[Address(RVA = "0xE98158", Offset = "0xE98158", VA = "0xE98158", Slot = "7")]
		private Vector4 Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x0000E898 File Offset: 0x0000CA98
		[Token(Token = "0x6001E47")]
		[Address(RVA = "0xE981E4", Offset = "0xE981E4", VA = "0xE981E4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		[Token(Token = "0x6001E48")]
		[Address(RVA = "0xE98268", Offset = "0xE98268", VA = "0xE98268", Slot = "8")]
		public bool Equals(Rg32 other)
		{
			return default(bool);
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E49")]
		[Address(RVA = "0xE9827C", Offset = "0xE9827C", VA = "0xE9827C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		[Token(Token = "0x6001E4A")]
		[Address(RVA = "0xE9834C", Offset = "0xE9834C", VA = "0xE9834C", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		[Token(Token = "0x6001E4B")]
		[Address(RVA = "0xE98354", Offset = "0xE98354", VA = "0xE98354")]
		public static bool operator ==(Rg32 lhs, Rg32 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
		[Token(Token = "0x6001E4C")]
		[Address(RVA = "0xE98364", Offset = "0xE98364", VA = "0xE98364")]
		public static bool operator !=(Rg32 lhs, Rg32 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x0000E910 File Offset: 0x0000CB10
		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0xE97EC0", Offset = "0xE97EC0", VA = "0xE97EC0")]
		private static uint Pack(float x, float y)
		{
			return 0U;
		}

		// Token: 0x04003149 RID: 12617
		[Token(Token = "0x4003149")]
		[FieldOffset(Offset = "0x0")]
		private uint packedValue;
	}
}
