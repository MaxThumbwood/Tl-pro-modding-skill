using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x02000437 RID: 1079
	[Token(Token = "0x2000437")]
	public struct NormalizedShort2 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x06001E25 RID: 7717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E25")]
		[Address(RVA = "0xE973A8", Offset = "0xE973A8", VA = "0xE973A8")]
		public NormalizedShort2(Vector2 vector)
		{
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E26")]
		[Address(RVA = "0xE975E4", Offset = "0xE975E4", VA = "0xE975E4")]
		public NormalizedShort2(float x, float y)
		{
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		[Token(Token = "0x6001E27")]
		[Address(RVA = "0xE97600", Offset = "0xE97600", VA = "0xE97600")]
		public static bool operator !=(NormalizedShort2 a, NormalizedShort2 b)
		{
			return default(bool);
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
		[Token(Token = "0x6001E28")]
		[Address(RVA = "0xE9762C", Offset = "0xE9762C", VA = "0xE9762C")]
		public static bool operator ==(NormalizedShort2 a, NormalizedShort2 b)
		{
			return default(bool);
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
		// (set) Token: 0x06001E2A RID: 7722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BB")]
		public uint PackedValue
		{
			[Token(Token = "0x6001E29")]
			[Address(RVA = "0xE9764C", Offset = "0xE9764C", VA = "0xE9764C", Slot = "4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E2A")]
			[Address(RVA = "0xE97654", Offset = "0xE97654", VA = "0xE97654", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x0000E700 File Offset: 0x0000C900
		[Token(Token = "0x6001E2B")]
		[Address(RVA = "0xE9765C", Offset = "0xE9765C", VA = "0xE9765C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0000E718 File Offset: 0x0000C918
		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0xE97624", Offset = "0xE97624", VA = "0xE97624", Slot = "8")]
		public bool Equals(NormalizedShort2 other)
		{
			return default(bool);
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0000E730 File Offset: 0x0000C930
		[Token(Token = "0x6001E2D")]
		[Address(RVA = "0xE976E0", Offset = "0xE976E0", VA = "0xE976E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0xE976E8", Offset = "0xE976E8", VA = "0xE976E8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x0000E748 File Offset: 0x0000C948
		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0xE97740", Offset = "0xE97740", VA = "0xE97740")]
		public Vector2 ToVector2()
		{
			return default(Vector2);
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x0000E760 File Offset: 0x0000C960
		[Token(Token = "0x6001E30")]
		[Address(RVA = "0xE973C4", Offset = "0xE973C4", VA = "0xE973C4")]
		private static uint PackInTwo(float vectorX, float vectorY)
		{
			return 0U;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E31")]
		[Address(RVA = "0xE97778", Offset = "0xE97778", VA = "0xE97778", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0000E778 File Offset: 0x0000C978
		[Token(Token = "0x6001E32")]
		[Address(RVA = "0xE97794", Offset = "0xE97794", VA = "0xE97794", Slot = "7")]
		private Vector4 Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x04003147 RID: 12615
		[Token(Token = "0x4003147")]
		[FieldOffset(Offset = "0x0")]
		private uint short2Packed;
	}
}
