using System;
using Il2CppDummyDll;

namespace ReLogic.Text
{
	// Token: 0x02000DDE RID: 3550
	[Token(Token = "0x2000DDE")]
	public interface IFontMetrics
	{
		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06006867 RID: 26727
		[Token(Token = "0x17000B21")]
		int LineSpacing
		{
			[Token(Token = "0x6006867")]
			get;
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06006868 RID: 26728
		[Token(Token = "0x17000B22")]
		float CharacterSpacing
		{
			[Token(Token = "0x6006868")]
			get;
		}

		// Token: 0x06006869 RID: 26729
		[Token(Token = "0x6006869")]
		GlyphMetrics GetCharacterMetrics(char character);
	}
}
