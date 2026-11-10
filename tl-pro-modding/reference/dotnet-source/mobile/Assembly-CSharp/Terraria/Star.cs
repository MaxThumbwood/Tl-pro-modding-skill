using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria
{
	// Token: 0x020004FF RID: 1279
	[Token(Token = "0x20004FF")]
	public class Star
	{
		// Token: 0x060032A2 RID: 12962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A2")]
		[Address(RVA = "0x1A0B248", Offset = "0x1A0B248", VA = "0x1A0B248")]
		public static void NightSetup()
		{
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A3")]
		[Address(RVA = "0x1A0B434", Offset = "0x1A0B434", VA = "0x1A0B434")]
		public static void StarFall(float positionX)
		{
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A4")]
		[Address(RVA = "0x1A0B828", Offset = "0x1A0B828", VA = "0x1A0B828")]
		public static void SpawnStars(int s = -1)
		{
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A5")]
		[Address(RVA = "0x1A0B6C8", Offset = "0x1A0B6C8", VA = "0x1A0B6C8")]
		public void Fall()
		{
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A6")]
		[Address(RVA = "0x1A0C188", Offset = "0x1A0C188", VA = "0x1A0C188")]
		public void Update()
		{
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A7")]
		[Address(RVA = "0x1A0C4E0", Offset = "0x1A0C4E0", VA = "0x1A0C4E0")]
		public static void UpdateStars()
		{
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032A8")]
		[Address(RVA = "0x1A0C17C", Offset = "0x1A0C17C", VA = "0x1A0C17C")]
		public Star()
		{
		}

		// Token: 0x040042EC RID: 17132
		[Token(Token = "0x40042EC")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 position;

		// Token: 0x040042ED RID: 17133
		[Token(Token = "0x40042ED")]
		[FieldOffset(Offset = "0x10")]
		public float scale;

		// Token: 0x040042EE RID: 17134
		[Token(Token = "0x40042EE")]
		[FieldOffset(Offset = "0x14")]
		public float rotation;

		// Token: 0x040042EF RID: 17135
		[Token(Token = "0x40042EF")]
		[FieldOffset(Offset = "0x18")]
		public int type;

		// Token: 0x040042F0 RID: 17136
		[Token(Token = "0x40042F0")]
		[FieldOffset(Offset = "0x1C")]
		public float twinkle;

		// Token: 0x040042F1 RID: 17137
		[Token(Token = "0x40042F1")]
		[FieldOffset(Offset = "0x20")]
		public float twinkleSpeed;

		// Token: 0x040042F2 RID: 17138
		[Token(Token = "0x40042F2")]
		[FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		// Token: 0x040042F3 RID: 17139
		[Token(Token = "0x40042F3")]
		[FieldOffset(Offset = "0x28")]
		public bool falling;

		// Token: 0x040042F4 RID: 17140
		[Token(Token = "0x40042F4")]
		[FieldOffset(Offset = "0x29")]
		public bool hidden;

		// Token: 0x040042F5 RID: 17141
		[Token(Token = "0x40042F5")]
		[FieldOffset(Offset = "0x2C")]
		public Vector2 fallSpeed;

		// Token: 0x040042F6 RID: 17142
		[Token(Token = "0x40042F6")]
		[FieldOffset(Offset = "0x34")]
		public int fallTime;

		// Token: 0x040042F7 RID: 17143
		[Token(Token = "0x40042F7")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 velocity;

		// Token: 0x040042F8 RID: 17144
		[Token(Token = "0x40042F8")]
		[FieldOffset(Offset = "0x0")]
		public static bool dayCheck;

		// Token: 0x040042F9 RID: 17145
		[Token(Token = "0x40042F9")]
		[FieldOffset(Offset = "0x4")]
		public static float starfallBoost;

		// Token: 0x040042FA RID: 17146
		[Token(Token = "0x40042FA")]
		[FieldOffset(Offset = "0x8")]
		public static int starFallCount;

		// Token: 0x040042FB RID: 17147
		[Token(Token = "0x40042FB")]
		[FieldOffset(Offset = "0x40")]
		public float fadeIn;
	}
}
