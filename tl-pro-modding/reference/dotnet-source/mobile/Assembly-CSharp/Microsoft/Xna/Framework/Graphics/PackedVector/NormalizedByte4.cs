using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x02000436 RID: 1078
	[Token(Token = "0x2000436")]
	public struct NormalizedByte4 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x06001E18 RID: 7704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E18")]
		[Address(RVA = "0xE96DB0", Offset = "0xE96DB0", VA = "0xE96DB0")]
		public NormalizedByte4(Vector4 vector)
		{
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E19")]
		[Address(RVA = "0xE971A4", Offset = "0xE971A4", VA = "0xE971A4")]
		public NormalizedByte4(float x, float y, float z, float w)
		{
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		[Token(Token = "0x6001E1A")]
		[Address(RVA = "0xE971D4", Offset = "0xE971D4", VA = "0xE971D4")]
		public static bool operator !=(NormalizedByte4 a, NormalizedByte4 b)
		{
			return default(bool);
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x0000E610 File Offset: 0x0000C810
		[Token(Token = "0x6001E1B")]
		[Address(RVA = "0xE971E0", Offset = "0xE971E0", VA = "0xE971E0")]
		public static bool operator ==(NormalizedByte4 a, NormalizedByte4 b)
		{
			return default(bool);
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x0000E628 File Offset: 0x0000C828
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BA")]
		public uint PackedValue
		{
			[Token(Token = "0x6001E1C")]
			[Address(RVA = "0xE971F0", Offset = "0xE971F0", VA = "0xE971F0", Slot = "4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E1D")]
			[Address(RVA = "0xE971F8", Offset = "0xE971F8", VA = "0xE971F8", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x0000E640 File Offset: 0x0000C840
		[Token(Token = "0x6001E1E")]
		[Address(RVA = "0xE97200", Offset = "0xE97200", VA = "0xE97200", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x0000E658 File Offset: 0x0000C858
		[Token(Token = "0x6001E1F")]
		[Address(RVA = "0xE97284", Offset = "0xE97284", VA = "0xE97284", Slot = "8")]
		public bool Equals(NormalizedByte4 other)
		{
			return default(bool);
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x0000E670 File Offset: 0x0000C870
		[Token(Token = "0x6001E20")]
		[Address(RVA = "0xE97298", Offset = "0xE97298", VA = "0xE97298", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E21")]
		[Address(RVA = "0xE972A0", Offset = "0xE972A0", VA = "0xE972A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x0000E688 File Offset: 0x0000C888
		[Token(Token = "0x6001E22")]
		[Address(RVA = "0xE96DE0", Offset = "0xE96DE0", VA = "0xE96DE0")]
		private static uint Pack(float x, float y, float z, float w)
		{
			return 0U;
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E23")]
		[Address(RVA = "0xE972F8", Offset = "0xE972F8", VA = "0xE972F8", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		[Token(Token = "0x6001E24")]
		[Address(RVA = "0xE97328", Offset = "0xE97328", VA = "0xE97328", Slot = "7")]
		public Vector4 ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x04003146 RID: 12614
		[Token(Token = "0x4003146")]
		[FieldOffset(Offset = "0x0")]
		private uint _packed;
	}
}
