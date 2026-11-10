using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Content;
using Terraria.GameContent;
using Terraria.GameContent.UI.Minimap;
using Terraria.GameContent.UI.ResourceSets;
using Terraria.IO;

namespace Terraria.Initializers
{
	// Token: 0x0200068F RID: 1679
	[Token(Token = "0x200068F")]
	public static class AssetInitializer
	{
		// Token: 0x06004094 RID: 16532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004094")]
		[Address(RVA = "0x1EC9B34", Offset = "0x1EC9B34", VA = "0x1EC9B34")]
		public static void CreateAssetServices(GameServiceContainer services)
		{
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004095")]
		[Address(RVA = "0x1EC9D40", Offset = "0x1EC9D40", VA = "0x1EC9D40")]
		public static void LoadSplashAssets(bool asyncLoadForSounds)
		{
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004096")]
		[Address(RVA = "0x1ECA028", Offset = "0x1ECA028", VA = "0x1ECA028")]
		public static IEnumerator LoadAssetsWhileInInitialBlackScreen_InSteps()
		{
			return null;
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004097")]
		[Address(RVA = "0x1ECA098", Offset = "0x1ECA098", VA = "0x1ECA098")]
		public static void LoadAssetsWhileInInitialBlackScreen()
		{
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004098")]
		[Address(RVA = "0x1ED5944", Offset = "0x1ED5944", VA = "0x1ED5944")]
		public static void Load(bool asyncLoad)
		{
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004099")]
		[Address(RVA = "0x1ED5948", Offset = "0x1ED5948", VA = "0x1ED5948")]
		private static IEnumerator LoadFonts_InSteps(AssetRequestMode mode)
		{
			return null;
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600409A")]
		[Address(RVA = "0x1ECA898", Offset = "0x1ECA898", VA = "0x1ECA898")]
		private static void LoadFonts(AssetRequestMode mode)
		{
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600409B")]
		[Address(RVA = "0x1ED58C0", Offset = "0x1ED58C0", VA = "0x1ED58C0")]
		private static void LoadSounds(AssetRequestMode mode)
		{
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600409C")]
		[Address(RVA = "0x1ED5780", Offset = "0x1ED5780", VA = "0x1ED5780")]
		private static void LoadRenderTargetAssets(AssetRequestMode mode)
		{
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600409D")]
		[Address(RVA = "0x1ED59D8", Offset = "0x1ED59D8", VA = "0x1ED59D8")]
		private static void RegisterRenderTargetAsset(INeedRenderTargetContent content)
		{
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600409E")]
		[Address(RVA = "0x1ED5AC8", Offset = "0x1ED5AC8", VA = "0x1ED5AC8")]
		private static IEnumerator LoadTextures_InSteps(AssetRequestMode mode)
		{
			return null;
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600409F")]
		[Address(RVA = "0x1ECAAC4", Offset = "0x1ECAAC4", VA = "0x1ECAAC4")]
		private static void LoadTextures(AssetRequestMode mode)
		{
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A0")]
		[Address(RVA = "0x1ED5B58", Offset = "0x1ED5B58", VA = "0x1ED5B58")]
		private static void LoadMinimapFrames(AssetRequestMode mode)
		{
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A1")]
		[Address(RVA = "0x1ED6D08", Offset = "0x1ED6D08", VA = "0x1ED6D08")]
		private static void Configuration_OnSave_MinimapFrame(Preferences obj)
		{
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A2")]
		[Address(RVA = "0x1ED6A28", Offset = "0x1ED6A28", VA = "0x1ED6A28")]
		private static void LoadMinimap(string name, Vector2 frameOffset, Vector2 resetPosition, Vector2 zoomInPosition, Vector2 zoomOutPosition, AssetRequestMode mode)
		{
		}

		// Token: 0x060040A3 RID: 16547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A3")]
		[Address(RVA = "0x1ED65B8", Offset = "0x1ED65B8", VA = "0x1ED65B8")]
		private static void LoadPlayerResourceSets(AssetRequestMode mode)
		{
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A4")]
		[Address(RVA = "0x1ED6EF4", Offset = "0x1ED6EF4", VA = "0x1ED6EF4")]
		private static void Configuration_OnSave_PlayerResourcesSet(Preferences obj)
		{
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040A5")]
		private static Asset<T> LoadAsset<T>(string assetName, AssetRequestMode mode) where T : class
		{
			return null;
		}

		// Token: 0x04004E7D RID: 20093
		[Token(Token = "0x4004E7D")]
		[FieldOffset(Offset = "0x0")]
		public static bool initialAssetsLoaded;

		// Token: 0x02000690 RID: 1680
		[Token(Token = "0x2000690")]
		private sealed class <LoadAssetsWhileInInitialBlackScreen_InSteps>d__3 : FileAPI, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x060040A6 RID: 16550 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040A6")]
			[Address(RVA = "0x1ED70E0", Offset = "0x1ED70E0", VA = "0x1ED70E0")]
			public <LoadAssetsWhileInInitialBlackScreen_InSteps>d__3(int <>1__state)
			{
			}

			// Token: 0x060040A7 RID: 16551 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040A7")]
			[Address(RVA = "0x1ED70FC", Offset = "0x1ED70FC", VA = "0x1ED70FC", Slot = "5")]
			private void System.IDisposable.Dispose()
			{
			}

			// Token: 0x060040A8 RID: 16552 RVA: 0x0001FC50 File Offset: 0x0001DE50
			[Token(Token = "0x60040A8")]
			[Address(RVA = "0x1ED7100", Offset = "0x1ED7100", VA = "0x1ED7100", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700080C RID: 2060
			// (get) Token: 0x060040A9 RID: 16553 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700080C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60040A9")]
				[Address(RVA = "0x1ED7CAC", Offset = "0x1ED7CAC", VA = "0x1ED7CAC", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060040AA RID: 16554 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040AA")]
			[Address(RVA = "0x1ED7CB4", Offset = "0x1ED7CB4", VA = "0x1ED7CB4", Slot = "8")]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			// Token: 0x1700080D RID: 2061
			// (get) Token: 0x060040AB RID: 16555 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700080D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60040AB")]
				[Address(RVA = "0x1ED7D00", Offset = "0x1ED7D00", VA = "0x1ED7D00", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04004E7E RID: 20094
			[Token(Token = "0x4004E7E")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x04004E7F RID: 20095
			[Token(Token = "0x4004E7F")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x04004E80 RID: 20096
			[Token(Token = "0x4004E80")]
			[FieldOffset(Offset = "0x10")]
			private bool <doneLoadingFonts>5__2;

			// Token: 0x04004E81 RID: 20097
			[Token(Token = "0x4004E81")]
			[FieldOffset(Offset = "0x14")]
			private IEnumerator <fontLoadProcedure>5__3;

			// Token: 0x04004E82 RID: 20098
			[Token(Token = "0x4004E82")]
			[FieldOffset(Offset = "0x18")]
			private bool <doneLoadingTextures>5__4;

			// Token: 0x04004E83 RID: 20099
			[Token(Token = "0x4004E83")]
			[FieldOffset(Offset = "0x1C")]
			private IEnumerator <textureLoadProcedure>5__5;
		}

		// Token: 0x02000691 RID: 1681
		[Token(Token = "0x2000691")]
		private sealed class <LoadFonts_InSteps>d__6 : FileAPI, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x060040AC RID: 16556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040AC")]
			[Address(RVA = "0x1ED7D08", Offset = "0x1ED7D08", VA = "0x1ED7D08")]
			public <LoadFonts_InSteps>d__6(int <>1__state)
			{
			}

			// Token: 0x060040AD RID: 16557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040AD")]
			[Address(RVA = "0x1ED7D24", Offset = "0x1ED7D24", VA = "0x1ED7D24", Slot = "5")]
			private void System.IDisposable.Dispose()
			{
			}

			// Token: 0x060040AE RID: 16558 RVA: 0x0001FC68 File Offset: 0x0001DE68
			[Token(Token = "0x60040AE")]
			[Address(RVA = "0x1ED7D28", Offset = "0x1ED7D28", VA = "0x1ED7D28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700080E RID: 2062
			// (get) Token: 0x060040AF RID: 16559 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700080E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60040AF")]
				[Address(RVA = "0x1ED8088", Offset = "0x1ED8088", VA = "0x1ED8088", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060040B0 RID: 16560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040B0")]
			[Address(RVA = "0x1ED8090", Offset = "0x1ED8090", VA = "0x1ED8090", Slot = "8")]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			// Token: 0x1700080F RID: 2063
			// (get) Token: 0x060040B1 RID: 16561 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700080F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60040B1")]
				[Address(RVA = "0x1ED80DC", Offset = "0x1ED80DC", VA = "0x1ED80DC", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04004E84 RID: 20100
			[Token(Token = "0x4004E84")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x04004E85 RID: 20101
			[Token(Token = "0x4004E85")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x04004E86 RID: 20102
			[Token(Token = "0x4004E86")]
			[FieldOffset(Offset = "0x10")]
			public AssetRequestMode mode;
		}

		// Token: 0x02000692 RID: 1682
		[Token(Token = "0x2000692")]
		private sealed class <LoadTextures_InSteps>d__11 : FileAPI, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x060040B2 RID: 16562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040B2")]
			[Address(RVA = "0x1ED80E4", Offset = "0x1ED80E4", VA = "0x1ED80E4")]
			public <LoadTextures_InSteps>d__11(int <>1__state)
			{
			}

			// Token: 0x060040B3 RID: 16563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040B3")]
			[Address(RVA = "0x1ED8100", Offset = "0x1ED8100", VA = "0x1ED8100", Slot = "5")]
			private void System.IDisposable.Dispose()
			{
			}

			// Token: 0x060040B4 RID: 16564 RVA: 0x0001FC80 File Offset: 0x0001DE80
			[Token(Token = "0x60040B4")]
			[Address(RVA = "0x1ED8104", Offset = "0x1ED8104", VA = "0x1ED8104", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000810 RID: 2064
			// (get) Token: 0x060040B5 RID: 16565 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000810")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60040B5")]
				[Address(RVA = "0x1EE3698", Offset = "0x1EE3698", VA = "0x1EE3698", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060040B6 RID: 16566 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040B6")]
			[Address(RVA = "0x1EE36A0", Offset = "0x1EE36A0", VA = "0x1EE36A0", Slot = "8")]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			// Token: 0x17000811 RID: 2065
			// (get) Token: 0x060040B7 RID: 16567 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000811")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60040B7")]
				[Address(RVA = "0x1EE36EC", Offset = "0x1EE36EC", VA = "0x1EE36EC", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04004E87 RID: 20103
			[Token(Token = "0x4004E87")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x04004E88 RID: 20104
			[Token(Token = "0x4004E88")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x04004E89 RID: 20105
			[Token(Token = "0x4004E89")]
			[FieldOffset(Offset = "0x10")]
			public AssetRequestMode mode;
		}

		// Token: 0x02000693 RID: 1683
		[Token(Token = "0x2000693")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x060040B8 RID: 16568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040B8")]
			[Address(RVA = "0x1EE36F4", Offset = "0x1EE36F4", VA = "0x1EE36F4")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x060040B9 RID: 16569 RVA: 0x0001FC98 File Offset: 0x0001DE98
			[Token(Token = "0x60040B9")]
			[Address(RVA = "0x1EE36FC", Offset = "0x1EE36FC", VA = "0x1EE36FC")]
			internal bool <LoadMinimapFrames>b__0(KeyValuePair<string, MinimapFrame> pair)
			{
				return default(bool);
			}

			// Token: 0x04004E8A RID: 20106
			[Token(Token = "0x4004E8A")]
			[FieldOffset(Offset = "0x8")]
			public string frameName;
		}

		// Token: 0x02000694 RID: 1684
		[Token(Token = "0x2000694")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060040BB RID: 16571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040BB")]
			[Address(RVA = "0x1EE37C0", Offset = "0x1EE37C0", VA = "0x1EE37C0")]
			public <>c()
			{
			}

			// Token: 0x060040BC RID: 16572 RVA: 0x0001FCB0 File Offset: 0x0001DEB0
			[Token(Token = "0x60040BC")]
			[Address(RVA = "0x1EE37C8", Offset = "0x1EE37C8", VA = "0x1EE37C8")]
			internal bool <Configuration_OnSave_MinimapFrame>b__14_0(KeyValuePair<string, MinimapFrame> pair)
			{
				return default(bool);
			}

			// Token: 0x060040BD RID: 16573 RVA: 0x0001FCC8 File Offset: 0x0001DEC8
			[Token(Token = "0x60040BD")]
			[Address(RVA = "0x1EE3848", Offset = "0x1EE3848", VA = "0x1EE3848")]
			internal bool <Configuration_OnSave_PlayerResourcesSet>b__17_0(KeyValuePair<string, IPlayerResourcesDisplaySet> pair)
			{
				return default(bool);
			}

			// Token: 0x04004E8B RID: 20107
			[Token(Token = "0x4004E8B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly AssetInitializer.<>c <>9;

			// Token: 0x04004E8C RID: 20108
			[Token(Token = "0x4004E8C")]
			[FieldOffset(Offset = "0x4")]
			public static Func<KeyValuePair<string, MinimapFrame>, bool> <>9__14_0;

			// Token: 0x04004E8D RID: 20109
			[Token(Token = "0x4004E8D")]
			[FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, IPlayerResourcesDisplaySet>, bool> <>9__17_0;
		}

		// Token: 0x02000695 RID: 1685
		[Token(Token = "0x2000695")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x060040BE RID: 16574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040BE")]
			[Address(RVA = "0x1EE38C8", Offset = "0x1EE38C8", VA = "0x1EE38C8")]
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x060040BF RID: 16575 RVA: 0x0001FCE0 File Offset: 0x0001DEE0
			[Token(Token = "0x60040BF")]
			[Address(RVA = "0x1EE38D0", Offset = "0x1EE38D0", VA = "0x1EE38D0")]
			internal bool <LoadPlayerResourceSets>b__0(KeyValuePair<string, IPlayerResourcesDisplaySet> pair)
			{
				return default(bool);
			}

			// Token: 0x04004E8E RID: 20110
			[Token(Token = "0x4004E8E")]
			[FieldOffset(Offset = "0x8")]
			public string frameName;
		}
	}
}
