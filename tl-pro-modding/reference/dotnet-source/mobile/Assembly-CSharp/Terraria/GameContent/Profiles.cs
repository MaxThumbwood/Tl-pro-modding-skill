using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent
{
	// Token: 0x020009DE RID: 2526
	[Token(Token = "0x20009DE")]
	public class Profiles
	{
		// Token: 0x0600526F RID: 21103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600526F")]
		[Address(RVA = "0x7DEF7C", Offset = "0x7DEF7C", VA = "0x7DEF7C")]
		public Profiles()
		{
		}

		// Token: 0x020009DF RID: 2527
		[Token(Token = "0x20009DF")]
		public class StackedNPCProfile : FileAPI
		{
			// Token: 0x06005270 RID: 21104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005270")]
			[Address(RVA = "0x7DCC70", Offset = "0x7DCC70", VA = "0x7DCC70")]
			public StackedNPCProfile(ITownNPCProfile[] profilesInOrderOfVariants)
			{
			}

			// Token: 0x06005271 RID: 21105 RVA: 0x00026670 File Offset: 0x00024870
			[Token(Token = "0x6005271")]
			[Address(RVA = "0x7DEF84", Offset = "0x7DEF84", VA = "0x7DEF84", Slot = "4")]
			public int RollVariation()
			{
				return 0;
			}

			// Token: 0x06005272 RID: 21106 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005272")]
			[Address(RVA = "0x7DEF8C", Offset = "0x7DEF8C", VA = "0x7DEF8C", Slot = "5")]
			public string GetNameForVariant(NPC npc)
			{
				return null;
			}

			// Token: 0x06005273 RID: 21107 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005273")]
			[Address(RVA = "0x7DF0DC", Offset = "0x7DF0DC", VA = "0x7DF0DC", Slot = "6")]
			public Asset<Texture2D> GetTextureNPCShouldUse(NPC npc)
			{
				return null;
			}

			// Token: 0x06005274 RID: 21108 RVA: 0x00026688 File Offset: 0x00024888
			[Token(Token = "0x6005274")]
			[Address(RVA = "0x7DF22C", Offset = "0x7DF22C", VA = "0x7DF22C", Slot = "7")]
			public int GetHeadTextureIndex(NPC npc)
			{
				return 0;
			}

			// Token: 0x040096CC RID: 38604
			[Token(Token = "0x40096CC")]
			[FieldOffset(Offset = "0x8")]
			internal ITownNPCProfile[] _profiles;
		}

		// Token: 0x020009E0 RID: 2528
		[Token(Token = "0x20009E0")]
		public class LegacyNPCProfile : FileAPI
		{
			// Token: 0x06005275 RID: 21109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005275")]
			[Address(RVA = "0x7DC964", Offset = "0x7DC964", VA = "0x7DC964")]
			public LegacyNPCProfile(string npcFileTitleFilePath, int defaultHeadIndex, bool includeDefault = true, bool uniquePartyTexture = true)
			{
			}

			// Token: 0x06005276 RID: 21110 RVA: 0x000266A0 File Offset: 0x000248A0
			[Token(Token = "0x6005276")]
			[Address(RVA = "0x7DF37C", Offset = "0x7DF37C", VA = "0x7DF37C", Slot = "4")]
			public int RollVariation()
			{
				return 0;
			}

			// Token: 0x06005277 RID: 21111 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005277")]
			[Address(RVA = "0x7DF384", Offset = "0x7DF384", VA = "0x7DF384", Slot = "5")]
			public string GetNameForVariant(NPC npc)
			{
				return null;
			}

			// Token: 0x06005278 RID: 21112 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005278")]
			[Address(RVA = "0x7DF3FC", Offset = "0x7DF3FC", VA = "0x7DF3FC", Slot = "6")]
			public Asset<Texture2D> GetTextureNPCShouldUse(NPC npc)
			{
				return null;
			}

			// Token: 0x06005279 RID: 21113 RVA: 0x000266B8 File Offset: 0x000248B8
			[Token(Token = "0x6005279")]
			[Address(RVA = "0x7DF450", Offset = "0x7DF450", VA = "0x7DF450", Slot = "7")]
			public int GetHeadTextureIndex(NPC npc)
			{
				return 0;
			}

			// Token: 0x040096CD RID: 38605
			[Token(Token = "0x40096CD")]
			[FieldOffset(Offset = "0x8")]
			private string _rootFilePath;

			// Token: 0x040096CE RID: 38606
			[Token(Token = "0x40096CE")]
			[FieldOffset(Offset = "0xC")]
			private int _defaultVariationHeadIndex;

			// Token: 0x040096CF RID: 38607
			[Token(Token = "0x40096CF")]
			[FieldOffset(Offset = "0x10")]
			internal Asset<Texture2D> _defaultNoAlt;

			// Token: 0x040096D0 RID: 38608
			[Token(Token = "0x40096D0")]
			[FieldOffset(Offset = "0x14")]
			internal Asset<Texture2D> _defaultParty;
		}

		// Token: 0x020009E1 RID: 2529
		[Token(Token = "0x20009E1")]
		public class TransformableNPCProfile : FileAPI
		{
			// Token: 0x0600527A RID: 21114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600527A")]
			[Address(RVA = "0x7DCEA0", Offset = "0x7DCEA0", VA = "0x7DCEA0")]
			public TransformableNPCProfile(string npcFileTitleFilePath, int defaultHeadIndex, bool includeCredits = true)
			{
			}

			// Token: 0x0600527B RID: 21115 RVA: 0x000266D0 File Offset: 0x000248D0
			[Token(Token = "0x600527B")]
			[Address(RVA = "0x7DF458", Offset = "0x7DF458", VA = "0x7DF458", Slot = "4")]
			public int RollVariation()
			{
				return 0;
			}

			// Token: 0x0600527C RID: 21116 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600527C")]
			[Address(RVA = "0x7DF460", Offset = "0x7DF460", VA = "0x7DF460", Slot = "5")]
			public string GetNameForVariant(NPC npc)
			{
				return null;
			}

			// Token: 0x0600527D RID: 21117 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600527D")]
			[Address(RVA = "0x7DF4D8", Offset = "0x7DF4D8", VA = "0x7DF4D8", Slot = "6")]
			public Asset<Texture2D> GetTextureNPCShouldUse(NPC npc)
			{
				return null;
			}

			// Token: 0x0600527E RID: 21118 RVA: 0x000266E8 File Offset: 0x000248E8
			[Token(Token = "0x600527E")]
			[Address(RVA = "0x7DF53C", Offset = "0x7DF53C", VA = "0x7DF53C", Slot = "7")]
			public int GetHeadTextureIndex(NPC npc)
			{
				return 0;
			}

			// Token: 0x040096D1 RID: 38609
			[Token(Token = "0x40096D1")]
			[FieldOffset(Offset = "0x8")]
			private string _rootFilePath;

			// Token: 0x040096D2 RID: 38610
			[Token(Token = "0x40096D2")]
			[FieldOffset(Offset = "0xC")]
			private int _defaultVariationHeadIndex;

			// Token: 0x040096D3 RID: 38611
			[Token(Token = "0x40096D3")]
			[FieldOffset(Offset = "0x10")]
			internal Asset<Texture2D> _defaultNoAlt;

			// Token: 0x040096D4 RID: 38612
			[Token(Token = "0x40096D4")]
			[FieldOffset(Offset = "0x14")]
			internal Asset<Texture2D> _defaultTransformed;

			// Token: 0x040096D5 RID: 38613
			[Token(Token = "0x40096D5")]
			[FieldOffset(Offset = "0x18")]
			internal Asset<Texture2D> _defaultCredits;
		}

		// Token: 0x020009E2 RID: 2530
		[Token(Token = "0x20009E2")]
		public class VariantNPCProfile : FileAPI
		{
			// Token: 0x0600527F RID: 21119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600527F")]
			[Address(RVA = "0x7DEB48", Offset = "0x7DEB48", VA = "0x7DEB48")]
			public VariantNPCProfile(string npcFileTitleFilePath, string npcBaseName, int[] variantHeadIds, string[] variantTextureNames)
			{
			}

			// Token: 0x06005280 RID: 21120 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005280")]
			[Address(RVA = "0x7DF544", Offset = "0x7DF544", VA = "0x7DF544")]
			public Profiles.VariantNPCProfile SetPartyTextures(string[] variantTextureNames)
			{
				return null;
			}

			// Token: 0x06005281 RID: 21121 RVA: 0x00026700 File Offset: 0x00024900
			[Token(Token = "0x6005281")]
			[Address(RVA = "0x7DF790", Offset = "0x7DF790", VA = "0x7DF790", Slot = "4")]
			public int RollVariation()
			{
				return 0;
			}

			// Token: 0x06005282 RID: 21122 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005282")]
			[Address(RVA = "0x7DF830", Offset = "0x7DF830", VA = "0x7DF830", Slot = "5")]
			public string GetNameForVariant(NPC npc)
			{
				return null;
			}

			// Token: 0x06005283 RID: 21123 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005283")]
			[Address(RVA = "0x7DF9A8", Offset = "0x7DF9A8", VA = "0x7DF9A8", Slot = "6")]
			public Asset<Texture2D> GetTextureNPCShouldUse(NPC npc)
			{
				return null;
			}

			// Token: 0x06005284 RID: 21124 RVA: 0x00026718 File Offset: 0x00024918
			[Token(Token = "0x6005284")]
			[Address(RVA = "0x7DFB1C", Offset = "0x7DFB1C", VA = "0x7DFB1C", Slot = "7")]
			public int GetHeadTextureIndex(NPC npc)
			{
				return 0;
			}

			// Token: 0x040096D6 RID: 38614
			[Token(Token = "0x40096D6")]
			[FieldOffset(Offset = "0x8")]
			private string _rootFilePath;

			// Token: 0x040096D7 RID: 38615
			[Token(Token = "0x40096D7")]
			[FieldOffset(Offset = "0xC")]
			private string _npcBaseName;

			// Token: 0x040096D8 RID: 38616
			[Token(Token = "0x40096D8")]
			[FieldOffset(Offset = "0x10")]
			private int[] _variantHeadIDs;

			// Token: 0x040096D9 RID: 38617
			[Token(Token = "0x40096D9")]
			[FieldOffset(Offset = "0x14")]
			private string[] _variants;

			// Token: 0x040096DA RID: 38618
			[Token(Token = "0x40096DA")]
			[FieldOffset(Offset = "0x18")]
			internal Dictionary<string, Asset<Texture2D>> _variantTextures;
		}
	}
}
