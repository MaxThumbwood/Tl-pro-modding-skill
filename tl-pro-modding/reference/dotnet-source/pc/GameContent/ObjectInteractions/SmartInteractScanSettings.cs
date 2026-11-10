// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ObjectInteractions.SmartInteractScanSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent.ObjectInteractions;

public struct SmartInteractScanSettings
{
  public Player player;
  public bool DemandOnlyZeroDistanceTargets;
  public bool FullInteraction;
  public Vector2 mousevec;
  public int LX;
  public int HX;
  public int LY;
  public int HY;
}
