using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x02000933 RID: 2355
	[Token(Token = "0x2000933")]
	public class CoinLossRevengeSystem
	{
		// Token: 0x06004E9E RID: 20126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E9E")]
		[Address(RVA = "0x736000", Offset = "0x736000", VA = "0x736000")]
		public void AddMarkerFromReader(BinaryReader reader)
		{
		}

		// Token: 0x06004E9F RID: 20127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E9F")]
		[Address(RVA = "0x73636C", Offset = "0x73636C", VA = "0x73636C")]
		private void AddMarker(CoinLossRevengeSystem.RevengeMarker marker)
		{
		}

		// Token: 0x06004EA0 RID: 20128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA0")]
		[Address(RVA = "0x7364E0", Offset = "0x7364E0", VA = "0x7364E0")]
		public void DestroyMarker(int markerUniqueID)
		{
		}

		// Token: 0x06004EA1 RID: 20129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA1")]
		[Address(RVA = "0x7366D0", Offset = "0x7366D0", VA = "0x7366D0")]
		public CoinLossRevengeSystem()
		{
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA2")]
		[Address(RVA = "0x7367AC", Offset = "0x7367AC", VA = "0x7367AC")]
		public void CacheEnemy(NPC npc)
		{
		}

		// Token: 0x06004EA3 RID: 20131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA3")]
		[Address(RVA = "0x736C14", Offset = "0x736C14", VA = "0x736C14")]
		public void Reset()
		{
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA4")]
		[Address(RVA = "0x736D4C", Offset = "0x736D4C", VA = "0x736D4C")]
		public void Update()
		{
		}

		// Token: 0x06004EA5 RID: 20133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA5")]
		[Address(RVA = "0x737934", Offset = "0x737934", VA = "0x737934")]
		public void CheckRespawns()
		{
		}

		// Token: 0x06004EA6 RID: 20134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA6")]
		[Address(RVA = "0x736DF8", Offset = "0x736DF8", VA = "0x736DF8")]
		private void RemoveExpiredOrInvalidMarkers()
		{
		}

		// Token: 0x06004EA7 RID: 20135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA7")]
		[Address(RVA = "0x738CE0", Offset = "0x738CE0", VA = "0x738CE0")]
		public CoinLossRevengeSystem.RevengeMarker DrawMapIcons(SpriteBatch spriteBatch, Vector2 mapTopLeft, Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, ref string unused)
		{
			return null;
		}

		// Token: 0x06004EA8 RID: 20136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA8")]
		[Address(RVA = "0x7395D0", Offset = "0x7395D0", VA = "0x7395D0")]
		public void SendAllMarkersToPlayer(int plr)
		{
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x00024918 File Offset: 0x00022B18
		[Token(Token = "0x6004EAA")]
		[Address(RVA = "0x739974", Offset = "0x739974", VA = "0x739974")]
		private bool <RemoveExpiredOrInvalidMarkers>b__20_0(CoinLossRevengeSystem.RevengeMarker x)
		{
			return default(bool);
		}

		// Token: 0x06004EAB RID: 20139 RVA: 0x00024930 File Offset: 0x00022B30
		[Token(Token = "0x6004EAB")]
		[Address(RVA = "0x7399D8", Offset = "0x7399D8", VA = "0x7399D8")]
		private bool <RemoveExpiredOrInvalidMarkers>b__20_3(CoinLossRevengeSystem.RevengeMarker x)
		{
			return default(bool);
		}

		// Token: 0x0400931A RID: 37658
		[Token(Token = "0x400931A")]
		[FieldOffset(Offset = "0x0")]
		public static bool DisplayCaching;

		// Token: 0x0400931B RID: 37659
		[Token(Token = "0x400931B")]
		[FieldOffset(Offset = "0x4")]
		public static int MinimumCoinsForCaching;

		// Token: 0x0400931C RID: 37660
		[Token(Token = "0x400931C")]
		private const int PLAYER_BOX_WIDTH_INNER = 1968;

		// Token: 0x0400931D RID: 37661
		[Token(Token = "0x400931D")]
		private const int PLAYER_BOX_HEIGHT_INNER = 1200;

		// Token: 0x0400931E RID: 37662
		[Token(Token = "0x400931E")]
		private const int PLAYER_BOX_WIDTH_OUTER = 2608;

		// Token: 0x0400931F RID: 37663
		[Token(Token = "0x400931F")]
		private const int PLAYER_BOX_HEIGHT_OUTER = 1840;

		// Token: 0x04009320 RID: 37664
		[Token(Token = "0x4009320")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 _playerBoxSizeInner;

		// Token: 0x04009321 RID: 37665
		[Token(Token = "0x4009321")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector2 _playerBoxSizeOuter;

		// Token: 0x04009322 RID: 37666
		[Token(Token = "0x4009322")]
		[FieldOffset(Offset = "0x8")]
		private List<CoinLossRevengeSystem.RevengeMarker> _markers;

		// Token: 0x04009323 RID: 37667
		[Token(Token = "0x4009323")]
		[FieldOffset(Offset = "0xC")]
		private readonly object _markersLock;

		// Token: 0x04009324 RID: 37668
		[Token(Token = "0x4009324")]
		[FieldOffset(Offset = "0x10")]
		private int _gameTime;

		// Token: 0x02000934 RID: 2356
		[Token(Token = "0x2000934")]
		public class RevengeMarker
		{
			// Token: 0x06004EAC RID: 20140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EAC")]
			[Address(RVA = "0x738730", Offset = "0x738730", VA = "0x738730")]
			public void SetToExpire()
			{
			}

			// Token: 0x17000974 RID: 2420
			// (get) Token: 0x06004EAD RID: 20141 RVA: 0x00024948 File Offset: 0x00022B48
			[Token(Token = "0x17000974")]
			public bool RespawnAttemptLocked
			{
				[Token(Token = "0x6004EAD")]
				[Address(RVA = "0x739A14", Offset = "0x739A14", VA = "0x739A14")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06004EAE RID: 20142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EAE")]
			[Address(RVA = "0x739A1C", Offset = "0x739A1C", VA = "0x739A1C")]
			public void SetRespawnAttemptLock(bool state)
			{
			}

			// Token: 0x06004EAF RID: 20143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EAF")]
			[Address(RVA = "0x7361DC", Offset = "0x7361DC", VA = "0x7361DC")]
			public RevengeMarker(Vector2 coords, int npcNetId, float npcHPPercent, int npcType, int npcAiStyle, int coinValue, float baseValue, bool spawnedFromStatue, int gameTime, int uniqueID = -1)
			{
			}

			// Token: 0x06004EB0 RID: 20144 RVA: 0x00024960 File Offset: 0x00022B60
			[Token(Token = "0x6004EB0")]
			[Address(RVA = "0x739CC8", Offset = "0x739CC8", VA = "0x739CC8")]
			public bool IsInvalid()
			{
				return default(bool);
			}

			// Token: 0x06004EB1 RID: 20145 RVA: 0x00024978 File Offset: 0x00022B78
			[Token(Token = "0x6004EB1")]
			[Address(RVA = "0x7399B0", Offset = "0x7399B0", VA = "0x7399B0")]
			public bool IsExpired(int gameTime)
			{
				return default(bool);
			}

			// Token: 0x06004EB2 RID: 20146 RVA: 0x00024990 File Offset: 0x00022B90
			[Token(Token = "0x6004EB2")]
			[Address(RVA = "0x739A24", Offset = "0x739A24", VA = "0x739A24")]
			private int CalculateExpirationTime(int gameCacheTime, int coinValue)
			{
				return 0;
			}

			// Token: 0x06004EB3 RID: 20147 RVA: 0x000249A8 File Offset: 0x00022BA8
			[Token(Token = "0x6004EB3")]
			[Address(RVA = "0x7383F8", Offset = "0x7383F8", VA = "0x7383F8")]
			public bool Intersects(Rectangle rectInner, Rectangle rectOuter)
			{
				return default(bool);
			}

			// Token: 0x06004EB4 RID: 20148 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EB4")]
			[Address(RVA = "0x73873C", Offset = "0x73873C", VA = "0x73873C")]
			public void SpawnEnemy()
			{
			}

			// Token: 0x06004EB5 RID: 20149 RVA: 0x000249C0 File Offset: 0x00022BC0
			[Token(Token = "0x6004EB5")]
			[Address(RVA = "0x7384A8", Offset = "0x7384A8", VA = "0x7384A8")]
			public bool WouldNPCBeDiscouraged(Player playerTarget)
			{
				return default(bool);
			}

			// Token: 0x06004EB6 RID: 20150 RVA: 0x000249D8 File Offset: 0x00022BD8
			[Token(Token = "0x6004EB6")]
			[Address(RVA = "0x738FA8", Offset = "0x738FA8", VA = "0x738FA8")]
			public bool DrawMapIcon(SpriteBatch spriteBatch, Vector2 mapTopLeft, Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, int gameTime)
			{
				return default(bool);
			}

			// Token: 0x06004EB7 RID: 20151 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EB7")]
			[Address(RVA = "0x739F64", Offset = "0x739F64", VA = "0x739F64")]
			public void UseMouseOver(SpriteBatch spriteBatch, ref string mouseTextString, float drawScale = 1f)
			{
			}

			// Token: 0x17000975 RID: 2421
			// (get) Token: 0x06004EB8 RID: 20152 RVA: 0x000249F0 File Offset: 0x00022BF0
			[Token(Token = "0x17000975")]
			public int UniqueID
			{
				[Token(Token = "0x6004EB8")]
				[Address(RVA = "0x73A190", Offset = "0x73A190", VA = "0x73A190")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06004EB9 RID: 20153 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EB9")]
			[Address(RVA = "0x73A198", Offset = "0x73A198", VA = "0x73A198")]
			public void WriteSelfTo(BinaryWriter writer)
			{
			}

			// Token: 0x04009325 RID: 37669
			[Token(Token = "0x4009325")]
			[FieldOffset(Offset = "0x0")]
			private static int _uniqueIDCounter;

			// Token: 0x04009326 RID: 37670
			[Token(Token = "0x4009326")]
			[FieldOffset(Offset = "0x4")]
			private static readonly int _expirationCompCopper;

			// Token: 0x04009327 RID: 37671
			[Token(Token = "0x4009327")]
			[FieldOffset(Offset = "0x8")]
			private static readonly int _expirationCompSilver;

			// Token: 0x04009328 RID: 37672
			[Token(Token = "0x4009328")]
			[FieldOffset(Offset = "0xC")]
			private static readonly int _expirationCompGold;

			// Token: 0x04009329 RID: 37673
			[Token(Token = "0x4009329")]
			[FieldOffset(Offset = "0x10")]
			private static readonly int _expirationCompPlat;

			// Token: 0x0400932A RID: 37674
			[Token(Token = "0x400932A")]
			private const int ONE_MINUTE = 3600;

			// Token: 0x0400932B RID: 37675
			[Token(Token = "0x400932B")]
			private const int ENEMY_BOX_WIDTH = 2160;

			// Token: 0x0400932C RID: 37676
			[Token(Token = "0x400932C")]
			private const int ENEMY_BOX_HEIGHT = 1440;

			// Token: 0x0400932D RID: 37677
			[Token(Token = "0x400932D")]
			[FieldOffset(Offset = "0x14")]
			public static readonly Vector2 EnemyBoxSize;

			// Token: 0x0400932E RID: 37678
			[Token(Token = "0x400932E")]
			[FieldOffset(Offset = "0x8")]
			private readonly Vector2 _location;

			// Token: 0x0400932F RID: 37679
			[Token(Token = "0x400932F")]
			[FieldOffset(Offset = "0x10")]
			private readonly Rectangle _hitbox;

			// Token: 0x04009330 RID: 37680
			[Token(Token = "0x4009330")]
			[FieldOffset(Offset = "0x20")]
			private readonly int _npcNetID;

			// Token: 0x04009331 RID: 37681
			[Token(Token = "0x4009331")]
			[FieldOffset(Offset = "0x24")]
			private readonly float _npcHPPercent;

			// Token: 0x04009332 RID: 37682
			[Token(Token = "0x4009332")]
			[FieldOffset(Offset = "0x28")]
			private readonly float _baseValue;

			// Token: 0x04009333 RID: 37683
			[Token(Token = "0x4009333")]
			[FieldOffset(Offset = "0x2C")]
			private readonly int _coinsValue;

			// Token: 0x04009334 RID: 37684
			[Token(Token = "0x4009334")]
			[FieldOffset(Offset = "0x30")]
			private readonly int _npcTypeAgainstDiscouragement;

			// Token: 0x04009335 RID: 37685
			[Token(Token = "0x4009335")]
			[FieldOffset(Offset = "0x34")]
			private readonly int _npcAIStyleAgainstDiscouragement;

			// Token: 0x04009336 RID: 37686
			[Token(Token = "0x4009336")]
			[FieldOffset(Offset = "0x38")]
			private readonly int _expirationTime;

			// Token: 0x04009337 RID: 37687
			[Token(Token = "0x4009337")]
			[FieldOffset(Offset = "0x3C")]
			private readonly bool _spawnedFromStatue;

			// Token: 0x04009338 RID: 37688
			[Token(Token = "0x4009338")]
			[FieldOffset(Offset = "0x40")]
			private readonly int _uniqueID;

			// Token: 0x04009339 RID: 37689
			[Token(Token = "0x4009339")]
			[FieldOffset(Offset = "0x44")]
			private bool _forceExpire;

			// Token: 0x0400933A RID: 37690
			[Token(Token = "0x400933A")]
			[FieldOffset(Offset = "0x45")]
			private bool _attemptedRespawn;
		}

		// Token: 0x02000935 RID: 2357
		[Token(Token = "0x2000935")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06004EBB RID: 20155 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EBB")]
			[Address(RVA = "0x7366C8", Offset = "0x7366C8", VA = "0x7366C8")]
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x06004EBC RID: 20156 RVA: 0x00024A08 File Offset: 0x00022C08
			[Token(Token = "0x6004EBC")]
			[Address(RVA = "0x73A43C", Offset = "0x73A43C", VA = "0x73A43C")]
			internal bool <DestroyMarker>b__0(CoinLossRevengeSystem.RevengeMarker x)
			{
				return default(bool);
			}

			// Token: 0x0400933B RID: 37691
			[Token(Token = "0x400933B")]
			[FieldOffset(Offset = "0x8")]
			public int markerUniqueID;
		}

		// Token: 0x02000936 RID: 2358
		[Token(Token = "0x2000936")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004EBE RID: 20158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EBE")]
			[Address(RVA = "0x73A4E0", Offset = "0x73A4E0", VA = "0x73A4E0")]
			public <>c()
			{
			}

			// Token: 0x06004EBF RID: 20159 RVA: 0x00024A20 File Offset: 0x00022C20
			[Token(Token = "0x6004EBF")]
			[Address(RVA = "0x73A4E8", Offset = "0x73A4E8", VA = "0x73A4E8")]
			internal bool <RemoveExpiredOrInvalidMarkers>b__20_1(CoinLossRevengeSystem.RevengeMarker x)
			{
				return default(bool);
			}

			// Token: 0x06004EC0 RID: 20160 RVA: 0x00024A38 File Offset: 0x00022C38
			[Token(Token = "0x6004EC0")]
			[Address(RVA = "0x73A508", Offset = "0x73A508", VA = "0x73A508")]
			internal bool <RemoveExpiredOrInvalidMarkers>b__20_2(CoinLossRevengeSystem.RevengeMarker x)
			{
				return default(bool);
			}

			// Token: 0x0400933C RID: 37692
			[Token(Token = "0x400933C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly CoinLossRevengeSystem.<>c <>9;

			// Token: 0x0400933D RID: 37693
			[Token(Token = "0x400933D")]
			[FieldOffset(Offset = "0x4")]
			public static Func<CoinLossRevengeSystem.RevengeMarker, bool> <>9__20_1;

			// Token: 0x0400933E RID: 37694
			[Token(Token = "0x400933E")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<CoinLossRevengeSystem.RevengeMarker> <>9__20_2;
		}
	}
}
