// Decompiled with JetBrains decompiler
// Type: Terraria.Cloud
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.Utilities;

#nullable disable
namespace Terraria;

public class Cloud
{
  public Vector2 position;
  public float scale;
  public float rotation;
  public float rSpeed;
  public float sSpeed;
  public bool active;
  public SpriteEffects spriteDir;
  public int type;
  public int width;
  public int height;
  public float Alpha;
  public bool kill;
  private static UnifiedRandom rand = new UnifiedRandom();
  public static Vector2? lastCameraCenter;

  public static void resetClouds()
  {
    if (Main.dedServ)
      return;
    Main.windSpeedCurrent = Main.windSpeedTarget;
    for (int index = 0; index < 200; ++index)
      Main.cloud[index].active = false;
    for (int index = 0; index < Main.numClouds; ++index)
    {
      Cloud.addCloud();
      Main.cloud[index].Alpha = 1f;
    }
    for (int index = 0; index < 200; ++index)
      Main.cloud[index].Alpha = 1f;
  }

  public static void addCloud()
  {
    if (Main.netMode == 2)
      return;
    int index1 = -1;
    for (int index2 = 0; index2 < 200; ++index2)
    {
      if (!Main.cloud[index2].active)
      {
        index1 = index2;
        break;
      }
    }
    if (index1 < 0)
      return;
    Main.cloud[index1].kill = false;
    Main.cloud[index1].rSpeed = 0.0f;
    Main.cloud[index1].sSpeed = 0.0f;
    Main.cloud[index1].scale = (float) Cloud.rand.Next(70, 131) * 0.01f;
    Main.cloud[index1].rotation = (float) Cloud.rand.Next(-10, 11) * 0.01f;
    Main.cloud[index1].width = (int) ((double) TextureAssets.Cloud[Main.cloud[index1].type].Width() * (double) Main.cloud[index1].scale);
    Main.cloud[index1].height = (int) ((double) TextureAssets.Cloud[Main.cloud[index1].type].Height() * (double) Main.cloud[index1].scale);
    Main.cloud[index1].Alpha = 0.0f;
    Main.cloud[index1].spriteDir = SpriteEffects.None;
    if (Cloud.rand.Next(2) == 0)
      Main.cloud[index1].spriteDir = SpriteEffects.FlipHorizontally;
    float num1 = Main.windSpeedCurrent;
    if (!Main.gameMenu)
      num1 = Main.windSpeedCurrent - Main.player[Main.myPlayer].velocity.X * 0.1f;
    int num2 = 0;
    int num3 = 0;
    if ((double) num1 > 0.0)
      num2 -= 200;
    if ((double) num1 < 0.0)
      num3 += 200;
    int num4 = 300;
    float num5 = (float) Cloud.rand.Next(num2 - num4, Main.screenWidth + num3 + num4);
    Main.cloud[index1].Alpha = 0.0f;
    Main.cloud[index1].position.Y = (float) Cloud.rand.Next((int) ((double) -Main.screenHeight * 0.25), (int) ((double) Main.screenHeight * 0.15000000596046448));
    if (Cloud.rand.Next(3) == 0)
      Main.cloud[index1].position.Y -= (float) Cloud.rand.Next((int) ((double) Main.screenHeight * 0.10000000149011612));
    Main.cloud[index1].type = Cloud.rand.Next(4);
    if ((double) Main.cloudAlpha > 0.0 && Cloud.rand.Next(4) != 0 || (double) Main.cloudBGActive >= 1.0 && Cloud.rand.Next(2) == 0)
    {
      Main.cloud[index1].type = Cloud.rand.Next(18, 22);
      if ((double) Main.cloud[index1].scale >= 1.15)
        Main.cloud[index1].position.Y -= 150f;
      if ((double) Main.cloud[index1].scale >= 1.0)
        Main.cloud[index1].position.Y -= 150f;
    }
    else if ((double) Main.cloudBGActive <= 0.0 && (double) Main.cloudAlpha == 0.0 && (double) Main.cloud[index1].scale < 1.0 && (double) Main.cloud[index1].position.Y < (double) -Main.screenHeight * 0.15000000596046448 && (double) Main.numClouds <= 80.0)
      Main.cloud[index1].type = Cloud.rand.Next(9, 14);
    else if (((double) Main.cloud[index1].scale < 1.15 && (double) Main.cloud[index1].position.Y < (double) -Main.screenHeight * 0.30000001192092896 || (double) Main.cloud[index1].scale < 0.85 && (double) Main.cloud[index1].position.Y < (double) Main.screenHeight * 0.15000000596046448) && ((double) Main.numClouds > 70.0 || (double) Main.cloudBGActive >= 1.0))
      Main.cloud[index1].type = Cloud.rand.Next(4, 9);
    else if ((double) Main.cloud[index1].position.Y > (double) -Main.screenHeight * 0.15000000596046448 && Cloud.rand.Next(2) == 0 && (double) Main.numClouds > 20.0)
      Main.cloud[index1].type = Cloud.rand.Next(14, 18);
    if (Cloud.rand.Next(Main.dontStarveWorld || Main.tenthAnniversaryWorld ? 25 : 150) == 0)
      Main.cloud[index1].type = Cloud.RollRareCloud();
    else if (Main.tenthAnniversaryWorld && Cloud.rand.Next(3) == 0)
      Main.cloud[index1].type = Cloud.RollRareCloud();
    if ((double) Main.cloud[index1].scale > 1.2)
      Main.cloud[index1].position.Y += 100f;
    if ((double) Main.cloud[index1].scale > 1.3)
      Main.cloud[index1].scale = 1.3f;
    if ((double) Main.cloud[index1].scale < 0.7)
      Main.cloud[index1].scale = 0.7f;
    Main.cloud[index1].active = true;
    Main.cloud[index1].position.X = num5;
    if ((double) Main.cloud[index1].position.X > (double) (Main.screenWidth + 400))
      Main.cloud[index1].Alpha = 1f;
    if ((double) Main.cloud[index1].position.X + (double) TextureAssets.Cloud[Main.cloud[index1].type].Width() * (double) Main.cloud[index1].scale < -400.0)
      Main.cloud[index1].Alpha = 1f;
    Rectangle rectangle1 = new Rectangle((int) Main.cloud[index1].position.X, (int) Main.cloud[index1].position.Y, Main.cloud[index1].width, Main.cloud[index1].height);
    for (int index3 = 0; index3 < 200; ++index3)
    {
      if (index1 != index3 && Main.cloud[index3].active)
      {
        Rectangle rectangle2 = new Rectangle((int) Main.cloud[index3].position.X, (int) Main.cloud[index3].position.Y, Main.cloud[index3].width, Main.cloud[index3].height);
        if (rectangle1.Intersects(rectangle2))
          Main.cloud[index1].active = false;
      }
    }
  }

  private static int RollRareCloud()
  {
    int num = -1;
    bool flag = false;
    while (!flag)
    {
      num = !Main.tenthAnniversaryWorld ? Cloud.rand.Next(22, 41) : Cloud.rand.Next(22, 37);
      switch (num)
      {
        case 25:
        case 26:
          flag = NPC.downedBoss1;
          continue;
        case 28:
          if (Cloud.rand.Next(10) == 0)
          {
            flag = true;
            continue;
          }
          continue;
        case 30:
        case 35:
          flag = Main.hardMode;
          continue;
        case 31 /*0x1F*/:
          flag = NPC.downedBoss3;
          continue;
        case 36:
          flag = NPC.downedBoss2 && WorldGen.crimson;
          continue;
        case 37:
        case 38:
        case 39:
        case 40:
          if (Main.dontStarveWorld || Cloud.rand.Next(10) == 0)
          {
            flag = true;
            continue;
          }
          continue;
        default:
          flag = true;
          continue;
      }
    }
    return num;
  }

  public Color cloudColor(Color bgColor)
  {
    float num = this.scale * this.Alpha;
    if ((double) num > 1.0)
      num = 1f;
    return new Color((int) (byte) (float) (int) ((double) bgColor.R * (double) num), (int) (byte) (float) (int) ((double) bgColor.G * (double) num), (int) (byte) (float) (int) ((double) bgColor.B * (double) num), (int) (byte) (float) (int) ((double) bgColor.A * (double) num));
  }

  public object Clone() => this.MemberwiseClone();

  public static void UpdateClouds()
  {
    if (Main.netMode == 2)
      return;
    int maxValue = 0;
    for (int index = 0; index < 200; ++index)
    {
      if (Main.cloud[index].active)
      {
        Main.cloud[index].Update();
        if (!Main.cloud[index].kill)
          ++maxValue;
      }
    }
    for (int index = 0; index < 200; ++index)
    {
      if (Main.cloud[index].active)
      {
        if (index > 1 && (!Main.cloud[index - 1].active || (double) Main.cloud[index - 1].scale > (double) Main.cloud[index].scale + 0.02))
        {
          Cloud cloud = (Cloud) Main.cloud[index - 1].Clone();
          Main.cloud[index - 1] = (Cloud) Main.cloud[index].Clone();
          Main.cloud[index] = cloud;
        }
        if (index < 199 && (!Main.cloud[index].active || (double) Main.cloud[index + 1].scale < (double) Main.cloud[index].scale - 0.02))
        {
          Cloud cloud = (Cloud) Main.cloud[index + 1].Clone();
          Main.cloud[index + 1] = (Cloud) Main.cloud[index].Clone();
          Main.cloud[index] = cloud;
        }
      }
    }
    if (maxValue < Main.numClouds)
    {
      Cloud.addCloud();
    }
    else
    {
      if (maxValue <= Main.numClouds)
        return;
      int index1 = Cloud.rand.Next(maxValue);
      for (int index2 = 0; Main.cloud[index1].kill && index2 < 100; index1 = Cloud.rand.Next(maxValue))
        ++index2;
      Main.cloud[index1].kill = true;
    }
  }

  public static void UpdateCloudParallax()
  {
    float num = 0.0f;
    Vector2 center = Main.Camera.Center;
    if (Cloud.lastCameraCenter.HasValue)
      num = center.X - Cloud.lastCameraCenter.Value.X;
    Cloud.lastCameraCenter = new Vector2?(center);
    if ((double) num == 0.0)
      return;
    for (int index = 0; index < 200; ++index)
    {
      Cloud cloud = Main.cloud[index];
      if (cloud.active)
        cloud.position.X -= num * cloud.GetParallax();
    }
  }

  private float GetParallax()
  {
    float num1;
    float num2;
    if ((double) this.scale < 1.0)
    {
      num1 = 0.07f;
      num2 = (float) (((double) (this.scale + 0.15f) + 1.0) / 2.0);
    }
    else if ((double) this.scale <= 1.15)
    {
      num1 = 0.19f;
      num2 = this.scale - 0.075f;
    }
    else
    {
      num1 = 0.23f;
      num2 = (float) ((double) this.scale - 0.15000000596046448 - 0.075000002980232239);
    }
    float num3 = num2 * num2;
    return num1 * num3;
  }

  public void Update()
  {
    if (WorldGen.drunkWorldGenText && Main.gameMenu)
      this.type = !Main.onlyShimmerOceanWorlds ? (!WorldGen.dontStarveWorldGen ? (!WorldGen.getGoodWorldGen ? 28 : ((double) this.scale >= 0.8 ? 26 : 25)) : ((double) this.scale >= 0.7 ? ((double) this.scale >= 0.8 ? ((double) this.scale >= 0.9 ? 37 : 38) : 39) : 40)) : 29;
    if ((double) this.scale == 1.0)
      this.scale -= 0.0001f;
    if ((double) this.scale == 1.15)
      this.scale -= 0.0001f;
    this.position.X += Main.windSpeedCurrent * 9f * this.GetParallax() * (float) Main.dayRate;
    float num = 600f;
    if ((double) Main.bgAlphaFrontLayer[4] == 1.0 && (double) this.position.Y > 200.0)
    {
      this.kill = true;
      this.Alpha -= 0.005f * (float) Main.dayRate;
    }
    if (!this.kill)
    {
      if ((double) this.Alpha < 1.0)
      {
        this.Alpha += 1f / 1000f * (float) Main.dayRate;
        if ((double) this.Alpha > 1.0)
          this.Alpha = 1f;
      }
    }
    else
    {
      this.Alpha -= 1f / 1000f * (float) Main.dayRate;
      if ((double) this.Alpha <= 0.0)
        this.active = false;
    }
    if ((double) this.position.X + (double) TextureAssets.Cloud[this.type].Width() * (double) this.scale < -(double) num || (double) this.position.X > (double) Main.screenWidth + (double) num)
      this.active = false;
    this.rSpeed += (float) Cloud.rand.Next(-10, 11) * 2E-05f;
    if ((double) this.rSpeed > 0.0002)
      this.rSpeed = 0.0002f;
    if ((double) this.rSpeed < -0.0002)
      this.rSpeed = -0.0002f;
    if ((double) this.rotation > 0.02)
      this.rotation = 0.02f;
    if ((double) this.rotation < -0.02)
      this.rotation = -0.02f;
    this.rotation += this.rSpeed;
    this.width = (int) ((double) TextureAssets.Cloud[this.type].Width() * (double) this.scale);
    this.height = (int) ((double) TextureAssets.Cloud[this.type].Height() * (double) this.scale);
    if (this.type < 9 || this.type > 13 || (double) Main.cloudAlpha <= 0.0 && (double) Main.cloudBGActive < 1.0)
      return;
    this.kill = true;
  }
}
