// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.WorldGenerator
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Threading;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Terraria.GameContent.UI.States;
using Terraria.Testing;
using Terraria.Utilities;

#nullable disable
namespace Terraria.WorldBuilding;

public class WorldGenerator
{
  internal readonly List<GenPass> _passes = new List<GenPass>();
  private readonly int _seed;
  private readonly WorldGenConfiguration _configuration;
  private readonly GenerationProgress _progress;
  private readonly WorldGenerator.Controller _controller;
  private readonly object _controlLock = new object();
  private GenPass _currentPass;
  public static GenerationProgress CurrentGenerationProgress;
  public static WorldGenerator.Controller CurrentController;
  private static Stopwatch _hashTime = new Stopwatch();

  public static List<GenPassResult> PassResults => WorldGen.Manifest.GenPassResults;

  public WorldGenerator(
    int seed,
    WorldGenConfiguration configuration,
    GenerationProgress progress = null,
    WorldGenerator.Controller controller = null)
  {
    this._seed = seed;
    this._configuration = configuration;
    this._progress = progress == null ? new GenerationProgress() : progress;
    this._controller = controller == null ? new WorldGenerator.Controller() : controller;
  }

  public void Append(GenPass pass) => this._passes.Add(pass);

  public bool GenerateWorld()
  {
    WorldGenerator._hashTime.Reset();
    this._controller.SetGenerator(this);
    WorldGenerator.CurrentController = this._controller;
    this._progress.TotalWeight = this._passes.Where<GenPass>((Func<GenPass, bool>) (p => p.Enabled)).Sum<GenPass>((Func<GenPass, double>) (p => p.Weight));
    WorldGenerator.CurrentGenerationProgress = this._progress;
    if (this._controller.PauseAfterPass != null)
      WorldGenerator.SetDebugWorldGenUIVisibility(true);
    bool flag = false;
    while (!this._controller.QueuedAbort)
    {
      if (this._controller.Paused)
      {
        this._controller.OnPaused();
      }
      else
      {
        lock (this._controlLock)
        {
          if (WorldGenerator.PassResults.Count != this._passes.Count)
          {
            this._currentPass = this._passes[WorldGenerator.PassResults.Count];
            lock (this._currentPass)
            {
              WorldGenerator.PassResults.Add(this.RunPass(this._currentPass));
              this._controller.OnPassCompleted();
            }
            this._currentPass = (GenPass) null;
          }
          else
            goto label_18;
        }
      }
    }
    flag = true;
label_18:
    Trace.WriteLine(string.Join<GenPassResult>("\n", (IEnumerable<GenPassResult>) WorldGenerator.PassResults) + $"\nFinished world - Seed: {Main.ActiveWorldFileData.SeedText} Width: {Main.maxTilesX}, Height: {Main.maxTilesY}, Evil: {WorldGen.WorldGenParam_Evil}, Difficulty: {Main.GameMode}\nTotal Generation Time: {WorldGenerator.PassResults.Sum<GenPassResult>((Func<GenPassResult, int>) (r => r.DurationMs))}\n");
    WorldGenerator.SetDebugWorldGenUIVisibility(false);
    WorldGenerator.CurrentGenerationProgress = (GenerationProgress) null;
    WorldGenerator.CurrentController = (WorldGenerator.Controller) null;
    return !flag;
  }

  private static void SetDebugWorldGenUIVisibility(bool visible)
  {
    bool flag = UIWorldGenDebug.ActiveInstance != null;
    if (visible == flag)
      return;
    Main.RunOnMainThread((Action) (() =>
    {
      if (visible)
        UIWorldGenDebug.Open();
      else
        UIWorldGenDebug.Close();
    })).Wait();
  }

  private GenPassResult RunPass(GenPass pass)
  {
    if (!pass.Enabled)
      return new GenPassResult()
      {
        Name = pass.Name,
        Skipped = true
      };
    Stopwatch stopwatch = Stopwatch.StartNew();
    Main.rand = new UnifiedRandom(this._seed);
    this._progress.Start(pass.Weight);
    try
    {
      pass.Apply(this._progress, this._configuration.GetPassConfiguration(pass.Name));
    }
    catch (Exception ex)
    {
      this._controller.ReportException("Exception in Pass: " + pass.Name, ex);
    }
    this._progress.End();
    return new GenPassResult()
    {
      Name = pass.Name,
      DurationMs = (int) stopwatch.ElapsedMilliseconds,
      RandNext = WorldGen.genRand.Next()
    };
  }

  public static uint HashWorld()
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    WorldGenerator.\u003C\u003Ec__DisplayClass17_0 cDisplayClass170 = new WorldGenerator.\u003C\u003Ec__DisplayClass17_0();
    WorldGenerator._hashTime.Start();
    // ISSUE: reference to a compiler-generated field
    cDisplayClass170.line_hashes = new uint[Main.maxTilesX];
    // ISSUE: method pointer
    FastParallel.For(0, Main.maxTilesX, new ParallelForAction((object) cDisplayClass170, __methodptr(\u003CHashWorld\u003Eb__0)), (object) null);
    uint num1 = 0;
    // ISSUE: reference to a compiler-generated field
    foreach (uint lineHash in cDisplayClass170.line_hashes)
    {
      uint num2 = num1 ^ lineHash;
      num1 = (uint) ((int) (num2 << 13 | num2 >> 19) * 5 - 430675100);
    }
    WorldGenerator._hashTime.Stop();
    return num1;
  }

  public enum SnapshotFrequency
  {
    None = -1, // 0xFFFFFFFF
    Manual = 0,
    Automatic = 1,
    Always = 2,
  }

  public class Controller
  {
    private WorldManifest _previousManifest;
    private Dictionary<GenPass, WorldGenSnapshot> _snapshots;
    public Action<WorldGenerator.Controller> OnPassesLoaded;
    private WorldGenerator _generator;
    private bool _paused;

    public List<GenPass> Passes => this._generator._passes;

    public GenPass CurrentPass => this._generator._currentPass;

    public GenPass LastCompletedPass
    {
      get
      {
        return WorldGenerator.PassResults.Count != 0 ? this.Passes[WorldGenerator.PassResults.Count - 1] : (GenPass) null;
      }
    }

    public GenPass PauseAfterPass { get; set; }

    public bool PauseOnHashMismatch { get; set; }

    public bool PausedDueToHashMismatch { get; set; }

    public WorldGenerator.SnapshotFrequency SnapshotFrequency { get; set; }

    public bool Paused
    {
      get => this._paused;
      set
      {
        this._paused = value;
        if (value)
          this.PauseAfterPass = (GenPass) null;
        else
          this.PausedDueToHashMismatch = false;
      }
    }

    public bool QueuedAbort { get; set; }

    public WorldGenSnapshot GetSnapshot(GenPass pass)
    {
      WorldGenSnapshot worldGenSnapshot;
      return !this._snapshots.TryGetValue(pass, out worldGenSnapshot) ? (WorldGenSnapshot) null : worldGenSnapshot;
    }

    public Controller(WorldManifest prevManifest = null)
    {
      this._previousManifest = prevManifest;
      this.PauseOnHashMismatch = true;
      this.SnapshotFrequency = WorldGenerator.SnapshotFrequency.None;
    }

    internal void SetGenerator(WorldGenerator generator)
    {
      this._generator = generator;
      this._snapshots = WorldGenSnapshot.LoadSnapshots(this._previousManifest, this.Passes);
      if (this._previousManifest != null)
      {
        foreach (GenPassResult genPassResult in this._previousManifest.GenPassResults.Where<GenPassResult>((Func<GenPassResult, bool>) (r => r.Skipped)))
        {
          GenPassResult r = genPassResult;
          this.Passes.SingleOrDefault<GenPass>((Func<GenPass, bool>) (p => p.Name == r.Name))?.Disable();
        }
      }
      if (this.OnPassesLoaded == null)
        return;
      this.OnPassesLoaded(this);
    }

    internal void OnPaused()
    {
      WorldGenerator.SetDebugWorldGenUIVisibility(true);
      this.ForceUpdateProgress();
      Thread.Sleep(10);
    }

    internal void OnPassCompleted()
    {
      int num = WorldGenerator.PassResults.Count - 1;
      GenPassResult passResult = WorldGenerator.PassResults[num];
      WorldGenSnapshot snapshot1 = this.GetSnapshot(this.CurrentPass);
      GenPass genPass1 = this.Passes.Skip<GenPass>(WorldGenerator.PassResults.Count).FirstOrDefault<GenPass>();
      if (UIWorldGenDebug.ActiveInstance != null || genPass1 == null)
        passResult.Hash = new uint?(WorldGenerator.HashWorld());
      Trace.WriteLine((object) passResult);
      foreach (GenPass genPass2 in this.Passes.Skip<GenPass>(num))
      {
        WorldGenSnapshot snapshot2 = this.GetSnapshot(genPass2);
        if (snapshot2 != null && !snapshot2.GenPassResults[num].Matches(passResult))
          this._snapshots.Remove(genPass2);
      }
      bool flag = this.SnapshotFrequency == WorldGenerator.SnapshotFrequency.Always || this.SnapshotFrequency == WorldGenerator.SnapshotFrequency.Automatic && (this.MsSinceLastSnapshot() > 500 || genPass1 != null && genPass1 == this.PauseAfterPass);
      if (passResult.Skipped)
        flag = false;
      if (this.QueuedAbort)
        flag = false;
      if (snapshot1 != null && snapshot1.IsValidHistoryOf(WorldGen.Manifest))
      {
        flag = false;
        if (snapshot1.Outdated)
          snapshot1.ResaveForCurrentVersion();
      }
      if (flag)
        this.TryCreateSnapshot();
      this.CheckLatestPassResultAgainstManifest(num, passResult, snapshot1);
      if (this.PauseAfterPass == this.CurrentPass)
        this.Paused = true;
      if (Main.gameMenu)
        return;
      Main.QueueMainThreadAction(new Action(Main.sectionManager.SetAllFramedSectionsAsNeedingRefresh));
    }

    private void CheckLatestPassResultAgainstManifest(
      int currentPassIndex,
      GenPassResult result,
      WorldGenSnapshot prevSnapshot)
    {
      if (this._previousManifest == null || currentPassIndex >= this._previousManifest.GenPassResults.Count || this._previousManifest.GenPassResults[currentPassIndex].Matches(result))
        return;
      this._previousManifest = (WorldManifest) null;
      string message = $"{this.CurrentPass.Name} output changed since last gen.";
      if (this.PauseOnHashMismatch)
      {
        if (prevSnapshot != null)
        {
          try
          {
            prevSnapshot.Load();
            this.ReportException(message + " The previous output has been loaded as a snapshot (use /swap and /snapshotdiff to compare)");
            goto label_7;
          }
          catch (Exception ex)
          {
            this.ReportException(message + "An attempt was made to load a snapshot of the previous output, but an exception occurred", ex);
            goto label_7;
          }
        }
      }
      this.ReportException(message);
label_7:
      if (!this.PauseOnHashMismatch)
        return;
      this.Paused = true;
      this.PausedDueToHashMismatch = true;
    }

    public void DeleteSnapshot(GenPass pass)
    {
      Utils.TryOperateInLock((object) pass, (Action) (() =>
      {
        WorldGenSnapshot snap;
        if (!this._snapshots.TryGetValue(pass, out snap))
          return;
        this._snapshots.Remove(pass);
        WorldGenSnapshot.Delete(snap);
      }));
    }

    public void DeleteAllSnapshots()
    {
      this.TryOperateInControlLock((Action) (() =>
      {
        this._snapshots.Clear();
        WorldGenSnapshot.DeleteAllForCurrentWorld();
      }));
    }

    private int MsSinceLastSnapshot()
    {
      return WorldGenerator.PassResults.Skip<GenPassResult>(this.Passes.GetRange(0, WorldGenerator.PassResults.Count).FindLastIndex(new Predicate<GenPass>(this._snapshots.ContainsKey)) + 1).Sum<GenPassResult>((Func<GenPassResult, int>) (r => r.DurationMs));
    }

    public void ForceUpdateProgress()
    {
      GenerationProgress progress = this._generator._progress;
      progress.Message = WorldGenerator.PassResults.Count == 0 ? "World Cleared" : "Paused after " + this.Passes[WorldGenerator.PassResults.Count - 1].Name;
      progress.TotalWeight = this.Passes.Where<GenPass>((Func<GenPass, bool>) (p => p.Enabled)).Sum<GenPass>((Func<GenPass, double>) (p => p.Weight));
      progress.TotalWeightedProgress = this.Passes.Take<GenPass>(WorldGenerator.PassResults.Count).Where<GenPass>((Func<GenPass, bool>) (p => p.Enabled)).Sum<GenPass>((Func<GenPass, double>) (p => p.Weight));
    }

    public bool TryOperateInControlLock(Action action)
    {
      return Utils.TryOperateInLock(this._generator._controlLock, action);
    }

    public bool TryCreateSnapshot()
    {
      return this.TryOperateInControlLock((Action) (() =>
      {
        if (!WorldGen.Manifest.FinalHash.HasValue)
        {
          Main.NewText("Pass was not run with worldgen debugging enabled, please re-run", (byte) 240 /*0xF0*/, (byte) 30, (byte) 30);
        }
        else
        {
          uint? finalHash = WorldGen.Manifest.FinalHash;
          uint num = WorldGenerator.HashWorld();
          if (!((int) finalHash.GetValueOrDefault() == (int) num & finalHash.HasValue))
          {
            Main.NewText("World has been modified since last gen pass completed. Please rerun or use /snapshot instead", (byte) 240 /*0xF0*/, (byte) 30, (byte) 30);
          }
          else
          {
            try
            {
              this._snapshots[this.LastCompletedPass] = WorldGenSnapshot.Create();
            }
            catch (Exception ex)
            {
              this.ReportException("Exception occured while creating snapshot", ex);
            }
          }
        }
      }));
    }

    public bool TryReset()
    {
      return this.TryOperateInControlLock((Action) (() =>
      {
        this.UpdatePreviousManifest();
        WorldGen.RestoreTemporaryStateChanges();
        WorldGen.clearWorld();
        WorldGen.Reset();
        this.ForceUpdateProgress();
        this.Paused = true;
        Main.NewText("World Reset", B: (byte) 0);
      }));
    }

    private void UpdatePreviousManifest()
    {
      if (this._previousManifest != null && WorldGenerator.PassResults.Count <= this._previousManifest.GenPassResults.Count)
        return;
      this._previousManifest = WorldGen.Manifest;
    }

    public bool TryResetToSnapshot(GenPass pass)
    {
      WorldGenSnapshot snap = this.GetSnapshot(pass);
      return snap != null && !snap.Outdated && this.TryOperateInControlLock((Action) (() =>
      {
        try
        {
          this.UpdatePreviousManifest();
          snap.Restore();
          this.ForceUpdateProgress();
        }
        catch (Exception ex)
        {
          this.ReportException("Exception occured while restoring snapshot", ex);
        }
      }));
    }

    public bool TryRunToEndOfPass(GenPass pass, bool useSnapshots = true, bool mustRunPass = true)
    {
      if (!pass.Enabled)
        return false;
      int passIndex = this.Passes.IndexOf(pass);
      if (this.TryOperateInControlLock((Action) (() =>
      {
        GenPass pass1 = this.Passes.Take<GenPass>(passIndex + (mustRunPass ? 0 : 1)).Reverse<GenPass>().FirstOrDefault<GenPass>((Func<GenPass, bool>) (p => this.GetSnapshot(p) != null && !this.GetSnapshot(p).Outdated));
        bool flag = passIndex < WorldGenerator.PassResults.Count;
        if (useSnapshots && pass1 != null && (flag || this.Passes.IndexOf(pass1) >= WorldGenerator.PassResults.Count))
          this.TryResetToSnapshot(pass1);
        else if (flag)
          this.TryReset();
        if (WorldGenerator.PassResults.Count == passIndex + 1)
        {
          this.Paused = true;
        }
        else
        {
          this.PauseAfterPass = pass;
          this.Paused = false;
        }
      })))
        return true;
      if (pass != this.CurrentPass && passIndex <= WorldGenerator.PassResults.Count)
        return false;
      this.PauseAfterPass = pass;
      return true;
    }

    public bool TryResetToPreviousPass(GenPass pass)
    {
      GenPass pass1 = this.Passes.Take<GenPass>(this.Passes.IndexOf(pass)).Reverse<GenPass>().FirstOrDefault<GenPass>((Func<GenPass, bool>) (p => p.Enabled));
      return pass1 == null ? this.TryReset() : this.TryRunToEndOfPass(pass1, mustRunPass: false);
    }

    internal void ReportException(string message, Exception ex = null)
    {
      Trace.WriteLine(ex != null ? ex.ToString() : message);
      if (!DebugOptions.enableDebugCommands)
        return;
      this.Paused = true;
      WorldGenerator.SetDebugWorldGenUIVisibility(true);
      UIWorldGenDebug.ActiveInstance.UnhideChat();
      Main.NewText(message, G: (byte) 0, B: (byte) 0);
    }
  }
}
