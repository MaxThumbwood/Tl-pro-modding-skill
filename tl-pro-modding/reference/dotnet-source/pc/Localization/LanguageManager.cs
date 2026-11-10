// Decompiled with JetBrains decompiler
// Type: Terraria.Localization.LanguageManager
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using CsvHelper;
using Newtonsoft.Json;
using ReLogic.Content;
using ReLogic.Content.Sources;
using ReLogic.Graphics;
using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using Terraria.Utilities;

#nullable disable
namespace Terraria.Localization;

public class LanguageManager
{
  public static LanguageManager Instance = new LanguageManager();
  private readonly Dictionary<string, LocalizedText> _localizedTexts = new Dictionary<string, LocalizedText>();
  private readonly Dictionary<string, List<string>> _categoryGroupedKeys = new Dictionary<string, List<string>>();
  private readonly Dictionary<string, Dictionary<string, string>> _textVariations = new Dictionary<string, Dictionary<string, string>>();
  private GameCulture _fallbackCulture = GameCulture.DefaultCulture;
  private List<IContentSource> _contentSources = new List<IContentSource>();
  public const char VariationSeparatorSign = '$';

  public event LanguageChangeCallback OnLanguageChanged;

  public GameCulture ActiveCulture { get; private set; }

  private LanguageManager() => this._localizedTexts[""] = LocalizedText.Empty;

  public int GetCategorySize(string name)
  {
    List<string> stringList;
    return this._categoryGroupedKeys.TryGetValue(name, out stringList) ? stringList.Count : 0;
  }

  public void SetLanguage(int legacyId) => this.SetLanguage(GameCulture.FromLegacyId(legacyId));

  public void SetLanguage(string cultureName)
  {
    this.SetLanguage(GameCulture.FromName(cultureName));
  }

  public void EstimateWordCount()
  {
    string[] array = this._localizedTexts.Values.Select<LocalizedText, string>((Func<LocalizedText, string>) (v => v.UnformattedValue)).SelectMany<string, string>((Func<string, IEnumerable<string>>) (text => (IEnumerable<string>) text.Split(' ', '\n', '-', ','))).Where<string>((Func<string, bool>) (word => !string.IsNullOrWhiteSpace(word) && !word.StartsWith("{") && !word.EndsWith("}"))).ToArray<string>();
    ((IEnumerable<string>) array).Distinct<string>().OrderBy<string, int>((Func<string, int>) (w => w.Length)).ToArray<string>();
    Trace.WriteLine("Estimated word count: " + (object) array.Length);
    Trace.WriteLine("Excluding one letter words: " + (object) ((IEnumerable<string>) array).Where<string>((Func<string, bool>) (w => w.Length > 1)).Count<string>());
  }

  private void SetAllTextValuesToKeys()
  {
    foreach (KeyValuePair<string, LocalizedText> localizedText in this._localizedTexts)
      localizedText.Value.SetValue(localizedText.Key);
  }

  private string[] GetLanguageFilesForCulture(GameCulture culture)
  {
    Assembly.GetExecutingAssembly();
    return Array.FindAll<string>(typeof (Program).Assembly.GetManifestResourceNames(), (Predicate<string>) (element => element.StartsWith("Terraria.Localization.Content." + culture.CultureInfo.Name) && element.EndsWith(".json")));
  }

  public void SetLanguage(GameCulture culture)
  {
    if (this.ActiveCulture == culture)
      return;
    Thread.CurrentThread.CurrentCulture = culture.CultureInfo;
    Thread.CurrentThread.CurrentUICulture = culture.CultureInfo;
    this.ReloadLanguage(culture);
  }

  private void ReloadLanguage(GameCulture targetCulture)
  {
    if (this.ActiveCulture != this._fallbackCulture)
    {
      this.SetAllTextValuesToKeys();
      if (targetCulture != this._fallbackCulture)
        this.LoadLanguage(this._fallbackCulture);
    }
    this.LoadLanguage(targetCulture);
    if (this.OnLanguageChanged == null)
      return;
    this.OnLanguageChanged(this);
  }

  private void LoadLanguage(GameCulture culture)
  {
    this.ActiveCulture = culture;
    this._textVariations.Clear();
    this.LoadFilesForCulture(culture);
    this.LoadFromContentSources();
    this.ProcessCopyCommandsInTexts();
  }

  private void LoadFilesForCulture(GameCulture culture)
  {
    foreach (string path in this.GetLanguageFilesForCulture(culture))
    {
      try
      {
        string fileText = (string) null ?? Utils.ReadEmbeddedResource(path);
        if (fileText == null || fileText.Length < 2)
          throw new FormatException();
        this.LoadLanguageFromFileTextJson(fileText, true);
      }
      catch (Exception ex)
      {
        if (Debugger.IsAttached)
          Debugger.Break();
        Console.WriteLine("Failed to load language file: " + path);
        break;
      }
    }
  }

  private void ProcessCopyCommandsInTexts()
  {
    Regex regex = new Regex("{\\$(\\w+\\.\\w+)}", RegexOptions.Compiled);
    foreach (KeyValuePair<string, LocalizedText> localizedText1 in this._localizedTexts)
    {
      LocalizedText localizedText2 = localizedText1.Value;
      for (int index = 0; index < 100; ++index)
      {
        string unformattedValue = localizedText2.UnformattedValue;
        string str = regex.Replace(unformattedValue, (MatchEvaluator) (match =>
        {
          string key = match.Groups[1].ToString();
          LocalizedText localizedText3;
          return !this._localizedTexts.TryGetValue(key, out localizedText3) ? key : localizedText3.UnformattedValue;
        }));
        if (!(str == unformattedValue))
          localizedText2.SetValue(str);
        else
          break;
      }
    }
  }

  public void UseSources(List<IContentSource> sourcesFromLowestToHighest)
  {
    this._contentSources = sourcesFromLowestToHighest;
    this.ReloadLanguage(this.ActiveCulture);
  }

  private void LoadFromContentSources()
  {
    string name = this.ActiveCulture.Name;
    string lower = $"Localization{Path.DirectorySeparatorChar.ToString()}{name}".ToLower();
    foreach (IContentSource contentSource in this._contentSources)
    {
      foreach (string str1 in contentSource.GetAllAssetsStartingWith(lower))
      {
        string extension = contentSource.GetExtension(str1);
        if ((extension == ".json" ? 1 : (extension == ".csv" ? 1 : 0)) != 0)
        {
          try
          {
            using (Stream stream = contentSource.OpenStream(str1))
            {
              using (StreamReader streamReader = new StreamReader(stream))
              {
                string end = streamReader.ReadToEnd();
                if (extension == ".json")
                  this.LoadLanguageFromFileTextJson(end, false);
                if (extension == ".csv")
                  this.LoadLanguageFromFileTextCsv(end);
              }
            }
          }
          catch (Exception ex)
          {
            IAssetRepository iassetRepository = XnaExtensions.Get<IAssetRepository>((IServiceProvider) Main.instance.Services);
            if (iassetRepository != null)
            {
              if (iassetRepository.AssetLoadFailHandler != null)
              {
                string str2 = str1 + extension;
                iassetRepository.AssetLoadFailHandler.Invoke(str2, (Exception) AssetLoadException.FromAssetException(str2, ex));
              }
            }
          }
        }
      }
    }
  }

  public void LoadLanguageFromFileTextCsv(string fileText)
  {
    using (TextReader textReader = (TextReader) new StringReader(fileText))
    {
      using (CsvReader csvReader = new CsvReader(textReader))
      {
        csvReader.Configuration.HasHeaderRecord = true;
        if (!csvReader.ReadHeader())
          return;
        string[] fieldHeaders = csvReader.FieldHeaders;
        int val1 = -1;
        int val2 = -1;
        for (int index = 0; index < fieldHeaders.Length; ++index)
        {
          string lower = fieldHeaders[index].ToLower();
          if (lower == "translation")
            val2 = index;
          if (lower == "key")
            val1 = index;
        }
        if (val1 == -1 || val2 == -1)
          return;
        int num = Math.Max(val1, val2) + 1;
        while (csvReader.Read())
        {
          string[] currentRecord = csvReader.CurrentRecord;
          if (currentRecord.Length >= num)
          {
            string key = currentRecord[val1];
            string str = currentRecord[val2];
            if (!string.IsNullOrWhiteSpace(key) && !string.IsNullOrWhiteSpace(str))
              this.UpdateTextValue(key, str);
          }
        }
      }
    }
  }

  public void LoadLanguageFromFileTextJson(string fileText, bool canCreateCategories)
  {
    foreach (KeyValuePair<string, Dictionary<string, string>> keyValuePair1 in JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(fileText))
    {
      string key1 = keyValuePair1.Key;
      foreach (KeyValuePair<string, string> keyValuePair2 in keyValuePair1.Value)
      {
        string key2 = $"{keyValuePair1.Key}.{keyValuePair2.Key}";
        if (!this.UpdateTextValue(key2, keyValuePair2.Value) & canCreateCategories)
        {
          this._localizedTexts.Add(key2, new LocalizedText(key2, keyValuePair2.Value));
          List<string> stringList;
          if (!this._categoryGroupedKeys.TryGetValue(keyValuePair1.Key, out stringList))
            this._categoryGroupedKeys.Add(keyValuePair1.Key, stringList = new List<string>());
          stringList.Add(keyValuePair2.Key);
        }
      }
    }
  }

  private bool UpdateTextValue(string key, string value)
  {
    if (key.Contains<char>('$'))
    {
      string[] strArray = key.Split('$');
      this.AddVariant(strArray[0], strArray[1], value);
      return true;
    }
    LocalizedText localizedText;
    if (!this._localizedTexts.TryGetValue(key, out localizedText))
      return false;
    localizedText.SetValue(value);
    return true;
  }

  public bool HotReloadContentFile(IContentSource contentSource, string path, string fullPath)
  {
    path = path.Replace('\\', '/');
    if (!path.StartsWith("Localization/"))
      return false;
    string str = File.ReadAllText(fullPath);
    if (path.EndsWith(".json"))
      JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(str);
    else if (!path.EndsWith(".csv"))
      return false;
    if (contentSource == null)
      return false;
    this.ReloadLanguage(this.ActiveCulture);
    return true;
  }

  [Conditional("DEBUG")]
  private void ValidateAllCharactersContainedInFont(DynamicSpriteFont font)
  {
    if (font == null)
      return;
    string str = "";
    foreach (LocalizedText localizedText in this._localizedTexts.Values)
    {
      foreach (char ch in localizedText.Value)
      {
        if (!font.IsCharacterSupported(ch))
          str = $"{str}{localizedText.Key}, {ch.ToString()}, {(object) (int) ch}\n";
      }
    }
  }

  public LocalizedText[] FindAll(Regex regex)
  {
    int length = 0;
    foreach (KeyValuePair<string, LocalizedText> localizedText in this._localizedTexts)
    {
      if (regex.IsMatch(localizedText.Key))
        ++length;
    }
    LocalizedText[] all = new LocalizedText[length];
    int index = 0;
    foreach (KeyValuePair<string, LocalizedText> localizedText in this._localizedTexts)
    {
      if (regex.IsMatch(localizedText.Key))
      {
        all[index] = localizedText.Value;
        ++index;
      }
    }
    return all;
  }

  public LocalizedText[] FindAll(LanguageSearchFilter filter)
  {
    LinkedList<LocalizedText> source = new LinkedList<LocalizedText>();
    foreach (KeyValuePair<string, LocalizedText> localizedText in this._localizedTexts)
    {
      if (filter(localizedText.Key, localizedText.Value))
        source.AddLast(localizedText.Value);
    }
    return source.ToArray<LocalizedText>();
  }

  public LocalizedText SelectRandom(LanguageSearchFilter filter, UnifiedRandom random = null)
  {
    int maxValue = 0;
    foreach (KeyValuePair<string, LocalizedText> localizedText in this._localizedTexts)
    {
      if (filter(localizedText.Key, localizedText.Value))
        ++maxValue;
    }
    int num = (random ?? Main.rand).Next(maxValue);
    foreach (KeyValuePair<string, LocalizedText> localizedText in this._localizedTexts)
    {
      if (filter(localizedText.Key, localizedText.Value) && --maxValue == num)
        return localizedText.Value;
    }
    return LocalizedText.Empty;
  }

  public LocalizedText RandomFromCategory(string categoryName, UnifiedRandom random = null)
  {
    List<string> stringList;
    return !this._categoryGroupedKeys.TryGetValue(categoryName, out stringList) ? new LocalizedText(categoryName + ".RANDOM", categoryName + ".RANDOM") : this.GetText($"{categoryName}.{stringList[(random ?? Main.rand).Next(stringList.Count)]}");
  }

  public LocalizedText IndexedFromCategory(string categoryName, int index)
  {
    List<string> stringList;
    if (!this._categoryGroupedKeys.TryGetValue(categoryName, out stringList))
      return new LocalizedText(categoryName + ".INDEXED", categoryName + ".INDEXED");
    int index1 = index % stringList.Count;
    return this.GetText($"{categoryName}.{stringList[index1]}");
  }

  public bool Exists(string key) => this._localizedTexts.ContainsKey(key);

  public LocalizedText GetText(string key)
  {
    LocalizedText localizedText;
    return this._localizedTexts.TryGetValue(key, out localizedText) ? localizedText : (this._localizedTexts[key] = new LocalizedText(key, key));
  }

  public string GetTextValue(string key)
  {
    LocalizedText localizedText;
    return this._localizedTexts.TryGetValue(key, out localizedText) ? localizedText.Value : key;
  }

  public string GetTextValue(string key, object arg0)
  {
    LocalizedText localizedText;
    return this._localizedTexts.TryGetValue(key, out localizedText) ? localizedText.Format(arg0) : key;
  }

  public string GetTextValue(string key, object arg0, object arg1)
  {
    LocalizedText localizedText;
    return this._localizedTexts.TryGetValue(key, out localizedText) ? localizedText.Format(arg0, arg1) : key;
  }

  public string GetTextValue(string key, object arg0, object arg1, object arg2)
  {
    LocalizedText localizedText;
    return this._localizedTexts.TryGetValue(key, out localizedText) ? localizedText.Format(arg0, arg1, arg2) : key;
  }

  public string GetTextValue(string key, params object[] args)
  {
    LocalizedText localizedText;
    return this._localizedTexts.TryGetValue(key, out localizedText) ? localizedText.Format(args) : key;
  }

  private void AddVariant(string key, string variant, string value)
  {
    Dictionary<string, string> dictionary;
    if (!this._textVariations.TryGetValue(key, out dictionary))
      this._textVariations[key] = dictionary = new Dictionary<string, string>();
    dictionary[variant] = value;
  }

  public bool TryGetVariation(string key, string variant, out string value)
  {
    value = (string) null;
    Dictionary<string, string> dictionary;
    return this._textVariations.TryGetValue(key, out dictionary) && dictionary.TryGetValue(variant, out value);
  }

  public void SetFallbackCulture(GameCulture culture) => this._fallbackCulture = culture;
}
