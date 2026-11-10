// Decompiled with JetBrains decompiler
// Type: Terraria.Initializers.NetworkInitializer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.GameContent;
using Terraria.GameContent.Items;
using Terraria.GameContent.NetModules;
using Terraria.Net;

#nullable disable
namespace Terraria.Initializers;

public static class NetworkInitializer
{
  public static void Load()
  {
    NetManager.Instance.Register<NetLiquidModule>();
    NetManager.Instance.Register<NetTextModule>();
    NetManager.Instance.Register<NetPingModule>();
    NetManager.Instance.Register<NetAmbienceModule>();
    NetManager.Instance.Register<NetBestiaryModule>();
    NetManager.Instance.Register<NetCreativePowersModule>();
    NetManager.Instance.Register<NetCreativeUnlocksPlayerReportModule>();
    NetManager.Instance.Register<NetTeleportPylonModule>();
    NetManager.Instance.Register<NetParticlesModule>();
    NetManager.Instance.Register<NetCreativePowerPermissionsModule>();
    NetManager.Instance.Register<BannerSystem.NetBannersModule>();
    NetManager.Instance.Register<CraftingRequests.NetCraftingRequestsModule>();
    NetManager.Instance.Register<TagEffectState.NetModule>();
    NetManager.Instance.Register<LeashedEntity.NetModule>();
    NetManager.Instance.Register<UnbreakableWallScan.NetModule>();
  }
}
