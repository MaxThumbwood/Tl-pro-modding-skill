using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D6B RID: 3435
	[Token(Token = "0x2000D6B")]
	public class UIBestiaryEntryIcon : UIElement
	{
		// Token: 0x060065BB RID: 26043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065BB")]
		[Address(RVA = "0xB4C838", Offset = "0xB4C838", VA = "0xB4C838")]
		public UIBestiaryEntryIcon(BestiaryEntry entry, bool isPortrait)
		{
		}

		// Token: 0x060065BC RID: 26044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065BC")]
		[Address(RVA = "0xB52C44", Offset = "0xB52C44", VA = "0xB52C44", Slot = "9")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x060065BD RID: 26045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065BD")]
		[Address(RVA = "0xB52EBC", Offset = "0xB52EBC", VA = "0xB52EBC", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060065BE RID: 26046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065BE")]
		[Address(RVA = "0xB4CE00", Offset = "0xB4CE00", VA = "0xB4CE00")]
		public string GetHoverText()
		{
			return null;
		}

		// Token: 0x0400A30C RID: 41740
		[Token(Token = "0x400A30C")]
		[FieldOffset(Offset = "0xF4")]
		private BestiaryEntry _entry;

		// Token: 0x0400A30D RID: 41741
		[Token(Token = "0x400A30D")]
		[FieldOffset(Offset = "0xF8")]
		private Asset<Texture2D> _notUnlockedTexture;

		// Token: 0x0400A30E RID: 41742
		[Token(Token = "0x400A30E")]
		[FieldOffset(Offset = "0xFC")]
		private bool _isPortrait;

		// Token: 0x0400A30F RID: 41743
		[Token(Token = "0x400A30F")]
		[FieldOffset(Offset = "0xFD")]
		public bool ForceHover;

		// Token: 0x0400A310 RID: 41744
		[Token(Token = "0x400A310")]
		[FieldOffset(Offset = "0x100")]
		private BestiaryUICollectionInfo _collectionInfo;
	}
}
