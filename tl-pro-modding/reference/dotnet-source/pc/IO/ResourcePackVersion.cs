// Decompiled with JetBrains decompiler
// Type: Terraria.IO.ResourcePackVersion
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Newtonsoft.Json;
using System;
using System.Diagnostics;

#nullable disable
namespace Terraria.IO;

[DebuggerDisplay("Version {Major}.{Minor}")]
public struct ResourcePackVersion : IComparable, IComparable<ResourcePackVersion>
{
  [JsonProperty("major")]
  public int Major { get; private set; }

  [JsonProperty("minor")]
  public int Minor { get; private set; }

  public static ResourcePackVersion Create(int major, int minor)
  {
    return new ResourcePackVersion()
    {
      Major = major,
      Minor = minor
    };
  }

  public int CompareTo(object obj)
  {
    if (obj == null)
      return 1;
    if (!(obj is ResourcePackVersion other))
      throw new ArgumentException("A RatingInformation object is required for comparison.", nameof (obj));
    return this.CompareTo(other);
  }

  public int CompareTo(ResourcePackVersion other)
  {
    int num = this.Major.CompareTo(other.Major);
    return num != 0 ? num : this.Minor.CompareTo(other.Minor);
  }

  public static bool operator ==(ResourcePackVersion lhs, ResourcePackVersion rhs)
  {
    return lhs.CompareTo(rhs) == 0;
  }

  public static bool operator !=(ResourcePackVersion lhs, ResourcePackVersion rhs) => !(lhs == rhs);

  public static bool operator <(ResourcePackVersion lhs, ResourcePackVersion rhs)
  {
    return lhs.CompareTo(rhs) < 0;
  }

  public static bool operator >(ResourcePackVersion lhs, ResourcePackVersion rhs)
  {
    return lhs.CompareTo(rhs) > 0;
  }

  public override bool Equals(object obj)
  {
    return obj is ResourcePackVersion other && this.CompareTo(other) == 0;
  }

  public override int GetHashCode()
  {
    return ((long) this.Major << 32 /*0x20*/ | (long) this.Minor).GetHashCode();
  }

  public string GetFormattedVersion() => $"{(object) this.Major}.{(object) this.Minor}";
}
