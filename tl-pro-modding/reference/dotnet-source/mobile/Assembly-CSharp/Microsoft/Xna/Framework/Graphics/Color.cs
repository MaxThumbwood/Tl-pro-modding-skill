using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003C8 RID: 968
	[Token(Token = "0x20003C8")]
	[Serializable]
	public struct Color : FileAPI
	{
		// Token: 0x06001A2C RID: 6700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A2C")]
		[Address(RVA = "0xE31334", Offset = "0xE31334", VA = "0xE31334")]
		public Color(Vector3 vector)
		{
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A2D")]
		[Address(RVA = "0xE31608", Offset = "0xE31608", VA = "0xE31608")]
		public Color(Vector4 vector)
		{
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A2E")]
		[Address(RVA = "0xE3199C", Offset = "0xE3199C", VA = "0xE3199C")]
		public Color(int r, int g, int b)
		{
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A2F")]
		[Address(RVA = "0xE319B4", Offset = "0xE319B4", VA = "0xE319B4")]
		public Color(int r, int g, int b, int a)
		{
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A30")]
		[Address(RVA = "0xE319CC", Offset = "0xE319CC", VA = "0xE319CC")]
		public Color(float r, float g, float b)
		{
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A31")]
		[Address(RVA = "0xE31C70", Offset = "0xE31C70", VA = "0xE31C70")]
		public Color(float r, float g, float b, float a)
		{
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A32")]
		[Address(RVA = "0xE31FC0", Offset = "0xE31FC0", VA = "0xE31FC0")]
		public Color(Color rgb, int a)
		{
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A33")]
		[Address(RVA = "0xE31FE0", Offset = "0xE31FE0", VA = "0xE31FE0")]
		public Color(Color rgb, float a)
		{
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		[Token(Token = "0x6001A34")]
		[Address(RVA = "0xE32124", Offset = "0xE32124", VA = "0xE32124")]
		public ushort RGB565()
		{
			return 0;
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		[Token(Token = "0x6001A35")]
		[Address(RVA = "0xE32148", Offset = "0xE32148", VA = "0xE32148")]
		public ushort ARGB4444()
		{
			return 0;
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		[Token(Token = "0x6001A36")]
		[Address(RVA = "0xE32178", Offset = "0xE32178", VA = "0xE32178")]
		public Color32 RenderColour()
		{
			return default(Color32);
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		// (set) Token: 0x06001A38 RID: 6712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002DF")]
		public uint PackedValue
		{
			[Token(Token = "0x6001A37")]
			[Address(RVA = "0xE32184", Offset = "0xE32184", VA = "0xE32184")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001A38")]
			[Address(RVA = "0xE32190", Offset = "0xE32190", VA = "0xE32190")]
			set
			{
			}
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0000CB10 File Offset: 0x0000AD10
		[Token(Token = "0x6001A39")]
		[Address(RVA = "0xE3219C", Offset = "0xE3219C", VA = "0xE3219C")]
		public static bool operator ==(Color colorA, Color colorB)
		{
			return default(bool);
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0000CB28 File Offset: 0x0000AD28
		[Token(Token = "0x6001A3A")]
		[Address(RVA = "0xE321AC", Offset = "0xE321AC", VA = "0xE321AC")]
		public static bool operator !=(Color colorA, Color colorB)
		{
			return default(bool);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0000CB40 File Offset: 0x0000AD40
		[Token(Token = "0x6001A3B")]
		[Address(RVA = "0xE32214", Offset = "0xE32214", VA = "0xE32214")]
		internal float GetBrightness()
		{
			return 0f;
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0000CB58 File Offset: 0x0000AD58
		[Token(Token = "0x6001A3C")]
		[Address(RVA = "0xE322E0", Offset = "0xE322E0", VA = "0xE322E0")]
		internal float GetSaturation()
		{
			return 0f;
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x0000CB70 File Offset: 0x0000AD70
		[Token(Token = "0x6001A3D")]
		[Address(RVA = "0xE323D4", Offset = "0xE323D4", VA = "0xE323D4")]
		internal float GetHue()
		{
			return 0f;
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x0000CB88 File Offset: 0x0000AD88
		[Token(Token = "0x6001A3E")]
		[Address(RVA = "0xE32554", Offset = "0xE32554", VA = "0xE32554", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
		[Token(Token = "0x6001A3F")]
		[Address(RVA = "0xE325F0", Offset = "0xE325F0", VA = "0xE325F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A40")]
		[Address(RVA = "0xE32614", Offset = "0xE32614", VA = "0xE32614", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		[Token(Token = "0x6001A41")]
		[Address(RVA = "0xE3283C", Offset = "0xE3283C", VA = "0xE3283C")]
		public Vector4 ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		[Token(Token = "0x6001A42")]
		[Address(RVA = "0xE328B8", Offset = "0xE328B8", VA = "0xE328B8")]
		public Vector3 ToVector3()
		{
			return default(Vector3);
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		[Token(Token = "0x6001A43")]
		[Address(RVA = "0xE32928", Offset = "0xE32928", VA = "0xE32928")]
		public static Color operator *(Color a, float amount)
		{
			return default(Color);
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0000CC00 File Offset: 0x0000AE00
		[Token(Token = "0x6001A44")]
		[Address(RVA = "0xE329E0", Offset = "0xE329E0", VA = "0xE329E0")]
		public static Color Multiply(Color a, float amount)
		{
			return default(Color);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0000CC18 File Offset: 0x0000AE18
		[Token(Token = "0x6001A45")]
		[Address(RVA = "0xE32B00", Offset = "0xE32B00", VA = "0xE32B00")]
		public static Color MultiplyClamped(Color a, float amount)
		{
			return default(Color);
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0000CC30 File Offset: 0x0000AE30
		[Token(Token = "0x6001A46")]
		[Address(RVA = "0xE32CB8", Offset = "0xE32CB8", VA = "0xE32CB8")]
		public static Color Lerp(Color value1, Color value2, float amount)
		{
			return default(Color);
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0000CC48 File Offset: 0x0000AE48
		[Token(Token = "0x6001A47")]
		[Address(RVA = "0xE330BC", Offset = "0xE330BC", VA = "0xE330BC", Slot = "4")]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		// Token: 0x04002CCD RID: 11469
		[Token(Token = "0x4002CCD")]
		[FieldOffset(Offset = "0x0")]
		public byte A;

		// Token: 0x04002CCE RID: 11470
		[Token(Token = "0x4002CCE")]
		[FieldOffset(Offset = "0x1")]
		public byte B;

		// Token: 0x04002CCF RID: 11471
		[Token(Token = "0x4002CCF")]
		[FieldOffset(Offset = "0x2")]
		public byte G;

		// Token: 0x04002CD0 RID: 11472
		[Token(Token = "0x4002CD0")]
		[FieldOffset(Offset = "0x3")]
		public byte R;

		// Token: 0x04002CD1 RID: 11473
		[Token(Token = "0x4002CD1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Color Transparent;

		// Token: 0x04002CD2 RID: 11474
		[Token(Token = "0x4002CD2")]
		[FieldOffset(Offset = "0x4")]
		public static readonly Color TransparentBlack;

		// Token: 0x04002CD3 RID: 11475
		[Token(Token = "0x4002CD3")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Color TransparentWhite;

		// Token: 0x04002CD4 RID: 11476
		[Token(Token = "0x4002CD4")]
		[FieldOffset(Offset = "0xC")]
		public static readonly Color AliceBlue;

		// Token: 0x04002CD5 RID: 11477
		[Token(Token = "0x4002CD5")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Color AntiqueWhite;

		// Token: 0x04002CD6 RID: 11478
		[Token(Token = "0x4002CD6")]
		[FieldOffset(Offset = "0x14")]
		public static readonly Color Aqua;

		// Token: 0x04002CD7 RID: 11479
		[Token(Token = "0x4002CD7")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Color Aquamarine;

		// Token: 0x04002CD8 RID: 11480
		[Token(Token = "0x4002CD8")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly Color Azure;

		// Token: 0x04002CD9 RID: 11481
		[Token(Token = "0x4002CD9")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Color Beige;

		// Token: 0x04002CDA RID: 11482
		[Token(Token = "0x4002CDA")]
		[FieldOffset(Offset = "0x24")]
		public static readonly Color Bisque;

		// Token: 0x04002CDB RID: 11483
		[Token(Token = "0x4002CDB")]
		[FieldOffset(Offset = "0x28")]
		public static readonly Color Black;

		// Token: 0x04002CDC RID: 11484
		[Token(Token = "0x4002CDC")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly Color BlanchedAlmond;

		// Token: 0x04002CDD RID: 11485
		[Token(Token = "0x4002CDD")]
		[FieldOffset(Offset = "0x30")]
		public static readonly Color Blue;

		// Token: 0x04002CDE RID: 11486
		[Token(Token = "0x4002CDE")]
		[FieldOffset(Offset = "0x34")]
		public static readonly Color BlueViolet;

		// Token: 0x04002CDF RID: 11487
		[Token(Token = "0x4002CDF")]
		[FieldOffset(Offset = "0x38")]
		public static readonly Color Brown;

		// Token: 0x04002CE0 RID: 11488
		[Token(Token = "0x4002CE0")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly Color BurlyWood;

		// Token: 0x04002CE1 RID: 11489
		[Token(Token = "0x4002CE1")]
		[FieldOffset(Offset = "0x40")]
		public static readonly Color CadetBlue;

		// Token: 0x04002CE2 RID: 11490
		[Token(Token = "0x4002CE2")]
		[FieldOffset(Offset = "0x44")]
		public static readonly Color Chartreuse;

		// Token: 0x04002CE3 RID: 11491
		[Token(Token = "0x4002CE3")]
		[FieldOffset(Offset = "0x48")]
		public static readonly Color Chocolate;

		// Token: 0x04002CE4 RID: 11492
		[Token(Token = "0x4002CE4")]
		[FieldOffset(Offset = "0x4C")]
		public static readonly Color Coral;

		// Token: 0x04002CE5 RID: 11493
		[Token(Token = "0x4002CE5")]
		[FieldOffset(Offset = "0x50")]
		public static readonly Color CornflowerBlue;

		// Token: 0x04002CE6 RID: 11494
		[Token(Token = "0x4002CE6")]
		[FieldOffset(Offset = "0x54")]
		public static readonly Color Cornsilk;

		// Token: 0x04002CE7 RID: 11495
		[Token(Token = "0x4002CE7")]
		[FieldOffset(Offset = "0x58")]
		public static readonly Color Crimson;

		// Token: 0x04002CE8 RID: 11496
		[Token(Token = "0x4002CE8")]
		[FieldOffset(Offset = "0x5C")]
		public static readonly Color Cyan;

		// Token: 0x04002CE9 RID: 11497
		[Token(Token = "0x4002CE9")]
		[FieldOffset(Offset = "0x60")]
		public static readonly Color DarkBlue;

		// Token: 0x04002CEA RID: 11498
		[Token(Token = "0x4002CEA")]
		[FieldOffset(Offset = "0x64")]
		public static readonly Color DarkCyan;

		// Token: 0x04002CEB RID: 11499
		[Token(Token = "0x4002CEB")]
		[FieldOffset(Offset = "0x68")]
		public static readonly Color DarkGoldenrod;

		// Token: 0x04002CEC RID: 11500
		[Token(Token = "0x4002CEC")]
		[FieldOffset(Offset = "0x6C")]
		public static readonly Color DarkGray;

		// Token: 0x04002CED RID: 11501
		[Token(Token = "0x4002CED")]
		[FieldOffset(Offset = "0x70")]
		public static readonly Color DarkGreen;

		// Token: 0x04002CEE RID: 11502
		[Token(Token = "0x4002CEE")]
		[FieldOffset(Offset = "0x74")]
		public static readonly Color DarkKhaki;

		// Token: 0x04002CEF RID: 11503
		[Token(Token = "0x4002CEF")]
		[FieldOffset(Offset = "0x78")]
		public static readonly Color DarkMagenta;

		// Token: 0x04002CF0 RID: 11504
		[Token(Token = "0x4002CF0")]
		[FieldOffset(Offset = "0x7C")]
		public static readonly Color DarkOliveGreen;

		// Token: 0x04002CF1 RID: 11505
		[Token(Token = "0x4002CF1")]
		[FieldOffset(Offset = "0x80")]
		public static readonly Color DarkOrange;

		// Token: 0x04002CF2 RID: 11506
		[Token(Token = "0x4002CF2")]
		[FieldOffset(Offset = "0x84")]
		public static readonly Color DarkOrchid;

		// Token: 0x04002CF3 RID: 11507
		[Token(Token = "0x4002CF3")]
		[FieldOffset(Offset = "0x88")]
		public static readonly Color DarkRed;

		// Token: 0x04002CF4 RID: 11508
		[Token(Token = "0x4002CF4")]
		[FieldOffset(Offset = "0x8C")]
		public static readonly Color DarkSalmon;

		// Token: 0x04002CF5 RID: 11509
		[Token(Token = "0x4002CF5")]
		[FieldOffset(Offset = "0x90")]
		public static readonly Color DarkSeaGreen;

		// Token: 0x04002CF6 RID: 11510
		[Token(Token = "0x4002CF6")]
		[FieldOffset(Offset = "0x94")]
		public static readonly Color DarkSlateBlue;

		// Token: 0x04002CF7 RID: 11511
		[Token(Token = "0x4002CF7")]
		[FieldOffset(Offset = "0x98")]
		public static readonly Color DarkSlateGray;

		// Token: 0x04002CF8 RID: 11512
		[Token(Token = "0x4002CF8")]
		[FieldOffset(Offset = "0x9C")]
		public static readonly Color DarkTurquoise;

		// Token: 0x04002CF9 RID: 11513
		[Token(Token = "0x4002CF9")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly Color DarkViolet;

		// Token: 0x04002CFA RID: 11514
		[Token(Token = "0x4002CFA")]
		[FieldOffset(Offset = "0xA4")]
		public static readonly Color DeepPink;

		// Token: 0x04002CFB RID: 11515
		[Token(Token = "0x4002CFB")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly Color DeepSkyBlue;

		// Token: 0x04002CFC RID: 11516
		[Token(Token = "0x4002CFC")]
		[FieldOffset(Offset = "0xAC")]
		public static readonly Color DimGray;

		// Token: 0x04002CFD RID: 11517
		[Token(Token = "0x4002CFD")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly Color DodgerBlue;

		// Token: 0x04002CFE RID: 11518
		[Token(Token = "0x4002CFE")]
		[FieldOffset(Offset = "0xB4")]
		public static readonly Color Firebrick;

		// Token: 0x04002CFF RID: 11519
		[Token(Token = "0x4002CFF")]
		[FieldOffset(Offset = "0xB8")]
		public static readonly Color FloralWhite;

		// Token: 0x04002D00 RID: 11520
		[Token(Token = "0x4002D00")]
		[FieldOffset(Offset = "0xBC")]
		public static readonly Color ForestGreen;

		// Token: 0x04002D01 RID: 11521
		[Token(Token = "0x4002D01")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly Color Fuchsia;

		// Token: 0x04002D02 RID: 11522
		[Token(Token = "0x4002D02")]
		[FieldOffset(Offset = "0xC4")]
		public static readonly Color Gainsboro;

		// Token: 0x04002D03 RID: 11523
		[Token(Token = "0x4002D03")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly Color GhostWhite;

		// Token: 0x04002D04 RID: 11524
		[Token(Token = "0x4002D04")]
		[FieldOffset(Offset = "0xCC")]
		public static readonly Color Gold;

		// Token: 0x04002D05 RID: 11525
		[Token(Token = "0x4002D05")]
		[FieldOffset(Offset = "0xD0")]
		public static readonly Color Goldenrod;

		// Token: 0x04002D06 RID: 11526
		[Token(Token = "0x4002D06")]
		[FieldOffset(Offset = "0xD4")]
		public static readonly Color Gray;

		// Token: 0x04002D07 RID: 11527
		[Token(Token = "0x4002D07")]
		[FieldOffset(Offset = "0xD8")]
		public static readonly Color Green;

		// Token: 0x04002D08 RID: 11528
		[Token(Token = "0x4002D08")]
		[FieldOffset(Offset = "0xDC")]
		public static readonly Color GreenYellow;

		// Token: 0x04002D09 RID: 11529
		[Token(Token = "0x4002D09")]
		[FieldOffset(Offset = "0xE0")]
		public static readonly Color Honeydew;

		// Token: 0x04002D0A RID: 11530
		[Token(Token = "0x4002D0A")]
		[FieldOffset(Offset = "0xE4")]
		public static readonly Color HotPink;

		// Token: 0x04002D0B RID: 11531
		[Token(Token = "0x4002D0B")]
		[FieldOffset(Offset = "0xE8")]
		public static readonly Color IndianRed;

		// Token: 0x04002D0C RID: 11532
		[Token(Token = "0x4002D0C")]
		[FieldOffset(Offset = "0xEC")]
		public static readonly Color Indigo;

		// Token: 0x04002D0D RID: 11533
		[Token(Token = "0x4002D0D")]
		[FieldOffset(Offset = "0xF0")]
		public static readonly Color Ivory;

		// Token: 0x04002D0E RID: 11534
		[Token(Token = "0x4002D0E")]
		[FieldOffset(Offset = "0xF4")]
		public static readonly Color Khaki;

		// Token: 0x04002D0F RID: 11535
		[Token(Token = "0x4002D0F")]
		[FieldOffset(Offset = "0xF8")]
		public static readonly Color Lavender;

		// Token: 0x04002D10 RID: 11536
		[Token(Token = "0x4002D10")]
		[FieldOffset(Offset = "0xFC")]
		public static readonly Color LavenderBlush;

		// Token: 0x04002D11 RID: 11537
		[Token(Token = "0x4002D11")]
		[FieldOffset(Offset = "0x100")]
		public static readonly Color LawnGreen;

		// Token: 0x04002D12 RID: 11538
		[Token(Token = "0x4002D12")]
		[FieldOffset(Offset = "0x104")]
		public static readonly Color LemonChiffon;

		// Token: 0x04002D13 RID: 11539
		[Token(Token = "0x4002D13")]
		[FieldOffset(Offset = "0x108")]
		public static readonly Color LightBlue;

		// Token: 0x04002D14 RID: 11540
		[Token(Token = "0x4002D14")]
		[FieldOffset(Offset = "0x10C")]
		public static readonly Color LightCoral;

		// Token: 0x04002D15 RID: 11541
		[Token(Token = "0x4002D15")]
		[FieldOffset(Offset = "0x110")]
		public static readonly Color LightCyan;

		// Token: 0x04002D16 RID: 11542
		[Token(Token = "0x4002D16")]
		[FieldOffset(Offset = "0x114")]
		public static readonly Color LightGoldenrodYellow;

		// Token: 0x04002D17 RID: 11543
		[Token(Token = "0x4002D17")]
		[FieldOffset(Offset = "0x118")]
		public static readonly Color LightGreen;

		// Token: 0x04002D18 RID: 11544
		[Token(Token = "0x4002D18")]
		[FieldOffset(Offset = "0x11C")]
		public static readonly Color LightGray;

		// Token: 0x04002D19 RID: 11545
		[Token(Token = "0x4002D19")]
		[FieldOffset(Offset = "0x120")]
		public static readonly Color LightPink;

		// Token: 0x04002D1A RID: 11546
		[Token(Token = "0x4002D1A")]
		[FieldOffset(Offset = "0x124")]
		public static readonly Color LightSalmon;

		// Token: 0x04002D1B RID: 11547
		[Token(Token = "0x4002D1B")]
		[FieldOffset(Offset = "0x128")]
		public static readonly Color LightSeaGreen;

		// Token: 0x04002D1C RID: 11548
		[Token(Token = "0x4002D1C")]
		[FieldOffset(Offset = "0x12C")]
		public static readonly Color LightSkyBlue;

		// Token: 0x04002D1D RID: 11549
		[Token(Token = "0x4002D1D")]
		[FieldOffset(Offset = "0x130")]
		public static readonly Color LightSlateGray;

		// Token: 0x04002D1E RID: 11550
		[Token(Token = "0x4002D1E")]
		[FieldOffset(Offset = "0x134")]
		public static readonly Color LightSteelBlue;

		// Token: 0x04002D1F RID: 11551
		[Token(Token = "0x4002D1F")]
		[FieldOffset(Offset = "0x138")]
		public static readonly Color LightYellow;

		// Token: 0x04002D20 RID: 11552
		[Token(Token = "0x4002D20")]
		[FieldOffset(Offset = "0x13C")]
		public static readonly Color Lime;

		// Token: 0x04002D21 RID: 11553
		[Token(Token = "0x4002D21")]
		[FieldOffset(Offset = "0x140")]
		public static readonly Color LimeGreen;

		// Token: 0x04002D22 RID: 11554
		[Token(Token = "0x4002D22")]
		[FieldOffset(Offset = "0x144")]
		public static readonly Color Linen;

		// Token: 0x04002D23 RID: 11555
		[Token(Token = "0x4002D23")]
		[FieldOffset(Offset = "0x148")]
		public static readonly Color Magenta;

		// Token: 0x04002D24 RID: 11556
		[Token(Token = "0x4002D24")]
		[FieldOffset(Offset = "0x14C")]
		public static readonly Color Maroon;

		// Token: 0x04002D25 RID: 11557
		[Token(Token = "0x4002D25")]
		[FieldOffset(Offset = "0x150")]
		public static readonly Color MediumAquamarine;

		// Token: 0x04002D26 RID: 11558
		[Token(Token = "0x4002D26")]
		[FieldOffset(Offset = "0x154")]
		public static readonly Color MediumBlue;

		// Token: 0x04002D27 RID: 11559
		[Token(Token = "0x4002D27")]
		[FieldOffset(Offset = "0x158")]
		public static readonly Color MediumOrchid;

		// Token: 0x04002D28 RID: 11560
		[Token(Token = "0x4002D28")]
		[FieldOffset(Offset = "0x15C")]
		public static readonly Color MediumPurple;

		// Token: 0x04002D29 RID: 11561
		[Token(Token = "0x4002D29")]
		[FieldOffset(Offset = "0x160")]
		public static readonly Color MediumSeaGreen;

		// Token: 0x04002D2A RID: 11562
		[Token(Token = "0x4002D2A")]
		[FieldOffset(Offset = "0x164")]
		public static readonly Color MediumSlateBlue;

		// Token: 0x04002D2B RID: 11563
		[Token(Token = "0x4002D2B")]
		[FieldOffset(Offset = "0x168")]
		public static readonly Color MediumSpringGreen;

		// Token: 0x04002D2C RID: 11564
		[Token(Token = "0x4002D2C")]
		[FieldOffset(Offset = "0x16C")]
		public static readonly Color MediumTurquoise;

		// Token: 0x04002D2D RID: 11565
		[Token(Token = "0x4002D2D")]
		[FieldOffset(Offset = "0x170")]
		public static readonly Color MediumVioletRed;

		// Token: 0x04002D2E RID: 11566
		[Token(Token = "0x4002D2E")]
		[FieldOffset(Offset = "0x174")]
		public static readonly Color MidnightBlue;

		// Token: 0x04002D2F RID: 11567
		[Token(Token = "0x4002D2F")]
		[FieldOffset(Offset = "0x178")]
		public static readonly Color MintCream;

		// Token: 0x04002D30 RID: 11568
		[Token(Token = "0x4002D30")]
		[FieldOffset(Offset = "0x17C")]
		public static readonly Color MistyRose;

		// Token: 0x04002D31 RID: 11569
		[Token(Token = "0x4002D31")]
		[FieldOffset(Offset = "0x180")]
		public static readonly Color Moccasin;

		// Token: 0x04002D32 RID: 11570
		[Token(Token = "0x4002D32")]
		[FieldOffset(Offset = "0x184")]
		public static readonly Color NavajoWhite;

		// Token: 0x04002D33 RID: 11571
		[Token(Token = "0x4002D33")]
		[FieldOffset(Offset = "0x188")]
		public static readonly Color Navy;

		// Token: 0x04002D34 RID: 11572
		[Token(Token = "0x4002D34")]
		[FieldOffset(Offset = "0x18C")]
		public static readonly Color OldLace;

		// Token: 0x04002D35 RID: 11573
		[Token(Token = "0x4002D35")]
		[FieldOffset(Offset = "0x190")]
		public static readonly Color Olive;

		// Token: 0x04002D36 RID: 11574
		[Token(Token = "0x4002D36")]
		[FieldOffset(Offset = "0x194")]
		public static readonly Color OliveDrab;

		// Token: 0x04002D37 RID: 11575
		[Token(Token = "0x4002D37")]
		[FieldOffset(Offset = "0x198")]
		public static readonly Color Orange;

		// Token: 0x04002D38 RID: 11576
		[Token(Token = "0x4002D38")]
		[FieldOffset(Offset = "0x19C")]
		public static readonly Color OrangeRed;

		// Token: 0x04002D39 RID: 11577
		[Token(Token = "0x4002D39")]
		[FieldOffset(Offset = "0x1A0")]
		public static readonly Color Orchid;

		// Token: 0x04002D3A RID: 11578
		[Token(Token = "0x4002D3A")]
		[FieldOffset(Offset = "0x1A4")]
		public static readonly Color PaleGoldenrod;

		// Token: 0x04002D3B RID: 11579
		[Token(Token = "0x4002D3B")]
		[FieldOffset(Offset = "0x1A8")]
		public static readonly Color PaleGreen;

		// Token: 0x04002D3C RID: 11580
		[Token(Token = "0x4002D3C")]
		[FieldOffset(Offset = "0x1AC")]
		public static readonly Color PaleTurquoise;

		// Token: 0x04002D3D RID: 11581
		[Token(Token = "0x4002D3D")]
		[FieldOffset(Offset = "0x1B0")]
		public static readonly Color PaleVioletRed;

		// Token: 0x04002D3E RID: 11582
		[Token(Token = "0x4002D3E")]
		[FieldOffset(Offset = "0x1B4")]
		public static readonly Color PapayaWhip;

		// Token: 0x04002D3F RID: 11583
		[Token(Token = "0x4002D3F")]
		[FieldOffset(Offset = "0x1B8")]
		public static readonly Color PeachPuff;

		// Token: 0x04002D40 RID: 11584
		[Token(Token = "0x4002D40")]
		[FieldOffset(Offset = "0x1BC")]
		public static readonly Color Peru;

		// Token: 0x04002D41 RID: 11585
		[Token(Token = "0x4002D41")]
		[FieldOffset(Offset = "0x1C0")]
		public static readonly Color Pink;

		// Token: 0x04002D42 RID: 11586
		[Token(Token = "0x4002D42")]
		[FieldOffset(Offset = "0x1C4")]
		public static readonly Color Plum;

		// Token: 0x04002D43 RID: 11587
		[Token(Token = "0x4002D43")]
		[FieldOffset(Offset = "0x1C8")]
		public static readonly Color PowderBlue;

		// Token: 0x04002D44 RID: 11588
		[Token(Token = "0x4002D44")]
		[FieldOffset(Offset = "0x1CC")]
		public static readonly Color Purple;

		// Token: 0x04002D45 RID: 11589
		[Token(Token = "0x4002D45")]
		[FieldOffset(Offset = "0x1D0")]
		public static readonly Color Red;

		// Token: 0x04002D46 RID: 11590
		[Token(Token = "0x4002D46")]
		[FieldOffset(Offset = "0x1D4")]
		public static readonly Color RosyBrown;

		// Token: 0x04002D47 RID: 11591
		[Token(Token = "0x4002D47")]
		[FieldOffset(Offset = "0x1D8")]
		public static readonly Color RoyalBlue;

		// Token: 0x04002D48 RID: 11592
		[Token(Token = "0x4002D48")]
		[FieldOffset(Offset = "0x1DC")]
		public static readonly Color SaddleBrown;

		// Token: 0x04002D49 RID: 11593
		[Token(Token = "0x4002D49")]
		[FieldOffset(Offset = "0x1E0")]
		public static readonly Color Salmon;

		// Token: 0x04002D4A RID: 11594
		[Token(Token = "0x4002D4A")]
		[FieldOffset(Offset = "0x1E4")]
		public static readonly Color SandyBrown;

		// Token: 0x04002D4B RID: 11595
		[Token(Token = "0x4002D4B")]
		[FieldOffset(Offset = "0x1E8")]
		public static readonly Color SeaGreen;

		// Token: 0x04002D4C RID: 11596
		[Token(Token = "0x4002D4C")]
		[FieldOffset(Offset = "0x1EC")]
		public static readonly Color SeaShell;

		// Token: 0x04002D4D RID: 11597
		[Token(Token = "0x4002D4D")]
		[FieldOffset(Offset = "0x1F0")]
		public static readonly Color Sienna;

		// Token: 0x04002D4E RID: 11598
		[Token(Token = "0x4002D4E")]
		[FieldOffset(Offset = "0x1F4")]
		public static readonly Color Silver;

		// Token: 0x04002D4F RID: 11599
		[Token(Token = "0x4002D4F")]
		[FieldOffset(Offset = "0x1F8")]
		public static readonly Color SkyBlue;

		// Token: 0x04002D50 RID: 11600
		[Token(Token = "0x4002D50")]
		[FieldOffset(Offset = "0x1FC")]
		public static readonly Color SlateBlue;

		// Token: 0x04002D51 RID: 11601
		[Token(Token = "0x4002D51")]
		[FieldOffset(Offset = "0x200")]
		public static readonly Color SlateGray;

		// Token: 0x04002D52 RID: 11602
		[Token(Token = "0x4002D52")]
		[FieldOffset(Offset = "0x204")]
		public static readonly Color Snow;

		// Token: 0x04002D53 RID: 11603
		[Token(Token = "0x4002D53")]
		[FieldOffset(Offset = "0x208")]
		public static readonly Color SpringGreen;

		// Token: 0x04002D54 RID: 11604
		[Token(Token = "0x4002D54")]
		[FieldOffset(Offset = "0x20C")]
		public static readonly Color SteelBlue;

		// Token: 0x04002D55 RID: 11605
		[Token(Token = "0x4002D55")]
		[FieldOffset(Offset = "0x210")]
		public static readonly Color Tan;

		// Token: 0x04002D56 RID: 11606
		[Token(Token = "0x4002D56")]
		[FieldOffset(Offset = "0x214")]
		public static readonly Color Teal;

		// Token: 0x04002D57 RID: 11607
		[Token(Token = "0x4002D57")]
		[FieldOffset(Offset = "0x218")]
		public static readonly Color Thistle;

		// Token: 0x04002D58 RID: 11608
		[Token(Token = "0x4002D58")]
		[FieldOffset(Offset = "0x21C")]
		public static readonly Color Tomato;

		// Token: 0x04002D59 RID: 11609
		[Token(Token = "0x4002D59")]
		[FieldOffset(Offset = "0x220")]
		public static readonly Color Turquoise;

		// Token: 0x04002D5A RID: 11610
		[Token(Token = "0x4002D5A")]
		[FieldOffset(Offset = "0x224")]
		public static readonly Color Violet;

		// Token: 0x04002D5B RID: 11611
		[Token(Token = "0x4002D5B")]
		[FieldOffset(Offset = "0x228")]
		public static readonly Color Wheat;

		// Token: 0x04002D5C RID: 11612
		[Token(Token = "0x4002D5C")]
		[FieldOffset(Offset = "0x22C")]
		public static readonly Color White;

		// Token: 0x04002D5D RID: 11613
		[Token(Token = "0x4002D5D")]
		[FieldOffset(Offset = "0x230")]
		public static readonly Color WhiteSmoke;

		// Token: 0x04002D5E RID: 11614
		[Token(Token = "0x4002D5E")]
		[FieldOffset(Offset = "0x234")]
		public static readonly Color Yellow;

		// Token: 0x04002D5F RID: 11615
		[Token(Token = "0x4002D5F")]
		[FieldOffset(Offset = "0x238")]
		public static readonly Color YellowGreen;
	}
}
