using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D74 RID: 3444
	[Token(Token = "0x2000D74")]
	public class UICharacterNameButton : UIElement
	{
		// Token: 0x060065EA RID: 26090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065EA")]
		[Address(RVA = "0xB565A8", Offset = "0xB565A8", VA = "0xB565A8")]
		public UICharacterNameButton(LocalizedText titleText, LocalizedText emptyContentText, [Optional] LocalizedText description)
		{
		}

		// Token: 0x060065EB RID: 26091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065EB")]
		[Address(RVA = "0xB56CA0", Offset = "0xB56CA0", VA = "0xB56CA0", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060065EC RID: 26092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065EC")]
		[Address(RVA = "0xB56B1C", Offset = "0xB56B1C", VA = "0xB56B1C")]
		public void SetContents(string name)
		{
		}

		// Token: 0x060065ED RID: 26093 RVA: 0x0002E3B0 File Offset: 0x0002C5B0
		[Token(Token = "0x60065ED")]
		[Address(RVA = "0xB56F00", Offset = "0xB56F00", VA = "0xB56F00")]
		public CalculatedStyle GetTextDimensions()
		{
			return default(CalculatedStyle);
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065EE")]
		[Address(RVA = "0xB56F28", Offset = "0xB56F28", VA = "0xB56F28")]
		public void TrimDisplayIfOverElementDimensions(int padding)
		{
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065EF")]
		[Address(RVA = "0xB5740C", Offset = "0xB5740C", VA = "0xB5740C", Slot = "15")]
		public override void LeftMouseDown(UIMouseEvent evt)
		{
		}

		// Token: 0x060065F0 RID: 26096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F0")]
		[Address(RVA = "0xB57414", Offset = "0xB57414", VA = "0xB57414", Slot = "23")]
		public override void MouseOver(UIMouseEvent evt)
		{
		}

		// Token: 0x060065F1 RID: 26097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F1")]
		[Address(RVA = "0xB57430", Offset = "0xB57430", VA = "0xB57430", Slot = "24")]
		public override void MouseOut(UIMouseEvent evt)
		{
		}

		// Token: 0x0400A328 RID: 41768
		[Token(Token = "0x400A328")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private readonly Asset<Texture2D> _BasePanelTexture;

		// Token: 0x0400A329 RID: 41769
		[Token(Token = "0x400A329")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly Asset<Texture2D> _selectedBorderTexture;

		// Token: 0x0400A32A RID: 41770
		[Token(Token = "0x400A32A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		// Token: 0x0400A32B RID: 41771
		[Token(Token = "0x400A32B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool _hovered;

		// Token: 0x0400A32C RID: 41772
		[Token(Token = "0x400A32C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		private bool _soundedHover;

		// Token: 0x0400A32D RID: 41773
		[Token(Token = "0x400A32D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private readonly LocalizedText _textToShowWhenEmpty;

		// Token: 0x0400A32E RID: 41774
		[Token(Token = "0x400A32E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private string actualContents;

		// Token: 0x0400A32F RID: 41775
		[Token(Token = "0x400A32F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private UIText _text;

		// Token: 0x0400A330 RID: 41776
		[Token(Token = "0x400A330")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private UIText _title;

		// Token: 0x0400A331 RID: 41777
		[Token(Token = "0x400A331")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public readonly LocalizedText Description;

		// Token: 0x0400A332 RID: 41778
		[Token(Token = "0x400A332")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public float DistanceFromTitleToOption;
	}
}
