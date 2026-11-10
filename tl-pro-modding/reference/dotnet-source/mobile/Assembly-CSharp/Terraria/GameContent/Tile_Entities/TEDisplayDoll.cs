using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x020009F5 RID: 2549
	[Token(Token = "0x20009F5")]
	public class TEDisplayDoll : TileEntityType<TEDisplayDoll>, FileAPI
	{
		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x060052DB RID: 21211 RVA: 0x00026928 File Offset: 0x00024B28
		[Token(Token = "0x170009C2")]
		public ArraySegment<Item> AccSlots
		{
			[Token(Token = "0x60052DB")]
			[Address(RVA = "0x7E8F9C", Offset = "0x7E8F9C", VA = "0x7E8F9C")]
			get
			{
				return default(ArraySegment<Item>);
			}
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052DD")]
		[Address(RVA = "0x7E955C", Offset = "0x7E955C", VA = "0x7E955C")]
		private static void RegisterUsePose(int useStyle, DisplayDollPoseID pose, float usePercent, [Optional] float? useAim)
		{
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052DE")]
		[Address(RVA = "0x7E9794", Offset = "0x7E9794", VA = "0x7E9794")]
		public TEDisplayDoll()
		{
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x00026940 File Offset: 0x00024B40
		[Token(Token = "0x60052DF")]
		[Address(RVA = "0x7E9BB4", Offset = "0x7E9BB4", VA = "0x7E9BB4")]
		public static int Hook_AfterPlacement(int x, int y, int type = 470, int style = 0, int direction = 1, int alternate = 0)
		{
			return 0;
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x00026958 File Offset: 0x00024B58
		[Token(Token = "0x60052E0")]
		[Address(RVA = "0x7E9DE4", Offset = "0x7E9DE4", VA = "0x7E9DE4")]
		private bool IsValidPose(int testedPose)
		{
			return default(bool);
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E1")]
		[Address(RVA = "0x7EA07C", Offset = "0x7EA07C", VA = "0x7EA07C", Slot = "7")]
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E2")]
		[Address(RVA = "0x7EA8D0", Offset = "0x7EA8D0", VA = "0x7EA8D0", Slot = "8")]
		public override void ReadExtraData(BinaryReader reader, int gameVersion, bool networkSend)
		{
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E3")]
		[Address(RVA = "0x7EAFC4", Offset = "0x7EAFC4", VA = "0x7EAFC4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E4")]
		[Address(RVA = "0x7EB334", Offset = "0x7EB334", VA = "0x7EB334")]
		public static void Framing_CheckTile(int callX, int callY)
		{
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E5")]
		[Address(RVA = "0x7EBBB8", Offset = "0x7EBBB8", VA = "0x7EBBB8")]
		public void Draw(int tileLeftX, int tileTopY)
		{
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E6")]
		[Address(RVA = "0x7ECFDC", Offset = "0x7ECFDC", VA = "0x7ECFDC", Slot = "9")]
		public override void OnPlayerUpdate(Player player)
		{
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E7")]
		[Address(RVA = "0x7ED120", Offset = "0x7ED120", VA = "0x7ED120")]
		public static void OnPlayerInteraction(Player player, int clickX, int clickY)
		{
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E8")]
		[Address(RVA = "0x7ED3D4", Offset = "0x7ED3D4", VA = "0x7ED3D4")]
		private void DrawUI(Player player, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E9")]
		[Address(RVA = "0x7ED504", Offset = "0x7ED504", VA = "0x7ED504")]
		private void DrawSlotMisc(Player player, SpriteBatch spriteBatch, int slotsToShowLine, int slotsArrayOffset, float offsetX, float offsetY, int inventoryContextTarget)
		{
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052EA")]
		[Address(RVA = "0x7ED8CC", Offset = "0x7ED8CC", VA = "0x7ED8CC")]
		private void DrawSlotPairSet(Player player, SpriteBatch spriteBatch, int slotsToShowLine, int slotsArrayOffset, float offsetX, float offsetY, int inventoryContextTarget)
		{
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x00026970 File Offset: 0x00024B70
		[Token(Token = "0x60052EB")]
		[Address(RVA = "0x7EDCCC", Offset = "0x7EDCCC", VA = "0x7EDCCC", Slot = "11")]
		public override bool OverrideItemSlotHover(Item[] inv, int context = 0, int slot = 0)
		{
			return default(bool);
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x00026988 File Offset: 0x00024B88
		[Token(Token = "0x60052EC")]
		[Address(RVA = "0x7EDF24", Offset = "0x7EDF24", VA = "0x7EDF24", Slot = "12")]
		public override bool OverrideItemSlotLeftClick(Item[] inv, int context = 0, int slot = 0)
		{
			return default(bool);
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x000269A0 File Offset: 0x00024BA0
		[Token(Token = "0x60052ED")]
		[Address(RVA = "0x7EDE50", Offset = "0x7EDE50", VA = "0x7EDE50")]
		public static bool CanQuickSwapIntoDisplayDoll(Item item)
		{
			return default(bool);
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x000269B8 File Offset: 0x00024BB8
		[Token(Token = "0x60052EE")]
		[Address(RVA = "0x7EE6C4", Offset = "0x7EE6C4", VA = "0x7EE6C4")]
		public static bool AcceptedInWeaponSlot(Item item)
		{
			return default(bool);
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x000269D0 File Offset: 0x00024BD0
		[Token(Token = "0x60052EF")]
		[Address(RVA = "0x7EE328", Offset = "0x7EE328", VA = "0x7EE328")]
		private bool TryFitting(Item[] inv, int slot)
		{
			return default(bool);
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x000269E8 File Offset: 0x00024BE8
		[Token(Token = "0x60052F0")]
		[Address(RVA = "0x7EE708", Offset = "0x7EE708", VA = "0x7EE708")]
		private int GetAccessoryTargetSlot(Item item)
		{
			return 0;
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F1")]
		[Address(RVA = "0x7EE958", Offset = "0x7EE958", VA = "0x7EE958")]
		public void WriteItem(int itemIndex, BinaryWriter writer, Item[] collection)
		{
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F2")]
		[Address(RVA = "0x7EEA04", Offset = "0x7EEA04", VA = "0x7EEA04")]
		public void ReadItem(int itemIndex, BinaryReader reader, Item[] collection)
		{
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F3")]
		[Address(RVA = "0x7EEB04", Offset = "0x7EEB04", VA = "0x7EEB04")]
		public void WriteData(int itemIndex, int command, BinaryWriter writer)
		{
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F4")]
		[Address(RVA = "0x7EEB70", Offset = "0x7EEB70", VA = "0x7EEB70")]
		public void ReadData(int itemIndex, int command, BinaryReader reader)
		{
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F5")]
		[Address(RVA = "0x7EEC10", Offset = "0x7EEC10", VA = "0x7EEC10")]
		public static void WriteDummySync(int itemIndex, int command, BinaryWriter writer)
		{
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F6")]
		[Address(RVA = "0x7EEC64", Offset = "0x7EEC64", VA = "0x7EEC64")]
		public static void ReadDummySync(int itemIndex, int command, BinaryReader reader)
		{
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F7")]
		[Address(RVA = "0x7EEBDC", Offset = "0x7EEBDC", VA = "0x7EEBDC")]
		public void ReadPose(BinaryReader reader)
		{
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x00026A00 File Offset: 0x00024C00
		[Token(Token = "0x60052F8")]
		[Address(RVA = "0x7EECB0", Offset = "0x7EECB0", VA = "0x7EECB0", Slot = "15")]
		public override bool IsTileValidForEntity(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F9")]
		[Address(RVA = "0x7EF064", Offset = "0x7EF064", VA = "0x7EF064")]
		public void SetInventoryFromMannequin(int headFrame, int shirtFrame, int legFrame)
		{
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x00026A18 File Offset: 0x00024C18
		[Token(Token = "0x60052FA")]
		[Address(RVA = "0x7EF304", Offset = "0x7EF304", VA = "0x7EF304")]
		public static bool IsBreakable(int clickX, int clickY)
		{
			return default(bool);
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x00026A30 File Offset: 0x00024C30
		[Token(Token = "0x60052FB")]
		[Address(RVA = "0x7EF6E8", Offset = "0x7EF6E8", VA = "0x7EF6E8")]
		public static bool TryChangePose(int clickX, int clickY)
		{
			return default(bool);
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052FC")]
		[Address(RVA = "0x7EFAA8", Offset = "0x7EFAA8", VA = "0x7EFAA8")]
		public void ChangePose()
		{
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x00026A48 File Offset: 0x00024C48
		[Token(Token = "0x60052FD")]
		[Address(RVA = "0x7EF5BC", Offset = "0x7EF5BC", VA = "0x7EF5BC")]
		public bool ContainsItems()
		{
			return default(bool);
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052FE")]
		[Address(RVA = "0x7EFAD8", Offset = "0x7EFAD8", VA = "0x7EFAD8", Slot = "18")]
		public void FixLoadedData()
		{
		}

		// Token: 0x04009716 RID: 38678
		[Token(Token = "0x4009716")]
		private const int MyTileID = 470;

		// Token: 0x04009717 RID: 38679
		[Token(Token = "0x4009717")]
		public const int entityTileWidth = 2;

		// Token: 0x04009718 RID: 38680
		[Token(Token = "0x4009718")]
		public const int entityTileHeight = 3;

		// Token: 0x04009719 RID: 38681
		[Token(Token = "0x4009719")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int lastDrawFrame;

		// Token: 0x0400971A RID: 38682
		[Token(Token = "0x400971A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static Player _dollPlayer;

		// Token: 0x0400971B RID: 38683
		[Token(Token = "0x400971B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Item[] _equip;

		// Token: 0x0400971C RID: 38684
		[Token(Token = "0x400971C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Item[] _dyes;

		// Token: 0x0400971D RID: 38685
		[Token(Token = "0x400971D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Item[] _misc;

		// Token: 0x0400971E RID: 38686
		[Token(Token = "0x400971E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public byte _pose;

		// Token: 0x0400971F RID: 38687
		[Token(Token = "0x400971F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _lastMountDrawn;

		// Token: 0x04009720 RID: 38688
		[Token(Token = "0x4009720")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Dictionary<int, List<TEDisplayDoll.DisplayDollPose>> SupportedUseStylePoses;

		// Token: 0x04009721 RID: 38689
		[Token(Token = "0x4009721")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static Projectile _projectileDummy;

		// Token: 0x020009F6 RID: 2550
		[Token(Token = "0x20009F6")]
		public struct DisplayDollPose
		{
			// Token: 0x04009722 RID: 38690
			[Token(Token = "0x4009722")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public DisplayDollPoseID Pose;

			// Token: 0x04009723 RID: 38691
			[Token(Token = "0x4009723")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float ItemAnimationPercent;

			// Token: 0x04009724 RID: 38692
			[Token(Token = "0x4009724")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float? ItemAimRadians;
		}
	}
}
