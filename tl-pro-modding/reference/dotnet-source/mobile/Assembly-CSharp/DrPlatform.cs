using System;
using System.Collections.Concurrent;
using System.Threading;
using Il2CppDummyDll;
using Terraria.Chat;
using UnityEngine;

// Token: 0x02000031 RID: 49
[Token(Token = "0x2000031")]
public class DrPlatform
{
	// Token: 0x1700004B RID: 75
	// (get) Token: 0x060000FB RID: 251 RVA: 0x00002790 File Offset: 0x00000990
	[Token(Token = "0x1700004B")]
	public static bool IsChromebook
	{
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x4A0650", Offset = "0x4A0650", VA = "0x4A0650")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060000FC RID: 252 RVA: 0x000027A8 File Offset: 0x000009A8
	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x4A1060", Offset = "0x4A1060", VA = "0x4A1060")]
	public static bool IsRunningVisionOS()
	{
		return default(bool);
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x060000FD RID: 253 RVA: 0x000027C0 File Offset: 0x000009C0
	[Token(Token = "0x1700004C")]
	public static DrPlatform.DrPlatformType CurrentPlatform
	{
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x49C048", Offset = "0x49C048", VA = "0x49C048")]
		get
		{
			return DrPlatform.DrPlatformType.None;
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x060000FE RID: 254 RVA: 0x000027D8 File Offset: 0x000009D8
	[Token(Token = "0x1700004D")]
	public static DrPlatform.DrSKUType CurrentSKU
	{
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x4A1068", Offset = "0x4A1068", VA = "0x4A1068")]
		get
		{
			return DrPlatform.DrSKUType.UNKNOWN;
		}
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x4A1070", Offset = "0x4A1070", VA = "0x4A1070")]
	public static void OpenStoreURL()
	{
	}

	// Token: 0x06000100 RID: 256 RVA: 0x000027F0 File Offset: 0x000009F0
	[Token(Token = "0x6000100")]
	[Address(RVA = "0x49D3D4", Offset = "0x49D3D4", VA = "0x49D3D4")]
	public static bool IsCurrentPlatform(DrPlatform.DrPlatformType platform)
	{
		return default(bool);
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00002808 File Offset: 0x00000A08
	[Token(Token = "0x6000101")]
	[Address(RVA = "0x4A1150", Offset = "0x4A1150", VA = "0x4A1150")]
	public static bool PlatformMatches(DrPlatform.DrPlatformType platformCompare1, DrPlatform.DrPlatformType platformCompare2)
	{
		return default(bool);
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000102")]
	[Address(RVA = "0x4A115C", Offset = "0x4A115C", VA = "0x4A115C")]
	public static void Update(float elapsedTime)
	{
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000103 RID: 259 RVA: 0x00002820 File Offset: 0x00000A20
	[Token(Token = "0x1700004E")]
	public static bool IsMainThread
	{
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x4A1518", Offset = "0x4A1518", VA = "0x4A1518")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000104")]
	[Address(RVA = "0x4A157C", Offset = "0x4A157C", VA = "0x4A157C")]
	public static void Setup()
	{
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000105")]
	[Address(RVA = "0x4A1600", Offset = "0x4A1600", VA = "0x4A1600")]
	public static void Start()
	{
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x4A165C", Offset = "0x4A165C", VA = "0x4A165C")]
	public static void StartSession()
	{
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x4A16D4", Offset = "0x4A16D4", VA = "0x4A16D4")]
	private static void SetConnectionDown(bool connectionDown)
	{
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000108")]
	[Address(RVA = "0x4A1658", Offset = "0x4A1658", VA = "0x4A1658")]
	private static void SetVSyncCount()
	{
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06000109 RID: 265 RVA: 0x00002838 File Offset: 0x00000A38
	[Token(Token = "0x1700004F")]
	public static bool IsUIHighlightEnabled
	{
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x4A1728", Offset = "0x4A1728", VA = "0x4A1728")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000050")]
	public static string InstallSource
	{
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x4A1730", Offset = "0x4A1730", VA = "0x4A1730")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010B")]
	[Address(RVA = "0x4A1B80", Offset = "0x4A1B80", VA = "0x4A1B80")]
	public DrPlatform()
	{
	}

	// Token: 0x04000305 RID: 773
	[Token(Token = "0x4000305")]
	[FieldOffset(Offset = "0x0")]
	private static bool? isChromebook;

	// Token: 0x04000306 RID: 774
	[Token(Token = "0x4000306")]
	[FieldOffset(Offset = "0x4")]
	public static Thread MainThread;

	// Token: 0x04000307 RID: 775
	[Token(Token = "0x4000307")]
	[FieldOffset(Offset = "0x8")]
	public static string DeviceModel;

	// Token: 0x04000308 RID: 776
	[Token(Token = "0x4000308")]
	[FieldOffset(Offset = "0xC")]
	public static bool ConnectionDown;

	// Token: 0x04000309 RID: 777
	[Token(Token = "0x4000309")]
	[FieldOffset(Offset = "0x10")]
	public static Guid SessionId;

	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public class Android
	{
		// Token: 0x0600010C RID: 268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x4A15F4", Offset = "0x4A15F4", VA = "0x4A15F4")]
		public static void Setup()
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x4A139C", Offset = "0x4A139C", VA = "0x4A139C")]
		public static void Update()
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		public static string InstallSource
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x4A17A0", Offset = "0x4A17A0", VA = "0x4A17A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x4A1B88", Offset = "0x4A1B88", VA = "0x4A1B88")]
		public Android()
		{
		}

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x2000033")]
		public class User
		{
			// Token: 0x17000052 RID: 82
			// (get) Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000052")]
			public static string UserUID
			{
				[Token(Token = "0x6000110")]
				[Address(RVA = "0x4A1B90", Offset = "0x4A1B90", VA = "0x4A1B90")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000053")]
			public static string GamerTag
			{
				[Token(Token = "0x6000111")]
				[Address(RVA = "0x4A1C38", Offset = "0x4A1C38", VA = "0x4A1C38")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000112 RID: 274 RVA: 0x00002850 File Offset: 0x00000A50
			[Token(Token = "0x17000054")]
			public static DrPlatform.Android.User.LoginState CurrentLoginState
			{
				[Token(Token = "0x6000112")]
				[Address(RVA = "0x4A1CE0", Offset = "0x4A1CE0", VA = "0x4A1CE0")]
				get
				{
					return DrPlatform.Android.User.LoginState.Waiting;
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000055")]
			public static string AccountProfileURL
			{
				[Token(Token = "0x6000113")]
				[Address(RVA = "0x4A1D44", Offset = "0x4A1D44", VA = "0x4A1D44")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000114 RID: 276 RVA: 0x00002868 File Offset: 0x00000A68
			[Token(Token = "0x17000056")]
			public static bool SigningIn
			{
				[Token(Token = "0x6000114")]
				[Address(RVA = "0x4A1DEC", Offset = "0x4A1DEC", VA = "0x4A1DEC")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000115 RID: 277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x4A1E50", Offset = "0x4A1E50", VA = "0x4A1E50")]
			public static void RequestLogin()
			{
			}

			// Token: 0x06000116 RID: 278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x4A1EFC", Offset = "0x4A1EFC", VA = "0x4A1EFC")]
			public static void Logout()
			{
			}

			// Token: 0x06000117 RID: 279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x4A1FAC", Offset = "0x4A1FAC", VA = "0x4A1FAC")]
			public User()
			{
			}

			// Token: 0x02000034 RID: 52
			[Token(Token = "0x2000034")]
			public enum LoginState
			{
				// Token: 0x0400030B RID: 779
				[Token(Token = "0x400030B")]
				Waiting,
				// Token: 0x0400030C RID: 780
				[Token(Token = "0x400030C")]
				LoggingIn,
				// Token: 0x0400030D RID: 781
				[Token(Token = "0x400030D")]
				LoggedIn,
				// Token: 0x0400030E RID: 782
				[Token(Token = "0x400030E")]
				FromCache,
				// Token: 0x0400030F RID: 783
				[Token(Token = "0x400030F")]
				LoggedOut
			}
		}
	}

	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	public enum DrPlatformType
	{
		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		None,
		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		PC,
		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		Google,
		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		iOS = 4,
		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		Amazon = 8,
		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		Steam = 16,
		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		PS4 = 32,
		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		Yahoo = 64,
		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		XBOXONE = 128,
		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		Stadia = 256,
		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		Switch = 512,
		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		AppleArcade = 1024,
		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		Mobile = 14,
		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		Console = 672,
		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		All = 65535
	}

	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	public enum DrSKUType
	{
		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		UNKNOWN,
		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		SCEE,
		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		SCEA,
		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		SCEASIA
	}

	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	public static class User
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x17000057")]
		public static bool PermissionsFetchFailed
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x4A1FB4", Offset = "0x4A1FB4", VA = "0x4A1FB4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x17000058")]
		public static bool HasUserGeneratedContentPermissions
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x4A2058", Offset = "0x4A2058", VA = "0x4A2058")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x17000059")]
		public static bool HasChatPermissions
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x4A235C", Offset = "0x4A235C", VA = "0x4A235C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x4A1400", Offset = "0x4A1400", VA = "0x4A1400")]
		public static void UpdateChatRequests()
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x4A25A8", Offset = "0x4A25A8", VA = "0x4A25A8")]
		public static void FilterText(string inputText, Action<string> callback)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x4A26E8", Offset = "0x4A26E8", VA = "0x4A26E8")]
		private static void PlatformCheckCanChatThread()
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x4A2878", Offset = "0x4A2878", VA = "0x4A2878")]
		public static void CanChatWith(ChatHelper.ChatRequest request)
		{
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600011F RID: 287 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x1700005A")]
		public static bool IsAgeRestricted
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x4A2B24", Offset = "0x4A2B24", VA = "0x4A2B24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x1700005B")]
		public static bool IsPatchRequired
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x4A2BB8", Offset = "0x4A2BB8", VA = "0x4A2BB8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000121 RID: 289 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x1700005C")]
		public static bool HasMultiplayerPermissions
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x4A2C4C", Offset = "0x4A2C4C", VA = "0x4A2C4C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x4A030C", Offset = "0x4A030C", VA = "0x4A030C")]
		public static void OnPlatformUserChanged()
		{
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000123 RID: 291 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000124 RID: 292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000002")]
		public static event Action PlatformUserChanged
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x4A2E4C", Offset = "0x4A2E4C", VA = "0x4A2E4C")]
			add
			{
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x4A2F50", Offset = "0x4A2F50", VA = "0x4A2F50")]
			remove
			{
			}
		}

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x0")]
		private static ConcurrentQueue<ChatHelper.ChatRequest> PendingChatRequests;

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x4")]
		private static ManualResetEvent chatCheckPending;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x8")]
		private static ConcurrentQueue<ChatHelper.ChatRequest> CompletedChatRequests;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0xC")]
		private static ManagedThread PlatformCheckThread;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x10")]
		private static object fiitlerOpLock;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x14")]
		private static AutoResetEvent fliterOpCompleteEvent;
	}

	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public class IOS
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005D")]
		public static iOS_Mouse Mouse
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x4A321C", Offset = "0x4A321C", VA = "0x4A321C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x4A1398", Offset = "0x4A1398", VA = "0x4A1398")]
		public static void Update()
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x4A330C", Offset = "0x4A330C", VA = "0x4A330C")]
		public static void Setup()
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005E")]
		public static string AppID
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x4A1108", Offset = "0x4A1108", VA = "0x4A1108")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x4A3318", Offset = "0x4A3318", VA = "0x4A3318")]
		public static void UpdateMouse()
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x4A343C", Offset = "0x4A343C", VA = "0x4A343C")]
		public IOS()
		{
		}

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x0")]
		private static iOS_Mouse _mouse;
	}

	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	public class PS4
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x4A3444", Offset = "0x4A3444", VA = "0x4A3444")]
		public static void UpdateMouse()
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x4A347C", Offset = "0x4A347C", VA = "0x4A347C")]
		public static void Update(bool updateFocus = false)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x4A3480", Offset = "0x4A3480", VA = "0x4A3480")]
		public static void Setup()
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x4A350C", Offset = "0x4A350C", VA = "0x4A350C")]
		public static void StartSession()
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x4A3510", Offset = "0x4A3510", VA = "0x4A3510")]
		public static void Start()
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x4A3514", Offset = "0x4A3514", VA = "0x4A3514")]
		public static void NotfityMultiplayerRealTimeUsage()
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x4A3690", Offset = "0x4A3690", VA = "0x4A3690")]
		public PS4()
		{
		}

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		private const float SOCKET_CLEANUP_TIME = 1f;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x0")]
		private static bool _setup;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x1")]
		private static bool _hasFocus;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x4")]
		private static float _socketsTimer;

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x8")]
		private static DateTime _lastMPNofityMessage;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x10")]
		public static bool DisablePlatformChecks;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x11")]
		private static bool wasMouseConnected;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x14")]
		public static Vector3 lastUnityMousePosition;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x20")]
		public static Vector3 MousePosition;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x2C")]
		public static bool MouseButton0;

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x2D")]
		public static bool MouseButton1;

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x2E")]
		public static bool MouseButton2;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x2F")]
		public static bool MouseButtonPrev0;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x30")]
		public static bool MouseButtonPrev1;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x31")]
		public static bool MouseButtonPrev2;

		// Token: 0x0200003A RID: 58
		[Token(Token = "0x200003A")]
		public class User
		{
			// Token: 0x06000134 RID: 308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x4A3750", Offset = "0x4A3750", VA = "0x4A3750")]
			public static void ShowProfile(string playerId)
			{
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000135 RID: 309 RVA: 0x00002910 File Offset: 0x00000B10
			[Token(Token = "0x1700005F")]
			public static bool PermissionsFetchFailed
			{
				[Token(Token = "0x6000135")]
				[Address(RVA = "0x4A1FBC", Offset = "0x4A1FBC", VA = "0x4A1FBC")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000136 RID: 310 RVA: 0x00002928 File Offset: 0x00000B28
			[Token(Token = "0x17000060")]
			public static bool IsPatchRequired
			{
				[Token(Token = "0x6000136")]
				[Address(RVA = "0x4A2BC0", Offset = "0x4A2BC0", VA = "0x4A2BC0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000137 RID: 311 RVA: 0x00002940 File Offset: 0x00000B40
			[Token(Token = "0x17000061")]
			public static bool IsAgeRestricted
			{
				[Token(Token = "0x6000137")]
				[Address(RVA = "0x4A2B2C", Offset = "0x4A2B2C", VA = "0x4A2B2C")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000138 RID: 312 RVA: 0x00002958 File Offset: 0x00000B58
			[Token(Token = "0x17000062")]
			public static bool HasUserGeneratedContentPermissions
			{
				[Token(Token = "0x6000138")]
				[Address(RVA = "0x4A22C0", Offset = "0x4A22C0", VA = "0x4A22C0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000139 RID: 313 RVA: 0x00002970 File Offset: 0x00000B70
			[Token(Token = "0x17000063")]
			public static bool HasChatPermissions
			{
				[Token(Token = "0x6000139")]
				[Address(RVA = "0x4A3790", Offset = "0x4A3790", VA = "0x4A3790")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000064")]
			public static string UserUID
			{
				[Token(Token = "0x600013A")]
				[Address(RVA = "0x4A3824", Offset = "0x4A3824", VA = "0x4A3824")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000065")]
			public static string GamerTag
			{
				[Token(Token = "0x600013B")]
				[Address(RVA = "0x4A3874", Offset = "0x4A3874", VA = "0x4A3874")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600013C RID: 316 RVA: 0x00002988 File Offset: 0x00000B88
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x4A38C4", Offset = "0x4A38C4", VA = "0x4A38C4")]
			public static bool CanViewPlayerOnline(string playerId)
			{
				return default(bool);
			}

			// Token: 0x0600013D RID: 317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x4A38CC", Offset = "0x4A38CC", VA = "0x4A38CC")]
			public static void Start()
			{
			}

			// Token: 0x0600013E RID: 318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x4A38D0", Offset = "0x4A38D0", VA = "0x4A38D0")]
			public static void ResetPermissions()
			{
			}

			// Token: 0x0600013F RID: 319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x4A3758", Offset = "0x4A3758", VA = "0x4A3758")]
			private static void SetupPermissions()
			{
			}

			// Token: 0x06000140 RID: 320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x4A3924", Offset = "0x4A3924", VA = "0x4A3924")]
			public User()
			{
			}

			// Token: 0x0400033C RID: 828
			[Token(Token = "0x400033C")]
			[FieldOffset(Offset = "0x0")]
			public static int PrimaryUserID;

			// Token: 0x0400033D RID: 829
			[Token(Token = "0x400033D")]
			[FieldOffset(Offset = "0x4")]
			private static bool UGCRestriction;

			// Token: 0x0400033E RID: 830
			[Token(Token = "0x400033E")]
			[FieldOffset(Offset = "0x5")]
			private static bool ChatRestriction;

			// Token: 0x0400033F RID: 831
			[Token(Token = "0x400033F")]
			[FieldOffset(Offset = "0x6")]
			private static bool PatchRequired;

			// Token: 0x04000340 RID: 832
			[Token(Token = "0x4000340")]
			[FieldOffset(Offset = "0x7")]
			private static bool AgeRestricted;

			// Token: 0x04000341 RID: 833
			[Token(Token = "0x4000341")]
			[FieldOffset(Offset = "0x8")]
			private static bool MultiplayerRestricted;

			// Token: 0x04000342 RID: 834
			[Token(Token = "0x4000342")]
			[FieldOffset(Offset = "0x9")]
			private static bool SetupUserPermissions;
		}
	}

	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public class Switch
	{
		// Token: 0x06000141 RID: 321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x4A392C", Offset = "0x4A392C", VA = "0x4A392C")]
		public static void Setup()
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x4A3A84", Offset = "0x4A3A84", VA = "0x4A3A84")]
		public static void Start()
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x4A3A88", Offset = "0x4A3A88", VA = "0x4A3A88")]
		public static void Update()
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x17000066")]
		public static bool Docked
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x4A3A8C", Offset = "0x4A3A8C", VA = "0x4A3A8C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x4A3AF4", Offset = "0x4A3AF4", VA = "0x4A3AF4")]
		private static void SetCpuBoostMode(object data)
		{
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000146 RID: 326 RVA: 0x000029B8 File Offset: 0x00000BB8
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000067")]
		public static bool CPUBoostMode
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x4A3BE4", Offset = "0x4A3BE4", VA = "0x4A3BE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x4A3988", Offset = "0x4A3988", VA = "0x4A3988")]
			set
			{
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x4A407C", Offset = "0x4A407C", VA = "0x4A407C")]
		public static void ShowProfile(PlatformUser user)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x4A4080", Offset = "0x4A4080", VA = "0x4A4080")]
		public static void FilterText(ref string value)
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x4A4084", Offset = "0x4A4084", VA = "0x4A4084")]
		public Switch()
		{
		}

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0x0")]
		private static bool cpuBoost;
	}

	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	public class XBO
	{
		// Token: 0x0600014B RID: 331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x4A408C", Offset = "0x4A408C", VA = "0x4A408C")]
		public static void Update()
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x4A4090", Offset = "0x4A4090", VA = "0x4A4090")]
		public static void Setup()
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x4A40EC", Offset = "0x4A40EC", VA = "0x4A40EC")]
		private static void Suspending()
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x4A42FC", Offset = "0x4A42FC", VA = "0x4A42FC")]
		private static void Resuming(double span)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x4A4300", Offset = "0x4A4300", VA = "0x4A4300")]
		private static void ResourceAvailabilityChangedEvent(bool amConstrained)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x4A4304", Offset = "0x4A4304", VA = "0x4A4304")]
		public static void StartSession()
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x4A4308", Offset = "0x4A4308", VA = "0x4A4308")]
		public static void Start()
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x4A430C", Offset = "0x4A430C", VA = "0x4A430C")]
		public XBO()
		{
		}

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		public const string SCID = "f4f80100-7f03-4df9-8fbd-f0191738ca2a";

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x0")]
		private static bool _setup;

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x200003D")]
		public class User
		{
			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000153 RID: 339 RVA: 0x000029D0 File Offset: 0x00000BD0
			[Token(Token = "0x17000068")]
			public static bool HasMultiplayerPermissions
			{
				[Token(Token = "0x6000153")]
				[Address(RVA = "0x4A4314", Offset = "0x4A4314", VA = "0x4A4314")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000154 RID: 340 RVA: 0x000029E8 File Offset: 0x00000BE8
			[Token(Token = "0x17000069")]
			public static bool HasUserGeneratedContentPermissions
			{
				[Token(Token = "0x6000154")]
				[Address(RVA = "0x4A2354", Offset = "0x4A2354", VA = "0x4A2354")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x06000155 RID: 341 RVA: 0x00002A00 File Offset: 0x00000C00
			[Token(Token = "0x1700006A")]
			public static bool HasChatPermissions
			{
				[Token(Token = "0x6000155")]
				[Address(RVA = "0x4A25A0", Offset = "0x4A25A0", VA = "0x4A25A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x06000156 RID: 342 RVA: 0x00002A18 File Offset: 0x00000C18
			[Token(Token = "0x1700006B")]
			public static bool HasCrossPlayPermission
			{
				[Token(Token = "0x6000156")]
				[Address(RVA = "0x4A431C", Offset = "0x4A431C", VA = "0x4A431C")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700006C")]
			public static string UserUID
			{
				[Token(Token = "0x6000157")]
				[Address(RVA = "0x4A4398", Offset = "0x4A4398", VA = "0x4A4398")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700006D")]
			public static string GamerTag
			{
				[Token(Token = "0x6000158")]
				[Address(RVA = "0x4A43E8", Offset = "0x4A43E8", VA = "0x4A43E8")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000159 RID: 345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x4A43F0", Offset = "0x4A43F0", VA = "0x4A43F0")]
			public static void Start()
			{
			}

			// Token: 0x0600015A RID: 346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x4A43F4", Offset = "0x4A43F4", VA = "0x4A43F4")]
			public static void ShowGamerCard(string xboPlayerId)
			{
			}

			// Token: 0x0600015B RID: 347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x4A43FC", Offset = "0x4A43FC", VA = "0x4A43FC")]
			public User()
			{
			}
		}
	}
}
