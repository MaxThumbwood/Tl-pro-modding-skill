// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.Secrets
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Text;

#nullable disable
namespace Terraria.Utilities;

public static class Secrets
{
  private static readonly byte[] _salt = Convert.FromBase64String("fT2JQQzNMJl2NRoMbo9RjA==");

  public static string ToSecret(string plainInput)
  {
    byte[] inputBytes = new BCrypt.Net.BCrypt().CryptRaw(Encoding.UTF8.GetBytes(plainInput), Secrets._salt, 4);
    for (int index1 = 0; index1 < 1000; ++index1)
    {
      int index2 = index1 % inputBytes.Length;
      int index3 = (int) inputBytes[index2] % inputBytes.Length;
      Utils.Swap<byte>(ref inputBytes[index2], ref inputBytes[index3]);
    }
    return Convert.ToBase64String(new BCrypt.Net.BCrypt().CryptRaw(inputBytes, Secrets._salt, 4));
  }
}
