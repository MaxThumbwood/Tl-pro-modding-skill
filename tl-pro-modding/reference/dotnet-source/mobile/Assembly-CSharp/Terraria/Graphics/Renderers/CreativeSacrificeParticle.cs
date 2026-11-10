using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008D5 RID: 2261
	[Token(Token = "0x20008D5")]
	public class CreativeSacrificeParticle : FileAPI
	{
		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06004C5B RID: 19547 RVA: 0x00024108 File Offset: 0x00022308
		// (set) Token: 0x06004C5C RID: 19548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700093D")]
		public bool ShouldBeRemovedFromRenderer
		{
			[Token(Token = "0x6004C5B")]
			[Address(RVA = "0x6F326C", Offset = "0x6F326C", VA = "0x6F326C", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004C5C")]
			[Address(RVA = "0x6F3274", Offset = "0x6F3274", VA = "0x6F3274")]
			private set
			{
			}
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5D")]
		[Address(RVA = "0x6F327C", Offset = "0x6F327C", VA = "0x6F327C")]
		public CreativeSacrificeParticle(Asset<Texture2D> textureAsset, Rectangle? frame, Vector2 initialVelocity, Vector2 initialLocalPosition)
		{
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5E")]
		[Address(RVA = "0x6F3488", Offset = "0x6F3488", VA = "0x6F3488", Slot = "5")]
		public void Update(ref ParticleRendererSettings settings)
		{
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5F")]
		[Address(RVA = "0x6F3574", Offset = "0x6F3574", VA = "0x6F3574", Slot = "6")]
		public void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
		}

		// Token: 0x04009139 RID: 37177
		[Token(Token = "0x4009139")]
		[FieldOffset(Offset = "0x8")]
		private bool <ShouldBeRemovedFromRenderer>k__BackingField;

		// Token: 0x0400913A RID: 37178
		[Token(Token = "0x400913A")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 AccelerationPerFrame;

		// Token: 0x0400913B RID: 37179
		[Token(Token = "0x400913B")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 Velocity;

		// Token: 0x0400913C RID: 37180
		[Token(Token = "0x400913C")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 LocalPosition;

		// Token: 0x0400913D RID: 37181
		[Token(Token = "0x400913D")]
		[FieldOffset(Offset = "0x24")]
		public float ScaleOffsetPerFrame;

		// Token: 0x0400913E RID: 37182
		[Token(Token = "0x400913E")]
		[FieldOffset(Offset = "0x28")]
		public float StopWhenBelowXScale;

		// Token: 0x0400913F RID: 37183
		[Token(Token = "0x400913F")]
		[FieldOffset(Offset = "0x2C")]
		private Asset<Texture2D> _texture;

		// Token: 0x04009140 RID: 37184
		[Token(Token = "0x4009140")]
		[FieldOffset(Offset = "0x30")]
		private Rectangle _frame;

		// Token: 0x04009141 RID: 37185
		[Token(Token = "0x4009141")]
		[FieldOffset(Offset = "0x40")]
		private Vector2 _origin;

		// Token: 0x04009142 RID: 37186
		[Token(Token = "0x4009142")]
		[FieldOffset(Offset = "0x48")]
		private float _scale;
	}
}
