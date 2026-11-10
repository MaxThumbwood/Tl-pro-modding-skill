// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.TileBatch
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

#nullable disable
namespace Terraria.Graphics;

public class TileBatch
{
  private const int MinSliceLength = 2;
  private static readonly float[] CORNER_OFFSET_X = new float[4]
  {
    0.0f,
    1f,
    1f,
    0.0f
  };
  private static readonly float[] CORNER_OFFSET_Y = new float[4]
  {
    0.0f,
    0.0f,
    1f,
    1f
  };
  private GraphicsDevice _graphicsDevice;
  private TileBatch.SpriteData[] _spriteDataQueue = new TileBatch.SpriteData[2048 /*0x0800*/];
  private Texture2D[] _spriteTextures = new Texture2D[2048 /*0x0800*/];
  private int _queuedSpriteCount;
  private bool _layeredSortingEnabled;
  private TileBatch.DataSlice[] _batchData = new TileBatch.DataSlice[2048 /*0x0800*/];
  private int _batchDataCount;
  private TileBatch.LayerBatch[] _batches = new TileBatch.LayerBatch[2048 /*0x0800*/];
  private int _batchCount;
  private uint? _nextLayerStack;
  private int _currentBatchIndex;
  private TileBatch.LayerBatchKey _currentBatchKey;
  private Dictionary<TileBatch.LayerBatchKey, int> _batchLookup = new Dictionary<TileBatch.LayerBatchKey, int>();
  private readonly TileBatch.RecentLayerCacheEntry[] _batchLookupCache = new TileBatch.RecentLayerCacheEntry[2048 /*0x0800*/];
  private Texture2D[] _passTextures = new Texture2D[512 /*0x0200*/];
  private int _passTextureCount;
  private Dictionary<Texture2D, ushort> _textureIdLookup = new Dictionary<Texture2D, ushort>();
  private SpriteBatch _spriteBatch;
  private static Vector2 _vector2Zero;
  private static Rectangle? _nullRectangle;
  private DynamicVertexBuffer _vertexBuffer;
  private DynamicIndexBuffer _indexBuffer;
  private short[] _fallbackIndexData;
  private VertexPositionColorTexture[] _vertices = new VertexPositionColorTexture[8192 /*0x2000*/];
  private int _vertexBufferPosition;
  private int _drawCalls;

  public TileBatch(GraphicsDevice graphicsDevice)
  {
    this._graphicsDevice = graphicsDevice;
    this._spriteBatch = new SpriteBatch(graphicsDevice);
    this.Allocate();
  }

  private void Allocate()
  {
    if (this._vertexBuffer == null || this._vertexBuffer.IsDisposed)
    {
      this._vertexBuffer = new DynamicVertexBuffer(this._graphicsDevice, typeof (VertexPositionColorTexture), 8192 /*0x2000*/, BufferUsage.WriteOnly);
      this._vertexBufferPosition = 0;
      this._vertexBuffer.ContentLost += (EventHandler<EventArgs>) ((_param1, _param2) => this._vertexBufferPosition = 0);
    }
    if (this._indexBuffer != null && !this._indexBuffer.IsDisposed)
      return;
    if (this._fallbackIndexData == null)
    {
      this._fallbackIndexData = new short[12288 /*0x3000*/];
      for (int index = 0; index < 2048 /*0x0800*/; ++index)
      {
        this._fallbackIndexData[index * 6] = (short) (index * 4);
        this._fallbackIndexData[index * 6 + 1] = (short) (index * 4 + 1);
        this._fallbackIndexData[index * 6 + 2] = (short) (index * 4 + 2);
        this._fallbackIndexData[index * 6 + 3] = (short) (index * 4);
        this._fallbackIndexData[index * 6 + 4] = (short) (index * 4 + 2);
        this._fallbackIndexData[index * 6 + 5] = (short) (index * 4 + 3);
      }
    }
    this._indexBuffer = new DynamicIndexBuffer(this._graphicsDevice, typeof (short), 12288 /*0x3000*/, BufferUsage.WriteOnly);
    this._indexBuffer.SetData<short>(this._fallbackIndexData);
    this._indexBuffer.ContentLost += (EventHandler<EventArgs>) ((_param1, _param2) => this._indexBuffer.SetData<short>(this._fallbackIndexData));
  }

  private void FlushRenderState()
  {
    this.Allocate();
    this._graphicsDevice.SetVertexBuffer((VertexBuffer) this._vertexBuffer);
    this._graphicsDevice.Indices = (IndexBuffer) this._indexBuffer;
    this._graphicsDevice.SamplerStates[0] = SamplerState.PointClamp;
    this._drawCalls = 0;
  }

  public void Dispose()
  {
    if (this._vertexBuffer != null)
      this._vertexBuffer.Dispose();
    if (this._indexBuffer == null)
      return;
    this._indexBuffer.Dispose();
  }

  public void Begin(RasterizerState rasterizer, Matrix transformation)
  {
    this._spriteBatch.Begin(SpriteSortMode.Deferred, (BlendState) null, (SamplerState) null, (DepthStencilState) null, rasterizer, (Effect) null, transformation);
    this._spriteBatch.End();
  }

  public void Begin()
  {
    this.Begin(RasterizerState.CullCounterClockwise, Matrix.Identity);
    if (this._queuedSpriteCount > 0)
      throw new InvalidOperationException("Sprites have already been added before calling Begin");
  }

  public int Restart() => this.End();

  public void SetLayer(uint layer, ushort stack = 0)
  {
    if (layer >= 16777216U /*0x01000000*/)
      throw new ArgumentOutOfRangeException("Max Layer Exceeded");
    if (!this._layeredSortingEnabled)
    {
      if (this._queuedSpriteCount > 0)
        throw new InvalidOperationException("Sprites have already been added before setting the first layer");
      this._layeredSortingEnabled = true;
    }
    this._nextLayerStack = new uint?(layer << 16 /*0x10*/ | (uint) stack);
  }

  public void Draw(Texture2D texture, Vector2 position, VertexColors colors)
  {
    this.InternalDraw(texture, ref new Vector4()
    {
      X = position.X,
      Y = position.Y,
      Z = 1f,
      W = 1f
    }, true, ref TileBatch._nullRectangle, ref colors, ref TileBatch._vector2Zero, SpriteEffects.None, 0.0f);
  }

  public void Draw(
    Texture2D texture,
    Vector2 position,
    Rectangle? sourceRectangle,
    VertexColors colors,
    Vector2 origin,
    float scale,
    SpriteEffects effects)
  {
    this.InternalDraw(texture, ref new Vector4()
    {
      X = position.X,
      Y = position.Y,
      Z = scale,
      W = scale
    }, true, ref sourceRectangle, ref colors, ref origin, effects, 0.0f);
  }

  public void Draw(Texture2D texture, Vector4 destination, VertexColors colors)
  {
    this.InternalDraw(texture, ref destination, false, ref TileBatch._nullRectangle, ref colors, ref TileBatch._vector2Zero, SpriteEffects.None, 0.0f);
  }

  public void Draw(Texture2D texture, Vector2 position, VertexColors colors, Vector2 scale)
  {
    this.InternalDraw(texture, ref new Vector4()
    {
      X = position.X,
      Y = position.Y,
      Z = scale.X,
      W = scale.Y
    }, true, ref TileBatch._nullRectangle, ref colors, ref TileBatch._vector2Zero, SpriteEffects.None, 0.0f);
  }

  public void Draw(
    Texture2D texture,
    Vector4 destination,
    Rectangle? sourceRectangle,
    VertexColors colors)
  {
    this.InternalDraw(texture, ref destination, false, ref sourceRectangle, ref colors, ref TileBatch._vector2Zero, SpriteEffects.None, 0.0f);
  }

  public void Draw(
    Texture2D texture,
    Vector4 destination,
    Rectangle? sourceRectangle,
    VertexColors colors,
    Vector2 origin,
    SpriteEffects effects,
    float rotation)
  {
    this.InternalDraw(texture, ref destination, false, ref sourceRectangle, ref colors, ref origin, effects, rotation);
  }

  public void Draw(
    Texture2D texture,
    Rectangle destinationRectangle,
    Rectangle? sourceRectangle,
    VertexColors colors)
  {
    this.InternalDraw(texture, ref new Vector4()
    {
      X = (float) destinationRectangle.X,
      Y = (float) destinationRectangle.Y,
      Z = (float) destinationRectangle.Width,
      W = (float) destinationRectangle.Height
    }, false, ref sourceRectangle, ref colors, ref TileBatch._vector2Zero, SpriteEffects.None, 0.0f);
  }

  private static short[] CreateIndexData()
  {
    short[] indexData = new short[12288 /*0x3000*/];
    for (int index = 0; index < 2048 /*0x0800*/; ++index)
    {
      indexData[index * 6] = (short) (index * 4);
      indexData[index * 6 + 1] = (short) (index * 4 + 1);
      indexData[index * 6 + 2] = (short) (index * 4 + 2);
      indexData[index * 6 + 3] = (short) (index * 4);
      indexData[index * 6 + 4] = (short) (index * 4 + 2);
      indexData[index * 6 + 5] = (short) (index * 4 + 3);
    }
    return indexData;
  }

  private unsafe void InternalDraw(
    Texture2D texture,
    ref Vector4 destination,
    bool scaleDestination,
    ref Rectangle? sourceRectangle,
    ref VertexColors colors,
    ref Vector2 origin,
    SpriteEffects effects,
    float rotation)
  {
    int index;
    if (this._layeredSortingEnabled)
    {
      if (this._nextLayerStack.HasValue)
      {
        uint layerStack = this._nextLayerStack.Value;
        if (texture != this._currentBatchKey.Texture || (int) layerStack != (int) this._currentBatchKey.LayerStack)
          this.SwitchBatch(texture, layerStack);
      }
      else if (texture != this._currentBatchKey.Texture)
        this.SwitchBatch(texture, this._currentBatchKey.LayerStack + 1U);
      this._nextLayerStack = new uint?();
      index = this.GetNextSpriteIndex(ref this._batches[this._currentBatchIndex]);
    }
    else
    {
      if (this._queuedSpriteCount >= this._spriteDataQueue.Length)
        Array.Resize<TileBatch.SpriteData>(ref this._spriteDataQueue, this._spriteDataQueue.Length << 1);
      if (this._queuedSpriteCount >= this._spriteTextures.Length)
        Array.Resize<Texture2D>(ref this._spriteTextures, this._spriteTextures.Length << 1);
      this._spriteTextures[this._queuedSpriteCount] = texture;
      index = this._queuedSpriteCount++;
    }
    fixed (TileBatch.SpriteData* spriteDataPtr = &this._spriteDataQueue[index])
    {
      float z = destination.Z;
      float w = destination.W;
      if (sourceRectangle.HasValue)
      {
        Rectangle rectangle = sourceRectangle.Value;
        spriteDataPtr->Source.X = (float) rectangle.X;
        spriteDataPtr->Source.Y = (float) rectangle.Y;
        spriteDataPtr->Source.Z = (float) rectangle.Width;
        spriteDataPtr->Source.W = (float) rectangle.Height;
        if (scaleDestination)
        {
          z *= (float) rectangle.Width;
          w *= (float) rectangle.Height;
        }
      }
      else
      {
        float width = (float) texture.Width;
        float height = (float) texture.Height;
        spriteDataPtr->Source.X = 0.0f;
        spriteDataPtr->Source.Y = 0.0f;
        spriteDataPtr->Source.Z = width;
        spriteDataPtr->Source.W = height;
        if (scaleDestination)
        {
          z *= width;
          w *= height;
        }
      }
      spriteDataPtr->Destination.X = destination.X;
      spriteDataPtr->Destination.Y = destination.Y;
      spriteDataPtr->Destination.Z = z;
      spriteDataPtr->Destination.W = w;
      spriteDataPtr->Origin.X = origin.X;
      spriteDataPtr->Origin.Y = origin.Y;
      spriteDataPtr->Effects = effects;
      spriteDataPtr->Colors = colors;
      spriteDataPtr->Rotation = rotation;
    }
  }

  private int GetNextSpriteIndex(ref TileBatch.LayerBatch layerBatchState)
  {
    if (layerBatchState.CurrentSliceIsFull)
    {
      int spriteBufferSlice = this.GetNewSpriteBufferSlice(layerBatchState.Length);
      this._batchData[layerBatchState.Tail].Next = spriteBufferSlice;
      layerBatchState.Tail = spriteBufferSlice;
      layerBatchState.NextSprite = this._batchData[spriteBufferSlice].Start;
    }
    ++layerBatchState.Length;
    return layerBatchState.NextSprite++;
  }

  private int GetNewSpriteBufferSlice(int length)
  {
    if (this._batchDataCount == this._batchData.Length)
      Array.Resize<TileBatch.DataSlice>(ref this._batchData, this._batchData.Length * 2);
    int spriteBufferSlice = this._batchDataCount++;
    this._batchData[spriteBufferSlice] = new TileBatch.DataSlice()
    {
      Start = this._queuedSpriteCount,
      Length = length
    };
    this._queuedSpriteCount += length;
    while (this._queuedSpriteCount > this._spriteDataQueue.Length)
      Array.Resize<TileBatch.SpriteData>(ref this._spriteDataQueue, this._spriteDataQueue.Length * 2);
    return spriteBufferSlice;
  }

  private void SwitchBatch(Texture2D texture, uint layerStack)
  {
    TileBatch.LayerBatchKey currentBatchKey = this._currentBatchKey;
    int currentBatchIndex = this._currentBatchIndex;
    this._currentBatchKey = new TileBatch.LayerBatchKey()
    {
      LayerStack = layerStack,
      Texture = texture
    };
    uint index1 = layerStack >> 14 | layerStack & (uint) ushort.MaxValue;
    if ((long) index1 < (long) this._batchLookupCache.Length && this._batchLookupCache[(int) index1].Texture == texture)
      this._currentBatchIndex = this._batchLookupCache[(int) index1].BatchIndex;
    else if (!this._batchLookup.TryGetValue(this._currentBatchKey, out this._currentBatchIndex))
      this.CreateBatch();
    uint index2 = currentBatchKey.LayerStack >> 14 | currentBatchKey.LayerStack & (uint) ushort.MaxValue;
    if ((long) index2 >= (long) this._batchLookupCache.Length)
      return;
    this._batchLookupCache[(int) index2] = new TileBatch.RecentLayerCacheEntry((Texture) currentBatchKey.Texture, currentBatchIndex);
  }

  private void CreateBatch()
  {
    Texture2D texture = this._currentBatchKey.Texture;
    ushort passTextureCount;
    if (!this._textureIdLookup.TryGetValue(texture, out passTextureCount))
    {
      this._textureIdLookup[texture] = passTextureCount = (ushort) this._passTextureCount;
      if (this._passTextureCount == this._passTextures.Length)
        Array.Resize<Texture2D>(ref this._passTextures, this._passTextures.Length * 2);
      this._passTextures[this._passTextureCount++] = texture;
    }
    if (this._batchCount == this._batches.Length)
      Array.Resize<TileBatch.LayerBatch>(ref this._batches, this._batches.Length * 2);
    int spriteBufferSlice = this.GetNewSpriteBufferSlice(2);
    this._batches[this._currentBatchIndex = this._batchCount++] = new TileBatch.LayerBatch()
    {
      LayerStack = this._currentBatchKey.LayerStack,
      Texture = passTextureCount,
      Head = spriteBufferSlice,
      Tail = spriteBufferSlice,
      NextSprite = this._batchData[spriteBufferSlice].Start
    };
    this._batchLookup[this._currentBatchKey] = this._currentBatchIndex;
  }

  public int End()
  {
    this._layeredSortingEnabled = false;
    if (this._queuedSpriteCount == 0)
      return 0;
    this.FlushRenderState();
    if (this._passTextureCount > 0)
      this.FlushLayered();
    else
      this.Flush();
    return this._drawCalls;
  }

  private void Flush()
  {
    Texture2D texture = (Texture2D) null;
    int offset = 0;
    for (int index = 0; index < this._queuedSpriteCount; ++index)
    {
      if (this._spriteTextures[index] != texture)
      {
        if (index > offset)
          this.RenderBatch(texture, this._spriteDataQueue, offset, index - offset);
        offset = index;
        texture = this._spriteTextures[index];
      }
    }
    this.RenderBatch(texture, this._spriteDataQueue, offset, this._queuedSpriteCount - offset);
    Array.Clear((Array) this._spriteTextures, 0, this._queuedSpriteCount);
    this._queuedSpriteCount = 0;
  }

  private void RenderBatch(
    Texture2D texture,
    TileBatch.SpriteData[] sprites,
    int offset,
    int count)
  {
    this._graphicsDevice.Textures[0] = (Texture) texture;
    while (count > 0)
    {
      SetDataOptions options = SetDataOptions.NoOverwrite;
      int count1 = count;
      if (count1 > 2048 /*0x0800*/ - this._vertexBufferPosition)
      {
        count1 = 2048 /*0x0800*/ - this._vertexBufferPosition;
        if (count1 < 256 /*0x0100*/)
        {
          this._vertexBufferPosition = 0;
          options = SetDataOptions.Discard;
          count1 = count;
          if (count1 > 2048 /*0x0800*/)
            count1 = 2048 /*0x0800*/;
        }
      }
      this.FillVertexBuffer(texture, sprites, offset, count1, 0);
      this._vertexBuffer.SetData<VertexPositionColorTexture>(this._vertexBufferPosition * sizeof (VertexPositionColorTexture) * 4, this._vertices, 0, count1 * 4, sizeof (VertexPositionColorTexture), options);
      this._graphicsDevice.DrawIndexedPrimitives(PrimitiveType.TriangleList, 0, this._vertexBufferPosition * 4, count1 * 4, this._vertexBufferPosition * 6, count1 * 2);
      this._vertexBufferPosition += count1;
      offset += count1;
      count -= count1;
      ++this._drawCalls;
    }
  }

  private unsafe void FillVertexBuffer(
    Texture2D texture,
    TileBatch.SpriteData[] sprites,
    int offset,
    int count,
    int vbSpriteOffset)
  {
    float num1 = 1f / (float) texture.Width;
    float num2 = 1f / (float) texture.Height;
    fixed (TileBatch.SpriteData* spriteDataPtr1 = &sprites[offset])
      fixed (VertexPositionColorTexture* positionColorTexturePtr1 = &this._vertices[vbSpriteOffset * 4])
      {
        TileBatch.SpriteData* spriteDataPtr2 = spriteDataPtr1;
        VertexPositionColorTexture* positionColorTexturePtr2 = positionColorTexturePtr1;
        for (int index1 = 0; index1 < count; ++index1)
        {
          float num3;
          float num4;
          if ((double) spriteDataPtr2->Rotation != 0.0)
          {
            num3 = (float) Math.Cos((double) spriteDataPtr2->Rotation);
            num4 = (float) Math.Sin((double) spriteDataPtr2->Rotation);
          }
          else
          {
            num3 = 1f;
            num4 = 0.0f;
          }
          float num5 = spriteDataPtr2->Origin.X / spriteDataPtr2->Source.Z;
          float num6 = spriteDataPtr2->Origin.Y / spriteDataPtr2->Source.W;
          positionColorTexturePtr2->Color = spriteDataPtr2->Colors.TopLeftColor;
          positionColorTexturePtr2[1].Color = spriteDataPtr2->Colors.TopRightColor;
          positionColorTexturePtr2[2].Color = spriteDataPtr2->Colors.BottomRightColor;
          positionColorTexturePtr2[3].Color = spriteDataPtr2->Colors.BottomLeftColor;
          for (int index2 = 0; index2 < 4; ++index2)
          {
            float num7 = TileBatch.CORNER_OFFSET_X[index2];
            float num8 = TileBatch.CORNER_OFFSET_Y[index2];
            float num9 = (num7 - num5) * spriteDataPtr2->Destination.Z;
            float num10 = (num8 - num6) * spriteDataPtr2->Destination.W;
            float num11 = (float) ((double) spriteDataPtr2->Destination.X + (double) num9 * (double) num3 - (double) num10 * (double) num4);
            float num12 = (float) ((double) spriteDataPtr2->Destination.Y + (double) num9 * (double) num4 + (double) num10 * (double) num3);
            if ((spriteDataPtr2->Effects & SpriteEffects.FlipVertically) != SpriteEffects.None)
              num8 = 1f - num8;
            if ((spriteDataPtr2->Effects & SpriteEffects.FlipHorizontally) != SpriteEffects.None)
              num7 = 1f - num7;
            positionColorTexturePtr2->Position.X = num11;
            positionColorTexturePtr2->Position.Y = num12;
            positionColorTexturePtr2->Position.Z = 0.0f;
            positionColorTexturePtr2->TextureCoordinate.X = (spriteDataPtr2->Source.X + num7 * spriteDataPtr2->Source.Z) * num1;
            positionColorTexturePtr2->TextureCoordinate.Y = (spriteDataPtr2->Source.Y + num8 * spriteDataPtr2->Source.W) * num2;
            ++positionColorTexturePtr2;
          }
          ++spriteDataPtr2;
        }
      }
  }

  private void FlushLayered()
  {
    Array.Sort<TileBatch.LayerBatch>(this._batches, 0, this._batchCount);
    int vbCount = 0;
    this._vertexBufferPosition = 0;
    for (int index1 = 0; index1 < this._batchCount; ++index1)
    {
      TileBatch.LayerBatch batch1 = this._batches[index1];
      this._graphicsDevice.Textures[0] = (Texture) this._passTextures[(int) batch1.Texture];
      int length = batch1.Length;
      int index2 = index1;
      int batchOffset = 0;
      TileBatch.DataSlice currentSlice = new TileBatch.DataSlice();
      do
      {
        if (this._vertexBufferPosition == vbCount)
        {
          vbCount = 0;
          this._vertexBufferPosition = 0;
          for (; vbCount < length && this.FillVertexBuffer(this._batches[index2], ref currentSlice, ref batchOffset, ref vbCount); batchOffset = 0)
            ++index2;
          for (; vbCount < 2048 /*0x0800*/ && index2 < this._batchCount; ++index2)
          {
            TileBatch.LayerBatch batch2 = this._batches[index2];
            if (vbCount + batch2.Length <= 2048 /*0x0800*/)
              this.FillVertexBuffer(batch2, ref vbCount);
            else
              break;
          }
          this._vertexBuffer.SetData<VertexPositionColorTexture>(this._vertices, 0, vbCount * 4, SetDataOptions.Discard);
        }
        int num = Math.Min(length, vbCount - this._vertexBufferPosition);
        this._graphicsDevice.DrawIndexedPrimitives(PrimitiveType.TriangleList, this._vertexBufferPosition * 4, 0, num * 4, 0, num * 2);
        this._vertexBufferPosition += num;
        length -= num;
        ++this._drawCalls;
      }
      while (length > 0);
    }
    this._queuedSpriteCount = 0;
    this._batchDataCount = 0;
    this._batchCount = 0;
    this._batchLookup.Clear();
    Array.Clear((Array) this._batchLookupCache, 0, this._batchLookupCache.Length);
    this._passTextureCount = 0;
    this._textureIdLookup.Clear();
    this._currentBatchKey = new TileBatch.LayerBatchKey();
  }

  private void FillVertexBuffer(TileBatch.LayerBatch batch, ref int vbCount)
  {
    TileBatch.DataSlice currentSlice = new TileBatch.DataSlice();
    int batchOffset = 0;
    this.FillVertexBuffer(batch, ref currentSlice, ref batchOffset, ref vbCount);
  }

  private bool FillVertexBuffer(
    TileBatch.LayerBatch batch,
    ref TileBatch.DataSlice currentSlice,
    ref int batchOffset,
    ref int vbCount)
  {
    if (batchOffset == 0)
      currentSlice = this._batchData[batch.Head];
    Texture2D passTexture = this._passTextures[(int) batch.Texture];
    while (batchOffset < batch.Length)
    {
      if (currentSlice.Length == 0)
        currentSlice = this._batchData[currentSlice.Next];
      int count = Math.Min(Math.Min(batch.Length - batchOffset, currentSlice.Length), 2048 /*0x0800*/ - vbCount);
      if (count == 0)
        return false;
      this.FillVertexBuffer(passTexture, this._spriteDataQueue, currentSlice.Start, count, vbCount);
      vbCount += count;
      batchOffset += count;
      currentSlice.Start += count;
      currentSlice.Length -= count;
    }
    return true;
  }

  private struct SpriteData
  {
    public Vector4 Source;
    public Vector4 Destination;
    public Vector2 Origin;
    public SpriteEffects Effects;
    public VertexColors Colors;
    public float Rotation;
  }

  private struct DataSlice
  {
    public int Start;
    public int Length;
    public int Next;
  }

  private struct LayerBatch : IComparable<TileBatch.LayerBatch>
  {
    public uint LayerStack;
    public ushort Texture;
    public int Head;
    public int Tail;
    public int Length;
    public int NextSprite;

    public ulong SortKey => (ulong) this.LayerStack << 16 /*0x10*/ | (ulong) this.Texture;

    public bool CurrentSliceIsFull => this.Length >= 2 && (this.Length & this.Length - 1) == 0;

    public int CompareTo(TileBatch.LayerBatch other) => this.SortKey.CompareTo(other.SortKey);
  }

  private struct LayerBatchKey : IEquatable<TileBatch.LayerBatchKey>
  {
    public uint LayerStack;
    public Texture2D Texture;

    public bool Equals(TileBatch.LayerBatchKey other)
    {
      return (int) this.LayerStack == (int) other.LayerStack;
    }

    public override int GetHashCode() => (int) this.LayerStack ^ this.Texture.GetHashCode();
  }

  private struct RecentLayerCacheEntry(Texture texture, int batchIndex)
  {
    public readonly Texture Texture = texture;
    public readonly int BatchIndex = batchIndex;
  }
}
