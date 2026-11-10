// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntity
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria.DataStructures;
using Terraria.GameContent.LeashedEntities;
using Terraria.Net;

#nullable disable
namespace Terraria.GameContent;

public class LeashedEntity
{
  private static readonly LeashedEntity.SectionEntityList[,] BySection = new LeashedEntity.SectionEntityList[Main.maxTilesX / 200 + 1, Main.maxTilesY / 150 + 1];
  private static readonly List<LeashedEntity.SectionEntityList> ActiveSectionList = new List<LeashedEntity.SectionEntityList>();
  private static readonly List<LeashedEntity> ByWhoAmI = new List<LeashedEntity>();
  private int sectionSlot;
  public bool active;
  public int whoAmI;
  public Vector2 position;
  public Vector2 velocity;
  public int direction;
  public int width;
  public int height;
  private const int StreamingRate = 1024 /*0x0400*/;

  static LeashedEntity()
  {
    ActiveSections.SectionActivated += (Action<Point>) (sectionCoordinates => LeashedEntity.GetSection(sectionCoordinates).Activate());
    RemoteClient.NetSectionActivated += new Action<int, Point>(LeashedEntity.SyncEntitiesInSection);
  }

  public int Type { get; private set; }

  public Point16 AnchorPosition { get; private set; }

  public Point SectionCoordinates
  {
    get
    {
      return new Point(Netplay.GetSectionX((int) this.AnchorPosition.X), Netplay.GetSectionY((int) this.AnchorPosition.Y));
    }
  }

  public Vector2 Center
  {
    get
    {
      return new Vector2(this.position.X + (float) (this.width / 2), this.position.Y + (float) (this.height / 2));
    }
    set
    {
      this.position = new Vector2(value.X - (float) (this.width / 2), value.Y - (float) (this.height / 2));
    }
  }

  public Vector2 Size
  {
    get => new Vector2((float) this.width, (float) this.height);
    set
    {
      this.width = (int) value.X;
      this.height = (int) value.Y;
    }
  }

  public static void Clear(bool keepActiveSections = false)
  {
    Array.Clear((Array) LeashedEntity.BySection, 0, LeashedEntity.BySection.Length);
    LeashedEntity.ByWhoAmI.Clear();
    LeashedEntity.ByWhoAmI.Capacity = 10000;
    LeashedEntity.ActiveSectionList.Clear();
    LeashedEntity.ActiveSectionList.Capacity = LeashedEntity.BySection.Length;
    if (!keepActiveSections)
      return;
    for (int x = 0; x < LeashedEntity.BySection.GetLength(0); ++x)
    {
      for (int y = 0; y < LeashedEntity.BySection.GetLength(1); ++y)
      {
        if (ActiveSections.IsSectionActive(new Point(x, y)))
          LeashedEntity.GetSection(new Point(x, y)).Activate();
      }
    }
  }

  public static void AddNewEntity(LeashedEntity e, Point16 anchorPos)
  {
    if (e == null || Main.netMode == 1)
      return;
    int slot = LeashedEntity.ByWhoAmI.IndexOf((LeashedEntity) null);
    if (slot < 0)
    {
      slot = LeashedEntity.ByWhoAmI.Count;
      LeashedEntity.ByWhoAmI.Add((LeashedEntity) null);
    }
    LeashedEntity.AddNewEntity(e, anchorPos, slot);
  }

  private static void AddNewEntity(LeashedEntity e, Point16 anchorPos, int slot)
  {
    e.AnchorPosition = anchorPos;
    e.active = true;
    e.whoAmI = slot;
    LeashedEntity.ByWhoAmI[slot] = e;
    LeashedEntity.SectionEntityList section = LeashedEntity.GetSection(e.SectionCoordinates);
    section.Add(e);
    if (Main.netMode != 1 && section.active)
      e.Spawn(true);
    if (Main.netMode != 2)
      return;
    LeashedEntity.NetModule.Sync(e, true);
  }

  private static LeashedEntity.SectionEntityList GetSection(Point sectionCoordinates)
  {
    LeashedEntity.SectionEntityList section = LeashedEntity.BySection[sectionCoordinates.X, sectionCoordinates.Y];
    if (section == null)
      LeashedEntity.BySection[sectionCoordinates.X, sectionCoordinates.Y] = section = new LeashedEntity.SectionEntityList(sectionCoordinates);
    return section;
  }

  private static void Remove(LeashedEntity e)
  {
    e.active = false;
    LeashedEntity.ByWhoAmI[e.whoAmI] = (LeashedEntity) null;
    while (LeashedEntity.ByWhoAmI.Count > 0 && LeashedEntity.ByWhoAmI[LeashedEntity.ByWhoAmI.Count - 1] == null)
      LeashedEntity.ByWhoAmI.RemoveAt(LeashedEntity.ByWhoAmI.Count - 1);
    LeashedEntity.GetSection(e.SectionCoordinates).Remove(e);
    if (Main.netMode != 2)
      return;
    LeashedEntity.NetModule.Remove(e.whoAmI);
  }

  public static bool TryGet(int slot, out LeashedEntity entity)
  {
    entity = (LeashedEntity) null;
    if (slot < 0 || slot >= LeashedEntity.ByWhoAmI.Count)
      return false;
    entity = LeashedEntity.ByWhoAmI[slot];
    return entity != null;
  }

  public static void UpdateEntities()
  {
    LeashedEntity.RecheckActiveSections();
    LeashedEntity._UpdateEntities();
  }

  private static void RecheckActiveSections()
  {
    int index1 = 0;
    for (int index2 = 0; index2 < LeashedEntity.ActiveSectionList.Count; ++index2)
    {
      LeashedEntity.SectionEntityList activeSection = LeashedEntity.ActiveSectionList[index2];
      activeSection.CompactIfNecesary();
      if (!ActiveSections.IsSectionActive(activeSection.coordinates))
        activeSection.Deactivate();
      else
        LeashedEntity.ActiveSectionList[index1++] = activeSection;
    }
    LeashedEntity.ActiveSectionList.RemoveRange(index1, LeashedEntity.ActiveSectionList.Count - index1);
  }

  private static void _UpdateEntities()
  {
    foreach (LeashedEntity.SectionEntityList activeSection in LeashedEntity.ActiveSectionList)
    {
      LeashedEntity[] list = activeSection.list;
      int count = activeSection.count;
      for (int index = 0; index < count; ++index)
      {
        LeashedEntity e = list[index];
        if (e != null)
        {
          if (e.active)
          {
            e.Update();
            e.StreamNetUpdates();
          }
          if (!e.active)
            LeashedEntity.Remove(e);
        }
      }
    }
  }

  private void StreamNetUpdates()
  {
    if (Main.netMode != 2 || ((long) Main.GameUpdateCount + (long) this.whoAmI & 1023L /*0x03FF*/) != 0L)
      return;
    LeashedEntity.NetModule.Sync(this, false);
  }

  private static void SyncEntitiesInSection(int toClient, Point sectionCoordinates)
  {
    LeashedEntity.GetSection(sectionCoordinates).Sync(toClient);
  }

  public static void DrawEntities()
  {
    TimeLogger.StartTimestamp fromTimestamp = TimeLogger.Start();
    Rectangle rectangle = new Rectangle((int) Main.screenPosition.X, (int) Main.screenPosition.Y, Main.screenWidth, Main.screenHeight);
    rectangle.Inflate(512 /*0x0200*/, 512 /*0x0200*/);
    foreach (LeashedEntity.SectionEntityList activeSection in LeashedEntity.ActiveSectionList)
    {
      LeashedEntity[] list = activeSection.list;
      int count = activeSection.count;
      for (int index = 0; index < count; ++index)
      {
        LeashedEntity leashedEntity = list[index];
        if (leashedEntity != null && rectangle.Contains(leashedEntity.Center.ToPoint()))
          leashedEntity.Draw();
      }
    }
    TimeLogger.LeashedEntities.AddTime(fromTimestamp);
  }

  public virtual LeashedEntity NewInstance()
  {
    LeashedEntity instance = (LeashedEntity) Activator.CreateInstance(this.GetType(), true);
    instance.Type = this.Type;
    return instance;
  }

  public virtual void Spawn(bool newlyAdded)
  {
  }

  public virtual void Despawn()
  {
  }

  public virtual void Update()
  {
  }

  public virtual void Draw()
  {
  }

  public virtual void NetSend(BinaryWriter writer, bool full)
  {
  }

  public virtual void NetReceive(BinaryReader reader, bool full)
  {
  }

  public bool NearbySectionsMissing(int fluff = 3)
  {
    if (Main.netMode != 1)
      return false;
    Point point = this.position.ToTileCoordinates().ClampedInWorld(fluff);
    return Main.tile[point.X - fluff, point.Y] == null || Main.tile[point.X + fluff, point.Y] == null || Main.tile[point.X, point.Y - fluff] == null || Main.tile[point.X, point.Y + fluff] == null;
  }

  public class NetModule : Terraria.Net.NetModule
  {
    public override bool Deserialize(BinaryReader reader, int userId)
    {
      LeashedEntity.NetModule.MessageType messageType = (LeashedEntity.NetModule.MessageType) reader.ReadByte();
      int slot = reader.Read7BitEncodedInt();
      switch (messageType)
      {
        case LeashedEntity.NetModule.MessageType.Remove:
          this.HandleRemove(slot);
          break;
        case LeashedEntity.NetModule.MessageType.FullSync:
          LeashedEntity.NetModule.HandleFullSync(slot, reader.Read7BitEncodedInt(), new Point16(reader.ReadInt16(), reader.ReadInt16()), reader);
          break;
        case LeashedEntity.NetModule.MessageType.PartialSync:
          LeashedEntity.NetModule.HandlePartialSync(slot, reader.Read7BitEncodedInt(), reader);
          break;
        default:
          return false;
      }
      return true;
    }

    public static void Remove(int slot)
    {
      NetPacket packet = Terraria.Net.NetModule.CreatePacket<LeashedEntity.NetModule>();
      packet.Writer.Write((byte) 0);
      packet.Writer.Write7BitEncodedInt(slot);
      NetManager.Instance.Broadcast(packet);
    }

    public static void Sync(LeashedEntity entity, bool full, int toClient = -1)
    {
      NetPacket packet = Terraria.Net.NetModule.CreatePacket<LeashedEntity.NetModule>();
      packet.Writer.Write(full ? (byte) 1 : (byte) 2);
      packet.Writer.Write7BitEncodedInt(entity.whoAmI);
      packet.Writer.Write7BitEncodedInt(entity.Type);
      if (full)
      {
        packet.Writer.Write(entity.AnchorPosition.X);
        packet.Writer.Write(entity.AnchorPosition.Y);
      }
      entity.NetSend(packet.Writer, full);
      if (toClient >= 0)
        NetManager.Instance.SendToClient(packet, toClient);
      else
        NetManager.Instance.Broadcast(packet, (NetManager.BroadcastCondition) (i => Netplay.Clients[i].IsSectionActive(entity.SectionCoordinates)));
    }

    private void HandleRemove(int slot)
    {
      LeashedEntity entity;
      if (!LeashedEntity.TryGet(slot, out entity))
        return;
      LeashedEntity.Remove(entity);
    }

    private static void HandleFullSync(int slot, int type, Point16 anchorPos, BinaryReader reader)
    {
      while (slot >= LeashedEntity.ByWhoAmI.Count)
        LeashedEntity.ByWhoAmI.Add((LeashedEntity) null);
      LeashedEntity e = LeashedEntity.ByWhoAmI[slot];
      if (e == null)
      {
        e = LeashedEntity.Registry.Get(type).NewInstance();
        LeashedEntity.AddNewEntity(e, anchorPos, slot);
      }
      else if (e.Type != type || e.AnchorPosition != anchorPos)
        throw new Exception($"LeashedEntity type mismatch for full sync. Slot: {(object) slot} Existing: {(object) e.Type} @ {(object) e.AnchorPosition} New: {(object) type} @ {(object) anchorPos}");
      e.NetReceive(reader, true);
    }

    private static void HandlePartialSync(int slot, int type, BinaryReader reader)
    {
      LeashedEntity leashedEntity = LeashedEntity.ByWhoAmI[slot];
      if (leashedEntity.Type != type)
        throw new Exception($"LeashedEntity type mismatch for full sync. Slot: {(object) slot} Existing: {(object) leashedEntity.Type} Synced: {(object) type}");
      leashedEntity.NetReceive(reader, false);
    }

    private enum MessageType
    {
      Remove,
      FullSync,
      PartialSync,
    }
  }

  public class Registry
  {
    private static readonly List<LeashedEntity> Prototypes = new List<LeashedEntity>();

    public static void RegisterAll()
    {
      LeashedEntity.Registry.Prototypes.Add((LeashedEntity) null);
      LeashedKite.Prototype = LeashedEntity.Registry.Register<LeashedKite>();
      LeashedEntity.Registry.Register((LeashedEntity) WalkerLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) CrawlerLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) SnailLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) RunnerLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) FlyerLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) NormalButterflyLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) EmpressButterflyLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) HellButterflyLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) FireflyLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) ShimmerFlyLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) DragonflyLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) CrawlingFlyLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) BirdLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) WaterfowlLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) FishLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) FairyLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) JumperLeashedCritter.Prototype);
      LeashedEntity.Registry.Register((LeashedEntity) WaterStriderLeashedCritter.Prototype);
    }

    public static void Register(LeashedEntity prototype)
    {
      prototype.Type = LeashedEntity.Registry.Prototypes.Count;
      LeashedEntity.Registry.Prototypes.Add(prototype);
    }

    public static T Register<T>() where T : LeashedEntity, new()
    {
      T obj1 = new T();
      obj1.Type = LeashedEntity.Registry.Prototypes.Count;
      T obj2 = obj1;
      LeashedEntity.Registry.Prototypes.Add((LeashedEntity) obj2);
      return obj2;
    }

    public static LeashedEntity Get(int type) => LeashedEntity.Registry.Prototypes[type];
  }

  private class SectionEntityList
  {
    public readonly Point coordinates;
    public bool active;
    public LeashedEntity[] list = new LeashedEntity[32 /*0x20*/];
    public int count;
    private int emptySlots;

    public SectionEntityList(Point coordinates) => this.coordinates = coordinates;

    public void Add(LeashedEntity e)
    {
      if (this.count == this.list.Length)
        Array.Resize<LeashedEntity>(ref this.list, this.list.Length * 2);
      e.sectionSlot = this.count;
      this.list[this.count++] = e;
    }

    public void Remove(LeashedEntity e)
    {
      this.list[e.sectionSlot] = (LeashedEntity) null;
      ++this.emptySlots;
    }

    public void CompactIfNecesary()
    {
      if (this.emptySlots < this.count / 2)
        return;
      int index1 = 0;
      for (int index2 = 0; index2 < this.count; ++index2)
      {
        LeashedEntity leashedEntity = this.list[index2];
        if (leashedEntity != null)
        {
          leashedEntity.sectionSlot = index1;
          this.list[index1++] = leashedEntity;
        }
      }
      Array.Clear((Array) this.list, index1, this.count - index1);
      this.count = index1;
      this.emptySlots = 0;
    }

    public void Activate()
    {
      this.active = true;
      if (Main.netMode != 1)
      {
        foreach (LeashedEntity leashedEntity in this.list)
          leashedEntity?.Spawn(false);
      }
      LeashedEntity.ActiveSectionList.Add(this);
    }

    public void Deactivate()
    {
      this.active = false;
      if (Main.netMode == 1)
        return;
      foreach (LeashedEntity leashedEntity in this.list)
        leashedEntity?.Despawn();
    }

    public void Sync(int toClient)
    {
      foreach (LeashedEntity entity in this.list)
      {
        if (entity != null)
          LeashedEntity.NetModule.Sync(entity, true, toClient);
      }
    }
  }
}
