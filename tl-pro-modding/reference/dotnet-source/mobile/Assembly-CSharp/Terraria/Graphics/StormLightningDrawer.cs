using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities.Terraria.Utilities;

namespace Terraria.Graphics
{
	// Token: 0x020008B4 RID: 2228
	[Token(Token = "0x20008B4")]
	public struct StormLightningDrawer
	{
		// Token: 0x06004B7F RID: 19327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B7F")]
		[Address(RVA = "0x656998", Offset = "0x656998", VA = "0x656998")]
		public void Draw(Vector2[] positions, float[] rotations, float width, Color color, float progress, bool isMainBolt, FloatRange progressRange, float intensity, StormLightningDrawer.AnimParams animParams, [Optional] Vector2 offset)
		{
		}

		// Token: 0x06004B80 RID: 19328 RVA: 0x00023E50 File Offset: 0x00022050
		[Token(Token = "0x6004B80")]
		[Address(RVA = "0x6573F4", Offset = "0x6573F4", VA = "0x6573F4")]
		private static float WaveTransition(float progressOnStrip, float waveProgress, float transitionLength, float from, float to)
		{
			return 0f;
		}

		// Token: 0x06004B81 RID: 19329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B81")]
		[Address(RVA = "0x6574D4", Offset = "0x6574D4", VA = "0x6574D4")]
		private void StripColors(float progressOnStrip, out Color col)
		{
		}

		// Token: 0x06004B82 RID: 19330 RVA: 0x00023E68 File Offset: 0x00022068
		[Token(Token = "0x6004B82")]
		[Address(RVA = "0x65779C", Offset = "0x65779C", VA = "0x65779C")]
		private float StripWidth(float progressOnStrip)
		{
			return 0f;
		}

		// Token: 0x0400907C RID: 36988
		[Token(Token = "0x400907C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VertexStrip _vertexStrip;

		// Token: 0x0400907D RID: 36989
		[Token(Token = "0x400907D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float _width;

		// Token: 0x0400907E RID: 36990
		[Token(Token = "0x400907E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private Color _color;

		// Token: 0x0400907F RID: 36991
		[Token(Token = "0x400907F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool _isMainBolt;

		// Token: 0x04009080 RID: 36992
		[Token(Token = "0x4009080")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private float _progress;

		// Token: 0x04009081 RID: 36993
		[Token(Token = "0x4009081")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private FloatRange _progressRange;

		// Token: 0x04009082 RID: 36994
		[Token(Token = "0x4009082")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _taperEnd;

		// Token: 0x04009083 RID: 36995
		[Token(Token = "0x4009083")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private StormLightningDrawer.AnimParams _anim;

		// Token: 0x04009084 RID: 36996
		[Token(Token = "0x4009084")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static StormLightningDrawer.AnimParams DefaultAnim;

		// Token: 0x04009085 RID: 36997
		[Token(Token = "0x4009085")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static StormLightningDrawer.AnimParams ArcSurge;

		// Token: 0x020008B5 RID: 2229
		[Token(Token = "0x20008B5")]
		public struct AnimParams
		{
			// Token: 0x04009086 RID: 36998
			[Token(Token = "0x4009086")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float InitialOpacity;

			// Token: 0x04009087 RID: 36999
			[Token(Token = "0x4009087")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float FadeStartProgress;

			// Token: 0x04009088 RID: 37000
			[Token(Token = "0x4009088")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float FadeMidProgress;

			// Token: 0x04009089 RID: 37001
			[Token(Token = "0x4009089")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float FadeEndProgress;

			// Token: 0x0400908A RID: 37002
			[Token(Token = "0x400908A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float FinalOpacity;

			// Token: 0x0400908B RID: 37003
			[Token(Token = "0x400908B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float WaveTransitionLength;

			// Token: 0x0400908C RID: 37004
			[Token(Token = "0x400908C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float WaveTransitionInDuration;

			// Token: 0x0400908D RID: 37005
			[Token(Token = "0x400908D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float WaveTransitionOutDuration;
		}
	}
}
