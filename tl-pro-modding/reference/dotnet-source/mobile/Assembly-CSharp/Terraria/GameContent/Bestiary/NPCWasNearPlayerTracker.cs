using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BF0 RID: 3056
	[Token(Token = "0x2000BF0")]
	public class NPCWasNearPlayerTracker : FileAPI, GUIControllerItem
	{
		// Token: 0x06005C3A RID: 23610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C3A")]
		[Address(RVA = "0x99CEE4", Offset = "0x99CEE4", VA = "0x99CEE4")]
		public void PrepareSamplesBasedOptimizations()
		{
		}

		// Token: 0x06005C3B RID: 23611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C3B")]
		[Address(RVA = "0x99C6A8", Offset = "0x99C6A8", VA = "0x99C6A8")]
		public NPCWasNearPlayerTracker()
		{
		}

		// Token: 0x06005C3C RID: 23612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C3C")]
		[Address(RVA = "0x99CEE8", Offset = "0x99CEE8", VA = "0x99CEE8")]
		public void RegisterWasNearby(NPC npc)
		{
		}

		// Token: 0x06005C3D RID: 23613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C3D")]
		[Address(RVA = "0x99D05C", Offset = "0x99D05C", VA = "0x99D05C")]
		public void SetWasSeenDirectly(string persistentId)
		{
		}

		// Token: 0x06005C3E RID: 23614 RVA: 0x0002B488 File Offset: 0x00029688
		[Token(Token = "0x6005C3E")]
		[Address(RVA = "0x99D220", Offset = "0x99D220", VA = "0x99D220")]
		public bool GetWasNearbyBefore(NPC npc)
		{
			return default(bool);
		}

		// Token: 0x06005C3F RID: 23615 RVA: 0x0002B4A0 File Offset: 0x000296A0
		[Token(Token = "0x6005C3F")]
		[Address(RVA = "0x99D2A8", Offset = "0x99D2A8", VA = "0x99D2A8")]
		public bool GetWasNearbyBefore(string persistentIdentifier)
		{
			return default(bool);
		}

		// Token: 0x06005C40 RID: 23616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C40")]
		[Address(RVA = "0x99AE00", Offset = "0x99AE00", VA = "0x99AE00", Slot = "4")]
		public void Save(BinaryWriter writer)
		{
		}

		// Token: 0x06005C41 RID: 23617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C41")]
		[Address(RVA = "0x99B5AC", Offset = "0x99B5AC", VA = "0x99B5AC", Slot = "5")]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x06005C42 RID: 23618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C42")]
		[Address(RVA = "0x99B8B4", Offset = "0x99B8B4", VA = "0x99B8B4", Slot = "6")]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x06005C43 RID: 23619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C43")]
		[Address(RVA = "0x99BAB4", Offset = "0x99BAB4", VA = "0x99BAB4", Slot = "7")]
		public void Reset()
		{
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C44")]
		[Address(RVA = "0x99D314", Offset = "0x99D314", VA = "0x99D314")]
		public void ScanWorldForFinds()
		{
		}

		// Token: 0x06005C45 RID: 23621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C45")]
		[Address(RVA = "0x99BF48", Offset = "0x99BF48", VA = "0x99BF48", Slot = "8")]
		public void OnPlayerJoining(int playerIndex)
		{
		}

		// Token: 0x04009CEC RID: 40172
		[Token(Token = "0x4009CEC")]
		[FieldOffset(Offset = "0x8")]
		private object _entryCreationLock;

		// Token: 0x04009CED RID: 40173
		[Token(Token = "0x4009CED")]
		[FieldOffset(Offset = "0xC")]
		private HashSet<string> _wasNearPlayer;

		// Token: 0x04009CEE RID: 40174
		[Token(Token = "0x4009CEE")]
		[FieldOffset(Offset = "0x10")]
		private List<Rectangle> _playerHitboxesForBestiary;

		// Token: 0x04009CEF RID: 40175
		[Token(Token = "0x4009CEF")]
		[FieldOffset(Offset = "0x14")]
		private List<int> _wasSeenNearPlayerByNetId;
	}
}
