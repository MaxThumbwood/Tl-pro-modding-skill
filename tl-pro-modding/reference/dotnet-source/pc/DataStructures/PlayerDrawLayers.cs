// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.PlayerDrawLayers
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using System.Collections.Generic;
using Terraria.GameContent;
using Terraria.GameContent.Events;
using Terraria.GameContent.Liquid;
using Terraria.Graphics;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.UI;

#nullable disable
namespace Terraria.DataStructures;

public static class PlayerDrawLayers
{
  public static void DrawPlayer_extra_TorsoPlus(ref PlayerDrawSet drawinfo)
  {
    drawinfo.Position.Y += drawinfo.torsoOffset;
    drawinfo.ItemLocation.Y += drawinfo.torsoOffset;
  }

  public static void DrawPlayer_extra_TorsoMinus(ref PlayerDrawSet drawinfo)
  {
    drawinfo.Position.Y -= drawinfo.torsoOffset;
    drawinfo.ItemLocation.Y -= drawinfo.torsoOffset;
  }

  public static void DrawPlayer_extra_MountPlus(ref PlayerDrawSet drawinfo)
  {
    drawinfo.Position.Y += (float) ((int) drawinfo.mountOffSet / 2);
  }

  public static void DrawPlayer_extra_MountMinus(ref PlayerDrawSet drawinfo)
  {
    drawinfo.Position.Y -= (float) ((int) drawinfo.mountOffSet / 2);
  }

  public static void DrawCompositeArmorPiece(
    ref PlayerDrawSet drawinfo,
    CompositePlayerDrawContext context,
    DrawData data,
    int bodyIndex)
  {
    drawinfo.DrawDataCache.Add(data);
    if (drawinfo.hideEntirePlayer || drawinfo.hideEntirePlayerExceptHelmetsAndFaceAccessories)
      return;
    switch (context)
    {
      case CompositePlayerDrawContext.BackShoulder:
      case CompositePlayerDrawContext.BackArm:
      case CompositePlayerDrawContext.FrontArm:
      case CompositePlayerDrawContext.FrontShoulder:
        if (drawinfo.armGlowColor.PackedValue > 0U)
        {
          DrawData drawData = data with
          {
            color = drawinfo.armGlowColor
          };
          Rectangle rectangle = drawData.sourceRect.Value;
          rectangle.Y += 224 /*0xE0*/;
          drawData.sourceRect = new Rectangle?(rectangle);
          if (bodyIndex == 227)
          {
            Vector2 position = drawData.position;
            for (int index = 0; index < 2; ++index)
            {
              Vector2 vector2 = new Vector2((float) Main.rand.Next(-10, 10) * 0.125f, (float) Main.rand.Next(-10, 10) * 0.125f);
              drawData.position = position + vector2;
              if (index == 0)
                drawinfo.DrawDataCache.Add(drawData);
            }
          }
          drawinfo.DrawDataCache.Add(drawData);
          break;
        }
        break;
      case CompositePlayerDrawContext.Torso:
        if (drawinfo.bodyGlowColor.PackedValue > 0U)
        {
          DrawData drawData = data with
          {
            color = drawinfo.bodyGlowColor
          };
          Rectangle rectangle = drawData.sourceRect.Value;
          rectangle.Y += 224 /*0xE0*/;
          drawData.sourceRect = new Rectangle?(rectangle);
          if (bodyIndex == 227)
          {
            Vector2 position = drawData.position;
            for (int index = 0; index < 2; ++index)
            {
              Vector2 vector2 = new Vector2((float) Main.rand.Next(-10, 10) * 0.125f, (float) Main.rand.Next(-10, 10) * 0.125f);
              drawData.position = position + vector2;
              if (index == 0)
                drawinfo.DrawDataCache.Add(drawData);
            }
          }
          drawinfo.DrawDataCache.Add(drawData);
          break;
        }
        break;
    }
    if (context == CompositePlayerDrawContext.FrontShoulder && drawinfo.drawPlayer.head == 269)
    {
      Vector2 pos = drawinfo.helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect;
      drawinfo.drawPlayer.ApplyHeadOffsetFromMount(ref pos);
      DrawData drawData = new DrawData(TextureAssets.Extra[214].Value, pos, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cHead;
      drawinfo.DrawDataCache.Add(drawData);
      drawData = new DrawData(TextureAssets.GlowMask[308].Value, pos, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.headGlowColor, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cHead;
      drawinfo.DrawDataCache.Add(drawData);
    }
    if (context == CompositePlayerDrawContext.FrontArm && bodyIndex == 205)
    {
      Color immuneAlphaPure = drawinfo.drawPlayer.GetImmuneAlphaPure(new Color(100, 100, 100, 0), drawinfo.shadow);
      ulong seed = (ulong) (drawinfo.drawPlayer.miscCounter / 4);
      int num1 = 4;
      for (int index = 0; index < num1; ++index)
      {
        float num2 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.2f;
        float num3 = (float) Utils.RandomInt(ref seed, -10, 1) * 0.15f;
        DrawData drawData = data;
        Rectangle rectangle = drawData.sourceRect.Value;
        rectangle.Y += 224 /*0xE0*/;
        drawData.sourceRect = new Rectangle?(rectangle);
        drawData.position.X += num2;
        drawData.position.Y += num3;
        drawData.color = immuneAlphaPure;
        drawinfo.DrawDataCache.Add(drawData);
      }
    }
    if (bodyIndex == 251)
    {
      DrawData drawData = data with
      {
        texture = TextureAssets.GlowMask[364].Value,
        color = PlayerDrawLayers.GetChickenBonesGlowColor(ref drawinfo, true)
      };
      float scale = drawinfo.stealth * drawinfo.stealth * (1f - drawinfo.shadow);
      drawData.color = Color.Multiply(drawData.color, scale);
      drawinfo.DrawDataCache.Add(drawData);
    }
    else
    {
      if (bodyIndex != 259)
        return;
      DrawData drawData = data with
      {
        texture = TextureAssets.GlowMask[376].Value,
        color = drawinfo.drawPlayer.GetImmuneAlphaPure(Color.White, drawinfo.shadow)
      };
      float scale = drawinfo.stealth * drawinfo.stealth * (1f - drawinfo.shadow);
      drawData.color = Color.Multiply(drawData.color, scale);
      drawinfo.DrawDataCache.Add(drawData);
    }
  }

  public static Color GetChickenBonesGlowColor(
    ref PlayerDrawSet drawinfo,
    bool scaleByShadow,
    bool wings = false)
  {
    if (drawinfo.hideEntirePlayer || drawinfo.hideEntirePlayerExceptHelmetsAndFaceAccessories)
      return Color.Transparent;
    Color newColor = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
    if (!wings)
    {
      float num = Utils.Remap(Utils.WrappedLerp(0.0f, 1f, (float) (drawinfo.drawPlayer.miscCounter % 100) / 100f), 0.0f, 1f, 0.8f, 1f);
      newColor *= num;
    }
    return !scaleByShadow ? newColor : drawinfo.drawPlayer.GetImmuneAlphaPure(newColor, drawinfo.shadow);
  }

  public static Color GetLunaGlowColor(ref PlayerDrawSet drawinfo, bool scaleByShadow)
  {
    if (drawinfo.hideEntirePlayer || drawinfo.hideEntirePlayerExceptHelmetsAndFaceAccessories)
      return Color.Transparent;
    Color newColor = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 100) * Utils.Remap(Utils.WrappedLerp(0.0f, 1f, (float) (drawinfo.drawPlayer.miscCounter % 100) / 100f), 0.0f, 1f, 0.85f, 1f);
    return !scaleByShadow ? newColor : drawinfo.drawPlayer.GetImmuneAlphaPure(newColor, drawinfo.shadow);
  }

  public static void DrawPlayer_01_BackHair(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.hideHair || !drawinfo.backHairDraw)
      return;
    Vector2 position = new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect + drawinfo.hairOffset;
    if (drawinfo.drawPlayer.head == -1 || drawinfo.fullHair || drawinfo.drawsBackHairWithoutHeadgear)
    {
      drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.PlayerHair[drawinfo.drawPlayer.hair].Value, position, new Rectangle?(drawinfo.hairBackFrame), drawinfo.colorHair, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.hairDyePacked
      });
    }
    else
    {
      if (!drawinfo.hatHair)
        return;
      drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.PlayerHairAlt[drawinfo.drawPlayer.hair].Value, position, new Rectangle?(drawinfo.hairBackFrame), drawinfo.colorHair, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.hairDyePacked
      });
    }
  }

  public static void DrawPlayer_02_MountBehindPlayer(ref PlayerDrawSet drawinfo)
  {
    if (!drawinfo.drawPlayer.mount.Active)
      return;
    PlayerDrawLayers.DrawMeowcartTrail(ref drawinfo);
    PlayerDrawLayers.DrawTiedBalloons(ref drawinfo);
    drawinfo.drawPlayer.mount.Draw(drawinfo.DrawDataCache, 0, drawinfo.drawPlayer, drawinfo.Position, drawinfo.colorMount, drawinfo.playerEffect, drawinfo.shadow);
    drawinfo.drawPlayer.mount.Draw(drawinfo.DrawDataCache, 1, drawinfo.drawPlayer, drawinfo.Position, drawinfo.colorMount, drawinfo.playerEffect, drawinfo.shadow);
  }

  public static void DrawPlayer_03_Carpet(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.carpetFrame < 0)
      return;
    Color colorArmorLegs = drawinfo.colorArmorLegs;
    float num = 0.0f;
    if ((double) drawinfo.drawPlayer.gravDir == -1.0)
      num = 10f;
    drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.FlyingCarpet.Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) (drawinfo.drawPlayer.height / 2) + 28.0 * (double) drawinfo.drawPlayer.gravDir + (double) num)), new Rectangle?(new Rectangle(0, TextureAssets.FlyingCarpet.Height() / 6 * drawinfo.drawPlayer.carpetFrame, TextureAssets.FlyingCarpet.Width(), TextureAssets.FlyingCarpet.Height() / 6)), colorArmorLegs, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.FlyingCarpet.Width() / 2), (float) (TextureAssets.FlyingCarpet.Height() / 8)), 1f, drawinfo.playerEffect)
    {
      shader = drawinfo.cCarpet
    });
  }

  public static void DrawPlayer_03_PortableStool(ref PlayerDrawSet drawinfo)
  {
    if (!drawinfo.drawPlayer.portableStoolInfo.IsInUse || (double) drawinfo.shadow != 0.0)
      return;
    Texture2D texture2D = TextureAssets.Extra[102].Value;
    Vector2 position = new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height + 28.0));
    Rectangle r = texture2D.Frame();
    Vector2 origin = r.Size() * new Vector2(0.5f, 1f);
    drawinfo.DrawDataCache.Add(new DrawData(texture2D, position, new Rectangle?(r), drawinfo.colorArmorLegs, drawinfo.drawPlayer.bodyRotation, origin, 1f, drawinfo.playerEffect)
    {
      shader = drawinfo.cPortableStool
    });
  }

  public static void DrawPlayer_04_ElectrifiedDebuffBack(ref PlayerDrawSet drawinfo)
  {
    if (!drawinfo.drawPlayer.electrified || (double) drawinfo.shadow != 0.0)
      return;
    Texture2D texture = TextureAssets.GlowMask[25].Value;
    int num1 = drawinfo.drawPlayer.miscCounter / 5;
    for (int index = 0; index < 2; ++index)
    {
      int num2 = num1 % 7;
      if (num2 <= 1 || num2 >= 5)
      {
        DrawData drawData = new DrawData(texture, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(new Rectangle(0, num2 * texture.Height / 7, texture.Width, texture.Height / 7)), drawinfo.colorElectricity, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (texture.Width / 2), (float) (texture.Height / 14)), 1f, drawinfo.playerEffect);
        drawinfo.DrawDataCache.Add(drawData);
      }
      num1 = num2 + 3;
    }
  }

  public static void DrawPlayer_05_ForbiddenSetRing(ref PlayerDrawSet drawinfo)
  {
    if (!drawinfo.drawPlayer.setForbidden || (double) drawinfo.shadow != 0.0)
      return;
    Color color1 = Color.Lerp(drawinfo.colorArmorBody, Color.White, 0.7f);
    Texture2D texture2D = TextureAssets.Extra[74].Value;
    Texture2D texture = TextureAssets.GlowMask[217].Value;
    int num1 = !drawinfo.drawPlayer.setForbiddenCooldownLocked ? 1 : 0;
    int num2 = (int) ((double) ((float) ((double) drawinfo.drawPlayer.miscCounter / 300.0 * 6.2831854820251465)).ToRotationVector2().Y * 6.0);
    float num3 = ((float) ((double) drawinfo.drawPlayer.miscCounter / 75.0 * 6.2831854820251465)).ToRotationVector2().X * 4f;
    Color color2 = new Color(80 /*0x50*/, 70, 40, 0) * (float) ((double) num3 / 8.0 + 0.5) * 0.8f;
    if (num1 == 0)
    {
      num2 = 0;
      num3 = 2f;
      color2 = new Color(80 /*0x50*/, 70, 40, 0) * 0.3f;
      color1 = color1.MultiplyRGB(new Color(0.5f, 0.5f, 1f));
    }
    Vector2 vector2 = new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2));
    int num4 = 10;
    int num5 = 20;
    if (drawinfo.drawPlayer.head == 238)
    {
      num4 += 4;
      num5 += 4;
    }
    Vector2 position = vector2 + new Vector2((float) (-drawinfo.drawPlayer.direction * num4), (float) ((double) -num5 * (double) drawinfo.drawPlayer.gravDir + (double) num2 * (double) drawinfo.drawPlayer.gravDir));
    DrawData drawData = new DrawData(texture2D, position, new Rectangle?(), color1, drawinfo.drawPlayer.bodyRotation, texture2D.Size() / 2f, 1f, drawinfo.playerEffect);
    drawData.shader = drawinfo.cBody;
    drawinfo.DrawDataCache.Add(drawData);
    for (float num6 = 0.0f; (double) num6 < 4.0; ++num6)
    {
      drawData = new DrawData(texture, position + (num6 * 1.57079637f).ToRotationVector2() * num3, new Rectangle?(), color2, drawinfo.drawPlayer.bodyRotation, texture2D.Size() / 2f, 1f, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData);
    }
  }

  public static void DrawPlayer_01_3_BackHead(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.head >= 0 && drawinfo.drawPlayer.head < ArmorIDs.Head.Count)
    {
      int index = ArmorIDs.Head.Sets.FrontToBackID[drawinfo.drawPlayer.head];
      if (index >= 0)
      {
        Vector2 helmetOffset = drawinfo.helmetOffset;
        drawinfo.drawPlayer.ApplyHeadOffsetFromMount(ref helmetOffset);
        drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.ArmorHead[index].Value, helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect)
        {
          shader = drawinfo.cHead
        });
      }
    }
    if (drawinfo.drawPlayer.face <= (sbyte) 0 || drawinfo.drawPlayer.face != (sbyte) 23)
      return;
    PlayerDrawLayers.DrawPlayer_ChippysHeadband(ref drawinfo);
  }

  public static void DrawPlayer_01_2_JimsCloak(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.legs != 60 || drawinfo.isSitting || drawinfo.drawPlayer.invis || PlayerDrawLayers.ShouldOverrideLegs_CheckShoes(ref drawinfo) && !drawinfo.drawPlayer.wearsRobe)
      return;
    drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.Extra[153].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.legFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.legFrame.Height + 4.0)) + drawinfo.drawPlayer.legPosition + drawinfo.legVect, new Rectangle?(drawinfo.drawPlayer.legFrame), drawinfo.colorArmorLegs, drawinfo.drawPlayer.legRotation, drawinfo.legVect, 1f, drawinfo.playerEffect)
    {
      shader = drawinfo.cLegs
    });
  }

  public static void DrawPlayer_05_2_SafemanSun(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.head != 238 || (double) drawinfo.shadow != 0.0)
      return;
    Color color1 = Color.Lerp(drawinfo.colorArmorBody, Color.White, 0.7f);
    Texture2D texture2D = TextureAssets.Extra[152].Value;
    Texture2D texture = TextureAssets.Extra[152].Value;
    int num1 = (int) ((double) ((float) ((double) drawinfo.drawPlayer.miscCounter / 300.0 * 6.2831854820251465)).ToRotationVector2().Y * 6.0);
    float num2 = ((float) ((double) drawinfo.drawPlayer.miscCounter / 75.0 * 6.2831854820251465)).ToRotationVector2().X * 4f;
    Color color2 = new Color(80 /*0x50*/, 70, 40, 0) * (float) ((double) num2 / 8.0 + 0.5) * 0.8f;
    Vector2 vector2 = new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2));
    int num3 = 8;
    int num4 = 20;
    int num5 = num3 + 4;
    int num6 = num4 + 4;
    if (drawinfo.drawPlayer.mount.Active)
    {
      switch (drawinfo.drawPlayer.mount.Type)
      {
        case 55:
        case 56:
        case 61:
          num6 -= 22;
          break;
      }
    }
    Vector2 position = vector2 + new Vector2((float) (-drawinfo.drawPlayer.direction * num5), (float) ((double) -num6 * (double) drawinfo.drawPlayer.gravDir + (double) num1 * (double) drawinfo.drawPlayer.gravDir));
    DrawData drawData = new DrawData(texture2D, position, new Rectangle?(), color1, drawinfo.drawPlayer.bodyRotation, texture2D.Size() / 2f, 1f, drawinfo.playerEffect);
    drawData.shader = drawinfo.cHead;
    drawinfo.DrawDataCache.Add(drawData);
    for (float num7 = 0.0f; (double) num7 < 4.0; ++num7)
    {
      drawData = new DrawData(texture, position + (num7 * 1.57079637f).ToRotationVector2() * num2, new Rectangle?(), color2, drawinfo.drawPlayer.bodyRotation, texture2D.Size() / 2f, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cHead;
      drawinfo.DrawDataCache.Add(drawData);
    }
  }

  public static void DrawPlayer_06_WebbedDebuffBack(ref PlayerDrawSet drawinfo)
  {
    if (!drawinfo.drawPlayer.webbed || (double) drawinfo.shadow != 0.0 || (double) drawinfo.drawPlayer.velocity.Y == 0.0)
      return;
    Color color = drawinfo.colorArmorBody * 0.75f;
    Texture2D texture2D = TextureAssets.Extra[32 /*0x20*/].Value;
    DrawData drawData = new DrawData(texture2D, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(), color, drawinfo.drawPlayer.bodyRotation, texture2D.Size() / 2f, 1f, drawinfo.playerEffect);
    drawinfo.DrawDataCache.Add(drawData);
  }

  public static void DrawPlayer_07_LeinforsHairShampoo(ref PlayerDrawSet drawinfo)
  {
    if (!drawinfo.drawPlayer.leinforsHair || !drawinfo.fullHair && !drawinfo.hatHair && !drawinfo.drawsBackHairWithoutHeadgear && drawinfo.drawPlayer.head != -1 && drawinfo.drawPlayer.head != 0 || drawinfo.drawPlayer.hair == 12 || (double) drawinfo.shadow != 0.0 || (double) Main.rgbToHsl(drawinfo.colorHead).Z <= 0.20000000298023224)
      return;
    if (Main.rand.Next(20) == 0 && !drawinfo.hatHair)
    {
      Rectangle r = Utils.CenteredRectangle(drawinfo.Position + drawinfo.drawPlayer.Size / 2f + new Vector2(0.0f, drawinfo.drawPlayer.gravDir * -20f), new Vector2(20f, 14f));
      int index = Dust.NewDust(r.TopLeft(), r.Width, r.Height, 204, Alpha: 150, Scale: 0.3f);
      Main.dust[index].fadeIn = 1f;
      Main.dust[index].velocity *= 0.1f;
      Main.dust[index].noLight = true;
      Main.dust[index].shader = GameShaders.Armor.GetSecondaryShader(drawinfo.drawPlayer.cLeinShampoo, drawinfo.drawPlayer);
      drawinfo.DustCache.Add(index);
    }
    if (Main.rand.Next(40) == 0 && drawinfo.hatHair)
    {
      Rectangle r = Utils.CenteredRectangle(drawinfo.Position + drawinfo.drawPlayer.Size / 2f + new Vector2((float) (drawinfo.drawPlayer.direction * -10), drawinfo.drawPlayer.gravDir * -10f), new Vector2(5f, 5f));
      int index = Dust.NewDust(r.TopLeft(), r.Width, r.Height, 204, Alpha: 150, Scale: 0.3f);
      Main.dust[index].fadeIn = 1f;
      Main.dust[index].velocity *= 0.1f;
      Main.dust[index].noLight = true;
      Main.dust[index].shader = GameShaders.Armor.GetSecondaryShader(drawinfo.drawPlayer.cLeinShampoo, drawinfo.drawPlayer);
      drawinfo.DustCache.Add(index);
    }
    if ((double) drawinfo.drawPlayer.velocity.X == 0.0 || !drawinfo.backHairDraw || Main.rand.Next(15) != 0)
      return;
    Rectangle r1 = Utils.CenteredRectangle(drawinfo.Position + drawinfo.drawPlayer.Size / 2f + new Vector2((float) (drawinfo.drawPlayer.direction * -14), 0.0f), new Vector2(4f, 30f));
    int index1 = Dust.NewDust(r1.TopLeft(), r1.Width, r1.Height, 204, Alpha: 150, Scale: 0.3f);
    Main.dust[index1].fadeIn = 1f;
    Main.dust[index1].velocity *= 0.1f;
    Main.dust[index1].noLight = true;
    Main.dust[index1].shader = GameShaders.Armor.GetSecondaryShader(drawinfo.drawPlayer.cLeinShampoo, drawinfo.drawPlayer);
    drawinfo.DustCache.Add(index1);
  }

  public static bool DrawPlayer_08_PlayerVisuallyHasFullArmorSet(
    PlayerDrawSet drawinfo,
    int head,
    int body,
    int legs)
  {
    return drawinfo.drawPlayer.head == head && drawinfo.drawPlayer.body == body && drawinfo.drawPlayer.legs == legs;
  }

  public static void DrawPlayer_08_Backpacks(ref PlayerDrawSet drawinfo)
  {
    DrawData drawData;
    if (PlayerDrawLayers.DrawPlayer_08_PlayerVisuallyHasFullArmorSet(drawinfo, 266, 235, 218))
    {
      Vector2 position = (new Vector2((float) (-2.0 * (double) drawinfo.drawPlayer.Directions.X - 2.0), 0.0f) + drawinfo.Position - Main.screenPosition + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.width / 2), (float) (drawinfo.drawPlayer.height - drawinfo.drawPlayer.bodyFrame.Height / 2))).Floor();
      Texture2D texture2D = TextureAssets.Extra[212].Value;
      Rectangle rectangle = texture2D.Frame(verticalFrames: 5, frameY: drawinfo.drawPlayer.miscCounter % 25 / 5);
      Color color = drawinfo.drawPlayer.GetImmuneAlphaPure(new Color(250, 250, 250, 200), drawinfo.shadow) * drawinfo.drawPlayer.stealth;
      drawData = new DrawData(texture2D, position, new Rectangle?(rectangle), color, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cBody;
      drawinfo.DrawDataCache.Add(drawData);
    }
    if (PlayerDrawLayers.DrawPlayer_08_PlayerVisuallyHasFullArmorSet(drawinfo, 268, 237, 222))
    {
      Vector2 position = (new Vector2((float) (1.0 * (double) drawinfo.drawPlayer.Directions.X - 9.0), -4f * drawinfo.drawPlayer.Directions.Y) + drawinfo.Position - Main.screenPosition + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.width / 2), (float) (drawinfo.drawPlayer.height - drawinfo.drawPlayer.bodyFrame.Height / 2))).Floor();
      Texture2D texture2D = TextureAssets.Extra[213].Value;
      Rectangle rectangle = texture2D.Frame(verticalFrames: 5, frameY: drawinfo.drawPlayer.miscCounter % 25 / 5);
      Color color = drawinfo.drawPlayer.GetImmuneAlphaPure(new Color(250, 250, 250, 200), drawinfo.shadow) * drawinfo.drawPlayer.stealth;
      drawData = new DrawData(texture2D, position, new Rectangle?(rectangle), color, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cBody;
      drawinfo.DrawDataCache.Add(drawData);
    }
    if (drawinfo.heldItem.type == 4818 && drawinfo.drawPlayer.ownedProjectileCounts[902] == 0)
    {
      int index = 8;
      Vector2 vector2 = new Vector2(0.0f, 8f);
      Vector2 position = (drawinfo.Position - Main.screenPosition + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.width / 2), (float) (drawinfo.drawPlayer.height - drawinfo.drawPlayer.bodyFrame.Height / 2)) + new Vector2(0.0f, -4f) + vector2).Floor();
      drawData = new DrawData(TextureAssets.BackPack[index].Value, position, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData);
    }
    if (drawinfo.drawPlayer.backpack > (sbyte) 0 && (int) drawinfo.drawPlayer.backpack < ArmorIDs.Back.Count && (!drawinfo.drawPlayer.mount.Active || drawinfo.drawPlayer.mount.Type >= 0 && MountID.Sets.DoesNotOverrideBackpackDraw[drawinfo.drawPlayer.mount.Type]))
    {
      Vector2 vector2 = new Vector2(0.0f, 8f);
      Vector2 position = (drawinfo.Position - Main.screenPosition + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.width / 2), (float) (drawinfo.drawPlayer.height - drawinfo.drawPlayer.bodyFrame.Height / 2)) + new Vector2(0.0f, -4f) + vector2).Floor();
      drawData = new DrawData(TextureAssets.AccBack[(int) drawinfo.drawPlayer.backpack].Value, position, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cBackpack;
      drawinfo.DrawDataCache.Add(drawData);
    }
    else
    {
      if (drawinfo.heldItem.type != 1178 && drawinfo.heldItem.type != 779 && drawinfo.heldItem.type != 5134 && drawinfo.heldItem.type != 1295 && drawinfo.heldItem.type != 1910 && !drawinfo.drawPlayer.turtleArmor && drawinfo.drawPlayer.body != 106 && drawinfo.drawPlayer.body != 170)
        return;
      int type = drawinfo.heldItem.type;
      int index = 1;
      float num1 = -4f;
      float num2 = -8f;
      int num3 = 0;
      if (drawinfo.drawPlayer.turtleArmor)
      {
        index = 4;
        num3 = drawinfo.cBody;
      }
      else if (drawinfo.drawPlayer.body == 106)
      {
        index = 6;
        num3 = drawinfo.cBody;
      }
      else if (drawinfo.drawPlayer.body == 170)
      {
        index = 7;
        num3 = drawinfo.cBody;
      }
      else
      {
        switch (type)
        {
          case 779:
            index = 2;
            break;
          case 1178:
            index = 1;
            break;
          case 1295:
            index = 3;
            break;
          case 1910:
            index = 5;
            break;
          case 5134:
            index = 9;
            break;
        }
      }
      Vector2 vector2 = new Vector2(0.0f, 8f);
      Vector2 position1 = (drawinfo.Position - Main.screenPosition + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.width / 2), (float) (drawinfo.drawPlayer.height - drawinfo.drawPlayer.bodyFrame.Height / 2)) + new Vector2(0.0f, -4f) + vector2).Floor();
      Vector2 position2 = (drawinfo.Position - Main.screenPosition + new Vector2((float) (drawinfo.drawPlayer.width / 2), (float) (drawinfo.drawPlayer.height - drawinfo.drawPlayer.bodyFrame.Height / 2)) + new Vector2((num1 - 9f) * (float) drawinfo.drawPlayer.direction, (2f + num2) * drawinfo.drawPlayer.gravDir) + vector2).Floor();
      switch (index)
      {
        case 4:
        case 6:
          drawData = new DrawData(TextureAssets.BackPack[index].Value, position1, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
          drawData.shader = num3;
          drawinfo.DrawDataCache.Add(drawData);
          break;
        case 7:
          drawData = new DrawData(TextureAssets.BackPack[index].Value, position1, new Rectangle?(new Rectangle(0, drawinfo.drawPlayer.bodyFrame.Y, TextureAssets.BackPack[index].Width(), drawinfo.drawPlayer.bodyFrame.Height)), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, new Vector2((float) TextureAssets.BackPack[index].Width() * 0.5f, drawinfo.bodyVect.Y), 1f, drawinfo.playerEffect);
          drawData.shader = num3;
          drawinfo.DrawDataCache.Add(drawData);
          break;
        default:
          drawData = new DrawData(TextureAssets.BackPack[index].Value, position2, new Rectangle?(new Rectangle(0, 0, TextureAssets.BackPack[index].Width(), TextureAssets.BackPack[index].Height())), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.BackPack[index].Width() / 2), (float) (TextureAssets.BackPack[index].Height() / 2)), 1f, drawinfo.playerEffect);
          drawData.shader = num3;
          drawinfo.DrawDataCache.Add(drawData);
          break;
      }
    }
  }

  public static void DrawPlayer_08_1_Tails(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.tail <= (sbyte) 0 || (int) drawinfo.drawPlayer.tail >= ArmorIDs.Back.Count || drawinfo.drawPlayer.mount.Active)
      return;
    Vector2 zero = Vector2.Zero;
    if (drawinfo.isSitting)
      zero.Y += -2f;
    if (!drawinfo.drawPlayer.Male)
      zero.X += (float) (2 * drawinfo.drawPlayer.direction);
    Vector2 vector2 = new Vector2(0.0f, 8f);
    Vector2 position = (zero + drawinfo.Position - Main.screenPosition + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.width / 2), (float) (drawinfo.drawPlayer.height - drawinfo.drawPlayer.bodyFrame.Height / 2)) + new Vector2(0.0f, -4f) + vector2).Floor();
    drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.AccBack[(int) drawinfo.drawPlayer.tail].Value, position, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect)
    {
      shader = drawinfo.cTail
    });
  }

  public static void DrawPlayer_10_BackAcc(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.back <= (sbyte) 0 || (int) drawinfo.drawPlayer.back >= ArmorIDs.Back.Count)
      return;
    if (drawinfo.drawPlayer.front >= (sbyte) 1 && drawinfo.drawPlayer.front <= (sbyte) 4)
    {
      int num = drawinfo.drawPlayer.bodyFrame.Y / 56;
      if (num < 1 || num > 5)
      {
        drawinfo.armorAdjust = 10;
      }
      else
      {
        if (drawinfo.drawPlayer.front == (sbyte) 1)
          drawinfo.armorAdjust = 0;
        if (drawinfo.drawPlayer.front == (sbyte) 2)
          drawinfo.armorAdjust = 8;
        if (drawinfo.drawPlayer.front == (sbyte) 3)
          drawinfo.armorAdjust = 0;
        if (drawinfo.drawPlayer.front == (sbyte) 4)
          drawinfo.armorAdjust = 8;
      }
    }
    Vector2 zero = Vector2.Zero;
    Vector2 vector2 = new Vector2(0.0f, 8f);
    Vector2 position1 = drawinfo.Position;
    Vector2 position2 = (zero + position1 - Main.screenPosition + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.width / 2), (float) (drawinfo.drawPlayer.height - drawinfo.drawPlayer.bodyFrame.Height / 2)) + new Vector2(0.0f, -4f) + vector2).Floor();
    DrawData drawData = new DrawData(TextureAssets.AccBack[(int) drawinfo.drawPlayer.back].Value, position2, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
    drawData.shader = drawinfo.cBack;
    drawinfo.DrawDataCache.Add(drawData);
    if (drawinfo.drawPlayer.back != (sbyte) 36)
      return;
    Rectangle bodyFrame = drawinfo.drawPlayer.bodyFrame;
    Rectangle rectangle = bodyFrame with { Width = 2 };
    int num1 = 0;
    int num2 = bodyFrame.Width / 2;
    int num3 = 2;
    if ((drawinfo.playerEffect & SpriteEffects.FlipHorizontally) != SpriteEffects.None)
    {
      num1 = bodyFrame.Width - 2;
      num3 = -2;
    }
    for (int index = 0; index < num2; ++index)
    {
      rectangle.X = bodyFrame.X + 2 * index;
      Color color = drawinfo.drawPlayer.GetImmuneAlpha(LiquidRenderer.GetShimmerGlitterColor(true, (float) index / 16f, 0.0f), drawinfo.shadow) * ((float) drawinfo.colorArmorBody.A / (float) byte.MaxValue);
      drawData = new DrawData(TextureAssets.GlowMask[332].Value, position2 + new Vector2((float) (num1 + index * num3), 0.0f), new Rectangle?(rectangle), color, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cBack;
      drawinfo.DrawDataCache.Add(drawData);
    }
  }

  public static void DrawPlayer_09_Wings(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.dead || drawinfo.hideEntirePlayer || drawinfo.hideEntirePlayerExceptHelmetsAndFaceAccessories)
      return;
    Vector2 directions = drawinfo.drawPlayer.Directions;
    Vector2 vector2_1 = drawinfo.Position - Main.screenPosition + drawinfo.drawPlayer.Size / 2f;
    Vector2 vector2_2 = new Vector2(0.0f, 7f);
    Vector2 commonWingPosPreFloor = drawinfo.Position - Main.screenPosition + new Vector2((float) (drawinfo.drawPlayer.width / 2), (float) (drawinfo.drawPlayer.height - drawinfo.drawPlayer.bodyFrame.Height / 2)) + vector2_2;
    if (drawinfo.drawPlayer.wings <= 0)
      return;
    Main.instance.LoadWings(drawinfo.drawPlayer.wings);
    if (drawinfo.drawPlayer.wings == 22)
    {
      if (!drawinfo.drawPlayer.ShouldDrawWingsThatAreAlwaysAnimated())
        return;
      Main.instance.LoadItemFlames(1866);
      Color colorArmorBody = drawinfo.colorArmorBody;
      int y = 26;
      int x = -9;
      Vector2 vec = commonWingPosPreFloor + new Vector2((float) x, (float) y) * directions;
      DrawData drawData;
      if ((double) drawinfo.shadow == 0.0 && drawinfo.drawPlayer.grappling[0] == -1)
      {
        for (int index = 0; index < 7; ++index)
        {
          Color color = new Color(250 - index * 10, 250 - index * 10, 250 - index * 10, 150 - index * 10);
          Vector2 vector2_3 = new Vector2((float) Main.rand.Next(-10, 11) * 0.2f, (float) Main.rand.Next(-10, 11) * 0.2f);
          drawinfo.stealth *= drawinfo.stealth;
          drawinfo.stealth *= 1f - drawinfo.shadow;
          color = new Color((int) ((double) color.R * (double) drawinfo.stealth), (int) ((double) color.G * (double) drawinfo.stealth), (int) ((double) color.B * (double) drawinfo.stealth), (int) ((double) color.A * (double) drawinfo.stealth));
          vector2_3.X = drawinfo.drawPlayer.itemFlamePos[index].X;
          vector2_3.Y = -drawinfo.drawPlayer.itemFlamePos[index].Y;
          vector2_3 *= 0.5f;
          Vector2 position = (vec + vector2_3).Floor();
          drawData = new DrawData(TextureAssets.ItemFlame[1866].Value, position, new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 7 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 7 - 2)), color, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 14)), 1f, drawinfo.playerEffect);
          drawData.shader = drawinfo.cWings;
          drawinfo.DrawDataCache.Add(drawData);
        }
      }
      drawData = new DrawData(TextureAssets.Wings[drawinfo.drawPlayer.wings].Value, vec.Floor(), new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 7 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 7)), colorArmorBody, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 14)), 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cWings;
      drawinfo.DrawDataCache.Add(drawData);
    }
    else if (drawinfo.drawPlayer.wings == 28)
    {
      if (!drawinfo.drawPlayer.ShouldDrawWingsThatAreAlwaysAnimated())
        return;
      Color colorArmorBody = drawinfo.colorArmorBody;
      Vector2 vector2_4 = new Vector2(0.0f, 19f);
      Vector2 vec = commonWingPosPreFloor + vector2_4 * directions;
      Texture2D texture2D = TextureAssets.Wings[drawinfo.drawPlayer.wings].Value;
      Rectangle r = texture2D.Frame(verticalFrames: 4, frameY: drawinfo.drawPlayer.miscCounter / 5 % 4);
      r.Width -= 2;
      r.Height -= 2;
      DrawData drawData = new DrawData(texture2D, vec.Floor(), new Rectangle?(r), Color.Lerp(colorArmorBody, Color.White, 1f), drawinfo.drawPlayer.bodyRotation, r.Size() / 2f, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cWings;
      drawinfo.DrawDataCache.Add(drawData);
      drawData = new DrawData(TextureAssets.Extra[38].Value, vec.Floor(), new Rectangle?(r), Color.Lerp(colorArmorBody, Color.White, 0.5f), drawinfo.drawPlayer.bodyRotation, r.Size() / 2f, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cWings;
      drawinfo.DrawDataCache.Add(drawData);
    }
    else if (drawinfo.drawPlayer.wings == 45)
    {
      if (!drawinfo.drawPlayer.ShouldDrawWingsThatAreAlwaysAnimated())
        return;
      PlayerDrawLayers.DrawStarboardRainbowTrail(ref drawinfo, commonWingPosPreFloor, directions);
      Color color1 = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      int y = 22;
      int x = 0;
      Vector2 vec = commonWingPosPreFloor + new Vector2((float) x, (float) y) * directions;
      double num1 = 1.0 - (double) drawinfo.shadow;
      Color color2 = color1 * (float) num1;
      DrawData drawData = new DrawData(TextureAssets.Wings[drawinfo.drawPlayer.wings].Value, vec.Floor(), new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 6 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 6)), color2, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 12)), 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cWings;
      drawinfo.DrawDataCache.Add(drawData);
      if ((double) drawinfo.shadow != 0.0)
        return;
      float num2 = ((float) ((double) drawinfo.drawPlayer.miscCounter / 75.0 * 6.2831854820251465)).ToRotationVector2().X * 4f;
      Color color3 = new Color(70, 70, 70, 0) * (float) ((double) num2 / 8.0 + 0.5) * 0.4f;
      for (float f = 0.0f; (double) f < 6.2831854820251465; f += 1.57079637f)
      {
        drawData = new DrawData(TextureAssets.Wings[drawinfo.drawPlayer.wings].Value, vec.Floor() + f.ToRotationVector2() * num2, new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 6 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 6)), color3, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 12)), 1f, drawinfo.playerEffect);
        drawData.shader = drawinfo.cWings;
        drawinfo.DrawDataCache.Add(drawData);
      }
    }
    else if (drawinfo.drawPlayer.wings == 34)
    {
      if (!drawinfo.drawPlayer.ShouldDrawWingsThatAreAlwaysAnimated())
        return;
      drawinfo.stealth *= drawinfo.stealth;
      drawinfo.stealth *= 1f - drawinfo.shadow;
      Color color = new Color((int) (250.0 * (double) drawinfo.stealth), (int) (250.0 * (double) drawinfo.stealth), (int) (250.0 * (double) drawinfo.stealth), (int) (100.0 * (double) drawinfo.stealth));
      Vector2 vector2_5 = new Vector2(0.0f, 0.0f);
      Texture2D texture2D = TextureAssets.Wings[drawinfo.drawPlayer.wings].Value;
      Vector2 vec = drawinfo.Position + drawinfo.drawPlayer.Size / 2f - Main.screenPosition + vector2_5 * drawinfo.drawPlayer.Directions - Vector2.UnitX * (float) drawinfo.drawPlayer.direction * 4f;
      Rectangle r = texture2D.Frame(verticalFrames: 6, frameY: drawinfo.drawPlayer.wingFrame);
      r.Width -= 2;
      r.Height -= 2;
      drawinfo.DrawDataCache.Add(new DrawData(texture2D, vec.Floor(), new Rectangle?(r), color, drawinfo.drawPlayer.bodyRotation, r.Size() / 2f, 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.cWings
      });
    }
    else if (drawinfo.drawPlayer.wings == 51)
    {
      drawinfo.stealth *= drawinfo.stealth;
      drawinfo.stealth *= 1f - drawinfo.shadow;
      Color color = PlayerDrawLayers.GetLunaGlowColor(ref drawinfo, true) * drawinfo.stealth;
      Vector2 vector2_6 = new Vector2(0.0f, (double) drawinfo.drawPlayer.Directions.Y < 0.0 ? 8f : 6f);
      Texture2D texture2D = TextureAssets.Wings[drawinfo.drawPlayer.wings].Value;
      Vector2 vec = drawinfo.Position + new Vector2((float) (drawinfo.drawPlayer.width / 2), (float) (drawinfo.drawPlayer.height - drawinfo.drawPlayer.bodyFrame.Height / 2)) - Main.screenPosition + vector2_6 - Vector2.UnitX * (float) drawinfo.drawPlayer.direction * 4f;
      Rectangle r = texture2D.Frame(verticalFrames: 8, frameY: drawinfo.drawPlayer.wingFrame);
      r.Width -= 2;
      r.Height -= 2;
      drawinfo.DrawDataCache.Add(new DrawData(texture2D, vec.Floor(), new Rectangle?(r), color, drawinfo.drawPlayer.bodyRotation, r.Size() / 2f, 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.cWings
      });
    }
    else if (drawinfo.drawPlayer.wings == 47)
    {
      Color colorArmorBody = drawinfo.colorArmorBody;
      Color color = PlayerDrawLayers.GetChickenBonesGlowColor(ref drawinfo, true, true);
      drawinfo.stealth *= drawinfo.stealth;
      drawinfo.stealth *= 1f - drawinfo.shadow;
      if ((double) drawinfo.stealth == 1.0)
        color.A = (byte) 180;
      color = Color.Multiply(color, drawinfo.stealth);
      Vector2 vector2_7 = Main.OffsetsPlayerHeadgear[drawinfo.drawPlayer.bodyFrame.Y / drawinfo.drawPlayer.bodyFrame.Height];
      vector2_7.Y -= 2f;
      Vector2 vector2_8 = new Vector2(1f, 1f) + vector2_7;
      Texture2D texture2D = TextureAssets.Wings[drawinfo.drawPlayer.wings].Value;
      Vector2 vec = commonWingPosPreFloor + vector2_8 * drawinfo.drawPlayer.Directions - Vector2.UnitX * (float) drawinfo.drawPlayer.direction * 4f;
      Rectangle r = texture2D.Frame(verticalFrames: 11, frameY: drawinfo.drawPlayer.wingFrame);
      r.Width -= 2;
      r.Height -= 2;
      DrawData drawData = new DrawData(texture2D, vec.Floor(), new Rectangle?(r), colorArmorBody, drawinfo.drawPlayer.bodyRotation, r.Size() / 2f, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cWings;
      drawinfo.DrawDataCache.Add(drawData);
      drawData = new DrawData(TextureAssets.GlowMask[366].Value, vec.Floor(), new Rectangle?(r), color, drawinfo.drawPlayer.bodyRotation, r.Size() / 2f, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cWings;
      drawinfo.DrawDataCache.Add(drawData);
    }
    else if (drawinfo.drawPlayer.wings == 49)
    {
      Color colorArmorBody = drawinfo.colorArmorBody;
      Vector2 vector2_9 = Main.OffsetsPlayerHeadgear[drawinfo.drawPlayer.bodyFrame.Y / drawinfo.drawPlayer.bodyFrame.Height];
      vector2_9.Y -= 2f;
      Vector2 vector2_10 = new Vector2(1f, 1f) + vector2_9;
      Texture2D texture2D = TextureAssets.Wings[drawinfo.drawPlayer.wings].Value;
      Vector2 vec = commonWingPosPreFloor + vector2_10 * drawinfo.drawPlayer.Directions - Vector2.UnitX * (float) drawinfo.drawPlayer.direction * 4f;
      Rectangle r = texture2D.Frame(verticalFrames: 11, frameY: drawinfo.drawPlayer.wingFrame);
      r.Width -= 2;
      r.Height -= 2;
      drawinfo.DrawDataCache.Add(new DrawData(texture2D, vec.Floor(), new Rectangle?(r), colorArmorBody, drawinfo.drawPlayer.bodyRotation, r.Size() / 2f, 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.cWings
      });
    }
    else if (drawinfo.drawPlayer.wings == 48 /*0x30*/)
    {
      if (!drawinfo.drawPlayer.ShouldDrawWingsThatAreAlwaysAnimated())
        return;
      Color colorArmorBody = drawinfo.colorArmorBody;
      Vector2 vector2_11 = new Vector2(4f, 0.0f);
      Texture2D texture2D = TextureAssets.Wings[drawinfo.drawPlayer.wings].Value;
      Vector2 vec = drawinfo.Position + drawinfo.drawPlayer.Size / 2f - Main.screenPosition + vector2_11 * drawinfo.drawPlayer.Directions - Vector2.UnitX * (float) drawinfo.drawPlayer.direction * 4f;
      Rectangle r = texture2D.Frame(verticalFrames: 8, frameY: drawinfo.drawPlayer.wingFrame);
      r.Width -= 2;
      r.Height -= 2;
      drawinfo.DrawDataCache.Add(new DrawData(texture2D, vec.Floor(), new Rectangle?(r), colorArmorBody, drawinfo.drawPlayer.bodyRotation, r.Size() / 2f, 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.cWings
      });
    }
    else if (drawinfo.drawPlayer.wings == 40)
    {
      drawinfo.stealth *= drawinfo.stealth;
      drawinfo.stealth *= 1f - drawinfo.shadow;
      Color color = new Color((int) (250.0 * (double) drawinfo.stealth), (int) (250.0 * (double) drawinfo.stealth), (int) (250.0 * (double) drawinfo.stealth), (int) (100.0 * (double) drawinfo.stealth));
      Vector2 vector2_12 = new Vector2(-4f, 0.0f);
      Texture2D texture2D = TextureAssets.Wings[drawinfo.drawPlayer.wings].Value;
      Vector2 vector2_13 = commonWingPosPreFloor + vector2_12 * directions;
      for (int index = 0; index < 1; ++index)
      {
        SpriteEffects playerEffect = drawinfo.playerEffect;
        Vector2 scale = new Vector2(1f);
        Vector2 zero = Vector2.Zero with
        {
          X = (float) (drawinfo.drawPlayer.direction * 3)
        };
        if (index == 1)
        {
          playerEffect ^= SpriteEffects.FlipHorizontally;
          scale = new Vector2(0.7f, 1f);
          zero.X += (float) -drawinfo.drawPlayer.direction * 6f;
        }
        Vector2 vector2_14 = drawinfo.drawPlayer.velocity * -1.5f;
        int num3 = 0;
        int num4 = 8;
        float num5 = 4f;
        if ((double) drawinfo.drawPlayer.velocity.Y == 0.0)
        {
          num3 = 8;
          num4 = 14;
          num5 = 3f;
        }
        for (int frameY = num3; frameY < num4; ++frameY)
        {
          Vector2 vector2_15 = vector2_13;
          Rectangle r = texture2D.Frame(verticalFrames: 14, frameY: frameY);
          r.Width -= 2;
          r.Height -= 2;
          int num6 = (frameY - num3) % (int) num5;
          Vector2 vector2_16 = new Vector2(0.0f, 0.5f).RotatedBy(((double) drawinfo.drawPlayer.miscCounterNormalized * (2.0 + (double) num6) + (double) num6 * 0.5 + (double) index * 1.2999999523162842) * 6.2831854820251465) * (float) (num6 + 1);
          Vector2 vec = vector2_15 + vector2_16 + vector2_14 * ((float) num6 / num5) + zero;
          drawinfo.DrawDataCache.Add(new DrawData(texture2D, vec.Floor(), new Rectangle?(r), color, drawinfo.drawPlayer.bodyRotation, r.Size() / 2f, scale, playerEffect)
          {
            shader = drawinfo.cWings
          });
        }
      }
    }
    else if (drawinfo.drawPlayer.wings == 39)
    {
      if (!drawinfo.drawPlayer.ShouldDrawWingsThatAreAlwaysAnimated())
        return;
      drawinfo.stealth *= drawinfo.stealth;
      drawinfo.stealth *= 1f - drawinfo.shadow;
      Color colorArmorBody = drawinfo.colorArmorBody;
      Vector2 vector2_17 = new Vector2(-6f, -7f);
      Texture2D texture2D = TextureAssets.Wings[drawinfo.drawPlayer.wings].Value;
      Vector2 vec = commonWingPosPreFloor + vector2_17 * directions;
      Rectangle r = texture2D.Frame(verticalFrames: 6, frameY: drawinfo.drawPlayer.wingFrame);
      r.Width -= 2;
      r.Height -= 2;
      drawinfo.DrawDataCache.Add(new DrawData(texture2D, vec.Floor(), new Rectangle?(r), colorArmorBody, drawinfo.drawPlayer.bodyRotation, r.Size() / 2f, 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.cWings
      });
    }
    else if (drawinfo.drawPlayer.wings == 50)
    {
      Texture2D texture2D = TextureAssets.Wings[drawinfo.drawPlayer.wings].Value;
      Vector2 zero = Vector2.Zero;
      Vector2 vec = commonWingPosPreFloor + zero * drawinfo.drawPlayer.Directions - Vector2.UnitX * (float) drawinfo.drawPlayer.direction * 4f;
      int verticalFrames = 11;
      Rectangle rectangle = texture2D.Frame(verticalFrames: verticalFrames, frameY: drawinfo.drawPlayer.wingFrame);
      DrawData drawData = new DrawData(texture2D, vec.Floor(), new Rectangle?(rectangle), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / verticalFrames / 2)), 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cWings;
      drawinfo.DrawDataCache.Add(drawData);
      Color color = drawinfo.drawPlayer.GetImmuneAlphaPure(Color.White, drawinfo.shadow) * (drawinfo.stealth * drawinfo.stealth) * (1f - drawinfo.shadow);
      drawData = new DrawData(TextureAssets.Wings[drawinfo.drawPlayer.wings].Value, vec.Floor(), new Rectangle?(rectangle), color, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / verticalFrames / 2)), 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cWings;
      drawinfo.DrawDataCache.Add(drawData);
    }
    else
    {
      int num7 = 0;
      int num8 = 0;
      int num9 = 4;
      if (drawinfo.drawPlayer.wings == 43)
      {
        num8 = -5;
        num7 = -7;
        num9 = 7;
      }
      else if (drawinfo.drawPlayer.wings == 44)
        num9 = 7;
      else if (drawinfo.drawPlayer.wings == 5)
      {
        num8 = 4;
        num7 -= 4;
      }
      else if (drawinfo.drawPlayer.wings == 27)
        num8 = 3;
      else if (drawinfo.drawPlayer.wings == 41)
        num8 = -1;
      else if (drawinfo.drawPlayer.wings == 12)
      {
        num8 = -1;
        num7 = -1;
      }
      Color color4 = drawinfo.colorArmorBody;
      if (drawinfo.drawPlayer.wings == 9 || drawinfo.drawPlayer.wings == 29)
      {
        drawinfo.stealth *= drawinfo.stealth;
        drawinfo.stealth *= 1f - drawinfo.shadow;
        color4 = new Color((int) (250.0 * (double) drawinfo.stealth), (int) (250.0 * (double) drawinfo.stealth), (int) (250.0 * (double) drawinfo.stealth), (int) (100.0 * (double) drawinfo.stealth));
      }
      if (drawinfo.drawPlayer.wings == 10)
      {
        drawinfo.stealth *= drawinfo.stealth;
        drawinfo.stealth *= 1f - drawinfo.shadow;
        color4 = new Color((int) (250.0 * (double) drawinfo.stealth), (int) (250.0 * (double) drawinfo.stealth), (int) (250.0 * (double) drawinfo.stealth), (int) (175.0 * (double) drawinfo.stealth));
      }
      if (drawinfo.drawPlayer.wings == 11 && (int) color4.A > (int) Main.gFade)
        color4.A = Main.gFade;
      if (drawinfo.drawPlayer.wings == 31 /*0x1F*/)
        color4.A = (byte) (220.0 * (double) drawinfo.stealth);
      if (drawinfo.drawPlayer.wings == 32 /*0x20*/)
        color4.A = (byte) ((double) sbyte.MaxValue * (double) drawinfo.stealth);
      if (drawinfo.drawPlayer.wings == 6)
      {
        color4.A = (byte) (160.0 * (double) drawinfo.stealth);
        color4 *= 0.9f;
      }
      Vector2 vec = commonWingPosPreFloor + new Vector2((float) (num8 - 9), (float) (num7 + 2)) * directions;
      DrawData drawData = new DrawData(TextureAssets.Wings[drawinfo.drawPlayer.wings].Value, vec.Floor(), new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / num9 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / num9)), color4, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / num9 / 2)), 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cWings;
      drawinfo.DrawDataCache.Add(drawData);
      if (drawinfo.drawPlayer.wings == 43 && (double) drawinfo.shadow == 0.0)
      {
        float scale = drawinfo.stealth * drawinfo.stealth;
        Vector2 vector2_18 = vec;
        Vector2 origin = new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / num9 / 2));
        Rectangle rectangle = new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / num9 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / num9);
        for (int index = 0; index < 2; ++index)
        {
          Vector2 vector2_19 = new Vector2((float) Main.rand.Next(-10, 10) * 0.125f, (float) Main.rand.Next(-10, 10) * 0.125f);
          drawData = new DrawData(TextureAssets.GlowMask[272].Value, vector2_18 + vector2_19, new Rectangle?(rectangle), Color.Multiply(new Color(230, 230, 230, 60), scale), drawinfo.drawPlayer.bodyRotation, origin, 1f, drawinfo.playerEffect);
          drawData.shader = drawinfo.cWings;
          drawinfo.DrawDataCache.Add(drawData);
        }
      }
      if (drawinfo.drawPlayer.wings == 23)
      {
        drawinfo.stealth *= drawinfo.stealth;
        drawinfo.stealth *= 1f - drawinfo.shadow;
        color4 = new Color((int) (200.0 * (double) drawinfo.stealth), (int) (200.0 * (double) drawinfo.stealth), (int) (200.0 * (double) drawinfo.stealth), (int) (200.0 * (double) drawinfo.stealth));
        drawData = new DrawData(TextureAssets.Flames[8].Value, vec.Floor(), new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4)), color4, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 8)), 1f, drawinfo.playerEffect);
        drawData.shader = drawinfo.cWings;
        drawinfo.DrawDataCache.Add(drawData);
      }
      else if (drawinfo.drawPlayer.wings == 27)
      {
        drawData = new DrawData(TextureAssets.GlowMask[92].Value, vec.Floor(), new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4)), new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) sbyte.MaxValue) * drawinfo.stealth * (1f - drawinfo.shadow), drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 8)), 1f, drawinfo.playerEffect);
        drawData.shader = drawinfo.cWings;
        drawinfo.DrawDataCache.Add(drawData);
      }
      else if (drawinfo.drawPlayer.wings == 44)
      {
        PlayerRainbowWingsTextureContent playerRainbowWings = TextureAssets.RenderTargets.PlayerRainbowWings;
        playerRainbowWings.Request();
        if (!playerRainbowWings.IsReady)
          return;
        drawData = new DrawData((Texture2D) playerRainbowWings.GetTarget(), vec.Floor(), new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 7 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 7)), new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue) * drawinfo.stealth * (1f - drawinfo.shadow), drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 14)), 1f, drawinfo.playerEffect);
        drawData.shader = drawinfo.cWings;
        drawinfo.DrawDataCache.Add(drawData);
      }
      else if (drawinfo.drawPlayer.wings == 30)
      {
        drawData = new DrawData(TextureAssets.GlowMask[181].Value, vec.Floor(), new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4)), new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) sbyte.MaxValue) * drawinfo.stealth * (1f - drawinfo.shadow), drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 8)), 1f, drawinfo.playerEffect);
        drawData.shader = drawinfo.cWings;
        drawinfo.DrawDataCache.Add(drawData);
      }
      else if (drawinfo.drawPlayer.wings == 38)
      {
        Color color5 = drawinfo.ArkhalisColor * drawinfo.stealth * (1f - drawinfo.shadow);
        drawData = new DrawData(TextureAssets.GlowMask[251].Value, vec.Floor(), new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4)), color5, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 8)), 1f, drawinfo.playerEffect);
        drawData.shader = drawinfo.cWings;
        drawinfo.DrawDataCache.Add(drawData);
        for (int index = drawinfo.drawPlayer.shadowPos.Length - 2; index >= 0; --index)
        {
          Color color6 = color5 with { A = (byte) 0 } * MathHelper.Lerp(1f, 0.0f, (float) index / 3f) * 0.1f;
          Vector2 vector2_20 = drawinfo.drawPlayer.shadowPos[index] - drawinfo.drawPlayer.position;
          for (float num10 = 0.0f; (double) num10 < 1.0; num10 += 0.01f)
          {
            Vector2 vector2_21 = new Vector2(2f, 0.0f).RotatedBy((double) num10 / 0.039999999105930328 * 6.2831854820251465);
            drawData = new DrawData(TextureAssets.GlowMask[251].Value, vector2_21 + vector2_20 * num10 + vec, new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4)), color6 * (1f - num10), drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 8)), 1f, drawinfo.playerEffect);
            drawData.shader = drawinfo.cWings;
            drawinfo.DrawDataCache.Add(drawData);
          }
        }
      }
      else if (drawinfo.drawPlayer.wings == 29)
      {
        drawData = new DrawData(TextureAssets.Wings[drawinfo.drawPlayer.wings].Value, vec.Floor(), new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4)), new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * drawinfo.stealth * (1f - drawinfo.shadow) * 0.5f, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 8)), 1.06f, drawinfo.playerEffect);
        drawData.shader = drawinfo.cWings;
        drawinfo.DrawDataCache.Add(drawData);
      }
      else if (drawinfo.drawPlayer.wings == 36)
      {
        drawData = new DrawData(TextureAssets.GlowMask[213].Value, vec.Floor(), new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4)), new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * drawinfo.stealth * (1f - drawinfo.shadow), drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 8)), 1.06f, drawinfo.playerEffect);
        drawData.shader = drawinfo.cWings;
        drawinfo.DrawDataCache.Add(drawData);
        Vector2 spinningpoint = new Vector2(0.0f, (float) (2.0 - (double) drawinfo.shadow * 2.0));
        for (int index = 0; index < 4; ++index)
        {
          drawData = new DrawData(TextureAssets.GlowMask[213].Value, spinningpoint.RotatedBy(1.5707963705062866 * (double) index) + vec.Floor(), new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4)), new Color((int) sbyte.MaxValue, (int) sbyte.MaxValue, (int) sbyte.MaxValue, (int) sbyte.MaxValue) * drawinfo.stealth * (1f - drawinfo.shadow), drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 8)), 1f, drawinfo.playerEffect);
          drawData.shader = drawinfo.cWings;
          drawinfo.DrawDataCache.Add(drawData);
        }
      }
      else if (drawinfo.drawPlayer.wings == 31 /*0x1F*/)
      {
        Color color7 = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
        Color color8 = Color.Lerp(Color.HotPink, Color.Crimson, (float) (Math.Cos(6.2831854820251465 * ((double) drawinfo.drawPlayer.miscCounter / 100.0)) * 0.40000000596046448 + 0.5)) with
        {
          A = 0
        };
        for (int index = 0; index < 4; ++index)
        {
          Vector2 vector2_22 = new Vector2((float) (Math.Cos(6.2831854820251465 * ((double) drawinfo.drawPlayer.miscCounter / 60.0)) * 0.5 + 0.5), 0.0f).RotatedBy((double) index * 1.5707963705062866) * 1f;
          drawData = new DrawData(TextureAssets.Wings[drawinfo.drawPlayer.wings].Value, vec.Floor() + vector2_22, new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4)), color8 * drawinfo.stealth * (1f - drawinfo.shadow) * 0.5f, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 8)), 1f, drawinfo.playerEffect);
          drawData.shader = drawinfo.cWings;
          drawinfo.DrawDataCache.Add(drawData);
        }
        drawData = new DrawData(TextureAssets.Wings[drawinfo.drawPlayer.wings].Value, vec.Floor(), new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4)), color8 * drawinfo.stealth * (1f - drawinfo.shadow) * 1f, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 8)), 1f, drawinfo.playerEffect);
        drawData.shader = drawinfo.cWings;
        drawinfo.DrawDataCache.Add(drawData);
      }
      else
      {
        if (drawinfo.drawPlayer.wings != 32 /*0x20*/)
          return;
        drawData = new DrawData(TextureAssets.GlowMask[183].Value, vec.Floor(), new Rectangle?(new Rectangle(0, TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4 * drawinfo.drawPlayer.wingFrame, TextureAssets.Wings[drawinfo.drawPlayer.wings].Width(), TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 4)), new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * drawinfo.stealth * (1f - drawinfo.shadow), drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Width() / 2), (float) (TextureAssets.Wings[drawinfo.drawPlayer.wings].Height() / 8)), 1.06f, drawinfo.playerEffect);
        drawData.shader = drawinfo.cWings;
        drawinfo.DrawDataCache.Add(drawData);
      }
    }
  }

  public static void DrawPlayer_12_1_BalloonFronts(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.balloonFront <= (sbyte) 0 || (int) drawinfo.drawPlayer.balloonFront >= ArmorIDs.Balloon.Count)
      return;
    if (ArmorIDs.Balloon.Sets.UsesTorsoFraming[(int) drawinfo.drawPlayer.balloonFront])
    {
      drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.AccBalloon[(int) drawinfo.drawPlayer.balloonFront].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + drawinfo.bodyVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.cBalloonFront
      });
    }
    else
    {
      int num = FocusHelper.PausePlayerBalloonAnimations ? 0 : DateTime.Now.Millisecond % 800 / 200;
      Vector2 vector2_1 = Main.OffsetsPlayerOffhand[drawinfo.drawPlayer.bodyFrame.Y / 56];
      if (drawinfo.drawPlayer.direction != 1)
        vector2_1.X = (float) drawinfo.drawPlayer.width - vector2_1.X;
      if ((double) drawinfo.drawPlayer.gravDir != 1.0)
        vector2_1.Y -= (float) drawinfo.drawPlayer.height;
      Vector2 vector2_2 = new Vector2(0.0f, 8f) + new Vector2(0.0f, 6f);
      Vector2 vector2_3 = new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X + (double) vector2_1.X), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) vector2_1.Y * (double) drawinfo.drawPlayer.gravDir));
      Vector2 position = (drawinfo.Position - Main.screenPosition + vector2_1 * new Vector2(1f, drawinfo.drawPlayer.gravDir) + new Vector2(0.0f, (float) (drawinfo.drawPlayer.height - drawinfo.drawPlayer.bodyFrame.Height)) + vector2_2).Floor();
      drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.AccBalloon[(int) drawinfo.drawPlayer.balloonFront].Value, position, new Rectangle?(new Rectangle(0, TextureAssets.AccBalloon[(int) drawinfo.drawPlayer.balloonFront].Height() / 4 * num, TextureAssets.AccBalloon[(int) drawinfo.drawPlayer.balloonFront].Width(), TextureAssets.AccBalloon[(int) drawinfo.drawPlayer.balloonFront].Height() / 4)), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (26 + drawinfo.drawPlayer.direction * 4), (float) (28.0 + (double) drawinfo.drawPlayer.gravDir * 6.0)), 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.cBalloonFront
      });
    }
  }

  public static void DrawPlayer_11_Balloons(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.balloon <= (sbyte) 0 || (int) drawinfo.drawPlayer.balloon >= ArmorIDs.Balloon.Count)
      return;
    if (ArmorIDs.Balloon.Sets.UsesTorsoFraming[(int) drawinfo.drawPlayer.balloon])
    {
      drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.AccBalloon[(int) drawinfo.drawPlayer.balloon].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + drawinfo.bodyVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.cBalloon
      });
    }
    else
    {
      int num = FocusHelper.PausePlayerBalloonAnimations ? 0 : DateTime.Now.Millisecond % 800 / 200;
      Vector2 vector2_1 = Main.OffsetsPlayerOffhand[drawinfo.drawPlayer.bodyFrame.Y / 56];
      if (drawinfo.drawPlayer.direction != 1)
        vector2_1.X = (float) drawinfo.drawPlayer.width - vector2_1.X;
      if ((double) drawinfo.drawPlayer.gravDir != 1.0)
        vector2_1.Y -= (float) drawinfo.drawPlayer.height;
      Vector2 vector2_2 = new Vector2(0.0f, 8f) + new Vector2(0.0f, 6f);
      Vector2 vector2_3 = new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X + (double) vector2_1.X), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) vector2_1.Y * (double) drawinfo.drawPlayer.gravDir));
      Vector2 position = (drawinfo.Position - Main.screenPosition + vector2_1 * new Vector2(1f, drawinfo.drawPlayer.gravDir) + new Vector2(0.0f, (float) (drawinfo.drawPlayer.height - drawinfo.drawPlayer.bodyFrame.Height)) + vector2_2).Floor();
      drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.AccBalloon[(int) drawinfo.drawPlayer.balloon].Value, position, new Rectangle?(new Rectangle(0, TextureAssets.AccBalloon[(int) drawinfo.drawPlayer.balloon].Height() / 4 * num, TextureAssets.AccBalloon[(int) drawinfo.drawPlayer.balloon].Width(), TextureAssets.AccBalloon[(int) drawinfo.drawPlayer.balloon].Height() / 4)), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (26 + drawinfo.drawPlayer.direction * 4), (float) (28.0 + (double) drawinfo.drawPlayer.gravDir * 6.0)), 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.cBalloon
      });
    }
  }

  public static void DrawPlayer_12_Skin(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.usesCompositeTorso)
    {
      PlayerDrawLayers.DrawPlayer_12_Skin_Composite(ref drawinfo);
    }
    else
    {
      if (drawinfo.isSitting)
        drawinfo.hidesBottomSkin = true;
      DrawData drawData;
      if (!drawinfo.hidesTopSkin)
      {
        drawinfo.Position.Y += drawinfo.torsoOffset;
        drawData = new DrawData(TextureAssets.Players[drawinfo.skinVar, 3].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorBodySkin, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect)
        {
          shader = drawinfo.skinDyePacked
        };
        drawinfo.DrawDataCache.Add(drawData);
        drawinfo.Position.Y -= drawinfo.torsoOffset;
      }
      if (drawinfo.hidesBottomSkin || PlayerDrawLayers.IsBottomOverridden(ref drawinfo))
        return;
      if (drawinfo.isSitting)
      {
        PlayerDrawLayers.DrawSittingLegs(ref drawinfo, TextureAssets.Players[drawinfo.skinVar, 10].Value, drawinfo.colorLegs, legIndex: drawinfo.drawPlayer.legs, skin: true);
      }
      else
      {
        drawData = new DrawData(TextureAssets.Players[drawinfo.skinVar, 10].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.legFrame), drawinfo.colorLegs, drawinfo.drawPlayer.legRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
        drawinfo.DrawDataCache.Add(drawData);
      }
    }
  }

  public static bool IsBottomOverridden(ref PlayerDrawSet drawinfo)
  {
    return PlayerDrawLayers.ShouldOverrideLegs_CheckPants(ref drawinfo) || PlayerDrawLayers.ShouldOverrideLegs_CheckShoes(ref drawinfo);
  }

  public static bool ShouldOverrideLegs_CheckPants(ref PlayerDrawSet drawinfo)
  {
    switch (drawinfo.drawPlayer.legs)
    {
      case 55:
      case 63 /*0x3F*/:
      case 67:
      case 106:
      case 138:
      case 140:
      case 143:
      case 217:
      case 222:
      case 226:
      case 228:
        return true;
      default:
        return false;
    }
  }

  public static bool ShouldOverrideLegs_CheckShoes(ref PlayerDrawSet drawinfo)
  {
    return drawinfo.drawPlayer.shoe == (sbyte) 15;
  }

  public static void DrawPlayer_12_Skin_Composite(ref PlayerDrawSet drawinfo)
  {
    DrawData drawData1;
    if (!drawinfo.hidesTopSkin && !drawinfo.drawPlayer.invis)
    {
      Vector2 vector2_1 = new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2));
      vector2_1.Y += drawinfo.torsoOffset;
      Vector2 vector2_2 = Main.OffsetsPlayerHeadgear[drawinfo.drawPlayer.bodyFrame.Y / drawinfo.drawPlayer.bodyFrame.Height];
      vector2_2.Y -= 2f;
      Vector2 position = vector2_1 + vector2_2 * (float) -((drawinfo.playerEffect & SpriteEffects.FlipVertically) != 0).ToDirectionInt();
      float bodyRotation = drawinfo.drawPlayer.bodyRotation;
      Vector2 vector2_3 = position;
      Vector2 vector2_4 = position;
      Vector2 bodyVect1 = drawinfo.bodyVect;
      Vector2 bodyVect2 = drawinfo.bodyVect;
      Vector2 compositeOffsetBackArm = PlayerDrawLayers.GetCompositeOffset_BackArm(ref drawinfo);
      Vector2 vector2_5 = vector2_3 + compositeOffsetBackArm;
      Vector2 vector2_6 = compositeOffsetBackArm;
      Vector2 vector2_7 = bodyVect1 + vector2_6;
      Vector2 compositeOffsetFrontArm = PlayerDrawLayers.GetCompositeOffset_FrontArm(ref drawinfo);
      Vector2 vector2_8 = bodyVect2 + compositeOffsetFrontArm;
      Vector2 vector2_9 = compositeOffsetFrontArm;
      Vector2 vector2_10 = vector2_4 + vector2_9;
      if (drawinfo.drawFloatingTube)
      {
        List<DrawData> drawDataCache = drawinfo.DrawDataCache;
        drawData1 = new DrawData(TextureAssets.Extra[105].Value, position, new Rectangle?(new Rectangle(0, 0, 40, 56)), drawinfo.floatingTubeColor, bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
        drawData1.shader = drawinfo.cFloatingTube;
        DrawData drawData2 = drawData1;
        drawDataCache.Add(drawData2);
      }
      List<DrawData> drawDataCache1 = drawinfo.DrawDataCache;
      drawData1 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 3].Value, position, new Rectangle?(drawinfo.compTorsoFrame), drawinfo.colorBodySkin, bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
      drawData1.shader = drawinfo.skinDyePacked;
      DrawData drawData3 = drawData1;
      drawDataCache1.Add(drawData3);
    }
    if (!drawinfo.hidesBottomSkin && !drawinfo.drawPlayer.invis && !PlayerDrawLayers.IsBottomOverridden(ref drawinfo))
    {
      if (drawinfo.isSitting)
      {
        PlayerDrawLayers.DrawSittingLegs(ref drawinfo, TextureAssets.Players[drawinfo.skinVar, 10].Value, drawinfo.colorLegs, drawinfo.skinDyePacked, drawinfo.drawPlayer.legs, skin: true);
      }
      else
      {
        drawData1 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 10].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.legFrame), drawinfo.colorLegs, drawinfo.drawPlayer.legRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
        drawData1.shader = drawinfo.skinDyePacked;
        DrawData drawData4 = drawData1;
        drawinfo.DrawDataCache.Add(drawData4);
      }
    }
    PlayerDrawLayers.DrawPlayer_12_SkinComposite_BackArmShirt(ref drawinfo);
  }

  public static void DrawPlayer_12_SkinComposite_BackArmShirt(ref PlayerDrawSet drawinfo)
  {
    Vector2 vector2_1 = new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2));
    Vector2 vector2_2 = Main.OffsetsPlayerHeadgear[drawinfo.drawPlayer.bodyFrame.Y / drawinfo.drawPlayer.bodyFrame.Height];
    vector2_2.Y -= 2f;
    Vector2 vector2_3 = vector2_1 + vector2_2 * (float) -((drawinfo.playerEffect & SpriteEffects.FlipVertically) != 0).ToDirectionInt();
    vector2_3.Y += drawinfo.torsoOffset;
    float bodyRotation = drawinfo.drawPlayer.bodyRotation;
    Vector2 vector2_4 = vector2_3;
    Vector2 vector2_5 = vector2_3;
    Vector2 bodyVect = drawinfo.bodyVect;
    Vector2 compositeOffsetBackArm = PlayerDrawLayers.GetCompositeOffset_BackArm(ref drawinfo);
    Vector2 position1 = vector2_4 + compositeOffsetBackArm;
    Vector2 position2 = vector2_5 + drawinfo.backShoulderOffset;
    Vector2 origin1 = bodyVect + compositeOffsetBackArm;
    float rotation = bodyRotation + drawinfo.compositeBackArmRotation;
    bool flag1 = !drawinfo.drawPlayer.invis;
    bool flag2 = !drawinfo.drawPlayer.invis;
    bool flag3 = drawinfo.drawPlayer.body > 0 && drawinfo.drawPlayer.body < ArmorIDs.Body.Count;
    bool flag4 = drawinfo.drawPlayer.coat > 0 && drawinfo.drawPlayer.coat < ArmorIDs.Body.Count;
    bool flag5 = !drawinfo.hidesTopSkin;
    bool flag6 = false;
    DrawData drawData1;
    if (flag3)
    {
      flag1 &= drawinfo.missingHand;
      if (flag2 && drawinfo.missingArm)
      {
        if (flag5)
        {
          List<DrawData> drawDataCache = drawinfo.DrawDataCache;
          drawData1 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 7].Value, position1, new Rectangle?(drawinfo.compBackArmFrame), drawinfo.colorBodySkin, rotation, origin1, 1f, drawinfo.playerEffect);
          drawData1.shader = drawinfo.skinDyePacked;
          DrawData drawData2 = drawData1;
          drawDataCache.Add(drawData2);
        }
        if (!flag6 & flag5)
        {
          List<DrawData> drawDataCache = drawinfo.DrawDataCache;
          drawData1 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 5].Value, position1, new Rectangle?(drawinfo.compBackArmFrame), drawinfo.colorBodySkin, rotation, origin1, 1f, drawinfo.playerEffect);
          drawData1.shader = drawinfo.skinDyePacked;
          DrawData drawData3 = drawData1;
          drawDataCache.Add(drawData3);
          flag6 = true;
        }
        flag2 = false;
      }
      if (!drawinfo.drawPlayer.invis || PlayerDrawLayers.IsArmorDrawnWhenInvisible(drawinfo.drawPlayer.body))
      {
        Texture2D texture1 = TextureAssets.ArmorBodyComposite[drawinfo.drawPlayer.body].Value;
        if (!drawinfo.hideCompositeShoulders)
        {
          ref PlayerDrawSet local1 = ref drawinfo;
          drawData1 = new DrawData(texture1, position2, new Rectangle?(drawinfo.compBackShoulderFrame), drawinfo.colorArmorBody, bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
          drawData1.shader = drawinfo.cBody;
          DrawData data1 = drawData1;
          int body1 = drawinfo.drawPlayer.body;
          PlayerDrawLayers.DrawCompositeArmorPiece(ref local1, CompositePlayerDrawContext.BackShoulder, data1, body1);
          if (drawinfo.drawPlayer.body == 71)
          {
            Texture2D texture2 = TextureAssets.Extra[277].Value;
            ref PlayerDrawSet local2 = ref drawinfo;
            drawData1 = new DrawData(texture2, position2, new Rectangle?(drawinfo.compBackShoulderFrame), drawinfo.colorArmorBody, bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
            drawData1.shader = 0;
            DrawData data2 = drawData1;
            int body2 = drawinfo.drawPlayer.body;
            PlayerDrawLayers.DrawCompositeArmorPiece(ref local2, CompositePlayerDrawContext.BackShoulder, data2, body2);
          }
        }
        PlayerDrawLayers.DrawPlayer_12_1_BalloonFronts(ref drawinfo);
        ref PlayerDrawSet local3 = ref drawinfo;
        drawData1 = new DrawData(texture1, position1, new Rectangle?(drawinfo.compBackArmFrame), drawinfo.colorArmorBody, rotation, origin1, 1f, drawinfo.playerEffect);
        drawData1.shader = drawinfo.cBody;
        DrawData data3 = drawData1;
        int body3 = drawinfo.drawPlayer.body;
        PlayerDrawLayers.DrawCompositeArmorPiece(ref local3, CompositePlayerDrawContext.BackArm, data3, body3);
        if (drawinfo.drawPlayer.body == 71)
        {
          Texture2D texture3 = TextureAssets.Extra[277].Value;
          ref PlayerDrawSet local4 = ref drawinfo;
          drawData1 = new DrawData(texture3, position1, new Rectangle?(drawinfo.compBackArmFrame), drawinfo.colorArmorBody, rotation, origin1, 1f, drawinfo.playerEffect);
          drawData1.shader = 0;
          DrawData data4 = drawData1;
          int body4 = drawinfo.drawPlayer.body;
          PlayerDrawLayers.DrawCompositeArmorPiece(ref local4, CompositePlayerDrawContext.BackArm, data4, body4);
        }
      }
    }
    if (flag1)
    {
      if (flag5)
      {
        if (flag2)
        {
          List<DrawData> drawDataCache = drawinfo.DrawDataCache;
          drawData1 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 7].Value, position1, new Rectangle?(drawinfo.compBackArmFrame), drawinfo.colorBodySkin, rotation, origin1, 1f, drawinfo.playerEffect);
          drawData1.shader = drawinfo.skinDyePacked;
          DrawData drawData4 = drawData1;
          drawDataCache.Add(drawData4);
        }
        if (!flag6 & flag5)
        {
          List<DrawData> drawDataCache = drawinfo.DrawDataCache;
          drawData1 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 5].Value, position1, new Rectangle?(drawinfo.compBackArmFrame), drawinfo.colorBodySkin, rotation, origin1, 1f, drawinfo.playerEffect);
          drawData1.shader = drawinfo.skinDyePacked;
          DrawData drawData5 = drawData1;
          drawDataCache.Add(drawData5);
        }
      }
      if (!flag3)
      {
        drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.Players[drawinfo.skinVar, 8].Value, position1, new Rectangle?(drawinfo.compBackArmFrame), drawinfo.colorUnderShirt, rotation, origin1, 1f, drawinfo.playerEffect));
        PlayerDrawLayers.DrawPlayer_12_1_BalloonFronts(ref drawinfo);
        drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.Players[drawinfo.skinVar, 13].Value, position1, new Rectangle?(drawinfo.compBackArmFrame), drawinfo.colorShirt, rotation, origin1, 1f, drawinfo.playerEffect));
      }
    }
    if (flag4 && (!drawinfo.drawPlayer.invis || PlayerDrawLayers.IsArmorDrawnWhenInvisible(drawinfo.drawPlayer.coat)))
    {
      Texture2D texture = TextureAssets.ArmorBodyComposite[drawinfo.drawPlayer.coat].Value;
      if (!drawinfo.hideCompositeShoulders)
      {
        ref PlayerDrawSet local = ref drawinfo;
        drawData1 = new DrawData(texture, position2, new Rectangle?(drawinfo.compBackShoulderFrame), drawinfo.colorArmorBody, bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
        drawData1.shader = drawinfo.cCoat;
        DrawData data = drawData1;
        int coat = drawinfo.drawPlayer.coat;
        PlayerDrawLayers.DrawCompositeArmorPiece(ref local, CompositePlayerDrawContext.BackShoulder, data, coat);
      }
      ref PlayerDrawSet local5 = ref drawinfo;
      drawData1 = new DrawData(texture, position1, new Rectangle?(drawinfo.compBackArmFrame), drawinfo.colorArmorBody, rotation, origin1, 1f, drawinfo.playerEffect);
      drawData1.shader = drawinfo.cCoat;
      DrawData data5 = drawData1;
      int coat1 = drawinfo.drawPlayer.coat;
      PlayerDrawLayers.DrawCompositeArmorPiece(ref local5, CompositePlayerDrawContext.BackArm, data5, coat1);
    }
    if (drawinfo.drawPlayer.handoff > (sbyte) 0 && (int) drawinfo.drawPlayer.handoff < ArmorIDs.HandOff.Count)
    {
      Texture2D texture = TextureAssets.AccHandsOffComposite[(int) drawinfo.drawPlayer.handoff].Value;
      ref PlayerDrawSet local = ref drawinfo;
      drawData1 = new DrawData(texture, position1, new Rectangle?(drawinfo.compBackArmFrame), drawinfo.colorArmorBody, rotation, origin1, 1f, drawinfo.playerEffect);
      drawData1.shader = drawinfo.cHandOff;
      DrawData data = drawData1;
      PlayerDrawLayers.DrawCompositeArmorPiece(ref local, CompositePlayerDrawContext.BackArmAccessory, data, -1);
    }
    if (!drawinfo.drawPlayer.drawingFootball)
      return;
    Main.instance.LoadProjectile(861);
    Texture2D texture2D = TextureAssets.Projectile[861].Value;
    Rectangle r = texture2D.Frame(verticalFrames: 4);
    Vector2 origin2 = r.Size() / 2f;
    Vector2 position3 = position1 + new Vector2((float) (drawinfo.drawPlayer.direction * -2), drawinfo.drawPlayer.gravDir * 4f);
    drawinfo.DrawDataCache.Add(new DrawData(texture2D, position3, new Rectangle?(r), drawinfo.colorArmorBody, bodyRotation + 0.7853982f * (float) drawinfo.drawPlayer.direction, origin2, 0.8f, drawinfo.playerEffect));
  }

  public static void DrawPlayer_13_ArmorBackCoat(ref PlayerDrawSet drawinfo)
  {
    int bodyExtensionBack = PlayerDrawLayers.GetMatchingBodyExtensionBack(ref drawinfo, drawinfo.drawPlayer.coat);
    if (bodyExtensionBack == -1)
      return;
    Main.instance.LoadArmorLegs(bodyExtensionBack);
    if (drawinfo.isSitting && bodyExtensionBack != 195)
      PlayerDrawLayers.DrawSittingLegs(ref drawinfo, TextureAssets.ArmorLeg[bodyExtensionBack].Value, drawinfo.colorArmorBody, drawinfo.cCoat, bodyExtensionBack, new Vector2(0.0f, drawinfo.seatYOffset));
    else
      PlayerDrawLayers.DrawLongCoat(ref drawinfo, ref new DrawData(TextureAssets.ArmorLeg[bodyExtensionBack].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.legFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.legFrame.Height + 4.0)) + drawinfo.drawPlayer.legPosition + drawinfo.legVect, new Rectangle?(drawinfo.drawPlayer.legFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.legRotation, drawinfo.legVect, 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.cCoat
      }, bodyExtensionBack);
  }

  public static void DrawPlayer_13_Leggings(ref PlayerDrawSet drawinfo)
  {
    Vector2 legsOffset1 = drawinfo.legsOffset;
    if (drawinfo.drawPlayer.legs == 169)
      return;
    if (drawinfo.isSitting && drawinfo.drawPlayer.legs != 140)
    {
      if (drawinfo.drawPlayer.legs > 0 && drawinfo.drawPlayer.legs < ArmorIDs.Legs.Count && (!PlayerDrawLayers.ShouldOverrideLegs_CheckShoes(ref drawinfo) || drawinfo.drawPlayer.wearsRobe))
      {
        if (drawinfo.drawPlayer.invis)
          return;
        PlayerDrawLayers.DrawSittingLegs(ref drawinfo, TextureAssets.ArmorLeg[drawinfo.drawPlayer.legs].Value, drawinfo.colorArmorLegs, drawinfo.cLegs, drawinfo.drawPlayer.legs);
        if (drawinfo.drawPlayer.legs == 60)
        {
          Texture2D textureToDraw = TextureAssets.Extra[278].Value;
          PlayerDrawLayers.DrawSittingLegs(ref drawinfo, textureToDraw, drawinfo.colorArmorLegs, legIndex: drawinfo.drawPlayer.legs);
        }
        if (drawinfo.legsGlowMask == -1)
          return;
        if (drawinfo.legsGlowMask == 274)
        {
          Vector2 legsOffset2 = drawinfo.legsOffset;
          for (int index = 0; index < 2; ++index)
          {
            Vector2 vector2 = new Vector2((float) Main.rand.Next(-10, 10) * 0.125f, (float) Main.rand.Next(-10, 10) * 0.125f);
            drawinfo.legsOffset += vector2;
            PlayerDrawLayers.DrawSittingLegs(ref drawinfo, TextureAssets.GlowMask[drawinfo.legsGlowMask].Value, drawinfo.legsGlowColor, drawinfo.cLegs, drawinfo.drawPlayer.legs);
            drawinfo.legsOffset = legsOffset2;
          }
        }
        else
          PlayerDrawLayers.DrawSittingLegs(ref drawinfo, TextureAssets.GlowMask[drawinfo.legsGlowMask].Value, drawinfo.legsGlowColor, drawinfo.cLegs, drawinfo.drawPlayer.legs);
      }
      else
      {
        if (drawinfo.drawPlayer.invis || PlayerDrawLayers.ShouldOverrideLegs_CheckShoes(ref drawinfo))
          return;
        PlayerDrawLayers.DrawSittingLegs(ref drawinfo, TextureAssets.Players[drawinfo.skinVar, 11].Value, drawinfo.colorPants, legIndex: drawinfo.drawPlayer.legs, skin: true);
        PlayerDrawLayers.DrawSittingLegs(ref drawinfo, TextureAssets.Players[drawinfo.skinVar, 12].Value, drawinfo.colorShoes, legIndex: drawinfo.drawPlayer.legs, skin: true);
      }
    }
    else if (drawinfo.drawPlayer.legs == 140)
    {
      if (drawinfo.drawPlayer.invis || drawinfo.drawPlayer.mount.Active)
        return;
      Texture2D texture = TextureAssets.Extra[73].Value;
      bool flag = drawinfo.drawPlayer.legFrame.Y != drawinfo.drawPlayer.legFrame.Height || Main.gameMenu;
      int num1 = drawinfo.drawPlayer.miscCounter / 3 % 8;
      if (flag)
        num1 = drawinfo.drawPlayer.miscCounter / 4 % 8;
      Rectangle r = new Rectangle(18 * flag.ToInt(), num1 * 26, 16 /*0x10*/, 24);
      float num2 = 12f;
      if (drawinfo.drawPlayer.bodyFrame.Height != 0)
        num2 = 12f - Main.OffsetsPlayerHeadgear[drawinfo.drawPlayer.bodyFrame.Y / drawinfo.drawPlayer.bodyFrame.Height].Y;
      if ((double) drawinfo.drawPlayer.Directions.Y == -1.0)
        num2 -= 6f;
      Vector2 scale = new Vector2(1f, 1f);
      Vector2 vector2_1 = drawinfo.Position + drawinfo.drawPlayer.Size * new Vector2(0.5f, (float) (0.5 + 0.5 * (double) drawinfo.drawPlayer.gravDir));
      int direction = drawinfo.drawPlayer.direction;
      Vector2 vector2_2 = new Vector2(0.0f, -num2 * drawinfo.drawPlayer.gravDir);
      Vector2 vector2_3 = vector2_1 + vector2_2 - Main.screenPosition + drawinfo.drawPlayer.legPosition;
      if (drawinfo.isSitting)
        vector2_3.Y += drawinfo.seatYOffset;
      Vector2 position = (vector2_3 + legsOffset1).Floor();
      drawinfo.DrawDataCache.Add(new DrawData(texture, position, new Rectangle?(r), drawinfo.colorArmorLegs, drawinfo.drawPlayer.legRotation, r.Size() * new Vector2(0.5f, (float) (0.5 - (double) drawinfo.drawPlayer.gravDir * 0.5)), scale, drawinfo.playerEffect)
      {
        shader = drawinfo.cLegs
      });
    }
    else if (drawinfo.drawPlayer.legs > 0 && drawinfo.drawPlayer.legs < ArmorIDs.Legs.Count && (!PlayerDrawLayers.ShouldOverrideLegs_CheckShoes(ref drawinfo) || drawinfo.drawPlayer.wearsRobe))
    {
      if (drawinfo.drawPlayer.invis)
        return;
      DrawData drawData = new DrawData(TextureAssets.ArmorLeg[drawinfo.drawPlayer.legs].Value, legsOffset1 + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.legFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.legFrame.Height + 4.0)) + drawinfo.drawPlayer.legPosition + drawinfo.legVect, new Rectangle?(drawinfo.drawPlayer.legFrame), drawinfo.colorArmorLegs, drawinfo.drawPlayer.legRotation, drawinfo.legVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cLegs;
      drawinfo.DrawDataCache.Add(drawData);
      if (drawinfo.drawPlayer.legs == 60)
      {
        drawData = new DrawData(TextureAssets.Extra[278].Value, legsOffset1 + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.legFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.legFrame.Height + 4.0)) + drawinfo.drawPlayer.legPosition + drawinfo.legVect, new Rectangle?(drawinfo.drawPlayer.legFrame), drawinfo.colorArmorLegs, drawinfo.drawPlayer.legRotation, drawinfo.legVect, 1f, drawinfo.playerEffect);
        drawData.shader = 0;
        drawinfo.DrawDataCache.Add(drawData);
      }
      if (drawinfo.legsGlowMask == -1)
        return;
      if (drawinfo.legsGlowMask == 274)
      {
        for (int index = 0; index < 2; ++index)
        {
          Vector2 vector2 = new Vector2((float) Main.rand.Next(-10, 10) * 0.125f, (float) Main.rand.Next(-10, 10) * 0.125f);
          drawData = new DrawData(TextureAssets.GlowMask[drawinfo.legsGlowMask].Value, legsOffset1 + vector2 + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.legFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.legFrame.Height + 4.0)) + drawinfo.drawPlayer.legPosition + drawinfo.legVect, new Rectangle?(drawinfo.drawPlayer.legFrame), drawinfo.legsGlowColor, drawinfo.drawPlayer.legRotation, drawinfo.legVect, 1f, drawinfo.playerEffect);
          drawData.shader = drawinfo.cLegs;
          drawinfo.DrawDataCache.Add(drawData);
        }
      }
      else
      {
        drawData = new DrawData(TextureAssets.GlowMask[drawinfo.legsGlowMask].Value, legsOffset1 + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.legFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.legFrame.Height + 4.0)) + drawinfo.drawPlayer.legPosition + drawinfo.legVect, new Rectangle?(drawinfo.drawPlayer.legFrame), drawinfo.legsGlowColor, drawinfo.drawPlayer.legRotation, drawinfo.legVect, 1f, drawinfo.playerEffect);
        drawData.shader = drawinfo.cLegs;
        drawinfo.DrawDataCache.Add(drawData);
      }
    }
    else
    {
      if (drawinfo.drawPlayer.invis || PlayerDrawLayers.ShouldOverrideLegs_CheckShoes(ref drawinfo))
        return;
      DrawData drawData = new DrawData(TextureAssets.Players[drawinfo.skinVar, 11].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.legFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.legFrame.Height + 4.0)) + drawinfo.drawPlayer.legPosition + drawinfo.legVect, new Rectangle?(drawinfo.drawPlayer.legFrame), drawinfo.colorPants, drawinfo.drawPlayer.legRotation, drawinfo.legVect, 1f, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData);
      drawData = new DrawData(TextureAssets.Players[drawinfo.skinVar, 12].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.legFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.legFrame.Height + 4.0)) + drawinfo.drawPlayer.legPosition + drawinfo.legVect, new Rectangle?(drawinfo.drawPlayer.legFrame), drawinfo.colorShoes, drawinfo.drawPlayer.legRotation, drawinfo.legVect, 1f, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData);
    }
  }

  private static void DrawSittingLegs(
    ref PlayerDrawSet drawinfo,
    Texture2D textureToDraw,
    Color matchingColor,
    int shaderIndex = 0,
    int legIndex = -1,
    Vector2 offset = default (Vector2),
    bool skin = false)
  {
    Vector2 legsOffset = drawinfo.legsOffset;
    Vector2 vector2_1 = new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.legFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.legFrame.Height + 4.0)) + drawinfo.drawPlayer.legPosition + drawinfo.legVect;
    Rectangle legFrame = drawinfo.drawPlayer.legFrame;
    vector2_1.Y -= 2f;
    vector2_1.Y += drawinfo.seatYOffset;
    Vector2 vector2_2 = vector2_1 + legsOffset + offset;
    int x = 2;
    int num1 = 42;
    int num2 = 2;
    int num3 = 2;
    int num4 = 0;
    int num5 = 0;
    int num6 = 0;
    bool flag1 = false;
    bool flag2 = false;
    if (legIndex == 169 || !skin)
    {
      switch (legIndex)
      {
        case 106:
        case 143:
        case 226:
          x = 0;
          num3 = 0;
          num1 = 6;
          vector2_2.Y += 4f;
          legFrame.Y = legFrame.Height * 5;
          break;
        case 132:
          x = -2;
          num6 = 2;
          break;
        case 149:
        case 171:
        case 172:
          x = -6;
          num3 = 2;
          num4 = 2;
          num2 = 4;
          num1 = 6;
          legFrame = drawinfo.drawPlayer.legFrame;
          vector2_2.Y += 6f;
          vector2_2.Y -= drawinfo.seatYOffset;
          break;
        case 169:
          if (skin)
          {
            x = -6;
            num3 = 2;
            num4 = 2;
            num2 = 4;
            num1 = 6;
            legFrame = drawinfo.drawPlayer.legFrame;
            vector2_2.Y += 6f;
            break;
          }
          x = 0;
          num3 = 0;
          num4 = 0;
          num2 = 1;
          num1 = 0;
          legFrame = drawinfo.drawPlayer.legFrame;
          vector2_2.Y -= drawinfo.seatYOffset;
          flag1 = true;
          break;
        case 193:
        case 194:
          if (drawinfo.drawPlayer.body == 218)
          {
            x = -2;
            num6 = 2;
            vector2_2.Y += 2f;
            break;
          }
          break;
        case 214:
        case 215:
        case 216:
          x = -6;
          num3 = 2;
          num4 = 2;
          num2 = 4;
          num1 = 6;
          legFrame = drawinfo.drawPlayer.legFrame;
          vector2_2.Y += 6f;
          break;
        case 217:
          x = 0;
          num3 = 0;
          num4 = 0;
          num2 = 1;
          num1 = 0;
          legFrame = drawinfo.drawPlayer.legFrame;
          flag2 = true;
          break;
        case 222:
          vector2_2.X -= 2f * drawinfo.drawPlayer.Directions.X;
          break;
        case 223:
          vector2_2.X -= 2f * drawinfo.drawPlayer.Directions.X;
          vector2_2.Y -= drawinfo.seatYOffset;
          break;
        case 238:
        case 239:
          x = 2;
          num3 = 2;
          num4 = -2;
          num1 = 42;
          vector2_2.Y -= drawinfo.seatYOffset;
          flag1 = true;
          break;
      }
    }
    for (int index = num2; index >= 0; --index)
    {
      Vector2 position = vector2_2 + new Vector2((float) x, 2f) * new Vector2((float) drawinfo.drawPlayer.direction, 1f);
      Rectangle rectangle = legFrame;
      if (!flag2)
      {
        rectangle.Y += index * 2;
        rectangle.Y += num1;
        rectangle.Height -= num1;
        rectangle.Height -= index * 2;
        if (index != num2)
          rectangle.Height = 2;
      }
      position.X += (float) (drawinfo.drawPlayer.direction * num3 * index + num5 * drawinfo.drawPlayer.direction);
      if (index != 0)
        position.X += (float) (num6 * drawinfo.drawPlayer.direction);
      position.Y += (float) num1;
      position.Y += (float) num4;
      DrawData cdd = new DrawData(textureToDraw, position, new Rectangle?(rectangle), matchingColor, drawinfo.drawPlayer.legRotation, drawinfo.legVect, 1f, drawinfo.playerEffect);
      cdd.shader = shaderIndex;
      if (flag1)
        PlayerDrawLayers.DrawLongCoat(ref drawinfo, ref cdd, legIndex);
      else
        drawinfo.DrawDataCache.Add(cdd);
    }
  }

  public static void DrawPlayer_14_Shoes(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.shoe <= (sbyte) 0 || (int) drawinfo.drawPlayer.shoe >= ArmorIDs.Shoe.Count || PlayerDrawLayers.ShouldOverrideLegs_CheckPants(ref drawinfo))
      return;
    Vector2 shoeDrawOffset = drawinfo.drawPlayer.GetShoeDrawOffset();
    int shaderIndex = drawinfo.cShoe;
    if (drawinfo.drawPlayer.shoe == (sbyte) 22 || drawinfo.drawPlayer.shoe == (sbyte) 23)
      shaderIndex = drawinfo.cFlameWaker;
    if (drawinfo.isSitting)
      PlayerDrawLayers.DrawSittingLegs(ref drawinfo, TextureAssets.AccShoes[(int) drawinfo.drawPlayer.shoe].Value, drawinfo.colorArmorLegs, shaderIndex, drawinfo.drawPlayer.legs, shoeDrawOffset);
    else
      drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.AccShoes[(int) drawinfo.drawPlayer.shoe].Value, shoeDrawOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.legFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.legFrame.Height + 4.0)) + drawinfo.drawPlayer.legPosition + drawinfo.legVect, new Rectangle?(drawinfo.drawPlayer.legFrame), drawinfo.colorArmorLegs, drawinfo.drawPlayer.legRotation, drawinfo.legVect, 1f, drawinfo.playerEffect)
      {
        shader = shaderIndex
      });
  }

  public static void DrawPlayer_15_SkinLongCoat(ref PlayerDrawSet drawinfo)
  {
    if ((drawinfo.skinVar == 3 || drawinfo.skinVar == 8 ? 1 : (drawinfo.skinVar == 7 ? 1 : 0)) == 0 || drawinfo.drawPlayer.body > 0 && drawinfo.drawPlayer.body < ArmorIDs.Body.Count || drawinfo.drawPlayer.invis)
      return;
    if (drawinfo.isSitting)
    {
      PlayerDrawLayers.DrawSittingLegs(ref drawinfo, TextureAssets.Players[drawinfo.skinVar, 14].Value, drawinfo.colorShirt, legIndex: drawinfo.drawPlayer.legs, skin: true);
    }
    else
    {
      DrawData drawData = new DrawData(TextureAssets.Players[drawinfo.skinVar, 14].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.legFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.legFrame.Height + 4.0)) + drawinfo.drawPlayer.legPosition + drawinfo.legVect, new Rectangle?(drawinfo.drawPlayer.legFrame), drawinfo.colorShirt, drawinfo.drawPlayer.legRotation, drawinfo.legVect, 1f, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData);
    }
  }

  public static void DrawPlayer_16_ArmorLongCoat(ref PlayerDrawSet drawinfo)
  {
    int matchingBodyExtension1 = PlayerDrawLayers.GetMatchingBodyExtension(ref drawinfo, drawinfo.drawPlayer.body);
    DrawData cdd;
    if (matchingBodyExtension1 != -1)
    {
      Main.instance.LoadArmorLegs(matchingBodyExtension1);
      if (drawinfo.isSitting && matchingBodyExtension1 != 195)
      {
        PlayerDrawLayers.DrawSittingLegs(ref drawinfo, TextureAssets.ArmorLeg[matchingBodyExtension1].Value, drawinfo.colorArmorBody, drawinfo.cCoat, matchingBodyExtension1);
      }
      else
      {
        cdd = new DrawData(TextureAssets.ArmorLeg[matchingBodyExtension1].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.legFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.legFrame.Height + 4.0)) + drawinfo.drawPlayer.legPosition + drawinfo.legVect, new Rectangle?(drawinfo.drawPlayer.legFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.legRotation, drawinfo.legVect, 1f, drawinfo.playerEffect);
        cdd.shader = drawinfo.cBody;
        PlayerDrawLayers.DrawLongCoat(ref drawinfo, ref cdd, matchingBodyExtension1);
      }
    }
    int matchingBodyExtension2 = PlayerDrawLayers.GetMatchingBodyExtension(ref drawinfo, drawinfo.drawPlayer.coat);
    if (matchingBodyExtension2 == -1)
      return;
    Main.instance.LoadArmorLegs(matchingBodyExtension2);
    if (drawinfo.isSitting && matchingBodyExtension2 != 195)
    {
      PlayerDrawLayers.DrawSittingLegs(ref drawinfo, TextureAssets.ArmorLeg[matchingBodyExtension2].Value, drawinfo.colorArmorBody, drawinfo.cCoat, matchingBodyExtension2);
    }
    else
    {
      cdd = new DrawData(TextureAssets.ArmorLeg[matchingBodyExtension2].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.legFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.legFrame.Height + 4.0)) + drawinfo.drawPlayer.legPosition + drawinfo.legVect, new Rectangle?(drawinfo.drawPlayer.legFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.legRotation, drawinfo.legVect, 1f, drawinfo.playerEffect);
      cdd.shader = drawinfo.cCoat;
      PlayerDrawLayers.DrawLongCoat(ref drawinfo, ref cdd, matchingBodyExtension2);
    }
  }

  private static void DrawLongCoat(
    ref PlayerDrawSet drawinfo,
    ref DrawData cdd,
    int specialLegCoat)
  {
    drawinfo.DrawDataCache.Add(cdd);
    if (specialLegCoat != 238)
      return;
    DrawData drawData = cdd with
    {
      texture = TextureAssets.GlowMask[363].Value,
      color = PlayerDrawLayers.GetChickenBonesGlowColor(ref drawinfo, true)
    };
    float scale = drawinfo.stealth * drawinfo.stealth * (1f - drawinfo.shadow);
    drawData.color = Color.Multiply(drawData.color, scale);
    drawinfo.DrawDataCache.Add(drawData);
  }

  public static int GetMatchingBodyExtensionBack(ref PlayerDrawSet drawinfo, int bodyValue)
  {
    int bodyExtensionBack = -1;
    if (bodyValue == 251)
      bodyExtensionBack = 239;
    return bodyExtensionBack;
  }

  public static int GetMatchingBodyExtension(ref PlayerDrawSet drawinfo, int bodyValue)
  {
    int matchingBodyExtension = -1;
    switch (bodyValue)
    {
      case 52:
        matchingBodyExtension = !drawinfo.drawPlayer.Male ? 172 : 171;
        break;
      case 53:
        matchingBodyExtension = !drawinfo.drawPlayer.Male ? 176 /*0xB0*/ : 175;
        break;
      case 73:
        matchingBodyExtension = 170;
        break;
      case 81:
        matchingBodyExtension = 169;
        break;
      case 89:
        matchingBodyExtension = 186;
        break;
      case 168:
        matchingBodyExtension = 164;
        break;
      case 182:
        matchingBodyExtension = 163;
        break;
      case 187:
        matchingBodyExtension = 173;
        break;
      case 198:
        matchingBodyExtension = 162;
        break;
      case 200:
        matchingBodyExtension = 149;
        break;
      case 201:
        matchingBodyExtension = 150;
        break;
      case 202:
        matchingBodyExtension = 151;
        break;
      case 205:
        matchingBodyExtension = 174;
        break;
      case 207:
        matchingBodyExtension = 161;
        break;
      case 209:
        matchingBodyExtension = 160 /*0xA0*/;
        break;
      case 210:
        matchingBodyExtension = !drawinfo.drawPlayer.Male ? 177 : 178;
        break;
      case 211:
        matchingBodyExtension = !drawinfo.drawPlayer.Male ? 181 : 182;
        break;
      case 218:
        matchingBodyExtension = 195;
        break;
      case 222:
        matchingBodyExtension = !drawinfo.drawPlayer.Male ? 200 : 201;
        break;
      case 225:
        matchingBodyExtension = 206;
        break;
      case 236:
        matchingBodyExtension = 221;
        break;
      case 237:
        matchingBodyExtension = 223;
        break;
      case 251:
        matchingBodyExtension = 238;
        break;
    }
    return matchingBodyExtension;
  }

  public static void DrawPlayer_17_Torso(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.usesCompositeTorso)
      PlayerDrawLayers.DrawPlayer_17_TorsoComposite(ref drawinfo);
    else if (drawinfo.drawPlayer.body > 0 && drawinfo.drawPlayer.body < ArmorIDs.Body.Count)
    {
      Rectangle bodyFrame = drawinfo.drawPlayer.bodyFrame;
      int num = drawinfo.armorAdjust;
      bodyFrame.X += num;
      bodyFrame.Width -= num;
      if (drawinfo.drawPlayer.direction == -1)
        num = 0;
      if (!drawinfo.drawPlayer.invis || drawinfo.drawPlayer.body != 21 && drawinfo.drawPlayer.body != 22)
      {
        DrawData drawData = new DrawData(drawinfo.drawPlayer.Male ? TextureAssets.ArmorBody[drawinfo.drawPlayer.body].Value : TextureAssets.FemaleBody[drawinfo.drawPlayer.body].Value, new Vector2((float) ((int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)) + num), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(bodyFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
        drawData.shader = drawinfo.cBody;
        drawinfo.DrawDataCache.Add(drawData);
        if (drawinfo.bodyGlowMask != -1)
        {
          drawData = new DrawData(TextureAssets.GlowMask[drawinfo.bodyGlowMask].Value, new Vector2((float) ((int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)) + num), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(bodyFrame), drawinfo.bodyGlowColor, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
          drawData.shader = drawinfo.cBody;
          drawinfo.DrawDataCache.Add(drawData);
        }
      }
      if (!drawinfo.missingHand || drawinfo.drawPlayer.invis)
        return;
      DrawData drawData1 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 5].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorBodySkin, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.skinDyePacked
      };
      drawinfo.DrawDataCache.Add(drawData1);
    }
    else
    {
      if (drawinfo.drawPlayer.invis)
        return;
      if (!drawinfo.drawPlayer.Male)
      {
        DrawData drawData = new DrawData(TextureAssets.Players[drawinfo.skinVar, 4].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorUnderShirt, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
        drawinfo.DrawDataCache.Add(drawData);
        drawData = new DrawData(TextureAssets.Players[drawinfo.skinVar, 6].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorShirt, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
        drawinfo.DrawDataCache.Add(drawData);
      }
      else
      {
        DrawData drawData = new DrawData(TextureAssets.Players[drawinfo.skinVar, 4].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorUnderShirt, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
        drawinfo.DrawDataCache.Add(drawData);
        drawData = new DrawData(TextureAssets.Players[drawinfo.skinVar, 6].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorShirt, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
        drawinfo.DrawDataCache.Add(drawData);
      }
      DrawData drawData2 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 5].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorBodySkin, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.skinDyePacked
      };
      drawinfo.DrawDataCache.Add(drawData2);
    }
  }

  public static void DrawPlayer_17_TorsoComposite(ref PlayerDrawSet drawinfo)
  {
    Vector2 vector2_1 = new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2));
    Vector2 vector2_2 = Main.OffsetsPlayerHeadgear[drawinfo.drawPlayer.bodyFrame.Y / drawinfo.drawPlayer.bodyFrame.Height];
    vector2_2.Y -= 2f;
    Vector2 position = vector2_1 + vector2_2 * (float) -((drawinfo.playerEffect & SpriteEffects.FlipVertically) != 0).ToDirectionInt();
    float bodyRotation = drawinfo.drawPlayer.bodyRotation;
    Vector2 vector2_3 = position;
    Vector2 bodyVect = drawinfo.bodyVect;
    Vector2 compositeOffsetBackArm = PlayerDrawLayers.GetCompositeOffset_BackArm(ref drawinfo);
    Vector2 vector2_4 = compositeOffsetBackArm;
    Vector2 vector2_5 = vector2_3 + vector2_4;
    Vector2 vector2_6 = bodyVect + compositeOffsetBackArm;
    bool flag = false;
    DrawData drawData1;
    if (drawinfo.drawPlayer.body > 0 && drawinfo.drawPlayer.body < ArmorIDs.Body.Count)
    {
      flag = true;
      if (!drawinfo.drawPlayer.invis || PlayerDrawLayers.IsArmorDrawnWhenInvisible(drawinfo.drawPlayer.body))
      {
        Texture2D texture1 = TextureAssets.ArmorBodyComposite[drawinfo.drawPlayer.body].Value;
        ref PlayerDrawSet local1 = ref drawinfo;
        drawData1 = new DrawData(texture1, position, new Rectangle?(drawinfo.compTorsoFrame), drawinfo.colorArmorBody, bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
        drawData1.shader = drawinfo.cBody;
        DrawData data1 = drawData1;
        int body1 = drawinfo.drawPlayer.body;
        PlayerDrawLayers.DrawCompositeArmorPiece(ref local1, CompositePlayerDrawContext.Torso, data1, body1);
        if (drawinfo.drawPlayer.body == 71)
        {
          Texture2D texture2 = TextureAssets.Extra[277].Value;
          ref PlayerDrawSet local2 = ref drawinfo;
          drawData1 = new DrawData(texture2, position, new Rectangle?(drawinfo.compTorsoFrame), drawinfo.colorArmorBody, bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
          drawData1.shader = 0;
          DrawData data2 = drawData1;
          int body2 = drawinfo.drawPlayer.body;
          PlayerDrawLayers.DrawCompositeArmorPiece(ref local2, CompositePlayerDrawContext.Torso, data2, body2);
        }
      }
    }
    if (!flag && !drawinfo.drawPlayer.invis)
    {
      drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.Players[drawinfo.skinVar, 4].Value, position, new Rectangle?(drawinfo.compBackShoulderFrame), drawinfo.colorUnderShirt, bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect));
      drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.Players[drawinfo.skinVar, 6].Value, position, new Rectangle?(drawinfo.compBackShoulderFrame), drawinfo.colorShirt, bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect));
      drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.Players[drawinfo.skinVar, 4].Value, position, new Rectangle?(drawinfo.compTorsoFrame), drawinfo.colorUnderShirt, bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect));
      drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.Players[drawinfo.skinVar, 6].Value, position, new Rectangle?(drawinfo.compTorsoFrame), drawinfo.colorShirt, bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect));
    }
    if (drawinfo.drawPlayer.coat > 0 && drawinfo.drawPlayer.coat < ArmorIDs.Body.Count && (!drawinfo.drawPlayer.invis || PlayerDrawLayers.IsArmorDrawnWhenInvisible(drawinfo.drawPlayer.coat)))
    {
      Texture2D texture = TextureAssets.ArmorBodyComposite[drawinfo.drawPlayer.coat].Value;
      ref PlayerDrawSet local = ref drawinfo;
      drawData1 = new DrawData(texture, position, new Rectangle?(drawinfo.compTorsoFrame), drawinfo.colorArmorBody, bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
      drawData1.shader = drawinfo.cCoat;
      DrawData data = drawData1;
      int coat = drawinfo.drawPlayer.coat;
      PlayerDrawLayers.DrawCompositeArmorPiece(ref local, CompositePlayerDrawContext.Torso, data, coat);
    }
    if (!drawinfo.drawFloatingTube)
      return;
    List<DrawData> drawDataCache = drawinfo.DrawDataCache;
    drawData1 = new DrawData(TextureAssets.Extra[105].Value, position, new Rectangle?(new Rectangle(0, 56, 40, 56)), drawinfo.floatingTubeColor, bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
    drawData1.shader = drawinfo.cFloatingTube;
    DrawData drawData2 = drawData1;
    drawDataCache.Add(drawData2);
  }

  public static void DrawPlayer_18_OffhandAcc(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.usesCompositeBackHandAcc || drawinfo.drawPlayer.handoff <= (sbyte) 0 || (int) drawinfo.drawPlayer.handoff >= ArmorIDs.HandOff.Count)
      return;
    drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.AccHandsOff[(int) drawinfo.drawPlayer.handoff].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect)
    {
      shader = drawinfo.cHandOff
    });
  }

  public static void DrawPlayer_JimsDroneRadio(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.HeldItem.type != 5451 && drawinfo.drawPlayer.HeldItem.type != 5738 || drawinfo.drawPlayer.itemAnimation != 0)
      return;
    Rectangle bodyFrame = drawinfo.drawPlayer.bodyFrame;
    drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.Extra[261].Value, new Vector2((float) ((int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)) + drawinfo.drawPlayer.direction * 2), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0 + 14.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(bodyFrame), drawinfo.colorArmorLegs, drawinfo.drawPlayer.legRotation, drawinfo.legVect, 1f, drawinfo.playerEffect)
    {
      shader = drawinfo.cWaist
    });
  }

  public static void DrawPlayer_19_WaistAcc(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.waist <= (sbyte) 0 || (int) drawinfo.drawPlayer.waist >= ArmorIDs.Waist.Count)
      return;
    Rectangle rectangle = drawinfo.drawPlayer.legFrame;
    if (ArmorIDs.Waist.Sets.UsesTorsoFraming[(int) drawinfo.drawPlayer.waist])
      rectangle = drawinfo.drawPlayer.bodyFrame;
    drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.AccWaist[(int) drawinfo.drawPlayer.waist].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.legFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.legFrame.Height + 4.0)) + drawinfo.drawPlayer.legPosition + drawinfo.legVect, new Rectangle?(rectangle), drawinfo.colorArmorLegs, drawinfo.drawPlayer.legRotation, drawinfo.legVect, 1f, drawinfo.playerEffect)
    {
      shader = drawinfo.cWaist
    });
  }

  public static void DrawPlayer_20_NeckAcc(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.neck <= (sbyte) 0 || (int) drawinfo.drawPlayer.neck >= ArmorIDs.Neck.Count)
      return;
    drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.AccNeck[(int) drawinfo.drawPlayer.neck].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect)
    {
      shader = drawinfo.cNeck
    });
  }

  public static void DrawPlayer_21_Head(ref PlayerDrawSet drawinfo)
  {
    Vector2 zero = Vector2.Zero;
    drawinfo.drawPlayer.ApplyHeadOffsetFromMount(ref zero);
    Vector2 helmetOffset = drawinfo.helmetOffset + zero;
    PlayerDrawLayers.DrawPlayer_21_Head_TheFace(ref drawinfo);
    bool flag1 = drawinfo.drawPlayer.head == 14 || drawinfo.drawPlayer.head == 56 || drawinfo.drawPlayer.head == 114 || drawinfo.drawPlayer.head == 158 || drawinfo.drawPlayer.head == 69 || drawinfo.drawPlayer.head == 180;
    bool flag2 = drawinfo.drawPlayer.head == 28;
    bool flag3 = drawinfo.drawPlayer.head == 39 || drawinfo.drawPlayer.head == 38;
    bool flag4 = true;
    if (drawinfo.drawPlayer.mount.Active)
    {
      int type = drawinfo.drawPlayer.mount.Type;
      if (type == 54)
      {
        if (drawinfo.drawPlayer.head >= 0 && !ArmorIDs.Head.Sets.CanDrawOnVelociraptorMount[drawinfo.drawPlayer.head])
          flag4 = false;
      }
      else if (type >= 0 && MountID.Sets.PlayerIsHidden[type])
        flag4 = false;
    }
    Vector2 vector2_1 = new Vector2((float) (-drawinfo.drawPlayer.bodyFrame.Width / 2 + drawinfo.drawPlayer.width / 2), (float) (drawinfo.drawPlayer.height - drawinfo.drawPlayer.bodyFrame.Height + 4));
    Vector2 vector2_2 = (drawinfo.Position - Main.screenPosition + vector2_1).Floor() + drawinfo.drawPlayer.headPosition + drawinfo.headVect + zero;
    if ((drawinfo.playerEffect & SpriteEffects.FlipVertically) != SpriteEffects.None)
    {
      int num = drawinfo.drawPlayer.bodyFrame.Height - drawinfo.hairFrontFrame.Height;
      vector2_2.Y += (float) num;
    }
    Vector2 position = vector2_2 + drawinfo.hairOffset;
    DrawData drawData;
    if (flag4 && drawinfo.fullHair)
    {
      Color color = drawinfo.colorArmorHead;
      int num = drawinfo.cHead;
      if (ArmorIDs.Head.Sets.UseSkinColor[drawinfo.drawPlayer.head])
      {
        color = !drawinfo.drawPlayer.isDisplayDollOrInanimate ? drawinfo.colorHead : drawinfo.colorDisplayDollSkin;
        num = drawinfo.skinDyePacked;
      }
      drawData = new DrawData(TextureAssets.ArmorHead[drawinfo.drawPlayer.head].Value, helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), color, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData.shader = num;
      drawinfo.DrawDataCache.Add(drawData);
      if (!drawinfo.drawPlayer.invis)
      {
        drawData = new DrawData(TextureAssets.PlayerHair[drawinfo.drawPlayer.hair].Value, position, new Rectangle?(drawinfo.hairFrontFrame), drawinfo.colorHair, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
        drawData.shader = drawinfo.hairDyePacked;
        drawinfo.DrawDataCache.Add(drawData);
      }
    }
    if (flag4 && drawinfo.hatHair && !drawinfo.drawPlayer.invis)
    {
      drawData = new DrawData(TextureAssets.PlayerHairAlt[drawinfo.drawPlayer.hair].Value, position, new Rectangle?(drawinfo.hairFrontFrame), drawinfo.colorHair, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.hairDyePacked;
      drawinfo.DrawDataCache.Add(drawData);
    }
    if (flag4 && drawinfo.drawPlayer.head == 270)
    {
      Rectangle bodyFrame = drawinfo.drawPlayer.bodyFrame;
      bodyFrame.Width += 2;
      drawData = new DrawData(TextureAssets.ArmorHead[drawinfo.drawPlayer.head].Value, helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(bodyFrame), drawinfo.colorArmorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cHead;
      drawinfo.DrawDataCache.Add(drawData);
      drawData = new DrawData(TextureAssets.GlowMask[drawinfo.headGlowMask].Value, helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(bodyFrame), drawinfo.headGlowColor, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cHead;
      drawinfo.DrawDataCache.Add(drawData);
    }
    else if (flag4 && drawinfo.drawPlayer.head == 282)
    {
      Rectangle bodyFrame1 = drawinfo.drawPlayer.bodyFrame;
      Rectangle bodyFrame2 = drawinfo.drawPlayer.bodyFrame;
      bodyFrame2.X = bodyFrame2.Y = 0;
      int num1 = 9;
      int num2 = 4;
      int num3 = drawinfo.drawPlayer.miscCounter % (num1 * num2) / num2;
      bodyFrame1.Y = bodyFrame1.Height * num3;
      int index = 0 + drawinfo.drawPlayer.bodyFrame.Y / 56;
      if (index >= Main.OffsetsPlayerHeadgear.Length)
        index = 0;
      Vector2 vector2_3 = Main.OffsetsPlayerHeadgear[index];
      vector2_3.Y -= 2f;
      Vector2 vector2_4 = vector2_3 * (float) -((drawinfo.playerEffect & SpriteEffects.FlipVertically) != 0).ToDirectionInt();
      drawData = new DrawData(TextureAssets.ArmorHead[drawinfo.drawPlayer.head].Value, vector2_4 + helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(bodyFrame1), drawinfo.colorArmorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cHead;
      drawinfo.DrawDataCache.Add(drawData);
      drawData = new DrawData(TextureAssets.GlowMask[drawinfo.headGlowMask].Value, vector2_4 + helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(bodyFrame2), drawinfo.headGlowColor, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cHead;
      drawinfo.DrawDataCache.Add(drawData);
    }
    else if (flag4 & flag1)
    {
      Rectangle bodyFrame = drawinfo.drawPlayer.bodyFrame;
      Vector2 headVect = drawinfo.headVect;
      if ((double) drawinfo.drawPlayer.gravDir == 1.0)
      {
        if (bodyFrame.Y != 0)
        {
          bodyFrame.Y -= 2;
          headVect.Y += 2f;
        }
        bodyFrame.Height -= 8;
      }
      else if (bodyFrame.Y != 0)
      {
        bodyFrame.Y -= 2;
        headVect.Y -= 10f;
        bodyFrame.Height -= 8;
      }
      Color color = drawinfo.colorArmorHead;
      int num = drawinfo.cHead;
      if (ArmorIDs.Head.Sets.UseSkinColor[drawinfo.drawPlayer.head])
      {
        color = !drawinfo.drawPlayer.isDisplayDollOrInanimate ? drawinfo.colorHead : drawinfo.colorDisplayDollSkin;
        num = drawinfo.skinDyePacked;
      }
      drawData = new DrawData(TextureAssets.ArmorHead[drawinfo.drawPlayer.head].Value, helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(bodyFrame), color, drawinfo.drawPlayer.headRotation, headVect, 1f, drawinfo.playerEffect);
      drawData.shader = num;
      drawinfo.DrawDataCache.Add(drawData);
    }
    else if (flag4 && drawinfo.drawPlayer.head == 259)
    {
      int verticalFrames = 27;
      Texture2D texture2D = TextureAssets.ArmorHead[drawinfo.drawPlayer.head].Value;
      Rectangle r = texture2D.Frame(verticalFrames: verticalFrames, frameY: drawinfo.drawPlayer.rabbitOrderFrame.DisplayFrame);
      Vector2 origin = r.Size() / 2f;
      int num4 = drawinfo.drawPlayer.babyBird.ToInt();
      Vector2 specialHatDrawPosition = PlayerDrawLayers.DrawPlayer_21_Head_GetSpecialHatDrawPosition(ref drawinfo, ref helmetOffset, new Vector2((float) (1 + num4 * 2), (float) (drawinfo.drawPlayer.babyBird.ToInt() * -6 - 26)));
      int hatStacks = PlayerDrawLayers.GetHatStacks(ref drawinfo, 4955);
      float num5 = (float) Math.PI / 60f;
      float num6 = (float) ((double) num5 * (double) drawinfo.drawPlayer.position.X % 6.2831854820251465);
      for (int index = hatStacks - 1; index >= 0; --index)
      {
        float x = (float) ((double) Vector2.UnitY.RotatedBy((double) num6 + (double) num5 * (double) index).X * ((double) index / 30.0) * 2.0) - (float) (index * 2 * drawinfo.drawPlayer.direction);
        drawData = new DrawData(texture2D, specialHatDrawPosition + new Vector2(x, (float) (index * -14) * drawinfo.drawPlayer.gravDir), new Rectangle?(r), drawinfo.colorArmorHead, drawinfo.drawPlayer.headRotation, origin, 1f, drawinfo.playerEffect);
        drawData.shader = drawinfo.cHead;
        drawinfo.DrawDataCache.Add(drawData);
      }
      if (!drawinfo.drawPlayer.invis)
      {
        drawData = new DrawData(TextureAssets.PlayerHair[drawinfo.drawPlayer.hair].Value, position, new Rectangle?(drawinfo.hairFrontFrame), drawinfo.colorHair, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
        drawData.shader = drawinfo.hairDyePacked;
        drawinfo.DrawDataCache.Add(drawData);
      }
    }
    else if (flag4 && drawinfo.drawPlayer.head > 0 && drawinfo.drawPlayer.head < ArmorIDs.Head.Count && !flag2)
    {
      if (!(drawinfo.drawPlayer.invis & flag3))
      {
        if (drawinfo.drawPlayer.head == 13)
        {
          int hatStacks = PlayerDrawLayers.GetHatStacks(ref drawinfo, 205);
          float num7 = (float) Math.PI / 60f;
          float num8 = (float) ((double) num7 * (double) drawinfo.drawPlayer.position.X % 6.2831854820251465);
          for (int index = 0; index < hatStacks; ++index)
          {
            float num9 = (float) ((double) Vector2.UnitY.RotatedBy((double) num8 + (double) num7 * (double) index).X * ((double) index / 30.0) * 2.0);
            drawData = new DrawData(TextureAssets.ArmorHead[drawinfo.drawPlayer.head].Value, helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)) + num9, (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0 - (double) (4 * index))) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
            drawData.shader = drawinfo.cHead;
            drawinfo.DrawDataCache.Add(drawData);
          }
        }
        else if (drawinfo.drawPlayer.head == 265)
        {
          int verticalFrames = 6;
          Texture2D texture2D = TextureAssets.ArmorHead[drawinfo.drawPlayer.head].Value;
          Rectangle r = texture2D.Frame(verticalFrames: verticalFrames, frameY: drawinfo.drawPlayer.rabbitOrderFrame.DisplayFrame);
          Vector2 origin = r.Size() / 2f;
          Vector2 specialHatDrawPosition = PlayerDrawLayers.DrawPlayer_21_Head_GetSpecialHatDrawPosition(ref drawinfo, ref helmetOffset, new Vector2(0.0f, -9f));
          int hatStacks = PlayerDrawLayers.GetHatStacks(ref drawinfo, 5004);
          float num10 = (float) Math.PI / 60f;
          float num11 = (float) ((double) num10 * (double) drawinfo.drawPlayer.position.X % 6.2831854820251465);
          int num12 = hatStacks * 4 + 2;
          int num13 = 0;
          bool flag5 = ((double) Main.GlobalTimeWrappedHourly + 180.0) % 600.0 < 60.0;
          for (int index = num12 - 1; index >= 0; --index)
          {
            int num14 = 0;
            if (index == num12 - 1)
            {
              r.Y = 0;
              num14 = 2;
            }
            else
              r.Y = index != 0 ? r.Height * (num13++ % 4 + 1) : r.Height * 5;
            if (!(r.Y == r.Height * 3 & flag5))
            {
              float x = (float) ((double) Vector2.UnitY.RotatedBy((double) num11 + (double) num10 * (double) index).X * ((double) index / 10.0) * 4.0 - (double) index * 0.10000000149011612 * (double) drawinfo.drawPlayer.direction);
              drawData = new DrawData(texture2D, specialHatDrawPosition + new Vector2(x, (float) (index * -4 + num14) * drawinfo.drawPlayer.gravDir), new Rectangle?(r), drawinfo.colorArmorHead, drawinfo.drawPlayer.headRotation, origin, 1f, drawinfo.playerEffect);
              drawData.shader = drawinfo.cHead;
              drawinfo.DrawDataCache.Add(drawData);
            }
          }
        }
        else
        {
          Rectangle bodyFrame = drawinfo.drawPlayer.bodyFrame;
          Vector2 headVect = drawinfo.headVect;
          if ((double) drawinfo.drawPlayer.gravDir == 1.0)
          {
            bodyFrame.Height -= 4;
          }
          else
          {
            headVect.Y -= 4f;
            bodyFrame.Height -= 4;
          }
          Color color1 = drawinfo.colorArmorHead;
          int num15 = drawinfo.cHead;
          Texture2D texture = TextureAssets.ArmorHead[drawinfo.drawPlayer.head].Value;
          Color color2 = drawinfo.drawPlayer.isDisplayDollOrInanimate ? drawinfo.colorDisplayDollSkin : drawinfo.colorHead;
          int skinDyePacked = drawinfo.skinDyePacked;
          if (ArmorIDs.Head.Sets.UseSkinColor[drawinfo.drawPlayer.head])
          {
            color1 = color2;
            num15 = skinDyePacked;
          }
          if (drawinfo.drawPlayer.mount.Active && drawinfo.mountHandlesHeadDraw && drawinfo.drawPlayer.head == 288)
            texture = TextureAssets.Extra[284].Value;
          drawData = new DrawData(texture, helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(bodyFrame), color1, drawinfo.drawPlayer.headRotation, headVect, 1f, drawinfo.playerEffect);
          drawData.shader = num15;
          drawinfo.DrawDataCache.Add(drawData);
          if (drawinfo.drawPlayer.head == 292)
          {
            drawData = new DrawData(TextureAssets.Extra[300].Value, helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(bodyFrame), color2, drawinfo.drawPlayer.headRotation, headVect, 1f, drawinfo.playerEffect);
            drawData.shader = skinDyePacked;
            drawinfo.DrawDataCache.Add(drawData);
          }
          if (drawinfo.drawPlayer.head == 109)
          {
            drawData = new DrawData(TextureAssets.Extra[276].Value, helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(bodyFrame), color1, drawinfo.drawPlayer.headRotation, headVect, 1f, drawinfo.playerEffect);
            drawData.shader = 0;
            drawinfo.DrawDataCache.Add(drawData);
          }
          if (drawinfo.headGlowMask != -1)
          {
            if (drawinfo.headGlowMask == 309)
            {
              int tvScreen = PlayerDrawLayers.DrawPlayer_Head_GetTVScreen(drawinfo.drawPlayer);
              if (tvScreen != 0)
              {
                int index = 0 + drawinfo.drawPlayer.bodyFrame.Y / 56;
                if (index >= Main.OffsetsPlayerHeadgear.Length)
                  index = 0;
                Vector2 vector2_5 = Main.OffsetsPlayerHeadgear[index];
                vector2_5.Y -= 2f;
                Vector2 vector2_6 = vector2_5 * (float) -((drawinfo.playerEffect & SpriteEffects.FlipVertically) != 0).ToDirectionInt();
                Texture2D texture2D = TextureAssets.GlowMask[drawinfo.headGlowMask].Value;
                int frameY = drawinfo.drawPlayer.miscCounter % 20 / 5;
                if (tvScreen == 5)
                {
                  frameY = 0;
                  if (drawinfo.drawPlayer.eyeHelper.EyeFrameToShow > 0)
                    frameY = 2;
                }
                Rectangle rectangle = texture2D.Frame(6, 4, tvScreen, frameY, -2);
                drawData = new DrawData(texture2D, vector2_6 + helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(rectangle), drawinfo.headGlowColor, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
                drawData.shader = drawinfo.cHead;
                drawinfo.DrawDataCache.Add(drawData);
              }
            }
            else if (drawinfo.headGlowMask == 273)
            {
              for (int index = 0; index < 2; ++index)
              {
                Vector2 vector2_7 = new Vector2((float) Main.rand.Next(-10, 10) * 0.125f, (float) Main.rand.Next(-10, 10) * 0.125f);
                drawData = new DrawData(TextureAssets.GlowMask[drawinfo.headGlowMask].Value, vector2_7 + helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(bodyFrame), drawinfo.headGlowColor, drawinfo.drawPlayer.headRotation, headVect, 1f, drawinfo.playerEffect);
                drawData.shader = drawinfo.cHead;
                drawinfo.DrawDataCache.Add(drawData);
              }
            }
            else
            {
              drawData = new DrawData(TextureAssets.GlowMask[drawinfo.headGlowMask].Value, helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(bodyFrame), drawinfo.headGlowColor, drawinfo.drawPlayer.headRotation, headVect, 1f, drawinfo.playerEffect);
              drawData.shader = drawinfo.cHead;
              drawinfo.DrawDataCache.Add(drawData);
            }
          }
          if (drawinfo.drawPlayer.head == 211)
          {
            Color color3 = new Color(100, 100, 100, 0);
            ulong seed = (ulong) (drawinfo.drawPlayer.miscCounter / 4 + 100);
            int num16 = 4;
            for (int index = 0; index < num16; ++index)
            {
              float x = (float) Utils.RandomInt(ref seed, -10, 11) * 0.2f;
              float y = (float) Utils.RandomInt(ref seed, -14, 1) * 0.15f;
              drawData = new DrawData(TextureAssets.GlowMask[241].Value, helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect + new Vector2(x, y), new Rectangle?(drawinfo.drawPlayer.bodyFrame), color3, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
              drawData.shader = drawinfo.cHead;
              drawinfo.DrawDataCache.Add(drawData);
            }
          }
        }
      }
    }
    else if (flag4 && !drawinfo.drawPlayer.invis && (drawinfo.drawPlayer.face < (sbyte) 0 || !ArmorIDs.Face.Sets.PreventHairDraw[(int) drawinfo.drawPlayer.face]))
    {
      drawData = new DrawData(TextureAssets.PlayerHair[drawinfo.drawPlayer.hair].Value, position, new Rectangle?(drawinfo.hairFrontFrame), drawinfo.colorHair, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.hairDyePacked;
      drawinfo.DrawDataCache.Add(drawData);
    }
    bool flag6 = drawinfo.drawPlayer.head < 0 || !ArmorIDs.Head.Sets.PreventBeardDraw[drawinfo.drawPlayer.head];
    if (drawinfo.drawPlayer.mount.Active && drawinfo.drawPlayer.mount.Type == 54)
      flag6 = true;
    if (drawinfo.drawPlayer.beard > (sbyte) 0 & flag6)
    {
      Vector2 vector2_8 = drawinfo.drawPlayer.GetBeardDrawOffset() + zero;
      Color color = drawinfo.colorArmorHead;
      if (ArmorIDs.Beard.Sets.UseHairColor[(int) drawinfo.drawPlayer.beard])
        color = drawinfo.colorHair;
      drawData = new DrawData(TextureAssets.AccBeard[(int) drawinfo.drawPlayer.beard].Value, vector2_8 + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), color, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cBeard;
      drawinfo.DrawDataCache.Add(drawData);
    }
    if (flag4 && drawinfo.drawPlayer.head == 205)
    {
      drawData = new DrawData(TextureAssets.Extra[77].Value, helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.skinDyePacked
      };
      drawinfo.DrawDataCache.Add(drawData);
    }
    if (flag4 && drawinfo.drawPlayer.head == 214 && !drawinfo.drawPlayer.invis)
    {
      Rectangle bodyFrame = drawinfo.drawPlayer.bodyFrame with
      {
        Y = 0
      };
      float t = (float) drawinfo.drawPlayer.miscCounter / 300f;
      Color color4 = new Color(0, 0, 0, 0);
      float from = 0.8f;
      float to = 0.9f;
      if ((double) t >= (double) from)
        color4 = Color.Lerp(Color.Transparent, new Color(200, 200, 200, 0), Utils.GetLerpValue(from, to, t, true));
      if ((double) t >= (double) to)
        color4 = Color.Lerp(Color.Transparent, new Color(200, 200, 200, 0), Utils.GetLerpValue(1f, to, t, true));
      Color color5 = color4 * (drawinfo.stealth * (1f - drawinfo.shadow));
      drawData = new DrawData(TextureAssets.Extra[90].Value, helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect - Main.OffsetsPlayerHeadgear[drawinfo.drawPlayer.bodyFrame.Y / drawinfo.drawPlayer.bodyFrame.Height], new Rectangle?(bodyFrame), color5, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData);
    }
    if (flag4 && drawinfo.drawPlayer.head == 137)
    {
      drawData = new DrawData(TextureAssets.JackHat.Value, helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue), drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData);
      for (int index = 0; index < 7; ++index)
      {
        Color color = new Color(110 - index * 10, 110 - index * 10, 110 - index * 10, 110 - index * 10);
        Vector2 vector2_9 = new Vector2((float) Main.rand.Next(-10, 11) * 0.2f, (float) Main.rand.Next(-10, 11) * 0.2f);
        vector2_9.X = drawinfo.drawPlayer.itemFlamePos[index].X;
        vector2_9.Y = drawinfo.drawPlayer.itemFlamePos[index].Y;
        vector2_9 *= 0.5f;
        drawData = new DrawData(TextureAssets.JackHat.Value, helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect + vector2_9, new Rectangle?(drawinfo.drawPlayer.bodyFrame), color, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
        drawinfo.DrawDataCache.Add(drawData);
      }
    }
    if (!drawinfo.drawPlayer.babyBird)
      return;
    Rectangle bodyFrame3 = drawinfo.drawPlayer.bodyFrame with
    {
      Y = 0
    };
    Vector2 pos = Vector2.Zero;
    Color color6 = drawinfo.colorArmorHead;
    if (drawinfo.drawPlayer.mount.Active)
    {
      int type = drawinfo.drawPlayer.mount.Type;
      if (type == 52)
      {
        Vector2 mountedCenter = drawinfo.drawPlayer.MountedCenter;
        color6 = drawinfo.drawPlayer.GetImmuneAlphaPure(Lighting.GetColorClamped((int) mountedCenter.X / 16 /*0x10*/, (int) mountedCenter.Y / 16 /*0x10*/, Color.White), drawinfo.shadow);
        pos = new Vector2(0.0f, 6f) * drawinfo.drawPlayer.Directions;
      }
      if (type == 54)
      {
        Vector2 mountedCenter = drawinfo.drawPlayer.MountedCenter;
        color6 = drawinfo.drawPlayer.GetImmuneAlphaPure(Lighting.GetColorClamped((int) mountedCenter.X / 16 /*0x10*/, (int) mountedCenter.Y / 16 /*0x10*/, Color.White), drawinfo.shadow);
        drawinfo.drawPlayer.ApplyHeadOffsetFromMount(ref pos);
        pos += new Vector2(-2f, 2f) * drawinfo.drawPlayer.Directions;
      }
    }
    drawData = new DrawData(TextureAssets.Extra[100].Value, pos + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect + Main.OffsetsPlayerHeadgear[drawinfo.drawPlayer.bodyFrame.Y / drawinfo.drawPlayer.bodyFrame.Height] * drawinfo.drawPlayer.gravDir, new Rectangle?(bodyFrame3), color6, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
    drawinfo.DrawDataCache.Add(drawData);
  }

  public static int DrawPlayer_Head_GetTVScreen(Player plr)
  {
    if (NPC.AnyDanger())
      return 4;
    if (plr.statLife <= plr.statLifeMax2 / 4)
      return 1;
    if (plr.ZoneCorrupt || plr.ZoneCrimson || plr.ZoneGraveyard)
      return 0;
    if (plr.wet)
      return 2;
    return plr.townNPCs >= 3 || BirthdayParty.PartyIsUp || LanternNight.LanternsUp ? 5 : 3;
  }

  private static int GetHatStacks(ref PlayerDrawSet drawinfo, int hatItemId)
  {
    int hatStacks = 0;
    int index1 = 0;
    if (drawinfo.drawPlayer.armor[index1] != null && drawinfo.drawPlayer.armor[index1].type == hatItemId && drawinfo.drawPlayer.armor[index1].stack > 0)
      hatStacks += drawinfo.drawPlayer.armor[index1].stack;
    int index2 = 10;
    if (drawinfo.drawPlayer.armor[index2] != null && drawinfo.drawPlayer.armor[index2].type == hatItemId && drawinfo.drawPlayer.armor[index2].stack > 0)
      hatStacks += drawinfo.drawPlayer.armor[index2].stack;
    if (hatStacks > 2)
      hatStacks = 2;
    return hatStacks;
  }

  private static Vector2 DrawPlayer_21_Head_GetSpecialHatDrawPosition(
    ref PlayerDrawSet drawinfo,
    ref Vector2 helmetOffset,
    Vector2 hatOffset)
  {
    Vector2 vector2 = Main.OffsetsPlayerHeadgear[drawinfo.drawPlayer.bodyFrame.Y / drawinfo.drawPlayer.bodyFrame.Height] * drawinfo.drawPlayer.Directions;
    Vector2 vec = (drawinfo.Position - Main.screenPosition + helmetOffset + new Vector2((float) (-drawinfo.drawPlayer.bodyFrame.Width / 2 + drawinfo.drawPlayer.width / 2), (float) (drawinfo.drawPlayer.height - drawinfo.drawPlayer.bodyFrame.Height + 4)) + hatOffset * drawinfo.drawPlayer.Directions + vector2).Floor() + (drawinfo.drawPlayer.headPosition + drawinfo.headVect);
    if ((double) drawinfo.drawPlayer.gravDir == -1.0)
      vec.Y += 12f;
    vec = vec.Floor();
    return vec;
  }

  private static void DrawPlayer_21_Head_TheFace(ref PlayerDrawSet drawinfo)
  {
    Vector2 zero = Vector2.Zero;
    drawinfo.drawPlayer.ApplyHeadOffsetFromMount(ref zero);
    bool flag = drawinfo.drawPlayer.head >= 0 && ArmorIDs.Head.Sets.HidesHead[drawinfo.drawPlayer.head];
    if (drawinfo.mountHandlesHeadDraw)
    {
      if (drawinfo.mountDrawsEyelid)
        PlayerDrawLayers.DrawPlayer_21_Head_TheFace_Eyelid(ref drawinfo);
      if (drawinfo.drawPlayer.face <= (sbyte) 0 || !ArmorIDs.Face.Sets.DrawInFaceUnderHairLayer[(int) drawinfo.drawPlayer.face] || drawinfo.drawPlayer.mount.Active && drawinfo.drawPlayer.mount.Type == 54 && !ArmorIDs.Face.Sets.CanDrawOnVelociraptorMount[(int) drawinfo.drawPlayer.face])
        return;
      drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.AccFace[(int) drawinfo.drawPlayer.face].Value, zero + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.cFace
      });
    }
    else if (!flag && drawinfo.drawPlayer.faceHead > (sbyte) 0 && (int) drawinfo.drawPlayer.faceHead < (int) ArmorIDs.Face.Count)
    {
      Vector2 vector2 = drawinfo.drawPlayer.GetFaceHeadOffsetFromHelmet() + zero;
      DrawData drawData = new DrawData(TextureAssets.AccFace[(int) drawinfo.drawPlayer.faceHead].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect + vector2, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cFaceHead;
      drawinfo.DrawDataCache.Add(drawData);
      if (drawinfo.drawPlayer.face <= (sbyte) 0 || !ArmorIDs.Face.Sets.DrawInFaceUnderHairLayer[(int) drawinfo.drawPlayer.face] || drawinfo.drawPlayer.mount.Active && drawinfo.drawPlayer.mount.Type == 54 && !ArmorIDs.Face.Sets.CanDrawOnVelociraptorMount[(int) drawinfo.drawPlayer.face])
        return;
      float num = 0.0f;
      if (drawinfo.drawPlayer.face == (sbyte) 5)
      {
        switch (drawinfo.drawPlayer.faceHead)
        {
          case 10:
          case 11:
          case 12:
          case 13:
            num = (float) (2 * drawinfo.drawPlayer.direction);
            break;
        }
      }
      drawData = new DrawData(TextureAssets.AccFace[(int) drawinfo.drawPlayer.face].Value, zero + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)) + num, (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cFace;
      drawinfo.DrawDataCache.Add(drawData);
    }
    else
    {
      if (drawinfo.drawPlayer.invis || flag)
        return;
      DrawData drawData1 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 0].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData1.shader = drawinfo.skinDyePacked;
      DrawData drawData2 = drawData1;
      drawinfo.DrawDataCache.Add(drawData2);
      drawData2 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 1].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorEyeWhites, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData2);
      drawData2 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 2].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorEyes, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData2);
      PlayerDrawLayers.DrawPlayer_21_Head_TheFace_Eyelid(ref drawinfo);
      if (drawinfo.drawPlayer.yoraiz0rDarkness)
      {
        drawData1 = new DrawData(TextureAssets.Extra[67].Value, zero + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
        drawData1.shader = drawinfo.skinDyePacked;
        drawData2 = drawData1;
        drawinfo.DrawDataCache.Add(drawData2);
      }
      if (drawinfo.drawPlayer.face <= (sbyte) 0 || !ArmorIDs.Face.Sets.DrawInFaceUnderHairLayer[(int) drawinfo.drawPlayer.face] || drawinfo.drawPlayer.mount.Active && drawinfo.drawPlayer.mount.Type == 54 && !ArmorIDs.Face.Sets.CanDrawOnVelociraptorMount[(int) drawinfo.drawPlayer.face])
        return;
      drawData2 = new DrawData(TextureAssets.AccFace[(int) drawinfo.drawPlayer.face].Value, zero + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData2.shader = drawinfo.cFace;
      drawinfo.DrawDataCache.Add(drawData2);
    }
  }

  private static void DrawPlayer_21_Head_TheFace_Eyelid(ref PlayerDrawSet drawinfo)
  {
    Asset<Texture2D> player = TextureAssets.Players[drawinfo.skinVar, 15];
    if (!player.IsLoaded)
      return;
    Vector2 zero = Vector2.Zero;
    drawinfo.drawPlayer.ApplyHeadOffsetFromMount(ref zero);
    Vector2 vector2_1 = Main.OffsetsPlayerHeadgear[drawinfo.drawPlayer.bodyFrame.Y / drawinfo.drawPlayer.bodyFrame.Height];
    vector2_1.Y -= 2f;
    Vector2 vector2_2 = vector2_1 * (float) -((drawinfo.playerEffect & SpriteEffects.FlipVertically) != 0).ToDirectionInt();
    Color color = drawinfo.colorHead;
    int num = drawinfo.skinDyePacked;
    int frameY = drawinfo.drawPlayer.eyeHelper.EyeFrameToShow;
    if (drawinfo.drawPlayer.mount.Active && drawinfo.drawPlayer.mount.Type == 54)
    {
      color = drawinfo.drawPlayer.GetImmuneAlpha(Lighting.GetColorClamped((int) drawinfo.drawPlayer.MountedCenter.X / 16 /*0x10*/, (int) drawinfo.drawPlayer.MountedCenter.Y / 16 /*0x10*/, new Color(158, 92, 67)), drawinfo.shadow);
      num = drawinfo.drawPlayer.cMount;
    }
    if (drawinfo.drawPlayer.mount.Active && drawinfo.mountHandlesHeadDraw && drawinfo.mountDrawsEyelid && drawinfo.drawPlayer.head == 288)
    {
      color = Color.Black;
      frameY = 2;
    }
    Rectangle rectangle = player.Frame(verticalFrames: 3, frameY: frameY);
    DrawData drawData = new DrawData(player.Value, zero + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect + vector2_2, new Rectangle?(rectangle), color, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect)
    {
      shader = num
    };
    drawinfo.DrawDataCache.Add(drawData);
  }

  public static void DrawPlayer_21_1_Magiluminescence(ref PlayerDrawSet drawinfo)
  {
    if ((double) drawinfo.shadow != 0.0 || drawinfo.drawPlayer.neck != (sbyte) 11 || drawinfo.hideEntirePlayer || drawinfo.hideEntirePlayerExceptHelmetsAndFaceAccessories)
      return;
    Color colorArmorBody = drawinfo.colorArmorBody;
    Color color = new Color(140, 140, 35, 12);
    float amount = (float) ((double) ((int) colorArmorBody.R + (int) colorArmorBody.G + (int) colorArmorBody.B) / 3.0 / (double) byte.MaxValue);
    color = Color.Lerp(color, Color.Transparent, amount);
    if (color == Color.Transparent)
      return;
    drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.GlowMask[310].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), color, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect)
    {
      shader = drawinfo.cNeck
    });
  }

  public static void DrawPlayer_ChippysHeadband(ref PlayerDrawSet drawinfo)
  {
    Texture2D texture2D = TextureAssets.Extra[279].Value;
    float num1 = 0.4f;
    float num2 = 0.8f;
    float num3 = 160f;
    Vector2 zero = Vector2.Zero;
    float num4 = 0.0f;
    bool isVelociraptor = false;
    bool hasRockGolemHead = false;
    Vector2 offsetForFaceAcc = PlayerDrawLayers.DrawPlayer_GetMountOffsetForFaceAcc(ref drawinfo, ref isVelociraptor, ref hasRockGolemHead);
    Vector2 faceDrawOffset = drawinfo.drawPlayer.GetFaceDrawOffset((int) drawinfo.drawPlayer.face);
    if (isVelociraptor & hasRockGolemHead)
      faceDrawOffset += drawinfo.drawPlayer.GetHelmetOffsetAddonFromMount();
    Vector2 vector2_1 = faceDrawOffset + offsetForFaceAcc;
    int num5 = Math.Min(drawinfo.drawPlayer.availableAdvancedShadowsCount - 1, 30);
    float num6 = 0.0f;
    for (int shadowIndex = num5; shadowIndex > 0; --shadowIndex)
    {
      EntityShadowInfo advancedShadow1 = drawinfo.drawPlayer.GetAdvancedShadow(shadowIndex);
      EntityShadowInfo advancedShadow2 = drawinfo.drawPlayer.GetAdvancedShadow(shadowIndex - 1);
      if (shadowIndex == 1)
        num4 = drawinfo.drawPlayer.position.AngleFrom(advancedShadow1.Position);
      num6 += Vector2.Distance(advancedShadow1.Position, advancedShadow2.Position);
    }
    float num7 = MathHelper.Clamp(num6 / num3, 0.0f, 1f);
    float num8 = (float) (-(double) Main.WindForVisuals * 0.44999998807907104) * drawinfo.drawPlayer.Directions.Y * Utils.MultiLerp((float) ((double) drawinfo.drawPlayer.miscCounter % 100.0 / 100.0), 0.3f, 0.5f, 0.8f, 1f, 0.8f, 1f, 0.7f, 0.6f, 0.8f, 0.3f);
    float num9 = num7;
    int frameY;
    switch ((double) num9 < (double) num2 ? ((double) num9 < (double) num1 ? 0 : 1) : 2)
    {
      case 1:
        frameY = (int) Utils.Lerp(1.0, 6.0, (double) drawinfo.drawPlayer.miscCounter % 24.0 / 24.0);
        break;
      case 2:
        frameY = (int) Utils.Lerp(7.0, 12.0, (double) drawinfo.drawPlayer.miscCounter % 18.0 / 18.0);
        break;
      default:
        frameY = 0;
        break;
    }
    float num10 = num4;
    if ((double) num10 != 0.0 && (double) drawinfo.drawPlayer.Directions.X == -1.0)
      num10 += 3.14159274f;
    float rotation = (num10 + num8) % 6.28318548f;
    Rectangle rectangle = texture2D.Frame(verticalFrames: 13, frameY: frameY);
    Vector2 origin = new Vector2(26f, 22f);
    if ((double) drawinfo.drawPlayer.Directions.X == -1.0)
      origin.X = 46f;
    if ((double) drawinfo.drawPlayer.Directions.Y == -1.0)
      origin.Y = 56f - origin.Y;
    Vector2 vector2_2 = new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (rectangle.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) rectangle.Height + 4.0)) + drawinfo.drawPlayer.headPosition + origin;
    Vector2 vector2_3 = vector2_1 + new Vector2(1f, -2f) * drawinfo.drawPlayer.Directions;
    Vector2 vector2_4 = Main.OffsetsPlayerHeadgear[drawinfo.drawPlayer.bodyFrame.Y / drawinfo.drawPlayer.bodyFrame.Height];
    vector2_4.Y -= 2f;
    Vector2 vector2_5 = vector2_4 * drawinfo.drawPlayer.Directions.Y;
    drawinfo.DrawDataCache.Add(new DrawData(texture2D, vector2_3 + zero + vector2_2 + vector2_5, new Rectangle?(rectangle), drawinfo.colorArmorHead, rotation, origin, 1f, drawinfo.playerEffect)
    {
      shader = drawinfo.cFace
    });
  }

  public static Vector2 DrawPlayer_GetMountOffsetForFaceAcc(
    ref PlayerDrawSet drawinfo,
    ref bool isVelociraptor,
    ref bool hasRockGolemHead)
  {
    Vector2 pos = Vector2.Zero;
    isVelociraptor = false;
    hasRockGolemHead = drawinfo.drawPlayer.head == 241;
    if (drawinfo.drawPlayer.mount.Active)
    {
      switch (drawinfo.drawPlayer.mount.Type)
      {
        case 52:
          pos = new Vector2(28f, -2f) * drawinfo.drawPlayer.Directions;
          break;
        case 54:
          drawinfo.drawPlayer.ApplyHeadOffsetFromMount(ref pos);
          pos -= drawinfo.drawPlayer.GetHelmetOffsetAddonFromMount();
          isVelociraptor = true;
          break;
        case 55:
        case 56:
        case 61:
          drawinfo.drawPlayer.ApplyHeadOffsetFromMount(ref pos);
          pos -= drawinfo.drawPlayer.GetHelmetOffsetAddonFromMount();
          break;
      }
    }
    return pos;
  }

  public static void DrawPlayer_22_FaceAcc(ref PlayerDrawSet drawinfo)
  {
    bool isVelociraptor = false;
    bool hasRockGolemHead = false;
    bool flag = drawinfo.drawPlayer.head == 287;
    Vector2 offsetForFaceAcc = PlayerDrawLayers.DrawPlayer_GetMountOffsetForFaceAcc(ref drawinfo, ref isVelociraptor, ref hasRockGolemHead);
    DrawData drawData;
    if (drawinfo.drawPlayer.face > (sbyte) 0 && (int) drawinfo.drawPlayer.face < (int) ArmorIDs.Face.Count && !ArmorIDs.Face.Sets.DrawInFaceUnderHairLayer[(int) drawinfo.drawPlayer.face] && (!isVelociraptor || ArmorIDs.Face.Sets.CanDrawOnVelociraptorMount[(int) drawinfo.drawPlayer.face]) && (drawinfo.drawPlayer.face != (sbyte) 23 || !flag))
    {
      Vector2 faceDrawOffset = drawinfo.drawPlayer.GetFaceDrawOffset((int) drawinfo.drawPlayer.face);
      if (isVelociraptor & hasRockGolemHead)
        faceDrawOffset += drawinfo.drawPlayer.GetHelmetOffsetAddonFromMount();
      drawData = new DrawData(TextureAssets.AccFace[(int) drawinfo.drawPlayer.face].Value, faceDrawOffset + offsetForFaceAcc + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cFace;
      drawinfo.DrawDataCache.Add(drawData);
    }
    if (drawinfo.drawPlayer.faceMask > (sbyte) 0 && (int) drawinfo.drawPlayer.faceMask < (int) ArmorIDs.Face.Count && (!isVelociraptor || ArmorIDs.Face.Sets.CanDrawOnVelociraptorMount[(int) drawinfo.drawPlayer.faceMask]))
    {
      Vector2 faceDrawOffset = drawinfo.drawPlayer.GetFaceDrawOffset((int) drawinfo.drawPlayer.faceMask);
      if (isVelociraptor & hasRockGolemHead)
        faceDrawOffset += drawinfo.drawPlayer.GetHelmetOffsetAddonFromMount();
      drawData = new DrawData(TextureAssets.AccFace[(int) drawinfo.drawPlayer.faceMask].Value, faceDrawOffset + offsetForFaceAcc + drawinfo.helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cFaceMask;
      drawinfo.DrawDataCache.Add(drawData);
    }
    if (drawinfo.drawPlayer.faceFlower > (sbyte) 0 && (int) drawinfo.drawPlayer.faceFlower < (int) ArmorIDs.Face.Count && (!isVelociraptor || ArmorIDs.Face.Sets.CanDrawOnVelociraptorMount[(int) drawinfo.drawPlayer.faceFlower]))
    {
      Vector2 faceDrawOffset = drawinfo.drawPlayer.GetFaceDrawOffset((int) drawinfo.drawPlayer.faceFlower);
      if (isVelociraptor & hasRockGolemHead)
        faceDrawOffset += drawinfo.drawPlayer.GetHelmetOffsetAddonFromMount();
      drawData = new DrawData(TextureAssets.AccFace[(int) drawinfo.drawPlayer.faceFlower].Value, faceDrawOffset + offsetForFaceAcc + drawinfo.helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cFaceFlower;
      drawinfo.DrawDataCache.Add(drawData);
    }
    if (drawinfo.drawUnicornHorn)
    {
      Vector2 zero = Vector2.Zero;
      if (isVelociraptor & hasRockGolemHead)
        zero += drawinfo.drawPlayer.GetHelmetOffsetAddonFromMount();
      drawData = new DrawData(TextureAssets.Extra[143].Value, offsetForFaceAcc + zero + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cUnicornHorn;
      drawinfo.DrawDataCache.Add(drawData);
    }
    if (!drawinfo.drawAngelHalo)
      return;
    Vector2 zero1 = Vector2.Zero;
    if (isVelociraptor & hasRockGolemHead)
      zero1 += drawinfo.drawPlayer.GetHelmetOffsetAddonFromMount() + new Vector2(-4f, -14f) * drawinfo.drawPlayer.Directions;
    Color color = drawinfo.drawPlayer.GetImmuneAlphaPure(new Color(200, 200, 200, 150), drawinfo.shadow) * drawinfo.drawPlayer.stealth;
    Main.instance.LoadAccFace(7);
    drawData = new DrawData(TextureAssets.AccFace[7].Value, offsetForFaceAcc + zero1 + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect, new Rectangle?(drawinfo.drawPlayer.bodyFrame), color, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
    drawData.shader = drawinfo.cAngelHalo;
    drawinfo.DrawDataCache.Add(drawData);
  }

  public static void DrawTiedBalloons(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.mount.Type != 34)
      return;
    Texture2D texture2D = TextureAssets.Extra[141].Value;
    Vector2 vector2 = new Vector2(0.0f, 4f);
    Color colorMount = drawinfo.colorMount;
    int frameY = (int) ((double) Main.GlobalTimeWrappedHourly * 3.0 + (double) drawinfo.drawPlayer.position.X / 50.0) % 3;
    Rectangle rectangle = texture2D.Frame(verticalFrames: 3, frameY: frameY);
    Vector2 origin = new Vector2((float) (rectangle.Width / 2), (float) rectangle.Height);
    float rotation = (float) (-(double) drawinfo.drawPlayer.velocity.X * 0.10000000149011612) - drawinfo.drawPlayer.fullRotation;
    DrawData drawData = new DrawData(texture2D, drawinfo.drawPlayer.MountedCenter + vector2 - Main.screenPosition, new Rectangle?(rectangle), colorMount, rotation, origin, 1f, drawinfo.playerEffect);
    drawinfo.DrawDataCache.Add(drawData);
  }

  public static void DrawStarboardRainbowTrail(
    ref PlayerDrawSet drawinfo,
    Vector2 commonWingPosPreFloor,
    Vector2 dirsVec)
  {
    if ((double) drawinfo.shadow != 0.0)
      return;
    int num1 = Math.Min(drawinfo.drawPlayer.availableAdvancedShadowsCount - 1, 30);
    float num2 = 0.0f;
    for (int shadowIndex = num1; shadowIndex > 0; --shadowIndex)
    {
      EntityShadowInfo advancedShadow1 = drawinfo.drawPlayer.GetAdvancedShadow(shadowIndex);
      EntityShadowInfo advancedShadow2 = drawinfo.drawPlayer.GetAdvancedShadow(shadowIndex - 1);
      num2 += Vector2.Distance(advancedShadow1.Position, advancedShadow2.Position);
    }
    float num3 = MathHelper.Clamp(num2 / 160f, 0.0f, 1f);
    Main.instance.LoadProjectile(250);
    Texture2D texture = TextureAssets.Projectile[250].Value;
    float x = 1.7f;
    Vector2 origin = new Vector2((float) (texture.Width / 2), (float) (texture.Height / 2));
    Vector2 vector2_1 = new Vector2((float) drawinfo.drawPlayer.width, (float) drawinfo.drawPlayer.height) / 2f;
    Color white = Color.White with { A = 64 /*0x40*/ };
    Vector2 vector2_2 = drawinfo.drawPlayer.DefaultSize * new Vector2(0.5f, 1f) + new Vector2(0.0f, -4f);
    if ((double) dirsVec.Y < 0.0)
      vector2_2 = drawinfo.drawPlayer.DefaultSize * new Vector2(0.5f, 0.0f) + new Vector2(0.0f, 4f);
    for (int shadowIndex = num1; shadowIndex > 0; --shadowIndex)
    {
      EntityShadowInfo advancedShadow3 = drawinfo.drawPlayer.GetAdvancedShadow(shadowIndex);
      EntityShadowInfo advancedShadow4 = drawinfo.drawPlayer.GetAdvancedShadow(shadowIndex - 1);
      Vector2 pos1 = advancedShadow3.Position + vector2_2 + advancedShadow3.HeadgearOffset;
      Vector2 pos2 = advancedShadow4.Position + vector2_2 + advancedShadow4.HeadgearOffset;
      Vector2 vector2_3 = drawinfo.drawPlayer.RotatedRelativePoint(pos1, true, false);
      Vector2 vector2_4 = drawinfo.drawPlayer.RotatedRelativePoint(pos2, true, false);
      float num4 = (vector2_4 - vector2_3).ToRotation() - 1.57079637f;
      float rotation = 1.57079637f * (float) drawinfo.drawPlayer.direction;
      float t = Math.Abs(vector2_4.X - vector2_3.X);
      Vector2 scale = new Vector2(x, t / (float) texture.Height);
      float num5 = (float) (1.0 - (double) shadowIndex / (double) num1);
      float num6 = num5 * num5 * Utils.GetLerpValue(0.0f, 4f, t, true) * 0.5f;
      float num7 = num6 * num6;
      Color color = white * num7 * num3;
      if (!(color == Color.Transparent))
      {
        DrawData drawData = new DrawData(texture, vector2_3 - Main.screenPosition, new Rectangle?(), color, rotation, origin, scale, drawinfo.playerEffect);
        drawData.shader = drawinfo.cWings;
        drawinfo.DrawDataCache.Add(drawData);
        for (float amount = 0.25f; (double) amount < 1.0; amount += 0.25f)
        {
          drawData = new DrawData(texture, Vector2.Lerp(vector2_3, vector2_4, amount) - Main.screenPosition, new Rectangle?(), color, rotation, origin, scale, drawinfo.playerEffect);
          drawData.shader = drawinfo.cWings;
          drawinfo.DrawDataCache.Add(drawData);
        }
      }
    }
  }

  public static void DrawMeowcartTrail(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.mount.Type != 33 || (double) drawinfo.shadow > 0.0)
      return;
    int num1 = Math.Min(drawinfo.drawPlayer.availableAdvancedShadowsCount - 1, 20);
    float num2 = 0.0f;
    for (int shadowIndex = num1; shadowIndex > 0; --shadowIndex)
    {
      EntityShadowInfo advancedShadow1 = drawinfo.drawPlayer.GetAdvancedShadow(shadowIndex);
      EntityShadowInfo advancedShadow2 = drawinfo.drawPlayer.GetAdvancedShadow(shadowIndex - 1);
      num2 += Vector2.Distance(advancedShadow1.Position, advancedShadow2.Position);
    }
    float num3 = MathHelper.Clamp(num2 / 160f, 0.0f, 1f);
    Main.instance.LoadProjectile(250);
    Texture2D texture = TextureAssets.Projectile[250].Value;
    float x = 1.5f;
    Vector2 origin = new Vector2((float) (texture.Width / 2), 0.0f);
    Vector2 vector2_1 = new Vector2((float) drawinfo.drawPlayer.width, (float) drawinfo.drawPlayer.height) / 2f;
    Vector2 vector2_2 = new Vector2((float) (-drawinfo.drawPlayer.direction * 10), 15f);
    Color white = Color.White with { A = 127 /*0x7F*/ };
    Vector2 vector2_3 = vector2_2;
    Vector2 vector2_4 = vector2_1 + vector2_3;
    Vector2 zero = Vector2.Zero;
    Vector2 vector2_5 = drawinfo.drawPlayer.RotatedRelativePoint(drawinfo.drawPlayer.Center + zero + vector2_2) - drawinfo.drawPlayer.position;
    for (int shadowIndex = num1; shadowIndex > 0; --shadowIndex)
    {
      EntityShadowInfo advancedShadow3 = drawinfo.drawPlayer.GetAdvancedShadow(shadowIndex);
      EntityShadowInfo advancedShadow4 = drawinfo.drawPlayer.GetAdvancedShadow(shadowIndex - 1);
      Vector2 vector2_6 = advancedShadow3.Position + zero;
      Vector2 vector2_7 = advancedShadow4.Position + zero;
      Vector2 pos1 = vector2_6 + vector2_5;
      Vector2 pos2 = vector2_7 + vector2_5;
      Vector2 vector2_8 = drawinfo.drawPlayer.RotatedRelativePoint(pos1, true, false);
      Vector2 vector2_9 = drawinfo.drawPlayer.RotatedRelativePoint(pos2, true, false);
      float rotation = (vector2_9 - vector2_8).ToRotation() - 1.57079637f;
      float num4 = Vector2.Distance(vector2_8, vector2_9);
      Vector2 scale = new Vector2(x, num4 / (float) texture.Height);
      float num5 = (float) (1.0 - (double) shadowIndex / (double) num1);
      float num6 = num5 * num5;
      Color color = white * num6 * num3;
      DrawData drawData = new DrawData(texture, vector2_8 - Main.screenPosition, new Rectangle?(), color, rotation, origin, scale, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData);
    }
  }

  public static void DrawPlayer_23_MountFront(ref PlayerDrawSet drawinfo)
  {
    if (!drawinfo.drawPlayer.mount.Active)
      return;
    drawinfo.drawPlayer.mount.Draw(drawinfo.DrawDataCache, 2, drawinfo.drawPlayer, drawinfo.Position, drawinfo.colorMount, drawinfo.playerEffect, drawinfo.shadow);
    if (drawinfo.mountHandlesHeadDraw)
    {
      PlayerDrawLayers.DrawPlayer_21_Head(ref drawinfo);
      PlayerDrawLayers.DrawPlayer_22_FaceAcc(ref drawinfo);
      if (drawinfo.drawFrontAccInNeckAccLayer)
      {
        PlayerDrawLayers.DrawPlayer_extra_TorsoMinus(ref drawinfo);
        PlayerDrawLayers.DrawPlayer_32_FrontAcc_FrontPart(ref drawinfo);
        PlayerDrawLayers.DrawPlayer_extra_TorsoPlus(ref drawinfo);
      }
    }
    if (drawinfo.drawPlayer.mount.Type == 54)
      return;
    drawinfo.drawPlayer.mount.Draw(drawinfo.DrawDataCache, 3, drawinfo.drawPlayer, drawinfo.Position, drawinfo.colorMount, drawinfo.playerEffect, drawinfo.shadow);
  }

  public static void DrawPlayer_24_Pulley(ref PlayerDrawSet drawinfo)
  {
    if (!drawinfo.drawPlayer.pulley || drawinfo.drawPlayer.itemAnimation != 0)
      return;
    if (drawinfo.drawPlayer.pulleyDir == (byte) 2)
    {
      int num1 = -25;
      int num2 = 0;
      float rotation = 0.0f;
      DrawData drawData = new DrawData(TextureAssets.Pulley.Value, new Vector2((float) ((int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X + (double) (drawinfo.drawPlayer.width / 2) - (double) (9 * drawinfo.drawPlayer.direction)) + num2 * drawinfo.drawPlayer.direction), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) (drawinfo.drawPlayer.height / 2) + 2.0 * (double) drawinfo.drawPlayer.gravDir + (double) num1 * (double) drawinfo.drawPlayer.gravDir)), new Rectangle?(new Rectangle(0, TextureAssets.Pulley.Height() / 2 * drawinfo.drawPlayer.pulleyFrame, TextureAssets.Pulley.Width(), TextureAssets.Pulley.Height() / 2)), drawinfo.colorArmorHead, rotation, new Vector2((float) (TextureAssets.Pulley.Width() / 2), (float) (TextureAssets.Pulley.Height() / 4)), 1f, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData);
    }
    else
    {
      int num3 = -26;
      int num4 = 10;
      float rotation = 0.35f * (float) -drawinfo.drawPlayer.direction;
      DrawData drawData = new DrawData(TextureAssets.Pulley.Value, new Vector2((float) ((int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X + (double) (drawinfo.drawPlayer.width / 2) - (double) (9 * drawinfo.drawPlayer.direction)) + num4 * drawinfo.drawPlayer.direction), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) (drawinfo.drawPlayer.height / 2) + 2.0 * (double) drawinfo.drawPlayer.gravDir + (double) num3 * (double) drawinfo.drawPlayer.gravDir)), new Rectangle?(new Rectangle(0, TextureAssets.Pulley.Height() / 2 * drawinfo.drawPlayer.pulleyFrame, TextureAssets.Pulley.Width(), TextureAssets.Pulley.Height() / 2)), drawinfo.colorArmorHead, rotation, new Vector2((float) (TextureAssets.Pulley.Width() / 2), (float) (TextureAssets.Pulley.Height() / 4)), 1f, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData);
    }
  }

  public static void DrawPlayer_25_Shield(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.shield <= (sbyte) 0 || (int) drawinfo.drawPlayer.shield >= ArmorIDs.Shield.Count)
      return;
    Vector2 zero1 = Vector2.Zero;
    if (drawinfo.drawPlayer.shieldRaised)
      zero1.Y -= 4f * drawinfo.drawPlayer.gravDir;
    Rectangle bodyFrame = drawinfo.drawPlayer.bodyFrame;
    Vector2 zero2 = Vector2.Zero;
    Vector2 bodyVect = drawinfo.bodyVect;
    if (bodyFrame.Width != TextureAssets.AccShield[(int) drawinfo.drawPlayer.shield].Value.Width)
    {
      bodyFrame.Width = TextureAssets.AccShield[(int) drawinfo.drawPlayer.shield].Value.Width;
      bodyVect.X += (float) (bodyFrame.Width - TextureAssets.AccShield[(int) drawinfo.drawPlayer.shield].Value.Width);
      if ((drawinfo.playerEffect & SpriteEffects.FlipHorizontally) != SpriteEffects.None)
        bodyVect.X = (float) bodyFrame.Width - bodyVect.X;
    }
    DrawData drawData;
    if (drawinfo.drawPlayer.shieldRaised)
    {
      float num1 = (float) Math.Sin((double) Main.GlobalTimeWrappedHourly * 6.2831854820251465);
      float x = (float) (2.5 + 1.5 * (double) num1);
      Color colorArmorBody = drawinfo.colorArmorBody with
      {
        A = 0
      };
      colorArmorBody *= (float) (0.44999998807907104 - (double) num1 * 0.15000000596046448);
      for (float num2 = 0.0f; (double) num2 < 4.0; ++num2)
      {
        drawData = new DrawData(TextureAssets.AccShield[(int) drawinfo.drawPlayer.shield].Value, zero2 + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)) + zero1 + new Vector2(x, 0.0f).RotatedBy((double) num2 / 4.0 * 6.2831854820251465), new Rectangle?(bodyFrame), colorArmorBody, drawinfo.drawPlayer.bodyRotation, bodyVect, 1f, drawinfo.playerEffect);
        drawData.shader = drawinfo.cShield;
        drawinfo.DrawDataCache.Add(drawData);
      }
    }
    drawData = new DrawData(TextureAssets.AccShield[(int) drawinfo.drawPlayer.shield].Value, zero2 + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)) + zero1, new Rectangle?(bodyFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, bodyVect, 1f, drawinfo.playerEffect);
    drawData.shader = drawinfo.cShield;
    drawinfo.DrawDataCache.Add(drawData);
    if (drawinfo.drawPlayer.shieldRaised)
    {
      Color colorArmorBody = drawinfo.colorArmorBody;
      float num = (float) Math.Sin((double) Main.GlobalTimeWrappedHourly * 3.1415927410125732);
      colorArmorBody.A = (byte) ((double) colorArmorBody.A * (0.5 + 0.5 * (double) num));
      colorArmorBody *= (float) (0.5 + 0.5 * (double) num);
      drawData = new DrawData(TextureAssets.AccShield[(int) drawinfo.drawPlayer.shield].Value, zero2 + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)) + zero1, new Rectangle?(bodyFrame), colorArmorBody, drawinfo.drawPlayer.bodyRotation, bodyVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cShield;
    }
    if (drawinfo.drawPlayer.shieldRaised && drawinfo.drawPlayer.shieldParryTimeLeft > 0)
    {
      float num3 = (float) drawinfo.drawPlayer.shieldParryTimeLeft / 20f;
      float num4 = 1.5f * num3;
      Vector2 vector2_1 = zero2 + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)) + zero1;
      Color colorArmorBody = drawinfo.colorArmorBody;
      float num5 = 1f;
      Vector2 vector2_2 = drawinfo.Position + drawinfo.drawPlayer.Size / 2f - Main.screenPosition;
      Vector2 vector2_3 = vector2_1 - vector2_2;
      Vector2 position = vector2_1 + vector2_3 * num4;
      float scale = num5 + num4;
      colorArmorBody.A = (byte) ((double) colorArmorBody.A * (1.0 - (double) num3));
      colorArmorBody *= 1f - num3;
      drawData = new DrawData(TextureAssets.AccShield[(int) drawinfo.drawPlayer.shield].Value, position, new Rectangle?(bodyFrame), colorArmorBody, drawinfo.drawPlayer.bodyRotation, bodyVect, scale, drawinfo.playerEffect);
      drawData.shader = drawinfo.cShield;
      drawinfo.DrawDataCache.Add(drawData);
    }
    if (!drawinfo.drawPlayer.mount.Cart)
      return;
    drawinfo.DrawDataCache.Reverse(drawinfo.DrawDataCache.Count - 2, 2);
  }

  public static void DrawPlayer_26_SolarShield(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.solarShields <= 0 || (double) drawinfo.shadow != 0.0 || drawinfo.drawPlayer.dead)
      return;
    Texture2D texture2D = TextureAssets.Extra[61 + drawinfo.drawPlayer.solarShields - 1].Value;
    Color color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) sbyte.MaxValue);
    float rotation1 = (drawinfo.drawPlayer.solarShieldPos[0] * new Vector2(1f, 0.5f)).ToRotation();
    if (drawinfo.drawPlayer.direction == -1)
      rotation1 += 3.14159274f;
    float rotation2 = rotation1 + 0.06283186f * (float) drawinfo.drawPlayer.direction;
    drawinfo.DrawDataCache.Add(new DrawData(texture2D, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) (drawinfo.drawPlayer.height / 2))) + drawinfo.drawPlayer.solarShieldPos[0], new Rectangle?(), color, rotation2, texture2D.Size() / 2f, 1f, drawinfo.playerEffect)
    {
      shader = drawinfo.cBody
    });
  }

  public static void DrawPlayer_27_HeldItem(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.JustDroppedAnItem || !drawinfo.drawPlayer.IsAllowedToHoldItems)
      return;
    if (drawinfo.SelectedDrawnProjectile != null && (double) drawinfo.shadow == 0.0 && drawinfo.SelectedDrawnProjectile.drawLayer == 7)
      drawinfo.projectileDrawPosition = drawinfo.DrawDataCache.Count;
    Item heldItem = drawinfo.heldItem;
    int index1 = heldItem.type;
    if (drawinfo.drawPlayer.UsingBiomeTorches)
    {
      switch (index1)
      {
        case 8:
          index1 = drawinfo.drawPlayer.BiomeTorchHoldStyle(index1);
          break;
        case 966:
          index1 = drawinfo.drawPlayer.BiomeCampfireHoldStyle(index1);
          break;
      }
    }
    float adjustedItemScale = drawinfo.drawPlayer.GetAdjustedItemScale(heldItem);
    Main.instance.LoadItem(index1);
    Texture2D texture2D1 = TextureAssets.Item[index1].Value;
    Vector2 position1 = new Vector2((float) (int) ((double) drawinfo.ItemLocation.X - (double) Main.screenPosition.X), (float) (int) ((double) drawinfo.ItemLocation.Y - (double) Main.screenPosition.Y));
    Rectangle r1 = drawinfo.drawPlayer.GetItemDrawFrame(index1);
    if (index1 == 5629)
    {
      texture2D1 = TextureAssets.Extra[285].Value;
      r1 = texture2D1.Frame();
    }
    bool drawUseStyle = drawinfo.drawPlayer.itemAnimation > 0 && heldItem.useStyle != 0;
    bool drawHoldStyle = heldItem.holdStyle != 0 && !drawinfo.drawPlayer.pulley;
    if (!drawinfo.drawPlayer.CanVisuallyHoldItem(heldItem))
      drawHoldStyle = false;
    drawinfo.itemColor = Lighting.GetColor((int) ((double) drawinfo.Position.X + (double) drawinfo.drawPlayer.width * 0.5) / 16 /*0x10*/, (int) (((double) drawinfo.Position.Y + (double) drawinfo.drawPlayer.height * 0.5) / 16.0));
    if (index1 == 678)
      drawinfo.itemColor = Color.White;
    PlayerDrawLayers.DrawPlayer_27_HeldItem_ApplyStealthToColor(ref drawinfo, heldItem, drawUseStyle, drawHoldStyle, ref drawinfo.itemColor);
    if ((double) drawinfo.shadow != 0.0 || drawinfo.drawPlayer.frozen || !(drawUseStyle | drawHoldStyle) || index1 <= 0 || drawinfo.drawPlayer.dead || heldItem.noUseGraphic || drawinfo.drawPlayer.wet && heldItem.noWet || drawinfo.drawPlayer.happyFunTorchTime && drawinfo.drawPlayer.inventory[drawinfo.drawPlayer.selectedItem].createTile == 4 && drawinfo.drawPlayer.itemAnimation == 0)
      return;
    string name = drawinfo.drawPlayer.name;
    Color color1 = Color.White;
    Vector2 vector2_1 = Vector2.Zero;
    if (index1 <= 1506)
    {
      if (index1 <= 204)
      {
        if (index1 != 46)
        {
          if (index1 != 104)
          {
            if (index1 == 204)
            {
              vector2_1 = new Vector2(4f, -6f) * drawinfo.drawPlayer.Directions;
              goto label_38;
            }
            goto label_38;
          }
        }
        else
        {
          color1 = Color.Lerp(Color.Transparent, new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) sbyte.MaxValue) * 0.7f, Utils.Remap(drawinfo.itemColor.ToVector3().Length() / 1.731f, 0.3f, 0.5f, 1f, 0.0f));
          goto label_38;
        }
      }
      else
      {
        if (index1 == 426 || index1 == 797 || index1 == 1506)
          goto label_31;
        goto label_38;
      }
    }
    else if (index1 <= 5097)
    {
      if (index1 != 3349)
      {
        if ((uint) (index1 - 5094) > 1U)
        {
          if ((uint) (index1 - 5096) <= 1U)
            goto label_31;
          goto label_38;
        }
      }
      else
      {
        vector2_1 = new Vector2(2f, -2f) * drawinfo.drawPlayer.Directions;
        goto label_38;
      }
    }
    else
    {
      if (index1 != 5462)
      {
        if (index1 != 5669)
        {
          if ((uint) (index1 - 5670) <= 1U)
          {
            color1 = Item.GetPhaseColor(heldItem.shoot);
            goto label_38;
          }
          goto label_38;
        }
        float amount = Utils.WrappedLerp(0.5f, 1f, (float) (Main.LocalPlayer.miscCounter % 100) / 100f);
        color1 = Color.Lerp(color1, new Color(180, 85, 30), amount) with
        {
          A = (byte) heldItem.alpha
        };
        goto label_38;
      }
      vector2_1 = new Vector2(12f, -14f) * drawinfo.drawPlayer.Directions;
      color1 = new Color((int) byte.MaxValue, 140, 0, 5);
      color1 = Color.Transparent;
      if (drawinfo.SelectedDrawnProjectile != null)
      {
        Projectile selectedDrawnProjectile = drawinfo.SelectedDrawnProjectile;
        if (selectedDrawnProjectile.active && selectedDrawnProjectile.type == 1040)
        {
          color1 = Color.Lerp(Color.Transparent, new Color((int) byte.MaxValue, 140, 0, 5), Utils.Remap(selectedDrawnProjectile.ai[1], 0.0f, 30f, 0.0f, 1f));
          goto label_38;
        }
        goto label_38;
      }
      goto label_38;
    }
    vector2_1 = new Vector2(4f, -4f) * drawinfo.drawPlayer.Directions;
    goto label_38;
label_31:
    vector2_1 = new Vector2(6f, -6f) * drawinfo.drawPlayer.Directions;
label_38:
    if (index1 == 3823)
      vector2_1 = new Vector2((float) (7 * drawinfo.drawPlayer.direction), -7f * drawinfo.drawPlayer.gravDir);
    if (index1 == 3827)
    {
      vector2_1 = new Vector2((float) (13 * drawinfo.drawPlayer.direction), -13f * drawinfo.drawPlayer.gravDir);
      color1 = heldItem.GetAlpha(drawinfo.itemColor);
      color1 = Color.Lerp(color1, Color.White, 0.6f) with
      {
        A = (byte) 66
      };
    }
    PlayerDrawLayers.DrawPlayer_27_HeldItem_ApplyStealthToColor(ref drawinfo, heldItem, drawUseStyle, drawHoldStyle, ref color1);
    Vector2 vector2_2 = new Vector2((float) ((double) r1.Width * 0.5 - (double) r1.Width * 0.5 * (double) drawinfo.drawPlayer.direction), (float) r1.Height);
    if (heldItem.useStyle == 9 && drawinfo.drawPlayer.itemAnimation > 0)
    {
      Vector2 vector2_3 = new Vector2(0.5f, 0.4f);
      if (heldItem.type == 5009 || heldItem.type == 5042 || heldItem.type == 5645)
      {
        vector2_3 = new Vector2(0.26f, 0.5f);
        if (drawinfo.drawPlayer.direction == -1)
          vector2_3.X = 1f - vector2_3.X;
      }
      vector2_2 = r1.Size() * vector2_3;
    }
    if ((double) drawinfo.drawPlayer.gravDir == -1.0)
      vector2_2.Y = (float) r1.Height - vector2_2.Y;
    Vector2 origin1 = vector2_2 + vector2_1;
    float rotation1 = drawinfo.drawPlayer.itemRotation;
    if (heldItem.useStyle == 8)
    {
      ref float local = ref position1.X;
      double num = (double) local;
      int direction = drawinfo.drawPlayer.direction;
      local = (float) (num - 0.0);
      rotation1 -= 1.57079637f * (float) drawinfo.drawPlayer.direction;
      origin1.Y = 2f;
      origin1.X += (float) (2 * drawinfo.drawPlayer.direction);
    }
    if (index1 == 425 || index1 == 507)
      drawinfo.itemEffect = (double) drawinfo.drawPlayer.gravDir != 1.0 ? (drawinfo.drawPlayer.direction != 1 ? SpriteEffects.FlipHorizontally : SpriteEffects.None) : (drawinfo.drawPlayer.direction != 1 ? SpriteEffects.FlipHorizontally | SpriteEffects.FlipVertically : SpriteEffects.FlipVertically);
    if ((index1 == 946 || index1 == 4707) && (double) rotation1 != 0.0)
    {
      position1.Y -= 22f * drawinfo.drawPlayer.gravDir;
      rotation1 = -1.57f * (float) -drawinfo.drawPlayer.direction * drawinfo.drawPlayer.gravDir;
    }
    ItemSlot.GetItemLight(ref drawinfo.itemColor, heldItem, lightScalar: drawinfo.drawPlayer.stealth);
    switch (index1)
    {
      case 3476:
        Texture2D texture2D2 = TextureAssets.Extra[64 /*0x40*/].Value;
        Rectangle r2 = texture2D2.Frame(verticalFrames: 9, frameY: drawinfo.drawPlayer.miscCounter % 54 / 6);
        Vector2 vector2_4 = new Vector2((float) (r2.Width / 2 * drawinfo.drawPlayer.direction), 0.0f);
        Vector2 origin2 = r2.Size() / 2f;
        DrawData drawData1 = new DrawData(texture2D2, (drawinfo.ItemLocation - Main.screenPosition + vector2_4).Floor(), new Rectangle?(r2), heldItem.GetAlpha(drawinfo.itemColor).MultiplyRGBA(new Color(new Vector4(0.5f, 0.5f, 0.5f, 0.8f))), drawinfo.drawPlayer.itemRotation, origin2, adjustedItemScale, drawinfo.itemEffect);
        drawinfo.DrawDataCache.Add(drawData1);
        drawData1 = new DrawData(TextureAssets.GlowMask[195].Value, (drawinfo.ItemLocation - Main.screenPosition + vector2_4).Floor(), new Rectangle?(r2), new Color(250, 250, 250, heldItem.alpha) * 0.5f, drawinfo.drawPlayer.itemRotation, origin2, adjustedItemScale, drawinfo.itemEffect);
        drawinfo.DrawDataCache.Add(drawData1);
        break;
      case 3779:
        Texture2D texture2D3 = texture2D1;
        Rectangle r3 = texture2D3.Frame();
        Vector2 vector2_5 = new Vector2((float) (r3.Width / 2 * drawinfo.drawPlayer.direction), 0.0f);
        Vector2 origin3 = r3.Size() / 2f;
        Color color2 = new Color(120, 40, 222, 0) * (float) (((double) ((float) ((double) drawinfo.drawPlayer.miscCounter / 75.0 * 6.2831854820251465)).ToRotationVector2().X * 1.0 + 0.0) / 2.0 * 0.30000001192092896 + 0.85000002384185791) * 0.5f;
        float num1 = 2f;
        DrawData drawData2;
        for (float num2 = 0.0f; (double) num2 < 4.0; ++num2)
        {
          drawData2 = new DrawData(TextureAssets.GlowMask[218].Value, (drawinfo.ItemLocation - Main.screenPosition + vector2_5).Floor() + (num2 * 1.57079637f).ToRotationVector2() * num1, new Rectangle?(r3), color2, drawinfo.drawPlayer.itemRotation, origin3, adjustedItemScale, drawinfo.itemEffect);
          drawinfo.DrawDataCache.Add(drawData2);
        }
        drawData2 = new DrawData(texture2D3, (drawinfo.ItemLocation - Main.screenPosition + vector2_5).Floor(), new Rectangle?(r3), heldItem.GetAlpha(drawinfo.itemColor).MultiplyRGBA(new Color(new Vector4(0.5f, 0.5f, 0.5f, 0.8f))), drawinfo.drawPlayer.itemRotation, origin3, adjustedItemScale, drawinfo.itemEffect);
        drawinfo.DrawDataCache.Add(drawData2);
        break;
      case 4049:
        Texture2D texture2D4 = TextureAssets.Extra[92].Value;
        Rectangle r4 = texture2D4.Frame(verticalFrames: 4, frameY: drawinfo.drawPlayer.miscCounter % 20 / 5);
        Vector2 vector2_6 = new Vector2((float) (r4.Width / 2 * drawinfo.drawPlayer.direction), 0.0f);
        vector2_6 += new Vector2((float) (-10 * drawinfo.drawPlayer.direction), 8f * drawinfo.drawPlayer.gravDir);
        Vector2 origin4 = r4.Size() / 2f;
        DrawData drawData3 = new DrawData(texture2D4, (drawinfo.ItemLocation - Main.screenPosition + vector2_6).Floor(), new Rectangle?(r4), heldItem.GetAlpha(drawinfo.itemColor), drawinfo.drawPlayer.itemRotation, origin4, adjustedItemScale, drawinfo.itemEffect);
        drawinfo.DrawDataCache.Add(drawData3);
        break;
      default:
        if (heldItem.useStyle == 5)
        {
          if (Item.staff[index1])
          {
            float num3 = drawinfo.drawPlayer.itemRotation + 0.785f * (float) drawinfo.drawPlayer.direction;
            float num4 = 0.0f;
            float num5 = 0.0f;
            Vector2 origin5 = new Vector2(0.0f, (float) r1.Height);
            if (index1 == 3210)
            {
              num4 = (float) (8 * -drawinfo.drawPlayer.direction);
              num5 = (float) (2 * (int) drawinfo.drawPlayer.gravDir);
            }
            if (index1 == 3870)
            {
              Vector2 vector2_7 = (drawinfo.drawPlayer.itemRotation + 0.7853982f * (float) drawinfo.drawPlayer.direction).ToRotationVector2() * new Vector2((float) -drawinfo.drawPlayer.direction * 1.5f, drawinfo.drawPlayer.gravDir) * 3f;
              num4 = (float) (int) vector2_7.X;
              num5 = (float) (int) vector2_7.Y;
            }
            if (index1 == 3787)
              num5 = (float) (int) ((double) (8 * (int) drawinfo.drawPlayer.gravDir) * Math.Cos((double) num3));
            if (index1 == 3209)
            {
              Vector2 vector2_8 = (new Vector2(-8f, 0.0f) * drawinfo.drawPlayer.Directions).RotatedBy((double) drawinfo.drawPlayer.itemRotation);
              num4 = vector2_8.X;
              num5 = vector2_8.Y;
            }
            if ((double) drawinfo.drawPlayer.gravDir == -1.0)
            {
              if (drawinfo.drawPlayer.direction == -1)
              {
                num3 += 1.57f;
                origin5 = new Vector2((float) r1.Width, 0.0f);
                num4 -= (float) r1.Width;
              }
              else
              {
                num3 -= 1.57f;
                origin5 = Vector2.Zero;
              }
            }
            else if (drawinfo.drawPlayer.direction == -1)
            {
              origin5 = new Vector2((float) r1.Width, (float) r1.Height);
              num4 -= (float) r1.Width;
            }
            DrawData drawData4 = new DrawData(texture2D1, new Vector2((float) (int) ((double) drawinfo.ItemLocation.X - (double) Main.screenPosition.X + (double) origin5.X + (double) num4), (float) (int) ((double) drawinfo.ItemLocation.Y - (double) Main.screenPosition.Y + (double) num5)), new Rectangle?(r1), heldItem.GetAlpha(drawinfo.itemColor), num3, origin5, adjustedItemScale, drawinfo.itemEffect);
            drawinfo.DrawDataCache.Add(drawData4);
            if (index1 != 3870)
              break;
            drawData4 = new DrawData(TextureAssets.GlowMask[238].Value, new Vector2((float) (int) ((double) drawinfo.ItemLocation.X - (double) Main.screenPosition.X + (double) origin5.X + (double) num4), (float) (int) ((double) drawinfo.ItemLocation.Y - (double) Main.screenPosition.Y + (double) num5)), new Rectangle?(r1), new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) sbyte.MaxValue), num3, origin5, adjustedItemScale, drawinfo.itemEffect);
            drawinfo.DrawDataCache.Add(drawData4);
            break;
          }
          if (index1 == 5118)
          {
            float rotation2 = drawinfo.drawPlayer.itemRotation + 1.57f * (float) drawinfo.drawPlayer.direction;
            Vector2 origin6 = new Vector2((float) r1.Width * 0.5f, (float) r1.Height);
            Vector2 vector2_9 = (new Vector2(10f, 4f) * drawinfo.drawPlayer.Directions).RotatedBy((double) drawinfo.drawPlayer.itemRotation);
            vector2_9.Y += (float) r1.Height * 0.5f;
            DrawData drawData5 = new DrawData(texture2D1, new Vector2((float) (int) ((double) drawinfo.ItemLocation.X - (double) Main.screenPosition.X + (double) vector2_9.X), (float) (int) ((double) drawinfo.ItemLocation.Y - (double) Main.screenPosition.Y + (double) vector2_9.Y)), new Rectangle?(r1), heldItem.GetAlpha(drawinfo.itemColor), rotation2, origin6, adjustedItemScale, drawinfo.itemEffect);
            drawinfo.DrawDataCache.Add(drawData5);
            break;
          }
          Vector2 vector2_10 = new Vector2(0.0f, (float) (r1.Height / 2));
          Vector2 vector2_11 = Main.DrawPlayerItemPos(drawinfo.drawPlayer.gravDir, index1);
          int x = (int) vector2_11.X;
          vector2_10.Y = vector2_11.Y;
          Vector2 origin7 = new Vector2((float) -x, (float) (r1.Height / 2));
          if (drawinfo.drawPlayer.direction == -1)
            origin7 = new Vector2((float) (r1.Width + x), (float) (r1.Height / 2));
          DrawData drawData6 = new DrawData(texture2D1, new Vector2((float) (int) ((double) drawinfo.ItemLocation.X - (double) Main.screenPosition.X + (double) vector2_10.X), (float) (int) ((double) drawinfo.ItemLocation.Y - (double) Main.screenPosition.Y + (double) vector2_10.Y)), new Rectangle?(r1), heldItem.GetAlpha(drawinfo.itemColor), drawinfo.drawPlayer.itemRotation, origin7, adjustedItemScale, drawinfo.itemEffect);
          drawinfo.DrawDataCache.Add(drawData6);
          if (heldItem.color != new Color())
          {
            drawData6 = new DrawData(texture2D1, new Vector2((float) (int) ((double) drawinfo.ItemLocation.X - (double) Main.screenPosition.X + (double) vector2_10.X), (float) (int) ((double) drawinfo.ItemLocation.Y - (double) Main.screenPosition.Y + (double) vector2_10.Y)), new Rectangle?(r1), heldItem.GetColor(drawinfo.itemColor), drawinfo.drawPlayer.itemRotation, origin7, adjustedItemScale, drawinfo.itemEffect);
            drawinfo.DrawDataCache.Add(drawData6);
          }
          if (heldItem.glowMask != (short) -1)
          {
            Color white = Color.White;
            PlayerDrawLayers.DrawPlayer_27_HeldItem_ApplyStealthToColor(ref drawinfo, heldItem, drawUseStyle, drawHoldStyle, ref white);
            drawData6 = new DrawData(TextureAssets.GlowMask[(int) heldItem.glowMask].Value, new Vector2((float) (int) ((double) drawinfo.ItemLocation.X - (double) Main.screenPosition.X + (double) vector2_10.X), (float) (int) ((double) drawinfo.ItemLocation.Y - (double) Main.screenPosition.Y + (double) vector2_10.Y)), new Rectangle?(r1), white, drawinfo.drawPlayer.itemRotation, origin7, adjustedItemScale, drawinfo.itemEffect);
            drawinfo.DrawDataCache.Add(drawData6);
          }
          if (index1 != 3788)
            break;
          float num6 = (float) ((double) ((float) ((double) drawinfo.drawPlayer.miscCounter / 75.0 * 6.2831854820251465)).ToRotationVector2().X * 1.0 + 0.0);
          Color color3 = new Color(80 /*0x50*/, 40, 252, 0) * (float) ((double) num6 / 2.0 * 0.30000001192092896 + 0.85000002384185791) * 0.5f;
          PlayerDrawLayers.DrawPlayer_27_HeldItem_ApplyStealthToColor(ref drawinfo, heldItem, drawUseStyle, drawHoldStyle, ref color3);
          for (float num7 = 0.0f; (double) num7 < 4.0; ++num7)
          {
            drawData6 = new DrawData(TextureAssets.GlowMask[220].Value, new Vector2((float) (int) ((double) drawinfo.ItemLocation.X - (double) Main.screenPosition.X + (double) vector2_10.X), (float) (int) ((double) drawinfo.ItemLocation.Y - (double) Main.screenPosition.Y + (double) vector2_10.Y)) + (num7 * 1.57079637f + drawinfo.drawPlayer.itemRotation).ToRotationVector2() * num6, new Rectangle?(), color3, drawinfo.drawPlayer.itemRotation, origin7, adjustedItemScale, drawinfo.itemEffect);
            drawinfo.DrawDataCache.Add(drawData6);
          }
          break;
        }
        DrawData drawData7 = new DrawData(texture2D1, position1, new Rectangle?(r1), heldItem.GetAlpha(drawinfo.itemColor), rotation1, origin1, adjustedItemScale, drawinfo.itemEffect);
        drawinfo.DrawDataCache.Add(drawData7);
        if (heldItem.color != new Color())
        {
          drawData7 = new DrawData(texture2D1, position1, new Rectangle?(r1), heldItem.GetColor(drawinfo.itemColor), rotation1, origin1, adjustedItemScale, drawinfo.itemEffect);
          drawinfo.DrawDataCache.Add(drawData7);
        }
        if (heldItem.glowMask != (short) -1)
        {
          if (index1 == 5670 || index1 == 5671)
          {
            drawData7 = new DrawData(TextureAssets.GlowMask[(int) heldItem.glowMask].Value, position1, new Rectangle?(r1), color1, rotation1, origin1, adjustedItemScale, drawinfo.itemEffect);
            drawinfo.DrawDataCache.Add(drawData7);
            color1 = Item.GetPhaseColor(heldItem.shoot, true);
            PlayerDrawLayers.DrawPlayer_27_HeldItem_ApplyStealthToColor(ref drawinfo, heldItem, drawUseStyle, drawHoldStyle, ref color1);
          }
          drawData7 = new DrawData(TextureAssets.GlowMask[(int) heldItem.glowMask].Value, position1, new Rectangle?(r1), color1, rotation1, origin1, adjustedItemScale, drawinfo.itemEffect);
          drawinfo.DrawDataCache.Add(drawData7);
        }
        if (heldItem.type == 5462 && drawinfo.SelectedDrawnProjectile != null)
        {
          Projectile selectedDrawnProjectile = drawinfo.SelectedDrawnProjectile;
          if (selectedDrawnProjectile.active && selectedDrawnProjectile.type == 1040)
          {
            float fromValue = selectedDrawnProjectile.ai[1];
            color1 = Color.Lerp(Color.Transparent, new Color((int) byte.MaxValue, 180, 60, 0), Utils.Remap(selectedDrawnProjectile.ai[1], 0.0f, 30f, 0.0f, 1f));
            float num8 = Utils.Remap(fromValue, 20f, 26f, 0.0f, 1f) * Utils.Remap(fromValue, 26f, 32f, 1f, 0.0f);
            float num9 = Utils.Remap(fromValue, 23f, 29f, 0.0f, 1f);
            float num10 = (float) (1.0 - (1.0 - (double) num9) * (1.0 - (double) num9));
            float scale1 = adjustedItemScale * (float) (1.0 + (double) num10 * 0.30000001192092896);
            Vector2 position2 = position1 - new Vector2((float) drawinfo.drawPlayer.direction, -drawinfo.drawPlayer.gravDir).RotatedBy((double) drawinfo.drawPlayer.itemRotation) * (float) ((double) scale1 * 4.0 + 3.0);
            for (float num11 = 0.0f; (double) num11 < 6.2831854820251465; num11 += 1.57079637f)
            {
              drawData7 = new DrawData(TextureAssets.GlowMask[(int) heldItem.glowMask].Value, position2, new Rectangle?(r1), color1 * num8, rotation1, origin1, scale1, drawinfo.itemEffect);
              drawinfo.DrawDataCache.Add(drawData7);
            }
            int num12 = 37;
            Vector2 position3 = position1 + new Vector2((float) (num12 * drawinfo.drawPlayer.direction), (float) -num12 * drawinfo.drawPlayer.gravDir).RotatedBy((double) drawinfo.drawPlayer.itemRotation) * adjustedItemScale;
            Texture2D texture2D5 = TextureAssets.Extra[174].Value;
            float scale2 = (1f - num10) * 0.85f;
            drawData7 = new DrawData(texture2D5, position3, new Rectangle?(), color1 * num8, 0.0f, texture2D5.Frame().Size() / 2f, scale2, drawinfo.itemEffect);
            drawinfo.DrawDataCache.Add(drawData7);
            drawData7 = new DrawData(texture2D5, position3, new Rectangle?(), Color.White * num8, 0.0f, texture2D5.Frame().Size() / 2f, scale2 * 0.92f, drawinfo.itemEffect);
            drawinfo.DrawDataCache.Add(drawData7);
          }
        }
        if (!heldItem.flame)
          break;
        if ((double) drawinfo.shadow != 0.0)
          break;
        try
        {
          Main.instance.LoadItemFlames(index1);
          if (!TextureAssets.ItemFlame[index1].IsLoaded)
            break;
          Color color4 = new Color(100, 100, 100, 0);
          int num13 = 7;
          float num14 = 1f;
          float num15 = 0.0f;
          switch (index1)
          {
            case 3045:
              color4 = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB, 0);
              break;
            case 4952:
              num13 = 3;
              num14 = 0.6f;
              color4 = new Color(50, 50, 50, 0);
              break;
            case 5293:
              color4 = new Color(50, 50, 100, 20);
              break;
            case 5322:
              color4 = new Color(100, 100, 100, 150);
              num15 = (float) (-2 * drawinfo.drawPlayer.direction);
              break;
            case 5353:
              color4 = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 200);
              break;
          }
          PlayerDrawLayers.DrawPlayer_27_HeldItem_ApplyStealthToColor(ref drawinfo, heldItem, drawUseStyle, drawHoldStyle, ref color4);
          for (int index2 = 0; index2 < num13; ++index2)
          {
            float num16 = drawinfo.drawPlayer.itemFlamePos[index2].X * adjustedItemScale * num14;
            float num17 = drawinfo.drawPlayer.itemFlamePos[index2].Y * adjustedItemScale * num14;
            drawData7 = new DrawData(TextureAssets.ItemFlame[index1].Value, new Vector2((float) (int) ((double) position1.X + (double) num16 + (double) num15), (float) (int) ((double) position1.Y + (double) num17)), new Rectangle?(r1), color4, rotation1, origin1, adjustedItemScale, drawinfo.itemEffect);
            drawinfo.DrawDataCache.Add(drawData7);
          }
          break;
        }
        catch
        {
          break;
        }
    }
  }

  private static void DrawPlayer_27_HeldItem_ApplyStealthToColor(
    ref PlayerDrawSet drawinfo,
    Item playerItem,
    bool drawUseStyle,
    bool drawHoldStyle,
    ref Color color)
  {
    bool flag1 = drawUseStyle && playerItem.ranged;
    bool flag2 = !drawUseStyle & drawHoldStyle;
    if (drawinfo.drawPlayer.shroomiteStealth && flag1 | flag2)
    {
      float num1 = drawinfo.drawPlayer.stealth;
      if ((double) num1 < 0.029999999329447746)
        num1 = 0.03f;
      float num2 = (float) ((1.0 + (double) num1 * 10.0) / 11.0);
      color = new Color((int) (byte) ((double) color.R * (double) num1), (int) (byte) ((double) color.G * (double) num1), (int) (byte) ((double) color.B * (double) num2), (int) (byte) ((double) color.A * (double) num1));
    }
    if (!drawinfo.drawPlayer.setVortex || !(flag1 | flag2))
      return;
    float num3 = drawinfo.drawPlayer.stealth;
    if ((double) num3 < 0.029999999329447746)
      num3 = 0.03f;
    double num4 = (1.0 + (double) num3 * 10.0) / 11.0;
    color = color.MultiplyRGBA(new Color(Vector4.Lerp(Vector4.One, new Vector4(0.0f, 0.12f, 0.16f, 0.0f), 1f - num3)));
  }

  public static void DrawPlayer_28_ArmOverItem(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.mount.Active && drawinfo.drawPlayer.mount.Type == 54)
      drawinfo.drawPlayer.mount.Draw(drawinfo.DrawDataCache, 3, drawinfo.drawPlayer, drawinfo.Position, drawinfo.colorMount, drawinfo.playerEffect, drawinfo.shadow);
    else if (drawinfo.usesCompositeTorso)
      PlayerDrawLayers.DrawPlayer_28_ArmOverItemComposite(ref drawinfo);
    else if (drawinfo.drawPlayer.body > 0 && drawinfo.drawPlayer.body < ArmorIDs.Body.Count)
    {
      Rectangle bodyFrame = drawinfo.drawPlayer.bodyFrame;
      int num1 = drawinfo.armorAdjust;
      bodyFrame.X += num1;
      bodyFrame.Width -= num1;
      if (drawinfo.drawPlayer.direction == -1)
        num1 = 0;
      if (drawinfo.drawPlayer.invis && (drawinfo.drawPlayer.body == 21 || drawinfo.drawPlayer.body == 22))
        return;
      DrawData drawData1;
      if (drawinfo.missingHand && !drawinfo.drawPlayer.invis)
      {
        int body = drawinfo.drawPlayer.body;
        DrawData drawData2;
        if (drawinfo.missingArm)
        {
          drawData2 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 7].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorBodySkin, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
          drawData2.shader = drawinfo.skinDyePacked;
          DrawData drawData3 = drawData2;
          drawinfo.DrawDataCache.Add(drawData3);
        }
        drawData2 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 9].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorBodySkin, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
        drawData2.shader = drawinfo.skinDyePacked;
        drawData1 = drawData2;
        drawinfo.DrawDataCache.Add(drawData1);
      }
      drawData1 = new DrawData(TextureAssets.ArmorArm[drawinfo.drawPlayer.body].Value, new Vector2((float) ((int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)) + num1), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(bodyFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
      drawData1.shader = drawinfo.cBody;
      drawinfo.DrawDataCache.Add(drawData1);
      if (drawinfo.armGlowMask != -1)
      {
        drawData1 = new DrawData(TextureAssets.GlowMask[drawinfo.armGlowMask].Value, new Vector2((float) ((int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)) + num1), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(bodyFrame), drawinfo.armGlowColor, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
        drawData1.shader = drawinfo.cBody;
        drawinfo.DrawDataCache.Add(drawData1);
      }
      if (drawinfo.drawPlayer.body != 205)
        return;
      Color color = new Color(100, 100, 100, 0);
      ulong seed = (ulong) (drawinfo.drawPlayer.miscCounter / 4);
      int num2 = 4;
      for (int index = 0; index < num2; ++index)
      {
        float num3 = (float) Utils.RandomInt(ref seed, -10, 11) * 0.2f;
        float num4 = (float) Utils.RandomInt(ref seed, -10, 1) * 0.15f;
        drawData1 = new DrawData(TextureAssets.GlowMask[240 /*0xF0*/].Value, new Vector2((float) ((int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)) + num1), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2) + num3, (float) (drawinfo.drawPlayer.bodyFrame.Height / 2) + num4), new Rectangle?(bodyFrame), color, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
        drawData1.shader = drawinfo.cBody;
        drawinfo.DrawDataCache.Add(drawData1);
      }
    }
    else
    {
      if (drawinfo.drawPlayer.invis)
        return;
      DrawData drawData = new DrawData(TextureAssets.Players[drawinfo.skinVar, 7].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorBodySkin, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect)
      {
        shader = drawinfo.skinDyePacked
      };
      drawinfo.DrawDataCache.Add(drawData);
      drawData = new DrawData(TextureAssets.Players[drawinfo.skinVar, 8].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorUnderShirt, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData);
      drawData = new DrawData(TextureAssets.Players[drawinfo.skinVar, 13].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorShirt, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData);
    }
  }

  public static void DrawPlayer_28_ArmOverItemComposite(ref PlayerDrawSet drawinfo)
  {
    Vector2 vector2_1 = new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2));
    Vector2 vector2_2 = Main.OffsetsPlayerHeadgear[drawinfo.drawPlayer.bodyFrame.Y / drawinfo.drawPlayer.bodyFrame.Height];
    vector2_2.Y -= 2f;
    Vector2 vector2_3 = vector2_1 + vector2_2 * (float) -((drawinfo.playerEffect & SpriteEffects.FlipVertically) != 0).ToDirectionInt();
    float bodyRotation = drawinfo.drawPlayer.bodyRotation;
    float rotation = drawinfo.drawPlayer.bodyRotation + drawinfo.compositeFrontArmRotation;
    Vector2 bodyVect = drawinfo.bodyVect;
    Vector2 compositeOffsetFrontArm = PlayerDrawLayers.GetCompositeOffset_FrontArm(ref drawinfo);
    Vector2 origin = bodyVect + compositeOffsetFrontArm;
    Vector2 position1 = vector2_3 + compositeOffsetFrontArm;
    Vector2 position2 = position1 + drawinfo.frontShoulderOffset;
    if (drawinfo.compFrontArmFrame.X / drawinfo.compFrontArmFrame.Width >= 7)
      position1 += new Vector2((drawinfo.playerEffect & SpriteEffects.FlipHorizontally) != SpriteEffects.None ? -1f : 1f, (drawinfo.playerEffect & SpriteEffects.FlipVertically) != SpriteEffects.None ? -1f : 1f);
    int num1 = drawinfo.drawPlayer.invis ? 1 : 0;
    int num2 = drawinfo.drawPlayer.body <= 0 ? 0 : (drawinfo.drawPlayer.body < ArmorIDs.Body.Count ? 1 : 0);
    bool flag1 = drawinfo.drawPlayer.coat > 0 && drawinfo.drawPlayer.coat < ArmorIDs.Body.Count;
    int num3 = drawinfo.compShoulderOverFrontArm ? 1 : 0;
    int num4 = drawinfo.compShoulderOverFrontArm ? 0 : 1;
    int num5 = drawinfo.compShoulderOverFrontArm ? 0 : 1;
    bool flag2 = !drawinfo.hidesTopSkin;
    DrawData drawData1;
    if (num2 != 0)
    {
      if (!drawinfo.drawPlayer.invis || PlayerDrawLayers.IsArmorDrawnWhenInvisible(drawinfo.drawPlayer.body))
      {
        Texture2D texture1 = TextureAssets.ArmorBodyComposite[drawinfo.drawPlayer.body].Value;
        for (int index = 0; index < 2; ++index)
        {
          if (((drawinfo.drawPlayer.invis ? 0 : (index == num5 ? 1 : 0)) & (flag2 ? 1 : 0)) != 0)
          {
            if (drawinfo.missingArm)
            {
              List<DrawData> drawDataCache = drawinfo.DrawDataCache;
              drawData1 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 7].Value, position1, new Rectangle?(drawinfo.compFrontArmFrame), drawinfo.colorBodySkin, rotation, origin, 1f, drawinfo.playerEffect);
              drawData1.shader = drawinfo.skinDyePacked;
              DrawData drawData2 = drawData1;
              drawDataCache.Add(drawData2);
            }
            if (drawinfo.missingHand)
            {
              List<DrawData> drawDataCache = drawinfo.DrawDataCache;
              drawData1 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 9].Value, position1, new Rectangle?(drawinfo.compFrontArmFrame), drawinfo.colorBodySkin, rotation, origin, 1f, drawinfo.playerEffect);
              drawData1.shader = drawinfo.skinDyePacked;
              DrawData drawData3 = drawData1;
              drawDataCache.Add(drawData3);
            }
          }
          if (index == num3 && !drawinfo.hideCompositeShoulders)
          {
            ref PlayerDrawSet local1 = ref drawinfo;
            drawData1 = new DrawData(texture1, position2, new Rectangle?(drawinfo.compFrontShoulderFrame), drawinfo.colorArmorBody, bodyRotation, origin, 1f, drawinfo.playerEffect);
            drawData1.shader = drawinfo.cBody;
            DrawData data1 = drawData1;
            int body1 = drawinfo.drawPlayer.body;
            PlayerDrawLayers.DrawCompositeArmorPiece(ref local1, CompositePlayerDrawContext.FrontShoulder, data1, body1);
            if (drawinfo.drawPlayer.body == 71)
            {
              Texture2D texture2 = TextureAssets.Extra[277].Value;
              ref PlayerDrawSet local2 = ref drawinfo;
              drawData1 = new DrawData(texture2, position2, new Rectangle?(drawinfo.compFrontShoulderFrame), drawinfo.colorArmorBody, bodyRotation, origin, 1f, drawinfo.playerEffect);
              drawData1.shader = 0;
              DrawData data2 = drawData1;
              int body2 = drawinfo.drawPlayer.body;
              PlayerDrawLayers.DrawCompositeArmorPiece(ref local2, CompositePlayerDrawContext.FrontShoulder, data2, body2);
              if (drawinfo.drawPlayer.legs == 60)
              {
                Texture2D texture3 = TextureAssets.Extra[275].Value;
                ref PlayerDrawSet local3 = ref drawinfo;
                drawData1 = new DrawData(texture3, position2, new Rectangle?(drawinfo.compFrontShoulderFrame), drawinfo.colorArmorBody, bodyRotation, origin, 1f, drawinfo.playerEffect);
                drawData1.shader = drawinfo.cLegs;
                DrawData data3 = drawData1;
                int body3 = drawinfo.drawPlayer.body;
                PlayerDrawLayers.DrawCompositeArmorPiece(ref local3, CompositePlayerDrawContext.FrontShoulder, data3, body3);
              }
            }
          }
          if (index == num4)
          {
            ref PlayerDrawSet local4 = ref drawinfo;
            drawData1 = new DrawData(texture1, position1, new Rectangle?(drawinfo.compFrontArmFrame), drawinfo.colorArmorBody, rotation, origin, 1f, drawinfo.playerEffect);
            drawData1.shader = drawinfo.cBody;
            DrawData data4 = drawData1;
            int body4 = drawinfo.drawPlayer.body;
            PlayerDrawLayers.DrawCompositeArmorPiece(ref local4, CompositePlayerDrawContext.FrontArm, data4, body4);
            if (drawinfo.drawPlayer.body == 71)
            {
              Texture2D texture4 = TextureAssets.Extra[277].Value;
              ref PlayerDrawSet local5 = ref drawinfo;
              drawData1 = new DrawData(texture4, position1, new Rectangle?(drawinfo.compFrontArmFrame), drawinfo.colorArmorBody, rotation, origin, 1f, drawinfo.playerEffect);
              drawData1.shader = 0;
              DrawData data5 = drawData1;
              int body5 = drawinfo.drawPlayer.body;
              PlayerDrawLayers.DrawCompositeArmorPiece(ref local5, CompositePlayerDrawContext.FrontArm, data5, body5);
            }
          }
        }
      }
    }
    else if (!drawinfo.drawPlayer.invis)
    {
      for (int index = 0; index < 2; ++index)
      {
        if (index == num3)
        {
          if (flag2)
          {
            List<DrawData> drawDataCache = drawinfo.DrawDataCache;
            drawData1 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 7].Value, position2, new Rectangle?(drawinfo.compFrontShoulderFrame), drawinfo.colorBodySkin, bodyRotation, origin, 1f, drawinfo.playerEffect);
            drawData1.shader = drawinfo.skinDyePacked;
            DrawData drawData4 = drawData1;
            drawDataCache.Add(drawData4);
          }
          if (!drawinfo.hideCompositeShoulders)
          {
            drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.Players[drawinfo.skinVar, 8].Value, position2, new Rectangle?(drawinfo.compFrontShoulderFrame), drawinfo.colorUnderShirt, bodyRotation, origin, 1f, drawinfo.playerEffect));
            drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.Players[drawinfo.skinVar, 13].Value, position2, new Rectangle?(drawinfo.compFrontShoulderFrame), drawinfo.colorShirt, bodyRotation, origin, 1f, drawinfo.playerEffect));
            drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.Players[drawinfo.skinVar, 6].Value, position2, new Rectangle?(drawinfo.compFrontShoulderFrame), drawinfo.colorShirt, bodyRotation, origin, 1f, drawinfo.playerEffect));
            if (drawinfo.drawPlayer.head == 269)
            {
              Vector2 pos = drawinfo.helmetOffset + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.headPosition + drawinfo.headVect;
              drawinfo.drawPlayer.ApplyHeadOffsetFromMount(ref pos);
              DrawData drawData5 = new DrawData(TextureAssets.Extra[214].Value, pos, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorHead, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
              drawData5.shader = drawinfo.cHead;
              drawinfo.DrawDataCache.Add(drawData5);
              drawData5 = new DrawData(TextureAssets.GlowMask[308].Value, pos, new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.headGlowColor, drawinfo.drawPlayer.headRotation, drawinfo.headVect, 1f, drawinfo.playerEffect);
              drawData5.shader = drawinfo.cHead;
              drawinfo.DrawDataCache.Add(drawData5);
            }
          }
        }
        if (index == num4)
        {
          if (flag2)
          {
            List<DrawData> drawDataCache = drawinfo.DrawDataCache;
            drawData1 = new DrawData(TextureAssets.Players[drawinfo.skinVar, 7].Value, position1, new Rectangle?(drawinfo.compFrontArmFrame), drawinfo.colorBodySkin, rotation, origin, 1f, drawinfo.playerEffect);
            drawData1.shader = drawinfo.skinDyePacked;
            DrawData drawData6 = drawData1;
            drawDataCache.Add(drawData6);
          }
          drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.Players[drawinfo.skinVar, 8].Value, position1, new Rectangle?(drawinfo.compFrontArmFrame), drawinfo.colorUnderShirt, rotation, origin, 1f, drawinfo.playerEffect));
          drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.Players[drawinfo.skinVar, 13].Value, position1, new Rectangle?(drawinfo.compFrontArmFrame), drawinfo.colorShirt, rotation, origin, 1f, drawinfo.playerEffect));
          drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.Players[drawinfo.skinVar, 6].Value, position1, new Rectangle?(drawinfo.compFrontArmFrame), drawinfo.colorShirt, rotation, origin, 1f, drawinfo.playerEffect));
        }
      }
    }
    if (flag1 && (!drawinfo.drawPlayer.invis || PlayerDrawLayers.IsArmorDrawnWhenInvisible(drawinfo.drawPlayer.coat)))
    {
      Texture2D texture = TextureAssets.ArmorBodyComposite[drawinfo.drawPlayer.coat].Value;
      for (int index = 0; index < 2; ++index)
      {
        if (index == num3 && !drawinfo.hideCompositeShoulders)
        {
          ref PlayerDrawSet local = ref drawinfo;
          drawData1 = new DrawData(texture, position2, new Rectangle?(drawinfo.compFrontShoulderFrame), drawinfo.colorArmorBody, bodyRotation, origin, 1f, drawinfo.playerEffect);
          drawData1.shader = drawinfo.cCoat;
          DrawData data = drawData1;
          int coat = drawinfo.drawPlayer.coat;
          PlayerDrawLayers.DrawCompositeArmorPiece(ref local, CompositePlayerDrawContext.FrontShoulder, data, coat);
        }
        if (index == num4)
        {
          ref PlayerDrawSet local = ref drawinfo;
          drawData1 = new DrawData(texture, position1, new Rectangle?(drawinfo.compFrontArmFrame), drawinfo.colorArmorBody, rotation, origin, 1f, drawinfo.playerEffect);
          drawData1.shader = drawinfo.cCoat;
          DrawData data = drawData1;
          int coat = drawinfo.drawPlayer.coat;
          PlayerDrawLayers.DrawCompositeArmorPiece(ref local, CompositePlayerDrawContext.FrontArm, data, coat);
        }
      }
    }
    if (drawinfo.drawPlayer.handon <= (sbyte) 0 || (int) drawinfo.drawPlayer.handon >= ArmorIDs.HandOn.Count)
      return;
    Texture2D texture5 = TextureAssets.AccHandsOnComposite[(int) drawinfo.drawPlayer.handon].Value;
    ref PlayerDrawSet local6 = ref drawinfo;
    drawData1 = new DrawData(texture5, position1, new Rectangle?(drawinfo.compFrontArmFrame), drawinfo.colorArmorBody, rotation, origin, 1f, drawinfo.playerEffect);
    drawData1.shader = drawinfo.cHandOn;
    DrawData data6 = drawData1;
    PlayerDrawLayers.DrawCompositeArmorPiece(ref local6, CompositePlayerDrawContext.FrontArmAccessory, data6, -1);
  }

  public static void DrawPlayer_29_OnhandAcc(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.usesCompositeFrontHandAcc || drawinfo.drawPlayer.handon <= (sbyte) 0 || (int) drawinfo.drawPlayer.handon >= ArmorIDs.HandOn.Count)
      return;
    drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.AccHandsOn[(int) drawinfo.drawPlayer.handon].Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect)
    {
      shader = drawinfo.cHandOn
    });
  }

  public static void DrawPlayer_30_BladedGlove(ref PlayerDrawSet drawinfo)
  {
    Item heldItem = drawinfo.heldItem;
    if (heldItem.type <= -1 || !Item.claw[heldItem.type] || (double) drawinfo.shadow != 0.0)
      return;
    Main.instance.LoadItem(heldItem.type);
    Asset<Texture2D> asset = TextureAssets.Item[heldItem.type];
    if (drawinfo.drawPlayer.frozen || drawinfo.drawPlayer.itemAnimation <= 0 && (heldItem.holdStyle == 0 || drawinfo.drawPlayer.pulley) || heldItem.type <= 0 || drawinfo.drawPlayer.dead || heldItem.noUseGraphic || drawinfo.drawPlayer.wet && heldItem.noWet)
      return;
    if ((double) drawinfo.drawPlayer.gravDir == -1.0)
    {
      DrawData drawData = new DrawData(asset.Value, new Vector2((float) (int) ((double) drawinfo.ItemLocation.X - (double) Main.screenPosition.X), (float) (int) ((double) drawinfo.ItemLocation.Y - (double) Main.screenPosition.Y)), new Rectangle?(new Rectangle(0, 0, asset.Width(), asset.Height())), heldItem.GetAlpha(drawinfo.itemColor), drawinfo.drawPlayer.itemRotation, new Vector2((float) ((double) asset.Width() * 0.5 - (double) asset.Width() * 0.5 * (double) drawinfo.drawPlayer.direction), 0.0f), drawinfo.drawPlayer.GetAdjustedItemScale(heldItem), drawinfo.itemEffect);
      drawinfo.DrawDataCache.Add(drawData);
    }
    else
    {
      DrawData drawData = new DrawData(asset.Value, new Vector2((float) (int) ((double) drawinfo.ItemLocation.X - (double) Main.screenPosition.X), (float) (int) ((double) drawinfo.ItemLocation.Y - (double) Main.screenPosition.Y)), new Rectangle?(new Rectangle(0, 0, asset.Width(), asset.Height())), heldItem.GetAlpha(drawinfo.itemColor), drawinfo.drawPlayer.itemRotation, new Vector2((float) ((double) asset.Width() * 0.5 - (double) asset.Width() * 0.5 * (double) drawinfo.drawPlayer.direction), (float) asset.Height()), drawinfo.drawPlayer.GetAdjustedItemScale(heldItem), drawinfo.itemEffect);
      drawinfo.DrawDataCache.Add(drawData);
    }
  }

  public static void DrawPlayer_31_ProjectileOverArm(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.SelectedDrawnProjectile == null || (double) drawinfo.shadow != 0.0 || drawinfo.SelectedDrawnProjectile.drawLayer != 8)
      return;
    drawinfo.projectileDrawPosition = drawinfo.DrawDataCache.Count;
  }

  public static void DrawPlayer_32_FrontAcc(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.front <= (sbyte) 0 || (int) drawinfo.drawPlayer.front >= ArmorIDs.Front.Count || drawinfo.drawPlayer.mount.Active)
      return;
    Vector2 zero = Vector2.Zero;
    drawinfo.DrawDataCache.Add(new DrawData(TextureAssets.AccFront[(int) drawinfo.drawPlayer.front].Value, zero + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(drawinfo.drawPlayer.bodyFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, drawinfo.bodyVect, 1f, drawinfo.playerEffect)
    {
      shader = drawinfo.cFront
    });
  }

  public static void DrawPlayer_32_FrontAcc_FrontPart(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.front <= (sbyte) 0 || (int) drawinfo.drawPlayer.front >= ArmorIDs.Front.Count || ArmorIDs.Front.Sets.DontDrawIfWearingAScarfOrCape[(int) drawinfo.drawPlayer.front] && (drawinfo.drawPlayer.neck > (sbyte) 0 && ArmorIDs.Neck.Sets.IsAScarf[(int) drawinfo.drawPlayer.neck] || drawinfo.drawPlayer.back > (sbyte) 0 && ArmorIDs.Back.Sets.IsACape[(int) drawinfo.drawPlayer.back]))
      return;
    Rectangle bodyFrame = drawinfo.drawPlayer.bodyFrame;
    int num1 = bodyFrame.Width / 2;
    bodyFrame.Width -= num1;
    Vector2 bodyVect = drawinfo.bodyVect;
    if ((drawinfo.playerEffect & SpriteEffects.FlipHorizontally) != SpriteEffects.None)
      bodyVect.X -= (float) num1;
    Vector2 position = drawinfo.drawPlayer.GetFrontDrawOffset() + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2));
    DrawData drawData = new DrawData(TextureAssets.AccFront[(int) drawinfo.drawPlayer.front].Value, position, new Rectangle?(bodyFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, bodyVect, 1f, drawinfo.playerEffect);
    drawData.shader = drawinfo.cFront;
    drawinfo.DrawDataCache.Add(drawData);
    if (drawinfo.drawPlayer.front != (sbyte) 12)
      return;
    Rectangle rectangle1 = bodyFrame;
    Rectangle rectangle2 = rectangle1 with { Width = 2 };
    int num2 = 0;
    int num3 = rectangle1.Width / 2;
    int num4 = 2;
    if ((drawinfo.playerEffect & SpriteEffects.FlipHorizontally) != SpriteEffects.None)
    {
      num2 = rectangle1.Width - 2;
      num4 = -2;
    }
    for (int index = 0; index < num3; ++index)
    {
      rectangle2.X = rectangle1.X + 2 * index;
      Color color = drawinfo.drawPlayer.GetImmuneAlpha(LiquidRenderer.GetShimmerGlitterColor(true, (float) index / 16f, 0.0f), drawinfo.shadow) * ((float) drawinfo.colorArmorBody.A / (float) byte.MaxValue);
      drawData = new DrawData(TextureAssets.GlowMask[331].Value, position + new Vector2((float) (num2 + index * num4), 0.0f), new Rectangle?(rectangle2), color, drawinfo.drawPlayer.bodyRotation, bodyVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cFront;
      drawinfo.DrawDataCache.Add(drawData);
    }
  }

  public static void DrawPlayer_32_FrontAcc_BackPart(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.front <= (sbyte) 0 || (int) drawinfo.drawPlayer.front >= ArmorIDs.Front.Count || ArmorIDs.Front.Sets.DontDrawIfWearingAScarfOrCape[(int) drawinfo.drawPlayer.front] && (drawinfo.drawPlayer.neck > (sbyte) 0 && ArmorIDs.Neck.Sets.IsAScarf[(int) drawinfo.drawPlayer.neck] || drawinfo.drawPlayer.back > (sbyte) 0 && ArmorIDs.Back.Sets.IsACape[(int) drawinfo.drawPlayer.back]))
      return;
    Rectangle bodyFrame = drawinfo.drawPlayer.bodyFrame;
    int num1 = bodyFrame.Width / 2;
    bodyFrame.Width -= num1;
    bodyFrame.X += num1;
    Vector2 bodyVect = drawinfo.bodyVect;
    if ((drawinfo.playerEffect & SpriteEffects.FlipHorizontally) == SpriteEffects.None)
      bodyVect.X -= (float) num1;
    Vector2 position = drawinfo.drawPlayer.GetFrontDrawOffset() + new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2));
    DrawData drawData = new DrawData(TextureAssets.AccFront[(int) drawinfo.drawPlayer.front].Value, position, new Rectangle?(bodyFrame), drawinfo.colorArmorBody, drawinfo.drawPlayer.bodyRotation, bodyVect, 1f, drawinfo.playerEffect);
    drawData.shader = drawinfo.cFront;
    drawinfo.DrawDataCache.Add(drawData);
    if (drawinfo.drawPlayer.front != (sbyte) 12)
      return;
    Rectangle rectangle1 = bodyFrame;
    Rectangle rectangle2 = rectangle1 with { Width = 2 };
    int num2 = 0;
    int num3 = rectangle1.Width / 2;
    int num4 = 2;
    if ((drawinfo.playerEffect & SpriteEffects.FlipHorizontally) != SpriteEffects.None)
    {
      num2 = rectangle1.Width - 2;
      num4 = -2;
    }
    for (int index = 0; index < num3; ++index)
    {
      rectangle2.X = rectangle1.X + 2 * index;
      Color color = drawinfo.drawPlayer.GetImmuneAlpha(LiquidRenderer.GetShimmerGlitterColor(true, (float) index / 16f, 0.0f), drawinfo.shadow) * ((float) drawinfo.colorArmorBody.A / (float) byte.MaxValue);
      drawData = new DrawData(TextureAssets.GlowMask[331].Value, position + new Vector2((float) (num2 + index * num4), 0.0f), new Rectangle?(rectangle2), color, drawinfo.drawPlayer.bodyRotation, bodyVect, 1f, drawinfo.playerEffect);
      drawData.shader = drawinfo.cFront;
      drawinfo.DrawDataCache.Add(drawData);
    }
  }

  public static void DrawPlayer_33_FrozenOrWebbedDebuff(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.drawPlayer.shimmering)
      return;
    if (drawinfo.drawPlayer.frozen && (double) drawinfo.shadow == 0.0)
    {
      Color colorArmorBody = drawinfo.colorArmorBody;
      colorArmorBody.R = (byte) ((double) colorArmorBody.R * 0.55);
      colorArmorBody.G = (byte) ((double) colorArmorBody.G * 0.55);
      colorArmorBody.B = (byte) ((double) colorArmorBody.B * 0.55);
      colorArmorBody.A = (byte) ((double) colorArmorBody.A * 0.55);
      DrawData drawData = new DrawData(TextureAssets.Frozen.Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(new Rectangle(0, 0, TextureAssets.Frozen.Width(), TextureAssets.Frozen.Height())), colorArmorBody, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (TextureAssets.Frozen.Width() / 2), (float) (TextureAssets.Frozen.Height() / 2)), 1f, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData);
    }
    else
    {
      if (!drawinfo.drawPlayer.webbed || (double) drawinfo.shadow != 0.0 || (double) drawinfo.drawPlayer.velocity.Y != 0.0)
        return;
      Color color = drawinfo.colorArmorBody * 0.75f;
      Texture2D texture2D = TextureAssets.Extra[31 /*0x1F*/].Value;
      int num = drawinfo.drawPlayer.height / 2;
      DrawData drawData = new DrawData(texture2D, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0 + (double) num)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(), color, drawinfo.drawPlayer.bodyRotation, texture2D.Size() / 2f, 1f, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData);
    }
  }

  public static void DrawPlayer_34_ElectrifiedDebuffFront(ref PlayerDrawSet drawinfo)
  {
    if (!drawinfo.drawPlayer.electrified || (double) drawinfo.shadow != 0.0)
      return;
    Texture2D texture = TextureAssets.GlowMask[25].Value;
    int num1 = drawinfo.drawPlayer.miscCounter / 5;
    for (int index = 0; index < 2; ++index)
    {
      int num2 = num1 % 7;
      if (num2 > 1 && num2 < 5)
      {
        DrawData drawData = new DrawData(texture, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(new Rectangle(0, num2 * texture.Height / 7, texture.Width, texture.Height / 7)), drawinfo.colorElectricity, drawinfo.drawPlayer.bodyRotation, new Vector2((float) (texture.Width / 2), (float) (texture.Height / 14)), 1f, drawinfo.playerEffect);
        drawinfo.DrawDataCache.Add(drawData);
      }
      num1 = num2 + 3;
    }
  }

  public static void DrawPlayer_35_IceBarrier(ref PlayerDrawSet drawinfo)
  {
    if (!drawinfo.drawPlayer.iceBarrier || (double) drawinfo.shadow != 0.0)
      return;
    int height = TextureAssets.IceBarrier.Height() / 12;
    Color white = Color.White;
    DrawData drawData = new DrawData(TextureAssets.IceBarrier.Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X - (double) (drawinfo.drawPlayer.bodyFrame.Width / 2) + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - (double) drawinfo.drawPlayer.bodyFrame.Height + 4.0)) + drawinfo.drawPlayer.bodyPosition + new Vector2((float) (drawinfo.drawPlayer.bodyFrame.Width / 2), (float) (drawinfo.drawPlayer.bodyFrame.Height / 2)), new Rectangle?(new Rectangle(0, height * (int) drawinfo.drawPlayer.iceBarrierFrame, TextureAssets.IceBarrier.Width(), height)), white, 0.0f, new Vector2((float) (TextureAssets.Frozen.Width() / 2), (float) (TextureAssets.Frozen.Height() / 2)), 1f, drawinfo.playerEffect);
    drawinfo.DrawDataCache.Add(drawData);
  }

  public static void DrawPlayer_36_CTG(ref PlayerDrawSet drawinfo)
  {
    if ((double) drawinfo.shadow != 0.0 || (byte) drawinfo.drawPlayer.ownedLargeGems <= (byte) 0)
      return;
    bool flag = false;
    BitsByte ownedLargeGems = drawinfo.drawPlayer.ownedLargeGems;
    float num1 = 0.0f;
    for (int key = 0; key < 7; ++key)
    {
      if (ownedLargeGems[key])
        ++num1;
    }
    float num2 = (float) (1.0 - (double) num1 * 0.059999998658895493);
    float num3 = (float) (((double) num1 - 1.0) * 4.0);
    switch (num1)
    {
      case 2f:
        num3 += 10f;
        break;
      case 3f:
        num3 += 8f;
        break;
      case 4f:
        num3 += 6f;
        break;
      case 5f:
        num3 += 6f;
        break;
      case 6f:
        num3 += 2f;
        break;
      case 7f:
        num3 += 0.0f;
        break;
    }
    float num4 = (float) ((double) drawinfo.drawPlayer.miscCounter / 300.0 * 6.2831854820251465);
    if ((double) num1 <= 0.0)
      return;
    float num5 = 6.28318548f / num1;
    float num6 = 0.0f;
    Vector2 vector2 = new Vector2(1.3f, 0.65f);
    if (!flag)
      vector2 = Vector2.One;
    List<DrawData> collection = new List<DrawData>();
    for (int key = 0; key < 7; ++key)
    {
      if (!ownedLargeGems[key])
      {
        ++num6;
      }
      else
      {
        Vector2 rotationVector2 = (num4 + num5 * ((float) key - num6)).ToRotationVector2();
        float num7 = num2;
        if (flag)
          num7 = MathHelper.Lerp(num2 * 0.7f, 1f, (float) ((double) rotationVector2.Y / 2.0 + 0.5));
        Texture2D texture2D = TextureAssets.Gem[key].Value;
        DrawData drawData = new DrawData(texture2D, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) drawinfo.drawPlayer.height - 80.0)) + rotationVector2 * vector2 * num3, new Rectangle?(), new Color(250, 250, 250, (int) Main.mouseTextColor / 2), 0.0f, texture2D.Size() / 2f, (float) ((double) Main.mouseTextColor / 1000.0 + 0.800000011920929) * num7, SpriteEffects.None);
        collection.Add(drawData);
      }
    }
    if (flag)
      collection.Sort(new Comparison<DrawData>(DelegateMethods.CompareDrawSorterByYScale));
    drawinfo.DrawDataCache.AddRange((IEnumerable<DrawData>) collection);
  }

  public static void DrawPlayer_37_BeetleBuff(ref PlayerDrawSet drawinfo)
  {
    if (!drawinfo.drawPlayer.beetleOffense && !drawinfo.drawPlayer.beetleDefense || (double) drawinfo.shadow != 0.0)
      return;
    for (int index1 = 0; index1 < drawinfo.drawPlayer.beetleOrbs; ++index1)
    {
      DrawData drawData;
      for (int index2 = 0; index2 < 5; ++index2)
      {
        Color colorArmorBody = drawinfo.colorArmorBody;
        float num = 0.5f - (float) index2 * 0.1f;
        colorArmorBody.R = (byte) ((double) colorArmorBody.R * (double) num);
        colorArmorBody.G = (byte) ((double) colorArmorBody.G * (double) num);
        colorArmorBody.B = (byte) ((double) colorArmorBody.B * (double) num);
        colorArmorBody.A = (byte) ((double) colorArmorBody.A * (double) num);
        Vector2 vector2 = -drawinfo.drawPlayer.beetleVel[index1] * (float) index2;
        drawData = new DrawData(TextureAssets.Beetle.Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) (drawinfo.drawPlayer.height / 2))) + drawinfo.drawPlayer.beetlePos[index1] + vector2, new Rectangle?(new Rectangle(0, TextureAssets.Beetle.Height() / 3 * drawinfo.drawPlayer.beetleFrame + 1, TextureAssets.Beetle.Width(), TextureAssets.Beetle.Height() / 3 - 2)), colorArmorBody, 0.0f, new Vector2((float) (TextureAssets.Beetle.Width() / 2), (float) (TextureAssets.Beetle.Height() / 6)), 1f, drawinfo.playerEffect);
        drawinfo.DrawDataCache.Add(drawData);
      }
      drawData = new DrawData(TextureAssets.Beetle.Value, new Vector2((float) (int) ((double) drawinfo.Position.X - (double) Main.screenPosition.X + (double) (drawinfo.drawPlayer.width / 2)), (float) (int) ((double) drawinfo.Position.Y - (double) Main.screenPosition.Y + (double) (drawinfo.drawPlayer.height / 2))) + drawinfo.drawPlayer.beetlePos[index1], new Rectangle?(new Rectangle(0, TextureAssets.Beetle.Height() / 3 * drawinfo.drawPlayer.beetleFrame + 1, TextureAssets.Beetle.Width(), TextureAssets.Beetle.Height() / 3 - 2)), drawinfo.colorArmorBody, 0.0f, new Vector2((float) (TextureAssets.Beetle.Width() / 2), (float) (TextureAssets.Beetle.Height() / 6)), 1f, drawinfo.playerEffect);
      drawinfo.DrawDataCache.Add(drawData);
    }
  }

  public static void DrawPlayer_38_EyebrellaCloud(ref PlayerDrawSet drawinfo)
  {
    if (!drawinfo.drawPlayer.eyebrellaCloud || (double) drawinfo.shadow != 0.0)
      return;
    Texture2D texture2D = TextureAssets.Projectile[238].Value;
    int frameY = drawinfo.drawPlayer.miscCounter % 18 / 6;
    Rectangle rectangle = texture2D.Frame(verticalFrames: 6, frameY: frameY);
    Vector2 origin = new Vector2((float) (rectangle.Width / 2), (float) (rectangle.Height / 2));
    Vector2 pos = new Vector2(0.0f, -70f);
    drawinfo.drawPlayer.ApplyHeadOffsetFromMount(ref pos);
    if (drawinfo.drawPlayer.mount.Active && drawinfo.drawPlayer.mount.Type == 54)
      pos += new Vector2(-14f, 0.0f) * drawinfo.drawPlayer.Directions;
    Vector2 position = drawinfo.drawPlayer.MountedCenter - new Vector2(0.0f, (float) drawinfo.drawPlayer.height * 0.5f) + pos - Main.screenPosition;
    Color color1 = Lighting.GetColor((drawinfo.drawPlayer.Top + new Vector2(0.0f, -30f)).ToTileCoordinates());
    int num1 = 170;
    int num2;
    int b = num2 = num1;
    int g = num2;
    int r = num2;
    if ((int) color1.R < num1)
      r = (int) color1.R;
    if ((int) color1.G < num1)
      g = (int) color1.G;
    if ((int) color1.B < num1)
      b = (int) color1.B;
    Color color2 = new Color(r, g, b, 100);
    float num3 = (float) (drawinfo.drawPlayer.miscCounter % 50) / 50f;
    float num4 = 3f;
    DrawData drawData;
    for (int index = 0; index < 2; ++index)
    {
      Vector2 vector2 = new Vector2(index == 0 ? -num4 : num4, 0.0f).RotatedBy((double) num3 * 6.2831854820251465 * (index == 0 ? 1.0 : -1.0));
      drawData = new DrawData(texture2D, position + vector2, new Rectangle?(rectangle), color2 * 0.65f, 0.0f, origin, 1f, (double) drawinfo.drawPlayer.gravDir == -1.0 ? SpriteEffects.FlipVertically : SpriteEffects.None);
      drawData.shader = drawinfo.cHead;
      drawData.ignorePlayerRotation = true;
      drawinfo.DrawDataCache.Add(drawData);
    }
    drawData = new DrawData(texture2D, position, new Rectangle?(rectangle), color2, 0.0f, origin, 1f, (double) drawinfo.drawPlayer.gravDir == -1.0 ? SpriteEffects.FlipVertically : SpriteEffects.None);
    drawData.shader = drawinfo.cHead;
    drawData.ignorePlayerRotation = true;
    drawinfo.DrawDataCache.Add(drawData);
  }

  private static Vector2 GetCompositeOffset_BackArm(ref PlayerDrawSet drawinfo)
  {
    return new Vector2((float) (6 * ((drawinfo.playerEffect & SpriteEffects.FlipHorizontally) != SpriteEffects.None ? -1 : 1)), (float) (2 * ((drawinfo.playerEffect & SpriteEffects.FlipVertically) != SpriteEffects.None ? -1 : 1)));
  }

  private static Vector2 GetCompositeOffset_FrontArm(ref PlayerDrawSet drawinfo)
  {
    return new Vector2((float) (-5 * ((drawinfo.playerEffect & SpriteEffects.FlipHorizontally) != SpriteEffects.None ? -1 : 1)), 0.0f);
  }

  public static void DrawPlayer_TransformDrawData(ref PlayerDrawSet drawinfo)
  {
    double rotation = (double) drawinfo.rotation;
    Vector2 vector2_1 = drawinfo.Position - Main.screenPosition + drawinfo.rotationOrigin;
    Vector2 vector2_2 = drawinfo.drawPlayer.position + drawinfo.rotationOrigin;
    Matrix rotationZ = Matrix.CreateRotationZ(drawinfo.rotation);
    for (int index = 0; index < drawinfo.DustCache.Count; ++index)
    {
      Vector2 vector2_3 = Vector2.Transform(Main.dust[drawinfo.DustCache[index]].position - vector2_2, rotationZ);
      Main.dust[drawinfo.DustCache[index]].position = vector2_3 + vector2_2;
    }
    for (int index = 0; index < drawinfo.GoreCache.Count; ++index)
    {
      Vector2 vector2_4 = Vector2.Transform(Main.gore[drawinfo.GoreCache[index]].position - vector2_2, rotationZ);
      Main.gore[drawinfo.GoreCache[index]].position = vector2_4 + vector2_2;
    }
    for (int index = 0; index < drawinfo.DrawDataCache.Count; ++index)
    {
      DrawData drawData = drawinfo.DrawDataCache[index];
      if (!drawData.ignorePlayerRotation)
      {
        Vector2 vector2_5 = Vector2.Transform(drawData.position - vector2_1, rotationZ);
        drawData.position = vector2_5 + vector2_1;
        drawData.rotation += drawinfo.rotation;
        drawinfo.DrawDataCache[index] = drawData;
      }
    }
  }

  public static void DrawPlayer_ScaleDrawData(ref PlayerDrawSet drawinfo, float scale)
  {
    if ((double) scale == 1.0)
      return;
    Vector2 vector2_1 = drawinfo.Position + drawinfo.drawPlayer.Size * new Vector2(0.5f, 1f) - Main.screenPosition;
    for (int index = 0; index < drawinfo.DrawDataCache.Count; ++index)
    {
      DrawData drawData = drawinfo.DrawDataCache[index];
      Vector2 vector2_2 = drawData.position - vector2_1;
      drawData.position = vector2_1 + vector2_2 * scale;
      drawData.scale *= scale;
      drawinfo.DrawDataCache[index] = drawData;
    }
  }

  public static void DrawPlayer_AddSelectionGlow(ref PlayerDrawSet drawinfo)
  {
    if (drawinfo.selectionGlowColor == Color.Transparent)
      return;
    Color selectionGlowColor = drawinfo.selectionGlowColor;
    List<DrawData> drawDataList = new List<DrawData>();
    drawDataList.AddRange((IEnumerable<DrawData>) PlayerDrawLayers.GetFlatColoredCloneData(ref drawinfo, new Vector2(0.0f, -2f), selectionGlowColor));
    drawDataList.AddRange((IEnumerable<DrawData>) PlayerDrawLayers.GetFlatColoredCloneData(ref drawinfo, new Vector2(0.0f, 2f), selectionGlowColor));
    drawDataList.AddRange((IEnumerable<DrawData>) PlayerDrawLayers.GetFlatColoredCloneData(ref drawinfo, new Vector2(2f, 0.0f), selectionGlowColor));
    drawDataList.AddRange((IEnumerable<DrawData>) PlayerDrawLayers.GetFlatColoredCloneData(ref drawinfo, new Vector2(-2f, 0.0f), selectionGlowColor));
    drawDataList.AddRange((IEnumerable<DrawData>) drawinfo.DrawDataCache);
    drawinfo.DrawDataCache = drawDataList;
  }

  public static void DrawPlayer_MakeIntoFirstFractalAfterImage(ref PlayerDrawSet drawinfo)
  {
    if (!drawinfo.drawPlayer.isFirstFractalAfterImage)
    {
      int num = drawinfo.drawPlayer.HeldItem.type != 4722 ? 0 : (drawinfo.drawPlayer.itemAnimation > 0 ? 1 : 0);
    }
    else
    {
      for (int index = 0; index < drawinfo.DrawDataCache.Count; ++index)
      {
        DrawData drawData = drawinfo.DrawDataCache[index];
        drawData.color *= drawinfo.drawPlayer.firstFractalAfterImageOpacity;
        drawData.color.A = (byte) ((double) drawData.color.A * 0.800000011920929);
        drawinfo.DrawDataCache[index] = drawData;
      }
    }
  }

  public static void DrawPlayer_RenderAllLayers(ref PlayerDrawSet drawinfo)
  {
    SpriteDrawBuffer spriteBuffer = Main.spriteBuffer;
    List<DrawData> drawDataCache = drawinfo.DrawDataCache;
    foreach (DrawData drawData in drawDataCache)
    {
      if (drawData.texture != null)
        drawData.Draw(spriteBuffer);
    }
    DrawData cdd = new DrawData();
    int num = 0;
    for (int index = 0; index <= drawDataCache.Count; ++index)
    {
      if (drawinfo.projectileDrawPosition == index)
      {
        if (cdd.shader != 0)
          Main.pixelShader.CurrentTechnique.Passes[0].Apply();
        spriteBuffer.Unbind();
        PlayerDrawLayers.DrawHeldProj(drawinfo, drawinfo.SelectedDrawnProjectile);
      }
      if (index != drawDataCache.Count)
      {
        cdd = drawDataCache[index];
        if (!cdd.sourceRect.HasValue)
          cdd.sourceRect = new Rectangle?(cdd.texture.Frame());
        PlayerDrawHelper.SetShaderForData(drawinfo.drawPlayer, drawinfo.cHead, ref cdd);
        if (cdd.texture != null)
          spriteBuffer.DrawSingle(num++);
      }
    }
    spriteBuffer.Unbind();
    Main.pixelShader.CurrentTechnique.Passes[0].Apply();
  }

  private static void DrawHeldProj(PlayerDrawSet drawinfo, Projectile proj)
  {
    SamplerState samplerState = Main.graphics.GraphicsDevice.SamplerStates[0];
    Player player1 = Main.player[proj.owner];
    Player player2 = player1;
    player2.position = player2.position + player1.netOffset;
    Projectile projectile1 = proj;
    projectile1.position = projectile1.position + player1.netOffset;
    try
    {
      Main.instance.DrawProjDirect(proj, drawinfo.drawPlayer);
      if (proj.type != 595 && proj.type != 735)
      {
        if (proj.type != 927)
          goto label_5;
      }
      Main.instance.DrawProjDirect(proj, drawinfo.drawPlayer);
    }
    catch
    {
      proj.active = false;
    }
label_5:
    Player player3 = player1;
    player3.position = player3.position - player1.netOffset;
    Projectile projectile2 = proj;
    projectile2.position = projectile2.position - player1.netOffset;
    Main.graphics.GraphicsDevice.SamplerStates[0] = samplerState;
  }

  public static void DrawPlayer_RenderAllLayersSlow(ref PlayerDrawSet drawinfo)
  {
    int num = -1;
    List<DrawData> drawDataCache = drawinfo.DrawDataCache;
    Effect pixelShader = Main.pixelShader;
    Projectile[] projectile = Main.projectile;
    SpriteBatch spriteBatch = Main.spriteBatch;
    for (int index = 0; index <= drawDataCache.Count; ++index)
    {
      if (drawinfo.projectileDrawPosition == index)
      {
        if (num != 0)
        {
          pixelShader.CurrentTechnique.Passes[0].Apply();
          num = 0;
        }
        try
        {
          Main.instance.DrawProjDirect(drawinfo.SelectedDrawnProjectile, drawinfo.drawPlayer);
        }
        catch
        {
          drawinfo.SelectedDrawnProjectile.active = false;
        }
      }
      if (index != drawDataCache.Count)
      {
        DrawData cdd = drawDataCache[index];
        if (!cdd.sourceRect.HasValue)
          cdd.sourceRect = new Rectangle?(cdd.texture.Frame());
        PlayerDrawHelper.SetShaderForData(drawinfo.drawPlayer, drawinfo.cHead, ref cdd);
        num = cdd.shader;
        if (cdd.texture != null)
          cdd.Draw(spriteBatch);
      }
    }
    pixelShader.CurrentTechnique.Passes[0].Apply();
  }

  public static void DrawPlayer_DrawSelectionRect(ref PlayerDrawSet drawinfo)
  {
    Vector2 lowest;
    Vector2 highest;
    SpriteRenderTargetHelper.GetDrawBoundary(drawinfo.DrawDataCache, out lowest, out highest);
    Utils.DrawRect(Main.spriteBatch, lowest + Main.screenPosition, highest + Main.screenPosition, Color.White);
  }

  private static bool IsArmorDrawnWhenInvisible(int torsoID)
  {
    switch (torsoID)
    {
      case 21:
      case 22:
        return false;
      default:
        return true;
    }
  }

  private static DrawData[] GetFlatColoredCloneData(
    ref PlayerDrawSet drawinfo,
    Vector2 offset,
    Color color)
  {
    int colorOnlyShaderIndex = ContentSamples.DyeShaderIDs.ColorOnlyShaderIndex;
    DrawData[] coloredCloneData = new DrawData[drawinfo.DrawDataCache.Count];
    for (int index = 0; index < drawinfo.DrawDataCache.Count; ++index)
    {
      DrawData drawData = drawinfo.DrawDataCache[index];
      drawData.position += offset;
      drawData.shader = colorOnlyShaderIndex;
      drawData.color = color;
      coloredCloneData[index] = drawData;
    }
    return coloredCloneData;
  }
}
