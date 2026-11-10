using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Graphics
{
	// Token: 0x02000E01 RID: 3585
	[Token(Token = "0x2000E01")]
	public interface IDebugDrawer
	{
		// Token: 0x06006905 RID: 26885
		[Token(Token = "0x6006905")]
		void DrawSquare(Vector4 positionAndSize, Color color);

		// Token: 0x06006906 RID: 26886
		[Token(Token = "0x6006906")]
		void DrawSquareFromCenter(Vector2 center, Vector2 size, float rotation, Color color);
	}
}
