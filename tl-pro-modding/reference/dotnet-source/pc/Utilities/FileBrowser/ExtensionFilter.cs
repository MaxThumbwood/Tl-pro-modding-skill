// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.FileBrowser.ExtensionFilter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Utilities.FileBrowser;

public struct ExtensionFilter(string filterName, params string[] filterExtensions)
{
  public string Name = filterName;
  public string[] Extensions = filterExtensions;
}
