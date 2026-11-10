using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000AA4 RID: 2724
	[Token(Token = "0x2000AA4")]
	public class Conditions
	{
		// Token: 0x06005635 RID: 22069 RVA: 0x00027C18 File Offset: 0x00025E18
		[Token(Token = "0x6005635")]
		[Address(RVA = "0x83299C", Offset = "0x83299C", VA = "0x83299C")]
		public static bool SoulOfWhateverConditionCanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x06005636 RID: 22070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005636")]
		[Address(RVA = "0x832C0C", Offset = "0x832C0C", VA = "0x832C0C")]
		public Conditions()
		{
		}

		// Token: 0x02000AA5 RID: 2725
		[Token(Token = "0x2000AA5")]
		public class NeverTrue : FileAPI, GUIControllerItem
		{
			// Token: 0x06005637 RID: 22071 RVA: 0x00027C30 File Offset: 0x00025E30
			[Token(Token = "0x6005637")]
			[Address(RVA = "0x832C14", Offset = "0x832C14", VA = "0x832C14", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005638 RID: 22072 RVA: 0x00027C48 File Offset: 0x00025E48
			[Token(Token = "0x6005638")]
			[Address(RVA = "0x832C1C", Offset = "0x832C1C", VA = "0x832C1C", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005639 RID: 22073 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005639")]
			[Address(RVA = "0x832C24", Offset = "0x832C24", VA = "0x832C24", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600563A RID: 22074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600563A")]
			[Address(RVA = "0x832C2C", Offset = "0x832C2C", VA = "0x832C2C")]
			public NeverTrue()
			{
			}
		}

		// Token: 0x02000AA6 RID: 2726
		[Token(Token = "0x2000AA6")]
		public class IsUsingSpecificAIValues : FileAPI, GUIControllerItem
		{
			// Token: 0x0600563B RID: 22075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600563B")]
			[Address(RVA = "0x832C34", Offset = "0x832C34", VA = "0x832C34")]
			public IsUsingSpecificAIValues(int aislot, float valueToMatch)
			{
			}

			// Token: 0x0600563C RID: 22076 RVA: 0x00027C60 File Offset: 0x00025E60
			[Token(Token = "0x600563C")]
			[Address(RVA = "0x832C58", Offset = "0x832C58", VA = "0x832C58", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600563D RID: 22077 RVA: 0x00027C78 File Offset: 0x00025E78
			[Token(Token = "0x600563D")]
			[Address(RVA = "0x832CA4", Offset = "0x832CA4", VA = "0x832CA4", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600563E RID: 22078 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600563E")]
			[Address(RVA = "0x832CAC", Offset = "0x832CAC", VA = "0x832CAC", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x040098ED RID: 39149
			[Token(Token = "0x40098ED")]
			[FieldOffset(Offset = "0x8")]
			public int aiSlotToCheck;

			// Token: 0x040098EE RID: 39150
			[Token(Token = "0x40098EE")]
			[FieldOffset(Offset = "0xC")]
			public float valueToMatch;
		}

		// Token: 0x02000AA7 RID: 2727
		[Token(Token = "0x2000AA7")]
		public class FrostMoonDropGatingChance : FileAPI, GUIControllerItem
		{
			// Token: 0x0600563F RID: 22079 RVA: 0x00027C90 File Offset: 0x00025E90
			[Token(Token = "0x600563F")]
			[Address(RVA = "0x832CB8", Offset = "0x832CB8", VA = "0x832CB8", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005640 RID: 22080 RVA: 0x00027CA8 File Offset: 0x00025EA8
			[Token(Token = "0x6005640")]
			[Address(RVA = "0x832E1C", Offset = "0x832E1C", VA = "0x832E1C", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005641 RID: 22081 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005641")]
			[Address(RVA = "0x832E24", Offset = "0x832E24", VA = "0x832E24", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005642 RID: 22082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005642")]
			[Address(RVA = "0x832EA4", Offset = "0x832EA4", VA = "0x832EA4")]
			public FrostMoonDropGatingChance()
			{
			}
		}

		// Token: 0x02000AA8 RID: 2728
		[Token(Token = "0x2000AA8")]
		public class PumpkinMoonDropGatingChance : FileAPI, GUIControllerItem
		{
			// Token: 0x06005643 RID: 22083 RVA: 0x00027CC0 File Offset: 0x00025EC0
			[Token(Token = "0x6005643")]
			[Address(RVA = "0x832EB0", Offset = "0x832EB0", VA = "0x832EB0", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005644 RID: 22084 RVA: 0x00027CD8 File Offset: 0x00025ED8
			[Token(Token = "0x6005644")]
			[Address(RVA = "0x83300C", Offset = "0x83300C", VA = "0x83300C", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005645 RID: 22085 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005645")]
			[Address(RVA = "0x833014", Offset = "0x833014", VA = "0x833014", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005646 RID: 22086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005646")]
			[Address(RVA = "0x833094", Offset = "0x833094", VA = "0x833094")]
			public PumpkinMoonDropGatingChance()
			{
			}
		}

		// Token: 0x02000AA9 RID: 2729
		[Token(Token = "0x2000AA9")]
		public class FrostMoonDropGateForTrophies : FileAPI, GUIControllerItem
		{
			// Token: 0x06005647 RID: 22087 RVA: 0x00027CF0 File Offset: 0x00025EF0
			[Token(Token = "0x6005647")]
			[Address(RVA = "0x83309C", Offset = "0x83309C", VA = "0x83309C", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005648 RID: 22088 RVA: 0x00027D08 File Offset: 0x00025F08
			[Token(Token = "0x6005648")]
			[Address(RVA = "0x833204", Offset = "0x833204", VA = "0x833204", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005649 RID: 22089 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005649")]
			[Address(RVA = "0x83320C", Offset = "0x83320C", VA = "0x83320C", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600564A RID: 22090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600564A")]
			[Address(RVA = "0x833214", Offset = "0x833214", VA = "0x833214")]
			public FrostMoonDropGateForTrophies()
			{
			}
		}

		// Token: 0x02000AAA RID: 2730
		[Token(Token = "0x2000AAA")]
		public class PumpkinMoonDropGateForTrophies : FileAPI, GUIControllerItem
		{
			// Token: 0x0600564B RID: 22091 RVA: 0x00027D20 File Offset: 0x00025F20
			[Token(Token = "0x600564B")]
			[Address(RVA = "0x83321C", Offset = "0x83321C", VA = "0x83321C", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600564C RID: 22092 RVA: 0x00027D38 File Offset: 0x00025F38
			[Token(Token = "0x600564C")]
			[Address(RVA = "0x833384", Offset = "0x833384", VA = "0x833384", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600564D RID: 22093 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600564D")]
			[Address(RVA = "0x83338C", Offset = "0x83338C", VA = "0x83338C", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600564E RID: 22094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600564E")]
			[Address(RVA = "0x833394", Offset = "0x833394", VA = "0x833394")]
			public PumpkinMoonDropGateForTrophies()
			{
			}
		}

		// Token: 0x02000AAB RID: 2731
		[Token(Token = "0x2000AAB")]
		public class IsPumpkinMoon : FileAPI, GUIControllerItem
		{
			// Token: 0x0600564F RID: 22095 RVA: 0x00027D50 File Offset: 0x00025F50
			[Token(Token = "0x600564F")]
			[Address(RVA = "0x83339C", Offset = "0x83339C", VA = "0x83339C", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005650 RID: 22096 RVA: 0x00027D68 File Offset: 0x00025F68
			[Token(Token = "0x6005650")]
			[Address(RVA = "0x833400", Offset = "0x833400", VA = "0x833400", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005651 RID: 22097 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005651")]
			[Address(RVA = "0x833408", Offset = "0x833408", VA = "0x833408", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005652 RID: 22098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005652")]
			[Address(RVA = "0x833410", Offset = "0x833410", VA = "0x833410")]
			public IsPumpkinMoon()
			{
			}
		}

		// Token: 0x02000AAC RID: 2732
		[Token(Token = "0x2000AAC")]
		public class FromCertainWaveAndAbove : FileAPI, GUIControllerItem
		{
			// Token: 0x06005653 RID: 22099 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005653")]
			[Address(RVA = "0x833418", Offset = "0x833418", VA = "0x833418")]
			public FromCertainWaveAndAbove(int neededWave)
			{
			}

			// Token: 0x06005654 RID: 22100 RVA: 0x00027D80 File Offset: 0x00025F80
			[Token(Token = "0x6005654")]
			[Address(RVA = "0x833434", Offset = "0x833434", VA = "0x833434", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005655 RID: 22101 RVA: 0x00027D98 File Offset: 0x00025F98
			[Token(Token = "0x6005655")]
			[Address(RVA = "0x8334AC", Offset = "0x8334AC", VA = "0x8334AC", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005656 RID: 22102 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005656")]
			[Address(RVA = "0x8334B4", Offset = "0x8334B4", VA = "0x8334B4", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x040098EF RID: 39151
			[Token(Token = "0x40098EF")]
			[FieldOffset(Offset = "0x8")]
			public int neededWave;
		}

		// Token: 0x02000AAD RID: 2733
		[Token(Token = "0x2000AAD")]
		public class IsBloodMoonAndNotFromStatue : FileAPI, GUIControllerItem
		{
			// Token: 0x06005657 RID: 22103 RVA: 0x00027DB0 File Offset: 0x00025FB0
			[Token(Token = "0x6005657")]
			[Address(RVA = "0x833578", Offset = "0x833578", VA = "0x833578", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005658 RID: 22104 RVA: 0x00027DC8 File Offset: 0x00025FC8
			[Token(Token = "0x6005658")]
			[Address(RVA = "0x833634", Offset = "0x833634", VA = "0x833634", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005659 RID: 22105 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005659")]
			[Address(RVA = "0x83363C", Offset = "0x83363C", VA = "0x83363C", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600565A RID: 22106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600565A")]
			[Address(RVA = "0x833644", Offset = "0x833644", VA = "0x833644")]
			public IsBloodMoonAndNotFromStatue()
			{
			}
		}

		// Token: 0x02000AAE RID: 2734
		[Token(Token = "0x2000AAE")]
		public class DownedAllMechBosses : FileAPI, GUIControllerItem
		{
			// Token: 0x0600565B RID: 22107 RVA: 0x00027DE0 File Offset: 0x00025FE0
			[Token(Token = "0x600565B")]
			[Address(RVA = "0x83364C", Offset = "0x83364C", VA = "0x83364C", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600565C RID: 22108 RVA: 0x00027DF8 File Offset: 0x00025FF8
			[Token(Token = "0x600565C")]
			[Address(RVA = "0x833708", Offset = "0x833708", VA = "0x833708", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600565D RID: 22109 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600565D")]
			[Address(RVA = "0x833710", Offset = "0x833710", VA = "0x833710", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600565E RID: 22110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600565E")]
			[Address(RVA = "0x833718", Offset = "0x833718", VA = "0x833718")]
			public DownedAllMechBosses()
			{
			}
		}

		// Token: 0x02000AAF RID: 2735
		[Token(Token = "0x2000AAF")]
		public class DownedPlantera : FileAPI, GUIControllerItem
		{
			// Token: 0x0600565F RID: 22111 RVA: 0x00027E10 File Offset: 0x00026010
			[Token(Token = "0x600565F")]
			[Address(RVA = "0x833720", Offset = "0x833720", VA = "0x833720", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005660 RID: 22112 RVA: 0x00027E28 File Offset: 0x00026028
			[Token(Token = "0x6005660")]
			[Address(RVA = "0x833784", Offset = "0x833784", VA = "0x833784", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005661 RID: 22113 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005661")]
			[Address(RVA = "0x83378C", Offset = "0x83378C", VA = "0x83378C", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005662 RID: 22114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005662")]
			[Address(RVA = "0x833794", Offset = "0x833794", VA = "0x833794")]
			public DownedPlantera()
			{
			}
		}

		// Token: 0x02000AB0 RID: 2736
		[Token(Token = "0x2000AB0")]
		public class IsHardmode : FileAPI, GUIControllerItem
		{
			// Token: 0x06005663 RID: 22115 RVA: 0x00027E40 File Offset: 0x00026040
			[Token(Token = "0x6005663")]
			[Address(RVA = "0x83379C", Offset = "0x83379C", VA = "0x83379C", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005664 RID: 22116 RVA: 0x00027E58 File Offset: 0x00026058
			[Token(Token = "0x6005664")]
			[Address(RVA = "0x833800", Offset = "0x833800", VA = "0x833800", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005665 RID: 22117 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005665")]
			[Address(RVA = "0x833808", Offset = "0x833808", VA = "0x833808", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005666 RID: 22118 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005666")]
			[Address(RVA = "0x833810", Offset = "0x833810", VA = "0x833810")]
			public IsHardmode()
			{
			}
		}

		// Token: 0x02000AB1 RID: 2737
		[Token(Token = "0x2000AB1")]
		public class FirstTimeKillingPlantera : FileAPI, GUIControllerItem
		{
			// Token: 0x06005667 RID: 22119 RVA: 0x00027E70 File Offset: 0x00026070
			[Token(Token = "0x6005667")]
			[Address(RVA = "0x833818", Offset = "0x833818", VA = "0x833818", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005668 RID: 22120 RVA: 0x00027E88 File Offset: 0x00026088
			[Token(Token = "0x6005668")]
			[Address(RVA = "0x833884", Offset = "0x833884", VA = "0x833884", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005669 RID: 22121 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005669")]
			[Address(RVA = "0x83388C", Offset = "0x83388C", VA = "0x83388C", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600566A RID: 22122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600566A")]
			[Address(RVA = "0x833894", Offset = "0x833894", VA = "0x833894")]
			public FirstTimeKillingPlantera()
			{
			}
		}

		// Token: 0x02000AB2 RID: 2738
		[Token(Token = "0x2000AB2")]
		public class MechanicalBossesDummyCondition : FileAPI, GUIControllerItem
		{
			// Token: 0x0600566B RID: 22123 RVA: 0x00027EA0 File Offset: 0x000260A0
			[Token(Token = "0x600566B")]
			[Address(RVA = "0x83389C", Offset = "0x83389C", VA = "0x83389C", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600566C RID: 22124 RVA: 0x00027EB8 File Offset: 0x000260B8
			[Token(Token = "0x600566C")]
			[Address(RVA = "0x8338A4", Offset = "0x8338A4", VA = "0x8338A4", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600566D RID: 22125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600566D")]
			[Address(RVA = "0x8338AC", Offset = "0x8338AC", VA = "0x8338AC", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600566E RID: 22126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600566E")]
			[Address(RVA = "0x82F480", Offset = "0x82F480", VA = "0x82F480")]
			public MechanicalBossesDummyCondition()
			{
			}
		}

		// Token: 0x02000AB3 RID: 2739
		[Token(Token = "0x2000AB3")]
		public class PirateMap : FileAPI, GUIControllerItem
		{
			// Token: 0x0600566F RID: 22127 RVA: 0x00027ED0 File Offset: 0x000260D0
			[Token(Token = "0x600566F")]
			[Address(RVA = "0x8338B4", Offset = "0x8338B4", VA = "0x8338B4", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005670 RID: 22128 RVA: 0x00027EE8 File Offset: 0x000260E8
			[Token(Token = "0x6005670")]
			[Address(RVA = "0x833A50", Offset = "0x833A50", VA = "0x833A50", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005671 RID: 22129 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005671")]
			[Address(RVA = "0x833A58", Offset = "0x833A58", VA = "0x833A58", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005672 RID: 22130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005672")]
			[Address(RVA = "0x833AD8", Offset = "0x833AD8", VA = "0x833AD8")]
			public PirateMap()
			{
			}
		}

		// Token: 0x02000AB4 RID: 2740
		[Token(Token = "0x2000AB4")]
		public class IsChristmas : FileAPI, GUIControllerItem
		{
			// Token: 0x06005673 RID: 22131 RVA: 0x00027F00 File Offset: 0x00026100
			[Token(Token = "0x6005673")]
			[Address(RVA = "0x833AE0", Offset = "0x833AE0", VA = "0x833AE0", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005674 RID: 22132 RVA: 0x00027F18 File Offset: 0x00026118
			[Token(Token = "0x6005674")]
			[Address(RVA = "0x833B44", Offset = "0x833B44", VA = "0x833B44", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005675 RID: 22133 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005675")]
			[Address(RVA = "0x833B4C", Offset = "0x833B4C", VA = "0x833B4C", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005676 RID: 22134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005676")]
			[Address(RVA = "0x833BCC", Offset = "0x833BCC", VA = "0x833BCC")]
			public IsChristmas()
			{
			}
		}

		// Token: 0x02000AB5 RID: 2741
		[Token(Token = "0x2000AB5")]
		public class NotExpert : FileAPI, GUIControllerItem
		{
			// Token: 0x06005677 RID: 22135 RVA: 0x00027F30 File Offset: 0x00026130
			[Token(Token = "0x6005677")]
			[Address(RVA = "0x833BD4", Offset = "0x833BD4", VA = "0x833BD4", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005678 RID: 22136 RVA: 0x00027F48 File Offset: 0x00026148
			[Token(Token = "0x6005678")]
			[Address(RVA = "0x833C38", Offset = "0x833C38", VA = "0x833C38", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005679 RID: 22137 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005679")]
			[Address(RVA = "0x833C9C", Offset = "0x833C9C", VA = "0x833C9C", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600567A RID: 22138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600567A")]
			[Address(RVA = "0x82E56C", Offset = "0x82E56C", VA = "0x82E56C")]
			public NotExpert()
			{
			}
		}

		// Token: 0x02000AB6 RID: 2742
		[Token(Token = "0x2000AB6")]
		public class DropExtraGel : FileAPI, GUIControllerItem
		{
			// Token: 0x0600567B RID: 22139 RVA: 0x00027F60 File Offset: 0x00026160
			[Token(Token = "0x600567B")]
			[Address(RVA = "0x833D1C", Offset = "0x833D1C", VA = "0x833D1C", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600567C RID: 22140 RVA: 0x00027F78 File Offset: 0x00026178
			[Token(Token = "0x600567C")]
			[Address(RVA = "0x833D24", Offset = "0x833D24", VA = "0x833D24", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600567D RID: 22141 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600567D")]
			[Address(RVA = "0x833D2C", Offset = "0x833D2C", VA = "0x833D2C", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600567E RID: 22142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600567E")]
			[Address(RVA = "0x82DF8C", Offset = "0x82DF8C", VA = "0x82DF8C")]
			public DropExtraGel()
			{
			}
		}

		// Token: 0x02000AB7 RID: 2743
		[Token(Token = "0x2000AB7")]
		public class NotDropExtraGel : FileAPI, GUIControllerItem
		{
			// Token: 0x0600567F RID: 22143 RVA: 0x00027F90 File Offset: 0x00026190
			[Token(Token = "0x600567F")]
			[Address(RVA = "0x833D34", Offset = "0x833D34", VA = "0x833D34", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005680 RID: 22144 RVA: 0x00027FA8 File Offset: 0x000261A8
			[Token(Token = "0x6005680")]
			[Address(RVA = "0x833D48", Offset = "0x833D48", VA = "0x833D48", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005681 RID: 22145 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005681")]
			[Address(RVA = "0x833D5C", Offset = "0x833D5C", VA = "0x833D5C", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005682 RID: 22146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005682")]
			[Address(RVA = "0x82DF94", Offset = "0x82DF94", VA = "0x82DF94")]
			public NotDropExtraGel()
			{
			}
		}

		// Token: 0x02000AB8 RID: 2744
		[Token(Token = "0x2000AB8")]
		public class NotMasterMode : FileAPI, GUIControllerItem
		{
			// Token: 0x06005683 RID: 22147 RVA: 0x00027FC0 File Offset: 0x000261C0
			[Token(Token = "0x6005683")]
			[Address(RVA = "0x833D64", Offset = "0x833D64", VA = "0x833D64", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005684 RID: 22148 RVA: 0x00027FD8 File Offset: 0x000261D8
			[Token(Token = "0x6005684")]
			[Address(RVA = "0x833DC8", Offset = "0x833DC8", VA = "0x833DC8", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005685 RID: 22149 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005685")]
			[Address(RVA = "0x833E2C", Offset = "0x833E2C", VA = "0x833E2C", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005686 RID: 22150 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005686")]
			[Address(RVA = "0x82EB44", Offset = "0x82EB44", VA = "0x82EB44")]
			public NotMasterMode()
			{
			}
		}

		// Token: 0x02000AB9 RID: 2745
		[Token(Token = "0x2000AB9")]
		public class MissingTwin : FileAPI, GUIControllerItem
		{
			// Token: 0x06005687 RID: 22151 RVA: 0x00027FF0 File Offset: 0x000261F0
			[Token(Token = "0x6005687")]
			[Address(RVA = "0x833EAC", Offset = "0x833EAC", VA = "0x833EAC", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005688 RID: 22152 RVA: 0x00028008 File Offset: 0x00026208
			[Token(Token = "0x6005688")]
			[Address(RVA = "0x833F34", Offset = "0x833F34", VA = "0x833F34", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005689 RID: 22153 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005689")]
			[Address(RVA = "0x833F3C", Offset = "0x833F3C", VA = "0x833F3C", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600568A RID: 22154 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600568A")]
			[Address(RVA = "0x833F44", Offset = "0x833F44", VA = "0x833F44")]
			public MissingTwin()
			{
			}
		}

		// Token: 0x02000ABA RID: 2746
		[Token(Token = "0x2000ABA")]
		public class EmpressOfLightIsGenuinelyEnraged : FileAPI, GUIControllerItem
		{
			// Token: 0x0600568B RID: 22155 RVA: 0x00028020 File Offset: 0x00026220
			[Token(Token = "0x600568B")]
			[Address(RVA = "0x833F4C", Offset = "0x833F4C", VA = "0x833F4C", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600568C RID: 22156 RVA: 0x00028038 File Offset: 0x00026238
			[Token(Token = "0x600568C")]
			[Address(RVA = "0x833F70", Offset = "0x833F70", VA = "0x833F70", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600568D RID: 22157 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600568D")]
			[Address(RVA = "0x833F78", Offset = "0x833F78", VA = "0x833F78", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600568E RID: 22158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600568E")]
			[Address(RVA = "0x833FF8", Offset = "0x833FF8", VA = "0x833FF8")]
			public EmpressOfLightIsGenuinelyEnraged()
			{
			}
		}

		// Token: 0x02000ABB RID: 2747
		[Token(Token = "0x2000ABB")]
		public class RedHatSkeletron : FileAPI, GUIControllerItem
		{
			// Token: 0x0600568F RID: 22159 RVA: 0x00028050 File Offset: 0x00026250
			[Token(Token = "0x600568F")]
			[Address(RVA = "0x834000", Offset = "0x834000", VA = "0x834000", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005690 RID: 22160 RVA: 0x00028068 File Offset: 0x00026268
			[Token(Token = "0x6005690")]
			[Address(RVA = "0x834024", Offset = "0x834024", VA = "0x834024", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005691 RID: 22161 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005691")]
			[Address(RVA = "0x8340E4", Offset = "0x8340E4", VA = "0x8340E4", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005692 RID: 22162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005692")]
			[Address(RVA = "0x834164", Offset = "0x834164", VA = "0x834164")]
			public RedHatSkeletron()
			{
			}
		}

		// Token: 0x02000ABC RID: 2748
		[Token(Token = "0x2000ABC")]
		public class PlayerNeedsHealing : FileAPI, GUIControllerItem
		{
			// Token: 0x06005693 RID: 22163 RVA: 0x00028080 File Offset: 0x00026280
			[Token(Token = "0x6005693")]
			[Address(RVA = "0x83416C", Offset = "0x83416C", VA = "0x83416C", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005694 RID: 22164 RVA: 0x00028098 File Offset: 0x00026298
			[Token(Token = "0x6005694")]
			[Address(RVA = "0x8341A4", Offset = "0x8341A4", VA = "0x8341A4", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005695 RID: 22165 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005695")]
			[Address(RVA = "0x8341AC", Offset = "0x8341AC", VA = "0x8341AC", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005696 RID: 22166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005696")]
			[Address(RVA = "0x83422C", Offset = "0x83422C", VA = "0x83422C")]
			public PlayerNeedsHealing()
			{
			}
		}

		// Token: 0x02000ABD RID: 2749
		[Token(Token = "0x2000ABD")]
		public class MechdusaKill : FileAPI, GUIControllerItem
		{
			// Token: 0x06005697 RID: 22167 RVA: 0x000280B0 File Offset: 0x000262B0
			[Token(Token = "0x6005697")]
			[Address(RVA = "0x834234", Offset = "0x834234", VA = "0x834234", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005698 RID: 22168 RVA: 0x000280C8 File Offset: 0x000262C8
			[Token(Token = "0x6005698")]
			[Address(RVA = "0x8343A4", Offset = "0x8343A4", VA = "0x8343A4", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005699 RID: 22169 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005699")]
			[Address(RVA = "0x8343AC", Offset = "0x8343AC", VA = "0x8343AC", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600569A RID: 22170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600569A")]
			[Address(RVA = "0x8343B4", Offset = "0x8343B4", VA = "0x8343B4")]
			public MechdusaKill()
			{
			}

			// Token: 0x040098F0 RID: 39152
			[Token(Token = "0x40098F0")]
			[FieldOffset(Offset = "0x0")]
			private static int[] _targetList;
		}

		// Token: 0x02000ABE RID: 2750
		[Token(Token = "0x2000ABE")]
		public class LegacyHack_IsBossAndExpert : FileAPI, GUIControllerItem
		{
			// Token: 0x0600569C RID: 22172 RVA: 0x000280E0 File Offset: 0x000262E0
			[Token(Token = "0x600569C")]
			[Address(RVA = "0x834464", Offset = "0x834464", VA = "0x834464", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600569D RID: 22173 RVA: 0x000280F8 File Offset: 0x000262F8
			[Token(Token = "0x600569D")]
			[Address(RVA = "0x8344E8", Offset = "0x8344E8", VA = "0x8344E8", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600569E RID: 22174 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600569E")]
			[Address(RVA = "0x834548", Offset = "0x834548", VA = "0x834548", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600569F RID: 22175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600569F")]
			[Address(RVA = "0x8345C8", Offset = "0x8345C8", VA = "0x8345C8")]
			public LegacyHack_IsBossAndExpert()
			{
			}
		}

		// Token: 0x02000ABF RID: 2751
		[Token(Token = "0x2000ABF")]
		public class LegacyHack_IsBossAndNotExpert : FileAPI, GUIControllerItem
		{
			// Token: 0x060056A0 RID: 22176 RVA: 0x00028110 File Offset: 0x00026310
			[Token(Token = "0x60056A0")]
			[Address(RVA = "0x8345D0", Offset = "0x8345D0", VA = "0x8345D0", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056A1 RID: 22177 RVA: 0x00028128 File Offset: 0x00026328
			[Token(Token = "0x60056A1")]
			[Address(RVA = "0x834658", Offset = "0x834658", VA = "0x834658", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056A2 RID: 22178 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056A2")]
			[Address(RVA = "0x8346BC", Offset = "0x8346BC", VA = "0x8346BC", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056A3 RID: 22179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056A3")]
			[Address(RVA = "0x83473C", Offset = "0x83473C", VA = "0x83473C")]
			public LegacyHack_IsBossAndNotExpert()
			{
			}
		}

		// Token: 0x02000AC0 RID: 2752
		[Token(Token = "0x2000AC0")]
		public class LegacyHack_IsABoss : FileAPI, GUIControllerItem
		{
			// Token: 0x060056A4 RID: 22180 RVA: 0x00028140 File Offset: 0x00026340
			[Token(Token = "0x60056A4")]
			[Address(RVA = "0x834744", Offset = "0x834744", VA = "0x834744", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056A5 RID: 22181 RVA: 0x00028158 File Offset: 0x00026358
			[Token(Token = "0x60056A5")]
			[Address(RVA = "0x834768", Offset = "0x834768", VA = "0x834768", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056A6 RID: 22182 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056A6")]
			[Address(RVA = "0x834770", Offset = "0x834770", VA = "0x834770", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056A7 RID: 22183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056A7")]
			[Address(RVA = "0x834778", Offset = "0x834778", VA = "0x834778")]
			public LegacyHack_IsABoss()
			{
			}
		}

		// Token: 0x02000AC1 RID: 2753
		[Token(Token = "0x2000AC1")]
		public class IsExpert : FileAPI, GUIControllerItem
		{
			// Token: 0x060056A8 RID: 22184 RVA: 0x00028170 File Offset: 0x00026370
			[Token(Token = "0x60056A8")]
			[Address(RVA = "0x834780", Offset = "0x834780", VA = "0x834780", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056A9 RID: 22185 RVA: 0x00028188 File Offset: 0x00026388
			[Token(Token = "0x60056A9")]
			[Address(RVA = "0x8347E0", Offset = "0x8347E0", VA = "0x8347E0", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056AA RID: 22186 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056AA")]
			[Address(RVA = "0x834840", Offset = "0x834840", VA = "0x834840", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056AB RID: 22187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056AB")]
			[Address(RVA = "0x82E564", Offset = "0x82E564", VA = "0x82E564")]
			public IsExpert()
			{
			}
		}

		// Token: 0x02000AC2 RID: 2754
		[Token(Token = "0x2000AC2")]
		public class IsMasterMode : FileAPI, GUIControllerItem
		{
			// Token: 0x060056AC RID: 22188 RVA: 0x000281A0 File Offset: 0x000263A0
			[Token(Token = "0x60056AC")]
			[Address(RVA = "0x834920", Offset = "0x834920", VA = "0x834920", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056AD RID: 22189 RVA: 0x000281B8 File Offset: 0x000263B8
			[Token(Token = "0x60056AD")]
			[Address(RVA = "0x834980", Offset = "0x834980", VA = "0x834980", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056AE RID: 22190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056AE")]
			[Address(RVA = "0x8349E0", Offset = "0x8349E0", VA = "0x8349E0", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056AF RID: 22191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056AF")]
			[Address(RVA = "0x82EB3C", Offset = "0x82EB3C", VA = "0x82EB3C")]
			public IsMasterMode()
			{
			}
		}

		// Token: 0x02000AC3 RID: 2755
		[Token(Token = "0x2000AC3")]
		public class IsCrimson : FileAPI, GUIControllerItem
		{
			// Token: 0x060056B0 RID: 22192 RVA: 0x000281D0 File Offset: 0x000263D0
			[Token(Token = "0x60056B0")]
			[Address(RVA = "0x834A60", Offset = "0x834A60", VA = "0x834A60", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056B1 RID: 22193 RVA: 0x000281E8 File Offset: 0x000263E8
			[Token(Token = "0x60056B1")]
			[Address(RVA = "0x834AC4", Offset = "0x834AC4", VA = "0x834AC4", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056B2 RID: 22194 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056B2")]
			[Address(RVA = "0x834B28", Offset = "0x834B28", VA = "0x834B28", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056B3 RID: 22195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056B3")]
			[Address(RVA = "0x834BA8", Offset = "0x834BA8", VA = "0x834BA8")]
			public IsCrimson()
			{
			}
		}

		// Token: 0x02000AC4 RID: 2756
		[Token(Token = "0x2000AC4")]
		public class IsCorruption : FileAPI, GUIControllerItem
		{
			// Token: 0x060056B4 RID: 22196 RVA: 0x00028200 File Offset: 0x00026400
			[Token(Token = "0x60056B4")]
			[Address(RVA = "0x834BB0", Offset = "0x834BB0", VA = "0x834BB0", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056B5 RID: 22197 RVA: 0x00028218 File Offset: 0x00026418
			[Token(Token = "0x60056B5")]
			[Address(RVA = "0x834C1C", Offset = "0x834C1C", VA = "0x834C1C", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056B6 RID: 22198 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056B6")]
			[Address(RVA = "0x834C88", Offset = "0x834C88", VA = "0x834C88", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056B7 RID: 22199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056B7")]
			[Address(RVA = "0x834D08", Offset = "0x834D08", VA = "0x834D08")]
			public IsCorruption()
			{
			}
		}

		// Token: 0x02000AC5 RID: 2757
		[Token(Token = "0x2000AC5")]
		public class IsCrimsonAndNotExpert : FileAPI, GUIControllerItem
		{
			// Token: 0x060056B8 RID: 22200 RVA: 0x00028230 File Offset: 0x00026430
			[Token(Token = "0x60056B8")]
			[Address(RVA = "0x834D10", Offset = "0x834D10", VA = "0x834D10", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056B9 RID: 22201 RVA: 0x00028248 File Offset: 0x00026448
			[Token(Token = "0x60056B9")]
			[Address(RVA = "0x834DC0", Offset = "0x834DC0", VA = "0x834DC0", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056BA RID: 22202 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056BA")]
			[Address(RVA = "0x834E70", Offset = "0x834E70", VA = "0x834E70", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056BB RID: 22203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056BB")]
			[Address(RVA = "0x834EF0", Offset = "0x834EF0", VA = "0x834EF0")]
			public IsCrimsonAndNotExpert()
			{
			}
		}

		// Token: 0x02000AC6 RID: 2758
		[Token(Token = "0x2000AC6")]
		public class IsCorruptionAndNotExpert : FileAPI, GUIControllerItem
		{
			// Token: 0x060056BC RID: 22204 RVA: 0x00028260 File Offset: 0x00026460
			[Token(Token = "0x60056BC")]
			[Address(RVA = "0x834EF8", Offset = "0x834EF8", VA = "0x834EF8", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056BD RID: 22205 RVA: 0x00028278 File Offset: 0x00026478
			[Token(Token = "0x60056BD")]
			[Address(RVA = "0x834FA4", Offset = "0x834FA4", VA = "0x834FA4", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056BE RID: 22206 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056BE")]
			[Address(RVA = "0x835050", Offset = "0x835050", VA = "0x835050", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056BF RID: 22207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056BF")]
			[Address(RVA = "0x8350D0", Offset = "0x8350D0", VA = "0x8350D0")]
			public IsCorruptionAndNotExpert()
			{
			}
		}

		// Token: 0x02000AC7 RID: 2759
		[Token(Token = "0x2000AC7")]
		public class HalloweenWeapons : FileAPI, GUIControllerItem
		{
			// Token: 0x060056C0 RID: 22208 RVA: 0x00028290 File Offset: 0x00026490
			[Token(Token = "0x60056C0")]
			[Address(RVA = "0x8350D8", Offset = "0x8350D8", VA = "0x8350D8", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056C1 RID: 22209 RVA: 0x000282A8 File Offset: 0x000264A8
			[Token(Token = "0x60056C1")]
			[Address(RVA = "0x83528C", Offset = "0x83528C", VA = "0x83528C", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056C2 RID: 22210 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056C2")]
			[Address(RVA = "0x835294", Offset = "0x835294", VA = "0x835294", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056C3 RID: 22211 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056C3")]
			[Address(RVA = "0x835314", Offset = "0x835314", VA = "0x835314")]
			public HalloweenWeapons()
			{
			}
		}

		// Token: 0x02000AC8 RID: 2760
		[Token(Token = "0x2000AC8")]
		public class SoulOfNight : FileAPI, GUIControllerItem
		{
			// Token: 0x060056C4 RID: 22212 RVA: 0x000282C0 File Offset: 0x000264C0
			[Token(Token = "0x60056C4")]
			[Address(RVA = "0x83531C", Offset = "0x83531C", VA = "0x83531C", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056C5 RID: 22213 RVA: 0x000282D8 File Offset: 0x000264D8
			[Token(Token = "0x60056C5")]
			[Address(RVA = "0x8353A0", Offset = "0x8353A0", VA = "0x8353A0", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056C6 RID: 22214 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056C6")]
			[Address(RVA = "0x8353A8", Offset = "0x8353A8", VA = "0x8353A8", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056C7 RID: 22215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056C7")]
			[Address(RVA = "0x835428", Offset = "0x835428", VA = "0x835428")]
			public SoulOfNight()
			{
			}
		}

		// Token: 0x02000AC9 RID: 2761
		[Token(Token = "0x2000AC9")]
		public class SoulOfLight : FileAPI, GUIControllerItem
		{
			// Token: 0x060056C8 RID: 22216 RVA: 0x000282F0 File Offset: 0x000264F0
			[Token(Token = "0x60056C8")]
			[Address(RVA = "0x835430", Offset = "0x835430", VA = "0x835430", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056C9 RID: 22217 RVA: 0x00028308 File Offset: 0x00026508
			[Token(Token = "0x60056C9")]
			[Address(RVA = "0x835488", Offset = "0x835488", VA = "0x835488", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056CA RID: 22218 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056CA")]
			[Address(RVA = "0x835490", Offset = "0x835490", VA = "0x835490", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056CB RID: 22219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056CB")]
			[Address(RVA = "0x835510", Offset = "0x835510", VA = "0x835510")]
			public SoulOfLight()
			{
			}
		}

		// Token: 0x02000ACA RID: 2762
		[Token(Token = "0x2000ACA")]
		public class NotFromStatue : FileAPI, GUIControllerItem
		{
			// Token: 0x060056CC RID: 22220 RVA: 0x00028320 File Offset: 0x00026520
			[Token(Token = "0x60056CC")]
			[Address(RVA = "0x835518", Offset = "0x835518", VA = "0x835518", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056CD RID: 22221 RVA: 0x00028338 File Offset: 0x00026538
			[Token(Token = "0x60056CD")]
			[Address(RVA = "0x83553C", Offset = "0x83553C", VA = "0x83553C", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056CE RID: 22222 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056CE")]
			[Address(RVA = "0x835544", Offset = "0x835544", VA = "0x835544", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056CF RID: 22223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056CF")]
			[Address(RVA = "0x8355C4", Offset = "0x8355C4", VA = "0x8355C4")]
			public NotFromStatue()
			{
			}
		}

		// Token: 0x02000ACB RID: 2763
		[Token(Token = "0x2000ACB")]
		public class HalloweenGoodieBagDrop : FileAPI, GUIControllerItem
		{
			// Token: 0x060056D0 RID: 22224 RVA: 0x00028350 File Offset: 0x00026550
			[Token(Token = "0x60056D0")]
			[Address(RVA = "0x8355CC", Offset = "0x8355CC", VA = "0x8355CC", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056D1 RID: 22225 RVA: 0x00028368 File Offset: 0x00026568
			[Token(Token = "0x60056D1")]
			[Address(RVA = "0x8356E0", Offset = "0x8356E0", VA = "0x8356E0", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056D2 RID: 22226 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056D2")]
			[Address(RVA = "0x8356E8", Offset = "0x8356E8", VA = "0x8356E8", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056D3 RID: 22227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056D3")]
			[Address(RVA = "0x835768", Offset = "0x835768", VA = "0x835768")]
			public HalloweenGoodieBagDrop()
			{
			}
		}

		// Token: 0x02000ACC RID: 2764
		[Token(Token = "0x2000ACC")]
		public class XmasPresentDrop : FileAPI, GUIControllerItem
		{
			// Token: 0x060056D4 RID: 22228 RVA: 0x00028380 File Offset: 0x00026580
			[Token(Token = "0x60056D4")]
			[Address(RVA = "0x835770", Offset = "0x835770", VA = "0x835770", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056D5 RID: 22229 RVA: 0x00028398 File Offset: 0x00026598
			[Token(Token = "0x60056D5")]
			[Address(RVA = "0x835884", Offset = "0x835884", VA = "0x835884", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056D6 RID: 22230 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056D6")]
			[Address(RVA = "0x83588C", Offset = "0x83588C", VA = "0x83588C", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056D7 RID: 22231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056D7")]
			[Address(RVA = "0x83590C", Offset = "0x83590C", VA = "0x83590C")]
			public XmasPresentDrop()
			{
			}
		}

		// Token: 0x02000ACD RID: 2765
		[Token(Token = "0x2000ACD")]
		public class LivingFlames : FileAPI, GUIControllerItem
		{
			// Token: 0x060056D8 RID: 22232 RVA: 0x000283B0 File Offset: 0x000265B0
			[Token(Token = "0x60056D8")]
			[Address(RVA = "0x835914", Offset = "0x835914", VA = "0x835914", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056D9 RID: 22233 RVA: 0x000283C8 File Offset: 0x000265C8
			[Token(Token = "0x60056D9")]
			[Address(RVA = "0x835A38", Offset = "0x835A38", VA = "0x835A38", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056DA RID: 22234 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056DA")]
			[Address(RVA = "0x835A40", Offset = "0x835A40", VA = "0x835A40", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056DB RID: 22235 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056DB")]
			[Address(RVA = "0x835AC0", Offset = "0x835AC0", VA = "0x835AC0")]
			public LivingFlames()
			{
			}
		}

		// Token: 0x02000ACE RID: 2766
		[Token(Token = "0x2000ACE")]
		public class NamedNPC : FileAPI, GUIControllerItem
		{
			// Token: 0x060056DC RID: 22236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056DC")]
			[Address(RVA = "0x835AC8", Offset = "0x835AC8", VA = "0x835AC8")]
			public NamedNPC(string neededName)
			{
			}

			// Token: 0x060056DD RID: 22237 RVA: 0x000283E0 File Offset: 0x000265E0
			[Token(Token = "0x60056DD")]
			[Address(RVA = "0x835AE4", Offset = "0x835AE4", VA = "0x835AE4", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056DE RID: 22238 RVA: 0x000283F8 File Offset: 0x000265F8
			[Token(Token = "0x60056DE")]
			[Address(RVA = "0x835B9C", Offset = "0x835B9C", VA = "0x835B9C", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056DF RID: 22239 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056DF")]
			[Address(RVA = "0x835BA4", Offset = "0x835BA4", VA = "0x835BA4", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x040098F1 RID: 39153
			[Token(Token = "0x40098F1")]
			[FieldOffset(Offset = "0x8")]
			public string neededName;
		}

		// Token: 0x02000ACF RID: 2767
		[Token(Token = "0x2000ACF")]
		public class HallowKeyCondition : FileAPI, GUIControllerItem
		{
			// Token: 0x060056E0 RID: 22240 RVA: 0x00028410 File Offset: 0x00026610
			[Token(Token = "0x60056E0")]
			[Address(RVA = "0x835C24", Offset = "0x835C24", VA = "0x835C24", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056E1 RID: 22241 RVA: 0x00028428 File Offset: 0x00026628
			[Token(Token = "0x60056E1")]
			[Address(RVA = "0x835D48", Offset = "0x835D48", VA = "0x835D48", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056E2 RID: 22242 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056E2")]
			[Address(RVA = "0x835D50", Offset = "0x835D50", VA = "0x835D50", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056E3 RID: 22243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056E3")]
			[Address(RVA = "0x835DD0", Offset = "0x835DD0", VA = "0x835DD0")]
			public HallowKeyCondition()
			{
			}
		}

		// Token: 0x02000AD0 RID: 2768
		[Token(Token = "0x2000AD0")]
		public class JungleKeyCondition : FileAPI, GUIControllerItem
		{
			// Token: 0x060056E4 RID: 22244 RVA: 0x00028440 File Offset: 0x00026640
			[Token(Token = "0x60056E4")]
			[Address(RVA = "0x835DD8", Offset = "0x835DD8", VA = "0x835DD8", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056E5 RID: 22245 RVA: 0x00028458 File Offset: 0x00026658
			[Token(Token = "0x60056E5")]
			[Address(RVA = "0x835EFC", Offset = "0x835EFC", VA = "0x835EFC", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056E6 RID: 22246 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056E6")]
			[Address(RVA = "0x835F04", Offset = "0x835F04", VA = "0x835F04", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056E7 RID: 22247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056E7")]
			[Address(RVA = "0x835F84", Offset = "0x835F84", VA = "0x835F84")]
			public JungleKeyCondition()
			{
			}
		}

		// Token: 0x02000AD1 RID: 2769
		[Token(Token = "0x2000AD1")]
		public class CorruptKeyCondition : FileAPI, GUIControllerItem
		{
			// Token: 0x060056E8 RID: 22248 RVA: 0x00028470 File Offset: 0x00026670
			[Token(Token = "0x60056E8")]
			[Address(RVA = "0x835F8C", Offset = "0x835F8C", VA = "0x835F8C", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056E9 RID: 22249 RVA: 0x00028488 File Offset: 0x00026688
			[Token(Token = "0x60056E9")]
			[Address(RVA = "0x8360B0", Offset = "0x8360B0", VA = "0x8360B0", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056EA RID: 22250 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056EA")]
			[Address(RVA = "0x8360B8", Offset = "0x8360B8", VA = "0x8360B8", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056EB RID: 22251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056EB")]
			[Address(RVA = "0x836138", Offset = "0x836138", VA = "0x836138")]
			public CorruptKeyCondition()
			{
			}
		}

		// Token: 0x02000AD2 RID: 2770
		[Token(Token = "0x2000AD2")]
		public class CrimsonKeyCondition : FileAPI, GUIControllerItem
		{
			// Token: 0x060056EC RID: 22252 RVA: 0x000284A0 File Offset: 0x000266A0
			[Token(Token = "0x60056EC")]
			[Address(RVA = "0x836140", Offset = "0x836140", VA = "0x836140", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056ED RID: 22253 RVA: 0x000284B8 File Offset: 0x000266B8
			[Token(Token = "0x60056ED")]
			[Address(RVA = "0x836264", Offset = "0x836264", VA = "0x836264", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056EE RID: 22254 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056EE")]
			[Address(RVA = "0x83626C", Offset = "0x83626C", VA = "0x83626C", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056EF RID: 22255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056EF")]
			[Address(RVA = "0x8362EC", Offset = "0x8362EC", VA = "0x8362EC")]
			public CrimsonKeyCondition()
			{
			}
		}

		// Token: 0x02000AD3 RID: 2771
		[Token(Token = "0x2000AD3")]
		public class FrozenKeyCondition : FileAPI, GUIControllerItem
		{
			// Token: 0x060056F0 RID: 22256 RVA: 0x000284D0 File Offset: 0x000266D0
			[Token(Token = "0x60056F0")]
			[Address(RVA = "0x8362F4", Offset = "0x8362F4", VA = "0x8362F4", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056F1 RID: 22257 RVA: 0x000284E8 File Offset: 0x000266E8
			[Token(Token = "0x60056F1")]
			[Address(RVA = "0x836418", Offset = "0x836418", VA = "0x836418", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056F2 RID: 22258 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056F2")]
			[Address(RVA = "0x836420", Offset = "0x836420", VA = "0x836420", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056F3 RID: 22259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056F3")]
			[Address(RVA = "0x8364A0", Offset = "0x8364A0", VA = "0x8364A0")]
			public FrozenKeyCondition()
			{
			}
		}

		// Token: 0x02000AD4 RID: 2772
		[Token(Token = "0x2000AD4")]
		public class DesertKeyCondition : FileAPI, GUIControllerItem
		{
			// Token: 0x060056F4 RID: 22260 RVA: 0x00028500 File Offset: 0x00026700
			[Token(Token = "0x60056F4")]
			[Address(RVA = "0x8364A8", Offset = "0x8364A8", VA = "0x8364A8", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056F5 RID: 22261 RVA: 0x00028518 File Offset: 0x00026718
			[Token(Token = "0x60056F5")]
			[Address(RVA = "0x8365FC", Offset = "0x8365FC", VA = "0x8365FC", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056F6 RID: 22262 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056F6")]
			[Address(RVA = "0x836604", Offset = "0x836604", VA = "0x836604", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056F7 RID: 22263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056F7")]
			[Address(RVA = "0x836684", Offset = "0x836684", VA = "0x836684")]
			public DesertKeyCondition()
			{
			}
		}

		// Token: 0x02000AD5 RID: 2773
		[Token(Token = "0x2000AD5")]
		public class BeatAnyMechBoss : FileAPI, GUIControllerItem
		{
			// Token: 0x060056F8 RID: 22264 RVA: 0x00028530 File Offset: 0x00026730
			[Token(Token = "0x60056F8")]
			[Address(RVA = "0x83668C", Offset = "0x83668C", VA = "0x83668C", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056F9 RID: 22265 RVA: 0x00028548 File Offset: 0x00026748
			[Token(Token = "0x60056F9")]
			[Address(RVA = "0x8366F0", Offset = "0x8366F0", VA = "0x8366F0", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056FA RID: 22266 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056FA")]
			[Address(RVA = "0x8366F8", Offset = "0x8366F8", VA = "0x8366F8", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056FB RID: 22267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056FB")]
			[Address(RVA = "0x836778", Offset = "0x836778", VA = "0x836778")]
			public BeatAnyMechBoss()
			{
			}
		}

		// Token: 0x02000AD6 RID: 2774
		[Token(Token = "0x2000AD6")]
		public class YoyoCascade : FileAPI, GUIControllerItem
		{
			// Token: 0x060056FC RID: 22268 RVA: 0x00028560 File Offset: 0x00026760
			[Token(Token = "0x60056FC")]
			[Address(RVA = "0x836780", Offset = "0x836780", VA = "0x836780", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x060056FD RID: 22269 RVA: 0x00028578 File Offset: 0x00026778
			[Token(Token = "0x60056FD")]
			[Address(RVA = "0x836914", Offset = "0x836914", VA = "0x836914", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x060056FE RID: 22270 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60056FE")]
			[Address(RVA = "0x83691C", Offset = "0x83691C", VA = "0x83691C", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x060056FF RID: 22271 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60056FF")]
			[Address(RVA = "0x83699C", Offset = "0x83699C", VA = "0x83699C")]
			public YoyoCascade()
			{
			}
		}

		// Token: 0x02000AD7 RID: 2775
		[Token(Token = "0x2000AD7")]
		public class YoyosAmarok : FileAPI, GUIControllerItem
		{
			// Token: 0x06005700 RID: 22272 RVA: 0x00028590 File Offset: 0x00026790
			[Token(Token = "0x6005700")]
			[Address(RVA = "0x8369A4", Offset = "0x8369A4", VA = "0x8369A4", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005701 RID: 22273 RVA: 0x000285A8 File Offset: 0x000267A8
			[Token(Token = "0x6005701")]
			[Address(RVA = "0x836AC4", Offset = "0x836AC4", VA = "0x836AC4", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005702 RID: 22274 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005702")]
			[Address(RVA = "0x836ACC", Offset = "0x836ACC", VA = "0x836ACC", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005703 RID: 22275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005703")]
			[Address(RVA = "0x836B4C", Offset = "0x836B4C", VA = "0x836B4C")]
			public YoyosAmarok()
			{
			}
		}

		// Token: 0x02000AD8 RID: 2776
		[Token(Token = "0x2000AD8")]
		public class YoyosYelets : FileAPI, GUIControllerItem
		{
			// Token: 0x06005704 RID: 22276 RVA: 0x000285C0 File Offset: 0x000267C0
			[Token(Token = "0x6005704")]
			[Address(RVA = "0x836B54", Offset = "0x836B54", VA = "0x836B54", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005705 RID: 22277 RVA: 0x000285D8 File Offset: 0x000267D8
			[Token(Token = "0x6005705")]
			[Address(RVA = "0x836CB8", Offset = "0x836CB8", VA = "0x836CB8", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005706 RID: 22278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005706")]
			[Address(RVA = "0x836CC0", Offset = "0x836CC0", VA = "0x836CC0", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005707 RID: 22279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005707")]
			[Address(RVA = "0x836D40", Offset = "0x836D40", VA = "0x836D40")]
			public YoyosYelets()
			{
			}
		}

		// Token: 0x02000AD9 RID: 2777
		[Token(Token = "0x2000AD9")]
		public class YoyosKraken : FileAPI, GUIControllerItem
		{
			// Token: 0x06005708 RID: 22280 RVA: 0x000285F0 File Offset: 0x000267F0
			[Token(Token = "0x6005708")]
			[Address(RVA = "0x836D48", Offset = "0x836D48", VA = "0x836D48", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005709 RID: 22281 RVA: 0x00028608 File Offset: 0x00026808
			[Token(Token = "0x6005709")]
			[Address(RVA = "0x836EAC", Offset = "0x836EAC", VA = "0x836EAC", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600570A RID: 22282 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600570A")]
			[Address(RVA = "0x836EB4", Offset = "0x836EB4", VA = "0x836EB4", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600570B RID: 22283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600570B")]
			[Address(RVA = "0x836F34", Offset = "0x836F34", VA = "0x836F34")]
			public YoyosKraken()
			{
			}
		}

		// Token: 0x02000ADA RID: 2778
		[Token(Token = "0x2000ADA")]
		public class YoyosHelFire : FileAPI, GUIControllerItem
		{
			// Token: 0x0600570C RID: 22284 RVA: 0x00028620 File Offset: 0x00026820
			[Token(Token = "0x600570C")]
			[Address(RVA = "0x836F3C", Offset = "0x836F3C", VA = "0x836F3C", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600570D RID: 22285 RVA: 0x00028638 File Offset: 0x00026838
			[Token(Token = "0x600570D")]
			[Address(RVA = "0x8370C8", Offset = "0x8370C8", VA = "0x8370C8", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600570E RID: 22286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600570E")]
			[Address(RVA = "0x8370D0", Offset = "0x8370D0", VA = "0x8370D0", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600570F RID: 22287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600570F")]
			[Address(RVA = "0x837150", Offset = "0x837150", VA = "0x837150")]
			public YoyosHelFire()
			{
			}
		}

		// Token: 0x02000ADB RID: 2779
		[Token(Token = "0x2000ADB")]
		public class WindyEnoughForKiteDrops : FileAPI, GUIControllerItem
		{
			// Token: 0x06005710 RID: 22288 RVA: 0x00028650 File Offset: 0x00026850
			[Token(Token = "0x6005710")]
			[Address(RVA = "0x837158", Offset = "0x837158", VA = "0x837158", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005711 RID: 22289 RVA: 0x00028668 File Offset: 0x00026868
			[Token(Token = "0x6005711")]
			[Address(RVA = "0x8371B8", Offset = "0x8371B8", VA = "0x8371B8", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005712 RID: 22290 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005712")]
			[Address(RVA = "0x8371C0", Offset = "0x8371C0", VA = "0x8371C0", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005713 RID: 22291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005713")]
			[Address(RVA = "0x837240", Offset = "0x837240", VA = "0x837240")]
			public WindyEnoughForKiteDrops()
			{
			}
		}

		// Token: 0x02000ADC RID: 2780
		[Token(Token = "0x2000ADC")]
		public class Easymode : FileAPI, GUIControllerItem
		{
			// Token: 0x06005714 RID: 22292 RVA: 0x00028680 File Offset: 0x00026880
			[Token(Token = "0x6005714")]
			[Address(RVA = "0x837248", Offset = "0x837248", VA = "0x837248", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005715 RID: 22293 RVA: 0x00028698 File Offset: 0x00026898
			[Token(Token = "0x6005715")]
			[Address(RVA = "0x8372B4", Offset = "0x8372B4", VA = "0x8372B4", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005716 RID: 22294 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005716")]
			[Address(RVA = "0x837320", Offset = "0x837320", VA = "0x837320", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005717 RID: 22295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005717")]
			[Address(RVA = "0x837328", Offset = "0x837328", VA = "0x837328")]
			public Easymode()
			{
			}
		}

		// Token: 0x02000ADD RID: 2781
		[Token(Token = "0x2000ADD")]
		public class RemixSeed : FileAPI, GUIControllerItem
		{
			// Token: 0x06005718 RID: 22296 RVA: 0x000286B0 File Offset: 0x000268B0
			[Token(Token = "0x6005718")]
			[Address(RVA = "0x837330", Offset = "0x837330", VA = "0x837330", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005719 RID: 22297 RVA: 0x000286C8 File Offset: 0x000268C8
			[Token(Token = "0x6005719")]
			[Address(RVA = "0x837394", Offset = "0x837394", VA = "0x837394", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600571A RID: 22298 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600571A")]
			[Address(RVA = "0x8373F8", Offset = "0x8373F8", VA = "0x8373F8", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600571B RID: 22299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600571B")]
			[Address(RVA = "0x837400", Offset = "0x837400", VA = "0x837400")]
			public RemixSeed()
			{
			}
		}

		// Token: 0x02000ADE RID: 2782
		[Token(Token = "0x2000ADE")]
		public class NotRemixSeed : FileAPI, GUIControllerItem
		{
			// Token: 0x0600571C RID: 22300 RVA: 0x000286E0 File Offset: 0x000268E0
			[Token(Token = "0x600571C")]
			[Address(RVA = "0x837408", Offset = "0x837408", VA = "0x837408", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600571D RID: 22301 RVA: 0x000286F8 File Offset: 0x000268F8
			[Token(Token = "0x600571D")]
			[Address(RVA = "0x837474", Offset = "0x837474", VA = "0x837474", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600571E RID: 22302 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600571E")]
			[Address(RVA = "0x8374E0", Offset = "0x8374E0", VA = "0x8374E0", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600571F RID: 22303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600571F")]
			[Address(RVA = "0x8374E8", Offset = "0x8374E8", VA = "0x8374E8")]
			public NotRemixSeed()
			{
			}
		}

		// Token: 0x02000ADF RID: 2783
		[Token(Token = "0x2000ADF")]
		public class RemixSeedEasymode : FileAPI, GUIControllerItem
		{
			// Token: 0x06005720 RID: 22304 RVA: 0x00028710 File Offset: 0x00026910
			[Token(Token = "0x6005720")]
			[Address(RVA = "0x8374F0", Offset = "0x8374F0", VA = "0x8374F0", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005721 RID: 22305 RVA: 0x00028728 File Offset: 0x00026928
			[Token(Token = "0x6005721")]
			[Address(RVA = "0x837588", Offset = "0x837588", VA = "0x837588", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005722 RID: 22306 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005722")]
			[Address(RVA = "0x837620", Offset = "0x837620", VA = "0x837620", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005723 RID: 22307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005723")]
			[Address(RVA = "0x837628", Offset = "0x837628", VA = "0x837628")]
			public RemixSeedEasymode()
			{
			}
		}

		// Token: 0x02000AE0 RID: 2784
		[Token(Token = "0x2000AE0")]
		public class RemixSeedHardmode : FileAPI, GUIControllerItem
		{
			// Token: 0x06005724 RID: 22308 RVA: 0x00028740 File Offset: 0x00026940
			[Token(Token = "0x6005724")]
			[Address(RVA = "0x837630", Offset = "0x837630", VA = "0x837630", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005725 RID: 22309 RVA: 0x00028758 File Offset: 0x00026958
			[Token(Token = "0x6005725")]
			[Address(RVA = "0x8376C8", Offset = "0x8376C8", VA = "0x8376C8", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005726 RID: 22310 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005726")]
			[Address(RVA = "0x837760", Offset = "0x837760", VA = "0x837760", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005727 RID: 22311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005727")]
			[Address(RVA = "0x837768", Offset = "0x837768", VA = "0x837768")]
			public RemixSeedHardmode()
			{
			}
		}

		// Token: 0x02000AE1 RID: 2785
		[Token(Token = "0x2000AE1")]
		public class NotRemixSeedEasymode : FileAPI, GUIControllerItem
		{
			// Token: 0x06005728 RID: 22312 RVA: 0x00028770 File Offset: 0x00026970
			[Token(Token = "0x6005728")]
			[Address(RVA = "0x837770", Offset = "0x837770", VA = "0x837770", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005729 RID: 22313 RVA: 0x00028788 File Offset: 0x00026988
			[Token(Token = "0x6005729")]
			[Address(RVA = "0x837810", Offset = "0x837810", VA = "0x837810", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600572A RID: 22314 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600572A")]
			[Address(RVA = "0x8378B0", Offset = "0x8378B0", VA = "0x8378B0", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600572B RID: 22315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600572B")]
			[Address(RVA = "0x8378B8", Offset = "0x8378B8", VA = "0x8378B8")]
			public NotRemixSeedEasymode()
			{
			}
		}

		// Token: 0x02000AE2 RID: 2786
		[Token(Token = "0x2000AE2")]
		public class NotRemixSeedHardmode : FileAPI, GUIControllerItem
		{
			// Token: 0x0600572C RID: 22316 RVA: 0x000287A0 File Offset: 0x000269A0
			[Token(Token = "0x600572C")]
			[Address(RVA = "0x8378C0", Offset = "0x8378C0", VA = "0x8378C0", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600572D RID: 22317 RVA: 0x000287B8 File Offset: 0x000269B8
			[Token(Token = "0x600572D")]
			[Address(RVA = "0x837960", Offset = "0x837960", VA = "0x837960", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600572E RID: 22318 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600572E")]
			[Address(RVA = "0x837A00", Offset = "0x837A00", VA = "0x837A00", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600572F RID: 22319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600572F")]
			[Address(RVA = "0x837A08", Offset = "0x837A08", VA = "0x837A08")]
			public NotRemixSeedHardmode()
			{
			}
		}

		// Token: 0x02000AE3 RID: 2787
		[Token(Token = "0x2000AE3")]
		public class EyeOfCthulhuDefeatedAndNoAltarsInWorld : FileAPI, GUIControllerItem
		{
			// Token: 0x06005730 RID: 22320 RVA: 0x000287D0 File Offset: 0x000269D0
			[Token(Token = "0x6005730")]
			[Address(RVA = "0x837A10", Offset = "0x837A10", VA = "0x837A10", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005731 RID: 22321 RVA: 0x000287E8 File Offset: 0x000269E8
			[Token(Token = "0x6005731")]
			[Address(RVA = "0x837AC8", Offset = "0x837AC8", VA = "0x837AC8", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005732 RID: 22322 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005732")]
			[Address(RVA = "0x837AD0", Offset = "0x837AD0", VA = "0x837AD0", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005733 RID: 22323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005733")]
			[Address(RVA = "0x837AD8", Offset = "0x837AD8", VA = "0x837AD8")]
			public EyeOfCthulhuDefeatedAndNoAltarsInWorld()
			{
			}
		}

		// Token: 0x02000AE4 RID: 2788
		[Token(Token = "0x2000AE4")]
		public class TenthAnniversaryIsUp : FileAPI, GUIControllerItem
		{
			// Token: 0x06005734 RID: 22324 RVA: 0x00028800 File Offset: 0x00026A00
			[Token(Token = "0x6005734")]
			[Address(RVA = "0x837AE0", Offset = "0x837AE0", VA = "0x837AE0", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005735 RID: 22325 RVA: 0x00028818 File Offset: 0x00026A18
			[Token(Token = "0x6005735")]
			[Address(RVA = "0x837B44", Offset = "0x837B44", VA = "0x837B44", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005736 RID: 22326 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005736")]
			[Address(RVA = "0x837BA8", Offset = "0x837BA8", VA = "0x837BA8", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005737 RID: 22327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005737")]
			[Address(RVA = "0x837BB0", Offset = "0x837BB0", VA = "0x837BB0")]
			public TenthAnniversaryIsUp()
			{
			}
		}

		// Token: 0x02000AE5 RID: 2789
		[Token(Token = "0x2000AE5")]
		public class TenthAnniversaryIsNotUp : FileAPI, GUIControllerItem
		{
			// Token: 0x06005738 RID: 22328 RVA: 0x00028830 File Offset: 0x00026A30
			[Token(Token = "0x6005738")]
			[Address(RVA = "0x837BB8", Offset = "0x837BB8", VA = "0x837BB8", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005739 RID: 22329 RVA: 0x00028848 File Offset: 0x00026A48
			[Token(Token = "0x6005739")]
			[Address(RVA = "0x837C24", Offset = "0x837C24", VA = "0x837C24", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600573A RID: 22330 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600573A")]
			[Address(RVA = "0x837C90", Offset = "0x837C90", VA = "0x837C90", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600573B RID: 22331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600573B")]
			[Address(RVA = "0x837C98", Offset = "0x837C98", VA = "0x837C98")]
			public TenthAnniversaryIsNotUp()
			{
			}
		}

		// Token: 0x02000AE6 RID: 2790
		[Token(Token = "0x2000AE6")]
		public class DontStarveIsUp : FileAPI, GUIControllerItem
		{
			// Token: 0x0600573C RID: 22332 RVA: 0x00028860 File Offset: 0x00026A60
			[Token(Token = "0x600573C")]
			[Address(RVA = "0x837CA0", Offset = "0x837CA0", VA = "0x837CA0", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600573D RID: 22333 RVA: 0x00028878 File Offset: 0x00026A78
			[Token(Token = "0x600573D")]
			[Address(RVA = "0x837D04", Offset = "0x837D04", VA = "0x837D04", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600573E RID: 22334 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600573E")]
			[Address(RVA = "0x837D68", Offset = "0x837D68", VA = "0x837D68", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600573F RID: 22335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600573F")]
			[Address(RVA = "0x837D70", Offset = "0x837D70", VA = "0x837D70")]
			public DontStarveIsUp()
			{
			}
		}

		// Token: 0x02000AE7 RID: 2791
		[Token(Token = "0x2000AE7")]
		public class DontStarveIsNotUp : FileAPI, GUIControllerItem
		{
			// Token: 0x06005740 RID: 22336 RVA: 0x00028890 File Offset: 0x00026A90
			[Token(Token = "0x6005740")]
			[Address(RVA = "0x837D78", Offset = "0x837D78", VA = "0x837D78", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005741 RID: 22337 RVA: 0x000288A8 File Offset: 0x00026AA8
			[Token(Token = "0x6005741")]
			[Address(RVA = "0x837DE4", Offset = "0x837DE4", VA = "0x837DE4", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005742 RID: 22338 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005742")]
			[Address(RVA = "0x837E50", Offset = "0x837E50", VA = "0x837E50", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005743 RID: 22339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005743")]
			[Address(RVA = "0x837E58", Offset = "0x837E58", VA = "0x837E58")]
			public DontStarveIsNotUp()
			{
			}
		}

		// Token: 0x02000AE8 RID: 2792
		[Token(Token = "0x2000AE8")]
		public class SkyblockIsUp : FileAPI, GUIControllerItem
		{
			// Token: 0x06005744 RID: 22340 RVA: 0x000288C0 File Offset: 0x00026AC0
			[Token(Token = "0x6005744")]
			[Address(RVA = "0x837E60", Offset = "0x837E60", VA = "0x837E60", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005745 RID: 22341 RVA: 0x000288D8 File Offset: 0x00026AD8
			[Token(Token = "0x6005745")]
			[Address(RVA = "0x837EC4", Offset = "0x837EC4", VA = "0x837EC4", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x06005746 RID: 22342 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005746")]
			[Address(RVA = "0x837F28", Offset = "0x837F28", VA = "0x837F28", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x06005747 RID: 22343 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005747")]
			[Address(RVA = "0x837F30", Offset = "0x837F30", VA = "0x837F30")]
			public SkyblockIsUp()
			{
			}
		}

		// Token: 0x02000AE9 RID: 2793
		[Token(Token = "0x2000AE9")]
		public class SkyblockIsNotUp : FileAPI, GUIControllerItem
		{
			// Token: 0x06005748 RID: 22344 RVA: 0x000288F0 File Offset: 0x00026AF0
			[Token(Token = "0x6005748")]
			[Address(RVA = "0x837F38", Offset = "0x837F38", VA = "0x837F38", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x06005749 RID: 22345 RVA: 0x00028908 File Offset: 0x00026B08
			[Token(Token = "0x6005749")]
			[Address(RVA = "0x837FA4", Offset = "0x837FA4", VA = "0x837FA4", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600574A RID: 22346 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600574A")]
			[Address(RVA = "0x838010", Offset = "0x838010", VA = "0x838010", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600574B RID: 22347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600574B")]
			[Address(RVA = "0x838018", Offset = "0x838018", VA = "0x838018")]
			public SkyblockIsNotUp()
			{
			}
		}

		// Token: 0x02000AEA RID: 2794
		[Token(Token = "0x2000AEA")]
		public class SkyblockIsUpNoSickle : FileAPI, GUIControllerItem
		{
			// Token: 0x0600574C RID: 22348 RVA: 0x00028920 File Offset: 0x00026B20
			[Token(Token = "0x600574C")]
			[Address(RVA = "0x838020", Offset = "0x838020", VA = "0x838020", Slot = "4")]
			public bool CanDrop(DropAttemptInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600574D RID: 22349 RVA: 0x00028938 File Offset: 0x00026B38
			[Token(Token = "0x600574D")]
			[Address(RVA = "0x8380B8", Offset = "0x8380B8", VA = "0x8380B8", Slot = "5")]
			public bool CanShowItemDropInUI()
			{
				return default(bool);
			}

			// Token: 0x0600574E RID: 22350 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600574E")]
			[Address(RVA = "0x8380C0", Offset = "0x8380C0", VA = "0x8380C0", Slot = "6")]
			public string GetConditionDescription()
			{
				return null;
			}

			// Token: 0x0600574F RID: 22351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600574F")]
			[Address(RVA = "0x8380C8", Offset = "0x8380C8", VA = "0x8380C8")]
			public SkyblockIsUpNoSickle()
			{
			}
		}
	}
}
