using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200039C RID: 924
	[Token(Token = "0x200039C")]
	[Serializable]
	public struct Vector2 : FileAPI
	{
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x0000AB30 File Offset: 0x00008D30
		[Token(Token = "0x17000237")]
		public static Vector2 Zero
		{
			[Token(Token = "0x6001746")]
			[Address(RVA = "0xE185B4", Offset = "0xE185B4", VA = "0xE185B4")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x0000AB48 File Offset: 0x00008D48
		[Token(Token = "0x17000238")]
		public static Vector2 One
		{
			[Token(Token = "0x6001747")]
			[Address(RVA = "0xE18628", Offset = "0xE18628", VA = "0xE18628")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x0000AB60 File Offset: 0x00008D60
		[Token(Token = "0x17000239")]
		public static Vector2 UnitX
		{
			[Token(Token = "0x6001748")]
			[Address(RVA = "0xE1869C", Offset = "0xE1869C", VA = "0xE1869C")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x0000AB78 File Offset: 0x00008D78
		[Token(Token = "0x1700023A")]
		public static Vector2 UnitY
		{
			[Token(Token = "0x6001749")]
			[Address(RVA = "0xE18710", Offset = "0xE18710", VA = "0xE18710")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600174A")]
		[Address(RVA = "0xE18784", Offset = "0xE18784", VA = "0xE18784")]
		public Vector2(float x, float y)
		{
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600174B")]
		[Address(RVA = "0xE1878C", Offset = "0xE1878C", VA = "0xE1878C")]
		public Vector2(float value)
		{
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600174C")]
		[Address(RVA = "0xE18798", Offset = "0xE18798", VA = "0xE18798")]
		public static void Reflect(ref Vector2 vector, ref Vector2 normal, out Vector2 result)
		{
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x0000AB90 File Offset: 0x00008D90
		[Token(Token = "0x600174D")]
		[Address(RVA = "0xE18870", Offset = "0xE18870", VA = "0xE18870")]
		public static Vector2 Reflect(Vector2 vector, Vector2 normal)
		{
			return default(Vector2);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		[Token(Token = "0x600174E")]
		[Address(RVA = "0xE18954", Offset = "0xE18954", VA = "0xE18954")]
		public static Vector2 Add(Vector2 value1, Vector2 value2)
		{
			return default(Vector2);
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600174F")]
		[Address(RVA = "0xE18978", Offset = "0xE18978", VA = "0xE18978")]
		public static void Add(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
		{
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		[Token(Token = "0x6001750")]
		[Address(RVA = "0xE1899C", Offset = "0xE1899C", VA = "0xE1899C")]
		public static Vector2 Barycentric(Vector2 value1, Vector2 value2, Vector2 value3, float amount1, float amount2)
		{
			return default(Vector2);
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001751")]
		[Address(RVA = "0xE18A0C", Offset = "0xE18A0C", VA = "0xE18A0C")]
		public static void Barycentric(ref Vector2 value1, ref Vector2 value2, ref Vector2 value3, float amount1, float amount2, out Vector2 result)
		{
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		[Token(Token = "0x6001752")]
		[Address(RVA = "0xE18A80", Offset = "0xE18A80", VA = "0xE18A80")]
		public static Vector2 CatmullRom(Vector2 value1, Vector2 value2, Vector2 value3, Vector2 value4, float amount)
		{
			return default(Vector2);
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001753")]
		[Address(RVA = "0xE18AF0", Offset = "0xE18AF0", VA = "0xE18AF0")]
		public static void CatmullRom(ref Vector2 value1, ref Vector2 value2, ref Vector2 value3, ref Vector2 value4, float amount, out Vector2 result)
		{
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		[Token(Token = "0x6001754")]
		[Address(RVA = "0xE18B68", Offset = "0xE18B68", VA = "0xE18B68")]
		public static Vector2 Clamp(Vector2 value1, Vector2 min, Vector2 max)
		{
			return default(Vector2);
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001755")]
		[Address(RVA = "0xE18BAC", Offset = "0xE18BAC", VA = "0xE18BAC")]
		public static void Clamp(ref Vector2 value1, ref Vector2 min, ref Vector2 max, out Vector2 result)
		{
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x0000AC08 File Offset: 0x00008E08
		[Token(Token = "0x6001756")]
		[Address(RVA = "0xE18BF8", Offset = "0xE18BF8", VA = "0xE18BF8")]
		public static float Distance(Vector2 value1, Vector2 value2)
		{
			return 0f;
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001757")]
		[Address(RVA = "0xE18C90", Offset = "0xE18C90", VA = "0xE18C90")]
		public static void Distance(ref Vector2 value1, ref Vector2 value2, out float result)
		{
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x0000AC20 File Offset: 0x00008E20
		[Token(Token = "0x6001758")]
		[Address(RVA = "0xE18D24", Offset = "0xE18D24", VA = "0xE18D24")]
		public static float DistanceSquared(Vector2 value1, Vector2 value2)
		{
			return 0f;
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001759")]
		[Address(RVA = "0xE18D4C", Offset = "0xE18D4C", VA = "0xE18D4C")]
		public static void DistanceSquared(ref Vector2 value1, ref Vector2 value2, out float result)
		{
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x0000AC38 File Offset: 0x00008E38
		[Token(Token = "0x600175A")]
		[Address(RVA = "0xE18D74", Offset = "0xE18D74", VA = "0xE18D74")]
		public static Vector2 Divide(Vector2 value1, Vector2 value2)
		{
			return default(Vector2);
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600175B")]
		[Address(RVA = "0xE18D98", Offset = "0xE18D98", VA = "0xE18D98")]
		public static void Divide(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
		{
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x0000AC50 File Offset: 0x00008E50
		[Token(Token = "0x600175C")]
		[Address(RVA = "0xE18DBC", Offset = "0xE18DBC", VA = "0xE18DBC")]
		public static Vector2 Divide(Vector2 value1, float divider)
		{
			return default(Vector2);
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600175D")]
		[Address(RVA = "0xE18DE4", Offset = "0xE18DE4", VA = "0xE18DE4")]
		public static void Divide(ref Vector2 value1, float divider, out Vector2 result)
		{
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x0000AC68 File Offset: 0x00008E68
		[Token(Token = "0x600175E")]
		[Address(RVA = "0xE18850", Offset = "0xE18850", VA = "0xE18850")]
		public static float Dot(Vector2 value1, Vector2 value2)
		{
			return 0f;
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600175F")]
		[Address(RVA = "0xE18E0C", Offset = "0xE18E0C", VA = "0xE18E0C")]
		public static void Dot(ref Vector2 value1, ref Vector2 value2, out float result)
		{
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x0000AC80 File Offset: 0x00008E80
		[Token(Token = "0x6001760")]
		[Address(RVA = "0xE18E2C", Offset = "0xE18E2C", VA = "0xE18E2C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x0000AC98 File Offset: 0x00008E98
		[Token(Token = "0x6001761")]
		[Address(RVA = "0xE18F40", Offset = "0xE18F40", VA = "0xE18F40", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		[Token(Token = "0x6001762")]
		[Address(RVA = "0xE18FE4", Offset = "0xE18FE4", VA = "0xE18FE4", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		[Token(Token = "0x6001763")]
		[Address(RVA = "0xE19010", Offset = "0xE19010", VA = "0xE19010")]
		public static Vector2 Hermite(Vector2 value1, Vector2 tangent1, Vector2 value2, Vector2 tangent2, float amount)
		{
			return default(Vector2);
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001764")]
		[Address(RVA = "0xE19080", Offset = "0xE19080", VA = "0xE19080")]
		public static void Hermite(ref Vector2 value1, ref Vector2 tangent1, ref Vector2 value2, ref Vector2 tangent2, float amount, out Vector2 result)
		{
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x0000ACE0 File Offset: 0x00008EE0
		[Token(Token = "0x6001765")]
		[Address(RVA = "0xE190F4", Offset = "0xE190F4", VA = "0xE190F4")]
		public float Length()
		{
			return 0f;
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		[Token(Token = "0x6001766")]
		[Address(RVA = "0xE19170", Offset = "0xE19170", VA = "0xE19170")]
		public float LengthSquared()
		{
			return 0f;
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0000AD10 File Offset: 0x00008F10
		[Token(Token = "0x6001767")]
		[Address(RVA = "0xE19188", Offset = "0xE19188", VA = "0xE19188")]
		public static Vector2 Lerp(Vector2 value1, Vector2 value2, float amount)
		{
			return default(Vector2);
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001768")]
		[Address(RVA = "0xE191D0", Offset = "0xE191D0", VA = "0xE191D0")]
		public static void Lerp(ref Vector2 value1, ref Vector2 value2, float amount, out Vector2 result)
		{
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0000AD28 File Offset: 0x00008F28
		[Token(Token = "0x6001769")]
		[Address(RVA = "0xE19218", Offset = "0xE19218", VA = "0xE19218")]
		public static Vector2 Max(Vector2 value1, Vector2 value2)
		{
			return default(Vector2);
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600176A")]
		[Address(RVA = "0xE19254", Offset = "0xE19254", VA = "0xE19254")]
		public static void Max(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
		{
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x0000AD40 File Offset: 0x00008F40
		[Token(Token = "0x600176B")]
		[Address(RVA = "0xE19294", Offset = "0xE19294", VA = "0xE19294")]
		public static Vector2 Min(Vector2 value1, Vector2 value2)
		{
			return default(Vector2);
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600176C")]
		[Address(RVA = "0xE192D0", Offset = "0xE192D0", VA = "0xE192D0")]
		public static void Min(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
		{
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x0000AD58 File Offset: 0x00008F58
		[Token(Token = "0x600176D")]
		[Address(RVA = "0xE19310", Offset = "0xE19310", VA = "0xE19310")]
		public static Vector2 Multiply(Vector2 value1, Vector2 value2)
		{
			return default(Vector2);
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0000AD70 File Offset: 0x00008F70
		[Token(Token = "0x600176E")]
		[Address(RVA = "0xE19334", Offset = "0xE19334", VA = "0xE19334")]
		public static Vector2 Multiply(Vector2 value1, float scaleFactor)
		{
			return default(Vector2);
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600176F")]
		[Address(RVA = "0xE19354", Offset = "0xE19354", VA = "0xE19354")]
		public static void Multiply(ref Vector2 value1, float scaleFactor, out Vector2 result)
		{
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001770")]
		[Address(RVA = "0xE19374", Offset = "0xE19374", VA = "0xE19374")]
		public static void Multiply(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
		{
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0000AD88 File Offset: 0x00008F88
		[Token(Token = "0x6001771")]
		[Address(RVA = "0xE19398", Offset = "0xE19398", VA = "0xE19398")]
		public static Vector2 Negate(Vector2 value)
		{
			return default(Vector2);
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001772")]
		[Address(RVA = "0xE193A8", Offset = "0xE193A8", VA = "0xE193A8")]
		public static void Negate(ref Vector2 value, out Vector2 result)
		{
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001773")]
		[Address(RVA = "0xE193C4", Offset = "0xE193C4", VA = "0xE193C4")]
		public void Normalize()
		{
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		[Token(Token = "0x6001774")]
		[Address(RVA = "0xE19464", Offset = "0xE19464", VA = "0xE19464")]
		public static Vector2 Normalize(Vector2 value)
		{
			return default(Vector2);
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001775")]
		[Address(RVA = "0xE194FC", Offset = "0xE194FC", VA = "0xE194FC")]
		public static void Normalize(ref Vector2 value, out Vector2 result)
		{
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[Token(Token = "0x6001776")]
		[Address(RVA = "0xE195A0", Offset = "0xE195A0", VA = "0xE195A0")]
		public static Vector2 SmoothStep(Vector2 value1, Vector2 value2, float amount)
		{
			return default(Vector2);
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001777")]
		[Address(RVA = "0xE195E8", Offset = "0xE195E8", VA = "0xE195E8")]
		public static void SmoothStep(ref Vector2 value1, ref Vector2 value2, float amount, out Vector2 result)
		{
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		[Token(Token = "0x6001778")]
		[Address(RVA = "0xE19630", Offset = "0xE19630", VA = "0xE19630")]
		public static Vector2 Subtract(Vector2 value1, Vector2 value2)
		{
			return default(Vector2);
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001779")]
		[Address(RVA = "0xE19654", Offset = "0xE19654", VA = "0xE19654")]
		public static void Subtract(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
		{
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		[Token(Token = "0x600177A")]
		[Address(RVA = "0xE19678", Offset = "0xE19678", VA = "0xE19678")]
		public static Vector2 Transform(Vector2 position, Matrix matrix)
		{
			return default(Vector2);
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177B")]
		[Address(RVA = "0xE19740", Offset = "0xE19740", VA = "0xE19740")]
		public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector2 result)
		{
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x0000AE00 File Offset: 0x00009000
		[Token(Token = "0x600177C")]
		[Address(RVA = "0xE19784", Offset = "0xE19784", VA = "0xE19784")]
		public static Vector2 Transform(Vector2 value, Quaternion rotation)
		{
			return default(Vector2);
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177D")]
		[Address(RVA = "0xE197D0", Offset = "0xE197D0", VA = "0xE197D0")]
		public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector2 result)
		{
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177E")]
		[Address(RVA = "0xE1981C", Offset = "0xE1981C", VA = "0xE1981C")]
		public static void Transform(Vector2[] sourceArray, ref Matrix matrix, Vector2[] destinationArray)
		{
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177F")]
		[Address(RVA = "0xE19868", Offset = "0xE19868", VA = "0xE19868")]
		public static void Transform(Vector2[] sourceArray, ref Quaternion rotation, Vector2[] destinationArray)
		{
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001780")]
		[Address(RVA = "0xE198B4", Offset = "0xE198B4", VA = "0xE198B4")]
		public static void Transform(Vector2[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2[] destinationArray, int destinationIndex, int length)
		{
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001781")]
		[Address(RVA = "0xE19900", Offset = "0xE19900", VA = "0xE19900")]
		public static void Transform(Vector2[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector2[] destinationArray, int destinationIndex, int length)
		{
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x0000AE18 File Offset: 0x00009018
		[Token(Token = "0x6001782")]
		[Address(RVA = "0xE1994C", Offset = "0xE1994C", VA = "0xE1994C")]
		public static Vector2 TransformNormal(Vector2 normal, Matrix matrix)
		{
			return default(Vector2);
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001783")]
		[Address(RVA = "0xE199F8", Offset = "0xE199F8", VA = "0xE199F8")]
		public static void TransformNormal(ref Vector2 normal, ref Matrix matrix, out Vector2 result)
		{
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001784")]
		[Address(RVA = "0xE19A2C", Offset = "0xE19A2C", VA = "0xE19A2C")]
		public static void TransformNormal(Vector2[] sourceArray, ref Matrix matrix, Vector2[] destinationArray)
		{
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001785")]
		[Address(RVA = "0xE19A78", Offset = "0xE19A78", VA = "0xE19A78")]
		public static void TransformNormal(Vector2[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2[] destinationArray, int destinationIndex, int length)
		{
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001786")]
		[Address(RVA = "0xE19AC4", Offset = "0xE19AC4", VA = "0xE19AC4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x0000AE30 File Offset: 0x00009030
		[Token(Token = "0x6001787")]
		[Address(RVA = "0xE19C7C", Offset = "0xE19C7C", VA = "0xE19C7C")]
		public static Vector2 operator -(Vector2 value)
		{
			return default(Vector2);
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x0000AE48 File Offset: 0x00009048
		[Token(Token = "0x6001788")]
		[Address(RVA = "0xE18F0C", Offset = "0xE18F0C", VA = "0xE18F0C")]
		public static bool operator ==(Vector2 value1, Vector2 value2)
		{
			return default(bool);
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x0000AE60 File Offset: 0x00009060
		[Token(Token = "0x6001789")]
		[Address(RVA = "0xE19C8C", Offset = "0xE19C8C", VA = "0xE19C8C")]
		public static bool operator !=(Vector2 value1, Vector2 value2)
		{
			return default(bool);
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x0000AE78 File Offset: 0x00009078
		[Token(Token = "0x600178A")]
		[Address(RVA = "0xE19CC0", Offset = "0xE19CC0", VA = "0xE19CC0")]
		public static Vector2 operator +(Vector2 value1, Vector2 value2)
		{
			return default(Vector2);
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0000AE90 File Offset: 0x00009090
		[Token(Token = "0x600178B")]
		[Address(RVA = "0xE19CE4", Offset = "0xE19CE4", VA = "0xE19CE4")]
		public static Vector2 operator -(Vector2 value1, Vector2 value2)
		{
			return default(Vector2);
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0000AEA8 File Offset: 0x000090A8
		[Token(Token = "0x600178C")]
		[Address(RVA = "0xE19D08", Offset = "0xE19D08", VA = "0xE19D08")]
		public static Vector2 operator *(Vector2 value1, Vector2 value2)
		{
			return default(Vector2);
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x0000AEC0 File Offset: 0x000090C0
		[Token(Token = "0x600178D")]
		[Address(RVA = "0xE19D2C", Offset = "0xE19D2C", VA = "0xE19D2C")]
		public static Vector2 operator *(Vector2 value, float scaleFactor)
		{
			return default(Vector2);
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x0000AED8 File Offset: 0x000090D8
		[Token(Token = "0x600178E")]
		[Address(RVA = "0xE19D4C", Offset = "0xE19D4C", VA = "0xE19D4C")]
		public static Vector2 operator *(float scaleFactor, Vector2 value)
		{
			return default(Vector2);
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0000AEF0 File Offset: 0x000090F0
		[Token(Token = "0x600178F")]
		[Address(RVA = "0xE19D6C", Offset = "0xE19D6C", VA = "0xE19D6C")]
		public static Vector2 operator /(Vector2 value1, Vector2 value2)
		{
			return default(Vector2);
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x0000AF08 File Offset: 0x00009108
		[Token(Token = "0x6001790")]
		[Address(RVA = "0xE19D90", Offset = "0xE19D90", VA = "0xE19D90")]
		public static Vector2 operator /(Vector2 value1, float divider)
		{
			return default(Vector2);
		}

		// Token: 0x04002B11 RID: 11025
		[Token(Token = "0x4002B11")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 zeroVector;

		// Token: 0x04002B12 RID: 11026
		[Token(Token = "0x4002B12")]
		[FieldOffset(Offset = "0x8")]
		private static Vector2 unitVector;

		// Token: 0x04002B13 RID: 11027
		[Token(Token = "0x4002B13")]
		[FieldOffset(Offset = "0x10")]
		private static Vector2 unitXVector;

		// Token: 0x04002B14 RID: 11028
		[Token(Token = "0x4002B14")]
		[FieldOffset(Offset = "0x18")]
		private static Vector2 unitYVector;

		// Token: 0x04002B15 RID: 11029
		[Token(Token = "0x4002B15")]
		[FieldOffset(Offset = "0x0")]
		public float X;

		// Token: 0x04002B16 RID: 11030
		[Token(Token = "0x4002B16")]
		[FieldOffset(Offset = "0x4")]
		public float Y;
	}
}
