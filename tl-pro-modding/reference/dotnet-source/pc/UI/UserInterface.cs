// Decompiled with JetBrains decompiler
// Type: Terraria.UI.UserInterface
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using Terraria.GameInput;

#nullable disable
namespace Terraria.UI;

public class UserInterface
{
  private const double DOUBLE_CLICK_TIME = 500.0;
  private const double STATE_CHANGE_CLICK_DISABLE_TIME = 200.0;
  private const int MAX_HISTORY_SIZE = 32 /*0x20*/;
  private const int HISTORY_PRUNE_SIZE = 4;
  public static UserInterface ActiveInstance = new UserInterface();
  private List<UIState> _history = new List<UIState>();
  private UserInterface.InputPointerCache LeftMouse = new UserInterface.InputPointerCache()
  {
    MouseDownEvent = (UserInterface.MouseElementEvent) ((element, evt) => element.LeftMouseDown(evt)),
    MouseUpEvent = (UserInterface.MouseElementEvent) ((element, evt) => element.LeftMouseUp(evt)),
    ClickEvent = (UserInterface.MouseElementEvent) ((element, evt) => element.LeftClick(evt)),
    DoubleClickEvent = (UserInterface.MouseElementEvent) ((element, evt) => element.LeftDoubleClick(evt))
  };
  private UserInterface.InputPointerCache RightMouse = new UserInterface.InputPointerCache()
  {
    MouseDownEvent = (UserInterface.MouseElementEvent) ((element, evt) => element.RightMouseDown(evt)),
    MouseUpEvent = (UserInterface.MouseElementEvent) ((element, evt) => element.RightMouseUp(evt)),
    ClickEvent = (UserInterface.MouseElementEvent) ((element, evt) => element.RightClick(evt)),
    DoubleClickEvent = (UserInterface.MouseElementEvent) ((element, evt) => element.RightDoubleClick(evt))
  };
  public Vector2 MousePosition;
  private UIElement _lastElementHover;
  private double _clickDisabledTimeRemaining;
  private bool _isStateDirty;
  public bool IsVisible;
  private UIState _currentState;

  public void ClearPointers()
  {
    this.LeftMouse.Clear();
    this.RightMouse.Clear();
  }

  public bool MouseCaptured()
  {
    if (this.LeftMouse.WasDown && this.LeftMouse.LastDown != null)
      return true;
    return this.RightMouse.WasDown && this.RightMouse.LastDown != null;
  }

  public void ResetLasts()
  {
    if (this._lastElementHover != null)
      this._lastElementHover.MouseOut(new UIMouseEvent(this._lastElementHover, this.MousePosition));
    this.ClearPointers();
    this._lastElementHover = (UIElement) null;
  }

  public void EscapeElements() => this.ResetLasts();

  public UIState CurrentState => this._currentState;

  public UserInterface() => UserInterface.ActiveInstance = this;

  public void Use()
  {
    if (UserInterface.ActiveInstance != this)
    {
      UserInterface.ActiveInstance = this;
      this.Recalculate();
    }
    else
      UserInterface.ActiveInstance = this;
  }

  private void ImmediatelyUpdateInputPointers()
  {
    this.LeftMouse.WasDown = Main.mouseLeft;
    this.RightMouse.WasDown = Main.mouseRight;
  }

  private void ResetState()
  {
    if (!Main.dedServ)
    {
      this.GetMousePosition();
      this.ImmediatelyUpdateInputPointers();
      if (this._lastElementHover != null)
        this._lastElementHover.MouseOut(new UIMouseEvent(this._lastElementHover, this.MousePosition));
    }
    this.ClearPointers();
    this._lastElementHover = (UIElement) null;
    this._clickDisabledTimeRemaining = Math.Max(this._clickDisabledTimeRemaining, 200.0);
  }

  private void GetMousePosition()
  {
    this.MousePosition = new Vector2((float) Main.mouseX, (float) Main.mouseY);
  }

  public void Update(GameTime time)
  {
    if (this._currentState == null)
      return;
    bool flag = FocusHelper.AllowUIInputs;
    if (!Main.gameMenu && PlayerInput.IgnoreMouseInterface)
      flag = false;
    this.GetMousePosition();
    UIElement elementAt = flag ? this._currentState.GetElementAt(this.MousePosition) : (UIElement) null;
    this._clickDisabledTimeRemaining = Math.Max(0.0, this._clickDisabledTimeRemaining - time.ElapsedGameTime.TotalMilliseconds);
    int num = this._clickDisabledTimeRemaining > 0.0 ? 1 : 0;
    if (elementAt != this._lastElementHover)
    {
      if (this._lastElementHover != null)
        this._lastElementHover.MouseOut(new UIMouseEvent(this._lastElementHover, this.MousePosition));
      elementAt?.MouseOver(new UIMouseEvent(elementAt, this.MousePosition));
      this._lastElementHover = elementAt;
    }
    if (num == 0)
    {
      this.HandleClick(this.LeftMouse, time, Main.mouseLeft & flag, elementAt);
      this.HandleClick(this.RightMouse, time, Main.mouseRight & flag, elementAt);
    }
    if (PlayerInput.ScrollWheelDeltaForUI != 0)
    {
      elementAt?.ScrollWheel(new UIScrollWheelEvent(elementAt, this.MousePosition, PlayerInput.ScrollWheelDeltaForUI));
      PlayerInput.ScrollWheelDeltaForUI = 0;
    }
    if (this._currentState == null)
      return;
    this._currentState.Update(time);
  }

  private void HandleClick(
    UserInterface.InputPointerCache cache,
    GameTime time,
    bool isDown,
    UIElement mouseElement)
  {
    if (isDown && !cache.WasDown && mouseElement != null)
    {
      cache.LastDown = mouseElement;
      cache.MouseDownEvent(mouseElement, new UIMouseEvent(mouseElement, this.MousePosition));
      if (cache.LastClicked == mouseElement && time.TotalGameTime.TotalMilliseconds - cache.LastTimeDown < 500.0)
      {
        cache.DoubleClickEvent(mouseElement, new UIMouseEvent(mouseElement, this.MousePosition));
        cache.LastClicked = (UIElement) null;
      }
      cache.LastTimeDown = time.TotalGameTime.TotalMilliseconds;
    }
    else if (!isDown && cache.WasDown && cache.LastDown != null)
    {
      UIElement lastDown = cache.LastDown;
      if (lastDown.ContainsPoint(this.MousePosition))
      {
        cache.ClickEvent(lastDown, new UIMouseEvent(lastDown, this.MousePosition));
        cache.LastClicked = cache.LastDown;
      }
      cache.MouseUpEvent(lastDown, new UIMouseEvent(lastDown, this.MousePosition));
      cache.LastDown = (UIElement) null;
    }
    cache.WasDown = isDown;
  }

  public void Draw(SpriteBatch spriteBatch, GameTime time)
  {
    this.Use();
    if (this._currentState == null)
      return;
    if (this._isStateDirty)
    {
      this._currentState.Recalculate();
      this._isStateDirty = false;
    }
    this._currentState.Draw(spriteBatch);
  }

  public void DrawDebugHitbox(BasicDebugDrawer drawer)
  {
    UIState currentState = this._currentState;
  }

  public void SetState(UIState state)
  {
    if (state == this._currentState)
      return;
    if (state != null)
      this.AddToHistory(state);
    if (this._currentState != null)
    {
      if (this._lastElementHover != null)
        this._lastElementHover.MouseOut(new UIMouseEvent(this._lastElementHover, this.MousePosition));
      this._currentState.Deactivate();
    }
    this._currentState = state;
    this.ResetState();
    if (state != null)
    {
      this._isStateDirty = true;
      state.Activate();
      state.Recalculate();
    }
    this.IsVisible = this._currentState != null;
  }

  public void GoBack()
  {
    if (this._history.Count < 2)
      return;
    UIState state = this._history[this._history.Count - 2];
    this._history.RemoveRange(this._history.Count - 2, 2);
    this.SetState(state);
  }

  private void AddToHistory(UIState state)
  {
    this._history.Add(state);
    if (this._history.Count <= 32 /*0x20*/)
      return;
    this._history.RemoveRange(0, 4);
  }

  public void Recalculate()
  {
    if (this._currentState == null)
      return;
    this._currentState.Recalculate();
  }

  public CalculatedStyle GetDimensions()
  {
    Vector2 originalScreenSize = PlayerInput.OriginalScreenSize;
    return new CalculatedStyle(0.0f, 0.0f, originalScreenSize.X / Main.UIScale, originalScreenSize.Y / Main.UIScale);
  }

  internal void RefreshState()
  {
    if (this._currentState != null)
      this._currentState.Deactivate();
    this.ResetState();
    this._currentState.Activate();
    this._currentState.Recalculate();
  }

  public bool IsElementUnderMouse()
  {
    return this.IsVisible && this._lastElementHover != null && !(this._lastElementHover is UIState);
  }

  private delegate void MouseElementEvent(UIElement element, UIMouseEvent evt);

  private class InputPointerCache
  {
    public double LastTimeDown;
    public bool WasDown;
    public UIElement LastDown;
    public UIElement LastClicked;
    public UserInterface.MouseElementEvent MouseDownEvent;
    public UserInterface.MouseElementEvent MouseUpEvent;
    public UserInterface.MouseElementEvent ClickEvent;
    public UserInterface.MouseElementEvent DoubleClickEvent;

    public void Clear()
    {
      this.LastClicked = (UIElement) null;
      this.LastDown = (UIElement) null;
      this.LastTimeDown = 0.0;
    }
  }
}
