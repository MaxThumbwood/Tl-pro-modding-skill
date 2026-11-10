// Decompiled with JetBrains decompiler
// Type: Terraria.Audio.ASoundEffectBasedAudioTrack
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Audio;
using System;

#nullable disable
namespace Terraria.Audio;

public abstract class ASoundEffectBasedAudioTrack : IAudioTrack, IDisposable
{
  protected const int bufferLength = 4096 /*0x1000*/;
  protected const int bufferCountPerSubmit = 2;
  protected const int buffersToCoverFor = 8;
  protected byte[] _bufferToSubmit = new byte[4096 /*0x1000*/];
  protected float[] _temporaryBuffer = new float[2048 /*0x0800*/];
  private int _sampleRate;
  private AudioChannels _channels;
  protected DynamicSoundEffectInstance _soundEffectInstance;

  protected void CreateSoundEffect(int sampleRate, AudioChannels channels)
  {
    this._sampleRate = sampleRate;
    this._channels = channels;
    this._soundEffectInstance = new DynamicSoundEffectInstance(this._sampleRate, this._channels);
  }

  private void _soundEffectInstance_BufferNeeded(object sender, EventArgs e)
  {
    this.PrepareBuffer();
  }

  public void Update()
  {
    if (!this.IsPlaying || this._soundEffectInstance.PendingBufferCount >= 8)
      return;
    this.PrepareBuffer();
  }

  protected void ResetBuffer()
  {
    for (int index = 0; index < this._bufferToSubmit.Length; ++index)
      this._bufferToSubmit[index] = (byte) 0;
  }

  protected void PrepareBuffer()
  {
    for (int index = 0; index < 2; ++index)
      this.ReadAheadPutAChunkIntoTheBuffer();
  }

  public bool IsPlaying => this._soundEffectInstance.State == SoundState.Playing;

  public bool IsStopped => this._soundEffectInstance.State == SoundState.Stopped;

  public bool IsPaused => this._soundEffectInstance.State == SoundState.Paused;

  public void Stop(AudioStopOptions options)
  {
    this._soundEffectInstance.Stop(options == AudioStopOptions.Immediate);
  }

  public void Play()
  {
    this.PrepareToPlay();
    this._soundEffectInstance.Play();
  }

  public void Pause() => this._soundEffectInstance.Pause();

  public void SetVariable(string variableName, float value)
  {
    switch (variableName)
    {
      case "Volume":
        this._soundEffectInstance.Volume = this.ReMapVolumeToMatchXact(value);
        break;
      case "Pitch":
        this._soundEffectInstance.Pitch = value;
        break;
      case "Pan":
        this._soundEffectInstance.Pan = value;
        break;
    }
  }

  private float ReMapVolumeToMatchXact(float musicVolume)
  {
    return (float) Math.Pow(10.0, (31.0 * (double) musicVolume - 25.0 - 11.94) / 20.0);
  }

  public void Resume() => this._soundEffectInstance.Resume();

  protected virtual void PrepareToPlay() => this.ResetBuffer();

  public abstract void Reuse();

  protected virtual void ReadAheadPutAChunkIntoTheBuffer()
  {
  }

  public abstract void Dispose();
}
