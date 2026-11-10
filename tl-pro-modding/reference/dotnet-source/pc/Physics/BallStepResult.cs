// Decompiled with JetBrains decompiler
// Type: Terraria.Physics.BallStepResult
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Physics;

public struct BallStepResult
{
  public readonly BallState State;

  private BallStepResult(BallState state) => this.State = state;

  public static BallStepResult OutOfBounds() => new BallStepResult(BallState.OutOfBounds);

  public static BallStepResult Moving() => new BallStepResult(BallState.Moving);

  public static BallStepResult Resting() => new BallStepResult(BallState.Resting);
}
