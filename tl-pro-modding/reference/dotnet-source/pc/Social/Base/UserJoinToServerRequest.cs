// Decompiled with JetBrains decompiler
// Type: Terraria.Social.Base.UserJoinToServerRequest
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;

#nullable disable
namespace Terraria.Social.Base;

public abstract class UserJoinToServerRequest
{
  internal string UserDisplayName { get; private set; }

  internal string UserFullIdentifier { get; private set; }

  public event Action OnAccepted;

  public event Action OnRejected;

  public UserJoinToServerRequest(string userDisplayName, string fullIdentifier)
  {
    this.UserDisplayName = userDisplayName;
    this.UserFullIdentifier = fullIdentifier;
  }

  public void Accept()
  {
    if (this.OnAccepted == null)
      return;
    this.OnAccepted();
  }

  public void Reject()
  {
    if (this.OnRejected == null)
      return;
    this.OnRejected();
  }

  public abstract bool IsValid();

  public abstract string GetUserWrapperText();
}
