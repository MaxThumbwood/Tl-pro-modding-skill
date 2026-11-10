// Decompiled with JetBrains decompiler
// Type: Terraria.Social.Base.FriendsSocialModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Social.Base;

public abstract class FriendsSocialModule : ISocialModule
{
  public abstract string GetUsername();

  public abstract void OpenJoinInterface();

  public abstract void Initialize();

  public abstract void Shutdown();
}
