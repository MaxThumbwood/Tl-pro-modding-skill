using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008E0 RID: 2272
	[Token(Token = "0x20008E0")]
	public class LegacyPlayerRenderer : PlayerDrawLayers
	{
		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06004C91 RID: 19601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700093F")]
		public static SamplerState MountedSamplerState
		{
			[Token(Token = "0x6004C91")]
			[Address(RVA = "0x6F8718", Offset = "0x6F8718", VA = "0x6F8718")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C92")]
		[Address(RVA = "0x6F87C4", Offset = "0x6F87C4", VA = "0x6F87C4")]
		public void DrawPlayers(Camera camera, List<Player> players)
		{
		}

		// Token: 0x06004C93 RID: 19603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C93")]
		[Address(RVA = "0x6FA200", Offset = "0x6FA200", VA = "0x6FA200")]
		public void DrawPlayerHead(Camera camera, Player drawPlayer, Vector2 position, float alpha = 1f, float scale = 1f, [Optional] Color borderColor)
		{
		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C94")]
		[Address(RVA = "0x6FA5F0", Offset = "0x6FA5F0", VA = "0x6FA5F0")]
		private void RenderOutlines(int count, float alpha, float scale, Color borderColor)
		{
		}

		// Token: 0x06004C95 RID: 19605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C95")]
		[Address(RVA = "0x6FAF40", Offset = "0x6FAF40", VA = "0x6FAF40")]
		private void DrawPlayer_BoringSetup(PlayerDrawSet drawinfo, Player player, ref Vector2 drawPosition, float shadowOpacity, float rotation, ref Vector2 rotationOrigin)
		{
		}

		// Token: 0x06004C96 RID: 19606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C96")]
		[Address(RVA = "0x6FAFFC", Offset = "0x6FAFFC", VA = "0x6FAFFC")]
		public void DrawPlayer(Camera camera, Player drawPlayer, Vector2 position, float rotation, Vector2 rotationOrigin, float shadow = 0f, float scale = 1f, [Optional] Vector2[] positionalOffsets)
		{
		}

		// Token: 0x06004C97 RID: 19607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C97")]
		[Address(RVA = "0x6FBA90", Offset = "0x6FBA90", VA = "0x6FBA90")]
		public void DrawDisplayDoll(Camera camera, Player drawPlayer, Vector2 position, float rotation, Vector2 rotationOrigin, float shadow = 0f)
		{
		}

		// Token: 0x06004C98 RID: 19608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C98")]
		[Address(RVA = "0x6FB534", Offset = "0x6FB534", VA = "0x6FB534")]
		private static void DrawPlayer_UseNormalLayers(PlayerDrawSet drawinfo)
		{
		}

		// Token: 0x06004C99 RID: 19609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C99")]
		[Address(RVA = "0x65A450", Offset = "0x65A450", VA = "0x65A450")]
		private void DrawPlayer_UseNormalLayersCombinded(PlayerDrawSet drawinfo)
		{
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C9A")]
		[Address(RVA = "0x6B39D8", Offset = "0x6B39D8", VA = "0x6B39D8")]
		private static void DrawPlayer_UseDisplayDollLayersCombinded(PlayerDrawSet drawinfo)
		{
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C9B")]
		[Address(RVA = "0x6F8AD8", Offset = "0x6F8AD8", VA = "0x6F8AD8")]
		private void DrawPlayerFull(Camera camera, Player drawPlayer)
		{
		}

		// Token: 0x06004C9C RID: 19612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C9C")]
		[Address(RVA = "0x6FC330", Offset = "0x6FC330", VA = "0x6FC330")]
		public void PrepareDrawForFrame(Player drawPlayer)
		{
		}

		// Token: 0x06004C9D RID: 19613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C9D")]
		[Address(RVA = "0x6FC548", Offset = "0x6FC548", VA = "0x6FC548")]
		private void DrawPlayerStoned(Camera camera, Player drawPlayer, Vector2 position)
		{
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C9E")]
		[Address(RVA = "0x6FBCF0", Offset = "0x6FBCF0", VA = "0x6FBCF0")]
		private void DrawGhost(Camera camera, Player drawPlayer, Vector2 position, float shadow = 0f)
		{
		}

		// Token: 0x06004C9F RID: 19615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C9F")]
		[Address(RVA = "0x6FCA74", Offset = "0x6FCA74", VA = "0x6FCA74")]
		public LegacyPlayerRenderer()
		{
		}

		// Token: 0x04009196 RID: 37270
		[Token(Token = "0x4009196")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private DrawData[] _drawData;

		// Token: 0x04009197 RID: 37271
		[Token(Token = "0x4009197")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private List<int> _dust;

		// Token: 0x04009198 RID: 37272
		[Token(Token = "0x4009198")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<int> _gore;

		// Token: 0x04009199 RID: 37273
		[Token(Token = "0x4009199")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Projectile OverrideHeldProjectile;

		// Token: 0x0400919A RID: 37274
		[Token(Token = "0x400919A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayerDrawHeadSet mydrawinfo;

		// Token: 0x0400919B RID: 37275
		[Token(Token = "0x400919B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector2[] OutlineOffsets;

		// Token: 0x0400919C RID: 37276
		[Token(Token = "0x400919C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static PlayerDrawSet drawInfo;
	}
}
