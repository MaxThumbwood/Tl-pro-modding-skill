using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x0200093B RID: 2363
	[Token(Token = "0x200093B")]
	public class PressurePlateHelper
	{
		// Token: 0x06004EEF RID: 20207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EEF")]
		[Address(RVA = "0x741F5C", Offset = "0x741F5C", VA = "0x741F5C")]
		public static void Update()
		{
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF0")]
		[Address(RVA = "0x742378", Offset = "0x742378", VA = "0x742378")]
		public static void Reset()
		{
		}

		// Token: 0x06004EF1 RID: 20209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF1")]
		[Address(RVA = "0x742510", Offset = "0x742510", VA = "0x742510")]
		public static void ResetPlayer(int player)
		{
		}

		// Token: 0x06004EF2 RID: 20210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF2")]
		[Address(RVA = "0x7428CC", Offset = "0x7428CC", VA = "0x7428CC")]
		public static void UpdatePlayerPosition(Player player)
		{
		}

		// Token: 0x06004EF3 RID: 20211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF3")]
		[Address(RVA = "0x743830", Offset = "0x743830", VA = "0x743830")]
		public static void DestroyPlate(Point location)
		{
		}

		// Token: 0x06004EF4 RID: 20212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF4")]
		[Address(RVA = "0x743960", Offset = "0x743960", VA = "0x743960")]
		private static void UpdatePlatePosition(Point location, int player, bool onIt)
		{
		}

		// Token: 0x06004EF5 RID: 20213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF5")]
		[Address(RVA = "0x74354C", Offset = "0x74354C", VA = "0x74354C")]
		private static void MoveInto(Point location, int player)
		{
		}

		// Token: 0x06004EF6 RID: 20214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF6")]
		[Address(RVA = "0x742638", Offset = "0x742638", VA = "0x742638")]
		private static void MoveAwayFrom(Point location, int player)
		{
		}

		// Token: 0x06004EF7 RID: 20215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF7")]
		[Address(RVA = "0x742240", Offset = "0x742240", VA = "0x742240")]
		private static void PokeLocation(Point location)
		{
		}

		// Token: 0x06004EF8 RID: 20216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF8")]
		[Address(RVA = "0x7439E8", Offset = "0x7439E8", VA = "0x7439E8")]
		public PressurePlateHelper()
		{
		}

		// Token: 0x0400934B RID: 37707
		[Token(Token = "0x400934B")]
		[FieldOffset(Offset = "0x0")]
		public static object EntityCreationLock;

		// Token: 0x0400934C RID: 37708
		[Token(Token = "0x400934C")]
		[FieldOffset(Offset = "0x4")]
		public static Dictionary<Point, bool[]> PressurePlatesPressed;

		// Token: 0x0400934D RID: 37709
		[Token(Token = "0x400934D")]
		[FieldOffset(Offset = "0x8")]
		public static bool NeedsFirstUpdate;

		// Token: 0x0400934E RID: 37710
		[Token(Token = "0x400934E")]
		[FieldOffset(Offset = "0xC")]
		private static Vector2[] PlayerLastPosition;

		// Token: 0x0400934F RID: 37711
		[Token(Token = "0x400934F")]
		[FieldOffset(Offset = "0x10")]
		private static Rectangle pressurePlateBounds;

		// Token: 0x04009350 RID: 37712
		[Token(Token = "0x4009350")]
		[FieldOffset(Offset = "0x20")]
		private static List<Point> tilesOld;

		// Token: 0x04009351 RID: 37713
		[Token(Token = "0x4009351")]
		[FieldOffset(Offset = "0x24")]
		private static List<Point> tilesNew;
	}
}
