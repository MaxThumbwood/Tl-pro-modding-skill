using System;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Items;
using Terraria.UI;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x02000469 RID: 1129
	[Token(Token = "0x2000469")]
	public class Item : FileAPI
	{
		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D1")]
		public string Name
		{
			[Token(Token = "0x6001F51")]
			[Address(RVA = "0xF142C4", Offset = "0xF142C4", VA = "0xF142C4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001F52 RID: 8018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D2")]
		public string HoverName
		{
			[Token(Token = "0x6001F52")]
			[Address(RVA = "0xF1433C", Offset = "0xF1433C", VA = "0xF1433C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F53")]
		[Address(RVA = "0xF14600", Offset = "0xF14600", VA = "0xF14600")]
		public static string GetHoverName(Item item, int stack)
		{
			return null;
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F54")]
		[Address(RVA = "0xF146C4", Offset = "0xF146C4", VA = "0xF146C4")]
		public static void StartCachingType(int t)
		{
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F55")]
		[Address(RVA = "0xF14780", Offset = "0xF14780", VA = "0xF14780")]
		public static void DropCache(IEntitySource reason, Vector2 pos, Vector2 spread, int t, bool stopCaching = true)
		{
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F56")]
		[Address(RVA = "0xF15964", Offset = "0xF15964", VA = "0xF15964")]
		public IEntitySource GetNPCSource_FromThis()
		{
			return null;
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F57")]
		[Address(RVA = "0xF159D8", Offset = "0xF159D8", VA = "0xF159D8")]
		public IEntitySource GetItemSource_Misc(int itemSourceId)
		{
			return null;
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001F58 RID: 8024 RVA: 0x0000F018 File Offset: 0x0000D218
		[Token(Token = "0x170003D3")]
		public bool PaintOrCoating
		{
			[Token(Token = "0x6001F58")]
			[Address(RVA = "0xF15A54", Offset = "0xF15A54", VA = "0xF15A54")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x0000F030 File Offset: 0x0000D230
		[Token(Token = "0x170003D4")]
		public int OriginalRarity
		{
			[Token(Token = "0x6001F59")]
			[Address(RVA = "0xF15A78", Offset = "0xF15A78", VA = "0xF15A78")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001F5A RID: 8026 RVA: 0x0000F048 File Offset: 0x0000D248
		[Token(Token = "0x170003D5")]
		public int OriginalDamage
		{
			[Token(Token = "0x6001F5A")]
			[Address(RVA = "0xF15B38", Offset = "0xF15B38", VA = "0xF15B38")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x0000F060 File Offset: 0x0000D260
		[Token(Token = "0x170003D6")]
		public int OriginalDefense
		{
			[Token(Token = "0x6001F5B")]
			[Address(RVA = "0xF15BF8", Offset = "0xF15BF8", VA = "0xF15BF8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001F5C RID: 8028 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F5D RID: 8029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D7")]
		public ItemVariant Variant
		{
			[Token(Token = "0x6001F5C")]
			[Address(RVA = "0xF15CB8", Offset = "0xF15CB8", VA = "0xF15CB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F5D")]
			[Address(RVA = "0xF15CC0", Offset = "0xF15CC0", VA = "0xF15CC0")]
			private set
			{
			}
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5E")]
		[Address(RVA = "0xF15CC8", Offset = "0xF15CC8", VA = "0xF15CC8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x0000F078 File Offset: 0x0000D278
		[Token(Token = "0x6001F5F")]
		[Address(RVA = "0xF15DEC", Offset = "0xF15DEC", VA = "0xF15DEC")]
		public bool CanHavePrefixes()
		{
			return default(bool);
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x0000F090 File Offset: 0x0000D290
		[Token(Token = "0x6001F60")]
		[Address(RVA = "0xF1624C", Offset = "0xF1624C", VA = "0xF1624C")]
		public bool Prefix(int prefixWeWant)
		{
			return default(bool);
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		[Token(Token = "0x6001F61")]
		[Address(RVA = "0xF16270", Offset = "0xF16270", VA = "0xF16270")]
		public bool Prefix(int prefixWeWant, out bool rolledPrefixIsTopTier)
		{
			return default(bool);
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
		[Token(Token = "0x6001F62")]
		[Address(RVA = "0xF17C6C", Offset = "0xF17C6C", VA = "0xF17C6C")]
		public bool CanRollPrefix(int prefix)
		{
			return default(bool);
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x0000F0D8 File Offset: 0x0000D2D8
		[Token(Token = "0x6001F63")]
		[Address(RVA = "0xF17CC4", Offset = "0xF17CC4", VA = "0xF17CC4")]
		public int GetVisualCritChance(Player player)
		{
			return 0;
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
		[Token(Token = "0x6001F64")]
		[Address(RVA = "0xF17D44", Offset = "0xF17D44", VA = "0xF17D44")]
		public Color GetPopupRarityColor()
		{
			return default(Color);
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x0000F108 File Offset: 0x0000D308
		[Token(Token = "0x6001F65")]
		[Address(RVA = "0xF17DAC", Offset = "0xF17DAC", VA = "0xF17DAC")]
		public static Color GetPopupRarityColor(int itemRarity)
		{
			return default(Color);
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x0000F120 File Offset: 0x0000D320
		[Token(Token = "0x6001F66")]
		[Address(RVA = "0xF16DEC", Offset = "0xF16DEC", VA = "0xF16DEC")]
		public bool TryGetPrefixStatMultipliersForItem(int rolledPrefix, out float dmg, out float kb, out float spd, out float size, out float shtspd, out float mcst, out int crt, out int tagdmg, out int arpen, out float value)
		{
			return default(bool);
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x0000F138 File Offset: 0x0000D338
		[Token(Token = "0x6001F67")]
		[Address(RVA = "0xF16C2C", Offset = "0xF16C2C", VA = "0xF16C2C")]
		public float BestPrefixValue()
		{
			return 0f;
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F68")]
		[Address(RVA = "0xF15E00", Offset = "0xF15E00", VA = "0xF15E00")]
		public int[] GetRollablePrefixes()
		{
			return null;
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x0000F150 File Offset: 0x0000D350
		[Token(Token = "0x6001F69")]
		[Address(RVA = "0xF16D98", Offset = "0xF16D98", VA = "0xF16D98")]
		public bool RollAPrefix(UnifiedRandom random, ref int rolledPrefix)
		{
			return default(bool);
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x0000F168 File Offset: 0x0000D368
		[Token(Token = "0x6001F6A")]
		[Address(RVA = "0xF17FE4", Offset = "0xF17FE4", VA = "0xF17FE4")]
		public bool IsAPrefixableAccessory()
		{
			return default(bool);
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x0000F180 File Offset: 0x0000D380
		[Token(Token = "0x6001F6B")]
		[Address(RVA = "0xF18088", Offset = "0xF18088", VA = "0xF18088")]
		public bool CanBeEquipped()
		{
			return default(bool);
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x0000F198 File Offset: 0x0000D398
		[Token(Token = "0x6001F6C")]
		[Address(RVA = "0xF18208", Offset = "0xF18208", VA = "0xF18208")]
		public bool OnlyNeedOneInInventory()
		{
			return default(bool);
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F6D")]
		[Address(RVA = "0xF143F4", Offset = "0xF143F4", VA = "0xF143F4")]
		public string AffixName()
		{
			return null;
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6E")]
		[Address(RVA = "0xF18310", Offset = "0xF18310", VA = "0xF18310")]
		public void RebuildTooltip()
		{
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6F")]
		[Address(RVA = "0xF18388", Offset = "0xF18388", VA = "0xF18388")]
		public void netDefaults(int type)
		{
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		[Token(Token = "0x6001F70")]
		[Address(RVA = "0xF183B8", Offset = "0xF183B8", VA = "0xF183B8")]
		public bool FitsAmmoSlot()
		{
			return default(bool);
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x0000F1C8 File Offset: 0x0000D3C8
		[Token(Token = "0x6001F71")]
		[Address(RVA = "0xF18428", Offset = "0xF18428", VA = "0xF18428")]
		public bool CanFillEmptyAmmoSlot()
		{
			return default(bool);
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F72")]
		[Address(RVA = "0xEB6E08", Offset = "0xEB6E08", VA = "0xEB6E08")]
		private void SetDefaults1(int type)
		{
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F73")]
		[Address(RVA = "0xEC9A3C", Offset = "0xEC9A3C", VA = "0xEC9A3C")]
		private void SetDefaults2(int type)
		{
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F74")]
		[Address(RVA = "0xED8340", Offset = "0xED8340", VA = "0xED8340")]
		private void SetDefaults3(int type)
		{
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F75")]
		[Address(RVA = "0xF184D8", Offset = "0xF184D8", VA = "0xF184D8")]
		public void DefaultToQuestFish()
		{
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F76")]
		[Address(RVA = "0xEE2870", Offset = "0xEE2870", VA = "0xEE2870")]
		private void SetDefaults4(int type)
		{
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F77")]
		[Address(RVA = "0xF184F8", Offset = "0xF184F8", VA = "0xF184F8")]
		public void DefaultToGolfBall(int projid)
		{
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F78")]
		[Address(RVA = "0xEF1860", Offset = "0xEF1860", VA = "0xEF1860")]
		private void SetDefaults5(int type)
		{
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F79")]
		[Address(RVA = "0xF18628", Offset = "0xF18628", VA = "0xF18628")]
		public void DefaultToBanner(int tileStyleToPlace = 0)
		{
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7A")]
		[Address(RVA = "0xF186B0", Offset = "0xF186B0", VA = "0xF186B0")]
		public void DefaultToMonolith(int tileIDToPlace, int tileStyleToPlace = 0)
		{
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7B")]
		[Address(RVA = "0xF1873C", Offset = "0xF1873C", VA = "0xF1873C")]
		public void DefaultToBomb(int projectileID, float throwSpeed)
		{
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7C")]
		[Address(RVA = "0xF187F0", Offset = "0xF187F0", VA = "0xF187F0")]
		public void DefaultToVoiceOverrideAccessory(sbyte voiceOverrideID)
		{
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7D")]
		[Address(RVA = "0xF18830", Offset = "0xF18830", VA = "0xF18830")]
		public void DefaultToSolution(int projectileId)
		{
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7E")]
		[Address(RVA = "0xF18900", Offset = "0xF18900", VA = "0xF18900")]
		public void DefaultToWhip(int projectileId, int dmg, float kb, float shootspeed, int animationTotalTime = 30)
		{
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7F")]
		[Address(RVA = "0xF189CC", Offset = "0xF189CC", VA = "0xF189CC")]
		public void DefaultToKite(int projId)
		{
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F80")]
		[Address(RVA = "0xF18AB8", Offset = "0xF18AB8", VA = "0xF18AB8")]
		public void ChangeItemType(int to)
		{
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
		[Token(Token = "0x6001F81")]
		[Address(RVA = "0xF18B00", Offset = "0xF18B00", VA = "0xF18B00")]
		public bool IsConsideredSameItemAsType(int compareType)
		{
			return default(bool);
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F82")]
		[Address(RVA = "0xF18D44", Offset = "0xF18D44", VA = "0xF18D44")]
		public void DefaultToVanitypet(int projId, int buffID)
		{
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		[Token(Token = "0x170003D8")]
		public bool IsACoin
		{
			[Token(Token = "0x6001F83")]
			[Address(RVA = "0xF18E5C", Offset = "0xF18E5C", VA = "0xF18E5C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x0000F210 File Offset: 0x0000D410
		[Token(Token = "0x6001F84")]
		[Address(RVA = "0xF18E74", Offset = "0xF18E74", VA = "0xF18E74")]
		public static bool IsAGolfingItem(Item item)
		{
			return default(bool);
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F85")]
		[Address(RVA = "0xF18F40", Offset = "0xF18F40", VA = "0xF18F40")]
		private void DefaultToSeaShell()
		{
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F86")]
		[Address(RVA = "0xF1907C", Offset = "0xF1907C", VA = "0xF1907C")]
		public void DefaultToCapturedCritter(short npcIdToSpawnOnUse)
		{
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F87")]
		[Address(RVA = "0xF190C0", Offset = "0xF190C0", VA = "0xF190C0")]
		public void DefaultToStaff(int projType, float pushForwardSpeed, int singleShotTime, int manaPerShot)
		{
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F88")]
		[Address(RVA = "0xF191B0", Offset = "0xF191B0", VA = "0xF191B0")]
		public void DefaultToSpear(int projType, float pushForwardSpeed, int animationTime)
		{
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F89")]
		[Address(RVA = "0xF19270", Offset = "0xF19270", VA = "0xF19270")]
		private void SetFoodDefaults(int type)
		{
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F8A")]
		[Address(RVA = "0xF1C354", Offset = "0xF1C354", VA = "0xF1C354")]
		public void DefaultToMinecart(int mount)
		{
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F8B")]
		[Address(RVA = "0xF1C36C", Offset = "0xF1C36C", VA = "0xF1C36C")]
		public void DefaultToPlaceableWall(ushort wallToPlace)
		{
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F8C")]
		[Address(RVA = "0xF1C3A4", Offset = "0xF1C3A4", VA = "0xF1C3A4")]
		public void SetWeaponValues(int dmg, float knockback, int bonusCritChance = 0)
		{
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F8D")]
		[Address(RVA = "0xF1C3B4", Offset = "0xF1C3B4", VA = "0xF1C3B4")]
		public void DefaultToBow(int singleShotTime, float shotVelocity, bool hasAutoReuse = false)
		{
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F8E")]
		[Address(RVA = "0xF1917C", Offset = "0xF1917C", VA = "0xF1917C")]
		public void DefaultToMagicWeapon(int projType, int singleShotTime, float shotVelocity, bool hasAutoReuse = false)
		{
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F8F")]
		[Address(RVA = "0xF1C4B0", Offset = "0xF1C4B0", VA = "0xF1C4B0")]
		public void DefaultToRangedWeapon(int baseProjType, int ammoID, int singleShotTime, float shotVelocity, bool hasAutoReuse = false)
		{
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F90")]
		[Address(RVA = "0xF18A84", Offset = "0xF18A84", VA = "0xF18A84")]
		public void DefaultToThrownWeapon(int baseProjType, int singleShotTime, float shotVelocity, bool hasAutoReuse = false)
		{
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F91")]
		[Address(RVA = "0xF1C4EC", Offset = "0xF1C4EC", VA = "0xF1C4EC")]
		private void DefaultToTorch(int tileStyleToPlace, bool allowWaterPlacement = false)
		{
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F92")]
		[Address(RVA = "0xF186FC", Offset = "0xF186FC", VA = "0xF186FC")]
		public void DefaultToPlaceableTile(int tileIDToPlace, int tileStyleToPlace = 0)
		{
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F93")]
		[Address(RVA = "0xF18674", Offset = "0xF18674", VA = "0xF18674")]
		public void DefaultToPlaceableTile(ushort tileIDToPlace, int tileStyleToPlace = 0)
		{
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F94")]
		[Address(RVA = "0xF1C540", Offset = "0xF1C540", VA = "0xF1C540")]
		public void MakeUsableWithChlorophyteExtractinator()
		{
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F95")]
		[Address(RVA = "0xF1C568", Offset = "0xF1C568", VA = "0xF1C568")]
		public void DefaultToGolfClub(int newwidth, int newheight)
		{
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F96")]
		[Address(RVA = "0xF1C5B0", Offset = "0xF1C5B0", VA = "0xF1C5B0")]
		public void DefaultToLawnMower(int newwidth, int newheight)
		{
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F97")]
		[Address(RVA = "0xF1C168", Offset = "0xF1C168", VA = "0xF1C168")]
		public void DefaultToFood(int newwidth, int newheight, int foodbuff, int foodbuffduration, bool useGulpSound = false, int animationTime = 17)
		{
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F98")]
		[Address(RVA = "0xF1C270", Offset = "0xF1C270", VA = "0xF1C270")]
		public void DefaultToHealingPotion(int newwidth, int newheight, int healingAmount, int animationTime = 17)
		{
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F99")]
		[Address(RVA = "0xF1861C", Offset = "0xF1861C", VA = "0xF1861C")]
		public void SetShopValues(ItemRarityColor rarity, int coinValue)
		{
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F9A")]
		[Address(RVA = "0xF1C64C", Offset = "0xF1C64C", VA = "0xF1C64C")]
		public void DefaultToHeadgear(int newwidth, int newheight, int helmetArtID)
		{
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F9B")]
		[Address(RVA = "0xF1C65C", Offset = "0xF1C65C", VA = "0xF1C65C")]
		public void DefaultToBody(int newwidth, int newheight, int bodySlotID)
		{
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F9C")]
		[Address(RVA = "0xF1C66C", Offset = "0xF1C66C", VA = "0xF1C66C")]
		public void DefaultToLegs(int newwidth, int newheight, int legSlotID)
		{
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F9D")]
		[Address(RVA = "0xF1C67C", Offset = "0xF1C67C", VA = "0xF1C67C")]
		public void DefaultToAccessory(int newwidth = 24, int newheight = 24)
		{
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F9E")]
		[Address(RVA = "0xF1C690", Offset = "0xF1C690", VA = "0xF1C690")]
		public void DefaultToInfoAccessory(int newwidth = 24, int newheight = 24)
		{
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F9F")]
		[Address(RVA = "0xF1C6A8", Offset = "0xF1C6A8", VA = "0xF1C6A8")]
		public void DefaultToGuitar(int newwidth = 24, int newheight = 24)
		{
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA0")]
		[Address(RVA = "0xF1C6D0", Offset = "0xF1C6D0", VA = "0xF1C6D0")]
		public void DefaultToMusicBox(int style)
		{
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA1")]
		[Address(RVA = "0xF14AF0", Offset = "0xF14AF0", VA = "0xF14AF0")]
		public Item()
		{
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA2")]
		[Address(RVA = "0xF1C730", Offset = "0xF1C730", VA = "0xF1C730")]
		public Item(int Type, [Optional] ItemVariant variant)
		{
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA3")]
		[Address(RVA = "0xF14BB8", Offset = "0xF14BB8", VA = "0xF14BB8")]
		public void SetDefaults(int Type, [Optional] ItemVariant variant)
		{
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA4")]
		[Address(RVA = "0xF1CA50", Offset = "0xF1CA50", VA = "0xF1CA50")]
		private void DebugTrySettingManaCost(int itemType, int manaToSet)
		{
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA5")]
		[Address(RVA = "0xF1CA60", Offset = "0xF1CA60", VA = "0xF1CA60")]
		public void OnCreated(ItemCreationContext context)
		{
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA6")]
		[Address(RVA = "0xF1C80C", Offset = "0xF1C80C", VA = "0xF1C80C")]
		public void ResetStats(int Type)
		{
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x0000F228 File Offset: 0x0000D428
		[Token(Token = "0x6001FA7")]
		[Address(RVA = "0xF1CA7C", Offset = "0xF1CA7C", VA = "0xF1CA7C")]
		public static Color GetPhaseColor(int projectileType, bool drawColor = false)
		{
			return default(Color);
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x0000F240 File Offset: 0x0000D440
		[Token(Token = "0x6001FA8")]
		[Address(RVA = "0xF1D074", Offset = "0xF1D074", VA = "0xF1D074")]
		private static Color GetPhaseColorDirect(int projectileType)
		{
			return default(Color);
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x0000F258 File Offset: 0x0000D458
		[Token(Token = "0x6001FA9")]
		[Address(RVA = "0xF1D10C", Offset = "0xF1D10C", VA = "0xF1D10C")]
		public Color GetAlphaFaded(Color newColor)
		{
			return default(Color);
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x0000F270 File Offset: 0x0000D470
		[Token(Token = "0x6001FAA")]
		[Address(RVA = "0xF1D1DC", Offset = "0xF1D1DC", VA = "0xF1D1DC")]
		public Color GetAlpha(Color newColor)
		{
			return default(Color);
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x0000F288 File Offset: 0x0000D488
		[Token(Token = "0x6001FAB")]
		[Address(RVA = "0xF1DC10", Offset = "0xF1DC10", VA = "0xF1DC10")]
		public Color GetColor(Color newColor)
		{
			return default(Color);
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		[Token(Token = "0x6001FAC")]
		[Address(RVA = "0xF1DCA8", Offset = "0xF1DCA8", VA = "0xF1DCA8")]
		public static bool MechSpawn(float x, float y, int type)
		{
			return default(bool);
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		[Token(Token = "0x6001FAD")]
		[Address(RVA = "0xF185F8", Offset = "0xF185F8", VA = "0xF185F8")]
		public static int buyPrice(int platinum = 0, int gold = 0, int silver = 0, int copper = 0)
		{
			return 0;
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		[Token(Token = "0x6001FAE")]
		[Address(RVA = "0xF18E34", Offset = "0xF18E34", VA = "0xF18E34")]
		public static int sellPrice(int platinum = 0, int gold = 0, int silver = 0, int copper = 0)
		{
			return 0;
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		[Token(Token = "0x6001FAF")]
		[Address(RVA = "0xF1DEBC", Offset = "0xF1DEBC", VA = "0xF1DEBC")]
		public static int GetRandomVoiceItem()
		{
			return 0;
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x0000F300 File Offset: 0x0000D500
		[Token(Token = "0x6001FB0")]
		[Address(RVA = "0xF1DFAC", Offset = "0xF1DFAC", VA = "0xF1DFAC")]
		public bool CanShimmer()
		{
			return default(bool);
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x0000F318 File Offset: 0x0000D518
		[Token(Token = "0x6001FB1")]
		[Address(RVA = "0xF1E28C", Offset = "0xF1E28C", VA = "0xF1E28C")]
		public int FindDecraftAmount()
		{
			return 0;
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x0000F330 File Offset: 0x0000D530
		[Token(Token = "0x6001FB2")]
		[Address(RVA = "0xF1E140", Offset = "0xF1E140", VA = "0xF1E140")]
		public int GetShimmerEquivalentType(bool forDecrafting = false)
		{
			return 0;
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB3")]
		[Address(RVA = "0xF1E35C", Offset = "0xF1E35C", VA = "0xF1E35C")]
		public void FixAgainstExploit()
		{
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FB4")]
		[Address(RVA = "0xF1E5A8", Offset = "0xF1E5A8", VA = "0xF1E5A8")]
		public FlexibleTileWand GetFlexibleTileWand()
		{
			return null;
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x0000F348 File Offset: 0x0000D548
		[Token(Token = "0x6001FB5")]
		[Address(RVA = "0xF1ED70", Offset = "0xF1ED70", VA = "0xF1ED70")]
		public bool TryAddStack(int itemType, ref int amountLeftToAdd)
		{
			return default(bool);
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x0000F360 File Offset: 0x0000D560
		[Token(Token = "0x6001FB6")]
		[Address(RVA = "0xF1EEF8", Offset = "0xF1EEF8", VA = "0xF1EEF8")]
		public bool CanPassivelyStackInWorld()
		{
			return default(bool);
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x0000F378 File Offset: 0x0000D578
		[Token(Token = "0x6001FB7")]
		[Address(RVA = "0xF1F05C", Offset = "0xF1F05C", VA = "0xF1F05C")]
		public static Rectangle GetDrawHitbox(int type, Player user)
		{
			return default(Rectangle);
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FB8")]
		[Address(RVA = "0xF1F5A4", Offset = "0xF1F5A4", VA = "0xF1F5A4")]
		public static IDisposable DefaultAssignNewItemsToPlayer(int plr)
		{
			return null;
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x0000F390 File Offset: 0x0000D590
		[Token(Token = "0x6001FB9")]
		[Address(RVA = "0xF1F618", Offset = "0xF1F618", VA = "0xF1F618")]
		public static int NewItem(int X, int Y, int Width, int Height, int Type, int Stack = 1, bool noBroadcast = false, int pfix = 0, NewItemOwnership ownership = NewItemOwnership.None)
		{
			return 0;
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBA")]
		[Address(RVA = "0xF1F74C", Offset = "0xF1F74C", VA = "0xF1F74C")]
		public static void RequestNewItem(IEntitySource source, Vector2 center, int type, int stack = 1, int prefix = 0, NewItemOwnership ownership = NewItemOwnership.None, [Optional] Vector2? velocity, [Optional] Item.NewItemModifier modifier)
		{
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
		[Token(Token = "0x6001FBB")]
		[Address(RVA = "0xF15864", Offset = "0xF15864", VA = "0xF15864")]
		public static int NewItem(IEntitySource source, int X, int Y, int Width, int Height, int type, int stack = 1, bool noBroadcast = false, int prefix = 0, NewItemOwnership ownership = NewItemOwnership.None, [Optional] Vector2? velocity, [Optional] Item.NewItemModifier modifier)
		{
			return 0;
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		[Token(Token = "0x6001FBC")]
		[Address(RVA = "0xF1F8C4", Offset = "0xF1F8C4", VA = "0xF1F8C4")]
		public static int NewItem(IEntitySource source, Vector2 center, int type, int stack = 1, int prefix = 0, NewItemOwnership ownership = NewItemOwnership.None, [Optional] Vector2? velocity, [Optional] Item.NewItemModifier modifier, bool noBroadcast = false)
		{
			return 0;
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		[Token(Token = "0x6001FBD")]
		[Address(RVA = "0xF20604", Offset = "0xF20604", VA = "0xF20604")]
		private static int PickAnItemSlotToSpawnItemOn()
		{
			return 0;
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FBE")]
		[Address(RVA = "0xF20AA4", Offset = "0xF20AA4", VA = "0xF20AA4")]
		public Item Clone()
		{
			return null;
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FBF")]
		[Address(RVA = "0xF20B38", Offset = "0xF20B38", VA = "0xF20B38")]
		public Item clientClone(Item cloneDestination)
		{
			return null;
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC0")]
		[Address(RVA = "0xF20D40", Offset = "0xF20D40", VA = "0xF20D40")]
		public Item DeepClone()
		{
			return null;
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		[Token(Token = "0x6001FC1")]
		[Address(RVA = "0xF20DD4", Offset = "0xF20DD4", VA = "0xF20DD4")]
		public bool IsNotTheSameAs(Item compareItem)
		{
			return default(bool);
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x0000F408 File Offset: 0x0000D608
		[Token(Token = "0x6001FC2")]
		[Address(RVA = "0xF20E24", Offset = "0xF20E24", VA = "0xF20E24")]
		public bool IsNetStateDifferent(Item compareItem)
		{
			return default(bool);
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x0000F420 File Offset: 0x0000D620
		[Token(Token = "0x6001FC3")]
		[Address(RVA = "0xF20E84", Offset = "0xF20E84", VA = "0xF20E84")]
		public static bool CanStack(Item item1, Item item2)
		{
			return default(bool);
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x0000F438 File Offset: 0x0000D638
		[Token(Token = "0x6001FC4")]
		[Address(RVA = "0xF20ED4", Offset = "0xF20ED4", VA = "0xF20ED4")]
		public static bool CanStack(ref ChestItem item1, ref ChestItem item2)
		{
			return default(bool);
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x0000F450 File Offset: 0x0000D650
		[Token(Token = "0x6001FC5")]
		[Address(RVA = "0xF20F04", Offset = "0xF20F04", VA = "0xF20F04")]
		public static bool CanStack(Item item1, ref ChestItem item2)
		{
			return default(bool);
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC6")]
		[Address(RVA = "0xF20F48", Offset = "0xF20F48", VA = "0xF20F48")]
		public void SetNameOverride(string name)
		{
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC7")]
		[Address(RVA = "0xF20F50", Offset = "0xF20F50", VA = "0xF20F50")]
		public void ClearNameOverride()
		{
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x0000F468 File Offset: 0x0000D668
		[Token(Token = "0x170003D9")]
		public bool IsAir
		{
			[Token(Token = "0x6001FC8")]
			[Address(RVA = "0xF1EED4", Offset = "0xF1EED4", VA = "0xF1EED4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC9")]
		[Address(RVA = "0xF1CA2C", Offset = "0xF1CA2C", VA = "0xF1CA2C")]
		public void TurnToAir()
		{
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCA")]
		[Address(RVA = "0xF20F5C", Offset = "0xF20F5C", VA = "0xF20F5C")]
		public void OnPurchase(Item item)
		{
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x0000F480 File Offset: 0x0000D680
		[Token(Token = "0x6001FCB")]
		[Address(RVA = "0xF20FC4", Offset = "0xF20FC4", VA = "0xF20FC4")]
		public int GetStoreValue()
		{
			return 0;
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCC")]
		[Address(RVA = "0xF2103C", Offset = "0xF2103C", VA = "0xF2103C")]
		public void Serialize(BinaryWriter writer, bool writeFavorite = false)
		{
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCD")]
		[Address(RVA = "0xF210EC", Offset = "0xF210EC", VA = "0xF210EC")]
		public void DeserializeFrom(BinaryReader reader, bool readFavorite = false)
		{
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x0000F498 File Offset: 0x0000D698
		[Token(Token = "0x170003DA")]
		public bool IsCurrency
		{
			[Token(Token = "0x6001FCE")]
			[Address(RVA = "0xF211EC", Offset = "0xF211EC", VA = "0xF211EC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCF")]
		[Address(RVA = "0xF1E500", Offset = "0xF1E500", VA = "0xF1E500")]
		public void ResetPrefix()
		{
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD0")]
		[Address(RVA = "0xF2126C", Offset = "0xF2126C", VA = "0xF2126C")]
		public void Refresh(bool onlyIfVariantChanged = true)
		{
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		[Token(Token = "0x170003DB")]
		public bool CanBeQuickUsed
		{
			[Token(Token = "0x6001FD1")]
			[Address(RVA = "0xF21350", Offset = "0xF21350", VA = "0xF21350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040031E7 RID: 12775
		[Token(Token = "0x40031E7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int numberOfNewItems;

		// Token: 0x040031E8 RID: 12776
		[Token(Token = "0x40031E8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int width;

		// Token: 0x040031E9 RID: 12777
		[Token(Token = "0x40031E9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int height;

		// Token: 0x040031EA RID: 12778
		[Token(Token = "0x40031EA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int coinGrabRange;

		// Token: 0x040031EB RID: 12779
		[Token(Token = "0x40031EB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int manaGrabRange;

		// Token: 0x040031EC RID: 12780
		[Token(Token = "0x40031EC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static int lifeGrabRange;

		// Token: 0x040031ED RID: 12781
		[Token(Token = "0x40031ED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static int treasureGrabRange;

		// Token: 0x040031EE RID: 12782
		[Token(Token = "0x40031EE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string _nameOverride;

		// Token: 0x040031EF RID: 12783
		[Token(Token = "0x40031EF")]
		public const int luckPotionDuration1 = 18000;

		// Token: 0x040031F0 RID: 12784
		[Token(Token = "0x40031F0")]
		public const int luckPotionDuration2 = 36000;

		// Token: 0x040031F1 RID: 12785
		[Token(Token = "0x40031F1")]
		public const int luckPotionDuration3 = 54000;

		// Token: 0x040031F2 RID: 12786
		[Token(Token = "0x40031F2")]
		public const int flaskTime = 72000;

		// Token: 0x040031F3 RID: 12787
		[Token(Token = "0x40031F3")]
		public const int copper = 1;

		// Token: 0x040031F4 RID: 12788
		[Token(Token = "0x40031F4")]
		public const int silver = 100;

		// Token: 0x040031F5 RID: 12789
		[Token(Token = "0x40031F5")]
		public const int gold = 10000;

		// Token: 0x040031F6 RID: 12790
		[Token(Token = "0x40031F6")]
		public const int platinum = 1000000;

		// Token: 0x040031F7 RID: 12791
		[Token(Token = "0x40031F7")]
		public const int goldCritterRarityColor = 3;

		// Token: 0x040031F8 RID: 12792
		[Token(Token = "0x40031F8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int shadowOrbPrice;

		// Token: 0x040031F9 RID: 12793
		[Token(Token = "0x40031F9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int dungeonPrice;

		// Token: 0x040031FA RID: 12794
		[Token(Token = "0x40031FA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly int queenBeePrice;

		// Token: 0x040031FB RID: 12795
		[Token(Token = "0x40031FB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int hellPrice;

		// Token: 0x040031FC RID: 12796
		[Token(Token = "0x40031FC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly int eclipsePrice;

		// Token: 0x040031FD RID: 12797
		[Token(Token = "0x40031FD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int eclipsePostPlanteraPrice;

		// Token: 0x040031FE RID: 12798
		[Token(Token = "0x40031FE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static readonly int eclipseMothronPrice;

		// Token: 0x040031FF RID: 12799
		[Token(Token = "0x40031FF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static int CommonMaxStack;

		// Token: 0x04003200 RID: 12800
		[Token(Token = "0x4003200")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static int[] cachedItemSpawnsByType;

		// Token: 0x04003201 RID: 12801
		[Token(Token = "0x4003201")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static int potionDelay;

		// Token: 0x04003202 RID: 12802
		[Token(Token = "0x4003202")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static int restorationDelay;

		// Token: 0x04003203 RID: 12803
		[Token(Token = "0x4003203")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static int eggnogDelay;

		// Token: 0x04003204 RID: 12804
		[Token(Token = "0x4003204")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static int mushroomDelay;

		// Token: 0x04003205 RID: 12805
		[Token(Token = "0x4003205")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool questItem;

		// Token: 0x04003206 RID: 12806
		[Token(Token = "0x4003206")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static int[] headType;

		// Token: 0x04003207 RID: 12807
		[Token(Token = "0x4003207")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static int[] bodyType;

		// Token: 0x04003208 RID: 12808
		[Token(Token = "0x4003208")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static int[] legType;

		// Token: 0x04003209 RID: 12809
		[Token(Token = "0x4003209")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static bool[] staff;

		// Token: 0x0400320A RID: 12810
		[Token(Token = "0x400320A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static bool[] claw;

		// Token: 0x0400320B RID: 12811
		[Token(Token = "0x400320B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool flame;

		// Token: 0x0400320C RID: 12812
		[Token(Token = "0x400320C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public bool mech;

		// Token: 0x0400320D RID: 12813
		[Token(Token = "0x400320D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int tileWand;

		// Token: 0x0400320E RID: 12814
		[Token(Token = "0x400320E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool wornArmor;

		// Token: 0x0400320F RID: 12815
		[Token(Token = "0x400320F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int tooltipContext;

		// Token: 0x04003210 RID: 12816
		[Token(Token = "0x4003210")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int tooltipSlot;

		// Token: 0x04003211 RID: 12817
		[Token(Token = "0x4003211")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public byte dye;

		// Token: 0x04003212 RID: 12818
		[Token(Token = "0x4003212")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int fishingPole;

		// Token: 0x04003213 RID: 12819
		[Token(Token = "0x4003213")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int bait;

		// Token: 0x04003214 RID: 12820
		[Token(Token = "0x4003214")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public short makeNPC;

		// Token: 0x04003215 RID: 12821
		[Token(Token = "0x4003215")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		public bool expertOnly;

		// Token: 0x04003216 RID: 12822
		[Token(Token = "0x4003216")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool expert;

		// Token: 0x04003217 RID: 12823
		[Token(Token = "0x4003217")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool isAShopItem;

		// Token: 0x04003218 RID: 12824
		[Token(Token = "0x4003218")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public short hairDye;

		// Token: 0x04003219 RID: 12825
		[Token(Token = "0x4003219")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public byte paint;

		// Token: 0x0400321A RID: 12826
		[Token(Token = "0x400321A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public byte paintCoating;

		// Token: 0x0400321B RID: 12827
		[Token(Token = "0x400321B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int type;

		// Token: 0x0400321C RID: 12828
		[Token(Token = "0x400321C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool favorited;

		// Token: 0x0400321D RID: 12829
		[Token(Token = "0x400321D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		public byte holdStyle;

		// Token: 0x0400321E RID: 12830
		[Token(Token = "0x400321E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		public byte useStyle;

		// Token: 0x0400321F RID: 12831
		[Token(Token = "0x400321F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		public bool channel;

		// Token: 0x04003220 RID: 12832
		[Token(Token = "0x4003220")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool accessory;

		// Token: 0x04003221 RID: 12833
		[Token(Token = "0x4003221")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int useAnimation;

		// Token: 0x04003222 RID: 12834
		[Token(Token = "0x4003222")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int useTime;

		// Token: 0x04003223 RID: 12835
		[Token(Token = "0x4003223")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int stack;

		// Token: 0x04003224 RID: 12836
		[Token(Token = "0x4003224")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int maxStack;

		// Token: 0x04003225 RID: 12837
		[Token(Token = "0x4003225")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int pick;

		// Token: 0x04003226 RID: 12838
		[Token(Token = "0x4003226")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int axe;

		// Token: 0x04003227 RID: 12839
		[Token(Token = "0x4003227")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int hammer;

		// Token: 0x04003228 RID: 12840
		[Token(Token = "0x4003228")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int tileBoost;

		// Token: 0x04003229 RID: 12841
		[Token(Token = "0x4003229")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int createTile;

		// Token: 0x0400322A RID: 12842
		[Token(Token = "0x400322A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int createWall;

		// Token: 0x0400322B RID: 12843
		[Token(Token = "0x400322B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int placeStyle;

		// Token: 0x0400322C RID: 12844
		[Token(Token = "0x400322C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int damage;

		// Token: 0x0400322D RID: 12845
		[Token(Token = "0x400322D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float knockBack;

		// Token: 0x0400322E RID: 12846
		[Token(Token = "0x400322E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int healLife;

		// Token: 0x0400322F RID: 12847
		[Token(Token = "0x400322F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public int healMana;

		// Token: 0x04003230 RID: 12848
		[Token(Token = "0x4003230")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool potion;

		// Token: 0x04003231 RID: 12849
		[Token(Token = "0x4003231")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool consumable;

		// Token: 0x04003232 RID: 12850
		[Token(Token = "0x4003232")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public bool autoReuse;

		// Token: 0x04003233 RID: 12851
		[Token(Token = "0x4003233")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		public bool useTurn;

		// Token: 0x04003234 RID: 12852
		[Token(Token = "0x4003234")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public Color color;

		// Token: 0x04003235 RID: 12853
		[Token(Token = "0x4003235")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int alpha;

		// Token: 0x04003236 RID: 12854
		[Token(Token = "0x4003236")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public short glowMask;

		// Token: 0x04003237 RID: 12855
		[Token(Token = "0x4003237")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float scale;

		// Token: 0x04003238 RID: 12856
		[Token(Token = "0x4003238")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public LegacySoundStyle UseSound;

		// Token: 0x04003239 RID: 12857
		[Token(Token = "0x4003239")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float useSoundPitch;

		// Token: 0x0400323A RID: 12858
		[Token(Token = "0x400323A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int defense;

		// Token: 0x0400323B RID: 12859
		[Token(Token = "0x400323B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int headSlot;

		// Token: 0x0400323C RID: 12860
		[Token(Token = "0x400323C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public int bodySlot;

		// Token: 0x0400323D RID: 12861
		[Token(Token = "0x400323D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int legSlot;

		// Token: 0x0400323E RID: 12862
		[Token(Token = "0x400323E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public sbyte handOnSlot;

		// Token: 0x0400323F RID: 12863
		[Token(Token = "0x400323F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public sbyte handOffSlot;

		// Token: 0x04003240 RID: 12864
		[Token(Token = "0x4003240")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB6")]
		public sbyte backSlot;

		// Token: 0x04003241 RID: 12865
		[Token(Token = "0x4003241")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB7")]
		public sbyte frontSlot;

		// Token: 0x04003242 RID: 12866
		[Token(Token = "0x4003242")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public sbyte shoeSlot;

		// Token: 0x04003243 RID: 12867
		[Token(Token = "0x4003243")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		public sbyte waistSlot;

		// Token: 0x04003244 RID: 12868
		[Token(Token = "0x4003244")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		public sbyte wingSlot;

		// Token: 0x04003245 RID: 12869
		[Token(Token = "0x4003245")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBB")]
		public sbyte shieldSlot;

		// Token: 0x04003246 RID: 12870
		[Token(Token = "0x4003246")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public sbyte neckSlot;

		// Token: 0x04003247 RID: 12871
		[Token(Token = "0x4003247")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public sbyte faceSlot;

		// Token: 0x04003248 RID: 12872
		[Token(Token = "0x4003248")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBE")]
		public sbyte balloonSlot;

		// Token: 0x04003249 RID: 12873
		[Token(Token = "0x4003249")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBF")]
		public sbyte beardSlot;

		// Token: 0x0400324A RID: 12874
		[Token(Token = "0x400324A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public sbyte voiceSlot;

		// Token: 0x0400324B RID: 12875
		[Token(Token = "0x400324B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public int stringColor;

		// Token: 0x0400324C RID: 12876
		[Token(Token = "0x400324C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public ItemTooltip ToolTip;

		// Token: 0x0400324D RID: 12877
		[Token(Token = "0x400324D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public string BestiaryNotes;

		// Token: 0x0400324E RID: 12878
		[Token(Token = "0x400324E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int rare;

		// Token: 0x0400324F RID: 12879
		[Token(Token = "0x400324F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private ItemVariant <Variant>k__BackingField;

		// Token: 0x04003250 RID: 12880
		[Token(Token = "0x4003250")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public int shoot;

		// Token: 0x04003251 RID: 12881
		[Token(Token = "0x4003251")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float shootSpeed;

		// Token: 0x04003252 RID: 12882
		[Token(Token = "0x4003252")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public int ammo;

		// Token: 0x04003253 RID: 12883
		[Token(Token = "0x4003253")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public bool notAmmo;

		// Token: 0x04003254 RID: 12884
		[Token(Token = "0x4003254")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public int useAmmo;

		// Token: 0x04003255 RID: 12885
		[Token(Token = "0x4003255")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public int lifeRegen;

		// Token: 0x04003256 RID: 12886
		[Token(Token = "0x4003256")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int manaIncrease;

		// Token: 0x04003257 RID: 12887
		[Token(Token = "0x4003257")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public bool buyOnce;

		// Token: 0x04003258 RID: 12888
		[Token(Token = "0x4003258")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public int mana;

		// Token: 0x04003259 RID: 12889
		[Token(Token = "0x4003259")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public bool noUseGraphic;

		// Token: 0x0400325A RID: 12890
		[Token(Token = "0x400325A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		public bool noMelee;

		// Token: 0x0400325B RID: 12891
		[Token(Token = "0x400325B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public int value;

		// Token: 0x0400325C RID: 12892
		[Token(Token = "0x400325C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public bool buy;

		// Token: 0x0400325D RID: 12893
		[Token(Token = "0x400325D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		public bool reforge;

		// Token: 0x0400325E RID: 12894
		[Token(Token = "0x400325E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x106")]
		public bool social;

		// Token: 0x0400325F RID: 12895
		[Token(Token = "0x400325F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x107")]
		public bool vanity;

		// Token: 0x04003260 RID: 12896
		[Token(Token = "0x4003260")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool material;

		// Token: 0x04003261 RID: 12897
		[Token(Token = "0x4003261")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		public bool noWet;

		// Token: 0x04003262 RID: 12898
		[Token(Token = "0x4003262")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public int buffType;

		// Token: 0x04003263 RID: 12899
		[Token(Token = "0x4003263")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int buffTime;

		// Token: 0x04003264 RID: 12900
		[Token(Token = "0x4003264")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public int mountType;

		// Token: 0x04003265 RID: 12901
		[Token(Token = "0x4003265")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public bool cartTrack;

		// Token: 0x04003266 RID: 12902
		[Token(Token = "0x4003266")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		public bool uniqueStack;

		// Token: 0x04003267 RID: 12903
		[Token(Token = "0x4003267")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public int shopSpecialCurrency;

		// Token: 0x04003268 RID: 12904
		[Token(Token = "0x4003268")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public int? shopCustomPrice;

		// Token: 0x04003269 RID: 12905
		[Token(Token = "0x4003269")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public bool shootsEveryUse;

		// Token: 0x0400326A RID: 12906
		[Token(Token = "0x400326A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		public bool chlorophyteExtractinatorConsumable;

		// Token: 0x0400326B RID: 12907
		[Token(Token = "0x400326B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
		public bool DD2Summon;

		// Token: 0x0400326C RID: 12908
		[Token(Token = "0x400326C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public int crit;

		// Token: 0x0400326D RID: 12909
		[Token(Token = "0x400326D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public int armorPenetration;

		// Token: 0x0400326E RID: 12910
		[Token(Token = "0x400326E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public int bonusTagDamage;

		// Token: 0x0400326F RID: 12911
		[Token(Token = "0x400326F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public byte prefix;

		// Token: 0x04003270 RID: 12912
		[Token(Token = "0x4003270")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x139")]
		public bool melee;

		// Token: 0x04003271 RID: 12913
		[Token(Token = "0x4003271")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13A")]
		public bool magic;

		// Token: 0x04003272 RID: 12914
		[Token(Token = "0x4003272")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13B")]
		public bool ranged;

		// Token: 0x04003273 RID: 12915
		[Token(Token = "0x4003273")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public bool summon;

		// Token: 0x04003274 RID: 12916
		[Token(Token = "0x4003274")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13D")]
		public bool sentry;

		// Token: 0x04003275 RID: 12917
		[Token(Token = "0x4003275")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public int reuseDelay;

		// Token: 0x04003276 RID: 12918
		[Token(Token = "0x4003276")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public bool newAndShiny;

		// Token: 0x04003277 RID: 12919
		[Token(Token = "0x4003277")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x145")]
		public bool hasVanityEffects;

		// Token: 0x04003278 RID: 12920
		[Token(Token = "0x4003278")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private string _affixName;

		// Token: 0x04003279 RID: 12921
		[Token(Token = "0x4003279")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private int _affixType;

		// Token: 0x0400327A RID: 12922
		[Token(Token = "0x400327A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private byte _affixPrefix;

		// Token: 0x0400327B RID: 12923
		[Token(Token = "0x400327B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private int _affixLang;

		// Token: 0x0400327C RID: 12924
		[Token(Token = "0x400327C")]
		private const int foodWidth = 22;

		// Token: 0x0400327D RID: 12925
		[Token(Token = "0x400327D")]
		private const int foodHeight = 22;

		// Token: 0x0400327E RID: 12926
		[Token(Token = "0x400327E")]
		public const int WALL_PLACEMENT_USETIME = 7;

		// Token: 0x0400327F RID: 12927
		[Token(Token = "0x400327F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private static Color[] _phaseColors;

		// Token: 0x04003280 RID: 12928
		[Token(Token = "0x4003280")]
		private static int? _DefaultAssignItemsToNewPlayer;

		// Token: 0x04003281 RID: 12929
		[Token(Token = "0x4003281")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly int PickupReplacementTime;

		// Token: 0x04003282 RID: 12930
		[Token(Token = "0x4003282")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static readonly int SlotsRemainingBeforeEmergencyStackingInMultiplayer;

		// Token: 0x0200046A RID: 1130
		[Token(Token = "0x200046A")]
		private class DefaultAssignNewItemsToPlayer_OverrideHandle : FileAPI
		{
			// Token: 0x06001FD3 RID: 8147 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001FD3")]
			[Address(RVA = "0x1204C58", Offset = "0x1204C58", VA = "0x1204C58")]
			public DefaultAssignNewItemsToPlayer_OverrideHandle(int plr)
			{
			}

			// Token: 0x06001FD4 RID: 8148 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001FD4")]
			[Address(RVA = "0x1204D28", Offset = "0x1204D28", VA = "0x1204D28", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x04003283 RID: 12931
			[Token(Token = "0x4003283")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly int? _prev;
		}

		// Token: 0x0200046B RID: 1131
		// (Invoke) Token: 0x06001FD6 RID: 8150
		[Token(Token = "0x200046B")]
		public delegate void NewItemModifier(WorldItem item);
	}
}
