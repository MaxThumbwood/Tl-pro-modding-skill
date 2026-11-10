using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BD8 RID: 3032
	[Token(Token = "0x2000BD8")]
	public static class Filters
	{
		// Token: 0x02000BD9 RID: 3033
		[Token(Token = "0x2000BD9")]
		public class BySearch : FileAPI, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x17000A37 RID: 2615
			// (get) Token: 0x06005BD1 RID: 23505 RVA: 0x0002B0E0 File Offset: 0x000292E0
			[Token(Token = "0x17000A37")]
			public bool? ForcedDisplay
			{
				[Token(Token = "0x6005BD1")]
				[Address(RVA = "0x9970E8", Offset = "0x9970E8", VA = "0x9970E8", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005BD2 RID: 23506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BD2")]
			[Address(RVA = "0x997150", Offset = "0x997150", VA = "0x997150")]
			public BySearch()
			{
			}

			// Token: 0x06005BD3 RID: 23507 RVA: 0x0002B0F8 File Offset: 0x000292F8
			[Token(Token = "0x6005BD3")]
			[Address(RVA = "0x997158", Offset = "0x997158", VA = "0x997158", Slot = "5")]
			public bool FitsFilter(BestiaryEntry entry)
			{
				return default(bool);
			}

			// Token: 0x06005BD4 RID: 23508 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BD4")]
			[Address(RVA = "0x997388", Offset = "0x997388", VA = "0x997388", Slot = "6")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06005BD5 RID: 23509 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BD5")]
			[Address(RVA = "0x9973D0", Offset = "0x9973D0", VA = "0x9973D0", Slot = "7")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x06005BD6 RID: 23510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BD6")]
			[Address(RVA = "0x99760C", Offset = "0x99760C", VA = "0x99760C", Slot = "8")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x06005BD7 RID: 23511 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BD7")]
			[Address(RVA = "0x9977D0", Offset = "0x9977D0", VA = "0x9977D0", Slot = "9")]
			public void SetSearch(string searchText)
			{
			}

			// Token: 0x04009CD4 RID: 40148
			[Token(Token = "0x4009CD4")]
			[FieldOffset(Offset = "0x8")]
			private string _search;
		}

		// Token: 0x02000BDA RID: 3034
		[Token(Token = "0x2000BDA")]
		public class ByUnlockState : FileAPI, GUIControllerItem
		{
			// Token: 0x17000A38 RID: 2616
			// (get) Token: 0x06005BD8 RID: 23512 RVA: 0x0002B110 File Offset: 0x00029310
			[Token(Token = "0x17000A38")]
			public bool? ForcedDisplay
			{
				[Token(Token = "0x6005BD8")]
				[Address(RVA = "0x9977D8", Offset = "0x9977D8", VA = "0x9977D8", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005BD9 RID: 23513 RVA: 0x0002B128 File Offset: 0x00029328
			[Token(Token = "0x6005BD9")]
			[Address(RVA = "0x997840", Offset = "0x997840", VA = "0x997840", Slot = "5")]
			public bool FitsFilter(BestiaryEntry entry)
			{
				return default(bool);
			}

			// Token: 0x06005BDA RID: 23514 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BDA")]
			[Address(RVA = "0x9979B8", Offset = "0x9979B8", VA = "0x9979B8", Slot = "6")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06005BDB RID: 23515 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BDB")]
			[Address(RVA = "0x997A00", Offset = "0x997A00", VA = "0x997A00", Slot = "7")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x06005BDC RID: 23516 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BDC")]
			[Address(RVA = "0x997C40", Offset = "0x997C40", VA = "0x997C40", Slot = "8")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x06005BDD RID: 23517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BDD")]
			[Address(RVA = "0x997E0C", Offset = "0x997E0C", VA = "0x997E0C")]
			public ByUnlockState()
			{
			}

			// Token: 0x04009CD5 RID: 40149
			[Token(Token = "0x4009CD5")]
			private const int framesPerRow = 16;

			// Token: 0x04009CD6 RID: 40150
			[Token(Token = "0x4009CD6")]
			private const int framesPerColumn = 5;
		}

		// Token: 0x02000BDB RID: 3035
		[Token(Token = "0x2000BDB")]
		public class ByRareCreature : FileAPI, GUIControllerItem
		{
			// Token: 0x17000A39 RID: 2617
			// (get) Token: 0x06005BDE RID: 23518 RVA: 0x0002B140 File Offset: 0x00029340
			[Token(Token = "0x17000A39")]
			public bool? ForcedDisplay
			{
				[Token(Token = "0x6005BDE")]
				[Address(RVA = "0x997E14", Offset = "0x997E14", VA = "0x997E14", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005BDF RID: 23519 RVA: 0x0002B158 File Offset: 0x00029358
			[Token(Token = "0x6005BDF")]
			[Address(RVA = "0x997E1C", Offset = "0x997E1C", VA = "0x997E1C", Slot = "5")]
			public bool FitsFilter(BestiaryEntry entry)
			{
				return default(bool);
			}

			// Token: 0x06005BE0 RID: 23520 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BE0")]
			[Address(RVA = "0x997F2C", Offset = "0x997F2C", VA = "0x997F2C", Slot = "6")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06005BE1 RID: 23521 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BE1")]
			[Address(RVA = "0x997F74", Offset = "0x997F74", VA = "0x997F74", Slot = "7")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x06005BE2 RID: 23522 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BE2")]
			[Address(RVA = "0x9981B0", Offset = "0x9981B0", VA = "0x9981B0", Slot = "8")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x06005BE3 RID: 23523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BE3")]
			[Address(RVA = "0x998374", Offset = "0x998374", VA = "0x998374")]
			public ByRareCreature()
			{
			}
		}

		// Token: 0x02000BDC RID: 3036
		[Token(Token = "0x2000BDC")]
		public class ByBoss : FileAPI, GUIControllerItem
		{
			// Token: 0x17000A3A RID: 2618
			// (get) Token: 0x06005BE4 RID: 23524 RVA: 0x0002B170 File Offset: 0x00029370
			[Token(Token = "0x17000A3A")]
			public bool? ForcedDisplay
			{
				[Token(Token = "0x6005BE4")]
				[Address(RVA = "0x99837C", Offset = "0x99837C", VA = "0x99837C", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005BE5 RID: 23525 RVA: 0x0002B188 File Offset: 0x00029388
			[Token(Token = "0x6005BE5")]
			[Address(RVA = "0x998384", Offset = "0x998384", VA = "0x998384", Slot = "5")]
			public bool FitsFilter(BestiaryEntry entry)
			{
				return default(bool);
			}

			// Token: 0x06005BE6 RID: 23526 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BE6")]
			[Address(RVA = "0x998494", Offset = "0x998494", VA = "0x998494", Slot = "6")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06005BE7 RID: 23527 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BE7")]
			[Address(RVA = "0x9984DC", Offset = "0x9984DC", VA = "0x9984DC", Slot = "7")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x06005BE8 RID: 23528 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BE8")]
			[Address(RVA = "0x99871C", Offset = "0x99871C", VA = "0x99871C", Slot = "8")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x06005BE9 RID: 23529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BE9")]
			[Address(RVA = "0x9988E8", Offset = "0x9988E8", VA = "0x9988E8")]
			public ByBoss()
			{
			}

			// Token: 0x04009CD7 RID: 40151
			[Token(Token = "0x4009CD7")]
			private const int framesPerRow = 16;

			// Token: 0x04009CD8 RID: 40152
			[Token(Token = "0x4009CD8")]
			private const int framesPerColumn = 5;
		}

		// Token: 0x02000BDD RID: 3037
		[Token(Token = "0x2000BDD")]
		public class ByInfoElement : FileAPI, GUIControllerItem
		{
			// Token: 0x17000A3B RID: 2619
			// (get) Token: 0x06005BEA RID: 23530 RVA: 0x0002B1A0 File Offset: 0x000293A0
			[Token(Token = "0x17000A3B")]
			public bool? ForcedDisplay
			{
				[Token(Token = "0x6005BEA")]
				[Address(RVA = "0x9988F0", Offset = "0x9988F0", VA = "0x9988F0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005BEB RID: 23531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BEB")]
			[Address(RVA = "0x9988F8", Offset = "0x9988F8", VA = "0x9988F8")]
			public ByInfoElement(IBestiaryInfoElement element)
			{
			}

			// Token: 0x06005BEC RID: 23532 RVA: 0x0002B1B8 File Offset: 0x000293B8
			[Token(Token = "0x6005BEC")]
			[Address(RVA = "0x998914", Offset = "0x998914", VA = "0x998914", Slot = "5")]
			public bool FitsFilter(BestiaryEntry entry)
			{
				return default(bool);
			}

			// Token: 0x06005BED RID: 23533 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BED")]
			[Address(RVA = "0x998990", Offset = "0x998990", VA = "0x998990", Slot = "6")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06005BEE RID: 23534 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BEE")]
			[Address(RVA = "0x998A58", Offset = "0x998A58", VA = "0x998A58", Slot = "7")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x06005BEF RID: 23535 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BEF")]
			[Address(RVA = "0x998B20", Offset = "0x998B20", VA = "0x998B20", Slot = "8")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x04009CD9 RID: 40153
			[Token(Token = "0x4009CD9")]
			[FieldOffset(Offset = "0x8")]
			private IBestiaryInfoElement _element;
		}
	}
}
