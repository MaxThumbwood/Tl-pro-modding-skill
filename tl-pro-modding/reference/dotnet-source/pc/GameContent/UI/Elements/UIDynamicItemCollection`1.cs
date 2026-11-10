// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UIDynamicItemCollection`1
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Terraria.GameInput;
using Terraria.UI;
using Terraria.UI.Gamepad;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public abstract class UIDynamicItemCollection<TEntry> : UIDynamicItemCollection
{
  private List<TEntry> _contents = new List<TEntry>();
  private int _itemsPerLine;
  private const int sizePerEntryX = 44;
  private const int sizePerEntryY = 44;
  private List<SnapPoint> _dummySnapPoints = new List<SnapPoint>();

  public UIDynamicItemCollection()
  {
    this.Width = new StyleDimension(0.0f, 1f);
    this.HAlign = 0.5f;
    this.UpdateSize();
  }

  public int Count => this._contents.Count;

  protected abstract Item GetItem(TEntry entry);

  protected override void DrawSelf(SpriteBatch spriteBatch)
  {
    Main.inventoryScale = 0.846153855f;
    int startX;
    int startY;
    int startItemIndex;
    int endItemIndex;
    this.GetGridParameters(out startX, out startY, out startItemIndex, out endItemIndex);
    int itemsPerLine = this._itemsPerLine;
    Vector2 v = Main.MouseScreen;
    if (PlayerInput.UsingGamepad)
      v = UILinkPointNavigator.GetPosition(UILinkPointNavigator.CurrentPoint);
    for (int index = startItemIndex; index < endItemIndex; ++index)
    {
      TEntry content = this._contents[index];
      Rectangle itemSlotHitbox = this.GetItemSlotHitbox(startX, startY, startItemIndex, index);
      if (TextureAssets.Item[this.GetItem(content).type].State == null)
        --itemsPerLine;
      bool hovering = this.IsMouseHovering && itemSlotHitbox.Contains(v.ToPoint()) && !PlayerInput.IgnoreMouseInterface;
      this.DrawSlot(spriteBatch, content, itemSlotHitbox.TopLeft(), hovering);
      if (itemsPerLine <= 0)
        break;
    }
    for (int index = 0; index < this._contents.Count && itemsPerLine > 0; ++index)
    {
      Item obj = this.GetItem(this._contents[(index + endItemIndex) % this._contents.Count]);
      if (TextureAssets.Item[obj.type].State == null)
      {
        Main.instance.LoadItem(obj.type);
        itemsPerLine -= 4;
      }
    }
  }

  protected abstract void DrawSlot(
    SpriteBatch spriteBatch,
    TEntry entry,
    Vector2 pos,
    bool hovering);

  private Rectangle GetItemSlotHitbox(int startX, int startY, int startItemIndex, int i)
  {
    int num1 = i - startItemIndex;
    int num2 = num1 % this._itemsPerLine;
    int num3 = num1 / this._itemsPerLine;
    return new Rectangle(startX + num2 * 44, startY + num3 * 44, 44, 44);
  }

  private void GetGridParameters(
    out int startX,
    out int startY,
    out int startItemIndex,
    out int endItemIndex)
  {
    Rectangle rectangle = this.GetDimensions().ToRectangle();
    Rectangle viewCullingArea = this.Parent.GetViewCullingArea();
    int x = rectangle.Center.X;
    startX = x - (int) ((double) (44 * this._itemsPerLine) * 0.5);
    startY = rectangle.Top;
    startItemIndex = 0;
    endItemIndex = this._contents.Count;
    int num1 = (Math.Min(viewCullingArea.Top, rectangle.Top) - viewCullingArea.Top) / 44;
    startY += -num1 * 44;
    startItemIndex += -num1 * this._itemsPerLine;
    int num2 = (int) Math.Ceiling((double) viewCullingArea.Height / 44.0) * this._itemsPerLine;
    if (endItemIndex <= num2 + startItemIndex + this._itemsPerLine)
      return;
    endItemIndex = num2 + startItemIndex + this._itemsPerLine;
  }

  public override void Recalculate()
  {
    base.Recalculate();
    this.UpdateSize();
  }

  public override void Update(GameTime gameTime)
  {
    base.Update(gameTime);
    if (!this.IsMouseHovering)
      return;
    Main.LocalPlayer.mouseInterface = true;
  }

  public void SetContentsToShow(List<TEntry> itemsToShow)
  {
    this._contents.Clear();
    this._contents.AddRange((IEnumerable<TEntry>) itemsToShow);
    this.UpdateSize();
  }

  public int GetItemsPerLine() => this._itemsPerLine;

  public override List<SnapPoint> GetSnapPoints()
  {
    List<SnapPoint> snapPoints = new List<SnapPoint>();
    int startX;
    int startY;
    int startItemIndex;
    int endItemIndex;
    this.GetGridParameters(out startX, out startY, out startItemIndex, out endItemIndex);
    int itemsPerLine = this._itemsPerLine;
    Rectangle viewCullingArea = this.Parent.GetViewCullingArea();
    int num = endItemIndex - startItemIndex;
    while (this._dummySnapPoints.Count < num)
      this._dummySnapPoints.Add(new SnapPoint("DynamicItemCollectionSlot", 0, Vector2.Zero, Vector2.Zero));
    int index1 = 0;
    Vector2 vector2 = this.GetDimensions().Position();
    for (int index2 = startItemIndex; index2 < endItemIndex; ++index2)
    {
      Point center = this.GetItemSlotHitbox(startX, startY, startItemIndex, index2).Center;
      if (viewCullingArea.Contains(center))
      {
        SnapPoint dummySnapPoint = this._dummySnapPoints[index1];
        dummySnapPoint.ThisIsAHackThatChangesTheSnapPointsInfo(Vector2.Zero, center.ToVector2() - vector2, index2);
        dummySnapPoint.Calculate((UIElement) this);
        ++index1;
        snapPoints.Add(dummySnapPoint);
      }
    }
    foreach (UIElement element in this.Elements)
      snapPoints.AddRange((IEnumerable<SnapPoint>) element.GetSnapPoints());
    return snapPoints;
  }

  public void UpdateSize()
  {
    int num = this.GetDimensions().ToRectangle().Width / 44;
    this._itemsPerLine = num;
    this.MinHeight.Set((float) (44 * (int) Math.Ceiling((double) this._contents.Count / (double) num)), 0.0f);
  }
}
