using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.LootSimulation
{
	// Token: 0x02000A44 RID: 2628
	[Token(Token = "0x2000A44")]
	public class SimulatorInfo
	{
		// Token: 0x0600545F RID: 21599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600545F")]
		[Address(RVA = "0x814D08", Offset = "0x814D08", VA = "0x814D08")]
		public SimulatorInfo()
		{
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005460")]
		[Address(RVA = "0x815690", Offset = "0x815690", VA = "0x815690")]
		public void ReturnToOriginalDaytime()
		{
		}

		// Token: 0x06005461 RID: 21601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005461")]
		[Address(RVA = "0x815704", Offset = "0x815704", VA = "0x815704")]
		public void AddItem(int itemId, int amount)
		{
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005462")]
		[Address(RVA = "0x815790", Offset = "0x815790", VA = "0x815790")]
		public void ReturnToOriginalPlayerPosition()
		{
		}

		// Token: 0x040097E9 RID: 38889
		[Token(Token = "0x40097E9")]
		[FieldOffset(Offset = "0x8")]
		public Player player;

		// Token: 0x040097EA RID: 38890
		[Token(Token = "0x40097EA")]
		[FieldOffset(Offset = "0x10")]
		private double _originalDayTimeCounter;

		// Token: 0x040097EB RID: 38891
		[Token(Token = "0x40097EB")]
		[FieldOffset(Offset = "0x18")]
		private bool _originalDayTimeFlag;

		// Token: 0x040097EC RID: 38892
		[Token(Token = "0x40097EC")]
		[FieldOffset(Offset = "0x1C")]
		private Vector2 _originalPlayerPosition;

		// Token: 0x040097ED RID: 38893
		[Token(Token = "0x40097ED")]
		[FieldOffset(Offset = "0x24")]
		public bool runningExpertMode;

		// Token: 0x040097EE RID: 38894
		[Token(Token = "0x40097EE")]
		[FieldOffset(Offset = "0x28")]
		public LootSimulationItemCounter itemCounter;

		// Token: 0x040097EF RID: 38895
		[Token(Token = "0x40097EF")]
		[FieldOffset(Offset = "0x2C")]
		public NPC npcVictim;
	}
}
