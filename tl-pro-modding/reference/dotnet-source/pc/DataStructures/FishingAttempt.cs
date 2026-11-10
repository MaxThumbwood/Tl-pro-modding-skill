// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.FishingAttempt
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public struct FishingAttempt
{
  public PlayerFishingConditions playerFishingConditions;
  public int X;
  public int Y;
  public int bobberType;
  public bool common;
  public bool uncommon;
  public bool rare;
  public bool veryrare;
  public bool legendary;
  public bool crate;
  public bool junk;
  public bool inLava;
  public bool inHoney;
  public int waterTilesCount;
  public int waterNeededToFish;
  public float waterQuality;
  public int chumsInWater;
  public int fishingLevel;
  public bool CanFishInLava;
  public float atmo;
  public int questFish;
  public int heightLevel;
  public int rolledItemDrop;
  public int rolledEnemySpawn;
}
