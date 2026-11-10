using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008D6 RID: 2262
	[Token(Token = "0x20008D6")]
	public abstract class ABasicParticle : FileAPI, GUIControllerItem
	{
		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06004C60 RID: 19552 RVA: 0x00024120 File Offset: 0x00022320
		// (set) Token: 0x06004C61 RID: 19553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700093E")]
		public bool ShouldBeRemovedFromRenderer
		{
			[Token(Token = "0x6004C60")]
			[Address(RVA = "0x6F37B0", Offset = "0x6F37B0", VA = "0x6F37B0", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004C61")]
			[Address(RVA = "0x6F37B8", Offset = "0x6F37B8", VA = "0x6F37B8")]
			protected set
			{
			}
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C62")]
		[Address(RVA = "0x6F37C0", Offset = "0x6F37C0", VA = "0x6F37C0")]
		public ABasicParticle(ParticlePool pool)
		{
		}

		// Token: 0x06004C63 RID: 19555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C63")]
		[Address(RVA = "0x6F39F0", Offset = "0x6F39F0", VA = "0x6F39F0", Slot = "9")]
		public virtual void SetBasicInfo(Asset<Texture2D> textureAsset, Rectangle? frame, Vector2 initialVelocity, Vector2 initialLocalPosition)
		{
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C64")]
		[Address(RVA = "0x6F3BE0", Offset = "0x6F3BE0", VA = "0x6F3BE0", Slot = "10")]
		public virtual void Update(ref ParticleRendererSettings settings)
		{
		}

		// Token: 0x06004C65 RID: 19557
		[Token(Token = "0x6004C65")]
		public abstract void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch);

		// Token: 0x06004C66 RID: 19558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C66")]
		[Address(RVA = "0x6F3C70", Offset = "0x6F3C70", VA = "0x6F3C70", Slot = "4")]
		public void RestInPool()
		{
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C67")]
		[Address(RVA = "0x6F3CD8", Offset = "0x6F3CD8", VA = "0x6F3CD8", Slot = "12")]
		public virtual void FetchFromPool()
		{
		}

		// Token: 0x04009143 RID: 37187
		[Token(Token = "0x4009143")]
		[FieldOffset(Offset = "0x8")]
		private bool <ShouldBeRemovedFromRenderer>k__BackingField;

		// Token: 0x04009144 RID: 37188
		[Token(Token = "0x4009144")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 AccelerationPerFrame;

		// Token: 0x04009145 RID: 37189
		[Token(Token = "0x4009145")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 Velocity;

		// Token: 0x04009146 RID: 37190
		[Token(Token = "0x4009146")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 LocalPosition;

		// Token: 0x04009147 RID: 37191
		[Token(Token = "0x4009147")]
		[FieldOffset(Offset = "0x24")]
		protected Asset<Texture2D> _texture;

		// Token: 0x04009148 RID: 37192
		[Token(Token = "0x4009148")]
		[FieldOffset(Offset = "0x28")]
		protected Rectangle _frame;

		// Token: 0x04009149 RID: 37193
		[Token(Token = "0x4009149")]
		[FieldOffset(Offset = "0x38")]
		protected Vector2 _origin;

		// Token: 0x0400914A RID: 37194
		[Token(Token = "0x400914A")]
		[FieldOffset(Offset = "0x40")]
		public float Rotation;

		// Token: 0x0400914B RID: 37195
		[Token(Token = "0x400914B")]
		[FieldOffset(Offset = "0x44")]
		public float RotationVelocity;

		// Token: 0x0400914C RID: 37196
		[Token(Token = "0x400914C")]
		[FieldOffset(Offset = "0x48")]
		public float RotationAcceleration;

		// Token: 0x0400914D RID: 37197
		[Token(Token = "0x400914D")]
		[FieldOffset(Offset = "0x4C")]
		public Vector2 Scale;

		// Token: 0x0400914E RID: 37198
		[Token(Token = "0x400914E")]
		[FieldOffset(Offset = "0x54")]
		public Vector2 ScaleVelocity;

		// Token: 0x0400914F RID: 37199
		[Token(Token = "0x400914F")]
		[FieldOffset(Offset = "0x5C")]
		public Vector2 ScaleAcceleration;

		// Token: 0x04009150 RID: 37200
		[Token(Token = "0x4009150")]
		[FieldOffset(Offset = "0x64")]
		public readonly ParticlePool Pool;
	}
}
