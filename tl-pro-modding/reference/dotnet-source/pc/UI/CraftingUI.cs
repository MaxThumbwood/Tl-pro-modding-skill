// Decompiled with JetBrains decompiler
// Type: Terraria.UI.CraftingUI
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using Terraria.Localization;
using Terraria.UI.Gamepad;

#nullable disable
namespace Terraria.UI;

public class CraftingUI : ICraftingUI
{
  public static float[] availableRecipeY = new float[Recipe.maxRecipes];
  private static NewCraftingUI.RecipeFilter _lastFilter;

  private static float inventoryScale
  {
    get => Main.inventoryScale;
    set => Main.inventoryScale = value;
  }

  private static int numAvailableRecipes => Main.numAvailableRecipes;

  private static int focusRecipe
  {
    get => Main.focusRecipe;
    set => Main.focusRecipe = value;
  }

  private static int mouseX => Main.mouseX;

  private static int mouseY => Main.mouseY;

  private static Color inventoryBack
  {
    get => Main.inventoryBack;
    set => Main.inventoryBack = value;
  }

  private static bool recFastScroll
  {
    get => Main.PipsFastScroll;
    set => Main.PipsFastScroll = value;
  }

  private static int recStart
  {
    get => Main.recStart;
    set => Main.recStart = value;
  }

  public static bool AnyAdvancedGridVisible => NewCraftingUI.Visible;

  public static string CraftingWindowTextKey
  {
    get
    {
      return Player.Settings.CraftingGridControl != Player.Settings.CraftingGridMode.Classic ? "GameUI.CraftingWindow" : "GameUI.CraftingWindowClassic";
    }
  }

  public static string CraftingWindowTextTipKey
  {
    get
    {
      return Player.Settings.CraftingGridControl != Player.Settings.CraftingGridMode.Classic ? "GameUI.CraftingWindowTip" : "GameUI.CraftingWindowClassicTip";
    }
  }

  public CraftingUI()
  {
    for (int index = 0; index < CraftingUI.availableRecipeY.Length; ++index)
      CraftingUI.availableRecipeY[index] = (float) (65 * index);
  }

  public void VisuallyRepositionRecipes(int oldRecipe)
  {
    float num = CraftingUI.availableRecipeY[Main.focusRecipe] - CraftingUI.availableRecipeY[oldRecipe];
    for (int index = 0; index < CraftingUI.availableRecipeY.Length; ++index)
      CraftingUI.availableRecipeY[index] -= num;
  }

  public static NewCraftingUI.RecipeFilter RecipeFilterHack
  {
    get
    {
      return (!Main.playerInventory || Main.PipsCurrentPage != Main.PipPage.Recipes ? 0 : (Player.Settings.CraftingGridControl == Player.Settings.CraftingGridMode.Classic ? 1 : 0)) == 0 ? (NewCraftingUI.RecipeFilter) null : CraftingUI._lastFilter;
    }
  }

  public static void ClearHacks() => CraftingUI._lastFilter = (NewCraftingUI.RecipeFilter) null;

  public void OpenCloseFilter(NewCraftingUI.RecipeFilter filter)
  {
    if (Main.playerInventory && Main.PipsCurrentPage == Main.PipPage.Recipes && Main.PipsUseGrid)
    {
      CraftingUI._lastFilter = (NewCraftingUI.RecipeFilter) null;
      IngameUIWindows.CloseAll();
    }
    else
    {
      CraftingUI._lastFilter = filter;
      IngameUIWindows.CloseAll(true);
      Player.OpenInventory();
      Main.PipsUseGrid = true;
      Main.PipsCurrentPage = Main.PipPage.Recipes;
    }
  }

  public void DrawRecipesList(
    SpriteBatch spriteBatch,
    int adjY,
    int middleY,
    Color craftingTipColor)
  {
    UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeBig = -1;
    UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeSmall = -1;
    if (CraftingUI.numAvailableRecipes > 0)
    {
      string windowDescription = Lang.inter[25].Value;
      if (CraftingUI.RecipeFilterHack != null)
        windowDescription = CraftingUI.RecipeFilterHack.GetWindowDescription();
      DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, windowDescription, new Vector2(76f, (float) (414 + adjY)), craftingTipColor, 0.0f, new Vector2(), 1f, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
    }
    this.AdjustRecipeOffsets();
    for (int recipeIndex = 0; recipeIndex < Recipe.maxRecipes; ++recipeIndex)
    {
      if (recipeIndex < CraftingUI.numAvailableRecipes && (double) Math.Abs(CraftingUI.availableRecipeY[recipeIndex]) <= (double) middleY)
      {
        CraftingUI.inventoryScale = (float) (100.0 / ((double) Math.Abs(CraftingUI.availableRecipeY[recipeIndex]) + 100.0));
        if ((double) CraftingUI.inventoryScale < 0.75)
          CraftingUI.inventoryScale = 0.75f;
        if (CraftingUI.recFastScroll)
          CraftingUI.inventoryScale = 0.75f;
        double inventoryAlpha;
        Color inventoryColor2;
        this.GetItemSlotColors(middleY, 100f, recipeIndex, out inventoryAlpha, out inventoryColor2);
        int x = (int) (46.0 - 26.0 * (double) CraftingUI.inventoryScale);
        int y = (int) (410.0 + (double) CraftingUI.availableRecipeY[recipeIndex] * (double) CraftingUI.inventoryScale - 30.0 * (double) CraftingUI.inventoryScale + (double) adjY);
        if (!Main.LocalPlayer.creativeInterface && CraftingUI.mouseX >= x && (double) CraftingUI.mouseX <= (double) x + (double) TextureAssets.InventoryBack.Width() * (double) CraftingUI.inventoryScale && CraftingUI.mouseY >= y && (double) CraftingUI.mouseY <= (double) y + (double) TextureAssets.InventoryBack.Height() * (double) CraftingUI.inventoryScale && !PlayerInput.IgnoreMouseInterface)
          Main.HoverOverCraftingItemButton(recipeIndex);
        if (CraftingUI.numAvailableRecipes > 0)
        {
          inventoryAlpha -= 50.0;
          if (inventoryAlpha < 0.0)
            inventoryAlpha = 0.0;
          if (recipeIndex == CraftingUI.focusRecipe)
          {
            UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeSmall = 0;
            if (PlayerInput.SettingsForUI.HighlightThingsForMouse)
              ItemSlot.DrawGoldBGForCraftingMaterial = true;
          }
          else
            UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeSmall = -1;
          Color inventoryBack = CraftingUI.inventoryBack;
          CraftingUI.inventoryBack = new Color((int) (byte) inventoryAlpha, (int) (byte) inventoryAlpha, (int) (byte) inventoryAlpha, (int) (byte) inventoryAlpha);
          ItemSlot.Draw(spriteBatch, ref Main.recipe[Main.availableRecipe[recipeIndex]].createItem, 22, new Vector2((float) x, (float) y), inventoryColor2);
          CraftingUI.inventoryBack = inventoryBack;
        }
      }
    }
    CraftingUI.inventoryScale = 0.6f;
    if (CraftingUI.numAvailableRecipes <= 0)
      return;
    UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeBig = -1;
    UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeSmall = -1;
    for (int index = 0; index < Recipe.maxRequirements; ++index)
    {
      Recipe recipe = Main.recipe[Main.availableRecipe[CraftingUI.focusRecipe]];
      Item inv = recipe.requiredItem[index];
      if (inv.type == 0)
      {
        UILinkPointNavigator.Shortcuts.CRAFT_CurrentIngredientsCount = index + 1;
        break;
      }
      int x = 80 /*0x50*/ + index * 40;
      int y = 380 + adjY;
      double num1 = (double) ((int) CraftingUI.inventoryBack.A + 50) - (double) Math.Abs(CraftingUI.availableRecipeY[CraftingUI.focusRecipe]) * 2.0;
      if (num1 == 0.0)
        break;
      if (CraftingUI.mouseX >= x && (double) CraftingUI.mouseX <= (double) x + (double) TextureAssets.InventoryBack.Width() * (double) CraftingUI.inventoryScale && CraftingUI.mouseY >= y && (double) CraftingUI.mouseY <= (double) y + (double) TextureAssets.InventoryBack.Height() * (double) CraftingUI.inventoryScale && !PlayerInput.IgnoreMouseInterface)
      {
        Main.craftingHide = true;
        Main.LocalPlayer.mouseInterface = true;
        ItemSlot.HoverOverrideClick(inv, 22);
        CraftingUI.SetRecipeMaterialDisplayName(recipe, inv);
      }
      double num2 = num1 - 50.0;
      if (num2 < 0.0)
        num2 = 0.0;
      UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeSmall = 1 + index;
      Color inventoryBack = CraftingUI.inventoryBack;
      CraftingUI.inventoryBack = new Color((int) (byte) num2, (int) (byte) num2, (int) (byte) num2, (int) (byte) num2);
      ItemSlot.Draw(spriteBatch, ref inv, 22, new Vector2((float) x, (float) y));
      CraftingUI.inventoryBack = inventoryBack;
    }
  }

  public static void DrawGridToggle(
    SpriteBatch spriteBatch,
    int craftX,
    int craftY,
    int gamepadPointId)
  {
    if (CraftingUI._lastFilter != null && (!CraftingUI._lastFilter.CanRemainOpen() || Main.PipsCurrentPage != Main.PipPage.Recipes || !Main.playerInventory))
      CraftingUI._lastFilter = (NewCraftingUI.RecipeFilter) null;
    UILinkPointNavigator.SetPosition(gamepadPointId, new Vector2((float) craftX, (float) craftY));
    if (CraftingUI.numAvailableRecipes == 0 && !CraftingUI.AnyAdvancedGridVisible)
    {
      if (Main.PipsCurrentPage != Main.PipPage.Recipes)
        return;
      Main.PipsUseGrid = false;
    }
    else
    {
      bool state = CraftingUI.mouseX > craftX - 15 && CraftingUI.mouseX < craftX + 15 && CraftingUI.mouseY > craftY - 15 && CraftingUI.mouseY < craftY + 15 && !PlayerInput.IgnoreMouseInterface;
      if (Main.PipsCurrentPage == Main.PipPage.Recipes)
        Utils.DrawSelectedCraftingBarIndicator(spriteBatch, craftX, craftY);
      bool flag = Player.Settings.CraftingGridControl == Player.Settings.CraftingGridMode.Classic;
      int num = 2;
      if (NewCraftingUI.Visible)
        num = 4;
      if (Main.PipsCurrentPage == Main.PipPage.Recipes && Main.PipsUseGrid)
        num = 0;
      int index = num + state.ToInt();
      spriteBatch.Draw(TextureAssets.CraftToggle[index].Value, new Vector2((float) craftX, (float) craftY), new Rectangle?(), Color.White, 0.0f, TextureAssets.CraftToggle[index].Value.Size() / 2f, 1f, SpriteEffects.None, 0.0f);
      if (state)
      {
        Main.instance.MouseTextNoOverride(Language.GetTextValue(CraftingUI.CraftingWindowTextTipKey));
        Main.player[Main.myPlayer].mouseInterface = true;
        if (Main.mouseLeft && Main.mouseLeftRelease)
        {
          if (!Main.TryChangePipsPage(Main.PipPage.Recipes))
          {
            if (flag)
            {
              NewCraftingUI.Close(true, true);
              Main.PipsUseGrid = !Main.PipsUseGrid;
            }
            else
            {
              Main.PipsUseGrid = false;
              if (CraftingUI.AnyAdvancedGridVisible)
                UILinkPointNavigator.ChangePoint(11001);
              NewCraftingUI.ToggleInInventory();
            }
            Main.mouseLeftRelease = false;
          }
          SoundEngine.PlaySound(12);
        }
        if (Main.mouseRight && Main.mouseRightRelease)
        {
          Main.mouseRightRelease = false;
          SoundEngine.PlaySound(12);
          switch (Player.Settings.CraftingGridControl)
          {
            case Player.Settings.CraftingGridMode.Modern:
              Player.Settings.CraftingGridControl = Player.Settings.CraftingGridMode.Classic;
              break;
            case Player.Settings.CraftingGridMode.Classic:
              Player.Settings.CraftingGridControl = Player.Settings.CraftingGridMode.Modern;
              break;
          }
        }
      }
      Main.DoStatefulTickSound(ref Main.GridToggleMouseOverCrafting, state);
    }
  }

  public static void DrawCraftFromNearbyChestsToggle(
    SpriteBatch spriteBatch,
    int toggleNearbyX,
    int toggleNearbyY,
    int gamepadPointId)
  {
    UILinkPointNavigator.SetPosition(gamepadPointId, new Vector2((float) toggleNearbyX, (float) toggleNearbyY));
    bool state = CraftingUI.mouseX > toggleNearbyX - 15 && CraftingUI.mouseX < toggleNearbyX + 15 && CraftingUI.mouseY > toggleNearbyY - 15 && CraftingUI.mouseY < toggleNearbyY + 15 && !PlayerInput.IgnoreMouseInterface;
    int index = 2 - Player.Settings.CraftFromNearbyChests.ToInt() * 2 + state.ToInt();
    int scale = 1;
    spriteBatch.Draw(TextureAssets.ChestCraft[index].Value, new Vector2((float) toggleNearbyX, (float) toggleNearbyY), new Rectangle?(), Color.White, 0.0f, TextureAssets.ChestCraft[index].Value.Size() / 2f, (float) scale, SpriteEffects.None, 0.0f);
    if (state)
    {
      Main.instance.MouseTextNoOverride(Language.GetTextValue(Player.Settings.CraftFromNearbyChests ? "GameUI.CraftFromNearbyChestsOn" : "GameUI.CraftFromNearbyChestsOff"));
      Main.player[Main.myPlayer].mouseInterface = true;
      if (Main.mouseLeft && Main.mouseLeftRelease)
      {
        Player.Settings.CraftFromNearbyChests = !Player.Settings.CraftFromNearbyChests;
        NewCraftingUI.RefreshGrid();
        SoundEngine.PlaySound(12);
        Main.SaveSettings();
      }
    }
    Main.DoStatefulTickSound(ref Main.nearbyCraftingMouseOver, state);
  }

  private void GetItemSlotColors(
    int middleY,
    float fadeInValue,
    int recipeIndex,
    out double inventoryAlpha,
    out Color inventoryColor2)
  {
    inventoryAlpha = (double) ((int) CraftingUI.inventoryBack.A + 50);
    double num = (double) byte.MaxValue;
    if ((double) Math.Abs(CraftingUI.availableRecipeY[recipeIndex]) > (double) middleY - (double) fadeInValue)
    {
      inventoryAlpha = 150.0 * ((double) fadeInValue - ((double) Math.Abs(CraftingUI.availableRecipeY[recipeIndex]) - ((double) middleY - (double) fadeInValue))) * 0.01;
      num = (double) byte.MaxValue * ((double) fadeInValue - ((double) Math.Abs(CraftingUI.availableRecipeY[recipeIndex]) - ((double) middleY - (double) fadeInValue))) * 0.01;
    }
    Color color = new Color((int) (byte) inventoryAlpha, (int) (byte) inventoryAlpha, (int) (byte) inventoryAlpha, (int) (byte) inventoryAlpha);
    inventoryColor2 = new Color((int) (byte) num, (int) (byte) num, (int) (byte) num, (int) (byte) num);
  }

  private void AdjustRecipeOffsets() => this.DrawRecipes_AdjustRecipeOffsetSnappy();

  private void DrawRecipes_AdjustRecipeOffsetSnappy()
  {
    int num1 = 65;
    float amount = (float) num1 / 10f;
    float num2 = CraftingUI.availableRecipeY[CraftingUI.focusRecipe];
    float num3 = Utils.MoveTowards(num2 * 0.97f, 0.0f, amount);
    if (CraftingUI.recFastScroll)
      num3 = 0.0f;
    CraftingUI.availableRecipeY[CraftingUI.focusRecipe] = num3;
    if ((int) ((double) num2 / (double) num1) != (int) ((double) num3 / (double) num1))
      SoundEngine.PlaySound(12);
    for (int index = 0; index < CraftingUI.numAvailableRecipes; ++index)
    {
      double num4 = (double) CraftingUI.availableRecipeY[index];
      int num5 = (index - CraftingUI.focusRecipe) * num1;
      CraftingUI.availableRecipeY[index] = num3 + (float) num5;
    }
    if ((double) num2 != 0.0)
      return;
    CraftingUI.recFastScroll = false;
  }

  private void DrawRecipes_AdjustRecipeOffset(int recipeIndex)
  {
    int num = 65;
    float amount = (float) num / 10f;
    int target = (recipeIndex - CraftingUI.focusRecipe) * num;
    if ((double) CraftingUI.availableRecipeY[recipeIndex] == (double) target)
    {
      CraftingUI.recFastScroll = false;
    }
    else
    {
      if ((double) CraftingUI.availableRecipeY[recipeIndex] == 0.0 && !CraftingUI.recFastScroll)
        SoundEngine.PlaySound(12);
      if (CraftingUI.recFastScroll)
        CraftingUI.availableRecipeY[recipeIndex] = (float) target;
      else
        CraftingUI.availableRecipeY[recipeIndex] = Utils.MoveTowards(CraftingUI.availableRecipeY[recipeIndex], (float) target, amount);
    }
  }

  public static void SetRecipeMaterialDisplayName(Recipe recipe, Item material)
  {
    ItemSlot.MouseHover(material.Clone(), 22);
    Item hoverItem = Main.HoverItem;
    string theText;
    if (recipe.ProcessGroupsForText(material.type, out theText))
      hoverItem.SetNameOverride(theText);
    Main.hoverItemName = hoverItem.Name;
    if (material.stack <= 1)
      return;
    Main.hoverItemName = $"{Main.hoverItemName} ({(object) material.stack})";
  }

  public void DrawRecipesGrid(SpriteBatch spriteBatch)
  {
    UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeBig = -1;
    UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeSmall = -1;
    int num1 = 42;
    CraftingUI.inventoryScale = 0.75f;
    int num2 = 340;
    int num3 = 310;
    int num4 = (Main.screenWidth - num3 - 280) / num1;
    int num5 = (Main.screenHeight - num2 - 20) / num1;
    UILinkPointNavigator.Shortcuts.CRAFT_IconsPerRow = num4;
    UILinkPointNavigator.Shortcuts.CRAFT_IconsPerColumn = num5;
    int num6 = 0;
    int num7 = 0;
    int num8 = num3;
    int num9 = num2;
    int x1 = num3 - 20;
    int y1 = num2 + 2;
    if (CraftingUI.recStart > CraftingUI.numAvailableRecipes - num4 * num5)
    {
      CraftingUI.recStart = CraftingUI.numAvailableRecipes - num4 * num5;
      if (CraftingUI.recStart < 0)
        CraftingUI.recStart = 0;
    }
    if (CraftingUI.recStart > 0)
    {
      if (CraftingUI.mouseX >= x1 && CraftingUI.mouseX <= x1 + TextureAssets.CraftUpButton.Width() && CraftingUI.mouseY >= y1 && CraftingUI.mouseY <= y1 + TextureAssets.CraftUpButton.Height() && !PlayerInput.IgnoreMouseInterface)
      {
        Main.LocalPlayer.mouseInterface = true;
        if (Main.mouseLeftRelease && Main.mouseLeft)
        {
          CraftingUI.recStart -= num4;
          if (CraftingUI.recStart < 0)
            CraftingUI.recStart = 0;
          SoundEngine.PlaySound(12);
          Main.mouseLeftRelease = false;
        }
      }
      spriteBatch.Draw(TextureAssets.CraftUpButton.Value, new Vector2((float) x1, (float) y1), new Rectangle?(), new Color(200, 200, 200, 200), 0.0f, new Vector2(), 1f, SpriteEffects.None, 0.0f);
    }
    if (CraftingUI.recStart < CraftingUI.numAvailableRecipes - num4 * num5)
    {
      int y2 = y1 + 20;
      if (CraftingUI.mouseX >= x1 && CraftingUI.mouseX <= x1 + TextureAssets.CraftUpButton.Width() && CraftingUI.mouseY >= y2 && CraftingUI.mouseY <= y2 + TextureAssets.CraftUpButton.Height() && !PlayerInput.IgnoreMouseInterface)
      {
        Main.LocalPlayer.mouseInterface = true;
        if (Main.mouseLeftRelease && Main.mouseLeft)
        {
          CraftingUI.recStart += num4;
          SoundEngine.PlaySound(12);
          if (CraftingUI.recStart > CraftingUI.numAvailableRecipes - num4)
            CraftingUI.recStart = CraftingUI.numAvailableRecipes - num4;
          Main.mouseLeftRelease = false;
        }
      }
      spriteBatch.Draw(TextureAssets.CraftDownButton.Value, new Vector2((float) x1, (float) y2), new Rectangle?(), new Color(200, 200, 200, 200), 0.0f, new Vector2(), 1f, SpriteEffects.None, 0.0f);
    }
    for (int recStart = CraftingUI.recStart; recStart < Recipe.maxRecipes && recStart < CraftingUI.numAvailableRecipes; ++recStart)
    {
      int x2 = num8;
      int y3 = num9;
      double num10 = (double) ((int) CraftingUI.inventoryBack.A + 50);
      double maxValue = (double) byte.MaxValue;
      Color color1 = new Color((int) (byte) num10, (int) (byte) num10, (int) (byte) num10, (int) (byte) num10);
      Color color2 = new Color((int) (byte) maxValue, (int) (byte) maxValue, (int) (byte) maxValue, (int) (byte) maxValue);
      if (CraftingUI.mouseX >= x2 && (double) CraftingUI.mouseX <= (double) x2 + (double) TextureAssets.InventoryBack.Width() * (double) CraftingUI.inventoryScale && CraftingUI.mouseY >= y3 && (double) CraftingUI.mouseY <= (double) y3 + (double) TextureAssets.InventoryBack.Height() * (double) CraftingUI.inventoryScale && !PlayerInput.IgnoreMouseInterface)
      {
        Main.LocalPlayer.mouseInterface = true;
        if (Main.mouseLeftRelease && Main.mouseLeft)
        {
          CraftingUI.focusRecipe = recStart;
          CraftingUI.recFastScroll = true;
          Main.PipsUseGrid = false;
          SoundEngine.PlaySound(12);
          Main.mouseLeftRelease = false;
          if (PlayerInput.UsingGamepadUI)
          {
            UILinkPointNavigator.ChangePage(9);
            Main.LockCraftingForThisCraftClickDuration();
          }
        }
        Main.craftingHide = true;
        Item createItem = Main.recipe[Main.availableRecipe[recStart]].createItem;
        Main.HoverItem = createItem.Clone();
        ItemSlot.MouseHover(22);
        Main.hoverItemName = createItem.Name;
        if (createItem.stack > 1)
          Main.hoverItemName = $"{Main.hoverItemName} ({(object) createItem.stack})";
      }
      if (CraftingUI.numAvailableRecipes > 0)
      {
        double num11 = num10 - 50.0;
        if (num11 < 0.0)
          num11 = 0.0;
        UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeBig = recStart - CraftingUI.recStart;
        Color inventoryBack = CraftingUI.inventoryBack;
        CraftingUI.inventoryBack = new Color((int) (byte) num11, (int) (byte) num11, (int) (byte) num11, (int) (byte) num11);
        ItemSlot.Draw(spriteBatch, ref Main.recipe[Main.availableRecipe[recStart]].createItem, 22, new Vector2((float) x2, (float) y3));
        CraftingUI.inventoryBack = inventoryBack;
      }
      num8 += num1;
      ++num6;
      if (num6 >= num4)
      {
        num8 = num3;
        num9 += num1;
        num6 = 0;
        ++num7;
        if (num7 >= num5)
          break;
      }
    }
  }

  public void ScrollCraftingList(int mouseWheel)
  {
    CraftingUI.focusRecipe += mouseWheel;
    if (CraftingUI.focusRecipe > CraftingUI.numAvailableRecipes - 1)
      CraftingUI.focusRecipe = CraftingUI.numAvailableRecipes - 1;
    if (CraftingUI.focusRecipe >= 0)
      return;
    CraftingUI.focusRecipe = 0;
  }

  public void ScrollCraftingGrid(int mouseWheel, int width)
  {
    if (mouseWheel < 0)
    {
      CraftingUI.recStart -= width;
      if (CraftingUI.recStart >= 0)
        return;
      CraftingUI.recStart = 0;
    }
    else
    {
      CraftingUI.recStart += width;
      SoundEngine.PlaySound(12);
      if (CraftingUI.recStart <= CraftingUI.numAvailableRecipes - width)
        return;
      CraftingUI.recStart = CraftingUI.numAvailableRecipes - width;
    }
  }
}
