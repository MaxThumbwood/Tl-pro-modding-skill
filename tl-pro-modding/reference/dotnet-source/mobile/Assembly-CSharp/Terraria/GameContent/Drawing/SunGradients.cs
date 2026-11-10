using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000CA2 RID: 3234
	[Token(Token = "0x2000CA2")]
	public class SunGradients
	{
		// Token: 0x06006001 RID: 24577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006001")]
		[Address(RVA = "0xA91D54", Offset = "0xA91D54", VA = "0xA91D54")]
		private static int[] Ocean()
		{
			return null;
		}

		// Token: 0x06006002 RID: 24578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006002")]
		[Address(RVA = "0xA91E14", Offset = "0xA91E14", VA = "0xA91E14")]
		public SunGradients()
		{
		}

		// Token: 0x04009ED3 RID: 40659
		[Token(Token = "0x4009ED3")]
		[FieldOffset(Offset = "0x0")]
		private static Color[] _Sunrise_Aluminum;

		// Token: 0x04009ED4 RID: 40660
		[Token(Token = "0x4009ED4")]
		[FieldOffset(Offset = "0x4")]
		private static Color[] _Sunrise_Blue;

		// Token: 0x04009ED5 RID: 40661
		[Token(Token = "0x4009ED5")]
		[FieldOffset(Offset = "0x8")]
		private static Color[] _Sunrise_Violet;

		// Token: 0x04009ED6 RID: 40662
		[Token(Token = "0x4009ED6")]
		[FieldOffset(Offset = "0xC")]
		private static Color[] _Sunrise_Yellow;

		// Token: 0x04009ED7 RID: 40663
		[Token(Token = "0x4009ED7")]
		[FieldOffset(Offset = "0x10")]
		private static Color[] _Sunset_Blue;

		// Token: 0x04009ED8 RID: 40664
		[Token(Token = "0x4009ED8")]
		[FieldOffset(Offset = "0x14")]
		private static Color[] _Sunset_Dark;

		// Token: 0x04009ED9 RID: 40665
		[Token(Token = "0x4009ED9")]
		[FieldOffset(Offset = "0x18")]
		private static Color[] _Sunset_Pink;

		// Token: 0x04009EDA RID: 40666
		[Token(Token = "0x4009EDA")]
		[FieldOffset(Offset = "0x1C")]
		private static Color[] _Sunset_Red;

		// Token: 0x04009EDB RID: 40667
		[Token(Token = "0x4009EDB")]
		[FieldOffset(Offset = "0x20")]
		public static List<Color[]> Sunrises;

		// Token: 0x04009EDC RID: 40668
		[Token(Token = "0x4009EDC")]
		[FieldOffset(Offset = "0x24")]
		public static List<Color[]> Sunsets;

		// Token: 0x04009EDD RID: 40669
		[Token(Token = "0x4009EDD")]
		[FieldOffset(Offset = "0x28")]
		public static Dictionary<int, Color> BackgroundGradientColors;

		// Token: 0x04009EDE RID: 40670
		[Token(Token = "0x4009EDE")]
		[FieldOffset(Offset = "0x2C")]
		public static List<BackgroundGradientDrawer> BackgroundDrawers;

		// Token: 0x04009EDF RID: 40671
		[Token(Token = "0x4009EDF")]
		[FieldOffset(Offset = "0x30")]
		private static int[] oceanArray;

		// Token: 0x02000CA3 RID: 3235
		[Token(Token = "0x2000CA3")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006005 RID: 24581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006005")]
			[Address(RVA = "0xA95734", Offset = "0xA95734", VA = "0xA95734")]
			public <>c()
			{
			}

			// Token: 0x06006006 RID: 24582 RVA: 0x0002C430 File Offset: 0x0002A630
			[Token(Token = "0x6006006")]
			[Address(RVA = "0xA9573C", Offset = "0xA9573C", VA = "0xA9573C")]
			internal float <.cctor>b__15_0()
			{
				return 0f;
			}

			// Token: 0x06006007 RID: 24583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006007")]
			[Address(RVA = "0xA957B8", Offset = "0xA957B8", VA = "0xA957B8")]
			internal int[] <.cctor>b__15_1()
			{
				return null;
			}

			// Token: 0x06006008 RID: 24584 RVA: 0x0002C448 File Offset: 0x0002A648
			[Token(Token = "0x6006008")]
			[Address(RVA = "0xA9581C", Offset = "0xA9581C", VA = "0xA9581C")]
			internal float <.cctor>b__15_2()
			{
				return 0f;
			}

			// Token: 0x06006009 RID: 24585 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006009")]
			[Address(RVA = "0xA95898", Offset = "0xA95898", VA = "0xA95898")]
			internal int[] <.cctor>b__15_3()
			{
				return null;
			}

			// Token: 0x0600600A RID: 24586 RVA: 0x0002C460 File Offset: 0x0002A660
			[Token(Token = "0x600600A")]
			[Address(RVA = "0xA958FC", Offset = "0xA958FC", VA = "0xA958FC")]
			internal float <.cctor>b__15_4()
			{
				return 0f;
			}

			// Token: 0x0600600B RID: 24587 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600600B")]
			[Address(RVA = "0xA95978", Offset = "0xA95978", VA = "0xA95978")]
			internal int[] <.cctor>b__15_5()
			{
				return null;
			}

			// Token: 0x0600600C RID: 24588 RVA: 0x0002C478 File Offset: 0x0002A678
			[Token(Token = "0x600600C")]
			[Address(RVA = "0xA959DC", Offset = "0xA959DC", VA = "0xA959DC")]
			internal float <.cctor>b__15_6()
			{
				return 0f;
			}

			// Token: 0x0600600D RID: 24589 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600600D")]
			[Address(RVA = "0xA95A58", Offset = "0xA95A58", VA = "0xA95A58")]
			internal int[] <.cctor>b__15_7()
			{
				return null;
			}

			// Token: 0x0600600E RID: 24590 RVA: 0x0002C490 File Offset: 0x0002A690
			[Token(Token = "0x600600E")]
			[Address(RVA = "0xA95ABC", Offset = "0xA95ABC", VA = "0xA95ABC")]
			internal float <.cctor>b__15_8()
			{
				return 0f;
			}

			// Token: 0x0600600F RID: 24591 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600600F")]
			[Address(RVA = "0xA95B38", Offset = "0xA95B38", VA = "0xA95B38")]
			internal int[] <.cctor>b__15_9()
			{
				return null;
			}

			// Token: 0x06006010 RID: 24592 RVA: 0x0002C4A8 File Offset: 0x0002A6A8
			[Token(Token = "0x6006010")]
			[Address(RVA = "0xA95B9C", Offset = "0xA95B9C", VA = "0xA95B9C")]
			internal float <.cctor>b__15_10()
			{
				return 0f;
			}

			// Token: 0x06006011 RID: 24593 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006011")]
			[Address(RVA = "0xA95C18", Offset = "0xA95C18", VA = "0xA95C18")]
			internal int[] <.cctor>b__15_11()
			{
				return null;
			}

			// Token: 0x06006012 RID: 24594 RVA: 0x0002C4C0 File Offset: 0x0002A6C0
			[Token(Token = "0x6006012")]
			[Address(RVA = "0xA95C7C", Offset = "0xA95C7C", VA = "0xA95C7C")]
			internal float <.cctor>b__15_12()
			{
				return 0f;
			}

			// Token: 0x06006013 RID: 24595 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006013")]
			[Address(RVA = "0xA95CF8", Offset = "0xA95CF8", VA = "0xA95CF8")]
			internal int[] <.cctor>b__15_13()
			{
				return null;
			}

			// Token: 0x06006014 RID: 24596 RVA: 0x0002C4D8 File Offset: 0x0002A6D8
			[Token(Token = "0x6006014")]
			[Address(RVA = "0xA95D5C", Offset = "0xA95D5C", VA = "0xA95D5C")]
			internal float <.cctor>b__15_14()
			{
				return 0f;
			}

			// Token: 0x06006015 RID: 24597 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006015")]
			[Address(RVA = "0xA95DD8", Offset = "0xA95DD8", VA = "0xA95DD8")]
			internal int[] <.cctor>b__15_15()
			{
				return null;
			}

			// Token: 0x06006016 RID: 24598 RVA: 0x0002C4F0 File Offset: 0x0002A6F0
			[Token(Token = "0x6006016")]
			[Address(RVA = "0xA95E3C", Offset = "0xA95E3C", VA = "0xA95E3C")]
			internal float <.cctor>b__15_16()
			{
				return 0f;
			}

			// Token: 0x06006017 RID: 24599 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006017")]
			[Address(RVA = "0xA95EB8", Offset = "0xA95EB8", VA = "0xA95EB8")]
			internal int[] <.cctor>b__15_17()
			{
				return null;
			}

			// Token: 0x06006018 RID: 24600 RVA: 0x0002C508 File Offset: 0x0002A708
			[Token(Token = "0x6006018")]
			[Address(RVA = "0xA95F44", Offset = "0xA95F44", VA = "0xA95F44")]
			internal float <.cctor>b__15_18()
			{
				return 0f;
			}

			// Token: 0x06006019 RID: 24601 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006019")]
			[Address(RVA = "0xA95FC0", Offset = "0xA95FC0", VA = "0xA95FC0")]
			internal int[] <.cctor>b__15_19()
			{
				return null;
			}

			// Token: 0x0600601A RID: 24602 RVA: 0x0002C520 File Offset: 0x0002A720
			[Token(Token = "0x600601A")]
			[Address(RVA = "0xA96024", Offset = "0xA96024", VA = "0xA96024")]
			internal float <.cctor>b__15_20()
			{
				return 0f;
			}

			// Token: 0x0600601B RID: 24603 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600601B")]
			[Address(RVA = "0xA960A0", Offset = "0xA960A0", VA = "0xA960A0")]
			internal int[] <.cctor>b__15_21()
			{
				return null;
			}

			// Token: 0x0600601C RID: 24604 RVA: 0x0002C538 File Offset: 0x0002A738
			[Token(Token = "0x600601C")]
			[Address(RVA = "0xA96104", Offset = "0xA96104", VA = "0xA96104")]
			internal float <.cctor>b__15_22()
			{
				return 0f;
			}

			// Token: 0x0600601D RID: 24605 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600601D")]
			[Address(RVA = "0xA96180", Offset = "0xA96180", VA = "0xA96180")]
			internal int[] <.cctor>b__15_23()
			{
				return null;
			}

			// Token: 0x0600601E RID: 24606 RVA: 0x0002C550 File Offset: 0x0002A750
			[Token(Token = "0x600601E")]
			[Address(RVA = "0xA961E4", Offset = "0xA961E4", VA = "0xA961E4")]
			internal float <.cctor>b__15_24()
			{
				return 0f;
			}

			// Token: 0x04009EE0 RID: 40672
			[Token(Token = "0x4009EE0")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SunGradients.<>c <>9;
		}
	}
}
