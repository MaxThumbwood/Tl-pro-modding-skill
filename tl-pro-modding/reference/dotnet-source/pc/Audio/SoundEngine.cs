// Decompiled with JetBrains decompiler
// Type: Terraria.Audio.SoundEngine
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using ReLogic.Utilities;
using System;
using System.IO;

#nullable disable
namespace Terraria.Audio;

public static class SoundEngine
{
  public static LegacySoundPlayer LegacySoundPlayer;
  public static SoundPlayer SoundPlayer;
  public static bool AreSoundsPaused;

  public static bool IsAudioSupported { get; private set; }

  public static IAudioSystem Initialize()
  {
    SoundEngine.IsAudioSupported = SoundEngine.TestAudioSupport();
    try
    {
      if (SoundEngine.IsAudioSupported)
        return (IAudioSystem) new LegacyAudioSystem();
    }
    catch (Exception ex)
    {
      SoundEngine.IsAudioSupported = false;
    }
    return (IAudioSystem) new DisabledAudioSystem();
  }

  public static void Load(IServiceProvider services)
  {
    if (!SoundEngine.IsAudioSupported)
      return;
    SoundEngine.LegacySoundPlayer = new LegacySoundPlayer(services);
    SoundEngine.SoundPlayer = new SoundPlayer();
  }

  public static void Update()
  {
    if (!SoundEngine.IsAudioSupported)
      return;
    if (Main.audioSystem != null)
      Main.audioSystem.UpdateAudioEngine();
    SoundInstanceGarbageCollector.Update();
    bool pauseSounds = FocusHelper.PauseSounds;
    if (!SoundEngine.AreSoundsPaused & pauseSounds)
      SoundEngine.SoundPlayer.PauseAll();
    else if (SoundEngine.AreSoundsPaused && !pauseSounds)
      SoundEngine.SoundPlayer.ResumeAll();
    SoundEngine.AreSoundsPaused = pauseSounds;
    SoundEngine.SoundPlayer.Update();
  }

  public static void Reload()
  {
    if (!SoundEngine.IsAudioSupported)
      return;
    if (SoundEngine.LegacySoundPlayer != null)
      SoundEngine.LegacySoundPlayer.Reload();
    if (SoundEngine.SoundPlayer == null)
      return;
    SoundEngine.SoundPlayer.Reload();
  }

  public static void PlaySound(int type, Vector2 position, int style = 1, float pitchOffset = 0.0f)
  {
    SoundEngine.PlaySound(type, (int) position.X, (int) position.Y, style, pitchOffset: pitchOffset);
  }

  public static SoundEffectInstance PlaySound(
    LegacySoundStyle type,
    Vector2 position,
    float pitchOffset = 0.0f,
    float volumeScale = 1f)
  {
    return SoundEngine.PlaySound(type, (int) position.X, (int) position.Y, pitchOffset, volumeScale);
  }

  public static SoundEffectInstance PlaySound(
    LegacySoundStyle type,
    int x = -1,
    int y = -1,
    float pitchOffset = 0.0f,
    float volumeScale = 1f)
  {
    return type == null ? (SoundEffectInstance) null : SoundEngine.PlaySound(type.SoundId, x, y, type.Style, type.Volume * volumeScale, pitchOffset + type.GetRandomPitch());
  }

  public static SoundEffectInstance PlaySound(
    int type,
    int x = -1,
    int y = -1,
    int Style = 1,
    float volumeScale = 1f,
    float pitchOffset = 0.0f)
  {
    return Main.dedServ || !SoundEngine.IsAudioSupported ? (SoundEffectInstance) null : SoundEngine.LegacySoundPlayer.PlaySound(type, x, y, Style, volumeScale, pitchOffset);
  }

  public static ActiveSound GetActiveSound(SlotId id)
  {
    return Main.dedServ || !SoundEngine.IsAudioSupported ? (ActiveSound) null : SoundEngine.SoundPlayer.GetActiveSound(id);
  }

  public static SlotId PlayTrackedSound(
    SoundStyle style,
    Vector2 position,
    SoundPlayOverrides overrides = default (SoundPlayOverrides))
  {
    return Main.dedServ || !SoundEngine.IsAudioSupported || style.MaxTrackedInstances > 0 && SoundEngine.SoundPlayer.GetActiveSoundCount(style) >= style.MaxTrackedInstances ? SlotId.Invalid : SoundEngine.SoundPlayer.Play(style, position, overrides);
  }

  public static SlotId PlayTrackedLoopedSound(
    SoundStyle style,
    Vector2 position,
    ActiveSound.LoopedPlayCondition loopingCondition = null,
    SoundPlayOverrides overrides = default (SoundPlayOverrides))
  {
    return Main.dedServ || !SoundEngine.IsAudioSupported ? SlotId.Invalid : SoundEngine.SoundPlayer.PlayLooped(style, position, loopingCondition, overrides);
  }

  public static SlotId PlayTrackedSound(SoundStyle style)
  {
    return Main.dedServ || !SoundEngine.IsAudioSupported ? SlotId.Invalid : SoundEngine.SoundPlayer.Play(style);
  }

  public static void StopTrackedSounds()
  {
    if (Main.dedServ || !SoundEngine.IsAudioSupported)
      return;
    SoundEngine.SoundPlayer.StopAll();
  }

  public static SoundEffect GetTrackableSoundByStyleId(int id)
  {
    return Main.dedServ || !SoundEngine.IsAudioSupported ? (SoundEffect) null : SoundEngine.LegacySoundPlayer.GetTrackableSoundByStyleId(id);
  }

  public static void StopAmbientSounds()
  {
    if (Main.dedServ || !SoundEngine.IsAudioSupported || SoundEngine.LegacySoundPlayer == null)
      return;
    SoundEngine.LegacySoundPlayer.StopAmbientSounds();
  }

  public static ActiveSound FindActiveSound(SoundStyle style)
  {
    return Main.dedServ || !SoundEngine.IsAudioSupported ? (ActiveSound) null : SoundEngine.SoundPlayer.FindActiveSound(style);
  }

  private static bool TestAudioSupport()
  {
    byte[] buffer = new byte[166]
    {
      (byte) 82,
      (byte) 73,
      (byte) 70,
      (byte) 70,
      (byte) 158,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 87,
      (byte) 65,
      (byte) 86,
      (byte) 69,
      (byte) 102,
      (byte) 109,
      (byte) 116,
      (byte) 32 /*0x20*/,
      (byte) 16 /*0x10*/,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 68,
      (byte) 172,
      (byte) 0,
      (byte) 0,
      (byte) 136,
      (byte) 88,
      (byte) 1,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 16 /*0x10*/,
      (byte) 0,
      (byte) 76,
      (byte) 73,
      (byte) 83,
      (byte) 84,
      (byte) 26,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 73,
      (byte) 78,
      (byte) 70,
      (byte) 79,
      (byte) 73,
      (byte) 83,
      (byte) 70,
      (byte) 84,
      (byte) 14,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 76,
      (byte) 97,
      (byte) 118,
      (byte) 102,
      (byte) 53,
      (byte) 54,
      (byte) 46,
      (byte) 52,
      (byte) 48 /*0x30*/,
      (byte) 46,
      (byte) 49,
      (byte) 48 /*0x30*/,
      (byte) 49,
      (byte) 0,
      (byte) 100,
      (byte) 97,
      (byte) 116,
      (byte) 97,
      (byte) 88,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 126,
      (byte) 4,
      (byte) 240 /*0xF0*/,
      (byte) 8,
      (byte) 64 /*0x40*/,
      (byte) 13,
      (byte) 95,
      (byte) 17,
      (byte) 67,
      (byte) 21,
      (byte) 217,
      (byte) 24,
      (byte) 23,
      (byte) 28,
      (byte) 240 /*0xF0*/,
      (byte) 30,
      (byte) 94,
      (byte) 33,
      (byte) 84,
      (byte) 35,
      (byte) 208 /*0xD0*/,
      (byte) 36,
      (byte) 204,
      (byte) 37,
      (byte) 71,
      (byte) 38,
      (byte) 64 /*0x40*/,
      (byte) 38,
      (byte) 183,
      (byte) 37,
      (byte) 180,
      (byte) 36,
      (byte) 58,
      (byte) 35,
      (byte) 79,
      (byte) 33,
      (byte) 1,
      (byte) 31 /*0x1F*/,
      (byte) 86,
      (byte) 28,
      (byte) 92,
      (byte) 25,
      (byte) 37,
      (byte) 22,
      (byte) 185,
      (byte) 18,
      (byte) 42,
      (byte) 15,
      (byte) 134,
      (byte) 11,
      (byte) 222,
      (byte) 7,
      (byte) 68,
      (byte) 4,
      (byte) 196,
      (byte) 0,
      (byte) 112 /*0x70*/,
      (byte) 253,
      (byte) 86,
      (byte) 250,
      (byte) 132,
      (byte) 247,
      (byte) 6,
      (byte) 245,
      (byte) 230,
      (byte) 242,
      (byte) 47,
      (byte) 241,
      (byte) 232,
      (byte) 239,
      (byte) 25,
      (byte) 239,
      (byte) 194,
      (byte) 238,
      (byte) 231,
      (byte) 238,
      (byte) 139,
      (byte) 239,
      (byte) 169,
      (byte) 240 /*0xF0*/,
      (byte) 61,
      (byte) 242,
      (byte) 67,
      (byte) 244,
      (byte) 180,
      (byte) 246
    };
    try
    {
      using (MemoryStream memoryStream = new MemoryStream(buffer))
        SoundEffect.FromStream((Stream) memoryStream);
    }
    catch (NoAudioHardwareException ex)
    {
      Console.WriteLine("No audio hardware found. Disabling all audio.");
      return false;
    }
    catch
    {
      return false;
    }
    return true;
  }
}
