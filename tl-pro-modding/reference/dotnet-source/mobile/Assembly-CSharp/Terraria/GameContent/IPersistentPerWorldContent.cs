using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x02000989 RID: 2441
	[Token(Token = "0x2000989")]
	public interface IPersistentPerWorldContent
	{
		// Token: 0x0600507C RID: 20604
		[Token(Token = "0x600507C")]
		void Save(BinaryWriter writer);

		// Token: 0x0600507D RID: 20605
		[Token(Token = "0x600507D")]
		void Load(BinaryReader reader, int gameVersionSaveWasMadeOn);

		// Token: 0x0600507E RID: 20606
		[Token(Token = "0x600507E")]
		void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn);

		// Token: 0x0600507F RID: 20607
		[Token(Token = "0x600507F")]
		void Reset();
	}
}
