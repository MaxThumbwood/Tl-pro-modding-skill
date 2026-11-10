using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D73 RID: 3443
	[Token(Token = "0x2000D73")]
	public class UIBestiaryNPCEntryPortrait : UIElement
	{
		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x060065E7 RID: 26087 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060065E8 RID: 26088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AEC")]
		public BestiaryEntry Entry
		{
			[Token(Token = "0x60065E7")]
			[Address(RVA = "0xB55C20", Offset = "0xB55C20", VA = "0xB55C20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60065E8")]
			[Address(RVA = "0xB55C28", Offset = "0xB55C28", VA = "0xB55C28")]
			private set
			{
			}
		}

		// Token: 0x060065E9 RID: 26089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065E9")]
		[Address(RVA = "0xB55C30", Offset = "0xB55C30", VA = "0xB55C30")]
		public UIBestiaryNPCEntryPortrait(BestiaryEntry entry, Asset<Texture2D> portraitBackgroundAsset, Color portraitColor, List<IBestiaryBackgroundOverlayAndColorProvider> overlays)
		{
		}

		// Token: 0x0400A327 RID: 41767
		[Token(Token = "0x400A327")]
		[FieldOffset(Offset = "0xF4")]
		private BestiaryEntry <Entry>k__BackingField;
	}
}
