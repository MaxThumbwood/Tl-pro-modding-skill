using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x020007CC RID: 1996
	[Token(Token = "0x20007CC")]
	public abstract class TileEntity
	{
		// Token: 0x060044A9 RID: 17577 RVA: 0x00020DA8 File Offset: 0x0001EFA8
		[Token(Token = "0x60044A9")]
		[Address(RVA = "0x55B678", Offset = "0x55B678", VA = "0x55B678")]
		public static int AssignNewID()
		{
			return 0;
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x060044AA RID: 17578 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060044AB RID: 17579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000041")]
		public static event Action _UpdateStart
		{
			[Token(Token = "0x60044AA")]
			[Address(RVA = "0x55B6E4", Offset = "0x55B6E4", VA = "0x55B6E4")]
			add
			{
			}
			[Token(Token = "0x60044AB")]
			[Address(RVA = "0x55B7E8", Offset = "0x55B7E8", VA = "0x55B7E8")]
			remove
			{
			}
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x060044AC RID: 17580 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060044AD RID: 17581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000042")]
		public static event Action _UpdateEnd
		{
			[Token(Token = "0x60044AC")]
			[Address(RVA = "0x55B8EC", Offset = "0x55B8EC", VA = "0x55B8EC")]
			add
			{
			}
			[Token(Token = "0x60044AD")]
			[Address(RVA = "0x55B9F0", Offset = "0x55B9F0", VA = "0x55B9F0")]
			remove
			{
			}
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044AE")]
		[Address(RVA = "0x55BAF4", Offset = "0x55BAF4", VA = "0x55BAF4")]
		public static void Clear()
		{
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044AF")]
		[Address(RVA = "0x55BC14", Offset = "0x55BC14", VA = "0x55BC14")]
		public static void PerformUpdates()
		{
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B0")]
		[Address(RVA = "0x55BE04", Offset = "0x55BE04", VA = "0x55BE04")]
		private static void UpdateStart()
		{
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B1")]
		[Address(RVA = "0x55BEA8", Offset = "0x55BEA8", VA = "0x55BEA8")]
		private static void UpdateEnd()
		{
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B2")]
		[Address(RVA = "0x55BF4C", Offset = "0x55BF4C", VA = "0x55BF4C")]
		public static void Add(TileEntity ent)
		{
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B3")]
		[Address(RVA = "0x55C1D4", Offset = "0x55C1D4", VA = "0x55C1D4", Slot = "4")]
		public virtual void OnPlaced()
		{
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B4")]
		[Address(RVA = "0x55C1D8", Offset = "0x55C1D8", VA = "0x55C1D8", Slot = "5")]
		public virtual void OnRemoved()
		{
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x00020DC0 File Offset: 0x0001EFC0
		[Token(Token = "0x60044B5")]
		[Address(RVA = "0x55C1DC", Offset = "0x55C1DC", VA = "0x55C1DC")]
		protected static int Place(int x, int y, int type)
		{
			return 0;
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B6")]
		[Address(RVA = "0x55C388", Offset = "0x55C388", VA = "0x55C388")]
		public static void Kill(int x, int y, int type)
		{
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B7")]
		[Address(RVA = "0x55C490", Offset = "0x55C490", VA = "0x55C490")]
		public static void Remove(TileEntity entity, bool ignorePosition = false)
		{
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B8")]
		[Address(RVA = "0x55C704", Offset = "0x55C704", VA = "0x55C704")]
		public static void InitializeAll()
		{
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x00020DD8 File Offset: 0x0001EFD8
		[Token(Token = "0x60044B9")]
		[Address(RVA = "0x55C1CC", Offset = "0x55C1CC", VA = "0x55C1CC")]
		public static int GetKey(int x, int y)
		{
			return 0;
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BA")]
		[Address(RVA = "0x55C848", Offset = "0x55C848", VA = "0x55C848")]
		public static void PlaceEntityNet(int x, int y, int type)
		{
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x00020DF0 File Offset: 0x0001EFF0
		[Token(Token = "0x60044BB")]
		public static bool TryGetAt<T>(int x, int y, out T result) where T : TileEntity
		{
			return default(bool);
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x00020E08 File Offset: 0x0001F008
		[Token(Token = "0x60044BC")]
		public static bool TryGet<T>(int id, out T result) where T : TileEntity
		{
			return default(bool);
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x060044BD RID: 17597 RVA: 0x00020E20 File Offset: 0x0001F020
		[Token(Token = "0x1700083D")]
		public int PositionKey
		{
			[Token(Token = "0x60044BD")]
			[Address(RVA = "0x55C990", Offset = "0x55C990", VA = "0x55C990")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BE")]
		[Address(RVA = "0x55CA00", Offset = "0x55CA00", VA = "0x55CA00", Slot = "6")]
		public virtual void Update()
		{
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BF")]
		[Address(RVA = "0x55CA04", Offset = "0x55CA04", VA = "0x55CA04")]
		public static void Write(BinaryWriter writer, TileEntity ent, bool networkSend = false)
		{
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044C0")]
		[Address(RVA = "0x55CB24", Offset = "0x55CB24", VA = "0x55CB24")]
		public static TileEntity Read(BinaryReader reader, int gameVersion, bool networkSend = false)
		{
			return null;
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044C1")]
		[Address(RVA = "0x55CD68", Offset = "0x55CD68", VA = "0x55CD68")]
		public static TileEntity ReadPos32(BinaryReader reader, int gameVersion, bool networkSend = false)
		{
			return null;
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C2")]
		[Address(RVA = "0x55CA5C", Offset = "0x55CA5C", VA = "0x55CA5C")]
		private void WriteInner(BinaryWriter writer, bool networkSend)
		{
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C3")]
		[Address(RVA = "0x55CC98", Offset = "0x55CC98", VA = "0x55CC98")]
		private void ReadInner(BinaryReader reader, int gameVersion, bool networkSend)
		{
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C4")]
		[Address(RVA = "0x55CEDC", Offset = "0x55CEDC", VA = "0x55CEDC")]
		private void ReadInnerPos32(BinaryReader reader, int gameVersion, bool networkSend)
		{
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C5")]
		[Address(RVA = "0x55CFAC", Offset = "0x55CFAC", VA = "0x55CFAC", Slot = "7")]
		public virtual void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C6")]
		[Address(RVA = "0x55CFB0", Offset = "0x55CFB0", VA = "0x55CFB0", Slot = "8")]
		public virtual void ReadExtraData(BinaryReader reader, int gameVersion, bool networkSend)
		{
		}

		// Token: 0x060044C7 RID: 17607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C7")]
		[Address(RVA = "0x55CFB4", Offset = "0x55CFB4", VA = "0x55CFB4", Slot = "9")]
		public virtual void OnPlayerUpdate(Player player)
		{
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x00020E38 File Offset: 0x0001F038
		[Token(Token = "0x60044C8")]
		[Address(RVA = "0x55CFB8", Offset = "0x55CFB8", VA = "0x55CFB8")]
		public static bool IsOccupied(int id, out int interactingPlayer)
		{
			return default(bool);
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C9")]
		[Address(RVA = "0x55D08C", Offset = "0x55D08C", VA = "0x55D08C", Slot = "10")]
		public virtual void OnInventoryDraw(Player player, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x00020E50 File Offset: 0x0001F050
		[Token(Token = "0x60044CA")]
		[Address(RVA = "0x55D090", Offset = "0x55D090", VA = "0x55D090", Slot = "11")]
		public virtual bool OverrideItemSlotHover(Item[] inv, int context = 0, int slot = 0)
		{
			return default(bool);
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x00020E68 File Offset: 0x0001F068
		[Token(Token = "0x60044CB")]
		[Address(RVA = "0x55D098", Offset = "0x55D098", VA = "0x55D098", Slot = "12")]
		public virtual bool OverrideItemSlotLeftClick(Item[] inv, int context = 0, int slot = 0)
		{
			return default(bool);
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CC")]
		[Address(RVA = "0x55D0A0", Offset = "0x55D0A0", VA = "0x55D0A0")]
		public static void BasicOpenCloseInteraction(Player player, int x, int y, int id)
		{
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CD")]
		[Address(RVA = "0x55D570", Offset = "0x55D570", VA = "0x55D570")]
		public static void SetInteractionAnchor(Player player, int x, int y, int id)
		{
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CE")]
		[Address(RVA = "0x55D738", Offset = "0x55D738", VA = "0x55D738", Slot = "13")]
		public virtual void RegisterTileEntityID(int assignedID)
		{
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CF")]
		[Address(RVA = "0x55D73C", Offset = "0x55D73C", VA = "0x55D73C", Slot = "14")]
		public virtual void NetPlaceEntityAttempt(int x, int y)
		{
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x00020E80 File Offset: 0x0001F080
		[Token(Token = "0x60044D0")]
		[Address(RVA = "0x55D740", Offset = "0x55D740", VA = "0x55D740", Slot = "15")]
		public virtual bool IsTileValidForEntity(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044D1")]
		[Address(RVA = "0x55D748", Offset = "0x55D748", VA = "0x55D748", Slot = "16")]
		public virtual TileEntity GenerateInstance()
		{
			return null;
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D2")]
		[Address(RVA = "0x55D750", Offset = "0x55D750", VA = "0x55D750", Slot = "17")]
		public virtual void OnWorldLoaded()
		{
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D3")]
		[Address(RVA = "0x55D754", Offset = "0x55D754", VA = "0x55D754")]
		protected TileEntity()
		{
		}

		// Token: 0x04008C48 RID: 35912
		[Token(Token = "0x4008C48")]
		[FieldOffset(Offset = "0x0")]
		public static TileEntitiesManager manager;

		// Token: 0x04008C49 RID: 35913
		[Token(Token = "0x4008C49")]
		public const int MaxEntitiesPerChunk = 1000;

		// Token: 0x04008C4A RID: 35914
		[Token(Token = "0x4008C4A")]
		[FieldOffset(Offset = "0x4")]
		public static object EntityCreationLock;

		// Token: 0x04008C4B RID: 35915
		[Token(Token = "0x4008C4B")]
		[FieldOffset(Offset = "0x8")]
		public static List<TileEntity> UpdateEntities;

		// Token: 0x04008C4C RID: 35916
		[Token(Token = "0x4008C4C")]
		[FieldOffset(Offset = "0xC")]
		public static Dictionary<int, TileEntity> ByID;

		// Token: 0x04008C4D RID: 35917
		[Token(Token = "0x4008C4D")]
		[FieldOffset(Offset = "0x10")]
		public static Dictionary<int, TileEntity> ByPosition;

		// Token: 0x04008C4E RID: 35918
		[Token(Token = "0x4008C4E")]
		[FieldOffset(Offset = "0x14")]
		public static int TileEntitiesNextID;

		// Token: 0x04008C51 RID: 35921
		[Token(Token = "0x4008C51")]
		[FieldOffset(Offset = "0x8")]
		public int ID;

		// Token: 0x04008C52 RID: 35922
		[Token(Token = "0x4008C52")]
		[FieldOffset(Offset = "0xC")]
		public Point16 Position;

		// Token: 0x04008C53 RID: 35923
		[Token(Token = "0x4008C53")]
		[FieldOffset(Offset = "0x10")]
		public byte type;

		// Token: 0x04008C54 RID: 35924
		[Token(Token = "0x4008C54")]
		[FieldOffset(Offset = "0x11")]
		public bool RequiresUpdates;
	}
}
