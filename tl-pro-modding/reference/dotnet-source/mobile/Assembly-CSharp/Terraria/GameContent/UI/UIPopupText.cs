using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000D38 RID: 3384
	[Token(Token = "0x2000D38")]
	public class UIPopupText
	{
		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x0600645B RID: 25691 RVA: 0x0002DF18 File Offset: 0x0002C118
		[Token(Token = "0x17000AC6")]
		public float TargetScale
		{
			[Token(Token = "0x600645B")]
			[Address(RVA = "0xB26BB8", Offset = "0xB26BB8", VA = "0xB26BB8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600645C RID: 25692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600645C")]
		[Address(RVA = "0xB25C1C", Offset = "0xB25C1C", VA = "0xB25C1C")]
		public void PrepareDisplayText()
		{
		}

		// Token: 0x0600645D RID: 25693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600645D")]
		[Address(RVA = "0xB25CB8", Offset = "0xB25CB8", VA = "0xB25CB8")]
		public void Update(int whoAmI, UIPopupTextManager manager)
		{
		}

		// Token: 0x0600645E RID: 25694 RVA: 0x0002DF30 File Offset: 0x0002C130
		[Token(Token = "0x600645E")]
		[Address(RVA = "0xB26BC0", Offset = "0xB26BC0", VA = "0xB26BC0")]
		public Vector2 GetTextHitbox()
		{
			return default(Vector2);
		}

		// Token: 0x0600645F RID: 25695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600645F")]
		[Address(RVA = "0xB26294", Offset = "0xB26294", VA = "0xB26294")]
		public UIPopupText()
		{
		}

		// Token: 0x0400A1DE RID: 41438
		[Token(Token = "0x400A1DE")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 position;

		// Token: 0x0400A1DF RID: 41439
		[Token(Token = "0x400A1DF")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 velocity;

		// Token: 0x0400A1E0 RID: 41440
		[Token(Token = "0x400A1E0")]
		[FieldOffset(Offset = "0x18")]
		public float alpha;

		// Token: 0x0400A1E1 RID: 41441
		[Token(Token = "0x400A1E1")]
		[FieldOffset(Offset = "0x1C")]
		public int alphaDir;

		// Token: 0x0400A1E2 RID: 41442
		[Token(Token = "0x400A1E2")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x0400A1E3 RID: 41443
		[Token(Token = "0x400A1E3")]
		[FieldOffset(Offset = "0x24")]
		public string displayText;

		// Token: 0x0400A1E4 RID: 41444
		[Token(Token = "0x400A1E4")]
		[FieldOffset(Offset = "0x28")]
		public float scale;

		// Token: 0x0400A1E5 RID: 41445
		[Token(Token = "0x400A1E5")]
		[FieldOffset(Offset = "0x2C")]
		public float rotation;

		// Token: 0x0400A1E6 RID: 41446
		[Token(Token = "0x400A1E6")]
		[FieldOffset(Offset = "0x30")]
		public Color color;

		// Token: 0x0400A1E7 RID: 41447
		[Token(Token = "0x400A1E7")]
		[FieldOffset(Offset = "0x34")]
		public bool active;

		// Token: 0x0400A1E8 RID: 41448
		[Token(Token = "0x400A1E8")]
		[FieldOffset(Offset = "0x38")]
		public int lifeTime;

		// Token: 0x0400A1E9 RID: 41449
		[Token(Token = "0x400A1E9")]
		[FieldOffset(Offset = "0x3C")]
		public int framesSinceSpawn;

		// Token: 0x0400A1EA RID: 41450
		[Token(Token = "0x400A1EA")]
		[FieldOffset(Offset = "0x0")]
		public static int activeTime;

		// Token: 0x0400A1EB RID: 41451
		[Token(Token = "0x400A1EB")]
		[FieldOffset(Offset = "0x40")]
		public UIPopupTextContext context;
	}
}
