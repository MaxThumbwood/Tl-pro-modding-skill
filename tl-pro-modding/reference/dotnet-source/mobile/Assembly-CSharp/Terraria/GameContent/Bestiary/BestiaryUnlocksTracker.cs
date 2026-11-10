using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BEE RID: 3054
	[Token(Token = "0x2000BEE")]
	public class BestiaryUnlocksTracker : FileAPI, GUIControllerItem
	{
		// Token: 0x06005C29 RID: 23593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C29")]
		[Address(RVA = "0x99AA90", Offset = "0x99AA90", VA = "0x99AA90", Slot = "4")]
		public void Save(BinaryWriter writer)
		{
		}

		// Token: 0x06005C2A RID: 23594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2A")]
		[Address(RVA = "0x99B330", Offset = "0x99B330", VA = "0x99B330", Slot = "5")]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x06005C2B RID: 23595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2B")]
		[Address(RVA = "0x99B72C", Offset = "0x99B72C", VA = "0x99B72C", Slot = "6")]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x06005C2C RID: 23596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2C")]
		[Address(RVA = "0x99B95C", Offset = "0x99B95C", VA = "0x99B95C", Slot = "7")]
		public void Reset()
		{
		}

		// Token: 0x06005C2D RID: 23597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2D")]
		[Address(RVA = "0x99BBE0", Offset = "0x99BBE0", VA = "0x99BBE0", Slot = "8")]
		public void OnPlayerJoining(int playerIndex)
		{
		}

		// Token: 0x06005C2E RID: 23598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2E")]
		[Address(RVA = "0x99C4D0", Offset = "0x99C4D0", VA = "0x99C4D0")]
		public void FillBasedOnVersionBefore210()
		{
		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2F")]
		[Address(RVA = "0x99C4D4", Offset = "0x99C4D4", VA = "0x99C4D4")]
		public BestiaryUnlocksTracker()
		{
		}

		// Token: 0x04009CE6 RID: 40166
		[Token(Token = "0x4009CE6")]
		[FieldOffset(Offset = "0x8")]
		public NPCKillsTracker Kills;

		// Token: 0x04009CE7 RID: 40167
		[Token(Token = "0x4009CE7")]
		[FieldOffset(Offset = "0xC")]
		public NPCWasNearPlayerTracker Sights;

		// Token: 0x04009CE8 RID: 40168
		[Token(Token = "0x4009CE8")]
		[FieldOffset(Offset = "0x10")]
		public NPCWasChatWithTracker Chats;
	}
}
