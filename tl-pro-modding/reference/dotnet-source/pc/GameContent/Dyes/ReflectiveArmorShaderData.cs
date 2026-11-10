// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Dyes.ReflectiveArmorShaderData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

#nullable disable
namespace Terraria.GameContent.Dyes;

public class ReflectiveArmorShaderData(Asset<Effect> shader, string passName) : ArmorShaderData(shader, passName)
{
  private Effect _effect;
  private ShaderData.EffectParameter<Vector3> uLightSource;

  private void CheckCachedParameters()
  {
    if (this._effect != null && this._effect == this.Shader)
      return;
    this._effect = this.Shader;
    this.uLightSource = this.Shader.GetParameter<Vector3>("uLightSource");
  }

  public override void Apply(Entity entity, DrawData? drawData)
  {
    this.CheckCachedParameters();
    if (entity == null)
    {
      this.uLightSource.SetValue(Vector3.Zero);
    }
    else
    {
      float num1 = 0.0f;
      if (drawData.HasValue)
        num1 = drawData.Value.rotation;
      Vector2 position = entity.position;
      float width = (float) entity.width;
      float height = (float) entity.height;
      Vector2 vector2_1 = new Vector2(width, height) * 0.1f;
      Vector2 vector2_2 = position + vector2_1;
      float x = width * 0.8f;
      float y = height * 0.8f;
      Vector3 subLight1 = Lighting.GetSubLight(vector2_2 + new Vector2(x * 0.5f, 0.0f));
      Vector3 subLight2 = Lighting.GetSubLight(vector2_2 + new Vector2(0.0f, y * 0.5f));
      Vector3 subLight3 = Lighting.GetSubLight(vector2_2 + new Vector2(x, y * 0.5f));
      Vector3 subLight4 = Lighting.GetSubLight(vector2_2 + new Vector2(x * 0.5f, y));
      float num2 = subLight1.X + subLight1.Y + subLight1.Z;
      float num3 = subLight2.X + subLight2.Y + subLight2.Z;
      float num4 = subLight3.X + subLight3.Y + subLight3.Z;
      float num5 = subLight4.X + subLight4.Y + subLight4.Z;
      Vector2 spinningpoint = new Vector2(num4 - num3, num5 - num2);
      if ((double) spinningpoint.Length() > 1.0)
      {
        float num6 = 1f;
        spinningpoint /= num6;
      }
      if (entity.direction == -1)
        spinningpoint.X *= -1f;
      spinningpoint = spinningpoint.RotatedBy(-(double) num1);
      Vector3 vector3 = new Vector3(spinningpoint, (float) (1.0 - ((double) spinningpoint.X * (double) spinningpoint.X + (double) spinningpoint.Y * (double) spinningpoint.Y)));
      vector3.X *= 2f;
      vector3.Y -= 0.15f;
      vector3.Y *= 2f;
      vector3.Normalize();
      vector3.Z *= 0.6f;
      this.uLightSource.SetValue(vector3);
    }
    base.Apply(entity, drawData);
  }
}
