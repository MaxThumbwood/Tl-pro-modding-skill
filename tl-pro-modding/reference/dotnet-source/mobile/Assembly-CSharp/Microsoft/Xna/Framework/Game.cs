using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200039F RID: 927
	[Token(Token = "0x200039F")]
	public class Game : FileAPI
	{
		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600183C RID: 6204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700024C")]
		public ContentManager Content
		{
			[Token(Token = "0x600183B")]
			[Address(RVA = "0xE1E28C", Offset = "0xE1E28C", VA = "0xE1E28C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600183C")]
			[Address(RVA = "0xE1E294", Offset = "0xE1E294", VA = "0xE1E294")]
			set
			{
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024D")]
		public GraphicsDevice GraphicsDevice
		{
			[Token(Token = "0x600183D")]
			[Address(RVA = "0xE1E29C", Offset = "0xE1E29C", VA = "0xE1E29C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x0000B838 File Offset: 0x00009A38
		// (set) Token: 0x0600183F RID: 6207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700024E")]
		public bool IsActive
		{
			[Token(Token = "0x600183E")]
			[Address(RVA = "0xE1E324", Offset = "0xE1E324", VA = "0xE1E324")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600183F")]
			[Address(RVA = "0xE1E32C", Offset = "0xE1E32C", VA = "0xE1E32C")]
			set
			{
			}
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001840")]
		[Address(RVA = "0xE1E334", Offset = "0xE1E334", VA = "0xE1E334")]
		public Game()
		{
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001841")]
		[Address(RVA = "0xE1E614", Offset = "0xE1E614", VA = "0xE1E614", Slot = "5")]
		protected virtual void Update(GameTime gameTime)
		{
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024F")]
		public GameComponentCollection Components
		{
			[Token(Token = "0x6001842")]
			[Address(RVA = "0xE1E618", Offset = "0xE1E618", VA = "0xE1E618")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001843")]
		[Address(RVA = "0xE1E620", Offset = "0xE1E620", VA = "0xE1E620")]
		public void UnityAwake()
		{
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001844")]
		[Address(RVA = "0xE1E680", Offset = "0xE1E680", VA = "0xE1E680")]
		public void initialiseCallBack(object threadContext)
		{
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001845")]
		[Address(RVA = "0xE1E8B4", Offset = "0xE1E8B4", VA = "0xE1E8B4")]
		public void UnityStart()
		{
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001846")]
		[Address(RVA = "0xE1E9A0", Offset = "0xE1E9A0", VA = "0xE1E9A0")]
		public void UnityServerInitialise()
		{
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001847")]
		[Address(RVA = "0xE1EA80", Offset = "0xE1EA80", VA = "0xE1EA80")]
		public void UnityServerShutdown()
		{
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001848")]
		[Address(RVA = "0xE1EA8C", Offset = "0xE1EA8C", VA = "0xE1EA8C")]
		public void UnityServerUpdate(float elapsedTime)
		{
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001849")]
		[Address(RVA = "0xE1EFA8", Offset = "0xE1EFA8", VA = "0xE1EFA8")]
		public void UnityUpdate(float elapsedTime)
		{
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184A")]
		[Address(RVA = "0xE1F97C", Offset = "0xE1F97C", VA = "0xE1F97C")]
		public void UnityDraw()
		{
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184B")]
		[Address(RVA = "0xE1FC28", Offset = "0xE1FC28", VA = "0xE1FC28", Slot = "6")]
		protected virtual void Draw(GameTime gameTime)
		{
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184C")]
		[Address(RVA = "0xE1FC2C", Offset = "0xE1FC2C", VA = "0xE1FC2C", Slot = "7")]
		protected virtual void Initialize()
		{
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184D")]
		[Address(RVA = "0xE1FC3C", Offset = "0xE1FC3C", VA = "0xE1FC3C", Slot = "8")]
		protected virtual void LoadContent()
		{
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184E")]
		[Address(RVA = "0xE1FC40", Offset = "0xE1FC40", VA = "0xE1FC40", Slot = "9")]
		protected virtual void UnloadContent()
		{
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184F")]
		[Address(RVA = "0xE1FC44", Offset = "0xE1FC44", VA = "0xE1FC44", Slot = "10")]
		protected virtual void Exit()
		{
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000250")]
		public GameWindow Window
		{
			[Token(Token = "0x6001850")]
			[Address(RVA = "0xE1FC48", Offset = "0xE1FC48", VA = "0xE1FC48")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000251")]
		public GameServiceContainer Services
		{
			[Token(Token = "0x6001851")]
			[Address(RVA = "0xE1FCBC", Offset = "0xE1FCBC", VA = "0xE1FCBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001852")]
		[Address(RVA = "0xE1FD58", Offset = "0xE1FD58", VA = "0xE1FD58")]
		internal void Run()
		{
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001853")]
		[Address(RVA = "0xE1FDA4", Offset = "0xE1FDA4", VA = "0xE1FDA4", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001854")]
		[Address(RVA = "0xE1FDA8", Offset = "0xE1FDA8", VA = "0xE1FDA8")]
		internal void Begin()
		{
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001855")]
		[Address(RVA = "0xE1FDAC", Offset = "0xE1FDAC", VA = "0xE1FDAC")]
		internal void Tick(float deltaTime)
		{
		}

		// Token: 0x04002B2F RID: 11055
		[Token(Token = "0x4002B2F")]
		[FieldOffset(Offset = "0x8")]
		private GameComponentCollection _components;

		// Token: 0x04002B30 RID: 11056
		[Token(Token = "0x4002B30")]
		[FieldOffset(Offset = "0xC")]
		private ContentManager content;

		// Token: 0x04002B31 RID: 11057
		[Token(Token = "0x4002B31")]
		[FieldOffset(Offset = "0x10")]
		private GraphicsDevice graphicsDevice;

		// Token: 0x04002B32 RID: 11058
		[Token(Token = "0x4002B32")]
		[FieldOffset(Offset = "0x18")]
		private long totalTicks;

		// Token: 0x04002B33 RID: 11059
		[Token(Token = "0x4002B33")]
		[FieldOffset(Offset = "0x20")]
		private bool _active;

		// Token: 0x04002B34 RID: 11060
		[Token(Token = "0x4002B34")]
		[FieldOffset(Offset = "0x21")]
		public bool IsMouseVisible;

		// Token: 0x04002B35 RID: 11061
		[Token(Token = "0x4002B35")]
		[FieldOffset(Offset = "0x22")]
		public bool IsFixedTimeStep;

		// Token: 0x04002B36 RID: 11062
		[Token(Token = "0x4002B36")]
		[FieldOffset(Offset = "0x28")]
		private DateTime _lastUpdate;

		// Token: 0x04002B37 RID: 11063
		[Token(Token = "0x4002B37")]
		[FieldOffset(Offset = "0x30")]
		private DateTime _firstUpdate;

		// Token: 0x04002B38 RID: 11064
		[Token(Token = "0x4002B38")]
		[FieldOffset(Offset = "0x38")]
		private TimeSpan _totalTime;

		// Token: 0x04002B39 RID: 11065
		[Token(Token = "0x4002B39")]
		[FieldOffset(Offset = "0x40")]
		private bool _initialised;

		// Token: 0x04002B3A RID: 11066
		[Token(Token = "0x4002B3A")]
		[FieldOffset(Offset = "0x41")]
		private bool _uiHidden;

		// Token: 0x04002B3B RID: 11067
		[Token(Token = "0x4002B3B")]
		[FieldOffset(Offset = "0x42")]
		private bool _serverRunning;

		// Token: 0x04002B3C RID: 11068
		[Token(Token = "0x4002B3C")]
		[FieldOffset(Offset = "0x0")]
		private static TimeSpan FrameTickTime;

		// Token: 0x04002B3D RID: 11069
		[Token(Token = "0x4002B3D")]
		[FieldOffset(Offset = "0x8")]
		private static TimeSpan FrameClampTickTime;

		// Token: 0x04002B3E RID: 11070
		[Token(Token = "0x4002B3E")]
		[FieldOffset(Offset = "0x10")]
		private static TimeSpan FrameIgnoreTime;

		// Token: 0x04002B3F RID: 11071
		[Token(Token = "0x4002B3F")]
		[FieldOffset(Offset = "0x18")]
		private static GameTime RunGameTime;

		// Token: 0x04002B40 RID: 11072
		[Token(Token = "0x4002B40")]
		[FieldOffset(Offset = "0x20")]
		private static DateTime lastFrameUpdate;

		// Token: 0x04002B41 RID: 11073
		[Token(Token = "0x4002B41")]
		[FieldOffset(Offset = "0x28")]
		private static DateTime[] lastFrameTime;

		// Token: 0x04002B42 RID: 11074
		[Token(Token = "0x4002B42")]
		[FieldOffset(Offset = "0x2C")]
		private static DateTime[] frameTime;

		// Token: 0x04002B43 RID: 11075
		[Token(Token = "0x4002B43")]
		[FieldOffset(Offset = "0x30")]
		private static int frameTimeCounter;

		// Token: 0x04002B44 RID: 11076
		[Token(Token = "0x4002B44")]
		[FieldOffset(Offset = "0x43")]
		private bool updateModeVariable;

		// Token: 0x04002B45 RID: 11077
		[Token(Token = "0x4002B45")]
		[FieldOffset(Offset = "0x44")]
		private int updateCount;

		// Token: 0x04002B46 RID: 11078
		[Token(Token = "0x4002B46")]
		[FieldOffset(Offset = "0x48")]
		private DateTime updateTimeStart;

		// Token: 0x04002B47 RID: 11079
		[Token(Token = "0x4002B47")]
		[FieldOffset(Offset = "0x50")]
		private DateTime lastUpdateTime;

		// Token: 0x04002B48 RID: 11080
		[Token(Token = "0x4002B48")]
		[FieldOffset(Offset = "0x58")]
		private int fpsCount;

		// Token: 0x04002B49 RID: 11081
		[Token(Token = "0x4002B49")]
		[FieldOffset(Offset = "0x5C")]
		private int slowFrameCount;

		// Token: 0x04002B4A RID: 11082
		[Token(Token = "0x4002B4A")]
		[FieldOffset(Offset = "0x60")]
		private int oddFrameCount;

		// Token: 0x04002B4B RID: 11083
		[Token(Token = "0x4002B4B")]
		[FieldOffset(Offset = "0x64")]
		private bool highFrameRate;
	}
}
