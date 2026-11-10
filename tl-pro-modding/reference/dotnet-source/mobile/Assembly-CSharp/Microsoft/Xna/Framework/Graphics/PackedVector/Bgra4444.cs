using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x0200042B RID: 1067
	[Token(Token = "0x200042B")]
	public struct Bgra4444 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x06001DB4 RID: 7604 RVA: 0x0000E040 File Offset: 0x0000C240
		[Token(Token = "0x6001DB4")]
		[Address(RVA = "0xE948C8", Offset = "0xE948C8", VA = "0xE948C8")]
		private static ushort Pack(float x, float y, float z, float w)
		{
			return 0;
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB5")]
		[Address(RVA = "0xE94C5C", Offset = "0xE94C5C", VA = "0xE94C5C")]
		public Bgra4444(float x, float y, float z, float w)
		{
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DB6")]
		[Address(RVA = "0xE94C8C", Offset = "0xE94C8C", VA = "0xE94C8C")]
		public Bgra4444(Vector4 vector)
		{
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x0000E058 File Offset: 0x0000C258
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B2")]
		public ushort PackedValue
		{
			[Token(Token = "0x6001DB7")]
			[Address(RVA = "0xE94CBC", Offset = "0xE94CBC", VA = "0xE94CBC", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001DB8")]
			[Address(RVA = "0xE94CC4", Offset = "0xE94CC4", VA = "0xE94CC4", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x0000E070 File Offset: 0x0000C270
		[Token(Token = "0x6001DB9")]
		[Address(RVA = "0xE94CCC", Offset = "0xE94CCC", VA = "0xE94CCC", Slot = "7")]
		public Vector4 ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DBA")]
		[Address(RVA = "0xE94D4C", Offset = "0xE94D4C", VA = "0xE94D4C", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x0000E088 File Offset: 0x0000C288
		[Token(Token = "0x6001DBB")]
		[Address(RVA = "0xE94D7C", Offset = "0xE94D7C", VA = "0xE94D7C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		[Token(Token = "0x6001DBC")]
		[Address(RVA = "0xE94E14", Offset = "0xE94E14", VA = "0xE94E14", Slot = "8")]
		public bool Equals(Bgra4444 other)
		{
			return default(bool);
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DBD")]
		[Address(RVA = "0xE94E2C", Offset = "0xE94E2C", VA = "0xE94E2C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		[Token(Token = "0x6001DBE")]
		[Address(RVA = "0xE94F24", Offset = "0xE94F24", VA = "0xE94F24", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
		[Token(Token = "0x6001DBF")]
		[Address(RVA = "0xE94E00", Offset = "0xE94E00", VA = "0xE94E00")]
		public static bool operator ==(Bgra4444 lhs, Bgra4444 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		[Token(Token = "0x6001DC0")]
		[Address(RVA = "0xE94F2C", Offset = "0xE94F2C", VA = "0xE94F2C")]
		public static bool operator !=(Bgra4444 lhs, Bgra4444 rhs)
		{
			return default(bool);
		}

		// Token: 0x0400313C RID: 12604
		[Token(Token = "0x400313C")]
		[FieldOffset(Offset = "0x0")]
		private ushort _packedValue;
	}
}
