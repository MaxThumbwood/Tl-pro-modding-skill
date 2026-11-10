// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Renderers.ParticlePool`1
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace Terraria.Graphics.Renderers;

public class ParticlePool<T> where T : IPooledParticle
{
  private ParticlePool<T>.ParticleInstantiator _instantiator;
  private List<T> _particles;

  public int CountParticlesInUse()
  {
    int num = 0;
    for (int index = 0; index < num; ++index)
    {
      if (!this._particles[index].IsRestingInPool)
        ++num;
    }
    return num;
  }

  public ParticlePool(int initialPoolSize, ParticlePool<T>.ParticleInstantiator instantiator)
  {
    this._particles = new List<T>(initialPoolSize);
    this._instantiator = instantiator;
  }

  public T RequestParticle()
  {
    if (Main.NoPooling)
      this._particles.RemoveAll((Predicate<T>) (p => p.IsRestingInPool));
    int count = this._particles.Count;
    for (int index = 0; index < count; ++index)
    {
      if (this._particles[index].IsRestingInPool)
      {
        this._particles[index].FetchFromPool();
        return this._particles[index];
      }
    }
    T obj = this._instantiator();
    this._particles.Add(obj);
    obj.FetchFromPool();
    return obj;
  }

  public delegate T ParticleInstantiator() where T : IPooledParticle;
}
