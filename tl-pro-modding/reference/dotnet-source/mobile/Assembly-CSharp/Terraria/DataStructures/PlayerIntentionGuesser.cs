using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.GameContent;

namespace Terraria.DataStructures
{
	// Token: 0x02000790 RID: 1936
	[Token(Token = "0x2000790")]
	public class PlayerIntentionGuesser
	{
		// Token: 0x06004407 RID: 17415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004407")]
		[Address(RVA = "0x5579D0", Offset = "0x5579D0", VA = "0x5579D0")]
		public void Track(Player player, int x, int y, GuessedPlayerIntention intention)
		{
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004408")]
		[Address(RVA = "0x557AF8", Offset = "0x557AF8", VA = "0x557AF8")]
		public void AllowTracking(int time = 60)
		{
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004409")]
		[Address(RVA = "0x557B00", Offset = "0x557B00", VA = "0x557B00")]
		public void Update(Player player)
		{
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440A")]
		[Address(RVA = "0x557D08", Offset = "0x557D08", VA = "0x557D08")]
		public void PrepareUsageProxy(Player player, int itemType, int areaInflateWidth, int areaInflateHeight)
		{
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440B")]
		[Address(RVA = "0x558160", Offset = "0x558160", VA = "0x558160")]
		public PlayerIntentionGuesser()
		{
		}

		// Token: 0x04008B9D RID: 35741
		[Token(Token = "0x4008B9D")]
		[FieldOffset(Offset = "0x8")]
		public int LastX;

		// Token: 0x04008B9E RID: 35742
		[Token(Token = "0x4008B9E")]
		[FieldOffset(Offset = "0xC")]
		public int LastY;

		// Token: 0x04008B9F RID: 35743
		[Token(Token = "0x4008B9F")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 LastPosition;

		// Token: 0x04008BA0 RID: 35744
		[Token(Token = "0x4008BA0")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 LastCenter;

		// Token: 0x04008BA1 RID: 35745
		[Token(Token = "0x4008BA1")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 LastMouse;

		// Token: 0x04008BA2 RID: 35746
		[Token(Token = "0x4008BA2")]
		[FieldOffset(Offset = "0x28")]
		public int LastDirection;

		// Token: 0x04008BA3 RID: 35747
		[Token(Token = "0x4008BA3")]
		[FieldOffset(Offset = "0x2C")]
		public int LastWidth;

		// Token: 0x04008BA4 RID: 35748
		[Token(Token = "0x4008BA4")]
		[FieldOffset(Offset = "0x30")]
		public GuessedPlayerIntention Intention;

		// Token: 0x04008BA5 RID: 35749
		[Token(Token = "0x4008BA5")]
		[FieldOffset(Offset = "0x34")]
		public SmartCursorHelper.SmartCursorUsageInfo UsageProxy;

		// Token: 0x04008BA6 RID: 35750
		[Token(Token = "0x4008BA6")]
		[FieldOffset(Offset = "0x38")]
		public int TimeWithIntention;

		// Token: 0x04008BA7 RID: 35751
		[Token(Token = "0x4008BA7")]
		[FieldOffset(Offset = "0x3C")]
		public int PlayerActiveActionTimeLeft;
	}
}
