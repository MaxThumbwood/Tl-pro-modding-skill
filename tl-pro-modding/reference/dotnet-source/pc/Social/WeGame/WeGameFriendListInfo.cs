// Decompiled with JetBrains decompiler
// Type: Terraria.Social.WeGame.WeGameFriendListInfo
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using rail;
using System.Collections.Generic;
using System.Runtime.Serialization;

#nullable disable
namespace Terraria.Social.WeGame;

[DataContract]
public class WeGameFriendListInfo
{
  [DataMember]
  public List<RailFriendInfo> _friendList;
}
