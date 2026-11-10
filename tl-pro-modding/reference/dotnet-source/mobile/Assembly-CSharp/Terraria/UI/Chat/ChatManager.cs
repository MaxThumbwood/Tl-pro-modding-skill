using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Chat;

namespace Terraria.UI.Chat
{
	// Token: 0x0200089F RID: 2207
	[Token(Token = "0x200089F")]
	public static class ChatManager
	{
		// Token: 0x06004B04 RID: 19204 RVA: 0x00023A18 File Offset: 0x00021C18
		[Token(Token = "0x6004B04")]
		[Address(RVA = "0x641DA8", Offset = "0x641DA8", VA = "0x641DA8")]
		public static Color WaveColor(Color color)
		{
			return default(Color);
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B05")]
		[Address(RVA = "0x641E24", Offset = "0x641E24", VA = "0x641E24")]
		public static void ConvertNormalSnippets(TextSnippet[] snippets)
		{
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B06")]
		public static void Register<T>(string[] names) where T : ITagHandler, new()
		{
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B07")]
		[Address(RVA = "0x641FF8", Offset = "0x641FF8", VA = "0x641FF8")]
		private static ITagHandler GetHandler(string tagName)
		{
			return null;
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B08")]
		[Address(RVA = "0x64211C", Offset = "0x64211C", VA = "0x64211C")]
		public static TextSnippet[] ParseMessage(string text, Color baseColor, float maxWidth = -1f)
		{
			return null;
		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x00023A30 File Offset: 0x00021C30
		[Token(Token = "0x6004B09")]
		[Address(RVA = "0x643218", Offset = "0x643218", VA = "0x643218")]
		public static bool AddChatText(SpriteFont font, string text, Vector2 baseScale)
		{
			return default(bool);
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x00023A48 File Offset: 0x00021C48
		[Token(Token = "0x6004B0A")]
		[Address(RVA = "0x64329C", Offset = "0x64329C", VA = "0x64329C")]
		public static Vector2 GetStringSizeSimple(SpriteFont font, string text, Vector2 baseScale, float maxWidth = -1f)
		{
			return default(Vector2);
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x00023A60 File Offset: 0x00021C60
		[Token(Token = "0x6004B0B")]
		[Address(RVA = "0x644290", Offset = "0x644290", VA = "0x644290")]
		public static Vector2 GetStringSize(SpriteFont font, string text, Vector2 baseScale, float maxWidth = -1f)
		{
			return default(Vector2);
		}

		// Token: 0x06004B0C RID: 19212 RVA: 0x00023A78 File Offset: 0x00021C78
		[Token(Token = "0x6004B0C")]
		[Address(RVA = "0x6433A4", Offset = "0x6433A4", VA = "0x6433A4")]
		public static Vector2 GetStringSize(SpriteFont font, TextSnippet[] snippets, Vector2 baseScale, float maxWidth = -1f)
		{
			return default(Vector2);
		}

		// Token: 0x06004B0D RID: 19213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B0D")]
		[Address(RVA = "0x644384", Offset = "0x644384", VA = "0x644384")]
		public static void DrawColorCodedStringShadow(SpriteBatch spriteBatch, SpriteFont font, TextSnippet[] snippets, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f, int maxLines = 100)
		{
		}

		// Token: 0x06004B0E RID: 19214 RVA: 0x00023A90 File Offset: 0x00021C90
		[Token(Token = "0x6004B0E")]
		[Address(RVA = "0x6445C4", Offset = "0x6445C4", VA = "0x6445C4")]
		public static Vector2 DrawColorCodedString(Vector2[] offsets, SpriteBatch spriteBatch, SpriteFont font, TextSnippet[] snippets, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, out int hoveredSnippet, float maxWidth, bool ignoreColors = false, int maxLines = 100)
		{
			return default(Vector2);
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x00023AA8 File Offset: 0x00021CA8
		[Token(Token = "0x6004B0F")]
		[Address(RVA = "0x645D20", Offset = "0x645D20", VA = "0x645D20")]
		public static Vector2 DrawColorCodedString(SpriteBatch spriteBatch, SpriteFont font, TextSnippet[] snippets, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, out int hoveredSnippet, float maxWidth, bool ignoreColors = false, int maxLines = 100)
		{
			return default(Vector2);
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x00023AC0 File Offset: 0x00021CC0
		[Token(Token = "0x6004B10")]
		[Address(RVA = "0x647364", Offset = "0x647364", VA = "0x647364")]
		public static Vector2 DrawColorCodedStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, TextSnippet[] snippets, Vector2 position, float rotation, Vector2 origin, Vector2 baseScale, out int hoveredSnippet, float maxWidth = -1f, float spread = 2f, int maxLines = 100)
		{
			return default(Vector2);
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B11")]
		[Address(RVA = "0x64751C", Offset = "0x64751C", VA = "0x64751C")]
		public static void DrawColorCodedStringShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
		{
		}

		// Token: 0x06004B12 RID: 19218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B12")]
		[Address(RVA = "0x6482F8", Offset = "0x6482F8", VA = "0x6482F8")]
		public static void DrawColorCodedStringShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f, int maxLines = 100)
		{
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B13")]
		[Address(RVA = "0x648518", Offset = "0x648518", VA = "0x648518")]
		public static void DrawColorCodedStringShadow(SpriteBatch spriteBatch, SpriteFont font, StringBuilder text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
		{
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B14")]
		[Address(RVA = "0x648F34", Offset = "0x648F34", VA = "0x648F34")]
		public static void DrawColorCodedString(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, bool ignoreColors = false, int maxLines = 100)
		{
		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B15")]
		[Address(RVA = "0x64773C", Offset = "0x64773C", VA = "0x64773C")]
		public static void DrawColorCodedString(Vector2[] offsets, SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, bool ignoreColors = false, int maxLines = 100)
		{
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x00023AD8 File Offset: 0x00021CD8
		[Token(Token = "0x6004B16")]
		[Address(RVA = "0x649AFC", Offset = "0x649AFC", VA = "0x649AFC")]
		public static Vector2 DrawColorCodedString(SpriteBatch spriteBatch, SpriteFont font, StringBuilder text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, bool ignoreColors = false)
		{
			return default(Vector2);
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x00023AF0 File Offset: 0x00021CF0
		[Token(Token = "0x6004B17")]
		[Address(RVA = "0x648740", Offset = "0x648740", VA = "0x648740")]
		public static Vector2 DrawColorCodedString(Vector2[] offsets, SpriteBatch spriteBatch, SpriteFont font, StringBuilder text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, bool ignoreColors = false)
		{
			return default(Vector2);
		}

		// Token: 0x06004B18 RID: 19224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B18")]
		[Address(RVA = "0x64A2FC", Offset = "0x64A2FC", VA = "0x64A2FC")]
		public static void DrawColorCodedStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
		{
		}

		// Token: 0x06004B19 RID: 19225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B19")]
		[Address(RVA = "0x64A4F0", Offset = "0x64A4F0", VA = "0x64A4F0")]
		public static void DrawStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
		{
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1A")]
		[Address(RVA = "0x64A6DC", Offset = "0x64A6DC", VA = "0x64A6DC")]
		public static void DrawStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f, int maxLines = 100)
		{
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1B")]
		[Address(RVA = "0x64A8D0", Offset = "0x64A8D0", VA = "0x64A8D0")]
		public static void DrawStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, StringBuilder text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
		{
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1C")]
		[Address(RVA = "0x64AAB4", Offset = "0x64AAB4", VA = "0x64AAB4")]
		public static void DrawStringWithShadowSimple(SpriteBatch spriteBatch, SpriteFont font, ref SpriteFont.CharacterSource source, Vector2 position, Color baseColor, float baseScale, float maxWidth = -1f, float spread = 2f)
		{
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1D")]
		[Address(RVA = "0x64BD40", Offset = "0x64BD40", VA = "0x64BD40")]
		public static void DrawStringWithShadowSimplePanelBacking(SpriteBatch spriteBatch, SpriteFont font, ref SpriteFont.CharacterSource source, Vector2 position, Color baseColor, float baseScale, Vector2 tlOffset, Vector2 brOffset, Panel_Layout backingLayout, float maxWidth = -1f, float spread = 2f)
		{
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1E")]
		[Address(RVA = "0x64AD98", Offset = "0x64AD98", VA = "0x64AD98")]
		public static void DrawColorCodedStringSimple(Vector2[] offsets, SpriteBatch spriteBatch, SpriteFont font, ref SpriteFont.CharacterSource source, Vector2 position, Color baseColor, float baseScale, float maxWidth = -1f, bool ignoreColors = false, int maxLines = 100)
		{
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x00023B08 File Offset: 0x00021D08
		[Token(Token = "0x6004B1F")]
		[Address(RVA = "0x64C070", Offset = "0x64C070", VA = "0x64C070")]
		public static Vector2 DrawColorCodedStringBacking(SpriteBatch spriteBatch, SpriteFont font, ref SpriteFont.CharacterSource text, Vector2 position, Color baseColor, float baseScale, float maxWidth, Vector2 tlOffset, Vector2 brOffset, Panel_Layout backingLayout)
		{
			return default(Vector2);
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x00023B20 File Offset: 0x00021D20
		[Token(Token = "0x6004B20")]
		[Address(RVA = "0x64B6F8", Offset = "0x64B6F8", VA = "0x64B6F8")]
		public static Vector2 DrawColorCodedStringSimple(SpriteBatch spriteBatch, SpriteFont font, ref SpriteFont.CharacterSource text, Vector2 position, Color baseColor, float baseScale, float maxWidth = -1f, bool ignoreColors = false)
		{
			return default(Vector2);
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B22")]
		[Address(RVA = "0x6423A4", Offset = "0x6423A4", VA = "0x6423A4")]
		internal static void <ParseMessage>g__ProcessSection|10_0(string text, ref ChatManager.<>c__DisplayClass10_0 A_1)
		{
		}

		// Token: 0x04009036 RID: 36918
		[Token(Token = "0x4009036")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ChatCommandProcessor Commands;

		// Token: 0x04009037 RID: 36919
		[Token(Token = "0x4009037")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static ConcurrentDictionary<string, ITagHandler> _handlers;

		// Token: 0x04009038 RID: 36920
		[Token(Token = "0x4009038")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Vector2[] ShadowDirectionsScaled;

		// Token: 0x04009039 RID: 36921
		[Token(Token = "0x4009039")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly Vector2[] ShadowDirections;

		// Token: 0x0400903A RID: 36922
		[Token(Token = "0x400903A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static bool AllowColon;

		// Token: 0x0400903B RID: 36923
		[Token(Token = "0x400903B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static TextSnippet[] SingleLineSnippet;

		// Token: 0x0400903C RID: 36924
		[Token(Token = "0x400903C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static SpriteBatch overloadedSpriteBatch;

		// Token: 0x020008A0 RID: 2208
		[Token(Token = "0x20008A0")]
		public static class Regexes
		{
			// Token: 0x0400903D RID: 36925
			[Token(Token = "0x400903D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Regex Format;
		}

		// Token: 0x020008A1 RID: 2209
		[Token(Token = "0x20008A1")]
		[StructLayout(3)]
		private struct <>c__DisplayClass10_0
		{
			// Token: 0x0400903E RID: 36926
			[Token(Token = "0x400903E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<TextSnippet> snippets;

			// Token: 0x0400903F RID: 36927
			[Token(Token = "0x400903F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Color baseColor;
		}
	}
}
