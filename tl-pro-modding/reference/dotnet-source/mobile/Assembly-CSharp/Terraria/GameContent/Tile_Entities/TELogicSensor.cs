using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x02000A00 RID: 2560
	[Token(Token = "0x2000A00")]
	public class TELogicSensor : TileEntityType<TELogicSensor>
	{
		// Token: 0x06005352 RID: 21330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005352")]
		[Address(RVA = "0x7F90F0", Offset = "0x7F90F0", VA = "0x7F90F0", Slot = "13")]
		public override void RegisterTileEntityID(int assignedID)
		{
		}

		// Token: 0x06005353 RID: 21331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005353")]
		[Address(RVA = "0x7F9240", Offset = "0x7F9240", VA = "0x7F9240", Slot = "4")]
		public override void OnPlaced()
		{
		}

		// Token: 0x06005354 RID: 21332 RVA: 0x00026CA0 File Offset: 0x00024EA0
		[Token(Token = "0x6005354")]
		[Address(RVA = "0x7F9370", Offset = "0x7F9370", VA = "0x7F9370", Slot = "15")]
		public override bool IsTileValidForEntity(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005355 RID: 21333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005355")]
		[Address(RVA = "0x7F97A4", Offset = "0x7F97A4", VA = "0x7F97A4")]
		private static void UpdateStartInternal()
		{
		}

		// Token: 0x06005356 RID: 21334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005356")]
		[Address(RVA = "0x7F9890", Offset = "0x7F9890", VA = "0x7F9890")]
		private static void FillPlayerHitboxes()
		{
		}

		// Token: 0x06005357 RID: 21335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005357")]
		[Address(RVA = "0x7F9A48", Offset = "0x7F9A48", VA = "0x7F9A48")]
		private static void UpdateEndInternal()
		{
		}

		// Token: 0x06005358 RID: 21336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005358")]
		[Address(RVA = "0x7FA04C", Offset = "0x7FA04C", VA = "0x7FA04C", Slot = "6")]
		public override void Update()
		{
		}

		// Token: 0x06005359 RID: 21337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005359")]
		[Address(RVA = "0x7FA958", Offset = "0x7FA958", VA = "0x7FA958")]
		public void ChangeState(bool onState, bool TripWire)
		{
		}

		// Token: 0x0600535A RID: 21338 RVA: 0x00026CB8 File Offset: 0x00024EB8
		[Token(Token = "0x600535A")]
		[Address(RVA = "0x7F93DC", Offset = "0x7F93DC", VA = "0x7F93DC")]
		public static bool ValidTile(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600535B")]
		[Address(RVA = "0x7FAEDC", Offset = "0x7FAEDC", VA = "0x7FAEDC")]
		public TELogicSensor()
		{
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x00026CD0 File Offset: 0x00024ED0
		[Token(Token = "0x600535C")]
		[Address(RVA = "0x7FAF44", Offset = "0x7FAF44", VA = "0x7FAF44")]
		public static TELogicSensor.LogicCheckType FigureCheckType(int x, int y, out bool on)
		{
			return TELogicSensor.LogicCheckType.None;
		}

		// Token: 0x0600535D RID: 21341 RVA: 0x00026CE8 File Offset: 0x00024EE8
		[Token(Token = "0x600535D")]
		[Address(RVA = "0x7FA154", Offset = "0x7FA154", VA = "0x7FA154")]
		public static bool GetState(int x, int y, TELogicSensor.LogicCheckType type, [Optional] TELogicSensor instance)
		{
			return default(bool);
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600535E")]
		[Address(RVA = "0x7F92D8", Offset = "0x7F92D8", VA = "0x7F92D8")]
		public void FigureCheckState()
		{
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600535F")]
		[Address(RVA = "0x7FB144", Offset = "0x7FB144", VA = "0x7FB144")]
		public static void GetFrame(int x, int y, TELogicSensor.LogicCheckType type, bool on)
		{
		}

		// Token: 0x06005360 RID: 21344 RVA: 0x00026D00 File Offset: 0x00024F00
		[Token(Token = "0x6005360")]
		[Address(RVA = "0x7FAC8C", Offset = "0x7FAC8C", VA = "0x7FAC8C")]
		public static bool SanityCheck(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005361 RID: 21345 RVA: 0x00026D18 File Offset: 0x00024F18
		[Token(Token = "0x6005361")]
		[Address(RVA = "0x7FB950", Offset = "0x7FB950", VA = "0x7FB950")]
		public static int Hook_AfterPlacement(int x, int y, int type = 423, int style = 0, int direction = 1, int alternate = 0)
		{
			return 0;
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005362")]
		[Address(RVA = "0x7FB4F4", Offset = "0x7FB4F4", VA = "0x7FB4F4")]
		public new static void Kill(int x, int y)
		{
		}

		// Token: 0x06005363 RID: 21347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005363")]
		[Address(RVA = "0x7FBB38", Offset = "0x7FBB38", VA = "0x7FBB38", Slot = "7")]
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005364")]
		[Address(RVA = "0x7FBBA8", Offset = "0x7FBBA8", VA = "0x7FBBA8", Slot = "8")]
		public override void ReadExtraData(BinaryReader reader, int gameVersion, bool networkSend)
		{
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005365")]
		[Address(RVA = "0x7FBC0C", Offset = "0x7FBC0C", VA = "0x7FBC0C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04009744 RID: 38724
		[Token(Token = "0x4009744")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<int, Rectangle> playerBox;

		// Token: 0x04009745 RID: 38725
		[Token(Token = "0x4009745")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static List<Tuple<Point16, bool>> tripPoints;

		// Token: 0x04009746 RID: 38726
		[Token(Token = "0x4009746")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<int> markedIDsForRemoval;

		// Token: 0x04009747 RID: 38727
		[Token(Token = "0x4009747")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static bool inUpdateLoop;

		// Token: 0x04009748 RID: 38728
		[Token(Token = "0x4009748")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		private static bool playerBoxFilled;

		// Token: 0x04009749 RID: 38729
		[Token(Token = "0x4009749")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public TELogicSensor.LogicCheckType logicCheck;

		// Token: 0x0400974A RID: 38730
		[Token(Token = "0x400974A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool On;

		// Token: 0x0400974B RID: 38731
		[Token(Token = "0x400974B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int CountedData;

		// Token: 0x02000A01 RID: 2561
		[Token(Token = "0x2000A01")]
		public enum LogicCheckType
		{
			// Token: 0x0400974D RID: 38733
			[Token(Token = "0x400974D")]
			None,
			// Token: 0x0400974E RID: 38734
			[Token(Token = "0x400974E")]
			Day,
			// Token: 0x0400974F RID: 38735
			[Token(Token = "0x400974F")]
			Night,
			// Token: 0x04009750 RID: 38736
			[Token(Token = "0x4009750")]
			PlayerAbove,
			// Token: 0x04009751 RID: 38737
			[Token(Token = "0x4009751")]
			Water,
			// Token: 0x04009752 RID: 38738
			[Token(Token = "0x4009752")]
			Lava,
			// Token: 0x04009753 RID: 38739
			[Token(Token = "0x4009753")]
			Honey,
			// Token: 0x04009754 RID: 38740
			[Token(Token = "0x4009754")]
			Liquid
		}
	}
}
