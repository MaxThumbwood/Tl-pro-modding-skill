// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.PlacementHook
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;

#nullable disable
namespace Terraria.DataStructures;

public struct PlacementHook(
  Func<int, int, int, int, int, int, int> hook,
  int badReturn,
  int badResponse,
  bool processedCoordinates)
{
  public Func<int, int, int, int, int, int, int> hook = hook;
  public int badReturn = badReturn;
  public int badResponse = badResponse;
  public bool processedCoordinates = processedCoordinates;
  public static PlacementHook Empty = new PlacementHook((Func<int, int, int, int, int, int, int>) null, 0, 0, false);
  public const int Response_AllInvalid = 0;

  public static bool operator ==(PlacementHook first, PlacementHook second)
  {
    return first.hook == second.hook && first.badResponse == second.badResponse && first.badReturn == second.badReturn && first.processedCoordinates == second.processedCoordinates;
  }

  public static bool operator !=(PlacementHook first, PlacementHook second)
  {
    return first.hook != second.hook || first.badResponse != second.badResponse || first.badReturn != second.badReturn || first.processedCoordinates != second.processedCoordinates;
  }

  public override bool Equals(object obj)
  {
    return obj is PlacementHook placementHook && this == placementHook;
  }

  public override int GetHashCode() => base.GetHashCode();
}
