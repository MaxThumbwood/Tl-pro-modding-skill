// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Shaders.ScreenShaderData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

#nullable disable
namespace Terraria.Graphics.Shaders;

public class ScreenShaderData : ShaderData
{
  private Vector3 _uColor = Vector3.One;
  private Vector3 _uSecondaryColor = Vector3.One;
  private float _uOpacity = 1f;
  private float _globalOpacity = 1f;
  private float _uIntensity = 1f;
  private Vector2 _uTargetPosition = Vector2.One;
  private Vector2 _uDirection = new Vector2(0.0f, 1f);
  private float _uProgress;
  private Vector2 _uImageOffset = Vector2.Zero;
  private Vector2 _uSceneSize;
  private Vector2 _uSceneOffset;
  private Vector2 _uImageSize0;
  private Asset<Texture2D>[] _uAssetImages = new Asset<Texture2D>[3];
  private Texture2D[] _uCustomImages = new Texture2D[3];
  private SamplerState[] _samplerStates = new SamplerState[3];
  private Vector2[] _imageScales = new Vector2[3]
  {
    Vector2.One,
    Vector2.One,
    Vector2.One
  };
  public static bool MultiChunkCapture;
  private Effect _effect;
  private ShaderData.EffectParameter<Vector3> uColor;
  private ShaderData.EffectParameter<float> uOpacity;
  private ShaderData.EffectParameter<Vector3> uSecondaryColor;
  private ShaderData.EffectParameter<float> uTime;
  private ShaderData.EffectParameter<Vector2> uScreenResolution;
  private ShaderData.EffectParameter<Vector2> uScreenPosition;
  private ShaderData.EffectParameter<Vector2> uTargetPosition;
  private ShaderData.EffectParameter<Vector2> uImageOffset;
  private ShaderData.EffectParameter<Vector2> uSceneSize;
  private ShaderData.EffectParameter<Vector2> uSceneOffset;
  private ShaderData.EffectParameter<float> uIntensity;
  private ShaderData.EffectParameter<float> uProgress;
  private ShaderData.EffectParameter<Vector2> uDirection;
  private ShaderData.EffectParameter<Vector2> uZoom;
  private ShaderData.EffectParameter<Vector2>[] uImageSize = new ShaderData.EffectParameter<Vector2>[4];
  private ShaderData.EffectParameter<bool> uMultiChunkScene;

  public float Intensity => this._uIntensity;

  public float CombinedOpacity => this._uOpacity * this._globalOpacity;

  public ScreenShaderData(string passName)
    : base(Main.ScreenShaderRef, passName)
  {
  }

  public ScreenShaderData(Asset<Effect> shader, string passName)
    : base(shader, passName)
  {
  }

  public virtual void Update(GameTime gameTime)
  {
  }

  public static Vector2 UnscaledScreenPosition
  {
    get
    {
      Matrix effectMatrix = Main.GameViewMatrix.EffectMatrix;
      Matrix transformationMatrix = Main.GameViewMatrix.TransformationMatrix;
      return Main.screenPosition + new Vector2(effectMatrix.M41 - transformationMatrix.M41, effectMatrix.M42 - transformationMatrix.M42) / new Vector2(transformationMatrix.M11, transformationMatrix.M22);
    }
  }

  public static Vector2 UnscaledScreenSize
  {
    get
    {
      return new Vector2((float) Main.screenWidth, (float) Main.screenHeight) / Main.GameViewMatrix.RenderZoom;
    }
  }

  private void CheckCachedParameters()
  {
    if (this._effect != null && this._effect == this.Shader)
      return;
    this._effect = this.Shader;
    this.uColor = this.Shader.GetParameter<Vector3>("uColor");
    this.uOpacity = this.Shader.GetParameter<float>("uOpacity");
    this.uSecondaryColor = this.Shader.GetParameter<Vector3>("uSecondaryColor");
    this.uTime = this.Shader.GetParameter<float>("uTime");
    this.uScreenResolution = this.Shader.GetParameter<Vector2>("uScreenResolution");
    this.uScreenPosition = this.Shader.GetParameter<Vector2>("uScreenPosition");
    this.uTargetPosition = this.Shader.GetParameter<Vector2>("uTargetPosition");
    this.uImageOffset = this.Shader.GetParameter<Vector2>("uImageOffset");
    this.uSceneSize = this.Shader.GetParameter<Vector2>("uSceneSize");
    this.uSceneOffset = this.Shader.GetParameter<Vector2>("uSceneOffset");
    this.uIntensity = this.Shader.GetParameter<float>("uIntensity");
    this.uProgress = this.Shader.GetParameter<float>("uProgress");
    this.uDirection = this.Shader.GetParameter<Vector2>("uDirection");
    this.uZoom = this.Shader.GetParameter<Vector2>("uZoom");
    this.uMultiChunkScene = this.Shader.GetParameter<bool>("uMultiChunkScene");
    for (int index = 0; index < this.uImageSize.Length; ++index)
      this.uImageSize[index] = this.Shader.GetParameter<Vector2>("uImageSize" + (object) index);
  }

  public override void Apply()
  {
    this.CheckCachedParameters();
    Vector2 vector2 = new Vector2((float) Main.offScreenRange, (float) Main.offScreenRange);
    this.uColor.SetValue(this._uColor);
    this.uOpacity.SetValue(this.CombinedOpacity);
    this.uSecondaryColor.SetValue(this._uSecondaryColor);
    this.uTime.SetValue(Main.GlobalTimeWrappedHourly);
    this.uScreenResolution.SetValue(ScreenShaderData.UnscaledScreenSize);
    this.uScreenPosition.SetValue(ScreenShaderData.UnscaledScreenPosition - vector2);
    this.uTargetPosition.SetValue(this._uTargetPosition - vector2);
    this.uImageOffset.SetValue(this._uImageOffset);
    this.uSceneSize.SetValue(this._uSceneSize);
    this.uSceneOffset.SetValue(this._uSceneOffset);
    this.uIntensity.SetValue(this._uIntensity);
    this.uProgress.SetValue(this._uProgress);
    this.uDirection.SetValue(this._uDirection);
    this.uZoom.SetValue(Main.GameViewMatrix.RenderZoom);
    this.uMultiChunkScene.SetValue(ScreenShaderData.MultiChunkCapture);
    this.uImageSize[0].SetValue(this._uImageSize0);
    for (int index = 0; index < this._uAssetImages.Length; ++index)
    {
      Texture2D uCustomImage = this._uCustomImages[index];
      if (this._uAssetImages[index] != null && this._uAssetImages[index].IsLoaded)
        uCustomImage = this._uAssetImages[index].Value;
      if (uCustomImage != null)
      {
        Main.graphics.GraphicsDevice.Textures[index + 1] = (Texture) uCustomImage;
        int width = uCustomImage.Width;
        int height = uCustomImage.Height;
        Main.graphics.GraphicsDevice.SamplerStates[index + 1] = this._samplerStates[index] == null ? (!Utils.IsPowerOfTwo(width) || !Utils.IsPowerOfTwo(height) ? SamplerState.AnisotropicClamp : SamplerState.LinearWrap) : this._samplerStates[index];
        this.uImageSize[index + 1].SetValue(new Vector2((float) width, (float) height) * this._imageScales[index]);
      }
    }
    base.Apply();
  }

  public ScreenShaderData UseImageOffset(Vector2 offset)
  {
    this._uImageOffset = offset;
    return this;
  }

  public ScreenShaderData UseIntensity(float intensity)
  {
    this._uIntensity = intensity;
    return this;
  }

  public ScreenShaderData UseColor(float r, float g, float b)
  {
    return this.UseColor(new Vector3(r, g, b));
  }

  public ScreenShaderData UseProgress(float progress)
  {
    this._uProgress = progress;
    return this;
  }

  public ScreenShaderData UseImage(Texture2D image, int index = 0, SamplerState samplerState = null)
  {
    this._samplerStates[index] = samplerState;
    this._uAssetImages[index] = (Asset<Texture2D>) null;
    this._uCustomImages[index] = image;
    return this;
  }

  public ScreenShaderData UseImage(string path, int index = 0, SamplerState samplerState = null)
  {
    this._uAssetImages[index] = Main.Assets.Request<Texture2D>(path, (AssetRequestMode) 1);
    this._uCustomImages[index] = (Texture2D) null;
    this._samplerStates[index] = samplerState;
    return this;
  }

  public ScreenShaderData UseSceneSize(Vector2 size)
  {
    this._uSceneSize = size;
    return this;
  }

  public ScreenShaderData UseSceneOffset(Vector2 size)
  {
    this._uSceneOffset = size;
    return this;
  }

  public ScreenShaderData UseImageSize0(Vector2 size)
  {
    this._uImageSize0 = size;
    return this;
  }

  public ScreenShaderData UseColor(Color color) => this.UseColor(color.ToVector3());

  public ScreenShaderData UseColor(Vector3 color)
  {
    this._uColor = color;
    return this;
  }

  public ScreenShaderData UseDirection(Vector2 direction)
  {
    this._uDirection = direction;
    return this;
  }

  public ScreenShaderData UseGlobalOpacity(float opacity)
  {
    this._globalOpacity = opacity;
    return this;
  }

  public ScreenShaderData UseTargetPosition(Vector2 position)
  {
    this._uTargetPosition = position;
    return this;
  }

  public ScreenShaderData UseSecondaryColor(float r, float g, float b)
  {
    return this.UseSecondaryColor(new Vector3(r, g, b));
  }

  public ScreenShaderData UseSecondaryColor(Color color)
  {
    return this.UseSecondaryColor(color.ToVector3());
  }

  public ScreenShaderData UseSecondaryColor(Vector3 color)
  {
    this._uSecondaryColor = color;
    return this;
  }

  public ScreenShaderData UseOpacity(float opacity)
  {
    this._uOpacity = opacity;
    return this;
  }

  public ScreenShaderData UseImageScale(Vector2 scale, int index = 0)
  {
    this._imageScales[index] = scale;
    return this;
  }

  public virtual ScreenShaderData GetSecondaryShader(Player player) => this;
}
