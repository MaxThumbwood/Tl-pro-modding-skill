// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Items.ItemVariantCondition
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Localization;

#nullable disable
namespace Terraria.GameContent.Items;

public class ItemVariantCondition
{
  public readonly NetworkText Description;
  public readonly ItemVariantCondition.Condition IsMet;

  public ItemVariantCondition(NetworkText description, ItemVariantCondition.Condition condition)
  {
    this.Description = description;
    this.IsMet = condition;
  }

  public override string ToString() => this.Description.ToString();

  public delegate bool Condition();
}
