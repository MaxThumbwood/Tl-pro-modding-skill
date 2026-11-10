// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Renderers.IParticle
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.Graphics.Renderers;

public interface IParticle
{
  bool ShouldBeRemovedFromRenderer { get; }

  void Update(ref ParticleRendererSettings settings);

  void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch);
}
