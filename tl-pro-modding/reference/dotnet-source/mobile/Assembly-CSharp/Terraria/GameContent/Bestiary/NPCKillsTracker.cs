using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BEF RID: 3055
	[Token(Token = "0x2000BEF")]
	public class NPCKillsTracker : FileAPI, GUIControllerItem
	{
		// Token: 0x06005C30 RID: 23600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C30")]
		[Address(RVA = "0x99C5CC", Offset = "0x99C5CC", VA = "0x99C5CC")]
		public NPCKillsTracker()
		{
		}

		// Token: 0x06005C31 RID: 23601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C31")]
		[Address(RVA = "0x99C920", Offset = "0x99C920", VA = "0x99C920")]
		public void RegisterKill(NPC npc)
		{
		}

		// Token: 0x06005C32 RID: 23602 RVA: 0x0002B458 File Offset: 0x00029658
		[Token(Token = "0x6005C32")]
		[Address(RVA = "0x99CD20", Offset = "0x99CD20", VA = "0x99CD20")]
		public int GetKillCount(NPC npc)
		{
			return 0;
		}

		// Token: 0x06005C33 RID: 23603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C33")]
		[Address(RVA = "0x99CAA4", Offset = "0x99CAA4", VA = "0x99CAA4")]
		public void SetKillCountDirectly(string persistentId, int killCount)
		{
		}

		// Token: 0x06005C34 RID: 23604 RVA: 0x0002B470 File Offset: 0x00029670
		[Token(Token = "0x6005C34")]
		[Address(RVA = "0x99CDC0", Offset = "0x99CDC0", VA = "0x99CDC0")]
		public int GetKillCount(string persistentId)
		{
			return 0;
		}

		// Token: 0x06005C35 RID: 23605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C35")]
		[Address(RVA = "0x99AAF4", Offset = "0x99AAF4", VA = "0x99AAF4", Slot = "4")]
		public void Save(BinaryWriter writer)
		{
		}

		// Token: 0x06005C36 RID: 23606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C36")]
		[Address(RVA = "0x99B4D0", Offset = "0x99B4D0", VA = "0x99B4D0", Slot = "5")]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x06005C37 RID: 23607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C37")]
		[Address(RVA = "0x99B84C", Offset = "0x99B84C", VA = "0x99B84C", Slot = "6")]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x06005C38 RID: 23608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C38")]
		[Address(RVA = "0x99BA50", Offset = "0x99BA50", VA = "0x99BA50", Slot = "7")]
		public void Reset()
		{
		}

		// Token: 0x06005C39 RID: 23609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C39")]
		[Address(RVA = "0x99BC44", Offset = "0x99BC44", VA = "0x99BC44", Slot = "8")]
		public void OnPlayerJoining(int playerIndex)
		{
		}

		// Token: 0x04009CE9 RID: 40169
		[Token(Token = "0x4009CE9")]
		[FieldOffset(Offset = "0x8")]
		private object _entryCreationLock;

		// Token: 0x04009CEA RID: 40170
		[Token(Token = "0x4009CEA")]
		public const int POSITIVE_KILL_COUNT_CAP = 999999999;

		// Token: 0x04009CEB RID: 40171
		[Token(Token = "0x4009CEB")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<string, int> _killCountsByNpcId;
	}
}
