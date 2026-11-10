using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200078D RID: 1933
	[Token(Token = "0x200078D")]
	public struct FishingAttempt
	{
		// Token: 0x04008B7F RID: 35711
		[Token(Token = "0x4008B7F")]
		[FieldOffset(Offset = "0x0")]
		public PlayerFishingConditions playerFishingConditions;

		// Token: 0x04008B80 RID: 35712
		[Token(Token = "0x4008B80")]
		[FieldOffset(Offset = "0x18")]
		public int X;

		// Token: 0x04008B81 RID: 35713
		[Token(Token = "0x4008B81")]
		[FieldOffset(Offset = "0x1C")]
		public int Y;

		// Token: 0x04008B82 RID: 35714
		[Token(Token = "0x4008B82")]
		[FieldOffset(Offset = "0x20")]
		public int bobberType;

		// Token: 0x04008B83 RID: 35715
		[Token(Token = "0x4008B83")]
		[FieldOffset(Offset = "0x24")]
		public bool common;

		// Token: 0x04008B84 RID: 35716
		[Token(Token = "0x4008B84")]
		[FieldOffset(Offset = "0x25")]
		public bool uncommon;

		// Token: 0x04008B85 RID: 35717
		[Token(Token = "0x4008B85")]
		[FieldOffset(Offset = "0x26")]
		public bool rare;

		// Token: 0x04008B86 RID: 35718
		[Token(Token = "0x4008B86")]
		[FieldOffset(Offset = "0x27")]
		public bool veryrare;

		// Token: 0x04008B87 RID: 35719
		[Token(Token = "0x4008B87")]
		[FieldOffset(Offset = "0x28")]
		public bool legendary;

		// Token: 0x04008B88 RID: 35720
		[Token(Token = "0x4008B88")]
		[FieldOffset(Offset = "0x29")]
		public bool crate;

		// Token: 0x04008B89 RID: 35721
		[Token(Token = "0x4008B89")]
		[FieldOffset(Offset = "0x2A")]
		public bool junk;

		// Token: 0x04008B8A RID: 35722
		[Token(Token = "0x4008B8A")]
		[FieldOffset(Offset = "0x2B")]
		public bool inLava;

		// Token: 0x04008B8B RID: 35723
		[Token(Token = "0x4008B8B")]
		[FieldOffset(Offset = "0x2C")]
		public bool inHoney;

		// Token: 0x04008B8C RID: 35724
		[Token(Token = "0x4008B8C")]
		[FieldOffset(Offset = "0x30")]
		public int waterTilesCount;

		// Token: 0x04008B8D RID: 35725
		[Token(Token = "0x4008B8D")]
		[FieldOffset(Offset = "0x34")]
		public int waterNeededToFish;

		// Token: 0x04008B8E RID: 35726
		[Token(Token = "0x4008B8E")]
		[FieldOffset(Offset = "0x38")]
		public float waterQuality;

		// Token: 0x04008B8F RID: 35727
		[Token(Token = "0x4008B8F")]
		[FieldOffset(Offset = "0x3C")]
		public int chumsInWater;

		// Token: 0x04008B90 RID: 35728
		[Token(Token = "0x4008B90")]
		[FieldOffset(Offset = "0x40")]
		public int fishingLevel;

		// Token: 0x04008B91 RID: 35729
		[Token(Token = "0x4008B91")]
		[FieldOffset(Offset = "0x44")]
		public bool CanFishInLava;

		// Token: 0x04008B92 RID: 35730
		[Token(Token = "0x4008B92")]
		[FieldOffset(Offset = "0x48")]
		public float atmo;

		// Token: 0x04008B93 RID: 35731
		[Token(Token = "0x4008B93")]
		[FieldOffset(Offset = "0x4C")]
		public int questFish;

		// Token: 0x04008B94 RID: 35732
		[Token(Token = "0x4008B94")]
		[FieldOffset(Offset = "0x50")]
		public int heightLevel;

		// Token: 0x04008B95 RID: 35733
		[Token(Token = "0x4008B95")]
		[FieldOffset(Offset = "0x54")]
		public int rolledItemDrop;

		// Token: 0x04008B96 RID: 35734
		[Token(Token = "0x4008B96")]
		[FieldOffset(Offset = "0x58")]
		public int rolledEnemySpawn;
	}
}
