// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.WorldGenSnapshot
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Terraria.Testing;
using Terraria.Utilities;

#nullable disable
namespace Terraria.WorldBuilding;

public class WorldGenSnapshot
{
  private int _dataOffset;
  private List<GenPass> _matchingPasses;
  private static string SnapshotFolderSuffix = "_gensnapshots";
  private static string Extension = ".gensnapshot";
  private static IDictionary<string, long> _snapshotSizeCache = (IDictionary<string, long>) new Dictionary<string, long>();

  public WorldManifest Manifest { get; private set; }

  private string Path { get; set; }

  private string GenVarsJson { get; set; }

  public List<GenPassResult> GenPassResults => this.Manifest.GenPassResults;

  public bool Outdated
  {
    get
    {
      return this.Manifest.GitSHA != GitStatus.GitSHA || this.Manifest.Version != Main.versionNumber || !this._matchingPasses.Zip<GenPass, GenPassResult, bool>((IEnumerable<GenPassResult>) this.GenPassResults, (Func<GenPass, GenPassResult, bool>) ((p, r) => p.Enabled == !r.Skipped)).All<bool>((Func<bool, bool>) (x => x));
    }
  }

  public override string ToString()
  {
    GenPassResult genPassResult = this.GenPassResults.Last<GenPassResult>();
    return $"Pass - {genPassResult.Name}, rand - {genPassResult.RandNext:X8}, hash - {genPassResult.Hash:X8}";
  }

  private static string PathForActiveWorld
  {
    get
    {
      return System.IO.Path.ChangeExtension(Main.ActiveWorldFileData.Path, (string) null) + WorldGenSnapshot.SnapshotFolderSuffix;
    }
  }

  public static long EstimatedDiskUsage => WorldGenSnapshot._snapshotSizeCache.Values.Sum();

  public static void DeleteAllForCurrentWorld()
  {
    if (Directory.Exists(WorldGenSnapshot.PathForActiveWorld))
    {
      try
      {
        Directory.Delete(WorldGenSnapshot.PathForActiveWorld, true);
      }
      catch (Exception ex)
      {
      }
    }
    WorldGenSnapshot._snapshotSizeCache.Clear();
  }

  public static WorldGenSnapshot Create()
  {
    WorldGenSnapshot context = new WorldGenSnapshot()
    {
      Manifest = WorldGen.Manifest.Clone(),
      GenVarsJson = WorldGenSnapshot.SnapshotGenVars.Serialize()
    };
    context._matchingPasses = WorldGenerator.CurrentController.Passes.GetRange(0, context.GenPassResults.Count);
    context.Path = System.IO.Path.Combine(WorldGenSnapshot.PathForActiveWorld, context.ToString() + WorldGenSnapshot.Extension);
    if (!Directory.Exists(WorldGenSnapshot.PathForActiveWorld))
      Directory.CreateDirectory(WorldGenSnapshot.PathForActiveWorld);
    TileSnapshot.Create((object) context);
    using (BinaryWriter writer = new BinaryWriter((Stream) File.Create(context.Path)))
    {
      writer.Write(context.Manifest.Serialize());
      writer.Write(context.GenVarsJson);
      context._dataOffset = (int) writer.BaseStream.Position;
      TileSnapshot.Save(writer);
      WorldGenSnapshot._snapshotSizeCache[context.Path] = writer.BaseStream.Length;
    }
    return context;
  }

  public static void Delete(WorldGenSnapshot snap)
  {
    try
    {
      File.Delete(snap.Path);
    }
    catch (Exception ex)
    {
    }
    WorldGenSnapshot._snapshotSizeCache.Remove(snap.Path);
  }

  public void ResaveForCurrentVersion()
  {
    this.Manifest = WorldGen.Manifest.Clone();
    this.GenVarsJson = WorldGenSnapshot.SnapshotGenVars.Serialize();
    using (MemoryStream destination = new MemoryStream())
    {
      using (FileStream fileStream = File.OpenRead(this.Path))
      {
        fileStream.Seek((long) this._dataOffset, SeekOrigin.Current);
        fileStream.CopyTo((Stream) destination);
      }
      destination.Position = 0L;
      using (BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(this.Path)))
      {
        binaryWriter.Write(this.Manifest.Serialize());
        binaryWriter.Write(this.GenVarsJson);
        this._dataOffset = (int) binaryWriter.BaseStream.Position;
        destination.CopyTo(binaryWriter.BaseStream);
        WorldGenSnapshot._snapshotSizeCache[this.Path] = binaryWriter.BaseStream.Length;
      }
    }
  }

  public static Dictionary<GenPass, WorldGenSnapshot> LoadSnapshots(
    WorldManifest worldManifest,
    List<GenPass> passes)
  {
    WorldGenSnapshot._snapshotSizeCache.Clear();
    Dictionary<GenPass, WorldGenSnapshot> dictionary = new Dictionary<GenPass, WorldGenSnapshot>();
    Task.Factory.StartNew((Action) (() => WorldGenSnapshot.DeleteSnapshotsForOtherWorlds(WorldGenSnapshot.PathForActiveWorld)));
    if (!Directory.Exists(WorldGenSnapshot.PathForActiveWorld))
      return dictionary;
    if (worldManifest == null)
    {
      Trace.WriteLine("Deleting old snapshots because a new world is being created (/regen was not used)");
      WorldGenSnapshot.DeleteAllForCurrentWorld();
      return dictionary;
    }
    foreach (string enumerateFile in Directory.EnumerateFiles(WorldGenSnapshot.PathForActiveWorld, "*" + WorldGenSnapshot.Extension))
    {
      WorldGenSnapshot snap;
      GenPass pass;
      if (WorldGenSnapshot.ReadSnapshot(enumerateFile, out snap) && snap.IsValidHistoryOf(worldManifest) && WorldGenSnapshot.FindMatchingGenPass(snap.Manifest, passes, out pass))
      {
        snap._matchingPasses = passes.GetRange(0, snap.GenPassResults.Count);
        dictionary[pass] = snap;
      }
      else
      {
        Trace.WriteLine($"Deleting snapshot ({snap}) due to manifest mismatch. A change to the codebase has probably invalidated it.");
        WorldGenSnapshot.Delete(snap);
      }
    }
    return dictionary;
  }

  private static void DeleteSnapshotsForOtherWorlds(string snapshotPathForActiveWorld)
  {
    string directoryName = System.IO.Path.GetDirectoryName(snapshotPathForActiveWorld);
    string fileName = System.IO.Path.GetFileName(snapshotPathForActiveWorld);
    foreach (string enumerateDirectory in Directory.EnumerateDirectories(directoryName))
    {
      if (enumerateDirectory.EndsWith(WorldGenSnapshot.SnapshotFolderSuffix) && !(System.IO.Path.GetFileName(enumerateDirectory) == fileName))
      {
        Trace.WriteLine("Deleting snapshot directory: " + enumerateDirectory);
        try
        {
          Directory.Delete(enumerateDirectory, true);
        }
        catch (Exception ex)
        {
        }
      }
    }
  }

  private static bool FindMatchingGenPass(
    WorldManifest manifest,
    List<GenPass> passes,
    out GenPass pass)
  {
    pass = (GenPass) null;
    List<GenPassResult> genPassResults = manifest.GenPassResults;
    if (genPassResults.Count > passes.Count || !genPassResults.Zip<GenPassResult, GenPass, bool>((IEnumerable<GenPass>) passes, (Func<GenPassResult, GenPass, bool>) ((r, p) => r.Name == p.Name)).All<bool>((Func<bool, bool>) (x => x)))
      return false;
    pass = passes[genPassResults.Count - 1];
    return true;
  }

  public bool IsValidHistoryOf(WorldManifest target)
  {
    return WorldGenSnapshot.StartsWith(target.GenPassResults, this.Manifest.GenPassResults);
  }

  private static bool StartsWith(List<GenPassResult> list, List<GenPassResult> prefix)
  {
    return prefix.Count <= list.Count && list.Zip<GenPassResult, GenPassResult, bool>((IEnumerable<GenPassResult>) prefix, (Func<GenPassResult, GenPassResult, bool>) ((a, b) => a.Matches(b))).All<bool>((Func<bool, bool>) (x => x));
  }

  private static bool ReadSnapshot(string path, out WorldGenSnapshot snap)
  {
    try
    {
      using (BinaryReader binaryReader = new BinaryReader((Stream) File.OpenRead(path)))
      {
        snap = new WorldGenSnapshot()
        {
          Path = path,
          Manifest = WorldManifest.Deserialize(binaryReader.ReadString()),
          GenVarsJson = binaryReader.ReadString(),
          _dataOffset = (int) binaryReader.BaseStream.Position
        };
        WorldGenSnapshot._snapshotSizeCache[path] = binaryReader.BaseStream.Length;
        return true;
      }
    }
    catch (Exception ex)
    {
      Trace.WriteLine($"Failed to read snapshot: {path}, {(object) ex}");
      snap = (WorldGenSnapshot) null;
      return false;
    }
  }

  public void Load()
  {
    if (TileSnapshot.Context == this)
      return;
    using (BinaryReader reader = new BinaryReader((Stream) File.OpenRead(this.Path)))
    {
      reader.BaseStream.Seek((long) this._dataOffset, SeekOrigin.Current);
      TileSnapshot.Load(reader, (object) this);
    }
  }

  public void Restore()
  {
    this.Load();
    WorldGen.RestoreTemporaryStateChanges();
    WorldGen.Reset();
    WorldGen.Manifest = this.Manifest.Clone();
    WorldGenSnapshot.SnapshotGenVars.DeserializeAndApply(this.GenVarsJson);
    TileSnapshot.Restore();
    foreach (NPC npc in Main.npc)
      npc.active = false;
    Main.NewText("Restored " + (object) this, B: (byte) 0);
  }

  [JsonConverter(typeof (WorldGenSnapshot.SnapshotGenVars))]
  private class SnapshotGenVars : JsonConverter
  {
    public static JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
    {
      ContractResolver = (IContractResolver) new EasyDeserializationJsonContractResolver(),
      PreserveReferencesHandling = (PreserveReferencesHandling) 1,
      ReferenceLoopHandling = (ReferenceLoopHandling) 2,
      TypeNameHandling = (TypeNameHandling) 4
    };
    private static Dictionary<string, MemberInfo> fieldsAndProperties = ((IEnumerable<MemberInfo>) typeof (GenVars).GetFields(BindingFlags.Static | BindingFlags.Public)).Concat<MemberInfo>((IEnumerable<MemberInfo>) typeof (GenVars).GetProperties(BindingFlags.Static | BindingFlags.Public)).Where<MemberInfo>((Func<MemberInfo, bool>) (m => (object) (m as PropertyInfo) == null || ((PropertyInfo) m).CanWrite)).Where<MemberInfo>((Func<MemberInfo, bool>) (m => (object) (m as FieldInfo) == null || !((FieldInfo) m).IsInitOnly)).Where<MemberInfo>((Func<MemberInfo, bool>) (m => !((IEnumerable<object>) m.GetCustomAttributes(typeof (JsonIgnoreAttribute), true)).Any<object>())).ToDictionary<MemberInfo, string>((Func<MemberInfo, string>) (m => m.Name));

    public static string Serialize()
    {
      return JsonConvert.SerializeObject((object) new WorldGenSnapshot.SnapshotGenVars(), WorldGenSnapshot.SnapshotGenVars.SerializerSettings);
    }

    public static void DeserializeAndApply(string json)
    {
      JsonConvert.DeserializeObject<WorldGenSnapshot.SnapshotGenVars>(json, WorldGenSnapshot.SnapshotGenVars.SerializerSettings);
    }

    public virtual bool CanConvert(Type objectType)
    {
      return objectType == typeof (WorldGenSnapshot.SnapshotGenVars);
    }

    public virtual object ReadJson(
      JsonReader reader,
      Type objectType,
      object existingValue,
      JsonSerializer serializer)
    {
      if (reader.TokenType != 1)
        throw new JsonReaderException();
      while (reader.Read() && reader.TokenType != 13)
      {
        string key = reader.TokenType == 4 ? (string) reader.Value : throw new JsonReaderException("Expected PropertyName");
        if (!reader.Read())
          throw new JsonReaderException();
        MemberInfo member;
        if (WorldGenSnapshot.SnapshotGenVars.fieldsAndProperties.TryGetValue(key, out member))
          this.SetValue(member, serializer.Deserialize(reader, this.GetType(member)));
        else
          reader.Skip();
      }
      return (object) null;
    }

    public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
      writer.WriteStartObject();
      foreach (MemberInfo member in WorldGenSnapshot.SnapshotGenVars.fieldsAndProperties.Values)
      {
        writer.WritePropertyName(member.Name);
        serializer.Serialize(writer, this.GetValue(member), this.GetType(member));
      }
      writer.WriteEndObject();
    }

    private Type GetType(MemberInfo member)
    {
      if ((object) (member as PropertyInfo) != null)
        return ((PropertyInfo) member).PropertyType;
      return (object) (member as FieldInfo) != null ? ((FieldInfo) member).FieldType : throw new ArgumentException(member.GetType().ToString());
    }

    private object GetValue(MemberInfo member)
    {
      if ((object) (member as PropertyInfo) != null)
        return ((PropertyInfo) member).GetGetMethod().Invoke((object) null, (object[]) null);
      return (object) (member as FieldInfo) != null ? ((FieldInfo) member).GetValue((object) null) : throw new ArgumentException(member.GetType().ToString());
    }

    private void SetValue(MemberInfo member, object v)
    {
      if ((object) (member as PropertyInfo) != null)
      {
        ((PropertyInfo) member).GetSetMethod().Invoke((object) null, new object[1]
        {
          v
        });
      }
      else
      {
        if ((object) (member as FieldInfo) == null)
          throw new ArgumentException(member.GetType().ToString());
        ((FieldInfo) member).SetValue((object) null, v);
      }
    }
  }
}
