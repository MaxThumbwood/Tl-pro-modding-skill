using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Golf
{
	// Token: 0x02000CD1 RID: 3281
	[Token(Token = "0x2000CD1")]
	public class GolfState
	{
		// Token: 0x06006166 RID: 24934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006166")]
		[Address(RVA = "0xAB28FC", Offset = "0xAB28FC", VA = "0xAB28FC")]
		private void UpdateScoreTime()
		{
		}

		// Token: 0x06006167 RID: 24935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006167")]
		[Address(RVA = "0xAB02B0", Offset = "0xAB02B0", VA = "0xAB02B0")]
		public void ResetScoreTime()
		{
		}

		// Token: 0x06006168 RID: 24936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006168")]
		[Address(RVA = "0xAAF9C8", Offset = "0xAAF9C8", VA = "0xAAF9C8")]
		public void SetScoreTime()
		{
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06006169 RID: 24937 RVA: 0x0002CFD0 File Offset: 0x0002B1D0
		[Token(Token = "0x17000A90")]
		public float ScoreAdjustment
		{
			[Token(Token = "0x6006169")]
			[Address(RVA = "0xAB2910", Offset = "0xAB2910", VA = "0xAB2910")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x0600616A RID: 24938 RVA: 0x0002CFE8 File Offset: 0x0002B1E8
		[Token(Token = "0x17000A91")]
		public bool ShouldScoreHole
		{
			[Token(Token = "0x600616A")]
			[Address(RVA = "0xAAF9B0", Offset = "0xAAF9B0", VA = "0xAAF9B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600616B RID: 24939 RVA: 0x0002D000 File Offset: 0x0002B200
		[Token(Token = "0x600616B")]
		[Address(RVA = "0xAB292C", Offset = "0xAB292C", VA = "0xAB292C")]
		public bool TryGetCameraTrackingPosition(out Vector2 cameraPosition)
		{
			return default(bool);
		}

		// Token: 0x0600616C RID: 24940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616C")]
		[Address(RVA = "0xAB2C28", Offset = "0xAB2C28", VA = "0xAB2C28")]
		public void WorldClear()
		{
		}

		// Token: 0x0600616D RID: 24941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616D")]
		[Address(RVA = "0xAB2C4C", Offset = "0xAB2C4C", VA = "0xAB2C4C")]
		public void CancelBallTracking()
		{
		}

		// Token: 0x0600616E RID: 24942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616E")]
		[Address(RVA = "0xAAD8E8", Offset = "0xAAD8E8", VA = "0xAAD8E8")]
		public void RecordSwing(Projectile golfBall)
		{
		}

		// Token: 0x0600616F RID: 24943 RVA: 0x0002D018 File Offset: 0x0002B218
		[Token(Token = "0x600616F")]
		[Address(RVA = "0xAB2C58", Offset = "0xAB2C58", VA = "0xAB2C58")]
		private int GetGolfBallId(Projectile golfBall)
		{
			return 0;
		}

		// Token: 0x06006170 RID: 24944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006170")]
		[Address(RVA = "0xAB2AC8", Offset = "0xAB2AC8", VA = "0xAB2AC8")]
		public Projectile GetLastHitBall()
		{
			return null;
		}

		// Token: 0x06006171 RID: 24945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006171")]
		[Address(RVA = "0xAB2C7C", Offset = "0xAB2C7C", VA = "0xAB2C7C")]
		public void Update()
		{
		}

		// Token: 0x06006172 RID: 24946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006172")]
		[Address(RVA = "0xAAF9D4", Offset = "0xAAF9D4", VA = "0xAAF9D4")]
		public void RecordBallInfo(Projectile golfBall)
		{
		}

		// Token: 0x06006173 RID: 24947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006173")]
		[Address(RVA = "0xAAFB30", Offset = "0xAAFB30", VA = "0xAAFB30")]
		public void LandBall(Projectile golfBall)
		{
		}

		// Token: 0x06006174 RID: 24948 RVA: 0x0002D030 File Offset: 0x0002B230
		[Token(Token = "0x6006174")]
		[Address(RVA = "0xAAFC28", Offset = "0xAAFC28", VA = "0xAAFC28")]
		public int GetGolfBallScore(Projectile golfBall)
		{
			return 0;
		}

		// Token: 0x06006175 RID: 24949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006175")]
		[Address(RVA = "0xAB2E18", Offset = "0xAB2E18", VA = "0xAB2E18")]
		public void ResetGolfBall()
		{
		}

		// Token: 0x06006176 RID: 24950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006176")]
		[Address(RVA = "0xAB2FD0", Offset = "0xAB2FD0", VA = "0xAB2FD0")]
		public GolfState()
		{
		}

		// Token: 0x0400A015 RID: 40981
		[Token(Token = "0x400A015")]
		private const int BALL_RETURN_PENALTY = 1;

		// Token: 0x0400A016 RID: 40982
		[Token(Token = "0x400A016")]
		[FieldOffset(Offset = "0x8")]
		private int golfScoreTime;

		// Token: 0x0400A017 RID: 40983
		[Token(Token = "0x400A017")]
		[FieldOffset(Offset = "0xC")]
		private int golfScoreTimeMax;

		// Token: 0x0400A018 RID: 40984
		[Token(Token = "0x400A018")]
		[FieldOffset(Offset = "0x10")]
		private int golfScoreDelay;

		// Token: 0x0400A019 RID: 40985
		[Token(Token = "0x400A019")]
		[FieldOffset(Offset = "0x18")]
		private double _lastRecordedBallTime;

		// Token: 0x0400A01A RID: 40986
		[Token(Token = "0x400A01A")]
		[FieldOffset(Offset = "0x20")]
		private Vector2? _lastRecordedBallLocation;

		// Token: 0x0400A01B RID: 40987
		[Token(Token = "0x400A01B")]
		[FieldOffset(Offset = "0x2C")]
		private bool _waitingForBallToSettle;

		// Token: 0x0400A01C RID: 40988
		[Token(Token = "0x400A01C")]
		[FieldOffset(Offset = "0x30")]
		private Vector2 _lastSwingPosition;

		// Token: 0x0400A01D RID: 40989
		[Token(Token = "0x400A01D")]
		[FieldOffset(Offset = "0x38")]
		private Projectile _lastHitGolfBall;

		// Token: 0x0400A01E RID: 40990
		[Token(Token = "0x400A01E")]
		[FieldOffset(Offset = "0x3C")]
		private int _lastRecordedSwingCount;

		// Token: 0x0400A01F RID: 40991
		[Token(Token = "0x400A01F")]
		[FieldOffset(Offset = "0x40")]
		private GolfBallTrackRecord[] _hitRecords;
	}
}
