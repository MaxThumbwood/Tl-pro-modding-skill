// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.States.UIDebugCommandsList
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.Audio;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Testing.ChatCommands;
using Terraria.UI;
using Terraria.UI.Chat;

#nullable disable
namespace Terraria.GameContent.UI.States;

public class UIDebugCommandsList : UIState
{
  private readonly UIList _commandsList = new UIList();
  private readonly List<UIDebugCommandItem> _commands = new List<UIDebugCommandItem>();

  public UIDebugCommandsList() => this.BuildPage();

  public override void OnDeactivate()
  {
  }

  private void BuildPage()
  {
    this.RemoveAllChildren();
    UIElement element1 = new UIElement();
    element1.Width.Set(0.0f, 0.8f);
    element1.MaxWidth.Set(800f, 0.0f);
    element1.MinWidth.Set(600f, 0.0f);
    element1.Top.Set(220f, 0.0f);
    element1.Height.Set(-220f, 1f);
    element1.HAlign = 0.5f;
    this.Append(element1);
    UIPanel element2 = new UIPanel();
    element2.Width.Set(0.0f, 1f);
    element2.Height.Set(-110f, 1f);
    element2.BackgroundColor = new Color(33, 43, 79) * 0.95f;
    element1.Append((UIElement) element2);
    UIWrappedSearchBar wrappedSearchBar = new UIWrappedSearchBar((Action) (() => UserInterface.ActiveInstance.SetState((UIState) this)));
    wrappedSearchBar.Width = new StyleDimension(200f, 0.0f);
    wrappedSearchBar.Top = new StyleDimension(20f, 0.0f);
    UIWrappedSearchBar element3 = wrappedSearchBar;
    element3.OnSearchContentsChanged += new Action<string>(this.searchbar_OnSearchContentsChanged);
    element2.Append((UIElement) element3);
    this._commandsList.Width.Set(-25f, 1f);
    this._commandsList.Height.Set(-60f, 1f);
    this._commandsList.VAlign = 1f;
    this._commandsList.ListPadding = 5f;
    element2.Append((UIElement) this._commandsList);
    UITextPanel<string> element4 = new UITextPanel<string>("Debug Commands", large: true);
    element4.HAlign = 0.5f;
    element4.Top.Set(-33f, 0.0f);
    element4.SetPadding(13f);
    element4.BackgroundColor = new Color(73, 94, 171);
    element1.Append((UIElement) element4);
    UITextPanel<LocalizedText> element5 = new UITextPanel<LocalizedText>(Language.GetText("UI.Back"), 0.7f, true);
    element5.Width.Set(-10f, 0.5f);
    element5.Height.Set(50f, 0.0f);
    element5.VAlign = 1f;
    element5.HAlign = 0.5f;
    element5.Top.Set(-45f, 0.0f);
    element5.OnMouseOver += new UIElement.MouseEvent(UIDebugCommandsList.FadedMouseOver);
    element5.OnMouseOut += new UIElement.MouseEvent(UIDebugCommandsList.FadedMouseOut);
    element5.OnLeftClick += new UIElement.MouseEvent(this.GoBackClick);
    element1.Append((UIElement) element5);
    UIScrollbar uiScrollbar = new UIScrollbar();
    uiScrollbar.SetView(100f, 1000f);
    uiScrollbar.Height.Set(0.0f, 1f);
    uiScrollbar.HAlign = 1f;
    element2.Append((UIElement) uiScrollbar);
    this._commandsList.SetScrollbar(uiScrollbar);
    this.PopulateCommandsList();
  }

  private void searchbar_OnSearchContentsChanged(string searchContents)
  {
    if (searchContents == null)
      searchContents = string.Empty;
    string lowerContents = searchContents.ToLowerInvariant().Trim();
    bool flag = string.IsNullOrWhiteSpace(lowerContents);
    this._commandsList.Clear();
    foreach (UIDebugCommandItem command in this._commands)
    {
      if (flag || UIDebugCommandsList.DoesCommandMatchSearch(lowerContents, command))
        this._commandsList.Add((UIElement) command);
    }
  }

  private static bool DoesCommandMatchSearch(string lowerContents, UIDebugCommandItem command)
  {
    IDebugCommand command1 = command.Command;
    return command1.Name.ToLowerInvariant().Contains(lowerContents) || command1.Description != null && command1.Description.ToLowerInvariant().Contains(lowerContents) || command1.HelpText != null && command1.HelpText.ToLowerInvariant().Contains(lowerContents);
  }

  private void GoBackClick(UIMouseEvent evt, UIElement listeningElement) => IngameFancyUI.Close();

  private static void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    ((UIPanel) evt.Target).BackgroundColor = new Color(73, 94, 171);
    ((UIPanel) evt.Target).BorderColor = Colors.FancyUIFatButtonMouseOver;
  }

  private static void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
  {
    ((UIPanel) evt.Target).BackgroundColor = new Color(63 /*0x3F*/, 82, 151) * 0.8f;
    ((UIPanel) evt.Target).BorderColor = Color.Black;
  }

  private void PopulateCommandsList()
  {
    List<IDebugCommand> list = ChatManager.DebugCommands.Commands.ToList<IDebugCommand>();
    list.Sort((Comparison<IDebugCommand>) ((x, y) => StringComparer.OrdinalIgnoreCase.Compare(x.Name, y.Name)));
    int num = 0;
    foreach (IDebugCommand command in list)
    {
      UIDebugCommandItem debugCommandItem = new UIDebugCommandItem(command, num++);
      this._commands.Add(debugCommandItem);
      this._commandsList.Add((UIElement) debugCommandItem);
    }
  }

  private static void DrawMouseOver()
  {
    Item obj = new Item();
    obj.SetDefaults(0);
    obj.SetNameOverride("Dev Commands");
    obj.type = 1;
    obj.scale = 0.0f;
    obj.rare = 10;
    Main.HoverItem = obj;
    Main.instance.MouseText("");
    Main.mouseText = true;
  }
}
