using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ReLogic.Content;
using ReLogic.Graphics;
using Terraria.Achievements;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Ambience;
using Terraria.GameContent.Animations;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.FishDropRules;
using Terraria.GameContent.Golf;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.UI;
using Terraria.GameContent.UI.BigProgressBar;
using Terraria.GameContent.UI.Chat;
using Terraria.GameContent.UI.Minimap;
using Terraria.GameContent.UI.ResourceSets;
using Terraria.Graphics;
using Terraria.Graphics.CameraModifiers;
using Terraria.Graphics.Light;
using Terraria.Graphics.Renderers;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Map;
using Terraria.Net;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria
{
	// Token: 0x0200046D RID: 1133
	[Token(Token = "0x200046D")]
	public class Main : Game
	{
		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x0000F648 File Offset: 0x0000D848
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E6")]
		public static bool flushLighting
		{
			[Token(Token = "0x6002006")]
			[Address(RVA = "0x10060B0", Offset = "0x10060B0", VA = "0x10060B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002007")]
			[Address(RVA = "0x1006118", Offset = "0x1006118", VA = "0x1006118")]
			set
			{
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002009 RID: 8201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E7")]
		public static MinimapFrame ActiveMinimapFrame
		{
			[Token(Token = "0x6002008")]
			[Address(RVA = "0x1006184", Offset = "0x1006184", VA = "0x1006184")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002009")]
			[Address(RVA = "0x10061EC", Offset = "0x10061EC", VA = "0x10061EC")]
			set
			{
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600200B RID: 8203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E8")]
		public static IPlayerResourcesDisplaySet ActivePlayerResourcesSet
		{
			[Token(Token = "0x600200A")]
			[Address(RVA = "0x1006258", Offset = "0x1006258", VA = "0x1006258")]
			get
			{
				return null;
			}
			[Token(Token = "0x600200B")]
			[Address(RVA = "0x10062C0", Offset = "0x10062C0", VA = "0x10062C0")]
			set
			{
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x0000F660 File Offset: 0x0000D860
		// (set) Token: 0x0600200D RID: 8205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E9")]
		public static int mapDelay
		{
			[Token(Token = "0x600200C")]
			[Address(RVA = "0x100632C", Offset = "0x100632C", VA = "0x100632C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600200D")]
			[Address(RVA = "0x1006394", Offset = "0x1006394", VA = "0x1006394")]
			set
			{
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x0000F678 File Offset: 0x0000D878
		// (set) Token: 0x0600200F RID: 8207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003EA")]
		public static bool SettingsUnlock_WorldEvil
		{
			[Token(Token = "0x600200E")]
			[Address(RVA = "0x1006400", Offset = "0x1006400", VA = "0x1006400")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600200F")]
			[Address(RVA = "0x1006468", Offset = "0x1006468", VA = "0x1006468")]
			set
			{
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x0000F690 File Offset: 0x0000D890
		// (set) Token: 0x06002011 RID: 8209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003EB")]
		public static bool SettingsEnabled_MinersWobble
		{
			[Token(Token = "0x6002010")]
			[Address(RVA = "0x10064D4", Offset = "0x10064D4", VA = "0x10064D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002011")]
			[Address(RVA = "0x100653C", Offset = "0x100653C", VA = "0x100653C")]
			set
			{
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
		// (set) Token: 0x06002013 RID: 8211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003EC")]
		public static bool SettingBlockGamepadsEntirely
		{
			[Token(Token = "0x6002012")]
			[Address(RVA = "0x10065A8", Offset = "0x10065A8", VA = "0x10065A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002013")]
			[Address(RVA = "0x1006610", Offset = "0x1006610", VA = "0x1006610")]
			set
			{
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
		// (set) Token: 0x06002015 RID: 8213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003ED")]
		public static bool SettingDontScaleMainMenuUp
		{
			[Token(Token = "0x6002014")]
			[Address(RVA = "0x100667C", Offset = "0x100667C", VA = "0x100667C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002015")]
			[Address(RVA = "0x10066E4", Offset = "0x10066E4", VA = "0x10066E4")]
			set
			{
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06002016 RID: 8214 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
		// (set) Token: 0x06002017 RID: 8215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003EE")]
		public static bool SettingsEnabled_OpaqueBoxBehindTooltips
		{
			[Token(Token = "0x6002016")]
			[Address(RVA = "0x1006750", Offset = "0x1006750", VA = "0x1006750")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002017")]
			[Address(RVA = "0x10067B8", Offset = "0x10067B8", VA = "0x10067B8")]
			set
			{
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
		// (set) Token: 0x06002019 RID: 8217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003EF")]
		public static int tooltipTime
		{
			[Token(Token = "0x6002018")]
			[Address(RVA = "0x1006824", Offset = "0x1006824", VA = "0x1006824")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002019")]
			[Address(RVA = "0x100688C", Offset = "0x100688C", VA = "0x100688C")]
			set
			{
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x0000F708 File Offset: 0x0000D908
		// (set) Token: 0x0600201B RID: 8219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F0")]
		public static int inventoryTooltipTime
		{
			[Token(Token = "0x600201A")]
			[Address(RVA = "0x10068F8", Offset = "0x10068F8", VA = "0x10068F8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600201B")]
			[Address(RVA = "0x1006960", Offset = "0x1006960", VA = "0x1006960")]
			set
			{
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x0000F720 File Offset: 0x0000D920
		// (set) Token: 0x0600201D RID: 8221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F1")]
		public static bool SettingMusicReplayDelayEnabled
		{
			[Token(Token = "0x600201C")]
			[Address(RVA = "0x10069CC", Offset = "0x10069CC", VA = "0x10069CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600201D")]
			[Address(RVA = "0x1006A34", Offset = "0x1006A34", VA = "0x1006A34")]
			set
			{
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x0000F738 File Offset: 0x0000D938
		// (set) Token: 0x0600201F RID: 8223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F2")]
		public static bool HidePassword
		{
			[Token(Token = "0x600201E")]
			[Address(RVA = "0x1006AA0", Offset = "0x1006AA0", VA = "0x1006AA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600201F")]
			[Address(RVA = "0x1006B08", Offset = "0x1006B08", VA = "0x1006B08")]
			set
			{
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x0000F750 File Offset: 0x0000D950
		// (set) Token: 0x06002021 RID: 8225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F3")]
		public static bool ReversedUpDownArmorSetBonuses
		{
			[Token(Token = "0x6002020")]
			[Address(RVA = "0x1006B74", Offset = "0x1006B74", VA = "0x1006B74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002021")]
			[Address(RVA = "0x1006BDC", Offset = "0x1006BDC", VA = "0x1006BDC")]
			set
			{
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x0000F768 File Offset: 0x0000D968
		// (set) Token: 0x06002023 RID: 8227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F4")]
		public static bool MouseShowBuildingGrid
		{
			[Token(Token = "0x6002022")]
			[Address(RVA = "0x1006C48", Offset = "0x1006C48", VA = "0x1006C48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002023")]
			[Address(RVA = "0x1006CB0", Offset = "0x1006CB0", VA = "0x1006CB0")]
			set
			{
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x0000F780 File Offset: 0x0000D980
		// (set) Token: 0x06002025 RID: 8229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F5")]
		public static float MouseBuildingGridAlpha
		{
			[Token(Token = "0x6002024")]
			[Address(RVA = "0x1006D1C", Offset = "0x1006D1C", VA = "0x1006D1C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002025")]
			[Address(RVA = "0x1006D84", Offset = "0x1006D84", VA = "0x1006D84")]
			set
			{
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002027 RID: 8231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F6")]
		public static Camera Camera
		{
			[Token(Token = "0x6002026")]
			[Address(RVA = "0x1006DF4", Offset = "0x1006DF4", VA = "0x1006DF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002027")]
			[Address(RVA = "0x1006E5C", Offset = "0x1006E5C", VA = "0x1006E5C")]
			set
			{
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002029 RID: 8233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F7")]
		public static string _savePath
		{
			[Token(Token = "0x6002028")]
			[Address(RVA = "0x1006EC8", Offset = "0x1006EC8", VA = "0x1006EC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002029")]
			[Address(RVA = "0x1006F30", Offset = "0x1006F30", VA = "0x1006F30")]
			set
			{
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600202B RID: 8235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F8")]
		public static string _oldSavePath
		{
			[Token(Token = "0x600202A")]
			[Address(RVA = "0x1006F9C", Offset = "0x1006F9C", VA = "0x1006F9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600202B")]
			[Address(RVA = "0x1007004", Offset = "0x1007004", VA = "0x1007004")]
			set
			{
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F9")]
		public static FavoritesFile LocalFavoriteData
		{
			[Token(Token = "0x600202C")]
			[Address(RVA = "0x1007070", Offset = "0x1007070", VA = "0x1007070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600202D RID: 8237 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600202E RID: 8238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FA")]
		public static FileMetadata MapFileMetadata
		{
			[Token(Token = "0x600202D")]
			[Address(RVA = "0x10070D8", Offset = "0x10070D8", VA = "0x10070D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600202E")]
			[Address(RVA = "0x1007140", Offset = "0x1007140", VA = "0x1007140")]
			set
			{
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002030 RID: 8240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FB")]
		public static BigProgressBarSystem BigBossProgressBar
		{
			[Token(Token = "0x600202F")]
			[Address(RVA = "0x10071AC", Offset = "0x10071AC", VA = "0x10071AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002030")]
			[Address(RVA = "0x1007214", Offset = "0x1007214", VA = "0x1007214")]
			set
			{
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x0000F798 File Offset: 0x0000D998
		// (set) Token: 0x06002032 RID: 8242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FC")]
		private float hellBlackBoxBottom
		{
			[Token(Token = "0x6002031")]
			[Address(RVA = "0x1007280", Offset = "0x1007280", VA = "0x1007280")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002032")]
			[Address(RVA = "0x10072E8", Offset = "0x10072E8", VA = "0x10072E8")]
			set
			{
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002034 RID: 8244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FD")]
		private int[] backTexture
		{
			[Token(Token = "0x6002033")]
			[Address(RVA = "0x1007358", Offset = "0x1007358", VA = "0x1007358")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002034")]
			[Address(RVA = "0x10073C0", Offset = "0x10073C0", VA = "0x10073C0")]
			set
			{
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002036 RID: 8246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FE")]
		private int[] oldBackTexture
		{
			[Token(Token = "0x6002035")]
			[Address(RVA = "0x100742C", Offset = "0x100742C", VA = "0x100742C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002036")]
			[Address(RVA = "0x1007494", Offset = "0x1007494", VA = "0x1007494")]
			set
			{
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002038 RID: 8248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FF")]
		private Texture2D[] backTextureValues
		{
			[Token(Token = "0x6002037")]
			[Address(RVA = "0x1007500", Offset = "0x1007500", VA = "0x1007500")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002038")]
			[Address(RVA = "0x1007568", Offset = "0x1007568", VA = "0x1007568")]
			set
			{
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600203A RID: 8250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000400")]
		private Texture2D[] oldBackTextureValues
		{
			[Token(Token = "0x6002039")]
			[Address(RVA = "0x10075D4", Offset = "0x10075D4", VA = "0x10075D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600203A")]
			[Address(RVA = "0x100763C", Offset = "0x100763C", VA = "0x100763C")]
			set
			{
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600203C RID: 8252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000401")]
		public static WorldSections sectionManager
		{
			[Token(Token = "0x600203B")]
			[Address(RVA = "0x10076A8", Offset = "0x10076A8", VA = "0x10076A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600203C")]
			[Address(RVA = "0x1007710", Offset = "0x1007710", VA = "0x1007710")]
			set
			{
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x0600203D RID: 8253 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
		// (set) Token: 0x0600203E RID: 8254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000402")]
		public static int WaveQuality
		{
			[Token(Token = "0x600203D")]
			[Address(RVA = "0x100777C", Offset = "0x100777C", VA = "0x100777C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600203E")]
			[Address(RVA = "0x10077E4", Offset = "0x10077E4", VA = "0x10077E4")]
			set
			{
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x0600203F RID: 8255 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
		// (set) Token: 0x06002040 RID: 8256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000403")]
		public static bool UseStormEffects
		{
			[Token(Token = "0x600203F")]
			[Address(RVA = "0x1007850", Offset = "0x1007850", VA = "0x1007850")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002040")]
			[Address(RVA = "0x10078B8", Offset = "0x10078B8", VA = "0x10078B8")]
			set
			{
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		// (set) Token: 0x06002042 RID: 8258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000404")]
		public static bool UseHeatDistortion
		{
			[Token(Token = "0x6002041")]
			[Address(RVA = "0x1007924", Offset = "0x1007924", VA = "0x1007924")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002042")]
			[Address(RVA = "0x100798C", Offset = "0x100798C", VA = "0x100798C")]
			set
			{
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		// (set) Token: 0x06002044 RID: 8260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000405")]
		private static float cameraLerp
		{
			[Token(Token = "0x6002043")]
			[Address(RVA = "0x10079F8", Offset = "0x10079F8", VA = "0x10079F8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002044")]
			[Address(RVA = "0x1007A60", Offset = "0x1007A60", VA = "0x1007A60")]
			set
			{
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x0000F810 File Offset: 0x0000DA10
		// (set) Token: 0x06002046 RID: 8262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000406")]
		private static int cameraLerpTimer
		{
			[Token(Token = "0x6002045")]
			[Address(RVA = "0x1007AD8", Offset = "0x1007AD8", VA = "0x1007AD8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002046")]
			[Address(RVA = "0x1007B40", Offset = "0x1007B40", VA = "0x1007B40")]
			set
			{
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x0000F828 File Offset: 0x0000DA28
		// (set) Token: 0x06002048 RID: 8264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000407")]
		private static int cameraLerpTimeToggle
		{
			[Token(Token = "0x6002047")]
			[Address(RVA = "0x1007BAC", Offset = "0x1007BAC", VA = "0x1007BAC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002048")]
			[Address(RVA = "0x1007C14", Offset = "0x1007C14", VA = "0x1007C14")]
			set
			{
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x0000F840 File Offset: 0x0000DA40
		// (set) Token: 0x0600204A RID: 8266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000408")]
		private static bool cameraGamePadLerp
		{
			[Token(Token = "0x6002049")]
			[Address(RVA = "0x1007C80", Offset = "0x1007C80", VA = "0x1007C80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600204A")]
			[Address(RVA = "0x1007CE8", Offset = "0x1007CE8", VA = "0x1007CE8")]
			set
			{
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x0000F858 File Offset: 0x0000DA58
		// (set) Token: 0x0600204C RID: 8268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000409")]
		public static Vector2 CurrentPan
		{
			[Token(Token = "0x600204B")]
			[Address(RVA = "0x1007D54", Offset = "0x1007D54", VA = "0x1007D54")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600204C")]
			[Address(RVA = "0x1007DC0", Offset = "0x1007DC0", VA = "0x1007DC0")]
			set
			{
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x0000F870 File Offset: 0x0000DA70
		// (set) Token: 0x0600204E RID: 8270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040A")]
		public static float sunCircle
		{
			[Token(Token = "0x600204D")]
			[Address(RVA = "0x1007E2C", Offset = "0x1007E2C", VA = "0x1007E2C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600204E")]
			[Address(RVA = "0x1007E94", Offset = "0x1007E94", VA = "0x1007E94")]
			set
			{
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x0000F888 File Offset: 0x0000DA88
		// (set) Token: 0x06002050 RID: 8272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040B")]
		public static int BlackFadeIn
		{
			[Token(Token = "0x600204F")]
			[Address(RVA = "0x1007F0C", Offset = "0x1007F0C", VA = "0x1007F0C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002050")]
			[Address(RVA = "0x1007F74", Offset = "0x1007F74", VA = "0x1007F74")]
			set
			{
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		// (set) Token: 0x06002052 RID: 8274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040C")]
		public static int undergroundBackground
		{
			[Token(Token = "0x6002051")]
			[Address(RVA = "0x1007FE0", Offset = "0x1007FE0", VA = "0x1007FE0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002052")]
			[Address(RVA = "0x1008048", Offset = "0x1008048", VA = "0x1008048")]
			set
			{
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		// (set) Token: 0x06002054 RID: 8276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040D")]
		public static int oldUndergroundBackground
		{
			[Token(Token = "0x6002053")]
			[Address(RVA = "0x10080B4", Offset = "0x10080B4", VA = "0x10080B4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002054")]
			[Address(RVA = "0x100811C", Offset = "0x100811C", VA = "0x100811C")]
			set
			{
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
		// (set) Token: 0x06002056 RID: 8278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040E")]
		public static bool renderNow
		{
			[Token(Token = "0x6002055")]
			[Address(RVA = "0x1008188", Offset = "0x1008188", VA = "0x1008188")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002056")]
			[Address(RVA = "0x10081F0", Offset = "0x10081F0", VA = "0x10081F0")]
			set
			{
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x0000F8E8 File Offset: 0x0000DAE8
		// (set) Token: 0x06002058 RID: 8280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040F")]
		public static int mouseX
		{
			[Token(Token = "0x6002057")]
			[Address(RVA = "0x100825C", Offset = "0x100825C", VA = "0x100825C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002058")]
			[Address(RVA = "0x10082C4", Offset = "0x10082C4", VA = "0x10082C4")]
			set
			{
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x0000F900 File Offset: 0x0000DB00
		// (set) Token: 0x0600205A RID: 8282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000410")]
		public static int mouseY
		{
			[Token(Token = "0x6002059")]
			[Address(RVA = "0x1008330", Offset = "0x1008330", VA = "0x1008330")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600205A")]
			[Address(RVA = "0x1008398", Offset = "0x1008398", VA = "0x1008398")]
			set
			{
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x0000F918 File Offset: 0x0000DB18
		// (set) Token: 0x0600205C RID: 8284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000411")]
		public static int worldMouseX
		{
			[Token(Token = "0x600205B")]
			[Address(RVA = "0x1008404", Offset = "0x1008404", VA = "0x1008404")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600205C")]
			[Address(RVA = "0x100846C", Offset = "0x100846C", VA = "0x100846C")]
			set
			{
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x0000F930 File Offset: 0x0000DB30
		// (set) Token: 0x0600205E RID: 8286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000412")]
		public static int worldMouseY
		{
			[Token(Token = "0x600205D")]
			[Address(RVA = "0x10084D8", Offset = "0x10084D8", VA = "0x10084D8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600205E")]
			[Address(RVA = "0x1008540", Offset = "0x1008540", VA = "0x1008540")]
			set
			{
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x0000F948 File Offset: 0x0000DB48
		// (set) Token: 0x06002060 RID: 8288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000413")]
		public static int lastMouseX
		{
			[Token(Token = "0x600205F")]
			[Address(RVA = "0x10085AC", Offset = "0x10085AC", VA = "0x10085AC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002060")]
			[Address(RVA = "0x1008614", Offset = "0x1008614", VA = "0x1008614")]
			set
			{
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x0000F960 File Offset: 0x0000DB60
		// (set) Token: 0x06002062 RID: 8290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000414")]
		public static int lastMouseY
		{
			[Token(Token = "0x6002061")]
			[Address(RVA = "0x1008680", Offset = "0x1008680", VA = "0x1008680")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002062")]
			[Address(RVA = "0x10086E8", Offset = "0x10086E8", VA = "0x10086E8")]
			set
			{
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x0000F978 File Offset: 0x0000DB78
		// (set) Token: 0x06002064 RID: 8292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000415")]
		public static bool mouseLeft
		{
			[Token(Token = "0x6002063")]
			[Address(RVA = "0x1008754", Offset = "0x1008754", VA = "0x1008754")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002064")]
			[Address(RVA = "0x10087BC", Offset = "0x10087BC", VA = "0x10087BC")]
			set
			{
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x0000F990 File Offset: 0x0000DB90
		// (set) Token: 0x06002066 RID: 8294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000416")]
		public static bool mouseRight
		{
			[Token(Token = "0x6002065")]
			[Address(RVA = "0x1008828", Offset = "0x1008828", VA = "0x1008828")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002066")]
			[Address(RVA = "0x1008890", Offset = "0x1008890", VA = "0x1008890")]
			set
			{
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		// (set) Token: 0x06002068 RID: 8296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000417")]
		public static bool worldMouseLeft
		{
			[Token(Token = "0x6002067")]
			[Address(RVA = "0x10088FC", Offset = "0x10088FC", VA = "0x10088FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002068")]
			[Address(RVA = "0x1008964", Offset = "0x1008964", VA = "0x1008964")]
			set
			{
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		// (set) Token: 0x0600206A RID: 8298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000418")]
		public static bool worldMouseLeftRelease
		{
			[Token(Token = "0x6002069")]
			[Address(RVA = "0x10089D0", Offset = "0x10089D0", VA = "0x10089D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600206A")]
			[Address(RVA = "0x1008A38", Offset = "0x1008A38", VA = "0x1008A38")]
			set
			{
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
		// (set) Token: 0x0600206C RID: 8300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000419")]
		public static bool worldMouseRight
		{
			[Token(Token = "0x600206B")]
			[Address(RVA = "0x1008AA4", Offset = "0x1008AA4", VA = "0x1008AA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600206C")]
			[Address(RVA = "0x1008B0C", Offset = "0x1008B0C", VA = "0x1008B0C")]
			set
			{
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
		// (set) Token: 0x0600206E RID: 8302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041A")]
		public static bool worldMouseRightRelease
		{
			[Token(Token = "0x600206D")]
			[Address(RVA = "0x1008B78", Offset = "0x1008B78", VA = "0x1008B78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600206E")]
			[Address(RVA = "0x1008BE0", Offset = "0x1008BE0", VA = "0x1008BE0")]
			set
			{
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x0000FA08 File Offset: 0x0000DC08
		// (set) Token: 0x06002070 RID: 8304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041B")]
		public static bool isMouseLeftConsumedByUI
		{
			[Token(Token = "0x600206F")]
			[Address(RVA = "0x1008C4C", Offset = "0x1008C4C", VA = "0x1008C4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002070")]
			[Address(RVA = "0x1008CB4", Offset = "0x1008CB4", VA = "0x1008CB4")]
			set
			{
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x0000FA20 File Offset: 0x0000DC20
		// (set) Token: 0x06002072 RID: 8306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041C")]
		public static bool DisableIntenseVisualEffects
		{
			[Token(Token = "0x6002071")]
			[Address(RVA = "0x1008D20", Offset = "0x1008D20", VA = "0x1008D20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002072")]
			[Address(RVA = "0x1008D88", Offset = "0x1008D88", VA = "0x1008D88")]
			set
			{
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x0000FA38 File Offset: 0x0000DC38
		// (set) Token: 0x06002074 RID: 8308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041D")]
		public static bool DisableCameraShake
		{
			[Token(Token = "0x6002073")]
			[Address(RVA = "0x1008DF4", Offset = "0x1008DF4", VA = "0x1008DF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002074")]
			[Address(RVA = "0x1008E5C", Offset = "0x1008E5C", VA = "0x1008E5C")]
			set
			{
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x0000FA50 File Offset: 0x0000DC50
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041E")]
		public static bool hairWindow
		{
			[Token(Token = "0x6002075")]
			[Address(RVA = "0x1008EC8", Offset = "0x1008EC8", VA = "0x1008EC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002076")]
			[Address(RVA = "0x1008F30", Offset = "0x1008F30", VA = "0x1008F30")]
			set
			{
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x0000FA68 File Offset: 0x0000DC68
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041F")]
		public static bool clothesWindow
		{
			[Token(Token = "0x6002077")]
			[Address(RVA = "0x1008F9C", Offset = "0x1008F9C", VA = "0x1008F9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002078")]
			[Address(RVA = "0x1009004", Offset = "0x1009004", VA = "0x1009004")]
			set
			{
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x0000FA80 File Offset: 0x0000DC80
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000420")]
		public static bool ingameOptionsWindow
		{
			[Token(Token = "0x6002079")]
			[Address(RVA = "0x1009070", Offset = "0x1009070", VA = "0x1009070")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600207A")]
			[Address(RVA = "0x10090D8", Offset = "0x10090D8", VA = "0x10090D8")]
			set
			{
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x0000FA98 File Offset: 0x0000DC98
		// (set) Token: 0x0600207C RID: 8316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000421")]
		public static bool inFancyUI
		{
			[Token(Token = "0x600207B")]
			[Address(RVA = "0x1009144", Offset = "0x1009144", VA = "0x1009144")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600207C")]
			[Address(RVA = "0x10091AC", Offset = "0x10091AC", VA = "0x10091AC")]
			set
			{
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		// (set) Token: 0x0600207E RID: 8318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000422")]
		public static byte gFade
		{
			[Token(Token = "0x600207D")]
			[Address(RVA = "0x1009218", Offset = "0x1009218", VA = "0x1009218")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600207E")]
			[Address(RVA = "0x1009280", Offset = "0x1009280", VA = "0x1009280")]
			set
			{
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
		// (set) Token: 0x06002080 RID: 8320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000423")]
		public static float gFader
		{
			[Token(Token = "0x600207F")]
			[Address(RVA = "0x10092EC", Offset = "0x10092EC", VA = "0x10092EC")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002080")]
			[Address(RVA = "0x1009354", Offset = "0x1009354", VA = "0x1009354")]
			set
			{
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000424")]
		public static byte gFadeDir
		{
			[Token(Token = "0x6002081")]
			[Address(RVA = "0x10093C4", Offset = "0x10093C4", VA = "0x10093C4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002082")]
			[Address(RVA = "0x100942C", Offset = "0x100942C", VA = "0x100942C")]
			set
			{
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		// (set) Token: 0x06002084 RID: 8324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000425")]
		public static bool render
		{
			[Token(Token = "0x6002083")]
			[Address(RVA = "0x1009498", Offset = "0x1009498", VA = "0x1009498")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002084")]
			[Address(RVA = "0x1009500", Offset = "0x1009500", VA = "0x1009500")]
			set
			{
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x0000FB10 File Offset: 0x0000DD10
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000426")]
		public static int qaStyle
		{
			[Token(Token = "0x6002085")]
			[Address(RVA = "0x100956C", Offset = "0x100956C", VA = "0x100956C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002086")]
			[Address(RVA = "0x10095D4", Offset = "0x10095D4", VA = "0x10095D4")]
			set
			{
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x0000FB28 File Offset: 0x0000DD28
		[Token(Token = "0x17000427")]
		public static int RecentServersConfigured
		{
			[Token(Token = "0x6002087")]
			[Address(RVA = "0x1009640", Offset = "0x1009640", VA = "0x1009640")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000428")]
		public static Netplay.RecentServerInformation[] RecentServer
		{
			[Token(Token = "0x6002088")]
			[Address(RVA = "0x1009748", Offset = "0x1009748", VA = "0x1009748")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x0000FB40 File Offset: 0x0000DD40
		// (set) Token: 0x0600208A RID: 8330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000429")]
		public static bool BackgroundEnabled
		{
			[Token(Token = "0x6002089")]
			[Address(RVA = "0x10097B0", Offset = "0x10097B0", VA = "0x10097B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600208A")]
			[Address(RVA = "0x1009818", Offset = "0x1009818", VA = "0x1009818")]
			set
			{
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x0000FB58 File Offset: 0x0000DD58
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042A")]
		public static int instantBGTransitionCounter
		{
			[Token(Token = "0x600208B")]
			[Address(RVA = "0x1009884", Offset = "0x1009884", VA = "0x1009884")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600208C")]
			[Address(RVA = "0x10098EC", Offset = "0x10098EC", VA = "0x10098EC")]
			set
			{
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x0000FB70 File Offset: 0x0000DD70
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042B")]
		public static int bgDelay
		{
			[Token(Token = "0x600208D")]
			[Address(RVA = "0x1009958", Offset = "0x1009958", VA = "0x1009958")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600208E")]
			[Address(RVA = "0x10099C0", Offset = "0x10099C0", VA = "0x10099C0")]
			set
			{
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x0000FB88 File Offset: 0x0000DD88
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042C")]
		public static int bgStyle
		{
			[Token(Token = "0x600208F")]
			[Address(RVA = "0x1009A2C", Offset = "0x1009A2C", VA = "0x1009A2C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002090")]
			[Address(RVA = "0x1009A94", Offset = "0x1009A94", VA = "0x1009A94")]
			set
			{
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042D")]
		public static float[] bgAlphaFrontLayer
		{
			[Token(Token = "0x6002091")]
			[Address(RVA = "0x1009B00", Offset = "0x1009B00", VA = "0x1009B00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002092")]
			[Address(RVA = "0x1009B68", Offset = "0x1009B68", VA = "0x1009B68")]
			set
			{
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042E")]
		public static float[] bgAlphaFarBackLayer
		{
			[Token(Token = "0x6002093")]
			[Address(RVA = "0x1009BD4", Offset = "0x1009BD4", VA = "0x1009BD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002094")]
			[Address(RVA = "0x1009C3C", Offset = "0x1009C3C", VA = "0x1009C3C")]
			set
			{
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042F")]
		public static int[] bgFrame
		{
			[Token(Token = "0x6002095")]
			[Address(RVA = "0x1009CA8", Offset = "0x1009CA8", VA = "0x1009CA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002096")]
			[Address(RVA = "0x1009D10", Offset = "0x1009D10", VA = "0x1009D10")]
			set
			{
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000430")]
		public static int[] bgFrameCounter
		{
			[Token(Token = "0x6002097")]
			[Address(RVA = "0x1009D7C", Offset = "0x1009D7C", VA = "0x1009D7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002098")]
			[Address(RVA = "0x1009DE4", Offset = "0x1009DE4", VA = "0x1009DE4")]
			set
			{
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000431")]
		public static bool refreshMap
		{
			[Token(Token = "0x6002099")]
			[Address(RVA = "0x1009E50", Offset = "0x1009E50", VA = "0x1009E50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600209A")]
			[Address(RVA = "0x1009EB8", Offset = "0x1009EB8", VA = "0x1009EB8")]
			set
			{
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		// (set) Token: 0x0600209C RID: 8348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000432")]
		public static int loadMapLastX
		{
			[Token(Token = "0x600209B")]
			[Address(RVA = "0x1009F24", Offset = "0x1009F24", VA = "0x1009F24")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600209C")]
			[Address(RVA = "0x1009F8C", Offset = "0x1009F8C", VA = "0x1009F8C")]
			set
			{
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		// (set) Token: 0x0600209E RID: 8350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000433")]
		public static bool loadMapLock
		{
			[Token(Token = "0x600209D")]
			[Address(RVA = "0x1009FF8", Offset = "0x1009FF8", VA = "0x1009FF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600209E")]
			[Address(RVA = "0x100A060", Offset = "0x100A060", VA = "0x100A060")]
			set
			{
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000434")]
		public static bool loadMap
		{
			[Token(Token = "0x600209F")]
			[Address(RVA = "0x100A0CC", Offset = "0x100A0CC", VA = "0x100A0CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020A0")]
			[Address(RVA = "0x100A134", Offset = "0x100A134", VA = "0x100A134")]
			set
			{
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x0000FC00 File Offset: 0x0000DE00
		// (set) Token: 0x060020A2 RID: 8354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000435")]
		public static bool loadMapSections
		{
			[Token(Token = "0x60020A1")]
			[Address(RVA = "0x100A1A0", Offset = "0x100A1A0", VA = "0x100A1A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020A2")]
			[Address(RVA = "0x100A208", Offset = "0x100A208", VA = "0x100A208")]
			set
			{
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x0000FC18 File Offset: 0x0000DE18
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000436")]
		public static bool mapReady
		{
			[Token(Token = "0x60020A3")]
			[Address(RVA = "0x100A274", Offset = "0x100A274", VA = "0x100A274")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020A4")]
			[Address(RVA = "0x100A2DC", Offset = "0x100A2DC", VA = "0x100A2DC")]
			set
			{
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x0000FC30 File Offset: 0x0000DE30
		// (set) Token: 0x060020A6 RID: 8358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000437")]
		public static bool updateMap
		{
			[Token(Token = "0x60020A5")]
			[Address(RVA = "0x100A348", Offset = "0x100A348", VA = "0x100A348")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020A6")]
			[Address(RVA = "0x100A3B0", Offset = "0x100A3B0", VA = "0x100A3B0")]
			set
			{
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x0000FC48 File Offset: 0x0000DE48
		// (set) Token: 0x060020A8 RID: 8360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000438")]
		public static int mapMinX
		{
			[Token(Token = "0x60020A7")]
			[Address(RVA = "0x100A41C", Offset = "0x100A41C", VA = "0x100A41C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020A8")]
			[Address(RVA = "0x100A484", Offset = "0x100A484", VA = "0x100A484")]
			set
			{
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x0000FC60 File Offset: 0x0000DE60
		// (set) Token: 0x060020AA RID: 8362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000439")]
		public static int mapMaxX
		{
			[Token(Token = "0x60020A9")]
			[Address(RVA = "0x100A4F0", Offset = "0x100A4F0", VA = "0x100A4F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020AA")]
			[Address(RVA = "0x100A558", Offset = "0x100A558", VA = "0x100A558")]
			set
			{
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x0000FC78 File Offset: 0x0000DE78
		// (set) Token: 0x060020AC RID: 8364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043A")]
		public static int mapMinY
		{
			[Token(Token = "0x60020AB")]
			[Address(RVA = "0x100A5C4", Offset = "0x100A5C4", VA = "0x100A5C4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020AC")]
			[Address(RVA = "0x100A62C", Offset = "0x100A62C", VA = "0x100A62C")]
			set
			{
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x0000FC90 File Offset: 0x0000DE90
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043B")]
		public static int mapMaxY
		{
			[Token(Token = "0x60020AD")]
			[Address(RVA = "0x100A698", Offset = "0x100A698", VA = "0x100A698")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020AE")]
			[Address(RVA = "0x100A700", Offset = "0x100A700", VA = "0x100A700")]
			set
			{
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060020AF RID: 8367 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		// (set) Token: 0x060020B0 RID: 8368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043C")]
		public static int mapTimeMax
		{
			[Token(Token = "0x60020AF")]
			[Address(RVA = "0x100A76C", Offset = "0x100A76C", VA = "0x100A76C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020B0")]
			[Address(RVA = "0x100A7D4", Offset = "0x100A7D4", VA = "0x100A7D4")]
			set
			{
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		// (set) Token: 0x060020B2 RID: 8370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043D")]
		public static int mapTime
		{
			[Token(Token = "0x60020B1")]
			[Address(RVA = "0x100A840", Offset = "0x100A840", VA = "0x100A840")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020B2")]
			[Address(RVA = "0x100A8A8", Offset = "0x100A8A8", VA = "0x100A8A8")]
			set
			{
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		// (set) Token: 0x060020B4 RID: 8372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043E")]
		public static bool clearMap
		{
			[Token(Token = "0x60020B3")]
			[Address(RVA = "0x100A914", Offset = "0x100A914", VA = "0x100A914")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020B4")]
			[Address(RVA = "0x100A97C", Offset = "0x100A97C", VA = "0x100A97C")]
			set
			{
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043F")]
		public static bool mapInit
		{
			[Token(Token = "0x60020B5")]
			[Address(RVA = "0x100A9E8", Offset = "0x100A9E8", VA = "0x100A9E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020B6")]
			[Address(RVA = "0x100AA50", Offset = "0x100AA50", VA = "0x100AA50")]
			set
			{
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x0000FD08 File Offset: 0x0000DF08
		// (set) Token: 0x060020B8 RID: 8376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000440")]
		public static bool mapEnabled
		{
			[Token(Token = "0x60020B7")]
			[Address(RVA = "0x100AABC", Offset = "0x100AABC", VA = "0x100AABC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020B8")]
			[Address(RVA = "0x100AB24", Offset = "0x100AB24", VA = "0x100AB24")]
			set
			{
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x0000FD20 File Offset: 0x0000DF20
		// (set) Token: 0x060020BA RID: 8378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000441")]
		public static int mapStyle
		{
			[Token(Token = "0x60020B9")]
			[Address(RVA = "0x100AB90", Offset = "0x100AB90", VA = "0x100AB90")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020BA")]
			[Address(RVA = "0x100ABF8", Offset = "0x100ABF8", VA = "0x100ABF8")]
			set
			{
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x0000FD38 File Offset: 0x0000DF38
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000442")]
		public static float grabMapX
		{
			[Token(Token = "0x60020BB")]
			[Address(RVA = "0x100AC64", Offset = "0x100AC64", VA = "0x100AC64")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60020BC")]
			[Address(RVA = "0x100ACCC", Offset = "0x100ACCC", VA = "0x100ACCC")]
			set
			{
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x0000FD50 File Offset: 0x0000DF50
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000443")]
		public static float grabMapY
		{
			[Token(Token = "0x60020BD")]
			[Address(RVA = "0x100AD40", Offset = "0x100AD40", VA = "0x100AD40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60020BE")]
			[Address(RVA = "0x100ADA8", Offset = "0x100ADA8", VA = "0x100ADA8")]
			set
			{
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x0000FD68 File Offset: 0x0000DF68
		// (set) Token: 0x060020C0 RID: 8384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000444")]
		public static float grabMapInitialX
		{
			[Token(Token = "0x60020BF")]
			[Address(RVA = "0x100AE20", Offset = "0x100AE20", VA = "0x100AE20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60020C0")]
			[Address(RVA = "0x100AE88", Offset = "0x100AE88", VA = "0x100AE88")]
			set
			{
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x0000FD80 File Offset: 0x0000DF80
		// (set) Token: 0x060020C2 RID: 8386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000445")]
		public static float grabMapInitialY
		{
			[Token(Token = "0x60020C1")]
			[Address(RVA = "0x100AF00", Offset = "0x100AF00", VA = "0x100AF00")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60020C2")]
			[Address(RVA = "0x100AF68", Offset = "0x100AF68", VA = "0x100AF68")]
			set
			{
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x0000FD98 File Offset: 0x0000DF98
		// (set) Token: 0x060020C4 RID: 8388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000446")]
		public static bool grabMapInProgress
		{
			[Token(Token = "0x60020C3")]
			[Address(RVA = "0x100AFE0", Offset = "0x100AFE0", VA = "0x100AFE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020C4")]
			[Address(RVA = "0x100B048", Offset = "0x100B048", VA = "0x100B048")]
			set
			{
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
		// (set) Token: 0x060020C6 RID: 8390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000447")]
		public static int miniMapX
		{
			[Token(Token = "0x60020C5")]
			[Address(RVA = "0x100B0B4", Offset = "0x100B0B4", VA = "0x100B0B4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020C6")]
			[Address(RVA = "0x100B11C", Offset = "0x100B11C", VA = "0x100B11C")]
			set
			{
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		// (set) Token: 0x060020C8 RID: 8392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000448")]
		public static int miniMapY
		{
			[Token(Token = "0x60020C7")]
			[Address(RVA = "0x100B188", Offset = "0x100B188", VA = "0x100B188")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020C8")]
			[Address(RVA = "0x100B1F0", Offset = "0x100B1F0", VA = "0x100B1F0")]
			set
			{
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		// (set) Token: 0x060020CA RID: 8394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000449")]
		public static int miniMapWidth
		{
			[Token(Token = "0x60020C9")]
			[Address(RVA = "0x100B25C", Offset = "0x100B25C", VA = "0x100B25C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020CA")]
			[Address(RVA = "0x100B2C4", Offset = "0x100B2C4", VA = "0x100B2C4")]
			set
			{
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		// (set) Token: 0x060020CC RID: 8396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044A")]
		public static int miniMapHeight
		{
			[Token(Token = "0x60020CB")]
			[Address(RVA = "0x100B330", Offset = "0x100B330", VA = "0x100B330")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020CC")]
			[Address(RVA = "0x100B398", Offset = "0x100B398", VA = "0x100B398")]
			set
			{
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x0000FE10 File Offset: 0x0000E010
		// (set) Token: 0x060020CE RID: 8398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044B")]
		public static float mapMinimapScale
		{
			[Token(Token = "0x60020CD")]
			[Address(RVA = "0x100B404", Offset = "0x100B404", VA = "0x100B404")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60020CE")]
			[Address(RVA = "0x100B46C", Offset = "0x100B46C", VA = "0x100B46C")]
			set
			{
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x0000FE28 File Offset: 0x0000E028
		// (set) Token: 0x060020D0 RID: 8400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044C")]
		public static float mapMinimapAlpha
		{
			[Token(Token = "0x60020CF")]
			[Address(RVA = "0x100B4E4", Offset = "0x100B4E4", VA = "0x100B4E4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60020D0")]
			[Address(RVA = "0x100B54C", Offset = "0x100B54C", VA = "0x100B54C")]
			set
			{
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x0000FE40 File Offset: 0x0000E040
		// (set) Token: 0x060020D2 RID: 8402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044D")]
		public static float mapOverlayScale
		{
			[Token(Token = "0x60020D1")]
			[Address(RVA = "0x100B5C4", Offset = "0x100B5C4", VA = "0x100B5C4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60020D2")]
			[Address(RVA = "0x100B62C", Offset = "0x100B62C", VA = "0x100B62C")]
			set
			{
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060020D3 RID: 8403 RVA: 0x0000FE58 File Offset: 0x0000E058
		// (set) Token: 0x060020D4 RID: 8404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044E")]
		public static float mapOverlayAlpha
		{
			[Token(Token = "0x60020D3")]
			[Address(RVA = "0x100B6A4", Offset = "0x100B6A4", VA = "0x100B6A4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60020D4")]
			[Address(RVA = "0x100B70C", Offset = "0x100B70C", VA = "0x100B70C")]
			set
			{
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060020D5 RID: 8405 RVA: 0x0000FE70 File Offset: 0x0000E070
		// (set) Token: 0x060020D6 RID: 8406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044F")]
		public static bool mapFullscreen
		{
			[Token(Token = "0x60020D5")]
			[Address(RVA = "0x100B780", Offset = "0x100B780", VA = "0x100B780")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020D6")]
			[Address(RVA = "0x100B7E8", Offset = "0x100B7E8", VA = "0x100B7E8")]
			set
			{
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x0000FE88 File Offset: 0x0000E088
		// (set) Token: 0x060020D8 RID: 8408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000450")]
		public static Point16 MapPylonTile
		{
			[Token(Token = "0x60020D7")]
			[Address(RVA = "0x100B854", Offset = "0x100B854", VA = "0x100B854")]
			get
			{
				return default(Point16);
			}
			[Token(Token = "0x60020D8")]
			[Address(RVA = "0x100B8BC", Offset = "0x100B8BC", VA = "0x100B8BC")]
			set
			{
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060020D9 RID: 8409 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		// (set) Token: 0x060020DA RID: 8410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000451")]
		public static bool PanTargetMapFullscreen
		{
			[Token(Token = "0x60020D9")]
			[Address(RVA = "0x100B928", Offset = "0x100B928", VA = "0x100B928")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020DA")]
			[Address(RVA = "0x100B990", Offset = "0x100B990", VA = "0x100B990")]
			set
			{
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060020DB RID: 8411 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
		// (set) Token: 0x060020DC RID: 8412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000452")]
		public static Vector2 PanTargetMapFullscreenEnd
		{
			[Token(Token = "0x60020DB")]
			[Address(RVA = "0x100B9FC", Offset = "0x100B9FC", VA = "0x100B9FC")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60020DC")]
			[Address(RVA = "0x100BA68", Offset = "0x100BA68", VA = "0x100BA68")]
			set
			{
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060020DD RID: 8413 RVA: 0x0000FED0 File Offset: 0x0000E0D0
		// (set) Token: 0x060020DE RID: 8414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000453")]
		public static bool resetMapFull
		{
			[Token(Token = "0x60020DD")]
			[Address(RVA = "0x100BAD4", Offset = "0x100BAD4", VA = "0x100BAD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020DE")]
			[Address(RVA = "0x100BB3C", Offset = "0x100BB3C", VA = "0x100BB3C")]
			set
			{
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060020DF RID: 8415 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		// (set) Token: 0x060020E0 RID: 8416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000454")]
		public static int resetMapFullCharacter
		{
			[Token(Token = "0x60020DF")]
			[Address(RVA = "0x100BBA8", Offset = "0x100BBA8", VA = "0x100BBA8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020E0")]
			[Address(RVA = "0x100BC10", Offset = "0x100BC10", VA = "0x100BC10")]
			set
			{
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x0000FF00 File Offset: 0x0000E100
		// (set) Token: 0x060020E2 RID: 8418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000455")]
		public static float mapFullscreenScale
		{
			[Token(Token = "0x60020E1")]
			[Address(RVA = "0x100BC7C", Offset = "0x100BC7C", VA = "0x100BC7C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60020E2")]
			[Address(RVA = "0x100BCE4", Offset = "0x100BCE4", VA = "0x100BCE4")]
			set
			{
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x0000FF18 File Offset: 0x0000E118
		// (set) Token: 0x060020E4 RID: 8420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000456")]
		public static Vector2 mapFullscreenPos
		{
			[Token(Token = "0x60020E3")]
			[Address(RVA = "0x100BD5C", Offset = "0x100BD5C", VA = "0x100BD5C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60020E4")]
			[Address(RVA = "0x100BDC8", Offset = "0x100BDC8", VA = "0x100BDC8")]
			set
			{
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x0000FF30 File Offset: 0x0000E130
		// (set) Token: 0x060020E6 RID: 8422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000457")]
		public static int renderCount
		{
			[Token(Token = "0x60020E5")]
			[Address(RVA = "0x100BE34", Offset = "0x100BE34", VA = "0x100BE34")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020E6")]
			[Address(RVA = "0x100BE9C", Offset = "0x100BE9C", VA = "0x100BE9C")]
			set
			{
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060020E7 RID: 8423 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020E8 RID: 8424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000458")]
		public static Stopwatch saveTime
		{
			[Token(Token = "0x60020E7")]
			[Address(RVA = "0x100BF08", Offset = "0x100BF08", VA = "0x100BF08")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020E8")]
			[Address(RVA = "0x100BF70", Offset = "0x100BF70", VA = "0x100BF70")]
			set
			{
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x0000FF48 File Offset: 0x0000E148
		// (set) Token: 0x060020EA RID: 8426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000459")]
		public static float shimmerAlpha
		{
			[Token(Token = "0x60020E9")]
			[Address(RVA = "0x100BFDC", Offset = "0x100BFDC", VA = "0x100BFDC")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60020EA")]
			[Address(RVA = "0x100C044", Offset = "0x100C044", VA = "0x100C044")]
			set
			{
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060020EB RID: 8427 RVA: 0x0000FF60 File Offset: 0x0000E160
		// (set) Token: 0x060020EC RID: 8428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045A")]
		public static float shimmerDarken
		{
			[Token(Token = "0x60020EB")]
			[Address(RVA = "0x100C0BC", Offset = "0x100C0BC", VA = "0x100C0BC")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60020EC")]
			[Address(RVA = "0x100C124", Offset = "0x100C124", VA = "0x100C124")]
			set
			{
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060020ED RID: 8429 RVA: 0x0000FF78 File Offset: 0x0000E178
		// (set) Token: 0x060020EE RID: 8430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045B")]
		public static float shimmerBrightenDelay
		{
			[Token(Token = "0x60020ED")]
			[Address(RVA = "0x100C198", Offset = "0x100C198", VA = "0x100C198")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60020EE")]
			[Address(RVA = "0x100C200", Offset = "0x100C200", VA = "0x100C200")]
			set
			{
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x0000FF90 File Offset: 0x0000E190
		// (set) Token: 0x060020F0 RID: 8432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045C")]
		public static float gfxQuality
		{
			[Token(Token = "0x60020EF")]
			[Address(RVA = "0x100C278", Offset = "0x100C278", VA = "0x100C278")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60020F0")]
			[Address(RVA = "0x100C2E0", Offset = "0x100C2E0", VA = "0x100C2E0")]
			set
			{
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060020F1 RID: 8433 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
		// (set) Token: 0x060020F2 RID: 8434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045D")]
		public static float gfxRate
		{
			[Token(Token = "0x60020F1")]
			[Address(RVA = "0x100C358", Offset = "0x100C358", VA = "0x100C358")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60020F2")]
			[Address(RVA = "0x100C3C0", Offset = "0x100C3C0", VA = "0x100C3C0")]
			set
			{
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060020F3 RID: 8435 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		// (set) Token: 0x060020F4 RID: 8436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045E")]
		public static int teamCooldown
		{
			[Token(Token = "0x60020F3")]
			[Address(RVA = "0x100C434", Offset = "0x100C434", VA = "0x100C434")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020F4")]
			[Address(RVA = "0x100C49C", Offset = "0x100C49C", VA = "0x100C49C")]
			set
			{
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		// (set) Token: 0x060020F6 RID: 8438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045F")]
		public static bool showFrameRate
		{
			[Token(Token = "0x60020F5")]
			[Address(RVA = "0x100C508", Offset = "0x100C508", VA = "0x100C508")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020F6")]
			[Address(RVA = "0x100C570", Offset = "0x100C570", VA = "0x100C570")]
			set
			{
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
		// (set) Token: 0x060020F8 RID: 8440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000460")]
		public static bool drewLava
		{
			[Token(Token = "0x60020F7")]
			[Address(RVA = "0x100C5DC", Offset = "0x100C5DC", VA = "0x100C5DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020F8")]
			[Address(RVA = "0x100C644", Offset = "0x100C644", VA = "0x100C644")]
			set
			{
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x00010008 File Offset: 0x0000E208
		// (set) Token: 0x060020FA RID: 8442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000461")]
		public static int numActiveLiquidAlpha
		{
			[Token(Token = "0x60020F9")]
			[Address(RVA = "0x100C6B0", Offset = "0x100C6B0", VA = "0x100C6B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020FA")]
			[Address(RVA = "0x100C718", Offset = "0x100C718", VA = "0x100C718")]
			set
			{
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020FC RID: 8444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000462")]
		public static int[] activeLiquidAlpha
		{
			[Token(Token = "0x60020FB")]
			[Address(RVA = "0x100C784", Offset = "0x100C784", VA = "0x100C784")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020FC")]
			[Address(RVA = "0x100C7EC", Offset = "0x100C7EC", VA = "0x100C7EC")]
			set
			{
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020FE RID: 8446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000463")]
		public static float[] liquidAlpha
		{
			[Token(Token = "0x60020FD")]
			[Address(RVA = "0x100C858", Offset = "0x100C858", VA = "0x100C858")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020FE")]
			[Address(RVA = "0x100C8C0", Offset = "0x100C8C0", VA = "0x100C8C0")]
			set
			{
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060020FF RID: 8447 RVA: 0x00010020 File Offset: 0x0000E220
		// (set) Token: 0x06002100 RID: 8448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000464")]
		public static int waterStyle
		{
			[Token(Token = "0x60020FF")]
			[Address(RVA = "0x100C92C", Offset = "0x100C92C", VA = "0x100C92C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002100")]
			[Address(RVA = "0x100C994", Offset = "0x100C994", VA = "0x100C994")]
			set
			{
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06002101 RID: 8449 RVA: 0x00010038 File Offset: 0x0000E238
		// (set) Token: 0x06002102 RID: 8450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000465")]
		public static bool TOWMusicUnlocked
		{
			[Token(Token = "0x6002101")]
			[Address(RVA = "0x100CA00", Offset = "0x100CA00", VA = "0x100CA00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002102")]
			[Address(RVA = "0x100CA68", Offset = "0x100CA68", VA = "0x100CA68")]
			set
			{
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06002103 RID: 8451 RVA: 0x00010050 File Offset: 0x0000E250
		// (set) Token: 0x06002104 RID: 8452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000466")]
		public static float caveParallax
		{
			[Token(Token = "0x6002103")]
			[Address(RVA = "0x100CAD4", Offset = "0x100CAD4", VA = "0x100CAD4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002104")]
			[Address(RVA = "0x100CB3C", Offset = "0x100CB3C", VA = "0x100CB3C")]
			set
			{
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x00010068 File Offset: 0x0000E268
		// (set) Token: 0x06002106 RID: 8454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000467")]
		public static bool showItemText
		{
			[Token(Token = "0x6002105")]
			[Address(RVA = "0x100CBB4", Offset = "0x100CBB4", VA = "0x100CBB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002106")]
			[Address(RVA = "0x100CC1C", Offset = "0x100CC1C", VA = "0x100CC1C")]
			set
			{
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06002107 RID: 8455 RVA: 0x00010080 File Offset: 0x0000E280
		// (set) Token: 0x06002108 RID: 8456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000468")]
		public static bool autoSave
		{
			[Token(Token = "0x6002107")]
			[Address(RVA = "0x100CC88", Offset = "0x100CC88", VA = "0x100CC88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002108")]
			[Address(RVA = "0x100CCF0", Offset = "0x100CCF0", VA = "0x100CCF0")]
			set
			{
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x00010098 File Offset: 0x0000E298
		[Token(Token = "0x17000469")]
		public static int worldID
		{
			[Token(Token = "0x6002109")]
			[Address(RVA = "0x100CD5C", Offset = "0x100CD5C", VA = "0x100CD5C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x000100B0 File Offset: 0x0000E2B0
		// (set) Token: 0x0600210B RID: 8459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046A")]
		public static int background
		{
			[Token(Token = "0x600210A")]
			[Address(RVA = "0x100CDD8", Offset = "0x100CDD8", VA = "0x100CDD8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600210B")]
			[Address(RVA = "0x100CE40", Offset = "0x100CE40", VA = "0x100CE40")]
			set
			{
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x000100C8 File Offset: 0x0000E2C8
		// (set) Token: 0x0600210D RID: 8461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046B")]
		public static int caveBackground
		{
			[Token(Token = "0x600210C")]
			[Address(RVA = "0x100CEAC", Offset = "0x100CEAC", VA = "0x100CEAC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600210D")]
			[Address(RVA = "0x100CF14", Offset = "0x100CF14", VA = "0x100CF14")]
			set
			{
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x000100E0 File Offset: 0x0000E2E0
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046C")]
		public static float ugBackTransition
		{
			[Token(Token = "0x600210E")]
			[Address(RVA = "0x100CF80", Offset = "0x100CF80", VA = "0x100CF80")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600210F")]
			[Address(RVA = "0x100CFE8", Offset = "0x100CFE8", VA = "0x100CFE8")]
			set
			{
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x000100F8 File Offset: 0x0000E2F8
		// (set) Token: 0x06002111 RID: 8465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046D")]
		public static Vector2 LastCelestialBodyPosition
		{
			[Token(Token = "0x6002110")]
			[Address(RVA = "0x100D05C", Offset = "0x100D05C", VA = "0x100D05C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002111")]
			[Address(RVA = "0x100D0C8", Offset = "0x100D0C8", VA = "0x100D0C8")]
			set
			{
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x00010110 File Offset: 0x0000E310
		// (set) Token: 0x06002113 RID: 8467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046E")]
		public static Vector2 LastCelestialBodyPositionScaled
		{
			[Token(Token = "0x6002112")]
			[Address(RVA = "0x100D134", Offset = "0x100D134", VA = "0x100D134")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002113")]
			[Address(RVA = "0x100D1A0", Offset = "0x100D1A0", VA = "0x100D1A0")]
			set
			{
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x00010128 File Offset: 0x0000E328
		// (set) Token: 0x06002115 RID: 8469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046F")]
		public static Main.AutoPauseMode autoPause
		{
			[Token(Token = "0x6002114")]
			[Address(RVA = "0x100D20C", Offset = "0x100D20C", VA = "0x100D20C")]
			get
			{
				return Main.AutoPauseMode.Disabled;
			}
			[Token(Token = "0x6002115")]
			[Address(RVA = "0x100D274", Offset = "0x100D274", VA = "0x100D274")]
			set
			{
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06002116 RID: 8470 RVA: 0x00010140 File Offset: 0x0000E340
		// (set) Token: 0x06002117 RID: 8471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000470")]
		public static bool placementPreview
		{
			[Token(Token = "0x6002116")]
			[Address(RVA = "0x100D2E0", Offset = "0x100D2E0", VA = "0x100D2E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002117")]
			[Address(RVA = "0x100D348", Offset = "0x100D348", VA = "0x100D348")]
			set
			{
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06002118 RID: 8472 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002119 RID: 8473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000471")]
		public static SceneMetrics _cameraSceneMetrics
		{
			[Token(Token = "0x6002118")]
			[Address(RVA = "0x100D3B4", Offset = "0x100D3B4", VA = "0x100D3B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002119")]
			[Address(RVA = "0x100D41C", Offset = "0x100D41C", VA = "0x100D41C")]
			set
			{
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600211B RID: 8475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000472")]
		public static SceneMetrics _playerSceneMetrics
		{
			[Token(Token = "0x600211A")]
			[Address(RVA = "0x100D488", Offset = "0x100D488", VA = "0x100D488")]
			get
			{
				return null;
			}
			[Token(Token = "0x600211B")]
			[Address(RVA = "0x100D4F0", Offset = "0x100D4F0", VA = "0x100D4F0")]
			set
			{
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000473")]
		public static SceneMetrics SceneMetrics
		{
			[Token(Token = "0x600211C")]
			[Address(RVA = "0x100D55C", Offset = "0x100D55C", VA = "0x100D55C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x0600211D RID: 8477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000474")]
		public static SceneMetrics PlayerSceneMetrics
		{
			[Token(Token = "0x600211D")]
			[Address(RVA = "0x100D740", Offset = "0x100D740", VA = "0x100D740")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600211F RID: 8479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000475")]
		public static SceneState SceneState
		{
			[Token(Token = "0x600211E")]
			[Address(RVA = "0x100D7F8", Offset = "0x100D7F8", VA = "0x100D7F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600211F")]
			[Address(RVA = "0x100D860", Offset = "0x100D860", VA = "0x100D860")]
			set
			{
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x00010158 File Offset: 0x0000E358
		// (set) Token: 0x06002121 RID: 8481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000476")]
		public static bool _usingSeparateCameraSceneMetrics
		{
			[Token(Token = "0x6002120")]
			[Address(RVA = "0x100D6D8", Offset = "0x100D6D8", VA = "0x100D6D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002121")]
			[Address(RVA = "0x100D8CC", Offset = "0x100D8CC", VA = "0x100D8CC")]
			set
			{
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06002122 RID: 8482 RVA: 0x00010170 File Offset: 0x0000E370
		// (set) Token: 0x06002123 RID: 8483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000477")]
		public static bool SettingsEnabled_TilesSwayInWind
		{
			[Token(Token = "0x6002122")]
			[Address(RVA = "0x100D938", Offset = "0x100D938", VA = "0x100D938")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002123")]
			[Address(RVA = "0x100D9A0", Offset = "0x100D9A0", VA = "0x100D9A0")]
			set
			{
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06002124 RID: 8484 RVA: 0x00010188 File Offset: 0x0000E388
		// (set) Token: 0x06002125 RID: 8485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000478")]
		public static float SmoothedMushroomLightInfluence
		{
			[Token(Token = "0x6002124")]
			[Address(RVA = "0x100DA0C", Offset = "0x100DA0C", VA = "0x100DA0C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002125")]
			[Address(RVA = "0x100DA74", Offset = "0x100DA74", VA = "0x100DA74")]
			set
			{
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x000101A0 File Offset: 0x0000E3A0
		// (set) Token: 0x06002127 RID: 8487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000479")]
		public static float GraveyardVisualIntensity
		{
			[Token(Token = "0x6002126")]
			[Address(RVA = "0x100DAE4", Offset = "0x100DAE4", VA = "0x100DAE4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002127")]
			[Address(RVA = "0x100DB4C", Offset = "0x100DB4C", VA = "0x100DB4C")]
			set
			{
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x000101B8 File Offset: 0x0000E3B8
		// (set) Token: 0x06002129 RID: 8489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700047A")]
		public static float musicVolume
		{
			[Token(Token = "0x6002128")]
			[Address(RVA = "0x100DBBC", Offset = "0x100DBBC", VA = "0x100DBBC")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002129")]
			[Address(RVA = "0x100DC24", Offset = "0x100DC24", VA = "0x100DC24")]
			set
			{
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x000101D0 File Offset: 0x0000E3D0
		// (set) Token: 0x0600212B RID: 8491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700047B")]
		public static float ambientVolume
		{
			[Token(Token = "0x600212A")]
			[Address(RVA = "0x100DC9C", Offset = "0x100DC9C", VA = "0x100DC9C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600212B")]
			[Address(RVA = "0x100DD04", Offset = "0x100DD04", VA = "0x100DD04")]
			set
			{
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x000101E8 File Offset: 0x0000E3E8
		// (set) Token: 0x0600212D RID: 8493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700047C")]
		public static float soundVolume
		{
			[Token(Token = "0x600212C")]
			[Address(RVA = "0x100DD7C", Offset = "0x100DD7C", VA = "0x100DD7C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600212D")]
			[Address(RVA = "0x100DDE4", Offset = "0x100DDE4", VA = "0x100DDE4")]
			set
			{
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600212F RID: 8495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700047D")]
		public static WorldMap Map
		{
			[Token(Token = "0x600212E")]
			[Address(RVA = "0x100DE58", Offset = "0x100DE58", VA = "0x100DE58")]
			get
			{
				return null;
			}
			[Token(Token = "0x600212F")]
			[Address(RVA = "0x100DEC0", Offset = "0x100DEC0", VA = "0x100DEC0")]
			set
			{
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06002130 RID: 8496 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002131 RID: 8497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700047E")]
		public static Rain[] rain
		{
			[Token(Token = "0x6002130")]
			[Address(RVA = "0x100DF2C", Offset = "0x100DF2C", VA = "0x100DF2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002131")]
			[Address(RVA = "0x100DF94", Offset = "0x100DF94", VA = "0x100DF94")]
			set
			{
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x00010200 File Offset: 0x0000E400
		// (set) Token: 0x06002133 RID: 8499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700047F")]
		public static float startScreenYOffset
		{
			[Token(Token = "0x6002132")]
			[Address(RVA = "0x100E000", Offset = "0x100E000", VA = "0x100E000")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002133")]
			[Address(RVA = "0x100E068", Offset = "0x100E068", VA = "0x100E068")]
			set
			{
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x00010218 File Offset: 0x0000E418
		// (set) Token: 0x06002135 RID: 8501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000480")]
		public static float targetScreenYOffset
		{
			[Token(Token = "0x6002134")]
			[Address(RVA = "0x100E0D8", Offset = "0x100E0D8", VA = "0x100E0D8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002135")]
			[Address(RVA = "0x100E140", Offset = "0x100E140", VA = "0x100E140")]
			set
			{
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x00010230 File Offset: 0x0000E430
		// (set) Token: 0x06002137 RID: 8503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000481")]
		public static float screenYOffset
		{
			[Token(Token = "0x6002136")]
			[Address(RVA = "0x100E1B0", Offset = "0x100E1B0", VA = "0x100E1B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002137")]
			[Address(RVA = "0x100E218", Offset = "0x100E218", VA = "0x100E218")]
			set
			{
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x00010248 File Offset: 0x0000E448
		// (set) Token: 0x06002139 RID: 8505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000482")]
		public static float cameraOffset
		{
			[Token(Token = "0x6002138")]
			[Address(RVA = "0x100E288", Offset = "0x100E288", VA = "0x100E288")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002139")]
			[Address(RVA = "0x100E2F0", Offset = "0x100E2F0", VA = "0x100E2F0")]
			set
			{
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x00010260 File Offset: 0x0000E460
		// (set) Token: 0x0600213B RID: 8507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000483")]
		public static Vector2 screenPosition
		{
			[Token(Token = "0x600213A")]
			[Address(RVA = "0x100E360", Offset = "0x100E360", VA = "0x100E360")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600213B")]
			[Address(RVA = "0x100E3CC", Offset = "0x100E3CC", VA = "0x100E3CC")]
			set
			{
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x00010278 File Offset: 0x0000E478
		// (set) Token: 0x0600213D RID: 8509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000484")]
		public static Vector2 screenLastPosition
		{
			[Token(Token = "0x600213C")]
			[Address(RVA = "0x100E438", Offset = "0x100E438", VA = "0x100E438")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600213D")]
			[Address(RVA = "0x100E4A4", Offset = "0x100E4A4", VA = "0x100E4A4")]
			set
			{
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x00010290 File Offset: 0x0000E490
		// (set) Token: 0x0600213F RID: 8511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000485")]
		public static Vector2 screenLastCamPosition
		{
			[Token(Token = "0x600213E")]
			[Address(RVA = "0x100E510", Offset = "0x100E510", VA = "0x100E510")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600213F")]
			[Address(RVA = "0x100E57C", Offset = "0x100E57C", VA = "0x100E57C")]
			set
			{
			}
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x000102A8 File Offset: 0x0000E4A8
		[Token(Token = "0x6002140")]
		[Address(RVA = "0x100E5E8", Offset = "0x100E5E8", VA = "0x100E5E8")]
		public static Rectangle FullScreenRectWithEdge()
		{
			return default(Rectangle);
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x000102C0 File Offset: 0x0000E4C0
		// (set) Token: 0x06002142 RID: 8514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000486")]
		public static int screenWidth
		{
			[Token(Token = "0x6002141")]
			[Address(RVA = "0x100E718", Offset = "0x100E718", VA = "0x100E718")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002142")]
			[Address(RVA = "0x100E7E8", Offset = "0x100E7E8", VA = "0x100E7E8")]
			set
			{
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x000102D8 File Offset: 0x0000E4D8
		// (set) Token: 0x06002144 RID: 8516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000487")]
		public static int screenHeight
		{
			[Token(Token = "0x6002143")]
			[Address(RVA = "0x100E780", Offset = "0x100E780", VA = "0x100E780")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002144")]
			[Address(RVA = "0x100E854", Offset = "0x100E854", VA = "0x100E854")]
			set
			{
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x000102F0 File Offset: 0x0000E4F0
		// (set) Token: 0x06002146 RID: 8518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000488")]
		public static bool drawingPlayerChat
		{
			[Token(Token = "0x6002145")]
			[Address(RVA = "0x100E8C0", Offset = "0x100E8C0", VA = "0x100E8C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002146")]
			[Address(RVA = "0x100E928", Offset = "0x100E928", VA = "0x100E928")]
			set
			{
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x00010308 File Offset: 0x0000E508
		// (set) Token: 0x06002148 RID: 8520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000489")]
		public static bool chatRelease
		{
			[Token(Token = "0x6002147")]
			[Address(RVA = "0x100E994", Offset = "0x100E994", VA = "0x100E994")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002148")]
			[Address(RVA = "0x100E9FC", Offset = "0x100E9FC", VA = "0x100E9FC")]
			set
			{
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600214A RID: 8522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048A")]
		public static string chatText
		{
			[Token(Token = "0x6002149")]
			[Address(RVA = "0x100EA68", Offset = "0x100EA68", VA = "0x100EA68")]
			get
			{
				return null;
			}
			[Token(Token = "0x600214A")]
			[Address(RVA = "0x100EAD0", Offset = "0x100EAD0", VA = "0x100EAD0")]
			set
			{
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x00010320 File Offset: 0x0000E520
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048B")]
		public static bool inputTextEnter
		{
			[Token(Token = "0x600214B")]
			[Address(RVA = "0x100EB3C", Offset = "0x100EB3C", VA = "0x100EB3C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600214C")]
			[Address(RVA = "0x100EBA4", Offset = "0x100EBA4", VA = "0x100EBA4")]
			set
			{
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x00010338 File Offset: 0x0000E538
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048C")]
		public static bool inputTextEscape
		{
			[Token(Token = "0x600214D")]
			[Address(RVA = "0x100EC10", Offset = "0x100EC10", VA = "0x100EC10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600214E")]
			[Address(RVA = "0x100EC78", Offset = "0x100EC78", VA = "0x100EC78")]
			set
			{
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x00010350 File Offset: 0x0000E550
		// (set) Token: 0x06002150 RID: 8528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048D")]
		public static bool mouseLeftRelease
		{
			[Token(Token = "0x600214F")]
			[Address(RVA = "0x100ECE4", Offset = "0x100ECE4", VA = "0x100ECE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002150")]
			[Address(RVA = "0x100ED4C", Offset = "0x100ED4C", VA = "0x100ED4C")]
			set
			{
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x00010368 File Offset: 0x0000E568
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048E")]
		public static bool mouseRightRelease
		{
			[Token(Token = "0x6002151")]
			[Address(RVA = "0x100EDB8", Offset = "0x100EDB8", VA = "0x100EDB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002152")]
			[Address(RVA = "0x100EE20", Offset = "0x100EE20", VA = "0x100EE20")]
			set
			{
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x00010380 File Offset: 0x0000E580
		// (set) Token: 0x06002154 RID: 8532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048F")]
		public static bool playerInventory
		{
			[Token(Token = "0x6002153")]
			[Address(RVA = "0x100EE8C", Offset = "0x100EE8C", VA = "0x100EE8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002154")]
			[Address(RVA = "0x100EEF4", Offset = "0x100EEF4", VA = "0x100EEF4")]
			set
			{
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x00010398 File Offset: 0x0000E598
		// (set) Token: 0x06002156 RID: 8534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000490")]
		public static int stackSplit
		{
			[Token(Token = "0x6002155")]
			[Address(RVA = "0x100EF60", Offset = "0x100EF60", VA = "0x100EF60")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002156")]
			[Address(RVA = "0x100EFC8", Offset = "0x100EFC8", VA = "0x100EFC8")]
			set
			{
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x000103B0 File Offset: 0x0000E5B0
		// (set) Token: 0x06002158 RID: 8536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000491")]
		public static bool preventStackSplitReset
		{
			[Token(Token = "0x6002157")]
			[Address(RVA = "0x100F034", Offset = "0x100F034", VA = "0x100F034")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002158")]
			[Address(RVA = "0x100F09C", Offset = "0x100F09C", VA = "0x100F09C")]
			set
			{
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x000103C8 File Offset: 0x0000E5C8
		// (set) Token: 0x0600215A RID: 8538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000492")]
		public static int stackCounter
		{
			[Token(Token = "0x6002159")]
			[Address(RVA = "0x100F108", Offset = "0x100F108", VA = "0x100F108")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600215A")]
			[Address(RVA = "0x100F170", Offset = "0x100F170", VA = "0x100F170")]
			set
			{
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x000103E0 File Offset: 0x0000E5E0
		// (set) Token: 0x0600215C RID: 8540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000493")]
		public static int stackDelay
		{
			[Token(Token = "0x600215B")]
			[Address(RVA = "0x100F1DC", Offset = "0x100F1DC", VA = "0x100F1DC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600215C")]
			[Address(RVA = "0x100F244", Offset = "0x100F244", VA = "0x100F244")]
			set
			{
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x000103F8 File Offset: 0x0000E5F8
		// (set) Token: 0x0600215E RID: 8542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000494")]
		public static int superFastStack
		{
			[Token(Token = "0x600215D")]
			[Address(RVA = "0x100F2B0", Offset = "0x100F2B0", VA = "0x100F2B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600215E")]
			[Address(RVA = "0x100F318", Offset = "0x100F318", VA = "0x100F318")]
			set
			{
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x00010410 File Offset: 0x0000E610
		// (set) Token: 0x06002160 RID: 8544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000495")]
		public static int timesTriedToFastStack
		{
			[Token(Token = "0x600215F")]
			[Address(RVA = "0x100F384", Offset = "0x100F384", VA = "0x100F384")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002160")]
			[Address(RVA = "0x100F3EC", Offset = "0x100F3EC", VA = "0x100F3EC")]
			set
			{
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002162 RID: 8546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000496")]
		public static Item mouseItem
		{
			[Token(Token = "0x6002161")]
			[Address(RVA = "0x100F458", Offset = "0x100F458", VA = "0x100F458")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002162")]
			[Address(RVA = "0x100F4C0", Offset = "0x100F4C0", VA = "0x100F4C0")]
			set
			{
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x00010428 File Offset: 0x0000E628
		// (set) Token: 0x06002164 RID: 8548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000497")]
		public static float mouseItemTime
		{
			[Token(Token = "0x6002163")]
			[Address(RVA = "0x100F52C", Offset = "0x100F52C", VA = "0x100F52C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002164")]
			[Address(RVA = "0x100F594", Offset = "0x100F594", VA = "0x100F594")]
			set
			{
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002166 RID: 8550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000498")]
		public static Item[] mouseItemSource
		{
			[Token(Token = "0x6002165")]
			[Address(RVA = "0x100F604", Offset = "0x100F604", VA = "0x100F604")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002166")]
			[Address(RVA = "0x100F66C", Offset = "0x100F66C", VA = "0x100F66C")]
			set
			{
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x00010440 File Offset: 0x0000E640
		// (set) Token: 0x06002168 RID: 8552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000499")]
		public static int mouseItemSourceIndex
		{
			[Token(Token = "0x6002167")]
			[Address(RVA = "0x100F6D8", Offset = "0x100F6D8", VA = "0x100F6D8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002168")]
			[Address(RVA = "0x100F740", Offset = "0x100F740", VA = "0x100F740")]
			set
			{
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x00010458 File Offset: 0x0000E658
		// (set) Token: 0x0600216A RID: 8554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049A")]
		public static int mouseItemSourceContext
		{
			[Token(Token = "0x6002169")]
			[Address(RVA = "0x100F7AC", Offset = "0x100F7AC", VA = "0x100F7AC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600216A")]
			[Address(RVA = "0x100F814", Offset = "0x100F814", VA = "0x100F814")]
			set
			{
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600216C RID: 8556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049B")]
		public static Item guideItem
		{
			[Token(Token = "0x600216B")]
			[Address(RVA = "0x100F880", Offset = "0x100F880", VA = "0x100F880")]
			get
			{
				return null;
			}
			[Token(Token = "0x600216C")]
			[Address(RVA = "0x100F8E8", Offset = "0x100F8E8", VA = "0x100F8E8")]
			set
			{
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600216E RID: 8558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049C")]
		public static Item reforgeItem
		{
			[Token(Token = "0x600216D")]
			[Address(RVA = "0x100F954", Offset = "0x100F954", VA = "0x100F954")]
			get
			{
				return null;
			}
			[Token(Token = "0x600216E")]
			[Address(RVA = "0x100F9BC", Offset = "0x100F9BC", VA = "0x100F9BC")]
			set
			{
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x00010470 File Offset: 0x0000E670
		// (set) Token: 0x06002170 RID: 8560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049D")]
		public static float inventoryScale
		{
			[Token(Token = "0x600216F")]
			[Address(RVA = "0x100FA28", Offset = "0x100FA28", VA = "0x100FA28")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002170")]
			[Address(RVA = "0x100FA90", Offset = "0x100FA90", VA = "0x100FA90")]
			set
			{
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06002171 RID: 8561 RVA: 0x00010488 File Offset: 0x0000E688
		// (set) Token: 0x06002172 RID: 8562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049E")]
		public static Point rulerLineDisplayValues
		{
			[Token(Token = "0x6002171")]
			[Address(RVA = "0x100FB00", Offset = "0x100FB00", VA = "0x100FB00")]
			get
			{
				return default(Point);
			}
			[Token(Token = "0x6002172")]
			[Address(RVA = "0x100FB6C", Offset = "0x100FB6C", VA = "0x100FB6C")]
			set
			{
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002174 RID: 8564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049F")]
		public static int[] availableRecipe
		{
			[Token(Token = "0x6002173")]
			[Address(RVA = "0x100FBD8", Offset = "0x100FBD8", VA = "0x100FBD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002174")]
			[Address(RVA = "0x100FC40", Offset = "0x100FC40", VA = "0x100FC40")]
			set
			{
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x000104A0 File Offset: 0x0000E6A0
		// (set) Token: 0x06002176 RID: 8566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A0")]
		public static int lastRecipeUpdateId
		{
			[Token(Token = "0x6002175")]
			[Address(RVA = "0x100FCAC", Offset = "0x100FCAC", VA = "0x100FCAC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002176")]
			[Address(RVA = "0x100FD14", Offset = "0x100FD14", VA = "0x100FD14")]
			set
			{
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x000104B8 File Offset: 0x0000E6B8
		// (set) Token: 0x06002178 RID: 8568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A1")]
		public static int numAvailableRecipes
		{
			[Token(Token = "0x6002177")]
			[Address(RVA = "0x100FD80", Offset = "0x100FD80", VA = "0x100FD80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002178")]
			[Address(RVA = "0x100FDE8", Offset = "0x100FDE8", VA = "0x100FDE8")]
			set
			{
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x000104D0 File Offset: 0x0000E6D0
		// (set) Token: 0x0600217A RID: 8570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A2")]
		public static int focusRecipe
		{
			[Token(Token = "0x6002179")]
			[Address(RVA = "0x100FE54", Offset = "0x100FE54", VA = "0x100FE54")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600217A")]
			[Address(RVA = "0x100FEBC", Offset = "0x100FEBC", VA = "0x100FEBC")]
			set
			{
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x0600217B RID: 8571 RVA: 0x000104E8 File Offset: 0x0000E6E8
		// (set) Token: 0x0600217C RID: 8572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A3")]
		public static int myPlayer
		{
			[Token(Token = "0x600217B")]
			[Address(RVA = "0x100FF28", Offset = "0x100FF28", VA = "0x100FF28")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600217C")]
			[Address(RVA = "0x100FF90", Offset = "0x100FF90", VA = "0x100FF90")]
			set
			{
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x0600217D RID: 8573 RVA: 0x00010500 File Offset: 0x0000E700
		// (set) Token: 0x0600217E RID: 8574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A4")]
		public static int spawnTileX
		{
			[Token(Token = "0x600217D")]
			[Address(RVA = "0x100FFFC", Offset = "0x100FFFC", VA = "0x100FFFC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600217E")]
			[Address(RVA = "0x1010064", Offset = "0x1010064", VA = "0x1010064")]
			set
			{
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x00010518 File Offset: 0x0000E718
		// (set) Token: 0x06002180 RID: 8576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A5")]
		public static int spawnTileY
		{
			[Token(Token = "0x600217F")]
			[Address(RVA = "0x10100D0", Offset = "0x10100D0", VA = "0x10100D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002180")]
			[Address(RVA = "0x1010138", Offset = "0x1010138", VA = "0x1010138")]
			set
			{
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06002181 RID: 8577 RVA: 0x00010530 File Offset: 0x0000E730
		// (set) Token: 0x06002182 RID: 8578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A6")]
		public static bool npcChatRelease
		{
			[Token(Token = "0x6002181")]
			[Address(RVA = "0x10101A4", Offset = "0x10101A4", VA = "0x10101A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002182")]
			[Address(RVA = "0x101020C", Offset = "0x101020C", VA = "0x101020C")]
			set
			{
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x00010548 File Offset: 0x0000E748
		// (set) Token: 0x06002184 RID: 8580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A7")]
		public static bool editSign
		{
			[Token(Token = "0x6002183")]
			[Address(RVA = "0x1010278", Offset = "0x1010278", VA = "0x1010278")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002184")]
			[Address(RVA = "0x10102E0", Offset = "0x10102E0", VA = "0x10102E0")]
			set
			{
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06002185 RID: 8581 RVA: 0x00010560 File Offset: 0x0000E760
		// (set) Token: 0x06002186 RID: 8582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A8")]
		public static bool editChest
		{
			[Token(Token = "0x6002185")]
			[Address(RVA = "0x101034C", Offset = "0x101034C", VA = "0x101034C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002186")]
			[Address(RVA = "0x10103B4", Offset = "0x10103B4", VA = "0x10103B4")]
			set
			{
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06002187 RID: 8583 RVA: 0x00010578 File Offset: 0x0000E778
		// (set) Token: 0x06002188 RID: 8584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A9")]
		public static bool blockInput
		{
			[Token(Token = "0x6002187")]
			[Address(RVA = "0x1010420", Offset = "0x1010420", VA = "0x1010420")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002188")]
			[Address(RVA = "0x1010488", Offset = "0x1010488", VA = "0x1010488")]
			set
			{
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06002189 RID: 8585 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600218A RID: 8586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AA")]
		public static string blockKey
		{
			[Token(Token = "0x6002189")]
			[Address(RVA = "0x10104F4", Offset = "0x10104F4", VA = "0x10104F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600218A")]
			[Address(RVA = "0x101055C", Offset = "0x101055C", VA = "0x101055C")]
			set
			{
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600218B RID: 8587 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600218C RID: 8588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AB")]
		public static string defaultChestName
		{
			[Token(Token = "0x600218B")]
			[Address(RVA = "0x10105C8", Offset = "0x10105C8", VA = "0x10105C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600218C")]
			[Address(RVA = "0x1010630", Offset = "0x1010630", VA = "0x1010630")]
			set
			{
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600218D RID: 8589 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600218E RID: 8590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AC")]
		public static string npcChatText
		{
			[Token(Token = "0x600218D")]
			[Address(RVA = "0x101069C", Offset = "0x101069C", VA = "0x101069C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600218E")]
			[Address(RVA = "0x1010704", Offset = "0x1010704", VA = "0x1010704")]
			set
			{
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600218F RID: 8591 RVA: 0x00010590 File Offset: 0x0000E790
		// (set) Token: 0x06002190 RID: 8592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AD")]
		public static bool npcChatFocus1
		{
			[Token(Token = "0x600218F")]
			[Address(RVA = "0x10107B0", Offset = "0x10107B0", VA = "0x10107B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002190")]
			[Address(RVA = "0x1010818", Offset = "0x1010818", VA = "0x1010818")]
			set
			{
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06002191 RID: 8593 RVA: 0x000105A8 File Offset: 0x0000E7A8
		// (set) Token: 0x06002192 RID: 8594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AE")]
		public static bool npcChatFocus2
		{
			[Token(Token = "0x6002191")]
			[Address(RVA = "0x1010884", Offset = "0x1010884", VA = "0x1010884")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002192")]
			[Address(RVA = "0x10108EC", Offset = "0x10108EC", VA = "0x10108EC")]
			set
			{
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x000105C0 File Offset: 0x0000E7C0
		// (set) Token: 0x06002194 RID: 8596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AF")]
		public static bool npcChatFocus3
		{
			[Token(Token = "0x6002193")]
			[Address(RVA = "0x1010958", Offset = "0x1010958", VA = "0x1010958")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002194")]
			[Address(RVA = "0x10109C0", Offset = "0x10109C0", VA = "0x10109C0")]
			set
			{
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x000105D8 File Offset: 0x0000E7D8
		// (set) Token: 0x06002196 RID: 8598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B0")]
		public static bool npcChatFocus4
		{
			[Token(Token = "0x6002195")]
			[Address(RVA = "0x1010A2C", Offset = "0x1010A2C", VA = "0x1010A2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002196")]
			[Address(RVA = "0x1010A94", Offset = "0x1010A94", VA = "0x1010A94")]
			set
			{
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06002197 RID: 8599 RVA: 0x000105F0 File Offset: 0x0000E7F0
		// (set) Token: 0x06002198 RID: 8600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B1")]
		public static int oldNPCShop
		{
			[Token(Token = "0x6002197")]
			[Address(RVA = "0x1010B00", Offset = "0x1010B00", VA = "0x1010B00")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002198")]
			[Address(RVA = "0x1010B68", Offset = "0x1010B68", VA = "0x1010B68")]
			set
			{
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06002199 RID: 8601 RVA: 0x00010608 File Offset: 0x0000E808
		// (set) Token: 0x0600219A RID: 8602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B2")]
		public static int npcShop
		{
			[Token(Token = "0x6002199")]
			[Address(RVA = "0x1010BD4", Offset = "0x1010BD4", VA = "0x1010BD4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600219A")]
			[Address(RVA = "0x1010C3C", Offset = "0x1010C3C", VA = "0x1010C3C")]
			set
			{
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600219B RID: 8603 RVA: 0x00010620 File Offset: 0x0000E820
		// (set) Token: 0x0600219C RID: 8604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B3")]
		public static int npcChatCornerItem
		{
			[Token(Token = "0x600219B")]
			[Address(RVA = "0x1010CA8", Offset = "0x1010CA8", VA = "0x1010CA8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600219C")]
			[Address(RVA = "0x1010D10", Offset = "0x1010D10", VA = "0x1010D10")]
			set
			{
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600219E RID: 8606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B4")]
		public static NPCID.Sets.NPCPortraitProvider npcChatPortrait
		{
			[Token(Token = "0x600219D")]
			[Address(RVA = "0x1010D7C", Offset = "0x1010D7C", VA = "0x1010D7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600219E")]
			[Address(RVA = "0x1010DE4", Offset = "0x1010DE4", VA = "0x1010DE4")]
			set
			{
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600219F RID: 8607 RVA: 0x00010638 File Offset: 0x0000E838
		// (set) Token: 0x060021A0 RID: 8608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B5")]
		public static DateTime npcChatPortraitFrameCounter
		{
			[Token(Token = "0x600219F")]
			[Address(RVA = "0x1010E50", Offset = "0x1010E50", VA = "0x1010E50")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60021A0")]
			[Address(RVA = "0x1010EBC", Offset = "0x1010EBC", VA = "0x1010EBC")]
			set
			{
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060021A1 RID: 8609 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021A2 RID: 8610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B6")]
		public InventoryStorage[] shop
		{
			[Token(Token = "0x60021A1")]
			[Address(RVA = "0x1010F28", Offset = "0x1010F28", VA = "0x1010F28")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021A2")]
			[Address(RVA = "0x1010F90", Offset = "0x1010F90", VA = "0x1010F90")]
			set
			{
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021A4 RID: 8612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B7")]
		public static ItemShopSellbackHelper shopSellbackHelper
		{
			[Token(Token = "0x60021A3")]
			[Address(RVA = "0x1010FFC", Offset = "0x1010FFC", VA = "0x1010FFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021A4")]
			[Address(RVA = "0x1011064", Offset = "0x1011064", VA = "0x1011064")]
			set
			{
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060021A5 RID: 8613 RVA: 0x00010650 File Offset: 0x0000E850
		// (set) Token: 0x060021A6 RID: 8614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B8")]
		public static bool anglerQuestFinished
		{
			[Token(Token = "0x60021A5")]
			[Address(RVA = "0x10110D0", Offset = "0x10110D0", VA = "0x10110D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021A6")]
			[Address(RVA = "0x1011138", Offset = "0x1011138", VA = "0x1011138")]
			set
			{
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021A8 RID: 8616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B9")]
		public static GolfState LocalGolfState
		{
			[Token(Token = "0x60021A7")]
			[Address(RVA = "0x10111A4", Offset = "0x10111A4", VA = "0x10111A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021A8")]
			[Address(RVA = "0x101120C", Offset = "0x101120C", VA = "0x101120C")]
			set
			{
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021AA RID: 8618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BA")]
		public static DroneCameraTracker DroneCameraTracker
		{
			[Token(Token = "0x60021A9")]
			[Address(RVA = "0x1011278", Offset = "0x1011278", VA = "0x1011278")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021AA")]
			[Address(RVA = "0x10112E0", Offset = "0x10112E0", VA = "0x10112E0")]
			set
			{
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x00010668 File Offset: 0x0000E868
		// (set) Token: 0x060021AC RID: 8620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BB")]
		public static bool InGuideCraftMenu
		{
			[Token(Token = "0x60021AB")]
			[Address(RVA = "0x101134C", Offset = "0x101134C", VA = "0x101134C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021AC")]
			[Address(RVA = "0x10113B4", Offset = "0x10113B4", VA = "0x10113B4")]
			set
			{
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x00010680 File Offset: 0x0000E880
		// (set) Token: 0x060021AE RID: 8622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BC")]
		public static bool InReforgeMenu
		{
			[Token(Token = "0x60021AD")]
			[Address(RVA = "0x1011420", Offset = "0x1011420", VA = "0x1011420")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021AE")]
			[Address(RVA = "0x1011488", Offset = "0x1011488", VA = "0x1011488")]
			set
			{
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x00010698 File Offset: 0x0000E898
		// (set) Token: 0x060021B0 RID: 8624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BD")]
		public static bool gameMenu
		{
			[Token(Token = "0x60021AF")]
			[Address(RVA = "0x10114F4", Offset = "0x10114F4", VA = "0x10114F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021B0")]
			[Address(RVA = "0x101155C", Offset = "0x101155C", VA = "0x101155C")]
			set
			{
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021B2 RID: 8626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BE")]
		public static List<PlayerFileData> PreviousPlayerList
		{
			[Token(Token = "0x60021B1")]
			[Address(RVA = "0x10115C8", Offset = "0x10115C8", VA = "0x10115C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021B2")]
			[Address(RVA = "0x1011630", Offset = "0x1011630", VA = "0x1011630")]
			set
			{
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021B4 RID: 8628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BF")]
		public static List<PlayerFileData> PlayerList
		{
			[Token(Token = "0x60021B3")]
			[Address(RVA = "0x101169C", Offset = "0x101169C", VA = "0x101169C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021B4")]
			[Address(RVA = "0x1011704", Offset = "0x1011704", VA = "0x1011704")]
			set
			{
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021B6 RID: 8630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C0")]
		public static PlayerFileData ActivePlayerFileData
		{
			[Token(Token = "0x60021B5")]
			[Address(RVA = "0x1011770", Offset = "0x1011770", VA = "0x1011770")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021B6")]
			[Address(RVA = "0x10117D8", Offset = "0x10117D8", VA = "0x10117D8")]
			set
			{
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021B8 RID: 8632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C1")]
		public static Player PendingPlayer
		{
			[Token(Token = "0x60021B7")]
			[Address(RVA = "0x1011844", Offset = "0x1011844", VA = "0x1011844")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021B8")]
			[Address(RVA = "0x10118AC", Offset = "0x10118AC", VA = "0x10118AC")]
			set
			{
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C2")]
		public static string WorldPath
		{
			[Token(Token = "0x60021B9")]
			[Address(RVA = "0x1011918", Offset = "0x1011918", VA = "0x1011918")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C3")]
		public static string PlayerPath
		{
			[Token(Token = "0x60021BA")]
			[Address(RVA = "0x1011FD4", Offset = "0x1011FD4", VA = "0x1011FD4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C4")]
		public static string OldPlayerPath
		{
			[Token(Token = "0x60021BB")]
			[Address(RVA = "0x1012090", Offset = "0x1012090", VA = "0x1012090")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060021BC RID: 8636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C5")]
		public static string OldWorldPath
		{
			[Token(Token = "0x60021BC")]
			[Address(RVA = "0x1012308", Offset = "0x1012308", VA = "0x1012308")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021BE RID: 8638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C6")]
		private static Preferences _configuration
		{
			[Token(Token = "0x60021BD")]
			[Address(RVA = "0x10123DC", Offset = "0x10123DC", VA = "0x10123DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021BE")]
			[Address(RVA = "0x1012444", Offset = "0x1012444", VA = "0x1012444")]
			set
			{
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C7")]
		public static Preferences Configuration
		{
			[Token(Token = "0x60021BF")]
			[Address(RVA = "0x10124B0", Offset = "0x10124B0", VA = "0x10124B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021C1 RID: 8641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C8")]
		private static Preferences _inputProfiles
		{
			[Token(Token = "0x60021C0")]
			[Address(RVA = "0x1012734", Offset = "0x1012734", VA = "0x1012734")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021C1")]
			[Address(RVA = "0x101279C", Offset = "0x101279C", VA = "0x101279C")]
			set
			{
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C9")]
		public static Preferences InputProfiles
		{
			[Token(Token = "0x60021C2")]
			[Address(RVA = "0x1012808", Offset = "0x1012808", VA = "0x1012808")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x000106B0 File Offset: 0x0000E8B0
		// (set) Token: 0x060021C4 RID: 8644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CA")]
		public static bool invasionProgressNearInvasion
		{
			[Token(Token = "0x60021C3")]
			[Address(RVA = "0x1012A8C", Offset = "0x1012A8C", VA = "0x1012A8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021C4")]
			[Address(RVA = "0x1012AF4", Offset = "0x1012AF4", VA = "0x1012AF4")]
			set
			{
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x000106C8 File Offset: 0x0000E8C8
		// (set) Token: 0x060021C6 RID: 8646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CB")]
		public static int invasionProgressMode
		{
			[Token(Token = "0x60021C5")]
			[Address(RVA = "0x1012B60", Offset = "0x1012B60", VA = "0x1012B60")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021C6")]
			[Address(RVA = "0x1012BC8", Offset = "0x1012BC8", VA = "0x1012BC8")]
			set
			{
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x000106E0 File Offset: 0x0000E8E0
		// (set) Token: 0x060021C8 RID: 8648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CC")]
		public static bool HasInteractableObjectThatIsNotATile
		{
			[Token(Token = "0x60021C7")]
			[Address(RVA = "0x1012C34", Offset = "0x1012C34", VA = "0x1012C34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021C8")]
			[Address(RVA = "0x1012C9C", Offset = "0x1012C9C", VA = "0x1012C9C")]
			set
			{
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x000106F8 File Offset: 0x0000E8F8
		// (set) Token: 0x060021CA RID: 8650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CD")]
		public static bool cSmartCursorModeIsToggleAndNotHold
		{
			[Token(Token = "0x60021C9")]
			[Address(RVA = "0x1012D08", Offset = "0x1012D08", VA = "0x1012D08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021CA")]
			[Address(RVA = "0x1012D70", Offset = "0x1012D70", VA = "0x1012D70")]
			set
			{
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x00010710 File Offset: 0x0000E910
		// (set) Token: 0x060021CC RID: 8652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CE")]
		public static bool SmartCursorShowing
		{
			[Token(Token = "0x60021CB")]
			[Address(RVA = "0x1012DDC", Offset = "0x1012DDC", VA = "0x1012DDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021CC")]
			[Address(RVA = "0x1012E44", Offset = "0x1012E44", VA = "0x1012E44")]
			set
			{
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x00010728 File Offset: 0x0000E928
		// (set) Token: 0x060021CE RID: 8654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CF")]
		public static int SmartCursorX
		{
			[Token(Token = "0x60021CD")]
			[Address(RVA = "0x1012EB0", Offset = "0x1012EB0", VA = "0x1012EB0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021CE")]
			[Address(RVA = "0x1012F18", Offset = "0x1012F18", VA = "0x1012F18")]
			set
			{
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x00010740 File Offset: 0x0000E940
		// (set) Token: 0x060021D0 RID: 8656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D0")]
		public static int SmartCursorY
		{
			[Token(Token = "0x60021CF")]
			[Address(RVA = "0x1012F84", Offset = "0x1012F84", VA = "0x1012F84")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021D0")]
			[Address(RVA = "0x1012FEC", Offset = "0x1012FEC", VA = "0x1012FEC")]
			set
			{
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x00010758 File Offset: 0x0000E958
		// (set) Token: 0x060021D2 RID: 8658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D1")]
		public static bool SmartInteractShowingGenuine
		{
			[Token(Token = "0x60021D1")]
			[Address(RVA = "0x1013058", Offset = "0x1013058", VA = "0x1013058")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021D2")]
			[Address(RVA = "0x10130C0", Offset = "0x10130C0", VA = "0x10130C0")]
			set
			{
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x00010770 File Offset: 0x0000E970
		// (set) Token: 0x060021D4 RID: 8660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D2")]
		public static bool SmartInteractShowingFake
		{
			[Token(Token = "0x60021D3")]
			[Address(RVA = "0x101312C", Offset = "0x101312C", VA = "0x101312C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021D4")]
			[Address(RVA = "0x1013194", Offset = "0x1013194", VA = "0x1013194")]
			set
			{
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x00010788 File Offset: 0x0000E988
		// (set) Token: 0x060021D6 RID: 8662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D3")]
		public static int SmartInteractX
		{
			[Token(Token = "0x60021D5")]
			[Address(RVA = "0x1013200", Offset = "0x1013200", VA = "0x1013200")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021D6")]
			[Address(RVA = "0x1013268", Offset = "0x1013268", VA = "0x1013268")]
			set
			{
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x000107A0 File Offset: 0x0000E9A0
		// (set) Token: 0x060021D8 RID: 8664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D4")]
		public static int SmartInteractY
		{
			[Token(Token = "0x60021D7")]
			[Address(RVA = "0x10132D4", Offset = "0x10132D4", VA = "0x10132D4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021D8")]
			[Address(RVA = "0x101333C", Offset = "0x101333C", VA = "0x101333C")]
			set
			{
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x000107B8 File Offset: 0x0000E9B8
		// (set) Token: 0x060021DA RID: 8666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D5")]
		public static int SmartInteractNPC
		{
			[Token(Token = "0x60021D9")]
			[Address(RVA = "0x10133A8", Offset = "0x10133A8", VA = "0x10133A8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021DA")]
			[Address(RVA = "0x1013410", Offset = "0x1013410", VA = "0x1013410")]
			set
			{
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x000107D0 File Offset: 0x0000E9D0
		// (set) Token: 0x060021DC RID: 8668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D6")]
		public static int SmartInteractProj
		{
			[Token(Token = "0x60021DB")]
			[Address(RVA = "0x101347C", Offset = "0x101347C", VA = "0x101347C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021DC")]
			[Address(RVA = "0x10134E4", Offset = "0x10134E4", VA = "0x10134E4")]
			set
			{
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x000107E8 File Offset: 0x0000E9E8
		// (set) Token: 0x060021DE RID: 8670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D7")]
		public static bool SmartInteractPotionOfReturn
		{
			[Token(Token = "0x60021DD")]
			[Address(RVA = "0x1013550", Offset = "0x1013550", VA = "0x1013550")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021DE")]
			[Address(RVA = "0x10135B8", Offset = "0x10135B8", VA = "0x10135B8")]
			set
			{
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x00010800 File Offset: 0x0000EA00
		// (set) Token: 0x060021E0 RID: 8672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D8")]
		public static int SmartInteractTileCoordsCount
		{
			[Token(Token = "0x60021DF")]
			[Address(RVA = "0x1013624", Offset = "0x1013624", VA = "0x1013624")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021E0")]
			[Address(RVA = "0x101368C", Offset = "0x101368C", VA = "0x101368C")]
			set
			{
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021E2 RID: 8674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D9")]
		public static Dictionary<int, bool> SmartInteractTileCoordsSelected
		{
			[Token(Token = "0x60021E1")]
			[Address(RVA = "0x10136F8", Offset = "0x10136F8", VA = "0x10136F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021E2")]
			[Address(RVA = "0x1013760", Offset = "0x1013760", VA = "0x1013760")]
			set
			{
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x00010818 File Offset: 0x0000EA18
		// (set) Token: 0x060021E4 RID: 8676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DA")]
		public static int TileInteractionLX
		{
			[Token(Token = "0x60021E3")]
			[Address(RVA = "0x10137CC", Offset = "0x10137CC", VA = "0x10137CC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021E4")]
			[Address(RVA = "0x1013834", Offset = "0x1013834", VA = "0x1013834")]
			set
			{
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060021E5 RID: 8677 RVA: 0x00010830 File Offset: 0x0000EA30
		// (set) Token: 0x060021E6 RID: 8678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DB")]
		public static int TileInteractionLY
		{
			[Token(Token = "0x60021E5")]
			[Address(RVA = "0x10138A0", Offset = "0x10138A0", VA = "0x10138A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021E6")]
			[Address(RVA = "0x1013908", Offset = "0x1013908", VA = "0x1013908")]
			set
			{
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060021E7 RID: 8679 RVA: 0x00010848 File Offset: 0x0000EA48
		// (set) Token: 0x060021E8 RID: 8680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DC")]
		public static int TileInteractionHX
		{
			[Token(Token = "0x60021E7")]
			[Address(RVA = "0x1013974", Offset = "0x1013974", VA = "0x1013974")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021E8")]
			[Address(RVA = "0x10139DC", Offset = "0x10139DC", VA = "0x10139DC")]
			set
			{
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060021E9 RID: 8681 RVA: 0x00010860 File Offset: 0x0000EA60
		// (set) Token: 0x060021EA RID: 8682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DD")]
		public static int lxAimCursorRegion
		{
			[Token(Token = "0x60021E9")]
			[Address(RVA = "0x1013A48", Offset = "0x1013A48", VA = "0x1013A48")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021EA")]
			[Address(RVA = "0x1013AB0", Offset = "0x1013AB0", VA = "0x1013AB0")]
			set
			{
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060021EB RID: 8683 RVA: 0x00010878 File Offset: 0x0000EA78
		// (set) Token: 0x060021EC RID: 8684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DE")]
		public static int hxAimCursorRegion
		{
			[Token(Token = "0x60021EB")]
			[Address(RVA = "0x1013B1C", Offset = "0x1013B1C", VA = "0x1013B1C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021EC")]
			[Address(RVA = "0x1013B84", Offset = "0x1013B84", VA = "0x1013B84")]
			set
			{
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060021ED RID: 8685 RVA: 0x00010890 File Offset: 0x0000EA90
		// (set) Token: 0x060021EE RID: 8686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DF")]
		public static int lyAimCursorRegion
		{
			[Token(Token = "0x60021ED")]
			[Address(RVA = "0x1013BF0", Offset = "0x1013BF0", VA = "0x1013BF0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021EE")]
			[Address(RVA = "0x1013C58", Offset = "0x1013C58", VA = "0x1013C58")]
			set
			{
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060021EF RID: 8687 RVA: 0x000108A8 File Offset: 0x0000EAA8
		// (set) Token: 0x060021F0 RID: 8688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E0")]
		public static int hyAimCursorRegion
		{
			[Token(Token = "0x60021EF")]
			[Address(RVA = "0x1013CC4", Offset = "0x1013CC4", VA = "0x1013CC4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021F0")]
			[Address(RVA = "0x1013D2C", Offset = "0x1013D2C", VA = "0x1013D2C")]
			set
			{
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060021F1 RID: 8689 RVA: 0x000108C0 File Offset: 0x0000EAC0
		// (set) Token: 0x060021F2 RID: 8690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E1")]
		public static int AimCursorRegionFrame
		{
			[Token(Token = "0x60021F1")]
			[Address(RVA = "0x1013D98", Offset = "0x1013D98", VA = "0x1013D98")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021F2")]
			[Address(RVA = "0x1013E00", Offset = "0x1013E00", VA = "0x1013E00")]
			set
			{
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060021F3 RID: 8691 RVA: 0x000108D8 File Offset: 0x0000EAD8
		// (set) Token: 0x060021F4 RID: 8692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E2")]
		public static int TileInteractionHY
		{
			[Token(Token = "0x60021F3")]
			[Address(RVA = "0x1013E6C", Offset = "0x1013E6C", VA = "0x1013E6C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021F4")]
			[Address(RVA = "0x1013ED4", Offset = "0x1013ED4", VA = "0x1013ED4")]
			set
			{
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060021F5 RID: 8693 RVA: 0x000108F0 File Offset: 0x0000EAF0
		// (set) Token: 0x060021F6 RID: 8694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E3")]
		public static int cursorOverride
		{
			[Token(Token = "0x60021F5")]
			[Address(RVA = "0x1013F40", Offset = "0x1013F40", VA = "0x1013F40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021F6")]
			[Address(RVA = "0x1013FA8", Offset = "0x1013FA8", VA = "0x1013FA8")]
			set
			{
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x00010908 File Offset: 0x0000EB08
		// (set) Token: 0x060021F8 RID: 8696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E4")]
		public static int signHover
		{
			[Token(Token = "0x60021F7")]
			[Address(RVA = "0x1014014", Offset = "0x1014014", VA = "0x1014014")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021F8")]
			[Address(RVA = "0x101407C", Offset = "0x101407C", VA = "0x101407C")]
			set
			{
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x00010920 File Offset: 0x0000EB20
		// (set) Token: 0x060021FA RID: 8698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E5")]
		public static int lastSignHover
		{
			[Token(Token = "0x60021F9")]
			[Address(RVA = "0x10140E8", Offset = "0x10140E8", VA = "0x10140E8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021FA")]
			[Address(RVA = "0x1014150", Offset = "0x1014150", VA = "0x1014150")]
			set
			{
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060021FB RID: 8699 RVA: 0x00010938 File Offset: 0x0000EB38
		// (set) Token: 0x060021FC RID: 8700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E6")]
		public static Color mouseColor
		{
			[Token(Token = "0x60021FB")]
			[Address(RVA = "0x10141BC", Offset = "0x10141BC", VA = "0x10141BC")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60021FC")]
			[Address(RVA = "0x1014224", Offset = "0x1014224", VA = "0x1014224")]
			set
			{
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x00010950 File Offset: 0x0000EB50
		// (set) Token: 0x060021FE RID: 8702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E7")]
		public static Color ControllerColor
		{
			[Token(Token = "0x60021FD")]
			[Address(RVA = "0x1014290", Offset = "0x1014290", VA = "0x1014290")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60021FE")]
			[Address(RVA = "0x10142F8", Offset = "0x10142F8", VA = "0x10142F8")]
			set
			{
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x00010968 File Offset: 0x0000EB68
		// (set) Token: 0x06002200 RID: 8704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E8")]
		public static Color ControllerBorderColor
		{
			[Token(Token = "0x60021FF")]
			[Address(RVA = "0x1014364", Offset = "0x1014364", VA = "0x1014364")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6002200")]
			[Address(RVA = "0x10143CC", Offset = "0x10143CC", VA = "0x10143CC")]
			set
			{
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x00010980 File Offset: 0x0000EB80
		// (set) Token: 0x06002202 RID: 8706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E9")]
		public static Color MouseBorderColor
		{
			[Token(Token = "0x6002201")]
			[Address(RVA = "0x1014438", Offset = "0x1014438", VA = "0x1014438")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6002202")]
			[Address(RVA = "0x10144A0", Offset = "0x10144A0", VA = "0x10144A0")]
			set
			{
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x00010998 File Offset: 0x0000EB98
		// (set) Token: 0x06002204 RID: 8708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EA")]
		public static Color cursorColor
		{
			[Token(Token = "0x6002203")]
			[Address(RVA = "0x101450C", Offset = "0x101450C", VA = "0x101450C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6002204")]
			[Address(RVA = "0x1014574", Offset = "0x1014574", VA = "0x1014574")]
			set
			{
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x000109B0 File Offset: 0x0000EBB0
		// (set) Token: 0x06002206 RID: 8710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EB")]
		public static int cursorColorDirection
		{
			[Token(Token = "0x6002205")]
			[Address(RVA = "0x10145E0", Offset = "0x10145E0", VA = "0x10145E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002206")]
			[Address(RVA = "0x1014648", Offset = "0x1014648", VA = "0x1014648")]
			set
			{
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x000109C8 File Offset: 0x0000EBC8
		// (set) Token: 0x06002208 RID: 8712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EC")]
		public static float cursorAlpha
		{
			[Token(Token = "0x6002207")]
			[Address(RVA = "0x10146B4", Offset = "0x10146B4", VA = "0x10146B4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002208")]
			[Address(RVA = "0x101471C", Offset = "0x101471C", VA = "0x101471C")]
			set
			{
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x000109E0 File Offset: 0x0000EBE0
		// (set) Token: 0x0600220A RID: 8714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004ED")]
		public static float cursorScale
		{
			[Token(Token = "0x6002209")]
			[Address(RVA = "0x101478C", Offset = "0x101478C", VA = "0x101478C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600220A")]
			[Address(RVA = "0x10147F4", Offset = "0x10147F4", VA = "0x10147F4")]
			set
			{
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x000109F8 File Offset: 0x0000EBF8
		// (set) Token: 0x0600220C RID: 8716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EE")]
		public static bool signBubble
		{
			[Token(Token = "0x600220B")]
			[Address(RVA = "0x1014864", Offset = "0x1014864", VA = "0x1014864")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600220C")]
			[Address(RVA = "0x10148CC", Offset = "0x10148CC", VA = "0x10148CC")]
			set
			{
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x00010A10 File Offset: 0x0000EC10
		// (set) Token: 0x0600220E RID: 8718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EF")]
		public static int signX
		{
			[Token(Token = "0x600220D")]
			[Address(RVA = "0x1014938", Offset = "0x1014938", VA = "0x1014938")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600220E")]
			[Address(RVA = "0x10149A0", Offset = "0x10149A0", VA = "0x10149A0")]
			set
			{
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x00010A28 File Offset: 0x0000EC28
		// (set) Token: 0x06002210 RID: 8720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F0")]
		public static int signY
		{
			[Token(Token = "0x600220F")]
			[Address(RVA = "0x1014A0C", Offset = "0x1014A0C", VA = "0x1014A0C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002210")]
			[Address(RVA = "0x1014A74", Offset = "0x1014A74", VA = "0x1014A74")]
			set
			{
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06002211 RID: 8721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004F1")]
		public static ParticleRenderer ParticleSystem_HousingQuery
		{
			[Token(Token = "0x6002211")]
			[Address(RVA = "0x1014AE0", Offset = "0x1014AE0", VA = "0x1014AE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06002212 RID: 8722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004F2")]
		public static ParticleRenderer ParticleSystem_OverInventory
		{
			[Token(Token = "0x6002212")]
			[Address(RVA = "0x1014B48", Offset = "0x1014B48", VA = "0x1014B48")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06002213 RID: 8723 RVA: 0x00010A40 File Offset: 0x0000EC40
		// (set) Token: 0x06002214 RID: 8724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F3")]
		public static bool SettingsSavePending
		{
			[Token(Token = "0x6002213")]
			[Address(RVA = "0x1014BB0", Offset = "0x1014BB0", VA = "0x1014BB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002214")]
			[Address(RVA = "0x1014C18", Offset = "0x1014C18", VA = "0x1014C18")]
			set
			{
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004F4")]
		public static IChatMonitor chatMonitor
		{
			[Token(Token = "0x6002215")]
			[Address(RVA = "0x1014C84", Offset = "0x1014C84", VA = "0x1014C84")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x00010A58 File Offset: 0x0000EC58
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F5")]
		public static int menuMode
		{
			[Token(Token = "0x6002216")]
			[Address(RVA = "0x1014CEC", Offset = "0x1014CEC", VA = "0x1014CEC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002217")]
			[Address(RVA = "0x1014D54", Offset = "0x1014D54", VA = "0x1014D54")]
			set
			{
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x00010A70 File Offset: 0x0000EC70
		// (set) Token: 0x06002219 RID: 8729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F6")]
		public static bool Quitting
		{
			[Token(Token = "0x6002218")]
			[Address(RVA = "0x1014DC0", Offset = "0x1014DC0", VA = "0x1014DC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002219")]
			[Address(RVA = "0x1014E28", Offset = "0x1014E28", VA = "0x1014E28")]
			set
			{
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x00010A88 File Offset: 0x0000EC88
		// (set) Token: 0x0600221B RID: 8731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F7")]
		public static int overloadedMousePositionX
		{
			[Token(Token = "0x600221A")]
			[Address(RVA = "0x1014E94", Offset = "0x1014E94", VA = "0x1014E94")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600221B")]
			[Address(RVA = "0x1014EFC", Offset = "0x1014EFC", VA = "0x1014EFC")]
			set
			{
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x00010AA0 File Offset: 0x0000ECA0
		// (set) Token: 0x0600221D RID: 8733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F8")]
		public static int overloadedMousePositionY
		{
			[Token(Token = "0x600221C")]
			[Address(RVA = "0x1014F68", Offset = "0x1014F68", VA = "0x1014F68")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600221D")]
			[Address(RVA = "0x1014FD0", Offset = "0x1014FD0", VA = "0x1014FD0")]
			set
			{
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x00010AB8 File Offset: 0x0000ECB8
		// (set) Token: 0x0600221F RID: 8735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F9")]
		public static bool HoveringOverAnNPC
		{
			[Token(Token = "0x600221E")]
			[Address(RVA = "0x101503C", Offset = "0x101503C", VA = "0x101503C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600221F")]
			[Address(RVA = "0x10150A4", Offset = "0x10150A4", VA = "0x10150A4")]
			set
			{
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		// (set) Token: 0x06002221 RID: 8737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FA")]
		private static int rare
		{
			[Token(Token = "0x6002220")]
			[Address(RVA = "0x1015110", Offset = "0x1015110", VA = "0x1015110")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002221")]
			[Address(RVA = "0x1015178", Offset = "0x1015178", VA = "0x1015178")]
			set
			{
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x00010AE8 File Offset: 0x0000ECE8
		// (set) Token: 0x06002223 RID: 8739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FB")]
		public static int hairStart
		{
			[Token(Token = "0x6002222")]
			[Address(RVA = "0x10151E4", Offset = "0x10151E4", VA = "0x10151E4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002223")]
			[Address(RVA = "0x101524C", Offset = "0x101524C", VA = "0x101524C")]
			set
			{
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x00010B00 File Offset: 0x0000ED00
		// (set) Token: 0x06002225 RID: 8741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FC")]
		public static int oldHairStyle
		{
			[Token(Token = "0x6002224")]
			[Address(RVA = "0x10152B8", Offset = "0x10152B8", VA = "0x10152B8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002225")]
			[Address(RVA = "0x1015320", Offset = "0x1015320", VA = "0x1015320")]
			set
			{
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x00010B18 File Offset: 0x0000ED18
		// (set) Token: 0x06002227 RID: 8743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FD")]
		public static Color oldHairColor
		{
			[Token(Token = "0x6002226")]
			[Address(RVA = "0x101538C", Offset = "0x101538C", VA = "0x101538C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6002227")]
			[Address(RVA = "0x10153F4", Offset = "0x10153F4", VA = "0x10153F4")]
			set
			{
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x00010B30 File Offset: 0x0000ED30
		// (set) Token: 0x06002229 RID: 8745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FE")]
		public static int selClothes
		{
			[Token(Token = "0x6002228")]
			[Address(RVA = "0x1015460", Offset = "0x1015460", VA = "0x1015460")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002229")]
			[Address(RVA = "0x10154C8", Offset = "0x10154C8", VA = "0x10154C8")]
			set
			{
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x0600222A RID: 8746 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600222B RID: 8747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FF")]
		public static Color[] oldClothesColor
		{
			[Token(Token = "0x600222A")]
			[Address(RVA = "0x1015534", Offset = "0x1015534", VA = "0x1015534")]
			get
			{
				return null;
			}
			[Token(Token = "0x600222B")]
			[Address(RVA = "0x101559C", Offset = "0x101559C", VA = "0x101559C")]
			set
			{
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x00010B48 File Offset: 0x0000ED48
		// (set) Token: 0x0600222D RID: 8749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000500")]
		public static int oldClothesStyle
		{
			[Token(Token = "0x600222C")]
			[Address(RVA = "0x1015608", Offset = "0x1015608", VA = "0x1015608")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600222D")]
			[Address(RVA = "0x1015670", Offset = "0x1015670", VA = "0x1015670")]
			set
			{
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x00010B60 File Offset: 0x0000ED60
		// (set) Token: 0x0600222F RID: 8751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000501")]
		public static int oldVoiceStyle
		{
			[Token(Token = "0x600222E")]
			[Address(RVA = "0x10156DC", Offset = "0x10156DC", VA = "0x10156DC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600222F")]
			[Address(RVA = "0x1015744", Offset = "0x1015744", VA = "0x1015744")]
			set
			{
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x00010B78 File Offset: 0x0000ED78
		// (set) Token: 0x06002231 RID: 8753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000502")]
		public static float oldVoicePitch
		{
			[Token(Token = "0x6002230")]
			[Address(RVA = "0x10157B0", Offset = "0x10157B0", VA = "0x10157B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002231")]
			[Address(RVA = "0x1015818", Offset = "0x1015818", VA = "0x1015818")]
			set
			{
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x00010B90 File Offset: 0x0000ED90
		// (set) Token: 0x06002233 RID: 8755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000503")]
		public static int interactedDresserTopLeftX
		{
			[Token(Token = "0x6002232")]
			[Address(RVA = "0x1015888", Offset = "0x1015888", VA = "0x1015888")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002233")]
			[Address(RVA = "0x10158F0", Offset = "0x10158F0", VA = "0x10158F0")]
			set
			{
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x00010BA8 File Offset: 0x0000EDA8
		// (set) Token: 0x06002235 RID: 8757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000504")]
		public static int interactedDresserTopLeftY
		{
			[Token(Token = "0x6002234")]
			[Address(RVA = "0x101595C", Offset = "0x101595C", VA = "0x101595C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002235")]
			[Address(RVA = "0x10159C4", Offset = "0x10159C4", VA = "0x10159C4")]
			set
			{
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002237 RID: 8759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000505")]
		public static Player dresserInterfaceDummy
		{
			[Token(Token = "0x6002236")]
			[Address(RVA = "0x1015A30", Offset = "0x1015A30", VA = "0x1015A30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002237")]
			[Address(RVA = "0x1015A98", Offset = "0x1015A98", VA = "0x1015A98")]
			set
			{
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x00010BC0 File Offset: 0x0000EDC0
		// (set) Token: 0x06002239 RID: 8761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000506")]
		private static bool _MouseOversCanClear
		{
			[Token(Token = "0x6002238")]
			[Address(RVA = "0x1015B04", Offset = "0x1015B04", VA = "0x1015B04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002239")]
			[Address(RVA = "0x1015B6C", Offset = "0x1015B6C", VA = "0x1015B6C")]
			set
			{
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x00010BD8 File Offset: 0x0000EDD8
		// (set) Token: 0x0600223B RID: 8763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000507")]
		private static Vector2 _itemIconCacheScreenPosition
		{
			[Token(Token = "0x600223A")]
			[Address(RVA = "0x1015BD8", Offset = "0x1015BD8", VA = "0x1015BD8")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600223B")]
			[Address(RVA = "0x1015C44", Offset = "0x1015C44", VA = "0x1015C44")]
			set
			{
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x00010BF0 File Offset: 0x0000EDF0
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000508")]
		private static int _itemIconCacheSelectedItemID
		{
			[Token(Token = "0x600223C")]
			[Address(RVA = "0x1015CB0", Offset = "0x1015CB0", VA = "0x1015CB0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600223D")]
			[Address(RVA = "0x1015D18", Offset = "0x1015D18", VA = "0x1015D18")]
			set
			{
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x00010C08 File Offset: 0x0000EE08
		// (set) Token: 0x0600223F RID: 8767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000509")]
		private static int _itemIconCacheTime
		{
			[Token(Token = "0x600223E")]
			[Address(RVA = "0x1015D84", Offset = "0x1015D84", VA = "0x1015D84")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600223F")]
			[Address(RVA = "0x1015DEC", Offset = "0x1015DEC", VA = "0x1015DEC")]
			set
			{
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x00010C20 File Offset: 0x0000EE20
		// (set) Token: 0x06002241 RID: 8769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050A")]
		public static Color selColor
		{
			[Token(Token = "0x6002240")]
			[Address(RVA = "0x1015E58", Offset = "0x1015E58", VA = "0x1015E58")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6002241")]
			[Address(RVA = "0x1015EC0", Offset = "0x1015EC0", VA = "0x1015EC0")]
			set
			{
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x00010C38 File Offset: 0x0000EE38
		// (set) Token: 0x06002243 RID: 8771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050B")]
		public static int bgScroll
		{
			[Token(Token = "0x6002242")]
			[Address(RVA = "0x1015F2C", Offset = "0x1015F2C", VA = "0x1015F2C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002243")]
			[Address(RVA = "0x1015F94", Offset = "0x1015F94", VA = "0x1015F94")]
			set
			{
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x00010C50 File Offset: 0x0000EE50
		// (set) Token: 0x06002245 RID: 8773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050C")]
		public static float hBar
		{
			[Token(Token = "0x6002244")]
			[Address(RVA = "0x1016000", Offset = "0x1016000", VA = "0x1016000")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002245")]
			[Address(RVA = "0x1016068", Offset = "0x1016068", VA = "0x1016068")]
			set
			{
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x00010C68 File Offset: 0x0000EE68
		// (set) Token: 0x06002247 RID: 8775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050D")]
		public static float sBar
		{
			[Token(Token = "0x6002246")]
			[Address(RVA = "0x10160D8", Offset = "0x10160D8", VA = "0x10160D8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002247")]
			[Address(RVA = "0x1016140", Offset = "0x1016140", VA = "0x1016140")]
			set
			{
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06002248 RID: 8776 RVA: 0x00010C80 File Offset: 0x0000EE80
		// (set) Token: 0x06002249 RID: 8777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050E")]
		public static float lBar
		{
			[Token(Token = "0x6002248")]
			[Address(RVA = "0x10161B0", Offset = "0x10161B0", VA = "0x10161B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002249")]
			[Address(RVA = "0x1016218", Offset = "0x1016218", VA = "0x1016218")]
			set
			{
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x00010C98 File Offset: 0x0000EE98
		// (set) Token: 0x0600224B RID: 8779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050F")]
		public static float aBar
		{
			[Token(Token = "0x600224A")]
			[Address(RVA = "0x1016288", Offset = "0x1016288", VA = "0x1016288")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600224B")]
			[Address(RVA = "0x10162F0", Offset = "0x10162F0", VA = "0x10162F0")]
			set
			{
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x00010CB0 File Offset: 0x0000EEB0
		// (set) Token: 0x0600224D RID: 8781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000510")]
		public static float GamepadCursorAlpha
		{
			[Token(Token = "0x600224C")]
			[Address(RVA = "0x1016360", Offset = "0x1016360", VA = "0x1016360")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600224D")]
			[Address(RVA = "0x10163C8", Offset = "0x10163C8", VA = "0x10163C8")]
			set
			{
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000511")]
		public static bool CanUpdateGameplay
		{
			[Token(Token = "0x600224E")]
			[Address(RVA = "0x1016438", Offset = "0x1016438", VA = "0x1016438")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600224F")]
			[Address(RVA = "0x101649C", Offset = "0x101649C", VA = "0x101649C")]
			private set
			{
			}
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002250")]
		[Address(RVA = "0x1016504", Offset = "0x1016504", VA = "0x1016504")]
		public static void ToggleGameplayUpdates(bool state)
		{
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x00010CE0 File Offset: 0x0000EEE0
		[Token(Token = "0x17000512")]
		public static Matrix UIScaleMatrix
		{
			[Token(Token = "0x6002251")]
			[Address(RVA = "0x10165B0", Offset = "0x10165B0", VA = "0x10165B0")]
			get
			{
				return default(Matrix);
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		[Token(Token = "0x17000513")]
		public static float UIScaleWanted
		{
			[Token(Token = "0x6002252")]
			[Address(RVA = "0x1016660", Offset = "0x1016660", VA = "0x1016660")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06002253 RID: 8787 RVA: 0x00010D10 File Offset: 0x0000EF10
		// (set) Token: 0x06002254 RID: 8788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000514")]
		public static float UIScale
		{
			[Token(Token = "0x6002253")]
			[Address(RVA = "0x10166C4", Offset = "0x10166C4", VA = "0x10166C4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002254")]
			[Address(RVA = "0x1016728", Offset = "0x1016728", VA = "0x1016728")]
			set
			{
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06002255 RID: 8789 RVA: 0x00010D28 File Offset: 0x0000EF28
		[Token(Token = "0x17000515")]
		public float UIScaleMax
		{
			[Token(Token = "0x6002255")]
			[Address(RVA = "0x10168C0", Offset = "0x10168C0", VA = "0x10168C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x00010D40 File Offset: 0x0000EF40
		[Token(Token = "0x17000516")]
		public static bool RenderTargetsRequired
		{
			[Token(Token = "0x6002256")]
			[Address(RVA = "0x1016A2C", Offset = "0x1016A2C", VA = "0x1016A2C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06002257 RID: 8791 RVA: 0x00010D58 File Offset: 0x0000EF58
		[Token(Token = "0x17000517")]
		public static bool IsItRaining
		{
			[Token(Token = "0x6002257")]
			[Address(RVA = "0x1016B0C", Offset = "0x1016B0C", VA = "0x1016B0C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06002258 RID: 8792 RVA: 0x00010D70 File Offset: 0x0000EF70
		[Token(Token = "0x17000518")]
		public static bool ThickMouse
		{
			[Token(Token = "0x6002258")]
			[Address(RVA = "0x1016B80", Offset = "0x1016B80", VA = "0x1016B80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x00010D88 File Offset: 0x0000EF88
		[Token(Token = "0x17000519")]
		public static bool GamepadDisableCursorItemIcon
		{
			[Token(Token = "0x6002259")]
			[Address(RVA = "0x1016C78", Offset = "0x1016C78", VA = "0x1016C78")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051A")]
		public static string SavePath
		{
			[Token(Token = "0x600225A")]
			[Address(RVA = "0x10119D4", Offset = "0x10119D4", VA = "0x10119D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051B")]
		public static string OldSavePath
		{
			[Token(Token = "0x600225B")]
			[Address(RVA = "0x1012164", Offset = "0x1012164", VA = "0x1012164")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600225C")]
		[Address(RVA = "0x1016D2C", Offset = "0x1016D2C", VA = "0x1016D2C")]
		public static void FindAnnouncementBoxStatus()
		{
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600225D RID: 8797 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		// (set) Token: 0x0600225E RID: 8798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051C")]
		public static int GameMode
		{
			[Token(Token = "0x600225D")]
			[Address(RVA = "0x1016EE0", Offset = "0x1016EE0", VA = "0x1016EE0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600225E")]
			[Address(RVA = "0x1016F80", Offset = "0x1016F80", VA = "0x1016F80")]
			set
			{
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x0600225F RID: 8799 RVA: 0x00010DB8 File Offset: 0x0000EFB8
		[Token(Token = "0x1700051D")]
		public static bool IsJourneyMode
		{
			[Token(Token = "0x600225F")]
			[Address(RVA = "0x1017034", Offset = "0x1017034", VA = "0x1017034")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		[Token(Token = "0x1700051E")]
		public static bool NoFunctionalSurface
		{
			[Token(Token = "0x6002260")]
			[Address(RVA = "0x1017124", Offset = "0x1017124", VA = "0x1017124")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06002261 RID: 8801 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		[Token(Token = "0x1700051F")]
		public static bool surviveHardcoreDeath
		{
			[Token(Token = "0x6002261")]
			[Address(RVA = "0x101719C", Offset = "0x101719C", VA = "0x101719C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x00010E00 File Offset: 0x0000F000
		[Token(Token = "0x17000520")]
		public static bool specialSeedWorld
		{
			[Token(Token = "0x6002262")]
			[Address(RVA = "0x1017258", Offset = "0x1017258", VA = "0x1017258")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06002263 RID: 8803 RVA: 0x00010E18 File Offset: 0x0000F018
		[Token(Token = "0x17000521")]
		public static bool onlyDontStarveWorld
		{
			[Token(Token = "0x6002263")]
			[Address(RVA = "0x10173EC", Offset = "0x10173EC", VA = "0x10173EC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x00010E30 File Offset: 0x0000F030
		[Token(Token = "0x17000522")]
		public static bool onlyShimmerOceanWorlds
		{
			[Token(Token = "0x6002264")]
			[Address(RVA = "0x1017580", Offset = "0x1017580", VA = "0x1017580")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06002265 RID: 8805 RVA: 0x00010E48 File Offset: 0x0000F048
		[Token(Token = "0x17000523")]
		public static bool onlyShimmerOceanWorldsGeneration
		{
			[Token(Token = "0x6002265")]
			[Address(RVA = "0x101768C", Offset = "0x101768C", VA = "0x101768C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x00010E60 File Offset: 0x0000F060
		[Token(Token = "0x17000524")]
		public static bool masterMode
		{
			[Token(Token = "0x6002266")]
			[Address(RVA = "0x1017798", Offset = "0x1017798", VA = "0x1017798")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06002267 RID: 8807 RVA: 0x00010E78 File Offset: 0x0000F078
		[Token(Token = "0x17000525")]
		public static bool expertMode
		{
			[Token(Token = "0x6002267")]
			[Address(RVA = "0x1017B38", Offset = "0x1017B38", VA = "0x1017B38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x00010E90 File Offset: 0x0000F090
		[Token(Token = "0x17000526")]
		public static float Difficulty
		{
			[Token(Token = "0x6002268")]
			[Address(RVA = "0x1017850", Offset = "0x1017850", VA = "0x1017850")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x00010EA8 File Offset: 0x0000F0A8
		[Token(Token = "0x6002269")]
		[Address(RVA = "0x1017BF0", Offset = "0x1017BF0", VA = "0x1017BF0")]
		public static Color GetColorForCurrentDifficulty(bool includeLegendary = true)
		{
			return default(Color);
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		[Token(Token = "0x600226A")]
		[Address(RVA = "0x1017F3C", Offset = "0x1017F3C", VA = "0x1017F3C")]
		public static Color GetColorForDifficulty(float gameDifficultyLevel)
		{
			return default(Color);
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		[Token(Token = "0x600226B")]
		[Address(RVA = "0x10180FC", Offset = "0x10180FC", VA = "0x10180FC")]
		public static bool CanPlayCreditsRoll()
		{
			return default(bool);
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000527")]
		public static AchievementManager Achievements
		{
			[Token(Token = "0x600226C")]
			[Address(RVA = "0x1018390", Offset = "0x1018390", VA = "0x1018390")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600226E RID: 8814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000528")]
		public WaterfallManager waterfallManager
		{
			[Token(Token = "0x600226D")]
			[Address(RVA = "0x10183F8", Offset = "0x10183F8", VA = "0x10183F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600226E")]
			[Address(RVA = "0x1018460", Offset = "0x1018460", VA = "0x1018460")]
			set
			{
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600226F RID: 8815 RVA: 0x00010EF0 File Offset: 0x0000F0F0
		// (set) Token: 0x06002270 RID: 8816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000529")]
		public static ulong UnpausedUpdateSeed
		{
			[Token(Token = "0x600226F")]
			[Address(RVA = "0x1018520", Offset = "0x1018520", VA = "0x1018520")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002270")]
			[Address(RVA = "0x1018588", Offset = "0x1018588", VA = "0x1018588")]
			private set
			{
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06002271 RID: 8817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052A")]
		public static Effect screenShader
		{
			[Token(Token = "0x6002271")]
			[Address(RVA = "0x10185F8", Offset = "0x10185F8", VA = "0x10185F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052B")]
		public static Effect pixelShader
		{
			[Token(Token = "0x6002272")]
			[Address(RVA = "0x1018674", Offset = "0x1018674", VA = "0x1018674")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052C")]
		public static Effect tileShader
		{
			[Token(Token = "0x6002273")]
			[Address(RVA = "0x10186F0", Offset = "0x10186F0", VA = "0x10186F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002274")]
		[Address(RVA = "0x101876C", Offset = "0x101876C", VA = "0x101876C")]
		public static void SetCameraLerp(float lerp, int time)
		{
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06002275 RID: 8821 RVA: 0x00010F08 File Offset: 0x0000F108
		[Token(Token = "0x1700052D")]
		public static Matrix Transform
		{
			[Token(Token = "0x6002275")]
			[Address(RVA = "0x10188D4", Offset = "0x10188D4", VA = "0x10188D4")]
			get
			{
				return default(Matrix);
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x00010F20 File Offset: 0x0000F120
		[Token(Token = "0x1700052E")]
		public static Vector2 MouseScreen
		{
			[Token(Token = "0x6002276")]
			[Address(RVA = "0x101899C", Offset = "0x101899C", VA = "0x101899C")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06002277 RID: 8823 RVA: 0x00010F38 File Offset: 0x0000F138
		[Token(Token = "0x1700052F")]
		public static Vector2 MouseWorld
		{
			[Token(Token = "0x6002277")]
			[Address(RVA = "0x1018AC8", Offset = "0x1018AC8", VA = "0x1018AC8")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x00010F50 File Offset: 0x0000F150
		[Token(Token = "0x17000530")]
		public static Vector2 MouseWorld2
		{
			[Token(Token = "0x6002278")]
			[Address(RVA = "0x1018D9C", Offset = "0x1018D9C", VA = "0x1018D9C")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x00010F68 File Offset: 0x0000F168
		[Token(Token = "0x6002279")]
		[Address(RVA = "0x101911C", Offset = "0x101911C", VA = "0x101911C")]
		public static Vector2 ReverseGravitySupport(Vector2 pos, float height = 0f)
		{
			return default(Vector2);
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x00010F80 File Offset: 0x0000F180
		[Token(Token = "0x600227A")]
		[Address(RVA = "0x10192B8", Offset = "0x10192B8", VA = "0x10192B8")]
		public static Point ReverseGravitySupport(Point pos, int height = 0)
		{
			return default(Point);
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x00010F98 File Offset: 0x0000F198
		[Token(Token = "0x600227B")]
		[Address(RVA = "0x1019438", Offset = "0x1019438", VA = "0x1019438")]
		public static Rectangle ReverseGravitySupport(Rectangle box)
		{
			return default(Rectangle);
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000531")]
		public static INetDiagnosticsUI ActiveNetDiagnosticsUI
		{
			[Token(Token = "0x600227C")]
			[Address(RVA = "0x10195C0", Offset = "0x10195C0", VA = "0x10195C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		// (set) Token: 0x0600227E RID: 8830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000532")]
		public int mouseNPCIndex
		{
			[Token(Token = "0x600227D")]
			[Address(RVA = "0x1019710", Offset = "0x1019710", VA = "0x1019710")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600227E")]
			[Address(RVA = "0x1019778", Offset = "0x1019778", VA = "0x1019778")]
			set
			{
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600227F RID: 8831 RVA: 0x00010FC8 File Offset: 0x0000F1C8
		// (set) Token: 0x06002280 RID: 8832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000533")]
		public int mouseNPCType
		{
			[Token(Token = "0x600227F")]
			[Address(RVA = "0x10197E4", Offset = "0x10197E4", VA = "0x10197E4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002280")]
			[Address(RVA = "0x101984C", Offset = "0x101984C", VA = "0x101984C")]
			set
			{
			}
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002281")]
		[Address(RVA = "0x10198B8", Offset = "0x10198B8", VA = "0x10198B8")]
		public void SetMouseNPC(int index, int type)
		{
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002282")]
		[Address(RVA = "0x1019974", Offset = "0x1019974", VA = "0x1019974")]
		public void SetMouseNPC_ToHousingQuery()
		{
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x00010FE0 File Offset: 0x0000F1E0
		// (set) Token: 0x06002284 RID: 8836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000534")]
		public static float LastSunVisibility
		{
			[Token(Token = "0x6002283")]
			[Address(RVA = "0x1019980", Offset = "0x1019980", VA = "0x1019980")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002284")]
			[Address(RVA = "0x10199E8", Offset = "0x10199E8", VA = "0x10199E8")]
			set
			{
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06002285 RID: 8837 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002286 RID: 8838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001F")]
		public static event Action OnEnginePreload
		{
			[Token(Token = "0x6002285")]
			[Address(RVA = "0x1019A58", Offset = "0x1019A58", VA = "0x1019A58")]
			add
			{
			}
			[Token(Token = "0x6002286")]
			[Address(RVA = "0x1019B60", Offset = "0x1019B60", VA = "0x1019B60")]
			remove
			{
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06002287 RID: 8839 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002288 RID: 8840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000020")]
		public static event Action<Vector2> OnResolutionChanged
		{
			[Token(Token = "0x6002287")]
			[Address(RVA = "0x1019C68", Offset = "0x1019C68", VA = "0x1019C68")]
			add
			{
			}
			[Token(Token = "0x6002288")]
			[Address(RVA = "0x1019D90", Offset = "0x1019D90", VA = "0x1019D90")]
			remove
			{
			}
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06002289 RID: 8841 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600228A RID: 8842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000021")]
		public static event Action OnEngineLoad
		{
			[Token(Token = "0x6002289")]
			[Address(RVA = "0x1019EB8", Offset = "0x1019EB8", VA = "0x1019EB8")]
			add
			{
			}
			[Token(Token = "0x600228A")]
			[Address(RVA = "0x1019FBC", Offset = "0x1019FBC", VA = "0x1019FBC")]
			remove
			{
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x0600228B RID: 8843 RVA: 0x00010FF8 File Offset: 0x0000F1F8
		[Token(Token = "0x17000535")]
		public static uint GameUpdateCount
		{
			[Token(Token = "0x600228B")]
			[Address(RVA = "0x101A0C0", Offset = "0x101A0C0", VA = "0x101A0C0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x0600228C RID: 8844 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600228D RID: 8845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000022")]
		public static event Action OnTickForThirdPartySoftwareOnly
		{
			[Token(Token = "0x600228C")]
			[Address(RVA = "0x101A124", Offset = "0x101A124", VA = "0x101A124")]
			add
			{
			}
			[Token(Token = "0x600228D")]
			[Address(RVA = "0x101A22C", Offset = "0x101A22C", VA = "0x101A22C")]
			remove
			{
			}
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x0600228E RID: 8846 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600228F RID: 8847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000023")]
		public static event Action OnTickForInternalCodeOnly
		{
			[Token(Token = "0x600228E")]
			[Address(RVA = "0x101A334", Offset = "0x101A334", VA = "0x101A334")]
			add
			{
			}
			[Token(Token = "0x600228F")]
			[Address(RVA = "0x101A43C", Offset = "0x101A43C", VA = "0x101A43C")]
			remove
			{
			}
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06002290 RID: 8848 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002291 RID: 8849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000024")]
		public static event Action<GameTime> OnPreDraw
		{
			[Token(Token = "0x6002290")]
			[Address(RVA = "0x101A544", Offset = "0x101A544", VA = "0x101A544")]
			add
			{
			}
			[Token(Token = "0x6002291")]
			[Address(RVA = "0x101A664", Offset = "0x101A664", VA = "0x101A664")]
			remove
			{
			}
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06002292 RID: 8850 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002293 RID: 8851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000025")]
		public static event Action<GameTime> OnPostDraw
		{
			[Token(Token = "0x6002292")]
			[Address(RVA = "0x101A784", Offset = "0x101A784", VA = "0x101A784")]
			add
			{
			}
			[Token(Token = "0x6002293")]
			[Address(RVA = "0x101A8AC", Offset = "0x101A8AC", VA = "0x101A8AC")]
			remove
			{
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06002294 RID: 8852 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002295 RID: 8853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000026")]
		public static event Action<Vector2, float> OnPostFullscreenMapDraw
		{
			[Token(Token = "0x6002294")]
			[Address(RVA = "0x101A9D4", Offset = "0x101A9D4", VA = "0x101A9D4")]
			add
			{
			}
			[Token(Token = "0x6002295")]
			[Address(RVA = "0x101AAFC", Offset = "0x101AAFC", VA = "0x101AAFC")]
			remove
			{
			}
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06002296 RID: 8854 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002297 RID: 8855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000027")]
		public static event Action OnRenderTargetsReleased
		{
			[Token(Token = "0x6002296")]
			[Address(RVA = "0x101AC24", Offset = "0x101AC24", VA = "0x101AC24")]
			add
			{
			}
			[Token(Token = "0x6002297")]
			[Address(RVA = "0x101AD2C", Offset = "0x101AD2C", VA = "0x101AD2C")]
			remove
			{
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06002298 RID: 8856 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002299 RID: 8857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000028")]
		public static event ResolutionChangeEvent OnRenderTargetsInitialized
		{
			[Token(Token = "0x6002298")]
			[Address(RVA = "0x101AE34", Offset = "0x101AE34", VA = "0x101AE34")]
			add
			{
			}
			[Token(Token = "0x6002299")]
			[Address(RVA = "0x101AF38", Offset = "0x101AF38", VA = "0x101AF38")]
			remove
			{
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x00011010 File Offset: 0x0000F210
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000536")]
		private int firstTileX
		{
			[Token(Token = "0x600229A")]
			[Address(RVA = "0x101B03C", Offset = "0x101B03C", VA = "0x101B03C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600229B")]
			[Address(RVA = "0x101B0A4", Offset = "0x101B0A4", VA = "0x101B0A4")]
			set
			{
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x00011028 File Offset: 0x0000F228
		// (set) Token: 0x0600229D RID: 8861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000537")]
		private int lastTileX
		{
			[Token(Token = "0x600229C")]
			[Address(RVA = "0x101B110", Offset = "0x101B110", VA = "0x101B110")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600229D")]
			[Address(RVA = "0x101B178", Offset = "0x101B178", VA = "0x101B178")]
			set
			{
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x0600229E RID: 8862 RVA: 0x00011040 File Offset: 0x0000F240
		// (set) Token: 0x0600229F RID: 8863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000538")]
		private int firstTileY
		{
			[Token(Token = "0x600229E")]
			[Address(RVA = "0x101B1E4", Offset = "0x101B1E4", VA = "0x101B1E4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600229F")]
			[Address(RVA = "0x101B24C", Offset = "0x101B24C", VA = "0x101B24C")]
			set
			{
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x00011058 File Offset: 0x0000F258
		// (set) Token: 0x060022A1 RID: 8865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000539")]
		private int lastTileY
		{
			[Token(Token = "0x60022A0")]
			[Address(RVA = "0x101B2B8", Offset = "0x101B2B8", VA = "0x101B2B8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60022A1")]
			[Address(RVA = "0x101B320", Offset = "0x101B320", VA = "0x101B320")]
			set
			{
			}
		}

		// Token: 0x060022A2 RID: 8866
		[Token(Token = "0x60022A2")]
		[Address(RVA = "0x101B390", Offset = "0x101B390", VA = "0x101B390")]
		[PreserveSig]
		private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

		// Token: 0x060022A3 RID: 8867
		[Token(Token = "0x60022A3")]
		[Address(RVA = "0x101B440", Offset = "0x101B440", VA = "0x101B440")]
		[PreserveSig]
		private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

		// Token: 0x060022A4 RID: 8868
		[Token(Token = "0x60022A4")]
		[Address(RVA = "0x101B4E0", Offset = "0x101B4E0", VA = "0x101B4E0")]
		[PreserveSig]
		private static extern int GetMenuItemCount(IntPtr hWnd);

		// Token: 0x060022A5 RID: 8869
		[Token(Token = "0x60022A5")]
		[Address(RVA = "0x101B580", Offset = "0x101B580", VA = "0x101B580")]
		[PreserveSig]
		public static extern IntPtr LoadLibrary(string dllToLoad);

		// Token: 0x060022A6 RID: 8870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A6")]
		[Address(RVA = "0x101B644", Offset = "0x101B644", VA = "0x101B644")]
		public static void FlushBatches(bool submitBatchesInProgress = false)
		{
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700053A")]
		public static SamplerState DefaultSamplerState
		{
			[Token(Token = "0x60022A7")]
			[Address(RVA = "0x101BA28", Offset = "0x101BA28", VA = "0x101BA28")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x00011070 File Offset: 0x0000F270
		[Token(Token = "0x1700053B")]
		public static bool isThereAWorldSurface
		{
			[Token(Token = "0x60022A8")]
			[Address(RVA = "0x101BAD8", Offset = "0x101BAD8", VA = "0x101BAD8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x00011088 File Offset: 0x0000F288
		[Token(Token = "0x1700053C")]
		public static int UnderworldLayer
		{
			[Token(Token = "0x60022A9")]
			[Address(RVA = "0x101BB5C", Offset = "0x101BB5C", VA = "0x101BB5C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x000110A0 File Offset: 0x0000F2A0
		[Token(Token = "0x60022AA")]
		[Address(RVA = "0x101BBC4", Offset = "0x101BBC4", VA = "0x101BBC4")]
		public static MoonPhase GetMoonPhase()
		{
			return MoonPhase.Full;
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x000110B8 File Offset: 0x0000F2B8
		[Token(Token = "0x1700053D")]
		public static int HorizonPhase
		{
			[Token(Token = "0x60022AB")]
			[Address(RVA = "0x101BC28", Offset = "0x101BC28", VA = "0x101BC28")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x000110D0 File Offset: 0x0000F2D0
		[Token(Token = "0x1700053E")]
		public static float WindForVisuals
		{
			[Token(Token = "0x60022AC")]
			[Address(RVA = "0x101BCDC", Offset = "0x101BCDC", VA = "0x101BCDC")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AD")]
		[Address(RVA = "0x101BD40", Offset = "0x101BD40", VA = "0x101BD40")]
		public static void ResetInventoryState()
		{
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x000110E8 File Offset: 0x0000F2E8
		[Token(Token = "0x60022AE")]
		[Address(RVA = "0x101BDB0", Offset = "0x101BDB0", VA = "0x101BDB0")]
		public static Vector2 DrawPlayerItemPos(float gravdir, int itemtype)
		{
			return default(Vector2);
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AF")]
		[Address(RVA = "0x101CB70", Offset = "0x101CB70", VA = "0x101CB70")]
		public static void SetupTileMerge()
		{
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B0")]
		[Address(RVA = "0x101CE98", Offset = "0x101CE98", VA = "0x101CE98")]
		public static void RegisterItemAnimation(int index, DrawAnimation animation)
		{
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B1")]
		[Address(RVA = "0x101D058", Offset = "0x101D058", VA = "0x101D058")]
		public static void InitializeItemAnimations()
		{
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700053F")]
		public static Player LocalPlayer
		{
			[Token(Token = "0x60022B2")]
			[Address(RVA = "0x10182C0", Offset = "0x10182C0", VA = "0x10182C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000540")]
		public static CreativeUnlocksTracker LocalPlayerCreativeTracker
		{
			[Token(Token = "0x60022B3")]
			[Address(RVA = "0x101D748", Offset = "0x101D748", VA = "0x101D748")]
			get
			{
				return null;
			}
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B4")]
		[Address(RVA = "0x101D830", Offset = "0x101D830", VA = "0x101D830")]
		public static void SetGraphicsProfile(GraphicsProfile profile, bool forceSet)
		{
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B5")]
		[Address(RVA = "0x101D8CC", Offset = "0x101D8CC", VA = "0x101D8CC")]
		private static void SetGraphicsProfileInternal()
		{
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B6")]
		[Address(RVA = "0x101D8D0", Offset = "0x101D8D0", VA = "0x101D8D0")]
		private static void TrySupporting8K()
		{
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B7")]
		[Address(RVA = "0x101D8D8", Offset = "0x101D8D8", VA = "0x101D8D8")]
		public static void AnglerQuestSwap()
		{
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000541")]
		public static string playerPathName
		{
			[Token(Token = "0x60022B8")]
			[Address(RVA = "0x101E2B4", Offset = "0x101E2B4", VA = "0x101E2B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000542")]
		public static string worldPathName
		{
			[Token(Token = "0x60022B9")]
			[Address(RVA = "0x101E37C", Offset = "0x101E37C", VA = "0x101E37C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x00011100 File Offset: 0x0000F300
		// (set) Token: 0x060022BB RID: 8891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000543")]
		public int currentNPCShowingChatBubble
		{
			[Token(Token = "0x60022BA")]
			[Address(RVA = "0x101E3F8", Offset = "0x101E3F8", VA = "0x101E3F8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60022BB")]
			[Address(RVA = "0x101E460", Offset = "0x101E460", VA = "0x101E460")]
			set
			{
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060022BC RID: 8892 RVA: 0x00011118 File Offset: 0x0000F318
		[Token(Token = "0x17000544")]
		public static bool NetClientOnly
		{
			[Token(Token = "0x60022BC")]
			[Address(RVA = "0x101E4CC", Offset = "0x101E4CC", VA = "0x101E4CC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x00011130 File Offset: 0x0000F330
		[Token(Token = "0x17000545")]
		public static bool NetClient
		{
			[Token(Token = "0x60022BD")]
			[Address(RVA = "0x101E53C", Offset = "0x101E53C", VA = "0x101E53C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x00011148 File Offset: 0x0000F348
		[Token(Token = "0x17000546")]
		public static bool LogicHost
		{
			[Token(Token = "0x60022BE")]
			[Address(RVA = "0x101E5A4", Offset = "0x101E5A4", VA = "0x101E5A4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x00011160 File Offset: 0x0000F360
		[Token(Token = "0x17000547")]
		public static bool NetHostOnly
		{
			[Token(Token = "0x60022BF")]
			[Address(RVA = "0x101E654", Offset = "0x101E654", VA = "0x101E654")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060022C0 RID: 8896 RVA: 0x00011178 File Offset: 0x0000F378
		[Token(Token = "0x17000548")]
		public static bool LogicClient
		{
			[Token(Token = "0x60022C0")]
			[Address(RVA = "0x101E6C4", Offset = "0x101E6C4", VA = "0x101E6C4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x00011190 File Offset: 0x0000F390
		[Token(Token = "0x17000549")]
		public static bool NetHost
		{
			[Token(Token = "0x60022C1")]
			[Address(RVA = "0x101E730", Offset = "0x101E730", VA = "0x101E730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x000111A8 File Offset: 0x0000F3A8
		[Token(Token = "0x1700054A")]
		public static bool NetClientHost
		{
			[Token(Token = "0x60022C2")]
			[Address(RVA = "0x101E798", Offset = "0x101E798", VA = "0x101E798")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x000111C0 File Offset: 0x0000F3C0
		// (set) Token: 0x060022C4 RID: 8900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054B")]
		public static bool SmartCursorIsUsed
		{
			[Token(Token = "0x60022C3")]
			[Address(RVA = "0x101E808", Offset = "0x101E808", VA = "0x101E808")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022C4")]
			[Address(RVA = "0x101E894", Offset = "0x101E894", VA = "0x101E894")]
			set
			{
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x000111D8 File Offset: 0x0000F3D8
		// (set) Token: 0x060022C6 RID: 8902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054C")]
		public static bool SmartCursorWanted
		{
			[Token(Token = "0x60022C5")]
			[Address(RVA = "0x101E928", Offset = "0x101E928", VA = "0x101E928")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022C6")]
			[Address(RVA = "0x101E9B4", Offset = "0x101E9B4", VA = "0x101E9B4")]
			set
			{
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x000111F0 File Offset: 0x0000F3F0
		[Token(Token = "0x1700054D")]
		public static bool HasSmartInteractTarget
		{
			[Token(Token = "0x60022C7")]
			[Address(RVA = "0x101EA48", Offset = "0x101EA48", VA = "0x101EA48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C8")]
		[Address(RVA = "0x101EC4C", Offset = "0x101EC4C", VA = "0x101EC4C")]
		public void UpdateParticleSystems_World()
		{
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C9")]
		[Address(RVA = "0x101EE60", Offset = "0x101EE60", VA = "0x101EE60")]
		public void UpdateParticleSystems_UI()
		{
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CA")]
		[Address(RVA = "0x101EF4C", Offset = "0x101EF4C", VA = "0x101EF4C")]
		public static void TrySetPreparationState(Main.WorldPreparationState state)
		{
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CB")]
		[Address(RVA = "0x101EFBC", Offset = "0x101EFBC", VA = "0x101EFBC")]
		public static void UpdateWorldPreparationState()
		{
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CC")]
		[Address(RVA = "0x101F2B0", Offset = "0x101F2B0", VA = "0x101F2B0")]
		public static void SetupNonSmartCursorAimTileCoords(out int lx, out int hx, out int ly, out int hy)
		{
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x00011208 File Offset: 0x0000F408
		[Token(Token = "0x60022CD")]
		[Address(RVA = "0x1020040", Offset = "0x1020040", VA = "0x1020040")]
		public static bool IsInteractionHighlighted(int x, int y, out bool selected)
		{
			return default(bool);
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x00011220 File Offset: 0x0000F420
		[Token(Token = "0x60022CE")]
		[Address(RVA = "0x1020424", Offset = "0x1020424", VA = "0x1020424")]
		public static bool InSmartCursorHighlightArea(int x, int y, out bool actuallySelected)
		{
			return default(bool);
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CF")]
		[Address(RVA = "0x10207C8", Offset = "0x10207C8", VA = "0x10207C8")]
		public static byte[] Decompress(byte[] inputData, int outputSize)
		{
			return null;
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D0")]
		[Address(RVA = "0x1020944", Offset = "0x1020944", VA = "0x1020944")]
		public static string GenerateWorldNameFromSeed(int seed)
		{
			return null;
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D1")]
		[Address(RVA = "0x1020C34", Offset = "0x1020C34", VA = "0x1020C34")]
		public static string GenerateWorldNameFromUID(Guid uid)
		{
			return null;
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D2")]
		[Address(RVA = "0x1020CB4", Offset = "0x1020CB4", VA = "0x1020CB4")]
		public static string GenerateWorldNameFromActiveWorldUID()
		{
			return null;
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D3")]
		[Address(RVA = "0x1020DEC", Offset = "0x1020DEC", VA = "0x1020DEC")]
		public static void LoadWorlds(bool canFullRefresh = false)
		{
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00011238 File Offset: 0x0000F438
		[Token(Token = "0x60022D4")]
		[Address(RVA = "0x1022458", Offset = "0x1022458", VA = "0x1022458")]
		private static int WorldListSortMethod(WorldFileData data1, WorldFileData data2)
		{
			return 0;
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D5")]
		[Address(RVA = "0x10224A8", Offset = "0x10224A8", VA = "0x10224A8")]
		public static void ClearPlayers()
		{
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D6")]
		[Address(RVA = "0x1022630", Offset = "0x1022630", VA = "0x1022630")]
		public static void LoadPlayers(bool canFullRefresh = false)
		{
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x00011250 File Offset: 0x0000F450
		[Token(Token = "0x60022D7")]
		[Address(RVA = "0x1023D00", Offset = "0x1023D00", VA = "0x1023D00")]
		private static int PlayerListSortMethod(PlayerFileData data1, PlayerFileData data2)
		{
			return 0;
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D8")]
		[Address(RVA = "0x1023D4C", Offset = "0x1023D4C", VA = "0x1023D4C")]
		private void ResetRecent()
		{
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x00011268 File Offset: 0x0000F468
		[Token(Token = "0x60022D9")]
		[Address(RVA = "0x1023F6C", Offset = "0x1023F6C", VA = "0x1023F6C")]
		private bool LoadRecent(byte[] fileData, bool ignoreLatestData)
		{
			return default(bool);
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DA")]
		[Address(RVA = "0x1024B20", Offset = "0x1024B20", VA = "0x1024B20")]
		public void OpenRecent()
		{
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DB")]
		[Address(RVA = "0x1024D54", Offset = "0x1024D54", VA = "0x1024D54")]
		public static void SaveRecent()
		{
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x00011280 File Offset: 0x0000F480
		[Token(Token = "0x60022DC")]
		[Address(RVA = "0x10258E4", Offset = "0x10258E4", VA = "0x10258E4")]
		public static bool SaveSettings()
		{
			return default(bool);
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DD")]
		[Address(RVA = "0x102A9C0", Offset = "0x102A9C0", VA = "0x102A9C0")]
		protected void CheckBunny()
		{
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x00011298 File Offset: 0x0000F498
		[Token(Token = "0x60022DE")]
		[Address(RVA = "0x102AA28", Offset = "0x102AA28", VA = "0x102AA28")]
		private static bool HasCollectorsEditionRegistry()
		{
			return default(bool);
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DF")]
		[Address(RVA = "0x102AA30", Offset = "0x102AA30", VA = "0x102AA30")]
		public void ResetSettings()
		{
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E0")]
		[Address(RVA = "0x1031CE0", Offset = "0x1031CE0", VA = "0x1031CE0")]
		private static void TryPickingDefaultUIScale(float displayHeight)
		{
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x000112B0 File Offset: 0x0000F4B0
		// (set) Token: 0x060022E2 RID: 8930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054E")]
		public static bool Platform_LowPowerMode
		{
			[Token(Token = "0x60022E1")]
			[Address(RVA = "0x1031E48", Offset = "0x1031E48", VA = "0x1031E48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022E2")]
			[Address(RVA = "0x1031EAC", Offset = "0x1031EAC", VA = "0x1031EAC")]
			set
			{
			}
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E3")]
		[Address(RVA = "0x1031FCC", Offset = "0x1031FCC", VA = "0x1031FCC")]
		private static void SetPlatform60FPS(bool enabled)
		{
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x000112C8 File Offset: 0x0000F4C8
		// (set) Token: 0x060022E4 RID: 8932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054F")]
		public static bool Setting_Target60FPS
		{
			[Token(Token = "0x60022E5")]
			[Address(RVA = "0x10321A8", Offset = "0x10321A8", VA = "0x10321A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022E4")]
			[Address(RVA = "0x10320D4", Offset = "0x10320D4", VA = "0x10320D4")]
			set
			{
			}
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x000112E0 File Offset: 0x0000F4E0
		[Token(Token = "0x60022E6")]
		[Address(RVA = "0x103220C", Offset = "0x103220C", VA = "0x103220C")]
		private ButtonControlMode GetPanModeSetting(string id, ButtonControlMode defaultValue)
		{
			return ButtonControlMode.Hold;
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E7")]
		[Address(RVA = "0x102AD2C", Offset = "0x102AD2C", VA = "0x102AD2C")]
		public void LoadSettings(bool allowLoad = true)
		{
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E8")]
		[Address(RVA = "0x1033078", Offset = "0x1033078", VA = "0x1033078")]
		protected void OpenLegacySettings()
		{
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E9")]
		[Address(RVA = "0x1034B90", Offset = "0x1034B90", VA = "0x1034B90")]
		public static void UpdateTrialMode()
		{
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x000112F8 File Offset: 0x0000F4F8
		[Token(Token = "0x60022EA")]
		[Address(RVA = "0x1034CC0", Offset = "0x1034CC0", VA = "0x1034CC0")]
		public static bool IsTrialMode()
		{
			return default(bool);
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022EB")]
		[Address(RVA = "0x1034D24", Offset = "0x1034D24", VA = "0x1034D24")]
		public static void ErasePlayer(int i)
		{
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022EC")]
		[Address(RVA = "0x1035310", Offset = "0x1035310", VA = "0x1035310")]
		public static void EraseWorld(int i)
		{
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022ED")]
		[Address(RVA = "0x103562C", Offset = "0x103562C", VA = "0x103562C")]
		public static string GetPlayerPathFromName(string playerName, bool cloudSave)
		{
			return null;
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EE")]
		[Address(RVA = "0x1035F04", Offset = "0x1035F04", VA = "0x1035F04")]
		public static string GetWorldNameFromPath(string filename)
		{
			return null;
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EF")]
		[Address(RVA = "0x1035FA4", Offset = "0x1035FA4", VA = "0x1035FA4")]
		public static string GetPlayerNameFromPath(string filename)
		{
			return null;
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F0")]
		[Address(RVA = "0x10360C8", Offset = "0x10360C8", VA = "0x10360C8")]
		public static string GetWorldPathFromName(string worldName, bool cloudSave)
		{
			return null;
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F1")]
		[Address(RVA = "0x1036998", Offset = "0x1036998", VA = "0x1036998")]
		public void setServerWorldRollbacks(string rollBacksToKeep)
		{
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F2")]
		[Address(RVA = "0x1036A40", Offset = "0x1036A40", VA = "0x1036A40")]
		public void autoCreate(string worldSize)
		{
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F3")]
		[Address(RVA = "0x1036C28", Offset = "0x1036C28", VA = "0x1036C28")]
		public void NewMOTD(string newMOTD)
		{
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F4")]
		[Address(RVA = "0x1036C90", Offset = "0x1036C90", VA = "0x1036C90")]
		public static string ConvertToSafeArgument(string arg)
		{
			return null;
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F5")]
		[Address(RVA = "0x1036CF8", Offset = "0x1036CF8", VA = "0x1036CF8")]
		public static string ConvertFromSafeArgument(string arg)
		{
			return null;
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F6")]
		[Address(RVA = "0x1036D60", Offset = "0x1036D60", VA = "0x1036D60")]
		public void LoadDedConfig(string configPath)
		{
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F7")]
		[Address(RVA = "0x103872C", Offset = "0x103872C", VA = "0x103872C")]
		public void SetNetPlayers(int mPlayers)
		{
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F8")]
		[Address(RVA = "0x1038794", Offset = "0x1038794", VA = "0x1038794")]
		public void SetWorld(string world, bool cloud)
		{
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F9")]
		[Address(RVA = "0x1038828", Offset = "0x1038828", VA = "0x1038828")]
		public void SetWorldName(string world)
		{
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FA")]
		[Address(RVA = "0x1038890", Offset = "0x1038890", VA = "0x1038890")]
		public void EnableAutoShutdown()
		{
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FB")]
		[Address(RVA = "0x1038904", Offset = "0x1038904", VA = "0x1038904")]
		public void AutoPass()
		{
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FC")]
		[Address(RVA = "0x103896C", Offset = "0x103896C", VA = "0x103896C")]
		public void AutoJoin(string IP)
		{
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FD")]
		[Address(RVA = "0x1038A30", Offset = "0x1038A30", VA = "0x1038A30")]
		public void AutoHost()
		{
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FE")]
		[Address(RVA = "0x1038BB0", Offset = "0x1038BB0", VA = "0x1038BB0")]
		public void loadLib(string path)
		{
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FF")]
		[Address(RVA = "0x1038CC0", Offset = "0x1038CC0", VA = "0x1038CC0")]
		public void NeverSleep()
		{
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002300")]
		[Address(RVA = "0x1038CC4", Offset = "0x1038CC4", VA = "0x1038CC4")]
		public void YouCanSleepNow()
		{
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002301")]
		[Address(RVA = "0x1038CC8", Offset = "0x1038CC8", VA = "0x1038CC8")]
		public static void RunServerCallBack(object threadContext)
		{
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002302")]
		[Address(RVA = "0x103B404", Offset = "0x103B404", VA = "0x103B404")]
		public static void RunDedServ(string worldName, string password)
		{
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002303")]
		[Address(RVA = "0x103A0E0", Offset = "0x103A0E0", VA = "0x103A0E0")]
		public void DedServ()
		{
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002304")]
		[Address(RVA = "0x103B79C", Offset = "0x103B79C", VA = "0x103B79C")]
		private static void DedServ_SeedFlagsMenu()
		{
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002305")]
		[Address(RVA = "0x103B6B4", Offset = "0x103B6B4", VA = "0x103B6B4")]
		private static void WriteFancyWorldLoadErrorToConsole()
		{
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002306")]
		[Address(RVA = "0x103BFE8", Offset = "0x103BFE8", VA = "0x103BFE8")]
		public static void startDedInput()
		{
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002307")]
		[Address(RVA = "0x103C150", Offset = "0x103C150", VA = "0x103C150")]
		public static void startDedInputCallBack()
		{
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002308")]
		[Address(RVA = "0x103BF78", Offset = "0x103BF78", VA = "0x103BF78")]
		private static string ReadLineInput()
		{
			return null;
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x00011310 File Offset: 0x0000F510
		[Token(Token = "0x6002309")]
		[Address(RVA = "0x10405B4", Offset = "0x10405B4", VA = "0x10405B4")]
		public static bool IsFastForwardingTime()
		{
			return default(bool);
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230A")]
		[Address(RVA = "0x1040654", Offset = "0x1040654", VA = "0x1040654")]
		public static void Sundialing()
		{
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230B")]
		[Address(RVA = "0x104083C", Offset = "0x104083C", VA = "0x104083C")]
		public static void Moondialing()
		{
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230C")]
		[Address(RVA = "0x1040A24", Offset = "0x1040A24", VA = "0x1040A24")]
		public static void UpdateTimeRate()
		{
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230D")]
		[Address(RVA = "0x10394D0", Offset = "0x10394D0", VA = "0x10394D0")]
		public Main()
		{
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230E")]
		[Address(RVA = "0x1040D90", Offset = "0x1040D90", VA = "0x1040D90")]
		protected void SetTitle()
		{
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230F")]
		[Address(RVA = "0x1040E3C", Offset = "0x1040E3C", VA = "0x1040E3C")]
		private static void SetTileValue()
		{
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002310")]
		[Address(RVA = "0x1041560", Offset = "0x1041560", VA = "0x1041560")]
		private static void ResetGameCounter()
		{
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002311")]
		[Address(RVA = "0x10415C8", Offset = "0x10415C8", VA = "0x10415C8", Slot = "7")]
		protected override void Initialize()
		{
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002312")]
		[Address(RVA = "0x1041E64", Offset = "0x1041E64", VA = "0x1041E64")]
		private void Initialize_AlmostEverything()
		{
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002313")]
		[Address(RVA = "0x1043DDC", Offset = "0x1043DDC", VA = "0x1043DDC")]
		private void Initialize_Entities()
		{
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002314")]
		[Address(RVA = "0x1067450", Offset = "0x1067450", VA = "0x1067450")]
		private static void Initialize_Items()
		{
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002315")]
		[Address(RVA = "0x1058DA8", Offset = "0x1058DA8", VA = "0x1058DA8")]
		private static void Initialize_TileAndNPCData2()
		{
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002316")]
		[Address(RVA = "0x107B6DC", Offset = "0x107B6DC", VA = "0x107B6DC")]
		private static void AddEchoFurnitureTile(int tileId)
		{
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002317")]
		[Address(RVA = "0x1044688", Offset = "0x1044688", VA = "0x1044688")]
		private static void Initialize_TileAndNPCData1()
		{
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002318")]
		[Address(RVA = "0x10433C0", Offset = "0x10433C0", VA = "0x10433C0")]
		private void ClientInitialize()
		{
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002319")]
		[Address(RVA = "0x107B7A0", Offset = "0x107B7A0", VA = "0x107B7A0")]
		private static void CacheSupportedDisplaySizes()
		{
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231A")]
		[Address(RVA = "0x107BBFC", Offset = "0x107BBFC", VA = "0x107BBFC")]
		private static void CollectDisplayResolutionsFromAdapter(GraphicsAdapter adapter)
		{
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231B")]
		[Address(RVA = "0x107C01C", Offset = "0x107C01C", VA = "0x107C01C")]
		private static void RegisterDisplayResolution(int width, int height)
		{
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x00011328 File Offset: 0x0000F528
		[Token(Token = "0x600231C")]
		[Address(RVA = "0x107C184", Offset = "0x107C184", VA = "0x107C184")]
		private static bool IsModeOfSameResolutionRegistered(DisplayMode mode)
		{
			return default(bool);
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231D")]
		[Address(RVA = "0x107C298", Offset = "0x107C298", VA = "0x107C298")]
		public static void LoadTestLog(string logname)
		{
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231E")]
		[Address(RVA = "0x107C29C", Offset = "0x107C29C", VA = "0x107C29C")]
		private void OnceFailedLoadingAnAsset(string assetPath, Exception e)
		{
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231F")]
		[Address(RVA = "0x107C2A0", Offset = "0x107C2A0", VA = "0x107C2A0")]
		public static void ProcessAsyncLoad()
		{
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002320")]
		[Address(RVA = "0x107C38C", Offset = "0x107C38C", VA = "0x107C38C")]
		private void AssetWatcherValueUpdated(IAsset asset)
		{
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002321")]
		[Address(RVA = "0x107C8AC", Offset = "0x107C8AC", VA = "0x107C8AC")]
		private void AssetWatcherUpdateFailed(IAsset asset, Exception e)
		{
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002322")]
		[Address(RVA = "0x107CA4C", Offset = "0x107CA4C", VA = "0x107CA4C", Slot = "8")]
		protected override void LoadContent()
		{
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002323")]
		[Address(RVA = "0x107D158", Offset = "0x107D158", VA = "0x107D158")]
		private void LoadContent_Shaders()
		{
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002324")]
		[Address(RVA = "0x10433BC", Offset = "0x10433BC", VA = "0x10433BC")]
		private void LoadContent_TryEnteringHiDef()
		{
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002325")]
		[Address(RVA = "0x107D410", Offset = "0x107D410", VA = "0x107D410")]
		protected IEnumerator LoadContent_Deferred()
		{
			return null;
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002326")]
		[Address(RVA = "0x107D4A0", Offset = "0x107D4A0", VA = "0x107D4A0")]
		private void TickLoadProcess()
		{
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002327")]
		[Address(RVA = "0x107D558", Offset = "0x107D558", VA = "0x107D558")]
		private static void PostContentLoadInitialize()
		{
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002328")]
		[Address(RVA = "0x107D7EC", Offset = "0x107D7EC", VA = "0x107D7EC")]
		private IEnumerator LoadMusic_InSteps()
		{
			return null;
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002329")]
		[Address(RVA = "0x107D85C", Offset = "0x107D85C", VA = "0x107D85C", Slot = "9")]
		protected override void UnloadContent()
		{
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600232A")]
		[Address(RVA = "0x107D860", Offset = "0x107D860", VA = "0x107D860")]
		public static void CheckForMoonEventsStartingTemporarySeasons()
		{
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600232B")]
		[Address(RVA = "0x107DD90", Offset = "0x107DD90", VA = "0x107DD90")]
		public static void CheckForMoonEventsScoreDisplay()
		{
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600232C")]
		[Address(RVA = "0x107E04C", Offset = "0x107E04C", VA = "0x107E04C")]
		public static void stopMoonEvent()
		{
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600232D")]
		[Address(RVA = "0x107E2BC", Offset = "0x107E2BC", VA = "0x107E2BC")]
		public static void startPumpkinMoon()
		{
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600232E")]
		[Address(RVA = "0x107E5B0", Offset = "0x107E5B0", VA = "0x107E5B0")]
		public static void startSnowMoon()
		{
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600232F")]
		[Address(RVA = "0x107E8BC", Offset = "0x107E8BC", VA = "0x107E8BC")]
		public void UpdateAudio()
		{
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x00011340 File Offset: 0x0000F540
		[Token(Token = "0x17000550")]
		public static bool IsItAHappyWindyDay
		{
			[Token(Token = "0x6002330")]
			[Address(RVA = "0x108A5C4", Offset = "0x108A5C4", VA = "0x108A5C4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x00011358 File Offset: 0x0000F558
		[Token(Token = "0x17000551")]
		public static bool IsItStorming
		{
			[Token(Token = "0x6002331")]
			[Address(RVA = "0x108A628", Offset = "0x108A628", VA = "0x108A628")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x00011370 File Offset: 0x0000F570
		[Token(Token = "0x17000552")]
		public static bool WindyEnoughForKiteDrops
		{
			[Token(Token = "0x6002332")]
			[Address(RVA = "0x108A68C", Offset = "0x108A68C", VA = "0x108A68C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002333")]
		[Address(RVA = "0x10878A0", Offset = "0x10878A0", VA = "0x10878A0")]
		private void UpdateAudio_DecideOnTOWMusic()
		{
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002334")]
		[Address(RVA = "0x1082A70", Offset = "0x1082A70", VA = "0x1082A70")]
		private void UpdateAudio_DecideOnNewMusic()
		{
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002335")]
		[Address(RVA = "0x108A7C8", Offset = "0x108A7C8", VA = "0x108A7C8")]
		private void UpdateWindyDayState()
		{
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002336")]
		[Address(RVA = "0x108ABF0", Offset = "0x108ABF0", VA = "0x108ABF0")]
		public static void snowing()
		{
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002337")]
		[Address(RVA = "0x108BEF0", Offset = "0x108BEF0", VA = "0x108BEF0")]
		public static void checkXMas()
		{
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00011388 File Offset: 0x0000F588
		[Token(Token = "0x6002338")]
		[Address(RVA = "0x108C07C", Offset = "0x108C07C", VA = "0x108C07C")]
		public static bool isHalloweenDateNow()
		{
			return default(bool);
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002339")]
		[Address(RVA = "0x108C154", Offset = "0x108C154", VA = "0x108C154")]
		public static void checkHalloween()
		{
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233A")]
		[Address(RVA = "0x108C278", Offset = "0x108C278", VA = "0x108C278")]
		public void updateCloudLayer()
		{
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233B")]
		[Address(RVA = "0x108C954", Offset = "0x108C954", VA = "0x108C954")]
		public static void TeleportEffect(Rectangle effectRect, int Style, int extraInfo = 0, float dustCountMult = 1f, TeleportationSide side = TeleportationSide.Entry, [Optional] Vector2 otherPosition)
		{
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233C")]
		[Address(RVA = "0x108F2A0", Offset = "0x108F2A0", VA = "0x108F2A0")]
		public static void Ambience()
		{
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233D")]
		[Address(RVA = "0x1067834", Offset = "0x1067834", VA = "0x1067834")]
		public static void AnimateTiles_CritterCages()
		{
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233E")]
		[Address(RVA = "0x108FB60", Offset = "0x108FB60", VA = "0x108FB60")]
		private static void UpdateOwlCageFrames()
		{
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233F")]
		[Address(RVA = "0x108FC04", Offset = "0x108FC04", VA = "0x108FC04")]
		private static void UpdateDragonflyJarFrames()
		{
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002340")]
		[Address(RVA = "0x108FD04", Offset = "0x108FD04", VA = "0x108FD04")]
		private static void UpdateOwlCageFrame(int[] frames, int[] frameCounters, int style)
		{
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002341")]
		[Address(RVA = "0x108FF1C", Offset = "0x108FF1C", VA = "0x108FF1C")]
		private static void UpdateDragonflyJarFrame(int[,] frames, int[,] frameCounters, int style, int variation)
		{
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002342")]
		[Address(RVA = "0x10902BC", Offset = "0x10902BC", VA = "0x10902BC")]
		public static void DoUpdate_AnimateItemIcons()
		{
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002343")]
		[Address(RVA = "0x1090430", Offset = "0x1090430", VA = "0x1090430")]
		public static void QueueMainThreadAction(Action action)
		{
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002344")]
		[Address(RVA = "0x10904D0", Offset = "0x10904D0", VA = "0x10904D0")]
		public static Task RunOnMainThread(Action action)
		{
			return null;
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002345")]
		public static Task<T> RunOnMainThread<T>(Func<T> func)
		{
			return null;
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002346")]
		[Address(RVA = "0x1090610", Offset = "0x1090610", VA = "0x1090610")]
		private static void ConsumeAllMainThreadActions()
		{
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002347")]
		[Address(RVA = "0x10906F0", Offset = "0x10906F0", VA = "0x10906F0", Slot = "5")]
		protected override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002348")]
		[Address(RVA = "0x10961A4", Offset = "0x10961A4", VA = "0x10961A4")]
		public void UpdateViewZoomKeys()
		{
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002349")]
		[Address(RVA = "0x1096448", Offset = "0x1096448", VA = "0x1096448")]
		public static void NotifyOfEvent(GameNotificationType type)
		{
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234A")]
		[Address(RVA = "0x10909F0", Offset = "0x10909F0", VA = "0x10909F0")]
		protected void DoUpdate(GameTime gameTime)
		{
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234B")]
		[Address(RVA = "0x109644C", Offset = "0x109644C", VA = "0x109644C")]
		internal static void UpdateCreativeGameModeOverride()
		{
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234C")]
		[Address(RVA = "0x1096F64", Offset = "0x1096F64", VA = "0x1096F64")]
		private static void TryPlayingCreditsRoll()
		{
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x000113A0 File Offset: 0x0000F5A0
		[Token(Token = "0x600234D")]
		[Address(RVA = "0x10A2F7C", Offset = "0x10A2F7C", VA = "0x10A2F7C")]
		public static bool CanPauseGame()
		{
			return default(bool);
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234E")]
		[Address(RVA = "0x10A345C", Offset = "0x10A345C", VA = "0x10A345C")]
		private static void DoUpdate_WhilePaused()
		{
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234F")]
		[Address(RVA = "0x1097254", Offset = "0x1097254", VA = "0x1097254")]
		private static void UpdateUIStates(GameTime gameTime)
		{
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002350")]
		[Address(RVA = "0x10A085C", Offset = "0x10A085C", VA = "0x10A085C")]
		private void DoDebugFunctions()
		{
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002351")]
		[Address(RVA = "0x10AB890", Offset = "0x10AB890", VA = "0x10AB890")]
		public void ToggleHorizonRenderer()
		{
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002352")]
		[Address(RVA = "0x10AB900", Offset = "0x10AB900", VA = "0x10AB900")]
		private void PreUpdateAllProjectiles()
		{
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002353")]
		[Address(RVA = "0x10AB9D0", Offset = "0x10AB9D0", VA = "0x10AB9D0")]
		private void PostUpdateAllProjectiles()
		{
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002354")]
		[Address(RVA = "0x10A1348", Offset = "0x10A1348", VA = "0x10A1348")]
		private static void TrySyncingMyPlayer()
		{
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002355")]
		[Address(RVA = "0x10AB9D4", Offset = "0x10AB9D4", VA = "0x10AB9D4")]
		private static void TrySyncingItemArray(ref bool syncedAnyInventoryContents, Item[] my, Item[] other, int slotOffset)
		{
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x000113B8 File Offset: 0x0000F5B8
		[Token(Token = "0x6002356")]
		[Address(RVA = "0x10A7620", Offset = "0x10A7620", VA = "0x10A7620")]
		public bool ShouldUpdateEntities()
		{
			return default(bool);
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002357")]
		[Address(RVA = "0x10A76D4", Offset = "0x10A76D4", VA = "0x10A76D4")]
		private void DoUpdateInWorld()
		{
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002358")]
		[Address(RVA = "0x10ABBD8", Offset = "0x10ABBD8", VA = "0x10ABBD8")]
		private static void CheckBossIndexes()
		{
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x000113D0 File Offset: 0x0000F5D0
		[Token(Token = "0x6002359")]
		[Address(RVA = "0x10B1B08", Offset = "0x10B1B08", VA = "0x10B1B08")]
		public static bool IsNPCActiveAndOneOfTypes(int npcIndex, short npcType)
		{
			return default(bool);
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235A")]
		[Address(RVA = "0x10973C4", Offset = "0x10973C4", VA = "0x10973C4")]
		private static void UpdateOldNPCShop()
		{
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235B")]
		[Address(RVA = "0x10987D4", Offset = "0x10987D4", VA = "0x10987D4")]
		private static void DoUpdate_AnimateCursorColors()
		{
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235C")]
		[Address(RVA = "0x1098974", Offset = "0x1098974", VA = "0x1098974")]
		private static void DoUpdate_AnimateTileGlows()
		{
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235D")]
		[Address(RVA = "0x10A0858", Offset = "0x10A0858", VA = "0x10A0858")]
		private static void DoUpdate_Enter_ToggleChat()
		{
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235E")]
		[Address(RVA = "0x10B22F8", Offset = "0x10B22F8", VA = "0x10B22F8")]
		public static void OpenPlayerChat()
		{
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235F")]
		[Address(RVA = "0x10B24E8", Offset = "0x10B24E8", VA = "0x10B24E8")]
		public static void ClosePlayerChat()
		{
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002360")]
		[Address(RVA = "0x10A0854", Offset = "0x10A0854", VA = "0x10A0854")]
		private static void DoUpdate_HandleChat()
		{
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002361")]
		[Address(RVA = "0x10A0638", Offset = "0x10A0638", VA = "0x10A0638")]
		private void DoUpdate_HandleInput()
		{
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002362")]
		[Address(RVA = "0x10A042C", Offset = "0x10A042C", VA = "0x10A042C")]
		private static void DoUpdate_AltEnter_ToggleFullscreen()
		{
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002363")]
		[Address(RVA = "0x10A0428", Offset = "0x10A0428", VA = "0x10A0428")]
		private static void DoUpdate_F11_ToggleUI()
		{
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002364")]
		[Address(RVA = "0x10A0424", Offset = "0x10A0424", VA = "0x10A0424")]
		private static void DoUpdate_F7_ToggleGraphicsDiagnostics()
		{
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002365")]
		[Address(RVA = "0x10A0420", Offset = "0x10A0420", VA = "0x10A0420")]
		private static void DoUpdate_F8_ToggleNetDiagnostics()
		{
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002366")]
		[Address(RVA = "0x10A041C", Offset = "0x10A041C", VA = "0x10A041C")]
		private static void DoUpdate_F9_ToggleLighting()
		{
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002367")]
		[Address(RVA = "0x10A0418", Offset = "0x10A0418", VA = "0x10A0418")]
		private static void DoUpdate_F10_ToggleFPS()
		{
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002368")]
		[Address(RVA = "0x109A730", Offset = "0x109A730", VA = "0x109A730")]
		private static void AnimateTiles()
		{
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002369")]
		[Address(RVA = "0x10B27AC", Offset = "0x10B27AC", VA = "0x10B27AC")]
		private static void AnimateTiles_WeatherVane()
		{
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236A")]
		[Address(RVA = "0x109954C", Offset = "0x109954C", VA = "0x109954C")]
		private static void DoUpdate_AnimateWalls()
		{
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236B")]
		[Address(RVA = "0x109931C", Offset = "0x109931C", VA = "0x109931C")]
		private void DoUpdate_AnimateWaterfalls()
		{
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236C")]
		[Address(RVA = "0x1098E8C", Offset = "0x1098E8C", VA = "0x1098E8C")]
		private static void DoUpdate_AnimateVisualPlayerAura()
		{
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236D")]
		[Address(RVA = "0x1098B38", Offset = "0x1098B38", VA = "0x1098B38")]
		private void DoUpdate_AnimateDiscoRGB()
		{
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236E")]
		[Address(RVA = "0x109731C", Offset = "0x109731C", VA = "0x109731C")]
		private static void DoUpdate_AnimateBackgrounds()
		{
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236F")]
		[Address(RVA = "0x10B2C10", Offset = "0x10B2C10", VA = "0x10B2C10")]
		private static void DoUpdate_AnimateBackgrounds_UpdateForest(int bgIndex, int[] bgSet)
		{
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002370")]
		[Address(RVA = "0x1096730", Offset = "0x1096730", VA = "0x1096730")]
		private static void DoUpdate_AutoSave()
		{
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002371")]
		[Address(RVA = "0x10B35BC", Offset = "0x10B35BC", VA = "0x10B35BC")]
		private static void UpdateSettingUnlocks()
		{
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002372")]
		[Address(RVA = "0x10AB250", Offset = "0x10AB250", VA = "0x10AB250")]
		public static void InputTextSign()
		{
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002373")]
		[Address(RVA = "0x10AB4FC", Offset = "0x10AB4FC", VA = "0x10AB4FC")]
		public static void InputTextChest()
		{
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002374")]
		[Address(RVA = "0x10B42E0", Offset = "0x10B42E0", VA = "0x10B42E0")]
		public static void InputTextSignCancel()
		{
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002375")]
		[Address(RVA = "0x10975D0", Offset = "0x10975D0", VA = "0x10975D0")]
		private static void UpdateMenu()
		{
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002376")]
		[Address(RVA = "0x10B23D4", Offset = "0x10B23D4", VA = "0x10B23D4")]
		public static void clrInput()
		{
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x000113E8 File Offset: 0x0000F5E8
		[Token(Token = "0x17000553")]
		public static bool HasKeyboard
		{
			[Token(Token = "0x6002377")]
			[Address(RVA = "0x10B459C", Offset = "0x10B459C", VA = "0x10B459C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x00011400 File Offset: 0x0000F600
		[Token(Token = "0x17000554")]
		public static bool KeyboardIsActive
		{
			[Token(Token = "0x6002378")]
			[Address(RVA = "0x10B4608", Offset = "0x10B4608", VA = "0x10B4608")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002379")]
		[Address(RVA = "0x10B46B8", Offset = "0x10B46B8", VA = "0x10B46B8")]
		public static void OpenKeyboard(string initial, int maxCharacters = -1, bool password = false, bool multiline = false, bool filterText = true)
		{
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237A")]
		[Address(RVA = "0x10AB154", Offset = "0x10AB154", VA = "0x10AB154")]
		public static void CloseKeyboard()
		{
		}

		// Token: 0x0600237B RID: 9083
		[Token(Token = "0x600237B")]
		[Address(RVA = "0x10B4860", Offset = "0x10B4860", VA = "0x10B4860")]
		[PreserveSig]
		public static extern short GetKeyState(int keyCode);

		// Token: 0x0600237C RID: 9084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600237C")]
		[Address(RVA = "0x10B3790", Offset = "0x10B3790", VA = "0x10B3790")]
		public static string GetInputText(string oldString, Rectangle region, int maxCharacters = -1, bool password = false, bool retainText = false, bool multiline = false, bool filterText = true)
		{
			return null;
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237D")]
		[Address(RVA = "0x10B4900", Offset = "0x10B4900", VA = "0x10B4900")]
		public void MouseTextHackZoom(string text, [Optional] string buffTooltip)
		{
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237E")]
		[Address(RVA = "0x10B4920", Offset = "0x10B4920", VA = "0x10B4920")]
		public void MouseTextHackZoom(string text, int itemRarity, byte diff = 0, [Optional] string buffTooltip)
		{
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237F")]
		[Address(RVA = "0x10B4B10", Offset = "0x10B4B10", VA = "0x10B4B10")]
		public void MouseTextNoOverride(string cursorText, int rare = 0, byte diff = 0, int hackedMouseX = -1, int hackedMouseY = -1, int hackedScreenWidth = -1, int hackedScreenHeight = -1, int pushWidthX = 0)
		{
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002380")]
		[Address(RVA = "0x10B4C00", Offset = "0x10B4C00", VA = "0x10B4C00")]
		public void MouseText(string cursorText, int rare = 0, byte diff = 0, int hackedMouseX = -1, int hackedMouseY = -1, int hackedScreenWidth = -1, int hackedScreenHeight = -1, int pushWidthX = 0)
		{
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002381")]
		[Address(RVA = "0x10B4CF0", Offset = "0x10B4CF0", VA = "0x10B4CF0")]
		public static Item DisplayAndGetFakeItem(ItemRarityColor color)
		{
			return null;
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002382")]
		[Address(RVA = "0x10B4E90", Offset = "0x10B4E90", VA = "0x10B4E90")]
		public static void ClearHoverItem()
		{
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002383")]
		[Address(RVA = "0x10B4A08", Offset = "0x10B4A08", VA = "0x10B4A08")]
		public void MouseText(string cursorText, string buffTooltip, int rare = 0, byte diff = 0, int hackedMouseX = -1, int hackedMouseY = -1, int hackedScreenWidth = -1, int hackedScreenHeight = -1, int pushWidthX = 0, bool noOverride = false)
		{
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002384")]
		[Address(RVA = "0x10B4F10", Offset = "0x10B4F10", VA = "0x10B4F10")]
		private void MouseTextInner(Main.MouseTextCache info, bool worldMouse)
		{
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002385")]
		[Address(RVA = "0x10B6268", Offset = "0x10B6268", VA = "0x10B6268")]
		private void MouseText_DrawItemTooltip(Main.MouseTextCache info, int rare, byte diff, int X, int Y)
		{
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002386")]
		[Address(RVA = "0x10BCE78", Offset = "0x10BCE78", VA = "0x10BCE78")]
		public static void MouseText_DrawItemTooltip_GetLinesInfo(Item item, ref int yoyoLogo, ref int researchLine, ref int materialsLine, float oldKB, ref int numLines, string[] toolTipLine, bool[] preFixLine, bool[] badPreFixLine, ref int setBonusLine, ref Color setBonusColour, ref int sharedLine)
		{
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002387")]
		[Address(RVA = "0x10BB9AC", Offset = "0x10BB9AC", VA = "0x10BB9AC")]
		private void MouseText_DrawBuffTooltip(string cursorText, string buffString, ref int X, ref int Y)
		{
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002388")]
		[Address(RVA = "0x10C399C", Offset = "0x10C399C", VA = "0x10C399C")]
		protected void DrawFPS()
		{
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002389")]
		[Address(RVA = "0x10C4110", Offset = "0x10C4110", VA = "0x10C4110")]
		public static void shine(ref Color newColor, int type)
		{
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238A")]
		[Address(RVA = "0x10C4864", Offset = "0x10C4864", VA = "0x10C4864")]
		public static void shine(ref Vector3 newColor, int type, int frameX)
		{
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238B")]
		[Address(RVA = "0x10C4D54", Offset = "0x10C4D54", VA = "0x10C4D54")]
		private void DrawTileEntities(bool solidLayer, bool overRenderTargets, bool intoRenderTargets)
		{
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238C")]
		[Address(RVA = "0x10C4D9C", Offset = "0x10C4D9C", VA = "0x10C4D9C")]
		public void ClearCachedTileDraws()
		{
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238D")]
		[Address(RVA = "0x1032480", Offset = "0x1032480", VA = "0x1032480")]
		public static void SetUseHorizonRender(bool horizonEnabled)
		{
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238E")]
		[Address(RVA = "0x10C4DE8", Offset = "0x10C4DE8", VA = "0x10C4DE8")]
		public void ResetAllContentBasedRenderTargets()
		{
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x00011418 File Offset: 0x0000F618
		[Token(Token = "0x600238F")]
		[Address(RVA = "0x10C4F68", Offset = "0x10C4F68", VA = "0x10C4F68")]
		public static bool IsTileSpelunkable(Tile t)
		{
			return default(bool);
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x00011430 File Offset: 0x0000F630
		[Token(Token = "0x6002390")]
		[Address(RVA = "0x10C51CC", Offset = "0x10C51CC", VA = "0x10C51CC")]
		public static bool IsTileSpelunkable(ushort typeCache, short tileFrameX, short tileFrameY)
		{
			return default(bool);
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x00011448 File Offset: 0x0000F648
		[Token(Token = "0x6002391")]
		[Address(RVA = "0x10C52A8", Offset = "0x10C52A8", VA = "0x10C52A8")]
		public static bool IsTileBiomeSightable(ushort type, short tileFrameX, short tileFrameY, ref Color sightColor)
		{
			return default(bool);
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002392")]
		[Address(RVA = "0x10C54B8", Offset = "0x10C54B8", VA = "0x10C54B8")]
		protected void DrawTiles(bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
		{
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002393")]
		[Address(RVA = "0x10C5508", Offset = "0x10C5508", VA = "0x10C5508")]
		protected void DrawGoreBehind()
		{
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002394")]
		[Address(RVA = "0x10C61B8", Offset = "0x10C61B8", VA = "0x10C61B8")]
		protected void DrawGore()
		{
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002395")]
		[Address(RVA = "0x10C6AF0", Offset = "0x10C6AF0", VA = "0x10C6AF0")]
		public void DrawHealthBar(float X, float Y, int Health, int MaxHealth, float alpha, float scale = 1f, bool noFlip = false, bool inUISpace = false)
		{
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x00011460 File Offset: 0x0000F660
		[Token(Token = "0x6002396")]
		[Address(RVA = "0x10C7930", Offset = "0x10C7930", VA = "0x10C7930")]
		public static float NPCAddHeight(NPC theNPC)
		{
			return 0f;
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002397")]
		[Address(RVA = "0x10C827C", Offset = "0x10C827C", VA = "0x10C827C")]
		internal void DrawProjectiles()
		{
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x00011478 File Offset: 0x0000F678
		[Token(Token = "0x6002398")]
		[Address(RVA = "0x10C8C60", Offset = "0x10C8C60", VA = "0x10C8C60")]
		public static int GetProjectileDesiredShader(Projectile proj)
		{
			return 0;
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002399")]
		[Address(RVA = "0x10C905C", Offset = "0x10C905C", VA = "0x10C905C")]
		private void RefreshPlayerDrawOrder()
		{
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239A")]
		[Address(RVA = "0x10C9490", Offset = "0x10C9490", VA = "0x10C9490")]
		protected void DrawPlayers_BehindNPCs()
		{
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239B")]
		[Address(RVA = "0x10C98C8", Offset = "0x10C98C8", VA = "0x10C98C8")]
		protected void DrawPlayers_AfterProjectiles()
		{
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239C")]
		[Address(RVA = "0x10C9D00", Offset = "0x10C9D00", VA = "0x10C9D00")]
		protected void DrawElderEye(SpriteBatch spriteBatch, Vector2 worldPosition, float opacity, float scale, int frameNumber, Color passedColor)
		{
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239D")]
		[Address(RVA = "0x10CA020", Offset = "0x10CA020", VA = "0x10CA020")]
		internal void DrawNPCs(bool behindTiles = false)
		{
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239E")]
		[Address(RVA = "0x10CD068", Offset = "0x10CD068", VA = "0x10CD068")]
		protected void DrawNPCCheckAlt(NPC n)
		{
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239F")]
		[Address(RVA = "0x10CD22C", Offset = "0x10CD22C", VA = "0x10CD22C")]
		protected void DrawNPC(NPC npc, bool behindTiles, LightMap lightMap, ref Rectangle lightRegion)
		{
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A0")]
		[Address(RVA = "0x10CD324", Offset = "0x10CD324", VA = "0x10CD324")]
		public void DrawNPCDirect_QueenSlimeWings(NPC rCurrentNPC, SpriteBatch mySpriteBatch, Vector2 screenPos, Vector2 drawCenter, Color originColor)
		{
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A1")]
		[Address(RVA = "0xF355A8", Offset = "0xF355A8", VA = "0xF355A8")]
		public void DrawNPCDirect(SpriteBatch mySpriteBatch, NPC rCurrentNPC, bool behindTiles, Vector2 screenPos)
		{
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A2")]
		[Address(RVA = "0x10CD7D0", Offset = "0x10CD7D0", VA = "0x10CD7D0")]
		private static void GetMoonlordSmolBulletWarningTimes(out int framesBeforeSmolBeam, out int framesBeforeSmolBeam2)
		{
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x00011490 File Offset: 0x0000F690
		[Token(Token = "0x60023A3")]
		[Address(RVA = "0x10CD7E4", Offset = "0x10CD7E4", VA = "0x10CD7E4")]
		private Color GetMoonLordColoring(NPC rCurrentNPC)
		{
			return default(Color);
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A4")]
		[Address(RVA = "0x10CD9C4", Offset = "0x10CD9C4", VA = "0x10CD9C4")]
		private static void DrawNPCDirect_Deerclops(SpriteBatch mySpriteBatch, NPC rCurrentNPC, ref Vector2 screenPos, int typeCache, ref Color npcColor, ref Vector2 halfSize, SpriteEffects npcSpriteEffect)
		{
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A5")]
		[Address(RVA = "0x10CEA4C", Offset = "0x10CEA4C", VA = "0x10CEA4C")]
		private static void DrawNPCDirect_DeerclopsLeg(SpriteBatch mySpriteBatch, NPC rCurrentNPC, ref Vector2 screenPos, int typeCache, ref Color npcColor, ref Vector2 halfSize, SpriteEffects npcSpriteEffect)
		{
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A6")]
		[Address(RVA = "0xF762B8", Offset = "0xF762B8", VA = "0xF762B8")]
		public void DrawNPCDirect(SpriteBatch mySpriteBatch, NPC rCurrentNPC, bool behindTiles, Vector2 screenPos, LightMap lightMap, ref Rectangle lightRegion)
		{
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A7")]
		[Address(RVA = "0x10CED58", Offset = "0x10CED58", VA = "0x10CED58")]
		private static void DrawNPCDirect_Faeling(SpriteBatch mySpriteBatch, NPC rCurrentNPC, ref Vector2 screenPos, int typeCache, ref Color npcColor, ref Vector2 halfSize, SpriteEffects npcSpriteEffect)
		{
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A8")]
		[Address(RVA = "0x10CFB50", Offset = "0x10CFB50", VA = "0x10CFB50")]
		private static void DrawNPCDirect_HallowBoss(SpriteBatch mySpriteBatch, NPC rCurrentNPC, ref Vector2 screenPos, int typeCache, ref Color npcColor, ref Vector2 halfSize, SpriteEffects npcSpriteEffect)
		{
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A9")]
		[Address(RVA = "0x10D2B74", Offset = "0x10D2B74", VA = "0x10D2B74")]
		private static void DrawNPCDirect_GetHallowBossArmFrame(NPC rCurrentNPC, out int armFrame_Count, out int armFrameToUseLeft, out int armFrameToUseRight)
		{
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AA")]
		[Address(RVA = "0x10D3120", Offset = "0x10D3120", VA = "0x10D3120")]
		private static void DrawNPC_SlimeItem(NPC rCurrentNPC, int typeCache, Color npcColor, float addedRotation)
		{
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AB")]
		[Address(RVA = "0x101C96C", Offset = "0x101C96C", VA = "0x101C96C")]
		public static void GetItemDrawFrame(int item, out Texture2D itemTexture, out Rectangle itemFrame)
		{
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AC")]
		[Address(RVA = "0x10D3A28", Offset = "0x10D3A28", VA = "0x10D3A28")]
		protected void DrawNPCExtras(NPC n, bool beforeDraw, float addHeight, float addY, Color npcColor, Vector2 halfSize, SpriteEffects npcSpriteEffect, Vector2 screenPosition)
		{
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AD")]
		[Address(RVA = "0x10D7244", Offset = "0x10D7244", VA = "0x10D7244")]
		private void DrawProj_LightsBane(Projectile proj)
		{
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AE")]
		[Address(RVA = "0x10D8B64", Offset = "0x10D8B64", VA = "0x10D8B64")]
		private void DrawProj_NightsEdge(Projectile proj)
		{
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AF")]
		[Address(RVA = "0x10D9ED8", Offset = "0x10D9ED8", VA = "0x10D9ED8")]
		private void DrawProj_DeadCellsFlintSlash(Projectile proj)
		{
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B0")]
		[Address(RVA = "0x10DACAC", Offset = "0x10DACAC", VA = "0x10DACAC")]
		private void DrawProj_Excalibur(Projectile proj)
		{
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B1")]
		[Address(RVA = "0x10DC120", Offset = "0x10DC120", VA = "0x10DC120")]
		private void DrawProj_TheHorsemansBlade(Projectile proj)
		{
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B2")]
		[Address(RVA = "0x10DD59C", Offset = "0x10DD59C", VA = "0x10DD59C")]
		private void DrawProj_ChlorophyteClaymoreBlade(Projectile proj)
		{
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B3")]
		[Address(RVA = "0x10DEC60", Offset = "0x10DEC60", VA = "0x10DEC60")]
		private void DrawProj_TrueExcalibur(Projectile proj)
		{
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B4")]
		[Address(RVA = "0x10E01B8", Offset = "0x10E01B8", VA = "0x10E01B8")]
		private void DrawProj_TrueNightsEdge(Projectile proj)
		{
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B5")]
		[Address(RVA = "0x10E1A8C", Offset = "0x10E1A8C", VA = "0x10E1A8C")]
		private void DrawProj_TerraBlade2(Projectile proj)
		{
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B6")]
		[Address(RVA = "0x10E2F30", Offset = "0x10E2F30", VA = "0x10E2F30")]
		private void DrawProj_TerraBlade2Shot(Projectile proj)
		{
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B7")]
		[Address(RVA = "0x10C887C", Offset = "0x10C887C", VA = "0x10C887C")]
		public void DrawProj(int i)
		{
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B8")]
		[Address(RVA = "0x10E4DAC", Offset = "0x10E4DAC", VA = "0x10E4DAC")]
		private void DrawContinuousTrail(Projectile proj)
		{
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B9")]
		[Address(RVA = "0x10E55F8", Offset = "0x10E55F8", VA = "0x10E55F8")]
		private void DrawShadow_HallowBossLastingRainbow(Projectile proj, Vector2 drawPositionOffset, int shadowStart, int shadowMax, int shadowSkip, SpriteEffects dir, float toationOffsetForAllDraws, float rotator, float secondaryShadowScaleDivider, float minimalScale, Vector2 drawOrigin, ref Rectangle shadowFrame, Texture2D tex)
		{
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BA")]
		[Address(RVA = "0x10E6044", Offset = "0x10E6044", VA = "0x10E6044")]
		private void DrawShadow_HallowBossRainbowStreak(Projectile proj, Vector2 drawPositionOffset, int shadowStart, int shadowMax, int shadowSkip, SpriteEffects dir, float toationOffsetForAllDraws, float rotator, float secondaryShadowScaleDivider, float minimalScale, Vector2 drawOrigin, ref Rectangle shadowFrame, Texture2D tex)
		{
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BB")]
		[Address(RVA = "0x10E4FB4", Offset = "0x10E4FB4", VA = "0x10E4FB4")]
		private static void DrawTrail(Projectile proj, Vector2 rotatableOffsetFromCenter, Color baseColor)
		{
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BC")]
		[Address(RVA = "0xFB6DA8", Offset = "0xFB6DA8", VA = "0xFB6DA8")]
		public void DrawProjDirect(Projectile proj, [Optional] Player overridePlayer)
		{
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BD")]
		[Address(RVA = "0x10E6F5C", Offset = "0x10E6F5C", VA = "0x10E6F5C")]
		private static void DrawProj_Flamethrower(Projectile proj)
		{
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BE")]
		[Address(RVA = "0x10E825C", Offset = "0x10E825C", VA = "0x10E825C")]
		private static void DrawProj_Flamethrower_Foxsparks(Projectile proj, Player theOwner)
		{
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BF")]
		[Address(RVA = "0x10E9710", Offset = "0x10E9710", VA = "0x10E9710")]
		private static void DrawProj_Spear(Projectile proj, Player theOwner, ref Color projectileColor, ref SpriteEffects dir)
		{
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C0")]
		[Address(RVA = "0x10D9954", Offset = "0x10D9954", VA = "0x10D9954")]
		private static void DrawPrettyStarSparkle(float opacity, SpriteEffects dir, Vector2 drawpos, Color drawColor, Color shineColor, float flareCounter, float fadeInStart, float fadeInEnd, float fadeOutStart, float fadeOutEnd, float rotation, Vector2 scale, Vector2 fatness)
		{
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C1")]
		[Address(RVA = "0x10EAE28", Offset = "0x10EAE28", VA = "0x10EAE28")]
		private static void DrawProj_FlailChains(Projectile proj, Player theOwner, Vector2 mountedCenter)
		{
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C2")]
		[Address(RVA = "0x10EB9B4", Offset = "0x10EB9B4", VA = "0x10EB9B4")]
		private static void DrawProj_FlailChains_Old(Projectile proj, Vector2 mountedCenter)
		{
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x000114A8 File Offset: 0x0000F6A8
		[Token(Token = "0x60023C3")]
		[Address(RVA = "0x10ECC90", Offset = "0x10ECC90", VA = "0x10ECC90")]
		private static Color TryApplyingPlayerStringColor(int playerStringColor, Color stringColor)
		{
			return default(Color);
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C4")]
		[Address(RVA = "0x10ED200", Offset = "0x10ED200", VA = "0x10ED200")]
		private static void DrawProj_FishingLine(Projectile proj, Player theOwner, ref float polePosX, ref float polePosY, Vector2 mountedCenter)
		{
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C5")]
		[Address(RVA = "0x10EE1A4", Offset = "0x10EE1A4", VA = "0x10EE1A4")]
		private void DrawProj_StardustGuardianPunching(Projectile proj)
		{
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C6")]
		[Address(RVA = "0x10EEA10", Offset = "0x10EEA10", VA = "0x10EEA10")]
		private void DrawProj_PiercingStarlight(Projectile proj)
		{
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C7")]
		[Address(RVA = "0x10EFA20", Offset = "0x10EFA20", VA = "0x10EFA20")]
		private void DrawProj_FairyQueenLance(Projectile proj)
		{
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C8")]
		[Address(RVA = "0x10F0750", Offset = "0x10F0750", VA = "0x10F0750")]
		private void DrawProj_FairyQueenRangedItemShot(Projectile proj)
		{
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C9")]
		[Address(RVA = "0x10F0FD0", Offset = "0x10F0FD0", VA = "0x10F0FD0")]
		private void DrawProj_EmpressBlade(Projectile proj, float hueOverride)
		{
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CA")]
		[Address(RVA = "0x10F1CAC", Offset = "0x10F1CAC", VA = "0x10F1CAC")]
		private void DrawProj_CoolWhipMinion(Projectile proj)
		{
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CB")]
		[Address(RVA = "0x10F2384", Offset = "0x10F2384", VA = "0x10F2384")]
		private void DrawMurderAurora(Projectile proj)
		{
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CC")]
		[Address(RVA = "0x10F2A70", Offset = "0x10F2A70", VA = "0x10F2A70")]
		private void DrawWhip(Projectile proj, Player theOwner)
		{
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x000114C0 File Offset: 0x0000F6C0
		[Token(Token = "0x60023CD")]
		[Address(RVA = "0x10FB4D0", Offset = "0x10FB4D0", VA = "0x10FB4D0")]
		public static Vector2 DrawWhip_SlimeWhip(Projectile proj, List<Vector2> controlPoints)
		{
			return default(Vector2);
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x000114D8 File Offset: 0x0000F6D8
		[Token(Token = "0x60023CE")]
		[Address(RVA = "0x10F7F84", Offset = "0x10F7F84", VA = "0x10F7F84")]
		public static Vector2 DrawWhip_GenericWhip(Projectile proj, List<Vector2> controlPoints, int segmentCount, float startWidth = 1f, float endWidth = 1f)
		{
			return default(Vector2);
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x000114F0 File Offset: 0x0000F6F0
		[Token(Token = "0x60023CF")]
		[Address(RVA = "0x10F8E40", Offset = "0x10F8E40", VA = "0x10F8E40")]
		public static Vector2 DrawWhip_FlowerWhip(Projectile proj, List<Vector2> controlPoints, int segmentCount, float startWidth = 1f, float endWidth = 1f)
		{
			return default(Vector2);
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x00011508 File Offset: 0x0000F708
		[Token(Token = "0x60023D0")]
		[Address(RVA = "0x10FA098", Offset = "0x10FA098", VA = "0x10FA098")]
		public static Vector2 DrawWhip_Constellation(Projectile proj, List<Vector2> controlPoints, int segmentCount, float startWidth = 1f, float endWidth = 1f)
		{
			return default(Vector2);
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x00011520 File Offset: 0x0000F720
		[Token(Token = "0x60023D1")]
		[Address(RVA = "0x10FACEC", Offset = "0x10FACEC", VA = "0x10FACEC")]
		public static Vector2 DrawWhip_MoonLordWhip(Projectile proj, List<Vector2> controlPoints)
		{
			return default(Vector2);
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x00011538 File Offset: 0x0000F738
		[Token(Token = "0x60023D2")]
		[Address(RVA = "0x10F86C8", Offset = "0x10F86C8", VA = "0x10F86C8")]
		public static Vector2 DrawWhip_MeteorWhip(Projectile proj, List<Vector2> controlPoints)
		{
			return default(Vector2);
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x00011550 File Offset: 0x0000F750
		[Token(Token = "0x60023D3")]
		[Address(RVA = "0x10F958C", Offset = "0x10F958C", VA = "0x10F958C")]
		public static Vector2 DrawWhip_EelWhip(Projectile proj, List<Vector2> controlPoints)
		{
			return default(Vector2);
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x00011568 File Offset: 0x0000F768
		[Token(Token = "0x60023D4")]
		[Address(RVA = "0x10F799C", Offset = "0x10F799C", VA = "0x10F799C")]
		public static Vector2 DrawWhip_BoneWhip(Projectile proj, List<Vector2> controlPoints)
		{
			return default(Vector2);
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x00011580 File Offset: 0x0000F780
		[Token(Token = "0x60023D5")]
		[Address(RVA = "0x10F5B50", Offset = "0x10F5B50", VA = "0x10F5B50")]
		public static Vector2 DrawWhip_CoolWhip(Projectile proj, List<Vector2> controlPoints)
		{
			return default(Vector2);
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x00011598 File Offset: 0x0000F798
		[Token(Token = "0x60023D6")]
		[Address(RVA = "0x10F621C", Offset = "0x10F621C", VA = "0x10F621C")]
		public static Vector2 DrawWhip_FireWhip(Projectile proj, List<Vector2> controlPoints)
		{
			return default(Vector2);
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x000115B0 File Offset: 0x0000F7B0
		[Token(Token = "0x60023D7")]
		[Address(RVA = "0x10F6EE4", Offset = "0x10F6EE4", VA = "0x10F6EE4")]
		public static Vector2 DrawWhip_RainbowWhip(Projectile proj, Player theOwner, List<Vector2> controlPoints)
		{
			return default(Vector2);
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x000115C8 File Offset: 0x0000F7C8
		[Token(Token = "0x60023D8")]
		[Address(RVA = "0x10F68E8", Offset = "0x10F68E8", VA = "0x10F68E8")]
		public static Vector2 DrawWhip_ThornWhip(Projectile proj, List<Vector2> controlPoints)
		{
			return default(Vector2);
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x000115E0 File Offset: 0x0000F7E0
		[Token(Token = "0x60023D9")]
		[Address(RVA = "0x10F3EA4", Offset = "0x10F3EA4", VA = "0x10F3EA4")]
		public static Vector2 DrawWhip_WhipSword(Projectile proj, List<Vector2> controlPoints)
		{
			return default(Vector2);
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x000115F8 File Offset: 0x0000F7F8
		[Token(Token = "0x60023DA")]
		[Address(RVA = "0x10F4C78", Offset = "0x10F4C78", VA = "0x10F4C78")]
		public static Vector2 DrawWhip_WhipMace(Projectile proj, List<Vector2> controlPoints)
		{
			return default(Vector2);
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x00011610 File Offset: 0x0000F810
		[Token(Token = "0x60023DB")]
		[Address(RVA = "0x10F53E4", Offset = "0x10F53E4", VA = "0x10F53E4")]
		public static Vector2 DrawWhip_WhipScythe(Projectile proj, List<Vector2> controlPoints)
		{
			return default(Vector2);
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x00011628 File Offset: 0x0000F828
		[Token(Token = "0x60023DC")]
		[Address(RVA = "0x10F4534", Offset = "0x10F4534", VA = "0x10F4534")]
		public static Vector2 DrawWhip_WhipBland(Projectile proj, List<Vector2> controlPoints)
		{
			return default(Vector2);
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DD")]
		[Address(RVA = "0x10FBC98", Offset = "0x10FBC98", VA = "0x10FBC98")]
		private void DrawTwinsPet(Projectile proj)
		{
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DE")]
		[Address(RVA = "0x10FC2E8", Offset = "0x10FC2E8", VA = "0x10FC2E8")]
		private void DrawMultisegmentPet(Projectile proj)
		{
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DF")]
		[Address(RVA = "0x10FCEF8", Offset = "0x10FCEF8", VA = "0x10FCEF8")]
		public static void DrawKite(Projectile proj, Vector2 anchorPos, float wind, ref Vector2_DynamicArray_120 oldPos, ref Float_DynamicArray_120 oldRot, ref Int_DynamicArray_120 oldSpriteDirection)
		{
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E0")]
		[Address(RVA = "0x10FFDD4", Offset = "0x10FFDD4", VA = "0x10FFDD4")]
		private void DrawProjWithStarryTrail(Projectile proj, Player theOwner, Color projectileColor, SpriteEffects dir)
		{
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x00011640 File Offset: 0x0000F840
		[Token(Token = "0x60023E1")]
		[Address(RVA = "0x11013D8", Offset = "0x11013D8", VA = "0x11013D8")]
		private static int TryInteractingWithVoidLens(Projectile proj)
		{
			return 0;
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x00011658 File Offset: 0x0000F858
		[Token(Token = "0x60023E2")]
		[Address(RVA = "0x1102080", Offset = "0x1102080", VA = "0x1102080")]
		private static int TryInteractingWithMoneyTrough(Projectile proj)
		{
			return 0;
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x00011670 File Offset: 0x0000F870
		[Token(Token = "0x60023E3")]
		[Address(RVA = "0x1102CE0", Offset = "0x1102CE0", VA = "0x1102CE0")]
		private int TryDespawningProjectile(Projectile proj, int itemIcon)
		{
			return 0;
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E4")]
		[Address(RVA = "0x11038B0", Offset = "0x11038B0", VA = "0x11038B0")]
		private void TryDespawningProjectile_ModifyBeforeKill(Projectile proj, ref bool giveItem)
		{
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E5")]
		[Address(RVA = "0x110398C", Offset = "0x110398C", VA = "0x110398C")]
		private void TryDespawningProjectile_SpecialkillCode(Projectile proj)
		{
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x00011688 File Offset: 0x0000F888
		[Token(Token = "0x60023E6")]
		[Address(RVA = "0x1103A88", Offset = "0x1103A88", VA = "0x1103A88")]
		private static int TryPetting(Projectile proj, int itemIcon)
		{
			return 0;
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E7")]
		[Address(RVA = "0x1102BF8", Offset = "0x1102BF8", VA = "0x1102BF8")]
		public static void PlayInteractiveProjectileOpenCloseSound(int projType, bool open)
		{
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E8")]
		[Address(RVA = "0x1104328", Offset = "0x1104328", VA = "0x1104328")]
		public static void PrintTimedMessage(string message, object[] arguments)
		{
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E9")]
		[Address(RVA = "0x110446C", Offset = "0x110446C", VA = "0x110446C")]
		private static void TryInteractingWithMoneyTrough2(Projectile proj)
		{
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EA")]
		[Address(RVA = "0x10F1C30", Offset = "0x10F1C30", VA = "0x10F1C30")]
		public void PrepareDrawnProjectileDrawing(Projectile proj)
		{
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EB")]
		[Address(RVA = "0x11054AC", Offset = "0x11054AC", VA = "0x11054AC")]
		public void PrepareDrawnEntityDrawing(Entity entity, int intendedShader)
		{
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EC")]
		[Address(RVA = "0x10E8154", Offset = "0x10E8154", VA = "0x10E8154")]
		public static void EntitySpriteDraw(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float worthless = 0f)
		{
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023ED")]
		[Address(RVA = "0x10E6AAC", Offset = "0x10E6AAC", VA = "0x10E6AAC")]
		public static void EntitySpriteDraw(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float worthless = 0f)
		{
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EE")]
		[Address(RVA = "0x1105C84", Offset = "0x1105C84", VA = "0x1105C84")]
		public static void EntitySpriteDraw(DrawData data)
		{
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x000116A0 File Offset: 0x0000F8A0
		[Token(Token = "0x60023EF")]
		[Address(RVA = "0x1105FA0", Offset = "0x1105FA0", VA = "0x1105FA0")]
		public static Color buffColor(Color newColor, float R, float G, float B, float A)
		{
			return default(Color);
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F0")]
		[Address(RVA = "0x1106068", Offset = "0x1106068", VA = "0x1106068")]
		protected void CacheNPCDraws()
		{
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F1")]
		[Address(RVA = "0x110698C", Offset = "0x110698C", VA = "0x110698C")]
		protected void CacheProjDraws()
		{
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F2")]
		[Address(RVA = "0x1106C24", Offset = "0x1106C24", VA = "0x1106C24")]
		internal void DrawCachedNPCs(List<int> npcCache, bool behindTiles)
		{
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F3")]
		[Address(RVA = "0x1106F04", Offset = "0x1106F04", VA = "0x1106F04")]
		internal void DrawCachedProjs(List<int> projCache, bool startSpriteBatch = true)
		{
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F4")]
		[Address(RVA = "0x1107538", Offset = "0x1107538", VA = "0x1107538")]
		internal void DrawSuperSpecialProjectiles(List<int> projCache, bool startSpriteBatch = true)
		{
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F5")]
		[Address(RVA = "0x11080D0", Offset = "0x11080D0", VA = "0x11080D0")]
		protected void SortDrawCacheWorms()
		{
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F6")]
		[Address(RVA = "0x11080F0", Offset = "0x11080F0", VA = "0x11080F0")]
		private void SortBabyBirdProjectiles(List<int> list)
		{
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F7")]
		[Address(RVA = "0x1108550", Offset = "0x1108550", VA = "0x1108550")]
		private void SortStardustDragonProjectiles(List<int> list)
		{
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F8")]
		[Address(RVA = "0x1109154", Offset = "0x1109154", VA = "0x1109154")]
		protected void DrawWoF()
		{
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F9")]
		[Address(RVA = "0x110A3F0", Offset = "0x110A3F0", VA = "0x110A3F0")]
		private static void DrawWOFBody()
		{
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FA")]
		[Address(RVA = "0x1109B8C", Offset = "0x1109B8C", VA = "0x1109B8C")]
		private static void DrawWOFRopeToTheHungry(int i)
		{
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FB")]
		[Address(RVA = "0x1109480", Offset = "0x1109480", VA = "0x1109480")]
		private static void DrawWOFTongueToPlayer(int i)
		{
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x000116B8 File Offset: 0x0000F8B8
		[Token(Token = "0x60023FC")]
		[Address(RVA = "0x110ABC8", Offset = "0x110ABC8", VA = "0x110ABC8")]
		public static Color quickAlpha(Color oldColor, float Alpha)
		{
			return default(Color);
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FD")]
		[Address(RVA = "0x110AC80", Offset = "0x110AC80", VA = "0x110AC80")]
		public void DrawItem_GetBasics(Item item, int slot, out Texture2D texture, out Rectangle frame, out Rectangle glowmaskFrame)
		{
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FE")]
		[Address(RVA = "0x110B490", Offset = "0x110B490", VA = "0x110B490")]
		private void DrawItem_AnimateSlot(int slot, int gameFramesPerSpriteFrame, int spriteFramesAmount)
		{
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FF")]
		[Address(RVA = "0x110B560", Offset = "0x110B560", VA = "0x110B560")]
		protected void DrawItem(WorldItem item, int whoami)
		{
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002400")]
		[Address(RVA = "0x110E23C", Offset = "0x110E23C", VA = "0x110E23C")]
		public void DrawItems()
		{
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002401")]
		[Address(RVA = "0x110E2DC", Offset = "0x110E2DC", VA = "0x110E2DC")]
		protected void DrawRain()
		{
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002402")]
		[Address(RVA = "0x110EE8C", Offset = "0x110EE8C", VA = "0x110EE8C")]
		protected void DrawDust()
		{
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002403")]
		[Address(RVA = "0x11111F8", Offset = "0x11111F8", VA = "0x11111F8")]
		public static void HelpText()
		{
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x000116D0 File Offset: 0x0000F8D0
		[Token(Token = "0x6002404")]
		[Address(RVA = "0x1117710", Offset = "0x1117710", VA = "0x1117710")]
		public static bool CanDryadPlayStardewAnimation(Player player, NPC npc)
		{
			return default(bool);
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002405")]
		[Address(RVA = "0x11177BC", Offset = "0x11177BC", VA = "0x11177BC")]
		public void OpenShop(int shopIndex)
		{
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002406")]
		[Address(RVA = "0x1101FB8", Offset = "0x1101FB8", VA = "0x1101FB8")]
		public static void SetNPCShopIndex(int index)
		{
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002407")]
		[Address(RVA = "0x1117AA8", Offset = "0x1117AA8", VA = "0x1117AA8")]
		public static void DoNPCPortraitHop()
		{
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002408")]
		[Address(RVA = "0x1117BA4", Offset = "0x1117BA4", VA = "0x1117BA4")]
		public static void CloseNPCChatOrSign()
		{
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002409")]
		[Address(RVA = "0x10B4068", Offset = "0x10B4068", VA = "0x10B4068")]
		public static void SubmitSignText()
		{
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x000116E8 File Offset: 0x0000F8E8
		[Token(Token = "0x600240A")]
		[Address(RVA = "0x1117DC4", Offset = "0x1117DC4", VA = "0x1117DC4")]
		private int NPCBannerSorter(int npcIndex1, int npcIndex2)
		{
			return 0;
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600240B")]
		[Address(RVA = "0x1117E94", Offset = "0x1117E94", VA = "0x1117E94")]
		public static string GetCoinValueText_Nurse(ref Color chatColor, ref int healCost)
		{
			return null;
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600240C")]
		[Address(RVA = "0x111888C", Offset = "0x111888C", VA = "0x111888C")]
		public static string GetCoinValueText_TaxCollector(ref Color chatColor, ref int healCost)
		{
			return null;
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240D")]
		[Address(RVA = "0x11193C4", Offset = "0x11193C4", VA = "0x11193C4")]
		public static void NPCChatText_TavernkeepAdvice()
		{
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240E")]
		[Address(RVA = "0x1119534", Offset = "0x1119534", VA = "0x1119534")]
		public static void NPCChatText_DyeTraderRarePlant()
		{
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240F")]
		[Address(RVA = "0x1119AE8", Offset = "0x1119AE8", VA = "0x1119AE8")]
		public static void NPCChatText_TinkererReforge()
		{
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002410")]
		[Address(RVA = "0x1119C3C", Offset = "0x1119C3C", VA = "0x1119C3C")]
		public static void NPCChatText_GuideReverseCrafting()
		{
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002411")]
		[Address(RVA = "0x1119D90", Offset = "0x1119D90", VA = "0x1119D90")]
		public static void NPCChatText_PartyGirlSwapMusic()
		{
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x00011700 File Offset: 0x0000F900
		[Token(Token = "0x6002412")]
		[Address(RVA = "0x1119EE0", Offset = "0x1119EE0", VA = "0x1119EE0")]
		public static int GetNurseHealCost()
		{
			return 0;
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002413")]
		[Address(RVA = "0x111A510", Offset = "0x111A510", VA = "0x111A510")]
		public static void NPCChatText_DoNurseHeal(int healCost)
		{
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002414")]
		[Address(RVA = "0x111B264", Offset = "0x111B264", VA = "0x111B264")]
		public static void NPCChatText_DoTaxCollector()
		{
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002415")]
		[Address(RVA = "0x111B9E8", Offset = "0x111B9E8", VA = "0x111B9E8")]
		public static void NPCChatText_DoAnglerQuest()
		{
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002416")]
		[Address(RVA = "0x111C380", Offset = "0x111C380", VA = "0x111C380")]
		public static void DryadText_WorldPurityOrStardewValleyBit()
		{
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002417")]
		[Address(RVA = "0x111C5B0", Offset = "0x111C5B0", VA = "0x111C5B0")]
		public static void DryadText_Do_StardewValleyBit()
		{
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002418")]
		[Address(RVA = "0x111C7A8", Offset = "0x111C7A8", VA = "0x111C7A8")]
		protected void DrawNPCHousesInWorld()
		{
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002419")]
		[Address(RVA = "0x111E1A8", Offset = "0x111E1A8", VA = "0x111E1A8")]
		protected void DrawPlayerChat()
		{
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600241A RID: 9242 RVA: 0x00011718 File Offset: 0x0000F918
		[Token(Token = "0x17000555")]
		public static bool ShouldPVPDraw
		{
			[Token(Token = "0x600241A")]
			[Address(RVA = "0x111E840", Offset = "0x111E840", VA = "0x111E840")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241B")]
		[Address(RVA = "0x111E8B0", Offset = "0x111E8B0", VA = "0x111E8B0")]
		public static void LockCraftingForThisCraftClickDuration()
		{
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241C")]
		[Address(RVA = "0x111E918", Offset = "0x111E918", VA = "0x111E918")]
		public void DrawMouseOver()
		{
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x00011730 File Offset: 0x0000F930
		[Token(Token = "0x600241D")]
		[Address(RVA = "0x11225C8", Offset = "0x11225C8", VA = "0x11225C8")]
		public static bool LocalPlayerHasPendingInventoryActions()
		{
			return default(bool);
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600241E RID: 9246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000556")]
		public static Item MouseDisplayItem
		{
			[Token(Token = "0x600241E")]
			[Address(RVA = "0x1122688", Offset = "0x1122688", VA = "0x1122688")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241F")]
		[Address(RVA = "0x11227BC", Offset = "0x11227BC", VA = "0x11227BC")]
		public static void CraftItem_GrantItem(Recipe recipe, Item result, bool quickCraft)
		{
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002420")]
		[Address(RVA = "0x1120A18", Offset = "0x1120A18", VA = "0x1120A18")]
		private void HoverOverNPCs(Rectangle mouseRectangle)
		{
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x00011748 File Offset: 0x0000F948
		[Token(Token = "0x6002421")]
		[Address(RVA = "0x11231C8", Offset = "0x11231C8", VA = "0x11231C8")]
		private static bool TryFreeingElderSlime(int npcIndex)
		{
			return default(bool);
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002422")]
		[Address(RVA = "0x11233C0", Offset = "0x11233C0", VA = "0x11233C0")]
		private static void DrawNPCChatBubble(int i)
		{
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002423")]
		[Address(RVA = "0x1123E8C", Offset = "0x1123E8C", VA = "0x1123E8C")]
		public void GUIBarsDraw()
		{
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002424")]
		[Address(RVA = "0x1123FB0", Offset = "0x1123FB0", VA = "0x1123FB0")]
		protected void GUIBarsDrawInner()
		{
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002425")]
		[Address(RVA = "0x11241BC", Offset = "0x11241BC", VA = "0x11241BC")]
		public static void DrawInterface_Resources_ClearBuffs()
		{
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002426")]
		[Address(RVA = "0x1125D34", Offset = "0x1125D34", VA = "0x1125D34")]
		public void DrawInterface_Resources_Buffs()
		{
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002427")]
		[Address(RVA = "0x1127180", Offset = "0x1127180", VA = "0x1127180")]
		public static string GetBuffTooltip(Player player, int buffType)
		{
			return null;
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x00011760 File Offset: 0x0000F960
		[Token(Token = "0x6002428")]
		[Address(RVA = "0x112766C", Offset = "0x112766C", VA = "0x112766C")]
		public static bool TryGetBuffTime(int buffSlotOnPlayer, out int buffTimeValue)
		{
			return default(bool);
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x00011778 File Offset: 0x0000F978
		[Token(Token = "0x6002429")]
		[Address(RVA = "0x1126168", Offset = "0x1126168", VA = "0x1126168")]
		public static int DrawBuffIcon(int drawBuffText, int buffSlotOnPlayer, int x, int y)
		{
			return 0;
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242A")]
		[Address(RVA = "0x1127BB0", Offset = "0x1127BB0", VA = "0x1127BB0")]
		public static void TryRemovingBuff(int i, int b)
		{
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242B")]
		[Address(RVA = "0x1127FA8", Offset = "0x1127FA8", VA = "0x1127FA8")]
		public static void TryRemovingBuff_CheckBuffHideMisc(int slot, int buffID)
		{
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242C")]
		[Address(RVA = "0x112424C", Offset = "0x112424C", VA = "0x112424C")]
		private static void DrawInterface_Resources_Breath()
		{
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242D")]
		[Address(RVA = "0x11282BC", Offset = "0x11282BC", VA = "0x11282BC")]
		private static void DrawInterface_Resources_GolfPower()
		{
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242E")]
		[Address(RVA = "0x1128724", Offset = "0x1128724", VA = "0x1128724")]
		private static void DrawInterface_GolfBallIndicator()
		{
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242F")]
		[Address(RVA = "0x1129680", Offset = "0x1129680", VA = "0x1129680")]
		protected void GUIHotbarDrawInner()
		{
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002430")]
		[Address(RVA = "0x112B17C", Offset = "0x112B17C", VA = "0x112B17C")]
		public static void OpenHairWindow()
		{
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002431")]
		[Address(RVA = "0x112B660", Offset = "0x112B660", VA = "0x112B660")]
		public static void CancelHairWindow(bool quiet = false)
		{
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002432")]
		[Address(RVA = "0x112BB3C", Offset = "0x112BB3C", VA = "0x112BB3C")]
		public static void BuyHairWindow()
		{
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x00011790 File Offset: 0x0000F990
		[Token(Token = "0x6002433")]
		[Address(RVA = "0x112BF74", Offset = "0x112BF74", VA = "0x112BF74")]
		public static int UnlockedMaxHair()
		{
			return 0;
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002434")]
		[Address(RVA = "0x112C038", Offset = "0x112C038", VA = "0x112C038")]
		public static void OpenClothesWindow()
		{
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002435")]
		[Address(RVA = "0x112CC60", Offset = "0x112CC60", VA = "0x112CC60")]
		public static void CancelClothesWindow(bool quiet = false)
		{
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002436")]
		[Address(RVA = "0x112D73C", Offset = "0x112D73C", VA = "0x112D73C")]
		public static void SaveClothesWindow()
		{
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002437")]
		[Address(RVA = "0x112D908", Offset = "0x112D908", VA = "0x112D908")]
		private void SetupDrawInterfaceLayers()
		{
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002438")]
		[Address(RVA = "0x1130BA8", Offset = "0x1130BA8", VA = "0x1130BA8")]
		protected void DrawInterface(GameTime gameTime)
		{
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002439")]
		[Address(RVA = "0x1130ED0", Offset = "0x1130ED0", VA = "0x1130ED0")]
		private static void DrawWallOfCopperShortswords()
		{
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243A")]
		[Address(RVA = "0x113141C", Offset = "0x113141C", VA = "0x113141C")]
		private static void DrawWallOfBoulders()
		{
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243B")]
		[Address(RVA = "0x1131878", Offset = "0x1131878", VA = "0x1131878")]
		private static void DrawInterface_41_InterfaceLogic4()
		{
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243C")]
		[Address(RVA = "0x1131BF4", Offset = "0x1131BF4", VA = "0x1131BF4")]
		private static void DrawSpectatingControlHint()
		{
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243D")]
		[Address(RVA = "0x1131A88", Offset = "0x1131A88", VA = "0x1131A88")]
		private static void DrawPendingMouseText(bool worldMouse = false)
		{
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243E")]
		[Address(RVA = "0x1132060", Offset = "0x1132060", VA = "0x1132060")]
		private void DrawInterface_40_InteractItemIcon()
		{
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x000117A8 File Offset: 0x0000F9A8
		[Token(Token = "0x600243F")]
		[Address(RVA = "0x1134698", Offset = "0x1134698", VA = "0x1134698")]
		private bool TryGetAmmo(Item sourceItem, out Item ammoItem, out Color ammoColor, out float ammoScale, out Vector2 ammoOffset)
		{
			return default(bool);
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002440")]
		[Address(RVA = "0x11349F8", Offset = "0x11349F8", VA = "0x11349F8")]
		private void DrawInterface_39_MouseOver()
		{
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002441")]
		[Address(RVA = "0x11349FC", Offset = "0x11349FC", VA = "0x11349FC")]
		public void PerformHousingCheck(int x, int y)
		{
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002442")]
		[Address(RVA = "0x1134CE0", Offset = "0x1134CE0", VA = "0x1134CE0")]
		public void TryMovingNPC(int x, int y, int selectedNPC)
		{
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002443")]
		[Address(RVA = "0x1134DC8", Offset = "0x1134DC8", VA = "0x1134DC8")]
		private void DrawInterface_38_MouseCarriedObject()
		{
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002444")]
		[Address(RVA = "0x1136688", Offset = "0x1136688", VA = "0x1136688")]
		public static void DrawInterface_37_DebugStuff()
		{
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002445")]
		[Address(RVA = "0x113668C", Offset = "0x113668C", VA = "0x113668C")]
		public void DrawWorldCursor(bool magnify = false)
		{
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002446")]
		[Address(RVA = "0x1139BB8", Offset = "0x1139BB8", VA = "0x1139BB8")]
		public static void DrawInterface_ConfigureTouchControls()
		{
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002447")]
		[Address(RVA = "0x1139BBC", Offset = "0x1139BBC", VA = "0x1139BBC")]
		public static void DrawInterface_FinalUI()
		{
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002448")]
		[Address(RVA = "0x1139C4C", Offset = "0x1139C4C", VA = "0x1139C4C")]
		public static void DrawInterface_36_Cursor()
		{
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002449")]
		[Address(RVA = "0x113D964", Offset = "0x113D964", VA = "0x113D964")]
		private static void DrawInterface_35_YouDied()
		{
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244A")]
		[Address(RVA = "0x113F264", Offset = "0x113F264", VA = "0x113F264")]
		private void DrawInterface_34_PlayerChat()
		{
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244B")]
		[Address(RVA = "0x113F388", Offset = "0x113F388", VA = "0x113F388")]
		private void DrawInterface_33_MouseText()
		{
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244C")]
		[Address(RVA = "0x113FD0C", Offset = "0x113FD0C", VA = "0x113FD0C")]
		private void DrawInterface_InstrumentMouseText()
		{
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244D")]
		[Address(RVA = "0x11402F0", Offset = "0x11402F0", VA = "0x11402F0")]
		private static void DrawInterface_32_GamepadRadialHotbars()
		{
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244E")]
		[Address(RVA = "0x1140774", Offset = "0x1140774", VA = "0x1140774")]
		private void DrawInterface_31_BuilderAccToggles()
		{
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244F")]
		[Address(RVA = "0x1140778", Offset = "0x1140778", VA = "0x1140778")]
		public static void DrawInterface_29_SettingsButton()
		{
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002450")]
		[Address(RVA = "0x1140BC8", Offset = "0x1140BC8", VA = "0x1140BC8")]
		private void DrawInterface_28_InfoAccs()
		{
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002451")]
		[Address(RVA = "0x1140C54", Offset = "0x1140C54", VA = "0x1140C54")]
		private void HackForGamepadInputHell()
		{
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002452")]
		[Address(RVA = "0x1140C5C", Offset = "0x1140C5C", VA = "0x1140C5C")]
		private void DrawInterface_27_Inventory()
		{
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002453")]
		[Address(RVA = "0x1140D3C", Offset = "0x1140D3C", VA = "0x1140D3C")]
		private static void DrawInterface_26_InterfaceLogic3()
		{
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002454")]
		[Address(RVA = "0x1141114", Offset = "0x1141114", VA = "0x1141114")]
		private void DrawInterface_25_ResourceBars()
		{
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002455")]
		[Address(RVA = "0x11411AC", Offset = "0x11411AC", VA = "0x11411AC")]
		private static void DrawInterface_24_InterfaceLogic2()
		{
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002456")]
		[Address(RVA = "0x11413B0", Offset = "0x11413B0", VA = "0x11413B0")]
		private void DrawInterface_23_NPCSignsDialog()
		{
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002457")]
		[Address(RVA = "0x1141AB0", Offset = "0x1141AB0", VA = "0x1141AB0")]
		private void DrawInterface_22_DresserWindow()
		{
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002458")]
		[Address(RVA = "0x1141BCC", Offset = "0x1141BCC", VA = "0x1141BCC")]
		private void DrawInterface_21_HairWindow()
		{
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002459")]
		[Address(RVA = "0x1141CE8", Offset = "0x1141CE8", VA = "0x1141CE8")]
		private static void DrawInterface_20_MultiplayerPlayerNames()
		{
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245A")]
		[Address(RVA = "0x1141DD4", Offset = "0x1141DD4", VA = "0x1141DD4")]
		private static void DrawInterface_19_SignTileBubble()
		{
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245B")]
		[Address(RVA = "0x1142638", Offset = "0x1142638", VA = "0x1142638")]
		private static void DrawInterface_17_DiagnoseNet()
		{
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245C")]
		[Address(RVA = "0x1142758", Offset = "0x1142758", VA = "0x1142758")]
		private void DrawInterface_16_MapOrMinimap()
		{
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x000117C0 File Offset: 0x0000F9C0
		[Token(Token = "0x17000557")]
		public int RecommendedEquipmentAreaPushUp
		{
			[Token(Token = "0x600245D")]
			[Address(RVA = "0x114282C", Offset = "0x114282C", VA = "0x114282C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245E")]
		[Address(RVA = "0x1142978", Offset = "0x1142978", VA = "0x1142978")]
		private static void DrawInterface_15_InvasionProgressBars()
		{
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245F")]
		[Address(RVA = "0x11439C0", Offset = "0x11439C0", VA = "0x11439C0")]
		private void DrawInterface_14_EntityHealthBars()
		{
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002460")]
		[Address(RVA = "0x11475E8", Offset = "0x11475E8", VA = "0x11475E8")]
		private void DrawInterface_Healthbar_Worm(NPC head, int tailID, float scale)
		{
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002461")]
		[Address(RVA = "0x11478D4", Offset = "0x11478D4", VA = "0x11478D4")]
		private static void DrawInterface_13_AchievementCompletePopups()
		{
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x000117D8 File Offset: 0x0000F9D8
		[Token(Token = "0x6002462")]
		[Address(RVA = "0x1147940", Offset = "0x1147940", VA = "0x1147940")]
		private static bool DrawInterface_12_IngameFancyUI()
		{
			return default(bool);
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x000117F0 File Offset: 0x0000F9F0
		[Token(Token = "0x6002463")]
		[Address(RVA = "0x1147C98", Offset = "0x1147C98", VA = "0x1147C98")]
		private bool DrawInterface_11_IngameOptionsMenu()
		{
			return default(bool);
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x00011808 File Offset: 0x0000FA08
		[Token(Token = "0x6002464")]
		[Address(RVA = "0x1147CA0", Offset = "0x1147CA0", VA = "0x1147CA0")]
		private static bool DrawInterface_8_CheckF11UIHideToggle()
		{
			return default(bool);
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x00011820 File Offset: 0x0000FA20
		[Token(Token = "0x6002465")]
		[Address(RVA = "0x1147E40", Offset = "0x1147E40", VA = "0x1147E40")]
		private static bool DrawInterface_10_CheckCaptureManager()
		{
			return default(bool);
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002466")]
		[Address(RVA = "0x1147E48", Offset = "0x1147E48", VA = "0x1147E48")]
		private static void DrawInterface_9_WireSelection()
		{
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002467")]
		[Address(RVA = "0x1147F30", Offset = "0x1147F30", VA = "0x1147F30")]
		private static void DrawInterface_0_InterfaceLogic1()
		{
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002468")]
		[Address(RVA = "0x1148118", Offset = "0x1148118", VA = "0x1148118")]
		private void DrawInterface_7_TownNPCHouseBanners()
		{
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x00011838 File Offset: 0x0000FA38
		[Token(Token = "0x6002469")]
		[Address(RVA = "0x1148374", Offset = "0x1148374", VA = "0x1148374")]
		private bool DrawVirtualControls()
		{
			return default(bool);
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600246A")]
		[Address(RVA = "0x1148540", Offset = "0x1148540", VA = "0x1148540")]
		public void DrawInterface_WorldMouse()
		{
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600246B")]
		[Address(RVA = "0x1148840", Offset = "0x1148840", VA = "0x1148840")]
		private void DrawInterface_WorldMouseOver()
		{
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600246C")]
		[Address(RVA = "0x1148C9C", Offset = "0x1148C9C", VA = "0x1148C9C")]
		public static void DrawTileGridOption(bool magnify = false)
		{
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600246D")]
		[Address(RVA = "0x1149980", Offset = "0x1149980", VA = "0x1149980")]
		private static void DrawInterface_6_TileGridOption()
		{
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600246E")]
		[Address(RVA = "0x1149A8C", Offset = "0x1149A8C", VA = "0x1149A8C")]
		private static void DrawInterface_5_GamepadLockOn()
		{
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600246F")]
		[Address(RVA = "0x1149B30", Offset = "0x1149B30", VA = "0x1149B30")]
		private static void DrawInterface_4_Ruler()
		{
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002470")]
		[Address(RVA = "0x114AFA8", Offset = "0x114AFA8", VA = "0x114AFA8")]
		private static void DrawInterface_3_LaserRuler()
		{
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002471")]
		[Address(RVA = "0x114C2D0", Offset = "0x114C2D0", VA = "0x114C2D0")]
		private static void DrawInterface_2_SmartCursorTargets()
		{
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002472")]
		[Address(RVA = "0x114E254", Offset = "0x114E254", VA = "0x114E254")]
		private static void DrawInterface_1_1_DrawEmoteBubblesInWorld()
		{
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002473")]
		[Address(RVA = "0x114E638", Offset = "0x114E638", VA = "0x114E638")]
		private static void DrawInterface_1_2_DrawEntityMarkersInWorld()
		{
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002474")]
		[Address(RVA = "0x109660C", Offset = "0x109660C", VA = "0x109660C")]
		private static void MouseOversTryToClear()
		{
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002475")]
		[Address(RVA = "0x114F090", Offset = "0x114F090", VA = "0x114F090")]
		private static void MouseOversClear()
		{
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002476")]
		[Address(RVA = "0x114F450", Offset = "0x114F450", VA = "0x114F450")]
		public static void ItemIconCacheUpdate(int selectedItemID)
		{
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002477")]
		[Address(RVA = "0x1134210", Offset = "0x1134210", VA = "0x1134210")]
		public static void ItemIconCacheVerification()
		{
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002478")]
		[Address(RVA = "0x114F5B8", Offset = "0x114F5B8", VA = "0x114F5B8")]
		public static void DrawWallOfFish()
		{
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002479")]
		[Address(RVA = "0x114FCC4", Offset = "0x114FCC4", VA = "0x114FCC4")]
		public static void DrawWallOfStars()
		{
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247A")]
		[Address(RVA = "0x114C338", Offset = "0x114C338", VA = "0x114C338")]
		private static void DrawSmartCursor()
		{
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247B")]
		[Address(RVA = "0x1150734", Offset = "0x1150734", VA = "0x1150734")]
		private static void DrawSmartInteract()
		{
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247C")]
		[Address(RVA = "0x1151D80", Offset = "0x1151D80", VA = "0x1151D80")]
		private void DrawInterface_30_Hotbar()
		{
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247D")]
		[Address(RVA = "0x11413B4", Offset = "0x11413B4", VA = "0x11413B4")]
		public void GUIChatDraw()
		{
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x00011850 File Offset: 0x0000FA50
		[Token(Token = "0x17000558")]
		public static bool ShouldDrawInfoIconsHorizontally
		{
			[Token(Token = "0x600247E")]
			[Address(RVA = "0x1151F5C", Offset = "0x1151F5C", VA = "0x1151F5C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600247F RID: 9343 RVA: 0x00011868 File Offset: 0x0000FA68
		[Token(Token = "0x17000559")]
		public static bool CanShowInfoAccs
		{
			[Token(Token = "0x600247F")]
			[Address(RVA = "0x1152214", Offset = "0x1152214", VA = "0x1152214")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002480")]
		[Address(RVA = "0x10A0860", Offset = "0x10A0860", VA = "0x10A0860")]
		public static void CheckInvasionProgressDisplay()
		{
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002481")]
		[Address(RVA = "0x115261C", Offset = "0x115261C", VA = "0x115261C")]
		public static void SyncAnInvasion(int toWho)
		{
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002482")]
		[Address(RVA = "0x1152478", Offset = "0x1152478", VA = "0x1152478")]
		public static void ReportInvasionProgress(int progress, int progressMax, int icon, int progressWave)
		{
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002483")]
		[Address(RVA = "0x1142B24", Offset = "0x1142B24", VA = "0x1142B24")]
		public static void DrawInvasionProgress()
		{
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002484")]
		[Address(RVA = "0x109606C", Offset = "0x109606C", VA = "0x109606C")]
		protected void QuitGame()
		{
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x00011880 File Offset: 0x0000FA80
		[Token(Token = "0x6002485")]
		[Address(RVA = "0x1152A84", Offset = "0x1152A84", VA = "0x1152A84")]
		public static Color randColor()
		{
			return default(Color);
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x00011898 File Offset: 0x0000FA98
		[Token(Token = "0x6002486")]
		[Address(RVA = "0x1152BA8", Offset = "0x1152BA8", VA = "0x1152BA8")]
		public static Color hslToRgb(Vector3 hslVector)
		{
			return default(Color);
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x000118B0 File Offset: 0x0000FAB0
		[Token(Token = "0x6002487")]
		[Address(RVA = "0x108EB98", Offset = "0x108EB98", VA = "0x108EB98")]
		public static Color hslToRgb(float Hue, float Saturation, float Luminosity, byte a = 255)
		{
			return default(Color);
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002488")]
		[Address(RVA = "0x1152CD8", Offset = "0x1152CD8", VA = "0x1152CD8")]
		public static void hslToRgb(ref Color color, float Hue, float Saturation, float Luminosity, byte a = 255)
		{
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x000118C8 File Offset: 0x0000FAC8
		[Token(Token = "0x6002489")]
		[Address(RVA = "0x1152C28", Offset = "0x1152C28", VA = "0x1152C28")]
		public static double hue2rgb(double c, double t1, double t2)
		{
			return 0.0;
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x000118E0 File Offset: 0x0000FAE0
		[Token(Token = "0x600248A")]
		[Address(RVA = "0x11533D0", Offset = "0x11533D0", VA = "0x11533D0")]
		public static Vector3 rgbToHsl(Color newColor)
		{
			return default(Vector3);
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x000118F8 File Offset: 0x0000FAF8
		[Token(Token = "0x1700055A")]
		public static bool HasHWCursor
		{
			[Token(Token = "0x600248B")]
			[Address(RVA = "0x11535A8", Offset = "0x11535A8", VA = "0x11535A8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248C")]
		[Address(RVA = "0x113BDB0", Offset = "0x113BDB0", VA = "0x113BDB0")]
		public static void DrawCursor(Vector2 bonus, bool smart = false)
		{
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248D")]
		[Address(RVA = "0x11536F4", Offset = "0x11536F4", VA = "0x11536F4")]
		public static void ClearSmartInteract()
		{
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x00011910 File Offset: 0x0000FB10
		[Token(Token = "0x600248E")]
		[Address(RVA = "0x113AFF4", Offset = "0x113AFF4", VA = "0x113AFF4")]
		public static Vector2 DrawThickCursor(bool smart = false)
		{
			return default(Vector2);
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248F")]
		[Address(RVA = "0x1153968", Offset = "0x1153968", VA = "0x1153968")]
		private void OnCharacterNamed(string text)
		{
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002490")]
		[Address(RVA = "0x1153AE8", Offset = "0x1153AE8", VA = "0x1153AE8")]
		private void OnSeedSelected(string text)
		{
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002491")]
		[Address(RVA = "0x1153C58", Offset = "0x1153C58", VA = "0x1153C58")]
		private void OnWorldNamed(string text)
		{
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06002492 RID: 9362 RVA: 0x00011928 File Offset: 0x0000FB28
		[Token(Token = "0x1700055B")]
		public static Point ScreenSize
		{
			[Token(Token = "0x6002492")]
			[Address(RVA = "0x1131300", Offset = "0x1131300", VA = "0x1131300")]
			get
			{
				return default(Point);
			}
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002493")]
		[Address(RVA = "0x1153EA8", Offset = "0x1153EA8", VA = "0x1153EA8")]
		public static void GoToWorldSelect()
		{
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002494")]
		[Address(RVA = "0x1153F5C", Offset = "0x1153F5C", VA = "0x1153F5C")]
		public static void StartClientGameplay()
		{
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002495")]
		[Address(RVA = "0x115404C", Offset = "0x115404C", VA = "0x115404C")]
		public static void ReleaseHostAndPlayProcess()
		{
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002496")]
		[Address(RVA = "0x11540D8", Offset = "0x11540D8", VA = "0x11540D8")]
		private string SanitizePathArgument(string argumentName, string argumentPath)
		{
			return null;
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002497")]
		[Address(RVA = "0x1154258", Offset = "0x1154258", VA = "0x1154258")]
		protected void DrawMenu(GameTime gameTime)
		{
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002498")]
		[Address(RVA = "0x1157C78", Offset = "0x1157C78", VA = "0x1157C78")]
		private static void DrawVersionNumber(Color menuColor, float upBump)
		{
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002499")]
		[Address(RVA = "0x1158024", Offset = "0x1158024", VA = "0x1158024")]
		public static void ClearVisualPostProcessEffects(bool filtersOnly = false)
		{
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249A")]
		[Address(RVA = "0x1159F50", Offset = "0x1159F50", VA = "0x1159F50")]
		public static void ClearWorldSeedFlags()
		{
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249B")]
		[Address(RVA = "0x1159FC8", Offset = "0x1159FC8", VA = "0x1159FC8")]
		private static void PostDrawMenu(Point screenSizeCache, Point screenSizeCacheAfterScaling)
		{
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249C")]
		[Address(RVA = "0x115A1BC", Offset = "0x115A1BC", VA = "0x115A1BC")]
		private void PreDrawMenu(out Point screenSizeCache, out Point screenSizeCacheAfterScaling)
		{
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x00011940 File Offset: 0x0000FB40
		[Token(Token = "0x600249D")]
		[Address(RVA = "0x115A3FC", Offset = "0x115A3FC", VA = "0x115A3FC")]
		private static bool IsBorderlessDisplayAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249E")]
		[Address(RVA = "0x115A404", Offset = "0x115A404", VA = "0x115A404")]
		public static void CycleVoiceStyle(Player plr, int offset)
		{
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249F")]
		[Address(RVA = "0x115A4FC", Offset = "0x115A4FC", VA = "0x115A4FC")]
		private static void CycleClothingStyle(Player plr)
		{
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x00011958 File Offset: 0x0000FB58
		[Token(Token = "0x60024A0")]
		[Address(RVA = "0x115A708", Offset = "0x115A708", VA = "0x115A708")]
		private static bool IsValidPlayerStyle(Player plr)
		{
			return default(bool);
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A1")]
		[Address(RVA = "0x115A5A4", Offset = "0x115A5A4", VA = "0x115A5A4")]
		private static void CycleClothingStyle_Inner(Player plr)
		{
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A2")]
		[Address(RVA = "0x115A730", Offset = "0x115A730", VA = "0x115A730")]
		public static void ResetKeyBindings()
		{
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A3")]
		[Address(RVA = "0x10B1BC0", Offset = "0x10B1BC0", VA = "0x10B1BC0")]
		public static void CursorColor()
		{
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A4")]
		[Address(RVA = "0x115A988", Offset = "0x115A988", VA = "0x115A988")]
		private void UnloadSplashScreenTextures()
		{
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A5")]
		[Address(RVA = "0x115AA7C", Offset = "0x115AA7C", VA = "0x115AA7C")]
		protected void DrawSplash(GameTime gameTime)
		{
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A6")]
		[Address(RVA = "0x115B938", Offset = "0x115B938", VA = "0x115B938")]
		private void DrawSplash_LoadingFlower(Color splashColor)
		{
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A7")]
		[Address(RVA = "0x115BE60", Offset = "0x115BE60", VA = "0x115BE60")]
		private void DrawSplash_LoadingStar(Color splashColor)
		{
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A8")]
		[Address(RVA = "0x115C26C", Offset = "0x115C26C", VA = "0x115C26C")]
		protected void DrawUnderworldBackground(bool flat)
		{
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A9")]
		[Address(RVA = "0x115C708", Offset = "0x115C708", VA = "0x115C708")]
		private static void DrawUnderworldBackgroudLayer(bool flat, Vector2 screenOffset, float pushUp, int layerTextureIndex)
		{
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AA")]
		[Address(RVA = "0x115DE08", Offset = "0x115DE08", VA = "0x115DE08")]
		private void ProcessBatchFinished(int index)
		{
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060024AB RID: 9387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700055C")]
		private ThreadedRenderManager.BatchProcessCallback ProcessBatchFinishedCallback
		{
			[Token(Token = "0x60024AB")]
			[Address(RVA = "0x115DE80", Offset = "0x115DE80", VA = "0x115DE80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AC")]
		[Address(RVA = "0x115DF2C", Offset = "0x115DF2C", VA = "0x115DF2C")]
		private void WaitBackgroundDrawThreads(int numberOfThreads)
		{
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AD")]
		[Address(RVA = "0x115E328", Offset = "0x115E328", VA = "0x115E328")]
		public void DrawCurrentBackground(int bgStartX, int bgStartY, int bgLoops, int bgLoopsY, int diff, Vector2 drawOffset)
		{
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AE")]
		[Address(RVA = "0x115F714", Offset = "0x115F714", VA = "0x115F714")]
		public void DrawMagmaLayer(int bgStartX, int bgStartY, int bgLoops, int bgLoopsY, int diff, Vector2 drawOffset)
		{
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AF")]
		[Address(RVA = "0x1160C10", Offset = "0x1160C10", VA = "0x1160C10")]
		public void DrawRockLayer(int bgStartX, int bgStartY, int bgLoops, int bgLoopsY, int diff, Vector2 drawOffset)
		{
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x00011970 File Offset: 0x0000FB70
		[Token(Token = "0x60024B0")]
		[Address(RVA = "0x1162110", Offset = "0x1162110", VA = "0x1162110")]
		private int GetRockTransitionPoint()
		{
			return 0;
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x00011988 File Offset: 0x0000FB88
		[Token(Token = "0x60024B1")]
		[Address(RVA = "0x1162268", Offset = "0x1162268", VA = "0x1162268")]
		private static int DrawBackground_PickUndergroundBackgroundStyle(double magmaLayer)
		{
			return 0;
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B2")]
		[Address(RVA = "0x1162A30", Offset = "0x1162A30", VA = "0x1162A30")]
		protected void DrawBackground()
		{
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x000119A0 File Offset: 0x0000FBA0
		[Token(Token = "0x60024B3")]
		[Address(RVA = "0x11789B4", Offset = "0x11789B4", VA = "0x11789B4")]
		public static Point GetScreenOverdrawOffset()
		{
			return default(Point);
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x000119B8 File Offset: 0x0000FBB8
		[Token(Token = "0x60024B4")]
		[Address(RVA = "0x11789D8", Offset = "0x11789D8", VA = "0x11789D8")]
		private static bool ShouldDrawBackgroundTileAt(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x000119D0 File Offset: 0x0000FBD0
		[Token(Token = "0x60024B5")]
		[Address(RVA = "0x1178C00", Offset = "0x1178C00", VA = "0x1178C00")]
		public static bool WallLightAt(int i, int j)
		{
			return default(bool);
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x000119E8 File Offset: 0x0000FBE8
		[Token(Token = "0x60024B6")]
		[Address(RVA = "0x1178C74", Offset = "0x1178C74", VA = "0x1178C74")]
		public static bool WallLightAt(int i, int j, bool showInvisibleWalls)
		{
			return default(bool);
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B7")]
		[Address(RVA = "0x116C140", Offset = "0x116C140", VA = "0x116C140")]
		protected void OldDrawBackground()
		{
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B8")]
		[Address(RVA = "0x1178E44", Offset = "0x1178E44", VA = "0x1178E44")]
		protected void RenderBackground()
		{
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B9")]
		[Address(RVA = "0x117A314", Offset = "0x117A314", VA = "0x117A314")]
		public static string ValueToCoins(long value)
		{
			return null;
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024BA")]
		[Address(RVA = "0x117A830", Offset = "0x117A830", VA = "0x117A830")]
		private static void UpdateMinimapAnchors()
		{
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x00011A00 File Offset: 0x0000FC00
		[Token(Token = "0x60024BB")]
		[Address(RVA = "0x117A8D4", Offset = "0x117A8D4", VA = "0x117A8D4")]
		private static bool DrawPlayerMapIcon_CanBeSeen(int playerIndex)
		{
			return default(bool);
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024BC")]
		[Address(RVA = "0x117AAA8", Offset = "0x117AAA8", VA = "0x117AAA8")]
		private static void DrawNPCMapIcons3(float X, float Y, float scale, byte alpha, float headScale)
		{
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024BD")]
		[Address(RVA = "0x117B9F0", Offset = "0x117B9F0", VA = "0x117B9F0")]
		private static string DrawNPCMapIcons2(string mouseTextString, float X2, float Y2, float scale, byte alpha, float xOff, float yOff, float left, float top, float headScale)
		{
			return null;
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024BE")]
		[Address(RVA = "0x117D284", Offset = "0x117D284", VA = "0x117D284")]
		private static string DrawNPCMapIcons(string mouseTextString, float X, float Y, float scale, byte alpha, float headScale)
		{
			return null;
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x00011A18 File Offset: 0x0000FC18
		[Token(Token = "0x60024BF")]
		[Address(RVA = "0x117B4CC", Offset = "0x117B4CC", VA = "0x117B4CC")]
		private static bool DrawNPCMapIcon_CanBeSeen_Townie(NPC npc)
		{
			return default(bool);
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C0")]
		[Address(RVA = "0x117E3C8", Offset = "0x117E3C8", VA = "0x117E3C8")]
		private void DrawActiveSectionsOnMap(float X, float Y, float left, float top, float scale)
		{
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C1")]
		[Address(RVA = "0x117E8D8", Offset = "0x117E8D8", VA = "0x117E8D8")]
		private static void DrawMapFullscreenBackground(Vector2 screenPosition, int screenWidth, int screenHeight)
		{
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x00011A30 File Offset: 0x0000FC30
		[Token(Token = "0x60024C2")]
		[Address(RVA = "0x11801F4", Offset = "0x11801F4", VA = "0x11801F4")]
		public static bool DrawPlayerDeathMarker(float X, float Y, float scale, float left, float top, float headScale, int i, int alpha)
		{
			return default(bool);
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C3")]
		[Address(RVA = "0x1180798", Offset = "0x1180798", VA = "0x1180798")]
		public void DrawMiscMapIcons(SpriteBatch spriteBatch, Vector2 mapTopLeft, Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, ref string mouseTextString)
		{
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C4")]
		[Address(RVA = "0x11810E8", Offset = "0x11810E8", VA = "0x11810E8")]
		private void DrawMapIcons_PotionOfReturnAppearAfterUsePosition(SpriteBatch spriteBatch, Vector2 mapTopLeft, Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, ref string mouseTextString)
		{
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C5")]
		[Address(RVA = "0x1180898", Offset = "0x1180898", VA = "0x1180898")]
		private void DrawMapIcons_PotionOfReturnHomePosition(SpriteBatch spriteBatch, Vector2 mapTopLeft, Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, ref string mouseTextString)
		{
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C6")]
		[Address(RVA = "0x1181938", Offset = "0x1181938", VA = "0x1181938")]
		private void DrawMapIcons_LastGolfballHit(SpriteBatch spriteBatch, Vector2 mapTopLeft, Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, ref string mouseTextString)
		{
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C7")]
		[Address(RVA = "0x11821B0", Offset = "0x11821B0", VA = "0x11821B0")]
		public static void TriggerPing(Vector2 position)
		{
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C8")]
		[Address(RVA = "0x117B4D4", Offset = "0x117B4D4", VA = "0x117B4D4")]
		public static void DrawNPCHeadFriendly(Entity theNPC, byte alpha, float headScale, SpriteEffects dir, int npcID, float x, float y)
		{
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C9")]
		[Address(RVA = "0x117B75C", Offset = "0x117B75C", VA = "0x117B75C")]
		public static void DrawNPCHeadBoss(Entity theNPC, byte alpha, float headScale, float rotation, SpriteEffects effects, int npcID, float x, float y)
		{
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CA")]
		[Address(RVA = "0x118233C", Offset = "0x118233C", VA = "0x118233C")]
		public static void DrawWithOutlines(Texture2D tex, Vector2 position, Rectangle rect, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects)
		{
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x00011A48 File Offset: 0x0000FC48
		[Token(Token = "0x60024CB")]
		[Address(RVA = "0x1182DE8", Offset = "0x1182DE8", VA = "0x1182DE8")]
		public static Color GetPlayerHeadBordersColor(Player plr, bool ignoreDead = false)
		{
			return default(Color);
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CC")]
		[Address(RVA = "0x1183008", Offset = "0x1183008", VA = "0x1183008")]
		public static string DrawMap_FindChestName(LocalizedText[] chestNames, Tile chestTile, int x, int y, int fullTileWidth = 36)
		{
			return null;
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CD")]
		[Address(RVA = "0x11832A4", Offset = "0x11832A4", VA = "0x11832A4")]
		public void DrawSimpleSurfaceBackground(Vector2 areaPosition, int areaWidth, int areaHeight)
		{
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CE")]
		[Address(RVA = "0x11837A4", Offset = "0x11837A4", VA = "0x11837A4")]
		private void DrawPaladinsShield()
		{
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CF")]
		[Address(RVA = "0x1183AD0", Offset = "0x1183AD0", VA = "0x1183AD0")]
		private void DrawPaladinsShieldBoundary(Vector2 from, Vector2 to)
		{
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D0")]
		[Address(RVA = "0x1184840", Offset = "0x1184840", VA = "0x1184840")]
		protected void RenderTiles()
		{
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D1")]
		[Address(RVA = "0x118501C", Offset = "0x118501C", VA = "0x118501C")]
		protected void RenderTiles2()
		{
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D2")]
		[Address(RVA = "0x1185540", Offset = "0x1185540", VA = "0x1185540")]
		protected void RenderWater()
		{
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x00011A60 File Offset: 0x0000FC60
		[Token(Token = "0x60024D3")]
		[Address(RVA = "0x1185818", Offset = "0x1185818", VA = "0x1185818")]
		public static int CalculateWaterStyle(bool ignoreFountains = false)
		{
			return 0;
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x00011A78 File Offset: 0x0000FC78
		[Token(Token = "0x60024D4")]
		[Address(RVA = "0x1185BC0", Offset = "0x1185BC0", VA = "0x1185BC0")]
		public static bool IsLiquidStyleWater(int liquidStyle)
		{
			return default(bool);
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D5")]
		[Address(RVA = "0x1179498", Offset = "0x1179498", VA = "0x1179498")]
		private void DrawWaters(bool isBackground = false)
		{
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D6")]
		[Address(RVA = "0x1185BE4", Offset = "0x1185BE4", VA = "0x1185BE4")]
		protected void DrawLiquid(bool bg, int waterStyle, float Alpha = 1f, bool waterOnly = false)
		{
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D7")]
		[Address(RVA = "0x1189920", Offset = "0x1189920", VA = "0x1189920")]
		public static void DrawTileInWater(SpriteBatch spriteBatch, Vector2 drawOffset, int x, int y, byte liquid, short frameX, short frameY)
		{
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D8")]
		[Address(RVA = "0x1186110", Offset = "0x1186110", VA = "0x1186110")]
		public void oldDrawWater(bool bg = false, int Style = 0, float Alpha = 1f)
		{
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x00011A90 File Offset: 0x0000FC90
		[Token(Token = "0x60024D9")]
		[Address(RVA = "0x1189CC0", Offset = "0x1189CC0", VA = "0x1189CC0")]
		protected bool FullTile(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DA")]
		[Address(RVA = "0x118A6C0", Offset = "0x118A6C0", VA = "0x118A6C0")]
		protected void DrawBlack(bool force = false)
		{
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DB")]
		[Address(RVA = "0x118B9C4", Offset = "0x118B9C4", VA = "0x118B9C4")]
		public static void UpdateFrameShouldShowInvisibleBlocksAndWalls()
		{
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x00011AA8 File Offset: 0x0000FCA8
		[Token(Token = "0x60024DC")]
		[Address(RVA = "0x1160B50", Offset = "0x1160B50", VA = "0x1160B50")]
		public static bool ShouldShowInvisibleBlocksAndWalls()
		{
			return default(bool);
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DD")]
		[Address(RVA = "0x1184D6C", Offset = "0x1184D6C", VA = "0x1184D6C")]
		protected void RenderBlack()
		{
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DE")]
		[Address(RVA = "0x118BA2C", Offset = "0x118BA2C", VA = "0x118BA2C")]
		protected void DrawWalls()
		{
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DF")]
		[Address(RVA = "0x118BA50", Offset = "0x118BA50", VA = "0x118BA50")]
		protected void RenderWalls()
		{
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E0")]
		[Address(RVA = "0x118BFB4", Offset = "0x118BFB4", VA = "0x118BFB4")]
		protected void ReleaseTargets()
		{
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E1")]
		[Address(RVA = "0x118C3E0", Offset = "0x118C3E0", VA = "0x118C3E0")]
		protected void InitTargets()
		{
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E2")]
		[Address(RVA = "0x118C6A4", Offset = "0x118C6A4", VA = "0x118C6A4")]
		protected void EnsureRenderTargetContent()
		{
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E3")]
		[Address(RVA = "0x118C5F4", Offset = "0x118C5F4", VA = "0x118C5F4")]
		protected void InitTargets(int width, int height)
		{
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E4")]
		[Address(RVA = "0x118C754", Offset = "0x118C754", VA = "0x118C754")]
		protected void DrawWires()
		{
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x00011AC0 File Offset: 0x0000FCC0
		[Token(Token = "0x60024E5")]
		[Address(RVA = "0x11913C0", Offset = "0x11913C0", VA = "0x11913C0")]
		public static int ConvertPaintIdToTileShaderIndex(int paintIndexOnTile, bool isUsedForPaintingGrass, bool useWallShaderHacks)
		{
			return 0;
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E6")]
		[Address(RVA = "0x1191420", Offset = "0x1191420", VA = "0x1191420")]
		public static void ResetWindCounter(bool resetExtreme = false)
		{
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E7")]
		[Address(RVA = "0x1191500", Offset = "0x1191500", VA = "0x1191500")]
		public static void NewLightning(bool instant = false, bool skipSound = false)
		{
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E8")]
		[Address(RVA = "0x10A4E00", Offset = "0x10A4E00", VA = "0x10A4E00")]
		public void UpdateWeather(GameTime gameTime, int currentDayRateIteration)
		{
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E9")]
		[Address(RVA = "0x11785A0", Offset = "0x11785A0", VA = "0x11785A0")]
		public void LoadBackground(int i)
		{
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EA")]
		[Address(RVA = "0x10D3838", Offset = "0x10D3838", VA = "0x10D3838")]
		public void LoadItem(int i)
		{
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EB")]
		[Address(RVA = "0x1122FD8", Offset = "0x1122FD8", VA = "0x1122FD8")]
		public void LoadNPC(int i)
		{
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EC")]
		[Address(RVA = "0x10D88D8", Offset = "0x10D88D8", VA = "0x10D88D8")]
		public void LoadProjectile(int i)
		{
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024ED")]
		[Address(RVA = "0x10C5FC4", Offset = "0x10C5FC4", VA = "0x10C5FC4")]
		public void LoadGore(int i)
		{
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EE")]
		[Address(RVA = "0x1191830", Offset = "0x1191830", VA = "0x1191830")]
		public void LoadWall(int i)
		{
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EF")]
		[Address(RVA = "0x1191B18", Offset = "0x1191B18", VA = "0x1191B18")]
		public void LoadTiles(int i)
		{
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F0")]
		[Address(RVA = "0x1191F18", Offset = "0x1191F18", VA = "0x1191F18")]
		public void LoadItemFlames(int i)
		{
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F1")]
		[Address(RVA = "0x1192194", Offset = "0x1192194", VA = "0x1192194")]
		public void LoadWings(int i)
		{
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F2")]
		[Address(RVA = "0x1192384", Offset = "0x1192384", VA = "0x1192384")]
		public void LoadHair(int i)
		{
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F3")]
		[Address(RVA = "0x119264C", Offset = "0x119264C", VA = "0x119264C")]
		public void LoadArmorHead(int i)
		{
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F4")]
		[Address(RVA = "0x119283C", Offset = "0x119283C", VA = "0x119283C")]
		public void LoadArmorBody(int i)
		{
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F5")]
		[Address(RVA = "0x1192D28", Offset = "0x1192D28", VA = "0x1192D28")]
		public void LoadArmorLegs(int i)
		{
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F6")]
		[Address(RVA = "0x1192F18", Offset = "0x1192F18", VA = "0x1192F18")]
		public void LoadAccHandsOn(int i)
		{
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F7")]
		[Address(RVA = "0x1193334", Offset = "0x1193334", VA = "0x1193334")]
		public void LoadAccHandsOff(int i)
		{
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F8")]
		[Address(RVA = "0x119371C", Offset = "0x119371C", VA = "0x119371C")]
		public void LoadAccBack(int i)
		{
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F9")]
		[Address(RVA = "0x119390C", Offset = "0x119390C", VA = "0x119390C")]
		public void LoadAccFront(int i)
		{
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FA")]
		[Address(RVA = "0x1193AFC", Offset = "0x1193AFC", VA = "0x1193AFC")]
		public void LoadAccShoes(int i)
		{
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FB")]
		[Address(RVA = "0x1193CEC", Offset = "0x1193CEC", VA = "0x1193CEC")]
		public void LoadAccWaist(int i)
		{
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FC")]
		[Address(RVA = "0x1193EDC", Offset = "0x1193EDC", VA = "0x1193EDC")]
		public void LoadAccShield(int i)
		{
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FD")]
		[Address(RVA = "0x11940CC", Offset = "0x11940CC", VA = "0x11940CC")]
		public void LoadAccNeck(int i)
		{
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FE")]
		[Address(RVA = "0x11942BC", Offset = "0x11942BC", VA = "0x11942BC")]
		public void LoadAccFace(int i)
		{
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FF")]
		[Address(RVA = "0x11944AC", Offset = "0x11944AC", VA = "0x11944AC")]
		public void LoadAccBalloon(int i)
		{
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002500")]
		[Address(RVA = "0x119469C", Offset = "0x119469C", VA = "0x119469C")]
		public void LoadAccBeard(int i)
		{
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002501")]
		[Address(RVA = "0x119488C", Offset = "0x119488C", VA = "0x119488C")]
		public void LoadFlameRing()
		{
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002502")]
		[Address(RVA = "0x1194A50", Offset = "0x1194A50", VA = "0x1194A50")]
		protected void DrawSurfaceBG()
		{
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x00011AD8 File Offset: 0x0000FCD8
		[Token(Token = "0x6002503")]
		[Address(RVA = "0x11989D4", Offset = "0x11989D4", VA = "0x11989D4")]
		public static bool ShouldDrawSurfaceBackground()
		{
			return default(bool);
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002504")]
		[Address(RVA = "0x119C4AC", Offset = "0x119C4AC", VA = "0x119C4AC")]
		private void DrawClouds_Closest(float globalCloudAlpha)
		{
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002505")]
		[Address(RVA = "0x119AF20", Offset = "0x119AF20", VA = "0x119AF20")]
		private void DrawClouds_Closer(float globalCloudAlpha)
		{
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002506")]
		[Address(RVA = "0x1198BF0", Offset = "0x1198BF0", VA = "0x1198BF0")]
		private void DrawClouds_Distant(bool drawBackground, float backgroundTopMagicNumber, int pushBGTopHack, float globalCloudAlpha)
		{
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002507")]
		[Address(RVA = "0x11A90C4", Offset = "0x11A90C4", VA = "0x11A90C4")]
		private void StartDrawingClouds()
		{
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002508")]
		[Address(RVA = "0x11A9268", Offset = "0x11A9268", VA = "0x11A9268")]
		private void EndDrawingClouds()
		{
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002509")]
		[Address(RVA = "0x11A917C", Offset = "0x11A917C", VA = "0x11A917C")]
		private void DrawCloud(float globalCloudAlpha, Cloud theCloud, int cloudPass, float cY)
		{
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x00011AF0 File Offset: 0x0000FCF0
		[Token(Token = "0x600250A")]
		[Address(RVA = "0x11A8FB4", Offset = "0x11A8FB4", VA = "0x11A8FB4")]
		private static float DrawSurfaceBG_GetFogPower()
		{
			return 0f;
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250B")]
		[Address(RVA = "0x11A9320", Offset = "0x11A9320", VA = "0x11A9320")]
		private void DrawSurfaceBG_DrawBackMountainsLayer(int bgTextureIndex)
		{
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x00011B08 File Offset: 0x0000FD08
		[Token(Token = "0x600250C")]
		[Address(RVA = "0x11A9588", Offset = "0x11A9588", VA = "0x11A9588")]
		private int DrawSurfaceBG_GetLayerYOffset(int bgTextureIndex)
		{
			return 0;
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x00011B20 File Offset: 0x0000FD20
		[Token(Token = "0x600250D")]
		[Address(RVA = "0x11A9D10", Offset = "0x11A9D10", VA = "0x11A9D10")]
		private float GetForestToForestBackgroundLerperValue()
		{
			return 0f;
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250E")]
		[Address(RVA = "0x1199EC8", Offset = "0x1199EC8", VA = "0x1199EC8")]
		private void DrawSurfaceBG_BackMountainsStep1(float backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack)
		{
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250F")]
		[Address(RVA = "0x119B520", Offset = "0x119B520", VA = "0x119B520")]
		private void DrawSurfaceBG_BackMountainsStep2(int pushBGTopHack)
		{
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002510")]
		[Address(RVA = "0x11A9DE4", Offset = "0x11A9DE4", VA = "0x11A9DE4")]
		private void UpdateOceanWaterLineForAmbience()
		{
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002511")]
		[Address(RVA = "0x11A74F8", Offset = "0x11A74F8", VA = "0x11A74F8")]
		private void DrawSurfaceBG_Mushroom(float backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
		{
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002512")]
		[Address(RVA = "0x11A5E30", Offset = "0x11A5E30", VA = "0x11A5E30")]
		private void DrawSurfaceBG_Crimson(float backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
		{
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002513")]
		[Address(RVA = "0x11A4860", Offset = "0x11A4860", VA = "0x11A4860")]
		private void DrawSurfaceBG_Snow(float backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
		{
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002514")]
		[Address(RVA = "0x11A9FC0", Offset = "0x11A9FC0", VA = "0x11A9FC0")]
		private void SetBackgroundOffsets(int backgroundID, float backgroundTopMagicNumber, int pushBGTopHack)
		{
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002515")]
		[Address(RVA = "0x11A3388", Offset = "0x11A3388", VA = "0x11A3388")]
		private void DrawSurfaceBG_Hallow(float backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
		{
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002516")]
		[Address(RVA = "0x11A23B8", Offset = "0x11A23B8", VA = "0x11A23B8")]
		private void DrawSurfaceBG_GoodEvilDesert(float backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int layerIndex)
		{
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002517")]
		[Address(RVA = "0x11A0FC0", Offset = "0x11A0FC0", VA = "0x11A0FC0")]
		private void DrawSurfaceBG_Jungle(float backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
		{
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002518")]
		[Address(RVA = "0x119FD00", Offset = "0x119FD00", VA = "0x119FD00")]
		private void DrawSurfaceBG_Desert(float backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
		{
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002519")]
		[Address(RVA = "0x115DB8C", Offset = "0x115DB8C", VA = "0x115DB8C")]
		private void DrawSurfaceBG_DrawChangeOverlay(int backgroundAreaId)
		{
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251A")]
		[Address(RVA = "0x119E448", Offset = "0x119E448", VA = "0x119E448")]
		private void DrawSurfaceBG_Corrupt(float backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
		{
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x00011B38 File Offset: 0x0000FD38
		[Token(Token = "0x600251B")]
		[Address(RVA = "0x11A9920", Offset = "0x11A9920", VA = "0x11A9920")]
		private Rectangle? GetBackgroundRect(int backgroundTextureIndex)
		{
			return null;
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x00011B50 File Offset: 0x0000FD50
		[Token(Token = "0x600251C")]
		[Address(RVA = "0x11AAEF4", Offset = "0x11AAEF4", VA = "0x11AAEF4")]
		private uint GetBackgroundCounter()
		{
			return 0U;
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251D")]
		[Address(RVA = "0x1198FD0", Offset = "0x1198FD0", VA = "0x1198FD0")]
		private void DrawBackgroundItem(Texture2D texture, TextureMask mask, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth = 0f)
		{
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251E")]
		[Address(RVA = "0x119CA98", Offset = "0x119CA98", VA = "0x119CA98")]
		private void DrawSurfaceBG_Forest(float backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
		{
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251F")]
		[Address(RVA = "0x11AB0B8", Offset = "0x11AB0B8", VA = "0x11AB0B8")]
		private void DrawBackgroundBlackFill()
		{
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002520")]
		[Address(RVA = "0x11AB55C", Offset = "0x11AB55C", VA = "0x11AB55C")]
		public void DrawTileCracks(int crackType, HitTile hitter)
		{
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06002521 RID: 9505 RVA: 0x00011B68 File Offset: 0x0000FD68
		[Token(Token = "0x1700055D")]
		public static bool ShouldPlayRainbowBoulderMusic
		{
			[Token(Token = "0x6002521")]
			[Address(RVA = "0x108A758", Offset = "0x108A758", VA = "0x108A758")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002522")]
		[Address(RVA = "0x11ACA3C", Offset = "0x11ACA3C", VA = "0x11ACA3C")]
		public void RainbowBoulderMusicPlayCallback(int trackIndex, int sequentialTimesPlayed)
		{
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06002523 RID: 9507 RVA: 0x00011B80 File Offset: 0x0000FD80
		[Token(Token = "0x1700055E")]
		public static bool IsGraphicsDeviceAvailable
		{
			[Token(Token = "0x6002523")]
			[Address(RVA = "0x11ACB58", Offset = "0x11ACB58", VA = "0x11ACB58")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002524")]
		[Address(RVA = "0x11ACB60", Offset = "0x11ACB60", VA = "0x11ACB60")]
		private void GraphicsDeviceLost(object sender, EventArgs evt)
		{
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002525")]
		[Address(RVA = "0x11ACB64", Offset = "0x11ACB64", VA = "0x11ACB64", Slot = "6")]
		protected override void Draw(GameTime gameTime)
		{
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002526")]
		[Address(RVA = "0x11ACD00", Offset = "0x11ACD00", VA = "0x11ACD00")]
		private void DoDraw(GameTime gameTime)
		{
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002527")]
		[Address(RVA = "0x11C7AF0", Offset = "0x11C7AF0", VA = "0x11C7AF0")]
		private static void DrawLensFlare()
		{
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002528")]
		[Address(RVA = "0x11C99D8", Offset = "0x11C99D8", VA = "0x11C99D8")]
		public static void UpdateSceneMetrics(Rectangle visualScanArea)
		{
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002529")]
		[Address(RVA = "0x11C9F5C", Offset = "0x11C9F5C", VA = "0x11C9F5C")]
		public static void BlackFadeCameraTeleport()
		{
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x00011B98 File Offset: 0x0000FD98
		[Token(Token = "0x1700055F")]
		public static float BlackFadeDist
		{
			[Token(Token = "0x600252A")]
			[Address(RVA = "0x11CAEC0", Offset = "0x11CAEC0", VA = "0x11CAEC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x00011BB0 File Offset: 0x0000FDB0
		[Token(Token = "0x600252B")]
		[Address(RVA = "0x11CAFF4", Offset = "0x11CAFF4", VA = "0x11CAFF4")]
		public static Vector2 PlayerFocusedScreenPosition()
		{
			return default(Vector2);
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252C")]
		[Address(RVA = "0x11CB294", Offset = "0x11CB294", VA = "0x11CB294")]
		public static void StartCameraTransitionForPlayerTeleport(Vector2 oldPosition, float lerp, int lerpSpeedupDelay)
		{
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252D")]
		[Address(RVA = "0x11BE8D8", Offset = "0x11BE8D8", VA = "0x11BE8D8")]
		private static void DoDraw_UpdateCameraPosition()
		{
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252E")]
		[Address(RVA = "0x10B0F40", Offset = "0x10B0F40", VA = "0x10B0F40")]
		private static void UpdateCameraPan()
		{
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		[Token(Token = "0x17000560")]
		public static bool IsCameraTrackingObject
		{
			[Token(Token = "0x600252F")]
			[Address(RVA = "0x1153670", Offset = "0x1153670", VA = "0x1153670")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x00011BE0 File Offset: 0x0000FDE0
		[Token(Token = "0x6002530")]
		[Address(RVA = "0x11C9D20", Offset = "0x11C9D20", VA = "0x11C9D20")]
		private static bool GetObjectTrackingCameraPan(out Vector2 trackedPosition, out float panRate, out float doubleRateDist)
		{
			return default(bool);
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		[Token(Token = "0x6002531")]
		[Address(RVA = "0x11CBAC4", Offset = "0x11CBAC4", VA = "0x11CBAC4")]
		private static bool GetPlayerControlledCameraPan(ref Vector2 targetPan, ref float maxPanSpeed)
		{
			return default(bool);
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x00011C10 File Offset: 0x0000FE10
		[Token(Token = "0x6002532")]
		[Address(RVA = "0x11CC724", Offset = "0x11CC724", VA = "0x11CC724")]
		public static bool IsItDay()
		{
			return default(bool);
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00011C28 File Offset: 0x0000FE28
		[Token(Token = "0x6002533")]
		[Address(RVA = "0x11CC7C8", Offset = "0x11CC7C8", VA = "0x11CC7C8")]
		public static double starGameMath(double value = 1.0)
		{
			return 0.0;
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002534")]
		[Address(RVA = "0x11C3800", Offset = "0x11C3800", VA = "0x11C3800")]
		private void DrawSunAndMoon(Main.SceneArea sceneArea, Color moonColor, Color sunColor, float tempMushroomInfluence)
		{
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06002535 RID: 9525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000561")]
		public static bool[] SunMask
		{
			[Token(Token = "0x6002535")]
			[Address(RVA = "0x11AB050", Offset = "0x11AB050", VA = "0x11AB050")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002536")]
		[Address(RVA = "0x11C2FCC", Offset = "0x11C2FCC", VA = "0x11C2FCC")]
		private void DrawStarsInBackground(Main.SceneArea sceneArea, bool artificial)
		{
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002537")]
		[Address(RVA = "0x11CC8A8", Offset = "0x11CC8A8", VA = "0x11CC8A8")]
		private void DrawStar(ref Main.SceneArea sceneArea, float starOpacity, Color bgColorForStars, int i, Star theStar, bool artificial, bool foreground = false)
		{
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002538")]
		[Address(RVA = "0x11C2AC4", Offset = "0x11C2AC4", VA = "0x11C2AC4")]
		private static void ApplyColorOfTheSkiesToTiles()
		{
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002539")]
		[Address(RVA = "0x11C2BF8", Offset = "0x11C2BF8", VA = "0x11C2BF8")]
		private static void UpdateAtmosphereTransparencyToSkyColor()
		{
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253A")]
		[Address(RVA = "0x11CDA58", Offset = "0x11CDA58", VA = "0x11CDA58")]
		private void Debug_PrettifyMap()
		{
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253B")]
		[Address(RVA = "0x11C98D4", Offset = "0x11C98D4", VA = "0x11C98D4")]
		private static void DrawNetplayStatusText()
		{
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253C")]
		[Address(RVA = "0x11C91D4", Offset = "0x11C91D4", VA = "0x11C91D4")]
		private void DrawPlayerChatBubbles()
		{
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253D")]
		[Address(RVA = "0x11C7BEC", Offset = "0x11C7BEC", VA = "0x11C7BEC")]
		private void DoDraw_WallsTilesNPCs()
		{
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253E")]
		[Address(RVA = "0x11CEC88", Offset = "0x11CEC88", VA = "0x11CEC88")]
		private void DoDraw_Waterfalls()
		{
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253F")]
		[Address(RVA = "0x11CF500", Offset = "0x11CF500", VA = "0x11CF500")]
		private void DoDraw_Tiles_Solid()
		{
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002540")]
		[Address(RVA = "0x11CE238", Offset = "0x11CE238", VA = "0x11CE238")]
		private void DoDraw_Tiles_NonSolid()
		{
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002541")]
		[Address(RVA = "0x11D03F4", Offset = "0x11D03F4", VA = "0x11D03F4")]
		private void DoDraw_DrawNPCsOverTiles()
		{
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002542")]
		[Address(RVA = "0x11CED6C", Offset = "0x11CED6C", VA = "0x11CED6C")]
		private void DoDraw_DrawNPCsBehindTiles()
		{
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002543")]
		[Address(RVA = "0x11CE0DC", Offset = "0x11CE0DC", VA = "0x11CE0DC")]
		private void DrawBackGore()
		{
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002544")]
		[Address(RVA = "0x11CDA5C", Offset = "0x11CDA5C", VA = "0x11CDA5C")]
		private void DoDraw_WallsAndBlacks()
		{
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002545")]
		[Address(RVA = "0x11C1010", Offset = "0x11C1010", VA = "0x11C1010")]
		private static void SetBackColor(Main.InfoToSetBackColor info, out Color sunColor, out Color moonColor)
		{
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002546")]
		[Address(RVA = "0x11CA3F8", Offset = "0x11CA3F8", VA = "0x11CA3F8")]
		public static void GetAreaToLight(out int firstTileX, out int lastTileX, out int firstTileY, out int lastTileY)
		{
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002547")]
		[Address(RVA = "0x11C09E0", Offset = "0x11C09E0", VA = "0x11C09E0")]
		private void DoLightTiles()
		{
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002548")]
		[Address(RVA = "0x11CB6FC", Offset = "0x11CB6FC", VA = "0x11CB6FC")]
		public static void ClampScreenPositionToWorld()
		{
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x00011C40 File Offset: 0x0000FE40
		[Token(Token = "0x6002549")]
		[Address(RVA = "0x11D0B30", Offset = "0x11D0B30", VA = "0x11D0B30")]
		private static float ComputeScAdj(float screenY, float screenHeight)
		{
			return 0f;
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254A")]
		[Address(RVA = "0x11C6BC8", Offset = "0x11C6BC8", VA = "0x11C6BC8")]
		private void DrawBG()
		{
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254B")]
		[Address(RVA = "0x11D0C78", Offset = "0x11D0C78", VA = "0x11D0C78")]
		private void DrawBG_HandleBackgroundTransition(int newBackgroundStyle)
		{
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254C")]
		[Address(RVA = "0x11D1490", Offset = "0x11D1490", VA = "0x11D1490")]
		private void UpdateBGVisibility_FrontLayer(int? targetBiomeOverride, float? transitionAmountOverride)
		{
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x00011C58 File Offset: 0x0000FE58
		[Token(Token = "0x600254D")]
		[Address(RVA = "0x11D1994", Offset = "0x11D1994", VA = "0x11D1994")]
		private bool UpdateBGVisibility_FrontLayer_IsDesertVariantSwap(int targetBiome, int originalBiome)
		{
			return default(bool);
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254E")]
		[Address(RVA = "0x11D1130", Offset = "0x11D1130", VA = "0x11D1130")]
		private void UpdateBGVisibility_BackLayer(int? targetBiomeOverride, float? transitionAmountOverride)
		{
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00011C70 File Offset: 0x0000FE70
		[Token(Token = "0x600254F")]
		[Address(RVA = "0x11CA778", Offset = "0x11CA778", VA = "0x11CA778")]
		public static int GetPreferredBGStyleForPlayer()
		{
			return 0;
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002550")]
		[Address(RVA = "0x11D1B78", Offset = "0x11D1B78", VA = "0x11D1B78")]
		private void DrawBG_ModifyBGFarBackLayerAlpha(int desiredBG, [Optional] int? desiredBG2, [Optional] float? transitionAmountOverride)
		{
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002551")]
		[Address(RVA = "0x11C88E4", Offset = "0x11C88E4", VA = "0x11C88E4")]
		public void DrawInfernoRings()
		{
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002552")]
		[Address(RVA = "0x10AF270", Offset = "0x10AF270", VA = "0x10AF270")]
		private static void UpdateInvasion()
		{
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002553")]
		[Address(RVA = "0x11D1F44", Offset = "0x11D1F44", VA = "0x11D1F44")]
		private static void InvasionWarning()
		{
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x00011C88 File Offset: 0x0000FE88
		[Token(Token = "0x6002554")]
		[Address(RVA = "0x11D2744", Offset = "0x11D2744", VA = "0x11D2744")]
		public static bool CanStartInvasion(int type = 1, bool ignoreDelay = false)
		{
			return default(bool);
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002555")]
		[Address(RVA = "0x11D28E0", Offset = "0x11D28E0", VA = "0x11D28E0")]
		public static void StartInvasion(int type = 1)
		{
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002556")]
		[Address(RVA = "0x11D2D28", Offset = "0x11D2D28", VA = "0x11D2D28")]
		public static void FakeLoadInvasionStart()
		{
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002557")]
		[Address(RVA = "0x10B031C", Offset = "0x10B031C", VA = "0x10B031C")]
		private static void UpdateClient()
		{
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002558")]
		[Address(RVA = "0x10B0B18", Offset = "0x10B0B18", VA = "0x10B0B18")]
		private static void CheckAssignItemOwnership()
		{
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002559")]
		[Address(RVA = "0x10AFA08", Offset = "0x10AFA08", VA = "0x10AFA08")]
		private static void UpdateServer()
		{
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255A")]
		[Address(RVA = "0x1134C50", Offset = "0x1134C50", VA = "0x1134C50")]
		public static void NewText(string newText, Color color, bool onlyCurrentPlayer = false)
		{
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255B")]
		[Address(RVA = "0x11D2E90", Offset = "0x11D2E90", VA = "0x11D2E90")]
		public static void NewText(string newText, byte R = 255, byte G = 255, byte B = 255, bool onlyCurrentPlayer = false)
		{
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255C")]
		[Address(RVA = "0x107C4EC", Offset = "0x107C4EC", VA = "0x107C4EC")]
		public static void NewTextMultiline(string text, bool force = false, [Optional] Color c, int WidthLimit = -1, bool onlyCurrentPlayer = false)
		{
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600255D RID: 9565 RVA: 0x00011CA0 File Offset: 0x0000FEA0
		[Token(Token = "0x17000562")]
		public static bool IsRainingForever
		{
			[Token(Token = "0x600255D")]
			[Address(RVA = "0x11D3250", Offset = "0x11D3250", VA = "0x11D3250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255E")]
		[Address(RVA = "0x11D32C8", Offset = "0x11D32C8", VA = "0x11D32C8")]
		public static void StopRain(bool instant = false)
		{
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255F")]
		[Address(RVA = "0x11D33D8", Offset = "0x11D33D8", VA = "0x11D33D8")]
		public static void StartRain(bool instant = false, [Optional] float? strengthOverride, bool guaranteeCoinRain = false)
		{
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002560")]
		[Address(RVA = "0x11D3D64", Offset = "0x11D3D64", VA = "0x11D3D64")]
		public static void ChangeRain(bool instant = false, [Optional] float? strengthOverride)
		{
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002561")]
		[Address(RVA = "0x11D40E8", Offset = "0x11D40E8", VA = "0x11D40E8")]
		public static void StartSlimeRain(bool announce = true)
		{
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002562")]
		[Address(RVA = "0x11579D8", Offset = "0x11579D8", VA = "0x11579D8")]
		public static void StopSlimeRain(bool announce = true)
		{
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002563")]
		[Address(RVA = "0x10AC0A0", Offset = "0x10AC0A0", VA = "0x10AC0A0")]
		private static void UpdateTime()
		{
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x00011CB8 File Offset: 0x0000FEB8
		[Token(Token = "0x6002564")]
		[Address(RVA = "0x11DA080", Offset = "0x11DA080", VA = "0x11DA080")]
		public static bool AnyPlayerReadyToFightKingSlime()
		{
			return default(bool);
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002565")]
		[Address(RVA = "0x11DA1C4", Offset = "0x11DA1C4", VA = "0x11DA1C4")]
		public static void SkipToTime(int timeToSet, bool setIsDayTime)
		{
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x00011CD0 File Offset: 0x0000FED0
		[Token(Token = "0x6002566")]
		[Address(RVA = "0x11D479C", Offset = "0x11D479C", VA = "0x11D479C")]
		public static bool ShouldNormalEventsBeAbleToStart()
		{
			return default(bool);
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002567")]
		[Address(RVA = "0x11D5860", Offset = "0x11D5860", VA = "0x11D5860")]
		public static void UpdateTime_StartNight(ref bool stopEvents)
		{
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002568")]
		[Address(RVA = "0x11D4864", Offset = "0x11D4864", VA = "0x11D4864")]
		public static void UpdateTime_StartDay(ref bool stopEvents)
		{
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002569")]
		[Address(RVA = "0x11D5498", Offset = "0x11D5498", VA = "0x11D5498")]
		private static void HandleMeteorFall()
		{
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256A")]
		[Address(RVA = "0x11D453C", Offset = "0x11D453C", VA = "0x11D453C")]
		private static void UpdateSlimeRainWarning()
		{
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		[Token(Token = "0x600256B")]
		[Address(RVA = "0x11DA3E0", Offset = "0x11DA3E0", VA = "0x11DA3E0")]
		public static BestiaryUnlockProgressReport GetBestiaryProgressReport()
		{
			return default(BestiaryUnlockProgressReport);
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256C")]
		[Address(RVA = "0x11D6E3C", Offset = "0x11D6E3C", VA = "0x11D6E3C")]
		private static void UpdateTime_SpawnTownNPCs()
		{
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x00011D00 File Offset: 0x0000FF00
		[Token(Token = "0x600256D")]
		[Address(RVA = "0x11DA5B0", Offset = "0x11DA5B0", VA = "0x11DA5B0")]
		public static int DamageVar(float dmg, float luck = 0f)
		{
			return 0;
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x00011D18 File Offset: 0x0000FF18
		[Token(Token = "0x600256E")]
		[Address(RVA = "0x11DA8FC", Offset = "0x11DA8FC", VA = "0x11DA8FC")]
		public static double CalculateDamageNPCsTake(int Damage, int Defense)
		{
			return 0.0;
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x00011D30 File Offset: 0x0000FF30
		[Token(Token = "0x600256F")]
		[Address(RVA = "0x11DA92C", Offset = "0x11DA92C", VA = "0x11DA92C")]
		public static double CalculateDamagePlayersTakeInPVP(int Damage, int Defense)
		{
			return 0.0;
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00011D48 File Offset: 0x0000FF48
		[Token(Token = "0x6002570")]
		[Address(RVA = "0x11DA95C", Offset = "0x11DA95C", VA = "0x11DA95C")]
		public static double CalculateDamagePlayersTake(int Damage, int Defense)
		{
			return 0.0;
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002571")]
		[Address(RVA = "0x11DAB40", Offset = "0x11DAB40", VA = "0x11DAB40")]
		public void OnTileChangeEvent(int x, int y, int count, TileChangeType eventType)
		{
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002572")]
		[Address(RVA = "0x1038B44", Offset = "0x1038B44", VA = "0x1038B44")]
		public static void ClearPendingPlayerSelectCallbacks()
		{
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002573")]
		[Address(RVA = "0x11DABCC", Offset = "0x11DABCC", VA = "0x11DABCC")]
		public static void SelectPlayer(PlayerFileData data)
		{
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002574")]
		[Address(RVA = "0x10B26CC", Offset = "0x10B26CC", VA = "0x10B26CC")]
		public static void ToggleFullScreen()
		{
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002575")]
		[Address(RVA = "0x1034B1C", Offset = "0x1034B1C", VA = "0x1034B1C")]
		public static void SetFullScreen(bool fullscreen)
		{
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002576")]
		[Address(RVA = "0x11DB228", Offset = "0x11DB228", VA = "0x11DB228")]
		public static void SetResolution(int width, int height)
		{
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002577")]
		[Address(RVA = "0x10325DC", Offset = "0x10325DC", VA = "0x10325DC")]
		public static void SetDisplayMode(int width, int height, bool fullscreen)
		{
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002578")]
		[Address(RVA = "0x101F204", Offset = "0x101F204", VA = "0x101F204")]
		public static void FixUIScale()
		{
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002579")]
		[Address(RVA = "0x11DB2BC", Offset = "0x11DB2BC", VA = "0x11DB2BC")]
		public void FullscreenStartup()
		{
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257A")]
		[Address(RVA = "0x118C4B4", Offset = "0x118C4B4", VA = "0x118C4B4")]
		public void UpdateDisplaySettings()
		{
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257B")]
		[Address(RVA = "0x11DB42C", Offset = "0x11DB42C", VA = "0x11DB42C")]
		public static void SwitchNetMode(int mode)
		{
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257C")]
		[Address(RVA = "0x11DB4A4", Offset = "0x11DB4A4", VA = "0x11DB4A4")]
		public static void WeGameRequireExitGame()
		{
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x00011D60 File Offset: 0x0000FF60
		[Token(Token = "0x600257E")]
		[Address(RVA = "0x11E0158", Offset = "0x11E0158", VA = "0x11E0158")]
		private bool <SetupDrawInterfaceLayers>b__2380_9()
		{
			return default(bool);
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x00011D78 File Offset: 0x0000FF78
		[Token(Token = "0x600257F")]
		[Address(RVA = "0x11E0168", Offset = "0x11E0168", VA = "0x11E0168")]
		private bool <SetupDrawInterfaceLayers>b__2380_10()
		{
			return default(bool);
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x00011D90 File Offset: 0x0000FF90
		[Token(Token = "0x6002580")]
		[Address(RVA = "0x11E0178", Offset = "0x11E0178", VA = "0x11E0178")]
		private bool <SetupDrawInterfaceLayers>b__2380_12()
		{
			return default(bool);
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x00011DA8 File Offset: 0x0000FFA8
		[Token(Token = "0x6002581")]
		[Address(RVA = "0x11E0188", Offset = "0x11E0188", VA = "0x11E0188")]
		private bool <SetupDrawInterfaceLayers>b__2380_13()
		{
			return default(bool);
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		[Token(Token = "0x6002582")]
		[Address(RVA = "0x11E0198", Offset = "0x11E0198", VA = "0x11E0198")]
		private bool <SetupDrawInterfaceLayers>b__2380_17()
		{
			return default(bool);
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00011DD8 File Offset: 0x0000FFD8
		[Token(Token = "0x6002583")]
		[Address(RVA = "0x11E01A8", Offset = "0x11E01A8", VA = "0x11E01A8")]
		private bool <SetupDrawInterfaceLayers>b__2380_20()
		{
			return default(bool);
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x00011DF0 File Offset: 0x0000FFF0
		[Token(Token = "0x6002584")]
		[Address(RVA = "0x11E0240", Offset = "0x11E0240", VA = "0x11E0240")]
		private bool <SetupDrawInterfaceLayers>b__2380_22()
		{
			return default(bool);
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x00011E08 File Offset: 0x00010008
		[Token(Token = "0x6002585")]
		[Address(RVA = "0x11E02D0", Offset = "0x11E02D0", VA = "0x11E02D0")]
		private bool <SetupDrawInterfaceLayers>b__2380_23()
		{
			return default(bool);
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x00011E20 File Offset: 0x00010020
		[Token(Token = "0x6002586")]
		[Address(RVA = "0x11E02E0", Offset = "0x11E02E0", VA = "0x11E02E0")]
		private bool <SetupDrawInterfaceLayers>b__2380_24()
		{
			return default(bool);
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x00011E38 File Offset: 0x00010038
		[Token(Token = "0x6002587")]
		[Address(RVA = "0x11E02F0", Offset = "0x11E02F0", VA = "0x11E02F0")]
		private bool <SetupDrawInterfaceLayers>b__2380_25()
		{
			return default(bool);
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x00011E50 File Offset: 0x00010050
		[Token(Token = "0x6002588")]
		[Address(RVA = "0x11E0300", Offset = "0x11E0300", VA = "0x11E0300")]
		private bool <SetupDrawInterfaceLayers>b__2380_26()
		{
			return default(bool);
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x00011E68 File Offset: 0x00010068
		[Token(Token = "0x6002589")]
		[Address(RVA = "0x11E0310", Offset = "0x11E0310", VA = "0x11E0310")]
		private bool <SetupDrawInterfaceLayers>b__2380_27()
		{
			return default(bool);
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x00011E80 File Offset: 0x00010080
		[Token(Token = "0x600258A")]
		[Address(RVA = "0x11E0320", Offset = "0x11E0320", VA = "0x11E0320")]
		private bool <SetupDrawInterfaceLayers>b__2380_28()
		{
			return default(bool);
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x00011E98 File Offset: 0x00010098
		[Token(Token = "0x600258B")]
		[Address(RVA = "0x11E0328", Offset = "0x11E0328", VA = "0x11E0328")]
		private bool <SetupDrawInterfaceLayers>b__2380_29()
		{
			return default(bool);
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x00011EB0 File Offset: 0x000100B0
		[Token(Token = "0x600258C")]
		[Address(RVA = "0x11E0338", Offset = "0x11E0338", VA = "0x11E0338")]
		private bool <SetupDrawInterfaceLayers>b__2380_30()
		{
			return default(bool);
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x00011EC8 File Offset: 0x000100C8
		[Token(Token = "0x600258D")]
		[Address(RVA = "0x11E0348", Offset = "0x11E0348", VA = "0x11E0348")]
		private bool <SetupDrawInterfaceLayers>b__2380_38()
		{
			return default(bool);
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x00011EE0 File Offset: 0x000100E0
		[Token(Token = "0x600258E")]
		[Address(RVA = "0x11E0358", Offset = "0x11E0358", VA = "0x11E0358")]
		private bool <SetupDrawInterfaceLayers>b__2380_39()
		{
			return default(bool);
		}

		// Token: 0x0400328B RID: 12939
		[Token(Token = "0x400328B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool SettingsEnabled_AutoReuseAllItems;

		// Token: 0x0400328C RID: 12940
		[Token(Token = "0x400328C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ulong EverLastingTicker;

		// Token: 0x0400328D RID: 12941
		[Token(Token = "0x400328D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static int CurrentDrawnEntityShader;

		// Token: 0x0400328E RID: 12942
		[Token(Token = "0x400328E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static Entity CurrentDrawnEntity;

		// Token: 0x0400328F RID: 12943
		[Token(Token = "0x400328F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool LightingEveryFrame;

		// Token: 0x04003290 RID: 12944
		[Token(Token = "0x4003290")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public static bool AllowUnfocusedInputOnGamepad;

		// Token: 0x04003291 RID: 12945
		[Token(Token = "0x4003291")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public static bool CrouchingEnabled;

		// Token: 0x04003292 RID: 12946
		[Token(Token = "0x4003292")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static Main instance;

		// Token: 0x04003293 RID: 12947
		[Token(Token = "0x4003293")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool AnnouncementBoxDisabled;

		// Token: 0x04003294 RID: 12948
		[Token(Token = "0x4003294")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static int AnnouncementBoxRange;

		// Token: 0x04003295 RID: 12949
		[Token(Token = "0x4003295")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static bool drunkWorld;

		// Token: 0x04003296 RID: 12950
		[Token(Token = "0x4003296")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public static bool getGoodWorld;

		// Token: 0x04003297 RID: 12951
		[Token(Token = "0x4003297")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static Vector2 destroyerHB;

		// Token: 0x04003298 RID: 12952
		[Token(Token = "0x4003298")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static FileMetadata WorldFileMetadata;

		// Token: 0x04003299 RID: 12953
		[Token(Token = "0x4003299")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static PingMapLayer Pings;

		// Token: 0x0400329A RID: 12954
		[Token(Token = "0x400329A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static CreativeUI CreativeMenu;

		// Token: 0x0400329B RID: 12955
		[Token(Token = "0x400329B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static MapIconOverlay MapIcons;

		// Token: 0x0400329C RID: 12956
		[Token(Token = "0x400329C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static Vector2 _lastPingMousePosition;

		// Token: 0x0400329D RID: 12957
		[Token(Token = "0x400329D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static double _lastPingMouseDownTime;

		// Token: 0x0400329E RID: 12958
		[Token(Token = "0x400329E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static Main.OnPlayerSelected _pendingCharacterSelect;

		// Token: 0x0400329F RID: 12959
		[Token(Token = "0x400329F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static bool drawBackGore;

		// Token: 0x040032A0 RID: 12960
		[Token(Token = "0x40032A0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static ulong LobbyId;

		// Token: 0x040032A1 RID: 12961
		[Token(Token = "0x40032A1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static bool ServerSideCharacter;

		// Token: 0x040032A2 RID: 12962
		[Token(Token = "0x40032A2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static string clientUUID;

		// Token: 0x040032A3 RID: 12963
		[Token(Token = "0x40032A3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static int toolTipDistance;

		// Token: 0x040032A4 RID: 12964
		[Token(Token = "0x40032A4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static float GlobalTimeWrappedHourly;

		// Token: 0x040032A5 RID: 12965
		[Token(Token = "0x40032A5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static bool GlobalTimerPaused;

		// Token: 0x040032A6 RID: 12966
		[Token(Token = "0x40032A6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public static GameTime gameTimeCache;

		// Token: 0x040032A7 RID: 12967
		[Token(Token = "0x40032A7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static ulong TileFrameSeed;

		// Token: 0x040032A8 RID: 12968
		[Token(Token = "0x40032A8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static ulong _drawCycleCounter;

		// Token: 0x040032A9 RID: 12969
		[Token(Token = "0x40032A9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static int npcStreamSpeed;

		// Token: 0x040032AA RID: 12970
		[Token(Token = "0x40032AA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public static bool superFast;

		// Token: 0x040032AB RID: 12971
		[Token(Token = "0x40032AB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static bool[] townNPCCanSpawn;

		// Token: 0x040032AC RID: 12972
		[Token(Token = "0x40032AC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public static int musicBox2;

		// Token: 0x040032AD RID: 12973
		[Token(Token = "0x40032AD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static int musicBoxNotModifiedByVolume;

		// Token: 0x040032AE RID: 12974
		[Token(Token = "0x40032AE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public static byte HealthBarDrawSettings;

		// Token: 0x040032AF RID: 12975
		[Token(Token = "0x40032AF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static float wFrCounter;

		// Token: 0x040032B0 RID: 12976
		[Token(Token = "0x40032B0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public static float wFrame;

		// Token: 0x040032B1 RID: 12977
		[Token(Token = "0x40032B1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static bool drawDiag;

		// Token: 0x040032B2 RID: 12978
		[Token(Token = "0x40032B2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public static bool drawRelease;

		// Token: 0x040032B3 RID: 12979
		[Token(Token = "0x40032B3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		public static bool drawBetterDebug;

		// Token: 0x040032B4 RID: 12980
		[Token(Token = "0x40032B4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB3")]
		public static bool betterDebugRelease;

		// Token: 0x040032B5 RID: 12981
		[Token(Token = "0x40032B5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public static bool drawToScreen;

		// Token: 0x040032B6 RID: 12982
		[Token(Token = "0x40032B6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public static bool targetSet;

		// Token: 0x040032B7 RID: 12983
		[Token(Token = "0x40032B7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static ConcurrentQueue<Action> _mainThreadActions;

		// Token: 0x040032B8 RID: 12984
		[Token(Token = "0x40032B8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public static float essScale;

		// Token: 0x040032B9 RID: 12985
		[Token(Token = "0x40032B9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static int essDir;

		// Token: 0x040032BA RID: 12986
		[Token(Token = "0x40032BA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public static float[] cloudBGX;

		// Token: 0x040032BB RID: 12987
		[Token(Token = "0x40032BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static float cloudBGAlpha;

		// Token: 0x040032BC RID: 12988
		[Token(Token = "0x40032BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public static float cloudBGActive;

		// Token: 0x040032BD RID: 12989
		[Token(Token = "0x40032BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static int[] cloudBG;

		// Token: 0x040032BE RID: 12990
		[Token(Token = "0x40032BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public static int[] treeMntBGSet1;

		// Token: 0x040032BF RID: 12991
		[Token(Token = "0x40032BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static int[] treeMntBGSet2;

		// Token: 0x040032C0 RID: 12992
		[Token(Token = "0x40032C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public static int[] treeMntBGSet3;

		// Token: 0x040032C1 RID: 12993
		[Token(Token = "0x40032C1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static int[] treeMntBGSet4;

		// Token: 0x040032C2 RID: 12994
		[Token(Token = "0x40032C2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public static int[] treeBGSet1;

		// Token: 0x040032C3 RID: 12995
		[Token(Token = "0x40032C3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public static int[] treeBGSet2;

		// Token: 0x040032C4 RID: 12996
		[Token(Token = "0x40032C4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public static int[] treeBGSet3;

		// Token: 0x040032C5 RID: 12997
		[Token(Token = "0x40032C5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public static int[] treeBGSet4;

		// Token: 0x040032C6 RID: 12998
		[Token(Token = "0x40032C6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public static int[] corruptBG;

		// Token: 0x040032C7 RID: 12999
		[Token(Token = "0x40032C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public static int[] jungleBG;

		// Token: 0x040032C8 RID: 13000
		[Token(Token = "0x40032C8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public static int[] snowMntBG;

		// Token: 0x040032C9 RID: 13001
		[Token(Token = "0x40032C9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public static int[] snowBG;

		// Token: 0x040032CA RID: 13002
		[Token(Token = "0x40032CA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public static int[] hallowBG;

		// Token: 0x040032CB RID: 13003
		[Token(Token = "0x40032CB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public static int[] crimsonBG;

		// Token: 0x040032CC RID: 13004
		[Token(Token = "0x40032CC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public static int[] desertBG;

		// Token: 0x040032CD RID: 13005
		[Token(Token = "0x40032CD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public static int[] mushroomBG;

		// Token: 0x040032CE RID: 13006
		[Token(Token = "0x40032CE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public static int oceanBG;

		// Token: 0x040032CF RID: 13007
		[Token(Token = "0x40032CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public static int[] underworldBG;

		// Token: 0x040032D0 RID: 13008
		[Token(Token = "0x40032D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public static BackgroundVariantSet desertBackgroundSet;

		// Token: 0x040032D1 RID: 13009
		[Token(Token = "0x40032D1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public static int[] treeX;

		// Token: 0x040032D2 RID: 13010
		[Token(Token = "0x40032D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public static int[] treeStyle;

		// Token: 0x040032D3 RID: 13011
		[Token(Token = "0x40032D3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public static int[] caveBackX;

		// Token: 0x040032D4 RID: 13012
		[Token(Token = "0x40032D4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public static int[] caveBackStyle;

		// Token: 0x040032D5 RID: 13013
		[Token(Token = "0x40032D5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public static int iceBackStyle;

		// Token: 0x040032D6 RID: 13014
		[Token(Token = "0x40032D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public static int hellBackStyle;

		// Token: 0x040032D7 RID: 13015
		[Token(Token = "0x40032D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public static int jungleBackStyle;

		// Token: 0x040032D8 RID: 13016
		[Token(Token = "0x40032D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public static string debugWords;

		// Token: 0x040032D9 RID: 13017
		[Token(Token = "0x40032D9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public static bool gamePad;

		// Token: 0x040032DA RID: 13018
		[Token(Token = "0x40032DA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		public static bool xMas;

		// Token: 0x040032DB RID: 13019
		[Token(Token = "0x40032DB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x142")]
		public static bool halloween;

		// Token: 0x040032DC RID: 13020
		[Token(Token = "0x40032DC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x143")]
		public static bool forceXMasForToday;

		// Token: 0x040032DD RID: 13021
		[Token(Token = "0x40032DD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public static bool forceHalloweenForToday;

		// Token: 0x040032DE RID: 13022
		[Token(Token = "0x40032DE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x145")]
		public static bool forceXMasForever;

		// Token: 0x040032DF RID: 13023
		[Token(Token = "0x40032DF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x146")]
		public static bool forceHalloweenForever;

		// Token: 0x040032E0 RID: 13024
		[Token(Token = "0x40032E0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public static int snowDust;

		// Token: 0x040032E1 RID: 13025
		[Token(Token = "0x40032E1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public static bool changeTheTitle;

		// Token: 0x040032E2 RID: 13026
		[Token(Token = "0x40032E2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public static int keyCount;

		// Token: 0x040032E3 RID: 13027
		[Token(Token = "0x40032E3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		public static string[] keyString;

		// Token: 0x040032E4 RID: 13028
		[Token(Token = "0x40032E4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public static int[] keyInt;

		// Token: 0x040032E5 RID: 13029
		[Token(Token = "0x40032E5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public static double UpdateTimeAccumulator;

		// Token: 0x040032E6 RID: 13030
		[Token(Token = "0x40032E6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public static bool drawSkip;

		// Token: 0x040032E7 RID: 13031
		[Token(Token = "0x40032E7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public static int fpsCount;

		// Token: 0x040032E8 RID: 13032
		[Token(Token = "0x40032E8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public static Stopwatch fpsTimer;

		// Token: 0x040032E9 RID: 13033
		[Token(Token = "0x40032E9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		public static int dayRate;

		// Token: 0x040032EA RID: 13034
		[Token(Token = "0x40032EA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public static int desiredWorldTilesUpdateRate;

		// Token: 0x040032EB RID: 13035
		[Token(Token = "0x40032EB")]
		public const int MaxWorldViewSizeWidth = 1920;

		// Token: 0x040032EC RID: 13036
		[Token(Token = "0x40032EC")]
		public const int MaxWorldViewSizeHeight = 1200;

		// Token: 0x040032ED RID: 13037
		[Token(Token = "0x40032ED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public static int maxScreenW;

		// Token: 0x040032EE RID: 13038
		[Token(Token = "0x40032EE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public static int maxScreenH;

		// Token: 0x040032EF RID: 13039
		[Token(Token = "0x40032EF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		public static readonly Point MaxWorldViewSize;

		// Token: 0x040032F0 RID: 13040
		[Token(Token = "0x40032F0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		public static int minScreenW;

		// Token: 0x040032F1 RID: 13041
		[Token(Token = "0x40032F1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public static int minScreenH;

		// Token: 0x040032F2 RID: 13042
		[Token(Token = "0x40032F2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		public static float iS;

		// Token: 0x040032F3 RID: 13043
		[Token(Token = "0x40032F3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public static int buffScanAreaWidth;

		// Token: 0x040032F4 RID: 13044
		[Token(Token = "0x40032F4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		public static int buffScanAreaHeight;

		// Token: 0x040032F5 RID: 13045
		[Token(Token = "0x40032F5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public static float musicPitch;

		// Token: 0x040032F6 RID: 13046
		[Token(Token = "0x40032F6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		public static int maxMP;

		// Token: 0x040032F7 RID: 13047
		[Token(Token = "0x40032F7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public static bool shortRender;

		// Token: 0x040032F8 RID: 13048
		[Token(Token = "0x40032F8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public static int ladyBugRainBoost;

		// Token: 0x040032F9 RID: 13049
		[Token(Token = "0x40032F9")]
		public const int BG_STYLES_COUNT = 14;

		// Token: 0x040032FA RID: 13050
		[Token(Token = "0x40032FA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public static int EquipPage;

		// Token: 0x040032FB RID: 13051
		[Token(Token = "0x40032FB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		public static int EquipPageSelected;

		// Token: 0x040032FC RID: 13052
		[Token(Token = "0x40032FC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public static int wofNPCIndex;

		// Token: 0x040032FD RID: 13053
		[Token(Token = "0x40032FD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public static int wofDrawAreaTop;

		// Token: 0x040032FE RID: 13054
		[Token(Token = "0x40032FE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public static int wofDrawAreaBottom;

		// Token: 0x040032FF RID: 13055
		[Token(Token = "0x40032FF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public static int wofDrawFrameIndex;

		// Token: 0x04003300 RID: 13056
		[Token(Token = "0x4003300")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public static int offScreenRange;

		// Token: 0x04003301 RID: 13057
		[Token(Token = "0x4003301")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public static int maxMapUpdates;

		// Token: 0x04003302 RID: 13058
		[Token(Token = "0x4003302")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public static int textureMaxWidth;

		// Token: 0x04003303 RID: 13059
		[Token(Token = "0x4003303")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public static int textureMaxHeight;

		// Token: 0x04003304 RID: 13060
		[Token(Token = "0x4003304")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public static int mapTargetX;

		// Token: 0x04003305 RID: 13061
		[Token(Token = "0x4003305")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public static int mapTargetY;

		// Token: 0x04003306 RID: 13062
		[Token(Token = "0x4003306")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public static bool[,] initMap;

		// Token: 0x04003307 RID: 13063
		[Token(Token = "0x4003307")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public static float mapMinimapDefaultScale;

		// Token: 0x04003308 RID: 13064
		[Token(Token = "0x4003308")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static uint _gameUpdateCount;

		// Token: 0x04003309 RID: 13065
		[Token(Token = "0x4003309")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		public static bool SkipAssemblyLoad;

		// Token: 0x0400330A RID: 13066
		[Token(Token = "0x400330A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public static KeyboardState keyState;

		// Token: 0x0400330B RID: 13067
		[Token(Token = "0x400330B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		public static KeyboardState oldKeyState;

		// Token: 0x0400330C RID: 13068
		[Token(Token = "0x400330C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public static bool craftingHide;

		// Token: 0x0400330D RID: 13069
		[Token(Token = "0x400330D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x239")]
		public static bool armorHide;

		// Token: 0x0400330E RID: 13070
		[Token(Token = "0x400330E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		public static float craftingAlpha;

		// Token: 0x0400330F RID: 13071
		[Token(Token = "0x400330F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		public static float armorAlpha;

		// Token: 0x04003310 RID: 13072
		[Token(Token = "0x4003310")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x244")]
		public static float[] buffAlpha;

		// Token: 0x04003311 RID: 13073
		[Token(Token = "0x4003311")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public static bool hardMode;

		// Token: 0x04003312 RID: 13074
		[Token(Token = "0x4003312")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		public static Vector2 sceneWaterPos;

		// Token: 0x04003313 RID: 13075
		[Token(Token = "0x4003313")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x254")]
		public static Vector2 sceneTilePos;

		// Token: 0x04003314 RID: 13076
		[Token(Token = "0x4003314")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		public static Vector2 sceneTile2Pos;

		// Token: 0x04003315 RID: 13077
		[Token(Token = "0x4003315")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x264")]
		public static Vector2 sceneWallPos;

		// Token: 0x04003316 RID: 13078
		[Token(Token = "0x4003316")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		public static Vector2 sceneBackgroundPos;

		// Token: 0x04003317 RID: 13079
		[Token(Token = "0x4003317")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x274")]
		public static bool maxQ;

		// Token: 0x04003318 RID: 13080
		[Token(Token = "0x4003318")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		public static int DiscoR;

		// Token: 0x04003319 RID: 13081
		[Token(Token = "0x4003319")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		public static int DiscoB;

		// Token: 0x0400331A RID: 13082
		[Token(Token = "0x400331A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		public static int DiscoG;

		// Token: 0x0400331B RID: 13083
		[Token(Token = "0x400331B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		public static int teamCooldownLen;

		// Token: 0x0400331C RID: 13084
		[Token(Token = "0x400331C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		public static bool gamePaused;

		// Token: 0x0400331D RID: 13085
		[Token(Token = "0x400331D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x289")]
		public static bool gameInactive;

		// Token: 0x0400331E RID: 13086
		[Token(Token = "0x400331E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		public static int updatesCountedForFPS;

		// Token: 0x0400331F RID: 13087
		[Token(Token = "0x400331F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		public static int drawsCountedForFPS;

		// Token: 0x04003320 RID: 13088
		[Token(Token = "0x4003320")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		public static int uCount;

		// Token: 0x04003321 RID: 13089
		[Token(Token = "0x4003321")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		public static int updateRate;

		// Token: 0x04003322 RID: 13090
		[Token(Token = "0x4003322")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
		public static int frameRate;

		// Token: 0x04003323 RID: 13091
		[Token(Token = "0x4003323")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		public static bool RGBRelease;

		// Token: 0x04003324 RID: 13092
		[Token(Token = "0x4003324")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2A1")]
		public static bool qRelease;

		// Token: 0x04003325 RID: 13093
		[Token(Token = "0x4003325")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2A2")]
		public static bool netRelease;

		// Token: 0x04003326 RID: 13094
		[Token(Token = "0x4003326")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2A3")]
		public static bool frameRelease;

		// Token: 0x04003327 RID: 13095
		[Token(Token = "0x4003327")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
		public static int magmaBGFrame;

		// Token: 0x04003328 RID: 13096
		[Token(Token = "0x4003328")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		public static int magmaBGFrameCounter;

		// Token: 0x04003329 RID: 13097
		[Token(Token = "0x4003329")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		public static int saveTimer;

		// Token: 0x0400332A RID: 13098
		[Token(Token = "0x400332A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		public static bool autoJoin;

		// Token: 0x0400332B RID: 13099
		[Token(Token = "0x400332B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2B1")]
		public static bool serverStarting;

		// Token: 0x0400332C RID: 13100
		[Token(Token = "0x400332C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
		public static float leftWorld;

		// Token: 0x0400332D RID: 13101
		[Token(Token = "0x400332D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		public static float rightWorld;

		// Token: 0x0400332E RID: 13102
		[Token(Token = "0x400332E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
		public static float topWorld;

		// Token: 0x0400332F RID: 13103
		[Token(Token = "0x400332F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		public static float bottomWorld;

		// Token: 0x04003330 RID: 13104
		[Token(Token = "0x4003330")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C4")]
		public static int maxTilesX;

		// Token: 0x04003331 RID: 13105
		[Token(Token = "0x4003331")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		public static int maxTilesY;

		// Token: 0x04003332 RID: 13106
		[Token(Token = "0x4003332")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2CC")]
		public static int maxSectionsX;

		// Token: 0x04003333 RID: 13107
		[Token(Token = "0x4003333")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		public static int maxSectionsY;

		// Token: 0x04003334 RID: 13108
		[Token(Token = "0x4003334")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
		public static int maxDustToDraw;

		// Token: 0x04003335 RID: 13109
		[Token(Token = "0x4003335")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		public static int maxNetPlayers;

		// Token: 0x04003336 RID: 13110
		[Token(Token = "0x4003336")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
		public static bool ServerHasRemoteIP;

		// Token: 0x04003337 RID: 13111
		[Token(Token = "0x4003337")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		public static IPAddress ServerRemoteIP;

		// Token: 0x04003338 RID: 13112
		[Token(Token = "0x4003338")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
		public static int ServerRemotePort;

		// Token: 0x04003339 RID: 13113
		[Token(Token = "0x4003339")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		public static bool ServerHasPassword;

		// Token: 0x0400333A RID: 13114
		[Token(Token = "0x400333A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2EC")]
		public static int activePlayerCount;

		// Token: 0x0400333B RID: 13115
		[Token(Token = "0x400333B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		public static int activeScalingPlayerCount;

		// Token: 0x0400333C RID: 13116
		[Token(Token = "0x400333C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
		public static int maxActivePlayers;

		// Token: 0x0400333D RID: 13117
		[Token(Token = "0x400333D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		public static int maxRain;

		// Token: 0x0400333E RID: 13118
		[Token(Token = "0x400333E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2FC")]
		public static int slimeWarningTime;

		// Token: 0x0400333F RID: 13119
		[Token(Token = "0x400333F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		public static int slimeWarningDelay;

		// Token: 0x04003340 RID: 13120
		[Token(Token = "0x4003340")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x304")]
		public static float slimeRainNPCSlots;

		// Token: 0x04003341 RID: 13121
		[Token(Token = "0x4003341")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		public static bool[] slimeRainNPC;

		// Token: 0x04003342 RID: 13122
		[Token(Token = "0x4003342")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		public static double slimeRainTime;

		// Token: 0x04003343 RID: 13123
		[Token(Token = "0x4003343")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		public static bool slimeRain;

		// Token: 0x04003344 RID: 13124
		[Token(Token = "0x4003344")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
		public static int slimeRainKillCount;

		// Token: 0x04003345 RID: 13125
		[Token(Token = "0x4003345")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		public static float cameraX;

		// Token: 0x04003346 RID: 13126
		[Token(Token = "0x4003346")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x324")]
		public static float cameraY;

		// Token: 0x04003347 RID: 13127
		[Token(Token = "0x4003347")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		public static int WorldRollingBackupsCountToKeep;

		// Token: 0x04003348 RID: 13128
		[Token(Token = "0x4003348")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		public static bool swapMusic;

		// Token: 0x04003349 RID: 13129
		[Token(Token = "0x4003349")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		public static int dungeonX;

		// Token: 0x0400334A RID: 13130
		[Token(Token = "0x400334A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x334")]
		public static int dungeonY;

		// Token: 0x0400334B RID: 13131
		[Token(Token = "0x400334B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		public static Liquid[] liquid;

		// Token: 0x0400334C RID: 13132
		[Token(Token = "0x400334C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
		public static LiquidBuffer[] liquidBuffer;

		// Token: 0x0400334D RID: 13133
		[Token(Token = "0x400334D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		public static bool dedServ;

		// Token: 0x0400334E RID: 13134
		[Token(Token = "0x400334E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x344")]
		public static int spamCount;

		// Token: 0x0400334F RID: 13135
		[Token(Token = "0x400334F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		public static int newMusic;

		// Token: 0x04003350 RID: 13136
		[Token(Token = "0x4003350")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34C")]
		public static int curMusic;

		// Token: 0x04003351 RID: 13137
		[Token(Token = "0x4003351")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		public static int dayMusic;

		// Token: 0x04003352 RID: 13138
		[Token(Token = "0x4003352")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x354")]
		public static int ugMusic;

		// Token: 0x04003353 RID: 13139
		[Token(Token = "0x4003353")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		public static bool bannerMouseOver;

		// Token: 0x04003354 RID: 13140
		[Token(Token = "0x4003354")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x35C")]
		public static string buffString;

		// Token: 0x04003355 RID: 13141
		[Token(Token = "0x4003355")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		public static string libPath;

		// Token: 0x04003356 RID: 13142
		[Token(Token = "0x4003356")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x364")]
		public static int lo;

		// Token: 0x04003357 RID: 13143
		[Token(Token = "0x4003357")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		public static int LogoA;

		// Token: 0x04003358 RID: 13144
		[Token(Token = "0x4003358")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x36C")]
		public static int LogoB;

		// Token: 0x04003359 RID: 13145
		[Token(Token = "0x4003359")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		public static bool LogoT;

		// Token: 0x0400335A RID: 13146
		[Token(Token = "0x400335A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x374")]
		public static string statusText;

		// Token: 0x0400335B RID: 13147
		[Token(Token = "0x400335B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		public static string worldName;

		// Token: 0x0400335C RID: 13148
		[Token(Token = "0x400335C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x37C")]
		public static Color tileColor;

		// Token: 0x0400335D RID: 13149
		[Token(Token = "0x400335D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		public static double worldSurface;

		// Token: 0x0400335E RID: 13150
		[Token(Token = "0x400335E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		public static double rockLayer;

		// Token: 0x0400335F RID: 13151
		[Token(Token = "0x400335F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		public static bool dayTime;

		// Token: 0x04003360 RID: 13152
		[Token(Token = "0x4003360")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		public static double time;

		// Token: 0x04003361 RID: 13153
		[Token(Token = "0x4003361")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		public static double timeForVisualEffects;

		// Token: 0x04003362 RID: 13154
		[Token(Token = "0x4003362")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		public static int moonPhase;

		// Token: 0x04003363 RID: 13155
		[Token(Token = "0x4003363")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3AC")]
		public static short sunModY;

		// Token: 0x04003364 RID: 13156
		[Token(Token = "0x4003364")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3AE")]
		public static short moonModY;

		// Token: 0x04003365 RID: 13157
		[Token(Token = "0x4003365")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		public static bool alreadyGrabbingSunOrMoon;

		// Token: 0x04003366 RID: 13158
		[Token(Token = "0x4003366")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3B1")]
		public static bool bloodMoon;

		// Token: 0x04003367 RID: 13159
		[Token(Token = "0x4003367")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3B2")]
		public static bool pumpkinMoon;

		// Token: 0x04003368 RID: 13160
		[Token(Token = "0x4003368")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3B3")]
		public static bool snowMoon;

		// Token: 0x04003369 RID: 13161
		[Token(Token = "0x4003369")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3B4")]
		public static float cloudAlpha;

		// Token: 0x0400336A RID: 13162
		[Token(Token = "0x400336A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		public static float maxRaining;

		// Token: 0x0400336B RID: 13163
		[Token(Token = "0x400336B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3BC")]
		public static float oldMaxRaining;

		// Token: 0x0400336C RID: 13164
		[Token(Token = "0x400336C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		public static int rainTime;

		// Token: 0x0400336D RID: 13165
		[Token(Token = "0x400336D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C4")]
		public static bool raining;

		// Token: 0x0400336E RID: 13166
		[Token(Token = "0x400336E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		public static int coinRain;

		// Token: 0x0400336F RID: 13167
		[Token(Token = "0x400336F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3CC")]
		public static bool eclipse;

		// Token: 0x04003370 RID: 13168
		[Token(Token = "0x4003370")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		public static float eclipseLight;

		// Token: 0x04003371 RID: 13169
		[Token(Token = "0x4003371")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3D4")]
		public static int checkForSpawns;

		// Token: 0x04003372 RID: 13170
		[Token(Token = "0x4003372")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		public static int helpText;

		// Token: 0x04003373 RID: 13171
		[Token(Token = "0x4003373")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3DC")]
		public static int BartenderHelpTextIndex;

		// Token: 0x04003374 RID: 13172
		[Token(Token = "0x4003374")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		public static float demonTorch;

		// Token: 0x04003375 RID: 13173
		[Token(Token = "0x4003375")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3E4")]
		public static int demonTorchDir;

		// Token: 0x04003376 RID: 13174
		[Token(Token = "0x4003376")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		public static float martianLight;

		// Token: 0x04003377 RID: 13175
		[Token(Token = "0x4003377")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3EC")]
		public static int martianLightDir;

		// Token: 0x04003378 RID: 13176
		[Token(Token = "0x4003378")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		public static float masterColor;

		// Token: 0x04003379 RID: 13177
		[Token(Token = "0x4003379")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3F4")]
		public static int masterColorDir;

		// Token: 0x0400337A RID: 13178
		[Token(Token = "0x400337A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		public static int numStars;

		// Token: 0x0400337B RID: 13179
		[Token(Token = "0x400337B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3FC")]
		public static int weatherCounter;

		// Token: 0x0400337C RID: 13180
		[Token(Token = "0x400337C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		public static int numClouds;

		// Token: 0x0400337D RID: 13181
		[Token(Token = "0x400337D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x404")]
		public static int numCloudsTemp;

		// Token: 0x0400337E RID: 13182
		[Token(Token = "0x400337E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		public static float windSpeedCurrent;

		// Token: 0x0400337F RID: 13183
		[Token(Token = "0x400337F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40C")]
		public static float windSpeedTarget;

		// Token: 0x04003380 RID: 13184
		[Token(Token = "0x4003380")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		public static int windCounter;

		// Token: 0x04003381 RID: 13185
		[Token(Token = "0x4003381")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x414")]
		public static int extremeWindCounter;

		// Token: 0x04003382 RID: 13186
		[Token(Token = "0x4003382")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		public static bool windPhysics;

		// Token: 0x04003383 RID: 13187
		[Token(Token = "0x4003383")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x41C")]
		public static float windPhysicsStrength;

		// Token: 0x04003384 RID: 13188
		[Token(Token = "0x4003384")]
		public const float lowWindLimit = 0.35f;

		// Token: 0x04003385 RID: 13189
		[Token(Token = "0x4003385")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		public static Cloud[] cloud;

		// Token: 0x04003386 RID: 13190
		[Token(Token = "0x4003386")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x424")]
		public static bool resetClouds;

		// Token: 0x04003387 RID: 13191
		[Token(Token = "0x4003387")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		public static int fadeCounter;

		// Token: 0x04003388 RID: 13192
		[Token(Token = "0x4003388")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x42C")]
		public static float invAlpha;

		// Token: 0x04003389 RID: 13193
		[Token(Token = "0x4003389")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		public static float invDir;

		// Token: 0x0400338A RID: 13194
		[Token(Token = "0x400338A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x434")]
		public static bool allChestStackHover;

		// Token: 0x0400338B RID: 13195
		[Token(Token = "0x400338B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x435")]
		public static bool inventorySortMouseOver;

		// Token: 0x0400338C RID: 13196
		[Token(Token = "0x400338C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		public static int moonType;

		// Token: 0x0400338D RID: 13197
		[Token(Token = "0x400338D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x43C")]
		public static bool UseExperimentalFeatures;

		// Token: 0x0400338E RID: 13198
		[Token(Token = "0x400338E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		public static string DefaultSeed;

		// Token: 0x0400338F RID: 13199
		[Token(Token = "0x400338F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x444")]
		public static float[] musicFade;

		// Token: 0x04003390 RID: 13200
		[Token(Token = "0x4003390")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		public static HairstyleUnlocksHelper Hairstyles;

		// Token: 0x04003391 RID: 13201
		[Token(Token = "0x4003391")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44C")]
		public static bool tilesLoaded;

		// Token: 0x04003392 RID: 13202
		[Token(Token = "0x4003392")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		public static TileData tile;

		// Token: 0x04003393 RID: 13203
		[Token(Token = "0x4003393")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x454")]
		public static Dust[] dust;

		// Token: 0x04003394 RID: 13204
		[Token(Token = "0x4003394")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		public static Star[] star;

		// Token: 0x04003395 RID: 13205
		[Token(Token = "0x4003395")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x45C")]
		public static WorldItem[] item;

		// Token: 0x04003396 RID: 13206
		[Token(Token = "0x4003396")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		public static int[] timeItemSlotCannotBeReusedFor;

		// Token: 0x04003397 RID: 13207
		[Token(Token = "0x4003397")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x464")]
		public static NPC[] npc;

		// Token: 0x04003398 RID: 13208
		[Token(Token = "0x4003398")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x468")]
		public static Gore[] gore;

		// Token: 0x04003399 RID: 13209
		[Token(Token = "0x4003399")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x46C")]
		public static List<int> BoneJavlinProjectiles;

		// Token: 0x0400339A RID: 13210
		[Token(Token = "0x400339A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		public static List<int> TentacleSpikeProjectiles;

		// Token: 0x0400339B RID: 13211
		[Token(Token = "0x400339B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x474")]
		public static List<int> DaybreakProjectiles;

		// Token: 0x0400339C RID: 13212
		[Token(Token = "0x400339C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		public static List<int> StardustCellMinionShotProjectiles;

		// Token: 0x0400339D RID: 13213
		[Token(Token = "0x400339D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x47C")]
		public static List<int> BloodButchererProjectiles;

		// Token: 0x0400339E RID: 13214
		[Token(Token = "0x400339E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		public static Projectile[] projectile;

		// Token: 0x0400339F RID: 13215
		[Token(Token = "0x400339F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x484")]
		public static int[,] projectileIdentity;

		// Token: 0x040033A0 RID: 13216
		[Token(Token = "0x40033A0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x488")]
		public static CombatText[] combatText;

		// Token: 0x040033A1 RID: 13217
		[Token(Token = "0x40033A1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48C")]
		public static Chest[] chest;

		// Token: 0x040033A2 RID: 13218
		[Token(Token = "0x40033A2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		public static Sign[] sign;

		// Token: 0x040033A3 RID: 13219
		[Token(Token = "0x40033A3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x494")]
		public static int[] itemFrame;

		// Token: 0x040033A4 RID: 13220
		[Token(Token = "0x40033A4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		public static int[] itemFrameCounter;

		// Token: 0x040033A5 RID: 13221
		[Token(Token = "0x40033A5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x49C")]
		public static bool screenMaximized;

		// Token: 0x040033A6 RID: 13222
		[Token(Token = "0x40033A6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x49D")]
		public static bool screenBorderless;

		// Token: 0x040033A7 RID: 13223
		[Token(Token = "0x40033A7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
		public static int screenBorderlessPendingResizes;

		// Token: 0x040033A8 RID: 13224
		[Token(Token = "0x40033A8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4A4")]
		public static int teamNamePlateDistance;

		// Token: 0x040033A9 RID: 13225
		[Token(Token = "0x40033A9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		public static int multiplayerNPCSmoothingRange;

		// Token: 0x040033AA RID: 13226
		[Token(Token = "0x40033AA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4AC")]
		public static bool Setting_UseReducedMaxLiquids;

		// Token: 0x040033AB RID: 13227
		[Token(Token = "0x40033AB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
		public static int PlayerOverheadChatMessageDisplayTime;

		// Token: 0x040033AC RID: 13228
		[Token(Token = "0x40033AC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4B4")]
		public static object CurrentInputTextTakerOverride;

		// Token: 0x040033AD RID: 13229
		[Token(Token = "0x40033AD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		public static float[] hotbarScale;

		// Token: 0x040033AE RID: 13230
		[Token(Token = "0x40033AE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4BC")]
		public static byte mouseTextColor;

		// Token: 0x040033AF RID: 13231
		[Token(Token = "0x40033AF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		public static int mouseTextColorChange;

		// Token: 0x040033B0 RID: 13232
		[Token(Token = "0x40033B0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C4")]
		public static bool hasFocus;

		// Token: 0x040033B1 RID: 13233
		[Token(Token = "0x40033B1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C5")]
		public static bool recFastScroll;

		// Token: 0x040033B2 RID: 13234
		[Token(Token = "0x40033B2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C6")]
		public static bool recBigList;

		// Token: 0x040033B3 RID: 13235
		[Token(Token = "0x40033B3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
		public static int recStart;

		// Token: 0x040033B4 RID: 13236
		[Token(Token = "0x40033B4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4CC")]
		public static Recipe[] recipe;

		// Token: 0x040033B5 RID: 13237
		[Token(Token = "0x40033B5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
		public static float[] availableRecipeY;

		// Token: 0x040033B6 RID: 13238
		[Token(Token = "0x40033B6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4D4")]
		public static Player[] player;

		// Token: 0x040033B7 RID: 13239
		[Token(Token = "0x40033B7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
		public static Player[] playerVisualClone;

		// Token: 0x040033B8 RID: 13240
		[Token(Token = "0x40033B8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4DC")]
		public static bool[] countsAsHostForGameplay;

		// Token: 0x040033B9 RID: 13241
		[Token(Token = "0x40033B9")]
		public const int TravelShopMaxSlots = 40;

		// Token: 0x040033BA RID: 13242
		[Token(Token = "0x40033BA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
		public static int[] travelShop;

		// Token: 0x040033BB RID: 13243
		[Token(Token = "0x40033BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4E4")]
		public static List<string> anglerWhoFinishedToday;

		// Token: 0x040033BC RID: 13244
		[Token(Token = "0x40033BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
		public static int anglerQuest;

		// Token: 0x040033BD RID: 13245
		[Token(Token = "0x40033BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4EC")]
		public static AmbienceServer AmbienceServer;

		// Token: 0x040033BE RID: 13246
		[Token(Token = "0x40033BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
		public static ItemDropDatabase ItemDropsDB;

		// Token: 0x040033BF RID: 13247
		[Token(Token = "0x40033BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4F4")]
		public static FishDropRuleList FishDropsDB;

		// Token: 0x040033C0 RID: 13248
		[Token(Token = "0x40033C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
		public static BestiaryDatabase BestiaryDB;

		// Token: 0x040033C1 RID: 13249
		[Token(Token = "0x40033C1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4FC")]
		public static ItemDropResolver ItemDropSolver;

		// Token: 0x040033C2 RID: 13250
		[Token(Token = "0x40033C2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x500")]
		public static BestiaryUnlocksTracker BestiaryTracker;

		// Token: 0x040033C3 RID: 13251
		[Token(Token = "0x40033C3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x504")]
		public static TeleportPylonsSystem PylonSystem;

		// Token: 0x040033C4 RID: 13252
		[Token(Token = "0x40033C4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x508")]
		public static ShopHelper ShopHelper;

		// Token: 0x040033C5 RID: 13253
		[Token(Token = "0x40033C5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50C")]
		public static bool Support4K;

		// Token: 0x040033C6 RID: 13254
		[Token(Token = "0x40033C6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x510")]
		public static float MinimumZoomComparerX;

		// Token: 0x040033C7 RID: 13255
		[Token(Token = "0x40033C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x514")]
		public static float MinimumZoomComparerY;

		// Token: 0x040033C8 RID: 13256
		[Token(Token = "0x40033C8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x518")]
		public static int LogicCheckScreenWidth;

		// Token: 0x040033C9 RID: 13257
		[Token(Token = "0x40033C9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x51C")]
		public static int LogicCheckScreenHeight;

		// Token: 0x040033CA RID: 13258
		[Token(Token = "0x40033CA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x520")]
		private static Main.WorldPreparationState _worldPreparationState;

		// Token: 0x040033CB RID: 13259
		[Token(Token = "0x40033CB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x524")]
		public static float temporaryGUIScaleSlider;

		// Token: 0x040033CC RID: 13260
		[Token(Token = "0x40033CC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x528")]
		public static bool temporaryGUIScaleSliderUpdate;

		// Token: 0x040033CD RID: 13261
		[Token(Token = "0x40033CD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x52C")]
		public static Item HoverItem;

		// Token: 0x040033CE RID: 13262
		[Token(Token = "0x40033CE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x530")]
		private static int backSpaceCount;

		// Token: 0x040033CF RID: 13263
		[Token(Token = "0x40033CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x534")]
		private static float backSpaceRate;

		// Token: 0x040033D0 RID: 13264
		[Token(Token = "0x40033D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x538")]
		public static string motd;

		// Token: 0x040033D1 RID: 13265
		[Token(Token = "0x40033D1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x53C")]
		public static bool toggleFullscreen;

		// Token: 0x040033D2 RID: 13266
		[Token(Token = "0x40033D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x540")]
		public static int numDisplayModes;

		// Token: 0x040033D3 RID: 13267
		[Token(Token = "0x40033D3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x544")]
		public static bool menuBGChangedDay;

		// Token: 0x040033D4 RID: 13268
		[Token(Token = "0x40033D4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x545")]
		public static bool menuBGChangedNight;

		// Token: 0x040033D5 RID: 13269
		[Token(Token = "0x40033D5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x546")]
		public static bool lockMenuBGChange;

		// Token: 0x040033D6 RID: 13270
		[Token(Token = "0x40033D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x548")]
		public static List<WorldFileData> WorldList;

		// Token: 0x040033D7 RID: 13271
		[Token(Token = "0x40033D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54C")]
		public static WorldFileData ActiveWorldFileData;

		// Token: 0x040033D8 RID: 13272
		[Token(Token = "0x40033D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x550")]
		public static string CloudWorldPath;

		// Token: 0x040033D9 RID: 13273
		[Token(Token = "0x40033D9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x554")]
		private static string _playerPath;

		// Token: 0x040033DA RID: 13274
		[Token(Token = "0x40033DA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x558")]
		public static string CloudPlayerPath;

		// Token: 0x040033DB RID: 13275
		[Token(Token = "0x40033DB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x55C")]
		private static string _oldPlayerPath;

		// Token: 0x040033DC RID: 13276
		[Token(Token = "0x40033DC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x560")]
		private static string _oldWorldPath;

		// Token: 0x040033DD RID: 13277
		[Token(Token = "0x40033DD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x564")]
		public static KeyboardState inputText;

		// Token: 0x040033DE RID: 13278
		[Token(Token = "0x40033DE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x588")]
		public static KeyboardState oldInputText;

		// Token: 0x040033DF RID: 13279
		[Token(Token = "0x40033DF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5AC")]
		public static int PendingResolutionWidth;

		// Token: 0x040033E0 RID: 13280
		[Token(Token = "0x40033E0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5B0")]
		public static int PendingResolutionHeight;

		// Token: 0x040033E1 RID: 13281
		[Token(Token = "0x40033E1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5B4")]
		public static bool PendingBorderlessState;

		// Token: 0x040033E2 RID: 13282
		[Token(Token = "0x40033E2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5B8")]
		public static int invasionType;

		// Token: 0x040033E3 RID: 13283
		[Token(Token = "0x40033E3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C0")]
		public static double invasionX;

		// Token: 0x040033E4 RID: 13284
		[Token(Token = "0x40033E4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C8")]
		public static int invasionSize;

		// Token: 0x040033E5 RID: 13285
		[Token(Token = "0x40033E5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5CC")]
		public static int invasionDelay;

		// Token: 0x040033E6 RID: 13286
		[Token(Token = "0x40033E6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5D0")]
		public static int invasionWarn;

		// Token: 0x040033E7 RID: 13287
		[Token(Token = "0x40033E7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5D4")]
		public static int invasionSizeStart;

		// Token: 0x040033E8 RID: 13288
		[Token(Token = "0x40033E8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5D8")]
		public static int invasionProgressIcon;

		// Token: 0x040033E9 RID: 13289
		[Token(Token = "0x40033E9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5DC")]
		public static int invasionProgress;

		// Token: 0x040033EA RID: 13290
		[Token(Token = "0x40033EA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5E0")]
		public static int invasionProgressMax;

		// Token: 0x040033EB RID: 13291
		[Token(Token = "0x40033EB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5E4")]
		public static int invasionProgressWave;

		// Token: 0x040033EC RID: 13292
		[Token(Token = "0x40033EC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5E8")]
		public static int invasionWaveMax;

		// Token: 0x040033ED RID: 13293
		[Token(Token = "0x40033ED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5EC")]
		public static int invasionProgressDisplayLeft;

		// Token: 0x040033EE RID: 13294
		[Token(Token = "0x40033EE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5F0")]
		public static float invasionProgressAlpha;

		// Token: 0x040033EF RID: 13295
		[Token(Token = "0x40033EF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5F4")]
		public static bool mouseExit;

		// Token: 0x040033F0 RID: 13296
		[Token(Token = "0x40033F0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5F8")]
		public static float exitScale;

		// Token: 0x040033F1 RID: 13297
		[Token(Token = "0x40033F1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5FC")]
		public static bool mouseReforge;

		// Token: 0x040033F2 RID: 13298
		[Token(Token = "0x40033F2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x600")]
		public static float reforgeScale;

		// Token: 0x040033F3 RID: 13299
		[Token(Token = "0x40033F3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x604")]
		public static Player clientPlayer;

		// Token: 0x040033F4 RID: 13300
		[Token(Token = "0x40033F4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x608")]
		public static string getIP;

		// Token: 0x040033F5 RID: 13301
		[Token(Token = "0x40033F5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60C")]
		public static string getPort;

		// Token: 0x040033F6 RID: 13302
		[Token(Token = "0x40033F6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x610")]
		public static bool menuMultiplayer;

		// Token: 0x040033F7 RID: 13303
		[Token(Token = "0x40033F7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x611")]
		public static bool menuServer;

		// Token: 0x040033F8 RID: 13304
		[Token(Token = "0x40033F8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x614")]
		public static int netMode;

		// Token: 0x040033F9 RID: 13305
		[Token(Token = "0x40033F9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x618")]
		private static int _targetNetMode;

		// Token: 0x040033FA RID: 13306
		[Token(Token = "0x40033FA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x61C")]
		private static bool _hasPendingNetmodeChange;

		// Token: 0x040033FB RID: 13307
		[Token(Token = "0x40033FB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x620")]
		public static int netPlayCounter;

		// Token: 0x040033FC RID: 13308
		[Token(Token = "0x40033FC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x624")]
		public static int lastNPCUpdate;

		// Token: 0x040033FD RID: 13309
		[Token(Token = "0x40033FD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x628")]
		public static int lastItemUpdate;

		// Token: 0x040033FE RID: 13310
		[Token(Token = "0x40033FE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x62C")]
		public static int maxNPCUpdates;

		// Token: 0x040033FF RID: 13311
		[Token(Token = "0x40033FF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x630")]
		public static int maxItemUpdates;

		// Token: 0x04003400 RID: 13312
		[Token(Token = "0x4003400")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x634")]
		public static ColorSlidersSet mouseColorSlider;

		// Token: 0x04003401 RID: 13313
		[Token(Token = "0x4003401")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x638")]
		public static ColorSlidersSet mouseBorderColorSlider;

		// Token: 0x04003402 RID: 13314
		[Token(Token = "0x4003402")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x63C")]
		public static bool hideUI;

		// Token: 0x04003403 RID: 13315
		[Token(Token = "0x4003403")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x63D")]
		public static bool releaseUI;

		// Token: 0x04003404 RID: 13316
		[Token(Token = "0x4003404")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x640")]
		public static int FrameSkipMode;

		// Token: 0x04003405 RID: 13317
		[Token(Token = "0x4003405")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x644")]
		public static bool terrariasFixedTiming;

		// Token: 0x04003406 RID: 13318
		[Token(Token = "0x4003406")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int splashCounter;

		// Token: 0x04003407 RID: 13319
		[Token(Token = "0x4003407")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x648")]
		public static ParticleRenderer ParticleSystem_World_OverPlayers;

		// Token: 0x04003408 RID: 13320
		[Token(Token = "0x4003408")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64C")]
		public static ParticleRenderer ParticleSystem_World_BehindPlayers;

		// Token: 0x04003409 RID: 13321
		[Token(Token = "0x4003409")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x650")]
		public static ParticleRenderer ParticleSystem_OverCursor;

		// Token: 0x0400340A RID: 13322
		[Token(Token = "0x400340A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x654")]
		public static AnchoredEntitiesCollection sittingManager;

		// Token: 0x0400340B RID: 13323
		[Token(Token = "0x400340B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x658")]
		public static AnchoredEntitiesCollection sleepingManager;

		// Token: 0x0400340C RID: 13324
		[Token(Token = "0x400340C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x65C")]
		private static bool shouldSetDefaultUIScale;

		// Token: 0x0400340D RID: 13325
		[Token(Token = "0x400340D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x660")]
		private static float newDefaultUIScale;

		// Token: 0x0400340E RID: 13326
		[Token(Token = "0x400340E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x664")]
		private static bool _target60FPS;

		// Token: 0x0400340F RID: 13327
		[Token(Token = "0x400340F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x665")]
		private static bool startFullscreen;

		// Token: 0x04003410 RID: 13328
		[Token(Token = "0x4003410")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x666")]
		public static bool CaptureModeDisabled;

		// Token: 0x04003411 RID: 13329
		[Token(Token = "0x4003411")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x667")]
		public static bool unityMouseOver;

		// Token: 0x04003412 RID: 13330
		[Token(Token = "0x4003412")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x668")]
		public static bool LocalModeServer;

		// Token: 0x04003413 RID: 13331
		[Token(Token = "0x4003413")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x66C")]
		public static LegacyPlayerRenderer PlayerRenderer;

		// Token: 0x04003414 RID: 13332
		[Token(Token = "0x4003414")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x670")]
		public static IPlayerRenderer PotionOfReturnRenderer;

		// Token: 0x04003415 RID: 13333
		[Token(Token = "0x4003415")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x674")]
		private static bool? _overrideForExpertMode;

		// Token: 0x04003416 RID: 13334
		[Token(Token = "0x4003416")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x676")]
		private static bool? _overrideForMasterMode;

		// Token: 0x04003417 RID: 13335
		[Token(Token = "0x4003417")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x678")]
		public static int musicError;

		// Token: 0x04003418 RID: 13336
		[Token(Token = "0x4003418")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x67C")]
		public static string oldStatusText;

		// Token: 0x04003419 RID: 13337
		[Token(Token = "0x4003419")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x680")]
		public static bool localPlayerConnected;

		// Token: 0x0400341A RID: 13338
		[Token(Token = "0x400341A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x681")]
		public static bool autoShutdown;

		// Token: 0x0400341B RID: 13339
		[Token(Token = "0x400341B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x682")]
		public static bool forceServerShutdown;

		// Token: 0x0400341C RID: 13340
		[Token(Token = "0x400341C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x683")]
		public static bool serverBootupInProgress;

		// Token: 0x0400341D RID: 13341
		[Token(Token = "0x400341D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x684")]
		public static int sundialCooldown;

		// Token: 0x0400341E RID: 13342
		[Token(Token = "0x400341E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x688")]
		public static bool fastForwardTimeToDawn;

		// Token: 0x0400341F RID: 13343
		[Token(Token = "0x400341F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x689")]
		public static bool _shouldUseWindyDayMusic;

		// Token: 0x04003420 RID: 13344
		[Token(Token = "0x4003420")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68A")]
		public static bool _shouldUseStormMusic;

		// Token: 0x04003421 RID: 13345
		[Token(Token = "0x4003421")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68B")]
		public static bool playOldTile;

		// Token: 0x04003422 RID: 13346
		[Token(Token = "0x4003422")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68C")]
		public static bool boulderLogo;

		// Token: 0x04003423 RID: 13347
		[Token(Token = "0x4003423")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x690")]
		public static float ambientWaterfallX;

		// Token: 0x04003424 RID: 13348
		[Token(Token = "0x4003424")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x694")]
		public static float ambientWaterfallY;

		// Token: 0x04003425 RID: 13349
		[Token(Token = "0x4003425")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x698")]
		public static float ambientWaterfallStrength;

		// Token: 0x04003426 RID: 13350
		[Token(Token = "0x4003426")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x69C")]
		public static float ambientLavafallX;

		// Token: 0x04003427 RID: 13351
		[Token(Token = "0x4003427")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6A0")]
		public static float ambientLavafallY;

		// Token: 0x04003428 RID: 13352
		[Token(Token = "0x4003428")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6A4")]
		public static float ambientLavafallStrength;

		// Token: 0x04003429 RID: 13353
		[Token(Token = "0x4003429")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6A8")]
		public static float ambientLavaX;

		// Token: 0x0400342A RID: 13354
		[Token(Token = "0x400342A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6AC")]
		public static float ambientLavaY;

		// Token: 0x0400342B RID: 13355
		[Token(Token = "0x400342B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6B0")]
		public static float ambientLavaStrength;

		// Token: 0x0400342C RID: 13356
		[Token(Token = "0x400342C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6B4")]
		public static int ambientCounter;

		// Token: 0x0400342D RID: 13357
		[Token(Token = "0x400342D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6B8")]
		private static bool _isWaterfallMusicPlaying;

		// Token: 0x0400342E RID: 13358
		[Token(Token = "0x400342E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6B9")]
		private static bool _isLavafallMusicPlaying;

		// Token: 0x0400342F RID: 13359
		[Token(Token = "0x400342F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6BC")]
		public static int ProjectileUpdateLoopIndex;

		// Token: 0x04003430 RID: 13360
		[Token(Token = "0x4003430")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C0")]
		public static GameTipsDisplay gameTips;

		// Token: 0x04003431 RID: 13361
		[Token(Token = "0x4003431")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C4")]
		public static int weatherVaneBobframe;

		// Token: 0x04003432 RID: 13362
		[Token(Token = "0x4003432")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C8")]
		private static DrKeyboard_Base _keyboard;

		// Token: 0x04003433 RID: 13363
		[Token(Token = "0x4003433")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6CC")]
		public static int _openedFrame;

		// Token: 0x04003434 RID: 13364
		[Token(Token = "0x4003434")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6D0")]
		private static int _maxCharaceters;

		// Token: 0x04003435 RID: 13365
		[Token(Token = "0x4003435")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6D4")]
		public static int selectedPlayer;

		// Token: 0x04003436 RID: 13366
		[Token(Token = "0x4003436")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6D8")]
		public static int selectedWorld;

		// Token: 0x04003437 RID: 13367
		[Token(Token = "0x4003437")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6DC")]
		public static string newWorldName;

		// Token: 0x04003438 RID: 13368
		[Token(Token = "0x4003438")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6E0")]
		private static int[] specX;

		// Token: 0x04003439 RID: 13369
		[Token(Token = "0x4003439")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6E4")]
		private static int[] specY;

		// Token: 0x0400343A RID: 13370
		[Token(Token = "0x400343A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6E8")]
		private static List<string> _requiredObjecsForCraftingText;

		// Token: 0x0400343B RID: 13371
		[Token(Token = "0x400343B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6EC")]
		private static bool hidePVPIcons;

		// Token: 0x0400343C RID: 13372
		[Token(Token = "0x400343C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6F0")]
		public static string hoverItemName;

		// Token: 0x0400343D RID: 13373
		[Token(Token = "0x400343D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6F4")]
		public static Color inventoryBack;

		// Token: 0x0400343E RID: 13374
		[Token(Token = "0x400343E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6F8")]
		public static bool mouseText;

		// Token: 0x0400343F RID: 13375
		[Token(Token = "0x400343F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6FC")]
		public static int mH;

		// Token: 0x04003440 RID: 13376
		[Token(Token = "0x4003440")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x700")]
		private static int lastMouseDrawItem;

		// Token: 0x04003441 RID: 13377
		[Token(Token = "0x4003441")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x704")]
		private static int lastMouseDrawXOffset;

		// Token: 0x04003442 RID: 13378
		[Token(Token = "0x4003442")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x708")]
		public static int focusColor;

		// Token: 0x04003443 RID: 13379
		[Token(Token = "0x4003443")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70C")]
		public static int colorDelay;

		// Token: 0x04003444 RID: 13380
		[Token(Token = "0x4003444")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x710")]
		public static int setKey;

		// Token: 0x04003445 RID: 13381
		[Token(Token = "0x4003445")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x714")]
		public static bool rememberPass;

		// Token: 0x04003446 RID: 13382
		[Token(Token = "0x4003446")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x715")]
		public static bool autoPass;

		// Token: 0x04003447 RID: 13383
		[Token(Token = "0x4003447")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x718")]
		public static int menuFocus;

		// Token: 0x04003448 RID: 13384
		[Token(Token = "0x4003448")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x71C")]
		public static bool blockMouse;

		// Token: 0x04003449 RID: 13385
		[Token(Token = "0x4003449")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x720")]
		public static float MenuXMovement;

		// Token: 0x0400344A RID: 13386
		[Token(Token = "0x400344A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x724")]
		public static float MapScale;

		// Token: 0x0400344B RID: 13387
		[Token(Token = "0x400344B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x728")]
		public static bool cancelWormHole;

		// Token: 0x0400344C RID: 13388
		[Token(Token = "0x400344C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x72C")]
		public static float lightning;

		// Token: 0x0400344D RID: 13389
		[Token(Token = "0x400344D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x730")]
		private static float lightningDecay;

		// Token: 0x0400344E RID: 13390
		[Token(Token = "0x400344E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x734")]
		private static float lightningSpeed;

		// Token: 0x0400344F RID: 13391
		[Token(Token = "0x400344F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x738")]
		private static int thunderDelay;

		// Token: 0x04003450 RID: 13392
		[Token(Token = "0x4003450")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x73C")]
		public static int thunderDistance;

		// Token: 0x04003451 RID: 13393
		[Token(Token = "0x4003451")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x740")]
		public static bool thunderSkipSound;

		// Token: 0x04003452 RID: 13394
		[Token(Token = "0x4003452")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x744")]
		private static float backgroundLayerTransitionSpeed;

		// Token: 0x04003453 RID: 13395
		[Token(Token = "0x4003453")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x748")]
		public static float atmo;

		// Token: 0x04003454 RID: 13396
		[Token(Token = "0x4003454")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74C")]
		private static float bgScale;

		// Token: 0x04003455 RID: 13397
		[Token(Token = "0x4003455")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x750")]
		private static int bgWidthScaled;

		// Token: 0x04003456 RID: 13398
		[Token(Token = "0x4003456")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x754")]
		public static Color ColorOfTheSkies;

		// Token: 0x04003457 RID: 13399
		[Token(Token = "0x4003457")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x758")]
		public static Color ColorOfSurfaceBackgroundsBase;

		// Token: 0x04003458 RID: 13400
		[Token(Token = "0x4003458")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x75C")]
		public static Color ColorOfSurfaceBackgroundsModified;

		// Token: 0x04003459 RID: 13401
		[Token(Token = "0x4003459")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x760")]
		private static string _oldNetplayStatusText;

		// Token: 0x0400345A RID: 13402
		[Token(Token = "0x400345A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x764")]
		private static TextSnippet[] _netplayStatusTextSnippets;

		// Token: 0x0400345B RID: 13403
		[Token(Token = "0x400345B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x768")]
		private static bool _canShowMeteorFall;

		// Token: 0x0400345C RID: 13404
		[Token(Token = "0x400345C")]
		private const string versionStringBecauseTheyreTheSame = "v1.4.5.8";

		// Token: 0x0400345D RID: 13405
		[Token(Token = "0x400345D")]
		public const int curRelease = 326;

		// Token: 0x0400345E RID: 13406
		[Token(Token = "0x400345E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x76C")]
		public static StringBuilder UIStringBuilder;

		// Token: 0x0400345F RID: 13407
		[Token(Token = "0x400345F")]
		public const string assemblyVersionNumber = "1.4.5.8";

		// Token: 0x04003460 RID: 13408
		[Token(Token = "0x4003460")]
		public const string copyrightText = "Copyright © 2026 Re-Logic";

		// Token: 0x04003461 RID: 13409
		[Token(Token = "0x4003461")]
		public const ulong WorldGeneratorVersion = 1400159338497UL;

		// Token: 0x04003462 RID: 13410
		[Token(Token = "0x4003462")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x770")]
		public static Dictionary<string, MinimapFrame> MinimapFrames;

		// Token: 0x04003463 RID: 13411
		[Token(Token = "0x4003463")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x774")]
		public static Dictionary<string, IPlayerResourcesDisplaySet> PlayerResourcesSets;

		// Token: 0x04003464 RID: 13412
		[Token(Token = "0x4003464")]
		public const string TerrariaSaveFolderPath = "Terraria";

		// Token: 0x04003465 RID: 13413
		[Token(Token = "0x4003465")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x778")]
		public static IAssetRepository Assets;

		// Token: 0x04003466 RID: 13414
		[Token(Token = "0x4003466")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _musicLoaded;

		// Token: 0x04003467 RID: 13415
		[Token(Token = "0x4003467")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		public bool _artLoaded;

		// Token: 0x04003468 RID: 13416
		[Token(Token = "0x4003468")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		private bool _begunMainAsyncLoad;

		// Token: 0x04003469 RID: 13417
		[Token(Token = "0x4003469")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x77C")]
		private static bool <CanUpdateGameplay>k__BackingField;

		// Token: 0x0400346A RID: 13418
		[Token(Token = "0x400346A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x77D")]
		private static bool GameAskedToQuit;

		// Token: 0x0400346B RID: 13419
		[Token(Token = "0x400346B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x780")]
		public static float ForcedMinimumZoom;

		// Token: 0x0400346C RID: 13420
		[Token(Token = "0x400346C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x784")]
		public static SpriteViewMatrix GameViewMatrix;

		// Token: 0x0400346D RID: 13421
		[Token(Token = "0x400346D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x788")]
		public static SpriteViewMatrix BackgroundViewMatrix;

		// Token: 0x0400346E RID: 13422
		[Token(Token = "0x400346E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78C")]
		private static Matrix _uiScaleMatrix;

		// Token: 0x0400346F RID: 13423
		[Token(Token = "0x400346F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7CC")]
		private static float _uiScaleWanted;

		// Token: 0x04003470 RID: 13424
		[Token(Token = "0x4003470")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7D0")]
		private static float _uiScaleUsed;

		// Token: 0x04003471 RID: 13425
		[Token(Token = "0x4003471")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7D4")]
		public static float GameZoomTarget;

		// Token: 0x04003472 RID: 13426
		[Token(Token = "0x4003472")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7D8")]
		public static bool InvisibleCursorForGamepad;

		// Token: 0x04003473 RID: 13427
		[Token(Token = "0x4003473")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7D9")]
		public static bool GamepadDisableCursorItemIconInner;

		// Token: 0x04003474 RID: 13428
		[Token(Token = "0x4003474")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7DA")]
		public static bool GamepadDisableInstructionsDisplay;

		// Token: 0x04003475 RID: 13429
		[Token(Token = "0x4003475")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7DC")]
		private static GameNotificationType _flashNotificationType;

		// Token: 0x04003476 RID: 13430
		[Token(Token = "0x4003476")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7E0")]
		public static string versionNumber;

		// Token: 0x04003477 RID: 13431
		[Token(Token = "0x4003477")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7E4")]
		public static string versionNumber2;

		// Token: 0x04003478 RID: 13432
		[Token(Token = "0x4003478")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7E8")]
		public static string AutogenSeedName;

		// Token: 0x04003479 RID: 13433
		[Token(Token = "0x4003479")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7EC")]
		public static bool tenthAnniversaryWorld;

		// Token: 0x0400347A RID: 13434
		[Token(Token = "0x400347A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7ED")]
		public static bool dontStarveWorld;

		// Token: 0x0400347B RID: 13435
		[Token(Token = "0x400347B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7EE")]
		public static bool notTheBeesWorld;

		// Token: 0x0400347C RID: 13436
		[Token(Token = "0x400347C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7EF")]
		public static bool remixWorld;

		// Token: 0x0400347D RID: 13437
		[Token(Token = "0x400347D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F0")]
		public static bool noTrapsWorld;

		// Token: 0x0400347E RID: 13438
		[Token(Token = "0x400347E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F1")]
		public static bool zenithWorld;

		// Token: 0x0400347F RID: 13439
		[Token(Token = "0x400347F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F2")]
		public static bool skyblockWorld;

		// Token: 0x04003480 RID: 13440
		[Token(Token = "0x4003480")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F3")]
		public static bool vampireSeed;

		// Token: 0x04003481 RID: 13441
		[Token(Token = "0x4003481")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F4")]
		public static bool infectedSeed;

		// Token: 0x04003482 RID: 13442
		[Token(Token = "0x4003482")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F5")]
		public static bool teamBasedSpawnsSeed;

		// Token: 0x04003483 RID: 13443
		[Token(Token = "0x4003483")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F6")]
		public static bool dualDungeonsSeed;

		// Token: 0x04003484 RID: 13444
		[Token(Token = "0x4003484")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F7")]
		public static bool moreLightningSeed;

		// Token: 0x04003485 RID: 13445
		[Token(Token = "0x4003485")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7F8")]
		public static bool noLightningSeed;

		// Token: 0x04003486 RID: 13446
		[Token(Token = "0x4003486")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7FC")]
		private static float? _gameModeDifficultyOverride;

		// Token: 0x04003487 RID: 13447
		[Token(Token = "0x4003487")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x804")]
		public static FavoritesFile CloudFavoritesData;

		// Token: 0x04003488 RID: 13448
		[Token(Token = "0x4003488")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x808")]
		public static UserInterface MenuUI;

		// Token: 0x04003489 RID: 13449
		[Token(Token = "0x4003489")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80C")]
		public static UserInterface InGameUI;

		// Token: 0x0400348A RID: 13450
		[Token(Token = "0x400348A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x810")]
		public static bool ContentLoaded;

		// Token: 0x0400348B RID: 13451
		[Token(Token = "0x400348B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x818")]
		private static ulong <UnpausedUpdateSeed>k__BackingField;

		// Token: 0x0400348C RID: 13452
		[Token(Token = "0x400348C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x820")]
		public static Asset<Effect> ScreenShaderRef;

		// Token: 0x0400348D RID: 13453
		[Token(Token = "0x400348D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x824")]
		public static Asset<Effect> PixelShaderRef;

		// Token: 0x0400348E RID: 13454
		[Token(Token = "0x400348E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x828")]
		public static Asset<Effect> TileShaderRef;

		// Token: 0x0400348F RID: 13455
		[Token(Token = "0x400348F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x82C")]
		public static List<IEnumerator> DelayedProcesses;

		// Token: 0x04003490 RID: 13456
		[Token(Token = "0x4003490")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x830")]
		public static List<IEnumerator> DelayedProcessesInGame;

		// Token: 0x04003491 RID: 13457
		[Token(Token = "0x4003491")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x834")]
		public static bool dedServFPS;

		// Token: 0x04003492 RID: 13458
		[Token(Token = "0x4003492")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x838")]
		public static int dedServCount1;

		// Token: 0x04003493 RID: 13459
		[Token(Token = "0x4003493")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x83C")]
		public static int dedServCount2;

		// Token: 0x04003494 RID: 13460
		[Token(Token = "0x4003494")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x840")]
		public static readonly int offLimitBorderTiles;

		// Token: 0x04003495 RID: 13461
		[Token(Token = "0x4003495")]
		public const int maxMusic = 105;

		// Token: 0x04003496 RID: 13462
		[Token(Token = "0x4003496")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x844")]
		public static readonly int maxBackgrounds;

		// Token: 0x04003497 RID: 13463
		[Token(Token = "0x4003497")]
		public const int MaxShopIDs = 100;

		// Token: 0x04003498 RID: 13464
		[Token(Token = "0x4003498")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x848")]
		public static Vector2[] OffsetsNPCOffhand;

		// Token: 0x04003499 RID: 13465
		[Token(Token = "0x4003499")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x84C")]
		public static Vector2[] OffsetsPlayerOffhand;

		// Token: 0x0400349A RID: 13466
		[Token(Token = "0x400349A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x850")]
		public static Vector2[] OffsetsPlayerOnhand;

		// Token: 0x0400349B RID: 13467
		[Token(Token = "0x400349B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x854")]
		public static Vector2[] OffsetsPlayerHeadgear;

		// Token: 0x0400349C RID: 13468
		[Token(Token = "0x400349C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x858")]
		public static bool noWindowBorder;

		// Token: 0x0400349D RID: 13469
		[Token(Token = "0x400349D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x85C")]
		public static RasterizerState Rasterizer;

		// Token: 0x0400349E RID: 13470
		[Token(Token = "0x400349E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string _cachedTitle;

		// Token: 0x0400349F RID: 13471
		[Token(Token = "0x400349F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x860")]
		public static bool skipMenu;

		// Token: 0x040034A0 RID: 13472
		[Token(Token = "0x40034A0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x861")]
		public static bool verboseNetplay;

		// Token: 0x040034A1 RID: 13473
		[Token(Token = "0x40034A1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x862")]
		public static bool stopTimeOuts;

		// Token: 0x040034A2 RID: 13474
		[Token(Token = "0x40034A2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x863")]
		public static bool showSpam;

		// Token: 0x040034A3 RID: 13475
		[Token(Token = "0x40034A3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x864")]
		public static bool runningCollectorsEdition;

		// Token: 0x040034A4 RID: 13476
		[Token(Token = "0x40034A4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x865")]
		public static bool shouldDrawNetDiagnosticsUI;

		// Token: 0x040034A5 RID: 13477
		[Token(Token = "0x40034A5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x868")]
		private static INetDiagnosticsUI _activeNetDiagnosticsUI;

		// Token: 0x040034A6 RID: 13478
		[Token(Token = "0x40034A6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x86C")]
		public static IMultiplayerClosePlayersOverlay ActiveClosePlayersTeamOverlay;

		// Token: 0x040034A7 RID: 13479
		[Token(Token = "0x40034A7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool gammaTest;

		// Token: 0x040034A8 RID: 13480
		[Token(Token = "0x40034A8")]
		private const bool USE_ASYNC_LOAD = true;

		// Token: 0x040034A9 RID: 13481
		[Token(Token = "0x40034A9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x870")]
		public static bool _isAsyncLoadComplete;

		// Token: 0x040034AA RID: 13482
		[Token(Token = "0x40034AA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x871")]
		public static bool showSplash;

		// Token: 0x040034AB RID: 13483
		[Token(Token = "0x40034AB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x872")]
		public static bool ignoreErrors;

		// Token: 0x040034AC RID: 13484
		[Token(Token = "0x40034AC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x874")]
		public static string defaultIP;

		// Token: 0x040034AD RID: 13485
		[Token(Token = "0x40034AD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x878")]
		public static int defaultPort;

		// Token: 0x040034AE RID: 13486
		[Token(Token = "0x40034AE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x87C")]
		public static bool[] projHostile;

		// Token: 0x040034AF RID: 13487
		[Token(Token = "0x40034AF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x880")]
		public static bool[] projHook;

		// Token: 0x040034B0 RID: 13488
		[Token(Token = "0x40034B0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x884")]
		public static bool[] pvpBuff;

		// Token: 0x040034B1 RID: 13489
		[Token(Token = "0x40034B1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x888")]
		public static bool[] persistentBuff;

		// Token: 0x040034B2 RID: 13490
		[Token(Token = "0x40034B2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88C")]
		public static bool[] vanityPet;

		// Token: 0x040034B3 RID: 13491
		[Token(Token = "0x40034B3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x890")]
		public static bool[] lightPet;

		// Token: 0x040034B4 RID: 13492
		[Token(Token = "0x40034B4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x894")]
		public static bool[] meleeBuff;

		// Token: 0x040034B5 RID: 13493
		[Token(Token = "0x40034B5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x898")]
		public static bool[] debuff;

		// Token: 0x040034B6 RID: 13494
		[Token(Token = "0x40034B6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x89C")]
		public static bool[] buffNoSave;

		// Token: 0x040034B7 RID: 13495
		[Token(Token = "0x40034B7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A0")]
		public static bool[] buffNoTimeDisplay;

		// Token: 0x040034B8 RID: 13496
		[Token(Token = "0x40034B8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A4")]
		public static bool[] buffDoubleApply;

		// Token: 0x040034B9 RID: 13497
		[Token(Token = "0x40034B9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RenderTarget2D backWaterTarget;

		// Token: 0x040034BA RID: 13498
		[Token(Token = "0x40034BA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A8")]
		public static RenderTarget2D waterTarget;

		// Token: 0x040034BB RID: 13499
		[Token(Token = "0x40034BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RenderTarget2D tileTarget;

		// Token: 0x040034BC RID: 13500
		[Token(Token = "0x40034BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RenderTarget2D blackTarget;

		// Token: 0x040034BD RID: 13501
		[Token(Token = "0x40034BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private RenderTarget2D tile2Target;

		// Token: 0x040034BE RID: 13502
		[Token(Token = "0x40034BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RenderTarget2D wallTarget;

		// Token: 0x040034BF RID: 13503
		[Token(Token = "0x40034BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private RenderTarget2D backgroundTarget;

		// Token: 0x040034C0 RID: 13504
		[Token(Token = "0x40034C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RenderTarget2D backgroundTargetSwap;

		// Token: 0x040034C1 RID: 13505
		[Token(Token = "0x40034C1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool backgroundTargetSwapPending;

		// Token: 0x040034C2 RID: 13506
		[Token(Token = "0x40034C2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8AC")]
		public static RenderTarget2D skyTarget;

		// Token: 0x040034C3 RID: 13507
		[Token(Token = "0x40034C3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8B0")]
		public static RenderTarget2D screenTarget;

		// Token: 0x040034C4 RID: 13508
		[Token(Token = "0x40034C4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8B4")]
		public static RenderTarget2D screenTargetSwap;

		// Token: 0x040034C5 RID: 13509
		[Token(Token = "0x40034C5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8B8")]
		public static RenderTarget2D objectsTarget_Small;

		// Token: 0x040034C6 RID: 13510
		[Token(Token = "0x40034C6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RenderTarget2D[,] mapTarget;

		// Token: 0x040034C7 RID: 13511
		[Token(Token = "0x40034C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private RenderTarget2D mapSectionTexture;

		// Token: 0x040034C8 RID: 13512
		[Token(Token = "0x40034C8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8BC")]
		public static bool[,] mapWasContentLost;

		// Token: 0x040034C9 RID: 13513
		[Token(Token = "0x40034C9")]
		public const int numInfoIcons = 13;

		// Token: 0x040034CA RID: 13514
		[Token(Token = "0x40034CA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C0")]
		public static Color OurFavoriteColor;

		// Token: 0x040034CC RID: 13516
		[Token(Token = "0x40034CC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C8")]
		private static bool IsEnginePreloaded;

		// Token: 0x040034CF RID: 13519
		[Token(Token = "0x40034CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8D4")]
		private static bool IsEngineLoaded;

		// Token: 0x040034D7 RID: 13527
		[Token(Token = "0x40034D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private double bgParallax;

		// Token: 0x040034D8 RID: 13528
		[Token(Token = "0x40034D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int bgStartX;

		// Token: 0x040034D9 RID: 13529
		[Token(Token = "0x40034D9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int bgLoops;

		// Token: 0x040034DA RID: 13530
		[Token(Token = "0x40034DA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int bgStartY;

		// Token: 0x040034DB RID: 13531
		[Token(Token = "0x40034DB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private int bgLoopsY;

		// Token: 0x040034DC RID: 13532
		[Token(Token = "0x40034DC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float bgTopY;

		// Token: 0x040034DD RID: 13533
		[Token(Token = "0x40034DD")]
		private const int MF_BYPOSITION = 1024;

		// Token: 0x040034DE RID: 13534
		[Token(Token = "0x40034DE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8F4")]
		public static GraphicsDeviceManager graphics;

		// Token: 0x040034DF RID: 13535
		[Token(Token = "0x40034DF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8F8")]
		public static SpriteBatch spriteBatch;

		// Token: 0x040034E0 RID: 13536
		[Token(Token = "0x40034E0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8FC")]
		public static SpriteBatch_Cloud cloudBatch;

		// Token: 0x040034E1 RID: 13537
		[Token(Token = "0x40034E1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x900")]
		public static SpriteBatch_NatureLit natureLitBatch;

		// Token: 0x040034E2 RID: 13538
		[Token(Token = "0x40034E2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x904")]
		public static SpriteBatch spriteBatch2;

		// Token: 0x040034E3 RID: 13539
		[Token(Token = "0x40034E3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x908")]
		public static TileBatch tileBatch;

		// Token: 0x040034E4 RID: 13540
		[Token(Token = "0x40034E4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90C")]
		public static BasicDebugDrawer DebugDrawer;

		// Token: 0x040034E5 RID: 13541
		[Token(Token = "0x40034E5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x910")]
		public static SamplerState SamplerStateForCursor;

		// Token: 0x040034E6 RID: 13542
		[Token(Token = "0x40034E6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x914")]
		public static GenerationProgress AutogenProgress;

		// Token: 0x040034E7 RID: 13543
		[Token(Token = "0x40034E7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x918")]
		private static Process tServer;

		// Token: 0x040034E8 RID: 13544
		[Token(Token = "0x40034E8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x91C")]
		public static Color mcColor;

		// Token: 0x040034E9 RID: 13545
		[Token(Token = "0x40034E9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x920")]
		public static Color hcColor;

		// Token: 0x040034EA RID: 13546
		[Token(Token = "0x40034EA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x924")]
		public static Color creativeModeColor;

		// Token: 0x040034EB RID: 13547
		[Token(Token = "0x40034EB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x928")]
		public static Color legendaryModeColor;

		// Token: 0x040034EC RID: 13548
		[Token(Token = "0x40034EC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x92C")]
		public static Color highVersionColor;

		// Token: 0x040034ED RID: 13549
		[Token(Token = "0x40034ED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x930")]
		public static Color errorColor;

		// Token: 0x040034EE RID: 13550
		[Token(Token = "0x40034EE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x934")]
		public static bool afterPartyOfDoom;

		// Token: 0x040034EF RID: 13551
		[Token(Token = "0x40034EF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float chestLootScale;

		// Token: 0x040034F0 RID: 13552
		[Token(Token = "0x40034F0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool chestLootHover;

		// Token: 0x040034F1 RID: 13553
		[Token(Token = "0x40034F1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float chestStackScale;

		// Token: 0x040034F2 RID: 13554
		[Token(Token = "0x40034F2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool chestStackHover;

		// Token: 0x040034F3 RID: 13555
		[Token(Token = "0x40034F3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float chestDepositScale;

		// Token: 0x040034F4 RID: 13556
		[Token(Token = "0x40034F4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public bool chestDepositHover;

		// Token: 0x040034F5 RID: 13557
		[Token(Token = "0x40034F5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float chestRenameScale;

		// Token: 0x040034F6 RID: 13558
		[Token(Token = "0x40034F6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool chestRenameHover;

		// Token: 0x040034F7 RID: 13559
		[Token(Token = "0x40034F7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float chestCancelScale;

		// Token: 0x040034F8 RID: 13560
		[Token(Token = "0x40034F8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool chestCancelHover;

		// Token: 0x040034F9 RID: 13561
		[Token(Token = "0x40034F9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public int DiscoStyle;

		// Token: 0x040034FA RID: 13562
		[Token(Token = "0x40034FA")]
		public const int sectionWidth = 200;

		// Token: 0x040034FB RID: 13563
		[Token(Token = "0x40034FB")]
		public const int sectionHeight = 150;

		// Token: 0x040034FC RID: 13564
		[Token(Token = "0x40034FC")]
		public const int maxDust = 6000;

		// Token: 0x040034FD RID: 13565
		[Token(Token = "0x40034FD")]
		public const int maxCombatText = 100;

		// Token: 0x040034FE RID: 13566
		[Token(Token = "0x40034FE")]
		public const int maxPlayers = 255;

		// Token: 0x040034FF RID: 13567
		[Token(Token = "0x40034FF")]
		public const int maxChests = 8000;

		// Token: 0x04003500 RID: 13568
		[Token(Token = "0x4003500")]
		public const int maxItems = 400;

		// Token: 0x04003501 RID: 13569
		[Token(Token = "0x4003501")]
		public const int maxProjectiles = 1000;

		// Token: 0x04003502 RID: 13570
		[Token(Token = "0x4003502")]
		public const int maxNPCs = 200;

		// Token: 0x04003503 RID: 13571
		[Token(Token = "0x4003503")]
		private const double slimeRainMaxTime = 54000.0;

		// Token: 0x04003504 RID: 13572
		[Token(Token = "0x4003504")]
		private const double slimeRainMinTime = 32400.0;

		// Token: 0x04003505 RID: 13573
		[Token(Token = "0x4003505")]
		private const double slimeRainMaxDelay = 604800.0;

		// Token: 0x04003506 RID: 13574
		[Token(Token = "0x4003506")]
		private const double slimeRainMinDelay = 302400.0;

		// Token: 0x04003507 RID: 13575
		[Token(Token = "0x4003507")]
		private const double LeinforsBalanceRequestForSlimeRainChance = 1.0416666666666667;

		// Token: 0x04003508 RID: 13576
		[Token(Token = "0x4003508")]
		private const double slimeRainChance = 450000.00000000006;

		// Token: 0x04003509 RID: 13577
		[Token(Token = "0x4003509")]
		public const int maxGore = 600;

		// Token: 0x0400350A RID: 13578
		[Token(Token = "0x400350A")]
		public const int InventoryItemSlotsStart = 0;

		// Token: 0x0400350B RID: 13579
		[Token(Token = "0x400350B")]
		public const int InventoryItemSlotsCount = 50;

		// Token: 0x0400350C RID: 13580
		[Token(Token = "0x400350C")]
		public const int InventoryCoinSlotsStart = 50;

		// Token: 0x0400350D RID: 13581
		[Token(Token = "0x400350D")]
		public const int InventoryCoinSlotsCount = 4;

		// Token: 0x0400350E RID: 13582
		[Token(Token = "0x400350E")]
		public const int InventoryAmmoSlotsStart = 54;

		// Token: 0x0400350F RID: 13583
		[Token(Token = "0x400350F")]
		public const int InventoryAmmoSlotsCount = 4;

		// Token: 0x04003510 RID: 13584
		[Token(Token = "0x4003510")]
		public const int InventorySlotsTotal = 58;

		// Token: 0x04003511 RID: 13585
		[Token(Token = "0x4003511")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public int invBottom;

		// Token: 0x04003512 RID: 13586
		[Token(Token = "0x4003512")]
		public const int maxLiquidTypes = 15;

		// Token: 0x04003513 RID: 13587
		[Token(Token = "0x4003513")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x935")]
		public static bool useBackupFiles;

		// Token: 0x04003514 RID: 13588
		[Token(Token = "0x4003514")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x936")]
		public static bool validateSaves;

		// Token: 0x04003515 RID: 13589
		[Token(Token = "0x4003515")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x938")]
		public static Color[] teamColor;

		// Token: 0x04003516 RID: 13590
		[Token(Token = "0x4003516")]
		public const double dayLength = 54000.0;

		// Token: 0x04003517 RID: 13591
		[Token(Token = "0x4003517")]
		public const double nightLength = 32400.0;

		// Token: 0x04003518 RID: 13592
		[Token(Token = "0x4003518")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x93C")]
		public static bool autoGen;

		// Token: 0x04003519 RID: 13593
		[Token(Token = "0x4003519")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x940")]
		public static int[] projFrames;

		// Token: 0x0400351A RID: 13594
		[Token(Token = "0x400351A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x944")]
		public static bool[] projPet;

		// Token: 0x0400351B RID: 13595
		[Token(Token = "0x400351B")]
		public const int maxStars = 400;

		// Token: 0x0400351C RID: 13596
		[Token(Token = "0x400351C")]
		public const int maxStarTypes = 4;

		// Token: 0x0400351D RID: 13597
		[Token(Token = "0x400351D")]
		public const int maxClouds = 200;

		// Token: 0x0400351E RID: 13598
		[Token(Token = "0x400351E")]
		public static UnifiedRandom rand;

		// Token: 0x0400351F RID: 13599
		[Token(Token = "0x400351F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x948")]
		public static XORShiftRand QuickRand;

		// Token: 0x04003520 RID: 13600
		[Token(Token = "0x4003520")]
		public const int maxMoons = 9;

		// Token: 0x04003521 RID: 13601
		[Token(Token = "0x4003521")]
		public const int numTileColors = 32;

		// Token: 0x04003522 RID: 13602
		[Token(Token = "0x4003522")]
		public const int numTreeStyles = 32;

		// Token: 0x04003523 RID: 13603
		[Token(Token = "0x4003523")]
		public const int numberOfHairstyles = 228;

		// Token: 0x04003524 RID: 13604
		[Token(Token = "0x4003524")]
		public const int maxHairStyles = 228;

		// Token: 0x04003525 RID: 13605
		[Token(Token = "0x4003525")]
		public const int maxCharSelectHair = 51;

		// Token: 0x04003526 RID: 13606
		[Token(Token = "0x4003526")]
		public const int maxHairOfStylistDefault = 123;

		// Token: 0x04003527 RID: 13607
		[Token(Token = "0x4003527")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x94C")]
		public static IAudioSystem audioSystem;

		// Token: 0x04003528 RID: 13608
		[Token(Token = "0x4003528")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x950")]
		public static bool[] musicNoCrossFade;

		// Token: 0x04003529 RID: 13609
		[Token(Token = "0x4003529")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x954")]
		public static ServerMode MenuServerMode;

		// Token: 0x0400352A RID: 13610
		[Token(Token = "0x400352A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x958")]
		public static bool[] tileLighted;

		// Token: 0x0400352B RID: 13611
		[Token(Token = "0x400352B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x95C")]
		public static bool[] tileMergeDirt;

		// Token: 0x0400352C RID: 13612
		[Token(Token = "0x400352C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x960")]
		public static bool[] tileCut;

		// Token: 0x0400352D RID: 13613
		[Token(Token = "0x400352D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x964")]
		public static bool[] tileAlch;

		// Token: 0x0400352E RID: 13614
		[Token(Token = "0x400352E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x968")]
		public static int[] tileShine;

		// Token: 0x0400352F RID: 13615
		[Token(Token = "0x400352F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x96C")]
		public static bool[] tileShine2;

		// Token: 0x04003530 RID: 13616
		[Token(Token = "0x4003530")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x970")]
		public static bool[] wallHouse;

		// Token: 0x04003531 RID: 13617
		[Token(Token = "0x4003531")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x974")]
		public static bool[] wallDungeon;

		// Token: 0x04003532 RID: 13618
		[Token(Token = "0x4003532")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x978")]
		public static bool[] wallLight;

		// Token: 0x04003533 RID: 13619
		[Token(Token = "0x4003533")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x97C")]
		public static bool[] wallLighted;

		// Token: 0x04003534 RID: 13620
		[Token(Token = "0x4003534")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x980")]
		public static int[] wallBlend;

		// Token: 0x04003535 RID: 13621
		[Token(Token = "0x4003535")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x984")]
		public static bool[] tileStone;

		// Token: 0x04003536 RID: 13622
		[Token(Token = "0x4003536")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x988")]
		public static bool[] tileAxe;

		// Token: 0x04003537 RID: 13623
		[Token(Token = "0x4003537")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98C")]
		public static bool[] tileHammer;

		// Token: 0x04003538 RID: 13624
		[Token(Token = "0x4003538")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x990")]
		public static bool[] tileWaterDeath;

		// Token: 0x04003539 RID: 13625
		[Token(Token = "0x4003539")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x994")]
		public static bool[] tileLavaDeath;

		// Token: 0x0400353A RID: 13626
		[Token(Token = "0x400353A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x998")]
		public static bool[] tileTable;

		// Token: 0x0400353B RID: 13627
		[Token(Token = "0x400353B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x99C")]
		public static bool[] tileBlockLight;

		// Token: 0x0400353C RID: 13628
		[Token(Token = "0x400353C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9A0")]
		public static bool[] tileNoSunLight;

		// Token: 0x0400353D RID: 13629
		[Token(Token = "0x400353D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9A4")]
		public static bool[] tileDungeon;

		// Token: 0x0400353E RID: 13630
		[Token(Token = "0x400353E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9A8")]
		public static bool[] tileSpelunker;

		// Token: 0x0400353F RID: 13631
		[Token(Token = "0x400353F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9AC")]
		public static bool[] tileSolidTop;

		// Token: 0x04003540 RID: 13632
		[Token(Token = "0x4003540")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9B0")]
		public static bool[] tileSolid;

		// Token: 0x04003541 RID: 13633
		[Token(Token = "0x4003541")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9B4")]
		public static bool[] tileBouncy;

		// Token: 0x04003542 RID: 13634
		[Token(Token = "0x4003542")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9B8")]
		public static short[] tileOreFinderPriority;

		// Token: 0x04003543 RID: 13635
		[Token(Token = "0x4003543")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9BC")]
		public static byte[] tileLargeFrames;

		// Token: 0x04003544 RID: 13636
		[Token(Token = "0x4003544")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C0")]
		public static byte[] wallLargeFrames;

		// Token: 0x04003545 RID: 13637
		[Token(Token = "0x4003545")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C4")]
		public static bool[] tileRope;

		// Token: 0x04003546 RID: 13638
		[Token(Token = "0x4003546")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C8")]
		public static bool[] tileBrick;

		// Token: 0x04003547 RID: 13639
		[Token(Token = "0x4003547")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9CC")]
		public static bool[] tileMoss;

		// Token: 0x04003548 RID: 13640
		[Token(Token = "0x4003548")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9D0")]
		public static bool[] tileNoAttach;

		// Token: 0x04003549 RID: 13641
		[Token(Token = "0x4003549")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9D4")]
		public static bool[] tileNoFail;

		// Token: 0x0400354A RID: 13642
		[Token(Token = "0x400354A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9D8")]
		public static bool[] tileCracked;

		// Token: 0x0400354B RID: 13643
		[Token(Token = "0x400354B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9DC")]
		public static bool[] tileObsidianKill;

		// Token: 0x0400354C RID: 13644
		[Token(Token = "0x400354C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9E0")]
		public static bool[] tileFrameImportant;

		// Token: 0x0400354D RID: 13645
		[Token(Token = "0x400354D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9E4")]
		public static bool[] tilePile;

		// Token: 0x0400354E RID: 13646
		[Token(Token = "0x400354E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9E8")]
		public static bool[] tileBlendAll;

		// Token: 0x0400354F RID: 13647
		[Token(Token = "0x400354F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9EC")]
		public static short[] tileGlowMask;

		// Token: 0x04003550 RID: 13648
		[Token(Token = "0x4003550")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9F0")]
		public static bool[] tileContainer;

		// Token: 0x04003551 RID: 13649
		[Token(Token = "0x4003551")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9F4")]
		public static bool[] tileSign;

		// Token: 0x04003552 RID: 13650
		[Token(Token = "0x4003552")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9F8")]
		public static bool[][] tileMerge;

		// Token: 0x04003553 RID: 13651
		[Token(Token = "0x4003553")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9FC")]
		public static int cageFrames;

		// Token: 0x04003554 RID: 13652
		[Token(Token = "0x4003554")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA00")]
		public static bool critterCage;

		// Token: 0x04003555 RID: 13653
		[Token(Token = "0x4003555")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA04")]
		public static int[] bunnyCageFrame;

		// Token: 0x04003556 RID: 13654
		[Token(Token = "0x4003556")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA08")]
		public static int[] bunnyCageFrameCounter;

		// Token: 0x04003557 RID: 13655
		[Token(Token = "0x4003557")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0C")]
		public static int[] squirrelCageFrame;

		// Token: 0x04003558 RID: 13656
		[Token(Token = "0x4003558")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA10")]
		public static int[] squirrelCageFrameCounter;

		// Token: 0x04003559 RID: 13657
		[Token(Token = "0x4003559")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA14")]
		public static int[] squirrelCageFrameOrange;

		// Token: 0x0400355A RID: 13658
		[Token(Token = "0x400355A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA18")]
		public static int[] squirrelCageFrameCounterOrange;

		// Token: 0x0400355B RID: 13659
		[Token(Token = "0x400355B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA1C")]
		public static int[] mallardCageFrame;

		// Token: 0x0400355C RID: 13660
		[Token(Token = "0x400355C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA20")]
		public static int[] mallardCageFrameCounter;

		// Token: 0x0400355D RID: 13661
		[Token(Token = "0x400355D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA24")]
		public static int[] duckCageFrame;

		// Token: 0x0400355E RID: 13662
		[Token(Token = "0x400355E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA28")]
		public static int[] duckCageFrameCounter;

		// Token: 0x0400355F RID: 13663
		[Token(Token = "0x400355F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA2C")]
		public static int[] grebeCageFrame;

		// Token: 0x04003560 RID: 13664
		[Token(Token = "0x4003560")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA30")]
		public static int[] grebeCageFrameCounter;

		// Token: 0x04003561 RID: 13665
		[Token(Token = "0x4003561")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA34")]
		public static int[] seagullCageFrame;

		// Token: 0x04003562 RID: 13666
		[Token(Token = "0x4003562")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA38")]
		public static int[] seagullCageFrameCounter;

		// Token: 0x04003563 RID: 13667
		[Token(Token = "0x4003563")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA3C")]
		public static int[] birdCageFrame;

		// Token: 0x04003564 RID: 13668
		[Token(Token = "0x4003564")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA40")]
		public static int[] birdCageFrameCounter;

		// Token: 0x04003565 RID: 13669
		[Token(Token = "0x4003565")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA44")]
		public static int[] redBirdCageFrame;

		// Token: 0x04003566 RID: 13670
		[Token(Token = "0x4003566")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA48")]
		public static int[] redBirdCageFrameCounter;

		// Token: 0x04003567 RID: 13671
		[Token(Token = "0x4003567")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA4C")]
		public static int[] blueBirdCageFrame;

		// Token: 0x04003568 RID: 13672
		[Token(Token = "0x4003568")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA50")]
		public static int[] blueBirdCageFrameCounter;

		// Token: 0x04003569 RID: 13673
		[Token(Token = "0x4003569")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA54")]
		public static int[] macawCageFrame;

		// Token: 0x0400356A RID: 13674
		[Token(Token = "0x400356A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA58")]
		public static int[] macawCageFrameCounter;

		// Token: 0x0400356B RID: 13675
		[Token(Token = "0x400356B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA5C")]
		public static byte[,] butterflyCageMode;

		// Token: 0x0400356C RID: 13676
		[Token(Token = "0x400356C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA60")]
		public static int[,] butterflyCageFrame;

		// Token: 0x0400356D RID: 13677
		[Token(Token = "0x400356D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA64")]
		public static int[,] butterflyCageFrameCounter;

		// Token: 0x0400356E RID: 13678
		[Token(Token = "0x400356E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA68")]
		public static int[,] dragonflyJarFrameCounter;

		// Token: 0x0400356F RID: 13679
		[Token(Token = "0x400356F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA6C")]
		public static int[,] dragonflyJarFrame;

		// Token: 0x04003570 RID: 13680
		[Token(Token = "0x4003570")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA70")]
		public static int[,] scorpionCageFrame;

		// Token: 0x04003571 RID: 13681
		[Token(Token = "0x4003571")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA74")]
		public static int[,] scorpionCageFrameCounter;

		// Token: 0x04003572 RID: 13682
		[Token(Token = "0x4003572")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA78")]
		public static int[] snailCageFrame;

		// Token: 0x04003573 RID: 13683
		[Token(Token = "0x4003573")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA7C")]
		public static int[] snailCageFrameCounter;

		// Token: 0x04003574 RID: 13684
		[Token(Token = "0x4003574")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA80")]
		public static int[] snail2CageFrame;

		// Token: 0x04003575 RID: 13685
		[Token(Token = "0x4003575")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA84")]
		public static int[] snail2CageFrameCounter;

		// Token: 0x04003576 RID: 13686
		[Token(Token = "0x4003576")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA88")]
		public static byte[] fishBowlFrameMode;

		// Token: 0x04003577 RID: 13687
		[Token(Token = "0x4003577")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8C")]
		public static int[] fishBowlFrame;

		// Token: 0x04003578 RID: 13688
		[Token(Token = "0x4003578")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA90")]
		public static int[] fishBowlFrameCounter;

		// Token: 0x04003579 RID: 13689
		[Token(Token = "0x4003579")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA94")]
		public static int[] lavaFishBowlFrame;

		// Token: 0x0400357A RID: 13690
		[Token(Token = "0x400357A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA98")]
		public static int[] lavaFishBowlFrameCounter;

		// Token: 0x0400357B RID: 13691
		[Token(Token = "0x400357B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA9C")]
		public static int[] frogCageFrame;

		// Token: 0x0400357C RID: 13692
		[Token(Token = "0x400357C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAA0")]
		public static int[] frogCageFrameCounter;

		// Token: 0x0400357D RID: 13693
		[Token(Token = "0x400357D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAA4")]
		public static int[] mouseCageFrame;

		// Token: 0x0400357E RID: 13694
		[Token(Token = "0x400357E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAA8")]
		public static int[] mouseCageFrameCounter;

		// Token: 0x0400357F RID: 13695
		[Token(Token = "0x400357F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAAC")]
		public static int[] turtleCageFrame;

		// Token: 0x04003580 RID: 13696
		[Token(Token = "0x4003580")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAB0")]
		public static int[] turtleCageFrameCounter;

		// Token: 0x04003581 RID: 13697
		[Token(Token = "0x4003581")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAB4")]
		public static int[] fairyJarFrame;

		// Token: 0x04003582 RID: 13698
		[Token(Token = "0x4003582")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAB8")]
		public static int[] fairyJarFrameCounter;

		// Token: 0x04003583 RID: 13699
		[Token(Token = "0x4003583")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xABC")]
		public static byte[,] jellyfishCageMode;

		// Token: 0x04003584 RID: 13700
		[Token(Token = "0x4003584")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC0")]
		public static int[,] jellyfishCageFrame;

		// Token: 0x04003585 RID: 13701
		[Token(Token = "0x4003585")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC4")]
		public static int[,] jellyfishCageFrameCounter;

		// Token: 0x04003586 RID: 13702
		[Token(Token = "0x4003586")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC8")]
		public static int[] wormCageFrame;

		// Token: 0x04003587 RID: 13703
		[Token(Token = "0x4003587")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xACC")]
		public static int[] wormCageFrameCounter;

		// Token: 0x04003588 RID: 13704
		[Token(Token = "0x4003588")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAD0")]
		public static int[] maggotCageFrame;

		// Token: 0x04003589 RID: 13705
		[Token(Token = "0x4003589")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAD4")]
		public static int[] maggotCageFrameCounter;

		// Token: 0x0400358A RID: 13706
		[Token(Token = "0x400358A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAD8")]
		public static int[] ratCageFrame;

		// Token: 0x0400358B RID: 13707
		[Token(Token = "0x400358B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xADC")]
		public static int[] ratCageFrameCounter;

		// Token: 0x0400358C RID: 13708
		[Token(Token = "0x400358C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAE0")]
		public static int[] ladybugCageFrame;

		// Token: 0x0400358D RID: 13709
		[Token(Token = "0x400358D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAE4")]
		public static int[] ladybugCageFrameCounter;

		// Token: 0x0400358E RID: 13710
		[Token(Token = "0x400358E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAE8")]
		public static int[] penguinCageFrame;

		// Token: 0x0400358F RID: 13711
		[Token(Token = "0x400358F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAEC")]
		public static int[] penguinCageFrameCounter;

		// Token: 0x04003590 RID: 13712
		[Token(Token = "0x4003590")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAF0")]
		public static int[] waterStriderCageFrame;

		// Token: 0x04003591 RID: 13713
		[Token(Token = "0x4003591")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAF4")]
		public static int[] waterStriderCageFrameCounter;

		// Token: 0x04003592 RID: 13714
		[Token(Token = "0x4003592")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAF8")]
		public static int[] seahorseCageFrame;

		// Token: 0x04003593 RID: 13715
		[Token(Token = "0x4003593")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAFC")]
		public static int[] seahorseCageFrameCounter;

		// Token: 0x04003594 RID: 13716
		[Token(Token = "0x4003594")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB00")]
		public static int[,] slugCageFrame;

		// Token: 0x04003595 RID: 13717
		[Token(Token = "0x4003595")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB04")]
		public static int[,] slugCageFrameCounter;

		// Token: 0x04003596 RID: 13718
		[Token(Token = "0x4003596")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB08")]
		public static int[] owlCageFrame;

		// Token: 0x04003597 RID: 13719
		[Token(Token = "0x4003597")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0C")]
		public static int[] owlCageFrameCounter;

		// Token: 0x04003598 RID: 13720
		[Token(Token = "0x4003598")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB10")]
		public static int[] grasshopperCageFrame;

		// Token: 0x04003599 RID: 13721
		[Token(Token = "0x4003599")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB14")]
		public static int[] grasshopperCageFrameCounter;

		// Token: 0x0400359A RID: 13722
		[Token(Token = "0x400359A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB18")]
		public static int[] pufferfishCageFrame;

		// Token: 0x0400359B RID: 13723
		[Token(Token = "0x400359B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB1C")]
		public static int[] pufferfishCageFrameCounter;

		// Token: 0x0400359C RID: 13724
		[Token(Token = "0x400359C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB20")]
		public static bool[] tileSand;

		// Token: 0x0400359D RID: 13725
		[Token(Token = "0x400359D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB24")]
		public static bool[] tileFlame;

		// Token: 0x0400359E RID: 13726
		[Token(Token = "0x400359E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB28")]
		public static bool[] npcCatchable;

		// Token: 0x0400359F RID: 13727
		[Token(Token = "0x400359F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB2C")]
		public static int[] tileFrame;

		// Token: 0x040035A0 RID: 13728
		[Token(Token = "0x40035A0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB30")]
		public static int[] tileFrameCounter;

		// Token: 0x040035A1 RID: 13729
		[Token(Token = "0x40035A1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB34")]
		public static byte[] wallFrame;

		// Token: 0x040035A2 RID: 13730
		[Token(Token = "0x40035A2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB38")]
		public static byte[] wallFrameCounter;

		// Token: 0x040035A3 RID: 13731
		[Token(Token = "0x40035A3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB3C")]
		public static int[] backgroundWidth;

		// Token: 0x040035A4 RID: 13732
		[Token(Token = "0x40035A4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB40")]
		public static int[] backgroundHeight;

		// Token: 0x040035A5 RID: 13733
		[Token(Token = "0x40035A5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB44")]
		public static DrawAnimation[] itemAnimations;

		// Token: 0x040035A6 RID: 13734
		[Token(Token = "0x40035A6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB48")]
		private static DrawAnimation _coinOnWorldAnimation;

		// Token: 0x040035A7 RID: 13735
		[Token(Token = "0x40035A7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB4C")]
		private static DrawAnimation _monkStaffT3OnWorldAnimation;

		// Token: 0x040035A8 RID: 13736
		[Token(Token = "0x40035A8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB50")]
		public static List<int> itemAnimationsRegistered;

		// Token: 0x040035A9 RID: 13737
		[Token(Token = "0x40035A9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB54")]
		public static int[] anglerQuestItemNetIDs;

		// Token: 0x040035AA RID: 13738
		[Token(Token = "0x40035AA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB58")]
		private static int _renderTargetMaxSize;

		// Token: 0x040035AB RID: 13739
		[Token(Token = "0x40035AB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB5C")]
		private static GraphicsProfile _selectedGraphicsProfile;

		// Token: 0x040035AC RID: 13740
		[Token(Token = "0x40035AC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB60")]
		private static GraphicsProfile _currentGraphicsProfile;

		// Token: 0x040035AD RID: 13741
		[Token(Token = "0x40035AD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB64")]
		private static UnifiedRandom _drawRand;

		// Token: 0x040035AE RID: 13742
		[Token(Token = "0x40035AE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB68")]
		public static int[] displayWidth;

		// Token: 0x040035AF RID: 13743
		[Token(Token = "0x40035AF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB6C")]
		public static int[] displayHeight;

		// Token: 0x040035B0 RID: 13744
		[Token(Token = "0x40035B0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB70")]
		private static int maxLoadPlayer;

		// Token: 0x040035B1 RID: 13745
		[Token(Token = "0x40035B1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB74")]
		private static int maxLoadWorld;

		// Token: 0x040035B2 RID: 13746
		[Token(Token = "0x40035B2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB78")]
		public static int[] npcFrameCount;

		// Token: 0x040035B3 RID: 13747
		[Token(Token = "0x40035B3")]
		public const int MaxTimeout = 10;

		// Token: 0x040035B4 RID: 13748
		[Token(Token = "0x40035B4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB7C")]
		public static string cUp;

		// Token: 0x040035B5 RID: 13749
		[Token(Token = "0x40035B5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB80")]
		public static string cLeft;

		// Token: 0x040035B6 RID: 13750
		[Token(Token = "0x40035B6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB84")]
		public static string cDown;

		// Token: 0x040035B7 RID: 13751
		[Token(Token = "0x40035B7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB88")]
		public static string cRight;

		// Token: 0x040035B8 RID: 13752
		[Token(Token = "0x40035B8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8C")]
		public static string cJump;

		// Token: 0x040035B9 RID: 13753
		[Token(Token = "0x40035B9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB90")]
		public static string cThrowItem;

		// Token: 0x040035BA RID: 13754
		[Token(Token = "0x40035BA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB94")]
		public static string cHeal;

		// Token: 0x040035BB RID: 13755
		[Token(Token = "0x40035BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB98")]
		public static string cMana;

		// Token: 0x040035BC RID: 13756
		[Token(Token = "0x40035BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB9C")]
		public static string cBuff;

		// Token: 0x040035BD RID: 13757
		[Token(Token = "0x40035BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBA0")]
		public static string cHook;

		// Token: 0x040035BE RID: 13758
		[Token(Token = "0x40035BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBA4")]
		public static string cTorch;

		// Token: 0x040035BF RID: 13759
		[Token(Token = "0x40035BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBA8")]
		public static string cInv;

		// Token: 0x040035C0 RID: 13760
		[Token(Token = "0x40035C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBAC")]
		public static string cSmart;

		// Token: 0x040035C1 RID: 13761
		[Token(Token = "0x40035C1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBB0")]
		public static string cMount;

		// Token: 0x040035C2 RID: 13762
		[Token(Token = "0x40035C2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBB4")]
		public static string cFavoriteKey;

		// Token: 0x040035C3 RID: 13763
		[Token(Token = "0x40035C3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBB8")]
		public static string cMapZoomIn;

		// Token: 0x040035C4 RID: 13764
		[Token(Token = "0x40035C4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBBC")]
		public static string cMapZoomOut;

		// Token: 0x040035C5 RID: 13765
		[Token(Token = "0x40035C5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC0")]
		public static string cMapAlphaUp;

		// Token: 0x040035C6 RID: 13766
		[Token(Token = "0x40035C6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC4")]
		public static string cMapAlphaDown;

		// Token: 0x040035C7 RID: 13767
		[Token(Token = "0x40035C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC8")]
		public static string cMapFull;

		// Token: 0x040035C8 RID: 13768
		[Token(Token = "0x40035C8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBCC")]
		public static string cMapStyle;

		// Token: 0x040035C9 RID: 13769
		[Token(Token = "0x40035C9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBD0")]
		public static Keys FavoriteKey;

		// Token: 0x040035CA RID: 13770
		[Token(Token = "0x40035CA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public List<int> DrawCacheNPCsMoonMoon;

		// Token: 0x040035CB RID: 13771
		[Token(Token = "0x40035CB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public List<int> DrawCacheNPCsOverPlayers;

		// Token: 0x040035CC RID: 13772
		[Token(Token = "0x40035CC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public List<int> DrawCacheNPCProjectiles;

		// Token: 0x040035CD RID: 13773
		[Token(Token = "0x40035CD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public List<int> DrawCacheNPCsBehindNonSolidTiles;

		// Token: 0x040035CE RID: 13774
		[Token(Token = "0x40035CE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public List<int> DrawCacheProjsBehindNPCsAndTiles;

		// Token: 0x040035CF RID: 13775
		[Token(Token = "0x40035CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public List<int> DrawCacheProjsBehindNPCs;

		// Token: 0x040035D0 RID: 13776
		[Token(Token = "0x40035D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public List<int> DrawCacheProjsBehindProjectiles;

		// Token: 0x040035D1 RID: 13777
		[Token(Token = "0x40035D1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public List<int> DrawCacheProjsOverWiresUI;

		// Token: 0x040035D2 RID: 13778
		[Token(Token = "0x40035D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public List<int> DrawCacheProjsOverPlayers;

		// Token: 0x040035D3 RID: 13779
		[Token(Token = "0x40035D3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public List<int> DrawCacheFirstFractals;

		// Token: 0x040035D4 RID: 13780
		[Token(Token = "0x40035D4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBD4")]
		public static bool SyncingWorlds;

		// Token: 0x040035D5 RID: 13781
		[Token(Token = "0x40035D5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBD8")]
		public static object SyncWorldObject;

		// Token: 0x040035D6 RID: 13782
		[Token(Token = "0x40035D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBDC")]
		public static bool SyncingPlayers;

		// Token: 0x040035D7 RID: 13783
		[Token(Token = "0x40035D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBE0")]
		public static object SyncPlayerObject;

		// Token: 0x040035D8 RID: 13784
		[Token(Token = "0x40035D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBE4")]
		private static bool _lowPowerMode;

		// Token: 0x040035D9 RID: 13785
		[Token(Token = "0x40035D9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBE5")]
		public static bool PerformedTouchInputConfig;

		// Token: 0x040035DA RID: 13786
		[Token(Token = "0x40035DA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBE6")]
		private static bool TrialMode;

		// Token: 0x040035DB RID: 13787
		[Token(Token = "0x40035DB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBE8")]
		public static string autoGenFileLocation;

		// Token: 0x040035DC RID: 13788
		[Token(Token = "0x40035DC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBEC")]
		public static bool fastForwardTimeToDusk;

		// Token: 0x040035DD RID: 13789
		[Token(Token = "0x40035DD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBF0")]
		public static int moondialCooldown;

		// Token: 0x040035DE RID: 13790
		[Token(Token = "0x40035DE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBF4")]
		private static Stopwatch splashTimer;

		// Token: 0x040035DF RID: 13791
		[Token(Token = "0x40035DF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBF8")]
		public static GeneralIssueReporter IssueReporter;

		// Token: 0x040035E0 RID: 13792
		[Token(Token = "0x40035E0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBFC")]
		private static int AnimateCritterPages;

		// Token: 0x040035E1 RID: 13793
		[Token(Token = "0x40035E1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC00")]
		public static bool PreventUpdatingTargets;

		// Token: 0x040035E2 RID: 13794
		[Token(Token = "0x40035E2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private DateTime lastYield;

		// Token: 0x040035E3 RID: 13795
		[Token(Token = "0x40035E3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private IEnumerator _gameContentLoadProcess;

		// Token: 0x040035E4 RID: 13796
		[Token(Token = "0x40035E4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private int _musicSilencerCounter;

		// Token: 0x040035E5 RID: 13797
		[Token(Token = "0x40035E5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int lastMusicPlayed;

		// Token: 0x040035E6 RID: 13798
		[Token(Token = "0x40035E6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC04")]
		private static Main.TitleMusicStyle titleMusicStyle;

		// Token: 0x040035E7 RID: 13799
		[Token(Token = "0x40035E7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC08")]
		private static Main.TitleMusicStyle titleMusicStyleRandom;

		// Token: 0x040035E8 RID: 13800
		[Token(Token = "0x40035E8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0C")]
		private static float _minWind;

		// Token: 0x040035E9 RID: 13801
		[Token(Token = "0x40035E9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC10")]
		private static float _maxWind;

		// Token: 0x040035EA RID: 13802
		[Token(Token = "0x40035EA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC14")]
		private static float _minRain;

		// Token: 0x040035EB RID: 13803
		[Token(Token = "0x40035EB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC18")]
		private static float _maxRain;

		// Token: 0x040035EC RID: 13804
		[Token(Token = "0x40035EC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC1C")]
		private static int[] UpdateDragonflyJarFrame_0;

		// Token: 0x040035ED RID: 13805
		[Token(Token = "0x40035ED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC20")]
		private static int[] UpdateDragonflyJarFrame_1;

		// Token: 0x040035EE RID: 13806
		[Token(Token = "0x40035EE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Stopwatch _worldUpdateTimeTester;

		// Token: 0x040035EF RID: 13807
		[Token(Token = "0x40035EF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private int _perfLastFrame;

		// Token: 0x040035F0 RID: 13808
		[Token(Token = "0x40035F0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector2 lastCloudScreenPosition;

		// Token: 0x040035F1 RID: 13809
		[Token(Token = "0x40035F1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public SpelunkerProjectileHelper SpelunkerProjectileHelper;

		// Token: 0x040035F2 RID: 13810
		[Token(Token = "0x40035F2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public ChumBucketProjectileHelper ChumBucketProjectileHelper;

		// Token: 0x040035F3 RID: 13811
		[Token(Token = "0x40035F3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC24")]
		private static int AutoSavePlayerTime;

		// Token: 0x040035F4 RID: 13812
		[Token(Token = "0x40035F4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC28")]
		public static int AutoSaveWorldTime;

		// Token: 0x040035F5 RID: 13813
		[Token(Token = "0x40035F5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC2C")]
		private static int seedMoonGoal;

		// Token: 0x040035F6 RID: 13814
		[Token(Token = "0x40035F6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC30")]
		private static List<char> removeChars;

		// Token: 0x040035F7 RID: 13815
		[Token(Token = "0x40035F7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public float logoRotation;

		// Token: 0x040035F8 RID: 13816
		[Token(Token = "0x40035F8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public float logoRotationDirection;

		// Token: 0x040035F9 RID: 13817
		[Token(Token = "0x40035F9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public float logoRotationSpeed;

		// Token: 0x040035FA RID: 13818
		[Token(Token = "0x40035FA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public float logoScale;

		// Token: 0x040035FB RID: 13819
		[Token(Token = "0x40035FB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		public float logoScaleDirection;

		// Token: 0x040035FC RID: 13820
		[Token(Token = "0x40035FC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public float logoScaleSpeed;

		// Token: 0x040035FD RID: 13821
		[Token(Token = "0x40035FD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC34")]
		private static int maxMenuItems;

		// Token: 0x040035FE RID: 13822
		[Token(Token = "0x40035FE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float[] menuItemScale;

		// Token: 0x040035FF RID: 13823
		[Token(Token = "0x40035FF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int focusMenu;

		// Token: 0x04003600 RID: 13824
		[Token(Token = "0x4003600")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int selectedMenu;

		// Token: 0x04003601 RID: 13825
		[Token(Token = "0x4003601")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int selectedMenu2;

		// Token: 0x04003602 RID: 13826
		[Token(Token = "0x4003602")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC38")]
		public static int menuSkip;

		// Token: 0x04003603 RID: 13827
		[Token(Token = "0x4003603")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC3C")]
		private static bool _needsLanguageSelect;

		// Token: 0x04003604 RID: 13828
		[Token(Token = "0x4003604")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC40")]
		private static Item tooltipPrefixComparisonItem;

		// Token: 0x04003605 RID: 13829
		[Token(Token = "0x4003605")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC44")]
		private static Item _mouseTextFakeItem;

		// Token: 0x04003606 RID: 13830
		[Token(Token = "0x4003606")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC48")]
		private static Item _airHoverItem;

		// Token: 0x04003607 RID: 13831
		[Token(Token = "0x4003607")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public int textBlinkerCount;

		// Token: 0x04003608 RID: 13832
		[Token(Token = "0x4003608")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public int textBlinkerState;

		// Token: 0x04003609 RID: 13833
		[Token(Token = "0x4003609")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC50")]
		public static long TotalMemory;

		// Token: 0x0400360A RID: 13834
		[Token(Token = "0x400360A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC58")]
		public static int TotalMemoryUpdate;

		// Token: 0x0400360B RID: 13835
		[Token(Token = "0x400360B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC5C")]
		public static int TotalMemotyFullClear;

		// Token: 0x0400360C RID: 13836
		[Token(Token = "0x400360C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC60")]
		private static Vector3 shimmerShine;

		// Token: 0x0400360D RID: 13837
		[Token(Token = "0x400360D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		public TilePaintSystemV2 TilePaintSystem;

		// Token: 0x0400360E RID: 13838
		[Token(Token = "0x400360E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public TileDrawing TilesRenderer;

		// Token: 0x0400360F RID: 13839
		[Token(Token = "0x400360F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public WallDrawing WallsRenderer;

		// Token: 0x04003610 RID: 13840
		[Token(Token = "0x4003610")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public IHorizonRenderer HorizonRenderer;

		// Token: 0x04003611 RID: 13841
		[Token(Token = "0x4003611")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC6C")]
		public static bool HorizonShadersEnabled;

		// Token: 0x04003612 RID: 13842
		[Token(Token = "0x4003612")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		public HorizonHelper HorizonHelper;

		// Token: 0x04003613 RID: 13843
		[Token(Token = "0x4003613")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private AmbientWindSystem _ambientWindSys;

		// Token: 0x04003614 RID: 13844
		[Token(Token = "0x4003614")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private List<Player> _playersThatDrawBehindNPCs;

		// Token: 0x04003615 RID: 13845
		[Token(Token = "0x4003615")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private List<Player> _playersThatDrawAfterProjectiles;

		// Token: 0x04003616 RID: 13846
		[Token(Token = "0x4003616")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private List<Player> drawPlayersPotion;

		// Token: 0x04003617 RID: 13847
		[Token(Token = "0x4003617")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private List<DrawData> _voidLensData;

		// Token: 0x04003618 RID: 13848
		[Token(Token = "0x4003618")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private FlameLashDrawer flameLashDrawer;

		// Token: 0x04003619 RID: 13849
		[Token(Token = "0x4003619")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private MagicMissileDrawer magicMissileDrawer;

		// Token: 0x0400361A RID: 13850
		[Token(Token = "0x400361A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private FinalFractalHelper finalFractalHelper;

		// Token: 0x0400361B RID: 13851
		[Token(Token = "0x400361B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private RainbowRodDrawer rainbowRodDrawer;

		// Token: 0x0400361C RID: 13852
		[Token(Token = "0x400361C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1AD")]
		private EmpressBladeDrawer empressBladeDrawer;

		// Token: 0x0400361D RID: 13853
		[Token(Token = "0x400361D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B5")]
		private GemStaffShotDrawer gemStaffShotDrawer;

		// Token: 0x0400361E RID: 13854
		[Token(Token = "0x400361E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC70")]
		private static BlendState _multiplyBlendState;

		// Token: 0x0400361F RID: 13855
		[Token(Token = "0x400361F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC74")]
		private static StardewValleyAnimation _stardewAnimation;

		// Token: 0x04003620 RID: 13856
		[Token(Token = "0x4003620")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC78")]
		private static UnifiedRandom _tempSeededRandom;

		// Token: 0x04003621 RID: 13857
		[Token(Token = "0x4003621")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC7C")]
		private static List<Vector2> ribbonPointsCache;

		// Token: 0x04003622 RID: 13858
		[Token(Token = "0x4003622")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private List<int> birds_SortBabyBirdProjectiles;

		// Token: 0x04003623 RID: 13859
		[Token(Token = "0x4003623")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private List<List<int>> tempList_SortStardustDragonProjectiles;

		// Token: 0x04003624 RID: 13860
		[Token(Token = "0x4003624")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private List<int> leftOvers_SortStardustDragonProjectiles;

		// Token: 0x04003625 RID: 13861
		[Token(Token = "0x4003625")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private List<int> worm_SortStardustDragonProjectiles;

		// Token: 0x04003626 RID: 13862
		[Token(Token = "0x4003626")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private List<int> tempWorm_SortStardustDragonProjectiles;

		// Token: 0x04003627 RID: 13863
		[Token(Token = "0x4003627")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private List<int> _occupantsListToDrawNPCHouses;

		// Token: 0x04003628 RID: 13864
		[Token(Token = "0x4003628")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private List<int> _npcsWithBannersToDraw;

		// Token: 0x04003629 RID: 13865
		[Token(Token = "0x4003629")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private List<int> _npcTypesThatAlreadyDrewAHead;

		// Token: 0x0400362A RID: 13866
		[Token(Token = "0x400362A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private int[] _npcIndexWhoHoldsHeadIndex;

		// Token: 0x0400362B RID: 13867
		[Token(Token = "0x400362B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC80")]
		private static bool _preventCraftingBecauseClickWasUsedToChangeFocusedRecipe;

		// Token: 0x0400362C RID: 13868
		[Token(Token = "0x400362C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC84")]
		private static int _currentRecipeBeingCrafted;

		// Token: 0x0400362D RID: 13869
		[Token(Token = "0x400362D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private bool _needToSetupDrawInterfaceLayers;

		// Token: 0x0400362E RID: 13870
		[Token(Token = "0x400362E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		private List<GameInterfaceLayer> _gameInterfaceLayers;

		// Token: 0x0400362F RID: 13871
		[Token(Token = "0x400362F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC88")]
		private static GameTime _drawInterfaceGameTime;

		// Token: 0x04003630 RID: 13872
		[Token(Token = "0x4003630")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8C")]
		public static bool DoGlowingMouseItemDraw;

		// Token: 0x04003631 RID: 13873
		[Token(Token = "0x4003631")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private byte instrumentMouseFixHack;

		// Token: 0x04003632 RID: 13874
		[Token(Token = "0x4003632")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8D")]
		private static bool _settingsButtonIsPushedToSide;

		// Token: 0x04003633 RID: 13875
		[Token(Token = "0x4003633")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC90")]
		private static readonly Point[] SmartCursorDirectionLocks;

		// Token: 0x04003634 RID: 13876
		[Token(Token = "0x4003634")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC94")]
		private static bool _cannotDrawAccessoriesHorizontally;

		// Token: 0x04003635 RID: 13877
		[Token(Token = "0x4003635")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		private int grabColorSlider;

		// Token: 0x04003636 RID: 13878
		[Token(Token = "0x4003636")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC95")]
		private static bool _blockFancyUIWhileLoading;

		// Token: 0x04003637 RID: 13879
		[Token(Token = "0x4003637")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private bool[] menuWide;

		// Token: 0x04003638 RID: 13880
		[Token(Token = "0x4003638")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
		private bool _needsMenuUIRecalculation;

		// Token: 0x04003639 RID: 13881
		[Token(Token = "0x4003639")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public RejectionMenuInfo RejectionMenuInfo;

		// Token: 0x0400363A RID: 13882
		[Token(Token = "0x400363A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private float _splashFrameCount;

		// Token: 0x0400363B RID: 13883
		[Token(Token = "0x400363B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private bool quickSplash;

		// Token: 0x0400363C RID: 13884
		[Token(Token = "0x400363C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private Color[] backgroundColorSlicesStatic;

		// Token: 0x0400363D RID: 13885
		[Token(Token = "0x400363D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

		// Token: 0x0400363E RID: 13886
		[Token(Token = "0x400363E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private ThreadedRenderManager _threadManager;

		// Token: 0x0400363F RID: 13887
		[Token(Token = "0x400363F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public ThreadLocal<Main.BackgroundDrawInfo> _currentBackgroundDrawInfo;

		// Token: 0x04003640 RID: 13888
		[Token(Token = "0x4003640")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		private int[] tempBack;

		// Token: 0x04003641 RID: 13889
		[Token(Token = "0x4003641")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC98")]
		private static int _minimapTopRightAnchorOffsetTowardsLeft;

		// Token: 0x04003642 RID: 13890
		[Token(Token = "0x4003642")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC9C")]
		private static int _minimapTopRightAnchorOffsetTowardsBottom;

		// Token: 0x04003643 RID: 13891
		[Token(Token = "0x4003643")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		public bool FlushWater;

		// Token: 0x04003644 RID: 13892
		[Token(Token = "0x4003644")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCA0")]
		public static bool frameShouldShowInvisibleBlocksAnWallsCached;

		// Token: 0x04003645 RID: 13893
		[Token(Token = "0x4003645")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCA1")]
		private static VertexColors _glowPaintColors;

		// Token: 0x04003646 RID: 13894
		[Token(Token = "0x4003646")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		protected List<Tuple<int, int, ushort>> DrawWiresSpecialTiles;

		// Token: 0x04003647 RID: 13895
		[Token(Token = "0x4003647")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private int lastWeatherFrame;

		// Token: 0x04003648 RID: 13896
		[Token(Token = "0x4003648")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCB4")]
		private static Rectangle backgroundItemRectangle;

		// Token: 0x04003649 RID: 13897
		[Token(Token = "0x4003649")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC4")]
		private static Rectangle clampedBackgroundItemRectangle;

		// Token: 0x0400364A RID: 13898
		[Token(Token = "0x400364A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		private float screenOff;

		// Token: 0x0400364B RID: 13899
		[Token(Token = "0x400364B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private float scAdj;

		// Token: 0x0400364C RID: 13900
		[Token(Token = "0x400364C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCD4")]
		private static int _rainbowBoulderMusicFramesCounter;

		// Token: 0x0400364D RID: 13901
		[Token(Token = "0x400364D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCD8")]
		private static bool _finishedRainbowBoulderStart;

		// Token: 0x0400364E RID: 13902
		[Token(Token = "0x400364E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x234")]
		private bool _isDrawingOrUpdating;

		// Token: 0x0400364F RID: 13903
		[Token(Token = "0x400364F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCDC")]
		public static List<INeedRenderTargetContent> ContentThatNeedsRenderTargets;

		// Token: 0x04003650 RID: 13904
		[Token(Token = "0x4003650")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x235")]
		private bool _resetContentThatNeedsRenderTargetsNextFrame;

		// Token: 0x04003651 RID: 13905
		[Token(Token = "0x4003651")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCE0")]
		private static Item clearItem;

		// Token: 0x04003652 RID: 13906
		[Token(Token = "0x4003652")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCE4")]
		private static int _lastFrameFPSCount;

		// Token: 0x04003653 RID: 13907
		[Token(Token = "0x4003653")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCE8")]
		public static bool disableDontStarveDarknessDamage;

		// Token: 0x04003654 RID: 13908
		[Token(Token = "0x4003654")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public CameraModifierStack CameraModifiers;

		// Token: 0x04003655 RID: 13909
		[Token(Token = "0x4003655")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCE9")]
		public static bool starGame;

		// Token: 0x04003656 RID: 13910
		[Token(Token = "0x4003656")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCEC")]
		public static int starsHit;

		// Token: 0x04003657 RID: 13911
		[Token(Token = "0x4003657")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private float controllerSunGrabPositionX;

		// Token: 0x04003658 RID: 13912
		[Token(Token = "0x4003658")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private float controllerSunGrabPositionY;

		// Token: 0x0200046E RID: 1134
		[Token(Token = "0x200046E")]
		public static class CurrentFrameFlags
		{
			// Token: 0x04003659 RID: 13913
			[Token(Token = "0x4003659")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static int ActivePlayersCount;

			// Token: 0x0400365A RID: 13914
			[Token(Token = "0x400365A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static int SleepingPlayersCount;

			// Token: 0x0400365B RID: 13915
			[Token(Token = "0x400365B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static bool AnyActiveBossNPC;

			// Token: 0x0400365C RID: 13916
			[Token(Token = "0x400365C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public static bool HadAnActiveInteractibleProjectile;

			// Token: 0x0200046F RID: 1135
			[Token(Token = "0x200046F")]
			public static class Hacks
			{
				// Token: 0x0400365D RID: 13917
				[Token(Token = "0x400365D")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static Matrix CurrentBackgroundMatrixForCreditsRoll;
			}
		}

		// Token: 0x02000470 RID: 1136
		// (Invoke) Token: 0x06002590 RID: 9616
		[Token(Token = "0x2000470")]
		public delegate void OnPlayerSelected(PlayerFileData player);

		// Token: 0x02000471 RID: 1137
		[Token(Token = "0x2000471")]
		public enum AutoPauseMode
		{
			// Token: 0x0400365F RID: 13919
			[Token(Token = "0x400365F")]
			Disabled,
			// Token: 0x04003660 RID: 13920
			[Token(Token = "0x4003660")]
			Menus,
			// Token: 0x04003661 RID: 13921
			[Token(Token = "0x4003661")]
			Inventory
		}

		// Token: 0x02000472 RID: 1138
		[Token(Token = "0x2000472")]
		public enum WorldPreparationState
		{
			// Token: 0x04003663 RID: 13923
			[Token(Token = "0x4003663")]
			AwaitingData,
			// Token: 0x04003664 RID: 13924
			[Token(Token = "0x4003664")]
			ProcessingData,
			// Token: 0x04003665 RID: 13925
			[Token(Token = "0x4003665")]
			Ready
		}

		// Token: 0x02000473 RID: 1139
		[Token(Token = "0x2000473")]
		private enum TitleMusicStyle
		{
			// Token: 0x04003667 RID: 13927
			[Token(Token = "0x4003667")]
			Current,
			// Token: 0x04003668 RID: 13928
			[Token(Token = "0x4003668")]
			Old,
			// Token: 0x04003669 RID: 13929
			[Token(Token = "0x4003669")]
			Console,
			// Token: 0x0400366A RID: 13930
			[Token(Token = "0x400366A")]
			Random
		}

		// Token: 0x02000474 RID: 1140
		[Token(Token = "0x2000474")]
		public struct MouseTextCache
		{
			// Token: 0x0400366B RID: 13931
			[Token(Token = "0x400366B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool noOverride;

			// Token: 0x0400366C RID: 13932
			[Token(Token = "0x400366C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool isValid;

			// Token: 0x0400366D RID: 13933
			[Token(Token = "0x400366D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public string cursorText;

			// Token: 0x0400366E RID: 13934
			[Token(Token = "0x400366E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int rare;

			// Token: 0x0400366F RID: 13935
			[Token(Token = "0x400366F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public byte diff;

			// Token: 0x04003670 RID: 13936
			[Token(Token = "0x4003670")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int X;

			// Token: 0x04003671 RID: 13937
			[Token(Token = "0x4003671")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int Y;

			// Token: 0x04003672 RID: 13938
			[Token(Token = "0x4003672")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int hackedScreenWidth;

			// Token: 0x04003673 RID: 13939
			[Token(Token = "0x4003673")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int hackedScreenHeight;

			// Token: 0x04003674 RID: 13940
			[Token(Token = "0x4003674")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string buffTooltip;
		}

		// Token: 0x02000475 RID: 1141
		[Token(Token = "0x2000475")]
		public class BackgroundDrawInfo
		{
			// Token: 0x06002593 RID: 9619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002593")]
			[Address(RVA = "0x120C188", Offset = "0x120C188", VA = "0x120C188")]
			public BackgroundDrawInfo()
			{
			}

			// Token: 0x04003675 RID: 13941
			[Token(Token = "0x4003675")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public SpriteBatch backgroundSpriteBatch;

			// Token: 0x04003676 RID: 13942
			[Token(Token = "0x4003676")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Color[] backgroundColorSlicesStatic;

			// Token: 0x04003677 RID: 13943
			[Token(Token = "0x4003677")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public VertexColors bgColors;
		}

		// Token: 0x02000476 RID: 1142
		[Token(Token = "0x2000476")]
		public struct SceneArea
		{
			// Token: 0x04003678 RID: 13944
			[Token(Token = "0x4003678")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2 SceneLocalScreenPositionOffset;

			// Token: 0x04003679 RID: 13945
			[Token(Token = "0x4003679")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float totalWidth;

			// Token: 0x0400367A RID: 13946
			[Token(Token = "0x400367A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float totalHeight;

			// Token: 0x0400367B RID: 13947
			[Token(Token = "0x400367B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int bgTopY;
		}

		// Token: 0x02000477 RID: 1143
		[Token(Token = "0x2000477")]
		public struct InfoToSetBackColor
		{
			// Token: 0x0400367C RID: 13948
			[Token(Token = "0x400367C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool isInGameMenuOrIsServer;

			// Token: 0x0400367D RID: 13949
			[Token(Token = "0x400367D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float CorruptionBiomeInfluence;

			// Token: 0x0400367E RID: 13950
			[Token(Token = "0x400367E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float CrimsonBiomeInfluence;

			// Token: 0x0400367F RID: 13951
			[Token(Token = "0x400367F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float JungleBiomeInfluence;

			// Token: 0x04003680 RID: 13952
			[Token(Token = "0x4003680")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float MushroomBiomeInfluence;

			// Token: 0x04003681 RID: 13953
			[Token(Token = "0x4003681")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float GraveyardInfluence;

			// Token: 0x04003682 RID: 13954
			[Token(Token = "0x4003682")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool BloodMoonActive;

			// Token: 0x04003683 RID: 13955
			[Token(Token = "0x4003683")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool LanternNightActive;
		}

		// Token: 0x02000478 RID: 1144
		[Token(Token = "0x2000478")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002595 RID: 9621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002595")]
			[Address(RVA = "0x120C260", Offset = "0x120C260", VA = "0x120C260")]
			public <>c()
			{
			}

			// Token: 0x06002596 RID: 9622 RVA: 0x00011EF8 File Offset: 0x000100F8
			[Token(Token = "0x6002596")]
			[Address(RVA = "0x120C268", Offset = "0x120C268", VA = "0x120C268")]
			internal bool <LoadWorlds>b__1924_0(string path)
			{
				return default(bool);
			}

			// Token: 0x06002597 RID: 9623 RVA: 0x00011F10 File Offset: 0x00010110
			[Token(Token = "0x6002597")]
			[Address(RVA = "0x120C33C", Offset = "0x120C33C", VA = "0x120C33C")]
			internal bool <LoadPlayers>b__1929_0(string path)
			{
				return default(bool);
			}

			// Token: 0x06002598 RID: 9624 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002598")]
			[Address(RVA = "0x120C410", Offset = "0x120C410", VA = "0x120C410")]
			internal Main.BackgroundDrawInfo <.ctor>b__1992_0()
			{
				return null;
			}

			// Token: 0x06002599 RID: 9625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002599")]
			[Address(RVA = "0x120C4C8", Offset = "0x120C4C8", VA = "0x120C4C8")]
			internal void <Initialize>b__1998_0()
			{
			}

			// Token: 0x0600259A RID: 9626 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600259A")]
			[Address(RVA = "0x120C608", Offset = "0x120C608", VA = "0x120C608")]
			internal void <Initialize>b__1998_1()
			{
			}

			// Token: 0x0600259B RID: 9627 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600259B")]
			[Address(RVA = "0x120C684", Offset = "0x120C684", VA = "0x120C684")]
			internal void <ClientInitialize>b__2007_0(LanguageManager languageManager)
			{
			}

			// Token: 0x0600259C RID: 9628 RVA: 0x00011F28 File Offset: 0x00010128
			[Token(Token = "0x600259C")]
			[Address(RVA = "0x120C6E4", Offset = "0x120C6E4", VA = "0x120C6E4")]
			internal bool <SetupDrawInterfaceLayers>b__2380_0()
			{
				return default(bool);
			}

			// Token: 0x0600259D RID: 9629 RVA: 0x00011F40 File Offset: 0x00010140
			[Token(Token = "0x600259D")]
			[Address(RVA = "0x120C748", Offset = "0x120C748", VA = "0x120C748")]
			internal bool <SetupDrawInterfaceLayers>b__2380_1()
			{
				return default(bool);
			}

			// Token: 0x0600259E RID: 9630 RVA: 0x00011F58 File Offset: 0x00010158
			[Token(Token = "0x600259E")]
			[Address(RVA = "0x120C7AC", Offset = "0x120C7AC", VA = "0x120C7AC")]
			internal bool <SetupDrawInterfaceLayers>b__2380_2()
			{
				return default(bool);
			}

			// Token: 0x0600259F RID: 9631 RVA: 0x00011F70 File Offset: 0x00010170
			[Token(Token = "0x600259F")]
			[Address(RVA = "0x120C810", Offset = "0x120C810", VA = "0x120C810")]
			internal bool <SetupDrawInterfaceLayers>b__2380_3()
			{
				return default(bool);
			}

			// Token: 0x060025A0 RID: 9632 RVA: 0x00011F88 File Offset: 0x00010188
			[Token(Token = "0x60025A0")]
			[Address(RVA = "0x120C874", Offset = "0x120C874", VA = "0x120C874")]
			internal bool <SetupDrawInterfaceLayers>b__2380_4()
			{
				return default(bool);
			}

			// Token: 0x060025A1 RID: 9633 RVA: 0x00011FA0 File Offset: 0x000101A0
			[Token(Token = "0x60025A1")]
			[Address(RVA = "0x120C8D8", Offset = "0x120C8D8", VA = "0x120C8D8")]
			internal bool <SetupDrawInterfaceLayers>b__2380_5()
			{
				return default(bool);
			}

			// Token: 0x060025A2 RID: 9634 RVA: 0x00011FB8 File Offset: 0x000101B8
			[Token(Token = "0x60025A2")]
			[Address(RVA = "0x120C93C", Offset = "0x120C93C", VA = "0x120C93C")]
			internal bool <SetupDrawInterfaceLayers>b__2380_6()
			{
				return default(bool);
			}

			// Token: 0x060025A3 RID: 9635 RVA: 0x00011FD0 File Offset: 0x000101D0
			[Token(Token = "0x60025A3")]
			[Address(RVA = "0x120C9A0", Offset = "0x120C9A0", VA = "0x120C9A0")]
			internal bool <SetupDrawInterfaceLayers>b__2380_7()
			{
				return default(bool);
			}

			// Token: 0x060025A4 RID: 9636 RVA: 0x00011FE8 File Offset: 0x000101E8
			[Token(Token = "0x60025A4")]
			[Address(RVA = "0x120CA04", Offset = "0x120CA04", VA = "0x120CA04")]
			internal bool <SetupDrawInterfaceLayers>b__2380_8()
			{
				return default(bool);
			}

			// Token: 0x060025A5 RID: 9637 RVA: 0x00012000 File Offset: 0x00010200
			[Token(Token = "0x60025A5")]
			[Address(RVA = "0x120CA68", Offset = "0x120CA68", VA = "0x120CA68")]
			internal bool <SetupDrawInterfaceLayers>b__2380_11()
			{
				return default(bool);
			}

			// Token: 0x060025A6 RID: 9638 RVA: 0x00012018 File Offset: 0x00010218
			[Token(Token = "0x60025A6")]
			[Address(RVA = "0x120CACC", Offset = "0x120CACC", VA = "0x120CACC")]
			internal bool <SetupDrawInterfaceLayers>b__2380_14()
			{
				return default(bool);
			}

			// Token: 0x060025A7 RID: 9639 RVA: 0x00012030 File Offset: 0x00010230
			[Token(Token = "0x60025A7")]
			[Address(RVA = "0x120CB30", Offset = "0x120CB30", VA = "0x120CB30")]
			internal bool <SetupDrawInterfaceLayers>b__2380_15()
			{
				return default(bool);
			}

			// Token: 0x060025A8 RID: 9640 RVA: 0x00012048 File Offset: 0x00010248
			[Token(Token = "0x60025A8")]
			[Address(RVA = "0x120CB94", Offset = "0x120CB94", VA = "0x120CB94")]
			internal bool <SetupDrawInterfaceLayers>b__2380_16()
			{
				return default(bool);
			}

			// Token: 0x060025A9 RID: 9641 RVA: 0x00012060 File Offset: 0x00010260
			[Token(Token = "0x60025A9")]
			[Address(RVA = "0x120CBF8", Offset = "0x120CBF8", VA = "0x120CBF8")]
			internal bool <SetupDrawInterfaceLayers>b__2380_18()
			{
				return default(bool);
			}

			// Token: 0x060025AA RID: 9642 RVA: 0x00012078 File Offset: 0x00010278
			[Token(Token = "0x60025AA")]
			[Address(RVA = "0x120CC5C", Offset = "0x120CC5C", VA = "0x120CC5C")]
			internal bool <SetupDrawInterfaceLayers>b__2380_19()
			{
				return default(bool);
			}

			// Token: 0x060025AB RID: 9643 RVA: 0x00012090 File Offset: 0x00010290
			[Token(Token = "0x60025AB")]
			[Address(RVA = "0x120CCC0", Offset = "0x120CCC0", VA = "0x120CCC0")]
			internal bool <SetupDrawInterfaceLayers>b__2380_21()
			{
				return default(bool);
			}

			// Token: 0x060025AC RID: 9644 RVA: 0x000120A8 File Offset: 0x000102A8
			[Token(Token = "0x60025AC")]
			[Address(RVA = "0x120CD24", Offset = "0x120CD24", VA = "0x120CD24")]
			internal bool <SetupDrawInterfaceLayers>b__2380_31()
			{
				return default(bool);
			}

			// Token: 0x060025AD RID: 9645 RVA: 0x000120C0 File Offset: 0x000102C0
			[Token(Token = "0x60025AD")]
			[Address(RVA = "0x120CD88", Offset = "0x120CD88", VA = "0x120CD88")]
			internal bool <SetupDrawInterfaceLayers>b__2380_32()
			{
				return default(bool);
			}

			// Token: 0x060025AE RID: 9646 RVA: 0x000120D8 File Offset: 0x000102D8
			[Token(Token = "0x60025AE")]
			[Address(RVA = "0x120CDEC", Offset = "0x120CDEC", VA = "0x120CDEC")]
			internal bool <SetupDrawInterfaceLayers>b__2380_33()
			{
				return default(bool);
			}

			// Token: 0x060025AF RID: 9647 RVA: 0x000120F0 File Offset: 0x000102F0
			[Token(Token = "0x60025AF")]
			[Address(RVA = "0x120CE50", Offset = "0x120CE50", VA = "0x120CE50")]
			internal bool <SetupDrawInterfaceLayers>b__2380_34()
			{
				return default(bool);
			}

			// Token: 0x060025B0 RID: 9648 RVA: 0x00012108 File Offset: 0x00010308
			[Token(Token = "0x60025B0")]
			[Address(RVA = "0x120CEB4", Offset = "0x120CEB4", VA = "0x120CEB4")]
			internal bool <SetupDrawInterfaceLayers>b__2380_35()
			{
				return default(bool);
			}

			// Token: 0x060025B1 RID: 9649 RVA: 0x00012120 File Offset: 0x00010320
			[Token(Token = "0x60025B1")]
			[Address(RVA = "0x120CF18", Offset = "0x120CF18", VA = "0x120CF18")]
			internal bool <SetupDrawInterfaceLayers>b__2380_36()
			{
				return default(bool);
			}

			// Token: 0x060025B2 RID: 9650 RVA: 0x00012138 File Offset: 0x00010338
			[Token(Token = "0x60025B2")]
			[Address(RVA = "0x120CF7C", Offset = "0x120CF7C", VA = "0x120CF7C")]
			internal bool <SetupDrawInterfaceLayers>b__2380_37()
			{
				return default(bool);
			}

			// Token: 0x060025B3 RID: 9651 RVA: 0x00012150 File Offset: 0x00010350
			[Token(Token = "0x60025B3")]
			[Address(RVA = "0x120CFE0", Offset = "0x120CFE0", VA = "0x120CFE0")]
			internal bool <SetupDrawInterfaceLayers>b__2380_40()
			{
				return default(bool);
			}

			// Token: 0x060025B4 RID: 9652 RVA: 0x00012168 File Offset: 0x00010368
			[Token(Token = "0x60025B4")]
			[Address(RVA = "0x120D044", Offset = "0x120D044", VA = "0x120D044")]
			internal bool <UpdateBGVisibility_FrontLayer_IsDesertVariantSwap>b__2714_0(int bg)
			{
				return default(bool);
			}

			// Token: 0x04003684 RID: 13956
			[Token(Token = "0x4003684")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Main.<>c <>9;

			// Token: 0x04003685 RID: 13957
			[Token(Token = "0x4003685")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<string, bool> <>9__1924_0;

			// Token: 0x04003686 RID: 13958
			[Token(Token = "0x4003686")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, bool> <>9__1929_0;

			// Token: 0x04003687 RID: 13959
			[Token(Token = "0x4003687")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static Func<Main.BackgroundDrawInfo> <>9__1992_0;

			// Token: 0x04003688 RID: 13960
			[Token(Token = "0x4003688")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action <>9__1998_0;

			// Token: 0x04003689 RID: 13961
			[Token(Token = "0x4003689")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static Action <>9__1998_1;

			// Token: 0x0400368A RID: 13962
			[Token(Token = "0x400368A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static LanguageChangeCallback <>9__2007_0;

			// Token: 0x0400368B RID: 13963
			[Token(Token = "0x400368B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static GameInterfaceDrawMethod <>9__2380_0;

			// Token: 0x0400368C RID: 13964
			[Token(Token = "0x400368C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static GameInterfaceDrawMethod <>9__2380_1;

			// Token: 0x0400368D RID: 13965
			[Token(Token = "0x400368D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public static GameInterfaceDrawMethod <>9__2380_2;

			// Token: 0x0400368E RID: 13966
			[Token(Token = "0x400368E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static GameInterfaceDrawMethod <>9__2380_3;

			// Token: 0x0400368F RID: 13967
			[Token(Token = "0x400368F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public static GameInterfaceDrawMethod <>9__2380_4;

			// Token: 0x04003690 RID: 13968
			[Token(Token = "0x4003690")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static GameInterfaceDrawMethod <>9__2380_5;

			// Token: 0x04003691 RID: 13969
			[Token(Token = "0x4003691")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public static GameInterfaceDrawMethod <>9__2380_6;

			// Token: 0x04003692 RID: 13970
			[Token(Token = "0x4003692")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static GameInterfaceDrawMethod <>9__2380_7;

			// Token: 0x04003693 RID: 13971
			[Token(Token = "0x4003693")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public static GameInterfaceDrawMethod <>9__2380_8;

			// Token: 0x04003694 RID: 13972
			[Token(Token = "0x4003694")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static GameInterfaceDrawMethod <>9__2380_11;

			// Token: 0x04003695 RID: 13973
			[Token(Token = "0x4003695")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public static GameInterfaceDrawMethod <>9__2380_14;

			// Token: 0x04003696 RID: 13974
			[Token(Token = "0x4003696")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static GameInterfaceDrawMethod <>9__2380_15;

			// Token: 0x04003697 RID: 13975
			[Token(Token = "0x4003697")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public static GameInterfaceDrawMethod <>9__2380_16;

			// Token: 0x04003698 RID: 13976
			[Token(Token = "0x4003698")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static GameInterfaceDrawMethod <>9__2380_18;

			// Token: 0x04003699 RID: 13977
			[Token(Token = "0x4003699")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public static GameInterfaceDrawMethod <>9__2380_19;

			// Token: 0x0400369A RID: 13978
			[Token(Token = "0x400369A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static GameInterfaceDrawMethod <>9__2380_21;

			// Token: 0x0400369B RID: 13979
			[Token(Token = "0x400369B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public static GameInterfaceDrawMethod <>9__2380_31;

			// Token: 0x0400369C RID: 13980
			[Token(Token = "0x400369C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static GameInterfaceDrawMethod <>9__2380_32;

			// Token: 0x0400369D RID: 13981
			[Token(Token = "0x400369D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public static GameInterfaceDrawMethod <>9__2380_33;

			// Token: 0x0400369E RID: 13982
			[Token(Token = "0x400369E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static GameInterfaceDrawMethod <>9__2380_34;

			// Token: 0x0400369F RID: 13983
			[Token(Token = "0x400369F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public static GameInterfaceDrawMethod <>9__2380_35;

			// Token: 0x040036A0 RID: 13984
			[Token(Token = "0x40036A0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static GameInterfaceDrawMethod <>9__2380_36;

			// Token: 0x040036A1 RID: 13985
			[Token(Token = "0x40036A1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public static GameInterfaceDrawMethod <>9__2380_37;

			// Token: 0x040036A2 RID: 13986
			[Token(Token = "0x40036A2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static GameInterfaceDrawMethod <>9__2380_40;

			// Token: 0x040036A3 RID: 13987
			[Token(Token = "0x40036A3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public static Func<int, bool> <>9__2714_0;
		}

		// Token: 0x02000479 RID: 1145
		[Token(Token = "0x2000479")]
		private sealed class <LoadContent_Deferred>d__2022 : FileAPI, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x060025B5 RID: 9653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025B5")]
			[Address(RVA = "0x120D1DC", Offset = "0x120D1DC", VA = "0x120D1DC")]
			public <LoadContent_Deferred>d__2022(int <>1__state)
			{
			}

			// Token: 0x060025B6 RID: 9654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025B6")]
			[Address(RVA = "0x120D1F8", Offset = "0x120D1F8", VA = "0x120D1F8", Slot = "5")]
			private void System.IDisposable.Dispose()
			{
			}

			// Token: 0x060025B7 RID: 9655 RVA: 0x00012180 File Offset: 0x00010380
			[Token(Token = "0x60025B7")]
			[Address(RVA = "0x120D1FC", Offset = "0x120D1FC", VA = "0x120D1FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000563 RID: 1379
			// (get) Token: 0x060025B8 RID: 9656 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000563")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60025B8")]
				[Address(RVA = "0x120DA60", Offset = "0x120DA60", VA = "0x120DA60", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060025B9 RID: 9657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025B9")]
			[Address(RVA = "0x120DA68", Offset = "0x120DA68", VA = "0x120DA68", Slot = "8")]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			// Token: 0x17000564 RID: 1380
			// (get) Token: 0x060025BA RID: 9658 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000564")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60025BA")]
				[Address(RVA = "0x120DAB4", Offset = "0x120DAB4", VA = "0x120DAB4", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x040036A4 RID: 13988
			[Token(Token = "0x40036A4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x040036A5 RID: 13989
			[Token(Token = "0x40036A5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x040036A6 RID: 13990
			[Token(Token = "0x40036A6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Main <>4__this;

			// Token: 0x040036A7 RID: 13991
			[Token(Token = "0x40036A7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool <doneLoadingMusic>5__2;

			// Token: 0x040036A8 RID: 13992
			[Token(Token = "0x40036A8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private IEnumerator <musicLoadProcedure>5__3;

			// Token: 0x040036A9 RID: 13993
			[Token(Token = "0x40036A9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private bool <doneinitialLoad>5__4;

			// Token: 0x040036AA RID: 13994
			[Token(Token = "0x40036AA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private IEnumerator <initialLoadProcedure>5__5;
		}

		// Token: 0x0200047A RID: 1146
		[Token(Token = "0x200047A")]
		private sealed class <LoadMusic_InSteps>d__2025 : FileAPI, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x060025BB RID: 9659 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025BB")]
			[Address(RVA = "0x120DABC", Offset = "0x120DABC", VA = "0x120DABC")]
			public <LoadMusic_InSteps>d__2025(int <>1__state)
			{
			}

			// Token: 0x060025BC RID: 9660 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025BC")]
			[Address(RVA = "0x120DAD8", Offset = "0x120DAD8", VA = "0x120DAD8", Slot = "5")]
			private void System.IDisposable.Dispose()
			{
			}

			// Token: 0x060025BD RID: 9661 RVA: 0x00012198 File Offset: 0x00010398
			[Token(Token = "0x60025BD")]
			[Address(RVA = "0x120DADC", Offset = "0x120DADC", VA = "0x120DADC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000565 RID: 1381
			// (get) Token: 0x060025BE RID: 9662 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000565")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60025BE")]
				[Address(RVA = "0x120DD24", Offset = "0x120DD24", VA = "0x120DD24", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060025BF RID: 9663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025BF")]
			[Address(RVA = "0x120DD2C", Offset = "0x120DD2C", VA = "0x120DD2C", Slot = "8")]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			// Token: 0x17000566 RID: 1382
			// (get) Token: 0x060025C0 RID: 9664 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000566")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60025C0")]
				[Address(RVA = "0x120DD78", Offset = "0x120DD78", VA = "0x120DD78", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x040036AB RID: 13995
			[Token(Token = "0x40036AB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x040036AC RID: 13996
			[Token(Token = "0x40036AC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x040036AD RID: 13997
			[Token(Token = "0x40036AD")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <i>5__2;
		}

		// Token: 0x0200047B RID: 1147
		[Token(Token = "0x200047B")]
		private sealed class <>c__DisplayClass2067_0
		{
			// Token: 0x060025C1 RID: 9665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025C1")]
			[Address(RVA = "0x120DD80", Offset = "0x120DD80", VA = "0x120DD80")]
			public <>c__DisplayClass2067_0()
			{
			}

			// Token: 0x060025C2 RID: 9666 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60025C2")]
			[Address(RVA = "0x120DD88", Offset = "0x120DD88", VA = "0x120DD88")]
			internal object <RunOnMainThread>b__0()
			{
				return null;
			}

			// Token: 0x040036AE RID: 13998
			[Token(Token = "0x40036AE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Action action;
		}

		// Token: 0x0200047C RID: 1148
		[Token(Token = "0x200047C")]
		private sealed class <>c__DisplayClass2068_0<T>
		{
			// Token: 0x060025C3 RID: 9667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025C3")]
			public <>c__DisplayClass2068_0()
			{
			}

			// Token: 0x060025C4 RID: 9668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025C4")]
			internal void <RunOnMainThread>b__0()
			{
			}

			// Token: 0x040036AF RID: 13999
			[Token(Token = "0x40036AF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TaskCompletionSource<T> tcs;

			// Token: 0x040036B0 RID: 14000
			[Token(Token = "0x40036B0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T> func;
		}
	}
}
