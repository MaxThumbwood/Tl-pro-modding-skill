using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x0200095D RID: 2397
	[Token(Token = "0x200095D")]
	public class DoorOpeningHelper
	{
		// Token: 0x06004FCC RID: 20428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FCC")]
		[Address(RVA = "0x755254", Offset = "0x755254", VA = "0x755254")]
		public void AllowOpeningDoorsByVelocityAloneForATime(int timeInFramesToAllow)
		{
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FCD")]
		[Address(RVA = "0x75525C", Offset = "0x75525C", VA = "0x75525C")]
		public void Update(Player player)
		{
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x00025290 File Offset: 0x00023490
		[Token(Token = "0x6004FCE")]
		[Address(RVA = "0x755478", Offset = "0x755478", VA = "0x755478")]
		private bool ShouldTryOpeningDoors()
		{
			return default(bool);
		}

		// Token: 0x06004FCF RID: 20431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FCF")]
		[Address(RVA = "0x7556C8", Offset = "0x7556C8", VA = "0x7556C8")]
		public static void CyclePreferences()
		{
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FD0")]
		[Address(RVA = "0x755298", Offset = "0x755298", VA = "0x755298")]
		public void LookForDoorsToClose(Player player)
		{
		}

		// Token: 0x06004FD1 RID: 20433 RVA: 0x000252A8 File Offset: 0x000234A8
		[Token(Token = "0x6004FD1")]
		[Address(RVA = "0x7557AC", Offset = "0x7557AC", VA = "0x7557AC")]
		private DoorOpeningHelper.PlayerInfoForClosingDoors GetPlayerInfoForClosingDoor(Player player)
		{
			return default(DoorOpeningHelper.PlayerInfoForClosingDoors);
		}

		// Token: 0x06004FD2 RID: 20434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FD2")]
		[Address(RVA = "0x75552C", Offset = "0x75552C", VA = "0x75552C")]
		public void LookForDoorsToOpen(Player player)
		{
		}

		// Token: 0x06004FD3 RID: 20435 RVA: 0x000252C0 File Offset: 0x000234C0
		[Token(Token = "0x6004FD3")]
		[Address(RVA = "0x7557FC", Offset = "0x7557FC", VA = "0x7557FC")]
		private DoorOpeningHelper.PlayerInfoForOpeningDoors GetPlayerInfoForOpeningDoor(Player player)
		{
			return default(DoorOpeningHelper.PlayerInfoForOpeningDoors);
		}

		// Token: 0x06004FD4 RID: 20436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FD4")]
		[Address(RVA = "0x755B8C", Offset = "0x755B8C", VA = "0x755B8C")]
		private void TryAutoOpeningDoor(Point tileCoords, DoorOpeningHelper.PlayerInfoForOpeningDoors playerInfo)
		{
		}

		// Token: 0x06004FD5 RID: 20437 RVA: 0x000252D8 File Offset: 0x000234D8
		[Token(Token = "0x6004FD5")]
		[Address(RVA = "0x755E34", Offset = "0x755E34", VA = "0x755E34")]
		private bool TryGetHandler(Point tileCoords, out DoorOpeningHelper.DoorAutoHandler infoProvider)
		{
			return default(bool);
		}

		// Token: 0x06004FD6 RID: 20438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FD6")]
		[Address(RVA = "0x756004", Offset = "0x756004", VA = "0x756004")]
		public DoorOpeningHelper()
		{
		}

		// Token: 0x040093AF RID: 37807
		[Token(Token = "0x40093AF")]
		[FieldOffset(Offset = "0x0")]
		public static DoorOpeningHelper.DoorAutoOpeningPreference PreferenceSettings;

		// Token: 0x040093B0 RID: 37808
		[Token(Token = "0x40093B0")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<int, DoorOpeningHelper.DoorAutoHandler> _handlerByTileType;

		// Token: 0x040093B1 RID: 37809
		[Token(Token = "0x40093B1")]
		[FieldOffset(Offset = "0xC")]
		private List<DoorOpeningHelper.DoorOpenCloseTogglingInfo> _ongoingOpenDoors;

		// Token: 0x040093B2 RID: 37810
		[Token(Token = "0x40093B2")]
		[FieldOffset(Offset = "0x10")]
		private int _timeWeCanOpenDoorsUsingVelocityAlone;

		// Token: 0x0200095E RID: 2398
		[Token(Token = "0x200095E")]
		public enum DoorAutoOpeningPreference
		{
			// Token: 0x040093B4 RID: 37812
			[Token(Token = "0x40093B4")]
			Disabled,
			// Token: 0x040093B5 RID: 37813
			[Token(Token = "0x40093B5")]
			EnabledForGamepadOnly,
			// Token: 0x040093B6 RID: 37814
			[Token(Token = "0x40093B6")]
			EnabledForEverything
		}

		// Token: 0x0200095F RID: 2399
		[Token(Token = "0x200095F")]
		private enum DoorCloseAttemptResult
		{
			// Token: 0x040093B8 RID: 37816
			[Token(Token = "0x40093B8")]
			StillInDoorArea,
			// Token: 0x040093B9 RID: 37817
			[Token(Token = "0x40093B9")]
			ClosedDoor,
			// Token: 0x040093BA RID: 37818
			[Token(Token = "0x40093BA")]
			FailedToCloseDoor,
			// Token: 0x040093BB RID: 37819
			[Token(Token = "0x40093BB")]
			DoorIsInvalidated
		}

		// Token: 0x02000960 RID: 2400
		[Token(Token = "0x2000960")]
		private struct DoorOpenCloseTogglingInfo
		{
			// Token: 0x040093BC RID: 37820
			[Token(Token = "0x40093BC")]
			[FieldOffset(Offset = "0x0")]
			public Point tileCoordsForToggling;

			// Token: 0x040093BD RID: 37821
			[Token(Token = "0x40093BD")]
			[FieldOffset(Offset = "0x8")]
			public DoorOpeningHelper.DoorAutoHandler handler;
		}

		// Token: 0x02000961 RID: 2401
		[Token(Token = "0x2000961")]
		private struct PlayerInfoForOpeningDoors
		{
			// Token: 0x040093BE RID: 37822
			[Token(Token = "0x40093BE")]
			[FieldOffset(Offset = "0x0")]
			public Rectangle hitboxToOpenDoor;

			// Token: 0x040093BF RID: 37823
			[Token(Token = "0x40093BF")]
			[FieldOffset(Offset = "0x10")]
			public int intendedOpeningDirection;

			// Token: 0x040093C0 RID: 37824
			[Token(Token = "0x40093C0")]
			[FieldOffset(Offset = "0x14")]
			public int playerGravityDirection;

			// Token: 0x040093C1 RID: 37825
			[Token(Token = "0x40093C1")]
			[FieldOffset(Offset = "0x18")]
			public Rectangle tileCoordSpaceForCheckingForDoors;
		}

		// Token: 0x02000962 RID: 2402
		[Token(Token = "0x2000962")]
		private struct PlayerInfoForClosingDoors
		{
			// Token: 0x040093C2 RID: 37826
			[Token(Token = "0x40093C2")]
			[FieldOffset(Offset = "0x0")]
			public Rectangle hitboxToNotCloseDoor;
		}

		// Token: 0x02000963 RID: 2403
		[Token(Token = "0x2000963")]
		private interface DoorAutoHandler
		{
			// Token: 0x06004FD8 RID: 20440
			[Token(Token = "0x6004FD8")]
			DoorOpeningHelper.DoorOpenCloseTogglingInfo ProvideInfo(Point tileCoords);

			// Token: 0x06004FD9 RID: 20441
			[Token(Token = "0x6004FD9")]
			bool TryOpenDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo info, DoorOpeningHelper.PlayerInfoForOpeningDoors playerInfo);

			// Token: 0x06004FDA RID: 20442
			[Token(Token = "0x6004FDA")]
			DoorOpeningHelper.DoorCloseAttemptResult TryCloseDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo info, DoorOpeningHelper.PlayerInfoForClosingDoors playerInfo);
		}

		// Token: 0x02000964 RID: 2404
		[Token(Token = "0x2000964")]
		private class CommonDoorOpeningInfoProvider : FileAPI
		{
			// Token: 0x06004FDB RID: 20443 RVA: 0x000252F0 File Offset: 0x000234F0
			[Token(Token = "0x6004FDB")]
			[Address(RVA = "0x75623C", Offset = "0x75623C", VA = "0x75623C", Slot = "4")]
			public DoorOpeningHelper.DoorOpenCloseTogglingInfo ProvideInfo(Point tileCoords)
			{
				return default(DoorOpeningHelper.DoorOpenCloseTogglingInfo);
			}

			// Token: 0x06004FDC RID: 20444 RVA: 0x00025308 File Offset: 0x00023508
			[Token(Token = "0x6004FDC")]
			[Address(RVA = "0x7563AC", Offset = "0x7563AC", VA = "0x7563AC", Slot = "5")]
			public bool TryOpenDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo doorInfo, DoorOpeningHelper.PlayerInfoForOpeningDoors playerInfo)
			{
				return default(bool);
			}

			// Token: 0x06004FDD RID: 20445 RVA: 0x00025320 File Offset: 0x00023520
			[Token(Token = "0x6004FDD")]
			[Address(RVA = "0x75685C", Offset = "0x75685C", VA = "0x75685C", Slot = "6")]
			public DoorOpeningHelper.DoorCloseAttemptResult TryCloseDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo info, DoorOpeningHelper.PlayerInfoForClosingDoors playerInfo)
			{
				return DoorOpeningHelper.DoorCloseAttemptResult.StillInDoorArea;
			}

			// Token: 0x06004FDE RID: 20446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FDE")]
			[Address(RVA = "0x7561D8", Offset = "0x7561D8", VA = "0x7561D8")]
			public CommonDoorOpeningInfoProvider()
			{
			}
		}

		// Token: 0x02000965 RID: 2405
		[Token(Token = "0x2000965")]
		private class TallGateOpeningInfoProvider : FileAPI
		{
			// Token: 0x06004FDF RID: 20447 RVA: 0x00025338 File Offset: 0x00023538
			[Token(Token = "0x6004FDF")]
			[Address(RVA = "0x756CE0", Offset = "0x756CE0", VA = "0x756CE0", Slot = "4")]
			public DoorOpeningHelper.DoorOpenCloseTogglingInfo ProvideInfo(Point tileCoords)
			{
				return default(DoorOpeningHelper.DoorOpenCloseTogglingInfo);
			}

			// Token: 0x06004FE0 RID: 20448 RVA: 0x00025350 File Offset: 0x00023550
			[Token(Token = "0x6004FE0")]
			[Address(RVA = "0x756E50", Offset = "0x756E50", VA = "0x756E50", Slot = "5")]
			public bool TryOpenDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo doorInfo, DoorOpeningHelper.PlayerInfoForOpeningDoors playerInfo)
			{
				return default(bool);
			}

			// Token: 0x06004FE1 RID: 20449 RVA: 0x00025368 File Offset: 0x00023568
			[Token(Token = "0x6004FE1")]
			[Address(RVA = "0x757114", Offset = "0x757114", VA = "0x757114", Slot = "6")]
			public DoorOpeningHelper.DoorCloseAttemptResult TryCloseDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo info, DoorOpeningHelper.PlayerInfoForClosingDoors playerInfo)
			{
				return DoorOpeningHelper.DoorCloseAttemptResult.StillInDoorArea;
			}

			// Token: 0x06004FE2 RID: 20450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FE2")]
			[Address(RVA = "0x7561E0", Offset = "0x7561E0", VA = "0x7561E0")]
			public TallGateOpeningInfoProvider()
			{
			}
		}
	}
}
