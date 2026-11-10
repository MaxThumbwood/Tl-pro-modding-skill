// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.GenerationProgress
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.WorldBuilding;

public class GenerationProgress
{
  private string _message = "";
  private double _value;
  private double _totalWeightedProgress;
  public double TotalWeight;
  public double CurrentPassWeight = 1.0;

  public string Message
  {
    get => string.Format(this._message, (object) this.Value);
    set => this._message = value.Replace("%", "{0:0.0%}");
  }

  public string MessageNoFormatting
  {
    get => this._message;
    set => this._message = value;
  }

  public double Value
  {
    set => this._value = Utils.Clamp<double>(value, 0.0, 1.0);
    get => this._value;
  }

  public double TotalWeightedProgress
  {
    set => this._totalWeightedProgress = value;
  }

  public double TotalProgress
  {
    get
    {
      return this.TotalWeight == 0.0 ? 0.0 : (this.Value * this.CurrentPassWeight + this._totalWeightedProgress) / this.TotalWeight;
    }
  }

  public void Set(double value) => this.Value = value;

  public void Set(double value, double min, double max) => this.Value = min + value * (max - min);

  public void Start(double weight)
  {
    this.CurrentPassWeight = weight;
    this._value = 0.0;
  }

  public void End()
  {
    this._totalWeightedProgress += this.CurrentPassWeight;
    this._value = 0.0;
  }
}
