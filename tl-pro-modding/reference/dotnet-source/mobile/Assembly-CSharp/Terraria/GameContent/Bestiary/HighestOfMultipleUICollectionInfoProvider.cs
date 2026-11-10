using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C03 RID: 3075
	[Token(Token = "0x2000C03")]
	public class HighestOfMultipleUICollectionInfoProvider : FileAPI
	{
		// Token: 0x06005C82 RID: 23682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C82")]
		[Address(RVA = "0x9A200C", Offset = "0x9A200C", VA = "0x9A200C")]
		public HighestOfMultipleUICollectionInfoProvider(IBestiaryUICollectionInfoProvider[] providers)
		{
		}

		// Token: 0x06005C83 RID: 23683 RVA: 0x0002B5A8 File Offset: 0x000297A8
		[Token(Token = "0x6005C83")]
		[Address(RVA = "0x9A2030", Offset = "0x9A2030", VA = "0x9A2030", Slot = "4")]
		public BestiaryUICollectionInfo GetEntryUICollectionInfo()
		{
			return default(BestiaryUICollectionInfo);
		}

		// Token: 0x06005C84 RID: 23684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C84")]
		[Address(RVA = "0x9A21E8", Offset = "0x9A21E8", VA = "0x9A21E8")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x04009D10 RID: 40208
		[Token(Token = "0x4009D10")]
		[FieldOffset(Offset = "0x8")]
		private IBestiaryUICollectionInfoProvider[] _providers;

		// Token: 0x04009D11 RID: 40209
		[Token(Token = "0x4009D11")]
		[FieldOffset(Offset = "0xC")]
		private int _mainProviderIndex;
	}
}
