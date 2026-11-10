// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.NewCraftingUI
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Map;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.UI.Gamepad;

#nullable disable
namespace Terraria.GameContent.UI;

public class NewCraftingUI : UIState
{
  private static UserInterface _ui = new UserInterface();
  private static NewCraftingUI _instance;
  private bool _openedWithoutFilter;
  private NewCraftingUI.RecipeFilter _filter;
  private int? _selectedRecipeIndex;
  private NewCraftingUI.RecipeEntry _hoveredEntry;
  private string _missingRequirementsTooltipText;
  private NewCraftingUI.ItemGrid _itemGrid;
  private UIText _text;
  private UIWrappedSearchBar _searchBar;
  private UIElement _gridContainer;
  private bool _gamepadMoveToSearchButtonHack;
  private bool _gamepadMoveToGridEntryHack;
  private bool _gamepadReturnToGridEntry;
  private EntryFilterer<Item, IItemEntryFilter> _filterer;
  public const string SnapPointName_Search = "NewCraftingUISearch";
  public const string SnapPointName_Filters = "NewCraftingUIFilters";
  private static List<string> _missingObjects = new List<string>();
  private static readonly Color DisabledSlotColor = new Color(160 /*0xA0*/, 160 /*0xA0*/, 160 /*0xA0*/, (int) byte.MaxValue);
  private List<NewCraftingUI.RecipeEntry> _recipes = new List<NewCraftingUI.RecipeEntry>(Recipe.maxRecipes);
  private List<NewCraftingUI.RecipeEntry> _filteredRecipes = new List<NewCraftingUI.RecipeEntry>(Recipe.maxRecipes);
  private NewCraftingUI.RecipeEntry[] _recipeListLookup;
  private Item _resetForGuideItem;
  private UIGamepadHelper _helper;

  public static bool Visible => NewCraftingUI._ui.CurrentState != null;

  private NewCraftingUI.RecipeEntry SelectedEntry
  {
    get
    {
      return !this._selectedRecipeIndex.HasValue ? (NewCraftingUI.RecipeEntry) null : this._recipeListLookup[this._selectedRecipeIndex.Value];
    }
  }

  public NewCraftingUI()
  {
    UILinkPage page = UILinkPointNavigator.Pages[24];
    page.OnSpecialInteracts += new Func<string>(this.GetGamepadInstructions);
    page.UpdateEvent += (Action) (() => PlayerInput.GamepadAllowScrolling = true);
    page.EnterEvent += (Action) (() => page.CurrentPoint = Main.InGuideCraftMenu ? 20020 : 20000);
    this._filterer = new EntryFilterer<Item, IItemEntryFilter>();
    List<IItemEntryFilter> itemEntryFilterList = new List<IItemEntryFilter>()
    {
      (IItemEntryFilter) new ItemFilters.Weapon(),
      (IItemEntryFilter) new ItemFilters.Armor(),
      (IItemEntryFilter) new ItemFilters.Vanity(),
      (IItemEntryFilter) new ItemFilters.BuildingBlock(),
      (IItemEntryFilter) new ItemFilters.Furniture(),
      (IItemEntryFilter) new ItemFilters.Accessories(),
      (IItemEntryFilter) new ItemFilters.MiscAccessories(),
      (IItemEntryFilter) new ItemFilters.Consumables(),
      (IItemEntryFilter) new ItemFilters.Tools(),
      (IItemEntryFilter) new ItemFilters.Materials()
    };
    List<IItemEntryFilter> filters = new List<IItemEntryFilter>();
    filters.AddRange((IEnumerable<IItemEntryFilter>) itemEntryFilterList);
    filters.Add((IItemEntryFilter) new ItemFilters.MiscFallback(itemEntryFilterList));
    this._filterer.AddFilters(filters);
    this._filterer.SetSearchFilterObject<ItemFilters.BySearch>(new ItemFilters.BySearch());
    this.HAlign = 0.0f;
    this.VAlign = 0.0f;
    this.Left = new StyleDimension(20f, 0.0f);
    this.Top = new StyleDimension(312f, 0.0f);
    this.Width = new StyleDimension(490f, 0.0f);
    this.Height = new StyleDimension(-350f, 1f);
    this.SetPadding(0.0f);
    UIElement uiElement = new UIElement()
    {
      Width = StyleDimension.Fill,
      Height = StyleDimension.Fill
    };
    uiElement.SetPadding(0.0f);
    this.BuildInfinitesMenuContents(uiElement);
    this.Append(uiElement);
  }

  private void BuildInfinitesMenuContents(UIElement totalContainer)
  {
    UIPanel uiPanel = new UIPanel();
    uiPanel.Width = new StyleDimension(0.0f, 1f);
    uiPanel.Height = new StyleDimension(-38f, 1f);
    uiPanel.Top = new StyleDimension(38f, 0.0f);
    uiPanel.PaddingRight = 8f;
    UIPanel element1 = uiPanel;
    element1.BackgroundColor = Utils.ShiftBlueToCyanTheme(element1.BackgroundColor);
    element1.BorderColor = Utils.ShiftBlueToCyanTheme(element1.BorderColor);
    element1.BackgroundColor *= 0.8f;
    element1.BorderColor *= 0.8f;
    totalContainer.Append((UIElement) element1);
    UIText uiText = new UIText("");
    uiText.Left = new StyleDimension(-1f, 0.0f);
    uiText.Top = new StyleDimension(-2f, 0.0f);
    UIText element2 = uiText;
    element1.Append((UIElement) element2);
    this._text = element2;
    UIWrappedSearchBar wrappedSearchBar = new UIWrappedSearchBar(new Action(this.GoBackFromVirtualKeyboard), theme: UIWrappedSearchBar.ColorTheme.Red);
    wrappedSearchBar.Top = new StyleDimension(-4f, 0.0f);
    wrappedSearchBar.HAlign = 1f;
    UIWrappedSearchBar element3 = wrappedSearchBar;
    element3.CustomOpenVirtualKeyboard = (Action<UIState>) (state => IngameFancyUI.OpenUIState(state, false));
    element3.OnSearchContentsChanged += new Action<string>(this.OnSearchContentsChanged);
    element3.SetSearchSnapPoint("NewCraftingUISearch", 0);
    element1.Append((UIElement) element3);
    this._searchBar = element3;
    UIElement element4 = new UIElement()
    {
      Width = StyleDimension.Fill,
      Height = StyleDimension.Fill,
      VAlign = 1f
    };
    this._gridContainer = element4;
    element1.Append(element4);
    UIHorizontalSeparator horizontalSeparator = new UIHorizontalSeparator();
    horizontalSeparator.Width = new StyleDimension(-8f, 1f);
    horizontalSeparator.HAlign = 0.5f;
    horizontalSeparator.Color = new Color(89, 116, 213, (int) byte.MaxValue) * 0.9f;
    UIHorizontalSeparator element5 = horizontalSeparator;
    element5.Color = Utils.ShiftBlueToCyanTheme(element5.Color);
    element4.Append((UIElement) element5);
    UIList uiList = new UIList();
    uiList.Width = new StyleDimension(-20f, 1f);
    uiList.Height = new StyleDimension(-7f, 1f);
    uiList.VAlign = 1f;
    uiList.HAlign = 0.0f;
    UIList element6 = uiList;
    element4.Append((UIElement) element6);
    float num = 4f;
    UIScrollbar uiScrollbar1 = new UIScrollbar(UIScrollbar.ColorTheme.Cyan);
    uiScrollbar1.AutoHide = true;
    uiScrollbar1.Height = new StyleDimension((float) (-(double) num * 2.0 - 11.0), 1f);
    uiScrollbar1.Top = new StyleDimension(-num, 0.0f);
    uiScrollbar1.VAlign = 1f;
    uiScrollbar1.HAlign = 1f;
    UIScrollbar uiScrollbar2 = uiScrollbar1;
    element4.Append((UIElement) uiScrollbar2);
    element6.SetScrollbar(uiScrollbar2);
    element6.Add((UIElement) (this._itemGrid = new NewCraftingUI.ItemGrid(this)));
    UICreativeItemsInfiniteFilteringOptions filteringOptions = new UICreativeItemsInfiniteFilteringOptions(this._filterer, "NewCraftingUIFilters", UICreativeItemsInfiniteFilteringOptions.ColorTheme.Cyan);
    filteringOptions.HAlign = 0.5f;
    UICreativeItemsInfiniteFilteringOptions element7 = filteringOptions;
    element7.OnClickingOption += new Action(this.ResetRecipes);
    totalContainer.Append((UIElement) element7);
  }

  public override void Draw(SpriteBatch spriteBatch)
  {
    if (this.IsMouseHovering)
      Main.LocalPlayer.mouseInterface = true;
    this.UpdateCraftAreaSize();
    this.UpdateText();
    this.UpdateContents();
    base.Draw(spriteBatch);
  }

  private void UpdateCraftAreaSize()
  {
    int num = Main.InGuideCraftMenu ? 130 : 77;
    if ((double) this._gridContainer.Height.Pixels == (double) -num)
      return;
    this._gridContainer.Height.Pixels = (float) -num;
    this._gridContainer.Recalculate();
  }

  private void UpdateText()
  {
    string text = this._filter != null ? this._filter.GetWindowDescription() : Lang.inter[25].Value;
    if (!(text != this._text.Text))
      return;
    this._text.SetText(text);
    this._text.Recalculate();
    this._searchBar.Width = new StyleDimension((float) (-(double) this._text.GetOuterDimensions().Width - 10.0), 1f);
    this._searchBar.Recalculate();
  }

  protected override void DrawChildren(SpriteBatch spriteBatch)
  {
    this._hoveredEntry = (NewCraftingUI.RecipeEntry) null;
    this._missingRequirementsTooltipText = (string) null;
    base.DrawChildren(spriteBatch);
    if (PlayerInput.UsingGamepad && this._hoveredEntry != null)
      this._selectedRecipeIndex = new int?(this._hoveredEntry.index);
    Vector2 pos = this.GetInnerDimensions().ToRectangle().TopLeft() + new Vector2(24f, 73f);
    if (Main.InGuideCraftMenu)
    {
      if (this.DrawRecipeSlot(spriteBatch, Main.guideItem, 7, pos + new Vector2(0.0f, 58f), true, 1f))
        ItemSlot.Handle(ref Main.guideItem, 7);
      string text = Main.guideItem.IsAir ? Lang.inter[24].Value : $"{Lang.inter[21].Value} {Main.guideItem.Name}";
      ChatManager.DrawColorCodedStringWithShadow(spriteBatch, FontAssets.MouseText.Value, text, pos + new Vector2(52f, 73f), Color.White, 0.0f, Vector2.Zero, Vector2.One, spread: 1f);
    }
    int materialCount = 0;
    NewCraftingUI.RecipeEntry entry = this._hoveredEntry ?? this.SelectedEntry;
    if (entry != null)
    {
      Recipe recipe = entry.Recipe;
      if (Main.InGuideCraftMenu)
      {
        string requirementsText = Main.GetRecipeRequirementsText(recipe, false);
        ChatManager.DrawColorCodedStringWithShadow(spriteBatch, FontAssets.MouseText.Value, requirementsText, pos + new Vector2(52f, 36f), Color.White, 0.0f, Vector2.Zero, Vector2.One, spread: 1f);
      }
      if (this.DrawRecipeSlot(spriteBatch, recipe.createItem, 42, pos, entry.Available, 1f))
        this.HandleCraftSlot(entry, 42);
      spriteBatch.Draw(Main.Assets.Request<Texture2D>("Images/UI/Craft", (AssetRequestMode) 1).Value, pos + new Vector2(47f, 13f), new Rectangle?(), Color.White, 0.0f, Vector2.Zero, 0.8f, SpriteEffects.None, 0.0f);
      while (materialCount < Recipe.maxRequirements && !recipe.requiredItem[materialCount].IsAir)
        ++materialCount;
      Vector2 vector2_1 = pos + new Vector2(72f, 22f);
      float mscale = Math.Min(11f / (float) materialCount, 1f);
      for (int index = 0; index < materialCount; ++index)
      {
        Item obj = recipe.requiredItem[index];
        int availableItemCount = Recipe.GetAvailableItemCount(recipe.requiredItemQuickLookup[index]);
        bool flag = Main.InGuideCraftMenu || availableItemCount >= obj.stack;
        Vector2 vector2_2 = vector2_1 + new Vector2((float) (index * 34), -16f) * mscale;
        UILinkPointNavigator.Shortcuts.NewCraftingUI_MaterialIndex = index;
        if (this.DrawRecipeSlot(spriteBatch, obj, 43, vector2_2, flag, 0.7f * mscale))
        {
          ItemSlot.HoverOverrideClick(obj, 43);
          CraftingUI.SetRecipeMaterialDisplayName(recipe, obj);
        }
        if (!Main.InGuideCraftMenu)
          this.DrawOwnedItemCount(spriteBatch, availableItemCount, flag, vector2_2, mscale);
      }
    }
    int craftX = 42;
    int num = 285;
    if (Main.LocalPlayer.difficulty == (byte) 3 && !Main.CreativeMenu.Blocked)
      craftX += 40;
    CraftingUI.DrawGridToggle(spriteBatch, craftX, num, 20030);
    int toggleNearbyX = craftX + 40;
    if (!Main.InGuideCraftMenu)
      CraftingUI.DrawCraftFromNearbyChestsToggle(spriteBatch, toggleNearbyX, num, 20031);
    this.SetupGamepadPoints(entry != null, materialCount);
  }

  private void HandleCraftSlot(NewCraftingUI.RecipeEntry entry, int context)
  {
    Recipe recipe = entry.Recipe;
    int? selectedRecipeIndex = this._selectedRecipeIndex;
    int index = entry.index;
    bool flag = !(selectedRecipeIndex.GetValueOrDefault() == index & selectedRecipeIndex.HasValue) || PlayerInput.UsingGamepad && context == 41;
    if (!entry.Available | flag)
    {
      if (!ItemSlot.HoverOverrideClick(recipe.createItem, context) & flag && (Main.mouseLeft && Main.mouseLeftRelease || Main.mouseRight && Main.mouseRightRelease))
      {
        this._selectedRecipeIndex = new int?(entry.index);
        if (entry.Available)
          Main.focusRecipe = entry.availableIndex;
        UILinkPointNavigator.ChangePoint(20000);
        this._gamepadReturnToGridEntry = true;
        Main.stackSplit = 15;
        Main._preventCraftingBecauseClickWasUsedToChangeFocusedRecipe = true;
        SoundEngine.PlaySound(12);
      }
      ItemSlot.MouseHover(recipe.createItem, context);
    }
    else
      Main.HoverOverCraftingItemButton(Main.focusRecipe);
    if (entry.Available)
      return;
    this._missingRequirementsTooltipText = this.GetReasonForRecipeNotAvailable(recipe);
  }

  private string GetReasonForRecipeNotAvailable(Recipe recipe)
  {
    NewCraftingUI._missingObjects.Clear();
    recipe.PlayerMeetsEnvironmentConditions(Main.LocalPlayer, NewCraftingUI._missingObjects);
    return NewCraftingUI._missingObjects.Count > 0 ? $"{Lang.inter[22].Value} {string.Join(", ", (IEnumerable<string>) NewCraftingUI._missingObjects)}" : Language.GetTextValue("GameUI.NotEnoughMaterials");
  }

  internal static void AddTooltipLines(
    Item hoverItem,
    ref int numLines,
    string[] lineText,
    Color[] lineColors)
  {
    if (NewCraftingUI._instance != null && (NewCraftingUI._instance._missingRequirementsTooltipText == null || hoverItem.IsAir))
      return;
    lineText[numLines] = NewCraftingUI._instance._missingRequirementsTooltipText;
    lineColors[numLines] = new Color((int) byte.MaxValue, 140, 160 /*0xA0*/, (int) byte.MaxValue);
    ++numLines;
  }

  private void DrawOwnedItemCount(
    SpriteBatch spriteBatch,
    int owned,
    bool enough,
    Vector2 mpos,
    float mscale)
  {
    mpos += new Vector2(3f, 32f) * mscale;
    string text = owned > 999 ? "999+" : owned.ToString();
    Color baseColor = enough ? new Color(144 /*0x90*/, 238, 144 /*0x90*/, (int) byte.MaxValue) : new Color((int) byte.MaxValue, 140, 160 /*0xA0*/, (int) byte.MaxValue);
    ChatManager.DrawColorCodedStringWithShadow(spriteBatch, FontAssets.ItemStack.Value, text, mpos, baseColor, 0.0f, Vector2.Zero, Vector2.One * 0.8f * mscale, spread: 1f);
  }

  private bool DrawRecipeSlot(
    SpriteBatch spriteBatch,
    Item item,
    int context,
    Vector2 pos,
    bool enabled,
    float scale)
  {
    Color inventoryBack = Main.inventoryBack;
    Main.inventoryBack = Color.White * 0.7490196f;
    double inventoryScale = (double) Main.inventoryScale;
    Main.inventoryScale *= scale;
    ItemSlot.Draw(spriteBatch, ref item, context, pos, enabled ? Color.White : NewCraftingUI.DisabledSlotColor);
    Main.inventoryScale = (float) inventoryScale;
    Main.inventoryBack = inventoryBack;
    return new Rectangle((int) pos.X, (int) pos.Y, (int) ((double) TextureAssets.InventoryBack.Width() * (double) scale), (int) ((double) TextureAssets.InventoryBack.Height() * (double) scale)).Contains(Main.MouseScreen.ToPoint());
  }

  private void ResetRecipes()
  {
    this._resetForGuideItem = Main.InGuideCraftMenu ? Main.guideItem : (Item) null;
    this._gamepadReturnToGridEntry = false;
    this._gamepadMoveToGridEntryHack = false;
    Array.Resize<NewCraftingUI.RecipeEntry>(ref this._recipeListLookup, Recipe.maxRecipes);
    if (this._recipes.Count == 0)
      return;
    this._recipes.Clear();
    this._filteredRecipes.Clear();
    Array.Clear((Array) this._recipeListLookup, 0, this._recipeListLookup.Length);
  }

  private void UpdateContents()
  {
    Recipe.UpdateRecipeList();
    if (Main.InGuideCraftMenu && Main.guideItem != this._resetForGuideItem)
      this.ResetRecipes();
    foreach (NewCraftingUI.RecipeEntry recipe in this._recipes)
      recipe.availableIndex = -1;
    int num = Main.numAvailableRecipes;
    if (Main.InGuideCraftMenu && Main.guideItem.IsAir)
      num = 0;
    bool flag = this._filteredRecipes.Count == 0;
    for (int index1 = 0; index1 < num; ++index1)
    {
      int index2 = Main.availableRecipe[index1];
      NewCraftingUI.RecipeEntry recipeEntry = this._recipeListLookup[index2];
      if (recipeEntry == null)
      {
        this._recipeListLookup[index2] = recipeEntry = new NewCraftingUI.RecipeEntry(index2);
        this._recipes.Add(recipeEntry);
        if (this.FitsFilter(recipeEntry.Recipe))
        {
          recipeEntry.gridIndex = this._filteredRecipes.Count;
          this._filteredRecipes.Add(recipeEntry);
        }
      }
      recipeEntry.availableIndex = index1;
    }
    if (this.SelectedEntry == null)
      this._selectedRecipeIndex = new int?();
    else if (this._filter != null && !this._filter.Accepts(this.SelectedEntry.Recipe))
      this._selectedRecipeIndex = new int?();
    else if (this.SelectedEntry.Available)
      Main.focusRecipe = this.SelectedEntry.availableIndex;
    if (this._itemGrid.Count == this._filteredRecipes.Count && (!flag || this._filteredRecipes.Count <= 0))
      return;
    this._itemGrid.SetContentsToShow(this._filteredRecipes);
  }

  private bool FitsFilter(Recipe recipe)
  {
    if (!this._filterer.FitsFilter(recipe.createItem))
      return false;
    return this._filter == null || this._filter.Accepts(recipe);
  }

  private void OnSearchContentsChanged(string contents)
  {
    this._filterer.SetSearchFilter(contents);
    this.ResetRecipes();
  }

  public override void Update(GameTime gameTime)
  {
    if (this._filter != null && !this._filter.CanRemainOpen())
      NewCraftingUI.Close(returnToInventory: true);
    else
      base.Update(gameTime);
  }

  private void SetupGamepadPoints(bool craftSlotVisible, int materialCount)
  {
    UILinkPage page1 = UILinkPointNavigator.Pages[24];
    int num1 = 20050;
    List<SnapPoint> snapPoints = this.GetSnapPoints();
    UILinkPage page2 = UILinkPointNavigator.Pages[0];
    UILinkPoint link1 = page2.LinkMap[300];
    UILinkPoint link2 = !craftSlotVisible ? (UILinkPoint) null : page1.LinkMap[20000];
    UILinkPoint link3 = !Main.InGuideCraftMenu ? (UILinkPoint) null : page1.LinkMap[20020];
    UILinkPoint link4 = Main.LocalPlayer.difficulty != (byte) 3 || Main.CreativeMenu.Blocked ? (UILinkPoint) null : page2.LinkMap[311];
    UILinkPoint link5 = page1.LinkMap[20030];
    UILinkPoint link6 = Main.InGuideCraftMenu ? (UILinkPoint) null : page1.LinkMap[20031];
    ref UIGamepadHelper local = ref this._helper;
    int id = num1;
    int currentID1 = id + 1;
    SnapPoint snap = snapPoints.First<SnapPoint>((Func<SnapPoint, bool>) (pt => pt.Name == "NewCraftingUISearch"));
    UILinkPoint upSide = local.MakeLinkPointFromSnapPoint(id, snap);
    if (this._gamepadMoveToSearchButtonHack)
    {
      this._gamepadMoveToSearchButtonHack = false;
      UILinkPointNavigator.ChangePoint(upSide.ID);
    }
    List<SnapPoint> pointsByCategoryName1 = this._helper.GetOrderedPointsByCategoryName(snapPoints, "NewCraftingUIFilters");
    UILinkPoint[] linkStripHorizontal = this._helper.CreateUILinkStripHorizontal(ref currentID1, pointsByCategoryName1);
    upSide.Up = linkStripHorizontal[0].ID;
    for (int index = 0; index < linkStripHorizontal.Length; ++index)
    {
      this._helper.PairUpDown(index == 10 ? link1 : page2.LinkMap[40 + (int) Math.Round((double) (index * 10) / 11.0)], linkStripHorizontal[index]);
      linkStripHorizontal[index].Down = upSide.ID;
    }
    int index1 = 0;
    if (link4 != null)
    {
      this._helper.PairUpDown(link4, linkStripHorizontal[index1]);
      this._helper.PairUpDown(page2.LinkMap[40], link4);
      ++index1;
    }
    this._helper.PairLeftRight(link4, link5);
    this._helper.PairUpDown(link5, linkStripHorizontal[index1]);
    this._helper.PairUpDown(page2.LinkMap[40 + index1], link5);
    int index2 = index1 + 1;
    this._helper.PairLeftRight(link5, link6);
    if (link6 != null)
    {
      this._helper.PairUpDown(link6, linkStripHorizontal[index2]);
      this._helper.PairUpDown(page2.LinkMap[40 + index2], link6);
    }
    this._helper.PairLeftRight(link6 ?? link5, link1);
    this._helper.PairUpDown(link2, link3);
    this._helper.PairUpDown(upSide, link2 ?? link3);
    UILinkPoint topLinkPoint = link3 ?? link2 ?? upSide;
    UILinkPoint uiLinkPoint = (UILinkPoint) null;
    List<SnapPoint> pointsByCategoryName2 = this._helper.GetOrderedPointsByCategoryName(snapPoints, "DynamicItemCollectionSlot");
    if (pointsByCategoryName2.Count > 0)
    {
      int currentID2 = 20100;
      int itemsPerLine = this._itemGrid.GetItemsPerLine();
      UILinkPoint[,] uiLinkPointGrid = this._helper.CreateUILinkPointGrid(ref currentID2, pointsByCategoryName2, itemsPerLine, topLinkPoint, (UILinkPoint) null, (UILinkPoint) null, (UILinkPoint) null);
      uiLinkPoint = uiLinkPointGrid[0, 0];
      if (this.SelectedEntry != null && this.SelectedEntry.gridIndex >= 0)
      {
        int num2 = this.SelectedEntry.gridIndex - pointsByCategoryName2[0].Id;
        if (num2 >= 0 && num2 < pointsByCategoryName2.Count)
        {
          uiLinkPoint = uiLinkPointGrid[num2 % itemsPerLine, num2 / itemsPerLine];
          if (this._gamepadMoveToGridEntryHack)
            UILinkPointNavigator.ChangePoint(uiLinkPoint.ID);
        }
      }
    }
    topLinkPoint.Down = uiLinkPoint == null ? -1 : uiLinkPoint.ID;
    this._gamepadMoveToGridEntryHack = false;
    UILinkPoint link7 = materialCount == 0 ? (UILinkPoint) null : page1.LinkMap[20001];
    UILinkPoint link8 = materialCount == 0 ? (UILinkPoint) null : page1.LinkMap[20001 + materialCount - 1];
    this._helper.PairLeftRight(link2, link7);
    for (int index3 = 0; index3 < Recipe.maxRequirements - 1; ++index3)
    {
      UILinkPoint link9 = page1.LinkMap[20001 + index3];
      this._helper.PairLeftRight(link9, page1.LinkMap[20001 + index3 + 1]);
      link9.Down = link2 == null ? -1 : link2.Down;
      link9.Up = link2 == null ? -1 : link2.Up;
    }
    if (link8 == null)
      return;
    link8.Right = -1;
  }

  private static bool IsGridPoint(int point) => point >= 20100 && point < 21000;

  private static bool IsMaterialPoint(int point) => point >= 20001 && point < 20016;

  private string GetGamepadInstructions()
  {
    if (!NewCraftingUI.Visible)
      return "";
    bool flag = true;
    int context = -1;
    switch (UILinkPointNavigator.CurrentPoint)
    {
      case 20000:
        context = 42;
        break;
      case 20020:
        context = 7;
        break;
      default:
        if (NewCraftingUI.IsMaterialPoint(UILinkPointNavigator.CurrentPoint))
        {
          context = 43;
          break;
        }
        if (this._hoveredEntry != null)
        {
          context = 41;
          break;
        }
        flag = false;
        break;
    }
    if (context != 42 && context != 43)
      this._gamepadReturnToGridEntry = false;
    string str1 = "";
    string str2;
    if (this._gamepadReturnToGridEntry)
    {
      str2 = str1 + PlayerInput.BuildCommand(Language.GetTextValue("UI.Back"), PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]);
      Main.LocalPlayer.releaseInventory = false;
      if (PlayerInput.AllowExecutionOfGamepadInstructions && PlayerInput.Triggers.JustPressed.Inventory)
        this._gamepadMoveToGridEntryHack = true;
    }
    else
      str2 = str1 + PlayerInput.BuildCommand(Lang.misc[56].Value, PlayerInput.ProfileGamepadUI.KeyStatus["Inventory"]);
    string str3 = str2 + PlayerInput.BuildCommand(Lang.misc[64 /*0x40*/].Value, PlayerInput.ProfileGamepadUI.KeyStatus["HotbarMinus"], PlayerInput.ProfileGamepadUI.KeyStatus["HotbarPlus"]);
    if (!flag || this._hoveredEntry != null)
    {
      str3 += PlayerInput.BuildCommand(Lang.misc[53].Value, PlayerInput.ProfileGamepadUI.KeyStatus["MouseLeft"]);
      if (this._hoveredEntry != null && this._hoveredEntry.Available && !Main.InGuideCraftMenu)
      {
        string gamepadInstructions = ItemSlot.GetQuickCraftGamepadInstructions(this._hoveredEntry.Recipe);
        if (gamepadInstructions != null)
        {
          if (PlayerInput.AllowExecutionOfGamepadInstructions && PlayerInput.Triggers.Current.Grapple)
            this._selectedRecipeIndex = new int?(this._hoveredEntry.index);
          str3 += gamepadInstructions;
        }
      }
    }
    else if (context == 42)
    {
      NewCraftingUI.RecipeEntry selectedEntry = this.SelectedEntry;
      if (selectedEntry != null && selectedEntry.Available)
        str3 += ItemSlot.GetCraftSlotGamepadInstructions();
    }
    return context != 7 ? (flag ? str3 + ItemSlot.GetGamepadInstructions(context) : str3 + ItemSlot.GetGamepadInstructions(43)) : str3 + ItemSlot.GetGamepadInstructions(ref Main.guideItem, context);
  }

  private void GoBackFromVirtualKeyboard()
  {
    IngameFancyUI.Close(true);
    this._gamepadMoveToSearchButtonHack = true;
  }

  public static void Close(bool quiet = false, bool returnToInventory = false)
  {
    if (!NewCraftingUI.Visible)
      return;
    NewCraftingUI._ui.SetState((UIState) null);
    Main.PipsFastScroll = true;
    if (!returnToInventory)
      Main.playerInventory = false;
    if (quiet)
      return;
    SoundEngine.PlaySound(11);
  }

  public static void Open(bool quiet = false, NewCraftingUI.RecipeFilter filter = null)
  {
    if (NewCraftingUI.Visible)
      return;
    if (!Main.playerInventory || Main.LocalPlayer.chest == -1 && !Main.InGuideCraftMenu)
      IngameUIWindows.CloseAll(true);
    Main.playerInventory = true;
    Main.PipsCurrentPage = Main.PipPage.Recipes;
    Main._preventCraftingBecauseClickWasUsedToChangeFocusedRecipe = true;
    if (NewCraftingUI._instance == null)
      NewCraftingUI._instance = new NewCraftingUI();
    NewCraftingUI._instance.SetFilter(filter);
    NewCraftingUI._ui.SetState((UIState) NewCraftingUI._instance);
    if (quiet)
      return;
    SoundEngine.PlaySound(10);
  }

  public override void OnActivate()
  {
    NewCraftingUI._instance._openedWithoutFilter = this._filter == null;
    this._selectedRecipeIndex = Main.numAvailableRecipes < 0 ? new int?() : new int?(Main.availableRecipe[Main.focusRecipe]);
    this.ResetRecipes();
    this._searchBar.SetContents("");
    this._filterer.ActiveFilters.Clear();
    UILinkPointNavigator.ChangePage(24);
  }

  public override void OnDeactivate()
  {
    this._filter = (NewCraftingUI.RecipeFilter) null;
    this._selectedRecipeIndex = new int?();
    this._hoveredEntry = (NewCraftingUI.RecipeEntry) null;
    this._missingRequirementsTooltipText = (string) null;
    UILinkPointNavigator.ChangePoint(1500);
  }

  public static void ToggleInInventory(bool quiet = false)
  {
    if (NewCraftingUI.Visible)
      NewCraftingUI.Close(quiet, true);
    else
      NewCraftingUI.Open(quiet);
  }

  public static void OpenCloseFilter(NewCraftingUI.RecipeFilter filter)
  {
    if (!NewCraftingUI.Visible)
      NewCraftingUI.Open(filter: filter);
    else if (NewCraftingUI._instance._filter == null || !NewCraftingUI._instance._filter.Matches(filter))
    {
      if (Main.InGuideCraftMenu)
      {
        Main.LocalPlayer.SetTalkNPC(-1);
        Main.InGuideCraftMenu = false;
        Main.LocalPlayer.dropItemCheck();
      }
      SoundEngine.PlaySound(12);
      NewCraftingUI._instance.SetFilter(filter);
    }
    else if (NewCraftingUI._instance._openedWithoutFilter)
    {
      SoundEngine.PlaySound(12);
      NewCraftingUI._instance.SetFilter((NewCraftingUI.RecipeFilter) null);
    }
    else
      NewCraftingUI.Close(returnToInventory: true);
  }

  private void SetFilter(NewCraftingUI.RecipeFilter filter)
  {
    this._filter = filter;
    this.ResetRecipes();
  }

  public static void UpdateUI(GameTime gameTime)
  {
    if (!NewCraftingUI.Visible || Main.inFancyUI)
      return;
    NewCraftingUI._ui.Update(gameTime);
  }

  public static void DrawUI(SpriteBatch spriteBatch)
  {
    if (!NewCraftingUI.Visible || Main.inFancyUI)
      return;
    NewCraftingUI._ui.Draw(spriteBatch, Main.gameTimeCache);
  }

  public static void RefreshGrid()
  {
    if (!NewCraftingUI.Visible)
      return;
    NewCraftingUI._instance.ResetRecipes();
  }

  private class RecipeEntry
  {
    public readonly int index;
    public int availableIndex = -1;
    public int gridIndex = -1;

    public RecipeEntry(int index) => this.index = index;

    public bool Available => this.availableIndex >= 0;

    public Recipe Recipe => Main.recipe[this.index];
  }

  private class ItemGrid : UIDynamicItemCollection<NewCraftingUI.RecipeEntry>
  {
    private readonly NewCraftingUI parent;

    public ItemGrid(NewCraftingUI parent) => this.parent = parent;

    protected override Item GetItem(NewCraftingUI.RecipeEntry entry) => entry.Recipe.createItem;

    protected override void DrawSlot(
      SpriteBatch spriteBatch,
      NewCraftingUI.RecipeEntry entry,
      Vector2 pos,
      bool hovering)
    {
      Item createItem = entry.Recipe.createItem;
      int context = 41;
      if (PlayerInput.UsingGamepad && NewCraftingUI.IsGridPoint(UILinkPointNavigator.CurrentPoint))
      {
        ItemSlot.DrawSelectionHighlightForGridSlot = false;
        UILinkPointNavigator.Shortcuts.ItemSlotShouldHighlightAsSelected = hovering;
      }
      else
      {
        int index = entry.index;
        int? selectedRecipeIndex = this.parent._selectedRecipeIndex;
        int valueOrDefault = selectedRecipeIndex.GetValueOrDefault();
        ItemSlot.DrawSelectionHighlightForGridSlot = index == valueOrDefault & selectedRecipeIndex.HasValue;
        UILinkPointNavigator.Shortcuts.ItemSlotShouldHighlightAsSelected = false;
      }
      if (hovering)
      {
        this.parent._hoveredEntry = entry;
        this.parent.HandleCraftSlot(entry, 41);
      }
      ItemSlot.Draw(spriteBatch, ref createItem, context, pos, entry.Available ? Color.White : NewCraftingUI.DisabledSlotColor);
    }
  }

  public interface RecipeFilter
  {
    string GetWindowDescription();

    bool Accepts(Recipe recipe);

    bool CanRemainOpen();

    bool Matches(NewCraftingUI.RecipeFilter other);
  }

  public abstract class TileBasedRecipeFilter : NewCraftingUI.RecipeFilter
  {
    public readonly int tileType;
    public readonly int tileStyle;

    public TileBasedRecipeFilter(int tileType, int tileStyle)
    {
      this.tileType = tileType;
      this.tileStyle = tileStyle;
    }

    public string GetWindowDescription()
    {
      return Language.GetTextValue("CombineFormat.Crafting", (object) Lang.GetMapObjectName(MapHelper.TileToLookup(this.tileType, this.tileStyle)));
    }

    public abstract bool Accepts(Recipe recipe);

    public bool CanRemainOpen() => Main.LocalPlayer.adjTile[this.tileType];

    public bool Matches(NewCraftingUI.RecipeFilter other)
    {
      return other is NewCraftingUI.TileBasedRecipeFilter && NewCraftingUI.TileBasedRecipeFilter.Matches(this, (NewCraftingUI.TileBasedRecipeFilter) other);
    }

    private static bool Matches(
      NewCraftingUI.TileBasedRecipeFilter a,
      NewCraftingUI.TileBasedRecipeFilter b)
    {
      return a.tileType == b.tileType && a.tileStyle == b.tileStyle;
    }
  }

  public class CraftStationRecipeFilter : NewCraftingUI.TileBasedRecipeFilter
  {
    private bool[] acceptTileTypes;

    public CraftStationRecipeFilter(int tileType, int tileStyle)
      : base(tileType, tileStyle)
    {
      this.acceptTileTypes = new bool[(int) TileID.Count];
      this.AcceptTileType(tileType);
    }

    private void AcceptTileType(int tileType)
    {
      this.acceptTileTypes[tileType] = true;
      List<int> tileCountsA = Recipe.TileCountsAs[tileType];
      if (tileCountsA == null)
        return;
      foreach (int tileType1 in tileCountsA)
        this.AcceptTileType(tileType1);
    }

    public override bool Accepts(Recipe recipe)
    {
      if (recipe.DoesNotNeedTileOrLiquid)
        return true;
      return recipe.requiredTile >= 0 && this.acceptTileTypes[recipe.requiredTile];
    }
  }

  public class WaterSourceRecipeFilter(int tileType, int tileStyle) : 
    NewCraftingUI.TileBasedRecipeFilter(tileType, tileStyle)
  {
    public override bool Accepts(Recipe recipe)
    {
      return recipe.DoesNotNeedTileOrLiquid || recipe.needWater;
    }
  }
}
