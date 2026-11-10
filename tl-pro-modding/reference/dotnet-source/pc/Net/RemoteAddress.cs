// Decompiled with JetBrains decompiler
// Type: Terraria.Net.RemoteAddress
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Net;

public abstract class RemoteAddress
{
  public AddressType Type;

  public abstract string GetIdentifier();

  public abstract string GetFriendlyName();

  public abstract bool IsLocalHost();
}
