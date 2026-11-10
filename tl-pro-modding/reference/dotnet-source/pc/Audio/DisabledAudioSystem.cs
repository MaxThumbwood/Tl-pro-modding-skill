// Decompiled with JetBrains decompiler
// Type: Terraria.Audio.DisabledAudioSystem
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Content.Sources;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Terraria.Audio;

public class DisabledAudioSystem : IAudioSystem, IDisposable
{
  public void LoadFromSources()
  {
  }

  public void UseSources(List<IContentSource> sources)
  {
  }

  public void Update()
  {
  }

  public void UpdateMisc()
  {
  }

  public IEnumerator PrepareWaveBank()
  {
    yield break;
  }

  public void LoadCue(int cueIndex, string cueName)
  {
  }

  public void PauseAll()
  {
  }

  public void ResumeAll()
  {
  }

  public void UpdateAmbientCueState(
    int i,
    bool gameIsActive,
    ref float trackVolume,
    float systemVolume)
  {
  }

  public void UpdateAmbientCueTowardStopping(
    int i,
    float stoppingSpeed,
    ref float trackVolume,
    float systemVolume)
  {
  }

  public bool IsTrackPlaying(int trackIndex) => false;

  public void UpdateCommonTrack(bool active, int i, float totalVolume, ref float tempFade)
  {
  }

  public void UpdateCommonTrackTowardStopping(
    int i,
    float totalVolume,
    ref float tempFade,
    bool isMainTrackAudible)
  {
  }

  public void UpdateAudioEngine()
  {
  }

  public void SetPlayCallback(int trackIndex, AudioTrackPlayCallback callback)
  {
  }

  public void Dispose()
  {
  }
}
