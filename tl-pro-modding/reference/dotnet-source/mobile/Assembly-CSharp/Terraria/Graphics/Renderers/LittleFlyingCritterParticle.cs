using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008CF RID: 2255
	[Token(Token = "0x20008CF")]
	public class LittleFlyingCritterParticle : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06004C2F RID: 19503 RVA: 0x00024060 File Offset: 0x00022260
		// (set) Token: 0x06004C30 RID: 19504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700093A")]
		public bool ShouldBeRemovedFromRenderer
		{
			[Token(Token = "0x6004C2F")]
			[Address(RVA = "0x6EC124", Offset = "0x6EC124", VA = "0x6EC124", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004C30")]
			[Address(RVA = "0x6EC12C", Offset = "0x6EC12C", VA = "0x6EC12C")]
			private set
			{
			}
		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C31")]
		[Address(RVA = "0x6EC134", Offset = "0x6EC134", VA = "0x6EC134")]
		public LittleFlyingCritterParticle(ParticlePool pool)
		{
		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C32")]
		[Address(RVA = "0x6EC150", Offset = "0x6EC150", VA = "0x6EC150")]
		public void Prepare(LittleFlyingCritterParticle.FlyType type, Vector2 position, int duration, [Optional] Color overrideColor, int repelLifetimeDecay = 0)
		{
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C33")]
		[Address(RVA = "0x6EC368", Offset = "0x6EC368", VA = "0x6EC368")]
		private void RandomizeVelocity()
		{
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C34")]
		[Address(RVA = "0x6EC438", Offset = "0x6EC438", VA = "0x6EC438", Slot = "4")]
		public void RestInPool()
		{
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C35")]
		[Address(RVA = "0x6EC4A0", Offset = "0x6EC4A0", VA = "0x6EC4A0", Slot = "10")]
		public virtual void FetchFromPool()
		{
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C36")]
		[Address(RVA = "0x6EC560", Offset = "0x6EC560", VA = "0x6EC560", Slot = "7")]
		public void Update(ref ParticleRendererSettings settings)
		{
		}

		// Token: 0x06004C37 RID: 19511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C37")]
		[Address(RVA = "0x6EC940", Offset = "0x6EC940", VA = "0x6EC940", Slot = "8")]
		public void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C38")]
		[Address(RVA = "0x6ED2F4", Offset = "0x6ED2F4", VA = "0x6ED2F4")]
		private void Draw_ButterFly(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C39")]
		[Address(RVA = "0x6ECACC", Offset = "0x6ECACC", VA = "0x6ECACC")]
		private void Draw_Fly(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3A")]
		[Address(RVA = "0x6ED828", Offset = "0x6ED828", VA = "0x6ED828", Slot = "9")]
		public void BeRepelled(ref ParticleRepelDetails details)
		{
		}

		// Token: 0x040090F9 RID: 37113
		[Token(Token = "0x40090F9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int _lifeTimeCounted;

		// Token: 0x040090FA RID: 37114
		[Token(Token = "0x40090FA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int _lifeTimeTotal;

		// Token: 0x040090FB RID: 37115
		[Token(Token = "0x40090FB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ParticlePool Pool;

		// Token: 0x040090FC RID: 37116
		[Token(Token = "0x40090FC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool <ShouldBeRemovedFromRenderer>k__BackingField;

		// Token: 0x040090FD RID: 37117
		[Token(Token = "0x40090FD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2 _spawnPosition;

		// Token: 0x040090FE RID: 37118
		[Token(Token = "0x40090FE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector2 _localPosition;

		// Token: 0x040090FF RID: 37119
		[Token(Token = "0x40090FF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector2 _velocity;

		// Token: 0x04009100 RID: 37120
		[Token(Token = "0x4009100")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _neverGoBelowThis;

		// Token: 0x04009101 RID: 37121
		[Token(Token = "0x4009101")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector2 _addedVelocity;

		// Token: 0x04009102 RID: 37122
		[Token(Token = "0x4009102")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _repelLifetimeDecay;

		// Token: 0x04009103 RID: 37123
		[Token(Token = "0x4009103")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color _overrideColor;

		// Token: 0x04009104 RID: 37124
		[Token(Token = "0x4009104")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private LittleFlyingCritterParticle.FlyType _type;

		// Token: 0x04009105 RID: 37125
		[Token(Token = "0x4009105")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _variantRow;

		// Token: 0x04009106 RID: 37126
		[Token(Token = "0x4009106")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _variantColumn;

		// Token: 0x020008D0 RID: 2256
		[Token(Token = "0x20008D0")]
		public enum FlyType
		{
			// Token: 0x04009108 RID: 37128
			[Token(Token = "0x4009108")]
			RegularFly,
			// Token: 0x04009109 RID: 37129
			[Token(Token = "0x4009109")]
			ButterFly
		}
	}
}
