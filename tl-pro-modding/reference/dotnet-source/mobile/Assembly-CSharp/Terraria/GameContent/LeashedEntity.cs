using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.Net;

namespace Terraria.GameContent
{
	// Token: 0x02000993 RID: 2451
	[Token(Token = "0x2000993")]
	public class LeashedEntity
	{
		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x0600509E RID: 20638 RVA: 0x00025860 File Offset: 0x00023A60
		// (set) Token: 0x0600509F RID: 20639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000993")]
		public int Type
		{
			[Token(Token = "0x600509E")]
			[Address(RVA = "0x76E480", Offset = "0x76E480", VA = "0x76E480")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600509F")]
			[Address(RVA = "0x76E488", Offset = "0x76E488", VA = "0x76E488")]
			private set
			{
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x060050A0 RID: 20640 RVA: 0x00025878 File Offset: 0x00023A78
		// (set) Token: 0x060050A1 RID: 20641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000994")]
		public Point16 AnchorPosition
		{
			[Token(Token = "0x60050A0")]
			[Address(RVA = "0x76E490", Offset = "0x76E490", VA = "0x76E490")]
			get
			{
				return default(Point16);
			}
			[Token(Token = "0x60050A1")]
			[Address(RVA = "0x76E498", Offset = "0x76E498", VA = "0x76E498")]
			private set
			{
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x060050A2 RID: 20642 RVA: 0x00025890 File Offset: 0x00023A90
		[Token(Token = "0x17000995")]
		public Point SectionCoordinates
		{
			[Token(Token = "0x60050A2")]
			[Address(RVA = "0x76E4A0", Offset = "0x76E4A0", VA = "0x76E4A0")]
			get
			{
				return default(Point);
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x060050A3 RID: 20643 RVA: 0x000258A8 File Offset: 0x00023AA8
		// (set) Token: 0x060050A4 RID: 20644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000996")]
		public Vector2 Center
		{
			[Token(Token = "0x60050A3")]
			[Address(RVA = "0x76E544", Offset = "0x76E544", VA = "0x76E544")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60050A4")]
			[Address(RVA = "0x76E5A0", Offset = "0x76E5A0", VA = "0x76E5A0")]
			set
			{
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x060050A5 RID: 20645 RVA: 0x000258C0 File Offset: 0x00023AC0
		// (set) Token: 0x060050A6 RID: 20646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000997")]
		public Vector2 Size
		{
			[Token(Token = "0x60050A5")]
			[Address(RVA = "0x76E618", Offset = "0x76E618", VA = "0x76E618")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60050A6")]
			[Address(RVA = "0x76E64C", Offset = "0x76E64C", VA = "0x76E64C")]
			set
			{
			}
		}

		// Token: 0x060050A7 RID: 20647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A7")]
		[Address(RVA = "0x76E690", Offset = "0x76E690", VA = "0x76E690")]
		public static void Clear(bool keepActiveSections = false)
		{
		}

		// Token: 0x060050A8 RID: 20648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A8")]
		[Address(RVA = "0x76EE4C", Offset = "0x76EE4C", VA = "0x76EE4C")]
		public static void AddNewEntity(LeashedEntity e, Point16 anchorPos)
		{
		}

		// Token: 0x060050A9 RID: 20649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A9")]
		[Address(RVA = "0x76F060", Offset = "0x76F060", VA = "0x76F060")]
		private static void AddNewEntity(LeashedEntity e, Point16 anchorPos, int slot)
		{
		}

		// Token: 0x060050AA RID: 20650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050AA")]
		[Address(RVA = "0x76EB30", Offset = "0x76EB30", VA = "0x76EB30")]
		private static LeashedEntity.SectionEntityList GetSection(Point sectionCoordinates)
		{
			return null;
		}

		// Token: 0x060050AB RID: 20651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050AB")]
		[Address(RVA = "0x76F7BC", Offset = "0x76F7BC", VA = "0x76F7BC")]
		private static void Remove(LeashedEntity e)
		{
		}

		// Token: 0x060050AC RID: 20652 RVA: 0x000258D8 File Offset: 0x00023AD8
		[Token(Token = "0x60050AC")]
		[Address(RVA = "0x76FCAC", Offset = "0x76FCAC", VA = "0x76FCAC")]
		public static bool TryGet(int slot, out LeashedEntity entity)
		{
			return default(bool);
		}

		// Token: 0x060050AD RID: 20653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050AD")]
		[Address(RVA = "0x76FDBC", Offset = "0x76FDBC", VA = "0x76FDBC")]
		public static void UpdateEntities()
		{
		}

		// Token: 0x060050AE RID: 20654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050AE")]
		[Address(RVA = "0x76FE1C", Offset = "0x76FE1C", VA = "0x76FE1C")]
		private static void RecheckActiveSections()
		{
		}

		// Token: 0x060050AF RID: 20655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050AF")]
		[Address(RVA = "0x770050", Offset = "0x770050", VA = "0x770050")]
		private static void _UpdateEntities()
		{
		}

		// Token: 0x060050B0 RID: 20656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B0")]
		[Address(RVA = "0x77047C", Offset = "0x77047C", VA = "0x77047C")]
		private void StreamNetUpdates()
		{
		}

		// Token: 0x060050B1 RID: 20657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B1")]
		[Address(RVA = "0x770574", Offset = "0x770574", VA = "0x770574")]
		private static void SyncEntitiesInSection(int toClient, Point sectionCoordinates)
		{
		}

		// Token: 0x060050B2 RID: 20658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B2")]
		[Address(RVA = "0x770690", Offset = "0x770690", VA = "0x770690")]
		public static void DrawEntities()
		{
		}

		// Token: 0x060050B3 RID: 20659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B3")]
		[Address(RVA = "0x770AD8", Offset = "0x770AD8", VA = "0x770AD8", Slot = "4")]
		public virtual LeashedEntity NewInstance()
		{
			return null;
		}

		// Token: 0x060050B4 RID: 20660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B4")]
		[Address(RVA = "0x770B78", Offset = "0x770B78", VA = "0x770B78", Slot = "5")]
		public virtual void Spawn(bool newlyAdded)
		{
		}

		// Token: 0x060050B5 RID: 20661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B5")]
		[Address(RVA = "0x770B7C", Offset = "0x770B7C", VA = "0x770B7C", Slot = "6")]
		public virtual void Despawn()
		{
		}

		// Token: 0x060050B6 RID: 20662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B6")]
		[Address(RVA = "0x770B80", Offset = "0x770B80", VA = "0x770B80", Slot = "7")]
		public virtual void Update()
		{
		}

		// Token: 0x060050B7 RID: 20663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B7")]
		[Address(RVA = "0x770B84", Offset = "0x770B84", VA = "0x770B84", Slot = "8")]
		public virtual void Draw()
		{
		}

		// Token: 0x060050B8 RID: 20664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B8")]
		[Address(RVA = "0x770B88", Offset = "0x770B88", VA = "0x770B88", Slot = "9")]
		public virtual void NetSend(BinaryWriter writer, bool full)
		{
		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B9")]
		[Address(RVA = "0x770B8C", Offset = "0x770B8C", VA = "0x770B8C", Slot = "10")]
		public virtual void NetReceive(BinaryReader reader, bool full)
		{
		}

		// Token: 0x060050BA RID: 20666 RVA: 0x000258F0 File Offset: 0x00023AF0
		[Token(Token = "0x60050BA")]
		[Address(RVA = "0x770B90", Offset = "0x770B90", VA = "0x770B90")]
		public bool NearbySectionsMissing(int fluff = 3)
		{
			return default(bool);
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050BB")]
		[Address(RVA = "0x770D44", Offset = "0x770D44", VA = "0x770D44")]
		public LeashedEntity()
		{
		}

		// Token: 0x04009489 RID: 38025
		[Token(Token = "0x4009489")]
		[FieldOffset(Offset = "0x0")]
		private static LeashedEntity.SectionEntityList[,] BySection;

		// Token: 0x0400948A RID: 38026
		[Token(Token = "0x400948A")]
		[FieldOffset(Offset = "0x4")]
		private static readonly List<LeashedEntity.SectionEntityList> ActiveSectionList;

		// Token: 0x0400948B RID: 38027
		[Token(Token = "0x400948B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<LeashedEntity> ByWhoAmI;

		// Token: 0x0400948C RID: 38028
		[Token(Token = "0x400948C")]
		[FieldOffset(Offset = "0x8")]
		private int sectionSlot;

		// Token: 0x0400948D RID: 38029
		[Token(Token = "0x400948D")]
		[FieldOffset(Offset = "0xC")]
		public bool active;

		// Token: 0x0400948E RID: 38030
		[Token(Token = "0x400948E")]
		[FieldOffset(Offset = "0x10")]
		public int whoAmI;

		// Token: 0x0400948F RID: 38031
		[Token(Token = "0x400948F")]
		[FieldOffset(Offset = "0x14")]
		private int <Type>k__BackingField;

		// Token: 0x04009490 RID: 38032
		[Token(Token = "0x4009490")]
		[FieldOffset(Offset = "0x18")]
		private Point16 <AnchorPosition>k__BackingField;

		// Token: 0x04009491 RID: 38033
		[Token(Token = "0x4009491")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 position;

		// Token: 0x04009492 RID: 38034
		[Token(Token = "0x4009492")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 velocity;

		// Token: 0x04009493 RID: 38035
		[Token(Token = "0x4009493")]
		[FieldOffset(Offset = "0x2C")]
		public int direction;

		// Token: 0x04009494 RID: 38036
		[Token(Token = "0x4009494")]
		[FieldOffset(Offset = "0x30")]
		public int width;

		// Token: 0x04009495 RID: 38037
		[Token(Token = "0x4009495")]
		[FieldOffset(Offset = "0x34")]
		public int height;

		// Token: 0x04009496 RID: 38038
		[Token(Token = "0x4009496")]
		private const int StreamingRate = 1024;

		// Token: 0x02000994 RID: 2452
		[Token(Token = "0x2000994")]
		public class NetModule : Terraria.Net.NetModule
		{
			// Token: 0x060050BC RID: 20668 RVA: 0x00025908 File Offset: 0x00023B08
			[Token(Token = "0x60050BC")]
			[Address(RVA = "0x770D4C", Offset = "0x770D4C", VA = "0x770D4C", Slot = "4")]
			public override bool Deserialize(BinaryReader reader, int userId)
			{
				return default(bool);
			}

			// Token: 0x060050BD RID: 20669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050BD")]
			[Address(RVA = "0x76FB34", Offset = "0x76FB34", VA = "0x76FB34")]
			public static void Remove(int slot)
			{
			}

			// Token: 0x060050BE RID: 20670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050BE")]
			[Address(RVA = "0x76F3A8", Offset = "0x76F3A8", VA = "0x76F3A8")]
			public static void Sync(LeashedEntity entity, bool full, int toClient = -1)
			{
			}

			// Token: 0x060050BF RID: 20671 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050BF")]
			[Address(RVA = "0x770F90", Offset = "0x770F90", VA = "0x770F90")]
			private void HandleRemove(int slot)
			{
			}

			// Token: 0x060050C0 RID: 20672 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050C0")]
			[Address(RVA = "0x771030", Offset = "0x771030", VA = "0x771030")]
			private static void HandleFullSync(int slot, int type, Point16 anchorPos, BinaryReader reader)
			{
			}

			// Token: 0x060050C1 RID: 20673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050C1")]
			[Address(RVA = "0x7715CC", Offset = "0x7715CC", VA = "0x7715CC")]
			private static void HandlePartialSync(int slot, int type, BinaryReader reader)
			{
			}

			// Token: 0x060050C2 RID: 20674 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050C2")]
			[Address(RVA = "0x771904", Offset = "0x771904", VA = "0x771904")]
			public NetModule()
			{
			}

			// Token: 0x02000995 RID: 2453
			[Token(Token = "0x2000995")]
			private enum MessageType
			{
				// Token: 0x04009498 RID: 38040
				[Token(Token = "0x4009498")]
				Remove,
				// Token: 0x04009499 RID: 38041
				[Token(Token = "0x4009499")]
				FullSync,
				// Token: 0x0400949A RID: 38042
				[Token(Token = "0x400949A")]
				PartialSync
			}

			// Token: 0x02000996 RID: 2454
			[Token(Token = "0x2000996")]
			private sealed class <>c__DisplayClass3_0
			{
				// Token: 0x060050C3 RID: 20675 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60050C3")]
				[Address(RVA = "0x77185C", Offset = "0x77185C", VA = "0x77185C")]
				public <>c__DisplayClass3_0()
				{
				}

				// Token: 0x060050C4 RID: 20676 RVA: 0x00025920 File Offset: 0x00023B20
				[Token(Token = "0x60050C4")]
				[Address(RVA = "0x77190C", Offset = "0x77190C", VA = "0x77190C")]
				internal bool <Sync>b__0(int i)
				{
					return default(bool);
				}

				// Token: 0x0400949B RID: 38043
				[Token(Token = "0x400949B")]
				[FieldOffset(Offset = "0x8")]
				public LeashedEntity entity;
			}
		}

		// Token: 0x02000997 RID: 2455
		[Token(Token = "0x2000997")]
		public class Registry
		{
			// Token: 0x060050C5 RID: 20677 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050C5")]
			[Address(RVA = "0x771A50", Offset = "0x771A50", VA = "0x771A50")]
			public static void RegisterAll()
			{
			}

			// Token: 0x060050C6 RID: 20678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050C6")]
			[Address(RVA = "0x7720A4", Offset = "0x7720A4", VA = "0x7720A4")]
			public static void Register(LeashedEntity prototype)
			{
			}

			// Token: 0x060050C7 RID: 20679 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60050C7")]
			public static T Register<T>() where T : LeashedEntity, new()
			{
				return null;
			}

			// Token: 0x060050C8 RID: 20680 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60050C8")]
			[Address(RVA = "0x771864", Offset = "0x771864", VA = "0x771864")]
			public static LeashedEntity Get(int type)
			{
				return null;
			}

			// Token: 0x060050C9 RID: 20681 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050C9")]
			[Address(RVA = "0x7721D0", Offset = "0x7721D0", VA = "0x7721D0")]
			public Registry()
			{
			}

			// Token: 0x0400949C RID: 38044
			[Token(Token = "0x400949C")]
			[FieldOffset(Offset = "0x0")]
			private static readonly List<LeashedEntity> Prototypes;
		}

		// Token: 0x02000998 RID: 2456
		[Token(Token = "0x2000998")]
		private class SectionEntityList
		{
			// Token: 0x060050CB RID: 20683 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050CB")]
			[Address(RVA = "0x76F748", Offset = "0x76F748", VA = "0x76F748")]
			public SectionEntityList(Point coordinates)
			{
			}

			// Token: 0x060050CC RID: 20684 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050CC")]
			[Address(RVA = "0x76F2B4", Offset = "0x76F2B4", VA = "0x76F2B4")]
			public void Add(LeashedEntity e)
			{
			}

			// Token: 0x060050CD RID: 20685 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050CD")]
			[Address(RVA = "0x76FAEC", Offset = "0x76FAEC", VA = "0x76FAEC")]
			public void Remove(LeashedEntity e)
			{
			}

			// Token: 0x060050CE RID: 20686 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050CE")]
			[Address(RVA = "0x7702D4", Offset = "0x7702D4", VA = "0x7702D4")]
			public void CompactIfNecesary()
			{
			}

			// Token: 0x060050CF RID: 20687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050CF")]
			[Address(RVA = "0x76ECA4", Offset = "0x76ECA4", VA = "0x76ECA4")]
			public void Activate()
			{
			}

			// Token: 0x060050D0 RID: 20688 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050D0")]
			[Address(RVA = "0x7703A8", Offset = "0x7703A8", VA = "0x7703A8")]
			public void Deactivate()
			{
			}

			// Token: 0x060050D1 RID: 20689 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050D1")]
			[Address(RVA = "0x77063C", Offset = "0x77063C", VA = "0x77063C")]
			public void Sync(int toClient)
			{
			}

			// Token: 0x0400949D RID: 38045
			[Token(Token = "0x400949D")]
			[FieldOffset(Offset = "0x8")]
			public readonly Point coordinates;

			// Token: 0x0400949E RID: 38046
			[Token(Token = "0x400949E")]
			[FieldOffset(Offset = "0x10")]
			public bool active;

			// Token: 0x0400949F RID: 38047
			[Token(Token = "0x400949F")]
			[FieldOffset(Offset = "0x14")]
			public LeashedEntity[] list;

			// Token: 0x040094A0 RID: 38048
			[Token(Token = "0x40094A0")]
			[FieldOffset(Offset = "0x18")]
			public int count;

			// Token: 0x040094A1 RID: 38049
			[Token(Token = "0x40094A1")]
			[FieldOffset(Offset = "0x1C")]
			private int emptySlots;
		}

		// Token: 0x02000999 RID: 2457
		[Token(Token = "0x2000999")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060050D3 RID: 20691 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050D3")]
			[Address(RVA = "0x7722F8", Offset = "0x7722F8", VA = "0x7722F8")]
			public <>c()
			{
			}

			// Token: 0x060050D4 RID: 20692 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60050D4")]
			[Address(RVA = "0x772300", Offset = "0x772300", VA = "0x772300")]
			internal void <.cctor>b__3_0(Point sectionCoordinates)
			{
			}

			// Token: 0x040094A2 RID: 38050
			[Token(Token = "0x40094A2")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LeashedEntity.<>c <>9;
		}
	}
}
