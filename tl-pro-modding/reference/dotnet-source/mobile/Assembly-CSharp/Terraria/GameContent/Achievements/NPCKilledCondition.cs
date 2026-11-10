using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x02000C61 RID: 3169
	[Token(Token = "0x2000C61")]
	public class NPCKilledCondition : AchievementCondition
	{
		// Token: 0x06005E24 RID: 24100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E24")]
		[Address(RVA = "0x9B9A50", Offset = "0x9B9A50", VA = "0x9B9A50")]
		private NPCKilledCondition(LocalUser user, short npcId)
		{
		}

		// Token: 0x06005E25 RID: 24101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E25")]
		[Address(RVA = "0x9B9EEC", Offset = "0x9B9EEC", VA = "0x9B9EEC")]
		private NPCKilledCondition(LocalUser user, short[] npcIds)
		{
		}

		// Token: 0x06005E26 RID: 24102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E26")]
		[Address(RVA = "0x9B9FB4", Offset = "0x9B9FB4", VA = "0x9B9FB4", Slot = "5")]
		public override void Shutdown()
		{
		}

		// Token: 0x06005E27 RID: 24103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E27")]
		[Address(RVA = "0x9B9B54", Offset = "0x9B9B54", VA = "0x9B9B54")]
		private static void ListenForPickup(NPCKilledCondition condition)
		{
		}

		// Token: 0x06005E28 RID: 24104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E28")]
		[Address(RVA = "0x9BA0E4", Offset = "0x9BA0E4", VA = "0x9BA0E4")]
		private static void NPCKilledListener(Player player, short npcId)
		{
		}

		// Token: 0x06005E29 RID: 24105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E29")]
		[Address(RVA = "0x9BA35C", Offset = "0x9BA35C", VA = "0x9BA35C")]
		public static AchievementCondition Create(LocalUser user, short[] npcIds)
		{
			return null;
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E2A")]
		[Address(RVA = "0x9BA3D4", Offset = "0x9BA3D4", VA = "0x9BA3D4")]
		public static AchievementCondition Create(LocalUser user, short npcId)
		{
			return null;
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E2B")]
		[Address(RVA = "0x9BA44C", Offset = "0x9BA44C", VA = "0x9BA44C")]
		public static AchievementCondition[] CreateMany(LocalUser user, short[] npcs)
		{
			return null;
		}

		// Token: 0x04009DD2 RID: 40402
		[Token(Token = "0x4009DD2")]
		private const string Identifier = "NPC_KILLED";

		// Token: 0x04009DD3 RID: 40403
		[Token(Token = "0x4009DD3")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<short, List<NPCKilledCondition>> _listeners;

		// Token: 0x04009DD4 RID: 40404
		[Token(Token = "0x4009DD4")]
		[FieldOffset(Offset = "0x4")]
		private static bool _isListenerHooked;

		// Token: 0x04009DD5 RID: 40405
		[Token(Token = "0x4009DD5")]
		[FieldOffset(Offset = "0x18")]
		private readonly LocalUser _user;

		// Token: 0x04009DD6 RID: 40406
		[Token(Token = "0x4009DD6")]
		[FieldOffset(Offset = "0x1C")]
		private short[] _npcIds;
	}
}
