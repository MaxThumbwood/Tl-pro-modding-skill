// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.CameraModifiers.CameraModifierStack
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;

#nullable disable
namespace Terraria.Graphics.CameraModifiers;

public class CameraModifierStack
{
  private List<ICameraModifier> _modifiers = new List<ICameraModifier>();

  public void Add(ICameraModifier modifier)
  {
    this.RemoveIdenticalModifiers(modifier);
    if (!Main.UseScreenShake && modifier.IsAScreenShake)
      return;
    this._modifiers.Add(modifier);
  }

  private void RemoveIdenticalModifiers(ICameraModifier modifier)
  {
    string uniqueIdentity = modifier.UniqueIdentity;
    if (uniqueIdentity == null)
      return;
    for (int index = this._modifiers.Count - 1; index >= 0; --index)
    {
      if (this._modifiers[index].UniqueIdentity == uniqueIdentity)
        this._modifiers.RemoveAt(index);
    }
  }

  public void ApplyTo(ref Vector2 cameraPosition)
  {
    CameraInfo cameraPosition1 = new CameraInfo(cameraPosition);
    this.ClearFinishedModifiers();
    for (int index = 0; index < this._modifiers.Count; ++index)
      this._modifiers[index].Update(ref cameraPosition1);
    cameraPosition = cameraPosition1.CameraPosition;
  }

  private void ClearFinishedModifiers()
  {
    for (int index = this._modifiers.Count - 1; index >= 0; --index)
    {
      if (this._modifiers[index].Finished)
        this._modifiers.RemoveAt(index);
    }
  }
}
