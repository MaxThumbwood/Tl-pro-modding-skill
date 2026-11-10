using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x02000779 RID: 1913
	[Token(Token = "0x2000779")]
	public class MinionRespawner
	{
		// Token: 0x0600433F RID: 17215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600433F")]
		[Address(RVA = "0x4FDCE8", Offset = "0x4FDCE8", VA = "0x4FDCE8")]
		public void Clear()
		{
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004340")]
		[Address(RVA = "0x4FDD68", Offset = "0x4FDD68", VA = "0x4FDD68")]
		public void CollectMinionsFor(Player player)
		{
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004341")]
		[Address(RVA = "0x4FDF44", Offset = "0x4FDF44", VA = "0x4FDF44")]
		public void Replace(IEnumerable<MinionSpawnInfo> records)
		{
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004342")]
		[Address(RVA = "0x4FE020", Offset = "0x4FE020", VA = "0x4FE020")]
		public void RestoreMinionsFor(Player player)
		{
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004343")]
		[Address(RVA = "0x4FE2DC", Offset = "0x4FE2DC", VA = "0x4FE2DC")]
		public MinionRespawner()
		{
		}

		// Token: 0x04008A9C RID: 35484
		[Token(Token = "0x4008A9C")]
		[FieldOffset(Offset = "0x8")]
		private List<MinionSpawnInfo> _minions;
	}
}
