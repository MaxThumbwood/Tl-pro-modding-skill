using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x020009E3 RID: 2531
	[Token(Token = "0x20009E3")]
	public class TownRoomManager
	{
		// Token: 0x06005285 RID: 21125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005285")]
		[Address(RVA = "0x7DFB50", Offset = "0x7DFB50", VA = "0x7DFB50")]
		public void AddOccupantsToList(int x, int y, List<int> occupantsList)
		{
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005286")]
		[Address(RVA = "0x7DFB94", Offset = "0x7DFB94", VA = "0x7DFB94")]
		public void AddOccupantsToList(Point tilePosition, List<int> occupants)
		{
		}

		// Token: 0x06005287 RID: 21127 RVA: 0x00026730 File Offset: 0x00024930
		[Token(Token = "0x6005287")]
		[Address(RVA = "0x7DFE48", Offset = "0x7DFE48", VA = "0x7DFE48")]
		public bool HasRoomQuick(int npcID)
		{
			return default(bool);
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x00026748 File Offset: 0x00024948
		[Token(Token = "0x6005288")]
		[Address(RVA = "0x7DFE6C", Offset = "0x7DFE6C", VA = "0x7DFE6C")]
		public bool HasRoom(int npcID, out Point roomPosition)
		{
			return default(bool);
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005289")]
		[Address(RVA = "0x7E00A8", Offset = "0x7E00A8", VA = "0x7E00A8")]
		public void SetRoom(int npcID, int x, int y)
		{
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528A")]
		[Address(RVA = "0x7E0118", Offset = "0x7E0118", VA = "0x7E0118")]
		public void SetRoom(int npcID, Point pt)
		{
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528B")]
		[Address(RVA = "0x7E0410", Offset = "0x7E0410", VA = "0x7E0410")]
		public void KickOut(NPC n)
		{
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528C")]
		[Address(RVA = "0x7E0464", Offset = "0x7E0464", VA = "0x7E0464")]
		public void KickOut(int npcType)
		{
		}

		// Token: 0x0600528D RID: 21133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528D")]
		[Address(RVA = "0x7E068C", Offset = "0x7E068C", VA = "0x7E068C")]
		public void DisplayRooms()
		{
		}

		// Token: 0x0600528E RID: 21134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528E")]
		[Address(RVA = "0x7E0930", Offset = "0x7E0930", VA = "0x7E0930")]
		public void Save(BinaryWriter writer)
		{
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528F")]
		[Address(RVA = "0x7E0C70", Offset = "0x7E0C70", VA = "0x7E0C70")]
		public void Load(BinaryReader reader)
		{
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005290")]
		[Address(RVA = "0x7E0E70", Offset = "0x7E0E70", VA = "0x7E0E70")]
		public void Clear()
		{
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x00026760 File Offset: 0x00024960
		[Token(Token = "0x6005291")]
		[Address(RVA = "0x7E0F30", Offset = "0x7E0F30", VA = "0x7E0F30")]
		public byte GetHouseholdStatus(NPC n)
		{
			return 0;
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x00026778 File Offset: 0x00024978
		[Token(Token = "0x6005292")]
		[Address(RVA = "0x7E0F7C", Offset = "0x7E0F7C", VA = "0x7E0F7C")]
		public bool CanNPCsLiveWithEachOther(int npc1ByType, NPC npc2)
		{
			return default(bool);
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x00026790 File Offset: 0x00024990
		[Token(Token = "0x6005293")]
		[Address(RVA = "0x7E1070", Offset = "0x7E1070", VA = "0x7E1070")]
		public bool CanNPCsLiveWithEachOther(NPC npc1, NPC npc2)
		{
			return default(bool);
		}

		// Token: 0x06005294 RID: 21140 RVA: 0x000267A8 File Offset: 0x000249A8
		[Token(Token = "0x6005294")]
		[Address(RVA = "0x7D5080", Offset = "0x7D5080", VA = "0x7D5080")]
		public bool CanNPCsLiveWithEachOther_ShopHelper(NPC npc1, NPC npc2)
		{
			return default(bool);
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005295")]
		[Address(RVA = "0x7E10A8", Offset = "0x7E10A8", VA = "0x7E10A8")]
		public TownRoomManager()
		{
		}

		// Token: 0x040096DB RID: 38619
		[Token(Token = "0x40096DB")]
		[FieldOffset(Offset = "0x0")]
		public static object EntityCreationLock;

		// Token: 0x040096DC RID: 38620
		[Token(Token = "0x40096DC")]
		[FieldOffset(Offset = "0x8")]
		private List<Tuple<int, Point>> _roomLocationPairs;

		// Token: 0x040096DD RID: 38621
		[Token(Token = "0x40096DD")]
		[FieldOffset(Offset = "0xC")]
		private bool[] _hasRoom;

		// Token: 0x020009E4 RID: 2532
		[Token(Token = "0x20009E4")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06005297 RID: 21143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005297")]
			[Address(RVA = "0x7E0408", Offset = "0x7E0408", VA = "0x7E0408")]
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06005298 RID: 21144 RVA: 0x000267C0 File Offset: 0x000249C0
			[Token(Token = "0x6005298")]
			[Address(RVA = "0x7E11FC", Offset = "0x7E11FC", VA = "0x7E11FC")]
			internal bool <SetRoom>b__0(Tuple<int, Point> x)
			{
				return default(bool);
			}

			// Token: 0x040096DE RID: 38622
			[Token(Token = "0x40096DE")]
			[FieldOffset(Offset = "0x8")]
			public int npcID;
		}

		// Token: 0x020009E5 RID: 2533
		[Token(Token = "0x20009E5")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06005299 RID: 21145 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005299")]
			[Address(RVA = "0x7E0684", Offset = "0x7E0684", VA = "0x7E0684")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x0600529A RID: 21146 RVA: 0x000267D8 File Offset: 0x000249D8
			[Token(Token = "0x600529A")]
			[Address(RVA = "0x7E125C", Offset = "0x7E125C", VA = "0x7E125C")]
			internal bool <KickOut>b__0(Tuple<int, Point> x)
			{
				return default(bool);
			}

			// Token: 0x040096DF RID: 38623
			[Token(Token = "0x40096DF")]
			[FieldOffset(Offset = "0x8")]
			public int npcType;
		}
	}
}
