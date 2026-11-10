using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;

namespace Terraria
{
	// Token: 0x020004A4 RID: 1188
	[Token(Token = "0x20004A4")]
	public class PopupText
	{
		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06002CBF RID: 11455 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002CC0 RID: 11456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FF")]
		public static PopupText[] popupText
		{
			[Token(Token = "0x6002CBF")]
			[Address(RVA = "0x187F970", Offset = "0x187F970", VA = "0x187F970")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CC0")]
			[Address(RVA = "0x187F9D8", Offset = "0x187F9D8", VA = "0x187F9D8")]
			set
			{
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000600")]
		public Vector2[] charOffsets
		{
			[Token(Token = "0x6002CC1")]
			[Address(RVA = "0x187FA44", Offset = "0x187FA44", VA = "0x187FA44")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06002CC2 RID: 11458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000601")]
		public Color[] charColors
		{
			[Token(Token = "0x6002CC2")]
			[Address(RVA = "0x187FAA8", Offset = "0x187FAA8", VA = "0x187FAA8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x00015A68 File Offset: 0x00013C68
		[Token(Token = "0x17000602")]
		public bool AnyEffect
		{
			[Token(Token = "0x6002CC3")]
			[Address(RVA = "0x187FB0C", Offset = "0x187FB0C", VA = "0x187FB0C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06002CC4 RID: 11460 RVA: 0x00015A80 File Offset: 0x00013C80
		[Token(Token = "0x17000603")]
		public bool notActuallyAnItem
		{
			[Token(Token = "0x6002CC4")]
			[Address(RVA = "0x187FB1C", Offset = "0x187FB1C", VA = "0x187FB1C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x00015A98 File Offset: 0x00013C98
		[Token(Token = "0x17000604")]
		public static float TargetScale
		{
			[Token(Token = "0x6002CC5")]
			[Address(RVA = "0x187FB40", Offset = "0x187FB40", VA = "0x187FB40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CC6")]
		[Address(RVA = "0x187FC28", Offset = "0x187FC28", VA = "0x187FC28")]
		public static void ClearSonarText()
		{
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CC7")]
		[Address(RVA = "0x187FDCC", Offset = "0x187FDCC", VA = "0x187FDCC")]
		public static void ResetText(PopupText text)
		{
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x00015AB0 File Offset: 0x00013CB0
		[Token(Token = "0x6002CC8")]
		[Address(RVA = "0x187FEF8", Offset = "0x187FEF8", VA = "0x187FEF8")]
		public static int NewText(AdvancedPopupRequest request, Vector2 position)
		{
			return 0;
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x00015AC8 File Offset: 0x00013CC8
		[Token(Token = "0x6002CC9")]
		[Address(RVA = "0x18804E4", Offset = "0x18804E4", VA = "0x18804E4")]
		public static int NewText(PopupTextContext context, int npcNetID, Vector2 position, bool stay5TimesLonger)
		{
			return 0;
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x00015AE0 File Offset: 0x00013CE0
		[Token(Token = "0x6002CCA")]
		[Address(RVA = "0x18808F8", Offset = "0x18808F8", VA = "0x18808F8")]
		public static int NewText(PopupTextContext context, Item newItem, Vector2 position, int stack, bool noStack = false, bool longText = false)
		{
			return 0;
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CCB")]
		[Address(RVA = "0x1881A3C", Offset = "0x1881A3C", VA = "0x1881A3C")]
		private static void PrepareEffects(PopupTextContext context, Item newItem, PopupText somePopup)
		{
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CCC")]
		[Address(RVA = "0x1880414", Offset = "0x1880414", VA = "0x1880414")]
		private void PrepareDisplayText()
		{
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CCD")]
		[Address(RVA = "0x1881F50", Offset = "0x1881F50", VA = "0x1881F50")]
		private void PrepareTextEffects()
		{
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CCE")]
		[Address(RVA = "0x18820AC", Offset = "0x18820AC", VA = "0x18820AC")]
		private static void EmitFancyFlashDust(PopupText somePopup)
		{
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CCF")]
		[Address(RVA = "0x18815AC", Offset = "0x18815AC", VA = "0x18815AC")]
		private void AddToCoinValue(long addedValue)
		{
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x00015AF8 File Offset: 0x00013CF8
		[Token(Token = "0x6002CD0")]
		[Address(RVA = "0x18801DC", Offset = "0x18801DC", VA = "0x18801DC")]
		private static int FindNextItemTextSlot()
		{
			return 0;
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD1")]
		[Address(RVA = "0x18829F8", Offset = "0x18829F8", VA = "0x18829F8")]
		public static void AssignAsSonarText(int sonarTextIndex)
		{
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CD2")]
		[Address(RVA = "0x1881664", Offset = "0x1881664", VA = "0x1881664")]
		public static string ValueToName(long coinValue)
		{
			return null;
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD3")]
		[Address(RVA = "0x1881B48", Offset = "0x1881B48", VA = "0x1881B48")]
		private void ValueToName()
		{
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD4")]
		[Address(RVA = "0x1882B04", Offset = "0x1882B04", VA = "0x1882B04")]
		private void UpdateCache()
		{
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD5")]
		[Address(RVA = "0x1882C78", Offset = "0x1882C78", VA = "0x1882C78")]
		public void Update(int whoAmI)
		{
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD6")]
		[Address(RVA = "0x188349C", Offset = "0x188349C", VA = "0x188349C")]
		public static void UpdateItemText()
		{
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD7")]
		[Address(RVA = "0x1883614", Offset = "0x1883614", VA = "0x1883614")]
		public static void ClearAll()
		{
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD8")]
		[Address(RVA = "0x1883768", Offset = "0x1883768", VA = "0x1883768")]
		public static void DrawItemTextPopups(float scaleTarget)
		{
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD9")]
		[Address(RVA = "0x1883750", Offset = "0x1883750", VA = "0x1883750")]
		public PopupText()
		{
		}

		// Token: 0x04003DFB RID: 15867
		[Token(Token = "0x4003DFB")]
		[FieldOffset(Offset = "0x0")]
		public static int activeTime;

		// Token: 0x04003DFC RID: 15868
		[Token(Token = "0x4003DFC")]
		[FieldOffset(Offset = "0x4")]
		public static int numActive;

		// Token: 0x04003DFD RID: 15869
		[Token(Token = "0x4003DFD")]
		[FieldOffset(Offset = "0x8")]
		public static int sonarText;

		// Token: 0x04003DFE RID: 15870
		[Token(Token = "0x4003DFE")]
		[FieldOffset(Offset = "0xC")]
		private static float[] TextAnimKeys;

		// Token: 0x04003DFF RID: 15871
		[Token(Token = "0x4003DFF")]
		public const int maxItemText = 20;

		// Token: 0x04003E00 RID: 15872
		[Token(Token = "0x4003E00")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 position;

		// Token: 0x04003E01 RID: 15873
		[Token(Token = "0x4003E01")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 velocity;

		// Token: 0x04003E02 RID: 15874
		[Token(Token = "0x4003E02")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 triggerPosition;

		// Token: 0x04003E03 RID: 15875
		[Token(Token = "0x4003E03")]
		[FieldOffset(Offset = "0x20")]
		public float alpha;

		// Token: 0x04003E04 RID: 15876
		[Token(Token = "0x4003E04")]
		[FieldOffset(Offset = "0x24")]
		public int alphaDir;

		// Token: 0x04003E05 RID: 15877
		[Token(Token = "0x4003E05")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x04003E06 RID: 15878
		[Token(Token = "0x4003E06")]
		[FieldOffset(Offset = "0x2C")]
		public string displayText;

		// Token: 0x04003E07 RID: 15879
		[Token(Token = "0x4003E07")]
		[FieldOffset(Offset = "0x30")]
		public long stack;

		// Token: 0x04003E08 RID: 15880
		[Token(Token = "0x4003E08")]
		[FieldOffset(Offset = "0x38")]
		public float scale;

		// Token: 0x04003E09 RID: 15881
		[Token(Token = "0x4003E09")]
		[FieldOffset(Offset = "0x3C")]
		public float rotation;

		// Token: 0x04003E0A RID: 15882
		[Token(Token = "0x4003E0A")]
		[FieldOffset(Offset = "0x40")]
		public Color color;

		// Token: 0x04003E0B RID: 15883
		[Token(Token = "0x4003E0B")]
		[FieldOffset(Offset = "0x44")]
		public bool active;

		// Token: 0x04003E0C RID: 15884
		[Token(Token = "0x4003E0C")]
		[FieldOffset(Offset = "0x48")]
		public int lifeTime;

		// Token: 0x04003E0D RID: 15885
		[Token(Token = "0x4003E0D")]
		[FieldOffset(Offset = "0x4C")]
		public int framesSinceSpawn;

		// Token: 0x04003E0E RID: 15886
		[Token(Token = "0x4003E0E")]
		[FieldOffset(Offset = "0x50")]
		public bool NoStack;

		// Token: 0x04003E0F RID: 15887
		[Token(Token = "0x4003E0F")]
		[FieldOffset(Offset = "0x54")]
		public int TextAnim;

		// Token: 0x04003E10 RID: 15888
		[Token(Token = "0x4003E10")]
		[FieldOffset(Offset = "0x58")]
		public bool coinText;

		// Token: 0x04003E11 RID: 15889
		[Token(Token = "0x4003E11")]
		[FieldOffset(Offset = "0x60")]
		public long coinValue;

		// Token: 0x04003E12 RID: 15890
		[Token(Token = "0x4003E12")]
		[FieldOffset(Offset = "0x68")]
		public bool expert;

		// Token: 0x04003E13 RID: 15891
		[Token(Token = "0x4003E13")]
		[FieldOffset(Offset = "0x69")]
		public bool master;

		// Token: 0x04003E14 RID: 15892
		[Token(Token = "0x4003E14")]
		[FieldOffset(Offset = "0x6A")]
		public bool sonar;

		// Token: 0x04003E15 RID: 15893
		[Token(Token = "0x4003E15")]
		[FieldOffset(Offset = "0x6C")]
		public PopupTextContext context;

		// Token: 0x04003E16 RID: 15894
		[Token(Token = "0x4003E16")]
		[FieldOffset(Offset = "0x70")]
		public int npcNetID;

		// Token: 0x04003E17 RID: 15895
		[Token(Token = "0x4003E17")]
		[FieldOffset(Offset = "0x74")]
		public bool freeAdvanced;

		// Token: 0x04003E18 RID: 15896
		[Token(Token = "0x4003E18")]
		[FieldOffset(Offset = "0x78")]
		public PopupEffectStyle effectStyle;

		// Token: 0x04003E19 RID: 15897
		[Token(Token = "0x4003E19")]
		[FieldOffset(Offset = "0x7C")]
		public int effectIntensity;

		// Token: 0x04003E1A RID: 15898
		[Token(Token = "0x4003E1A")]
		[FieldOffset(Offset = "0x80")]
		private Vector2 cachedSize;

		// Token: 0x04003E1B RID: 15899
		[Token(Token = "0x4003E1B")]
		[FieldOffset(Offset = "0x88")]
		private string cachedName;

		// Token: 0x04003E1C RID: 15900
		[Token(Token = "0x4003E1C")]
		[FieldOffset(Offset = "0x90")]
		private long cachedStack;

		// Token: 0x04003E1D RID: 15901
		[Token(Token = "0x4003E1D")]
		[FieldOffset(Offset = "0x10")]
		private static Vector2[] charOffsetsShared;

		// Token: 0x04003E1E RID: 15902
		[Token(Token = "0x4003E1E")]
		[FieldOffset(Offset = "0x14")]
		private static Color[] charColorsShared;
	}
}
