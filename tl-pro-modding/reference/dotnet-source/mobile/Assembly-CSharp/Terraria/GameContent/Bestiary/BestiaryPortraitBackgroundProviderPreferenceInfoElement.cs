using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C0B RID: 3083
	[Token(Token = "0x2000C0B")]
	public class BestiaryPortraitBackgroundProviderPreferenceInfoElement : FileAPI, GUIControllerItem
	{
		// Token: 0x06005CA6 RID: 23718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA6")]
		[Address(RVA = "0x9A3AA8", Offset = "0x9A3AA8", VA = "0x9A3AA8")]
		public BestiaryPortraitBackgroundProviderPreferenceInfoElement(IBestiaryBackgroundImagePathAndColorProvider preferredProvider)
		{
		}

		// Token: 0x06005CA7 RID: 23719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CA7")]
		[Address(RVA = "0x9A3AC4", Offset = "0x9A3AC4", VA = "0x9A3AC4", Slot = "6")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x06005CA8 RID: 23720 RVA: 0x0002B698 File Offset: 0x00029898
		[Token(Token = "0x6005CA8")]
		[Address(RVA = "0x9A3ACC", Offset = "0x9A3ACC", VA = "0x9A3ACC", Slot = "5")]
		public bool Matches(IBestiaryBackgroundImagePathAndColorProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06005CA9 RID: 23721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CA9")]
		[Address(RVA = "0x9A3AE0", Offset = "0x9A3AE0", VA = "0x9A3AE0", Slot = "4")]
		public IBestiaryBackgroundImagePathAndColorProvider GetPreferredProvider()
		{
			return null;
		}

		// Token: 0x04009D1D RID: 40221
		[Token(Token = "0x4009D1D")]
		[FieldOffset(Offset = "0x8")]
		private IBestiaryBackgroundImagePathAndColorProvider _preferredProvider;
	}
}
