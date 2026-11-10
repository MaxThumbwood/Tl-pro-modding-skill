// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.NPCFollowState
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.IO;

#nullable disable
namespace Terraria.DataStructures;

public class NPCFollowState
{
  private NPC _npc;
  private int? _playerIndexBeingFollowed;
  private Vector2 _floorBreadcrumb;

  public Vector2 BreadcrumbPosition => this._floorBreadcrumb;

  public bool IsFollowingPlayer => this._playerIndexBeingFollowed.HasValue;

  public Player PlayerBeingFollowed
  {
    get
    {
      return this._playerIndexBeingFollowed.HasValue ? Main.player[this._playerIndexBeingFollowed.Value] : (Player) null;
    }
  }

  public void FollowPlayer(int playerIndex)
  {
    this._playerIndexBeingFollowed = new int?(playerIndex);
    this._floorBreadcrumb = Main.player[playerIndex].Bottom;
    this._npc.netUpdate = true;
  }

  public void StopFollowing()
  {
    this._playerIndexBeingFollowed = new int?();
    this.MoveNPCBackHome();
    this._npc.netUpdate = true;
  }

  public void Clear(NPC npcToBelongTo)
  {
    this._npc = npcToBelongTo;
    this._playerIndexBeingFollowed = new int?();
    this._floorBreadcrumb = new Vector2();
  }

  private bool ShouldSync() => this._npc.isLikeATownNPC;

  public void WriteTo(BinaryWriter writer)
  {
    int num = this._playerIndexBeingFollowed.HasValue ? this._playerIndexBeingFollowed.Value : -1;
    writer.Write((short) num);
  }

  public void ReadFrom(BinaryReader reader)
  {
    short index = reader.ReadInt16();
    if (!Main.player.IndexInRange<Player>((int) index))
      return;
    this._playerIndexBeingFollowed = new int?((int) index);
  }

  private void MoveNPCBackHome()
  {
    this._npc.ai[0] = 20f;
    this._npc.ai[1] = 0.0f;
    this._npc.ai[2] = 0.0f;
    this._npc.ai[3] = 0.0f;
    this._npc.netUpdate = true;
  }

  public void Update()
  {
    if (!this.IsFollowingPlayer)
      return;
    Player playerBeingFollowed = this.PlayerBeingFollowed;
    if (!playerBeingFollowed.active || playerBeingFollowed.dead)
    {
      this.StopFollowing();
    }
    else
    {
      this.UpdateBreadcrumbs(playerBeingFollowed);
      Dust.QuickDust(this._floorBreadcrumb, Color.Red);
    }
  }

  private void UpdateBreadcrumbs(Player player)
  {
    Vector2? nullable = new Vector2?();
    if ((double) player.velocity.Y == 0.0 && (double) player.gravDir == 1.0)
      nullable = new Vector2?(player.Bottom);
    int num = 8;
    if (!nullable.HasValue || (double) Vector2.Distance(nullable.Value, this._floorBreadcrumb) < (double) num)
      return;
    this._floorBreadcrumb = nullable.Value;
    this._npc.netUpdate = true;
  }
}
