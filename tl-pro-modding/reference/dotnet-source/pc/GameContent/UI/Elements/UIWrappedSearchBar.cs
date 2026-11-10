// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UIWrappedSearchBar
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using System.Linq;
using Terraria.Audio;
using Terraria.GameContent.UI.States;
using Terraria.Localization;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UIWrappedSearchBar : UIElement
{
  private Action _goBackFromVirtualKeyboard;
  private LocalizedText _emptyText;
  private UISearchBar _searchBar;
  private UIPanel _searchBoxPanel;
  private UIElement _searchButton;
  private string _searchString;
  public Action<UIState> CustomOpenVirtualKeyboard;
  private UIWrappedSearchBar.ColorTheme _theme;

  public event Action<string> OnSearchContentsChanged;

  public bool HasContents => this._searchBar.HasContents;

  public void SetContents(string contents, bool forced = false)
  {
    this._searchBar.SetContents(contents, forced);
  }

  public bool IsWritingText => this._searchBar.IsWritingText;

  public void ToggleTakingText() => this._searchBar.ToggleTakingText();

  public int MaxInputLength
  {
    get => this._searchBar.MaxInputLength;
    set => this._searchBar.MaxInputLength = value;
  }

  public void SetSearchSnapPoint(string name, int id, Vector2? anchor = null, Vector2? offset = null)
  {
    this._searchButton.SetSnapPoint(name, id, anchor, offset);
  }

  public UIWrappedSearchBar(
    Action goBackFromVirtualKeyboard,
    LocalizedText emptyText = null,
    UIWrappedSearchBar.ColorTheme theme = UIWrappedSearchBar.ColorTheme.Blue)
  {
    this._theme = theme;
    this._goBackFromVirtualKeyboard = goBackFromVirtualKeyboard;
    this._emptyText = emptyText != null ? emptyText : Language.GetText("UI.PlayerNameSlot");
    this.Height = new StyleDimension(24f, 0.0f);
    this.Width = new StyleDimension(0.0f, 1f);
    this.SetPadding(0.0f);
    this.AddSearchBar();
    this.SetContents((string) null, true);
  }

  public void HideSearchButton()
  {
    this.RemoveChild(this._searchButton);
    this._searchBoxPanel.Width = new StyleDimension(-3f, 1f);
    this.Recalculate();
  }

  private void AddSearchBar()
  {
    string str = "Images/UI/Bestiary/Button_Search";
    if (this._theme == UIWrappedSearchBar.ColorTheme.Red)
      str = "Images/UI/Bestiary/Button_Search_2";
    UIImageButton uiImageButton1 = new UIImageButton(Main.Assets.Request<Texture2D>(str, (AssetRequestMode) 1));
    uiImageButton1.VAlign = 0.5f;
    UIImageButton element1 = uiImageButton1;
    this._searchButton = (UIElement) element1;
    element1.OnLeftClick += new UIElement.MouseEvent(this.Click_SearchArea);
    element1.SetHoverImage(Main.Assets.Request<Texture2D>("Images/UI/Bestiary/Button_Search_Border", (AssetRequestMode) 1));
    element1.SetVisibility(1f, 1f);
    this.Append((UIElement) element1);
    UIPanel uiPanel = new UIPanel();
    uiPanel.Width = new StyleDimension((float) (-(double) element1.Width.Pixels - 3.0), 1f);
    uiPanel.Height = new StyleDimension(0.0f, 1f);
    uiPanel.VAlign = 0.5f;
    uiPanel.HAlign = 1f;
    UIPanel element2 = uiPanel;
    this._searchBoxPanel = element2;
    element2.BackgroundColor = new Color(35, 40, 83);
    element2.BorderColor = new Color(35, 40, 83);
    if (this._theme == UIWrappedSearchBar.ColorTheme.Red)
    {
      element2.BackgroundColor = Utils.ShiftBlueToCyanTheme(element2.BackgroundColor);
      element2.BorderColor = Utils.ShiftBlueToCyanTheme(element2.BorderColor);
    }
    element2.SetPadding(0.0f);
    this.Append((UIElement) element2);
    UISearchBar uiSearchBar = new UISearchBar(this._emptyText, 0.8f);
    uiSearchBar.Width = new StyleDimension(0.0f, 1f);
    uiSearchBar.Height = new StyleDimension(0.0f, 1f);
    uiSearchBar.HAlign = 0.0f;
    uiSearchBar.VAlign = 0.5f;
    uiSearchBar.Left = new StyleDimension(0.0f, 0.0f);
    uiSearchBar.IgnoresMouseInteraction = true;
    UISearchBar element3 = uiSearchBar;
    this._searchBar = element3;
    element2.OnLeftClick += new UIElement.MouseEvent(this.Click_SearchArea);
    element2.OnRightClick += new UIElement.MouseEvent(this.SearchBox_OnRightClick);
    element3.OnContentsChanged += new Action<string>(this.UpdateSearchContents);
    element2.Append((UIElement) element3);
    element3.OnStartTakingInput += new Action(this.OnStartTakingInput);
    element3.OnEndTakingInput += new Action(this.OnEndTakingInput);
    element3.OnNeedingVirtualKeyboard += new Action(this.OpenVirtualKeyboardWhenNeeded);
    UIImageButton uiImageButton2 = new UIImageButton(Main.Assets.Request<Texture2D>("Images/UI/SearchCancel", (AssetRequestMode) 1));
    uiImageButton2.HAlign = 1f;
    uiImageButton2.VAlign = 0.5f;
    uiImageButton2.Left = new StyleDimension(-2f, 0.0f);
    UIImageButton element4 = uiImageButton2;
    element4.OnMouseOver += new UIElement.MouseEvent(this.searchCancelButton_OnMouseOver);
    element4.OnLeftClick += new UIElement.MouseEvent(this.searchCancelButton_OnClick);
    element2.Append((UIElement) element4);
  }

  private void searchCancelButton_OnClick(UIMouseEvent evt, UIElement listeningElement)
  {
    if (this.HasContents)
    {
      this.SetContents((string) null, true);
      SoundEngine.PlaySound(11);
    }
    else
      SoundEngine.PlaySound(12);
  }

  private void searchCancelButton_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
  }

  private void OpenVirtualKeyboardWhenNeeded()
  {
    UIVirtualKeyboard state = new UIVirtualKeyboard(this._emptyText.Value, this._searchString, new UIVirtualKeyboard.KeyboardSubmitEvent(this.SubmitVirtualText), new Action(this.GoBackFromVirtualKeyboard), allowEmpty: true, maxLength: this.MaxInputLength);
    if (this.CustomOpenVirtualKeyboard != null)
      this.CustomOpenVirtualKeyboard((UIState) state);
    else
      UserInterface.ActiveInstance.SetState((UIState) state);
  }

  private void SubmitVirtualText(string text)
  {
    this.SetContents(text.Trim());
    this.GoBackFromVirtualKeyboard();
  }

  private void GoBackFromVirtualKeyboard()
  {
    this._searchBar.ToggleTakingText();
    this._goBackFromVirtualKeyboard();
  }

  private void OnStartTakingInput() => this._searchBoxPanel.BorderColor = Main.OurFavoriteColor;

  private void OnEndTakingInput()
  {
    this._searchBoxPanel.BorderColor = new Color(35, 40, 83);
    if (this._theme != UIWrappedSearchBar.ColorTheme.Red)
      return;
    this._searchBoxPanel.BorderColor = Utils.ShiftBlueToCyanTheme(this._searchBoxPanel.BorderColor);
  }

  private void UpdateSearchContents(string contents)
  {
    this._searchString = contents;
    if (this.OnSearchContentsChanged == null)
      return;
    this.OnSearchContentsChanged(contents);
  }

  private void Click_SearchArea(UIMouseEvent evt, UIElement listeningElement)
  {
    if (evt.Target.Parent == this._searchBoxPanel)
      return;
    this.ToggleTakingText();
  }

  private void SearchBox_OnRightClick(UIMouseEvent evt, UIElement listeningElement)
  {
    this.SetContents((string) null, true);
    if (this.IsWritingText)
      return;
    this.ToggleTakingText();
  }

  public override void Update(GameTime gameTime)
  {
    base.Update(gameTime);
    if (!this.IsWritingText || !FocusHelper.AllowUIInputs || !Main.mouseLeft && !Main.mouseRight || this.Elements.Any<UIElement>((Func<UIElement, bool>) (e => e.IsMouseHovering)))
      return;
    this.ToggleTakingText();
  }

  public enum ColorTheme
  {
    Blue,
    Red,
  }
}
