using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ReLogic.Content;
using ReLogic.Utilities;
using Terraria.DataStructures;
using Terraria.UI.Chat;
using Terraria.Utilities;
using Terraria.Utilities.Terraria.Utilities;

namespace Terraria
{
	// Token: 0x02000509 RID: 1289
	[Token(Token = "0x2000509")]
	public static class Utils
	{
		// Token: 0x060033DE RID: 13278 RVA: 0x00019698 File Offset: 0x00017898
		[Token(Token = "0x60033DE")]
		[Address(RVA = "0x1A244A8", Offset = "0x1A244A8", VA = "0x1A244A8")]
		public static Color ColorLerp_BlackToWhite(float percent)
		{
			return default(Color);
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x000196B0 File Offset: 0x000178B0
		[Token(Token = "0x60033DF")]
		[Address(RVA = "0x1A24520", Offset = "0x1A24520", VA = "0x1A24520")]
		public static double Lerp(double value1, double value2, double amount)
		{
			return 0.0;
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x000196C8 File Offset: 0x000178C8
		[Token(Token = "0x60033E0")]
		[Address(RVA = "0x1A2453C", Offset = "0x1A2453C", VA = "0x1A2453C")]
		public static Vector2 Round(Vector2 input)
		{
			return default(Vector2);
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x000196E0 File Offset: 0x000178E0
		[Token(Token = "0x60033E1")]
		[Address(RVA = "0x1A246F8", Offset = "0x1A246F8", VA = "0x1A246F8")]
		public static bool IsPowerOfTwo(int x)
		{
			return default(bool);
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x000196F8 File Offset: 0x000178F8
		[Token(Token = "0x60033E2")]
		[Address(RVA = "0x1A24718", Offset = "0x1A24718", VA = "0x1A24718")]
		public static float SmoothStep(float min, float max, float x)
		{
			return 0f;
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x00019710 File Offset: 0x00017910
		[Token(Token = "0x60033E3")]
		[Address(RVA = "0x1A24744", Offset = "0x1A24744", VA = "0x1A24744")]
		public static double SmoothStep(double min, double max, double x)
		{
			return 0.0;
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x00019728 File Offset: 0x00017928
		[Token(Token = "0x60033E4")]
		[Address(RVA = "0x1A24814", Offset = "0x1A24814", VA = "0x1A24814")]
		public static float UnclampedSmoothStep(float min, float max, float x)
		{
			return 0f;
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x00019740 File Offset: 0x00017940
		[Token(Token = "0x60033E5")]
		[Address(RVA = "0x1A24834", Offset = "0x1A24834", VA = "0x1A24834")]
		public static double UnclampedSmoothStep(double min, double max, double x)
		{
			return 0.0;
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E6")]
		[Address(RVA = "0x1A24854", Offset = "0x1A24854", VA = "0x1A24854")]
		public static void CycleControlControl_ClickHold(ref ButtonControlMode mode)
		{
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E7")]
		[Address(RVA = "0x1A24868", Offset = "0x1A24868", VA = "0x1A24868")]
		public static void CycleControlControl_OffOnClickHold(ref ButtonControlMode mode)
		{
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E8")]
		[Address(RVA = "0x1A24880", Offset = "0x1A24880", VA = "0x1A24880")]
		public static Dictionary<string, string> ParseArguements(string[] args)
		{
			return null;
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E9")]
		public static void Swap<T>(ref T t1, ref T t2)
		{
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EA")]
		public static T Clamp<T>(T value, T min, T max) where T : IComparable<T>
		{
			return null;
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x00019758 File Offset: 0x00017958
		[Token(Token = "0x60033EB")]
		[Address(RVA = "0x1A24AE4", Offset = "0x1A24AE4", VA = "0x1A24AE4")]
		public static Rectangle Clamp(Rectangle r, Rectangle bounds)
		{
			return default(Rectangle);
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x00019770 File Offset: 0x00017970
		[Token(Token = "0x60033EC")]
		[Address(RVA = "0x1A24C38", Offset = "0x1A24C38", VA = "0x1A24C38")]
		public static float Turn01ToCyclic010(float value)
		{
			return 0f;
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x00019788 File Offset: 0x00017988
		[Token(Token = "0x60033ED")]
		[Address(RVA = "0x1A24CD4", Offset = "0x1A24CD4", VA = "0x1A24CD4")]
		public static float PingPongFrom01To010(float value)
		{
			return 0f;
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033EE")]
		public static void Shift<T>(T[] array, int n)
		{
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x000197A0 File Offset: 0x000179A0
		[Token(Token = "0x60033EF")]
		[Address(RVA = "0x1A24D1C", Offset = "0x1A24D1C", VA = "0x1A24D1C")]
		public static float MultiLerp(float percent, float[] floats)
		{
			return 0f;
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x000197B8 File Offset: 0x000179B8
		[Token(Token = "0x60033F0")]
		[Address(RVA = "0x1A24DC4", Offset = "0x1A24DC4", VA = "0x1A24DC4")]
		public static Color MultiLerp(float percent, Color[] colors)
		{
			return default(Color);
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x000197D0 File Offset: 0x000179D0
		[Token(Token = "0x60033F1")]
		[Address(RVA = "0x1A24EC8", Offset = "0x1A24EC8", VA = "0x1A24EC8")]
		public static float WrappedLerp(float value1, float value2, float percent)
		{
			return 0f;
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x000197E8 File Offset: 0x000179E8
		[Token(Token = "0x60033F2")]
		[Address(RVA = "0x1A24EF4", Offset = "0x1A24EF4", VA = "0x1A24EF4")]
		public static float GetLerpValue(float from, float to, float t, bool clamped = false)
		{
			return 0f;
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x00019800 File Offset: 0x00017A00
		[Token(Token = "0x60033F3")]
		[Address(RVA = "0x1A24F78", Offset = "0x1A24F78", VA = "0x1A24F78")]
		public static float Remap(float fromValue, float fromMin, float fromMax, float toMin, float toMax, bool clamped = true)
		{
			return 0f;
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x00019818 File Offset: 0x00017A18
		[Token(Token = "0x60033F4")]
		[Address(RVA = "0x1A25078", Offset = "0x1A25078", VA = "0x1A25078")]
		public static double Remap(double fromValue, double fromMin, double fromMax, double toMin, double toMax, bool clamped = true)
		{
			return 0.0;
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x00019830 File Offset: 0x00017A30
		[Token(Token = "0x60033F5")]
		[Address(RVA = "0x1A251E8", Offset = "0x1A251E8", VA = "0x1A251E8")]
		public static double EaseOutBounce(double x)
		{
			return 0.0;
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x00019848 File Offset: 0x00017A48
		[Token(Token = "0x60033F6")]
		[Address(RVA = "0x1A25300", Offset = "0x1A25300", VA = "0x1A25300")]
		private static double BounceEaseOut(double t, int bounces, double elasticity)
		{
			return 0.0;
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x00019860 File Offset: 0x00017A60
		[Token(Token = "0x60033F7")]
		[Address(RVA = "0x1A253DC", Offset = "0x1A253DC", VA = "0x1A253DC")]
		public static double EaseInCirc(double x)
		{
			return 0.0;
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x00019878 File Offset: 0x00017A78
		[Token(Token = "0x60033F8")]
		[Address(RVA = "0x1A25460", Offset = "0x1A25460", VA = "0x1A25460")]
		public static double EaseOutCirc(double x)
		{
			return 0.0;
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F9")]
		[Address(RVA = "0x1A25508", Offset = "0x1A25508", VA = "0x1A25508")]
		public static void GetPortraitMovement(double t, out double offsetX, out double scaleX)
		{
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x00019890 File Offset: 0x00017A90
		[Token(Token = "0x60033FA")]
		[Address(RVA = "0x1A258F8", Offset = "0x1A258F8", VA = "0x1A258F8")]
		public static Color ShiftHue(Color color, float hueShift, float luminanceShift, float saturationBoost)
		{
			return default(Color);
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x000198A8 File Offset: 0x00017AA8
		[Token(Token = "0x60033FB")]
		[Address(RVA = "0x1A25A5C", Offset = "0x1A25A5C", VA = "0x1A25A5C")]
		public static Color ShiftBlueToCyanTheme(Color color)
		{
			return default(Color);
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FC")]
		[Address(RVA = "0x1A25AE0", Offset = "0x1A25AE0", VA = "0x1A25AE0")]
		public static void ClampWithinWorld(ref int minX, ref int minY, ref int maxX, ref int maxY, bool lastValuesInclusiveToIteration = false, int fluffX = 0, int fluffY = 0)
		{
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FD")]
		[Address(RVA = "0x1A25C58", Offset = "0x1A25C58", VA = "0x1A25C58")]
		public static void DrawNotificationIcon(SpriteBatch spritebatch, Rectangle hitbox, float rotationMultiplier = 1f, bool worldSpace = false)
		{
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FE")]
		[Address(RVA = "0x1A25DEC", Offset = "0x1A25DEC", VA = "0x1A25DEC")]
		public static void DrawNotificationIcon(SpriteBatch spritebatch, Vector2 position, float rotationMultiplier = 1f, bool worldSpace = false, float scaleMultiplier = 1f)
		{
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x000198C0 File Offset: 0x00017AC0
		[Token(Token = "0x60033FF")]
		[Address(RVA = "0x1A263EC", Offset = "0x1A263EC", VA = "0x1A263EC")]
		public static Vector2 ConstrainedToPointInRectangle(Rectangle bounds, Vector2 centerTestPosition)
		{
			return default(Vector2);
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x000198D8 File Offset: 0x00017AD8
		[Token(Token = "0x6003400")]
		[Address(RVA = "0x1A26828", Offset = "0x1A26828", VA = "0x1A26828")]
		private static bool CheckForGoodTeleportationSpot_CheckNoInvalidTiles(int tpx, int tpy, Utils.RandomTeleportationAttemptSettings settings)
		{
			return default(bool);
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x000198F0 File Offset: 0x00017AF0
		[Token(Token = "0x6003401")]
		[Address(RVA = "0x1A26B48", Offset = "0x1A26B48", VA = "0x1A26B48")]
		public static Vector2 CheckForGoodTeleportationSpot(ref bool canSpawn, int teleportStartX, int teleportRangeX, int teleportStartY, int teleportRangeY, Utils.RandomTeleportationAttemptSettings settings)
		{
			return default(Vector2);
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x00019908 File Offset: 0x00017B08
		[Token(Token = "0x6003402")]
		[Address(RVA = "0x1A28610", Offset = "0x1A28610", VA = "0x1A28610")]
		public static Utils.ChaseResults GetChaseResults(Vector2 chaserPosition, float chaserSpeed, Vector2 runnerPosition, Vector2 runnerVelocity)
		{
			return default(Utils.ChaseResults);
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x00019920 File Offset: 0x00017B20
		[Token(Token = "0x6003403")]
		[Address(RVA = "0x1A28C40", Offset = "0x1A28C40", VA = "0x1A28C40")]
		public static float GetJumpForce(float jumpHeight, float atGravity)
		{
			return 0f;
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x00019938 File Offset: 0x00017B38
		[Token(Token = "0x6003404")]
		[Address(RVA = "0x1A28CC4", Offset = "0x1A28CC4", VA = "0x1A28CC4")]
		public static float GetJumpTimeToApex(float jumpHeight, float atGravity)
		{
			return 0f;
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x00019950 File Offset: 0x00017B50
		[Token(Token = "0x6003405")]
		[Address(RVA = "0x1A28D44", Offset = "0x1A28D44", VA = "0x1A28D44")]
		public static Vector2 FactorAcceleration(Vector2 currentVelocity, float timeToInterception, Vector2 descendOfProjectile, int framesOfLenience)
		{
			return default(Vector2);
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x00019968 File Offset: 0x00017B68
		[Token(Token = "0x6003406")]
		[Address(RVA = "0x1A28B34", Offset = "0x1A28B34", VA = "0x1A28B34")]
		public static bool SolveQuadratic(float a, float b, float c, out float result1, out float result2)
		{
			return default(bool);
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x00019980 File Offset: 0x00017B80
		[Token(Token = "0x6003407")]
		[Address(RVA = "0x1A25168", Offset = "0x1A25168", VA = "0x1A25168")]
		public static double GetLerpValue(double from, double to, double t, bool clamped = false)
		{
			return 0.0;
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x00019998 File Offset: 0x00017B98
		[Token(Token = "0x6003408")]
		[Address(RVA = "0x1A28E98", Offset = "0x1A28E98", VA = "0x1A28E98")]
		public static float GetDayTimeAs24FloatStartingFromMidnight()
		{
			return 0f;
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x000199B0 File Offset: 0x00017BB0
		[Token(Token = "0x6003409")]
		[Address(RVA = "0x1A28F88", Offset = "0x1A28F88", VA = "0x1A28F88")]
		public static Vector2 GetDayTimeAsDirectionIn24HClock()
		{
			return default(Vector2);
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x000199C8 File Offset: 0x00017BC8
		[Token(Token = "0x600340A")]
		[Address(RVA = "0x1A290A8", Offset = "0x1A290A8", VA = "0x1A290A8")]
		public static Vector2 GetDayTimeAsDirectionIn24HClock(float timeFrom0To24)
		{
			return default(Vector2);
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340B")]
		[Address(RVA = "0x1A292A0", Offset = "0x1A292A0", VA = "0x1A292A0")]
		public static string[] ConvertMonoArgsToDotNet(string[] brokenArgs)
		{
			return null;
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340C")]
		public static T Max<T>(T[] args) where T : IComparable
		{
			return null;
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x000199E0 File Offset: 0x00017BE0
		[Token(Token = "0x600340D")]
		[Address(RVA = "0x1A2952C", Offset = "0x1A2952C", VA = "0x1A2952C")]
		public static float LineRectangleDistance(Rectangle rect, Vector2 lineStart, Vector2 lineEnd)
		{
			return 0f;
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340E")]
		[Address(RVA = "0x1A29D68", Offset = "0x1A29D68", VA = "0x1A29D68")]
		public static List<List<TextSnippet>> WordwrapStringSmart(string text, Color c, SpriteFont font, int maxWidth, int maxLines)
		{
			return null;
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340F")]
		[Address(RVA = "0x1A2A9B0", Offset = "0x1A2A9B0", VA = "0x1A2A9B0")]
		public static string[] WordwrapString(string text, SpriteFont font, int maxWidth, int maxLines, out int lineAmount)
		{
			return null;
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x000199F8 File Offset: 0x00017BF8
		[Token(Token = "0x6003410")]
		[Address(RVA = "0x1A2B1F0", Offset = "0x1A2B1F0", VA = "0x1A2B1F0")]
		public static Rectangle CenteredRectangle(Vector2 center, Vector2 size)
		{
			return default(Rectangle);
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x00019A10 File Offset: 0x00017C10
		[Token(Token = "0x6003411")]
		[Address(RVA = "0x1A2B28C", Offset = "0x1A2B28C", VA = "0x1A2B28C")]
		public static Rectangle CenteredRectangle(Point center, Point size)
		{
			return default(Rectangle);
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x00019A28 File Offset: 0x00017C28
		[Token(Token = "0x6003412")]
		[Address(RVA = "0x1A2B2C4", Offset = "0x1A2B2C4", VA = "0x1A2B2C4")]
		public static Rectangle Including(Rectangle rect, Point point)
		{
			return default(Rectangle);
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x00019A40 File Offset: 0x00017C40
		[Token(Token = "0x6003413")]
		[Address(RVA = "0x1A2B400", Offset = "0x1A2B400", VA = "0x1A2B400")]
		public static Vector2 Vector2FromElipse(Vector2 angleVector, Vector2 elipseSizes)
		{
			return default(Vector2);
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x00019A58 File Offset: 0x00017C58
		[Token(Token = "0x6003414")]
		[Address(RVA = "0x1A2B6F0", Offset = "0x1A2B6F0", VA = "0x1A2B6F0")]
		public static bool FloatIntersect(float r1StartX, float r1StartY, float r1Width, float r1Height, float r2StartX, float r2StartY, float r2Width, float r2Height)
		{
			return default(bool);
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x00019A70 File Offset: 0x00017C70
		[Token(Token = "0x6003415")]
		[Address(RVA = "0x1A2B75C", Offset = "0x1A2B75C", VA = "0x1A2B75C")]
		public static bool DoubleIntersect(double r1StartX, double r1StartY, double r1Width, double r1Height, double r2StartX, double r2StartY, double r2Width, double r2Height)
		{
			return default(bool);
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x00019A88 File Offset: 0x00017C88
		[Token(Token = "0x6003416")]
		[Address(RVA = "0x1A2B7CC", Offset = "0x1A2B7CC", VA = "0x1A2B7CC")]
		public static bool LineSegmentsIntersect(Vector2D start1, Vector2D end1, Vector2D start2, Vector2D end2)
		{
			return default(bool);
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x00019AA0 File Offset: 0x00017CA0
		[Token(Token = "0x6003417")]
		[Address(RVA = "0x1A2BA40", Offset = "0x1A2BA40", VA = "0x1A2BA40")]
		public static long CoinsCount(out bool overFlowing, ChestItem[] inv, int maxItem, int[] ignoreSlots)
		{
			return 0L;
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x00019AB8 File Offset: 0x00017CB8
		[Token(Token = "0x6003418")]
		[Address(RVA = "0x1A2BBE0", Offset = "0x1A2BBE0", VA = "0x1A2BBE0")]
		public static long CoinsCount(out bool overFlowing, Item[] inv, int[] ignoreSlots)
		{
			return 0L;
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003419")]
		[Address(RVA = "0x1A2BDC0", Offset = "0x1A2BDC0", VA = "0x1A2BDC0")]
		public static int[] CoinsSplit(long count)
		{
			return null;
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x00019AD0 File Offset: 0x00017CD0
		[Token(Token = "0x600341A")]
		[Address(RVA = "0x1A2BF50", Offset = "0x1A2BF50", VA = "0x1A2BF50")]
		public static long CoinsCombineStacks(out bool overFlowing, long[] coinCounts)
		{
			return 0L;
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600341B")]
		[Address(RVA = "0x1A2BFE0", Offset = "0x1A2BFE0", VA = "0x1A2BFE0")]
		public static void PoofOfSmoke(Vector2 position)
		{
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x00019AE8 File Offset: 0x00017CE8
		[Token(Token = "0x600341C")]
		[Address(RVA = "0x1A2C7CC", Offset = "0x1A2C7CC", VA = "0x1A2C7CC")]
		public static Vector2 ToScreenPosition(Vector2 worldPosition)
		{
			return default(Vector2);
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x00019B00 File Offset: 0x00017D00
		[Token(Token = "0x600341D")]
		[Address(RVA = "0x1A2C9E8", Offset = "0x1A2C9E8", VA = "0x1A2C9E8")]
		public static Vector2 ScreenToWorldPosition(Vector2 screenPosition)
		{
			return default(Vector2);
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341E")]
		[Address(RVA = "0x1A2CD0C", Offset = "0x1A2CD0C", VA = "0x1A2CD0C")]
		public static string PrettifyPercentDisplay(float percent, string originalFormat)
		{
			return null;
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600341F")]
		[Address(RVA = "0x1A2CEF0", Offset = "0x1A2CEF0", VA = "0x1A2CEF0")]
		public static void TrimTextIfNeeded(ref string text, SpriteFont font, float scale, float maxWidth)
		{
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003420")]
		[Address(RVA = "0x1A2D1F0", Offset = "0x1A2D1F0", VA = "0x1A2D1F0")]
		public static string FormatWith(string original, object obj)
		{
			return null;
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x00019B18 File Offset: 0x00017D18
		[Token(Token = "0x6003421")]
		[Address(RVA = "0x1A2D3A0", Offset = "0x1A2D3A0", VA = "0x1A2D3A0")]
		public static bool TryCreatingDirectory(string folderPath)
		{
			return default(bool);
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003422")]
		[Address(RVA = "0x1A2D454", Offset = "0x1A2D454", VA = "0x1A2D454")]
		public static void OpenFolder(string folderPath)
		{
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x00019B30 File Offset: 0x00017D30
		[Token(Token = "0x6003423")]
		[Address(RVA = "0x1A2D4F8", Offset = "0x1A2D4F8", VA = "0x1A2D4F8")]
		public static TimeSpan SWTicksToTimeSpan(long swTicks)
		{
			return default(TimeSpan);
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x00019B48 File Offset: 0x00017D48
		[Token(Token = "0x6003424")]
		[Address(RVA = "0x1A2D5CC", Offset = "0x1A2D5CC", VA = "0x1A2D5CC")]
		public static long TimeSpanToSWTicks(TimeSpan timeSpan)
		{
			return 0L;
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003425")]
		[Address(RVA = "0x1A2D684", Offset = "0x1A2D684", VA = "0x1A2D684")]
		public static byte[] ToByteArray(string str)
		{
			return null;
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x00019B60 File Offset: 0x00017D60
		[Token(Token = "0x6003426")]
		[Address(RVA = "0x1A2C6E8", Offset = "0x1A2C6E8", VA = "0x1A2C6E8")]
		public static float NextFloat(UnifiedRandom r)
		{
			return 0f;
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x00019B78 File Offset: 0x00017D78
		[Token(Token = "0x6003427")]
		[Address(RVA = "0x1A2D740", Offset = "0x1A2D740", VA = "0x1A2D740")]
		public static float NextFloatDirection(UnifiedRandom r)
		{
			return 0f;
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x00019B90 File Offset: 0x00017D90
		[Token(Token = "0x6003428")]
		[Address(RVA = "0x1A2D77C", Offset = "0x1A2D77C", VA = "0x1A2D77C")]
		public static float NextFloat(UnifiedRandom random, FloatRange range)
		{
			return 0f;
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003429")]
		public static T NextFromList<T>(UnifiedRandom random, T[] objs)
		{
			return null;
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x00019BA8 File Offset: 0x00017DA8
		[Token(Token = "0x600342A")]
		[Address(RVA = "0x1A2D820", Offset = "0x1A2D820", VA = "0x1A2D820")]
		public static bool JustBecameTrue(bool state, ref bool releasedStateHolder)
		{
			return default(bool);
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600342B")]
		public static T NextFromCollection<T>(UnifiedRandom random, List<T> objs)
		{
			return null;
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x00019BC0 File Offset: 0x00017DC0
		[Token(Token = "0x600342C")]
		[Address(RVA = "0x1A2D84C", Offset = "0x1A2D84C", VA = "0x1A2D84C")]
		public static int Next(UnifiedRandom random, IntRange range)
		{
			return 0;
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x00019BD8 File Offset: 0x00017DD8
		[Token(Token = "0x600342D")]
		[Address(RVA = "0x1A2D880", Offset = "0x1A2D880", VA = "0x1A2D880")]
		public static Point NextFromRectangle(UnifiedRandom r, Rectangle rect)
		{
			return default(Point);
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x00019BF0 File Offset: 0x00017DF0
		[Token(Token = "0x600342E")]
		[Address(RVA = "0x1A2D98C", Offset = "0x1A2D98C", VA = "0x1A2D98C")]
		public static Vector2 NextVector2Square(UnifiedRandom r, float min, float max)
		{
			return default(Vector2);
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x00019C08 File Offset: 0x00017E08
		[Token(Token = "0x600342F")]
		[Address(RVA = "0x1A2DA28", Offset = "0x1A2DA28", VA = "0x1A2DA28")]
		public static Vector2 NextVector2FromRectangle(UnifiedRandom r, Rectangle rect)
		{
			return default(Vector2);
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x00019C20 File Offset: 0x00017E20
		[Token(Token = "0x6003430")]
		[Address(RVA = "0x1A2DB34", Offset = "0x1A2DB34", VA = "0x1A2DB34")]
		public static Vector2 NextVector2Unit(UnifiedRandom r, float startRotation = 0f, float rotationRange = 6.2831855f)
		{
			return default(Vector2);
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x00019C38 File Offset: 0x00017E38
		[Token(Token = "0x6003431")]
		[Address(RVA = "0x1A2DC80", Offset = "0x1A2DC80", VA = "0x1A2DC80")]
		public static Vector2 NextVector2Circular(UnifiedRandom r, float circleHalfWidth, float circleHalfHeight)
		{
			return default(Vector2);
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x00019C50 File Offset: 0x00017E50
		[Token(Token = "0x6003432")]
		[Address(RVA = "0x1A2DDCC", Offset = "0x1A2DDCC", VA = "0x1A2DDCC")]
		public static Vector2 NextVector2CircularEdge(UnifiedRandom r, float circleHalfWidth, float circleHalfHeight)
		{
			return default(Vector2);
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x00019C68 File Offset: 0x00017E68
		[Token(Token = "0x6003433")]
		[Address(RVA = "0x1A2DED4", Offset = "0x1A2DED4", VA = "0x1A2DED4")]
		public static Vector2D NextVector2DSquare(UnifiedRandom r, double min, double max)
		{
			return default(Vector2D);
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x00019C80 File Offset: 0x00017E80
		[Token(Token = "0x6003434")]
		[Address(RVA = "0x1A2DF70", Offset = "0x1A2DF70", VA = "0x1A2DF70")]
		public static Vector2D NextVector2DFromRectangle(UnifiedRandom r, Rectangle rect)
		{
			return default(Vector2D);
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x00019C98 File Offset: 0x00017E98
		[Token(Token = "0x6003435")]
		[Address(RVA = "0x1A2E02C", Offset = "0x1A2E02C", VA = "0x1A2E02C")]
		public static Vector2D NextVector2DUnit(UnifiedRandom r, double startRotation = 0.0, double rotationRange = 6.2831854820251465)
		{
			return default(Vector2D);
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x00019CB0 File Offset: 0x00017EB0
		[Token(Token = "0x6003436")]
		[Address(RVA = "0x1A2E210", Offset = "0x1A2E210", VA = "0x1A2E210")]
		public static Vector2D NextVector2DCircular(UnifiedRandom r, double circleHalfWidth, double circleHalfHeight)
		{
			return default(Vector2D);
		}

		// Token: 0x06003437 RID: 13367 RVA: 0x00019CC8 File Offset: 0x00017EC8
		[Token(Token = "0x6003437")]
		[Address(RVA = "0x1A2E394", Offset = "0x1A2E394", VA = "0x1A2E394")]
		public static Vector2D NextVector2DCircularEdge(UnifiedRandom r, double circleHalfWidth, double circleHalfHeight)
		{
			return default(Vector2D);
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x00019CE0 File Offset: 0x00017EE0
		[Token(Token = "0x6003438")]
		[Address(RVA = "0x1A2E4D4", Offset = "0x1A2E4D4", VA = "0x1A2E4D4")]
		public static int Width(Asset<Texture2D> asset)
		{
			return 0;
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x00019CF8 File Offset: 0x00017EF8
		[Token(Token = "0x6003439")]
		[Address(RVA = "0x1A2E564", Offset = "0x1A2E564", VA = "0x1A2E564")]
		public static int Height(Asset<Texture2D> asset)
		{
			return 0;
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x00019D10 File Offset: 0x00017F10
		[Token(Token = "0x600343A")]
		[Address(RVA = "0x1A2E5F4", Offset = "0x1A2E5F4", VA = "0x1A2E5F4")]
		public static Rectangle Frame(Asset<Texture2D> tex, int horizontalFrames = 1, int verticalFrames = 1, int frameX = 0, int frameY = 0, int sizeOffsetX = 0, int sizeOffsetY = 0)
		{
			return default(Rectangle);
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x00019D28 File Offset: 0x00017F28
		[Token(Token = "0x600343B")]
		[Address(RVA = "0x1A2E840", Offset = "0x1A2E840", VA = "0x1A2E840")]
		public static Rectangle OffsetSize(Rectangle rect, int xSize, int ySize)
		{
			return default(Rectangle);
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x00019D40 File Offset: 0x00017F40
		[Token(Token = "0x600343C")]
		[Address(RVA = "0x1A2E860", Offset = "0x1A2E860", VA = "0x1A2E860")]
		public static Vector2 Size(Asset<Texture2D> tex)
		{
			return default(Vector2);
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x00019D58 File Offset: 0x00017F58
		[Token(Token = "0x600343D")]
		[Address(RVA = "0x1A2E7A8", Offset = "0x1A2E7A8", VA = "0x1A2E7A8")]
		public static Rectangle Frame(Texture2D tex, int horizontalFrames = 1, int verticalFrames = 1, int frameX = 0, int frameY = 0, int sizeOffsetX = 0, int sizeOffsetY = 0)
		{
			return default(Rectangle);
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x00019D70 File Offset: 0x00017F70
		[Token(Token = "0x600343E")]
		[Address(RVA = "0x1A2EA58", Offset = "0x1A2EA58", VA = "0x1A2EA58")]
		public static Vector2 OriginFlip(Rectangle rect, Vector2 origin, SpriteEffects effects)
		{
			return default(Vector2);
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x00019D88 File Offset: 0x00017F88
		[Token(Token = "0x600343F")]
		[Address(RVA = "0x1A2E9F8", Offset = "0x1A2E9F8", VA = "0x1A2E9F8")]
		public static Vector2 Size(Texture2D tex)
		{
			return default(Vector2);
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003440")]
		[Address(RVA = "0x1A2EAA8", Offset = "0x1A2EAA8", VA = "0x1A2EAA8")]
		public static void WriteRGB(BinaryWriter bb, Color c)
		{
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003441")]
		[Address(RVA = "0x1A2EB44", Offset = "0x1A2EB44", VA = "0x1A2EB44")]
		public static void WriteVector2(BinaryWriter bb, Vector2 v)
		{
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003442")]
		[Address(RVA = "0x1A2EBA0", Offset = "0x1A2EBA0", VA = "0x1A2EBA0")]
		public static void WritePackedVector2(BinaryWriter bb, Vector2 v)
		{
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x00019DA0 File Offset: 0x00017FA0
		[Token(Token = "0x6003443")]
		[Address(RVA = "0x1A2EBF0", Offset = "0x1A2EBF0", VA = "0x1A2EBF0")]
		public static Color ReadRGB(BinaryReader bb)
		{
			return default(Color);
		}

		// Token: 0x06003444 RID: 13380 RVA: 0x00019DB8 File Offset: 0x00017FB8
		[Token(Token = "0x6003444")]
		[Address(RVA = "0x1A2EC90", Offset = "0x1A2EC90", VA = "0x1A2EC90")]
		public static Vector2 ReadVector2(BinaryReader bb)
		{
			return default(Vector2);
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x00019DD0 File Offset: 0x00017FD0
		[Token(Token = "0x6003445")]
		[Address(RVA = "0x1A2ED04", Offset = "0x1A2ED04", VA = "0x1A2ED04")]
		public static Vector2 ReadPackedVector2(BinaryReader bb)
		{
			return default(Vector2);
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003446")]
		[Address(RVA = "0x1A2ED60", Offset = "0x1A2ED60", VA = "0x1A2ED60")]
		public static void Write7BitEncodedInt(BinaryWriter writer, int value)
		{
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x00019DE8 File Offset: 0x00017FE8
		[Token(Token = "0x6003447")]
		[Address(RVA = "0x1A2EDC8", Offset = "0x1A2EDC8", VA = "0x1A2EDC8")]
		public static int Read7BitEncodedInt(BinaryReader reader)
		{
			return 0;
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x00019E00 File Offset: 0x00018000
		[Token(Token = "0x6003448")]
		[Address(RVA = "0x1A2EE90", Offset = "0x1A2EE90", VA = "0x1A2EE90")]
		public static Vector2 Left(Rectangle r)
		{
			return default(Vector2);
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x00019E18 File Offset: 0x00018018
		[Token(Token = "0x6003449")]
		[Address(RVA = "0x1A2EED0", Offset = "0x1A2EED0", VA = "0x1A2EED0")]
		public static Vector2 Right(Rectangle r)
		{
			return default(Vector2);
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x00019E30 File Offset: 0x00018030
		[Token(Token = "0x600344A")]
		[Address(RVA = "0x1A2EF14", Offset = "0x1A2EF14", VA = "0x1A2EF14")]
		public static Vector2 Top(Rectangle r)
		{
			return default(Vector2);
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x00019E48 File Offset: 0x00018048
		[Token(Token = "0x600344B")]
		[Address(RVA = "0x1A2EF50", Offset = "0x1A2EF50", VA = "0x1A2EF50")]
		public static Vector2 Bottom(Rectangle r)
		{
			return default(Vector2);
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x00019E60 File Offset: 0x00018060
		[Token(Token = "0x600344C")]
		[Address(RVA = "0x1A29A30", Offset = "0x1A29A30", VA = "0x1A29A30")]
		public static Vector2 TopLeft(Rectangle r)
		{
			return default(Vector2);
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x00019E78 File Offset: 0x00018078
		[Token(Token = "0x600344D")]
		[Address(RVA = "0x1A29A64", Offset = "0x1A29A64", VA = "0x1A29A64")]
		public static Vector2 TopRight(Rectangle r)
		{
			return default(Vector2);
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x00019E90 File Offset: 0x00018090
		[Token(Token = "0x600344E")]
		[Address(RVA = "0x1A29A9C", Offset = "0x1A29A9C", VA = "0x1A29A9C")]
		public static Vector2 BottomLeft(Rectangle r)
		{
			return default(Vector2);
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x00019EA8 File Offset: 0x000180A8
		[Token(Token = "0x600344F")]
		[Address(RVA = "0x1A25DAC", Offset = "0x1A25DAC", VA = "0x1A25DAC")]
		public static Vector2 BottomRight(Rectangle r)
		{
			return default(Vector2);
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x00019EC0 File Offset: 0x000180C0
		[Token(Token = "0x6003450")]
		[Address(RVA = "0x1A2EF94", Offset = "0x1A2EF94", VA = "0x1A2EF94")]
		public static Vector2D TopLeftDouble(Rectangle r)
		{
			return default(Vector2D);
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x00019ED8 File Offset: 0x000180D8
		[Token(Token = "0x6003451")]
		[Address(RVA = "0x1A2EFD4", Offset = "0x1A2EFD4", VA = "0x1A2EFD4")]
		public static Vector2D TopRightDouble(Rectangle r)
		{
			return default(Vector2D);
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x00019EF0 File Offset: 0x000180F0
		[Token(Token = "0x6003452")]
		[Address(RVA = "0x1A2F018", Offset = "0x1A2F018", VA = "0x1A2F018")]
		public static Vector2D BottomLeftDouble(Rectangle r)
		{
			return default(Vector2D);
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x00019F08 File Offset: 0x00018108
		[Token(Token = "0x6003453")]
		[Address(RVA = "0x1A2F060", Offset = "0x1A2F060", VA = "0x1A2F060")]
		public static Vector2D BottomRightDouble(Rectangle r)
		{
			return default(Vector2D);
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x00019F20 File Offset: 0x00018120
		[Token(Token = "0x6003454")]
		[Address(RVA = "0x1A2F0AC", Offset = "0x1A2F0AC", VA = "0x1A2F0AC")]
		public static Vector2 Center(Rectangle r)
		{
			return default(Vector2);
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x00019F38 File Offset: 0x00018138
		[Token(Token = "0x6003455")]
		[Address(RVA = "0x1A2F0F4", Offset = "0x1A2F0F4", VA = "0x1A2F0F4")]
		public static Vector2 Size(Rectangle r)
		{
			return default(Vector2);
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x00019F50 File Offset: 0x00018150
		[Token(Token = "0x6003456")]
		[Address(RVA = "0x1A2F128", Offset = "0x1A2F128", VA = "0x1A2F128")]
		public static float Distance(Rectangle r, Vector2 point)
		{
			return 0f;
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00019F68 File Offset: 0x00018168
		[Token(Token = "0x6003457")]
		[Address(RVA = "0x1A2F544", Offset = "0x1A2F544", VA = "0x1A2F544")]
		public static double Distance(Rectangle r, Vector2D point)
		{
			return 0.0;
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x00019F80 File Offset: 0x00018180
		[Token(Token = "0x6003458")]
		[Address(RVA = "0x1A2F9C0", Offset = "0x1A2F9C0", VA = "0x1A2F9C0")]
		public static Vector2 ClosestPointInRect(Rectangle r, Vector2 point)
		{
			return default(Vector2);
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x00019F98 File Offset: 0x00018198
		[Token(Token = "0x6003459")]
		[Address(RVA = "0x1A2FB84", Offset = "0x1A2FB84", VA = "0x1A2FB84")]
		public static Rectangle Modified(Rectangle r, int x, int y, int w, int h)
		{
			return default(Rectangle);
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x00019FB0 File Offset: 0x000181B0
		[Token(Token = "0x600345A")]
		[Address(RVA = "0x1A2FBCC", Offset = "0x1A2FBCC", VA = "0x1A2FBCC")]
		public static bool IntersectsConeFastInaccurate(Rectangle targetRect, Vector2 coneCenter, float coneLength, float coneRotation, float maximumAngle)
		{
			return default(bool);
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x00019FC8 File Offset: 0x000181C8
		[Token(Token = "0x600345B")]
		[Address(RVA = "0x1A2FF3C", Offset = "0x1A2FF3C", VA = "0x1A2FF3C")]
		public static bool IntersectsConeSlowMoreAccurate(Rectangle targetRect, Vector2 coneCenter, float coneLength, float coneRotation, float maximumAngle)
		{
			return default(bool);
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x00019FE0 File Offset: 0x000181E0
		[Token(Token = "0x600345C")]
		[Address(RVA = "0x1A30300", Offset = "0x1A30300", VA = "0x1A30300")]
		public static bool DoesFitInCone(Vector2 point, Vector2 coneCenter, float coneLength, float coneRotation, float maximumAngle)
		{
			return default(bool);
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x00019FF8 File Offset: 0x000181F8
		[Token(Token = "0x600345D")]
		[Address(RVA = "0x1A2FEAC", Offset = "0x1A2FEAC", VA = "0x1A2FEAC")]
		public static float ToRotation(Vector2 v)
		{
			return 0f;
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x0001A010 File Offset: 0x00018210
		[Token(Token = "0x600345E")]
		[Address(RVA = "0x1A304E0", Offset = "0x1A304E0", VA = "0x1A304E0")]
		public static double ToRotation(Vector2D v)
		{
			return 0.0;
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x0001A028 File Offset: 0x00018228
		[Token(Token = "0x600345F")]
		[Address(RVA = "0x1A2C718", Offset = "0x1A2C718", VA = "0x1A2C718")]
		public static Vector2 ToRotationVector2(float f)
		{
			return default(Vector2);
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x0001A040 File Offset: 0x00018240
		[Token(Token = "0x6003460")]
		[Address(RVA = "0x1A2E168", Offset = "0x1A2E168", VA = "0x1A2E168")]
		public static Vector2D ToRotationVector2D(double f)
		{
			return default(Vector2D);
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x0001A058 File Offset: 0x00018258
		[Token(Token = "0x6003461")]
		[Address(RVA = "0x1A29180", Offset = "0x1A29180", VA = "0x1A29180")]
		public static Vector2 RotatedBy(Vector2 spinningpoint, double radians, [Optional] Vector2 center)
		{
			return default(Vector2);
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x0001A070 File Offset: 0x00018270
		[Token(Token = "0x6003462")]
		[Address(RVA = "0x1A3055C", Offset = "0x1A3055C", VA = "0x1A3055C")]
		public static Vector2D RotatedBy(Vector2D spinningpoint, double radians, [Optional] Vector2D center)
		{
			return default(Vector2D);
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x0001A088 File Offset: 0x00018288
		[Token(Token = "0x6003463")]
		[Address(RVA = "0x1A30694", Offset = "0x1A30694", VA = "0x1A30694")]
		public static Vector2 RotatedByRandom(Vector2 spinninpoint, double maxRadians)
		{
			return default(Vector2);
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x0001A0A0 File Offset: 0x000182A0
		[Token(Token = "0x6003464")]
		[Address(RVA = "0x1A307CC", Offset = "0x1A307CC", VA = "0x1A307CC")]
		public static Vector2 Floor(Vector2 vec)
		{
			return default(Vector2);
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x0001A0B8 File Offset: 0x000182B8
		[Token(Token = "0x6003465")]
		[Address(RVA = "0x1A30818", Offset = "0x1A30818", VA = "0x1A30818")]
		public static bool HasNaNs(Vector2 vec)
		{
			return default(bool);
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x0001A0D0 File Offset: 0x000182D0
		[Token(Token = "0x6003466")]
		[Address(RVA = "0x1A29AD8", Offset = "0x1A29AD8", VA = "0x1A29AD8")]
		public static bool Between(Vector2 vec, Vector2 minimum, Vector2 maximum)
		{
			return default(bool);
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x0001A0E8 File Offset: 0x000182E8
		[Token(Token = "0x6003467")]
		[Address(RVA = "0x1A308DC", Offset = "0x1A308DC", VA = "0x1A308DC")]
		public static Vector2 ScaledBy(Vector2 vec, Vector2 other)
		{
			return default(Vector2);
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x0001A100 File Offset: 0x00018300
		[Token(Token = "0x6003468")]
		[Address(RVA = "0x1A3097C", Offset = "0x1A3097C", VA = "0x1A3097C")]
		public static Vector2 ScaledBy(Vector2 vec, float scaleX, float scaleY)
		{
			return default(Vector2);
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x0001A118 File Offset: 0x00018318
		[Token(Token = "0x6003469")]
		[Address(RVA = "0x1A30A40", Offset = "0x1A30A40", VA = "0x1A30A40")]
		public static Vector2 ToVector2(Point p)
		{
			return default(Vector2);
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x0001A130 File Offset: 0x00018330
		[Token(Token = "0x600346A")]
		[Address(RVA = "0x1A30A74", Offset = "0x1A30A74", VA = "0x1A30A74")]
		public static Vector2 ToVector2(Point16 p)
		{
			return default(Vector2);
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x0001A148 File Offset: 0x00018348
		[Token(Token = "0x600346B")]
		[Address(RVA = "0x1A30AB0", Offset = "0x1A30AB0", VA = "0x1A30AB0")]
		public static Vector3 ToVector3(Vector2 v)
		{
			return default(Vector3);
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x0001A160 File Offset: 0x00018360
		[Token(Token = "0x600346C")]
		[Address(RVA = "0x1A30ADC", Offset = "0x1A30ADC", VA = "0x1A30ADC")]
		public static Vector2D ToVector2D(Point p)
		{
			return default(Vector2D);
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x0001A178 File Offset: 0x00018378
		[Token(Token = "0x600346D")]
		[Address(RVA = "0x1A30B1C", Offset = "0x1A30B1C", VA = "0x1A30B1C")]
		public static Vector2D ToVector2D(Point16 p)
		{
			return default(Vector2D);
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x0001A190 File Offset: 0x00018390
		[Token(Token = "0x600346E")]
		[Address(RVA = "0x1A30B60", Offset = "0x1A30B60", VA = "0x1A30B60")]
		public static Vector2 ToWorldCoordinates(Point p, float autoAddX = 8f, float autoAddY = 8f)
		{
			return default(Vector2);
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x0001A1A8 File Offset: 0x000183A8
		[Token(Token = "0x600346F")]
		[Address(RVA = "0x1A30CAC", Offset = "0x1A30CAC", VA = "0x1A30CAC")]
		public static Vector2 ToWorldCoordinates(Point16 p, float autoAddX = 8f, float autoAddY = 8f)
		{
			return default(Vector2);
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x0001A1C0 File Offset: 0x000183C0
		[Token(Token = "0x6003470")]
		[Address(RVA = "0x1A30DF4", Offset = "0x1A30DF4", VA = "0x1A30DF4")]
		public static Vector2 MoveTowards(Vector2 currentPosition, Vector2 targetPosition, float maxAmountAllowedToMove)
		{
			return default(Vector2);
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x0001A1D8 File Offset: 0x000183D8
		[Token(Token = "0x6003471")]
		[Address(RVA = "0x1A311D0", Offset = "0x1A311D0", VA = "0x1A311D0")]
		public static float MoveTowards(float original, float target, float amount)
		{
			return 0f;
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x0001A1F0 File Offset: 0x000183F0
		[Token(Token = "0x6003472")]
		[Address(RVA = "0x1A31298", Offset = "0x1A31298", VA = "0x1A31298")]
		public static Point16 ToTileCoordinates16(Vector2 vec)
		{
			return default(Point16);
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x0001A208 File Offset: 0x00018408
		[Token(Token = "0x6003473")]
		[Address(RVA = "0x1A31300", Offset = "0x1A31300", VA = "0x1A31300")]
		public static Point16 ToTileCoordinates16(Vector2D vec)
		{
			return default(Point16);
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x0001A220 File Offset: 0x00018420
		[Token(Token = "0x6003474")]
		[Address(RVA = "0x1A26390", Offset = "0x1A26390", VA = "0x1A26390")]
		public static Point ToTileCoordinates(Vector2 vec)
		{
			return default(Point);
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x0001A238 File Offset: 0x00018438
		[Token(Token = "0x6003475")]
		[Address(RVA = "0x1A31370", Offset = "0x1A31370", VA = "0x1A31370")]
		public static Point ToTileCoordinates(Vector2D vec)
		{
			return default(Point);
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x0001A250 File Offset: 0x00018450
		[Token(Token = "0x6003476")]
		[Address(RVA = "0x1A267D4", Offset = "0x1A267D4", VA = "0x1A267D4")]
		public static Point ToPoint(Vector2 v)
		{
			return default(Point);
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x0001A268 File Offset: 0x00018468
		[Token(Token = "0x6003477")]
		[Address(RVA = "0x1A313D8", Offset = "0x1A313D8", VA = "0x1A313D8")]
		public static Point ToPoint(Vector2D v)
		{
			return default(Point);
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x0001A280 File Offset: 0x00018480
		[Token(Token = "0x6003478")]
		[Address(RVA = "0x1A31438", Offset = "0x1A31438", VA = "0x1A31438")]
		public static Vector2 ToVector2(Vector2D v)
		{
			return default(Vector2);
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x0001A298 File Offset: 0x00018498
		[Token(Token = "0x6003479")]
		[Address(RVA = "0x1A31474", Offset = "0x1A31474", VA = "0x1A31474")]
		public static Vector2D ToVector2D(Vector2 v)
		{
			return default(Vector2D);
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x0001A2B0 File Offset: 0x000184B0
		[Token(Token = "0x600347A")]
		[Address(RVA = "0x1A30FD0", Offset = "0x1A30FD0", VA = "0x1A30FD0")]
		public static Vector2 SafeNormalize(Vector2 v, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x0001A2C8 File Offset: 0x000184C8
		[Token(Token = "0x600347B")]
		[Address(RVA = "0x1A314B4", Offset = "0x1A314B4", VA = "0x1A314B4")]
		public static Vector2D SafeNormalize(Vector2D v, Vector2D defaultValue)
		{
			return default(Vector2D);
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x0001A2E0 File Offset: 0x000184E0
		[Token(Token = "0x600347C")]
		[Address(RVA = "0x1A31610", Offset = "0x1A31610", VA = "0x1A31610")]
		public static Point ClampedInWorld(Point p, int fluff = 0)
		{
			return default(Point);
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x0001A2F8 File Offset: 0x000184F8
		[Token(Token = "0x600347D")]
		[Address(RVA = "0x1A29B34", Offset = "0x1A29B34", VA = "0x1A29B34")]
		public static Vector2 ClosestPointOnLine(Vector2 P, Vector2 A, Vector2 B)
		{
			return default(Vector2);
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x0001A310 File Offset: 0x00018510
		[Token(Token = "0x600347E")]
		[Address(RVA = "0x1A31738", Offset = "0x1A31738", VA = "0x1A31738")]
		public static Vector2D ClosestPointOnLine(Vector2D P, Vector2D A, Vector2D B)
		{
			return default(Vector2D);
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x0001A328 File Offset: 0x00018528
		[Token(Token = "0x600347F")]
		[Address(RVA = "0x1A319A8", Offset = "0x1A319A8", VA = "0x1A319A8")]
		public static bool RectangleLineCollision(Vector2 rectTopLeft, Vector2 rectBottomRight, Vector2 lineStart, Vector2 lineEnd)
		{
			return default(bool);
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x0001A340 File Offset: 0x00018540
		[Token(Token = "0x6003480")]
		[Address(RVA = "0x1A31D50", Offset = "0x1A31D50", VA = "0x1A31D50")]
		public static Vector2 RotateRandom(Vector2 spinninpoint, double maxRadians)
		{
			return default(Vector2);
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x0001A358 File Offset: 0x00018558
		[Token(Token = "0x6003481")]
		[Address(RVA = "0x1A31E88", Offset = "0x1A31E88", VA = "0x1A31E88")]
		public static float AngleTo(Vector2 Origin, Vector2 Target)
		{
			return 0f;
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x0001A370 File Offset: 0x00018570
		[Token(Token = "0x6003482")]
		[Address(RVA = "0x1A31F30", Offset = "0x1A31F30", VA = "0x1A31F30")]
		public static float AngleFrom(Vector2 Origin, Vector2 Target)
		{
			return 0f;
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x0001A388 File Offset: 0x00018588
		[Token(Token = "0x6003483")]
		[Address(RVA = "0x1A31FD8", Offset = "0x1A31FD8", VA = "0x1A31FD8")]
		public static Vector2 rotateTowards(Vector2 currentPosition, Vector2 currentVelocity, Vector2 targetPosition, float maxChange)
		{
			return default(Vector2);
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x0001A3A0 File Offset: 0x000185A0
		[Token(Token = "0x6003484")]
		[Address(RVA = "0x1A29CDC", Offset = "0x1A29CDC", VA = "0x1A29CDC")]
		public static float Distance(Vector2 Origin, Vector2 Target)
		{
			return 0f;
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x0001A3B8 File Offset: 0x000185B8
		[Token(Token = "0x6003485")]
		[Address(RVA = "0x1A3237C", Offset = "0x1A3237C", VA = "0x1A3237C")]
		public static double Distance(Vector2D Origin, Vector2D Target)
		{
			return 0.0;
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x0001A3D0 File Offset: 0x000185D0
		[Token(Token = "0x6003486")]
		[Address(RVA = "0x1A32428", Offset = "0x1A32428", VA = "0x1A32428")]
		public static float DistanceSQ(Vector2 Origin, Vector2 Target)
		{
			return 0f;
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x0001A3E8 File Offset: 0x000185E8
		[Token(Token = "0x6003487")]
		[Address(RVA = "0x1A324B4", Offset = "0x1A324B4", VA = "0x1A324B4")]
		public static Vector2 DirectionTo(Vector2 Origin, Vector2 Target)
		{
			return default(Vector2);
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x0001A400 File Offset: 0x00018600
		[Token(Token = "0x6003488")]
		[Address(RVA = "0x1A32568", Offset = "0x1A32568", VA = "0x1A32568")]
		public static Vector2 DirectionFrom(Vector2 Origin, Vector2 Target)
		{
			return default(Vector2);
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x0001A418 File Offset: 0x00018618
		[Token(Token = "0x6003489")]
		[Address(RVA = "0x1A3261C", Offset = "0x1A3261C", VA = "0x1A3261C")]
		public static bool WithinRange(Vector2 Origin, Vector2 Target, float MaxRange)
		{
			return default(bool);
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x0001A430 File Offset: 0x00018630
		[Token(Token = "0x600348A")]
		[Address(RVA = "0x1A326CC", Offset = "0x1A326CC", VA = "0x1A326CC")]
		public static Vector2 XY(Vector4 vec)
		{
			return default(Vector2);
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x0001A448 File Offset: 0x00018648
		[Token(Token = "0x600348B")]
		[Address(RVA = "0x1A326E8", Offset = "0x1A326E8", VA = "0x1A326E8")]
		public static Vector2 ZW(Vector4 vec)
		{
			return default(Vector2);
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x0001A460 File Offset: 0x00018660
		[Token(Token = "0x600348C")]
		[Address(RVA = "0x1A3270C", Offset = "0x1A3270C", VA = "0x1A3270C")]
		public static Vector3 XZW(Vector4 vec)
		{
			return default(Vector3);
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x0001A478 File Offset: 0x00018678
		[Token(Token = "0x600348D")]
		[Address(RVA = "0x1A3273C", Offset = "0x1A3273C", VA = "0x1A3273C")]
		public static Vector3 YZW(Vector4 vec)
		{
			return default(Vector3);
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x0001A490 File Offset: 0x00018690
		[Token(Token = "0x600348E")]
		[Address(RVA = "0x1A32774", Offset = "0x1A32774", VA = "0x1A32774")]
		public static Color MultiplyRGB(Color firstColor, Color secondColor)
		{
			return default(Color);
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x0001A4A8 File Offset: 0x000186A8
		[Token(Token = "0x600348F")]
		[Address(RVA = "0x1A3284C", Offset = "0x1A3284C", VA = "0x1A3284C")]
		public static Color MultiplyRGBA(Color firstColor, Color secondColor)
		{
			return default(Color);
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003490")]
		[Address(RVA = "0x1A32960", Offset = "0x1A32960", VA = "0x1A32960")]
		public static string Hex3(Color color)
		{
			return null;
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003491")]
		[Address(RVA = "0x1A32A1C", Offset = "0x1A32A1C", VA = "0x1A32A1C")]
		public static string Hex4(Color color)
		{
			return null;
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x0001A4C0 File Offset: 0x000186C0
		[Token(Token = "0x6003492")]
		[Address(RVA = "0x1A32AF4", Offset = "0x1A32AF4", VA = "0x1A32AF4")]
		public static int ToDirectionInt(bool value)
		{
			return 0;
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x0001A4D8 File Offset: 0x000186D8
		[Token(Token = "0x6003493")]
		[Address(RVA = "0x1A32B08", Offset = "0x1A32B08", VA = "0x1A32B08")]
		public static int ToInt(bool value)
		{
			return 0;
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x0001A4F0 File Offset: 0x000186F0
		[Token(Token = "0x6003494")]
		[Address(RVA = "0x1A32B0C", Offset = "0x1A32B0C", VA = "0x1A32B0C")]
		public static int ModulusPositive(int myInteger, int modulusNumber)
		{
			return 0;
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x0001A508 File Offset: 0x00018708
		[Token(Token = "0x6003495")]
		[Address(RVA = "0x1A32B2C", Offset = "0x1A32B2C", VA = "0x1A32B2C")]
		public static float AngleLerp(float curAngle, float targetAngle, float amount)
		{
			return 0f;
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x0001A520 File Offset: 0x00018720
		[Token(Token = "0x6003496")]
		[Address(RVA = "0x1A322DC", Offset = "0x1A322DC", VA = "0x1A322DC")]
		public static float AngleTowards(float curAngle, float targetAngle, float maxChange)
		{
			return 0f;
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x0001A538 File Offset: 0x00018738
		[Token(Token = "0x6003497")]
		[Address(RVA = "0x1A32BB0", Offset = "0x1A32BB0", VA = "0x1A32BB0")]
		public static float RotateUntil(float curAngle, float targetAngle, float changePerTick)
		{
			return 0f;
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x0001A550 File Offset: 0x00018750
		[Token(Token = "0x6003498")]
		[Address(RVA = "0x1A32C4C", Offset = "0x1A32C4C", VA = "0x1A32C4C")]
		public static bool deepCompare(int[] firstArray, int[] secondArray)
		{
			return default(bool);
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x0001A568 File Offset: 0x00018768
		[Token(Token = "0x6003499")]
		[Address(RVA = "0x1A32CC4", Offset = "0x1A32CC4", VA = "0x1A32CC4")]
		public static bool deepCompare(Rectangle[,] firstArray, Rectangle[,] secondArray)
		{
			return default(bool);
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600349A")]
		[Address(RVA = "0x1A32EE8", Offset = "0x1A32EE8", VA = "0x1A32EE8")]
		public static List<int> GetTrueIndexes(bool[] array)
		{
			return null;
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600349B")]
		[Address(RVA = "0x1A33040", Offset = "0x1A33040", VA = "0x1A33040")]
		public static List<int> GetTrueIndexes(bool[][] arrays)
		{
			return null;
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x0001A580 File Offset: 0x00018780
		[Token(Token = "0x600349C")]
		public static int Count<T>(T[] arr, T value)
		{
			return 0;
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x0001A598 File Offset: 0x00018798
		[Token(Token = "0x600349D")]
		[Address(RVA = "0x1A331C0", Offset = "0x1A331C0", VA = "0x1A331C0")]
		public static bool PressingShift(KeyboardState kb)
		{
			return default(bool);
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x0001A5B0 File Offset: 0x000187B0
		[Token(Token = "0x600349E")]
		[Address(RVA = "0x1A33294", Offset = "0x1A33294", VA = "0x1A33294")]
		public static bool PressingControl(KeyboardState kb)
		{
			return default(bool);
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x0001A5C8 File Offset: 0x000187C8
		[Token(Token = "0x600349F")]
		[Address(RVA = "0x1A33368", Offset = "0x1A33368", VA = "0x1A33368")]
		public static bool PressingAlt(KeyboardState kb)
		{
			return default(bool);
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A0")]
		public static R[] MapArray<T, R>(T[] array, Func<T, R> mapper)
		{
			return null;
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x0001A5E0 File Offset: 0x000187E0
		[Token(Token = "0x60034A1")]
		[Address(RVA = "0x1A3343C", Offset = "0x1A3343C", VA = "0x1A3343C")]
		public static bool PlotLine(Point16 p0, Point16 p1, Utils.TileActionAttempt plot, bool jump = true)
		{
			return default(bool);
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x0001A5F8 File Offset: 0x000187F8
		[Token(Token = "0x60034A2")]
		[Address(RVA = "0x1A33758", Offset = "0x1A33758", VA = "0x1A33758")]
		public static bool PlotLine(Point p0, Point p1, Utils.TileActionAttempt plot, bool jump = true)
		{
			return default(bool);
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A3")]
		[Address(RVA = "0x1A337EC", Offset = "0x1A337EC", VA = "0x1A337EC")]
		private static void PlotLineLength(int x0, int y0, int x1, int y1, ref int length, bool jump = true)
		{
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x0001A610 File Offset: 0x00018810
		[Token(Token = "0x60034A4")]
		[Address(RVA = "0x1A339A8", Offset = "0x1A339A8", VA = "0x1A339A8")]
		private static bool PlotLineOffset(Vector2D start, Vector2D end, double halfWidth, int x0, int y0, int x1, int y1, Utils.TileActionAttempt plot, bool jump = true)
		{
			return default(bool);
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x0001A628 File Offset: 0x00018828
		[Token(Token = "0x60034A5")]
		[Address(RVA = "0x1A340C8", Offset = "0x1A340C8", VA = "0x1A340C8")]
		private static bool PlotLineOffsetTale(Vector2D start, Vector2D end, int length, double halfWidth, int x0, int y0, int x1, int y1, Utils.TileActionAttempt plot, bool jump = true)
		{
			return default(bool);
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x0001A640 File Offset: 0x00018840
		[Token(Token = "0x60034A6")]
		[Address(RVA = "0x1A334C8", Offset = "0x1A334C8", VA = "0x1A334C8")]
		private static bool PlotLine(int x0, int y0, int x1, int y1, Utils.TileActionAttempt plot, bool jump = true)
		{
			return default(bool);
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x0001A658 File Offset: 0x00018858
		[Token(Token = "0x60034A7")]
		[Address(RVA = "0x1A348C4", Offset = "0x1A348C4", VA = "0x1A348C4")]
		public static int RandomNext(ref ulong seed, int bits)
		{
			return 0;
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x0001A670 File Offset: 0x00018870
		[Token(Token = "0x60034A8")]
		[Address(RVA = "0x1A3496C", Offset = "0x1A3496C", VA = "0x1A3496C")]
		public static ulong RandomNextSeed(ulong seed)
		{
			return 0UL;
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x0001A688 File Offset: 0x00018888
		[Token(Token = "0x60034A9")]
		[Address(RVA = "0x1A34994", Offset = "0x1A34994", VA = "0x1A34994")]
		public static float RandomFloat(ref ulong seed)
		{
			return 0f;
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x0001A6A0 File Offset: 0x000188A0
		[Token(Token = "0x60034AA")]
		[Address(RVA = "0x1A34A80", Offset = "0x1A34A80", VA = "0x1A34A80")]
		public static int RandomInt(ref ulong seed, int max)
		{
			return 0;
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x0001A6B8 File Offset: 0x000188B8
		[Token(Token = "0x60034AB")]
		[Address(RVA = "0x1A34C30", Offset = "0x1A34C30", VA = "0x1A34C30")]
		public static int RandomInt(ref ulong seed, int min, int max)
		{
			return 0;
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x0001A6D0 File Offset: 0x000188D0
		[Token(Token = "0x60034AC")]
		[Address(RVA = "0x1A34CA4", Offset = "0x1A34CA4", VA = "0x1A34CA4")]
		public static bool PlotTileLineInner(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x0001A6E8 File Offset: 0x000188E8
		[Token(Token = "0x60034AD")]
		[Address(RVA = "0x1A34D40", Offset = "0x1A34D40", VA = "0x1A34D40")]
		public static bool PlotTileLine(Vector2 start, Vector2 end, float width, Utils.TileActionAttempt plot)
		{
			return default(bool);
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x0001A700 File Offset: 0x00018900
		[Token(Token = "0x60034AE")]
		[Address(RVA = "0x1A34E80", Offset = "0x1A34E80", VA = "0x1A34E80")]
		public static bool PlotTileLine(Vector2D start, Vector2D end, double width, Utils.TileActionAttempt plot)
		{
			return default(bool);
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x0001A718 File Offset: 0x00018918
		[Token(Token = "0x60034AF")]
		[Address(RVA = "0x1A352B8", Offset = "0x1A352B8", VA = "0x1A352B8")]
		public static bool PlotTileTale(Vector2D start, Vector2D end, double width, Utils.TileActionAttempt plot)
		{
			return default(bool);
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x0001A730 File Offset: 0x00018930
		[Token(Token = "0x60034B0")]
		[Address(RVA = "0x1A35594", Offset = "0x1A35594", VA = "0x1A35594")]
		public static bool FloodFillTile(int x, int y, float maxDist, Utils.TileActionAttempt plot)
		{
			return default(bool);
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x0001A748 File Offset: 0x00018948
		[Token(Token = "0x60034B1")]
		[Address(RVA = "0x1A36910", Offset = "0x1A36910", VA = "0x1A36910")]
		public static int RandomConsecutive(double random, int odds)
		{
			return 0;
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x0001A760 File Offset: 0x00018960
		[Token(Token = "0x60034B2")]
		[Address(RVA = "0x1A369D4", Offset = "0x1A369D4", VA = "0x1A369D4")]
		public static Vector2 RandomVector2(UnifiedRandom random, float min, float max)
		{
			return default(Vector2);
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x0001A778 File Offset: 0x00018978
		[Token(Token = "0x60034B3")]
		[Address(RVA = "0x1A36A70", Offset = "0x1A36A70", VA = "0x1A36A70")]
		public static Vector2D RandomVector2D(UnifiedRandom random, double min, double max)
		{
			return default(Vector2D);
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x0001A790 File Offset: 0x00018990
		[Token(Token = "0x60034B4")]
		public static bool IndexInRange<T>(T[] t, int index)
		{
			return default(bool);
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x0001A7A8 File Offset: 0x000189A8
		[Token(Token = "0x60034B5")]
		public static bool IndexInRange<T>(List<T> t, int index)
		{
			return default(bool);
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B6")]
		public static T SelectRandom<T>(UnifiedRandom random, T[] choices)
		{
			return null;
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B7")]
		[Address(RVA = "0x1A36B0C", Offset = "0x1A36B0C", VA = "0x1A36B0C")]
		public static void DrawBorderStringFourWay(SpriteBatch sb, SpriteFont font, string text, float x, float y, Color textColor, Color borderColor, Vector2 origin, float scale = 1f)
		{
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x0001A7C0 File Offset: 0x000189C0
		[Token(Token = "0x60034B8")]
		[Address(RVA = "0x1A36CF4", Offset = "0x1A36CF4", VA = "0x1A36CF4")]
		public static Vector2 DrawBorderStringMeasured(SpriteBatch sb, string text, Vector2 pos, Color color, float scale = 1f, float anchorx = 0f, float anchory = 0f, int maxCharactersDisplayed = -1)
		{
			return default(Vector2);
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x0001A7D8 File Offset: 0x000189D8
		[Token(Token = "0x60034B9")]
		[Address(RVA = "0x1A37010", Offset = "0x1A37010", VA = "0x1A37010")]
		public static Vector2 DrawBorderString(SpriteBatch sb, string text, Vector2 pos, Color color, float scale = 1f, float anchorx = 0f, float anchory = 0f, int maxCharactersDisplayed = -1)
		{
			return default(Vector2);
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x0001A7F0 File Offset: 0x000189F0
		[Token(Token = "0x60034BA")]
		[Address(RVA = "0x1A37264", Offset = "0x1A37264", VA = "0x1A37264")]
		public static Vector2 DrawBorderStringBig(SpriteBatch spriteBatch, string text, Vector2 pos, Color color, float scale = 1f, float anchorx = 0f, float anchory = 0f, int maxCharactersDisplayed = -1)
		{
			return default(Vector2);
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BB")]
		[Address(RVA = "0x1A3763C", Offset = "0x1A3763C", VA = "0x1A3763C")]
		public static void DrawInvBG(SpriteBatch sb, Rectangle R, [Optional] Color c)
		{
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BC")]
		[Address(RVA = "0x1A3806C", Offset = "0x1A3806C", VA = "0x1A3806C")]
		public static void DrawInvBG(SpriteBatch sb, float x, float y, float w, float h, [Optional] Color c)
		{
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BD")]
		[Address(RVA = "0x1A376CC", Offset = "0x1A376CC", VA = "0x1A376CC")]
		public static void DrawInvBG(SpriteBatch sb, int x, int y, int w, int h, [Optional] Color c)
		{
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BE")]
		[Address(RVA = "0x1A3815C", Offset = "0x1A3815C", VA = "0x1A3815C")]
		public static string ReadEmbeddedResource(string path)
		{
			return null;
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BF")]
		[Address(RVA = "0x1A38500", Offset = "0x1A38500", VA = "0x1A38500")]
		public static void DrawSplicedPanel(SpriteBatch sb, Texture2D texture, int x, int y, int w, int h, int leftEnd, int rightEnd, int topEnd, int bottomEnd, Color c)
		{
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C0")]
		[Address(RVA = "0x1A38E38", Offset = "0x1A38E38", VA = "0x1A38E38")]
		public static void DrawSettingsPanel(SpriteBatch spriteBatch, Vector2 position, float width, Color color)
		{
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C1")]
		[Address(RVA = "0x1A392FC", Offset = "0x1A392FC", VA = "0x1A392FC")]
		public static void DrawSettings2Panel(SpriteBatch spriteBatch, Vector2 position, float width, Color color)
		{
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C2")]
		[Address(RVA = "0x1A38F24", Offset = "0x1A38F24", VA = "0x1A38F24")]
		public static void DrawPanel(Texture2D texture, int edgeWidth, int edgeShove, SpriteBatch spriteBatch, Vector2 position, float width, Color color)
		{
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C3")]
		[Address(RVA = "0x1A393E8", Offset = "0x1A393E8", VA = "0x1A393E8")]
		public static void DrawRectangle(SpriteBatch sb, Vector2 start, Vector2 end, Color colorStart, Color colorEnd, float width)
		{
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C4")]
		[Address(RVA = "0x1A399E0", Offset = "0x1A399E0", VA = "0x1A399E0")]
		public static void DrawLaser(SpriteBatch sb, Texture2D tex, Vector2 start, Vector2 end, Vector2 scale, Utils.LaserLineFraming framing)
		{
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C5")]
		[Address(RVA = "0x1A3A064", Offset = "0x1A3A064", VA = "0x1A3A064")]
		public static void DrawLine(SpriteBatch spriteBatch, Point start, Point end, Color color)
		{
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C6")]
		[Address(RVA = "0x1A3A160", Offset = "0x1A3A160", VA = "0x1A3A160")]
		public static void DrawLine(SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color color)
		{
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C7")]
		[Address(RVA = "0x1A3957C", Offset = "0x1A3957C", VA = "0x1A3957C")]
		public static void DrawLine(SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color colorStart, Color colorEnd, float width)
		{
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C8")]
		[Address(RVA = "0x1A3A624", Offset = "0x1A3A624", VA = "0x1A3A624")]
		public static void DrawRectForTilesInWorld(SpriteBatch spriteBatch, Rectangle rect, Color color)
		{
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C9")]
		[Address(RVA = "0x1A3A6F0", Offset = "0x1A3A6F0", VA = "0x1A3A6F0")]
		public static void DrawRectForTilesInWorld(SpriteBatch spriteBatch, Point start, Point end, Color color)
		{
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CA")]
		[Address(RVA = "0x1A3A94C", Offset = "0x1A3A94C", VA = "0x1A3A94C")]
		public static void DrawRect(SpriteBatch spriteBatch, Rectangle rect, Color color)
		{
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CB")]
		[Address(RVA = "0x1A3A7F0", Offset = "0x1A3A7F0", VA = "0x1A3A7F0")]
		public static void DrawRect(SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color color)
		{
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CC")]
		[Address(RVA = "0x1A3AA40", Offset = "0x1A3AA40", VA = "0x1A3AA40")]
		public static void DrawRect(SpriteBatch spriteBatch, Vector2 topLeft, Vector2 topRight, Vector2 bottomRight, Vector2 bottomLeft, Color color)
		{
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CD")]
		[Address(RVA = "0x1A3AB28", Offset = "0x1A3AB28", VA = "0x1A3AB28")]
		public static void DrawSelectedCraftingBarIndicator(SpriteBatch spriteBatch, int craftX, int craftY)
		{
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CE")]
		[Address(RVA = "0x1A3AD84", Offset = "0x1A3AD84", VA = "0x1A3AD84")]
		public static void DrawCursorSingle(SpriteBatch sb, Color color, float rot = float.NaN, float scale = 1f, [Optional] Vector2 manualPosition, int cursorSlot = 0, int specialMode = 0)
		{
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x0001A808 File Offset: 0x00018A08
		[Token(Token = "0x60034CF")]
		[Address(RVA = "0x1A3B610", Offset = "0x1A3B610", VA = "0x1A3B610")]
		public static bool TryOperateInLock(object _lock, Action action)
		{
			return default(bool);
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x0001A820 File Offset: 0x00018A20
		[Token(Token = "0x60034D0")]
		[Address(RVA = "0x1A3B6DC", Offset = "0x1A3B6DC", VA = "0x1A3B6DC")]
		public static bool ParseCommandPrefix(string text, string prefix, out string remainder)
		{
			return default(bool);
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D1")]
		[Address(RVA = "0x1A36F48", Offset = "0x1A36F48", VA = "0x1A36F48")]
		public static string TrimUserString(string s, int length)
		{
			return null;
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D2")]
		[Address(RVA = "0x1A2D178", Offset = "0x1A2D178", VA = "0x1A2D178")]
		public static string TrimLastCharacter(string s)
		{
			return null;
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x0001A838 File Offset: 0x00018A38
		[Token(Token = "0x60034D4")]
		[Address(RVA = "0x1A34034", Offset = "0x1A34034", VA = "0x1A34034")]
		internal static bool <PlotLineOffset>g__PlotAtOffset|207_0(int xVal, int yVal, ref Utils.<>c__DisplayClass207_0 A_2)
		{
			return default(bool);
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x0001A850 File Offset: 0x00018A50
		[Token(Token = "0x60034D5")]
		[Address(RVA = "0x1A34530", Offset = "0x1A34530", VA = "0x1A34530")]
		internal static bool <PlotLineOffsetTale>g__PlotAtOffset|208_0(int xVal, int yVal, ref Utils.<>c__DisplayClass208_0 A_2)
		{
			return default(bool);
		}

		// Token: 0x04004360 RID: 17248
		[Token(Token = "0x4004360")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int MaxFloatInt;

		// Token: 0x04004361 RID: 17249
		[Token(Token = "0x4004361")]
		public const long MaxCoins = 9999999999L;

		// Token: 0x04004362 RID: 17250
		[Token(Token = "0x4004362")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static Dictionary<SpriteFont, float[]> charLengths;

		// Token: 0x04004363 RID: 17251
		[Token(Token = "0x4004363")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Regex _substitutionRegex;

		// Token: 0x04004364 RID: 17252
		[Token(Token = "0x4004364")]
		private const ulong RANDOM_MULTIPLIER = 25214903917UL;

		// Token: 0x04004365 RID: 17253
		[Token(Token = "0x4004365")]
		private const ulong RANDOM_ADD = 11UL;

		// Token: 0x04004366 RID: 17254
		[Token(Token = "0x4004366")]
		private const ulong RANDOM_MASK = 281474976710655UL;

		// Token: 0x04004367 RID: 17255
		[Token(Token = "0x4004367")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static Utils.TileActionAttempt plotInnerCall;

		// Token: 0x04004368 RID: 17256
		[Token(Token = "0x4004368")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Point plotInnerLineMinOffset;

		// Token: 0x04004369 RID: 17257
		[Token(Token = "0x4004369")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Point plotInnerLineMaxOffset;

		// Token: 0x0400436A RID: 17258
		[Token(Token = "0x400436A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Utils.TileActionAttempt PlotTileLineInnerInstance;

		// Token: 0x0200050A RID: 1290
		// (Invoke) Token: 0x060034D7 RID: 13527
		[Token(Token = "0x200050A")]
		public delegate bool TileActionAttempt(int x, int y);

		// Token: 0x0200050B RID: 1291
		// (Invoke) Token: 0x060034DB RID: 13531
		[Token(Token = "0x200050B")]
		public delegate void LaserLineFraming(int stage, out float distanceCovered, out Rectangle frame, out Vector2 origin, out Color color);

		// Token: 0x0200050C RID: 1292
		// (Invoke) Token: 0x060034DF RID: 13535
		[Token(Token = "0x200050C")]
		public delegate Color ColorLerpMethod(float percent);

		// Token: 0x0200050D RID: 1293
		[Token(Token = "0x200050D")]
		public class RandomTeleportationAttemptSettings
		{
			// Token: 0x060034E2 RID: 13538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60034E2")]
			[Address(RVA = "0x1A3BF94", Offset = "0x1A3BF94", VA = "0x1A3BF94")]
			public RandomTeleportationAttemptSettings()
			{
			}

			// Token: 0x0400436B RID: 17259
			[Token(Token = "0x400436B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector2 teleporteeSize;

			// Token: 0x0400436C RID: 17260
			[Token(Token = "0x400436C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector2 teleporteeVelocity;

			// Token: 0x0400436D RID: 17261
			[Token(Token = "0x400436D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float teleporteeGravityDirection;

			// Token: 0x0400436E RID: 17262
			[Token(Token = "0x400436E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool mostlySolidFloor;

			// Token: 0x0400436F RID: 17263
			[Token(Token = "0x400436F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
			public bool avoidLava;

			// Token: 0x04004370 RID: 17264
			[Token(Token = "0x4004370")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
			public bool avoidAnyLiquid;

			// Token: 0x04004371 RID: 17265
			[Token(Token = "0x4004371")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
			public bool avoidHurtTiles;

			// Token: 0x04004372 RID: 17266
			[Token(Token = "0x4004372")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool avoidWalls;

			// Token: 0x04004373 RID: 17267
			[Token(Token = "0x4004373")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int attemptsBeforeGivingUp;

			// Token: 0x04004374 RID: 17268
			[Token(Token = "0x4004374")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int maximumFallDistanceFromOrignalPoint;

			// Token: 0x04004375 RID: 17269
			[Token(Token = "0x4004375")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool strictRange;

			// Token: 0x04004376 RID: 17270
			[Token(Token = "0x4004376")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int[] tilesToAvoid;

			// Token: 0x04004377 RID: 17271
			[Token(Token = "0x4004377")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int tilesToAvoidRange;

			// Token: 0x04004378 RID: 17272
			[Token(Token = "0x4004378")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool allowSolidTopFloor;

			// Token: 0x04004379 RID: 17273
			[Token(Token = "0x4004379")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Func<int, int, Tile, Tile, Tile, bool> specializedConditions;
		}

		// Token: 0x0200050E RID: 1294
		[Token(Token = "0x200050E")]
		public struct ChaseResults
		{
			// Token: 0x0400437A RID: 17274
			[Token(Token = "0x400437A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool InterceptionHappens;

			// Token: 0x0400437B RID: 17275
			[Token(Token = "0x400437B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector2 InterceptionPosition;

			// Token: 0x0400437C RID: 17276
			[Token(Token = "0x400437C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float InterceptionTime;

			// Token: 0x0400437D RID: 17277
			[Token(Token = "0x400437D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector2 ChaserVelocity;
		}

		// Token: 0x0200050F RID: 1295
		[Token(Token = "0x200050F")]
		private sealed class <>c__DisplayClass75_0
		{
			// Token: 0x060034E3 RID: 13539 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60034E3")]
			[Address(RVA = "0x1A2D398", Offset = "0x1A2D398", VA = "0x1A2D398")]
			public <>c__DisplayClass75_0()
			{
			}

			// Token: 0x060034E4 RID: 13540 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034E4")]
			[Address(RVA = "0x1A3BF9C", Offset = "0x1A3BF9C", VA = "0x1A3BF9C")]
			internal string <FormatWith>b__0(Match match)
			{
				return null;
			}

			// Token: 0x0400437E RID: 17278
			[Token(Token = "0x400437E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public PropertyDescriptorCollection properties;

			// Token: 0x0400437F RID: 17279
			[Token(Token = "0x400437F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public object obj;
		}

		// Token: 0x02000510 RID: 1296
		[Token(Token = "0x2000510")]
		[StructLayout(3)]
		private struct <>c__DisplayClass207_0
		{
			// Token: 0x04004380 RID: 17280
			[Token(Token = "0x4004380")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int lineMinOffsetX;

			// Token: 0x04004381 RID: 17281
			[Token(Token = "0x4004381")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int lineMinOffsetY;

			// Token: 0x04004382 RID: 17282
			[Token(Token = "0x4004382")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int lineMaxOffsetX;

			// Token: 0x04004383 RID: 17283
			[Token(Token = "0x4004383")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int lineMaxOffsetY;

			// Token: 0x04004384 RID: 17284
			[Token(Token = "0x4004384")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Utils.TileActionAttempt plot;
		}

		// Token: 0x02000511 RID: 1297
		[Token(Token = "0x2000511")]
		[StructLayout(3)]
		private struct <>c__DisplayClass208_0
		{
			// Token: 0x04004385 RID: 17285
			[Token(Token = "0x4004385")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int curLength;

			// Token: 0x04004386 RID: 17286
			[Token(Token = "0x4004386")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int length;

			// Token: 0x04004387 RID: 17287
			[Token(Token = "0x4004387")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Point lineStartMinOffset;

			// Token: 0x04004388 RID: 17288
			[Token(Token = "0x4004388")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector2D start;

			// Token: 0x04004389 RID: 17289
			[Token(Token = "0x4004389")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector2D perpOffset;

			// Token: 0x0400438A RID: 17290
			[Token(Token = "0x400438A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public double halfWidth;

			// Token: 0x0400438B RID: 17291
			[Token(Token = "0x400438B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Point lineStartMaxOffset;

			// Token: 0x0400438C RID: 17292
			[Token(Token = "0x400438C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Point lineMinOffset;

			// Token: 0x0400438D RID: 17293
			[Token(Token = "0x400438D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int x0;

			// Token: 0x0400438E RID: 17294
			[Token(Token = "0x400438E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public int y0;

			// Token: 0x0400438F RID: 17295
			[Token(Token = "0x400438F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Point lineMaxOffset;

			// Token: 0x04004390 RID: 17296
			[Token(Token = "0x4004390")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Utils.TileActionAttempt plot;
		}
	}
}
