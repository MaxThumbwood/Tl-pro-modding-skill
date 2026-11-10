using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200039E RID: 926
	[Token(Token = "0x200039E")]
	[Serializable]
	public struct Vector4 : FileAPI
	{
		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x0000B3E8 File Offset: 0x000095E8
		[Token(Token = "0x17000246")]
		public static Vector4 Zero
		{
			[Token(Token = "0x60017E9")]
			[Address(RVA = "0xE1BF74", Offset = "0xE1BF74", VA = "0xE1BF74")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x0000B400 File Offset: 0x00009600
		[Token(Token = "0x17000247")]
		public static Vector4 One
		{
			[Token(Token = "0x60017EA")]
			[Address(RVA = "0xE1BFE0", Offset = "0xE1BFE0", VA = "0xE1BFE0")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x0000B418 File Offset: 0x00009618
		[Token(Token = "0x17000248")]
		public static Vector4 UnitX
		{
			[Token(Token = "0x60017EB")]
			[Address(RVA = "0xE1C050", Offset = "0xE1C050", VA = "0xE1C050")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x0000B430 File Offset: 0x00009630
		[Token(Token = "0x17000249")]
		public static Vector4 UnitY
		{
			[Token(Token = "0x60017EC")]
			[Address(RVA = "0xE1C0C0", Offset = "0xE1C0C0", VA = "0xE1C0C0")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x0000B448 File Offset: 0x00009648
		[Token(Token = "0x1700024A")]
		public static Vector4 UnitZ
		{
			[Token(Token = "0x60017ED")]
			[Address(RVA = "0xE1C130", Offset = "0xE1C130", VA = "0xE1C130")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x0000B460 File Offset: 0x00009660
		[Token(Token = "0x1700024B")]
		public static Vector4 UnitW
		{
			[Token(Token = "0x60017EE")]
			[Address(RVA = "0xE1C1A0", Offset = "0xE1C1A0", VA = "0xE1C1A0")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017EF")]
		[Address(RVA = "0xE1C210", Offset = "0xE1C210", VA = "0xE1C210")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F0")]
		[Address(RVA = "0xE1C21C", Offset = "0xE1C21C", VA = "0xE1C21C")]
		public Vector4(Vector2 value, float z, float w)
		{
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F1")]
		[Address(RVA = "0xE1C228", Offset = "0xE1C228", VA = "0xE1C228")]
		public Vector4(Vector3 value, float w)
		{
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F2")]
		[Address(RVA = "0xE1C234", Offset = "0xE1C234", VA = "0xE1C234")]
		public Vector4(float value)
		{
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x0000B478 File Offset: 0x00009678
		[Token(Token = "0x60017F3")]
		[Address(RVA = "0xE1C240", Offset = "0xE1C240", VA = "0xE1C240")]
		public static Vector4 Add(Vector4 value1, Vector4 value2)
		{
			return default(Vector4);
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F4")]
		[Address(RVA = "0xE1C284", Offset = "0xE1C284", VA = "0xE1C284")]
		public static void Add(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
		{
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x0000B490 File Offset: 0x00009690
		[Token(Token = "0x60017F5")]
		[Address(RVA = "0xE1C298", Offset = "0xE1C298", VA = "0xE1C298")]
		public static Vector4 Barycentric(Vector4 value1, Vector4 value2, Vector4 value3, float amount1, float amount2)
		{
			return default(Vector4);
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F6")]
		[Address(RVA = "0xE1C354", Offset = "0xE1C354", VA = "0xE1C354")]
		public static void Barycentric(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, float amount1, float amount2, out Vector4 result)
		{
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x0000B4A8 File Offset: 0x000096A8
		[Token(Token = "0x60017F7")]
		[Address(RVA = "0xE1C410", Offset = "0xE1C410", VA = "0xE1C410")]
		public static Vector4 CatmullRom(Vector4 value1, Vector4 value2, Vector4 value3, Vector4 value4, float amount)
		{
			return default(Vector4);
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F8")]
		[Address(RVA = "0xE1C4C8", Offset = "0xE1C4C8", VA = "0xE1C4C8")]
		public static void CatmullRom(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, ref Vector4 value4, float amount, out Vector4 result)
		{
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x0000B4C0 File Offset: 0x000096C0
		[Token(Token = "0x60017F9")]
		[Address(RVA = "0xE1C588", Offset = "0xE1C588", VA = "0xE1C588")]
		public static Vector4 Clamp(Vector4 value1, Vector4 min, Vector4 max)
		{
			return default(Vector4);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017FA")]
		[Address(RVA = "0xE1C60C", Offset = "0xE1C60C", VA = "0xE1C60C")]
		public static void Clamp(ref Vector4 value1, ref Vector4 min, ref Vector4 max, out Vector4 result)
		{
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x0000B4D8 File Offset: 0x000096D8
		[Token(Token = "0x60017FB")]
		[Address(RVA = "0xE1C688", Offset = "0xE1C688", VA = "0xE1C688")]
		public static float Distance(Vector4 value1, Vector4 value2)
		{
			return 0f;
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017FC")]
		[Address(RVA = "0xE1C758", Offset = "0xE1C758", VA = "0xE1C758")]
		public static void Distance(ref Vector4 value1, ref Vector4 value2, out float result)
		{
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[Token(Token = "0x60017FD")]
		[Address(RVA = "0xE1C80C", Offset = "0xE1C80C", VA = "0xE1C80C")]
		public static float DistanceSquared(Vector4 value1, Vector4 value2)
		{
			return 0f;
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017FE")]
		[Address(RVA = "0xE1C854", Offset = "0xE1C854", VA = "0xE1C854")]
		public static void DistanceSquared(ref Vector4 value1, ref Vector4 value2, out float result)
		{
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x0000B508 File Offset: 0x00009708
		[Token(Token = "0x60017FF")]
		[Address(RVA = "0xE1C89C", Offset = "0xE1C89C", VA = "0xE1C89C")]
		public static Vector4 Divide(Vector4 value1, Vector4 value2)
		{
			return default(Vector4);
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x0000B520 File Offset: 0x00009720
		[Token(Token = "0x6001800")]
		[Address(RVA = "0xE1C8E0", Offset = "0xE1C8E0", VA = "0xE1C8E0")]
		public static Vector4 Divide(Vector4 value1, float divider)
		{
			return default(Vector4);
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001801")]
		[Address(RVA = "0xE1C920", Offset = "0xE1C920", VA = "0xE1C920")]
		public static void Divide(ref Vector4 value1, float divider, out Vector4 result)
		{
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001802")]
		[Address(RVA = "0xE1C93C", Offset = "0xE1C93C", VA = "0xE1C93C")]
		public static void Divide(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
		{
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x0000B538 File Offset: 0x00009738
		[Token(Token = "0x6001803")]
		[Address(RVA = "0xE1C980", Offset = "0xE1C980", VA = "0xE1C980")]
		public static float Dot(Vector4 vector1, Vector4 vector2)
		{
			return 0f;
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001804")]
		[Address(RVA = "0xE1C9B8", Offset = "0xE1C9B8", VA = "0xE1C9B8")]
		public static void Dot(ref Vector4 vector1, ref Vector4 vector2, out float result)
		{
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x0000B550 File Offset: 0x00009750
		[Token(Token = "0x6001805")]
		[Address(RVA = "0xE1C9F0", Offset = "0xE1C9F0", VA = "0xE1C9F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x0000B568 File Offset: 0x00009768
		[Token(Token = "0x6001806")]
		[Address(RVA = "0xE1CB7C", Offset = "0xE1CB7C", VA = "0xE1CB7C", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x0000B580 File Offset: 0x00009780
		[Token(Token = "0x6001807")]
		[Address(RVA = "0xE1CBE0", Offset = "0xE1CBE0", VA = "0xE1CBE0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x0000B598 File Offset: 0x00009798
		[Token(Token = "0x6001808")]
		[Address(RVA = "0xE1CC18", Offset = "0xE1CC18", VA = "0xE1CC18")]
		public static Vector4 Hermite(Vector4 value1, Vector4 tangent1, Vector4 value2, Vector4 tangent2, float amount)
		{
			return default(Vector4);
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001809")]
		[Address(RVA = "0xE1CCD0", Offset = "0xE1CCD0", VA = "0xE1CCD0")]
		public static void Hermite(ref Vector4 value1, ref Vector4 tangent1, ref Vector4 value2, ref Vector4 tangent2, float amount, out Vector4 result)
		{
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x0000B5B0 File Offset: 0x000097B0
		[Token(Token = "0x600180A")]
		[Address(RVA = "0xE1CD84", Offset = "0xE1CD84", VA = "0xE1CD84")]
		public float Length()
		{
			return 0f;
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x0000B5C8 File Offset: 0x000097C8
		[Token(Token = "0x600180B")]
		[Address(RVA = "0xE1CE10", Offset = "0xE1CE10", VA = "0xE1CE10")]
		public float LengthSquared()
		{
			return 0f;
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x0000B5E0 File Offset: 0x000097E0
		[Token(Token = "0x600180C")]
		[Address(RVA = "0xE1CE38", Offset = "0xE1CE38", VA = "0xE1CE38")]
		public static Vector4 Lerp(Vector4 value1, Vector4 value2, float amount)
		{
			return default(Vector4);
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180D")]
		[Address(RVA = "0xE1CEC0", Offset = "0xE1CEC0", VA = "0xE1CEC0")]
		public static void Lerp(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result)
		{
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x0000B5F8 File Offset: 0x000097F8
		[Token(Token = "0x600180E")]
		[Address(RVA = "0xE1CF38", Offset = "0xE1CF38", VA = "0xE1CF38")]
		public static Vector4 Max(Vector4 value1, Vector4 value2)
		{
			return default(Vector4);
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180F")]
		[Address(RVA = "0xE1CFAC", Offset = "0xE1CFAC", VA = "0xE1CFAC")]
		public static void Max(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
		{
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x0000B610 File Offset: 0x00009810
		[Token(Token = "0x6001810")]
		[Address(RVA = "0xE1D018", Offset = "0xE1D018", VA = "0xE1D018")]
		public static Vector4 Min(Vector4 value1, Vector4 value2)
		{
			return default(Vector4);
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001811")]
		[Address(RVA = "0xE1D08C", Offset = "0xE1D08C", VA = "0xE1D08C")]
		public static void Min(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
		{
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x0000B628 File Offset: 0x00009828
		[Token(Token = "0x6001812")]
		[Address(RVA = "0xE1D0F8", Offset = "0xE1D0F8", VA = "0xE1D0F8")]
		public static Vector4 Multiply(Vector4 value1, Vector4 value2)
		{
			return default(Vector4);
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x0000B640 File Offset: 0x00009840
		[Token(Token = "0x6001813")]
		[Address(RVA = "0xE1D13C", Offset = "0xE1D13C", VA = "0xE1D13C")]
		public static Vector4 Multiply(Vector4 value1, float scaleFactor)
		{
			return default(Vector4);
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001814")]
		[Address(RVA = "0xE1D174", Offset = "0xE1D174", VA = "0xE1D174")]
		public static void Multiply(ref Vector4 value1, float scaleFactor, out Vector4 result)
		{
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001815")]
		[Address(RVA = "0xE1D188", Offset = "0xE1D188", VA = "0xE1D188")]
		public static void Multiply(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
		{
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x0000B658 File Offset: 0x00009858
		[Token(Token = "0x6001816")]
		[Address(RVA = "0xE1D19C", Offset = "0xE1D19C", VA = "0xE1D19C")]
		public static Vector4 Negate(Vector4 value)
		{
			return default(Vector4);
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001817")]
		[Address(RVA = "0xE1D1C0", Offset = "0xE1D1C0", VA = "0xE1D1C0")]
		public static void Negate(ref Vector4 value, out Vector4 result)
		{
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001818")]
		[Address(RVA = "0xE1D1D0", Offset = "0xE1D1D0", VA = "0xE1D1D0")]
		public void Normalize()
		{
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x0000B670 File Offset: 0x00009870
		[Token(Token = "0x6001819")]
		[Address(RVA = "0xE1D264", Offset = "0xE1D264", VA = "0xE1D264")]
		public static Vector4 Normalize(Vector4 vector)
		{
			return default(Vector4);
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181A")]
		[Address(RVA = "0xE1D324", Offset = "0xE1D324", VA = "0xE1D324")]
		public static void Normalize(ref Vector4 vector, out Vector4 result)
		{
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x0000B688 File Offset: 0x00009888
		[Token(Token = "0x600181B")]
		[Address(RVA = "0xE1D3BC", Offset = "0xE1D3BC", VA = "0xE1D3BC")]
		public static Vector4 SmoothStep(Vector4 value1, Vector4 value2, float amount)
		{
			return default(Vector4);
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181C")]
		[Address(RVA = "0xE1D444", Offset = "0xE1D444", VA = "0xE1D444")]
		public static void SmoothStep(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result)
		{
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0000B6A0 File Offset: 0x000098A0
		[Token(Token = "0x600181D")]
		[Address(RVA = "0xE1D4BC", Offset = "0xE1D4BC", VA = "0xE1D4BC")]
		public static Vector4 Subtract(Vector4 value1, Vector4 value2)
		{
			return default(Vector4);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181E")]
		[Address(RVA = "0xE1D500", Offset = "0xE1D500", VA = "0xE1D500")]
		public static void Subtract(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
		{
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[Token(Token = "0x600181F")]
		[Address(RVA = "0xE1D514", Offset = "0xE1D514", VA = "0xE1D514")]
		public static Vector4 Transform(Vector2 position, Matrix matrix)
		{
			return default(Vector4);
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x0000B6D0 File Offset: 0x000098D0
		[Token(Token = "0x6001820")]
		[Address(RVA = "0xE1D660", Offset = "0xE1D660", VA = "0xE1D660")]
		public static Vector4 Transform(Vector2 value, Quaternion rotation)
		{
			return default(Vector4);
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x0000B6E8 File Offset: 0x000098E8
		[Token(Token = "0x6001821")]
		[Address(RVA = "0xE1D6AC", Offset = "0xE1D6AC", VA = "0xE1D6AC")]
		public static Vector4 Transform(Vector3 value, Quaternion rotation)
		{
			return default(Vector4);
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0000B700 File Offset: 0x00009900
		[Token(Token = "0x6001822")]
		[Address(RVA = "0xE1D6F8", Offset = "0xE1D6F8", VA = "0xE1D6F8")]
		public static Vector4 Transform(Vector4 value, Quaternion rotation)
		{
			return default(Vector4);
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001823")]
		[Address(RVA = "0xE1D744", Offset = "0xE1D744", VA = "0xE1D744")]
		public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector4 result)
		{
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001824")]
		[Address(RVA = "0xE1D790", Offset = "0xE1D790", VA = "0xE1D790")]
		public static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector4 result)
		{
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001825")]
		[Address(RVA = "0xE1D7DC", Offset = "0xE1D7DC", VA = "0xE1D7DC")]
		public static void Transform(ref Vector4 value, ref Quaternion rotation, out Vector4 result)
		{
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001826")]
		[Address(RVA = "0xE1D828", Offset = "0xE1D828", VA = "0xE1D828")]
		public static void Transform(Vector4[] sourceArray, ref Quaternion rotation, Vector4[] destinationArray)
		{
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001827")]
		[Address(RVA = "0xE1D874", Offset = "0xE1D874", VA = "0xE1D874")]
		public static void Transform(Vector4[] sourceArray, ref Matrix matrix, Vector4[] destinationArray)
		{
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001828")]
		[Address(RVA = "0xE1D8C0", Offset = "0xE1D8C0", VA = "0xE1D8C0")]
		public static void Transform(Vector4[] sourceArray, int sourceIndex, ref Matrix matrix, Vector4[] destinationArray, int destinationIndex, int length)
		{
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001829")]
		[Address(RVA = "0xE1D90C", Offset = "0xE1D90C", VA = "0xE1D90C")]
		public static void Transform(Vector4[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector4[] destinationArray, int destinationIndex, int length)
		{
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x0000B718 File Offset: 0x00009918
		[Token(Token = "0x600182A")]
		[Address(RVA = "0xE1D958", Offset = "0xE1D958", VA = "0xE1D958")]
		public static Vector4 Transform(Vector3 position, Matrix matrix)
		{
			return default(Vector4);
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0000B730 File Offset: 0x00009930
		[Token(Token = "0x600182B")]
		[Address(RVA = "0xE1DB04", Offset = "0xE1DB04", VA = "0xE1DB04")]
		public static Vector4 Transform(Vector4 vector, Matrix matrix)
		{
			return default(Vector4);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182C")]
		[Address(RVA = "0xE1D634", Offset = "0xE1D634", VA = "0xE1D634")]
		public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector4 result)
		{
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182D")]
		[Address(RVA = "0xE1DABC", Offset = "0xE1DABC", VA = "0xE1DABC")]
		public static void Transform(ref Vector3 position, ref Matrix matrix, out Vector4 result)
		{
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182E")]
		[Address(RVA = "0xE1DC64", Offset = "0xE1DC64", VA = "0xE1DC64")]
		public static void Transform(ref Vector4 vector, ref Matrix matrix, out Vector4 result)
		{
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600182F")]
		[Address(RVA = "0xE1DCB8", Offset = "0xE1DCB8", VA = "0xE1DCB8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x0000B748 File Offset: 0x00009948
		[Token(Token = "0x6001830")]
		[Address(RVA = "0xE1DF38", Offset = "0xE1DF38", VA = "0xE1DF38")]
		public static Vector4 operator -(Vector4 value)
		{
			return default(Vector4);
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x0000B760 File Offset: 0x00009960
		[Token(Token = "0x6001831")]
		[Address(RVA = "0xE1CB0C", Offset = "0xE1CB0C", VA = "0xE1CB0C")]
		public static bool operator ==(Vector4 value1, Vector4 value2)
		{
			return default(bool);
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x0000B778 File Offset: 0x00009978
		[Token(Token = "0x6001832")]
		[Address(RVA = "0xE1DF5C", Offset = "0xE1DF5C", VA = "0xE1DF5C")]
		public static bool operator !=(Vector4 value1, Vector4 value2)
		{
			return default(bool);
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x0000B790 File Offset: 0x00009990
		[Token(Token = "0x6001833")]
		[Address(RVA = "0xE1DFCC", Offset = "0xE1DFCC", VA = "0xE1DFCC")]
		public static Vector4 operator +(Vector4 value1, Vector4 value2)
		{
			return default(Vector4);
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x0000B7A8 File Offset: 0x000099A8
		[Token(Token = "0x6001834")]
		[Address(RVA = "0xE1E010", Offset = "0xE1E010", VA = "0xE1E010")]
		public static Vector4 operator -(Vector4 value1, Vector4 value2)
		{
			return default(Vector4);
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x0000B7C0 File Offset: 0x000099C0
		[Token(Token = "0x6001835")]
		[Address(RVA = "0xE1E054", Offset = "0xE1E054", VA = "0xE1E054")]
		public static Vector4 operator *(Vector4 value1, Vector4 value2)
		{
			return default(Vector4);
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0000B7D8 File Offset: 0x000099D8
		[Token(Token = "0x6001836")]
		[Address(RVA = "0xE1E098", Offset = "0xE1E098", VA = "0xE1E098")]
		public static Vector4 operator *(Vector4 value1, float scaleFactor)
		{
			return default(Vector4);
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x0000B7F0 File Offset: 0x000099F0
		[Token(Token = "0x6001837")]
		[Address(RVA = "0xE1E0D0", Offset = "0xE1E0D0", VA = "0xE1E0D0")]
		public static Vector4 operator *(float scaleFactor, Vector4 value1)
		{
			return default(Vector4);
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x0000B808 File Offset: 0x00009A08
		[Token(Token = "0x6001838")]
		[Address(RVA = "0xE1E108", Offset = "0xE1E108", VA = "0xE1E108")]
		public static Vector4 operator /(Vector4 value1, Vector4 value2)
		{
			return default(Vector4);
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x0000B820 File Offset: 0x00009A20
		[Token(Token = "0x6001839")]
		[Address(RVA = "0xE1E14C", Offset = "0xE1E14C", VA = "0xE1E14C")]
		public static Vector4 operator /(Vector4 value1, float divider)
		{
			return default(Vector4);
		}

		// Token: 0x04002B25 RID: 11045
		[Token(Token = "0x4002B25")]
		[FieldOffset(Offset = "0x0")]
		private static Vector4 zeroVector;

		// Token: 0x04002B26 RID: 11046
		[Token(Token = "0x4002B26")]
		[FieldOffset(Offset = "0x10")]
		private static Vector4 unitVector;

		// Token: 0x04002B27 RID: 11047
		[Token(Token = "0x4002B27")]
		[FieldOffset(Offset = "0x20")]
		private static Vector4 unitXVector;

		// Token: 0x04002B28 RID: 11048
		[Token(Token = "0x4002B28")]
		[FieldOffset(Offset = "0x30")]
		private static Vector4 unitYVector;

		// Token: 0x04002B29 RID: 11049
		[Token(Token = "0x4002B29")]
		[FieldOffset(Offset = "0x40")]
		private static Vector4 unitZVector;

		// Token: 0x04002B2A RID: 11050
		[Token(Token = "0x4002B2A")]
		[FieldOffset(Offset = "0x50")]
		private static Vector4 unitWVector;

		// Token: 0x04002B2B RID: 11051
		[Token(Token = "0x4002B2B")]
		[FieldOffset(Offset = "0x0")]
		public float X;

		// Token: 0x04002B2C RID: 11052
		[Token(Token = "0x4002B2C")]
		[FieldOffset(Offset = "0x4")]
		public float Y;

		// Token: 0x04002B2D RID: 11053
		[Token(Token = "0x4002B2D")]
		[FieldOffset(Offset = "0x8")]
		public float Z;

		// Token: 0x04002B2E RID: 11054
		[Token(Token = "0x4002B2E")]
		[FieldOffset(Offset = "0xC")]
		public float W;
	}
}
