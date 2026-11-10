using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x0200059F RID: 1439
	[Token(Token = "0x200059F")]
	public static class Searches
	{
		// Token: 0x06003ACC RID: 15052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ACC")]
		[Address(RVA = "0x1E06ED4", Offset = "0x1E06ED4", VA = "0x1E06ED4")]
		public static GenSearch Chain(GenSearch search, GenCondition[] conditions)
		{
			return null;
		}

		// Token: 0x020005A0 RID: 1440
		[Token(Token = "0x20005A0")]
		public class Left : GenSearch
		{
			// Token: 0x06003ACD RID: 15053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003ACD")]
			[Address(RVA = "0x1E06EF8", Offset = "0x1E06EF8", VA = "0x1E06EF8")]
			public Left(int maxDistance)
			{
			}

			// Token: 0x06003ACE RID: 15054 RVA: 0x0001D9E8 File Offset: 0x0001BBE8
			[Token(Token = "0x6003ACE")]
			[Address(RVA = "0x1E06F70", Offset = "0x1E06F70", VA = "0x1E06F70", Slot = "4")]
			public override Point Find(Point origin)
			{
				return default(Point);
			}

			// Token: 0x04004642 RID: 17986
			[Token(Token = "0x4004642")]
			[FieldOffset(Offset = "0x10")]
			private int _maxDistance;
		}

		// Token: 0x020005A1 RID: 1441
		[Token(Token = "0x20005A1")]
		public class Right : GenSearch
		{
			// Token: 0x06003ACF RID: 15055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003ACF")]
			[Address(RVA = "0x1E070CC", Offset = "0x1E070CC", VA = "0x1E070CC")]
			public Right(int maxDistance)
			{
			}

			// Token: 0x06003AD0 RID: 15056 RVA: 0x0001DA00 File Offset: 0x0001BC00
			[Token(Token = "0x6003AD0")]
			[Address(RVA = "0x1E07144", Offset = "0x1E07144", VA = "0x1E07144", Slot = "4")]
			public override Point Find(Point origin)
			{
				return default(Point);
			}

			// Token: 0x04004643 RID: 17987
			[Token(Token = "0x4004643")]
			[FieldOffset(Offset = "0x10")]
			private int _maxDistance;
		}

		// Token: 0x020005A2 RID: 1442
		[Token(Token = "0x20005A2")]
		public class Down : GenSearch
		{
			// Token: 0x06003AD1 RID: 15057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AD1")]
			[Address(RVA = "0x1E072A0", Offset = "0x1E072A0", VA = "0x1E072A0")]
			public Down(int maxDistance)
			{
			}

			// Token: 0x06003AD2 RID: 15058 RVA: 0x0001DA18 File Offset: 0x0001BC18
			[Token(Token = "0x6003AD2")]
			[Address(RVA = "0x1E07318", Offset = "0x1E07318", VA = "0x1E07318", Slot = "4")]
			public override Point Find(Point origin)
			{
				return default(Point);
			}

			// Token: 0x04004644 RID: 17988
			[Token(Token = "0x4004644")]
			[FieldOffset(Offset = "0x10")]
			private int _maxDistance;
		}

		// Token: 0x020005A3 RID: 1443
		[Token(Token = "0x20005A3")]
		public class Up : GenSearch
		{
			// Token: 0x06003AD3 RID: 15059 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AD3")]
			[Address(RVA = "0x1E074BC", Offset = "0x1E074BC", VA = "0x1E074BC")]
			public Up(int maxDistance)
			{
			}

			// Token: 0x06003AD4 RID: 15060 RVA: 0x0001DA30 File Offset: 0x0001BC30
			[Token(Token = "0x6003AD4")]
			[Address(RVA = "0x1E07534", Offset = "0x1E07534", VA = "0x1E07534", Slot = "4")]
			public override Point Find(Point origin)
			{
				return default(Point);
			}

			// Token: 0x04004645 RID: 17989
			[Token(Token = "0x4004645")]
			[FieldOffset(Offset = "0x10")]
			private int _maxDistance;
		}

		// Token: 0x020005A4 RID: 1444
		[Token(Token = "0x20005A4")]
		public class Rectangle : GenSearch
		{
			// Token: 0x06003AD5 RID: 15061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AD5")]
			[Address(RVA = "0x1E07690", Offset = "0x1E07690", VA = "0x1E07690")]
			public Rectangle(int width, int height)
			{
			}

			// Token: 0x06003AD6 RID: 15062 RVA: 0x0001DA48 File Offset: 0x0001BC48
			[Token(Token = "0x6003AD6")]
			[Address(RVA = "0x1E07710", Offset = "0x1E07710", VA = "0x1E07710", Slot = "4")]
			public override Point Find(Point origin)
			{
				return default(Point);
			}

			// Token: 0x04004646 RID: 17990
			[Token(Token = "0x4004646")]
			[FieldOffset(Offset = "0x10")]
			private int _width;

			// Token: 0x04004647 RID: 17991
			[Token(Token = "0x4004647")]
			[FieldOffset(Offset = "0x14")]
			private int _height;
		}
	}
}
