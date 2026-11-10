using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x02000506 RID: 1286
	[Token(Token = "0x2000506")]
	[StructLayout(0)]
	public class Tile_PC
	{
		// Token: 0x0600336F RID: 13167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600336F")]
		[Address(RVA = "0x1A1F97C", Offset = "0x1A1F97C", VA = "0x1A1F97C")]
		public Tile_PC()
		{
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003370")]
		[Address(RVA = "0x1A1F9A4", Offset = "0x1A1F9A4", VA = "0x1A1F9A4")]
		public Tile_PC(Tile_PC copy)
		{
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003371")]
		[Address(RVA = "0x1A1FA34", Offset = "0x1A1FA34", VA = "0x1A1FA34")]
		public void ApplyToTile(Tile tile)
		{
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003372")]
		[Address(RVA = "0x1A20708", Offset = "0x1A20708", VA = "0x1A20708")]
		public static Tile_PC FromTile(Tile tile)
		{
			return null;
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003373")]
		[Address(RVA = "0x1A214C4", Offset = "0x1A214C4", VA = "0x1A214C4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003374")]
		[Address(RVA = "0x1A214CC", Offset = "0x1A214CC", VA = "0x1A214CC")]
		public void ClearEverything()
		{
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003375")]
		[Address(RVA = "0x1A214E4", Offset = "0x1A214E4", VA = "0x1A214E4")]
		public void ClearTile()
		{
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003376")]
		[Address(RVA = "0x1A214F8", Offset = "0x1A214F8", VA = "0x1A214F8")]
		public void ClearSlope()
		{
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003377")]
		[Address(RVA = "0x1A2150C", Offset = "0x1A2150C", VA = "0x1A2150C")]
		public void ClearTileAndPaint()
		{
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003378")]
		[Address(RVA = "0x1A21548", Offset = "0x1A21548", VA = "0x1A21548")]
		public void CopyFrom(Tile_PC from)
		{
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06003379 RID: 13177 RVA: 0x00019068 File Offset: 0x00017268
		[Token(Token = "0x170006F0")]
		public int collisionType
		{
			[Token(Token = "0x6003379")]
			[Address(RVA = "0x1A21630", Offset = "0x1A21630", VA = "0x1A21630")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x00019080 File Offset: 0x00017280
		[Token(Token = "0x600337A")]
		[Address(RVA = "0x1A21734", Offset = "0x1A21734", VA = "0x1A21734")]
		public bool isTheSameAs(Tile compTile)
		{
			return default(bool);
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x00019098 File Offset: 0x00017298
		[Token(Token = "0x600337B")]
		[Address(RVA = "0x1A21F44", Offset = "0x1A21F44", VA = "0x1A21F44")]
		public int blockType()
		{
			return 0;
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600337C")]
		[Address(RVA = "0x1A21270", Offset = "0x1A21270", VA = "0x1A21270")]
		public void liquidType(int liquidType)
		{
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x000190B0 File Offset: 0x000172B0
		[Token(Token = "0x600337D")]
		[Address(RVA = "0x1A205FC", Offset = "0x1A205FC", VA = "0x1A205FC")]
		public byte liquidType()
		{
			return 0;
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x000190C8 File Offset: 0x000172C8
		[Token(Token = "0x600337E")]
		[Address(RVA = "0x1A21FB4", Offset = "0x1A21FB4", VA = "0x1A21FB4")]
		public bool nactive()
		{
			return default(bool);
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600337F")]
		[Address(RVA = "0x1A21FCC", Offset = "0x1A21FCC", VA = "0x1A21FCC")]
		public void ResetToType(ushort type)
		{
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003380")]
		[Address(RVA = "0x1A21FEC", Offset = "0x1A21FEC", VA = "0x1A21FEC")]
		internal void ClearMetadata()
		{
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x000190E0 File Offset: 0x000172E0
		[Token(Token = "0x6003381")]
		[Address(RVA = "0x1A22000", Offset = "0x1A22000", VA = "0x1A22000")]
		public Color actColor(Color oldColor)
		{
			return default(Color);
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003382")]
		[Address(RVA = "0x1A220B0", Offset = "0x1A220B0", VA = "0x1A220B0")]
		public void actColor(ref Vector3 oldColor)
		{
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x000190F8 File Offset: 0x000172F8
		[Token(Token = "0x6003383")]
		[Address(RVA = "0x1A22168", Offset = "0x1A22168", VA = "0x1A22168")]
		public bool topSlope()
		{
			return default(bool);
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x00019110 File Offset: 0x00017310
		[Token(Token = "0x6003384")]
		[Address(RVA = "0x1A22188", Offset = "0x1A22188", VA = "0x1A22188")]
		public bool bottomSlope()
		{
			return default(bool);
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x00019128 File Offset: 0x00017328
		[Token(Token = "0x6003385")]
		[Address(RVA = "0x1A221A8", Offset = "0x1A221A8", VA = "0x1A221A8")]
		public bool leftSlope()
		{
			return default(bool);
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x00019140 File Offset: 0x00017340
		[Token(Token = "0x6003386")]
		[Address(RVA = "0x1A221C4", Offset = "0x1A221C4", VA = "0x1A221C4")]
		public bool rightSlope()
		{
			return default(bool);
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x00019158 File Offset: 0x00017358
		[Token(Token = "0x6003387")]
		[Address(RVA = "0x1A221E4", Offset = "0x1A221E4", VA = "0x1A221E4")]
		public bool HasSameSlope(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x00019170 File Offset: 0x00017370
		[Token(Token = "0x6003388")]
		[Address(RVA = "0x1A205F0", Offset = "0x1A205F0", VA = "0x1A205F0")]
		public byte wallColor()
		{
			return 0;
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003389")]
		[Address(RVA = "0x1A2125C", Offset = "0x1A2125C", VA = "0x1A2125C")]
		public void wallColor(byte wallColor)
		{
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x00019188 File Offset: 0x00017388
		[Token(Token = "0x600338A")]
		[Address(RVA = "0x1A222DC", Offset = "0x1A222DC", VA = "0x1A222DC")]
		public bool lava()
		{
			return default(bool);
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600338B")]
		[Address(RVA = "0x1A21F64", Offset = "0x1A21F64", VA = "0x1A21F64")]
		public void lava(bool lava)
		{
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x000191A0 File Offset: 0x000173A0
		[Token(Token = "0x600338C")]
		[Address(RVA = "0x1A222F4", Offset = "0x1A222F4", VA = "0x1A222F4")]
		public bool honey()
		{
			return default(bool);
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600338D")]
		[Address(RVA = "0x1A21F80", Offset = "0x1A21F80", VA = "0x1A21F80")]
		public void honey(bool honey)
		{
		}

		// Token: 0x0600338E RID: 13198 RVA: 0x000191B8 File Offset: 0x000173B8
		[Token(Token = "0x600338E")]
		[Address(RVA = "0x1A2230C", Offset = "0x1A2230C", VA = "0x1A2230C")]
		public bool shimmer()
		{
			return default(bool);
		}

		// Token: 0x0600338F RID: 13199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600338F")]
		[Address(RVA = "0x1A21F9C", Offset = "0x1A21F9C", VA = "0x1A21F9C")]
		public void shimmer(bool shimmer)
		{
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x000191D0 File Offset: 0x000173D0
		[Token(Token = "0x6003390")]
		[Address(RVA = "0x1A22324", Offset = "0x1A22324", VA = "0x1A22324")]
		public bool water()
		{
			return default(bool);
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x000191E8 File Offset: 0x000173E8
		[Token(Token = "0x6003391")]
		[Address(RVA = "0x1A22338", Offset = "0x1A22338", VA = "0x1A22338")]
		public bool anyWater()
		{
			return default(bool);
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x00019200 File Offset: 0x00017400
		[Token(Token = "0x6003392")]
		[Address(RVA = "0x1A22358", Offset = "0x1A22358", VA = "0x1A22358")]
		public bool anyLava()
		{
			return default(bool);
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x00019218 File Offset: 0x00017418
		[Token(Token = "0x6003393")]
		[Address(RVA = "0x1A22380", Offset = "0x1A22380", VA = "0x1A22380")]
		public bool anyHoney()
		{
			return default(bool);
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x00019230 File Offset: 0x00017430
		[Token(Token = "0x6003394")]
		[Address(RVA = "0x1A223A8", Offset = "0x1A223A8", VA = "0x1A223A8")]
		public bool anyShimmer()
		{
			return default(bool);
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x00019248 File Offset: 0x00017448
		[Token(Token = "0x6003395")]
		[Address(RVA = "0x1A2062C", Offset = "0x1A2062C", VA = "0x1A2062C")]
		public bool wire4()
		{
			return default(bool);
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003396")]
		[Address(RVA = "0x1A2132C", Offset = "0x1A2132C", VA = "0x1A2132C")]
		public void wire4(bool wire4)
		{
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x00019260 File Offset: 0x00017460
		[Token(Token = "0x6003397")]
		[Address(RVA = "0x1A20640", Offset = "0x1A20640", VA = "0x1A20640")]
		public int wallFrameX()
		{
			return 0;
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003398")]
		[Address(RVA = "0x1A21344", Offset = "0x1A21344", VA = "0x1A21344")]
		public void wallFrameX(int wallFrameX)
		{
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x00019278 File Offset: 0x00017478
		[Token(Token = "0x6003399")]
		[Address(RVA = "0x1A20674", Offset = "0x1A20674", VA = "0x1A20674")]
		public byte frameNumber()
		{
			return 0;
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339A")]
		[Address(RVA = "0x1A213B0", Offset = "0x1A213B0", VA = "0x1A213B0")]
		public void frameNumber(byte frameNumber)
		{
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x00019290 File Offset: 0x00017490
		[Token(Token = "0x600339B")]
		[Address(RVA = "0x1A20668", Offset = "0x1A20668", VA = "0x1A20668")]
		public byte wallFrameNumber()
		{
			return 0;
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339C")]
		[Address(RVA = "0x1A2139C", Offset = "0x1A2139C", VA = "0x1A2139C")]
		public void wallFrameNumber(byte wallFrameNumber)
		{
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x000192A8 File Offset: 0x000174A8
		[Token(Token = "0x600339D")]
		[Address(RVA = "0x1A20654", Offset = "0x1A20654", VA = "0x1A20654")]
		public int wallFrameY()
		{
			return 0;
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339E")]
		[Address(RVA = "0x1A21370", Offset = "0x1A21370", VA = "0x1A21370")]
		public void wallFrameY(int wallFrameY)
		{
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x000192C0 File Offset: 0x000174C0
		[Token(Token = "0x600339F")]
		[Address(RVA = "0x1A223D0", Offset = "0x1A223D0", VA = "0x1A223D0")]
		public bool checkingLiquid()
		{
			return default(bool);
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A0")]
		[Address(RVA = "0x1A223DC", Offset = "0x1A223DC", VA = "0x1A223DC")]
		public void checkingLiquid(bool checkingLiquid)
		{
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x000192D8 File Offset: 0x000174D8
		[Token(Token = "0x60033A1")]
		[Address(RVA = "0x1A223F4", Offset = "0x1A223F4", VA = "0x1A223F4")]
		public bool skipLiquid()
		{
			return default(bool);
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A2")]
		[Address(RVA = "0x1A22400", Offset = "0x1A22400", VA = "0x1A22400")]
		public void skipLiquid(bool skipLiquid)
		{
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x000192F0 File Offset: 0x000174F0
		[Token(Token = "0x60033A3")]
		[Address(RVA = "0x1A20680", Offset = "0x1A20680", VA = "0x1A20680")]
		public bool invisibleBlock()
		{
			return default(bool);
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A4")]
		[Address(RVA = "0x1A213C8", Offset = "0x1A213C8", VA = "0x1A213C8")]
		public void invisibleBlock(bool invisibleBlock)
		{
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x00019308 File Offset: 0x00017508
		[Token(Token = "0x60033A5")]
		[Address(RVA = "0x1A2068C", Offset = "0x1A2068C", VA = "0x1A2068C")]
		public bool invisibleWall()
		{
			return default(bool);
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A6")]
		[Address(RVA = "0x1A213E0", Offset = "0x1A213E0", VA = "0x1A213E0")]
		public void invisibleWall(bool invisibleWall)
		{
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x00019320 File Offset: 0x00017520
		[Token(Token = "0x60033A7")]
		[Address(RVA = "0x1A20698", Offset = "0x1A20698", VA = "0x1A20698")]
		public bool fullbrightBlock()
		{
			return default(bool);
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A8")]
		[Address(RVA = "0x1A213F8", Offset = "0x1A213F8", VA = "0x1A213F8")]
		public void fullbrightBlock(bool fullbrightBlock)
		{
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x00019338 File Offset: 0x00017538
		[Token(Token = "0x60033A9")]
		[Address(RVA = "0x1A206AC", Offset = "0x1A206AC", VA = "0x1A206AC")]
		public byte color()
		{
			return 0;
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AA")]
		[Address(RVA = "0x1A21410", Offset = "0x1A21410", VA = "0x1A21410")]
		public void color(byte color)
		{
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x00019350 File Offset: 0x00017550
		[Token(Token = "0x60033AB")]
		[Address(RVA = "0x1A206B8", Offset = "0x1A206B8", VA = "0x1A206B8")]
		public bool active()
		{
			return default(bool);
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AC")]
		[Address(RVA = "0x1A21424", Offset = "0x1A21424", VA = "0x1A21424")]
		public void active(bool active)
		{
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x00019368 File Offset: 0x00017568
		[Token(Token = "0x60033AD")]
		[Address(RVA = "0x1A206C4", Offset = "0x1A206C4", VA = "0x1A206C4")]
		public bool inActive()
		{
			return default(bool);
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AE")]
		[Address(RVA = "0x1A2143C", Offset = "0x1A2143C", VA = "0x1A2143C")]
		public void inActive(bool inActive)
		{
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x00019380 File Offset: 0x00017580
		[Token(Token = "0x60033AF")]
		[Address(RVA = "0x1A20608", Offset = "0x1A20608", VA = "0x1A20608")]
		public bool wire()
		{
			return default(bool);
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B0")]
		[Address(RVA = "0x1A212DC", Offset = "0x1A212DC", VA = "0x1A212DC")]
		public void wire(bool wire)
		{
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x00019398 File Offset: 0x00017598
		[Token(Token = "0x60033B1")]
		[Address(RVA = "0x1A20614", Offset = "0x1A20614", VA = "0x1A20614")]
		public bool wire2()
		{
			return default(bool);
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B2")]
		[Address(RVA = "0x1A212F4", Offset = "0x1A212F4", VA = "0x1A212F4")]
		public void wire2(bool wire2)
		{
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x000193B0 File Offset: 0x000175B0
		[Token(Token = "0x60033B3")]
		[Address(RVA = "0x1A20620", Offset = "0x1A20620", VA = "0x1A20620")]
		public bool wire3()
		{
			return default(bool);
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B4")]
		[Address(RVA = "0x1A21310", Offset = "0x1A21310", VA = "0x1A21310")]
		public void wire3(bool wire3)
		{
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x000193C8 File Offset: 0x000175C8
		[Token(Token = "0x60033B5")]
		[Address(RVA = "0x1A206D0", Offset = "0x1A206D0", VA = "0x1A206D0")]
		public bool halfBrick()
		{
			return default(bool);
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B6")]
		[Address(RVA = "0x1A21454", Offset = "0x1A21454", VA = "0x1A21454")]
		public void halfBrick(bool halfBrick)
		{
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x000193E0 File Offset: 0x000175E0
		[Token(Token = "0x60033B7")]
		[Address(RVA = "0x1A206DC", Offset = "0x1A206DC", VA = "0x1A206DC")]
		public bool actuator()
		{
			return default(bool);
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B8")]
		[Address(RVA = "0x1A21470", Offset = "0x1A21470", VA = "0x1A21470")]
		public void actuator(bool actuator)
		{
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x000193F8 File Offset: 0x000175F8
		[Token(Token = "0x60033B9")]
		[Address(RVA = "0x1A206E8", Offset = "0x1A206E8", VA = "0x1A206E8")]
		public byte slope()
		{
			return 0;
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BA")]
		[Address(RVA = "0x1A2148C", Offset = "0x1A2148C", VA = "0x1A2148C")]
		public void slope(byte slope)
		{
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x00019410 File Offset: 0x00017610
		[Token(Token = "0x60033BB")]
		[Address(RVA = "0x1A206F4", Offset = "0x1A206F4", VA = "0x1A206F4")]
		public bool fullbrightWall()
		{
			return default(bool);
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BC")]
		[Address(RVA = "0x1A214A8", Offset = "0x1A214A8", VA = "0x1A214A8")]
		public void fullbrightWall(bool fullbrightWall)
		{
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x00019428 File Offset: 0x00017628
		[Token(Token = "0x60033BD")]
		[Address(RVA = "0x1A22418", Offset = "0x1A22418", VA = "0x1A22418")]
		public bool anyWire()
		{
			return default(bool);
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BE")]
		[Address(RVA = "0x1A22440", Offset = "0x1A22440", VA = "0x1A22440")]
		public void Clear(TileDataType types)
		{
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BF")]
		[Address(RVA = "0x1A22598", Offset = "0x1A22598", VA = "0x1A22598")]
		public static void SmoothSlope(int x, int y, bool applyToNeighbors = true, bool sync = false)
		{
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C0")]
		[Address(RVA = "0x1A231DC", Offset = "0x1A231DC", VA = "0x1A231DC")]
		public void CopyPaintAndCoating(Tile other)
		{
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00019440 File Offset: 0x00017640
		[Token(Token = "0x60033C1")]
		[Address(RVA = "0x1A23384", Offset = "0x1A23384", VA = "0x1A23384")]
		public TileColorCache BlockColorAndCoating()
		{
			return default(TileColorCache);
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x00019458 File Offset: 0x00017658
		[Token(Token = "0x60033C2")]
		[Address(RVA = "0x1A233A4", Offset = "0x1A233A4", VA = "0x1A233A4")]
		public TileColorCache WallColorAndCoating()
		{
			return default(TileColorCache);
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C3")]
		[Address(RVA = "0x1A2152C", Offset = "0x1A2152C", VA = "0x1A2152C")]
		public void ClearBlockPaintAndCoating()
		{
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C4")]
		[Address(RVA = "0x1A22570", Offset = "0x1A22570", VA = "0x1A22570")]
		public void ClearWallPaintAndCoating()
		{
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C5")]
		[Address(RVA = "0x1A233CC", Offset = "0x1A233CC", VA = "0x1A233CC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400433C RID: 17212
		[Token(Token = "0x400433C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort type;

		// Token: 0x0400433D RID: 17213
		[Token(Token = "0x400433D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public ushort wall;

		// Token: 0x0400433E RID: 17214
		[Token(Token = "0x400433E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public byte liquid;

		// Token: 0x0400433F RID: 17215
		[Token(Token = "0x400433F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public ushort sTileHeader;

		// Token: 0x04004340 RID: 17216
		[Token(Token = "0x4004340")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		public byte bTileHeader;

		// Token: 0x04004341 RID: 17217
		[Token(Token = "0x4004341")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte bTileHeader2;

		// Token: 0x04004342 RID: 17218
		[Token(Token = "0x4004342")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public byte bTileHeader3;

		// Token: 0x04004343 RID: 17219
		[Token(Token = "0x4004343")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public short frameX;

		// Token: 0x04004344 RID: 17220
		[Token(Token = "0x4004344")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public short frameY;

		// Token: 0x04004345 RID: 17221
		[Token(Token = "0x4004345")]
		private const int Bit0 = 1;

		// Token: 0x04004346 RID: 17222
		[Token(Token = "0x4004346")]
		private const int Bit1 = 2;

		// Token: 0x04004347 RID: 17223
		[Token(Token = "0x4004347")]
		private const int Bit2 = 4;

		// Token: 0x04004348 RID: 17224
		[Token(Token = "0x4004348")]
		private const int Bit3 = 8;

		// Token: 0x04004349 RID: 17225
		[Token(Token = "0x4004349")]
		private const int Bit4 = 16;

		// Token: 0x0400434A RID: 17226
		[Token(Token = "0x400434A")]
		private const int Bit5 = 32;

		// Token: 0x0400434B RID: 17227
		[Token(Token = "0x400434B")]
		private const int Bit6 = 64;

		// Token: 0x0400434C RID: 17228
		[Token(Token = "0x400434C")]
		private const int Bit7 = 128;

		// Token: 0x0400434D RID: 17229
		[Token(Token = "0x400434D")]
		private const ushort Bit15 = 32768;

		// Token: 0x0400434E RID: 17230
		[Token(Token = "0x400434E")]
		public const int Type_Solid = 0;

		// Token: 0x0400434F RID: 17231
		[Token(Token = "0x400434F")]
		public const int Type_Halfbrick = 1;

		// Token: 0x04004350 RID: 17232
		[Token(Token = "0x4004350")]
		public const int Type_SlopeDownRight = 2;

		// Token: 0x04004351 RID: 17233
		[Token(Token = "0x4004351")]
		public const int Type_SlopeDownLeft = 3;

		// Token: 0x04004352 RID: 17234
		[Token(Token = "0x4004352")]
		public const int Type_SlopeUpRight = 4;

		// Token: 0x04004353 RID: 17235
		[Token(Token = "0x4004353")]
		public const int Type_SlopeUpLeft = 5;

		// Token: 0x04004354 RID: 17236
		[Token(Token = "0x4004354")]
		public const int Liquid_Water = 0;

		// Token: 0x04004355 RID: 17237
		[Token(Token = "0x4004355")]
		public const int Liquid_Lava = 1;

		// Token: 0x04004356 RID: 17238
		[Token(Token = "0x4004356")]
		public const int Liquid_Honey = 2;

		// Token: 0x04004357 RID: 17239
		[Token(Token = "0x4004357")]
		public const int Liquid_Shimmer = 3;

		// Token: 0x04004358 RID: 17240
		[Token(Token = "0x4004358")]
		private const int NeitherLavaOrHoney = 159;

		// Token: 0x04004359 RID: 17241
		[Token(Token = "0x4004359")]
		private const int EitherLavaOrHoney = 96;
	}
}
