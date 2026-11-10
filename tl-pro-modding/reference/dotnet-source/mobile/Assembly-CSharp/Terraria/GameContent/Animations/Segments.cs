using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.Localization;

namespace Terraria.GameContent.Animations
{
	// Token: 0x02000C47 RID: 3143
	[Token(Token = "0x2000C47")]
	public class Segments
	{
		// Token: 0x06005D8F RID: 23951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D8F")]
		[Address(RVA = "0x9ACAEC", Offset = "0x9ACAEC", VA = "0x9ACAEC")]
		public Segments()
		{
		}

		// Token: 0x04009D90 RID: 40336
		[Token(Token = "0x4009D90")]
		private const float PixelsToRollUpPerFrame = 0.75f;

		// Token: 0x02000C48 RID: 3144
		[Token(Token = "0x2000C48")]
		public class LocalizedTextSegment : FileAPI
		{
			// Token: 0x17000A69 RID: 2665
			// (get) Token: 0x06005D90 RID: 23952 RVA: 0x0002BAB8 File Offset: 0x00029CB8
			[Token(Token = "0x17000A69")]
			public float DedicatedTimeNeeded
			{
				[Token(Token = "0x6005D90")]
				[Address(RVA = "0x9ACAF4", Offset = "0x9ACAF4", VA = "0x9ACAF4", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06005D91 RID: 23953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D91")]
			[Address(RVA = "0x9ACB00", Offset = "0x9ACB00", VA = "0x9ACB00")]
			public LocalizedTextSegment(float timeInAnimation, string textKey)
			{
			}

			// Token: 0x06005D92 RID: 23954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D92")]
			[Address(RVA = "0x9ACB90", Offset = "0x9ACB90", VA = "0x9ACB90")]
			public LocalizedTextSegment(float timeInAnimation, LocalizedText textObject, Vector2 anchorOffset)
			{
			}

			// Token: 0x06005D93 RID: 23955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D93")]
			[Address(RVA = "0x9ACBC4", Offset = "0x9ACBC4", VA = "0x9ACBC4", Slot = "5")]
			public void Draw(ref GameAnimationSegment info)
			{
			}

			// Token: 0x04009D91 RID: 40337
			[Token(Token = "0x4009D91")]
			private const int PixelsForALine = 120;

			// Token: 0x04009D92 RID: 40338
			[Token(Token = "0x4009D92")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private LocalizedText _text;

			// Token: 0x04009D93 RID: 40339
			[Token(Token = "0x4009D93")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private float _timeToShowPeak;

			// Token: 0x04009D94 RID: 40340
			[Token(Token = "0x4009D94")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector2 _anchorOffset;
		}

		// Token: 0x02000C49 RID: 3145
		[Token(Token = "0x2000C49")]
		public abstract class AnimationSegmentWithActions<T> : FileAPI
		{
			// Token: 0x17000A6A RID: 2666
			// (get) Token: 0x06005D94 RID: 23956 RVA: 0x0002BAD0 File Offset: 0x00029CD0
			[Token(Token = "0x17000A6A")]
			public float DedicatedTimeNeeded
			{
				[Token(Token = "0x6005D94")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06005D95 RID: 23957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D95")]
			public AnimationSegmentWithActions(int targetTime)
			{
			}

			// Token: 0x06005D96 RID: 23958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D96")]
			protected void ProcessActions(T obj, float localTimeForObject)
			{
			}

			// Token: 0x06005D97 RID: 23959 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005D97")]
			public Segments.AnimationSegmentWithActions<T> Then(IAnimationSegmentAction<T> act)
			{
				return null;
			}

			// Token: 0x06005D98 RID: 23960 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005D98")]
			public Segments.AnimationSegmentWithActions<T> With(IAnimationSegmentAction<T> act)
			{
				return null;
			}

			// Token: 0x06005D99 RID: 23961
			[Token(Token = "0x6005D99")]
			protected abstract void Bind(IAnimationSegmentAction<T> act);

			// Token: 0x06005D9A RID: 23962
			[Token(Token = "0x6005D9A")]
			public abstract void Draw(ref GameAnimationSegment info);

			// Token: 0x04009D95 RID: 40341
			[Token(Token = "0x4009D95")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _dedicatedTimeNeeded;

			// Token: 0x04009D96 RID: 40342
			[Token(Token = "0x4009D96")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _lastDedicatedTimeNeeded;

			// Token: 0x04009D97 RID: 40343
			[Token(Token = "0x4009D97")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int _targetTime;

			// Token: 0x04009D98 RID: 40344
			[Token(Token = "0x4009D98")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private List<IAnimationSegmentAction<T>> _actions;
		}

		// Token: 0x02000C4A RID: 3146
		[Token(Token = "0x2000C4A")]
		public class PlayerSegment : Segments.AnimationSegmentWithActions<Player>
		{
			// Token: 0x06005D9B RID: 23963 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D9B")]
			[Address(RVA = "0x9AD0E8", Offset = "0x9AD0E8", VA = "0x9AD0E8")]
			public PlayerSegment(int targetTime, Vector2 anchorOffset, Vector2 normalizedHitboxOrigin)
			{
			}

			// Token: 0x06005D9C RID: 23964 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005D9C")]
			[Address(RVA = "0x9AD1A8", Offset = "0x9AD1A8", VA = "0x9AD1A8")]
			public Segments.PlayerSegment UseShaderEffect(Segments.PlayerSegment.IShaderEffect shaderEffect)
			{
				return null;
			}

			// Token: 0x06005D9D RID: 23965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D9D")]
			[Address(RVA = "0x9AD1B0", Offset = "0x9AD1B0", VA = "0x9AD1B0", Slot = "6")]
			protected override void Bind(IAnimationSegmentAction<Player> act)
			{
			}

			// Token: 0x06005D9E RID: 23966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D9E")]
			[Address(RVA = "0x9AD270", Offset = "0x9AD270", VA = "0x9AD270", Slot = "7")]
			public override void Draw(ref GameAnimationSegment info)
			{
			}

			// Token: 0x06005D9F RID: 23967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D9F")]
			[Address(RVA = "0x9AD970", Offset = "0x9AD970", VA = "0x9AD970")]
			private void ResetPlayerAnimation(ref GameAnimationSegment info)
			{
			}

			// Token: 0x04009D99 RID: 40345
			[Token(Token = "0x4009D99")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Player _player;

			// Token: 0x04009D9A RID: 40346
			[Token(Token = "0x4009D9A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Vector2 _anchorOffset;

			// Token: 0x04009D9B RID: 40347
			[Token(Token = "0x4009D9B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Vector2 _normalizedOriginForHitbox;

			// Token: 0x04009D9C RID: 40348
			[Token(Token = "0x4009D9C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Segments.PlayerSegment.IShaderEffect _shaderEffect;

			// Token: 0x04009D9D RID: 40349
			[Token(Token = "0x4009D9D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Item _blankItem;

			// Token: 0x02000C4B RID: 3147
			[Token(Token = "0x2000C4B")]
			public interface IShaderEffect
			{
				// Token: 0x06005DA1 RID: 23969
				[Token(Token = "0x6005DA1")]
				void BeforeDrawing(ref GameAnimationSegment info);

				// Token: 0x06005DA2 RID: 23970
				[Token(Token = "0x6005DA2")]
				void AfterDrawing(ref GameAnimationSegment info);
			}

			// Token: 0x02000C4C RID: 3148
			[Token(Token = "0x2000C4C")]
			public class ImmediateSpritebatchForPlayerDyesEffect : FileAPI
			{
				// Token: 0x06005DA3 RID: 23971 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005DA3")]
				[Address(RVA = "0x9ADB24", Offset = "0x9ADB24", VA = "0x9ADB24", Slot = "4")]
				public void BeforeDrawing(ref GameAnimationSegment info)
				{
				}

				// Token: 0x06005DA4 RID: 23972 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005DA4")]
				[Address(RVA = "0x9ADDF0", Offset = "0x9ADDF0", VA = "0x9ADDF0", Slot = "5")]
				public void AfterDrawing(ref GameAnimationSegment info)
				{
				}

				// Token: 0x06005DA5 RID: 23973 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005DA5")]
				[Address(RVA = "0x9AE0BC", Offset = "0x9AE0BC", VA = "0x9AE0BC")]
				public ImmediateSpritebatchForPlayerDyesEffect()
				{
				}
			}
		}

		// Token: 0x02000C4D RID: 3149
		[Token(Token = "0x2000C4D")]
		public class NPCSegment : Segments.AnimationSegmentWithActions<NPC>
		{
			// Token: 0x06005DA6 RID: 23974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DA6")]
			[Address(RVA = "0x9AE0C4", Offset = "0x9AE0C4", VA = "0x9AE0C4")]
			public NPCSegment(int targetTime, int npcId, Vector2 anchorOffset, Vector2 normalizedNPCHitboxOrigin)
			{
			}

			// Token: 0x06005DA7 RID: 23975 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DA7")]
			[Address(RVA = "0x9AE2A8", Offset = "0x9AE2A8", VA = "0x9AE2A8", Slot = "6")]
			protected override void Bind(IAnimationSegmentAction<NPC> act)
			{
			}

			// Token: 0x06005DA8 RID: 23976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DA8")]
			[Address(RVA = "0x9AE368", Offset = "0x9AE368", VA = "0x9AE368", Slot = "7")]
			public override void Draw(ref GameAnimationSegment info)
			{
			}

			// Token: 0x06005DA9 RID: 23977 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DA9")]
			[Address(RVA = "0x9AE794", Offset = "0x9AE794", VA = "0x9AE794")]
			private void ResetNPCAnimation(ref GameAnimationSegment info)
			{
			}

			// Token: 0x04009D9E RID: 40350
			[Token(Token = "0x4009D9E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private NPC _npc;

			// Token: 0x04009D9F RID: 40351
			[Token(Token = "0x4009D9F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Vector2 _anchorOffset;

			// Token: 0x04009DA0 RID: 40352
			[Token(Token = "0x4009DA0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Vector2 _normalizedOriginForHitbox;
		}

		// Token: 0x02000C4E RID: 3150
		[Token(Token = "0x2000C4E")]
		public class LooseSprite
		{
			// Token: 0x06005DAA RID: 23978 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DAA")]
			[Address(RVA = "0x9AE92C", Offset = "0x9AE92C", VA = "0x9AE92C")]
			public LooseSprite(DrawData data, Asset<Texture2D> asset)
			{
			}

			// Token: 0x06005DAB RID: 23979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DAB")]
			[Address(RVA = "0x9AEA2C", Offset = "0x9AEA2C", VA = "0x9AEA2C")]
			public void Reset()
			{
			}

			// Token: 0x04009DA1 RID: 40353
			[Token(Token = "0x4009DA1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private DrawData _originalDrawData;

			// Token: 0x04009DA2 RID: 40354
			[Token(Token = "0x4009DA2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Asset<Texture2D> _asset;

			// Token: 0x04009DA3 RID: 40355
			[Token(Token = "0x4009DA3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public DrawData CurrentDrawData;

			// Token: 0x04009DA4 RID: 40356
			[Token(Token = "0x4009DA4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float CurrentOpacity;
		}

		// Token: 0x02000C4F RID: 3151
		[Token(Token = "0x2000C4F")]
		public class SpriteSegment : Segments.AnimationSegmentWithActions<Segments.LooseSprite>
		{
			// Token: 0x06005DAC RID: 23980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DAC")]
			[Address(RVA = "0x9AEA9C", Offset = "0x9AEA9C", VA = "0x9AEA9C")]
			public SpriteSegment(Asset<Texture2D> asset, int targetTime, DrawData data, Vector2 anchorOffset)
			{
			}

			// Token: 0x06005DAD RID: 23981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DAD")]
			[Address(RVA = "0x9AEC38", Offset = "0x9AEC38", VA = "0x9AEC38", Slot = "6")]
			protected override void Bind(IAnimationSegmentAction<Segments.LooseSprite> act)
			{
			}

			// Token: 0x06005DAE RID: 23982 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005DAE")]
			[Address(RVA = "0x9AECF8", Offset = "0x9AECF8", VA = "0x9AECF8")]
			public Segments.SpriteSegment UseShaderEffect(Segments.SpriteSegment.IShaderEffect shaderEffect)
			{
				return null;
			}

			// Token: 0x06005DAF RID: 23983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DAF")]
			[Address(RVA = "0x9AED00", Offset = "0x9AED00", VA = "0x9AED00", Slot = "7")]
			public override void Draw(ref GameAnimationSegment info)
			{
			}

			// Token: 0x06005DB0 RID: 23984 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DB0")]
			[Address(RVA = "0x9AF0EC", Offset = "0x9AF0EC", VA = "0x9AF0EC")]
			private void ResetSpriteAnimation(ref GameAnimationSegment info)
			{
			}

			// Token: 0x04009DA5 RID: 40357
			[Token(Token = "0x4009DA5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Segments.LooseSprite _sprite;

			// Token: 0x04009DA6 RID: 40358
			[Token(Token = "0x4009DA6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Vector2 _anchorOffset;

			// Token: 0x04009DA7 RID: 40359
			[Token(Token = "0x4009DA7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Segments.SpriteSegment.IShaderEffect _shaderEffect;

			// Token: 0x02000C50 RID: 3152
			[Token(Token = "0x2000C50")]
			public interface IShaderEffect
			{
				// Token: 0x06005DB1 RID: 23985
				[Token(Token = "0x6005DB1")]
				void BeforeDrawing(ref GameAnimationSegment info, ref DrawData drawData);

				// Token: 0x06005DB2 RID: 23986
				[Token(Token = "0x6005DB2")]
				void AfterDrawing(ref GameAnimationSegment info, ref DrawData drawData);
			}

			// Token: 0x02000C51 RID: 3153
			[Token(Token = "0x2000C51")]
			public class MaskedFadeEffect : FileAPI
			{
				// Token: 0x06005DB3 RID: 23987 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005DB3")]
				[Address(RVA = "0x9AF168", Offset = "0x9AF168", VA = "0x9AF168")]
				public MaskedFadeEffect([Optional] Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction fetchMatrixMethod, string shaderKey = "MaskedFade", int verticalFrameCount = 1, int verticalFrameWait = 1)
				{
				}

				// Token: 0x06005DB4 RID: 23988 RVA: 0x0002BAE8 File Offset: 0x00029CE8
				[Token(Token = "0x6005DB4")]
				[Address(RVA = "0x9AF314", Offset = "0x9AF314", VA = "0x9AF314")]
				private Matrix DefaultFetchMatrix()
				{
					return default(Matrix);
				}

				// Token: 0x06005DB5 RID: 23989 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005DB5")]
				[Address(RVA = "0x9AF39C", Offset = "0x9AF39C", VA = "0x9AF39C", Slot = "4")]
				public void BeforeDrawing(ref GameAnimationSegment info, ref DrawData drawData)
				{
				}

				// Token: 0x06005DB6 RID: 23990 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005DB6")]
				[Address(RVA = "0x9AFA1C", Offset = "0x9AFA1C", VA = "0x9AFA1C")]
				public Segments.SpriteSegment.MaskedFadeEffect WithPanX(Segments.Panning panning)
				{
					return null;
				}

				// Token: 0x06005DB7 RID: 23991 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005DB7")]
				[Address(RVA = "0x9AFA34", Offset = "0x9AFA34", VA = "0x9AFA34")]
				public Segments.SpriteSegment.MaskedFadeEffect WithPanY(Segments.Panning panning)
				{
					return null;
				}

				// Token: 0x06005DB8 RID: 23992 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005DB8")]
				[Address(RVA = "0x9AFA4C", Offset = "0x9AFA4C", VA = "0x9AFA4C", Slot = "5")]
				public void AfterDrawing(ref GameAnimationSegment info, ref DrawData drawData)
				{
				}

				// Token: 0x04009DA8 RID: 40360
				[Token(Token = "0x4009DA8")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private readonly string _shaderKey;

				// Token: 0x04009DA9 RID: 40361
				[Token(Token = "0x4009DA9")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				private readonly int _verticalFrameCount;

				// Token: 0x04009DAA RID: 40362
				[Token(Token = "0x4009DAA")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private readonly int _verticalFrameWait;

				// Token: 0x04009DAB RID: 40363
				[Token(Token = "0x4009DAB")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				private Segments.Panning _panX;

				// Token: 0x04009DAC RID: 40364
				[Token(Token = "0x4009DAC")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Segments.Panning _panY;

				// Token: 0x04009DAD RID: 40365
				[Token(Token = "0x4009DAD")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
				private Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction _fetchMatrix;

				// Token: 0x02000C52 RID: 3154
				// (Invoke) Token: 0x06005DBA RID: 23994
				[Token(Token = "0x2000C52")]
				public delegate Matrix GetMatrixAction();
			}
		}

		// Token: 0x02000C53 RID: 3155
		[Token(Token = "0x2000C53")]
		public struct Panning
		{
			// Token: 0x06005DBD RID: 23997 RVA: 0x0002BB00 File Offset: 0x00029D00
			[Token(Token = "0x6005DBD")]
			[Address(RVA = "0x9AF9D4", Offset = "0x9AF9D4", VA = "0x9AF9D4")]
			public float GetPanAmount(float time)
			{
				return 0f;
			}

			// Token: 0x04009DAE RID: 40366
			[Token(Token = "0x4009DAE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float AmountOverTime;

			// Token: 0x04009DAF RID: 40367
			[Token(Token = "0x4009DAF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float StartAmount;

			// Token: 0x04009DB0 RID: 40368
			[Token(Token = "0x4009DB0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float Delay;

			// Token: 0x04009DB1 RID: 40369
			[Token(Token = "0x4009DB1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float Duration;
		}

		// Token: 0x02000C54 RID: 3156
		[Token(Token = "0x2000C54")]
		public class EmoteSegment : FileAPI
		{
			// Token: 0x17000A6B RID: 2667
			// (get) Token: 0x06005DBE RID: 23998 RVA: 0x0002BB18 File Offset: 0x00029D18
			// (set) Token: 0x06005DBF RID: 23999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A6B")]
			public float DedicatedTimeNeeded
			{
				[Token(Token = "0x6005DBE")]
				[Address(RVA = "0x9AFE24", Offset = "0x9AFE24", VA = "0x9AFE24", Slot = "4")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6005DBF")]
				[Address(RVA = "0x9AFE2C", Offset = "0x9AFE2C", VA = "0x9AFE2C")]
				private set
				{
				}
			}

			// Token: 0x06005DC0 RID: 24000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DC0")]
			[Address(RVA = "0x9AFE34", Offset = "0x9AFE34", VA = "0x9AFE34")]
			public EmoteSegment(int emoteId, int targetTime, int timeToPlay, Vector2 position, SpriteEffects drawEffect, [Optional] Vector2 velocity)
			{
			}

			// Token: 0x06005DC1 RID: 24001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DC1")]
			[Address(RVA = "0x9AFE8C", Offset = "0x9AFE8C", VA = "0x9AFE8C", Slot = "5")]
			public void Draw(ref GameAnimationSegment info)
			{
			}

			// Token: 0x06005DC2 RID: 24002 RVA: 0x0002BB30 File Offset: 0x00029D30
			[Token(Token = "0x6005DC2")]
			[Address(RVA = "0x9B03A8", Offset = "0x9B03A8", VA = "0x9B03A8")]
			private Rectangle GetFrame(int wrappedTime)
			{
				return default(Rectangle);
			}

			// Token: 0x04009DB2 RID: 40370
			[Token(Token = "0x4009DB2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private float <DedicatedTimeNeeded>k__BackingField;

			// Token: 0x04009DB3 RID: 40371
			[Token(Token = "0x4009DB3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private int _targetTime;

			// Token: 0x04009DB4 RID: 40372
			[Token(Token = "0x4009DB4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector2 _offset;

			// Token: 0x04009DB5 RID: 40373
			[Token(Token = "0x4009DB5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private SpriteEffects _effect;

			// Token: 0x04009DB6 RID: 40374
			[Token(Token = "0x4009DB6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int _emoteId;

			// Token: 0x04009DB7 RID: 40375
			[Token(Token = "0x4009DB7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector2 _velocity;
		}
	}
}
