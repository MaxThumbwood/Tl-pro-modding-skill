// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Tile_Entities.TEDisplayDoll
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.Graphics.Renderers;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.Tile_Entities;

public class TEDisplayDoll : TileEntityType<TEDisplayDoll>, IFixLoadedData
{
  private const int MyTileID = 470;
  public const int entityTileWidth = 2;
  public const int entityTileHeight = 3;
  private Player _dollPlayer;
  private Item[] _equip;
  private Item[] _dyes;
  private Item[] _misc;
  private byte _pose;
  public static Dictionary<int, List<TEDisplayDoll.DisplayDollPose>> SupportedUseStylePoses = new Dictionary<int, List<TEDisplayDoll.DisplayDollPose>>();
  private static Projectile _projectileDummy = new Projectile();
  private static LegacyPlayerRenderer _playerRenderer = new LegacyPlayerRenderer();

  public Item[] Equipment => this._equip;

  static TEDisplayDoll()
  {
    TEDisplayDoll.SupportedUseStylePoses.Clear();
    TEDisplayDoll.RegisterUsePose(1, DisplayDollPoseID.Use1, 1f);
    TEDisplayDoll.RegisterUsePose(1, DisplayDollPoseID.Use2, 0.8f);
    TEDisplayDoll.RegisterUsePose(1, DisplayDollPoseID.Use3, 0.6f);
    TEDisplayDoll.RegisterUsePose(1, DisplayDollPoseID.Use4, 0.4143f);
    TEDisplayDoll.RegisterUsePose(1, DisplayDollPoseID.Use5, 0.2f);
    TEDisplayDoll.RegisterUsePose(7, DisplayDollPoseID.Use1, 0.5f);
    TEDisplayDoll.RegisterUsePose(3, DisplayDollPoseID.Use1, 0.5f);
    TEDisplayDoll.RegisterUsePose(4, DisplayDollPoseID.Use1, 0.5f);
    TEDisplayDoll.RegisterUsePose(5, DisplayDollPoseID.Use1, 0.5f, new float?(-1.57079637f));
    TEDisplayDoll.RegisterUsePose(5, DisplayDollPoseID.Use2, 0.5f, new float?(-0.7853982f));
    TEDisplayDoll.RegisterUsePose(5, DisplayDollPoseID.Use3, 0.5f, new float?(0.0f));
    TEDisplayDoll.RegisterUsePose(5, DisplayDollPoseID.Use4, 0.5f, new float?(0.7853981f));
    TEDisplayDoll.RegisterUsePose(5, DisplayDollPoseID.Use5, 0.5f, new float?(1.57079637f));
    TEDisplayDoll.RegisterUsePose(6, DisplayDollPoseID.Use1, 0.5f);
    TEDisplayDoll.RegisterUsePose(2, DisplayDollPoseID.Use1, 0.5f);
    TEDisplayDoll.RegisterUsePose(8, DisplayDollPoseID.Use1, 0.5f);
    TEDisplayDoll.RegisterUsePose(9, DisplayDollPoseID.Use1, 0.5f);
    TEDisplayDoll.RegisterUsePose(11, DisplayDollPoseID.Use1, 0.5f);
    TEDisplayDoll.RegisterUsePose(12, DisplayDollPoseID.Use1, 0.75f);
    TEDisplayDoll.RegisterUsePose(12, DisplayDollPoseID.Use2, 0.5f);
    TEDisplayDoll.RegisterUsePose(12, DisplayDollPoseID.Use3, 0.25f);
    TEDisplayDoll.RegisterUsePose(13, DisplayDollPoseID.Use1, 0.5f, new float?(-1.57079637f));
    TEDisplayDoll.RegisterUsePose(13, DisplayDollPoseID.Use2, 0.5f, new float?(-0.7853982f));
    TEDisplayDoll.RegisterUsePose(13, DisplayDollPoseID.Use3, 0.5f, new float?(0.0f));
    TEDisplayDoll.RegisterUsePose(13, DisplayDollPoseID.Use4, 0.5f, new float?(0.7853981f));
    TEDisplayDoll.RegisterUsePose(13, DisplayDollPoseID.Use5, 0.5f, new float?(1.57079637f));
    TEDisplayDoll.RegisterUsePose(14, DisplayDollPoseID.Use1, 0.5f);
    TEDisplayDoll.RegisterUsePose(15, DisplayDollPoseID.Use1, 0.5f);
  }

  private static void RegisterUsePose(
    int useStyle,
    DisplayDollPoseID pose,
    float usePercent,
    float? useAim = null)
  {
    List<TEDisplayDoll.DisplayDollPose> displayDollPoseList;
    if (!TEDisplayDoll.SupportedUseStylePoses.TryGetValue(useStyle, out displayDollPoseList))
    {
      displayDollPoseList = new List<TEDisplayDoll.DisplayDollPose>();
      TEDisplayDoll.SupportedUseStylePoses[useStyle] = displayDollPoseList;
    }
    displayDollPoseList.Add(new TEDisplayDoll.DisplayDollPose()
    {
      Pose = pose,
      ItemAnimationPercent = usePercent,
      ItemAimRadians = useAim
    });
  }

  public TEDisplayDoll()
  {
    this._equip = new Item[9];
    for (int index = 0; index < this._equip.Length; ++index)
      this._equip[index] = new Item();
    this._dyes = new Item[9];
    for (int index = 0; index < this._dyes.Length; ++index)
      this._dyes[index] = new Item();
    this._misc = new Item[1];
    for (int index = 0; index < this._misc.Length; ++index)
      this._misc[index] = new Item();
    this._dollPlayer = new Player();
    this._dollPlayer.hair = 15;
    this._dollPlayer.skinColor = Color.White;
    this._dollPlayer.skinVariant = 10;
  }

  public static int Hook_AfterPlacement(
    int x,
    int y,
    int type = 470,
    int style = 0,
    int direction = 1,
    int alternate = 0)
  {
    if (Main.netMode != 1)
      return TileEntityType<TEDisplayDoll>.Place(x, y - 2);
    NetMessage.SendTileSquare(Main.myPlayer, x, y - 2, 2, 3);
    NetMessage.SendData(87, number: x, number2: (float) (y - 2), number3: (float) TileEntityType<TEDisplayDoll>.EntityTypeID);
    return -1;
  }

  private bool IsValidPose(int testedPose)
  {
    bool flag = false;
    switch (testedPose)
    {
      case 0:
      case 1:
      case 2:
      case 3:
        flag = true;
        break;
    }
    Item obj = this._misc[0];
    List<TEDisplayDoll.DisplayDollPose> displayDollPoseList;
    if (!flag && obj != null && !obj.IsAir && TEDisplayDoll.SupportedUseStylePoses.TryGetValue(obj.useStyle, out displayDollPoseList))
    {
      foreach (TEDisplayDoll.DisplayDollPose displayDollPose in displayDollPoseList)
      {
        if ((DisplayDollPoseID) this._pose == displayDollPose.Pose)
        {
          flag = true;
          break;
        }
      }
    }
    return flag;
  }

  public override void WriteExtraData(BinaryWriter writer, bool networkSend)
  {
    BitsByte bitsByte1 = (BitsByte) (byte) 0;
    bitsByte1[0] = !this._equip[0].IsAir;
    bitsByte1[1] = !this._equip[1].IsAir;
    bitsByte1[2] = !this._equip[2].IsAir;
    bitsByte1[3] = !this._equip[3].IsAir;
    bitsByte1[4] = !this._equip[4].IsAir;
    bitsByte1[5] = !this._equip[5].IsAir;
    bitsByte1[6] = !this._equip[6].IsAir;
    bitsByte1[7] = !this._equip[7].IsAir;
    BitsByte bitsByte2 = (BitsByte) (byte) 0;
    bitsByte2[0] = !this._dyes[0].IsAir;
    bitsByte2[1] = !this._dyes[1].IsAir;
    bitsByte2[2] = !this._dyes[2].IsAir;
    bitsByte2[3] = !this._dyes[3].IsAir;
    bitsByte2[4] = !this._dyes[4].IsAir;
    bitsByte2[5] = !this._dyes[5].IsAir;
    bitsByte2[6] = !this._dyes[6].IsAir;
    bitsByte2[7] = !this._dyes[7].IsAir;
    BitsByte bitsByte3 = (BitsByte) (byte) 0;
    bitsByte3[0] = !this._misc[0].IsAir;
    bitsByte3[1] = !this._equip[8].IsAir;
    bitsByte3[2] = !this._dyes[8].IsAir;
    writer.Write((byte) bitsByte1);
    writer.Write((byte) bitsByte2);
    writer.Write(this._pose);
    writer.Write((byte) bitsByte3);
    foreach (Item obj in this._equip)
    {
      if (!obj.IsAir)
      {
        writer.Write((short) obj.type);
        writer.Write(obj.prefix);
        writer.Write((short) obj.stack);
      }
    }
    foreach (Item dye in this._dyes)
    {
      if (!dye.IsAir)
      {
        writer.Write((short) dye.type);
        writer.Write(dye.prefix);
        writer.Write((short) dye.stack);
      }
    }
    foreach (Item obj in this._misc)
    {
      if (!obj.IsAir)
      {
        writer.Write((short) obj.type);
        writer.Write(obj.prefix);
        writer.Write((short) obj.stack);
      }
    }
  }

  public override void ReadExtraData(BinaryReader reader, int gameVersion, bool networkSend)
  {
    BitsByte bitsByte1 = (BitsByte) reader.ReadByte();
    BitsByte bitsByte2 = (BitsByte) reader.ReadByte();
    if (gameVersion >= 307)
      this._pose = reader.ReadByte();
    BitsByte bitsByte3 = (BitsByte) (byte) 0;
    if (gameVersion >= 308)
      bitsByte3 = (BitsByte) reader.ReadByte();
    bool flag = false;
    if (gameVersion == 311)
    {
      flag = bitsByte3[1];
      bitsByte3[1] = false;
    }
    int num1 = (int) (byte) bitsByte1 | (bitsByte3[1] ? 256 /*0x0100*/ : 0);
    for (int index = 0; index < this._equip.Length; ++index)
    {
      this._equip[index] = new Item();
      Item obj = this._equip[index];
      if ((num1 & 1 << index) != 0)
      {
        obj.netDefaults((int) reader.ReadInt16());
        obj.Prefix((int) reader.ReadByte());
        obj.stack = (int) reader.ReadInt16();
      }
    }
    long num2 = (long) ((int) (byte) bitsByte2 | (bitsByte3[2] ? 256 /*0x0100*/ : 0));
    for (int index = 0; index < this._dyes.Length; ++index)
    {
      this._dyes[index] = new Item();
      Item dye = this._dyes[index];
      if ((num2 & (long) (1 << index)) != 0L)
      {
        dye.netDefaults((int) reader.ReadInt16());
        dye.Prefix((int) reader.ReadByte());
        dye.stack = (int) reader.ReadInt16();
      }
    }
    for (int key = 0; key < this._misc.Length; ++key)
    {
      this._misc[key] = new Item();
      Item obj = this._misc[key];
      if (bitsByte3[key])
      {
        obj.netDefaults((int) reader.ReadInt16());
        obj.Prefix((int) reader.ReadByte());
        obj.stack = (int) reader.ReadInt16();
      }
    }
    if (!flag)
      return;
    Item obj1 = this._equip[8];
    obj1.netDefaults((int) reader.ReadInt16());
    obj1.Prefix((int) reader.ReadByte());
    obj1.stack = (int) reader.ReadInt16();
  }

  public override string ToString()
  {
    return $"{(object) this.Position.X}x  {(object) this.Position.Y}y item: {(object) this._equip[0]} {(object) this._equip[1]} {(object) this._equip[2]}";
  }

  public static void Framing_CheckTile(int callX, int callY)
  {
    if (WorldGen.destroyObject)
      return;
    int num1 = callX;
    int num2 = callY;
    Tile tileSafely = Framing.GetTileSafely(callX, callY);
    int num3 = num1 - (int) tileSafely.frameX / 18 % 2;
    int num4 = num2 - (int) tileSafely.frameY / 18 % 3;
    bool flag = false;
    for (int index1 = num3; index1 < num3 + 2; ++index1)
    {
      for (int index2 = num4; index2 < num4 + 3; ++index2)
      {
        Tile tile = Main.tile[index1, index2];
        if (!tile.active() || tile.type != (ushort) 470)
          flag = true;
      }
    }
    if (!WorldGen.SolidTileAllowBottomSlope(num3, num4 + 3) || !WorldGen.SolidTileAllowBottomSlope(num3 + 1, num4 + 3))
      flag = true;
    if (!flag)
      return;
    TileEntityType<TEDisplayDoll>.Kill(num3, num4);
    if ((int) Main.tile[callX, callY].frameX / 72 != 1)
      Item.NewItem((IEntitySource) new EntitySource_TileBreak(num3, num4), num3 * 16 /*0x10*/, num4 * 16 /*0x10*/, 32 /*0x20*/, 48 /*0x30*/, 498);
    else
      Item.NewItem((IEntitySource) new EntitySource_TileBreak(num3, num4), num3 * 16 /*0x10*/, num4 * 16 /*0x10*/, 32 /*0x20*/, 48 /*0x30*/, 1989);
    WorldGen.destroyObject = true;
    for (int i = num3; i < num3 + 2; ++i)
    {
      for (int j = num4; j < num4 + 3; ++j)
      {
        if (Main.tile[i, j].active() && Main.tile[i, j].type == (ushort) 470)
          WorldGen.KillTile(i, j);
      }
    }
    WorldGen.destroyObject = false;
  }

  public void Draw(int tileLeftX, int tileTopY)
  {
    Player dollPlayer = this._dollPlayer;
    for (int index = 0; index < 8; ++index)
    {
      dollPlayer.armor[index] = this._equip[index];
      dollPlayer.dye[index] = this._dyes[index];
    }
    Item sItem = this._misc[0];
    dollPlayer.inventory[0] = sItem;
    dollPlayer.direction = -1;
    dollPlayer.Male = true;
    Tile tileSafely = Framing.GetTileSafely(tileLeftX, tileTopY);
    if ((int) tileSafely.frameX % 72 == 36)
      dollPlayer.direction = 1;
    if ((int) tileSafely.frameX / 72 == 1)
      dollPlayer.Male = false;
    dollPlayer.isDisplayDollOrInanimate = true;
    dollPlayer.ResetEffects();
    dollPlayer.ResetVisibleAccessories();
    dollPlayer.UpdateDyes();
    dollPlayer.DisplayDollUpdate();
    dollPlayer.UpdateSocialShadow();
    dollPlayer.bodyFrameCounter = 0.0;
    dollPlayer.headFrameCounter = 0.0;
    dollPlayer.legFrameCounter = 0.0;
    dollPlayer.wingFrameCounter = 0;
    dollPlayer.sitting.isSitting = false;
    dollPlayer.itemAnimationMax = 0;
    dollPlayer.itemAnimation = 0;
    Item obj = this._equip[8];
    int m = -1;
    if (!obj.IsAir)
      m = obj.mountType;
    if (dollPlayer.mount.Type != m)
    {
      if (m == -1)
        dollPlayer.mount.Dismount(dollPlayer);
      else
        dollPlayer.mount.SetMount(m, dollPlayer);
    }
    dollPlayer.miscDyes[3] = this._dyes[8];
    dollPlayer.miscDyes[2] = this._dyes[8];
    int num1 = 0;
    DisplayDollPoseID displayDollPoseId = (DisplayDollPoseID) this._pose;
    if (!this.IsValidPose((int) this._pose))
      displayDollPoseId = DisplayDollPoseID.Standing;
    if (m != -1)
    {
      dollPlayer.mount.ApplyDummyFrameCounters();
      if (displayDollPoseId == DisplayDollPoseID.Sitting || displayDollPoseId == DisplayDollPoseID.Jumping)
        displayDollPoseId = DisplayDollPoseID.Standing;
    }
    switch (displayDollPoseId)
    {
      case DisplayDollPoseID.Standing:
        dollPlayer.velocity = Vector2.Zero;
        break;
      case DisplayDollPoseID.Sitting:
        dollPlayer.velocity = Vector2.Zero;
        dollPlayer.sitting.isSitting = true;
        num1 = 14;
        break;
      case DisplayDollPoseID.Jumping:
        dollPlayer.velocity = Vector2.UnitY;
        break;
      case DisplayDollPoseID.Walking:
        dollPlayer.velocity = Vector2.UnitX * (float) dollPlayer.direction;
        dollPlayer.legFrame.Y = dollPlayer.legFrame.Height * 9;
        dollPlayer.bodyFrame.Y = dollPlayer.legFrame.Y;
        break;
      default:
        dollPlayer.velocity = Vector2.Zero;
        List<TEDisplayDoll.DisplayDollPose> displayDollPoseList1;
        if (TEDisplayDoll.SupportedUseStylePoses.TryGetValue(sItem.useStyle, out displayDollPoseList1))
        {
          using (List<TEDisplayDoll.DisplayDollPose>.Enumerator enumerator = displayDollPoseList1.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              TEDisplayDoll.DisplayDollPose current = enumerator.Current;
              if ((DisplayDollPoseID) this._pose == current.Pose)
              {
                dollPlayer.itemAnimationMax = 1000;
                dollPlayer.itemAnimation = (int) (1000.0 * (double) current.ItemAnimationPercent);
                dollPlayer.itemRotation = 0.0f;
                float? itemAimRadians = current.ItemAimRadians;
                if (itemAimRadians.HasValue)
                {
                  Player player = dollPlayer;
                  itemAimRadians = current.ItemAimRadians;
                  double num2 = (double) itemAimRadians.Value;
                  player.itemRotation = (float) num2;
                  if (dollPlayer.direction == -1)
                  {
                    dollPlayer.itemRotation *= -1f;
                    break;
                  }
                  break;
                }
                break;
              }
            }
            break;
          }
        }
        break;
    }
    dollPlayer.PlayerFrame();
    Vector2 vector2 = new Vector2((float) (tileLeftX + 1), (float) (tileTopY + 3)) * 16f + new Vector2((float) (-dollPlayer.width / 2), (float) (-dollPlayer.height - 6 + num1));
    dollPlayer.position = vector2;
    dollPlayer.lastVisualizedSelectedItem = sItem;
    dollPlayer.ItemCheck_EmitHeldItemLight(sItem);
    dollPlayer.AnimatePlayerAndGetItemFrame(0.0f, sItem);
    TEDisplayDoll._playerRenderer.OverrideHeldProjectile = (Projectile) null;
    if (sItem != null && !sItem.IsAir && sItem.shoot > 0)
    {
      Projectile projectileDummy = TEDisplayDoll._projectileDummy;
      projectileDummy.SetDefaults(sItem.shoot);
      projectileDummy.isAPreviewDisplayDoll = true;
      bool botherDrawing = false;
      List<TEDisplayDoll.DisplayDollPose> displayDollPoseList2;
      if (TEDisplayDoll.SupportedUseStylePoses.TryGetValue(sItem.useStyle, out displayDollPoseList2))
      {
        foreach (TEDisplayDoll.DisplayDollPose pose in displayDollPoseList2)
        {
          if ((DisplayDollPoseID) this._pose == pose.Pose)
          {
            projectileDummy.AI_DisplayDoll(dollPlayer, pose, out botherDrawing);
            break;
          }
        }
      }
      if (botherDrawing)
      {
        TEDisplayDoll._playerRenderer.OverrideHeldProjectile = projectileDummy;
        switch (projectileDummy.drawLayer)
        {
          case 0:
          case 1:
          case 2:
          case 3:
            Main.instance.DrawProjDirect(projectileDummy);
            break;
        }
      }
    }
    dollPlayer.isFullbright = tileSafely.fullbrightBlock();
    dollPlayer.skinDyePacked = PlayerDrawHelper.PackShader((int) tileSafely.color(), PlayerDrawHelper.ShaderConfiguration.TilePaintID);
    TEDisplayDoll._playerRenderer.PrepareDrawForFrame(dollPlayer);
    TEDisplayDoll._playerRenderer.DrawPlayer(Main.Camera, dollPlayer, dollPlayer.position, 0.0f, dollPlayer.fullRotationOrigin, 0.0f, 1f);
  }

  public override void OnPlayerUpdate(Player player)
  {
    if (player.InTileEntityInteractionRange(player.tileEntityAnchor.X, player.tileEntityAnchor.Y, 2, 3, TileReachCheckSettings.Simple) && player.chest == -1 && player.talkNPC == -1)
      return;
    if (player.chest == -1 && player.talkNPC == -1)
      SoundEngine.PlaySound(11);
    player.tileEntityAnchor.Clear();
  }

  public static void OnPlayerInteraction(Player player, int clickX, int clickY)
  {
    int x = clickX;
    int index = clickY;
    if ((int) Main.tile[x, index].frameX % 36 != 0)
      --x;
    int y1 = index - (int) Main.tile[x, index].frameY / 18;
    int id = TileEntityType<TEDisplayDoll>.Find(x, y1);
    if (id == -1)
      return;
    int y2 = y1 + 1;
    TileEntity.BasicOpenCloseInteraction(player, x, y2, id);
  }

  public override void OnInventoryDraw(Player player, SpriteBatch spriteBatch)
  {
    if (Main.tile[player.tileEntityAnchor.X, player.tileEntityAnchor.Y].type != (ushort) 470)
      player.tileEntityAnchor.Clear();
    else
      this.DrawUI(player, spriteBatch);
  }

  public string GetItemGamepadInstructions(int slot = 0)
  {
    Item[] inv = this._equip;
    int slot1 = slot;
    int context;
    if (slot >= 18)
    {
      inv = this._misc;
      slot1 = 0;
      context = 38;
    }
    else if (slot >= 9)
    {
      slot1 -= 9;
      inv = this._dyes;
      context = 25;
    }
    else
      context = slot != 8 ? (slot < 3 ? 23 : 24) : 39;
    return ItemSlot.GetGamepadInstructions(inv, context, slot1);
  }

  private void DrawUI(Player player, SpriteBatch spriteBatch)
  {
    Main.inventoryScale = 0.755f;
    this.DrawSlotMisc(player, spriteBatch, 1, 0, 0.0f, 0.5f, 38);
    this.DrawSlotPairSet(player, spriteBatch, 3, 0, 1f, 0.5f, 23);
    this.DrawSlotPairSet(player, spriteBatch, 5, 3, 4f, 0.5f, 24);
    this.DrawSlotPairSet(player, spriteBatch, 1, 8, 9f, 0.5f, 39);
  }

  private void DrawSlotMisc(
    Player player,
    SpriteBatch spriteBatch,
    int slotsToShowLine,
    int slotsArrayOffset,
    float offsetX,
    float offsetY,
    int inventoryContextTarget)
  {
    Item[] misc = this._misc;
    int context = inventoryContextTarget;
    for (int index1 = 0; index1 < slotsToShowLine; ++index1)
    {
      for (int index2 = 0; index2 < 1; ++index2)
      {
        int num1 = (int) (22.0 + ((double) index1 + (double) offsetX) * 56.0 * (double) Main.inventoryScale);
        int num2 = (int) ((double) Main.instance.invBottom + ((double) index2 + (double) offsetY) * 56.0 * (double) Main.inventoryScale);
        if (index2 == 0)
        {
          misc = this._misc;
          context = inventoryContextTarget;
        }
        if (Utils.FloatIntersect((float) Main.mouseX, (float) Main.mouseY, 0.0f, 0.0f, (float) num1, (float) num2, (float) TextureAssets.InventoryBack.Width() * Main.inventoryScale, (float) TextureAssets.InventoryBack.Height() * Main.inventoryScale) && !PlayerInput.IgnoreMouseInterface)
        {
          player.mouseInterface = true;
          ItemSlot.Handle(misc, context, index1 + slotsArrayOffset);
        }
        ItemSlot.Draw(spriteBatch, misc, context, index1 + slotsArrayOffset, new Vector2((float) num1, (float) num2));
      }
    }
  }

  private void DrawSlotPairSet(
    Player player,
    SpriteBatch spriteBatch,
    int slotsToShowLine,
    int slotsArrayOffset,
    float offsetX,
    float offsetY,
    int inventoryContextTarget)
  {
    Item[] equip = this._equip;
    for (int index1 = 0; index1 < slotsToShowLine; ++index1)
    {
      for (int index2 = 0; index2 < 2; ++index2)
      {
        int num1 = (int) (22.0 + ((double) index1 + (double) offsetX) * 56.0 * (double) Main.inventoryScale);
        int num2 = (int) ((double) Main.instance.invBottom + ((double) index2 + (double) offsetY) * 56.0 * (double) Main.inventoryScale);
        Item[] inv;
        int context;
        if (index2 == 0)
        {
          inv = this._equip;
          context = inventoryContextTarget;
        }
        else
        {
          inv = this._dyes;
          context = 25;
        }
        if (Utils.FloatIntersect((float) Main.mouseX, (float) Main.mouseY, 0.0f, 0.0f, (float) num1, (float) num2, (float) TextureAssets.InventoryBack.Width() * Main.inventoryScale, (float) TextureAssets.InventoryBack.Height() * Main.inventoryScale) && !PlayerInput.IgnoreMouseInterface)
        {
          player.mouseInterface = true;
          ItemSlot.Handle(inv, context, index1 + slotsArrayOffset);
        }
        ItemSlot.Draw(spriteBatch, inv, context, index1 + slotsArrayOffset, new Vector2((float) num1, (float) num2));
      }
    }
  }

  public override ItemSlot.AlternateClickAction? GetShiftClickAction(
    Item[] inv,
    int context = 0,
    int slot = 0)
  {
    Item newItem = inv[slot];
    if (context == 0 && TEDisplayDoll.CanQuickSwapIntoDisplayDoll(newItem))
      return new ItemSlot.AlternateClickAction?(ItemSlot.AlternateClickAction.TransferToChest);
    return (context == 23 || context == 24 || context == 39 || context == 25 || context == 38) && Main.LocalPlayer.ItemSpace(newItem).CanTakeItemToPersonalInventory ? new ItemSlot.AlternateClickAction?(ItemSlot.AlternateClickAction.TransferFromChest) : new ItemSlot.AlternateClickAction?();
  }

  public override bool PerformShiftClickAction(Item[] inv, int context = 0, int slot = 0)
  {
    Item newItem = inv[slot];
    if (Main.cursorOverride == 9 && context == 0)
    {
      if (!newItem.IsAir && !newItem.favorited && TEDisplayDoll.CanQuickSwapIntoDisplayDoll(newItem))
        return this.TryFitting(inv, slot);
    }
    else if (Main.cursorOverride == 8 && (context == 23 || context == 24 || context == 39 || context == 25 || context == 38))
    {
      inv[slot] = Main.LocalPlayer.GetItem(newItem, GetItemSettings.QuickTransferFromSlot);
      if (Main.netMode == 1)
      {
        int player = Main.myPlayer;
        double id = (double) this.ID;
        double number3 = (double) slot;
        int num;
        switch (context)
        {
          case 25:
            num = 1;
            break;
          case 38:
            num = 3;
            break;
          default:
            num = 0;
            break;
        }
        double number4 = (double) num;
        NetMessage.SendData(121, number: player, number2: (float) id, number3: (float) number3, number4: (float) number4);
      }
      return true;
    }
    return false;
  }

  public static bool CanQuickSwapIntoDisplayDoll(Item item)
  {
    return item.headSlot > 0 || item.bodySlot > 0 || item.legSlot > 0 || item.accessory || item.mountType >= 0 || TEDisplayDoll.AcceptedInWeaponSlot(item);
  }

  public static bool AcceptedInWeaponSlot(Item item)
  {
    return item.useStyle != 0 && item.mountType == -1 || item.holdStyle != 0;
  }

  private bool TryFitting(Item[] inv, int slot)
  {
    Item obj = inv[slot];
    Item[] objArray = this._equip;
    int number3 = -1;
    if (obj.headSlot > 0)
      number3 = 0;
    else if (obj.bodySlot > 0)
      number3 = 1;
    else if (obj.legSlot > 0)
      number3 = 2;
    else if (obj.accessory)
      number3 = this.GetAccessoryTargetSlot(obj);
    else if (obj.mountType >= 0)
      number3 = 8;
    else if (TEDisplayDoll.AcceptedInWeaponSlot(obj))
    {
      objArray = this._misc;
      number3 = 0;
    }
    if (number3 == -1)
      return false;
    if (obj.stack > 1 && !objArray[number3].IsAir)
      return true;
    SoundEngine.PlaySound(7);
    if (obj.stack > 1)
    {
      obj.favorited = false;
      objArray[number3] = obj.Clone();
      objArray[number3].stack = 1;
      --obj.stack;
    }
    else
    {
      inv[slot].favorited = false;
      Utils.Swap<Item>(ref objArray[number3], ref inv[slot]);
    }
    if (Main.netMode == 1)
      NetMessage.SendData(121, number: Main.myPlayer, number2: (float) this.ID, number3: (float) number3, number4: objArray == this._misc ? 3f : 0.0f);
    return true;
  }

  private int GetAccessoryTargetSlot(Item item)
  {
    int collisionSlot;
    if (ItemSlot.HasIncompatibleAccessory(item, new ArraySegment<Item>(this._equip, 3, 5), out collisionSlot))
      return collisionSlot;
    for (int accessoryTargetSlot = 3; accessoryTargetSlot < 6; ++accessoryTargetSlot)
    {
      if (this._equip[accessoryTargetSlot].IsAir)
        return accessoryTargetSlot;
    }
    return 3;
  }

  public void WriteItem(int itemIndex, BinaryWriter writer, Item[] collection)
  {
    Item obj = collection[itemIndex];
    writer.Write((ushort) obj.type);
    writer.Write((ushort) obj.stack);
    writer.Write(obj.prefix);
  }

  public void ReadItem(int itemIndex, BinaryReader reader, Item[] collection)
  {
    int Type = (int) reader.ReadUInt16();
    int num = (int) reader.ReadUInt16();
    int prefixWeWant = (int) reader.ReadByte();
    if (itemIndex >= collection.Length)
      return;
    Item obj = collection[itemIndex];
    obj.SetDefaults(Type);
    obj.stack = num;
    obj.Prefix(prefixWeWant);
  }

  public void WriteData(int itemIndex, int command, BinaryWriter writer)
  {
    bool flag1 = command == 1;
    int num = command == 2 ? 1 : 0;
    bool flag2 = command == 3;
    if (num != 0)
    {
      writer.Write(this._pose);
    }
    else
    {
      Item[] collection = this._equip;
      if (flag1)
        collection = this._dyes;
      if (flag2)
        collection = this._misc;
      this.WriteItem(itemIndex, writer, collection);
    }
  }

  public void ReadData(int itemIndex, int command, BinaryReader reader)
  {
    bool flag1 = command == 1;
    int num = command == 2 ? 1 : 0;
    bool flag2 = command == 3;
    if (num != 0)
    {
      this.ReadPose(reader);
    }
    else
    {
      Item[] collection = this._equip;
      if (flag1)
        collection = this._dyes;
      if (flag2)
        collection = this._misc;
      this.ReadItem(itemIndex, reader, collection);
    }
  }

  public static void WriteDummySync(int itemIndex, int command, BinaryWriter writer)
  {
    if (command == 2)
    {
      writer.Write((byte) 0);
    }
    else
    {
      writer.Write(0);
      writer.Write((byte) 0);
    }
  }

  public static void ReadDummySync(int itemIndex, int command, BinaryReader reader)
  {
    if (command == 2)
    {
      int num1 = (int) reader.ReadByte();
    }
    else
    {
      reader.ReadInt32();
      int num2 = (int) reader.ReadByte();
    }
  }

  public void ReadPose(BinaryReader reader) => this._pose = reader.ReadByte();

  public override bool IsTileValidForEntity(int x, int y)
  {
    return Main.tile[x, y].active() && Main.tile[x, y].type == (ushort) 470 && Main.tile[x, y].frameY == (short) 0 && (int) Main.tile[x, y].frameX % 36 == 0;
  }

  public void SetInventoryFromMannequin(int headFrame, int shirtFrame, int legFrame)
  {
    headFrame /= 100;
    shirtFrame /= 100;
    legFrame /= 100;
    if (headFrame >= 0 && headFrame < Item.headType.Length)
      this._equip[0].SetDefaults(Item.headType[headFrame]);
    if (shirtFrame >= 0 && shirtFrame < Item.bodyType.Length)
      this._equip[1].SetDefaults(Item.bodyType[shirtFrame]);
    if (legFrame < 0 || legFrame >= Item.legType.Length)
      return;
    this._equip[2].SetDefaults(Item.legType[legFrame]);
  }

  public static bool IsBreakable(int clickX, int clickY)
  {
    int x = clickX;
    int index = clickY;
    if ((int) Main.tile[x, index].frameX % 36 != 0)
      --x;
    int y = index - (int) Main.tile[x, index].frameY / 18;
    TEDisplayDoll result;
    return !TileEntity.TryGetAt<TEDisplayDoll>(x, y, out result) || !result.ContainsItems();
  }

  public static bool TryChangePose(int clickX, int clickY)
  {
    int x = clickX;
    int index = clickY;
    if ((int) Main.tile[x, index].frameX % 36 != 0)
      --x;
    int y = index - (int) Main.tile[x, index].frameY / 18;
    TEDisplayDoll result;
    if (!TileEntity.TryGetAt<TEDisplayDoll>(x, y, out result))
      return false;
    result.ChangePose();
    if (Main.netMode == 1)
      NetMessage.SendData(121, number: Main.myPlayer, number2: (float) result.ID, number3: (float) result._pose, number4: 2f);
    return true;
  }

  public void ChangePose()
  {
    ++this._pose;
    if (this.IsValidPose((int) this._pose))
      return;
    this._pose = (byte) 0;
  }

  public bool ContainsItems()
  {
    foreach (Item obj in this._equip)
    {
      if (!obj.IsAir)
        return true;
    }
    foreach (Item dye in this._dyes)
    {
      if (!dye.IsAir)
        return true;
    }
    foreach (Item obj in this._misc)
    {
      if (!obj.IsAir)
        return true;
    }
    return false;
  }

  public void FixLoadedData()
  {
    foreach (Item obj in this._equip)
      obj.FixAgainstExploit();
    foreach (Item dye in this._dyes)
      dye.FixAgainstExploit();
    foreach (Item obj in this._misc)
      obj.FixAgainstExploit();
  }

  public struct DisplayDollPose
  {
    public DisplayDollPoseID Pose;
    public float ItemAnimationPercent;
    public float? ItemAimRadians;
  }
}
