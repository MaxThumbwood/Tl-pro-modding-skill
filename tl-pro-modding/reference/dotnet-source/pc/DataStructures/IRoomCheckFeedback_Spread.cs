// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.IRoomCheckFeedback_Spread
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public interface IRoomCheckFeedback_Spread
{
  bool StopOnFail { get; }

  bool DisplayText { get; }

  void BeginSpread(int x, int y);

  void StartedInASolidTile(int x, int y);

  void TooCloseToWorldEdge(int x, int y, int iteration);

  void AnyBlockScannedHere(int x, int y, int iteration);

  void RoomTooBig(int x, int y, int iteration);

  void BlockingWall(int x, int y, int iteration);

  void BlockingOpenGate(int x, int y, int iteration);

  void Stinkbug(int x, int y, int iteration);

  void EchoStinkbug(int x, int y, int iteration);

  void MissingAWall(int x, int y, int iteration);

  void UnsafeWall(int x, int y, int iteration);

  void EndSpread();
}
