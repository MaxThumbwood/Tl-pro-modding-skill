using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI.Chat
{
	// Token: 0x020008A2 RID: 2210
	[Token(Token = "0x20008A2")]
	public interface ITagHandler
	{
		// Token: 0x06004B24 RID: 19236
		[Token(Token = "0x6004B24")]
		TextSnippet Parse(string text, [Optional] Color baseColor, [Optional] string options);
	}
}
