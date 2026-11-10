// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Creative.CreativeUnlocksTracker
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.IO;

#nullable disable
namespace Terraria.GameContent.Creative;

public class CreativeUnlocksTracker : IPersistentPerWorldContent, IOnPlayerJoining
{
  public ItemsSacrificedUnlocksTracker ItemSacrifices = new ItemsSacrificedUnlocksTracker();

  public void Save(BinaryWriter writer) => this.ItemSacrifices.Save(writer);

  public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
  {
    this.ItemSacrifices.Load(reader, gameVersionSaveWasMadeOn);
  }

  public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
  {
    this.ValidateWorld(reader, gameVersionSaveWasMadeOn);
  }

  public void Reset() => this.ItemSacrifices.Reset();

  public void OnPlayerJoining(int playerIndex) => this.ItemSacrifices.OnPlayerJoining(playerIndex);
}
