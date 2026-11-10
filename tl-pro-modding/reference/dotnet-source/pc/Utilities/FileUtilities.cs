// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.FileUtilities
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.OS;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using Terraria.Social;

#nullable disable
namespace Terraria.Utilities;

public static class FileUtilities
{
  private static Regex FileNameRegex = new Regex("^(?<path>.*[\\\\\\/])?(?:$|(?<fileName>.+?)(?:(?<extension>\\.[^.]*$)|$))", RegexOptions.IgnoreCase | RegexOptions.Compiled);

  public static bool Exists(string path, bool cloud)
  {
    return cloud && SocialAPI.Cloud != null ? SocialAPI.Cloud.HasFile(path) : File.Exists(path);
  }

  public static void Delete(string path, bool cloud, bool forceDeleteFile = false)
  {
    if (cloud && SocialAPI.Cloud != null)
      SocialAPI.Cloud.Delete(path);
    else if (forceDeleteFile)
      File.Delete(path);
    else
      Platform.Get<IPathService>().MoveToRecycleBin(path);
  }

  public static string GetFullPath(string path, bool cloud)
  {
    return !cloud ? Path.GetFullPath(path) : path;
  }

  public static void Copy(string source, string destination, bool cloud)
  {
    if (!cloud)
    {
      try
      {
        File.Copy(source, destination, true);
      }
      catch (IOException ex)
      {
        if (ex.GetType() != typeof (IOException))
          throw;
        using (FileStream fileStream = File.OpenRead(source))
        {
          using (FileStream destination1 = File.Create(destination))
            fileStream.CopyTo((Stream) destination1);
        }
      }
    }
    else
    {
      if (SocialAPI.Cloud == null)
        return;
      SocialAPI.Cloud.Write(destination, SocialAPI.Cloud.Read(source));
    }
  }

  public static void Move(string source, string destination, bool cloud)
  {
    if (!cloud)
    {
      try
      {
        if (File.Exists(destination))
          File.Delete(destination);
        File.Move(source, destination);
        return;
      }
      catch (IOException ex)
      {
      }
    }
    FileUtilities.Copy(source, destination, cloud);
    FileUtilities.Delete(source, cloud, true);
  }

  public static int GetFileSize(string path, bool cloud)
  {
    return cloud && SocialAPI.Cloud != null ? SocialAPI.Cloud.GetFileSize(path) : (int) new FileInfo(path).Length;
  }

  public static void Read(string path, byte[] buffer, int length, bool cloud)
  {
    if (cloud && SocialAPI.Cloud != null)
    {
      SocialAPI.Cloud.Read(path, buffer, length);
    }
    else
    {
      using (FileStream fileStream = File.OpenRead(path))
        fileStream.Read(buffer, 0, length);
    }
  }

  public static byte[] ReadAllBytes(string path, bool cloud)
  {
    return cloud && SocialAPI.Cloud != null ? SocialAPI.Cloud.Read(path) : File.ReadAllBytes(path);
  }

  public static bool WriteAllBytes(string path, byte[] data, bool cloud)
  {
    return FileUtilities.Write(path, data, data.Length, cloud);
  }

  public static bool Write(string path, byte[] data, int length, bool cloud)
  {
    if (cloud)
      return SocialAPI.Cloud != null && SocialAPI.Cloud.Write(path, data, length);
    string parentFolderPath = FileUtilities.GetParentFolderPath(path);
    if (parentFolderPath != "")
      Utils.TryCreatingDirectory(parentFolderPath);
    FileUtilities.RemoveReadOnlyAttribute(path);
    using (FileStream fileStream = File.Open(path, FileMode.Create))
    {
      while (fileStream.Position < (long) length)
        fileStream.Write(data, (int) fileStream.Position, Math.Min(length - (int) fileStream.Position, 2048 /*0x0800*/));
    }
    return true;
  }

  public static void RemoveReadOnlyAttribute(string path)
  {
    if (!File.Exists(path))
      return;
    try
    {
      FileAttributes attributes = File.GetAttributes(path);
      if ((attributes & FileAttributes.ReadOnly) != FileAttributes.ReadOnly)
        return;
      FileAttributes fileAttributes = attributes & ~FileAttributes.ReadOnly;
      File.SetAttributes(path, fileAttributes);
    }
    catch (Exception ex)
    {
    }
  }

  public static bool MoveToCloud(string localPath, string cloudPath)
  {
    if (SocialAPI.Cloud == null)
      return false;
    int num = FileUtilities.WriteAllBytes(cloudPath, FileUtilities.ReadAllBytes(localPath, false), true) ? 1 : 0;
    if (num == 0)
      return num != 0;
    FileUtilities.Delete(localPath, false);
    return num != 0;
  }

  public static bool MoveToLocal(string cloudPath, string localPath)
  {
    if (SocialAPI.Cloud == null)
      return false;
    if (FileUtilities.WriteAllBytes(localPath, FileUtilities.ReadAllBytes(cloudPath, true), false))
      FileUtilities.Delete(cloudPath, true);
    return true;
  }

  public static bool CopyToLocal(string cloudPath, string localPath)
  {
    if (SocialAPI.Cloud == null)
      return false;
    FileUtilities.WriteAllBytes(localPath, FileUtilities.ReadAllBytes(cloudPath, true), false);
    return true;
  }

  public static string GetFileName(string path, bool includeExtension = true)
  {
    Match match = FileUtilities.FileNameRegex.Match(path);
    if (match == null || match.Groups["fileName"] == null)
      return "";
    includeExtension &= match.Groups["extension"] != null;
    return match.Groups["fileName"].Value + (includeExtension ? match.Groups["extension"].Value : "");
  }

  public static string GetParentFolderPath(string path, bool includeExtension = true)
  {
    Match match = FileUtilities.FileNameRegex.Match(path);
    return match == null || match.Groups[nameof (path)] == null ? "" : match.Groups[nameof (path)].Value;
  }

  public static void CopyFolder(string sourcePath, string destinationPath)
  {
    Directory.CreateDirectory(destinationPath);
    foreach (string directory in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
      Directory.CreateDirectory(directory.Replace(sourcePath, destinationPath));
    foreach (string file in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
      File.Copy(file, file.Replace(sourcePath, destinationPath), true);
  }

  public static void ProtectedInvoke(Action action)
  {
    bool isBackground = Thread.CurrentThread.IsBackground;
    try
    {
      Thread.CurrentThread.IsBackground = false;
      action();
    }
    finally
    {
      Thread.CurrentThread.IsBackground = isBackground;
    }
  }
}
