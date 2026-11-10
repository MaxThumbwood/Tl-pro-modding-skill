using System;
using Il2CppDummyDll;

namespace Terraria.WorldBuilding
{
	// Token: 0x0200056E RID: 1390
	[Token(Token = "0x200056E")]
	public static class Conditions
	{
		// Token: 0x0200056F RID: 1391
		[Token(Token = "0x200056F")]
		public class IsTile : GenCondition
		{
			// Token: 0x06003A4B RID: 14923 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A4B")]
			[Address(RVA = "0x1E00968", Offset = "0x1E00968", VA = "0x1E00968")]
			public IsTile(ushort[] types)
			{
			}

			// Token: 0x06003A4C RID: 14924 RVA: 0x0001D580 File Offset: 0x0001B780
			[Token(Token = "0x6003A4C")]
			[Address(RVA = "0x1E00990", Offset = "0x1E00990", VA = "0x1E00990", Slot = "4")]
			protected override bool CheckValidity(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x040045FD RID: 17917
			[Token(Token = "0x40045FD")]
			[FieldOffset(Offset = "0x18")]
			private ushort[] _types;
		}

		// Token: 0x02000570 RID: 1392
		[Token(Token = "0x2000570")]
		public class Continue : GenCondition
		{
			// Token: 0x06003A4D RID: 14925 RVA: 0x0001D598 File Offset: 0x0001B798
			[Token(Token = "0x6003A4D")]
			[Address(RVA = "0x1E00CD8", Offset = "0x1E00CD8", VA = "0x1E00CD8", Slot = "4")]
			protected override bool CheckValidity(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x06003A4E RID: 14926 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A4E")]
			[Address(RVA = "0x1E00CE0", Offset = "0x1E00CE0", VA = "0x1E00CE0")]
			public Continue()
			{
			}
		}

		// Token: 0x02000571 RID: 1393
		[Token(Token = "0x2000571")]
		public class BoolCheck : GenCondition
		{
			// Token: 0x06003A4F RID: 14927 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A4F")]
			[Address(RVA = "0x1E00CF0", Offset = "0x1E00CF0", VA = "0x1E00CF0")]
			public BoolCheck(bool theBool)
			{
			}

			// Token: 0x06003A50 RID: 14928 RVA: 0x0001D5B0 File Offset: 0x0001B7B0
			[Token(Token = "0x6003A50")]
			[Address(RVA = "0x1E00D18", Offset = "0x1E00D18", VA = "0x1E00D18", Slot = "4")]
			protected override bool CheckValidity(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x040045FE RID: 17918
			[Token(Token = "0x40045FE")]
			[FieldOffset(Offset = "0x18")]
			private bool _theBool;
		}

		// Token: 0x02000572 RID: 1394
		[Token(Token = "0x2000572")]
		public class MysticSnake : GenCondition
		{
			// Token: 0x06003A51 RID: 14929 RVA: 0x0001D5C8 File Offset: 0x0001B7C8
			[Token(Token = "0x6003A51")]
			[Address(RVA = "0x1E00D20", Offset = "0x1E00D20", VA = "0x1E00D20", Slot = "4")]
			protected override bool CheckValidity(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x06003A52 RID: 14930 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A52")]
			[Address(RVA = "0x1E010D0", Offset = "0x1E010D0", VA = "0x1E010D0")]
			public MysticSnake()
			{
			}
		}

		// Token: 0x02000573 RID: 1395
		[Token(Token = "0x2000573")]
		public class InWorld : GenCondition
		{
			// Token: 0x06003A53 RID: 14931 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A53")]
			[Address(RVA = "0x1E010E0", Offset = "0x1E010E0", VA = "0x1E010E0")]
			public InWorld(int fluff)
			{
			}

			// Token: 0x06003A54 RID: 14932 RVA: 0x0001D5E0 File Offset: 0x0001B7E0
			[Token(Token = "0x6003A54")]
			[Address(RVA = "0x1E01108", Offset = "0x1E01108", VA = "0x1E01108", Slot = "4")]
			protected override bool CheckValidity(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x040045FF RID: 17919
			[Token(Token = "0x40045FF")]
			[FieldOffset(Offset = "0x18")]
			private int _fluff;
		}

		// Token: 0x02000574 RID: 1396
		[Token(Token = "0x2000574")]
		public class IsSolid : GenCondition
		{
			// Token: 0x06003A55 RID: 14933 RVA: 0x0001D5F8 File Offset: 0x0001B7F8
			[Token(Token = "0x6003A55")]
			[Address(RVA = "0x1E01184", Offset = "0x1E01184", VA = "0x1E01184", Slot = "4")]
			protected override bool CheckValidity(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x06003A56 RID: 14934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A56")]
			[Address(RVA = "0x1E01460", Offset = "0x1E01460", VA = "0x1E01460")]
			public IsSolid()
			{
			}
		}

		// Token: 0x02000575 RID: 1397
		[Token(Token = "0x2000575")]
		public class HasLava : GenCondition
		{
			// Token: 0x06003A57 RID: 14935 RVA: 0x0001D610 File Offset: 0x0001B810
			[Token(Token = "0x6003A57")]
			[Address(RVA = "0x1E01470", Offset = "0x1E01470", VA = "0x1E01470", Slot = "4")]
			protected override bool CheckValidity(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x06003A58 RID: 14936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A58")]
			[Address(RVA = "0x1E016A8", Offset = "0x1E016A8", VA = "0x1E016A8")]
			public HasLava()
			{
			}
		}

		// Token: 0x02000576 RID: 1398
		[Token(Token = "0x2000576")]
		public class NotNull : GenCondition
		{
			// Token: 0x06003A59 RID: 14937 RVA: 0x0001D628 File Offset: 0x0001B828
			[Token(Token = "0x6003A59")]
			[Address(RVA = "0x1E016B8", Offset = "0x1E016B8", VA = "0x1E016B8", Slot = "4")]
			protected override bool CheckValidity(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x06003A5A RID: 14938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A5A")]
			[Address(RVA = "0x1E01748", Offset = "0x1E01748", VA = "0x1E01748")]
			public NotNull()
			{
			}
		}
	}
}
