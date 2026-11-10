// Decompiled with JetBrains decompiler
// Type: Terraria.Social.Base.CloudSocialModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using Terraria.IO;

#nullable disable
namespace Terraria.Social.Base;

public abstract class CloudSocialModule : ISocialModule
{
  public bool EnabledByDefault;

  public virtual void BindTo(Preferences preferences)
  {
    preferences.OnSave += new Action<Preferences>(this.Configuration_OnSave);
    preferences.OnLoad += new Action<Preferences>(this.Configuration_OnLoad);
  }

  private void Configuration_OnLoad(Preferences preferences)
  {
    this.EnabledByDefault = preferences.Get<bool>("CloudSavingDefault", false);
  }

  private void Configuration_OnSave(Preferences preferences)
  {
    preferences.Put("CloudSavingDefault", (object) this.EnabledByDefault);
  }

  public abstract void Initialize();

  public abstract void Shutdown();

  public abstract IEnumerable<string> GetFiles();

  public abstract bool Write(string path, byte[] data, int length);

  public abstract void Read(string path, byte[] buffer, int length);

  public abstract bool HasFile(string path);

  public abstract int GetFileSize(string path);

  public abstract bool Delete(string path);

  public abstract bool Forget(string path);

  public byte[] Read(string path)
  {
    byte[] buffer = new byte[this.GetFileSize(path)];
    this.Read(path, buffer, buffer.Length);
    return buffer;
  }

  public void Read(string path, byte[] buffer) => this.Read(path, buffer, buffer.Length);

  public bool Write(string path, byte[] data) => this.Write(path, data, data.Length);
}
