using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x0200042A RID: 1066
	[Token(Token = "0x200042A")]
	public struct Bgr565 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x06001DA6 RID: 7590 RVA: 0x0000DF68 File Offset: 0x0000C168
		[Token(Token = "0x6001DA6")]
		[Address(RVA = "0xE94248", Offset = "0xE94248", VA = "0xE94248")]
		private static ushort Pack(float x, float y, float z)
		{
			return 0;
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA7")]
		[Address(RVA = "0xE94520", Offset = "0xE94520", VA = "0xE94520")]
		public Bgr565(float x, float y, float z)
		{
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA8")]
		[Address(RVA = "0xE94540", Offset = "0xE94540", VA = "0xE94540")]
		public Bgr565(Vector3 vector)
		{
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x0000DF80 File Offset: 0x0000C180
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B1")]
		public ushort PackedValue
		{
			[Token(Token = "0x6001DA9")]
			[Address(RVA = "0xE94560", Offset = "0xE94560", VA = "0xE94560", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001DAA")]
			[Address(RVA = "0xE94568", Offset = "0xE94568", VA = "0xE94568", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x0000DF98 File Offset: 0x0000C198
		[Token(Token = "0x6001DAB")]
		[Address(RVA = "0xE94570", Offset = "0xE94570", VA = "0xE94570")]
		public Vector3 ToVector3()
		{
			return default(Vector3);
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DAC")]
		[Address(RVA = "0xE945E8", Offset = "0xE945E8", VA = "0xE945E8", Slot = "6")]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		[Token(Token = "0x6001DAD")]
		[Address(RVA = "0xE94664", Offset = "0xE94664", VA = "0xE94664", Slot = "7")]
		private Vector4 Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
		[Token(Token = "0x6001DAE")]
		[Address(RVA = "0xE94704", Offset = "0xE94704", VA = "0xE94704", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		[Token(Token = "0x6001DAF")]
		[Address(RVA = "0xE9479C", Offset = "0xE9479C", VA = "0xE9479C", Slot = "8")]
		public bool Equals(Bgr565 other)
		{
			return default(bool);
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DB0")]
		[Address(RVA = "0xE947B4", Offset = "0xE947B4", VA = "0xE947B4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x0000DFF8 File Offset: 0x0000C1F8
		[Token(Token = "0x6001DB1")]
		[Address(RVA = "0xE948AC", Offset = "0xE948AC", VA = "0xE948AC", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x0000E010 File Offset: 0x0000C210
		[Token(Token = "0x6001DB2")]
		[Address(RVA = "0xE94788", Offset = "0xE94788", VA = "0xE94788")]
		public static bool operator ==(Bgr565 lhs, Bgr565 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x0000E028 File Offset: 0x0000C228
		[Token(Token = "0x6001DB3")]
		[Address(RVA = "0xE948B4", Offset = "0xE948B4", VA = "0xE948B4")]
		public static bool operator !=(Bgr565 lhs, Bgr565 rhs)
		{
			return default(bool);
		}

		// Token: 0x0400313B RID: 12603
		[Token(Token = "0x400313B")]
		[FieldOffset(Offset = "0x0")]
		private ushort _packedValue;
	}
}
