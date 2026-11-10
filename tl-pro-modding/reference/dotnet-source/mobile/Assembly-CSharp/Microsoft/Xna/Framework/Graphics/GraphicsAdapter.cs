using System;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003F0 RID: 1008
	[Token(Token = "0x20003F0")]
	public sealed class GraphicsAdapter
	{
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x0000CED0 File Offset: 0x0000B0D0
		// (set) Token: 0x06001B57 RID: 6999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030B")]
		public static int VirtualScreenSize
		{
			[Token(Token = "0x6001B56")]
			[Address(RVA = "0xE7F2F8", Offset = "0xE7F2F8", VA = "0xE7F2F8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B57")]
			[Address(RVA = "0xE7F35C", Offset = "0xE7F35C", VA = "0xE7F35C")]
			set
			{
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030C")]
		public static GraphicsAdapter DefaultAdapter
		{
			[Token(Token = "0x6001B59")]
			[Address(RVA = "0xE7FB14", Offset = "0xE7FB14", VA = "0xE7FB14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030D")]
		public static ReadOnlyCollection<GraphicsAdapter> Adapters
		{
			[Token(Token = "0x6001B5A")]
			[Address(RVA = "0xE7FBB0", Offset = "0xE7FBB0", VA = "0xE7FBB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		// (set) Token: 0x06001B5C RID: 7004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030E")]
		public static bool UseReferenceDevice
		{
			[Token(Token = "0x6001B5B")]
			[Address(RVA = "0xE7FC14", Offset = "0xE7FC14", VA = "0xE7FC14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B5C")]
			[Address(RVA = "0xE7FCC8", Offset = "0xE7FCC8", VA = "0xE7FCC8")]
			set
			{
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x0000CF00 File Offset: 0x0000B100
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030F")]
		public static GraphicsAdapter.DriverType UseDriverType
		{
			[Token(Token = "0x6001B5D")]
			[Address(RVA = "0xE7FD74", Offset = "0xE7FD74", VA = "0xE7FD74")]
			get
			{
				return GraphicsAdapter.DriverType.Hardware;
			}
			[Token(Token = "0x6001B5E")]
			[Address(RVA = "0xE7FDD8", Offset = "0xE7FDD8", VA = "0xE7FDD8")]
			set
			{
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x0000CF18 File Offset: 0x0000B118
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000310")]
		public static bool UseDebugLayers
		{
			[Token(Token = "0x6001B5F")]
			[Address(RVA = "0xE7FE40", Offset = "0xE7FE40", VA = "0xE7FE40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B60")]
			[Address(RVA = "0xE7FEA4", Offset = "0xE7FEA4", VA = "0xE7FEA4")]
			set
			{
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000311")]
		public string Description
		{
			[Token(Token = "0x6001B61")]
			[Address(RVA = "0xE7FF0C", Offset = "0xE7FF0C", VA = "0xE7FF0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B62")]
			[Address(RVA = "0xE7FF14", Offset = "0xE7FF14", VA = "0xE7FF14")]
			private set
			{
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x0000CF30 File Offset: 0x0000B130
		// (set) Token: 0x06001B64 RID: 7012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000312")]
		public int DeviceId
		{
			[Token(Token = "0x6001B63")]
			[Address(RVA = "0xE7FF1C", Offset = "0xE7FF1C", VA = "0xE7FF1C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B64")]
			[Address(RVA = "0xE7FF24", Offset = "0xE7FF24", VA = "0xE7FF24")]
			private set
			{
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B66 RID: 7014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000313")]
		public string DeviceName
		{
			[Token(Token = "0x6001B65")]
			[Address(RVA = "0xE7FF2C", Offset = "0xE7FF2C", VA = "0xE7FF2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B66")]
			[Address(RVA = "0xE7FF34", Offset = "0xE7FF34", VA = "0xE7FF34")]
			private set
			{
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x0000CF48 File Offset: 0x0000B148
		// (set) Token: 0x06001B68 RID: 7016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000314")]
		public int VendorId
		{
			[Token(Token = "0x6001B67")]
			[Address(RVA = "0xE7FF3C", Offset = "0xE7FF3C", VA = "0xE7FF3C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B68")]
			[Address(RVA = "0xE7FF44", Offset = "0xE7FF44", VA = "0xE7FF44")]
			private set
			{
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x0000CF60 File Offset: 0x0000B160
		// (set) Token: 0x06001B6A RID: 7018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000315")]
		public bool IsDefaultAdapter
		{
			[Token(Token = "0x6001B69")]
			[Address(RVA = "0xE7FF4C", Offset = "0xE7FF4C", VA = "0xE7FF4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B6A")]
			[Address(RVA = "0xE7FF54", Offset = "0xE7FF54", VA = "0xE7FF54")]
			private set
			{
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x0000CF78 File Offset: 0x0000B178
		// (set) Token: 0x06001B6C RID: 7020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000316")]
		public IntPtr MonitorHandle
		{
			[Token(Token = "0x6001B6B")]
			[Address(RVA = "0xE7FF5C", Offset = "0xE7FF5C", VA = "0xE7FF5C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B6C")]
			[Address(RVA = "0xE7FF64", Offset = "0xE7FF64", VA = "0xE7FF64")]
			private set
			{
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x0000CF90 File Offset: 0x0000B190
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000317")]
		public int Revision
		{
			[Token(Token = "0x6001B6D")]
			[Address(RVA = "0xE7FF6C", Offset = "0xE7FF6C", VA = "0xE7FF6C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B6E")]
			[Address(RVA = "0xE7FF74", Offset = "0xE7FF74", VA = "0xE7FF74")]
			private set
			{
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		// (set) Token: 0x06001B70 RID: 7024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000318")]
		public int SubSystemId
		{
			[Token(Token = "0x6001B6F")]
			[Address(RVA = "0xE7FF7C", Offset = "0xE7FF7C", VA = "0xE7FF7C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B70")]
			[Address(RVA = "0xE7FF84", Offset = "0xE7FF84", VA = "0xE7FF84")]
			private set
			{
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000319")]
		public DisplayModeCollection SupportedDisplayModes
		{
			[Token(Token = "0x6001B71")]
			[Address(RVA = "0xE7FF8C", Offset = "0xE7FF8C", VA = "0xE7FF8C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700031A")]
		public DisplayMode CurrentDisplayMode
		{
			[Token(Token = "0x6001B72")]
			[Address(RVA = "0xE7FF94", Offset = "0xE7FF94", VA = "0xE7FF94")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		[Token(Token = "0x1700031B")]
		public bool IsWideScreen
		{
			[Token(Token = "0x6001B73")]
			[Address(RVA = "0xE7FF9C", Offset = "0xE7FF9C", VA = "0xE7FF9C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		[Token(Token = "0x6001B74")]
		[Address(RVA = "0xE7FFE0", Offset = "0xE7FFE0", VA = "0xE7FFE0")]
		public bool QueryRenderTargetFormat(GraphicsProfile graphicsProfile, SurfaceFormat format, DepthFormat depthFormat, int multiSampleCount, out SurfaceFormat selectedFormat, out DepthFormat selectedDepthFormat, out int selectedMultiSampleCount)
		{
			return default(bool);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
		[Token(Token = "0x6001B75")]
		[Address(RVA = "0xE80150", Offset = "0xE80150", VA = "0xE80150")]
		public bool IsProfileSupported(GraphicsProfile graphicsProfile)
		{
			return default(bool);
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B76")]
		[Address(RVA = "0xE80158", Offset = "0xE80158", VA = "0xE80158")]
		public void Dispose()
		{
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B77")]
		[Address(RVA = "0xE7F5C8", Offset = "0xE7F5C8", VA = "0xE7F5C8")]
		private static void PlatformInitializeAdapters(out ReadOnlyCollection<GraphicsAdapter> adaptersResults)
		{
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B78")]
		[Address(RVA = "0xE8015C", Offset = "0xE8015C", VA = "0xE8015C")]
		public GraphicsAdapter()
		{
		}

		// Token: 0x04002F53 RID: 12115
		[Token(Token = "0x4002F53")]
		[FieldOffset(Offset = "0x0")]
		private static int _virtualScreenSize;

		// Token: 0x04002F54 RID: 12116
		[Token(Token = "0x4002F54")]
		[FieldOffset(Offset = "0x4")]
		private static readonly ReadOnlyCollection<GraphicsAdapter> _adapters;

		// Token: 0x04002F55 RID: 12117
		[Token(Token = "0x4002F55")]
		[FieldOffset(Offset = "0x8")]
		private DisplayModeCollection _supportedDisplayModes;

		// Token: 0x04002F56 RID: 12118
		[Token(Token = "0x4002F56")]
		[FieldOffset(Offset = "0xC")]
		private DisplayMode _currentDisplayMode;

		// Token: 0x04002F57 RID: 12119
		[Token(Token = "0x4002F57")]
		[FieldOffset(Offset = "0x8")]
		private static GraphicsAdapter.DriverType <UseDriverType>k__BackingField;

		// Token: 0x04002F58 RID: 12120
		[Token(Token = "0x4002F58")]
		[FieldOffset(Offset = "0xC")]
		private static bool <UseDebugLayers>k__BackingField;

		// Token: 0x04002F59 RID: 12121
		[Token(Token = "0x4002F59")]
		[FieldOffset(Offset = "0x10")]
		private string <Description>k__BackingField;

		// Token: 0x04002F5A RID: 12122
		[Token(Token = "0x4002F5A")]
		[FieldOffset(Offset = "0x14")]
		private int <DeviceId>k__BackingField;

		// Token: 0x04002F5B RID: 12123
		[Token(Token = "0x4002F5B")]
		[FieldOffset(Offset = "0x18")]
		private string <DeviceName>k__BackingField;

		// Token: 0x04002F5C RID: 12124
		[Token(Token = "0x4002F5C")]
		[FieldOffset(Offset = "0x1C")]
		private int <VendorId>k__BackingField;

		// Token: 0x04002F5D RID: 12125
		[Token(Token = "0x4002F5D")]
		[FieldOffset(Offset = "0x20")]
		private bool <IsDefaultAdapter>k__BackingField;

		// Token: 0x04002F5E RID: 12126
		[Token(Token = "0x4002F5E")]
		[FieldOffset(Offset = "0x24")]
		private IntPtr <MonitorHandle>k__BackingField;

		// Token: 0x04002F5F RID: 12127
		[Token(Token = "0x4002F5F")]
		[FieldOffset(Offset = "0x28")]
		private int <Revision>k__BackingField;

		// Token: 0x04002F60 RID: 12128
		[Token(Token = "0x4002F60")]
		[FieldOffset(Offset = "0x2C")]
		private int <SubSystemId>k__BackingField;

		// Token: 0x020003F1 RID: 1009
		[Token(Token = "0x20003F1")]
		public enum DriverType
		{
			// Token: 0x04002F62 RID: 12130
			[Token(Token = "0x4002F62")]
			Hardware,
			// Token: 0x04002F63 RID: 12131
			[Token(Token = "0x4002F63")]
			Reference,
			// Token: 0x04002F64 RID: 12132
			[Token(Token = "0x4002F64")]
			FastSoftware
		}
	}
}
