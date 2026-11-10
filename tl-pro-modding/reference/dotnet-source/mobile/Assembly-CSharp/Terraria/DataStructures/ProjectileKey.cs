using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x02000796 RID: 1942
	[Token(Token = "0x2000796")]
	[StructLayout(2)]
	public struct ProjectileKey : FileAPI
	{
		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06004424 RID: 17444 RVA: 0x00020AC0 File Offset: 0x0001ECC0
		[Token(Token = "0x17000834")]
		public int Spawner
		{
			[Token(Token = "0x6004424")]
			[Address(RVA = "0x558820", Offset = "0x558820", VA = "0x558820")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06004425 RID: 17445 RVA: 0x00020AD8 File Offset: 0x0001ECD8
		[Token(Token = "0x17000835")]
		public int Index
		{
			[Token(Token = "0x6004425")]
			[Address(RVA = "0x558828", Offset = "0x558828", VA = "0x558828")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06004426 RID: 17446 RVA: 0x00020AF0 File Offset: 0x0001ECF0
		[Token(Token = "0x17000836")]
		public int Generation
		{
			[Token(Token = "0x6004426")]
			[Address(RVA = "0x558834", Offset = "0x558834", VA = "0x558834")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004427")]
		[Address(RVA = "0x558840", Offset = "0x558840", VA = "0x558840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x00020B08 File Offset: 0x0001ED08
		[Token(Token = "0x6004428")]
		[Address(RVA = "0x558914", Offset = "0x558914", VA = "0x558914")]
		private static uint Pack(int spawner, int index, int generation)
		{
			return 0U;
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004429")]
		[Address(RVA = "0x558924", Offset = "0x558924", VA = "0x558924")]
		private ProjectileKey(uint bits)
		{
		}

		// Token: 0x0600442A RID: 17450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600442A")]
		[Address(RVA = "0x55892C", Offset = "0x55892C", VA = "0x55892C")]
		private ProjectileKey(float bits)
		{
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600442B")]
		[Address(RVA = "0x558934", Offset = "0x558934", VA = "0x558934")]
		public ProjectileKey(int spawner, int index, int generation)
		{
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x00020B20 File Offset: 0x0001ED20
		[Token(Token = "0x600442C")]
		[Address(RVA = "0x558948", Offset = "0x558948", VA = "0x558948")]
		public static implicit operator uint(ProjectileKey p)
		{
			return 0U;
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x00020B38 File Offset: 0x0001ED38
		[Token(Token = "0x600442D")]
		[Address(RVA = "0x55894C", Offset = "0x55894C", VA = "0x55894C")]
		public static implicit operator int(ProjectileKey p)
		{
			return 0;
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x00020B50 File Offset: 0x0001ED50
		[Token(Token = "0x600442E")]
		[Address(RVA = "0x558950", Offset = "0x558950", VA = "0x558950")]
		public static implicit operator float(ProjectileKey p)
		{
			return 0f;
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x00020B68 File Offset: 0x0001ED68
		[Token(Token = "0x600442F")]
		[Address(RVA = "0x558954", Offset = "0x558954", VA = "0x558954")]
		public static explicit operator ProjectileKey(int i)
		{
			return default(ProjectileKey);
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x00020B80 File Offset: 0x0001ED80
		[Token(Token = "0x6004430")]
		[Address(RVA = "0x558958", Offset = "0x558958", VA = "0x558958")]
		public static explicit operator ProjectileKey(uint u)
		{
			return default(ProjectileKey);
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x00020B98 File Offset: 0x0001ED98
		[Token(Token = "0x6004431")]
		[Address(RVA = "0x55895C", Offset = "0x55895C", VA = "0x55895C")]
		public static explicit operator ProjectileKey(float f)
		{
			return default(ProjectileKey);
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x00020BB0 File Offset: 0x0001EDB0
		[Token(Token = "0x6004432")]
		[Address(RVA = "0x558960", Offset = "0x558960", VA = "0x558960", Slot = "4")]
		public bool Equals(ProjectileKey other)
		{
			return default(bool);
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x00020BC8 File Offset: 0x0001EDC8
		[Token(Token = "0x6004433")]
		[Address(RVA = "0x558974", Offset = "0x558974", VA = "0x558974")]
		public bool TryGet(out Projectile proj)
		{
			return default(bool);
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x00020BE0 File Offset: 0x0001EDE0
		[Token(Token = "0x6004434")]
		[Address(RVA = "0x5589E8", Offset = "0x5589E8", VA = "0x5589E8")]
		public bool TryGetActive(out Projectile proj)
		{
			return default(bool);
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x00020BF8 File Offset: 0x0001EDF8
		[Token(Token = "0x6004435")]
		[Address(RVA = "0x558A88", Offset = "0x558A88", VA = "0x558A88")]
		public bool TryGetActive(int expectedType, out Projectile proj)
		{
			return default(bool);
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x00020C10 File Offset: 0x0001EE10
		[Token(Token = "0x6004436")]
		[Address(RVA = "0x558B4C", Offset = "0x558B4C", VA = "0x558B4C")]
		public bool TryGetActive(bool[] expectedTypes, out Projectile proj)
		{
			return default(bool);
		}

		// Token: 0x04008BC5 RID: 35781
		[Token(Token = "0x4008BC5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly uint bits;

		// Token: 0x04008BC6 RID: 35782
		[Token(Token = "0x4008BC6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly float floatBits;
	}
}
