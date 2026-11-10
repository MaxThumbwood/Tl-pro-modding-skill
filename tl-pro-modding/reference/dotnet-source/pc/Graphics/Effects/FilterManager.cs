// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Effects.FilterManager
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Terraria.IO;

#nullable disable
namespace Terraria.Graphics.Effects;

public class FilterManager : EffectManager<Filter>
{
  private const float OPACITY_RATE = 1f;
  private LinkedList<Filter> _activeFilters = new LinkedList<Filter>();
  private int _filterLimit = 16 /*0x10*/;
  private EffectPriority _priorityThreshold;
  private int _activeFilterCount;
  private bool _captureThisFrame;

  public event Action OnPostDraw;

  public void BindTo(Preferences preferences)
  {
    preferences.OnSave += new Action<Preferences>(this.Configuration_OnSave);
    preferences.OnLoad += new Action<Preferences>(this.Configuration_OnLoad);
  }

  private void Configuration_OnSave(Preferences preferences)
  {
    preferences.Put("FilterLimit", (object) this._filterLimit);
    preferences.Put("FilterPriorityThreshold", (object) Enum.GetName(typeof (EffectPriority), (object) this._priorityThreshold));
  }

  private void Configuration_OnLoad(Preferences preferences)
  {
    this._filterLimit = preferences.Get<int>("FilterLimit", 16 /*0x10*/);
    EffectPriority result;
    if (!Enum.TryParse<EffectPriority>(preferences.Get<string>("FilterPriorityThreshold", "VeryLow"), out result))
      return;
    this._priorityThreshold = result;
  }

  public override void OnActivate(Filter effect, Vector2 position)
  {
    if (this._activeFilters.Contains(effect))
    {
      if (effect.Active)
        return;
      if (effect.Priority >= this._priorityThreshold)
        --this._activeFilterCount;
      this._activeFilters.Remove(effect);
    }
    else
      effect.Opacity = 0.0f;
    if (effect.Priority >= this._priorityThreshold)
      ++this._activeFilterCount;
    if (this._activeFilters.Count == 0)
    {
      this._activeFilters.AddLast(effect);
    }
    else
    {
      for (LinkedListNode<Filter> node = this._activeFilters.First; node != null; node = node.Next)
      {
        Filter filter = node.Value;
        if (effect.Priority <= filter.Priority)
        {
          this._activeFilters.AddAfter(node, effect);
          return;
        }
      }
      this._activeFilters.AddLast(effect);
    }
  }

  public void BeginCapture(RenderTarget2D screenTarget1)
  {
    if (this._activeFilterCount == 0 && this.OnPostDraw == null)
    {
      this._captureThisFrame = false;
    }
    else
    {
      this._captureThisFrame = true;
      Main.instance.GraphicsDevice.SetRenderTarget(screenTarget1);
      Main.instance.GraphicsDevice.Clear(Color.Transparent);
    }
  }

  public void Update(GameTime gameTime)
  {
    LinkedListNode<Filter> node = this._activeFilters.First;
    int count = this._activeFilters.Count;
    int num = 0;
    LinkedListNode<Filter> next;
    for (; node != null; node = next)
    {
      Filter filter = node.Value;
      next = node.Next;
      bool flag = false;
      if (filter.Priority >= this._priorityThreshold)
      {
        ++num;
        if (num > this._activeFilterCount - this._filterLimit)
        {
          filter.Update(gameTime);
          flag = true;
        }
      }
      if (filter.Active & flag)
        filter.Opacity = Math.Min(filter.Opacity + (float) (gameTime.ElapsedGameTime.TotalSeconds * 1.0), 1f);
      else
        filter.Opacity = Math.Max(filter.Opacity - (float) (gameTime.ElapsedGameTime.TotalSeconds * 1.0), 0.0f);
      if (!filter.Active && (double) filter.Opacity == 0.0)
      {
        if (filter.Priority >= this._priorityThreshold)
          --this._activeFilterCount;
        this._activeFilters.Remove(node);
      }
    }
  }

  public void EndCapture(
    RenderTarget2D finalTexture,
    RenderTarget2D screenTarget1,
    RenderTarget2D screenTarget2)
  {
    this.EndCapture(finalTexture, screenTarget1, screenTarget2, screenTarget1.Size(), screenTarget1.Size(), Vector2.Zero);
  }

  public void EndCapture(
    RenderTarget2D finalTexture,
    RenderTarget2D screenTarget1,
    RenderTarget2D screenTarget2,
    Vector2 screenSize,
    Vector2 sceneSize,
    Vector2 sceneOffset)
  {
    if (!this._captureThisFrame)
      return;
    Rectangle rectangle = new Rectangle(0, 0, (int) screenSize.X, (int) screenSize.Y);
    RenderTarget2D t2 = screenTarget1;
    RenderTarget2D t1 = screenTarget2;
    GraphicsDevice graphicsDevice = Main.instance.GraphicsDevice;
    graphicsDevice.SetRenderTarget(t1);
    graphicsDevice.Clear(Color.Transparent);
    Main.spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
    SpriteEffects effects = Main.GameViewMatrix.Effects;
    Main.spriteBatch.Draw((Texture2D) Main.skyTarget, Vector2.Zero, new Rectangle?(rectangle), Color.White, 0.0f, Vector2.Zero, 1f, effects, 0.0f);
    Main.spriteBatch.Draw((Texture2D) t2, Vector2.Zero, new Rectangle?(rectangle), Color.White, 0.0f, Vector2.Zero, 1f, effects, 0.0f);
    Main.spriteBatch.End();
    Utils.Swap<RenderTarget2D>(ref t1, ref t2);
    int num = 0;
    LinkedListNode<Filter> linkedListNode = this._activeFilters.First;
    Filter filter1 = (Filter) null;
    LinkedListNode<Filter> next;
    for (; linkedListNode != null; linkedListNode = next)
    {
      Filter filter2 = linkedListNode.Value;
      next = linkedListNode.Next;
      if (filter2.Priority >= this._priorityThreshold)
      {
        ++num;
        if (num > this._activeFilterCount - this._filterLimit && filter2.IsVisible())
        {
          if (filter1 != null)
          {
            graphicsDevice.SetRenderTarget(t1);
            graphicsDevice.Clear(Color.Transparent);
            Main.spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
            filter1.Apply(t2.Size(), sceneSize, sceneOffset);
            Main.spriteBatch.Draw((Texture2D) t2, Vector2.Zero, new Rectangle?(rectangle), Main.ColorOfTheSkies);
            Main.spriteBatch.End();
            Utils.Swap<RenderTarget2D>(ref t1, ref t2);
          }
          filter1 = filter2;
        }
      }
    }
    graphicsDevice.SetRenderTarget(finalTexture);
    graphicsDevice.Clear(Color.Transparent);
    if ((double) Main.player[Main.myPlayer].gravDir == -1.0)
      Main.spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.LinearClamp, DepthStencilState.Default, RasterizerState.CullNone, (Effect) null, Main.GameViewMatrix.EffectMatrix);
    else
      Main.spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
    if (filter1 != null)
    {
      filter1.Apply(t2.Size(), sceneSize, sceneOffset);
      Main.spriteBatch.Draw((Texture2D) t2, Vector2.Zero, new Rectangle?(rectangle), Main.ColorOfTheSkies);
    }
    else
      Main.spriteBatch.Draw((Texture2D) t2, Vector2.Zero, new Rectangle?(rectangle), Color.White);
    Main.spriteBatch.End();
    for (int index = 0; index < 8; ++index)
      graphicsDevice.Textures[index] = (Texture) null;
    if (this.OnPostDraw == null)
      return;
    this.OnPostDraw();
  }

  public bool HasActiveFilter() => this._activeFilters.Count != 0;

  public bool CanCapture() => this.HasActiveFilter() || this.OnPostDraw != null;
}
