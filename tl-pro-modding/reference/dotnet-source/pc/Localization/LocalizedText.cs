// Decompiled with JetBrains decompiler
// Type: Terraria.Localization.LocalizedText
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;

#nullable disable
namespace Terraria.Localization;

public class LocalizedText
{
  public static readonly LocalizedText Empty = new LocalizedText("", "");
  private static Regex _substitutionRegex = new Regex("{(\\?(?:!)?)?([a-zA-Z][\\w\\.]*)}", RegexOptions.Compiled);
  public readonly string Key;
  private object _value;
  private static Dictionary<Type, PropertyDescriptorCollection> _propertyLookupCache = new Dictionary<Type, PropertyDescriptorCollection>();

  public string Value
  {
    get
    {
      string formatted;
      return this._value is VariableText variableText && variableText.TryFormat(new Func<string, object>(Lang.GetGlobalSubstitution), out formatted) ? formatted : this._value.ToString();
    }
  }

  public string UnformattedValue => this._value.ToString();

  public string EnglishValue { get; private set; }

  public bool HasValue => this.EnglishValue != this.Key;

  public bool ConditionsMet
  {
    get
    {
      return !(this._value is VariableText variableText) || variableText.ConditionsMet(new Func<string, object>(Lang.GetGlobalSubstitution));
    }
  }

  internal LocalizedText(string key, string text)
  {
    this.Key = key;
    this.SetValue(text);
  }

  internal void SetValue(string value)
  {
    this._value = value != null ? (object) value : throw new ArgumentNullException(nameof (value));
    if (LanguageManager.Instance != null && LanguageManager.Instance.ActiveCulture == GameCulture.DefaultCulture)
      this.EnglishValue = value;
    VariableText text;
    if (!VariableText.TryCreate(value, out text))
      return;
    this._value = (object) text;
  }

  public bool GetValueIfConditionsMet(out string formatted)
  {
    if (this._value is VariableText variableText)
      return variableText.TryFormat(new Func<string, object>(Lang.GetGlobalSubstitution), out formatted);
    formatted = this.Value;
    return true;
  }

  public bool TryFormatWith(object obj, out string formatted)
  {
    if (this._value is VariableText variableText)
      return variableText.TryFormat(LocalizedText.GetPropertyLookupFunc(obj), out formatted);
    formatted = this.Value;
    return true;
  }

  public bool TryFormatWith(Func<string, object> lookup, out string formatted)
  {
    if (this._value is VariableText variableText)
      return variableText.TryFormat(lookup, out formatted);
    formatted = this.Value;
    return true;
  }

  public string FormatWith(object obj)
  {
    string formatted;
    return !this.TryFormatWith(obj, out formatted) ? this.Value : formatted;
  }

  public string FormatWith(Func<string, object> lookup)
  {
    string formatted;
    return !this.TryFormatWith(lookup, out formatted) ? this.Value : formatted;
  }

  public bool ConditionsMetWith(object obj)
  {
    return !(this._value is VariableText variableText) || variableText.ConditionsMet(LocalizedText.GetPropertyLookupFunc(obj));
  }

  public bool ConditionsMetWith(Func<string, object> lookup)
  {
    return !(this._value is VariableText variableText) || variableText.ConditionsMet(lookup);
  }

  public NetworkText ToNetworkText() => NetworkText.FromKey(this.Key);

  public NetworkText ToNetworkText(params object[] substitutions)
  {
    return NetworkText.FromKey(this.Key, substitutions);
  }

  public static explicit operator string(LocalizedText text) => text.Value;

  public string Format(object arg0) => string.Format(this.Value, arg0);

  public string Format(object arg0, object arg1) => string.Format(this.Value, arg0, arg1);

  public string Format(object arg0, object arg1, object arg2)
  {
    return string.Format(this.Value, arg0, arg1, arg2);
  }

  public string Format(params object[] args) => string.Format(this.Value, args);

  public override string ToString() => this.Value;

  public bool EqualsCommand(string text)
  {
    text = text.ToLower();
    return text == this.Value || text == this.EnglishValue;
  }

  public bool ParseCommandPrefix(string text, out string remainder)
  {
    return Utils.ParseCommandPrefix(text, this.Value, out remainder) || Utils.ParseCommandPrefix(text, this.EnglishValue, out remainder);
  }

  private static Func<string, object> GetPropertyLookupFunc(object inst)
  {
    Type type = inst.GetType();
    PropertyDescriptorCollection properties;
    if (!LocalizedText._propertyLookupCache.TryGetValue(type, out properties))
      LocalizedText._propertyLookupCache[type] = properties = TypeDescriptor.GetProperties(type);
    return (Func<string, object>) (name =>
    {
      PropertyDescriptor propertyDescriptor = properties[name];
      return propertyDescriptor != null ? propertyDescriptor.GetValue(inst) : Lang.GetGlobalSubstitution(name);
    });
  }
}
