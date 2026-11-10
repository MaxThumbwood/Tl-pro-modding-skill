// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.NPCKillsTracker
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using System.IO;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.NetModules;
using Terraria.ID;
using Terraria.Net;

#nullable disable
namespace Terraria.GameContent.Bestiary;

public class NPCKillsTracker : IPersistentPerWorldContent, IOnPlayerJoining
{
  private object _entryCreationLock = new object();
  public const int POSITIVE_KILL_COUNT_CAP = 999999999;
  private Dictionary<string, int> _killCountsByNpcId;

  public NPCKillsTracker() => this._killCountsByNpcId = new Dictionary<string, int>();

  public void RegisterKill(NPC npc)
  {
    string bestiaryCreditId = npc.GetBestiaryCreditId();
    int num1;
    this._killCountsByNpcId.TryGetValue(bestiaryCreditId, out num1);
    int num2 = num1 + 1;
    this.SetKillCountDirectly(bestiaryCreditId, num2);
    if (Main.netMode != 2)
      return;
    NetManager.Instance.Broadcast(NetBestiaryModule.SerializeKillCount(npc.netID, num2));
  }

  public int GetKillCount(NPC npc) => this.GetKillCount(npc.GetBestiaryCreditId());

  public void SetKillCountDirectly(string persistentId, int killCount)
  {
    lock (this._entryCreationLock)
    {
      int num = this._killCountsByNpcId.ContainsKey(persistentId) ? 1 : 0;
      this._killCountsByNpcId[persistentId] = Utils.Clamp<int>(killCount, 0, 999999999);
      if (num != 0)
        return;
      AchievementsHelper.TryGrantingBestiary100PercentAchievement();
    }
  }

  public int GetKillCount(string persistentId)
  {
    int killCount;
    this._killCountsByNpcId.TryGetValue(persistentId, out killCount);
    return killCount;
  }

  public void Save(BinaryWriter writer)
  {
    lock (this._killCountsByNpcId)
    {
      writer.Write(this._killCountsByNpcId.Count);
      foreach (KeyValuePair<string, int> keyValuePair in this._killCountsByNpcId)
      {
        writer.Write(keyValuePair.Key);
        writer.Write(keyValuePair.Value);
      }
    }
  }

  public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
  {
    int num = reader.ReadInt32();
    for (int index = 0; index < num; ++index)
      this._killCountsByNpcId[reader.ReadString()] = reader.ReadInt32();
  }

  public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
  {
    int num = reader.ReadInt32();
    for (int index = 0; index < num; ++index)
    {
      reader.ReadString();
      reader.ReadInt32();
    }
  }

  public void Reset() => this._killCountsByNpcId.Clear();

  public void OnPlayerJoining(int playerIndex)
  {
    foreach (KeyValuePair<string, int> keyValuePair in this._killCountsByNpcId)
    {
      int npcNetId;
      if (ContentSamples.NpcNetIdsByPersistentIds.TryGetValue(keyValuePair.Key, out npcNetId))
        NetManager.Instance.SendToClient(NetBestiaryModule.SerializeKillCount(npcNetId, keyValuePair.Value), playerIndex);
    }
  }
}
