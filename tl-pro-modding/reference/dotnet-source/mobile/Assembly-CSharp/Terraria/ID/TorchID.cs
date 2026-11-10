using System;
using Il2CppDummyDll;

namespace Terraria.ID
{
	// Token: 0x02000725 RID: 1829
	[Token(Token = "0x2000725")]
	public static class TorchID
	{
		// Token: 0x06004207 RID: 16903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004207")]
		[Address(RVA = "0x4EB170", Offset = "0x4EB170", VA = "0x4EB170")]
		public static void Initialize()
		{
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004208")]
		[Address(RVA = "0x4EBCDC", Offset = "0x4EBCDC", VA = "0x4EBCDC")]
		public static void TorchColor(int torchID, out float R, out float G, out float B)
		{
		}

		// Token: 0x040087CB RID: 34763
		[Token(Token = "0x40087CB")]
		[FieldOffset(Offset = "0x0")]
		public static int[] Dust;

		// Token: 0x040087CC RID: 34764
		[Token(Token = "0x40087CC")]
		[FieldOffset(Offset = "0x4")]
		private static TorchID.ITorchLightProvider[] _lights;

		// Token: 0x040087CD RID: 34765
		[Token(Token = "0x40087CD")]
		public const short Torch = 0;

		// Token: 0x040087CE RID: 34766
		[Token(Token = "0x40087CE")]
		public const short Blue = 1;

		// Token: 0x040087CF RID: 34767
		[Token(Token = "0x40087CF")]
		public const short Red = 2;

		// Token: 0x040087D0 RID: 34768
		[Token(Token = "0x40087D0")]
		public const short Green = 3;

		// Token: 0x040087D1 RID: 34769
		[Token(Token = "0x40087D1")]
		public const short Purple = 4;

		// Token: 0x040087D2 RID: 34770
		[Token(Token = "0x40087D2")]
		public const short White = 5;

		// Token: 0x040087D3 RID: 34771
		[Token(Token = "0x40087D3")]
		public const short Yellow = 6;

		// Token: 0x040087D4 RID: 34772
		[Token(Token = "0x40087D4")]
		public const short Demon = 7;

		// Token: 0x040087D5 RID: 34773
		[Token(Token = "0x40087D5")]
		public const short Cursed = 8;

		// Token: 0x040087D6 RID: 34774
		[Token(Token = "0x40087D6")]
		public const short Ice = 9;

		// Token: 0x040087D7 RID: 34775
		[Token(Token = "0x40087D7")]
		public const short Orange = 10;

		// Token: 0x040087D8 RID: 34776
		[Token(Token = "0x40087D8")]
		public const short Ichor = 11;

		// Token: 0x040087D9 RID: 34777
		[Token(Token = "0x40087D9")]
		public const short UltraBright = 12;

		// Token: 0x040087DA RID: 34778
		[Token(Token = "0x40087DA")]
		public const short Bone = 13;

		// Token: 0x040087DB RID: 34779
		[Token(Token = "0x40087DB")]
		public const short Rainbow = 14;

		// Token: 0x040087DC RID: 34780
		[Token(Token = "0x40087DC")]
		public const short Pink = 15;

		// Token: 0x040087DD RID: 34781
		[Token(Token = "0x40087DD")]
		public const short Desert = 16;

		// Token: 0x040087DE RID: 34782
		[Token(Token = "0x40087DE")]
		public const short Coral = 17;

		// Token: 0x040087DF RID: 34783
		[Token(Token = "0x40087DF")]
		public const short Corrupt = 18;

		// Token: 0x040087E0 RID: 34784
		[Token(Token = "0x40087E0")]
		public const short Crimson = 19;

		// Token: 0x040087E1 RID: 34785
		[Token(Token = "0x40087E1")]
		public const short Hallowed = 20;

		// Token: 0x040087E2 RID: 34786
		[Token(Token = "0x40087E2")]
		public const short Jungle = 21;

		// Token: 0x040087E3 RID: 34787
		[Token(Token = "0x40087E3")]
		public const short Mushroom = 22;

		// Token: 0x040087E4 RID: 34788
		[Token(Token = "0x40087E4")]
		public const short Shimmer = 23;

		// Token: 0x040087E5 RID: 34789
		[Token(Token = "0x40087E5")]
		[FieldOffset(Offset = "0x8")]
		public static readonly short Count;

		// Token: 0x02000726 RID: 1830
		[Token(Token = "0x2000726")]
		public class Sets
		{
			// Token: 0x0600420A RID: 16906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600420A")]
			[Address(RVA = "0x4EBF14", Offset = "0x4EBF14", VA = "0x4EBF14")]
			public Sets()
			{
			}

			// Token: 0x040087E6 RID: 34790
			[Token(Token = "0x40087E6")]
			[FieldOffset(Offset = "0x0")]
			public static SetFactory Factory;

			// Token: 0x040087E7 RID: 34791
			[Token(Token = "0x40087E7")]
			[FieldOffset(Offset = "0x4")]
			public static bool[] IsABiomeTorch;
		}

		// Token: 0x02000727 RID: 1831
		[Token(Token = "0x2000727")]
		private interface ITorchLightProvider
		{
			// Token: 0x0600420C RID: 16908
			[Token(Token = "0x600420C")]
			void GetRGB(out float r, out float g, out float b);
		}

		// Token: 0x02000728 RID: 1832
		[Token(Token = "0x2000728")]
		private struct ConstantTorchLight : FileAPI
		{
			// Token: 0x0600420D RID: 16909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600420D")]
			[Address(RVA = "0x4EBCD4", Offset = "0x4EBCD4", VA = "0x4EBCD4")]
			public ConstantTorchLight(float Red, float Green, float Blue)
			{
			}

			// Token: 0x0600420E RID: 16910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600420E")]
			[Address(RVA = "0x4EC07C", Offset = "0x4EC07C", VA = "0x4EC07C", Slot = "4")]
			public void GetRGB(out float r, out float g, out float b)
			{
			}

			// Token: 0x040087E8 RID: 34792
			[Token(Token = "0x40087E8")]
			[FieldOffset(Offset = "0x0")]
			public float R;

			// Token: 0x040087E9 RID: 34793
			[Token(Token = "0x40087E9")]
			[FieldOffset(Offset = "0x4")]
			public float G;

			// Token: 0x040087EA RID: 34794
			[Token(Token = "0x40087EA")]
			[FieldOffset(Offset = "0x8")]
			public float B;
		}

		// Token: 0x02000729 RID: 1833
		[Token(Token = "0x2000729")]
		private struct DemonTorchLight : FileAPI
		{
			// Token: 0x0600420F RID: 16911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600420F")]
			[Address(RVA = "0x4EC098", Offset = "0x4EC098", VA = "0x4EC098", Slot = "4")]
			public void GetRGB(out float r, out float g, out float b)
			{
			}
		}

		// Token: 0x0200072A RID: 1834
		[Token(Token = "0x200072A")]
		private struct ShimmerTorchLight : FileAPI
		{
			// Token: 0x06004210 RID: 16912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004210")]
			[Address(RVA = "0x4EC138", Offset = "0x4EC138", VA = "0x4EC138", Slot = "4")]
			public void GetRGB(out float r, out float g, out float b)
			{
			}
		}

		// Token: 0x0200072B RID: 1835
		[Token(Token = "0x200072B")]
		private struct DiscoTorchLight : FileAPI
		{
			// Token: 0x06004211 RID: 16913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004211")]
			[Address(RVA = "0x4EC244", Offset = "0x4EC244", VA = "0x4EC244", Slot = "4")]
			public void GetRGB(out float r, out float g, out float b)
			{
			}
		}
	}
}
