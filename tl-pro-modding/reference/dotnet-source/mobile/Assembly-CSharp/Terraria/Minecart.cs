using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria
{
	// Token: 0x020004D5 RID: 1237
	[Token(Token = "0x20004D5")]
	public static class Minecart
	{
		// Token: 0x060030BF RID: 12479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030BF")]
		[Address(RVA = "0x19EE334", Offset = "0x19EE334", VA = "0x19EE334")]
		public static void Initialize()
		{
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x00017688 File Offset: 0x00015888
		[Token(Token = "0x60030C0")]
		[Address(RVA = "0x19F2404", Offset = "0x19F2404", VA = "0x19F2404")]
		public static bool CanSwitchTrack(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x000176A0 File Offset: 0x000158A0
		[Token(Token = "0x60030C1")]
		[Address(RVA = "0x19F3250", Offset = "0x19F3250", VA = "0x19F3250")]
		public static bool IsPressurePlate(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x000176B8 File Offset: 0x000158B8
		[Token(Token = "0x60030C2")]
		[Address(RVA = "0x19F34B4", Offset = "0x19F34B4", VA = "0x19F34B4")]
		public static BitsByte TrackCollision(Player Player, ref Vector2 Position, ref Vector2 Velocity, ref Vector2 lastBoost, int Width, int Height, bool followDown, bool followUp, int fallStart, bool trackOnly, Mount.MountDelegatesData delegatesData)
		{
			return default(BitsByte);
		}

		// Token: 0x060030C3 RID: 12483 RVA: 0x000176D0 File Offset: 0x000158D0
		[Token(Token = "0x60030C3")]
		[Address(RVA = "0x19F4CC4", Offset = "0x19F4CC4", VA = "0x19F4CC4")]
		public static bool FrameTrack(int i, int j, bool pound, bool mute = false)
		{
			return default(bool);
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x000176E8 File Offset: 0x000158E8
		[Token(Token = "0x60030C4")]
		[Address(RVA = "0x19F5BEC", Offset = "0x19F5BEC", VA = "0x19F5BEC")]
		private static int GetNearbyTilesSetLookupIndex(int i, int j)
		{
			return 0;
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x00017700 File Offset: 0x00015900
		[Token(Token = "0x60030C5")]
		[Address(RVA = "0x19F63F8", Offset = "0x19F63F8", VA = "0x19F63F8")]
		public static bool GetOnTrack(int tileX, int tileY, ref Vector2 Position, int Width, int Height, Minecart.Customization settings)
		{
			return default(bool);
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x00017718 File Offset: 0x00015918
		[Token(Token = "0x60030C6")]
		[Address(RVA = "0x19F68C4", Offset = "0x19F68C4", VA = "0x19F68C4")]
		public static bool OnTrack(Vector2 Position, int Width, int Height, Minecart.Customization settings)
		{
			return default(bool);
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x00017730 File Offset: 0x00015930
		[Token(Token = "0x60030C7")]
		[Address(RVA = "0x19F6B44", Offset = "0x19F6B44", VA = "0x19F6B44")]
		public static float TrackRotation(Player player, ref float rotation, Vector2 Position, int Width, int Height, bool followDown, bool followUp, Mount.MountDelegatesData delegatesData)
		{
			return 0f;
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C8")]
		[Address(RVA = "0x19F6CA4", Offset = "0x19F6CA4", VA = "0x19F6CA4")]
		public static void GetWheelsPositions(Player player, Vector2 Position, int Width, int Height, bool followDown, bool followUp, Mount.MountDelegatesData delegatesData, out Vector2 leftWheel, out Vector2 rightWheel)
		{
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C9")]
		[Address(RVA = "0x19F6ED0", Offset = "0x19F6ED0", VA = "0x19F6ED0")]
		public static void HitTrackSwitch(Vector2 Position, int Width, int Height, Minecart.Customization settings)
		{
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x00017748 File Offset: 0x00015948
		[Token(Token = "0x60030CA")]
		[Address(RVA = "0x19F7048", Offset = "0x19F7048", VA = "0x19F7048")]
		public static Vector2 GetMagnetPosition(Vector2 Position, int Width, int Height, Minecart.Customization settings)
		{
			return default(Vector2);
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030CB")]
		[Address(RVA = "0x19F7178", Offset = "0x19F7178", VA = "0x19F7178")]
		public static void FlipSwitchTrack(int i, int j)
		{
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030CC")]
		[Address(RVA = "0x19F746C", Offset = "0x19F746C", VA = "0x19F746C")]
		public static void TrackColors(int i, int j, Tile trackTile, out int frontColor, out int backColor)
		{
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x00017760 File Offset: 0x00015960
		[Token(Token = "0x60030CD")]
		[Address(RVA = "0x19F7C74", Offset = "0x19F7C74", VA = "0x19F7C74")]
		public static bool DrawLeftDecoration(int frameID)
		{
			return default(bool);
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x00017778 File Offset: 0x00015978
		[Token(Token = "0x60030CE")]
		[Address(RVA = "0x19F7CF4", Offset = "0x19F7CF4", VA = "0x19F7CF4")]
		public static bool DrawRightDecoration(int frameID)
		{
			return default(bool);
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x00017790 File Offset: 0x00015990
		[Token(Token = "0x60030CF")]
		[Address(RVA = "0x19F7D74", Offset = "0x19F7D74", VA = "0x19F7D74")]
		public static bool DrawBumper(int frameID)
		{
			return default(bool);
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x000177A8 File Offset: 0x000159A8
		[Token(Token = "0x60030D0")]
		[Address(RVA = "0x19F7E44", Offset = "0x19F7E44", VA = "0x19F7E44")]
		public static bool DrawBouncyBumper(int frameID)
		{
			return default(bool);
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030D1")]
		[Address(RVA = "0x19F7F10", Offset = "0x19F7F10", VA = "0x19F7F10")]
		public static void PlaceTrack(Tile trackCache, int style)
		{
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x000177C0 File Offset: 0x000159C0
		[Token(Token = "0x60030D2")]
		[Address(RVA = "0x19F820C", Offset = "0x19F820C", VA = "0x19F820C")]
		public static int GetTrackItem(Tile trackCache)
		{
			return 0;
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x000177D8 File Offset: 0x000159D8
		[Token(Token = "0x60030D3")]
		[Address(RVA = "0x19F8330", Offset = "0x19F8330", VA = "0x19F8330")]
		public static Rectangle GetSourceRect(int frameID, int animationFrame = 0)
		{
			return default(Rectangle);
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x000177F0 File Offset: 0x000159F0
		[Token(Token = "0x60030D4")]
		[Address(RVA = "0x19F84B4", Offset = "0x19F84B4", VA = "0x19F84B4")]
		public static bool GetAreExpectationsForSidesMet(Point tileCoords, int? expectedYOffsetForLeft, int? expectedYOffsetForRight)
		{
			return default(bool);
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030D5")]
		[Address(RVA = "0x19F86B8", Offset = "0x19F86B8", VA = "0x19F86B8")]
		public static void TryFittingTileOrientation(Point tileCoords, int? expectedYOffsetForLeft, int? expectedYOffsetForRight)
		{
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x00017808 File Offset: 0x00015A08
		[Token(Token = "0x60030D6")]
		[Address(RVA = "0x19F8698", Offset = "0x19F8698", VA = "0x19F8698")]
		private static int ConvertOffsetYToTrackConnectionValue(int offsetY)
		{
			return 0;
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x00017820 File Offset: 0x00015A20
		[Token(Token = "0x60030D7")]
		[Address(RVA = "0x19F8AA0", Offset = "0x19F8AA0", VA = "0x19F8AA0")]
		private static int ConvertTrackConnectionValueToOffsetY(int trackConnectionValue)
		{
			return 0;
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030D8")]
		[Address(RVA = "0x19F4B6C", Offset = "0x19F4B6C", VA = "0x19F4B6C")]
		public static void WheelSparks(Action<Vector2> DustAction, Vector2 Position, int Width, int Height, int sparkCount, Minecart.Customization settings)
		{
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x00017838 File Offset: 0x00015A38
		[Token(Token = "0x60030D9")]
		[Address(RVA = "0x19F30C0", Offset = "0x19F30C0", VA = "0x19F30C0")]
		private static short FrontTrack(Tile tileTrack)
		{
			return 0;
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030DA")]
		[Address(RVA = "0x19F6278", Offset = "0x19F6278", VA = "0x19F6278")]
		private static void FrontTrack(Tile tileTrack, short trackID)
		{
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x00017850 File Offset: 0x00015A50
		[Token(Token = "0x60030DB")]
		[Address(RVA = "0x19F3188", Offset = "0x19F3188", VA = "0x19F3188")]
		private static short BackTrack(Tile tileTrack)
		{
			return 0;
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030DC")]
		[Address(RVA = "0x19F6338", Offset = "0x19F6338", VA = "0x19F6338")]
		private static void BackTrack(Tile tileTrack, short trackID)
		{
		}

		// Token: 0x04004123 RID: 16675
		[Token(Token = "0x4004123")]
		private const int TotalFrames = 36;

		// Token: 0x04004124 RID: 16676
		[Token(Token = "0x4004124")]
		public const int LeftDownDecoration = 36;

		// Token: 0x04004125 RID: 16677
		[Token(Token = "0x4004125")]
		public const int RightDownDecoration = 37;

		// Token: 0x04004126 RID: 16678
		[Token(Token = "0x4004126")]
		public const int BouncyBumperDecoration = 38;

		// Token: 0x04004127 RID: 16679
		[Token(Token = "0x4004127")]
		public const int RegularBumperDecoration = 39;

		// Token: 0x04004128 RID: 16680
		[Token(Token = "0x4004128")]
		public const int Flag_OnTrack = 0;

		// Token: 0x04004129 RID: 16681
		[Token(Token = "0x4004129")]
		public const int Flag_BouncyBumper = 1;

		// Token: 0x0400412A RID: 16682
		[Token(Token = "0x400412A")]
		public const int Flag_UsedRamp = 2;

		// Token: 0x0400412B RID: 16683
		[Token(Token = "0x400412B")]
		public const int Flag_HitSwitch = 3;

		// Token: 0x0400412C RID: 16684
		[Token(Token = "0x400412C")]
		public const int Flag_BoostLeft = 4;

		// Token: 0x0400412D RID: 16685
		[Token(Token = "0x400412D")]
		public const int Flag_BoostRight = 5;

		// Token: 0x0400412E RID: 16686
		[Token(Token = "0x400412E")]
		private const int NoConnection = -1;

		// Token: 0x0400412F RID: 16687
		[Token(Token = "0x400412F")]
		private const int TopConnection = 0;

		// Token: 0x04004130 RID: 16688
		[Token(Token = "0x4004130")]
		private const int MiddleConnection = 1;

		// Token: 0x04004131 RID: 16689
		[Token(Token = "0x4004131")]
		private const int BottomConnection = 2;

		// Token: 0x04004132 RID: 16690
		[Token(Token = "0x4004132")]
		private const int BumperEnd = -1;

		// Token: 0x04004133 RID: 16691
		[Token(Token = "0x4004133")]
		private const int BouncyEnd = -2;

		// Token: 0x04004134 RID: 16692
		[Token(Token = "0x4004134")]
		private const int RampEnd = -3;

		// Token: 0x04004135 RID: 16693
		[Token(Token = "0x4004135")]
		private const int OpenEnd = -4;

		// Token: 0x04004136 RID: 16694
		[Token(Token = "0x4004136")]
		public const float BoosterSpeed = 4f;

		// Token: 0x04004137 RID: 16695
		[Token(Token = "0x4004137")]
		private const int Type_Normal = 0;

		// Token: 0x04004138 RID: 16696
		[Token(Token = "0x4004138")]
		private const int Type_Pressure = 1;

		// Token: 0x04004139 RID: 16697
		[Token(Token = "0x4004139")]
		private const int Type_Booster = 2;

		// Token: 0x0400413A RID: 16698
		[Token(Token = "0x400413A")]
		[FieldOffset(Offset = "0x0")]
		private static int[] _leftSideConnection;

		// Token: 0x0400413B RID: 16699
		[Token(Token = "0x400413B")]
		[FieldOffset(Offset = "0x4")]
		private static int[] _rightSideConnection;

		// Token: 0x0400413C RID: 16700
		[Token(Token = "0x400413C")]
		[FieldOffset(Offset = "0x8")]
		private static int[] _trackType;

		// Token: 0x0400413D RID: 16701
		[Token(Token = "0x400413D")]
		[FieldOffset(Offset = "0xC")]
		private static bool[] _boostLeft;

		// Token: 0x0400413E RID: 16702
		[Token(Token = "0x400413E")]
		[FieldOffset(Offset = "0x10")]
		private static Vector2[] _texturePosition;

		// Token: 0x0400413F RID: 16703
		[Token(Token = "0x400413F")]
		[FieldOffset(Offset = "0x14")]
		private static short _firstPressureFrame;

		// Token: 0x04004140 RID: 16704
		[Token(Token = "0x4004140")]
		[FieldOffset(Offset = "0x16")]
		private static short _firstLeftBoostFrame;

		// Token: 0x04004141 RID: 16705
		[Token(Token = "0x4004141")]
		[FieldOffset(Offset = "0x18")]
		private static short _firstRightBoostFrame;

		// Token: 0x04004142 RID: 16706
		[Token(Token = "0x4004142")]
		[FieldOffset(Offset = "0x1C")]
		private static int[][] _trackSwitchOptions;

		// Token: 0x04004143 RID: 16707
		[Token(Token = "0x4004143")]
		[FieldOffset(Offset = "0x20")]
		private static int[][] _tileHeight;

		// Token: 0x020004D6 RID: 1238
		[Token(Token = "0x20004D6")]
		private enum TrackState
		{
			// Token: 0x04004145 RID: 16709
			[Token(Token = "0x4004145")]
			NoTrack = -1,
			// Token: 0x04004146 RID: 16710
			[Token(Token = "0x4004146")]
			AboveTrack,
			// Token: 0x04004147 RID: 16711
			[Token(Token = "0x4004147")]
			OnTrack,
			// Token: 0x04004148 RID: 16712
			[Token(Token = "0x4004148")]
			BelowTrack,
			// Token: 0x04004149 RID: 16713
			[Token(Token = "0x4004149")]
			AboveFront,
			// Token: 0x0400414A RID: 16714
			[Token(Token = "0x400414A")]
			AboveBack,
			// Token: 0x0400414B RID: 16715
			[Token(Token = "0x400414B")]
			OnFront,
			// Token: 0x0400414C RID: 16716
			[Token(Token = "0x400414C")]
			OnBack
		}

		// Token: 0x020004D7 RID: 1239
		[Token(Token = "0x20004D7")]
		public struct Customization
		{
			// Token: 0x17000672 RID: 1650
			// (get) Token: 0x060030DD RID: 12509 RVA: 0x00017868 File Offset: 0x00015A68
			[Token(Token = "0x17000672")]
			public static Minecart.Customization Default
			{
				[Token(Token = "0x60030DD")]
				[Address(RVA = "0x19F238C", Offset = "0x19F238C", VA = "0x19F238C")]
				get
				{
					return default(Minecart.Customization);
				}
			}

			// Token: 0x0400414D RID: 16717
			[Token(Token = "0x400414D")]
			[FieldOffset(Offset = "0x0")]
			public float MinecartTextureWidth;

			// Token: 0x0400414E RID: 16718
			[Token(Token = "0x400414E")]
			[FieldOffset(Offset = "0x4")]
			public Vector2 WheelOffset;

			// Token: 0x0400414F RID: 16719
			[Token(Token = "0x400414F")]
			[FieldOffset(Offset = "0xC")]
			public Vector2 MagnetOffset;
		}
	}
}
