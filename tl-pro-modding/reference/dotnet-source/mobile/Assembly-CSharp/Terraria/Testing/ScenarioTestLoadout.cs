using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Terraria.DataStructures;

namespace Terraria.Testing
{
	// Token: 0x020005EA RID: 1514
	[Token(Token = "0x20005EA")]
	public class ScenarioTestLoadout
	{
		// Token: 0x06003C4A RID: 15434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4A")]
		[Address(RVA = "0x1E57EE8", Offset = "0x1E57EE8", VA = "0x1E57EE8")]
		public void Prepare(Player player)
		{
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4B")]
		[Address(RVA = "0x1E58724", Offset = "0x1E58724", VA = "0x1E58724")]
		public void Apply(Player player)
		{
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4C")]
		[Address(RVA = "0x1E58134", Offset = "0x1E58134", VA = "0x1E58134")]
		public void Fill(List<ScenarioTestLoadout.MinionRecord> records)
		{
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4D")]
		[Address(RVA = "0x1E58BA8", Offset = "0x1E58BA8", VA = "0x1E58BA8")]
		public void Apply(Player player, List<ScenarioTestLoadout.MinionRecord> records)
		{
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4E")]
		[Address(RVA = "0x1E5853C", Offset = "0x1E5853C", VA = "0x1E5853C")]
		public void Fill(Player player, List<ScenarioTestLoadout.BuffRecord> records)
		{
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4F")]
		[Address(RVA = "0x1E58E3C", Offset = "0x1E58E3C", VA = "0x1E58E3C")]
		public void Apply(Player player, List<ScenarioTestLoadout.BuffRecord> records)
		{
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C50")]
		[Address(RVA = "0x1E5835C", Offset = "0x1E5835C", VA = "0x1E5835C")]
		public void Fill(Item[] items, List<ScenarioTestLoadout.ItemRecord> records, int rangeStart, int rangeEndExclusive)
		{
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C51")]
		[Address(RVA = "0x1E588C0", Offset = "0x1E588C0", VA = "0x1E588C0")]
		public void Apply(Item[] items, List<ScenarioTestLoadout.ItemRecord> records)
		{
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C52")]
		[Address(RVA = "0x1E590A8", Offset = "0x1E590A8", VA = "0x1E590A8")]
		public static ScenarioTestLoadout Deserialize(string json)
		{
			return null;
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C53")]
		[Address(RVA = "0x1E59170", Offset = "0x1E59170", VA = "0x1E59170")]
		public static string Serialize(ScenarioTestLoadout loadout)
		{
			return null;
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x0001E6C0 File Offset: 0x0001C8C0
		[Token(Token = "0x6003C54")]
		[Address(RVA = "0x1E59290", Offset = "0x1E59290", VA = "0x1E59290")]
		public static bool TryReadFromFriendlyName(out ScenarioTestLoadout config, string name)
		{
			return default(bool);
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x0001E6D8 File Offset: 0x0001C8D8
		[Token(Token = "0x6003C55")]
		[Address(RVA = "0x1E594B4", Offset = "0x1E594B4", VA = "0x1E594B4")]
		public static bool TryReadFromFilePath(out ScenarioTestLoadout config, string FilePath)
		{
			return default(bool);
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C56")]
		[Address(RVA = "0x1E595E0", Offset = "0x1E595E0", VA = "0x1E595E0")]
		public static void Set(ScenarioTestLoadout config, string name)
		{
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C57")]
		[Address(RVA = "0x1E593DC", Offset = "0x1E593DC", VA = "0x1E593DC")]
		private static string ToFilePath(string name)
		{
			return null;
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C58")]
		[Address(RVA = "0x1E59678", Offset = "0x1E59678", VA = "0x1E59678")]
		public static void Clear(string name)
		{
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C59")]
		[Address(RVA = "0x1E596FC", Offset = "0x1E596FC", VA = "0x1E596FC")]
		public static string[] FindAll()
		{
			return null;
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C5A")]
		[Address(RVA = "0x1E597E4", Offset = "0x1E597E4", VA = "0x1E597E4")]
		public ScenarioTestLoadout()
		{
		}

		// Token: 0x0400479D RID: 18333
		[Token(Token = "0x400479D")]
		[FieldOffset(Offset = "0x8")]
		public bool DayTime;

		// Token: 0x0400479E RID: 18334
		[Token(Token = "0x400479E")]
		[FieldOffset(Offset = "0xC")]
		public int TimeOfDay;

		// Token: 0x0400479F RID: 18335
		[Token(Token = "0x400479F")]
		[FieldOffset(Offset = "0x10")]
		public int SelectedItem;

		// Token: 0x040047A0 RID: 18336
		[Token(Token = "0x40047A0")]
		[FieldOffset(Offset = "0x14")]
		public int Life;

		// Token: 0x040047A1 RID: 18337
		[Token(Token = "0x40047A1")]
		[FieldOffset(Offset = "0x18")]
		public int LifeMax;

		// Token: 0x040047A2 RID: 18338
		[Token(Token = "0x40047A2")]
		[FieldOffset(Offset = "0x1C")]
		public int Mana;

		// Token: 0x040047A3 RID: 18339
		[Token(Token = "0x40047A3")]
		[FieldOffset(Offset = "0x20")]
		public int ManaMax;

		// Token: 0x040047A4 RID: 18340
		[Token(Token = "0x40047A4")]
		[FieldOffset(Offset = "0x24")]
		public List<ScenarioTestLoadout.MinionRecord> Minions;

		// Token: 0x040047A5 RID: 18341
		[Token(Token = "0x40047A5")]
		[FieldOffset(Offset = "0x28")]
		public List<ScenarioTestLoadout.ItemRecord> Items_Inventory;

		// Token: 0x040047A6 RID: 18342
		[Token(Token = "0x40047A6")]
		[FieldOffset(Offset = "0x2C")]
		public List<ScenarioTestLoadout.ItemRecord> Items_Ammo;

		// Token: 0x040047A7 RID: 18343
		[Token(Token = "0x40047A7")]
		[FieldOffset(Offset = "0x30")]
		public List<ScenarioTestLoadout.ItemRecord> Items_Armor;

		// Token: 0x040047A8 RID: 18344
		[Token(Token = "0x40047A8")]
		[FieldOffset(Offset = "0x34")]
		public List<ScenarioTestLoadout.ItemRecord> Items_Equipment;

		// Token: 0x040047A9 RID: 18345
		[Token(Token = "0x40047A9")]
		[FieldOffset(Offset = "0x38")]
		public List<ScenarioTestLoadout.BuffRecord> Buffs;

		// Token: 0x040047AA RID: 18346
		[Token(Token = "0x40047AA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string LoadoutsPath;

		// Token: 0x040047AB RID: 18347
		[Token(Token = "0x40047AB")]
		[FieldOffset(Offset = "0x4")]
		private static readonly JsonSerializerSettings SerializerSettings;

		// Token: 0x020005EB RID: 1515
		[Token(Token = "0x20005EB")]
		public class ItemRecord
		{
			// Token: 0x06003C5C RID: 15452 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C5C")]
			[Address(RVA = "0x1E590A0", Offset = "0x1E590A0", VA = "0x1E590A0")]
			public ItemRecord()
			{
			}

			// Token: 0x040047AC RID: 18348
			[Token(Token = "0x40047AC")]
			[FieldOffset(Offset = "0x8")]
			public int Index;

			// Token: 0x040047AD RID: 18349
			[Token(Token = "0x40047AD")]
			[FieldOffset(Offset = "0xC")]
			public string Type;

			// Token: 0x040047AE RID: 18350
			[Token(Token = "0x40047AE")]
			[FieldOffset(Offset = "0x10")]
			public int Prefix;

			// Token: 0x040047AF RID: 18351
			[Token(Token = "0x40047AF")]
			[FieldOffset(Offset = "0x14")]
			public int Stack;
		}

		// Token: 0x020005EC RID: 1516
		[Token(Token = "0x20005EC")]
		public class BuffRecord
		{
			// Token: 0x06003C5D RID: 15453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C5D")]
			[Address(RVA = "0x1E59098", Offset = "0x1E59098", VA = "0x1E59098")]
			public BuffRecord()
			{
			}

			// Token: 0x040047B0 RID: 18352
			[Token(Token = "0x40047B0")]
			[FieldOffset(Offset = "0x8")]
			public int Index;

			// Token: 0x040047B1 RID: 18353
			[Token(Token = "0x40047B1")]
			[FieldOffset(Offset = "0xC")]
			public string Type;

			// Token: 0x040047B2 RID: 18354
			[Token(Token = "0x40047B2")]
			[FieldOffset(Offset = "0x10")]
			public int Time;
		}

		// Token: 0x020005ED RID: 1517
		[Token(Token = "0x20005ED")]
		public class MinionRecord
		{
			// Token: 0x06003C5E RID: 15454 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C5E")]
			[Address(RVA = "0x1E59090", Offset = "0x1E59090", VA = "0x1E59090")]
			public MinionRecord()
			{
			}

			// Token: 0x040047B3 RID: 18355
			[Token(Token = "0x40047B3")]
			[FieldOffset(Offset = "0x8")]
			public int ItemType;

			// Token: 0x040047B4 RID: 18356
			[Token(Token = "0x40047B4")]
			[FieldOffset(Offset = "0xC")]
			public int ItemPrefix;
		}

		// Token: 0x020005EE RID: 1518
		[Token(Token = "0x20005EE")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003C60 RID: 15456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C60")]
			[Address(RVA = "0x1E59BF0", Offset = "0x1E59BF0", VA = "0x1E59BF0")]
			public <>c()
			{
			}

			// Token: 0x06003C61 RID: 15457 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C61")]
			[Address(RVA = "0x1E59BF8", Offset = "0x1E59BF8", VA = "0x1E59BF8")]
			internal MinionSpawnFromInventoryItem <Apply>b__19_0(ScenarioTestLoadout.MinionRecord x)
			{
				return null;
			}

			// Token: 0x040047B5 RID: 18357
			[Token(Token = "0x40047B5")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ScenarioTestLoadout.<>c <>9;

			// Token: 0x040047B6 RID: 18358
			[Token(Token = "0x40047B6")]
			[FieldOffset(Offset = "0x4")]
			public static Func<ScenarioTestLoadout.MinionRecord, MinionSpawnFromInventoryItem> <>9__19_0;
		}
	}
}
