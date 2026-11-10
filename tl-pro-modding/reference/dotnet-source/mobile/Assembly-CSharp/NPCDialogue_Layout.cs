using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200024D RID: 589
[Token(Token = "0x200024D")]
public class NPCDialogue_Layout : LayoutDefinition
{
	// Token: 0x06000E4E RID: 3662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4E")]
	[Address(RVA = "0xC938AC", Offset = "0xC938AC", VA = "0xC938AC")]
	private void Awake()
	{
	}

	// Token: 0x06000E4F RID: 3663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4F")]
	[Address(RVA = "0xC93900", Offset = "0xC93900", VA = "0xC93900")]
	public NPCDialogue_Layout()
	{
	}

	// Token: 0x04001ACF RID: 6863
	[Token(Token = "0x4001ACF")]
	[FieldOffset(Offset = "0x0")]
	public static NPCDialogue_Layout Instance;

	// Token: 0x04001AD0 RID: 6864
	[Token(Token = "0x4001AD0")]
	[FieldOffset(Offset = "0xC")]
	public int BackingTextPadding;

	// Token: 0x04001AD1 RID: 6865
	[Token(Token = "0x4001AD1")]
	[FieldOffset(Offset = "0x10")]
	public int BackingTextPaddingController;

	// Token: 0x04001AD2 RID: 6866
	[Token(Token = "0x4001AD2")]
	[FieldOffset(Offset = "0x14")]
	public int MinTextHeight;

	// Token: 0x04001AD3 RID: 6867
	[Token(Token = "0x4001AD3")]
	[FieldOffset(Offset = "0x18")]
	public int TextBackingOffset;

	// Token: 0x04001AD4 RID: 6868
	[Token(Token = "0x4001AD4")]
	[FieldOffset(Offset = "0x1C")]
	public int MaxWidthLastLineAddition;

	// Token: 0x04001AD5 RID: 6869
	[Token(Token = "0x4001AD5")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x04001AD6 RID: 6870
	[Token(Token = "0x4001AD6")]
	[FieldOffset(Offset = "0x24")]
	public String_Layout Text;

	// Token: 0x04001AD7 RID: 6871
	[Token(Token = "0x4001AD7")]
	[FieldOffset(Offset = "0x28")]
	public Panel_Layout TextBacking;

	// Token: 0x04001AD8 RID: 6872
	[Token(Token = "0x4001AD8")]
	[FieldOffset(Offset = "0x2C")]
	public Panel_Layout MenuDivider;

	// Token: 0x04001AD9 RID: 6873
	[Token(Token = "0x4001AD9")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Close;

	// Token: 0x04001ADA RID: 6874
	[Token(Token = "0x4001ADA")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout Option1;

	// Token: 0x04001ADB RID: 6875
	[Token(Token = "0x4001ADB")]
	[FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Option2;

	// Token: 0x04001ADC RID: 6876
	[Token(Token = "0x4001ADC")]
	[FieldOffset(Offset = "0x3C")]
	public TransactionButton_Layout Happiness;

	// Token: 0x04001ADD RID: 6877
	[Token(Token = "0x4001ADD")]
	[FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout NPCHousing;

	// Token: 0x04001ADE RID: 6878
	[Token(Token = "0x4001ADE")]
	[FieldOffset(Offset = "0x44")]
	public TransactionButton_Layout HousingMenu;

	// Token: 0x04001ADF RID: 6879
	[Token(Token = "0x4001ADF")]
	[FieldOffset(Offset = "0x48")]
	public String_Layout Option1Cost;

	// Token: 0x04001AE0 RID: 6880
	[Token(Token = "0x4001AE0")]
	[FieldOffset(Offset = "0x4C")]
	public String_Layout Option1CostController;

	// Token: 0x04001AE1 RID: 6881
	[Token(Token = "0x4001AE1")]
	[FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout CornerImage;

	// Token: 0x04001AE2 RID: 6882
	[Token(Token = "0x4001AE2")]
	[FieldOffset(Offset = "0x54")]
	public TransactionButton_Layout CornerImageController;

	// Token: 0x04001AE3 RID: 6883
	[Token(Token = "0x4001AE3")]
	[FieldOffset(Offset = "0x58")]
	public String_Layout CornerText;

	// Token: 0x04001AE4 RID: 6884
	[Token(Token = "0x4001AE4")]
	[FieldOffset(Offset = "0x5C")]
	public String_Layout CornerTextController;

	// Token: 0x04001AE5 RID: 6885
	[Token(Token = "0x4001AE5")]
	[FieldOffset(Offset = "0x60")]
	public String_Layout DialogueItemName;

	// Token: 0x04001AE6 RID: 6886
	[Token(Token = "0x4001AE6")]
	[FieldOffset(Offset = "0x64")]
	public Panel_Layout DialogueItemNameDivider;

	// Token: 0x04001AE7 RID: 6887
	[Token(Token = "0x4001AE7")]
	[FieldOffset(Offset = "0x68")]
	public Panel_Layout DialogueItem;

	// Token: 0x04001AE8 RID: 6888
	[Token(Token = "0x4001AE8")]
	[FieldOffset(Offset = "0x6C")]
	public Panel_Layout DialogueItemBacking;

	// Token: 0x04001AE9 RID: 6889
	[Token(Token = "0x4001AE9")]
	[FieldOffset(Offset = "0x70")]
	public Panel_Layout NPCProfileBacking;

	// Token: 0x04001AEA RID: 6890
	[Token(Token = "0x4001AEA")]
	[FieldOffset(Offset = "0x74")]
	public Panel_Layout NPCProfileImage;

	// Token: 0x04001AEB RID: 6891
	[Token(Token = "0x4001AEB")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve NPCProfileBounce;

	// Token: 0x04001AEC RID: 6892
	[Token(Token = "0x4001AEC")]
	[FieldOffset(Offset = "0x7C")]
	public NPCDialogue_Layout.Icons_Layout Icons;

	// Token: 0x0200024E RID: 590
	[Token(Token = "0x200024E")]
	[Serializable]
	public class Icons_Layout
	{
		// Token: 0x06000E50 RID: 3664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E50")]
		[Address(RVA = "0xC93970", Offset = "0xC93970", VA = "0xC93970")]
		public Icons_Layout()
		{
		}

		// Token: 0x04001AED RID: 6893
		[Token(Token = "0x4001AED")]
		[FieldOffset(Offset = "0x8")]
		public Texture_Layout SaveIcon;

		// Token: 0x04001AEE RID: 6894
		[Token(Token = "0x4001AEE")]
		[FieldOffset(Offset = "0xC")]
		public Texture_Layout EditIcon;

		// Token: 0x04001AEF RID: 6895
		[Token(Token = "0x4001AEF")]
		[FieldOffset(Offset = "0x10")]
		public Texture_Layout ShopIcon;

		// Token: 0x04001AF0 RID: 6896
		[Token(Token = "0x4001AF0")]
		[FieldOffset(Offset = "0x14")]
		public Texture_Layout StatusIcon;

		// Token: 0x04001AF1 RID: 6897
		[Token(Token = "0x4001AF1")]
		[FieldOffset(Offset = "0x18")]
		public Texture_Layout StatusIconShimmered;

		// Token: 0x04001AF2 RID: 6898
		[Token(Token = "0x4001AF2")]
		[FieldOffset(Offset = "0x1C")]
		public Texture_Layout StrangePlantsIcon;

		// Token: 0x04001AF3 RID: 6899
		[Token(Token = "0x4001AF3")]
		[FieldOffset(Offset = "0x20")]
		public Texture_Layout StrangePlantsIconShimmered;

		// Token: 0x04001AF4 RID: 6900
		[Token(Token = "0x4001AF4")]
		[FieldOffset(Offset = "0x24")]
		public Texture_Layout HairIcon;

		// Token: 0x04001AF5 RID: 6901
		[Token(Token = "0x4001AF5")]
		[FieldOffset(Offset = "0x28")]
		public Texture_Layout HairIconShimmered;

		// Token: 0x04001AF6 RID: 6902
		[Token(Token = "0x4001AF6")]
		[FieldOffset(Offset = "0x2C")]
		public Texture_Layout HealIcon;

		// Token: 0x04001AF7 RID: 6903
		[Token(Token = "0x4001AF7")]
		[FieldOffset(Offset = "0x30")]
		public Texture_Layout HealIconShimmered;

		// Token: 0x04001AF8 RID: 6904
		[Token(Token = "0x4001AF8")]
		[FieldOffset(Offset = "0x34")]
		public Texture_Layout CollectIcon;

		// Token: 0x04001AF9 RID: 6905
		[Token(Token = "0x4001AF9")]
		[FieldOffset(Offset = "0x38")]
		public Texture_Layout CollectIconShimmered;

		// Token: 0x04001AFA RID: 6906
		[Token(Token = "0x4001AFA")]
		[FieldOffset(Offset = "0x3C")]
		public Texture_Layout ReforgeIcon;

		// Token: 0x04001AFB RID: 6907
		[Token(Token = "0x4001AFB")]
		[FieldOffset(Offset = "0x40")]
		public Texture_Layout ReforgeIconShimmered;

		// Token: 0x04001AFC RID: 6908
		[Token(Token = "0x4001AFC")]
		[FieldOffset(Offset = "0x44")]
		public Texture_Layout CraftIcon;

		// Token: 0x04001AFD RID: 6909
		[Token(Token = "0x4001AFD")]
		[FieldOffset(Offset = "0x48")]
		public Texture_Layout HelpIcon;

		// Token: 0x04001AFE RID: 6910
		[Token(Token = "0x4001AFE")]
		[FieldOffset(Offset = "0x4C")]
		public Texture_Layout CurseIcon;

		// Token: 0x04001AFF RID: 6911
		[Token(Token = "0x4001AFF")]
		[FieldOffset(Offset = "0x50")]
		public Texture_Layout QuestIcon;

		// Token: 0x04001B00 RID: 6912
		[Token(Token = "0x4001B00")]
		[FieldOffset(Offset = "0x54")]
		public Texture_Layout QuestIconShimmered;

		// Token: 0x04001B01 RID: 6913
		[Token(Token = "0x4001B01")]
		[FieldOffset(Offset = "0x58")]
		public Texture_Layout BartenderIcon;

		// Token: 0x04001B02 RID: 6914
		[Token(Token = "0x4001B02")]
		[FieldOffset(Offset = "0x5C")]
		public Texture_Layout BartenderIconShimmered;

		// Token: 0x04001B03 RID: 6915
		[Token(Token = "0x4001B03")]
		[FieldOffset(Offset = "0x60")]
		public Texture_Layout PetIcon;

		// Token: 0x04001B04 RID: 6916
		[Token(Token = "0x4001B04")]
		[FieldOffset(Offset = "0x64")]
		public Texture_Layout MusicIcon;

		// Token: 0x04001B05 RID: 6917
		[Token(Token = "0x4001B05")]
		[FieldOffset(Offset = "0x68")]
		public Texture_Layout MusicIconShimmered;

		// Token: 0x04001B06 RID: 6918
		[Token(Token = "0x4001B06")]
		[FieldOffset(Offset = "0x6C")]
		public Texture_Layout PainterIcon;

		// Token: 0x04001B07 RID: 6919
		[Token(Token = "0x4001B07")]
		[FieldOffset(Offset = "0x70")]
		public Texture_Layout PainterIconShimmered;
	}
}
