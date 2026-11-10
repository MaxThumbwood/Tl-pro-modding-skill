using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Server
{
	// Token: 0x02000642 RID: 1602
	[Token(Token = "0x2000642")]
	public class Game : FileAPI
	{
		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06003E17 RID: 15895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007AF")]
		public GameComponentCollection Components
		{
			[Token(Token = "0x6003E17")]
			[Address(RVA = "0x1E695F8", Offset = "0x1E695F8", VA = "0x1E695F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06003E18 RID: 15896 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003E19 RID: 15897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B0")]
		public ContentManager Content
		{
			[Token(Token = "0x6003E18")]
			[Address(RVA = "0x1E69600", Offset = "0x1E69600", VA = "0x1E69600")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E19")]
			[Address(RVA = "0x1E69608", Offset = "0x1E69608", VA = "0x1E69608")]
			set
			{
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06003E1A RID: 15898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B1")]
		public GraphicsDevice GraphicsDevice
		{
			[Token(Token = "0x6003E1A")]
			[Address(RVA = "0x1E6960C", Offset = "0x1E6960C", VA = "0x1E6960C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06003E1B RID: 15899 RVA: 0x0001EA80 File Offset: 0x0001CC80
		// (set) Token: 0x06003E1C RID: 15900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B2")]
		public TimeSpan InactiveSleepTime
		{
			[Token(Token = "0x6003E1B")]
			[Address(RVA = "0x1E69614", Offset = "0x1E69614", VA = "0x1E69614")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6003E1C")]
			[Address(RVA = "0x1E69680", Offset = "0x1E69680", VA = "0x1E69680")]
			set
			{
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06003E1D RID: 15901 RVA: 0x0001EA98 File Offset: 0x0001CC98
		[Token(Token = "0x170007B3")]
		public bool IsActive
		{
			[Token(Token = "0x6003E1D")]
			[Address(RVA = "0x1E69684", Offset = "0x1E69684", VA = "0x1E69684")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06003E1E RID: 15902 RVA: 0x0001EAB0 File Offset: 0x0001CCB0
		// (set) Token: 0x06003E1F RID: 15903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B4")]
		public bool IsFixedTimeStep
		{
			[Token(Token = "0x6003E1E")]
			[Address(RVA = "0x1E6968C", Offset = "0x1E6968C", VA = "0x1E6968C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E1F")]
			[Address(RVA = "0x1E69694", Offset = "0x1E69694", VA = "0x1E69694")]
			set
			{
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06003E20 RID: 15904 RVA: 0x0001EAC8 File Offset: 0x0001CCC8
		// (set) Token: 0x06003E21 RID: 15905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B5")]
		public bool IsMouseVisible
		{
			[Token(Token = "0x6003E20")]
			[Address(RVA = "0x1E69698", Offset = "0x1E69698", VA = "0x1E69698")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E21")]
			[Address(RVA = "0x1E696A0", Offset = "0x1E696A0", VA = "0x1E696A0")]
			set
			{
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06003E22 RID: 15906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B6")]
		public GameServiceContainer Services
		{
			[Token(Token = "0x6003E22")]
			[Address(RVA = "0x1E696A4", Offset = "0x1E696A4", VA = "0x1E696A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06003E23 RID: 15907 RVA: 0x0001EAE0 File Offset: 0x0001CCE0
		// (set) Token: 0x06003E24 RID: 15908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B7")]
		public TimeSpan TargetElapsedTime
		{
			[Token(Token = "0x6003E23")]
			[Address(RVA = "0x1E696AC", Offset = "0x1E696AC", VA = "0x1E696AC")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6003E24")]
			[Address(RVA = "0x1E69718", Offset = "0x1E69718", VA = "0x1E69718")]
			set
			{
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06003E25 RID: 15909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B8")]
		public GameWindow Window
		{
			[Token(Token = "0x6003E25")]
			[Address(RVA = "0x1E6971C", Offset = "0x1E6971C", VA = "0x1E6971C")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06003E26 RID: 15910 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003E27 RID: 15911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000037")]
		public event EventHandler<EventArgs> Activated
		{
			[Token(Token = "0x6003E26")]
			[Address(RVA = "0x1E69724", Offset = "0x1E69724", VA = "0x1E69724")]
			add
			{
			}
			[Token(Token = "0x6003E27")]
			[Address(RVA = "0x1E697EC", Offset = "0x1E697EC", VA = "0x1E697EC")]
			remove
			{
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06003E28 RID: 15912 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003E29 RID: 15913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000038")]
		public event EventHandler<EventArgs> Deactivated
		{
			[Token(Token = "0x6003E28")]
			[Address(RVA = "0x1E698B4", Offset = "0x1E698B4", VA = "0x1E698B4")]
			add
			{
			}
			[Token(Token = "0x6003E29")]
			[Address(RVA = "0x1E6997C", Offset = "0x1E6997C", VA = "0x1E6997C")]
			remove
			{
			}
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06003E2A RID: 15914 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003E2B RID: 15915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000039")]
		public event EventHandler<EventArgs> Disposed
		{
			[Token(Token = "0x6003E2A")]
			[Address(RVA = "0x1E69A44", Offset = "0x1E69A44", VA = "0x1E69A44")]
			add
			{
			}
			[Token(Token = "0x6003E2B")]
			[Address(RVA = "0x1E69B0C", Offset = "0x1E69B0C", VA = "0x1E69B0C")]
			remove
			{
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06003E2C RID: 15916 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003E2D RID: 15917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003A")]
		public event EventHandler<EventArgs> Exiting
		{
			[Token(Token = "0x6003E2C")]
			[Address(RVA = "0x1E69BD4", Offset = "0x1E69BD4", VA = "0x1E69BD4")]
			add
			{
			}
			[Token(Token = "0x6003E2D")]
			[Address(RVA = "0x1E69C9C", Offset = "0x1E69C9C", VA = "0x1E69C9C")]
			remove
			{
			}
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x0001EAF8 File Offset: 0x0001CCF8
		[Token(Token = "0x6003E2E")]
		[Address(RVA = "0x1E69D64", Offset = "0x1E69D64", VA = "0x1E69D64", Slot = "5")]
		protected virtual bool BeginDraw()
		{
			return default(bool);
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E2F")]
		[Address(RVA = "0x1E69D6C", Offset = "0x1E69D6C", VA = "0x1E69D6C", Slot = "6")]
		protected virtual void BeginRun()
		{
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E30")]
		[Address(RVA = "0x1E69D70", Offset = "0x1E69D70", VA = "0x1E69D70", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E31")]
		[Address(RVA = "0x1E69D74", Offset = "0x1E69D74", VA = "0x1E69D74", Slot = "7")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E32")]
		[Address(RVA = "0x1E69D78", Offset = "0x1E69D78", VA = "0x1E69D78", Slot = "8")]
		protected virtual void Draw(GameTime gameTime)
		{
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E33")]
		[Address(RVA = "0x1E69D7C", Offset = "0x1E69D7C", VA = "0x1E69D7C", Slot = "9")]
		protected virtual void EndDraw()
		{
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E34")]
		[Address(RVA = "0x1E69D80", Offset = "0x1E69D80", VA = "0x1E69D80", Slot = "10")]
		protected virtual void EndRun()
		{
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E35")]
		[Address(RVA = "0x1E69D84", Offset = "0x1E69D84", VA = "0x1E69D84")]
		public void Exit()
		{
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E36")]
		[Address(RVA = "0x1E69D88", Offset = "0x1E69D88", VA = "0x1E69D88", Slot = "11")]
		protected virtual void Initialize()
		{
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E37")]
		[Address(RVA = "0x1E69D8C", Offset = "0x1E69D8C", VA = "0x1E69D8C", Slot = "12")]
		protected virtual void LoadContent()
		{
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E38")]
		[Address(RVA = "0x1E69D90", Offset = "0x1E69D90", VA = "0x1E69D90", Slot = "13")]
		protected virtual void OnActivated(object sender, EventArgs args)
		{
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E39")]
		[Address(RVA = "0x1E69D94", Offset = "0x1E69D94", VA = "0x1E69D94", Slot = "14")]
		protected virtual void OnDeactivated(object sender, EventArgs args)
		{
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E3A")]
		[Address(RVA = "0x1E69D98", Offset = "0x1E69D98", VA = "0x1E69D98", Slot = "15")]
		protected virtual void OnExiting(object sender, EventArgs args)
		{
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E3B")]
		[Address(RVA = "0x1E69D9C", Offset = "0x1E69D9C", VA = "0x1E69D9C")]
		public void ResetElapsedTime()
		{
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E3C")]
		[Address(RVA = "0x1E69DA0", Offset = "0x1E69DA0", VA = "0x1E69DA0")]
		public void Run()
		{
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E3D")]
		[Address(RVA = "0x1E69DA4", Offset = "0x1E69DA4", VA = "0x1E69DA4")]
		public void RunOneFrame()
		{
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x0001EB10 File Offset: 0x0001CD10
		[Token(Token = "0x6003E3E")]
		[Address(RVA = "0x1E69DA8", Offset = "0x1E69DA8", VA = "0x1E69DA8", Slot = "16")]
		protected virtual bool ShowMissingRequirementMessage(Exception exception)
		{
			return default(bool);
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E3F")]
		[Address(RVA = "0x1E69DB0", Offset = "0x1E69DB0", VA = "0x1E69DB0")]
		public void SuppressDraw()
		{
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E40")]
		[Address(RVA = "0x1E69DB4", Offset = "0x1E69DB4", VA = "0x1E69DB4")]
		public void Tick()
		{
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E41")]
		[Address(RVA = "0x1E69DB8", Offset = "0x1E69DB8", VA = "0x1E69DB8", Slot = "17")]
		protected virtual void UnloadContent()
		{
		}

		// Token: 0x06003E42 RID: 15938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E42")]
		[Address(RVA = "0x1E69DBC", Offset = "0x1E69DBC", VA = "0x1E69DBC", Slot = "18")]
		protected virtual void Update(GameTime gameTime)
		{
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E43")]
		[Address(RVA = "0x1E69DC0", Offset = "0x1E69DC0", VA = "0x1E69DC0")]
		public Game()
		{
		}
	}
}
