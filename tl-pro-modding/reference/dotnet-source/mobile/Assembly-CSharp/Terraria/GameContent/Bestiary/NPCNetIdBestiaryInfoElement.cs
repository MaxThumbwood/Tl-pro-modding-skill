using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C1A RID: 3098
	[Token(Token = "0x2000C1A")]
	public class NPCNetIdBestiaryInfoElement : FileAPI, GUIControllerItem
	{
		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06005CDE RID: 23774 RVA: 0x0002B7B8 File Offset: 0x000299B8
		// (set) Token: 0x06005CDF RID: 23775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A4E")]
		public int NetId
		{
			[Token(Token = "0x6005CDE")]
			[Address(RVA = "0x9A5A88", Offset = "0x9A5A88", VA = "0x9A5A88")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005CDF")]
			[Address(RVA = "0x9A5A90", Offset = "0x9A5A90", VA = "0x9A5A90")]
			private set
			{
			}
		}

		// Token: 0x06005CE0 RID: 23776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE0")]
		[Address(RVA = "0x99E760", Offset = "0x99E760", VA = "0x99E760")]
		public NPCNetIdBestiaryInfoElement(int npcNetId)
		{
		}

		// Token: 0x06005CE1 RID: 23777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CE1")]
		[Address(RVA = "0x9A5A98", Offset = "0x9A5A98", VA = "0x9A5A98", Slot = "4")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06005CE2 RID: 23778 RVA: 0x0002B7D0 File Offset: 0x000299D0
		[Token(Token = "0x17000A4F")]
		public int BestiaryDisplayIndex
		{
			[Token(Token = "0x6005CE2")]
			[Address(RVA = "0x9A5AA0", Offset = "0x9A5AA0", VA = "0x9A5AA0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04009D36 RID: 40246
		[Token(Token = "0x4009D36")]
		[FieldOffset(Offset = "0x8")]
		private int <NetId>k__BackingField;
	}
}
