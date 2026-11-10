// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Personalities.NPCPreferenceTrait
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.Personalities;

public class NPCPreferenceTrait : IShopPersonalityTrait
{
  public AffectionLevel Level;
  public int NpcId;

  public void ModifyShopPrice(HelperInfo info, ShopHelper shopHelperInstance)
  {
    if (!info.nearbyNPCsByType[this.NpcId])
      return;
    switch (this.Level)
    {
      case AffectionLevel.Hate:
        shopHelperInstance.HateNPC(this.NpcId);
        break;
      case AffectionLevel.Dislike:
        shopHelperInstance.DislikeNPC(this.NpcId);
        break;
      case AffectionLevel.Like:
        shopHelperInstance.LikeNPC(this.NpcId);
        break;
      case AffectionLevel.Love:
        shopHelperInstance.LoveNPC(this.NpcId);
        break;
    }
  }
}
