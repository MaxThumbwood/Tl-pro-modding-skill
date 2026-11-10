// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.InvasionDamageTracker
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using Terraria.Localization;

#nullable disable
namespace Terraria.GameContent;

public class InvasionDamageTracker : NPCDamageTracker
{
  private static Dictionary<int, string> VanillaInvasionNameKeys = new Dictionary<int, string>()
  {
    {
      1,
      "Bestiary_Invasions.Goblins"
    },
    {
      2,
      "Bestiary_Invasions.FrostLegion"
    },
    {
      3,
      "Bestiary_Invasions.Pirates"
    },
    {
      4,
      "Bestiary_Invasions.Martian"
    },
    {
      -2,
      "Bestiary_Invasions.PumpkinMoon"
    },
    {
      -1,
      "Bestiary_Invasions.FrostMoon"
    }
  };
  private readonly int _invasionGroup;
  private readonly LocalizedText _name;

  public InvasionDamageTracker(int invasionGroup, LocalizedText name = null)
  {
    this._invasionGroup = invasionGroup;
    this._name = name != null ? name : Language.GetText(InvasionDamageTracker.VanillaInvasionNameKeys[invasionGroup]);
  }

  public override LocalizedText Name => this._name;

  public override LocalizedText KillTimeMessage => (LocalizedText) null;

  protected override bool IncludeDamageFor(NPC npc)
  {
    return NPC.GetNPCInvasionGroup(npc.type) == this._invasionGroup;
  }

  protected override void CheckActive()
  {
    if (this.IsActive())
      return;
    this.Stop();
  }

  private bool IsActive()
  {
    if (this._invasionGroup == -2)
      return Main.pumpkinMoon;
    return this._invasionGroup == -1 ? Main.snowMoon : Main.invasionType == this._invasionGroup;
  }
}
