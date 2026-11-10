// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.NPCInteraction
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent;

public abstract class NPCInteraction
{
  public abstract bool Condition();

  public abstract string GetText();

  public abstract void Interact();

  public virtual bool ShowExcalmation => false;

  public virtual bool TryAddCoins(ref Color chatColor, out int coinValue)
  {
    coinValue = 0;
    return false;
  }

  public Player LocalPlayer => Main.LocalPlayer;

  public NPC TalkNPC => Main.npc[this.LocalPlayer.talkNPC];

  public int TalkNPCType => this.LocalPlayer.talkNPC == -1 ? 0 : this.TalkNPC.type;
}
