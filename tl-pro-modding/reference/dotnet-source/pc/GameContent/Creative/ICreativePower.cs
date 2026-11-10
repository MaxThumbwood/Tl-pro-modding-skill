// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Creative.ICreativePower
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using System.IO;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.Creative;

public interface ICreativePower
{
  ushort PowerId { get; set; }

  string ServerConfigName { get; set; }

  PowerPermissionLevel CurrentPermissionLevel { get; set; }

  PowerPermissionLevel DefaultPermissionLevel { get; set; }

  void DeserializeNetMessage(BinaryReader reader, int userId);

  void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements);

  bool GetIsUnlocked();
}
