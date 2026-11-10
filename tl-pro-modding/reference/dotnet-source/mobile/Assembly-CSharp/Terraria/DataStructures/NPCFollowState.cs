using System;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x0200077D RID: 1917
	[Token(Token = "0x200077D")]
	public class NPCFollowState
	{
		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x0600434D RID: 17229 RVA: 0x00020688 File Offset: 0x0001E888
		[Token(Token = "0x1700082A")]
		public Vector2 BreadcrumbPosition
		{
			[Token(Token = "0x600434D")]
			[Address(RVA = "0x4FECF8", Offset = "0x4FECF8", VA = "0x4FECF8")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x0600434E RID: 17230 RVA: 0x000206A0 File Offset: 0x0001E8A0
		[Token(Token = "0x1700082B")]
		public bool IsFollowingPlayer
		{
			[Token(Token = "0x600434E")]
			[Address(RVA = "0x4FED0C", Offset = "0x4FED0C", VA = "0x4FED0C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x0600434F RID: 17231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700082C")]
		public Player PlayerBeingFollowed
		{
			[Token(Token = "0x600434F")]
			[Address(RVA = "0x4FED4C", Offset = "0x4FED4C", VA = "0x4FED4C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004350")]
		[Address(RVA = "0x4FEE18", Offset = "0x4FEE18", VA = "0x4FEE18")]
		public void FollowPlayer(int playerIndex)
		{
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004351")]
		[Address(RVA = "0x4FEF28", Offset = "0x4FEF28", VA = "0x4FEF28")]
		public void StopFollowing()
		{
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004352")]
		[Address(RVA = "0x4FF028", Offset = "0x4FF028", VA = "0x4FF028")]
		public void Clear(NPC npcToBelongTo)
		{
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x000206B8 File Offset: 0x0001E8B8
		[Token(Token = "0x6004353")]
		[Address(RVA = "0x4FF03C", Offset = "0x4FF03C", VA = "0x4FF03C")]
		private bool ShouldSync()
		{
			return default(bool);
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004354")]
		[Address(RVA = "0x4FF060", Offset = "0x4FF060", VA = "0x4FF060")]
		public void WriteTo(BinaryWriter writer)
		{
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004355")]
		[Address(RVA = "0x4FF10C", Offset = "0x4FF10C", VA = "0x4FF10C")]
		public void ReadFrom(BinaryReader reader)
		{
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004356")]
		[Address(RVA = "0x4FEF60", Offset = "0x4FEF60", VA = "0x4FEF60")]
		private void MoveNPCBackHome()
		{
		}

		// Token: 0x06004357 RID: 17239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004357")]
		[Address(RVA = "0x4FF250", Offset = "0x4FF250", VA = "0x4FF250")]
		public void Update()
		{
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004358")]
		[Address(RVA = "0x4FF3B4", Offset = "0x4FF3B4", VA = "0x4FF3B4")]
		private void UpdateBreadcrumbs(Player player)
		{
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004359")]
		[Address(RVA = "0x4FF564", Offset = "0x4FF564", VA = "0x4FF564")]
		public NPCFollowState()
		{
		}

		// Token: 0x04008AA9 RID: 35497
		[Token(Token = "0x4008AA9")]
		[FieldOffset(Offset = "0x8")]
		private NPC _npc;

		// Token: 0x04008AAA RID: 35498
		[Token(Token = "0x4008AAA")]
		[FieldOffset(Offset = "0xC")]
		private int? _playerIndexBeingFollowed;

		// Token: 0x04008AAB RID: 35499
		[Token(Token = "0x4008AAB")]
		[FieldOffset(Offset = "0x14")]
		private Vector2 _floorBreadcrumb;
	}
}
