using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Graphics
{
	// Token: 0x02000DFF RID: 3583
	[Token(Token = "0x2000DFF")]
	public class BasicDebugDrawer : FileAPI, GUIControllerItem
	{
		// Token: 0x060068FA RID: 26874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068FA")]
		[Address(RVA = "0xB83D18", Offset = "0xB83D18", VA = "0xB83D18")]
		public BasicDebugDrawer(GraphicsDevice graphicsDevice)
		{
		}

		// Token: 0x060068FB RID: 26875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068FB")]
		[Address(RVA = "0xB83E94", Offset = "0xB83E94", VA = "0xB83E94")]
		public void Begin(Matrix matrix)
		{
		}

		// Token: 0x060068FC RID: 26876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068FC")]
		[Address(RVA = "0xB83FFC", Offset = "0xB83FFC", VA = "0xB83FFC")]
		public void Begin()
		{
		}

		// Token: 0x060068FD RID: 26877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068FD")]
		[Address(RVA = "0xB84094", Offset = "0xB84094", VA = "0xB84094", Slot = "4")]
		public void DrawSquare(Vector4 positionAndSize, Color color)
		{
		}

		// Token: 0x060068FE RID: 26878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068FE")]
		[Address(RVA = "0xB84224", Offset = "0xB84224", VA = "0xB84224")]
		public void DrawSquare(Vector2 position, Vector2 size, Color color)
		{
		}

		// Token: 0x060068FF RID: 26879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068FF")]
		[Address(RVA = "0xB84374", Offset = "0xB84374", VA = "0xB84374", Slot = "5")]
		public void DrawSquareFromCenter(Vector2 center, Vector2 size, float rotation, Color color)
		{
		}

		// Token: 0x06006900 RID: 26880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006900")]
		[Address(RVA = "0xB844AC", Offset = "0xB844AC", VA = "0xB844AC")]
		public void DrawLine(Vector2 start, Vector2 end, float width, Color color)
		{
		}

		// Token: 0x06006901 RID: 26881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006901")]
		[Address(RVA = "0xB84698", Offset = "0xB84698", VA = "0xB84698")]
		public void End()
		{
		}

		// Token: 0x06006902 RID: 26882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006902")]
		[Address(RVA = "0xB846BC", Offset = "0xB846BC", VA = "0xB846BC", Slot = "7")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06006903 RID: 26883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006903")]
		[Address(RVA = "0xB8471C", Offset = "0xB8471C", VA = "0xB8471C", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400A6CC RID: 42700
		[Token(Token = "0x400A6CC")]
		[FieldOffset(Offset = "0x8")]
		private SpriteBatch _spriteBatch;

		// Token: 0x0400A6CD RID: 42701
		[Token(Token = "0x400A6CD")]
		[FieldOffset(Offset = "0xC")]
		private Texture2D _texture;

		// Token: 0x0400A6CE RID: 42702
		[Token(Token = "0x400A6CE")]
		[FieldOffset(Offset = "0x10")]
		private bool _disposedValue;
	}
}
