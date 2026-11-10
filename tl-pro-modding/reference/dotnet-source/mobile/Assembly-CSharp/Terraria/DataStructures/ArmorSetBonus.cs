using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.Localization;

namespace Terraria.DataStructures
{
	// Token: 0x02000742 RID: 1858
	[Token(Token = "0x2000742")]
	public class ArmorSetBonus
	{
		// Token: 0x06004273 RID: 17011 RVA: 0x00020358 File Offset: 0x0001E558
		[Token(Token = "0x6004273")]
		[Address(RVA = "0x4F6538", Offset = "0x4F6538", VA = "0x4F6538")]
		public int GetPart(ArmorSetBonus.PartType part)
		{
			return 0;
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x00020370 File Offset: 0x0001E570
		[Token(Token = "0x6004274")]
		[Address(RVA = "0x4F4EE0", Offset = "0x4F4EE0", VA = "0x4F4EE0")]
		public ArmorSetBonus.QueryResult QueryCount(ArmorSetBonus.QueryContext context)
		{
			return default(ArmorSetBonus.QueryResult);
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004275")]
		[Address(RVA = "0x4F6574", Offset = "0x4F6574", VA = "0x4F6574")]
		private void TryCounting(int testedItem, int neededItem, ref int foundItemCount, ref int neededItemCount)
		{
		}

		// Token: 0x06004276 RID: 17014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004276")]
		[Address(RVA = "0x4F65A0", Offset = "0x4F65A0", VA = "0x4F65A0")]
		public string GetTooltipForSinglePiece(int itemType)
		{
			return null;
		}

		// Token: 0x06004277 RID: 17015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004277")]
		[Address(RVA = "0x4F6728", Offset = "0x4F6728", VA = "0x4F6728")]
		public string GetTooltipForWornArmor(ArmorSetBonus.QueryContext context, ArmorSetBonus.QueryResult result)
		{
			return null;
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004278")]
		[Address(RVA = "0x4F4F74", Offset = "0x4F4F74", VA = "0x4F4F74")]
		public static ArmorSetBonus.Builder Create(ArmorSetBonus.ArmorSetEffect effect, string textKey, ArmorSetBonus.PartType primaryPart = ArmorSetBonus.PartType.None)
		{
			return null;
		}

		// Token: 0x06004279 RID: 17017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004279")]
		[Address(RVA = "0x4F69B8", Offset = "0x4F69B8", VA = "0x4F69B8")]
		public ArmorSetBonus()
		{
		}

		// Token: 0x040089F5 RID: 35317
		[Token(Token = "0x40089F5")]
		[FieldOffset(Offset = "0x8")]
		public ArmorSetBonus.ArmorSetEffect Effect;

		// Token: 0x040089F6 RID: 35318
		[Token(Token = "0x40089F6")]
		[FieldOffset(Offset = "0xC")]
		public LocalizedText Description;

		// Token: 0x040089F7 RID: 35319
		[Token(Token = "0x40089F7")]
		[FieldOffset(Offset = "0x10")]
		public int Head;

		// Token: 0x040089F8 RID: 35320
		[Token(Token = "0x40089F8")]
		[FieldOffset(Offset = "0x14")]
		public int Body;

		// Token: 0x040089F9 RID: 35321
		[Token(Token = "0x40089F9")]
		[FieldOffset(Offset = "0x18")]
		public int Legs;

		// Token: 0x040089FA RID: 35322
		[Token(Token = "0x40089FA")]
		[FieldOffset(Offset = "0x1C")]
		public ArmorSetBonus.PartType PrimaryPart;

		// Token: 0x040089FB RID: 35323
		[Token(Token = "0x40089FB")]
		[FieldOffset(Offset = "0x0")]
		private static LocalizedText ItemSetBonusEquipped;

		// Token: 0x040089FC RID: 35324
		[Token(Token = "0x40089FC")]
		[FieldOffset(Offset = "0x4")]
		private static LocalizedText ItemSetBonusGeneral;

		// Token: 0x040089FD RID: 35325
		[Token(Token = "0x40089FD")]
		[FieldOffset(Offset = "0x8")]
		private static LocalizedText[] ItemSetBonusDecidedBy;

		// Token: 0x02000743 RID: 1859
		// (Invoke) Token: 0x0600427C RID: 17020
		[Token(Token = "0x2000743")]
		public delegate void ArmorSetEffect(Player player);

		// Token: 0x02000744 RID: 1860
		[Token(Token = "0x2000744")]
		public enum PartType
		{
			// Token: 0x040089FF RID: 35327
			[Token(Token = "0x40089FF")]
			None,
			// Token: 0x04008A00 RID: 35328
			[Token(Token = "0x4008A00")]
			Head,
			// Token: 0x04008A01 RID: 35329
			[Token(Token = "0x4008A01")]
			Body,
			// Token: 0x04008A02 RID: 35330
			[Token(Token = "0x4008A02")]
			Legs
		}

		// Token: 0x02000745 RID: 1861
		[Token(Token = "0x2000745")]
		public struct QueryContext
		{
			// Token: 0x0600427F RID: 17023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600427F")]
			[Address(RVA = "0x4F6C6C", Offset = "0x4F6C6C", VA = "0x4F6C6C")]
			public QueryContext(Player player)
			{
			}

			// Token: 0x06004280 RID: 17024 RVA: 0x00020388 File Offset: 0x0001E588
			[Token(Token = "0x6004280")]
			[Address(RVA = "0x4F6D00", Offset = "0x4F6D00", VA = "0x4F6D00")]
			private static int TryGetType(Item item)
			{
				return 0;
			}

			// Token: 0x06004281 RID: 17025 RVA: 0x000203A0 File Offset: 0x0001E5A0
			[Token(Token = "0x6004281")]
			[Address(RVA = "0x4F68CC", Offset = "0x4F68CC", VA = "0x4F68CC")]
			public int GetPart(ArmorSetBonus.PartType part)
			{
				return 0;
			}

			// Token: 0x04008A03 RID: 35331
			[Token(Token = "0x4008A03")]
			[FieldOffset(Offset = "0x0")]
			public int HeadItem;

			// Token: 0x04008A04 RID: 35332
			[Token(Token = "0x4008A04")]
			[FieldOffset(Offset = "0x4")]
			public int BodyItem;

			// Token: 0x04008A05 RID: 35333
			[Token(Token = "0x4008A05")]
			[FieldOffset(Offset = "0x8")]
			public int LegItem;
		}

		// Token: 0x02000746 RID: 1862
		[Token(Token = "0x2000746")]
		public struct QueryResult
		{
			// Token: 0x17000817 RID: 2071
			// (get) Token: 0x06004282 RID: 17026 RVA: 0x000203B8 File Offset: 0x0001E5B8
			[Token(Token = "0x17000817")]
			public bool Complete
			{
				[Token(Token = "0x6004282")]
				[Address(RVA = "0x4F4F5C", Offset = "0x4F4F5C", VA = "0x4F4F5C")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04008A06 RID: 35334
			[Token(Token = "0x4008A06")]
			[FieldOffset(Offset = "0x0")]
			public int ItemsNeeded;

			// Token: 0x04008A07 RID: 35335
			[Token(Token = "0x4008A07")]
			[FieldOffset(Offset = "0x4")]
			public int ItemsFound;
		}

		// Token: 0x02000747 RID: 1863
		[Token(Token = "0x2000747")]
		private class SetBonusDisplayStringSubstitutes
		{
			// Token: 0x17000818 RID: 2072
			// (get) Token: 0x06004283 RID: 17027 RVA: 0x000203D0 File Offset: 0x0001E5D0
			// (set) Token: 0x06004284 RID: 17028 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000818")]
			public int Numerator
			{
				[Token(Token = "0x6004283")]
				[Address(RVA = "0x4F6D10", Offset = "0x4F6D10", VA = "0x4F6D10")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6004284")]
				[Address(RVA = "0x4F6D18", Offset = "0x4F6D18", VA = "0x4F6D18")]
				set
				{
				}
			}

			// Token: 0x17000819 RID: 2073
			// (get) Token: 0x06004285 RID: 17029 RVA: 0x000203E8 File Offset: 0x0001E5E8
			// (set) Token: 0x06004286 RID: 17030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000819")]
			public int Denominator
			{
				[Token(Token = "0x6004285")]
				[Address(RVA = "0x4F6D20", Offset = "0x4F6D20", VA = "0x4F6D20")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6004286")]
				[Address(RVA = "0x4F6D28", Offset = "0x4F6D28", VA = "0x4F6D28")]
				set
				{
				}
			}

			// Token: 0x1700081A RID: 2074
			// (get) Token: 0x06004287 RID: 17031 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06004288 RID: 17032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700081A")]
			public LocalizedText Description
			{
				[Token(Token = "0x6004287")]
				[Address(RVA = "0x4F6D30", Offset = "0x4F6D30", VA = "0x4F6D30")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004288")]
				[Address(RVA = "0x4F6D38", Offset = "0x4F6D38", VA = "0x4F6D38")]
				set
				{
				}
			}

			// Token: 0x06004289 RID: 17033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004289")]
			[Address(RVA = "0x4F6720", Offset = "0x4F6720", VA = "0x4F6720")]
			public SetBonusDisplayStringSubstitutes()
			{
			}

			// Token: 0x04008A08 RID: 35336
			[Token(Token = "0x4008A08")]
			[FieldOffset(Offset = "0x8")]
			private int <Numerator>k__BackingField;

			// Token: 0x04008A09 RID: 35337
			[Token(Token = "0x4008A09")]
			[FieldOffset(Offset = "0xC")]
			private int <Denominator>k__BackingField;

			// Token: 0x04008A0A RID: 35338
			[Token(Token = "0x4008A0A")]
			[FieldOffset(Offset = "0x10")]
			private LocalizedText <Description>k__BackingField;
		}

		// Token: 0x02000748 RID: 1864
		[Token(Token = "0x2000748")]
		public class Builder
		{
			// Token: 0x0600428A RID: 17034 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600428A")]
			[Address(RVA = "0x4F6908", Offset = "0x4F6908", VA = "0x4F6908")]
			public Builder(ArmorSetBonus.ArmorSetEffect effect, string textKey, ArmorSetBonus.PartType primaryPart)
			{
			}

			// Token: 0x0600428B RID: 17035 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600428B")]
			[Address(RVA = "0x4F31AC", Offset = "0x4F31AC", VA = "0x4F31AC")]
			public ArmorSetBonus.Builder Set(int head, int body, int legs)
			{
				return null;
			}

			// Token: 0x0600428C RID: 17036 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600428C")]
			[Address(RVA = "0x4F393C", Offset = "0x4F393C", VA = "0x4F393C")]
			public ArmorSetBonus.Builder Set(int[] headOptions, int[] bodyOptions, int[] legsOptions)
			{
				return null;
			}

			// Token: 0x0600428D RID: 17037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600428D")]
			[Address(RVA = "0x4F3294", Offset = "0x4F3294", VA = "0x4F3294")]
			public void Add()
			{
			}

			// Token: 0x04008A0B RID: 35339
			[Token(Token = "0x4008A0B")]
			[FieldOffset(Offset = "0x8")]
			private ArmorSetBonus.ArmorSetEffect Effect;

			// Token: 0x04008A0C RID: 35340
			[Token(Token = "0x4008A0C")]
			[FieldOffset(Offset = "0xC")]
			private string TextKey;

			// Token: 0x04008A0D RID: 35341
			[Token(Token = "0x4008A0D")]
			[FieldOffset(Offset = "0x10")]
			private ArmorSetBonus.PartType PrimaryPart;

			// Token: 0x04008A0E RID: 35342
			[Token(Token = "0x4008A0E")]
			[FieldOffset(Offset = "0x14")]
			private List<ArmorSetBonus.Builder.Parts> _sets;

			// Token: 0x02000749 RID: 1865
			[Token(Token = "0x2000749")]
			private struct Parts
			{
				// Token: 0x04008A0F RID: 35343
				[Token(Token = "0x4008A0F")]
				[FieldOffset(Offset = "0x0")]
				public int Head;

				// Token: 0x04008A10 RID: 35344
				[Token(Token = "0x4008A10")]
				[FieldOffset(Offset = "0x4")]
				public int Body;

				// Token: 0x04008A11 RID: 35345
				[Token(Token = "0x4008A11")]
				[FieldOffset(Offset = "0x8")]
				public int Legs;
			}
		}
	}
}
