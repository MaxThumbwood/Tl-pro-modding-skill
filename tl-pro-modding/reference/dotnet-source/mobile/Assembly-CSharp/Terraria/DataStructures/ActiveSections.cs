using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x0200073D RID: 1853
	[Token(Token = "0x200073D")]
	public static class ActiveSections
	{
		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06004217 RID: 16919 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004218 RID: 16920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000040")]
		public static event Action<Point> SectionActivated
		{
			[Token(Token = "0x6004217")]
			[Address(RVA = "0x4ED13C", Offset = "0x4ED13C", VA = "0x4ED13C")]
			add
			{
			}
			[Token(Token = "0x6004218")]
			[Address(RVA = "0x4ED25C", Offset = "0x4ED25C", VA = "0x4ED25C")]
			remove
			{
			}
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004219")]
		[Address(RVA = "0x4ED37C", Offset = "0x4ED37C", VA = "0x4ED37C")]
		public static void CheckSection(Vector2 position, int fluff = 1)
		{
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x00020268 File Offset: 0x0001E468
		[Token(Token = "0x600421A")]
		[Address(RVA = "0x4ED6C0", Offset = "0x4ED6C0", VA = "0x4ED6C0")]
		public static bool IsSectionActive(Point sectionCoords)
		{
			return default(bool);
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x00020280 File Offset: 0x0001E480
		[Token(Token = "0x600421B")]
		[Address(RVA = "0x4ED918", Offset = "0x4ED918", VA = "0x4ED918")]
		public static int TimeTillInactive(Point sectionCoords)
		{
			return 0;
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600421C")]
		[Address(RVA = "0x4EDAA4", Offset = "0x4EDAA4", VA = "0x4EDAA4")]
		public static void Reset()
		{
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600421D")]
		[Address(RVA = "0x4EDC88", Offset = "0x4EDC88", VA = "0x4EDC88")]
		public static void CheckSize()
		{
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x00020298 File Offset: 0x0001E498
		[Token(Token = "0x600421E")]
		[Address(RVA = "0x4ED804", Offset = "0x4ED804", VA = "0x4ED804")]
		public static Point ClampSectionCoords(Point point)
		{
			return default(Point);
		}

		// Token: 0x040089E8 RID: 35304
		[Token(Token = "0x40089E8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly uint SectionInactiveTime;

		// Token: 0x040089E9 RID: 35305
		[Token(Token = "0x40089E9")]
		[FieldOffset(Offset = "0x4")]
		private static uint[,] LastActiveTime;
	}
}
