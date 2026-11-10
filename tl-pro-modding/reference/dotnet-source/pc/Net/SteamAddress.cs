// Decompiled with JetBrains decompiler
// Type: Terraria.Net.SteamAddress
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Steamworks;

#nullable disable
namespace Terraria.Net;

public class SteamAddress : RemoteAddress
{
  public readonly CSteamID SteamId;
  private string _friendlyName;

  public SteamAddress(CSteamID steamId)
  {
    this.Type = AddressType.Steam;
    this.SteamId = steamId;
  }

  public override string ToString()
  {
    return $"STEAM_0:{(this.SteamId.m_SteamID % 2UL).ToString()}:{((this.SteamId.m_SteamID - (76561197960265728UL /*0x0110000100000000*/ + this.SteamId.m_SteamID % 2UL)) / 2UL).ToString()}";
  }

  public override string GetIdentifier() => this.ToString();

  public override bool IsLocalHost()
  {
    return Program.LaunchParameters.ContainsKey("-localsteamid") && Program.LaunchParameters["-localsteamid"].Equals(this.SteamId.m_SteamID.ToString());
  }

  public override string GetFriendlyName()
  {
    if (this._friendlyName == null)
      this._friendlyName = SteamFriends.GetFriendPersonaName(this.SteamId);
    return this._friendlyName;
  }
}
