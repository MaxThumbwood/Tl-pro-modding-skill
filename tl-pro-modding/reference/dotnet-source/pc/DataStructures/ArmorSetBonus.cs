// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.ArmorSetBonus
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using Terraria.Localization;

#nullable disable
namespace Terraria.DataStructures;

public class ArmorSetBonus
{
  public ArmorSetBonus.ArmorSetEffect Effect;
  public LocalizedText Description;
  public int Head;
  public int Body;
  public int Legs;
  public ArmorSetBonus.PartType PrimaryPart;
  private static LocalizedText ItemSetBonusEquipped = Language.GetText("UI.ItemSetBonusEquipped");
  private static LocalizedText ItemSetBonusGeneral = Language.GetText("UI.ItemSetBonusGeneral");
  private static LocalizedText[] ItemSetBonusDecidedBy = new LocalizedText[4]
  {
    null,
    Language.GetText("UI.ItemSetBonusDecidedByHead"),
    Language.GetText("UI.ItemSetBonusDecidedByBody"),
    Language.GetText("UI.ItemSetBonusDecidedByLegs")
  };

  public int GetPart(ArmorSetBonus.PartType part)
  {
    switch (part)
    {
      case ArmorSetBonus.PartType.Head:
        return this.Head;
      case ArmorSetBonus.PartType.Body:
        return this.Body;
      case ArmorSetBonus.PartType.Legs:
        return this.Legs;
      default:
        return 0;
    }
  }

  public ArmorSetBonus.QueryResult QueryCount(ArmorSetBonus.QueryContext context)
  {
    ArmorSetBonus.QueryResult queryResult = new ArmorSetBonus.QueryResult();
    this.TryCounting(context.HeadItem, this.Head, ref queryResult.ItemsFound, ref queryResult.ItemsNeeded);
    this.TryCounting(context.BodyItem, this.Body, ref queryResult.ItemsFound, ref queryResult.ItemsNeeded);
    this.TryCounting(context.LegItem, this.Legs, ref queryResult.ItemsFound, ref queryResult.ItemsNeeded);
    return queryResult;
  }

  private void TryCounting(
    int testedItem,
    int neededItem,
    ref int foundItemCount,
    ref int neededItemCount)
  {
    if (neededItem == 0)
      return;
    ++neededItemCount;
    if (testedItem != neededItem)
      return;
    ++foundItemCount;
  }

  public string GetTooltipForSinglePiece(int itemType)
  {
    LocalizedText description = this.Description;
    if (this.PrimaryPart != ArmorSetBonus.PartType.None && this.GetPart(this.PrimaryPart) != itemType)
      description = ArmorSetBonus.ItemSetBonusDecidedBy[(int) this.PrimaryPart];
    return ArmorSetBonus.ItemSetBonusGeneral.FormatWith((object) new ArmorSetBonus.SetBonusDisplayStringSubstitutes()
    {
      Description = description
    });
  }

  public string GetTooltipForWornArmor(
    ArmorSetBonus.QueryContext context,
    ArmorSetBonus.QueryResult result)
  {
    LocalizedText description = this.Description;
    if (this.PrimaryPart != ArmorSetBonus.PartType.None && context.GetPart(this.PrimaryPart) != this.GetPart(this.PrimaryPart))
      description = ArmorSetBonus.ItemSetBonusDecidedBy[(int) this.PrimaryPart];
    return ArmorSetBonus.ItemSetBonusEquipped.FormatWith((object) new ArmorSetBonus.SetBonusDisplayStringSubstitutes()
    {
      Description = description,
      Numerator = result.ItemsFound,
      Denominator = result.ItemsNeeded
    });
  }

  public static ArmorSetBonus.Builder Create(
    ArmorSetBonus.ArmorSetEffect effect,
    string textKey,
    ArmorSetBonus.PartType primaryPart = ArmorSetBonus.PartType.None)
  {
    return new ArmorSetBonus.Builder(effect, textKey, primaryPart);
  }

  public delegate void ArmorSetEffect(Player player);

  public enum PartType
  {
    None,
    Head,
    Body,
    Legs,
  }

  public struct QueryContext
  {
    public int HeadItem;
    public int BodyItem;
    public int LegItem;

    public QueryContext(Player player)
    {
      this.HeadItem = ArmorSetBonus.QueryContext.TryGetType(player.armor[0]);
      this.BodyItem = ArmorSetBonus.QueryContext.TryGetType(player.armor[1]);
      this.LegItem = ArmorSetBonus.QueryContext.TryGetType(player.armor[2]);
    }

    private static int TryGetType(Item item) => item != null ? item.type : 0;

    public int GetPart(ArmorSetBonus.PartType part)
    {
      switch (part)
      {
        case ArmorSetBonus.PartType.Head:
          return this.HeadItem;
        case ArmorSetBonus.PartType.Body:
          return this.BodyItem;
        case ArmorSetBonus.PartType.Legs:
          return this.LegItem;
        default:
          return 0;
      }
    }
  }

  public struct QueryResult
  {
    public int ItemsNeeded;
    public int ItemsFound;

    public bool Complete => this.ItemsNeeded == this.ItemsFound;
  }

  private class SetBonusDisplayStringSubstitutes
  {
    public int Numerator { get; set; }

    public int Denominator { get; set; }

    public LocalizedText Description { get; set; }
  }

  public class Builder
  {
    private ArmorSetBonus.ArmorSetEffect Effect;
    private string TextKey;
    private ArmorSetBonus.PartType PrimaryPart;
    private List<ArmorSetBonus.Builder.Parts> _sets = new List<ArmorSetBonus.Builder.Parts>();

    public Builder(
      ArmorSetBonus.ArmorSetEffect effect,
      string textKey,
      ArmorSetBonus.PartType primaryPart)
    {
      this.Effect = effect;
      this.TextKey = textKey;
      this.PrimaryPart = primaryPart;
    }

    public ArmorSetBonus.Builder Set(int head, int body, int legs)
    {
      this._sets.Add(new ArmorSetBonus.Builder.Parts()
      {
        Head = head,
        Body = body,
        Legs = legs
      });
      return this;
    }

    public ArmorSetBonus.Builder Set(int[] headOptions, int[] bodyOptions, int[] legsOptions)
    {
      if (headOptions == null)
        headOptions = new int[1];
      if (bodyOptions == null)
        bodyOptions = new int[1];
      if (legsOptions == null)
        legsOptions = new int[1];
      foreach (int headOption in headOptions)
      {
        foreach (int bodyOption in bodyOptions)
        {
          foreach (int legsOption in legsOptions)
            this.Set(headOption, bodyOption, legsOption);
        }
      }
      return this;
    }

    public void Add()
    {
      foreach (ArmorSetBonus.Builder.Parts set in this._sets)
        ArmorSetBonuses.All.Add(new ArmorSetBonus()
        {
          Effect = this.Effect,
          Description = Language.GetText(this.TextKey),
          Head = set.Head,
          Body = set.Body,
          Legs = set.Legs,
          PrimaryPart = this.PrimaryPart
        });
    }

    private struct Parts
    {
      public int Head;
      public int Body;
      public int Legs;
    }
  }
}
