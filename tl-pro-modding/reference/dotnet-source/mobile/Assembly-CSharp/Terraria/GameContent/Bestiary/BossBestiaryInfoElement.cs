using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C07 RID: 3079
	[Token(Token = "0x2000C07")]
	public class BossBestiaryInfoElement : FileAPI, GUIControllerItem
	{
		// Token: 0x06005C93 RID: 23699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C93")]
		[Address(RVA = "0x9A2E60", Offset = "0x9A2E60", VA = "0x9A2E60", Slot = "4")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x06005C94 RID: 23700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C94")]
		[Address(RVA = "0x9A2E68", Offset = "0x9A2E68", VA = "0x9A2E68", Slot = "5")]
		public string GetSearchString(ref BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x06005C95 RID: 23701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C95")]
		[Address(RVA = "0x99E9A0", Offset = "0x99E9A0", VA = "0x99E9A0")]
		public BossBestiaryInfoElement()
		{
		}
	}
}
