using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008CE RID: 2254
	[Token(Token = "0x20008CE")]
	public class StormLightningParticle : FileAPI, GUIControllerItem
	{
		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06004C1F RID: 19487 RVA: 0x00024000 File Offset: 0x00022200
		// (set) Token: 0x06004C20 RID: 19488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000936")]
		public bool ShouldBeRemovedFromRenderer
		{
			[Token(Token = "0x6004C1F")]
			[Address(RVA = "0x6E98D8", Offset = "0x6E98D8", VA = "0x6E98D8", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004C20")]
			[Address(RVA = "0x6E98E0", Offset = "0x6E98E0", VA = "0x6E98E0")]
			private set
			{
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06004C21 RID: 19489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000937")]
		private LightningGenerator.Bolt MainBolt
		{
			[Token(Token = "0x6004C21")]
			[Address(RVA = "0x6E98E8", Offset = "0x6E98E8", VA = "0x6E98E8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06004C22 RID: 19490 RVA: 0x00024018 File Offset: 0x00022218
		[Token(Token = "0x17000938")]
		public Vector2 EndPosition
		{
			[Token(Token = "0x6004C22")]
			[Address(RVA = "0x6E993C", Offset = "0x6E993C", VA = "0x6E993C")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06004C23 RID: 19491 RVA: 0x00024030 File Offset: 0x00022230
		// (set) Token: 0x06004C24 RID: 19492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000939")]
		public bool IsRestingInPool
		{
			[Token(Token = "0x6004C23")]
			[Address(RVA = "0x6E9A00", Offset = "0x6E9A00", VA = "0x6E9A00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004C24")]
			[Address(RVA = "0x6E9A08", Offset = "0x6E9A08", VA = "0x6E9A08")]
			private set
			{
			}
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C25")]
		[Address(RVA = "0x6E9A10", Offset = "0x6E9A10", VA = "0x6E9A10", Slot = "4")]
		public void RestInPool()
		{
		}

		// Token: 0x06004C26 RID: 19494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C26")]
		[Address(RVA = "0x6E9A80", Offset = "0x6E9A80", VA = "0x6E9A80")]
		public StormLightningParticle(ParticlePool pool)
		{
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C27")]
		[Address(RVA = "0x6E9B30", Offset = "0x6E9B30", VA = "0x6E9B30", Slot = "9")]
		public virtual void FetchFromPool()
		{
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C28")]
		[Address(RVA = "0x6E9BC8", Offset = "0x6E9BC8", VA = "0x6E9BC8")]
		public void Prepare(LightningGenerator generator, uint seed, Vector2 sourcePosition, Vector2 targetPosition, int lifeTimeTotal, Color color, float width, float intensity, StormLightningDrawer.AnimParams animParams, int anchorToPlayer, bool steadyLight)
		{
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C29")]
		[Address(RVA = "0x6E9F0C", Offset = "0x6E9F0C", VA = "0x6E9F0C")]
		public void Prepare(LightningGenerator generator, uint seed, Vector2 targetPosition, int lifeTimeTotal, Color color, float width, StormLightningDrawer.AnimParams animParams)
		{
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C2A")]
		[Address(RVA = "0x6E9D80", Offset = "0x6E9D80", VA = "0x6E9D80")]
		private void _Prepare(LightningGenerator generator, uint seed, Vector2 targetPosition, Vector2? fromDirection, int lifeTimeTotal, Color color, float width, float intensity, StormLightningDrawer.AnimParams animParams, int? anchorToPlayerHand, bool steadyLight)
		{
		}

		// Token: 0x06004C2B RID: 19499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C2B")]
		[Address(RVA = "0x6E9FA0", Offset = "0x6E9FA0", VA = "0x6E9FA0")]
		private void EmitSpawnDust(uint seed, Color color, LightningGenerator.Bolt mainBolt)
		{
		}

		// Token: 0x06004C2C RID: 19500 RVA: 0x00024048 File Offset: 0x00022248
		[Token(Token = "0x6004C2C")]
		[Address(RVA = "0x6EA7BC", Offset = "0x6EA7BC", VA = "0x6EA7BC")]
		public static Vector2 GetPlayerAnchorPos(Player player)
		{
			return default(Vector2);
		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C2D")]
		[Address(RVA = "0x6EA8B4", Offset = "0x6EA8B4", VA = "0x6EA8B4", Slot = "7")]
		public void Update(ref ParticleRendererSettings settings)
		{
		}

		// Token: 0x06004C2E RID: 19502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C2E")]
		[Address(RVA = "0x6EB830", Offset = "0x6EB830", VA = "0x6EB830", Slot = "8")]
		public void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
		}

		// Token: 0x040090ED RID: 37101
		[Token(Token = "0x40090ED")]
		[FieldOffset(Offset = "0x8")]
		private bool <ShouldBeRemovedFromRenderer>k__BackingField;

		// Token: 0x040090EE RID: 37102
		[Token(Token = "0x40090EE")]
		[FieldOffset(Offset = "0x9")]
		public Color Color;

		// Token: 0x040090EF RID: 37103
		[Token(Token = "0x40090EF")]
		[FieldOffset(Offset = "0x10")]
		public float Width;

		// Token: 0x040090F0 RID: 37104
		[Token(Token = "0x40090F0")]
		[FieldOffset(Offset = "0x14")]
		private ParticlePool Pool;

		// Token: 0x040090F1 RID: 37105
		[Token(Token = "0x40090F1")]
		[FieldOffset(Offset = "0x18")]
		private List<LightningGenerator.Bolt> bolts;

		// Token: 0x040090F2 RID: 37106
		[Token(Token = "0x40090F2")]
		[FieldOffset(Offset = "0x1C")]
		private bool <IsRestingInPool>k__BackingField;

		// Token: 0x040090F3 RID: 37107
		[Token(Token = "0x40090F3")]
		[FieldOffset(Offset = "0x20")]
		public int AnchorToPlayerHand;

		// Token: 0x040090F4 RID: 37108
		[Token(Token = "0x40090F4")]
		[FieldOffset(Offset = "0x24")]
		private float Intensity;

		// Token: 0x040090F5 RID: 37109
		[Token(Token = "0x40090F5")]
		[FieldOffset(Offset = "0x28")]
		private bool SteadyLight;

		// Token: 0x040090F6 RID: 37110
		[Token(Token = "0x40090F6")]
		[FieldOffset(Offset = "0x2C")]
		private int _lifeTimeCounted;

		// Token: 0x040090F7 RID: 37111
		[Token(Token = "0x40090F7")]
		[FieldOffset(Offset = "0x30")]
		private int _lifeTimeTotal;

		// Token: 0x040090F8 RID: 37112
		[Token(Token = "0x40090F8")]
		[FieldOffset(Offset = "0x34")]
		private StormLightningDrawer.AnimParams _animParams;
	}
}
