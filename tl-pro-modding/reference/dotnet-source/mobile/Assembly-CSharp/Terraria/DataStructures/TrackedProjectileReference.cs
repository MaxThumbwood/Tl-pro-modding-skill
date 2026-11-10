using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007CF RID: 1999
	[Token(Token = "0x20007CF")]
	public struct TrackedProjectileReference
	{
		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x060044F1 RID: 17649 RVA: 0x00020FA0 File Offset: 0x0001F1A0
		// (set) Token: 0x060044F2 RID: 17650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000847")]
		public ProjectileKey Key
		{
			[Token(Token = "0x60044F1")]
			[Address(RVA = "0x55E7C0", Offset = "0x55E7C0", VA = "0x55E7C0")]
			get
			{
				return default(ProjectileKey);
			}
			[Token(Token = "0x60044F2")]
			[Address(RVA = "0x55E7C8", Offset = "0x55E7C8", VA = "0x55E7C8")]
			private set
			{
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x060044F3 RID: 17651 RVA: 0x00020FB8 File Offset: 0x0001F1B8
		// (set) Token: 0x060044F4 RID: 17652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000848")]
		public int ProjectileType
		{
			[Token(Token = "0x60044F3")]
			[Address(RVA = "0x55E7D0", Offset = "0x55E7D0", VA = "0x55E7D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60044F4")]
			[Address(RVA = "0x55E7D8", Offset = "0x55E7D8", VA = "0x55E7D8")]
			private set
			{
			}
		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F5")]
		[Address(RVA = "0x55E7E0", Offset = "0x55E7E0", VA = "0x55E7E0")]
		public void Set(Projectile proj)
		{
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F6")]
		[Address(RVA = "0x55E820", Offset = "0x55E820", VA = "0x55E820")]
		public void Clear()
		{
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F7")]
		[Address(RVA = "0x55E830", Offset = "0x55E830", VA = "0x55E830")]
		public void Write(BinaryWriter writer)
		{
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x00020FD0 File Offset: 0x0001F1D0
		[Token(Token = "0x60044F8")]
		[Address(RVA = "0x55E890", Offset = "0x55E890", VA = "0x55E890")]
		public bool IsTracking(Projectile proj)
		{
			return default(bool);
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F9")]
		[Address(RVA = "0x55E8C0", Offset = "0x55E8C0", VA = "0x55E8C0")]
		public void Read(BinaryReader reader)
		{
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x00020FE8 File Offset: 0x0001F1E8
		[Token(Token = "0x60044FA")]
		[Address(RVA = "0x55E918", Offset = "0x55E918", VA = "0x55E918", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x00021000 File Offset: 0x0001F200
		[Token(Token = "0x60044FB")]
		[Address(RVA = "0x55E9B0", Offset = "0x55E9B0", VA = "0x55E9B0")]
		public bool Equals(TrackedProjectileReference other)
		{
			return default(bool);
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x00021018 File Offset: 0x0001F218
		[Token(Token = "0x60044FC")]
		[Address(RVA = "0x55E9D4", Offset = "0x55E9D4", VA = "0x55E9D4", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x00021030 File Offset: 0x0001F230
		[Token(Token = "0x60044FD")]
		[Address(RVA = "0x55EA48", Offset = "0x55EA48", VA = "0x55EA48")]
		public static bool operator ==(TrackedProjectileReference c1, TrackedProjectileReference c2)
		{
			return default(bool);
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00021048 File Offset: 0x0001F248
		[Token(Token = "0x60044FE")]
		[Address(RVA = "0x55EA60", Offset = "0x55EA60", VA = "0x55EA60")]
		public static bool operator !=(TrackedProjectileReference c1, TrackedProjectileReference c2)
		{
			return default(bool);
		}

		// Token: 0x04008C6B RID: 35947
		[Token(Token = "0x4008C6B")]
		[FieldOffset(Offset = "0x0")]
		private ProjectileKey <Key>k__BackingField;

		// Token: 0x04008C6C RID: 35948
		[Token(Token = "0x4008C6C")]
		[FieldOffset(Offset = "0x4")]
		private int <ProjectileType>k__BackingField;
	}
}
