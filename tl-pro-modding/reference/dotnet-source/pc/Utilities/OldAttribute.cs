// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.OldAttribute
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;

#nullable disable
namespace Terraria.Utilities;

public sealed class OldAttribute : Attribute
{
  private string message;

  public OldAttribute() => this.message = "";

  public OldAttribute(string message) => this.message = message;

  public string Message => this.message;
}
