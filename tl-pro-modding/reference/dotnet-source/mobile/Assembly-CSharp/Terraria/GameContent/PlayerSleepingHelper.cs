using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x020009BA RID: 2490
	[Token(Token = "0x20009BA")]
	public struct PlayerSleepingHelper
	{
		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06005170 RID: 20848 RVA: 0x00025D88 File Offset: 0x00023F88
		[Token(Token = "0x170009A3")]
		public bool FullyFallenAsleep
		{
			[Token(Token = "0x6005170")]
			[Address(RVA = "0x77CD60", Offset = "0x77CD60", VA = "0x77CD60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005171")]
		[Address(RVA = "0x77CD84", Offset = "0x77CD84", VA = "0x77CD84")]
		public void GetSleepingOffsetInfo(Player player, out Vector2 posOffset)
		{
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x00025DA0 File Offset: 0x00023FA0
		[Token(Token = "0x6005172")]
		[Address(RVA = "0x77CF48", Offset = "0x77CF48", VA = "0x77CF48")]
		private bool DoesPlayerHaveReasonToActUpInBed(Player player)
		{
			return default(bool);
		}

		// Token: 0x06005173 RID: 20851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005173")]
		[Address(RVA = "0x77D094", Offset = "0x77D094", VA = "0x77D094")]
		public void SetIsSleepingAndAdjustPlayerRotation(Player player, bool state)
		{
		}

		// Token: 0x06005174 RID: 20852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005174")]
		[Address(RVA = "0x77D268", Offset = "0x77D268", VA = "0x77D268")]
		public void UpdateState(Player player)
		{
		}

		// Token: 0x06005175 RID: 20853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005175")]
		[Address(RVA = "0x77DBA8", Offset = "0x77DBA8", VA = "0x77DBA8")]
		public void StopSleeping(Player player, bool multiplayerBroadcast = true)
		{
		}

		// Token: 0x06005176 RID: 20854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005176")]
		[Address(RVA = "0x77DCD8", Offset = "0x77DCD8", VA = "0x77DCD8")]
		public void StartSleeping(Player player, int x, int y)
		{
		}

		// Token: 0x06005177 RID: 20855 RVA: 0x00025DB8 File Offset: 0x00023FB8
		[Token(Token = "0x6005177")]
		[Address(RVA = "0x77D68C", Offset = "0x77D68C", VA = "0x77D68C")]
		public static bool GetSleepingTargetInfo(int x, int y, out int targetDirection, out Vector2 anchorPosition, out Vector2 visualoffset)
		{
			return default(bool);
		}

		// Token: 0x06005178 RID: 20856 RVA: 0x00025DD0 File Offset: 0x00023FD0
		[Token(Token = "0x6005178")]
		[Address(RVA = "0x77E220", Offset = "0x77E220", VA = "0x77E220")]
		private static Vector2 SetOffsetbyBed(int bedStyle)
		{
			return default(Vector2);
		}

		// Token: 0x040094DD RID: 38109
		[Token(Token = "0x40094DD")]
		public const int BedSleepingMaxDistance = 96;

		// Token: 0x040094DE RID: 38110
		[Token(Token = "0x40094DE")]
		public const int TimeToFullyFallAsleep = 120;

		// Token: 0x040094DF RID: 38111
		[Token(Token = "0x40094DF")]
		[FieldOffset(Offset = "0x0")]
		public bool isSleeping;

		// Token: 0x040094E0 RID: 38112
		[Token(Token = "0x40094E0")]
		[FieldOffset(Offset = "0x4")]
		public int sleepingIndex;

		// Token: 0x040094E1 RID: 38113
		[Token(Token = "0x40094E1")]
		[FieldOffset(Offset = "0x8")]
		public int timeSleeping;

		// Token: 0x040094E2 RID: 38114
		[Token(Token = "0x40094E2")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 visualOffsetOfBedBase;
	}
}
