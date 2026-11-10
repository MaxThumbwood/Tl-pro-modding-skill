// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.DitherSnakePass
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.GameContent.Generation.Dungeon;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes;

public class DitherSnakePass(string passName) : GenPass(passName, 1.0)
{
  public static readonly double[,] _bayerDither = new double[4, 4]
  {
    {
      0.0,
      0.5,
      0.125,
      0.625
    },
    {
      0.75,
      0.25,
      0.875,
      0.375
    },
    {
      3.0 / 16.0,
      11.0 / 16.0,
      1.0 / 16.0,
      9.0 / 16.0
    },
    {
      15.0 / 16.0,
      7.0 / 16.0,
      13.0 / 16.0,
      5.0 / 16.0
    }
  };

  protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
  {
    progress.Message = Language.GetTextValue("WorldGeneration.DualDungeonsDitherSnake");
    GenVars.CurrentDungeon = 0;
    GenVars.CurrentDungeonGenVars.dungeonDitherSnake = this.CalculateDungeonDitherSnake(progress, 0.0, 0.02500000037252903);
    this.GenerateDungeonDitherSnake(progress, 0.02500000037252903, 0.5);
    GenVars.CurrentDungeon = 1;
    GenVars.CurrentDungeonGenVars.dungeonDitherSnake = this.CalculateDungeonDitherSnake(progress, 0.5, 0.52499997615814209);
    this.GenerateDungeonDitherSnake(progress, 0.52499997615814209, 1.0);
  }

  private void GenerateDungeonDitherSnake(
    GenerationProgress progress,
    double progressMin,
    double progressMax)
  {
    int num = 0;
    double count = (double) GenVars.CurrentDungeonGenVars.dungeonDitherSnake.Count;
    foreach (DungeonControlLine dungeonControlLine in (List<DungeonControlLine>) GenVars.CurrentDungeonGenVars.dungeonDitherSnake)
    {
      progress.Set((double) num++ / count, progressMin, progressMax);
      Microsoft.Xna.Framework.Rectangle hitbox = GenVars.CurrentDungeonGenVars.outerPotentialDungeonBounds.Hitbox;
      dungeonControlLine.Paint(hitbox);
    }
  }

  private DitherSnake CalculateDungeonDitherSnake(
    GenerationProgress progress,
    double progressMin,
    double progressMax)
  {
    DitherSnake source = new DitherSnake();
    UnifiedRandom genRand = WorldGen.genRand;
    List<DungeonGenerationStyleData> generationStyles = GenVars.CurrentDungeonGenVars.dungeonGenerationStyles;
    DungeonBounds potentialDungeonBounds = GenVars.CurrentDungeonGenVars.outerPotentialDungeonBounds;
    double fromValue = (double) Main.maxTilesX / 4200.0;
    int num1 = (int) (20.0 * fromValue);
    int count = generationStyles.Count;
    double num2 = 1.0 / (double) (num1 - 1);
    double num3 = 1.0 / (double) (count - 1);
    double num4 = (double) potentialDungeonBounds.Height / (double) count;
    double num5 = 1.0 - DungeonControlLine.NormalizedDistanceSafeFromDither;
    double val1_1 = num4 / 2.0 * (1.0 + num5 / 2.0) - 1.0;
    double val1_2 = val1_1 - 0.1 * fromValue * num4;
    double num6 = 0.05;
    double num7 = Utils.Remap(fromValue, 1.0, 2.0, 1.0, 1.5);
    double num8 = val1_1 + num4 / 2.0 * num7;
    double num9 = val1_1;
    Vector2D vector2D1;
    // ISSUE: explicit constructor call
    ((Vector2D) ref vector2D1).\u002Ector((double) potentialDungeonBounds.X + num8, (double) potentialDungeonBounds.Y + num9);
    Vector2D vector2D2;
    // ISSUE: explicit constructor call
    ((Vector2D) ref vector2D2).\u002Ector((double) potentialDungeonBounds.Width - num8 * 2.0, (double) potentialDungeonBounds.Height - num9 * 2.0);
    double num10 = Math.Min(val1_1 - val1_2, vector2D2.X * num2 / 2.0);
    DungeonGenerationStyleData generationStyleData = generationStyles[0];
    double startRadius = val1_1;
    Vector2D start = Vector2D.Zero;
    int num11 = num1 * count;
    int num12 = num11 / generationStyles.Count;
    double num13 = val1_1;
    double num14 = val1_1;
    for (int index = 0; index < num11; ++index)
    {
      progress.Set((double) index / (double) num11, progressMin, progressMax);
      int num15 = index % num1;
      int num16 = index / num1;
      double num17 = num2 * (double) num15;
      double num18 = num3 * (double) num16;
      int num19 = GenVars.CurrentDungeonGenVars.dungeonSide == (int) DungeonSide.Left ? 1 : -1;
      if (num16 % 2 == 1)
        num19 *= -1;
      if (num19 < 0)
        num17 = 1.0 - num17;
      Vector2D end1 = Vector2D.op_Addition(vector2D1, Vector2D.op_Multiply(vector2D2, new Vector2D(num17, num18)));
      if (index == 0)
        start = end1;
      else if (num16 == 0 && (end1.X - (double) GenVars.CurrentDungeonGenVars.dungeonLocation) * (double) num19 < 0.0)
      {
        // ISSUE: explicit constructor call
        ((Vector2D) ref start).\u002Ector((double) GenVars.CurrentDungeonGenVars.dungeonLocation, end1.Y);
      }
      else
      {
        num13 = Utils.Lerp(Math.Max(val1_2, num13 - num10), Math.Min(val1_1, num13 + num10), genRand.NextDouble());
        num14 = Utils.Lerp(Math.Max(val1_2, num14 - num10), Math.Min(val1_1, num14 + num10), genRand.NextDouble());
        double endRadius = (num13 + num14) / 2.0;
        end1.Y += (num13 - num14) / 2.0;
        int num20 = index / num12;
        DungeonGenerationStyleData style = generationStyles[num20];
        DungeonControlLine line1 = new DungeonControlLine(start, end1, startRadius, endRadius, num20, style);
        source.Add(line1);
        start = end1;
        startRadius = endRadius;
        if ((num15 != num1 - 1 ? 0 : (num16 != count - 1 ? 1 : 0)) != 0)
        {
          Vector2D spinningpoint = end1;
          Vector2D vector2D3 = Vector2D.op_Addition(end1, Vector2D.op_Multiply(vector2D2, new Vector2D(0.0, num3)));
          Vector2D center = Vector2D.Lerp(spinningpoint, vector2D3, 0.5);
          for (double num21 = num6; num21 < 0.5; num21 += num6)
          {
            Vector2D end2 = spinningpoint.RotatedBy(2.0 * Math.PI * num21 * (double) num19, center);
            end2.X = Utils.Lerp(end2.X, center.X, 1.0 - num7);
            DungeonControlLine line2 = new DungeonControlLine(start, end2, startRadius, endRadius, num20, style)
            {
              CurveLine = true
            };
            source.Add(line2);
            start = end2;
            startRadius = endRadius;
          }
          ++index;
        }
      }
    }
    source.SetTangents();
    int num22 = GenVars.CurrentDungeonGenVars.dungeonSide == (int) DungeonSide.Left ? 1 : -1;
    source.First<DungeonControlLine>().StartTangent = Vector2D.op_Multiply(Vector2D.UnitX, (double) num22);
    source.Last<DungeonControlLine>().EndTangent = Vector2D.op_Multiply(Vector2D.UnitX, (double) num22);
    source.AdjustTangentsToPreventSelfIntersection();
    return source;
  }
}
