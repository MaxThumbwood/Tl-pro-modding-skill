// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.CraftingEffects
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.Audio;
using Terraria.GameContent.Drawing;
using Terraria.Graphics.Renderers;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent;

public class CraftingEffects
{
  private static int _justCraftedItemType;
  private static float _mouseItemGlow;

  public static void OnCraft(Recipe recipe, bool quickCraft)
  {
    CraftingEffects._justCraftedItemType = recipe.createItem.type;
    Item createItem = recipe.createItem;
    CraftingEffects.SpawnEffects_BeforeGrantingItem(recipe, createItem);
    if (quickCraft)
      return;
    CraftingEffects._mouseItemGlow = 1f;
  }

  public static void OnCraftItemGranted(Recipe recipe, Item result, bool quickCraft)
  {
    PopupText.NewText(PopupTextContext.ItemCraft, result, Main.LocalPlayer.Center, recipe.createItem.stack);
    CraftingEffects.SpawnEffects_AfterGrantingItem(recipe, result, quickCraft);
  }

  public static void Update()
  {
    if ((double) CraftingEffects._mouseItemGlow <= 0.0)
      return;
    CraftingEffects._mouseItemGlow -= 0.035f;
  }

  public static float GetGlow(Item cursorItem)
  {
    return (double) CraftingEffects._mouseItemGlow <= 0.0 || CraftingEffects._justCraftedItemType != cursorItem.type ? 0.0f : CraftingEffects._mouseItemGlow;
  }

  private static void SpawnEffects_BeforeGrantingItem(Recipe recipe, Item result)
  {
    SoundEngine.PlaySound(7);
  }

  public static void SpawnEffects_AfterGrantingItem(Recipe recipe, Item result, bool quickCraft)
  {
  }

  private static bool RecipeUsesCraftingStation(Recipe recipe, int tileId)
  {
    return recipe.requiredTile == tileId;
  }

  public static CraftingEffectDetails GetEffectDetails(Item newItem)
  {
    int rare = newItem.rare;
    CraftingEffectDetails effectDetails = new CraftingEffectDetails();
    effectDetails.Rarity = rare;
    if (((newItem.healLife > 0 || newItem.healMana > 0 || newItem.buffType > 0 || ItemID.Sets.IsFood[newItem.type] ? 1 : (ItemID.Sets.SortingPriorityPotionsBuffs[newItem.type] != -1 ? 1 : 0)) & (newItem.consumable ? 1 : 0)) != 0)
    {
      effectDetails.Style = PopupEffectStyle.Potion;
      effectDetails.Intensity = rare;
    }
    int num = newItem.GetRollablePrefixes() != null || newItem.accessory || newItem.bodySlot != -1 || newItem.headSlot != -1 || newItem.legSlot != -1 || newItem.shoot != 0 && Main.projHook[newItem.shoot] ? 1 : (newItem.mountType != -1 ? 1 : 0);
    if (num != 0)
    {
      effectDetails.Style = PopupEffectStyle.Metal;
      effectDetails.Intensity = rare;
    }
    if (num != 0 && newItem.magic)
    {
      effectDetails.Style = PopupEffectStyle.MagicWeapon;
      effectDetails.Intensity = rare;
    }
    if (num != 0 && newItem.melee)
    {
      effectDetails.Style = PopupEffectStyle.MeleeWeapon;
      effectDetails.Intensity = rare;
    }
    if (num != 0 && newItem.ranged)
    {
      effectDetails.Style = PopupEffectStyle.RangedWeapon;
      effectDetails.Intensity = rare;
    }
    return effectDetails;
  }

  private static void CreateBubbleParticles(int n)
  {
    for (float num = 0.0f; (double) num < 2.0; num += 0.0833333358f)
    {
      float timeToLive = 15f;
      float f = (float) (6.2831854820251465 * ((double) num + (double) Main.rand.NextFloat()));
      FadingParticle fadingParticle1 = ParticleOrchestrator._poolFading.RequestParticle();
      fadingParticle1.SetBasicInfo(TextureAssets.Bubble, new Rectangle?(), f.ToRotationVector2() * (float) (2.0 + 3.0 * (double) Main.rand.NextFloat()), Main.MouseScreen + f.ToRotationVector2() * (float) (10.0 + 40.0 * (double) Main.rand.NextFloat()));
      fadingParticle1.SetTypeInfo(timeToLive);
      fadingParticle1.AccelerationPerFrame = fadingParticle1.Velocity * (-1f / timeToLive);
      FadingParticle fadingParticle2 = fadingParticle1;
      fadingParticle2.LocalPosition = fadingParticle2.LocalPosition - fadingParticle1.Velocity * 4f;
      fadingParticle1.FadeInNormalizedTime = 0.2f;
      fadingParticle1.FadeOutNormalizedTime = 0.7f;
      fadingParticle1.Scale = Vector2.One;
      Main.ParticleSystem_OverInventory.Add((IParticle) fadingParticle1);
    }
  }
}
