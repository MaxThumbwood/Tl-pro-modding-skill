// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Renderers.ParticleRenderer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

#nullable disable
namespace Terraria.Graphics.Renderers;

public class ParticleRenderer
{
  public ParticleRendererSettings Settings;
  public List<IParticle> Particles = new List<IParticle>();

  public ParticleRenderer() => this.Settings = new ParticleRendererSettings();

  public void Add(IParticle particle) => this.Particles.Add(particle);

  public void Clear()
  {
    for (int index = 0; index < this.Particles.Count; ++index)
    {
      if (this.Particles[index] is IPooledParticle particle)
        particle.RestInPool();
    }
    this.Particles.Clear();
  }

  public void Update()
  {
    for (int index = 0; index < this.Particles.Count; ++index)
    {
      if (this.Particles[index].ShouldBeRemovedFromRenderer)
      {
        if (this.Particles[index] is IPooledParticle particle)
          particle.RestInPool();
        this.Particles.RemoveAt(index);
        --index;
      }
      else
        this.Particles[index].Update(ref this.Settings);
    }
  }

  public void Draw(SpriteBatch spriteBatch)
  {
    TimeLogger.StartTimestamp fromTimestamp = TimeLogger.Start();
    for (int index = 0; index < this.Particles.Count; ++index)
    {
      if (!this.Particles[index].ShouldBeRemovedFromRenderer)
        this.Particles[index].Draw(ref this.Settings, spriteBatch);
    }
    TimeLogger.Particles.AddTime(fromTimestamp);
  }
}
