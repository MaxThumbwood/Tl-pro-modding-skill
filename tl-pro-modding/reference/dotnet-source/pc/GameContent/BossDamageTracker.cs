// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.BossDamageTracker
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Localization;

#nullable disable
namespace Terraria.GameContent;

public class BossDamageTracker : NPCDamageTracker
{
  private readonly int _type;
  private readonly NPCDamageTracker.CustomDefinition _overrides;
  private bool _killed;

  public BossDamageTracker(int type, NPCDamageTracker.CustomDefinition definition)
  {
    if (definition != null && definition.NPCTypes != null)
      type = definition.NPCTypes[0];
    this._type = type;
    this._overrides = definition;
  }

  public override LocalizedText Name
  {
    get
    {
      return this._overrides == null || this._overrides.Name == null ? Lang.GetNPCName(this._type) : this._overrides.Name;
    }
  }

  public override LocalizedText KillTimeMessage
  {
    get
    {
      return Language.GetText(this._killed ? "BossDamageCommand.KillTime" : "BossDamageCommand.KillTimeEscaped");
    }
  }

  protected override bool IncludeDamageFor(NPC npc)
  {
    if (NPCDamageTracker.BossTypeForMob[npc.type] == this._type)
      return true;
    return this._overrides == null || this._overrides.NPCTypes == null ? npc.type == this._type : this._overrides.NPCTypes.Contains(npc.type);
  }

  protected override void CheckActive()
  {
    if (this.IsActive())
      return;
    this.Stop();
  }

  private bool IsActive()
  {
    if (this._overrides == null || this._overrides.NPCTypes == null)
      return NPC.npcsFoundForCheckActive[this._type];
    foreach (int npcType in this._overrides.NPCTypes)
    {
      if (NPC.npcsFoundForCheckActive[npcType])
        return true;
    }
    return false;
  }

  protected override void OnBossKilled(NPC npc) => this._killed = true;
}
