// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.NoRoomCheckFeedback
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public class NoRoomCheckFeedback : 
  IRoomCheckFeedback,
  IRoomCheckFeedback_Spread,
  IRoomCheckFeedback_Scoring
{
  public static NoRoomCheckFeedback WithText = new NoRoomCheckFeedback(true);
  public static NoRoomCheckFeedback WithoutText = new NoRoomCheckFeedback(false);

  public NoRoomCheckFeedback(bool displayText) => this.DisplayText = displayText;

  public void BeginSpread(int x, int y)
  {
  }

  public void StartedInASolidTile(int x, int y)
  {
  }

  public void TooCloseToWorldEdge(int x, int y, int iteration)
  {
  }

  public void AnyBlockScannedHere(int x, int y, int iteration)
  {
  }

  public void RoomTooBig(int x, int y, int iteration)
  {
  }

  public void BlockingWall(int x, int y, int iteration)
  {
  }

  public void BlockingOpenGate(int x, int y, int iteration)
  {
  }

  public void Stinkbug(int x, int y, int iteration)
  {
  }

  public void EchoStinkbug(int x, int y, int iteration)
  {
  }

  public void MissingAWall(int x, int y, int iteration)
  {
  }

  public void UnsafeWall(int x, int y, int iteration)
  {
  }

  public void EndSpread()
  {
  }

  public void BeginScoring()
  {
  }

  public void ReportScore(int x, int y, int score)
  {
  }

  public void SetAsHighScore(int x, int y, int score)
  {
  }

  public void EndScoring()
  {
  }

  public bool StopOnFail => true;

  public bool DisplayText { get; private set; }
}
