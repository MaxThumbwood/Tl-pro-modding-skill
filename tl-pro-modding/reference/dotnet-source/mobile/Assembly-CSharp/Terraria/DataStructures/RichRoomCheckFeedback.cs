using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Renderers;

namespace Terraria.DataStructures
{
	// Token: 0x0200076D RID: 1901
	[Token(Token = "0x200076D")]
	public class RichRoomCheckFeedback : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x06004318 RID: 17176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004318")]
		[Address(RVA = "0x4FA988", Offset = "0x4FA988", VA = "0x4FA988")]
		private static RoomCheckParticle GetNewParticle(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004319")]
		[Address(RVA = "0x4FA9FC", Offset = "0x4FA9FC", VA = "0x4FA9FC")]
		private void Add(int x, int y, int iteration, RichRoomCheckFeedback.Reason type)
		{
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x0600431A RID: 17178 RVA: 0x00020598 File Offset: 0x0001E798
		[Token(Token = "0x17000825")]
		public bool StopOnFail
		{
			[Token(Token = "0x600431A")]
			[Address(RVA = "0x4FAAEC", Offset = "0x4FAAEC", VA = "0x4FAAEC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x0600431B RID: 17179 RVA: 0x000205B0 File Offset: 0x0001E7B0
		[Token(Token = "0x17000826")]
		public bool DisplayText
		{
			[Token(Token = "0x600431B")]
			[Address(RVA = "0x4FAAF4", Offset = "0x4FAAF4", VA = "0x4FAAF4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600431C")]
		[Address(RVA = "0x4FAAFC", Offset = "0x4FAAFC", VA = "0x4FAAFC", Slot = "6")]
		public void BeginSpread(int x, int y)
		{
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600431D")]
		[Address(RVA = "0x4FAB14", Offset = "0x4FAB14", VA = "0x4FAB14", Slot = "7")]
		public void StartedInASolidTile(int x, int y)
		{
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600431E")]
		[Address(RVA = "0x4FAB34", Offset = "0x4FAB34", VA = "0x4FAB34", Slot = "8")]
		public void TooCloseToWorldEdge(int x, int y, int iteration)
		{
		}

		// Token: 0x0600431F RID: 17183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600431F")]
		[Address(RVA = "0x4FAB50", Offset = "0x4FAB50", VA = "0x4FAB50", Slot = "9")]
		public void AnyBlockScannedHere(int x, int y, int iteration)
		{
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004320")]
		[Address(RVA = "0x4FAB6C", Offset = "0x4FAB6C", VA = "0x4FAB6C", Slot = "10")]
		public void RoomTooBig(int x, int y, int iteration)
		{
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004321")]
		[Address(RVA = "0x4FAB88", Offset = "0x4FAB88", VA = "0x4FAB88", Slot = "11")]
		public void BlockingWall(int x, int y, int iteration)
		{
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004322")]
		[Address(RVA = "0x4FABA4", Offset = "0x4FABA4", VA = "0x4FABA4", Slot = "12")]
		public void BlockingOpenGate(int x, int y, int iteration)
		{
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004323")]
		[Address(RVA = "0x4FABC0", Offset = "0x4FABC0", VA = "0x4FABC0", Slot = "13")]
		public void Stinkbug(int x, int y, int iteration)
		{
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004324")]
		[Address(RVA = "0x4FABDC", Offset = "0x4FABDC", VA = "0x4FABDC", Slot = "14")]
		public void EchoStinkbug(int x, int y, int iteration)
		{
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004325")]
		[Address(RVA = "0x4FABF8", Offset = "0x4FABF8", VA = "0x4FABF8", Slot = "15")]
		public void MissingAWall(int x, int y, int iteration)
		{
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004326")]
		[Address(RVA = "0x4FAC14", Offset = "0x4FAC14", VA = "0x4FAC14", Slot = "16")]
		public void UnsafeWall(int x, int y, int iteration)
		{
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004327")]
		[Address(RVA = "0x4FAC30", Offset = "0x4FAC30", VA = "0x4FAC30", Slot = "17")]
		public void EndSpread()
		{
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x000205C8 File Offset: 0x0001E7C8
		[Token(Token = "0x6004328")]
		[Address(RVA = "0x4FC57C", Offset = "0x4FC57C", VA = "0x4FC57C")]
		private float GetHighestDistanceFromOrigin(ref Vector2 origin)
		{
			return 0f;
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004329")]
		[Address(RVA = "0x4FC6A4", Offset = "0x4FC6A4", VA = "0x4FC6A4", Slot = "18")]
		public void BeginScoring()
		{
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600432A")]
		[Address(RVA = "0x4FC6B4", Offset = "0x4FC6B4", VA = "0x4FC6B4", Slot = "19")]
		public void ReportScore(int x, int y, int score)
		{
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600432B")]
		[Address(RVA = "0x4FC780", Offset = "0x4FC780", VA = "0x4FC780", Slot = "20")]
		public void SetAsHighScore(int x, int y, int score)
		{
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600432C")]
		[Address(RVA = "0x4FC78C", Offset = "0x4FC78C", VA = "0x4FC78C", Slot = "21")]
		public void EndScoring()
		{
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600432D")]
		[Address(RVA = "0x4FD2D0", Offset = "0x4FD2D0", VA = "0x4FD2D0")]
		public RichRoomCheckFeedback()
		{
		}

		// Token: 0x04008A76 RID: 35446
		[Token(Token = "0x4008A76")]
		[FieldOffset(Offset = "0x0")]
		public static RichRoomCheckFeedback Instance;

		// Token: 0x04008A77 RID: 35447
		[Token(Token = "0x4008A77")]
		[FieldOffset(Offset = "0x4")]
		private static ParticlePoolType<RoomCheckParticle> _particlePool;

		// Token: 0x04008A78 RID: 35448
		[Token(Token = "0x4008A78")]
		[FieldOffset(Offset = "0x8")]
		private RichRoomCheckFeedback.ParticlePreparation[] _space;

		// Token: 0x04008A79 RID: 35449
		[Token(Token = "0x4008A79")]
		[FieldOffset(Offset = "0xC")]
		private int _spaceCount;

		// Token: 0x04008A7A RID: 35450
		[Token(Token = "0x4008A7A")]
		[FieldOffset(Offset = "0x10")]
		private int _highestIteration;

		// Token: 0x04008A7B RID: 35451
		[Token(Token = "0x4008A7B")]
		[FieldOffset(Offset = "0x14")]
		private RichRoomCheckFeedback.ScorePreparation[] _score;

		// Token: 0x04008A7C RID: 35452
		[Token(Token = "0x4008A7C")]
		[FieldOffset(Offset = "0x18")]
		private int _scoreCount;

		// Token: 0x04008A7D RID: 35453
		[Token(Token = "0x4008A7D")]
		[FieldOffset(Offset = "0x1C")]
		private RichRoomCheckFeedback.ScorePreparation _bestScore;

		// Token: 0x04008A7E RID: 35454
		[Token(Token = "0x4008A7E")]
		[FieldOffset(Offset = "0x28")]
		private int _originX;

		// Token: 0x04008A7F RID: 35455
		[Token(Token = "0x4008A7F")]
		[FieldOffset(Offset = "0x2C")]
		private int _originY;

		// Token: 0x0200076E RID: 1902
		[Token(Token = "0x200076E")]
		private enum Reason
		{
			// Token: 0x04008A81 RID: 35457
			[Token(Token = "0x4008A81")]
			BlockedWall,
			// Token: 0x04008A82 RID: 35458
			[Token(Token = "0x4008A82")]
			UnsafeWall,
			// Token: 0x04008A83 RID: 35459
			[Token(Token = "0x4008A83")]
			OpenAir,
			// Token: 0x04008A84 RID: 35460
			[Token(Token = "0x4008A84")]
			Good,
			// Token: 0x04008A85 RID: 35461
			[Token(Token = "0x4008A85")]
			Hazard
		}

		// Token: 0x0200076F RID: 1903
		[Token(Token = "0x200076F")]
		private struct ParticlePreparation
		{
			// Token: 0x04008A86 RID: 35462
			[Token(Token = "0x4008A86")]
			[FieldOffset(Offset = "0x0")]
			public RichRoomCheckFeedback.Reason type;

			// Token: 0x04008A87 RID: 35463
			[Token(Token = "0x4008A87")]
			[FieldOffset(Offset = "0x4")]
			public int x;

			// Token: 0x04008A88 RID: 35464
			[Token(Token = "0x4008A88")]
			[FieldOffset(Offset = "0x8")]
			public int y;

			// Token: 0x04008A89 RID: 35465
			[Token(Token = "0x4008A89")]
			[FieldOffset(Offset = "0xC")]
			public int iteration;

			// Token: 0x04008A8A RID: 35466
			[Token(Token = "0x4008A8A")]
			[FieldOffset(Offset = "0x10")]
			public bool consumed;
		}

		// Token: 0x02000770 RID: 1904
		[Token(Token = "0x2000770")]
		private struct ScorePreparation
		{
			// Token: 0x04008A8B RID: 35467
			[Token(Token = "0x4008A8B")]
			[FieldOffset(Offset = "0x0")]
			public int x;

			// Token: 0x04008A8C RID: 35468
			[Token(Token = "0x4008A8C")]
			[FieldOffset(Offset = "0x4")]
			public int y;

			// Token: 0x04008A8D RID: 35469
			[Token(Token = "0x4008A8D")]
			[FieldOffset(Offset = "0x8")]
			public int score;
		}
	}
}
