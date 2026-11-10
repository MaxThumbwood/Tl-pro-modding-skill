using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000397 RID: 919
	[Token(Token = "0x2000397")]
	[Serializable]
	public struct Plane : FileAPI
	{
		// Token: 0x060016D0 RID: 5840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D0")]
		[Address(RVA = "0xE14430", Offset = "0xE14430", VA = "0xE14430")]
		public Plane(Vector4 value)
		{
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D1")]
		[Address(RVA = "0xE14448", Offset = "0xE14448", VA = "0xE14448")]
		public Plane(Vector3 normal, float d)
		{
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D2")]
		[Address(RVA = "0xE14458", Offset = "0xE14458", VA = "0xE14458")]
		public Plane(Vector3 a, Vector3 b, Vector3 c)
		{
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D3")]
		[Address(RVA = "0xE14724", Offset = "0xE14724", VA = "0xE14724")]
		public Plane(float a, float b, float c, float d)
		{
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x0000A500 File Offset: 0x00008700
		[Token(Token = "0x60016D4")]
		[Address(RVA = "0xE14734", Offset = "0xE14734", VA = "0xE14734")]
		public float Dot(Vector4 value)
		{
			return 0f;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D5")]
		[Address(RVA = "0xE1476C", Offset = "0xE1476C", VA = "0xE1476C")]
		public void Dot(ref Vector4 value, out float result)
		{
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x0000A518 File Offset: 0x00008718
		[Token(Token = "0x60016D6")]
		[Address(RVA = "0xE147A4", Offset = "0xE147A4", VA = "0xE147A4")]
		public float DotCoordinate(Vector3 value)
		{
			return 0f;
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D7")]
		[Address(RVA = "0xE147D8", Offset = "0xE147D8", VA = "0xE147D8")]
		public void DotCoordinate(ref Vector3 value, out float result)
		{
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x0000A530 File Offset: 0x00008730
		[Token(Token = "0x60016D8")]
		[Address(RVA = "0xE1480C", Offset = "0xE1480C", VA = "0xE1480C")]
		public float DotNormal(Vector3 value)
		{
			return 0f;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D9")]
		[Address(RVA = "0xE14838", Offset = "0xE14838", VA = "0xE14838")]
		public void DotNormal(ref Vector3 value, out float result)
		{
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016DA")]
		[Address(RVA = "0xE14864", Offset = "0xE14864", VA = "0xE14864")]
		public static void Transform(ref Plane plane, ref Quaternion rotation, out Plane result)
		{
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016DB")]
		[Address(RVA = "0xE148B0", Offset = "0xE148B0", VA = "0xE148B0")]
		public static void Transform(ref Plane plane, ref Matrix matrix, out Plane result)
		{
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x0000A548 File Offset: 0x00008748
		[Token(Token = "0x60016DC")]
		[Address(RVA = "0xE148FC", Offset = "0xE148FC", VA = "0xE148FC")]
		public static Plane Transform(Plane plane, Quaternion rotation)
		{
			return default(Plane);
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x0000A560 File Offset: 0x00008760
		[Token(Token = "0x60016DD")]
		[Address(RVA = "0xE14948", Offset = "0xE14948", VA = "0xE14948")]
		public static Plane Transform(Plane plane, Matrix matrix)
		{
			return default(Plane);
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016DE")]
		[Address(RVA = "0xE14994", Offset = "0xE14994", VA = "0xE14994")]
		public void Normalize()
		{
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x0000A578 File Offset: 0x00008778
		[Token(Token = "0x60016DF")]
		[Address(RVA = "0xE14AC8", Offset = "0xE14AC8", VA = "0xE14AC8")]
		public static Plane Normalize(Plane value)
		{
			return default(Plane);
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E0")]
		[Address(RVA = "0xE14B0C", Offset = "0xE14B0C", VA = "0xE14B0C")]
		public static void Normalize(ref Plane value, out Plane result)
		{
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x0000A590 File Offset: 0x00008790
		[Token(Token = "0x60016E1")]
		[Address(RVA = "0xE14C60", Offset = "0xE14C60", VA = "0xE14C60")]
		public static bool operator !=(Plane plane1, Plane plane2)
		{
			return default(bool);
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x0000A5A8 File Offset: 0x000087A8
		[Token(Token = "0x60016E2")]
		[Address(RVA = "0xE14E0C", Offset = "0xE14E0C", VA = "0xE14E0C")]
		public static bool operator ==(Plane plane1, Plane plane2)
		{
			return default(bool);
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x0000A5C0 File Offset: 0x000087C0
		[Token(Token = "0x60016E3")]
		[Address(RVA = "0xE14EE8", Offset = "0xE14EE8", VA = "0xE14EE8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x0000A5D8 File Offset: 0x000087D8
		[Token(Token = "0x60016E4")]
		[Address(RVA = "0xE14D3C", Offset = "0xE14D3C", VA = "0xE14D3C", Slot = "4")]
		public bool Equals(Plane other)
		{
			return default(bool);
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x0000A5F0 File Offset: 0x000087F0
		[Token(Token = "0x60016E5")]
		[Address(RVA = "0xE15054", Offset = "0xE15054", VA = "0xE15054", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E6")]
		[Address(RVA = "0xE15124", Offset = "0xE15124", VA = "0xE15124", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04002B02 RID: 11010
		[Token(Token = "0x4002B02")]
		[FieldOffset(Offset = "0x0")]
		public float D;

		// Token: 0x04002B03 RID: 11011
		[Token(Token = "0x4002B03")]
		[FieldOffset(Offset = "0x4")]
		public Vector3 Normal;
	}
}
