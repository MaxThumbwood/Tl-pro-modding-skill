using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000787 RID: 1927
	[Token(Token = "0x2000787")]
	public class PlayerDrawSet
	{
		// Token: 0x0600437F RID: 17279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437F")]
		[Address(RVA = "0x500D18", Offset = "0x500D18", VA = "0x500D18")]
		public ref DrawData AddDrawData()
		{
			return null;
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06004380 RID: 17280 RVA: 0x000207F0 File Offset: 0x0001E9F0
		[Token(Token = "0x17000830")]
		public Vector2 Center
		{
			[Token(Token = "0x6004380")]
			[Address(RVA = "0x500D50", Offset = "0x500D50", VA = "0x500D50")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06004381 RID: 17281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004381")]
		[Address(RVA = "0x500DE8", Offset = "0x500DE8", VA = "0x500DE8")]
		public void BoringSetup(Player player, ref Vector2 drawPosition, float shadowOpacity, float rotation, ref Vector2 rotationOrigin, [Optional] Projectile overrideHeldProjectile)
		{
		}

		// Token: 0x06004382 RID: 17282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004382")]
		[Address(RVA = "0x50DA90", Offset = "0x50DA90", VA = "0x50DA90")]
		private void AdjustmentsForWolfMount()
		{
		}

		// Token: 0x06004383 RID: 17283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004383")]
		[Address(RVA = "0x50E198", Offset = "0x50E198", VA = "0x50E198")]
		private void AdjustmentsForVelociraptorMount()
		{
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004384")]
		[Address(RVA = "0x50E308", Offset = "0x50E308", VA = "0x50E308")]
		private void AdjustmentsForRatMount()
		{
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004385")]
		[Address(RVA = "0x50E31C", Offset = "0x50E31C", VA = "0x50E31C")]
		private void AdjustmentsForBatMount()
		{
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004386")]
		[Address(RVA = "0x50E330", Offset = "0x50E330", VA = "0x50E330")]
		private void AdjustmentsForPixieMount()
		{
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004387")]
		[Address(RVA = "0x50E344", Offset = "0x50E344", VA = "0x50E344")]
		private void CreateCompositeData()
		{
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004388")]
		[Address(RVA = "0x50EBD4", Offset = "0x50EBD4", VA = "0x50EBD4")]
		private void CreateCompositeData_DetermineShoulderOffsets(int armor, int targetFrameNumber)
		{
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004389")]
		[Address(RVA = "0x50EE5C", Offset = "0x50EE5C", VA = "0x50EE5C")]
		private void CreateCompositeFrameRect(int ptX, int ptY, ref Rectangle frame)
		{
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600438A")]
		[Address(RVA = "0x50EDE4", Offset = "0x50EDE4", VA = "0x50EDE4")]
		private void UpdateCompositeArm(ref Player.CompositeArmData data, ref float rotation, ref int frameIndexX, ref int frameIndexY, int targetX)
		{
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600438B")]
		[Address(RVA = "0x50EE84", Offset = "0x50EE84", VA = "0x50EE84")]
		public PlayerDrawSet()
		{
		}

		// Token: 0x04008ACA RID: 35530
		[Token(Token = "0x4008ACA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int DrawDataCacheCount;

		// Token: 0x04008ACB RID: 35531
		[Token(Token = "0x4008ACB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public DrawData[] DrawDataCache;

		// Token: 0x04008ACC RID: 35532
		[Token(Token = "0x4008ACC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<int> DustCache;

		// Token: 0x04008ACD RID: 35533
		[Token(Token = "0x4008ACD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public List<int> GoreCache;

		// Token: 0x04008ACE RID: 35534
		[Token(Token = "0x4008ACE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Player drawPlayer;

		// Token: 0x04008ACF RID: 35535
		[Token(Token = "0x4008ACF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float shadow;

		// Token: 0x04008AD0 RID: 35536
		[Token(Token = "0x4008AD0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 Position;

		// Token: 0x04008AD1 RID: 35537
		[Token(Token = "0x4008AD1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 VisualPositionOffset;

		// Token: 0x04008AD2 RID: 35538
		[Token(Token = "0x4008AD2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int projectileDrawPosition;

		// Token: 0x04008AD3 RID: 35539
		[Token(Token = "0x4008AD3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 ItemLocation;

		// Token: 0x04008AD4 RID: 35540
		[Token(Token = "0x4008AD4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int armorAdjust;

		// Token: 0x04008AD5 RID: 35541
		[Token(Token = "0x4008AD5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool missingHand;

		// Token: 0x04008AD6 RID: 35542
		[Token(Token = "0x4008AD6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool missingArm;

		// Token: 0x04008AD7 RID: 35543
		[Token(Token = "0x4008AD7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int skinVar;

		// Token: 0x04008AD8 RID: 35544
		[Token(Token = "0x4008AD8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool fullHair;

		// Token: 0x04008AD9 RID: 35545
		[Token(Token = "0x4008AD9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool drawsBackHairWithoutHeadgear;

		// Token: 0x04008ADA RID: 35546
		[Token(Token = "0x4008ADA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool hatHair;

		// Token: 0x04008ADB RID: 35547
		[Token(Token = "0x4008ADB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		public bool hideHair;

		// Token: 0x04008ADC RID: 35548
		[Token(Token = "0x4008ADC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int hairDyePacked;

		// Token: 0x04008ADD RID: 35549
		[Token(Token = "0x4008ADD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int skinDyePacked;

		// Token: 0x04008ADE RID: 35550
		[Token(Token = "0x4008ADE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float mountOffSet;

		// Token: 0x04008ADF RID: 35551
		[Token(Token = "0x4008ADF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int cHead;

		// Token: 0x04008AE0 RID: 35552
		[Token(Token = "0x4008AE0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int cBody;

		// Token: 0x04008AE1 RID: 35553
		[Token(Token = "0x4008AE1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int cLegs;

		// Token: 0x04008AE2 RID: 35554
		[Token(Token = "0x4008AE2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int cHandOn;

		// Token: 0x04008AE3 RID: 35555
		[Token(Token = "0x4008AE3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int cHandOff;

		// Token: 0x04008AE4 RID: 35556
		[Token(Token = "0x4008AE4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int cBack;

		// Token: 0x04008AE5 RID: 35557
		[Token(Token = "0x4008AE5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int cFront;

		// Token: 0x04008AE6 RID: 35558
		[Token(Token = "0x4008AE6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int cShoe;

		// Token: 0x04008AE7 RID: 35559
		[Token(Token = "0x4008AE7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int cFlameWaker;

		// Token: 0x04008AE8 RID: 35560
		[Token(Token = "0x4008AE8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int cWaist;

		// Token: 0x04008AE9 RID: 35561
		[Token(Token = "0x4008AE9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int cShield;

		// Token: 0x04008AEA RID: 35562
		[Token(Token = "0x4008AEA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public int cNeck;

		// Token: 0x04008AEB RID: 35563
		[Token(Token = "0x4008AEB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int cFace;

		// Token: 0x04008AEC RID: 35564
		[Token(Token = "0x4008AEC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public int cBalloon;

		// Token: 0x04008AED RID: 35565
		[Token(Token = "0x4008AED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int cWings;

		// Token: 0x04008AEE RID: 35566
		[Token(Token = "0x4008AEE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int cCarpet;

		// Token: 0x04008AEF RID: 35567
		[Token(Token = "0x4008AEF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int cPortableStool;

		// Token: 0x04008AF0 RID: 35568
		[Token(Token = "0x4008AF0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int cFloatingTube;

		// Token: 0x04008AF1 RID: 35569
		[Token(Token = "0x4008AF1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public int cUnicornHorn;

		// Token: 0x04008AF2 RID: 35570
		[Token(Token = "0x4008AF2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int cAngelHalo;

		// Token: 0x04008AF3 RID: 35571
		[Token(Token = "0x4008AF3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int cBeard;

		// Token: 0x04008AF4 RID: 35572
		[Token(Token = "0x4008AF4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public int cLeinShampoo;

		// Token: 0x04008AF5 RID: 35573
		[Token(Token = "0x4008AF5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int cBackpack;

		// Token: 0x04008AF6 RID: 35574
		[Token(Token = "0x4008AF6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public int cTail;

		// Token: 0x04008AF7 RID: 35575
		[Token(Token = "0x4008AF7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public int cFaceHead;

		// Token: 0x04008AF8 RID: 35576
		[Token(Token = "0x4008AF8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public int cFaceFlower;

		// Token: 0x04008AF9 RID: 35577
		[Token(Token = "0x4008AF9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public int cFaceMask;

		// Token: 0x04008AFA RID: 35578
		[Token(Token = "0x4008AFA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public int cBalloonFront;

		// Token: 0x04008AFB RID: 35579
		[Token(Token = "0x4008AFB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int cCoat;

		// Token: 0x04008AFC RID: 35580
		[Token(Token = "0x4008AFC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public SpriteEffects playerEffect;

		// Token: 0x04008AFD RID: 35581
		[Token(Token = "0x4008AFD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public SpriteEffects itemEffect;

		// Token: 0x04008AFE RID: 35582
		[Token(Token = "0x4008AFE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public Color colorHair;

		// Token: 0x04008AFF RID: 35583
		[Token(Token = "0x4008AFF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color colorEyeWhites;

		// Token: 0x04008B00 RID: 35584
		[Token(Token = "0x4008B00")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public Color colorEyes;

		// Token: 0x04008B01 RID: 35585
		[Token(Token = "0x4008B01")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Color colorHead;

		// Token: 0x04008B02 RID: 35586
		[Token(Token = "0x4008B02")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public Color colorBodySkin;

		// Token: 0x04008B03 RID: 35587
		[Token(Token = "0x4008B03")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Color colorLegs;

		// Token: 0x04008B04 RID: 35588
		[Token(Token = "0x4008B04")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public Color colorShirt;

		// Token: 0x04008B05 RID: 35589
		[Token(Token = "0x4008B05")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Color colorUnderShirt;

		// Token: 0x04008B06 RID: 35590
		[Token(Token = "0x4008B06")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public Color colorPants;

		// Token: 0x04008B07 RID: 35591
		[Token(Token = "0x4008B07")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Color colorShoes;

		// Token: 0x04008B08 RID: 35592
		[Token(Token = "0x4008B08")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public Color colorArmorHead;

		// Token: 0x04008B09 RID: 35593
		[Token(Token = "0x4008B09")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Color colorArmorBody;

		// Token: 0x04008B0A RID: 35594
		[Token(Token = "0x4008B0A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public Color colorMount;

		// Token: 0x04008B0B RID: 35595
		[Token(Token = "0x4008B0B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Color colorArmorLegs;

		// Token: 0x04008B0C RID: 35596
		[Token(Token = "0x4008B0C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Color colorElectricity;

		// Token: 0x04008B0D RID: 35597
		[Token(Token = "0x4008B0D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public Color colorDisplayDollSkin;

		// Token: 0x04008B0E RID: 35598
		[Token(Token = "0x4008B0E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int headGlowMask;

		// Token: 0x04008B0F RID: 35599
		[Token(Token = "0x4008B0F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public int bodyGlowMask;

		// Token: 0x04008B10 RID: 35600
		[Token(Token = "0x4008B10")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int armGlowMask;

		// Token: 0x04008B11 RID: 35601
		[Token(Token = "0x4008B11")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public int legsGlowMask;

		// Token: 0x04008B12 RID: 35602
		[Token(Token = "0x4008B12")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Color headGlowColor;

		// Token: 0x04008B13 RID: 35603
		[Token(Token = "0x4008B13")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public Color bodyGlowColor;

		// Token: 0x04008B14 RID: 35604
		[Token(Token = "0x4008B14")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public Color armGlowColor;

		// Token: 0x04008B15 RID: 35605
		[Token(Token = "0x4008B15")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public Color legsGlowColor;

		// Token: 0x04008B16 RID: 35606
		[Token(Token = "0x4008B16")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public Color ArkhalisColor;

		// Token: 0x04008B17 RID: 35607
		[Token(Token = "0x4008B17")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public float stealth;

		// Token: 0x04008B18 RID: 35608
		[Token(Token = "0x4008B18")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public Vector2 legVect;

		// Token: 0x04008B19 RID: 35609
		[Token(Token = "0x4008B19")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public Vector2 bodyVect;

		// Token: 0x04008B1A RID: 35610
		[Token(Token = "0x4008B1A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public Vector2 headVect;

		// Token: 0x04008B1B RID: 35611
		[Token(Token = "0x4008B1B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public Color selectionGlowColor;

		// Token: 0x04008B1C RID: 35612
		[Token(Token = "0x4008B1C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		public float torsoOffset;

		// Token: 0x04008B1D RID: 35613
		[Token(Token = "0x4008B1D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public bool hidesTopSkin;

		// Token: 0x04008B1E RID: 35614
		[Token(Token = "0x4008B1E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		public bool hidesBottomSkin;

		// Token: 0x04008B1F RID: 35615
		[Token(Token = "0x4008B1F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public float rotation;

		// Token: 0x04008B20 RID: 35616
		[Token(Token = "0x4008B20")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public Vector2 rotationOrigin;

		// Token: 0x04008B21 RID: 35617
		[Token(Token = "0x4008B21")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public Rectangle hairFrontFrame;

		// Token: 0x04008B22 RID: 35618
		[Token(Token = "0x4008B22")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public Rectangle hairBackFrame;

		// Token: 0x04008B23 RID: 35619
		[Token(Token = "0x4008B23")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public bool backHairDraw;

		// Token: 0x04008B24 RID: 35620
		[Token(Token = "0x4008B24")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x189")]
		public Color itemColor;

		// Token: 0x04008B25 RID: 35621
		[Token(Token = "0x4008B25")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18D")]
		public bool usesCompositeTorso;

		// Token: 0x04008B26 RID: 35622
		[Token(Token = "0x4008B26")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18E")]
		public bool usesCompositeFrontHandAcc;

		// Token: 0x04008B27 RID: 35623
		[Token(Token = "0x4008B27")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18F")]
		public bool usesCompositeBackHandAcc;

		// Token: 0x04008B28 RID: 35624
		[Token(Token = "0x4008B28")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public bool compShoulderOverFrontArm;

		// Token: 0x04008B29 RID: 35625
		[Token(Token = "0x4008B29")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		public Rectangle compBackShoulderFrame;

		// Token: 0x04008B2A RID: 35626
		[Token(Token = "0x4008B2A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		public Rectangle compFrontShoulderFrame;

		// Token: 0x04008B2B RID: 35627
		[Token(Token = "0x4008B2B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		public Rectangle compBackArmFrame;

		// Token: 0x04008B2C RID: 35628
		[Token(Token = "0x4008B2C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public Rectangle compFrontArmFrame;

		// Token: 0x04008B2D RID: 35629
		[Token(Token = "0x4008B2D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public Rectangle compTorsoFrame;

		// Token: 0x04008B2E RID: 35630
		[Token(Token = "0x4008B2E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public float compositeBackArmRotation;

		// Token: 0x04008B2F RID: 35631
		[Token(Token = "0x4008B2F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public float compositeFrontArmRotation;

		// Token: 0x04008B30 RID: 35632
		[Token(Token = "0x4008B30")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		public bool hideCompositeShoulders;

		// Token: 0x04008B31 RID: 35633
		[Token(Token = "0x4008B31")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public Vector2 frontShoulderOffset;

		// Token: 0x04008B32 RID: 35634
		[Token(Token = "0x4008B32")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public Vector2 backShoulderOffset;

		// Token: 0x04008B33 RID: 35635
		[Token(Token = "0x4008B33")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public WeaponDrawOrder weaponDrawOrder;

		// Token: 0x04008B34 RID: 35636
		[Token(Token = "0x4008B34")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		public bool weaponOverFrontArm;

		// Token: 0x04008B35 RID: 35637
		[Token(Token = "0x4008B35")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x205")]
		public bool isSitting;

		// Token: 0x04008B36 RID: 35638
		[Token(Token = "0x4008B36")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x206")]
		public bool isSleeping;

		// Token: 0x04008B37 RID: 35639
		[Token(Token = "0x4008B37")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public float seatYOffset;

		// Token: 0x04008B38 RID: 35640
		[Token(Token = "0x4008B38")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		public int sittingIndex;

		// Token: 0x04008B39 RID: 35641
		[Token(Token = "0x4008B39")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		public bool drawFrontAccInNeckAccLayer;

		// Token: 0x04008B3A RID: 35642
		[Token(Token = "0x4008B3A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x211")]
		public bool drawFrontAccInNeckAccLayerAlways;

		// Token: 0x04008B3B RID: 35643
		[Token(Token = "0x4008B3B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x212")]
		public bool mountHandlesHeadDraw;

		// Token: 0x04008B3C RID: 35644
		[Token(Token = "0x4008B3C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x213")]
		public bool mountDrawsEyelid;

		// Token: 0x04008B3D RID: 35645
		[Token(Token = "0x4008B3D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		public Item heldItem;

		// Token: 0x04008B3E RID: 35646
		[Token(Token = "0x4008B3E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public bool drawFloatingTube;

		// Token: 0x04008B3F RID: 35647
		[Token(Token = "0x4008B3F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x219")]
		public bool drawUnicornHorn;

		// Token: 0x04008B40 RID: 35648
		[Token(Token = "0x4008B40")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x21A")]
		public bool drawAngelHalo;

		// Token: 0x04008B41 RID: 35649
		[Token(Token = "0x4008B41")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x21B")]
		public Color floatingTubeColor;

		// Token: 0x04008B42 RID: 35650
		[Token(Token = "0x4008B42")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		public Vector2 hairOffset;

		// Token: 0x04008B43 RID: 35651
		[Token(Token = "0x4008B43")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		public Vector2 helmetOffset;

		// Token: 0x04008B44 RID: 35652
		[Token(Token = "0x4008B44")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		public Vector2 legsOffset;

		// Token: 0x04008B45 RID: 35653
		[Token(Token = "0x4008B45")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public bool hideEntirePlayer;

		// Token: 0x04008B46 RID: 35654
		[Token(Token = "0x4008B46")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x239")]
		public bool hideEntirePlayerExceptHelmetsAndFaceAccessories;

		// Token: 0x04008B47 RID: 35655
		[Token(Token = "0x4008B47")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		public Projectile SelectedDrawnProjectile;

		// Token: 0x04008B48 RID: 35656
		[Token(Token = "0x4008B48")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static Color baseHairColor;
	}
}
