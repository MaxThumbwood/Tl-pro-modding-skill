using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;
using Terraria.Social.Base;

namespace Terraria.UI
{
	// Token: 0x02000840 RID: 2112
	[Token(Token = "0x2000840")]
	public class InGameNotificationsTracker
	{
		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06004900 RID: 18688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000902")]
		private static List<IInGameNotification> _notifications
		{
			[Token(Token = "0x6004900")]
			[Address(RVA = "0x5F6E0C", Offset = "0x5F6E0C", VA = "0x5F6E0C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004901")]
		[Address(RVA = "0x5F6E74", Offset = "0x5F6E74", VA = "0x5F6E74")]
		public static void Initialize()
		{
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004902")]
		[Address(RVA = "0x5F7070", Offset = "0x5F7070", VA = "0x5F7070")]
		private static void JoinRequests_OnRequestAdded(UserJoinToServerRequest request)
		{
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004903")]
		[Address(RVA = "0x5F71D0", Offset = "0x5F71D0", VA = "0x5F71D0")]
		private static void JoinRequests_OnRequestRemoved(UserJoinToServerRequest request)
		{
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004904")]
		[Address(RVA = "0x5F740C", Offset = "0x5F740C", VA = "0x5F740C")]
		public static void DrawInGame(SpriteBatch sb)
		{
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004905")]
		[Address(RVA = "0x5F78A0", Offset = "0x5F78A0", VA = "0x5F78A0")]
		public static void DrawInIngameOptions(SpriteBatch spriteBatch, Rectangle area, ref int gamepadPointIdLocalIndexToUse)
		{
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004906")]
		[Address(RVA = "0x5F7BC0", Offset = "0x5F7BC0", VA = "0x5F7BC0")]
		public static void AddCompleted(Achievement achievement)
		{
		}

		// Token: 0x06004907 RID: 18695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004907")]
		[Address(RVA = "0x5F7074", Offset = "0x5F7074", VA = "0x5F7074")]
		public static void AddJoinRequest(UserJoinToServerRequest request)
		{
		}

		// Token: 0x06004908 RID: 18696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004908")]
		[Address(RVA = "0x5F8054", Offset = "0x5F8054", VA = "0x5F8054")]
		public static void Clear()
		{
		}

		// Token: 0x06004909 RID: 18697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004909")]
		[Address(RVA = "0x5F8120", Offset = "0x5F8120", VA = "0x5F8120")]
		public static void Update()
		{
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600490A")]
		[Address(RVA = "0x5F845C", Offset = "0x5F845C", VA = "0x5F845C")]
		public InGameNotificationsTracker()
		{
		}
	}
}
