using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C22 RID: 3106
	[Token(Token = "0x2000C22")]
	public class SearchAliasInfoElement : FileAPI, GUIControllerItem
	{
		// Token: 0x06005D02 RID: 23810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D02")]
		[Address(RVA = "0x9AA9A4", Offset = "0x9AA9A4", VA = "0x9AA9A4")]
		public SearchAliasInfoElement(string alias)
		{
		}

		// Token: 0x06005D03 RID: 23811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D03")]
		[Address(RVA = "0x9AA9C0", Offset = "0x9AA9C0", VA = "0x9AA9C0", Slot = "5")]
		public string GetSearchString(ref BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x06005D04 RID: 23812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D04")]
		[Address(RVA = "0x9AA9D4", Offset = "0x9AA9D4", VA = "0x9AA9D4", Slot = "4")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x04009D46 RID: 40262
		[Token(Token = "0x4009D46")]
		[FieldOffset(Offset = "0x8")]
		private readonly string _alias;
	}
}
