// Decompiled with JetBrains decompiler
// Type: Terraria.IO.FileData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Utilities;

#nullable disable
namespace Terraria.IO;

public abstract class FileData
{
  protected string _path;
  protected bool _isCloudSave;
  public FileMetadata Metadata;
  public string Name;
  public readonly string Type;
  protected bool _isFavorite;

  public string Path => this._path;

  public bool IsCloudSave => this._isCloudSave;

  public bool IsFavorite => this._isFavorite;

  protected FileData(string type) => this.Type = type;

  protected FileData(string type, string path, bool isCloud)
  {
    this.Type = type;
    this._path = path;
    this._isCloudSave = isCloud;
    this._isFavorite = (isCloud ? Main.CloudFavoritesData : Main.LocalFavoriteData).IsFavorite(this);
  }

  public void ToggleFavorite() => this.SetFavorite(!this.IsFavorite);

  public string GetFileName(bool includeExtension = true)
  {
    return FileUtilities.GetFileName(this.Path, includeExtension);
  }

  public void SetFavorite(bool favorite, bool saveChanges = true)
  {
    this._isFavorite = favorite;
    if (!saveChanges)
      return;
    (this.IsCloudSave ? Main.CloudFavoritesData : Main.LocalFavoriteData).SaveFavorite(this);
  }

  public abstract void SetAsActive();

  public abstract void MoveToCloud();

  public abstract void MoveToLocal();
}
