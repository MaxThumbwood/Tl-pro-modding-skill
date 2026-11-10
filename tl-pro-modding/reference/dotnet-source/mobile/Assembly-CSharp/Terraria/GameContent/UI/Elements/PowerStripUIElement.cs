using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D5D RID: 3421
	[Token(Token = "0x2000D5D")]
	public class PowerStripUIElement : UIElement
	{
		// Token: 0x06006570 RID: 25968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006570")]
		[Address(RVA = "0xB472E4", Offset = "0xB472E4", VA = "0xB472E4")]
		public PowerStripUIElement(string gamepadGroupName, List<UIElement> buttons)
		{
		}

		// Token: 0x0400A2CE RID: 41678
		[Token(Token = "0x400A2CE")]
		[FieldOffset(Offset = "0xF4")]
		private List<UIElement> _buttonsBySorting;

		// Token: 0x0400A2CF RID: 41679
		[Token(Token = "0x400A2CF")]
		[FieldOffset(Offset = "0xF8")]
		private string _gamepadPointGroupname;
	}
}
