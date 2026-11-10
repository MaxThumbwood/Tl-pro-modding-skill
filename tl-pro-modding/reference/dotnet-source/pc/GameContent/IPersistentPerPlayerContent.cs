// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.IPersistentPerPlayerContent
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.IO;

#nullable disable
namespace Terraria.GameContent;

public interface IPersistentPerPlayerContent
{
  void Save(Player player, BinaryWriter writer);

  void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn);

  void ApplyLoadedDataToOutOfPlayerFields(Player player);

  void ResetDataForNewPlayer(Player player);

  void Reset();
}
