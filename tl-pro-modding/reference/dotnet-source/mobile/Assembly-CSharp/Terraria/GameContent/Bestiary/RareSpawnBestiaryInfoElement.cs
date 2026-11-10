using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C06 RID: 3078
	[Token(Token = "0x2000C06")]
	public class RareSpawnBestiaryInfoElement : FileAPI, GUIControllerItem
	{
		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06005C8E RID: 23694 RVA: 0x0002B650 File Offset: 0x00029850
		// (set) Token: 0x06005C8F RID: 23695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A46")]
		public int RarityLevel
		{
			[Token(Token = "0x6005C8E")]
			[Address(RVA = "0x9A2D94", Offset = "0x9A2D94", VA = "0x9A2D94")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005C8F")]
			[Address(RVA = "0x9A2D9C", Offset = "0x9A2D9C", VA = "0x9A2D9C")]
			private set
			{
			}
		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C90")]
		[Address(RVA = "0x99E984", Offset = "0x99E984", VA = "0x99E984")]
		public RareSpawnBestiaryInfoElement(int rarityLevel)
		{
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C91")]
		[Address(RVA = "0x9A2DA4", Offset = "0x9A2DA4", VA = "0x9A2DA4", Slot = "4")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C92")]
		[Address(RVA = "0x9A2DAC", Offset = "0x9A2DAC", VA = "0x9A2DAC", Slot = "5")]
		public string GetSearchString(ref BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x04009D16 RID: 40214
		[Token(Token = "0x4009D16")]
		[FieldOffset(Offset = "0x8")]
		private int <RarityLevel>k__BackingField;
	}
}
