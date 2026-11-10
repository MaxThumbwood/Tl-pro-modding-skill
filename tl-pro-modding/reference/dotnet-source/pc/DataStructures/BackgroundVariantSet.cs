// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.BackgroundVariantSet
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public class BackgroundVariantSet
{
  public BackgroundVariant Pure = new BackgroundVariant();
  public BackgroundVariant Corrupt = new BackgroundVariant();
  public BackgroundVariant Crimson = new BackgroundVariant();
  public BackgroundVariant Hallow = new BackgroundVariant();

  public void Clear()
  {
    this.Pure.Clear();
    this.Corrupt.Clear();
    this.Crimson.Clear();
    this.Hallow.Clear();
  }
}
