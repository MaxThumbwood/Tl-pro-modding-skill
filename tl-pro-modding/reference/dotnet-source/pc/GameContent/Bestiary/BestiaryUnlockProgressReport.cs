// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.BestiaryUnlockProgressReport
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.Bestiary;

public struct BestiaryUnlockProgressReport
{
  public int EntriesTotal;
  public float CompletionAmountTotal;

  public float CompletionPercent
  {
    get => this.EntriesTotal == 0 ? 1f : this.CompletionAmountTotal / (float) this.EntriesTotal;
  }
}
