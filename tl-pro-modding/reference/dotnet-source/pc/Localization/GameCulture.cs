// Decompiled with JetBrains decompiler
// Type: Terraria.Localization.GameCulture
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

#nullable disable
namespace Terraria.Localization;

public class GameCulture
{
  private static Dictionary<GameCulture.CultureName, GameCulture> _NamedCultures = new Dictionary<GameCulture.CultureName, GameCulture>()
  {
    {
      GameCulture.CultureName.English,
      new GameCulture("en-US", 1)
    },
    {
      GameCulture.CultureName.German,
      new GameCulture("de-DE", 2)
    },
    {
      GameCulture.CultureName.Italian,
      new GameCulture("it-IT", 3)
    },
    {
      GameCulture.CultureName.French,
      new GameCulture("fr-FR", 4)
    },
    {
      GameCulture.CultureName.Spanish,
      new GameCulture("es-ES", 5)
    },
    {
      GameCulture.CultureName.Russian,
      new GameCulture("ru-RU", 6)
    },
    {
      GameCulture.CultureName.Chinese,
      new GameCulture("zh-Hans", 7)
    },
    {
      GameCulture.CultureName.Portuguese,
      new GameCulture("pt-BR", 8)
    },
    {
      GameCulture.CultureName.Polish,
      new GameCulture("pl-PL", 9)
    },
    {
      GameCulture.CultureName.Japanese,
      new GameCulture("ja-JP", 10)
    },
    {
      GameCulture.CultureName.Korean,
      new GameCulture("ko-KR", 11)
    },
    {
      GameCulture.CultureName.ChineseTraditional,
      new GameCulture("zh-Hant", 12)
    }
  };
  private static Dictionary<int, GameCulture> _legacyCultures;
  public readonly CultureInfo CultureInfo;
  public readonly int LegacyId;

  public static GameCulture DefaultCulture { get; set; }

  public bool IsActive => Language.ActiveCulture == this;

  public string Name => this.CultureInfo.Name;

  public static GameCulture FromCultureName(GameCulture.CultureName name)
  {
    return !GameCulture._NamedCultures.ContainsKey(name) ? GameCulture.DefaultCulture : GameCulture._NamedCultures[name];
  }

  public static GameCulture FromLegacyId(int id)
  {
    if (id < 1)
      id = 1;
    return !GameCulture._legacyCultures.ContainsKey(id) ? GameCulture.DefaultCulture : GameCulture._legacyCultures[id];
  }

  public static GameCulture FromName(string name)
  {
    return GameCulture._legacyCultures.Values.SingleOrDefault<GameCulture>((Func<GameCulture, bool>) (culture => culture.Name == name)) ?? GameCulture.DefaultCulture;
  }

  static GameCulture()
  {
    GameCulture.DefaultCulture = GameCulture._NamedCultures[GameCulture.CultureName.English];
  }

  public GameCulture(string name, int legacyId)
  {
    this.CultureInfo = new CultureInfo(name);
    this.LegacyId = legacyId;
    GameCulture.RegisterLegacyCulture(this, legacyId);
  }

  private static void RegisterLegacyCulture(GameCulture culture, int legacyId)
  {
    if (GameCulture._legacyCultures == null)
      GameCulture._legacyCultures = new Dictionary<int, GameCulture>();
    GameCulture._legacyCultures.Add(legacyId, culture);
  }

  public enum CultureName
  {
    English = 1,
    German = 2,
    Italian = 3,
    French = 4,
    Spanish = 5,
    Russian = 6,
    Chinese = 7,
    Portuguese = 8,
    Polish = 9,
    Japanese = 10, // 0x0000000A
    Korean = 11, // 0x0000000B
    ChineseTraditional = 12, // 0x0000000C
    Unknown = 9999, // 0x0000270F
  }
}
