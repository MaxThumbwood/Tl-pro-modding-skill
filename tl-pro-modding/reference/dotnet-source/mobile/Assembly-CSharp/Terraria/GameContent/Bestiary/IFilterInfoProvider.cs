using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C11 RID: 3089
	[Token(Token = "0x2000C11")]
	public interface IFilterInfoProvider
	{
		// Token: 0x06005CC4 RID: 23748
		[Token(Token = "0x6005CC4")]
		UIElement GetFilterImage();

		// Token: 0x06005CC5 RID: 23749
		[Token(Token = "0x6005CC5")]
		string GetDisplayNameKey();

		// Token: 0x06005CC6 RID: 23750
		[Token(Token = "0x6005CC6")]
		void GetDisplay(out Texture2D texture, out Rectangle frame);
	}
}
