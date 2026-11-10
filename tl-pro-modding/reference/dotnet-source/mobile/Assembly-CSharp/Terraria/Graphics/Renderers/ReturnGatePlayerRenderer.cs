using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.ObjectInteractions;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008E1 RID: 2273
	[Token(Token = "0x20008E1")]
	internal class ReturnGatePlayerRenderer : FileAPI
	{
		// Token: 0x06004CA1 RID: 19617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA1")]
		[Address(RVA = "0x70D9D8", Offset = "0x70D9D8", VA = "0x70D9D8", Slot = "4")]
		public void DrawPlayers(Camera camera, List<Player> players)
		{
		}

		// Token: 0x06004CA2 RID: 19618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA2")]
		[Address(RVA = "0x70E56C", Offset = "0x70E56C", VA = "0x70E56C", Slot = "5")]
		public void DrawPlayerHead(Camera camera, Player drawPlayer, Vector2 position, float alpha = 1f, float scale = 1f, [Optional] Color borderColor)
		{
		}

		// Token: 0x06004CA3 RID: 19619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA3")]
		[Address(RVA = "0x70E574", Offset = "0x70E574", VA = "0x70E574", Slot = "6")]
		public void DrawPlayer(Camera camera, Player drawPlayer, Vector2 position, float rotation, Vector2 rotationOrigin, float shadow = 0f, float scale = 1f, [Optional] Vector2[] positionalOffsets)
		{
		}

		// Token: 0x06004CA4 RID: 19620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA4")]
		[Address(RVA = "0x70E570", Offset = "0x70E570", VA = "0x70E570")]
		private void DrawReturnGateInMap(Camera camera, Player player)
		{
		}

		// Token: 0x06004CA5 RID: 19621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA5")]
		[Address(RVA = "0x70E578", Offset = "0x70E578", VA = "0x70E578")]
		public void OverReturnGateInWorld(Player player)
		{
		}

		// Token: 0x06004CA6 RID: 19622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA6")]
		[Address(RVA = "0x70DB68", Offset = "0x70DB68", VA = "0x70DB68")]
		private void DrawReturnGateInWorld(Camera camera, Player player)
		{
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA7")]
		[Address(RVA = "0x70EBCC", Offset = "0x70EBCC", VA = "0x70EBCC", Slot = "7")]
		public void PrepareDrawForFrame(Player drawPlayer)
		{
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA8")]
		[Address(RVA = "0x70EBD0", Offset = "0x70EBD0", VA = "0x70EBD0")]
		public ReturnGatePlayerRenderer()
		{
		}

		// Token: 0x0400919D RID: 37277
		[Token(Token = "0x400919D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private List<DrawData> _voidLensData;

		// Token: 0x0400919E RID: 37278
		[Token(Token = "0x400919E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private PotionOfReturnGateInteractionChecker _interactionChecker;
	}
}
