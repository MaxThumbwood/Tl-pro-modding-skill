using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C13 RID: 3091
	[Token(Token = "0x2000C13")]
	public class ItemFromCatchingNPCBestiaryInfoElement : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x06005CCC RID: 23756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CCC")]
		[Address(RVA = "0x9A4668", Offset = "0x9A4668", VA = "0x9A4668")]
		public ItemFromCatchingNPCBestiaryInfoElement(int itemId)
		{
		}

		// Token: 0x06005CCD RID: 23757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CCD")]
		[Address(RVA = "0x9A4684", Offset = "0x9A4684", VA = "0x9A4684", Slot = "4")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x06005CCE RID: 23758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CCE")]
		[Address(RVA = "0x9A4764", Offset = "0x9A4764", VA = "0x9A4764", Slot = "5")]
		public string GetSearchString(ref BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x04009D2B RID: 40235
		[Token(Token = "0x4009D2B")]
		[FieldOffset(Offset = "0x8")]
		private int _itemType;
	}
}
