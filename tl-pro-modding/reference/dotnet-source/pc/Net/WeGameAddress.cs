// Decompiled with JetBrains decompiler
// Type: Terraria.Net.WeGameAddress
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using rail;

#nullable disable
namespace Terraria.Net;

public class WeGameAddress : RemoteAddress
{
  public readonly RailID rail_id;
  private string nickname;

  public WeGameAddress(RailID id, string name)
  {
    this.Type = AddressType.WeGame;
    this.rail_id = id;
    this.nickname = name;
  }

  public override string ToString()
  {
    return "WEGAME_0:" + ((RailComparableID) this.rail_id).id_.ToString();
  }

  public override string GetIdentifier() => this.ToString();

  public override bool IsLocalHost()
  {
    return Program.LaunchParameters.ContainsKey("-localwegameid") && Program.LaunchParameters["-localwegameid"].Equals(((RailComparableID) this.rail_id).id_.ToString());
  }

  public override string GetFriendlyName() => this.nickname;
}
