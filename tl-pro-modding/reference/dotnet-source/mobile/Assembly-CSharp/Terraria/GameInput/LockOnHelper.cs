using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameInput
{
	// Token: 0x0200081D RID: 2077
	[Token(Token = "0x200081D")]
	public class LockOnHelper
	{
		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x060046EC RID: 18156 RVA: 0x00021948 File Offset: 0x0001FB48
		// (set) Token: 0x060046ED RID: 18157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000876")]
		public static LockOnHelper.LockOnMode UseMode
		{
			[Token(Token = "0x60046EC")]
			[Address(RVA = "0x5A7FC8", Offset = "0x5A7FC8", VA = "0x5A7FC8")]
			get
			{
				return LockOnHelper.LockOnMode.FocusTarget;
			}
			[Token(Token = "0x60046ED")]
			[Address(RVA = "0x5A7FF4", Offset = "0x5A7FF4", VA = "0x5A7FF4")]
			set
			{
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x060046EE RID: 18158 RVA: 0x00021960 File Offset: 0x0001FB60
		// (set) Token: 0x060046EF RID: 18159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000877")]
		private static bool _enabled
		{
			[Token(Token = "0x60046EE")]
			[Address(RVA = "0x5A8024", Offset = "0x5A8024", VA = "0x5A8024")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60046EF")]
			[Address(RVA = "0x5A8050", Offset = "0x5A8050", VA = "0x5A8050")]
			set
			{
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x060046F0 RID: 18160 RVA: 0x00021978 File Offset: 0x0001FB78
		// (set) Token: 0x060046F1 RID: 18161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000878")]
		private static bool _canLockOn
		{
			[Token(Token = "0x60046F0")]
			[Address(RVA = "0x5A8080", Offset = "0x5A8080", VA = "0x5A8080")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60046F1")]
			[Address(RVA = "0x5A80AC", Offset = "0x5A80AC", VA = "0x5A80AC")]
			set
			{
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x060046F2 RID: 18162 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060046F3 RID: 18163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000879")]
		private static List<int> _targets
		{
			[Token(Token = "0x60046F2")]
			[Address(RVA = "0x5A80DC", Offset = "0x5A80DC", VA = "0x5A80DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60046F3")]
			[Address(RVA = "0x5A8108", Offset = "0x5A8108", VA = "0x5A8108")]
			set
			{
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x060046F4 RID: 18164 RVA: 0x00021990 File Offset: 0x0001FB90
		// (set) Token: 0x060046F5 RID: 18165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087A")]
		private static int _pickedTarget
		{
			[Token(Token = "0x60046F4")]
			[Address(RVA = "0x5A8138", Offset = "0x5A8138", VA = "0x5A8138")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60046F5")]
			[Address(RVA = "0x5A8164", Offset = "0x5A8164", VA = "0x5A8164")]
			set
			{
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x060046F6 RID: 18166 RVA: 0x000219A8 File Offset: 0x0001FBA8
		// (set) Token: 0x060046F7 RID: 18167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087B")]
		private static int _lifeTimeCounter
		{
			[Token(Token = "0x60046F6")]
			[Address(RVA = "0x5A8194", Offset = "0x5A8194", VA = "0x5A8194")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60046F7")]
			[Address(RVA = "0x5A81C0", Offset = "0x5A81C0", VA = "0x5A81C0")]
			set
			{
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x060046F8 RID: 18168 RVA: 0x000219C0 File Offset: 0x0001FBC0
		// (set) Token: 0x060046F9 RID: 18169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087C")]
		private static int _lifeTimeArrowDisplay
		{
			[Token(Token = "0x60046F8")]
			[Address(RVA = "0x5A81F0", Offset = "0x5A81F0", VA = "0x5A81F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60046F9")]
			[Address(RVA = "0x5A821C", Offset = "0x5A821C", VA = "0x5A821C")]
			set
			{
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x060046FA RID: 18170 RVA: 0x000219D8 File Offset: 0x0001FBD8
		// (set) Token: 0x060046FB RID: 18171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087D")]
		private static int _threeDSTarget
		{
			[Token(Token = "0x60046FA")]
			[Address(RVA = "0x5A824C", Offset = "0x5A824C", VA = "0x5A824C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60046FB")]
			[Address(RVA = "0x5A8278", Offset = "0x5A8278", VA = "0x5A8278")]
			set
			{
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x060046FC RID: 18172 RVA: 0x000219F0 File Offset: 0x0001FBF0
		// (set) Token: 0x060046FD RID: 18173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087E")]
		private static int _targetClosestTarget
		{
			[Token(Token = "0x60046FC")]
			[Address(RVA = "0x5A82A8", Offset = "0x5A82A8", VA = "0x5A82A8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60046FD")]
			[Address(RVA = "0x5A82D4", Offset = "0x5A82D4", VA = "0x5A82D4")]
			set
			{
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x060046FE RID: 18174 RVA: 0x00021A08 File Offset: 0x0001FC08
		// (set) Token: 0x060046FF RID: 18175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087F")]
		public static bool ForceUsability
		{
			[Token(Token = "0x60046FE")]
			[Address(RVA = "0x5A8304", Offset = "0x5A8304", VA = "0x5A8304")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60046FF")]
			[Address(RVA = "0x5A8330", Offset = "0x5A8330", VA = "0x5A8330")]
			set
			{
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06004700 RID: 18176 RVA: 0x00021A20 File Offset: 0x0001FC20
		// (set) Token: 0x06004701 RID: 18177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000880")]
		public static bool LockOnAvailable
		{
			[Token(Token = "0x6004700")]
			[Address(RVA = "0x5A8360", Offset = "0x5A8360", VA = "0x5A8360")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004701")]
			[Address(RVA = "0x5A838C", Offset = "0x5A838C", VA = "0x5A838C")]
			set
			{
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06004702 RID: 18178 RVA: 0x00021A38 File Offset: 0x0001FC38
		// (set) Token: 0x06004703 RID: 18179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000881")]
		private static int _lastFrame
		{
			[Token(Token = "0x6004702")]
			[Address(RVA = "0x5A83BC", Offset = "0x5A83BC", VA = "0x5A83BC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004703")]
			[Address(RVA = "0x5A83E8", Offset = "0x5A83E8", VA = "0x5A83E8")]
			set
			{
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06004704 RID: 18180 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004705 RID: 18181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000882")]
		private static float[,] _drawProgress
		{
			[Token(Token = "0x6004704")]
			[Address(RVA = "0x5A8418", Offset = "0x5A8418", VA = "0x5A8418")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004705")]
			[Address(RVA = "0x5A8444", Offset = "0x5A8444", VA = "0x5A8444")]
			set
			{
			}
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004706")]
		[Address(RVA = "0x5A8474", Offset = "0x5A8474", VA = "0x5A8474")]
		public static void CycleUseModes()
		{
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06004707 RID: 18183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000883")]
		public static NPC AimedTarget
		{
			[Token(Token = "0x6004707")]
			[Address(RVA = "0x5A8568", Offset = "0x5A8568", VA = "0x5A8568")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06004708 RID: 18184 RVA: 0x00021A50 File Offset: 0x0001FC50
		[Token(Token = "0x17000884")]
		public static Vector2 PredictedPosition
		{
			[Token(Token = "0x6004708")]
			[Address(RVA = "0x5A872C", Offset = "0x5A872C", VA = "0x5A872C")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004709")]
		[Address(RVA = "0x5A8FC8", Offset = "0x5A8FC8", VA = "0x5A8FC8")]
		public static void Update()
		{
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x00021A68 File Offset: 0x0001FC68
		[Token(Token = "0x600470A")]
		[Address(RVA = "0x5A9AEC", Offset = "0x5A9AEC", VA = "0x5A9AEC")]
		public static bool CanUseLockonSystem()
		{
			return default(bool);
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470B")]
		[Address(RVA = "0x5AA3E8", Offset = "0x5AA3E8", VA = "0x5AA3E8")]
		public static void SetUP()
		{
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470C")]
		[Address(RVA = "0x5AA6D8", Offset = "0x5AA6D8", VA = "0x5AA6D8")]
		public static void SetDOWN()
		{
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x00021A80 File Offset: 0x0001FC80
		[Token(Token = "0x600470D")]
		[Address(RVA = "0x5AA310", Offset = "0x5AA310", VA = "0x5AA310")]
		private static bool ShouldLockOn(Player p)
		{
			return default(bool);
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470E")]
		[Address(RVA = "0x5AA8BC", Offset = "0x5AA8BC", VA = "0x5AA8BC")]
		public static void Toggle(bool forceOff = false)
		{
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x0600470F RID: 18191 RVA: 0x00021A98 File Offset: 0x0001FC98
		[Token(Token = "0x17000885")]
		public static bool Enabled
		{
			[Token(Token = "0x600470F")]
			[Address(RVA = "0x5AA9A0", Offset = "0x5AA9A0", VA = "0x5AA9A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06004710 RID: 18192 RVA: 0x00021AB0 File Offset: 0x0001FCB0
		[Token(Token = "0x17000886")]
		public static Vector2 MouseWorld
		{
			[Token(Token = "0x6004710")]
			[Address(RVA = "0x5AAA1C", Offset = "0x5AAA1C", VA = "0x5AAA1C")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004711")]
		[Address(RVA = "0x5A9DAC", Offset = "0x5A9DAC", VA = "0x5A9DAC")]
		private static void FindMostViableTarget(LockOnHelper.LockOnMode context, ref int targetVar)
		{
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004712")]
		[Address(RVA = "0x5AA084", Offset = "0x5AA084", VA = "0x5AA084")]
		private static void HandlePressing()
		{
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004713")]
		[Address(RVA = "0x5ABE40", Offset = "0x5ABE40", VA = "0x5ABE40")]
		private static void CycleTargetFocus()
		{
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004714")]
		[Address(RVA = "0x5ABBD0", Offset = "0x5ABBD0", VA = "0x5ABBD0")]
		private static void CycleTargetThreeDS()
		{
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x00021AC8 File Offset: 0x0001FCC8
		[Token(Token = "0x6004715")]
		[Address(RVA = "0x5AA274", Offset = "0x5AA274", VA = "0x5AA274")]
		private static bool CanEnable()
		{
			return default(bool);
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004716")]
		[Address(RVA = "0x5A9AF4", Offset = "0x5A9AF4", VA = "0x5A9AF4")]
		private static void SetActive(bool on)
		{
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004717")]
		[Address(RVA = "0x5AABDC", Offset = "0x5AABDC", VA = "0x5AABDC")]
		private static void RefreshTargets(Vector2 position, float radius)
		{
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004718")]
		[Address(RVA = "0x5AB4E4", Offset = "0x5AB4E4", VA = "0x5AB4E4")]
		private static void GetClosestTarget(Vector2 position)
		{
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x00021AE0 File Offset: 0x0001FCE0
		[Token(Token = "0x6004719")]
		[Address(RVA = "0x5AA1CC", Offset = "0x5AA1CC", VA = "0x5AA1CC")]
		private static bool ValidTarget(NPC n)
		{
			return default(bool);
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600471A")]
		[Address(RVA = "0x5AA548", Offset = "0x5AA548", VA = "0x5AA548")]
		private static void SetLockPosition(Vector2 position)
		{
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600471B")]
		[Address(RVA = "0x5AA778", Offset = "0x5AA778", VA = "0x5AA778")]
		private static void ResetLockPosition()
		{
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600471C")]
		[Address(RVA = "0x5AC620", Offset = "0x5AC620", VA = "0x5AC620")]
		public static void Draw(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600471D")]
		[Address(RVA = "0x5ADD00", Offset = "0x5ADD00", VA = "0x5ADD00")]
		public LockOnHelper()
		{
		}

		// Token: 0x04008DCE RID: 36302
		[Token(Token = "0x4008DCE")]
		private const float LOCKON_RANGE = 2000f;

		// Token: 0x04008DCF RID: 36303
		[Token(Token = "0x4008DCF")]
		private const int LOCKON_HOLD_LIFETIME = 40;

		// Token: 0x04008DD0 RID: 36304
		[Token(Token = "0x4008DD0")]
		[FieldOffset(Offset = "0x0")]
		private static List<int> tempTargets;

		// Token: 0x0200081E RID: 2078
		[Token(Token = "0x200081E")]
		public enum LockOnMode
		{
			// Token: 0x04008DD2 RID: 36306
			[Token(Token = "0x4008DD2")]
			FocusTarget,
			// Token: 0x04008DD3 RID: 36307
			[Token(Token = "0x4008DD3")]
			TargetClosest,
			// Token: 0x04008DD4 RID: 36308
			[Token(Token = "0x4008DD4")]
			ThreeDS
		}
	}
}
