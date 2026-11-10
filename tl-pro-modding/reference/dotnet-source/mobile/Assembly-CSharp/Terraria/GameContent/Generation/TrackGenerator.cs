using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Generation
{
	// Token: 0x02000B10 RID: 2832
	[Token(Token = "0x2000B10")]
	public class TrackGenerator
	{
		// Token: 0x06005834 RID: 22580 RVA: 0x00029010 File Offset: 0x00027210
		[Token(Token = "0x6005834")]
		[Address(RVA = "0x865378", Offset = "0x865378", VA = "0x865378")]
		public bool Place(Point origin, int minLength, int maxLength)
		{
			return default(bool);
		}

		// Token: 0x06005835 RID: 22581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005835")]
		[Address(RVA = "0x865754", Offset = "0x865754", VA = "0x865754")]
		private void PlacePath()
		{
		}

		// Token: 0x06005836 RID: 22582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005836")]
		[Address(RVA = "0x8654FC", Offset = "0x8654FC", VA = "0x8654FC")]
		private void CreateTrackStart(Point origin)
		{
		}

		// Token: 0x06005837 RID: 22583 RVA: 0x00029028 File Offset: 0x00027228
		[Token(Token = "0x6005837")]
		[Address(RVA = "0x865604", Offset = "0x865604", VA = "0x865604")]
		private bool FindPath(int minLength, int maxLength)
		{
			return default(bool);
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x00029040 File Offset: 0x00027240
		[Token(Token = "0x6005838")]
		[Address(RVA = "0x86759C", Offset = "0x86759C", VA = "0x86759C")]
		private TrackGenerator.TrackPlacementState CreateTunnel()
		{
			return TrackGenerator.TrackPlacementState.Available;
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005839")]
		[Address(RVA = "0x86704C", Offset = "0x86704C", VA = "0x86704C")]
		private void AppendToHistory(TrackGenerator.TrackSlope slope, TrackGenerator.TrackMode mode = TrackGenerator.TrackMode.Normal)
		{
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x00029058 File Offset: 0x00027258
		[Token(Token = "0x600583A")]
		[Address(RVA = "0x8670F4", Offset = "0x8670F4", VA = "0x8670F4")]
		private TrackGenerator.TrackPlacementState TryRewriteHistoryToAvoidTiles()
		{
			return TrackGenerator.TrackPlacementState.Available;
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583B")]
		[Address(RVA = "0x867FA8", Offset = "0x867FA8", VA = "0x867FA8")]
		private void RewriteSlopeDirection(int index, TrackGenerator.TrackSlope slope)
		{
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x00029070 File Offset: 0x00027270
		[Token(Token = "0x600583C")]
		[Address(RVA = "0x867BB4", Offset = "0x867BB4", VA = "0x867BB4")]
		private TrackGenerator.TrackPlacementState GetHistorySegmentPlacementState(int startIndex, int length)
		{
			return TrackGenerator.TrackPlacementState.Available;
		}

		// Token: 0x0600583D RID: 22589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583D")]
		[Address(RVA = "0x867950", Offset = "0x867950", VA = "0x867950")]
		private void SmoothTrack()
		{
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x00029088 File Offset: 0x00027288
		[Token(Token = "0x600583E")]
		[Address(RVA = "0x867F84", Offset = "0x867F84", VA = "0x867F84")]
		private static bool CanSlopesTouch(TrackGenerator.TrackSlope leftSlope, TrackGenerator.TrackSlope rightSlope)
		{
			return default(bool);
		}

		// Token: 0x0600583F RID: 22591 RVA: 0x000290A0 File Offset: 0x000272A0
		[Token(Token = "0x600583F")]
		[Address(RVA = "0x865434", Offset = "0x865434", VA = "0x865434")]
		private static bool FindSuitableOrigin(ref Point origin)
		{
			return default(bool);
		}

		// Token: 0x06005840 RID: 22592 RVA: 0x000290B8 File Offset: 0x000272B8
		[Token(Token = "0x6005840")]
		[Address(RVA = "0x867CBC", Offset = "0x867CBC", VA = "0x867CBC")]
		private static TrackGenerator.TrackPlacementState CalculateStateForLocation(int x, int y)
		{
			return TrackGenerator.TrackPlacementState.Available;
		}

		// Token: 0x06005841 RID: 22593 RVA: 0x000290D0 File Offset: 0x000272D0
		[Token(Token = "0x6005841")]
		[Address(RVA = "0x868BE0", Offset = "0x868BE0", VA = "0x868BE0")]
		private static bool IsMinecartTrack(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005842 RID: 22594 RVA: 0x000290E8 File Offset: 0x000272E8
		[Token(Token = "0x6005842")]
		[Address(RVA = "0x868070", Offset = "0x868070", VA = "0x868070")]
		private static bool IsLocationInvalid(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005843")]
		[Address(RVA = "0x868DEC", Offset = "0x868DEC", VA = "0x868DEC")]
		private void DrawPause()
		{
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005844")]
		[Address(RVA = "0x868DF0", Offset = "0x868DF0", VA = "0x868DF0")]
		public TrackGenerator()
		{
		}

		// Token: 0x0400998C RID: 39308
		[Token(Token = "0x400998C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ushort[] InvalidWalls;

		// Token: 0x0400998D RID: 39309
		[Token(Token = "0x400998D")]
		[FieldOffset(Offset = "0x4")]
		private static readonly ushort[] InvalidTiles;

		// Token: 0x0400998E RID: 39310
		[Token(Token = "0x400998E")]
		[FieldOffset(Offset = "0x8")]
		private readonly TrackGenerator.TrackHistory[] _history;

		// Token: 0x0400998F RID: 39311
		[Token(Token = "0x400998F")]
		[FieldOffset(Offset = "0xC")]
		private readonly TrackGenerator.TrackHistory[] _rewriteHistory;

		// Token: 0x04009990 RID: 39312
		[Token(Token = "0x4009990")]
		[FieldOffset(Offset = "0x10")]
		private int _xDirection;

		// Token: 0x04009991 RID: 39313
		[Token(Token = "0x4009991")]
		[FieldOffset(Offset = "0x14")]
		private int _length;

		// Token: 0x04009992 RID: 39314
		[Token(Token = "0x4009992")]
		[FieldOffset(Offset = "0x18")]
		private int playerHeight;

		// Token: 0x02000B11 RID: 2833
		[Token(Token = "0x2000B11")]
		private enum TrackPlacementState
		{
			// Token: 0x04009994 RID: 39316
			[Token(Token = "0x4009994")]
			Available,
			// Token: 0x04009995 RID: 39317
			[Token(Token = "0x4009995")]
			Obstructed,
			// Token: 0x04009996 RID: 39318
			[Token(Token = "0x4009996")]
			Invalid
		}

		// Token: 0x02000B12 RID: 2834
		[Token(Token = "0x2000B12")]
		private enum TrackSlope : sbyte
		{
			// Token: 0x04009998 RID: 39320
			[Token(Token = "0x4009998")]
			Up = -1,
			// Token: 0x04009999 RID: 39321
			[Token(Token = "0x4009999")]
			Straight,
			// Token: 0x0400999A RID: 39322
			[Token(Token = "0x400999A")]
			Down
		}

		// Token: 0x02000B13 RID: 2835
		[Token(Token = "0x2000B13")]
		private enum TrackMode : byte
		{
			// Token: 0x0400999C RID: 39324
			[Token(Token = "0x400999C")]
			Normal,
			// Token: 0x0400999D RID: 39325
			[Token(Token = "0x400999D")]
			Tunnel
		}

		// Token: 0x02000B14 RID: 2836
		[Token(Token = "0x2000B14")]
		private struct TrackHistory
		{
			// Token: 0x06005846 RID: 22598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005846")]
			[Address(RVA = "0x867034", Offset = "0x867034", VA = "0x867034")]
			public TrackHistory(int x, int y, TrackGenerator.TrackSlope slope)
			{
			}

			// Token: 0x0400999E RID: 39326
			[Token(Token = "0x400999E")]
			[FieldOffset(Offset = "0x0")]
			public short X;

			// Token: 0x0400999F RID: 39327
			[Token(Token = "0x400999F")]
			[FieldOffset(Offset = "0x2")]
			public short Y;

			// Token: 0x040099A0 RID: 39328
			[Token(Token = "0x40099A0")]
			[FieldOffset(Offset = "0x4")]
			public TrackGenerator.TrackSlope Slope;

			// Token: 0x040099A1 RID: 39329
			[Token(Token = "0x40099A1")]
			[FieldOffset(Offset = "0x5")]
			public TrackGenerator.TrackMode Mode;
		}
	}
}
