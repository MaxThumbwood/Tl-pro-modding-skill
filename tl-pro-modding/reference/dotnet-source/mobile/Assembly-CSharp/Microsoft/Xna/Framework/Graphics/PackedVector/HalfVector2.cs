using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x02000431 RID: 1073
	[Token(Token = "0x2000431")]
	public struct HalfVector2 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x06001DEB RID: 7659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DEB")]
		[Address(RVA = "0xE96098", Offset = "0xE96098", VA = "0xE96098")]
		public HalfVector2(float x, float y)
		{
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DEC")]
		[Address(RVA = "0xE960E4", Offset = "0xE960E4", VA = "0xE960E4")]
		public HalfVector2(Vector2 vector)
		{
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DED")]
		[Address(RVA = "0xE96110", Offset = "0xE96110", VA = "0xE96110", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x0000E388 File Offset: 0x0000C588
		[Token(Token = "0x6001DEE")]
		[Address(RVA = "0xE960C4", Offset = "0xE960C4", VA = "0xE960C4")]
		private static uint PackHelper(float vectorX, float vectorY)
		{
			return 0U;
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
		[Token(Token = "0x6001DEF")]
		[Address(RVA = "0xE9613C", Offset = "0xE9613C", VA = "0xE9613C")]
		public Vector2 ToVector2()
		{
			return default(Vector2);
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
		[Token(Token = "0x6001DF0")]
		[Address(RVA = "0xE96224", Offset = "0xE96224", VA = "0xE96224", Slot = "7")]
		private Vector4 Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B6")]
		public uint PackedValue
		{
			[Token(Token = "0x6001DF1")]
			[Address(RVA = "0xE9626C", Offset = "0xE9626C", VA = "0xE9626C", Slot = "4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001DF2")]
			[Address(RVA = "0xE96274", Offset = "0xE96274", VA = "0xE96274", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DF3")]
		[Address(RVA = "0xE9627C", Offset = "0xE9627C", VA = "0xE9627C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
		[Token(Token = "0x6001DF4")]
		[Address(RVA = "0xE96304", Offset = "0xE96304", VA = "0xE96304", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x0000E400 File Offset: 0x0000C600
		[Token(Token = "0x6001DF5")]
		[Address(RVA = "0xE9630C", Offset = "0xE9630C", VA = "0xE9630C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x0000E418 File Offset: 0x0000C618
		[Token(Token = "0x6001DF6")]
		[Address(RVA = "0xE96390", Offset = "0xE96390", VA = "0xE96390", Slot = "8")]
		public bool Equals(HalfVector2 other)
		{
			return default(bool);
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x0000E430 File Offset: 0x0000C630
		[Token(Token = "0x6001DF7")]
		[Address(RVA = "0xE96398", Offset = "0xE96398", VA = "0xE96398")]
		public static bool operator ==(HalfVector2 a, HalfVector2 b)
		{
			return default(bool);
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x0000E448 File Offset: 0x0000C648
		[Token(Token = "0x6001DF8")]
		[Address(RVA = "0xE963B8", Offset = "0xE963B8", VA = "0xE963B8")]
		public static bool operator !=(HalfVector2 a, HalfVector2 b)
		{
			return default(bool);
		}

		// Token: 0x04003143 RID: 12611
		[Token(Token = "0x4003143")]
		[FieldOffset(Offset = "0x0")]
		private uint packedValue;
	}
}
