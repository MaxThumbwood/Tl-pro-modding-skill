// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.EasyDeserializationJsonContractResolver
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.ComponentModel;
using System.Reflection;

#nullable disable
namespace Terraria.Utilities;

public class EasyDeserializationJsonContractResolver : DefaultContractResolver
{
  protected virtual JsonContract CreateContract(Type objectType)
  {
    JsonContract contract = base.CreateContract(objectType);
    if (contract is JsonStringContract && objectType != typeof (string))
    {
      TypeConverter converter = TypeDescriptor.GetConverter(objectType);
      if (converter != null && converter.CanConvertTo(typeof (string)) && !converter.CanConvertFrom(typeof (string)))
        contract = (JsonContract) this.CreateObjectContract(objectType);
    }
    if (objectType.IsArray || objectType.IsValueType)
      contract.IsReference = new bool?(false);
    return contract;
  }

  protected virtual JsonProperty CreateProperty(
    MemberInfo member,
    MemberSerialization memberSerialization)
  {
    JsonProperty property = base.CreateProperty(member, memberSerialization);
    if (!property.Writable)
      property.Ignored = true;
    return property;
  }
}
