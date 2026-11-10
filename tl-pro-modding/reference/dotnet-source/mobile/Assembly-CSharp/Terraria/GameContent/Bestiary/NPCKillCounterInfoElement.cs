using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C1F RID: 3103
	[Token(Token = "0x2000C1F")]
	public class NPCKillCounterInfoElement : FileAPI
	{
		// Token: 0x06005CEF RID: 23791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CEF")]
		[Address(RVA = "0x99E7C4", Offset = "0x99E7C4", VA = "0x99E7C4")]
		public NPCKillCounterInfoElement(int npcNetId)
		{
		}

		// Token: 0x06005CF0 RID: 23792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CF0")]
		[Address(RVA = "0x9A768C", Offset = "0x9A768C", VA = "0x9A768C", Slot = "4")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x06005CF1 RID: 23793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF1")]
		[Address(RVA = "0x9A7FCC", Offset = "0x9A7FCC", VA = "0x9A7FCC")]
		private void ShowDescription(UIElement element)
		{
		}

		// Token: 0x06005CF2 RID: 23794 RVA: 0x0002B848 File Offset: 0x00029A48
		[Token(Token = "0x6005CF2")]
		[Address(RVA = "0x9A7E70", Offset = "0x9A7E70", VA = "0x9A7E70")]
		private int? GetKillCount()
		{
			return null;
		}

		// Token: 0x04009D3C RID: 40252
		[Token(Token = "0x4009D3C")]
		[FieldOffset(Offset = "0x8")]
		private NPC _instance;
	}
}
