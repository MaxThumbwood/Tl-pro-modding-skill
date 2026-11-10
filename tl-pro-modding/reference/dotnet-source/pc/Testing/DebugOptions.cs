// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.DebugOptions
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.Localization;

#nullable disable
namespace Terraria.Testing;

public static class DebugOptions
{
  public static bool enableDebugCommands = false;
  public static bool Shared_ReportCommandUsage = true;
  public static int Shared_ServerPing = 0;
  public static double UpdateWaitInMs = 0.0;
  public static double DrawWaitInMs = 0.0;
  public static bool devLightTilesCheat;
  public static bool noLimits;
  public static bool noPause;
  public static int unlockMap;
  public static bool ShowSections;
  public static bool ShowUnbreakableWall;
  public static bool DrawLinkPoints;
  public static bool ShowNetOffsetDust;
  public static Vector2 FakeNetOffset;
  public static bool hideTiles = false;
  public static bool hideTiles2 = false;
  public static bool hideWalls = false;
  public static bool hideWater = false;
  public static bool NoDamageVar;
  public static bool LetProjectilesAimAtTargetDummies;
  public static bool PracticeMode;

  public static void SyncToJoiningPlayer(int playerIndex)
  {
    if (!DebugOptions.enableDebugCommands)
      return;
    NetMessage.SendData(94, playerIndex, text: NetworkText.FromLiteral("/showdebug"), number2: DebugOptions.Shared_ReportCommandUsage ? 1f : 0.0f);
    NetMessage.SendData(94, playerIndex, text: NetworkText.FromLiteral("/setserverping"), number2: (float) DebugOptions.Shared_ServerPing);
  }
}
