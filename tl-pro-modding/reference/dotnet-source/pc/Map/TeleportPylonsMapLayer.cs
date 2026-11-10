// Decompiled with JetBrains decompiler
// Type: Terraria.Map.TeleportPylonsMapLayer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameInput;
using Terraria.UI;

#nullable disable
namespace Terraria.Map;

public class TeleportPylonsMapLayer : IMapLayer
{
  public const int BorderSize = 10;

  public static void DrawLine(
    SpriteBatch spriteBatch,
    Vector2 start,
    Vector2 end,
    Color col,
    float width)
  {
    float val2 = Vector2.Distance(start, end);
    float rotation = (end - start).ToRotation();
    int num = Math.Min(5, (int) val2);
    Rectangle rectangle = TextureAssets.BlackTile.Value.Frame();
    for (int index = 0; index < num; ++index)
      spriteBatch.Draw(TextureAssets.BlackTile.Value, Vector2.Lerp(start, end, (float) index / (float) num), new Rectangle?(rectangle), col, rotation, new Vector2(0.0f, (float) rectangle.Width * 0.5f), new Vector2((float) ((double) val2 / (double) num / 16.0), width / 16f), SpriteEffects.None, 0.0f);
  }

  public void Draw(ref MapOverlayDrawContext context, ref string text)
  {
    List<TeleportPylonInfo> pylons = Main.PylonSystem.Pylons;
    float num1 = 1f;
    float num2 = num1 * 2f;
    float num3 = num1 * 0.5f;
    Texture2D texture2D1 = TextureAssets.Extra[182].Value;
    Texture2D texture2D2 = TextureAssets.Extra[299].Value;
    Color color1 = Color.White;
    if (!TeleportPylonsSystem.IsPlayerNearAPylon(Main.LocalPlayer))
      color1 = Color.Gray * 0.5f;
    bool flag1 = false;
    int index1 = -1;
    SpriteFrame spriteFrame;
    if (Main.mapFullscreen && Main.MapPylonTile.X != (short) -1 && Main.MapPylonTile.Y != (short) -1)
    {
      ref MapOverlayDrawContext local1 = ref context;
      Texture2D texture1 = texture2D1;
      Vector2 position1 = Main.MapPylonTile.ToVector2() + new Vector2(1.5f, 2f);
      spriteFrame = new SpriteFrame((byte) 11, (byte) 1, (byte) 0, (byte) 0);
      spriteFrame.PaddingY = 0;
      SpriteFrame frame1 = spriteFrame;
      double scale1 = (double) num1;
      Alignment center1 = Alignment.Center;
      Rectangle unclampedDrawRegion = local1.GetUnclampedDrawRegion(texture1, position1, frame1, (float) scale1, center1);
      Point center2 = unclampedDrawRegion.Center;
      for (int index2 = 0; index2 < pylons.Count; ++index2)
      {
        TeleportPylonInfo info = pylons[index2];
        if (TeleportPylonsMapLayer.IsRevealed(info) && !(info.PositionInTiles == Main.MapPylonTile))
        {
          ref MapOverlayDrawContext local2 = ref context;
          Texture2D texture2 = texture2D1;
          Vector2 position2 = info.PositionInTiles.ToVector2() + new Vector2(1.5f, 2f);
          spriteFrame = new SpriteFrame((byte) 11, (byte) 1, (byte) 0, (byte) 0);
          spriteFrame.PaddingY = 0;
          SpriteFrame frame2 = spriteFrame;
          double scale2 = (double) num1;
          Alignment center3 = Alignment.Center;
          unclampedDrawRegion = local2.GetUnclampedDrawRegion(texture2, position2, frame2, (float) scale2, center3);
          Point center4 = unclampedDrawRegion.Center;
          TeleportPylonsMapLayer.DrawLine(Main.spriteBatch, center2.ToVector2(), center4.ToVector2(), Color.Black, 6f);
          TeleportPylonsMapLayer.DrawLine(Main.spriteBatch, center2.ToVector2(), center4.ToVector2(), Color.White, 2f);
        }
      }
    }
    for (int index3 = 0; index3 < pylons.Count; ++index3)
    {
      TeleportPylonInfo info = pylons[index3];
      if (TeleportPylonsMapLayer.IsRevealed(info))
      {
        bool flag2 = true;
        MapOverlayDrawContext.DrawResult drawResult;
        if (Main.mapFullscreen)
        {
          ref MapOverlayDrawContext local3 = ref context;
          Texture2D texture = texture2D1;
          Texture2D offscreenTexture = texture2D2;
          Vector2 position = info.PositionInTiles.ToVector2() + new Vector2(1.5f, 2f);
          Color color2 = color1;
          spriteFrame = new SpriteFrame((byte) 11, (byte) 1, (byte) info.TypeOfPylon, (byte) 0);
          spriteFrame.PaddingY = 0;
          SpriteFrame frame = spriteFrame;
          double scaleIfNotSelected = (double) num1;
          double scaleIfSelected = (double) num2;
          double scaleIfOffscreen = (double) num3;
          Alignment center = Alignment.Center;
          ref bool local4 = ref flag2;
          drawResult = local3.DrawClamped(texture, offscreenTexture, position, color2, frame, (float) scaleIfNotSelected, (float) scaleIfSelected, (float) scaleIfOffscreen, center, 10, out local4);
        }
        else
        {
          ref MapOverlayDrawContext local = ref context;
          Texture2D texture = texture2D1;
          Vector2 position = info.PositionInTiles.ToVector2() + new Vector2(1.5f, 2f);
          Color color3 = color1;
          spriteFrame = new SpriteFrame((byte) 11, (byte) 1, (byte) info.TypeOfPylon, (byte) 0);
          spriteFrame.PaddingY = 0;
          SpriteFrame frame = spriteFrame;
          double scaleIfNotSelected = (double) num1;
          double scaleIfSelected = (double) num2;
          Alignment center = Alignment.Center;
          drawResult = local.Draw(texture, position, color3, frame, (float) scaleIfNotSelected, (float) scaleIfSelected, center);
        }
        if (drawResult.IsMouseOver)
        {
          Main.cancelWormHole = true;
          string itemNameValue = Lang.GetItemNameValue(TETeleportationPylon.GetPylonItemTypeFromTileStyle((int) info.TypeOfPylon));
          text = itemNameValue;
          if (Main.mouseLeft && Main.mouseLeftRelease)
          {
            flag1 = flag2;
            index1 = index3;
          }
        }
      }
    }
    if (index1 == -1 || !Main.mouseLeft || !Main.mouseLeftRelease)
      return;
    TeleportPylonInfo info1 = pylons[index1];
    if (flag1)
    {
      Main.mouseLeftRelease = false;
      Main.mapFullscreen = false;
      PlayerInput.LockGamepadButtons("MouseLeft");
      Main.PylonSystem.RequestTeleportation(info1, Main.LocalPlayer);
      SoundEngine.PlaySound(11);
    }
    else
    {
      Main.mouseLeftRelease = false;
      PlayerInput.LockGamepadButtons("MouseLeft");
      Main.PanTargetMapFullscreen = true;
      Main.PanTargetMapFullscreenEnd.X = (float) info1.PositionInTiles.X;
      Main.PanTargetMapFullscreenEnd.Y = (float) info1.PositionInTiles.Y;
    }
  }

  public static bool IsRevealed(TeleportPylonInfo info)
  {
    return !Main.teamBasedSpawnsSeed || Main.Map.IsRevealed((int) info.PositionInTiles.X, (int) info.PositionInTiles.Y);
  }
}
