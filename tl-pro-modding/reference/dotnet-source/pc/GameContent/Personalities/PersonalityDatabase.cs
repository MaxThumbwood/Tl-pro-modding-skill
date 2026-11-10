// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Personalities.PersonalityDatabase
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.Personalities;

public class PersonalityDatabase
{
  private Dictionary<int, PersonalityProfile> _personalityProfiles;
  private PersonalityProfile _trashEntry = new PersonalityProfile();

  public PersonalityDatabase()
  {
    this._personalityProfiles = new Dictionary<int, PersonalityProfile>();
  }

  public void Register(int npcId, IShopPersonalityTrait trait)
  {
    if (!this._personalityProfiles.ContainsKey(npcId))
      this._personalityProfiles[npcId] = new PersonalityProfile();
    this._personalityProfiles[npcId].ShopModifiers.Add(trait);
  }

  public void Register(IShopPersonalityTrait trait, params int[] npcIds)
  {
    for (int index = 0; index < npcIds.Length; ++index)
      this.Register(trait, npcIds[index]);
  }

  public PersonalityProfile GetByNPCID(int npcId)
  {
    PersonalityProfile personalityProfile;
    return this._personalityProfiles.TryGetValue(npcId, out personalityProfile) ? personalityProfile : this._trashEntry;
  }
}
