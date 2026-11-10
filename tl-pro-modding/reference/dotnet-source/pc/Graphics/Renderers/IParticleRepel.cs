// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Renderers.IParticleRepel
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Graphics.Renderers;

public interface IParticleRepel : IParticle
{
  void BeRepelled(ref ParticleRepelDetails details);
}
