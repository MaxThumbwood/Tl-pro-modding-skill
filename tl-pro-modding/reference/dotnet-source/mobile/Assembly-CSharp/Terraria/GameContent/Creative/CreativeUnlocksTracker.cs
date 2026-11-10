using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000CDB RID: 3291
	[Token(Token = "0x2000CDB")]
	public class CreativeUnlocksTracker : FileAPI, GUIControllerItem
	{
		// Token: 0x060061BA RID: 25018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061BA")]
		[Address(RVA = "0xADDBF0", Offset = "0xADDBF0", VA = "0xADDBF0", Slot = "4")]
		public void Save(BinaryWriter writer)
		{
		}

		// Token: 0x060061BB RID: 25019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061BB")]
		[Address(RVA = "0xADDD48", Offset = "0xADDD48", VA = "0xADDD48", Slot = "5")]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x060061BC RID: 25020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061BC")]
		[Address(RVA = "0xADE068", Offset = "0xADE068", VA = "0xADE068", Slot = "6")]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x060061BD RID: 25021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061BD")]
		[Address(RVA = "0xADE06C", Offset = "0xADE06C", VA = "0xADE06C", Slot = "7")]
		public void Reset()
		{
		}

		// Token: 0x060061BE RID: 25022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061BE")]
		[Address(RVA = "0xADE1AC", Offset = "0xADE1AC", VA = "0xADE1AC", Slot = "8")]
		public void OnPlayerJoining(int playerIndex)
		{
		}

		// Token: 0x060061BF RID: 25023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061BF")]
		[Address(RVA = "0xADE1C0", Offset = "0xADE1C0", VA = "0xADE1C0")]
		public CreativeUnlocksTracker()
		{
		}

		// Token: 0x0400A051 RID: 41041
		[Token(Token = "0x400A051")]
		[FieldOffset(Offset = "0x8")]
		public ItemsSacrificedUnlocksTracker ItemSacrifices;
	}
}
