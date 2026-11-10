using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x020009A2 RID: 2466
	[Token(Token = "0x20009A2")]
	public class NPCInteractions
	{
		// Token: 0x06005110 RID: 20752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005110")]
		[Address(RVA = "0x7777A0", Offset = "0x7777A0", VA = "0x7777A0")]
		public static void Initialize()
		{
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005111")]
		[Address(RVA = "0x777EB4", Offset = "0x777EB4", VA = "0x777EB4")]
		private static void Shop(int npcType, int shopIndex, [Optional] string customTextKey)
		{
		}

		// Token: 0x06005112 RID: 20754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005112")]
		[Address(RVA = "0x777F74", Offset = "0x777F74", VA = "0x777F74")]
		private static void Register(NPCInteraction interaction)
		{
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005113")]
		[Address(RVA = "0x778118", Offset = "0x778118", VA = "0x778118")]
		public NPCInteractions()
		{
		}

		// Token: 0x040094CC RID: 38092
		[Token(Token = "0x40094CC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<NPCInteraction> All;

		// Token: 0x020009A3 RID: 2467
		[Token(Token = "0x20009A3")]
		public static class Actions
		{
			// Token: 0x020009A4 RID: 2468
			[Token(Token = "0x20009A4")]
			public class OpenSign : NPCInteraction
			{
				// Token: 0x06005115 RID: 20757 RVA: 0x00025B00 File Offset: 0x00023D00
				[Token(Token = "0x6005115")]
				[Address(RVA = "0x7781CC", Offset = "0x7781CC", VA = "0x7781CC", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x06005116 RID: 20758 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005116")]
				[Address(RVA = "0x778248", Offset = "0x778248", VA = "0x778248", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x06005117 RID: 20759 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005117")]
				[Address(RVA = "0x77830C", Offset = "0x77830C", VA = "0x77830C", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x06005118 RID: 20760 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005118")]
				[Address(RVA = "0x778074", Offset = "0x778074", VA = "0x778074")]
				public OpenSign()
				{
				}
			}

			// Token: 0x020009A5 RID: 2469
			[Token(Token = "0x20009A5")]
			public class OpenShop : NPCInteraction
			{
				// Token: 0x06005119 RID: 20761 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005119")]
				[Address(RVA = "0x7780EC", Offset = "0x7780EC", VA = "0x7780EC")]
				public OpenShop(int npcType, int shopIndex, [Optional] string customTextKey)
				{
				}

				// Token: 0x0600511A RID: 20762 RVA: 0x00025B18 File Offset: 0x00023D18
				[Token(Token = "0x600511A")]
				[Address(RVA = "0x77839C", Offset = "0x77839C", VA = "0x77839C", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x0600511B RID: 20763 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600511B")]
				[Address(RVA = "0x7783BC", Offset = "0x7783BC", VA = "0x7783BC", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x0600511C RID: 20764 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600511C")]
				[Address(RVA = "0x778498", Offset = "0x778498", VA = "0x778498", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x040094CD RID: 38093
				[Token(Token = "0x40094CD")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private int _shopIndex;

				// Token: 0x040094CE RID: 38094
				[Token(Token = "0x40094CE")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				private int _npcType;

				// Token: 0x040094CF RID: 38095
				[Token(Token = "0x40094CF")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private string _customTextKey;
			}

			// Token: 0x020009A6 RID: 2470
			[Token(Token = "0x20009A6")]
			public class StardewValleyBit : NPCInteraction
			{
				// Token: 0x170009A0 RID: 2464
				// (get) Token: 0x0600511D RID: 20765 RVA: 0x00025B30 File Offset: 0x00023D30
				[Token(Token = "0x170009A0")]
				public override bool ShowExclamation
				{
					[Token(Token = "0x600511D")]
					[Address(RVA = "0x778520", Offset = "0x778520", VA = "0x778520", Slot = "7")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x0600511E RID: 20766 RVA: 0x00025B48 File Offset: 0x00023D48
				[Token(Token = "0x600511E")]
				[Address(RVA = "0x778528", Offset = "0x778528", VA = "0x778528", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x0600511F RID: 20767 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600511F")]
				[Address(RVA = "0x7785FC", Offset = "0x7785FC", VA = "0x7785FC", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x06005120 RID: 20768 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005120")]
				[Address(RVA = "0x77867C", Offset = "0x77867C", VA = "0x77867C", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x06005121 RID: 20769 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005121")]
				[Address(RVA = "0x77807C", Offset = "0x77807C", VA = "0x77807C")]
				public StardewValleyBit()
				{
				}
			}

			// Token: 0x020009A7 RID: 2471
			[Token(Token = "0x20009A7")]
			public class DryadPurification : NPCInteraction
			{
				// Token: 0x06005122 RID: 20770 RVA: 0x00025B60 File Offset: 0x00023D60
				[Token(Token = "0x6005122")]
				[Address(RVA = "0x778710", Offset = "0x778710", VA = "0x778710", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x06005123 RID: 20771 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005123")]
				[Address(RVA = "0x7787E8", Offset = "0x7787E8", VA = "0x7787E8", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x06005124 RID: 20772 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005124")]
				[Address(RVA = "0x778874", Offset = "0x778874", VA = "0x778874", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x06005125 RID: 20773 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005125")]
				[Address(RVA = "0x778084", Offset = "0x778084", VA = "0x778084")]
				public DryadPurification()
				{
				}
			}

			// Token: 0x020009A8 RID: 2472
			[Token(Token = "0x20009A8")]
			public class AnglerQuest : NPCInteraction
			{
				// Token: 0x170009A1 RID: 2465
				// (get) Token: 0x06005126 RID: 20774 RVA: 0x00025B78 File Offset: 0x00023D78
				[Token(Token = "0x170009A1")]
				public override bool ShowExclamation
				{
					[Token(Token = "0x6005126")]
					[Address(RVA = "0x7789AC", Offset = "0x7789AC", VA = "0x7789AC", Slot = "7")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x06005127 RID: 20775 RVA: 0x00025B90 File Offset: 0x00023D90
				[Token(Token = "0x6005127")]
				[Address(RVA = "0x778A10", Offset = "0x778A10", VA = "0x778A10", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x06005128 RID: 20776 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005128")]
				[Address(RVA = "0x778A2C", Offset = "0x778A2C", VA = "0x778A2C", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x06005129 RID: 20777 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005129")]
				[Address(RVA = "0x778AB8", Offset = "0x778AB8", VA = "0x778AB8", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x0600512A RID: 20778 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600512A")]
				[Address(RVA = "0x77808C", Offset = "0x77808C", VA = "0x77808C")]
				public AnglerQuest()
				{
				}
			}

			// Token: 0x020009A9 RID: 2473
			[Token(Token = "0x20009A9")]
			public class PetAnimal : NPCInteraction
			{
				// Token: 0x0600512B RID: 20779 RVA: 0x00025BA8 File Offset: 0x00023DA8
				[Token(Token = "0x600512B")]
				[Address(RVA = "0x778B18", Offset = "0x778B18", VA = "0x778B18", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x0600512C RID: 20780 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600512C")]
				[Address(RVA = "0x778B98", Offset = "0x778B98", VA = "0x778B98", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x0600512D RID: 20781 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600512D")]
				[Address(RVA = "0x778C18", Offset = "0x778C18", VA = "0x778C18", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x0600512E RID: 20782 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600512E")]
				[Address(RVA = "0x778094", Offset = "0x778094", VA = "0x778094")]
				public PetAnimal()
				{
				}
			}

			// Token: 0x020009AA RID: 2474
			[Token(Token = "0x20009AA")]
			public class OldManCurse : NPCInteraction
			{
				// Token: 0x0600512F RID: 20783 RVA: 0x00025BC0 File Offset: 0x00023DC0
				[Token(Token = "0x600512F")]
				[Address(RVA = "0x778DF0", Offset = "0x778DF0", VA = "0x778DF0", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x06005130 RID: 20784 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005130")]
				[Address(RVA = "0x778E68", Offset = "0x778E68", VA = "0x778E68", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x06005131 RID: 20785 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005131")]
				[Address(RVA = "0x778EF4", Offset = "0x778EF4", VA = "0x778EF4", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x06005132 RID: 20786 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005132")]
				[Address(RVA = "0x77809C", Offset = "0x77809C", VA = "0x77809C")]
				public OldManCurse()
				{
				}
			}

			// Token: 0x020009AB RID: 2475
			[Token(Token = "0x20009AB")]
			public class GuideTip : NPCInteraction
			{
				// Token: 0x06005133 RID: 20787 RVA: 0x00025BD8 File Offset: 0x00023DD8
				[Token(Token = "0x6005133")]
				[Address(RVA = "0x77907C", Offset = "0x77907C", VA = "0x77907C", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x06005134 RID: 20788 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005134")]
				[Address(RVA = "0x779094", Offset = "0x779094", VA = "0x779094", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x06005135 RID: 20789 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005135")]
				[Address(RVA = "0x779120", Offset = "0x779120", VA = "0x779120", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x06005136 RID: 20790 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005136")]
				[Address(RVA = "0x7780A4", Offset = "0x7780A4", VA = "0x7780A4")]
				public GuideTip()
				{
				}
			}

			// Token: 0x020009AC RID: 2476
			[Token(Token = "0x20009AC")]
			public class TaxCollectorCollectTaxes : NPCInteraction
			{
				// Token: 0x06005137 RID: 20791 RVA: 0x00025BF0 File Offset: 0x00023DF0
				[Token(Token = "0x6005137")]
				[Address(RVA = "0x7791B8", Offset = "0x7791B8", VA = "0x7791B8", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x06005138 RID: 20792 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005138")]
				[Address(RVA = "0x7791D4", Offset = "0x7791D4", VA = "0x7791D4", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x06005139 RID: 20793 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005139")]
				[Address(RVA = "0x779260", Offset = "0x779260", VA = "0x779260", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x0600513A RID: 20794 RVA: 0x00025C08 File Offset: 0x00023E08
				[Token(Token = "0x600513A")]
				[Address(RVA = "0x7792C0", Offset = "0x7792C0", VA = "0x7792C0", Slot = "8")]
				public override bool TryAddCoins(ref Color chatColor, out int coinValue)
				{
					return default(bool);
				}

				// Token: 0x0600513B RID: 20795 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600513B")]
				[Address(RVA = "0x777F6C", Offset = "0x777F6C", VA = "0x777F6C")]
				public TaxCollectorCollectTaxes()
				{
				}
			}

			// Token: 0x020009AD RID: 2477
			[Token(Token = "0x20009AD")]
			public class NurseHeal : NPCInteraction
			{
				// Token: 0x0600513C RID: 20796 RVA: 0x00025C20 File Offset: 0x00023E20
				[Token(Token = "0x600513C")]
				[Address(RVA = "0x779348", Offset = "0x779348", VA = "0x779348", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x0600513D RID: 20797 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600513D")]
				[Address(RVA = "0x779360", Offset = "0x779360", VA = "0x779360", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x0600513E RID: 20798 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600513E")]
				[Address(RVA = "0x7793EC", Offset = "0x7793EC", VA = "0x7793EC", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x0600513F RID: 20799 RVA: 0x00025C38 File Offset: 0x00023E38
				[Token(Token = "0x600513F")]
				[Address(RVA = "0x779454", Offset = "0x779454", VA = "0x779454", Slot = "8")]
				public override bool TryAddCoins(ref Color chatColor, out int coinValue)
				{
					return default(bool);
				}

				// Token: 0x06005140 RID: 20800 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005140")]
				[Address(RVA = "0x778064", Offset = "0x778064", VA = "0x778064")]
				public NurseHeal()
				{
				}
			}

			// Token: 0x020009AE RID: 2478
			[Token(Token = "0x20009AE")]
			public class CloseChat : NPCInteraction
			{
				// Token: 0x06005141 RID: 20801 RVA: 0x00025C50 File Offset: 0x00023E50
				[Token(Token = "0x6005141")]
				[Address(RVA = "0x7794E4", Offset = "0x7794E4", VA = "0x7794E4", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x06005142 RID: 20802 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005142")]
				[Address(RVA = "0x7794EC", Offset = "0x7794EC", VA = "0x7794EC", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x06005143 RID: 20803 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005143")]
				[Address(RVA = "0x779578", Offset = "0x779578", VA = "0x779578", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x06005144 RID: 20804 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005144")]
				[Address(RVA = "0x77806C", Offset = "0x77806C", VA = "0x77806C")]
				public CloseChat()
				{
				}
			}

			// Token: 0x020009AF RID: 2479
			[Token(Token = "0x20009AF")]
			public class ReportHappiness : NPCInteraction
			{
				// Token: 0x06005145 RID: 20805 RVA: 0x00025C68 File Offset: 0x00023E68
				[Token(Token = "0x6005145")]
				[Address(RVA = "0x7795D8", Offset = "0x7795D8", VA = "0x7795D8", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x06005146 RID: 20806 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005146")]
				[Address(RVA = "0x779720", Offset = "0x779720", VA = "0x779720", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x06005147 RID: 20807 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005147")]
				[Address(RVA = "0x7797A0", Offset = "0x7797A0", VA = "0x7797A0", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x06005148 RID: 20808 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005148")]
				[Address(RVA = "0x7780DC", Offset = "0x7780DC", VA = "0x7780DC")]
				public ReportHappiness()
				{
				}
			}

			// Token: 0x020009B0 RID: 2480
			[Token(Token = "0x20009B0")]
			public class RequestHome : NPCInteraction
			{
				// Token: 0x170009A2 RID: 2466
				// (get) Token: 0x06005149 RID: 20809 RVA: 0x00025C80 File Offset: 0x00023E80
				[Token(Token = "0x170009A2")]
				public override bool ShowExclamation
				{
					[Token(Token = "0x6005149")]
					[Address(RVA = "0x7798A0", Offset = "0x7798A0", VA = "0x7798A0", Slot = "7")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x0600514A RID: 20810 RVA: 0x00025C98 File Offset: 0x00023E98
				[Token(Token = "0x600514A")]
				[Address(RVA = "0x7798A8", Offset = "0x7798A8", VA = "0x7798A8", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x0600514B RID: 20811 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600514B")]
				[Address(RVA = "0x779958", Offset = "0x779958", VA = "0x779958", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x0600514C RID: 20812 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600514C")]
				[Address(RVA = "0x7799D8", Offset = "0x7799D8", VA = "0x7799D8", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x0600514D RID: 20813 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600514D")]
				[Address(RVA = "0x7780E4", Offset = "0x7780E4", VA = "0x7780E4")]
				public RequestHome()
				{
				}
			}

			// Token: 0x020009B1 RID: 2481
			[Token(Token = "0x20009B1")]
			public class PartyGirlMusicSwap : NPCInteraction
			{
				// Token: 0x0600514E RID: 20814 RVA: 0x00025CB0 File Offset: 0x00023EB0
				[Token(Token = "0x600514E")]
				[Address(RVA = "0x779ECC", Offset = "0x779ECC", VA = "0x779ECC", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x0600514F RID: 20815 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600514F")]
				[Address(RVA = "0x779EE4", Offset = "0x779EE4", VA = "0x779EE4", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x06005150 RID: 20816 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005150")]
				[Address(RVA = "0x779F64", Offset = "0x779F64", VA = "0x779F64", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x06005151 RID: 20817 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005151")]
				[Address(RVA = "0x7780AC", Offset = "0x7780AC", VA = "0x7780AC")]
				public PartyGirlMusicSwap()
				{
				}
			}

			// Token: 0x020009B2 RID: 2482
			[Token(Token = "0x20009B2")]
			public class GuideReverseCrafting : NPCInteraction
			{
				// Token: 0x06005152 RID: 20818 RVA: 0x00025CC8 File Offset: 0x00023EC8
				[Token(Token = "0x6005152")]
				[Address(RVA = "0x779FC4", Offset = "0x779FC4", VA = "0x779FC4", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x06005153 RID: 20819 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005153")]
				[Address(RVA = "0x779FDC", Offset = "0x779FDC", VA = "0x779FDC", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x06005154 RID: 20820 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005154")]
				[Address(RVA = "0x77A068", Offset = "0x77A068", VA = "0x77A068", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x06005155 RID: 20821 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005155")]
				[Address(RVA = "0x7780B4", Offset = "0x7780B4", VA = "0x7780B4")]
				public GuideReverseCrafting()
				{
				}
			}

			// Token: 0x020009B3 RID: 2483
			[Token(Token = "0x20009B3")]
			public class TinkererReforge : NPCInteraction
			{
				// Token: 0x06005156 RID: 20822 RVA: 0x00025CE0 File Offset: 0x00023EE0
				[Token(Token = "0x6005156")]
				[Address(RVA = "0x77A0C8", Offset = "0x77A0C8", VA = "0x77A0C8", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x06005157 RID: 20823 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005157")]
				[Address(RVA = "0x77A0E0", Offset = "0x77A0E0", VA = "0x77A0E0", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x06005158 RID: 20824 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005158")]
				[Address(RVA = "0x77A16C", Offset = "0x77A16C", VA = "0x77A16C", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x06005159 RID: 20825 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005159")]
				[Address(RVA = "0x7780BC", Offset = "0x7780BC", VA = "0x7780BC")]
				public TinkererReforge()
				{
				}
			}

			// Token: 0x020009B4 RID: 2484
			[Token(Token = "0x20009B4")]
			public class StylistHairWindow : NPCInteraction
			{
				// Token: 0x0600515A RID: 20826 RVA: 0x00025CF8 File Offset: 0x00023EF8
				[Token(Token = "0x600515A")]
				[Address(RVA = "0x77A1CC", Offset = "0x77A1CC", VA = "0x77A1CC", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x0600515B RID: 20827 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600515B")]
				[Address(RVA = "0x77A1E8", Offset = "0x77A1E8", VA = "0x77A1E8", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x0600515C RID: 20828 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600515C")]
				[Address(RVA = "0x77A268", Offset = "0x77A268", VA = "0x77A268", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x0600515D RID: 20829 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600515D")]
				[Address(RVA = "0x7780C4", Offset = "0x7780C4", VA = "0x7780C4")]
				public StylistHairWindow()
				{
				}
			}

			// Token: 0x020009B5 RID: 2485
			[Token(Token = "0x20009B5")]
			public class DyeTraderRarePlant : NPCInteraction
			{
				// Token: 0x0600515E RID: 20830 RVA: 0x00025D10 File Offset: 0x00023F10
				[Token(Token = "0x600515E")]
				[Address(RVA = "0x77A2C8", Offset = "0x77A2C8", VA = "0x77A2C8", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x0600515F RID: 20831 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600515F")]
				[Address(RVA = "0x77A348", Offset = "0x77A348", VA = "0x77A348", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x06005160 RID: 20832 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005160")]
				[Address(RVA = "0x77A3D4", Offset = "0x77A3D4", VA = "0x77A3D4", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x06005161 RID: 20833 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005161")]
				[Address(RVA = "0x7780CC", Offset = "0x7780CC", VA = "0x7780CC")]
				public DyeTraderRarePlant()
				{
				}
			}

			// Token: 0x020009B6 RID: 2486
			[Token(Token = "0x20009B6")]
			public class TavernkeepAdvice : NPCInteraction
			{
				// Token: 0x06005162 RID: 20834 RVA: 0x00025D28 File Offset: 0x00023F28
				[Token(Token = "0x6005162")]
				[Address(RVA = "0x77A434", Offset = "0x77A434", VA = "0x77A434", Slot = "4")]
				public override bool Condition()
				{
					return default(bool);
				}

				// Token: 0x06005163 RID: 20835 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005163")]
				[Address(RVA = "0x77A450", Offset = "0x77A450", VA = "0x77A450", Slot = "5")]
				public override string GetText()
				{
					return null;
				}

				// Token: 0x06005164 RID: 20836 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005164")]
				[Address(RVA = "0x77A4D0", Offset = "0x77A4D0", VA = "0x77A4D0", Slot = "6")]
				public override void Interact()
				{
				}

				// Token: 0x06005165 RID: 20837 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005165")]
				[Address(RVA = "0x7780D4", Offset = "0x7780D4", VA = "0x7780D4")]
				public TavernkeepAdvice()
				{
				}
			}
		}
	}
}
