// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.FileBrowser.FileBrowser
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Utilities.FileBrowser;

public class FileBrowser
{
  private static IFileBrowser _platformWrapper = (IFileBrowser) new NativeFileDialog();

  public static string OpenFilePanel(string title, string extension)
  {
    ExtensionFilter[] extensionFilterArray;
    if (!string.IsNullOrEmpty(extension))
      extensionFilterArray = new ExtensionFilter[1]
      {
        new ExtensionFilter("", new string[1]{ extension })
      };
    else
      extensionFilterArray = (ExtensionFilter[]) null;
    ExtensionFilter[] extensions = extensionFilterArray;
    return Terraria.Utilities.FileBrowser.FileBrowser.OpenFilePanel(title, extensions);
  }

  public static string OpenFilePanel(string title, ExtensionFilter[] extensions)
  {
    return Terraria.Utilities.FileBrowser.FileBrowser._platformWrapper.OpenFilePanel(title, extensions);
  }
}
