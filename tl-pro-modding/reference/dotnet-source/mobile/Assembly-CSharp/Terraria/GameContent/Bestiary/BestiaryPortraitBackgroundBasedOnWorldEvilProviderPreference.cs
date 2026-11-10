using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C0C RID: 3084
	[Token(Token = "0x2000C0C")]
	public class BestiaryPortraitBackgroundBasedOnWorldEvilProviderPreferenceInfoElement : FileAPI, GUIControllerItem
	{
		// Token: 0x06005CAA RID: 23722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CAA")]
		[Address(RVA = "0x9A3AE8", Offset = "0x9A3AE8", VA = "0x9A3AE8")]
		public BestiaryPortraitBackgroundBasedOnWorldEvilProviderPreferenceInfoElement(IBestiaryBackgroundImagePathAndColorProvider preferredProviderCorrupt, IBestiaryBackgroundImagePathAndColorProvider preferredProviderCrimson)
		{
		}

		// Token: 0x06005CAB RID: 23723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CAB")]
		[Address(RVA = "0x9A3B0C", Offset = "0x9A3B0C", VA = "0x9A3B0C", Slot = "6")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x06005CAC RID: 23724 RVA: 0x0002B6B0 File Offset: 0x000298B0
		[Token(Token = "0x6005CAC")]
		[Address(RVA = "0x9A3B14", Offset = "0x9A3B14", VA = "0x9A3B14", Slot = "5")]
		public bool Matches(IBestiaryBackgroundImagePathAndColorProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06005CAD RID: 23725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CAD")]
		[Address(RVA = "0x9A3BE8", Offset = "0x9A3BE8", VA = "0x9A3BE8", Slot = "4")]
		public IBestiaryBackgroundImagePathAndColorProvider GetPreferredProvider()
		{
			return null;
		}

		// Token: 0x04009D1E RID: 40222
		[Token(Token = "0x4009D1E")]
		[FieldOffset(Offset = "0x8")]
		private IBestiaryBackgroundImagePathAndColorProvider _preferredProviderCorrupt;

		// Token: 0x04009D1F RID: 40223
		[Token(Token = "0x4009D1F")]
		[FieldOffset(Offset = "0xC")]
		private IBestiaryBackgroundImagePathAndColorProvider _preferredProviderCrimson;
	}
}
