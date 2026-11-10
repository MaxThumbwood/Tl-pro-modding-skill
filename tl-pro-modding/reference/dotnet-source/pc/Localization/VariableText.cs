// Decompiled with JetBrains decompiler
// Type: Terraria.Localization.VariableText
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

#nullable disable
namespace Terraria.Localization;

internal class VariableText
{
  private readonly string _original;
  private readonly string _format;
  private readonly VariableText.Condition[] _conditions;
  private readonly string[] _variables;
  private readonly object[] _formatArgBuffer;
  private readonly StringBuilder _formatBuffer = new StringBuilder();
  private static readonly Regex _substitutionRegex = new Regex("{(\\?!?)?([a-zA-Z][\\w\\.]*)}", RegexOptions.Compiled);

  private VariableText(
    string original,
    string format,
    VariableText.Condition[] conditions,
    string[] variables)
  {
    this._original = original;
    this._format = format;
    this._conditions = conditions;
    this._variables = variables;
    this._formatArgBuffer = new object[variables.Length];
  }

  public static bool TryCreate(string s, out VariableText text)
  {
    if (!VariableText._substitutionRegex.IsMatch(s))
    {
      text = (VariableText) null;
      return false;
    }
    List<string> variables = new List<string>();
    List<VariableText.Condition> conditions = new List<VariableText.Condition>();
    string format = VariableText._substitutionRegex.Replace(s, (MatchEvaluator) (match =>
    {
      string str1 = match.Groups[2].ToString();
      string str2 = match.Groups[1].ToString();
      if (str2 != "")
      {
        conditions.Add(new VariableText.Condition()
        {
          Name = str1,
          RequiredValue = str2 == "?"
        });
        return "";
      }
      int num = variables.IndexOf(str1);
      if (num < 0)
      {
        num = variables.Count;
        variables.Add(str1);
      }
      return $"{{{(object) num}}}";
    }));
    text = new VariableText(s, format, conditions.ToArray(), variables.ToArray());
    return true;
  }

  private bool CheckConditionsAndLoadArgs(Func<string, object> lookup)
  {
    foreach (VariableText.Condition condition in this._conditions)
    {
      if (((int) (lookup(condition.Name) as bool?) ?? 0) != (condition.RequiredValue ? 1 : 0))
        return false;
    }
    for (int index = 0; index < this._variables.Length; ++index)
    {
      object obj = lookup(this._variables[index]);
      if (obj == null)
        return false;
      this._formatArgBuffer[index] = obj;
    }
    return true;
  }

  public bool ConditionsMet(Func<string, object> lookup) => this.CheckConditionsAndLoadArgs(lookup);

  public bool TryFormat(Func<string, object> lookup, out string formatted)
  {
    if (!this.CheckConditionsAndLoadArgs(lookup))
    {
      formatted = (string) null;
      return false;
    }
    this._formatBuffer.AppendFormat(this._format, this._formatArgBuffer);
    formatted = this._formatBuffer.ToString();
    this._formatBuffer.Clear();
    return true;
  }

  public override string ToString() => this._original;

  private struct Condition
  {
    public bool RequiredValue;
    public string Name;
  }
}
