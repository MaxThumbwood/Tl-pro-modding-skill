using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Generation.Dungeon
{
	// Token: 0x02000B1B RID: 2843
	[Token(Token = "0x2000B1B")]
	public struct DungeonPlatformData
	{
		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06005885 RID: 22661 RVA: 0x00029370 File Offset: 0x00027570
		[Token(Token = "0x170009F7")]
		public bool IsAShelf
		{
			[Token(Token = "0x6005885")]
			[Address(RVA = "0x873DEC", Offset = "0x873DEC", VA = "0x873DEC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040099BF RID: 39359
		[Token(Token = "0x40099BF")]
		[FieldOffset(Offset = "0x0")]
		public Point Position;

		// Token: 0x040099C0 RID: 39360
		[Token(Token = "0x40099C0")]
		[FieldOffset(Offset = "0x8")]
		public int? OverrideStyle;

		// Token: 0x040099C1 RID: 39361
		[Token(Token = "0x40099C1")]
		[FieldOffset(Offset = "0x10")]
		public int OverrideMaxLengthAllowed;

		// Token: 0x040099C2 RID: 39362
		[Token(Token = "0x40099C2")]
		[FieldOffset(Offset = "0x14")]
		public int? OverrideHeightFluff;

		// Token: 0x040099C3 RID: 39363
		[Token(Token = "0x40099C3")]
		[FieldOffset(Offset = "0x1C")]
		public bool InAHallway;

		// Token: 0x040099C4 RID: 39364
		[Token(Token = "0x40099C4")]
		[FieldOffset(Offset = "0x1D")]
		public bool ForcePlacement;

		// Token: 0x040099C5 RID: 39365
		[Token(Token = "0x40099C5")]
		[FieldOffset(Offset = "0x1E")]
		public bool SkipOtherPlatformsCheck;

		// Token: 0x040099C6 RID: 39366
		[Token(Token = "0x40099C6")]
		[FieldOffset(Offset = "0x1F")]
		public bool SkipSpaceCheck;

		// Token: 0x040099C7 RID: 39367
		[Token(Token = "0x40099C7")]
		[FieldOffset(Offset = "0x20")]
		public double PlaceBooksChance;

		// Token: 0x040099C8 RID: 39368
		[Token(Token = "0x40099C8")]
		[FieldOffset(Offset = "0x28")]
		public bool NoWaterbolt;

		// Token: 0x040099C9 RID: 39369
		[Token(Token = "0x40099C9")]
		[FieldOffset(Offset = "0x30")]
		public double PlacePotsChance;

		// Token: 0x040099CA RID: 39370
		[Token(Token = "0x40099CA")]
		[FieldOffset(Offset = "0x38")]
		public double PlaceWaterCandlesChance;

		// Token: 0x040099CB RID: 39371
		[Token(Token = "0x40099CB")]
		[FieldOffset(Offset = "0x40")]
		public double PlacePotionBottlesChance;

		// Token: 0x040099CC RID: 39372
		[Token(Token = "0x40099CC")]
		[FieldOffset(Offset = "0x48")]
		public Func<DungeonData, int, int, bool> canPlaceHereCallback;
	}
}
