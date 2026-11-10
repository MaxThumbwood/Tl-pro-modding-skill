using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace ReLogic.OS
{
	// Token: 0x02000DEA RID: 3562
	[Token(Token = "0x2000DEA")]
	public interface IWindowService
	{
		// Token: 0x06006893 RID: 26771
		[Token(Token = "0x6006893")]
		void SetUnicodeTitle(GameWindow window, string title);

		// Token: 0x06006894 RID: 26772
		[Token(Token = "0x6006894")]
		void StartFlashingIcon(GameWindow window);

		// Token: 0x06006895 RID: 26773
		[Token(Token = "0x6006895")]
		void StopFlashingIcon(GameWindow window);

		// Token: 0x06006896 RID: 26774
		[Token(Token = "0x6006896")]
		float GetScaling();

		// Token: 0x06006897 RID: 26775
		[Token(Token = "0x6006897")]
		void SetQuickEditEnabled(bool enabled);
	}
}
