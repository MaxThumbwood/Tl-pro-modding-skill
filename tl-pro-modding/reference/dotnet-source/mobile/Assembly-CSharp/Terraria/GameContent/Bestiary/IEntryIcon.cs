using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BF3 RID: 3059
	[Token(Token = "0x2000BF3")]
	public interface IEntryIcon
	{
		// Token: 0x06005C58 RID: 23640
		[Token(Token = "0x6005C58")]
		void Update(BestiaryUICollectionInfo providedInfo, Rectangle hitbox, EntryIconDrawSettings settings);

		// Token: 0x06005C59 RID: 23641
		[Token(Token = "0x6005C59")]
		void Draw(BestiaryUICollectionInfo providedInfo, SpriteBatch spriteBatch, EntryIconDrawSettings settings);

		// Token: 0x06005C5A RID: 23642
		[Token(Token = "0x6005C5A")]
		bool GetUnlockState(BestiaryUICollectionInfo providedInfo);

		// Token: 0x06005C5B RID: 23643
		[Token(Token = "0x6005C5B")]
		string GetHoverText(BestiaryUICollectionInfo providedInfo);

		// Token: 0x06005C5C RID: 23644
		[Token(Token = "0x6005C5C")]
		IEntryIcon CreateClone();
	}
}
