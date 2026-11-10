using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.DataStructures;
using Terraria.Localization;

namespace Terraria.GameContent
{
	// Token: 0x020009BB RID: 2491
	[Token(Token = "0x20009BB")]
	public class PlayerDamageTracker
	{
		// Token: 0x06005179 RID: 20857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005179")]
		[Address(RVA = "0x77E460", Offset = "0x77E460", VA = "0x77E460")]
		public void Reset()
		{
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600517A")]
		[Address(RVA = "0x77E4E0", Offset = "0x77E4E0", VA = "0x77E4E0")]
		public void AddDamage(PlayerDeathReason damageSource, int damage)
		{
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517B")]
		[Address(RVA = "0x77E7FC", Offset = "0x77E7FC", VA = "0x77E7FC")]
		private PlayerDamageTracker.CreditEntry GetOrAddEntry(string name)
		{
			return null;
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517C")]
		[Address(RVA = "0x77E560", Offset = "0x77E560", VA = "0x77E560")]
		private static string GetSourceName(PlayerDeathReason source)
		{
			return null;
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517D")]
		[Address(RVA = "0x77EAAC", Offset = "0x77EAAC", VA = "0x77EAAC")]
		public NetworkText GetReport([Optional] PlayerDeathReason lethalDamageSource)
		{
			return null;
		}

		// Token: 0x0600517E RID: 20862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600517E")]
		[Address(RVA = "0x77F340", Offset = "0x77F340", VA = "0x77F340")]
		public PlayerDamageTracker()
		{
		}

		// Token: 0x040094E3 RID: 38115
		[Token(Token = "0x40094E3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly List<PlayerDamageTracker.CreditEntry> _list;

		// Token: 0x020009BC RID: 2492
		[Token(Token = "0x20009BC")]
		private class CreditEntry : FileAPI
		{
			// Token: 0x170009A4 RID: 2468
			// (get) Token: 0x0600517F RID: 20863 RVA: 0x00025DE8 File Offset: 0x00023FE8
			// (set) Token: 0x06005180 RID: 20864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170009A4")]
			public int Damage
			{
				[Token(Token = "0x600517F")]
				[Address(RVA = "0x77F3D8", Offset = "0x77F3D8", VA = "0x77F3D8")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6005180")]
				[Address(RVA = "0x77F3E0", Offset = "0x77F3E0", VA = "0x77F3E0")]
				set
				{
				}
			}

			// Token: 0x170009A5 RID: 2469
			// (get) Token: 0x06005181 RID: 20865 RVA: 0x00025E00 File Offset: 0x00024000
			// (set) Token: 0x06005182 RID: 20866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170009A5")]
			public int HitCount
			{
				[Token(Token = "0x6005181")]
				[Address(RVA = "0x77F3E8", Offset = "0x77F3E8", VA = "0x77F3E8")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6005182")]
				[Address(RVA = "0x77F3F0", Offset = "0x77F3F0", VA = "0x77F3F0")]
				set
				{
				}
			}

			// Token: 0x06005183 RID: 20867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005183")]
			[Address(RVA = "0x77EA90", Offset = "0x77EA90", VA = "0x77EA90")]
			public CreditEntry(string name)
			{
			}

			// Token: 0x06005184 RID: 20868 RVA: 0x00025E18 File Offset: 0x00024018
			[Token(Token = "0x6005184")]
			[Address(RVA = "0x77F3F8", Offset = "0x77F3F8", VA = "0x77F3F8", Slot = "4")]
			public int CompareTo(PlayerDamageTracker.CreditEntry other)
			{
				return 0;
			}

			// Token: 0x040094E4 RID: 38116
			[Token(Token = "0x40094E4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly string Name;

			// Token: 0x040094E5 RID: 38117
			[Token(Token = "0x40094E5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private int <Damage>k__BackingField;

			// Token: 0x040094E6 RID: 38118
			[Token(Token = "0x40094E6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <HitCount>k__BackingField;
		}

		// Token: 0x020009BD RID: 2493
		[Token(Token = "0x20009BD")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005186 RID: 20870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005186")]
			[Address(RVA = "0x77F4CC", Offset = "0x77F4CC", VA = "0x77F4CC")]
			public <>c()
			{
			}

			// Token: 0x06005187 RID: 20871 RVA: 0x00025E30 File Offset: 0x00024030
			[Token(Token = "0x6005187")]
			[Address(RVA = "0x77F4D4", Offset = "0x77F4D4", VA = "0x77F4D4")]
			internal int <GetReport>b__6_0(PlayerDamageTracker.CreditEntry x)
			{
				return 0;
			}

			// Token: 0x040094E7 RID: 38119
			[Token(Token = "0x40094E7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly PlayerDamageTracker.<>c <>9;

			// Token: 0x040094E8 RID: 38120
			[Token(Token = "0x40094E8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<PlayerDamageTracker.CreditEntry, int> <>9__6_0;
		}
	}
}
