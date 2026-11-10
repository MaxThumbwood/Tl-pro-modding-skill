// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.NPCNetIdBestiaryInfoElement
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.ID;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.Bestiary;

public class NPCNetIdBestiaryInfoElement : IBestiaryInfoElement, IBestiaryEntryDisplayIndex
{
  public int NetId { get; private set; }

  public NPCNetIdBestiaryInfoElement(int npcNetId) => this.NetId = npcNetId;

  public UIElement ProvideUIElement(BestiaryUICollectionInfo info) => (UIElement) null;

  public int BestiaryDisplayIndex => ContentSamples.NpcBestiarySortingId[this.NetId];
}
