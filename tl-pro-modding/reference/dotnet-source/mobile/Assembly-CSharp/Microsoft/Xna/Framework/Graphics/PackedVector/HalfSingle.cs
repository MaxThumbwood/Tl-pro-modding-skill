using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x0200042E RID: 1070
	[Token(Token = "0x200042E")]
	public struct HalfSingle : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x06001DDB RID: 7643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DDB")]
		[Address(RVA = "0xE95BEC", Offset = "0xE95BEC", VA = "0xE95BEC")]
		public HalfSingle(float single)
		{
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x0000E280 File Offset: 0x0000C480
		// (set) Token: 0x06001DDD RID: 7645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B5")]
		public ushort PackedValue
		{
			[Token(Token = "0x6001DDC")]
			[Address(RVA = "0xE95C08", Offset = "0xE95C08", VA = "0xE95C08", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001DDD")]
			[Address(RVA = "0xE95C10", Offset = "0xE95C10", VA = "0xE95C10", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x0000E298 File Offset: 0x0000C498
		[Token(Token = "0x6001DDE")]
		[Address(RVA = "0xE95C18", Offset = "0xE95C18", VA = "0xE95C18")]
		public float ToSingle()
		{
			return 0f;
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DDF")]
		[Address(RVA = "0xE95CFC", Offset = "0xE95CFC", VA = "0xE95CFC", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
		[Token(Token = "0x6001DE0")]
		[Address(RVA = "0xE95D14", Offset = "0xE95D14", VA = "0xE95D14", Slot = "7")]
		private Vector4 Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
		[Token(Token = "0x6001DE1")]
		[Address(RVA = "0xE95DBC", Offset = "0xE95DBC", VA = "0xE95DBC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x0000E2E0 File Offset: 0x0000C4E0
		[Token(Token = "0x6001DE2")]
		[Address(RVA = "0xE95EE8", Offset = "0xE95EE8", VA = "0xE95EE8", Slot = "8")]
		public bool Equals(HalfSingle other)
		{
			return default(bool);
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DE3")]
		[Address(RVA = "0xE95F00", Offset = "0xE95F00", VA = "0xE95F00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		[Token(Token = "0x6001DE4")]
		[Address(RVA = "0xE95F9C", Offset = "0xE95F9C", VA = "0xE95F9C", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x0000E310 File Offset: 0x0000C510
		[Token(Token = "0x6001DE5")]
		[Address(RVA = "0xE95ED4", Offset = "0xE95ED4", VA = "0xE95ED4")]
		public static bool operator ==(HalfSingle lhs, HalfSingle rhs)
		{
			return default(bool);
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x0000E328 File Offset: 0x0000C528
		[Token(Token = "0x6001DE6")]
		[Address(RVA = "0xE95FA4", Offset = "0xE95FA4", VA = "0xE95FA4")]
		public static bool operator !=(HalfSingle lhs, HalfSingle rhs)
		{
			return default(bool);
		}

		// Token: 0x0400313F RID: 12607
		[Token(Token = "0x400313F")]
		[FieldOffset(Offset = "0x0")]
		private ushort packedValue;
	}
}
