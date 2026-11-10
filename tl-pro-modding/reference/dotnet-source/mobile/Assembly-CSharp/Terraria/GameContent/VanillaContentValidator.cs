using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent
{
	// Token: 0x020009EB RID: 2539
	[Token(Token = "0x20009EB")]
	public class VanillaContentValidator : FileAPI
	{
		// Token: 0x060052B5 RID: 21173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052B5")]
		[Address(RVA = "0x7E3528", Offset = "0x7E3528", VA = "0x7E3528")]
		public VanillaContentValidator(string infoFilePath)
		{
		}

		// Token: 0x060052B6 RID: 21174 RVA: 0x00026868 File Offset: 0x00024A68
		[Token(Token = "0x60052B6")]
		public bool AssetIsValid<T>(T content, string contentPath, out IRejectionReason rejectReason) where T : class
		{
			return default(bool);
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B7")]
		[Address(RVA = "0x7E37EC", Offset = "0x7E37EC", VA = "0x7E37EC")]
		public HashSet<string> GetValidImageFilePaths()
		{
			return null;
		}

		// Token: 0x040096F3 RID: 38643
		[Token(Token = "0x40096F3")]
		[FieldOffset(Offset = "0x0")]
		public static VanillaContentValidator Instance;

		// Token: 0x040096F4 RID: 38644
		[Token(Token = "0x40096F4")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, VanillaContentValidator.TextureMetaData> _info;

		// Token: 0x020009EC RID: 2540
		[Token(Token = "0x20009EC")]
		private struct TextureMetaData
		{
			// Token: 0x060052B8 RID: 21176 RVA: 0x00026880 File Offset: 0x00024A80
			[Token(Token = "0x60052B8")]
			[Address(RVA = "0x7E3980", Offset = "0x7E3980", VA = "0x7E3980")]
			public bool Matches(Texture2D texture, out IRejectionReason rejectReason)
			{
				return default(bool);
			}

			// Token: 0x040096F5 RID: 38645
			[Token(Token = "0x40096F5")]
			[FieldOffset(Offset = "0x0")]
			public int Width;

			// Token: 0x040096F6 RID: 38646
			[Token(Token = "0x40096F6")]
			[FieldOffset(Offset = "0x4")]
			public int Height;
		}

		// Token: 0x020009ED RID: 2541
		[Token(Token = "0x20009ED")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060052BA RID: 21178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60052BA")]
			[Address(RVA = "0x7E3AF8", Offset = "0x7E3AF8", VA = "0x7E3AF8")]
			public <>c()
			{
			}

			// Token: 0x060052BB RID: 21179 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60052BB")]
			[Address(RVA = "0x7E3B00", Offset = "0x7E3B00", VA = "0x7E3B00")]
			internal string <GetValidImageFilePaths>b__4_0(KeyValuePair<string, VanillaContentValidator.TextureMetaData> x)
			{
				return null;
			}

			// Token: 0x040096F7 RID: 38647
			[Token(Token = "0x40096F7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly VanillaContentValidator.<>c <>9;

			// Token: 0x040096F8 RID: 38648
			[Token(Token = "0x40096F8")]
			[FieldOffset(Offset = "0x4")]
			public static Func<KeyValuePair<string, VanillaContentValidator.TextureMetaData>, string> <>9__4_0;
		}
	}
}
