using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x020004B2 RID: 1202
	[Token(Token = "0x20004B2")]
	public class Cloud
	{
		// Token: 0x06002EEA RID: 12010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EEA")]
		[Address(RVA = "0x188BA0C", Offset = "0x188BA0C", VA = "0x188BA0C")]
		public static void resetClouds()
		{
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EEB")]
		[Address(RVA = "0x188BC00", Offset = "0x188BC00", VA = "0x188BC00")]
		public static void addCloud()
		{
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x00016788 File Offset: 0x00014988
		[Token(Token = "0x6002EEC")]
		[Address(RVA = "0x188D69C", Offset = "0x188D69C", VA = "0x188D69C")]
		private static int RollRareCloud()
		{
			return 0;
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x000167A0 File Offset: 0x000149A0
		[Token(Token = "0x6002EED")]
		[Address(RVA = "0x188DA3C", Offset = "0x188DA3C", VA = "0x188DA3C")]
		public Color cloudColor(Color bgColor)
		{
			return default(Color);
		}

		// Token: 0x06002EEE RID: 12014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EEE")]
		[Address(RVA = "0x188DB9C", Offset = "0x188DB9C", VA = "0x188DB9C")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06002EEF RID: 12015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EEF")]
		[Address(RVA = "0x188DBA8", Offset = "0x188DBA8", VA = "0x188DBA8")]
		public static void UpdateClouds()
		{
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EF0")]
		[Address(RVA = "0x188E9B0", Offset = "0x188E9B0", VA = "0x188E9B0")]
		public static void UpdateCloudParallax()
		{
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x000167B8 File Offset: 0x000149B8
		[Token(Token = "0x6002EF1")]
		[Address(RVA = "0x188EC78", Offset = "0x188EC78", VA = "0x188EC78")]
		private float GetParallax()
		{
			return 0f;
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EF2")]
		[Address(RVA = "0x188E2C0", Offset = "0x188E2C0", VA = "0x188E2C0")]
		public void Update()
		{
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EF3")]
		[Address(RVA = "0x188ED10", Offset = "0x188ED10", VA = "0x188ED10")]
		public Cloud()
		{
		}

		// Token: 0x04003EDA RID: 16090
		[Token(Token = "0x4003EDA")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 position;

		// Token: 0x04003EDB RID: 16091
		[Token(Token = "0x4003EDB")]
		[FieldOffset(Offset = "0x10")]
		public float scale;

		// Token: 0x04003EDC RID: 16092
		[Token(Token = "0x4003EDC")]
		[FieldOffset(Offset = "0x14")]
		public float rotation;

		// Token: 0x04003EDD RID: 16093
		[Token(Token = "0x4003EDD")]
		[FieldOffset(Offset = "0x18")]
		public float rSpeed;

		// Token: 0x04003EDE RID: 16094
		[Token(Token = "0x4003EDE")]
		[FieldOffset(Offset = "0x1C")]
		public float sSpeed;

		// Token: 0x04003EDF RID: 16095
		[Token(Token = "0x4003EDF")]
		[FieldOffset(Offset = "0x20")]
		public bool active;

		// Token: 0x04003EE0 RID: 16096
		[Token(Token = "0x4003EE0")]
		[FieldOffset(Offset = "0x24")]
		public SpriteEffects spriteDir;

		// Token: 0x04003EE1 RID: 16097
		[Token(Token = "0x4003EE1")]
		[FieldOffset(Offset = "0x28")]
		public int type;

		// Token: 0x04003EE2 RID: 16098
		[Token(Token = "0x4003EE2")]
		[FieldOffset(Offset = "0x2C")]
		public int width;

		// Token: 0x04003EE3 RID: 16099
		[Token(Token = "0x4003EE3")]
		[FieldOffset(Offset = "0x30")]
		public int height;

		// Token: 0x04003EE4 RID: 16100
		[Token(Token = "0x4003EE4")]
		[FieldOffset(Offset = "0x34")]
		public float Alpha;

		// Token: 0x04003EE5 RID: 16101
		[Token(Token = "0x4003EE5")]
		[FieldOffset(Offset = "0x38")]
		public bool kill;

		// Token: 0x04003EE6 RID: 16102
		[Token(Token = "0x4003EE6")]
		[FieldOffset(Offset = "0x0")]
		private static UnifiedRandom rand;

		// Token: 0x04003EE7 RID: 16103
		[Token(Token = "0x4003EE7")]
		[FieldOffset(Offset = "0x4")]
		public static Vector2? screenLastPosition;
	}
}
