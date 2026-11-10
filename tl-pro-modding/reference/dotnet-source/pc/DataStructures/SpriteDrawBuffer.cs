// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.SpriteDrawBuffer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria.Graphics;

#nullable disable
namespace Terraria.DataStructures;

public class SpriteDrawBuffer
{
  private readonly GraphicsDevice graphicsDevice;
  private readonly SpriteBatch spriteBatch;
  private readonly int bufferSize;
  private DynamicVertexBuffer vertexBuffer;
  private IndexBuffer indexBuffer;
  private int vertexCount;
  private VertexPositionColorTexture[] vertices;
  private Texture[] textures;
  private int uploadedSpriteIndex = -1;
  private VertexBufferBinding[] preBindVertexBuffers;
  private IndexBuffer preBindIndexBuffer;

  public SpriteDrawBuffer(GraphicsDevice graphicsDevice, int bufferSize = 2048 /*0x0800*/)
  {
    this.graphicsDevice = graphicsDevice;
    this.bufferSize = bufferSize;
    this.ResizeArrays(bufferSize);
    this.spriteBatch = new SpriteBatch(graphicsDevice);
  }

  public void ResizeArrays(int count)
  {
    Array.Resize<VertexPositionColorTexture>(ref this.vertices, count * 4);
    Array.Resize<Texture>(ref this.textures, count);
  }

  public void ApplyDefaultSpriteEffect(RasterizerState rasterizer, Matrix transformation)
  {
    this.spriteBatch.Begin(SpriteSortMode.Deferred, (BlendState) null, (SamplerState) null, (DepthStencilState) null, rasterizer, (Effect) null, transformation);
    this.spriteBatch.End();
  }

  public void ApplyDefaultSpriteEffect()
  {
    this.spriteBatch.Begin();
    this.spriteBatch.End();
  }

  private void CheckBuffers()
  {
    if (this.vertexBuffer == null || this.vertexBuffer.IsDisposed)
    {
      if (this.vertexBuffer != null)
        this.vertexBuffer.Dispose();
      this.vertexBuffer = new DynamicVertexBuffer(this.graphicsDevice, typeof (VertexPositionColorTexture), this.bufferSize * 4, BufferUsage.WriteOnly);
    }
    if (this.indexBuffer != null && !this.indexBuffer.IsDisposed)
      return;
    if (this.indexBuffer != null)
      this.indexBuffer.Dispose();
    this.indexBuffer = new IndexBuffer(this.graphicsDevice, typeof (ushort), this.bufferSize * 6, BufferUsage.WriteOnly);
    this.indexBuffer.SetData<ushort>(SpriteDrawBuffer.GenIndexBuffer(this.bufferSize));
  }

  private static ushort[] GenIndexBuffer(int maxSprites)
  {
    ushort[] numArray1 = new ushort[maxSprites * 6];
    int num1 = 0;
    ushort num2 = 0;
    while (num1 < maxSprites)
    {
      ushort[] numArray2 = numArray1;
      int index1 = num1;
      int num3 = index1 + 1;
      int num4 = (int) num2;
      numArray2[index1] = (ushort) num4;
      ushort[] numArray3 = numArray1;
      int index2 = num3;
      int num5 = index2 + 1;
      int num6 = (int) (ushort) ((uint) num2 + 1U);
      numArray3[index2] = (ushort) num6;
      ushort[] numArray4 = numArray1;
      int index3 = num5;
      int num7 = index3 + 1;
      int num8 = (int) (ushort) ((uint) num2 + 2U);
      numArray4[index3] = (ushort) num8;
      ushort[] numArray5 = numArray1;
      int index4 = num7;
      int num9 = index4 + 1;
      int num10 = (int) (ushort) ((uint) num2 + 3U);
      numArray5[index4] = (ushort) num10;
      ushort[] numArray6 = numArray1;
      int index5 = num9;
      int num11 = index5 + 1;
      int num12 = (int) (ushort) ((uint) num2 + 2U);
      numArray6[index5] = (ushort) num12;
      ushort[] numArray7 = numArray1;
      int index6 = num11;
      num1 = index6 + 1;
      int num13 = (int) (ushort) ((uint) num2 + 1U);
      numArray7[index6] = (ushort) num13;
      num2 += (ushort) 4;
    }
    return numArray1;
  }

  private void Bind()
  {
    if (this.preBindVertexBuffers != null)
      return;
    this.preBindVertexBuffers = this.graphicsDevice.GetVertexBuffers();
    this.preBindIndexBuffer = this.graphicsDevice.Indices;
    this.graphicsDevice.SetVertexBuffer((VertexBuffer) this.vertexBuffer);
    this.graphicsDevice.Indices = this.indexBuffer;
  }

  public void Unbind()
  {
    if (this.preBindVertexBuffers == null)
      return;
    this.graphicsDevice.SetVertexBuffers(this.preBindVertexBuffers);
    this.graphicsDevice.Indices = this.preBindIndexBuffer;
    this.preBindVertexBuffers = (VertexBufferBinding[]) null;
    this.preBindIndexBuffer = (IndexBuffer) null;
  }

  public int DrawRange(int index, int count)
  {
    this.vertexCount = 0;
    this.CheckBuffers();
    this.Bind();
    this.graphicsDevice.Textures[0] = this.textures[index];
    int num1 = 0;
    while (count > 0)
    {
      if (this.uploadedSpriteIndex < 0 || index < this.uploadedSpriteIndex || index + count > this.uploadedSpriteIndex + this.bufferSize)
      {
        this.vertexBuffer.SetData<VertexPositionColorTexture>(this.vertices, index * 4, Math.Min(this.vertices.Length - index * 4, this.bufferSize * 4), SetDataOptions.Discard);
        this.uploadedSpriteIndex = index;
      }
      int num2 = Math.Min(count, this.bufferSize);
      this.graphicsDevice.DrawIndexedPrimitives(PrimitiveType.TriangleList, (index - this.uploadedSpriteIndex) * 4, 0, num2 * 4, 0, num2 * 2);
      count -= num2;
      index += num2;
      ++num1;
    }
    return num1;
  }

  public void DrawSingle(int index) => this.DrawRange(index, 1);

  public int DrawAll()
  {
    if (this.vertexCount == 0)
      return 0;
    int num1 = this.vertexCount / 4;
    Texture texture1 = this.textures[0];
    int index1 = 0;
    int num2 = 0;
    for (int index2 = 1; index2 < num1; ++index2)
    {
      Texture texture2 = this.textures[index2];
      if (texture2 != texture1)
      {
        num2 += this.DrawRange(index1, index2 - index1);
        index1 = index2;
        texture1 = texture2;
      }
    }
    int num3 = num2 + this.DrawRange(index1, num1 - index1);
    this.Unbind();
    return num3;
  }

  public void Draw(Texture2D texture, Vector2 position, VertexColors colors)
  {
    this.Draw(texture, position, new Rectangle?(), colors, 0.0f, Vector2.Zero, 1f, SpriteEffects.None);
  }

  public void Draw(Texture2D texture, Rectangle destination, VertexColors colors)
  {
    this.Draw(texture, destination, new Rectangle?(), colors);
  }

  public void Draw(
    Texture2D texture,
    Rectangle destination,
    Rectangle? sourceRectangle,
    VertexColors colors)
  {
    this.Draw(texture, destination, sourceRectangle, colors, 0.0f, Vector2.Zero, SpriteEffects.None);
  }

  public void Draw(
    Texture2D texture,
    Vector2 position,
    Rectangle? sourceRectangle,
    VertexColors color,
    float rotation,
    Vector2 origin,
    float scale,
    SpriteEffects effects)
  {
    this.Draw(texture, position, sourceRectangle, color, rotation, origin, new Vector2(scale, scale), effects);
  }

  public void Draw(
    Texture2D texture,
    Vector2 position,
    Rectangle? sourceRectangle,
    VertexColors colors,
    float rotation,
    Vector2 origin,
    Vector2 scale,
    SpriteEffects effects)
  {
    float z;
    float w;
    if (sourceRectangle.HasValue)
    {
      z = (float) sourceRectangle.Value.Width * scale.X;
      w = (float) sourceRectangle.Value.Height * scale.Y;
    }
    else
    {
      z = (float) texture.Width * scale.X;
      w = (float) texture.Height * scale.Y;
    }
    this.Draw(texture, new Vector4(position.X, position.Y, z, w), sourceRectangle, colors, rotation, origin, effects);
  }

  public void Draw(
    Texture2D texture,
    Rectangle destination,
    Rectangle? sourceRectangle,
    VertexColors colors,
    float rotation,
    Vector2 origin,
    SpriteEffects effects)
  {
    this.Draw(texture, new Vector4((float) destination.X, (float) destination.Y, (float) destination.Width, (float) destination.Height), sourceRectangle, colors, rotation, origin, effects);
  }

  public void Draw(
    Texture2D texture,
    Vector4 destination,
    VertexColors colors,
    float rotation = 0.0f,
    Vector2 origin = default (Vector2),
    SpriteEffects effects = SpriteEffects.None)
  {
    this.Draw(texture, destination, new Rectangle?(), colors, rotation, origin, effects);
  }

  public void Draw(
    Texture2D texture,
    Vector4 destinationRectangle,
    Rectangle? sourceRectangle,
    VertexColors colors,
    float rotation = 0.0f,
    Vector2 origin = default (Vector2),
    SpriteEffects effect = SpriteEffects.None,
    float depth = 0.0f)
  {
    Vector4 sourceRectangle1;
    if (sourceRectangle.HasValue)
    {
      sourceRectangle1.X = (float) sourceRectangle.Value.X;
      sourceRectangle1.Y = (float) sourceRectangle.Value.Y;
      sourceRectangle1.Z = (float) sourceRectangle.Value.Width;
      sourceRectangle1.W = (float) sourceRectangle.Value.Height;
    }
    else
    {
      sourceRectangle1.X = 0.0f;
      sourceRectangle1.Y = 0.0f;
      sourceRectangle1.Z = (float) texture.Width;
      sourceRectangle1.W = (float) texture.Height;
    }
    Vector2 texCoordTL;
    texCoordTL.X = sourceRectangle1.X / (float) texture.Width;
    texCoordTL.Y = sourceRectangle1.Y / (float) texture.Height;
    Vector2 texCoordBR;
    texCoordBR.X = (sourceRectangle1.X + sourceRectangle1.Z) / (float) texture.Width;
    texCoordBR.Y = (sourceRectangle1.Y + sourceRectangle1.W) / (float) texture.Height;
    if ((effect & SpriteEffects.FlipVertically) != SpriteEffects.None)
    {
      float y = texCoordBR.Y;
      texCoordBR.Y = texCoordTL.Y;
      texCoordTL.Y = y;
    }
    if ((effect & SpriteEffects.FlipHorizontally) != SpriteEffects.None)
    {
      float x = texCoordBR.X;
      texCoordBR.X = texCoordTL.X;
      texCoordTL.X = x;
    }
    this.QueueSprite(destinationRectangle, -origin, colors, sourceRectangle1, texCoordTL, texCoordBR, texture, depth, rotation);
  }

  private void QueueSprite(
    Vector4 destinationRect,
    Vector2 origin,
    VertexColors colors,
    Vector4 sourceRectangle,
    Vector2 texCoordTL,
    Vector2 texCoordBR,
    Texture2D texture,
    float depth,
    float rotation)
  {
    this.uploadedSpriteIndex = -1;
    float num1 = origin.X / sourceRectangle.Z;
    double num2 = (double) origin.Y / (double) sourceRectangle.W;
    float x = destinationRect.X;
    float y = destinationRect.Y;
    float z = destinationRect.Z;
    float w = destinationRect.W;
    float num3 = num1 * z;
    double num4 = (double) w;
    float num5 = (float) (num2 * num4);
    float num6;
    float num7;
    if ((double) rotation != 0.0)
    {
      num6 = (float) Math.Cos((double) rotation);
      num7 = (float) Math.Sin((double) rotation);
    }
    else
    {
      num6 = 1f;
      num7 = 0.0f;
    }
    int index = this.vertexCount / 4;
    if (index >= this.textures.Length)
      this.ResizeArrays(this.textures.Length * 2);
    this.textures[index] = (Texture) texture;
    this.PushVertex(new Vector3((float) ((double) x + (double) num3 * (double) num6 - (double) num5 * (double) num7), (float) ((double) y + (double) num3 * (double) num7 + (double) num5 * (double) num6), depth), colors.TopLeftColor, texCoordTL);
    this.PushVertex(new Vector3((float) ((double) x + ((double) num3 + (double) z) * (double) num6 - (double) num5 * (double) num7), (float) ((double) y + ((double) num3 + (double) z) * (double) num7 + (double) num5 * (double) num6), depth), colors.TopRightColor, new Vector2(texCoordBR.X, texCoordTL.Y));
    this.PushVertex(new Vector3((float) ((double) x + (double) num3 * (double) num6 - ((double) num5 + (double) w) * (double) num7), (float) ((double) y + (double) num3 * (double) num7 + ((double) num5 + (double) w) * (double) num6), depth), colors.BottomLeftColor, new Vector2(texCoordTL.X, texCoordBR.Y));
    this.PushVertex(new Vector3((float) ((double) x + ((double) num3 + (double) z) * (double) num6 - ((double) num5 + (double) w) * (double) num7), (float) ((double) y + ((double) num3 + (double) z) * (double) num7 + ((double) num5 + (double) w) * (double) num6), depth), colors.BottomRightColor, texCoordBR);
  }

  private void PushVertex(Vector3 pos, Color color, Vector2 texCoord)
  {
    SpriteDrawBuffer.SetVertex(ref this.vertices[this.vertexCount++], pos, color, texCoord);
  }

  private static void SetVertex(
    ref VertexPositionColorTexture vertex,
    Vector3 pos,
    Color color,
    Vector2 texCoord)
  {
    vertex.Position = pos;
    vertex.Color = color;
    vertex.TextureCoordinate = texCoord;
  }
}
