using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C01 RID: 3073
	[Token(Token = "0x2000C01")]
	public class TownNPCUICollectionInfoProvider : FileAPI
	{
		// Token: 0x06005C79 RID: 23673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C79")]
		[Address(RVA = "0x99F380", Offset = "0x99F380", VA = "0x99F380")]
		public TownNPCUICollectionInfoProvider(string persistentId)
		{
		}

		// Token: 0x06005C7A RID: 23674 RVA: 0x0002B530 File Offset: 0x00029730
		[Token(Token = "0x6005C7A")]
		[Address(RVA = "0x9A1A98", Offset = "0x9A1A98", VA = "0x9A1A98", Slot = "4")]
		public BestiaryUICollectionInfo GetEntryUICollectionInfo()
		{
			return default(BestiaryUICollectionInfo);
		}

		// Token: 0x06005C7B RID: 23675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C7B")]
		[Address(RVA = "0x9A1BAC", Offset = "0x9A1BAC", VA = "0x9A1BAC")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x04009D0C RID: 40204
		[Token(Token = "0x4009D0C")]
		[FieldOffset(Offset = "0x8")]
		private string _persistentIdentifierToCheck;
	}
}
