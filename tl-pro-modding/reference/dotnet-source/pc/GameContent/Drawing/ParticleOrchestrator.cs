// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Drawing.ParticleOrchestrator
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.Audio;
using Terraria.GameContent.NetModules;
using Terraria.Graphics.CameraModifiers;
using Terraria.Graphics.Renderers;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Net;

#nullable disable
namespace Terraria.GameContent.Drawing;

public class ParticleOrchestrator
{
  internal static ParticlePool<FadingParticle> _poolFading = new ParticlePool<FadingParticle>(200, new ParticlePool<FadingParticle>.ParticleInstantiator(ParticleOrchestrator.GetNewFadingParticle));
  private static ParticlePool<FadingPlayerShaderParticle> _poolFadingPlayerShader = new ParticlePool<FadingPlayerShaderParticle>(200, new ParticlePool<FadingPlayerShaderParticle>.ParticleInstantiator(ParticleOrchestrator.GetNewFadingPlayerShaderParticle));
  private static ParticlePool<LittleFlyingCritterParticle> _poolFlies = new ParticlePool<LittleFlyingCritterParticle>(200, new ParticlePool<LittleFlyingCritterParticle>.ParticleInstantiator(ParticleOrchestrator.GetNewPooFlyParticle));
  private static ParticlePool<LittleFlyingCritterParticle> _natureFlies = new ParticlePool<LittleFlyingCritterParticle>(200, new ParticlePool<LittleFlyingCritterParticle>.ParticleInstantiator(ParticleOrchestrator.GetNewNatureFlyParticle));
  private static ParticlePool<ItemTransferParticle> _poolItemTransfer = new ParticlePool<ItemTransferParticle>(100, new ParticlePool<ItemTransferParticle>.ParticleInstantiator(ParticleOrchestrator.GetNewItemTransferParticle));
  private static ParticlePool<FakeFishParticle> _fakeFish = new ParticlePool<FakeFishParticle>(100, new ParticlePool<FakeFishParticle>.ParticleInstantiator(ParticleOrchestrator.GetNewFakeFishParticle));
  private static ParticlePool<FlameParticle> _poolFlame = new ParticlePool<FlameParticle>(200, new ParticlePool<FlameParticle>.ParticleInstantiator(ParticleOrchestrator.GetNewFlameParticle));
  private static ParticlePool<RandomizedFrameParticle> _poolRandomizedFrame = new ParticlePool<RandomizedFrameParticle>(200, new ParticlePool<RandomizedFrameParticle>.ParticleInstantiator(ParticleOrchestrator.GetNewRandomizedFrameParticle));
  private static ParticlePool<PrettySparkleParticle> _poolPrettySparkle = new ParticlePool<PrettySparkleParticle>(200, new ParticlePool<PrettySparkleParticle>.ParticleInstantiator(ParticleOrchestrator.GetNewPrettySparkleParticle));
  private static ParticlePool<GasParticle> _poolGas = new ParticlePool<GasParticle>(200, new ParticlePool<GasParticle>.ParticleInstantiator(ParticleOrchestrator.GetNewGasParticle));
  private static ParticlePool<BloodyExplosionParticle> _poolBloodyExplosion = new ParticlePool<BloodyExplosionParticle>(200, new ParticlePool<BloodyExplosionParticle>.ParticleInstantiator(ParticleOrchestrator.GetNewBloodyExplosionParticle));
  private static ParticlePool<ShockIconParticle> _poolShockIcon = new ParticlePool<ShockIconParticle>(200, new ParticlePool<ShockIconParticle>.ParticleInstantiator(ParticleOrchestrator.GetNewShockIconParticle));
  public static ParticlePool<ItemTransferParticle> ScreenItemParticles = new ParticlePool<ItemTransferParticle>(100, new ParticlePool<ItemTransferParticle>.ParticleInstantiator(ParticleOrchestrator.GetNewItemTransferParticle_ScreenSpace));
  public static ParticlePool<StormLightningParticle> StormLightningParticles = new ParticlePool<StormLightningParticle>(20, new ParticlePool<StormLightningParticle>.ParticleInstantiator(ParticleOrchestrator.GetNewStormLightningParticle));
  private static SlotId[] _mushBoiExplosionSounds = new SlotId[3];

  public static void RequestParticleSpawn(
    bool clientOnly,
    ParticleOrchestraType type,
    ParticleOrchestraSettings settings,
    int? overrideInvokingPlayerIndex = null)
  {
    settings.IndexOfPlayerWhoInvokedThis = (byte) Main.myPlayer;
    if (overrideInvokingPlayerIndex.HasValue)
      settings.IndexOfPlayerWhoInvokedThis = (byte) overrideInvokingPlayerIndex.Value;
    ParticleOrchestrator.SpawnParticlesDirect(type, settings);
    if (clientOnly || Main.netMode != 1)
      return;
    NetManager.Instance.SendToServer(NetParticlesModule.Serialize(type, settings));
  }

  public static void BroadcastParticleSpawn(
    ParticleOrchestraType type,
    ParticleOrchestraSettings settings)
  {
    settings.IndexOfPlayerWhoInvokedThis = (byte) Main.myPlayer;
    if (!Main.dedServ)
      ParticleOrchestrator.SpawnParticlesDirect(type, settings);
    else
      NetManager.Instance.Broadcast(NetParticlesModule.Serialize(type, settings));
  }

  public static void BroadcastOrRequestParticleSpawn(
    ParticleOrchestraType type,
    ParticleOrchestraSettings settings)
  {
    settings.IndexOfPlayerWhoInvokedThis = (byte) Main.myPlayer;
    if (!Main.dedServ)
      ParticleOrchestrator.SpawnParticlesDirect(type, settings);
    if (Main.netMode == 0)
      return;
    NetManager.Instance.SendToServerOrBroadcast(NetParticlesModule.Serialize(type, settings));
  }

  private static FadingParticle GetNewFadingParticle() => new FadingParticle();

  private static FadingPlayerShaderParticle GetNewFadingPlayerShaderParticle()
  {
    return new FadingPlayerShaderParticle();
  }

  private static LittleFlyingCritterParticle GetNewPooFlyParticle()
  {
    return new LittleFlyingCritterParticle();
  }

  private static LittleFlyingCritterParticle GetNewNatureFlyParticle()
  {
    return new LittleFlyingCritterParticle();
  }

  private static ItemTransferParticle GetNewItemTransferParticle() => new ItemTransferParticle();

  private static FakeFishParticle GetNewFakeFishParticle() => new FakeFishParticle();

  private static FlameParticle GetNewFlameParticle() => new FlameParticle();

  private static RandomizedFrameParticle GetNewRandomizedFrameParticle()
  {
    return new RandomizedFrameParticle();
  }

  private static PrettySparkleParticle GetNewPrettySparkleParticle() => new PrettySparkleParticle();

  private static GasParticle GetNewGasParticle() => new GasParticle();

  private static BloodyExplosionParticle GetNewBloodyExplosionParticle()
  {
    return new BloodyExplosionParticle();
  }

  private static ShockIconParticle GetNewShockIconParticle() => new ShockIconParticle();

  private static ItemTransferParticle GetNewItemTransferParticle_ScreenSpace()
  {
    return new ItemTransferParticle();
  }

  private static StormLightningParticle GetNewStormLightningParticle()
  {
    return new StormLightningParticle();
  }

  public static void SpawnParticlesDirect(
    ParticleOrchestraType type,
    ParticleOrchestraSettings settings)
  {
    if (Main.netMode == 2)
      return;
    switch (type)
    {
      case ParticleOrchestraType.Keybrand:
        ParticleOrchestrator.Spawn_Keybrand(settings);
        break;
      case ParticleOrchestraType.FlameWaders:
        ParticleOrchestrator.Spawn_FlameWaders(settings);
        break;
      case ParticleOrchestraType.StellarTune:
        ParticleOrchestrator.Spawn_StellarTune(settings);
        break;
      case ParticleOrchestraType.WallOfFleshGoatMountFlames:
        ParticleOrchestrator.Spawn_WallOfFleshGoatMountFlames(settings);
        break;
      case ParticleOrchestraType.BlackLightningHit:
        ParticleOrchestrator.Spawn_BlackLightningHit(settings);
        break;
      case ParticleOrchestraType.RainbowRodHit:
        ParticleOrchestrator.Spawn_RainbowRodHit(settings);
        break;
      case ParticleOrchestraType.BlackLightningSmall:
        ParticleOrchestrator.Spawn_BlackLightningSmall(settings);
        break;
      case ParticleOrchestraType.StardustPunch:
        ParticleOrchestrator.Spawn_StardustPunch(settings);
        break;
      case ParticleOrchestraType.PrincessWeapon:
        ParticleOrchestrator.Spawn_PrincessWeapon(settings);
        break;
      case ParticleOrchestraType.PaladinsHammer:
        ParticleOrchestrator.Spawn_PaladinsHammer(settings);
        break;
      case ParticleOrchestraType.NightsEdge:
        ParticleOrchestrator.Spawn_NightsEdge(settings);
        break;
      case ParticleOrchestraType.SilverBulletSparkle:
        ParticleOrchestrator.Spawn_SilverBulletSparkle(settings);
        break;
      case ParticleOrchestraType.TrueNightsEdge:
        ParticleOrchestrator.Spawn_TrueNightsEdge(settings);
        break;
      case ParticleOrchestraType.Excalibur:
        ParticleOrchestrator.Spawn_Excalibur(settings);
        break;
      case ParticleOrchestraType.TrueExcalibur:
        ParticleOrchestrator.Spawn_TrueExcalibur(settings);
        break;
      case ParticleOrchestraType.TerraBlade:
        ParticleOrchestrator.Spawn_TerraBlade(settings);
        break;
      case ParticleOrchestraType.ChlorophyteLeafCrystalPassive:
        ParticleOrchestrator.Spawn_LeafCrystalPassive(settings);
        break;
      case ParticleOrchestraType.ChlorophyteLeafCrystalShot:
        ParticleOrchestrator.Spawn_LeafCrystalShot(settings);
        break;
      case ParticleOrchestraType.BestReforge:
        ParticleOrchestrator.Spawn_BestReforge(settings);
        break;
      case ParticleOrchestraType.PetExchange:
        ParticleOrchestrator.Spawn_PetExchange(settings);
        break;
      case ParticleOrchestraType.SlapHand:
        ParticleOrchestrator.Spawn_SlapHand(settings);
        break;
      case ParticleOrchestraType.FlyMeal:
        ParticleOrchestrator.Spawn_FlyMeal(settings);
        break;
      case ParticleOrchestraType.VampireOnFire:
        ParticleOrchestrator.Spawn_VampireOnFire(settings);
        break;
      case ParticleOrchestraType.GasTrap:
        ParticleOrchestrator.Spawn_GasTrap(settings);
        break;
      case ParticleOrchestraType.ItemTransfer:
        ParticleOrchestrator.Spawn_ItemTransfer(settings);
        break;
      case ParticleOrchestraType.ShimmerArrow:
        ParticleOrchestrator.Spawn_ShimmerArrow(settings);
        break;
      case ParticleOrchestraType.TownSlimeTransform:
        ParticleOrchestrator.Spawn_TownSlimeTransform(settings);
        break;
      case ParticleOrchestraType.LoadoutChange:
        ParticleOrchestrator.Spawn_LoadOutChange(settings);
        break;
      case ParticleOrchestraType.ShimmerBlock:
        ParticleOrchestrator.Spawn_ShimmerBlock(settings);
        break;
      case ParticleOrchestraType.Digestion:
        ParticleOrchestrator.Spawn_Digestion(settings);
        break;
      case ParticleOrchestraType.WaffleIron:
        ParticleOrchestrator.Spawn_WaffleIron(settings);
        break;
      case ParticleOrchestraType.PooFly:
        ParticleOrchestrator.Spawn_PooFly(settings);
        break;
      case ParticleOrchestraType.ShimmerTownNPC:
        ParticleOrchestrator.Spawn_ShimmerTownNPC(settings);
        break;
      case ParticleOrchestraType.ShimmerTownNPCSend:
        ParticleOrchestrator.Spawn_ShimmerTownNPCSend(settings);
        break;
      case ParticleOrchestraType.DeadCellsMushroomBoiExplosion:
        ParticleOrchestrator.Spawn_DeadCellsMushroomBoiExplosion(settings);
        break;
      case ParticleOrchestraType.DeadCellsDownDashExplosion:
        ParticleOrchestrator.Spawn_DeadCellsDownDashExplosion(settings);
        break;
      case ParticleOrchestraType.DeadCellsBarnacleShotFiring:
        ParticleOrchestrator.Spawn_DeadCellsBarnacleShotFiring(settings);
        break;
      case ParticleOrchestraType.BlueLightningSmall:
        ParticleOrchestrator.Spawn_BlueLightningSmall(settings);
        break;
      case ParticleOrchestraType.ShadowOrbExplosion:
        ParticleOrchestrator.Spawn_ShadowOrbExplosion(settings);
        break;
      case ParticleOrchestraType.UFOLaser:
        ParticleOrchestrator.Spawn_UFOLaser(settings);
        break;
      case ParticleOrchestraType.DeadCellsBeheadedEffect:
        ParticleOrchestrator.Spawn_DeadCellsHeadEffect(settings);
        break;
      case ParticleOrchestraType.DeadCellsFlint:
        ParticleOrchestrator.Spawn_DeadCellsFlint(settings);
        break;
      case ParticleOrchestraType.DeadCellsBarrelExplosion:
        ParticleOrchestrator.Spawn_DeadCellsBarrelExplosion(settings);
        break;
      case ParticleOrchestraType.DeadCellsMushroomBoiTargetFound:
        ParticleOrchestrator.Spawn_DeadCellsMushroomBoiTargetFound(settings);
        break;
      case ParticleOrchestraType.MoonLordWhipHit:
        ParticleOrchestrator.Spawn_MoonLordWhip(settings);
        break;
      case ParticleOrchestraType.MoonLordWhipEye:
        ParticleOrchestrator.Spawn_MoonLordWhipEye(settings);
        break;
      case ParticleOrchestraType.PlayerVoiceOverrideSound:
        ParticleOrchestrator.Spawn_PlayerVoiceOverrideSound(settings);
        break;
      case ParticleOrchestraType.RainbowBoulder1:
        ParticleOrchestrator.Spawn_RainbowBoulder1(settings);
        break;
      case ParticleOrchestraType.RainbowBoulder2:
        ParticleOrchestrator.Spawn_RainbowBoulder2(settings);
        break;
      case ParticleOrchestraType.RainbowBoulder3:
        ParticleOrchestrator.Spawn_RainbowBoulder3(settings);
        break;
      case ParticleOrchestraType.RainbowBoulder4:
        ParticleOrchestrator.Spawn_RainbowBoulder4(settings);
        break;
      case ParticleOrchestraType.FakeFish:
        ParticleOrchestrator.Spawn_FakeFish(settings);
        break;
      case ParticleOrchestraType.LakeSparkle:
        ParticleOrchestrator.Spawn_LakeSparkle(settings);
        break;
      case ParticleOrchestraType.NatureFly:
        ParticleOrchestrator.Spawn_NatureFly(settings);
        break;
      case ParticleOrchestraType.FakeFishJump:
        ParticleOrchestrator.Spawn_FakeFish(settings, true);
        break;
      case ParticleOrchestraType.ClassyCane:
        ParticleOrchestrator.Spawn_ClassyCane(settings);
        break;
      case ParticleOrchestraType.MagnetSphereBolt:
        ParticleOrchestrator.Spawn_MagnetSphereBolt(settings);
        break;
      case ParticleOrchestraType.HeatRay:
        ParticleOrchestrator.Spawn_HeatRay(settings);
        break;
      case ParticleOrchestraType.ShadowbeamHostile:
        ParticleOrchestrator.Spawn_Shadowbeam(settings);
        break;
      case ParticleOrchestraType.ShadowbeamFriendly:
        ParticleOrchestrator.Spawn_Shadowbeam(settings, false);
        break;
      case ParticleOrchestraType.RainbowBoulderPetBounce:
        ParticleOrchestrator.Spawn_RainbowBoulder4(settings, true);
        break;
      case ParticleOrchestraType.StormLightning:
        ParticleOrchestrator.Spawn_StormLightning(settings);
        break;
      case ParticleOrchestraType.StormlightningWindup:
        ParticleOrchestrator.Spawn_StormLightningWindup(settings);
        break;
      case ParticleOrchestraType.PaladinsShieldHit:
        ParticleOrchestrator.Spawn_PaladinsShieldHit(settings);
        break;
      case ParticleOrchestraType.HeroicisSetSpawnSound:
        ParticleOrchestrator.Spawn_HeroicisSetSpawnSound(settings);
        break;
      case ParticleOrchestraType.BlueLightningSmallLong:
        ParticleOrchestrator.Spawn_BlueLightningSmallLong(settings);
        break;
      case ParticleOrchestraType.InScreenDungeonSpawn:
        ParticleOrchestrator.Spawn_InScreenDungeonSpawn(settings);
        break;
      case ParticleOrchestraType.CattivaHit:
        ParticleOrchestrator.Spawn_CattivaHit(settings);
        break;
      case ParticleOrchestraType.PaladinsHammerShockwave:
        ParticleOrchestrator.Spawn_PaladinsHammerShockwave(settings);
        break;
    }
  }

  private static void Spawn_PaladinsHammerShockwave(ParticleOrchestraSettings settings)
  {
    Vector2 positionInWorld = settings.PositionInWorld;
    int x = (int) settings.MovementVector.X;
    int y = (int) settings.MovementVector.Y;
    Vector2 position = positionInWorld + new Vector2((float) x * 0.5f, (float) y * 0.5f);
    SoundEngine.PlaySound(SoundID.Item180, position);
    for (int index1 = 0; index1 < 200; ++index1)
    {
      if (Main.rand.Next(2) == 0)
      {
        int index2 = Dust.NewDust(positionInWorld, x, y, 57, Alpha: 200, Scale: 1.2f);
        Main.dust[index2].velocity = Main.dust[index2].position - position;
        Main.dust[index2].velocity.Normalize();
        Main.dust[index2].velocity *= 9.5f;
        Main.dust[index2].noGravity = true;
      }
      if (Main.rand.Next(3) == 0)
      {
        int index3 = Dust.NewDust(positionInWorld, x, y, 43, Alpha: 254, Scale: 0.3f);
        Main.dust[index3].velocity = Main.dust[index3].position - position;
        Main.dust[index3].velocity.Normalize();
        Main.dust[index3].velocity *= 9.5f;
        Main.dust[index3].noGravity = true;
      }
    }
  }

  private static void Spawn_InScreenDungeonSpawn(ParticleOrchestraSettings settings)
  {
    Vector2 movementVector = settings.MovementVector;
    Vector2 positionInWorld = settings.PositionInWorld;
    int uniqueInfoPiece = settings.UniqueInfoPiece;
    Vector2 vector2_1 = new Vector2(-0.5f, -1f) * movementVector;
    Vector2 vector2_2 = positionInWorld + vector2_1;
    int num = Main.rand.Next(2, 5);
    for (int index = 0; index < num; ++index)
    {
      Gore gore = Gore.NewGorePerfect(vector2_2 + new Vector2(-16f, -16f) + movementVector * new Vector2(Main.rand.NextFloat(), (float) (0.5 + (double) Main.rand.NextFloat() * 0.5)), Main.rand.NextVector2Circular(2f, 2f), Main.rand.Next(61, 64 /*0x40*/));
      gore.scale *= 1f;
      gore.position -= gore.velocity * 5f;
    }
    SoundEngine.PlaySound(ContentSamples.NpcsByNetId[uniqueInfoPiece].HitSound, (int) settings.PositionInWorld.X, (int) settings.PositionInWorld.Y);
  }

  private static void Spawn_HeroicisSetSpawnSound(ParticleOrchestraSettings settings)
  {
    SoundEngine.PlaySound(SoundID.RainbowBoulder, (int) settings.PositionInWorld.X, (int) settings.PositionInWorld.Y);
  }

  private static void Spawn_PaladinsShieldHit(ParticleOrchestraSettings settings)
  {
    Main.instance.LoadItem(938);
    Asset<Texture2D> textureAsset = TextureAssets.Item[938];
    if (!textureAsset.IsLoaded)
      return;
    Vector2 positionInWorld = settings.PositionInWorld;
    int x = (int) positionInWorld.X;
    int y = (int) positionInWorld.Y;
    Vector2 vector2_1 = Vector2.Zero;
    if (Main.player.IndexInRange<Player>(x))
    {
      Player player = Main.player[x];
      vector2_1 = player.MountedCenter;
      FadingParticle fadingParticle = ParticleOrchestrator._poolFading.RequestParticle();
      int timeToLive = 30;
      fadingParticle.followPlayerIndex = x;
      fadingParticle.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 220) * 0.85f;
      fadingParticle.SetBasicInfo(textureAsset, new Rectangle?(), Vector2.Zero, Vector2.Zero);
      fadingParticle.SetTypeInfo((float) timeToLive);
      fadingParticle.FadeInNormalizedTime = 0.1f;
      fadingParticle.FadeOutNormalizedTime = 0.1f;
      fadingParticle.Scale = new Vector2(1f, 1f) * 0.65f;
      fadingParticle.ScaleVelocity = new Vector2(2f, 2f) / (float) timeToLive;
      fadingParticle.ScaleAcceleration = -fadingParticle.ScaleVelocity / (float) timeToLive;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle);
      for (int index = 0; index < 4; ++index)
      {
        Dust dust = Dust.NewDustDirect(player.position, player.width, player.height, 57);
        dust.velocity *= 3f;
        dust.noGravity = true;
        dust.scale = 1f;
        dust.fadeIn = 1.5f;
        dust.noLight = true;
      }
    }
    if (!Main.player.IndexInRange<Player>(y))
      return;
    Player player1 = Main.player[y];
    FadingParticle fadingParticle1 = ParticleOrchestrator._poolFading.RequestParticle();
    float timeToLive1 = 15f;
    fadingParticle1.followPlayerIndex = x;
    fadingParticle1.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) sbyte.MaxValue) * 0.75f;
    fadingParticle1.SetBasicInfo(textureAsset, new Rectangle?(), Vector2.Zero, Vector2.Zero);
    fadingParticle1.SetTypeInfo(timeToLive1);
    fadingParticle1.FadeInNormalizedTime = 0.1f;
    fadingParticle1.FadeOutNormalizedTime = 0.1f;
    fadingParticle1.Scale = new Vector2(1f, 1f) * 0.65f;
    fadingParticle1.ScaleVelocity = new Vector2(2f, 2f) / timeToLive1;
    fadingParticle1.ScaleAcceleration = -fadingParticle1.ScaleVelocity / timeToLive1;
    Vector2 vector2_2 = vector2_1 - player1.MountedCenter;
    fadingParticle1.LocalPosition = -vector2_2;
    if (x == -1)
      fadingParticle1.LocalPosition = player1.MountedCenter;
    fadingParticle1.Velocity = vector2_2 * 0.5f / timeToLive1;
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle1);
    for (int index = 0; index < 4; ++index)
    {
      Dust dust = Dust.NewDustDirect(player1.position, player1.width, player1.height, 57);
      dust.velocity *= 3f;
      dust.noGravity = true;
      dust.scale = 1f;
      dust.fadeIn = 1.5f;
      dust.noLight = true;
    }
  }

  private static void Spawn_StormLightningWindup(ParticleOrchestraSettings settings)
  {
    float num1 = Main.rand.NextFloat() * 6.28318548f;
    float num2 = (float) Main.rand.Next(1, 3);
    float num3 = 0.7f;
    short i = 916;
    Main.instance.LoadProjectile((int) i);
    Color white = Color.White;
    if (settings.UniqueInfoPiece != 0)
      white.PackedValue = (uint) settings.UniqueInfoPiece;
    white.A = (byte) 0;
    for (float num4 = 0.0f; (double) num4 < 1.0; num4 += 1f / num2)
    {
      int timeToLive = Main.rand.Next(7, 11);
      float f = (float) (6.2831854820251465 * (double) num4 + (double) num1 + (double) Main.rand.NextFloatDirection() * 0.25);
      float num5 = (float) ((double) Main.rand.NextFloat() * 3.0 + 0.10000000149011612);
      Vector2 initialLocalPosition = Main.rand.NextVector2Circular(6f, 6f) * num3;
      Color color = white;
      RandomizedFrameParticle randomizedFrameParticle1 = ParticleOrchestrator._poolRandomizedFrame.RequestParticle();
      randomizedFrameParticle1.SetBasicInfo(TextureAssets.Projectile[(int) i], new Rectangle?(), Vector2.Zero, initialLocalPosition);
      randomizedFrameParticle1.SetTypeInfo(Main.projFrames[(int) i], 2, (float) timeToLive);
      randomizedFrameParticle1.Velocity = f.ToRotationVector2() * num5 * new Vector2(1f, 0.5f) + settings.MovementVector * 0.5f;
      randomizedFrameParticle1.ColorTint = color;
      randomizedFrameParticle1.LocalPosition = settings.PositionInWorld + initialLocalPosition;
      randomizedFrameParticle1.Rotation = randomizedFrameParticle1.Velocity.ToRotation();
      randomizedFrameParticle1.Scale = new Vector2(1.5f, 0.75f) * 1f;
      randomizedFrameParticle1.FadeInNormalizedTime = 1f;
      randomizedFrameParticle1.FadeOutNormalizedTime = 0.9f;
      randomizedFrameParticle1.ScaleVelocity = new Vector2(0.025f);
      if (Main.rand.Next(3) == 0)
      {
        RandomizedFrameParticle randomizedFrameParticle2 = randomizedFrameParticle1;
        randomizedFrameParticle2.LocalPosition = randomizedFrameParticle2.LocalPosition + randomizedFrameParticle1.Velocity * (float) (timeToLive - 1);
        RandomizedFrameParticle randomizedFrameParticle3 = randomizedFrameParticle1;
        randomizedFrameParticle3.Velocity = randomizedFrameParticle3.Velocity * -0.5f;
      }
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) randomizedFrameParticle1);
      RandomizedFrameParticle randomizedFrameParticle4 = ParticleOrchestrator._poolRandomizedFrame.RequestParticle();
      randomizedFrameParticle4.SetBasicInfo(TextureAssets.Projectile[(int) i], new Rectangle?(), Vector2.Zero, initialLocalPosition);
      randomizedFrameParticle4.SetTypeInfo(Main.projFrames[(int) i], 2, (float) timeToLive);
      randomizedFrameParticle4.Velocity = randomizedFrameParticle1.Velocity;
      randomizedFrameParticle4.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
      randomizedFrameParticle4.LocalPosition = randomizedFrameParticle1.LocalPosition;
      randomizedFrameParticle4.Rotation = randomizedFrameParticle1.Rotation;
      randomizedFrameParticle4.Scale = randomizedFrameParticle1.Scale * 0.5f;
      randomizedFrameParticle4.FadeInNormalizedTime = randomizedFrameParticle1.FadeInNormalizedTime;
      randomizedFrameParticle4.FadeOutNormalizedTime = randomizedFrameParticle1.FadeOutNormalizedTime;
      randomizedFrameParticle4.ScaleVelocity = randomizedFrameParticle1.ScaleVelocity * 0.5f;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) randomizedFrameParticle4);
    }
  }

  private static void Spawn_StormLightning(ParticleOrchestraSettings settings)
  {
    StormLightningParticle lightningParticle = ParticleOrchestrator.StormLightningParticles.RequestParticle();
    Color white = Color.White;
    if (settings.UniqueInfoPiece != 0)
      white.PackedValue = (uint) settings.UniqueInfoPiece;
    int num1 = 45;
    int x = (int) settings.MovementVector.X;
    lightningParticle.Prepare((uint) x, settings.PositionInWorld, num1, white);
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) lightningParticle);
    settings.PositionInWorld = lightningParticle.EndPosition;
    PunchCameraModifier modifier = new PunchCameraModifier(settings.PositionInWorld, (Main.rand.NextFloat() * 6.28318548f).ToRotationVector2() * new Vector2(0.5f, 1f), MathHelper.Lerp(2f, 10f, Main.SceneState.outsideWeatherEffectIntensity), 3f, 45, 1500f, "StormLightning");
    Main.instance.CameraModifiers.Add((ICameraModifier) modifier);
    Main.NewLightning(true, true);
    SoundEngine.PlaySound(SoundID.InstantThunder, settings.PositionInWorld, volumeScale: MathHelper.Lerp(0.4f, 1f, Main.SceneState.outsideWeatherEffectIntensity));
    Lighting.AddLight(settings.PositionInWorld, (float) white.R / (float) byte.MaxValue, (float) white.G / (float) byte.MaxValue, (float) white.B / (float) byte.MaxValue);
    int num2 = 3;
    Point tileCoordinates = settings.PositionInWorld.ToTileCoordinates();
    for (int i = tileCoordinates.X - 1; i <= tileCoordinates.X + 1; ++i)
    {
      for (int j = tileCoordinates.Y - 1; j <= tileCoordinates.Y + 1; ++j)
      {
        Tile tileSafely = Framing.GetTileSafely(i, j);
        if (tileSafely.active())
        {
          int tileDustAmount = WorldGen.KillTile_GetTileDustAmount(true, tileSafely);
          for (int index = 0; index < tileDustAmount; ++index)
          {
            Dust dust = Main.dust[WorldGen.KillTile_MakeTileDust(i, j, tileSafely)];
            dust.velocity.Y -= (float) (3.0 + (double) num2 * 1.5);
            dust.velocity.Y *= Main.rand.NextFloat();
            dust.velocity.Y *= 0.75f;
            dust.scale += (float) num2 * 0.03f;
          }
          for (int index = 0; index < tileDustAmount - 1; ++index)
          {
            Dust dust = Main.dust[WorldGen.KillTile_MakeTileDust(i, j, tileSafely)];
            dust.velocity.Y -= 1f + (float) num2;
            dust.velocity.Y *= Main.rand.NextFloat();
            dust.velocity.Y *= 0.75f;
          }
          if (tileSafely.type == (ushort) 5)
          {
            for (int index = 0; index < 6; ++index)
            {
              Dust dust = Dust.NewDustDirect(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 6);
              dust.velocity *= 2f;
              dust.fadeIn += Main.rand.NextFloat();
              dust.noLightEmittence = true;
            }
            for (int index = 0; index < 3; ++index)
            {
              Dust dust = Dust.NewDustDirect(new Vector2((float) (i * 16 /*0x10*/), (float) (j * 16 /*0x10*/)), 16 /*0x10*/, 16 /*0x10*/, 31 /*0x1F*/);
              dust.velocity *= 3f;
              dust.noGravity = true;
              dust.fadeIn += 1f + Main.rand.NextFloat();
            }
          }
        }
      }
    }
    ParticleOrchestrator.SpawnLightningExplosionDust(settings.PositionInWorld, white);
    for (int index = 0; index < 4; ++index)
      Gore.NewGoreDirect(settings.PositionInWorld + Utils.RandomVector2(Main.rand, -15f, 15f) * new Vector2(0.5f, 1f) + new Vector2(-20f, 0.0f), Vector2.Zero, 61 + Main.rand.Next(3)).velocity *= 0.5f;
    Vector2 vector2_1 = new Vector2(1.1f);
    Vector2 vector2_2 = new Vector2(-0.9f);
    short i1 = 1091;
    Main.instance.LoadProjectile((int) i1);
    FadingParticle fadingParticle1 = ParticleOrchestrator._poolFading.RequestParticle();
    fadingParticle1.SetBasicInfo(TextureAssets.Projectile[(int) i1], new Rectangle?(), Vector2.Zero, settings.PositionInWorld);
    fadingParticle1.SetTypeInfo((float) num1);
    fadingParticle1.ColorTint = white;
    fadingParticle1.ColorTint.A = (byte) 0;
    fadingParticle1.FadeInNormalizedTime = 0.01f;
    fadingParticle1.FadeOutNormalizedTime = 0.6f;
    fadingParticle1.Scale = vector2_1;
    fadingParticle1.ScaleVelocity = vector2_2 / (float) num1;
    fadingParticle1.ScaleAcceleration = fadingParticle1.ScaleVelocity * (-1f / (float) num1);
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle1);
    FadingParticle fadingParticle2 = ParticleOrchestrator._poolFading.RequestParticle();
    fadingParticle2.SetBasicInfo(TextureAssets.Projectile[(int) i1], new Rectangle?(), Vector2.Zero, settings.PositionInWorld);
    fadingParticle2.SetTypeInfo((float) num1);
    fadingParticle2.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    fadingParticle2.FadeInNormalizedTime = 0.01f;
    fadingParticle2.FadeOutNormalizedTime = 0.6f;
    fadingParticle2.Scale = vector2_1 * 0.7f;
    fadingParticle2.ScaleVelocity = vector2_2 * 0.7f / (float) num1;
    fadingParticle2.ScaleAcceleration = fadingParticle2.ScaleVelocity * (-1f / (float) num1);
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle2);
    float num3 = 12f;
    short i2 = 916;
    Main.instance.LoadProjectile((int) i2);
    for (float num4 = 0.0f; (double) num4 < 1.0; num4 += 1f / num3)
    {
      int timeToLive = Main.rand.Next(14, 22);
      Vector2 initialLocalPosition = Main.rand.NextVector2Circular(6f, 6f) * 0.7f;
      Color color = white;
      RandomizedFrameParticle randomizedFrameParticle1 = ParticleOrchestrator._poolRandomizedFrame.RequestParticle();
      randomizedFrameParticle1.SetBasicInfo(TextureAssets.Projectile[(int) i2], new Rectangle?(), Vector2.Zero, initialLocalPosition);
      randomizedFrameParticle1.SetTypeInfo(Main.projFrames[(int) i2], 3, (float) timeToLive);
      randomizedFrameParticle1.Velocity = Main.rand.NextVector2Circular(6f, 3f);
      randomizedFrameParticle1.ColorTint = color;
      randomizedFrameParticle1.LocalPosition = settings.PositionInWorld + initialLocalPosition;
      randomizedFrameParticle1.Rotation = randomizedFrameParticle1.Velocity.ToRotation();
      randomizedFrameParticle1.Scale = new Vector2(1.5f, 0.75f) * 0.85f;
      randomizedFrameParticle1.FadeInNormalizedTime = 0.01f;
      randomizedFrameParticle1.FadeOutNormalizedTime = 0.0f;
      randomizedFrameParticle1.ScaleVelocity = new Vector2(0.025f);
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) randomizedFrameParticle1);
      RandomizedFrameParticle randomizedFrameParticle2 = ParticleOrchestrator._poolRandomizedFrame.RequestParticle();
      randomizedFrameParticle2.SetBasicInfo(TextureAssets.Projectile[(int) i2], new Rectangle?(), Vector2.Zero, initialLocalPosition);
      randomizedFrameParticle2.SetTypeInfo(Main.projFrames[(int) i2], 3, (float) timeToLive);
      randomizedFrameParticle2.Velocity = randomizedFrameParticle1.Velocity;
      randomizedFrameParticle2.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
      randomizedFrameParticle2.LocalPosition = randomizedFrameParticle1.LocalPosition;
      randomizedFrameParticle2.Rotation = randomizedFrameParticle1.Rotation;
      randomizedFrameParticle2.Scale = randomizedFrameParticle1.Scale * 0.5f;
      randomizedFrameParticle2.FadeInNormalizedTime = randomizedFrameParticle1.FadeInNormalizedTime;
      randomizedFrameParticle2.FadeOutNormalizedTime = randomizedFrameParticle1.FadeOutNormalizedTime;
      randomizedFrameParticle2.ScaleVelocity = randomizedFrameParticle1.ScaleVelocity * 0.5f;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) randomizedFrameParticle2);
    }
  }

  public static void SpawnLightningExplosionDust(Vector2 position, Color customColor)
  {
    for (int index = 0; index < 12; ++index)
    {
      Dust dust = Dust.NewDustPerfect(position, 226);
      dust.HackFrame(278);
      dust.color = customColor;
      dust.customData = (object) dust.color;
      dust.velocity *= (float) (1.0 + (double) Main.rand.NextFloat() * 2.5);
      dust.velocity += new Vector2(0.0f, -2f);
      dust.fadeIn = 0.0f;
      dust.scale = (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.5);
      dust.velocity.X *= 2f;
      dust.position -= dust.velocity * 3f;
    }
    for (int index = 0; index < 6; ++index)
    {
      Dust dust = Dust.NewDustPerfect(position, 226);
      dust.HackFrame(278);
      dust.color = customColor;
      dust.customData = (object) dust.color;
      dust.velocity *= (float) (1.0 + (double) Main.rand.NextFloat() * 2.5);
      dust.velocity += new Vector2(0.0f, -2f);
      dust.fadeIn = (float) (1.7000000476837158 + (double) Main.rand.Next() * 1.0);
      dust.noGravity = true;
      dust.scale = (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.5);
      dust.velocity.X *= 2f;
      dust.velocity *= 0.6f;
      dust.position -= dust.velocity * 3f;
    }
    for (int index = 0; index < 6; ++index)
    {
      Dust dust = Dust.NewDustPerfect(position + Main.rand.NextVector2Circular(20f, 20f), 226);
      dust.HackFrame(278);
      dust.color = customColor;
      dust.customData = (object) dust.color;
      dust.velocity = new Vector2(0.0f, -1f).RotatedByRandom(0.78539818525314331);
      dust.velocity *= (float) (3.0 + (double) Main.rand.NextFloat() * 6.5);
      dust.fadeIn = 0.0f;
      dust.scale = (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.5);
      dust.noGravity = true;
      dust.position -= dust.velocity * 2f;
    }
    for (int index = 0; index < 6; ++index)
    {
      Dust rf = Dust.NewDustPerfect(position, 306, new Vector2?(new Vector2(0.0f, -4f).RotatedByRandom(1.5707963705062866)));
      rf.color = new Color((int) customColor.R, (int) customColor.G, (int) customColor.B, 0);
      rf.scale = 2.8f;
      rf.fadeIn = 0.0f;
      rf.noGravity = Main.rand.Next(3) != 0;
      Dust dust = Dust.CloneDust(rf);
      dust.color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
      dust.scale = 1.9f;
    }
    for (int index = 0; index < 6; ++index)
    {
      Dust rf = Dust.NewDustPerfect(position, 306, new Vector2?(new Vector2(0.0f, -2f).RotatedByRandom(1.5707963705062866)));
      rf.color = new Color((int) customColor.R, (int) customColor.G, (int) customColor.B, 0);
      rf.scale = 2.8f;
      rf.fadeIn = 0.0f;
      rf.noGravity = Main.rand.Next(3) != 0;
      Dust dust = Dust.CloneDust(rf);
      dust.color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
      dust.scale = 1.9f;
    }
    for (int index = 0; index < 3; ++index)
    {
      Dust dust = Dust.NewDustPerfect(position + Main.rand.NextVector2Circular(20f, 20f), 43, new Vector2?(Main.rand.NextVector2Circular(6f, 6f) * Main.rand.NextFloat()), 26, Color.Lerp(customColor, Color.White, Main.rand.NextFloat()), (float) (1.0 + (double) Main.rand.NextFloat() * 1.3999999761581421));
      dust.fadeIn = 1.5f;
      if ((double) dust.velocity.Y > 0.0 && Main.rand.Next(2) == 0)
        dust.velocity.Y *= -1f;
      dust.noGravity = true;
    }
  }

  private static void Spawn_NatureFly(ParticleOrchestraSettings settings)
  {
    int fromValue = ParticleOrchestrator._natureFlies.CountParticlesInUse();
    if (fromValue > 50 && (double) Main.rand.NextFloat() >= (double) Utils.Remap((float) fromValue, 50f, 400f, 0.5f, 0.0f))
      return;
    LittleFlyingCritterParticle flyingCritterParticle = ParticleOrchestrator._natureFlies.RequestParticle();
    Color rgb = Main.hslToRgb(Main.rand.NextFloat() * 0.14f, (float) (0.10000000149011612 + 0.60000002384185791 * (double) Main.rand.NextFloat()), (float) (0.30000001192092896 + 0.30000001192092896 * (double) Main.rand.NextFloat())) with
    {
      A = 170
    };
    flyingCritterParticle.Prepare(LittleFlyingCritterParticle.FlyType.RegularFly, settings.PositionInWorld, Main.rand.Next(180, 301), rgb, 1);
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) flyingCritterParticle);
  }

  private static void Spawn_LakeSparkle(ParticleOrchestraSettings settings)
  {
    FadingParticle fadingParticle = ParticleOrchestrator._poolFading.RequestParticle();
    Vector2 vector2_1 = Vector2.UnitY * (float) (-0.10000000149011612 - 0.40000000596046448 * (double) Main.rand.NextFloat());
    Vector2 vector2_2 = settings.MovementVector / 60f;
    fadingParticle.SetBasicInfo(TextureAssets.Star[0], new Rectangle?(), Vector2.Zero, settings.PositionInWorld);
    float timeToLive = (float) (50.0 + 90.0 * (double) Main.rand.NextFloat());
    fadingParticle.SetTypeInfo(timeToLive);
    fadingParticle.AccelerationPerFrame = vector2_2 / timeToLive;
    fadingParticle.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * Main.rand.NextFloat();
    fadingParticle.FadeInNormalizedTime = 0.45f;
    fadingParticle.FadeOutNormalizedTime = 0.45f;
    fadingParticle.Rotation = Main.rand.NextFloat() * 6.28318548f;
    fadingParticle.RotationVelocity = (float) ((double) Main.rand.NextFloatDirection() * 6.2831854820251465 / 32.0);
    fadingParticle.RotationVelocity *= Utils.Clamp<float>(settings.MovementVector.Length() / 32f, 0.0f, 1f);
    fadingParticle.Scale = Vector2.One * (float) (0.5 + 0.5 * (double) Main.rand.NextFloat());
    Main.ParticleSystem_World_BehindPlayers.Add((IParticle) fadingParticle);
  }

  private static void Spawn_FakeFish(ParticleOrchestraSettings settings, bool jumping = false)
  {
    FakeFishParticle fakeFishParticle = ParticleOrchestrator._fakeFish.RequestParticle();
    Vector2 movementVector = settings.MovementVector;
    int uniqueInfoPiece = settings.UniqueInfoPiece;
    int lifeTimeTotal = Main.rand.Next(240 /*0xF0*/, 421);
    fakeFishParticle.Position = settings.PositionInWorld;
    fakeFishParticle.Velocity = Vector2.Zero;
    fakeFishParticle.Prepare(uniqueInfoPiece, lifeTimeTotal, movementVector);
    if (jumping)
    {
      fakeFishParticle.Velocity = settings.MovementVector;
      fakeFishParticle.TryJumping();
    }
    Main.ParticleSystem_World_BehindPlayers.Add((IParticle) fakeFishParticle);
  }

  public static void MagnetFakeFish(Projectile proj, int searchedItemType)
  {
    foreach (FakeFishParticle fakeFishParticle in (IEnumerable<FakeFishParticle>) Main.ParticleSystem_World_BehindPlayers.Particles.OfType<FakeFishParticle>().OrderBy<FakeFishParticle, float>((Func<FakeFishParticle, float>) (x => x.Position.Distance(proj.Center))))
    {
      if (fakeFishParticle.TryToMagnetizeTo(proj, searchedItemType))
        return;
    }
    using (IEnumerator<FakeFishParticle> enumerator = Main.ParticleSystem_World_BehindPlayers.Particles.OfType<FakeFishParticle>().OrderBy<FakeFishParticle, float>((Func<FakeFishParticle, float>) (x => x.Position.Distance(proj.Center))).GetEnumerator())
    {
      do
        ;
      while (enumerator.MoveNext() && !enumerator.Current.TryToMagnetizeTo(proj));
    }
  }

  public static void PingFakeFish(Projectile proj, int searchedItemType)
  {
    foreach (FakeFishParticle fakeFishParticle in (IEnumerable<FakeFishParticle>) Main.ParticleSystem_World_BehindPlayers.Particles.OfType<FakeFishParticle>().OrderBy<FakeFishParticle, float>((Func<FakeFishParticle, float>) (x => x.Position.Distance(proj.Center))))
      fakeFishParticle.TryToBePinged(proj, searchedItemType);
  }

  public static void PushAwayFakeFish(Projectile proj, int searchedItemType)
  {
    foreach (FakeFishParticle fakeFishParticle in (IEnumerable<FakeFishParticle>) Main.ParticleSystem_World_BehindPlayers.Particles.OfType<FakeFishParticle>().OrderBy<FakeFishParticle, float>((Func<FakeFishParticle, float>) (x => x.Position.Distance(proj.Center))))
      fakeFishParticle.TryToPushAway(proj, searchedItemType);
  }

  public static void RepelAt(Vector2 position, float radius, bool wet)
  {
    ParticleRepelDetails details = new ParticleRepelDetails()
    {
      SourcePosition = position,
      Radius = radius,
      IsInWater = wet
    };
    foreach (IParticle particle in Main.ParticleSystem_World_BehindPlayers.Particles)
    {
      if (particle is IParticleRepel particleRepel)
        particleRepel.BeRepelled(ref details);
    }
    foreach (IParticle particle in Main.ParticleSystem_World_OverPlayers.Particles)
    {
      if (particle is IParticleRepel particleRepel)
        particleRepel.BeRepelled(ref details);
    }
  }

  private static void Spawn_RainbowBoulder4(ParticleOrchestraSettings settings, bool pet = false)
  {
    if (!pet)
      SoundEngine.PlaySound(SoundID.RainbowBoulder, (int) settings.PositionInWorld.X, (int) settings.PositionInWorld.Y);
    int num1 = 14;
    int num2 = 20;
    if (pet)
    {
      num1 = 8;
      num2 = 10;
    }
    for (int index1 = 0; index1 < num1; ++index1)
    {
      int index2 = Dust.NewDust(settings.PositionInWorld, 0, 0, 66, Alpha: 100, newColor: Main.hslToRgb(Main.rand.NextFloat(), 1f, 0.5f), Scale: pet ? 1.2f : 1.7f);
      Main.dust[index2].noGravity = true;
      if (pet)
      {
        Main.dust[index2].velocity *= 2f;
        Main.dust[index2].position = settings.PositionInWorld + Main.rand.NextVector2Circular(30f, 30f);
      }
      else
      {
        Main.dust[index2].velocity *= 3f;
        Main.dust[index2].position = settings.PositionInWorld + Main.rand.NextVector2Circular(30f, 30f);
      }
    }
    int num3 = 20;
    if (pet)
      num3 = 12;
    Rectangle rect = Utils.CenteredRectangle(settings.PositionInWorld, new Vector2((float) num3, (float) num3));
    float radians = settings.MovementVector.ToRotation() + 1.57079637f;
    for (float num4 = 0.0f; (double) num4 < (double) num2; ++num4)
    {
      PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      int num5 = Main.rand.Next(20, 40);
      prettySparkleParticle1.ColorTint = Main.hslToRgb(Main.rand.NextFloat(), 1f, 0.5f, (byte) 0);
      prettySparkleParticle1.LocalPosition = Main.rand.NextVector2FromRectangle(rect);
      prettySparkleParticle1.Rotation = 1.57079637f + radians;
      prettySparkleParticle1.Scale = new Vector2((float) (1.0 + (double) Main.rand.NextFloat() * 1.0), (float) (0.699999988079071 + (double) Main.rand.NextFloat() * 0.699999988079071));
      prettySparkleParticle1.Velocity = new Vector2(0.0f, -1f).RotatedBy((double) radians);
      prettySparkleParticle1.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle1.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle1.TimeToLive = (float) num5;
      prettySparkleParticle1.FadeOutEnd = (float) num5;
      prettySparkleParticle1.FadeInEnd = (float) (num5 / 2);
      prettySparkleParticle1.FadeOutStart = (float) (num5 / 2);
      prettySparkleParticle1.AdditiveAmount = 0.35f;
      prettySparkleParticle1.DrawVerticalAxis = false;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
      PrettySparkleParticle prettySparkleParticle2 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle2.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
      prettySparkleParticle2.LocalPosition = Main.rand.NextVector2FromRectangle(rect);
      prettySparkleParticle2.Rotation = 1.57079637f + radians;
      prettySparkleParticle2.Scale = prettySparkleParticle1.Scale * 0.5f;
      prettySparkleParticle2.Velocity = new Vector2(0.0f, 1f).RotatedBy((double) radians);
      prettySparkleParticle2.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle2.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle2.TimeToLive = (float) num5;
      prettySparkleParticle2.FadeOutEnd = (float) num5;
      prettySparkleParticle2.FadeInEnd = (float) (num5 / 2);
      prettySparkleParticle2.FadeOutStart = (float) (num5 / 2);
      prettySparkleParticle2.AdditiveAmount = 1f;
      prettySparkleParticle2.DrawVerticalAxis = false;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle2);
    }
  }

  private static void Spawn_RainbowBoulder1(ParticleOrchestraSettings settings)
  {
    float num1 = Main.rand.NextFloat() * 6.28318548f;
    float num2 = (float) (6 + Main.rand.Next(7));
    float num3 = Main.rand.NextFloat();
    Main.rand.Next(2);
    for (float num4 = 0.0f; (double) num4 < 1.0; num4 += 1f / num2)
    {
      Vector2 zero = Vector2.Zero;
      Vector2 vector2_1 = new Vector2((float) ((double) Main.rand.NextFloat() * 0.30000001192092896 + 1.0));
      float num5 = num1 + Main.rand.NextFloat() * 6.28318548f;
      float f = num1 + 6.28318548f * num4;
      float num6 = 1.57079637f;
      Vector2 vector2_2 = 0.8f * vector2_1 * (float) (0.89999997615814209 + 0.10000000149011612 * (double) Main.rand.NextFloat());
      float num7 = (float) (Main.rand.Next(20) + 180);
      Vector2 vector2_3 = Main.rand.NextVector2Circular(16f, 16f) * vector2_1;
      Vector2 vector2_4 = Main.rand.NextVector2CircularEdge(1.5f, 1.5f) with
      {
        X = 0.0f
      };
      if ((double) vector2_4.Y > 0.0)
        vector2_4.Y *= -1f;
      PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle1.Velocity = vector2_4 + zero;
      prettySparkleParticle1.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_4 / num7) - zero * 1f / num7;
      prettySparkleParticle1.ColorTint = Main.hslToRgb((float) (((double) num3 + (double) Main.rand.NextFloat() * 0.33000001311302185) % 1.0), 1f, (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.25));
      prettySparkleParticle1.ColorTint = Main.hslToRgb((float) (((double) num4 + (double) num3) % 1.0), 1f, 0.5f);
      prettySparkleParticle1.ColorTint.A = byte.MaxValue;
      prettySparkleParticle1.LocalPosition = settings.PositionInWorld + vector2_3;
      prettySparkleParticle1.Rotation = num6;
      prettySparkleParticle1.Scale = vector2_1;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
      PrettySparkleParticle prettySparkleParticle2 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle2.Velocity = vector2_4 + zero;
      prettySparkleParticle2.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_4 / num7) - zero * 1f / num7;
      prettySparkleParticle2.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
      prettySparkleParticle2.LocalPosition = settings.PositionInWorld + vector2_3;
      prettySparkleParticle2.Rotation = num6;
      prettySparkleParticle2.Scale = vector2_1 * 0.3f;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle2);
    }
    for (int index = 0; index < 21; ++index)
    {
      Dust dust = Dust.NewDustDirect(settings.PositionInWorld, 16 /*0x10*/, 16 /*0x10*/, 66, Alpha: 100, newColor: Main.hslToRgb(Main.rand.NextFloat(), 1f, 0.5f), Scale: 1.7f);
      dust.noGravity = true;
      dust.velocity = Main.rand.NextVector2CircularEdge(1f, 1f) * (float) (8.0 + 2.0 * (double) Main.rand.NextFloat());
      dust.fadeIn = 1f + Main.rand.NextFloat();
      dust.velocity.X = 0.0f;
      if ((double) dust.velocity.Y > 0.0)
        dust.velocity.Y *= -1f;
      dust.position -= dust.velocity * 5f;
    }
  }

  private static void Spawn_RainbowBoulder2(ParticleOrchestraSettings settings)
  {
    FadingParticle fadingParticle1 = ParticleOrchestrator._poolFading.RequestParticle();
    fadingParticle1.SetBasicInfo(TextureAssets.Star[0], new Rectangle?(), settings.MovementVector, settings.PositionInWorld);
    float timeToLive = 25f;
    fadingParticle1.SetTypeInfo(timeToLive);
    fadingParticle1.AccelerationPerFrame = settings.MovementVector / timeToLive;
    fadingParticle1.ColorTint = Main.hslToRgb(Main.rand.NextFloat(), 1f, 0.5f);
    fadingParticle1.FadeInNormalizedTime = 0.5f;
    fadingParticle1.FadeOutNormalizedTime = 0.5f;
    fadingParticle1.Rotation = Main.rand.NextFloat() * 6.28318548f;
    fadingParticle1.Scale = Vector2.One * (float) (0.5 + 0.5 * (double) Main.rand.NextFloat());
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle1);
    FadingParticle fadingParticle2 = fadingParticle1;
    FadingParticle fadingParticle3 = ParticleOrchestrator._poolFading.RequestParticle();
    fadingParticle3.SetBasicInfo(TextureAssets.Star[0], new Rectangle?(), settings.MovementVector, settings.PositionInWorld);
    fadingParticle3.SetTypeInfo(timeToLive);
    fadingParticle3.AccelerationPerFrame = settings.MovementVector / timeToLive;
    fadingParticle3.ColorTint = Main.hslToRgb(Main.rand.NextFloat(), 1f, 1f);
    fadingParticle3.ColorTint.A = (byte) 30;
    fadingParticle3.FadeInNormalizedTime = 0.5f;
    fadingParticle3.FadeOutNormalizedTime = 0.5f;
    fadingParticle3.Rotation = fadingParticle2.Rotation;
    fadingParticle3.Scale = fadingParticle2.Scale * 0.5f;
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle3);
  }

  private static void Spawn_RainbowBoulder3(ParticleOrchestraSettings settings)
  {
    float num1 = Main.rand.NextFloat() * 6.28318548f;
    float num2 = (float) (3 + Main.rand.Next(7));
    float num3 = Main.rand.NextFloat();
    float radians = 1.57079637f * (float) (Main.rand.Next(2) * 2 - 1);
    for (float num4 = 0.0f; (double) num4 < 1.0; num4 += 1f / num2)
    {
      Vector2 vector2_1 = settings.MovementVector * Main.rand.NextFloatDirection() * 0.15f;
      Vector2 vector2_2 = new Vector2((float) ((double) Main.rand.NextFloat() * 0.20000000298023224 + 0.30000001192092896));
      float num5 = num1 + Main.rand.NextFloat() * 6.28318548f;
      float f = num1 + 6.28318548f * num4;
      float num6 = 1.57079637f;
      Vector2 vector2_3 = 0.8f * vector2_2 * (float) (0.30000001192092896 + 1.5 * (double) Main.rand.NextFloat());
      float num7 = (float) (Main.rand.Next(20) + 70);
      Vector2 vector2_4 = (6.28318548f * num4 + num1).ToRotationVector2() * (float) (14.0 - (double) num2 + (double) Main.rand.NextFloat() * 3.0);
      PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle1.Velocity = f.ToRotationVector2() * vector2_3 + vector2_1;
      prettySparkleParticle1.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_3 / num7) - vector2_1 * 1f / num7;
      prettySparkleParticle1.ColorTint = Main.hslToRgb((float) (((double) num3 + (double) Main.rand.NextFloat() * 0.33000001311302185) % 1.0), 1f, (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.25));
      prettySparkleParticle1.ColorTint = Main.hslToRgb((float) (((double) num4 + (double) num3) % 1.0), 1f, 0.5f);
      prettySparkleParticle1.ColorTint.A = byte.MaxValue;
      prettySparkleParticle1.LocalPosition = settings.PositionInWorld + vector2_4;
      prettySparkleParticle1.Rotation = num6;
      prettySparkleParticle1.Scale = vector2_2;
      PrettySparkleParticle prettySparkleParticle2 = prettySparkleParticle1;
      prettySparkleParticle2.LocalPosition = prettySparkleParticle2.LocalPosition + prettySparkleParticle1.Velocity * 4f;
      prettySparkleParticle1.Velocity = prettySparkleParticle1.Velocity.RotatedBy((double) radians);
      prettySparkleParticle1.AccelerationPerFrame = prettySparkleParticle1.AccelerationPerFrame.RotatedBy((double) radians);
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
      PrettySparkleParticle prettySparkleParticle3 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle3.Velocity = f.ToRotationVector2() * vector2_3 + vector2_1;
      prettySparkleParticle3.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_3 / num7) - vector2_1 * 1f / num7;
      prettySparkleParticle3.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
      prettySparkleParticle3.LocalPosition = settings.PositionInWorld + vector2_4;
      prettySparkleParticle3.Rotation = num6;
      prettySparkleParticle3.Scale = vector2_2 * 0.3f;
      PrettySparkleParticle prettySparkleParticle4 = prettySparkleParticle3;
      prettySparkleParticle4.LocalPosition = prettySparkleParticle4.LocalPosition + prettySparkleParticle3.Velocity * 4f;
      prettySparkleParticle3.Velocity = prettySparkleParticle3.Velocity.RotatedBy((double) radians);
      prettySparkleParticle3.AccelerationPerFrame = prettySparkleParticle3.AccelerationPerFrame.RotatedBy((double) radians);
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle3);
    }
    for (int index = 0; index < 4; ++index)
    {
      Color rgb = Main.hslToRgb((float) (((double) num3 + (double) Main.rand.NextFloat() * 0.11999999731779099) % 1.0), 1f, (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.25));
      int dustIndex = Dust.NewDust(settings.PositionInWorld, 0, 0, 267, newColor: rgb);
      Main.dust[dustIndex].velocity = Main.rand.NextVector2Circular(1f, 1f);
      Main.dust[dustIndex].velocity += settings.MovementVector * Main.rand.NextFloatDirection() * 0.5f;
      Main.dust[dustIndex].noGravity = true;
      Main.dust[dustIndex].scale = (float) (0.60000002384185791 + (double) Main.rand.NextFloat() * 0.89999997615814209);
      Main.dust[dustIndex].fadeIn = (float) (0.699999988079071 + (double) Main.rand.NextFloat() * 0.800000011920929);
      Main.dust[dustIndex].noLight = true;
      Main.dust[dustIndex].noLightEmittence = true;
      if (dustIndex != 6000)
      {
        Dust dust = Dust.CloneDust(dustIndex);
        dust.scale /= 2f;
        dust.fadeIn *= 0.75f;
        dust.color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        dust.noLight = true;
        dust.noLightEmittence = true;
      }
    }
  }

  private static void Spawn_MoonLordWhip(ParticleOrchestraSettings settings)
  {
    float num1 = 30f;
    float num2 = 6.28318548f * Main.rand.NextFloat();
    float rotation = settings.MovementVector.SafeNormalize(Vector2.Zero).ToRotation();
    for (float num3 = 0.0f; (double) num3 < 1.0; ++num3)
    {
      PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 v = rotation.ToRotationVector2() * 4f;
      prettySparkleParticle1.ColorTint = new Color(0.3f, 0.6f, 0.7f, 0.5f);
      prettySparkleParticle1.LocalPosition = settings.PositionInWorld;
      prettySparkleParticle1.Rotation = v.ToRotation();
      prettySparkleParticle1.Scale = new Vector2(6f, 0.75f) * 1.1f;
      prettySparkleParticle1.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle1.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle1.TimeToLive = num1;
      prettySparkleParticle1.FadeOutEnd = num1;
      prettySparkleParticle1.FadeInEnd = num1 / 2f;
      prettySparkleParticle1.FadeOutStart = num1 / 2f;
      prettySparkleParticle1.AdditiveAmount = 0.35f;
      PrettySparkleParticle prettySparkleParticle2 = prettySparkleParticle1;
      prettySparkleParticle2.LocalPosition = prettySparkleParticle2.LocalPosition - v * num1 * 0.25f;
      prettySparkleParticle1.Velocity = v;
      prettySparkleParticle1.DrawVerticalAxis = false;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
    }
    for (float num4 = 0.0f; (double) num4 < 1.0; ++num4)
    {
      PrettySparkleParticle prettySparkleParticle3 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 vector2 = rotation.ToRotationVector2() * 4f;
      prettySparkleParticle3.ColorTint = new Color(0.2f, 1f, 0.4f, 1f);
      prettySparkleParticle3.LocalPosition = settings.PositionInWorld;
      prettySparkleParticle3.Rotation = vector2.ToRotation();
      prettySparkleParticle3.Scale = new Vector2(6f, 0.75f) * 0.7f;
      prettySparkleParticle3.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle3.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle3.TimeToLive = num1;
      prettySparkleParticle3.FadeOutEnd = num1;
      prettySparkleParticle3.FadeInEnd = num1 / 2f;
      prettySparkleParticle3.FadeOutStart = num1 / 2f;
      PrettySparkleParticle prettySparkleParticle4 = prettySparkleParticle3;
      prettySparkleParticle4.LocalPosition = prettySparkleParticle4.LocalPosition - vector2 * num1 * 0.25f;
      prettySparkleParticle3.Velocity = vector2;
      prettySparkleParticle3.DrawVerticalAxis = false;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle3);
      for (int index = 0; index < 2; ++index)
      {
        Dust dust1 = Dust.NewDustPerfect(settings.PositionInWorld, 229, new Vector2?(vector2.RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.02500000037252903) * Main.rand.NextFloat()));
        dust1.noGravity = true;
        dust1.scale = 1.2f;
        dust1.position += dust1.velocity * 4f;
        Dust dust2 = Dust.NewDustPerfect(settings.PositionInWorld, 229, new Vector2?(-vector2.RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.02500000037252903) * Main.rand.NextFloat()));
        dust2.noGravity = true;
        dust2.scale = 1.2f;
        dust2.position += dust2.velocity * 4f;
      }
    }
  }

  private static void Spawn_DeadCellsBarrelExplosion(ParticleOrchestraSettings settings)
  {
    Asset<Texture2D> textureAsset = TextureAssets.Extra[269];
    Rectangle rectangle1 = new Rectangle(0, 0, 100, 100);
    Rectangle rectangle2 = new Rectangle(0, 101, 100, 100);
    Rectangle rectangle3 = new Rectangle(0, 202, 100, 100);
    Color color1 = new Color(52, 208 /*0xD0*/, 254, 20);
    Color color2 = new Color(52, 208 /*0xD0*/, 254, 20);
    float timeToLive1 = 25f;
    FadingParticle fadingParticle1 = ParticleOrchestrator._poolFading.RequestParticle();
    fadingParticle1.SetBasicInfo(textureAsset, new Rectangle?(rectangle1), Vector2.Zero, settings.PositionInWorld);
    fadingParticle1.SetTypeInfo(timeToLive1);
    fadingParticle1.ColorTint = color2;
    fadingParticle1.Rotation = Main.rand.NextFloat() * 6.28318548f;
    fadingParticle1.RotationVelocity = (float) (6.2831854820251465 * (1.0 / (double) timeToLive1) * 1.0) * Main.rand.NextFloatDirection();
    fadingParticle1.RotationAcceleration = (float) (-(double) fadingParticle1.RotationVelocity * (1.0 / (double) timeToLive1));
    fadingParticle1.FadeInNormalizedTime = 0.01f;
    fadingParticle1.FadeOutNormalizedTime = 0.1f;
    fadingParticle1.Scale = Vector2.One * 1f;
    fadingParticle1.ScaleVelocity = Vector2.One * (2f / timeToLive1);
    fadingParticle1.ScaleAcceleration = fadingParticle1.ScaleVelocity * (-1f / timeToLive1);
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle1);
    FadingParticle fadingParticle2 = ParticleOrchestrator._poolFading.RequestParticle();
    fadingParticle2.SetBasicInfo(textureAsset, new Rectangle?(rectangle2), Vector2.Zero, settings.PositionInWorld);
    fadingParticle2.SetTypeInfo(timeToLive1 * 0.8f);
    fadingParticle2.ColorTint = color2 * 0.25f;
    fadingParticle2.FadeInNormalizedTime = 0.1f;
    fadingParticle2.FadeOutNormalizedTime = 0.1f;
    fadingParticle2.Scale = Vector2.One * 0.5f;
    fadingParticle2.ScaleVelocity = Vector2.One * 8.5f * (1f / timeToLive1);
    fadingParticle2.ScaleAcceleration = fadingParticle2.ScaleVelocity * (-1f / timeToLive1);
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle2);
    FadingParticle fadingParticle3 = ParticleOrchestrator._poolFading.RequestParticle();
    fadingParticle3.SetBasicInfo(textureAsset, new Rectangle?(rectangle2), Vector2.Zero, settings.PositionInWorld);
    fadingParticle3.SetTypeInfo(timeToLive1);
    fadingParticle3.ColorTint = color2 * 0.3f;
    fadingParticle3.FadeInNormalizedTime = 0.4f;
    fadingParticle3.FadeOutNormalizedTime = 0.5f;
    fadingParticle3.Scale = fadingParticle1.Scale;
    fadingParticle3.ScaleVelocity = fadingParticle1.ScaleVelocity;
    fadingParticle3.ScaleAcceleration = fadingParticle1.ScaleAcceleration;
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle3);
    FadingParticle fadingParticle4 = ParticleOrchestrator._poolFading.RequestParticle();
    fadingParticle4.SetBasicInfo(textureAsset, new Rectangle?(rectangle3), Vector2.Zero, settings.PositionInWorld);
    fadingParticle4.SetTypeInfo(timeToLive1);
    fadingParticle4.ColorTint = color2;
    fadingParticle4.FadeInNormalizedTime = 0.01f;
    fadingParticle4.FadeOutNormalizedTime = 0.7f;
    fadingParticle4.Scale = fadingParticle1.Scale * 0.9f;
    fadingParticle4.ScaleVelocity = fadingParticle1.ScaleVelocity * 1.5f;
    fadingParticle4.ScaleAcceleration = fadingParticle1.ScaleAcceleration * 1.5f;
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle4);
    for (float num = 0.0f; (double) num < 1.0; num += 0.04f)
    {
      float timeToLive2 = 25f;
      float f = 6.28318548f * num;
      FadingParticle fadingParticle5 = ParticleOrchestrator._poolFading.RequestParticle();
      fadingParticle5.SetBasicInfo(TextureAssets.Extra[89], new Rectangle?(), f.ToRotationVector2() * (float) (4.0 + 7.0 * (double) Main.rand.NextFloat()), settings.PositionInWorld + f.ToRotationVector2() * (float) (10.0 + 90.0 * (double) Main.rand.NextFloat()));
      fadingParticle5.SetTypeInfo(timeToLive2);
      fadingParticle5.AccelerationPerFrame = fadingParticle5.Velocity * (-1f / timeToLive2);
      FadingParticle fadingParticle6 = fadingParticle5;
      fadingParticle6.LocalPosition = fadingParticle6.LocalPosition - fadingParticle5.Velocity * 4f;
      fadingParticle5.ColorTint = color1;
      fadingParticle5.Rotation = f + 1.57079637f;
      fadingParticle5.FadeInNormalizedTime = 0.2f;
      fadingParticle5.FadeOutNormalizedTime = 0.3f;
      fadingParticle5.Scale = new Vector2(0.4f, 0.8f) * (float) (0.60000002384185791 + 0.60000002384185791 * (double) Main.rand.NextFloat());
      Main.ParticleSystem_World_BehindPlayers.Add((IParticle) fadingParticle5);
    }
    for (float num = 0.0f; (double) num < 1.0; num += 0.142857149f)
    {
      Dust dust = Dust.NewDustPerfect(settings.PositionInWorld, 267, new Vector2?(Vector2.Zero), newColor: new Color(100, 200, (int) byte.MaxValue, (int) sbyte.MaxValue), Scale: 2f);
      dust.noGravity = true;
      dust.velocity = new Vector2(0.0f, 12f).RotatedBy(6.2831854820251465 * (double) num) * Main.rand.NextFloat();
    }
  }

  private static void Spawn_DeadCellsFlint(ParticleOrchestraSettings settings)
  {
    Vector2 positionInWorld = settings.PositionInWorld;
    float num1 = settings.MovementVector.Y;
    if ((double) num1 == 0.0)
      num1 = 1f;
    float x1 = settings.MovementVector.X;
    bool flag = false;
    Point tileCoordinates1 = (positionInWorld + new Vector2(-x1, -160f)).ToTileCoordinates();
    Point tileCoordinates2 = (positionInWorld + new Vector2(x1, 160f)).ToTileCoordinates();
    int num2 = 3;
    tileCoordinates1.X -= num2;
    tileCoordinates1.Y -= num2;
    tileCoordinates2.X += num2;
    tileCoordinates2.Y += num2;
    int num3 = tileCoordinates1.X / 2 + tileCoordinates2.X / 2;
    int num4 = (int) x1 / 2 + 8 * num2;
    float Hue = 0.12f;
    float num5 = 2f;
    float num6 = 3f;
    float num7 = 40f;
    int num8 = 3;
    for (int x2 = tileCoordinates1.X; x2 <= tileCoordinates2.X; ++x2)
    {
      for (int y = tileCoordinates1.Y; y <= tileCoordinates2.Y; ++y)
      {
        if ((double) Vector2.Distance(positionInWorld, new Vector2((float) (x2 * 16 /*0x10*/), (float) (y * 16 /*0x10*/))) <= (double) num4)
        {
          Tile tileSafely1 = Framing.GetTileSafely(x2, y);
          if (tileSafely1.active() && Main.tileSolid[(int) tileSafely1.type] && !Main.tileSolidTop[(int) tileSafely1.type] && !Main.tileFrameImportant[(int) tileSafely1.type])
          {
            Tile tileSafely2 = Framing.GetTileSafely(x2, y - 1);
            if (!tileSafely2.active() || !Main.tileSolid[(int) tileSafely2.type] || Main.tileSolidTop[(int) tileSafely2.type])
            {
              flag = true;
              if (x2 > tileCoordinates1.X + num2 || x2 < tileCoordinates1.X - num2 || y > tileCoordinates1.Y + num2 || y < tileCoordinates2.Y - num2)
              {
                int tileDustAmount = WorldGen.KillTile_GetTileDustAmount(true, tileSafely1);
                for (int index = 0; index < tileDustAmount; ++index)
                {
                  Dust dust = Main.dust[WorldGen.KillTile_MakeTileDust(x2, y, tileSafely1)];
                  dust.velocity.Y -= (float) (3.0 + (double) num8 * 1.5);
                  dust.velocity.Y *= Main.rand.NextFloat();
                  dust.velocity.Y *= 0.75f;
                  dust.scale += (float) num8 * 0.03f;
                }
                if (num8 >= 2)
                {
                  for (int index = 0; index < tileDustAmount - 1; ++index)
                  {
                    Dust dust = Main.dust[WorldGen.KillTile_MakeTileDust(x2, y, tileSafely1)];
                    dust.velocity.Y -= 1f + (float) num8;
                    dust.velocity.Y *= Main.rand.NextFloat();
                    dust.velocity.Y *= 0.75f;
                  }
                }
                if (tileDustAmount > 0 && Main.rand.Next(2) != 0)
                {
                  float num9 = (float) Math.Abs(num3 - x2) / (num7 / 2f);
                  Gore gore = Gore.NewGoreDirect(positionInWorld, Vector2.Zero, 61 + Main.rand.Next(3), (float) (1.0 - (double) num8 * 0.15000000596046448 + (double) num9 * 0.5));
                  gore.velocity.Y -= (float) (0.10000000149011612 + (double) num8 * 0.5 + (double) num9 * (double) num8 * 1.0);
                  gore.velocity.Y *= Main.rand.NextFloat();
                  gore.velocity.Y *= num1;
                  gore.position = new Vector2((float) (x2 * 16 /*0x10*/) + 20f * num1, (float) (y * 16 /*0x10*/));
                  PrettySparkleParticle prettySparkleParticle = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
                  int num10 = Main.rand.Next(20, 40);
                  prettySparkleParticle.ColorTint = Main.hslToRgb(Hue, 1f, 0.5f, (byte) 0);
                  prettySparkleParticle.LocalPosition = gore.position;
                  prettySparkleParticle.Rotation = 1.57079637f;
                  prettySparkleParticle.Scale = new Vector2(num5 + Main.rand.NextFloat() * num6, (float) (0.699999988079071 + (double) Main.rand.NextFloat() * 0.699999988079071));
                  prettySparkleParticle.Velocity = new Vector2(0.0f, -2f * num1);
                  prettySparkleParticle.FadeInNormalizedTime = 0.1f;
                  prettySparkleParticle.FadeOutNormalizedTime = 0.95f;
                  prettySparkleParticle.TimeToLive = (float) num10;
                  prettySparkleParticle.FadeOutEnd = (float) num10;
                  prettySparkleParticle.FadeInEnd = (float) (num10 / 2);
                  prettySparkleParticle.FadeOutStart = (float) (num10 / 2);
                  prettySparkleParticle.AdditiveAmount = 0.35f;
                  prettySparkleParticle.DrawVerticalAxis = false;
                  Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle);
                }
              }
            }
          }
        }
      }
    }
    if (!flag)
      return;
    SoundEngine.PlaySound(SoundID.DeadCellsFlintRelease, positionInWorld);
    for (int index = 0; index < 30; ++index)
    {
      Vector2 vector2 = Main.rand.NextVector2Circular(5f, 3f);
      if ((double) vector2.Y > 0.0)
        vector2.Y *= -1f;
      Dust.NewDustPerfect(positionInWorld + Main.rand.NextVector2Circular(7f, 0.0f), 228, new Vector2?(vector2), Scale: (float) (0.699999988079071 + 0.800000011920929 * (double) Main.rand.NextFloat()));
    }
    SoundEngine.PlayTrackedSound((SoundStyle) SoundID.DD2_MonkStaffGroundImpact, positionInWorld);
  }

  private static void Spawn_MoonLordWhipEye(ParticleOrchestraSettings settings)
  {
    Asset<Texture2D> textureAsset = TextureAssets.Extra[270];
    if (!textureAsset.IsLoaded)
      return;
    float num = 1f;
    float timeToLive = 45f;
    float f = 6.28318548f * Main.rand.NextFloat();
    FadingParticle fadingParticle = ParticleOrchestrator._poolFading.RequestParticle();
    fadingParticle.SetBasicInfo(textureAsset, new Rectangle?(), Vector2.Zero, Vector2.Zero);
    fadingParticle.SetTypeInfo(timeToLive);
    fadingParticle.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
    fadingParticle.LocalPosition = settings.PositionInWorld + f.ToRotationVector2() * num * timeToLive * 0.5f;
    fadingParticle.Rotation = 0.0f;
    fadingParticle.FadeInNormalizedTime = 0.01f;
    fadingParticle.FadeOutNormalizedTime = 0.1f;
    fadingParticle.Velocity = settings.MovementVector * 0.05f;
    fadingParticle.AccelerationPerFrame = -(settings.MovementVector * 0.25f) / timeToLive;
    fadingParticle.Scale = new Vector2(1f, 1f) * (float) (0.699999988079071 + 0.44999998807907104 * (double) Main.rand.NextFloat());
    Main.ParticleSystem_World_BehindPlayers.Add((IParticle) fadingParticle);
  }

  private static void Spawn_DeadCellsHeadEffect(ParticleOrchestraSettings settings)
  {
    Asset<Texture2D> textureAsset = TextureAssets.Extra[266];
    if (!textureAsset.IsLoaded)
      return;
    Player player = Main.player[(int) settings.IndexOfPlayerWhoInvokedThis];
    if (!player.active)
      return;
    Vector2 v = settings.MovementVector + new Vector2(0.0f, 0.0f);
    for (float num1 = 0.0f; (double) num1 < 1.0; num1 += 0.5f)
    {
      float num2 = 0.5f * Utils.Remap(settings.MovementVector.Length(), 0.0f, 10f, 0.5f, 1f);
      float num3 = 1f;
      float timeToLive = 15f;
      float f = 6.28318548f * Main.rand.NextFloat();
      Vector2 vector2 = Main.rand.NextVector2Circular(4f, 4f) * num2;
      FadingPlayerShaderParticle playerShaderParticle1 = ParticleOrchestrator._poolFadingPlayerShader.RequestParticle();
      playerShaderParticle1.SetBasicInfo(textureAsset, new Rectangle?(), Vector2.Zero, Vector2.Zero);
      playerShaderParticle1.SetTypeInfo(timeToLive, player, player.cHead, false);
      playerShaderParticle1.Velocity = v * 0.5f;
      playerShaderParticle1.AccelerationPerFrame = playerShaderParticle1.Velocity * (float) -(-1.0 / (double) timeToLive) * 0.25f;
      playerShaderParticle1.LocalPosition = settings.PositionInWorld + f.ToRotationVector2() * num3 * num2 * timeToLive * 0.5f + vector2 + v * num1;
      FadingPlayerShaderParticle playerShaderParticle2 = playerShaderParticle1;
      playerShaderParticle2.LocalPosition = playerShaderParticle2.LocalPosition + playerShaderParticle1.Velocity * -0.5f;
      playerShaderParticle1.Rotation = v.ToRotation() + 1.57079637f;
      playerShaderParticle1.FadeInNormalizedTime = 0.01f;
      playerShaderParticle1.FadeOutNormalizedTime = 0.1f;
      playerShaderParticle1.Scale = new Vector2(0.6f, 1.2f) * num2;
      playerShaderParticle1.ScaleVelocity = playerShaderParticle1.Scale * (-1f / timeToLive);
      Main.ParticleSystem_World_BehindPlayers.Add((IParticle) playerShaderParticle1);
    }
  }

  private static void Spawn_UFOLaser(ParticleOrchestraSettings settings)
  {
    ParticleOrchestrator.SpawnHelper_SpawnInLine(settings, (Action<Vector2, Vector2>) ((dustPos, velocity) =>
    {
      ParticleOrchestrator.SpawnHelper_SpawnSingleLineDust(160 /*0xA0*/, dustPos, Main.rand.Next(2) == 0 ? Color.LimeGreen : Color.CornflowerBlue);
      ParticleOrchestrator.SpawnHelper_SpawnSingleLineDust(160 /*0xA0*/, dustPos - velocity * 0.25f, Main.rand.Next(2) == 0 ? Color.LimeGreen : Color.CornflowerBlue);
    }));
  }

  private static void Spawn_MagnetSphereBolt(ParticleOrchestraSettings settings)
  {
    ParticleOrchestrator.SpawnHelper_SpawnInLine(settings, (Action<Vector2, Vector2>) ((dustPos, velocity) =>
    {
      ParticleOrchestrator.SpawnHelper_SpawnSingleLineDust(160 /*0xA0*/, dustPos);
      ParticleOrchestrator.SpawnHelper_SpawnSingleLineDust(160 /*0xA0*/, dustPos - velocity * 0.25f);
      ParticleOrchestrator.SpawnHelper_SpawnSingleLineDust(160 /*0xA0*/, dustPos - velocity * 0.5f);
      ParticleOrchestrator.SpawnHelper_SpawnSingleLineDust(160 /*0xA0*/, dustPos - velocity * 0.75f);
    }));
  }

  private static void Spawn_HeatRay(ParticleOrchestraSettings settings)
  {
    ParticleOrchestrator.SpawnHelper_SpawnInLine(settings, (Action<Vector2, Vector2>) ((dustPos, velocity) =>
    {
      ParticleOrchestrator.SpawnHelper_SpawnSingleLineDust(162, dustPos);
      ParticleOrchestrator.SpawnHelper_SpawnSingleLineDust(162, dustPos - velocity * 0.25f);
      ParticleOrchestrator.SpawnHelper_SpawnSingleLineDust(162, dustPos - velocity * 0.5f);
      ParticleOrchestrator.SpawnHelper_SpawnSingleLineDust(162, dustPos - velocity * 0.75f);
    }));
  }

  private static void Spawn_Shadowbeam(ParticleOrchestraSettings settings, bool hostile = true)
  {
    float velocityScalar = 0.25f;
    if (hostile)
      velocityScalar = 0.03334f;
    ParticleOrchestrator.SpawnHelper_SpawnInLine(settings, (Action<Vector2, Vector2>) ((dustPos, velocity) =>
    {
      ParticleOrchestrator.SpawnHelper_SpawnSingleLineDust(173, dustPos);
      ParticleOrchestrator.SpawnHelper_SpawnSingleLineDust(173, dustPos - velocity * velocityScalar);
      ParticleOrchestrator.SpawnHelper_SpawnSingleLineDust(173, dustPos - velocity * velocityScalar * 2f);
    }));
  }

  private static void SpawnHelper_SpawnInLine(
    ParticleOrchestraSettings settings,
    Action<Vector2, Vector2> effectsPerStep = null)
  {
    if (effectsPerStep == null)
      return;
    Vector2 positionInWorld = settings.PositionInWorld;
    Vector2 movementVector = settings.MovementVector;
    Vector2 vector2_1 = (positionInWorld - movementVector).SafeNormalize(Vector2.Zero) * ((float) settings.UniqueInfoPiece / 1000f);
    float num1 = (positionInWorld - movementVector).Length();
    float num2 = vector2_1.Length();
    if ((double) num2 < 4.0)
      num2 = 4f;
    for (float num3 = 0.0f; (double) num3 < (double) num1; num3 += num2)
    {
      float amount = num3 / num1;
      Vector2 vector2_2 = Vector2.Lerp(movementVector, positionInWorld, amount);
      effectsPerStep(vector2_2, vector2_1);
    }
  }

  private static void SpawnHelper_SpawnSingleLineDust(int dustId, Vector2 dustPos, Color color = default (Color))
  {
    Vector2 Position = dustPos;
    Dust dust = Main.dust[Dust.NewDust(Position, 1, 1, dustId)];
    dust.position = Position;
    dust.scale = (float) Main.rand.Next(70, 110) * 0.013f;
    dust.velocity *= 0.2f;
    if (!(color != new Color()))
      return;
    dust.color = color;
  }

  private static void Spawn_ShadowOrbExplosion(ParticleOrchestraSettings settings)
  {
    float num1 = (float) (20.0 + 10.0 * (double) Main.rand.NextFloat());
    float num2 = -0.7853982f;
    float num3 = (float) (0.20000000298023224 + 0.40000000596046448 * (double) Main.rand.NextFloat());
    Color rgb = Main.hslToRgb((float) ((double) Main.rand.NextFloat() * 0.05000000074505806 + 0.75), 1f, 0.5f);
    rgb.A /= (byte) 2;
    Color color = rgb * (float) ((double) Main.rand.NextFloat() * 0.30000001192092896 + 0.699999988079071);
    for (float num4 = 0.0f; (double) num4 < 2.0; ++num4)
    {
      PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 v = ((float) (0.78539818525314331 + 3.1415927410125732 * (double) num4) + num2).ToRotationVector2() * 4f;
      prettySparkleParticle1.ColorTint = color;
      prettySparkleParticle1.LocalPosition = settings.PositionInWorld + Main.rand.NextVector2Circular(16f, 16f);
      prettySparkleParticle1.Rotation = v.ToRotation();
      prettySparkleParticle1.Scale = new Vector2(4f, 1f) * 1.1f * num3;
      prettySparkleParticle1.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle1.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle1.TimeToLive = num1;
      prettySparkleParticle1.FadeOutEnd = num1;
      prettySparkleParticle1.FadeInEnd = num1 / 2f;
      prettySparkleParticle1.FadeOutStart = num1 / 2f;
      prettySparkleParticle1.AdditiveAmount = 0.35f;
      PrettySparkleParticle prettySparkleParticle2 = prettySparkleParticle1;
      prettySparkleParticle2.LocalPosition = prettySparkleParticle2.LocalPosition - v * num1 * 0.25f;
      prettySparkleParticle1.Velocity = v * 0.05f;
      prettySparkleParticle1.DrawVerticalAxis = false;
      if ((double) num4 == 1.0)
      {
        PrettySparkleParticle prettySparkleParticle3 = prettySparkleParticle1;
        prettySparkleParticle3.Scale = prettySparkleParticle3.Scale * 1.5f;
        PrettySparkleParticle prettySparkleParticle4 = prettySparkleParticle1;
        prettySparkleParticle4.Velocity = prettySparkleParticle4.Velocity * 1.5f;
        PrettySparkleParticle prettySparkleParticle5 = prettySparkleParticle1;
        prettySparkleParticle5.LocalPosition = prettySparkleParticle5.LocalPosition - prettySparkleParticle1.Velocity * 4f;
      }
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
    }
    for (float num5 = 0.0f; (double) num5 < 2.0; ++num5)
    {
      PrettySparkleParticle prettySparkleParticle6 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 vector2 = ((float) (0.78539818525314331 + 3.1415927410125732 * (double) num5) + num2).ToRotationVector2() * 4f;
      prettySparkleParticle6.ColorTint = new Color(0.7583333f, 0.4f, 0.2f, 1f);
      prettySparkleParticle6.LocalPosition = settings.PositionInWorld + Main.rand.NextVector2Circular(16f, 16f);
      prettySparkleParticle6.Rotation = vector2.ToRotation();
      prettySparkleParticle6.Scale = new Vector2(4f, 1f) * 0.7f * num3;
      prettySparkleParticle6.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle6.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle6.TimeToLive = num1;
      prettySparkleParticle6.FadeOutEnd = num1;
      prettySparkleParticle6.FadeInEnd = num1 / 2f;
      prettySparkleParticle6.FadeOutStart = num1 / 2f;
      PrettySparkleParticle prettySparkleParticle7 = prettySparkleParticle6;
      prettySparkleParticle7.LocalPosition = prettySparkleParticle7.LocalPosition - vector2 * num1 * 0.25f;
      prettySparkleParticle6.Velocity = vector2 * 0.05f;
      prettySparkleParticle6.DrawVerticalAxis = false;
      if ((double) num5 == 1.0)
      {
        PrettySparkleParticle prettySparkleParticle8 = prettySparkleParticle6;
        prettySparkleParticle8.Scale = prettySparkleParticle8.Scale * 1.5f;
        PrettySparkleParticle prettySparkleParticle9 = prettySparkleParticle6;
        prettySparkleParticle9.Velocity = prettySparkleParticle9.Velocity * 1.5f;
        PrettySparkleParticle prettySparkleParticle10 = prettySparkleParticle6;
        prettySparkleParticle10.LocalPosition = prettySparkleParticle10.LocalPosition - prettySparkleParticle6.Velocity * 4f;
      }
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle6);
      for (int index = 0; index < 1; ++index)
      {
        Dust dust1 = Dust.NewDustPerfect(settings.PositionInWorld, 6, new Vector2?(vector2.RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.02500000037252903) * Main.rand.NextFloat()));
        dust1.noGravity = true;
        dust1.scale = 1.4f;
        Dust dust2 = Dust.NewDustPerfect(settings.PositionInWorld, 6, new Vector2?(-vector2.RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.02500000037252903) * Main.rand.NextFloat()));
        dust2.noGravity = true;
        dust2.scale = 1.4f;
      }
    }
    Vector2 Position = settings.PositionInWorld + new Vector2(-18f, -16f);
    float circleHalfWidth = 4f;
    float circleHalfHeight = 4f;
    for (int index = 0; index < 0; ++index)
    {
      int num6 = index % 2;
      Gore gore1 = Gore.NewGoreDirect(Position, Vector2.Zero, 99, (float) (1.0 + (double) Main.rand.NextFloat() * 0.30000001192092896));
      gore1.velocity = Main.rand.NextVector2Circular(circleHalfWidth, circleHalfHeight);
      gore1.alpha = (int) sbyte.MaxValue;
      gore1.rotation = 6.28318548f * Main.rand.NextFloat();
      gore1.position += gore1.velocity * 4f;
      Gore gore2 = Gore.NewGoreDirect(Position, Vector2.Zero, 99, (float) (0.800000011920929 + (double) Main.rand.NextFloat() * 0.30000001192092896));
      gore2.velocity = Main.rand.NextVector2Circular(circleHalfWidth, circleHalfHeight);
      gore2.alpha = (int) sbyte.MaxValue;
      gore2.rotation = 6.28318548f * Main.rand.NextFloat();
      gore2.position += gore2.velocity * 4f;
      Gore gore3 = Gore.NewGoreDirect(Position, Vector2.Zero, 99, (float) (1.2000000476837158 + (double) Main.rand.NextFloat() * 0.30000001192092896));
      gore3.velocity = Main.rand.NextVector2Circular(circleHalfWidth, circleHalfHeight);
      gore3.alpha = (int) sbyte.MaxValue;
      gore3.rotation = 6.28318548f * Main.rand.NextFloat();
      gore3.position += gore3.velocity * 4f;
    }
  }

  private static void Spawn_DeadCellsDownDashExplosion(ParticleOrchestraSettings settings)
  {
    Vector2 positionInWorld = settings.PositionInWorld;
    SoundEngine.PlayTrackedSound((SoundStyle) SoundID.DD2_MonkStaffGroundImpact, positionInWorld);
    float x1 = settings.MovementVector.X;
    Point tileCoordinates1 = (positionInWorld + new Vector2(-x1, -160f)).ToTileCoordinates();
    Point tileCoordinates2 = (positionInWorld + new Vector2(x1, 160f)).ToTileCoordinates();
    int num1 = tileCoordinates1.X / 2 + tileCoordinates2.X / 2;
    int num2 = (int) x1 / 2;
    bool flag = settings.UniqueInfoPiece == 1;
    float Hue = flag ? 0.01f : 0.55f;
    float num3 = flag ? 2f : 1f;
    float num4 = flag ? 3f : 2f;
    for (int index = 0; index < 40; ++index)
    {
      Vector2 vector2 = Main.rand.NextVector2Circular(5f, 3f);
      if ((double) vector2.Y > 0.0)
        vector2.Y *= -1f;
      if (flag)
        vector2 *= 1.5f;
      Dust dust = Dust.CloneDust(Dust.NewDustPerfect(positionInWorld + Main.rand.NextVector2Circular(10f, 0.0f), 306, new Vector2?(vector2), newColor: Main.hslToRgb(Hue, 1f, 0.5f), Scale: (float) (1.8999999761581421 + 0.800000011920929 * (double) Main.rand.NextFloat())));
      dust.scale -= 0.6f;
      dust.color = Color.White;
    }
    float num5 = 40f;
    int num6 = 3;
    for (int x2 = tileCoordinates1.X; x2 <= tileCoordinates2.X; ++x2)
    {
      for (int y = tileCoordinates1.Y; y <= tileCoordinates2.Y; ++y)
      {
        if ((double) Vector2.Distance(positionInWorld, new Vector2((float) (x2 * 16 /*0x10*/), (float) (y * 16 /*0x10*/))) <= (double) num2)
        {
          Tile tileSafely1 = Framing.GetTileSafely(x2, y);
          if (tileSafely1.active() && Main.tileSolid[(int) tileSafely1.type] && (!Main.tileSolidTop[(int) tileSafely1.type] || tileSafely1.frameY == (short) 0) && (!Main.tileFrameImportant[(int) tileSafely1.type] || Main.tileSolidTop[(int) tileSafely1.type]))
          {
            Tile tileSafely2 = Framing.GetTileSafely(x2, y - 1);
            if (!tileSafely2.active() || !Main.tileSolid[(int) tileSafely2.type] || Main.tileSolidTop[(int) tileSafely2.type])
            {
              int tileDustAmount = WorldGen.KillTile_GetTileDustAmount(true, tileSafely1);
              for (int index = 0; index < tileDustAmount; ++index)
              {
                Dust dust = Main.dust[WorldGen.KillTile_MakeTileDust(x2, y, tileSafely1)];
                dust.velocity.Y -= (float) (3.0 + (double) num6 * 1.5);
                dust.velocity.Y *= Main.rand.NextFloat();
                dust.velocity.Y *= 0.75f;
                dust.scale += (float) num6 * 0.03f;
              }
              if (num6 >= 2)
              {
                for (int index = 0; index < tileDustAmount - 1; ++index)
                {
                  Dust dust = Main.dust[WorldGen.KillTile_MakeTileDust(x2, y, tileSafely1)];
                  dust.velocity.Y -= 1f + (float) num6;
                  dust.velocity.Y *= Main.rand.NextFloat();
                  dust.velocity.Y *= 0.75f;
                }
              }
              if (tileDustAmount > 0 && Main.rand.Next(3) != 0)
              {
                float num7 = (float) Math.Abs(num1 - x2) / (num5 / 2f);
                Gore gore = Gore.NewGoreDirect(positionInWorld, Vector2.Zero, 61 + Main.rand.Next(3), (float) (1.0 - (double) num6 * 0.15000000596046448 + (double) num7 * 0.5));
                gore.velocity.Y -= (float) (0.10000000149011612 + (double) num6 * 0.5 + (double) num7 * (double) num6 * 1.0);
                gore.velocity.Y *= Main.rand.NextFloat();
                gore.position = new Vector2((float) (x2 * 16 /*0x10*/ + 20), (float) (y * 16 /*0x10*/));
                PrettySparkleParticle prettySparkleParticle = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
                int num8 = Main.rand.Next(20, 40);
                prettySparkleParticle.ColorTint = Main.hslToRgb(Hue + 0.1f * Main.rand.NextFloat(), 1f, 0.5f, (byte) 0);
                prettySparkleParticle.LocalPosition = gore.position;
                prettySparkleParticle.Rotation = 1.57079637f;
                prettySparkleParticle.Scale = new Vector2(num3 + Main.rand.NextFloat() * num4, (float) (0.699999988079071 + (double) Main.rand.NextFloat() * 0.699999988079071));
                prettySparkleParticle.Velocity = new Vector2(0.0f, -2f);
                prettySparkleParticle.FadeInNormalizedTime = 0.1f;
                prettySparkleParticle.FadeOutNormalizedTime = 0.95f;
                prettySparkleParticle.TimeToLive = (float) num8;
                prettySparkleParticle.FadeOutEnd = (float) num8;
                prettySparkleParticle.FadeInEnd = (float) (num8 / 2);
                prettySparkleParticle.FadeOutStart = (float) (num8 / 2);
                prettySparkleParticle.AdditiveAmount = 0.35f;
                prettySparkleParticle.DrawVerticalAxis = false;
                Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle);
              }
            }
          }
        }
      }
    }
  }

  private static void Spawn_ShimmerTownNPCSend(ParticleOrchestraSettings settings)
  {
    Rectangle rect = Utils.CenteredRectangle(settings.PositionInWorld, new Vector2(30f, 60f));
    for (float num1 = 0.0f; (double) num1 < 20.0; ++num1)
    {
      PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      int num2 = Main.rand.Next(20, 40);
      prettySparkleParticle1.ColorTint = Main.hslToRgb(Main.rand.NextFloat(), 1f, 0.5f, (byte) 0);
      prettySparkleParticle1.LocalPosition = Main.rand.NextVector2FromRectangle(rect);
      prettySparkleParticle1.Rotation = 1.57079637f;
      prettySparkleParticle1.Scale = new Vector2((float) (1.0 + (double) Main.rand.NextFloat() * 2.0), (float) (0.699999988079071 + (double) Main.rand.NextFloat() * 0.699999988079071));
      prettySparkleParticle1.Velocity = new Vector2(0.0f, -1f);
      prettySparkleParticle1.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle1.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle1.TimeToLive = (float) num2;
      prettySparkleParticle1.FadeOutEnd = (float) num2;
      prettySparkleParticle1.FadeInEnd = (float) (num2 / 2);
      prettySparkleParticle1.FadeOutStart = (float) (num2 / 2);
      prettySparkleParticle1.AdditiveAmount = 0.35f;
      prettySparkleParticle1.DrawVerticalAxis = false;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
      PrettySparkleParticle prettySparkleParticle2 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle2.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
      prettySparkleParticle2.LocalPosition = Main.rand.NextVector2FromRectangle(rect);
      prettySparkleParticle2.Rotation = 1.57079637f;
      prettySparkleParticle2.Scale = prettySparkleParticle1.Scale * 0.5f;
      prettySparkleParticle2.Velocity = new Vector2(0.0f, -1f);
      prettySparkleParticle2.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle2.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle2.TimeToLive = (float) num2;
      prettySparkleParticle2.FadeOutEnd = (float) num2;
      prettySparkleParticle2.FadeInEnd = (float) (num2 / 2);
      prettySparkleParticle2.FadeOutStart = (float) (num2 / 2);
      prettySparkleParticle2.AdditiveAmount = 1f;
      prettySparkleParticle2.DrawVerticalAxis = false;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle2);
    }
  }

  private static void Spawn_ShimmerTownNPC(ParticleOrchestraSettings settings)
  {
    Rectangle rectangle = Utils.CenteredRectangle(settings.PositionInWorld, new Vector2(30f, 60f));
    for (float num1 = 0.0f; (double) num1 < 20.0; ++num1)
    {
      PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      int num2 = Main.rand.Next(20, 40);
      prettySparkleParticle1.ColorTint = Main.hslToRgb(Main.rand.NextFloat(), 1f, 0.5f, (byte) 0);
      prettySparkleParticle1.LocalPosition = Main.rand.NextVector2FromRectangle(rectangle);
      prettySparkleParticle1.Rotation = 1.57079637f;
      prettySparkleParticle1.Scale = new Vector2((float) (1.0 + (double) Main.rand.NextFloat() * 2.0), (float) (0.699999988079071 + (double) Main.rand.NextFloat() * 0.699999988079071));
      prettySparkleParticle1.Velocity = new Vector2(0.0f, -1f);
      prettySparkleParticle1.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle1.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle1.TimeToLive = (float) num2;
      prettySparkleParticle1.FadeOutEnd = (float) num2;
      prettySparkleParticle1.FadeInEnd = (float) (num2 / 2);
      prettySparkleParticle1.FadeOutStart = (float) (num2 / 2);
      prettySparkleParticle1.AdditiveAmount = 0.35f;
      prettySparkleParticle1.DrawVerticalAxis = false;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
      PrettySparkleParticle prettySparkleParticle2 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle2.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
      prettySparkleParticle2.LocalPosition = Main.rand.NextVector2FromRectangle(rectangle);
      prettySparkleParticle2.Rotation = 1.57079637f;
      prettySparkleParticle2.Scale = prettySparkleParticle1.Scale * 0.5f;
      prettySparkleParticle2.Velocity = new Vector2(0.0f, -1f);
      prettySparkleParticle2.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle2.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle2.TimeToLive = (float) num2;
      prettySparkleParticle2.FadeOutEnd = (float) num2;
      prettySparkleParticle2.FadeInEnd = (float) (num2 / 2);
      prettySparkleParticle2.FadeOutStart = (float) (num2 / 2);
      prettySparkleParticle2.AdditiveAmount = 1f;
      prettySparkleParticle2.DrawVerticalAxis = false;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle2);
    }
    for (int index1 = 0; index1 < 20; ++index1)
    {
      int index2 = Dust.NewDust(rectangle.TopLeft(), rectangle.Width, rectangle.Height, 308);
      Main.dust[index2].velocity.Y -= 8f;
      Main.dust[index2].velocity.X *= 0.5f;
      Main.dust[index2].scale = 0.8f;
      Main.dust[index2].noGravity = true;
      switch (Main.rand.Next(6))
      {
        case 0:
          Main.dust[index2].color = new Color((int) byte.MaxValue, (int) byte.MaxValue, 210);
          break;
        case 1:
          Main.dust[index2].color = new Color(190, 245, (int) byte.MaxValue);
          break;
        case 2:
          Main.dust[index2].color = new Color((int) byte.MaxValue, 150, (int) byte.MaxValue);
          break;
        default:
          Main.dust[index2].color = new Color(190, 175, (int) byte.MaxValue);
          break;
      }
    }
    SoundEngine.PlaySound(SoundID.Item29, settings.PositionInWorld);
  }

  private static void Spawn_PooFly(ParticleOrchestraSettings settings)
  {
    int fromValue = ParticleOrchestrator._poolFlies.CountParticlesInUse();
    if (fromValue > 50 && (double) Main.rand.NextFloat() >= (double) Utils.Remap((float) fromValue, 50f, 400f, 0.5f, 0.0f))
      return;
    LittleFlyingCritterParticle flyingCritterParticle = ParticleOrchestrator._poolFlies.RequestParticle();
    flyingCritterParticle.Prepare(LittleFlyingCritterParticle.FlyType.RegularFly, settings.PositionInWorld, 300);
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) flyingCritterParticle);
  }

  private static void Spawn_Digestion(ParticleOrchestraSettings settings)
  {
    Vector2 positionInWorld = settings.PositionInWorld;
    int num1 = (double) settings.MovementVector.X < 0.0 ? 1 : -1;
    int num2 = Main.rand.Next(4);
    for (int index1 = 0; index1 < 3 + num2; ++index1)
    {
      int index2 = Dust.NewDust(positionInWorld + Vector2.UnitX * (float) -num1 * 8f - Vector2.One * 5f + Vector2.UnitY * 8f, 3, 6, 216, (float) -num1, 1f);
      Main.dust[index2].velocity /= 2f;
      Main.dust[index2].scale = 0.8f;
    }
    if (Main.rand.Next(30) == 0)
    {
      int index = Gore.NewGore(positionInWorld + Vector2.UnitX * (float) -num1 * 8f, Vector2.Zero, Main.rand.Next(580, 583));
      Main.gore[index].velocity /= 2f;
      Main.gore[index].velocity.Y = Math.Abs(Main.gore[index].velocity.Y);
      Main.gore[index].velocity.X = -Math.Abs(Main.gore[index].velocity.X) * (float) num1;
    }
    SoundEngine.PlaySound(SoundID.Item16, settings.PositionInWorld);
  }

  private static void Spawn_ShimmerBlock(ParticleOrchestraSettings settings)
  {
    float num = (float) settings.UniqueInfoPiece / 1000f;
    if ((double) num <= 0.0)
      num = 1f;
    FadingParticle fadingParticle = ParticleOrchestrator._poolFading.RequestParticle();
    fadingParticle.SetBasicInfo(TextureAssets.Star[0], new Rectangle?(), settings.MovementVector, settings.PositionInWorld);
    float timeToLive = 45f;
    fadingParticle.SetTypeInfo(timeToLive);
    fadingParticle.AccelerationPerFrame = settings.MovementVector / timeToLive;
    fadingParticle.ColorTint = Main.hslToRgb(Main.rand.NextFloat(), 0.75f, 0.8f);
    fadingParticle.ColorTint.A = (byte) 30;
    fadingParticle.FadeInNormalizedTime = 0.5f;
    fadingParticle.FadeOutNormalizedTime = 0.5f;
    fadingParticle.Rotation = Main.rand.NextFloat() * 6.28318548f;
    fadingParticle.Scale = Vector2.One * (float) (0.5 + 0.5 * (double) Main.rand.NextFloat()) * num;
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle);
  }

  private static void Spawn_LoadOutChange(ParticleOrchestraSettings settings)
  {
    Player player = Main.player[(int) settings.IndexOfPlayerWhoInvokedThis];
    if (!player.active)
      return;
    Rectangle hitbox = player.Hitbox;
    int num1 = 6;
    hitbox.Height -= num1;
    if ((double) player.gravDir == 1.0)
      hitbox.Y += num1;
    for (int index = 0; index < 40; ++index)
    {
      Dust dust = Dust.NewDustPerfect(Main.rand.NextVector2FromRectangle(hitbox), 16 /*0x10*/, Alpha: 120, Scale: (float) ((double) Main.rand.NextFloat() * 0.800000011920929 + 0.800000011920929));
      dust.velocity = new Vector2(0.0f, (float) ((double) -hitbox.Height * (double) Main.rand.NextFloat() * 0.039999999105930328)).RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.10000000149011612);
      dust.velocity += player.velocity * 2f * Main.rand.NextFloat();
      dust.noGravity = true;
      int num2;
      bool flag = (num2 = 1) != 0;
      dust.noLightEmittence = num2 != 0;
      dust.noLight = flag;
    }
    for (int index = 0; index < 5; ++index)
    {
      Dust dust = Dust.NewDustPerfect(Main.rand.NextVector2FromRectangle(hitbox), 43, Alpha: 254, newColor: Main.hslToRgb(Main.rand.NextFloat(), 0.3f, 0.8f), Scale: (float) ((double) Main.rand.NextFloat() * 0.800000011920929 + 0.800000011920929));
      dust.velocity = new Vector2(0.0f, (float) ((double) -hitbox.Height * (double) Main.rand.NextFloat() * 0.039999999105930328)).RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.10000000149011612);
      dust.velocity += player.velocity * 2f * Main.rand.NextFloat();
      dust.noGravity = true;
      int num3;
      bool flag = (num3 = 1) != 0;
      dust.noLightEmittence = num3 != 0;
      dust.noLight = flag;
    }
  }

  private static void Spawn_TownSlimeTransform(ParticleOrchestraSettings settings)
  {
    switch (settings.UniqueInfoPiece)
    {
      case 0:
        ParticleOrchestrator.NerdySlimeEffect(settings);
        break;
      case 1:
        ParticleOrchestrator.CopperSlimeEffect(settings);
        break;
      case 2:
        ParticleOrchestrator.ElderSlimeEffect(settings);
        break;
    }
  }

  private static void Spawn_DeadCellsMushroomBoiExplosion(ParticleOrchestraSettings settings)
  {
    if (Main.rand.Next(2) == 0)
    {
      int index = Main.rand.Next(ParticleOrchestrator._mushBoiExplosionSounds.Length);
      ActiveSound activeSound = SoundEngine.GetActiveSound(ParticleOrchestrator._mushBoiExplosionSounds[index]);
      if (activeSound != null && activeSound.IsPlaying)
        activeSound.Stop();
      ParticleOrchestrator._mushBoiExplosionSounds[index] = SoundEngine.PlayTrackedSound((SoundStyle) SoundID.DeadCellsMushroomExplode, settings.PositionInWorld);
    }
    BloodyExplosionParticle explosionParticle = ParticleOrchestrator._poolBloodyExplosion.RequestParticle();
    Color color1 = new Color((int) byte.MaxValue, 10, 10, 50) * 0.35f;
    explosionParticle.ColorTint = explosionParticle.LightColorTint = color1;
    explosionParticle.LocalPosition = settings.PositionInWorld;
    explosionParticle.TimeToLive = 10f;
    explosionParticle.FadeInNormalizedTime = 0.3f;
    explosionParticle.FadeOutNormalizedTime = 0.6f;
    explosionParticle.Velocity = Vector2.Zero;
    explosionParticle.InitialScale = 1f;
    Main.ParticleSystem_World_BehindPlayers.Add((IParticle) explosionParticle);
    Asset<Texture2D> textureAsset = TextureAssets.Extra[269];
    Rectangle rectangle1 = new Rectangle(0, 0, 100, 100);
    Rectangle rectangle2 = new Rectangle(0, 101, 100, 100);
    Rectangle rectangle3 = new Rectangle(0, 202, 100, 100);
    Color color2 = new Color((int) byte.MaxValue, 10, 10, (int) sbyte.MaxValue) * 0.45f;
    Color color3 = new Color((int) byte.MaxValue, 10, 10, (int) sbyte.MaxValue) * 0.45f;
    float timeToLive1 = 15f;
    FadingParticle fadingParticle1 = ParticleOrchestrator._poolFading.RequestParticle();
    fadingParticle1.SetBasicInfo(textureAsset, new Rectangle?(rectangle1), Vector2.Zero, settings.PositionInWorld);
    fadingParticle1.SetTypeInfo(timeToLive1);
    fadingParticle1.ColorTint = color3;
    fadingParticle1.Rotation = Main.rand.NextFloat() * 6.28318548f;
    fadingParticle1.RotationVelocity = (float) (6.2831854820251465 * (1.0 / (double) timeToLive1) * 1.0) * Main.rand.NextFloatDirection();
    fadingParticle1.RotationAcceleration = (float) (-(double) fadingParticle1.RotationVelocity * (1.0 / (double) timeToLive1));
    fadingParticle1.FadeInNormalizedTime = 0.01f;
    fadingParticle1.FadeOutNormalizedTime = 0.1f;
    fadingParticle1.Scale = Vector2.One * 0.6f;
    fadingParticle1.ScaleVelocity = Vector2.One * (1.2f / timeToLive1);
    fadingParticle1.ScaleAcceleration = fadingParticle1.ScaleVelocity * (-1f / timeToLive1);
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle1);
    FadingParticle fadingParticle2 = ParticleOrchestrator._poolFading.RequestParticle();
    fadingParticle2.SetBasicInfo(textureAsset, new Rectangle?(rectangle2), Vector2.Zero, settings.PositionInWorld);
    fadingParticle2.SetTypeInfo(timeToLive1 * 0.8f);
    fadingParticle2.ColorTint = color3 * 0.25f;
    fadingParticle2.FadeInNormalizedTime = 0.1f;
    fadingParticle2.FadeOutNormalizedTime = 0.1f;
    fadingParticle2.Scale = Vector2.One * 0.3f;
    fadingParticle2.ScaleVelocity = Vector2.One * 6.5f * (1f / timeToLive1);
    fadingParticle2.ScaleAcceleration = fadingParticle2.ScaleVelocity * (-1f / timeToLive1);
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle2);
    FadingParticle fadingParticle3 = ParticleOrchestrator._poolFading.RequestParticle();
    fadingParticle3.SetBasicInfo(textureAsset, new Rectangle?(rectangle2), Vector2.Zero, settings.PositionInWorld);
    fadingParticle3.SetTypeInfo(timeToLive1);
    fadingParticle3.ColorTint = color3 * 0.3f;
    fadingParticle3.FadeInNormalizedTime = 0.4f;
    fadingParticle3.FadeOutNormalizedTime = 0.5f;
    fadingParticle3.Scale = fadingParticle1.Scale;
    fadingParticle3.ScaleVelocity = fadingParticle1.ScaleVelocity;
    fadingParticle3.ScaleAcceleration = fadingParticle1.ScaleAcceleration;
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle3);
    FadingParticle fadingParticle4 = ParticleOrchestrator._poolFading.RequestParticle();
    fadingParticle4.SetBasicInfo(textureAsset, new Rectangle?(rectangle3), Vector2.Zero, settings.PositionInWorld);
    fadingParticle4.SetTypeInfo(timeToLive1);
    fadingParticle4.ColorTint = color3;
    fadingParticle4.FadeInNormalizedTime = 0.01f;
    fadingParticle4.FadeOutNormalizedTime = 0.7f;
    fadingParticle4.Scale = fadingParticle1.Scale * 0.9f;
    fadingParticle4.ScaleVelocity = fadingParticle1.ScaleVelocity * 1.5f;
    fadingParticle4.ScaleAcceleration = fadingParticle1.ScaleAcceleration * 1.5f;
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle4);
    for (float num = 0.0f; (double) num < 1.0; num += 0.166666672f)
    {
      float timeToLive2 = 15f;
      float f = 6.28318548f * num;
      FadingParticle fadingParticle5 = ParticleOrchestrator._poolFading.RequestParticle();
      fadingParticle5.SetBasicInfo(TextureAssets.Extra[89], new Rectangle?(), f.ToRotationVector2() * (float) (4.0 + 7.0 * (double) Main.rand.NextFloat()), settings.PositionInWorld + f.ToRotationVector2() * (float) (10.0 + 90.0 * (double) Main.rand.NextFloat()));
      fadingParticle5.SetTypeInfo(timeToLive2);
      fadingParticle5.AccelerationPerFrame = fadingParticle5.Velocity * (-1f / timeToLive2);
      FadingParticle fadingParticle6 = fadingParticle5;
      fadingParticle6.LocalPosition = fadingParticle6.LocalPosition - fadingParticle5.Velocity * 4f;
      fadingParticle5.ColorTint = color2;
      fadingParticle5.Rotation = f + 1.57079637f;
      fadingParticle5.FadeInNormalizedTime = 0.2f;
      fadingParticle5.FadeOutNormalizedTime = 0.3f;
      fadingParticle5.Scale = new Vector2(0.4f, 0.8f) * (float) (0.60000002384185791 + 0.60000002384185791 * (double) Main.rand.NextFloat());
      Main.ParticleSystem_World_BehindPlayers.Add((IParticle) fadingParticle5);
    }
  }

  private static void Spawn_DeadCellsMushroomBoiTargetFound(ParticleOrchestraSettings settings)
  {
    ShockIconParticle shockIconParticle = ParticleOrchestrator._poolShockIcon.RequestParticle();
    shockIconParticle.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, 10, 150);
    shockIconParticle.LocalPosition = settings.PositionInWorld;
    shockIconParticle.TimeToLive = 15f;
    shockIconParticle.FadeInNormalizedTime = 0.2f;
    shockIconParticle.FadeOutNormalizedTime = 0.7f;
    shockIconParticle.Velocity = Vector2.Zero;
    shockIconParticle.InitialScale = 1f;
    shockIconParticle.ParentProjectileID = settings.UniqueInfoPiece;
    shockIconParticle.OffsetFromParent = new Vector2(0.0f, -40f);
    Main.ParticleSystem_World_BehindPlayers.Add((IParticle) shockIconParticle);
  }

  private static void Spawn_DeadCellsBarnacleShotFiring(ParticleOrchestraSettings settings)
  {
    Vector2 positionInWorld = settings.PositionInWorld;
    Vector2 movementVector = settings.MovementVector;
    SoundEngine.PlaySound(SoundID.Item95, positionInWorld);
    for (int index = 0; index < 15; ++index)
    {
      Vector2 Position = positionInWorld + new Vector2((float) Main.rand.Next(-4, 4), (float) Main.rand.Next(-4, 4));
      Vector2 vector2 = movementVector.SafeNormalize(Vector2.Zero).RotatedByRandom(0.19634954631328583) * (index >= 8 ? (float) (3.0 + (double) Main.rand.NextFloat() * 2.0) : (float) (7.0 + (double) Main.rand.NextFloat() * 2.0));
      Vector2? Velocity = new Vector2?(vector2);
      Color newColor = new Color();
      Dust dust = Dust.NewDustPerfect(Position, 2, Velocity, newColor: newColor);
      dust.alpha = 50;
      dust.scale = (float) (1.2000000476837158 + (double) Main.rand.Next(-5, 5) * 0.0099999997764825821);
      dust.fadeIn = 0.5f;
      dust.noGravity = true;
      dust.velocity = vector2;
    }
    for (int index = 0; index < 5; ++index)
    {
      Vector2 Position = positionInWorld + new Vector2((float) Main.rand.Next(-4, 4), (float) Main.rand.Next(-4, 4));
      Vector2 vector2 = movementVector.SafeNormalize(Vector2.Zero).RotatedByRandom(0.098174773156642914) * (float) (0.0 + (double) Main.rand.NextFloat() * 8.0);
      Vector2? Velocity = new Vector2?(vector2);
      Color newColor = new Color();
      Dust dust = Dust.NewDustPerfect(Position, 267, Velocity, newColor: newColor);
      dust.alpha = (int) sbyte.MaxValue;
      dust.color = Color.Lerp(Color.DarkOliveGreen, Color.White, Main.rand.NextFloat() * 0.25f);
      dust.fadeIn = (float) (0.60000002384185791 + (double) Main.rand.NextFloat() * 0.60000002384185791);
      dust.scale = 0.5f;
      dust.noGravity = true;
      dust.velocity = vector2;
    }
  }

  private static void ElderSlimeEffect(ParticleOrchestraSettings settings)
  {
    for (int index = 0; index < 30; ++index)
    {
      Dust dust = Dust.NewDustPerfect(settings.PositionInWorld + Main.rand.NextVector2Circular(20f, 20f), 43, new Vector2?((settings.MovementVector * 0.75f + Main.rand.NextVector2Circular(6f, 6f)) * Main.rand.NextFloat()), 26, Color.Lerp(Main.OurFavoriteColor, Color.White, Main.rand.NextFloat()), (float) (1.0 + (double) Main.rand.NextFloat() * 1.3999999761581421));
      dust.fadeIn = 1.5f;
      if ((double) dust.velocity.Y > 0.0 && Main.rand.Next(2) == 0)
        dust.velocity.Y *= -1f;
      dust.noGravity = true;
    }
    for (int index = 0; index < 8; ++index)
      Gore.NewGoreDirect(settings.PositionInWorld + Utils.RandomVector2(Main.rand, -30f, 30f) * new Vector2(0.5f, 1f), Vector2.Zero, 61 + Main.rand.Next(3)).velocity *= 0.5f;
  }

  private static void NerdySlimeEffect(ParticleOrchestraSettings settings)
  {
    Color newColor = new Color(0, 80 /*0x50*/, (int) byte.MaxValue, 100);
    for (int index = 0; index < 60; ++index)
      Dust.NewDustPerfect(settings.PositionInWorld, 4, new Vector2?((settings.MovementVector * 0.75f + Main.rand.NextVector2Circular(6f, 6f)) * Main.rand.NextFloat()), 175, newColor, (float) (0.60000002384185791 + (double) Main.rand.NextFloat() * 1.3999999761581421));
  }

  private static void CopperSlimeEffect(ParticleOrchestraSettings settings)
  {
    for (int index = 0; index < 40; ++index)
    {
      Dust dust = Dust.NewDustPerfect(settings.PositionInWorld + Main.rand.NextVector2Circular(20f, 20f), 43, new Vector2?((settings.MovementVector * 0.75f + Main.rand.NextVector2Circular(6f, 6f)) * Main.rand.NextFloat()), 26, Color.Lerp(new Color(183, 88, 25), Color.White, Main.rand.NextFloat() * 0.5f), (float) (1.0 + (double) Main.rand.NextFloat() * 1.3999999761581421));
      dust.fadeIn = 1.5f;
      if ((double) dust.velocity.Y > 0.0 && Main.rand.Next(2) == 0)
        dust.velocity.Y *= -1f;
      dust.noGravity = true;
    }
  }

  private static void Spawn_ShimmerArrow(ParticleOrchestraSettings settings)
  {
    float num1 = 20f;
    for (int index1 = 0; index1 < 2; ++index1)
    {
      float num2 = (float) (6.2831854820251465 * (double) Main.rand.NextFloatDirection() * 0.05000000074505806);
      Color rgb = Main.hslToRgb(Main.rand.NextFloat(), 1f, 0.5f);
      rgb.A /= (byte) 2;
      Color color = Color.Lerp(rgb with
      {
        A = byte.MaxValue
      }, Color.White, 0.5f);
      for (float num3 = 0.0f; (double) num3 < 4.0; ++num3)
      {
        PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
        Vector2 v = (1.57079637f * num3 + num2).ToRotationVector2() * 4f;
        prettySparkleParticle1.ColorTint = rgb;
        prettySparkleParticle1.LocalPosition = settings.PositionInWorld;
        prettySparkleParticle1.Rotation = v.ToRotation();
        prettySparkleParticle1.Scale = new Vector2((double) num3 % 2.0 == 0.0 ? 2f : 4f, 0.5f) * 1.1f;
        prettySparkleParticle1.FadeInNormalizedTime = 5E-06f;
        prettySparkleParticle1.FadeOutNormalizedTime = 0.95f;
        prettySparkleParticle1.TimeToLive = num1;
        prettySparkleParticle1.FadeOutEnd = num1;
        prettySparkleParticle1.FadeInEnd = num1 / 2f;
        prettySparkleParticle1.FadeOutStart = num1 / 2f;
        prettySparkleParticle1.AdditiveAmount = 0.35f;
        prettySparkleParticle1.Velocity = -v * 0.2f;
        prettySparkleParticle1.DrawVerticalAxis = false;
        if ((double) num3 % 2.0 == 1.0)
        {
          PrettySparkleParticle prettySparkleParticle2 = prettySparkleParticle1;
          prettySparkleParticle2.Scale = prettySparkleParticle2.Scale * 0.9f;
          PrettySparkleParticle prettySparkleParticle3 = prettySparkleParticle1;
          prettySparkleParticle3.Velocity = prettySparkleParticle3.Velocity * 0.9f;
        }
        Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
      }
      for (float num4 = 0.0f; (double) num4 < 4.0; ++num4)
      {
        PrettySparkleParticle prettySparkleParticle4 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
        Vector2 vector2 = (1.57079637f * num4 + num2).ToRotationVector2() * 4f;
        prettySparkleParticle4.ColorTint = color;
        prettySparkleParticle4.LocalPosition = settings.PositionInWorld;
        prettySparkleParticle4.Rotation = vector2.ToRotation();
        prettySparkleParticle4.Scale = new Vector2((double) num4 % 2.0 == 0.0 ? 2f : 4f, 0.5f) * 0.7f;
        prettySparkleParticle4.FadeInNormalizedTime = 5E-06f;
        prettySparkleParticle4.FadeOutNormalizedTime = 0.95f;
        prettySparkleParticle4.TimeToLive = num1;
        prettySparkleParticle4.FadeOutEnd = num1;
        prettySparkleParticle4.FadeInEnd = num1 / 2f;
        prettySparkleParticle4.FadeOutStart = num1 / 2f;
        prettySparkleParticle4.Velocity = vector2 * 0.2f;
        prettySparkleParticle4.DrawVerticalAxis = false;
        if ((double) num4 % 2.0 == 1.0)
        {
          PrettySparkleParticle prettySparkleParticle5 = prettySparkleParticle4;
          prettySparkleParticle5.Scale = prettySparkleParticle5.Scale * 1.2f;
          PrettySparkleParticle prettySparkleParticle6 = prettySparkleParticle4;
          prettySparkleParticle6.Velocity = prettySparkleParticle6.Velocity * 1.2f;
        }
        Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle4);
        if (index1 == 0)
        {
          for (int index2 = 0; index2 < 1; ++index2)
          {
            Dust dust1 = Dust.NewDustPerfect(settings.PositionInWorld, 306, new Vector2?(vector2.RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.02500000037252903) * Main.rand.NextFloat()));
            dust1.noGravity = true;
            dust1.scale = 1.4f;
            dust1.fadeIn = 1.2f;
            dust1.color = rgb;
            Dust dust2 = Dust.NewDustPerfect(settings.PositionInWorld, 306, new Vector2?(-vector2.RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.02500000037252903) * Main.rand.NextFloat()));
            dust2.noGravity = true;
            dust2.scale = 1.4f;
            dust2.fadeIn = 1.2f;
            dust2.color = rgb;
          }
        }
      }
    }
  }

  private static void Spawn_ItemTransfer(ParticleOrchestraSettings settings)
  {
    Vector2 positionInWorld = settings.PositionInWorld;
    Vector2 endPosition = settings.PositionInWorld + settings.MovementVector;
    int key = settings.UniqueInfoPiece & 16777215 /*0xFFFFFF*/;
    BitsByte bitsByte = (BitsByte) (byte) (settings.UniqueInfoPiece >> 24);
    bool flag1 = bitsByte[0];
    bool flag2 = bitsByte[1];
    bool transitionIn = bitsByte[2];
    bool fullbright = bitsByte[3];
    Item obj;
    if (!ContentSamples.ItemsByType.TryGetValue(key, out obj) || obj.IsAir)
      return;
    int type = obj.type;
    int lifeTimeTotal = Main.rand.Next(60, 80 /*0x50*/);
    Chest.AskForChestToEatItem(endPosition + new Vector2(-8f, -8f), lifeTimeTotal + 10);
    Vector2 vector2 = Main.rand.NextVector2Square(-1f, 1f);
    ItemTransferParticle transferParticle = ParticleOrchestrator._poolItemTransfer.RequestParticle();
    transferParticle.Prepare(type, lifeTimeTotal, positionInWorld, endPosition, flag1 ? vector2 * 24f : Vector2.Zero, flag2 ? vector2 * 8f : Vector2.Zero, transitionIn, fullbright, false);
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) transferParticle);
  }

  private static void Spawn_PetExchange(ParticleOrchestraSettings settings)
  {
    Vector2 positionInWorld = settings.PositionInWorld;
    for (int index = 0; index < 13; ++index)
    {
      Gore gore = Gore.NewGoreDirect(positionInWorld + new Vector2(-20f, -20f) + Main.rand.NextVector2Circular(20f, 20f), Vector2.Zero, Main.rand.Next(61, 64 /*0x40*/), (float) (1.0 + (double) Main.rand.NextFloat() * 0.30000001192092896));
      gore.alpha = 100;
      gore.velocity = (6.28318548f * (float) Main.rand.Next()).ToRotationVector2() * Main.rand.NextFloat() + settings.MovementVector * 0.5f;
    }
  }

  private static void Spawn_TerraBlade(ParticleOrchestraSettings settings)
  {
    float num1 = 30f;
    float f = settings.MovementVector.ToRotation() + 1.57079637f;
    float x = 3f;
    for (float num2 = 0.0f; (double) num2 < 4.0; ++num2)
    {
      PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 v = (1.57079637f * num2 + f).ToRotationVector2() * 4f;
      prettySparkleParticle1.ColorTint = new Color(0.2f, 0.85f, 0.4f, 0.5f);
      prettySparkleParticle1.LocalPosition = settings.PositionInWorld;
      prettySparkleParticle1.Rotation = v.ToRotation();
      prettySparkleParticle1.Scale = new Vector2(x, 0.5f) * 1.1f;
      prettySparkleParticle1.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle1.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle1.TimeToLive = num1;
      prettySparkleParticle1.FadeOutEnd = num1;
      prettySparkleParticle1.FadeInEnd = num1 / 2f;
      prettySparkleParticle1.FadeOutStart = num1 / 2f;
      prettySparkleParticle1.AdditiveAmount = 0.35f;
      prettySparkleParticle1.Velocity = -v * 0.2f;
      prettySparkleParticle1.DrawVerticalAxis = false;
      if ((double) num2 % 2.0 == 1.0)
      {
        PrettySparkleParticle prettySparkleParticle2 = prettySparkleParticle1;
        prettySparkleParticle2.Scale = prettySparkleParticle2.Scale * 1.5f;
        PrettySparkleParticle prettySparkleParticle3 = prettySparkleParticle1;
        prettySparkleParticle3.Velocity = prettySparkleParticle3.Velocity * 2f;
      }
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
    }
    for (float num3 = -1f; (double) num3 <= 1.0; num3 += 2f)
    {
      PrettySparkleParticle prettySparkleParticle = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 vector2_1 = f.ToRotationVector2() * 4f;
      Vector2 vector2_2 = (1.57079637f * num3 + f).ToRotationVector2() * 2f;
      prettySparkleParticle.ColorTint = new Color(0.4f, 1f, 0.4f, 0.5f);
      prettySparkleParticle.LocalPosition = settings.PositionInWorld;
      prettySparkleParticle.Rotation = vector2_2.ToRotation();
      prettySparkleParticle.Scale = new Vector2(x, 0.5f) * 1.1f;
      prettySparkleParticle.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle.TimeToLive = num1;
      prettySparkleParticle.FadeOutEnd = num1;
      prettySparkleParticle.FadeInEnd = num1 / 2f;
      prettySparkleParticle.FadeOutStart = num1 / 2f;
      prettySparkleParticle.AdditiveAmount = 0.35f;
      prettySparkleParticle.Velocity = vector2_2.RotatedBy(1.5707963705062866) * 0.5f;
      prettySparkleParticle.DrawVerticalAxis = false;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle);
    }
    for (float num4 = 0.0f; (double) num4 < 4.0; ++num4)
    {
      PrettySparkleParticle prettySparkleParticle4 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 vector2 = (1.57079637f * num4 + f).ToRotationVector2() * 4f;
      prettySparkleParticle4.ColorTint = new Color(0.2f, 1f, 0.2f, 1f);
      prettySparkleParticle4.LocalPosition = settings.PositionInWorld;
      prettySparkleParticle4.Rotation = vector2.ToRotation();
      prettySparkleParticle4.Scale = new Vector2(x, 0.5f) * 0.7f;
      prettySparkleParticle4.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle4.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle4.TimeToLive = num1;
      prettySparkleParticle4.FadeOutEnd = num1;
      prettySparkleParticle4.FadeInEnd = num1 / 2f;
      prettySparkleParticle4.FadeOutStart = num1 / 2f;
      prettySparkleParticle4.Velocity = vector2 * 0.2f;
      prettySparkleParticle4.DrawVerticalAxis = false;
      if ((double) num4 % 2.0 == 1.0)
      {
        PrettySparkleParticle prettySparkleParticle5 = prettySparkleParticle4;
        prettySparkleParticle5.Scale = prettySparkleParticle5.Scale * 1.5f;
        PrettySparkleParticle prettySparkleParticle6 = prettySparkleParticle4;
        prettySparkleParticle6.Velocity = prettySparkleParticle6.Velocity * 2f;
      }
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle4);
      for (int index = 0; index < 1; ++index)
      {
        Dust dust1 = Dust.NewDustPerfect(settings.PositionInWorld, 107, new Vector2?(vector2.RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.02500000037252903) * Main.rand.NextFloat()));
        dust1.noGravity = true;
        dust1.scale = 0.8f;
        Dust dust2 = Dust.NewDustPerfect(settings.PositionInWorld, 107, new Vector2?(-vector2.RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.02500000037252903) * Main.rand.NextFloat()));
        dust2.noGravity = true;
        dust2.scale = 1.4f;
      }
    }
  }

  private static void Spawn_Excalibur(ParticleOrchestraSettings settings)
  {
    float num1 = 30f;
    float num2 = 0.0f;
    for (float num3 = 0.0f; (double) num3 < 4.0; ++num3)
    {
      PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 v = (1.57079637f * num3 + num2).ToRotationVector2() * 4f;
      prettySparkleParticle1.ColorTint = new Color(0.9f, 0.85f, 0.4f, 0.5f);
      prettySparkleParticle1.LocalPosition = settings.PositionInWorld;
      prettySparkleParticle1.Rotation = v.ToRotation();
      prettySparkleParticle1.Scale = new Vector2((double) num3 % 2.0 == 0.0 ? 2f : 4f, 0.5f) * 1.1f;
      prettySparkleParticle1.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle1.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle1.TimeToLive = num1;
      prettySparkleParticle1.FadeOutEnd = num1;
      prettySparkleParticle1.FadeInEnd = num1 / 2f;
      prettySparkleParticle1.FadeOutStart = num1 / 2f;
      prettySparkleParticle1.AdditiveAmount = 0.35f;
      prettySparkleParticle1.Velocity = -v * 0.2f;
      prettySparkleParticle1.DrawVerticalAxis = false;
      if ((double) num3 % 2.0 == 1.0)
      {
        PrettySparkleParticle prettySparkleParticle2 = prettySparkleParticle1;
        prettySparkleParticle2.Scale = prettySparkleParticle2.Scale * 1.5f;
        PrettySparkleParticle prettySparkleParticle3 = prettySparkleParticle1;
        prettySparkleParticle3.Velocity = prettySparkleParticle3.Velocity * 1.5f;
      }
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
    }
    for (float num4 = 0.0f; (double) num4 < 4.0; ++num4)
    {
      PrettySparkleParticle prettySparkleParticle4 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 vector2 = (1.57079637f * num4 + num2).ToRotationVector2() * 4f;
      prettySparkleParticle4.ColorTint = new Color(1f, 1f, 0.2f, 1f);
      prettySparkleParticle4.LocalPosition = settings.PositionInWorld;
      prettySparkleParticle4.Rotation = vector2.ToRotation();
      prettySparkleParticle4.Scale = new Vector2((double) num4 % 2.0 == 0.0 ? 2f : 4f, 0.5f) * 0.7f;
      prettySparkleParticle4.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle4.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle4.TimeToLive = num1;
      prettySparkleParticle4.FadeOutEnd = num1;
      prettySparkleParticle4.FadeInEnd = num1 / 2f;
      prettySparkleParticle4.FadeOutStart = num1 / 2f;
      prettySparkleParticle4.Velocity = vector2 * 0.2f;
      prettySparkleParticle4.DrawVerticalAxis = false;
      if ((double) num4 % 2.0 == 1.0)
      {
        PrettySparkleParticle prettySparkleParticle5 = prettySparkleParticle4;
        prettySparkleParticle5.Scale = prettySparkleParticle5.Scale * 1.5f;
        PrettySparkleParticle prettySparkleParticle6 = prettySparkleParticle4;
        prettySparkleParticle6.Velocity = prettySparkleParticle6.Velocity * 1.5f;
      }
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle4);
      for (int index = 0; index < 1; ++index)
      {
        Dust dust1 = Dust.NewDustPerfect(settings.PositionInWorld, 169, new Vector2?(vector2.RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.02500000037252903) * Main.rand.NextFloat()));
        dust1.noGravity = true;
        dust1.scale = 1.4f;
        Dust dust2 = Dust.NewDustPerfect(settings.PositionInWorld, 169, new Vector2?(-vector2.RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.02500000037252903) * Main.rand.NextFloat()));
        dust2.noGravity = true;
        dust2.scale = 1.4f;
      }
    }
  }

  private static void Spawn_SlapHand(ParticleOrchestraSettings settings)
  {
    SoundEngine.PlaySound(SoundID.Item175, settings.PositionInWorld);
  }

  private static void Spawn_WaffleIron(ParticleOrchestraSettings settings)
  {
    SoundEngine.PlaySound(SoundID.Item178, settings.PositionInWorld);
  }

  private static void Spawn_PlayerVoiceOverrideSound(ParticleOrchestraSettings settings)
  {
    byte playerWhoInvokedThis = settings.IndexOfPlayerWhoInvokedThis;
    if (playerWhoInvokedThis < (byte) 0 || playerWhoInvokedThis >= byte.MaxValue)
      return;
    Player player = Main.player[(int) settings.IndexOfPlayerWhoInvokedThis];
    if (!player.active || player.dead)
      return;
    sbyte uniqueInfoPiece = (sbyte) settings.UniqueInfoPiece;
    sbyte voiceOverride = player.voiceOverride;
    player.voiceOverride = uniqueInfoPiece;
    player.PlayHurtSound();
    player.voiceOverride = voiceOverride;
  }

  private static void Spawn_ClassyCane(ParticleOrchestraSettings settings)
  {
    int num1 = 7;
    float Scale = 1.1f;
    int Type = 10;
    Color newColor = new Color();
    Vector2 positionInWorld = settings.PositionInWorld;
    int num2 = 20;
    int num3 = 20;
    positionInWorld.X -= (float) (num2 / 2);
    positionInWorld.Y -= (float) (num3 / 2);
    int num4 = Main.rand.Next(0, 2);
    for (int index1 = 0; index1 < num4; ++index1)
    {
      int index2 = Gore.NewGore(new Vector2(positionInWorld.X + (float) Main.rand.Next(num2), positionInWorld.Y + (float) Main.rand.Next(num3)), Vector2.Zero, 1218);
      Main.gore[index2].velocity = new Vector2((float) Main.rand.Next(-10, 11) * 0.4f, (float) -(3.0 + (double) Main.rand.Next(6) * 0.30000001192092896));
    }
    for (int index3 = 0; index3 < num1; ++index3)
    {
      int index4 = Dust.NewDust(positionInWorld, num2, num3, Type, SpeedY: -1f, Alpha: 80 /*0x50*/, newColor: newColor, Scale: Scale);
      if (Main.rand.Next(3) != 0)
        Main.dust[index4].noGravity = true;
    }
  }

  private static void Spawn_FlyMeal(ParticleOrchestraSettings settings)
  {
    SoundEngine.PlaySound(SoundID.Item16, settings.PositionInWorld);
  }

  private static void Spawn_VampireOnFire(ParticleOrchestraSettings settings)
  {
    SoundEngine.PlaySound(SoundID.Item20, settings.PositionInWorld);
  }

  private static void Spawn_GasTrap(ParticleOrchestraSettings settings)
  {
    SoundEngine.PlaySound(SoundID.Item16, settings.PositionInWorld);
    Vector2 movementVector = settings.MovementVector;
    int num1 = 12;
    int num2 = 10;
    float num3 = 5f;
    float num4 = 2.5f;
    Color color = new Color(0.2f, 0.4f, 0.15f);
    Vector2 positionInWorld = settings.PositionInWorld;
    float maxRadians1 = 0.157079637f;
    float maxRadians2 = 0.209439516f;
    for (int index = 0; index < num1; ++index)
    {
      Vector2 vector2 = (movementVector + new Vector2(num3 + Main.rand.NextFloat() * 1f, 0.0f).RotatedBy((double) index / (double) num1 * 6.2831854820251465, Vector2.Zero)).RotatedByRandom((double) maxRadians1);
      GasParticle gasParticle = ParticleOrchestrator._poolGas.RequestParticle();
      gasParticle.AccelerationPerFrame = Vector2.Zero;
      gasParticle.Velocity = vector2;
      gasParticle.ColorTint = Color.White;
      gasParticle.LightColorTint = color;
      gasParticle.LocalPosition = positionInWorld + vector2;
      gasParticle.TimeToLive = (float) (50 + Main.rand.Next(20));
      gasParticle.InitialScale = (float) (1.0 + (double) Main.rand.NextFloat() * 0.34999999403953552);
      Main.ParticleSystem_World_BehindPlayers.Add((IParticle) gasParticle);
    }
    for (int index = 0; index < num2; ++index)
    {
      Vector2 vector2 = new Vector2(num4 + Main.rand.NextFloat() * 1.45f, 0.0f).RotatedBy((double) index / (double) num2 * 6.2831854820251465, Vector2.Zero).RotatedByRandom((double) maxRadians2);
      if (index % 2 == 0)
        vector2 *= 0.5f;
      GasParticle gasParticle = ParticleOrchestrator._poolGas.RequestParticle();
      gasParticle.AccelerationPerFrame = Vector2.Zero;
      gasParticle.Velocity = vector2;
      gasParticle.ColorTint = Color.White;
      gasParticle.LightColorTint = color;
      gasParticle.LocalPosition = positionInWorld;
      gasParticle.TimeToLive = (float) (80 /*0x50*/ + Main.rand.Next(30));
      gasParticle.InitialScale = (float) (1.0 + (double) Main.rand.NextFloat() * 0.5);
      Main.ParticleSystem_World_BehindPlayers.Add((IParticle) gasParticle);
    }
  }

  private static void Spawn_TrueExcalibur(ParticleOrchestraSettings settings)
  {
    float num1 = 36f;
    float num2 = 0.7853982f;
    for (float num3 = 0.0f; (double) num3 < 2.0; ++num3)
    {
      PrettySparkleParticle prettySparkleParticle = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 v = (1.57079637f * num3 + num2).ToRotationVector2() * 4f;
      prettySparkleParticle.ColorTint = new Color(1f, 0.0f, 0.3f, 1f);
      prettySparkleParticle.LocalPosition = settings.PositionInWorld;
      prettySparkleParticle.Rotation = v.ToRotation();
      prettySparkleParticle.Scale = new Vector2(5f, 0.5f) * 1.1f;
      prettySparkleParticle.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle.TimeToLive = num1;
      prettySparkleParticle.FadeOutEnd = num1;
      prettySparkleParticle.FadeInEnd = num1 / 2f;
      prettySparkleParticle.FadeOutStart = num1 / 2f;
      prettySparkleParticle.AdditiveAmount = 0.35f;
      prettySparkleParticle.DrawVerticalAxis = false;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle);
    }
    for (float num4 = 0.0f; (double) num4 < 2.0; ++num4)
    {
      PrettySparkleParticle prettySparkleParticle = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 vector2 = (1.57079637f * num4 + num2).ToRotationVector2() * 4f;
      prettySparkleParticle.ColorTint = new Color(1f, 0.5f, 0.8f, 1f);
      prettySparkleParticle.LocalPosition = settings.PositionInWorld;
      prettySparkleParticle.Rotation = vector2.ToRotation();
      prettySparkleParticle.Scale = new Vector2(3f, 0.5f) * 0.7f;
      prettySparkleParticle.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle.TimeToLive = num1;
      prettySparkleParticle.FadeOutEnd = num1;
      prettySparkleParticle.FadeInEnd = num1 / 2f;
      prettySparkleParticle.FadeOutStart = num1 / 2f;
      prettySparkleParticle.DrawVerticalAxis = false;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle);
      for (int index = 0; index < 1; ++index)
      {
        if (Main.rand.Next(2) != 0)
        {
          Dust dust1 = Dust.NewDustPerfect(settings.PositionInWorld, 242, new Vector2?(vector2.RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.02500000037252903) * Main.rand.NextFloat()));
          dust1.noGravity = true;
          dust1.scale = 1.4f;
          Dust dust2 = Dust.NewDustPerfect(settings.PositionInWorld, 242, new Vector2?(-vector2.RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.02500000037252903) * Main.rand.NextFloat()));
          dust2.noGravity = true;
          dust2.scale = 1.4f;
        }
      }
    }
    float num5 = 30f;
    float num6 = 0.0f;
    for (float num7 = 0.0f; (double) num7 < 4.0; ++num7)
    {
      PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 v = (1.57079637f * num7 + num6).ToRotationVector2() * 4f;
      prettySparkleParticle1.ColorTint = new Color(0.9f, 0.85f, 0.4f, 0.5f);
      prettySparkleParticle1.LocalPosition = settings.PositionInWorld;
      prettySparkleParticle1.Rotation = v.ToRotation();
      prettySparkleParticle1.Scale = new Vector2((double) num7 % 2.0 == 0.0 ? 2f : 4f, 0.5f) * 1.1f;
      prettySparkleParticle1.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle1.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle1.TimeToLive = num5;
      prettySparkleParticle1.FadeOutEnd = num5;
      prettySparkleParticle1.FadeInEnd = num5 / 2f;
      prettySparkleParticle1.FadeOutStart = num5 / 2f;
      prettySparkleParticle1.AdditiveAmount = 0.35f;
      prettySparkleParticle1.Velocity = -v * 0.2f;
      prettySparkleParticle1.DrawVerticalAxis = false;
      if ((double) num7 % 2.0 == 1.0)
      {
        PrettySparkleParticle prettySparkleParticle2 = prettySparkleParticle1;
        prettySparkleParticle2.Scale = prettySparkleParticle2.Scale * 1.5f;
        PrettySparkleParticle prettySparkleParticle3 = prettySparkleParticle1;
        prettySparkleParticle3.Velocity = prettySparkleParticle3.Velocity * 1.5f;
      }
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
    }
    for (float num8 = 0.0f; (double) num8 < 4.0; ++num8)
    {
      PrettySparkleParticle prettySparkleParticle4 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 vector2 = (1.57079637f * num8 + num6).ToRotationVector2() * 4f;
      prettySparkleParticle4.ColorTint = new Color(1f, 1f, 0.2f, 1f);
      prettySparkleParticle4.LocalPosition = settings.PositionInWorld;
      prettySparkleParticle4.Rotation = vector2.ToRotation();
      prettySparkleParticle4.Scale = new Vector2((double) num8 % 2.0 == 0.0 ? 2f : 4f, 0.5f) * 0.7f;
      prettySparkleParticle4.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle4.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle4.TimeToLive = num5;
      prettySparkleParticle4.FadeOutEnd = num5;
      prettySparkleParticle4.FadeInEnd = num5 / 2f;
      prettySparkleParticle4.FadeOutStart = num5 / 2f;
      prettySparkleParticle4.Velocity = vector2 * 0.2f;
      prettySparkleParticle4.DrawVerticalAxis = false;
      if ((double) num8 % 2.0 == 1.0)
      {
        PrettySparkleParticle prettySparkleParticle5 = prettySparkleParticle4;
        prettySparkleParticle5.Scale = prettySparkleParticle5.Scale * 1.5f;
        PrettySparkleParticle prettySparkleParticle6 = prettySparkleParticle4;
        prettySparkleParticle6.Velocity = prettySparkleParticle6.Velocity * 1.5f;
      }
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle4);
      for (int index = 0; index < 1; ++index)
      {
        if (Main.rand.Next(2) != 0)
        {
          Dust dust3 = Dust.NewDustPerfect(settings.PositionInWorld, 169, new Vector2?(vector2.RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.02500000037252903) * Main.rand.NextFloat()));
          dust3.noGravity = true;
          dust3.scale = 1.4f;
          Dust dust4 = Dust.NewDustPerfect(settings.PositionInWorld, 169, new Vector2?(-vector2.RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.02500000037252903) * Main.rand.NextFloat()));
          dust4.noGravity = true;
          dust4.scale = 1.4f;
        }
      }
    }
  }

  private static void Spawn_BestReforge(ParticleOrchestraSettings settings)
  {
    Vector2 vector2_1 = new Vector2(0.0f, 0.163500011f);
    Asset<Texture2D> textureAsset = Main.Assets.Request<Texture2D>("Images/UI/Creative/Research_Spark", (AssetRequestMode) 1);
    for (int index = 0; index < 8; ++index)
    {
      Vector2 vector2_2 = Main.rand.NextVector2Circular(3f, 4f);
      if ((double) vector2_2.Y > 0.0)
        vector2_2.Y = -vector2_2.Y;
      vector2_2.Y -= 2f;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) new CreativeSacrificeParticle(textureAsset, new Rectangle?(), settings.MovementVector + vector2_2, settings.PositionInWorld)
      {
        AccelerationPerFrame = vector2_1,
        ScaleOffsetPerFrame = -0.0166666675f
      });
    }
  }

  private static void Spawn_LeafCrystalPassive(ParticleOrchestraSettings settings)
  {
    float num1 = 90f;
    float num2 = 6.28318548f * Main.rand.NextFloat();
    float num3 = 3f;
    for (float num4 = 0.0f; (double) num4 < (double) num3; ++num4)
    {
      PrettySparkleParticle prettySparkleParticle = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 v = (6.28318548f / num3 * num4 + num2).ToRotationVector2() * 4f;
      prettySparkleParticle.ColorTint = new Color(0.3f, 0.6f, 0.3f, 0.5f);
      prettySparkleParticle.LocalPosition = settings.PositionInWorld;
      prettySparkleParticle.Rotation = v.ToRotation();
      prettySparkleParticle.Scale = new Vector2(4f, 1f) * 0.4f;
      prettySparkleParticle.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle.TimeToLive = num1;
      prettySparkleParticle.FadeOutEnd = num1;
      prettySparkleParticle.FadeInEnd = 10f;
      prettySparkleParticle.FadeOutStart = 10f;
      prettySparkleParticle.AdditiveAmount = 0.5f;
      prettySparkleParticle.Velocity = Vector2.Zero;
      prettySparkleParticle.DrawVerticalAxis = false;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle);
    }
  }

  private static void Spawn_LeafCrystalShot(ParticleOrchestraSettings settings)
  {
    int num = 30;
    PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
    Vector2 movementVector = settings.MovementVector;
    Color rgb = Main.hslToRgb((float) settings.UniqueInfoPiece / (float) byte.MaxValue, 1f, 0.5f);
    Color color = Color.Lerp(rgb, Color.Gold, (float) ((double) rgb.R / (double) byte.MaxValue * 0.5));
    prettySparkleParticle1.ColorTint = color;
    prettySparkleParticle1.LocalPosition = settings.PositionInWorld;
    prettySparkleParticle1.Rotation = movementVector.ToRotation();
    prettySparkleParticle1.Scale = new Vector2(4f, 1f) * 1f;
    prettySparkleParticle1.FadeInNormalizedTime = 5E-06f;
    prettySparkleParticle1.FadeOutNormalizedTime = 1f;
    prettySparkleParticle1.TimeToLive = (float) num;
    prettySparkleParticle1.FadeOutEnd = (float) num;
    prettySparkleParticle1.FadeInEnd = (float) (num / 2);
    prettySparkleParticle1.FadeOutStart = (float) (num / 2);
    prettySparkleParticle1.AdditiveAmount = 0.5f;
    prettySparkleParticle1.Velocity = settings.MovementVector;
    PrettySparkleParticle prettySparkleParticle2 = prettySparkleParticle1;
    prettySparkleParticle2.LocalPosition = prettySparkleParticle2.LocalPosition - prettySparkleParticle1.Velocity * 4f;
    prettySparkleParticle1.DrawVerticalAxis = false;
    Lighting.AddLight(settings.PositionInWorld, new Vector3(0.05f, 0.2f, 0.1f) * 1.5f);
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
  }

  private static void Spawn_TrueNightsEdge(ParticleOrchestraSettings settings)
  {
    float num1 = 30f;
    float num2 = 0.0f;
    for (float num3 = 0.0f; (double) num3 < 3.0; num3 += 2f)
    {
      PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 v = ((float) (0.78539818525314331 + 0.78539818525314331 * (double) num3) + num2).ToRotationVector2() * 4f;
      prettySparkleParticle1.ColorTint = new Color(0.3f, 0.6f, 0.3f, 0.5f);
      prettySparkleParticle1.LocalPosition = settings.PositionInWorld;
      prettySparkleParticle1.Rotation = v.ToRotation();
      prettySparkleParticle1.Scale = new Vector2(4f, 1f) * 1.1f;
      prettySparkleParticle1.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle1.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle1.TimeToLive = num1;
      prettySparkleParticle1.FadeOutEnd = num1;
      prettySparkleParticle1.FadeInEnd = num1 / 2f;
      prettySparkleParticle1.FadeOutStart = num1 / 2f;
      prettySparkleParticle1.AdditiveAmount = 0.35f;
      PrettySparkleParticle prettySparkleParticle2 = prettySparkleParticle1;
      prettySparkleParticle2.LocalPosition = prettySparkleParticle2.LocalPosition - v * num1 * 0.25f;
      prettySparkleParticle1.Velocity = v;
      prettySparkleParticle1.DrawVerticalAxis = false;
      if ((double) num3 == 1.0)
      {
        PrettySparkleParticle prettySparkleParticle3 = prettySparkleParticle1;
        prettySparkleParticle3.Scale = prettySparkleParticle3.Scale * 1.5f;
        PrettySparkleParticle prettySparkleParticle4 = prettySparkleParticle1;
        prettySparkleParticle4.Velocity = prettySparkleParticle4.Velocity * 1.5f;
        PrettySparkleParticle prettySparkleParticle5 = prettySparkleParticle1;
        prettySparkleParticle5.LocalPosition = prettySparkleParticle5.LocalPosition - prettySparkleParticle1.Velocity * 4f;
      }
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
    }
    for (float num4 = 0.0f; (double) num4 < 3.0; num4 += 2f)
    {
      PrettySparkleParticle prettySparkleParticle6 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 vector2 = ((float) (0.78539818525314331 + 0.78539818525314331 * (double) num4) + num2).ToRotationVector2() * 4f;
      prettySparkleParticle6.ColorTint = new Color(0.6f, 1f, 0.2f, 1f);
      prettySparkleParticle6.LocalPosition = settings.PositionInWorld;
      prettySparkleParticle6.Rotation = vector2.ToRotation();
      prettySparkleParticle6.Scale = new Vector2(4f, 1f) * 0.7f;
      prettySparkleParticle6.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle6.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle6.TimeToLive = num1;
      prettySparkleParticle6.FadeOutEnd = num1;
      prettySparkleParticle6.FadeInEnd = num1 / 2f;
      prettySparkleParticle6.FadeOutStart = num1 / 2f;
      PrettySparkleParticle prettySparkleParticle7 = prettySparkleParticle6;
      prettySparkleParticle7.LocalPosition = prettySparkleParticle7.LocalPosition - vector2 * num1 * 0.25f;
      prettySparkleParticle6.Velocity = vector2;
      prettySparkleParticle6.DrawVerticalAxis = false;
      if ((double) num4 == 1.0)
      {
        PrettySparkleParticle prettySparkleParticle8 = prettySparkleParticle6;
        prettySparkleParticle8.Scale = prettySparkleParticle8.Scale * 1.5f;
        PrettySparkleParticle prettySparkleParticle9 = prettySparkleParticle6;
        prettySparkleParticle9.Velocity = prettySparkleParticle9.Velocity * 1.5f;
        PrettySparkleParticle prettySparkleParticle10 = prettySparkleParticle6;
        prettySparkleParticle10.LocalPosition = prettySparkleParticle10.LocalPosition - prettySparkleParticle6.Velocity * 4f;
      }
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle6);
      for (int index = 0; index < 2; ++index)
      {
        Dust dust1 = Dust.NewDustPerfect(settings.PositionInWorld, 75, new Vector2?(vector2.RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.02500000037252903) * Main.rand.NextFloat()));
        dust1.noGravity = true;
        dust1.scale = 1.4f;
        Dust dust2 = Dust.NewDustPerfect(settings.PositionInWorld, 75, new Vector2?(-vector2.RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.02500000037252903) * Main.rand.NextFloat()));
        dust2.noGravity = true;
        dust2.scale = 1.4f;
      }
    }
  }

  private static void Spawn_NightsEdge(ParticleOrchestraSettings settings)
  {
    float num1 = 30f;
    float num2 = 0.0f;
    for (float num3 = 0.0f; (double) num3 < 3.0; ++num3)
    {
      PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 v = ((float) (0.78539818525314331 + 0.78539818525314331 * (double) num3) + num2).ToRotationVector2() * 4f;
      prettySparkleParticle1.ColorTint = new Color(0.25f, 0.1f, 0.5f, 0.5f);
      prettySparkleParticle1.LocalPosition = settings.PositionInWorld;
      prettySparkleParticle1.Rotation = v.ToRotation();
      prettySparkleParticle1.Scale = new Vector2(2f, 1f) * 1.1f;
      prettySparkleParticle1.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle1.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle1.TimeToLive = num1;
      prettySparkleParticle1.FadeOutEnd = num1;
      prettySparkleParticle1.FadeInEnd = num1 / 2f;
      prettySparkleParticle1.FadeOutStart = num1 / 2f;
      prettySparkleParticle1.AdditiveAmount = 0.35f;
      PrettySparkleParticle prettySparkleParticle2 = prettySparkleParticle1;
      prettySparkleParticle2.LocalPosition = prettySparkleParticle2.LocalPosition - v * num1 * 0.25f;
      prettySparkleParticle1.Velocity = v;
      prettySparkleParticle1.DrawVerticalAxis = false;
      if ((double) num3 == 1.0)
      {
        PrettySparkleParticle prettySparkleParticle3 = prettySparkleParticle1;
        prettySparkleParticle3.Scale = prettySparkleParticle3.Scale * 1.5f;
        PrettySparkleParticle prettySparkleParticle4 = prettySparkleParticle1;
        prettySparkleParticle4.Velocity = prettySparkleParticle4.Velocity * 1.5f;
        PrettySparkleParticle prettySparkleParticle5 = prettySparkleParticle1;
        prettySparkleParticle5.LocalPosition = prettySparkleParticle5.LocalPosition - prettySparkleParticle1.Velocity * 4f;
      }
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
    }
    for (float num4 = 0.0f; (double) num4 < 3.0; ++num4)
    {
      PrettySparkleParticle prettySparkleParticle6 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      Vector2 v = ((float) (0.78539818525314331 + 0.78539818525314331 * (double) num4) + num2).ToRotationVector2() * 4f;
      prettySparkleParticle6.ColorTint = new Color(0.5f, 0.25f, 1f, 1f);
      prettySparkleParticle6.LocalPosition = settings.PositionInWorld;
      prettySparkleParticle6.Rotation = v.ToRotation();
      prettySparkleParticle6.Scale = new Vector2(2f, 1f) * 0.7f;
      prettySparkleParticle6.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle6.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle6.TimeToLive = num1;
      prettySparkleParticle6.FadeOutEnd = num1;
      prettySparkleParticle6.FadeInEnd = num1 / 2f;
      prettySparkleParticle6.FadeOutStart = num1 / 2f;
      PrettySparkleParticle prettySparkleParticle7 = prettySparkleParticle6;
      prettySparkleParticle7.LocalPosition = prettySparkleParticle7.LocalPosition - v * num1 * 0.25f;
      prettySparkleParticle6.Velocity = v;
      prettySparkleParticle6.DrawVerticalAxis = false;
      if ((double) num4 == 1.0)
      {
        PrettySparkleParticle prettySparkleParticle8 = prettySparkleParticle6;
        prettySparkleParticle8.Scale = prettySparkleParticle8.Scale * 1.5f;
        PrettySparkleParticle prettySparkleParticle9 = prettySparkleParticle6;
        prettySparkleParticle9.Velocity = prettySparkleParticle9.Velocity * 1.5f;
        PrettySparkleParticle prettySparkleParticle10 = prettySparkleParticle6;
        prettySparkleParticle10.LocalPosition = prettySparkleParticle10.LocalPosition - prettySparkleParticle6.Velocity * 4f;
      }
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle6);
    }
  }

  private static void Spawn_SilverBulletSparkle(ParticleOrchestraSettings settings)
  {
    double num1 = (double) Main.rand.NextFloat() * 6.2831854820251465;
    Vector2 movementVector = settings.MovementVector;
    Vector2 vector2_1 = new Vector2((float) ((double) Main.rand.NextFloat() * 0.20000000298023224 + 0.40000000596046448));
    double num2 = (double) Main.rand.NextFloat();
    float num3 = 1.57079637f;
    Vector2 vector2_2 = Main.rand.NextVector2Circular(4f, 4f) * vector2_1;
    PrettySparkleParticle prettySparkleParticle = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
    prettySparkleParticle.AccelerationPerFrame = -movementVector * 1f / 30f;
    prettySparkleParticle.Velocity = movementVector;
    prettySparkleParticle.ColorTint = Color.White;
    prettySparkleParticle.LocalPosition = settings.PositionInWorld + vector2_2;
    prettySparkleParticle.Rotation = num3;
    prettySparkleParticle.Scale = vector2_1;
    prettySparkleParticle.FadeInNormalizedTime = 5E-06f;
    prettySparkleParticle.FadeOutNormalizedTime = 0.95f;
    prettySparkleParticle.FadeInEnd = 10f;
    prettySparkleParticle.FadeOutStart = 20f;
    prettySparkleParticle.FadeOutEnd = 30f;
    prettySparkleParticle.TimeToLive = 30f;
    Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle);
  }

  private static void Spawn_PaladinsHammer(ParticleOrchestraSettings settings)
  {
    float num1 = Main.rand.NextFloat() * 6.28318548f;
    float num2 = 1f;
    for (float num3 = 0.0f; (double) num3 < 1.0; num3 += 1f / num2)
    {
      float num4 = (float) (0.60000002384185791 + (double) Main.rand.NextFloat() * 0.34999999403953552);
      Vector2 vector2_1 = settings.MovementVector * num4;
      Vector2 vector2_2 = new Vector2((float) ((double) Main.rand.NextFloat() * 0.40000000596046448 + 0.20000000298023224));
      float f = num1 + Main.rand.NextFloat() * 6.28318548f;
      float num5 = 1.57079637f;
      Vector2 vector2_3 = 0.1f * vector2_2;
      Vector2 vector2_4 = Main.rand.NextVector2Circular(12f, 12f) * vector2_2;
      PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle1.AccelerationPerFrame = -vector2_1 * 1f / 30f;
      prettySparkleParticle1.Velocity = vector2_1 + f.ToRotationVector2() * 2f * num4;
      prettySparkleParticle1.ColorTint = new Color(1f, 0.8f, 0.4f, 0.0f);
      prettySparkleParticle1.LocalPosition = settings.PositionInWorld + vector2_4;
      prettySparkleParticle1.Rotation = num5;
      prettySparkleParticle1.Scale = vector2_2;
      prettySparkleParticle1.FadeInNormalizedTime = 5E-06f;
      prettySparkleParticle1.FadeOutNormalizedTime = 0.95f;
      prettySparkleParticle1.TimeToLive = 40f;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
      PrettySparkleParticle prettySparkleParticle2 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle2.AccelerationPerFrame = -vector2_1 * 1f / 30f;
      prettySparkleParticle2.Velocity = vector2_1 * 0.8f + f.ToRotationVector2() * 2f;
      prettySparkleParticle2.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
      prettySparkleParticle2.LocalPosition = settings.PositionInWorld + vector2_4;
      prettySparkleParticle2.Rotation = num5;
      prettySparkleParticle2.Scale = vector2_2 * 0.6f;
      prettySparkleParticle2.FadeInNormalizedTime = 0.1f;
      prettySparkleParticle2.FadeOutNormalizedTime = 0.9f;
      prettySparkleParticle2.TimeToLive = 60f;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle2);
    }
    for (int index = 0; index < 2; ++index)
    {
      Color newColor = new Color(1f, 0.7f, 0.3f, 0.0f);
      int dustIndex = Dust.NewDust(settings.PositionInWorld, 0, 0, 267, newColor: newColor);
      Main.dust[dustIndex].velocity = Main.rand.NextVector2Circular(2f, 2f);
      Main.dust[dustIndex].velocity += settings.MovementVector * (float) (0.5 + 0.5 * (double) Main.rand.NextFloat()) * 1.4f;
      Main.dust[dustIndex].noGravity = true;
      Main.dust[dustIndex].scale = 0.1f;
      Main.dust[dustIndex].position += Main.rand.NextVector2Circular(16f, 16f);
      Main.dust[dustIndex].velocity = settings.MovementVector;
      if (dustIndex != 6000)
      {
        Dust dust = Dust.CloneDust(dustIndex);
        dust.scale /= 2f;
        dust.fadeIn *= 0.75f;
        dust.color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      }
    }
  }

  private static void Spawn_PrincessWeapon(ParticleOrchestraSettings settings)
  {
    float num1 = Main.rand.NextFloat() * 6.28318548f;
    float num2 = 1f;
    for (float num3 = 0.0f; (double) num3 < 1.0; num3 += 1f / num2)
    {
      Vector2 vector2_1 = settings.MovementVector * (float) (0.60000002384185791 + (double) Main.rand.NextFloat() * 0.34999999403953552);
      Vector2 vector2_2 = new Vector2((float) ((double) Main.rand.NextFloat() * 0.40000000596046448 + 0.20000000298023224));
      float f = num1 + Main.rand.NextFloat() * 6.28318548f;
      float num4 = 1.57079637f;
      Vector2 vector2_3 = 0.1f * vector2_2;
      float num5 = 60f;
      Vector2 vector2_4 = Main.rand.NextVector2Circular(8f, 8f) * vector2_2;
      PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle1.Velocity = f.ToRotationVector2() * vector2_3 + vector2_1;
      prettySparkleParticle1.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_3 / num5) - vector2_1 * 1f / 30f;
      prettySparkleParticle1.AccelerationPerFrame = -vector2_1 * 1f / 60f;
      prettySparkleParticle1.Velocity = vector2_1 * 0.66f;
      prettySparkleParticle1.ColorTint = Main.hslToRgb((float) ((0.92000001668930054 + (double) Main.rand.NextFloat() * 0.019999999552965164) % 1.0), 1f, (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.25));
      prettySparkleParticle1.ColorTint.A = (byte) 0;
      prettySparkleParticle1.LocalPosition = settings.PositionInWorld + vector2_4;
      prettySparkleParticle1.Rotation = num4;
      prettySparkleParticle1.Scale = vector2_2;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
      PrettySparkleParticle prettySparkleParticle2 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle2.Velocity = f.ToRotationVector2() * vector2_3 + vector2_1;
      prettySparkleParticle2.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_3 / num5) - vector2_1 * 1f / 15f;
      prettySparkleParticle2.AccelerationPerFrame = -vector2_1 * 1f / 60f;
      prettySparkleParticle2.Velocity = vector2_1 * 0.66f;
      prettySparkleParticle2.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
      prettySparkleParticle2.LocalPosition = settings.PositionInWorld + vector2_4;
      prettySparkleParticle2.Rotation = num4;
      prettySparkleParticle2.Scale = vector2_2 * 0.6f;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle2);
    }
    for (int index = 0; index < 2; ++index)
    {
      Color rgb = Main.hslToRgb((float) ((0.92000001668930054 + (double) Main.rand.NextFloat() * 0.019999999552965164) % 1.0), 1f, (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.25));
      int dustIndex = Dust.NewDust(settings.PositionInWorld, 0, 0, 267, newColor: rgb);
      Main.dust[dustIndex].velocity = Main.rand.NextVector2Circular(2f, 2f);
      Main.dust[dustIndex].velocity += settings.MovementVector * (float) (0.5 + 0.5 * (double) Main.rand.NextFloat()) * 1.4f;
      Main.dust[dustIndex].noGravity = true;
      Main.dust[dustIndex].scale = 0.1f;
      Main.dust[dustIndex].position += Main.rand.NextVector2Circular(16f, 16f);
      Main.dust[dustIndex].velocity = settings.MovementVector;
      if (dustIndex != 6000)
      {
        Dust dust = Dust.CloneDust(dustIndex);
        dust.scale /= 2f;
        dust.fadeIn *= 0.75f;
        dust.color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      }
    }
  }

  private static void Spawn_StardustPunch(ParticleOrchestraSettings settings)
  {
    float num1 = Main.rand.NextFloat() * 6.28318548f;
    float num2 = 1f;
    for (float num3 = 0.0f; (double) num3 < 1.0; num3 += 1f / num2)
    {
      Vector2 vector2_1 = settings.MovementVector * (float) (0.30000001192092896 + (double) Main.rand.NextFloat() * 0.34999999403953552);
      Vector2 vector2_2 = new Vector2((float) ((double) Main.rand.NextFloat() * 0.40000000596046448 + 0.40000000596046448));
      float f = num1 + Main.rand.NextFloat() * 6.28318548f;
      float num4 = 1.57079637f;
      Vector2 vector2_3 = 0.1f * vector2_2;
      float num5 = 60f;
      Vector2 vector2_4 = Main.rand.NextVector2Circular(8f, 8f) * vector2_2;
      PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle1.Velocity = f.ToRotationVector2() * vector2_3 + vector2_1;
      prettySparkleParticle1.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_3 / num5) - vector2_1 * 1f / 60f;
      prettySparkleParticle1.ColorTint = Main.hslToRgb((float) ((0.60000002384185791 + (double) Main.rand.NextFloat() * 0.05000000074505806) % 1.0), 1f, (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.25));
      prettySparkleParticle1.ColorTint.A = (byte) 0;
      prettySparkleParticle1.LocalPosition = settings.PositionInWorld + vector2_4;
      prettySparkleParticle1.Rotation = num4;
      prettySparkleParticle1.Scale = vector2_2;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
      PrettySparkleParticle prettySparkleParticle2 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle2.Velocity = f.ToRotationVector2() * vector2_3 + vector2_1;
      prettySparkleParticle2.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_3 / num5) - vector2_1 * 1f / 30f;
      prettySparkleParticle2.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
      prettySparkleParticle2.LocalPosition = settings.PositionInWorld + vector2_4;
      prettySparkleParticle2.Rotation = num4;
      prettySparkleParticle2.Scale = vector2_2 * 0.6f;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle2);
    }
    for (int index = 0; index < 2; ++index)
    {
      Color rgb = Main.hslToRgb((float) ((0.5899999737739563 + (double) Main.rand.NextFloat() * 0.05000000074505806) % 1.0), 1f, (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.25));
      int dustIndex = Dust.NewDust(settings.PositionInWorld, 0, 0, 267, newColor: rgb);
      Main.dust[dustIndex].velocity = Main.rand.NextVector2Circular(2f, 2f);
      Main.dust[dustIndex].velocity += settings.MovementVector * (float) (0.5 + 0.5 * (double) Main.rand.NextFloat()) * 1.4f;
      Main.dust[dustIndex].noGravity = true;
      Main.dust[dustIndex].scale = (float) (0.60000002384185791 + (double) Main.rand.NextFloat() * 2.0);
      Main.dust[dustIndex].position += Main.rand.NextVector2Circular(16f, 16f);
      if (dustIndex != 6000)
      {
        Dust dust = Dust.CloneDust(dustIndex);
        dust.scale /= 2f;
        dust.fadeIn *= 0.75f;
        dust.color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      }
    }
  }

  private static void Spawn_RainbowRodHit(ParticleOrchestraSettings settings)
  {
    float num1 = Main.rand.NextFloat() * 6.28318548f;
    float num2 = 6f;
    float num3 = Main.rand.NextFloat();
    for (float num4 = 0.0f; (double) num4 < 1.0; num4 += 1f / num2)
    {
      Vector2 vector2_1 = settings.MovementVector * Main.rand.NextFloatDirection() * 0.15f;
      Vector2 vector2_2 = new Vector2((float) ((double) Main.rand.NextFloat() * 0.40000000596046448 + 0.40000000596046448));
      float f = num1 + Main.rand.NextFloat() * 6.28318548f;
      float num5 = 1.57079637f;
      Vector2 vector2_3 = 1.5f * vector2_2;
      float num6 = 60f;
      Vector2 vector2_4 = Main.rand.NextVector2Circular(8f, 8f) * vector2_2;
      PrettySparkleParticle prettySparkleParticle1 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle1.Velocity = f.ToRotationVector2() * vector2_3 + vector2_1;
      prettySparkleParticle1.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_3 / num6) - vector2_1 * 1f / 60f;
      prettySparkleParticle1.ColorTint = Main.hslToRgb((float) (((double) num3 + (double) Main.rand.NextFloat() * 0.33000001311302185) % 1.0), 1f, (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.25));
      prettySparkleParticle1.ColorTint.A = (byte) 0;
      prettySparkleParticle1.LocalPosition = settings.PositionInWorld + vector2_4;
      prettySparkleParticle1.Rotation = num5;
      prettySparkleParticle1.Scale = vector2_2;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle1);
      PrettySparkleParticle prettySparkleParticle2 = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle2.Velocity = f.ToRotationVector2() * vector2_3 + vector2_1;
      prettySparkleParticle2.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_3 / num6) - vector2_1 * 1f / 60f;
      prettySparkleParticle2.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
      prettySparkleParticle2.LocalPosition = settings.PositionInWorld + vector2_4;
      prettySparkleParticle2.Rotation = num5;
      prettySparkleParticle2.Scale = vector2_2 * 0.6f;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle2);
    }
    for (int index = 0; index < 12; ++index)
    {
      Color rgb = Main.hslToRgb((float) (((double) num3 + (double) Main.rand.NextFloat() * 0.11999999731779099) % 1.0), 1f, (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.25));
      int dustIndex = Dust.NewDust(settings.PositionInWorld, 0, 0, 267, newColor: rgb);
      Main.dust[dustIndex].velocity = Main.rand.NextVector2Circular(1f, 1f);
      Main.dust[dustIndex].velocity += settings.MovementVector * Main.rand.NextFloatDirection() * 0.5f;
      Main.dust[dustIndex].noGravity = true;
      Main.dust[dustIndex].scale = (float) (0.60000002384185791 + (double) Main.rand.NextFloat() * 0.89999997615814209);
      Main.dust[dustIndex].fadeIn = (float) (0.699999988079071 + (double) Main.rand.NextFloat() * 0.800000011920929);
      if (dustIndex != 6000)
      {
        Dust dust = Dust.CloneDust(dustIndex);
        dust.scale /= 2f;
        dust.fadeIn *= 0.75f;
        dust.color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      }
    }
  }

  private static void Spawn_BlackLightningSmall(ParticleOrchestraSettings settings)
  {
    float num1 = Main.rand.NextFloat() * 6.28318548f;
    float num2 = (float) Main.rand.Next(1, 3);
    float num3 = 0.7f;
    int i = 916;
    Main.instance.LoadProjectile(i);
    Color color1 = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    Color indigo = Color.Indigo with { A = 0 };
    for (float num4 = 0.0f; (double) num4 < 1.0; num4 += 1f / num2)
    {
      float f = (float) (6.2831854820251465 * (double) num4 + (double) num1 + (double) Main.rand.NextFloatDirection() * 0.25);
      float num5 = (float) ((double) Main.rand.NextFloat() * 4.0 + 0.10000000149011612);
      Vector2 initialLocalPosition = Main.rand.NextVector2Circular(12f, 12f) * num3;
      Color.Lerp(Color.Lerp(Color.Black, indigo, Main.rand.NextFloat() * 0.5f), color1, Main.rand.NextFloat() * 0.6f);
      Color color2 = new Color(0, 0, 0, (int) byte.MaxValue);
      int num6 = Main.rand.Next(4);
      if (num6 == 1)
        color2 = Color.Lerp(new Color(106, 90, 205, (int) sbyte.MaxValue), Color.Black, (float) (0.10000000149011612 + 0.699999988079071 * (double) Main.rand.NextFloat()));
      if (num6 == 2)
        color2 = Color.Lerp(new Color(106, 90, 205, 60), Color.Black, (float) (0.10000000149011612 + 0.800000011920929 * (double) Main.rand.NextFloat()));
      RandomizedFrameParticle randomizedFrameParticle = ParticleOrchestrator._poolRandomizedFrame.RequestParticle();
      randomizedFrameParticle.SetBasicInfo(TextureAssets.Projectile[i], new Rectangle?(), Vector2.Zero, initialLocalPosition);
      randomizedFrameParticle.SetTypeInfo(Main.projFrames[i], 2, 24f);
      randomizedFrameParticle.Velocity = f.ToRotationVector2() * num5 * new Vector2(1f, 0.5f) * 0.2f + settings.MovementVector;
      randomizedFrameParticle.ColorTint = color2;
      randomizedFrameParticle.LocalPosition = settings.PositionInWorld + initialLocalPosition;
      randomizedFrameParticle.Rotation = randomizedFrameParticle.Velocity.ToRotation();
      randomizedFrameParticle.Scale = Vector2.One * 0.5f;
      randomizedFrameParticle.FadeInNormalizedTime = 0.01f;
      randomizedFrameParticle.FadeOutNormalizedTime = 0.5f;
      randomizedFrameParticle.ScaleVelocity = new Vector2(0.025f);
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) randomizedFrameParticle);
    }
  }

  private static void Spawn_BlackLightningHit(ParticleOrchestraSettings settings)
  {
    float num1 = Main.rand.NextFloat() * 6.28318548f;
    float num2 = 7f;
    float num3 = 0.7f;
    int i = 916;
    Main.instance.LoadProjectile(i);
    Color color1 = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    Color indigo = Color.Indigo with { A = 0 };
    for (float num4 = 0.0f; (double) num4 < 1.0; num4 += 1f / num2)
    {
      float f = (float) (6.2831854820251465 * (double) num4 + (double) num1 + (double) Main.rand.NextFloatDirection() * 0.25);
      float num5 = (float) ((double) Main.rand.NextFloat() * 4.0 + 0.10000000149011612);
      Vector2 initialLocalPosition = Main.rand.NextVector2Circular(12f, 12f) * num3;
      Color.Lerp(Color.Lerp(Color.Black, indigo, Main.rand.NextFloat() * 0.5f), color1, Main.rand.NextFloat() * 0.6f);
      Color color2 = new Color(0, 0, 0, (int) byte.MaxValue);
      int num6 = Main.rand.Next(4);
      if (num6 == 1)
        color2 = Color.Lerp(new Color(106, 90, 205, (int) sbyte.MaxValue), Color.Black, (float) (0.10000000149011612 + 0.699999988079071 * (double) Main.rand.NextFloat()));
      if (num6 == 2)
        color2 = Color.Lerp(new Color(106, 90, 205, 60), Color.Black, (float) (0.10000000149011612 + 0.800000011920929 * (double) Main.rand.NextFloat()));
      RandomizedFrameParticle randomizedFrameParticle = ParticleOrchestrator._poolRandomizedFrame.RequestParticle();
      randomizedFrameParticle.SetBasicInfo(TextureAssets.Projectile[i], new Rectangle?(), Vector2.Zero, initialLocalPosition);
      randomizedFrameParticle.SetTypeInfo(Main.projFrames[i], 2, 24f);
      randomizedFrameParticle.Velocity = f.ToRotationVector2() * num5 * new Vector2(1f, 0.5f);
      randomizedFrameParticle.ColorTint = color2;
      randomizedFrameParticle.LocalPosition = settings.PositionInWorld + initialLocalPosition;
      randomizedFrameParticle.Rotation = f;
      randomizedFrameParticle.Scale = Vector2.One;
      randomizedFrameParticle.FadeInNormalizedTime = 0.01f;
      randomizedFrameParticle.FadeOutNormalizedTime = 0.5f;
      randomizedFrameParticle.ScaleVelocity = new Vector2(0.05f);
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) randomizedFrameParticle);
    }
  }

  private static void Spawn_BlueLightningSmallLong(ParticleOrchestraSettings settings)
  {
    Vector2 positionInWorld = settings.PositionInWorld;
    Vector2 vector2 = settings.MovementVector.SafeNormalize(Vector2.Zero);
    float num1 = settings.MovementVector.Length();
    int num2 = 25;
    int num3 = 40;
    if ((double) num1 < (double) num3)
      return;
    float num4 = 0.0f;
    while ((double) num4 < (double) num1)
    {
      ParticleOrchestrator.Spawn_BlueLightningSmall(new ParticleOrchestraSettings()
      {
        PositionInWorld = positionInWorld,
        MovementVector = vector2 * 2f
      });
      num4 += (float) num2;
      positionInWorld += vector2 * (float) num2;
    }
  }

  private static void Spawn_BlueLightningSmall(ParticleOrchestraSettings settings)
  {
    float num1 = Main.rand.NextFloat() * 6.28318548f;
    float num2 = (float) Main.rand.Next(1, 3);
    Main.rand.Next(1, 3);
    float num3 = 0.7f;
    short i = 916;
    Main.instance.LoadProjectile((int) i);
    Color color1 = new Color(133, (int) byte.MaxValue, (int) byte.MaxValue, 0);
    Color color2 = new Color(15, 100, 155, 0);
    Lighting.AddLight(settings.PositionInWorld, new Vector3(0.4f, 0.8f, 1f) * 0.7f);
    for (float num4 = 0.0f; (double) num4 < 1.0; num4 += 1f / num2)
    {
      float f = (float) (6.2831854820251465 * (double) num4 + (double) num1 + (double) Main.rand.NextFloatDirection() * 0.25);
      float num5 = (float) ((double) Main.rand.NextFloat() * 4.0 + 0.10000000149011612);
      Vector2 initialLocalPosition = Main.rand.NextVector2Circular(6f, 6f) * num3;
      Color color3 = Color.Lerp(color1, color2, Main.rand.NextFloat());
      RandomizedFrameParticle randomizedFrameParticle = ParticleOrchestrator._poolRandomizedFrame.RequestParticle();
      randomizedFrameParticle.SetBasicInfo(TextureAssets.Projectile[(int) i], new Rectangle?(), Vector2.Zero, initialLocalPosition);
      randomizedFrameParticle.SetTypeInfo(Main.projFrames[(int) i], 2, 10f);
      randomizedFrameParticle.Velocity = f.ToRotationVector2() * num5 * new Vector2(1f, 0.5f) * 0.2f + settings.MovementVector;
      randomizedFrameParticle.ColorTint = color3;
      randomizedFrameParticle.LocalPosition = settings.PositionInWorld + initialLocalPosition;
      randomizedFrameParticle.Rotation = randomizedFrameParticle.Velocity.ToRotation();
      randomizedFrameParticle.Scale = Vector2.One * 1f;
      randomizedFrameParticle.FadeInNormalizedTime = 0.01f;
      randomizedFrameParticle.FadeOutNormalizedTime = 0.5f;
      randomizedFrameParticle.ScaleVelocity = new Vector2(0.025f);
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) randomizedFrameParticle);
      if (Main.rand.Next(2) == 0)
      {
        Dust dust = Dust.NewDustPerfect(randomizedFrameParticle.LocalPosition, 226, new Vector2?(randomizedFrameParticle.Velocity));
        dust.scale = 0.8f;
        dust.noGravity = true;
        dust.velocity = Main.rand.NextVector2Circular(4f, 4f);
        dust.scale *= 1.25f;
      }
    }
  }

  private static void Spawn_StellarTune(ParticleOrchestraSettings settings)
  {
    float num1 = Main.rand.NextFloat() * 6.28318548f;
    float num2 = 5f;
    Vector2 vector2_1 = new Vector2(0.7f);
    for (float num3 = 0.0f; (double) num3 < 1.0; num3 += 1f / num2)
    {
      float f = (float) (6.2831854820251465 * (double) num3 + (double) num1 + (double) Main.rand.NextFloatDirection() * 0.25);
      Vector2 vector2_2 = 1.5f * vector2_1;
      float num4 = 60f;
      Vector2 vector2_3 = Main.rand.NextVector2Circular(12f, 12f) * vector2_1;
      Color color = Color.Lerp(Color.Gold, Color.HotPink, Main.rand.NextFloat());
      if (Main.rand.Next(2) == 0)
        color = Color.Lerp(Color.Violet, Color.HotPink, Main.rand.NextFloat());
      PrettySparkleParticle prettySparkleParticle = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle.Velocity = f.ToRotationVector2() * vector2_2;
      prettySparkleParticle.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_2 / num4);
      prettySparkleParticle.ColorTint = color;
      prettySparkleParticle.LocalPosition = settings.PositionInWorld + vector2_3;
      prettySparkleParticle.Rotation = f;
      prettySparkleParticle.Scale = vector2_1 * (float) ((double) Main.rand.NextFloat() * 0.800000011920929 + 0.20000000298023224);
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle);
    }
  }

  private static void Spawn_CattivaHit(ParticleOrchestraSettings settings)
  {
    float num1 = Main.rand.NextFloat() * 6.28318548f;
    float num2 = 6f;
    Vector2 vector2_1 = new Vector2(0.7f);
    for (float num3 = 0.0f; (double) num3 < 1.0; num3 += 1f / num2)
    {
      float f = (float) (6.2831854820251465 * (double) num3 + (double) num1 + (double) Main.rand.NextFloatDirection() * 0.25);
      Vector2 vector2_2 = 4.5f * vector2_1;
      float num4 = 16f;
      Vector2 vector2_3 = Main.rand.NextVector2Circular(6f, 6f) * vector2_1;
      Color color = Color.Lerp(Color.Gold, Color.Orange, Main.rand.NextFloat());
      if (Main.rand.Next(2) == 0)
        color = Color.Lerp(Color.White, Color.Orange, Main.rand.NextFloat());
      PrettySparkleParticle prettySparkleParticle = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle.Velocity = f.ToRotationVector2() * vector2_2;
      prettySparkleParticle.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_2 / num4) * 0.5f;
      prettySparkleParticle.ColorTint = color;
      prettySparkleParticle.LocalPosition = settings.PositionInWorld + vector2_3;
      prettySparkleParticle.Rotation = f;
      prettySparkleParticle.Scale = vector2_1 * (float) ((double) Main.rand.NextFloat() * 0.699999988079071 + 0.10000000149011612);
      prettySparkleParticle.DrawVerticalAxis = false;
      prettySparkleParticle.FadeInEnd = 0.1f;
      prettySparkleParticle.FadeOutNormalizedTime = 0.5f;
      prettySparkleParticle.TimeToLive = num4;
      prettySparkleParticle.Scale.X *= 4f;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle);
    }
  }

  private static void Spawn_Keybrand(ParticleOrchestraSettings settings)
  {
    float num1 = Main.rand.NextFloat() * 6.28318548f;
    float num2 = 3f;
    Vector2 vector2_1 = new Vector2(0.7f);
    for (float num3 = 0.0f; (double) num3 < 1.0; num3 += 1f / num2)
    {
      float f = (float) (6.2831854820251465 * (double) num3 + (double) num1 + (double) Main.rand.NextFloatDirection() * 0.10000000149011612);
      Vector2 vector2_2 = 1.5f * vector2_1;
      float num4 = 60f;
      Vector2 vector2_3 = Main.rand.NextVector2Circular(4f, 4f) * vector2_1;
      PrettySparkleParticle prettySparkleParticle = ParticleOrchestrator._poolPrettySparkle.RequestParticle();
      prettySparkleParticle.Velocity = f.ToRotationVector2() * vector2_2;
      prettySparkleParticle.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_2 / num4);
      prettySparkleParticle.ColorTint = Color.Lerp(Color.Gold, Color.OrangeRed, Main.rand.NextFloat());
      prettySparkleParticle.LocalPosition = settings.PositionInWorld + vector2_3;
      prettySparkleParticle.Rotation = f;
      prettySparkleParticle.Scale = vector2_1 * 0.8f;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) prettySparkleParticle);
    }
    float num5 = num1 + (float) (1.0 / (double) num2 / 2.0 * 6.2831854820251465);
    float num6 = Main.rand.NextFloat() * 6.28318548f;
    for (float num7 = 0.0f; (double) num7 < 1.0; num7 += 1f / num2)
    {
      float f = (float) (6.2831854820251465 * (double) num7 + (double) num6 + (double) Main.rand.NextFloatDirection() * 0.10000000149011612);
      Vector2 vector2_4 = 1f * vector2_1;
      float timeToLive = 30f;
      Color color = Color.Lerp(Color.White, Color.Lerp(Color.Gold, Color.OrangeRed, Main.rand.NextFloat()), 0.5f) with
      {
        A = 0
      };
      Vector2 vector2_5 = Main.rand.NextVector2Circular(4f, 4f) * vector2_1;
      FadingParticle fadingParticle = ParticleOrchestrator._poolFading.RequestParticle();
      fadingParticle.SetBasicInfo(TextureAssets.Extra[98], new Rectangle?(), Vector2.Zero, Vector2.Zero);
      fadingParticle.SetTypeInfo(timeToLive);
      fadingParticle.Velocity = f.ToRotationVector2() * vector2_4;
      fadingParticle.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_4 / timeToLive);
      fadingParticle.ColorTint = color;
      fadingParticle.LocalPosition = settings.PositionInWorld + f.ToRotationVector2() * vector2_4 * vector2_1 * timeToLive * 0.2f + vector2_5;
      fadingParticle.Rotation = f + 1.57079637f;
      fadingParticle.FadeInNormalizedTime = 0.3f;
      fadingParticle.FadeOutNormalizedTime = 0.4f;
      fadingParticle.Scale = new Vector2(0.5f, 1.2f) * 0.8f * vector2_1;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle);
    }
    float num8 = 1f;
    float num9 = Main.rand.NextFloat() * 6.28318548f;
    for (float num10 = 0.0f; (double) num10 < 1.0; num10 += 1f / num8)
    {
      float num11 = 6.28318548f * num10 + num9;
      float timeToLive = 30f;
      Color color = Color.Lerp(Color.CornflowerBlue, Color.White, Main.rand.NextFloat()) with
      {
        A = 127 /*0x7F*/
      };
      Vector2 vector2_6 = Main.rand.NextVector2Circular(4f, 4f) * vector2_1;
      Vector2 vector2_7 = Main.rand.NextVector2Square(0.7f, 1.3f);
      FadingParticle fadingParticle = ParticleOrchestrator._poolFading.RequestParticle();
      fadingParticle.SetBasicInfo(TextureAssets.Extra[174], new Rectangle?(), Vector2.Zero, Vector2.Zero);
      fadingParticle.SetTypeInfo(timeToLive);
      fadingParticle.ColorTint = color;
      fadingParticle.LocalPosition = settings.PositionInWorld + vector2_6;
      fadingParticle.Rotation = num11 + 1.57079637f;
      fadingParticle.FadeInNormalizedTime = 0.1f;
      fadingParticle.FadeOutNormalizedTime = 0.4f;
      fadingParticle.Scale = new Vector2(0.1f, 0.1f) * vector2_1;
      fadingParticle.ScaleVelocity = vector2_7 * 1f / 60f;
      fadingParticle.ScaleAcceleration = vector2_7 * -0.0166666675f / 60f;
      Main.ParticleSystem_World_OverPlayers.Add((IParticle) fadingParticle);
    }
  }

  private static void Spawn_FlameWaders(ParticleOrchestraSettings settings)
  {
    float timeToLive = 60f;
    for (int index = -1; index <= 1; ++index)
    {
      int i = (int) Main.rand.NextFromList<short>((short) 326, (short) 327, (short) 328);
      Main.instance.LoadProjectile(i);
      Player player = Main.player[(int) settings.IndexOfPlayerWhoInvokedThis];
      float num = (float) ((double) Main.rand.NextFloat() * 0.89999997615814209 + 0.10000000149011612);
      Vector2 vector2 = settings.PositionInWorld + new Vector2((float) index * 5.33333349f, 0.0f);
      FlameParticle flameParticle = ParticleOrchestrator._poolFlame.RequestParticle();
      flameParticle.SetBasicInfo(TextureAssets.Projectile[i], new Rectangle?(), Vector2.Zero, vector2);
      flameParticle.SetTypeInfo(timeToLive, (int) settings.IndexOfPlayerWhoInvokedThis, player.cFlameWaker);
      flameParticle.FadeOutNormalizedTime = 0.4f;
      flameParticle.ScaleAcceleration = Vector2.One * num * -0.0166666675f / timeToLive;
      flameParticle.Scale = Vector2.One * num;
      Main.ParticleSystem_World_BehindPlayers.Add((IParticle) flameParticle);
      if (Main.rand.Next(16 /*0x10*/) == 0)
      {
        Dust dust = Dust.NewDustDirect(vector2, 4, 4, 6, Alpha: 100);
        if (Main.rand.Next(2) == 0)
        {
          dust.noGravity = true;
          dust.fadeIn = 1.15f;
        }
        else
          dust.scale = 0.6f;
        dust.velocity *= 0.6f;
        dust.velocity.Y -= 1.2f;
        dust.noLight = true;
        dust.position.Y -= 4f;
        dust.shader = GameShaders.Armor.GetSecondaryShader(player.cFlameWaker, player);
      }
    }
  }

  private static void Spawn_WallOfFleshGoatMountFlames(ParticleOrchestraSettings settings)
  {
    float timeToLive = 50f;
    for (int index = -1; index <= 1; ++index)
    {
      int i = (int) Main.rand.NextFromList<short>((short) 326, (short) 327, (short) 328);
      Main.instance.LoadProjectile(i);
      Player player = Main.player[(int) settings.IndexOfPlayerWhoInvokedThis];
      float num = (float) ((double) Main.rand.NextFloat() * 0.89999997615814209 + 0.10000000149011612);
      Vector2 vector2 = settings.PositionInWorld + new Vector2((float) index * 5.33333349f, 0.0f);
      FlameParticle flameParticle = ParticleOrchestrator._poolFlame.RequestParticle();
      flameParticle.SetBasicInfo(TextureAssets.Projectile[i], new Rectangle?(), Vector2.Zero, vector2);
      flameParticle.SetTypeInfo(timeToLive, (int) settings.IndexOfPlayerWhoInvokedThis, player.cMount);
      flameParticle.FadeOutNormalizedTime = 0.3f;
      flameParticle.ScaleAcceleration = Vector2.One * num * -0.0166666675f / timeToLive;
      flameParticle.Scale = Vector2.One * num;
      Main.ParticleSystem_World_BehindPlayers.Add((IParticle) flameParticle);
      if (Main.rand.Next(8) == 0)
      {
        Dust dust = Dust.NewDustDirect(vector2, 4, 4, 6, Alpha: 100);
        if (Main.rand.Next(2) == 0)
        {
          dust.noGravity = true;
          dust.fadeIn = 1.15f;
        }
        else
          dust.scale = 0.6f;
        dust.velocity *= 0.6f;
        dust.velocity.Y -= 1.2f;
        dust.noLight = true;
        dust.position.Y -= 4f;
        dust.shader = GameShaders.Armor.GetSecondaryShader(player.cMount, player);
      }
    }
  }
}
