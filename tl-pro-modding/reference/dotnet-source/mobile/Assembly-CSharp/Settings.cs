using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

// Token: 0x020002E6 RID: 742
[Token(Token = "0x20002E6")]
public class Settings : LayoutDefinition
{
	// Token: 0x06001271 RID: 4721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001271")]
	[Address(RVA = "0xD8F3F0", Offset = "0xD8F3F0", VA = "0xD8F3F0")]
	private void Awake()
	{
	}

	// Token: 0x06001272 RID: 4722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001272")]
	[Address(RVA = "0xD8F450", Offset = "0xD8F450", VA = "0xD8F450")]
	public Settings()
	{
	}

	// Token: 0x040023D0 RID: 9168
	[Token(Token = "0x40023D0")]
	[FieldOffset(Offset = "0x0")]
	public static Settings Instance;

	// Token: 0x040023D1 RID: 9169
	[Token(Token = "0x40023D1")]
	[FieldOffset(Offset = "0xC")]
	public SettingsTooltips Tooltips;

	// Token: 0x040023D2 RID: 9170
	[Token(Token = "0x40023D2")]
	[FieldOffset(Offset = "0x10")]
	public Microsoft.Xna.Framework.Graphics.Color DuplicationTooltipBacking;

	// Token: 0x040023D3 RID: 9171
	[Token(Token = "0x40023D3")]
	[FieldOffset(Offset = "0x14")]
	public Microsoft.Xna.Framework.Graphics.Color VoidItemTooltipBacking;

	// Token: 0x040023D4 RID: 9172
	[Token(Token = "0x40023D4")]
	[FieldOffset(Offset = "0x18")]
	public Microsoft.Xna.Framework.Graphics.Color BannerTooltipBacking;

	// Token: 0x040023D5 RID: 9173
	[Token(Token = "0x40023D5")]
	[FieldOffset(Offset = "0x1C")]
	public Microsoft.Xna.Framework.Graphics.Color ChestTooltipBacking;

	// Token: 0x040023D6 RID: 9174
	[Token(Token = "0x40023D6")]
	[FieldOffset(Offset = "0x20")]
	public Microsoft.Xna.Framework.Graphics.Color BankTooltipBacking;

	// Token: 0x040023D7 RID: 9175
	[Token(Token = "0x40023D7")]
	[FieldOffset(Offset = "0x24")]
	public Microsoft.Xna.Framework.Graphics.Color PrefixTooltipBacking;

	// Token: 0x040023D8 RID: 9176
	[Token(Token = "0x40023D8")]
	[FieldOffset(Offset = "0x28")]
	public Microsoft.Xna.Framework.Graphics.Color Equip0TooltipBacking;

	// Token: 0x040023D9 RID: 9177
	[Token(Token = "0x40023D9")]
	[FieldOffset(Offset = "0x2C")]
	public Microsoft.Xna.Framework.Graphics.Color Equip1TooltipBacking;

	// Token: 0x040023DA RID: 9178
	[Token(Token = "0x40023DA")]
	[FieldOffset(Offset = "0x30")]
	public Microsoft.Xna.Framework.Graphics.Color Equip2TooltipBacking;

	// Token: 0x040023DB RID: 9179
	[Token(Token = "0x40023DB")]
	[FieldOffset(Offset = "0x34")]
	public Microsoft.Xna.Framework.Graphics.Color ShopTooltipBacking;

	// Token: 0x040023DC RID: 9180
	[Token(Token = "0x40023DC")]
	[FieldOffset(Offset = "0x38")]
	public Microsoft.Xna.Framework.Graphics.Color ResearchTooltipBacking;

	// Token: 0x040023DD RID: 9181
	[Token(Token = "0x40023DD")]
	[FieldOffset(Offset = "0x3C")]
	public Microsoft.Xna.Framework.Graphics.Color CraftingStationTooltipBacking;

	// Token: 0x040023DE RID: 9182
	[Token(Token = "0x40023DE")]
	[FieldOffset(Offset = "0x40")]
	public int BannerTooltipItemWidth;

	// Token: 0x040023DF RID: 9183
	[Token(Token = "0x40023DF")]
	[FieldOffset(Offset = "0x44")]
	public float DeselectedPageFade;

	// Token: 0x040023E0 RID: 9184
	[Token(Token = "0x40023E0")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve SliderSpeed;

	// Token: 0x040023E1 RID: 9185
	[Token(Token = "0x40023E1")]
	[FieldOffset(Offset = "0x4C")]
	public AnimationCurve AimCursorSpeed;

	// Token: 0x040023E2 RID: 9186
	[Token(Token = "0x40023E2")]
	[FieldOffset(Offset = "0x50")]
	public float MouseScrollSensitivity;

	// Token: 0x040023E3 RID: 9187
	[Token(Token = "0x40023E3")]
	[FieldOffset(Offset = "0x54")]
	public float GridScrollSpeed;

	// Token: 0x040023E4 RID: 9188
	[Token(Token = "0x40023E4")]
	[FieldOffset(Offset = "0x58")]
	public float ItemSlotHighlightIconScaleMin;

	// Token: 0x040023E5 RID: 9189
	[Token(Token = "0x40023E5")]
	[FieldOffset(Offset = "0x5C")]
	public float ItemSlotHighlightIconScaleMax;
}
