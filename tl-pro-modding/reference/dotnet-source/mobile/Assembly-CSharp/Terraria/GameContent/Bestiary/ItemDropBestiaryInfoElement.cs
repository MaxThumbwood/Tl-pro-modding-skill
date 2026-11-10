using System;
using Il2CppDummyDll;
using Terraria.GameContent.ItemDropRules;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C12 RID: 3090
	[Token(Token = "0x2000C12")]
	public class ItemDropBestiaryInfoElement : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x06005CC7 RID: 23751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC7")]
		[Address(RVA = "0x9A4304", Offset = "0x9A4304", VA = "0x9A4304")]
		public ItemDropBestiaryInfoElement(DropRateInfo info)
		{
		}

		// Token: 0x06005CC8 RID: 23752 RVA: 0x0002B788 File Offset: 0x00029988
		[Token(Token = "0x6005CC8")]
		[Address(RVA = "0x9A4340", Offset = "0x9A4340", VA = "0x9A4340")]
		public bool ShouldShowItem()
		{
			return default(bool);
		}

		// Token: 0x06005CC9 RID: 23753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC9")]
		[Address(RVA = "0x9A44AC", Offset = "0x9A44AC", VA = "0x9A44AC", Slot = "6")]
		public virtual UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x06005CCA RID: 23754 RVA: 0x0002B7A0 File Offset: 0x000299A0
		[Token(Token = "0x6005CCA")]
		[Address(RVA = "0x9A4348", Offset = "0x9A4348", VA = "0x9A4348")]
		private static bool ShouldShowItem(ref DropRateInfo dropRateInfo)
		{
			return default(bool);
		}

		// Token: 0x06005CCB RID: 23755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CCB")]
		[Address(RVA = "0x9A457C", Offset = "0x9A457C", VA = "0x9A457C", Slot = "5")]
		public string GetSearchString(ref BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x04009D2A RID: 40234
		[Token(Token = "0x4009D2A")]
		[FieldOffset(Offset = "0x8")]
		public DropRateInfo _droprateInfo;
	}
}
