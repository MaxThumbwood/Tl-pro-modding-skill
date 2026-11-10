using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics;
using Terraria.Graphics.Light;

namespace Terraria
{
	// Token: 0x0200046C RID: 1132
	[Token(Token = "0x200046C")]
	public class Lighting
	{
		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DC")]
		private static LightMode _mode
		{
			[Token(Token = "0x6001FD9")]
			[Address(RVA = "0x1204F3C", Offset = "0x1204F3C", VA = "0x1204F3C")]
			get
			{
				return LightMode.White;
			}
			[Token(Token = "0x6001FDA")]
			[Address(RVA = "0x1204FA4", Offset = "0x1204FA4", VA = "0x1204FA4")]
			set
			{
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DD")]
		private static LightingEngine NewEngine
		{
			[Token(Token = "0x6001FDB")]
			[Address(RVA = "0x1205010", Offset = "0x1205010", VA = "0x1205010")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001FDC RID: 8156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DE")]
		private static LegacyLighting LegacyEngine
		{
			[Token(Token = "0x6001FDC")]
			[Address(RVA = "0x1205078", Offset = "0x1205078", VA = "0x1205078")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FDE RID: 8158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DF")]
		private static ILightingEngine _activeEngine
		{
			[Token(Token = "0x6001FDD")]
			[Address(RVA = "0x12050E0", Offset = "0x12050E0", VA = "0x12050E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FDE")]
			[Address(RVA = "0x1205148", Offset = "0x1205148", VA = "0x1205148")]
			set
			{
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E0")]
		public static float GlobalBrightness
		{
			[Token(Token = "0x6001FDF")]
			[Address(RVA = "0x12051B8", Offset = "0x12051B8", VA = "0x12051B8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001FE0")]
			[Address(RVA = "0x120521C", Offset = "0x120521C", VA = "0x120521C")]
			set
			{
			}
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE1")]
		[Address(RVA = "0x1205290", Offset = "0x1205290", VA = "0x1205290")]
		public static void ResetLighting()
		{
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
		// (set) Token: 0x06001FE3 RID: 8163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E1")]
		public static LightMode Mode
		{
			[Token(Token = "0x6001FE2")]
			[Address(RVA = "0x120537C", Offset = "0x120537C", VA = "0x120537C")]
			get
			{
				return LightMode.White;
			}
			[Token(Token = "0x6001FE3")]
			[Address(RVA = "0x1205434", Offset = "0x1205434", VA = "0x1205434")]
			set
			{
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x0000F510 File Offset: 0x0000D710
		[Token(Token = "0x170003E2")]
		public static bool NotRetro
		{
			[Token(Token = "0x6001FE4")]
			[Address(RVA = "0x1205A50", Offset = "0x1205A50", VA = "0x1205A50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x0000F528 File Offset: 0x0000D728
		[Token(Token = "0x170003E3")]
		public static bool UsingNewLighting
		{
			[Token(Token = "0x6001FE5")]
			[Address(RVA = "0x1205B08", Offset = "0x1205B08", VA = "0x1205B08")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x0000F540 File Offset: 0x0000D740
		[Token(Token = "0x170003E4")]
		public static bool UpdateEveryFrame
		{
			[Token(Token = "0x6001FE6")]
			[Address(RVA = "0x1205C08", Offset = "0x1205C08", VA = "0x1205C08")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x1205C10", Offset = "0x1205C10", VA = "0x1205C10")]
		public static void AttachEngine(ILightingEngine engine)
		{
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x1205D2C", Offset = "0x1205D2C", VA = "0x1205D2C")]
		public static void DetachEngine(ILightingEngine engine)
		{
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE9")]
		[Address(RVA = "0x1205EB4", Offset = "0x1205EB4", VA = "0x1205EB4")]
		public static void Initialize(bool resized = false)
		{
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEA")]
		[Address(RVA = "0x12060E0", Offset = "0x12060E0", VA = "0x12060E0")]
		public static void LightTiles(int firstX, int lastX, int firstY, int lastY)
		{
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEB")]
		[Address(RVA = "0x1206408", Offset = "0x1206408", VA = "0x1206408")]
		private static void UpdateGlobalBrightness()
		{
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x0000F558 File Offset: 0x0000D758
		[Token(Token = "0x6001FEC")]
		[Address(RVA = "0x1206588", Offset = "0x1206588", VA = "0x1206588")]
		public static float Brightness(int x, int y)
		{
			return 0f;
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x0000F570 File Offset: 0x0000D770
		[Token(Token = "0x6001FED")]
		[Address(RVA = "0x1206768", Offset = "0x1206768", VA = "0x1206768")]
		public static Vector3 GetSubLight(Vector2 position)
		{
			return default(Vector3);
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEE")]
		[Address(RVA = "0x1206D60", Offset = "0x1206D60", VA = "0x1206D60")]
		public static void AddLight(Vector2 position, Vector3 rgb)
		{
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEF")]
		[Address(RVA = "0x1206FF8", Offset = "0x1206FF8", VA = "0x1206FF8")]
		public static void AddLight(Vector2 position, float r, float g, float b)
		{
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF0")]
		[Address(RVA = "0x12070CC", Offset = "0x12070CC", VA = "0x12070CC")]
		public static void AddLight(int i, int j, int torchID, float lightAmount)
		{
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF1")]
		[Address(RVA = "0x12072A8", Offset = "0x12072A8", VA = "0x12072A8")]
		public static void AddLight(Vector2 position, int torchID)
		{
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF2")]
		[Address(RVA = "0x12073E0", Offset = "0x12073E0", VA = "0x12073E0")]
		public static void AddLightForPlayer(int i, int j, float r, float g, float b, int playerId)
		{
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF3")]
		[Address(RVA = "0x1206E38", Offset = "0x1206E38", VA = "0x1206E38")]
		public static void AddLight(int i, int j, float r, float g, float b)
		{
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF4")]
		[Address(RVA = "0x1207580", Offset = "0x1207580", VA = "0x1207580")]
		public static void NextLightMode()
		{
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF5")]
		[Address(RVA = "0x1207808", Offset = "0x1207808", VA = "0x1207808")]
		public static void Clear()
		{
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x0000F588 File Offset: 0x0000D788
		[Token(Token = "0x6001FF6")]
		[Address(RVA = "0x120794C", Offset = "0x120794C", VA = "0x120794C")]
		public static Color GetColor(Point tileCoords)
		{
			return default(Color);
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		[Token(Token = "0x6001FF7")]
		[Address(RVA = "0x1207BE4", Offset = "0x1207BE4", VA = "0x1207BE4")]
		public static Color GetColor(Point tileCoords, Color originalColor)
		{
			return default(Color);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		[Token(Token = "0x6001FF8")]
		[Address(RVA = "0x1207E34", Offset = "0x1207E34", VA = "0x1207E34")]
		public static Color GetColor(int x, int y, Color oldColor)
		{
			return default(Color);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		[Token(Token = "0x6001FF9")]
		[Address(RVA = "0x1208084", Offset = "0x1208084", VA = "0x1208084")]
		public static Color GetColorClamped(int x, int y, Color oldColor)
		{
			return default(Color);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0000F5E8 File Offset: 0x0000D7E8
		[Token(Token = "0x6001FFA")]
		[Address(RVA = "0x120833C", Offset = "0x120833C", VA = "0x120833C")]
		public static Vector3 GetColorVector3(int x, int y)
		{
			return default(Vector3);
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFB")]
		[Address(RVA = "0x120855C", Offset = "0x120855C", VA = "0x120855C")]
		public static LightMap GetLightMap(out Rectangle lightMapRegion)
		{
			return null;
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x0000F600 File Offset: 0x0000D800
		[Token(Token = "0x6001FFC")]
		[Address(RVA = "0x12086A8", Offset = "0x12086A8", VA = "0x12086A8")]
		public static Rectangle GetScanRegion()
		{
			return default(Rectangle);
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x0000F618 File Offset: 0x0000D818
		[Token(Token = "0x170003E5")]
		private static bool lightingDisabled
		{
			[Token(Token = "0x6001FFD")]
			[Address(RVA = "0x12062E8", Offset = "0x12062E8", VA = "0x12062E8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x0000F630 File Offset: 0x0000D830
		[Token(Token = "0x6001FFE")]
		[Address(RVA = "0x1208808", Offset = "0x1208808", VA = "0x1208808")]
		public static Color GetColor(int x, int y)
		{
			return default(Color);
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FFF")]
		[Address(RVA = "0x1208AC4", Offset = "0x1208AC4", VA = "0x1208AC4")]
		public static void GetColor9Slice(int centerX, int centerY, ref Color[] slices)
		{
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002000")]
		[Address(RVA = "0x1208E48", Offset = "0x1208E48", VA = "0x1208E48")]
		public static void GetColor9Slice(int x, int y, ref Vector3[] slices)
		{
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002001")]
		[Address(RVA = "0x1209B24", Offset = "0x1209B24", VA = "0x1209B24")]
		public static void GetCornerColors(int centerX, int centerY, out VertexColors vertices, float scale = 1f)
		{
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002002")]
		[Address(RVA = "0x120A85C", Offset = "0x120A85C", VA = "0x120A85C")]
		public static void GetColor4Slice(int centerX, int centerY, ref Color[] slices)
		{
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002003")]
		[Address(RVA = "0x120B6B8", Offset = "0x120B6B8", VA = "0x120B6B8")]
		public static void GetColor4Slice(int x, int y, ref Vector3[] slices)
		{
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002004")]
		[Address(RVA = "0x120BF50", Offset = "0x120BF50", VA = "0x120BF50")]
		public Lighting()
		{
		}

		// Token: 0x04003284 RID: 12932
		[Token(Token = "0x4003284")]
		private const float DEFAULT_GLOBAL_BRIGHTNESS = 1.2f;

		// Token: 0x04003285 RID: 12933
		[Token(Token = "0x4003285")]
		private const float BLIND_GLOBAL_BRIGHTNESS = 1f;

		// Token: 0x04003286 RID: 12934
		[Token(Token = "0x4003286")]
		[FieldOffset(Offset = "0x0")]
		private static float <GlobalBrightness>k__BackingField;

		// Token: 0x04003287 RID: 12935
		[Token(Token = "0x4003287")]
		[FieldOffset(Offset = "0x4")]
		public static int OffScreenTiles;

		// Token: 0x04003288 RID: 12936
		[Token(Token = "0x4003288")]
		[FieldOffset(Offset = "0x8")]
		private static int ActiveEngineCount;

		// Token: 0x04003289 RID: 12937
		[Token(Token = "0x4003289")]
		[FieldOffset(Offset = "0xC")]
		private static ILightingEngine[] ActiveEngines;

		// Token: 0x0400328A RID: 12938
		[Token(Token = "0x400328A")]
		[FieldOffset(Offset = "0x10")]
		public static bool disableLightingForUI;
	}
}
