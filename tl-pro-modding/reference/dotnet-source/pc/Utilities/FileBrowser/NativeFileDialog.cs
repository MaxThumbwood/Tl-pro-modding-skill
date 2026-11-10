// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.FileBrowser.NativeFileDialog
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Terraria.Utilities.FileBrowser;

public class NativeFileDialog : IFileBrowser
{
  public string OpenFilePanel(string title, ExtensionFilter[] extensions)
  {
    string outPath;
    return nativefiledialog.NFD_OpenDialog(string.Join(",", ((IEnumerable<ExtensionFilter>) extensions).SelectMany<ExtensionFilter, string>((Func<ExtensionFilter, IEnumerable<string>>) (x => (IEnumerable<string>) x.Extensions)).ToArray<string>()), (string) null, out outPath) == nativefiledialog.nfdresult_t.NFD_OKAY ? outPath : (string) null;
  }
}
