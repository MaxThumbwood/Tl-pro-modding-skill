// Decompiled with JetBrains decompiler
// Type: Terraria.Audio.CustomSoundStyle
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Audio;
using Terraria.Utilities;

#nullable disable
namespace Terraria.Audio;

public class CustomSoundStyle : SoundStyle
{
  private static readonly UnifiedRandom Random = new UnifiedRandom();
  private readonly SoundEffect[] _soundEffects;

  public override bool IsTrackable => true;

  public override int MaxTrackedInstances => 0;

  public CustomSoundStyle(
    SoundEffect soundEffect,
    SoundType type = SoundType.Sound,
    float volume = 1f,
    float pitchVariance = 0.0f)
    : base(volume, pitchVariance, type)
  {
    this._soundEffects = new SoundEffect[1]{ soundEffect };
  }

  public CustomSoundStyle(
    SoundEffect[] soundEffects,
    SoundType type = SoundType.Sound,
    float volume = 1f,
    float pitchVariance = 0.0f)
    : base(volume, pitchVariance, type)
  {
    this._soundEffects = soundEffects;
  }

  public override SoundEffect GetRandomSound()
  {
    return this._soundEffects[CustomSoundStyle.Random.Next(this._soundEffects.Length)];
  }
}
