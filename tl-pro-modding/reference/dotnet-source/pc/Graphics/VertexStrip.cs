// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.VertexStrip
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Terraria.Graphics;

public class VertexStrip
{
  private VertexStrip.CustomVertexInfo[] _vertices = new VertexStrip.CustomVertexInfo[1];
  private int _vertexAmountCurrentlyMaintained;
  private short[] _indices = new short[1];
  private int _indicesAmountCurrentlyMaintained;
  private List<Vector2> _temporaryPositionsCache = new List<Vector2>();
  private List<float> _temporaryRotationsCache = new List<float>();

  public void Reset(int expectedVertexCount = 0)
  {
    this._vertexAmountCurrentlyMaintained = 0;
    this._indicesAmountCurrentlyMaintained = 0;
    if (this._vertices.Length >= expectedVertexCount)
      return;
    Array.Resize<VertexStrip.CustomVertexInfo>(ref this._vertices, expectedVertexCount);
  }

  public void PrepareStrip(
    Vector2[] positions,
    float[] rotations,
    VertexStrip.StripColorFunction colorFunction,
    VertexStrip.StripHalfWidthFunction widthFunction,
    Vector2 offsetForAllPositions = default (Vector2),
    int? expectedVertexPairsAmount = null,
    bool includeBacksides = false)
  {
    int length = positions.Length;
    this.Reset(length * 2);
    int num = length;
    if (expectedVertexPairsAmount.HasValue)
      num = expectedVertexPairsAmount.Value;
    for (int index = 0; index < length && !(positions[index] == Vector2.Zero); ++index)
    {
      Vector2 pos = positions[index] + offsetForAllPositions;
      float rot = MathHelper.WrapAngle(rotations[index]);
      float progressOnStrip = (float) index / (float) (num - 1);
      this.AddVertexPair(colorFunction, widthFunction, pos, rot, progressOnStrip);
    }
    this.PrepareIndices(includeBacksides);
  }

  public void PrepareStripWithProceduralPadding(
    Vector2[] positions,
    float[] rotations,
    VertexStrip.StripColorFunction colorFunction,
    VertexStrip.StripHalfWidthFunction widthFunction,
    Vector2 offsetForAllPositions = default (Vector2),
    bool includeBacksides = false,
    bool tryStoppingOddBug = true)
  {
    this._temporaryPositionsCache.Clear();
    this._temporaryRotationsCache.Clear();
    for (int index = 0; index < positions.Length && !(positions[index] == Vector2.Zero); ++index)
    {
      Vector2 position1 = positions[index];
      float f1 = MathHelper.WrapAngle(rotations[index]);
      this._temporaryPositionsCache.Add(position1);
      this._temporaryRotationsCache.Add(f1);
      if (index + 1 < positions.Length && positions[index + 1] != Vector2.Zero)
      {
        Vector2 position2 = positions[index + 1];
        float f2 = MathHelper.WrapAngle(rotations[index + 1]);
        int num1 = (int) ((double) Math.Abs(MathHelper.WrapAngle(f2 - f1)) / 0.2617993950843811);
        if (num1 != 0)
        {
          float num2 = position1.Distance(position2);
          Vector2 vector2_1 = position1 + f1.ToRotationVector2() * num2;
          Vector2 vector2_2 = position2 + f2.ToRotationVector2() * -num2;
          float num3 = 1f / (float) (num1 + 2);
          Vector2 Target = position1;
          for (float amount = num3; (double) amount < 1.0; amount += num3)
          {
            Vector2 Origin = Vector2.CatmullRom(vector2_1, position1, position2, vector2_2, amount);
            float f3 = MathHelper.WrapAngle(Origin.DirectionTo(Target).ToRotation());
            if (float.IsNaN(f3))
              f3 = this._temporaryRotationsCache.Last<float>();
            this._temporaryPositionsCache.Add(Origin);
            this._temporaryRotationsCache.Add(f3);
            Target = Origin;
          }
        }
      }
    }
    this.Reset(this._temporaryPositionsCache.Count * 2);
    int count = this._temporaryPositionsCache.Count;
    Vector2 zero = Vector2.Zero;
    for (int index = 0; index < count && (!tryStoppingOddBug || !(this._temporaryPositionsCache[index] == zero)); ++index)
    {
      Vector2 pos = this._temporaryPositionsCache[index] + offsetForAllPositions;
      float rot = this._temporaryRotationsCache[index];
      float progressOnStrip = (float) index / (float) (count - 1);
      this.AddVertexPair(colorFunction, widthFunction, pos, rot, progressOnStrip);
    }
    this.PrepareIndices(includeBacksides);
  }

  public void PrepareIndices(bool includeBacksides)
  {
    int num1 = this._vertexAmountCurrentlyMaintained / 2 - 1;
    int num2 = 6 + includeBacksides.ToInt() * 6;
    int newSize = num1 * num2;
    this._indicesAmountCurrentlyMaintained = newSize;
    if (this._indices.Length < newSize)
      Array.Resize<short>(ref this._indices, newSize);
    for (short index1 = 0; (int) index1 < num1; ++index1)
    {
      short index2 = (short) ((int) index1 * num2);
      int num3 = (int) index1 * 2;
      this._indices[(int) index2] = (short) num3;
      this._indices[(int) index2 + 1] = (short) (num3 + 1);
      this._indices[(int) index2 + 2] = (short) (num3 + 2);
      this._indices[(int) index2 + 3] = (short) (num3 + 2);
      this._indices[(int) index2 + 4] = (short) (num3 + 1);
      this._indices[(int) index2 + 5] = (short) (num3 + 3);
      if (includeBacksides)
      {
        this._indices[(int) index2 + 6] = (short) (num3 + 2);
        this._indices[(int) index2 + 7] = (short) (num3 + 1);
        this._indices[(int) index2 + 8] = (short) num3;
        this._indices[(int) index2 + 9] = (short) (num3 + 2);
        this._indices[(int) index2 + 10] = (short) (num3 + 3);
        this._indices[(int) index2 + 11] = (short) (num3 + 1);
      }
    }
  }

  public void AddVertexPair(
    VertexStrip.StripColorFunction colorFunction,
    VertexStrip.StripHalfWidthFunction widthFunction,
    Vector2 pos,
    float rot,
    float progressOnStrip)
  {
    Color vertexColor = colorFunction(progressOnStrip);
    float num = widthFunction(progressOnStrip);
    Vector2 vector2 = MathHelper.WrapAngle(rot - 1.57079637f).ToRotationVector2() * num;
    this.AddVertexPair(pos + vector2, pos - vector2, progressOnStrip, vertexColor);
  }

  public void AddVertexPair(Vector2 a, Vector2 b, Vector3 uvA, Vector3 uvB, Color vertexColor)
  {
    while (this._vertexAmountCurrentlyMaintained + 1 >= this._vertices.Length)
      Array.Resize<VertexStrip.CustomVertexInfo>(ref this._vertices, this._vertices.Length * 2);
    double num = (double) Vector2.Distance(a, b);
    this._vertices[this._vertexAmountCurrentlyMaintained].Position = a;
    this._vertices[this._vertexAmountCurrentlyMaintained + 1].Position = b;
    this._vertices[this._vertexAmountCurrentlyMaintained].TexCoord = uvA;
    this._vertices[this._vertexAmountCurrentlyMaintained + 1].TexCoord = uvB;
    this._vertices[this._vertexAmountCurrentlyMaintained].Color = vertexColor;
    this._vertices[this._vertexAmountCurrentlyMaintained + 1].Color = vertexColor;
    this._vertexAmountCurrentlyMaintained += 2;
  }

  public void AddVertexPair(Vector2 a, Vector2 b, float uv_x, Color vertexColor)
  {
    while (this._vertexAmountCurrentlyMaintained + 1 >= this._vertices.Length)
      Array.Resize<VertexStrip.CustomVertexInfo>(ref this._vertices, this._vertices.Length * 2);
    float num = Vector2.Distance(a, b);
    this._vertices[this._vertexAmountCurrentlyMaintained].Position = a;
    this._vertices[this._vertexAmountCurrentlyMaintained + 1].Position = b;
    this._vertices[this._vertexAmountCurrentlyMaintained].TexCoord = new Vector3(uv_x, num, num);
    this._vertices[this._vertexAmountCurrentlyMaintained + 1].TexCoord = new Vector3(uv_x, 0.0f, num);
    this._vertices[this._vertexAmountCurrentlyMaintained].Color = vertexColor;
    this._vertices[this._vertexAmountCurrentlyMaintained + 1].Color = vertexColor;
    this._vertexAmountCurrentlyMaintained += 2;
  }

  public void AddVertexPair(Vector2 v1, Vector2 v2, float uv_x, Color color1, Color color2)
  {
    while (this._vertexAmountCurrentlyMaintained + 1 >= this._vertices.Length)
      Array.Resize<VertexStrip.CustomVertexInfo>(ref this._vertices, this._vertices.Length * 2);
    float num = Vector2.Distance(v1, v2);
    this._vertices[this._vertexAmountCurrentlyMaintained++] = new VertexStrip.CustomVertexInfo(v1, color1, new Vector3(uv_x, num, num));
    this._vertices[this._vertexAmountCurrentlyMaintained++] = new VertexStrip.CustomVertexInfo(v2, color2, new Vector3(uv_x, 0.0f, num));
  }

  public void DrawTrail()
  {
    if (this._vertexAmountCurrentlyMaintained < 3)
      return;
    GraphicsDevice graphicsDevice = Main.instance.GraphicsDevice;
    VertexBufferBinding[] vertexBuffers = graphicsDevice.GetVertexBuffers();
    IndexBuffer indices = graphicsDevice.Indices;
    graphicsDevice.DrawUserIndexedPrimitives<VertexStrip.CustomVertexInfo>(PrimitiveType.TriangleList, this._vertices, 0, this._vertexAmountCurrentlyMaintained, this._indices, 0, this._indicesAmountCurrentlyMaintained / 3);
    graphicsDevice.SetVertexBuffers(vertexBuffers);
    graphicsDevice.Indices = indices;
  }

  public delegate Color StripColorFunction(float progressOnStrip);

  public delegate float StripHalfWidthFunction(float progressOnStrip);

  private struct CustomVertexInfo(Vector2 position, Color color, Vector3 texCoord) : IVertexType
  {
    public Vector2 Position = position;
    public Color Color = color;
    public Vector3 TexCoord = texCoord;
    private static VertexDeclaration _vertexDeclaration = new VertexDeclaration(new VertexElement[3]
    {
      new VertexElement(0, VertexElementFormat.Vector2, VertexElementUsage.Position, 0),
      new VertexElement(8, VertexElementFormat.Color, VertexElementUsage.Color, 0),
      new VertexElement(12, VertexElementFormat.Vector3, VertexElementUsage.TextureCoordinate, 0)
    });

    public VertexDeclaration VertexDeclaration => VertexStrip.CustomVertexInfo._vertexDeclaration;
  }
}
