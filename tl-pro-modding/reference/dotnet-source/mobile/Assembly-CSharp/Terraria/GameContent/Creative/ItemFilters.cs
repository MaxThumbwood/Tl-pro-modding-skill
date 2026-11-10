using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000CDE RID: 3294
	[Token(Token = "0x2000CDE")]
	public static class ItemFilters
	{
		// Token: 0x0400A05B RID: 41051
		[Token(Token = "0x400A05B")]
		private const int framesPerRow = 11;

		// Token: 0x0400A05C RID: 41052
		[Token(Token = "0x400A05C")]
		private const int framesPerColumn = 1;

		// Token: 0x0400A05D RID: 41053
		[Token(Token = "0x400A05D")]
		private const int frameSizeOffsetX = -2;

		// Token: 0x0400A05E RID: 41054
		[Token(Token = "0x400A05E")]
		private const int frameSizeOffsetY = 0;

		// Token: 0x02000CDF RID: 3295
		[Token(Token = "0x2000CDF")]
		public class BySearch : FileAPI, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x060061D6 RID: 25046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061D6")]
			[Address(RVA = "0xADF950", Offset = "0xADF950", VA = "0xADF950")]
			public BySearch()
			{
			}

			// Token: 0x060061D7 RID: 25047 RVA: 0x0002D1F8 File Offset: 0x0002B3F8
			[Token(Token = "0x60061D7")]
			[Address(RVA = "0xADF9F0", Offset = "0xADF9F0", VA = "0xADF9F0", Slot = "4")]
			public bool FitsFilter(Item entry)
			{
				return default(bool);
			}

			// Token: 0x060061D8 RID: 25048 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061D8")]
			[Address(RVA = "0xADFBC8", Offset = "0xADFBC8", VA = "0xADFBC8", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x060061D9 RID: 25049 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061D9")]
			[Address(RVA = "0xADFC10", Offset = "0xADFC10", VA = "0xADFC10", Slot = "6")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x060061DA RID: 25050 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061DA")]
			[Address(RVA = "0xADFE4C", Offset = "0xADFE4C", VA = "0xADFE4C", Slot = "7")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x060061DB RID: 25051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061DB")]
			[Address(RVA = "0xAE0010", Offset = "0xAE0010", VA = "0xAE0010", Slot = "8")]
			public void SetSearch(string searchText)
			{
			}

			// Token: 0x0400A05F RID: 41055
			[Token(Token = "0x400A05F")]
			private const int _tooltipMaxLines = 30;

			// Token: 0x0400A060 RID: 41056
			[Token(Token = "0x400A060")]
			[FieldOffset(Offset = "0x8")]
			private string[] _toolTipLines;

			// Token: 0x0400A061 RID: 41057
			[Token(Token = "0x400A061")]
			[FieldOffset(Offset = "0xC")]
			private bool[] _unusedPrefixLine;

			// Token: 0x0400A062 RID: 41058
			[Token(Token = "0x400A062")]
			[FieldOffset(Offset = "0x10")]
			private bool[] _unusedBadPrefixLines;

			// Token: 0x0400A063 RID: 41059
			[Token(Token = "0x400A063")]
			[FieldOffset(Offset = "0x14")]
			private int _unusedYoyoLogo;

			// Token: 0x0400A064 RID: 41060
			[Token(Token = "0x400A064")]
			[FieldOffset(Offset = "0x18")]
			private int _unusedResearchLine;

			// Token: 0x0400A065 RID: 41061
			[Token(Token = "0x400A065")]
			[FieldOffset(Offset = "0x1C")]
			private int _unusedSetBonusLine;

			// Token: 0x0400A066 RID: 41062
			[Token(Token = "0x400A066")]
			[FieldOffset(Offset = "0x20")]
			private int _unusedMaterialsLine;

			// Token: 0x0400A067 RID: 41063
			[Token(Token = "0x400A067")]
			[FieldOffset(Offset = "0x24")]
			private int _unusedShreadLine;

			// Token: 0x0400A068 RID: 41064
			[Token(Token = "0x400A068")]
			[FieldOffset(Offset = "0x28")]
			private Color _unusedSetBonusCol;

			// Token: 0x0400A069 RID: 41065
			[Token(Token = "0x400A069")]
			[FieldOffset(Offset = "0x2C")]
			private string _search;
		}

		// Token: 0x02000CE0 RID: 3296
		[Token(Token = "0x2000CE0")]
		public class BuildingBlock : FileAPI, GUIControllerItem
		{
			// Token: 0x060061DC RID: 25052 RVA: 0x0002D210 File Offset: 0x0002B410
			[Token(Token = "0x60061DC")]
			[Address(RVA = "0xAE0018", Offset = "0xAE0018", VA = "0xAE0018", Slot = "4")]
			public bool FitsFilter(Item entry)
			{
				return default(bool);
			}

			// Token: 0x060061DD RID: 25053 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061DD")]
			[Address(RVA = "0xAE00DC", Offset = "0xAE00DC", VA = "0xAE00DC", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x060061DE RID: 25054 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061DE")]
			[Address(RVA = "0xAE0124", Offset = "0xAE0124", VA = "0xAE0124", Slot = "6")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x060061DF RID: 25055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061DF")]
			[Address(RVA = "0xAE038C", Offset = "0xAE038C", VA = "0xAE038C", Slot = "7")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x060061E0 RID: 25056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061E0")]
			[Address(RVA = "0xAE0574", Offset = "0xAE0574", VA = "0xAE0574")]
			public BuildingBlock()
			{
			}
		}

		// Token: 0x02000CE1 RID: 3297
		[Token(Token = "0x2000CE1")]
		public class Furniture : FileAPI, GUIControllerItem
		{
			// Token: 0x060061E1 RID: 25057 RVA: 0x0002D228 File Offset: 0x0002B428
			[Token(Token = "0x60061E1")]
			[Address(RVA = "0xAE057C", Offset = "0xAE057C", VA = "0xAE057C", Slot = "4")]
			public bool FitsFilter(Item entry)
			{
				return default(bool);
			}

			// Token: 0x060061E2 RID: 25058 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061E2")]
			[Address(RVA = "0xAE0620", Offset = "0xAE0620", VA = "0xAE0620", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x060061E3 RID: 25059 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061E3")]
			[Address(RVA = "0xAE0668", Offset = "0xAE0668", VA = "0xAE0668", Slot = "6")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x060061E4 RID: 25060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061E4")]
			[Address(RVA = "0xAE08D0", Offset = "0xAE08D0", VA = "0xAE08D0", Slot = "7")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x060061E5 RID: 25061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061E5")]
			[Address(RVA = "0xAE0AB8", Offset = "0xAE0AB8", VA = "0xAE0AB8")]
			public Furniture()
			{
			}
		}

		// Token: 0x02000CE2 RID: 3298
		[Token(Token = "0x2000CE2")]
		public class Tools : FileAPI, GUIControllerItem
		{
			// Token: 0x060061E6 RID: 25062 RVA: 0x0002D240 File Offset: 0x0002B440
			[Token(Token = "0x60061E6")]
			[Address(RVA = "0xAE0AC0", Offset = "0xAE0AC0", VA = "0xAE0AC0", Slot = "4")]
			public bool FitsFilter(Item entry)
			{
				return default(bool);
			}

			// Token: 0x060061E7 RID: 25063 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061E7")]
			[Address(RVA = "0xAE0B78", Offset = "0xAE0B78", VA = "0xAE0B78", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x060061E8 RID: 25064 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061E8")]
			[Address(RVA = "0xAE0BC0", Offset = "0xAE0BC0", VA = "0xAE0BC0", Slot = "6")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x060061E9 RID: 25065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061E9")]
			[Address(RVA = "0xAE0E28", Offset = "0xAE0E28", VA = "0xAE0E28", Slot = "7")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x060061EA RID: 25066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061EA")]
			[Address(RVA = "0xAE1010", Offset = "0xAE1010", VA = "0xAE1010")]
			public Tools()
			{
			}

			// Token: 0x0400A06A RID: 41066
			[Token(Token = "0x400A06A")]
			[FieldOffset(Offset = "0x8")]
			private HashSet<int> _itemIdsThatAreAccepted;
		}

		// Token: 0x02000CE3 RID: 3299
		[Token(Token = "0x2000CE3")]
		public class Weapon : FileAPI, GUIControllerItem
		{
			// Token: 0x060061EB RID: 25067 RVA: 0x0002D258 File Offset: 0x0002B458
			[Token(Token = "0x60061EB")]
			[Address(RVA = "0xAE1910", Offset = "0xAE1910", VA = "0xAE1910", Slot = "4")]
			public bool FitsFilter(Item entry)
			{
				return default(bool);
			}

			// Token: 0x060061EC RID: 25068 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061EC")]
			[Address(RVA = "0xAE1938", Offset = "0xAE1938", VA = "0xAE1938", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x060061ED RID: 25069 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061ED")]
			[Address(RVA = "0xAE1980", Offset = "0xAE1980", VA = "0xAE1980", Slot = "6")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x060061EE RID: 25070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061EE")]
			[Address(RVA = "0xAE1BE8", Offset = "0xAE1BE8", VA = "0xAE1BE8", Slot = "7")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x060061EF RID: 25071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061EF")]
			[Address(RVA = "0xAE1DD0", Offset = "0xAE1DD0", VA = "0xAE1DD0")]
			public Weapon()
			{
			}
		}

		// Token: 0x02000CE4 RID: 3300
		[Token(Token = "0x2000CE4")]
		public abstract class AArmor
		{
			// Token: 0x060061F0 RID: 25072 RVA: 0x0002D270 File Offset: 0x0002B470
			[Token(Token = "0x60061F0")]
			[Address(RVA = "0xAE1DD8", Offset = "0xAE1DD8", VA = "0xAE1DD8")]
			public bool IsAnArmorThatMatchesSocialState(Item entry, bool shouldBeSocial)
			{
				return default(bool);
			}

			// Token: 0x060061F1 RID: 25073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061F1")]
			[Address(RVA = "0xAE1E2C", Offset = "0xAE1E2C", VA = "0xAE1E2C")]
			protected AArmor()
			{
			}
		}

		// Token: 0x02000CE5 RID: 3301
		[Token(Token = "0x2000CE5")]
		public class Armor : ItemFilters.AArmor, FileAPI, GUIControllerItem
		{
			// Token: 0x060061F2 RID: 25074 RVA: 0x0002D288 File Offset: 0x0002B488
			[Token(Token = "0x60061F2")]
			[Address(RVA = "0xAE1E34", Offset = "0xAE1E34", VA = "0xAE1E34", Slot = "4")]
			public bool FitsFilter(Item entry)
			{
				return default(bool);
			}

			// Token: 0x060061F3 RID: 25075 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061F3")]
			[Address(RVA = "0xAE1E80", Offset = "0xAE1E80", VA = "0xAE1E80", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x060061F4 RID: 25076 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061F4")]
			[Address(RVA = "0xAE1EC8", Offset = "0xAE1EC8", VA = "0xAE1EC8", Slot = "6")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x060061F5 RID: 25077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061F5")]
			[Address(RVA = "0xAE2130", Offset = "0xAE2130", VA = "0xAE2130", Slot = "7")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x060061F6 RID: 25078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061F6")]
			[Address(RVA = "0xAE2318", Offset = "0xAE2318", VA = "0xAE2318")]
			public Armor()
			{
			}
		}

		// Token: 0x02000CE6 RID: 3302
		[Token(Token = "0x2000CE6")]
		public class Vanity : ItemFilters.AArmor, FileAPI, GUIControllerItem
		{
			// Token: 0x060061F7 RID: 25079 RVA: 0x0002D2A0 File Offset: 0x0002B4A0
			[Token(Token = "0x60061F7")]
			[Address(RVA = "0xAE2320", Offset = "0xAE2320", VA = "0xAE2320", Slot = "4")]
			public bool FitsFilter(Item entry)
			{
				return default(bool);
			}

			// Token: 0x060061F8 RID: 25080 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061F8")]
			[Address(RVA = "0xAE2370", Offset = "0xAE2370", VA = "0xAE2370", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x060061F9 RID: 25081 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061F9")]
			[Address(RVA = "0xAE23B8", Offset = "0xAE23B8", VA = "0xAE23B8", Slot = "6")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x060061FA RID: 25082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061FA")]
			[Address(RVA = "0xAE2620", Offset = "0xAE2620", VA = "0xAE2620", Slot = "7")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x060061FB RID: 25083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061FB")]
			[Address(RVA = "0xAE2808", Offset = "0xAE2808", VA = "0xAE2808")]
			public Vanity()
			{
			}
		}

		// Token: 0x02000CE7 RID: 3303
		[Token(Token = "0x2000CE7")]
		public abstract class AAccessories
		{
			// Token: 0x060061FC RID: 25084 RVA: 0x0002D2B8 File Offset: 0x0002B4B8
			[Token(Token = "0x60061FC")]
			[Address(RVA = "0xAE2810", Offset = "0xAE2810", VA = "0xAE2810")]
			public bool IsAnAccessoryOfType(Item entry, ItemFilters.AAccessories.AccessoriesCategory categoryType)
			{
				return default(bool);
			}

			// Token: 0x060061FD RID: 25085 RVA: 0x0002D2D0 File Offset: 0x0002B4D0
			[Token(Token = "0x60061FD")]
			[Address(RVA = "0xAE286C", Offset = "0xAE286C", VA = "0xAE286C")]
			public static bool IsMiscEquipment(Item item)
			{
				return default(bool);
			}

			// Token: 0x060061FE RID: 25086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061FE")]
			[Address(RVA = "0xAE29B8", Offset = "0xAE29B8", VA = "0xAE29B8")]
			protected AAccessories()
			{
			}

			// Token: 0x02000CE8 RID: 3304
			[Token(Token = "0x2000CE8")]
			public enum AccessoriesCategory
			{
				// Token: 0x0400A06C RID: 41068
				[Token(Token = "0x400A06C")]
				Misc,
				// Token: 0x0400A06D RID: 41069
				[Token(Token = "0x400A06D")]
				NonMisc
			}
		}

		// Token: 0x02000CE9 RID: 3305
		[Token(Token = "0x2000CE9")]
		public class Accessories : ItemFilters.AAccessories, FileAPI, GUIControllerItem
		{
			// Token: 0x060061FF RID: 25087 RVA: 0x0002D2E8 File Offset: 0x0002B4E8
			[Token(Token = "0x60061FF")]
			[Address(RVA = "0xAE29C0", Offset = "0xAE29C0", VA = "0xAE29C0", Slot = "4")]
			public bool FitsFilter(Item entry)
			{
				return default(bool);
			}

			// Token: 0x06006200 RID: 25088 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006200")]
			[Address(RVA = "0xAE2A00", Offset = "0xAE2A00", VA = "0xAE2A00", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06006201 RID: 25089 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006201")]
			[Address(RVA = "0xAE2A48", Offset = "0xAE2A48", VA = "0xAE2A48", Slot = "6")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x06006202 RID: 25090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006202")]
			[Address(RVA = "0xAE2CB4", Offset = "0xAE2CB4", VA = "0xAE2CB4", Slot = "7")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x06006203 RID: 25091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006203")]
			[Address(RVA = "0xAE2E9C", Offset = "0xAE2E9C", VA = "0xAE2E9C")]
			public Accessories()
			{
			}
		}

		// Token: 0x02000CEA RID: 3306
		[Token(Token = "0x2000CEA")]
		public class MiscAccessories : ItemFilters.AAccessories, FileAPI, GUIControllerItem
		{
			// Token: 0x06006204 RID: 25092 RVA: 0x0002D300 File Offset: 0x0002B500
			[Token(Token = "0x6006204")]
			[Address(RVA = "0xAE2EA4", Offset = "0xAE2EA4", VA = "0xAE2EA4", Slot = "4")]
			public bool FitsFilter(Item entry)
			{
				return default(bool);
			}

			// Token: 0x06006205 RID: 25093 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006205")]
			[Address(RVA = "0xAE2EAC", Offset = "0xAE2EAC", VA = "0xAE2EAC", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06006206 RID: 25094 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006206")]
			[Address(RVA = "0xAE2EF4", Offset = "0xAE2EF4", VA = "0xAE2EF4", Slot = "6")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x06006207 RID: 25095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006207")]
			[Address(RVA = "0xAE315C", Offset = "0xAE315C", VA = "0xAE315C", Slot = "7")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x06006208 RID: 25096 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006208")]
			[Address(RVA = "0xAE3344", Offset = "0xAE3344", VA = "0xAE3344")]
			public MiscAccessories()
			{
			}
		}

		// Token: 0x02000CEB RID: 3307
		[Token(Token = "0x2000CEB")]
		public class Consumables : FileAPI, GUIControllerItem
		{
			// Token: 0x06006209 RID: 25097 RVA: 0x0002D318 File Offset: 0x0002B518
			[Token(Token = "0x6006209")]
			[Address(RVA = "0xAE334C", Offset = "0xAE334C", VA = "0xAE334C", Slot = "4")]
			public bool FitsFilter(Item entry)
			{
				return default(bool);
			}

			// Token: 0x0600620A RID: 25098 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600620A")]
			[Address(RVA = "0xAE33C8", Offset = "0xAE33C8", VA = "0xAE33C8", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x0600620B RID: 25099 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600620B")]
			[Address(RVA = "0xAE3410", Offset = "0xAE3410", VA = "0xAE3410", Slot = "6")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x0600620C RID: 25100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600620C")]
			[Address(RVA = "0xAE3678", Offset = "0xAE3678", VA = "0xAE3678", Slot = "7")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x0600620D RID: 25101 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600620D")]
			[Address(RVA = "0xAE3860", Offset = "0xAE3860", VA = "0xAE3860")]
			public Consumables()
			{
			}
		}

		// Token: 0x02000CEC RID: 3308
		[Token(Token = "0x2000CEC")]
		public class GameplayItems : FileAPI, GUIControllerItem
		{
			// Token: 0x0600620E RID: 25102 RVA: 0x0002D330 File Offset: 0x0002B530
			[Token(Token = "0x600620E")]
			[Address(RVA = "0xAE3868", Offset = "0xAE3868", VA = "0xAE3868", Slot = "4")]
			public bool FitsFilter(Item entry)
			{
				return default(bool);
			}

			// Token: 0x0600620F RID: 25103 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600620F")]
			[Address(RVA = "0xAE3900", Offset = "0xAE3900", VA = "0xAE3900", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06006210 RID: 25104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006210")]
			[Address(RVA = "0xAE3948", Offset = "0xAE3948", VA = "0xAE3948", Slot = "6")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x06006211 RID: 25105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006211")]
			[Address(RVA = "0xAE3BB0", Offset = "0xAE3BB0", VA = "0xAE3BB0", Slot = "7")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x06006212 RID: 25106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006212")]
			[Address(RVA = "0xAE3D98", Offset = "0xAE3D98", VA = "0xAE3D98")]
			public GameplayItems()
			{
			}
		}

		// Token: 0x02000CED RID: 3309
		[Token(Token = "0x2000CED")]
		public class MiscFallback : FileAPI, GUIControllerItem
		{
			// Token: 0x06006213 RID: 25107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006213")]
			[Address(RVA = "0xAE3DA0", Offset = "0xAE3DA0", VA = "0xAE3DA0")]
			public MiscFallback(List<IItemEntryFilter> otherFiltersToCheckAgainst)
			{
			}

			// Token: 0x06006214 RID: 25108 RVA: 0x0002D348 File Offset: 0x0002B548
			[Token(Token = "0x6006214")]
			[Address(RVA = "0xAE3E0C", Offset = "0xAE3E0C", VA = "0xAE3E0C", Slot = "4")]
			public bool FitsFilter(Item entry)
			{
				return default(bool);
			}

			// Token: 0x06006215 RID: 25109 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006215")]
			[Address(RVA = "0xAE403C", Offset = "0xAE403C", VA = "0xAE403C", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06006216 RID: 25110 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006216")]
			[Address(RVA = "0xAE4084", Offset = "0xAE4084", VA = "0xAE4084", Slot = "6")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x06006217 RID: 25111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006217")]
			[Address(RVA = "0xAE42EC", Offset = "0xAE42EC", VA = "0xAE42EC", Slot = "7")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x0400A06E RID: 41070
			[Token(Token = "0x400A06E")]
			[FieldOffset(Offset = "0x8")]
			private readonly List<IItemEntryFilter> otherFiltersToCheckAgainst;

			// Token: 0x0400A06F RID: 41071
			[Token(Token = "0x400A06F")]
			[FieldOffset(Offset = "0xC")]
			private bool?[] _fitsFilterByItemType;

			// Token: 0x02000CEE RID: 3310
			[Token(Token = "0x2000CEE")]
			private sealed class <>c__DisplayClass3_0
			{
				// Token: 0x06006218 RID: 25112 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006218")]
				[Address(RVA = "0xAE4034", Offset = "0xAE4034", VA = "0xAE4034")]
				public <>c__DisplayClass3_0()
				{
				}

				// Token: 0x06006219 RID: 25113 RVA: 0x0002D360 File Offset: 0x0002B560
				[Token(Token = "0x6006219")]
				[Address(RVA = "0xAE44D4", Offset = "0xAE44D4", VA = "0xAE44D4")]
				internal bool <FitsFilter>b__0(IItemEntryFilter f)
				{
					return default(bool);
				}

				// Token: 0x0400A070 RID: 41072
				[Token(Token = "0x400A070")]
				[FieldOffset(Offset = "0x8")]
				public Item entry;
			}
		}

		// Token: 0x02000CEF RID: 3311
		[Token(Token = "0x2000CEF")]
		public class Materials : FileAPI, GUIControllerItem
		{
			// Token: 0x0600621A RID: 25114 RVA: 0x0002D378 File Offset: 0x0002B578
			[Token(Token = "0x600621A")]
			[Address(RVA = "0xAE4594", Offset = "0xAE4594", VA = "0xAE4594", Slot = "4")]
			public bool FitsFilter(Item entry)
			{
				return default(bool);
			}

			// Token: 0x0600621B RID: 25115 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600621B")]
			[Address(RVA = "0xAE45B8", Offset = "0xAE45B8", VA = "0xAE45B8", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x0600621C RID: 25116 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600621C")]
			[Address(RVA = "0xAE4600", Offset = "0xAE4600", VA = "0xAE4600", Slot = "6")]
			public UIElement GetImage()
			{
				return null;
			}

			// Token: 0x0600621D RID: 25117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600621D")]
			[Address(RVA = "0xAE4868", Offset = "0xAE4868", VA = "0xAE4868", Slot = "7")]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
			}

			// Token: 0x0600621E RID: 25118 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600621E")]
			[Address(RVA = "0xAE4A50", Offset = "0xAE4A50", VA = "0xAE4A50")]
			public Materials()
			{
			}
		}
	}
}
