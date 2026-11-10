using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BF5 RID: 3061
	[Token(Token = "0x2000BF5")]
	public class UnlockableNPCEntryIcon : FileAPI
	{
		// Token: 0x06005C5D RID: 23645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C5D")]
		[Address(RVA = "0x99E9F4", Offset = "0x99E9F4", VA = "0x99E9F4")]
		public UnlockableNPCEntryIcon(int npcNetId, float ai0 = 0f, float ai1 = 0f, float ai2 = 0f, float ai3 = 0f, [Optional] string overrideNameKey)
		{
		}

		// Token: 0x06005C5E RID: 23646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C5E")]
		[Address(RVA = "0x99FF0C", Offset = "0x99FF0C", VA = "0x99FF0C", Slot = "8")]
		public IEntryIcon CreateClone()
		{
			return null;
		}

		// Token: 0x06005C5F RID: 23647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C5F")]
		[Address(RVA = "0x99FFA0", Offset = "0x99FFA0", VA = "0x99FFA0", Slot = "4")]
		public void Update(BestiaryUICollectionInfo providedInfo, Rectangle hitbox, EntryIconDrawSettings settings)
		{
		}

		// Token: 0x06005C60 RID: 23648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C60")]
		[Address(RVA = "0x9A0614", Offset = "0x9A0614", VA = "0x9A0614")]
		private void UpdatePosition(EntryIconDrawSettings settings)
		{
		}

		// Token: 0x06005C61 RID: 23649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C61")]
		[Address(RVA = "0x9A0958", Offset = "0x9A0958", VA = "0x9A0958")]
		private void AdjustSpecialSpawnRulesForVisuals(EntryIconDrawSettings settings)
		{
		}

		// Token: 0x06005C62 RID: 23650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C62")]
		[Address(RVA = "0x9A0E14", Offset = "0x9A0E14", VA = "0x9A0E14")]
		private void SimulateFirstHover(float velocity)
		{
		}

		// Token: 0x06005C63 RID: 23651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C63")]
		[Address(RVA = "0x9A0EA4", Offset = "0x9A0EA4", VA = "0x9A0EA4", Slot = "5")]
		public void Draw(BestiaryUICollectionInfo providedInfo, SpriteBatch spriteBatch, EntryIconDrawSettings settings)
		{
		}

		// Token: 0x06005C64 RID: 23652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C64")]
		[Address(RVA = "0x9A1364", Offset = "0x9A1364", VA = "0x9A1364", Slot = "7")]
		public string GetHoverText(BestiaryUICollectionInfo providedInfo)
		{
			return null;
		}

		// Token: 0x06005C65 RID: 23653 RVA: 0x0002B4E8 File Offset: 0x000296E8
		[Token(Token = "0x6005C65")]
		[Address(RVA = "0x9A1468", Offset = "0x9A1468", VA = "0x9A1468", Slot = "6")]
		public bool GetUnlockState(BestiaryUICollectionInfo providedInfo)
		{
			return default(bool);
		}

		// Token: 0x04009CF8 RID: 40184
		[Token(Token = "0x4009CF8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int lastFrameVisualsUpdated;

		// Token: 0x04009CF9 RID: 40185
		[Token(Token = "0x4009CF9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int _npcNetId;

		// Token: 0x04009CFA RID: 40186
		[Token(Token = "0x4009CFA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private NPC _npcCache;

		// Token: 0x04009CFB RID: 40187
		[Token(Token = "0x4009CFB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool _firstUpdateDone;

		// Token: 0x04009CFC RID: 40188
		[Token(Token = "0x4009CFC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Asset<Texture2D> _customTexture;

		// Token: 0x04009CFD RID: 40189
		[Token(Token = "0x4009CFD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector2 _positionOffsetCache;

		// Token: 0x04009CFE RID: 40190
		[Token(Token = "0x4009CFE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private string _overrideNameKey;
	}
}
