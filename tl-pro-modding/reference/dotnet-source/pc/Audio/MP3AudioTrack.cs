// Decompiled with JetBrains decompiler
// Type: Terraria.Audio.MP3AudioTrack
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Audio;
using System.IO;
using XPT.Core.Audio.MP3Sharp;

#nullable disable
namespace Terraria.Audio;

public class MP3AudioTrack : ASoundEffectBasedAudioTrack
{
  private Stream _stream;
  private MP3Stream _mp3Stream;

  public MP3AudioTrack(Stream stream)
  {
    this._stream = stream;
    MP3Stream mp3Stream = new MP3Stream(stream);
    int frequency = mp3Stream.Frequency;
    this._mp3Stream = mp3Stream;
    this.CreateSoundEffect(frequency, AudioChannels.Stereo);
  }

  public override void Reuse() => ((Stream) this._mp3Stream).Position = 0L;

  public override void Dispose()
  {
    this._soundEffectInstance.Dispose();
    ((Stream) this._mp3Stream).Dispose();
    this._stream.Dispose();
  }

  protected override void ReadAheadPutAChunkIntoTheBuffer()
  {
    byte[] bufferToSubmit = this._bufferToSubmit;
    if (((Stream) this._mp3Stream).Read(bufferToSubmit, 0, bufferToSubmit.Length) < 1)
      this.Stop(AudioStopOptions.Immediate);
    else
      this._soundEffectInstance.SubmitBuffer(this._bufferToSubmit);
  }
}
