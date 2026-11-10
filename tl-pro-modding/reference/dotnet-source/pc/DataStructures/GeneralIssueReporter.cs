// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.GeneralIssueReporter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.DataStructures;

public class GeneralIssueReporter : IProvideReports
{
  private List<IssueReport> _reports = new List<IssueReport>();

  public void AddReport(string textToShow) => this._reports.Add(new IssueReport(textToShow));

  public List<IssueReport> GetReports() => this._reports;
}
