// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.GitStatus
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using Terraria.Utilities;

#nullable disable
namespace Terraria.Testing;

public static class GitStatus
{
  private static string _gitSHA = "";
  private static bool _init;

  public static string GitSHA
  {
    get
    {
      GitStatus.Init();
      return GitStatus._gitSHA;
    }
  }

  private static void Init()
  {
    if (GitStatus._init)
      return;
    GitStatus._init = true;
    if (!GitStatus.HasGitFolder())
      return;
    try
    {
      GitStatus._gitSHA = GitStatus.GitRevParse();
    }
    catch (Exception ex)
    {
      int num = (int) MessageBox.Show(ex.Message, "git command failed", icon: MessageBoxIcon.Error);
    }
  }

  private static string GitRevParse()
  {
    using (Process process = new Process())
    {
      process.StartInfo = new ProcessStartInfo("git", "rev-parse HEAD")
      {
        UseShellExecute = false,
        RedirectStandardOutput = true,
        CreateNoWindow = true
      };
      process.Start();
      string str = process.StandardOutput.ReadToEnd().Trim();
      return Regex.IsMatch(str, "^[0-9a-f]+$") ? str : throw new Exception(str);
    }
  }

  private static bool HasGitFolder()
  {
    try
    {
      string directoryName = Path.GetDirectoryName(Path.GetFullPath("."));
      while (!Directory.Exists(Path.Combine(directoryName, ".git")))
      {
        if ((directoryName = Path.GetDirectoryName(directoryName)) == null)
          goto label_5;
      }
      return true;
    }
    catch (Exception ex)
    {
    }
label_5:
    return false;
  }
}
