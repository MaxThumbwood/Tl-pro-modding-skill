using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria
{
	// Token: 0x020004B7 RID: 1207
	[Token(Token = "0x20004B7")]
	public class CombatText
	{
		// Token: 0x06002F45 RID: 12101 RVA: 0x00016D58 File Offset: 0x00014F58
		[Token(Token = "0x6002F45")]
		[Address(RVA = "0x188EDC8", Offset = "0x188EDC8", VA = "0x188EDC8")]
		public static int NewText(Rectangle location, Color color, int amount, bool dramatic = false, bool dot = false)
		{
			return 0;
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x00016D70 File Offset: 0x00014F70
		[Token(Token = "0x6002F46")]
		[Address(RVA = "0x188EE78", Offset = "0x188EE78", VA = "0x188EE78")]
		public static int NewText(Rectangle location, Color color, string text, bool dramatic = false, bool dot = false)
		{
			return 0;
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F47")]
		[Address(RVA = "0x188F7EC", Offset = "0x188F7EC", VA = "0x188F7EC")]
		public static void clearAll()
		{
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06002F48 RID: 12104 RVA: 0x00016D88 File Offset: 0x00014F88
		[Token(Token = "0x17000625")]
		public static float TargetScale
		{
			[Token(Token = "0x6002F48")]
			[Address(RVA = "0x188F88C", Offset = "0x188F88C", VA = "0x188F88C")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F49")]
		[Address(RVA = "0x188F898", Offset = "0x188F898", VA = "0x188F898")]
		public void Update()
		{
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F4A")]
		[Address(RVA = "0x188FB68", Offset = "0x188FB68", VA = "0x188FB68")]
		public static void UpdateCombatText()
		{
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F4B")]
		[Address(RVA = "0x188FC50", Offset = "0x188FC50", VA = "0x188FC50")]
		public CombatText()
		{
		}

		// Token: 0x04003F07 RID: 16135
		[Token(Token = "0x4003F07")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Color DamagedFriendly;

		// Token: 0x04003F08 RID: 16136
		[Token(Token = "0x4003F08")]
		[FieldOffset(Offset = "0x4")]
		public static readonly Color DamagedFriendlyCrit;

		// Token: 0x04003F09 RID: 16137
		[Token(Token = "0x4003F09")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Color DamagedHostile;

		// Token: 0x04003F0A RID: 16138
		[Token(Token = "0x4003F0A")]
		[FieldOffset(Offset = "0xC")]
		public static readonly Color DamagedHostileCrit;

		// Token: 0x04003F0B RID: 16139
		[Token(Token = "0x4003F0B")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Color OthersDamagedHostile;

		// Token: 0x04003F0C RID: 16140
		[Token(Token = "0x4003F0C")]
		[FieldOffset(Offset = "0x14")]
		public static readonly Color OthersDamagedHostileCrit;

		// Token: 0x04003F0D RID: 16141
		[Token(Token = "0x4003F0D")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Color HealLife;

		// Token: 0x04003F0E RID: 16142
		[Token(Token = "0x4003F0E")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly Color HealMana;

		// Token: 0x04003F0F RID: 16143
		[Token(Token = "0x4003F0F")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Color LifeRegen;

		// Token: 0x04003F10 RID: 16144
		[Token(Token = "0x4003F10")]
		[FieldOffset(Offset = "0x24")]
		public static readonly Color LifeRegenNegative;

		// Token: 0x04003F11 RID: 16145
		[Token(Token = "0x4003F11")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 position;

		// Token: 0x04003F12 RID: 16146
		[Token(Token = "0x4003F12")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 velocity;

		// Token: 0x04003F13 RID: 16147
		[Token(Token = "0x4003F13")]
		[FieldOffset(Offset = "0x18")]
		public float alpha;

		// Token: 0x04003F14 RID: 16148
		[Token(Token = "0x4003F14")]
		[FieldOffset(Offset = "0x1C")]
		public int alphaDir;

		// Token: 0x04003F15 RID: 16149
		[Token(Token = "0x4003F15")]
		[FieldOffset(Offset = "0x20")]
		public string text;

		// Token: 0x04003F16 RID: 16150
		[Token(Token = "0x4003F16")]
		[FieldOffset(Offset = "0x24")]
		public float scale;

		// Token: 0x04003F17 RID: 16151
		[Token(Token = "0x4003F17")]
		[FieldOffset(Offset = "0x28")]
		public float rotation;

		// Token: 0x04003F18 RID: 16152
		[Token(Token = "0x4003F18")]
		[FieldOffset(Offset = "0x2C")]
		public Color color;

		// Token: 0x04003F19 RID: 16153
		[Token(Token = "0x4003F19")]
		[FieldOffset(Offset = "0x30")]
		public bool active;

		// Token: 0x04003F1A RID: 16154
		[Token(Token = "0x4003F1A")]
		[FieldOffset(Offset = "0x34")]
		public int lifeTime;

		// Token: 0x04003F1B RID: 16155
		[Token(Token = "0x4003F1B")]
		[FieldOffset(Offset = "0x38")]
		public bool crit;

		// Token: 0x04003F1C RID: 16156
		[Token(Token = "0x4003F1C")]
		[FieldOffset(Offset = "0x39")]
		public bool dot;
	}
}
