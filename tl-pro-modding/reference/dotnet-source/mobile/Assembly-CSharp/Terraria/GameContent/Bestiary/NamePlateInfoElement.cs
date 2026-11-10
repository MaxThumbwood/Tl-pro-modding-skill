using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C18 RID: 3096
	[Token(Token = "0x2000C18")]
	public class NamePlateInfoElement : FileAPI, GUIControllerItem
	{
		// Token: 0x06005CD9 RID: 23769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD9")]
		[Address(RVA = "0x99E77C", Offset = "0x99E77C", VA = "0x99E77C")]
		public NamePlateInfoElement(string languageKey, int npcNetId)
		{
		}

		// Token: 0x06005CDA RID: 23770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CDA")]
		[Address(RVA = "0x9A56C4", Offset = "0x9A56C4", VA = "0x9A56C4")]
		public string GetName()
		{
			return null;
		}

		// Token: 0x06005CDB RID: 23771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CDB")]
		[Address(RVA = "0x9A5730", Offset = "0x9A5730", VA = "0x9A5730", Slot = "4")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x06005CDC RID: 23772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CDC")]
		[Address(RVA = "0x9A59E8", Offset = "0x9A59E8", VA = "0x9A59E8", Slot = "5")]
		public string GetSearchString(ref BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x04009D34 RID: 40244
		[Token(Token = "0x4009D34")]
		[FieldOffset(Offset = "0x8")]
		private string _key;

		// Token: 0x04009D35 RID: 40245
		[Token(Token = "0x4009D35")]
		[FieldOffset(Offset = "0xC")]
		private int _npcNetId;
	}
}
