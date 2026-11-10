using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BF1 RID: 3057
	[Token(Token = "0x2000BF1")]
	public class NPCWasChatWithTracker : FileAPI, GUIControllerItem
	{
		// Token: 0x06005C46 RID: 23622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C46")]
		[Address(RVA = "0x99C844", Offset = "0x99C844", VA = "0x99C844")]
		public NPCWasChatWithTracker()
		{
		}

		// Token: 0x06005C47 RID: 23623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C47")]
		[Address(RVA = "0x99D778", Offset = "0x99D778", VA = "0x99D778")]
		public void RegisterChatStartWith(NPC npc)
		{
		}

		// Token: 0x06005C48 RID: 23624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C48")]
		[Address(RVA = "0x99D8EC", Offset = "0x99D8EC", VA = "0x99D8EC")]
		public void SetWasChatWithDirectly(string persistentId)
		{
		}

		// Token: 0x06005C49 RID: 23625 RVA: 0x0002B4B8 File Offset: 0x000296B8
		[Token(Token = "0x6005C49")]
		[Address(RVA = "0x99DAB0", Offset = "0x99DAB0", VA = "0x99DAB0")]
		public bool GetWasChatWith(NPC npc)
		{
			return default(bool);
		}

		// Token: 0x06005C4A RID: 23626 RVA: 0x0002B4D0 File Offset: 0x000296D0
		[Token(Token = "0x6005C4A")]
		[Address(RVA = "0x99DB38", Offset = "0x99DB38", VA = "0x99DB38")]
		public bool GetWasChatWith(string persistentId)
		{
			return default(bool);
		}

		// Token: 0x06005C4B RID: 23627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C4B")]
		[Address(RVA = "0x99B098", Offset = "0x99B098", VA = "0x99B098", Slot = "4")]
		public void Save(BinaryWriter writer)
		{
		}

		// Token: 0x06005C4C RID: 23628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C4C")]
		[Address(RVA = "0x99B66C", Offset = "0x99B66C", VA = "0x99B66C", Slot = "5")]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x06005C4D RID: 23629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C4D")]
		[Address(RVA = "0x99B908", Offset = "0x99B908", VA = "0x99B908", Slot = "6")]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x06005C4E RID: 23630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C4E")]
		[Address(RVA = "0x99BB7C", Offset = "0x99BB7C", VA = "0x99BB7C", Slot = "7")]
		public void Reset()
		{
		}

		// Token: 0x06005C4F RID: 23631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C4F")]
		[Address(RVA = "0x99C20C", Offset = "0x99C20C", VA = "0x99C20C", Slot = "8")]
		public void OnPlayerJoining(int playerIndex)
		{
		}

		// Token: 0x04009CF0 RID: 40176
		[Token(Token = "0x4009CF0")]
		[FieldOffset(Offset = "0x8")]
		private object _entryCreationLock;

		// Token: 0x04009CF1 RID: 40177
		[Token(Token = "0x4009CF1")]
		[FieldOffset(Offset = "0xC")]
		private HashSet<string> _chattedWithPlayer;
	}
}
