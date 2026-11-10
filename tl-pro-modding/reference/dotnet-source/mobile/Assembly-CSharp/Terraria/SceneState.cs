using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria
{
	// Token: 0x020004FA RID: 1274
	[Token(Token = "0x20004FA")]
	public class SceneState
	{
		// Token: 0x06003286 RID: 12934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003286")]
		[Address(RVA = "0x1A04ED4", Offset = "0x1A04ED4", VA = "0x1A04ED4")]
		public SceneState()
		{
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003287")]
		[Address(RVA = "0x1A04F7C", Offset = "0x1A04F7C", VA = "0x1A04F7C")]
		public void Reset()
		{
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003288")]
		[Address(RVA = "0x1A04FA4", Offset = "0x1A04FA4", VA = "0x1A04FA4")]
		public void Update(SceneMetrics metrics)
		{
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003289")]
		[Address(RVA = "0x1A05028", Offset = "0x1A05028", VA = "0x1A05028")]
		private void ApplyVisuals(SceneMetrics metrics)
		{
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600328A")]
		[Address(RVA = "0x1A08268", Offset = "0x1A08268", VA = "0x1A08268")]
		private void UpdateLightDecay(SceneMetrics metrics)
		{
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600328B")]
		[Address(RVA = "0x1A07FF4", Offset = "0x1A07FF4", VA = "0x1A07FF4")]
		private void UpdateShimmer(SceneMetrics metrics)
		{
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600328C")]
		[Address(RVA = "0x1A083D4", Offset = "0x1A083D4", VA = "0x1A083D4")]
		private void ManageSpecialBiomeVisuals(string biomeName, bool inZone, [Optional] Vector2 activationSource, bool alwaysInstant = false)
		{
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600328D")]
		[Address(RVA = "0x1A07E90", Offset = "0x1A07E90", VA = "0x1A07E90")]
		private void UpdateGraveyard(SceneMetrics metrics)
		{
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600328E")]
		[Address(RVA = "0x1A07A80", Offset = "0x1A07A80", VA = "0x1A07A80")]
		private void UpdateRGBPeriheralProbe(SceneMetrics metrics)
		{
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600328F")]
		[Address(RVA = "0x1A08AE4", Offset = "0x1A08AE4", VA = "0x1A08AE4")]
		public void MoveTowards(ref float value, float target, float amount)
		{
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003290")]
		[Address(RVA = "0x1A08AFC", Offset = "0x1A08AFC", VA = "0x1A08AFC")]
		public void MoveTowards(ref float value, float target, float inc, float dec)
		{
		}

		// Token: 0x040042DC RID: 17116
		[Token(Token = "0x40042DC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float airLightDecay;

		// Token: 0x040042DD RID: 17117
		[Token(Token = "0x40042DD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float solidLightDecay;

		// Token: 0x040042DE RID: 17118
		[Token(Token = "0x40042DE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float outsideWeatherEffectIntensity;

		// Token: 0x040042DF RID: 17119
		[Token(Token = "0x40042DF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float _outsideWeatherEffectIntensityBackingValue;

		// Token: 0x040042E0 RID: 17120
		[Token(Token = "0x40042E0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _deerclopsBlizzardSmoothedEffect;

		// Token: 0x040042E1 RID: 17121
		[Token(Token = "0x40042E1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool _disabledBlizzardGraphic;

		// Token: 0x040042E2 RID: 17122
		[Token(Token = "0x40042E2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool _disabledBlizzardSound;

		// Token: 0x040042E3 RID: 17123
		[Token(Token = "0x40042E3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _blizzardSoundVolume;

		// Token: 0x040042E4 RID: 17124
		[Token(Token = "0x40042E4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private SlotId _strongBlizzardSound;

		// Token: 0x040042E5 RID: 17125
		[Token(Token = "0x40042E5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SlotId _insideBlizzardSound;

		// Token: 0x040042E6 RID: 17126
		[Token(Token = "0x40042E6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _shimmerBrightenDelay;

		// Token: 0x040042E7 RID: 17127
		[Token(Token = "0x40042E7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool skipTransitions;
	}
}
