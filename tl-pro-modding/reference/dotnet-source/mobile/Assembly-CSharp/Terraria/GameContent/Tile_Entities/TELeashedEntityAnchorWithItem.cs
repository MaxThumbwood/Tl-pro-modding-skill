using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x020009FD RID: 2557
	[Token(Token = "0x20009FD")]
	public abstract class TELeashedEntityAnchorWithItem : TELeashedEntityAnchor
	{
		// Token: 0x06005336 RID: 21302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005336")]
		[Address(RVA = "0x7F6D4C", Offset = "0x7F6D4C", VA = "0x7F6D4C", Slot = "7")]
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
		}

		// Token: 0x06005337 RID: 21303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005337")]
		[Address(RVA = "0x7F6D80", Offset = "0x7F6D80", VA = "0x7F6D80", Slot = "8")]
		public override void ReadExtraData(BinaryReader reader, int gameVersion, bool networkSend)
		{
		}

		// Token: 0x06005338 RID: 21304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005338")]
		[Address(RVA = "0x7F6DB4", Offset = "0x7F6DB4", VA = "0x7F6DB4")]
		public void DropItemForTileBreak()
		{
		}

		// Token: 0x06005339 RID: 21305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005339")]
		[Address(RVA = "0x7F6F14", Offset = "0x7F6F14", VA = "0x7F6F14")]
		public void InsertItem(int itemType)
		{
		}

		// Token: 0x0600533A RID: 21306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600533A")]
		[Address(RVA = "0x7F6FB4", Offset = "0x7F6FB4", VA = "0x7F6FB4", Slot = "17")]
		public override void OnWorldLoaded()
		{
		}

		// Token: 0x0600533B RID: 21307
		[Token(Token = "0x600533B")]
		public abstract bool FitsItem(int itemType);

		// Token: 0x0600533C RID: 21308 RVA: 0x00026BF8 File Offset: 0x00024DF8
		[Token(Token = "0x600533C")]
		[Address(RVA = "0x7F7074", Offset = "0x7F7074", VA = "0x7F7074")]
		protected new static int PlaceFromPlayerPlacementHook(int x, int y, int type)
		{
			return 0;
		}

		// Token: 0x0600533D RID: 21309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600533D")]
		[Address(RVA = "0x7F73B8", Offset = "0x7F73B8", VA = "0x7F73B8")]
		protected TELeashedEntityAnchorWithItem()
		{
		}

		// Token: 0x04009740 RID: 38720
		[Token(Token = "0x4009740")]
		[FieldOffset(Offset = "0x18")]
		protected int itemType;
	}
}
