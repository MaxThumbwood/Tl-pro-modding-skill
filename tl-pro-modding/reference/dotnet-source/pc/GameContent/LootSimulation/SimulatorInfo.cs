// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LootSimulation.SimulatorInfo
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent.LootSimulation;

public class SimulatorInfo
{
  public Player player;
  private double _originalDayTimeCounter;
  private bool _originalDayTimeFlag;
  private Vector2 _originalPlayerPosition;
  public bool runningExpertMode;
  public LootSimulationItemCounter itemCounter;
  public NPC npcVictim;

  public SimulatorInfo()
  {
    this.player = new Player();
    this._originalDayTimeCounter = Main.time;
    this._originalDayTimeFlag = Main.dayTime;
    this._originalPlayerPosition = this.player.position;
    this.runningExpertMode = false;
  }

  public void ReturnToOriginalDaytime()
  {
    Main.dayTime = this._originalDayTimeFlag;
    Main.time = this._originalDayTimeCounter;
  }

  public void AddItem(int itemId, int amount)
  {
    this.itemCounter.AddItem(itemId, amount, this.runningExpertMode);
  }

  public void ReturnToOriginalPlayerPosition()
  {
    this.player.position = this._originalPlayerPosition;
  }
}
