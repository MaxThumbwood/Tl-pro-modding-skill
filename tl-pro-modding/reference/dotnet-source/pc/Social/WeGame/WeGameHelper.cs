// Decompiled with JetBrains decompiler
// Type: Terraria.Social.WeGame.WeGameHelper
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Text;

#nullable disable
namespace Terraria.Social.WeGame;

public class WeGameHelper
{
  [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
  private static extern void OutputDebugString(string message);

  public static void WriteDebugString(string format, params object[] args)
  {
    string str = "[WeGame] - " + format;
  }

  public static string Serialize<T>(T data)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      new DataContractJsonSerializer(typeof (T)).WriteObject((Stream) memoryStream, (object) data);
      memoryStream.Position = 0L;
      using (StreamReader streamReader = new StreamReader((Stream) memoryStream, Encoding.UTF8))
        return streamReader.ReadToEnd();
    }
  }

  public static void UnSerialize<T>(string str, out T data)
  {
    using (MemoryStream memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(str)))
    {
      DataContractJsonSerializer contractJsonSerializer = new DataContractJsonSerializer(typeof (T));
      data = (T) contractJsonSerializer.ReadObject((Stream) memoryStream);
    }
  }
}
