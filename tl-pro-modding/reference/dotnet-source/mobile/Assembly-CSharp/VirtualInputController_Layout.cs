using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000279 RID: 633
[Token(Token = "0x2000279")]
public class VirtualInputController_Layout : LayoutDefinition
{
	// Token: 0x06000ED1 RID: 3793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED1")]
	[Address(RVA = "0xC9E548", Offset = "0xC9E548", VA = "0xC9E548")]
	private void Awake()
	{
	}

	// Token: 0x06000ED2 RID: 3794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED2")]
	[Address(RVA = "0xC9E59C", Offset = "0xC9E59C", VA = "0xC9E59C")]
	public VirtualInputController_Layout()
	{
	}

	// Token: 0x04001E66 RID: 7782
	[Token(Token = "0x4001E66")]
	[FieldOffset(Offset = "0x0")]
	public static VirtualInputController_Layout Instance;

	// Token: 0x04001E67 RID: 7783
	[Token(Token = "0x4001E67")]
	[FieldOffset(Offset = "0xC")]
	public int ControlsFrameFadeTime;

	// Token: 0x04001E68 RID: 7784
	[Token(Token = "0x4001E68")]
	[FieldOffset(Offset = "0x10")]
	public QuickActionButton_Layout Jump;

	// Token: 0x04001E69 RID: 7785
	[Token(Token = "0x4001E69")]
	[FieldOffset(Offset = "0x14")]
	public QuickActionButton_Layout Jump2;

	// Token: 0x04001E6A RID: 7786
	[Token(Token = "0x4001E6A")]
	[FieldOffset(Offset = "0x18")]
	public Axis_Layout Movement;

	// Token: 0x04001E6B RID: 7787
	[Token(Token = "0x4001E6B")]
	[FieldOffset(Offset = "0x1C")]
	public QuickActionButton_Layout Heal;

	// Token: 0x04001E6C RID: 7788
	[Token(Token = "0x4001E6C")]
	[FieldOffset(Offset = "0x20")]
	public QuickActionButton_Layout Mana;

	// Token: 0x04001E6D RID: 7789
	[Token(Token = "0x4001E6D")]
	[FieldOffset(Offset = "0x24")]
	public QuickActionButton_Layout Buff;

	// Token: 0x04001E6E RID: 7790
	[Token(Token = "0x4001E6E")]
	[FieldOffset(Offset = "0x28")]
	public QuickActionButton_Layout Mount;

	// Token: 0x04001E6F RID: 7791
	[Token(Token = "0x4001E6F")]
	[FieldOffset(Offset = "0x2C")]
	public QuickActionButton_Layout SmartCursor;

	// Token: 0x04001E70 RID: 7792
	[Token(Token = "0x4001E70")]
	[FieldOffset(Offset = "0x30")]
	public QuickActionButton_Layout AutoFire;

	// Token: 0x04001E71 RID: 7793
	[Token(Token = "0x4001E71")]
	[FieldOffset(Offset = "0x34")]
	public QuickActionButton_Layout ZoomIn;

	// Token: 0x04001E72 RID: 7794
	[Token(Token = "0x4001E72")]
	[FieldOffset(Offset = "0x38")]
	public QuickActionButton_Layout ZoomOut;

	// Token: 0x04001E73 RID: 7795
	[Token(Token = "0x4001E73")]
	[FieldOffset(Offset = "0x3C")]
	public Panel_Layout ZoomBacking;

	// Token: 0x04001E74 RID: 7796
	[Token(Token = "0x4001E74")]
	[FieldOffset(Offset = "0x40")]
	public QuickActionButton_Layout Interact;

	// Token: 0x04001E75 RID: 7797
	[Token(Token = "0x4001E75")]
	[FieldOffset(Offset = "0x44")]
	public QuickActionButton_Layout Fire;

	// Token: 0x04001E76 RID: 7798
	[Token(Token = "0x4001E76")]
	[FieldOffset(Offset = "0x48")]
	public QuickActionButton_Layout Fire2;

	// Token: 0x04001E77 RID: 7799
	[Token(Token = "0x4001E77")]
	[FieldOffset(Offset = "0x4C")]
	public QuickActionButton_Layout Inventory;

	// Token: 0x04001E78 RID: 7800
	[Token(Token = "0x4001E78")]
	[FieldOffset(Offset = "0x50")]
	public QuickActionButton_Layout AutoSelect;

	// Token: 0x04001E79 RID: 7801
	[Token(Token = "0x4001E79")]
	[FieldOffset(Offset = "0x54")]
	public QuickActionButton_Layout GrappleSelect;

	// Token: 0x04001E7A RID: 7802
	[Token(Token = "0x4001E7A")]
	[FieldOffset(Offset = "0x58")]
	public QuickActionButton_Layout TargetLockOn;

	// Token: 0x04001E7B RID: 7803
	[Token(Token = "0x4001E7B")]
	[FieldOffset(Offset = "0x5C")]
	public FadeString_Layout ZoomValue;

	// Token: 0x04001E7C RID: 7804
	[Token(Token = "0x4001E7C")]
	[FieldOffset(Offset = "0x60")]
	public Axis_Layout FireAxis;

	// Token: 0x04001E7D RID: 7805
	[Token(Token = "0x4001E7D")]
	[FieldOffset(Offset = "0x64")]
	public Axis_Layout GrappleAxis;

	// Token: 0x04001E7E RID: 7806
	[Token(Token = "0x4001E7E")]
	[FieldOffset(Offset = "0x68")]
	public FadeString_Layout NotifySmartCursor;

	// Token: 0x04001E7F RID: 7807
	[Token(Token = "0x4001E7F")]
	[FieldOffset(Offset = "0x6C")]
	public FadeString_Layout NotifyAutoFire;

	// Token: 0x04001E80 RID: 7808
	[Token(Token = "0x4001E80")]
	[FieldOffset(Offset = "0x70")]
	public FadeString_Layout NotifyCombatTargeting;

	// Token: 0x04001E81 RID: 7809
	[Token(Token = "0x4001E81")]
	[FieldOffset(Offset = "0x74")]
	public FadeString_Layout NotifyProfile;

	// Token: 0x04001E82 RID: 7810
	[Token(Token = "0x4001E82")]
	[FieldOffset(Offset = "0x78")]
	public FadeString_Layout NotifySmartCursorController;

	// Token: 0x04001E83 RID: 7811
	[Token(Token = "0x4001E83")]
	[FieldOffset(Offset = "0x7C")]
	public FadeString_Layout NotifyAutoFireController;

	// Token: 0x04001E84 RID: 7812
	[Token(Token = "0x4001E84")]
	[FieldOffset(Offset = "0x80")]
	public FadeString_Layout NotifyCombatTargetingController;

	// Token: 0x04001E85 RID: 7813
	[Token(Token = "0x4001E85")]
	[FieldOffset(Offset = "0x84")]
	public FadeString_Layout NotifyProfileController;

	// Token: 0x04001E86 RID: 7814
	[Token(Token = "0x4001E86")]
	[FieldOffset(Offset = "0x88")]
	public String_Layout ProfileSwitchString;

	// Token: 0x04001E87 RID: 7815
	[Token(Token = "0x4001E87")]
	[FieldOffset(Offset = "0x8C")]
	public String_Layout AltFireString;

	// Token: 0x04001E88 RID: 7816
	[Token(Token = "0x4001E88")]
	[FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout MinionTargetting;

	// Token: 0x04001E89 RID: 7817
	[Token(Token = "0x4001E89")]
	[FieldOffset(Offset = "0x94")]
	public TransactionButton_Layout ShieldRight;

	// Token: 0x04001E8A RID: 7818
	[Token(Token = "0x4001E8A")]
	[FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout ItemSwap;

	// Token: 0x04001E8B RID: 7819
	[Token(Token = "0x4001E8B")]
	[FieldOffset(Offset = "0x9C")]
	public TransactionButton_Layout ToolConfig;

	// Token: 0x04001E8C RID: 7820
	[Token(Token = "0x4001E8C")]
	[FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout WireConfig;

	// Token: 0x04001E8D RID: 7821
	[Token(Token = "0x4001E8D")]
	[FieldOffset(Offset = "0xA4")]
	public TransactionButton_Layout ScopeAim;

	// Token: 0x04001E8E RID: 7822
	[Token(Token = "0x4001E8E")]
	[FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout DrillUseLeft;

	// Token: 0x04001E8F RID: 7823
	[Token(Token = "0x4001E8F")]
	[FieldOffset(Offset = "0xAC")]
	public TransactionButton_Layout DrillUseRight;

	// Token: 0x04001E90 RID: 7824
	[Token(Token = "0x4001E90")]
	[FieldOffset(Offset = "0xB0")]
	public TransactionButton_Layout PortalUseLeft;

	// Token: 0x04001E91 RID: 7825
	[Token(Token = "0x4001E91")]
	[FieldOffset(Offset = "0xB4")]
	public TransactionButton_Layout PortalUseRight;

	// Token: 0x04001E92 RID: 7826
	[Token(Token = "0x4001E92")]
	[FieldOffset(Offset = "0xB8")]
	public TransactionButton_Layout BookStaffUseLeft;

	// Token: 0x04001E93 RID: 7827
	[Token(Token = "0x4001E93")]
	[FieldOffset(Offset = "0xBC")]
	public TransactionButton_Layout BookStaffUseRight;

	// Token: 0x04001E94 RID: 7828
	[Token(Token = "0x4001E94")]
	[FieldOffset(Offset = "0xC0")]
	public TransactionButton_Layout MonkStaffT3UseLeft;

	// Token: 0x04001E95 RID: 7829
	[Token(Token = "0x4001E95")]
	[FieldOffset(Offset = "0xC4")]
	public TransactionButton_Layout MonkStaffT3UseRight;

	// Token: 0x04001E96 RID: 7830
	[Token(Token = "0x4001E96")]
	[FieldOffset(Offset = "0xC8")]
	public TransactionButton_Layout KiteUseLeft;

	// Token: 0x04001E97 RID: 7831
	[Token(Token = "0x4001E97")]
	[FieldOffset(Offset = "0xCC")]
	public TransactionButton_Layout KiteUseRight;

	// Token: 0x04001E98 RID: 7832
	[Token(Token = "0x4001E98")]
	[FieldOffset(Offset = "0xD0")]
	public TransactionButton_Layout CritterUseLeft;

	// Token: 0x04001E99 RID: 7833
	[Token(Token = "0x4001E99")]
	[FieldOffset(Offset = "0xD4")]
	public TransactionButton_Layout CritterUseRight;

	// Token: 0x04001E9A RID: 7834
	[Token(Token = "0x4001E9A")]
	[FieldOffset(Offset = "0xD8")]
	public TransactionButton_Layout DigtoiseRecall;

	// Token: 0x04001E9B RID: 7835
	[Token(Token = "0x4001E9B")]
	[FieldOffset(Offset = "0xDC")]
	public TransactionButton_Layout DigtoiseDig;

	// Token: 0x04001E9C RID: 7836
	[Token(Token = "0x4001E9C")]
	[FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout DigtoiseSummon;

	// Token: 0x04001E9D RID: 7837
	[Token(Token = "0x4001E9D")]
	[FieldOffset(Offset = "0xE4")]
	public TransactionButton_Layout DigtoiseDigStop;

	// Token: 0x0200027A RID: 634
	[Token(Token = "0x200027A")]
	public enum ContolType
	{
		// Token: 0x04001E9F RID: 7839
		[Token(Token = "0x4001E9F")]
		AutoFire,
		// Token: 0x04001EA0 RID: 7840
		[Token(Token = "0x4001EA0")]
		SmartCursor,
		// Token: 0x04001EA1 RID: 7841
		[Token(Token = "0x4001EA1")]
		CombatTargetting,
		// Token: 0x04001EA2 RID: 7842
		[Token(Token = "0x4001EA2")]
		Jump,
		// Token: 0x04001EA3 RID: 7843
		[Token(Token = "0x4001EA3")]
		Heal,
		// Token: 0x04001EA4 RID: 7844
		[Token(Token = "0x4001EA4")]
		Mana,
		// Token: 0x04001EA5 RID: 7845
		[Token(Token = "0x4001EA5")]
		Buff,
		// Token: 0x04001EA6 RID: 7846
		[Token(Token = "0x4001EA6")]
		Mount,
		// Token: 0x04001EA7 RID: 7847
		[Token(Token = "0x4001EA7")]
		Interact,
		// Token: 0x04001EA8 RID: 7848
		[Token(Token = "0x4001EA8")]
		Fire,
		// Token: 0x04001EA9 RID: 7849
		[Token(Token = "0x4001EA9")]
		GrappleAxis,
		// Token: 0x04001EAA RID: 7850
		[Token(Token = "0x4001EAA")]
		Count
	}

	// Token: 0x0200027B RID: 635
	[Token(Token = "0x200027B")]
	[Serializable]
	public class SlotEntry
	{
		// Token: 0x06000ED3 RID: 3795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0xC9E60C", Offset = "0xC9E60C", VA = "0xC9E60C")]
		public SlotEntry()
		{
		}

		// Token: 0x04001EAB RID: 7851
		[Token(Token = "0x4001EAB")]
		[FieldOffset(Offset = "0x8")]
		public VirtualInputController_Layout.ContolType DefaultControl;

		// Token: 0x04001EAC RID: 7852
		[Token(Token = "0x4001EAC")]
		[FieldOffset(Offset = "0xC")]
		public ControlAnchor.ControlId AnchorControl;

		// Token: 0x04001EAD RID: 7853
		[Token(Token = "0x4001EAD")]
		[FieldOffset(Offset = "0x10")]
		public LayoutCalculator.AnchorType Anchor;

		// Token: 0x04001EAE RID: 7854
		[Token(Token = "0x4001EAE")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 Location;

		// Token: 0x04001EAF RID: 7855
		[Token(Token = "0x4001EAF")]
		[FieldOffset(Offset = "0x1C")]
		public float Scale;
	}
}
