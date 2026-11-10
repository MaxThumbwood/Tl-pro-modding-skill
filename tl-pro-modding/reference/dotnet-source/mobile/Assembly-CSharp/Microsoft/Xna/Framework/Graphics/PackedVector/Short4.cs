using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x0200043D RID: 1085
	[Token(Token = "0x200043D")]
	public struct Short4 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x06001E76 RID: 7798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E76")]
		[Address(RVA = "0xE9961C", Offset = "0xE9961C", VA = "0xE9961C")]
		public Short4(Vector4 vector)
		{
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E77")]
		[Address(RVA = "0xE999CC", Offset = "0xE999CC", VA = "0xE999CC")]
		public Short4(float x, float y, float z, float w)
		{
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x0000EB80 File Offset: 0x0000CD80
		[Token(Token = "0x6001E78")]
		[Address(RVA = "0xE99A84", Offset = "0xE99A84", VA = "0xE99A84")]
		public static bool operator !=(Short4 a, Short4 b)
		{
			return default(bool);
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x0000EB98 File Offset: 0x0000CD98
		[Token(Token = "0x6001E79")]
		[Address(RVA = "0xE99A98", Offset = "0xE99A98", VA = "0xE99A98")]
		public static bool operator ==(Short4 a, Short4 b)
		{
			return default(bool);
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		// (set) Token: 0x06001E7B RID: 7803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C1")]
		public ulong PackedValue
		{
			[Token(Token = "0x6001E7A")]
			[Address(RVA = "0xE99AB0", Offset = "0xE99AB0", VA = "0xE99AB0", Slot = "4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001E7B")]
			[Address(RVA = "0xE99AB8", Offset = "0xE99AB8", VA = "0xE99AB8", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
		[Token(Token = "0x6001E7C")]
		[Address(RVA = "0xE99AC8", Offset = "0xE99AC8", VA = "0xE99AC8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
		[Token(Token = "0x6001E7D")]
		[Address(RVA = "0xE99B58", Offset = "0xE99B58", VA = "0xE99B58", Slot = "8")]
		public bool Equals(Short4 other)
		{
			return default(bool);
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		[Token(Token = "0x6001E7E")]
		[Address(RVA = "0xE99B74", Offset = "0xE99B74", VA = "0xE99B74", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E7F")]
		[Address(RVA = "0xE99B7C", Offset = "0xE99B7C", VA = "0xE99B7C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x0000EC10 File Offset: 0x0000CE10
		[Token(Token = "0x6001E80")]
		[Address(RVA = "0xE99648", Offset = "0xE99648", VA = "0xE99648")]
		private static ulong Pack(ref Vector4 vector)
		{
			return 0UL;
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E81")]
		[Address(RVA = "0xE99BD4", Offset = "0xE99BD4", VA = "0xE99BD4", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0000EC28 File Offset: 0x0000CE28
		[Token(Token = "0x6001E82")]
		[Address(RVA = "0xE99C00", Offset = "0xE99C00", VA = "0xE99C00", Slot = "7")]
		public Vector4 ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x0400314D RID: 12621
		[Token(Token = "0x400314D")]
		[FieldOffset(Offset = "0x0")]
		private ulong packedValue;
	}
}
