using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Shaders;

namespace Terraria.Graphics.Effects
{
	// Token: 0x0200090E RID: 2318
	[Token(Token = "0x200090E")]
	public class SimpleOverlay : Overlay
	{
		// Token: 0x06004DB8 RID: 19896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB8")]
		[Address(RVA = "0x726374", Offset = "0x726374", VA = "0x726374")]
		public SimpleOverlay(string textureName, ScreenShaderData shader, EffectPriority priority = EffectPriority.VeryLow, RenderLayers layer = RenderLayers.All)
		{
		}

		// Token: 0x06004DB9 RID: 19897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB9")]
		[Address(RVA = "0x72658C", Offset = "0x72658C", VA = "0x72658C")]
		public SimpleOverlay(string textureName, string shaderName = "Default", EffectPriority priority = EffectPriority.VeryLow, RenderLayers layer = RenderLayers.All)
		{
		}

		// Token: 0x06004DBA RID: 19898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DBA")]
		[Address(RVA = "0x72680C", Offset = "0x72680C", VA = "0x72680C")]
		public ScreenShaderData GetShader()
		{
			return null;
		}

		// Token: 0x06004DBB RID: 19899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DBB")]
		[Address(RVA = "0x726814", Offset = "0x726814", VA = "0x726814", Slot = "8")]
		public override void Draw(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06004DBC RID: 19900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DBC")]
		[Address(RVA = "0x726964", Offset = "0x726964", VA = "0x726964", Slot = "9")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06004DBD RID: 19901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DBD")]
		[Address(RVA = "0x726998", Offset = "0x726998", VA = "0x726998", Slot = "6")]
		public override void Activate(Vector2 position, object[] args)
		{
		}

		// Token: 0x06004DBE RID: 19902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DBE")]
		[Address(RVA = "0x7269AC", Offset = "0x7269AC", VA = "0x7269AC", Slot = "7")]
		public override void Deactivate(object[] args)
		{
		}

		// Token: 0x06004DBF RID: 19903 RVA: 0x00024630 File Offset: 0x00022830
		[Token(Token = "0x6004DBF")]
		[Address(RVA = "0x7269B8", Offset = "0x7269B8", VA = "0x7269B8", Slot = "5")]
		public override bool IsVisible()
		{
			return default(bool);
		}

		// Token: 0x040092CE RID: 37582
		[Token(Token = "0x40092CE")]
		[FieldOffset(Offset = "0x1C")]
		private Asset<Texture2D> _texture;

		// Token: 0x040092CF RID: 37583
		[Token(Token = "0x40092CF")]
		[FieldOffset(Offset = "0x20")]
		private ScreenShaderData _shader;

		// Token: 0x040092D0 RID: 37584
		[Token(Token = "0x40092D0")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 TargetPosition;
	}
}
