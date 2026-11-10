// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Shaders.HairShaderData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.Graphics.Shaders;

public class HairShaderData(Asset<Effect> shader, string passName) : ShaderData(shader, passName)
{
  protected Vector3 _uColor = Vector3.One;
  protected Vector3 _uSecondaryColor = Vector3.One;
  protected float _uSaturation = 1f;
  protected float _uOpacity = 1f;
  protected Asset<Texture2D> _uImage;
  protected bool _shaderDisabled;
  private Vector2 _uTargetPosition = Vector2.One;
  private Effect _effect;
  private ShaderData.EffectParameter<Vector3> uColor;
  private ShaderData.EffectParameter<float> uSaturation;
  private ShaderData.EffectParameter<Vector3> uSecondaryColor;
  private ShaderData.EffectParameter<float> uTime;
  private ShaderData.EffectParameter<float> uOpacity;
  private ShaderData.EffectParameter<float> uDirection;
  private ShaderData.EffectParameter<Vector4> uSourceRect;
  private ShaderData.EffectParameter<Vector2> uDrawPosition;
  private ShaderData.EffectParameter<Vector2> uTargetPosition;
  private ShaderData.EffectParameter<Vector2> uImageSize0;
  private ShaderData.EffectParameter<Vector2> uImageSize1;

  public bool ShaderDisabled => this._shaderDisabled;

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
    this.uDirection = this.Shader.GetParameter<float>("uDirection");
    this.uSourceRect = this.Shader.GetParameter<Vector4>("uSourceRect");
    this.uDrawPosition = this.Shader.GetParameter<Vector2>("uDrawPosition");
    this.uTargetPosition = this.Shader.GetParameter<Vector2>("uTargetPosition");
    this.uImageSize0 = this.Shader.GetParameter<Vector2>("uImageSize0");
    this.uImageSize1 = this.Shader.GetParameter<Vector2>("uImageSize1");
  }

  public virtual void Apply(Player player, DrawData? drawData = null)
  {
    if (this._shaderDisabled)
      return;
    this.CheckCachedParameters();
    this.uColor.SetValue(this._uColor);
    this.uSaturation.SetValue(this._uSaturation);
    this.uSecondaryColor.SetValue(this._uSecondaryColor);
    this.uTime.SetValue(Main.GlobalTimeWrappedHourly);
    this.uOpacity.SetValue(this._uOpacity);
    this.uTargetPosition.SetValue(this._uTargetPosition);
    if (drawData.HasValue)
    {
      DrawData drawData1 = drawData.Value;
      this.uSourceRect.SetValue(new Vector4((float) drawData1.sourceRect.Value.X, (float) drawData1.sourceRect.Value.Y, (float) drawData1.sourceRect.Value.Width, (float) drawData1.sourceRect.Value.Height));
      this.uDrawPosition.SetValue(drawData1.position);
      this.uImageSize0.SetValue(new Vector2((float) drawData1.texture.Width, (float) drawData1.texture.Height));
    }
    else
      this.uSourceRect.SetValue(new Vector4(0.0f, 0.0f, 4f, 4f));
    if (this._uImage != null)
    {
      Main.graphics.GraphicsDevice.Textures[1] = (Texture) this._uImage.Value;
      this.uImageSize1.SetValue(new Vector2((float) this._uImage.Width(), (float) this._uImage.Height()));
    }
    if (player != null)
      this.uDirection.SetValue((float) player.direction);
    this.Apply();
  }

  public virtual Color GetColor(Player player, Color lightColor)
  {
    return new Color(lightColor.ToVector4() * player.hairColor.ToVector4());
  }

  public HairShaderData UseColor(float r, float g, float b) => this.UseColor(new Vector3(r, g, b));

  public HairShaderData UseColor(Color color) => this.UseColor(color.ToVector3());

  public HairShaderData UseColor(Vector3 color)
  {
    this._uColor = color;
    return this;
  }

  public HairShaderData UseImage(string path)
  {
    if (!Main.dedServ)
      this._uImage = Main.Assets.Request<Texture2D>(path, (AssetRequestMode) 1);
    return this;
  }

  public HairShaderData UseOpacity(float alpha)
  {
    this._uOpacity = alpha;
    return this;
  }

  public HairShaderData UseSecondaryColor(float r, float g, float b)
  {
    return this.UseSecondaryColor(new Vector3(r, g, b));
  }

  public HairShaderData UseSecondaryColor(Color color) => this.UseSecondaryColor(color.ToVector3());

  public HairShaderData UseSecondaryColor(Vector3 color)
  {
    this._uSecondaryColor = color;
    return this;
  }

  public HairShaderData UseSaturation(float saturation)
  {
    this._uSaturation = saturation;
    return this;
  }

  public HairShaderData UseTargetPosition(Vector2 position)
  {
    this._uTargetPosition = position;
    return this;
  }
}
