using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000D1C RID: 3356
	[Token(Token = "0x2000D1C")]
	public class MoonlordDeathDrama
	{
		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x060063A8 RID: 25512 RVA: 0x0002DB58 File Offset: 0x0002BD58
		// (set) Token: 0x060063A9 RID: 25513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ABF")]
		public static float whitening
		{
			[Token(Token = "0x60063A8")]
			[Address(RVA = "0xB020B8", Offset = "0xB020B8", VA = "0xB020B8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60063A9")]
			[Address(RVA = "0xB02120", Offset = "0xB02120", VA = "0xB02120")]
			set
			{
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x060063AA RID: 25514 RVA: 0x0002DB70 File Offset: 0x0002BD70
		// (set) Token: 0x060063AB RID: 25515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC0")]
		private static float requestedLight
		{
			[Token(Token = "0x60063AA")]
			[Address(RVA = "0xB02190", Offset = "0xB02190", VA = "0xB02190")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60063AB")]
			[Address(RVA = "0xB021F8", Offset = "0xB021F8", VA = "0xB021F8")]
			set
			{
			}
		}

		// Token: 0x060063AC RID: 25516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063AC")]
		[Address(RVA = "0xB02268", Offset = "0xB02268", VA = "0xB02268")]
		public static void Update(SceneState sceneState, SceneMetrics metrics)
		{
		}

		// Token: 0x060063AD RID: 25517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063AD")]
		[Address(RVA = "0xB03028", Offset = "0xB03028", VA = "0xB03028")]
		public static void DrawPieces(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060063AE RID: 25518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063AE")]
		[Address(RVA = "0xB03588", Offset = "0xB03588", VA = "0xB03588")]
		public static void DrawExplosions(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060063AF RID: 25519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063AF")]
		[Address(RVA = "0xB03B44", Offset = "0xB03B44", VA = "0xB03B44")]
		public static void DrawWhite(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060063B0 RID: 25520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B0")]
		[Address(RVA = "0xB03E44", Offset = "0xB03E44", VA = "0xB03E44")]
		public static void ThrowPieces(Vector2 MoonlordCoreCenter, int DramaSeed)
		{
		}

		// Token: 0x060063B1 RID: 25521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B1")]
		[Address(RVA = "0xB04CD4", Offset = "0xB04CD4", VA = "0xB04CD4")]
		public static void AddExplosion(Vector2 spot)
		{
		}

		// Token: 0x060063B2 RID: 25522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B2")]
		[Address(RVA = "0xB050C0", Offset = "0xB050C0", VA = "0xB050C0")]
		public static void RequestLight(float light, Vector2 spot)
		{
		}

		// Token: 0x060063B3 RID: 25523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B3")]
		[Address(RVA = "0xB052B4", Offset = "0xB052B4", VA = "0xB052B4")]
		public MoonlordDeathDrama()
		{
		}

		// Token: 0x0400A0D4 RID: 41172
		[Token(Token = "0x400A0D4")]
		[FieldOffset(Offset = "0x0")]
		private static List<MoonlordDeathDrama.MoonlordPiece> _pieces;

		// Token: 0x0400A0D5 RID: 41173
		[Token(Token = "0x400A0D5")]
		[FieldOffset(Offset = "0x4")]
		private static List<MoonlordDeathDrama.MoonlordExplosion> _explosions;

		// Token: 0x0400A0D6 RID: 41174
		[Token(Token = "0x400A0D6")]
		[FieldOffset(Offset = "0x8")]
		private static List<Vector2> _lightSources;

		// Token: 0x02000D1D RID: 3357
		[Token(Token = "0x2000D1D")]
		public class MoonlordPiece
		{
			// Token: 0x060063B5 RID: 25525 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60063B5")]
			[Address(RVA = "0xB04C78", Offset = "0xB04C78", VA = "0xB04C78")]
			public MoonlordPiece(Texture2D pieceTexture, Vector2 textureOrigin, Vector2 centerPos, Vector2 velocity, float rot, float angularVelocity)
			{
			}

			// Token: 0x060063B6 RID: 25526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60063B6")]
			[Address(RVA = "0xB02C98", Offset = "0xB02C98", VA = "0xB02C98")]
			public void Update()
			{
			}

			// Token: 0x060063B7 RID: 25527 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60063B7")]
			[Address(RVA = "0xB03424", Offset = "0xB03424", VA = "0xB03424")]
			public void Draw(SpriteBatch sp)
			{
			}

			// Token: 0x17000AC1 RID: 2753
			// (get) Token: 0x060063B8 RID: 25528 RVA: 0x0002DB88 File Offset: 0x0002BD88
			[Token(Token = "0x17000AC1")]
			public bool Dead
			{
				[Token(Token = "0x60063B8")]
				[Address(RVA = "0xB02D68", Offset = "0xB02D68", VA = "0xB02D68")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060063B9 RID: 25529 RVA: 0x0002DBA0 File Offset: 0x0002BDA0
			[Token(Token = "0x60063B9")]
			[Address(RVA = "0xB03348", Offset = "0xB03348", VA = "0xB03348")]
			public bool InDrawRange(Rectangle playerScreen)
			{
				return default(bool);
			}

			// Token: 0x060063BA RID: 25530 RVA: 0x0002DBB8 File Offset: 0x0002BDB8
			[Token(Token = "0x60063BA")]
			[Address(RVA = "0xB05438", Offset = "0xB05438", VA = "0xB05438")]
			public Color GetLight()
			{
				return default(Color);
			}

			// Token: 0x0400A0D7 RID: 41175
			[Token(Token = "0x400A0D7")]
			[FieldOffset(Offset = "0x8")]
			private Texture2D _texture;

			// Token: 0x0400A0D8 RID: 41176
			[Token(Token = "0x400A0D8")]
			[FieldOffset(Offset = "0xC")]
			private Vector2 _position;

			// Token: 0x0400A0D9 RID: 41177
			[Token(Token = "0x400A0D9")]
			[FieldOffset(Offset = "0x14")]
			private Vector2 _velocity;

			// Token: 0x0400A0DA RID: 41178
			[Token(Token = "0x400A0DA")]
			[FieldOffset(Offset = "0x1C")]
			private Vector2 _origin;

			// Token: 0x0400A0DB RID: 41179
			[Token(Token = "0x400A0DB")]
			[FieldOffset(Offset = "0x24")]
			private float _rotation;

			// Token: 0x0400A0DC RID: 41180
			[Token(Token = "0x400A0DC")]
			[FieldOffset(Offset = "0x28")]
			private float _rotationVelocity;
		}

		// Token: 0x02000D1E RID: 3358
		[Token(Token = "0x2000D1E")]
		public class MoonlordExplosion
		{
			// Token: 0x060063BB RID: 25531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60063BB")]
			[Address(RVA = "0xB04F70", Offset = "0xB04F70", VA = "0xB04F70")]
			public MoonlordExplosion(Texture2D pieceTexture, Vector2 centerPos, int frameSpeed)
			{
			}

			// Token: 0x060063BC RID: 25532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60063BC")]
			[Address(RVA = "0xB02E5C", Offset = "0xB02E5C", VA = "0xB02E5C")]
			public void Update()
			{
			}

			// Token: 0x060063BD RID: 25533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60063BD")]
			[Address(RVA = "0xB03984", Offset = "0xB03984", VA = "0xB03984")]
			public void Draw(SpriteBatch sp)
			{
			}

			// Token: 0x17000AC2 RID: 2754
			// (get) Token: 0x060063BE RID: 25534 RVA: 0x0002DBD0 File Offset: 0x0002BDD0
			[Token(Token = "0x17000AC2")]
			public bool Dead
			{
				[Token(Token = "0x60063BE")]
				[Address(RVA = "0xB02F20", Offset = "0xB02F20", VA = "0xB02F20")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060063BF RID: 25535 RVA: 0x0002DBE8 File Offset: 0x0002BDE8
			[Token(Token = "0x60063BF")]
			[Address(RVA = "0xB038A8", Offset = "0xB038A8", VA = "0xB038A8")]
			public bool InDrawRange(Rectangle playerScreen)
			{
				return default(bool);
			}

			// Token: 0x060063C0 RID: 25536 RVA: 0x0002DC00 File Offset: 0x0002BE00
			[Token(Token = "0x60063C0")]
			[Address(RVA = "0xB05758", Offset = "0xB05758", VA = "0xB05758")]
			public Color GetLight()
			{
				return default(Color);
			}

			// Token: 0x0400A0DD RID: 41181
			[Token(Token = "0x400A0DD")]
			[FieldOffset(Offset = "0x8")]
			private Texture2D _texture;

			// Token: 0x0400A0DE RID: 41182
			[Token(Token = "0x400A0DE")]
			[FieldOffset(Offset = "0xC")]
			private Vector2 _position;

			// Token: 0x0400A0DF RID: 41183
			[Token(Token = "0x400A0DF")]
			[FieldOffset(Offset = "0x14")]
			private Vector2 _origin;

			// Token: 0x0400A0E0 RID: 41184
			[Token(Token = "0x400A0E0")]
			[FieldOffset(Offset = "0x1C")]
			private Rectangle _frame;

			// Token: 0x0400A0E1 RID: 41185
			[Token(Token = "0x400A0E1")]
			[FieldOffset(Offset = "0x2C")]
			private int _frameCounter;

			// Token: 0x0400A0E2 RID: 41186
			[Token(Token = "0x400A0E2")]
			[FieldOffset(Offset = "0x30")]
			private int _frameSpeed;
		}
	}
}
