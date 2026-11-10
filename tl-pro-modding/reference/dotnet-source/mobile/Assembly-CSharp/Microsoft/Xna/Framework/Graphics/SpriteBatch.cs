using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Terraria.Graphics;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000406 RID: 1030
	[Token(Token = "0x2000406")]
	public class SpriteBatch : GraphicsResource
	{
		// Token: 0x06001C4A RID: 7242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4A")]
		[Address(RVA = "0xE6C2B4", Offset = "0xE6C2B4", VA = "0xE6C2B4")]
		public SpriteBatch(GraphicsDevice graphicsDevice)
		{
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4B")]
		[Address(RVA = "0xE6C498", Offset = "0xE6C498", VA = "0xE6C498")]
		public void Begin(SpriteSortMode sortMode, bool defferedBatch)
		{
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4C")]
		[Address(RVA = "0xE6C6F4", Offset = "0xE6C6F4", VA = "0xE6C6F4")]
		public void Begin(SpriteSortMode sortMode = SpriteSortMode.Deferred, [Optional] BlendState blendState, [Optional] SamplerState samplerState, [Optional] DepthStencilState depthStencilState, [Optional] RasterizerState rasterizerState, [Optional] Effect effect, [Optional] Matrix? transformMatrix, bool defferedBatch = true)
		{
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4D")]
		[Address(RVA = "0xE6C930", Offset = "0xE6C930", VA = "0xE6C930")]
		public void End()
		{
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4E")]
		[Address(RVA = "0xE6CAC0", Offset = "0xE6CAC0", VA = "0xE6CAC0")]
		public void Flush()
		{
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4F")]
		[Address(RVA = "0xE6C694", Offset = "0xE6C694", VA = "0xE6C694")]
		private void Setup()
		{
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C50")]
		[Address(RVA = "0xE6CAE4", Offset = "0xE6CAE4", VA = "0xE6CAE4")]
		private void CheckValid(Texture2D texture)
		{
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C51")]
		[Address(RVA = "0xE6CB98", Offset = "0xE6CB98", VA = "0xE6CB98")]
		private void CheckValid(SpriteFont spriteFont, string text)
		{
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C52")]
		[Address(RVA = "0xE6CC80", Offset = "0xE6CC80", VA = "0xE6CC80")]
		private void CheckValid(SpriteFont spriteFont, StringBuilder text)
		{
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C53")]
		[Address(RVA = "0xE6CD68", Offset = "0xE6CD68", VA = "0xE6CD68")]
		public void Draw(Texture2D texture, [Optional] Vector2? position, [Optional] Rectangle? destinationRectangle, [Optional] Rectangle? sourceRectangle, [Optional] Vector2? origin, float rotation = 0f, [Optional] Vector2? scale, [Optional] Color? color, SpriteEffects effects = SpriteEffects.None, float layerDepth = 0f)
		{
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C54")]
		[Address(RVA = "0xE6DBFC", Offset = "0xE6DBFC", VA = "0xE6DBFC")]
		public void Draw(Texture2D texture, Vector2? position, Rectangle? destinationRectangle, Rectangle? sourceRectangle, Vector2? origin, float rotation, Vector2? scale, ref VertexColors color, SpriteEffects effects = SpriteEffects.None, float layerDepth = 0f)
		{
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C55")]
		[Address(RVA = "0xE6E978", Offset = "0xE6E978", VA = "0xE6E978")]
		[MethodImpl(256)]
		public SpriteBatchItem InsertNewBatchItem_Fast(Texture2D texture)
		{
			return null;
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C56")]
		[Address(RVA = "0xE6EC38", Offset = "0xE6EC38", VA = "0xE6EC38")]
		public SpriteBatchItem InsertNewBatchItem(Texture2D texture)
		{
			return null;
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C57")]
		[Address(RVA = "0xE6EF18", Offset = "0xE6EF18", VA = "0xE6EF18")]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects = SpriteEffects.None)
		{
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C58")]
		[Address(RVA = "0xE6F140", Offset = "0xE6F140", VA = "0xE6F140")]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects = SpriteEffects.None)
		{
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C59")]
		[Address(RVA = "0xE6F328", Offset = "0xE6F328", VA = "0xE6F328")]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, float rotation, Vector2 origin, float scale)
		{
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5A")]
		[Address(RVA = "0xE6F4D0", Offset = "0xE6F4D0", VA = "0xE6F4D0")]
		public void Draw(Texture2D texture, ref Vector2 position, ref Color color, float rotation, Vector2 origin, float scale)
		{
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5B")]
		[Address(RVA = "0xE6D26C", Offset = "0xE6D26C", VA = "0xE6D26C")]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5C")]
		[Address(RVA = "0xE6F79C", Offset = "0xE6F79C", VA = "0xE6F79C")]
		public void Draw(Texture2D texture, Vector2 position, ref Rectangle srcRect, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5D")]
		[Address(RVA = "0xE6E018", Offset = "0xE6E018", VA = "0xE6E018")]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, ref VertexColors color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5E")]
		[Address(RVA = "0xE6F9C8", Offset = "0xE6F9C8", VA = "0xE6F9C8")]
		public void Draw(Texture2D texture, Vector2 position, ref Rectangle srcRect, ref VertexColors color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5F")]
		[Address(RVA = "0xE6FBF8", Offset = "0xE6FBF8", VA = "0xE6FBF8")]
		public void Draw(Texture2D texture, Vector2 position, ref Rectangle srcRect, ref VertexColors color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C60")]
		[Address(RVA = "0xE6FE24", Offset = "0xE6FE24", VA = "0xE6FE24")]
		public static void ForceDrawScale(float scale, Vector2 origin, Vector2 position)
		{
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C61")]
		[Address(RVA = "0xE6FEF0", Offset = "0xE6FEF0", VA = "0xE6FEF0")]
		public static void ClearDrawScale()
		{
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C62")]
		[Address(RVA = "0xE6FF58", Offset = "0xE6FF58", VA = "0xE6FF58")]
		public static void TransformPosition(ref Vector2 position, ref Vector2 scale)
		{
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C63")]
		[Address(RVA = "0xE700AC", Offset = "0xE700AC", VA = "0xE700AC")]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth = 0f)
		{
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C64")]
		[Address(RVA = "0xE701C0", Offset = "0xE701C0", VA = "0xE701C0")]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color)
		{
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C65")]
		[Address(RVA = "0xE702EC", Offset = "0xE702EC", VA = "0xE702EC")]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref VertexColors color)
		{
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C66")]
		[Address(RVA = "0xE70688", Offset = "0xE70688", VA = "0xE70688")]
		public void Draw_Fast(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, SpriteEffects effects)
		{
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C67")]
		[Address(RVA = "0xE714C0", Offset = "0xE714C0", VA = "0xE714C0")]
		public void Draw_Fast(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref VertexColors color, SpriteEffects effects)
		{
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C68")]
		[Address(RVA = "0xE71870", Offset = "0xE71870", VA = "0xE71870")]
		public void Draw(Texture2D texture, Vector2 position, ref Rectangle srcRect, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth = 0f)
		{
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C69")]
		[Address(RVA = "0xE71A98", Offset = "0xE71A98", VA = "0xE71A98")]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, ref VertexColors color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth = 0f)
		{
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6A")]
		[Address(RVA = "0xE6D6E8", Offset = "0xE6D6E8", VA = "0xE6D6E8")]
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6B")]
		[Address(RVA = "0xE6E438", Offset = "0xE6E438", VA = "0xE6E438")]
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, ref VertexColors color, float rotation, Vector2 origin, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6C")]
		[Address(RVA = "0xE6F0FC", Offset = "0xE6F0FC", VA = "0xE6F0FC")]
		internal void FlushIfNeeded()
		{
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6D")]
		[Address(RVA = "0xE71BAC", Offset = "0xE71BAC", VA = "0xE71BAC")]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color)
		{
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6E")]
		[Address(RVA = "0xE71F34", Offset = "0xE71F34", VA = "0xE71F34")]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, ref VertexColors color)
		{
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6F")]
		[Address(RVA = "0xE722B4", Offset = "0xE722B4", VA = "0xE722B4")]
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color)
		{
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C70")]
		[Address(RVA = "0xE725BC", Offset = "0xE725BC", VA = "0xE725BC")]
		public void Draw(Texture2D texture, Vector2 position, Color color)
		{
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C71")]
		[Address(RVA = "0xE727A8", Offset = "0xE727A8", VA = "0xE727A8")]
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Color color)
		{
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C72")]
		[Address(RVA = "0xE72984", Offset = "0xE72984", VA = "0xE72984")]
		public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color)
		{
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C73")]
		[Address(RVA = "0xE730D4", Offset = "0xE730D4", VA = "0xE730D4")]
		public void DrawString(SpriteFont spriteFont, StringBuilder text, Vector2 position, Color color)
		{
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C74")]
		[Address(RVA = "0xE739BC", Offset = "0xE739BC", VA = "0xE739BC")]
		public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C75")]
		[Address(RVA = "0xE74778", Offset = "0xE74778", VA = "0xE74778")]
		public void DrawString(SpriteFont spriteFont, StringBuilder text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C76")]
		[Address(RVA = "0xE73AAC", Offset = "0xE73AAC", VA = "0xE73AAC")]
		public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C77")]
		[Address(RVA = "0xE75540", Offset = "0xE75540", VA = "0xE75540")]
		public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth, Vector2[] charOffsets)
		{
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C78")]
		[Address(RVA = "0xE76244", Offset = "0xE76244", VA = "0xE76244")]
		public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth, Vector2[] charOffsets, Color[] charColors)
		{
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C79")]
		[Address(RVA = "0xE76F48", Offset = "0xE76F48", VA = "0xE76F48")]
		public void DrawStringMultiLineRight(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7A")]
		[Address(RVA = "0xE782EC", Offset = "0xE782EC", VA = "0xE782EC")]
		public void DrawStringMultiLineCentre(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7B")]
		[Address(RVA = "0xE74868", Offset = "0xE74868", VA = "0xE74868")]
		public void DrawString(SpriteFont spriteFont, StringBuilder text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7C")]
		[Address(RVA = "0xE7969C", Offset = "0xE7969C", VA = "0xE7969C")]
		public void DrawString(SpriteFont spriteFont, string text, int start, int end, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, Vector2[] offsets)
		{
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7D")]
		[Address(RVA = "0xE7A268", Offset = "0xE7A268", VA = "0xE7A268")]
		public void DrawString(SpriteFont spriteFont, StringBuilder text, int start, int end, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, Vector2[] offsets)
		{
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7E")]
		[Address(RVA = "0xE7AC34", Offset = "0xE7AC34", VA = "0xE7AC34")]
		public void DrawString(SpriteFont spriteFont, string text, int start, int end, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7F")]
		[Address(RVA = "0xE7BA04", Offset = "0xE7BA04", VA = "0xE7BA04")]
		public void DrawString(SpriteFont spriteFont, StringBuilder text, int start, int end, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C80")]
		[Address(RVA = "0xE7C64C", Offset = "0xE7C64C", VA = "0xE7C64C")]
		public void DrawString(SpriteFont spriteFont, ref SpriteFont.CharacterSource source, Vector2 position, Color color, float scale, Vector2[] offsets)
		{
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C81")]
		[Address(RVA = "0xE7D054", Offset = "0xE7D054", VA = "0xE7D054")]
		public void DrawStringWithShadow(SpriteFont spriteFont, ref SpriteFont.CharacterSource source, Vector2 position, Color color, float scale)
		{
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C82")]
		[Address(RVA = "0xE7D8DC", Offset = "0xE7D8DC", VA = "0xE7D8DC")]
		public void DrawString(SpriteFont spriteFont, ref SpriteFont.CharacterSource source, Vector2 position, Color color, float scale)
		{
		}

		// Token: 0x04002FEC RID: 12268
		[Token(Token = "0x4002FEC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool BatchDeffered;

		// Token: 0x04002FED RID: 12269
		[Token(Token = "0x4002FED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool BatchDefferedHeadInsert;

		// Token: 0x04002FEE RID: 12270
		[Token(Token = "0x4002FEE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly SpriteBatcher _batcher;

		// Token: 0x04002FEF RID: 12271
		[Token(Token = "0x4002FEF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SpriteSortMode _sortMode;

		// Token: 0x04002FF0 RID: 12272
		[Token(Token = "0x4002FF0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private BlendState _blendState;

		// Token: 0x04002FF1 RID: 12273
		[Token(Token = "0x4002FF1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DepthStencilState _depthStencilState;

		// Token: 0x04002FF2 RID: 12274
		[Token(Token = "0x4002FF2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private RasterizerState _rasterizerState;

		// Token: 0x04002FF3 RID: 12275
		[Token(Token = "0x4002FF3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Effect _effect;

		// Token: 0x04002FF4 RID: 12276
		[Token(Token = "0x4002FF4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool _beginCalled;

		// Token: 0x04002FF5 RID: 12277
		[Token(Token = "0x4002FF5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _batchOffset;

		// Token: 0x04002FF6 RID: 12278
		[Token(Token = "0x4002FF6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private SpriteBatchItem _lastBatchItem;

		// Token: 0x04002FF7 RID: 12279
		[Token(Token = "0x4002FF7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SpriteBatchItemList _firstBatchList;

		// Token: 0x04002FF8 RID: 12280
		[Token(Token = "0x4002FF8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private SpriteBatchItemList _lastBatchList;

		// Token: 0x04002FF9 RID: 12281
		[Token(Token = "0x4002FF9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Effect _spriteEffect;

		// Token: 0x04002FFA RID: 12282
		[Token(Token = "0x4002FFA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private readonly EffectPass _spritePass;

		// Token: 0x04002FFB RID: 12283
		[Token(Token = "0x4002FFB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Matrix _renderMatrix;

		// Token: 0x04002FFC RID: 12284
		[Token(Token = "0x4002FFC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool _hasMatrix;

		// Token: 0x04002FFD RID: 12285
		[Token(Token = "0x4002FFD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Viewport _lastViewport;

		// Token: 0x04002FFE RID: 12286
		[Token(Token = "0x4002FFE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Matrix _projection;

		// Token: 0x04002FFF RID: 12287
		[Token(Token = "0x4002FFF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Rectangle _tempRect;

		// Token: 0x04003000 RID: 12288
		[Token(Token = "0x4003000")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private Vector2 _texCoordTL;

		// Token: 0x04003001 RID: 12289
		[Token(Token = "0x4003001")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Vector2 _texCoordBR;

		// Token: 0x04003002 RID: 12290
		[Token(Token = "0x4003002")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static bool NeedsHalfPixelOffset;

		// Token: 0x04003003 RID: 12291
		[Token(Token = "0x4003003")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public string LastBeginCall;

		// Token: 0x04003004 RID: 12292
		[Token(Token = "0x4003004")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public EffectPass OverloadedEffectPass;

		// Token: 0x04003005 RID: 12293
		[Token(Token = "0x4003005")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool forceDrawScale;

		// Token: 0x04003006 RID: 12294
		[Token(Token = "0x4003006")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static Vector2 forcedDrawScale;

		// Token: 0x04003007 RID: 12295
		[Token(Token = "0x4003007")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static Vector2 forcedDrawOrigin;

		// Token: 0x04003008 RID: 12296
		[Token(Token = "0x4003008")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static Vector2 forcedDrawPosition;

		// Token: 0x04003009 RID: 12297
		[Token(Token = "0x4003009")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static List<float> rightLineLengths;

		// Token: 0x0400300A RID: 12298
		[Token(Token = "0x400300A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static List<int> rightLineOffsets;

		// Token: 0x0400300B RID: 12299
		[Token(Token = "0x400300B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static List<SpriteBatchItem> rightLineElements;

		// Token: 0x0400300C RID: 12300
		[Token(Token = "0x400300C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector2[] scaledOffsets;
	}
}
