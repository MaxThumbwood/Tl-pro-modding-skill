using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x02000429 RID: 1065
	[Token(Token = "0x2000429")]
	public struct Alpha8 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x0000DE90 File Offset: 0x0000C090
		// (set) Token: 0x06001D9A RID: 7578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B0")]
		public byte PackedValue
		{
			[Token(Token = "0x6001D99")]
			[Address(RVA = "0xE93F58", Offset = "0xE93F58", VA = "0xE93F58", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D9A")]
			[Address(RVA = "0xE93F60", Offset = "0xE93F60", VA = "0xE93F60", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D9B")]
		[Address(RVA = "0xE93F68", Offset = "0xE93F68", VA = "0xE93F68")]
		public Alpha8(float alpha)
		{
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		[Token(Token = "0x6001D9C")]
		[Address(RVA = "0xE940C0", Offset = "0xE940C0", VA = "0xE940C0")]
		public float ToAlpha()
		{
			return 0f;
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D9D")]
		[Address(RVA = "0xE940E0", Offset = "0xE940E0", VA = "0xE940E0", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		[Token(Token = "0x6001D9E")]
		[Address(RVA = "0xE940F8", Offset = "0xE940F8", VA = "0xE940F8", Slot = "7")]
		private Vector4 Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x0000DED8 File Offset: 0x0000C0D8
		[Token(Token = "0x6001D9F")]
		[Address(RVA = "0xE94144", Offset = "0xE94144", VA = "0xE94144", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
		[Token(Token = "0x6001DA0")]
		[Address(RVA = "0xE941C8", Offset = "0xE941C8", VA = "0xE941C8", Slot = "8")]
		public bool Equals(Alpha8 other)
		{
			return default(bool);
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA1")]
		[Address(RVA = "0xE941E0", Offset = "0xE941E0", VA = "0xE941E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x0000DF08 File Offset: 0x0000C108
		[Token(Token = "0x6001DA2")]
		[Address(RVA = "0xE94218", Offset = "0xE94218", VA = "0xE94218", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x0000DF20 File Offset: 0x0000C120
		[Token(Token = "0x6001DA3")]
		[Address(RVA = "0xE94220", Offset = "0xE94220", VA = "0xE94220")]
		public static bool operator ==(Alpha8 lhs, Alpha8 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x0000DF38 File Offset: 0x0000C138
		[Token(Token = "0x6001DA4")]
		[Address(RVA = "0xE94234", Offset = "0xE94234", VA = "0xE94234")]
		public static bool operator !=(Alpha8 lhs, Alpha8 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x0000DF50 File Offset: 0x0000C150
		[Token(Token = "0x6001DA5")]
		[Address(RVA = "0xE93F80", Offset = "0xE93F80", VA = "0xE93F80")]
		private static byte Pack(float alpha)
		{
			return 0;
		}

		// Token: 0x0400313A RID: 12602
		[Token(Token = "0x400313A")]
		[FieldOffset(Offset = "0x0")]
		private byte packedValue;
	}
}
