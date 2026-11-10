using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020001A4 RID: 420
[Token(Token = "0x20001A4")]
public class Achievements_Layout : LayoutDefinition
{
	// Token: 0x06000C6F RID: 3183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6F")]
	[Address(RVA = "0xC662A8", Offset = "0xC662A8", VA = "0xC662A8")]
	private void Awake()
	{
	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C70")]
	[Address(RVA = "0xC662FC", Offset = "0xC662FC", VA = "0xC662FC")]
	public Achievements_Layout()
	{
	}

	// Token: 0x04000F80 RID: 3968
	[Token(Token = "0x4000F80")]
	[FieldOffset(Offset = "0x0")]
	public static Achievements_Layout Instance;

	// Token: 0x04000F81 RID: 3969
	[Token(Token = "0x4000F81")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Backing;

	// Token: 0x04000F82 RID: 3970
	[Token(Token = "0x4000F82")]
	[FieldOffset(Offset = "0x10")]
	public DraggableItemGrid_Layout AchievementsGrid;

	// Token: 0x04000F83 RID: 3971
	[Token(Token = "0x4000F83")]
	[FieldOffset(Offset = "0x14")]
	public StringButton_Layout Title;

	// Token: 0x04000F84 RID: 3972
	[Token(Token = "0x4000F84")]
	[FieldOffset(Offset = "0x18")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000F85 RID: 3973
	[Token(Token = "0x4000F85")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout MenuDivider2;

	// Token: 0x04000F86 RID: 3974
	[Token(Token = "0x4000F86")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Back;

	// Token: 0x04000F87 RID: 3975
	[Token(Token = "0x4000F87")]
	[FieldOffset(Offset = "0x24")]
	public Panel_Layout ItemBacking;

	// Token: 0x04000F88 RID: 3976
	[Token(Token = "0x4000F88")]
	[FieldOffset(Offset = "0x28")]
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x04000F89 RID: 3977
	[Token(Token = "0x4000F89")]
	[FieldOffset(Offset = "0x2C")]
	public Button_Layout ItemDivider;

	// Token: 0x04000F8A RID: 3978
	[Token(Token = "0x4000F8A")]
	[FieldOffset(Offset = "0x30")]
	public String_Layout ItemName;

	// Token: 0x04000F8B RID: 3979
	[Token(Token = "0x4000F8B")]
	[FieldOffset(Offset = "0x34")]
	public String_Layout ItemNameCompleted;

	// Token: 0x04000F8C RID: 3980
	[Token(Token = "0x4000F8C")]
	[FieldOffset(Offset = "0x38")]
	public Panel_Layout ItemNameDivider;

	// Token: 0x04000F8D RID: 3981
	[Token(Token = "0x4000F8D")]
	[FieldOffset(Offset = "0x3C")]
	public String_Layout ItemDescription;

	// Token: 0x04000F8E RID: 3982
	[Token(Token = "0x4000F8E")]
	[FieldOffset(Offset = "0x40")]
	public int ItemDescWidth;

	// Token: 0x04000F8F RID: 3983
	[Token(Token = "0x4000F8F")]
	[FieldOffset(Offset = "0x44")]
	public AchievementIcon ItemIcon;

	// Token: 0x04000F90 RID: 3984
	[Token(Token = "0x4000F90")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 ItemCatIconsPosition;

	// Token: 0x04000F91 RID: 3985
	[Token(Token = "0x4000F91")]
	[FieldOffset(Offset = "0x50")]
	public float ItemCatIconsScale;

	// Token: 0x04000F92 RID: 3986
	[Token(Token = "0x4000F92")]
	[FieldOffset(Offset = "0x54")]
	public String_Layout ProgressNumbers;

	// Token: 0x04000F93 RID: 3987
	[Token(Token = "0x4000F93")]
	[FieldOffset(Offset = "0x58")]
	public ProgressBar_Layout ProgressBar;

	// Token: 0x04000F94 RID: 3988
	[Token(Token = "0x4000F94")]
	[FieldOffset(Offset = "0x5C")]
	public Panel_Layout ItemInnerPanelTop;

	// Token: 0x04000F95 RID: 3989
	[Token(Token = "0x4000F95")]
	[FieldOffset(Offset = "0x60")]
	public Panel_Layout ItemSelectedInnerPanelTop;

	// Token: 0x04000F96 RID: 3990
	[Token(Token = "0x4000F96")]
	[FieldOffset(Offset = "0x64")]
	public Panel_Layout ItemInnerPanelBottom;

	// Token: 0x04000F97 RID: 3991
	[Token(Token = "0x4000F97")]
	[FieldOffset(Offset = "0x68")]
	public Panel_Layout ItemSelectedInnerPanelBottom;

	// Token: 0x04000F98 RID: 3992
	[Token(Token = "0x4000F98")]
	[FieldOffset(Offset = "0x6C")]
	public Panel_Layout CategoryDivider;

	// Token: 0x04000F99 RID: 3993
	[Token(Token = "0x4000F99")]
	[FieldOffset(Offset = "0x70")]
	public Vector2 InGameWindowShift;

	// Token: 0x04000F9A RID: 3994
	[Token(Token = "0x4000F9A")]
	[FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Filters;

	// Token: 0x04000F9B RID: 3995
	[Token(Token = "0x4000F9B")]
	[FieldOffset(Offset = "0x7C")]
	public Panel_Layout FiltersBacking;

	// Token: 0x04000F9C RID: 3996
	[Token(Token = "0x4000F9C")]
	[FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Slayer;

	// Token: 0x04000F9D RID: 3997
	[Token(Token = "0x4000F9D")]
	[FieldOffset(Offset = "0x84")]
	public TransactionButton_Layout Collector;

	// Token: 0x04000F9E RID: 3998
	[Token(Token = "0x4000F9E")]
	[FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout Explorer;

	// Token: 0x04000F9F RID: 3999
	[Token(Token = "0x4000F9F")]
	[FieldOffset(Offset = "0x8C")]
	public TransactionButton_Layout Challenger;
}
