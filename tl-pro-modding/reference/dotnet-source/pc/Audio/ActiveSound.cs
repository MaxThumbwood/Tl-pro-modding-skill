// Decompiled with JetBrains decompiler
// Type: Terraria.Audio.ActiveSound
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

#nullable disable
namespace Terraria.Audio;

public class ActiveSound
{
  public readonly bool IsGlobal;
  public Vector2 Position;
  public float Volume;
  public float Pitch;
  public ActiveSound.LoopedPlayCondition Condition;

  public SoundEffectInstance Sound { get; private set; }

  public SoundStyle Style { get; private set; }

  public bool IsPlaying => this.Sound != null && this.Sound.State == SoundState.Playing;

  private void UseOverrides(SoundPlayOverrides overrides)
  {
    if (!overrides.Volume.HasValue)
      return;
    this.Volume = overrides.Volume.Value;
  }

  public ActiveSound(SoundStyle style, Vector2 position, SoundPlayOverrides overrides)
  {
    this.Position = position;
    this.Volume = 1f;
    this.Pitch = style.PitchVariance;
    this.IsGlobal = false;
    this.Style = style;
    this.UseOverrides(overrides);
    this.Play();
  }

  public ActiveSound(SoundStyle style)
  {
    this.Position = Vector2.Zero;
    this.Volume = 1f;
    this.Pitch = style.PitchVariance;
    this.IsGlobal = true;
    this.Style = style;
    this.Play();
  }

  public ActiveSound(
    SoundStyle style,
    Vector2 position,
    ActiveSound.LoopedPlayCondition condition,
    SoundPlayOverrides overrides)
  {
    this.Position = position;
    this.Volume = 1f;
    this.Pitch = style.PitchVariance;
    this.IsGlobal = false;
    this.Style = style;
    this.UseOverrides(overrides);
    this.PlayLooped(condition);
  }

  private void Play()
  {
    SoundEffectInstance instance = this.Style.GetRandomSound().CreateInstance();
    this.Sound = instance;
    instance.Pitch += this.Style.GetRandomPitch();
    this.Pitch = instance.Pitch;
    instance.Volume = this.DetermineIntendedVolume();
    instance.Play();
    SoundInstanceGarbageCollector.Track(instance);
    this.Update();
  }

  private void PlayLooped(ActiveSound.LoopedPlayCondition condition)
  {
    SoundEffectInstance instance = this.Style.GetRandomSound().CreateInstance();
    this.Sound = instance;
    instance.Pitch += this.Style.GetRandomPitch();
    this.Pitch = instance.Pitch;
    instance.IsLooped = true;
    this.Condition = condition;
    instance.Play();
    SoundInstanceGarbageCollector.Track(instance);
    this.Update();
  }

  public void Stop()
  {
    if (this.Sound == null)
      return;
    this.Sound.Stop();
  }

  public void Pause()
  {
    if (this.Sound == null || this.Sound.State != SoundState.Playing)
      return;
    this.Sound.Pause();
  }

  public void Resume()
  {
    if (this.Sound == null || this.Sound.State != SoundState.Paused)
      return;
    this.Sound.Resume();
  }

  public void Update()
  {
    if (this.Sound == null)
      return;
    if (this.Condition != null && !this.Condition())
    {
      this.Sound.Stop(true);
    }
    else
    {
      this.Sound.Volume = this.DetermineIntendedVolume();
      this.Sound.Pitch = this.Pitch;
    }
  }

  private float DetermineIntendedVolume()
  {
    float num1 = 1f;
    if (!this.IsGlobal)
    {
      Vector2 vector2 = this.Position - Main.Camera.Center;
      this.Sound.Pan = MathHelper.Clamp(vector2.X / ((float) Main.MaxWorldViewSize.X * 0.5f), -1f, 1f);
      num1 = MathHelper.Clamp((float) (1.0 - (double) vector2.Length() / (double) LegacySoundPlayer.SoundAttenuationDistance), 0.0f, 1f);
    }
    float num2 = num1 * (this.Style.Volume * this.Volume);
    switch (this.Style.Type)
    {
      case SoundType.Sound:
        num2 *= Main.soundVolume;
        break;
      case SoundType.Ambient:
        num2 *= Main.ambientVolume;
        break;
      case SoundType.Music:
        num2 *= Main.musicVolume;
        break;
    }
    return MathHelper.Clamp(num2, 0.0f, 1f);
  }

  public delegate bool LoopedPlayCondition();
}
