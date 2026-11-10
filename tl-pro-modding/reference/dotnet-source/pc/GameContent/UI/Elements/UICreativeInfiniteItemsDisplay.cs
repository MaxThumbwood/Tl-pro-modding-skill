// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UICreativeInfiniteItemsDisplay
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using System.Collections.Generic;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.Graphics.Renderers;
using Terraria.ID;
using Terraria.Localization;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UICreativeInfiniteItemsDisplay : UIElement
{
  private CreativeUnlocksTracker _lastTrackerCheckedForEdits;
  private int _lastCheckedVersionForEdits = -1;
  private UICreativeItemGrid _itemGrid;
  private EntryFilterer<Item, IItemEntryFilter> _filterer;
  private EntrySorter<Item, ICreativeItemSortStep> _sorter;
  private UIElement _containerInfinites;
  private UIElement _containerSacrifice;
  private bool _showSacrificesInsteadOfInfinites;
  public const string SnapPointName_SacrificeSlot = "CreativeSacrificeSlot";
  public const string SnapPointName_SacrificeConfirmButton = "CreativeSacrificeConfirm";
  public const string SnapPointName_InfinitesFilter = "CreativeInfinitesFilter";
  public const string SnapPointName_InfinitesSearch = "CreativeInfinitesSearch";
  private List<UIImage> _sacrificeCogsSmall = new List<UIImage>();
  private List<UIImage> _sacrificeCogsMedium = new List<UIImage>();
  private List<UIImage> _sacrificeCogsBig = new List<UIImage>();
  private UIImageFramed _sacrificePistons;
  private UIParticleLayer _pistonParticleSystem;
  private Asset<Texture2D> _pistonParticleAsset;
  private int _sacrificeAnimationTimeLeft;
  private bool _researchComplete;
  private bool _hovered;
  private int _lastItemIdSacrificed;
  private int _lastItemAmountWeHad;
  private int _lastItemAmountWeNeededTotal;
  private List<Item> _itemList = new List<Item>();

  public UICreativeInfiniteItemsDisplay()
  {
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
    this._sorter = new EntrySorter<Item, ICreativeItemSortStep>();
    this._sorter.AddSortSteps(new List<ICreativeItemSortStep>()
    {
      (ICreativeItemSortStep) new SortingSteps.ByUnlockStatus(),
      (ICreativeItemSortStep) new SortingSteps.ByCreativeSortingId(),
      (ICreativeItemSortStep) new SortingSteps.Alphabetical()
    });
    this.BuildPage();
  }

  private void BuildPage()
  {
    this._lastCheckedVersionForEdits = -1;
    this.RemoveAllChildren();
    this.SetPadding(0.0f);
    UIElement totalContainer1 = new UIElement()
    {
      Width = StyleDimension.Fill,
      Height = StyleDimension.Fill
    };
    totalContainer1.SetPadding(0.0f);
    this._containerInfinites = totalContainer1;
    UIElement totalContainer2 = new UIElement()
    {
      Width = StyleDimension.Fill,
      Height = StyleDimension.Fill
    };
    totalContainer2.SetPadding(0.0f);
    this._containerSacrifice = totalContainer2;
    this.BuildInfinitesMenuContents(totalContainer1);
    this.BuildSacrificeMenuContents(totalContainer2);
    this.UpdateContents();
    this.OnUpdate += new UIElement.ElementEvent(this.UICreativeInfiniteItemsDisplay_OnUpdate);
  }

  private void Hover_OnUpdate(UIElement affectedElement)
  {
    if (!this._hovered)
      return;
    Main.LocalPlayer.mouseInterface = true;
  }

  private void Hover_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
  {
    this._hovered = false;
  }

  private void Hover_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
  {
    this._hovered = true;
  }

  private static UIPanel CreateBasicPanel()
  {
    UIPanel element = new UIPanel();
    UICreativeInfiniteItemsDisplay.SetBasicSizesForCreativeSacrificeOrInfinitesPanel((UIElement) element);
    element.BackgroundColor *= 0.8f;
    element.BorderColor *= 0.8f;
    return element;
  }

  private static void SetBasicSizesForCreativeSacrificeOrInfinitesPanel(UIElement element)
  {
    element.Width = new StyleDimension(0.0f, 1f);
    element.Height = new StyleDimension(-38f, 1f);
    element.Top = new StyleDimension(38f, 0.0f);
  }

  private void BuildInfinitesMenuContents(UIElement totalContainer)
  {
    UIPanel basicPanel = UICreativeInfiniteItemsDisplay.CreateBasicPanel();
    totalContainer.Append((UIElement) basicPanel);
    basicPanel.OnUpdate += new UIElement.ElementEvent(this.Hover_OnUpdate);
    basicPanel.OnMouseOver += new UIElement.MouseEvent(this.Hover_OnMouseOver);
    basicPanel.OnMouseOut += new UIElement.MouseEvent(this.Hover_OnMouseOut);
    this._itemGrid = new UICreativeItemGrid();
    UIWrappedSearchBar element1 = new UIWrappedSearchBar(new Action(this.GoBackFromVirtualKeyboard));
    element1.CustomOpenVirtualKeyboard = new Action<UIState>(IngameFancyUI.OpenUIState);
    element1.OnSearchContentsChanged += new Action<string>(this.OnSearchContentsChanged);
    element1.SetSearchSnapPoint("CreativeInfinitesSearch", 0);
    basicPanel.Append((UIElement) element1);
    UIList uiList = new UIList();
    uiList.Width = new StyleDimension(-25f, 1f);
    uiList.Height = new StyleDimension(-28f, 1f);
    uiList.VAlign = 1f;
    uiList.HAlign = 0.0f;
    UIList element2 = uiList;
    basicPanel.Append((UIElement) element2);
    float num = 4f;
    UIScrollbar uiScrollbar1 = new UIScrollbar();
    uiScrollbar1.Height = new StyleDimension((float) (-28.0 - (double) num * 2.0), 1f);
    uiScrollbar1.Top = new StyleDimension(-num, 0.0f);
    uiScrollbar1.VAlign = 1f;
    uiScrollbar1.HAlign = 1f;
    UIScrollbar uiScrollbar2 = uiScrollbar1;
    basicPanel.Append((UIElement) uiScrollbar2);
    element2.SetScrollbar(uiScrollbar2);
    element2.Add((UIElement) this._itemGrid);
    UICreativeItemsInfiniteFilteringOptions element3 = new UICreativeItemsInfiniteFilteringOptions(this._filterer, "CreativeInfinitesFilter");
    element3.OnClickingOption += new Action(this.filtersHelper_OnClickingOption);
    element3.Left = new StyleDimension(20f, 0.0f);
    totalContainer.Append((UIElement) element3);
    element3.OnUpdate += new UIElement.ElementEvent(this.Hover_OnUpdate);
    element3.OnMouseOver += new UIElement.MouseEvent(this.Hover_OnMouseOver);
    element3.OnMouseOut += new UIElement.MouseEvent(this.Hover_OnMouseOut);
  }

  private void BuildSacrificeMenuContents(UIElement totalContainer)
  {
    UIPanel basicPanel = UICreativeInfiniteItemsDisplay.CreateBasicPanel();
    basicPanel.VAlign = 0.5f;
    basicPanel.Height = new StyleDimension(170f, 0.0f);
    basicPanel.Width = new StyleDimension(170f, 0.0f);
    basicPanel.Top = new StyleDimension();
    totalContainer.Append((UIElement) basicPanel);
    basicPanel.OnUpdate += new UIElement.ElementEvent(this.Hover_OnUpdate);
    basicPanel.OnMouseOver += new UIElement.MouseEvent(this.Hover_OnMouseOver);
    basicPanel.OnMouseOut += new UIElement.MouseEvent(this.Hover_OnMouseOut);
    this.AddCogsForSacrificeMenu((UIElement) basicPanel);
    this._pistonParticleAsset = Main.Assets.Request<Texture2D>("Images/UI/Creative/Research_Spark", (AssetRequestMode) 1);
    float pixels = 0.0f;
    UIImage uiImage = new UIImage(Main.Assets.Request<Texture2D>("Images/UI/Creative/Research_Slots", (AssetRequestMode) 1));
    uiImage.HAlign = 0.5f;
    uiImage.VAlign = 0.5f;
    uiImage.Top = new StyleDimension(-20f, 0.0f);
    uiImage.Left = new StyleDimension(pixels, 0.0f);
    UIImage element1 = uiImage;
    basicPanel.Append((UIElement) element1);
    Asset<Texture2D> asset = Main.Assets.Request<Texture2D>("Images/UI/Creative/Research_FramedPistons", (AssetRequestMode) 1);
    UIImageFramed uiImageFramed = new UIImageFramed(asset, asset.Frame(verticalFrames: 9));
    uiImageFramed.HAlign = 0.5f;
    uiImageFramed.VAlign = 0.5f;
    uiImageFramed.Top = new StyleDimension(-20f, 0.0f);
    uiImageFramed.Left = new StyleDimension(pixels, 0.0f);
    uiImageFramed.IgnoresMouseInteraction = true;
    UIImageFramed element2 = uiImageFramed;
    basicPanel.Append((UIElement) element2);
    this._sacrificePistons = element2;
    UIParticleLayer uiParticleLayer = new UIParticleLayer();
    uiParticleLayer.Width = new StyleDimension(0.0f, 1f);
    uiParticleLayer.Height = new StyleDimension(0.0f, 1f);
    uiParticleLayer.AnchorPositionOffsetByPercents = Vector2.One / 2f;
    uiParticleLayer.AnchorPositionOffsetByPixels = Vector2.Zero;
    this._pistonParticleSystem = uiParticleLayer;
    element2.Append((UIElement) this._pistonParticleSystem);
    UIElement element3 = Main.CreativeMenu.ProvideItemSlotElement(0);
    element3.HAlign = 0.5f;
    element3.VAlign = 0.5f;
    element3.Top = new StyleDimension(-15f, 0.0f);
    element3.Left = new StyleDimension(pixels, 0.0f);
    element3.SetSnapPoint("CreativeSacrificeSlot", 0);
    element1.Append(element3);
    UIText uiText1 = new UIText("(0/50)", 0.8f);
    uiText1.Top = new StyleDimension(10f, 0.0f);
    uiText1.Left = new StyleDimension(pixels, 0.0f);
    uiText1.HAlign = 0.5f;
    uiText1.VAlign = 0.5f;
    uiText1.IgnoresMouseInteraction = true;
    UIText element4 = uiText1;
    element4.OnUpdate += new UIElement.ElementEvent(this.descriptionText_OnUpdate);
    basicPanel.Append((UIElement) element4);
    UIPanel uiPanel = new UIPanel();
    uiPanel.Top = new StyleDimension(0.0f, 0.0f);
    uiPanel.Left = new StyleDimension(pixels, 0.0f);
    uiPanel.HAlign = 0.5f;
    uiPanel.VAlign = 1f;
    uiPanel.Width = new StyleDimension(124f, 0.0f);
    uiPanel.Height = new StyleDimension(30f, 0.0f);
    UIPanel element5 = uiPanel;
    UIText uiText2 = new UIText(Language.GetText("CreativePowers.ConfirmInfiniteItemSacrifice"), 0.8f);
    uiText2.IgnoresMouseInteraction = true;
    uiText2.HAlign = 0.5f;
    uiText2.VAlign = 0.5f;
    UIText element6 = uiText2;
    element5.Append((UIElement) element6);
    element5.SetSnapPoint("CreativeSacrificeConfirm", 0);
    element5.OnLeftClick += new UIElement.MouseEvent(this.sacrificeButton_OnClick);
    element5.OnMouseOver += new UIElement.MouseEvent(this.FadedMouseOver);
    element5.OnMouseOut += new UIElement.MouseEvent(this.FadedMouseOut);
    element5.OnUpdate += new UIElement.ElementEvent(this.research_OnUpdate);
    basicPanel.Append((UIElement) element5);
    basicPanel.OnUpdate += new UIElement.ElementEvent(this.sacrificeWindow_OnUpdate);
  }

  private void research_OnUpdate(UIElement affectedElement)
  {
    if (!affectedElement.IsMouseHovering)
      return;
    Main.instance.MouseTextNoOverride(Language.GetTextValue("CreativePowers.ResearchButtonTooltip"));
  }

  private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    ((UIPanel) evt.Target).BorderColor = Colors.FancyUIFatButtonMouseOver;
  }

  private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
  {
    ((UIPanel) evt.Target).BorderColor = Color.Black;
  }

  private void AddCogsForSacrificeMenu(UIElement sacrificesContainer)
  {
    UIElement uiElement = new UIElement();
    uiElement.IgnoresMouseInteraction = true;
    UICreativeInfiniteItemsDisplay.SetBasicSizesForCreativeSacrificeOrInfinitesPanel(uiElement);
    uiElement.VAlign = 0.5f;
    uiElement.Height = new StyleDimension(170f, 0.0f);
    uiElement.Width = new StyleDimension(280f, 0.0f);
    uiElement.Top = new StyleDimension();
    uiElement.SetPadding(0.0f);
    sacrificesContainer.Append(uiElement);
    Vector2 vector2 = new Vector2(-10f, -10f);
    this.AddSymetricalCogsPair(uiElement, new Vector2(22f, 1f) + vector2, "Images/UI/Creative/Research_GearC", this._sacrificeCogsSmall);
    this.AddSymetricalCogsPair(uiElement, new Vector2(1f, 28f) + vector2, "Images/UI/Creative/Research_GearB", this._sacrificeCogsMedium);
    this.AddSymetricalCogsPair(uiElement, new Vector2(5f, 5f) + vector2, "Images/UI/Creative/Research_GearA", this._sacrificeCogsBig);
  }

  private void sacrificeWindow_OnUpdate(UIElement affectedElement) => this.UpdateVisualFrame();

  private void UpdateVisualFrame()
  {
    float num1 = 0.05f;
    float animationProgress = this.GetSacrificeAnimationProgress();
    double lerpValue = (double) Utils.GetLerpValue(1f, 0.7f, animationProgress, true);
    float num2 = 1f + (float) (lerpValue * lerpValue) * 2f;
    float num3 = num1 * num2;
    float num4 = 1.14285719f;
    float num5 = 1f;
    UICreativeInfiniteItemsDisplay.OffsetRotationsForCogs((float) (2.0 * (double) num3), this._sacrificeCogsSmall);
    UICreativeInfiniteItemsDisplay.OffsetRotationsForCogs(num4 * num3, this._sacrificeCogsMedium);
    UICreativeInfiniteItemsDisplay.OffsetRotationsForCogs(-num5 * num3, this._sacrificeCogsBig);
    int frameY = 0;
    if (this._sacrificeAnimationTimeLeft != 0)
    {
      float num6 = 0.1f;
      float num7 = 0.06666667f;
      frameY = (double) animationProgress < 1.0 - (double) num6 ? ((double) animationProgress < 1.0 - (double) num6 * 2.0 ? ((double) animationProgress < 1.0 - (double) num6 * 3.0 ? ((double) animationProgress < (double) num7 * 4.0 ? ((double) animationProgress < (double) num7 * 3.0 ? ((double) animationProgress < (double) num7 * 2.0 ? ((double) animationProgress < (double) num7 ? 1 : 2) : 3) : 4) : 5) : 6) : 7) : 8;
      if (this._sacrificeAnimationTimeLeft == 56)
      {
        SoundEngine.PlaySound(63 /*0x3F*/);
        Vector2 vector2 = new Vector2(0.0f, 0.163500011f);
        for (int index = 0; index < 15; ++index)
        {
          Vector2 initialVelocity = Main.rand.NextVector2Circular(4f, 3f);
          if ((double) initialVelocity.Y > 0.0)
            initialVelocity.Y = -initialVelocity.Y;
          initialVelocity.Y -= 2f;
          this._pistonParticleSystem.AddParticle((IParticle) new CreativeSacrificeParticle(this._pistonParticleAsset, new Rectangle?(), initialVelocity, Vector2.Zero)
          {
            AccelerationPerFrame = vector2,
            ScaleOffsetPerFrame = -0.0166666675f
          });
        }
      }
      if (this._sacrificeAnimationTimeLeft == 40 && this._researchComplete)
      {
        this._researchComplete = false;
        SoundEngine.PlaySound(64 /*0x40*/);
      }
    }
    this._sacrificePistons.SetFrame(1, 9, 0, frameY, 0, 0);
  }

  private static void OffsetRotationsForCogs(float rotationOffset, List<UIImage> cogsList)
  {
    cogsList[0].Rotation += rotationOffset;
    cogsList[1].Rotation -= rotationOffset;
  }

  private void AddSymetricalCogsPair(
    UIElement sacrificesContainer,
    Vector2 cogOFfsetsInPixels,
    string assetPath,
    List<UIImage> imagesList)
  {
    Asset<Texture2D> asset = Main.Assets.Request<Texture2D>(assetPath, (AssetRequestMode) 1);
    cogOFfsetsInPixels += -asset.Size() / 2f;
    UIImage uiImage1 = new UIImage(asset);
    uiImage1.NormalizedOrigin = Vector2.One / 2f;
    uiImage1.Left = new StyleDimension(cogOFfsetsInPixels.X, 0.0f);
    uiImage1.Top = new StyleDimension(cogOFfsetsInPixels.Y, 0.0f);
    UIImage element1 = uiImage1;
    imagesList.Add(element1);
    sacrificesContainer.Append((UIElement) element1);
    UIImage uiImage2 = new UIImage(asset);
    uiImage2.NormalizedOrigin = Vector2.One / 2f;
    uiImage2.HAlign = 1f;
    uiImage2.Left = new StyleDimension(-cogOFfsetsInPixels.X, 0.0f);
    uiImage2.Top = new StyleDimension(cogOFfsetsInPixels.Y, 0.0f);
    UIImage element2 = uiImage2;
    imagesList.Add(element2);
    sacrificesContainer.Append((UIElement) element2);
  }

  private void descriptionText_OnUpdate(UIElement affectedElement)
  {
    UIText uiText = affectedElement as UIText;
    int itemIdChecked;
    int amountWeHave;
    int amountNeededTotal;
    bool sacrificeNumbers = Main.CreativeMenu.GetSacrificeNumbers(out itemIdChecked, out amountWeHave, out amountNeededTotal);
    Main.CreativeMenu.ShouldDrawSacrificeArea();
    if (!Main.mouseItem.IsAir)
      this.ForgetItemSacrifice();
    if (itemIdChecked == 0)
    {
      if (this._lastItemIdSacrificed != 0 && this._lastItemAmountWeNeededTotal != this._lastItemAmountWeHad)
        uiText.SetText($"({this._lastItemAmountWeHad}/{this._lastItemAmountWeNeededTotal})");
      else
        uiText.SetText("???");
    }
    else
    {
      this.ForgetItemSacrifice();
      if (!sacrificeNumbers)
        uiText.SetText("X");
      else
        uiText.SetText($"({amountWeHave}/{amountNeededTotal})");
    }
  }

  private void sacrificeButton_OnClick(UIMouseEvent evt, UIElement listeningElement)
  {
    this.SacrificeWhatYouCan();
  }

  public void SacrificeWhatYouCan()
  {
    int itemIdChecked;
    int amountWeHave;
    int amountNeededTotal;
    Main.CreativeMenu.GetSacrificeNumbers(out itemIdChecked, out amountWeHave, out amountNeededTotal);
    int amountWeSacrificed;
    switch (Main.CreativeMenu.SacrificeItem(out amountWeSacrificed))
    {
      case CreativeUI.ItemSacrificeResult.SacrificedButNotDone:
        this._researchComplete = false;
        this.BeginSacrificeAnimation();
        this.RememberItemSacrifice(itemIdChecked, amountWeHave + amountWeSacrificed, amountNeededTotal);
        break;
      case CreativeUI.ItemSacrificeResult.SacrificedAndDone:
        this._researchComplete = true;
        this.BeginSacrificeAnimation();
        this.RememberItemSacrifice(itemIdChecked, amountWeHave + amountWeSacrificed, amountNeededTotal);
        break;
    }
  }

  public void StopPlayingAnimation()
  {
    this.ForgetItemSacrifice();
    this._sacrificeAnimationTimeLeft = 0;
    this._pistonParticleSystem.ClearParticles();
    this.UpdateVisualFrame();
  }

  private void RememberItemSacrifice(int itemId, int amountWeHave, int amountWeNeedTotal)
  {
    this._lastItemIdSacrificed = itemId;
    this._lastItemAmountWeHad = amountWeHave;
    this._lastItemAmountWeNeededTotal = amountWeNeedTotal;
  }

  private void ForgetItemSacrifice()
  {
    this._lastItemIdSacrificed = 0;
    this._lastItemAmountWeHad = 0;
    this._lastItemAmountWeNeededTotal = 0;
  }

  private void BeginSacrificeAnimation() => this._sacrificeAnimationTimeLeft = 60;

  private void UpdateSacrificeAnimation()
  {
    if (this._sacrificeAnimationTimeLeft <= 0)
      return;
    --this._sacrificeAnimationTimeLeft;
  }

  private float GetSacrificeAnimationProgress()
  {
    return Utils.GetLerpValue(60f, 0.0f, (float) this._sacrificeAnimationTimeLeft, true);
  }

  public void SetPageTypeToShow(
    UICreativeInfiniteItemsDisplay.InfiniteItemsDisplayPage page)
  {
    this._showSacrificesInsteadOfInfinites = page == UICreativeInfiniteItemsDisplay.InfiniteItemsDisplayPage.InfiniteItemsResearch;
  }

  private void UICreativeInfiniteItemsDisplay_OnUpdate(UIElement affectedElement)
  {
    this.RemoveAllChildren();
    CreativeUnlocksTracker playerCreativeTracker = Main.LocalPlayerCreativeTracker;
    if (this._lastTrackerCheckedForEdits != playerCreativeTracker)
    {
      this._lastTrackerCheckedForEdits = playerCreativeTracker;
      this._lastCheckedVersionForEdits = -1;
    }
    int lastEditId = playerCreativeTracker.ItemSacrifices.LastEditId;
    if (this._lastCheckedVersionForEdits != lastEditId)
    {
      this._lastCheckedVersionForEdits = lastEditId;
      this.UpdateContents();
    }
    if (this._showSacrificesInsteadOfInfinites)
      this.Append(this._containerSacrifice);
    else
      this.Append(this._containerInfinites);
    this.UpdateSacrificeAnimation();
  }

  private void filtersHelper_OnClickingOption() => this.UpdateContents();

  private void UpdateContents()
  {
    this._itemList.Clear();
    Main.LocalPlayerCreativeTracker.ItemSacrifices.ForEachItemWithResearchProgress((Action<int>) (type =>
    {
      Item entry = ContentSamples.ItemsByType[type];
      if (!this._filterer.FitsFilter(entry))
        return;
      this._itemList.Add(entry);
    }));
    this._itemList.Sort((IComparer<Item>) this._sorter);
    this._itemGrid.SetContentsToShow(this._itemList);
  }

  private void OnSearchContentsChanged(string contents)
  {
    this._filterer.SetSearchFilter(contents);
    this.UpdateContents();
  }

  private static UserInterface GetCurrentInterface()
  {
    UserInterface activeInstance = UserInterface.ActiveInstance;
    return !Main.gameMenu ? Main.InGameUI : Main.MenuUI;
  }

  private void GoBackFromVirtualKeyboard()
  {
    IngameFancyUI.Close(true);
    Main.playerInventory = true;
    Main.CreativeMenu.ResumeMenuFromGamepadSearch();
  }

  public int GetItemsPerLine() => this._itemGrid.GetItemsPerLine();

  public enum InfiniteItemsDisplayPage
  {
    InfiniteItemsPickup,
    InfiniteItemsResearch,
  }
}
