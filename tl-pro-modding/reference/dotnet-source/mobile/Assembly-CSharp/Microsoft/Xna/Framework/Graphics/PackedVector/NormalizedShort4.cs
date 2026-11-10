using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x02000438 RID: 1080
	[Token(Token = "0x2000438")]
	public struct NormalizedShort4 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x06001E33 RID: 7731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E33")]
		[Address(RVA = "0xE97868", Offset = "0xE97868", VA = "0xE97868")]
		public NormalizedShort4(Vector4 vector)
		{
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E34")]
		[Address(RVA = "0xE97C58", Offset = "0xE97C58", VA = "0xE97C58")]
		public NormalizedShort4(float x, float y, float z, float w)
		{
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0000E790 File Offset: 0x0000C990
		[Token(Token = "0x6001E35")]
		[Address(RVA = "0xE97C88", Offset = "0xE97C88", VA = "0xE97C88")]
		public static bool operator !=(NormalizedShort4 a, NormalizedShort4 b)
		{
			return default(bool);
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
		[Token(Token = "0x6001E36")]
		[Address(RVA = "0xE97CD0", Offset = "0xE97CD0", VA = "0xE97CD0")]
		public static bool operator ==(NormalizedShort4 a, NormalizedShort4 b)
		{
			return default(bool);
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
		// (set) Token: 0x06001E38 RID: 7736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BC")]
		public ulong PackedValue
		{
			[Token(Token = "0x6001E37")]
			[Address(RVA = "0xE97CF8", Offset = "0xE97CF8", VA = "0xE97CF8", Slot = "4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001E38")]
			[Address(RVA = "0xE97D00", Offset = "0xE97D00", VA = "0xE97D00", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		[Token(Token = "0x6001E39")]
		[Address(RVA = "0xE97D10", Offset = "0xE97D10", VA = "0xE97D10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
		[Token(Token = "0x6001E3A")]
		[Address(RVA = "0xE97CB4", Offset = "0xE97CB4", VA = "0xE97CB4", Slot = "8")]
		public bool Equals(NormalizedShort4 other)
		{
			return default(bool);
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x0000E808 File Offset: 0x0000CA08
		[Token(Token = "0x6001E3B")]
		[Address(RVA = "0xE97DA4", Offset = "0xE97DA4", VA = "0xE97DA4", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E3C")]
		[Address(RVA = "0xE97DAC", Offset = "0xE97DAC", VA = "0xE97DAC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x0000E820 File Offset: 0x0000CA20
		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0xE97898", Offset = "0xE97898", VA = "0xE97898")]
		private static ulong PackInFour(float vectorX, float vectorY, float vectorZ, float vectorW)
		{
			return 0UL;
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3E")]
		[Address(RVA = "0xE97E04", Offset = "0xE97E04", VA = "0xE97E04", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x0000E838 File Offset: 0x0000CA38
		[Token(Token = "0x6001E3F")]
		[Address(RVA = "0xE97E34", Offset = "0xE97E34", VA = "0xE97E34", Slot = "7")]
		public Vector4 ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x04003148 RID: 12616
		[Token(Token = "0x4003148")]
		[FieldOffset(Offset = "0x0")]
		private ulong short4Packed;
	}
}
