// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.LeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public abstract class LeashedCritter : LeashedEntity
{
  protected static NPC _dummy = new NPC();
  public int anchorStyle;
  protected int npcType;
  protected int spriteDirection;
  protected Rectangle frame;
  protected double frameCounter;
  protected LCG32Random rand;
  protected short WaitTime;
  protected byte State;
  protected Point16 TargetPosition;
  protected Vector2 netOffset;
  protected float scale = 1f;
  protected int strayingRangeInBlocks;
  protected bool isAquatic;
  protected static readonly float gravity = 0.3f;
  protected static readonly float maxFallSpeed = 10f;
  protected const int RecallDuration = 20;

  public void SetDefaults(int itemType) => this.SetDefaults(ContentSamples.ItemsByType[itemType]);

  protected virtual void SetDefaults(Item sample)
  {
    this.npcType = (int) sample.makeNPC;
    LeashedCritter._dummy.SetDefaults(this.npcType);
    this.Size = LeashedCritter._dummy.Size;
  }

  public override void NetSend(BinaryWriter writer, bool full)
  {
    if (full)
    {
      writer.Write7BitEncodedInt(this.npcType);
      writer.WriteVector2(this.Size);
    }
    writer.WritePackedVector2(this.position - this.AnchorPosition.ToWorldCoordinates());
    writer.Write(this.direction > 0);
    writer.Write(this.rand.state);
    writer.Write(this.WaitTime);
    writer.Write(this.State);
    writer.Write((sbyte) ((int) this.TargetPosition.X - (int) this.AnchorPosition.X));
    writer.Write((sbyte) ((int) this.TargetPosition.Y - (int) this.AnchorPosition.Y));
  }

  public override void NetReceive(BinaryReader reader, bool full)
  {
    if (full)
    {
      this.npcType = reader.Read7BitEncodedInt();
      this.Size = reader.ReadVector2();
    }
    Vector2 position = this.position;
    this.position = reader.ReadPackedVector2() + this.AnchorPosition.ToWorldCoordinates();
    this.direction = reader.ReadBoolean() ? 1 : -1;
    this.rand.state = reader.ReadUInt32();
    this.WaitTime = reader.ReadInt16();
    this.State = reader.ReadByte();
    this.TargetPosition = new Point16((int) this.AnchorPosition.X + (int) reader.ReadSByte(), (int) this.AnchorPosition.Y + (int) reader.ReadSByte());
    if (full)
      this.netOffset = Vector2.Zero;
    else
      this.netOffset += position - this.position;
    if (!full)
      return;
    this.Update();
  }

  public override void Spawn(bool newlyAdded)
  {
    this.Center = this.AnchorPosition.ToWorldCoordinates();
    this.TargetPosition = this.AnchorPosition;
    this.rand = new LCG32Random((uint) Main.rand.Next());
  }

  public override void Update() => this.netOffset = this.netOffset.MoveTowards(Vector2.Zero, 2f);

  protected void Recall()
  {
    bool flag = Main.netMode != 2;
    if (flag)
    {
      for (int index = 0; index < 10; ++index)
        Dust.NewDustDirect(this.position, this.width, this.height, 15, Alpha: 150, Scale: 1.1f);
    }
    this.Center = this.AnchorPosition.ToWorldCoordinates() - new Vector2(0.0f, 16f);
    this.velocity = Vector2.Zero;
    if (!flag)
      return;
    for (int index = 0; index < 10; ++index)
      Dust.NewDustDirect(this.position, this.width, this.height, 15, Alpha: 150, Scale: 1.1f);
  }

  protected virtual void VisualEffects()
  {
    if (this.npcType < 0 || !NPCID.Sets.IsGoldCritter[this.npcType])
      return;
    this.position = this.position + this.netOffset;
    Color color = Lighting.GetColor((int) this.Center.X / 16 /*0x10*/, (int) this.Center.Y / 16 /*0x10*/);
    if (color.R > (byte) 20 || color.B > (byte) 20 || color.G > (byte) 20)
    {
      int num1 = (int) color.R;
      if ((int) color.G > num1)
        num1 = (int) color.G;
      if ((int) color.B > num1)
        num1 = (int) color.B;
      int num2 = num1 / 30;
      if (Main.rand.Next(300) < num2)
      {
        int index = Dust.NewDust(this.position, this.width, this.height, 43, Alpha: 254, newColor: new Color((int) byte.MaxValue, (int) byte.MaxValue, 0), Scale: 0.5f);
        Main.dust[index].velocity *= 0.0f;
      }
    }
    this.position = this.position - this.netOffset;
  }

  protected virtual void CopyToDummy()
  {
    LeashedCritter._dummy.type = this.npcType;
    LeashedCritter._dummy.Size = this.Size;
    LeashedCritter._dummy.frame = this.frame;
    LeashedCritter._dummy.frameCounter = this.frameCounter;
    LeashedCritter._dummy.position = this.Center + new Vector2(0.0f, 8f) - new Vector2(this.Size.X / 2f, this.Size.Y);
    LeashedCritter._dummy.velocity = this.velocity;
    LeashedCritter._dummy.direction = this.direction;
    LeashedCritter._dummy.spriteDirection = this.spriteDirection;
    LeashedCritter._dummy.scale = this.scale;
    LeashedCritter._dummy.rotation = 0.0f;
    LeashedCritter._dummy.alpha = 0;
    LeashedCritter._dummy.wet = false;
    Array.Clear((Array) LeashedCritter._dummy.ai, 0, LeashedCritter._dummy.ai.Length);
    Array.Clear((Array) LeashedCritter._dummy.localAI, 0, LeashedCritter._dummy.localAI.Length);
  }

  protected void CopyFromDummy()
  {
    this.frame = LeashedCritter._dummy.frame;
    this.frameCounter = LeashedCritter._dummy.frameCounter;
    this.spriteDirection = LeashedCritter._dummy.spriteDirection;
  }

  public override void Draw()
  {
    Main.instance.LoadNPC(this.npcType);
    if (this.frame.Width == 0 || this.frame.Height == 0)
      this.frame = new Rectangle(0, 0, TextureAssets.Npc[this.npcType].Width(), TextureAssets.Npc[this.npcType].Height() / Main.npcFrameCount[this.npcType]);
    this.CopyToDummy();
    NPC dummy = LeashedCritter._dummy;
    dummy.position = dummy.position + (this.netOffset + this.GetDrawOffset());
    Main.instance.DrawNPCDirect(Main.spriteBatch, LeashedCritter._dummy, true, Main.screenPosition);
    Point tileCoordinates = LeashedCritter._dummy.Center.ToTileCoordinates();
    byte liquid = Framing.GetTileSafely(tileCoordinates.X, tileCoordinates.Y).liquid;
    if ((!this.isAquatic || liquid >= byte.MaxValue) && (this.isAquatic || liquid <= (byte) 0))
      return;
    this.DrawBubble();
  }

  public virtual Vector2 GetDrawOffset() => Vector2.Zero;

  protected void DrawBubble()
  {
    Main.instance.LoadGore(413);
    Texture2D texture2D = TextureAssets.Gore[413].Value;
    Rectangle r = texture2D.Frame();
    Vector2 origin = r.Size() / 2f;
    Vector2 vec = this.position + (this.netOffset + this.GetDrawOffset() + LeashedCritter._dummy.Size * new Vector2(0.5f, 0.5f));
    Point tileCoordinates = vec.ToTileCoordinates();
    Main.spriteBatch.Draw(texture2D, vec - Main.screenPosition, new Rectangle?(r), Lighting.GetColor(tileCoordinates), 0.0f, origin, 1f, SpriteEffects.None, 0.0f);
  }
}
