// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Effects.GameEffect
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.Graphics.Effects;

public abstract class GameEffect
{
  public float Opacity;
  protected bool _isLoaded;
  protected EffectPriority _priority;

  public bool IsLoaded => this._isLoaded;

  public EffectPriority Priority => this._priority;

  public void Load()
  {
    if (this._isLoaded)
      return;
    this._isLoaded = true;
    this.OnLoad();
  }

  public virtual void OnLoad()
  {
  }

  public abstract bool IsVisible();

  public abstract void Activate(Vector2 position, params object[] args);

  public abstract void Deactivate(params object[] args);
}
