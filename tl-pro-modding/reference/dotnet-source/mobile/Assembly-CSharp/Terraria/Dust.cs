using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Shaders;

namespace Terraria
{
	// Token: 0x02000467 RID: 1127
	[Token(Token = "0x2000467")]
	public class Dust
	{
		// Token: 0x06001F27 RID: 7975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F27")]
		[Address(RVA = "0xEA8650", Offset = "0xEA8650", VA = "0xEA8650")]
		public static void Reset()
		{
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F28")]
		[Address(RVA = "0xEA8874", Offset = "0xEA8874", VA = "0xEA8874")]
		public static Dust NewDustPerfect(Vector2 Position, int Type, [Optional] Vector2? Velocity, int Alpha = 0, [Optional] Color newColor, float Scale = 1f)
		{
			return null;
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F29")]
		[Address(RVA = "0xEA9C60", Offset = "0xEA9C60", VA = "0xEA9C60")]
		public static Dust NewDustDirect(Vector2 Position, int Width, int Height, int Type, float SpeedX = 0f, float SpeedY = 0f, int Alpha = 0, [Optional] Color newColor, float Scale = 1f)
		{
			return null;
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x0000EF40 File Offset: 0x0000D140
		[Token(Token = "0x6001F2A")]
		[Address(RVA = "0xEA8A00", Offset = "0xEA8A00", VA = "0xEA8A00")]
		public static int NewDust(Vector2 Position, int Width, int Height, int Type, float SpeedX = 0f, float SpeedY = 0f, int Alpha = 0, [Optional] Color newColor, float Scale = 1f)
		{
			return 0;
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2B")]
		[Address(RVA = "0xEA9F50", Offset = "0xEA9F50", VA = "0xEA9F50")]
		public static Dust CloneDust(int dustIndex)
		{
			return null;
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2C")]
		[Address(RVA = "0xEAA004", Offset = "0xEAA004", VA = "0xEAA004")]
		public static Dust CloneDust(Dust rf)
		{
			return null;
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F2D")]
		[Address(RVA = "0xEA9E6C", Offset = "0xEA9E6C", VA = "0xEA9E6C")]
		public static void SetNotActive(Dust dust)
		{
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2E")]
		[Address(RVA = "0xEAA2C8", Offset = "0xEAA2C8", VA = "0xEAA2C8")]
		public static Dust QuickDust(int x, int y, Color color)
		{
			return null;
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2F")]
		[Address(RVA = "0xEAA360", Offset = "0xEAA360", VA = "0xEAA360")]
		public static Dust QuickDust(Point tileCoords, Color color)
		{
			return null;
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F30")]
		[Address(RVA = "0xEAA5F0", Offset = "0xEAA5F0", VA = "0xEAA5F0")]
		public void HackFrame(int Type)
		{
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F31")]
		[Address(RVA = "0xEAA6D8", Offset = "0xEAA6D8", VA = "0xEAA6D8")]
		public static void QuickBox(Vector2 topLeft, Vector2 bottomRight, int divisions, Color color, float fadein = 1f, float dustScale = 1f, [Optional] Action<Dust> manipulator)
		{
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F32")]
		[Address(RVA = "0xEAAA08", Offset = "0xEAAA08", VA = "0xEAAA08")]
		public static void QuickCircle(Vector2 center, float radius, int divisions, Color color, Action<Dust> manipulator)
		{
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F33")]
		[Address(RVA = "0xEAAC58", Offset = "0xEAAC58", VA = "0xEAAC58")]
		public static void DrawDebugBox(Rectangle itemRectangle, [Optional] Color color)
		{
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F34")]
		[Address(RVA = "0xEAA438", Offset = "0xEAA438", VA = "0xEAA438")]
		public static Dust QuickDust(Vector2 pos, Color color)
		{
			return null;
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F35")]
		[Address(RVA = "0xEAAF00", Offset = "0xEAAF00", VA = "0xEAAF00")]
		public static Dust QuickDustSmall(Vector2 pos, Color color, bool floorPositionValues = false)
		{
			return null;
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F36")]
		[Address(RVA = "0xEAB01C", Offset = "0xEAB01C", VA = "0xEAB01C")]
		public static void QuickDustLine(Vector2 start, Vector2 end, float splits, Color color)
		{
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x0000EF58 File Offset: 0x0000D158
		[Token(Token = "0x6001F37")]
		[Address(RVA = "0xEAB1C8", Offset = "0xEAB1C8", VA = "0xEAB1C8")]
		public static int dustWater()
		{
			return 0;
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F38")]
		[Address(RVA = "0xEAB248", Offset = "0xEAB248", VA = "0xEAB248")]
		public static void UpdateDust()
		{
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F39")]
		[Address(RVA = "0xEB29B4", Offset = "0xEB29B4", VA = "0xEB29B4")]
		private static void SetupAlpha(short id, Color value)
		{
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F3A")]
		[Address(RVA = "0xEB2A58", Offset = "0xEB2A58", VA = "0xEB2A58")]
		public static void InitAlphaTable()
		{
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F3B")]
		[Address(RVA = "0xEB485C", Offset = "0xEB485C", VA = "0xEB485C")]
		public void GetAlpha(ref Color newColor)
		{
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x0000EF70 File Offset: 0x0000D170
		[Token(Token = "0x6001F3C")]
		[Address(RVA = "0xEB5584", Offset = "0xEB5584", VA = "0xEB5584")]
		public Color GetAlpha(Color newColor)
		{
			return default(Color);
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F3D")]
		[Address(RVA = "0xEB6BF8", Offset = "0xEB6BF8", VA = "0xEB6BF8")]
		public void GetColor(ref Color newColor)
		{
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x0000EF88 File Offset: 0x0000D188
		[Token(Token = "0x6001F3E")]
		[Address(RVA = "0xEB6C9C", Offset = "0xEB6C9C", VA = "0xEB6C9C")]
		public float GetVisualRotation()
		{
			return 0f;
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		[Token(Token = "0x6001F3F")]
		[Address(RVA = "0xEB6CB8", Offset = "0xEB6CB8", VA = "0xEB6CB8")]
		public float GetVisualScale()
		{
			return 0f;
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F40")]
		[Address(RVA = "0xEA8864", Offset = "0xEA8864", VA = "0xEA8864")]
		public Dust()
		{
		}

		// Token: 0x040031BA RID: 12730
		[Token(Token = "0x40031BA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int activeDustCount;

		// Token: 0x040031BB RID: 12731
		[Token(Token = "0x40031BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static Dust[] freeDust;

		// Token: 0x040031BC RID: 12732
		[Token(Token = "0x40031BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int freeDustCount;

		// Token: 0x040031BD RID: 12733
		[Token(Token = "0x40031BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static float dCount;

		// Token: 0x040031BE RID: 12734
		[Token(Token = "0x40031BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static int lavaBubbles;

		// Token: 0x040031BF RID: 12735
		[Token(Token = "0x40031BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static int SandStormCount;

		// Token: 0x040031C0 RID: 12736
		[Token(Token = "0x40031C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int dustIndex;

		// Token: 0x040031C1 RID: 12737
		[Token(Token = "0x40031C1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector2 position;

		// Token: 0x040031C2 RID: 12738
		[Token(Token = "0x40031C2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector2 velocity;

		// Token: 0x040031C3 RID: 12739
		[Token(Token = "0x40031C3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float fadeIn;

		// Token: 0x040031C4 RID: 12740
		[Token(Token = "0x40031C4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool noGravity;

		// Token: 0x040031C5 RID: 12741
		[Token(Token = "0x40031C5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float scale;

		// Token: 0x040031C6 RID: 12742
		[Token(Token = "0x40031C6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rotation;

		// Token: 0x040031C7 RID: 12743
		[Token(Token = "0x40031C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool noLight;

		// Token: 0x040031C8 RID: 12744
		[Token(Token = "0x40031C8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool noLightEmittance;

		// Token: 0x040031C9 RID: 12745
		[Token(Token = "0x40031C9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		public bool fullBright;

		// Token: 0x040031CA RID: 12746
		[Token(Token = "0x40031CA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
		public bool active;

		// Token: 0x040031CB RID: 12747
		[Token(Token = "0x40031CB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int type;

		// Token: 0x040031CC RID: 12748
		[Token(Token = "0x40031CC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color color;

		// Token: 0x040031CD RID: 12749
		[Token(Token = "0x40031CD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int alpha;

		// Token: 0x040031CE RID: 12750
		[Token(Token = "0x40031CE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Rectangle frame;

		// Token: 0x040031CF RID: 12751
		[Token(Token = "0x40031CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public ArmorShaderData shader;

		// Token: 0x040031D0 RID: 12752
		[Token(Token = "0x40031D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public object customData;

		// Token: 0x040031D1 RID: 12753
		[Token(Token = "0x40031D1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool firstFrame;

		// Token: 0x040031D2 RID: 12754
		[Token(Token = "0x40031D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int instancedPlayer;

		// Token: 0x040031D3 RID: 12755
		[Token(Token = "0x40031D3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool[] StaticAlpha;

		// Token: 0x040031D4 RID: 12756
		[Token(Token = "0x40031D4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static Color[] StaticAlphaValue;
	}
}
