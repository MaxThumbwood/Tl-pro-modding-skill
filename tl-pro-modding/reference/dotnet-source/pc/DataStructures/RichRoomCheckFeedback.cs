// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.RichRoomCheckFeedback
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using Terraria.GameContent;
using Terraria.Graphics.Renderers;
using Terraria.ID;
using Terraria.ObjectData;

#nullable disable
namespace Terraria.DataStructures;

public class RichRoomCheckFeedback : 
  IRoomCheckFeedback,
  IRoomCheckFeedback_Spread,
  IRoomCheckFeedback_Scoring
{
  public static RichRoomCheckFeedback Instance = new RichRoomCheckFeedback();
  private static ParticlePool<RoomCheckParticle> _particlePool = new ParticlePool<RoomCheckParticle>(100, new ParticlePool<RoomCheckParticle>.ParticleInstantiator(RichRoomCheckFeedback.GetNewParticle));
  private RichRoomCheckFeedback.ParticlePreparation[] _space = new RichRoomCheckFeedback.ParticlePreparation[128 /*0x80*/];
  private int _spaceCount;
  private int _highestIteration;
  private RichRoomCheckFeedback.ScorePreparation[] _score = new RichRoomCheckFeedback.ScorePreparation[128 /*0x80*/];
  private int _scoreCount;
  private RichRoomCheckFeedback.ScorePreparation _bestScore;
  private int _originX;
  private int _originY;

  private static RoomCheckParticle GetNewParticle() => new RoomCheckParticle();

  private void Add(int x, int y, int iteration, RichRoomCheckFeedback.Reason type)
  {
    if (this._spaceCount >= this._space.Length)
      Array.Resize<RichRoomCheckFeedback.ParticlePreparation>(ref this._space, this._space.Length * 2);
    if (this._highestIteration < iteration)
      this._highestIteration = iteration;
    this._space[this._spaceCount++] = new RichRoomCheckFeedback.ParticlePreparation()
    {
      type = type,
      x = x,
      y = y,
      iteration = iteration
    };
  }

  public bool StopOnFail => false;

  public bool DisplayText => false;

  public void BeginSpread(int x, int y)
  {
    this._spaceCount = 0;
    this._highestIteration = 0;
    this._originX = x;
    this._originY = y;
  }

  public void StartedInASolidTile(int x, int y)
  {
    this.Add(x, y, 0, RichRoomCheckFeedback.Reason.BlockedWall);
  }

  public void TooCloseToWorldEdge(int x, int y, int iteration)
  {
    this.Add(x, y, iteration, RichRoomCheckFeedback.Reason.OpenAir);
  }

  public void AnyBlockScannedHere(int x, int y, int iteration)
  {
    this.Add(x, y, iteration, RichRoomCheckFeedback.Reason.Good);
  }

  public void RoomTooBig(int x, int y, int iteration)
  {
    this.Add(x, y, iteration, RichRoomCheckFeedback.Reason.OpenAir);
  }

  public void BlockingWall(int x, int y, int iteration)
  {
    this.Add(x, y, iteration, RichRoomCheckFeedback.Reason.BlockedWall);
  }

  public void BlockingOpenGate(int x, int y, int iteration)
  {
    this.Add(x, y, iteration, RichRoomCheckFeedback.Reason.BlockedWall);
  }

  public void Stinkbug(int x, int y, int iteration)
  {
    this.Add(x, y, iteration, RichRoomCheckFeedback.Reason.Hazard);
  }

  public void EchoStinkbug(int x, int y, int iteration)
  {
    this.Add(x, y, iteration, RichRoomCheckFeedback.Reason.Hazard);
  }

  public void MissingAWall(int x, int y, int iteration)
  {
    this.Add(x, y, iteration, RichRoomCheckFeedback.Reason.OpenAir);
  }

  public void UnsafeWall(int x, int y, int iteration)
  {
    this.Add(x, y, iteration, RichRoomCheckFeedback.Reason.UnsafeWall);
  }

  public void EndSpread()
  {
    Vector2 origin = new Vector2((float) this._originX, (float) this._originY);
    for (int index1 = 0; index1 < this._spaceCount; ++index1)
    {
      RichRoomCheckFeedback.ParticlePreparation particlePreparation1 = this._space[index1];
      for (int index2 = 0; index2 < this._spaceCount; ++index2)
      {
        RichRoomCheckFeedback.ParticlePreparation particlePreparation2 = this._space[index2];
        if (particlePreparation1.x == particlePreparation2.x && particlePreparation1.y == particlePreparation2.y && particlePreparation1.type == RichRoomCheckFeedback.Reason.Good && particlePreparation2.type != RichRoomCheckFeedback.Reason.Good)
          particlePreparation1.consumed = true;
      }
      this._space[index1] = particlePreparation1;
    }
    float fromMax = (float) (3.0 * (double) this.GetHighestDistanceFromOrigin(ref origin) + 60.0);
    for (int index = 0; index < this._spaceCount; ++index)
    {
      RichRoomCheckFeedback.ParticlePreparation particlePreparation = this._space[index];
      if (!particlePreparation.consumed)
      {
        ushort type = Main.tile[particlePreparation.x, particlePreparation.y].type;
        bool flag = TileID.Sets.RoomNeeds.CountsAsTable[(int) type] || TileID.Sets.RoomNeeds.CountsAsChair[(int) type] || TileID.Sets.RoomNeeds.CountsAsTorch[(int) type] || TileID.Sets.RoomNeeds.CountsAsDoor[(int) type];
        Asset<Texture2D> textureAsset = TextureAssets.Extra[293];
        Color color = Color.Cyan * 0.7f;
        color.A /= (byte) 2;
        Vector2 vector2 = new Vector2((float) particlePreparation.x, (float) particlePreparation.y);
        float num1 = 1f;
        switch (particlePreparation.type)
        {
          case RichRoomCheckFeedback.Reason.BlockedWall:
            Asset<Texture2D> asset = TextureAssets.Extra[292];
            color = new Color(80 /*0x50*/, (int) byte.MaxValue, (int) byte.MaxValue) * 0.7f;
            color.A /= (byte) 2;
            continue;
          case RichRoomCheckFeedback.Reason.UnsafeWall:
            textureAsset = TextureAssets.Extra[298];
            color = new Color((int) byte.MaxValue, 40, 40, (int) byte.MaxValue);
            break;
          case RichRoomCheckFeedback.Reason.OpenAir:
          case RichRoomCheckFeedback.Reason.Hazard:
            textureAsset = TextureAssets.Extra[292];
            color = new Color((int) byte.MaxValue, 40, 40, (int) byte.MaxValue);
            break;
          default:
            num1 = 1.5f;
            if (flag)
              continue;
            break;
        }
        RoomCheckParticle roomCheckParticle = RichRoomCheckFeedback._particlePool.RequestParticle();
        roomCheckParticle.SetBasicInfo(textureAsset, new Rectangle?(), Vector2.Zero, new Vector2((float) (particlePreparation.x * 16 /*0x10*/ + 8), (float) (particlePreparation.y * 16 /*0x10*/ + 8)));
        roomCheckParticle.Delay = (int) (3.0 * (double) Vector2.Distance(origin, vector2));
        float num2 = fromMax - (float) roomCheckParticle.Delay;
        roomCheckParticle.SetTypeInfo(num2 * num1);
        roomCheckParticle.FadeInNormalizedTime = Utils.Remap(fromMax - 24f, (float) roomCheckParticle.Delay, fromMax, 0.0f, 1f);
        roomCheckParticle.FadeOutNormalizedTime = Utils.Remap(fromMax - 6f, (float) roomCheckParticle.Delay, fromMax, 0.0f, 1f);
        roomCheckParticle.ColorTint = color;
        roomCheckParticle.Scale = Vector2.One;
        Main.ParticleSystem_World_OverPlayers.Add((IParticle) roomCheckParticle);
      }
    }
    for (int index3 = 0; index3 < this._spaceCount; ++index3)
    {
      RichRoomCheckFeedback.ParticlePreparation particlePreparation3 = this._space[index3];
      if (!particlePreparation3.consumed)
      {
        ushort type = Main.tile[particlePreparation3.x, particlePreparation3.y].type;
        if ((TileID.Sets.RoomNeeds.CountsAsTable[(int) type] || TileID.Sets.RoomNeeds.CountsAsChair[(int) type] || TileID.Sets.RoomNeeds.CountsAsTorch[(int) type] ? 1 : (TileID.Sets.RoomNeeds.CountsAsDoor[(int) type] ? 1 : 0)) != 0)
        {
          Rectangle bounds;
          TileObjectData.TryGetTileBounds(particlePreparation3.x, particlePreparation3.y, out bounds);
          for (int index4 = 0; index4 < this._spaceCount; ++index4)
          {
            if (index4 != index3)
            {
              RichRoomCheckFeedback.ParticlePreparation particlePreparation4 = this._space[index4];
              if (particlePreparation4.x >= bounds.Left && particlePreparation4.x < bounds.Right && particlePreparation4.y >= bounds.Top && particlePreparation4.y < bounds.Bottom)
                this._space[index4].consumed = true;
            }
          }
        }
      }
    }
    bool flag1 = false;
    bool flag2 = false;
    bool flag3 = false;
    bool flag4 = false;
    for (int index = 0; index < this._spaceCount; ++index)
    {
      RichRoomCheckFeedback.ParticlePreparation particlePreparation = this._space[index];
      if (!particlePreparation.consumed)
      {
        ushort type = Main.tile[particlePreparation.x, particlePreparation.y].type;
        bool flag5 = TileID.Sets.RoomNeeds.CountsAsTable[(int) type];
        bool flag6 = TileID.Sets.RoomNeeds.CountsAsChair[(int) type];
        bool flag7 = TileID.Sets.RoomNeeds.CountsAsTorch[(int) type];
        bool flag8 = TileID.Sets.RoomNeeds.CountsAsDoor[(int) type];
        if (flag5 | flag6 | flag8 | flag7)
        {
          Asset<Texture2D> asset = TextureAssets.Extra[293];
          if (flag5)
          {
            if (!flag2)
            {
              flag2 = true;
              asset = TextureAssets.Extra[297];
            }
            else
              continue;
          }
          if (flag6)
          {
            if (!flag1)
            {
              flag1 = true;
              asset = TextureAssets.Extra[295];
            }
            else
              continue;
          }
          if (flag8)
          {
            if (!flag4)
            {
              flag4 = true;
              asset = TextureAssets.Extra[296];
            }
            else
              continue;
          }
          if (flag7)
          {
            if (!flag3)
            {
              flag3 = true;
              asset = TextureAssets.Extra[294];
            }
            else
              continue;
          }
          Rectangle bounds;
          TileObjectData.TryGetTileBounds(particlePreparation.x, particlePreparation.y, out bounds);
          (Color.LimeGreen * 0.8f).A /= (byte) 2;
          Vector2 vector2_1 = new Vector2((float) particlePreparation.x, (float) particlePreparation.y);
          RoomCheckParticle roomCheckParticle = RichRoomCheckFeedback._particlePool.RequestParticle();
          Vector2 vector2_2 = new Vector2((float) (bounds.Left + bounds.Right) / 2f, MathHelper.Min((float) ((double) bounds.Top / 2.0 + (double) bounds.Bottom / 2.0), (float) (bounds.Top + 1)));
          roomCheckParticle.SetBasicInfo(asset, new Rectangle?(), Vector2.Zero, vector2_2 * 16f + new Vector2(0.0f, (float) (-asset.Height() / 2)));
          roomCheckParticle.Delay = (int) (3.0 * (double) Vector2.Distance(origin, vector2_1));
          float timeToLive = fromMax - (float) roomCheckParticle.Delay;
          roomCheckParticle.SetTypeInfo(timeToLive);
          roomCheckParticle.FadeInNormalizedTime = Utils.Remap(fromMax - 24f, (float) roomCheckParticle.Delay, fromMax, 0.0f, 1f);
          roomCheckParticle.FadeOutNormalizedTime = Utils.Remap(fromMax - 6f, (float) roomCheckParticle.Delay, fromMax, 0.0f, 1f);
          roomCheckParticle.Scale = Vector2.One;
          int num = 32 /*0x20*/;
          roomCheckParticle.LocalPosition.Y -= (float) num;
          roomCheckParticle.Velocity = new Vector2(0.0f, (float) num * 2.5f) / timeToLive;
          roomCheckParticle.AccelerationPerFrame = -roomCheckParticle.Velocity * 1.25f / timeToLive;
          Main.ParticleSystem_World_OverPlayers.Add((IParticle) roomCheckParticle);
        }
      }
    }
  }

  private float GetHighestDistanceFromOrigin(ref Vector2 origin)
  {
    float distanceFromOrigin = 0.0f;
    for (int index = 0; index < this._spaceCount; ++index)
    {
      RichRoomCheckFeedback.ParticlePreparation particlePreparation = this._space[index];
      Vector2 vector2 = new Vector2((float) particlePreparation.x, (float) particlePreparation.y);
      float num = Vector2.Distance(origin, vector2);
      if ((double) distanceFromOrigin < (double) num)
        distanceFromOrigin = num;
    }
    return distanceFromOrigin;
  }

  public void BeginScoring()
  {
    this._bestScore = new RichRoomCheckFeedback.ScorePreparation();
    this._scoreCount = 0;
  }

  public void ReportScore(int x, int y, int score)
  {
    if (this._scoreCount >= this._score.Length)
      Array.Resize<RichRoomCheckFeedback.ScorePreparation>(ref this._score, this._score.Length * 2);
    this._score[this._scoreCount++] = new RichRoomCheckFeedback.ScorePreparation()
    {
      x = x,
      y = y,
      score = score
    };
  }

  public void SetAsHighScore(int x, int y, int score)
  {
    this._bestScore = new RichRoomCheckFeedback.ScorePreparation()
    {
      x = x,
      y = y,
      score = score
    };
  }

  public void EndScoring()
  {
    Vector2 vector2_1 = new Vector2((float) this._originX, (float) this._originY);
    float num1 = 0.0f;
    for (int index = 0; index < this._spaceCount; ++index)
    {
      RichRoomCheckFeedback.ParticlePreparation particlePreparation = this._space[index];
      Vector2 vector2_2 = new Vector2((float) particlePreparation.x, (float) particlePreparation.y);
      float num2 = Vector2.Distance(vector2_1, vector2_2);
      if ((double) num1 < (double) num2)
        num1 = num2;
    }
    float fromMax = (float) (3.0 * (double) num1 + 90.0);
    int score = this._bestScore.score;
    if (score == 0)
      return;
    for (int index = 0; index < this._scoreCount; ++index)
    {
      RichRoomCheckFeedback.ScorePreparation scorePreparation = this._score[index];
      if (scorePreparation.score != 0 && (scorePreparation.x != this._bestScore.x || scorePreparation.y != this._bestScore.y))
      {
        Asset<Texture2D> textureAsset = TextureAssets.Extra[293];
        RoomCheckParticle roomCheckParticle = RichRoomCheckFeedback._particlePool.RequestParticle();
        roomCheckParticle.SetBasicInfo(textureAsset, new Rectangle?(), Vector2.Zero, new Vector2((float) (scorePreparation.x * 16 /*0x10*/ + 8), (float) (scorePreparation.y * 16 /*0x10*/ + 8 - 16 /*0x10*/)));
        Vector2 vector2_3 = new Vector2((float) scorePreparation.x, (float) scorePreparation.y);
        roomCheckParticle.Delay = (int) (3.0 * (double) Vector2.Distance(vector2_1, vector2_3));
        float timeToLive = fromMax - (float) roomCheckParticle.Delay;
        roomCheckParticle.SetTypeInfo(timeToLive);
        roomCheckParticle.FadeInNormalizedTime = Utils.Remap(fromMax - 24f, (float) roomCheckParticle.Delay, fromMax, 0.0f, 1f);
        roomCheckParticle.FadeOutNormalizedTime = Utils.Remap(fromMax - 6f, (float) roomCheckParticle.Delay, fromMax, 0.0f, 1f);
        if (scorePreparation.score > 0)
          roomCheckParticle.ColorTint = Color.LimeGreen * (float) (0.5 + 0.5 * (double) scorePreparation.score / (double) score);
        else
          roomCheckParticle.ColorTint = Color.Red * ((float) scorePreparation.score / (float) -score);
        roomCheckParticle.Scale = Vector2.One * 2f;
        Main.ParticleSystem_World_OverPlayers.Add((IParticle) roomCheckParticle);
      }
    }
    for (int index = 0; index < 1; ++index)
    {
      RichRoomCheckFeedback.ScorePreparation bestScore = this._bestScore;
      if (bestScore.score != 0)
      {
        Asset<Texture2D> textureAsset = TextureAssets.Extra[293];
        RoomCheckParticle roomCheckParticle = RichRoomCheckFeedback._particlePool.RequestParticle();
        roomCheckParticle.SetBasicInfo(textureAsset, new Rectangle?(), Vector2.Zero, new Vector2((float) (bestScore.x * 16 /*0x10*/ + 8), (float) (bestScore.y * 16 /*0x10*/ + 8 - 16 /*0x10*/)));
        Vector2 vector2_4 = new Vector2((float) bestScore.x, (float) bestScore.y);
        roomCheckParticle.Delay = (int) (3.0 * (double) Vector2.Distance(vector2_1, vector2_4));
        float timeToLive = fromMax - (float) roomCheckParticle.Delay;
        roomCheckParticle.SetTypeInfo(timeToLive);
        roomCheckParticle.FadeInNormalizedTime = Utils.Remap(fromMax - 24f, (float) roomCheckParticle.Delay, fromMax, 0.0f, 1f);
        roomCheckParticle.FadeOutNormalizedTime = Utils.Remap(fromMax - 6f, (float) roomCheckParticle.Delay, fromMax, 0.0f, 1f);
        roomCheckParticle.ColorTint = Main.OurFavoriteColor;
        roomCheckParticle.Scale = Vector2.One * 3f;
        Main.ParticleSystem_World_OverPlayers.Add((IParticle) roomCheckParticle);
      }
    }
  }

  private enum Reason
  {
    BlockedWall,
    UnsafeWall,
    OpenAir,
    Good,
    Hazard,
  }

  private struct ParticlePreparation
  {
    public RichRoomCheckFeedback.Reason type;
    public int x;
    public int y;
    public int iteration;
    public bool consumed;
  }

  private struct ScorePreparation
  {
    public int x;
    public int y;
    public int score;
  }
}
