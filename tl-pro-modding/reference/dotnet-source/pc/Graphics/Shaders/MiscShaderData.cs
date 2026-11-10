// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Shaders.MiscShaderData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.Graphics.Shaders;

public class MiscShaderData(Asset<Effect> shader, string passName) : ShaderData(shader, passName)
{
  private Vector3 _uColor = Vector3.One;
  private Vector3 _uSecondaryColor = Vector3.One;
  private float _uSaturation = 1f;
  private float _uOpacity = 1f;
  private Asset<Texture2D> _uImage0;
  private Asset<Texture2D> _uImage1;
  private Asset<Texture2D> _uImage2;
  private Texture _uImage0Tex;
  private Texture _uImage1Tex;
  private Texture _uImage2Tex;
  private bool _useProjectionMatrix;
  private Vector4 _shaderSpecificData = Vector4.Zero;
  private SamplerState _customSamplerState;
  private Matrix? _transformMatrix;
  private Effect _effect;
  private ShaderData.EffectParameter<Vector3> uColor;
  private ShaderData.EffectParameter<float> uSaturation;
  private ShaderData.EffectParameter<Vector3> uSecondaryColor;
  private ShaderData.EffectParameter<float> uTime;
  private ShaderData.EffectParameter<float> uOpacity;
  private ShaderData.EffectParameter<Vector4> uShaderSpecificData;
  private ShaderData.EffectParameter<Vector4> uSourceRect;
  private ShaderData.EffectParameter<Vector2> uDrawPosition;
  private ShaderData.EffectParameter<Vector2> uImageSize0;
  private ShaderData.EffectParameter<Vector2> uImageSize1;
  private ShaderData.EffectParameter<Vector2> uImageSize2;
  private ShaderData.EffectParameter<Matrix> MatrixTransform;

  private void CheckCachedParameters()
  {
    if (this._effect != null && this._effect == this.Shader)
      return;
    this._effect = this.Shader;
    this.uColor = this.Shader.GetParameter<Vector3>("uColor");
    this.uSaturation = this.Shader.GetParameter<float>("uSaturation");
    this.uSecondaryColor = this.Shader.GetParameter<Vector3>("uSecondaryColor");
    this.uTime = this.Shader.GetParameter<float>("uTime");
    this.uOpacity = this.Shader.GetParameter<float>("uOpacity");
    this.uShaderSpecificData = this.Shader.GetParameter<Vector4>("uShaderSpecificData");
    this.uSourceRect = this.Shader.GetParameter<Vector4>("uSourceRect");
    this.uDrawPosition = this.Shader.GetParameter<Vector2>("uDrawPosition");
    this.uImageSize0 = this.Shader.GetParameter<Vector2>("uImageSize0");
    this.uImageSize1 = this.Shader.GetParameter<Vector2>("uImageSize1");
    this.uImageSize2 = this.Shader.GetParameter<Vector2>("uImageSize2");
    this.MatrixTransform = this.Shader.GetParameter<Matrix>("MatrixTransform");
  }

  public virtual void Apply(DrawData? drawData = null)
  {
    this.CheckCachedParameters();
    this.uColor.SetValue(this._uColor);
    this.uSaturation.SetValue(this._uSaturation);
    this.uSecondaryColor.SetValue(this._uSecondaryColor);
    this.uTime.SetValue(Main.GlobalTimeWrappedHourly);
    this.uOpacity.SetValue(this._uOpacity);
    this.uShaderSpecificData.SetValue(this._shaderSpecificData);
    if (drawData.HasValue)
    {
      DrawData drawData1 = drawData.Value;
      Vector4 vector4 = Vector4.Zero;
      if (drawData.Value.sourceRect.HasValue)
        vector4 = new Vector4((float) drawData1.sourceRect.Value.X, (float) drawData1.sourceRect.Value.Y, (float) drawData1.sourceRect.Value.Width, (float) drawData1.sourceRect.Value.Height);
      this.uSourceRect.SetValue(vector4);
      this.uDrawPosition.SetValue(drawData1.position);
      this.uImageSize0.SetValue(new Vector2((float) drawData1.texture.Width, (float) drawData1.texture.Height));
    }
    else
      this.uSourceRect.SetValue(new Vector4(0.0f, 0.0f, 4f, 4f));
    SamplerState samplerState = SamplerState.LinearWrap;
    if (this._customSamplerState != null)
      samplerState = this._customSamplerState;
    Texture tex1 = this._uImage0 != null ? (Texture) this._uImage0.Value : this._uImage0Tex;
    if (tex1 != null)
    {
      Main.graphics.GraphicsDevice.Textures[0] = tex1;
      Main.graphics.GraphicsDevice.SamplerStates[0] = samplerState;
      if (tex1 is Texture2D)
        this.uImageSize0.SetValue(((Texture2D) tex1).Size());
    }
    Texture tex2 = this._uImage1 != null ? (Texture) this._uImage1.Value : this._uImage1Tex;
    if (tex2 != null)
    {
      Main.graphics.GraphicsDevice.Textures[1] = tex2;
      Main.graphics.GraphicsDevice.SamplerStates[1] = samplerState;
      if (tex2 is Texture2D)
        this.uImageSize1.SetValue(((Texture2D) tex2).Size());
    }
    Texture tex3 = this._uImage2 != null ? (Texture) this._uImage2.Value : this._uImage2Tex;
    if (tex3 != null)
    {
      Main.graphics.GraphicsDevice.Textures[2] = tex3;
      Main.graphics.GraphicsDevice.SamplerStates[2] = samplerState;
      if (tex3 is Texture2D)
        this.uImageSize2.SetValue(((Texture2D) tex3).Size());
    }
    if (this._useProjectionMatrix)
      this.MatrixTransform.SetValue(Main.GameViewMatrix.NormalizedTransformationMatrix);
    if (this._transformMatrix.HasValue)
      this.MatrixTransform.SetValue(this._transformMatrix.Value);
    this.Apply();
  }

  public MiscShaderData UseColor(float r, float g, float b) => this.UseColor(new Vector3(r, g, b));

  public MiscShaderData UseColor(Color color) => this.UseColor(color.ToVector3());

  public MiscShaderData UseColor(Vector3 color)
  {
    this._uColor = color;
    return this;
  }

  public MiscShaderData UseSamplerState(SamplerState state)
  {
    this._customSamplerState = state;
    return this;
  }

  public MiscShaderData UseImage0(string path)
  {
    if (Main.dedServ)
      return this;
    this._uImage0Tex = (Texture) null;
    this._uImage0 = Main.Assets.Request<Texture2D>(path, (AssetRequestMode) 1);
    return this;
  }

  public MiscShaderData UseImage1(string path)
  {
    if (Main.dedServ)
      return this;
    this._uImage1Tex = (Texture) null;
    this._uImage1 = Main.Assets.Request<Texture2D>(path, (AssetRequestMode) 1);
    return this;
  }

  public MiscShaderData UseImage2(string path)
  {
    if (Main.dedServ)
      return this;
    this._uImage2Tex = (Texture) null;
    this._uImage2 = Main.Assets.Request<Texture2D>(path, (AssetRequestMode) 1);
    return this;
  }

  public MiscShaderData UseImage0(Texture texture)
  {
    if (Main.dedServ)
      return this;
    this._uImage0Tex = texture;
    this._uImage0 = (Asset<Texture2D>) null;
    return this;
  }

  public MiscShaderData UseImage1(Texture texture)
  {
    if (Main.dedServ)
      return this;
    this._uImage1Tex = texture;
    this._uImage1 = (Asset<Texture2D>) null;
    return this;
  }

  public MiscShaderData UseImage2(Texture texture)
  {
    if (Main.dedServ)
      return this;
    this._uImage2Tex = texture;
    this._uImage2 = (Asset<Texture2D>) null;
    return this;
  }

  private static bool IsPowerOfTwo(int n)
  {
    return (int) Math.Ceiling(Math.Log((double) n) / Math.Log(2.0)) == (int) Math.Floor(Math.Log((double) n) / Math.Log(2.0));
  }

  public MiscShaderData UseOpacity(float alpha)
  {
    this._uOpacity = alpha;
    return this;
  }

  public MiscShaderData UseSecondaryColor(float r, float g, float b)
  {
    return this.UseSecondaryColor(new Vector3(r, g, b));
  }

  public MiscShaderData UseSecondaryColor(Color color) => this.UseSecondaryColor(color.ToVector3());

  public MiscShaderData UseSecondaryColor(Vector3 color)
  {
    this._uSecondaryColor = color;
    return this;
  }

  public MiscShaderData UseProjectionMatrix(bool doUse)
  {
    this._useProjectionMatrix = doUse;
    return this;
  }

  public MiscShaderData UseSpriteTransformMatrix(Matrix? transform)
  {
    if (!transform.HasValue)
    {
      this._transformMatrix = new Matrix?();
      return this;
    }
    Viewport viewport = Main.graphics.GraphicsDevice.Viewport;
    float num1 = viewport.Width > 0 ? 1f / (float) viewport.Width : 0.0f;
    float num2 = viewport.Height > 0 ? -1f / (float) viewport.Height : 0.0f;
    Matrix matrix = new Matrix()
    {
      M11 = num1 * 2f,
      M22 = num2 * 2f,
      M33 = 1f,
      M44 = 1f,
      M41 = -1f - num1,
      M42 = 1f - num2
    };
    this._transformMatrix = new Matrix?(transform.Value * matrix);
    return this;
  }

  public MiscShaderData UseSaturation(float saturation)
  {
    this._uSaturation = saturation;
    return this;
  }

  public virtual MiscShaderData GetSecondaryShader(Entity entity) => this;

  public MiscShaderData UseShaderSpecificData(Vector4 specificData)
  {
    this._shaderSpecificData = specificData;
    return this;
  }
}
