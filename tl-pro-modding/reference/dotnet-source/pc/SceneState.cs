// Decompiled with JetBrains decompiler
// Type: Terraria.SceneState
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using System;
using Terraria.Audio;
using Terraria.GameContent.Events;
using Terraria.GameContent.RGB;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Map;

#nullable disable
namespace Terraria;

public class SceneState
{
  public float airLightDecay;
  public float solidLightDecay;
  public float outsideWeatherEffectIntensity;
  private float _outsideWeatherEffectIntensityBackingValue;
  private float _deerclopsBlizzardSmoothedEffect;
  private bool _disabledBlizzardGraphic;
  private bool _disabledBlizzardSound;
  private float _blizzardSoundVolume;
  private SlotId _strongBlizzardSound = SlotId.Invalid;
  private SlotId _insideBlizzardSound = SlotId.Invalid;
  private float _shimmerBrightenDelay;
  public bool skipTransitions;

  public SceneState() => this.Reset();

  public void Reset()
  {
    this.airLightDecay = 1f;
    this.solidLightDecay = 1f;
    this.outsideWeatherEffectIntensity = 1f;
    this._outsideWeatherEffectIntensityBackingValue = 1f;
    this._deerclopsBlizzardSmoothedEffect = 0.0f;
    this._blizzardSoundVolume = 0.0f;
    this._shimmerBrightenDelay = 0.0f;
    this.skipTransitions = true;
  }

  public void Update(SceneMetrics metrics)
  {
    this.ApplyVisuals(metrics);
    MapHelper.CaptureSceneState(metrics);
    this.skipTransitions = false;
  }

  private void ApplyVisuals(SceneMetrics metrics)
  {
    if (Main.dedServ)
      return;
    Player perspectivePlayer = metrics.PerspectivePlayer;
    this.UpdateRGBPeriheralProbe(metrics);
    this.UpdateGraveyard(metrics);
    this.UpdateShimmer(metrics);
    this.UpdateLightDecay(metrics);
    ScreenObstruction.Update(this, metrics);
    ScreenDarkness.Update(this, metrics);
    MoonlordDeathDrama.Update(this, metrics);
    bool flag1 = metrics.ZoneRain && metrics.ZoneSnow;
    bool flag2 = metrics.TileCenter.Y > Main.maxTilesY - 320;
    bool flag3 = (double) metrics.TileCenter.Y < Main.worldSurface && metrics.ZoneDesert && !metrics.ZoneRain && !metrics.ZoneSandstorm;
    this.ManageSpecialBiomeVisuals("Stardust", metrics.CloseEnoughToStardustTower, metrics.ClosestNPCPosition[493] - new Vector2(0.0f, 10f));
    this.ManageSpecialBiomeVisuals("Nebula", metrics.CloseEnoughToNebulaTower, metrics.ClosestNPCPosition[507] - new Vector2(0.0f, 10f));
    this.ManageSpecialBiomeVisuals("Vortex", metrics.CloseEnoughToVortexTower, metrics.ClosestNPCPosition[422] - new Vector2(0.0f, 10f));
    this.ManageSpecialBiomeVisuals("Solar", metrics.CloseEnoughToSolarTower, metrics.ClosestNPCPosition[517] - new Vector2(0.0f, 10f));
    this.ManageSpecialBiomeVisuals("MoonLord", metrics.ClosestNPCPosition[398] != Vector2.Zero);
    bool flag4 = metrics.CloseEnoughToSolarTower || metrics.CloseEnoughToVortexTower || metrics.CloseEnoughToNebulaTower || metrics.CloseEnoughToStardustTower;
    this.ManageSpecialBiomeVisuals("MonolithVortex", !flag4 && metrics.ActiveMonolithType == 0 || perspectivePlayer.vortexMonolithShader);
    this.ManageSpecialBiomeVisuals("MonolithNebula", !flag4 && metrics.ActiveMonolithType == 1 || perspectivePlayer.nebulaMonolithShader);
    this.ManageSpecialBiomeVisuals("MonolithStardust", !flag4 && metrics.ActiveMonolithType == 2 || perspectivePlayer.stardustMonolithShader);
    this.ManageSpecialBiomeVisuals("MonolithSolar", !flag4 && metrics.ActiveMonolithType == 3 || perspectivePlayer.solarMonolithShader);
    this.ManageSpecialBiomeVisuals("MonolithMoonLord", !flag4 && metrics.ActiveMonolithType == 4 || perspectivePlayer.moonLordMonolithShader);
    this.ManageSpecialBiomeVisuals("BloodMoon", Main.bloodMoon || metrics.BloodMoonMonolith || perspectivePlayer.bloodMoonMonolithShader);
    bool flag5 = Main.UseStormEffects & flag1;
    bool flag6 = !Main.dayTime && !flag5 && (double) Main.GraveyardVisualIntensity < 0.5;
    this.ManageSpecialBiomeVisuals("Aurora", metrics.ZoneSnow & flag6);
    this.ManageSpecialBiomeVisuals("Blizzard", Main.UseStormEffects & flag1);
    this.ManageSpecialBiomeVisuals("Sandstorm", Main.UseStormEffects && Sandstorm.ShowSandstormVisuals());
    bool flag7 = flag2 | flag3 || perspectivePlayer.sunScorchCounter > 0;
    this.ManageSpecialBiomeVisuals("HeatDistortion", Main.UseHeatDistortion & flag7);
    this.ManageSpecialBiomeVisuals("Graveyard", (double) Main.GraveyardVisualIntensity > 0.0);
    this.ManageSpecialBiomeVisuals("Sepia", ((Main.onlyDontStarveWorld ? 1 : 0) ^ (perspectivePlayer.dontStarveShader ? 1 : (metrics.RadioThingMonolith ? 1 : 0))) != 0);
    this.ManageSpecialBiomeVisuals("Noir", metrics.NoirMonolith || perspectivePlayer.noirShader);
    this.ManageSpecialBiomeVisuals("CRT", metrics.CRTMonolith || perspectivePlayer.CRTMonolithShader);
    this.ManageSpecialBiomeVisuals("Test2", metrics.RetroMonolith || perspectivePlayer.retroMonolithShader);
    this.ManageSpecialBiomeVisuals("WaterDistortion", Main.WaveQuality > 0);
    bool flag8 = metrics.TownNPCCount > 0 || metrics.PartyMonolithCount > 0;
    this.MoveTowards(ref SkyManager.Instance["Party"].Opacity, flag8 ? 1f : 0.0f, 0.01f);
    if (Filters.Scene["Graveyard"].IsActive())
    {
      float progress = MathHelper.Lerp(0.0f, 0.75f, Main.GraveyardVisualIntensity);
      ScreenShaderData shader = Filters.Scene["Graveyard"].GetShader();
      shader.UseTargetPosition(metrics.Center);
      shader.UseProgress(progress);
      shader.UseIntensity(1.2f);
    }
    if (Filters.Scene["Noir"].IsActive())
    {
      float intensity = MathHelper.Lerp(MathHelper.Lerp(0.1f, Utils.Remap(Vector3.Dot(Main.tileColor.ToVector3(), new Vector3(0.333333343f)), 0.5f, 0.1f, 0.0f, 0.2f), Utils.Remap((float) ((int) Main.worldSurface - metrics.TileCenter.Y), -40f, 40f, 0.0f, 1f)), 0.15f, Utils.Remap((float) (metrics.TileCenter.Y - Main.UnderworldLayer), -40f, 40f, 0.0f, 1f));
      Random random = new Random((int) ((double) Main.GlobalTimeWrappedHourly * 10.0));
      float x = (float) random.NextDouble();
      float y = (float) random.NextDouble();
      ScreenShaderData shader = Filters.Scene["Noir"].GetShader();
      shader.UseTargetPosition(metrics.Center);
      shader.UseIntensity(intensity);
      shader.UseImageOffset(new Vector2(x, y));
    }
    if (Filters.Scene["WaterDistortion"].IsActive())
    {
      double num1 = (double) Main.maxTilesX * 0.5 - (double) Math.Abs((float) metrics.TileCenter.X - (float) Main.maxTilesX * 0.5f);
      float num2 = 1f + Math.Abs(Main.windSpeedCurrent) * 1.25f + MathHelper.Clamp(Main.maxRaining, 0.0f, 1f) * 1.25f + (float) -((double) MathHelper.Clamp((float) ((num1 - 380.0) / 100.0), 0.0f, 1f) * 0.5 - 0.25);
      float num3 = 1f - MathHelper.Clamp((float) (3.0 * ((double) ((float) metrics.TileCenter.Y - (float) Main.worldSurface) / (Main.rockLayer - Main.worldSurface))), 0.0f, 1f);
      float intensity = MathHelper.Clamp(num2 * num3 + (float) (0.89999997615814209 - (double) MathHelper.Clamp((float) (Main.maxTilesY - metrics.TileCenter.Y - 200) / 300f, 0.0f, 1f) * 0.89999997615814209) + (float) ((1.0 - (double) num3) * 0.75), 0.0f, 2.5f);
      Filters.Scene["WaterDistortion"].GetShader().UseIntensity(intensity);
    }
    this.MoveTowards(ref this._outsideWeatherEffectIntensityBackingValue, metrics.BehindBackwall ? -0.1f : 1.1f, 0.005f);
    this.outsideWeatherEffectIntensity = Utils.Clamp<float>(this._outsideWeatherEffectIntensityBackingValue, 0.0f, 1f);
    if (Filters.Scene["Sandstorm"].IsActive())
    {
      Filters.Scene["Sandstorm"].GetShader().UseIntensity(this.outsideWeatherEffectIntensity * 0.4f * Math.Min(1f, Sandstorm.Severity));
      Filters.Scene["Sandstorm"].GetShader().UseOpacity(Math.Min(1f, Sandstorm.Severity * 1.5f) * this.outsideWeatherEffectIntensity);
      ((SimpleOverlay) Overlays.Scene["Sandstorm"]).GetShader().UseOpacity(Math.Min(1f, Sandstorm.Severity * 1.5f) * (1f - this.outsideWeatherEffectIntensity));
    }
    Filter filter = Filters.Scene["HeatDistortion"];
    if (filter.IsActive())
    {
      float num4 = 0.0f;
      if (perspectivePlayer.sunScorchCounter > 0)
      {
        float val2 = Utils.GetLerpValue(0.0f, 300f, (float) perspectivePlayer.sunScorchCounter, true) * 4f;
        num4 = Math.Max(num4, val2);
      }
      if (flag2)
      {
        float val2 = Math.Min(1f, (float) (metrics.TileCenter.Y - (Main.maxTilesY - 320)) / 120f) * 2f;
        num4 = Math.Max(num4, val2);
      }
      else if (flag3)
      {
        Vector3 vector3 = Main.tileColor.ToVector3();
        float num5 = (float) (((double) vector3.X + (double) vector3.Y + (double) vector3.Z) / 3.0);
        float val2 = this.outsideWeatherEffectIntensity * 4f * Math.Max(0.0f, 0.5f - Main.cloudAlpha) * num5;
        num4 = Math.Max(num4, val2);
      }
      filter.GetShader().UseIntensity(num4);
      filter.IsHidden = (double) num4 <= 0.0;
    }
    if (!this._disabledBlizzardGraphic)
    {
      try
      {
        if (flag1)
        {
          float num6 = Main.cloudAlpha;
          if (Main.remixWorld)
            num6 = 0.4f;
          this.MoveTowards(ref this._deerclopsBlizzardSmoothedEffect, NPC.IsADeerclopsNearScreen() ? 1f : 0.0f, 1f / 300f);
          float num7 = Math.Min(1f, num6 * 2f) * this.outsideWeatherEffectIntensity;
          float num8 = (float) ((double) this.outsideWeatherEffectIntensity * 0.40000000596046448 * (double) Math.Min(1f, num6 * 2f) * 0.89999997615814209 + 0.10000000149011612);
          float intensity = MathHelper.Lerp(num8, num8 * 0.5f, this._deerclopsBlizzardSmoothedEffect);
          float opacity = MathHelper.Lerp(num7, num7 * 0.5f, this._deerclopsBlizzardSmoothedEffect);
          Filters.Scene["Blizzard"].GetShader().UseIntensity(intensity);
          Filters.Scene["Blizzard"].GetShader().UseOpacity(opacity);
          ((SimpleOverlay) Overlays.Scene["Blizzard"]).GetShader().UseOpacity(1f - opacity);
        }
      }
      catch
      {
        this._disabledBlizzardGraphic = true;
      }
    }
    if (this._disabledBlizzardSound)
      return;
    try
    {
      if (flag1)
      {
        ActiveSound activeSound1 = SoundEngine.GetActiveSound(this._strongBlizzardSound);
        ActiveSound activeSound2 = SoundEngine.GetActiveSound(this._insideBlizzardSound);
        if (activeSound1 == null)
          this._strongBlizzardSound = SoundEngine.PlayTrackedSound((SoundStyle) SoundID.BlizzardStrongLoop);
        if (activeSound2 == null)
          this._insideBlizzardSound = SoundEngine.PlayTrackedSound((SoundStyle) SoundID.BlizzardInsideBuildingLoop);
        SoundEngine.GetActiveSound(this._strongBlizzardSound);
        SoundEngine.GetActiveSound(this._insideBlizzardSound);
      }
      this.MoveTowards(ref this._blizzardSoundVolume, flag1 ? 1f : 0.0f, 0.01f);
      float num = Math.Min(1f, Main.cloudAlpha * 2f) * this.outsideWeatherEffectIntensity;
      ActiveSound activeSound3 = SoundEngine.GetActiveSound(this._strongBlizzardSound);
      ActiveSound activeSound4 = SoundEngine.GetActiveSound(this._insideBlizzardSound);
      if ((double) this._blizzardSoundVolume > 0.0)
      {
        if (activeSound3 == null)
        {
          this._strongBlizzardSound = SoundEngine.PlayTrackedSound((SoundStyle) SoundID.BlizzardStrongLoop);
          activeSound3 = SoundEngine.GetActiveSound(this._strongBlizzardSound);
        }
        activeSound3.Volume = num * this._blizzardSoundVolume;
        if (activeSound4 == null)
        {
          this._insideBlizzardSound = SoundEngine.PlayTrackedSound((SoundStyle) SoundID.BlizzardInsideBuildingLoop);
          activeSound4 = SoundEngine.GetActiveSound(this._insideBlizzardSound);
        }
        activeSound4.Volume = (1f - num) * this._blizzardSoundVolume;
      }
      else
      {
        if (activeSound3 != null)
          activeSound3.Volume = 0.0f;
        else
          this._strongBlizzardSound = SlotId.Invalid;
        if (activeSound4 != null)
          activeSound4.Volume = 0.0f;
        else
          this._insideBlizzardSound = SlotId.Invalid;
      }
    }
    catch
    {
      this._disabledBlizzardSound = true;
    }
  }

  private void UpdateLightDecay(SceneMetrics metrics)
  {
    float num1 = 1f;
    float num2 = 1f;
    float target1 = num1 * (float) (1.0 - (double) Main.shimmerAlpha * 0.0);
    float target2 = num2 * (float) (1.0 - (double) Main.shimmerAlpha * 0.30000001192092896);
    if (Main.getGoodWorld)
    {
      if (metrics.WithinRangeOfNPC(245, 2000.0))
      {
        target1 *= 0.6f;
        target2 *= 0.6f;
      }
      else if (metrics.ZoneLihzhardTemple)
      {
        target1 *= 0.88f;
        target2 *= 0.88f;
      }
      else if (metrics.ZoneDungeon)
      {
        target1 *= 0.94f;
        target2 *= 0.94f;
      }
    }
    this.MoveTowards(ref this.airLightDecay, target1, 0.005f);
    this.MoveTowards(ref this.solidLightDecay, target2, 0.005f);
  }

  private void UpdateShimmer(SceneMetrics metrics)
  {
    bool flag = metrics.ShimmerMonolithState == 1 || metrics.ZoneShimmer || metrics.PerspectivePlayer.shimmerMonolithShader || metrics.PerspectivePlayer.shimmering && metrics.UndergroundForShimmering;
    if (metrics.ShimmerMonolithState == 2)
      flag = false;
    if (flag)
    {
      this.MoveTowards(ref Main.shimmerAlpha, 1f, 0.025f);
      if ((double) Main.shimmerAlpha < 0.5)
        return;
      this.MoveTowards(ref Main.shimmerDarken, 1f, 0.025f);
      this._shimmerBrightenDelay = 4f;
    }
    else
    {
      this.MoveTowards(ref Main.shimmerDarken, 0.0f, 0.05f);
      if ((double) Main.shimmerDarken == 0.0)
        this.MoveTowards(ref this._shimmerBrightenDelay, 0.0f, 1f);
      if ((double) this._shimmerBrightenDelay != 0.0)
        return;
      this.MoveTowards(ref Main.shimmerAlpha, 0.0f, 0.05f);
    }
  }

  private void ManageSpecialBiomeVisuals(
    string biomeName,
    bool inZone,
    Vector2 activationSource = default (Vector2),
    bool alwaysInstant = false)
  {
    if (SkyManager.Instance[biomeName] != null && inZone != SkyManager.Instance[biomeName].IsActive())
    {
      if (inZone)
        SkyManager.Instance.Activate(biomeName, activationSource);
      else
        SkyManager.Instance.Deactivate(biomeName);
    }
    Filter filter = Filters.Scene[biomeName];
    Overlay overlay = Overlays.Scene[biomeName];
    if (filter != null)
    {
      if (inZone != Filters.Scene[biomeName].IsActive())
      {
        if (inZone)
          Filters.Scene.Activate(biomeName, activationSource);
        else
          filter.Deactivate();
      }
      else if (inZone)
        filter.GetShader().UseTargetPosition(activationSource);
    }
    if (overlay != null && inZone != (Overlays.Scene[biomeName].Mode != OverlayMode.Inactive))
    {
      if (inZone)
        Overlays.Scene.Activate(biomeName, activationSource);
      else
        overlay.Deactivate();
    }
    if ((alwaysInstant ? 1 : (this.skipTransitions ? 1 : 0)) == 0)
      return;
    if (filter != null)
      filter.Opacity = inZone ? 1f : 0.0f;
    if (overlay == null)
      return;
    overlay.Opacity = inZone ? 1f : 0.0f;
  }

  private void UpdateGraveyard(SceneMetrics metrics)
  {
    float lerpValue = Utils.GetLerpValue((float) SceneMetrics.GraveyardTileMin, (float) SceneMetrics.GraveyardTileMax, (float) metrics.GraveyardTileCount, true);
    this.MoveTowards(ref Main.GraveyardVisualIntensity, lerpValue, 0.02f, 0.1f);
  }

  private void UpdateRGBPeriheralProbe(SceneMetrics metrics)
  {
    int num1 = 0;
    int num2 = metrics.ZoneOverworldHeight ? 1 : 0;
    if (metrics.AnyNPCs(4))
      num1 = 4;
    if (metrics.AnyNPCs(50))
      num1 = 50;
    if (num2 != 0 && Main.invasionType == 1)
      num1 = -1;
    if (metrics.AnyNPCs(13))
      num1 = 13;
    if (metrics.AnyNPCs(266))
      num1 = 266;
    if (metrics.AnyNPCs(222))
      num1 = 222;
    if (metrics.AnyNPCs(35))
      num1 = 35;
    if (metrics.AnyNPCs(113))
      num1 = 113;
    if (num2 != 0 && Main.invasionType == 2)
      num1 = -2;
    if (metrics.AnyNPCs(657))
      num1 = 657;
    if (metrics.AnyNPCs(126) || metrics.AnyNPCs(125))
      num1 = 126;
    if (metrics.AnyNPCs(134))
      num1 = 134;
    if (metrics.AnyNPCs((int) sbyte.MaxValue))
      num1 = (int) sbyte.MaxValue;
    if (num2 != 0 && Main.invasionType == 3)
      num1 = -3;
    if (metrics.AnyNPCs(262))
      num1 = 262;
    if (metrics.AnyNPCs(245))
      num1 = 245;
    if (metrics.AnyNPCs(636))
      num1 = 636;
    if (metrics.AnyNPCs(668) && NPC.IsDeerclopsHostile())
      num1 = 668;
    if (DD2Event.Ongoing)
      num1 = -6;
    if (num2 != 0 && Main.invasionType == 4)
      num1 = -4;
    if (metrics.AnyNPCs(439))
      num1 = 439;
    if (metrics.AnyNPCs(370))
      num1 = 370;
    if (metrics.AnyNPCs(398))
      num1 = 398;
    CommonConditions.Boss.HighestTierBossOrEvent = num1;
  }

  public void MoveTowards(ref float value, float target, float amount)
  {
    this.MoveTowards(ref value, target, amount, amount);
  }

  public void MoveTowards(ref float value, float target, float inc, float dec)
  {
    if (this.skipTransitions)
      value = target;
    else if ((double) value < (double) target)
    {
      value = Math.Min(value + inc, target);
    }
    else
    {
      if ((double) value <= (double) target)
        return;
      value = Math.Max(value - dec, target);
    }
  }
}
