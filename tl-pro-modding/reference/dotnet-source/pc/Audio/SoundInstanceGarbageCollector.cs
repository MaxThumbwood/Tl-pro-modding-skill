// Decompiled with JetBrains decompiler
// Type: Terraria.Audio.SoundInstanceGarbageCollector
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Audio;
using System.Collections.Generic;

#nullable disable
namespace Terraria.Audio;

public static class SoundInstanceGarbageCollector
{
  private static readonly List<SoundEffectInstance> _activeSounds = new List<SoundEffectInstance>(128 /*0x80*/);

  public static void Track(SoundEffectInstance sound)
  {
    if (!Program.IsFna)
      return;
    SoundInstanceGarbageCollector._activeSounds.Add(sound);
  }

  public static void Update()
  {
    for (int index = 0; index < SoundInstanceGarbageCollector._activeSounds.Count; ++index)
    {
      if (SoundInstanceGarbageCollector._activeSounds[index] == null)
      {
        SoundInstanceGarbageCollector._activeSounds.RemoveAt(index);
        --index;
      }
      else if (SoundInstanceGarbageCollector._activeSounds[index].State == SoundState.Stopped)
      {
        SoundInstanceGarbageCollector._activeSounds[index].Dispose();
        SoundInstanceGarbageCollector._activeSounds.RemoveAt(index);
        --index;
      }
    }
  }
}
