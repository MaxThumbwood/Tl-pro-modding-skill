// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LightningGenerator
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria.Utilities;
using Terraria.Utilities.Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent;

public class LightningGenerator
{
  public bool SolidTileCollision;
  public float RotationStrength;
  public int StepSize;
  public int Layers;
  public float LayerStrengthFactor;
  public float PerpendicularDeviationFactor;
  public float ReduceRandomnessAfter;
  public float ForkGenerationThresholdAngleFraction;
  public float ForkReflectAngleMultiplier;
  public float ForkRotationStrengthMultiplier;
  public float ForkStepSizeMultiplier;
  public float ForkLengthMultiplier;
  public int MaxForksPerBolt;
  public int MaxForkDepth;
  public FloatRange ForkProgressRange;

  public LightningGenerator.Bolt Generate(
    List<LightningGenerator.Bolt> bolts,
    uint seed,
    Vector2 sourcePosition,
    Vector2 targetPosition,
    bool calcPositions,
    bool calcRotations)
  {
    LightningGenerator.Bolt bolt1 = this.GenerateBolt(bolts, seed, 0, calcPositions, sourcePosition, targetPosition, this.RotationStrength, (float) this.StepSize, new FloatRange(0.0f, 1f));
    if (calcRotations)
    {
      foreach (LightningGenerator.Bolt bolt2 in bolts)
      {
        bolt2.rotations = LightningGenerator.CalcRotations(bolt2.positions);
        LightningGenerator.SmoothRotations(bolt2.rotations);
      }
    }
    return bolt1;
  }

  private LightningGenerator.Bolt GenerateBolt(
    List<LightningGenerator.Bolt> bolts,
    uint seed,
    int depth,
    bool calcPositions,
    Vector2 startPos,
    Vector2 targetPos,
    float rotationStrength,
    float stepSize,
    FloatRange progressRange)
  {
    LCG32Random lcG32Random = new LCG32Random(seed);
    float radians1 = 0.0f;
    float[] numArray = new float[this.Layers];
    Point tileCoordinates = targetPos.ToTileCoordinates();
    Vector2 vector2_1 = startPos;
    Vector2 vector2_2 = targetPos - startPos;
    float num1 = vector2_2.Length();
    Vector2 vector2_3 = vector2_2 / num1;
    Vector2 vector2_4 = new Vector2(vector2_3.Y, -vector2_3.X);
    int length = (int) ((double) num1 * 2.0 / (double) stepSize);
    int fromValue = 0;
    Vector2[] array = calcPositions ? new Vector2[length] : (Vector2[]) null;
    LightningGenerator.Bolt bolt = new LightningGenerator.Bolt()
    {
      positions = array,
      forkDepth = depth,
      progressRange = progressRange
    };
    int index1;
    for (index1 = 0; index1 < length; ++index1)
    {
      if (calcPositions)
        array[index1] = vector2_1;
      Vector2 vector2_5 = targetPos - vector2_1;
      float num2 = Vector2.Dot(vector2_5, vector2_3);
      if ((double) num2 >= (double) stepSize)
      {
        float num3 = MathHelper.Clamp((float) (1.0 - (double) num2 / (double) num1), 0.0f, 1f);
        if (this.SolidTileCollision && vector2_1.ToTileCoordinates() != tileCoordinates && this.TileCollision(vector2_1))
        {
          bolt.progressRange = new FloatRange(progressRange.Minimum, progressRange.Lerp(num3));
          bolt.collidedWithTile = true;
          break;
        }
        Vector2 spinningpoint = vector2_5 / vector2_5.Length();
        float num4 = MathHelper.Clamp(-Vector2.Dot(spinningpoint, vector2_4) / Math.Max(0.01f, (float) ((double) Math.Min(num3, 1f - num3) * (double) this.PerpendicularDeviationFactor * 2.0)), -1f, 1f);
        int layer;
        if (this.PickLayerToReroll(lcG32Random.NextDouble(), 0.5f, out layer))
        {
          float num5 = rotationStrength;
          for (int index2 = this.Layers - 1; index2 > layer; --index2)
            num5 /= this.LayerStrengthFactor;
          float num6 = (float) (lcG32Random.NextDouble() * 2.0 - 1.0);
          float num7 = (num6 + (float) (((double) num4 - (double) num6 * (double) Math.Abs(num4)) / 2.0)) * num5;
          float num8 = numArray[layer];
          float num9 = num7 - num8;
          radians1 += num9;
          numArray[layer] = num7;
          if (layer == this.Layers - 1)
          {
            float num10 = lcG32Random.NextFloat();
            float num11 = Utils.Remap((float) fromValue, 0.0f, (float) this.MaxForksPerBolt, 1f, 0.0f);
            float radians2 = radians1 - num9 * (1f + this.ForkReflectAngleMultiplier);
            if (bolts != null && (double) Math.Abs(num9) >= (double) rotationStrength * (double) this.ForkGenerationThresholdAngleFraction && this.ForkProgressRange.Contains(num3) && depth < this.MaxForkDepth && (double) num10 < (double) num11 && (double) Math.Abs(radians2) < 1.3962634801864624)
            {
              ++fromValue;
              float num12 = (1f - num3) * this.ForkLengthMultiplier;
              Vector2 targetPos1 = vector2_1 + spinningpoint.RotatedBy((double) radians2) * num1 * num12;
              this.GenerateBolt(bolts, lcG32Random.state + 1U, depth + 1, calcPositions, vector2_1, targetPos1, rotationStrength * this.ForkRotationStrengthMultiplier, stepSize * this.ForkStepSizeMultiplier, new FloatRange(progressRange.Lerp(num3), progressRange.Lerp(num3 + num12)));
            }
          }
        }
        float chance = Utils.Remap(num3, this.ReduceRandomnessAfter, 1f, 0.0f, 1f) + Utils.Remap(Math.Abs(num4), 0.5f, 1f, 0.0f, 1f);
        if (this.PickHighLayerToReroll(lcG32Random.NextDouble(), chance, out layer))
        {
          radians1 -= numArray[layer];
          numArray[layer] = 0.0f;
        }
        vector2_1 += spinningpoint.RotatedBy((double) radians1) * stepSize;
      }
      else
        break;
    }
    if (calcPositions && index1 < length)
    {
      Array.Resize<Vector2>(ref array, index1 + 1);
      bolt.positions = array;
    }
    if (bolts != null && index1 > 2)
      bolts.Add(bolt);
    return bolt;
  }

  private bool TileCollision(Vector2 pos)
  {
    Point tileCoordinates = pos.ToTileCoordinates();
    if (!WorldGen.InWorld(tileCoordinates) || Main.tile[tileCoordinates.X, tileCoordinates.Y] == null)
      return false;
    if (WorldGen.SolidOrSlopedTile(tileCoordinates.X, tileCoordinates.Y))
      return true;
    int liquid = (int) Main.tile[tileCoordinates.X, tileCoordinates.Y].liquid;
    return liquid > 0 && (int) pos.Y % 16 /*0x10*/ > 16 /*0x10*/ * ((int) byte.MaxValue - liquid) / (int) byte.MaxValue;
  }

  private bool PickLayerToReroll(double r, float chance, out int layer)
  {
    layer = 0;
    while (layer < this.Layers)
    {
      if (r >= 1.0 - (double) chance)
        return true;
      r /= (double) chance;
      ++layer;
    }
    return false;
  }

  private bool PickHighLayerToReroll(double r, float chance, out int layer)
  {
    if (!this.PickLayerToReroll(r, chance, out layer))
      return false;
    layer = this.Layers - 1 - layer;
    return true;
  }

  private static float[] CalcRotations(Vector2[] positions)
  {
    float[] numArray1 = new float[positions.Length];
    if (numArray1.Length < 2)
      return numArray1;
    int num1 = 0;
    float num2 = (positions[0] - positions[1]).ToRotation();
    float[] numArray2 = numArray1;
    int index1 = num1;
    int index2 = index1 + 1;
    double num3 = (double) num2;
    numArray2[index1] = (float) num3;
    while (index2 < numArray1.Length - 1)
    {
      float rotation = (positions[index2] - positions[index2 + 1]).ToRotation();
      numArray1[index2++] = num2 + MathHelper.WrapAngle(rotation - num2) / 2f;
      num2 = rotation;
    }
    numArray1[index2] = num2;
    return numArray1;
  }

  private static void SmoothRotations(float[] rotations)
  {
    float num = rotations[0];
    for (int index = 1; index < rotations.Length - 1; ++index)
    {
      float rotation1 = rotations[index];
      float rotation2 = rotations[index + 1];
      rotations[index] = rotation1 + (float) (((double) MathHelper.WrapAngle(num - rotation1) + (double) MathHelper.WrapAngle(rotation2 - rotation1)) / 2.0);
      num = rotation1;
    }
  }

  public class Bolt
  {
    public Vector2[] positions;
    public float[] rotations;
    public FloatRange progressRange;
    public int forkDepth;
    public bool collidedWithTile;

    public bool IsMainBolt => this.forkDepth == 0;
  }

  public static class StormLightning
  {
    public static LightningGenerator Generator = new LightningGenerator()
    {
      RotationStrength = 0.9f,
      StepSize = 8,
      Layers = 4,
      LayerStrengthFactor = 1.5f,
      PerpendicularDeviationFactor = 5f,
      ReduceRandomnessAfter = 0.8f,
      ForkGenerationThresholdAngleFraction = 0.65f,
      ForkReflectAngleMultiplier = 0.4f,
      ForkRotationStrengthMultiplier = 0.9f,
      ForkStepSizeMultiplier = 0.8f,
      ForkLengthMultiplier = 0.8f,
      MaxForksPerBolt = 2,
      MaxForkDepth = 2,
      ForkProgressRange = new FloatRange(0.3f, 0.8f),
      SolidTileCollision = true
    };
    private static float SourceRotationLimit = 0.34906587f;
    private static float Length = 1000f;

    public static bool CanHitTarget(uint seed, Vector2 targetPosition)
    {
      return !LightningGenerator.StormLightning.Generate((List<LightningGenerator.Bolt>) null, seed, targetPosition, false, false).collidedWithTile;
    }

    public static LightningGenerator.Bolt GenerateMainBoltPath(uint seed, Vector2 targetPosition)
    {
      return LightningGenerator.StormLightning.Generate((List<LightningGenerator.Bolt>) null, seed, targetPosition, calcRotations: false);
    }

    public static LightningGenerator.Bolt Generate(
      List<LightningGenerator.Bolt> bolts,
      uint seed,
      Vector2 targetPosition,
      bool calcPositions = true,
      bool calcRotations = true)
    {
      Vector2 vector2 = -Vector2.UnitY.RotatedBy((new LCG32Random(seed).NextDouble() * 2.0 - 1.0) * (double) LightningGenerator.StormLightning.SourceRotationLimit);
      return LightningGenerator.StormLightning.Generator.Generate(bolts, seed, targetPosition + vector2 * LightningGenerator.StormLightning.Length, targetPosition, calcPositions, calcRotations);
    }
  }
}
