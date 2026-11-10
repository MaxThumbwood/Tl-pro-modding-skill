// Decompiled with JetBrains decompiler
// Type: Terraria.Audio.IAudioTrack
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Audio;
using System;

#nullable disable
namespace Terraria.Audio;

public interface IAudioTrack : IDisposable
{
  bool IsPlaying { get; }

  bool IsStopped { get; }

  bool IsPaused { get; }

  void Stop(AudioStopOptions options);

  void Play();

  void Pause();

  void SetVariable(string variableName, float value);

  void Resume();

  void Reuse();

  void Update();
}
