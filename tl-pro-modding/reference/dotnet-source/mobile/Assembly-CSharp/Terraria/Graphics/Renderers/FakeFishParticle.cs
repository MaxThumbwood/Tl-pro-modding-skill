using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008D1 RID: 2257
	[Token(Token = "0x20008D1")]
	public class FakeFishParticle : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06004C3B RID: 19515 RVA: 0x00024078 File Offset: 0x00022278
		// (set) Token: 0x06004C3C RID: 19516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700093B")]
		public bool ShouldBeRemovedFromRenderer
		{
			[Token(Token = "0x6004C3B")]
			[Address(RVA = "0x6EDA70", Offset = "0x6EDA70", VA = "0x6EDA70", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004C3C")]
			[Address(RVA = "0x6EDA78", Offset = "0x6EDA78", VA = "0x6EDA78")]
			private set
			{
			}
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3D")]
		[Address(RVA = "0x6EDA80", Offset = "0x6EDA80", VA = "0x6EDA80")]
		public FakeFishParticle(ParticlePool pool)
		{
		}

		// Token: 0x06004C3E RID: 19518 RVA: 0x00024090 File Offset: 0x00022290
		[Token(Token = "0x6004C3E")]
		[Address(RVA = "0x6EDB0C", Offset = "0x6EDB0C", VA = "0x6EDB0C")]
		public bool TryToMagnetizeTo(Projectile projectile, int requiredItemType = -1)
		{
			return default(bool);
		}

		// Token: 0x06004C3F RID: 19519 RVA: 0x000240A8 File Offset: 0x000222A8
		[Token(Token = "0x6004C3F")]
		[Address(RVA = "0x6EE2BC", Offset = "0x6EE2BC", VA = "0x6EE2BC")]
		public bool TryToPushAway(Projectile projectile, int requiredItemType = -1)
		{
			return default(bool);
		}

		// Token: 0x06004C40 RID: 19520 RVA: 0x000240C0 File Offset: 0x000222C0
		[Token(Token = "0x6004C40")]
		[Address(RVA = "0x6EE504", Offset = "0x6EE504", VA = "0x6EE504")]
		public bool TryToBePinged(Projectile projectile, int requiredItemType = -1)
		{
			return default(bool);
		}

		// Token: 0x06004C41 RID: 19521 RVA: 0x000240D8 File Offset: 0x000222D8
		[Token(Token = "0x6004C41")]
		[Address(RVA = "0x6EDB88", Offset = "0x6EDB88", VA = "0x6EDB88")]
		public bool CanHit(Projectile projectile, int requiredItemType = -1, float allowedRange = 80f)
		{
			return default(bool);
		}

		// Token: 0x06004C42 RID: 19522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C42")]
		[Address(RVA = "0x6EE6E0", Offset = "0x6EE6E0", VA = "0x6EE6E0")]
		private void CheckLatch()
		{
		}

		// Token: 0x06004C43 RID: 19523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C43")]
		[Address(RVA = "0x6EE908", Offset = "0x6EE908", VA = "0x6EE908")]
		private void RemoveLatch()
		{
		}

		// Token: 0x06004C44 RID: 19524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C44")]
		[Address(RVA = "0x6EECDC", Offset = "0x6EECDC", VA = "0x6EECDC")]
		private void EmitWaterPulse()
		{
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C45")]
		[Address(RVA = "0x6EF0B8", Offset = "0x6EF0B8", VA = "0x6EF0B8")]
		private void DoStandardWaterSplash(Vector2 castPosition, bool shimmerWet, bool honeyWet, bool lavaWet)
		{
		}

		// Token: 0x06004C46 RID: 19526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C46")]
		[Address(RVA = "0x6EFBA8", Offset = "0x6EFBA8", VA = "0x6EFBA8", Slot = "7")]
		public void Update(ref ParticleRendererSettings settings)
		{
		}

		// Token: 0x06004C47 RID: 19527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C47")]
		[Address(RVA = "0x6EDCE8", Offset = "0x6EDCE8", VA = "0x6EDCE8")]
		private void SetAndGetLatchDetails(out Vector2 idealBobberPosition, out Vector2 idealOffset)
		{
		}

		// Token: 0x06004C48 RID: 19528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C48")]
		[Address(RVA = "0x6EE054", Offset = "0x6EE054", VA = "0x6EE054")]
		private void Rotate(bool instant = false)
		{
		}

		// Token: 0x06004C49 RID: 19529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C49")]
		[Address(RVA = "0x6EE914", Offset = "0x6EE914", VA = "0x6EE914")]
		private void PickNewVelocity()
		{
		}

		// Token: 0x06004C4A RID: 19530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4A")]
		[Address(RVA = "0x6F0A14", Offset = "0x6F0A14", VA = "0x6F0A14")]
		public void Prepare(int itemType, int lifeTimeTotal, Vector2 bobberLocation)
		{
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4B")]
		[Address(RVA = "0x6F0CF4", Offset = "0x6F0CF4", VA = "0x6F0CF4")]
		public void TryJumping()
		{
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4C")]
		[Address(RVA = "0x6F0DC8", Offset = "0x6F0DC8", VA = "0x6F0DC8", Slot = "8")]
		public void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4D")]
		[Address(RVA = "0x6F18E0", Offset = "0x6F18E0", VA = "0x6F18E0", Slot = "4")]
		public void RestInPool()
		{
		}

		// Token: 0x06004C4E RID: 19534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4E")]
		[Address(RVA = "0x6F19BC", Offset = "0x6F19BC", VA = "0x6F19BC", Slot = "10")]
		public virtual void FetchFromPool()
		{
		}

		// Token: 0x06004C4F RID: 19535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4F")]
		[Address(RVA = "0x6F1B5C", Offset = "0x6F1B5C", VA = "0x6F1B5C", Slot = "9")]
		public void BeRepelled(ref ParticleRepelDetails details)
		{
		}

		// Token: 0x0400910A RID: 37130
		[Token(Token = "0x400910A")]
		[FieldOffset(Offset = "0x8")]
		public readonly ParticlePool Pool;

		// Token: 0x0400910B RID: 37131
		[Token(Token = "0x400910B")]
		[FieldOffset(Offset = "0xC")]
		private bool <ShouldBeRemovedFromRenderer>k__BackingField;

		// Token: 0x0400910C RID: 37132
		[Token(Token = "0x400910C")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 Position;

		// Token: 0x0400910D RID: 37133
		[Token(Token = "0x400910D")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 Velocity;

		// Token: 0x0400910E RID: 37134
		[Token(Token = "0x400910E")]
		[FieldOffset(Offset = "0x20")]
		public float Rotation;

		// Token: 0x0400910F RID: 37135
		[Token(Token = "0x400910F")]
		[FieldOffset(Offset = "0x24")]
		public int PlayerWhoSpawned;

		// Token: 0x04009110 RID: 37136
		[Token(Token = "0x4009110")]
		[FieldOffset(Offset = "0x28")]
		private int _latchedProjectileType;

		// Token: 0x04009111 RID: 37137
		[Token(Token = "0x4009111")]
		[FieldOffset(Offset = "0x2C")]
		private Projectile _latchedProjectile;

		// Token: 0x04009112 RID: 37138
		[Token(Token = "0x4009112")]
		[FieldOffset(Offset = "0x30")]
		private Item _itemInstance;

		// Token: 0x04009113 RID: 37139
		[Token(Token = "0x4009113")]
		[FieldOffset(Offset = "0x34")]
		private int _lifeTimeCounted;

		// Token: 0x04009114 RID: 37140
		[Token(Token = "0x4009114")]
		[FieldOffset(Offset = "0x38")]
		private int _lifeTimeTotal;

		// Token: 0x04009115 RID: 37141
		[Token(Token = "0x4009115")]
		[FieldOffset(Offset = "0x3C")]
		private float _totalScale;

		// Token: 0x04009116 RID: 37142
		[Token(Token = "0x4009116")]
		[FieldOffset(Offset = "0x40")]
		private int _waitTime;

		// Token: 0x04009117 RID: 37143
		[Token(Token = "0x4009117")]
		[FieldOffset(Offset = "0x44")]
		private FakeFishParticle.State _state;

		// Token: 0x04009118 RID: 37144
		[Token(Token = "0x4009118")]
		[FieldOffset(Offset = "0x48")]
		private int _jumpTimeLeft;

		// Token: 0x04009119 RID: 37145
		[Token(Token = "0x4009119")]
		[FieldOffset(Offset = "0x4C")]
		private bool _itemLooksDiagonal;

		// Token: 0x0400911A RID: 37146
		[Token(Token = "0x400911A")]
		[FieldOffset(Offset = "0x50")]
		private Vector2 _targetVelocity;

		// Token: 0x0400911B RID: 37147
		[Token(Token = "0x400911B")]
		[FieldOffset(Offset = "0x58")]
		private Vector2 _bobberLocation;

		// Token: 0x0400911C RID: 37148
		[Token(Token = "0x400911C")]
		[FieldOffset(Offset = "0x60")]
		private int _steerTime;

		// Token: 0x0400911D RID: 37149
		[Token(Token = "0x400911D")]
		[FieldOffset(Offset = "0x64")]
		private bool _isInanimate;

		// Token: 0x0400911E RID: 37150
		[Token(Token = "0x400911E")]
		[FieldOffset(Offset = "0x65")]
		private Color _sonarColor;

		// Token: 0x0400911F RID: 37151
		[Token(Token = "0x400911F")]
		[FieldOffset(Offset = "0x6C")]
		private int _sonarTimeleft;

		// Token: 0x04009120 RID: 37152
		[Token(Token = "0x4009120")]
		[FieldOffset(Offset = "0x70")]
		private int _sonarStartTime;

		// Token: 0x04009121 RID: 37153
		[Token(Token = "0x4009121")]
		[FieldOffset(Offset = "0x74")]
		private bool _isSelectedSonarType;

		// Token: 0x04009122 RID: 37154
		[Token(Token = "0x4009122")]
		[FieldOffset(Offset = "0x75")]
		private bool _wasWet;

		// Token: 0x04009123 RID: 37155
		[Token(Token = "0x4009123")]
		[FieldOffset(Offset = "0x78")]
		private int _delayTime;

		// Token: 0x04009124 RID: 37156
		[Token(Token = "0x4009124")]
		[FieldOffset(Offset = "0x0")]
		public static List<FakeFishParticle> FakeFishParticles;

		// Token: 0x04009125 RID: 37157
		[Token(Token = "0x4009125")]
		[FieldOffset(Offset = "0x7C")]
		private bool _gotRepelled;

		// Token: 0x020008D2 RID: 2258
		[Token(Token = "0x20008D2")]
		private enum State
		{
			// Token: 0x04009127 RID: 37159
			[Token(Token = "0x4009127")]
			FreeRoaming,
			// Token: 0x04009128 RID: 37160
			[Token(Token = "0x4009128")]
			InterestedInBobber,
			// Token: 0x04009129 RID: 37161
			[Token(Token = "0x4009129")]
			Latched,
			// Token: 0x0400912A RID: 37162
			[Token(Token = "0x400912A")]
			Jumping
		}
	}
}
