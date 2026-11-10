using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x0200043C RID: 1084
	[Token(Token = "0x200043C")]
	public struct Short2 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x06001E68 RID: 7784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E68")]
		[Address(RVA = "0xE991B8", Offset = "0xE991B8", VA = "0xE991B8")]
		public Short2(Vector2 vector)
		{
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E69")]
		[Address(RVA = "0xE993D4", Offset = "0xE993D4", VA = "0xE993D4")]
		public Short2(float x, float y)
		{
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		[Token(Token = "0x6001E6A")]
		[Address(RVA = "0xE993F0", Offset = "0xE993F0", VA = "0xE993F0")]
		public static bool operator !=(Short2 a, Short2 b)
		{
			return default(bool);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		[Token(Token = "0x6001E6B")]
		[Address(RVA = "0xE993FC", Offset = "0xE993FC", VA = "0xE993FC")]
		public static bool operator ==(Short2 a, Short2 b)
		{
			return default(bool);
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		// (set) Token: 0x06001E6D RID: 7789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C0")]
		public uint PackedValue
		{
			[Token(Token = "0x6001E6C")]
			[Address(RVA = "0xE9940C", Offset = "0xE9940C", VA = "0xE9940C", Slot = "4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E6D")]
			[Address(RVA = "0xE99414", Offset = "0xE99414", VA = "0xE99414", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		[Token(Token = "0x6001E6E")]
		[Address(RVA = "0xE9941C", Offset = "0xE9941C", VA = "0xE9941C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x0000EB08 File Offset: 0x0000CD08
		[Token(Token = "0x6001E6F")]
		[Address(RVA = "0xE994A0", Offset = "0xE994A0", VA = "0xE994A0", Slot = "8")]
		public bool Equals(Short2 other)
		{
			return default(bool);
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x0000EB20 File Offset: 0x0000CD20
		[Token(Token = "0x6001E70")]
		[Address(RVA = "0xE994B4", Offset = "0xE994B4", VA = "0xE994B4", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E71")]
		[Address(RVA = "0xE994BC", Offset = "0xE994BC", VA = "0xE994BC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x0000EB38 File Offset: 0x0000CD38
		[Token(Token = "0x6001E72")]
		[Address(RVA = "0xE99514", Offset = "0xE99514", VA = "0xE99514")]
		public Vector2 ToVector2()
		{
			return default(Vector2);
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x0000EB50 File Offset: 0x0000CD50
		[Token(Token = "0x6001E73")]
		[Address(RVA = "0xE991D4", Offset = "0xE991D4", VA = "0xE991D4")]
		private static uint PackInTwo(float vectorX, float vectorY)
		{
			return 0U;
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E74")]
		[Address(RVA = "0xE9953C", Offset = "0xE9953C", VA = "0xE9953C", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0000EB68 File Offset: 0x0000CD68
		[Token(Token = "0x6001E75")]
		[Address(RVA = "0xE99558", Offset = "0xE99558", VA = "0xE99558", Slot = "7")]
		private Vector4 Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x0400314C RID: 12620
		[Token(Token = "0x400314C")]
		[FieldOffset(Offset = "0x0")]
		private uint _short2Packed;
	}
}
