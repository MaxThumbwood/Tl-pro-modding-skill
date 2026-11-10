using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent
{
	// Token: 0x020009DD RID: 2525
	[Token(Token = "0x20009DD")]
	public interface ITownNPCProfile
	{
		// Token: 0x0600526B RID: 21099
		[Token(Token = "0x600526B")]
		int RollVariation();

		// Token: 0x0600526C RID: 21100
		[Token(Token = "0x600526C")]
		string GetNameForVariant(NPC npc);

		// Token: 0x0600526D RID: 21101
		[Token(Token = "0x600526D")]
		Asset<Texture2D> GetTextureNPCShouldUse(NPC npc);

		// Token: 0x0600526E RID: 21102
		[Token(Token = "0x600526E")]
		int GetHeadTextureIndex(NPC npc);
	}
}
