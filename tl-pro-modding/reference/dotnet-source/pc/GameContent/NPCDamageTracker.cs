// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.NPCDamageTracker
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria.ID;
using Terraria.Localization;

#nullable disable
namespace Terraria.GameContent;

public abstract class NPCDamageTracker
{
  public static NPCDamageTracker.CustomDefinition[] CustomBossDefinitions = NPCID.Sets.Factory.CreateCustomSet<NPCDamageTracker.CustomDefinition>((NPCDamageTracker.CustomDefinition) null);
  public static int[] BossTypeForMob = NPCID.Sets.Factory.CreateIntSet();
  private static List<NPCDamageTracker> _activeTrackers = new List<NPCDamageTracker>();
  private static List<NPCDamageTracker> _recentFinishedTrackers = new List<NPCDamageTracker>();
  private static readonly int MAX_RECENT_TRACKERS = 3;
  private static readonly int EXTRA_RECENT_TRACKER_EXPIRY_TIME = 54000;
  private readonly List<NPCDamageTracker.CreditEntry> _list = new List<NPCDamageTracker.CreditEntry>((int) byte.MaxValue);
  private NPCDamageTracker.WorldCreditEntry _worldCredit;
  private NPCDamageTracker.CreditEntry _lastAttacker;
  private int _ticks;
  private int _lastHitTime;

  public static NPCDamageTracker.CustomDefinition RegisterCompositeTypeBoss(params int[] types)
  {
    NPCDamageTracker.CustomDefinition customDefinition = new NPCDamageTracker.CustomDefinition()
    {
      NPCTypes = ((IEnumerable<int>) types).ToList<int>()
    };
    foreach (int type in types)
      NPCDamageTracker.CustomBossDefinitions[type] = customDefinition;
    return customDefinition;
  }

  public static void RegisterMobsForBoss(int bossType, params int[] mobTypes)
  {
    foreach (int mobType in mobTypes)
      NPCDamageTracker.BossTypeForMob[mobType] = bossType;
  }

  static NPCDamageTracker()
  {
    NPCDamageTracker.RegisterMobsForBoss(50, 1, 535);
    NPCDamageTracker.RegisterMobsForBoss(4, 5);
    NPCDamageTracker.RegisterMobsForBoss(222, 210, 211);
    NPCDamageTracker.RegisterCompositeTypeBoss(13, 14, 15);
    NPCDamageTracker.RegisterCompositeTypeBoss(266, 267);
    NPCDamageTracker.RegisterCompositeTypeBoss(35, 36);
    NPCDamageTracker.RegisterMobsForBoss(113, 115, 116, 117, 118, 119);
    NPCDamageTracker.RegisterMobsForBoss(657, 658, 659, 660);
    NPCDamageTracker.RegisterCompositeTypeBoss(126, 125).Name = Language.GetText("Enemies.TheTwins");
    NPCDamageTracker.RegisterCompositeTypeBoss((int) sbyte.MaxValue, 128 /*0x80*/, 129, 130, 131);
    NPCDamageTracker.RegisterMobsForBoss(134, 139);
    NPCDamageTracker.RegisterMobsForBoss(262, 264);
    NPCDamageTracker.RegisterCompositeTypeBoss(245, 246, 247, 248);
    NPCDamageTracker.RegisterMobsForBoss(370, 372, 373);
    NPCDamageTracker.RegisterMobsForBoss(439, 454, 455, 456, 457, 458, 459);
    NPCDamageTracker.RegisterCompositeTypeBoss(398, 396, 397).Name = Language.GetText("Enemies.MoonLord");
  }

  private static bool GetRealActiveNPC(ref NPC npc)
  {
    if (npc.realLife >= 0)
      npc = Main.npc[npc.realLife];
    return npc.active;
  }

  private static bool TryGetTrackerFor(NPC npc, out NPCDamageTracker tracker)
  {
    tracker = (NPCDamageTracker) null;
    if (!NPCDamageTracker.GetRealActiveNPC(ref npc))
      return false;
    foreach (NPCDamageTracker activeTracker in NPCDamageTracker._activeTrackers)
    {
      if (activeTracker.IncludeDamageFor(npc))
      {
        tracker = activeTracker;
        return true;
      }
    }
    return false;
  }

  private static bool CreateTrackerFor(NPC npc, out NPCDamageTracker tracker)
  {
    tracker = (NPCDamageTracker) null;
    NPCDamageTracker.CustomDefinition customBossDefinition = NPCDamageTracker.CustomBossDefinitions[npc.type];
    if (customBossDefinition == null && !npc.boss)
      return false;
    tracker = (NPCDamageTracker) new BossDamageTracker(npc.type, customBossDefinition);
    return true;
  }

  public static void AddDamage(NPC npc, int owner, int damage)
  {
    if (!NPCDamageTracker.GetRealActiveNPC(ref npc) || npc.life <= 0)
      return;
    NPCDamageTracker tracker;
    if (!NPCDamageTracker.TryGetTrackerFor(npc, out tracker))
    {
      if (!NPCDamageTracker.CreateTrackerFor(npc, out tracker))
        return;
      NPCDamageTracker.Start(tracker);
    }
    tracker.AddDamage(owner, Math.Min(damage, npc.life));
  }

  public static void AddDamageToLastAttack(NPC npc, int damage)
  {
    NPCDamageTracker tracker;
    if (!NPCDamageTracker.GetRealActiveNPC(ref npc) || npc.life <= 0 || !NPCDamageTracker.TryGetTrackerFor(npc, out tracker))
      return;
    tracker.AddDamageToLastAttack(Math.Min(damage, npc.life));
  }

  public static void BossKilled(NPC npc)
  {
    NPCDamageTracker tracker;
    if (!NPCDamageTracker.TryGetTrackerFor(npc, out tracker))
      return;
    tracker.OnBossKilled(npc);
  }

  public static void Start(NPCDamageTracker tracker)
  {
    NPCDamageTracker._activeTrackers.Add(tracker);
  }

  public static void Reset()
  {
    NPCDamageTracker._activeTrackers.Clear();
    NPCDamageTracker._recentFinishedTrackers.Clear();
  }

  public static IEnumerable<NPCDamageTracker> RecentAttempts()
  {
    return (IEnumerable<NPCDamageTracker>) NPCDamageTracker._recentFinishedTrackers;
  }

  public static void Update()
  {
    foreach (NPCDamageTracker activeTracker in NPCDamageTracker._activeTrackers)
      activeTracker.Tick();
    foreach (NPCDamageTracker recentFinishedTracker in NPCDamageTracker._recentFinishedTrackers)
      recentFinishedTracker.Tick();
    for (int index = NPCDamageTracker._activeTrackers.Count - 1; index >= 0; --index)
      NPCDamageTracker._activeTrackers[index].CheckActive();
    while (NPCDamageTracker._recentFinishedTrackers.Count > 1 && NPCDamageTracker._recentFinishedTrackers[0].TimeSinceLastHit > NPCDamageTracker.EXTRA_RECENT_TRACKER_EXPIRY_TIME)
      NPCDamageTracker._recentFinishedTrackers.RemoveAt(0);
  }

  private static void StopTracking(NPCDamageTracker tracker)
  {
    if (!NPCDamageTracker._activeTrackers.Remove(tracker) || tracker.IsEmpty)
      return;
    NPCDamageTracker._recentFinishedTrackers.Add(tracker);
    if (NPCDamageTracker._recentFinishedTrackers.Count <= NPCDamageTracker.MAX_RECENT_TRACKERS)
      return;
    NPCDamageTracker._recentFinishedTrackers.RemoveAt(0);
  }

  public bool IsEmpty => this._list.Count == 0;

  public int Duration => this._lastHitTime;

  public int TimeSinceLastHit => this._ticks - this._lastHitTime;

  public abstract LocalizedText Name { get; }

  public abstract LocalizedText KillTimeMessage { get; }

  protected abstract bool IncludeDamageFor(NPC npc);

  protected virtual void CheckActive()
  {
  }

  protected virtual void OnBossKilled(NPC npc)
  {
  }

  private void Tick() => ++this._ticks;

  protected void Stop() => NPCDamageTracker.StopTracking(this);

  public void AddDamage(int owner, int damage)
  {
    this._lastHitTime = this._ticks;
    NPCDamageTracker.CreditEntry orAddEntry = this.GetOrAddEntry(owner);
    orAddEntry.Damage += damage;
    this._lastAttacker = orAddEntry;
  }

  public void AddDamageToLastAttack(int damage) => this._lastAttacker.Damage += damage;

  private NPCDamageTracker.CreditEntry GetOrAddEntry(int owner)
  {
    if (owner < 0 || owner >= (int) byte.MaxValue)
    {
      if (this._worldCredit == null)
      {
        this._worldCredit = new NPCDamageTracker.WorldCreditEntry();
        this._list.Add((NPCDamageTracker.CreditEntry) this._worldCredit);
      }
      return (NPCDamageTracker.CreditEntry) this._worldCredit;
    }
    string name = Main.player[owner].name;
    foreach (NPCDamageTracker.CreditEntry creditEntry in this._list)
    {
      if (creditEntry is NPCDamageTracker.PlayerCreditEntry orAddEntry && orAddEntry.PlayerName == name)
        return (NPCDamageTracker.CreditEntry) orAddEntry;
    }
    NPCDamageTracker.PlayerCreditEntry orAddEntry1 = new NPCDamageTracker.PlayerCreditEntry(name);
    this._list.Add((NPCDamageTracker.CreditEntry) orAddEntry1);
    return (NPCDamageTracker.CreditEntry) orAddEntry1;
  }

  public NetworkText GetReport(Player forPlayer = null)
  {
    this._list.Sort();
    int[] array = this._list.Select<NPCDamageTracker.CreditEntry, int>((Func<NPCDamageTracker.CreditEntry, int>) (x => x.Damage)).ToArray<int>();
    int[] percentages = NPCDamageTracker.CalculatePercentages(array);
    int length = ((IEnumerable<int>) array).Max().ToString().Length;
    List<NetworkText> networkTextList = new List<NetworkText>(this._list.Count + 2);
    StringBuilder stringBuilder1 = new StringBuilder("{0}");
    networkTextList.Add(NetworkText.FromKey("BossDamageCommand.Title", (object) this.Name.ToNetworkText()));
    LocalizedText killTimeMessage = this.KillTimeMessage;
    if (killTimeMessage != null)
    {
      stringBuilder1.Append("\n{1}");
      TimeSpan timeSpan = TimeSpan.FromSeconds((double) this.Duration / 60.0);
      string str = $"{(int) timeSpan.TotalMinutes}:{timeSpan.Seconds:00}";
      networkTextList.Add(killTimeMessage.ToNetworkText((object) str));
    }
    for (int index = 0; index < this._list.Count; ++index)
    {
      StringBuilder stringBuilder2 = new StringBuilder();
      stringBuilder2.Append(percentages[index]).Append('%');
      while (stringBuilder2.Length < 6)
        stringBuilder2.Append(' ');
      stringBuilder2.Append(array[index]);
      while (stringBuilder2.Length < 8 + length)
        stringBuilder2.Append(' ');
      NPCDamageTracker.CreditEntry creditEntry = this._list[index];
      stringBuilder2.Append('{').Append(networkTextList.Count).Append('}');
      networkTextList.Add(creditEntry.Name);
      string str = stringBuilder2.ToString();
      if (forPlayer != null && creditEntry is NPCDamageTracker.PlayerCreditEntry && ((NPCDamageTracker.PlayerCreditEntry) creditEntry).PlayerName == forPlayer.name)
        str = $"[c/FFAF00:{str}]";
      stringBuilder1.Append('\n').Append(str);
    }
    return NetworkText.FromFormattable(stringBuilder1.ToString(), (object[]) networkTextList.ToArray());
  }

  private static int[] CalculatePercentages(int[] damages)
  {
    int num1 = ((IEnumerable<int>) damages).Sum();
    int[] percentages = new int[damages.Length];
    double[] numArray = new double[damages.Length];
    int num2 = 0;
    for (int index = 0; index < damages.Length; ++index)
    {
      double num3 = (double) (damages[index] * 100) / (double) num1;
      int num4 = (int) num3;
      percentages[index] = num4;
      numArray[index] = num3 - (double) num4;
      num2 += num4;
    }
    for (; num2 < 100; ++num2)
    {
      int index1 = 0;
      double num5 = 0.0;
      for (int index2 = 0; index2 < damages.Length; ++index2)
      {
        if (numArray[index2] > num5)
        {
          num5 = numArray[index2];
          index1 = index2;
        }
      }
      numArray[index1] = 0.0;
      ++percentages[index1];
    }
    return percentages;
  }

  public class CustomDefinition
  {
    public List<int> NPCTypes;
    public LocalizedText Name;
  }

  private abstract class CreditEntry : IComparable<NPCDamageTracker.CreditEntry>
  {
    public int Damage { get; set; }

    public abstract NetworkText Name { get; }

    public int CompareTo(NPCDamageTracker.CreditEntry other)
    {
      return -this.Damage.CompareTo(other.Damage);
    }
  }

  private class PlayerCreditEntry : NPCDamageTracker.CreditEntry
  {
    public readonly string PlayerName;

    public PlayerCreditEntry(string name) => this.PlayerName = name;

    public override NetworkText Name => NetworkText.FromLiteral(this.PlayerName);
  }

  private class WorldCreditEntry : NPCDamageTracker.CreditEntry
  {
    public override NetworkText Name => NetworkText.FromKey("BossDamageCommand.WorldCreditName");
  }
}
