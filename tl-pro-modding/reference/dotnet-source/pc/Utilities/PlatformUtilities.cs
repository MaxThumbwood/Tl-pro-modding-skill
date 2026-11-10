// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.PlatformUtilities
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;

#nullable disable
namespace Terraria.Utilities;

public static class PlatformUtilities
{
  public static void SavePng(string path, int width, int height, byte[] data)
  {
    throw new NotSupportedException("Use Bitmap to save png images on windows");
  }
}
