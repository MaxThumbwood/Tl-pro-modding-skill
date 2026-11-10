using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.UI;

namespace Terraria.GameContent
{
	// Token: 0x0200099D RID: 2461
	[Token(Token = "0x200099D")]
	public static class LucyAxeMessage
	{
		// Token: 0x060050EA RID: 20714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050EA")]
		[Address(RVA = "0x774EF0", Offset = "0x774EF0", VA = "0x774EF0")]
		private static string GetCategoryName(LucyAxeMessage.MessageSource source)
		{
			return null;
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050EB")]
		[Address(RVA = "0x774FC0", Offset = "0x774FC0", VA = "0x774FC0")]
		public static void Initialize()
		{
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050EC")]
		[Address(RVA = "0x7750F8", Offset = "0x7750F8", VA = "0x7750F8")]
		private static void Hooks_OnEnterWorld(Player player)
		{
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050ED")]
		[Address(RVA = "0x7752C0", Offset = "0x7752C0", VA = "0x7752C0")]
		public static void UpdateMessageCooldowns()
		{
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050EE")]
		[Address(RVA = "0x7753C0", Offset = "0x7753C0", VA = "0x7753C0")]
		public static void TryPlayingIdleMessage()
		{
		}

		// Token: 0x060050EF RID: 20719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050EF")]
		[Address(RVA = "0x775864", Offset = "0x775864", VA = "0x775864")]
		private static void ItemSlot_OnItemTransferred(ItemSlot.ItemTransferInfo info)
		{
		}

		// Token: 0x060050F0 RID: 20720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F0")]
		[Address(RVA = "0x7751A0", Offset = "0x7751A0", VA = "0x7751A0")]
		private static void GiveIdleMessageCooldown()
		{
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F1")]
		[Address(RVA = "0x775AD0", Offset = "0x775AD0", VA = "0x775AD0")]
		public static void PutMessageTypeOnCooldown(LucyAxeMessage.MessageSource source, int timeInFrames)
		{
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x00025A28 File Offset: 0x00023C28
		[Token(Token = "0x60050F2")]
		[Address(RVA = "0x775AAC", Offset = "0x775AAC", VA = "0x775AAC")]
		private static bool CountsAsStorage(int itemSlotContext)
		{
			return default(bool);
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F3")]
		[Address(RVA = "0x775B50", Offset = "0x775B50", VA = "0x775B50")]
		public static void TryCreatingMessageWithCooldown(LucyAxeMessage.MessageSource messageSource, Vector2 position, Vector2 velocity, int cooldownTimeInTicks)
		{
		}

		// Token: 0x060050F4 RID: 20724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F4")]
		[Address(RVA = "0x77557C", Offset = "0x77557C", VA = "0x77557C")]
		public static void Create(LucyAxeMessage.MessageSource source, Vector2 position, Vector2 velocity)
		{
		}

		// Token: 0x060050F5 RID: 20725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F5")]
		[Address(RVA = "0x775EA8", Offset = "0x775EA8", VA = "0x775EA8")]
		private static void SpawnEmoteBubble()
		{
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F6")]
		[Address(RVA = "0x775F0C", Offset = "0x775F0C", VA = "0x775F0C")]
		public static void CreateFromNet(LucyAxeMessage.MessageSource source, byte variation, Vector2 position, Vector2 velocity)
		{
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F7")]
		[Address(RVA = "0x775E14", Offset = "0x775E14", VA = "0x775E14")]
		private static void PlaySound(LucyAxeMessage.MessageSource source, Vector2 position)
		{
		}

		// Token: 0x060050F8 RID: 20728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F8")]
		[Address(RVA = "0x775CCC", Offset = "0x775CCC", VA = "0x775CCC")]
		private static void SpawnPopupText(LucyAxeMessage.MessageSource source, int variationUnwrapped, Vector2 position, Vector2 velocity)
		{
		}

		// Token: 0x060050F9 RID: 20729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050F9")]
		[Address(RVA = "0x77601C", Offset = "0x77601C", VA = "0x77601C")]
		private static string GetTextForVariation(LucyAxeMessage.MessageSource source, int variationUnwrapped)
		{
			return null;
		}

		// Token: 0x040094BB RID: 38075
		[Token(Token = "0x40094BB")]
		[FieldOffset(Offset = "0x0")]
		private static byte _variation;

		// Token: 0x040094BC RID: 38076
		[Token(Token = "0x40094BC")]
		[FieldOffset(Offset = "0x4")]
		private static int[] _messageCooldownsByType;

		// Token: 0x0200099E RID: 2462
		[Token(Token = "0x200099E")]
		public enum MessageSource
		{
			// Token: 0x040094BE RID: 38078
			[Token(Token = "0x40094BE")]
			Idle,
			// Token: 0x040094BF RID: 38079
			[Token(Token = "0x40094BF")]
			Storage,
			// Token: 0x040094C0 RID: 38080
			[Token(Token = "0x40094C0")]
			ThrownAway,
			// Token: 0x040094C1 RID: 38081
			[Token(Token = "0x40094C1")]
			PickedUp,
			// Token: 0x040094C2 RID: 38082
			[Token(Token = "0x40094C2")]
			ChoppedTree,
			// Token: 0x040094C3 RID: 38083
			[Token(Token = "0x40094C3")]
			ChoppedGemTree,
			// Token: 0x040094C4 RID: 38084
			[Token(Token = "0x40094C4")]
			ChoppedCactus,
			// Token: 0x040094C5 RID: 38085
			[Token(Token = "0x40094C5")]
			Count
		}
	}
}
