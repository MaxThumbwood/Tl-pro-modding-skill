using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x020009B9 RID: 2489
	[Token(Token = "0x20009B9")]
	public struct PlayerSittingHelper
	{
		// Token: 0x0600516A RID: 20842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600516A")]
		[Address(RVA = "0x77A84C", Offset = "0x77A84C", VA = "0x77A84C")]
		public void GetSittingOffsetInfo(Player player, out Vector2 posOffset, out float seatAdjustment)
		{
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x00025D58 File Offset: 0x00023F58
		[Token(Token = "0x600516B")]
		[Address(RVA = "0x77AA94", Offset = "0x77AA94", VA = "0x77AA94")]
		public bool TryGetSittingBlock(Player player, out Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600516C")]
		[Address(RVA = "0x77C0FC", Offset = "0x77C0FC", VA = "0x77C0FC")]
		public void UpdateSitting(Player player)
		{
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600516D")]
		[Address(RVA = "0x77C68C", Offset = "0x77C68C", VA = "0x77C68C")]
		public void SitUp(Player player, bool multiplayerBroadcast = true)
		{
		}

		// Token: 0x0600516E RID: 20846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600516E")]
		[Address(RVA = "0x77C83C", Offset = "0x77C83C", VA = "0x77C83C")]
		public void SitDown(Player player, int x, int y)
		{
		}

		// Token: 0x0600516F RID: 20847 RVA: 0x00025D70 File Offset: 0x00023F70
		[Token(Token = "0x600516F")]
		[Address(RVA = "0x77AC70", Offset = "0x77AC70", VA = "0x77AC70")]
		public static bool GetSittingTargetInfo(Player player, int x, int y, out int targetDirection, out Vector2 playerSittingPosition, out Vector2 seatDownOffset, out ExtraSeatInfo extraInfo)
		{
			return default(bool);
		}

		// Token: 0x040094D8 RID: 38104
		[Token(Token = "0x40094D8")]
		public const int ChairSittingMaxDistance = 40;

		// Token: 0x040094D9 RID: 38105
		[Token(Token = "0x40094D9")]
		[FieldOffset(Offset = "0x0")]
		public bool isSitting;

		// Token: 0x040094DA RID: 38106
		[Token(Token = "0x40094DA")]
		[FieldOffset(Offset = "0x1")]
		public ExtraSeatInfo details;

		// Token: 0x040094DB RID: 38107
		[Token(Token = "0x40094DB")]
		[FieldOffset(Offset = "0x4")]
		public Vector2 offsetForSeat;

		// Token: 0x040094DC RID: 38108
		[Token(Token = "0x40094DC")]
		[FieldOffset(Offset = "0xC")]
		public int sittingIndex;
	}
}
