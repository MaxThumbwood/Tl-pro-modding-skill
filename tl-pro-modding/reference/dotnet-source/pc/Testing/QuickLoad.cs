// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.QuickLoad
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ReLogic.OS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Terraria.GameContent.UI.States;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.Testing;

public abstract class QuickLoad
{
  private static readonly string FilePath = Path.Combine(Main.SavePath, "dev-quickload.json");
  private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
  {
    ContractResolver = (IContractResolver) new EasyDeserializationJsonContractResolver(),
    TypeNameHandling = (TypeNameHandling) 4
  };
  private static QuickLoad _loadedConfig;

  protected abstract void Start();

  public static bool QuickLoading => QuickLoad._loadedConfig != null;

  public static void Load()
  {
    if (!QuickLoad.TryRead(out QuickLoad._loadedConfig) || !QuickLoad.ShiftHeld())
      return;
    QuickLoad._loadedConfig = (QuickLoad) null;
    Platform.Get<IWindowService>().Activate(Main.instance.Window);
    if (MessageBox.Show("Quick Load skipped. Do you want to delete the configuration?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
      return;
    QuickLoad.Clear();
  }

  public static void OnContentLoaded()
  {
    try
    {
      if (QuickLoad._loadedConfig == null)
        return;
      QuickLoad._loadedConfig.Start();
    }
    catch (Exception ex)
    {
      if (MessageBox.Show("Do you want to delete the configuration?\n\n" + (object) ex, "Quickload Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) != DialogResult.Yes)
        return;
      QuickLoad.Clear();
    }
  }

  public static QuickLoad Deserialize(string json)
  {
    return JsonConvert.DeserializeObject<QuickLoad>(json, QuickLoad.SerializerSettings);
  }

  public static string Serialize(QuickLoad config)
  {
    return JsonConvert.SerializeObject((object) config, typeof (QuickLoad), QuickLoad.SerializerSettings);
  }

  public static bool TryRead(out QuickLoad config)
  {
    config = (QuickLoad) null;
    try
    {
      if (!File.Exists(QuickLoad.FilePath))
        return false;
      config = QuickLoad.Deserialize(File.ReadAllText(QuickLoad.FilePath));
      return true;
    }
    catch (Exception ex)
    {
      return false;
    }
  }

  public static void Set(QuickLoad config)
  {
    File.WriteAllText(QuickLoad.FilePath, QuickLoad.Serialize(config));
  }

  public static void Clear()
  {
    if (!File.Exists(QuickLoad.FilePath))
      return;
    File.Delete(QuickLoad.FilePath);
  }

  private static bool ShiftHeld()
  {
    if (Keyboard.GetState().PressingShift())
      return true;
    try
    {
      if (Platform.IsWindows)
        return QuickLoad.ShiftHeldWin();
      if (Platform.IsOSX)
        return QuickLoad.ShiftHeldOSX();
      if (Platform.IsLinux)
        return QuickLoad.ShiftHeldX11();
    }
    catch (Exception ex)
    {
    }
    return false;
  }

  [DllImport("user32.dll")]
  private static extern short GetAsyncKeyState(int vKey);

  private static bool ShiftHeldWin()
  {
    return ((int) QuickLoad.GetAsyncKeyState(160 /*0xA0*/) & 32768 /*0x8000*/) != 0 || ((uint) QuickLoad.GetAsyncKeyState(161) & 32768U /*0x8000*/) > 0U;
  }

  [DllImport("/System/Library/Frameworks/CoreGraphics.framework/CoreGraphics")]
  private static extern ulong CGEventSourceFlagsState(uint stateID);

  private static bool ShiftHeldOSX()
  {
    return (QuickLoad.CGEventSourceFlagsState(1U) & 131072UL /*0x020000*/) > 0UL;
  }

  [DllImport("libX11")]
  private static extern IntPtr XOpenDisplay(IntPtr display);

  [DllImport("libX11")]
  private static extern void XCloseDisplay(IntPtr display);

  [DllImport("libX11")]
  private static extern int XQueryKeymap(IntPtr display, byte[] keys_return);

  [DllImport("libX11")]
  private static extern int XKeysymToKeycode(IntPtr display, ulong keysym);

  private static bool ShiftHeldX11()
  {
    IntPtr display = QuickLoad.XOpenDisplay(IntPtr.Zero);
    if (display == IntPtr.Zero)
      return false;
    try
    {
      int keycode1 = QuickLoad.XKeysymToKeycode(display, 65505UL);
      int keycode2 = QuickLoad.XKeysymToKeycode(display, 65506UL);
      byte[] keys_return = new byte[32 /*0x20*/];
      QuickLoad.XQueryKeymap(display, keys_return);
      return ((uint) keys_return[keycode1 / 8] & (uint) (1 << keycode1 % 8)) > 0U | ((uint) keys_return[keycode2 / 8] & (uint) (1 << keycode2 % 8)) > 0U;
    }
    finally
    {
      QuickLoad.XCloseDisplay(display);
    }
  }

  public class JoinWorld : QuickLoad
  {
    public Microsoft.Xna.Framework.Rectangle? WindowedBounds;
    public string PlayerPath;
    public string WorldPath;
    public string ServerIPText;
    public string ServerPassword;
    public bool IsHostAndPlay;
    public List<QuickLoad.JoinWorld> ExtraClients = new List<QuickLoad.JoinWorld>();
    public Vector2 PlayerPosition;
    public int MountType;
    public bool InDebugRegenUI;
    public string RegenTargetPassName;
    public WorldGenerator.SnapshotFrequency RegenSnapshotFrequency;
    public bool RegenPauseOnHashMismatch;

    protected override void Start()
    {
      string s;
      int result;
      if (Program.LaunchParameters.TryGetValue("-quickloadclient", out s) && int.TryParse(s, out result) && result < this.ExtraClients.Count)
      {
        this.ExtraClients[result].Start();
      }
      else
      {
        if (this.ExtraClients != null)
          this.LaunchExtraClients();
        this.RestoreWindowBounds();
        this.SelectPlayerAndWorld();
        this.PlayWorldOrJoinServer();
      }
    }

    private void RestoreWindowBounds()
    {
      if (!this.WindowedBounds.HasValue)
        return;
      Microsoft.Xna.Framework.Rectangle rectangle = this.WindowedBounds.Value;
      if (!Platform.Get<IWindowService>().IsSizeable(Main.instance.Window))
        return;
      Main.SetResolution(rectangle.Width, rectangle.Height);
      Platform.Get<IWindowService>().SetPosition(Main.instance.Window, rectangle.X, rectangle.Y);
    }

    private void SaveWindowBounds()
    {
      if (!Platform.Get<IWindowService>().IsSizeable(Main.instance.Window))
        return;
      this.WindowedBounds = new Microsoft.Xna.Framework.Rectangle?(Platform.Get<IWindowService>().GetBounds(Main.instance.Window));
    }

    private void LaunchExtraClients()
    {
      for (int index = 0; index < this.ExtraClients.Count; ++index)
        Process.Start(Process.GetCurrentProcess().ProcessName, "-quickloadclient " + (object) index);
    }

    protected void SelectPlayerAndWorld()
    {
      Main.LoadPlayers();
      Main.SelectPlayer(Main.PlayerList.Single<PlayerFileData>((Func<PlayerFileData, bool>) (p => p.Path == this.PlayerPath)));
      if (string.IsNullOrEmpty(this.WorldPath))
        return;
      Main.WorldList.Single<WorldFileData>((Func<WorldFileData, bool>) (w => w.Path == this.WorldPath)).SetAsActive();
    }

    protected void PlayWorldOrJoinServer()
    {
      WorldGen.Hooks.OnWorldLoad += new Action(this.OnWorldLoad);
      Main.menuMode = 10;
      if (this.ServerIPText != null)
      {
        Netplay.ServerPassword = this.ServerPassword;
        if (this.IsHostAndPlay)
        {
          Main.HostAndPlay();
        }
        else
        {
          Main.autoPass = true;
          Netplay.SetRemoteIP(this.ServerIPText);
          Netplay.StartTcpClient();
          Main.statusText = Language.GetTextValue("Net.ConnectingTo", (object) this.ServerIPText);
        }
      }
      else
        WorldGen.playWorld();
    }

    private void OnWorldLoad()
    {
      WorldGen.Hooks.OnWorldLoad -= new Action(this.OnWorldLoad);
      if (Main.ActiveWorldFileData.Path != this.WorldPath || Main.ActivePlayerFileData.Path != this.PlayerPath || this.ServerIPText != null && Main.netMode != 1 || Main.netMode == 1 && this.ServerIPText != Netplay.ServerIPText)
        return;
      if (this.PlayerPosition != Vector2.Zero)
        Main.LocalPlayer.position = this.PlayerPosition;
      if (this.MountType != 0)
        Main.LocalPlayer.mount.SetMount(this.MountType, Main.LocalPlayer);
      DebugUtils.QuickSPMessage("/onquickload");
    }

    public virtual QuickLoad.JoinWorld WithCurrentState()
    {
      this.SaveWindowBounds();
      Main.SaveSettings();
      if (!Main.gameMenu)
        Player.SavePlayer(Main.ActivePlayerFileData);
      if (Main.WorldFileMetadata == null)
        Main.WorldFileMetadata = FileMetadata.FromCurrentSettings(FileType.World);
      if (Main.netMode != 1)
        WorldFile.SaveWorld();
      this.PlayerPath = Main.ActivePlayerFileData.Path;
      this.WorldPath = Main.ActiveWorldFileData.Path;
      if (Main.netMode == 1)
      {
        this.ServerIPText = Netplay.ServerIPText;
        this.ServerPassword = Netplay.ServerPassword;
        this.IsHostAndPlay = Netplay.IsHostAndPlay;
        if (this.IsHostAndPlay)
          NetMessage.SendData(94, text: NetworkText.FromLiteral("/quickload-clientprobe"));
      }
      if (!Main.gameMenu)
      {
        this.PlayerPosition = Main.LocalPlayer.position;
        this.MountType = Main.LocalPlayer.mount.Type;
      }
      this.InDebugRegenUI = UIWorldGenDebug.ActiveInstance != null;
      if (this.InDebugRegenUI)
      {
        if (UIWorldGenDebug.CurrentTargetOrLatestPass != null)
          this.RegenTargetPassName = UIWorldGenDebug.CurrentTargetOrLatestPass.Name;
        this.RegenSnapshotFrequency = WorldGenerator.CurrentController.SnapshotFrequency;
        this.RegenPauseOnHashMismatch = WorldGenerator.CurrentController.PauseOnHashMismatch;
      }
      return this;
    }

    protected WorldGenerator.Controller CreateRegenController()
    {
      WorldGen.PrepForRegen();
      return new WorldGenerator.Controller(WorldGen.Manifest)
      {
        Paused = this.InDebugRegenUI && this.RegenTargetPassName == null,
        SnapshotFrequency = this.RegenSnapshotFrequency,
        PauseOnHashMismatch = this.RegenPauseOnHashMismatch,
        OnPassesLoaded = (Action<WorldGenerator.Controller>) (c =>
        {
          c.PauseAfterPass = c.Passes.FirstOrDefault<GenPass>((Func<GenPass, bool>) (p => p.Name == this.RegenTargetPassName));
          if (c.PauseAfterPass == null)
            return;
          c.TryRunToEndOfPass(c.PauseAfterPass);
        })
      };
    }
  }

  public class RegenWorld : QuickLoad.JoinWorld
  {
    protected override void Start()
    {
      this.SelectPlayerAndWorld();
      this.GenerateWorld();
    }

    private void GenerateWorld()
    {
      WorldGen.CreateNewWorld(controller: this.CreateRegenController(), afterGeneration: new WorldGen.WorldGenerationFinishCallback(this.OnGenerationFinished));
    }

    private void OnGenerationFinished(bool playable)
    {
      if (!playable)
        return;
      this.InDebugRegenUI = false;
      this.PlayWorldOrJoinServer();
    }
  }
}
