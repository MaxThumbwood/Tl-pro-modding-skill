using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000CA7 RID: 3239
	[Token(Token = "0x2000CA7")]
	public class NextHorizonRenderer : FileAPI
	{
		// Token: 0x0600602B RID: 24619 RVA: 0x0002C598 File Offset: 0x0002A798
		[Token(Token = "0x600602B")]
		[Address(RVA = "0xA96510", Offset = "0xA96510", VA = "0xA96510")]
		private static Rectangle GetGradientRect()
		{
			return default(Rectangle);
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602C")]
		[Address(RVA = "0xA966C0", Offset = "0xA966C0", VA = "0xA966C0", Slot = "4")]
		public void DrawHorizon()
		{
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x0002C5B0 File Offset: 0x0002A7B0
		[Token(Token = "0x600602D")]
		[Address(RVA = "0xA96FA0", Offset = "0xA96FA0", VA = "0xA96FA0")]
		public float GetMoonStrength()
		{
			return 0f;
		}

		// Token: 0x0600602E RID: 24622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602E")]
		[Address(RVA = "0xA970B0", Offset = "0xA970B0", VA = "0xA970B0", Slot = "10")]
		public void DrawSurfaceLayer(int layerIndex)
		{
		}

		// Token: 0x0600602F RID: 24623 RVA: 0x0002C5C8 File Offset: 0x0002A7C8
		[Token(Token = "0x600602F")]
		[Address(RVA = "0xA96C88", Offset = "0xA96C88", VA = "0xA96C88")]
		private int GetSunriseSunsetTextureIndex()
		{
			return 0;
		}

		// Token: 0x06006030 RID: 24624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006030")]
		[Address(RVA = "0xA97A80", Offset = "0xA97A80", VA = "0xA97A80", Slot = "5")]
		public void ModifyHorizonLight(ref Color color)
		{
		}

		// Token: 0x06006031 RID: 24625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006031")]
		[Address(RVA = "0xA97D14", Offset = "0xA97D14", VA = "0xA97D14", Slot = "6")]
		public void DrawSun(Vector2 sunPosition)
		{
		}

		// Token: 0x06006032 RID: 24626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006032")]
		[Address(RVA = "0xA97CC4", Offset = "0xA97CC4", VA = "0xA97CC4")]
		private void BlendColor(ref Color color, Color[] gradient, float opacity)
		{
		}

		// Token: 0x06006033 RID: 24627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006033")]
		[Address(RVA = "0xA97924", Offset = "0xA97924", VA = "0xA97924")]
		private void BlendColor(ref Color color, Color colorToChoose, float opacity)
		{
		}

		// Token: 0x06006034 RID: 24628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006034")]
		[Address(RVA = "0xA96CE8", Offset = "0xA96CE8", VA = "0xA96CE8")]
		private static void GetVisibilities(out float sunsetVisibility, out float sunriseVisibility, out float celestialVisibility)
		{
		}

		// Token: 0x06006035 RID: 24629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006035")]
		[Address(RVA = "0xA98580", Offset = "0xA98580", VA = "0xA98580", Slot = "7")]
		public void CloudsStart()
		{
		}

		// Token: 0x06006036 RID: 24630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006036")]
		[Address(RVA = "0xA98D60", Offset = "0xA98D60", VA = "0xA98D60", Slot = "8")]
		public void DrawCloud(float globalCloudAlpha, Cloud theCloud, int cloudPass, float cY)
		{
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006037")]
		[Address(RVA = "0xA996F4", Offset = "0xA996F4", VA = "0xA996F4")]
		private void OriginalColorsForCloud(Cloud theCloud, int cloudPass, ref Color cloudColor)
		{
		}

		// Token: 0x06006038 RID: 24632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006038")]
		[Address(RVA = "0xA997C4", Offset = "0xA997C4", VA = "0xA997C4")]
		private void BetterColorsForClouds(Cloud theCloud, int cloudPass, ref Vector2 cloudDrawPosition, ref Color cloudColor)
		{
		}

		// Token: 0x06006039 RID: 24633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006039")]
		[Address(RVA = "0xA99A9C", Offset = "0xA99A9C", VA = "0xA99A9C")]
		private void BlendColorAlongGradientBasedOnHeight(ref Color color, float visibility, float normalizedScreenHeight, Color[] gradient, float opacity)
		{
		}

		// Token: 0x0600603A RID: 24634 RVA: 0x0002C5E0 File Offset: 0x0002A7E0
		[Token(Token = "0x600603A")]
		[Address(RVA = "0xA98410", Offset = "0xA98410", VA = "0xA98410")]
		private static float GetCelestialEffectPower()
		{
			return 0f;
		}

		// Token: 0x0600603B RID: 24635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600603B")]
		[Address(RVA = "0xA99C5C", Offset = "0xA99C5C", VA = "0xA99C5C", Slot = "9")]
		public void CloudsEnd()
		{
		}

		// Token: 0x0600603C RID: 24636 RVA: 0x0002C5F8 File Offset: 0x0002A7F8
		[Token(Token = "0x600603C")]
		[Address(RVA = "0xA98CE8", Offset = "0xA98CE8", VA = "0xA98CE8")]
		private static Vector2 GetCelestialBodyPosition()
		{
			return default(Vector2);
		}

		// Token: 0x0600603D RID: 24637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600603D")]
		[Address(RVA = "0xA99EB8", Offset = "0xA99EB8", VA = "0xA99EB8", Slot = "11")]
		public void DrawLensFlare()
		{
		}

		// Token: 0x0600603E RID: 24638 RVA: 0x0002C610 File Offset: 0x0002A810
		[Token(Token = "0x600603E")]
		[Address(RVA = "0xA9A0C0", Offset = "0xA9A0C0", VA = "0xA9A0C0")]
		private float AdjustIntensity(float temporalIntensity, float celestialVisibility)
		{
			return 0f;
		}

		// Token: 0x0600603F RID: 24639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600603F")]
		[Address(RVA = "0xA9A7A0", Offset = "0xA9A7A0", VA = "0xA9A7A0")]
		private void DrawSunsetFlare(SpriteBatch spriteBatch, Vector2 sunPosition, Vector2 screenCenter, float intensity)
		{
		}

		// Token: 0x06006040 RID: 24640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006040")]
		[Address(RVA = "0xA9A220", Offset = "0xA9A220", VA = "0xA9A220")]
		private void DrawSunriseFlare(SpriteBatch spriteBatch, Vector2 sunPosition, Vector2 screenCenter, float intensity)
		{
		}

		// Token: 0x06006041 RID: 24641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006041")]
		[Address(RVA = "0xA9B414", Offset = "0xA9B414", VA = "0xA9B414")]
		public NextHorizonRenderer()
		{
		}

		// Token: 0x04009EE5 RID: 40677
		[Token(Token = "0x4009EE5")]
		[FieldOffset(Offset = "0x8")]
		private string[] _sunriseTexturePaths;

		// Token: 0x04009EE6 RID: 40678
		[Token(Token = "0x4009EE6")]
		[FieldOffset(Offset = "0xC")]
		private string[] _sunsetTexturePaths;

		// Token: 0x04009EE7 RID: 40679
		[Token(Token = "0x4009EE7")]
		private const int DEFAULT_MAX_SPRITES = 200;

		// Token: 0x04009EE8 RID: 40680
		[Token(Token = "0x4009EE8")]
		[FieldOffset(Offset = "0x10")]
		private List<DrawData> _drawData;
	}
}
