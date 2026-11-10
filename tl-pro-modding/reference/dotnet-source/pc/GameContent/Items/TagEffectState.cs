// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Items.TagEffectState
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.IO;
using Terraria.ID;
using Terraria.Net;

#nullable disable
namespace Terraria.GameContent.Items;

public class TagEffectState
{
  private readonly Player _owner;
  private UniqueTagEffect _effect;
  private readonly int[] TimeLeftOnNPC = new int[Main.maxNPCs];
  private readonly int[] ProcTimeLeftOnNPC = new int[Main.maxNPCs];

  public int Type { get; private set; }

  public TagEffectState(Player owner) => this._owner = owner;

  public bool IsNPCTagged(int npcIndex) => this.TimeLeftOnNPC[npcIndex] > 0;

  public bool CanProcOnNPC(int npcIndex) => this.ProcTimeLeftOnNPC[npcIndex] > 0;

  public void ClearProcOnNPC(int npcIndex)
  {
    this.ProcTimeLeftOnNPC[npcIndex] = 0;
    if (!this._effect.NetSync || this._owner != Main.LocalPlayer)
      return;
    NetManager.Instance.SendToServer(TagEffectState.NetModule.WriteClearProcOnNPC(this, npcIndex));
  }

  public void ResetNPCSlotData(int npcIndex)
  {
    this.TimeLeftOnNPC[npcIndex] = 0;
    this.ProcTimeLeftOnNPC[npcIndex] = 0;
  }

  private void ApplyTagToNPC(NPC npc)
  {
    if (this._effect == null)
      return;
    this.TimeLeftOnNPC[npc.whoAmI] = this._effect.TagDuration;
    if (this._effect.NetSync && this._owner == Main.LocalPlayer)
      NetManager.Instance.SendToServer(TagEffectState.NetModule.WriteApplyTagToNPC(this, npc.whoAmI));
    this._effect.OnTagAppliedToNPC(this._owner, npc);
  }

  private void EnableProcOnNPC(NPC npc)
  {
    if (this._effect == null)
      return;
    this.ProcTimeLeftOnNPC[npc.whoAmI] = this._effect.TagDuration;
    if (!this._effect.NetSync || this._owner != Main.LocalPlayer)
      return;
    NetManager.Instance.SendToServer(TagEffectState.NetModule.WriteEnableProcOnNPC(this, npc.whoAmI));
  }

  public void Update()
  {
    if (this._effect == null)
      return;
    for (int index = 0; index < this.TimeLeftOnNPC.Length; ++index)
    {
      if (this.TimeLeftOnNPC[index] > 0)
        --this.TimeLeftOnNPC[index];
    }
    for (int index = 0; index < this.ProcTimeLeftOnNPC.Length; ++index)
    {
      if (this.ProcTimeLeftOnNPC[index] > 0)
        --this.ProcTimeLeftOnNPC[index];
    }
  }

  private void Clear()
  {
    Array.Clear((Array) this.TimeLeftOnNPC, 0, this.TimeLeftOnNPC.Length);
    Array.Clear((Array) this.ProcTimeLeftOnNPC, 0, this.ProcTimeLeftOnNPC.Length);
  }

  public void TryApplyTagToNPC(int itemType, NPC npc)
  {
    if (!ItemID.Sets.UniqueTagEffects[itemType].CanApplyTagToNPC(npc.type))
      return;
    this.TrySetActiveEffect(itemType);
    this.ApplyTagToNPC(npc);
  }

  public void TryEnableProcOnNPC(int expectedActiveEffectType, NPC npc)
  {
    if (this.Type != expectedActiveEffectType)
      return;
    this.EnableProcOnNPC(npc);
  }

  public void TrySetActiveEffect(int type)
  {
    if (this.Type == type)
      return;
    if (this._effect != null)
      this._effect.OnRemovedFromPlayer(this._owner);
    this.Clear();
    UniqueTagEffect effect = this._effect;
    this.Type = type;
    this._effect = ItemID.Sets.UniqueTagEffects[type];
    if (this._owner == Main.LocalPlayer && (this._effect != null && this._effect.NetSync || effect != null && effect.NetSync))
      NetManager.Instance.SendToServer(TagEffectState.NetModule.WriteChangeActiveEffect(this));
    if (this._effect == null)
      return;
    this._effect.OnSetToPlayer(this._owner);
  }

  public void ModifyHit(
    Projectile optionalProjectile,
    NPC npcHit,
    ref int damageDealt,
    ref bool crit)
  {
    if (this._effect == null || !this.IsNPCTagged(npcHit.whoAmI) || !this._effect.CanRunHitEffects(this._owner, optionalProjectile, npcHit))
      return;
    this._effect.ModifyTaggedHit(this._owner, optionalProjectile, npcHit, ref damageDealt, ref crit);
    if (!this.CanProcOnNPC(npcHit.whoAmI))
      return;
    this._effect.ModifyProcHit(this._owner, optionalProjectile, npcHit, ref damageDealt, ref crit);
  }

  public void OnHit(Projectile optionalProjectile, NPC npcHit, int calcDamage)
  {
    if (this._effect == null || !this.IsNPCTagged(npcHit.whoAmI) || !this._effect.CanRunHitEffects(this._owner, optionalProjectile, npcHit))
      return;
    this._effect.OnTaggedHit(this._owner, optionalProjectile, npcHit, calcDamage);
    if (!this.CanProcOnNPC(npcHit.whoAmI))
      return;
    this.ClearProcOnNPC(npcHit.whoAmI);
    this._effect.OnProcHit(this._owner, optionalProjectile, npcHit, calcDamage);
  }

  public class NetModule : Terraria.Net.NetModule
  {
    public static void WriteSparseNPCTimeArray(BinaryWriter writer, int[] array)
    {
      for (int index = 0; index < array.Length; ++index)
      {
        int num = array[index];
        if (num != 0)
        {
          writer.Write((byte) index);
          writer.Write(num);
        }
      }
      writer.Write((byte) array.Length);
    }

    public static void ReadSparseNPCTimeArray(BinaryReader reader, int[] array)
    {
      Array.Clear((Array) array, 0, array.Length);
      while (true)
      {
        int index = (int) reader.ReadByte();
        if (index < array.Length)
          array[index] = reader.ReadInt32();
        else
          break;
      }
    }

    public static NetPacket WriteFullState(TagEffectState state)
    {
      NetPacket packet = Terraria.Net.NetModule.CreatePacket<TagEffectState.NetModule>();
      packet.Writer.Write((byte) state._owner.whoAmI);
      packet.Writer.Write((byte) 0);
      packet.Writer.Write((short) state.Type);
      TagEffectState.NetModule.WriteSparseNPCTimeArray(packet.Writer, state.TimeLeftOnNPC);
      if (state._effect.SyncProcs)
        TagEffectState.NetModule.WriteSparseNPCTimeArray(packet.Writer, state.ProcTimeLeftOnNPC);
      return packet;
    }

    public static NetPacket WriteChangeActiveEffect(TagEffectState state)
    {
      NetPacket packet = Terraria.Net.NetModule.CreatePacket<TagEffectState.NetModule>();
      packet.Writer.Write((byte) state._owner.whoAmI);
      packet.Writer.Write((byte) 1);
      packet.Writer.Write((short) state.Type);
      return packet;
    }

    private static NetPacket WriteNPCChange(
      TagEffectState state,
      TagEffectState.NetModule.MessageType msgType,
      int npcIndex)
    {
      NetPacket packet = Terraria.Net.NetModule.CreatePacket<TagEffectState.NetModule>();
      packet.Writer.Write((byte) state._owner.whoAmI);
      packet.Writer.Write((byte) msgType);
      packet.Writer.Write((byte) npcIndex);
      return packet;
    }

    public static NetPacket WriteApplyTagToNPC(TagEffectState state, int npcIndex)
    {
      return TagEffectState.NetModule.WriteNPCChange(state, TagEffectState.NetModule.MessageType.ApplyTagToNPC, npcIndex);
    }

    public static NetPacket WriteEnableProcOnNPC(TagEffectState state, int npcIndex)
    {
      return TagEffectState.NetModule.WriteNPCChange(state, TagEffectState.NetModule.MessageType.EnableProcOnNPC, npcIndex);
    }

    public static NetPacket WriteClearProcOnNPC(TagEffectState state, int npcIndex)
    {
      return TagEffectState.NetModule.WriteNPCChange(state, TagEffectState.NetModule.MessageType.ClearProcOnNPC, npcIndex);
    }

    public override bool Deserialize(BinaryReader reader, int userId)
    {
      int ignoreClient = (int) reader.ReadByte();
      if (Main.netMode == 2)
        ignoreClient = userId;
      TagEffectState tagEffectState = Main.player[ignoreClient].TagEffectState;
      TagEffectState.NetModule.MessageType msgType = (TagEffectState.NetModule.MessageType) reader.ReadByte();
      switch (msgType)
      {
        case TagEffectState.NetModule.MessageType.FullState:
          if (Main.netMode == 2)
            return false;
          tagEffectState.TrySetActiveEffect((int) reader.ReadInt16());
          TagEffectState.NetModule.ReadSparseNPCTimeArray(reader, tagEffectState.TimeLeftOnNPC);
          if (tagEffectState._effect.SyncProcs)
          {
            TagEffectState.NetModule.ReadSparseNPCTimeArray(reader, tagEffectState.ProcTimeLeftOnNPC);
            break;
          }
          break;
        case TagEffectState.NetModule.MessageType.ChangeActiveEffect:
          tagEffectState.TrySetActiveEffect((int) reader.ReadInt16());
          if (Main.netMode == 2)
          {
            NetManager.Instance.Broadcast(TagEffectState.NetModule.WriteChangeActiveEffect(tagEffectState), ignoreClient);
            break;
          }
          break;
        case TagEffectState.NetModule.MessageType.ApplyTagToNPC:
        case TagEffectState.NetModule.MessageType.EnableProcOnNPC:
        case TagEffectState.NetModule.MessageType.ClearProcOnNPC:
          int npcIndex = (int) reader.ReadByte();
          if (msgType == TagEffectState.NetModule.MessageType.ApplyTagToNPC)
            tagEffectState.ApplyTagToNPC(Main.npc[npcIndex]);
          else if (msgType == TagEffectState.NetModule.MessageType.EnableProcOnNPC)
            tagEffectState.EnableProcOnNPC(Main.npc[npcIndex]);
          else if (msgType == TagEffectState.NetModule.MessageType.ClearProcOnNPC)
            tagEffectState.ClearProcOnNPC(npcIndex);
          if (Main.netMode == 2)
          {
            NetManager.Instance.Broadcast(TagEffectState.NetModule.WriteNPCChange(tagEffectState, msgType, npcIndex), ignoreClient);
            break;
          }
          break;
      }
      return true;
    }

    public static void SyncStateIfNecessary(TagEffectState state, int toClient, int ignoreClient)
    {
      if (state._effect == null || !state._effect.NetSync)
        return;
      NetPacket packet = TagEffectState.NetModule.WriteFullState(state);
      if (toClient >= 0)
        NetManager.Instance.SendToClient(packet, toClient);
      else
        NetManager.Instance.Broadcast(packet, ignoreClient);
    }

    private enum MessageType
    {
      FullState,
      ChangeActiveEffect,
      ApplyTagToNPC,
      EnableProcOnNPC,
      ClearProcOnNPC,
    }
  }
}
