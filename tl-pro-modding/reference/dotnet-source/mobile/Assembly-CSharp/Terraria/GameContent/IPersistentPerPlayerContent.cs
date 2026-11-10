using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x0200098A RID: 2442
	[Token(Token = "0x200098A")]
	public interface IPersistentPerPlayerContent
	{
		// Token: 0x06005080 RID: 20608
		[Token(Token = "0x6005080")]
		void Save(Player player, BinaryWriter writer);

		// Token: 0x06005081 RID: 20609
		[Token(Token = "0x6005081")]
		void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn);

		// Token: 0x06005082 RID: 20610
		[Token(Token = "0x6005082")]
		void ApplyLoadedDataToOutOfPlayerFields(Player player);

		// Token: 0x06005083 RID: 20611
		[Token(Token = "0x6005083")]
		void ResetDataForNewPlayer(Player player);

		// Token: 0x06005084 RID: 20612
		[Token(Token = "0x6005084")]
		void Reset();
	}
}
