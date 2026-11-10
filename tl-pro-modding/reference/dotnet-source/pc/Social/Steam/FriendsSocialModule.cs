// Decompiled with JetBrains decompiler
// Type: Terraria.Social.Steam.FriendsSocialModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Steamworks;

#nullable disable
namespace Terraria.Social.Steam;

public class FriendsSocialModule : Terraria.Social.Base.FriendsSocialModule
{
  public override void Initialize()
  {
  }

  public override void Shutdown()
  {
  }

  public override string GetUsername() => SteamFriends.GetPersonaName();

  public override void OpenJoinInterface() => SteamFriends.ActivateGameOverlay("Friends");
}
