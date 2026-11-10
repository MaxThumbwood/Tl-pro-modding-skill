using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000CFF RID: 3327
	[Token(Token = "0x2000CFF")]
	public class CreativePowers
	{
		// Token: 0x06006245 RID: 25157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006245")]
		[Address(RVA = "0xAE52E8", Offset = "0xAE52E8", VA = "0xAE52E8")]
		public CreativePowers()
		{
		}

		// Token: 0x02000D00 RID: 3328
		[Token(Token = "0x2000D00")]
		public abstract class APerPlayerTogglePower : FileAPI, GUIControllerItem
		{
			// Token: 0x17000A9C RID: 2716
			// (get) Token: 0x06006246 RID: 25158 RVA: 0x0002D450 File Offset: 0x0002B650
			// (set) Token: 0x06006247 RID: 25159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A9C")]
			public ushort PowerId
			{
				[Token(Token = "0x6006246")]
				[Address(RVA = "0xAE52F0", Offset = "0xAE52F0", VA = "0xAE52F0", Slot = "4")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6006247")]
				[Address(RVA = "0xAE52F8", Offset = "0xAE52F8", VA = "0xAE52F8", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000A9D RID: 2717
			// (get) Token: 0x06006248 RID: 25160 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06006249 RID: 25161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A9D")]
			public string ServerConfigName
			{
				[Token(Token = "0x6006248")]
				[Address(RVA = "0xAE5300", Offset = "0xAE5300", VA = "0xAE5300", Slot = "6")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006249")]
				[Address(RVA = "0xAE5308", Offset = "0xAE5308", VA = "0xAE5308", Slot = "7")]
				set
				{
				}
			}

			// Token: 0x17000A9E RID: 2718
			// (get) Token: 0x0600624A RID: 25162 RVA: 0x0002D468 File Offset: 0x0002B668
			// (set) Token: 0x0600624B RID: 25163 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A9E")]
			public PowerPermissionLevel CurrentPermissionLevel
			{
				[Token(Token = "0x600624A")]
				[Address(RVA = "0xAE5310", Offset = "0xAE5310", VA = "0xAE5310", Slot = "8")]
				get
				{
					return PowerPermissionLevel.LockedForEveryone;
				}
				[Token(Token = "0x600624B")]
				[Address(RVA = "0xAE5318", Offset = "0xAE5318", VA = "0xAE5318", Slot = "9")]
				set
				{
				}
			}

			// Token: 0x17000A9F RID: 2719
			// (get) Token: 0x0600624C RID: 25164 RVA: 0x0002D480 File Offset: 0x0002B680
			// (set) Token: 0x0600624D RID: 25165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A9F")]
			public PowerPermissionLevel DefaultPermissionLevel
			{
				[Token(Token = "0x600624C")]
				[Address(RVA = "0xAE5320", Offset = "0xAE5320", VA = "0xAE5320", Slot = "10")]
				get
				{
					return PowerPermissionLevel.LockedForEveryone;
				}
				[Token(Token = "0x600624D")]
				[Address(RVA = "0xAE5328", Offset = "0xAE5328", VA = "0xAE5328", Slot = "11")]
				set
				{
				}
			}

			// Token: 0x0600624E RID: 25166 RVA: 0x0002D498 File Offset: 0x0002B698
			[Token(Token = "0x600624E")]
			[Address(RVA = "0xAE5330", Offset = "0xAE5330", VA = "0xAE5330")]
			public bool IsEnabledForPlayer(int playerIndex)
			{
				return default(bool);
			}

			// Token: 0x0600624F RID: 25167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600624F")]
			[Address(RVA = "0xAE53F0", Offset = "0xAE53F0", VA = "0xAE53F0", Slot = "12")]
			public void DeserializeNetMessage(BinaryReader reader, int userId)
			{
			}

			// Token: 0x06006250 RID: 25168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006250")]
			[Address(RVA = "0xAE5538", Offset = "0xAE5538", VA = "0xAE5538")]
			private void Deserialize_SyncEveryone(BinaryReader reader, int userId)
			{
			}

			// Token: 0x06006251 RID: 25169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006251")]
			[Address(RVA = "0xAE5790", Offset = "0xAE5790", VA = "0xAE5790")]
			public void SetEnabledState(int playerIndex, bool state)
			{
			}

			// Token: 0x06006252 RID: 25170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006252")]
			[Address(RVA = "0xAE599C", Offset = "0xAE599C", VA = "0xAE599C")]
			public void DebugCall()
			{
			}

			// Token: 0x06006253 RID: 25171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006253")]
			[Address(RVA = "0xAE59A0", Offset = "0xAE59A0", VA = "0xAE59A0")]
			internal void RequestUse()
			{
			}

			// Token: 0x06006254 RID: 25172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006254")]
			[Address(RVA = "0xAE5BA8", Offset = "0xAE5BA8", VA = "0xAE5BA8", Slot = "16")]
			public void Reset()
			{
			}

			// Token: 0x06006255 RID: 25173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006255")]
			[Address(RVA = "0xAE5BFC", Offset = "0xAE5BFC", VA = "0xAE5BFC", Slot = "15")]
			public void OnPlayerJoining(int playerIndex)
			{
			}

			// Token: 0x06006256 RID: 25174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006256")]
			[Address(RVA = "0xAE5EA4", Offset = "0xAE5EA4", VA = "0xAE5EA4", Slot = "13")]
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
			}

			// Token: 0x06006257 RID: 25175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006257")]
			[Address(RVA = "0xAE6124", Offset = "0xAE6124", VA = "0xAE6124")]
			private void button_OnUpdate(UIElement affectedElement)
			{
			}

			// Token: 0x06006258 RID: 25176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006258")]
			[Address(RVA = "0xAE6450", Offset = "0xAE6450", VA = "0xAE6450")]
			private void button_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06006259 RID: 25177
			[Token(Token = "0x6006259")]
			public abstract bool GetIsUnlocked();

			// Token: 0x0600625A RID: 25178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600625A")]
			[Address(RVA = "0xAE6528", Offset = "0xAE6528", VA = "0xAE6528")]
			protected APerPlayerTogglePower()
			{
			}

			// Token: 0x0400A077 RID: 41079
			[Token(Token = "0x400A077")]
			[FieldOffset(Offset = "0x8")]
			private ushort <PowerId>k__BackingField;

			// Token: 0x0400A078 RID: 41080
			[Token(Token = "0x400A078")]
			[FieldOffset(Offset = "0xC")]
			private string <ServerConfigName>k__BackingField;

			// Token: 0x0400A079 RID: 41081
			[Token(Token = "0x400A079")]
			[FieldOffset(Offset = "0x10")]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			// Token: 0x0400A07A RID: 41082
			[Token(Token = "0x400A07A")]
			[FieldOffset(Offset = "0x14")]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			// Token: 0x0400A07B RID: 41083
			[Token(Token = "0x400A07B")]
			[FieldOffset(Offset = "0x18")]
			internal string _powerNameKey;

			// Token: 0x0400A07C RID: 41084
			[Token(Token = "0x400A07C")]
			[FieldOffset(Offset = "0x1C")]
			internal Point _iconLocation;

			// Token: 0x0400A07D RID: 41085
			[Token(Token = "0x400A07D")]
			[FieldOffset(Offset = "0x24")]
			internal bool _defaultToggleState;

			// Token: 0x0400A07E RID: 41086
			[Token(Token = "0x400A07E")]
			[FieldOffset(Offset = "0x28")]
			private bool[] _perPlayerIsEnabled;

			// Token: 0x02000D01 RID: 3329
			[Token(Token = "0x2000D01")]
			private enum SubMessageType : byte
			{
				// Token: 0x0400A080 RID: 41088
				[Token(Token = "0x400A080")]
				SyncEveryone,
				// Token: 0x0400A081 RID: 41089
				[Token(Token = "0x400A081")]
				SyncOnePlayer
			}
		}

		// Token: 0x02000D02 RID: 3330
		[Token(Token = "0x2000D02")]
		public abstract class APerPlayerSliderPower : FileAPI, GUIControllerItem, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x17000AA0 RID: 2720
			// (get) Token: 0x0600625B RID: 25179 RVA: 0x0002D4B0 File Offset: 0x0002B6B0
			// (set) Token: 0x0600625C RID: 25180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AA0")]
			public ushort PowerId
			{
				[Token(Token = "0x600625B")]
				[Address(RVA = "0xAE658C", Offset = "0xAE658C", VA = "0xAE658C", Slot = "4")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600625C")]
				[Address(RVA = "0xAE6594", Offset = "0xAE6594", VA = "0xAE6594", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000AA1 RID: 2721
			// (get) Token: 0x0600625D RID: 25181 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600625E RID: 25182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AA1")]
			public string ServerConfigName
			{
				[Token(Token = "0x600625D")]
				[Address(RVA = "0xAE659C", Offset = "0xAE659C", VA = "0xAE659C", Slot = "6")]
				get
				{
					return null;
				}
				[Token(Token = "0x600625E")]
				[Address(RVA = "0xAE65A4", Offset = "0xAE65A4", VA = "0xAE65A4", Slot = "7")]
				set
				{
				}
			}

			// Token: 0x17000AA2 RID: 2722
			// (get) Token: 0x0600625F RID: 25183 RVA: 0x0002D4C8 File Offset: 0x0002B6C8
			// (set) Token: 0x06006260 RID: 25184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AA2")]
			public PowerPermissionLevel CurrentPermissionLevel
			{
				[Token(Token = "0x600625F")]
				[Address(RVA = "0xAE65AC", Offset = "0xAE65AC", VA = "0xAE65AC", Slot = "8")]
				get
				{
					return PowerPermissionLevel.LockedForEveryone;
				}
				[Token(Token = "0x6006260")]
				[Address(RVA = "0xAE65B4", Offset = "0xAE65B4", VA = "0xAE65B4", Slot = "9")]
				set
				{
				}
			}

			// Token: 0x17000AA3 RID: 2723
			// (get) Token: 0x06006261 RID: 25185 RVA: 0x0002D4E0 File Offset: 0x0002B6E0
			// (set) Token: 0x06006262 RID: 25186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AA3")]
			public PowerPermissionLevel DefaultPermissionLevel
			{
				[Token(Token = "0x6006261")]
				[Address(RVA = "0xAE65BC", Offset = "0xAE65BC", VA = "0xAE65BC", Slot = "10")]
				get
				{
					return PowerPermissionLevel.LockedForEveryone;
				}
				[Token(Token = "0x6006262")]
				[Address(RVA = "0xAE65C4", Offset = "0xAE65C4", VA = "0xAE65C4", Slot = "11")]
				set
				{
				}
			}

			// Token: 0x06006263 RID: 25187 RVA: 0x0002D4F8 File Offset: 0x0002B6F8
			[Token(Token = "0x6006263")]
			[Address(RVA = "0xAE65CC", Offset = "0xAE65CC", VA = "0xAE65CC")]
			public bool GetRemappedSliderValueFor(int playerIndex, out float value)
			{
				return default(bool);
			}

			// Token: 0x06006264 RID: 25188
			[Token(Token = "0x6006264")]
			public abstract float RemapSliderValueToPowerValue(float sliderValue);

			// Token: 0x06006265 RID: 25189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006265")]
			[Address(RVA = "0xAE66A8", Offset = "0xAE66A8", VA = "0xAE66A8", Slot = "12")]
			public void DeserializeNetMessage(BinaryReader reader, int userId)
			{
			}

			// Token: 0x06006266 RID: 25190
			[Token(Token = "0x6006266")]
			internal abstract void UpdateInfoFromSliderValueCache();

			// Token: 0x06006267 RID: 25191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006267")]
			[Address(RVA = "0xAE6818", Offset = "0xAE6818", VA = "0xAE6818", Slot = "13")]
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
			}

			// Token: 0x06006268 RID: 25192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006268")]
			[Address(RVA = "0xAE6864", Offset = "0xAE6864", VA = "0xAE6864")]
			public void DebugCall()
			{
			}

			// Token: 0x06006269 RID: 25193
			[Token(Token = "0x6006269")]
			public abstract UIElement ProvideSlider();

			// Token: 0x0600626A RID: 25194 RVA: 0x0002D510 File Offset: 0x0002B710
			[Token(Token = "0x600626A")]
			[Address(RVA = "0xAE6A10", Offset = "0xAE6A10", VA = "0xAE6A10")]
			internal float GetSliderValue()
			{
				return 0f;
			}

			// Token: 0x0600626B RID: 25195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600626B")]
			[Address(RVA = "0xAE6A98", Offset = "0xAE6A98", VA = "0xAE6A98")]
			internal void SetValueKeyboard(float value)
			{
			}

			// Token: 0x0600626C RID: 25196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600626C")]
			[Address(RVA = "0xAE6B7C", Offset = "0xAE6B7C", VA = "0xAE6B7C")]
			internal void SetValueGamepad()
			{
			}

			// Token: 0x0600626D RID: 25197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600626D")]
			[Address(RVA = "0xAE6BDC", Offset = "0xAE6BDC", VA = "0xAE6BDC")]
			public void PushChangeAndSetSlider(float value)
			{
			}

			// Token: 0x0600626E RID: 25198 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600626E")]
			[Address(RVA = "0xAE6EC4", Offset = "0xAE6EC4", VA = "0xAE6EC4", Slot = "17")]
			public GroupOptionButton<int> GetOptionButton(CreativePowerUIElementRequestInfo info, int optionIndex, int currentOptionIndex)
			{
				return null;
			}

			// Token: 0x0600626F RID: 25199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600626F")]
			[Address(RVA = "0xAE7040", Offset = "0xAE7040", VA = "0xAE7040")]
			private void categoryButton_OnUpdate(UIElement affectedElement)
			{
			}

			// Token: 0x06006270 RID: 25200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006270")]
			[Address(RVA = "0xAE7324", Offset = "0xAE7324", VA = "0xAE7324")]
			public void AttemptPushingChange()
			{
			}

			// Token: 0x06006271 RID: 25201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006271")]
			[Address(RVA = "0xAE6CB8", Offset = "0xAE6CB8", VA = "0xAE6CB8")]
			internal void PushChange(float newSliderValue)
			{
			}

			// Token: 0x06006272 RID: 25202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006272")]
			[Address(RVA = "0xAE73E0", Offset = "0xAE73E0", VA = "0xAE73E0", Slot = "21")]
			public virtual void Reset()
			{
			}

			// Token: 0x06006273 RID: 25203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006273")]
			[Address(RVA = "0xAE742C", Offset = "0xAE742C", VA = "0xAE742C", Slot = "22")]
			public virtual void ResetForPlayer(int playerIndex)
			{
			}

			// Token: 0x06006274 RID: 25204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006274")]
			[Address(RVA = "0xAE74BC", Offset = "0xAE74BC", VA = "0xAE74BC", Slot = "15")]
			public void OnPlayerJoining(int playerIndex)
			{
			}

			// Token: 0x06006275 RID: 25205
			[Token(Token = "0x6006275")]
			public abstract bool GetIsUnlocked();

			// Token: 0x06006276 RID: 25206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006276")]
			[Address(RVA = "0xAE74CC", Offset = "0xAE74CC", VA = "0xAE74CC")]
			protected APerPlayerSliderPower()
			{
			}

			// Token: 0x0400A082 RID: 41090
			[Token(Token = "0x400A082")]
			[FieldOffset(Offset = "0x8")]
			private ushort <PowerId>k__BackingField;

			// Token: 0x0400A083 RID: 41091
			[Token(Token = "0x400A083")]
			[FieldOffset(Offset = "0xC")]
			private string <ServerConfigName>k__BackingField;

			// Token: 0x0400A084 RID: 41092
			[Token(Token = "0x400A084")]
			[FieldOffset(Offset = "0x10")]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			// Token: 0x0400A085 RID: 41093
			[Token(Token = "0x400A085")]
			[FieldOffset(Offset = "0x14")]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			// Token: 0x0400A086 RID: 41094
			[Token(Token = "0x400A086")]
			[FieldOffset(Offset = "0x18")]
			internal Point _iconLocation;

			// Token: 0x0400A087 RID: 41095
			[Token(Token = "0x400A087")]
			[FieldOffset(Offset = "0x20")]
			internal float _sliderCurrentValueCache;

			// Token: 0x0400A088 RID: 41096
			[Token(Token = "0x400A088")]
			[FieldOffset(Offset = "0x24")]
			internal string _powerNameKey;

			// Token: 0x0400A089 RID: 41097
			[Token(Token = "0x400A089")]
			[FieldOffset(Offset = "0x28")]
			internal float[] _cachePerPlayer;

			// Token: 0x0400A08A RID: 41098
			[Token(Token = "0x400A08A")]
			[FieldOffset(Offset = "0x2C")]
			internal float _sliderDefaultValue;

			// Token: 0x0400A08B RID: 41099
			[Token(Token = "0x400A08B")]
			[FieldOffset(Offset = "0x30")]
			private float _currentTargetValue;

			// Token: 0x0400A08C RID: 41100
			[Token(Token = "0x400A08C")]
			[FieldOffset(Offset = "0x34")]
			private bool _needsToCommitChange;

			// Token: 0x0400A08D RID: 41101
			[Token(Token = "0x400A08D")]
			[FieldOffset(Offset = "0x38")]
			private DateTime _nextTimeWeCanPush;
		}

		// Token: 0x02000D03 RID: 3331
		[Token(Token = "0x2000D03")]
		public abstract class ASharedButtonPower : FileAPI
		{
			// Token: 0x17000AA4 RID: 2724
			// (get) Token: 0x06006277 RID: 25207 RVA: 0x0002D528 File Offset: 0x0002B728
			// (set) Token: 0x06006278 RID: 25208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AA4")]
			public ushort PowerId
			{
				[Token(Token = "0x6006277")]
				[Address(RVA = "0xAE757C", Offset = "0xAE757C", VA = "0xAE757C", Slot = "4")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6006278")]
				[Address(RVA = "0xAE7584", Offset = "0xAE7584", VA = "0xAE7584", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000AA5 RID: 2725
			// (get) Token: 0x06006279 RID: 25209 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600627A RID: 25210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AA5")]
			public string ServerConfigName
			{
				[Token(Token = "0x6006279")]
				[Address(RVA = "0xAE758C", Offset = "0xAE758C", VA = "0xAE758C", Slot = "6")]
				get
				{
					return null;
				}
				[Token(Token = "0x600627A")]
				[Address(RVA = "0xAE7594", Offset = "0xAE7594", VA = "0xAE7594", Slot = "7")]
				set
				{
				}
			}

			// Token: 0x17000AA6 RID: 2726
			// (get) Token: 0x0600627B RID: 25211 RVA: 0x0002D540 File Offset: 0x0002B740
			// (set) Token: 0x0600627C RID: 25212 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AA6")]
			public PowerPermissionLevel CurrentPermissionLevel
			{
				[Token(Token = "0x600627B")]
				[Address(RVA = "0xAE759C", Offset = "0xAE759C", VA = "0xAE759C", Slot = "8")]
				get
				{
					return PowerPermissionLevel.LockedForEveryone;
				}
				[Token(Token = "0x600627C")]
				[Address(RVA = "0xAE75A4", Offset = "0xAE75A4", VA = "0xAE75A4", Slot = "9")]
				set
				{
				}
			}

			// Token: 0x17000AA7 RID: 2727
			// (get) Token: 0x0600627D RID: 25213 RVA: 0x0002D558 File Offset: 0x0002B758
			// (set) Token: 0x0600627E RID: 25214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AA7")]
			public PowerPermissionLevel DefaultPermissionLevel
			{
				[Token(Token = "0x600627D")]
				[Address(RVA = "0xAE75AC", Offset = "0xAE75AC", VA = "0xAE75AC", Slot = "10")]
				get
				{
					return PowerPermissionLevel.LockedForEveryone;
				}
				[Token(Token = "0x600627E")]
				[Address(RVA = "0xAE75B4", Offset = "0xAE75B4", VA = "0xAE75B4", Slot = "11")]
				set
				{
				}
			}

			// Token: 0x0600627F RID: 25215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600627F")]
			[Address(RVA = "0xAE75BC", Offset = "0xAE75BC", VA = "0xAE75BC")]
			public ASharedButtonPower()
			{
			}

			// Token: 0x06006280 RID: 25216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006280")]
			[Address(RVA = "0xAE75E4", Offset = "0xAE75E4", VA = "0xAE75E4")]
			public void RequestUse()
			{
			}

			// Token: 0x06006281 RID: 25217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006281")]
			[Address(RVA = "0xAE76C8", Offset = "0xAE76C8", VA = "0xAE76C8", Slot = "12")]
			public void DeserializeNetMessage(BinaryReader reader, int userId)
			{
			}

			// Token: 0x06006282 RID: 25218
			[Token(Token = "0x6006282")]
			internal abstract void UsePower();

			// Token: 0x06006283 RID: 25219
			[Token(Token = "0x6006283")]
			internal abstract void OnCreation();

			// Token: 0x06006284 RID: 25220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006284")]
			[Address(RVA = "0xAE7794", Offset = "0xAE7794", VA = "0xAE7794", Slot = "13")]
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
			}

			// Token: 0x06006285 RID: 25221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006285")]
			[Address(RVA = "0xAE79E4", Offset = "0xAE79E4", VA = "0xAE79E4")]
			private void button_OnUpdate(UIElement affectedElement)
			{
			}

			// Token: 0x06006286 RID: 25222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006286")]
			[Address(RVA = "0xAE7BB4", Offset = "0xAE7BB4", VA = "0xAE7BB4")]
			private void button_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06006287 RID: 25223
			[Token(Token = "0x6006287")]
			public abstract bool GetIsUnlocked();

			// Token: 0x0400A08E RID: 41102
			[Token(Token = "0x400A08E")]
			[FieldOffset(Offset = "0x8")]
			private ushort <PowerId>k__BackingField;

			// Token: 0x0400A08F RID: 41103
			[Token(Token = "0x400A08F")]
			[FieldOffset(Offset = "0xC")]
			private string <ServerConfigName>k__BackingField;

			// Token: 0x0400A090 RID: 41104
			[Token(Token = "0x400A090")]
			[FieldOffset(Offset = "0x10")]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			// Token: 0x0400A091 RID: 41105
			[Token(Token = "0x400A091")]
			[FieldOffset(Offset = "0x14")]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			// Token: 0x0400A092 RID: 41106
			[Token(Token = "0x400A092")]
			[FieldOffset(Offset = "0x18")]
			internal Point _iconLocation;

			// Token: 0x0400A093 RID: 41107
			[Token(Token = "0x400A093")]
			[FieldOffset(Offset = "0x20")]
			internal string _powerNameKey;

			// Token: 0x0400A094 RID: 41108
			[Token(Token = "0x400A094")]
			[FieldOffset(Offset = "0x24")]
			internal string _descriptionKey;
		}

		// Token: 0x02000D04 RID: 3332
		[Token(Token = "0x2000D04")]
		public abstract class ASharedTogglePower : FileAPI, GUIControllerItem
		{
			// Token: 0x17000AA8 RID: 2728
			// (get) Token: 0x06006288 RID: 25224 RVA: 0x0002D570 File Offset: 0x0002B770
			// (set) Token: 0x06006289 RID: 25225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AA8")]
			public ushort PowerId
			{
				[Token(Token = "0x6006288")]
				[Address(RVA = "0xAE7C6C", Offset = "0xAE7C6C", VA = "0xAE7C6C", Slot = "4")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6006289")]
				[Address(RVA = "0xAE7C74", Offset = "0xAE7C74", VA = "0xAE7C74", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000AA9 RID: 2729
			// (get) Token: 0x0600628A RID: 25226 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600628B RID: 25227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AA9")]
			public string ServerConfigName
			{
				[Token(Token = "0x600628A")]
				[Address(RVA = "0xAE7C7C", Offset = "0xAE7C7C", VA = "0xAE7C7C", Slot = "6")]
				get
				{
					return null;
				}
				[Token(Token = "0x600628B")]
				[Address(RVA = "0xAE7C84", Offset = "0xAE7C84", VA = "0xAE7C84", Slot = "7")]
				set
				{
				}
			}

			// Token: 0x17000AAA RID: 2730
			// (get) Token: 0x0600628C RID: 25228 RVA: 0x0002D588 File Offset: 0x0002B788
			// (set) Token: 0x0600628D RID: 25229 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AAA")]
			public PowerPermissionLevel CurrentPermissionLevel
			{
				[Token(Token = "0x600628C")]
				[Address(RVA = "0xAE7C8C", Offset = "0xAE7C8C", VA = "0xAE7C8C", Slot = "8")]
				get
				{
					return PowerPermissionLevel.LockedForEveryone;
				}
				[Token(Token = "0x600628D")]
				[Address(RVA = "0xAE7C94", Offset = "0xAE7C94", VA = "0xAE7C94", Slot = "9")]
				set
				{
				}
			}

			// Token: 0x17000AAB RID: 2731
			// (get) Token: 0x0600628E RID: 25230 RVA: 0x0002D5A0 File Offset: 0x0002B7A0
			// (set) Token: 0x0600628F RID: 25231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AAB")]
			public PowerPermissionLevel DefaultPermissionLevel
			{
				[Token(Token = "0x600628E")]
				[Address(RVA = "0xAE7C9C", Offset = "0xAE7C9C", VA = "0xAE7C9C", Slot = "10")]
				get
				{
					return PowerPermissionLevel.LockedForEveryone;
				}
				[Token(Token = "0x600628F")]
				[Address(RVA = "0xAE7CA4", Offset = "0xAE7CA4", VA = "0xAE7CA4", Slot = "11")]
				set
				{
				}
			}

			// Token: 0x17000AAC RID: 2732
			// (get) Token: 0x06006290 RID: 25232 RVA: 0x0002D5B8 File Offset: 0x0002B7B8
			// (set) Token: 0x06006291 RID: 25233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AAC")]
			public bool Enabled
			{
				[Token(Token = "0x6006290")]
				[Address(RVA = "0xAE7CAC", Offset = "0xAE7CAC", VA = "0xAE7CAC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6006291")]
				[Address(RVA = "0xAE7CB4", Offset = "0xAE7CB4", VA = "0xAE7CB4")]
				private set
				{
				}
			}

			// Token: 0x06006292 RID: 25234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006292")]
			[Address(RVA = "0xAE7CBC", Offset = "0xAE7CBC", VA = "0xAE7CBC")]
			public void SetPowerInfo(bool enabled)
			{
			}

			// Token: 0x06006293 RID: 25235 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006293")]
			[Address(RVA = "0xAE7CC4", Offset = "0xAE7CC4", VA = "0xAE7CC4", Slot = "16")]
			public void Reset()
			{
			}

			// Token: 0x06006294 RID: 25236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006294")]
			[Address(RVA = "0xAE7CD0", Offset = "0xAE7CD0", VA = "0xAE7CD0", Slot = "15")]
			public void OnPlayerJoining(int playerIndex)
			{
			}

			// Token: 0x06006295 RID: 25237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006295")]
			[Address(RVA = "0xAE7E20", Offset = "0xAE7E20", VA = "0xAE7E20", Slot = "12")]
			public void DeserializeNetMessage(BinaryReader reader, int userId)
			{
			}

			// Token: 0x06006296 RID: 25238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006296")]
			[Address(RVA = "0xAE804C", Offset = "0xAE804C", VA = "0xAE804C")]
			public void RequestUse()
			{
			}

			// Token: 0x06006297 RID: 25239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006297")]
			[Address(RVA = "0xAE8190", Offset = "0xAE8190", VA = "0xAE8190", Slot = "13")]
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
			}

			// Token: 0x06006298 RID: 25240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006298")]
			[Address(RVA = "0xAE83F8", Offset = "0xAE83F8", VA = "0xAE83F8")]
			private void button_OnUpdate(UIElement affectedElement)
			{
			}

			// Token: 0x06006299 RID: 25241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006299")]
			[Address(RVA = "0xAE8708", Offset = "0xAE8708", VA = "0xAE8708")]
			private void button_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x0600629A RID: 25242
			[Token(Token = "0x600629A")]
			internal abstract void CustomizeButton(UIElement button);

			// Token: 0x0600629B RID: 25243
			[Token(Token = "0x600629B")]
			internal abstract string GetButtonTextKey();

			// Token: 0x0600629C RID: 25244
			[Token(Token = "0x600629C")]
			public abstract bool GetIsUnlocked();

			// Token: 0x0600629D RID: 25245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600629D")]
			[Address(RVA = "0xAE87C0", Offset = "0xAE87C0", VA = "0xAE87C0")]
			protected ASharedTogglePower()
			{
			}

			// Token: 0x0400A095 RID: 41109
			[Token(Token = "0x400A095")]
			[FieldOffset(Offset = "0x8")]
			private ushort <PowerId>k__BackingField;

			// Token: 0x0400A096 RID: 41110
			[Token(Token = "0x400A096")]
			[FieldOffset(Offset = "0xC")]
			private string <ServerConfigName>k__BackingField;

			// Token: 0x0400A097 RID: 41111
			[Token(Token = "0x400A097")]
			[FieldOffset(Offset = "0x10")]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			// Token: 0x0400A098 RID: 41112
			[Token(Token = "0x400A098")]
			[FieldOffset(Offset = "0x14")]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			// Token: 0x0400A099 RID: 41113
			[Token(Token = "0x400A099")]
			[FieldOffset(Offset = "0x18")]
			private bool <Enabled>k__BackingField;
		}

		// Token: 0x02000D05 RID: 3333
		[Token(Token = "0x2000D05")]
		public abstract class ASharedSliderPower : FileAPI, GUIControllerItem, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x17000AAD RID: 2733
			// (get) Token: 0x0600629E RID: 25246 RVA: 0x0002D5D0 File Offset: 0x0002B7D0
			// (set) Token: 0x0600629F RID: 25247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AAD")]
			public ushort PowerId
			{
				[Token(Token = "0x600629E")]
				[Address(RVA = "0xAE87C8", Offset = "0xAE87C8", VA = "0xAE87C8", Slot = "4")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600629F")]
				[Address(RVA = "0xAE87D0", Offset = "0xAE87D0", VA = "0xAE87D0", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000AAE RID: 2734
			// (get) Token: 0x060062A0 RID: 25248 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060062A1 RID: 25249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AAE")]
			public string ServerConfigName
			{
				[Token(Token = "0x60062A0")]
				[Address(RVA = "0xAE87D8", Offset = "0xAE87D8", VA = "0xAE87D8", Slot = "6")]
				get
				{
					return null;
				}
				[Token(Token = "0x60062A1")]
				[Address(RVA = "0xAE87E0", Offset = "0xAE87E0", VA = "0xAE87E0", Slot = "7")]
				set
				{
				}
			}

			// Token: 0x17000AAF RID: 2735
			// (get) Token: 0x060062A2 RID: 25250 RVA: 0x0002D5E8 File Offset: 0x0002B7E8
			// (set) Token: 0x060062A3 RID: 25251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AAF")]
			public PowerPermissionLevel CurrentPermissionLevel
			{
				[Token(Token = "0x60062A2")]
				[Address(RVA = "0xAE87E8", Offset = "0xAE87E8", VA = "0xAE87E8", Slot = "8")]
				get
				{
					return PowerPermissionLevel.LockedForEveryone;
				}
				[Token(Token = "0x60062A3")]
				[Address(RVA = "0xAE87F0", Offset = "0xAE87F0", VA = "0xAE87F0", Slot = "9")]
				set
				{
				}
			}

			// Token: 0x17000AB0 RID: 2736
			// (get) Token: 0x060062A4 RID: 25252 RVA: 0x0002D600 File Offset: 0x0002B800
			// (set) Token: 0x060062A5 RID: 25253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AB0")]
			public PowerPermissionLevel DefaultPermissionLevel
			{
				[Token(Token = "0x60062A4")]
				[Address(RVA = "0xAE87F8", Offset = "0xAE87F8", VA = "0xAE87F8", Slot = "10")]
				get
				{
					return PowerPermissionLevel.LockedForEveryone;
				}
				[Token(Token = "0x60062A5")]
				[Address(RVA = "0xAE8800", Offset = "0xAE8800", VA = "0xAE8800", Slot = "11")]
				set
				{
				}
			}

			// Token: 0x060062A6 RID: 25254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062A6")]
			[Address(RVA = "0xAE8808", Offset = "0xAE8808", VA = "0xAE8808", Slot = "12")]
			public void DeserializeNetMessage(BinaryReader reader, int userId)
			{
			}

			// Token: 0x060062A7 RID: 25255
			[Token(Token = "0x60062A7")]
			internal abstract void UpdateInfoFromSliderValueCache();

			// Token: 0x060062A8 RID: 25256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062A8")]
			[Address(RVA = "0xAE8A40", Offset = "0xAE8A40", VA = "0xAE8A40", Slot = "13")]
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
			}

			// Token: 0x060062A9 RID: 25257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062A9")]
			[Address(RVA = "0xAE8A8C", Offset = "0xAE8A8C", VA = "0xAE8A8C")]
			public void DebugCall()
			{
			}

			// Token: 0x060062AA RID: 25258
			[Token(Token = "0x60062AA")]
			public abstract UIElement ProvideSlider();

			// Token: 0x060062AB RID: 25259 RVA: 0x0002D618 File Offset: 0x0002B818
			[Token(Token = "0x60062AB")]
			[Address(RVA = "0xAE8BC8", Offset = "0xAE8BC8", VA = "0xAE8BC8")]
			internal float GetSliderValue()
			{
				return 0f;
			}

			// Token: 0x060062AC RID: 25260 RVA: 0x0002D630 File Offset: 0x0002B830
			[Token(Token = "0x60062AC")]
			[Address(RVA = "0xAE8C58", Offset = "0xAE8C58", VA = "0xAE8C58", Slot = "20")]
			internal virtual float GetSliderValueInner()
			{
				return 0f;
			}

			// Token: 0x060062AD RID: 25261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062AD")]
			[Address(RVA = "0xAE8C60", Offset = "0xAE8C60", VA = "0xAE8C60")]
			internal void SetValueKeyboard(float value)
			{
			}

			// Token: 0x060062AE RID: 25262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062AE")]
			[Address(RVA = "0xAE8CC8", Offset = "0xAE8CC8", VA = "0xAE8CC8")]
			internal void SetValueKeyboardForced(float value)
			{
			}

			// Token: 0x060062AF RID: 25263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062AF")]
			[Address(RVA = "0xAE8D88", Offset = "0xAE8D88", VA = "0xAE8D88")]
			internal void SetValueGamepad()
			{
			}

			// Token: 0x060062B0 RID: 25264 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60062B0")]
			[Address(RVA = "0xAE8E14", Offset = "0xAE8E14", VA = "0xAE8E14", Slot = "17")]
			public GroupOptionButton<int> GetOptionButton(CreativePowerUIElementRequestInfo info, int optionIndex, int currentOptionIndex)
			{
				return null;
			}

			// Token: 0x060062B1 RID: 25265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062B1")]
			[Address(RVA = "0xAE8F90", Offset = "0xAE8F90", VA = "0xAE8F90")]
			private void categoryButton_OnUpdate(UIElement affectedElement)
			{
			}

			// Token: 0x060062B2 RID: 25266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062B2")]
			[Address(RVA = "0xAE9274", Offset = "0xAE9274", VA = "0xAE9274")]
			public void AttemptPushingChange()
			{
			}

			// Token: 0x060062B3 RID: 25267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062B3")]
			[Address(RVA = "0xAE9478", Offset = "0xAE9478", VA = "0xAE9478", Slot = "21")]
			public virtual void Reset()
			{
			}

			// Token: 0x060062B4 RID: 25268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062B4")]
			[Address(RVA = "0xAE9484", Offset = "0xAE9484", VA = "0xAE9484", Slot = "15")]
			public void OnPlayerJoining(int playerIndex)
			{
			}

			// Token: 0x060062B5 RID: 25269
			[Token(Token = "0x60062B5")]
			public abstract bool GetIsUnlocked();

			// Token: 0x060062B6 RID: 25270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062B6")]
			[Address(RVA = "0xAE95E0", Offset = "0xAE95E0", VA = "0xAE95E0")]
			protected ASharedSliderPower()
			{
			}

			// Token: 0x0400A09A RID: 41114
			[Token(Token = "0x400A09A")]
			[FieldOffset(Offset = "0x8")]
			private ushort <PowerId>k__BackingField;

			// Token: 0x0400A09B RID: 41115
			[Token(Token = "0x400A09B")]
			[FieldOffset(Offset = "0xC")]
			private string <ServerConfigName>k__BackingField;

			// Token: 0x0400A09C RID: 41116
			[Token(Token = "0x400A09C")]
			[FieldOffset(Offset = "0x10")]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			// Token: 0x0400A09D RID: 41117
			[Token(Token = "0x400A09D")]
			[FieldOffset(Offset = "0x14")]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			// Token: 0x0400A09E RID: 41118
			[Token(Token = "0x400A09E")]
			[FieldOffset(Offset = "0x18")]
			internal Point _iconLocation;

			// Token: 0x0400A09F RID: 41119
			[Token(Token = "0x400A09F")]
			[FieldOffset(Offset = "0x20")]
			internal float _sliderCurrentValueCache;

			// Token: 0x0400A0A0 RID: 41120
			[Token(Token = "0x400A0A0")]
			[FieldOffset(Offset = "0x24")]
			internal string _powerNameKey;

			// Token: 0x0400A0A1 RID: 41121
			[Token(Token = "0x400A0A1")]
			[FieldOffset(Offset = "0x28")]
			internal bool _syncToJoiningPlayers;

			// Token: 0x0400A0A2 RID: 41122
			[Token(Token = "0x400A0A2")]
			[FieldOffset(Offset = "0x2C")]
			internal float _currentTargetValue;

			// Token: 0x0400A0A3 RID: 41123
			[Token(Token = "0x400A0A3")]
			[FieldOffset(Offset = "0x30")]
			private bool _needsToCommitChange;

			// Token: 0x0400A0A4 RID: 41124
			[Token(Token = "0x400A0A4")]
			[FieldOffset(Offset = "0x38")]
			private DateTime _nextTimeWeCanPush;
		}

		// Token: 0x02000D06 RID: 3334
		[Token(Token = "0x2000D06")]
		public class GodmodePower : CreativePowers.APerPlayerTogglePower, FileAPI
		{
			// Token: 0x060062B7 RID: 25271 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062B7")]
			[Address(RVA = "0xAE966C", Offset = "0xAE966C", VA = "0xAE966C")]
			public GodmodePower()
			{
			}

			// Token: 0x060062B8 RID: 25272 RVA: 0x0002D648 File Offset: 0x0002B848
			[Token(Token = "0x60062B8")]
			[Address(RVA = "0xAE975C", Offset = "0xAE975C", VA = "0xAE975C", Slot = "17")]
			public override bool GetIsUnlocked()
			{
				return default(bool);
			}

			// Token: 0x060062B9 RID: 25273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062B9")]
			[Address(RVA = "0xAE9764", Offset = "0xAE9764", VA = "0xAE9764", Slot = "18")]
			public void Save(Player player, BinaryWriter writer)
			{
			}

			// Token: 0x060062BA RID: 25274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062BA")]
			[Address(RVA = "0xAE98A0", Offset = "0xAE98A0", VA = "0xAE98A0", Slot = "21")]
			public void ResetDataForNewPlayer(Player player)
			{
			}

			// Token: 0x060062BB RID: 25275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062BB")]
			[Address(RVA = "0xAE98DC", Offset = "0xAE98DC", VA = "0xAE98DC", Slot = "19")]
			public void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x060062BC RID: 25276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062BC")]
			[Address(RVA = "0xAE9938", Offset = "0xAE9938", VA = "0xAE9938", Slot = "20")]
			public void ApplyLoadedDataToOutOfPlayerFields(Player player)
			{
			}
		}

		// Token: 0x02000D07 RID: 3335
		[Token(Token = "0x2000D07")]
		public class FarPlacementRangePower : CreativePowers.APerPlayerTogglePower, FileAPI
		{
			// Token: 0x060062BD RID: 25277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062BD")]
			[Address(RVA = "0xAE9A2C", Offset = "0xAE9A2C", VA = "0xAE9A2C")]
			public FarPlacementRangePower()
			{
			}

			// Token: 0x060062BE RID: 25278 RVA: 0x0002D660 File Offset: 0x0002B860
			[Token(Token = "0x60062BE")]
			[Address(RVA = "0xAE9B58", Offset = "0xAE9B58", VA = "0xAE9B58", Slot = "17")]
			public override bool GetIsUnlocked()
			{
				return default(bool);
			}

			// Token: 0x060062BF RID: 25279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062BF")]
			[Address(RVA = "0xAE9B60", Offset = "0xAE9B60", VA = "0xAE9B60", Slot = "18")]
			public void Save(Player player, BinaryWriter writer)
			{
			}

			// Token: 0x060062C0 RID: 25280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062C0")]
			[Address(RVA = "0xAE9C9C", Offset = "0xAE9C9C", VA = "0xAE9C9C", Slot = "21")]
			public void ResetDataForNewPlayer(Player player)
			{
			}

			// Token: 0x060062C1 RID: 25281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062C1")]
			[Address(RVA = "0xAE9CD8", Offset = "0xAE9CD8", VA = "0xAE9CD8", Slot = "19")]
			public void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x060062C2 RID: 25282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062C2")]
			[Address(RVA = "0xAE9D34", Offset = "0xAE9D34", VA = "0xAE9D34", Slot = "20")]
			public void ApplyLoadedDataToOutOfPlayerFields(Player player)
			{
			}
		}

		// Token: 0x02000D08 RID: 3336
		[Token(Token = "0x2000D08")]
		public class StartDayImmediately : CreativePowers.ASharedButtonPower
		{
			// Token: 0x060062C3 RID: 25283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062C3")]
			[Address(RVA = "0xAE9E28", Offset = "0xAE9E28", VA = "0xAE9E28", Slot = "15")]
			internal override void UsePower()
			{
			}

			// Token: 0x060062C4 RID: 25284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062C4")]
			[Address(RVA = "0xAE9EB4", Offset = "0xAE9EB4", VA = "0xAE9EB4", Slot = "16")]
			internal override void OnCreation()
			{
			}

			// Token: 0x060062C5 RID: 25285 RVA: 0x0002D678 File Offset: 0x0002B878
			[Token(Token = "0x60062C5")]
			[Address(RVA = "0xAE9F78", Offset = "0xAE9F78", VA = "0xAE9F78", Slot = "17")]
			public override bool GetIsUnlocked()
			{
				return default(bool);
			}

			// Token: 0x060062C6 RID: 25286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062C6")]
			[Address(RVA = "0xAE9F80", Offset = "0xAE9F80", VA = "0xAE9F80")]
			public StartDayImmediately()
			{
			}
		}

		// Token: 0x02000D09 RID: 3337
		[Token(Token = "0x2000D09")]
		public class StartNightImmediately : CreativePowers.ASharedButtonPower
		{
			// Token: 0x060062C7 RID: 25287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062C7")]
			[Address(RVA = "0xAE9FA8", Offset = "0xAE9FA8", VA = "0xAE9FA8", Slot = "15")]
			internal override void UsePower()
			{
			}

			// Token: 0x060062C8 RID: 25288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062C8")]
			[Address(RVA = "0xAEA034", Offset = "0xAEA034", VA = "0xAEA034", Slot = "16")]
			internal override void OnCreation()
			{
			}

			// Token: 0x060062C9 RID: 25289 RVA: 0x0002D690 File Offset: 0x0002B890
			[Token(Token = "0x60062C9")]
			[Address(RVA = "0xAEA0F8", Offset = "0xAEA0F8", VA = "0xAEA0F8", Slot = "17")]
			public override bool GetIsUnlocked()
			{
				return default(bool);
			}

			// Token: 0x060062CA RID: 25290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062CA")]
			[Address(RVA = "0xAEA100", Offset = "0xAEA100", VA = "0xAEA100")]
			public StartNightImmediately()
			{
			}
		}

		// Token: 0x02000D0A RID: 3338
		[Token(Token = "0x2000D0A")]
		public class StartNoonImmediately : CreativePowers.ASharedButtonPower
		{
			// Token: 0x060062CB RID: 25291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062CB")]
			[Address(RVA = "0xAEA128", Offset = "0xAEA128", VA = "0xAEA128", Slot = "15")]
			internal override void UsePower()
			{
			}

			// Token: 0x060062CC RID: 25292 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062CC")]
			[Address(RVA = "0xAEA1B4", Offset = "0xAEA1B4", VA = "0xAEA1B4", Slot = "16")]
			internal override void OnCreation()
			{
			}

			// Token: 0x060062CD RID: 25293 RVA: 0x0002D6A8 File Offset: 0x0002B8A8
			[Token(Token = "0x60062CD")]
			[Address(RVA = "0xAEA278", Offset = "0xAEA278", VA = "0xAEA278", Slot = "17")]
			public override bool GetIsUnlocked()
			{
				return default(bool);
			}

			// Token: 0x060062CE RID: 25294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062CE")]
			[Address(RVA = "0xAEA280", Offset = "0xAEA280", VA = "0xAEA280")]
			public StartNoonImmediately()
			{
			}
		}

		// Token: 0x02000D0B RID: 3339
		[Token(Token = "0x2000D0B")]
		public class StartMidnightImmediately : CreativePowers.ASharedButtonPower
		{
			// Token: 0x060062CF RID: 25295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062CF")]
			[Address(RVA = "0xAEA2A8", Offset = "0xAEA2A8", VA = "0xAEA2A8", Slot = "15")]
			internal override void UsePower()
			{
			}

			// Token: 0x060062D0 RID: 25296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062D0")]
			[Address(RVA = "0xAEA334", Offset = "0xAEA334", VA = "0xAEA334", Slot = "16")]
			internal override void OnCreation()
			{
			}

			// Token: 0x060062D1 RID: 25297 RVA: 0x0002D6C0 File Offset: 0x0002B8C0
			[Token(Token = "0x60062D1")]
			[Address(RVA = "0xAEA3F8", Offset = "0xAEA3F8", VA = "0xAEA3F8", Slot = "17")]
			public override bool GetIsUnlocked()
			{
				return default(bool);
			}

			// Token: 0x060062D2 RID: 25298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062D2")]
			[Address(RVA = "0xAEA400", Offset = "0xAEA400", VA = "0xAEA400")]
			public StartMidnightImmediately()
			{
			}
		}

		// Token: 0x02000D0C RID: 3340
		[Token(Token = "0x2000D0C")]
		public class ModifyTimeRate : CreativePowers.ASharedSliderPower, FileAPI
		{
			// Token: 0x17000AB1 RID: 2737
			// (get) Token: 0x060062D3 RID: 25299 RVA: 0x0002D6D8 File Offset: 0x0002B8D8
			// (set) Token: 0x060062D4 RID: 25300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AB1")]
			public int TargetTimeRate
			{
				[Token(Token = "0x60062D3")]
				[Address(RVA = "0xAEA428", Offset = "0xAEA428", VA = "0xAEA428")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60062D4")]
				[Address(RVA = "0xAEA430", Offset = "0xAEA430", VA = "0xAEA430")]
				private set
				{
				}
			}

			// Token: 0x060062D5 RID: 25301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062D5")]
			[Address(RVA = "0xAEA438", Offset = "0xAEA438", VA = "0xAEA438")]
			public ModifyTimeRate()
			{
			}

			// Token: 0x060062D6 RID: 25302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062D6")]
			[Address(RVA = "0xAEA554", Offset = "0xAEA554", VA = "0xAEA554", Slot = "21")]
			public override void Reset()
			{
			}

			// Token: 0x060062D7 RID: 25303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062D7")]
			[Address(RVA = "0xAEA568", Offset = "0xAEA568", VA = "0xAEA568", Slot = "18")]
			internal override void UpdateInfoFromSliderValueCache()
			{
			}

			// Token: 0x060062D8 RID: 25304 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60062D8")]
			[Address(RVA = "0xAEA6F4", Offset = "0xAEA6F4", VA = "0xAEA6F4", Slot = "19")]
			public override UIElement ProvideSlider()
			{
				return null;
			}

			// Token: 0x060062D9 RID: 25305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062D9")]
			[Address(RVA = "0xAEB0A4", Offset = "0xAEB0A4", VA = "0xAEB0A4")]
			private void bottomText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x060062DA RID: 25306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062DA")]
			[Address(RVA = "0xAEB0E0", Offset = "0xAEB0E0", VA = "0xAEB0E0")]
			private void middleText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x060062DB RID: 25307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062DB")]
			[Address(RVA = "0xAEB120", Offset = "0xAEB120", VA = "0xAEB120")]
			private void topText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x060062DC RID: 25308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062DC")]
			[Address(RVA = "0xAEB160", Offset = "0xAEB160", VA = "0xAEB160")]
			private void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x060062DD RID: 25309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062DD")]
			[Address(RVA = "0xAEB24C", Offset = "0xAEB24C", VA = "0xAEB24C")]
			private void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x060062DE RID: 25310 RVA: 0x0002D6F0 File Offset: 0x0002B8F0
			[Token(Token = "0x60062DE")]
			[Address(RVA = "0xAEB338", Offset = "0xAEB338", VA = "0xAEB338", Slot = "22")]
			public override bool GetIsUnlocked()
			{
				return default(bool);
			}

			// Token: 0x060062DF RID: 25311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062DF")]
			[Address(RVA = "0xAEB340", Offset = "0xAEB340", VA = "0xAEB340", Slot = "23")]
			public void Save(BinaryWriter writer)
			{
			}

			// Token: 0x060062E0 RID: 25312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062E0")]
			[Address(RVA = "0xAEB37C", Offset = "0xAEB37C", VA = "0xAEB37C", Slot = "24")]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x060062E1 RID: 25313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062E1")]
			[Address(RVA = "0xAEB3C4", Offset = "0xAEB3C4", VA = "0xAEB3C4", Slot = "25")]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x060062E2 RID: 25314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062E2")]
			[Address(RVA = "0xAEB3F0", Offset = "0xAEB3F0", VA = "0xAEB3F0")]
			private void UpdateMouseOverNoItemText(UIElement affectedElement)
			{
			}

			// Token: 0x060062E3 RID: 25315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062E3")]
			[Address(RVA = "0xAEB4E0", Offset = "0xAEB4E0", VA = "0xAEB4E0")]
			private void UpdateSliderAndShowMultiplierMouseOver(UIElement affectedElement)
			{
			}

			// Token: 0x0400A0A5 RID: 41125
			[Token(Token = "0x400A0A5")]
			[FieldOffset(Offset = "0x40")]
			private int <TargetTimeRate>k__BackingField;
		}

		// Token: 0x02000D0D RID: 3341
		[Token(Token = "0x2000D0D")]
		public class DifficultySliderPower : CreativePowers.ASharedSliderPower, FileAPI
		{
			// Token: 0x17000AB2 RID: 2738
			// (get) Token: 0x060062E4 RID: 25316 RVA: 0x0002D708 File Offset: 0x0002B908
			// (set) Token: 0x060062E5 RID: 25317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AB2")]
			public float StrengthMultiplierToGiveNPCs
			{
				[Token(Token = "0x60062E4")]
				[Address(RVA = "0xAEB644", Offset = "0xAEB644", VA = "0xAEB644")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60062E5")]
				[Address(RVA = "0xAEB64C", Offset = "0xAEB64C", VA = "0xAEB64C")]
				private set
				{
				}
			}

			// Token: 0x060062E6 RID: 25318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062E6")]
			[Address(RVA = "0xAEB654", Offset = "0xAEB654", VA = "0xAEB654")]
			public DifficultySliderPower()
			{
			}

			// Token: 0x060062E7 RID: 25319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062E7")]
			[Address(RVA = "0xAEB770", Offset = "0xAEB770", VA = "0xAEB770", Slot = "21")]
			public override void Reset()
			{
			}

			// Token: 0x060062E8 RID: 25320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062E8")]
			[Address(RVA = "0xAEB788", Offset = "0xAEB788", VA = "0xAEB788", Slot = "18")]
			internal override void UpdateInfoFromSliderValueCache()
			{
			}

			// Token: 0x060062E9 RID: 25321 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60062E9")]
			[Address(RVA = "0xAEB93C", Offset = "0xAEB93C", VA = "0xAEB93C", Slot = "19")]
			public override UIElement ProvideSlider()
			{
				return null;
			}

			// Token: 0x060062EA RID: 25322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062EA")]
			[Address(RVA = "0xAEC3A8", Offset = "0xAEC3A8", VA = "0xAEC3A8")]
			private void Click_Master(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x060062EB RID: 25323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062EB")]
			[Address(RVA = "0xAEC3E8", Offset = "0xAEC3E8", VA = "0xAEC3E8")]
			private void Click_Expert(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x060062EC RID: 25324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062EC")]
			[Address(RVA = "0xAEC42C", Offset = "0xAEC42C", VA = "0xAEC42C")]
			private void Click_Normal(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x060062ED RID: 25325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062ED")]
			[Address(RVA = "0xAEC470", Offset = "0xAEC470", VA = "0xAEC470")]
			private void Click_Journey(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x060062EE RID: 25326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062EE")]
			[Address(RVA = "0xAEC048", Offset = "0xAEC048", VA = "0xAEC048")]
			private static void AddIndication(UIPanel panel, float yAnchor, string indicationText, string iconImagePath, UIElement.ElementEvent updateEvent, UIElement.MouseEvent clickEvent)
			{
			}

			// Token: 0x060062EF RID: 25327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062EF")]
			[Address(RVA = "0xAEC4AC", Offset = "0xAEC4AC", VA = "0xAEC4AC")]
			private static void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x060062F0 RID: 25328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062F0")]
			[Address(RVA = "0xAEC4E4", Offset = "0xAEC4E4", VA = "0xAEC4E4")]
			private static void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x060062F1 RID: 25329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062F1")]
			[Address(RVA = "0xAEC51C", Offset = "0xAEC51C", VA = "0xAEC51C")]
			private void MouseOver_Journey(UIElement affectedElement)
			{
			}

			// Token: 0x060062F2 RID: 25330 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062F2")]
			[Address(RVA = "0xAEC640", Offset = "0xAEC640", VA = "0xAEC640")]
			private void MouseOver_Normal(UIElement affectedElement)
			{
			}

			// Token: 0x060062F3 RID: 25331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062F3")]
			[Address(RVA = "0xAEC764", Offset = "0xAEC764", VA = "0xAEC764")]
			private void MouseOver_Expert(UIElement affectedElement)
			{
			}

			// Token: 0x060062F4 RID: 25332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062F4")]
			[Address(RVA = "0xAEC888", Offset = "0xAEC888", VA = "0xAEC888")]
			private void MouseOver_Master(UIElement affectedElement)
			{
			}

			// Token: 0x060062F5 RID: 25333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062F5")]
			[Address(RVA = "0xAEC9AC", Offset = "0xAEC9AC", VA = "0xAEC9AC")]
			private void UpdateSliderColorAndShowMultiplierMouseOver(UIElement affectedElement)
			{
			}

			// Token: 0x060062F6 RID: 25334 RVA: 0x0002D720 File Offset: 0x0002B920
			[Token(Token = "0x60062F6")]
			[Address(RVA = "0xAECCA4", Offset = "0xAECCA4", VA = "0xAECCA4", Slot = "22")]
			public override bool GetIsUnlocked()
			{
				return default(bool);
			}

			// Token: 0x060062F7 RID: 25335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062F7")]
			[Address(RVA = "0xAECCAC", Offset = "0xAECCAC", VA = "0xAECCAC", Slot = "23")]
			public void Save(BinaryWriter writer)
			{
			}

			// Token: 0x060062F8 RID: 25336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062F8")]
			[Address(RVA = "0xAECCE8", Offset = "0xAECCE8", VA = "0xAECCE8", Slot = "24")]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x060062F9 RID: 25337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062F9")]
			[Address(RVA = "0xAECD30", Offset = "0xAECD30", VA = "0xAECD30", Slot = "25")]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x0400A0A6 RID: 41126
			[Token(Token = "0x400A0A6")]
			[FieldOffset(Offset = "0x40")]
			private float <StrengthMultiplierToGiveNPCs>k__BackingField;
		}

		// Token: 0x02000D0E RID: 3342
		[Token(Token = "0x2000D0E")]
		public class ModifyWindDirectionAndStrength : CreativePowers.ASharedSliderPower
		{
			// Token: 0x060062FA RID: 25338 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062FA")]
			[Address(RVA = "0xAECD5C", Offset = "0xAECD5C", VA = "0xAECD5C")]
			public ModifyWindDirectionAndStrength()
			{
			}

			// Token: 0x060062FB RID: 25339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062FB")]
			[Address(RVA = "0xAECE80", Offset = "0xAECE80", VA = "0xAECE80", Slot = "18")]
			internal override void UpdateInfoFromSliderValueCache()
			{
			}

			// Token: 0x060062FC RID: 25340 RVA: 0x0002D738 File Offset: 0x0002B938
			[Token(Token = "0x60062FC")]
			[Address(RVA = "0xAECF20", Offset = "0xAECF20", VA = "0xAECF20", Slot = "20")]
			internal override float GetSliderValueInner()
			{
				return 0f;
			}

			// Token: 0x060062FD RID: 25341 RVA: 0x0002D750 File Offset: 0x0002B950
			[Token(Token = "0x60062FD")]
			[Address(RVA = "0xAECFF4", Offset = "0xAECFF4", VA = "0xAECFF4", Slot = "22")]
			public override bool GetIsUnlocked()
			{
				return default(bool);
			}

			// Token: 0x060062FE RID: 25342 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60062FE")]
			[Address(RVA = "0xAECFFC", Offset = "0xAECFFC", VA = "0xAECFFC", Slot = "19")]
			public override UIElement ProvideSlider()
			{
				return null;
			}

			// Token: 0x060062FF RID: 25343 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062FF")]
			[Address(RVA = "0xAEDA00", Offset = "0xAEDA00", VA = "0xAEDA00")]
			private void topText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06006300 RID: 25344 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006300")]
			[Address(RVA = "0xAEDA40", Offset = "0xAEDA40", VA = "0xAEDA40")]
			private void bottomText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06006301 RID: 25345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006301")]
			[Address(RVA = "0xAEDA7C", Offset = "0xAEDA7C", VA = "0xAEDA7C")]
			private void middleText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06006302 RID: 25346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006302")]
			[Address(RVA = "0xAEDABC", Offset = "0xAEDABC", VA = "0xAEDABC")]
			private void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06006303 RID: 25347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006303")]
			[Address(RVA = "0xAEDBA8", Offset = "0xAEDBA8", VA = "0xAEDBA8")]
			private void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06006304 RID: 25348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006304")]
			[Address(RVA = "0xAEDC94", Offset = "0xAEDC94", VA = "0xAEDC94")]
			private void UpdateMouseOverNoItemText(UIElement affectedElement)
			{
			}

			// Token: 0x06006305 RID: 25349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006305")]
			[Address(RVA = "0xAEDD84", Offset = "0xAEDD84", VA = "0xAEDD84")]
			private void UpdateSliderAndShowMultiplierMouseOver(UIElement affectedElement)
			{
			}
		}

		// Token: 0x02000D0F RID: 3343
		[Token(Token = "0x2000D0F")]
		public class ModifyRainPower : CreativePowers.ASharedSliderPower
		{
			// Token: 0x06006306 RID: 25350 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006306")]
			[Address(RVA = "0xAEE050", Offset = "0xAEE050", VA = "0xAEE050")]
			public ModifyRainPower()
			{
			}

			// Token: 0x06006307 RID: 25351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006307")]
			[Address(RVA = "0xAEE174", Offset = "0xAEE174", VA = "0xAEE174", Slot = "18")]
			internal override void UpdateInfoFromSliderValueCache()
			{
			}

			// Token: 0x06006308 RID: 25352 RVA: 0x0002D768 File Offset: 0x0002B968
			[Token(Token = "0x6006308")]
			[Address(RVA = "0xAEE26C", Offset = "0xAEE26C", VA = "0xAEE26C", Slot = "20")]
			internal override float GetSliderValueInner()
			{
				return 0f;
			}

			// Token: 0x06006309 RID: 25353 RVA: 0x0002D780 File Offset: 0x0002B980
			[Token(Token = "0x6006309")]
			[Address(RVA = "0xAEE2D0", Offset = "0xAEE2D0", VA = "0xAEE2D0", Slot = "22")]
			public override bool GetIsUnlocked()
			{
				return default(bool);
			}

			// Token: 0x0600630A RID: 25354 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600630A")]
			[Address(RVA = "0xAEE2D8", Offset = "0xAEE2D8", VA = "0xAEE2D8", Slot = "19")]
			public override UIElement ProvideSlider()
			{
				return null;
			}

			// Token: 0x0600630B RID: 25355 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600630B")]
			[Address(RVA = "0xAEECDC", Offset = "0xAEECDC", VA = "0xAEECDC")]
			private void topText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x0600630C RID: 25356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600630C")]
			[Address(RVA = "0xAEED1C", Offset = "0xAEED1C", VA = "0xAEED1C")]
			private void middleText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x0600630D RID: 25357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600630D")]
			[Address(RVA = "0xAEED5C", Offset = "0xAEED5C", VA = "0xAEED5C")]
			private void bottomText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x0600630E RID: 25358 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600630E")]
			[Address(RVA = "0xAEED98", Offset = "0xAEED98", VA = "0xAEED98")]
			private void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x0600630F RID: 25359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600630F")]
			[Address(RVA = "0xAEEE84", Offset = "0xAEEE84", VA = "0xAEEE84")]
			private void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06006310 RID: 25360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006310")]
			[Address(RVA = "0xAEEF70", Offset = "0xAEEF70", VA = "0xAEEF70")]
			private void UpdateMouseOverNoItemText(UIElement affectedElement)
			{
			}

			// Token: 0x06006311 RID: 25361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006311")]
			[Address(RVA = "0xAEF060", Offset = "0xAEF060", VA = "0xAEF060")]
			private void UpdateSliderAndShowMultiplierMouseOver(UIElement affectedElement)
			{
			}
		}

		// Token: 0x02000D10 RID: 3344
		[Token(Token = "0x2000D10")]
		public class FreezeTime : CreativePowers.ASharedTogglePower, FileAPI
		{
			// Token: 0x06006312 RID: 25362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006312")]
			[Address(RVA = "0xAEF1B4", Offset = "0xAEF1B4", VA = "0xAEF1B4", Slot = "17")]
			internal override void CustomizeButton(UIElement button)
			{
			}

			// Token: 0x06006313 RID: 25363 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006313")]
			[Address(RVA = "0xAEF284", Offset = "0xAEF284", VA = "0xAEF284", Slot = "18")]
			internal override string GetButtonTextKey()
			{
				return null;
			}

			// Token: 0x06006314 RID: 25364 RVA: 0x0002D798 File Offset: 0x0002B998
			[Token(Token = "0x6006314")]
			[Address(RVA = "0xAEF2CC", Offset = "0xAEF2CC", VA = "0xAEF2CC", Slot = "19")]
			public override bool GetIsUnlocked()
			{
				return default(bool);
			}

			// Token: 0x06006315 RID: 25365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006315")]
			[Address(RVA = "0xAEF2D4", Offset = "0xAEF2D4", VA = "0xAEF2D4", Slot = "20")]
			public void Save(BinaryWriter writer)
			{
			}

			// Token: 0x06006316 RID: 25366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006316")]
			[Address(RVA = "0xAEF310", Offset = "0xAEF310", VA = "0xAEF310", Slot = "21")]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x06006317 RID: 25367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006317")]
			[Address(RVA = "0xAEF344", Offset = "0xAEF344", VA = "0xAEF344", Slot = "22")]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x06006318 RID: 25368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006318")]
			[Address(RVA = "0xAEF370", Offset = "0xAEF370", VA = "0xAEF370")]
			public FreezeTime()
			{
			}
		}

		// Token: 0x02000D11 RID: 3345
		[Token(Token = "0x2000D11")]
		public class FreezeWindDirectionAndStrength : CreativePowers.ASharedTogglePower, FileAPI
		{
			// Token: 0x06006319 RID: 25369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006319")]
			[Address(RVA = "0xAEF378", Offset = "0xAEF378", VA = "0xAEF378", Slot = "17")]
			internal override void CustomizeButton(UIElement button)
			{
			}

			// Token: 0x0600631A RID: 25370 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600631A")]
			[Address(RVA = "0xAEF448", Offset = "0xAEF448", VA = "0xAEF448", Slot = "18")]
			internal override string GetButtonTextKey()
			{
				return null;
			}

			// Token: 0x0600631B RID: 25371 RVA: 0x0002D7B0 File Offset: 0x0002B9B0
			[Token(Token = "0x600631B")]
			[Address(RVA = "0xAEF490", Offset = "0xAEF490", VA = "0xAEF490", Slot = "19")]
			public override bool GetIsUnlocked()
			{
				return default(bool);
			}

			// Token: 0x0600631C RID: 25372 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600631C")]
			[Address(RVA = "0xAEF498", Offset = "0xAEF498", VA = "0xAEF498", Slot = "20")]
			public void Save(BinaryWriter writer)
			{
			}

			// Token: 0x0600631D RID: 25373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600631D")]
			[Address(RVA = "0xAEF4D4", Offset = "0xAEF4D4", VA = "0xAEF4D4", Slot = "21")]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x0600631E RID: 25374 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600631E")]
			[Address(RVA = "0xAEF508", Offset = "0xAEF508", VA = "0xAEF508", Slot = "22")]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x0600631F RID: 25375 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600631F")]
			[Address(RVA = "0xAEF534", Offset = "0xAEF534", VA = "0xAEF534")]
			public FreezeWindDirectionAndStrength()
			{
			}
		}

		// Token: 0x02000D12 RID: 3346
		[Token(Token = "0x2000D12")]
		public class FreezeRainPower : CreativePowers.ASharedTogglePower, FileAPI
		{
			// Token: 0x06006320 RID: 25376 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006320")]
			[Address(RVA = "0xAEF53C", Offset = "0xAEF53C", VA = "0xAEF53C", Slot = "17")]
			internal override void CustomizeButton(UIElement button)
			{
			}

			// Token: 0x06006321 RID: 25377 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006321")]
			[Address(RVA = "0xAEF60C", Offset = "0xAEF60C", VA = "0xAEF60C", Slot = "18")]
			internal override string GetButtonTextKey()
			{
				return null;
			}

			// Token: 0x06006322 RID: 25378 RVA: 0x0002D7C8 File Offset: 0x0002B9C8
			[Token(Token = "0x6006322")]
			[Address(RVA = "0xAEF654", Offset = "0xAEF654", VA = "0xAEF654", Slot = "19")]
			public override bool GetIsUnlocked()
			{
				return default(bool);
			}

			// Token: 0x06006323 RID: 25379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006323")]
			[Address(RVA = "0xAEF65C", Offset = "0xAEF65C", VA = "0xAEF65C", Slot = "20")]
			public void Save(BinaryWriter writer)
			{
			}

			// Token: 0x06006324 RID: 25380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006324")]
			[Address(RVA = "0xAEF698", Offset = "0xAEF698", VA = "0xAEF698", Slot = "21")]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x06006325 RID: 25381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006325")]
			[Address(RVA = "0xAEF6CC", Offset = "0xAEF6CC", VA = "0xAEF6CC", Slot = "22")]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x06006326 RID: 25382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006326")]
			[Address(RVA = "0xAEF6F8", Offset = "0xAEF6F8", VA = "0xAEF6F8")]
			public FreezeRainPower()
			{
			}
		}

		// Token: 0x02000D13 RID: 3347
		[Token(Token = "0x2000D13")]
		public class StopBiomeSpreadPower : CreativePowers.ASharedTogglePower, FileAPI
		{
			// Token: 0x06006327 RID: 25383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006327")]
			[Address(RVA = "0xAEF700", Offset = "0xAEF700", VA = "0xAEF700", Slot = "17")]
			internal override void CustomizeButton(UIElement button)
			{
			}

			// Token: 0x06006328 RID: 25384 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006328")]
			[Address(RVA = "0xAEF7D0", Offset = "0xAEF7D0", VA = "0xAEF7D0", Slot = "18")]
			internal override string GetButtonTextKey()
			{
				return null;
			}

			// Token: 0x06006329 RID: 25385 RVA: 0x0002D7E0 File Offset: 0x0002B9E0
			[Token(Token = "0x6006329")]
			[Address(RVA = "0xAEF818", Offset = "0xAEF818", VA = "0xAEF818", Slot = "19")]
			public override bool GetIsUnlocked()
			{
				return default(bool);
			}

			// Token: 0x0600632A RID: 25386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600632A")]
			[Address(RVA = "0xAEF820", Offset = "0xAEF820", VA = "0xAEF820", Slot = "20")]
			public void Save(BinaryWriter writer)
			{
			}

			// Token: 0x0600632B RID: 25387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600632B")]
			[Address(RVA = "0xAEF85C", Offset = "0xAEF85C", VA = "0xAEF85C", Slot = "21")]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x0600632C RID: 25388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600632C")]
			[Address(RVA = "0xAEF890", Offset = "0xAEF890", VA = "0xAEF890", Slot = "22")]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x0600632D RID: 25389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600632D")]
			[Address(RVA = "0xAEF8BC", Offset = "0xAEF8BC", VA = "0xAEF8BC")]
			public StopBiomeSpreadPower()
			{
			}
		}

		// Token: 0x02000D14 RID: 3348
		[Token(Token = "0x2000D14")]
		public class SpawnRateSliderPerPlayerPower : CreativePowers.APerPlayerSliderPower, FileAPI
		{
			// Token: 0x17000AB3 RID: 2739
			// (get) Token: 0x0600632E RID: 25390 RVA: 0x0002D7F8 File Offset: 0x0002B9F8
			// (set) Token: 0x0600632F RID: 25391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AB3")]
			public float StrengthMultiplierToGiveNPCs
			{
				[Token(Token = "0x600632E")]
				[Address(RVA = "0xAEF8C4", Offset = "0xAEF8C4", VA = "0xAEF8C4")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600632F")]
				[Address(RVA = "0xAEF8CC", Offset = "0xAEF8CC", VA = "0xAEF8CC")]
				private set
				{
				}
			}

			// Token: 0x06006330 RID: 25392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006330")]
			[Address(RVA = "0xAEF8D4", Offset = "0xAEF8D4", VA = "0xAEF8D4")]
			public SpawnRateSliderPerPlayerPower()
			{
			}

			// Token: 0x06006331 RID: 25393 RVA: 0x0002D810 File Offset: 0x0002BA10
			[Token(Token = "0x6006331")]
			[Address(RVA = "0xAEF978", Offset = "0xAEF978", VA = "0xAEF978")]
			public bool GetShouldDisableSpawnsFor(int playerIndex)
			{
				return default(bool);
			}

			// Token: 0x06006332 RID: 25394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006332")]
			[Address(RVA = "0xAEFA8C", Offset = "0xAEFA8C", VA = "0xAEFA8C", Slot = "19")]
			internal override void UpdateInfoFromSliderValueCache()
			{
			}

			// Token: 0x06006333 RID: 25395 RVA: 0x0002D828 File Offset: 0x0002BA28
			[Token(Token = "0x6006333")]
			[Address(RVA = "0xAEFA90", Offset = "0xAEFA90", VA = "0xAEFA90", Slot = "18")]
			public override float RemapSliderValueToPowerValue(float sliderValue)
			{
				return 0f;
			}

			// Token: 0x06006334 RID: 25396 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006334")]
			[Address(RVA = "0xAEFB68", Offset = "0xAEFB68", VA = "0xAEFB68", Slot = "20")]
			public override UIElement ProvideSlider()
			{
				return null;
			}

			// Token: 0x06006335 RID: 25397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006335")]
			[Address(RVA = "0xAF0518", Offset = "0xAF0518", VA = "0xAF0518")]
			private void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06006336 RID: 25398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006336")]
			[Address(RVA = "0xAF0604", Offset = "0xAF0604", VA = "0xAF0604")]
			private void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06006337 RID: 25399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006337")]
			[Address(RVA = "0xAF06F0", Offset = "0xAF06F0", VA = "0xAF06F0")]
			private void topText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06006338 RID: 25400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006338")]
			[Address(RVA = "0xAF0730", Offset = "0xAF0730", VA = "0xAF0730")]
			private void middleText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06006339 RID: 25401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006339")]
			[Address(RVA = "0xAF0770", Offset = "0xAF0770", VA = "0xAF0770")]
			private void bottomText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x0600633A RID: 25402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600633A")]
			[Address(RVA = "0xAF07AC", Offset = "0xAF07AC", VA = "0xAF07AC")]
			private void UpdateMouseOverNoItemText(UIElement affectedElement)
			{
			}

			// Token: 0x0600633B RID: 25403 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600633B")]
			[Address(RVA = "0xAF089C", Offset = "0xAF089C", VA = "0xAF089C")]
			private void UpdateSliderAndShowMultiplierMouseOver(UIElement affectedElement)
			{
			}

			// Token: 0x0600633C RID: 25404 RVA: 0x0002D840 File Offset: 0x0002BA40
			[Token(Token = "0x600633C")]
			[Address(RVA = "0xAF0B3C", Offset = "0xAF0B3C", VA = "0xAF0B3C", Slot = "23")]
			public override bool GetIsUnlocked()
			{
				return default(bool);
			}

			// Token: 0x0600633D RID: 25405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600633D")]
			[Address(RVA = "0xAF0B44", Offset = "0xAF0B44", VA = "0xAF0B44", Slot = "24")]
			public void Save(Player player, BinaryWriter writer)
			{
			}

			// Token: 0x0600633E RID: 25406 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600633E")]
			[Address(RVA = "0xAF0B80", Offset = "0xAF0B80", VA = "0xAF0B80", Slot = "27")]
			public void ResetDataForNewPlayer(Player player)
			{
			}

			// Token: 0x0600633F RID: 25407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600633F")]
			[Address(RVA = "0xAF0BBC", Offset = "0xAF0BBC", VA = "0xAF0BBC", Slot = "25")]
			public void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x06006340 RID: 25408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006340")]
			[Address(RVA = "0xAF0C1C", Offset = "0xAF0C1C", VA = "0xAF0C1C", Slot = "26")]
			public void ApplyLoadedDataToOutOfPlayerFields(Player player)
			{
			}

			// Token: 0x0400A0A7 RID: 41127
			[Token(Token = "0x400A0A7")]
			[FieldOffset(Offset = "0x40")]
			private float <StrengthMultiplierToGiveNPCs>k__BackingField;
		}
	}
}
