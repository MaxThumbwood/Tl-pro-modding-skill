using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Achievements;
using Terraria.Social.Base;

namespace Terraria.UI
{
	// Token: 0x02000842 RID: 2114
	[Token(Token = "0x2000842")]
	public class InGamePopups
	{
		// Token: 0x06004911 RID: 18705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004911")]
		[Address(RVA = "0x5F8464", Offset = "0x5F8464", VA = "0x5F8464")]
		public InGamePopups()
		{
		}

		// Token: 0x02000843 RID: 2115
		[Token(Token = "0x2000843")]
		public class AchievementUnlockedPopup : FileAPI
		{
			// Token: 0x17000905 RID: 2309
			// (get) Token: 0x06004912 RID: 18706 RVA: 0x00022C80 File Offset: 0x00020E80
			// (set) Token: 0x06004913 RID: 18707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000905")]
			public bool ShouldBeRemoved
			{
				[Token(Token = "0x6004912")]
				[Address(RVA = "0x5F846C", Offset = "0x5F846C", VA = "0x5F846C", Slot = "5")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6004913")]
				[Address(RVA = "0x5F8474", Offset = "0x5F8474", VA = "0x5F8474")]
				private set
				{
				}
			}

			// Token: 0x17000906 RID: 2310
			// (get) Token: 0x06004914 RID: 18708 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06004915 RID: 18709 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000906")]
			public object CreationObject
			{
				[Token(Token = "0x6004914")]
				[Address(RVA = "0x5F847C", Offset = "0x5F847C", VA = "0x5F847C", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004915")]
				[Address(RVA = "0x5F8484", Offset = "0x5F8484", VA = "0x5F8484")]
				private set
				{
				}
			}

			// Token: 0x06004916 RID: 18710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004916")]
			[Address(RVA = "0x5F7D0C", Offset = "0x5F7D0C", VA = "0x5F7D0C")]
			public AchievementUnlockedPopup(Achievement achievement)
			{
			}

			// Token: 0x06004917 RID: 18711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004917")]
			[Address(RVA = "0x5F848C", Offset = "0x5F848C", VA = "0x5F848C", Slot = "6")]
			public void Update()
			{
			}

			// Token: 0x17000907 RID: 2311
			// (get) Token: 0x06004918 RID: 18712 RVA: 0x00022C98 File Offset: 0x00020E98
			[Token(Token = "0x17000907")]
			private float Scale
			{
				[Token(Token = "0x6004918")]
				[Address(RVA = "0x5F84A0", Offset = "0x5F84A0", VA = "0x5F84A0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000908 RID: 2312
			// (get) Token: 0x06004919 RID: 18713 RVA: 0x00022CB0 File Offset: 0x00020EB0
			[Token(Token = "0x17000908")]
			private float Opacity
			{
				[Token(Token = "0x6004919")]
				[Address(RVA = "0x5F8594", Offset = "0x5F8594", VA = "0x5F8594")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600491A RID: 18714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600491A")]
			[Address(RVA = "0x5F85CC", Offset = "0x5F85CC", VA = "0x5F85CC", Slot = "8")]
			public void PushAnchor(ref Vector2 anchorPosition)
			{
			}

			// Token: 0x0600491B RID: 18715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600491B")]
			[Address(RVA = "0x5F8684", Offset = "0x5F8684", VA = "0x5F8684", Slot = "7")]
			public void DrawInGame(SpriteBatch sb, Vector2 bottomAnchorPosition)
			{
			}

			// Token: 0x0600491C RID: 18716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600491C")]
			[Address(RVA = "0x5F9140", Offset = "0x5F9140", VA = "0x5F9140")]
			private void OnMouseOver()
			{
			}

			// Token: 0x0600491D RID: 18717 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600491D")]
			[Address(RVA = "0x5F92BC", Offset = "0x5F92BC", VA = "0x5F92BC", Slot = "9")]
			public void DrawInNotificationsArea(SpriteBatch spriteBatch, Rectangle area, ref int gamepadPointLocalIndexTouse)
			{
			}

			// Token: 0x04008F19 RID: 36633
			[Token(Token = "0x4008F19")]
			[FieldOffset(Offset = "0x8")]
			private Achievement _theAchievement;

			// Token: 0x04008F1A RID: 36634
			[Token(Token = "0x4008F1A")]
			[FieldOffset(Offset = "0xC")]
			private Asset<Texture2D> _achievementTexture;

			// Token: 0x04008F1B RID: 36635
			[Token(Token = "0x4008F1B")]
			[FieldOffset(Offset = "0x10")]
			private Asset<Texture2D> _achievementBorderTexture;

			// Token: 0x04008F1C RID: 36636
			[Token(Token = "0x4008F1C")]
			private const int _iconSize = 64;

			// Token: 0x04008F1D RID: 36637
			[Token(Token = "0x4008F1D")]
			private const int _iconSizeWithSpace = 66;

			// Token: 0x04008F1E RID: 36638
			[Token(Token = "0x4008F1E")]
			private const int _iconsPerRow = 8;

			// Token: 0x04008F1F RID: 36639
			[Token(Token = "0x4008F1F")]
			[FieldOffset(Offset = "0x14")]
			private int _iconIndex;

			// Token: 0x04008F20 RID: 36640
			[Token(Token = "0x4008F20")]
			[FieldOffset(Offset = "0x18")]
			private Rectangle _achievementIconFrame;

			// Token: 0x04008F21 RID: 36641
			[Token(Token = "0x4008F21")]
			[FieldOffset(Offset = "0x28")]
			private string _title;

			// Token: 0x04008F22 RID: 36642
			[Token(Token = "0x4008F22")]
			[FieldOffset(Offset = "0x2C")]
			private float _height;

			// Token: 0x04008F23 RID: 36643
			[Token(Token = "0x4008F23")]
			[FieldOffset(Offset = "0x30")]
			private int _ingameDisplayTimeLeft;

			// Token: 0x04008F24 RID: 36644
			[Token(Token = "0x4008F24")]
			[FieldOffset(Offset = "0x34")]
			private bool <ShouldBeRemoved>k__BackingField;

			// Token: 0x04008F25 RID: 36645
			[Token(Token = "0x4008F25")]
			[FieldOffset(Offset = "0x38")]
			private object <CreationObject>k__BackingField;
		}

		// Token: 0x02000844 RID: 2116
		[Token(Token = "0x2000844")]
		public class PlayerWantsToJoinGamePopup : FileAPI
		{
			// Token: 0x17000909 RID: 2313
			// (get) Token: 0x0600491E RID: 18718 RVA: 0x00022CC8 File Offset: 0x00020EC8
			[Token(Token = "0x17000909")]
			private float Scale
			{
				[Token(Token = "0x600491E")]
				[Address(RVA = "0x5F9394", Offset = "0x5F9394", VA = "0x5F9394")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700090A RID: 2314
			// (get) Token: 0x0600491F RID: 18719 RVA: 0x00022CE0 File Offset: 0x00020EE0
			[Token(Token = "0x1700090A")]
			private float Opacity
			{
				[Token(Token = "0x600491F")]
				[Address(RVA = "0x5F9404", Offset = "0x5F9404", VA = "0x5F9404")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700090B RID: 2315
			// (get) Token: 0x06004920 RID: 18720 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06004921 RID: 18721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700090B")]
			public object CreationObject
			{
				[Token(Token = "0x6004920")]
				[Address(RVA = "0x5F94A8", Offset = "0x5F94A8", VA = "0x5F94A8", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004921")]
				[Address(RVA = "0x5F94B0", Offset = "0x5F94B0", VA = "0x5F94B0")]
				private set
				{
				}
			}

			// Token: 0x06004922 RID: 18722 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004922")]
			[Address(RVA = "0x5F802C", Offset = "0x5F802C", VA = "0x5F802C")]
			public PlayerWantsToJoinGamePopup(UserJoinToServerRequest request)
			{
			}

			// Token: 0x1700090C RID: 2316
			// (get) Token: 0x06004923 RID: 18723 RVA: 0x00022CF8 File Offset: 0x00020EF8
			[Token(Token = "0x1700090C")]
			public bool ShouldBeRemoved
			{
				[Token(Token = "0x6004923")]
				[Address(RVA = "0x5F94B8", Offset = "0x5F94B8", VA = "0x5F94B8", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06004924 RID: 18724 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004924")]
			[Address(RVA = "0x5F94CC", Offset = "0x5F94CC", VA = "0x5F94CC", Slot = "6")]
			public void Update()
			{
			}

			// Token: 0x06004925 RID: 18725 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004925")]
			[Address(RVA = "0x5F94DC", Offset = "0x5F94DC", VA = "0x5F94DC", Slot = "7")]
			public void DrawInGame(SpriteBatch spriteBatch, Vector2 bottomAnchorPosition)
			{
			}

			// Token: 0x06004926 RID: 18726 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004926")]
			[Address(RVA = "0x5FA4AC", Offset = "0x5FA4AC", VA = "0x5FA4AC")]
			private void OnMouseOver(bool reject = false)
			{
			}

			// Token: 0x06004927 RID: 18727 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004927")]
			[Address(RVA = "0x5FA618", Offset = "0x5FA618", VA = "0x5FA618", Slot = "8")]
			public void PushAnchor(ref Vector2 positionAnchorBottom)
			{
			}

			// Token: 0x06004928 RID: 18728 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004928")]
			[Address(RVA = "0x5FA6D0", Offset = "0x5FA6D0", VA = "0x5FA6D0", Slot = "9")]
			public void DrawInNotificationsArea(SpriteBatch spriteBatch, Rectangle area, ref int gamepadPointLocalIndexTouse)
			{
			}

			// Token: 0x04008F26 RID: 36646
			[Token(Token = "0x4008F26")]
			[FieldOffset(Offset = "0x8")]
			private int _timeLeft;

			// Token: 0x04008F27 RID: 36647
			[Token(Token = "0x4008F27")]
			private const int _timeLeftMax = 1800;

			// Token: 0x04008F28 RID: 36648
			[Token(Token = "0x4008F28")]
			[FieldOffset(Offset = "0xC")]
			private UserJoinToServerRequest _request;

			// Token: 0x04008F29 RID: 36649
			[Token(Token = "0x4008F29")]
			[FieldOffset(Offset = "0x10")]
			private object <CreationObject>k__BackingField;
		}
	}
}
