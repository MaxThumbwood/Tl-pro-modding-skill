// Decompiled with JetBrains decompiler
// Type: Terraria.Social.WeGame.FriendsSocialModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using rail;

#nullable disable
namespace Terraria.Social.WeGame;

public class FriendsSocialModule : Terraria.Social.Base.FriendsSocialModule
{
  public override void Initialize()
  {
  }

  public override void Shutdown()
  {
  }

  public override string GetUsername()
  {
    string username;
    rail_api.RailFactory().RailPlayer().GetPlayerName(ref username);
    WeGameHelper.WriteDebugString("GetUsername by wegame" + username);
    return username;
  }

  public override void OpenJoinInterface()
  {
    WeGameHelper.WriteDebugString("OpenJoinInterface by wegame");
    rail_api.RailFactory().RailFloatingWindow().AsyncShowRailFloatingWindow((EnumRailWindowType) 10, "");
  }
}
