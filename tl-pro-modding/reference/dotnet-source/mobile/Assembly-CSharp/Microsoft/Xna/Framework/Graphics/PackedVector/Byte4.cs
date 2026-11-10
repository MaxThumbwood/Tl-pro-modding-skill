using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x0200042D RID: 1069
	[Token(Token = "0x200042D")]
	public struct Byte4 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x06001DCE RID: 7630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DCE")]
		[Address(RVA = "0xE955A0", Offset = "0xE955A0", VA = "0xE955A0")]
		public Byte4(Vector4 vector)
		{
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DCF")]
		[Address(RVA = "0xE9596C", Offset = "0xE9596C", VA = "0xE9596C")]
		public Byte4(float x, float y, float z, float w)
		{
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
		[Token(Token = "0x6001DD0")]
		[Address(RVA = "0xE95A24", Offset = "0xE95A24", VA = "0xE95A24")]
		public static bool operator !=(Byte4 a, Byte4 b)
		{
			return default(bool);
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		[Token(Token = "0x6001DD1")]
		[Address(RVA = "0xE95A30", Offset = "0xE95A30", VA = "0xE95A30")]
		public static bool operator ==(Byte4 a, Byte4 b)
		{
			return default(bool);
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B4")]
		public uint PackedValue
		{
			[Token(Token = "0x6001DD2")]
			[Address(RVA = "0xE95A40", Offset = "0xE95A40", VA = "0xE95A40", Slot = "4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001DD3")]
			[Address(RVA = "0xE95A48", Offset = "0xE95A48", VA = "0xE95A48", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x0000E208 File Offset: 0x0000C408
		[Token(Token = "0x6001DD4")]
		[Address(RVA = "0xE95A50", Offset = "0xE95A50", VA = "0xE95A50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x0000E220 File Offset: 0x0000C420
		[Token(Token = "0x6001DD5")]
		[Address(RVA = "0xE95AD4", Offset = "0xE95AD4", VA = "0xE95AD4", Slot = "8")]
		public bool Equals(Byte4 other)
		{
			return default(bool);
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x0000E238 File Offset: 0x0000C438
		[Token(Token = "0x6001DD6")]
		[Address(RVA = "0xE95AE8", Offset = "0xE95AE8", VA = "0xE95AE8", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD7")]
		[Address(RVA = "0xE95AF0", Offset = "0xE95AF0", VA = "0xE95AF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x0000E250 File Offset: 0x0000C450
		[Token(Token = "0x6001DD8")]
		[Address(RVA = "0xE955CC", Offset = "0xE955CC", VA = "0xE955CC")]
		private static uint Pack(ref Vector4 vector)
		{
			return 0U;
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD9")]
		[Address(RVA = "0xE95B48", Offset = "0xE95B48", VA = "0xE95B48", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x0000E268 File Offset: 0x0000C468
		[Token(Token = "0x6001DDA")]
		[Address(RVA = "0xE95B74", Offset = "0xE95B74", VA = "0xE95B74", Slot = "7")]
		public Vector4 ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x0400313E RID: 12606
		[Token(Token = "0x400313E")]
		[FieldOffset(Offset = "0x0")]
		private uint packedValue;
	}
}
