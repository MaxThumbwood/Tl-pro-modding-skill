// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.NPCWasNearPlayerTracker
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.IO;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.NetModules;
using Terraria.ID;
using Terraria.Net;

#nullable disable
namespace Terraria.GameContent.Bestiary;

public class NPCWasNearPlayerTracker : IPersistentPerWorldContent, IOnPlayerJoining
{
  private object _entryCreationLock = new object();
  private HashSet<string> _wasNearPlayer;
  private List<Rectangle> _playerHitboxesForBestiary;
  private List<int> _wasSeenNearPlayerByNetId;

  public void PrepareSamplesBasedOptimizations()
  {
  }

  public NPCWasNearPlayerTracker()
  {
    this._wasNearPlayer = new HashSet<string>();
    this._playerHitboxesForBestiary = new List<Rectangle>();
    this._wasSeenNearPlayerByNetId = new List<int>();
  }

  public void RegisterWasNearby(NPC npc)
  {
    string bestiaryCreditId = npc.GetBestiaryCreditId();
    bool flag = !this._wasNearPlayer.Contains(bestiaryCreditId);
    this.SetWasSeenDirectly(bestiaryCreditId);
    if (!(Main.netMode == 2 & flag))
      return;
    NetManager.Instance.Broadcast(NetBestiaryModule.SerializeSight(npc.netID));
  }

  public void SetWasSeenDirectly(string persistentId)
  {
    lock (this._entryCreationLock)
    {
      if (!this._wasNearPlayer.Add(persistentId))
        return;
      AchievementsHelper.TryGrantingBestiary100PercentAchievement();
    }
  }

  public bool GetWasNearbyBefore(NPC npc) => this.GetWasNearbyBefore(npc.GetBestiaryCreditId());

  public bool GetWasNearbyBefore(string persistentIdentifier)
  {
    return this._wasNearPlayer.Contains(persistentIdentifier);
  }

  public void Save(BinaryWriter writer)
  {
    lock (this._entryCreationLock)
    {
      writer.Write(this._wasNearPlayer.Count);
      foreach (string str in this._wasNearPlayer)
        writer.Write(str);
    }
  }

  public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
  {
    int num = reader.ReadInt32();
    for (int index = 0; index < num; ++index)
      this._wasNearPlayer.Add(reader.ReadString());
  }

  public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
  {
    int num = reader.ReadInt32();
    for (int index = 0; index < num; ++index)
      reader.ReadString();
  }

  public void Reset()
  {
    this._wasNearPlayer.Clear();
    this._playerHitboxesForBestiary.Clear();
    this._wasSeenNearPlayerByNetId.Clear();
  }

  public void ScanWorldForFinds()
  {
    this._playerHitboxesForBestiary.Clear();
    for (int index = 0; index < (int) byte.MaxValue; ++index)
    {
      Player player = Main.player[index];
      if (player.active)
        this._playerHitboxesForBestiary.Add(player.HitboxForBestiaryNearbyCheck);
    }
    for (int index1 = 0; index1 < Main.maxNPCs; ++index1)
    {
      NPC npc = Main.npc[index1];
      if (npc.active && npc.CountsAsACritter && !this._wasSeenNearPlayerByNetId.Contains(npc.netID))
      {
        Rectangle hitbox = npc.Hitbox;
        for (int index2 = 0; index2 < this._playerHitboxesForBestiary.Count; ++index2)
        {
          Rectangle rectangle = this._playerHitboxesForBestiary[index2];
          if (hitbox.Intersects(rectangle))
          {
            this._wasSeenNearPlayerByNetId.Add(npc.netID);
            this.RegisterWasNearby(npc);
          }
        }
      }
    }
  }

  public void OnPlayerJoining(int playerIndex)
  {
    foreach (string key in this._wasNearPlayer)
    {
      int npcNetId;
      if (ContentSamples.NpcNetIdsByPersistentIds.TryGetValue(key, out npcNetId))
        NetManager.Instance.SendToClient(NetBestiaryModule.SerializeSight(npcNetId), playerIndex);
    }
  }
}
