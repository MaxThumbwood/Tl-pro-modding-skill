using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x02000468 RID: 1128
	[Token(Token = "0x2000468")]
	public class HitTile
	{
		// Token: 0x06001F42 RID: 8002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F42")]
		[Address(RVA = "0xF11B30", Offset = "0xF11B30", VA = "0xF11B30")]
		public static void ClearAllTilesAtThisLocation(int x, int y)
		{
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F43")]
		[Address(RVA = "0xF11C90", Offset = "0xF11C90", VA = "0xF11C90")]
		public void ClearThisTile(int x, int y)
		{
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F44")]
		[Address(RVA = "0xF122B4", Offset = "0xF122B4", VA = "0xF122B4")]
		public HitTile()
		{
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		[Token(Token = "0x6001F45")]
		[Address(RVA = "0xF1238C", Offset = "0xF1238C", VA = "0xF1238C")]
		private int NextCrackStyle()
		{
			return 0;
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		[Token(Token = "0x6001F46")]
		[Address(RVA = "0xF12444", Offset = "0xF12444", VA = "0xF12444")]
		public int TryFinding(int x, int y, int hitType)
		{
			return 0;
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F47")]
		[Address(RVA = "0xF1253C", Offset = "0xF1253C", VA = "0xF1253C")]
		public void TryClearingAndPruning(int x, int y, int hitType)
		{
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		[Token(Token = "0x6001F48")]
		[Address(RVA = "0xF125F8", Offset = "0xF125F8", VA = "0xF125F8")]
		public int HitObject(int x, int y, int hitType)
		{
			return 0;
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F49")]
		[Address(RVA = "0xF12764", Offset = "0xF12764", VA = "0xF12764")]
		public void UpdatePosition(int tileId, int x, int y)
		{
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x0000F000 File Offset: 0x0000D200
		[Token(Token = "0x6001F4A")]
		[Address(RVA = "0xF127C0", Offset = "0xF127C0", VA = "0xF127C0")]
		public int AddDamage(int tileId, int damageAmount, bool updateAmount = true)
		{
			return 0;
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F4B")]
		[Address(RVA = "0xF129A4", Offset = "0xF129A4", VA = "0xF129A4")]
		private void ClearEntryData(int tileId)
		{
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F4C")]
		[Address(RVA = "0xF12898", Offset = "0xF12898", VA = "0xF12898")]
		private void SortSlots(int tileId)
		{
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F4D")]
		[Address(RVA = "0xF11DAC", Offset = "0xF11DAC", VA = "0xF11DAC")]
		public void Clear(int tileId)
		{
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F4E")]
		[Address(RVA = "0xF11E3C", Offset = "0xF11E3C", VA = "0xF11E3C")]
		public void Prune()
		{
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F4F")]
		[Address(RVA = "0xF12AA0", Offset = "0xF12AA0", VA = "0xF12AA0")]
		public void DrawFreshAnimations(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x040031D5 RID: 12757
		[Token(Token = "0x40031D5")]
		[FieldOffset(Offset = "0x0")]
		private static int lastCrack;

		// Token: 0x040031D6 RID: 12758
		[Token(Token = "0x40031D6")]
		public const int xIndex = 0;

		// Token: 0x040031D7 RID: 12759
		[Token(Token = "0x40031D7")]
		public const int yIndex = 1;

		// Token: 0x040031D8 RID: 12760
		[Token(Token = "0x40031D8")]
		public const int damageIndex = 2;

		// Token: 0x040031D9 RID: 12761
		[Token(Token = "0x40031D9")]
		public const int typeIndex = 3;

		// Token: 0x040031DA RID: 12762
		[Token(Token = "0x40031DA")]
		public const int timeToLiveIndex = 4;

		// Token: 0x040031DB RID: 12763
		[Token(Token = "0x40031DB")]
		public const int crackStyleIndex = 5;

		// Token: 0x040031DC RID: 12764
		[Token(Token = "0x40031DC")]
		public const int animationTimeElapsedIndex = 6;

		// Token: 0x040031DD RID: 12765
		[Token(Token = "0x40031DD")]
		public const int HitTileObjectCount = 7;

		// Token: 0x040031DE RID: 12766
		[Token(Token = "0x40031DE")]
		internal const int UNUSED = 0;

		// Token: 0x040031DF RID: 12767
		[Token(Token = "0x40031DF")]
		internal const int TILE = 1;

		// Token: 0x040031E0 RID: 12768
		[Token(Token = "0x40031E0")]
		internal const int WALL = 2;

		// Token: 0x040031E1 RID: 12769
		[Token(Token = "0x40031E1")]
		internal const int MAX_HITTILES = 500;

		// Token: 0x040031E2 RID: 12770
		[Token(Token = "0x40031E2")]
		internal const int TIMETOLIVE = 60;

		// Token: 0x040031E3 RID: 12771
		[Token(Token = "0x40031E3")]
		[FieldOffset(Offset = "0x4")]
		private static UnifiedRandom rand;

		// Token: 0x040031E4 RID: 12772
		[Token(Token = "0x40031E4")]
		[FieldOffset(Offset = "0x8")]
		public readonly int[] HitTileObjectData;

		// Token: 0x040031E5 RID: 12773
		[Token(Token = "0x40031E5")]
		[FieldOffset(Offset = "0xC")]
		private readonly int[] order;

		// Token: 0x040031E6 RID: 12774
		[Token(Token = "0x40031E6")]
		[FieldOffset(Offset = "0x10")]
		private int bufferLocation;
	}
}
