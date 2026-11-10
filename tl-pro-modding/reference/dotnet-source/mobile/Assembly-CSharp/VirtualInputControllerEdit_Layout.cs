using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000241 RID: 577
[Token(Token = "0x2000241")]
public class VirtualInputControllerEdit_Layout : LayoutDefinition
{
	// Token: 0x06000E37 RID: 3639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E37")]
	[Address(RVA = "0xC92E24", Offset = "0xC92E24", VA = "0xC92E24")]
	private void Awake()
	{
	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E38")]
	[Address(RVA = "0xC92E78", Offset = "0xC92E78", VA = "0xC92E78")]
	public VirtualInputControllerEdit_Layout()
	{
	}

	// Token: 0x040019D4 RID: 6612
	[Token(Token = "0x40019D4")]
	[FieldOffset(Offset = "0x0")]
	public static VirtualInputControllerEdit_Layout Instance;

	// Token: 0x040019D5 RID: 6613
	[Token(Token = "0x40019D5")]
	[FieldOffset(Offset = "0xC")]
	public float ControllerDragSpeed;

	// Token: 0x040019D6 RID: 6614
	[Token(Token = "0x40019D6")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Finish;

	// Token: 0x040019D7 RID: 6615
	[Token(Token = "0x40019D7")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout CancelChanges;

	// Token: 0x040019D8 RID: 6616
	[Token(Token = "0x40019D8")]
	[FieldOffset(Offset = "0x18")]
	public ItemGrid_Layout ControlSelection;

	// Token: 0x040019D9 RID: 6617
	[Token(Token = "0x40019D9")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout LeftInterfaceRegion;

	// Token: 0x040019DA RID: 6618
	[Token(Token = "0x40019DA")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout RightInterfaceRegion;

	// Token: 0x040019DB RID: 6619
	[Token(Token = "0x40019DB")]
	[FieldOffset(Offset = "0x24")]
	public Color LeftInterfaceRegionDraggingBackingColor;

	// Token: 0x040019DC RID: 6620
	[Token(Token = "0x40019DC")]
	[FieldOffset(Offset = "0x28")]
	public Color LeftInterfaceRegionDraggingBorderColor;

	// Token: 0x040019DD RID: 6621
	[Token(Token = "0x40019DD")]
	[FieldOffset(Offset = "0x2C")]
	public Color RightInterfaceRegionDraggingBackingColor;

	// Token: 0x040019DE RID: 6622
	[Token(Token = "0x40019DE")]
	[FieldOffset(Offset = "0x30")]
	public Color RightInterfaceRegionDraggingBorderColor;

	// Token: 0x040019DF RID: 6623
	[Token(Token = "0x40019DF")]
	[FieldOffset(Offset = "0x34")]
	public Panel_Layout ScreenBacking;

	// Token: 0x040019E0 RID: 6624
	[Token(Token = "0x40019E0")]
	[FieldOffset(Offset = "0x38")]
	public Panel_Layout ControlsBacking;

	// Token: 0x040019E1 RID: 6625
	[Token(Token = "0x40019E1")]
	[FieldOffset(Offset = "0x3C")]
	public ItemGrid_Layout ControlsGrid;

	// Token: 0x040019E2 RID: 6626
	[Token(Token = "0x40019E2")]
	[FieldOffset(Offset = "0x40")]
	public float ControlsItemScale;

	// Token: 0x040019E3 RID: 6627
	[Token(Token = "0x40019E3")]
	[FieldOffset(Offset = "0x44")]
	public Vector2 ControlsGridAxisOffset;

	// Token: 0x040019E4 RID: 6628
	[Token(Token = "0x40019E4")]
	[FieldOffset(Offset = "0x4C")]
	public Vector2 ControlsGridButtonOffset;

	// Token: 0x040019E5 RID: 6629
	[Token(Token = "0x40019E5")]
	[FieldOffset(Offset = "0x54")]
	public TransactionButton_Layout Mappings;

	// Token: 0x040019E6 RID: 6630
	[Token(Token = "0x40019E6")]
	[FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Controls;

	// Token: 0x040019E7 RID: 6631
	[Token(Token = "0x40019E7")]
	[FieldOffset(Offset = "0x5C")]
	public float InventoryColorScale;

	// Token: 0x040019E8 RID: 6632
	[Token(Token = "0x40019E8")]
	[FieldOffset(Offset = "0x60")]
	public VirtualInputControllerEdit_Layout.SlotPriority ControlPriority;

	// Token: 0x040019E9 RID: 6633
	[Token(Token = "0x40019E9")]
	[FieldOffset(Offset = "0x64")]
	public VirtualInputControllerEdit_Layout.ControlsWidgets EditControlWidgets;

	// Token: 0x040019EA RID: 6634
	[Token(Token = "0x40019EA")]
	[FieldOffset(Offset = "0x68")]
	public VirtualInputControllerEdit_Layout.ProfileWidgets EditProfileWidgets;

	// Token: 0x040019EB RID: 6635
	[Token(Token = "0x40019EB")]
	[FieldOffset(Offset = "0x6C")]
	public VirtualInputControllerEdit_Layout.AdjustWidgets AdjustControls;

	// Token: 0x040019EC RID: 6636
	[Token(Token = "0x40019EC")]
	[FieldOffset(Offset = "0x70")]
	public String_Layout GroupButtonIndex1;

	// Token: 0x040019ED RID: 6637
	[Token(Token = "0x40019ED")]
	[FieldOffset(Offset = "0x74")]
	public String_Layout GroupButtonIndex2;

	// Token: 0x040019EE RID: 6638
	[Token(Token = "0x40019EE")]
	[FieldOffset(Offset = "0x78")]
	public String_Layout GroupButtonIndex3;

	// Token: 0x040019EF RID: 6639
	[Token(Token = "0x40019EF")]
	[FieldOffset(Offset = "0x7C")]
	public String_Layout GroupButtonIndex4;

	// Token: 0x02000242 RID: 578
	[Token(Token = "0x2000242")]
	[Serializable]
	public class SlotPriority
	{
		// Token: 0x06000E39 RID: 3641 RVA: 0x00007920 File Offset: 0x00005B20
		[Token(Token = "0x6000E39")]
		[Address(RVA = "0xC92F50", Offset = "0xC92F50", VA = "0xC92F50")]
		public int Priority(VirtualControlsHardwareConfigurationMapping_Layout.ContolType type)
		{
			return 0;
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0xC930BC", Offset = "0xC930BC", VA = "0xC930BC")]
		public SlotPriority()
		{
		}

		// Token: 0x040019F0 RID: 6640
		[Token(Token = "0x40019F0")]
		[FieldOffset(Offset = "0x8")]
		public int AutoFire;

		// Token: 0x040019F1 RID: 6641
		[Token(Token = "0x40019F1")]
		[FieldOffset(Offset = "0xC")]
		public int SmartCursor;

		// Token: 0x040019F2 RID: 6642
		[Token(Token = "0x40019F2")]
		[FieldOffset(Offset = "0x10")]
		public int CombatTargetting;

		// Token: 0x040019F3 RID: 6643
		[Token(Token = "0x40019F3")]
		[FieldOffset(Offset = "0x14")]
		public int Jump;

		// Token: 0x040019F4 RID: 6644
		[Token(Token = "0x40019F4")]
		[FieldOffset(Offset = "0x18")]
		public int Heal;

		// Token: 0x040019F5 RID: 6645
		[Token(Token = "0x40019F5")]
		[FieldOffset(Offset = "0x1C")]
		public int Mana;

		// Token: 0x040019F6 RID: 6646
		[Token(Token = "0x40019F6")]
		[FieldOffset(Offset = "0x20")]
		public int Buff;

		// Token: 0x040019F7 RID: 6647
		[Token(Token = "0x40019F7")]
		[FieldOffset(Offset = "0x24")]
		public int Mount;

		// Token: 0x040019F8 RID: 6648
		[Token(Token = "0x40019F8")]
		[FieldOffset(Offset = "0x28")]
		public int Interact;

		// Token: 0x040019F9 RID: 6649
		[Token(Token = "0x40019F9")]
		[FieldOffset(Offset = "0x2C")]
		public int InteractOnly;

		// Token: 0x040019FA RID: 6650
		[Token(Token = "0x40019FA")]
		[FieldOffset(Offset = "0x30")]
		public int ToggleFireInteract;

		// Token: 0x040019FB RID: 6651
		[Token(Token = "0x40019FB")]
		[FieldOffset(Offset = "0x34")]
		public int Fire;

		// Token: 0x040019FC RID: 6652
		[Token(Token = "0x40019FC")]
		[FieldOffset(Offset = "0x38")]
		public int GrappleAxis;

		// Token: 0x040019FD RID: 6653
		[Token(Token = "0x40019FD")]
		[FieldOffset(Offset = "0x3C")]
		public int AutoSelect;

		// Token: 0x040019FE RID: 6654
		[Token(Token = "0x40019FE")]
		[FieldOffset(Offset = "0x40")]
		public int ZoomIn;

		// Token: 0x040019FF RID: 6655
		[Token(Token = "0x40019FF")]
		[FieldOffset(Offset = "0x44")]
		public int ZoomOut;

		// Token: 0x04001A00 RID: 6656
		[Token(Token = "0x4001A00")]
		[FieldOffset(Offset = "0x48")]
		public int Move;

		// Token: 0x04001A01 RID: 6657
		[Token(Token = "0x4001A01")]
		[FieldOffset(Offset = "0x4C")]
		public int Aim;

		// Token: 0x04001A02 RID: 6658
		[Token(Token = "0x4001A02")]
		[FieldOffset(Offset = "0x50")]
		public int GrappleFire;

		// Token: 0x04001A03 RID: 6659
		[Token(Token = "0x4001A03")]
		[FieldOffset(Offset = "0x54")]
		public int ProfileSwitch;

		// Token: 0x04001A04 RID: 6660
		[Token(Token = "0x4001A04")]
		[FieldOffset(Offset = "0x58")]
		public int Unbound;

		// Token: 0x04001A05 RID: 6661
		[Token(Token = "0x4001A05")]
		[FieldOffset(Offset = "0x5C")]
		public int InventoryToggle;

		// Token: 0x04001A06 RID: 6662
		[Token(Token = "0x4001A06")]
		[FieldOffset(Offset = "0x60")]
		public int Settings;

		// Token: 0x04001A07 RID: 6663
		[Token(Token = "0x4001A07")]
		[FieldOffset(Offset = "0x64")]
		public int Loadout1;

		// Token: 0x04001A08 RID: 6664
		[Token(Token = "0x4001A08")]
		[FieldOffset(Offset = "0x68")]
		public int Loadout2;

		// Token: 0x04001A09 RID: 6665
		[Token(Token = "0x4001A09")]
		[FieldOffset(Offset = "0x6C")]
		public int Loadout3;

		// Token: 0x04001A0A RID: 6666
		[Token(Token = "0x4001A0A")]
		[FieldOffset(Offset = "0x70")]
		public int LoadoutCycle;
	}

	// Token: 0x02000243 RID: 579
	[Token(Token = "0x2000243")]
	[Serializable]
	public class ControlsWidgets
	{
		// Token: 0x06000E3B RID: 3643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0xC930C4", Offset = "0xC930C4", VA = "0xC930C4")]
		public TransactionButton_Layout GetProfileTemplate(int index)
		{
			return null;
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0xC93198", Offset = "0xC93198", VA = "0xC93198")]
		public ControlsWidgets()
		{
		}

		// Token: 0x04001A0B RID: 6667
		[Token(Token = "0x4001A0B")]
		[FieldOffset(Offset = "0x8")]
		public Panel_Layout OptionsGreyout;

		// Token: 0x04001A0C RID: 6668
		[Token(Token = "0x4001A0C")]
		[FieldOffset(Offset = "0xC")]
		public TransactionButton_Layout ProfileValue;

		// Token: 0x04001A0D RID: 6669
		[Token(Token = "0x4001A0D")]
		[FieldOffset(Offset = "0x10")]
		public String_Layout ProfileTitle;

		// Token: 0x04001A0E RID: 6670
		[Token(Token = "0x4001A0E")]
		[FieldOffset(Offset = "0x14")]
		public Panel_Layout ControlButtonBacking;

		// Token: 0x04001A0F RID: 6671
		[Token(Token = "0x4001A0F")]
		[FieldOffset(Offset = "0x18")]
		public TransactionButton_Layout ButtonControl;

		// Token: 0x04001A10 RID: 6672
		[Token(Token = "0x4001A10")]
		[FieldOffset(Offset = "0x1C")]
		public TransactionButton_Layout StickControl;

		// Token: 0x04001A11 RID: 6673
		[Token(Token = "0x4001A11")]
		[FieldOffset(Offset = "0x20")]
		public TransactionButton_Layout RadialControl;

		// Token: 0x04001A12 RID: 6674
		[Token(Token = "0x4001A12")]
		[FieldOffset(Offset = "0x24")]
		public String_Layout TipText;

		// Token: 0x04001A13 RID: 6675
		[Token(Token = "0x4001A13")]
		[FieldOffset(Offset = "0x28")]
		public TransactionButton_Layout ProfileTemplateValue;

		// Token: 0x04001A14 RID: 6676
		[Token(Token = "0x4001A14")]
		[FieldOffset(Offset = "0x2C")]
		public Panel_Layout ProfileTemplateOptionsBacking;

		// Token: 0x04001A15 RID: 6677
		[Token(Token = "0x4001A15")]
		[FieldOffset(Offset = "0x30")]
		public TransactionButton_Layout ProfileTemplate1;

		// Token: 0x04001A16 RID: 6678
		[Token(Token = "0x4001A16")]
		[FieldOffset(Offset = "0x34")]
		public TransactionButton_Layout ProfileTemplate2;

		// Token: 0x04001A17 RID: 6679
		[Token(Token = "0x4001A17")]
		[FieldOffset(Offset = "0x38")]
		public TransactionButton_Layout ProfileTemplate3;

		// Token: 0x04001A18 RID: 6680
		[Token(Token = "0x4001A18")]
		[FieldOffset(Offset = "0x3C")]
		public TransactionButton_Layout ProfileTemplate4;

		// Token: 0x04001A19 RID: 6681
		[Token(Token = "0x4001A19")]
		[FieldOffset(Offset = "0x40")]
		public TransactionButton_Layout ProfileTemplate5;

		// Token: 0x04001A1A RID: 6682
		[Token(Token = "0x4001A1A")]
		[FieldOffset(Offset = "0x44")]
		public TransactionButton_Layout ProfileTemplate6;

		// Token: 0x04001A1B RID: 6683
		[Token(Token = "0x4001A1B")]
		[FieldOffset(Offset = "0x48")]
		public TransactionButton_Layout ProfileTemplate7;

		// Token: 0x04001A1C RID: 6684
		[Token(Token = "0x4001A1C")]
		[FieldOffset(Offset = "0x4C")]
		public TransactionButton_Layout ProfileTemplate8;

		// Token: 0x04001A1D RID: 6685
		[Token(Token = "0x4001A1D")]
		[FieldOffset(Offset = "0x50")]
		public TransactionButton_Layout ProfileTemplate9;

		// Token: 0x04001A1E RID: 6686
		[Token(Token = "0x4001A1E")]
		[FieldOffset(Offset = "0x54")]
		public TransactionButton_Layout ProfileTemplate10;

		// Token: 0x04001A1F RID: 6687
		[Token(Token = "0x4001A1F")]
		[FieldOffset(Offset = "0x58")]
		public TransactionButton_Layout ProfileTemplate11;

		// Token: 0x04001A20 RID: 6688
		[Token(Token = "0x4001A20")]
		[FieldOffset(Offset = "0x5C")]
		public TransactionButton_Layout ProfileTemplate12;

		// Token: 0x04001A21 RID: 6689
		[Token(Token = "0x4001A21")]
		[FieldOffset(Offset = "0x60")]
		public Panel_Layout MenuDivider;

		// Token: 0x04001A22 RID: 6690
		[Token(Token = "0x4001A22")]
		[FieldOffset(Offset = "0x64")]
		public Panel_Layout PageOptionsBacking;

		// Token: 0x04001A23 RID: 6691
		[Token(Token = "0x4001A23")]
		[FieldOffset(Offset = "0x68")]
		public TransactionButton_Layout PageOptionValue;

		// Token: 0x04001A24 RID: 6692
		[Token(Token = "0x4001A24")]
		[FieldOffset(Offset = "0x6C")]
		public TransactionButton_Layout BottomControls;

		// Token: 0x04001A25 RID: 6693
		[Token(Token = "0x4001A25")]
		[FieldOffset(Offset = "0x70")]
		public TransactionButton_Layout SideControls;

		// Token: 0x04001A26 RID: 6694
		[Token(Token = "0x4001A26")]
		[FieldOffset(Offset = "0x74")]
		public TransactionButton_Layout Undo;

		// Token: 0x04001A27 RID: 6695
		[Token(Token = "0x4001A27")]
		[FieldOffset(Offset = "0x78")]
		public TransactionButton_Layout Redo;

		// Token: 0x04001A28 RID: 6696
		[Token(Token = "0x4001A28")]
		[FieldOffset(Offset = "0x7C")]
		public TransactionButton_Layout Copy;

		// Token: 0x04001A29 RID: 6697
		[Token(Token = "0x4001A29")]
		[FieldOffset(Offset = "0x80")]
		public TransactionButton_Layout Paste;
	}

	// Token: 0x02000244 RID: 580
	[Token(Token = "0x2000244")]
	[Serializable]
	public class ProfileWidgets
	{
		// Token: 0x06000E3D RID: 3645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0xC931A0", Offset = "0xC931A0", VA = "0xC931A0")]
		public ProfileWidgets()
		{
		}

		// Token: 0x04001A2A RID: 6698
		[Token(Token = "0x4001A2A")]
		[FieldOffset(Offset = "0x8")]
		public Panel_Layout OptionsGreyout;

		// Token: 0x04001A2B RID: 6699
		[Token(Token = "0x4001A2B")]
		[FieldOffset(Offset = "0xC")]
		public TransactionButton_Layout CustomProfileEdit;

		// Token: 0x04001A2C RID: 6700
		[Token(Token = "0x4001A2C")]
		[FieldOffset(Offset = "0x10")]
		public TransactionButton_Layout CustomProfileSelect;

		// Token: 0x04001A2D RID: 6701
		[Token(Token = "0x4001A2D")]
		[FieldOffset(Offset = "0x14")]
		public TransactionButton_Layout ControlsAdjustPosition;

		// Token: 0x04001A2E RID: 6702
		[Token(Token = "0x4001A2E")]
		[FieldOffset(Offset = "0x18")]
		public TransactionButton_Layout ProfileValue;

		// Token: 0x04001A2F RID: 6703
		[Token(Token = "0x4001A2F")]
		[FieldOffset(Offset = "0x1C")]
		public Panel_Layout ProfileOptionsBacking;

		// Token: 0x04001A30 RID: 6704
		[Token(Token = "0x4001A30")]
		[FieldOffset(Offset = "0x20")]
		public TransactionButton_Layout Profile1;

		// Token: 0x04001A31 RID: 6705
		[Token(Token = "0x4001A31")]
		[FieldOffset(Offset = "0x24")]
		public TransactionButton_Layout Profile2;

		// Token: 0x04001A32 RID: 6706
		[Token(Token = "0x4001A32")]
		[FieldOffset(Offset = "0x28")]
		public TransactionButton_Layout Profile3;

		// Token: 0x04001A33 RID: 6707
		[Token(Token = "0x4001A33")]
		[FieldOffset(Offset = "0x2C")]
		public TransactionButton_Layout Profile4;

		// Token: 0x04001A34 RID: 6708
		[Token(Token = "0x4001A34")]
		[FieldOffset(Offset = "0x30")]
		public String_Layout DefaultProfileDescription;

		// Token: 0x04001A35 RID: 6709
		[Token(Token = "0x4001A35")]
		[FieldOffset(Offset = "0x34")]
		public TransactionButton_Layout DefaultProfileSelect;

		// Token: 0x04001A36 RID: 6710
		[Token(Token = "0x4001A36")]
		[FieldOffset(Offset = "0x38")]
		public Panel_Layout ProfileToolbarBacking;

		// Token: 0x04001A37 RID: 6711
		[Token(Token = "0x4001A37")]
		[FieldOffset(Offset = "0x3C")]
		public TransactionButton_Layout ProfileToolbarSimple;

		// Token: 0x04001A38 RID: 6712
		[Token(Token = "0x4001A38")]
		[FieldOffset(Offset = "0x40")]
		public TransactionButton_Layout ProfileToolbarAdvanced;

		// Token: 0x04001A39 RID: 6713
		[Token(Token = "0x4001A39")]
		[FieldOffset(Offset = "0x44")]
		public TransactionButton_Layout ProfileToolbarLegacy;

		// Token: 0x04001A3A RID: 6714
		[Token(Token = "0x4001A3A")]
		[FieldOffset(Offset = "0x48")]
		public TransactionButton_Layout ProfileToolbarCustom;

		// Token: 0x04001A3B RID: 6715
		[Token(Token = "0x4001A3B")]
		[FieldOffset(Offset = "0x4C")]
		public Panel_Layout MenuDivider1;

		// Token: 0x04001A3C RID: 6716
		[Token(Token = "0x4001A3C")]
		[FieldOffset(Offset = "0x50")]
		public Panel_Layout MenuDivider2;

		// Token: 0x04001A3D RID: 6717
		[Token(Token = "0x4001A3D")]
		[FieldOffset(Offset = "0x54")]
		public TransactionButton_Layout Back;

		// Token: 0x04001A3E RID: 6718
		[Token(Token = "0x4001A3E")]
		[FieldOffset(Offset = "0x58")]
		public String_Layout Tooltip;
	}

	// Token: 0x02000245 RID: 581
	[Token(Token = "0x2000245")]
	[Serializable]
	public class AdjustWidgets
	{
		// Token: 0x06000E3E RID: 3646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0xC931A8", Offset = "0xC931A8", VA = "0xC931A8")]
		public AdjustWidgets()
		{
		}

		// Token: 0x04001A3F RID: 6719
		[Token(Token = "0x4001A3F")]
		[FieldOffset(Offset = "0x8")]
		public Panel_Layout Backing;

		// Token: 0x04001A40 RID: 6720
		[Token(Token = "0x4001A40")]
		[FieldOffset(Offset = "0xC")]
		public TransactionButton_Layout Accept;

		// Token: 0x04001A41 RID: 6721
		[Token(Token = "0x4001A41")]
		[FieldOffset(Offset = "0x10")]
		public TransactionButton_Layout Default;

		// Token: 0x04001A42 RID: 6722
		[Token(Token = "0x4001A42")]
		[FieldOffset(Offset = "0x14")]
		public TransactionButton_Layout Cancel;

		// Token: 0x04001A43 RID: 6723
		[Token(Token = "0x4001A43")]
		[FieldOffset(Offset = "0x18")]
		public String_Layout Tooltip;

		// Token: 0x04001A44 RID: 6724
		[Token(Token = "0x4001A44")]
		[FieldOffset(Offset = "0x1C")]
		public Panel_Layout FeintAlignmentLine;

		// Token: 0x04001A45 RID: 6725
		[Token(Token = "0x4001A45")]
		[FieldOffset(Offset = "0x20")]
		public Panel_Layout AlignmentLine;
	}
}
