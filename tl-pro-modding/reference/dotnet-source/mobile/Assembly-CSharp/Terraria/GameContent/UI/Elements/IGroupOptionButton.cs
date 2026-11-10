using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D5B RID: 3419
	[Token(Token = "0x2000D5B")]
	public interface IGroupOptionButton
	{
		// Token: 0x06006558 RID: 25944
		[Token(Token = "0x6006558")]
		void SetColorsBasedOnSelectionState(Color pickedColor, Color unpickedColor, float opacityPicked, float opacityNotPicked);

		// Token: 0x06006559 RID: 25945
		[Token(Token = "0x6006559")]
		void SetBorderColor(Color color);
	}
}
