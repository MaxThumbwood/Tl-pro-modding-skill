// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Renderers.StormLightningParticle
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Terraria.GameContent;
using Terraria.GameContent.Drawing;
using Terraria.Utilities;

#nullable disable
namespace Terraria.Graphics.Renderers;

public class StormLightningParticle : IPooledParticle, IParticle
{
  public Color Color;
  public Vector2 EndPosition;
  public Vector2 StartPosition;
  private List<LightningGenerator.Bolt> bolts = new List<LightningGenerator.Bolt>();
  private int _lifeTimeCounted;
  private int _lifeTimeTotal;

  public bool ShouldBeRemovedFromRenderer { get; private set; }

  public bool IsRestingInPool { get; private set; }

  public void RestInPool() => this.IsRestingInPool = true;

  public virtual void FetchFromPool()
  {
    this._lifeTimeCounted = 0;
    this._lifeTimeTotal = 0;
    this.IsRestingInPool = false;
    this.ShouldBeRemovedFromRenderer = false;
    this.bolts.Clear();
  }

  public void Prepare(uint seed, Vector2 targetPosition, int lifeTimeTotal, Color color)
  {
    this.Color = color;
    this._lifeTimeTotal = lifeTimeTotal;
    LightningGenerator.Bolt bolt = LightningGenerator.StormLightning.Generate(this.bolts, seed, targetPosition);
    this.StartPosition = bolt.positions[0];
    this.EndPosition = bolt.positions[bolt.positions.Length - 1];
    LCG32Random lcG32Random = new LCG32Random(seed);
    int maxValue = (int) Math.Ceiling((double) bolt.positions.Length / 10.0);
    for (int index = 0; index < bolt.positions.Length; ++index)
    {
      if (lcG32Random.Next(maxValue) == 0)
      {
        Vector2 position = bolt.positions[index];
        Vector2 vector2 = Vector2.UnitY;
        if (bolt.rotations != null)
          vector2 = -bolt.rotations[index].ToRotationVector2();
        Vector2? Velocity = new Vector2?();
        Color newColor = new Color();
        Dust rf = Dust.NewDustPerfect(position, 226, Velocity, newColor: newColor);
        rf.HackFrame(278);
        rf.color = color;
        rf.customData = (object) rf.color;
        rf.velocity = vector2;
        rf.velocity *= (float) (3.0 + (double) lcG32Random.NextFloat() * 6.5);
        rf.fadeIn = 0.0f;
        rf.scale = (float) (0.40000000596046448 + (double) lcG32Random.NextFloat() * 0.5);
        rf.noGravity = true;
        rf.position -= rf.velocity * 6f;
        Dust.CloneDust(rf).velocity *= 0.5f;
        rf.scale -= 0.3f;
      }
    }
  }

  public void Update(ref ParticleRendererSettings settings)
  {
    Color color = new Color(80 /*0x50*/, 220, 220);
    double fromValue = (double) this._lifeTimeCounted / (double) this._lifeTimeTotal;
    float num1 = Utils.Remap((float) fromValue, 0.0f, 0.4f, 1f, 0.0f);
    if (fromValue < 0.30000001192092896)
      ParticleOrchestrator.RequestParticleSpawn(true, ParticleOrchestraType.StormlightningWindup, new ParticleOrchestraSettings()
      {
        PositionInWorld = this.StartPosition,
        MovementVector = Vector2.Zero,
        UniqueInfoPiece = (int) color.PackedValue
      });
    for (int index = 0; index < 3; ++index)
    {
      if (Main.rand.Next(4) == 0 && (double) Main.rand.NextFloat() <= (double) num1 * 0.12999999523162842)
      {
        Dust rf = Dust.NewDustDirect(this.StartPosition, 16 /*0x10*/, 16 /*0x10*/, 306, newColor: new Color((int) color.R, (int) color.G, (int) color.B, 0));
        rf.velocity = new Vector2(0.0f, -4f).RotatedByRandom(1.5707963705062866) * (float) (0.5 + 0.20000000298023224 * (double) Main.rand.NextFloatDirection());
        rf.scale = 1.8f;
        rf.fadeIn = 0.0f;
        rf.noGravity = Main.rand.Next(3) != 0;
        int num2;
        bool flag = (num2 = 1) != 0;
        rf.noLightEmittence = num2 != 0;
        rf.noLight = flag;
        Dust dust = Dust.CloneDust(rf);
        dust.color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
        dust.scale = 1.3f;
      }
    }
    for (int index = -1; index <= 1; index += 2)
    {
      if (Main.rand.Next(4) == 0 && (double) Main.rand.NextFloat() <= (double) num1 * 0.20000000298023224)
      {
        Dust rf = Dust.NewDustPerfect(this.StartPosition, 306, new Vector2?(new Vector2(0.0f, -4f).RotatedBy(0.78539818525314331 * (double) index * 1.0)));
        rf.color = new Color((int) color.R, (int) color.G, (int) color.B, 0);
        rf.scale = 1.8f;
        rf.fadeIn = 0.0f;
        rf.noGravity = Main.rand.Next(3) != 0;
        int num3;
        bool flag = (num3 = 1) != 0;
        rf.noLightEmittence = num3 != 0;
        rf.noLight = flag;
        Dust dust = Dust.CloneDust(rf);
        dust.color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
        dust.scale = 1.3f;
      }
    }
    for (int index = 0; index < 2; ++index)
    {
      if (Main.rand.Next(4) == 0 && (double) Main.rand.NextFloat() <= 0.20000000298023224)
      {
        Dust dust = Dust.NewDustPerfect(this.StartPosition, 226);
        dust.HackFrame(278);
        dust.color = color;
        dust.customData = (object) dust.color;
        dust.velocity *= (float) (1.0 + (double) Main.rand.NextFloat() * 2.5);
        dust.velocity += new Vector2(0.0f, -2f);
        dust.fadeIn = 0.0f;
        dust.scale = (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.5);
        dust.velocity.X *= 2f;
        dust.velocity = Main.rand.NextVector2Circular(3f, 2f) + new Vector2(0.0f, -2f);
        dust.noLight = dust.noLightEmittence = true;
        dust.position -= dust.velocity * 3f;
      }
    }
    if (++this._lifeTimeCounted < this._lifeTimeTotal)
      return;
    this.ShouldBeRemovedFromRenderer = true;
  }

  public void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
  {
    StormLightningDrawer stormLightningDrawer = new StormLightningDrawer();
    foreach (LightningGenerator.Bolt bolt in this.bolts)
    {
      float intensity = bolt.IsMainBolt ? 1f : (float) (0.5 * Math.Pow(0.8, (double) (bolt.forkDepth - 1)));
      stormLightningDrawer.Draw(bolt.positions, bolt.rotations, 16f, this.Color, (float) this._lifeTimeCounted / (float) this._lifeTimeTotal, bolt.IsMainBolt, bolt.progressRange, intensity);
    }
  }
}
