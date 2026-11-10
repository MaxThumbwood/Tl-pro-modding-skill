using System;
using Il2CppDummyDll;

namespace Terraria.IO
{
	// Token: 0x02000677 RID: 1655
	[Token(Token = "0x2000677")]
	public static class ItemConversion_OldMobile
	{
		// Token: 0x06003FE6 RID: 16358 RVA: 0x0001F620 File Offset: 0x0001D820
		[Token(Token = "0x6003FE6")]
		[Address(RVA = "0x1E8B334", Offset = "0x1E8B334", VA = "0x1E8B334")]
		public static bool ModifyItem(ref short itemId, ref short itemStack, ref byte prefix, bool chestConversion = false)
		{
			return default(bool);
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FE7")]
		[Address(RVA = "0x1E8BE1C", Offset = "0x1E8BE1C", VA = "0x1E8BE1C")]
		private static void GetCoinItem(int coinValue, ref short itemId, ref short itemStack)
		{
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x0001F638 File Offset: 0x0001D838
		[Token(Token = "0x6003FE8")]
		[Address(RVA = "0x1E8BEEC", Offset = "0x1E8BEEC", VA = "0x1E8BEEC")]
		public static bool ModifyBodySlot(ref int slot)
		{
			return default(bool);
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x0001F650 File Offset: 0x0001D850
		[Token(Token = "0x6003FE9")]
		[Address(RVA = "0x1E8C95C", Offset = "0x1E8C95C", VA = "0x1E8C95C")]
		public static bool ModifyHeadSlot(ref int slot)
		{
			return default(bool);
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x0001F668 File Offset: 0x0001D868
		[Token(Token = "0x6003FEA")]
		[Address(RVA = "0x1E8DA74", Offset = "0x1E8DA74", VA = "0x1E8DA74")]
		public static bool ModifyLegSlot(ref int slot)
		{
			return default(bool);
		}

		// Token: 0x040049A0 RID: 18848
		[Token(Token = "0x40049A0")]
		[FieldOffset(Offset = "0x0")]
		public static int CompensatedCurrency;

		// Token: 0x02000678 RID: 1656
		[Token(Token = "0x2000678")]
		private enum ARMOR_BODY_SLOTS
		{
			// Token: 0x040049A2 RID: 18850
			[Token(Token = "0x40049A2")]
			COPPER_CHAINMAIL = 1,
			// Token: 0x040049A3 RID: 18851
			[Token(Token = "0x40049A3")]
			IRON_CHAINMAIL,
			// Token: 0x040049A4 RID: 18852
			[Token(Token = "0x40049A4")]
			SILVER_CHAINMAIL,
			// Token: 0x040049A5 RID: 18853
			[Token(Token = "0x40049A5")]
			GOLD_CHAINMAIL,
			// Token: 0x040049A6 RID: 18854
			[Token(Token = "0x40049A6")]
			SHADOW_SCALEMAIL,
			// Token: 0x040049A7 RID: 18855
			[Token(Token = "0x40049A7")]
			METEOR_SUIT,
			// Token: 0x040049A8 RID: 18856
			[Token(Token = "0x40049A8")]
			NECRO_BREASTPLATE,
			// Token: 0x040049A9 RID: 18857
			[Token(Token = "0x40049A9")]
			JUNGLE_SHIRT,
			// Token: 0x040049AA RID: 18858
			[Token(Token = "0x40049AA")]
			MOLTEN_BREASTPLATE,
			// Token: 0x040049AB RID: 18859
			[Token(Token = "0x40049AB")]
			TUXEDO_SHIRT,
			// Token: 0x040049AC RID: 18860
			[Token(Token = "0x40049AC")]
			PLUMBERS_SHIRT,
			// Token: 0x040049AD RID: 18861
			[Token(Token = "0x40049AD")]
			HEROS_SHIRT,
			// Token: 0x040049AE RID: 18862
			[Token(Token = "0x40049AE")]
			ARCHAEOLOGISTS_JACKET,
			// Token: 0x040049AF RID: 18863
			[Token(Token = "0x40049AF")]
			NINJA_SHIRT,
			// Token: 0x040049B0 RID: 18864
			[Token(Token = "0x40049B0")]
			ROBE,
			// Token: 0x040049B1 RID: 18865
			[Token(Token = "0x40049B1")]
			THE_DOCTORS_SHIRT,
			// Token: 0x040049B2 RID: 18866
			[Token(Token = "0x40049B2")]
			COBALT_BREASTPLATE,
			// Token: 0x040049B3 RID: 18867
			[Token(Token = "0x40049B3")]
			MYTHRIL_CHAINMAIL,
			// Token: 0x040049B4 RID: 18868
			[Token(Token = "0x40049B4")]
			ADAMANTITE_BREASTPLATE,
			// Token: 0x040049B5 RID: 18869
			[Token(Token = "0x40049B5")]
			MINING_SHIRT,
			// Token: 0x040049B6 RID: 18870
			[Token(Token = "0x40049B6")]
			WEREWOLF,
			// Token: 0x040049B7 RID: 18871
			[Token(Token = "0x40049B7")]
			MERMAN,
			// Token: 0x040049B8 RID: 18872
			[Token(Token = "0x40049B8")]
			CLOWN_SHIRT,
			// Token: 0x040049B9 RID: 18873
			[Token(Token = "0x40049B9")]
			HALLOWED_PLATE_MAIL,
			// Token: 0x040049BA RID: 18874
			[Token(Token = "0x40049BA")]
			SANTA_SHIRT,
			// Token: 0x040049BB RID: 18875
			[Token(Token = "0x40049BB")]
			REDS_BREASTPLATE,
			// Token: 0x040049BC RID: 18876
			[Token(Token = "0x40049BC")]
			FROST_BREASTPLATE,
			// Token: 0x040049BD RID: 18877
			[Token(Token = "0x40049BD")]
			TIN_CHAINMAIL,
			// Token: 0x040049BE RID: 18878
			[Token(Token = "0x40049BE")]
			LEAD_CHAINMAIL,
			// Token: 0x040049BF RID: 18879
			[Token(Token = "0x40049BF")]
			TUNGSTEN_CHAINMAIL,
			// Token: 0x040049C0 RID: 18880
			[Token(Token = "0x40049C0")]
			PLATINUM_CHAINMAIL,
			// Token: 0x040049C1 RID: 18881
			[Token(Token = "0x40049C1")]
			WOOD_BREASTPLATE,
			// Token: 0x040049C2 RID: 18882
			[Token(Token = "0x40049C2")]
			EBONWOOD_BREASTPLATE,
			// Token: 0x040049C3 RID: 18883
			[Token(Token = "0x40049C3")]
			RICH_MAHOGANY_BREASTPLATE,
			// Token: 0x040049C4 RID: 18884
			[Token(Token = "0x40049C4")]
			PEARLWOOD_BREASTPLATE,
			// Token: 0x040049C5 RID: 18885
			[Token(Token = "0x40049C5")]
			RUNE_ROBE,
			// Token: 0x040049C6 RID: 18886
			[Token(Token = "0x40049C6")]
			CRIMSON_SCALEMAIL,
			// Token: 0x040049C7 RID: 18887
			[Token(Token = "0x40049C7")]
			ESKIMO_COAT,
			// Token: 0x040049C8 RID: 18888
			[Token(Token = "0x40049C8")]
			STEAMPUNK_SHIRT,
			// Token: 0x040049C9 RID: 18889
			[Token(Token = "0x40049C9")]
			BEE_SHIRT,
			// Token: 0x040049CA RID: 18890
			[Token(Token = "0x40049CA")]
			PRINCESS_DRESS,
			// Token: 0x040049CB RID: 18891
			[Token(Token = "0x40049CB")]
			PHARAOHS_ROBE,
			// Token: 0x040049CC RID: 18892
			[Token(Token = "0x40049CC")]
			MUMMY_SHIRT,
			// Token: 0x040049CD RID: 18893
			[Token(Token = "0x40049CD")]
			COWBOY_JACKET,
			// Token: 0x040049CE RID: 18894
			[Token(Token = "0x40049CE")]
			PIRATE_SHIRT,
			// Token: 0x040049CF RID: 18895
			[Token(Token = "0x40049CF")]
			CACTUS_BREASTPLATE,
			// Token: 0x040049D0 RID: 18896
			[Token(Token = "0x40049D0")]
			SHADEWOOD_BREASTPLATE,
			// Token: 0x040049D1 RID: 18897
			[Token(Token = "0x40049D1")]
			ANCIENT_SHADOW_SCALEMAIL,
			// Token: 0x040049D2 RID: 18898
			[Token(Token = "0x40049D2")]
			ANCIENT_COBALT_BREASTPLATE,
			// Token: 0x040049D3 RID: 18899
			[Token(Token = "0x40049D3")]
			PINK_ESKIMO_COAT,
			// Token: 0x040049D4 RID: 18900
			[Token(Token = "0x40049D4")]
			CHLOROPHYTE_PLATE_MAIL,
			// Token: 0x040049D5 RID: 18901
			[Token(Token = "0x40049D5")]
			RAIN_COAT,
			// Token: 0x040049D6 RID: 18902
			[Token(Token = "0x40049D6")]
			TIKI_SHIRT,
			// Token: 0x040049D7 RID: 18903
			[Token(Token = "0x40049D7")]
			PALLADIUM_BREASTPLATE,
			// Token: 0x040049D8 RID: 18904
			[Token(Token = "0x40049D8")]
			ORICHALCUM_BREASTPLATE,
			// Token: 0x040049D9 RID: 18905
			[Token(Token = "0x40049D9")]
			TITANIUM_BREASTPLATE,
			// Token: 0x040049DA RID: 18906
			[Token(Token = "0x40049DA")]
			SAILOR_SHIRT,
			// Token: 0x040049DB RID: 18907
			[Token(Token = "0x40049DB")]
			AMETHYST_ROBE,
			// Token: 0x040049DC RID: 18908
			[Token(Token = "0x40049DC")]
			TOPAZ_ROBE,
			// Token: 0x040049DD RID: 18909
			[Token(Token = "0x40049DD")]
			SAPPHIRE_ROBE,
			// Token: 0x040049DE RID: 18910
			[Token(Token = "0x40049DE")]
			EMERALD_ROBE,
			// Token: 0x040049DF RID: 18911
			[Token(Token = "0x40049DF")]
			RUBY_ROBE,
			// Token: 0x040049E0 RID: 18912
			[Token(Token = "0x40049E0")]
			DIAMOND_ROBE,
			// Token: 0x040049E1 RID: 18913
			[Token(Token = "0x40049E1")]
			WHITE_TUXEDO_SHIRT,
			// Token: 0x040049E2 RID: 18914
			[Token(Token = "0x40049E2")]
			TURTLE_SCALE_MAIL,
			// Token: 0x040049E3 RID: 18915
			[Token(Token = "0x40049E3")]
			SPECTRE_ROBE,
			// Token: 0x040049E4 RID: 18916
			[Token(Token = "0x40049E4")]
			SHROOMITE_BREASTPLATE,
			// Token: 0x040049E5 RID: 18917
			[Token(Token = "0x40049E5")]
			CENXS_BREASTPLATE,
			// Token: 0x040049E6 RID: 18918
			[Token(Token = "0x40049E6")]
			CROWNOS_BREASTPLATE,
			// Token: 0x040049E7 RID: 18919
			[Token(Token = "0x40049E7")]
			WILLS_BREASTPLATE,
			// Token: 0x040049E8 RID: 18920
			[Token(Token = "0x40049E8")]
			JIMS_BREASTPLATE,
			// Token: 0x040049E9 RID: 18921
			[Token(Token = "0x40049E9")]
			AARONS_BREASTPLATE,
			// Token: 0x040049EA RID: 18922
			[Token(Token = "0x40049EA")]
			D_TOWNS_BREASTPLATE,
			// Token: 0x040049EB RID: 18923
			[Token(Token = "0x40049EB")]
			CENXS_DRESS,
			// Token: 0x040049EC RID: 18924
			[Token(Token = "0x40049EC")]
			PUMPKIN_BREASTPLATE,
			// Token: 0x040049ED RID: 18925
			[Token(Token = "0x40049ED")]
			NURSE_SHIRT,
			// Token: 0x040049EE RID: 18926
			[Token(Token = "0x40049EE")]
			DYE_TRADER_ROBE,
			// Token: 0x040049EF RID: 18927
			[Token(Token = "0x40049EF")]
			CYBORG_SHIRT,
			// Token: 0x040049F0 RID: 18928
			[Token(Token = "0x40049F0")]
			CREEPER_SHIRT,
			// Token: 0x040049F1 RID: 18929
			[Token(Token = "0x40049F1")]
			CAT_SHIRT,
			// Token: 0x040049F2 RID: 18930
			[Token(Token = "0x40049F2")]
			GHOST_SHIRT,
			// Token: 0x040049F3 RID: 18931
			[Token(Token = "0x40049F3")]
			PUMPKIN_SHIRT,
			// Token: 0x040049F4 RID: 18932
			[Token(Token = "0x40049F4")]
			ROBOT_SHIRT,
			// Token: 0x040049F5 RID: 18933
			[Token(Token = "0x40049F5")]
			UNICORN_SHIRT,
			// Token: 0x040049F6 RID: 18934
			[Token(Token = "0x40049F6")]
			VAMPIRE_SHIRT,
			// Token: 0x040049F7 RID: 18935
			[Token(Token = "0x40049F7")]
			LEPRECHAUN_SHIRT,
			// Token: 0x040049F8 RID: 18936
			[Token(Token = "0x40049F8")]
			PIXIE_SHIRT,
			// Token: 0x040049F9 RID: 18937
			[Token(Token = "0x40049F9")]
			PRINCESS_DRESS_HALLOWEEN,
			// Token: 0x040049FA RID: 18938
			[Token(Token = "0x40049FA")]
			WITCH_DRESS,
			// Token: 0x040049FB RID: 18939
			[Token(Token = "0x40049FB")]
			BRIDE_OF_FRANKENSTEIN_DRESS,
			// Token: 0x040049FC RID: 18940
			[Token(Token = "0x40049FC")]
			KARATE_TORTOISE_SHIRT,
			// Token: 0x040049FD RID: 18941
			[Token(Token = "0x40049FD")]
			SCARECROW_SHIRT,
			// Token: 0x040049FE RID: 18942
			[Token(Token = "0x40049FE")]
			REAPER_ROBE,
			// Token: 0x040049FF RID: 18943
			[Token(Token = "0x40049FF")]
			FOX_SHIRT,
			// Token: 0x04004A00 RID: 18944
			[Token(Token = "0x4004A00")]
			SPOOKY_BREASTPLATE,
			// Token: 0x04004A01 RID: 18945
			[Token(Token = "0x4004A01")]
			SPACE_CREATURE_SHIRT,
			// Token: 0x04004A02 RID: 18946
			[Token(Token = "0x4004A02")]
			WOLF_SHIRT,
			// Token: 0x04004A03 RID: 18947
			[Token(Token = "0x4004A03")]
			TREASURE_HUNTER_SHIRT,
			// Token: 0x04004A04 RID: 18948
			[Token(Token = "0x4004A04")]
			DRYAD_COVERINGS,
			// Token: 0x04004A05 RID: 18949
			[Token(Token = "0x4004A05")]
			DRAGON_BREASTPLATE,
			// Token: 0x04004A06 RID: 18950
			[Token(Token = "0x4004A06")]
			TITAN_MAIL,
			// Token: 0x04004A07 RID: 18951
			[Token(Token = "0x4004A07")]
			SPECTRAL_ARMOR,
			// Token: 0x04004A08 RID: 18952
			[Token(Token = "0x4004A08")]
			FABULOUS_TUTU,
			// Token: 0x04004A09 RID: 18953
			[Token(Token = "0x4004A09")]
			GEORGES_TUXEDO_SHIRT,
			// Token: 0x04004A0A RID: 18954
			[Token(Token = "0x4004A0A")]
			DIRNDL,
			// Token: 0x04004A0B RID: 18955
			[Token(Token = "0x4004A0B")]
			TIROLER,
			// Token: 0x04004A0C RID: 18956
			[Token(Token = "0x4004A0C")]
			MRS_CLAUSE_SHIRT,
			// Token: 0x04004A0D RID: 18957
			[Token(Token = "0x4004A0D")]
			TREE_SHIRT,
			// Token: 0x04004A0E RID: 18958
			[Token(Token = "0x4004A0E")]
			PARKA_COAT,
			// Token: 0x04004A0F RID: 18959
			[Token(Token = "0x4004A0F")]
			UGLY_SWEATER,
			// Token: 0x04004A10 RID: 18960
			[Token(Token = "0x4004A10")]
			ELF_SHIRT,
			// Token: 0x04004A11 RID: 18961
			[Token(Token = "0x4004A11")]
			BEETLE_SCALE_MAIL,
			// Token: 0x04004A12 RID: 18962
			[Token(Token = "0x4004A12")]
			BEETLE_SHELL,
			// Token: 0x04004A13 RID: 18963
			[Token(Token = "0x4004A13")]
			GI,
			// Token: 0x04004A14 RID: 18964
			[Token(Token = "0x4004A14")]
			KIMONO,
			// Token: 0x04004A15 RID: 18965
			[Token(Token = "0x4004A15")]
			GYPSY_ROBE,
			// Token: 0x04004A16 RID: 18966
			[Token(Token = "0x4004A16")]
			BEE_BREASTPLATE,
			// Token: 0x04004A17 RID: 18967
			[Token(Token = "0x4004A17")]
			ANGLER_VEST,
			// Token: 0x04004A18 RID: 18968
			[Token(Token = "0x4004A18")]
			SPIDER_BREASTPLATE,
			// Token: 0x04004A19 RID: 18969
			[Token(Token = "0x4004A19")]
			MERMAID_ADORNMENT,
			// Token: 0x04004A1A RID: 18970
			[Token(Token = "0x4004A1A")]
			FISH_COSTUME_SHIRT,
			// Token: 0x04004A1B RID: 18971
			[Token(Token = "0x4004A1B")]
			BOREAL_WOOD_BREASTPLATE,
			// Token: 0x04004A1C RID: 18972
			[Token(Token = "0x4004A1C")]
			PALM_WOOD_BREASTPLATE,
			// Token: 0x04004A1D RID: 18973
			[Token(Token = "0x4004A1D")]
			MYTHICALROBE
		}

		// Token: 0x02000679 RID: 1657
		[Token(Token = "0x2000679")]
		private enum ARMOR_HEAD_SLOTS
		{
			// Token: 0x04004A1F RID: 18975
			[Token(Token = "0x4004A1F")]
			COPPER_HELMET = 1,
			// Token: 0x04004A20 RID: 18976
			[Token(Token = "0x4004A20")]
			IRON_HELMET,
			// Token: 0x04004A21 RID: 18977
			[Token(Token = "0x4004A21")]
			SILVER_HELMET,
			// Token: 0x04004A22 RID: 18978
			[Token(Token = "0x4004A22")]
			GOLD_HELMET,
			// Token: 0x04004A23 RID: 18979
			[Token(Token = "0x4004A23")]
			SHADOW_HELMET,
			// Token: 0x04004A24 RID: 18980
			[Token(Token = "0x4004A24")]
			METEOR_HELMET,
			// Token: 0x04004A25 RID: 18981
			[Token(Token = "0x4004A25")]
			NECRO_HELMET,
			// Token: 0x04004A26 RID: 18982
			[Token(Token = "0x4004A26")]
			JUNGLE_HAT,
			// Token: 0x04004A27 RID: 18983
			[Token(Token = "0x4004A27")]
			MOLTEN_HELMET,
			// Token: 0x04004A28 RID: 18984
			[Token(Token = "0x4004A28")]
			GOGGLES,
			// Token: 0x04004A29 RID: 18985
			[Token(Token = "0x4004A29")]
			MINING_HELMET,
			// Token: 0x04004A2A RID: 18986
			[Token(Token = "0x4004A2A")]
			SUNGLASSES,
			// Token: 0x04004A2B RID: 18987
			[Token(Token = "0x4004A2B")]
			EMPTY_BUCKET,
			// Token: 0x04004A2C RID: 18988
			[Token(Token = "0x4004A2C")]
			WIZARD_HAT,
			// Token: 0x04004A2D RID: 18989
			[Token(Token = "0x4004A2D")]
			TOP_HAT,
			// Token: 0x04004A2E RID: 18990
			[Token(Token = "0x4004A2E")]
			SUMMER_HAT,
			// Token: 0x04004A2F RID: 18991
			[Token(Token = "0x4004A2F")]
			BUNNY_HOOD,
			// Token: 0x04004A30 RID: 18992
			[Token(Token = "0x4004A30")]
			PLUMBERS_HAT,
			// Token: 0x04004A31 RID: 18993
			[Token(Token = "0x4004A31")]
			HEROS_HAT,
			// Token: 0x04004A32 RID: 18994
			[Token(Token = "0x4004A32")]
			FISH_BOWL,
			// Token: 0x04004A33 RID: 18995
			[Token(Token = "0x4004A33")]
			ARCHAEOLOGISTS_HAT,
			// Token: 0x04004A34 RID: 18996
			[Token(Token = "0x4004A34")]
			NINJA_HOOD,
			// Token: 0x04004A35 RID: 18997
			[Token(Token = "0x4004A35")]
			JUNGLE_ROSE,
			// Token: 0x04004A36 RID: 18998
			[Token(Token = "0x4004A36")]
			RED_HAT,
			// Token: 0x04004A37 RID: 18999
			[Token(Token = "0x4004A37")]
			ROBOT_HAT,
			// Token: 0x04004A38 RID: 19000
			[Token(Token = "0x4004A38")]
			GOLD_CROWN,
			// Token: 0x04004A39 RID: 19001
			[Token(Token = "0x4004A39")]
			DIVING_HELMET,
			// Token: 0x04004A3A RID: 19002
			[Token(Token = "0x4004A3A")]
			MIME_MASK,
			// Token: 0x04004A3B RID: 19003
			[Token(Token = "0x4004A3B")]
			COBALT_HAT,
			// Token: 0x04004A3C RID: 19004
			[Token(Token = "0x4004A3C")]
			COBALT_HELMET,
			// Token: 0x04004A3D RID: 19005
			[Token(Token = "0x4004A3D")]
			COBALT_MASK,
			// Token: 0x04004A3E RID: 19006
			[Token(Token = "0x4004A3E")]
			MYTHRIL_HOOD,
			// Token: 0x04004A3F RID: 19007
			[Token(Token = "0x4004A3F")]
			MYTHRIL_HELMET,
			// Token: 0x04004A40 RID: 19008
			[Token(Token = "0x4004A40")]
			MYTHRIL_HAT,
			// Token: 0x04004A41 RID: 19009
			[Token(Token = "0x4004A41")]
			ADAMANTITE_HEADGEAR,
			// Token: 0x04004A42 RID: 19010
			[Token(Token = "0x4004A42")]
			ADAMANTITE_HELMET,
			// Token: 0x04004A43 RID: 19011
			[Token(Token = "0x4004A43")]
			ADAMANTITE_MASK,
			// Token: 0x04004A44 RID: 19012
			[Token(Token = "0x4004A44")]
			WEREWOLF,
			// Token: 0x04004A45 RID: 19013
			[Token(Token = "0x4004A45")]
			MERMAN,
			// Token: 0x04004A46 RID: 19014
			[Token(Token = "0x4004A46")]
			CLOWN_HAT,
			// Token: 0x04004A47 RID: 19015
			[Token(Token = "0x4004A47")]
			HALLOWED_HELMET,
			// Token: 0x04004A48 RID: 19016
			[Token(Token = "0x4004A48")]
			HALLOWED_HEADGEAR,
			// Token: 0x04004A49 RID: 19017
			[Token(Token = "0x4004A49")]
			HALLOWED_MASK,
			// Token: 0x04004A4A RID: 19018
			[Token(Token = "0x4004A4A")]
			SANTA_HAT,
			// Token: 0x04004A4B RID: 19019
			[Token(Token = "0x4004A4B")]
			REDS_HELMET,
			// Token: 0x04004A4C RID: 19020
			[Token(Token = "0x4004A4C")]
			FROST_HELMET,
			// Token: 0x04004A4D RID: 19021
			[Token(Token = "0x4004A4D")]
			TIN_HELMET,
			// Token: 0x04004A4E RID: 19022
			[Token(Token = "0x4004A4E")]
			LEAD_HELMET,
			// Token: 0x04004A4F RID: 19023
			[Token(Token = "0x4004A4F")]
			TUNGSTEN_HELMET,
			// Token: 0x04004A50 RID: 19024
			[Token(Token = "0x4004A50")]
			PLATINUM_HELMET,
			// Token: 0x04004A51 RID: 19025
			[Token(Token = "0x4004A51")]
			PLATINUM_CROWN,
			// Token: 0x04004A52 RID: 19026
			[Token(Token = "0x4004A52")]
			WOOD_HELMET,
			// Token: 0x04004A53 RID: 19027
			[Token(Token = "0x4004A53")]
			EBONWOOD_HELMET,
			// Token: 0x04004A54 RID: 19028
			[Token(Token = "0x4004A54")]
			RICH_MAHOGANY_HELMET,
			// Token: 0x04004A55 RID: 19029
			[Token(Token = "0x4004A55")]
			PEARLWOOD_HELMET,
			// Token: 0x04004A56 RID: 19030
			[Token(Token = "0x4004A56")]
			RUNE_HAT,
			// Token: 0x04004A57 RID: 19031
			[Token(Token = "0x4004A57")]
			CRIMSON_HELMET,
			// Token: 0x04004A58 RID: 19032
			[Token(Token = "0x4004A58")]
			ESKIMO_HOOD,
			// Token: 0x04004A59 RID: 19033
			[Token(Token = "0x4004A59")]
			STEAMPUNK_HAT,
			// Token: 0x04004A5A RID: 19034
			[Token(Token = "0x4004A5A")]
			BEE_HAT,
			// Token: 0x04004A5B RID: 19035
			[Token(Token = "0x4004A5B")]
			PHARAOHS_MASK,
			// Token: 0x04004A5C RID: 19036
			[Token(Token = "0x4004A5C")]
			TIARA,
			// Token: 0x04004A5D RID: 19037
			[Token(Token = "0x4004A5D")]
			GREEN_CAP,
			// Token: 0x04004A5E RID: 19038
			[Token(Token = "0x4004A5E")]
			MUSHROOM_CAP,
			// Token: 0x04004A5F RID: 19039
			[Token(Token = "0x4004A5F")]
			TAM_O_SHANTER,
			// Token: 0x04004A60 RID: 19040
			[Token(Token = "0x4004A60")]
			MUMMY_MASK,
			// Token: 0x04004A61 RID: 19041
			[Token(Token = "0x4004A61")]
			COWBOY_HAT,
			// Token: 0x04004A62 RID: 19042
			[Token(Token = "0x4004A62")]
			PIRATE_HAT,
			// Token: 0x04004A63 RID: 19043
			[Token(Token = "0x4004A63")]
			VIKING_HELMET,
			// Token: 0x04004A64 RID: 19044
			[Token(Token = "0x4004A64")]
			CACTUS_HELMET,
			// Token: 0x04004A65 RID: 19045
			[Token(Token = "0x4004A65")]
			SHADEWOOD_HELMET,
			// Token: 0x04004A66 RID: 19046
			[Token(Token = "0x4004A66")]
			ANCIENT_IRON_HELMET,
			// Token: 0x04004A67 RID: 19047
			[Token(Token = "0x4004A67")]
			ANCIENT_GOLD_HELMET,
			// Token: 0x04004A68 RID: 19048
			[Token(Token = "0x4004A68")]
			ANCIENT_SHADOW_HELMET,
			// Token: 0x04004A69 RID: 19049
			[Token(Token = "0x4004A69")]
			ANCIENT_NECRO_HELMET,
			// Token: 0x04004A6A RID: 19050
			[Token(Token = "0x4004A6A")]
			ANCIENT_COBALT_HELMET,
			// Token: 0x04004A6B RID: 19051
			[Token(Token = "0x4004A6B")]
			PINK_ESKIMO_HOOD,
			// Token: 0x04004A6C RID: 19052
			[Token(Token = "0x4004A6C")]
			CHLOROPHYTE_MASK,
			// Token: 0x04004A6D RID: 19053
			[Token(Token = "0x4004A6D")]
			CHLOROPHYTE_HELMET,
			// Token: 0x04004A6E RID: 19054
			[Token(Token = "0x4004A6E")]
			CHLOROPHYTE_HEADGEAR,
			// Token: 0x04004A6F RID: 19055
			[Token(Token = "0x4004A6F")]
			RAIN_HAT,
			// Token: 0x04004A70 RID: 19056
			[Token(Token = "0x4004A70")]
			TIKI_MASK,
			// Token: 0x04004A71 RID: 19057
			[Token(Token = "0x4004A71")]
			PALLADIUM_MASK,
			// Token: 0x04004A72 RID: 19058
			[Token(Token = "0x4004A72")]
			PALLADIUM_HELMET,
			// Token: 0x04004A73 RID: 19059
			[Token(Token = "0x4004A73")]
			PALLADIUM_HEADGEAR,
			// Token: 0x04004A74 RID: 19060
			[Token(Token = "0x4004A74")]
			ORICHALCUM_MASK,
			// Token: 0x04004A75 RID: 19061
			[Token(Token = "0x4004A75")]
			ORICHALCUM_HELMET,
			// Token: 0x04004A76 RID: 19062
			[Token(Token = "0x4004A76")]
			ORICHALCUM_HEADGEAR,
			// Token: 0x04004A77 RID: 19063
			[Token(Token = "0x4004A77")]
			TITANIUM_MASK,
			// Token: 0x04004A78 RID: 19064
			[Token(Token = "0x4004A78")]
			TITANIUM_HELMET,
			// Token: 0x04004A79 RID: 19065
			[Token(Token = "0x4004A79")]
			TITANIUM_HEADGEAR,
			// Token: 0x04004A7A RID: 19066
			[Token(Token = "0x4004A7A")]
			UMBRELLA_HAT,
			// Token: 0x04004A7B RID: 19067
			[Token(Token = "0x4004A7B")]
			SKULL,
			// Token: 0x04004A7C RID: 19068
			[Token(Token = "0x4004A7C")]
			BALLA_HAT,
			// Token: 0x04004A7D RID: 19069
			[Token(Token = "0x4004A7D")]
			GANGSTA_HAT,
			// Token: 0x04004A7E RID: 19070
			[Token(Token = "0x4004A7E")]
			SAILOR_HAT,
			// Token: 0x04004A7F RID: 19071
			[Token(Token = "0x4004A7F")]
			EYE_PATCH,
			// Token: 0x04004A80 RID: 19072
			[Token(Token = "0x4004A80")]
			SKELETRON_MASK,
			// Token: 0x04004A81 RID: 19073
			[Token(Token = "0x4004A81")]
			TURTLE_HELMET,
			// Token: 0x04004A82 RID: 19074
			[Token(Token = "0x4004A82")]
			BEANIE,
			// Token: 0x04004A83 RID: 19075
			[Token(Token = "0x4004A83")]
			SPECTRE_HOOD,
			// Token: 0x04004A84 RID: 19076
			[Token(Token = "0x4004A84")]
			SWAT_HELMET,
			// Token: 0x04004A85 RID: 19077
			[Token(Token = "0x4004A85")]
			SHROOMITE_HEADGEAR,
			// Token: 0x04004A86 RID: 19078
			[Token(Token = "0x4004A86")]
			SHROOMITE_MASK,
			// Token: 0x04004A87 RID: 19079
			[Token(Token = "0x4004A87")]
			SHROOMITE_HELMET,
			// Token: 0x04004A88 RID: 19080
			[Token(Token = "0x4004A88")]
			CENXS_TIARA,
			// Token: 0x04004A89 RID: 19081
			[Token(Token = "0x4004A89")]
			CROWNOS_MASK,
			// Token: 0x04004A8A RID: 19082
			[Token(Token = "0x4004A8A")]
			WILLS_HELMET,
			// Token: 0x04004A8B RID: 19083
			[Token(Token = "0x4004A8B")]
			JIMS_HELMET,
			// Token: 0x04004A8C RID: 19084
			[Token(Token = "0x4004A8C")]
			AARONS_HELMET,
			// Token: 0x04004A8D RID: 19085
			[Token(Token = "0x4004A8D")]
			D_TOWNS_HELMET,
			// Token: 0x04004A8E RID: 19086
			[Token(Token = "0x4004A8E")]
			PUMPKIN_HELMET,
			// Token: 0x04004A8F RID: 19087
			[Token(Token = "0x4004A8F")]
			NURSE_HAT,
			// Token: 0x04004A90 RID: 19088
			[Token(Token = "0x4004A90")]
			WIZARDS_HAT,
			// Token: 0x04004A91 RID: 19089
			[Token(Token = "0x4004A91")]
			GUY_FAWKES_MASK,
			// Token: 0x04004A92 RID: 19090
			[Token(Token = "0x4004A92")]
			STEAM_PUNK_GOGGLES,
			// Token: 0x04004A93 RID: 19091
			[Token(Token = "0x4004A93")]
			CYBORG_HELMET,
			// Token: 0x04004A94 RID: 19092
			[Token(Token = "0x4004A94")]
			CREEPER_MASK,
			// Token: 0x04004A95 RID: 19093
			[Token(Token = "0x4004A95")]
			CAT_MASK,
			// Token: 0x04004A96 RID: 19094
			[Token(Token = "0x4004A96")]
			GHOST_MASK,
			// Token: 0x04004A97 RID: 19095
			[Token(Token = "0x4004A97")]
			PUMPKIN_MASK,
			// Token: 0x04004A98 RID: 19096
			[Token(Token = "0x4004A98")]
			ROBOT_MASK,
			// Token: 0x04004A99 RID: 19097
			[Token(Token = "0x4004A99")]
			UNICORN_MASK,
			// Token: 0x04004A9A RID: 19098
			[Token(Token = "0x4004A9A")]
			VAMPIRE_MASK,
			// Token: 0x04004A9B RID: 19099
			[Token(Token = "0x4004A9B")]
			WITCH_HAT,
			// Token: 0x04004A9C RID: 19100
			[Token(Token = "0x4004A9C")]
			LEPRECHAUN_HAT,
			// Token: 0x04004A9D RID: 19101
			[Token(Token = "0x4004A9D")]
			PRINCESS_HAT_HALLOWEEN,
			// Token: 0x04004A9E RID: 19102
			[Token(Token = "0x4004A9E")]
			BRIDE_OF_FRANKENSTEIN_MASK,
			// Token: 0x04004A9F RID: 19103
			[Token(Token = "0x4004A9F")]
			KARATE_TORTOISE_MASK,
			// Token: 0x04004AA0 RID: 19104
			[Token(Token = "0x4004AA0")]
			SCARECROW_HAT,
			// Token: 0x04004AA1 RID: 19105
			[Token(Token = "0x4004AA1")]
			REAPER_HOOD,
			// Token: 0x04004AA2 RID: 19106
			[Token(Token = "0x4004AA2")]
			FOX_MASK,
			// Token: 0x04004AA3 RID: 19107
			[Token(Token = "0x4004AA3")]
			CAT_EARS,
			// Token: 0x04004AA4 RID: 19108
			[Token(Token = "0x4004AA4")]
			SPOOKY_HELMET,
			// Token: 0x04004AA5 RID: 19109
			[Token(Token = "0x4004AA5")]
			SPACE_CREATURE_MASK,
			// Token: 0x04004AA6 RID: 19110
			[Token(Token = "0x4004AA6")]
			WOLF_MASK,
			// Token: 0x04004AA7 RID: 19111
			[Token(Token = "0x4004AA7")]
			JACK_O_LANTERN_MASK,
			// Token: 0x04004AA8 RID: 19112
			[Token(Token = "0x4004AA8")]
			DRAGON_MASK,
			// Token: 0x04004AA9 RID: 19113
			[Token(Token = "0x4004AA9")]
			TITAN_HELMET,
			// Token: 0x04004AAA RID: 19114
			[Token(Token = "0x4004AAA")]
			SPECTRAL_HEADGEAR,
			// Token: 0x04004AAB RID: 19115
			[Token(Token = "0x4004AAB")]
			FABULOUS_RIBBON,
			// Token: 0x04004AAC RID: 19116
			[Token(Token = "0x4004AAC")]
			GEORGES_HAT,
			// Token: 0x04004AAD RID: 19117
			[Token(Token = "0x4004AAD")]
			NEWYEARS_HAT,
			// Token: 0x04004AAE RID: 19118
			[Token(Token = "0x4004AAE")]
			DIRNDL,
			// Token: 0x04004AAF RID: 19119
			[Token(Token = "0x4004AAF")]
			TIROLER,
			// Token: 0x04004AB0 RID: 19120
			[Token(Token = "0x4004AB0")]
			GIANT_BOW,
			// Token: 0x04004AB1 RID: 19121
			[Token(Token = "0x4004AB1")]
			REINDEER_ANTLERS,
			// Token: 0x04004AB2 RID: 19122
			[Token(Token = "0x4004AB2")]
			MRS_CLAUSE_HAT,
			// Token: 0x04004AB3 RID: 19123
			[Token(Token = "0x4004AB3")]
			PARKA_HOOD,
			// Token: 0x04004AB4 RID: 19124
			[Token(Token = "0x4004AB4")]
			TREE_MASK,
			// Token: 0x04004AB5 RID: 19125
			[Token(Token = "0x4004AB5")]
			SNOW_HAT,
			// Token: 0x04004AB6 RID: 19126
			[Token(Token = "0x4004AB6")]
			ELF_HAT,
			// Token: 0x04004AB7 RID: 19127
			[Token(Token = "0x4004AB7")]
			FEZ,
			// Token: 0x04004AB8 RID: 19128
			[Token(Token = "0x4004AB8")]
			BEETLE_HELMET,
			// Token: 0x04004AB9 RID: 19129
			[Token(Token = "0x4004AB9")]
			BRAIN_MASK,
			// Token: 0x04004ABA RID: 19130
			[Token(Token = "0x4004ABA")]
			FLESH_MASK,
			// Token: 0x04004ABB RID: 19131
			[Token(Token = "0x4004ABB")]
			TWIN_MASK,
			// Token: 0x04004ABC RID: 19132
			[Token(Token = "0x4004ABC")]
			SKELETRON_PRIME_MASK,
			// Token: 0x04004ABD RID: 19133
			[Token(Token = "0x4004ABD")]
			BEE_MASK,
			// Token: 0x04004ABE RID: 19134
			[Token(Token = "0x4004ABE")]
			PLANTERA_MASK,
			// Token: 0x04004ABF RID: 19135
			[Token(Token = "0x4004ABF")]
			GOLEM_MASK,
			// Token: 0x04004AC0 RID: 19136
			[Token(Token = "0x4004AC0")]
			EATER_MASK,
			// Token: 0x04004AC1 RID: 19137
			[Token(Token = "0x4004AC1")]
			EYE_MASK,
			// Token: 0x04004AC2 RID: 19138
			[Token(Token = "0x4004AC2")]
			DESTROYER_MASK,
			// Token: 0x04004AC3 RID: 19139
			[Token(Token = "0x4004AC3")]
			MAGIC_HAT,
			// Token: 0x04004AC4 RID: 19140
			[Token(Token = "0x4004AC4")]
			SPECTRE_MASK,
			// Token: 0x04004AC5 RID: 19141
			[Token(Token = "0x4004AC5")]
			PEDDLERS_HAT,
			// Token: 0x04004AC6 RID: 19142
			[Token(Token = "0x4004AC6")]
			BEE_HEADGEAR,
			// Token: 0x04004AC7 RID: 19143
			[Token(Token = "0x4004AC7")]
			ANGLER_HAT,
			// Token: 0x04004AC8 RID: 19144
			[Token(Token = "0x4004AC8")]
			SPIDER_MASK,
			// Token: 0x04004AC9 RID: 19145
			[Token(Token = "0x4004AC9")]
			SEASHELL_HAIRPIN,
			// Token: 0x04004ACA RID: 19146
			[Token(Token = "0x4004ACA")]
			KING_SLIME_MASK,
			// Token: 0x04004ACB RID: 19147
			[Token(Token = "0x4004ACB")]
			FISH_COSTUME_MASK,
			// Token: 0x04004ACC RID: 19148
			[Token(Token = "0x4004ACC")]
			BOREAL_WOOD_HELMET,
			// Token: 0x04004ACD RID: 19149
			[Token(Token = "0x4004ACD")]
			PALM_WOOD_HELMET,
			// Token: 0x04004ACE RID: 19150
			[Token(Token = "0x4004ACE")]
			DUKE_FISHRON_MASK,
			// Token: 0x04004ACF RID: 19151
			[Token(Token = "0x4004ACF")]
			MYTHICAL_LION_MASK
		}

		// Token: 0x0200067A RID: 1658
		[Token(Token = "0x200067A")]
		private enum ARMOR_LEG_SLOTS
		{
			// Token: 0x04004AD1 RID: 19153
			[Token(Token = "0x4004AD1")]
			COPPER_GREAVES = 1,
			// Token: 0x04004AD2 RID: 19154
			[Token(Token = "0x4004AD2")]
			IRON_GREAVES,
			// Token: 0x04004AD3 RID: 19155
			[Token(Token = "0x4004AD3")]
			SILVER_GREAVES,
			// Token: 0x04004AD4 RID: 19156
			[Token(Token = "0x4004AD4")]
			GOLD_GREAVES,
			// Token: 0x04004AD5 RID: 19157
			[Token(Token = "0x4004AD5")]
			SHADOW_GREAVES,
			// Token: 0x04004AD6 RID: 19158
			[Token(Token = "0x4004AD6")]
			METEOR_LEGGINGS,
			// Token: 0x04004AD7 RID: 19159
			[Token(Token = "0x4004AD7")]
			NECRO_GREAVES,
			// Token: 0x04004AD8 RID: 19160
			[Token(Token = "0x4004AD8")]
			JUNGLE_PANTS,
			// Token: 0x04004AD9 RID: 19161
			[Token(Token = "0x4004AD9")]
			MOLTEN_GREAVES,
			// Token: 0x04004ADA RID: 19162
			[Token(Token = "0x4004ADA")]
			TUXEDO_PANTS,
			// Token: 0x04004ADB RID: 19163
			[Token(Token = "0x4004ADB")]
			PLUMBERS_PANTS,
			// Token: 0x04004ADC RID: 19164
			[Token(Token = "0x4004ADC")]
			HEROS_PANTS,
			// Token: 0x04004ADD RID: 19165
			[Token(Token = "0x4004ADD")]
			ARCHAEOLOGISTS_PANTS,
			// Token: 0x04004ADE RID: 19166
			[Token(Token = "0x4004ADE")]
			NINJA_PANTS,
			// Token: 0x04004ADF RID: 19167
			[Token(Token = "0x4004ADF")]
			THE_DOCTORS_PANTS,
			// Token: 0x04004AE0 RID: 19168
			[Token(Token = "0x4004AE0")]
			COBALT_LEGGINGS,
			// Token: 0x04004AE1 RID: 19169
			[Token(Token = "0x4004AE1")]
			MYTHRIL_GREAVES,
			// Token: 0x04004AE2 RID: 19170
			[Token(Token = "0x4004AE2")]
			ADAMANTITE_LEGGINGS,
			// Token: 0x04004AE3 RID: 19171
			[Token(Token = "0x4004AE3")]
			MINING_PANTS,
			// Token: 0x04004AE4 RID: 19172
			[Token(Token = "0x4004AE4")]
			WEREWOLF,
			// Token: 0x04004AE5 RID: 19173
			[Token(Token = "0x4004AE5")]
			MERMAN,
			// Token: 0x04004AE6 RID: 19174
			[Token(Token = "0x4004AE6")]
			CLOWN_PANTS,
			// Token: 0x04004AE7 RID: 19175
			[Token(Token = "0x4004AE7")]
			HALLOWED_GREAVES,
			// Token: 0x04004AE8 RID: 19176
			[Token(Token = "0x4004AE8")]
			SANTA_PANTS,
			// Token: 0x04004AE9 RID: 19177
			[Token(Token = "0x4004AE9")]
			REDS_LEGGINGS,
			// Token: 0x04004AEA RID: 19178
			[Token(Token = "0x4004AEA")]
			FROST_LEGGINGS,
			// Token: 0x04004AEB RID: 19179
			[Token(Token = "0x4004AEB")]
			TIN_GREAVES,
			// Token: 0x04004AEC RID: 19180
			[Token(Token = "0x4004AEC")]
			LEAD_GREAVES,
			// Token: 0x04004AED RID: 19181
			[Token(Token = "0x4004AED")]
			TUNGSTEN_GREAVES,
			// Token: 0x04004AEE RID: 19182
			[Token(Token = "0x4004AEE")]
			PLATINUM_GREAVES,
			// Token: 0x04004AEF RID: 19183
			[Token(Token = "0x4004AEF")]
			WOOD_GREAVES,
			// Token: 0x04004AF0 RID: 19184
			[Token(Token = "0x4004AF0")]
			EBONWOOD_GREAVES,
			// Token: 0x04004AF1 RID: 19185
			[Token(Token = "0x4004AF1")]
			RICH_MAHOGANY_GREAVES,
			// Token: 0x04004AF2 RID: 19186
			[Token(Token = "0x4004AF2")]
			PEARLWOOD_GREAVES,
			// Token: 0x04004AF3 RID: 19187
			[Token(Token = "0x4004AF3")]
			CRIMSON_GREAVES,
			// Token: 0x04004AF4 RID: 19188
			[Token(Token = "0x4004AF4")]
			ESKIMO_PANTS,
			// Token: 0x04004AF5 RID: 19189
			[Token(Token = "0x4004AF5")]
			STEAMPUNK_PANTS,
			// Token: 0x04004AF6 RID: 19190
			[Token(Token = "0x4004AF6")]
			BEE_PANTS,
			// Token: 0x04004AF7 RID: 19191
			[Token(Token = "0x4004AF7")]
			MUMMY_PANTS,
			// Token: 0x04004AF8 RID: 19192
			[Token(Token = "0x4004AF8")]
			COWBOY_PANTS,
			// Token: 0x04004AF9 RID: 19193
			[Token(Token = "0x4004AF9")]
			PIRATE_PANTS,
			// Token: 0x04004AFA RID: 19194
			[Token(Token = "0x4004AFA")]
			CACTUS_LEGGINGS,
			// Token: 0x04004AFB RID: 19195
			[Token(Token = "0x4004AFB")]
			SHADEWOOD_GREAVES,
			// Token: 0x04004AFC RID: 19196
			[Token(Token = "0x4004AFC")]
			ANCIENT_SHADOW_GREAVES,
			// Token: 0x04004AFD RID: 19197
			[Token(Token = "0x4004AFD")]
			ANCIENT_COBALT_LEGGINGS,
			// Token: 0x04004AFE RID: 19198
			[Token(Token = "0x4004AFE")]
			PINK_ESKIMO_PANTS,
			// Token: 0x04004AFF RID: 19199
			[Token(Token = "0x4004AFF")]
			CHLOROPHYTE_GREAVES,
			// Token: 0x04004B00 RID: 19200
			[Token(Token = "0x4004B00")]
			TIKI_PANTS,
			// Token: 0x04004B01 RID: 19201
			[Token(Token = "0x4004B01")]
			PALLADIUM_LEGGINGS,
			// Token: 0x04004B02 RID: 19202
			[Token(Token = "0x4004B02")]
			ORICHALCUM_LEGGINGS,
			// Token: 0x04004B03 RID: 19203
			[Token(Token = "0x4004B03")]
			TITANIUM_LEGGINGS,
			// Token: 0x04004B04 RID: 19204
			[Token(Token = "0x4004B04")]
			SAILOR_PANTS,
			// Token: 0x04004B05 RID: 19205
			[Token(Token = "0x4004B05")]
			WHITE_TUXEDO_PANTS,
			// Token: 0x04004B06 RID: 19206
			[Token(Token = "0x4004B06")]
			TURTLE_LEGGINGS,
			// Token: 0x04004B07 RID: 19207
			[Token(Token = "0x4004B07")]
			SPECTRE_PANTS,
			// Token: 0x04004B08 RID: 19208
			[Token(Token = "0x4004B08")]
			SHROOMITE_LEGGINGS,
			// Token: 0x04004B09 RID: 19209
			[Token(Token = "0x4004B09")]
			CENXS_LEGGINGS,
			// Token: 0x04004B0A RID: 19210
			[Token(Token = "0x4004B0A")]
			CROWNOS_LEGGINGS,
			// Token: 0x04004B0B RID: 19211
			[Token(Token = "0x4004B0B")]
			WILLS_LEGGINGS,
			// Token: 0x04004B0C RID: 19212
			[Token(Token = "0x4004B0C")]
			JIMS_LEGGINGS,
			// Token: 0x04004B0D RID: 19213
			[Token(Token = "0x4004B0D")]
			AARONS_LEGGINGS,
			// Token: 0x04004B0E RID: 19214
			[Token(Token = "0x4004B0E")]
			D_TOWNS_LEGGINGS,
			// Token: 0x04004B0F RID: 19215
			[Token(Token = "0x4004B0F")]
			CENXS_DRESS_PANTS,
			// Token: 0x04004B10 RID: 19216
			[Token(Token = "0x4004B10")]
			PUMPKIN_LEGGINGS,
			// Token: 0x04004B11 RID: 19217
			[Token(Token = "0x4004B11")]
			NURSE_PANTS,
			// Token: 0x04004B12 RID: 19218
			[Token(Token = "0x4004B12")]
			CYBORG_PANTS,
			// Token: 0x04004B13 RID: 19219
			[Token(Token = "0x4004B13")]
			CREEPER_PANTS,
			// Token: 0x04004B14 RID: 19220
			[Token(Token = "0x4004B14")]
			CAT_PANTS,
			// Token: 0x04004B15 RID: 19221
			[Token(Token = "0x4004B15")]
			PUMPKIN_PANTS,
			// Token: 0x04004B16 RID: 19222
			[Token(Token = "0x4004B16")]
			ROBOT_PANTS,
			// Token: 0x04004B17 RID: 19223
			[Token(Token = "0x4004B17")]
			UNICORN_PANTS,
			// Token: 0x04004B18 RID: 19224
			[Token(Token = "0x4004B18")]
			VAMPIRE_PANTS,
			// Token: 0x04004B19 RID: 19225
			[Token(Token = "0x4004B19")]
			LEPRECHAUN_PANTS,
			// Token: 0x04004B1A RID: 19226
			[Token(Token = "0x4004B1A")]
			PIXIE_PANTS,
			// Token: 0x04004B1B RID: 19227
			[Token(Token = "0x4004B1B")]
			WITCH_BOOTS,
			// Token: 0x04004B1C RID: 19228
			[Token(Token = "0x4004B1C")]
			KARATE_TORTOISE_PANTS,
			// Token: 0x04004B1D RID: 19229
			[Token(Token = "0x4004B1D")]
			SCARECROW_PANTS,
			// Token: 0x04004B1E RID: 19230
			[Token(Token = "0x4004B1E")]
			FOX_PANTS,
			// Token: 0x04004B1F RID: 19231
			[Token(Token = "0x4004B1F")]
			SPOOKY_LEGGINGS,
			// Token: 0x04004B20 RID: 19232
			[Token(Token = "0x4004B20")]
			SPACE_CREATURE_PANTS,
			// Token: 0x04004B21 RID: 19233
			[Token(Token = "0x4004B21")]
			WOLF_PANTS,
			// Token: 0x04004B22 RID: 19234
			[Token(Token = "0x4004B22")]
			TREASURE_HUNTER_PANTS,
			// Token: 0x04004B23 RID: 19235
			[Token(Token = "0x4004B23")]
			DRYAD_LOINCLOTH,
			// Token: 0x04004B24 RID: 19236
			[Token(Token = "0x4004B24")]
			MRS_CLAUSE_HEELS,
			// Token: 0x04004B25 RID: 19237
			[Token(Token = "0x4004B25")]
			TREE_TRUNKS,
			// Token: 0x04004B26 RID: 19238
			[Token(Token = "0x4004B26")]
			PARKA_PANTS,
			// Token: 0x04004B27 RID: 19239
			[Token(Token = "0x4004B27")]
			ELF_PANTS,
			// Token: 0x04004B28 RID: 19240
			[Token(Token = "0x4004B28")]
			ROBE,
			// Token: 0x04004B29 RID: 19241
			[Token(Token = "0x4004B29")]
			RUNE_ROBE,
			// Token: 0x04004B2A RID: 19242
			[Token(Token = "0x4004B2A")]
			PHARAOHS_ROBE,
			// Token: 0x04004B2B RID: 19243
			[Token(Token = "0x4004B2B")]
			AMETHYST_ROBE,
			// Token: 0x04004B2C RID: 19244
			[Token(Token = "0x4004B2C")]
			TOPAZ_ROBE,
			// Token: 0x04004B2D RID: 19245
			[Token(Token = "0x4004B2D")]
			SAPPHIRE_ROBE,
			// Token: 0x04004B2E RID: 19246
			[Token(Token = "0x4004B2E")]
			EMERALD_ROBE,
			// Token: 0x04004B2F RID: 19247
			[Token(Token = "0x4004B2F")]
			RUBY_ROBE,
			// Token: 0x04004B30 RID: 19248
			[Token(Token = "0x4004B30")]
			DIAMOND_ROBE,
			// Token: 0x04004B31 RID: 19249
			[Token(Token = "0x4004B31")]
			PRINCESS_DRESS,
			// Token: 0x04004B32 RID: 19250
			[Token(Token = "0x4004B32")]
			BEETLE_LEGGINGS,
			// Token: 0x04004B33 RID: 19251
			[Token(Token = "0x4004B33")]
			GI,
			// Token: 0x04004B34 RID: 19252
			[Token(Token = "0x4004B34")]
			KIMONO,
			// Token: 0x04004B35 RID: 19253
			[Token(Token = "0x4004B35")]
			GYPSY_ROBE,
			// Token: 0x04004B36 RID: 19254
			[Token(Token = "0x4004B36")]
			BEE_GREAVES,
			// Token: 0x04004B37 RID: 19255
			[Token(Token = "0x4004B37")]
			ANGLER_PANTS,
			// Token: 0x04004B38 RID: 19256
			[Token(Token = "0x4004B38")]
			SPIDER_GREAVES,
			// Token: 0x04004B39 RID: 19257
			[Token(Token = "0x4004B39")]
			MERMAID_TAIL,
			// Token: 0x04004B3A RID: 19258
			[Token(Token = "0x4004B3A")]
			FISH_COSTUME_FINSKIRT,
			// Token: 0x04004B3B RID: 19259
			[Token(Token = "0x4004B3B")]
			BOREAL_WOOD_GREAVES,
			// Token: 0x04004B3C RID: 19260
			[Token(Token = "0x4004B3C")]
			PALM_WOOD_GREAVES,
			// Token: 0x04004B3D RID: 19261
			[Token(Token = "0x4004B3D")]
			DRAGON_GREAVES,
			// Token: 0x04004B3E RID: 19262
			[Token(Token = "0x4004B3E")]
			TITAN_LEGGINGS,
			// Token: 0x04004B3F RID: 19263
			[Token(Token = "0x4004B3F")]
			SPECTRAL_SUBLIGAR,
			// Token: 0x04004B40 RID: 19264
			[Token(Token = "0x4004B40")]
			FABULOUS_SLIPPERS,
			// Token: 0x04004B41 RID: 19265
			[Token(Token = "0x4004B41")]
			GEORGES_TUXEDO_PANTS,
			// Token: 0x04004B42 RID: 19266
			[Token(Token = "0x4004B42")]
			DIRNDL,
			// Token: 0x04004B43 RID: 19267
			[Token(Token = "0x4004B43")]
			TIROLER,
			// Token: 0x04004B44 RID: 19268
			[Token(Token = "0x4004B44")]
			OSTARA_BOOTS,
			// Token: 0x04004B45 RID: 19269
			[Token(Token = "0x4004B45")]
			MYTHICALROBE
		}
	}
}
