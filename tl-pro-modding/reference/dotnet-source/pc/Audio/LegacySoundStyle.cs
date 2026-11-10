// Decompiled with JetBrains decompiler
// Type: Terraria.Audio.LegacySoundStyle
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Audio;
using Terraria.Utilities;

#nullable disable
namespace Terraria.Audio;

public class LegacySoundStyle : SoundStyle
{
  private static readonly UnifiedRandom Random = new UnifiedRandom();
  private readonly int _style;
  public readonly int Variations;
  public readonly int SoundId;
  public readonly int _maxTrackedInstances;

  public int Style
  {
    get
    {
      return this.Variations != 1 ? LegacySoundStyle.Random.Next(this._style, this._style + this.Variations) : this._style;
    }
  }

  public override bool IsTrackable => this.SoundId == 42;

  public override int MaxTrackedInstances => this._maxTrackedInstances;

  public LegacySoundStyle(int soundId, int style, SoundType type = SoundType.Sound, int maxTrackedInstances = 0)
    : base(type)
  {
    this._style = style;
    this.Variations = 1;
    this.SoundId = soundId;
    this._maxTrackedInstances = maxTrackedInstances;
  }

  public LegacySoundStyle(
    int soundId,
    int style,
    int variations,
    SoundType type = SoundType.Sound,
    int maxTrackedInstances = 0)
    : base(type)
  {
    this._style = style;
    this.Variations = variations;
    this.SoundId = soundId;
    this._maxTrackedInstances = maxTrackedInstances;
  }

  private LegacySoundStyle(
    int soundId,
    int style,
    int variations,
    SoundType type,
    float volume,
    float pitchVariance,
    int maxTrackedInstances)
    : base(volume, pitchVariance, type)
  {
    this._style = style;
    this.Variations = variations;
    this.SoundId = soundId;
    this._maxTrackedInstances = maxTrackedInstances;
  }

  public LegacySoundStyle WithVolume(float volume)
  {
    return new LegacySoundStyle(this.SoundId, this._style, this.Variations, this.Type, volume, this.PitchVariance, this.MaxTrackedInstances);
  }

  public LegacySoundStyle WithPitchVariance(float pitchVariance)
  {
    return new LegacySoundStyle(this.SoundId, this._style, this.Variations, this.Type, this.Volume, pitchVariance, this.MaxTrackedInstances);
  }

  public LegacySoundStyle AsMusic()
  {
    return new LegacySoundStyle(this.SoundId, this._style, this.Variations, SoundType.Music, this.Volume, this.PitchVariance, this.MaxTrackedInstances);
  }

  public LegacySoundStyle AsAmbient()
  {
    return new LegacySoundStyle(this.SoundId, this._style, this.Variations, SoundType.Ambient, this.Volume, this.PitchVariance, this.MaxTrackedInstances);
  }

  public LegacySoundStyle AsSound()
  {
    return new LegacySoundStyle(this.SoundId, this._style, this.Variations, SoundType.Sound, this.Volume, this.PitchVariance, this.MaxTrackedInstances);
  }

  public bool Includes(int soundId, int style)
  {
    return this.SoundId == soundId && style >= this._style && style < this._style + this.Variations;
  }

  public override SoundEffect GetRandomSound()
  {
    return this.IsTrackable ? SoundEngine.GetTrackableSoundByStyleId(this.Style) : (SoundEffect) null;
  }
}
