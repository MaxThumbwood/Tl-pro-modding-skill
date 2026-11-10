// Decompiled with JetBrains decompiler
// Type: Terraria.IO.WorldFileData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.IO;

public class WorldFileData : FileData
{
  private const ulong GUID_IN_WORLD_FILE_VERSION = 777389080577 /*0xB500000001*/;
  public static readonly int MAX_USER_SEED_TEXT_LENGTH = 40;
  public DateTime CreationTime;
  public DateTime LastPlayed;
  public int WorldSizeX;
  public int WorldSizeY;
  public ulong WorldGeneratorVersion;
  private string _seedText = "";
  private int _seed;
  public int LoadStatus = StatusID.Ok;
  public Exception LoadException;
  public Guid UniqueId;
  public int WorldId;
  public LocalizedText _worldSizeName;
  public int GameMode;
  public bool DrunkWorld;
  public bool NotTheBees;
  public bool ForTheWorthy;
  public bool Anniversary;
  public bool DontStarve;
  public bool RemixWorld;
  public bool NoTrapsWorld;
  public bool ZenithWorld;
  public bool SkyblockWorld;
  public bool HasCorruption = true;
  public bool IsHardMode;
  public bool DefeatedMoonlord;
  private static List<AWorldGenerationOption> seedOptionsInOrder = new List<AWorldGenerationOption>()
  {
    (AWorldGenerationOption) WorldGenerationOptions.Get<WorldSeedOption_Drunk>(),
    (AWorldGenerationOption) WorldGenerationOptions.Get<WorldSeedOption_NotTheBees>(),
    (AWorldGenerationOption) WorldGenerationOptions.Get<WorldSeedOption_ForTheWorthy>(),
    (AWorldGenerationOption) WorldGenerationOptions.Get<WorldSeedOption_Anniversary>(),
    (AWorldGenerationOption) WorldGenerationOptions.Get<WorldSeedOption_DontStarve>(),
    (AWorldGenerationOption) WorldGenerationOptions.Get<WorldSeedOption_Remix>(),
    (AWorldGenerationOption) WorldGenerationOptions.Get<WorldSeedOption_NoTraps>(),
    (AWorldGenerationOption) WorldGenerationOptions.Get<WorldSeedOption_Everything>(),
    (AWorldGenerationOption) WorldGenerationOptions.Get<WorldSeedOption_Skyblock>()
  };

  public string SeedText => this._seedText;

  public int Seed => this._seed;

  public bool IsValid => this.LoadStatus == StatusID.Ok;

  public string WorldSizeName => this._worldSizeName.Value;

  public bool HasCrimson
  {
    get => !this.HasCorruption;
    set => this.HasCorruption = !value;
  }

  public bool HasValidSeed => this.WorldGeneratorVersion > 0UL;

  public bool UseGuidAsMapName => this.WorldGeneratorVersion >= 777389080577UL /*0xB500000001*/;

  public string MapFileName
  {
    get => !this.UseGuidAsMapName ? this.WorldId.ToString() : this.UniqueId.ToString();
  }

  public string GetWorldName(bool allowCropping = false)
  {
    string worldName = this.Name;
    if (worldName == null || !allowCropping)
      return worldName;
    int num = 494;
    worldName = FontAssets.MouseText.Value.CreateCroppedText(worldName, (float) num);
    return worldName;
  }

  public string GetFullSeedText(bool allowCropping = false)
  {
    int num1 = 0;
    if (this.WorldSizeX == 4200 && this.WorldSizeY == 1200)
      num1 = 1;
    if (this.WorldSizeX == 6400 && this.WorldSizeY == 1800)
      num1 = 2;
    if (this.WorldSizeX == 8400 && this.WorldSizeY == 2400)
      num1 = 3;
    int num2 = 0;
    if (this.HasCorruption)
      num2 = 1;
    if (this.HasCrimson)
      num2 = 2;
    int num3 = this.GameMode + 1;
    string str = this._seedText;
    if (allowCropping)
    {
      int num4 = 340;
      str = FontAssets.MouseText.Value.CreateCroppedText(str, (float) num4);
    }
    int serializedSeedsSum = this.GetSerializedSeedsSum();
    return $"{num1}.{num3}.{num2}.{serializedSeedsSum}.{str}";
  }

  public int GetSerializedSeedsSum()
  {
    int serializedSeedsSum = 0;
    if (this.DrunkWorld)
      ++serializedSeedsSum;
    if (this.NotTheBees)
      serializedSeedsSum += 2;
    if (this.ForTheWorthy)
      serializedSeedsSum += 4;
    if (this.Anniversary)
      serializedSeedsSum += 8;
    if (this.DontStarve)
      serializedSeedsSum += 16 /*0x10*/;
    if (this.RemixWorld)
      serializedSeedsSum += 32 /*0x20*/;
    if (this.NoTrapsWorld)
      serializedSeedsSum += 64 /*0x40*/;
    if (this.ZenithWorld)
      serializedSeedsSum += 128 /*0x80*/;
    if (this.SkyblockWorld)
      serializedSeedsSum += 256 /*0x0100*/;
    return serializedSeedsSum;
  }

  public List<string> GetSecretSeedCodes()
  {
    if (string.IsNullOrWhiteSpace(this._seedText))
      return new List<string>();
    return ((IEnumerable<string>) this._seedText.Split('|')).ToList<string>();
  }

  private static void EnableSeedOptions(int serializedSeedSum)
  {
    for (int index = 0; index < WorldFileData.seedOptionsInOrder.Count; ++index)
    {
      if ((serializedSeedSum >> index & 1) == 1)
        WorldFileData.seedOptionsInOrder[index].Enabled = true;
    }
  }

  public static bool TryApplyingCopiedSeed(
    string input,
    bool playSound,
    out string processedSeed,
    out string seedTextIncludingSecrets,
    out List<string> secretSeedTexts)
  {
    processedSeed = input;
    seedTextIncludingSecrets = input;
    secretSeedTexts = (List<string>) null;
    int num1;
    int num2;
    int num3;
    if (string.IsNullOrWhiteSpace(input) || !WorldFileData.TryParseSeedOptionValue(ref processedSeed, out num1) || !WorldFileData.TryParseSeedOptionValue(ref processedSeed, out num2) || !WorldFileData.TryParseSeedOptionValue(ref processedSeed, out num3) || num1 <= 0 || num1 > 3 || num2 <= 0 || num2 > 4 || num3 <= 0 || num3 > 2)
      return false;
    int serializedSeedSum;
    if (!WorldFileData.TryParseSeedOptionValue(ref processedSeed, out serializedSeedSum))
      serializedSeedSum = 0;
    seedTextIncludingSecrets = processedSeed;
    secretSeedTexts = new List<string>();
    List<WorldGen.SecretSeed> secretSeedList = new List<WorldGen.SecretSeed>();
    string secretSeedText;
    WorldGen.SecretSeed secretSeed;
    while (WorldFileData.TryParseSecretSeed(ref processedSeed, out secretSeedText, out secretSeed))
    {
      secretSeedTexts.Add(secretSeedText);
      secretSeedList.Add(secretSeed);
    }
    if (processedSeed.Length > WorldFileData.MAX_USER_SEED_TEXT_LENGTH)
      return false;
    WorldGen.SetWorldSize(num1 - 1);
    Main.GameMode = num2 - 1;
    WorldGen.WorldGenParam_Evil = num3 - 1;
    WorldGenerationOptions.Reset();
    WorldFileData.EnableSeedOptions(serializedSeedSum);
    WorldGen.SecretSeed.ClearAllSeeds();
    foreach (WorldGen.SecretSeed seed in secretSeedList)
    {
      WorldGen.SecretSeed.Enable(seed, playSound);
      playSound = false;
    }
    return true;
  }

  private static bool TryParseSeedOptionValue(ref string processedSeed, out int value)
  {
    int length = processedSeed.IndexOf('.');
    if (length < 0)
    {
      value = 0;
      return false;
    }
    if (!int.TryParse(processedSeed.Substring(0, length), out value))
      return false;
    processedSeed = processedSeed.Substring(length + 1);
    return true;
  }

  private static bool TryParseSecretSeed(
    ref string processedSeed,
    out string secretSeedText,
    out WorldGen.SecretSeed secretSeed)
  {
    int length = processedSeed.IndexOf('|');
    if (length < 0)
    {
      secretSeedText = (string) null;
      secretSeed = (WorldGen.SecretSeed) null;
      return false;
    }
    secretSeedText = processedSeed.Substring(0, length);
    if (!WorldGen.SecretSeed.CheckInputForSecretSeed(secretSeedText, out secretSeed))
      return false;
    processedSeed = processedSeed.Substring(length + 1);
    return true;
  }

  public WorldFileData()
    : base("World")
  {
  }

  public WorldFileData(string path, bool cloudSave)
    : base("World", path, cloudSave)
  {
  }

  public override void SetAsActive()
  {
    if (this.LoadException != null)
      throw this.LoadException;
    Main.ActiveWorldFileData = this;
  }

  public void SetWorldSize(int x, int y)
  {
    this.WorldSizeX = x;
    this.WorldSizeY = y;
    switch (x)
    {
      case 4200:
        this._worldSizeName = Language.GetText("UI.WorldSizeSmall");
        break;
      case 6400:
        this._worldSizeName = Language.GetText("UI.WorldSizeMedium");
        break;
      case 8400:
        this._worldSizeName = Language.GetText("UI.WorldSizeLarge");
        break;
      default:
        this._worldSizeName = Language.GetText("UI.WorldSizeUnknown");
        break;
    }
  }

  public static WorldFileData FromInvalidWorld(
    string path,
    bool cloudSave,
    int statusCode,
    Exception exception)
  {
    WorldFileData worldFileData = new WorldFileData(path, cloudSave);
    worldFileData.GameMode = 0;
    worldFileData.SetSeedToEmpty();
    worldFileData.WorldGeneratorVersion = 0UL;
    worldFileData.Metadata = FileMetadata.FromCurrentSettings(FileType.World);
    worldFileData.SetWorldSize(1, 1);
    worldFileData.HasCorruption = true;
    worldFileData.IsHardMode = false;
    worldFileData.LoadStatus = statusCode;
    worldFileData.LoadException = exception;
    worldFileData.Name = FileUtilities.GetFileName(path, false);
    worldFileData.UniqueId = Guid.Empty;
    worldFileData.CreationTime = cloudSave ? DateTime.Now : File.GetCreationTime(path);
    return worldFileData;
  }

  public void SetSeedToEmpty() => this.SetSeed("");

  public void SetSeed(string seedText)
  {
    this._seedText = seedText;
    this._seed = WorldFileData.TranslateSeed(seedText);
  }

  public static int TranslateSeed(string seedText)
  {
    int result;
    if (!int.TryParse(seedText, out result))
      return Crc32.Calculate(seedText);
    return result != int.MinValue ? Math.Abs(result) : int.MaxValue;
  }

  public void SetSeedToRandom() => this.SetSeed(new UnifiedRandom().Next().ToString());

  public void SetSeedToRandomWithCurrentEvents()
  {
    this.SetSeedToRandom();
    if (!Main.isHalloweenDateNow())
      return;
    WorldGen.SecretSeed.Enable(WorldGen.SecretSeed.halloweenGen, false);
    this.SetSeed("pumpkinseason|" + this.SeedText);
  }

  public override void MoveToCloud()
  {
    if (this.IsCloudSave)
      return;
    string worldPathFromName = Main.GetWorldPathFromName(this.Name, true);
    if (!FileUtilities.MoveToCloud(this.Path, worldPathFromName))
      return;
    Main.LocalFavoriteData.ClearEntry((FileData) this);
    this._isCloudSave = true;
    this._path = worldPathFromName;
    Main.CloudFavoritesData.SaveFavorite((FileData) this);
  }

  public override void MoveToLocal()
  {
    if (!this.IsCloudSave)
      return;
    string worldPathFromName = Main.GetWorldPathFromName(this.Name, false);
    if (!FileUtilities.MoveToLocal(this.Path, worldPathFromName))
      return;
    Main.CloudFavoritesData.ClearEntry((FileData) this);
    this._isCloudSave = false;
    this._path = worldPathFromName;
    Main.LocalFavoriteData.SaveFavorite((FileData) this);
  }

  public void Rename(string newDisplayName)
  {
    if (newDisplayName == null)
      return;
    WorldGen.RenameWorld(this, newDisplayName, this.GetRenameCallback((Action) (() => Main.menuMode = 6)));
  }

  public void CopyToLocal(string newDisplayName, Action onCompleted)
  {
    if (this.IsCloudSave)
      return;
    string worldPathFromName = Main.GetWorldPathFromName(Guid.NewGuid().ToString(), false);
    FileUtilities.Copy(this.Path, worldPathFromName, false);
    this._path = worldPathFromName;
    WorldGen.RenameWorld(this, newDisplayName, this.GetRenameCallback(onCompleted));
  }

  private Action<string> GetRenameCallback(Action returnToMenu)
  {
    return (Action<string>) (newWorldName =>
    {
      this.Name = newWorldName;
      Main.QueueMainThreadAction((Action) (() =>
      {
        SoundEngine.PlaySound(10);
        returnToMenu();
      }));
    });
  }
}
