using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ReLogic.Reflection;
using Terraria.DataStructures;

namespace Terraria.ID
{
	// Token: 0x020006F4 RID: 1780
	[Token(Token = "0x20006F4")]
	public class NPCID
	{
		// Token: 0x0600419C RID: 16796 RVA: 0x00020118 File Offset: 0x0001E318
		[Token(Token = "0x600419C")]
		[Address(RVA = "0x1F2BE20", Offset = "0x1F2BE20", VA = "0x1F2BE20")]
		public static int FromLegacyName(string name)
		{
			return 0;
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x00020130 File Offset: 0x0001E330
		[Token(Token = "0x600419D")]
		[Address(RVA = "0x1F2BEE0", Offset = "0x1F2BEE0", VA = "0x1F2BEE0")]
		public static int FromNetId(int id)
		{
			return 0;
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600419E")]
		[Address(RVA = "0x1F2BF7C", Offset = "0x1F2BF7C", VA = "0x1F2BF7C")]
		public NPCID()
		{
		}

		// Token: 0x04007842 RID: 30786
		[Token(Token = "0x4007842")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] NetIdMap;

		// Token: 0x04007843 RID: 30787
		[Token(Token = "0x4007843")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Dictionary<string, int> LegacyNameToIdMap;

		// Token: 0x04007844 RID: 30788
		[Token(Token = "0x4007844")]
		public const short NegativeIDCount = -66;

		// Token: 0x04007845 RID: 30789
		[Token(Token = "0x4007845")]
		public const short BigHornetStingy = -65;

		// Token: 0x04007846 RID: 30790
		[Token(Token = "0x4007846")]
		public const short LittleHornetStingy = -64;

		// Token: 0x04007847 RID: 30791
		[Token(Token = "0x4007847")]
		public const short BigHornetSpikey = -63;

		// Token: 0x04007848 RID: 30792
		[Token(Token = "0x4007848")]
		public const short LittleHornetSpikey = -62;

		// Token: 0x04007849 RID: 30793
		[Token(Token = "0x4007849")]
		public const short BigHornetLeafy = -61;

		// Token: 0x0400784A RID: 30794
		[Token(Token = "0x400784A")]
		public const short LittleHornetLeafy = -60;

		// Token: 0x0400784B RID: 30795
		[Token(Token = "0x400784B")]
		public const short BigHornetHoney = -59;

		// Token: 0x0400784C RID: 30796
		[Token(Token = "0x400784C")]
		public const short LittleHornetHoney = -58;

		// Token: 0x0400784D RID: 30797
		[Token(Token = "0x400784D")]
		public const short BigHornetFatty = -57;

		// Token: 0x0400784E RID: 30798
		[Token(Token = "0x400784E")]
		public const short LittleHornetFatty = -56;

		// Token: 0x0400784F RID: 30799
		[Token(Token = "0x400784F")]
		public const short BigRainZombie = -55;

		// Token: 0x04007850 RID: 30800
		[Token(Token = "0x4007850")]
		public const short SmallRainZombie = -54;

		// Token: 0x04007851 RID: 30801
		[Token(Token = "0x4007851")]
		public const short BigPantlessSkeleton = -53;

		// Token: 0x04007852 RID: 30802
		[Token(Token = "0x4007852")]
		public const short SmallPantlessSkeleton = -52;

		// Token: 0x04007853 RID: 30803
		[Token(Token = "0x4007853")]
		public const short BigMisassembledSkeleton = -51;

		// Token: 0x04007854 RID: 30804
		[Token(Token = "0x4007854")]
		public const short SmallMisassembledSkeleton = -50;

		// Token: 0x04007855 RID: 30805
		[Token(Token = "0x4007855")]
		public const short BigHeadacheSkeleton = -49;

		// Token: 0x04007856 RID: 30806
		[Token(Token = "0x4007856")]
		public const short SmallHeadacheSkeleton = -48;

		// Token: 0x04007857 RID: 30807
		[Token(Token = "0x4007857")]
		public const short BigSkeleton = -47;

		// Token: 0x04007858 RID: 30808
		[Token(Token = "0x4007858")]
		public const short SmallSkeleton = -46;

		// Token: 0x04007859 RID: 30809
		[Token(Token = "0x4007859")]
		public const short BigFemaleZombie = -45;

		// Token: 0x0400785A RID: 30810
		[Token(Token = "0x400785A")]
		public const short SmallFemaleZombie = -44;

		// Token: 0x0400785B RID: 30811
		[Token(Token = "0x400785B")]
		public const short DemonEye2 = -43;

		// Token: 0x0400785C RID: 30812
		[Token(Token = "0x400785C")]
		public const short PurpleEye2 = -42;

		// Token: 0x0400785D RID: 30813
		[Token(Token = "0x400785D")]
		public const short GreenEye2 = -41;

		// Token: 0x0400785E RID: 30814
		[Token(Token = "0x400785E")]
		public const short DialatedEye2 = -40;

		// Token: 0x0400785F RID: 30815
		[Token(Token = "0x400785F")]
		public const short SleepyEye2 = -39;

		// Token: 0x04007860 RID: 30816
		[Token(Token = "0x4007860")]
		public const short CataractEye2 = -38;

		// Token: 0x04007861 RID: 30817
		[Token(Token = "0x4007861")]
		public const short BigTwiggyZombie = -37;

		// Token: 0x04007862 RID: 30818
		[Token(Token = "0x4007862")]
		public const short SmallTwiggyZombie = -36;

		// Token: 0x04007863 RID: 30819
		[Token(Token = "0x4007863")]
		public const short BigSwampZombie = -35;

		// Token: 0x04007864 RID: 30820
		[Token(Token = "0x4007864")]
		public const short SmallSwampZombie = -34;

		// Token: 0x04007865 RID: 30821
		[Token(Token = "0x4007865")]
		public const short BigSlimedZombie = -33;

		// Token: 0x04007866 RID: 30822
		[Token(Token = "0x4007866")]
		public const short SmallSlimedZombie = -32;

		// Token: 0x04007867 RID: 30823
		[Token(Token = "0x4007867")]
		public const short BigPincushionZombie = -31;

		// Token: 0x04007868 RID: 30824
		[Token(Token = "0x4007868")]
		public const short SmallPincushionZombie = -30;

		// Token: 0x04007869 RID: 30825
		[Token(Token = "0x4007869")]
		public const short BigBaldZombie = -29;

		// Token: 0x0400786A RID: 30826
		[Token(Token = "0x400786A")]
		public const short SmallBaldZombie = -28;

		// Token: 0x0400786B RID: 30827
		[Token(Token = "0x400786B")]
		public const short BigZombie = -27;

		// Token: 0x0400786C RID: 30828
		[Token(Token = "0x400786C")]
		public const short SmallZombie = -26;

		// Token: 0x0400786D RID: 30829
		[Token(Token = "0x400786D")]
		public const short BigCrimslime = -25;

		// Token: 0x0400786E RID: 30830
		[Token(Token = "0x400786E")]
		public const short LittleCrimslime = -24;

		// Token: 0x0400786F RID: 30831
		[Token(Token = "0x400786F")]
		public const short BigCrimera = -23;

		// Token: 0x04007870 RID: 30832
		[Token(Token = "0x4007870")]
		public const short LittleCrimera = -22;

		// Token: 0x04007871 RID: 30833
		[Token(Token = "0x4007871")]
		public const short GiantMossHornet = -21;

		// Token: 0x04007872 RID: 30834
		[Token(Token = "0x4007872")]
		public const short BigMossHornet = -20;

		// Token: 0x04007873 RID: 30835
		[Token(Token = "0x4007873")]
		public const short LittleMossHornet = -19;

		// Token: 0x04007874 RID: 30836
		[Token(Token = "0x4007874")]
		public const short TinyMossHornet = -18;

		// Token: 0x04007875 RID: 30837
		[Token(Token = "0x4007875")]
		public const short BigStinger = -17;

		// Token: 0x04007876 RID: 30838
		[Token(Token = "0x4007876")]
		public const short LittleStinger = -16;

		// Token: 0x04007877 RID: 30839
		[Token(Token = "0x4007877")]
		public const short HeavySkeleton = -15;

		// Token: 0x04007878 RID: 30840
		[Token(Token = "0x4007878")]
		public const short BigBoned = -14;

		// Token: 0x04007879 RID: 30841
		[Token(Token = "0x4007879")]
		public const short ShortBones = -13;

		// Token: 0x0400787A RID: 30842
		[Token(Token = "0x400787A")]
		public const short BigEater = -12;

		// Token: 0x0400787B RID: 30843
		[Token(Token = "0x400787B")]
		public const short LittleEater = -11;

		// Token: 0x0400787C RID: 30844
		[Token(Token = "0x400787C")]
		public const short JungleSlime = -10;

		// Token: 0x0400787D RID: 30845
		[Token(Token = "0x400787D")]
		public const short YellowSlime = -9;

		// Token: 0x0400787E RID: 30846
		[Token(Token = "0x400787E")]
		public const short RedSlime = -8;

		// Token: 0x0400787F RID: 30847
		[Token(Token = "0x400787F")]
		public const short PurpleSlime = -7;

		// Token: 0x04007880 RID: 30848
		[Token(Token = "0x4007880")]
		public const short BlackSlime = -6;

		// Token: 0x04007881 RID: 30849
		[Token(Token = "0x4007881")]
		public const short BabySlime = -5;

		// Token: 0x04007882 RID: 30850
		[Token(Token = "0x4007882")]
		public const short Pinky = -4;

		// Token: 0x04007883 RID: 30851
		[Token(Token = "0x4007883")]
		public const short GreenSlime = -3;

		// Token: 0x04007884 RID: 30852
		[Token(Token = "0x4007884")]
		public const short Slimer2 = -2;

		// Token: 0x04007885 RID: 30853
		[Token(Token = "0x4007885")]
		public const short Slimeling = -1;

		// Token: 0x04007886 RID: 30854
		[Token(Token = "0x4007886")]
		public const short None = 0;

		// Token: 0x04007887 RID: 30855
		[Token(Token = "0x4007887")]
		public const short BlueSlime = 1;

		// Token: 0x04007888 RID: 30856
		[Token(Token = "0x4007888")]
		public const short DemonEye = 2;

		// Token: 0x04007889 RID: 30857
		[Token(Token = "0x4007889")]
		public const short Zombie = 3;

		// Token: 0x0400788A RID: 30858
		[Token(Token = "0x400788A")]
		public const short EyeofCthulhu = 4;

		// Token: 0x0400788B RID: 30859
		[Token(Token = "0x400788B")]
		public const short ServantofCthulhu = 5;

		// Token: 0x0400788C RID: 30860
		[Token(Token = "0x400788C")]
		public const short EaterofSouls = 6;

		// Token: 0x0400788D RID: 30861
		[Token(Token = "0x400788D")]
		public const short DevourerHead = 7;

		// Token: 0x0400788E RID: 30862
		[Token(Token = "0x400788E")]
		public const short DevourerBody = 8;

		// Token: 0x0400788F RID: 30863
		[Token(Token = "0x400788F")]
		public const short DevourerTail = 9;

		// Token: 0x04007890 RID: 30864
		[Token(Token = "0x4007890")]
		public const short GiantWormHead = 10;

		// Token: 0x04007891 RID: 30865
		[Token(Token = "0x4007891")]
		public const short GiantWormBody = 11;

		// Token: 0x04007892 RID: 30866
		[Token(Token = "0x4007892")]
		public const short GiantWormTail = 12;

		// Token: 0x04007893 RID: 30867
		[Token(Token = "0x4007893")]
		public const short EaterofWorldsHead = 13;

		// Token: 0x04007894 RID: 30868
		[Token(Token = "0x4007894")]
		public const short EaterofWorldsBody = 14;

		// Token: 0x04007895 RID: 30869
		[Token(Token = "0x4007895")]
		public const short EaterofWorldsTail = 15;

		// Token: 0x04007896 RID: 30870
		[Token(Token = "0x4007896")]
		public const short MotherSlime = 16;

		// Token: 0x04007897 RID: 30871
		[Token(Token = "0x4007897")]
		public const short Merchant = 17;

		// Token: 0x04007898 RID: 30872
		[Token(Token = "0x4007898")]
		public const short Nurse = 18;

		// Token: 0x04007899 RID: 30873
		[Token(Token = "0x4007899")]
		public const short ArmsDealer = 19;

		// Token: 0x0400789A RID: 30874
		[Token(Token = "0x400789A")]
		public const short Dryad = 20;

		// Token: 0x0400789B RID: 30875
		[Token(Token = "0x400789B")]
		public const short Skeleton = 21;

		// Token: 0x0400789C RID: 30876
		[Token(Token = "0x400789C")]
		public const short Guide = 22;

		// Token: 0x0400789D RID: 30877
		[Token(Token = "0x400789D")]
		public const short MeteorHead = 23;

		// Token: 0x0400789E RID: 30878
		[Token(Token = "0x400789E")]
		public const short FireImp = 24;

		// Token: 0x0400789F RID: 30879
		[Token(Token = "0x400789F")]
		public const short BurningSphere = 25;

		// Token: 0x040078A0 RID: 30880
		[Token(Token = "0x40078A0")]
		public const short GoblinPeon = 26;

		// Token: 0x040078A1 RID: 30881
		[Token(Token = "0x40078A1")]
		public const short GoblinThief = 27;

		// Token: 0x040078A2 RID: 30882
		[Token(Token = "0x40078A2")]
		public const short GoblinWarrior = 28;

		// Token: 0x040078A3 RID: 30883
		[Token(Token = "0x40078A3")]
		public const short GoblinSorcerer = 29;

		// Token: 0x040078A4 RID: 30884
		[Token(Token = "0x40078A4")]
		public const short ChaosBall = 30;

		// Token: 0x040078A5 RID: 30885
		[Token(Token = "0x40078A5")]
		public const short AngryBones = 31;

		// Token: 0x040078A6 RID: 30886
		[Token(Token = "0x40078A6")]
		public const short DarkCaster = 32;

		// Token: 0x040078A7 RID: 30887
		[Token(Token = "0x40078A7")]
		public const short WaterSphere = 33;

		// Token: 0x040078A8 RID: 30888
		[Token(Token = "0x40078A8")]
		public const short CursedSkull = 34;

		// Token: 0x040078A9 RID: 30889
		[Token(Token = "0x40078A9")]
		public const short SkeletronHead = 35;

		// Token: 0x040078AA RID: 30890
		[Token(Token = "0x40078AA")]
		public const short SkeletronHand = 36;

		// Token: 0x040078AB RID: 30891
		[Token(Token = "0x40078AB")]
		public const short OldMan = 37;

		// Token: 0x040078AC RID: 30892
		[Token(Token = "0x40078AC")]
		public const short Demolitionist = 38;

		// Token: 0x040078AD RID: 30893
		[Token(Token = "0x40078AD")]
		public const short BoneSerpentHead = 39;

		// Token: 0x040078AE RID: 30894
		[Token(Token = "0x40078AE")]
		public const short BoneSerpentBody = 40;

		// Token: 0x040078AF RID: 30895
		[Token(Token = "0x40078AF")]
		public const short BoneSerpentTail = 41;

		// Token: 0x040078B0 RID: 30896
		[Token(Token = "0x40078B0")]
		public const short Hornet = 42;

		// Token: 0x040078B1 RID: 30897
		[Token(Token = "0x40078B1")]
		public const short ManEater = 43;

		// Token: 0x040078B2 RID: 30898
		[Token(Token = "0x40078B2")]
		public const short UndeadMiner = 44;

		// Token: 0x040078B3 RID: 30899
		[Token(Token = "0x40078B3")]
		public const short Tim = 45;

		// Token: 0x040078B4 RID: 30900
		[Token(Token = "0x40078B4")]
		public const short Bunny = 46;

		// Token: 0x040078B5 RID: 30901
		[Token(Token = "0x40078B5")]
		public const short CorruptBunny = 47;

		// Token: 0x040078B6 RID: 30902
		[Token(Token = "0x40078B6")]
		public const short Harpy = 48;

		// Token: 0x040078B7 RID: 30903
		[Token(Token = "0x40078B7")]
		public const short CaveBat = 49;

		// Token: 0x040078B8 RID: 30904
		[Token(Token = "0x40078B8")]
		public const short KingSlime = 50;

		// Token: 0x040078B9 RID: 30905
		[Token(Token = "0x40078B9")]
		public const short JungleBat = 51;

		// Token: 0x040078BA RID: 30906
		[Token(Token = "0x40078BA")]
		public const short DoctorBones = 52;

		// Token: 0x040078BB RID: 30907
		[Token(Token = "0x40078BB")]
		public const short TheGroom = 53;

		// Token: 0x040078BC RID: 30908
		[Token(Token = "0x40078BC")]
		public const short Clothier = 54;

		// Token: 0x040078BD RID: 30909
		[Token(Token = "0x40078BD")]
		public const short Goldfish = 55;

		// Token: 0x040078BE RID: 30910
		[Token(Token = "0x40078BE")]
		public const short Snatcher = 56;

		// Token: 0x040078BF RID: 30911
		[Token(Token = "0x40078BF")]
		public const short CorruptGoldfish = 57;

		// Token: 0x040078C0 RID: 30912
		[Token(Token = "0x40078C0")]
		public const short Piranha = 58;

		// Token: 0x040078C1 RID: 30913
		[Token(Token = "0x40078C1")]
		public const short LavaSlime = 59;

		// Token: 0x040078C2 RID: 30914
		[Token(Token = "0x40078C2")]
		public const short Hellbat = 60;

		// Token: 0x040078C3 RID: 30915
		[Token(Token = "0x40078C3")]
		public const short Vulture = 61;

		// Token: 0x040078C4 RID: 30916
		[Token(Token = "0x40078C4")]
		public const short Demon = 62;

		// Token: 0x040078C5 RID: 30917
		[Token(Token = "0x40078C5")]
		public const short BlueJellyfish = 63;

		// Token: 0x040078C6 RID: 30918
		[Token(Token = "0x40078C6")]
		public const short PinkJellyfish = 64;

		// Token: 0x040078C7 RID: 30919
		[Token(Token = "0x40078C7")]
		public const short Shark = 65;

		// Token: 0x040078C8 RID: 30920
		[Token(Token = "0x40078C8")]
		public const short VoodooDemon = 66;

		// Token: 0x040078C9 RID: 30921
		[Token(Token = "0x40078C9")]
		public const short Crab = 67;

		// Token: 0x040078CA RID: 30922
		[Token(Token = "0x40078CA")]
		public const short DungeonGuardian = 68;

		// Token: 0x040078CB RID: 30923
		[Token(Token = "0x40078CB")]
		public const short Antlion = 69;

		// Token: 0x040078CC RID: 30924
		[Token(Token = "0x40078CC")]
		public const short SpikeBall = 70;

		// Token: 0x040078CD RID: 30925
		[Token(Token = "0x40078CD")]
		public const short DungeonSlime = 71;

		// Token: 0x040078CE RID: 30926
		[Token(Token = "0x40078CE")]
		public const short BlazingWheel = 72;

		// Token: 0x040078CF RID: 30927
		[Token(Token = "0x40078CF")]
		public const short GoblinScout = 73;

		// Token: 0x040078D0 RID: 30928
		[Token(Token = "0x40078D0")]
		public const short Bird = 74;

		// Token: 0x040078D1 RID: 30929
		[Token(Token = "0x40078D1")]
		public const short Pixie = 75;

		// Token: 0x040078D2 RID: 30930
		[Token(Token = "0x40078D2")]
		public const short None2 = 76;

		// Token: 0x040078D3 RID: 30931
		[Token(Token = "0x40078D3")]
		public const short ArmoredSkeleton = 77;

		// Token: 0x040078D4 RID: 30932
		[Token(Token = "0x40078D4")]
		public const short Mummy = 78;

		// Token: 0x040078D5 RID: 30933
		[Token(Token = "0x40078D5")]
		public const short DarkMummy = 79;

		// Token: 0x040078D6 RID: 30934
		[Token(Token = "0x40078D6")]
		public const short LightMummy = 80;

		// Token: 0x040078D7 RID: 30935
		[Token(Token = "0x40078D7")]
		public const short CorruptSlime = 81;

		// Token: 0x040078D8 RID: 30936
		[Token(Token = "0x40078D8")]
		public const short Wraith = 82;

		// Token: 0x040078D9 RID: 30937
		[Token(Token = "0x40078D9")]
		public const short CursedHammer = 83;

		// Token: 0x040078DA RID: 30938
		[Token(Token = "0x40078DA")]
		public const short EnchantedSword = 84;

		// Token: 0x040078DB RID: 30939
		[Token(Token = "0x40078DB")]
		public const short Mimic = 85;

		// Token: 0x040078DC RID: 30940
		[Token(Token = "0x40078DC")]
		public const short Unicorn = 86;

		// Token: 0x040078DD RID: 30941
		[Token(Token = "0x40078DD")]
		public const short WyvernHead = 87;

		// Token: 0x040078DE RID: 30942
		[Token(Token = "0x40078DE")]
		public const short WyvernLegs = 88;

		// Token: 0x040078DF RID: 30943
		[Token(Token = "0x40078DF")]
		public const short WyvernBody = 89;

		// Token: 0x040078E0 RID: 30944
		[Token(Token = "0x40078E0")]
		public const short WyvernBody2 = 90;

		// Token: 0x040078E1 RID: 30945
		[Token(Token = "0x40078E1")]
		public const short WyvernBody3 = 91;

		// Token: 0x040078E2 RID: 30946
		[Token(Token = "0x40078E2")]
		public const short WyvernTail = 92;

		// Token: 0x040078E3 RID: 30947
		[Token(Token = "0x40078E3")]
		public const short GiantBat = 93;

		// Token: 0x040078E4 RID: 30948
		[Token(Token = "0x40078E4")]
		public const short Corruptor = 94;

		// Token: 0x040078E5 RID: 30949
		[Token(Token = "0x40078E5")]
		public const short DiggerHead = 95;

		// Token: 0x040078E6 RID: 30950
		[Token(Token = "0x40078E6")]
		public const short DiggerBody = 96;

		// Token: 0x040078E7 RID: 30951
		[Token(Token = "0x40078E7")]
		public const short DiggerTail = 97;

		// Token: 0x040078E8 RID: 30952
		[Token(Token = "0x40078E8")]
		public const short SeekerHead = 98;

		// Token: 0x040078E9 RID: 30953
		[Token(Token = "0x40078E9")]
		public const short SeekerBody = 99;

		// Token: 0x040078EA RID: 30954
		[Token(Token = "0x40078EA")]
		public const short SeekerTail = 100;

		// Token: 0x040078EB RID: 30955
		[Token(Token = "0x40078EB")]
		public const short Clinger = 101;

		// Token: 0x040078EC RID: 30956
		[Token(Token = "0x40078EC")]
		public const short AnglerFish = 102;

		// Token: 0x040078ED RID: 30957
		[Token(Token = "0x40078ED")]
		public const short GreenJellyfish = 103;

		// Token: 0x040078EE RID: 30958
		[Token(Token = "0x40078EE")]
		public const short Werewolf = 104;

		// Token: 0x040078EF RID: 30959
		[Token(Token = "0x40078EF")]
		public const short BoundGoblin = 105;

		// Token: 0x040078F0 RID: 30960
		[Token(Token = "0x40078F0")]
		public const short BoundWizard = 106;

		// Token: 0x040078F1 RID: 30961
		[Token(Token = "0x40078F1")]
		public const short GoblinTinkerer = 107;

		// Token: 0x040078F2 RID: 30962
		[Token(Token = "0x40078F2")]
		public const short Wizard = 108;

		// Token: 0x040078F3 RID: 30963
		[Token(Token = "0x40078F3")]
		public const short Clown = 109;

		// Token: 0x040078F4 RID: 30964
		[Token(Token = "0x40078F4")]
		public const short SkeletonArcher = 110;

		// Token: 0x040078F5 RID: 30965
		[Token(Token = "0x40078F5")]
		public const short GoblinArcher = 111;

		// Token: 0x040078F6 RID: 30966
		[Token(Token = "0x40078F6")]
		public const short VileSpit = 112;

		// Token: 0x040078F7 RID: 30967
		[Token(Token = "0x40078F7")]
		public const short WallofFlesh = 113;

		// Token: 0x040078F8 RID: 30968
		[Token(Token = "0x40078F8")]
		public const short WallofFleshEye = 114;

		// Token: 0x040078F9 RID: 30969
		[Token(Token = "0x40078F9")]
		public const short TheHungry = 115;

		// Token: 0x040078FA RID: 30970
		[Token(Token = "0x40078FA")]
		public const short TheHungryII = 116;

		// Token: 0x040078FB RID: 30971
		[Token(Token = "0x40078FB")]
		public const short LeechHead = 117;

		// Token: 0x040078FC RID: 30972
		[Token(Token = "0x40078FC")]
		public const short LeechBody = 118;

		// Token: 0x040078FD RID: 30973
		[Token(Token = "0x40078FD")]
		public const short LeechTail = 119;

		// Token: 0x040078FE RID: 30974
		[Token(Token = "0x40078FE")]
		public const short ChaosElemental = 120;

		// Token: 0x040078FF RID: 30975
		[Token(Token = "0x40078FF")]
		public const short Slimer = 121;

		// Token: 0x04007900 RID: 30976
		[Token(Token = "0x4007900")]
		public const short Gastropod = 122;

		// Token: 0x04007901 RID: 30977
		[Token(Token = "0x4007901")]
		public const short BoundMechanic = 123;

		// Token: 0x04007902 RID: 30978
		[Token(Token = "0x4007902")]
		public const short Mechanic = 124;

		// Token: 0x04007903 RID: 30979
		[Token(Token = "0x4007903")]
		public const short Retinazer = 125;

		// Token: 0x04007904 RID: 30980
		[Token(Token = "0x4007904")]
		public const short Spazmatism = 126;

		// Token: 0x04007905 RID: 30981
		[Token(Token = "0x4007905")]
		public const short SkeletronPrime = 127;

		// Token: 0x04007906 RID: 30982
		[Token(Token = "0x4007906")]
		public const short PrimeCannon = 128;

		// Token: 0x04007907 RID: 30983
		[Token(Token = "0x4007907")]
		public const short PrimeSaw = 129;

		// Token: 0x04007908 RID: 30984
		[Token(Token = "0x4007908")]
		public const short PrimeVice = 130;

		// Token: 0x04007909 RID: 30985
		[Token(Token = "0x4007909")]
		public const short PrimeLaser = 131;

		// Token: 0x0400790A RID: 30986
		[Token(Token = "0x400790A")]
		public const short BaldZombie = 132;

		// Token: 0x0400790B RID: 30987
		[Token(Token = "0x400790B")]
		public const short WanderingEye = 133;

		// Token: 0x0400790C RID: 30988
		[Token(Token = "0x400790C")]
		public const short TheDestroyer = 134;

		// Token: 0x0400790D RID: 30989
		[Token(Token = "0x400790D")]
		public const short TheDestroyerBody = 135;

		// Token: 0x0400790E RID: 30990
		[Token(Token = "0x400790E")]
		public const short TheDestroyerTail = 136;

		// Token: 0x0400790F RID: 30991
		[Token(Token = "0x400790F")]
		public const short IlluminantBat = 137;

		// Token: 0x04007910 RID: 30992
		[Token(Token = "0x4007910")]
		public const short IlluminantSlime = 138;

		// Token: 0x04007911 RID: 30993
		[Token(Token = "0x4007911")]
		public const short Probe = 139;

		// Token: 0x04007912 RID: 30994
		[Token(Token = "0x4007912")]
		public const short PossessedArmor = 140;

		// Token: 0x04007913 RID: 30995
		[Token(Token = "0x4007913")]
		public const short ToxicSludge = 141;

		// Token: 0x04007914 RID: 30996
		[Token(Token = "0x4007914")]
		public const short SantaClaus = 142;

		// Token: 0x04007915 RID: 30997
		[Token(Token = "0x4007915")]
		public const short SnowmanGangsta = 143;

		// Token: 0x04007916 RID: 30998
		[Token(Token = "0x4007916")]
		public const short MisterStabby = 144;

		// Token: 0x04007917 RID: 30999
		[Token(Token = "0x4007917")]
		public const short SnowBalla = 145;

		// Token: 0x04007918 RID: 31000
		[Token(Token = "0x4007918")]
		public const short None3 = 146;

		// Token: 0x04007919 RID: 31001
		[Token(Token = "0x4007919")]
		public const short IceSlime = 147;

		// Token: 0x0400791A RID: 31002
		[Token(Token = "0x400791A")]
		public const short Penguin = 148;

		// Token: 0x0400791B RID: 31003
		[Token(Token = "0x400791B")]
		public const short PenguinBlack = 149;

		// Token: 0x0400791C RID: 31004
		[Token(Token = "0x400791C")]
		public const short IceBat = 150;

		// Token: 0x0400791D RID: 31005
		[Token(Token = "0x400791D")]
		public const short Lavabat = 151;

		// Token: 0x0400791E RID: 31006
		[Token(Token = "0x400791E")]
		public const short GiantFlyingFox = 152;

		// Token: 0x0400791F RID: 31007
		[Token(Token = "0x400791F")]
		public const short GiantTortoise = 153;

		// Token: 0x04007920 RID: 31008
		[Token(Token = "0x4007920")]
		public const short IceTortoise = 154;

		// Token: 0x04007921 RID: 31009
		[Token(Token = "0x4007921")]
		public const short Wolf = 155;

		// Token: 0x04007922 RID: 31010
		[Token(Token = "0x4007922")]
		public const short RedDevil = 156;

		// Token: 0x04007923 RID: 31011
		[Token(Token = "0x4007923")]
		public const short Arapaima = 157;

		// Token: 0x04007924 RID: 31012
		[Token(Token = "0x4007924")]
		public const short VampireBat = 158;

		// Token: 0x04007925 RID: 31013
		[Token(Token = "0x4007925")]
		public const short Vampire = 159;

		// Token: 0x04007926 RID: 31014
		[Token(Token = "0x4007926")]
		public const short Truffle = 160;

		// Token: 0x04007927 RID: 31015
		[Token(Token = "0x4007927")]
		public const short ZombieEskimo = 161;

		// Token: 0x04007928 RID: 31016
		[Token(Token = "0x4007928")]
		public const short Frankenstein = 162;

		// Token: 0x04007929 RID: 31017
		[Token(Token = "0x4007929")]
		public const short BlackRecluse = 163;

		// Token: 0x0400792A RID: 31018
		[Token(Token = "0x400792A")]
		public const short WallCreeper = 164;

		// Token: 0x0400792B RID: 31019
		[Token(Token = "0x400792B")]
		public const short WallCreeperWall = 165;

		// Token: 0x0400792C RID: 31020
		[Token(Token = "0x400792C")]
		public const short SwampThing = 166;

		// Token: 0x0400792D RID: 31021
		[Token(Token = "0x400792D")]
		public const short UndeadViking = 167;

		// Token: 0x0400792E RID: 31022
		[Token(Token = "0x400792E")]
		public const short CorruptPenguin = 168;

		// Token: 0x0400792F RID: 31023
		[Token(Token = "0x400792F")]
		public const short IceElemental = 169;

		// Token: 0x04007930 RID: 31024
		[Token(Token = "0x4007930")]
		public const short PigronCorruption = 170;

		// Token: 0x04007931 RID: 31025
		[Token(Token = "0x4007931")]
		public const short PigronHallow = 171;

		// Token: 0x04007932 RID: 31026
		[Token(Token = "0x4007932")]
		public const short RuneWizard = 172;

		// Token: 0x04007933 RID: 31027
		[Token(Token = "0x4007933")]
		public const short Crimera = 173;

		// Token: 0x04007934 RID: 31028
		[Token(Token = "0x4007934")]
		public const short Herpling = 174;

		// Token: 0x04007935 RID: 31029
		[Token(Token = "0x4007935")]
		public const short AngryTrapper = 175;

		// Token: 0x04007936 RID: 31030
		[Token(Token = "0x4007936")]
		public const short MossHornet = 176;

		// Token: 0x04007937 RID: 31031
		[Token(Token = "0x4007937")]
		public const short Derpling = 177;

		// Token: 0x04007938 RID: 31032
		[Token(Token = "0x4007938")]
		public const short Steampunker = 178;

		// Token: 0x04007939 RID: 31033
		[Token(Token = "0x4007939")]
		public const short CrimsonAxe = 179;

		// Token: 0x0400793A RID: 31034
		[Token(Token = "0x400793A")]
		public const short PigronCrimson = 180;

		// Token: 0x0400793B RID: 31035
		[Token(Token = "0x400793B")]
		public const short FaceMonster = 181;

		// Token: 0x0400793C RID: 31036
		[Token(Token = "0x400793C")]
		public const short FloatyGross = 182;

		// Token: 0x0400793D RID: 31037
		[Token(Token = "0x400793D")]
		public const short Crimslime = 183;

		// Token: 0x0400793E RID: 31038
		[Token(Token = "0x400793E")]
		public const short SpikedIceSlime = 184;

		// Token: 0x0400793F RID: 31039
		[Token(Token = "0x400793F")]
		public const short SnowFlinx = 185;

		// Token: 0x04007940 RID: 31040
		[Token(Token = "0x4007940")]
		public const short PincushionZombie = 186;

		// Token: 0x04007941 RID: 31041
		[Token(Token = "0x4007941")]
		public const short SlimedZombie = 187;

		// Token: 0x04007942 RID: 31042
		[Token(Token = "0x4007942")]
		public const short SwampZombie = 188;

		// Token: 0x04007943 RID: 31043
		[Token(Token = "0x4007943")]
		public const short TwiggyZombie = 189;

		// Token: 0x04007944 RID: 31044
		[Token(Token = "0x4007944")]
		public const short CataractEye = 190;

		// Token: 0x04007945 RID: 31045
		[Token(Token = "0x4007945")]
		public const short SleepyEye = 191;

		// Token: 0x04007946 RID: 31046
		[Token(Token = "0x4007946")]
		public const short DialatedEye = 192;

		// Token: 0x04007947 RID: 31047
		[Token(Token = "0x4007947")]
		public const short GreenEye = 193;

		// Token: 0x04007948 RID: 31048
		[Token(Token = "0x4007948")]
		public const short PurpleEye = 194;

		// Token: 0x04007949 RID: 31049
		[Token(Token = "0x4007949")]
		public const short LostGirl = 195;

		// Token: 0x0400794A RID: 31050
		[Token(Token = "0x400794A")]
		public const short Nymph = 196;

		// Token: 0x0400794B RID: 31051
		[Token(Token = "0x400794B")]
		public const short ArmoredViking = 197;

		// Token: 0x0400794C RID: 31052
		[Token(Token = "0x400794C")]
		public const short Lihzahrd = 198;

		// Token: 0x0400794D RID: 31053
		[Token(Token = "0x400794D")]
		public const short LihzahrdCrawler = 199;

		// Token: 0x0400794E RID: 31054
		[Token(Token = "0x400794E")]
		public const short FemaleZombie = 200;

		// Token: 0x0400794F RID: 31055
		[Token(Token = "0x400794F")]
		public const short HeadacheSkeleton = 201;

		// Token: 0x04007950 RID: 31056
		[Token(Token = "0x4007950")]
		public const short MisassembledSkeleton = 202;

		// Token: 0x04007951 RID: 31057
		[Token(Token = "0x4007951")]
		public const short PantlessSkeleton = 203;

		// Token: 0x04007952 RID: 31058
		[Token(Token = "0x4007952")]
		public const short SpikedJungleSlime = 204;

		// Token: 0x04007953 RID: 31059
		[Token(Token = "0x4007953")]
		public const short Moth = 205;

		// Token: 0x04007954 RID: 31060
		[Token(Token = "0x4007954")]
		public const short IcyMerman = 206;

		// Token: 0x04007955 RID: 31061
		[Token(Token = "0x4007955")]
		public const short DyeTrader = 207;

		// Token: 0x04007956 RID: 31062
		[Token(Token = "0x4007956")]
		public const short PartyGirl = 208;

		// Token: 0x04007957 RID: 31063
		[Token(Token = "0x4007957")]
		public const short Cyborg = 209;

		// Token: 0x04007958 RID: 31064
		[Token(Token = "0x4007958")]
		public const short Bee = 210;

		// Token: 0x04007959 RID: 31065
		[Token(Token = "0x4007959")]
		public const short BeeSmall = 211;

		// Token: 0x0400795A RID: 31066
		[Token(Token = "0x400795A")]
		public const short PirateDeckhand = 212;

		// Token: 0x0400795B RID: 31067
		[Token(Token = "0x400795B")]
		public const short PirateCorsair = 213;

		// Token: 0x0400795C RID: 31068
		[Token(Token = "0x400795C")]
		public const short PirateDeadeye = 214;

		// Token: 0x0400795D RID: 31069
		[Token(Token = "0x400795D")]
		public const short PirateCrossbower = 215;

		// Token: 0x0400795E RID: 31070
		[Token(Token = "0x400795E")]
		public const short PirateCaptain = 216;

		// Token: 0x0400795F RID: 31071
		[Token(Token = "0x400795F")]
		public const short CochinealBeetle = 217;

		// Token: 0x04007960 RID: 31072
		[Token(Token = "0x4007960")]
		public const short CyanBeetle = 218;

		// Token: 0x04007961 RID: 31073
		[Token(Token = "0x4007961")]
		public const short LacBeetle = 219;

		// Token: 0x04007962 RID: 31074
		[Token(Token = "0x4007962")]
		public const short SeaSnail = 220;

		// Token: 0x04007963 RID: 31075
		[Token(Token = "0x4007963")]
		public const short Squid = 221;

		// Token: 0x04007964 RID: 31076
		[Token(Token = "0x4007964")]
		public const short QueenBee = 222;

		// Token: 0x04007965 RID: 31077
		[Token(Token = "0x4007965")]
		public const short ZombieRaincoat = 223;

		// Token: 0x04007966 RID: 31078
		[Token(Token = "0x4007966")]
		public const short FlyingFish = 224;

		// Token: 0x04007967 RID: 31079
		[Token(Token = "0x4007967")]
		public const short UmbrellaSlime = 225;

		// Token: 0x04007968 RID: 31080
		[Token(Token = "0x4007968")]
		public const short FlyingSnake = 226;

		// Token: 0x04007969 RID: 31081
		[Token(Token = "0x4007969")]
		public const short Painter = 227;

		// Token: 0x0400796A RID: 31082
		[Token(Token = "0x400796A")]
		public const short WitchDoctor = 228;

		// Token: 0x0400796B RID: 31083
		[Token(Token = "0x400796B")]
		public const short Pirate = 229;

		// Token: 0x0400796C RID: 31084
		[Token(Token = "0x400796C")]
		public const short GoldfishWalker = 230;

		// Token: 0x0400796D RID: 31085
		[Token(Token = "0x400796D")]
		public const short HornetFatty = 231;

		// Token: 0x0400796E RID: 31086
		[Token(Token = "0x400796E")]
		public const short HornetHoney = 232;

		// Token: 0x0400796F RID: 31087
		[Token(Token = "0x400796F")]
		public const short HornetLeafy = 233;

		// Token: 0x04007970 RID: 31088
		[Token(Token = "0x4007970")]
		public const short HornetSpikey = 234;

		// Token: 0x04007971 RID: 31089
		[Token(Token = "0x4007971")]
		public const short HornetStingy = 235;

		// Token: 0x04007972 RID: 31090
		[Token(Token = "0x4007972")]
		public const short JungleCreeper = 236;

		// Token: 0x04007973 RID: 31091
		[Token(Token = "0x4007973")]
		public const short JungleCreeperWall = 237;

		// Token: 0x04007974 RID: 31092
		[Token(Token = "0x4007974")]
		public const short BlackRecluseWall = 238;

		// Token: 0x04007975 RID: 31093
		[Token(Token = "0x4007975")]
		public const short BloodCrawler = 239;

		// Token: 0x04007976 RID: 31094
		[Token(Token = "0x4007976")]
		public const short BloodCrawlerWall = 240;

		// Token: 0x04007977 RID: 31095
		[Token(Token = "0x4007977")]
		public const short BloodFeeder = 241;

		// Token: 0x04007978 RID: 31096
		[Token(Token = "0x4007978")]
		public const short BloodJelly = 242;

		// Token: 0x04007979 RID: 31097
		[Token(Token = "0x4007979")]
		public const short IceGolem = 243;

		// Token: 0x0400797A RID: 31098
		[Token(Token = "0x400797A")]
		public const short RainbowSlime = 244;

		// Token: 0x0400797B RID: 31099
		[Token(Token = "0x400797B")]
		public const short Golem = 245;

		// Token: 0x0400797C RID: 31100
		[Token(Token = "0x400797C")]
		public const short GolemHead = 246;

		// Token: 0x0400797D RID: 31101
		[Token(Token = "0x400797D")]
		public const short GolemFistLeft = 247;

		// Token: 0x0400797E RID: 31102
		[Token(Token = "0x400797E")]
		public const short GolemFistRight = 248;

		// Token: 0x0400797F RID: 31103
		[Token(Token = "0x400797F")]
		public const short GolemHeadFree = 249;

		// Token: 0x04007980 RID: 31104
		[Token(Token = "0x4007980")]
		public const short AngryNimbus = 250;

		// Token: 0x04007981 RID: 31105
		[Token(Token = "0x4007981")]
		public const short Eyezor = 251;

		// Token: 0x04007982 RID: 31106
		[Token(Token = "0x4007982")]
		public const short Parrot = 252;

		// Token: 0x04007983 RID: 31107
		[Token(Token = "0x4007983")]
		public const short Reaper = 253;

		// Token: 0x04007984 RID: 31108
		[Token(Token = "0x4007984")]
		public const short ZombieMushroom = 254;

		// Token: 0x04007985 RID: 31109
		[Token(Token = "0x4007985")]
		public const short ZombieMushroomHat = 255;

		// Token: 0x04007986 RID: 31110
		[Token(Token = "0x4007986")]
		public const short FungoFish = 256;

		// Token: 0x04007987 RID: 31111
		[Token(Token = "0x4007987")]
		public const short AnomuraFungus = 257;

		// Token: 0x04007988 RID: 31112
		[Token(Token = "0x4007988")]
		public const short MushiLadybug = 258;

		// Token: 0x04007989 RID: 31113
		[Token(Token = "0x4007989")]
		public const short FungiBulb = 259;

		// Token: 0x0400798A RID: 31114
		[Token(Token = "0x400798A")]
		public const short GiantFungiBulb = 260;

		// Token: 0x0400798B RID: 31115
		[Token(Token = "0x400798B")]
		public const short FungiSpore = 261;

		// Token: 0x0400798C RID: 31116
		[Token(Token = "0x400798C")]
		public const short Plantera = 262;

		// Token: 0x0400798D RID: 31117
		[Token(Token = "0x400798D")]
		public const short PlanterasHook = 263;

		// Token: 0x0400798E RID: 31118
		[Token(Token = "0x400798E")]
		public const short PlanterasTentacle = 264;

		// Token: 0x0400798F RID: 31119
		[Token(Token = "0x400798F")]
		public const short Spore = 265;

		// Token: 0x04007990 RID: 31120
		[Token(Token = "0x4007990")]
		public const short BrainofCthulhu = 266;

		// Token: 0x04007991 RID: 31121
		[Token(Token = "0x4007991")]
		public const short Creeper = 267;

		// Token: 0x04007992 RID: 31122
		[Token(Token = "0x4007992")]
		public const short IchorSticker = 268;

		// Token: 0x04007993 RID: 31123
		[Token(Token = "0x4007993")]
		public const short RustyArmoredBonesAxe = 269;

		// Token: 0x04007994 RID: 31124
		[Token(Token = "0x4007994")]
		public const short RustyArmoredBonesFlail = 270;

		// Token: 0x04007995 RID: 31125
		[Token(Token = "0x4007995")]
		public const short RustyArmoredBonesSword = 271;

		// Token: 0x04007996 RID: 31126
		[Token(Token = "0x4007996")]
		public const short RustyArmoredBonesSwordNoArmor = 272;

		// Token: 0x04007997 RID: 31127
		[Token(Token = "0x4007997")]
		public const short BlueArmoredBones = 273;

		// Token: 0x04007998 RID: 31128
		[Token(Token = "0x4007998")]
		public const short BlueArmoredBonesMace = 274;

		// Token: 0x04007999 RID: 31129
		[Token(Token = "0x4007999")]
		public const short BlueArmoredBonesNoPants = 275;

		// Token: 0x0400799A RID: 31130
		[Token(Token = "0x400799A")]
		public const short BlueArmoredBonesSword = 276;

		// Token: 0x0400799B RID: 31131
		[Token(Token = "0x400799B")]
		public const short HellArmoredBones = 277;

		// Token: 0x0400799C RID: 31132
		[Token(Token = "0x400799C")]
		public const short HellArmoredBonesSpikeShield = 278;

		// Token: 0x0400799D RID: 31133
		[Token(Token = "0x400799D")]
		public const short HellArmoredBonesMace = 279;

		// Token: 0x0400799E RID: 31134
		[Token(Token = "0x400799E")]
		public const short HellArmoredBonesSword = 280;

		// Token: 0x0400799F RID: 31135
		[Token(Token = "0x400799F")]
		public const short RaggedCaster = 281;

		// Token: 0x040079A0 RID: 31136
		[Token(Token = "0x40079A0")]
		public const short RaggedCasterOpenCoat = 282;

		// Token: 0x040079A1 RID: 31137
		[Token(Token = "0x40079A1")]
		public const short Necromancer = 283;

		// Token: 0x040079A2 RID: 31138
		[Token(Token = "0x40079A2")]
		public const short NecromancerArmored = 284;

		// Token: 0x040079A3 RID: 31139
		[Token(Token = "0x40079A3")]
		public const short DiabolistRed = 285;

		// Token: 0x040079A4 RID: 31140
		[Token(Token = "0x40079A4")]
		public const short DiabolistWhite = 286;

		// Token: 0x040079A5 RID: 31141
		[Token(Token = "0x40079A5")]
		public const short BoneLee = 287;

		// Token: 0x040079A6 RID: 31142
		[Token(Token = "0x40079A6")]
		public const short DungeonSpirit = 288;

		// Token: 0x040079A7 RID: 31143
		[Token(Token = "0x40079A7")]
		public const short GiantCursedSkull = 289;

		// Token: 0x040079A8 RID: 31144
		[Token(Token = "0x40079A8")]
		public const short Paladin = 290;

		// Token: 0x040079A9 RID: 31145
		[Token(Token = "0x40079A9")]
		public const short SkeletonSniper = 291;

		// Token: 0x040079AA RID: 31146
		[Token(Token = "0x40079AA")]
		public const short TacticalSkeleton = 292;

		// Token: 0x040079AB RID: 31147
		[Token(Token = "0x40079AB")]
		public const short SkeletonCommando = 293;

		// Token: 0x040079AC RID: 31148
		[Token(Token = "0x40079AC")]
		public const short AngryBonesBig = 294;

		// Token: 0x040079AD RID: 31149
		[Token(Token = "0x40079AD")]
		public const short AngryBonesBigMuscle = 295;

		// Token: 0x040079AE RID: 31150
		[Token(Token = "0x40079AE")]
		public const short AngryBonesBigHelmet = 296;

		// Token: 0x040079AF RID: 31151
		[Token(Token = "0x40079AF")]
		public const short BirdBlue = 297;

		// Token: 0x040079B0 RID: 31152
		[Token(Token = "0x40079B0")]
		public const short BirdRed = 298;

		// Token: 0x040079B1 RID: 31153
		[Token(Token = "0x40079B1")]
		public const short Squirrel = 299;

		// Token: 0x040079B2 RID: 31154
		[Token(Token = "0x40079B2")]
		public const short Mouse = 300;

		// Token: 0x040079B3 RID: 31155
		[Token(Token = "0x40079B3")]
		public const short Raven = 301;

		// Token: 0x040079B4 RID: 31156
		[Token(Token = "0x40079B4")]
		public const short SlimeMasked = 302;

		// Token: 0x040079B5 RID: 31157
		[Token(Token = "0x40079B5")]
		public const short BunnySlimed = 303;

		// Token: 0x040079B6 RID: 31158
		[Token(Token = "0x40079B6")]
		public const short HoppinJack = 304;

		// Token: 0x040079B7 RID: 31159
		[Token(Token = "0x40079B7")]
		public const short Scarecrow1 = 305;

		// Token: 0x040079B8 RID: 31160
		[Token(Token = "0x40079B8")]
		public const short Scarecrow2 = 306;

		// Token: 0x040079B9 RID: 31161
		[Token(Token = "0x40079B9")]
		public const short Scarecrow3 = 307;

		// Token: 0x040079BA RID: 31162
		[Token(Token = "0x40079BA")]
		public const short Scarecrow4 = 308;

		// Token: 0x040079BB RID: 31163
		[Token(Token = "0x40079BB")]
		public const short Scarecrow5 = 309;

		// Token: 0x040079BC RID: 31164
		[Token(Token = "0x40079BC")]
		public const short Scarecrow6 = 310;

		// Token: 0x040079BD RID: 31165
		[Token(Token = "0x40079BD")]
		public const short Scarecrow7 = 311;

		// Token: 0x040079BE RID: 31166
		[Token(Token = "0x40079BE")]
		public const short Scarecrow8 = 312;

		// Token: 0x040079BF RID: 31167
		[Token(Token = "0x40079BF")]
		public const short Scarecrow9 = 313;

		// Token: 0x040079C0 RID: 31168
		[Token(Token = "0x40079C0")]
		public const short Scarecrow10 = 314;

		// Token: 0x040079C1 RID: 31169
		[Token(Token = "0x40079C1")]
		public const short HeadlessHorseman = 315;

		// Token: 0x040079C2 RID: 31170
		[Token(Token = "0x40079C2")]
		public const short Ghost = 316;

		// Token: 0x040079C3 RID: 31171
		[Token(Token = "0x40079C3")]
		public const short DemonEyeOwl = 317;

		// Token: 0x040079C4 RID: 31172
		[Token(Token = "0x40079C4")]
		public const short DemonEyeSpaceship = 318;

		// Token: 0x040079C5 RID: 31173
		[Token(Token = "0x40079C5")]
		public const short ZombieDoctor = 319;

		// Token: 0x040079C6 RID: 31174
		[Token(Token = "0x40079C6")]
		public const short ZombieSuperman = 320;

		// Token: 0x040079C7 RID: 31175
		[Token(Token = "0x40079C7")]
		public const short ZombiePixie = 321;

		// Token: 0x040079C8 RID: 31176
		[Token(Token = "0x40079C8")]
		public const short SkeletonTopHat = 322;

		// Token: 0x040079C9 RID: 31177
		[Token(Token = "0x40079C9")]
		public const short SkeletonAstonaut = 323;

		// Token: 0x040079CA RID: 31178
		[Token(Token = "0x40079CA")]
		public const short SkeletonAlien = 324;

		// Token: 0x040079CB RID: 31179
		[Token(Token = "0x40079CB")]
		public const short MourningWood = 325;

		// Token: 0x040079CC RID: 31180
		[Token(Token = "0x40079CC")]
		public const short Splinterling = 326;

		// Token: 0x040079CD RID: 31181
		[Token(Token = "0x40079CD")]
		public const short Pumpking = 327;

		// Token: 0x040079CE RID: 31182
		[Token(Token = "0x40079CE")]
		public const short PumpkingBlade = 328;

		// Token: 0x040079CF RID: 31183
		[Token(Token = "0x40079CF")]
		public const short Hellhound = 329;

		// Token: 0x040079D0 RID: 31184
		[Token(Token = "0x40079D0")]
		public const short Poltergeist = 330;

		// Token: 0x040079D1 RID: 31185
		[Token(Token = "0x40079D1")]
		public const short ZombieXmas = 331;

		// Token: 0x040079D2 RID: 31186
		[Token(Token = "0x40079D2")]
		public const short ZombieSweater = 332;

		// Token: 0x040079D3 RID: 31187
		[Token(Token = "0x40079D3")]
		public const short SlimeRibbonWhite = 333;

		// Token: 0x040079D4 RID: 31188
		[Token(Token = "0x40079D4")]
		public const short SlimeRibbonYellow = 334;

		// Token: 0x040079D5 RID: 31189
		[Token(Token = "0x40079D5")]
		public const short SlimeRibbonGreen = 335;

		// Token: 0x040079D6 RID: 31190
		[Token(Token = "0x40079D6")]
		public const short SlimeRibbonRed = 336;

		// Token: 0x040079D7 RID: 31191
		[Token(Token = "0x40079D7")]
		public const short BunnyXmas = 337;

		// Token: 0x040079D8 RID: 31192
		[Token(Token = "0x40079D8")]
		public const short ZombieElf = 338;

		// Token: 0x040079D9 RID: 31193
		[Token(Token = "0x40079D9")]
		public const short ZombieElfBeard = 339;

		// Token: 0x040079DA RID: 31194
		[Token(Token = "0x40079DA")]
		public const short ZombieElfGirl = 340;

		// Token: 0x040079DB RID: 31195
		[Token(Token = "0x40079DB")]
		public const short PresentMimic = 341;

		// Token: 0x040079DC RID: 31196
		[Token(Token = "0x40079DC")]
		public const short GingerbreadMan = 342;

		// Token: 0x040079DD RID: 31197
		[Token(Token = "0x40079DD")]
		public const short Yeti = 343;

		// Token: 0x040079DE RID: 31198
		[Token(Token = "0x40079DE")]
		public const short Everscream = 344;

		// Token: 0x040079DF RID: 31199
		[Token(Token = "0x40079DF")]
		public const short IceQueen = 345;

		// Token: 0x040079E0 RID: 31200
		[Token(Token = "0x40079E0")]
		public const short SantaNK1 = 346;

		// Token: 0x040079E1 RID: 31201
		[Token(Token = "0x40079E1")]
		public const short ElfCopter = 347;

		// Token: 0x040079E2 RID: 31202
		[Token(Token = "0x40079E2")]
		public const short Nutcracker = 348;

		// Token: 0x040079E3 RID: 31203
		[Token(Token = "0x40079E3")]
		public const short NutcrackerSpinning = 349;

		// Token: 0x040079E4 RID: 31204
		[Token(Token = "0x40079E4")]
		public const short ElfArcher = 350;

		// Token: 0x040079E5 RID: 31205
		[Token(Token = "0x40079E5")]
		public const short Krampus = 351;

		// Token: 0x040079E6 RID: 31206
		[Token(Token = "0x40079E6")]
		public const short Flocko = 352;

		// Token: 0x040079E7 RID: 31207
		[Token(Token = "0x40079E7")]
		public const short Stylist = 353;

		// Token: 0x040079E8 RID: 31208
		[Token(Token = "0x40079E8")]
		public const short WebbedStylist = 354;

		// Token: 0x040079E9 RID: 31209
		[Token(Token = "0x40079E9")]
		public const short Firefly = 355;

		// Token: 0x040079EA RID: 31210
		[Token(Token = "0x40079EA")]
		public const short Butterfly = 356;

		// Token: 0x040079EB RID: 31211
		[Token(Token = "0x40079EB")]
		public const short Worm = 357;

		// Token: 0x040079EC RID: 31212
		[Token(Token = "0x40079EC")]
		public const short LightningBug = 358;

		// Token: 0x040079ED RID: 31213
		[Token(Token = "0x40079ED")]
		public const short Snail = 359;

		// Token: 0x040079EE RID: 31214
		[Token(Token = "0x40079EE")]
		public const short GlowingSnail = 360;

		// Token: 0x040079EF RID: 31215
		[Token(Token = "0x40079EF")]
		public const short Frog = 361;

		// Token: 0x040079F0 RID: 31216
		[Token(Token = "0x40079F0")]
		public const short Duck = 362;

		// Token: 0x040079F1 RID: 31217
		[Token(Token = "0x40079F1")]
		public const short Duck2 = 363;

		// Token: 0x040079F2 RID: 31218
		[Token(Token = "0x40079F2")]
		public const short DuckWhite = 364;

		// Token: 0x040079F3 RID: 31219
		[Token(Token = "0x40079F3")]
		public const short DuckWhite2 = 365;

		// Token: 0x040079F4 RID: 31220
		[Token(Token = "0x40079F4")]
		public const short ScorpionBlack = 366;

		// Token: 0x040079F5 RID: 31221
		[Token(Token = "0x40079F5")]
		public const short Scorpion = 367;

		// Token: 0x040079F6 RID: 31222
		[Token(Token = "0x40079F6")]
		public const short TravellingMerchant = 368;

		// Token: 0x040079F7 RID: 31223
		[Token(Token = "0x40079F7")]
		public const short Angler = 369;

		// Token: 0x040079F8 RID: 31224
		[Token(Token = "0x40079F8")]
		public const short DukeFishron = 370;

		// Token: 0x040079F9 RID: 31225
		[Token(Token = "0x40079F9")]
		public const short DetonatingBubble = 371;

		// Token: 0x040079FA RID: 31226
		[Token(Token = "0x40079FA")]
		public const short Sharkron = 372;

		// Token: 0x040079FB RID: 31227
		[Token(Token = "0x40079FB")]
		public const short Sharkron2 = 373;

		// Token: 0x040079FC RID: 31228
		[Token(Token = "0x40079FC")]
		public const short TruffleWorm = 374;

		// Token: 0x040079FD RID: 31229
		[Token(Token = "0x40079FD")]
		public const short TruffleWormDigger = 375;

		// Token: 0x040079FE RID: 31230
		[Token(Token = "0x40079FE")]
		public const short SleepingAngler = 376;

		// Token: 0x040079FF RID: 31231
		[Token(Token = "0x40079FF")]
		public const short Grasshopper = 377;

		// Token: 0x04007A00 RID: 31232
		[Token(Token = "0x4007A00")]
		public const short ChatteringTeethBomb = 378;

		// Token: 0x04007A01 RID: 31233
		[Token(Token = "0x4007A01")]
		public const short CultistArcherBlue = 379;

		// Token: 0x04007A02 RID: 31234
		[Token(Token = "0x4007A02")]
		public const short CultistArcherWhite = 380;

		// Token: 0x04007A03 RID: 31235
		[Token(Token = "0x4007A03")]
		public const short BrainScrambler = 381;

		// Token: 0x04007A04 RID: 31236
		[Token(Token = "0x4007A04")]
		public const short RayGunner = 382;

		// Token: 0x04007A05 RID: 31237
		[Token(Token = "0x4007A05")]
		public const short MartianOfficer = 383;

		// Token: 0x04007A06 RID: 31238
		[Token(Token = "0x4007A06")]
		public const short ForceBubble = 384;

		// Token: 0x04007A07 RID: 31239
		[Token(Token = "0x4007A07")]
		public const short GrayGrunt = 385;

		// Token: 0x04007A08 RID: 31240
		[Token(Token = "0x4007A08")]
		public const short MartianEngineer = 386;

		// Token: 0x04007A09 RID: 31241
		[Token(Token = "0x4007A09")]
		public const short MartianTurret = 387;

		// Token: 0x04007A0A RID: 31242
		[Token(Token = "0x4007A0A")]
		public const short MartianDrone = 388;

		// Token: 0x04007A0B RID: 31243
		[Token(Token = "0x4007A0B")]
		public const short GigaZapper = 389;

		// Token: 0x04007A0C RID: 31244
		[Token(Token = "0x4007A0C")]
		public const short ScutlixRider = 390;

		// Token: 0x04007A0D RID: 31245
		[Token(Token = "0x4007A0D")]
		public const short Scutlix = 391;

		// Token: 0x04007A0E RID: 31246
		[Token(Token = "0x4007A0E")]
		public const short MartianSaucer = 392;

		// Token: 0x04007A0F RID: 31247
		[Token(Token = "0x4007A0F")]
		public const short MartianSaucerTurret = 393;

		// Token: 0x04007A10 RID: 31248
		[Token(Token = "0x4007A10")]
		public const short MartianSaucerCannon = 394;

		// Token: 0x04007A11 RID: 31249
		[Token(Token = "0x4007A11")]
		public const short MartianSaucerCore = 395;

		// Token: 0x04007A12 RID: 31250
		[Token(Token = "0x4007A12")]
		public const short MoonLordHead = 396;

		// Token: 0x04007A13 RID: 31251
		[Token(Token = "0x4007A13")]
		public const short MoonLordHand = 397;

		// Token: 0x04007A14 RID: 31252
		[Token(Token = "0x4007A14")]
		public const short MoonLordCore = 398;

		// Token: 0x04007A15 RID: 31253
		[Token(Token = "0x4007A15")]
		public const short MartianProbe = 399;

		// Token: 0x04007A16 RID: 31254
		[Token(Token = "0x4007A16")]
		public const short MoonLordFreeEye = 400;

		// Token: 0x04007A17 RID: 31255
		[Token(Token = "0x4007A17")]
		public const short MoonLordLeechBlob = 401;

		// Token: 0x04007A18 RID: 31256
		[Token(Token = "0x4007A18")]
		public const short StardustWormHead = 402;

		// Token: 0x04007A19 RID: 31257
		[Token(Token = "0x4007A19")]
		public const short StardustWormBody = 403;

		// Token: 0x04007A1A RID: 31258
		[Token(Token = "0x4007A1A")]
		public const short StardustWormTail = 404;

		// Token: 0x04007A1B RID: 31259
		[Token(Token = "0x4007A1B")]
		public const short StardustCellBig = 405;

		// Token: 0x04007A1C RID: 31260
		[Token(Token = "0x4007A1C")]
		public const short StardustCellSmall = 406;

		// Token: 0x04007A1D RID: 31261
		[Token(Token = "0x4007A1D")]
		public const short StardustJellyfishBig = 407;

		// Token: 0x04007A1E RID: 31262
		[Token(Token = "0x4007A1E")]
		public const short StardustJellyfishSmall = 408;

		// Token: 0x04007A1F RID: 31263
		[Token(Token = "0x4007A1F")]
		public const short StardustSpiderBig = 409;

		// Token: 0x04007A20 RID: 31264
		[Token(Token = "0x4007A20")]
		public const short StardustSpiderSmall = 410;

		// Token: 0x04007A21 RID: 31265
		[Token(Token = "0x4007A21")]
		public const short StardustSoldier = 411;

		// Token: 0x04007A22 RID: 31266
		[Token(Token = "0x4007A22")]
		public const short SolarCrawltipedeHead = 412;

		// Token: 0x04007A23 RID: 31267
		[Token(Token = "0x4007A23")]
		public const short SolarCrawltipedeBody = 413;

		// Token: 0x04007A24 RID: 31268
		[Token(Token = "0x4007A24")]
		public const short SolarCrawltipedeTail = 414;

		// Token: 0x04007A25 RID: 31269
		[Token(Token = "0x4007A25")]
		public const short SolarDrakomire = 415;

		// Token: 0x04007A26 RID: 31270
		[Token(Token = "0x4007A26")]
		public const short SolarDrakomireRider = 416;

		// Token: 0x04007A27 RID: 31271
		[Token(Token = "0x4007A27")]
		public const short SolarSroller = 417;

		// Token: 0x04007A28 RID: 31272
		[Token(Token = "0x4007A28")]
		public const short SolarCorite = 418;

		// Token: 0x04007A29 RID: 31273
		[Token(Token = "0x4007A29")]
		public const short SolarSolenian = 419;

		// Token: 0x04007A2A RID: 31274
		[Token(Token = "0x4007A2A")]
		public const short NebulaBrain = 420;

		// Token: 0x04007A2B RID: 31275
		[Token(Token = "0x4007A2B")]
		public const short NebulaHeadcrab = 421;

		// Token: 0x04007A2C RID: 31276
		[Token(Token = "0x4007A2C")]
		public const short NebulaBeast = 423;

		// Token: 0x04007A2D RID: 31277
		[Token(Token = "0x4007A2D")]
		public const short NebulaSoldier = 424;

		// Token: 0x04007A2E RID: 31278
		[Token(Token = "0x4007A2E")]
		public const short VortexRifleman = 425;

		// Token: 0x04007A2F RID: 31279
		[Token(Token = "0x4007A2F")]
		public const short VortexHornetQueen = 426;

		// Token: 0x04007A30 RID: 31280
		[Token(Token = "0x4007A30")]
		public const short VortexHornet = 427;

		// Token: 0x04007A31 RID: 31281
		[Token(Token = "0x4007A31")]
		public const short VortexLarva = 428;

		// Token: 0x04007A32 RID: 31282
		[Token(Token = "0x4007A32")]
		public const short VortexSoldier = 429;

		// Token: 0x04007A33 RID: 31283
		[Token(Token = "0x4007A33")]
		public const short ArmedZombie = 430;

		// Token: 0x04007A34 RID: 31284
		[Token(Token = "0x4007A34")]
		public const short ArmedZombieEskimo = 431;

		// Token: 0x04007A35 RID: 31285
		[Token(Token = "0x4007A35")]
		public const short ArmedZombiePincussion = 432;

		// Token: 0x04007A36 RID: 31286
		[Token(Token = "0x4007A36")]
		public const short ArmedZombieSlimed = 433;

		// Token: 0x04007A37 RID: 31287
		[Token(Token = "0x4007A37")]
		public const short ArmedZombieSwamp = 434;

		// Token: 0x04007A38 RID: 31288
		[Token(Token = "0x4007A38")]
		public const short ArmedZombieTwiggy = 435;

		// Token: 0x04007A39 RID: 31289
		[Token(Token = "0x4007A39")]
		public const short ArmedZombieCenx = 436;

		// Token: 0x04007A3A RID: 31290
		[Token(Token = "0x4007A3A")]
		public const short CultistTablet = 437;

		// Token: 0x04007A3B RID: 31291
		[Token(Token = "0x4007A3B")]
		public const short CultistDevote = 438;

		// Token: 0x04007A3C RID: 31292
		[Token(Token = "0x4007A3C")]
		public const short CultistBoss = 439;

		// Token: 0x04007A3D RID: 31293
		[Token(Token = "0x4007A3D")]
		public const short CultistBossClone = 440;

		// Token: 0x04007A3E RID: 31294
		[Token(Token = "0x4007A3E")]
		public const short GoldBird = 442;

		// Token: 0x04007A3F RID: 31295
		[Token(Token = "0x4007A3F")]
		public const short GoldBunny = 443;

		// Token: 0x04007A40 RID: 31296
		[Token(Token = "0x4007A40")]
		public const short GoldButterfly = 444;

		// Token: 0x04007A41 RID: 31297
		[Token(Token = "0x4007A41")]
		public const short GoldFrog = 445;

		// Token: 0x04007A42 RID: 31298
		[Token(Token = "0x4007A42")]
		public const short GoldGrasshopper = 446;

		// Token: 0x04007A43 RID: 31299
		[Token(Token = "0x4007A43")]
		public const short GoldMouse = 447;

		// Token: 0x04007A44 RID: 31300
		[Token(Token = "0x4007A44")]
		public const short GoldWorm = 448;

		// Token: 0x04007A45 RID: 31301
		[Token(Token = "0x4007A45")]
		public const short BoneThrowingSkeleton = 449;

		// Token: 0x04007A46 RID: 31302
		[Token(Token = "0x4007A46")]
		public const short BoneThrowingSkeleton2 = 450;

		// Token: 0x04007A47 RID: 31303
		[Token(Token = "0x4007A47")]
		public const short BoneThrowingSkeleton3 = 451;

		// Token: 0x04007A48 RID: 31304
		[Token(Token = "0x4007A48")]
		public const short BoneThrowingSkeleton4 = 452;

		// Token: 0x04007A49 RID: 31305
		[Token(Token = "0x4007A49")]
		public const short SkeletonMerchant = 453;

		// Token: 0x04007A4A RID: 31306
		[Token(Token = "0x4007A4A")]
		public const short CultistDragonHead = 454;

		// Token: 0x04007A4B RID: 31307
		[Token(Token = "0x4007A4B")]
		public const short CultistDragonBody1 = 455;

		// Token: 0x04007A4C RID: 31308
		[Token(Token = "0x4007A4C")]
		public const short CultistDragonBody2 = 456;

		// Token: 0x04007A4D RID: 31309
		[Token(Token = "0x4007A4D")]
		public const short CultistDragonBody3 = 457;

		// Token: 0x04007A4E RID: 31310
		[Token(Token = "0x4007A4E")]
		public const short CultistDragonBody4 = 458;

		// Token: 0x04007A4F RID: 31311
		[Token(Token = "0x4007A4F")]
		public const short CultistDragonTail = 459;

		// Token: 0x04007A50 RID: 31312
		[Token(Token = "0x4007A50")]
		public const short Butcher = 460;

		// Token: 0x04007A51 RID: 31313
		[Token(Token = "0x4007A51")]
		public const short CreatureFromTheDeep = 461;

		// Token: 0x04007A52 RID: 31314
		[Token(Token = "0x4007A52")]
		public const short Fritz = 462;

		// Token: 0x04007A53 RID: 31315
		[Token(Token = "0x4007A53")]
		public const short Nailhead = 463;

		// Token: 0x04007A54 RID: 31316
		[Token(Token = "0x4007A54")]
		public const short CrimsonBunny = 464;

		// Token: 0x04007A55 RID: 31317
		[Token(Token = "0x4007A55")]
		public const short CrimsonGoldfish = 465;

		// Token: 0x04007A56 RID: 31318
		[Token(Token = "0x4007A56")]
		public const short Psycho = 466;

		// Token: 0x04007A57 RID: 31319
		[Token(Token = "0x4007A57")]
		public const short DeadlySphere = 467;

		// Token: 0x04007A58 RID: 31320
		[Token(Token = "0x4007A58")]
		public const short DrManFly = 468;

		// Token: 0x04007A59 RID: 31321
		[Token(Token = "0x4007A59")]
		public const short ThePossessed = 469;

		// Token: 0x04007A5A RID: 31322
		[Token(Token = "0x4007A5A")]
		public const short CrimsonPenguin = 470;

		// Token: 0x04007A5B RID: 31323
		[Token(Token = "0x4007A5B")]
		public const short GoblinSummoner = 471;

		// Token: 0x04007A5C RID: 31324
		[Token(Token = "0x4007A5C")]
		public const short ShadowFlameApparition = 472;

		// Token: 0x04007A5D RID: 31325
		[Token(Token = "0x4007A5D")]
		public const short BigMimicCorruption = 473;

		// Token: 0x04007A5E RID: 31326
		[Token(Token = "0x4007A5E")]
		public const short BigMimicCrimson = 474;

		// Token: 0x04007A5F RID: 31327
		[Token(Token = "0x4007A5F")]
		public const short BigMimicHallow = 475;

		// Token: 0x04007A60 RID: 31328
		[Token(Token = "0x4007A60")]
		public const short BigMimicJungle = 476;

		// Token: 0x04007A61 RID: 31329
		[Token(Token = "0x4007A61")]
		public const short Mothron = 477;

		// Token: 0x04007A62 RID: 31330
		[Token(Token = "0x4007A62")]
		public const short MothronEgg = 478;

		// Token: 0x04007A63 RID: 31331
		[Token(Token = "0x4007A63")]
		public const short MothronSpawn = 479;

		// Token: 0x04007A64 RID: 31332
		[Token(Token = "0x4007A64")]
		public const short Medusa = 480;

		// Token: 0x04007A65 RID: 31333
		[Token(Token = "0x4007A65")]
		public const short GreekSkeleton = 481;

		// Token: 0x04007A66 RID: 31334
		[Token(Token = "0x4007A66")]
		public const short GraniteGolem = 482;

		// Token: 0x04007A67 RID: 31335
		[Token(Token = "0x4007A67")]
		public const short GraniteFlyer = 483;

		// Token: 0x04007A68 RID: 31336
		[Token(Token = "0x4007A68")]
		public const short EnchantedNightcrawler = 484;

		// Token: 0x04007A69 RID: 31337
		[Token(Token = "0x4007A69")]
		public const short Grubby = 485;

		// Token: 0x04007A6A RID: 31338
		[Token(Token = "0x4007A6A")]
		public const short Sluggy = 486;

		// Token: 0x04007A6B RID: 31339
		[Token(Token = "0x4007A6B")]
		public const short Buggy = 487;

		// Token: 0x04007A6C RID: 31340
		[Token(Token = "0x4007A6C")]
		public const short TargetDummy = 488;

		// Token: 0x04007A6D RID: 31341
		[Token(Token = "0x4007A6D")]
		public const short BloodZombie = 489;

		// Token: 0x04007A6E RID: 31342
		[Token(Token = "0x4007A6E")]
		public const short Drippler = 490;

		// Token: 0x04007A6F RID: 31343
		[Token(Token = "0x4007A6F")]
		public const short PirateShip = 491;

		// Token: 0x04007A70 RID: 31344
		[Token(Token = "0x4007A70")]
		public const short PirateShipCannon = 492;

		// Token: 0x04007A71 RID: 31345
		[Token(Token = "0x4007A71")]
		public const short LunarTowerStardust = 493;

		// Token: 0x04007A72 RID: 31346
		[Token(Token = "0x4007A72")]
		public const short Crawdad = 494;

		// Token: 0x04007A73 RID: 31347
		[Token(Token = "0x4007A73")]
		public const short Crawdad2 = 495;

		// Token: 0x04007A74 RID: 31348
		[Token(Token = "0x4007A74")]
		public const short GiantShelly = 496;

		// Token: 0x04007A75 RID: 31349
		[Token(Token = "0x4007A75")]
		public const short GiantShelly2 = 497;

		// Token: 0x04007A76 RID: 31350
		[Token(Token = "0x4007A76")]
		public const short Salamander = 498;

		// Token: 0x04007A77 RID: 31351
		[Token(Token = "0x4007A77")]
		public const short Salamander2 = 499;

		// Token: 0x04007A78 RID: 31352
		[Token(Token = "0x4007A78")]
		public const short Salamander3 = 500;

		// Token: 0x04007A79 RID: 31353
		[Token(Token = "0x4007A79")]
		public const short Salamander4 = 501;

		// Token: 0x04007A7A RID: 31354
		[Token(Token = "0x4007A7A")]
		public const short Salamander5 = 502;

		// Token: 0x04007A7B RID: 31355
		[Token(Token = "0x4007A7B")]
		public const short Salamander6 = 503;

		// Token: 0x04007A7C RID: 31356
		[Token(Token = "0x4007A7C")]
		public const short Salamander7 = 504;

		// Token: 0x04007A7D RID: 31357
		[Token(Token = "0x4007A7D")]
		public const short Salamander8 = 505;

		// Token: 0x04007A7E RID: 31358
		[Token(Token = "0x4007A7E")]
		public const short Salamander9 = 506;

		// Token: 0x04007A7F RID: 31359
		[Token(Token = "0x4007A7F")]
		public const short LunarTowerNebula = 507;

		// Token: 0x04007A80 RID: 31360
		[Token(Token = "0x4007A80")]
		public const short LunarTowerVortex = 422;

		// Token: 0x04007A81 RID: 31361
		[Token(Token = "0x4007A81")]
		public const short TaxCollector = 441;

		// Token: 0x04007A82 RID: 31362
		[Token(Token = "0x4007A82")]
		public const short GiantWalkingAntlion = 508;

		// Token: 0x04007A83 RID: 31363
		[Token(Token = "0x4007A83")]
		public const short GiantFlyingAntlion = 509;

		// Token: 0x04007A84 RID: 31364
		[Token(Token = "0x4007A84")]
		public const short DuneSplicerHead = 510;

		// Token: 0x04007A85 RID: 31365
		[Token(Token = "0x4007A85")]
		public const short DuneSplicerBody = 511;

		// Token: 0x04007A86 RID: 31366
		[Token(Token = "0x4007A86")]
		public const short DuneSplicerTail = 512;

		// Token: 0x04007A87 RID: 31367
		[Token(Token = "0x4007A87")]
		public const short TombCrawlerHead = 513;

		// Token: 0x04007A88 RID: 31368
		[Token(Token = "0x4007A88")]
		public const short TombCrawlerBody = 514;

		// Token: 0x04007A89 RID: 31369
		[Token(Token = "0x4007A89")]
		public const short TombCrawlerTail = 515;

		// Token: 0x04007A8A RID: 31370
		[Token(Token = "0x4007A8A")]
		public const short SolarFlare = 516;

		// Token: 0x04007A8B RID: 31371
		[Token(Token = "0x4007A8B")]
		public const short LunarTowerSolar = 517;

		// Token: 0x04007A8C RID: 31372
		[Token(Token = "0x4007A8C")]
		public const short SolarSpearman = 518;

		// Token: 0x04007A8D RID: 31373
		[Token(Token = "0x4007A8D")]
		public const short SolarGoop = 519;

		// Token: 0x04007A8E RID: 31374
		[Token(Token = "0x4007A8E")]
		public const short MartianWalker = 520;

		// Token: 0x04007A8F RID: 31375
		[Token(Token = "0x4007A8F")]
		public const short AncientCultistSquidhead = 521;

		// Token: 0x04007A90 RID: 31376
		[Token(Token = "0x4007A90")]
		public const short AncientLight = 522;

		// Token: 0x04007A91 RID: 31377
		[Token(Token = "0x4007A91")]
		public const short AncientDoom = 523;

		// Token: 0x04007A92 RID: 31378
		[Token(Token = "0x4007A92")]
		public const short DesertGhoul = 524;

		// Token: 0x04007A93 RID: 31379
		[Token(Token = "0x4007A93")]
		public const short DesertGhoulCorruption = 525;

		// Token: 0x04007A94 RID: 31380
		[Token(Token = "0x4007A94")]
		public const short DesertGhoulCrimson = 526;

		// Token: 0x04007A95 RID: 31381
		[Token(Token = "0x4007A95")]
		public const short DesertGhoulHallow = 527;

		// Token: 0x04007A96 RID: 31382
		[Token(Token = "0x4007A96")]
		public const short DesertLamiaLight = 528;

		// Token: 0x04007A97 RID: 31383
		[Token(Token = "0x4007A97")]
		public const short DesertLamiaDark = 529;

		// Token: 0x04007A98 RID: 31384
		[Token(Token = "0x4007A98")]
		public const short DesertScorpionWalk = 530;

		// Token: 0x04007A99 RID: 31385
		[Token(Token = "0x4007A99")]
		public const short DesertScorpionWall = 531;

		// Token: 0x04007A9A RID: 31386
		[Token(Token = "0x4007A9A")]
		public const short DesertBeast = 532;

		// Token: 0x04007A9B RID: 31387
		[Token(Token = "0x4007A9B")]
		public const short DesertDjinn = 533;

		// Token: 0x04007A9C RID: 31388
		[Token(Token = "0x4007A9C")]
		public const short DemonTaxCollector = 534;

		// Token: 0x04007A9D RID: 31389
		[Token(Token = "0x4007A9D")]
		public const short SlimeSpiked = 535;

		// Token: 0x04007A9E RID: 31390
		[Token(Token = "0x4007A9E")]
		public const short TheBride = 536;

		// Token: 0x04007A9F RID: 31391
		[Token(Token = "0x4007A9F")]
		public const short SandSlime = 537;

		// Token: 0x04007AA0 RID: 31392
		[Token(Token = "0x4007AA0")]
		public const short SquirrelRed = 538;

		// Token: 0x04007AA1 RID: 31393
		[Token(Token = "0x4007AA1")]
		public const short SquirrelGold = 539;

		// Token: 0x04007AA2 RID: 31394
		[Token(Token = "0x4007AA2")]
		public const short PartyBunny = 540;

		// Token: 0x04007AA3 RID: 31395
		[Token(Token = "0x4007AA3")]
		public const short SandElemental = 541;

		// Token: 0x04007AA4 RID: 31396
		[Token(Token = "0x4007AA4")]
		public const short SandShark = 542;

		// Token: 0x04007AA5 RID: 31397
		[Token(Token = "0x4007AA5")]
		public const short SandsharkCorrupt = 543;

		// Token: 0x04007AA6 RID: 31398
		[Token(Token = "0x4007AA6")]
		public const short SandsharkCrimson = 544;

		// Token: 0x04007AA7 RID: 31399
		[Token(Token = "0x4007AA7")]
		public const short SandsharkHallow = 545;

		// Token: 0x04007AA8 RID: 31400
		[Token(Token = "0x4007AA8")]
		public const short Tumbleweed = 546;

		// Token: 0x04007AA9 RID: 31401
		[Token(Token = "0x4007AA9")]
		public const short DD2AttackerTest = 547;

		// Token: 0x04007AAA RID: 31402
		[Token(Token = "0x4007AAA")]
		public const short DD2EterniaCrystal = 548;

		// Token: 0x04007AAB RID: 31403
		[Token(Token = "0x4007AAB")]
		public const short DD2LanePortal = 549;

		// Token: 0x04007AAC RID: 31404
		[Token(Token = "0x4007AAC")]
		public const short DD2Bartender = 550;

		// Token: 0x04007AAD RID: 31405
		[Token(Token = "0x4007AAD")]
		public const short DD2Betsy = 551;

		// Token: 0x04007AAE RID: 31406
		[Token(Token = "0x4007AAE")]
		public const short DD2GoblinT1 = 552;

		// Token: 0x04007AAF RID: 31407
		[Token(Token = "0x4007AAF")]
		public const short DD2GoblinT2 = 553;

		// Token: 0x04007AB0 RID: 31408
		[Token(Token = "0x4007AB0")]
		public const short DD2GoblinT3 = 554;

		// Token: 0x04007AB1 RID: 31409
		[Token(Token = "0x4007AB1")]
		public const short DD2GoblinBomberT1 = 555;

		// Token: 0x04007AB2 RID: 31410
		[Token(Token = "0x4007AB2")]
		public const short DD2GoblinBomberT2 = 556;

		// Token: 0x04007AB3 RID: 31411
		[Token(Token = "0x4007AB3")]
		public const short DD2GoblinBomberT3 = 557;

		// Token: 0x04007AB4 RID: 31412
		[Token(Token = "0x4007AB4")]
		public const short DD2WyvernT1 = 558;

		// Token: 0x04007AB5 RID: 31413
		[Token(Token = "0x4007AB5")]
		public const short DD2WyvernT2 = 559;

		// Token: 0x04007AB6 RID: 31414
		[Token(Token = "0x4007AB6")]
		public const short DD2WyvernT3 = 560;

		// Token: 0x04007AB7 RID: 31415
		[Token(Token = "0x4007AB7")]
		public const short DD2JavelinstT1 = 561;

		// Token: 0x04007AB8 RID: 31416
		[Token(Token = "0x4007AB8")]
		public const short DD2JavelinstT2 = 562;

		// Token: 0x04007AB9 RID: 31417
		[Token(Token = "0x4007AB9")]
		public const short DD2JavelinstT3 = 563;

		// Token: 0x04007ABA RID: 31418
		[Token(Token = "0x4007ABA")]
		public const short DD2DarkMageT1 = 564;

		// Token: 0x04007ABB RID: 31419
		[Token(Token = "0x4007ABB")]
		public const short DD2DarkMageT3 = 565;

		// Token: 0x04007ABC RID: 31420
		[Token(Token = "0x4007ABC")]
		public const short DD2SkeletonT1 = 566;

		// Token: 0x04007ABD RID: 31421
		[Token(Token = "0x4007ABD")]
		public const short DD2SkeletonT3 = 567;

		// Token: 0x04007ABE RID: 31422
		[Token(Token = "0x4007ABE")]
		public const short DD2WitherBeastT2 = 568;

		// Token: 0x04007ABF RID: 31423
		[Token(Token = "0x4007ABF")]
		public const short DD2WitherBeastT3 = 569;

		// Token: 0x04007AC0 RID: 31424
		[Token(Token = "0x4007AC0")]
		public const short DD2DrakinT2 = 570;

		// Token: 0x04007AC1 RID: 31425
		[Token(Token = "0x4007AC1")]
		public const short DD2DrakinT3 = 571;

		// Token: 0x04007AC2 RID: 31426
		[Token(Token = "0x4007AC2")]
		public const short DD2KoboldWalkerT2 = 572;

		// Token: 0x04007AC3 RID: 31427
		[Token(Token = "0x4007AC3")]
		public const short DD2KoboldWalkerT3 = 573;

		// Token: 0x04007AC4 RID: 31428
		[Token(Token = "0x4007AC4")]
		public const short DD2KoboldFlyerT2 = 574;

		// Token: 0x04007AC5 RID: 31429
		[Token(Token = "0x4007AC5")]
		public const short DD2KoboldFlyerT3 = 575;

		// Token: 0x04007AC6 RID: 31430
		[Token(Token = "0x4007AC6")]
		public const short DD2OgreT2 = 576;

		// Token: 0x04007AC7 RID: 31431
		[Token(Token = "0x4007AC7")]
		public const short DD2OgreT3 = 577;

		// Token: 0x04007AC8 RID: 31432
		[Token(Token = "0x4007AC8")]
		public const short DD2LightningBugT3 = 578;

		// Token: 0x04007AC9 RID: 31433
		[Token(Token = "0x4007AC9")]
		public const short BartenderUnconscious = 579;

		// Token: 0x04007ACA RID: 31434
		[Token(Token = "0x4007ACA")]
		public const short WalkingAntlion = 580;

		// Token: 0x04007ACB RID: 31435
		[Token(Token = "0x4007ACB")]
		public const short FlyingAntlion = 581;

		// Token: 0x04007ACC RID: 31436
		[Token(Token = "0x4007ACC")]
		public const short LarvaeAntlion = 582;

		// Token: 0x04007ACD RID: 31437
		[Token(Token = "0x4007ACD")]
		public const short FairyCritterPink = 583;

		// Token: 0x04007ACE RID: 31438
		[Token(Token = "0x4007ACE")]
		public const short FairyCritterGreen = 584;

		// Token: 0x04007ACF RID: 31439
		[Token(Token = "0x4007ACF")]
		public const short FairyCritterBlue = 585;

		// Token: 0x04007AD0 RID: 31440
		[Token(Token = "0x4007AD0")]
		public const short ZombieMerman = 586;

		// Token: 0x04007AD1 RID: 31441
		[Token(Token = "0x4007AD1")]
		public const short EyeballFlyingFish = 587;

		// Token: 0x04007AD2 RID: 31442
		[Token(Token = "0x4007AD2")]
		public const short Golfer = 588;

		// Token: 0x04007AD3 RID: 31443
		[Token(Token = "0x4007AD3")]
		public const short GolferRescue = 589;

		// Token: 0x04007AD4 RID: 31444
		[Token(Token = "0x4007AD4")]
		public const short TorchZombie = 590;

		// Token: 0x04007AD5 RID: 31445
		[Token(Token = "0x4007AD5")]
		public const short ArmedTorchZombie = 591;

		// Token: 0x04007AD6 RID: 31446
		[Token(Token = "0x4007AD6")]
		public const short GoldGoldfish = 592;

		// Token: 0x04007AD7 RID: 31447
		[Token(Token = "0x4007AD7")]
		public const short GoldGoldfishWalker = 593;

		// Token: 0x04007AD8 RID: 31448
		[Token(Token = "0x4007AD8")]
		public const short WindyBalloon = 594;

		// Token: 0x04007AD9 RID: 31449
		[Token(Token = "0x4007AD9")]
		public const short BlackDragonfly = 595;

		// Token: 0x04007ADA RID: 31450
		[Token(Token = "0x4007ADA")]
		public const short BlueDragonfly = 596;

		// Token: 0x04007ADB RID: 31451
		[Token(Token = "0x4007ADB")]
		public const short GreenDragonfly = 597;

		// Token: 0x04007ADC RID: 31452
		[Token(Token = "0x4007ADC")]
		public const short OrangeDragonfly = 598;

		// Token: 0x04007ADD RID: 31453
		[Token(Token = "0x4007ADD")]
		public const short RedDragonfly = 599;

		// Token: 0x04007ADE RID: 31454
		[Token(Token = "0x4007ADE")]
		public const short YellowDragonfly = 600;

		// Token: 0x04007ADF RID: 31455
		[Token(Token = "0x4007ADF")]
		public const short GoldDragonfly = 601;

		// Token: 0x04007AE0 RID: 31456
		[Token(Token = "0x4007AE0")]
		public const short Seagull = 602;

		// Token: 0x04007AE1 RID: 31457
		[Token(Token = "0x4007AE1")]
		public const short Seagull2 = 603;

		// Token: 0x04007AE2 RID: 31458
		[Token(Token = "0x4007AE2")]
		public const short LadyBug = 604;

		// Token: 0x04007AE3 RID: 31459
		[Token(Token = "0x4007AE3")]
		public const short GoldLadyBug = 605;

		// Token: 0x04007AE4 RID: 31460
		[Token(Token = "0x4007AE4")]
		public const short Maggot = 606;

		// Token: 0x04007AE5 RID: 31461
		[Token(Token = "0x4007AE5")]
		public const short Pupfish = 607;

		// Token: 0x04007AE6 RID: 31462
		[Token(Token = "0x4007AE6")]
		public const short Grebe = 608;

		// Token: 0x04007AE7 RID: 31463
		[Token(Token = "0x4007AE7")]
		public const short Grebe2 = 609;

		// Token: 0x04007AE8 RID: 31464
		[Token(Token = "0x4007AE8")]
		public const short Rat = 610;

		// Token: 0x04007AE9 RID: 31465
		[Token(Token = "0x4007AE9")]
		public const short Owl = 611;

		// Token: 0x04007AEA RID: 31466
		[Token(Token = "0x4007AEA")]
		public const short WaterStrider = 612;

		// Token: 0x04007AEB RID: 31467
		[Token(Token = "0x4007AEB")]
		public const short GoldWaterStrider = 613;

		// Token: 0x04007AEC RID: 31468
		[Token(Token = "0x4007AEC")]
		public const short ExplosiveBunny = 614;

		// Token: 0x04007AED RID: 31469
		[Token(Token = "0x4007AED")]
		public const short Dolphin = 615;

		// Token: 0x04007AEE RID: 31470
		[Token(Token = "0x4007AEE")]
		public const short Turtle = 616;

		// Token: 0x04007AEF RID: 31471
		[Token(Token = "0x4007AEF")]
		public const short TurtleJungle = 617;

		// Token: 0x04007AF0 RID: 31472
		[Token(Token = "0x4007AF0")]
		public const short BloodNautilus = 618;

		// Token: 0x04007AF1 RID: 31473
		[Token(Token = "0x4007AF1")]
		public const short BloodSquid = 619;

		// Token: 0x04007AF2 RID: 31474
		[Token(Token = "0x4007AF2")]
		public const short GoblinShark = 620;

		// Token: 0x04007AF3 RID: 31475
		[Token(Token = "0x4007AF3")]
		public const short BloodEelHead = 621;

		// Token: 0x04007AF4 RID: 31476
		[Token(Token = "0x4007AF4")]
		public const short BloodEelBody = 622;

		// Token: 0x04007AF5 RID: 31477
		[Token(Token = "0x4007AF5")]
		public const short BloodEelTail = 623;

		// Token: 0x04007AF6 RID: 31478
		[Token(Token = "0x4007AF6")]
		public const short Gnome = 624;

		// Token: 0x04007AF7 RID: 31479
		[Token(Token = "0x4007AF7")]
		public const short SeaTurtle = 625;

		// Token: 0x04007AF8 RID: 31480
		[Token(Token = "0x4007AF8")]
		public const short Seahorse = 626;

		// Token: 0x04007AF9 RID: 31481
		[Token(Token = "0x4007AF9")]
		public const short GoldSeahorse = 627;

		// Token: 0x04007AFA RID: 31482
		[Token(Token = "0x4007AFA")]
		public const short Dandelion = 628;

		// Token: 0x04007AFB RID: 31483
		[Token(Token = "0x4007AFB")]
		public const short IceMimic = 629;

		// Token: 0x04007AFC RID: 31484
		[Token(Token = "0x4007AFC")]
		public const short BloodMummy = 630;

		// Token: 0x04007AFD RID: 31485
		[Token(Token = "0x4007AFD")]
		public const short RockGolem = 631;

		// Token: 0x04007AFE RID: 31486
		[Token(Token = "0x4007AFE")]
		public const short MaggotZombie = 632;

		// Token: 0x04007AFF RID: 31487
		[Token(Token = "0x4007AFF")]
		public const short BestiaryGirl = 633;

		// Token: 0x04007B00 RID: 31488
		[Token(Token = "0x4007B00")]
		public const short SporeBat = 634;

		// Token: 0x04007B01 RID: 31489
		[Token(Token = "0x4007B01")]
		public const short SporeSkeleton = 635;

		// Token: 0x04007B02 RID: 31490
		[Token(Token = "0x4007B02")]
		public const short HallowBoss = 636;

		// Token: 0x04007B03 RID: 31491
		[Token(Token = "0x4007B03")]
		public const short TownCat = 637;

		// Token: 0x04007B04 RID: 31492
		[Token(Token = "0x4007B04")]
		public const short TownDog = 638;

		// Token: 0x04007B05 RID: 31493
		[Token(Token = "0x4007B05")]
		public const short GemSquirrelAmethyst = 639;

		// Token: 0x04007B06 RID: 31494
		[Token(Token = "0x4007B06")]
		public const short GemSquirrelTopaz = 640;

		// Token: 0x04007B07 RID: 31495
		[Token(Token = "0x4007B07")]
		public const short GemSquirrelSapphire = 641;

		// Token: 0x04007B08 RID: 31496
		[Token(Token = "0x4007B08")]
		public const short GemSquirrelEmerald = 642;

		// Token: 0x04007B09 RID: 31497
		[Token(Token = "0x4007B09")]
		public const short GemSquirrelRuby = 643;

		// Token: 0x04007B0A RID: 31498
		[Token(Token = "0x4007B0A")]
		public const short GemSquirrelDiamond = 644;

		// Token: 0x04007B0B RID: 31499
		[Token(Token = "0x4007B0B")]
		public const short GemSquirrelAmber = 645;

		// Token: 0x04007B0C RID: 31500
		[Token(Token = "0x4007B0C")]
		public const short GemBunnyAmethyst = 646;

		// Token: 0x04007B0D RID: 31501
		[Token(Token = "0x4007B0D")]
		public const short GemBunnyTopaz = 647;

		// Token: 0x04007B0E RID: 31502
		[Token(Token = "0x4007B0E")]
		public const short GemBunnySapphire = 648;

		// Token: 0x04007B0F RID: 31503
		[Token(Token = "0x4007B0F")]
		public const short GemBunnyEmerald = 649;

		// Token: 0x04007B10 RID: 31504
		[Token(Token = "0x4007B10")]
		public const short GemBunnyRuby = 650;

		// Token: 0x04007B11 RID: 31505
		[Token(Token = "0x4007B11")]
		public const short GemBunnyDiamond = 651;

		// Token: 0x04007B12 RID: 31506
		[Token(Token = "0x4007B12")]
		public const short GemBunnyAmber = 652;

		// Token: 0x04007B13 RID: 31507
		[Token(Token = "0x4007B13")]
		public const short HellButterfly = 653;

		// Token: 0x04007B14 RID: 31508
		[Token(Token = "0x4007B14")]
		public const short Lavafly = 654;

		// Token: 0x04007B15 RID: 31509
		[Token(Token = "0x4007B15")]
		public const short MagmaSnail = 655;

		// Token: 0x04007B16 RID: 31510
		[Token(Token = "0x4007B16")]
		public const short TownBunny = 656;

		// Token: 0x04007B17 RID: 31511
		[Token(Token = "0x4007B17")]
		public const short QueenSlimeBoss = 657;

		// Token: 0x04007B18 RID: 31512
		[Token(Token = "0x4007B18")]
		public const short QueenSlimeMinionBlue = 658;

		// Token: 0x04007B19 RID: 31513
		[Token(Token = "0x4007B19")]
		public const short QueenSlimeMinionPink = 659;

		// Token: 0x04007B1A RID: 31514
		[Token(Token = "0x4007B1A")]
		public const short QueenSlimeMinionPurple = 660;

		// Token: 0x04007B1B RID: 31515
		[Token(Token = "0x4007B1B")]
		public const short EmpressButterfly = 661;

		// Token: 0x04007B1C RID: 31516
		[Token(Token = "0x4007B1C")]
		public const short PirateGhost = 662;

		// Token: 0x04007B1D RID: 31517
		[Token(Token = "0x4007B1D")]
		public const short Princess = 663;

		// Token: 0x04007B1E RID: 31518
		[Token(Token = "0x4007B1E")]
		public const short TorchGod = 664;

		// Token: 0x04007B1F RID: 31519
		[Token(Token = "0x4007B1F")]
		public const short ChaosBallTim = 665;

		// Token: 0x04007B20 RID: 31520
		[Token(Token = "0x4007B20")]
		public const short VileSpitEaterOfWorlds = 666;

		// Token: 0x04007B21 RID: 31521
		[Token(Token = "0x4007B21")]
		public const short GoldenSlime = 667;

		// Token: 0x04007B22 RID: 31522
		[Token(Token = "0x4007B22")]
		public const short Deerclops = 668;

		// Token: 0x04007B23 RID: 31523
		[Token(Token = "0x4007B23")]
		public const short Stinkbug = 669;

		// Token: 0x04007B24 RID: 31524
		[Token(Token = "0x4007B24")]
		public const short TownSlimeBlue = 670;

		// Token: 0x04007B25 RID: 31525
		[Token(Token = "0x4007B25")]
		public const short ScarletMacaw = 671;

		// Token: 0x04007B26 RID: 31526
		[Token(Token = "0x4007B26")]
		public const short BlueMacaw = 672;

		// Token: 0x04007B27 RID: 31527
		[Token(Token = "0x4007B27")]
		public const short Toucan = 673;

		// Token: 0x04007B28 RID: 31528
		[Token(Token = "0x4007B28")]
		public const short YellowCockatiel = 674;

		// Token: 0x04007B29 RID: 31529
		[Token(Token = "0x4007B29")]
		public const short GrayCockatiel = 675;

		// Token: 0x04007B2A RID: 31530
		[Token(Token = "0x4007B2A")]
		public const short ShimmerSlime = 676;

		// Token: 0x04007B2B RID: 31531
		[Token(Token = "0x4007B2B")]
		public const short Shimmerfly = 677;

		// Token: 0x04007B2C RID: 31532
		[Token(Token = "0x4007B2C")]
		public const short TownSlimeGreen = 678;

		// Token: 0x04007B2D RID: 31533
		[Token(Token = "0x4007B2D")]
		public const short TownSlimeOld = 679;

		// Token: 0x04007B2E RID: 31534
		[Token(Token = "0x4007B2E")]
		public const short TownSlimePurple = 680;

		// Token: 0x04007B2F RID: 31535
		[Token(Token = "0x4007B2F")]
		public const short TownSlimeRainbow = 681;

		// Token: 0x04007B30 RID: 31536
		[Token(Token = "0x4007B30")]
		public const short TownSlimeRed = 682;

		// Token: 0x04007B31 RID: 31537
		[Token(Token = "0x4007B31")]
		public const short TownSlimeYellow = 683;

		// Token: 0x04007B32 RID: 31538
		[Token(Token = "0x4007B32")]
		public const short TownSlimeCopper = 684;

		// Token: 0x04007B33 RID: 31539
		[Token(Token = "0x4007B33")]
		public const short BoundTownSlimeOld = 685;

		// Token: 0x04007B34 RID: 31540
		[Token(Token = "0x4007B34")]
		public const short BoundTownSlimePurple = 686;

		// Token: 0x04007B35 RID: 31541
		[Token(Token = "0x4007B35")]
		public const short BoundTownSlimeYellow = 687;

		// Token: 0x04007B36 RID: 31542
		[Token(Token = "0x4007B36")]
		public const short Pufferfish = 688;

		// Token: 0x04007B37 RID: 31543
		[Token(Token = "0x4007B37")]
		public const short OwlMimic = 689;

		// Token: 0x04007B38 RID: 31544
		[Token(Token = "0x4007B38")]
		public const short StatueMimic = 690;

		// Token: 0x04007B39 RID: 31545
		[Token(Token = "0x4007B39")]
		public const short MossZombie = 691;

		// Token: 0x04007B3A RID: 31546
		[Token(Token = "0x4007B3A")]
		public const short Orca = 692;

		// Token: 0x04007B3B RID: 31547
		[Token(Token = "0x4007B3B")]
		public const short LibrarianSkeleton = 693;

		// Token: 0x04007B3C RID: 31548
		[Token(Token = "0x4007B3C")]
		public const short WaterBoltMimic = 694;

		// Token: 0x04007B3D RID: 31549
		[Token(Token = "0x4007B3D")]
		public const short PalworldCattivaDistressed = 695;

		// Token: 0x04007B3E RID: 31550
		[Token(Token = "0x4007B3E")]
		public const short PalworldFoxsparksDistressed = 696;

		// Token: 0x04007B3F RID: 31551
		[Token(Token = "0x4007B3F")]
		public const short Count = 697;

		// Token: 0x04007B40 RID: 31552
		[Token(Token = "0x4007B40")]
		[FieldOffset(Offset = "0x8")]
		public static readonly IdDictionary Search;

		// Token: 0x020006F5 RID: 1781
		[Token(Token = "0x20006F5")]
		public static class Sets
		{
			// Token: 0x060041A0 RID: 16800 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60041A0")]
			[Address(RVA = "0x1F6F890", Offset = "0x1F6F890", VA = "0x1F6F890")]
			public static NPCID.Sets.NPCPortraitSelector PrioritizedPortrait()
			{
				return null;
			}

			// Token: 0x060041A1 RID: 16801 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60041A1")]
			[Address(RVA = "0x1F6FA14", Offset = "0x1F6FA14", VA = "0x1F6FA14")]
			public static NPCID.Sets.BasicNPCPortrait BasicPortrait(string texturePath)
			{
				return null;
			}

			// Token: 0x060041A2 RID: 16802 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60041A2")]
			[Address(RVA = "0x1F6FAD4", Offset = "0x1F6FAD4", VA = "0x1F6FAD4")]
			public static NPCID.Sets.NPCPortraitSelector.SelectionCondition VariantPortraitCondition(int variantIndex)
			{
				return null;
			}

			// Token: 0x060041A3 RID: 16803 RVA: 0x00020148 File Offset: 0x0001E348
			[Token(Token = "0x60041A3")]
			[Address(RVA = "0x1F6FCA0", Offset = "0x1F6FCA0", VA = "0x1F6FCA0")]
			public static bool ShimmeredPortraitCondition()
			{
				return default(bool);
			}

			// Token: 0x060041A4 RID: 16804 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60041A4")]
			[Address(RVA = "0x1F6FD70", Offset = "0x1F6FD70", VA = "0x1F6FD70")]
			public static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> NPCBestiaryDrawOffsetCreation()
			{
				return null;
			}

			// Token: 0x060041A5 RID: 16805 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60041A5")]
			[Address(RVA = "0x1F70328", Offset = "0x1F70328", VA = "0x1F70328")]
			private static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> GetRedigitEntries()
			{
				return null;
			}

			// Token: 0x060041A6 RID: 16806 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60041A6")]
			[Address(RVA = "0x1F74258", Offset = "0x1F74258", VA = "0x1F74258")]
			private static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> GetGroxEntries()
			{
				return null;
			}

			// Token: 0x060041A7 RID: 16807 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60041A7")]
			[Address(RVA = "0x1F349AC", Offset = "0x1F349AC", VA = "0x1F349AC")]
			private static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> GetLeinforsEntries()
			{
				return null;
			}

			// Token: 0x04007B41 RID: 31553
			[Token(Token = "0x4007B41")]
			[FieldOffset(Offset = "0x0")]
			public static SetFactory Factory;

			// Token: 0x04007B42 RID: 31554
			[Token(Token = "0x4007B42")]
			[FieldOffset(Offset = "0x4")]
			public static Dictionary<int, int> SpecialSpawningRules;

			// Token: 0x04007B43 RID: 31555
			[Token(Token = "0x4007B43")]
			[FieldOffset(Offset = "0x8")]
			public static Dictionary<int, NPCID.Sets.NPCPortraitProvider> NPCPortraits;

			// Token: 0x04007B44 RID: 31556
			[Token(Token = "0x4007B44")]
			[FieldOffset(Offset = "0xC")]
			public static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> NPCBestiaryDrawOffset;

			// Token: 0x04007B45 RID: 31557
			[Token(Token = "0x4007B45")]
			[FieldOffset(Offset = "0x10")]
			public static Dictionary<int, NPCDebuffImmunityData> DebuffImmunitySets;

			// Token: 0x04007B46 RID: 31558
			[Token(Token = "0x4007B46")]
			[FieldOffset(Offset = "0x14")]
			public static List<int> NormalGoldCritterBestiaryPriority;

			// Token: 0x04007B47 RID: 31559
			[Token(Token = "0x4007B47")]
			[FieldOffset(Offset = "0x18")]
			public static List<int> BossBestiaryPriority;

			// Token: 0x04007B48 RID: 31560
			[Token(Token = "0x4007B48")]
			[FieldOffset(Offset = "0x1C")]
			public static List<int> TownNPCBestiaryPriority;

			// Token: 0x04007B49 RID: 31561
			[Token(Token = "0x4007B49")]
			[FieldOffset(Offset = "0x20")]
			public static bool[] SpawnOnPlayerCanSpawnInMidairOnSkyblock;

			// Token: 0x04007B4A RID: 31562
			[Token(Token = "0x4007B4A")]
			[FieldOffset(Offset = "0x24")]
			public static bool[] DontDropDungeonKeysOrSouls;

			// Token: 0x04007B4B RID: 31563
			[Token(Token = "0x4007B4B")]
			[FieldOffset(Offset = "0x28")]
			public static bool[] DontDoHardmodeScaling;

			// Token: 0x04007B4C RID: 31564
			[Token(Token = "0x4007B4C")]
			[FieldOffset(Offset = "0x2C")]
			public static bool[] ReflectStarShotsInForTheWorthy;

			// Token: 0x04007B4D RID: 31565
			[Token(Token = "0x4007B4D")]
			[FieldOffset(Offset = "0x30")]
			public static bool[] IsTownPet;

			// Token: 0x04007B4E RID: 31566
			[Token(Token = "0x4007B4E")]
			[FieldOffset(Offset = "0x34")]
			public static bool[] IsTownSlime;

			// Token: 0x04007B4F RID: 31567
			[Token(Token = "0x4007B4F")]
			[FieldOffset(Offset = "0x38")]
			public static bool[] CanConvertIntoCopperSlimeTownNPC;

			// Token: 0x04007B50 RID: 31568
			[Token(Token = "0x4007B50")]
			[FieldOffset(Offset = "0x3C")]
			public static List<int> GoldCrittersCollection;

			// Token: 0x04007B51 RID: 31569
			[Token(Token = "0x4007B51")]
			[FieldOffset(Offset = "0x40")]
			public static bool[] IsGoldCritter;

			// Token: 0x04007B52 RID: 31570
			[Token(Token = "0x4007B52")]
			[FieldOffset(Offset = "0x44")]
			public static bool[] ZappingJellyfish;

			// Token: 0x04007B53 RID: 31571
			[Token(Token = "0x4007B53")]
			[FieldOffset(Offset = "0x48")]
			public static bool?[] HunterPotionFriendlyOverride;

			// Token: 0x04007B54 RID: 31572
			[Token(Token = "0x4007B54")]
			[FieldOffset(Offset = "0x4C")]
			public static bool[] CantTakeLunchMoney;

			// Token: 0x04007B55 RID: 31573
			[Token(Token = "0x4007B55")]
			[FieldOffset(Offset = "0x50")]
			public static Dictionary<int, int> RespawnEnemyID;

			// Token: 0x04007B56 RID: 31574
			[Token(Token = "0x4007B56")]
			[FieldOffset(Offset = "0x54")]
			public static Dictionary<int, Vector2> NPCPortraitsCloseUpOffsets;

			// Token: 0x04007B57 RID: 31575
			[Token(Token = "0x4007B57")]
			[FieldOffset(Offset = "0x58")]
			public static Dictionary<int, Vector2> NPCPortraitsFullBodyRetroOffsets;

			// Token: 0x04007B58 RID: 31576
			[Token(Token = "0x4007B58")]
			[FieldOffset(Offset = "0x5C")]
			public static int[] TrailingMode;

			// Token: 0x04007B59 RID: 31577
			[Token(Token = "0x4007B59")]
			[FieldOffset(Offset = "0x60")]
			public static bool[] IsDragonfly;

			// Token: 0x04007B5A RID: 31578
			[Token(Token = "0x4007B5A")]
			[FieldOffset(Offset = "0x64")]
			public static bool[] BelongsToInvasionOldOnesArmy;

			// Token: 0x04007B5B RID: 31579
			[Token(Token = "0x4007B5B")]
			[FieldOffset(Offset = "0x68")]
			public static bool[] TeleportationImmune;

			// Token: 0x04007B5C RID: 31580
			[Token(Token = "0x4007B5C")]
			[FieldOffset(Offset = "0x6C")]
			public static bool[] UsesNewTargeting;

			// Token: 0x04007B5D RID: 31581
			[Token(Token = "0x4007B5D")]
			[FieldOffset(Offset = "0x70")]
			public static bool[] BirdThatCanPoop;

			// Token: 0x04007B5E RID: 31582
			[Token(Token = "0x4007B5E")]
			[FieldOffset(Offset = "0x74")]
			public static bool[] CritterThatCanTurnOnPlayers;

			// Token: 0x04007B5F RID: 31583
			[Token(Token = "0x4007B5F")]
			[FieldOffset(Offset = "0x78")]
			public static bool[] TakesDamageFromHostilesWithoutBeingFriendly;

			// Token: 0x04007B60 RID: 31584
			[Token(Token = "0x4007B60")]
			[FieldOffset(Offset = "0x7C")]
			public static bool[] AllNPCs;

			// Token: 0x04007B61 RID: 31585
			[Token(Token = "0x4007B61")]
			[FieldOffset(Offset = "0x80")]
			public static bool[] HurtingBees;

			// Token: 0x04007B62 RID: 31586
			[Token(Token = "0x4007B62")]
			[FieldOffset(Offset = "0x84")]
			public static bool[] CanBeHurtByBees;

			// Token: 0x04007B63 RID: 31587
			[Token(Token = "0x4007B63")]
			[FieldOffset(Offset = "0x88")]
			public static bool[] BoundTownNPCs;

			// Token: 0x04007B64 RID: 31588
			[Token(Token = "0x4007B64")]
			[FieldOffset(Offset = "0x8C")]
			public static bool[] ConveyorBeltCollision;

			// Token: 0x04007B65 RID: 31589
			[Token(Token = "0x4007B65")]
			[FieldOffset(Offset = "0x90")]
			public static bool[] SlimeCanContainItems;

			// Token: 0x04007B66 RID: 31590
			[Token(Token = "0x4007B66")]
			[FieldOffset(Offset = "0x94")]
			public static bool[] FighterUsesDD2PortalAppearEffect;

			// Token: 0x04007B67 RID: 31591
			[Token(Token = "0x4007B67")]
			[FieldOffset(Offset = "0x98")]
			public static float[] StatueSpawnedDropRarity;

			// Token: 0x04007B68 RID: 31592
			[Token(Token = "0x4007B68")]
			[FieldOffset(Offset = "0x9C")]
			public static bool[] NoEarlymodeLootWhenSpawnedFromStatue;

			// Token: 0x04007B69 RID: 31593
			[Token(Token = "0x4007B69")]
			[FieldOffset(Offset = "0xA0")]
			public static bool[] NeedsExpertScaling;

			// Token: 0x04007B6A RID: 31594
			[Token(Token = "0x4007B6A")]
			[FieldOffset(Offset = "0xA4")]
			public static bool[] ProjectileNPC;

			// Token: 0x04007B6B RID: 31595
			[Token(Token = "0x4007B6B")]
			[FieldOffset(Offset = "0xA8")]
			public static bool[] SavesAndLoads;

			// Token: 0x04007B6C RID: 31596
			[Token(Token = "0x4007B6C")]
			[FieldOffset(Offset = "0xAC")]
			public static int[] TrailCacheLength;

			// Token: 0x04007B6D RID: 31597
			[Token(Token = "0x4007B6D")]
			[FieldOffset(Offset = "0xB0")]
			public static bool[] SearchSpawnSlotsInReverse;

			// Token: 0x04007B6E RID: 31598
			[Token(Token = "0x4007B6E")]
			[FieldOffset(Offset = "0xB4")]
			public static bool[] CannotSpawnInSlot0;

			// Token: 0x04007B6F RID: 31599
			[Token(Token = "0x4007B6F")]
			[FieldOffset(Offset = "0xB8")]
			public static bool[] SkipUpdateInUnsyncedTiles;

			// Token: 0x04007B70 RID: 31600
			[Token(Token = "0x4007B70")]
			[FieldOffset(Offset = "0xBC")]
			public static bool[] UsesMultiplayerProximitySyncing;

			// Token: 0x04007B71 RID: 31601
			[Token(Token = "0x4007B71")]
			[FieldOffset(Offset = "0xC0")]
			public static bool[] NoMultiplayerSmoothingByType;

			// Token: 0x04007B72 RID: 31602
			[Token(Token = "0x4007B72")]
			[FieldOffset(Offset = "0xC4")]
			public static bool[] NoMultiplayerSmoothingByAI;

			// Token: 0x04007B73 RID: 31603
			[Token(Token = "0x4007B73")]
			[FieldOffset(Offset = "0xC8")]
			public static Vector2[] SyncAnchor;

			// Token: 0x04007B74 RID: 31604
			[Token(Token = "0x4007B74")]
			[FieldOffset(Offset = "0xCC")]
			public static bool[] MPAllowedEnemies;

			// Token: 0x04007B75 RID: 31605
			[Token(Token = "0x4007B75")]
			[FieldOffset(Offset = "0xD0")]
			public static bool[] TownCritter;

			// Token: 0x04007B76 RID: 31606
			[Token(Token = "0x4007B76")]
			[FieldOffset(Offset = "0xD4")]
			public static bool[] CountsAsCritter;

			// Token: 0x04007B77 RID: 31607
			[Token(Token = "0x4007B77")]
			[FieldOffset(Offset = "0xD8")]
			public static bool[] HasNoPartyText;

			// Token: 0x04007B78 RID: 31608
			[Token(Token = "0x4007B78")]
			[FieldOffset(Offset = "0xDC")]
			public static int[] HatOffsetY;

			// Token: 0x04007B79 RID: 31609
			[Token(Token = "0x4007B79")]
			[FieldOffset(Offset = "0xE0")]
			public static int[] FaceEmote;

			// Token: 0x04007B7A RID: 31610
			[Token(Token = "0x4007B7A")]
			[FieldOffset(Offset = "0xE4")]
			public static int[] ExtraFramesCount;

			// Token: 0x04007B7B RID: 31611
			[Token(Token = "0x4007B7B")]
			[FieldOffset(Offset = "0xE8")]
			public static int[] AttackFrameCount;

			// Token: 0x04007B7C RID: 31612
			[Token(Token = "0x4007B7C")]
			[FieldOffset(Offset = "0xEC")]
			public static int[] DangerDetectRange;

			// Token: 0x04007B7D RID: 31613
			[Token(Token = "0x4007B7D")]
			[FieldOffset(Offset = "0xF0")]
			public static bool[] ShimmerImmunity;

			// Token: 0x04007B7E RID: 31614
			[Token(Token = "0x4007B7E")]
			[FieldOffset(Offset = "0xF4")]
			public static int[] ShimmerTransformToItem;

			// Token: 0x04007B7F RID: 31615
			[Token(Token = "0x4007B7F")]
			[FieldOffset(Offset = "0xF8")]
			public static bool[] ShimmerTownTransform;

			// Token: 0x04007B80 RID: 31616
			[Token(Token = "0x4007B80")]
			[FieldOffset(Offset = "0xFC")]
			public static int[] ShimmerTransformToNPC;

			// Token: 0x04007B81 RID: 31617
			[Token(Token = "0x4007B81")]
			[FieldOffset(Offset = "0x100")]
			public static int[] AttackTime;

			// Token: 0x04007B82 RID: 31618
			[Token(Token = "0x4007B82")]
			[FieldOffset(Offset = "0x104")]
			public static int[] AttackAverageChance;

			// Token: 0x04007B83 RID: 31619
			[Token(Token = "0x4007B83")]
			[FieldOffset(Offset = "0x108")]
			public static int[] AttackType;

			// Token: 0x04007B84 RID: 31620
			[Token(Token = "0x4007B84")]
			[FieldOffset(Offset = "0x10C")]
			public static int[] PrettySafe;

			// Token: 0x04007B85 RID: 31621
			[Token(Token = "0x4007B85")]
			[FieldOffset(Offset = "0x110")]
			public static Color[] MagicAuraColor;

			// Token: 0x04007B86 RID: 31622
			[Token(Token = "0x4007B86")]
			[FieldOffset(Offset = "0x114")]
			public static bool[] DemonEyes;

			// Token: 0x04007B87 RID: 31623
			[Token(Token = "0x4007B87")]
			[FieldOffset(Offset = "0x118")]
			public static bool[] Zombies;

			// Token: 0x04007B88 RID: 31624
			[Token(Token = "0x4007B88")]
			[FieldOffset(Offset = "0x11C")]
			public static bool[] Skeletons;

			// Token: 0x04007B89 RID: 31625
			[Token(Token = "0x4007B89")]
			[FieldOffset(Offset = "0x120")]
			public static int[] BossHeadTextures;

			// Token: 0x04007B8A RID: 31626
			[Token(Token = "0x4007B8A")]
			[FieldOffset(Offset = "0x124")]
			public static bool[] PositiveNPCTypesExcludedFromDeathTally;

			// Token: 0x04007B8B RID: 31627
			[Token(Token = "0x4007B8B")]
			[FieldOffset(Offset = "0x128")]
			public static bool[] ShouldBeCountedAsBossForBestiary;

			// Token: 0x04007B8C RID: 31628
			[Token(Token = "0x4007B8C")]
			[FieldOffset(Offset = "0x12C")]
			public static bool[] ShouldBeCountedAsBossForRainbowBoulders;

			// Token: 0x04007B8D RID: 31629
			[Token(Token = "0x4007B8D")]
			[FieldOffset(Offset = "0x130")]
			public static bool[] DangerThatPreventsOtherDangers;

			// Token: 0x04007B8E RID: 31630
			[Token(Token = "0x4007B8E")]
			[FieldOffset(Offset = "0x134")]
			public static bool[] MustAlwaysDraw;

			// Token: 0x04007B8F RID: 31631
			[Token(Token = "0x4007B8F")]
			[FieldOffset(Offset = "0x138")]
			public static bool[] ExpandedCullDraw;

			// Token: 0x04007B90 RID: 31632
			[Token(Token = "0x4007B90")]
			[FieldOffset(Offset = "0x13C")]
			public static int[] ExtraTextureCount;

			// Token: 0x04007B91 RID: 31633
			[Token(Token = "0x4007B91")]
			[FieldOffset(Offset = "0x140")]
			public static int[] NPCFramingGroup;

			// Token: 0x04007B92 RID: 31634
			[Token(Token = "0x4007B92")]
			[FieldOffset(Offset = "0x144")]
			public static bool[] CanHitPastShimmer;

			// Token: 0x04007B93 RID: 31635
			[Token(Token = "0x4007B93")]
			[FieldOffset(Offset = "0x148")]
			public static int[][] TownNPCsFramingGroups;

			// Token: 0x020006F6 RID: 1782
			[Token(Token = "0x20006F6")]
			public struct NPCBestiaryDrawModifiers
			{
				// Token: 0x060041A9 RID: 16809 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60041A9")]
				[Address(RVA = "0x1F74554", Offset = "0x1F74554", VA = "0x1F74554")]
				public NPCBestiaryDrawModifiers(int seriouslyWhyCantStructsHaveParameterlessConstructors)
				{
				}

				// Token: 0x04007B94 RID: 31636
				[Token(Token = "0x4007B94")]
				[FieldOffset(Offset = "0x0")]
				public Vector2 Position;

				// Token: 0x04007B95 RID: 31637
				[Token(Token = "0x4007B95")]
				[FieldOffset(Offset = "0x8")]
				public float? PortraitPositionXOverride;

				// Token: 0x04007B96 RID: 31638
				[Token(Token = "0x4007B96")]
				[FieldOffset(Offset = "0x10")]
				public float? PortraitPositionYOverride;

				// Token: 0x04007B97 RID: 31639
				[Token(Token = "0x4007B97")]
				[FieldOffset(Offset = "0x18")]
				public float Rotation;

				// Token: 0x04007B98 RID: 31640
				[Token(Token = "0x4007B98")]
				[FieldOffset(Offset = "0x1C")]
				public float Scale;

				// Token: 0x04007B99 RID: 31641
				[Token(Token = "0x4007B99")]
				[FieldOffset(Offset = "0x20")]
				public float? PortraitScale;

				// Token: 0x04007B9A RID: 31642
				[Token(Token = "0x4007B9A")]
				[FieldOffset(Offset = "0x28")]
				public bool Hide;

				// Token: 0x04007B9B RID: 31643
				[Token(Token = "0x4007B9B")]
				[FieldOffset(Offset = "0x29")]
				public bool IsWet;

				// Token: 0x04007B9C RID: 31644
				[Token(Token = "0x4007B9C")]
				[FieldOffset(Offset = "0x2C")]
				public int? Frame;

				// Token: 0x04007B9D RID: 31645
				[Token(Token = "0x4007B9D")]
				[FieldOffset(Offset = "0x34")]
				public int? Direction;

				// Token: 0x04007B9E RID: 31646
				[Token(Token = "0x4007B9E")]
				[FieldOffset(Offset = "0x3C")]
				public int? SpriteDirection;

				// Token: 0x04007B9F RID: 31647
				[Token(Token = "0x4007B9F")]
				[FieldOffset(Offset = "0x44")]
				public float Velocity;

				// Token: 0x04007BA0 RID: 31648
				[Token(Token = "0x4007BA0")]
				[FieldOffset(Offset = "0x48")]
				public string CustomTexturePath;
			}

			// Token: 0x020006F7 RID: 1783
			[Token(Token = "0x20006F7")]
			public interface NPCPortraitProvider
			{
				// Token: 0x060041AA RID: 16810
				[Token(Token = "0x60041AA")]
				void GetDrawData(out Texture2D texture, out Rectangle drawFrame);
			}

			// Token: 0x020006F8 RID: 1784
			[Token(Token = "0x20006F8")]
			public class BasicNPCPortrait : FileAPI
			{
				// Token: 0x060041AB RID: 16811 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60041AB")]
				[Address(RVA = "0x1F6FAA0", Offset = "0x1F6FAA0", VA = "0x1F6FAA0")]
				public BasicNPCPortrait(string texturePath)
				{
				}

				// Token: 0x060041AC RID: 16812 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60041AC")]
				[Address(RVA = "0x1F74600", Offset = "0x1F74600", VA = "0x1F74600", Slot = "5")]
				public virtual void GetDrawData(out Texture2D texture, out Rectangle drawFrame)
				{
				}

				// Token: 0x04007BA1 RID: 31649
				[Token(Token = "0x4007BA1")]
				[FieldOffset(Offset = "0x8")]
				public string TexturePath;

				// Token: 0x04007BA2 RID: 31650
				[Token(Token = "0x4007BA2")]
				[FieldOffset(Offset = "0xC")]
				public int HorizontalFrames;

				// Token: 0x04007BA3 RID: 31651
				[Token(Token = "0x4007BA3")]
				[FieldOffset(Offset = "0x10")]
				public int VerticalFrames;

				// Token: 0x04007BA4 RID: 31652
				[Token(Token = "0x4007BA4")]
				[FieldOffset(Offset = "0x14")]
				public int PaddingX;

				// Token: 0x04007BA5 RID: 31653
				[Token(Token = "0x4007BA5")]
				[FieldOffset(Offset = "0x18")]
				public int PaddingY;

				// Token: 0x04007BA6 RID: 31654
				[Token(Token = "0x4007BA6")]
				[FieldOffset(Offset = "0x1C")]
				public int FrameX;

				// Token: 0x04007BA7 RID: 31655
				[Token(Token = "0x4007BA7")]
				[FieldOffset(Offset = "0x20")]
				public int FrameY;

				// Token: 0x04007BA8 RID: 31656
				[Token(Token = "0x4007BA8")]
				[FieldOffset(Offset = "0x24")]
				private Asset<Texture2D> _image;
			}

			// Token: 0x020006F9 RID: 1785
			[Token(Token = "0x20006F9")]
			public class NPCPortraitSelector : FileAPI
			{
				// Token: 0x060041AD RID: 16813 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60041AD")]
				[Address(RVA = "0x1F74818", Offset = "0x1F74818", VA = "0x1F74818")]
				public NPCID.Sets.NPCPortraitSelector With(NPCID.Sets.NPCPortraitSelector.SelectionCondition condition, NPCID.Sets.NPCPortraitProvider portrait)
				{
					return null;
				}

				// Token: 0x060041AE RID: 16814 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60041AE")]
				[Address(RVA = "0x1F748E4", Offset = "0x1F748E4", VA = "0x1F748E4")]
				public NPCID.Sets.NPCPortraitSelector Default(NPCID.Sets.NPCPortraitProvider portrait)
				{
					return null;
				}

				// Token: 0x060041AF RID: 16815 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60041AF")]
				[Address(RVA = "0x1F74A84", Offset = "0x1F74A84", VA = "0x1F74A84", Slot = "4")]
				public void GetDrawData(out Texture2D texture, out Rectangle drawFrame)
				{
				}

				// Token: 0x060041B0 RID: 16816 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60041B0")]
				[Address(RVA = "0x1F74B64", Offset = "0x1F74B64", VA = "0x1F74B64")]
				private NPCID.Sets.NPCPortraitProvider GetFirstValidatedEntry()
				{
					return null;
				}

				// Token: 0x060041B1 RID: 16817 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60041B1")]
				[Address(RVA = "0x1F6F97C", Offset = "0x1F6F97C", VA = "0x1F6F97C")]
				public NPCPortraitSelector()
				{
				}

				// Token: 0x04007BA9 RID: 31657
				[Token(Token = "0x4007BA9")]
				[FieldOffset(Offset = "0x8")]
				private List<NPCID.Sets.NPCPortraitSelector.Entry> _entries;

				// Token: 0x020006FA RID: 1786
				// (Invoke) Token: 0x060041B3 RID: 16819
				[Token(Token = "0x20006FA")]
				public delegate bool SelectionCondition();

				// Token: 0x020006FB RID: 1787
				[Token(Token = "0x20006FB")]
				public struct Entry
				{
					// Token: 0x04007BAA RID: 31658
					[Token(Token = "0x4007BAA")]
					[FieldOffset(Offset = "0x0")]
					public NPCID.Sets.NPCPortraitSelector.SelectionCondition Condition;

					// Token: 0x04007BAB RID: 31659
					[Token(Token = "0x4007BAB")]
					[FieldOffset(Offset = "0x4")]
					public NPCID.Sets.NPCPortraitProvider Portrait;
				}

				// Token: 0x020006FC RID: 1788
				[Token(Token = "0x20006FC")]
				[Serializable]
				private sealed class <>c
				{
					// Token: 0x060041B7 RID: 16823 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60041B7")]
					[Address(RVA = "0x1F74E2C", Offset = "0x1F74E2C", VA = "0x1F74E2C")]
					public <>c()
					{
					}

					// Token: 0x060041B8 RID: 16824 RVA: 0x00020160 File Offset: 0x0001E360
					[Token(Token = "0x60041B8")]
					[Address(RVA = "0x1F74E34", Offset = "0x1F74E34", VA = "0x1F74E34")]
					internal bool <Default>b__4_0()
					{
						return default(bool);
					}

					// Token: 0x04007BAC RID: 31660
					[Token(Token = "0x4007BAC")]
					[FieldOffset(Offset = "0x0")]
					public static readonly NPCID.Sets.NPCPortraitSelector.<>c <>9;

					// Token: 0x04007BAD RID: 31661
					[Token(Token = "0x4007BAD")]
					[FieldOffset(Offset = "0x4")]
					public static NPCID.Sets.NPCPortraitSelector.SelectionCondition <>9__4_0;
				}
			}

			// Token: 0x020006FD RID: 1789
			[Token(Token = "0x20006FD")]
			public class NPCVariantChecker
			{
				// Token: 0x060041B9 RID: 16825 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60041B9")]
				[Address(RVA = "0x1F6FBA8", Offset = "0x1F6FBA8", VA = "0x1F6FBA8")]
				public NPCVariantChecker(int variantToCheck)
				{
				}

				// Token: 0x060041BA RID: 16826 RVA: 0x00020178 File Offset: 0x0001E378
				[Token(Token = "0x60041BA")]
				[Address(RVA = "0x1F74E3C", Offset = "0x1F74E3C", VA = "0x1F74E3C")]
				public bool Fits()
				{
					return default(bool);
				}

				// Token: 0x04007BAE RID: 31662
				[Token(Token = "0x4007BAE")]
				[FieldOffset(Offset = "0x8")]
				public int VariantToCheck;
			}

			// Token: 0x020006FE RID: 1790
			[Token(Token = "0x20006FE")]
			private static class LocalBuffID
			{
				// Token: 0x04007BAF RID: 31663
				[Token(Token = "0x4007BAF")]
				public const int Confused = 31;

				// Token: 0x04007BB0 RID: 31664
				[Token(Token = "0x4007BB0")]
				public const int Poisoned = 20;

				// Token: 0x04007BB1 RID: 31665
				[Token(Token = "0x4007BB1")]
				public const int OnFire = 24;

				// Token: 0x04007BB2 RID: 31666
				[Token(Token = "0x4007BB2")]
				public const int OnFire3 = 323;

				// Token: 0x04007BB3 RID: 31667
				[Token(Token = "0x4007BB3")]
				public const int ShadowFlame = 153;

				// Token: 0x04007BB4 RID: 31668
				[Token(Token = "0x4007BB4")]
				public const int Daybreak = 189;

				// Token: 0x04007BB5 RID: 31669
				[Token(Token = "0x4007BB5")]
				public const int Frostburn = 44;

				// Token: 0x04007BB6 RID: 31670
				[Token(Token = "0x4007BB6")]
				public const int Frostburn2 = 324;

				// Token: 0x04007BB7 RID: 31671
				[Token(Token = "0x4007BB7")]
				public const int CursedInferno = 39;

				// Token: 0x04007BB8 RID: 31672
				[Token(Token = "0x4007BB8")]
				public const int BetsysCurse = 203;

				// Token: 0x04007BB9 RID: 31673
				[Token(Token = "0x4007BB9")]
				public const int Ichor = 69;

				// Token: 0x04007BBA RID: 31674
				[Token(Token = "0x4007BBA")]
				public const int Venom = 70;

				// Token: 0x04007BBB RID: 31675
				[Token(Token = "0x4007BBB")]
				public const int PotentAcid = 395;

				// Token: 0x04007BBC RID: 31676
				[Token(Token = "0x4007BBC")]
				public const int Oiled = 204;

				// Token: 0x04007BBD RID: 31677
				[Token(Token = "0x4007BBD")]
				public const int BoneJavelin = 169;

				// Token: 0x04007BBE RID: 31678
				[Token(Token = "0x4007BBE")]
				public const int TentacleSpike = 337;

				// Token: 0x04007BBF RID: 31679
				[Token(Token = "0x4007BBF")]
				public const int BloodButcherer = 344;

				// Token: 0x04007BC0 RID: 31680
				[Token(Token = "0x4007BC0")]
				public const int Bleeding = 30;

				// Token: 0x04007BC1 RID: 31681
				[Token(Token = "0x4007BC1")]
				public const int Hemorrhage = 375;
			}

			// Token: 0x020006FF RID: 1791
			[Token(Token = "0x20006FF")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x060041BC RID: 16828 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60041BC")]
				[Address(RVA = "0x1F74F8C", Offset = "0x1F74F8C", VA = "0x1F74F8C")]
				public <>c()
				{
				}

				// Token: 0x060041BD RID: 16829 RVA: 0x00020190 File Offset: 0x0001E390
				[Token(Token = "0x60041BD")]
				[Address(RVA = "0x1F74F94", Offset = "0x1F74F94", VA = "0x1F74F94")]
				internal bool <.cctor>b__97_0()
				{
					return default(bool);
				}

				// Token: 0x060041BE RID: 16830 RVA: 0x000201A8 File Offset: 0x0001E3A8
				[Token(Token = "0x60041BE")]
				[Address(RVA = "0x1F7503C", Offset = "0x1F7503C", VA = "0x1F7503C")]
				internal bool <.cctor>b__97_1()
				{
					return default(bool);
				}

				// Token: 0x060041BF RID: 16831 RVA: 0x000201C0 File Offset: 0x0001E3C0
				[Token(Token = "0x60041BF")]
				[Address(RVA = "0x1F750DC", Offset = "0x1F750DC", VA = "0x1F750DC")]
				internal bool <.cctor>b__97_2()
				{
					return default(bool);
				}

				// Token: 0x04007BC2 RID: 31682
				[Token(Token = "0x4007BC2")]
				[FieldOffset(Offset = "0x0")]
				public static readonly NPCID.Sets.<>c <>9;
			}
		}
	}
}
