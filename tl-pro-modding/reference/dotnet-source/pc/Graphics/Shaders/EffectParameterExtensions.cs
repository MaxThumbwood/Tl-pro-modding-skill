// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Shaders.EffectParameterExtensions
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.Graphics.Shaders;

public static class EffectParameterExtensions
{
  public static ShaderData.EffectParameter<T> GetParameter<T>(this Effect effect, string name)
  {
    return ShaderData.EffectParameter<T>.Get(effect.Parameters[name]);
  }
}
