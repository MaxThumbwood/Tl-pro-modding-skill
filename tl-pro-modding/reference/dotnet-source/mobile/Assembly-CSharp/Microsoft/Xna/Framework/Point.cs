using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000398 RID: 920
	[Token(Token = "0x2000398")]
	[Serializable]
	public struct Point : FileAPI
	{
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060016E7 RID: 5863 RVA: 0x0000A608 File Offset: 0x00008808
		[Token(Token = "0x1700022D")]
		public static Point Zero
		{
			[Token(Token = "0x60016E7")]
			[Address(RVA = "0xE151F4", Offset = "0xE151F4", VA = "0xE151F4")]
			get
			{
				return default(Point);
			}
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E8")]
		[Address(RVA = "0xE15268", Offset = "0xE15268", VA = "0xE15268")]
		public Point(int x, int y)
		{
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x0000A620 File Offset: 0x00008820
		[Token(Token = "0x60016E9")]
		[Address(RVA = "0xE15270", Offset = "0xE15270", VA = "0xE15270")]
		public static bool operator ==(Point a, Point b)
		{
			return default(bool);
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x0000A638 File Offset: 0x00008838
		[Token(Token = "0x60016EA")]
		[Address(RVA = "0xE15310", Offset = "0xE15310", VA = "0xE15310")]
		public static bool operator !=(Point a, Point b)
		{
			return default(bool);
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x0000A650 File Offset: 0x00008850
		[Token(Token = "0x60016EB")]
		[Address(RVA = "0xE152EC", Offset = "0xE152EC", VA = "0xE152EC", Slot = "4")]
		public bool Equals(Point other)
		{
			return default(bool);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x0000A668 File Offset: 0x00008868
		[Token(Token = "0x60016EC")]
		[Address(RVA = "0xE15388", Offset = "0xE15388", VA = "0xE15388", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x0000A680 File Offset: 0x00008880
		[Token(Token = "0x60016ED")]
		[Address(RVA = "0xE15458", Offset = "0xE15458", VA = "0xE15458", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EE")]
		[Address(RVA = "0xE15468", Offset = "0xE15468", VA = "0xE15468", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04002B04 RID: 11012
		[Token(Token = "0x4002B04")]
		[FieldOffset(Offset = "0x0")]
		private static Point zeroPoint;

		// Token: 0x04002B05 RID: 11013
		[Token(Token = "0x4002B05")]
		[FieldOffset(Offset = "0x0")]
		public int X;

		// Token: 0x04002B06 RID: 11014
		[Token(Token = "0x4002B06")]
		[FieldOffset(Offset = "0x4")]
		public int Y;
	}
}
