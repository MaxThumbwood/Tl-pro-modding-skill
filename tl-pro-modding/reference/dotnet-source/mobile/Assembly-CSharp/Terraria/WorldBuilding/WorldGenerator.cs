using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria.WorldBuilding
{
	// Token: 0x020005BC RID: 1468
	[Token(Token = "0x20005BC")]
	public class WorldGenerator
	{
		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06003B41 RID: 15169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000776")]
		public static List<GenPassResult> PassResults
		{
			[Token(Token = "0x6003B41")]
			[Address(RVA = "0x1E0EB4C", Offset = "0x1E0EB4C", VA = "0x1E0EB4C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B42")]
		[Address(RVA = "0x1E0EBC8", Offset = "0x1E0EBC8", VA = "0x1E0EBC8")]
		public WorldGenerator(int seed, WorldGenConfiguration configuration, [Optional] GenerationProgress progress, [Optional] WorldGenerator.Controller controller)
		{
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B43")]
		[Address(RVA = "0x1E0EDE8", Offset = "0x1E0EDE8", VA = "0x1E0EDE8")]
		public void Append(GenPass pass)
		{
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x0001DD78 File Offset: 0x0001BF78
		[Token(Token = "0x6003B44")]
		[Address(RVA = "0x1E0EEA4", Offset = "0x1E0EEA4", VA = "0x1E0EEA4")]
		public bool GenerateWorld()
		{
			return default(bool);
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B45")]
		[Address(RVA = "0x1E0FAE8", Offset = "0x1E0FAE8", VA = "0x1E0FAE8")]
		private GenPassResult RunPass(GenPass pass)
		{
			return null;
		}

		// Token: 0x04004707 RID: 18183
		[Token(Token = "0x4004707")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal readonly List<GenPass> _passes;

		// Token: 0x04004708 RID: 18184
		[Token(Token = "0x4004708")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly int _seed;

		// Token: 0x04004709 RID: 18185
		[Token(Token = "0x4004709")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly WorldGenConfiguration _configuration;

		// Token: 0x0400470A RID: 18186
		[Token(Token = "0x400470A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private readonly GenerationProgress _progress;

		// Token: 0x0400470B RID: 18187
		[Token(Token = "0x400470B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly WorldGenerator.Controller _controller;

		// Token: 0x0400470C RID: 18188
		[Token(Token = "0x400470C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly object _controlLock;

		// Token: 0x0400470D RID: 18189
		[Token(Token = "0x400470D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GenPass _currentPass;

		// Token: 0x0400470E RID: 18190
		[Token(Token = "0x400470E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static GenerationProgress CurrentGenerationProgress;

		// Token: 0x0400470F RID: 18191
		[Token(Token = "0x400470F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static WorldGenerator.Controller CurrentController;

		// Token: 0x04004710 RID: 18192
		[Token(Token = "0x4004710")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool TerminateWorldGen;

		// Token: 0x020005BD RID: 1469
		[Token(Token = "0x20005BD")]
		public enum SnapshotFrequency
		{
			// Token: 0x04004712 RID: 18194
			[Token(Token = "0x4004712")]
			None = -1,
			// Token: 0x04004713 RID: 18195
			[Token(Token = "0x4004713")]
			Manual,
			// Token: 0x04004714 RID: 18196
			[Token(Token = "0x4004714")]
			Automatic,
			// Token: 0x04004715 RID: 18197
			[Token(Token = "0x4004715")]
			Always
		}

		// Token: 0x020005BE RID: 1470
		[Token(Token = "0x20005BE")]
		public class Controller
		{
			// Token: 0x17000777 RID: 1911
			// (get) Token: 0x06003B46 RID: 15174 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000777")]
			public List<GenPass> Passes
			{
				[Token(Token = "0x6003B46")]
				[Address(RVA = "0x1E0FED0", Offset = "0x1E0FED0", VA = "0x1E0FED0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000778 RID: 1912
			// (get) Token: 0x06003B47 RID: 15175 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000778")]
			public GenPass CurrentPass
			{
				[Token(Token = "0x6003B47")]
				[Address(RVA = "0x1E0FEF4", Offset = "0x1E0FEF4", VA = "0x1E0FEF4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000779 RID: 1913
			// (get) Token: 0x06003B48 RID: 15176 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000779")]
			public GenPass LastCompletedPass
			{
				[Token(Token = "0x6003B48")]
				[Address(RVA = "0x1E0FF18", Offset = "0x1E0FF18", VA = "0x1E0FF18")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700077A RID: 1914
			// (get) Token: 0x06003B49 RID: 15177 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003B4A RID: 15178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700077A")]
			public GenPass PauseAfterPass
			{
				[Token(Token = "0x6003B49")]
				[Address(RVA = "0x1E10090", Offset = "0x1E10090", VA = "0x1E10090")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003B4A")]
				[Address(RVA = "0x1E10098", Offset = "0x1E10098", VA = "0x1E10098")]
				set
				{
				}
			}

			// Token: 0x1700077B RID: 1915
			// (get) Token: 0x06003B4B RID: 15179 RVA: 0x0001DD90 File Offset: 0x0001BF90
			// (set) Token: 0x06003B4C RID: 15180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700077B")]
			public bool PauseOnHashMismatch
			{
				[Token(Token = "0x6003B4B")]
				[Address(RVA = "0x1E100A0", Offset = "0x1E100A0", VA = "0x1E100A0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003B4C")]
				[Address(RVA = "0x1E100A8", Offset = "0x1E100A8", VA = "0x1E100A8")]
				set
				{
				}
			}

			// Token: 0x1700077C RID: 1916
			// (get) Token: 0x06003B4D RID: 15181 RVA: 0x0001DDA8 File Offset: 0x0001BFA8
			// (set) Token: 0x06003B4E RID: 15182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700077C")]
			public bool PausedDueToHashMismatch
			{
				[Token(Token = "0x6003B4D")]
				[Address(RVA = "0x1E100B0", Offset = "0x1E100B0", VA = "0x1E100B0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003B4E")]
				[Address(RVA = "0x1E100B8", Offset = "0x1E100B8", VA = "0x1E100B8")]
				set
				{
				}
			}

			// Token: 0x1700077D RID: 1917
			// (get) Token: 0x06003B4F RID: 15183 RVA: 0x0001DDC0 File Offset: 0x0001BFC0
			// (set) Token: 0x06003B50 RID: 15184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700077D")]
			public WorldGenerator.SnapshotFrequency SnapshotFrequency
			{
				[Token(Token = "0x6003B4F")]
				[Address(RVA = "0x1E100C0", Offset = "0x1E100C0", VA = "0x1E100C0")]
				get
				{
					return WorldGenerator.SnapshotFrequency.Manual;
				}
				[Token(Token = "0x6003B50")]
				[Address(RVA = "0x1E100C8", Offset = "0x1E100C8", VA = "0x1E100C8")]
				set
				{
				}
			}

			// Token: 0x1700077E RID: 1918
			// (get) Token: 0x06003B51 RID: 15185 RVA: 0x0001DDD8 File Offset: 0x0001BFD8
			// (set) Token: 0x06003B52 RID: 15186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700077E")]
			public bool Paused
			{
				[Token(Token = "0x6003B51")]
				[Address(RVA = "0x1E100D0", Offset = "0x1E100D0", VA = "0x1E100D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003B52")]
				[Address(RVA = "0x1E100D8", Offset = "0x1E100D8", VA = "0x1E100D8")]
				set
				{
				}
			}

			// Token: 0x1700077F RID: 1919
			// (get) Token: 0x06003B53 RID: 15187 RVA: 0x0001DDF0 File Offset: 0x0001BFF0
			// (set) Token: 0x06003B54 RID: 15188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700077F")]
			public bool QueuedAbort
			{
				[Token(Token = "0x6003B53")]
				[Address(RVA = "0x1E100F0", Offset = "0x1E100F0", VA = "0x1E100F0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003B54")]
				[Address(RVA = "0x1E100F8", Offset = "0x1E100F8", VA = "0x1E100F8")]
				set
				{
				}
			}

			// Token: 0x06003B55 RID: 15189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B55")]
			[Address(RVA = "0x1E0EDC4", Offset = "0x1E0EDC4", VA = "0x1E0EDC4")]
			public Controller([Optional] WorldManifest prevManifest)
			{
			}

			// Token: 0x06003B56 RID: 15190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B56")]
			[Address(RVA = "0x1E0FAC0", Offset = "0x1E0FAC0", VA = "0x1E0FAC0")]
			internal void SetGenerator(WorldGenerator generator)
			{
			}

			// Token: 0x06003B57 RID: 15191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B57")]
			[Address(RVA = "0x1E0FEC8", Offset = "0x1E0FEC8", VA = "0x1E0FEC8")]
			internal void OnPassCompleted()
			{
			}

			// Token: 0x06003B58 RID: 15192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B58")]
			[Address(RVA = "0x1E0FECC", Offset = "0x1E0FECC", VA = "0x1E0FECC")]
			internal void ReportException(string message, [Optional] Exception ex, bool pause = true)
			{
			}

			// Token: 0x04004716 RID: 18198
			[Token(Token = "0x4004716")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Action<WorldGenerator.Controller> OnPassesLoaded;

			// Token: 0x04004717 RID: 18199
			[Token(Token = "0x4004717")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private WorldGenerator _generator;

			// Token: 0x04004718 RID: 18200
			[Token(Token = "0x4004718")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private GenPass <PauseAfterPass>k__BackingField;

			// Token: 0x04004719 RID: 18201
			[Token(Token = "0x4004719")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool <PauseOnHashMismatch>k__BackingField;

			// Token: 0x0400471A RID: 18202
			[Token(Token = "0x400471A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			private bool <PausedDueToHashMismatch>k__BackingField;

			// Token: 0x0400471B RID: 18203
			[Token(Token = "0x400471B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private WorldGenerator.SnapshotFrequency <SnapshotFrequency>k__BackingField;

			// Token: 0x0400471C RID: 18204
			[Token(Token = "0x400471C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private bool _paused;

			// Token: 0x0400471D RID: 18205
			[Token(Token = "0x400471D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
			private bool <QueuedAbort>k__BackingField;
		}

		// Token: 0x020005BF RID: 1471
		[Token(Token = "0x20005BF")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003B5A RID: 15194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B5A")]
			[Address(RVA = "0x1E10174", Offset = "0x1E10174", VA = "0x1E10174")]
			public <>c()
			{
			}

			// Token: 0x06003B5B RID: 15195 RVA: 0x0001DE08 File Offset: 0x0001C008
			[Token(Token = "0x6003B5B")]
			[Address(RVA = "0x1E1017C", Offset = "0x1E1017C", VA = "0x1E1017C")]
			internal bool <GenerateWorld>b__14_0(GenPass p)
			{
				return default(bool);
			}

			// Token: 0x06003B5C RID: 15196 RVA: 0x0001DE20 File Offset: 0x0001C020
			[Token(Token = "0x6003B5C")]
			[Address(RVA = "0x1E101A0", Offset = "0x1E101A0", VA = "0x1E101A0")]
			internal double <GenerateWorld>b__14_1(GenPass p)
			{
				return 0.0;
			}

			// Token: 0x06003B5D RID: 15197 RVA: 0x0001DE38 File Offset: 0x0001C038
			[Token(Token = "0x6003B5D")]
			[Address(RVA = "0x1E101C0", Offset = "0x1E101C0", VA = "0x1E101C0")]
			internal int <GenerateWorld>b__14_2(GenPassResult r)
			{
				return 0;
			}

			// Token: 0x0400471E RID: 18206
			[Token(Token = "0x400471E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly WorldGenerator.<>c <>9;

			// Token: 0x0400471F RID: 18207
			[Token(Token = "0x400471F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<GenPass, bool> <>9__14_0;

			// Token: 0x04004720 RID: 18208
			[Token(Token = "0x4004720")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<GenPass, double> <>9__14_1;

			// Token: 0x04004721 RID: 18209
			[Token(Token = "0x4004721")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static Func<GenPassResult, int> <>9__14_2;
		}
	}
}
