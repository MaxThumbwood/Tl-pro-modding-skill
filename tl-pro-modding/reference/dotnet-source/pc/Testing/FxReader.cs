// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.FxReader
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Graphics;
using Microsoft.Xna.Framework.Content.Pipeline.Processors;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ReLogic.Content.Readers;
using System;
using System.IO;

#nullable disable
namespace Terraria.Testing;

public class FxReader : IAssetReader
{
  private readonly GraphicsDevice _graphicsDevice;

  public FxReader(GraphicsDevice graphicsDevice) => this._graphicsDevice = graphicsDevice;

  public T FromStream<T>(Stream stream) where T : class
  {
    if (typeof (T) != typeof (Effect))
      throw AssetLoadException.FromInvalidReader<FxReader, T>();
    string end;
    using (StreamReader streamReader = new StreamReader(stream))
      end = streamReader.ReadToEnd();
    EffectProcessor effectProcessor = new EffectProcessor();
    EffectContent input = new EffectContent();
    input.EffectCode = end;
    FxReader.DummyPipelineContext context = new FxReader.DummyPipelineContext();
    return new Effect(this._graphicsDevice, effectProcessor.Process(input, (ContentProcessorContext) context).GetEffectCode()) as T;
  }

  private class DummyPipelineContext : ContentProcessorContext
  {
    private readonly ContentBuildLogger _logger = (ContentBuildLogger) new FxReader.PipelineLogger();

    public override TargetPlatform TargetPlatform => TargetPlatform.Windows;

    public override GraphicsProfile TargetProfile => GraphicsProfile.Reach;

    public override ContentBuildLogger Logger => this._logger;

    public override OpaqueDataDictionary Parameters => throw new NotImplementedException();

    public override string BuildConfiguration => "Release";

    public override string OutputFilename => throw new NotImplementedException();

    public override string OutputDirectory => throw new NotImplementedException();

    public override string IntermediateDirectory => throw new NotImplementedException();

    public override void AddDependency(string filename) => throw new NotImplementedException();

    public override void AddOutputFile(string filename) => throw new NotImplementedException();

    public override TOutput BuildAndLoadAsset<TInput, TOutput>(
      ExternalReference<TInput> sourceAsset,
      string processorName,
      OpaqueDataDictionary processorParameters,
      string importerName)
    {
      throw new NotImplementedException();
    }

    public override ExternalReference<TOutput> BuildAsset<TInput, TOutput>(
      ExternalReference<TInput> sourceAsset,
      string processorName,
      OpaqueDataDictionary processorParameters,
      string importerName,
      string assetName)
    {
      throw new NotImplementedException();
    }

    public override TOutput Convert<TInput, TOutput>(
      TInput input,
      string processorName,
      OpaqueDataDictionary processorParameters)
    {
      throw new NotImplementedException();
    }
  }

  private class PipelineLogger : ContentBuildLogger
  {
    public override void LogImportantMessage(string message, params object[] messageArgs)
    {
    }

    public override void LogMessage(string message, params object[] messageArgs)
    {
    }

    public override void LogWarning(
      string helpLink,
      ContentIdentity contentIdentity,
      string message,
      params object[] messageArgs)
    {
    }
  }
}
