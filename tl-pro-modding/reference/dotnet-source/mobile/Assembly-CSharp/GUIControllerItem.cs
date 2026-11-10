using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000A0 RID: 160
[Token(Token = "0x20000A0")]
public interface GUIControllerItem
{
	// Token: 0x06000417 RID: 1047
	[Token(Token = "0x6000417")]
	void Activate();

	// Token: 0x06000418 RID: 1048
	[Token(Token = "0x6000418")]
	GUIControllerItem Navigate(Vector2 navigationVector);

	// Token: 0x06000419 RID: 1049
	[Token(Token = "0x6000419")]
	Rectangle GetSelectedItemRegion();

	// Token: 0x0600041A RID: 1050
	[Token(Token = "0x600041A")]
	int GetNavigationOutDirs();
}
