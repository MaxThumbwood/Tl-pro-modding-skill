using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ReLogic.Utilities;
using Terraria.DataStructures;
using Terraria.GameContent.Ambience;
using Terraria.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000C66 RID: 3174
	[Token(Token = "0x2000C66")]
	public class AmbientSky : CustomSky
	{
		// Token: 0x06005E4B RID: 24139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E4B")]
		[Address(RVA = "0x9BD248", Offset = "0x9BD248", VA = "0x9BD248", Slot = "6")]
		public override void Activate(Vector2 position, object[] args)
		{
		}

		// Token: 0x06005E4C RID: 24140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E4C")]
		[Address(RVA = "0x9BD254", Offset = "0x9BD254", VA = "0x9BD254", Slot = "7")]
		public override void Deactivate(object[] args)
		{
		}

		// Token: 0x06005E4D RID: 24141 RVA: 0x0002BC08 File Offset: 0x00029E08
		[Token(Token = "0x6005E4D")]
		[Address(RVA = "0x9BD260", Offset = "0x9BD260", VA = "0x9BD260")]
		private bool AnActiveSkyConflictsWithAmbience()
		{
			return default(bool);
		}

		// Token: 0x06005E4E RID: 24142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E4E")]
		[Address(RVA = "0x9BD3C8", Offset = "0x9BD3C8", VA = "0x9BD3C8", Slot = "8")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06005E4F RID: 24143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E4F")]
		[Address(RVA = "0x9BDB70", Offset = "0x9BDB70", VA = "0x9BDB70", Slot = "9")]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
		}

		// Token: 0x06005E50 RID: 24144 RVA: 0x0002BC20 File Offset: 0x00029E20
		[Token(Token = "0x6005E50")]
		[Address(RVA = "0x9BE144", Offset = "0x9BE144", VA = "0x9BE144", Slot = "10")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06005E51 RID: 24145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E51")]
		[Address(RVA = "0x9BE14C", Offset = "0x9BE14C", VA = "0x9BE14C", Slot = "11")]
		public override void Reset()
		{
		}

		// Token: 0x06005E52 RID: 24146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E52")]
		[Address(RVA = "0x9BE150", Offset = "0x9BE150", VA = "0x9BE150")]
		public void Spawn(Player player, SkyEntityType type, int seed)
		{
		}

		// Token: 0x06005E53 RID: 24147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E53")]
		[Address(RVA = "0x9C3654", Offset = "0x9C3654", VA = "0x9C3654")]
		public AmbientSky()
		{
		}

		// Token: 0x04009DF3 RID: 40435
		[Token(Token = "0x4009DF3")]
		[FieldOffset(Offset = "0x14")]
		private bool _isActive;

		// Token: 0x04009DF4 RID: 40436
		[Token(Token = "0x4009DF4")]
		[FieldOffset(Offset = "0x18")]
		private readonly SlotVector<AmbientSky.SkyEntity> _entities;

		// Token: 0x04009DF5 RID: 40437
		[Token(Token = "0x4009DF5")]
		[FieldOffset(Offset = "0x1C")]
		private int _frameCounter;

		// Token: 0x02000C67 RID: 3175
		[Token(Token = "0x2000C67")]
		private abstract class SkyEntity
		{
			// Token: 0x17000A71 RID: 2673
			// (get) Token: 0x06005E54 RID: 24148 RVA: 0x0002BC38 File Offset: 0x00029E38
			[Token(Token = "0x17000A71")]
			public Rectangle SourceRectangle
			{
				[Token(Token = "0x6005E54")]
				[Address(RVA = "0x9C36F0", Offset = "0x9C36F0", VA = "0x9C36F0")]
				get
				{
					return default(Rectangle);
				}
			}

			// Token: 0x06005E55 RID: 24149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E55")]
			[Address(RVA = "0x9C3738", Offset = "0x9C3738", VA = "0x9C3738")]
			protected void NextFrame()
			{
			}

			// Token: 0x06005E56 RID: 24150
			[Token(Token = "0x6005E56")]
			public abstract Color GetColor(Color backgroundColor);

			// Token: 0x06005E57 RID: 24151
			[Token(Token = "0x6005E57")]
			public abstract void Update(int frameCount);

			// Token: 0x06005E58 RID: 24152 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E58")]
			[Address(RVA = "0x9C3758", Offset = "0x9C3758", VA = "0x9C3758")]
			protected void SetPositionInWorldBasedOnScreenSpace(Vector2 actualWorldSpace)
			{
			}

			// Token: 0x06005E59 RID: 24153
			[Token(Token = "0x6005E59")]
			public abstract Vector2 GetDrawPosition();

			// Token: 0x06005E5A RID: 24154 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E5A")]
			[Address(RVA = "0x9C38D0", Offset = "0x9C38D0", VA = "0x9C38D0", Slot = "7")]
			public virtual void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
			{
			}

			// Token: 0x06005E5B RID: 24155 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E5B")]
			[Address(RVA = "0x9C38EC", Offset = "0x9C38EC", VA = "0x9C38EC")]
			public void CommonDraw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
			{
			}

			// Token: 0x06005E5C RID: 24156 RVA: 0x0002BC50 File Offset: 0x00029E50
			[Token(Token = "0x6005E5C")]
			[Address(RVA = "0x9C3C5C", Offset = "0x9C3C5C", VA = "0x9C3C5C")]
			internal Vector2 GetDrawPositionByDepth()
			{
				return default(Vector2);
			}

			// Token: 0x06005E5D RID: 24157 RVA: 0x0002BC68 File Offset: 0x00029E68
			[Token(Token = "0x6005E5D")]
			[Address(RVA = "0x9C3E14", Offset = "0x9C3E14", VA = "0x9C3E14")]
			internal float Helper_GetOpacityWithAccountingForOceanWaterLine()
			{
				return 0f;
			}

			// Token: 0x06005E5E RID: 24158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E5E")]
			[Address(RVA = "0x9C4028", Offset = "0x9C4028", VA = "0x9C4028")]
			protected SkyEntity()
			{
			}

			// Token: 0x04009DF6 RID: 40438
			[Token(Token = "0x4009DF6")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 Position;

			// Token: 0x04009DF7 RID: 40439
			[Token(Token = "0x4009DF7")]
			[FieldOffset(Offset = "0x10")]
			public Asset<Texture2D> Texture;

			// Token: 0x04009DF8 RID: 40440
			[Token(Token = "0x4009DF8")]
			[FieldOffset(Offset = "0x14")]
			public SpriteFrame Frame;

			// Token: 0x04009DF9 RID: 40441
			[Token(Token = "0x4009DF9")]
			[FieldOffset(Offset = "0x20")]
			public float Depth;

			// Token: 0x04009DFA RID: 40442
			[Token(Token = "0x4009DFA")]
			[FieldOffset(Offset = "0x24")]
			public SpriteEffects Effects;

			// Token: 0x04009DFB RID: 40443
			[Token(Token = "0x4009DFB")]
			[FieldOffset(Offset = "0x28")]
			public bool IsActive;

			// Token: 0x04009DFC RID: 40444
			[Token(Token = "0x4009DFC")]
			[FieldOffset(Offset = "0x2C")]
			public float Rotation;
		}

		// Token: 0x02000C68 RID: 3176
		[Token(Token = "0x2000C68")]
		private class FadingSkyEntity : AmbientSky.SkyEntity
		{
			// Token: 0x06005E5F RID: 24159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E5F")]
			[Address(RVA = "0x9C4040", Offset = "0x9C4040", VA = "0x9C4040")]
			public FadingSkyEntity()
			{
			}

			// Token: 0x06005E60 RID: 24160 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E60")]
			[Address(RVA = "0x9C40A0", Offset = "0x9C40A0", VA = "0x9C40A0", Slot = "5")]
			public override void Update(int frameCount)
			{
			}

			// Token: 0x06005E61 RID: 24161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E61")]
			[Address(RVA = "0x9C42EC", Offset = "0x9C42EC", VA = "0x9C42EC", Slot = "8")]
			public virtual void UpdateVelocity(int frameCount)
			{
			}

			// Token: 0x06005E62 RID: 24162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E62")]
			[Address(RVA = "0x9C41F8", Offset = "0x9C41F8", VA = "0x9C41F8")]
			private void UpdateOpacity(int frameCount)
			{
			}

			// Token: 0x06005E63 RID: 24163 RVA: 0x0002BC80 File Offset: 0x00029E80
			[Token(Token = "0x6005E63")]
			[Address(RVA = "0x9C41C4", Offset = "0x9C41C4", VA = "0x9C41C4")]
			private bool IsMovementDone(int frameCount)
			{
				return default(bool);
			}

			// Token: 0x06005E64 RID: 24164 RVA: 0x0002BC98 File Offset: 0x00029E98
			[Token(Token = "0x6005E64")]
			[Address(RVA = "0x9C42F0", Offset = "0x9C42F0", VA = "0x9C42F0", Slot = "4")]
			public override Color GetColor(Color backgroundColor)
			{
				return default(Color);
			}

			// Token: 0x06005E65 RID: 24165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E65")]
			[Address(RVA = "0x9C43A0", Offset = "0x9C43A0", VA = "0x9C43A0")]
			public void StartFadingOut(int currentFrameCount)
			{
			}

			// Token: 0x06005E66 RID: 24166 RVA: 0x0002BCB0 File Offset: 0x00029EB0
			[Token(Token = "0x6005E66")]
			[Address(RVA = "0x9C43E0", Offset = "0x9C43E0", VA = "0x9C43E0", Slot = "6")]
			public override Vector2 GetDrawPosition()
			{
				return default(Vector2);
			}

			// Token: 0x04009DFD RID: 40445
			[Token(Token = "0x4009DFD")]
			[FieldOffset(Offset = "0x30")]
			protected int LifeTime;

			// Token: 0x04009DFE RID: 40446
			[Token(Token = "0x4009DFE")]
			[FieldOffset(Offset = "0x34")]
			protected Vector2 Velocity;

			// Token: 0x04009DFF RID: 40447
			[Token(Token = "0x4009DFF")]
			[FieldOffset(Offset = "0x3C")]
			protected int FramingSpeed;

			// Token: 0x04009E00 RID: 40448
			[Token(Token = "0x4009E00")]
			[FieldOffset(Offset = "0x40")]
			protected int TimeEntitySpawnedIn;

			// Token: 0x04009E01 RID: 40449
			[Token(Token = "0x4009E01")]
			[FieldOffset(Offset = "0x44")]
			protected float Opacity;

			// Token: 0x04009E02 RID: 40450
			[Token(Token = "0x4009E02")]
			[FieldOffset(Offset = "0x48")]
			protected float BrightnessLerper;

			// Token: 0x04009E03 RID: 40451
			[Token(Token = "0x4009E03")]
			[FieldOffset(Offset = "0x4C")]
			protected float FinalOpacityMultiplier;

			// Token: 0x04009E04 RID: 40452
			[Token(Token = "0x4009E04")]
			[FieldOffset(Offset = "0x50")]
			protected float OpacityNormalizedTimeToFadeIn;

			// Token: 0x04009E05 RID: 40453
			[Token(Token = "0x4009E05")]
			[FieldOffset(Offset = "0x54")]
			protected float OpacityNormalizedTimeToFadeOut;

			// Token: 0x04009E06 RID: 40454
			[Token(Token = "0x4009E06")]
			[FieldOffset(Offset = "0x58")]
			protected int FrameOffset;
		}

		// Token: 0x02000C69 RID: 3177
		[Token(Token = "0x2000C69")]
		private class ButterfliesSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005E67 RID: 24167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E67")]
			[Address(RVA = "0x9C0770", Offset = "0x9C0770", VA = "0x9C0770")]
			public ButterfliesSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005E68 RID: 24168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E68")]
			[Address(RVA = "0x9C43F4", Offset = "0x9C43F4", VA = "0x9C43F4", Slot = "8")]
			public override void UpdateVelocity(int frameCount)
			{
			}

			// Token: 0x06005E69 RID: 24169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E69")]
			[Address(RVA = "0x9C4554", Offset = "0x9C4554", VA = "0x9C4554", Slot = "5")]
			public override void Update(int frameCount)
			{
			}
		}

		// Token: 0x02000C6A RID: 3178
		[Token(Token = "0x2000C6A")]
		private class LostKiteSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005E6A RID: 24170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E6A")]
			[Address(RVA = "0x9C0B40", Offset = "0x9C0B40", VA = "0x9C0B40")]
			public LostKiteSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005E6B RID: 24171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E6B")]
			[Address(RVA = "0x9C4658", Offset = "0x9C4658", VA = "0x9C4658", Slot = "8")]
			public override void UpdateVelocity(int frameCount)
			{
			}

			// Token: 0x06005E6C RID: 24172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E6C")]
			[Address(RVA = "0x9C4814", Offset = "0x9C4814", VA = "0x9C4814", Slot = "5")]
			public override void Update(int frameCount)
			{
			}
		}

		// Token: 0x02000C6B RID: 3179
		[Token(Token = "0x2000C6B")]
		private class PegasusSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005E6D RID: 24173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E6D")]
			[Address(RVA = "0x9C28E0", Offset = "0x9C28E0", VA = "0x9C28E0")]
			public PegasusSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005E6E RID: 24174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E6E")]
			[Address(RVA = "0x9C49EC", Offset = "0x9C49EC", VA = "0x9C49EC", Slot = "8")]
			public override void UpdateVelocity(int frameCount)
			{
			}

			// Token: 0x06005E6F RID: 24175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E6F")]
			[Address(RVA = "0x9C4B48", Offset = "0x9C4B48", VA = "0x9C4B48", Slot = "5")]
			public override void Update(int frameCount)
			{
			}

			// Token: 0x06005E70 RID: 24176 RVA: 0x0002BCC8 File Offset: 0x00029EC8
			[Token(Token = "0x6005E70")]
			[Address(RVA = "0x9C4C4C", Offset = "0x9C4C4C", VA = "0x9C4C4C", Slot = "4")]
			public override Color GetColor(Color backgroundColor)
			{
				return default(Color);
			}
		}

		// Token: 0x02000C6C RID: 3180
		[Token(Token = "0x2000C6C")]
		private class VultureSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005E71 RID: 24177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E71")]
			[Address(RVA = "0x9C0F10", Offset = "0x9C0F10", VA = "0x9C0F10")]
			public VultureSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005E72 RID: 24178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E72")]
			[Address(RVA = "0x9C4D20", Offset = "0x9C4D20", VA = "0x9C4D20", Slot = "8")]
			public override void UpdateVelocity(int frameCount)
			{
			}

			// Token: 0x06005E73 RID: 24179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E73")]
			[Address(RVA = "0x9C4E7C", Offset = "0x9C4E7C", VA = "0x9C4E7C", Slot = "5")]
			public override void Update(int frameCount)
			{
			}

			// Token: 0x06005E74 RID: 24180 RVA: 0x0002BCE0 File Offset: 0x00029EE0
			[Token(Token = "0x6005E74")]
			[Address(RVA = "0x9C4F80", Offset = "0x9C4F80", VA = "0x9C4F80", Slot = "4")]
			public override Color GetColor(Color backgroundColor)
			{
				return default(Color);
			}
		}

		// Token: 0x02000C6D RID: 3181
		[Token(Token = "0x2000C6D")]
		private class PixiePosseSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005E75 RID: 24181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E75")]
			[Address(RVA = "0x9C1290", Offset = "0x9C1290", VA = "0x9C1290")]
			public PixiePosseSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005E76 RID: 24182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E76")]
			[Address(RVA = "0x9C510C", Offset = "0x9C510C", VA = "0x9C510C", Slot = "8")]
			public override void UpdateVelocity(int frameCount)
			{
			}

			// Token: 0x06005E77 RID: 24183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E77")]
			[Address(RVA = "0x9C526C", Offset = "0x9C526C", VA = "0x9C526C", Slot = "5")]
			public override void Update(int frameCount)
			{
			}

			// Token: 0x06005E78 RID: 24184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E78")]
			[Address(RVA = "0x9C5428", Offset = "0x9C5428", VA = "0x9C5428", Slot = "7")]
			public override void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
			{
			}

			// Token: 0x04009E07 RID: 40455
			[Token(Token = "0x4009E07")]
			[FieldOffset(Offset = "0x5C")]
			private int pixieType;
		}

		// Token: 0x02000C6E RID: 3182
		[Token(Token = "0x2000C6E")]
		private class BirdsPackSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005E79 RID: 24185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E79")]
			[Address(RVA = "0x9BF340", Offset = "0x9BF340", VA = "0x9BF340")]
			public BirdsPackSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005E7A RID: 24186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E7A")]
			[Address(RVA = "0x9C5458", Offset = "0x9C5458", VA = "0x9C5458", Slot = "8")]
			public override void UpdateVelocity(int frameCount)
			{
			}

			// Token: 0x06005E7B RID: 24187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E7B")]
			[Address(RVA = "0x9C55B4", Offset = "0x9C55B4", VA = "0x9C55B4", Slot = "5")]
			public override void Update(int frameCount)
			{
			}
		}

		// Token: 0x02000C6F RID: 3183
		[Token(Token = "0x2000C6F")]
		private class SeagullsGroupSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005E7C RID: 24188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E7C")]
			[Address(RVA = "0x9C56C0", Offset = "0x9C56C0", VA = "0x9C56C0")]
			public SeagullsGroupSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005E7D RID: 24189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E7D")]
			[Address(RVA = "0x9C5A98", Offset = "0x9C5A98", VA = "0x9C5A98", Slot = "8")]
			public override void UpdateVelocity(int frameCount)
			{
			}

			// Token: 0x06005E7E RID: 24190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E7E")]
			[Address(RVA = "0x9C5C94", Offset = "0x9C5C94", VA = "0x9C5C94", Slot = "5")]
			public override void Update(int frameCount)
			{
			}

			// Token: 0x06005E7F RID: 24191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E7F")]
			[Address(RVA = "0x9C5D98", Offset = "0x9C5D98", VA = "0x9C5D98")]
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
			}

			// Token: 0x06005E80 RID: 24192 RVA: 0x0002BCF8 File Offset: 0x00029EF8
			[Token(Token = "0x6005E80")]
			[Address(RVA = "0x9C5DA8", Offset = "0x9C5DA8", VA = "0x9C5DA8", Slot = "4")]
			public override Color GetColor(Color backgroundColor)
			{
				return default(Color);
			}

			// Token: 0x06005E81 RID: 24193 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E81")]
			[Address(RVA = "0x9C5E7C", Offset = "0x9C5E7C", VA = "0x9C5E7C", Slot = "7")]
			public override void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
			{
			}

			// Token: 0x06005E82 RID: 24194 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005E82")]
			[Address(RVA = "0x9C1654", Offset = "0x9C1654", VA = "0x9C1654")]
			public static List<AmbientSky.SeagullsGroupSkyEntity> CreateGroup(Player player, FastRandom random)
			{
				return null;
			}

			// Token: 0x04009E08 RID: 40456
			[Token(Token = "0x4009E08")]
			[FieldOffset(Offset = "0x5C")]
			private Vector2 _magnetAccelerations;

			// Token: 0x04009E09 RID: 40457
			[Token(Token = "0x4009E09")]
			[FieldOffset(Offset = "0x64")]
			private Vector2 _magnetPointTarget;

			// Token: 0x04009E0A RID: 40458
			[Token(Token = "0x4009E0A")]
			[FieldOffset(Offset = "0x6C")]
			private Vector2 _positionVsMagnet;

			// Token: 0x04009E0B RID: 40459
			[Token(Token = "0x4009E0B")]
			[FieldOffset(Offset = "0x74")]
			private Vector2 _velocityVsMagnet;
		}

		// Token: 0x02000C70 RID: 3184
		[Token(Token = "0x2000C70")]
		private class GastropodGroupSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005E83 RID: 24195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E83")]
			[Address(RVA = "0x9C5EB0", Offset = "0x9C5EB0", VA = "0x9C5EB0")]
			public GastropodGroupSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005E84 RID: 24196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E84")]
			[Address(RVA = "0x9C6238", Offset = "0x9C6238", VA = "0x9C6238", Slot = "8")]
			public override void UpdateVelocity(int frameCount)
			{
			}

			// Token: 0x06005E85 RID: 24197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E85")]
			[Address(RVA = "0x9C64E4", Offset = "0x9C64E4", VA = "0x9C64E4", Slot = "5")]
			public override void Update(int frameCount)
			{
			}

			// Token: 0x06005E86 RID: 24198 RVA: 0x0002BD10 File Offset: 0x00029F10
			[Token(Token = "0x6005E86")]
			[Address(RVA = "0x9C6630", Offset = "0x9C6630", VA = "0x9C6630", Slot = "4")]
			public override Color GetColor(Color backgroundColor)
			{
				return default(Color);
			}

			// Token: 0x06005E87 RID: 24199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E87")]
			[Address(RVA = "0x9C6708", Offset = "0x9C6708", VA = "0x9C6708", Slot = "7")]
			public override void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
			{
			}

			// Token: 0x06005E88 RID: 24200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E88")]
			[Address(RVA = "0x9C6738", Offset = "0x9C6738", VA = "0x9C6738")]
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
			}

			// Token: 0x06005E89 RID: 24201 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005E89")]
			[Address(RVA = "0x9C22B8", Offset = "0x9C22B8", VA = "0x9C22B8")]
			public static List<AmbientSky.GastropodGroupSkyEntity> CreateGroup(Player player, FastRandom random)
			{
				return null;
			}

			// Token: 0x04009E0C RID: 40460
			[Token(Token = "0x4009E0C")]
			[FieldOffset(Offset = "0x5C")]
			private Vector2 _magnetAccelerations;

			// Token: 0x04009E0D RID: 40461
			[Token(Token = "0x4009E0D")]
			[FieldOffset(Offset = "0x64")]
			private Vector2 _magnetPointTarget;

			// Token: 0x04009E0E RID: 40462
			[Token(Token = "0x4009E0E")]
			[FieldOffset(Offset = "0x6C")]
			private Vector2 _positionVsMagnet;

			// Token: 0x04009E0F RID: 40463
			[Token(Token = "0x4009E0F")]
			[FieldOffset(Offset = "0x74")]
			private Vector2 _velocityVsMagnet;
		}

		// Token: 0x02000C71 RID: 3185
		[Token(Token = "0x2000C71")]
		private class SlimeBalloonGroupSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005E8A RID: 24202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E8A")]
			[Address(RVA = "0x9C6750", Offset = "0x9C6750", VA = "0x9C6750")]
			public SlimeBalloonGroupSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005E8B RID: 24203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E8B")]
			[Address(RVA = "0x9C6AE8", Offset = "0x9C6AE8", VA = "0x9C6AE8", Slot = "8")]
			public override void UpdateVelocity(int frameCount)
			{
			}

			// Token: 0x06005E8C RID: 24204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E8C")]
			[Address(RVA = "0x9C6D8C", Offset = "0x9C6D8C", VA = "0x9C6D8C", Slot = "5")]
			public override void Update(int frameCount)
			{
			}

			// Token: 0x06005E8D RID: 24205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E8D")]
			[Address(RVA = "0x9C6F84", Offset = "0x9C6F84", VA = "0x9C6F84")]
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
			}

			// Token: 0x06005E8E RID: 24206 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005E8E")]
			[Address(RVA = "0x9C1C8C", Offset = "0x9C1C8C", VA = "0x9C1C8C")]
			public static List<AmbientSky.SlimeBalloonGroupSkyEntity> CreateGroup(Player player, FastRandom random)
			{
				return null;
			}

			// Token: 0x04009E10 RID: 40464
			[Token(Token = "0x4009E10")]
			[FieldOffset(Offset = "0x5C")]
			private Vector2 _magnetAccelerations;

			// Token: 0x04009E11 RID: 40465
			[Token(Token = "0x4009E11")]
			[FieldOffset(Offset = "0x64")]
			private Vector2 _magnetPointTarget;

			// Token: 0x04009E12 RID: 40466
			[Token(Token = "0x4009E12")]
			[FieldOffset(Offset = "0x6C")]
			private Vector2 _positionVsMagnet;

			// Token: 0x04009E13 RID: 40467
			[Token(Token = "0x4009E13")]
			[FieldOffset(Offset = "0x74")]
			private Vector2 _velocityVsMagnet;
		}

		// Token: 0x02000C72 RID: 3186
		[Token(Token = "0x2000C72")]
		private class HellBatsGoupSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005E8F RID: 24207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E8F")]
			[Address(RVA = "0x9C6FA0", Offset = "0x9C6FA0", VA = "0x9C6FA0")]
			public HellBatsGoupSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005E90 RID: 24208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E90")]
			[Address(RVA = "0x9C73A0", Offset = "0x9C73A0", VA = "0x9C73A0", Slot = "8")]
			public override void UpdateVelocity(int frameCount)
			{
			}

			// Token: 0x06005E91 RID: 24209 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E91")]
			[Address(RVA = "0x9C7638", Offset = "0x9C7638", VA = "0x9C7638", Slot = "5")]
			public override void Update(int frameCount)
			{
			}

			// Token: 0x06005E92 RID: 24210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E92")]
			[Address(RVA = "0x9C763C", Offset = "0x9C763C", VA = "0x9C763C")]
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
			}

			// Token: 0x06005E93 RID: 24211 RVA: 0x0002BD28 File Offset: 0x00029F28
			[Token(Token = "0x6005E93")]
			[Address(RVA = "0x9C764C", Offset = "0x9C764C", VA = "0x9C764C", Slot = "4")]
			public override Color GetColor(Color backgroundColor)
			{
				return default(Color);
			}

			// Token: 0x06005E94 RID: 24212 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005E94")]
			[Address(RVA = "0x9C3030", Offset = "0x9C3030", VA = "0x9C3030")]
			public static List<AmbientSky.HellBatsGoupSkyEntity> CreateGroup(Player player, FastRandom random)
			{
				return null;
			}

			// Token: 0x06005E95 RID: 24213 RVA: 0x0002BD40 File Offset: 0x00029F40
			[Token(Token = "0x6005E95")]
			[Address(RVA = "0x9C7794", Offset = "0x9C7794", VA = "0x9C7794")]
			internal float Helper_GetOpacityWithAccountingForBackgroundsOff()
			{
				return 0f;
			}

			// Token: 0x04009E14 RID: 40468
			[Token(Token = "0x4009E14")]
			[FieldOffset(Offset = "0x5C")]
			private Vector2 _magnetAccelerations;

			// Token: 0x04009E15 RID: 40469
			[Token(Token = "0x4009E15")]
			[FieldOffset(Offset = "0x64")]
			private Vector2 _magnetPointTarget;

			// Token: 0x04009E16 RID: 40470
			[Token(Token = "0x4009E16")]
			[FieldOffset(Offset = "0x6C")]
			private Vector2 _positionVsMagnet;

			// Token: 0x04009E17 RID: 40471
			[Token(Token = "0x4009E17")]
			[FieldOffset(Offset = "0x74")]
			private Vector2 _velocityVsMagnet;
		}

		// Token: 0x02000C73 RID: 3187
		[Token(Token = "0x2000C73")]
		private class BatsGroupSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005E96 RID: 24214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E96")]
			[Address(RVA = "0x9C7840", Offset = "0x9C7840", VA = "0x9C7840")]
			public BatsGroupSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005E97 RID: 24215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E97")]
			[Address(RVA = "0x9C7C58", Offset = "0x9C7C58", VA = "0x9C7C58", Slot = "8")]
			public override void UpdateVelocity(int frameCount)
			{
			}

			// Token: 0x06005E98 RID: 24216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E98")]
			[Address(RVA = "0x9C7EF0", Offset = "0x9C7EF0", VA = "0x9C7EF0", Slot = "5")]
			public override void Update(int frameCount)
			{
			}

			// Token: 0x06005E99 RID: 24217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E99")]
			[Address(RVA = "0x9C7FF4", Offset = "0x9C7FF4", VA = "0x9C7FF4")]
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
			}

			// Token: 0x06005E9A RID: 24218 RVA: 0x0002BD58 File Offset: 0x00029F58
			[Token(Token = "0x6005E9A")]
			[Address(RVA = "0x9C8004", Offset = "0x9C8004", VA = "0x9C8004", Slot = "4")]
			public override Color GetColor(Color backgroundColor)
			{
				return default(Color);
			}

			// Token: 0x06005E9B RID: 24219 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005E9B")]
			[Address(RVA = "0x9C0138", Offset = "0x9C0138", VA = "0x9C0138")]
			public static List<AmbientSky.BatsGroupSkyEntity> CreateGroup(Player player, FastRandom random)
			{
				return null;
			}

			// Token: 0x04009E18 RID: 40472
			[Token(Token = "0x4009E18")]
			[FieldOffset(Offset = "0x5C")]
			private Vector2 _magnetAccelerations;

			// Token: 0x04009E19 RID: 40473
			[Token(Token = "0x4009E19")]
			[FieldOffset(Offset = "0x64")]
			private Vector2 _magnetPointTarget;

			// Token: 0x04009E1A RID: 40474
			[Token(Token = "0x4009E1A")]
			[FieldOffset(Offset = "0x6C")]
			private Vector2 _positionVsMagnet;

			// Token: 0x04009E1B RID: 40475
			[Token(Token = "0x4009E1B")]
			[FieldOffset(Offset = "0x74")]
			private Vector2 _velocityVsMagnet;
		}

		// Token: 0x02000C74 RID: 3188
		[Token(Token = "0x2000C74")]
		private class WyvernSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005E9C RID: 24220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E9C")]
			[Address(RVA = "0x9BFDC0", Offset = "0x9BFDC0", VA = "0x9BFDC0")]
			public WyvernSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005E9D RID: 24221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E9D")]
			[Address(RVA = "0x9C81E8", Offset = "0x9C81E8", VA = "0x9C81E8", Slot = "8")]
			public override void UpdateVelocity(int frameCount)
			{
			}
		}

		// Token: 0x02000C75 RID: 3189
		[Token(Token = "0x2000C75")]
		private class NormalizedBackgroundLayerSpaceSkyEntity : AmbientSky.SkyEntity
		{
			// Token: 0x06005E9E RID: 24222 RVA: 0x0002BD70 File Offset: 0x00029F70
			[Token(Token = "0x6005E9E")]
			[Address(RVA = "0x9C8344", Offset = "0x9C8344", VA = "0x9C8344", Slot = "4")]
			public override Color GetColor(Color backgroundColor)
			{
				return default(Color);
			}

			// Token: 0x06005E9F RID: 24223 RVA: 0x0002BD88 File Offset: 0x00029F88
			[Token(Token = "0x6005E9F")]
			[Address(RVA = "0x9C83C0", Offset = "0x9C83C0", VA = "0x9C83C0", Slot = "6")]
			public override Vector2 GetDrawPosition()
			{
				return default(Vector2);
			}

			// Token: 0x06005EA0 RID: 24224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EA0")]
			[Address(RVA = "0x9C83D4", Offset = "0x9C83D4", VA = "0x9C83D4", Slot = "5")]
			public override void Update(int frameCount)
			{
			}

			// Token: 0x06005EA1 RID: 24225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EA1")]
			[Address(RVA = "0x9C83D8", Offset = "0x9C83D8", VA = "0x9C83D8")]
			public NormalizedBackgroundLayerSpaceSkyEntity()
			{
			}
		}

		// Token: 0x02000C76 RID: 3190
		[Token(Token = "0x2000C76")]
		private class BoneSerpentSkyEntity : AmbientSky.NormalizedBackgroundLayerSpaceSkyEntity
		{
			// Token: 0x06005EA2 RID: 24226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EA2")]
			[Address(RVA = "0x9C83E8", Offset = "0x9C83E8", VA = "0x9C83E8")]
			public BoneSerpentSkyEntity()
			{
			}
		}

		// Token: 0x02000C77 RID: 3191
		[Token(Token = "0x2000C77")]
		private class AirshipSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005EA3 RID: 24227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EA3")]
			[Address(RVA = "0x9BF010", Offset = "0x9BF010", VA = "0x9BF010")]
			public AirshipSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005EA4 RID: 24228 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EA4")]
			[Address(RVA = "0x9C83F8", Offset = "0x9C83F8", VA = "0x9C83F8", Slot = "8")]
			public override void UpdateVelocity(int frameCount)
			{
			}

			// Token: 0x06005EA5 RID: 24229 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EA5")]
			[Address(RVA = "0x9C8554", Offset = "0x9C8554", VA = "0x9C8554", Slot = "5")]
			public override void Update(int frameCount)
			{
			}
		}

		// Token: 0x02000C78 RID: 3192
		[Token(Token = "0x2000C78")]
		private class AirBalloonSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005EA6 RID: 24230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EA6")]
			[Address(RVA = "0x9BEC60", Offset = "0x9BEC60", VA = "0x9BEC60")]
			public AirBalloonSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005EA7 RID: 24231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EA7")]
			[Address(RVA = "0x9C8658", Offset = "0x9C8658", VA = "0x9C8658", Slot = "8")]
			public override void UpdateVelocity(int frameCount)
			{
			}

			// Token: 0x06005EA8 RID: 24232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EA8")]
			[Address(RVA = "0x9C88B0", Offset = "0x9C88B0", VA = "0x9C88B0", Slot = "5")]
			public override void Update(int frameCount)
			{
			}

			// Token: 0x04009E1C RID: 40476
			[Token(Token = "0x4009E1C")]
			private const int RANDOM_TILE_SPAWN_RANGE = 100;
		}

		// Token: 0x02000C79 RID: 3193
		[Token(Token = "0x2000C79")]
		private class CrimeraSkyEntity : AmbientSky.EOCSkyEntity
		{
			// Token: 0x06005EA9 RID: 24233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EA9")]
			[Address(RVA = "0x9C2E44", Offset = "0x9C2E44", VA = "0x9C2E44")]
			public CrimeraSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005EAA RID: 24234 RVA: 0x0002BDA0 File Offset: 0x00029FA0
			[Token(Token = "0x6005EAA")]
			[Address(RVA = "0x9C89B4", Offset = "0x9C89B4", VA = "0x9C89B4", Slot = "4")]
			public override Color GetColor(Color backgroundColor)
			{
				return default(Color);
			}
		}

		// Token: 0x02000C7A RID: 3194
		[Token(Token = "0x2000C7A")]
		private class EOSSkyEntity : AmbientSky.EOCSkyEntity
		{
			// Token: 0x06005EAB RID: 24235 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EAB")]
			[Address(RVA = "0x9C2C58", Offset = "0x9C2C58", VA = "0x9C2C58")]
			public EOSSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005EAC RID: 24236 RVA: 0x0002BDB8 File Offset: 0x00029FB8
			[Token(Token = "0x6005EAC")]
			[Address(RVA = "0x9C8A88", Offset = "0x9C8A88", VA = "0x9C8A88", Slot = "4")]
			public override Color GetColor(Color backgroundColor)
			{
				return default(Color);
			}
		}

		// Token: 0x02000C7B RID: 3195
		[Token(Token = "0x2000C7B")]
		private class EOCSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005EAD RID: 24237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EAD")]
			[Address(RVA = "0x9BF6C0", Offset = "0x9BF6C0", VA = "0x9BF6C0")]
			public EOCSkyEntity(Player player, FastRandom random)
			{
			}

			// Token: 0x06005EAE RID: 24238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EAE")]
			[Address(RVA = "0x9C8B5C", Offset = "0x9C8B5C", VA = "0x9C8B5C")]
			private void BeginZigZag(ref FastRandom random, VirtualCamera camera, int direction)
			{
			}

			// Token: 0x06005EAF RID: 24239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EAF")]
			[Address(RVA = "0x9C8C50", Offset = "0x9C8C50", VA = "0x9C8C50")]
			private void BeginChasingPlayer(ref FastRandom random, VirtualCamera camera)
			{
			}

			// Token: 0x06005EB0 RID: 24240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EB0")]
			[Address(RVA = "0x9C8D9C", Offset = "0x9C8D9C", VA = "0x9C8D9C", Slot = "8")]
			public override void UpdateVelocity(int frameCount)
			{
			}

			// Token: 0x06005EB1 RID: 24241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EB1")]
			[Address(RVA = "0x9C8F08", Offset = "0x9C8F08", VA = "0x9C8F08")]
			private void ZigzagMove(int frameCount)
			{
			}

			// Token: 0x06005EB2 RID: 24242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EB2")]
			[Address(RVA = "0x9C8FE8", Offset = "0x9C8FE8", VA = "0x9C8FE8")]
			private void ChasePlayerTop(int frameCount)
			{
			}

			// Token: 0x04009E1D RID: 40477
			[Token(Token = "0x4009E1D")]
			private const int STATE_ZIGZAG = 1;

			// Token: 0x04009E1E RID: 40478
			[Token(Token = "0x4009E1E")]
			private const int STATE_GOOVERPLAYER = 2;

			// Token: 0x04009E1F RID: 40479
			[Token(Token = "0x4009E1F")]
			[FieldOffset(Offset = "0x5C")]
			private int _state;

			// Token: 0x04009E20 RID: 40480
			[Token(Token = "0x4009E20")]
			[FieldOffset(Offset = "0x60")]
			private int _direction;

			// Token: 0x04009E21 RID: 40481
			[Token(Token = "0x4009E21")]
			[FieldOffset(Offset = "0x64")]
			private float _waviness;
		}

		// Token: 0x02000C7C RID: 3196
		[Token(Token = "0x2000C7C")]
		private class MeteorSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005EB3 RID: 24243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EB3")]
			[Address(RVA = "0x9BF940", Offset = "0x9BF940", VA = "0x9BF940")]
			public MeteorSkyEntity(Player player, FastRandom random)
			{
			}
		}

		// Token: 0x02000C7D RID: 3197
		// (Invoke) Token: 0x06005EB5 RID: 24245
		[Token(Token = "0x2000C7D")]
		private delegate AmbientSky.SkyEntity EntityFactoryMethod(Player player, int seed);
	}
}
