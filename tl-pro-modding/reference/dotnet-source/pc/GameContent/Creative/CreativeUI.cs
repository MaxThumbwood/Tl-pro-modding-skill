// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Creative.CreativeUI
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using Terraria.Audio;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.UI;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.GameInput;
using Terraria.Localization;
using Terraria.Net;
using Terraria.UI;
using Terraria.UI.Gamepad;

#nullable disable
namespace Terraria.GameContent.Creative;

public class CreativeUI
{
  public const int ItemSlotIndexes_SacrificeItem = 0;
  public const int ItemSlotIndexes_Count = 1;
  private bool _initialized;
  private Asset<Texture2D> _buttonTexture;
  private Asset<Texture2D> _buttonBorderTexture;
  private Item[] _itemSlotsForUI = new Item[1];
  private UserInterface _powersUI = new UserInterface();
  public bool GamepadMoveToSearchButtonHack;
  private UICreativePowersMenu _uiState;

  public bool Enabled { get; private set; }

  public bool Blocked
  {
    get
    {
      if (Main.LocalPlayer.talkNPC != -1)
        return true;
      if (NewCraftingUI.Visible)
        return false;
      return Main.LocalPlayer.chest != -1 || Main.LocalPlayer.tileEntityAnchor.IsInValidUseTileEntity();
    }
  }

  public CreativeUI()
  {
    for (int index = 0; index < this._itemSlotsForUI.Length; ++index)
      this._itemSlotsForUI[index] = new Item();
  }

  public void Initialize()
  {
    this._buttonTexture = Main.Assets.Request<Texture2D>("Images/UI/Creative/Journey_Toggle", (AssetRequestMode) 1);
    this._buttonBorderTexture = Main.Assets.Request<Texture2D>("Images/UI/Creative/Journey_Toggle_MouseOver", (AssetRequestMode) 1);
    this._uiState = new UICreativePowersMenu();
    this._powersUI.SetState((UIState) this._uiState);
    this._initialized = true;
  }

  public void Update(GameTime gameTime)
  {
    if (!this.Enabled || !Main.playerInventory)
      return;
    this._powersUI.Update(gameTime);
  }

  public void Draw(SpriteBatch spriteBatch)
  {
    if (!this._initialized)
      this.Initialize();
    if (Main.LocalPlayer.difficulty != (byte) 3)
    {
      this.Enabled = false;
    }
    else
    {
      if (this.Blocked)
        return;
      Vector2 location = new Vector2(28f, 267f);
      Vector2 vector2_1 = new Vector2(353f, 258f);
      Vector2 vector2_2 = new Vector2(40f, 267f);
      Vector2 vector2_3 = new Vector2(50f, 50f);
      Vector2 vector2_4 = vector2_1 + vector2_3;
      if (Main.screenHeight < 650 && this.Enabled)
        location.X += 52f * Main.inventoryScale;
      this.DrawToggleButton(spriteBatch, location);
      if (!this.Enabled)
        return;
      this._powersUI.Draw(spriteBatch, Main.gameTimeCache);
    }
  }

  public UIElement ProvideItemSlotElement(int itemSlotContext)
  {
    return itemSlotContext != 0 ? (UIElement) null : (UIElement) new UIItemSlot(this._itemSlotsForUI, itemSlotContext, 30);
  }

  public Item GetItemByIndex(int itemSlotContext)
  {
    return itemSlotContext != 0 ? (Item) null : this._itemSlotsForUI[itemSlotContext];
  }

  public void SetItembyIndex(Item item, int itemSlotContext)
  {
    if (itemSlotContext != 0)
      return;
    this._itemSlotsForUI[itemSlotContext] = item;
  }

  private void DrawToggleButton(SpriteBatch spritebatch, Vector2 location)
  {
    Vector2 size = this._buttonTexture.Size();
    Rectangle hitbox = Utils.CenteredRectangle(location + size / 2f, size);
    UILinkPointNavigator.SetPosition(311, hitbox.Center.ToVector2());
    spritebatch.Draw(this._buttonTexture.Value, location, new Rectangle?(), Color.White, 0.0f, Vector2.Zero, 1f, SpriteEffects.None, 0.0f);
    Main.LocalPlayer.creativeInterface = false;
    if (hitbox.Contains(Main.MouseScreen.ToPoint()) && !PlayerInput.IgnoreMouseInterface)
    {
      Main.LocalPlayer.creativeInterface = true;
      Main.LocalPlayer.mouseInterface = true;
      if (this.Enabled)
        Main.instance.MouseTextNoOverride(Language.GetTextValue("CreativePowers.PowersMenuOpen"));
      else
        Main.instance.MouseTextNoOverride(Language.GetTextValue("CreativePowers.PowersMenuClosed"));
      spritebatch.Draw(this._buttonBorderTexture.Value, location, new Rectangle?(), Color.White, 0.0f, Vector2.Zero, 1f, SpriteEffects.None, 0.0f);
      if (Main.mouseLeft && Main.mouseLeftRelease)
        this.ToggleMenu();
    }
    Main.DoStatefulTickSound(ref Main.CreativeMenuMouseOver, Main.LocalPlayer.creativeInterface);
    if (!Main.LocalPlayerCreativeTracker.ItemSacrifices.AnyNewUnlocksFromTeammates)
      return;
    Utils.DrawNotificationIcon(spritebatch, hitbox);
  }

  public void SwapItem(ref Item item) => Utils.Swap<Item>(ref item, ref this._itemSlotsForUI[0]);

  public void CloseMenu()
  {
    if (!this.Enabled)
      return;
    this.Enabled = false;
    this.StopPlayingSacrificeAnimations();
  }

  public void ResumeMenuFromGamepadSearch()
  {
    this.Enabled = true;
    this.GamepadMoveToSearchButtonHack = true;
  }

  public void ToggleMenu()
  {
    this.Enabled = !this.Enabled;
    this._powersUI.EscapeElements();
    UISliderBase.EscapeElements();
    SoundEngine.PlaySound(12);
    if (this.Enabled)
    {
      NewCraftingUI.Close(true, true);
      Main.LocalPlayer.chest = -1;
      Main.LocalPlayer.tileEntityAnchor.Clear();
      UILinkPointNavigator.ChangePoint(10000);
    }
    else
    {
      if (this._itemSlotsForUI[0].stack <= 0)
        return;
      Main.LocalPlayer.GetOrDropItem(this._itemSlotsForUI[0], GetItemSettings.ReturnItemFromSlot);
      this.StopPlayingSacrificeAnimations();
    }
  }

  public bool IsShowingResearchMenu()
  {
    return this.Enabled && this._uiState != null && this._uiState.IsShowingResearchMenu;
  }

  public void SacrificeItemInSacrificeSlot()
  {
    if (this._uiState == null)
      return;
    this._uiState.SacrificeWhatsInResearchMenu();
  }

  public void StopPlayingSacrificeAnimations()
  {
    if (this._uiState == null)
      return;
    this._uiState.StopPlayingResearchAnimations();
  }

  public bool ShouldDrawSacrificeArea()
  {
    if (!this._itemSlotsForUI[0].IsAir)
      return true;
    Item mouseItem = Main.mouseItem;
    int amountNeeded;
    return !mouseItem.IsAir && CreativeItemSacrificesCatalog.Instance.TryGetSacrificeCountCapToUnlockInfiniteItems(mouseItem.type, out amountNeeded) && Main.LocalPlayerCreativeTracker.ItemSacrifices.GetSacrificeCount(mouseItem.type) < amountNeeded;
  }

  public bool GetSacrificeNumbers(
    out int itemIdChecked,
    out int amountWeHave,
    out int amountNeededTotal)
  {
    amountWeHave = 0;
    amountNeededTotal = 0;
    itemIdChecked = 0;
    Item obj = this._itemSlotsForUI[0];
    if (!obj.IsAir)
      itemIdChecked = obj.type;
    return Main.LocalPlayerCreativeTracker.ItemSacrifices.TryGetSacrificeNumbers(obj.type, out amountWeHave, out amountNeededTotal);
  }

  public CreativeUI.ItemSacrificeResult SacrificeItem(out int amountWeSacrificed)
  {
    return this.SacrificeItem(ref this._itemSlotsForUI[0], out amountWeSacrificed);
  }

  public CreativeUI.ItemSacrificeResult SacrificeItem(
    ref Item item,
    out int amountWeSacrificed,
    bool spawnExcessItem = true,
    bool onlySacrificeIfItWouldFinishResearch = false)
  {
    int amountNeededTotal = 0;
    int amountWeHave = 0;
    amountWeSacrificed = 0;
    if (!Main.LocalPlayerCreativeTracker.ItemSacrifices.TryGetSacrificeNumbers(item.type, out amountWeHave, out amountNeededTotal))
      return CreativeUI.ItemSacrificeResult.CannotSacrifice;
    int val1 = Utils.Clamp<int>(amountNeededTotal - amountWeHave, 0, amountNeededTotal);
    if (val1 == 0)
      return CreativeUI.ItemSacrificeResult.CannotSacrifice;
    int amount = Math.Min(val1, item.stack);
    bool flag = amount == val1;
    if (onlySacrificeIfItWouldFinishResearch && !flag)
      return CreativeUI.ItemSacrificeResult.CannotSacrifice;
    NetPacket packet = NetCreativeUnlocksPlayerReportModule.SerializeSacrificeRequest(Main.myPlayer, item.type, amount);
    NetManager.Instance.SendToServer(packet);
    if (!Main.ServerSideCharacter)
      Main.LocalPlayerCreativeTracker.ItemSacrifices.RegisterItemSacrifice(item.type, amount);
    item.stack -= amount;
    if (item.stack <= 0)
      item.TurnToAir();
    amountWeSacrificed = amount;
    if (item.stack > 0 & spawnExcessItem)
      item = Main.LocalPlayer.GetItem(item, GetItemSettings.ReturnItemFromSlot);
    return !flag ? CreativeUI.ItemSacrificeResult.SacrificedButNotDone : CreativeUI.ItemSacrificeResult.SacrificedAndDone;
  }

  public void Reset()
  {
    for (int index = 0; index < this._itemSlotsForUI.Length; ++index)
      this._itemSlotsForUI[index].TurnToAir();
    this._initialized = false;
    this.Enabled = false;
  }

  public enum ItemSacrificeResult
  {
    CannotSacrifice,
    SacrificedButNotDone,
    SacrificedAndDone,
  }
}
