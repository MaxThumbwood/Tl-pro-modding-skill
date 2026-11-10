using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Renderers;

namespace Terraria
{
	// Token: 0x02000465 RID: 1125
	[Token(Token = "0x2000465")]
	public class Chest : FileAPI
	{
		// Token: 0x06001EFE RID: 7934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFE")]
		[Address(RVA = "0xF0CD0C", Offset = "0xF0CD0C", VA = "0xF0CD0C")]
		public static void Clear()
		{
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EFF")]
		[Address(RVA = "0xF0CE00", Offset = "0xF0CE00", VA = "0xF0CE00")]
		public static Chest CreateWorldChest(int index, int x, int y)
		{
			return null;
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F00")]
		[Address(RVA = "0xF0D098", Offset = "0xF0D098", VA = "0xF0D098")]
		public static void Assign(Chest chest)
		{
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F01")]
		[Address(RVA = "0xF0D1F0", Offset = "0xF0D1F0", VA = "0xF0D1F0")]
		public void Resize(int newSize)
		{
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F02")]
		[Address(RVA = "0xF0D1F8", Offset = "0xF0D1F8", VA = "0xF0D1F8")]
		public static void RemoveChest(int chestIndex)
		{
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F03")]
		[Address(RVA = "0xF0D350", Offset = "0xF0D350", VA = "0xF0D350")]
		public static Chest CreateBank(int index)
		{
			return null;
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F04")]
		[Address(RVA = "0xF0D45C", Offset = "0xF0D45C", VA = "0xF0D45C")]
		public static Chest CreateShop()
		{
			return null;
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F05")]
		[Address(RVA = "0xF0D560", Offset = "0xF0D560", VA = "0xF0D560")]
		public static Chest CreateOutOfArray(int index, int x, int y, int maxItems)
		{
			return null;
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F06")]
		[Address(RVA = "0xF0D040", Offset = "0xF0D040", VA = "0xF0D040")]
		public void FillWithEmptyInstances()
		{
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		[Token(Token = "0x6001F07")]
		[Address(RVA = "0xF0D670", Offset = "0xF0D670", VA = "0xF0D670")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		[Token(Token = "0x6001F08")]
		[Address(RVA = "0xF0D6D4", Offset = "0xF0D6D4", VA = "0xF0D6D4")]
		public bool IsLockedOrInUse()
		{
			return default(bool);
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F09")]
		[Address(RVA = "0xF0CF80", Offset = "0xF0CF80", VA = "0xF0CF80")]
		public Chest(int index = 0, int x = 0, int y = 0, bool bank = false, int maxItems = 40)
		{
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F0A")]
		[Address(RVA = "0xF0DA28", Offset = "0xF0DA28", VA = "0xF0DA28", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F0B")]
		[Address(RVA = "0xF0DB48", Offset = "0xF0DB48", VA = "0xF0DB48")]
		public Chest CloneWithSeparateItems()
		{
			return null;
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F0C")]
		[Address(RVA = "0xF0DCF0", Offset = "0xF0DCF0", VA = "0xF0DCF0")]
		public static void Initialize()
		{
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x0000EE08 File Offset: 0x0000D008
		[Token(Token = "0x6001F0D")]
		[Address(RVA = "0xF0D788", Offset = "0xF0D788", VA = "0xF0D788")]
		public static bool IsPlayerInChest(int i)
		{
			return default(bool);
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F0E")]
		[Address(RVA = "0xF0DF34", Offset = "0xF0DF34", VA = "0xF0DF34")]
		public static List<int> GetCurrentlyOpenChests()
		{
			return null;
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x0000EE20 File Offset: 0x0000D020
		[Token(Token = "0x6001F0F")]
		[Address(RVA = "0xF0D85C", Offset = "0xF0D85C", VA = "0xF0D85C")]
		public static bool IsLocked(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x0000EE38 File Offset: 0x0000D038
		[Token(Token = "0x6001F10")]
		[Address(RVA = "0xF0E124", Offset = "0xF0E124", VA = "0xF0E124")]
		public static bool IsLocked(Tile t)
		{
			return default(bool);
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F11")]
		[Address(RVA = "0xF0E860", Offset = "0xF0E860", VA = "0xF0E860")]
		public static void VisualizeChestTransfer(Vector2 position, Vector2 chestPosition, int itemType, Chest.ItemTransferVisualizationSettings settings)
		{
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F12")]
		[Address(RVA = "0xF0E994", Offset = "0xF0E994", VA = "0xF0E994")]
		public static void VisualizeChestTransfer_CoinsBatch(Vector2 position, Vector2 chestPosition, long coinsMoved, Chest.ItemTransferVisualizationSettings settings)
		{
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F13")]
		[Address(RVA = "0xF0EAB4", Offset = "0xF0EAB4", VA = "0xF0EAB4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x0000EE50 File Offset: 0x0000D050
		[Token(Token = "0x6001F14")]
		[Address(RVA = "0xF0EABC", Offset = "0xF0EABC", VA = "0xF0EABC")]
		public static bool Unlock(int X, int Y)
		{
			return default(bool);
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x0000EE68 File Offset: 0x0000D068
		[Token(Token = "0x6001F15")]
		[Address(RVA = "0xF0F2B4", Offset = "0xF0F2B4", VA = "0xF0F2B4")]
		public static bool Lock(int X, int Y)
		{
			return default(bool);
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x0000EE80 File Offset: 0x0000D080
		[Token(Token = "0x6001F16")]
		[Address(RVA = "0xF0F83C", Offset = "0xF0F83C", VA = "0xF0F83C")]
		public static int UsingChest(int i)
		{
			return 0;
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x0000EE98 File Offset: 0x0000D098
		[Token(Token = "0x6001F17")]
		[Address(RVA = "0xF0F990", Offset = "0xF0F990", VA = "0xF0F990")]
		public static int FindChest(int X, int Y)
		{
			return 0;
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		[Token(Token = "0x6001F18")]
		[Address(RVA = "0xF0FA90", Offset = "0xF0FA90", VA = "0xF0FA90")]
		public static int FindEmptyChest(int x, int y, int type = 21, int style = 0, int direction = 1, int alternate = 0)
		{
			return 0;
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
		[Token(Token = "0x6001F19")]
		[Address(RVA = "0xF0FB54", Offset = "0xF0FB54", VA = "0xF0FB54")]
		public static bool NearOtherChests(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		[Token(Token = "0x6001F1A")]
		[Address(RVA = "0xF0FDE4", Offset = "0xF0FDE4", VA = "0xF0FDE4")]
		public static int AfterPlacement_Hook(int x, int y, int type = 21, int style = 0, int direction = 1, int alternate = 0)
		{
			return 0;
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x0000EEF8 File Offset: 0x0000D0F8
		[Token(Token = "0x6001F1B")]
		[Address(RVA = "0xF10140", Offset = "0xF10140", VA = "0xF10140")]
		public static int CreateChest(int X, int Y, int id = -1)
		{
			return 0;
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x0000EF10 File Offset: 0x0000D110
		[Token(Token = "0x6001F1C")]
		[Address(RVA = "0xF102DC", Offset = "0xF102DC", VA = "0xF102DC")]
		public static bool CanDestroyChest(int X, int Y)
		{
			return default(bool);
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x0000EF28 File Offset: 0x0000D128
		[Token(Token = "0x6001F1D")]
		[Address(RVA = "0xF10608", Offset = "0xF10608", VA = "0xF10608")]
		public static bool DestroyChest(int X, int Y)
		{
			return default(bool);
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1E")]
		[Address(RVA = "0xF1090C", Offset = "0xF1090C", VA = "0xF1090C")]
		public static void DestroyChestDirect(int X, int Y, int id)
		{
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1F")]
		[Address(RVA = "0xF10BEC", Offset = "0xF10BEC", VA = "0xF10BEC")]
		public static void AskForChestToEatItem(Vector2 worldPosition, int duration)
		{
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F20")]
		[Address(RVA = "0xF10D5C", Offset = "0xF10D5C", VA = "0xF10D5C")]
		private static FadingPlayerShaderParticle GetNewFadingPlayerShaderParticle(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F21")]
		[Address(RVA = "0xF10DD0", Offset = "0xF10DD0", VA = "0xF10DD0")]
		private static RoomCheckParticle GetNewParticle(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F22")]
		[Address(RVA = "0xF10E44", Offset = "0xF10E44", VA = "0xF10E44")]
		public static void IndicateBlockedChest(int chestIndex)
		{
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F23")]
		[Address(RVA = "0xF11400", Offset = "0xF11400", VA = "0xF11400")]
		public static void UpdateChestFrames()
		{
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F24")]
		[Address(RVA = "0xF11824", Offset = "0xF11824", VA = "0xF11824", Slot = "4")]
		public void FixLoadedData()
		{
		}

		// Token: 0x0400319C RID: 12700
		[Token(Token = "0x400319C")]
		[FieldOffset(Offset = "0x0")]
		private static HashSet<int> _chestInUse;

		// Token: 0x0400319D RID: 12701
		[Token(Token = "0x400319D")]
		public const float chestStackRange = 600f;

		// Token: 0x0400319E RID: 12702
		[Token(Token = "0x400319E")]
		public const int maxChestTypes = 52;

		// Token: 0x0400319F RID: 12703
		[Token(Token = "0x400319F")]
		[FieldOffset(Offset = "0x4")]
		public static int[] chestTypeToIcon;

		// Token: 0x040031A0 RID: 12704
		[Token(Token = "0x40031A0")]
		public const int maxChestTypes2 = 38;

		// Token: 0x040031A1 RID: 12705
		[Token(Token = "0x40031A1")]
		[FieldOffset(Offset = "0x8")]
		public static int[] chestTypeToIcon2;

		// Token: 0x040031A2 RID: 12706
		[Token(Token = "0x40031A2")]
		public const int maxDresserTypes = 65;

		// Token: 0x040031A3 RID: 12707
		[Token(Token = "0x40031A3")]
		[FieldOffset(Offset = "0xC")]
		public static int[] dresserTypeToIcon;

		// Token: 0x040031A4 RID: 12708
		[Token(Token = "0x40031A4")]
		public const int DefaultMaxItems = 40;

		// Token: 0x040031A5 RID: 12709
		[Token(Token = "0x40031A5")]
		public const int AbsoluteMaxItemsWeCanEverReachInAChestForNow = 200;

		// Token: 0x040031A6 RID: 12710
		[Token(Token = "0x40031A6")]
		[FieldOffset(Offset = "0x8")]
		public int maxItems;

		// Token: 0x040031A7 RID: 12711
		[Token(Token = "0x40031A7")]
		public const int MaxNameLength = 29;

		// Token: 0x040031A8 RID: 12712
		[Token(Token = "0x40031A8")]
		[FieldOffset(Offset = "0xC")]
		public ChestItem[] item;

		// Token: 0x040031A9 RID: 12713
		[Token(Token = "0x40031A9")]
		[FieldOffset(Offset = "0x10")]
		public readonly int x;

		// Token: 0x040031AA RID: 12714
		[Token(Token = "0x40031AA")]
		[FieldOffset(Offset = "0x14")]
		public readonly int y;

		// Token: 0x040031AB RID: 12715
		[Token(Token = "0x40031AB")]
		[FieldOffset(Offset = "0x18")]
		public readonly int index;

		// Token: 0x040031AC RID: 12716
		[Token(Token = "0x40031AC")]
		[FieldOffset(Offset = "0x1C")]
		public bool bankChest;

		// Token: 0x040031AD RID: 12717
		[Token(Token = "0x40031AD")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x040031AE RID: 12718
		[Token(Token = "0x40031AE")]
		[FieldOffset(Offset = "0x24")]
		public int frameCounter;

		// Token: 0x040031AF RID: 12719
		[Token(Token = "0x40031AF")]
		[FieldOffset(Offset = "0x28")]
		public int frame;

		// Token: 0x040031B0 RID: 12720
		[Token(Token = "0x40031B0")]
		[FieldOffset(Offset = "0x2C")]
		public int eatingAnimationTime;

		// Token: 0x040031B1 RID: 12721
		[Token(Token = "0x40031B1")]
		[FieldOffset(Offset = "0x30")]
		public bool inUseByPlayer;

		// Token: 0x040031B2 RID: 12722
		[Token(Token = "0x40031B2")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<Point, Chest> _chestsByCoords;

		// Token: 0x040031B3 RID: 12723
		[Token(Token = "0x40031B3")]
		[FieldOffset(Offset = "0x14")]
		private static ParticlePoolType<RoomCheckParticle> _particlePool;

		// Token: 0x02000466 RID: 1126
		[Token(Token = "0x2000466")]
		public struct ItemTransferVisualizationSettings
		{
			// Token: 0x040031B4 RID: 12724
			[Token(Token = "0x40031B4")]
			[FieldOffset(Offset = "0x0")]
			public bool RandomizeStartPosition;

			// Token: 0x040031B5 RID: 12725
			[Token(Token = "0x40031B5")]
			[FieldOffset(Offset = "0x1")]
			public bool RandomizeEndPosition;

			// Token: 0x040031B6 RID: 12726
			[Token(Token = "0x40031B6")]
			[FieldOffset(Offset = "0x2")]
			public bool TransitionIn;

			// Token: 0x040031B7 RID: 12727
			[Token(Token = "0x40031B7")]
			[FieldOffset(Offset = "0x3")]
			public bool Fullbright;

			// Token: 0x040031B8 RID: 12728
			[Token(Token = "0x40031B8")]
			[FieldOffset(Offset = "0x0")]
			public static Chest.ItemTransferVisualizationSettings PlayerToChest;

			// Token: 0x040031B9 RID: 12729
			[Token(Token = "0x40031B9")]
			[FieldOffset(Offset = "0x4")]
			public static Chest.ItemTransferVisualizationSettings Hopper;
		}
	}
}
