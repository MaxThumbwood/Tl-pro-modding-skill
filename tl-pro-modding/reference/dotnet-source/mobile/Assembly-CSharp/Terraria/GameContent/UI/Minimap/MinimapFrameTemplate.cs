using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Content;

namespace Terraria.GameContent.UI.Minimap
{
	// Token: 0x02000D58 RID: 3416
	[Token(Token = "0x2000D58")]
	public class MinimapFrameTemplate
	{
		// Token: 0x0600654B RID: 25931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600654B")]
		[Address(RVA = "0xB459C0", Offset = "0xB459C0", VA = "0xB459C0")]
		public MinimapFrameTemplate(string name, Vector2 frameOffset, Vector2 resetPosition, Vector2 zoomInPosition, Vector2 zoomOutPosition)
		{
		}

		// Token: 0x0600654C RID: 25932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600654C")]
		[Address(RVA = "0xB45A14", Offset = "0xB45A14", VA = "0xB45A14")]
		public MinimapFrame CreateInstance(AssetRequestMode mode)
		{
			return null;
		}

		// Token: 0x0600654D RID: 25933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600654D")]
		private static Asset<T> LoadAsset<T>(string assetName, AssetRequestMode mode) where T : class
		{
			return null;
		}

		// Token: 0x0400A2A4 RID: 41636
		[Token(Token = "0x400A2A4")]
		[FieldOffset(Offset = "0x8")]
		private string name;

		// Token: 0x0400A2A5 RID: 41637
		[Token(Token = "0x400A2A5")]
		[FieldOffset(Offset = "0xC")]
		private Vector2 frameOffset;

		// Token: 0x0400A2A6 RID: 41638
		[Token(Token = "0x400A2A6")]
		[FieldOffset(Offset = "0x14")]
		private Vector2 resetPosition;

		// Token: 0x0400A2A7 RID: 41639
		[Token(Token = "0x400A2A7")]
		[FieldOffset(Offset = "0x1C")]
		private Vector2 zoomInPosition;

		// Token: 0x0400A2A8 RID: 41640
		[Token(Token = "0x400A2A8")]
		[FieldOffset(Offset = "0x24")]
		private Vector2 zoomOutPosition;
	}
}
