using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000D25 RID: 3365
	[Token(Token = "0x2000D25")]
	public class EmoteBubble
	{
		// Token: 0x060063E9 RID: 25577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E9")]
		[Address(RVA = "0xB0AE88", Offset = "0xB0AE88", VA = "0xB0AE88")]
		public static void UpdateAll()
		{
		}

		// Token: 0x060063EA RID: 25578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063EA")]
		[Address(RVA = "0xB0B570", Offset = "0xB0B570", VA = "0xB0B570")]
		public static void DrawAll(SpriteBatch sb)
		{
		}

		// Token: 0x060063EB RID: 25579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063EB")]
		[Address(RVA = "0xB0C034", Offset = "0xB0C034", VA = "0xB0C034")]
		public static Tuple<int, int> SerializeNetAnchor(WorldUIAnchor anch)
		{
			return null;
		}

		// Token: 0x060063EC RID: 25580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063EC")]
		[Address(RVA = "0xB0C1B4", Offset = "0xB0C1B4", VA = "0xB0C1B4")]
		public static WorldUIAnchor DeserializeNetAnchor(int type, int meta)
		{
			return null;
		}

		// Token: 0x060063ED RID: 25581 RVA: 0x0002DCD8 File Offset: 0x0002BED8
		[Token(Token = "0x60063ED")]
		[Address(RVA = "0xB0C360", Offset = "0xB0C360", VA = "0xB0C360")]
		public static int AssignNewID()
		{
			return 0;
		}

		// Token: 0x060063EE RID: 25582 RVA: 0x0002DCF0 File Offset: 0x0002BEF0
		[Token(Token = "0x60063EE")]
		[Address(RVA = "0xB0C3CC", Offset = "0xB0C3CC", VA = "0xB0C3CC")]
		public static bool ShouldFilterPlayerEmote(Player player, int emoticon)
		{
			return default(bool);
		}

		// Token: 0x060063EF RID: 25583 RVA: 0x0002DD08 File Offset: 0x0002BF08
		[Token(Token = "0x60063EF")]
		[Address(RVA = "0xB0C690", Offset = "0xB0C690", VA = "0xB0C690")]
		public static int NewLocalOnlyBubble(int emoticon, WorldUIAnchor bubbleAnchor, int time)
		{
			return 0;
		}

		// Token: 0x060063F0 RID: 25584 RVA: 0x0002DD20 File Offset: 0x0002BF20
		[Token(Token = "0x60063F0")]
		[Address(RVA = "0xB0CB04", Offset = "0xB0CB04", VA = "0xB0CB04")]
		public static int NewBubble(int emoticon, WorldUIAnchor bubbleAnchor, int time)
		{
			return 0;
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x0002DD38 File Offset: 0x0002BF38
		[Token(Token = "0x60063F1")]
		[Address(RVA = "0xB0CE88", Offset = "0xB0CE88", VA = "0xB0CE88")]
		public static int NewBubbleNPC(WorldUIAnchor bubbleAnchor, int time, [Optional] WorldUIAnchor other)
		{
			return 0;
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F2")]
		[Address(RVA = "0xB0D75C", Offset = "0xB0D75C", VA = "0xB0D75C")]
		public static void CheckForNPCsToReactToEmoteBubble(int emoteID, Player player)
		{
		}

		// Token: 0x060063F3 RID: 25587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F3")]
		[Address(RVA = "0xB0C794", Offset = "0xB0C794", VA = "0xB0C794")]
		public EmoteBubble(int emotion, WorldUIAnchor bubbleAnchor, int time = 180)
		{
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F4")]
		[Address(RVA = "0xB0B528", Offset = "0xB0B528", VA = "0xB0B528")]
		private void Update()
		{
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F5")]
		[Address(RVA = "0xB0DA64", Offset = "0xB0DA64", VA = "0xB0DA64")]
		public static void DrawTemporaryBubble(SpriteBatch spritebatch, int emoteId, int maxLifetime, int currentLifetime, Entity anchor)
		{
		}

		// Token: 0x060063F6 RID: 25590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F6")]
		[Address(RVA = "0xB0B844", Offset = "0xB0B844", VA = "0xB0B844")]
		public void Draw(SpriteBatch sb)
		{
		}

		// Token: 0x060063F7 RID: 25591 RVA: 0x0002DD50 File Offset: 0x0002BF50
		[Token(Token = "0x60063F7")]
		[Address(RVA = "0xB0DBD4", Offset = "0xB0DBD4", VA = "0xB0DBD4")]
		private Vector2 GetPosition(out SpriteEffects effect)
		{
			return default(Vector2);
		}

		// Token: 0x060063F8 RID: 25592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F8")]
		[Address(RVA = "0xB0C7C4", Offset = "0xB0C7C4", VA = "0xB0C7C4")]
		public static void OnBubbleChange(int bubbleID)
		{
		}

		// Token: 0x060063F9 RID: 25593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F9")]
		[Address(RVA = "0xB0E248", Offset = "0xB0E248", VA = "0xB0E248")]
		public static void MakeLocalPlayerEmote(int emoteId)
		{
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FA")]
		[Address(RVA = "0xB0D134", Offset = "0xB0D134", VA = "0xB0D134")]
		public void PickNPCEmote([Optional] WorldUIAnchor other)
		{
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FB")]
		[Address(RVA = "0xB17160", Offset = "0xB17160", VA = "0xB17160")]
		private void ProbeCombat(List<int> list)
		{
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FC")]
		[Address(RVA = "0xB12940", Offset = "0xB12940", VA = "0xB12940")]
		private void ProbeWeather(List<int> list, Player plr)
		{
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FD")]
		[Address(RVA = "0xB1206C", Offset = "0xB1206C", VA = "0xB1206C")]
		private void ProbeEvents(List<int> list)
		{
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FE")]
		[Address(RVA = "0xB11B2C", Offset = "0xB11B2C", VA = "0xB11B2C")]
		private void ProbeDebuffs(List<int> list, Player plr)
		{
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FF")]
		[Address(RVA = "0xB101A8", Offset = "0xB101A8", VA = "0xB101A8")]
		private void ProbeItems(List<int> list, Player plr)
		{
		}

		// Token: 0x06006400 RID: 25600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006400")]
		[Address(RVA = "0xB0E474", Offset = "0xB0E474", VA = "0xB0E474")]
		private void ProbeTownNPCs(List<int> list)
		{
		}

		// Token: 0x06006401 RID: 25601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006401")]
		[Address(RVA = "0xB0F0C8", Offset = "0xB0F0C8", VA = "0xB0F0C8")]
		private void ProbeBiomes(List<int> list, Player plr)
		{
		}

		// Token: 0x06006402 RID: 25602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006402")]
		[Address(RVA = "0xB0F780", Offset = "0xB0F780", VA = "0xB0F780")]
		private void ProbeCritters(List<int> list)
		{
		}

		// Token: 0x06006403 RID: 25603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006403")]
		[Address(RVA = "0xB0E834", Offset = "0xB0E834", VA = "0xB0E834")]
		private void ProbeEmotions(List<int> list)
		{
		}

		// Token: 0x06006404 RID: 25604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006404")]
		[Address(RVA = "0xB104F0", Offset = "0xB104F0", VA = "0xB104F0")]
		private void ProbeBosses(List<int> list)
		{
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006405")]
		[Address(RVA = "0xB12E50", Offset = "0xB12E50", VA = "0xB12E50")]
		private void ProbeExceptions(List<int> list, Player plr, WorldUIAnchor other)
		{
		}

		// Token: 0x0400A0F3 RID: 41203
		[Token(Token = "0x400A0F3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int[] CountNPCs;

		// Token: 0x0400A0F4 RID: 41204
		[Token(Token = "0x400A0F4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static Dictionary<int, EmoteBubble> byID;

		// Token: 0x0400A0F5 RID: 41205
		[Token(Token = "0x400A0F5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<int> toClean;

		// Token: 0x0400A0F6 RID: 41206
		[Token(Token = "0x400A0F6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static int NextID;

		// Token: 0x0400A0F7 RID: 41207
		[Token(Token = "0x400A0F7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int ID;

		// Token: 0x0400A0F8 RID: 41208
		[Token(Token = "0x400A0F8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public WorldUIAnchor anchor;

		// Token: 0x0400A0F9 RID: 41209
		[Token(Token = "0x400A0F9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int lifeTime;

		// Token: 0x0400A0FA RID: 41210
		[Token(Token = "0x400A0FA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int lifeTimeStart;

		// Token: 0x0400A0FB RID: 41211
		[Token(Token = "0x400A0FB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int emote;

		// Token: 0x0400A0FC RID: 41212
		[Token(Token = "0x400A0FC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int metadata;

		// Token: 0x0400A0FD RID: 41213
		[Token(Token = "0x400A0FD")]
		private const int frameSpeed = 8;

		// Token: 0x0400A0FE RID: 41214
		[Token(Token = "0x400A0FE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int frameCounter;

		// Token: 0x0400A0FF RID: 41215
		[Token(Token = "0x400A0FF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int frame;

		// Token: 0x0400A100 RID: 41216
		[Token(Token = "0x400A100")]
		public const int EMOTE_SHEET_HORIZONTAL_FRAMES = 8;

		// Token: 0x0400A101 RID: 41217
		[Token(Token = "0x400A101")]
		public const int EMOTE_SHEET_EMOTES_PER_ROW = 4;

		// Token: 0x0400A102 RID: 41218
		[Token(Token = "0x400A102")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int EMOTE_SHEET_VERTICAL_FRAMES;

		// Token: 0x0400A103 RID: 41219
		[Token(Token = "0x400A103")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static EmoteBubble _temporaryBubble;
	}
}
