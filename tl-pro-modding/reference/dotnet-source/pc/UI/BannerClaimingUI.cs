// Decompiled with JetBrains decompiler
// Type: Terraria.UI.BannerClaimingUI
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ReLogic.Graphics;
using System;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.Localization;
using Terraria.UI.Gamepad;

#nullable disable
namespace Terraria.UI;

public class BannerClaimingUI : IPipsUI
{
  private int _focusedElementIndex;
  private int _gridSelectionCandidateIndex;
  private float _currentElementOffset;
  private int _availableItemsCount;
  private int _gridStartingElementIndex;
  private int _bannerStackRequestLimiter;
  private BannerClaimingUI.Entry[] _squashedItemTypesToShow = new BannerClaimingUI.Entry[400];

  public bool AnyAvailableBanners { get; private set; }

  private float inventoryScale
  {
    get => Main.inventoryScale;
    set => Main.inventoryScale = value;
  }

  private Color inventoryBack
  {
    get => Main.inventoryBack;
    set => Main.inventoryBack = value;
  }

  public int FocusedItemType
  {
    get
    {
      return this._focusedElementIndex >= 0 && this._focusedElementIndex < this._availableItemsCount ? this._squashedItemTypesToShow[this._focusedElementIndex].Type : 0;
    }
  }

  public void DrawBannersList(
    SpriteBatch spriteBatch,
    int adjY,
    int middleY,
    Color craftingTipColor)
  {
    UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeBig = -1;
    UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeSmall = -1;
    int claimableItemsCount = this.UpdateAndGetClaimableItemsCount();
    BannerSystem.AnyNewClaimableBanners = false;
    if (claimableItemsCount <= 0)
    {
      Main.TryChangePipsPage(Main.PipPage.Recipes);
    }
    else
    {
      DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, Language.GetTextValue("GameUI.BannersTitle"), new Vector2(76f, (float) (414 + adjY)), craftingTipColor, 0.0f, new Vector2(), 1f, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
      this.DrawBannersList_Move(claimableItemsCount);
      if (Main.PipsFastScroll)
      {
        this._currentElementOffset = (float) this._focusedElementIndex;
        Main.PipsFastScroll = false;
      }
      bool flag = Main.mouseLeft || Main.mouseRight;
      if (!flag)
        this._bannerStackRequestLimiter = 0;
      for (int recipeIndex = 0; recipeIndex < claimableItemsCount; ++recipeIndex)
      {
        float offset = (float) (((double) recipeIndex - (double) this._currentElementOffset) * 65.0);
        if ((double) Math.Abs(offset) <= (double) middleY)
        {
          BannerClaimingUI.Entry bannerEntry = this._squashedItemTypesToShow[recipeIndex];
          Item inv;
          if (ContentSamples.ItemsByType.TryGetValue(bannerEntry.Type, out inv))
          {
            this.inventoryScale = (float) (100.0 / ((double) Math.Abs(offset) + 100.0));
            if ((double) this.inventoryScale < 0.75)
              this.inventoryScale = 0.75f;
            double inventoryAlpha;
            Color inventoryColor2;
            this.GetItemSlotColors(offset, middleY, 100f, recipeIndex, out inventoryAlpha, out inventoryColor2);
            int x = (int) (46.0 - 26.0 * (double) this.inventoryScale);
            int y = (int) (410.0 + (double) offset * (double) this.inventoryScale - 30.0 * (double) this.inventoryScale + (double) adjY);
            if (!Main.LocalPlayer.creativeInterface && Main.mouseX >= x && (double) Main.mouseX <= (double) x + (double) TextureAssets.InventoryBack.Width() * (double) this.inventoryScale && Main.mouseY >= y && (double) Main.mouseY <= (double) y + (double) TextureAssets.InventoryBack.Height() * (double) this.inventoryScale && !PlayerInput.IgnoreMouseInterface)
            {
              Main.craftingHide = true;
              Main.LocalPlayer.mouseInterface = true;
              if (flag)
              {
                if (this._focusedElementIndex != recipeIndex)
                {
                  if (Main.mouseLeft && Main.mouseLeftRelease || Main.mouseRight && Main.mouseRightRelease)
                  {
                    this._focusedElementIndex = recipeIndex;
                    this._bannerStackRequestLimiter = -1;
                  }
                }
                else if ((double) offset == 0.0)
                  this.TryClaimingBanner(bannerEntry);
              }
              ItemSlot.MouseHover(inv, 35);
            }
            inventoryAlpha -= 50.0;
            if (inventoryAlpha < 0.0)
              inventoryAlpha = 0.0;
            if (recipeIndex == this._focusedElementIndex)
            {
              UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeSmall = 0;
              if (PlayerInput.SettingsForUI.HighlightThingsForMouse)
                ItemSlot.DrawGoldBGForCraftingMaterial = true;
            }
            else
              UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeSmall = -1;
            Color inventoryBack = this.inventoryBack;
            this.inventoryBack = new Color((int) (byte) inventoryAlpha, (int) (byte) inventoryAlpha, (int) (byte) inventoryAlpha, (int) (byte) inventoryAlpha);
            int stack = inv.stack;
            inv.stack = bannerEntry.Stack;
            ItemSlot.Draw(spriteBatch, ref inv, 35, new Vector2((float) x, (float) y), inventoryColor2);
            inv.stack = stack;
            this.inventoryBack = inventoryBack;
          }
        }
      }
    }
  }

  private void DrawBannersList_Move(int claimableItemsCount)
  {
    this._focusedElementIndex = Utils.Clamp<int>(this._focusedElementIndex, 0, claimableItemsCount - 1);
    this._currentElementOffset = Utils.Clamp<float>(this._currentElementOffset, 0.0f, (float) (claimableItemsCount - 1));
    int currentElementOffset1 = (int) this._currentElementOffset;
    this._currentElementOffset = MathHelper.Lerp(this._currentElementOffset, (float) this._focusedElementIndex, 0.03f);
    this._currentElementOffset = Utils.MoveTowards(this._currentElementOffset, (float) this._focusedElementIndex, 0.1f);
    int currentElementOffset2 = (int) this._currentElementOffset;
    if (currentElementOffset1 == currentElementOffset2)
      return;
    SoundEngine.PlaySound(12);
  }

  private void TryClaimingBanner(BannerClaimingUI.Entry bannerEntry)
  {
    ItemSlot.HandleItemPickupAction<BannerClaimingUI.Entry>(new ItemSlot.ItemPickupAction<BannerClaimingUI.Entry>(this.SendRequestForBanner), bannerEntry, bannerEntry.Type, bannerEntry.Stack, ref this._bannerStackRequestLimiter);
  }

  private void SendRequestForBanner(BannerClaimingUI.Entry bannerEntry, int itemAmount)
  {
    BannerSystem.RequestBannerClaim(bannerEntry.Index, itemAmount);
    SoundEngine.PlaySound(7);
  }

  private int UpdateAndGetClaimableItemsCount()
  {
    ushort[] claimableBannerCounts = BannerSystem.GetClaimableBannerCounts();
    BannerClaimingUI.Entry[] squashedItemTypesToShow = this._squashedItemTypesToShow;
    int claimableItemsCount = 0;
    Array.Clear((Array) squashedItemTypesToShow, 0, squashedItemTypesToShow.Length);
    for (int banner = 1; banner < claimableBannerCounts.Length; ++banner)
    {
      ushort num = claimableBannerCounts[banner];
      if (num > (ushort) 0)
        squashedItemTypesToShow[claimableItemsCount++] = new BannerClaimingUI.Entry()
        {
          Index = banner,
          Type = BannerSystem.BannerToItem(banner),
          Stack = (int) num
        };
    }
    this.AnyAvailableBanners = claimableItemsCount > 0;
    this._availableItemsCount = claimableItemsCount;
    if (!this.AnyAvailableBanners)
      BannerSystem.AnyNewClaimableBanners = false;
    return claimableItemsCount;
  }

  private void GetItemSlotColors(
    float offset,
    int middleY,
    float fadeInValue,
    int recipeIndex,
    out double inventoryAlpha,
    out Color inventoryColor2)
  {
    inventoryAlpha = (double) ((int) this.inventoryBack.A + 50);
    double num = (double) byte.MaxValue;
    if ((double) Math.Abs(offset) > (double) middleY - (double) fadeInValue)
    {
      inventoryAlpha = 150.0 * ((double) fadeInValue - ((double) Math.Abs(offset) - ((double) middleY - (double) fadeInValue))) * 0.01;
      num = (double) byte.MaxValue * ((double) fadeInValue - ((double) Math.Abs(offset) - ((double) middleY - (double) fadeInValue))) * 0.01;
    }
    Color color = new Color((int) (byte) inventoryAlpha, (int) (byte) inventoryAlpha, (int) (byte) inventoryAlpha, (int) (byte) inventoryAlpha);
    inventoryColor2 = new Color((int) (byte) num, (int) (byte) num, (int) (byte) num, (int) (byte) num);
  }

  public void DrawGridToggle(SpriteBatch spriteBatch, int adjY)
  {
    if (this.UpdateAndGetClaimableItemsCount() == 0)
    {
      if (Main.PipsCurrentPage != Main.PipPage.Banners)
        return;
      Main.PipsUseGrid = false;
    }
    else
    {
      int num1 = 128 /*0x80*/;
      int num2 = 450 + adjY;
      if (Main.InGuideCraftMenu)
        num2 -= 150;
      UILinkPointNavigator.SetPosition(11002, new Vector2((float) num1, (float) num2));
      bool state = Main.mouseX > num1 - 15 && Main.mouseX < num1 + 15 && Main.mouseY > num2 - 15 && Main.mouseY < num2 + 15 && !PlayerInput.IgnoreMouseInterface;
      if (Main.PipsCurrentPage == Main.PipPage.Banners)
        Utils.DrawSelectedCraftingBarIndicator(spriteBatch, num1, num2);
      int index = 2 - (Main.PipsCurrentPage == Main.PipPage.Banners && Main.PipsUseGrid).ToInt() * 2 + state.ToInt();
      Asset<Texture2D> tex = TextureAssets.BannerToggle[index];
      spriteBatch.Draw(tex.Value, new Vector2((float) num1, (float) num2), new Rectangle?(), Color.White, 0.0f, tex.Size() / 2f, 1f, SpriteEffects.None, 0.0f);
      if (state)
      {
        Main.instance.MouseTextNoOverride(Language.GetTextValue("GameUI.BannersWindow"));
        Main.player[Main.myPlayer].mouseInterface = true;
        if (Main.mouseLeft && Main.mouseLeftRelease)
        {
          if (!Main.TryChangePipsPage(Main.PipPage.Banners))
            Main.PipsUseGrid = !Main.PipsUseGrid;
          SoundEngine.PlaySound(12);
        }
      }
      Main.DoStatefulTickSound(ref Main.GridToggleMouseOverBanners, state);
      if (!BannerSystem.AnyNewClaimableBanners)
        return;
      Utils.DrawNotificationIcon(spriteBatch, new Vector2((float) num1, (float) (num2 - 7)));
    }
  }

  public void DrawBannersGrid(SpriteBatch spriteBatch)
  {
    int claimableItemsCount = this.UpdateAndGetClaimableItemsCount();
    BannerSystem.AnyNewClaimableBanners = false;
    UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeBig = -1;
    UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeSmall = -1;
    int num1 = 42;
    this.inventoryScale = 0.75f;
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
    int mouseX = Main.mouseX;
    int mouseY = Main.mouseY;
    int x1 = num3 - 20;
    int y1 = num2 + 2;
    if (this._gridStartingElementIndex > claimableItemsCount - num4 * num5)
    {
      this._gridStartingElementIndex = claimableItemsCount - num4 * num5;
      if (this._gridStartingElementIndex < 0)
        this._gridStartingElementIndex = 0;
    }
    if (this._gridStartingElementIndex > 0)
    {
      if (mouseX >= x1 && mouseX <= x1 + TextureAssets.CraftUpButton.Width() && mouseY >= y1 && mouseY <= y1 + TextureAssets.CraftUpButton.Height() && !PlayerInput.IgnoreMouseInterface)
      {
        Main.LocalPlayer.mouseInterface = true;
        if (Main.mouseLeftRelease && Main.mouseLeft)
        {
          this._gridStartingElementIndex -= num4;
          if (this._gridStartingElementIndex < 0)
            this._gridStartingElementIndex = 0;
          SoundEngine.PlaySound(12);
          Main.mouseLeftRelease = false;
        }
      }
      spriteBatch.Draw(TextureAssets.CraftUpButton.Value, new Vector2((float) x1, (float) y1), new Rectangle?(), new Color(200, 200, 200, 200), 0.0f, new Vector2(), 1f, SpriteEffects.None, 0.0f);
    }
    if (this._gridStartingElementIndex < claimableItemsCount - num4 * num5)
    {
      int y2 = y1 + 20;
      if (mouseX >= x1 && mouseX <= x1 + TextureAssets.CraftUpButton.Width() && mouseY >= y2 && mouseY <= y2 + TextureAssets.CraftUpButton.Height() && !PlayerInput.IgnoreMouseInterface)
      {
        Main.LocalPlayer.mouseInterface = true;
        if (Main.mouseLeftRelease && Main.mouseLeft)
        {
          this._gridStartingElementIndex += num4;
          SoundEngine.PlaySound(12);
          if (this._gridStartingElementIndex > claimableItemsCount - num4)
            this._gridStartingElementIndex = claimableItemsCount - num4;
          Main.mouseLeftRelease = false;
        }
      }
      spriteBatch.Draw(TextureAssets.CraftDownButton.Value, new Vector2((float) x1, (float) y2), new Rectangle?(), new Color(200, 200, 200, 200), 0.0f, new Vector2(), 1f, SpriteEffects.None, 0.0f);
    }
    this._gridStartingElementIndex = Utils.Clamp<int>(this._gridStartingElementIndex, 0, claimableItemsCount - 1);
    this._gridSelectionCandidateIndex = Utils.Clamp<int>(this._gridSelectionCandidateIndex, 0, claimableItemsCount - 1);
    for (int startingElementIndex = this._gridStartingElementIndex; startingElementIndex < claimableItemsCount && startingElementIndex < claimableItemsCount; ++startingElementIndex)
    {
      int x2 = num8;
      int y3 = num9;
      double num10 = (double) ((int) this.inventoryBack.A + 50);
      double maxValue = (double) byte.MaxValue;
      BannerClaimingUI.Entry entry = this._squashedItemTypesToShow[startingElementIndex];
      Item inv;
      if (ContentSamples.ItemsByType.TryGetValue(entry.Type, out inv))
      {
        Color color1 = new Color((int) (byte) num10, (int) (byte) num10, (int) (byte) num10, (int) (byte) num10);
        Color color2 = new Color((int) (byte) maxValue, (int) (byte) maxValue, (int) (byte) maxValue, (int) (byte) maxValue);
        if (mouseX >= x2 && (double) mouseX <= (double) x2 + (double) TextureAssets.InventoryBack.Width() * (double) this.inventoryScale && mouseY >= y3 && (double) mouseY <= (double) y3 + (double) TextureAssets.InventoryBack.Height() * (double) this.inventoryScale && !PlayerInput.IgnoreMouseInterface)
        {
          Main.LocalPlayer.mouseInterface = true;
          if (Main.mouseLeftRelease && Main.mouseLeft)
          {
            this._focusedElementIndex = startingElementIndex;
            Main.PipsFastScroll = true;
            Main.PipsUseGrid = false;
            SoundEngine.PlaySound(12);
            Main.mouseLeftRelease = false;
            if (PlayerInput.UsingGamepadUI)
            {
              UILinkPointNavigator.ChangePage(22);
              Main.LockCraftingForThisCraftClickDuration();
            }
          }
          Main.craftingHide = true;
          Main.HoverItem = inv.Clone();
          Main.HoverItem.stack = entry.Stack;
          ItemSlot.MouseHover(35);
          Main.hoverItemName = inv.Name;
          if (inv.stack > 1)
            Main.hoverItemName = $"{Main.hoverItemName} ({(object) inv.stack})";
        }
        if (claimableItemsCount > 0)
        {
          double num11 = num10 - 50.0;
          if (num11 < 0.0)
            num11 = 0.0;
          UILinkPointNavigator.Shortcuts.CRAFT_CurrentRecipeBig = this._gridSelectionCandidateIndex == startingElementIndex ? 0 : -1;
          Color inventoryBack = this.inventoryBack;
          this.inventoryBack = new Color((int) (byte) num11, (int) (byte) num11, (int) (byte) num11, (int) (byte) num11);
          int stack = inv.stack;
          inv.stack = entry.Stack;
          ItemSlot.Draw(spriteBatch, ref inv, 35, new Vector2((float) x2, (float) y3));
          inv.stack = stack;
          this.inventoryBack = inventoryBack;
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
  }

  public void ScrollCraftingList(int mouseWheel) => this._focusedElementIndex += mouseWheel;

  public void ScrollCraftingGrid(int mouseWheel, int width)
  {
    this._gridStartingElementIndex -= mouseWheel * width;
    if (mouseWheel <= 0)
      return;
    SoundEngine.PlaySound(12);
  }

  public void NavigatePipsList(int yOffset)
  {
    double currentElementOffset1 = (double) this._currentElementOffset;
    this._focusedElementIndex = Utils.Clamp<int>(this._focusedElementIndex + yOffset, 0, this._availableItemsCount - 1);
    double currentElementOffset2 = (double) this._currentElementOffset;
    if (currentElementOffset1 == currentElementOffset2)
      return;
    SoundEngine.PlaySound(12);
  }

  public void NavigatePipsGrid(int xOffset, int yOffset)
  {
    int craftIconsPerRow = UILinkPointNavigator.Shortcuts.CRAFT_IconsPerRow;
    int num1 = Math.Min(UILinkPointNavigator.Shortcuts.CRAFT_IconsPerColumn, (int) Math.Ceiling((double) this._availableItemsCount / (double) craftIconsPerRow));
    int num2 = this._gridSelectionCandidateIndex - this._gridStartingElementIndex;
    int num3 = num2 % craftIconsPerRow;
    int num4 = num2 / craftIconsPerRow;
    if (xOffset < 0 && num3 == 0)
      xOffset = 0;
    if (xOffset > 0 && num3 >= craftIconsPerRow)
      xOffset = 0;
    if (yOffset < 0 && this._gridStartingElementIndex > 0 && num4 == 0)
      this._gridStartingElementIndex -= craftIconsPerRow;
    if (yOffset > 0 && num4 == craftIconsPerRow - 1)
      this._gridStartingElementIndex += craftIconsPerRow;
    this._gridStartingElementIndex = Utils.Clamp<int>(this._gridStartingElementIndex, 0, Math.Max(0, this._availableItemsCount - 1 - craftIconsPerRow * num1));
    int num5 = this._gridSelectionCandidateIndex - this._gridStartingElementIndex;
    int num6 = num5 % craftIconsPerRow;
    int num7 = num5 / craftIconsPerRow;
    if (yOffset < 0 && this._gridStartingElementIndex == 0 && num7 == 0)
      yOffset = 0;
    if (yOffset > 0 && num7 == num1 - 1)
      yOffset = 0;
    int num8 = (this._availableItemsCount - this._gridStartingElementIndex) % craftIconsPerRow;
    if (yOffset > 0 && num8 != 0 && num7 == num1 - 2 && num6 >= num8)
      yOffset = 0;
    int selectionCandidateIndex1 = this._gridSelectionCandidateIndex;
    this._gridSelectionCandidateIndex = Utils.Clamp<int>(this._gridSelectionCandidateIndex + (xOffset + yOffset * craftIconsPerRow), 0, this._availableItemsCount - 1);
    int selectionCandidateIndex2 = this._gridSelectionCandidateIndex;
    if (selectionCandidateIndex1 == selectionCandidateIndex2)
      return;
    SoundEngine.PlaySound(12);
  }

  public void ResetGridSelection() => this._gridSelectionCandidateIndex = 0;

  private struct Entry
  {
    public int Index;
    public int Type;
    public int Stack;
  }
}
