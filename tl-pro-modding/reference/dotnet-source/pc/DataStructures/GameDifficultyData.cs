// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.GameDifficultyData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.DataStructures;

public static class GameDifficultyData
{
  public static readonly GameDifficultyData.LinearCurve EnemyMaxLifeMultiplier = new GameDifficultyData.LinearCurve(new GameDifficultyData.LinearCurve.Key[2]
  {
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Journey, 0.5f),
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Legendary, 4f)
  });
  public static readonly GameDifficultyData.LinearCurve EnemyDamageMultiplier = new GameDifficultyData.LinearCurve(new GameDifficultyData.LinearCurve.Key[3]
  {
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Journey, 0.5f),
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Master, 3f),
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Legendary, 5.33333349f)
  });
  public static readonly GameDifficultyData.LinearCurve HostileProjectileDamageMultiplier = new GameDifficultyData.LinearCurve(new GameDifficultyData.LinearCurve.Key[2]
  {
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Journey, 0.5f),
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Master, 3f)
  });
  public static readonly GameDifficultyData.LinearCurve KnockbackToEnemiesMultiplier = new GameDifficultyData.LinearCurve(new GameDifficultyData.LinearCurve.Key[2]
  {
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Classic, 1f),
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Master, 0.8f)
  });
  public static readonly GameDifficultyData.LinearCurve EnemyMoneyDropMultiplier = new GameDifficultyData.LinearCurve(new GameDifficultyData.LinearCurve.Key[4]
  {
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Classic, 1f),
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Expert, 2.5f),
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Master, 2.5f),
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Legendary, 3.5f)
  });
  public static readonly GameDifficultyData.LinearCurve TownNPCDamageMultiplier = new GameDifficultyData.LinearCurve(new GameDifficultyData.LinearCurve.Key[4]
  {
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Journey, 2f),
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Classic, 1f),
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Expert, 1.5f),
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Legendary, 2f)
  });
  public static readonly GameDifficultyData.LinearCurve DebuffTimeMultiplier = new GameDifficultyData.LinearCurve(new GameDifficultyData.LinearCurve.Key[3]
  {
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Classic, 1f),
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Expert, 2f),
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Master, 2.5f)
  });
  public static readonly GameDifficultyData.LinearCurve LightningPlayerDamageScaling = new GameDifficultyData.LinearCurve(new GameDifficultyData.LinearCurve.Key[4]
  {
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Journey, 0.04f),
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Classic, 0.08f),
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Master, 0.24f),
    new GameDifficultyData.LinearCurve.Key(GameDifficultyLevel.Legendary, 0.4f)
  });

  public struct LinearCurve
  {
    public readonly GameDifficultyData.LinearCurve.Key[] keys;

    public LinearCurve(params GameDifficultyData.LinearCurve.Key[] keys)
    {
      this.keys = keys;
      ref GameDifficultyData.LinearCurve.Key local = ref keys[0];
      for (int index = 1; index < keys.Length; ++index)
      {
        double input = (double) keys[index].input;
      }
    }

    public float Sample(float value)
    {
      GameDifficultyData.LinearCurve.Key key1 = this.keys[0];
      GameDifficultyData.LinearCurve.Key key2 = key1;
      for (int index = 0; index < this.keys.Length; ++index)
      {
        key2 = this.keys[index];
        if ((double) value > (double) key2.input)
          key1 = key2;
        else
          break;
      }
      float num1 = key2.input - key1.input;
      float num2 = key2.output - key1.output;
      return (double) num1 == 0.0 ? key1.output : (value - key1.input) * num2 / num1 + key1.output;
    }

    public override string ToString()
    {
      return string.Join<GameDifficultyData.LinearCurve.Key>(", ", (IEnumerable<GameDifficultyData.LinearCurve.Key>) this.keys);
    }

    public struct Key(float input, float output)
    {
      public readonly float input = input;
      public readonly float output = output;

      public override string ToString() => $"{(object) this.input} -> {(object) this.output}";
    }
  }
}
