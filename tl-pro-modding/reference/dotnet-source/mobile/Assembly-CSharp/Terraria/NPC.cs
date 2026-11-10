using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.Localization;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x02000483 RID: 1155
	[Token(Token = "0x2000483")]
	public class NPC : Entity
	{
		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x00012300 File Offset: 0x00010500
		[Token(Token = "0x1700056B")]
		public bool CanTalk
		{
			[Token(Token = "0x6002624")]
			[Address(RVA = "0x12ECEE0", Offset = "0x12ECEE0", VA = "0x12ECEE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06002625 RID: 9765 RVA: 0x00012318 File Offset: 0x00010518
		[Token(Token = "0x1700056C")]
		public bool CanBeTalkedTo
		{
			[Token(Token = "0x6002625")]
			[Address(RVA = "0x12ECFD4", Offset = "0x12ECFD4", VA = "0x12ECFD4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06002626 RID: 9766 RVA: 0x00012330 File Offset: 0x00010530
		[Token(Token = "0x1700056D")]
		public bool HasValidTarget
		{
			[Token(Token = "0x6002626")]
			[Address(RVA = "0x12ED024", Offset = "0x12ED024", VA = "0x12ED024")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06002627 RID: 9767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700056E")]
		private Player TargetPlayer
		{
			[Token(Token = "0x6002627")]
			[Address(RVA = "0x12ED1EC", Offset = "0x12ED1EC", VA = "0x12ED1EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x00012348 File Offset: 0x00010548
		[Token(Token = "0x1700056F")]
		public bool HasPlayerTarget
		{
			[Token(Token = "0x6002628")]
			[Address(RVA = "0x12ED1D8", Offset = "0x12ED1D8", VA = "0x12ED1D8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06002629 RID: 9769 RVA: 0x00012360 File Offset: 0x00010560
		[Token(Token = "0x17000570")]
		public bool HasNPCTarget
		{
			[Token(Token = "0x6002629")]
			[Address(RVA = "0x12ED330", Offset = "0x12ED330", VA = "0x12ED330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x00012378 File Offset: 0x00010578
		[Token(Token = "0x17000571")]
		public bool SupportsNPCTargets
		{
			[Token(Token = "0x600262A")]
			[Address(RVA = "0x12ED2B0", Offset = "0x12ED2B0", VA = "0x12ED2B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x0600262B RID: 9771 RVA: 0x00012390 File Offset: 0x00010590
		[Token(Token = "0x17000572")]
		public int TranslatedTargetIndex
		{
			[Token(Token = "0x600262B")]
			[Address(RVA = "0x12ED348", Offset = "0x12ED348", VA = "0x12ED348")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x0600262C RID: 9772 RVA: 0x000123A8 File Offset: 0x000105A8
		[Token(Token = "0x17000573")]
		public int WhoAmIToTargetingIndex
		{
			[Token(Token = "0x600262C")]
			[Address(RVA = "0x12ED35C", Offset = "0x12ED35C", VA = "0x12ED35C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x000123C0 File Offset: 0x000105C0
		[Token(Token = "0x600262D")]
		[Address(RVA = "0x12ED368", Offset = "0x12ED368", VA = "0x12ED368")]
		public NPCAimedTarget GetTargetData(bool ignorePlayerTankPets = true)
		{
			return default(NPCAimedTarget);
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x000123D8 File Offset: 0x000105D8
		[Token(Token = "0x17000574")]
		public bool IsShimmerVariant
		{
			[Token(Token = "0x600262E")]
			[Address(RVA = "0x12ED518", Offset = "0x12ED518", VA = "0x12ED518")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262F")]
		[Address(RVA = "0x12ED5B0", Offset = "0x12ED5B0", VA = "0x12ED5B0")]
		public static int[,,] InitializeMoonLordAttacks()
		{
			return null;
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002630")]
		[Address(RVA = "0x12EDAE8", Offset = "0x12EDAE8", VA = "0x12EDAE8")]
		public static int[,] InitializeMoonLordAttacks2()
		{
			return null;
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06002631 RID: 9777 RVA: 0x000123F0 File Offset: 0x000105F0
		// (set) Token: 0x06002632 RID: 9778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000575")]
		public byte generation
		{
			[Token(Token = "0x6002631")]
			[Address(RVA = "0x12EDDE8", Offset = "0x12EDDE8", VA = "0x12EDDE8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002632")]
			[Address(RVA = "0x12EDDF0", Offset = "0x12EDDF0", VA = "0x12EDDF0")]
			private set
			{
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06002633 RID: 9779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000576")]
		public string TypeName
		{
			[Token(Token = "0x6002633")]
			[Address(RVA = "0x12EDDF8", Offset = "0x12EDDF8", VA = "0x12EDDF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000577")]
		public string FullName
		{
			[Token(Token = "0x6002634")]
			[Address(RVA = "0x12EDE64", Offset = "0x12EDE64", VA = "0x12EDE64")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x00012408 File Offset: 0x00010608
		[Token(Token = "0x17000578")]
		public bool HasGivenName
		{
			[Token(Token = "0x6002635")]
			[Address(RVA = "0x12EDFD8", Offset = "0x12EDFD8", VA = "0x12EDFD8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000579")]
		public string GivenOrTypeName
		{
			[Token(Token = "0x6002636")]
			[Address(RVA = "0x12EDFFC", Offset = "0x12EDFFC", VA = "0x12EDFFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06002637 RID: 9783 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002638 RID: 9784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057A")]
		public string GivenName
		{
			[Token(Token = "0x6002637")]
			[Address(RVA = "0x12EE088", Offset = "0x12EE088", VA = "0x12EE088")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002638")]
			[Address(RVA = "0x12EE090", Offset = "0x12EE090", VA = "0x12EE090")]
			set
			{
			}
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002639")]
		[Address(RVA = "0x12EE100", Offset = "0x12EE100", VA = "0x12EE100")]
		public static string GetFullnameByID(int npcID)
		{
			return null;
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x00012420 File Offset: 0x00010620
		[Token(Token = "0x1700057B")]
		public static bool downedTowers
		{
			[Token(Token = "0x600263A")]
			[Address(RVA = "0x12EE274", Offset = "0x12EE274", VA = "0x12EE274")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600263B RID: 9787 RVA: 0x00012438 File Offset: 0x00010638
		[Token(Token = "0x1700057C")]
		public static bool DownedAnyPreHardmodeBoss
		{
			[Token(Token = "0x600263B")]
			[Address(RVA = "0x12EE354", Offset = "0x12EE354", VA = "0x12EE354")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x00012450 File Offset: 0x00010650
		[Token(Token = "0x1700057D")]
		public static int ShieldStrengthTowerMax
		{
			[Token(Token = "0x600263C")]
			[Address(RVA = "0x12EE4C0", Offset = "0x12EE4C0", VA = "0x12EE4C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600263D RID: 9789 RVA: 0x00012468 File Offset: 0x00010668
		[Token(Token = "0x1700057E")]
		public static bool TowersDefeated
		{
			[Token(Token = "0x600263D")]
			[Address(RVA = "0x12EE534", Offset = "0x12EE534", VA = "0x12EE534")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x00012480 File Offset: 0x00010680
		[Token(Token = "0x600263E")]
		[Address(RVA = "0x12EE614", Offset = "0x12EE614", VA = "0x12EE614")]
		public static bool BusyWithAnyInvasionOfSorts()
		{
			return default(bool);
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600263F RID: 9791 RVA: 0x00012498 File Offset: 0x00010698
		// (set) Token: 0x06002640 RID: 9792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057F")]
		public float Opacity
		{
			[Token(Token = "0x600263F")]
			[Address(RVA = "0x12EE784", Offset = "0x12EE784", VA = "0x12EE784")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002640")]
			[Address(RVA = "0x12EE7A8", Offset = "0x12EE7A8", VA = "0x12EE7A8")]
			set
			{
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06002641 RID: 9793 RVA: 0x000124B0 File Offset: 0x000106B0
		[Token(Token = "0x17000580")]
		public bool ShowLife
		{
			[Token(Token = "0x6002641")]
			[Address(RVA = "0x12EE808", Offset = "0x12EE808", VA = "0x12EE808")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06002642 RID: 9794 RVA: 0x000124C8 File Offset: 0x000106C8
		[Token(Token = "0x17000581")]
		public bool TreatedAsABossForRainbowBoulders
		{
			[Token(Token = "0x6002642")]
			[Address(RVA = "0x12EE828", Offset = "0x12EE828", VA = "0x12EE828")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x000124E0 File Offset: 0x000106E0
		[Token(Token = "0x6002643")]
		[Address(RVA = "0x12EE8C0", Offset = "0x12EE8C0", VA = "0x12EE8C0")]
		public float GetKnockbackMultiplier_ScaledByDifficulty(float normalKnockbackMult)
		{
			return 0f;
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x000124F8 File Offset: 0x000106F8
		[Token(Token = "0x6002644")]
		[Address(RVA = "0x12EE968", Offset = "0x12EE968", VA = "0x12EE968")]
		public int GetAttackDamage_ScaledByDifficulty(float normalDamage)
		{
			return 0;
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x00012510 File Offset: 0x00010710
		[Token(Token = "0x6002645")]
		[Address(RVA = "0x12EEA28", Offset = "0x12EEA28", VA = "0x12EEA28")]
		public int GetAttackDamage_CappedAtMaster(float normalDamage)
		{
			return 0;
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x00012528 File Offset: 0x00010728
		[Token(Token = "0x6002646")]
		[Address(RVA = "0x12EEB70", Offset = "0x12EEB70", VA = "0x12EEB70")]
		public int GetAttackDamage_LerpBetweenFinalValues(float normalDamage, float expertDamage)
		{
			return 0;
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x00012540 File Offset: 0x00010740
		[Token(Token = "0x6002647")]
		[Address(RVA = "0x12EEC78", Offset = "0x12EEC78", VA = "0x12EEC78")]
		public int GetAttackDamage_ForProjectiles(float normalDamage, float expertDamage)
		{
			return 0;
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x00012558 File Offset: 0x00010758
		[Token(Token = "0x6002648")]
		[Address(RVA = "0x12EED80", Offset = "0x12EED80", VA = "0x12EED80")]
		public int GetAttackDamage_ForProjectiles_MultiLerp(float normalDamage, float expertDamage, float masterDamage)
		{
			return 0;
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x00012570 File Offset: 0x00010770
		[Token(Token = "0x6002649")]
		[Address(RVA = "0x12EEEFC", Offset = "0x12EEEFC", VA = "0x12EEEFC")]
		public int GetAttackDamage_ForTownNPC(float normalDamage)
		{
			return 0;
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x00012588 File Offset: 0x00010788
		[Token(Token = "0x17000582")]
		public bool isLikeATownNPC
		{
			[Token(Token = "0x600264A")]
			[Address(RVA = "0x12ECFAC", Offset = "0x12ECFAC", VA = "0x12ECFAC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x000125A0 File Offset: 0x000107A0
		[Token(Token = "0x600264B")]
		[Address(RVA = "0x12EEFF0", Offset = "0x12EEFF0", VA = "0x12EEFF0")]
		public static bool SpawnAllowed_Demolitionist()
		{
			return default(bool);
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x000125B8 File Offset: 0x000107B8
		[Token(Token = "0x600264C")]
		[Address(RVA = "0x12EF188", Offset = "0x12EF188", VA = "0x12EF188")]
		public static bool SpawnAllowed_ArmsDealer()
		{
			return default(bool);
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x000125D0 File Offset: 0x000107D0
		[Token(Token = "0x600264D")]
		[Address(RVA = "0x12EF334", Offset = "0x12EF334", VA = "0x12EF334")]
		public static bool SpawnAllowed_DyeTrader()
		{
			return default(bool);
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x000125E8 File Offset: 0x000107E8
		[Token(Token = "0x600264E")]
		[Address(RVA = "0x12EF608", Offset = "0x12EF608", VA = "0x12EF608")]
		public static bool SpawnAllowed_Nurse()
		{
			return default(bool);
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x00012600 File Offset: 0x00010800
		[Token(Token = "0x600264F")]
		[Address(RVA = "0x12EF710", Offset = "0x12EF710", VA = "0x12EF710")]
		public static bool SpawnAllowed_Merchant()
		{
			return default(bool);
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002650")]
		[Address(RVA = "0x12EF8BC", Offset = "0x12EF8BC", VA = "0x12EF8BC")]
		public static void ClearFoundActiveNPCs()
		{
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002651")]
		[Address(RVA = "0x12EF980", Offset = "0x12EF980", VA = "0x12EF980")]
		public static void UpdateFoundActiveNPCs()
		{
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002652")]
		[Address(RVA = "0x12EFA88", Offset = "0x12EFA88", VA = "0x12EFA88")]
		public static void ClearFoundNPCTypesForBestiary()
		{
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002653")]
		[Address(RVA = "0x12EFB4C", Offset = "0x12EFB4C", VA = "0x12EFB4C")]
		public void EncourageDespawn(int despawnTime)
		{
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002654")]
		[Address(RVA = "0x12EFB64", Offset = "0x12EFB64", VA = "0x12EFB64")]
		public void DiscourageDespawn(int despawnTime)
		{
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x00012618 File Offset: 0x00010818
		[Token(Token = "0x6002655")]
		[Address(RVA = "0x12EFB7C", Offset = "0x12EFB7C", VA = "0x12EFB7C")]
		public static bool WouldBeEncouragedToDespawn(int aistyle, int type)
		{
			return default(bool);
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002656")]
		[Address(RVA = "0x12EFBF8", Offset = "0x12EFBF8", VA = "0x12EFBF8")]
		public static string getNewNPCName(int npcType)
		{
			return null;
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002657")]
		[Address(RVA = "0x12EFC5C", Offset = "0x12EFC5C", VA = "0x12EFC5C")]
		private static string getNewNPCNameInner(int npcType)
		{
			return null;
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002658")]
		[Address(RVA = "0x12F1C38", Offset = "0x12F1C38", VA = "0x12F1C38")]
		public NetworkText GetTypeNetName()
		{
			return null;
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002659")]
		[Address(RVA = "0x12F1D64", Offset = "0x12F1D64", VA = "0x12F1D64")]
		public void GetLifeStats(out int statLife, out int statLifeMax)
		{
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00012630 File Offset: 0x00010830
		[Token(Token = "0x600265A")]
		[Address(RVA = "0x12F1E54", Offset = "0x12F1E54", VA = "0x12F1E54")]
		public float GetLifePercent()
		{
			return 0f;
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600265B")]
		[Address(RVA = "0x12F1E94", Offset = "0x12F1E94", VA = "0x12F1E94")]
		public NetworkText GetFullNetName()
		{
			return null;
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600265C")]
		[Address(RVA = "0x12F20B8", Offset = "0x12F20B8", VA = "0x12F20B8")]
		public NetworkText GetGivenOrTypeNetName()
		{
			return null;
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600265D")]
		[Address(RVA = "0x12F204C", Offset = "0x12F204C", VA = "0x12F204C")]
		public NetworkText GetGivenNetName()
		{
			return null;
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265E")]
		[Address(RVA = "0x12F214C", Offset = "0x12F214C", VA = "0x12F214C")]
		public static void setNPCName(string newName, int npcType, bool resetExtras = false)
		{
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600265F")]
		[Address(RVA = "0x12F2430", Offset = "0x12F2430", VA = "0x12F2430")]
		public static string firstNPCName(int npcType)
		{
			return null;
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002660")]
		[Address(RVA = "0x12F2660", Offset = "0x12F2660", VA = "0x12F2660")]
		public static string GetFirstNPCNameOrNull(int npcType)
		{
			return null;
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x00012648 File Offset: 0x00010848
		[Token(Token = "0x6002661")]
		[Address(RVA = "0x12F2818", Offset = "0x12F2818", VA = "0x12F2818")]
		public static bool MechSpawn(float x, float y, int type)
		{
			return default(bool);
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x00012660 File Offset: 0x00010860
		[Token(Token = "0x6002662")]
		[Address(RVA = "0x12F3154", Offset = "0x12F3154", VA = "0x12F3154")]
		public static int TypeToDefaultHeadIndex(int type)
		{
			return 0;
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x00012678 File Offset: 0x00010878
		[Token(Token = "0x6002663")]
		[Address(RVA = "0x12F37BC", Offset = "0x12F37BC", VA = "0x12F37BC")]
		public int GetBossHeadTextureIndex()
		{
			return 0;
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x00012690 File Offset: 0x00010890
		[Token(Token = "0x6002664")]
		[Address(RVA = "0x12F39F0", Offset = "0x12F39F0", VA = "0x12F39F0")]
		public float GetBossHeadRotation()
		{
			return 0f;
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x000126A8 File Offset: 0x000108A8
		[Token(Token = "0x6002665")]
		[Address(RVA = "0x12F3ACC", Offset = "0x12F3ACC", VA = "0x12F3ACC")]
		public SpriteEffects GetBossHeadSpriteEffects()
		{
			return SpriteEffects.None;
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x000126C0 File Offset: 0x000108C0
		[Token(Token = "0x6002666")]
		[Address(RVA = "0x12F3AF4", Offset = "0x12F3AF4", VA = "0x12F3AF4")]
		public int BannerID()
		{
			return 0;
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002667")]
		[Address(RVA = "0x12F3B10", Offset = "0x12F3B10", VA = "0x12F3B10")]
		private void SetDefaultsFromNetId(int id, [Optional] NPCSpawnParams spawnparams)
		{
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002668")]
		[Address(RVA = "0x12F4B94", Offset = "0x12F4B94", VA = "0x12F4B94")]
		public void SetDefaults_ForNetId(int Type, NPCSpawnParams spawnparams, float scaleOverride)
		{
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002669")]
		[Address(RVA = "0x12F4F30", Offset = "0x12F4F30", VA = "0x12F4F30")]
		public NPC()
		{
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266A")]
		[Address(RVA = "0x12F52A0", Offset = "0x12F52A0", VA = "0x12F52A0")]
		public static void ClearAll()
		{
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266B")]
		[Address(RVA = "0x12F5450", Offset = "0x12F5450", VA = "0x12F5450")]
		public static void ResetNPCSlotData(int npcIndex)
		{
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266C")]
		[Address(RVA = "0x12F56D8", Offset = "0x12F56D8", VA = "0x12F56D8")]
		public void OnSpawn(IEntitySource source)
		{
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266D")]
		[Address(RVA = "0x1227A68", Offset = "0x1227A68", VA = "0x1227A68")]
		public void SetDefaults(int Type, [Optional] NPCSpawnParams spawnparams)
		{
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266E")]
		[Address(RVA = "0x12F5880", Offset = "0x12F5880", VA = "0x12F5880")]
		private void getTenthAnniversaryAdjustments()
		{
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266F")]
		[Address(RVA = "0x12F5B5C", Offset = "0x12F5B5C", VA = "0x12F5B5C")]
		private void getZenithSeedAdjustmentsBeforeEverything()
		{
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002670")]
		[Address(RVA = "0x12F5BB0", Offset = "0x12F5BB0", VA = "0x12F5BB0")]
		private void getGoodAdjustments()
		{
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002671")]
		[Address(RVA = "0x12F627C", Offset = "0x12F627C", VA = "0x12F627C")]
		private void LazySetLiquidMovementDD2()
		{
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002672")]
		[Address(RVA = "0x12F628C", Offset = "0x12F628C", VA = "0x12F628C")]
		public static void SetWorldSpecificMonstersByWorldID()
		{
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x000126D8 File Offset: 0x000108D8
		[Token(Token = "0x6002673")]
		[Address(RVA = "0x12F651C", Offset = "0x12F651C", VA = "0x12F651C")]
		public NPCSpawnParams GetMatchingSpawnParams()
		{
			return default(NPCSpawnParams);
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002674")]
		[Address(RVA = "0x12F4C0C", Offset = "0x12F4C0C", VA = "0x12F4C0C")]
		public void ScaleStats(int? activePlayersCount, float? strengthOverride)
		{
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002675")]
		[Address(RVA = "0x12F6998", Offset = "0x12F6998", VA = "0x12F6998")]
		public void ScaleStats_ByDifficulty()
		{
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002676")]
		[Address(RVA = "0x12F74A0", Offset = "0x12F74A0", VA = "0x12F74A0")]
		private void ScaleStats_ByDifficulty_Tweaks()
		{
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x000126F0 File Offset: 0x000108F0
		[Token(Token = "0x6002677")]
		[Address(RVA = "0x12F89AC", Offset = "0x12F89AC", VA = "0x12F89AC")]
		public static float GetBalance()
		{
			return 0f;
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x00012708 File Offset: 0x00010908
		[Token(Token = "0x6002678")]
		[Address(RVA = "0x12F8B24", Offset = "0x12F8B24", VA = "0x12F8B24")]
		public float GetMyBalance()
		{
			return 0f;
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x00012720 File Offset: 0x00010920
		[Token(Token = "0x6002679")]
		[Address(RVA = "0x12F6C40", Offset = "0x12F6C40", VA = "0x12F6C40")]
		private static int GetActivePlayerCount()
		{
			return 0;
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267A")]
		[Address(RVA = "0x12F6618", Offset = "0x12F6618", VA = "0x12F6618")]
		private void ScaleStats_ForExpertHardmode()
		{
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267B")]
		[Address(RVA = "0x12F6D38", Offset = "0x12F6D38", VA = "0x12F6D38")]
		private void ScaleStats_ByPlayerCount(int numPlayers)
		{
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267C")]
		[Address(RVA = "0x12F8A84", Offset = "0x12F8A84", VA = "0x12F8A84")]
		public static void GetStatScalingFactors(int numPlayers, out float balance, out float boost)
		{
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x00012738 File Offset: 0x00010938
		[Token(Token = "0x600267D")]
		[Address(RVA = "0x12F8C00", Offset = "0x12F8C00", VA = "0x12F8C00")]
		public static bool GetNPCLocation(int i, bool seekHead, bool averageDirection, out int index, out Vector2 pos)
		{
			return default(bool);
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267E")]
		[Address(RVA = "0x12F9510", Offset = "0x12F9510", VA = "0x12F9510")]
		public void PopAllAttachedProjectilesAndTakeDamageForThem()
		{
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x00012750 File Offset: 0x00010950
		[Token(Token = "0x600267F")]
		[Address(RVA = "0x12F9660", Offset = "0x12F9660", VA = "0x12F9660")]
		public bool AI_AttemptToFindTeleportSpot(ref Vector2 chosenTile, int targetTileX, int targetTileY, int rangeFromTargetTile = 20, int telefragPreventionDistanceInTiles = 5, int solidTileCheckFluff = 1, bool solidTileCheckCentered = false, bool teleportInAir = false)
		{
			return default(bool);
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x00012768 File Offset: 0x00010968
		[Token(Token = "0x6002680")]
		[Address(RVA = "0x12FA070", Offset = "0x12FA070", VA = "0x12FA070")]
		private bool AI_AttemptToFindTeleportSpotNearBooks(Point targetPosition, int maxRangeInTiles, out Vector2 destination)
		{
			return default(bool);
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x00012780 File Offset: 0x00010980
		[Token(Token = "0x6002681")]
		[Address(RVA = "0x12FAA10", Offset = "0x12FAA10", VA = "0x12FAA10")]
		private bool AI_AttemptToFindTeleportSpotNearBooks_SearchWall(int x, int y, bool downwards, out Vector2 destination, out bool outOfBounds)
		{
			return default(bool);
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002682")]
		[Address(RVA = "0x12FB134", Offset = "0x12FB134", VA = "0x12FB134")]
		public static void TransformElderSlime(int npcIndex)
		{
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002683")]
		[Address(RVA = "0x12FB948", Offset = "0x12FB948", VA = "0x12FB948")]
		public static void TransformCopperSlime(int npcIndex)
		{
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002684")]
		[Address(RVA = "0x12FBD44", Offset = "0x12FBD44", VA = "0x12FBD44")]
		public static void HaveDryadDoStardewAnimation()
		{
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002685")]
		[Address(RVA = "0x12FC45C", Offset = "0x12FC45C", VA = "0x12FC45C")]
		private void AI_047_GolemFist()
		{
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002686")]
		[Address(RVA = "0x12FE1D8", Offset = "0x12FE1D8", VA = "0x12FE1D8")]
		private void AI_045_Golem()
		{
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06002687 RID: 9863 RVA: 0x00012798 File Offset: 0x00010998
		[Token(Token = "0x17000583")]
		public static bool IsMechQueenUp
		{
			[Token(Token = "0x6002687")]
			[Address(RVA = "0x13009C8", Offset = "0x13009C8", VA = "0x13009C8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x000127B0 File Offset: 0x000109B0
		[Token(Token = "0x6002688")]
		[Address(RVA = "0x1300B94", Offset = "0x1300B94", VA = "0x1300B94")]
		public static bool SpawnMechQueen(int onWhichPlayer)
		{
			return default(bool);
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x000127C8 File Offset: 0x000109C8
		[Token(Token = "0x6002689")]
		[Address(RVA = "0x1302E9C", Offset = "0x1302E9C", VA = "0x1302E9C")]
		public bool IsCritterThatIsHostileToPlayers()
		{
			return default(bool);
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268A")]
		[Address(RVA = "0x1302F48", Offset = "0x1302F48", VA = "0x1302F48")]
		private void AI_000()
		{
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268B")]
		[Address(RVA = "0x13037D8", Offset = "0x13037D8", VA = "0x13037D8")]
		private void AI_004()
		{
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268C")]
		[Address(RVA = "0x1308790", Offset = "0x1308790", VA = "0x1308790")]
		private void AI_008()
		{
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268D")]
		[Address(RVA = "0x130DD04", Offset = "0x130DD04", VA = "0x130DD04")]
		private void AI_009()
		{
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268E")]
		[Address(RVA = "0x130F728", Offset = "0x130F728", VA = "0x130F728")]
		private void AI_010()
		{
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268F")]
		[Address(RVA = "0x13110A0", Offset = "0x13110A0", VA = "0x13110A0")]
		private void AI_011()
		{
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002690")]
		[Address(RVA = "0x13134BC", Offset = "0x13134BC", VA = "0x13134BC")]
		private void AI_012()
		{
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002691")]
		[Address(RVA = "0x13159C8", Offset = "0x13159C8", VA = "0x13159C8")]
		private void AI_013()
		{
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002692")]
		[Address(RVA = "0x1316EF0", Offset = "0x1316EF0", VA = "0x1316EF0")]
		private void AI_014()
		{
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002693")]
		[Address(RVA = "0x13195FC", Offset = "0x13195FC", VA = "0x13195FC")]
		private void AI_016()
		{
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002694")]
		[Address(RVA = "0x131B398", Offset = "0x131B398", VA = "0x131B398")]
		private void AI_017()
		{
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002695")]
		[Address(RVA = "0x131BA28", Offset = "0x131BA28", VA = "0x131BA28")]
		private void AI_018()
		{
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002696")]
		[Address(RVA = "0x131CE08", Offset = "0x131CE08", VA = "0x131CE08")]
		private void AI_019()
		{
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002697")]
		[Address(RVA = "0x131E35C", Offset = "0x131E35C", VA = "0x131E35C")]
		private void AI_020()
		{
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002698")]
		[Address(RVA = "0x131E854", Offset = "0x131E854", VA = "0x131E854")]
		public void AI_021()
		{
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002699")]
		[Address(RVA = "0x131EC4C", Offset = "0x131EC4C", VA = "0x131EC4C")]
		private void AI_022()
		{
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269A")]
		[Address(RVA = "0x13222E0", Offset = "0x13222E0", VA = "0x13222E0")]
		private void AI_023()
		{
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269B")]
		[Address(RVA = "0x1322A58", Offset = "0x1322A58", VA = "0x1322A58")]
		private void AI_024()
		{
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269C")]
		[Address(RVA = "0x1324138", Offset = "0x1324138", VA = "0x1324138")]
		private void AI_025()
		{
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269D")]
		[Address(RVA = "0x1324738", Offset = "0x1324738", VA = "0x1324738")]
		private void AI_027()
		{
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269E")]
		[Address(RVA = "0x1326F38", Offset = "0x1326F38", VA = "0x1326F38")]
		private void AI_028()
		{
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269F")]
		[Address(RVA = "0x1327ED0", Offset = "0x1327ED0", VA = "0x1327ED0")]
		private void AI_029()
		{
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A0")]
		[Address(RVA = "0x1328C60", Offset = "0x1328C60", VA = "0x1328C60")]
		private void AI_030()
		{
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A1")]
		[Address(RVA = "0x132C8A0", Offset = "0x132C8A0", VA = "0x132C8A0")]
		private void AI_031()
		{
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A2")]
		[Address(RVA = "0x1330244", Offset = "0x1330244", VA = "0x1330244")]
		private void AI_032()
		{
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A3")]
		[Address(RVA = "0x1331BCC", Offset = "0x1331BCC", VA = "0x1331BCC")]
		private void AI_033()
		{
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A4")]
		[Address(RVA = "0x1333AA4", Offset = "0x1333AA4", VA = "0x1333AA4")]
		private void AI_034()
		{
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A5")]
		[Address(RVA = "0x1335BD0", Offset = "0x1335BD0", VA = "0x1335BD0")]
		private void AI_035()
		{
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A6")]
		[Address(RVA = "0x13373BC", Offset = "0x13373BC", VA = "0x13373BC")]
		private void AI_036()
		{
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A7")]
		[Address(RVA = "0x1338AC0", Offset = "0x1338AC0", VA = "0x1338AC0")]
		private void AI_038()
		{
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A8")]
		[Address(RVA = "0x1339980", Offset = "0x1339980", VA = "0x1339980")]
		private void AI_039()
		{
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A9")]
		[Address(RVA = "0x133D8B0", Offset = "0x133D8B0", VA = "0x133D8B0")]
		private void AI_040()
		{
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AA")]
		[Address(RVA = "0x133ECA8", Offset = "0x133ECA8", VA = "0x133ECA8")]
		private void AI_041()
		{
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AB")]
		[Address(RVA = "0x1340584", Offset = "0x1340584", VA = "0x1340584")]
		private void AI_042()
		{
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AC")]
		[Address(RVA = "0x1340918", Offset = "0x1340918", VA = "0x1340918")]
		private void AI_043()
		{
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AD")]
		[Address(RVA = "0x1343C5C", Offset = "0x1343C5C", VA = "0x1343C5C")]
		private void AI_044()
		{
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AE")]
		[Address(RVA = "0x1344F08", Offset = "0x1344F08", VA = "0x1344F08")]
		private void AI_046()
		{
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AF")]
		[Address(RVA = "0x13464E0", Offset = "0x13464E0", VA = "0x13464E0")]
		private void AI_048()
		{
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B0")]
		[Address(RVA = "0x13487FC", Offset = "0x13487FC", VA = "0x13487FC")]
		private void AI_049()
		{
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B1")]
		[Address(RVA = "0x1348E70", Offset = "0x1348E70", VA = "0x1348E70")]
		private void AI_050()
		{
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B2")]
		[Address(RVA = "0x134AC88", Offset = "0x134AC88", VA = "0x134AC88")]
		private void AI_051()
		{
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B3")]
		[Address(RVA = "0x134D2B0", Offset = "0x134D2B0", VA = "0x134D2B0")]
		private void AI_052()
		{
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B4")]
		[Address(RVA = "0x134EEE0", Offset = "0x134EEE0", VA = "0x134EEE0")]
		private void AI_053()
		{
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B5")]
		[Address(RVA = "0x134F898", Offset = "0x134F898", VA = "0x134F898")]
		private void AI_054()
		{
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B6")]
		[Address(RVA = "0x1351F68", Offset = "0x1351F68", VA = "0x1351F68")]
		private void AI_055()
		{
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B7")]
		[Address(RVA = "0x13528A8", Offset = "0x13528A8", VA = "0x13528A8")]
		private void AI_056()
		{
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B8")]
		[Address(RVA = "0x1352C60", Offset = "0x1352C60", VA = "0x1352C60")]
		private void AI_057()
		{
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B9")]
		[Address(RVA = "0x1354F28", Offset = "0x1354F28", VA = "0x1354F28")]
		private void AI_058()
		{
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BA")]
		[Address(RVA = "0x135629C", Offset = "0x135629C", VA = "0x135629C")]
		private void AI_059()
		{
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BB")]
		[Address(RVA = "0x1357718", Offset = "0x1357718", VA = "0x1357718")]
		private void AI_060()
		{
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BC")]
		[Address(RVA = "0x1358CA0", Offset = "0x1358CA0", VA = "0x1358CA0")]
		private void AI_061()
		{
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BD")]
		[Address(RVA = "0x135A578", Offset = "0x135A578", VA = "0x135A578")]
		private void AI_062()
		{
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BE")]
		[Address(RVA = "0x135ADEC", Offset = "0x135ADEC", VA = "0x135ADEC")]
		private void AI_063()
		{
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BF")]
		[Address(RVA = "0x135B148", Offset = "0x135B148", VA = "0x135B148")]
		private void AI_064()
		{
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x135CA14", Offset = "0x135CA14", VA = "0x135CA14")]
		private void AI_066()
		{
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C1")]
		[Address(RVA = "0x135D060", Offset = "0x135D060", VA = "0x135D060")]
		private void AI_067()
		{
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C2")]
		[Address(RVA = "0x135E6E0", Offset = "0x135E6E0", VA = "0x135E6E0")]
		private void AI_068()
		{
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C3")]
		[Address(RVA = "0x135FED4", Offset = "0x135FED4", VA = "0x135FED4")]
		private void AI_070()
		{
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C4")]
		[Address(RVA = "0x1360860", Offset = "0x1360860", VA = "0x1360860")]
		private void AI_071()
		{
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C5")]
		[Address(RVA = "0x1361080", Offset = "0x1361080", VA = "0x1361080")]
		private void AI_072()
		{
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C6")]
		[Address(RVA = "0x13613E0", Offset = "0x13613E0", VA = "0x13613E0")]
		private void AI_073()
		{
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C7")]
		[Address(RVA = "0x136273C", Offset = "0x136273C", VA = "0x136273C")]
		private void AI_074()
		{
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C8")]
		[Address(RVA = "0x1365768", Offset = "0x1365768", VA = "0x1365768")]
		private void AI_075()
		{
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C9")]
		[Address(RVA = "0x136CC9C", Offset = "0x136CC9C", VA = "0x136CC9C")]
		private void AI_076()
		{
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CA")]
		[Address(RVA = "0x1370978", Offset = "0x1370978", VA = "0x1370978")]
		private void AI_080()
		{
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CB")]
		[Address(RVA = "0x13714DC", Offset = "0x13714DC", VA = "0x13714DC")]
		private void AI_082()
		{
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CC")]
		[Address(RVA = "0x1372E78", Offset = "0x1372E78", VA = "0x1372E78")]
		private void AI_083()
		{
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CD")]
		[Address(RVA = "0x1374AC8", Offset = "0x1374AC8", VA = "0x1374AC8")]
		private void AI_085()
		{
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CE")]
		[Address(RVA = "0x1376C74", Offset = "0x1376C74", VA = "0x1376C74")]
		private void AI_086()
		{
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CF")]
		[Address(RVA = "0x137859C", Offset = "0x137859C", VA = "0x137859C")]
		private void AI_087()
		{
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D0")]
		[Address(RVA = "0x137A6C8", Offset = "0x137A6C8", VA = "0x137A6C8")]
		private void AI_088()
		{
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D1")]
		[Address(RVA = "0x137DC40", Offset = "0x137DC40", VA = "0x137DC40")]
		private void AI_089()
		{
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D2")]
		[Address(RVA = "0x137E0E0", Offset = "0x137E0E0", VA = "0x137E0E0")]
		private void AI_090()
		{
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D3")]
		[Address(RVA = "0x137F664", Offset = "0x137F664", VA = "0x137F664")]
		private void AI_091()
		{
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D4")]
		[Address(RVA = "0x1380E94", Offset = "0x1380E94", VA = "0x1380E94")]
		private void AI_092()
		{
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D5")]
		[Address(RVA = "0x13815F4", Offset = "0x13815F4", VA = "0x13815F4")]
		private void AI_093()
		{
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D6")]
		[Address(RVA = "0x1382BC0", Offset = "0x1382BC0", VA = "0x1382BC0")]
		private void AI_094()
		{
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D7")]
		[Address(RVA = "0x1388A48", Offset = "0x1388A48", VA = "0x1388A48")]
		private void AI_095()
		{
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D8")]
		[Address(RVA = "0x138920C", Offset = "0x138920C", VA = "0x138920C")]
		private void AI_096()
		{
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D9")]
		[Address(RVA = "0x1389A14", Offset = "0x1389A14", VA = "0x1389A14")]
		private void AI_097()
		{
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DA")]
		[Address(RVA = "0x138B078", Offset = "0x138B078", VA = "0x138B078")]
		private void AI_098()
		{
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DB")]
		[Address(RVA = "0x138CA00", Offset = "0x138CA00", VA = "0x138CA00")]
		private void AI_099()
		{
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DC")]
		[Address(RVA = "0x138D2C8", Offset = "0x138D2C8", VA = "0x138D2C8")]
		private void AI_100()
		{
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DD")]
		[Address(RVA = "0x138DE68", Offset = "0x138DE68", VA = "0x138DE68")]
		private void AI_101()
		{
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DE")]
		[Address(RVA = "0x138F030", Offset = "0x138F030", VA = "0x138F030")]
		private void AI_102()
		{
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DF")]
		[Address(RVA = "0x1391AF8", Offset = "0x1391AF8", VA = "0x1391AF8")]
		private void AI_103()
		{
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E0")]
		[Address(RVA = "0x1392F74", Offset = "0x1392F74", VA = "0x1392F74")]
		private void AI_104()
		{
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E1")]
		[Address(RVA = "0x1392F80", Offset = "0x1392F80", VA = "0x1392F80")]
		private void AI_105()
		{
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E2")]
		[Address(RVA = "0x139527C", Offset = "0x139527C", VA = "0x139527C")]
		private void AI_106()
		{
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E3")]
		[Address(RVA = "0x1395B54", Offset = "0x1395B54", VA = "0x1395B54")]
		public void AI()
		{
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E4")]
		[Address(RVA = "0x140A550", Offset = "0x140A550", VA = "0x140A550")]
		private void MoonLord_SpawnTrueEyeOfCthulhu()
		{
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E5")]
		[Address(RVA = "0x13C0EB0", Offset = "0x13C0EB0", VA = "0x13C0EB0")]
		private void AI_077_MoonLordCore()
		{
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E6")]
		[Address(RVA = "0x13C4DF0", Offset = "0x13C4DF0", VA = "0x13C4DF0")]
		private void AI_078_MoonLordHands()
		{
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E7")]
		[Address(RVA = "0x13C7CB8", Offset = "0x13C7CB8", VA = "0x13C7CB8")]
		private void AI_079_MoonLordHead()
		{
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E8")]
		[Address(RVA = "0x13CA45C", Offset = "0x13CA45C", VA = "0x13CA45C")]
		private void AI_081_TrueEyeOfCthulhu()
		{
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E9")]
		[Address(RVA = "0x130873C", Offset = "0x130873C", VA = "0x130873C")]
		private void ClearTarget()
		{
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026EA")]
		[Address(RVA = "0x1409BA0", Offset = "0x1409BA0", VA = "0x1409BA0")]
		private void AI_127_Pal()
		{
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026EB")]
		[Address(RVA = "0x140A8C0", Offset = "0x140A8C0", VA = "0x140A8C0")]
		private void AI_127_Pal_GiveRewerd()
		{
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x000127E0 File Offset: 0x000109E0
		[Token(Token = "0x60026EC")]
		[Address(RVA = "0x140AA64", Offset = "0x140AA64", VA = "0x140AA64")]
		private int AI_127_Pal_SummonAttacker(int side)
		{
			return 0;
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026ED")]
		[Address(RVA = "0x140A7F0", Offset = "0x140A7F0", VA = "0x140A7F0")]
		private NPC AI_127_Pal_TryUnpackNPC(float aiValue)
		{
			return null;
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026EE")]
		[Address(RVA = "0x140AA6C", Offset = "0x140AA6C", VA = "0x140AA6C")]
		private void AddKingSlimeTeleportCacheTiles(int x0, int x1, int y0, int y1)
		{
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x000127F8 File Offset: 0x000109F8
		[Token(Token = "0x60026EF")]
		[Address(RVA = "0x140B190", Offset = "0x140B190", VA = "0x140B190")]
		private bool BuildKingSlimeTeleportCache(int tileTargetX, int tileTargetY, int outerRange, int innerRange)
		{
			return default(bool);
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x00012810 File Offset: 0x00010A10
		[Token(Token = "0x60026F0")]
		[Address(RVA = "0x140B2C0", Offset = "0x140B2C0", VA = "0x140B2C0")]
		private bool AI_015_KingSlime_FindTeleportSpot(bool antiCheese, ref float teleportSpotX, ref float teleportSpotY)
		{
			return default(bool);
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F1")]
		[Address(RVA = "0x13AF100", Offset = "0x13AF100", VA = "0x13AF100")]
		private void AI_015_KingSlime()
		{
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x00012828 File Offset: 0x00010A28
		[Token(Token = "0x60026F2")]
		[Address(RVA = "0x140B6C8", Offset = "0x140B6C8", VA = "0x140B6C8")]
		public static bool CanAnyPlayerSeeThisTile(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x00012840 File Offset: 0x00010A40
		[Token(Token = "0x60026F3")]
		[Address(RVA = "0x140B908", Offset = "0x140B908", VA = "0x140B908")]
		public static bool IsThisAGoodPlaceForAStatueMimic(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F4")]
		[Address(RVA = "0x1407E30", Offset = "0x1407E30", VA = "0x1407E30")]
		private void AI_126_StatueMimic()
		{
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F5")]
		[Address(RVA = "0x14071E8", Offset = "0x14071E8", VA = "0x14071E8")]
		private void AI_124_ElderSlimeChest()
		{
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F6")]
		[Address(RVA = "0x1407200", Offset = "0x1407200", VA = "0x1407200")]
		private void AI_125_ClumsySlimeBalloon()
		{
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F7")]
		[Address(RVA = "0x1387830", Offset = "0x1387830", VA = "0x1387830")]
		private void SpawnStardustMark_StardustTower()
		{
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F8")]
		[Address(RVA = "0x140BF74", Offset = "0x140BF74", VA = "0x140BF74")]
		private void SpawnStardustMark_StardustWorm()
		{
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x00012858 File Offset: 0x00010A58
		[Token(Token = "0x60026F9")]
		[Address(RVA = "0x140D0AC", Offset = "0x140D0AC", VA = "0x140D0AC")]
		public static bool IsDeerclopsHostile()
		{
			return default(bool);
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026FA")]
		[Address(RVA = "0x14048CC", Offset = "0x14048CC", VA = "0x14048CC")]
		private void AI_123_Deerclops()
		{
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x00012870 File Offset: 0x00010A70
		[Token(Token = "0x60026FB")]
		[Address(RVA = "0x140D6A4", Offset = "0x140D6A4", VA = "0x140D6A4")]
		private bool ShouldRunAway(ref NPCAimedTarget targetData, bool isChasing)
		{
			return default(bool);
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026FC")]
		[Address(RVA = "0x140D330", Offset = "0x140D330", VA = "0x140D330")]
		private void SpawnPassiveShadowHands(float lifePercent, int shadowHandDamage)
		{
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026FD")]
		[Address(RVA = "0x140DF0C", Offset = "0x140DF0C", VA = "0x140DF0C")]
		private void AI_123_Deerclops_ShootRubbleUp(ref NPCAimedTarget targetData, ref Point sourceTileCoords, int howMany, int distancedByThisManyTiles, float upBiasPerSpike, int whichOne)
		{
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026FE")]
		[Address(RVA = "0x140D838", Offset = "0x140D838", VA = "0x140D838")]
		private void AI_123_Deerclops_MakeSpikesForward(int AISLOT_PhaseCounter, NPCAimedTarget targetData)
		{
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026FF")]
		[Address(RVA = "0x140DB9C", Offset = "0x140DB9C", VA = "0x140DB9C")]
		private void AI_123_Deerclops_MakeSpikesBothSides(int AISLOT_PhaseCounter, NPCAimedTarget targetData)
		{
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x00012888 File Offset: 0x00010A88
		[Token(Token = "0x6002700")]
		[Address(RVA = "0x140F000", Offset = "0x140F000", VA = "0x140F000")]
		public static bool IsADeerclopsNearScreen()
		{
			return default(bool);
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002701")]
		[Address(RVA = "0x140F07C", Offset = "0x140F07C", VA = "0x140F07C")]
		private void AI_123_Deerclops_FindSpotToSpawnSpike(int howMany, int whichOne, ref int x, ref int y)
		{
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002702")]
		[Address(RVA = "0x140ECC0", Offset = "0x140ECC0", VA = "0x140ECC0")]
		private void AI_123_Deerclops_TryMakingSpike(ref Point sourceTileCoords, int dir, int howMany, int whichOne, int xOffset)
		{
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x000128A0 File Offset: 0x00010AA0
		[Token(Token = "0x6002703")]
		[Address(RVA = "0x140F540", Offset = "0x140F540", VA = "0x140F540")]
		private int AI_123_Deerclops_TryMakingSpike_FindBestY(ref Point sourceTileCoords, int x)
		{
			return 0;
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002704")]
		[Address(RVA = "0x140E440", Offset = "0x140E440", VA = "0x140E440")]
		private void AI_123_Deerclops_Movement(bool haltMovement, bool goHome)
		{
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002705")]
		[Address(RVA = "0x140F9F4", Offset = "0x140F9F4", VA = "0x140F9F4")]
		private void AI_124_DeerclopsLeg()
		{
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x000128B8 File Offset: 0x00010AB8
		[Token(Token = "0x6002706")]
		[Address(RVA = "0x14101F0", Offset = "0x14101F0", VA = "0x14101F0")]
		private static float? TryFindingFloor(Vector2 searchStartPositionInWorld, int searchRange, out int tilesTraveled)
		{
			return null;
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002707")]
		[Address(RVA = "0x137A5AC", Offset = "0x137A5AC", VA = "0x137A5AC")]
		private void AI_87_BigMimic_FireStuffCannonBurst()
		{
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002708")]
		[Address(RVA = "0x14104E0", Offset = "0x14104E0", VA = "0x14104E0")]
		private void AI_87_BigMimic_ShootItem(int itemID)
		{
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002709")]
		[Address(RVA = "0x1404284", Offset = "0x1404284", VA = "0x1404284")]
		public void AI_122_PirateGhost()
		{
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270A")]
		[Address(RVA = "0x130364C", Offset = "0x130364C", VA = "0x130364C")]
		public void AI_000_TransformBoundNPC(int playerID, int npcType)
		{
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270B")]
		[Address(RVA = "0x13B935C", Offset = "0x13B935C", VA = "0x13B935C")]
		private void AI_065_Butterflies()
		{
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x000128D0 File Offset: 0x00010AD0
		[Token(Token = "0x600270C")]
		[Address(RVA = "0x1410BE0", Offset = "0x1410BE0", VA = "0x1410BE0")]
		public static Color AI_121_QueenSlime_GetDustColor()
		{
			return default(Color);
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270D")]
		[Address(RVA = "0x1410D58", Offset = "0x1410D58", VA = "0x1410D58")]
		private void AI_121_QueenSlime_FlyMovement()
		{
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270E")]
		[Address(RVA = "0x14003B8", Offset = "0x14003B8", VA = "0x14003B8")]
		private void AI_121_QueenSlime()
		{
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x000128E8 File Offset: 0x00010AE8
		[Token(Token = "0x600270F")]
		[Address(RVA = "0x1411428", Offset = "0x1411428", VA = "0x1411428")]
		public bool AI_120_HallowBoss_IsInPhase2()
		{
			return default(bool);
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x00012900 File Offset: 0x00010B00
		[Token(Token = "0x6002710")]
		[Address(RVA = "0x1411488", Offset = "0x1411488", VA = "0x1411488")]
		public bool AI_120_HallowBoss_IsGenuinelyEnraged()
		{
			return default(bool);
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002711")]
		[Address(RVA = "0x14114E8", Offset = "0x14114E8", VA = "0x14114E8")]
		private void AI_120_HallowBoss_DoMagicEffect(Vector2 spot, int effectType, float progress)
		{
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x00012918 File Offset: 0x00010B18
		[Token(Token = "0x6002712")]
		[Address(RVA = "0x1411DE8", Offset = "0x1411DE8", VA = "0x1411DE8")]
		public static bool ShouldEmpressBeEnraged()
		{
			return default(bool);
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002713")]
		[Address(RVA = "0x13F71A8", Offset = "0x13F71A8", VA = "0x13F71A8")]
		private void AI_120_HallowBoss()
		{
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002714")]
		[Address(RVA = "0x1411FF0", Offset = "0x1411FF0", VA = "0x1411FF0")]
		private void AI_120_HallowBoss_DashTo(Vector2 targetPosition)
		{
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x00012930 File Offset: 0x00010B30
		[Token(Token = "0x6002715")]
		[Address(RVA = "0x140EB7C", Offset = "0x140EB7C", VA = "0x140EB7C")]
		public bool Boss_CanShootExtraAt(int playerIndex, int rotationIndexToAttack, int rotationSize, float attackScanDistance, bool alwaysSkipMainTarget = true)
		{
			return default(bool);
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002716")]
		[Address(RVA = "0x13F691C", Offset = "0x13F691C", VA = "0x13F691C")]
		private void AI_119_Dandelion()
		{
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002717")]
		[Address(RVA = "0x13F62E4", Offset = "0x13F62E4", VA = "0x13F62E4")]
		private void AI_118_Seahorses()
		{
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002718")]
		[Address(RVA = "0x13F2438", Offset = "0x13F2438", VA = "0x13F2438")]
		private void AI_117_BloodNautilus()
		{
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002719")]
		[Address(RVA = "0x14124AC", Offset = "0x14124AC", VA = "0x14124AC")]
		private void BloodNautilus_CallForHelp()
		{
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x0600271A RID: 10010 RVA: 0x00012948 File Offset: 0x00010B48
		[Token(Token = "0x17000584")]
		public static bool TooWindyForButterflies
		{
			[Token(Token = "0x600271A")]
			[Address(RVA = "0x1412B4C", Offset = "0x1412B4C", VA = "0x1412B4C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271B")]
		[Address(RVA = "0x13F2060", Offset = "0x13F2060", VA = "0x13F2060")]
		private void AI_116_WaterStriders()
		{
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271C")]
		[Address(RVA = "0x13F0D0C", Offset = "0x13F0D0C", VA = "0x13F0D0C")]
		private void AI_115_LadyBugs()
		{
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271D")]
		[Address(RVA = "0x13EF2B8", Offset = "0x13EF2B8", VA = "0x13EF2B8")]
		private void AI_114_Dragonflies()
		{
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271E")]
		[Address(RVA = "0x13EE0C0", Offset = "0x13EE0C0", VA = "0x13EE0C0")]
		private void AI_113_WindyBalloon()
		{
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600271F")]
		[Address(RVA = "0x141307C", Offset = "0x141307C", VA = "0x141307C")]
		public NPC AI_113_WindyBalloon_GetSlaveNPC()
		{
			return null;
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06002720 RID: 10016 RVA: 0x00012960 File Offset: 0x00010B60
		// (set) Token: 0x06002721 RID: 10017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000585")]
		public static bool foundAFairyCheck
		{
			[Token(Token = "0x6002720")]
			[Address(RVA = "0x14131AC", Offset = "0x14131AC", VA = "0x14131AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002721")]
			[Address(RVA = "0x1413224", Offset = "0x1413224", VA = "0x1413224")]
			set
			{
			}
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002722")]
		[Address(RVA = "0x13EA998", Offset = "0x13EA998", VA = "0x13EA998")]
		private void AI_112_FairyCritter()
		{
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002723")]
		[Address(RVA = "0x14137AC", Offset = "0x14137AC", VA = "0x14137AC")]
		public static void FairyEffects(Vector2 Position, int type)
		{
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002724")]
		[Address(RVA = "0x141337C", Offset = "0x141337C", VA = "0x141337C")]
		private void GetBirdFlightRecommendation(int downScanRange, int upRange, Point tCoords, out bool goDownwards, out bool goUpwards)
		{
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x00012978 File Offset: 0x00010B78
		[Token(Token = "0x6002725")]
		[Address(RVA = "0x1413608", Offset = "0x1413608", VA = "0x1413608")]
		private Vector2 GetFairyCircleOffset(float elapsedTime, float circleRotation, float circleHeight)
		{
			return default(Vector2);
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002726")]
		[Address(RVA = "0x1413C44", Offset = "0x1413C44", VA = "0x1413C44")]
		public static void ResetTreasureCache()
		{
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002727")]
		[Address(RVA = "0x1413D5C", Offset = "0x1413D5C", VA = "0x1413D5C")]
		private static NPC.PlayerTreasureCache GetTreasureCache(int player)
		{
			return null;
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x00012990 File Offset: 0x00010B90
		[Token(Token = "0x6002728")]
		[Address(RVA = "0x14132A0", Offset = "0x14132A0", VA = "0x14132A0")]
		private bool GetFairyTreasureCoords(out Point treasureCoords)
		{
			return default(bool);
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002729")]
		[Address(RVA = "0x13BB430", Offset = "0x13BB430", VA = "0x13BB430")]
		private void AI_069_DukeFishron()
		{
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272A")]
		[Address(RVA = "0x13B6528", Offset = "0x13B6528", VA = "0x13B6528")]
		private void AI_037_Destroyer()
		{
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272B")]
		[Address(RVA = "0x13A2654", Offset = "0x13A2654", VA = "0x13A2654")]
		private void AI_005_EaterOfSouls()
		{
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272C")]
		[Address(RVA = "0x1413F94", Offset = "0x1413F94", VA = "0x1413F94")]
		public void CopyInteractions(NPC npc)
		{
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x000129A8 File Offset: 0x00010BA8
		[Token(Token = "0x600272D")]
		[Address(RVA = "0x141401C", Offset = "0x141401C", VA = "0x141401C")]
		public static int GetEaterOfWorldsSegmentsCount()
		{
			return 0;
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x000129C0 File Offset: 0x00010BC0
		[Token(Token = "0x600272E")]
		[Address(RVA = "0x1351EF8", Offset = "0x1351EF8", VA = "0x1351EF8")]
		public static int GetBrainOfCthuluCreepersCount()
		{
			return 0;
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x000129D8 File Offset: 0x00010BD8
		[Token(Token = "0x600272F")]
		[Address(RVA = "0x1413F24", Offset = "0x1413F24", VA = "0x1413F24")]
		public static int GetDestroyerSegmentsCount()
		{
			return 0;
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x000129F0 File Offset: 0x00010BF0
		[Token(Token = "0x6002730")]
		[Address(RVA = "0x132C76C", Offset = "0x132C76C", VA = "0x132C76C")]
		public Vector2 GetMechQueenCenter()
		{
			return default(Vector2);
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002731")]
		[Address(RVA = "0x13A6528", Offset = "0x13A6528", VA = "0x13A6528")]
		private void AI_006_Worms()
		{
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002732")]
		[Address(RVA = "0x13A10EC", Offset = "0x13A10EC", VA = "0x13A10EC")]
		private void AI_002_FloatingEye()
		{
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002733")]
		[Address(RVA = "0x141425C", Offset = "0x141425C", VA = "0x141425C")]
		private void StingerExplosion()
		{
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x00012A08 File Offset: 0x00010C08
		[Token(Token = "0x6002734")]
		[Address(RVA = "0x141408C", Offset = "0x141408C", VA = "0x141408C")]
		public static bool DespawnEncouragement_AIStyle2_FloatingEye_IsDiscouraged(int npcID, Vector2 npcPosition, int target = 255)
		{
			return default(bool);
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x00012A20 File Offset: 0x00010C20
		[Token(Token = "0x6002735")]
		[Address(RVA = "0x14145EC", Offset = "0x14145EC", VA = "0x14145EC")]
		private bool AI_007_TownEntities_IsInAGoodRestingSpot(int tileX, int tileY, int idealRestX, int idealRestY)
		{
			return default(bool);
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x00012A38 File Offset: 0x00010C38
		[Token(Token = "0x6002736")]
		[Address(RVA = "0x141474C", Offset = "0x141474C", VA = "0x141474C")]
		private bool SolidOrSlopedTileOrPlatform(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002737")]
		[Address(RVA = "0x1414AF0", Offset = "0x1414AF0", VA = "0x1414AF0")]
		private void AI_007_FindGoodRestingSpot(int myTileX, int myTileY, out int floorX, out int floorY)
		{
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002738")]
		[Address(RVA = "0x1415DEC", Offset = "0x1415DEC", VA = "0x1415DEC")]
		private void AI_007_TryForcingSitting(int homeFloorX, int homeFloorY)
		{
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002739")]
		[Address(RVA = "0x1416938", Offset = "0x1416938", VA = "0x1416938")]
		public void UpdateHomeTileState(bool homeless, int x, int y)
		{
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x00012A50 File Offset: 0x00010C50
		[Token(Token = "0x600273A")]
		[Address(RVA = "0x1416AF4", Offset = "0x1416AF4", VA = "0x1416AF4")]
		public Color GetMagicAuraColor()
		{
			return default(Color);
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273B")]
		[Address(RVA = "0x1410994", Offset = "0x1410994", VA = "0x1410994")]
		private void AI_007_TownEntities_UpdateSavedStates()
		{
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273C")]
		[Address(RVA = "0x123D580", Offset = "0x123D580", VA = "0x123D580")]
		private void AI_007_TownEntities()
		{
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273D")]
		[Address(RVA = "0x1416CC4", Offset = "0x1416CC4", VA = "0x1416CC4")]
		private void AI_007_TownEntities_Shimmer_TeleportToLandingSpot()
		{
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x00012A68 File Offset: 0x00010C68
		[Token(Token = "0x600273E")]
		[Address(RVA = "0x1416EE4", Offset = "0x1416EE4", VA = "0x1416EE4")]
		private Vector2? AI_007_TownEntities_Shimmer_ScanForBestSpotToLandOn()
		{
			return null;
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273F")]
		[Address(RVA = "0x1417340", Offset = "0x1417340", VA = "0x1417340")]
		private void AI_007_TownEntities_TeleportToHome(int homeFloorX, int homeFloorY)
		{
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002740")]
		[Address(RVA = "0x1417548", Offset = "0x1417548", VA = "0x1417548")]
		private void AI_007_TownEntities_GetWalkPrediction(int myTileX, int homeFloorX, bool canBreathUnderWater, bool currentlyDrowning, int tileX, int tileY, out bool keepwalking, out bool avoidFalling)
		{
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x00012A80 File Offset: 0x00010C80
		[Token(Token = "0x6002741")]
		[Address(RVA = "0x1417E90", Offset = "0x1417E90", VA = "0x1417E90")]
		private bool AI_007_TownEntities_CheckIfWillDrown(bool currentlyDrowning)
		{
			return default(bool);
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002742")]
		[Address(RVA = "0x1417E98", Offset = "0x1417E98", VA = "0x1417E98")]
		private void AI_007_AttemptToPlayIdleAnimationsForPets(int petIdleChance)
		{
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x00012A98 File Offset: 0x00010C98
		[Token(Token = "0x6002743")]
		[Address(RVA = "0x133E994", Offset = "0x133E994", VA = "0x133E994")]
		public bool NPCCanStickToWalls(int transformID)
		{
			return default(bool);
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x00012AB0 File Offset: 0x00010CB0
		[Token(Token = "0x6002744")]
		[Address(RVA = "0x1418538", Offset = "0x1418538", VA = "0x1418538")]
		public bool NPCCanStickToWalls(Vector2 centerPos)
		{
			return default(bool);
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x00012AC8 File Offset: 0x00010CC8
		[Token(Token = "0x6002745")]
		[Address(RVA = "0x130D384", Offset = "0x130D384", VA = "0x130D384")]
		public static bool AI_GlobalFiringDistanceCheck(Vector2 shootPos, Vector2 targetPos)
		{
			return default(bool);
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x00012AE0 File Offset: 0x00010CE0
		[Token(Token = "0x6002746")]
		[Address(RVA = "0x141892C", Offset = "0x141892C", VA = "0x141892C")]
		private bool AI_003_Gnomes_ShouldTurnToStone()
		{
			return default(bool);
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002747")]
		[Address(RVA = "0x1250228", Offset = "0x1250228", VA = "0x1250228")]
		private void AI_003_Fighters()
		{
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x00012AF8 File Offset: 0x00010CF8
		[Token(Token = "0x6002748")]
		[Address(RVA = "0x1418A84", Offset = "0x1418A84", VA = "0x1418A84")]
		public static bool DespawnEncouragement_AIStyle3_Fighters_NotDiscouraged(int npcID, Vector2 position, NPC npcInstance)
		{
			return default(bool);
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x00012B10 File Offset: 0x00010D10
		[Token(Token = "0x6002749")]
		[Address(RVA = "0x1419DFC", Offset = "0x1419DFC", VA = "0x1419DFC")]
		public static bool DespawnEncouragement_AIStyle3_Fighters_CanBeBusyWithAction(int npcID)
		{
			return default(bool);
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274A")]
		[Address(RVA = "0x1395F90", Offset = "0x1395F90", VA = "0x1395F90")]
		private void AI_001_Slimes()
		{
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274B")]
		[Address(RVA = "0x141AD80", Offset = "0x141AD80", VA = "0x141AD80")]
		public void AI_001_SetRainbowSlimeColor()
		{
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x00012B28 File Offset: 0x00010D28
		[Token(Token = "0x600274C")]
		[Address(RVA = "0x141A154", Offset = "0x141A154", VA = "0x141A154")]
		private int AI_001_Slimes_GenerateItemInsideBody(bool isBallooned)
		{
			return 0;
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274D")]
		[Address(RVA = "0x13E5D8C", Offset = "0x13E5D8C", VA = "0x13E5D8C")]
		private void AI_110_Betsy()
		{
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x00012B40 File Offset: 0x00010D40
		[Token(Token = "0x600274E")]
		[Address(RVA = "0x130D5D8", Offset = "0x130D5D8", VA = "0x130D5D8")]
		private static bool AI_FindNearbyBook(Point searchPosition, int searchWidth, int searchHeight, out Point bookPosition, bool closestBook = false, bool checkPlayerScreenRanges = false)
		{
			return default(bool);
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274F")]
		[Address(RVA = "0x13B13E8", Offset = "0x13B13E8", VA = "0x13B13E8")]
		private void AI_026_Unicorns()
		{
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002750")]
		[Address(RVA = "0x13D63B0", Offset = "0x13D63B0", VA = "0x13D63B0")]
		private void AI_107_ImprovedWalkers()
		{
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002751")]
		[Address(RVA = "0x13CDE24", Offset = "0x13CDE24", VA = "0x13CDE24")]
		private void AI_084_LunaticCultist()
		{
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002752")]
		[Address(RVA = "0x13DFF48", Offset = "0x13DFF48", VA = "0x13DFF48")]
		private void AI_108_DivingFlyer()
		{
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002753")]
		[Address(RVA = "0x13E34F0", Offset = "0x13E34F0", VA = "0x13E34F0")]
		private void AI_109_DarkMage()
		{
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002754")]
		[Address(RVA = "0x13E9294", Offset = "0x13E9294", VA = "0x13E9294")]
		private void AI_111_DD2LightningBug()
		{
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002755")]
		[Address(RVA = "0x137A440", Offset = "0x137A440", VA = "0x137A440")]
		public void ReflectProjectiles(Rectangle myRect)
		{
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x00012B58 File Offset: 0x00010D58
		[Token(Token = "0x6002756")]
		[Address(RVA = "0x141B3D8", Offset = "0x141B3D8", VA = "0x141B3D8")]
		public bool CanReflectProjectile(Projectile proj)
		{
			return default(bool);
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002757")]
		[Address(RVA = "0x1412358", Offset = "0x1412358", VA = "0x1412358")]
		public void BloodNautilus_GetMouthPositionAndRotation(out Vector2 mouthPosition, out Vector2 mouthDirection)
		{
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002758")]
		[Address(RVA = "0x141B4E8", Offset = "0x141B4E8", VA = "0x141B4E8")]
		public void ReflectProjectile(Projectile proj)
		{
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x00012B70 File Offset: 0x00010D70
		[Token(Token = "0x6002759")]
		[Address(RVA = "0x141B980", Offset = "0x141B980", VA = "0x141B980")]
		public int GetShootingFrame(float circleY)
		{
			return 0;
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600275A")]
		[Address(RVA = "0x141BA28", Offset = "0x141BA28", VA = "0x141BA28")]
		public Tuple<Vector2, float> GetSwingStats(int swingMax, int swingCurrent, int aimDir, int itemWidth, int itemHeight)
		{
			return null;
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275B")]
		[Address(RVA = "0x141BD28", Offset = "0x141BD28", VA = "0x141BD28")]
		public void TweakSwingStats(int swingMax, int swingCurrent, int aimDir, ref Rectangle itemRectangle)
		{
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x00012B88 File Offset: 0x00010D88
		[Token(Token = "0x600275C")]
		[Address(RVA = "0x141BEF0", Offset = "0x141BEF0", VA = "0x141BEF0")]
		public bool UsesPartyHat()
		{
			return default(bool);
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x00012BA0 File Offset: 0x00010DA0
		[Token(Token = "0x600275D")]
		[Address(RVA = "0x141BFE8", Offset = "0x141BFE8", VA = "0x141BFE8")]
		public PartyHatColor GetPartyHatColor()
		{
			return PartyHatColor.None;
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275E")]
		[Address(RVA = "0x141C2B4", Offset = "0x141C2B4", VA = "0x141C2B4")]
		public void SetFrameSize()
		{
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x00012BB8 File Offset: 0x00010DB8
		[Token(Token = "0x600275F")]
		[Address(RVA = "0x130D2A8", Offset = "0x130D2A8", VA = "0x130D2A8")]
		public bool RedHatSkeletronAdjustmentsEnabled()
		{
			return default(bool);
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002760")]
		[Address(RVA = "0x126C100", Offset = "0x126C100", VA = "0x126C100")]
		public void FindFrame()
		{
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x00012BD0 File Offset: 0x00010DD0
		[Token(Token = "0x6002761")]
		[Address(RVA = "0x141C48C", Offset = "0x141C48C", VA = "0x141C48C")]
		private static int FindFrame_FromSequence(int sequenceFrame, int[] frames)
		{
			return 0;
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x00012BE8 File Offset: 0x00010DE8
		[Token(Token = "0x6002762")]
		[Address(RVA = "0x141C4BC", Offset = "0x141C4BC", VA = "0x141C4BC")]
		private static int FindFrame_Deerclops_GetAttack1Frame(int sequenceFrame)
		{
			return 0;
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x00012C00 File Offset: 0x00010E00
		[Token(Token = "0x6002763")]
		[Address(RVA = "0x141C544", Offset = "0x141C544", VA = "0x141C544")]
		private static int FindFrame_Deerclops_GetAttack2Frame(int sequenceFrame)
		{
			return 0;
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x00012C18 File Offset: 0x00010E18
		[Token(Token = "0x6002764")]
		[Address(RVA = "0x141C5CC", Offset = "0x141C5CC", VA = "0x141C5CC")]
		private static int FindFrame_Deerclops_GetAttack3Frame(int sequenceFrame)
		{
			return 0;
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002765")]
		[Address(RVA = "0x138992C", Offset = "0x138992C", VA = "0x138992C")]
		public void SimpleFlyMovement(Vector2 desiredVelocity, float moveSpeed)
		{
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002766")]
		[Address(RVA = "0x141AE0C", Offset = "0x141AE0C", VA = "0x141AE0C")]
		public void HealEffect(int healAmount, bool broadcast = true)
		{
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002767")]
		[Address(RVA = "0x1372C14", Offset = "0x1372C14", VA = "0x1372C14")]
		public static void HealEffect(Rectangle r, int healAmount, bool broadcast = true)
		{
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x00012C30 File Offset: 0x00010E30
		[Token(Token = "0x6002768")]
		[Address(RVA = "0x13714BC", Offset = "0x13714BC", VA = "0x13714BC")]
		public int FindClosestPlayer()
		{
			return 0;
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x00012C48 File Offset: 0x00010E48
		[Token(Token = "0x6002769")]
		[Address(RVA = "0x1371200", Offset = "0x1371200", VA = "0x1371200")]
		public int FindClosestPlayer(out float distanceToPlayer)
		{
			return 0;
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276A")]
		[Address(RVA = "0x141C654", Offset = "0x141C654", VA = "0x141C654")]
		public void BigMimicSpawnSmoke()
		{
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00012C60 File Offset: 0x00010E60
		[Token(Token = "0x600276B")]
		[Address(RVA = "0x141CA64", Offset = "0x141CA64", VA = "0x141CA64")]
		public static bool BigMimicSummonCheck(int x, int y, Player user)
		{
			return default(bool);
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x00012C78 File Offset: 0x00010E78
		[Token(Token = "0x600276C")]
		[Address(RVA = "0x141D8B4", Offset = "0x141D8B4", VA = "0x141D8B4")]
		public bool ShouldFaceTarget(ref NPCUtils.TargetSearchResults searchResults, [Optional] NPCUtils.TargetType? overrideTargetType)
		{
			return default(bool);
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276D")]
		[Address(RVA = "0x141DA3C", Offset = "0x141DA3C", VA = "0x141DA3C")]
		public void FaceTarget()
		{
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276E")]
		[Address(RVA = "0x12FDFF4", Offset = "0x12FDFF4", VA = "0x12FDFF4")]
		public void TargetClosest(bool faceTarget = true)
		{
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276F")]
		[Address(RVA = "0x1326D54", Offset = "0x1326D54", VA = "0x1326D54")]
		public void TargetClosest_WOF(bool faceTarget = true)
		{
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002770")]
		[Address(RVA = "0x141DB4C", Offset = "0x141DB4C", VA = "0x141DB4C")]
		private void TryTrackingTarget(ref float distance, ref float realDist, ref bool t, ref int tankTarget, int j)
		{
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002771")]
		[Address(RVA = "0x141DFFC", Offset = "0x141DFFC", VA = "0x141DFFC")]
		private void SetTargetTrackingValues(bool faceTarget, float realDist, int tankTarget)
		{
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00012C90 File Offset: 0x00010E90
		[Token(Token = "0x6002772")]
		[Address(RVA = "0x141E598", Offset = "0x141E598", VA = "0x141E598")]
		public bool DoesntDespawnToInactivityAndCountsNPCSlots()
		{
			return default(bool);
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x00012CA8 File Offset: 0x00010EA8
		[Token(Token = "0x6002773")]
		[Address(RVA = "0x141E5AC", Offset = "0x141E5AC", VA = "0x141E5AC")]
		public bool DoesntDespawnToInactivity()
		{
			return default(bool);
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002774")]
		[Address(RVA = "0x141E940", Offset = "0x141E940", VA = "0x141E940")]
		public void CheckActive()
		{
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002775")]
		[Address(RVA = "0x141F6BC", Offset = "0x141F6BC", VA = "0x141F6BC")]
		private void CheckActive_WormSegments()
		{
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002776")]
		[Address(RVA = "0x141F890", Offset = "0x141F890", VA = "0x141F890")]
		public static void BeginDelaySendNPCSync()
		{
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002777")]
		[Address(RVA = "0x141F92C", Offset = "0x141F92C", VA = "0x141F92C")]
		public static void EndDelaySendNPCSync()
		{
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002778")]
		[Address(RVA = "0x141FAC8", Offset = "0x141FAC8", VA = "0x141FAC8")]
		private static void DelaySendNPCSync(int whoIAm)
		{
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002779")]
		[Address(RVA = "0x141FBB8", Offset = "0x141FBB8", VA = "0x141FBB8")]
		public void PrepareForDeathAnimation()
		{
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277A")]
		[Address(RVA = "0x13491A8", Offset = "0x13491A8", VA = "0x13491A8")]
		public void checkDead()
		{
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277B")]
		[Address(RVA = "0x1420540", Offset = "0x1420540", VA = "0x1420540")]
		public void DropTombstoneTownNPC(NetworkText deathText)
		{
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x00012CC0 File Offset: 0x00010EC0
		[Token(Token = "0x600277C")]
		[Address(RVA = "0x12F8744", Offset = "0x12F8744", VA = "0x12F8744")]
		public static int GetNPCInvasionGroup(int npcID)
		{
			return 0;
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277D")]
		[Address(RVA = "0x1421158", Offset = "0x1421158", VA = "0x1421158")]
		private void DropEoWLoot(bool fromCheckDead = true)
		{
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x00012CD8 File Offset: 0x00010ED8
		[Token(Token = "0x600277E")]
		[Address(RVA = "0x1423980", Offset = "0x1423980", VA = "0x1423980")]
		private float GetMoonEventPointScalar()
		{
			return 0f;
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277F")]
		[Address(RVA = "0x1421D9C", Offset = "0x1421D9C", VA = "0x1421D9C")]
		private void CheckProgressFrostMoon()
		{
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002780")]
		[Address(RVA = "0x1422B90", Offset = "0x1422B90", VA = "0x1422B90")]
		private void CheckProgressPumpkinMoon()
		{
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x00012CF0 File Offset: 0x00010EF0
		[Token(Token = "0x6002781")]
		[Address(RVA = "0x1423A24", Offset = "0x1423A24", VA = "0x1423A24")]
		public bool AnyInteractions()
		{
			return default(bool);
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x00012D08 File Offset: 0x00010F08
		[Token(Token = "0x6002782")]
		[Address(RVA = "0x1423B38", Offset = "0x1423B38", VA = "0x1423B38")]
		public bool IsDamageDodgeable()
		{
			return default(bool);
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002783")]
		[Address(RVA = "0x1423C00", Offset = "0x1423C00", VA = "0x1423C00")]
		public static void SetEventFlagCleared(ref bool eventFlag, int gameEventId)
		{
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002784")]
		[Address(RVA = "0x1423C7C", Offset = "0x1423C7C", VA = "0x1423C7C")]
		public static void OnGameEventClearedForTheFirstTime(int gameEventId)
		{
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002785")]
		[Address(RVA = "0x1421304", Offset = "0x1421304", VA = "0x1421304")]
		public void NPCLoot()
		{
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x00012D20 File Offset: 0x00010F20
		[Token(Token = "0x6002786")]
		[Address(RVA = "0x14242CC", Offset = "0x14242CC", VA = "0x14242CC")]
		public bool IsNPCValidForBestiaryKillCredit()
		{
			return default(bool);
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002787")]
		[Address(RVA = "0x142445C", Offset = "0x142445C", VA = "0x142445C")]
		private void DoDeathEvents_BeforeLoot(Player closestPlayer)
		{
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002788")]
		[Address(RVA = "0x14244EC", Offset = "0x14244EC", VA = "0x14244EC")]
		private void NPCLoot_DropItems(Player closestPlayer)
		{
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002789")]
		[Address(RVA = "0x1429C50", Offset = "0x1429C50", VA = "0x1429C50")]
		public static void ResetBadgerHatTime()
		{
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278A")]
		[Address(RVA = "0x1429CB8", Offset = "0x1429CB8", VA = "0x1429CB8")]
		private void DoDeathEvents_DropBossPotionsAndHearts()
		{
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278B")]
		[Address(RVA = "0x142A2E0", Offset = "0x142A2E0", VA = "0x142A2E0")]
		private void DoDeathEvents_CelebrateBossDeath()
		{
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278C")]
		[Address(RVA = "0x142A6D8", Offset = "0x142A6D8", VA = "0x142A6D8")]
		private void CreateBrickBoxForWallOfFlesh()
		{
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278D")]
		[Address(RVA = "0x142ACC4", Offset = "0x142ACC4", VA = "0x142ACC4")]
		private void DoDeathEvents_SummonDungeonSpirit(Player closestPlayer)
		{
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278E")]
		[Address(RVA = "0x142B0FC", Offset = "0x142B0FC", VA = "0x142B0FC")]
		private void DoDeathEvents_AdvanceSlimeRain(Player closestPlayer)
		{
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278F")]
		[Address(RVA = "0x142924C", Offset = "0x142924C", VA = "0x142924C")]
		private void NPCLoot_DropHeals(Player closestPlayer)
		{
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002790")]
		[Address(RVA = "0x14245B4", Offset = "0x14245B4", VA = "0x14245B4")]
		private void DoDeathEvents(Player closestPlayer)
		{
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002791")]
		[Address(RVA = "0x142C928", Offset = "0x142C928", VA = "0x142C928")]
		private void ViolentlySpawnNerdySlime()
		{
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002792")]
		[Address(RVA = "0x142B2B8", Offset = "0x142B2B8", VA = "0x142B2B8")]
		private void NPCLoot_DropCommonLifeAndMana(Player closestPlayer)
		{
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002793")]
		[Address(RVA = "0x1426C90", Offset = "0x1426C90", VA = "0x1426C90")]
		private void NPCLoot_DropDungeonStuff()
		{
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002794")]
		[Address(RVA = "0x1427F54", Offset = "0x1427F54", VA = "0x1427F54")]
		private void NPCLoot_DropTempleTraps()
		{
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002795")]
		[Address(RVA = "0x1427AF0", Offset = "0x1427AF0", VA = "0x1427AF0")]
		private void NPCLoot_DropLihzahrdStuff()
		{
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002796")]
		[Address(RVA = "0x1426AB8", Offset = "0x1426AB8", VA = "0x1426AB8")]
		private void NPCLoot_DropAltar()
		{
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002797")]
		[Address(RVA = "0x142795C", Offset = "0x142795C", VA = "0x142795C")]
		private void NPCLoot_DropHellforge()
		{
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002798")]
		[Address(RVA = "0x1428148", Offset = "0x1428148", VA = "0x1428148")]
		private void NPCLoot_DropMoney(Player closestPlayer)
		{
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x00012D38 File Offset: 0x00010F38
		[Token(Token = "0x6002799")]
		[Address(RVA = "0x142CC60", Offset = "0x142CC60", VA = "0x142CC60")]
		public static int GetStackForSlimeItemDrop(int item)
		{
			return 0;
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x00012D50 File Offset: 0x00010F50
		[Token(Token = "0x600279A")]
		[Address(RVA = "0x142D028", Offset = "0x142D028", VA = "0x142D028")]
		public bool ExcludedFromDeathTally()
		{
			return default(bool);
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279B")]
		[Address(RVA = "0x14242EC", Offset = "0x14242EC", VA = "0x14242EC")]
		private void CountKillForBannersAndDropThem()
		{
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x00012D68 File Offset: 0x00010F68
		[Token(Token = "0x600279C")]
		[Address(RVA = "0x142422C", Offset = "0x142422C", VA = "0x142422C")]
		public bool GetWereThereAnyInteractions()
		{
			return default(bool);
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279D")]
		[Address(RVA = "0x1424078", Offset = "0x1424078", VA = "0x1424078")]
		private void CountKillForAchievements()
		{
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x00012D80 File Offset: 0x00010F80
		[Token(Token = "0x600279E")]
		[Address(RVA = "0x142D118", Offset = "0x142D118", VA = "0x142D118")]
		private bool TryTeleportingCaughtMysticFrog()
		{
			return default(bool);
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279F")]
		[Address(RVA = "0x142D804", Offset = "0x142D804", VA = "0x142D804")]
		public static void CatchNPC(int i, int who = -1)
		{
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A0")]
		[Address(RVA = "0x142E0B8", Offset = "0x142E0B8", VA = "0x142E0B8")]
		public void LocalPlayerInteraction()
		{
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A1")]
		[Address(RVA = "0x142F0E4", Offset = "0x142F0E4", VA = "0x142F0E4")]
		public void PlayerInteraction(int player)
		{
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A2")]
		[Address(RVA = "0x142E12C", Offset = "0x142E12C", VA = "0x142E12C")]
		private void ApplyInteraction(int player, bool localOnly)
		{
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A3")]
		[Address(RVA = "0x142F1A4", Offset = "0x142F1A4", VA = "0x142F1A4")]
		public void ApplyInteraction_Inner(int player, bool localOnly)
		{
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00012D98 File Offset: 0x00010F98
		[Token(Token = "0x60027A4")]
		[Address(RVA = "0x142F350", Offset = "0x142F350", VA = "0x142F350")]
		public static bool CanReleaseNPCs(int who)
		{
			return default(bool);
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x00012DB0 File Offset: 0x00010FB0
		[Token(Token = "0x60027A5")]
		[Address(RVA = "0x142F58C", Offset = "0x142F58C", VA = "0x142F58C")]
		public static int ReleaseNPC(int x, int y, int Type, int Style, int who)
		{
			return 0;
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A6")]
		[Address(RVA = "0x142FE14", Offset = "0x142FE14", VA = "0x142FE14")]
		public static void SpawnNPC()
		{
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x00012DC8 File Offset: 0x00010FC8
		[Token(Token = "0x60027A7")]
		[Address(RVA = "0x1412C10", Offset = "0x1412C10", VA = "0x1412C10")]
		public static bool FindCattailTop(int landX, int landY, out int cattailX, out int cattailY)
		{
			return default(bool);
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x00012DE0 File Offset: 0x00010FE0
		[Token(Token = "0x60027A8")]
		[Address(RVA = "0x142FF00", Offset = "0x142FF00", VA = "0x142FF00")]
		public static bool FindTreeBranch(int landX, int landY, out int treeBranchX, out int treeBranchY)
		{
			return default(bool);
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x00012DF8 File Offset: 0x00010FF8
		[Token(Token = "0x60027A9")]
		[Address(RVA = "0x14304AC", Offset = "0x14304AC", VA = "0x14304AC")]
		public static bool AnyDanger(bool quickBossNPCCheck = false, bool ignorePillarsAndMoonlordCountdown = false, bool ignoreInvasions = false)
		{
			return default(bool);
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x00012E10 File Offset: 0x00011010
		[Token(Token = "0x60027AA")]
		[Address(RVA = "0x1430834", Offset = "0x1430834", VA = "0x1430834")]
		public static bool AnyoneNearCultists()
		{
			return default(bool);
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AB")]
		[Address(RVA = "0x142BE2C", Offset = "0x142BE2C", VA = "0x142BE2C")]
		public static void SpawnWOF(Vector2 pos)
		{
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AC")]
		[Address(RVA = "0x1430CA0", Offset = "0x1430CA0", VA = "0x1430CA0")]
		public static void RedHatSkeletron(int onWho)
		{
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AD")]
		[Address(RVA = "0x14209B4", Offset = "0x14209B4", VA = "0x14209B4")]
		public static void SpawnSkeletron(int onWho, bool redHatMode = false)
		{
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AE")]
		[Address(RVA = "0x1301290", Offset = "0x1301290", VA = "0x1301290")]
		public static void SpawnOnPlayer(int plr, int npcType, float ai0 = 0f, float ai1 = 0f, float ai2 = 0f, float ai3 = 0f)
		{
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x00012E28 File Offset: 0x00011028
		[Token(Token = "0x60027AF")]
		[Address(RVA = "0x1430F3C", Offset = "0x1430F3C", VA = "0x1430F3C")]
		public static int GetAvailableAmountOfNPCsToSpawnUpToSlot(int amountWeWant, int highestNPCSlotIndexWeWillPick = 100)
		{
			return 0;
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B0")]
		[Address(RVA = "0x1302DD8", Offset = "0x1302DD8", VA = "0x1302DD8")]
		public static IEntitySource GetBossSpawnSource(int targetPlayerIndex)
		{
			return null;
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B1")]
		[Address(RVA = "0x142B778", Offset = "0x142B778", VA = "0x142B778")]
		public static void SpawnBoss(int spawnPositionX, int spawnPositionY, int Type, int targetPlayerIndex, float ai0 = 0f, float ai1 = 0f, float ai2 = 0f, float ai3 = 0f)
		{
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B2")]
		[Address(RVA = "0x1431014", Offset = "0x1431014", VA = "0x1431014")]
		public static void UpdateProtectedSpawnSlots()
		{
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B3")]
		[Address(RVA = "0x1431184", Offset = "0x1431184", VA = "0x1431184")]
		internal static NPC NewNPCInstanceInSlot(int slot, byte generation = 0)
		{
			return null;
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x00012E40 File Offset: 0x00011040
		[Token(Token = "0x60027B4")]
		[Address(RVA = "0x1300460", Offset = "0x1300460", VA = "0x1300460")]
		public static int NewNPC(IEntitySource source, int X, int Y, int Type, int Start = 0, float ai0 = 0f, float ai1 = 0f, float ai2 = 0f, float ai3 = 0f, int Target = 255)
		{
			return 0;
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x00012E58 File Offset: 0x00011058
		[Token(Token = "0x60027B5")]
		[Address(RVA = "0x1431414", Offset = "0x1431414", VA = "0x1431414")]
		private static int GetAvailableNPCSlot(int Type, int startIndex)
		{
			return 0;
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x00012E70 File Offset: 0x00011070
		[Token(Token = "0x60027B6")]
		[Address(RVA = "0x1431A34", Offset = "0x1431A34", VA = "0x1431A34")]
		private static bool IsSpawnSlotInUse(int slot)
		{
			return default(bool);
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B7")]
		[Address(RVA = "0x14316AC", Offset = "0x14316AC", VA = "0x14316AC")]
		private static void GiveTownUniqueDataToNPCsThatNeedIt(int Type, int nextNPC)
		{
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x00012E88 File Offset: 0x00011088
		[Token(Token = "0x60027B8")]
		[Address(RVA = "0x1431B28", Offset = "0x1431B28", VA = "0x1431B28")]
		public PlayerPettingInfo GetPettingInfo(Player player)
		{
			return default(PlayerPettingInfo);
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B9")]
		[Address(RVA = "0x1431CF0", Offset = "0x1431CF0", VA = "0x1431CF0")]
		public static void UnlockOrExchangePet(ref bool petBoughtFlag, int npcType, string textKeyForLicense, int netMessageData)
		{
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x00012EA0 File Offset: 0x000110A0
		[Token(Token = "0x60027BA")]
		[Address(RVA = "0x1432138", Offset = "0x1432138", VA = "0x1432138")]
		public static bool RerollVariationForNPCType(int npcType)
		{
			return default(bool);
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x00012EB8 File Offset: 0x000110B8
		[Token(Token = "0x60027BB")]
		[Address(RVA = "0x14321F8", Offset = "0x14321F8", VA = "0x14321F8")]
		public bool RerollVariation()
		{
			return default(bool);
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BC")]
		[Address(RVA = "0x1432570", Offset = "0x1432570", VA = "0x1432570")]
		public void TransformVisuals(int oldType, int newType)
		{
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BD")]
		[Address(RVA = "0x142D510", Offset = "0x142D510", VA = "0x142D510")]
		public void Teleport(Vector2 newPos, int Style = 0, int extraInfo = 0)
		{
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x00012ED0 File Offset: 0x000110D0
		[Token(Token = "0x60027BE")]
		[Address(RVA = "0x1418350", Offset = "0x1418350", VA = "0x1418350")]
		public Rectangle? TryGetAdjustedHitboxFromTransformation(int targetType)
		{
			return null;
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00012EE8 File Offset: 0x000110E8
		[Token(Token = "0x60027BF")]
		[Address(RVA = "0x133EB70", Offset = "0x133EB70", VA = "0x133EB70")]
		public bool TryMoveToTransformableSpaceInto(int targetType)
		{
			return default(bool);
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C0")]
		[Address(RVA = "0x12FB4D8", Offset = "0x12FB4D8", VA = "0x12FB4D8")]
		public void Transform(int newType, float ai0 = 0f, float ai1 = 0f, float ai2 = 0f, float ai3 = 0f, bool withReposition = true)
		{
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x00012F00 File Offset: 0x00011100
		[Token(Token = "0x60027C1")]
		[Address(RVA = "0x1433590", Offset = "0x1433590", VA = "0x1433590")]
		public int checkArmorPenetration(int armorPenetration, float armorPenetrationPercent)
		{
			return 0;
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x00012F18 File Offset: 0x00011118
		[Token(Token = "0x60027C2")]
		[Address(RVA = "0x1433610", Offset = "0x1433610", VA = "0x1433610")]
		public int KeyBrandStrike(int plr, int dmg, Vector2 bestSwordSpot)
		{
			return 0;
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x00012F30 File Offset: 0x00011130
		[Token(Token = "0x60027C3")]
		[Address(RVA = "0x12FDFCC", Offset = "0x12FDFCC", VA = "0x12FDFCC")]
		public int StrikeNPCNoInteraction(int Damage, float knockBack, int hitDirection)
		{
			return 0;
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x00012F48 File Offset: 0x00011148
		[Token(Token = "0x60027C4")]
		[Address(RVA = "0x14337C8", Offset = "0x14337C8", VA = "0x14337C8")]
		public int StrikeNPC(int Damage, float knockBack, int hitDirection, bool crit = false, bool fromNet = false, int owner = -1)
		{
			return 0;
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x00012F60 File Offset: 0x00011160
		[Token(Token = "0x60027C5")]
		[Address(RVA = "0x1433DD0", Offset = "0x1433DD0", VA = "0x1433DD0")]
		private int StrikeNPC_Inner(int Damage, float knockBack, int hitDirection, bool crit = false, bool fromNet = false, int owner = -1)
		{
			return 0;
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C6")]
		[Address(RVA = "0x141FD60", Offset = "0x141FD60", VA = "0x141FD60")]
		public static void LadyBugKilled(Vector2 Position, bool GoldLadyBug = false)
		{
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C7")]
		[Address(RVA = "0x141F300", Offset = "0x141F300", VA = "0x141F300")]
		private void LadyBugLuck(int plr, bool GoldLadyBug = false)
		{
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C8")]
		[Address(RVA = "0x14201AC", Offset = "0x14201AC", VA = "0x14201AC")]
		private void NPCLuck()
		{
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C9")]
		[Address(RVA = "0x129BCD0", Offset = "0x129BCD0", VA = "0x129BCD0")]
		public void HitEffect(int hitDirection = 0, double dmg = 10.0)
		{
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x00012F78 File Offset: 0x00011178
		[Token(Token = "0x60027CA")]
		[Address(RVA = "0x13133C4", Offset = "0x13133C4", VA = "0x13133C4")]
		public static int CountNPCS(int Type)
		{
			return 0;
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x00012F90 File Offset: 0x00011190
		[Token(Token = "0x60027CB")]
		[Address(RVA = "0x1435688", Offset = "0x1435688", VA = "0x1435688")]
		public static bool AnyHelpfulFairies()
		{
			return default(bool);
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x00012FA8 File Offset: 0x000111A8
		[Token(Token = "0x60027CC")]
		[Address(RVA = "0x141A874", Offset = "0x141A874", VA = "0x141A874")]
		private static bool AnyLifeCrystalSlimes()
		{
			return default(bool);
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x00012FC0 File Offset: 0x000111C0
		[Token(Token = "0x60027CD")]
		[Address(RVA = "0x12F8648", Offset = "0x12F8648", VA = "0x12F8648")]
		public static bool AnyNPCs(int Type)
		{
			return default(bool);
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x00012FD8 File Offset: 0x000111D8
		[Token(Token = "0x60027CE")]
		[Address(RVA = "0x1302CDC", Offset = "0x1302CDC", VA = "0x1302CDC")]
		public static int FindFirstNPC(int Type)
		{
			return 0;
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x00012FF0 File Offset: 0x000111F0
		[Token(Token = "0x60027CF")]
		[Address(RVA = "0x1435884", Offset = "0x1435884", VA = "0x1435884")]
		public static bool NearSpikeBall(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x00013008 File Offset: 0x00011208
		[Token(Token = "0x60027D0")]
		[Address(RVA = "0x1435B18", Offset = "0x1435B18", VA = "0x1435B18")]
		public int FindBuffIndex(int type)
		{
			return 0;
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D1")]
		[Address(RVA = "0x141A9D8", Offset = "0x141A9D8", VA = "0x141A9D8")]
		public void AddBuff(int type, int time, bool quiet = false)
		{
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D2")]
		[Address(RVA = "0x1435E58", Offset = "0x1435E58", VA = "0x1435E58")]
		public void RequestBuffRemoval(int buffTypeToRemove)
		{
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D3")]
		[Address(RVA = "0x1435C00", Offset = "0x1435C00", VA = "0x1435C00")]
		public void DelBuff(int buffIndex, bool quiet = false)
		{
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x00013020 File Offset: 0x00011220
		[Token(Token = "0x60027D4")]
		[Address(RVA = "0x13607FC", Offset = "0x13607FC", VA = "0x13607FC")]
		public Rectangle getRect()
		{
			return default(Rectangle);
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x00013038 File Offset: 0x00011238
		[Token(Token = "0x60027D5")]
		[Address(RVA = "0x1435FC8", Offset = "0x1435FC8", VA = "0x1435FC8")]
		public bool CanBeChasedBy([Optional] object attacker, bool ignoreDontTakeDamage = false)
		{
			return default(bool);
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x00013050 File Offset: 0x00011250
		[Token(Token = "0x60027D6")]
		[Address(RVA = "0x143601C", Offset = "0x143601C", VA = "0x143601C")]
		public bool HittableForOnHitRewards()
		{
			return default(bool);
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060027D7 RID: 10199 RVA: 0x00013068 File Offset: 0x00011268
		[Token(Token = "0x17000586")]
		public bool CountsAsACritter
		{
			[Token(Token = "0x60027D7")]
			[Address(RVA = "0x1436060", Offset = "0x1436060", VA = "0x1436060")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D8")]
		[Address(RVA = "0x14360A4", Offset = "0x14360A4", VA = "0x14360A4")]
		public void moneyPing(Vector2 pos)
		{
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D9")]
		[Address(RVA = "0x14362C8", Offset = "0x14362C8", VA = "0x14362C8")]
		public void IdleSounds()
		{
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DA")]
		[Address(RVA = "0x14376D4", Offset = "0x14376D4", VA = "0x14376D4")]
		public void UpdateAltTexture()
		{
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DB")]
		[Address(RVA = "0x14378E0", Offset = "0x14378E0", VA = "0x14378E0")]
		private void MakeTransitionEffectsForTextureChanges(int oldAltTexture, int currentAltTexture)
		{
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DC")]
		[Address(RVA = "0x1437B78", Offset = "0x1437B78", VA = "0x1437B78")]
		public static void ResetNetOffsets()
		{
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DD")]
		[Address(RVA = "0x1437CC0", Offset = "0x1437CC0", VA = "0x1437CC0")]
		public void UpdateNPC(int i)
		{
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DE")]
		[Address(RVA = "0x14421F8", Offset = "0x14421F8", VA = "0x14421F8")]
		private void CheckDialogue()
		{
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DF")]
		[Address(RVA = "0x1441554", Offset = "0x1441554", VA = "0x1441554")]
		private void SubAI_HandleTemporaryCatchableNPCPlayerInvulnerability()
		{
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E0")]
		[Address(RVA = "0x143B270", Offset = "0x143B270", VA = "0x143B270")]
		private void TrySyncingUniqueTownNPCData(int npcIndex)
		{
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E1")]
		[Address(RVA = "0x1308748", Offset = "0x1308748", VA = "0x1308748")]
		public void NetUpdateIgnoreSpamLimit()
		{
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E2")]
		[Address(RVA = "0x1326D48", Offset = "0x1326D48", VA = "0x1326D48")]
		public void NetUpdateLowPriority()
		{
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E3")]
		[Address(RVA = "0x1441130", Offset = "0x1441130", VA = "0x1441130")]
		private void UpdateNetworkCode(int i)
		{
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E4")]
		[Address(RVA = "0x1442FBC", Offset = "0x1442FBC", VA = "0x1442FBC")]
		private void StreamUpdatesToNearbyPlayers()
		{
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060027E5 RID: 10213 RVA: 0x00013080 File Offset: 0x00011280
		[Token(Token = "0x17000587")]
		public Point NetSectionCoordinates
		{
			[Token(Token = "0x60027E5")]
			[Address(RVA = "0x1443380", Offset = "0x1443380", VA = "0x1443380")]
			get
			{
				return default(Point);
			}
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E6")]
		[Address(RVA = "0x1442DDC", Offset = "0x1442DDC", VA = "0x1442DDC")]
		private void RecheckSectionsForSkippedUpdates()
		{
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E7")]
		[Address(RVA = "0x1433BE8", Offset = "0x1433BE8", VA = "0x1433BE8")]
		private static NPC.PendingDamage PushPendingDamage(NPC struck)
		{
			return null;
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E8")]
		[Address(RVA = "0x1435544", Offset = "0x1435544", VA = "0x1435544")]
		public static void AddStrikeDamage(NPC target, int damageTaken)
		{
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E9")]
		[Address(RVA = "0x141FC30", Offset = "0x141FC30", VA = "0x141FC30")]
		public static void SetStrikePhaseChange(NPC target)
		{
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EA")]
		[Address(RVA = "0x144345C", Offset = "0x144345C", VA = "0x144345C")]
		internal static void AckDamage()
		{
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EB")]
		[Address(RVA = "0x1443544", Offset = "0x1443544", VA = "0x1443544")]
		public static void GetPendingDamage(NPC npc, out int damage, out bool phaseChange)
		{
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027EC")]
		[Address(RVA = "0x144378C", Offset = "0x144378C", VA = "0x144378C")]
		public IEntitySource GetItemSource_Misc(int itemSourceId)
		{
			return null;
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027ED")]
		[Address(RVA = "0x142FD50", Offset = "0x142FD50", VA = "0x142FD50")]
		public static IEntitySource GetSpawnSource_NPCRelease(int whoReleasedIt)
		{
			return null;
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027EE")]
		[Address(RVA = "0x142DFF4", Offset = "0x142DFF4", VA = "0x142DFF4")]
		public static IEntitySource GetSpawnSource_NPCCatch(int whoCatchedIt)
		{
			return null;
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027EF")]
		[Address(RVA = "0x142B088", Offset = "0x142B088", VA = "0x142B088")]
		public IEntitySource GetSpawnSource_NPCHurt()
		{
			return null;
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F0")]
		[Address(RVA = "0x130D4F0", Offset = "0x130D4F0", VA = "0x130D4F0")]
		public IEntitySource GetSpawnSource_ForProjectile()
		{
			return null;
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F1")]
		[Address(RVA = "0x130D564", Offset = "0x130D564", VA = "0x130D564")]
		public IEntitySource GetSpawnSourceForProjectileNPC()
		{
			return null;
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F2")]
		[Address(RVA = "0x1443808", Offset = "0x1443808", VA = "0x1443808")]
		public static IEntitySource GetSpawnSourceForNaturalSpawn()
		{
			return null;
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F3")]
		[Address(RVA = "0x1443874", Offset = "0x1443874", VA = "0x1443874")]
		public static IEntitySource GetSpawnSourceForTownSpawn()
		{
			return null;
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F4")]
		[Address(RVA = "0x13003E8", Offset = "0x13003E8", VA = "0x13003E8")]
		public IEntitySource GetSpawnSourceForNPCFromNPCAI()
		{
			return null;
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F5")]
		[Address(RVA = "0x140A9F0", Offset = "0x140A9F0", VA = "0x140A9F0")]
		public IEntitySource GetItemSource_Loot()
		{
			return null;
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F6")]
		[Address(RVA = "0x1442370", Offset = "0x1442370", VA = "0x1442370")]
		private void UpdateNPC_UpdateTrails()
		{
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F7")]
		[Address(RVA = "0x1440CC0", Offset = "0x1440CC0", VA = "0x1440CC0")]
		private void UpdateNPC_UpdateGravity(out float maxFallSpeed)
		{
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F8")]
		[Address(RVA = "0x143BA94", Offset = "0x143BA94", VA = "0x143BA94")]
		private void UpdateNPC_SoulDrainDebuff()
		{
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x00013098 File Offset: 0x00011298
		[Token(Token = "0x60027F9")]
		[Address(RVA = "0x14438E0", Offset = "0x14438E0", VA = "0x14438E0")]
		public static Color buffColor(Color newColor, float R, float G, float B, float A)
		{
			return default(Color);
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x000130B0 File Offset: 0x000112B0
		[Token(Token = "0x60027FA")]
		[Address(RVA = "0x14439A8", Offset = "0x14439A8", VA = "0x14439A8")]
		public bool CurrentlyShimmerTransparent()
		{
			return default(bool);
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x000130C8 File Offset: 0x000112C8
		[Token(Token = "0x60027FB")]
		[Address(RVA = "0x1443AE8", Offset = "0x1443AE8", VA = "0x1443AE8")]
		public bool AppearsFriendlyToHunterPotion()
		{
			return default(bool);
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x000130E0 File Offset: 0x000112E0
		[Token(Token = "0x60027FC")]
		[Address(RVA = "0x1443A5C", Offset = "0x1443A5C", VA = "0x1443A5C")]
		public bool CanApplyHunterPotionEffects()
		{
			return default(bool);
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x000130F8 File Offset: 0x000112F8
		[Token(Token = "0x60027FD")]
		[Address(RVA = "0x1443C00", Offset = "0x1443C00", VA = "0x1443C00")]
		public Color GetNPCColorTintedByBuffs(Color npcColor)
		{
			return default(Color);
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FE")]
		[Address(RVA = "0x143CD70", Offset = "0x143CD70", VA = "0x143CD70")]
		private void UpdateNPC_BuffApplyVFX()
		{
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FF")]
		[Address(RVA = "0x135E180", Offset = "0x135E180", VA = "0x135E180")]
		private void GetShimmered()
		{
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002800")]
		[Address(RVA = "0x143C2E4", Offset = "0x143C2E4", VA = "0x143C2E4")]
		private void UpdateNPC_BuffApplyDOTs()
		{
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x00013110 File Offset: 0x00011310
		[Token(Token = "0x6002801")]
		[Address(RVA = "0x14447E8", Offset = "0x14447E8", VA = "0x14447E8")]
		private int GetDryadsBaneDamagePerSecond()
		{
			return 0;
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002802")]
		[Address(RVA = "0x1444F1C", Offset = "0x1444F1C", VA = "0x1444F1C")]
		private void ApplyEelWhipDoT()
		{
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002803")]
		[Address(RVA = "0x1444B98", Offset = "0x1444B98", VA = "0x1444B98")]
		public void GetHurtByDebuff(int amount)
		{
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002804")]
		[Address(RVA = "0x143C130", Offset = "0x143C130", VA = "0x143C130")]
		private void UpdateNPC_BuffClearExpiredBuffs()
		{
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002805")]
		[Address(RVA = "0x1440BCC", Offset = "0x1440BCC", VA = "0x1440BCC")]
		private void UpdateNPC_BloodMoonTransformations()
		{
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002806")]
		[Address(RVA = "0x1445084", Offset = "0x1445084", VA = "0x1445084")]
		public void AttemptToConvertNPCToEvil(bool crimson)
		{
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002807")]
		[Address(RVA = "0x143B3B8", Offset = "0x143B3B8", VA = "0x143B3B8")]
		public void UpdateNPC_BuffSetFlags(bool lowerBuffTime = true)
		{
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002808")]
		[Address(RVA = "0x143B37C", Offset = "0x143B37C", VA = "0x143B37C")]
		private void UpdateNPC_BuffFlagsReset()
		{
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002809")]
		[Address(RVA = "0x143A0C8", Offset = "0x143A0C8", VA = "0x143A0C8")]
		private void UpdateNPC_TeleportVisuals()
		{
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280A")]
		[Address(RVA = "0x143A888", Offset = "0x143A888", VA = "0x143A888")]
		private void UpdateNPC_CritterSounds()
		{
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280B")]
		[Address(RVA = "0x1439708", Offset = "0x1439708", VA = "0x1439708")]
		private void UpdateNPC_CastLights()
		{
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280C")]
		[Address(RVA = "0x1441994", Offset = "0x1441994", VA = "0x1441994")]
		private void GetHurtByOtherNPCs(bool[] acceptableNPCIDs)
		{
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280D")]
		[Address(RVA = "0x1445ACC", Offset = "0x1445ACC", VA = "0x1445ACC")]
		private void BeHurtByOtherNPC(int npcIndex, NPC thatNPC)
		{
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280E")]
		[Address(RVA = "0x1441928", Offset = "0x1441928", VA = "0x1441928")]
		private void CheckLifeRegen()
		{
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280F")]
		[Address(RVA = "0x1445D00", Offset = "0x1445D00", VA = "0x1445D00")]
		public void GetImmuneTime(int fromWho, int time)
		{
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002810")]
		[Address(RVA = "0x1441D58", Offset = "0x1441D58", VA = "0x1441D58")]
		private void UpdateCollision()
		{
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x00013128 File Offset: 0x00011328
		[Token(Token = "0x6002811")]
		[Address(RVA = "0x14490AC", Offset = "0x14490AC", VA = "0x14490AC")]
		private bool ConveyorBeltCollision()
		{
			return default(bool);
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002812")]
		[Address(RVA = "0x1448810", Offset = "0x1448810", VA = "0x1448810")]
		private void Collision_MoveWhileDry()
		{
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002813")]
		[Address(RVA = "0x14484F8", Offset = "0x14484F8", VA = "0x14484F8")]
		private void ApplyTileCollision(bool fall, Vector2 cPosition, int cWidth, int cHeight)
		{
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002814")]
		[Address(RVA = "0x1448B38", Offset = "0x1448B38", VA = "0x1448B38")]
		private void Collision_MoveSlopesAndStairFall(bool fall)
		{
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002815")]
		[Address(RVA = "0x1448948", Offset = "0x1448948", VA = "0x1448948")]
		private void Collision_MoveSnailOnSlopes()
		{
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002816")]
		[Address(RVA = "0x14497B8", Offset = "0x14497B8", VA = "0x14497B8")]
		private void Collision_MoveNormal(bool fall, Vector2 cPosition, int cWidth, int cHeight)
		{
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002817")]
		[Address(RVA = "0x14492B8", Offset = "0x14492B8", VA = "0x14492B8")]
		private void Collision_MoveSandshark(bool fall, Vector2 cPosition, int cWidth, int cHeight)
		{
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002818")]
		[Address(RVA = "0x144958C", Offset = "0x144958C", VA = "0x144958C")]
		private void Collision_MoveSolarSroller(bool fall, Vector2 cPosition, int cWidth, int cHeight)
		{
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002819")]
		[Address(RVA = "0x1449408", Offset = "0x1449408", VA = "0x1449408")]
		private void Collision_MoveStardustCell(bool fall, Vector2 cPosition, int cWidth, int cHeight)
		{
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281A")]
		[Address(RVA = "0x1449154", Offset = "0x1449154", VA = "0x1449154")]
		private void Collision_MoveBlazingWheel()
		{
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281B")]
		[Address(RVA = "0x144867C", Offset = "0x144867C", VA = "0x144867C")]
		private void Collision_MoveWhileWet(Vector2 oldDryVelocity, float Slowdown = 0.5f)
		{
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281C")]
		[Address(RVA = "0x141AEE4", Offset = "0x141AEE4", VA = "0x141AEE4")]
		public void GetTileCollisionParameters(out Vector2 cPosition, out int cWidth, out int cHeight)
		{
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281D")]
		[Address(RVA = "0x14482EC", Offset = "0x14482EC", VA = "0x14482EC")]
		private void FishTransformationDuringRain()
		{
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x00013140 File Offset: 0x00011340
		[Token(Token = "0x600281E")]
		[Address(RVA = "0x1447D38", Offset = "0x1447D38", VA = "0x1447D38")]
		private bool Collision_DecideFallThroughPlatforms()
		{
			return default(bool);
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x00013158 File Offset: 0x00011358
		[Token(Token = "0x600281F")]
		[Address(RVA = "0x1446150", Offset = "0x1446150", VA = "0x1446150")]
		private bool Collision_WaterCollision(bool lava)
		{
			return default(bool);
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002820")]
		[Address(RVA = "0x144202C", Offset = "0x144202C", VA = "0x144202C")]
		private void TryRemovingWaterPerishableEffects(bool isInLava)
		{
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002821")]
		[Address(RVA = "0x1449884", Offset = "0x1449884", VA = "0x1449884")]
		private void TryAddingRepeatedBuff(int buffId, int timeToGive, int lowThresholdUndeathToAllowBuff = 10)
		{
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x00013170 File Offset: 0x00011370
		[Token(Token = "0x6002822")]
		[Address(RVA = "0x1445EB8", Offset = "0x1445EB8", VA = "0x1445EB8")]
		private bool Collision_LavaCollision()
		{
			return default(bool);
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002823")]
		[Address(RVA = "0x1445DA0", Offset = "0x1445DA0", VA = "0x1445DA0")]
		private void Collision_WalkDownSlopes()
		{
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002824")]
		[Address(RVA = "0x1449910", Offset = "0x1449910", VA = "0x1449910")]
		public static void setFireFlyChance()
		{
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x00013188 File Offset: 0x00011388
		[Token(Token = "0x6002825")]
		[Address(RVA = "0x144A0C0", Offset = "0x144A0C0", VA = "0x144A0C0")]
		public Color GetBestiaryEntryColor()
		{
			return default(Color);
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x000131A0 File Offset: 0x000113A0
		[Token(Token = "0x6002826")]
		[Address(RVA = "0x144A128", Offset = "0x144A128", VA = "0x144A128")]
		public Color GetAlpha(Color newColor)
		{
			return default(Color);
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x000131B8 File Offset: 0x000113B8
		[Token(Token = "0x6002827")]
		[Address(RVA = "0x144B3F4", Offset = "0x144B3F4", VA = "0x144B3F4")]
		public Color GetShimmerColor(Color newColor)
		{
			return default(Color);
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x000131D0 File Offset: 0x000113D0
		[Token(Token = "0x6002828")]
		[Address(RVA = "0x144B498", Offset = "0x144B498", VA = "0x144B498")]
		public Color GetColor(Color newColor)
		{
			return default(Color);
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x000131E8 File Offset: 0x000113E8
		[Token(Token = "0x6002829")]
		[Address(RVA = "0x14377EC", Offset = "0x14377EC", VA = "0x14377EC")]
		public static bool ShouldBestiaryGirlBeLycantrope()
		{
			return default(bool);
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282A")]
		[Address(RVA = "0x144B628", Offset = "0x144B628", VA = "0x144B628")]
		public string GetChat()
		{
			return null;
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282B")]
		[Address(RVA = "0x1454240", Offset = "0x1454240", VA = "0x1454240")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x00013200 File Offset: 0x00011400
		[Token(Token = "0x600282C")]
		[Address(RVA = "0x1454248", Offset = "0x1454248", VA = "0x1454248")]
		public static bool CanShowHomelessText(int npcIndex)
		{
			return default(bool);
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x00013218 File Offset: 0x00011418
		[Token(Token = "0x600282D")]
		[Address(RVA = "0x1453EF0", Offset = "0x1453EF0", VA = "0x1453EF0")]
		public bool HasLuckTextForWizard(out string specialEventText)
		{
			return default(bool);
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x00013230 File Offset: 0x00011430
		[Token(Token = "0x600282E")]
		[Address(RVA = "0x1453948", Offset = "0x1453948", VA = "0x1453948")]
		public bool HasSpecialEventText(string specialTextCategoryKey, out string specialEventText)
		{
			return default(bool);
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x00013248 File Offset: 0x00011448
		[Token(Token = "0x600282F")]
		[Address(RVA = "0x145432C", Offset = "0x145432C", VA = "0x145432C")]
		public bool GetSpecialEventTextIfNotEmpty(string specialTextKey, object substitutes, ref string specialEventText)
		{
			return default(bool);
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002830")]
		[Address(RVA = "0x1441648", Offset = "0x1441648", VA = "0x1441648")]
		public void CheckDrowning()
		{
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002831")]
		[Address(RVA = "0x144149C", Offset = "0x144149C", VA = "0x144149C")]
		public void TryPortalJumping()
		{
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002832")]
		[Address(RVA = "0x1445168", Offset = "0x1445168", VA = "0x1445168")]
		public static void GetMeleeCollisionData(ref Rectangle victimHitbox, int enemyIndex, ref int specialHitSetter, ref float damageMultiplier, ref Rectangle npcRect)
		{
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002833")]
		[Address(RVA = "0x1454454", Offset = "0x1454454", VA = "0x1454454")]
		public string GetBestiaryCreditId()
		{
			return null;
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002834")]
		[Address(RVA = "0x14544F8", Offset = "0x14544F8", VA = "0x14544F8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040036FE RID: 14078
		[Token(Token = "0x40036FE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int MoonLordCountdown;

		// Token: 0x040036FF RID: 14079
		[Token(Token = "0x40036FF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int immuneTime;

		// Token: 0x04003700 RID: 14080
		[Token(Token = "0x4003700")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int maxAI;

		// Token: 0x04003701 RID: 14081
		[Token(Token = "0x4003701")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static int[] killCount;

		// Token: 0x04003702 RID: 14082
		[Token(Token = "0x4003702")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static float waveKills;

		// Token: 0x04003703 RID: 14083
		[Token(Token = "0x4003703")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static int waveNumber;

		// Token: 0x04003704 RID: 14084
		[Token(Token = "0x4003704")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool taxCollector;

		// Token: 0x04003705 RID: 14085
		[Token(Token = "0x4003705")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public static bool freeCake;

		// Token: 0x04003706 RID: 14086
		[Token(Token = "0x4003706")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static float gravity;

		// Token: 0x04003707 RID: 14087
		[Token(Token = "0x4003707")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static int fireFlyFriendly;

		// Token: 0x04003708 RID: 14088
		[Token(Token = "0x4003708")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static int fireFlyChance;

		// Token: 0x04003709 RID: 14089
		[Token(Token = "0x4003709")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static int fireFlyMultiple;

		// Token: 0x0400370A RID: 14090
		[Token(Token = "0x400370A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static int butterflyChance;

		// Token: 0x0400370B RID: 14091
		[Token(Token = "0x400370B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static int golemBoss;

		// Token: 0x0400370C RID: 14092
		[Token(Token = "0x400370C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static int plantBoss;

		// Token: 0x0400370D RID: 14093
		[Token(Token = "0x400370D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static int crimsonBoss;

		// Token: 0x0400370E RID: 14094
		[Token(Token = "0x400370E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static int deerclopsBoss;

		// Token: 0x0400370F RID: 14095
		[Token(Token = "0x400370F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static int sWidth;

		// Token: 0x04003710 RID: 14096
		[Token(Token = "0x4003710")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static int sHeight;

		// Token: 0x04003711 RID: 14097
		[Token(Token = "0x4003711")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static int spawnRangeX;

		// Token: 0x04003712 RID: 14098
		[Token(Token = "0x4003712")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private static int spawnRangeY;

		// Token: 0x04003713 RID: 14099
		[Token(Token = "0x4003713")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static int safeRangeX;

		// Token: 0x04003714 RID: 14100
		[Token(Token = "0x4003714")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static int safeRangeY;

		// Token: 0x04003715 RID: 14101
		[Token(Token = "0x4003715")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static int activeRangeX;

		// Token: 0x04003716 RID: 14102
		[Token(Token = "0x4003716")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private static int activeRangeY;

		// Token: 0x04003717 RID: 14103
		[Token(Token = "0x4003717")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static int townRangeX;

		// Token: 0x04003718 RID: 14104
		[Token(Token = "0x4003718")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private static int townRangeY;

		// Token: 0x04003719 RID: 14105
		[Token(Token = "0x4003719")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static bool noSpawnCycle;

		// Token: 0x0400371A RID: 14106
		[Token(Token = "0x400371A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private static int activeTime;

		// Token: 0x0400371B RID: 14107
		[Token(Token = "0x400371B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static int defaultSpawnRate;

		// Token: 0x0400371C RID: 14108
		[Token(Token = "0x400371C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private static int defaultMaxSpawns;

		// Token: 0x0400371D RID: 14109
		[Token(Token = "0x400371D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static bool savedTaxCollector;

		// Token: 0x0400371E RID: 14110
		[Token(Token = "0x400371E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public static bool savedGoblin;

		// Token: 0x0400371F RID: 14111
		[Token(Token = "0x400371F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		public static bool savedWizard;

		// Token: 0x04003720 RID: 14112
		[Token(Token = "0x4003720")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
		public static bool savedMech;

		// Token: 0x04003721 RID: 14113
		[Token(Token = "0x4003721")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public static bool savedAngler;

		// Token: 0x04003722 RID: 14114
		[Token(Token = "0x4003722")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		public static bool savedStylist;

		// Token: 0x04003723 RID: 14115
		[Token(Token = "0x4003723")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
		public static bool savedBartender;

		// Token: 0x04003724 RID: 14116
		[Token(Token = "0x4003724")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F")]
		public static bool savedGolfer;

		// Token: 0x04003725 RID: 14117
		[Token(Token = "0x4003725")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static bool boughtCat;

		// Token: 0x04003726 RID: 14118
		[Token(Token = "0x4003726")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public static bool boughtDog;

		// Token: 0x04003727 RID: 14119
		[Token(Token = "0x4003727")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		public static bool boughtBunny;

		// Token: 0x04003728 RID: 14120
		[Token(Token = "0x4003728")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x83")]
		public static bool combatBookWasUsed;

		// Token: 0x04003729 RID: 14121
		[Token(Token = "0x4003729")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static bool combatBookVolumeTwoWasUsed;

		// Token: 0x0400372A RID: 14122
		[Token(Token = "0x400372A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		public static bool peddlersSatchelWasUsed;

		// Token: 0x0400372B RID: 14123
		[Token(Token = "0x400372B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		public static bool downedBoss1;

		// Token: 0x0400372C RID: 14124
		[Token(Token = "0x400372C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x87")]
		public static bool downedBoss2;

		// Token: 0x0400372D RID: 14125
		[Token(Token = "0x400372D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static bool downedBoss3;

		// Token: 0x0400372E RID: 14126
		[Token(Token = "0x400372E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public static bool downedQueenBee;

		// Token: 0x0400372F RID: 14127
		[Token(Token = "0x400372F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public static bool downedSlimeKing;

		// Token: 0x04003730 RID: 14128
		[Token(Token = "0x4003730")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		public static bool downedGoblins;

		// Token: 0x04003731 RID: 14129
		[Token(Token = "0x4003731")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public static bool downedFrost;

		// Token: 0x04003732 RID: 14130
		[Token(Token = "0x4003732")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		public static bool downedPirates;

		// Token: 0x04003733 RID: 14131
		[Token(Token = "0x4003733")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8E")]
		public static bool downedClown;

		// Token: 0x04003734 RID: 14132
		[Token(Token = "0x4003734")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8F")]
		public static bool downedPlantBoss;

		// Token: 0x04003735 RID: 14133
		[Token(Token = "0x4003735")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static bool downedGolemBoss;

		// Token: 0x04003736 RID: 14134
		[Token(Token = "0x4003736")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public static bool downedMartians;

		// Token: 0x04003737 RID: 14135
		[Token(Token = "0x4003737")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		public static bool downedFishron;

		// Token: 0x04003738 RID: 14136
		[Token(Token = "0x4003738")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		public static bool downedHalloweenTree;

		// Token: 0x04003739 RID: 14137
		[Token(Token = "0x4003739")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public static bool downedHalloweenKing;

		// Token: 0x0400373A RID: 14138
		[Token(Token = "0x400373A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		public static bool downedChristmasIceQueen;

		// Token: 0x0400373B RID: 14139
		[Token(Token = "0x400373B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x96")]
		public static bool downedChristmasTree;

		// Token: 0x0400373C RID: 14140
		[Token(Token = "0x400373C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x97")]
		public static bool downedChristmasSantank;

		// Token: 0x0400373D RID: 14141
		[Token(Token = "0x400373D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static bool downedAncientCultist;

		// Token: 0x0400373E RID: 14142
		[Token(Token = "0x400373E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public static bool downedMoonlord;

		// Token: 0x0400373F RID: 14143
		[Token(Token = "0x400373F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		public static bool downedTowerSolar;

		// Token: 0x04003740 RID: 14144
		[Token(Token = "0x4003740")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9B")]
		public static bool downedTowerVortex;

		// Token: 0x04003741 RID: 14145
		[Token(Token = "0x4003741")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public static bool downedTowerNebula;

		// Token: 0x04003742 RID: 14146
		[Token(Token = "0x4003742")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		public static bool downedTowerStardust;

		// Token: 0x04003743 RID: 14147
		[Token(Token = "0x4003743")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9E")]
		public static bool downedEmpressOfLight;

		// Token: 0x04003744 RID: 14148
		[Token(Token = "0x4003744")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9F")]
		public static bool downedQueenSlime;

		// Token: 0x04003745 RID: 14149
		[Token(Token = "0x4003745")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static bool downedDeerclops;

		// Token: 0x04003746 RID: 14150
		[Token(Token = "0x4003746")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public static int ShieldStrengthTowerSolar;

		// Token: 0x04003747 RID: 14151
		[Token(Token = "0x4003747")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static int ShieldStrengthTowerVortex;

		// Token: 0x04003748 RID: 14152
		[Token(Token = "0x4003748")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public static int ShieldStrengthTowerNebula;

		// Token: 0x04003749 RID: 14153
		[Token(Token = "0x4003749")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static int ShieldStrengthTowerStardust;

		// Token: 0x0400374A RID: 14154
		[Token(Token = "0x400374A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public static int LunarShieldPowerNormal;

		// Token: 0x0400374B RID: 14155
		[Token(Token = "0x400374B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static int LunarShieldPowerExpert;

		// Token: 0x0400374C RID: 14156
		[Token(Token = "0x400374C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public static bool TowerActiveSolar;

		// Token: 0x0400374D RID: 14157
		[Token(Token = "0x400374D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public static bool TowerActiveVortex;

		// Token: 0x0400374E RID: 14158
		[Token(Token = "0x400374E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBE")]
		public static bool TowerActiveNebula;

		// Token: 0x0400374F RID: 14159
		[Token(Token = "0x400374F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBF")]
		public static bool TowerActiveStardust;

		// Token: 0x04003750 RID: 14160
		[Token(Token = "0x4003750")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static bool LunarApocalypseIsUp;

		// Token: 0x04003751 RID: 14161
		[Token(Token = "0x4003751")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		public static bool downedMechBossAny;

		// Token: 0x04003752 RID: 14162
		[Token(Token = "0x4003752")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		public static bool downedMechBoss1;

		// Token: 0x04003753 RID: 14163
		[Token(Token = "0x4003753")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC3")]
		public static bool downedMechBoss2;

		// Token: 0x04003754 RID: 14164
		[Token(Token = "0x4003754")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public static bool downedMechBoss3;

		// Token: 0x04003755 RID: 14165
		[Token(Token = "0x4003755")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static bool[] npcsFoundForCheckActive;

		// Token: 0x04003756 RID: 14166
		[Token(Token = "0x4003756")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public static int[] lazyNPCOwnedProjectileSearchArray;

		// Token: 0x04003757 RID: 14167
		[Token(Token = "0x4003757")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static int[] spawnSlotProtected;

		// Token: 0x04003758 RID: 14168
		[Token(Token = "0x4003758")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private static int spawnRate;

		// Token: 0x04003759 RID: 14169
		[Token(Token = "0x4003759")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static int maxSpawns;

		// Token: 0x0400375A RID: 14170
		[Token(Token = "0x400375A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public static CoinLossRevengeSystem RevengeManager;

		// Token: 0x0400375B RID: 14171
		[Token(Token = "0x400375B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static bool travelNPC;

		// Token: 0x0400375C RID: 14172
		[Token(Token = "0x400375C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public static int[,] cavernMonsterType;

		// Token: 0x0400375D RID: 14173
		[Token(Token = "0x400375D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static bool EoCKilledToday;

		// Token: 0x0400375E RID: 14174
		[Token(Token = "0x400375E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		private static bool WoFKilledToday;

		// Token: 0x0400375F RID: 14175
		[Token(Token = "0x400375F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
		public static bool fairyLog;

		// Token: 0x04003760 RID: 14176
		[Token(Token = "0x4003760")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private static int ignorePlayerInteractions;

		// Token: 0x04003761 RID: 14177
		[Token(Token = "0x4003761")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public static int ladyBugGoodLuckTime;

		// Token: 0x04003762 RID: 14178
		[Token(Token = "0x4003762")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public static int ladyBugBadLuckTime;

		// Token: 0x04003763 RID: 14179
		[Token(Token = "0x4003763")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static int ladyBugRainTime;

		// Token: 0x04003764 RID: 14180
		[Token(Token = "0x4003764")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private static int maximumAmountOfTimesLadyBugRainCanStack;

		// Token: 0x04003765 RID: 14181
		[Token(Token = "0x4003765")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public static int offSetDelayTime;

		// Token: 0x04003766 RID: 14182
		[Token(Token = "0x4003766")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool active;

		// Token: 0x04003767 RID: 14183
		[Token(Token = "0x4003767")]
		private const int NPC_TARGETS_START = 300;

		// Token: 0x04003768 RID: 14184
		[Token(Token = "0x4003768")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool IsABestiaryIconDummy;

		// Token: 0x04003769 RID: 14185
		[Token(Token = "0x4003769")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x43")]
		public bool IsAPortraitDummy;

		// Token: 0x0400376A RID: 14186
		[Token(Token = "0x400376A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool ForcePartyHatOn;

		// Token: 0x0400376B RID: 14187
		[Token(Token = "0x400376B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float waterMovementSpeed;

		// Token: 0x0400376C RID: 14188
		[Token(Token = "0x400376C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float lavaMovementSpeed;

		// Token: 0x0400376D RID: 14189
		[Token(Token = "0x400376D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float honeyMovementSpeed;

		// Token: 0x0400376E RID: 14190
		[Token(Token = "0x400376E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float shimmerMovementSpeed;

		// Token: 0x0400376F RID: 14191
		[Token(Token = "0x400376F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public static readonly int MoonLordHeadAttackTotalLoopTime;

		// Token: 0x04003770 RID: 14192
		[Token(Token = "0x4003770")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public static readonly int[,,] MoonLordAttacksArray;

		// Token: 0x04003771 RID: 14193
		[Token(Token = "0x4003771")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public static readonly int[,] MoonLordAttacksArray2;

		// Token: 0x04003772 RID: 14194
		[Token(Token = "0x4003772")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public static int MoonLordFightingDistance;

		// Token: 0x04003773 RID: 14195
		[Token(Token = "0x4003773")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public static int MaxMoonLordCountdown;

		// Token: 0x04003774 RID: 14196
		[Token(Token = "0x4003774")]
		public const int NaturalMoonlordCountdownTime = 3600;

		// Token: 0x04003775 RID: 14197
		[Token(Token = "0x4003775")]
		public const int ItemMoonlordCountdownTime = 720;

		// Token: 0x04003776 RID: 14198
		[Token(Token = "0x4003776")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int teleportStyle;

		// Token: 0x04003777 RID: 14199
		[Token(Token = "0x4003777")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float teleportTime;

		// Token: 0x04003778 RID: 14200
		[Token(Token = "0x4003778")]
		public const int goldCritterChance = 400;

		// Token: 0x04003779 RID: 14201
		[Token(Token = "0x4003779")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public static float totalInvasionPoints;

		// Token: 0x0400377A RID: 14202
		[Token(Token = "0x400377A")]
		public const float nameOverIncrement = 0.025f;

		// Token: 0x0400377B RID: 14203
		[Token(Token = "0x400377B")]
		public const float nameOverDistance = 350f;

		// Token: 0x0400377C RID: 14204
		[Token(Token = "0x400377C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float nameOver;

		// Token: 0x0400377D RID: 14205
		[Token(Token = "0x400377D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool SpawnedFromStatue;

		// Token: 0x0400377E RID: 14206
		[Token(Token = "0x400377E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		public bool CanBeReplacedByOtherNPCs;

		// Token: 0x0400377F RID: 14207
		[Token(Token = "0x400377F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		public bool dripping;

		// Token: 0x04003780 RID: 14208
		[Token(Token = "0x4003780")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		public bool drippingSlime;

		// Token: 0x04003781 RID: 14209
		[Token(Token = "0x4003781")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool drippingSparkleSlime;

		// Token: 0x04003782 RID: 14210
		[Token(Token = "0x4003782")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public static bool[] ShimmeredTownNPCs;

		// Token: 0x04003783 RID: 14211
		[Token(Token = "0x4003783")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int altTexture;

		// Token: 0x04003784 RID: 14212
		[Token(Token = "0x4003784")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int townNpcVariationIndex;

		// Token: 0x04003785 RID: 14213
		[Token(Token = "0x4003785")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public short catchItem;

		// Token: 0x04003786 RID: 14214
		[Token(Token = "0x4003786")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x76")]
		public short releaseOwner;

		// Token: 0x04003787 RID: 14215
		[Token(Token = "0x4003787")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int rarity;

		// Token: 0x04003788 RID: 14216
		[Token(Token = "0x4003788")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool[] playerInteraction;

		// Token: 0x04003789 RID: 14217
		[Token(Token = "0x4003789")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int lastInteraction;

		// Token: 0x0400378A RID: 14218
		[Token(Token = "0x400378A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool interactedWithPlayerLocally;

		// Token: 0x0400378B RID: 14219
		[Token(Token = "0x400378B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float takenDamageMultiplier;

		// Token: 0x0400378C RID: 14220
		[Token(Token = "0x400378C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static int spawnSpaceX;

		// Token: 0x0400378D RID: 14221
		[Token(Token = "0x400378D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private static int spawnSpaceY;

		// Token: 0x0400378E RID: 14222
		[Token(Token = "0x400378E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float gfxOffY;

		// Token: 0x0400378F RID: 14223
		[Token(Token = "0x400378F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float stepSpeed;

		// Token: 0x04003790 RID: 14224
		[Token(Token = "0x4003790")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool teleporting;

		// Token: 0x04003791 RID: 14225
		[Token(Token = "0x4003791")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		public bool stairFall;

		// Token: 0x04003792 RID: 14226
		[Token(Token = "0x4003792")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public static int stinkBugChance;

		// Token: 0x04003793 RID: 14227
		[Token(Token = "0x4003793")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Vector2[] oldPos;

		// Token: 0x04003794 RID: 14228
		[Token(Token = "0x4003794")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float[] oldRot;

		// Token: 0x04003795 RID: 14229
		[Token(Token = "0x4003795")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool setFrameSize;

		// Token: 0x04003796 RID: 14230
		[Token(Token = "0x4003796")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private byte <generation>k__BackingField;

		// Token: 0x04003797 RID: 14231
		[Token(Token = "0x4003797")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool netUpdate;

		// Token: 0x04003798 RID: 14232
		[Token(Token = "0x4003798")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		internal bool netUpdatePendingSpamCooldown;

		// Token: 0x04003799 RID: 14233
		[Token(Token = "0x4003799")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		internal bool netUpdatePendingFullSpamCooldown;

		// Token: 0x0400379A RID: 14234
		[Token(Token = "0x400379A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public readonly int netSpamPacketLimit;

		// Token: 0x0400379B RID: 14235
		[Token(Token = "0x400379B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public readonly int netSpamTicksPerPacket;

		// Token: 0x0400379C RID: 14236
		[Token(Token = "0x400379C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public readonly int netSpamTicksPerPacketForBosses;

		// Token: 0x0400379D RID: 14237
		[Token(Token = "0x400379D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public int netSpam;

		// Token: 0x0400379E RID: 14238
		[Token(Token = "0x400379E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool netAlways;

		// Token: 0x0400379F RID: 14239
		[Token(Token = "0x400379F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		public bool spawnNeedsSyncing;

		// Token: 0x040037A0 RID: 14240
		[Token(Token = "0x40037A0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		internal int netStream;

		// Token: 0x040037A1 RID: 14241
		[Token(Token = "0x40037A1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal NPC.PlayerNetSyncState[] playerNetSyncState;

		// Token: 0x040037A2 RID: 14242
		[Token(Token = "0x40037A2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool needsUniqueInfoUpdate;

		// Token: 0x040037A3 RID: 14243
		[Token(Token = "0x40037A3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Vector2 netOffset;

		// Token: 0x040037A4 RID: 14244
		[Token(Token = "0x40037A4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private static List<NPC.PendingDamage> pendingDamages;

		// Token: 0x040037A5 RID: 14245
		[Token(Token = "0x40037A5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int realLife;

		// Token: 0x040037A6 RID: 14246
		[Token(Token = "0x40037A6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private string _givenName;

		// Token: 0x040037A7 RID: 14247
		[Token(Token = "0x40037A7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float npcSlots;

		// Token: 0x040037A8 RID: 14248
		[Token(Token = "0x40037A8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float shimmerTransparency;

		// Token: 0x040037A9 RID: 14249
		[Token(Token = "0x40037A9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool dontCountMe;

		// Token: 0x040037AA RID: 14250
		[Token(Token = "0x40037AA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public static readonly int maxBuffs;

		// Token: 0x040037AB RID: 14251
		[Token(Token = "0x40037AB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public int[] buffType;

		// Token: 0x040037AC RID: 14252
		[Token(Token = "0x40037AC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public int[] buffTime;

		// Token: 0x040037AD RID: 14253
		[Token(Token = "0x40037AD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public bool[] buffImmune;

		// Token: 0x040037AE RID: 14254
		[Token(Token = "0x40037AE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public bool canDisplayBuffs;

		// Token: 0x040037AF RID: 14255
		[Token(Token = "0x40037AF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		public bool midas;

		// Token: 0x040037B0 RID: 14256
		[Token(Token = "0x40037B0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		public bool ichor;

		// Token: 0x040037B1 RID: 14257
		[Token(Token = "0x40037B1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF3")]
		public bool brokenArmor;

		// Token: 0x040037B2 RID: 14258
		[Token(Token = "0x40037B2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public bool onFire;

		// Token: 0x040037B3 RID: 14259
		[Token(Token = "0x40037B3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
		public bool onFire2;

		// Token: 0x040037B4 RID: 14260
		[Token(Token = "0x40037B4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF6")]
		public bool onFire3;

		// Token: 0x040037B5 RID: 14261
		[Token(Token = "0x40037B5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF7")]
		public bool onFrostBurn;

		// Token: 0x040037B6 RID: 14262
		[Token(Token = "0x40037B6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool onFrostBurn2;

		// Token: 0x040037B7 RID: 14263
		[Token(Token = "0x40037B7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		public bool poisoned;

		// Token: 0x040037B8 RID: 14264
		[Token(Token = "0x40037B8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		public bool venom;

		// Token: 0x040037B9 RID: 14265
		[Token(Token = "0x40037B9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		public bool chlorophyteSpore;

		// Token: 0x040037BA RID: 14266
		[Token(Token = "0x40037BA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public bool potentAcid;

		// Token: 0x040037BB RID: 14267
		[Token(Token = "0x40037BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		public bool tipsy;

		// Token: 0x040037BC RID: 14268
		[Token(Token = "0x40037BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFE")]
		public bool bleeding;

		// Token: 0x040037BD RID: 14269
		[Token(Token = "0x40037BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFF")]
		public bool hemorrhage;

		// Token: 0x040037BE RID: 14270
		[Token(Token = "0x40037BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public bool acceleratePoisons;

		// Token: 0x040037BF RID: 14271
		[Token(Token = "0x40037BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		public bool markedByScytheWhip;

		// Token: 0x040037C0 RID: 14272
		[Token(Token = "0x40037C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x102")]
		public bool markedByEelWhip;

		// Token: 0x040037C1 RID: 14273
		[Token(Token = "0x40037C1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x103")]
		public bool blueLightning;

		// Token: 0x040037C2 RID: 14274
		[Token(Token = "0x40037C2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public bool redLightning;

		// Token: 0x040037C3 RID: 14275
		[Token(Token = "0x40037C3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		public bool shadowFlame;

		// Token: 0x040037C4 RID: 14276
		[Token(Token = "0x40037C4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x106")]
		public bool soulDrain;

		// Token: 0x040037C5 RID: 14277
		[Token(Token = "0x40037C5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x107")]
		public bool shimmering;

		// Token: 0x040037C6 RID: 14278
		[Token(Token = "0x40037C6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public int lifeRegen;

		// Token: 0x040037C7 RID: 14279
		[Token(Token = "0x40037C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public int lifeRegenCount;

		// Token: 0x040037C8 RID: 14280
		[Token(Token = "0x40037C8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool confused;

		// Token: 0x040037C9 RID: 14281
		[Token(Token = "0x40037C9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		public bool loveStruck;

		// Token: 0x040037CA RID: 14282
		[Token(Token = "0x40037CA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x112")]
		public bool stinky;

		// Token: 0x040037CB RID: 14283
		[Token(Token = "0x40037CB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x113")]
		public bool dryadWard;

		// Token: 0x040037CC RID: 14284
		[Token(Token = "0x40037CC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public bool immortal;

		// Token: 0x040037CD RID: 14285
		[Token(Token = "0x40037CD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x115")]
		public bool chaseable;

		// Token: 0x040037CE RID: 14286
		[Token(Token = "0x40037CE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x116")]
		public bool canGhostHeal;

		// Token: 0x040037CF RID: 14287
		[Token(Token = "0x40037CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x117")]
		public bool javelined;

		// Token: 0x040037D0 RID: 14288
		[Token(Token = "0x40037D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public bool tentacleSpiked;

		// Token: 0x040037D1 RID: 14289
		[Token(Token = "0x40037D1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		public bool bloodButchered;

		// Token: 0x040037D2 RID: 14290
		[Token(Token = "0x40037D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11A")]
		public bool celled;

		// Token: 0x040037D3 RID: 14291
		[Token(Token = "0x40037D3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11B")]
		public bool dryadBane;

		// Token: 0x040037D4 RID: 14292
		[Token(Token = "0x40037D4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public bool daybreak;

		// Token: 0x040037D5 RID: 14293
		[Token(Token = "0x40037D5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
		public bool dontTakeDamageFromHostiles;

		// Token: 0x040037D6 RID: 14294
		[Token(Token = "0x40037D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11E")]
		public bool betsysCurse;

		// Token: 0x040037D7 RID: 14295
		[Token(Token = "0x40037D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11F")]
		public bool oiled;

		// Token: 0x040037D8 RID: 14296
		[Token(Token = "0x40037D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public int electricEelCounter;

		// Token: 0x040037D9 RID: 14297
		[Token(Token = "0x40037D9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public static bool unlockedSlimeBlueSpawn;

		// Token: 0x040037DA RID: 14298
		[Token(Token = "0x40037DA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x135")]
		public static bool unlockedSlimeGreenSpawn;

		// Token: 0x040037DB RID: 14299
		[Token(Token = "0x40037DB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x136")]
		public static bool unlockedSlimeOldSpawn;

		// Token: 0x040037DC RID: 14300
		[Token(Token = "0x40037DC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x137")]
		public static bool unlockedSlimePurpleSpawn;

		// Token: 0x040037DD RID: 14301
		[Token(Token = "0x40037DD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public static bool unlockedSlimeRainbowSpawn;

		// Token: 0x040037DE RID: 14302
		[Token(Token = "0x40037DE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x139")]
		public static bool unlockedSlimeRedSpawn;

		// Token: 0x040037DF RID: 14303
		[Token(Token = "0x40037DF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13A")]
		public static bool unlockedSlimeYellowSpawn;

		// Token: 0x040037E0 RID: 14304
		[Token(Token = "0x40037E0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13B")]
		public static bool unlockedSlimeCopperSpawn;

		// Token: 0x040037E1 RID: 14305
		[Token(Token = "0x40037E1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public static bool unlockedMerchantSpawn;

		// Token: 0x040037E2 RID: 14306
		[Token(Token = "0x40037E2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13D")]
		public static bool unlockedDemolitionistSpawn;

		// Token: 0x040037E3 RID: 14307
		[Token(Token = "0x40037E3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13E")]
		public static bool unlockedPartyGirlSpawn;

		// Token: 0x040037E4 RID: 14308
		[Token(Token = "0x40037E4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13F")]
		public static bool unlockedDyeTraderSpawn;

		// Token: 0x040037E5 RID: 14309
		[Token(Token = "0x40037E5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public static bool unlockedTruffleSpawn;

		// Token: 0x040037E6 RID: 14310
		[Token(Token = "0x40037E6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		public static bool unlockedArmsDealerSpawn;

		// Token: 0x040037E7 RID: 14311
		[Token(Token = "0x40037E7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x142")]
		public static bool unlockedNurseSpawn;

		// Token: 0x040037E8 RID: 14312
		[Token(Token = "0x40037E8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x143")]
		public static bool unlockedPrincessSpawn;

		// Token: 0x040037E9 RID: 14313
		[Token(Token = "0x40037E9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public static int LunarShieldPowerMax;

		// Token: 0x040037EA RID: 14314
		[Token(Token = "0x40037EA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public int soundDelay;

		// Token: 0x040037EB RID: 14315
		[Token(Token = "0x40037EB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public int[] immune;

		// Token: 0x040037EC RID: 14316
		[Token(Token = "0x40037EC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public int directionY;

		// Token: 0x040037ED RID: 14317
		[Token(Token = "0x40037ED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public int type;

		// Token: 0x040037EE RID: 14318
		[Token(Token = "0x40037EE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public float[] ai;

		// Token: 0x040037EF RID: 14319
		[Token(Token = "0x40037EF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public float[] localAI;

		// Token: 0x040037F0 RID: 14320
		[Token(Token = "0x40037F0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public int aiAction;

		// Token: 0x040037F1 RID: 14321
		[Token(Token = "0x40037F1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public int aiStyle;

		// Token: 0x040037F2 RID: 14322
		[Token(Token = "0x40037F2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public bool justHit;

		// Token: 0x040037F3 RID: 14323
		[Token(Token = "0x40037F3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public int timeLeft;

		// Token: 0x040037F4 RID: 14324
		[Token(Token = "0x40037F4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public int target;

		// Token: 0x040037F5 RID: 14325
		[Token(Token = "0x40037F5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public ulong targetSetFrame;

		// Token: 0x040037F6 RID: 14326
		[Token(Token = "0x40037F6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public int damage;

		// Token: 0x040037F7 RID: 14327
		[Token(Token = "0x40037F7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public int defense;

		// Token: 0x040037F8 RID: 14328
		[Token(Token = "0x40037F8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public int defDamage;

		// Token: 0x040037F9 RID: 14329
		[Token(Token = "0x40037F9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public int defDefense;

		// Token: 0x040037FA RID: 14330
		[Token(Token = "0x40037FA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public int defLifeMax;

		// Token: 0x040037FB RID: 14331
		[Token(Token = "0x40037FB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public bool coldDamage;

		// Token: 0x040037FC RID: 14332
		[Token(Token = "0x40037FC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x16D")]
		public bool trapImmune;

		// Token: 0x040037FD RID: 14333
		[Token(Token = "0x40037FD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public LegacySoundStyle HitSound;

		// Token: 0x040037FE RID: 14334
		[Token(Token = "0x40037FE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		public LegacySoundStyle DeathSound;

		// Token: 0x040037FF RID: 14335
		[Token(Token = "0x40037FF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public int life;

		// Token: 0x04003800 RID: 14336
		[Token(Token = "0x4003800")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public int lifeMax;

		// Token: 0x04003801 RID: 14337
		[Token(Token = "0x4003801")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public Rectangle targetRect;

		// Token: 0x04003802 RID: 14338
		[Token(Token = "0x4003802")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public double frameCounter;

		// Token: 0x04003803 RID: 14339
		[Token(Token = "0x4003803")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public Rectangle frame;

		// Token: 0x04003804 RID: 14340
		[Token(Token = "0x4003804")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public Color color;

		// Token: 0x04003805 RID: 14341
		[Token(Token = "0x4003805")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public int alpha;

		// Token: 0x04003806 RID: 14342
		[Token(Token = "0x4003806")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public bool hide;

		// Token: 0x04003807 RID: 14343
		[Token(Token = "0x4003807")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		public float scale;

		// Token: 0x04003808 RID: 14344
		[Token(Token = "0x4003808")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public float knockBackResist;

		// Token: 0x04003809 RID: 14345
		[Token(Token = "0x4003809")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public int oldDirectionY;

		// Token: 0x0400380A RID: 14346
		[Token(Token = "0x400380A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public int oldTarget;

		// Token: 0x0400380B RID: 14347
		[Token(Token = "0x400380B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public float rotation;

		// Token: 0x0400380C RID: 14348
		[Token(Token = "0x400380C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public bool noGravity;

		// Token: 0x0400380D RID: 14349
		[Token(Token = "0x400380D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		public bool noTileCollide;

		// Token: 0x0400380E RID: 14350
		[Token(Token = "0x400380E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		public bool collideX;

		// Token: 0x0400380F RID: 14351
		[Token(Token = "0x400380F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1CB")]
		public bool collideY;

		// Token: 0x04003810 RID: 14352
		[Token(Token = "0x4003810")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public bool boss;

		// Token: 0x04003811 RID: 14353
		[Token(Token = "0x4003811")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public int spriteDirection;

		// Token: 0x04003812 RID: 14354
		[Token(Token = "0x4003812")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public bool behindTiles;

		// Token: 0x04003813 RID: 14355
		[Token(Token = "0x4003813")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D5")]
		public bool lavaImmune;

		// Token: 0x04003814 RID: 14356
		[Token(Token = "0x4003814")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public float value;

		// Token: 0x04003815 RID: 14357
		[Token(Token = "0x4003815")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public int extraValue;

		// Token: 0x04003816 RID: 14358
		[Token(Token = "0x4003816")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public bool dontTakeDamage;

		// Token: 0x04003817 RID: 14359
		[Token(Token = "0x4003817")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		public bool dontTakeDamageStillShowLife;

		// Token: 0x04003818 RID: 14360
		[Token(Token = "0x4003818")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private int catchableNPCTempImmunityCounter;

		// Token: 0x04003819 RID: 14361
		[Token(Token = "0x4003819")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public int netID;

		// Token: 0x0400381A RID: 14362
		[Token(Token = "0x400381A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		public int statsAreScaledForThisManyPlayers;

		// Token: 0x0400381B RID: 14363
		[Token(Token = "0x400381B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public float difficulty;

		// Token: 0x0400381C RID: 14364
		[Token(Token = "0x400381C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		public bool townNPC;

		// Token: 0x0400381D RID: 14365
		[Token(Token = "0x400381D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public ConditionalDialogue nextDialogue;

		// Token: 0x0400381E RID: 14366
		[Token(Token = "0x400381E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
		public bool homeless;

		// Token: 0x0400381F RID: 14367
		[Token(Token = "0x400381F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1FD")]
		public bool homelessDespawn;

		// Token: 0x04003820 RID: 14368
		[Token(Token = "0x4003820")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public int lookForHomeTimeout;

		// Token: 0x04003821 RID: 14369
		[Token(Token = "0x4003821")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public static readonly int KickOutLookForHomeTimeout;

		// Token: 0x04003822 RID: 14370
		[Token(Token = "0x4003822")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		public int homeTileX;

		// Token: 0x04003823 RID: 14371
		[Token(Token = "0x4003823")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public int homeTileY;

		// Token: 0x04003824 RID: 14372
		[Token(Token = "0x4003824")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		public int housingCategory;

		// Token: 0x04003825 RID: 14373
		[Token(Token = "0x4003825")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		public bool oldHomeless;

		// Token: 0x04003826 RID: 14374
		[Token(Token = "0x4003826")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		public int oldHomeTileX;

		// Token: 0x04003827 RID: 14375
		[Token(Token = "0x4003827")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public int oldHomeTileY;

		// Token: 0x04003828 RID: 14376
		[Token(Token = "0x4003828")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		public bool friendly;

		// Token: 0x04003829 RID: 14377
		[Token(Token = "0x4003829")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x21D")]
		public bool closeDoor;

		// Token: 0x0400382A RID: 14378
		[Token(Token = "0x400382A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		public int doorX;

		// Token: 0x0400382B RID: 14379
		[Token(Token = "0x400382B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		public int doorY;

		// Token: 0x0400382C RID: 14380
		[Token(Token = "0x400382C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		public int friendlyRegen;

		// Token: 0x0400382D RID: 14381
		[Token(Token = "0x400382D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		public int breath;

		// Token: 0x0400382E RID: 14382
		[Token(Token = "0x400382E")]
		public const int breathMax = 200;

		// Token: 0x0400382F RID: 14383
		[Token(Token = "0x400382F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		public int breathCounter;

		// Token: 0x04003830 RID: 14384
		[Token(Token = "0x4003830")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x234")]
		public bool reflectsProjectiles;

		// Token: 0x04003831 RID: 14385
		[Token(Token = "0x4003831")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public int lastPortalColorIndex;

		// Token: 0x04003832 RID: 14386
		[Token(Token = "0x4003832")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		public bool despawnEncouraged;

		// Token: 0x04003833 RID: 14387
		[Token(Token = "0x4003833")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private long GoodRestingTileCacheTileState;

		// Token: 0x04003834 RID: 14388
		[Token(Token = "0x4003834")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private bool GoodRestingTileCacheFound;

		// Token: 0x04003835 RID: 14389
		[Token(Token = "0x4003835")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private Point GoodRestingTileCacheOrigin;

		// Token: 0x04003836 RID: 14390
		[Token(Token = "0x4003836")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x254")]
		private Point GoodRestingTileCacheResult;

		// Token: 0x04003837 RID: 14391
		[Token(Token = "0x4003837")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public static readonly double CommonMasterBossLifeReduction;

		// Token: 0x04003838 RID: 14392
		[Token(Token = "0x4003838")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public static int mechQueen;

		// Token: 0x04003839 RID: 14393
		[Token(Token = "0x4003839")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public static int brainOfGravity;

		// Token: 0x0400383A RID: 14394
		[Token(Token = "0x400383A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static int kingSlimePointCacheSize;

		// Token: 0x0400383B RID: 14395
		[Token(Token = "0x400383B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private static int kingSlimePointCacheSizeMax;

		// Token: 0x0400383C RID: 14396
		[Token(Token = "0x400383C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static Point[] kingSlimePointCache;

		// Token: 0x0400383D RID: 14397
		[Token(Token = "0x400383D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public static bool empressRageMode;

		// Token: 0x0400383E RID: 14398
		[Token(Token = "0x400383E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public static List<int> ai112NPCs;

		// Token: 0x0400383F RID: 14399
		[Token(Token = "0x400383F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private static NPC.PlayerTreasureCache[] PlayerTreasureCaches;

		// Token: 0x04003840 RID: 14400
		[Token(Token = "0x4003840")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static Point[] _nearbyBooks;

		// Token: 0x04003841 RID: 14401
		[Token(Token = "0x4003841")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private static readonly int[] _deerclopsAttack1Frames;

		// Token: 0x04003842 RID: 14402
		[Token(Token = "0x4003842")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static readonly int[] _deerclopsAttack2Frames;

		// Token: 0x04003843 RID: 14403
		[Token(Token = "0x4003843")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private static readonly int[] _deerclopsAttack3Frames;

		// Token: 0x04003844 RID: 14404
		[Token(Token = "0x4003844")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static bool DelayNPCDeathSyncs;

		// Token: 0x04003845 RID: 14405
		[Token(Token = "0x4003845")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private static List<int> DelayedNPCSyncs;

		// Token: 0x04003846 RID: 14406
		[Token(Token = "0x4003846")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public static int[] MoonEventRequiredPointsPerWaveLookup;

		// Token: 0x04003847 RID: 14407
		[Token(Token = "0x4003847")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private static NPC.Spawner spawner;

		// Token: 0x04003848 RID: 14408
		[Token(Token = "0x4003848")]
		public const int SPAWN_SLOT_PROTECTION_TIME = 2;

		// Token: 0x04003849 RID: 14409
		[Token(Token = "0x4003849")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static NPC.PendingDamage _currentStrikePendingDamage;

		// Token: 0x0400384A RID: 14410
		[Token(Token = "0x400384A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		public static bool PreventJojaColaDialog;

		// Token: 0x0400384B RID: 14411
		[Token(Token = "0x400384B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public static int RerollDryadText;

		// Token: 0x02000484 RID: 1156
		[Token(Token = "0x2000484")]
		internal struct PlayerNetSyncState
		{
			// Token: 0x0400384C RID: 14412
			[Token(Token = "0x400384C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte skippedSyncs;

			// Token: 0x0400384D RID: 14413
			[Token(Token = "0x400384D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public byte streamCounter;
		}

		// Token: 0x02000485 RID: 1157
		[Token(Token = "0x2000485")]
		private class PendingDamage
		{
			// Token: 0x06002836 RID: 10294 RVA: 0x00013260 File Offset: 0x00011460
			[Token(Token = "0x6002836")]
			[Address(RVA = "0x15FEC58", Offset = "0x15FEC58", VA = "0x15FEC58")]
			public bool Matches(NPC n)
			{
				return default(bool);
			}

			// Token: 0x06002837 RID: 10295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002837")]
			[Address(RVA = "0x15FEC9C", Offset = "0x15FEC9C", VA = "0x15FEC9C")]
			public PendingDamage()
			{
			}

			// Token: 0x0400384E RID: 14414
			[Token(Token = "0x400384E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public short index;

			// Token: 0x0400384F RID: 14415
			[Token(Token = "0x400384F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public byte generation;

			// Token: 0x04003850 RID: 14416
			[Token(Token = "0x4003850")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int damage;

			// Token: 0x04003851 RID: 14417
			[Token(Token = "0x4003851")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool phaseChange;
		}

		// Token: 0x02000486 RID: 1158
		[Token(Token = "0x2000486")]
		public class PlayerTreasureCache
		{
			// Token: 0x06002838 RID: 10296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002838")]
			[Address(RVA = "0x15FECA4", Offset = "0x15FECA4", VA = "0x15FECA4")]
			public void Generate(Player player)
			{
			}

			// Token: 0x06002839 RID: 10297 RVA: 0x00013278 File Offset: 0x00011478
			[Token(Token = "0x6002839")]
			[Address(RVA = "0x15FF274", Offset = "0x15FF274", VA = "0x15FF274")]
			public bool GetFairyTreasureCoords(Vector2 position, out Point treasureCoords)
			{
				return default(bool);
			}

			// Token: 0x0600283A RID: 10298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600283A")]
			[Address(RVA = "0x15FF5C0", Offset = "0x15FF5C0", VA = "0x15FF5C0")]
			public PlayerTreasureCache()
			{
			}

			// Token: 0x04003852 RID: 14418
			[Token(Token = "0x4003852")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool generated;

			// Token: 0x04003853 RID: 14419
			[Token(Token = "0x4003853")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int numPoints;

			// Token: 0x04003854 RID: 14420
			[Token(Token = "0x4003854")]
			private const int DX = 80;

			// Token: 0x04003855 RID: 14421
			[Token(Token = "0x4003855")]
			private const int DY = 56;

			// Token: 0x04003856 RID: 14422
			[Token(Token = "0x4003856")]
			private const int XSize = 160;

			// Token: 0x04003857 RID: 14423
			[Token(Token = "0x4003857")]
			private const int YSize = 112;

			// Token: 0x04003858 RID: 14424
			[Token(Token = "0x4003858")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int originX;

			// Token: 0x04003859 RID: 14425
			[Token(Token = "0x4003859")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int originY;

			// Token: 0x0400385A RID: 14426
			[Token(Token = "0x400385A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public short[] CalculatedScore;

			// Token: 0x0400385B RID: 14427
			[Token(Token = "0x400385B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public short[] PartitionScore;
		}

		// Token: 0x02000487 RID: 1159
		[Token(Token = "0x2000487")]
		public struct DOTTally
		{
			// Token: 0x0600283B RID: 10299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600283B")]
			[Address(RVA = "0x15FF634", Offset = "0x15FF634", VA = "0x15FF634")]
			public void AddSuperNaturalRegeneration(int amount)
			{
			}

			// Token: 0x0600283C RID: 10300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600283C")]
			[Address(RVA = "0x15FF644", Offset = "0x15FF644", VA = "0x15FF644")]
			public void Add(int regenLoss, int expectedAmountPerSecond = 0)
			{
			}

			// Token: 0x0600283D RID: 10301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600283D")]
			[Address(RVA = "0x15FF66C", Offset = "0x15FF66C", VA = "0x15FF66C")]
			public void AddPoison(int regenLoss, int expectedAmountPerSecond = 0)
			{
			}

			// Token: 0x0600283E RID: 10302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600283E")]
			[Address(RVA = "0x15FF6F8", Offset = "0x15FF6F8", VA = "0x15FF6F8")]
			public void AddBloodLoss(int regenLoss, int expectedAmountPerSecond = 0)
			{
			}

			// Token: 0x0600283F RID: 10303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600283F")]
			[Address(RVA = "0x15FF750", Offset = "0x15FF750", VA = "0x15FF750")]
			public void AddFlamable(int regenLoss, int expectedAmountPerSecond = 0)
			{
			}

			// Token: 0x06002840 RID: 10304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002840")]
			[Address(RVA = "0x15FF814", Offset = "0x15FF814", VA = "0x15FF814")]
			public void AddStackedProjecitle(short projTypeToLookFor, int damagePerSecond, int expectedDamagePerSecondDivider)
			{
			}

			// Token: 0x06002841 RID: 10305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002841")]
			[Address(RVA = "0x15FF6C4", Offset = "0x15FF6C4", VA = "0x15FF6C4")]
			private void SupportAcceleration(int regenLoss)
			{
			}

			// Token: 0x17000588 RID: 1416
			// (get) Token: 0x06002842 RID: 10306 RVA: 0x00013290 File Offset: 0x00011490
			[Token(Token = "0x17000588")]
			public static NPC.DOTTally None
			{
				[Token(Token = "0x6002842")]
				[Address(RVA = "0x15FFC30", Offset = "0x15FFC30", VA = "0x15FFC30")]
				get
				{
					return default(NPC.DOTTally);
				}
			}

			// Token: 0x0400385C RID: 14428
			[Token(Token = "0x400385C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NPC npc;

			// Token: 0x0400385D RID: 14429
			[Token(Token = "0x400385D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int LifeRegenLoss;

			// Token: 0x0400385E RID: 14430
			[Token(Token = "0x400385E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int LifeRegenLossThatCanBeBoosted;

			// Token: 0x0400385F RID: 14431
			[Token(Token = "0x400385F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int ExpectedDamagePerSecond;

			// Token: 0x04003860 RID: 14432
			[Token(Token = "0x4003860")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool BlockNaturalRegeneration;

			// Token: 0x04003861 RID: 14433
			[Token(Token = "0x4003861")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int SuperNaturalLifeRegen;
		}

		// Token: 0x02000488 RID: 1160
		[Token(Token = "0x2000488")]
		public class Spawner
		{
			// Token: 0x06002843 RID: 10307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002843")]
			[Address(RVA = "0x15FFC4C", Offset = "0x15FFC4C", VA = "0x15FFC4C")]
			public Spawner()
			{
			}

			// Token: 0x06002844 RID: 10308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002844")]
			[Address(RVA = "0x15FFC5C", Offset = "0x15FFC5C", VA = "0x15FFC5C")]
			public void SpawnNPC()
			{
			}

			// Token: 0x06002845 RID: 10309 RVA: 0x000132A8 File Offset: 0x000114A8
			[Token(Token = "0x6002845")]
			[Address(RVA = "0x1600910", Offset = "0x1600910", VA = "0x1600910")]
			private bool TrySpawnAnNPC(Player player)
			{
				return default(bool);
			}

			// Token: 0x06002846 RID: 10310 RVA: 0x000132C0 File Offset: 0x000114C0
			[Token(Token = "0x6002846")]
			[Address(RVA = "0x15FFF94", Offset = "0x15FFF94", VA = "0x15FFF94")]
			public static bool CanSpawnEnemiesNear(Player player)
			{
				return default(bool);
			}

			// Token: 0x06002847 RID: 10311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002847")]
			[Address(RVA = "0x1600C68", Offset = "0x1600C68", VA = "0x1600C68")]
			private void SetSpawnFlags(Player player)
			{
			}

			// Token: 0x06002848 RID: 10312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002848")]
			[Address(RVA = "0x16079C8", Offset = "0x16079C8", VA = "0x16079C8")]
			private void SetSpawnFlagsForChosenTile_ForDualDungeon(int spawnTileX, int groundTileY)
			{
			}

			// Token: 0x06002849 RID: 10313 RVA: 0x000132D8 File Offset: 0x000114D8
			[Token(Token = "0x6002849")]
			[Address(RVA = "0x16075E0", Offset = "0x16075E0", VA = "0x16075E0")]
			public static bool ShouldSpawnInvasionEnemies(Vector2 position)
			{
				return default(bool);
			}

			// Token: 0x0600284A RID: 10314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600284A")]
			[Address(RVA = "0x16016D0", Offset = "0x16016D0", VA = "0x16016D0")]
			private void GetSpawnRate(Player player, out int spawnRate, out int maxSpawns)
			{
			}

			// Token: 0x0600284B RID: 10315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600284B")]
			[Address(RVA = "0x1607A78", Offset = "0x1607A78", VA = "0x1607A78")]
			public static void GetSpawnArea(Player player, out Rectangle spawnArea, out Rectangle safeArea)
			{
			}

			// Token: 0x0600284C RID: 10316 RVA: 0x000132F0 File Offset: 0x000114F0
			[Token(Token = "0x600284C")]
			[Address(RVA = "0x1603CA0", Offset = "0x1603CA0", VA = "0x1603CA0")]
			public bool FindSpawnTile(Player player, out int spawnTileX, out int spawnTileY, out bool xRange)
			{
				return default(bool);
			}

			// Token: 0x0600284D RID: 10317 RVA: 0x00013308 File Offset: 0x00011508
			[Token(Token = "0x600284D")]
			[Address(RVA = "0x1604BF4", Offset = "0x1604BF4", VA = "0x1604BF4")]
			public static int GetSpawnWallType(int spawnTileX, int spawnTileY)
			{
				return 0;
			}

			// Token: 0x0600284E RID: 10318 RVA: 0x00013320 File Offset: 0x00011520
			[Token(Token = "0x600284E")]
			[Address(RVA = "0x1604E5C", Offset = "0x1604E5C", VA = "0x1604E5C")]
			private bool PostCheckChosenSpawnTile(int spawnTileX, int spawnTileY, int tileType, int wallType)
			{
				return default(bool);
			}

			// Token: 0x0600284F RID: 10319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600284F")]
			[Address(RVA = "0x1605558", Offset = "0x1605558", VA = "0x1605558")]
			public void SetSpawnFlagsForChosenTile(int spawnTileX, int spawnTileY, int groundTileY, int tileType, int wallType)
			{
			}

			// Token: 0x06002850 RID: 10320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002850")]
			[Address(RVA = "0x1454E18", Offset = "0x1454E18", VA = "0x1454E18")]
			public void SpawnAnNPC(int spawnTileX, int spawnTileY, int tileType, int wallType, bool xRange, int target)
			{
			}

			// Token: 0x06002851 RID: 10321 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002851")]
			[Address(RVA = "0x1608288", Offset = "0x1608288", VA = "0x1608288")]
			public NPC SpawnNPC(int X, int Y, int Type, int Start = 0, float ai0 = 0f, float ai1 = 0f, float ai2 = 0f, float ai3 = 0f, int Target = 255)
			{
				return null;
			}

			// Token: 0x06002852 RID: 10322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002852")]
			[Address(RVA = "0x16074BC", Offset = "0x16074BC", VA = "0x16074BC")]
			private static void SyncNewlySpawnedNPCs()
			{
			}

			// Token: 0x06002853 RID: 10323 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002853")]
			[Address(RVA = "0x16085B4", Offset = "0x16085B4", VA = "0x16085B4")]
			public NPC SpawnHornet(int spawnTileX, int spawnTileY)
			{
				return null;
			}

			// Token: 0x06002854 RID: 10324 RVA: 0x00013338 File Offset: 0x00011538
			[Token(Token = "0x6002854")]
			[Address(RVA = "0x16085A8", Offset = "0x16085A8", VA = "0x16085A8")]
			public int RollLuck(int range)
			{
				return 0;
			}

			// Token: 0x06002855 RID: 10325 RVA: 0x00013350 File Offset: 0x00011550
			[Token(Token = "0x6002855")]
			[Address(RVA = "0x1608C18", Offset = "0x1608C18", VA = "0x1608C18")]
			public int RollBadLuck(int range)
			{
				return 0;
			}

			// Token: 0x06002856 RID: 10326 RVA: 0x00013368 File Offset: 0x00011568
			[Token(Token = "0x6002856")]
			[Address(RVA = "0x1608C24", Offset = "0x1608C24", VA = "0x1608C24")]
			public int RollOnlyBadLuck(int range)
			{
				return 0;
			}

			// Token: 0x06002857 RID: 10327 RVA: 0x00013380 File Offset: 0x00011580
			[Token(Token = "0x6002857")]
			[Address(RVA = "0x1608C30", Offset = "0x1608C30", VA = "0x1608C30")]
			public int RollBadLuckExtreme(int range)
			{
				return 0;
			}

			// Token: 0x06002858 RID: 10328 RVA: 0x00013398 File Offset: 0x00011598
			[Token(Token = "0x6002858")]
			[Address(RVA = "0x1607A6C", Offset = "0x1607A6C", VA = "0x1607A6C")]
			public int RollOnlyBadLuckExtreme(int range)
			{
				return 0;
			}

			// Token: 0x06002859 RID: 10329 RVA: 0x000133B0 File Offset: 0x000115B0
			[Token(Token = "0x6002859")]
			[Address(RVA = "0x1608C3C", Offset = "0x1608C3C", VA = "0x1608C3C")]
			private static int GetGnomeChance()
			{
				return 0;
			}

			// Token: 0x0600285A RID: 10330 RVA: 0x000133C8 File Offset: 0x000115C8
			[Token(Token = "0x600285A")]
			[Address(RVA = "0x160811C", Offset = "0x160811C", VA = "0x160811C")]
			public static bool HasTileSpawnSpace(int spawnTileX, int spawnTileY)
			{
				return default(bool);
			}

			// Token: 0x0600285B RID: 10331 RVA: 0x000133E0 File Offset: 0x000115E0
			[Token(Token = "0x600285B")]
			[Address(RVA = "0x1608D70", Offset = "0x1608D70", VA = "0x1608D70")]
			public static bool CanSpawnInTiles(Rectangle tileRect)
			{
				return default(bool);
			}

			// Token: 0x0600285C RID: 10332 RVA: 0x000133F8 File Offset: 0x000115F8
			[Token(Token = "0x600285C")]
			[Address(RVA = "0x1608EB0", Offset = "0x1608EB0", VA = "0x1608EB0")]
			public static bool CanSpawnInTile(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x0600285D RID: 10333 RVA: 0x00013410 File Offset: 0x00011610
			[Token(Token = "0x600285D")]
			[Address(RVA = "0x16045DC", Offset = "0x16045DC", VA = "0x16045DC")]
			public static bool CheckNotSpawningOnScreen(int spawnTileX, int spawnTileY)
			{
				return default(bool);
			}

			// Token: 0x0600285E RID: 10334 RVA: 0x00013428 File Offset: 0x00011628
			[Token(Token = "0x600285E")]
			[Address(RVA = "0x1609100", Offset = "0x1609100", VA = "0x1609100")]
			public static bool Spawning_SandstoneCheck(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x0600285F RID: 10335 RVA: 0x00013440 File Offset: 0x00011640
			[Token(Token = "0x600285F")]
			[Address(RVA = "0x16097C4", Offset = "0x16097C4", VA = "0x16097C4")]
			public static bool Spawning_FlyingAntlionCheck(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x06002860 RID: 10336 RVA: 0x00013458 File Offset: 0x00011658
			[Token(Token = "0x6002860")]
			[Address(RVA = "0x1609AFC", Offset = "0x1609AFC", VA = "0x1609AFC")]
			private static int RollDragonflyType(int tileType = 2)
			{
				return 0;
			}

			// Token: 0x06002861 RID: 10337 RVA: 0x00013470 File Offset: 0x00011670
			[Token(Token = "0x6002861")]
			[Address(RVA = "0x1609C40", Offset = "0x1609C40", VA = "0x1609C40")]
			public static bool SpawnTileOrAboveHasAnyWallInSet(int x, int y, bool[] wallTypes)
			{
				return default(bool);
			}

			// Token: 0x06002862 RID: 10338 RVA: 0x00013488 File Offset: 0x00011688
			[Token(Token = "0x6002862")]
			[Address(RVA = "0x160A060", Offset = "0x160A060", VA = "0x160A060")]
			private static int SharkSpawnChance(int x, int y)
			{
				return 0;
			}

			// Token: 0x06002863 RID: 10339 RVA: 0x000134A0 File Offset: 0x000116A0
			[Token(Token = "0x6002863")]
			[Address(RVA = "0x160A3E0", Offset = "0x160A3E0", VA = "0x160A3E0")]
			private static bool CanSpawnDevourer(int X)
			{
				return default(bool);
			}

			// Token: 0x06002864 RID: 10340 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002864")]
			[Address(RVA = "0x160A57C", Offset = "0x160A57C", VA = "0x160A57C")]
			public void GetZombieSettings(out int zombieStyle, out bool spawnArmedZombies, out int torchZombieChance, out int maggotZombieChance)
			{
			}

			// Token: 0x06002865 RID: 10341 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002865")]
			[Address(RVA = "0x160A7E8", Offset = "0x160A7E8", VA = "0x160A7E8")]
			public void SpawnFrog(int spawnTileX, int spawnTileY)
			{
			}

			// Token: 0x06002866 RID: 10342 RVA: 0x000134B8 File Offset: 0x000116B8
			[Token(Token = "0x6002866")]
			[Address(RVA = "0x160A930", Offset = "0x160A930", VA = "0x160A930")]
			public static int GetBasicSlimeToSpawn(bool surface, int tileType, int spawnDist)
			{
				return 0;
			}

			// Token: 0x06002867 RID: 10343 RVA: 0x000134D0 File Offset: 0x000116D0
			[Token(Token = "0x6002867")]
			[Address(RVA = "0x160AC58", Offset = "0x160AC58", VA = "0x160AC58")]
			public static bool GetBasicSlimeToSpawn_ChanceToBeHolidaySlime()
			{
				return default(bool);
			}

			// Token: 0x06002868 RID: 10344 RVA: 0x000134E8 File Offset: 0x000116E8
			[Token(Token = "0x6002868")]
			[Address(RVA = "0x160AD40", Offset = "0x160AD40", VA = "0x160AD40")]
			public static int GetGemBunnyToSpawn()
			{
				return 0;
			}

			// Token: 0x06002869 RID: 10345 RVA: 0x00013500 File Offset: 0x00011700
			[Token(Token = "0x6002869")]
			[Address(RVA = "0x160AE0C", Offset = "0x160AE0C", VA = "0x160AE0C")]
			public static int GetGemSquirrelToSpawn()
			{
				return 0;
			}

			// Token: 0x0600286A RID: 10346 RVA: 0x00013518 File Offset: 0x00011718
			[Token(Token = "0x600286A")]
			[Address(RVA = "0x160AED8", Offset = "0x160AED8", VA = "0x160AED8")]
			private bool CheckToSpawnUndergroundGnomes(int spawnTileX, int spawnTileY, bool isAValidZoneAndTile, int gnomeChance)
			{
				return default(bool);
			}

			// Token: 0x0600286B RID: 10347 RVA: 0x00013530 File Offset: 0x00011730
			[Token(Token = "0x600286B")]
			[Address(RVA = "0x160B298", Offset = "0x160B298", VA = "0x160B298")]
			private static bool CheckToSpawnSpider(int spawnTileX, int spawnTileY)
			{
				return default(bool);
			}

			// Token: 0x0600286C RID: 10348 RVA: 0x00013548 File Offset: 0x00011748
			[Token(Token = "0x600286C")]
			[Address(RVA = "0x160B3BC", Offset = "0x160B3BC", VA = "0x160B3BC")]
			private bool CheckToSpawnRockGolem(int spawnTileX, int spawnTileY, int spawnTileType)
			{
				return default(bool);
			}

			// Token: 0x0600286D RID: 10349 RVA: 0x00013560 File Offset: 0x00011760
			[Token(Token = "0x600286D")]
			[Address(RVA = "0x160B59C", Offset = "0x160B59C", VA = "0x160B59C")]
			private bool CheckToSpawnUndergroundFairy(int spawnTileX, int spawnTileY)
			{
				return default(bool);
			}

			// Token: 0x0600286E RID: 10350 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600286E")]
			[Address(RVA = "0x160B7A0", Offset = "0x160B7A0", VA = "0x160B7A0")]
			private NPC SpawnLavaBaitCritters(int spawnTileX, int spawnTileY)
			{
				return null;
			}

			// Token: 0x0600286F RID: 10351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600286F")]
			[Address(RVA = "0x16048C4", Offset = "0x16048C4", VA = "0x16048C4")]
			public static void FindGroundTile(int x, int y, out int groundTileY)
			{
			}

			// Token: 0x06002870 RID: 10352 RVA: 0x00013578 File Offset: 0x00011778
			[Token(Token = "0x6002870")]
			[Address(RVA = "0x160BBB0", Offset = "0x160BBB0", VA = "0x160BBB0")]
			public static bool IsValidSpawningGroundTile(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x06002871 RID: 10353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002871")]
			[Address(RVA = "0x1600198", Offset = "0x1600198", VA = "0x1600198")]
			public static void SlimeRainSpawns(Player player)
			{
			}

			// Token: 0x06002872 RID: 10354 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002872")]
			[Address(RVA = "0x160BC20", Offset = "0x160BC20", VA = "0x160BC20")]
			public static void SpawnFaelings(Player player)
			{
			}

			// Token: 0x04003862 RID: 14434
			[Token(Token = "0x4003862")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static int spawnSpaceX;

			// Token: 0x04003863 RID: 14435
			[Token(Token = "0x4003863")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static int spawnSpaceY;

			// Token: 0x04003864 RID: 14436
			[Token(Token = "0x4003864")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static bool fairyLog;

			// Token: 0x04003865 RID: 14437
			[Token(Token = "0x4003865")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int numberOfActivePlayers;

			// Token: 0x04003866 RID: 14438
			[Token(Token = "0x4003866")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool reachedInvasionBossCap;

			// Token: 0x04003867 RID: 14439
			[Token(Token = "0x4003867")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int pX;

			// Token: 0x04003868 RID: 14440
			[Token(Token = "0x4003868")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int pY;

			// Token: 0x04003869 RID: 14441
			[Token(Token = "0x4003869")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float luck;

			// Token: 0x0400386A RID: 14442
			[Token(Token = "0x400386A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool dayTime;

			// Token: 0x0400386B RID: 14443
			[Token(Token = "0x400386B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
			public bool raining;

			// Token: 0x0400386C RID: 14444
			[Token(Token = "0x400386C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int townNPCs;

			// Token: 0x0400386D RID: 14445
			[Token(Token = "0x400386D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool skyMob;

			// Token: 0x0400386E RID: 14446
			[Token(Token = "0x400386E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			public bool noWorms;

			// Token: 0x0400386F RID: 14447
			[Token(Token = "0x400386F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x26")]
			public bool noGroundWorms;

			// Token: 0x04003870 RID: 14448
			[Token(Token = "0x4003870")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x27")]
			public bool invaders;

			// Token: 0x04003871 RID: 14449
			[Token(Token = "0x4003871")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool spawnFriendly;

			// Token: 0x04003872 RID: 14450
			[Token(Token = "0x4003872")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			public bool ignoreSafeWalls;

			// Token: 0x04003873 RID: 14451
			[Token(Token = "0x4003873")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
			public bool waterTile;

			// Token: 0x04003874 RID: 14452
			[Token(Token = "0x4003874")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
			public bool nearGranite;

			// Token: 0x04003875 RID: 14453
			[Token(Token = "0x4003875")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool nearMarble;

			// Token: 0x04003876 RID: 14454
			[Token(Token = "0x4003876")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
			public bool spawnSpider;

			// Token: 0x04003877 RID: 14455
			[Token(Token = "0x4003877")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
			public bool surfaceSpawn;

			// Token: 0x04003878 RID: 14456
			[Token(Token = "0x4003878")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
			public bool spawnUndergroundDesert;

			// Token: 0x04003879 RID: 14457
			[Token(Token = "0x4003879")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool hardDungeon;

			// Token: 0x0400387A RID: 14458
			[Token(Token = "0x400387A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool deeperThanRockLayer;

			// Token: 0x0400387B RID: 14459
			[Token(Token = "0x400387B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x32")]
			public bool underGround;

			// Token: 0x0400387C RID: 14460
			[Token(Token = "0x400387C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x33")]
			public bool isOcean;

			// Token: 0x0400387D RID: 14461
			[Token(Token = "0x400387D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool isBeach;

			// Token: 0x0400387E RID: 14462
			[Token(Token = "0x400387E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x35")]
			public bool isSpawningInWindDirection;

			// Token: 0x0400387F RID: 14463
			[Token(Token = "0x400387F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x36")]
			public bool skyBehindPlayer;

			// Token: 0x04003880 RID: 14464
			[Token(Token = "0x4003880")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x37")]
			public bool livingTree;

			// Token: 0x04003881 RID: 14465
			[Token(Token = "0x4003881")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool dualDungeonsSpawnRules;

			// Token: 0x04003882 RID: 14466
			[Token(Token = "0x4003882")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			public bool inDualDungeon;

			// Token: 0x04003883 RID: 14467
			[Token(Token = "0x4003883")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
			public bool tresspassingDualDungeon;

			// Token: 0x04003884 RID: 14468
			[Token(Token = "0x4003884")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
			public bool inRemixStartingArea;

			// Token: 0x04003885 RID: 14469
			[Token(Token = "0x4003885")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool offensiveToTim;

			// Token: 0x04003886 RID: 14470
			[Token(Token = "0x4003886")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool playerHasStartingHealth;

			// Token: 0x04003887 RID: 14471
			[Token(Token = "0x4003887")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
			public bool ZoneCorrupt;

			// Token: 0x04003888 RID: 14472
			[Token(Token = "0x4003888")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
			public bool ZoneCrimson;

			// Token: 0x04003889 RID: 14473
			[Token(Token = "0x4003889")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool ZoneHallow;

			// Token: 0x0400388A RID: 14474
			[Token(Token = "0x400388A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x41")]
			public bool ZoneJungle;

			// Token: 0x0400388B RID: 14475
			[Token(Token = "0x400388B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x42")]
			public bool ZoneSnow;

			// Token: 0x0400388C RID: 14476
			[Token(Token = "0x400388C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x43")]
			public bool ZoneGlowshroom;

			// Token: 0x0400388D RID: 14477
			[Token(Token = "0x400388D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool ZoneMeteor;

			// Token: 0x0400388E RID: 14478
			[Token(Token = "0x400388E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x45")]
			public bool ZoneGraveyard;

			// Token: 0x0400388F RID: 14479
			[Token(Token = "0x400388F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x46")]
			public bool ZoneDungeon;

			// Token: 0x04003890 RID: 14480
			[Token(Token = "0x4003890")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x47")]
			public bool ZoneLihzhardTemple;

			// Token: 0x04003891 RID: 14481
			[Token(Token = "0x4003891")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool ZoneGranite;

			// Token: 0x04003892 RID: 14482
			[Token(Token = "0x4003892")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool ZoneMarble;

			// Token: 0x04003893 RID: 14483
			[Token(Token = "0x4003893")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
			public bool ZoneSandstorm;

			// Token: 0x04003894 RID: 14484
			[Token(Token = "0x4003894")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
			public bool ZoneTowerSolar;

			// Token: 0x04003895 RID: 14485
			[Token(Token = "0x4003895")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool ZoneTowerVortex;

			// Token: 0x04003896 RID: 14486
			[Token(Token = "0x4003896")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool ZoneTowerNebula;

			// Token: 0x04003897 RID: 14487
			[Token(Token = "0x4003897")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
			public bool ZoneTowerStardust;

			// Token: 0x04003898 RID: 14488
			[Token(Token = "0x4003898")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
			public bool ZoneOldOneArmy;

			// Token: 0x04003899 RID: 14489
			[Token(Token = "0x4003899")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool ZoneWaterCandle;

			// Token: 0x0400389A RID: 14490
			[Token(Token = "0x400389A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x51")]
			public bool ZonePeaceCandle;

			// Token: 0x0400389B RID: 14491
			[Token(Token = "0x400389B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x52")]
			public bool ZoneShadowCandle;

			// Token: 0x0400389C RID: 14492
			[Token(Token = "0x400389C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public int defaultTarget;
		}
	}
}
