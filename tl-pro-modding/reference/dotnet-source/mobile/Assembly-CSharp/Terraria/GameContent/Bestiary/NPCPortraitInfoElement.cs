using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C1B RID: 3099
	[Token(Token = "0x2000C1B")]
	public class NPCPortraitInfoElement : FileAPI
	{
		// Token: 0x06005CE3 RID: 23779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE3")]
		[Address(RVA = "0x99E7A0", Offset = "0x99E7A0", VA = "0x99E7A0")]
		public NPCPortraitInfoElement([Optional] int? rarityStars)
		{
		}

		// Token: 0x06005CE4 RID: 23780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CE4")]
		[Address(RVA = "0x9A5B44", Offset = "0x9A5B44", VA = "0x9A5B44", Slot = "4")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x06005CE5 RID: 23781 RVA: 0x0002B7E8 File Offset: 0x000299E8
		[Token(Token = "0x6005CE5")]
		[Address(RVA = "0x9A7298", Offset = "0x9A7298", VA = "0x9A7298")]
		public int GetStarCount()
		{
			return 0;
		}

		// Token: 0x06005CE6 RID: 23782 RVA: 0x0002B800 File Offset: 0x00029A00
		[Token(Token = "0x6005CE6")]
		[Address(RVA = "0x9A7310", Offset = "0x9A7310", VA = "0x9A7310")]
		private float GetSortingValueForElement(IBestiaryInfoElement element)
		{
			return 0f;
		}

		// Token: 0x06005CE7 RID: 23783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CE7")]
		[Address(RVA = "0x9A6C48", Offset = "0x9A6C48", VA = "0x9A6C48")]
		private UIElement CreateStarsContainer()
		{
			return null;
		}

		// Token: 0x04009D37 RID: 40247
		[Token(Token = "0x4009D37")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int? _filledStarsCount;

		// Token: 0x02000C1C RID: 3100
		[Token(Token = "0x2000C1C")]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06005CE8 RID: 23784 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005CE8")]
			[Address(RVA = "0x9A6C40", Offset = "0x9A6C40", VA = "0x9A6C40")]
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x06005CE9 RID: 23785 RVA: 0x0002B818 File Offset: 0x00029A18
			[Token(Token = "0x6005CE9")]
			[Address(RVA = "0x9A73D8", Offset = "0x9A73D8", VA = "0x9A73D8")]
			internal bool <ProvideUIElement>b__0(IBestiaryBackgroundImagePathAndColorProvider provider)
			{
				return default(bool);
			}

			// Token: 0x04009D38 RID: 40248
			[Token(Token = "0x4009D38")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public IEnumerable<IPreferenceProviderElement> preferences;
		}

		// Token: 0x02000C1D RID: 3101
		[Token(Token = "0x2000C1D")]
		private sealed class <>c__DisplayClass2_1
		{
			// Token: 0x06005CEA RID: 23786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005CEA")]
			[Address(RVA = "0x9A74F4", Offset = "0x9A74F4", VA = "0x9A74F4")]
			public <>c__DisplayClass2_1()
			{
			}

			// Token: 0x06005CEB RID: 23787 RVA: 0x0002B830 File Offset: 0x00029A30
			[Token(Token = "0x6005CEB")]
			[Address(RVA = "0x9A74FC", Offset = "0x9A74FC", VA = "0x9A74FC")]
			internal bool <ProvideUIElement>b__2(IPreferenceProviderElement preference)
			{
				return default(bool);
			}

			// Token: 0x04009D39 RID: 40249
			[Token(Token = "0x4009D39")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public IBestiaryBackgroundImagePathAndColorProvider provider;
		}

		// Token: 0x02000C1E RID: 3102
		[Token(Token = "0x2000C1E")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005CED RID: 23789 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005CED")]
			[Address(RVA = "0x9A7630", Offset = "0x9A7630", VA = "0x9A7630")]
			public <>c()
			{
			}

			// Token: 0x06005CEE RID: 23790 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005CEE")]
			[Address(RVA = "0x9A7638", Offset = "0x9A7638", VA = "0x9A7638")]
			internal IBestiaryBackgroundOverlayAndColorProvider <ProvideUIElement>b__2_1(IBestiaryInfoElement x)
			{
				return null;
			}

			// Token: 0x04009D3A RID: 40250
			[Token(Token = "0x4009D3A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly NPCPortraitInfoElement.<>c <>9;

			// Token: 0x04009D3B RID: 40251
			[Token(Token = "0x4009D3B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<IBestiaryInfoElement, IBestiaryBackgroundOverlayAndColorProvider> <>9__2_1;
		}
	}
}
