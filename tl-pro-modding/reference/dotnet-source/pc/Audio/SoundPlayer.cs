// Decompiled with JetBrains decompiler
// Type: Terraria.Audio.SoundPlayer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using System.Collections.Generic;

#nullable disable
namespace Terraria.Audio;

public class SoundPlayer
{
  private readonly SlotVector<ActiveSound> _trackedSounds = new SlotVector<ActiveSound>(4096 /*0x1000*/);

  public SlotId Play(SoundStyle style, Vector2 position, SoundPlayOverrides overrides = default (SoundPlayOverrides))
  {
    return Main.dedServ || style == null || !style.IsTrackable || (double) Vector2.DistanceSquared(Main.screenPosition + new Vector2((float) (Main.screenWidth / 2), (float) (Main.screenHeight / 2)), position) > 100000000.0 ? SlotId.Invalid : this._trackedSounds.Add(new ActiveSound(style, position, overrides));
  }

  public SlotId PlayLooped(
    SoundStyle style,
    Vector2 position,
    ActiveSound.LoopedPlayCondition loopingCondition,
    SoundPlayOverrides overrides = default (SoundPlayOverrides))
  {
    return Main.dedServ || style == null || !style.IsTrackable || (double) Vector2.DistanceSquared(Main.screenPosition + new Vector2((float) (Main.screenWidth / 2), (float) (Main.screenHeight / 2)), position) > 100000000.0 ? SlotId.Invalid : this._trackedSounds.Add(new ActiveSound(style, position, loopingCondition, overrides));
  }

  public void Reload() => this.StopAll();

  public SlotId Play(SoundStyle style)
  {
    return Main.dedServ || style == null || !style.IsTrackable ? SlotId.Invalid : this._trackedSounds.Add(new ActiveSound(style));
  }

  public ActiveSound GetActiveSound(SlotId id)
  {
    return !this._trackedSounds.Has(id) ? (ActiveSound) null : this._trackedSounds[id];
  }

  public void PauseAll()
  {
    foreach (SlotVector<ActiveSound>.ItemPair trackedSound in (IEnumerable<SlotVector<ActiveSound>.ItemPair>) this._trackedSounds)
      trackedSound.Value.Pause();
  }

  public void ResumeAll()
  {
    foreach (SlotVector<ActiveSound>.ItemPair trackedSound in (IEnumerable<SlotVector<ActiveSound>.ItemPair>) this._trackedSounds)
      trackedSound.Value.Resume();
  }

  public void StopAll()
  {
    foreach (SlotVector<ActiveSound>.ItemPair trackedSound in (IEnumerable<SlotVector<ActiveSound>.ItemPair>) this._trackedSounds)
      trackedSound.Value.Stop();
    this._trackedSounds.Clear();
  }

  public void Update()
  {
    foreach (SlotVector<ActiveSound>.ItemPair trackedSound in (IEnumerable<SlotVector<ActiveSound>.ItemPair>) this._trackedSounds)
    {
      try
      {
        trackedSound.Value.Update();
        if (!trackedSound.Value.IsPlaying)
          this._trackedSounds.Remove(trackedSound.Id);
      }
      catch
      {
        this._trackedSounds.Remove(trackedSound.Id);
      }
    }
  }

  public int GetActiveSoundCount(SoundStyle style)
  {
    int activeSoundCount = 0;
    foreach (SlotVector<ActiveSound>.ItemPair trackedSound in (IEnumerable<SlotVector<ActiveSound>.ItemPair>) this._trackedSounds)
    {
      ActiveSound activeSound = trackedSound.Value;
      if (activeSound.Style == style && activeSound.IsPlaying)
        ++activeSoundCount;
    }
    return activeSoundCount;
  }

  public ActiveSound FindActiveSound(SoundStyle style)
  {
    foreach (SlotVector<ActiveSound>.ItemPair trackedSound in (IEnumerable<SlotVector<ActiveSound>.ItemPair>) this._trackedSounds)
    {
      if (trackedSound.Value.Style == style)
        return trackedSound.Value;
    }
    return (ActiveSound) null;
  }
}
