// Decompiled with JetBrains decompiler
// Type: Terraria.Cinematics.CinematicManager
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;

#nullable disable
namespace Terraria.Cinematics;

public class CinematicManager
{
  public static CinematicManager Instance = new CinematicManager();
  private List<Film> _films = new List<Film>();

  public void Update(GameTime gameTime)
  {
    if (this._films.Count <= 0)
      return;
    if (!this._films[0].IsActive)
      this._films[0].OnBegin();
    if (!FocusHelper.UpdateVisualEffects || this._films[0].OnUpdate(gameTime))
      return;
    this._films[0].OnEnd();
    this._films.RemoveAt(0);
  }

  public void PlayFilm(Film film) => this._films.Add(film);

  public void StopAll()
  {
  }
}
