using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C00 RID: 3072
	[Token(Token = "0x2000C00")]
	public class CritterUICollectionInfoProvider : FileAPI
	{
		// Token: 0x06005C76 RID: 23670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C76")]
		[Address(RVA = "0x99FB6C", Offset = "0x99FB6C", VA = "0x99FB6C")]
		public CritterUICollectionInfoProvider(string persistentId)
		{
		}

		// Token: 0x06005C77 RID: 23671 RVA: 0x0002B518 File Offset: 0x00029718
		[Token(Token = "0x6005C77")]
		[Address(RVA = "0x9A197C", Offset = "0x9A197C", VA = "0x9A197C", Slot = "4")]
		public BestiaryUICollectionInfo GetEntryUICollectionInfo()
		{
			return default(BestiaryUICollectionInfo);
		}

		// Token: 0x06005C78 RID: 23672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C78")]
		[Address(RVA = "0x9A1A90", Offset = "0x9A1A90", VA = "0x9A1A90")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x04009D0B RID: 40203
		[Token(Token = "0x4009D0B")]
		[FieldOffset(Offset = "0x8")]
		private string _persistentIdentifierToCheck;
	}
}
