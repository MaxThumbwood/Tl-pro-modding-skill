using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace ReLogic.Utilities
{
	// Token: 0x02000DD9 RID: 3545
	[Token(Token = "0x2000DD9")]
	[Serializable]
	public struct Vector2D : FileAPI
	{
		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x0600680D RID: 26637 RVA: 0x0002F298 File Offset: 0x0002D498
		[Token(Token = "0x17000B17")]
		public static Vector2D Zero
		{
			[Token(Token = "0x600680D")]
			[Address(RVA = "0xB7B3B4", Offset = "0xB7B3B4", VA = "0xB7B3B4")]
			get
			{
				return default(Vector2D);
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x0600680E RID: 26638 RVA: 0x0002F2B0 File Offset: 0x0002D4B0
		[Token(Token = "0x17000B18")]
		public static Vector2D One
		{
			[Token(Token = "0x600680E")]
			[Address(RVA = "0xB7B420", Offset = "0xB7B420", VA = "0xB7B420")]
			get
			{
				return default(Vector2D);
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x0600680F RID: 26639 RVA: 0x0002F2C8 File Offset: 0x0002D4C8
		[Token(Token = "0x17000B19")]
		public static Vector2D UnitX
		{
			[Token(Token = "0x600680F")]
			[Address(RVA = "0xB7B490", Offset = "0xB7B490", VA = "0xB7B490")]
			get
			{
				return default(Vector2D);
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06006810 RID: 26640 RVA: 0x0002F2E0 File Offset: 0x0002D4E0
		[Token(Token = "0x17000B1A")]
		public static Vector2D UnitY
		{
			[Token(Token = "0x6006810")]
			[Address(RVA = "0xB7B500", Offset = "0xB7B500", VA = "0xB7B500")]
			get
			{
				return default(Vector2D);
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06006811 RID: 26641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B1B")]
		internal string DebugDisplayString
		{
			[Token(Token = "0x6006811")]
			[Address(RVA = "0xB7B570", Offset = "0xB7B570", VA = "0xB7B570")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006812 RID: 26642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006812")]
		[Address(RVA = "0xB7B5E8", Offset = "0xB7B5E8", VA = "0xB7B5E8")]
		public Vector2D(double x, double y)
		{
		}

		// Token: 0x06006813 RID: 26643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006813")]
		[Address(RVA = "0xB7B600", Offset = "0xB7B600", VA = "0xB7B600")]
		public Vector2D(double value)
		{
		}

		// Token: 0x06006814 RID: 26644 RVA: 0x0002F2F8 File Offset: 0x0002D4F8
		[Token(Token = "0x6006814")]
		[Address(RVA = "0xB7B610", Offset = "0xB7B610", VA = "0xB7B610", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06006815 RID: 26645 RVA: 0x0002F310 File Offset: 0x0002D510
		[Token(Token = "0x6006815")]
		[Address(RVA = "0xB7B6E8", Offset = "0xB7B6E8", VA = "0xB7B6E8", Slot = "4")]
		public bool Equals(Vector2D other)
		{
			return default(bool);
		}

		// Token: 0x06006816 RID: 26646 RVA: 0x0002F328 File Offset: 0x0002D528
		[Token(Token = "0x6006816")]
		[Address(RVA = "0xB7B724", Offset = "0xB7B724", VA = "0xB7B724", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006817 RID: 26647 RVA: 0x0002F340 File Offset: 0x0002D540
		[Token(Token = "0x6006817")]
		[Address(RVA = "0xB7B810", Offset = "0xB7B810", VA = "0xB7B810")]
		public double Length()
		{
			return 0.0;
		}

		// Token: 0x06006818 RID: 26648 RVA: 0x0002F358 File Offset: 0x0002D558
		[Token(Token = "0x6006818")]
		[Address(RVA = "0xB7B888", Offset = "0xB7B888", VA = "0xB7B888")]
		public double LengthSquared()
		{
			return 0.0;
		}

		// Token: 0x06006819 RID: 26649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006819")]
		[Address(RVA = "0xB7B89C", Offset = "0xB7B89C", VA = "0xB7B89C")]
		public void Normalize()
		{
		}

		// Token: 0x0600681A RID: 26650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600681A")]
		[Address(RVA = "0xB7B930", Offset = "0xB7B930", VA = "0xB7B930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600681B RID: 26651 RVA: 0x0002F370 File Offset: 0x0002D570
		[Token(Token = "0x600681B")]
		[Address(RVA = "0xB7BB58", Offset = "0xB7BB58", VA = "0xB7BB58")]
		public static Vector2D Add(Vector2D value1, Vector2D value2)
		{
			return default(Vector2D);
		}

		// Token: 0x0600681C RID: 26652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600681C")]
		[Address(RVA = "0xB7BB98", Offset = "0xB7BB98", VA = "0xB7BB98")]
		public static void Add(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
		}

		// Token: 0x0600681D RID: 26653 RVA: 0x0002F388 File Offset: 0x0002D588
		[Token(Token = "0x600681D")]
		[Address(RVA = "0xB7BBBC", Offset = "0xB7BBBC", VA = "0xB7BBBC")]
		public static Vector2D Barycentric(Vector2D value1, Vector2D value2, Vector2D value3, double amount1, double amount2)
		{
			return default(Vector2D);
		}

		// Token: 0x0600681E RID: 26654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600681E")]
		[Address(RVA = "0xB7BCF8", Offset = "0xB7BCF8", VA = "0xB7BCF8")]
		public static void Barycentric(ref Vector2D value1, ref Vector2D value2, ref Vector2D value3, double amount1, double amount2, out Vector2D result)
		{
		}

		// Token: 0x0600681F RID: 26655 RVA: 0x0002F3A0 File Offset: 0x0002D5A0
		[Token(Token = "0x600681F")]
		[Address(RVA = "0xB7BDB4", Offset = "0xB7BDB4", VA = "0xB7BDB4")]
		public static Vector2D CatmullRom(Vector2D value1, Vector2D value2, Vector2D value3, Vector2D value4, double amount)
		{
			return default(Vector2D);
		}

		// Token: 0x06006820 RID: 26656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006820")]
		[Address(RVA = "0xB7BF9C", Offset = "0xB7BF9C", VA = "0xB7BF9C")]
		public static void CatmullRom(ref Vector2D value1, ref Vector2D value2, ref Vector2D value3, ref Vector2D value4, double amount, out Vector2D result)
		{
		}

		// Token: 0x06006821 RID: 26657 RVA: 0x0002F3B8 File Offset: 0x0002D5B8
		[Token(Token = "0x6006821")]
		[Address(RVA = "0xB7C0BC", Offset = "0xB7C0BC", VA = "0xB7C0BC")]
		public static Vector2D Clamp(Vector2D value1, Vector2D min, Vector2D max)
		{
			return default(Vector2D);
		}

		// Token: 0x06006822 RID: 26658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006822")]
		[Address(RVA = "0xB7C1FC", Offset = "0xB7C1FC", VA = "0xB7C1FC")]
		public static void Clamp(ref Vector2D value1, ref Vector2D min, ref Vector2D max, out Vector2D result)
		{
		}

		// Token: 0x06006823 RID: 26659 RVA: 0x0002F3D0 File Offset: 0x0002D5D0
		[Token(Token = "0x6006823")]
		[Address(RVA = "0xB7C2BC", Offset = "0xB7C2BC", VA = "0xB7C2BC")]
		public static double Distance(Vector2D value1, Vector2D value2)
		{
			return 0.0;
		}

		// Token: 0x06006824 RID: 26660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006824")]
		[Address(RVA = "0xB7C36C", Offset = "0xB7C36C", VA = "0xB7C36C")]
		public static void Distance(ref Vector2D value1, ref Vector2D value2, out double result)
		{
		}

		// Token: 0x06006825 RID: 26661 RVA: 0x0002F3E8 File Offset: 0x0002D5E8
		[Token(Token = "0x6006825")]
		[Address(RVA = "0xB7C3F8", Offset = "0xB7C3F8", VA = "0xB7C3F8")]
		public static double DistanceSquared(Vector2D value1, Vector2D value2)
		{
			return 0.0;
		}

		// Token: 0x06006826 RID: 26662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006826")]
		[Address(RVA = "0xB7C434", Offset = "0xB7C434", VA = "0xB7C434")]
		public static void DistanceSquared(ref Vector2D value1, ref Vector2D value2, out double result)
		{
		}

		// Token: 0x06006827 RID: 26663 RVA: 0x0002F400 File Offset: 0x0002D600
		[Token(Token = "0x6006827")]
		[Address(RVA = "0xB7C454", Offset = "0xB7C454", VA = "0xB7C454")]
		public static Vector2D Divide(Vector2D value1, Vector2D value2)
		{
			return default(Vector2D);
		}

		// Token: 0x06006828 RID: 26664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006828")]
		[Address(RVA = "0xB7C494", Offset = "0xB7C494", VA = "0xB7C494")]
		public static void Divide(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
		}

		// Token: 0x06006829 RID: 26665 RVA: 0x0002F418 File Offset: 0x0002D618
		[Token(Token = "0x6006829")]
		[Address(RVA = "0xB7C4B8", Offset = "0xB7C4B8", VA = "0xB7C4B8")]
		public static Vector2D Divide(Vector2D value1, double divider)
		{
			return default(Vector2D);
		}

		// Token: 0x0600682A RID: 26666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600682A")]
		[Address(RVA = "0xB7C4E0", Offset = "0xB7C4E0", VA = "0xB7C4E0")]
		public static void Divide(ref Vector2D value1, double divider, out Vector2D result)
		{
		}

		// Token: 0x0600682B RID: 26667 RVA: 0x0002F430 File Offset: 0x0002D630
		[Token(Token = "0x600682B")]
		[Address(RVA = "0xB7C50C", Offset = "0xB7C50C", VA = "0xB7C50C")]
		public static double Dot(Vector2D value1, Vector2D value2)
		{
			return 0.0;
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600682C")]
		[Address(RVA = "0xB7C540", Offset = "0xB7C540", VA = "0xB7C540")]
		public static void Dot(ref Vector2D value1, ref Vector2D value2, out double result)
		{
		}

		// Token: 0x0600682D RID: 26669 RVA: 0x0002F448 File Offset: 0x0002D648
		[Token(Token = "0x600682D")]
		[Address(RVA = "0xB7C558", Offset = "0xB7C558", VA = "0xB7C558")]
		public static double Cross(Vector2D value1, Vector2D value2)
		{
			return 0.0;
		}

		// Token: 0x0600682E RID: 26670 RVA: 0x0002F460 File Offset: 0x0002D660
		[Token(Token = "0x600682E")]
		[Address(RVA = "0xB7C58C", Offset = "0xB7C58C", VA = "0xB7C58C")]
		public static Vector2D Hermite(Vector2D value1, Vector2D tangent1, Vector2D value2, Vector2D tangent2, double amount)
		{
			return default(Vector2D);
		}

		// Token: 0x0600682F RID: 26671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600682F")]
		[Address(RVA = "0xB7C6FC", Offset = "0xB7C6FC", VA = "0xB7C6FC")]
		public static void Hermite(ref Vector2D value1, ref Vector2D tangent1, ref Vector2D value2, ref Vector2D tangent2, double amount, out Vector2D result)
		{
		}

		// Token: 0x06006830 RID: 26672 RVA: 0x0002F478 File Offset: 0x0002D678
		[Token(Token = "0x6006830")]
		[Address(RVA = "0xB7C900", Offset = "0xB7C900", VA = "0xB7C900")]
		public static Vector2D Lerp(Vector2D value1, Vector2D value2, double amount)
		{
			return default(Vector2D);
		}

		// Token: 0x06006831 RID: 26673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006831")]
		[Address(RVA = "0xB7C9DC", Offset = "0xB7C9DC", VA = "0xB7C9DC")]
		public static void Lerp(ref Vector2D value1, ref Vector2D value2, double amount, out Vector2D result)
		{
		}

		// Token: 0x06006832 RID: 26674 RVA: 0x0002F490 File Offset: 0x0002D690
		[Token(Token = "0x6006832")]
		[Address(RVA = "0xB7CA7C", Offset = "0xB7CA7C", VA = "0xB7CA7C")]
		public static Vector2D Max(Vector2D value1, Vector2D value2)
		{
			return default(Vector2D);
		}

		// Token: 0x06006833 RID: 26675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006833")]
		[Address(RVA = "0xB7CAC8", Offset = "0xB7CAC8", VA = "0xB7CAC8")]
		public static void Max(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
		}

		// Token: 0x06006834 RID: 26676 RVA: 0x0002F4A8 File Offset: 0x0002D6A8
		[Token(Token = "0x6006834")]
		[Address(RVA = "0xB7CAFC", Offset = "0xB7CAFC", VA = "0xB7CAFC")]
		public static Vector2D Min(Vector2D value1, Vector2D value2)
		{
			return default(Vector2D);
		}

		// Token: 0x06006835 RID: 26677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006835")]
		[Address(RVA = "0xB7CB48", Offset = "0xB7CB48", VA = "0xB7CB48")]
		public static void Min(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
		}

		// Token: 0x06006836 RID: 26678 RVA: 0x0002F4C0 File Offset: 0x0002D6C0
		[Token(Token = "0x6006836")]
		[Address(RVA = "0xB7CB7C", Offset = "0xB7CB7C", VA = "0xB7CB7C")]
		public static Vector2D Multiply(Vector2D value1, Vector2D value2)
		{
			return default(Vector2D);
		}

		// Token: 0x06006837 RID: 26679 RVA: 0x0002F4D8 File Offset: 0x0002D6D8
		[Token(Token = "0x6006837")]
		[Address(RVA = "0xB7CBBC", Offset = "0xB7CBBC", VA = "0xB7CBBC")]
		public static Vector2D Multiply(Vector2D value1, double scaleFactor)
		{
			return default(Vector2D);
		}

		// Token: 0x06006838 RID: 26680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006838")]
		[Address(RVA = "0xB7CBE0", Offset = "0xB7CBE0", VA = "0xB7CBE0")]
		public static void Multiply(ref Vector2D value1, double scaleFactor, out Vector2D result)
		{
		}

		// Token: 0x06006839 RID: 26681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006839")]
		[Address(RVA = "0xB7CC04", Offset = "0xB7CC04", VA = "0xB7CC04")]
		public static void Multiply(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
		}

		// Token: 0x0600683A RID: 26682 RVA: 0x0002F4F0 File Offset: 0x0002D6F0
		[Token(Token = "0x600683A")]
		[Address(RVA = "0xB7CC28", Offset = "0xB7CC28", VA = "0xB7CC28")]
		public static Vector2D Negate(Vector2D value)
		{
			return default(Vector2D);
		}

		// Token: 0x0600683B RID: 26683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600683B")]
		[Address(RVA = "0xB7CC44", Offset = "0xB7CC44", VA = "0xB7CC44")]
		public static void Negate(ref Vector2D value, out Vector2D result)
		{
		}

		// Token: 0x0600683C RID: 26684 RVA: 0x0002F508 File Offset: 0x0002D708
		[Token(Token = "0x600683C")]
		[Address(RVA = "0xB7CC60", Offset = "0xB7CC60", VA = "0xB7CC60")]
		public static Vector2D Normalize(Vector2D value)
		{
			return default(Vector2D);
		}

		// Token: 0x0600683D RID: 26685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600683D")]
		[Address(RVA = "0xB7CCFC", Offset = "0xB7CCFC", VA = "0xB7CCFC")]
		public static void Normalize(ref Vector2D value, out Vector2D result)
		{
		}

		// Token: 0x0600683E RID: 26686 RVA: 0x0002F520 File Offset: 0x0002D720
		[Token(Token = "0x600683E")]
		[Address(RVA = "0xB7CD94", Offset = "0xB7CD94", VA = "0xB7CD94")]
		public static Vector2D Reflect(Vector2D vector, Vector2D normal)
		{
			return default(Vector2D);
		}

		// Token: 0x0600683F RID: 26687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600683F")]
		[Address(RVA = "0xB7CDE0", Offset = "0xB7CDE0", VA = "0xB7CDE0")]
		public static void Reflect(ref Vector2D vector, ref Vector2D normal, out Vector2D result)
		{
		}

		// Token: 0x06006840 RID: 26688 RVA: 0x0002F538 File Offset: 0x0002D738
		[Token(Token = "0x6006840")]
		[Address(RVA = "0xB7CE04", Offset = "0xB7CE04", VA = "0xB7CE04")]
		public static Vector2D SmoothStep(Vector2D value1, Vector2D value2, double amount)
		{
			return default(Vector2D);
		}

		// Token: 0x06006841 RID: 26689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006841")]
		[Address(RVA = "0xB7D05C", Offset = "0xB7D05C", VA = "0xB7D05C")]
		public static void SmoothStep(ref Vector2D value1, ref Vector2D value2, double amount, out Vector2D result)
		{
		}

		// Token: 0x06006842 RID: 26690 RVA: 0x0002F550 File Offset: 0x0002D750
		[Token(Token = "0x6006842")]
		[Address(RVA = "0xB7D1DC", Offset = "0xB7D1DC", VA = "0xB7D1DC")]
		public static Vector2D Subtract(Vector2D value1, Vector2D value2)
		{
			return default(Vector2D);
		}

		// Token: 0x06006843 RID: 26691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006843")]
		[Address(RVA = "0xB7D21C", Offset = "0xB7D21C", VA = "0xB7D21C")]
		public static void Subtract(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
		}

		// Token: 0x06006844 RID: 26692 RVA: 0x0002F568 File Offset: 0x0002D768
		[Token(Token = "0x6006844")]
		[Address(RVA = "0xB7D240", Offset = "0xB7D240", VA = "0xB7D240")]
		public static Vector2D operator -(Vector2D value)
		{
			return default(Vector2D);
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x0002F580 File Offset: 0x0002D780
		[Token(Token = "0x6006845")]
		[Address(RVA = "0xB7D25C", Offset = "0xB7D25C", VA = "0xB7D25C")]
		public static bool operator ==(Vector2D value1, Vector2D value2)
		{
			return default(bool);
		}

		// Token: 0x06006846 RID: 26694 RVA: 0x0002F598 File Offset: 0x0002D798
		[Token(Token = "0x6006846")]
		[Address(RVA = "0xB7D2A8", Offset = "0xB7D2A8", VA = "0xB7D2A8")]
		public static bool operator !=(Vector2D value1, Vector2D value2)
		{
			return default(bool);
		}

		// Token: 0x06006847 RID: 26695 RVA: 0x0002F5B0 File Offset: 0x0002D7B0
		[Token(Token = "0x6006847")]
		[Address(RVA = "0xB7D354", Offset = "0xB7D354", VA = "0xB7D354")]
		public static Vector2D operator +(Vector2D value1, Vector2D value2)
		{
			return default(Vector2D);
		}

		// Token: 0x06006848 RID: 26696 RVA: 0x0002F5C8 File Offset: 0x0002D7C8
		[Token(Token = "0x6006848")]
		[Address(RVA = "0xB7D394", Offset = "0xB7D394", VA = "0xB7D394")]
		public static Vector2D operator -(Vector2D value1, Vector2D value2)
		{
			return default(Vector2D);
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x0002F5E0 File Offset: 0x0002D7E0
		[Token(Token = "0x6006849")]
		[Address(RVA = "0xB7D3D4", Offset = "0xB7D3D4", VA = "0xB7D3D4")]
		public static Vector2D operator *(Vector2D value1, Vector2D value2)
		{
			return default(Vector2D);
		}

		// Token: 0x0600684A RID: 26698 RVA: 0x0002F5F8 File Offset: 0x0002D7F8
		[Token(Token = "0x600684A")]
		[Address(RVA = "0xB7D414", Offset = "0xB7D414", VA = "0xB7D414")]
		public static Vector2D operator *(Vector2D value, double scaleFactor)
		{
			return default(Vector2D);
		}

		// Token: 0x0600684B RID: 26699 RVA: 0x0002F610 File Offset: 0x0002D810
		[Token(Token = "0x600684B")]
		[Address(RVA = "0xB7D438", Offset = "0xB7D438", VA = "0xB7D438")]
		public static Vector2D operator *(double scaleFactor, Vector2D value)
		{
			return default(Vector2D);
		}

		// Token: 0x0600684C RID: 26700 RVA: 0x0002F628 File Offset: 0x0002D828
		[Token(Token = "0x600684C")]
		[Address(RVA = "0xB7D468", Offset = "0xB7D468", VA = "0xB7D468")]
		public static Vector2D operator /(Vector2D value1, Vector2D value2)
		{
			return default(Vector2D);
		}

		// Token: 0x0600684D RID: 26701 RVA: 0x0002F640 File Offset: 0x0002D840
		[Token(Token = "0x600684D")]
		[Address(RVA = "0xB7D4A8", Offset = "0xB7D4A8", VA = "0xB7D4A8")]
		public static Vector2D operator /(Vector2D value1, double divider)
		{
			return default(Vector2D);
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x0002F658 File Offset: 0x0002D858
		[Token(Token = "0x600684E")]
		[Address(RVA = "0xB7D4D0", Offset = "0xB7D4D0", VA = "0xB7D4D0")]
		public static implicit operator Vector2D(Point point)
		{
			return default(Vector2D);
		}

		// Token: 0x0600684F RID: 26703 RVA: 0x0002F670 File Offset: 0x0002D870
		[Token(Token = "0x600684F")]
		[Address(RVA = "0xB7C1D0", Offset = "0xB7C1D0", VA = "0xB7C1D0")]
		public static double Clamp(double value, double min, double max)
		{
			return 0.0;
		}

		// Token: 0x06006850 RID: 26704 RVA: 0x0002F688 File Offset: 0x0002D888
		[Token(Token = "0x6006850")]
		[Address(RVA = "0xB7C9C0", Offset = "0xB7C9C0", VA = "0xB7C9C0")]
		public static double Lerp(double value1, double value2, double amount)
		{
			return 0.0;
		}

		// Token: 0x06006851 RID: 26705 RVA: 0x0002F6A0 File Offset: 0x0002D8A0
		[Token(Token = "0x6006851")]
		[Address(RVA = "0xB7CF98", Offset = "0xB7CF98", VA = "0xB7CF98")]
		public static double SmoothStep(double value1, double value2, double amount)
		{
			return 0.0;
		}

		// Token: 0x06006852 RID: 26706 RVA: 0x0002F6B8 File Offset: 0x0002D8B8
		[Token(Token = "0x6006852")]
		[Address(RVA = "0xB7C7D0", Offset = "0xB7C7D0", VA = "0xB7C7D0")]
		public static double Hermite(double value1, double tangent1, double value2, double tangent2, double amount)
		{
			return 0.0;
		}

		// Token: 0x06006853 RID: 26707 RVA: 0x0002F6D0 File Offset: 0x0002D8D0
		[Token(Token = "0x6006853")]
		[Address(RVA = "0xB7BCC8", Offset = "0xB7BCC8", VA = "0xB7BCC8")]
		public static double Barycentric(double value1, double value2, double value3, double amount1, double amount2)
		{
			return 0.0;
		}

		// Token: 0x06006854 RID: 26708 RVA: 0x0002F6E8 File Offset: 0x0002D8E8
		[Token(Token = "0x6006854")]
		[Address(RVA = "0xB7BF34", Offset = "0xB7BF34", VA = "0xB7BF34")]
		public static double CatmullRom(double value1, double value2, double value3, double value4, double amount)
		{
			return 0.0;
		}

		// Token: 0x0400A4CA RID: 42186
		[Token(Token = "0x400A4CA")]
		[FieldOffset(Offset = "0x0")]
		public double X;

		// Token: 0x0400A4CB RID: 42187
		[Token(Token = "0x400A4CB")]
		[FieldOffset(Offset = "0x8")]
		public double Y;

		// Token: 0x0400A4CC RID: 42188
		[Token(Token = "0x400A4CC")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2D zeroVector;

		// Token: 0x0400A4CD RID: 42189
		[Token(Token = "0x400A4CD")]
		[FieldOffset(Offset = "0x10")]
		private static Vector2D unitVector;

		// Token: 0x0400A4CE RID: 42190
		[Token(Token = "0x400A4CE")]
		[FieldOffset(Offset = "0x20")]
		private static Vector2D unitXVector;

		// Token: 0x0400A4CF RID: 42191
		[Token(Token = "0x400A4CF")]
		[FieldOffset(Offset = "0x30")]
		private static Vector2D unitYVector;

		// Token: 0x0400A4D0 RID: 42192
		[Token(Token = "0x400A4D0")]
		[FieldOffset(Offset = "0x40")]
		public static readonly double DoubleEpsilon;
	}
}
