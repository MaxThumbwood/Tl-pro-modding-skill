using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.FishDropRules;
using Terraria.GameContent.Tile_Entities;
using Terraria.WorldBuilding;

namespace Terraria
{
	// Token: 0x020004A5 RID: 1189
	[Token(Token = "0x20004A5")]
	public class Projectile : Entity
	{
		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000605")]
		public string Name
		{
			[Token(Token = "0x6002CDB")]
			[Address(RVA = "0x16FF0A8", Offset = "0x16FF0A8", VA = "0x16FF0A8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x00015B10 File Offset: 0x00013D10
		[Token(Token = "0x6002CDC")]
		[Address(RVA = "0x16FF130", Offset = "0x16FF130", VA = "0x16FF130")]
		public static bool IsNPCIndexImmuneToProjectileType(int projectileType, int npcIndex)
		{
			return default(bool);
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CDD")]
		[Address(RVA = "0x16FF248", Offset = "0x16FF248", VA = "0x16FF248")]
		public static void ResetNPCSlotData(int npcIndex)
		{
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CDE")]
		[Address(RVA = "0x16FF3A4", Offset = "0x16FF3A4", VA = "0x16FF3A4")]
		public void ResetStaticImmunityMatching(long expectedTime)
		{
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x00015B28 File Offset: 0x00013D28
		[Token(Token = "0x6002CDF")]
		[Address(RVA = "0x16FF4AC", Offset = "0x16FF4AC", VA = "0x16FF4AC")]
		public static bool TryLookup(ProjectileKey key, out Projectile proj)
		{
			return default(bool);
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CE0")]
		[Address(RVA = "0x16FF5E0", Offset = "0x16FF5E0", VA = "0x16FF5E0")]
		public static void ClearAll()
		{
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06002CE1 RID: 11489 RVA: 0x00015B40 File Offset: 0x00013D40
		[Token(Token = "0x17000606")]
		public bool WipableTurret
		{
			[Token(Token = "0x6002CE1")]
			[Address(RVA = "0x16FF8F0", Offset = "0x16FF8F0", VA = "0x16FF8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x00015B58 File Offset: 0x00013D58
		[Token(Token = "0x6002CE2")]
		[Address(RVA = "0x16FFA04", Offset = "0x16FFA04", VA = "0x16FFA04")]
		public bool TurretShouldPersist()
		{
			return default(bool);
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x00015B70 File Offset: 0x00013D70
		// (set) Token: 0x06002CE4 RID: 11492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000607")]
		public float Opacity
		{
			[Token(Token = "0x6002CE3")]
			[Address(RVA = "0x16FFAA0", Offset = "0x16FFAA0", VA = "0x16FFAA0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002CE4")]
			[Address(RVA = "0x16FFAC4", Offset = "0x16FFAC4", VA = "0x16FFAC4")]
			set
			{
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x00015B88 File Offset: 0x00013D88
		[Token(Token = "0x17000608")]
		public int IndexForVisuals
		{
			[Token(Token = "0x6002CE5")]
			[Address(RVA = "0x16FFB24", Offset = "0x16FFB24", VA = "0x16FFB24")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x00015BA0 File Offset: 0x00013DA0
		// (set) Token: 0x06002CE7 RID: 11495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000609")]
		public int MaxUpdates
		{
			[Token(Token = "0x6002CE6")]
			[Address(RVA = "0x16FFB30", Offset = "0x16FFB30", VA = "0x16FFB30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002CE7")]
			[Address(RVA = "0x16FFB3C", Offset = "0x16FFB3C", VA = "0x16FFB3C")]
			set
			{
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060A")]
		public NPC OwnerMinionAttackTargetNPC
		{
			[Token(Token = "0x6002CE8")]
			[Address(RVA = "0x16FFB48", Offset = "0x16FFB48", VA = "0x16FFB48")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CE9")]
		[Address(RVA = "0x16FFC48", Offset = "0x16FFC48", VA = "0x16FFC48")]
		private void TransformType(int typeToChangeInto)
		{
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CEA")]
		[Address(RVA = "0x160EEE4", Offset = "0x160EEE4", VA = "0x160EEE4")]
		public void SetDefaults(int Type)
		{
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CEB")]
		[Address(RVA = "0x16FFC50", Offset = "0x16FFC50", VA = "0x16FFC50")]
		private void UseGroupStaticImmunity(int Type)
		{
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CEC")]
		[Address(RVA = "0x16FFC68", Offset = "0x16FFC68", VA = "0x16FFC68")]
		private void ApplyGemStaffStats()
		{
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CED")]
		[Address(RVA = "0x16FFC88", Offset = "0x16FFC88", VA = "0x16FFC88")]
		public void DefaultToSpray()
		{
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CEE")]
		[Address(RVA = "0x16FFCCC", Offset = "0x16FFCCC", VA = "0x16FFCCC")]
		public void DefaultToWhip()
		{
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CEF")]
		[Address(RVA = "0x16FFD1C", Offset = "0x16FFD1C", VA = "0x16FFD1C")]
		public void DefaultToSpear()
		{
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CF0")]
		[Address(RVA = "0x16FFD54", Offset = "0x16FFD54", VA = "0x16FFD54")]
		public void DefaultToDrillOrChainsaw()
		{
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CF1")]
		[Address(RVA = "0x16FFD8C", Offset = "0x16FFD8C", VA = "0x16FFD8C")]
		public void DefaultToKite()
		{
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CF2")]
		[Address(RVA = "0x16FFDB4", Offset = "0x16FFDB4", VA = "0x16FFDB4")]
		public void DefaultToFlail()
		{
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CF3")]
		[Address(RVA = "0x16FFDE8", Offset = "0x16FFDE8", VA = "0x16FFDE8")]
		public void DefaultToYoyo()
		{
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CF4")]
		[Address(RVA = "0x16FFE10", Offset = "0x16FFE10", VA = "0x16FFE10")]
		public void DefaultToShortsword()
		{
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x00015BB8 File Offset: 0x00013DB8
		[Token(Token = "0x6002CF5")]
		[Address(RVA = "0x16FFE60", Offset = "0x16FFE60", VA = "0x16FFE60")]
		public static int GetNextSlot()
		{
			return 0;
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x00015BD0 File Offset: 0x00013DD0
		[Token(Token = "0x6002CF6")]
		[Address(RVA = "0x16FFF08", Offset = "0x16FFF08", VA = "0x16FFF08")]
		public static int NewProjectile(IEntitySource spawnSource, Vector2 position, Vector2 velocity, int Type, int Damage, float KnockBack, int Owner = -1, float ai0 = 0f, float ai1 = 0f, float ai2 = 0f, [Optional] NewProjectileModifier modifer)
		{
			return 0;
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x00015BE8 File Offset: 0x00013DE8
		[Token(Token = "0x6002CF7")]
		[Address(RVA = "0x1701994", Offset = "0x1701994", VA = "0x1701994")]
		public static int FindOldestProjectile()
		{
			return 0;
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF8")]
		[Address(RVA = "0x1701AD4", Offset = "0x1701AD4", VA = "0x1701AD4")]
		internal static Projectile NewProjectileSetup([Optional] ProjectileKey key)
		{
			return null;
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x00015C00 File Offset: 0x00013E00
		[Token(Token = "0x6002CF9")]
		[Address(RVA = "0x16FFFF0", Offset = "0x16FFFF0", VA = "0x16FFFF0")]
		public static int NewProjectile(IEntitySource spawnSource, float X, float Y, float SpeedX, float SpeedY, int Type, int Damage, float KnockBack, int Owner = -1, float ai0 = 0f, float ai1 = 0f, float ai2 = 0f, [Optional] NewProjectileModifier modifer)
		{
			return 0;
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFA")]
		[Address(RVA = "0x1701FE0", Offset = "0x1701FE0", VA = "0x1701FE0")]
		private void FindBannerToAssociateTo(IEntitySource spawnSource)
		{
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFB")]
		[Address(RVA = "0x1701D1C", Offset = "0x1701D1C", VA = "0x1701D1C")]
		private void ApplyStatsFromSource(IEntitySource spawnSource)
		{
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFC")]
		[Address(RVA = "0x1702174", Offset = "0x1702174", VA = "0x1702174")]
		private void TrackMinionSpawnSource(IEntitySource spawnSource)
		{
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x00015C18 File Offset: 0x00013E18
		[Token(Token = "0x6002CFD")]
		[Address(RVA = "0x170240C", Offset = "0x170240C", VA = "0x170240C")]
		public static Color GetGolfTrailColor(Projectile proj)
		{
			return default(Color);
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFE")]
		[Address(RVA = "0x17026B0", Offset = "0x17026B0", VA = "0x17026B0")]
		public void StatusNPC(int i)
		{
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFF")]
		[Address(RVA = "0x1706C70", Offset = "0x1706C70", VA = "0x1706C70")]
		private void ApplyWhipDebuffs(NPC targetNPC)
		{
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D00")]
		[Address(RVA = "0x1706DE8", Offset = "0x1706DE8", VA = "0x1706DE8")]
		public void StatusPvP(int i)
		{
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D01")]
		[Address(RVA = "0x1708E6C", Offset = "0x1708E6C", VA = "0x1708E6C")]
		public void ghostHurt(int dmg, Vector2 Position, Entity victim)
		{
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D02")]
		[Address(RVA = "0x17096BC", Offset = "0x17096BC", VA = "0x17096BC")]
		public void ghostHeal(int dmg, Vector2 Position, Entity victim)
		{
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D03")]
		[Address(RVA = "0x1709C28", Offset = "0x1709C28", VA = "0x1709C28")]
		public void vampireHeal(int dmg, Vector2 Position, Entity victim)
		{
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D04")]
		[Address(RVA = "0x1709E78", Offset = "0x1709E78", VA = "0x1709E78")]
		public void StatusPlayer(Player player)
		{
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D05")]
		[Address(RVA = "0x1708DFC", Offset = "0x1708DFC", VA = "0x1708DFC")]
		public void ApplyBuffTo(Player player, int buffType, int buffTime)
		{
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x00015C30 File Offset: 0x00013E30
		[Token(Token = "0x6002D06")]
		[Address(RVA = "0x170BCF0", Offset = "0x170BCF0", VA = "0x170BCF0")]
		public bool CanHitWithMeleeWeapon(Entity ent)
		{
			return default(bool);
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x00015C48 File Offset: 0x00013E48
		[Token(Token = "0x6002D07")]
		[Address(RVA = "0x170C618", Offset = "0x170C618", VA = "0x170C618")]
		public bool CanHitWithOwnBody(Entity ent)
		{
			return default(bool);
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D08")]
		[Address(RVA = "0x170D0E8", Offset = "0x170D0E8", VA = "0x170D0E8")]
		public void Damage()
		{
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x00015C60 File Offset: 0x00013E60
		[Token(Token = "0x6002D09")]
		[Address(RVA = "0x171EE1C", Offset = "0x171EE1C", VA = "0x171EE1C")]
		private bool EverySomeYoyoHits(int amount, bool countUp = true)
		{
			return default(bool);
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D0A")]
		[Address(RVA = "0x17104E8", Offset = "0x17104E8", VA = "0x17104E8")]
		private void Damage_PVE(ref Rectangle projRectangle, float projectileSpecificDamageMultiplier)
		{
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D0B")]
		[Address(RVA = "0x1725AD4", Offset = "0x1725AD4", VA = "0x1725AD4")]
		public static void TryMakingSnappingStoneStrike(IEntitySource entitySource, Entity targeter, int owner, NPC victim, ref int dmg, int snappingType)
		{
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D0C")]
		[Address(RVA = "0x1726B60", Offset = "0x1726B60", VA = "0x1726B60")]
		private void SpawnHitVisuals(Entity target)
		{
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x00015C78 File Offset: 0x00013E78
		[Token(Token = "0x6002D0D")]
		[Address(RVA = "0x170FE98", Offset = "0x170FE98", VA = "0x170FE98")]
		private float Damage_GetProjectileSpecificDamageMultiplier()
		{
			return 0f;
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D0E")]
		[Address(RVA = "0x171D300", Offset = "0x171D300", VA = "0x171D300")]
		private void Damage_PVP(ref Rectangle projRectangle, float projectileSpecificDamageMultiplier)
		{
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D0F")]
		[Address(RVA = "0x170F898", Offset = "0x170F898", VA = "0x170F898")]
		private void Damage_TryUsingPowders(ref Rectangle projRectangle)
		{
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D10")]
		[Address(RVA = "0x171DE40", Offset = "0x171DE40", VA = "0x171DE40")]
		private void Damage_EVP(ref Rectangle projRectangle)
		{
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06002D11 RID: 11537 RVA: 0x00015C90 File Offset: 0x00013E90
		[Token(Token = "0x1700060B")]
		public bool OwnedBySomeone
		{
			[Token(Token = "0x6002D11")]
			[Address(RVA = "0x171EEC4", Offset = "0x171EEC4", VA = "0x171EEC4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D12")]
		[Address(RVA = "0x1727B78", Offset = "0x1727B78", VA = "0x1727B78")]
		public static void SpawnMoonLordWhipProc(Projectile parent, NPC targetNPC, int procDamage, int aiCounter)
		{
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D13")]
		[Address(RVA = "0x1727454", Offset = "0x1727454", VA = "0x1727454")]
		public void ConstellationWhip_SpawnConstellationStarsTowards(NPC targetNPC, int calcDamage)
		{
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00015CA8 File Offset: 0x00013EA8
		[Token(Token = "0x6002D14")]
		[Address(RVA = "0x170DF7C", Offset = "0x170DF7C", VA = "0x170DF7C")]
		public Rectangle Damage_GetHitbox()
		{
			return default(Rectangle);
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D15")]
		[Address(RVA = "0x172A210", Offset = "0x172A210", VA = "0x172A210")]
		private void SelfHurtPlayers()
		{
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x00015CC0 File Offset: 0x00013EC0
		[Token(Token = "0x6002D16")]
		[Address(RVA = "0x172A1BC", Offset = "0x172A1BC", VA = "0x172A1BC")]
		public bool IsDamageDodgeable()
		{
			return default(bool);
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D17")]
		[Address(RVA = "0x1728274", Offset = "0x1728274", VA = "0x1728274")]
		public static void KillOldestJavelin(int protectedProjectileIndex, int projectileType, int targetNPCIndex, Point[] bufferForScan, List<int> projectileList)
		{
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x00015CD8 File Offset: 0x00013ED8
		[Token(Token = "0x6002D18")]
		[Address(RVA = "0x1725404", Offset = "0x1725404", VA = "0x1725404")]
		private int CountEnemiesWhoAreImmuneToMeRightNow(int cap)
		{
			return 0;
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D19")]
		[Address(RVA = "0x1729D6C", Offset = "0x1729D6C", VA = "0x1729D6C")]
		private static void EmitBlackLightningParticles(Vector2 position)
		{
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D1A")]
		[Address(RVA = "0x1727280", Offset = "0x1727280", VA = "0x1727280")]
		private void TryDoingOnHitEffects(Entity entity)
		{
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D1B")]
		[Address(RVA = "0x1729608", Offset = "0x1729608", VA = "0x1729608")]
		private void SummonSuperStarSlash(Vector2 target)
		{
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D1C")]
		[Address(RVA = "0x1728E90", Offset = "0x1728E90", VA = "0x1728E90")]
		private void SummonMonkGhast()
		{
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D1D")]
		[Address(RVA = "0x17259B8", Offset = "0x17259B8", VA = "0x17259B8")]
		private void ModifyStellarTuneDamage(ref int damage)
		{
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D1E")]
		[Address(RVA = "0x170E720", Offset = "0x170E720", VA = "0x170E720")]
		private void CutTiles()
		{
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D1F")]
		[Address(RVA = "0x172AB60", Offset = "0x172AB60", VA = "0x172AB60")]
		private void CutTilesAt(Vector2 boxPosition, int boxWidth, int boxHeight)
		{
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x00015CF0 File Offset: 0x00013EF0
		[Token(Token = "0x6002D20")]
		[Address(RVA = "0x172A624", Offset = "0x172A624", VA = "0x172A624")]
		private bool CanCutTiles()
		{
			return default(bool);
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x00015D08 File Offset: 0x00013F08
		[Token(Token = "0x6002D21")]
		[Address(RVA = "0x171EFB4", Offset = "0x171EFB4", VA = "0x171EFB4")]
		public bool Colliding(Rectangle myRect, Rectangle targetRect)
		{
			return default(bool);
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x00015D20 File Offset: 0x00013F20
		[Token(Token = "0x6002D22")]
		[Address(RVA = "0x172B8A4", Offset = "0x172B8A4", VA = "0x172B8A4")]
		private bool StormLightningCollisionCheck(Rectangle targetRect)
		{
			return default(bool);
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x00015D38 File Offset: 0x00013F38
		[Token(Token = "0x6002D23")]
		[Address(RVA = "0x1729E08", Offset = "0x1729E08", VA = "0x1729E08")]
		private Rectangle GetStormLightningExplosionRect()
		{
			return default(Rectangle);
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x00015D50 File Offset: 0x00013F50
		[Token(Token = "0x6002D24")]
		[Address(RVA = "0x1729F38", Offset = "0x1729F38", VA = "0x1729F38")]
		private bool StormLightningLiquidCollisionCheck(Vector2 targetCenter)
		{
			return default(bool);
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D25")]
		[Address(RVA = "0x172BAAC", Offset = "0x172BAAC", VA = "0x172BAAC")]
		public void ProjLight()
		{
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x00015D68 File Offset: 0x00013F68
		[Token(Token = "0x6002D26")]
		[Address(RVA = "0x172D2B8", Offset = "0x172D2B8", VA = "0x172D2B8")]
		public Rectangle getRect()
		{
			return default(Rectangle);
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D27")]
		[Address(RVA = "0x172D31C", Offset = "0x172D31C", VA = "0x172D31C")]
		public void Update(int i)
		{
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06002D28 RID: 11560 RVA: 0x00015D80 File Offset: 0x00013F80
		[Token(Token = "0x1700060C")]
		public Point NetSectionCoordinates
		{
			[Token(Token = "0x6002D28")]
			[Address(RVA = "0x173E138", Offset = "0x173E138", VA = "0x173E138")]
			get
			{
				return default(Point);
			}
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D29")]
		[Address(RVA = "0x173DF58", Offset = "0x173DF58", VA = "0x173DF58")]
		private void RecheckSectionsForSkippedUpdates()
		{
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2A")]
		[Address(RVA = "0x172FD2C", Offset = "0x172FD2C", VA = "0x172FD2C")]
		public void DecrementLocalImmuneTimeCounters()
		{
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x00015D98 File Offset: 0x00013F98
		[Token(Token = "0x6002D2B")]
		[Address(RVA = "0x173DE5C", Offset = "0x173DE5C", VA = "0x173DE5C")]
		private bool AutomaticallyChangesDirection()
		{
			return default(bool);
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2C")]
		[Address(RVA = "0x172FDD0", Offset = "0x172FDD0", VA = "0x172FDD0")]
		private void UpdateEnchantmentVisuals()
		{
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2D")]
		[Address(RVA = "0x173E214", Offset = "0x173E214", VA = "0x173E214")]
		public void EmitEnchantmentVisualsAt(Vector2 boxPosition, int boxWidth, int boxHeight)
		{
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2E")]
		[Address(RVA = "0x1731AA0", Offset = "0x1731AA0", VA = "0x1731AA0")]
		public void HandleMovement(Vector2 wetVelocity)
		{
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2F")]
		[Address(RVA = "0x1740044", Offset = "0x1740044", VA = "0x1740044")]
		public void GetCollisionParams(out Vector2 resizeAnchor, out int colWidth, out int colHeight)
		{
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D30")]
		[Address(RVA = "0x17439A8", Offset = "0x17439A8", VA = "0x17439A8")]
		private void RainbowBoulder_PreventSpam()
		{
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D31")]
		[Address(RVA = "0x1741DA4", Offset = "0x1741DA4", VA = "0x1741DA4")]
		private void RainbowBoulder_CheckBounce(ref Vector2 lastVelocity)
		{
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D32")]
		[Address(RVA = "0x1743BD4", Offset = "0x1743BD4", VA = "0x1743BD4")]
		private void RainbowBoulder_PerformSmartBounce()
		{
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D33")]
		[Address(RVA = "0x174403C", Offset = "0x174403C", VA = "0x174403C")]
		private void RainbowBoulder_HighlightNearbyTreasure()
		{
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D34")]
		[Address(RVA = "0x1744758", Offset = "0x1744758", VA = "0x1744758")]
		private void RainbowBoulder_GetAreas(out Player closestPlayer, out Rectangle playArea, out Rectangle closeToMe)
		{
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D35")]
		[Address(RVA = "0x17450A8", Offset = "0x17450A8", VA = "0x17450A8")]
		private void RainbowBoulder_JumpToPlayer(Player player)
		{
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D36")]
		[Address(RVA = "0x1744968", Offset = "0x1744968", VA = "0x1744968")]
		private void RainbowBoulder_JumpToEnemy(NPC npcProj)
		{
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D37")]
		[Address(RVA = "0x1745634", Offset = "0x1745634", VA = "0x1745634")]
		private void RainbowBoulder_JumpAwayFromEnemy(NPC npcProj)
		{
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D38")]
		[Address(RVA = "0x1744F78", Offset = "0x1744F78", VA = "0x1744F78")]
		private void RainbowBoulder_JumpToTreasure(Point point)
		{
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D39")]
		[Address(RVA = "0x174510C", Offset = "0x174510C", VA = "0x174510C")]
		private void RainbowBoulder_JumpToPosition(Vector2 targetPosition, Vector2 targetVelocity)
		{
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x00015DB0 File Offset: 0x00013FB0
		[Token(Token = "0x6002D3A")]
		[Address(RVA = "0x17449CC", Offset = "0x17449CC", VA = "0x17449CC")]
		private bool RainbowBoulder_GetTreasureCoords(Rectangle playArea, out Point treasureCoords)
		{
			return default(bool);
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D3B")]
		[Address(RVA = "0x172547C", Offset = "0x172547C", VA = "0x172547C")]
		private void LightDisc_Bounce(Vector2 hitPoint, Vector2 normal)
		{
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D3C")]
		[Address(RVA = "0x1745794", Offset = "0x1745794", VA = "0x1745794")]
		private void AI_149_GolfBall()
		{
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D3D")]
		[Address(RVA = "0x1745CD8", Offset = "0x1745CD8", VA = "0x1745CD8")]
		public void CheckSectionsInCaseOwnerIsWatching()
		{
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D3E")]
		[Address(RVA = "0x1742650", Offset = "0x1742650", VA = "0x1742650")]
		private void MakeBoulderOfEarthExplosion()
		{
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D3F")]
		[Address(RVA = "0x17434E8", Offset = "0x17434E8", VA = "0x17434E8")]
		private void UpdatePosition(Vector2 wetVelocity)
		{
		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D40")]
		[Address(RVA = "0x1746CEC", Offset = "0x1746CEC", VA = "0x1746CEC")]
		private void SpawnFakeFishInWater(int x, int y)
		{
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D41")]
		[Address(RVA = "0x174803C", Offset = "0x174803C", VA = "0x174803C")]
		public void FishingCheck()
		{
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x00015DC8 File Offset: 0x00013FC8
		[Token(Token = "0x6002D42")]
		[Address(RVA = "0x1748178", Offset = "0x1748178", VA = "0x1748178")]
		private bool TryBuildFishingContext(FishingContext context)
		{
			return default(bool);
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D43")]
		[Address(RVA = "0x17492CC", Offset = "0x17492CC", VA = "0x17492CC")]
		private void SetFishingCheckResults(ref FishingAttempt fisher)
		{
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D44")]
		[Address(RVA = "0x174A93C", Offset = "0x174A93C", VA = "0x174A93C")]
		private void FishingCheck_RollEnemySpawns(ref FishingAttempt fisher)
		{
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D45")]
		[Address(RVA = "0x174AC94", Offset = "0x174AC94", VA = "0x174AC94")]
		private void FishingCheck_RollItemDrop(ref FishingAttempt fisher)
		{
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D46")]
		[Address(RVA = "0x174A324", Offset = "0x174A324", VA = "0x174A324")]
		private FishingContext PrepareFishingContext(FishingContext context, FishingAttempt fisher)
		{
			return null;
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D47")]
		[Address(RVA = "0x174B030", Offset = "0x174B030", VA = "0x174B030")]
		private void FishingCheck_RollItemDropOld(ref FishingAttempt fisher)
		{
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D48")]
		[Address(RVA = "0x174A1DC", Offset = "0x174A1DC", VA = "0x174A1DC")]
		private void FishingCheck_ProbeForQuestFish(ref FishingAttempt fisher)
		{
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D49")]
		[Address(RVA = "0x1749E9C", Offset = "0x1749E9C", VA = "0x1749E9C")]
		private void FishingCheck_RollDropLevels(int fishingLevel, out bool common, out bool uncommon, out bool rare, out bool veryrare, out bool legendary, out bool crate)
		{
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D4A")]
		[Address(RVA = "0x1749940", Offset = "0x1749940", VA = "0x1749940")]
		private static void GetFishingPondState(int x, int y, out bool lava, out bool honey, out int numWaters, out int chumCount)
		{
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D4B")]
		[Address(RVA = "0x1747CE0", Offset = "0x1747CE0", VA = "0x1747CE0")]
		private static void GetFishingPondWidth(int x, int y, out int minX, out int maxX)
		{
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x00015DE0 File Offset: 0x00013FE0
		[Token(Token = "0x6002D4C")]
		[Address(RVA = "0x1725380", Offset = "0x1725380", VA = "0x1725380")]
		public bool CanBeReflected()
		{
			return default(bool);
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x00015DF8 File Offset: 0x00013FF8
		[Token(Token = "0x6002D4D")]
		[Address(RVA = "0x174D334", Offset = "0x174D334", VA = "0x174D334")]
		public Color GetConstellationColor(float alphaChannelMultiplier = 1f, float lerpToWhite = 0f, [Optional] float? rawHueOverride)
		{
			return default(Color);
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x00015E10 File Offset: 0x00014010
		[Token(Token = "0x6002D4E")]
		[Address(RVA = "0x174D518", Offset = "0x174D518", VA = "0x174D518")]
		public Color GetFairyQueenWeaponsColor(float alphaChannelMultiplier = 1f, float lerpToWhite = 0f, [Optional] float? rawHueOverride)
		{
			return default(Color);
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x00015E28 File Offset: 0x00014028
		[Token(Token = "0x6002D4F")]
		[Address(RVA = "0x174D658", Offset = "0x174D658", VA = "0x174D658")]
		public static Color GetFairyQueenWeaponsColorFull(int playerIndex, Vector2 center, float hueRaw, float alphaChannelMultiplier = 1f, float lerpToWhite = 0f, float Opacity = 1f, float luminance = 0.5f)
		{
			return default(Color);
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x00015E40 File Offset: 0x00014040
		[Token(Token = "0x6002D50")]
		[Address(RVA = "0x174F5A0", Offset = "0x174F5A0", VA = "0x174F5A0")]
		public float GetLastPrismHue(float laserIndex, ref float laserLuminance, ref float laserAlphaMultiplier)
		{
			return 0f;
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D51")]
		[Address(RVA = "0x17022B8", Offset = "0x17022B8", VA = "0x17022B8")]
		public void FinalizeProjectile()
		{
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D52")]
		[Address(RVA = "0x1751C04", Offset = "0x1751C04", VA = "0x1751C04")]
		private void FinalizeProjectile_GemStaves()
		{
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x00015E58 File Offset: 0x00014058
		[Token(Token = "0x6002D53")]
		[Address(RVA = "0x17301B4", Offset = "0x17301B4", VA = "0x17301B4")]
		public bool ShouldUseWindPhysics()
		{
			return default(bool);
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D54")]
		[Address(RVA = "0x1751DDC", Offset = "0x1751DDC", VA = "0x1751DDC")]
		private void AI_151_SuperStar()
		{
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x00015E70 File Offset: 0x00014070
		[Token(Token = "0x6002D55")]
		[Address(RVA = "0x175254C", Offset = "0x175254C", VA = "0x175254C")]
		public bool IsInterruptible(Player player)
		{
			return default(bool);
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D56")]
		[Address(RVA = "0x1752560", Offset = "0x1752560", VA = "0x1752560")]
		public void Interrupt(Player player)
		{
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D57")]
		[Address(RVA = "0x17525C4", Offset = "0x17525C4", VA = "0x17525C4")]
		public static IEntitySource GetNoneSource()
		{
			return null;
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D58")]
		[Address(RVA = "0x17525CC", Offset = "0x17525CC", VA = "0x17525CC")]
		public IEntitySource GetNPCSource_FromThis()
		{
			return null;
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D59")]
		[Address(RVA = "0x172580C", Offset = "0x172580C", VA = "0x172580C")]
		public IEntitySource GetProjectileSource_FromThis()
		{
			return null;
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5A")]
		[Address(RVA = "0x1752640", Offset = "0x1752640", VA = "0x1752640")]
		public IEntitySource GetItemSource_DropAsItem()
		{
			return null;
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5B")]
		[Address(RVA = "0x17526B4", Offset = "0x17526B4", VA = "0x17526B4")]
		public IEntitySource GetItemSource_FromThis()
		{
			return null;
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5C")]
		[Address(RVA = "0x170962C", Offset = "0x170962C", VA = "0x170962C")]
		public IEntitySource GetProjectileSource_OnHit(Entity victim, int projectileSourceId)
		{
			return null;
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5D")]
		[Address(RVA = "0x17273C4", Offset = "0x17273C4", VA = "0x17273C4")]
		public IEntitySource GetItemSource_OnHit(Entity victim, int itemSourceId)
		{
			return null;
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5E")]
		[Address(RVA = "0x1752728", Offset = "0x1752728", VA = "0x1752728")]
		public static IEntitySource InheritSource(Projectile projectile)
		{
			return null;
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D5F")]
		[Address(RVA = "0x17527B0", Offset = "0x17527B0", VA = "0x17527B0")]
		private void AI_152_SuperStarSlash()
		{
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D60")]
		[Address(RVA = "0x1753684", Offset = "0x1753684", VA = "0x1753684")]
		public void Resize(int newWidth, int newHeight)
		{
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D61")]
		[Address(RVA = "0x1730448", Offset = "0x1730448", VA = "0x1730448")]
		private void Shimmer()
		{
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D62")]
		[Address(RVA = "0x17536D0", Offset = "0x17536D0", VA = "0x17536D0")]
		public void AI_AdjustPlayerItemRotationToFaceProjectile(int itemIDPlayerNeedsToBeHolding = -1, float minSpeed = 0f, bool ignoreAlphaCheck = false)
		{
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x00015E88 File Offset: 0x00014088
		[Token(Token = "0x6002D63")]
		[Address(RVA = "0x1753968", Offset = "0x1753968", VA = "0x1753968")]
		private bool AI_DisplayDoll_ItemDisplay(Player doll, Item weapon, TEDisplayDoll.DisplayDollPose pose, float rotationAddon = 0f)
		{
			return default(bool);
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D64")]
		[Address(RVA = "0x1753D00", Offset = "0x1753D00", VA = "0x1753D00")]
		private void AI_DisplayDoll_Reset(Player doll)
		{
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D65")]
		[Address(RVA = "0x1753D68", Offset = "0x1753D68", VA = "0x1753D68")]
		public void AI_DisplayDoll(Player doll, Item weapon, TEDisplayDoll.DisplayDollPose pose, out bool botherDrawing)
		{
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D66")]
		[Address(RVA = "0x161AC48", Offset = "0x161AC48", VA = "0x161AC48")]
		public void AI()
		{
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D67")]
		[Address(RVA = "0x1757E48", Offset = "0x1757E48", VA = "0x1757E48")]
		private void AI_210_YoyoShots()
		{
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D68")]
		[Address(RVA = "0x1758ABC", Offset = "0x1758ABC", VA = "0x1758ABC")]
		private void AI_208_GlacierFangShot()
		{
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D69")]
		[Address(RVA = "0x175A2CC", Offset = "0x175A2CC", VA = "0x175A2CC")]
		private void AI_123_FloatingTurrets()
		{
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D6A")]
		[Address(RVA = "0x175DEA8", Offset = "0x175DEA8", VA = "0x175DEA8")]
		private void AI_053_FrostHydra()
		{
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D6B")]
		[Address(RVA = "0x175F564", Offset = "0x175F564", VA = "0x175F564")]
		private void AI_207_SnappingStone()
		{
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x00015EA0 File Offset: 0x000140A0
		[Token(Token = "0x6002D6C")]
		[Address(RVA = "0x175F568", Offset = "0x175F568", VA = "0x175F568")]
		private bool AI_206_CustomEliminationCheck_Forbidden(Entity otherEntity, int currentTarget)
		{
			return default(bool);
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D6D")]
		[Address(RVA = "0x175F648", Offset = "0x175F648", VA = "0x175F648")]
		private void AI_206_ForbiddenMinion()
		{
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D6E")]
		[Address(RVA = "0x1760D80", Offset = "0x1760D80", VA = "0x1760D80")]
		private void AI_029_GemStaffs()
		{
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D6F")]
		[Address(RVA = "0x1762A78", Offset = "0x1762A78", VA = "0x1762A78")]
		private void AI_029_GemStaffs_ActuallyGemStaffs()
		{
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D70")]
		[Address(RVA = "0x1763B94", Offset = "0x1763B94", VA = "0x1763B94")]
		private void AI_040_LeafBlower()
		{
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D71")]
		[Address(RVA = "0x1764544", Offset = "0x1764544", VA = "0x1764544")]
		private void AI_205_RemoteControlCar()
		{
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D72")]
		[Address(RVA = "0x1766C40", Offset = "0x1766C40", VA = "0x1766C40")]
		private void AI_204_Digtoise()
		{
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D73")]
		[Address(RVA = "0x176865C", Offset = "0x176865C", VA = "0x176865C")]
		private void DoPalAppearEffect(Player master, bool withParticles)
		{
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x00015EB8 File Offset: 0x000140B8
		[Token(Token = "0x6002D74")]
		[Address(RVA = "0x1768AE8", Offset = "0x1768AE8", VA = "0x1768AE8")]
		public PlayerPettingInfo GetPettingInfo(Player player)
		{
			return default(PlayerPettingInfo);
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D75")]
		[Address(RVA = "0x1768C40", Offset = "0x1768C40", VA = "0x1768C40")]
		private void AI_003_Boomerang()
		{
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D76")]
		[Address(RVA = "0x176D83C", Offset = "0x176D83C", VA = "0x176D83C")]
		private void AI_203_StormLightning()
		{
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x00015ED0 File Offset: 0x000140D0
		[Token(Token = "0x6002D77")]
		[Address(RVA = "0x1729ED0", Offset = "0x1729ED0", VA = "0x1729ED0")]
		public Color AI_203_GetLightningColor()
		{
			return default(Color);
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x00015EE8 File Offset: 0x000140E8
		[Token(Token = "0x6002D78")]
		[Address(RVA = "0x176F7E0", Offset = "0x176F7E0", VA = "0x176F7E0")]
		public static Color GetLightningColor(int type)
		{
			return default(Color);
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00015F00 File Offset: 0x00014100
		[Token(Token = "0x6002D79")]
		[Address(RVA = "0x176F768", Offset = "0x176F768", VA = "0x176F768")]
		private bool AI_203_TooFar(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x00015F18 File Offset: 0x00014118
		[Token(Token = "0x6002D7A")]
		[Address(RVA = "0x176F7CC", Offset = "0x176F7CC", VA = "0x176F7CC")]
		private int PackTargetIndex(int npcIndex = -1, int playerIndex = -1)
		{
			return 0;
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7B")]
		[Address(RVA = "0x176F6F4", Offset = "0x176F6F4", VA = "0x176F6F4")]
		private void UnpackTargetIndex(float aiValue, out int npcIndex, out int playerIndex)
		{
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7C")]
		[Address(RVA = "0x176F924", Offset = "0x176F924", VA = "0x176F924")]
		private void AI_202_TorchGodHelper()
		{
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7D")]
		[Address(RVA = "0x1770378", Offset = "0x1770378", VA = "0x1770378")]
		private void AI_201_ThrownMelee()
		{
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7E")]
		[Address(RVA = "0x17705E8", Offset = "0x17705E8", VA = "0x17705E8")]
		private void AI_200_BirdDroppings()
		{
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7F")]
		[Address(RVA = "0x1770D50", Offset = "0x1770D50", VA = "0x1770D50")]
		private void AI_199_MeteorOre()
		{
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D80")]
		[Address(RVA = "0x17711F0", Offset = "0x17711F0", VA = "0x17711F0")]
		private void AI_105_SporeSac()
		{
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x00015F30 File Offset: 0x00014130
		[Token(Token = "0x6002D81")]
		[Address(RVA = "0x175F0EC", Offset = "0x175F0EC", VA = "0x175F0EC")]
		public bool AI_053_HandleSentryNPCTargeting(Vector2 firingOffset, bool straightLine, out int targetSlot, out float x, out float y, float maxDistance = 1000f)
		{
			return default(bool);
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D82")]
		[Address(RVA = "0x1741064", Offset = "0x1741064", VA = "0x1741064")]
		private void AI_197_HandleTileCollision()
		{
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D83")]
		[Address(RVA = "0x1771CF0", Offset = "0x1771CF0", VA = "0x1771CF0")]
		private void AI_197_CeilingAndHoverTurret()
		{
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D84")]
		[Address(RVA = "0x1772E44", Offset = "0x1772E44", VA = "0x1772E44")]
		private void AI_196_Petal()
		{
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D85")]
		[Address(RVA = "0x17738C8", Offset = "0x17738C8", VA = "0x17738C8")]
		private void AI_113_TargetSticker()
		{
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D86")]
		[Address(RVA = "0x1725880", Offset = "0x1725880", VA = "0x1725880")]
		private void AI_113_UpdateDrawLayer()
		{
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D87")]
		[Address(RVA = "0x17768A4", Offset = "0x17768A4", VA = "0x17768A4")]
		private void AI_195_JimsDrone()
		{
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D88")]
		[Address(RVA = "0x1777974", Offset = "0x1777974", VA = "0x1777974")]
		public static void UseGasTrapInChest(int chestIndex, Chest theChest, int gasTrapIndex, int gasOffsetX, int gasOffsetY)
		{
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D89")]
		[Address(RVA = "0x1777DB4", Offset = "0x1777DB4", VA = "0x1777DB4")]
		private void AI_111_DryadsWard()
		{
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x00015F48 File Offset: 0x00014148
		[Token(Token = "0x6002D8A")]
		[Address(RVA = "0x1778EF0", Offset = "0x1778EF0", VA = "0x1778EF0")]
		public static bool GasTrapCheck(int x, int y, Player user)
		{
			return default(bool);
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D8B")]
		[Address(RVA = "0x177948C", Offset = "0x177948C", VA = "0x177948C")]
		private void AI_194_HorsemanPumpkin()
		{
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D8C")]
		[Address(RVA = "0x17799CC", Offset = "0x17799CC", VA = "0x17799CC")]
		private void AI_193_Flamethrower()
		{
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D8D")]
		[Address(RVA = "0x177A540", Offset = "0x177A540", VA = "0x177A540")]
		private void AI_047_MagnetSphere()
		{
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D8E")]
		[Address(RVA = "0x177A8A0", Offset = "0x177A8A0", VA = "0x177A8A0")]
		private void AI_047_MagnetSphere_TryAttacking()
		{
		}

		// Token: 0x06002D8F RID: 11663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D8F")]
		[Address(RVA = "0x177B044", Offset = "0x177B044", VA = "0x177B044")]
		public static void AI_192_GetJuminoFall(Projectile proj, out float timeSinceFall, out float fall)
		{
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D90")]
		[Address(RVA = "0x177B0C0", Offset = "0x177B0C0", VA = "0x177B0C0")]
		private void AI_192_JuminoAnimation()
		{
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D91")]
		[Address(RVA = "0x177CC84", Offset = "0x177CC84", VA = "0x177CC84")]
		private void AI_191_TrueNightsEdge()
		{
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x00015F60 File Offset: 0x00014160
		[Token(Token = "0x6002D92")]
		[Address(RVA = "0x177EFF4", Offset = "0x177EFF4", VA = "0x177EFF4")]
		private bool FindChlorophyteSporeCloudSpawn(ref Vector2 spawnPosition, Vector2 midPointDir)
		{
			return default(bool);
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x00015F78 File Offset: 0x00014178
		[Token(Token = "0x6002D93")]
		[Address(RVA = "0x177F324", Offset = "0x177F324", VA = "0x177F324")]
		public static bool IsTileSolidForImpact(Tile tile, bool treatPlatformsAsNonSolid = false)
		{
			return default(bool);
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D94")]
		[Address(RVA = "0x177F784", Offset = "0x177F784", VA = "0x177F784")]
		private void SpawnChlorophyteSporeCloud(Vector2 spawnPosition, Vector2 midPointDir)
		{
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D95")]
		[Address(RVA = "0x17808E4", Offset = "0x17808E4", VA = "0x17808E4")]
		private void AI_190_NightsEdge()
		{
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D96")]
		[Address(RVA = "0x1784048", Offset = "0x1784048", VA = "0x1784048")]
		private void AI_188_LightsBane()
		{
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D97")]
		[Address(RVA = "0x17845C0", Offset = "0x17845C0", VA = "0x17845C0")]
		private void AI_189_Volcano()
		{
		}

		// Token: 0x06002D98 RID: 11672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D98")]
		[Address(RVA = "0x1785B14", Offset = "0x1785B14", VA = "0x1785B14")]
		private void AI_066_TryInterceptingTarget(Vector2 targetDir, Vector2 targetVelocity, float speed)
		{
		}

		// Token: 0x06002D99 RID: 11673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D99")]
		[Address(RVA = "0x1785CEC", Offset = "0x1785CEC", VA = "0x1785CEC")]
		public static void RandomizeInsanityShadowFor(Entity targetEntity, bool isHostile, out Vector2 spawnposition, out Vector2 spawnvelocity, out float ai0, out float ai1)
		{
		}

		// Token: 0x06002D9A RID: 11674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D9A")]
		[Address(RVA = "0x1786A2C", Offset = "0x1786A2C", VA = "0x1786A2C")]
		private void AI_187_ShadowHand()
		{
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D9B")]
		[Address(RVA = "0x178737C", Offset = "0x178737C", VA = "0x178737C")]
		private void AI_187_ShadowHand_GetVariation(out int variation, out float fakeCounter, out float counterMax)
		{
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D9C")]
		[Address(RVA = "0x17874BC", Offset = "0x17874BC", VA = "0x17874BC")]
		private void AI_185_LifeDrain()
		{
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D9D")]
		[Address(RVA = "0x178789C", Offset = "0x178789C", VA = "0x178789C")]
		private void AI_186_PrincessWeapon()
		{
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D9E")]
		[Address(RVA = "0x1788D84", Offset = "0x1788D84", VA = "0x1788D84")]
		private void AI_184_BadTorchLuck()
		{
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D9F")]
		[Address(RVA = "0x17892C0", Offset = "0x17892C0", VA = "0x17892C0")]
		private void AI_121_StardustDragon()
		{
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA0")]
		[Address(RVA = "0x171EEE4", Offset = "0x171EEE4", VA = "0x171EEE4")]
		private Projectile FindStardustDragonHeadOfOwner()
		{
			return null;
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA1")]
		[Address(RVA = "0x178AE8C", Offset = "0x178AE8C", VA = "0x178AE8C")]
		private void AI_183_ZoologistStrike()
		{
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA2")]
		[Address(RVA = "0x178AF9C", Offset = "0x178AF9C", VA = "0x178AF9C")]
		private void AI_182_FinalFractal()
		{
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA3")]
		[Address(RVA = "0x178BD08", Offset = "0x178BD08", VA = "0x178BD08")]
		private void AI_181_FairyQueenRangedItemShot()
		{
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA4")]
		[Address(RVA = "0x178BFD8", Offset = "0x178BFD8", VA = "0x178BFD8")]
		private void AI_009_MagicMissiles()
		{
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA5")]
		[Address(RVA = "0x178E368", Offset = "0x178E368", VA = "0x178E368")]
		private void AI_009_MagicMissiles_Old()
		{
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA6")]
		[Address(RVA = "0x17420B4", Offset = "0x17420B4", VA = "0x17420B4")]
		private void AI_015_HandleMovementCollision(ref Vector2 wetVelocity, ref Vector2 lastVelocity)
		{
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA7")]
		[Address(RVA = "0x1776838", Offset = "0x1776838", VA = "0x1776838")]
		public void ResetLocalNPCHitImmunity()
		{
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA8")]
		[Address(RVA = "0x1791410", Offset = "0x1791410", VA = "0x1791410")]
		private void AI_015_Flails()
		{
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA9")]
		[Address(RVA = "0x1794C4C", Offset = "0x1794C4C", VA = "0x1794C4C")]
		private void AI_015_HandleMovementCollision_Old(ref Vector2 wetVelocity, ref Vector2 lastVelocity)
		{
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DAA")]
		[Address(RVA = "0x1794EA0", Offset = "0x1794EA0", VA = "0x1794EA0")]
		private void AI_015_Flails_Old()
		{
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DAB")]
		[Address(RVA = "0x1793FF0", Offset = "0x1793FF0", VA = "0x1793FF0")]
		private void AI_015_Flails_Dust(bool doFastThrowDust)
		{
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DAC")]
		[Address(RVA = "0x1795D58", Offset = "0x1795D58", VA = "0x1795D58")]
		private void AI_100_Medusa()
		{
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DAD")]
		[Address(RVA = "0x1797580", Offset = "0x1797580", VA = "0x1797580")]
		private void AI_120_StardustGuardian()
		{
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DAE")]
		[Address(RVA = "0x1799A90", Offset = "0x1799A90", VA = "0x1799A90")]
		private void AI_120_StardustGuardian_FindTarget(float lookupRange, ref int targetNPCIndex, ref float distanceToClosestTarget)
		{
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DAF")]
		[Address(RVA = "0x1799C68", Offset = "0x1799C68", VA = "0x1799C68")]
		private void AI_180_FairyQueenSunDance()
		{
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB0")]
		[Address(RVA = "0x179A398", Offset = "0x179A398", VA = "0x179A398")]
		private void AI_179_FairyQueenLance()
		{
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB1")]
		[Address(RVA = "0x179AA1C", Offset = "0x179AA1C", VA = "0x179AA1C")]
		private void AI_176_EdgyLightning()
		{
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DB2")]
		[Address(RVA = "0x179AD9C", Offset = "0x179AD9C", VA = "0x179AD9C")]
		public NPC FindTargetWithinRange(float maxRange, bool checkCanHit = false)
		{
			return null;
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB3")]
		[Address(RVA = "0x179B030", Offset = "0x179B030", VA = "0x179B030")]
		private void AI_177_IceWhipSlicer()
		{
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB4")]
		[Address(RVA = "0x179C3B8", Offset = "0x179C3B8", VA = "0x179C3B8")]
		private void AI_178_FireExplosion()
		{
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB5")]
		[Address(RVA = "0x179D968", Offset = "0x179D968", VA = "0x179D968")]
		private void AI_175_TitaniumStormShards()
		{
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB6")]
		[Address(RVA = "0x179DD68", Offset = "0x179DD68", VA = "0x179DD68")]
		private void AI_174_MultisegmentPet()
		{
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB7")]
		[Address(RVA = "0x179E52C", Offset = "0x179E52C", VA = "0x179E52C")]
		private void AI_173_HallowBossRainbowTrail()
		{
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x00015F90 File Offset: 0x00014190
		[Token(Token = "0x6002DB8")]
		[Address(RVA = "0x179E738", Offset = "0x179E738", VA = "0x179E738")]
		public Color AI_173_GetColor()
		{
			return default(Color);
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB9")]
		[Address(RVA = "0x179E9A0", Offset = "0x179E9A0", VA = "0x179E9A0")]
		private void AI_171_HallowBossRainbowStreak()
		{
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x00015FA8 File Offset: 0x000141A8
		[Token(Token = "0x6002DBA")]
		[Address(RVA = "0x179A7B8", Offset = "0x179A7B8", VA = "0x179A7B8")]
		public Color AI_171_GetColor()
		{
			return default(Color);
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBB")]
		[Address(RVA = "0x179F55C", Offset = "0x179F55C", VA = "0x179F55C")]
		private void AI_172_HallowBossRainbowPelletStorm()
		{
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x00015FC0 File Offset: 0x000141C0
		[Token(Token = "0x6002DBC")]
		[Address(RVA = "0x172B0BC", Offset = "0x172B0BC", VA = "0x172B0BC")]
		public int AI_172_GetPelletStormsCount()
		{
			return 0;
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x00015FD8 File Offset: 0x000141D8
		[Token(Token = "0x6002DBD")]
		[Address(RVA = "0x172B0C4", Offset = "0x172B0C4", VA = "0x172B0C4")]
		public Projectile.HallowBossPelletStormInfo AI_172_GetPelletStormInfo(int stormIndex)
		{
			return default(Projectile.HallowBossPelletStormInfo);
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x00015FF0 File Offset: 0x000141F0
		[Token(Token = "0x6002DBE")]
		[Address(RVA = "0x1728A20", Offset = "0x1728A20", VA = "0x1728A20")]
		public int FindTargetWithLineOfSight(float maxRange = 800f, [Optional] ICollection<int> ignoreTargets)
		{
			return 0;
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x00016008 File Offset: 0x00014208
		[Token(Token = "0x6002DBF")]
		[Address(RVA = "0x172998C", Offset = "0x172998C", VA = "0x172998C")]
		public static int FindTargetWithLineOfSight(Entity targeter, float maxRange = 800f, [Optional] ICollection<int> ignoreTargets)
		{
			return 0;
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC0")]
		[Address(RVA = "0x179F918", Offset = "0x179F918", VA = "0x179F918")]
		private void AI_170_FairyGlowstick()
		{
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC1")]
		[Address(RVA = "0x17A00E8", Offset = "0x17A00E8", VA = "0x17A00E8")]
		private void AI_169_Smolstars()
		{
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC2")]
		[Address(RVA = "0x17A13A0", Offset = "0x17A13A0", VA = "0x17A13A0")]
		private void AI_019_Spears()
		{
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00016020 File Offset: 0x00014220
		[Token(Token = "0x6002DC3")]
		[Address(RVA = "0x17579C0", Offset = "0x17579C0", VA = "0x17579C0")]
		private float AI_019_Spears_GetSpearOffsetRelativeToPlayer(Player master, int itemAnimation = -1, int itemAnimationMax = -1)
		{
			return 0f;
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x00016038 File Offset: 0x00014238
		[Token(Token = "0x6002DC4")]
		[Address(RVA = "0x172A8C8", Offset = "0x172A8C8", VA = "0x172A8C8")]
		public bool AI_019_Spears_GetExtensionHitbox(Player master, out Rectangle extensionBox)
		{
			return default(bool);
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC5")]
		[Address(RVA = "0x17A3F58", Offset = "0x17A3F58", VA = "0x17A3F58")]
		private void AI_019_Spears_Old()
		{
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC6")]
		[Address(RVA = "0x17A60AC", Offset = "0x17A60AC", VA = "0x17A60AC")]
		private void AI_168_FirstFractal()
		{
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC7")]
		[Address(RVA = "0x17A6798", Offset = "0x17A6798", VA = "0x17A6798")]
		private void AI_167_SparkleGuitar()
		{
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC8")]
		[Address(RVA = "0x17A6B88", Offset = "0x17A6B88", VA = "0x17A6B88")]
		private void AI_164_StormTigerGem()
		{
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x00016050 File Offset: 0x00014250
		[Token(Token = "0x6002DC9")]
		[Address(RVA = "0x17A6EA0", Offset = "0x17A6EA0", VA = "0x17A6EA0")]
		public static Vector2 AI_164_GetHomeLocation(Player master, int stackedIndex, int totalIndexes)
		{
			return default(Vector2);
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DCA")]
		[Address(RVA = "0x17A72A0", Offset = "0x17A72A0", VA = "0x17A72A0")]
		private void AI_162_TigerPounce()
		{
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DCB")]
		[Address(RVA = "0x17A7E80", Offset = "0x17A7E80", VA = "0x17A7E80")]
		private void PrepareBombToBlow()
		{
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x00016068 File Offset: 0x00014268
		[Token(Token = "0x6002DCC")]
		[Address(RVA = "0x1742A7C", Offset = "0x1742A7C", VA = "0x1742A7C")]
		private bool AI_016_CanAcornPlant(out Point plantPoint)
		{
			return default(bool);
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DCD")]
		[Address(RVA = "0x17A8A90", Offset = "0x17A8A90", VA = "0x17A8A90")]
		private void AI_016_Bombs()
		{
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DCE")]
		[Address(RVA = "0x17B00E0", Offset = "0x17B00E0", VA = "0x17B00E0")]
		private void AI_166_Dove()
		{
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DCF")]
		[Address(RVA = "0x17B057C", Offset = "0x17B057C", VA = "0x17B057C")]
		private void AI_161_RapierStabs()
		{
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD0")]
		[Address(RVA = "0x17B1190", Offset = "0x17B1190", VA = "0x17B1190")]
		private void AI_165_Whip()
		{
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x00016080 File Offset: 0x00014280
		[Token(Token = "0x6002DD1")]
		[Address(RVA = "0x17B96AC", Offset = "0x17B96AC", VA = "0x17B96AC")]
		public static float GetWhipAnimationPercent(Projectile proj)
		{
			return 0f;
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD2")]
		[Address(RVA = "0x170644C", Offset = "0x170644C", VA = "0x170644C")]
		public static void FillWhipControlPoints(Projectile proj, List<Vector2> controlPoints, [Optional] Player owner, bool getActualCollisionPoints = false, int frameOffset = 0)
		{
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD3")]
		[Address(RVA = "0x1706010", Offset = "0x1706010", VA = "0x1706010")]
		public static void GetWhipSettings(Projectile proj, out float timeToFlyOut, out int segments, out float rangeMultiplier)
		{
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD4")]
		[Address(RVA = "0x17B9760", Offset = "0x17B9760", VA = "0x17B9760")]
		private void AI_160_Kites()
		{
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD5")]
		[Address(RVA = "0x17B9AB8", Offset = "0x17B9AB8", VA = "0x17B9AB8")]
		public void KiteLogic(Vector2 anchorPoint, KiteFlyingInfo info)
		{
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD6")]
		[Address(RVA = "0x17BAE80", Offset = "0x17BAE80", VA = "0x17BAE80")]
		private void AI_159_PaperAirplanes()
		{
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD7")]
		[Address(RVA = "0x17BB918", Offset = "0x17BB918", VA = "0x17BB918")]
		private void AI_158_BabyBird()
		{
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x00016098 File Offset: 0x00014298
		[Token(Token = "0x6002DD8")]
		[Address(RVA = "0x17BCCD8", Offset = "0x17BCCD8", VA = "0x17BCCD8")]
		public static Vector2 AI_158_GetHomeLocation(Player master, int stackedIndex)
		{
			return default(Vector2);
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD9")]
		[Address(RVA = "0x176078C", Offset = "0x176078C", VA = "0x176078C")]
		public void Minion_FindTargetInRange(int startAttackRange, ref int attackTarget, bool skipIfCannotHitWithOwnBody, [Optional] Func<Entity, int, bool> customEliminationCheck, bool respectOwnerTarget = true)
		{
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x000160B0 File Offset: 0x000142B0
		[Token(Token = "0x6002DDA")]
		[Address(RVA = "0x17BD510", Offset = "0x17BD510", VA = "0x17BD510")]
		private bool AI_067_CustomEliminationCheck_Pirates(Entity otherEntity, int currentTarget)
		{
			return default(bool);
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x000160C8 File Offset: 0x000142C8
		[Token(Token = "0x6002DDB")]
		[Address(RVA = "0x17BD518", Offset = "0x17BD518", VA = "0x17BD518")]
		private bool AI_067_TigerSpecialAttack()
		{
			return default(bool);
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DDC")]
		[Address(RVA = "0x17BE590", Offset = "0x17BE590", VA = "0x17BE590")]
		private void AI_067_FreakingPirates()
		{
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DDD")]
		[Address(RVA = "0x17C9C40", Offset = "0x17C9C40", VA = "0x17C9C40")]
		private void AI_067_FreakingPirates_TryJumpingToTarget(Vector2 targetVelocity, Vector2 toTarget, Vector2 targetCenter)
		{
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DDE")]
		[Address(RVA = "0x17CA2EC", Offset = "0x17CA2EC", VA = "0x17CA2EC")]
		private void AI_067_FreakingPirates_HitIntention(Vector2 idealPosition)
		{
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DDF")]
		[Address(RVA = "0x17C969C", Offset = "0x17C969C", VA = "0x17C969C")]
		private void AI_067_FreakingPirates_TryAssigningHelp()
		{
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE0")]
		[Address(RVA = "0x17CA6CC", Offset = "0x17CA6CC", VA = "0x17CA6CC")]
		private void AI_157_SharpTears()
		{
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x000160E0 File Offset: 0x000142E0
		[Token(Token = "0x6002DE1")]
		[Address(RVA = "0x17BD2AC", Offset = "0x17BD2AC", VA = "0x17BD2AC")]
		public bool IsInRangeOfMeOrMyOwner(Entity entity, float maxDistance, out float myDistance, out float playerDistance, out bool closerIsMe)
		{
			return default(bool);
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE2")]
		[Address(RVA = "0x17CBD08", Offset = "0x17CBD08", VA = "0x17CBD08")]
		private void AI_156_BatOfLight()
		{
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x000160F8 File Offset: 0x000142F8
		[Token(Token = "0x6002DE3")]
		[Address(RVA = "0x17CC2B8", Offset = "0x17CC2B8", VA = "0x17CC2B8")]
		public Color AI_156_GetColor()
		{
			return default(Color);
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE4")]
		[Address(RVA = "0x17CC36C", Offset = "0x17CC36C", VA = "0x17CC36C")]
		private void AI_156_Think(List<int> blacklist)
		{
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE5")]
		[Address(RVA = "0x17CEC0C", Offset = "0x17CEC0C", VA = "0x17CEC0C")]
		private void AI_156_StartAttack()
		{
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x00016110 File Offset: 0x00014310
		[Token(Token = "0x6002DE6")]
		[Address(RVA = "0x17CE930", Offset = "0x17CE930", VA = "0x17CE930")]
		private int AI_156_TryAttackingNPCs(List<int> blackListedTargets, bool skipBodyCheck = false)
		{
			return 0;
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE7")]
		[Address(RVA = "0x1760B98", Offset = "0x1760B98", VA = "0x1760B98")]
		private void AI_GetMyGroupIndexAndFillBlackList(List<int> blackListedTargets, out int index, out int totalIndexesInGroup)
		{
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE8")]
		[Address(RVA = "0x17CE3B8", Offset = "0x17CE3B8", VA = "0x17CE3B8")]
		private void AI_156_GetIdlePosition(int stackedIndex, int totalIndexes, out Vector2 idleSpot, out float idleRotation)
		{
		}

		// Token: 0x06002DE9 RID: 11753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE9")]
		[Address(RVA = "0x17CEC78", Offset = "0x17CEC78", VA = "0x17CEC78")]
		private void AI_155_MysticSnakeCoil()
		{
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DEA")]
		[Address(RVA = "0x17D0814", Offset = "0x17D0814", VA = "0x17D0814")]
		private void AI_155_RemoveRope(Point start, Point end)
		{
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DEB")]
		[Address(RVA = "0x17D0AFC", Offset = "0x17D0AFC", VA = "0x17D0AFC")]
		private void AI_155_SpawnRopeIn(int x, int y)
		{
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DEC")]
		[Address(RVA = "0x17D119C", Offset = "0x17D119C", VA = "0x17D119C")]
		private void AI_154_VoidLens()
		{
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DED")]
		[Address(RVA = "0x17D1550", Offset = "0x17D1550", VA = "0x17D1550")]
		private void AI_153_ToiletPop()
		{
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DEE")]
		[Address(RVA = "0x17D1A2C", Offset = "0x17D1A2C", VA = "0x17D1A2C")]
		private void AI_198_Flint()
		{
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DEF")]
		[Address(RVA = "0x17D25C0", Offset = "0x17D25C0", VA = "0x17D25C0")]
		private void AI_198_Flint_EmitSpikes(Vector2 startPosition, int direction)
		{
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF0")]
		[Address(RVA = "0x17D2E74", Offset = "0x17D2E74", VA = "0x17D2E74")]
		private void FindBlockSurface(int x, ref int y, int downMax, int upmax)
		{
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF1")]
		[Address(RVA = "0x17D2D28", Offset = "0x17D2D28", VA = "0x17D2D28")]
		private void FindBlockCeiling(int x, ref int y, int upMax, int downMax)
		{
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF2")]
		[Address(RVA = "0x17D2FC0", Offset = "0x17D2FC0", VA = "0x17D2FC0")]
		private void AI_150_GolfClubHelper()
		{
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x00016128 File Offset: 0x00014328
		[Token(Token = "0x6002DF3")]
		[Address(RVA = "0x17D40B0", Offset = "0x17D40B0", VA = "0x17D40B0")]
		public Color GetCeleb2Color()
		{
			return default(Color);
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF4")]
		[Address(RVA = "0x17D42D0", Offset = "0x17D42D0", VA = "0x17D42D0")]
		private void AI_007_GrapplingHooks()
		{
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x00016140 File Offset: 0x00014340
		[Token(Token = "0x6002DF5")]
		[Address(RVA = "0x17D6314", Offset = "0x17D6314", VA = "0x17D6314")]
		private bool AI_007_GrapplingHooks_CanTileBeLatchedOnTo(Tile theTile)
		{
			return default(bool);
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF6")]
		[Address(RVA = "0x17D66E8", Offset = "0x17D66E8", VA = "0x17D66E8")]
		private void AI_147_Celeb2Rocket()
		{
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF7")]
		[Address(RVA = "0x17DC204", Offset = "0x17DC204", VA = "0x17DC204")]
		private void AI_148_StarSpawner()
		{
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF8")]
		[Address(RVA = "0x17D7EE0", Offset = "0x17D7EE0", VA = "0x17D7EE0")]
		private void AI_147_Explosion()
		{
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DF9")]
		[Address(RVA = "0x1745EFC", Offset = "0x1745EFC", VA = "0x1745EFC")]
		private void CreateGroundExplosion(float MAX_SPREAD, int fluff, int distFluff, int layerStart, int layerEnd, int layerJump)
		{
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DFA")]
		[Address(RVA = "0x17DC690", Offset = "0x17DC690", VA = "0x17DC690")]
		public void CheckUsability(Player player, ref bool currentlyUsable)
		{
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DFB")]
		[Address(RVA = "0x17DC6A4", Offset = "0x17DC6A4", VA = "0x17DC6A4")]
		private void AI_163_Chum()
		{
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DFC")]
		[Address(RVA = "0x17DDA8C", Offset = "0x17DDA8C", VA = "0x17DDA8C")]
		private void ReduceRemainingChumsInPool()
		{
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DFD")]
		[Address(RVA = "0x17DE488", Offset = "0x17DE488", VA = "0x17DE488")]
		private void AI_061_FishingBobber()
		{
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x00016158 File Offset: 0x00014358
		[Token(Token = "0x6002DFE")]
		[Address(RVA = "0x17DD6C8", Offset = "0x17DD6C8", VA = "0x17DD6C8")]
		private float AI_061_FishingBobber_GetWaterLine(int X, int Y)
		{
			return 0f;
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DFF")]
		[Address(RVA = "0x17DF478", Offset = "0x17DF478", VA = "0x17DF478")]
		private void AI_061_FishingBobber_DoASplash()
		{
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E00")]
		[Address(RVA = "0x17DF71C", Offset = "0x17DF71C", VA = "0x17DF71C")]
		private void AI_061_FishingBobber_GiveItemToPlayer(Player thePlayer, int itemType)
		{
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E01")]
		[Address(RVA = "0x17DFC28", Offset = "0x17DFC28", VA = "0x17DFC28")]
		private void AI_146_DD2Victory()
		{
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E02")]
		[Address(RVA = "0x1728A94", Offset = "0x1728A94", VA = "0x1728A94")]
		private void BetsySharpnel(int npcIndex)
		{
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E03")]
		[Address(RVA = "0x17DFC2C", Offset = "0x17DFC2C", VA = "0x17DFC2C")]
		private void CopyLocalNPCImmunityTo(Projectile p)
		{
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x00016170 File Offset: 0x00014370
		[Token(Token = "0x6002E04")]
		[Address(RVA = "0x1741D64", Offset = "0x1741D64", VA = "0x1741D64")]
		private int AI_048_GetStartPositionSettingDelay()
		{
			return 0;
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E05")]
		[Address(RVA = "0x164E370", Offset = "0x164E370", VA = "0x164E370")]
		private void AI_001()
		{
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E06")]
		[Address(RVA = "0x17DFCE4", Offset = "0x17DFCE4", VA = "0x17DFCE4")]
		public void ApplyHarpyCharm(int npcTargetIndex, int itemID)
		{
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E07")]
		[Address(RVA = "0x17E001C", Offset = "0x17E001C", VA = "0x17E001C")]
		private void AI_002()
		{
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E08")]
		[Address(RVA = "0x17E3F58", Offset = "0x17E3F58", VA = "0x17E3F58")]
		private void AI_003()
		{
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E09")]
		[Address(RVA = "0x17E7E00", Offset = "0x17E7E00", VA = "0x17E7E00")]
		private void AI_004()
		{
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E0A")]
		[Address(RVA = "0x17E8E0C", Offset = "0x17E8E0C", VA = "0x17E8E0C")]
		private void AI_005()
		{
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E0B")]
		[Address(RVA = "0x17EBCF8", Offset = "0x17EBCF8", VA = "0x17EBCF8")]
		private void AI_006()
		{
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E0C")]
		[Address(RVA = "0x17ECAC8", Offset = "0x17ECAC8", VA = "0x17ECAC8")]
		private void AI_008()
		{
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E0D")]
		[Address(RVA = "0x17EDF80", Offset = "0x17EDF80", VA = "0x17EDF80")]
		private void AI_010()
		{
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E0E")]
		[Address(RVA = "0x17EFFDC", Offset = "0x17EFFDC", VA = "0x17EFFDC")]
		private void AI_011()
		{
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E0F")]
		[Address(RVA = "0x17F0B5C", Offset = "0x17F0B5C", VA = "0x17F0B5C")]
		private void AI_012()
		{
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E10")]
		[Address(RVA = "0x17F1ED0", Offset = "0x17F1ED0", VA = "0x17F1ED0")]
		private void AI_013()
		{
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E11")]
		[Address(RVA = "0x17F2C28", Offset = "0x17F2C28", VA = "0x17F2C28")]
		private void AI_014()
		{
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E12")]
		[Address(RVA = "0x17F68AC", Offset = "0x17F68AC", VA = "0x17F68AC")]
		private void AI_017()
		{
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E13")]
		[Address(RVA = "0x17F6D38", Offset = "0x17F6D38", VA = "0x17F6D38")]
		private void AI_018()
		{
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E14")]
		[Address(RVA = "0x17F7DD0", Offset = "0x17F7DD0", VA = "0x17F7DD0")]
		private void AI_020()
		{
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E15")]
		[Address(RVA = "0x17F89A8", Offset = "0x17F89A8", VA = "0x17F89A8")]
		private void AI_021()
		{
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E16")]
		[Address(RVA = "0x17F8E1C", Offset = "0x17F8E1C", VA = "0x17F8E1C")]
		private void AI_022()
		{
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E17")]
		[Address(RVA = "0x17FB278", Offset = "0x17FB278", VA = "0x17FB278")]
		private void AI_023()
		{
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E18")]
		[Address(RVA = "0x17FB9F0", Offset = "0x17FB9F0", VA = "0x17FB9F0")]
		private void AI_024()
		{
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E19")]
		[Address(RVA = "0x17FC2E0", Offset = "0x17FC2E0", VA = "0x17FC2E0")]
		private void AI_025()
		{
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E1A")]
		[Address(RVA = "0x16871F0", Offset = "0x16871F0", VA = "0x16871F0")]
		private void AI_026()
		{
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E1B")]
		[Address(RVA = "0x17FE808", Offset = "0x17FE808", VA = "0x17FE808")]
		private void AI_027()
		{
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E1C")]
		[Address(RVA = "0x17FFB98", Offset = "0x17FFB98", VA = "0x17FFB98")]
		private void AI_028()
		{
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E1D")]
		[Address(RVA = "0x1800FC4", Offset = "0x1800FC4", VA = "0x1800FC4")]
		private void AI_030()
		{
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E1E")]
		[Address(RVA = "0x1801F60", Offset = "0x1801F60", VA = "0x1801F60")]
		private void AI_031()
		{
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E1F")]
		[Address(RVA = "0x1802580", Offset = "0x1802580", VA = "0x1802580")]
		private void AI_032()
		{
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E20")]
		[Address(RVA = "0x1803190", Offset = "0x1803190", VA = "0x1803190")]
		private void AI_033()
		{
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E21")]
		[Address(RVA = "0x18039EC", Offset = "0x18039EC", VA = "0x18039EC")]
		private void AI_034()
		{
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E22")]
		[Address(RVA = "0x18047A4", Offset = "0x18047A4", VA = "0x18047A4")]
		private void AI_035()
		{
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E23")]
		[Address(RVA = "0x180562C", Offset = "0x180562C", VA = "0x180562C")]
		private void AI_036()
		{
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E24")]
		[Address(RVA = "0x1806150", Offset = "0x1806150", VA = "0x1806150")]
		private void AI_037()
		{
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E25")]
		[Address(RVA = "0x180651C", Offset = "0x180651C", VA = "0x180651C")]
		private void AI_038()
		{
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E26")]
		[Address(RVA = "0x180674C", Offset = "0x180674C", VA = "0x180674C")]
		private void AI_039()
		{
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E27")]
		[Address(RVA = "0x1807CEC", Offset = "0x1807CEC", VA = "0x1807CEC")]
		private void AI_041()
		{
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E28")]
		[Address(RVA = "0x1807DC4", Offset = "0x1807DC4", VA = "0x1807DC4")]
		private void AI_042()
		{
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E29")]
		[Address(RVA = "0x1808868", Offset = "0x1808868", VA = "0x1808868")]
		private void AI_043()
		{
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E2A")]
		[Address(RVA = "0x1808EE4", Offset = "0x1808EE4", VA = "0x1808EE4")]
		private void AI_044()
		{
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E2B")]
		[Address(RVA = "0x1809660", Offset = "0x1809660", VA = "0x1809660")]
		private void AI_045()
		{
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E2C")]
		[Address(RVA = "0x180A45C", Offset = "0x180A45C", VA = "0x180A45C")]
		private void AI_046()
		{
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E2D")]
		[Address(RVA = "0x180AC9C", Offset = "0x180AC9C", VA = "0x180AC9C")]
		private void AI_048()
		{
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E2E")]
		[Address(RVA = "0x180AF30", Offset = "0x180AF30", VA = "0x180AF30")]
		private void AI_049()
		{
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E2F")]
		[Address(RVA = "0x180BA34", Offset = "0x180BA34", VA = "0x180BA34")]
		private void AI_050()
		{
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E30")]
		[Address(RVA = "0x180C6E8", Offset = "0x180C6E8", VA = "0x180C6E8")]
		private void AI_051()
		{
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E31")]
		[Address(RVA = "0x180D240", Offset = "0x180D240", VA = "0x180D240")]
		private void AI_052()
		{
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E32")]
		[Address(RVA = "0x180DD20", Offset = "0x180DD20", VA = "0x180DD20")]
		private void AI_054()
		{
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E33")]
		[Address(RVA = "0x180EEB0", Offset = "0x180EEB0", VA = "0x180EEB0")]
		private void AI_055()
		{
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E34")]
		[Address(RVA = "0x180F688", Offset = "0x180F688", VA = "0x180F688")]
		private void AI_056()
		{
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E35")]
		[Address(RVA = "0x180F874", Offset = "0x180F874", VA = "0x180F874")]
		private void AI_057()
		{
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E36")]
		[Address(RVA = "0x180FCF0", Offset = "0x180FCF0", VA = "0x180FCF0")]
		private void AI_058()
		{
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E37")]
		[Address(RVA = "0x180FEA4", Offset = "0x180FEA4", VA = "0x180FEA4")]
		private void AI_059()
		{
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E38")]
		[Address(RVA = "0x18106A4", Offset = "0x18106A4", VA = "0x18106A4")]
		private void AI_060()
		{
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x00016188 File Offset: 0x00014388
		[Token(Token = "0x6002E39")]
		[Address(RVA = "0x1813920", Offset = "0x1813920", VA = "0x1813920")]
		private bool Chester_IsAnyPlayerTrackingThisProjectile()
		{
			return default(bool);
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E3A")]
		[Address(RVA = "0x18139F0", Offset = "0x18139F0", VA = "0x18139F0")]
		private void AI_062()
		{
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E3B")]
		[Address(RVA = "0x181BC24", Offset = "0x181BC24", VA = "0x181BC24")]
		private void AI_063()
		{
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E3C")]
		[Address(RVA = "0x181C1D0", Offset = "0x181C1D0", VA = "0x181C1D0")]
		private void AI_064()
		{
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E3D")]
		[Address(RVA = "0x181CBD8", Offset = "0x181CBD8", VA = "0x181CBD8")]
		private void AI_065()
		{
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E3E")]
		[Address(RVA = "0x181D568", Offset = "0x181D568", VA = "0x181D568")]
		private void AI_066()
		{
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E3F")]
		[Address(RVA = "0x182094C", Offset = "0x182094C", VA = "0x182094C")]
		private void AI_068()
		{
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E40")]
		[Address(RVA = "0x18214E0", Offset = "0x18214E0", VA = "0x18214E0")]
		private void AI_069()
		{
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E41")]
		[Address(RVA = "0x1821DB0", Offset = "0x1821DB0", VA = "0x1821DB0")]
		private void AI_070()
		{
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E42")]
		[Address(RVA = "0x18227C0", Offset = "0x18227C0", VA = "0x18227C0")]
		private void AI_075()
		{
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E43")]
		[Address(RVA = "0x182DE44", Offset = "0x182DE44", VA = "0x182DE44")]
		private void AI_092()
		{
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E44")]
		[Address(RVA = "0x1830040", Offset = "0x1830040", VA = "0x1830040")]
		private void AI_099_1_Counterweights()
		{
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E45")]
		[Address(RVA = "0x1832600", Offset = "0x1832600", VA = "0x1832600")]
		private void AI_099_2_Yoyos()
		{
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E46")]
		[Address(RVA = "0x183568C", Offset = "0x183568C", VA = "0x183568C")]
		private void AI_130_FlameBurstTower()
		{
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x000161A0 File Offset: 0x000143A0
		[Token(Token = "0x6002E47")]
		[Address(RVA = "0x1837BA8", Offset = "0x1837BA8", VA = "0x1837BA8")]
		private int AI_130_FlameBurstTower_FindTarget(float shot_range, float angleRatioMax, Vector2 shootingSpot, bool canChangeDirection = true)
		{
			return 0;
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x000161B8 File Offset: 0x000143B8
		[Token(Token = "0x6002E48")]
		[Address(RVA = "0x18382B4", Offset = "0x18382B4", VA = "0x18382B4")]
		private int AI_134_Ballista_FindTarget(float shot_range, float deadBottomAngle, Vector2 shootingSpot)
		{
			return 0;
		}

		// Token: 0x06002E49 RID: 11849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E49")]
		[Address(RVA = "0x18389A8", Offset = "0x18389A8", VA = "0x18389A8")]
		private void AI_131_FlameBurstShot()
		{
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E4A")]
		[Address(RVA = "0x1838EB8", Offset = "0x1838EB8", VA = "0x1838EB8")]
		private void AI_134_Ballista()
		{
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x000161D0 File Offset: 0x000143D0
		[Token(Token = "0x6002E4B")]
		[Address(RVA = "0x1839E0C", Offset = "0x1839E0C", VA = "0x1839E0C")]
		public static int GetBallistraShotDelay(Player player)
		{
			return 0;
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E4C")]
		[Address(RVA = "0x1839E98", Offset = "0x1839E98", VA = "0x1839E98")]
		private void AI_135_OgreStomp()
		{
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E4D")]
		[Address(RVA = "0x183B6A0", Offset = "0x183B6A0", VA = "0x183B6A0")]
		private void AI_136_BetsyBreath()
		{
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E4E")]
		[Address(RVA = "0x183C924", Offset = "0x183C924", VA = "0x183C924")]
		private void AI_137_LightningAura()
		{
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E4F")]
		[Address(RVA = "0x175C610", Offset = "0x175C610", VA = "0x175C610")]
		private void AI_Sentries_HeavySlingReposition()
		{
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E50")]
		[Address(RVA = "0x183DF3C", Offset = "0x183DF3C", VA = "0x183DF3C")]
		private void AI_138_ExplosiveTrap()
		{
		}

		// Token: 0x06002E51 RID: 11857 RVA: 0x000161E8 File Offset: 0x000143E8
		[Token(Token = "0x6002E51")]
		[Address(RVA = "0x183E900", Offset = "0x183E900", VA = "0x183E900")]
		public static int GetExplosiveTrapCooldown(Player player)
		{
			return 0;
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E52")]
		[Address(RVA = "0x183E954", Offset = "0x183E954", VA = "0x183E954")]
		private void AI_139_ExplosiveTrapExplosion()
		{
		}

		// Token: 0x06002E53 RID: 11859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E53")]
		[Address(RVA = "0x183EB70", Offset = "0x183EB70", VA = "0x183EB70")]
		private void AI_140_MonkStaffT1()
		{
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E54")]
		[Address(RVA = "0x18407C4", Offset = "0x18407C4", VA = "0x18407C4")]
		private void AI_141_MonkStaffT1Explosion()
		{
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E55")]
		[Address(RVA = "0x1841BD4", Offset = "0x1841BD4", VA = "0x1841BD4")]
		private void AI_209_ChlorophyteClaymoreBladeSlam()
		{
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E56")]
		[Address(RVA = "0x1790260", Offset = "0x1790260", VA = "0x1790260")]
		private void CreateImpactExplosion(int dustAmountMultiplier, Vector2 explosionOrigin, ref Point scanAreaStart, ref Point scanAreaEnd, int explosionRange, out bool causedShockwaves)
		{
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E57")]
		[Address(RVA = "0x1840A08", Offset = "0x1840A08", VA = "0x1840A08")]
		private void CreateImpactExplosion_SleepyOctopod(int dustAmountMultiplier, Vector2 explosionOrigin, ref Point scanAreaStart, ref Point scanAreaEnd, int explosionRange, out bool causedShockwaves)
		{
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E58")]
		[Address(RVA = "0x1841540", Offset = "0x1841540", VA = "0x1841540")]
		private void CreateImpactExplosion2_SleepyOctopod(Vector2 explosionOrigin, bool causedShockwaves)
		{
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E59")]
		[Address(RVA = "0x1790CCC", Offset = "0x1790CCC", VA = "0x1790CCC")]
		private void CreateImpactExplosion2_FlailTileCollision(Vector2 explosionOrigin, bool causedShockwaves, Vector2 velocityBeforeCollision)
		{
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E5A")]
		[Address(RVA = "0x1841CB4", Offset = "0x1841CB4", VA = "0x1841CB4")]
		private void AI_142_MonkStaffT2And3()
		{
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E5B")]
		[Address(RVA = "0x1843578", Offset = "0x1843578", VA = "0x1843578")]
		private void AI_143_MonkStaffT2Ghast()
		{
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E5C")]
		[Address(RVA = "0x1843D24", Offset = "0x1843D24", VA = "0x1843D24")]
		private void AI_144_DD2Pet()
		{
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E5D")]
		[Address(RVA = "0x1845CA0", Offset = "0x1845CA0", VA = "0x1845CA0")]
		private void AI_145_BookStaffStorm()
		{
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x00016200 File Offset: 0x00014400
		[Token(Token = "0x6002E5E")]
		[Address(RVA = "0x172B20C", Offset = "0x172B20C", VA = "0x172B20C")]
		public bool AI_137_LightningAura_CanHit(Vector2 targetPosition)
		{
			return default(bool);
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x00016218 File Offset: 0x00014418
		[Token(Token = "0x6002E5F")]
		[Address(RVA = "0x17AFF14", Offset = "0x17AFF14", VA = "0x17AFF14")]
		private Point GetScarabBombDigDirectionSnap8()
		{
			return default(Point);
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x00016230 File Offset: 0x00014430
		[Token(Token = "0x6002E60")]
		[Address(RVA = "0x17A6704", Offset = "0x17A6704", VA = "0x17A6704")]
		public Color GetFirstFractalColor()
		{
			return default(Color);
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E61")]
		[Address(RVA = "0x1847110", Offset = "0x1847110", VA = "0x1847110")]
		public void Kill_DirtAndFluidProjectiles_RunDelegateMethodPushUpForHalfBricks(Point pt, float size, Utils.TileActionAttempt plot)
		{
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E62")]
		[Address(RVA = "0x1847430", Offset = "0x1847430", VA = "0x1847430")]
		private void LavaBoulderExplosion()
		{
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x00016248 File Offset: 0x00014448
		[Token(Token = "0x6002E63")]
		[Address(RVA = "0x1847790", Offset = "0x1847790", VA = "0x1847790")]
		public bool IsAttachedTo(NPC npc)
		{
			return default(bool);
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E64")]
		[Address(RVA = "0x1847820", Offset = "0x1847820", VA = "0x1847820")]
		private void BoulderExplosion()
		{
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E65")]
		[Address(RVA = "0x1847B7C", Offset = "0x1847B7C", VA = "0x1847B7C")]
		private void SpawnWebs()
		{
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E66")]
		[Address(RVA = "0x18480A0", Offset = "0x18480A0", VA = "0x18480A0")]
		public void Kill_SpiderBoulder_SpawnSpider()
		{
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E67")]
		[Address(RVA = "0x16A4E00", Offset = "0x16A4E00", VA = "0x16A4E00")]
		public void Kill()
		{
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E68")]
		[Address(RVA = "0x1848554", Offset = "0x1848554", VA = "0x1848554")]
		private void Kill_ExplodeTiles()
		{
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E69")]
		[Address(RVA = "0x184C6C8", Offset = "0x184C6C8", VA = "0x184C6C8")]
		private void Kill_Bombs_DoUsualKillCode()
		{
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E6A")]
		[Address(RVA = "0x1857270", Offset = "0x1857270", VA = "0x1857270")]
		private void SpawnLightningLiquidElectrificationParticles()
		{
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x00016260 File Offset: 0x00014460
		[Token(Token = "0x6002E6B")]
		[Address(RVA = "0x1857510", Offset = "0x1857510", VA = "0x1857510")]
		private bool SpawnLightningLiquidElectrificationParticles(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E6C")]
		[Address(RVA = "0x18578C8", Offset = "0x18578C8", VA = "0x18578C8")]
		private void DropGeodeGems()
		{
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E6D")]
		[Address(RVA = "0x1857EF8", Offset = "0x1857EF8", VA = "0x1857EF8")]
		private void DoRainbowCrystalStaffExplosion()
		{
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x00016278 File Offset: 0x00014478
		[Token(Token = "0x6002E6E")]
		[Address(RVA = "0x184BCB8", Offset = "0x184BCB8", VA = "0x184BCB8")]
		public bool ShouldWallExplode(Vector2 compareSpot, int radius, int minI, int maxI, int minJ, int maxJ)
		{
			return default(bool);
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x00016290 File Offset: 0x00014490
		[Token(Token = "0x6002E6F")]
		[Address(RVA = "0x18588BC", Offset = "0x18588BC", VA = "0x18588BC")]
		public Color GetFloatingDaggerMinionGlowColor()
		{
			return default(Color);
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x000162A8 File Offset: 0x000144A8
		[Token(Token = "0x6002E70")]
		[Address(RVA = "0x18589D4", Offset = "0x18589D4", VA = "0x18589D4")]
		public bool CanExplodeTile(int x, int y, bool explodeHardmodeOres = false)
		{
			return default(bool);
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E71")]
		[Address(RVA = "0x184BF24", Offset = "0x184BF24", VA = "0x184BF24")]
		public void ExplodeTiles(Vector2 compareSpot, int radius, int minI, int maxI, int minJ, int maxJ, bool wallSplode, bool explodeHardmodeOres = false)
		{
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E72")]
		[Address(RVA = "0x184B6BC", Offset = "0x184B6BC", VA = "0x184B6BC")]
		public void ExplodeCrackedTiles(Vector2 compareSpot, int radius, int minI, int maxI, int minJ, int maxJ)
		{
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x000162C0 File Offset: 0x000144C0
		[Token(Token = "0x6002E73")]
		[Address(RVA = "0x1859140", Offset = "0x1859140", VA = "0x1859140")]
		public bool IsSentryBeingCarried()
		{
			return default(bool);
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x000162D8 File Offset: 0x000144D8
		[Token(Token = "0x6002E74")]
		[Address(RVA = "0x175C3FC", Offset = "0x175C3FC", VA = "0x175C3FC")]
		public bool CanGetPickedUpBySentryBackpack()
		{
			return default(bool);
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E75")]
		[Address(RVA = "0x175C57C", Offset = "0x175C57C", VA = "0x175C57C")]
		public void SetAsSelectedSentryBackpackTarget()
		{
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x000162F0 File Offset: 0x000144F0
		[Token(Token = "0x6002E76")]
		[Address(RVA = "0x1859174", Offset = "0x1859174", VA = "0x1859174")]
		public bool TryGetContainerIndex(out int containerIndex)
		{
			return default(bool);
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x00016308 File Offset: 0x00014508
		[Token(Token = "0x6002E77")]
		[Address(RVA = "0x18591B4", Offset = "0x18591B4", VA = "0x18591B4")]
		public bool IsInteractable()
		{
			return default(bool);
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x00016320 File Offset: 0x00014520
		[Token(Token = "0x6002E78")]
		[Address(RVA = "0x1859264", Offset = "0x1859264", VA = "0x1859264")]
		public Color GetAlpha(Color newColor)
		{
			return default(Color);
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E79")]
		[Address(RVA = "0x185D3E0", Offset = "0x185D3E0", VA = "0x185D3E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E7A")]
		[Address(RVA = "0x16FF788", Offset = "0x16FF788", VA = "0x16FF788")]
		public Projectile()
		{
		}

		// Token: 0x04003E1F RID: 15903
		[Token(Token = "0x4003E1F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static uint[,] perIDStaticNPCImmunity;

		// Token: 0x04003E20 RID: 15904
		[Token(Token = "0x4003E20")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static List<Tuple<int, float>> _medusaHeadTargetList;

		// Token: 0x04003E21 RID: 15905
		[Token(Token = "0x4003E21")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<int> _ai164_blacklistedTargets;

		// Token: 0x04003E22 RID: 15906
		[Token(Token = "0x4003E22")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static List<int> _ai158_blacklistedTargets;

		// Token: 0x04003E23 RID: 15907
		[Token(Token = "0x4003E23")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<int> _ai156_blacklistedTargets;

		// Token: 0x04003E24 RID: 15908
		[Token(Token = "0x4003E24")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static float[] _CompanionCubeScreamCooldown;

		// Token: 0x04003E25 RID: 15909
		[Token(Token = "0x4003E25")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool active;

		// Token: 0x04003E26 RID: 15910
		[Token(Token = "0x4003E26")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int[] slotGenerations;

		// Token: 0x04003E27 RID: 15911
		[Token(Token = "0x4003E27")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static int[,] keyToIndex;

		// Token: 0x04003E28 RID: 15912
		[Token(Token = "0x4003E28")]
		public const int SentryLifeTime = 36000;

		// Token: 0x04003E29 RID: 15913
		[Token(Token = "0x4003E29")]
		public const int ArrowLifeTime = 1200;

		// Token: 0x04003E2A RID: 15914
		[Token(Token = "0x4003E2A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float ownerHitCheckDistance;

		// Token: 0x04003E2B RID: 15915
		[Token(Token = "0x4003E2B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool arrow;

		// Token: 0x04003E2C RID: 15916
		[Token(Token = "0x4003E2C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int numHits;

		// Token: 0x04003E2D RID: 15917
		[Token(Token = "0x4003E2D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool bobber;

		// Token: 0x04003E2E RID: 15918
		[Token(Token = "0x4003E2E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool netImportant;

		// Token: 0x04003E2F RID: 15919
		[Token(Token = "0x4003E2F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool noDropItem;

		// Token: 0x04003E30 RID: 15920
		[Token(Token = "0x4003E30")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static int maxAI;

		// Token: 0x04003E31 RID: 15921
		[Token(Token = "0x4003E31")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		public bool counterweight;

		// Token: 0x04003E32 RID: 15922
		[Token(Token = "0x4003E32")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float scale;

		// Token: 0x04003E33 RID: 15923
		[Token(Token = "0x4003E33")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float rotation;

		// Token: 0x04003E34 RID: 15924
		[Token(Token = "0x4003E34")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int type;

		// Token: 0x04003E35 RID: 15925
		[Token(Token = "0x4003E35")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int alpha;

		// Token: 0x04003E36 RID: 15926
		[Token(Token = "0x4003E36")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int immunityIdentity;

		// Token: 0x04003E37 RID: 15927
		[Token(Token = "0x4003E37")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool sentry;

		// Token: 0x04003E38 RID: 15928
		[Token(Token = "0x4003E38")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public short glowMask;

		// Token: 0x04003E39 RID: 15929
		[Token(Token = "0x4003E39")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int owner;

		// Token: 0x04003E3A RID: 15930
		[Token(Token = "0x4003E3A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Float_FixedArray_3 ai;

		// Token: 0x04003E3B RID: 15931
		[Token(Token = "0x4003E3B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Float_FixedArray_3 localAI;

		// Token: 0x04003E3C RID: 15932
		[Token(Token = "0x4003E3C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float gfxOffY;

		// Token: 0x04003E3D RID: 15933
		[Token(Token = "0x4003E3D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float stepSpeed;

		// Token: 0x04003E3E RID: 15934
		[Token(Token = "0x4003E3E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int aiStyle;

		// Token: 0x04003E3F RID: 15935
		[Token(Token = "0x4003E3F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int timeLeft;

		// Token: 0x04003E40 RID: 15936
		[Token(Token = "0x4003E40")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int soundDelay;

		// Token: 0x04003E41 RID: 15937
		[Token(Token = "0x4003E41")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int damage;

		// Token: 0x04003E42 RID: 15938
		[Token(Token = "0x4003E42")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public int originalDamage;

		// Token: 0x04003E43 RID: 15939
		[Token(Token = "0x4003E43")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int spriteDirection;

		// Token: 0x04003E44 RID: 15940
		[Token(Token = "0x4003E44")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool hostile;

		// Token: 0x04003E45 RID: 15941
		[Token(Token = "0x4003E45")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool reflected;

		// Token: 0x04003E46 RID: 15942
		[Token(Token = "0x4003E46")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float knockBack;

		// Token: 0x04003E47 RID: 15943
		[Token(Token = "0x4003E47")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool friendly;

		// Token: 0x04003E48 RID: 15944
		[Token(Token = "0x4003E48")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public int penetrate;

		// Token: 0x04003E49 RID: 15945
		[Token(Token = "0x4003E49")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public DictionaryIntArray localNPCImmunity;

		// Token: 0x04003E4A RID: 15946
		[Token(Token = "0x4003E4A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool usesLocalNPCImmunity;

		// Token: 0x04003E4B RID: 15947
		[Token(Token = "0x4003E4B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool usesIDStaticNPCImmunity;

		// Token: 0x04003E4C RID: 15948
		[Token(Token = "0x4003E4C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBE")]
		public bool appliesImmunityTimeOnSingleHits;

		// Token: 0x04003E4D RID: 15949
		[Token(Token = "0x4003E4D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public int maxPenetrate;

		// Token: 0x04003E4E RID: 15950
		[Token(Token = "0x4003E4E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public ProjectileKey key;

		// Token: 0x04003E4F RID: 15951
		[Token(Token = "0x4003E4F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float light;

		// Token: 0x04003E50 RID: 15952
		[Token(Token = "0x4003E50")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool netUpdate;

		// Token: 0x04003E51 RID: 15953
		[Token(Token = "0x4003E51")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		public bool netUpdate2;

		// Token: 0x04003E52 RID: 15954
		[Token(Token = "0x4003E52")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int netSpam;

		// Token: 0x04003E53 RID: 15955
		[Token(Token = "0x4003E53")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		internal bool[] netSyncSkippedForPlayer;

		// Token: 0x04003E54 RID: 15956
		[Token(Token = "0x4003E54")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Vector2_DynamicArray_120 oldPos;

		// Token: 0x04003E55 RID: 15957
		[Token(Token = "0x4003E55")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x49C")]
		public Float_DynamicArray_120 oldRot;

		// Token: 0x04003E56 RID: 15958
		[Token(Token = "0x4003E56")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x680")]
		public Int_DynamicArray_120 oldSpriteDirection;

		// Token: 0x04003E57 RID: 15959
		[Token(Token = "0x4003E57")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x864")]
		public bool minion;

		// Token: 0x04003E58 RID: 15960
		[Token(Token = "0x4003E58")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x868")]
		public float minionSlots;

		// Token: 0x04003E59 RID: 15961
		[Token(Token = "0x4003E59")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x86C")]
		public int minionPos;

		// Token: 0x04003E5A RID: 15962
		[Token(Token = "0x4003E5A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x870")]
		public int restrikeDelay;

		// Token: 0x04003E5B RID: 15963
		[Token(Token = "0x4003E5B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x874")]
		public bool tileCollide;

		// Token: 0x04003E5C RID: 15964
		[Token(Token = "0x4003E5C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x878")]
		public int extraUpdates;

		// Token: 0x04003E5D RID: 15965
		[Token(Token = "0x4003E5D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x87C")]
		public bool stopsDealingDamageAfterPenetrateHits;

		// Token: 0x04003E5E RID: 15966
		[Token(Token = "0x4003E5E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x880")]
		public int numUpdates;

		// Token: 0x04003E5F RID: 15967
		[Token(Token = "0x4003E5F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x884")]
		public bool ignoreWater;

		// Token: 0x04003E60 RID: 15968
		[Token(Token = "0x4003E60")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x885")]
		public bool isAPreviewDummy;

		// Token: 0x04003E61 RID: 15969
		[Token(Token = "0x4003E61")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x886")]
		public bool isAPreviewDisplayDoll;

		// Token: 0x04003E62 RID: 15970
		[Token(Token = "0x4003E62")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x888")]
		public MinionSpawnInfo MinionSpawnInfo;

		// Token: 0x04003E63 RID: 15971
		[Token(Token = "0x4003E63")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88C")]
		public object customHitbox;

		// Token: 0x04003E64 RID: 15972
		[Token(Token = "0x4003E64")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x890")]
		public int drawLayer;

		// Token: 0x04003E65 RID: 15973
		[Token(Token = "0x4003E65")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x894")]
		public bool usesOwnerLight;

		// Token: 0x04003E66 RID: 15974
		[Token(Token = "0x4003E66")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x895")]
		public bool hide;

		// Token: 0x04003E67 RID: 15975
		[Token(Token = "0x4003E67")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x896")]
		public bool ownerHitCheck;

		// Token: 0x04003E68 RID: 15976
		[Token(Token = "0x4003E68")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x897")]
		public bool usesOwnerMeleeHitCD;

		// Token: 0x04003E69 RID: 15977
		[Token(Token = "0x4003E69")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x898")]
		public DictionaryIntArray playerImmune;

		// Token: 0x04003E6A RID: 15978
		[Token(Token = "0x4003E6A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x89C")]
		public string miscText;

		// Token: 0x04003E6B RID: 15979
		[Token(Token = "0x4003E6B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A0")]
		public bool melee;

		// Token: 0x04003E6C RID: 15980
		[Token(Token = "0x4003E6C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A1")]
		public bool ranged;

		// Token: 0x04003E6D RID: 15981
		[Token(Token = "0x4003E6D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A2")]
		public bool magic;

		// Token: 0x04003E6E RID: 15982
		[Token(Token = "0x4003E6E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A3")]
		public bool coldDamage;

		// Token: 0x04003E6F RID: 15983
		[Token(Token = "0x4003E6F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A4")]
		public bool noEnchantments;

		// Token: 0x04003E70 RID: 15984
		[Token(Token = "0x4003E70")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A5")]
		public bool noEnchantmentVisuals;

		// Token: 0x04003E71 RID: 15985
		[Token(Token = "0x4003E71")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A6")]
		public bool trap;

		// Token: 0x04003E72 RID: 15986
		[Token(Token = "0x4003E72")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A7")]
		public bool npcProj;

		// Token: 0x04003E73 RID: 15987
		[Token(Token = "0x4003E73")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A8")]
		public bool originatedFromActivableTile;

		// Token: 0x04003E74 RID: 15988
		[Token(Token = "0x4003E74")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8AC")]
		public int frameCounter;

		// Token: 0x04003E75 RID: 15989
		[Token(Token = "0x4003E75")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8B0")]
		public int frame;

		// Token: 0x04003E76 RID: 15990
		[Token(Token = "0x4003E76")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8B4")]
		public bool manualDirectionChange;

		// Token: 0x04003E77 RID: 15991
		[Token(Token = "0x4003E77")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8B5")]
		public bool correctSlopeCollision;

		// Token: 0x04003E78 RID: 15992
		[Token(Token = "0x4003E78")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8B6")]
		public bool decidesManualFallThrough;

		// Token: 0x04003E79 RID: 15993
		[Token(Token = "0x4003E79")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8B7")]
		public bool shouldFallThrough;

		// Token: 0x04003E7A RID: 15994
		[Token(Token = "0x4003E7A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8B8")]
		public int localNPCHitCooldown;

		// Token: 0x04003E7B RID: 15995
		[Token(Token = "0x4003E7B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8BC")]
		public int idStaticNPCHitCooldown;

		// Token: 0x04003E7C RID: 15996
		[Token(Token = "0x4003E7C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C0")]
		public int bannerIdToRespondTo;

		// Token: 0x04003E7D RID: 15997
		[Token(Token = "0x4003E7D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C4")]
		public int tagEffectType;

		// Token: 0x04003E7E RID: 15998
		[Token(Token = "0x4003E7E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C8")]
		public int bonusTagDamage;

		// Token: 0x04003E7F RID: 15999
		[Token(Token = "0x4003E7F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8CC")]
		public int armorPenetration;

		// Token: 0x04003E80 RID: 16000
		[Token(Token = "0x4003E80")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8D0")]
		public int bonusCritChance;

		// Token: 0x04003E81 RID: 16001
		[Token(Token = "0x4003E81")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8D4")]
		public GameDifficultyData.LinearCurve hostileDamageScaling;

		// Token: 0x04003E82 RID: 16002
		[Token(Token = "0x4003E82")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static Conditions.IsSolid _cachedConditions_solid;

		// Token: 0x04003E83 RID: 16003
		[Token(Token = "0x4003E83")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Conditions.NotNull _cachedConditions_notNull;

		// Token: 0x04003E84 RID: 16004
		[Token(Token = "0x4003E84")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static int[] npcCrystalDartList;

		// Token: 0x04003E85 RID: 16005
		[Token(Token = "0x4003E85")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Point[] _javelinsMax6;

		// Token: 0x04003E86 RID: 16006
		[Token(Token = "0x4003E86")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static Point[] _javelinsMax8;

		// Token: 0x04003E87 RID: 16007
		[Token(Token = "0x4003E87")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Point[] _javelinsMax10;

		// Token: 0x04003E88 RID: 16008
		[Token(Token = "0x4003E88")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static List<int> _snappingStoneSkipTargets;

		// Token: 0x04003E89 RID: 16009
		[Token(Token = "0x4003E89")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8D8")]
		private Vector2? _lightningLastHitChainPos;

		// Token: 0x04003E8A RID: 16010
		[Token(Token = "0x4003E8A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Rectangle _whipHitboxBounds;

		// Token: 0x04003E8B RID: 16011
		[Token(Token = "0x4003E8B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8E4")]
		public List<Vector2> WhipPointsForCollision;

		// Token: 0x04003E8C RID: 16012
		[Token(Token = "0x4003E8C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static Rectangle _lanceHitboxBounds;

		// Token: 0x04003E8D RID: 16013
		[Token(Token = "0x4003E8D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static List<NPC> _rainbowBoulderTargetsAny;

		// Token: 0x04003E8E RID: 16014
		[Token(Token = "0x4003E8E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private static List<NPC> _rainbowBoulderTargetsFar;

		// Token: 0x04003E8F RID: 16015
		[Token(Token = "0x4003E8F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static List<FishPossibilityEntry> _availableFishTypesToShow;

		// Token: 0x04003E90 RID: 16016
		[Token(Token = "0x4003E90")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private static FishingContext _context;

		// Token: 0x04003E91 RID: 16017
		[Token(Token = "0x4003E91")]
		public const int StormLightningLiquidDamageRadius = 500;

		// Token: 0x04003E92 RID: 16018
		[Token(Token = "0x4003E92")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static Projectile.NPCDistanceByIndexComparator _medusaTargetComparer;

		// Token: 0x04003E93 RID: 16019
		[Token(Token = "0x4003E93")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static float kiteSoundPitch;

		// Token: 0x04003E94 RID: 16020
		[Token(Token = "0x4003E94")]
		public const float MinimumWindStrengthToFlyKite = 0.2f;

		// Token: 0x04003E95 RID: 16021
		[Token(Token = "0x4003E95")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static List<Point> _miningHelperPointsToSkip;

		// Token: 0x04003E96 RID: 16022
		[Token(Token = "0x4003E96")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public static List<int> ai92Projectiles;

		// Token: 0x020004A6 RID: 1190
		[Token(Token = "0x20004A6")]
		public struct GemStaffFeatures
		{
			// Token: 0x1700060D RID: 1549
			// (get) Token: 0x06002E7C RID: 11900 RVA: 0x00016338 File Offset: 0x00014538
			// (set) Token: 0x06002E7D RID: 11901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700060D")]
			public bool Homing
			{
				[Token(Token = "0x6002E7C")]
				[Address(RVA = "0x1886914", Offset = "0x1886914", VA = "0x1886914")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002E7D")]
				[Address(RVA = "0x188693C", Offset = "0x188693C", VA = "0x188693C")]
				set
				{
				}
			}

			// Token: 0x1700060E RID: 1550
			// (get) Token: 0x06002E7E RID: 11902 RVA: 0x00016350 File Offset: 0x00014550
			// (set) Token: 0x06002E7F RID: 11903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700060E")]
			public bool FastThenSlow
			{
				[Token(Token = "0x6002E7E")]
				[Address(RVA = "0x1886978", Offset = "0x1886978", VA = "0x1886978")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002E7F")]
				[Address(RVA = "0x1886984", Offset = "0x1886984", VA = "0x1886984")]
				set
				{
				}
			}

			// Token: 0x1700060F RID: 1551
			// (get) Token: 0x06002E80 RID: 11904 RVA: 0x00016368 File Offset: 0x00014568
			// (set) Token: 0x06002E81 RID: 11905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700060F")]
			public bool CanBounce
			{
				[Token(Token = "0x6002E80")]
				[Address(RVA = "0x188699C", Offset = "0x188699C", VA = "0x188699C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002E81")]
				[Address(RVA = "0x18869A8", Offset = "0x18869A8", VA = "0x18869A8")]
				set
				{
				}
			}

			// Token: 0x17000610 RID: 1552
			// (get) Token: 0x06002E82 RID: 11906 RVA: 0x00016380 File Offset: 0x00014580
			// (set) Token: 0x06002E83 RID: 11907 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000610")]
			public bool AoeExplosion
			{
				[Token(Token = "0x6002E82")]
				[Address(RVA = "0x18869C0", Offset = "0x18869C0", VA = "0x18869C0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002E83")]
				[Address(RVA = "0x18869CC", Offset = "0x18869CC", VA = "0x18869CC")]
				set
				{
				}
			}

			// Token: 0x17000611 RID: 1553
			// (get) Token: 0x06002E84 RID: 11908 RVA: 0x00016398 File Offset: 0x00014598
			// (set) Token: 0x06002E85 RID: 11909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000611")]
			public bool SwirlTwins
			{
				[Token(Token = "0x6002E84")]
				[Address(RVA = "0x18869E4", Offset = "0x18869E4", VA = "0x18869E4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002E85")]
				[Address(RVA = "0x18869F0", Offset = "0x18869F0", VA = "0x18869F0")]
				set
				{
				}
			}

			// Token: 0x17000612 RID: 1554
			// (get) Token: 0x06002E86 RID: 11910 RVA: 0x000163B0 File Offset: 0x000145B0
			// (set) Token: 0x06002E87 RID: 11911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000612")]
			public bool ArPenSpread
			{
				[Token(Token = "0x6002E86")]
				[Address(RVA = "0x1886A08", Offset = "0x1886A08", VA = "0x1886A08")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002E87")]
				[Address(RVA = "0x1886A14", Offset = "0x1886A14", VA = "0x1886A14")]
				set
				{
				}
			}

			// Token: 0x17000613 RID: 1555
			// (get) Token: 0x06002E88 RID: 11912 RVA: 0x000163C8 File Offset: 0x000145C8
			// (set) Token: 0x06002E89 RID: 11913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000613")]
			public bool BiggerHitbox
			{
				[Token(Token = "0x6002E88")]
				[Address(RVA = "0x1886A2C", Offset = "0x1886A2C", VA = "0x1886A2C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002E89")]
				[Address(RVA = "0x1886A38", Offset = "0x1886A38", VA = "0x1886A38")]
				set
				{
				}
			}

			// Token: 0x17000614 RID: 1556
			// (get) Token: 0x06002E8A RID: 11914 RVA: 0x000163E0 File Offset: 0x000145E0
			// (set) Token: 0x06002E8B RID: 11915 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000614")]
			public bool AllGems
			{
				[Token(Token = "0x6002E8A")]
				[Address(RVA = "0x1886A50", Offset = "0x1886A50", VA = "0x1886A50")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002E8B")]
				[Address(RVA = "0x1886A5C", Offset = "0x1886A5C", VA = "0x1886A5C")]
				set
				{
				}
			}

			// Token: 0x17000615 RID: 1557
			// (get) Token: 0x06002E8C RID: 11916 RVA: 0x000163F8 File Offset: 0x000145F8
			// (set) Token: 0x06002E8D RID: 11917 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000615")]
			public bool RepeatsGem
			{
				[Token(Token = "0x6002E8C")]
				[Address(RVA = "0x1886A74", Offset = "0x1886A74", VA = "0x1886A74")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002E8D")]
				[Address(RVA = "0x1886A80", Offset = "0x1886A80", VA = "0x1886A80")]
				set
				{
				}
			}

			// Token: 0x17000616 RID: 1558
			// (get) Token: 0x06002E8E RID: 11918 RVA: 0x00016410 File Offset: 0x00014610
			// (set) Token: 0x06002E8F RID: 11919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000616")]
			public bool AllGems2
			{
				[Token(Token = "0x6002E8E")]
				[Address(RVA = "0x1886A98", Offset = "0x1886A98", VA = "0x1886A98")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002E8F")]
				[Address(RVA = "0x1886AA4", Offset = "0x1886AA4", VA = "0x1886AA4")]
				set
				{
				}
			}

			// Token: 0x06002E90 RID: 11920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002E90")]
			[Address(RVA = "0x1886ABC", Offset = "0x1886ABC", VA = "0x1886ABC")]
			public GemStaffFeatures(float aiState)
			{
			}

			// Token: 0x06002E91 RID: 11921 RVA: 0x00016428 File Offset: 0x00014628
			[Token(Token = "0x6002E91")]
			[Address(RVA = "0x1886AC8", Offset = "0x1886AC8", VA = "0x1886AC8")]
			public float GetDamageMultiplier()
			{
				return 0f;
			}

			// Token: 0x04003E97 RID: 16023
			[Token(Token = "0x4003E97")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FloatIntUnion Bits;
		}

		// Token: 0x020004A7 RID: 1191
		[Token(Token = "0x20004A7")]
		private class NPCDistanceByIndexComparator : FileAPI
		{
			// Token: 0x06002E92 RID: 11922 RVA: 0x00016440 File Offset: 0x00014640
			[Token(Token = "0x6002E92")]
			[Address(RVA = "0x1886C00", Offset = "0x1886C00", VA = "0x1886C00", Slot = "4")]
			public int Compare(Tuple<int, float> npcIndex1, Tuple<int, float> npcIndex2)
			{
				return 0;
			}

			// Token: 0x06002E93 RID: 11923 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002E93")]
			[Address(RVA = "0x1886C80", Offset = "0x1886C80", VA = "0x1886C80")]
			public NPCDistanceByIndexComparator()
			{
			}
		}

		// Token: 0x020004A8 RID: 1192
		[Token(Token = "0x20004A8")]
		public struct HallowBossPelletStormInfo
		{
			// Token: 0x06002E94 RID: 11924 RVA: 0x00016458 File Offset: 0x00014658
			[Token(Token = "0x6002E94")]
			[Address(RVA = "0x1886C88", Offset = "0x1886C88", VA = "0x1886C88")]
			public float GetBulletProgress(int bulletIndex)
			{
				return 0f;
			}

			// Token: 0x06002E95 RID: 11925 RVA: 0x00016470 File Offset: 0x00014670
			[Token(Token = "0x6002E95")]
			[Address(RVA = "0x1886CA4", Offset = "0x1886CA4", VA = "0x1886CA4")]
			public bool IsValid(int bulletIndex)
			{
				return default(bool);
			}

			// Token: 0x06002E96 RID: 11926 RVA: 0x00016488 File Offset: 0x00014688
			[Token(Token = "0x6002E96")]
			[Address(RVA = "0x1886CE4", Offset = "0x1886CE4", VA = "0x1886CE4")]
			public Vector2 GetBulletPosition(int bulletIndex, Vector2 centerPoint)
			{
				return default(Vector2);
			}

			// Token: 0x06002E97 RID: 11927 RVA: 0x000164A0 File Offset: 0x000146A0
			[Token(Token = "0x6002E97")]
			[Address(RVA = "0x1886E88", Offset = "0x1886E88", VA = "0x1886E88")]
			public Rectangle GetBulletHitbox(int bulletIndex, Vector2 centerPoint)
			{
				return default(Rectangle);
			}

			// Token: 0x04003E98 RID: 16024
			[Token(Token = "0x4003E98")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float StartAngle;

			// Token: 0x04003E99 RID: 16025
			[Token(Token = "0x4003E99")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float AnglePerBullet;

			// Token: 0x04003E9A RID: 16026
			[Token(Token = "0x4003E9A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int BulletsInStorm;

			// Token: 0x04003E9B RID: 16027
			[Token(Token = "0x4003E9B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float BulletsProgressInStormStartNormalized;

			// Token: 0x04003E9C RID: 16028
			[Token(Token = "0x4003E9C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float BulletsProgressInStormBonusByIndexNormalized;

			// Token: 0x04003E9D RID: 16029
			[Token(Token = "0x4003E9D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float StormTotalRange;

			// Token: 0x04003E9E RID: 16030
			[Token(Token = "0x4003E9E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector2 BulletSize;
		}

		// Token: 0x020004A9 RID: 1193
		[Token(Token = "0x20004A9")]
		public struct AI_001_Features
		{
			// Token: 0x06002E98 RID: 11928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002E98")]
			[Address(RVA = "0x1886F50", Offset = "0x1886F50", VA = "0x1886F50")]
			public AI_001_Features(float aiState)
			{
			}

			// Token: 0x17000617 RID: 1559
			// (get) Token: 0x06002E99 RID: 11929 RVA: 0x000164B8 File Offset: 0x000146B8
			// (set) Token: 0x06002E9A RID: 11930 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000617")]
			public bool HarpyCharmed
			{
				[Token(Token = "0x6002E99")]
				[Address(RVA = "0x1886F58", Offset = "0x1886F58", VA = "0x1886F58")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002E9A")]
				[Address(RVA = "0x1886F64", Offset = "0x1886F64", VA = "0x1886F64")]
				set
				{
				}
			}

			// Token: 0x17000618 RID: 1560
			// (get) Token: 0x06002E9B RID: 11931 RVA: 0x000164D0 File Offset: 0x000146D0
			// (set) Token: 0x06002E9C RID: 11932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000618")]
			public bool HarpyCharmConsumed
			{
				[Token(Token = "0x6002E9B")]
				[Address(RVA = "0x1886F7C", Offset = "0x1886F7C", VA = "0x1886F7C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002E9C")]
				[Address(RVA = "0x1886F88", Offset = "0x1886F88", VA = "0x1886F88")]
				set
				{
				}
			}

			// Token: 0x17000619 RID: 1561
			// (get) Token: 0x06002E9D RID: 11933 RVA: 0x000164E8 File Offset: 0x000146E8
			// (set) Token: 0x06002E9E RID: 11934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000619")]
			public bool PhoenixQuivered
			{
				[Token(Token = "0x6002E9D")]
				[Address(RVA = "0x1886FA0", Offset = "0x1886FA0", VA = "0x1886FA0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002E9E")]
				[Address(RVA = "0x1886FAC", Offset = "0x1886FAC", VA = "0x1886FAC")]
				set
				{
				}
			}

			// Token: 0x1700061A RID: 1562
			// (get) Token: 0x06002E9F RID: 11935 RVA: 0x00016500 File Offset: 0x00014700
			// (set) Token: 0x06002EA0 RID: 11936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700061A")]
			public bool SeraphNecklaced
			{
				[Token(Token = "0x6002E9F")]
				[Address(RVA = "0x1886FC4", Offset = "0x1886FC4", VA = "0x1886FC4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002EA0")]
				[Address(RVA = "0x1886FD0", Offset = "0x1886FD0", VA = "0x1886FD0")]
				set
				{
				}
			}

			// Token: 0x04003E9F RID: 16031
			[Token(Token = "0x4003E9F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FloatIntUnion Bits;
		}

		// Token: 0x020004AA RID: 1194
		[Token(Token = "0x20004AA")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002EA2 RID: 11938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002EA2")]
			[Address(RVA = "0x188705C", Offset = "0x188705C", VA = "0x188705C")]
			public <>c()
			{
			}

			// Token: 0x06002EA3 RID: 11939 RVA: 0x00016518 File Offset: 0x00014718
			[Token(Token = "0x6002EA3")]
			[Address(RVA = "0x1887064", Offset = "0x1887064", VA = "0x1887064")]
			internal bool <StormLightningLiquidCollisionCheck>b__190_0(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x04003EA0 RID: 16032
			[Token(Token = "0x4003EA0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Projectile.<>c <>9;

			// Token: 0x04003EA1 RID: 16033
			[Token(Token = "0x4003EA1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Utils.TileActionAttempt <>9__190_0;
		}
	}
}
