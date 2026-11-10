// Decompiled with JetBrains decompiler
// Type: Terraria.IO.ResourcePack
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Ionic.Zip;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json.Linq;
using ReLogic.Content;
using ReLogic.Content.Sources;
using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria.GameContent;

#nullable disable
namespace Terraria.IO;

public class ResourcePack
{
  public readonly string FullPath;
  public readonly string FileName;
  private readonly IServiceProvider _services;
  public readonly bool IsCompressed;
  public readonly ResourcePack.BrandingType Branding;
  private readonly ZipFile _zipFile;
  private Texture2D _icon;
  private IContentSource _contentSource;
  private const string ICON_FILE_NAME = "icon.png";
  private const string PACK_FILE_NAME = "pack.json";

  public Texture2D Icon
  {
    get
    {
      if (this._icon == null)
        this._icon = this.CreateIcon();
      return this._icon;
    }
  }

  public string Name { get; private set; }

  public string Description { get; private set; }

  public string Author { get; private set; }

  public ResourcePackVersion Version { get; private set; }

  public bool IsEnabled { get; set; }

  public int SortingOrder { get; set; }

  public ResourcePack(IServiceProvider services, string path, ResourcePack.BrandingType branding = ResourcePack.BrandingType.None)
  {
    if (File.Exists(path))
      this.IsCompressed = true;
    else if (!Directory.Exists(path))
      throw new FileNotFoundException("Unable to find file or folder for resource pack at: " + path);
    this.FileName = Path.GetFileName(path);
    this._services = services;
    this.FullPath = path;
    this.Branding = branding;
    if (this.IsCompressed)
      this._zipFile = ZipFile.Read(path);
    this.LoadManifest();
  }

  public IContentSource GetContentSource()
  {
    if (this._contentSource == null)
    {
      this._contentSource = !this.IsCompressed ? (IContentSource) new FileSystemContentSource(Path.Combine(this.FullPath, "Content")) : (IContentSource) new ZipContentSource(this.FullPath, "Content");
      this._contentSource.ContentValidator = (IContentValidator) VanillaContentValidator.Instance;
    }
    return this._contentSource;
  }

  private Texture2D CreateIcon()
  {
    if (!this.HasFile("icon.png"))
      return XnaExtensions.Get<IAssetRepository>(this._services).Request<Texture2D>("Images/UI/DefaultResourcePackIcon", (AssetRequestMode) 1).Value;
    using (Stream stream = this.OpenStream("icon.png"))
      return XnaExtensions.Get<AssetReaderCollection>(this._services).Read<Texture2D>(stream, ".png");
  }

  private void LoadManifest()
  {
    if (!this.HasFile("pack.json"))
      throw new FileNotFoundException($"Resource Pack at \"{this.FullPath}\" must contain a {"pack.json"} file.");
    JObject jobject;
    using (Stream stream = this.OpenStream("pack.json"))
    {
      using (StreamReader streamReader = new StreamReader(stream))
        jobject = JObject.Parse(streamReader.ReadToEnd());
    }
    this.Name = Extensions.Value<string>((IEnumerable<JToken>) jobject["Name"]);
    this.Description = Extensions.Value<string>((IEnumerable<JToken>) jobject["Description"]);
    this.Author = Extensions.Value<string>((IEnumerable<JToken>) jobject["Author"]);
    this.Version = jobject["Version"].ToObject<ResourcePackVersion>();
  }

  private Stream OpenStream(string fileName)
  {
    if (!this.IsCompressed)
      return (Stream) File.OpenRead(Path.Combine(this.FullPath, fileName));
    ZipEntry zipEntry = this._zipFile[fileName];
    MemoryStream memoryStream = new MemoryStream((int) zipEntry.UncompressedSize);
    zipEntry.Extract((Stream) memoryStream);
    memoryStream.Position = 0L;
    return (Stream) memoryStream;
  }

  private bool HasFile(string fileName)
  {
    return !this.IsCompressed ? File.Exists(Path.Combine(this.FullPath, fileName)) : this._zipFile.ContainsEntry(fileName);
  }

  public enum BrandingType
  {
    None,
    SteamWorkshop,
  }
}
