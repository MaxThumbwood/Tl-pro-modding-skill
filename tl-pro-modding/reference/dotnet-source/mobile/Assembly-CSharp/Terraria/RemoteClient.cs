using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria
{
	// Token: 0x020004AB RID: 1195
	[Token(Token = "0x20004AB")]
	public class RemoteClient
	{
		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06002EA4 RID: 11940 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002EA5 RID: 11941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002C")]
		public static event Action<int, Point> NetSectionActivated
		{
			[Token(Token = "0x6002EA4")]
			[Address(RVA = "0x18871E0", Offset = "0x18871E0", VA = "0x18871E0")]
			add
			{
			}
			[Token(Token = "0x6002EA5")]
			[Address(RVA = "0x1887300", Offset = "0x1887300", VA = "0x1887300")]
			remove
			{
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06002EA6 RID: 11942 RVA: 0x00016530 File Offset: 0x00014730
		[Token(Token = "0x1700061B")]
		public bool HasAnySection
		{
			[Token(Token = "0x6002EA6")]
			[Address(RVA = "0x1887420", Offset = "0x1887420", VA = "0x1887420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EA7")]
		[Address(RVA = "0x1887510", Offset = "0x1887510", VA = "0x1887510")]
		public void SpamUpdate()
		{
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EA8")]
		[Address(RVA = "0x18879C8", Offset = "0x18879C8", VA = "0x18879C8")]
		public void SpamClear()
		{
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EA9")]
		[Address(RVA = "0x18879D8", Offset = "0x18879D8", VA = "0x18879D8")]
		public static void CheckSection(int playerIndex, Vector2 position, int fluff = 1)
		{
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EAA")]
		[Address(RVA = "0x1887C40", Offset = "0x1887C40", VA = "0x1887C40")]
		private static void CheckSection_ForClient(RemoteClient client, Vector2 position, int fluff)
		{
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x00016548 File Offset: 0x00014748
		[Token(Token = "0x6002EAB")]
		[Address(RVA = "0x1888344", Offset = "0x1888344", VA = "0x1888344")]
		public bool SectionRange(int size, int firstX, int firstY)
		{
			return default(bool);
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x00016560 File Offset: 0x00014760
		[Token(Token = "0x6002EAC")]
		[Address(RVA = "0x1888200", Offset = "0x1888200", VA = "0x1888200")]
		public bool IsSectionActive(Point sectionCoords)
		{
			return default(bool);
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EAD")]
		[Address(RVA = "0x1888530", Offset = "0x1888530", VA = "0x1888530")]
		public void Reset(bool setupActive = false)
		{
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EAE")]
		[Address(RVA = "0x1888904", Offset = "0x1888904", VA = "0x1888904")]
		public void ServerWriteCallBack(object state)
		{
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EAF")]
		[Address(RVA = "0x18889C0", Offset = "0x18889C0", VA = "0x18889C0")]
		public RemoteClient()
		{
		}

		// Token: 0x04003EA2 RID: 16034
		[Token(Token = "0x4003EA2")]
		[FieldOffset(Offset = "0x0")]
		private static List<Point> _pendingSectionFraming;

		// Token: 0x04003EA4 RID: 16036
		[Token(Token = "0x4003EA4")]
		[FieldOffset(Offset = "0x8")]
		public int Id;

		// Token: 0x04003EA5 RID: 16037
		[Token(Token = "0x4003EA5")]
		[FieldOffset(Offset = "0xC")]
		public string Name;

		// Token: 0x04003EA6 RID: 16038
		[Token(Token = "0x4003EA6")]
		[FieldOffset(Offset = "0x10")]
		public bool LocalHost;

		// Token: 0x04003EA7 RID: 16039
		[Token(Token = "0x4003EA7")]
		[FieldOffset(Offset = "0x11")]
		public bool Connected;

		// Token: 0x04003EA8 RID: 16040
		[Token(Token = "0x4003EA8")]
		[FieldOffset(Offset = "0x12")]
		public bool IsActive;

		// Token: 0x04003EA9 RID: 16041
		[Token(Token = "0x4003EA9")]
		[FieldOffset(Offset = "0x13")]
		public bool PendingTermination;

		// Token: 0x04003EAA RID: 16042
		[Token(Token = "0x4003EAA")]
		[FieldOffset(Offset = "0x14")]
		public bool IsAnnouncementCompleted;

		// Token: 0x04003EAB RID: 16043
		[Token(Token = "0x4003EAB")]
		[FieldOffset(Offset = "0x15")]
		public bool WasBanned;

		// Token: 0x04003EAC RID: 16044
		[Token(Token = "0x4003EAC")]
		[FieldOffset(Offset = "0x16")]
		public bool Kicked;

		// Token: 0x04003EAD RID: 16045
		[Token(Token = "0x4003EAD")]
		[FieldOffset(Offset = "0x18")]
		public int State;

		// Token: 0x04003EAE RID: 16046
		[Token(Token = "0x4003EAE")]
		[FieldOffset(Offset = "0x1C")]
		public int TimeOutTimer;

		// Token: 0x04003EAF RID: 16047
		[Token(Token = "0x4003EAF")]
		[FieldOffset(Offset = "0x20")]
		public int StatusCount;

		// Token: 0x04003EB0 RID: 16048
		[Token(Token = "0x4003EB0")]
		[FieldOffset(Offset = "0x24")]
		public int StatusMax;

		// Token: 0x04003EB1 RID: 16049
		[Token(Token = "0x4003EB1")]
		[FieldOffset(Offset = "0x28")]
		public bool[,] TileSections;

		// Token: 0x04003EB2 RID: 16050
		[Token(Token = "0x4003EB2")]
		[FieldOffset(Offset = "0x2C")]
		public uint[,] TileSectionsCheckTime;

		// Token: 0x04003EB3 RID: 16051
		[Token(Token = "0x4003EB3")]
		[FieldOffset(Offset = "0x30")]
		public bool CheckingSections;

		// Token: 0x04003EB4 RID: 16052
		[Token(Token = "0x4003EB4")]
		[FieldOffset(Offset = "0x34")]
		public float SpamProjectile;

		// Token: 0x04003EB5 RID: 16053
		[Token(Token = "0x4003EB5")]
		[FieldOffset(Offset = "0x38")]
		public float SpamAddBlock;

		// Token: 0x04003EB6 RID: 16054
		[Token(Token = "0x4003EB6")]
		[FieldOffset(Offset = "0x3C")]
		public float SpamDeleteBlock;

		// Token: 0x04003EB7 RID: 16055
		[Token(Token = "0x4003EB7")]
		[FieldOffset(Offset = "0x40")]
		public float SpamWater;

		// Token: 0x04003EB8 RID: 16056
		[Token(Token = "0x4003EB8")]
		[FieldOffset(Offset = "0x44")]
		public float SpamProjectileMax;

		// Token: 0x04003EB9 RID: 16057
		[Token(Token = "0x4003EB9")]
		[FieldOffset(Offset = "0x48")]
		public float SpamAddBlockMax;

		// Token: 0x04003EBA RID: 16058
		[Token(Token = "0x4003EBA")]
		[FieldOffset(Offset = "0x4C")]
		public float SpamDeleteBlockMax;

		// Token: 0x04003EBB RID: 16059
		[Token(Token = "0x4003EBB")]
		[FieldOffset(Offset = "0x50")]
		public float SpamWaterMax;
	}
}
