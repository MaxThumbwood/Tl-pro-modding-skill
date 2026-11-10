// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Shaders.ArmorShaderData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.Graphics.Shaders;

public class ArmorShaderData(Asset<Effect> shader, string passName) : ShaderData(shader, passName)
{
  private Vector3 _uColor = Vector3.One;
  private Vector3 _uSecondaryColor = Vector3.One;
  private float _uSaturation = 1f;
  private float _uOpacity = 1f;
  private Asset<Texture2D> _uImage;
  private Vector2 _uTargetPosition = Vector2.One;
  private Effect _effect;
  private ShaderData.EffectParameter<Vector3> uColor;
  private ShaderData.EffectParameter<float> uSaturation;
  private ShaderData.EffectParameter<Vector3> uSecondaryColor;
  private ShaderData.EffectParameter<float> uTime;
  private ShaderData.EffectParameter<float> uOpacity;
  private ShaderData.EffectParameter<Vector2> uTargetPosition;
  private ShaderData.EffectParameter<Vector4> uSourceRect;
  private ShaderData.EffectParameter<Vector4> uLegacyArmorSourceRect;
  private ShaderData.EffectParameter<Vector2> uLegacyArmorSheetSize;
  private ShaderData.EffectParameter<Vector2> uDrawPosition;
  private ShaderData.EffectParameter<float> uRotation;
  private ShaderData.EffectParameter<float> uDirection;
  private ShaderData.EffectParameter<Vector2> uImageSize0;
  private ShaderData.EffectParameter<Vector2> uImageSize1;

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
    this.uTargetPosition = this.Shader.GetParameter<Vector2>("uTargetPosition");
    this.uSourceRect = this.Shader.GetParameter<Vector4>("uSourceRect");
    this.uLegacyArmorSourceRect = this.Shader.GetParameter<Vector4>("uLegacyArmorSourceRect");
    this.uLegacyArmorSheetSize = this.Shader.GetParameter<Vector2>("uLegacyArmorSheetSize");
    this.uDrawPosition = this.Shader.GetParameter<Vector2>("uDrawPosition");
    this.uRotation = this.Shader.GetParameter<float>("uRotation");
    this.uDirection = this.Shader.GetParameter<float>("uDirection");
    this.uImageSize0 = this.Shader.GetParameter<Vector2>("uImageSize0");
    this.uImageSize1 = this.Shader.GetParameter<Vector2>("uImageSize1");
  }

  public virtual void Apply(Entity entity, DrawData? drawData = null)
  {
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
      Vector4 vector4 = !drawData1.sourceRect.HasValue ? new Vector4(0.0f, 0.0f, (float) drawData1.texture.Width, (float) drawData1.texture.Height) : new Vector4((float) drawData1.sourceRect.Value.X, (float) drawData1.sourceRect.Value.Y, (float) drawData1.sourceRect.Value.Width, (float) drawData1.sourceRect.Value.Height);
      this.uSourceRect.SetValue(vector4);
      this.uLegacyArmorSourceRect.SetValue(vector4);
      this.uDrawPosition.SetValue(drawData1.position);
      this.uImageSize0.SetValue(new Vector2((float) drawData1.texture.Width, (float) drawData1.texture.Height));
      this.uLegacyArmorSheetSize.SetValue(new Vector2((float) drawData1.texture.Width, (float) drawData1.texture.Height));
      this.uRotation.SetValue(drawData1.rotation * ((drawData1.effect & SpriteEffects.FlipHorizontally) != SpriteEffects.None ? -1f : 1f));
      this.uDirection.SetValue((drawData1.effect & SpriteEffects.FlipHorizontally) != SpriteEffects.None ? -1f : 1f);
    }
    else
    {
      Vector4 vector4 = new Vector4(0.0f, 0.0f, 4f, 4f);
      this.uSourceRect.SetValue(vector4);
      this.uLegacyArmorSourceRect.SetValue(vector4);
      this.uRotation.SetValue(0.0f);
    }
    if (this._uImage != null)
    {
      Main.graphics.GraphicsDevice.Textures[1] = (Texture) this._uImage.Value;
      this.uImageSize1.SetValue(new Vector2((float) this._uImage.Width(), (float) this._uImage.Height()));
    }
    if (entity != null)
      this.uDirection.SetValue((float) entity.direction);
    if (entity is Player player)
    {
      Rectangle bodyFrame = player.bodyFrame;
      this.uLegacyArmorSourceRect.SetValue(new Vector4((float) bodyFrame.X, (float) bodyFrame.Y, (float) bodyFrame.Width, (float) bodyFrame.Height));
      this.uLegacyArmorSheetSize.SetValue(new Vector2(40f, 1120f));
    }
    this.Apply();
  }

  public ArmorShaderData UseColor(float r, float g, float b) => this.UseColor(new Vector3(r, g, b));

  public ArmorShaderData UseColor(Color color) => this.UseColor(color.ToVector3());

  public ArmorShaderData UseColor(Vector3 color)
  {
    this._uColor = color;
    return this;
  }

  public ArmorShaderData UseImage(string path)
  {
    if (!Main.dedServ)
      this._uImage = Main.Assets.Request<Texture2D>(path, (AssetRequestMode) 1);
    return this;
  }

  public ArmorShaderData UseOpacity(float alpha)
  {
    this._uOpacity = alpha;
    return this;
  }

  public ArmorShaderData UseTargetPosition(Vector2 position)
  {
    this._uTargetPosition = position;
    return this;
  }

  public ArmorShaderData UseSecondaryColor(float r, float g, float b)
  {
    return this.UseSecondaryColor(new Vector3(r, g, b));
  }

  public ArmorShaderData UseSecondaryColor(Color color)
  {
    return this.UseSecondaryColor(color.ToVector3());
  }

  public ArmorShaderData UseSecondaryColor(Vector3 color)
  {
    this._uSecondaryColor = color;
    return this;
  }

  public ArmorShaderData UseSaturation(float saturation)
  {
    this._uSaturation = saturation;
    return this;
  }

  public virtual ArmorShaderData GetSecondaryShader(Entity entity) => this;
}
