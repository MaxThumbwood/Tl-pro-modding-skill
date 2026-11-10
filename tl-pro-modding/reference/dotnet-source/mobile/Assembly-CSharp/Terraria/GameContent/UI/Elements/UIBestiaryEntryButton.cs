using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D5F RID: 3423
	[Token(Token = "0x2000D5F")]
	public class UIBestiaryEntryButton : UIElement
	{
		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x0600657C RID: 25980 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600657D RID: 25981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE4")]
		public BestiaryEntry Entry
		{
			[Token(Token = "0x600657C")]
			[Address(RVA = "0xB4B178", Offset = "0xB4B178", VA = "0xB4B178")]
			get
			{
				return null;
			}
			[Token(Token = "0x600657D")]
			[Address(RVA = "0xB4B180", Offset = "0xB4B180", VA = "0xB4B180")]
			private set
			{
			}
		}

		// Token: 0x0600657E RID: 25982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600657E")]
		[Address(RVA = "0xB4B188", Offset = "0xB4B188", VA = "0xB4B188")]
		public UIBestiaryEntryButton(BestiaryEntry entry, bool isAPrettyPortrait)
		{
		}

		// Token: 0x0600657F RID: 25983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600657F")]
		[Address(RVA = "0xB4BDB8", Offset = "0xB4BDB8", VA = "0xB4BDB8")]
		private Asset<Texture2D> TryGettingBackgroundImageProvider(BestiaryEntry entry)
		{
			return null;
		}

		// Token: 0x06006580 RID: 25984 RVA: 0x0002E218 File Offset: 0x0002C418
		[Token(Token = "0x6006580")]
		[Address(RVA = "0xB4CAE0", Offset = "0xB4CAE0", VA = "0xB4CAE0")]
		private int? TryGettingDisplayIndex(BestiaryEntry entry)
		{
			return null;
		}

		// Token: 0x06006581 RID: 25985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006581")]
		[Address(RVA = "0xB4CD28", Offset = "0xB4CD28", VA = "0xB4CD28", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006582 RID: 25986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006582")]
		[Address(RVA = "0xB4CED8", Offset = "0xB4CED8", VA = "0xB4CED8")]
		private void MouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x06006583 RID: 25987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006583")]
		[Address(RVA = "0xB4CF7C", Offset = "0xB4CF7C", VA = "0xB4CF7C")]
		private void MouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x0400A2DF RID: 41695
		[Token(Token = "0x400A2DF")]
		[FieldOffset(Offset = "0xF4")]
		private BestiaryEntry <Entry>k__BackingField;

		// Token: 0x0400A2E0 RID: 41696
		[Token(Token = "0x400A2E0")]
		[FieldOffset(Offset = "0xF8")]
		private UIImage _bordersGlow;

		// Token: 0x0400A2E1 RID: 41697
		[Token(Token = "0x400A2E1")]
		[FieldOffset(Offset = "0xFC")]
		private UIImage _bordersOverlay;

		// Token: 0x0400A2E2 RID: 41698
		[Token(Token = "0x400A2E2")]
		[FieldOffset(Offset = "0x100")]
		private UIImage _borders;

		// Token: 0x0400A2E3 RID: 41699
		[Token(Token = "0x400A2E3")]
		[FieldOffset(Offset = "0x104")]
		private UIBestiaryEntryIcon _icon;

		// Token: 0x02000D60 RID: 3424
		[Token(Token = "0x2000D60")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06006584 RID: 25988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006584")]
			[Address(RVA = "0xB4CD20", Offset = "0xB4CD20", VA = "0xB4CD20")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x06006585 RID: 25989 RVA: 0x0002E230 File Offset: 0x0002C430
			[Token(Token = "0x6006585")]
			[Address(RVA = "0xB4CFF4", Offset = "0xB4CFF4", VA = "0xB4CFF4")]
			internal bool <TryGettingBackgroundImageProvider>b__2(IBestiaryBackgroundImagePathAndColorProvider provider)
			{
				return default(bool);
			}

			// Token: 0x0400A2E4 RID: 41700
			[Token(Token = "0x400A2E4")]
			[FieldOffset(Offset = "0x8")]
			public IEnumerable<IPreferenceProviderElement> preferences;
		}

		// Token: 0x02000D61 RID: 3425
		[Token(Token = "0x2000D61")]
		private sealed class <>c__DisplayClass9_1
		{
			// Token: 0x06006586 RID: 25990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006586")]
			[Address(RVA = "0xB4D110", Offset = "0xB4D110", VA = "0xB4D110")]
			public <>c__DisplayClass9_1()
			{
			}

			// Token: 0x06006587 RID: 25991 RVA: 0x0002E248 File Offset: 0x0002C448
			[Token(Token = "0x6006587")]
			[Address(RVA = "0xB4D118", Offset = "0xB4D118", VA = "0xB4D118")]
			internal bool <TryGettingBackgroundImageProvider>b__3(IPreferenceProviderElement preference)
			{
				return default(bool);
			}

			// Token: 0x0400A2E5 RID: 41701
			[Token(Token = "0x400A2E5")]
			[FieldOffset(Offset = "0x8")]
			public IBestiaryBackgroundImagePathAndColorProvider provider;
		}

		// Token: 0x02000D62 RID: 3426
		[Token(Token = "0x2000D62")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006589 RID: 25993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006589")]
			[Address(RVA = "0xB4D24C", Offset = "0xB4D24C", VA = "0xB4D24C")]
			public <>c()
			{
			}

			// Token: 0x0600658A RID: 25994 RVA: 0x0002E260 File Offset: 0x0002C460
			[Token(Token = "0x600658A")]
			[Address(RVA = "0xB4D254", Offset = "0xB4D254", VA = "0xB4D254")]
			internal bool <TryGettingBackgroundImageProvider>b__9_0(IBestiaryInfoElement x)
			{
				return default(bool);
			}

			// Token: 0x0600658B RID: 25995 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600658B")]
			[Address(RVA = "0xB4D2B0", Offset = "0xB4D2B0", VA = "0xB4D2B0")]
			internal IBestiaryBackgroundImagePathAndColorProvider <TryGettingBackgroundImageProvider>b__9_1(IBestiaryInfoElement x)
			{
				return null;
			}

			// Token: 0x0600658C RID: 25996 RVA: 0x0002E278 File Offset: 0x0002C478
			[Token(Token = "0x600658C")]
			[Address(RVA = "0xB4D304", Offset = "0xB4D304", VA = "0xB4D304")]
			internal bool <TryGettingDisplayIndex>b__10_0(IBestiaryInfoElement x)
			{
				return default(bool);
			}

			// Token: 0x0400A2E6 RID: 41702
			[Token(Token = "0x400A2E6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIBestiaryEntryButton.<>c <>9;

			// Token: 0x0400A2E7 RID: 41703
			[Token(Token = "0x400A2E7")]
			[FieldOffset(Offset = "0x4")]
			public static Func<IBestiaryInfoElement, bool> <>9__9_0;

			// Token: 0x0400A2E8 RID: 41704
			[Token(Token = "0x400A2E8")]
			[FieldOffset(Offset = "0x8")]
			public static Func<IBestiaryInfoElement, IBestiaryBackgroundImagePathAndColorProvider> <>9__9_1;

			// Token: 0x0400A2E9 RID: 41705
			[Token(Token = "0x400A2E9")]
			[FieldOffset(Offset = "0xC")]
			public static Func<IBestiaryInfoElement, bool> <>9__10_0;
		}
	}
}
