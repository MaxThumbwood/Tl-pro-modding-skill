// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.NPCInteractions
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.Audio;
using Terraria.GameContent.Achievements;
using Terraria.ID;
using Terraria.Localization;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent;

public class NPCInteractions
{
  public static List<NPCInteraction> All = new List<NPCInteraction>();

  public static void Initialize()
  {
    NPCInteractions.Shop(17, 1);
    NPCInteractions.Shop(19, 2);
    NPCInteractions.Shop(20, 3);
    NPCInteractions.Shop(38, 4);
    NPCInteractions.Shop(54, 5);
    NPCInteractions.Shop(107, 6);
    NPCInteractions.Shop(108, 7);
    NPCInteractions.Shop(124, 8);
    NPCInteractions.Shop(142, 9);
    NPCInteractions.Shop(160 /*0xA0*/, 10);
    NPCInteractions.Shop(178, 11);
    NPCInteractions.Shop(207, 12);
    NPCInteractions.Shop(208 /*0xD0*/, 13);
    NPCInteractions.Shop(209, 14);
    NPCInteractions.Shop(227, 15);
    NPCInteractions.Shop(228, 16 /*0x10*/);
    NPCInteractions.Shop(229, 17);
    NPCInteractions.Shop(353, 18);
    NPCInteractions.Shop(368, 19);
    NPCInteractions.Shop(453, 20);
    NPCInteractions.Shop(550, 21);
    NPCInteractions.Shop(588, 22);
    NPCInteractions.Shop(633, 23);
    NPCInteractions.Shop(663, 24);
    NPCInteractions.Shop(227, 25, "GameUI.PainterDecor");
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.TaxCollectorCollectTaxes());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.NurseHeal());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.CloseChat());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.OpenSign());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.StardewValleyBit());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.DryadPurification());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.AnglerQuest());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.PetAnimal());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.OldManCurse());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.GuideTip());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.PartyGirlMusicSwap());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.GuideReverseCrafting());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.TinkererReforge());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.StylistHairWindow());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.DyeTraderRarePlant());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.TavernkeepAdvice());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.ReportHappiness());
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.RequestHome());
  }

  private static void Shop(int npcType, int shopIndex, string customTextKey = null)
  {
    NPCInteractions.Register((NPCInteraction) new NPCInteractions.Actions.OpenShop(npcType, shopIndex, customTextKey));
  }

  private static void Register(NPCInteraction interaction) => NPCInteractions.All.Add(interaction);

  public static class Actions
  {
    public class OpenSign : NPCInteraction
    {
      public override bool Condition() => this.LocalPlayer.sign > -1;

      public override string GetText()
      {
        return Main.editSign ? Lang.inter[47].Value : Lang.inter[48 /*0x30*/].Value;
      }

      public override void Interact()
      {
        if (Main.editSign)
          Main.SubmitSignText();
        else
          IngameFancyUI.OpenVirtualKeyboard(1);
      }
    }

    public class OpenShop : NPCInteraction
    {
      private int _shopIndex;
      private int _npcType;
      private string _customTextKey;

      public OpenShop(int npcType, int shopIndex, string customTextKey = null)
      {
        this._npcType = npcType;
        this._shopIndex = shopIndex;
        this._customTextKey = customTextKey;
      }

      public override bool Condition() => this.TalkNPCType == this._npcType;

      public override string GetText()
      {
        return this._customTextKey != null ? Language.GetTextValue(this._customTextKey) : Lang.inter[28].Value;
      }

      public override void Interact() => Main.instance.OpenShop(this._shopIndex);
    }

    public class StardewValleyBit : NPCInteraction
    {
      public override bool ShowExcalmation => true;

      public override bool Condition()
      {
        return this.TalkNPCType == 20 && Main.CanDryadPlayStardewAnimation(this.LocalPlayer, this.TalkNPC);
      }

      public override string GetText() => Language.GetTextValue("StardewTalk.GiveColaButtonText");

      public override void Interact()
      {
        Main.DoNPCPortraitHop();
        SoundEngine.PlaySound(12);
        Main.DryadText_Do_StardewValleyBit();
      }
    }

    public class DryadPurification : NPCInteraction
    {
      public override bool Condition()
      {
        return this.TalkNPCType == 20 && !Main.CanDryadPlayStardewAnimation(this.LocalPlayer, this.TalkNPC);
      }

      public override string GetText() => Lang.inter[49].Value;

      public override void Interact()
      {
        Main.DoNPCPortraitHop();
        SoundEngine.PlaySound(12);
        bool worldIsEntirelyPure;
        Main.npcChatText = Lang.GetDryadWorldStatusDialog(out worldIsEntirelyPure);
        if (!worldIsEntirelyPure)
          return;
        AchievementsHelper.HandleSpecialEvent(this.LocalPlayer, 27);
      }
    }

    public class AnglerQuest : NPCInteraction
    {
      public override bool ShowExcalmation => true;

      public override bool Condition() => this.TalkNPCType == 369;

      public override string GetText() => Lang.inter[64 /*0x40*/].Value;

      public override void Interact() => Main.NPCChatText_DoAnglerQuest();
    }

    public class PetAnimal : NPCInteraction
    {
      public override bool Condition() => NPCID.Sets.IsTownPet[this.TalkNPCType];

      public override string GetText() => Language.GetTextValue("UI.PetTheAnimal");

      public override void Interact()
      {
        this.LocalPlayer.PetAnimal(Main.npc[this.LocalPlayer.talkNPC].GetPettingInfo(this.LocalPlayer));
      }
    }

    public class OldManCurse : NPCInteraction
    {
      public override bool Condition() => this.TalkNPCType == 37 && !Main.IsItDay();

      public override string GetText() => Lang.inter[50].Value;

      public override void Interact()
      {
        if (Main.netMode == 0)
          NPC.SpawnSkeletron(Main.myPlayer);
        else
          NetMessage.SendData(51, number: Main.myPlayer, number2: 1f);
        Main.npcChatText = "";
      }
    }

    public class GuideTip : NPCInteraction
    {
      public override bool Condition() => this.TalkNPCType == 22;

      public override string GetText() => Lang.inter[51].Value;

      public override void Interact()
      {
        SoundEngine.PlaySound(12);
        Main.HelpText();
        Main.DoNPCPortraitHop();
      }
    }

    public class TaxCollectorCollectTaxes : NPCInteraction
    {
      public override bool Condition() => this.TalkNPCType == 441;

      public override string GetText() => Lang.inter[89].Value;

      public override void Interact() => Main.NPCChatText_DoTaxCollector();

      public override bool TryAddCoins(ref Color chatColor, out int coinValue)
      {
        coinValue = 0;
        Main.GetCoinValueText_TaxCollector(ref chatColor, ref coinValue);
        return coinValue > 0;
      }
    }

    public class NurseHeal : NPCInteraction
    {
      public override bool Condition() => this.TalkNPCType == 18;

      public override string GetText() => Lang.inter[54].Value;

      public override void Interact() => Main.NPCChatText_DoNurseHeal(Main.GetNurseHealCost());

      public override bool TryAddCoins(ref Color chatColor, out int coinValue)
      {
        coinValue = Main.GetNurseHealCost();
        Main.GetCoinValueText_Nurse(ref chatColor, ref coinValue);
        return coinValue > 0;
      }
    }

    public class CloseChat : NPCInteraction
    {
      public override bool Condition() => true;

      public override string GetText() => Lang.inter[52].Value;

      public override void Interact() => Main.CloseNPCChatOrSign();
    }

    public class ReportHappiness : NPCInteraction
    {
      public override bool Condition()
      {
        return !NPC.CanShowHomelessText(Main.LocalPlayer.talkNPC) && this.LocalPlayer.currentShoppingSettings.HappinessReport != "";
      }

      public override string GetText() => Language.GetTextValue("UI.NPCCheckHappiness");

      public override void Interact()
      {
        Main.npcChatCornerItem = 0;
        SoundEngine.PlaySound(12);
        Main.npcChatText = this.LocalPlayer.currentShoppingSettings.HappinessReport;
        Main.DoNPCPortraitHop();
      }
    }

    public class RequestHome : NPCInteraction
    {
      public override bool ShowExcalmation => true;

      public override bool Condition() => NPC.CanShowHomelessText(Main.LocalPlayer.talkNPC);

      public override string GetText() => Language.GetTextValue("UI.NPCHousing");

      public override void Interact()
      {
        Main.npcChatCornerItem = -1;
        SoundEngine.PlaySound(12);
        Main.DoNPCPortraitHop();
        NPC talkNpc = this.TalkNPC;
        string str = "TownNPCMood_" + NPCID.Search.GetName(talkNpc.netID);
        if (talkNpc.type == 633 && talkNpc.altTexture == 2)
          str += "Transformed";
        if (talkNpc.type == 638)
          str = "DogChatter";
        else if (talkNpc.type == 637)
          str = "CatChatter";
        else if (talkNpc.type == 656)
          str = "BunnyChatter";
        else if (NPCID.Sets.IsTownSlime[talkNpc.type])
          str = $"Slime{Lang.GetSlimeType(talkNpc)}Chatter";
        Main.npcChatText = Language.GetTextValue(str + ".NoHome");
        Main.npcChatText += "\n\n";
        if (talkNpc.type == 160 /*0xA0*/)
          Main.npcChatText += Language.GetTextValueWith("HousingText.HousingRequirements_Truffle", (object) new
          {
            NPCName = talkNpc.FullName
          });
        else
          Main.npcChatText += Language.GetTextValue("HousingText.HousingRequirements");
      }
    }

    public class PartyGirlMusicSwap : NPCInteraction
    {
      public override bool Condition() => this.TalkNPCType == 208 /*0xD0*/;

      public override string GetText() => Language.GetTextValue("GameUI.Music");

      public override void Interact() => Main.NPCChatText_PartyGirlSwapMusic();
    }

    public class GuideReverseCrafting : NPCInteraction
    {
      public override bool Condition() => this.TalkNPCType == 22;

      public override string GetText() => Lang.inter[25].Value;

      public override void Interact() => Main.NPCChatText_GuideReverseCrafting();
    }

    public class TinkererReforge : NPCInteraction
    {
      public override bool Condition() => this.TalkNPCType == 107;

      public override string GetText() => Lang.inter[19].Value;

      public override void Interact() => Main.NPCChatText_TinkererReforge();
    }

    public class StylistHairWindow : NPCInteraction
    {
      public override bool Condition() => this.TalkNPCType == 353;

      public override string GetText() => Language.GetTextValue("GameUI.HairStyle");

      public override void Interact() => Main.OpenHairWindow();
    }

    public class DyeTraderRarePlant : NPCInteraction
    {
      public override bool Condition() => this.TalkNPCType == 207 && Main.hardMode;

      public override string GetText() => Lang.inter[107].Value;

      public override void Interact() => Main.NPCChatText_DyeTraderRarePlant();
    }

    public class TavernkeepAdvice : NPCInteraction
    {
      public override bool Condition() => this.TalkNPCType == 550;

      public override string GetText() => Language.GetTextValue("UI.BartenderHelp");

      public override void Interact() => Main.NPCChatText_TavernkeepAdvice();
    }
  }
}
