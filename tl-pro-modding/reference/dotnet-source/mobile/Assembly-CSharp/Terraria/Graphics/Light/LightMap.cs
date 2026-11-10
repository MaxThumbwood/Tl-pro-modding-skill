using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.Graphics.Light
{
	// Token: 0x020008FC RID: 2300
	[Token(Token = "0x20008FC")]
	public class LightMap
	{
		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06004D47 RID: 19783 RVA: 0x000243A8 File Offset: 0x000225A8
		// (set) Token: 0x06004D48 RID: 19784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000951")]
		public int NonVisiblePadding
		{
			[Token(Token = "0x6004D47")]
			[Address(RVA = "0x722C40", Offset = "0x722C40", VA = "0x722C40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004D48")]
			[Address(RVA = "0x722C48", Offset = "0x722C48", VA = "0x722C48")]
			set
			{
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06004D49 RID: 19785 RVA: 0x000243C0 File Offset: 0x000225C0
		// (set) Token: 0x06004D4A RID: 19786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000952")]
		public int Width
		{
			[Token(Token = "0x6004D49")]
			[Address(RVA = "0x722C50", Offset = "0x722C50", VA = "0x722C50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004D4A")]
			[Address(RVA = "0x722C58", Offset = "0x722C58", VA = "0x722C58")]
			private set
			{
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06004D4B RID: 19787 RVA: 0x000243D8 File Offset: 0x000225D8
		// (set) Token: 0x06004D4C RID: 19788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000953")]
		public int Height
		{
			[Token(Token = "0x6004D4B")]
			[Address(RVA = "0x722C60", Offset = "0x722C60", VA = "0x722C60")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004D4C")]
			[Address(RVA = "0x722C68", Offset = "0x722C68", VA = "0x722C68")]
			private set
			{
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06004D4D RID: 19789 RVA: 0x000243F0 File Offset: 0x000225F0
		// (set) Token: 0x06004D4E RID: 19790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000954")]
		public float LightDecayThroughAir
		{
			[Token(Token = "0x6004D4D")]
			[Address(RVA = "0x720114", Offset = "0x720114", VA = "0x720114")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004D4E")]
			[Address(RVA = "0x720018", Offset = "0x720018", VA = "0x720018")]
			set
			{
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06004D4F RID: 19791 RVA: 0x00024408 File Offset: 0x00022608
		// (set) Token: 0x06004D50 RID: 19792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000955")]
		public float LightDecayThroughSolid
		{
			[Token(Token = "0x6004D4F")]
			[Address(RVA = "0x720138", Offset = "0x720138", VA = "0x720138")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004D50")]
			[Address(RVA = "0x72006C", Offset = "0x72006C", VA = "0x72006C")]
			set
			{
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06004D51 RID: 19793 RVA: 0x00024420 File Offset: 0x00022620
		// (set) Token: 0x06004D52 RID: 19794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000956")]
		public float LightDecayThroughCrackedBrick
		{
			[Token(Token = "0x6004D51")]
			[Address(RVA = "0x72015C", Offset = "0x72015C", VA = "0x72015C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004D52")]
			[Address(RVA = "0x7200C0", Offset = "0x7200C0", VA = "0x7200C0")]
			set
			{
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06004D53 RID: 19795 RVA: 0x00024438 File Offset: 0x00022638
		// (set) Token: 0x06004D54 RID: 19796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000957")]
		public Vector3 LightDecayThroughWater
		{
			[Token(Token = "0x6004D53")]
			[Address(RVA = "0x7201B0", Offset = "0x7201B0", VA = "0x7201B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6004D54")]
			[Address(RVA = "0x720180", Offset = "0x720180", VA = "0x720180")]
			set
			{
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06004D55 RID: 19797 RVA: 0x00024450 File Offset: 0x00022650
		// (set) Token: 0x06004D56 RID: 19798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000958")]
		public Vector3 LightDecayThroughHoney
		{
			[Token(Token = "0x6004D55")]
			[Address(RVA = "0x722C70", Offset = "0x722C70", VA = "0x722C70")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6004D56")]
			[Address(RVA = "0x7201DC", Offset = "0x7201DC", VA = "0x7201DC")]
			set
			{
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06004D57 RID: 19799 RVA: 0x00024468 File Offset: 0x00022668
		// (set) Token: 0x06004D58 RID: 19800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000959")]
		public Vector3 Item
		{
			[Token(Token = "0x6004D57")]
			[Address(RVA = "0x71D0B8", Offset = "0x71D0B8", VA = "0x71D0B8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6004D58")]
			[Address(RVA = "0x722CA8", Offset = "0x722CA8", VA = "0x722CA8")]
			set
			{
			}
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D59")]
		[Address(RVA = "0x71CD1C", Offset = "0x71CD1C", VA = "0x71CD1C")]
		public LightMap()
		{
		}

		// Token: 0x06004D5A RID: 19802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D5A")]
		[Address(RVA = "0x722CE0", Offset = "0x722CE0", VA = "0x722CE0")]
		public void GetLight(int x, int y, out Vector3 color)
		{
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x00024480 File Offset: 0x00022680
		[Token(Token = "0x6004D5B")]
		[Address(RVA = "0x722D1C", Offset = "0x722D1C", VA = "0x722D1C")]
		public LightMaskMode GetMask(int x, int y)
		{
			return LightMaskMode.None;
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D5C")]
		[Address(RVA = "0x71F77C", Offset = "0x71F77C", VA = "0x71F77C")]
		public void Clear()
		{
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D5D")]
		[Address(RVA = "0x722D44", Offset = "0x722D44", VA = "0x722D44")]
		public void SetMaskAt(int x, int y, LightMaskMode mode)
		{
		}

		// Token: 0x06004D5E RID: 19806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D5E")]
		[Address(RVA = "0x721B60", Offset = "0x721B60", VA = "0x721B60")]
		public void BlurPass1()
		{
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D5F")]
		[Address(RVA = "0x721B64", Offset = "0x721B64", VA = "0x721B64")]
		public void BlurPass2()
		{
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D60")]
		[Address(RVA = "0x722F24", Offset = "0x722F24", VA = "0x722F24")]
		public void Blur()
		{
		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D61")]
		[Address(RVA = "0x722F48", Offset = "0x722F48", VA = "0x722F48")]
		private void ExportBatchFinished(int index)
		{
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06004D62 RID: 19810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700095A")]
		private ThreadedRenderManager.BatchProcessCallback ExportBatchFinishedCallback
		{
			[Token(Token = "0x6004D62")]
			[Address(RVA = "0x722F4C", Offset = "0x722F4C", VA = "0x722F4C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06004D63 RID: 19811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700095B")]
		private ThreadedRenderManager ThreadManager
		{
			[Token(Token = "0x6004D63")]
			[Address(RVA = "0x722FF8", Offset = "0x722FF8", VA = "0x722FF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004D64 RID: 19812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D64")]
		[Address(RVA = "0x72306C", Offset = "0x72306C", VA = "0x72306C")]
		private void Blur1PassThreaded(int start, int end)
		{
		}

		// Token: 0x06004D65 RID: 19813
		[Token(Token = "0x6004D65")]
		[Address(RVA = "0x7234B4", Offset = "0x7234B4", VA = "0x7234B4")]
		[PreserveSig]
		public unsafe static extern void Blur1PassNative(Vector3* colors, Vector3* decayData, LightMaskMode* maskData, int start, int end, int width, int height);

		// Token: 0x06004D66 RID: 19814
		[Token(Token = "0x6004D66")]
		[Address(RVA = "0x7234B8", Offset = "0x7234B8", VA = "0x7234B8")]
		[PreserveSig]
		public unsafe static extern void Blur2PassNative(Vector3* colors, Vector3* decayData, LightMaskMode* maskData, int start, int end, int width, int height);

		// Token: 0x06004D67 RID: 19815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D67")]
		[Address(RVA = "0x72342C", Offset = "0x72342C", VA = "0x72342C")]
		public void Blur1Pass(int start, int end)
		{
		}

		// Token: 0x06004D68 RID: 19816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D68")]
		[Address(RVA = "0x7234BC", Offset = "0x7234BC", VA = "0x7234BC")]
		private void Blur2PassThreaded(int start, int end)
		{
		}

		// Token: 0x06004D69 RID: 19817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D69")]
		[Address(RVA = "0x723714", Offset = "0x723714", VA = "0x723714")]
		public void Blur2Pass(int start, int end)
		{
		}

		// Token: 0x06004D6A RID: 19818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D6A")]
		[Address(RVA = "0x722D70", Offset = "0x722D70", VA = "0x722D70")]
		private void BlurPass()
		{
		}

		// Token: 0x06004D6B RID: 19819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D6B")]
		[Address(RVA = "0x72020C", Offset = "0x72020C", VA = "0x72020C")]
		public void ExecutePartialBlur(int pass)
		{
		}

		// Token: 0x06004D6C RID: 19820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D6C")]
		[Address(RVA = "0x723954", Offset = "0x723954", VA = "0x723954")]
		private void BlurLine(int startIndex, int endIndex, int stride)
		{
		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D6D")]
		[Address(RVA = "0x72379C", Offset = "0x72379C", VA = "0x72379C")]
		private void BlurLine2(int startIndex, int endIndex, int stride)
		{
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x00024498 File Offset: 0x00022698
		[Token(Token = "0x6004D6E")]
		[Address(RVA = "0x722C9C", Offset = "0x722C9C", VA = "0x722C9C")]
		private int IndexOf(int x, int y)
		{
			return 0;
		}

		// Token: 0x06004D6F RID: 19823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D6F")]
		[Address(RVA = "0x71D53C", Offset = "0x71D53C", VA = "0x71D53C")]
		public void SetSize(int width, int height)
		{
		}

		// Token: 0x04009234 RID: 37428
		[Token(Token = "0x4009234")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <NonVisiblePadding>k__BackingField;

		// Token: 0x04009235 RID: 37429
		[Token(Token = "0x4009235")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int <Width>k__BackingField;

		// Token: 0x04009236 RID: 37430
		[Token(Token = "0x4009236")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <Height>k__BackingField;

		// Token: 0x04009237 RID: 37431
		[Token(Token = "0x4009237")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3[] _colors;

		// Token: 0x04009238 RID: 37432
		[Token(Token = "0x4009238")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LightMaskMode[] _mask;

		// Token: 0x04009239 RID: 37433
		[Token(Token = "0x4009239")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3[] _decayColors;

		// Token: 0x0400923A RID: 37434
		[Token(Token = "0x400923A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FastRandom _random;

		// Token: 0x0400923B RID: 37435
		[Token(Token = "0x400923B")]
		private const int DEFAULT_WIDTH = 203;

		// Token: 0x0400923C RID: 37436
		[Token(Token = "0x400923C")]
		private const int DEFAULT_HEIGHT = 203;

		// Token: 0x0400923D RID: 37437
		[Token(Token = "0x400923D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

		// Token: 0x0400923E RID: 37438
		[Token(Token = "0x400923E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private ThreadedRenderManager _threadManager;
	}
}
