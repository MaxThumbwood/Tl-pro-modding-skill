// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Shaders.ShaderData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable disable
namespace Terraria.Graphics.Shaders;

public class ShaderData
{
  private readonly Asset<Effect> _shader;
  private readonly string _passName;
  private Effect _effect;
  private EffectPass _effectPass;

  public Effect Shader => this._shader != null ? this._shader.Value : (Effect) null;

  public ShaderData(Asset<Effect> shader, string passName)
  {
    this._passName = passName;
    this._shader = shader;
  }

  public virtual void Apply()
  {
    if (this._effect == null || this._effect != this.Shader)
    {
      this._effect = this.Shader;
      this._effectPass = this.Shader.CurrentTechnique.Passes[this._passName];
    }
    this._effectPass.Apply();
  }

  public class EffectParameter<T>
  {
    private readonly Action<T> _setValue;
    private T _value;
    private bool _hasValue;
    private static ConditionalWeakTable<EffectParameter, object> _cachedParameters = new ConditionalWeakTable<EffectParameter, object>();

    private EffectParameter(Action<T> setValue) => this._setValue = setValue;

    public void SetValue(T value)
    {
      if (this._hasValue && EqualityComparer<T>.Default.Equals(this._value, value))
        return;
      this._hasValue = true;
      this._value = value;
      this._setValue(value);
    }

    public static ShaderData.EffectParameter<T> Get(EffectParameter param)
    {
      return param == null ? (ShaderData.EffectParameter<T>) null : (ShaderData.EffectParameter<T>) ShaderData.EffectParameter<T>._cachedParameters.GetValue(param, new ConditionalWeakTable<EffectParameter, object>.CreateValueCallback(ShaderData.EffectParameter<T>._Create));
    }

    private static object _Create(EffectParameter param)
    {
      return (typeof (T) == typeof (Matrix) ? (object) new ShaderData.EffectParameter<Matrix>(new Action<Matrix>(param.SetValue)) : (typeof (T) == typeof (Quaternion) ? (object) new ShaderData.EffectParameter<Quaternion>(new Action<Quaternion>(param.SetValue)) : (typeof (T) == typeof (Vector4) ? (object) new ShaderData.EffectParameter<Vector4>(new Action<Vector4>(param.SetValue)) : (typeof (T) == typeof (Vector3) ? (object) new ShaderData.EffectParameter<Vector3>(new Action<Vector3>(param.SetValue)) : (typeof (T) == typeof (Vector2) ? (object) new ShaderData.EffectParameter<Vector2>(new Action<Vector2>(param.SetValue)) : (typeof (T) == typeof (float) ? (object) new ShaderData.EffectParameter<float>(new Action<float>(param.SetValue)) : (typeof (T) == typeof (int) ? (object) new ShaderData.EffectParameter<int>(new Action<int>(param.SetValue)) : (typeof (T) == typeof (bool) ? (object) new ShaderData.EffectParameter<bool>(new Action<bool>(param.SetValue)) : (typeof (T) == typeof (string) ? (object) new ShaderData.EffectParameter<string>(new Action<string>(param.SetValue)) : (typeof (T) == typeof (Texture) ? (object) new ShaderData.EffectParameter<Texture>(new Action<Texture>(param.SetValue)) : (object) null)))))))))) ?? throw new ArgumentOutOfRangeException("Unsupported type: " + (object) typeof (T));
    }
  }
}
