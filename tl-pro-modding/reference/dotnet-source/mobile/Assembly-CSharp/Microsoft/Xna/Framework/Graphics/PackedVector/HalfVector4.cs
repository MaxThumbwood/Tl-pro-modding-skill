using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x02000432 RID: 1074
	[Token(Token = "0x2000432")]
	public struct HalfVector4 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x06001DF9 RID: 7673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF9")]
		[Address(RVA = "0xE963DC", Offset = "0xE963DC", VA = "0xE963DC")]
		public HalfVector4(float x, float y, float z, float w)
		{
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFA")]
		[Address(RVA = "0xE96500", Offset = "0xE96500", VA = "0xE96500")]
		public HalfVector4(Vector4 vector)
		{
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFB")]
		[Address(RVA = "0xE9654C", Offset = "0xE9654C", VA = "0xE9654C", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x0000E460 File Offset: 0x0000C660
		[Token(Token = "0x6001DFC")]
		[Address(RVA = "0xE964BC", Offset = "0xE964BC", VA = "0xE964BC")]
		private static ulong PackHelper(ref Vector4 vector)
		{
			return 0UL;
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x0000E478 File Offset: 0x0000C678
		[Token(Token = "0x6001DFD")]
		[Address(RVA = "0xE96598", Offset = "0xE96598", VA = "0xE96598", Slot = "7")]
		public Vector4 ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x0000E490 File Offset: 0x0000C690
		// (set) Token: 0x06001DFF RID: 7679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B7")]
		public ulong PackedValue
		{
			[Token(Token = "0x6001DFE")]
			[Address(RVA = "0xE96784", Offset = "0xE96784", VA = "0xE96784", Slot = "4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001DFF")]
			[Address(RVA = "0xE9678C", Offset = "0xE9678C", VA = "0xE9678C", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E00")]
		[Address(RVA = "0xE9679C", Offset = "0xE9679C", VA = "0xE9679C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		[Token(Token = "0x6001E01")]
		[Address(RVA = "0xE96830", Offset = "0xE96830", VA = "0xE96830", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x0000E4C0 File Offset: 0x0000C6C0
		[Token(Token = "0x6001E02")]
		[Address(RVA = "0xE96838", Offset = "0xE96838", VA = "0xE96838", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		[Token(Token = "0x6001E03")]
		[Address(RVA = "0xE968CC", Offset = "0xE968CC", VA = "0xE968CC", Slot = "8")]
		public bool Equals(HalfVector4 other)
		{
			return default(bool);
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
		[Token(Token = "0x6001E04")]
		[Address(RVA = "0xE968E8", Offset = "0xE968E8", VA = "0xE968E8")]
		public static bool operator ==(HalfVector4 a, HalfVector4 b)
		{
			return default(bool);
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x0000E508 File Offset: 0x0000C708
		[Token(Token = "0x6001E05")]
		[Address(RVA = "0xE96910", Offset = "0xE96910", VA = "0xE96910")]
		public static bool operator !=(HalfVector4 a, HalfVector4 b)
		{
			return default(bool);
		}

		// Token: 0x04003144 RID: 12612
		[Token(Token = "0x4003144")]
		[FieldOffset(Offset = "0x0")]
		private ulong packedValue;
	}
}
