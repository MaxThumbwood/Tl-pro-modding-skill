using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BF6 RID: 3062
	[Token(Token = "0x2000BF6")]
	public class CustomEntryIcon : FileAPI
	{
		// Token: 0x06005C66 RID: 23654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C66")]
		[Address(RVA = "0x99FD1C", Offset = "0x99FD1C", VA = "0x99FD1C")]
		public CustomEntryIcon(string nameLanguageKey, string texturePath, Func<bool> unlockCondition)
		{
		}

		// Token: 0x06005C67 RID: 23655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C67")]
		[Address(RVA = "0x9A1574", Offset = "0x9A1574", VA = "0x9A1574", Slot = "8")]
		public IEntryIcon CreateClone()
		{
			return null;
		}

		// Token: 0x06005C68 RID: 23656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C68")]
		[Address(RVA = "0x9A1630", Offset = "0x9A1630", VA = "0x9A1630", Slot = "4")]
		public void Update(BestiaryUICollectionInfo providedInfo, Rectangle hitbox, EntryIconDrawSettings settings)
		{
		}

		// Token: 0x06005C69 RID: 23657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C69")]
		[Address(RVA = "0x9A1650", Offset = "0x9A1650", VA = "0x9A1650", Slot = "5")]
		public void Draw(BestiaryUICollectionInfo providedInfo, SpriteBatch spriteBatch, EntryIconDrawSettings settings)
		{
		}

		// Token: 0x06005C6A RID: 23658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C6A")]
		[Address(RVA = "0x9A1908", Offset = "0x9A1908", VA = "0x9A1908", Slot = "7")]
		public string GetHoverText(BestiaryUICollectionInfo providedInfo)
		{
			return null;
		}

		// Token: 0x06005C6B RID: 23659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C6B")]
		[Address(RVA = "0x9A1478", Offset = "0x9A1478", VA = "0x9A1478")]
		private void UpdateUnlockState(bool state)
		{
		}

		// Token: 0x06005C6C RID: 23660 RVA: 0x0002B500 File Offset: 0x00029700
		[Token(Token = "0x6005C6C")]
		[Address(RVA = "0x9A1640", Offset = "0x9A1640", VA = "0x9A1640", Slot = "6")]
		public bool GetUnlockState(BestiaryUICollectionInfo providedInfo)
		{
			return default(bool);
		}

		// Token: 0x04009CFF RID: 40191
		[Token(Token = "0x4009CFF")]
		[FieldOffset(Offset = "0x8")]
		private LocalizedText _text;

		// Token: 0x04009D00 RID: 40192
		[Token(Token = "0x4009D00")]
		[FieldOffset(Offset = "0xC")]
		private Asset<Texture2D> _textureAsset;

		// Token: 0x04009D01 RID: 40193
		[Token(Token = "0x4009D01")]
		[FieldOffset(Offset = "0x10")]
		private Rectangle _sourceRectangle;

		// Token: 0x04009D02 RID: 40194
		[Token(Token = "0x4009D02")]
		[FieldOffset(Offset = "0x20")]
		private Func<bool> _unlockCondition;
	}
}
