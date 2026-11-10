using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework
{
	// Token: 0x020003A7 RID: 935
	[Token(Token = "0x20003A7")]
	public class GameComponentCollectionEventArgs : EventArgs
	{
		// Token: 0x060018AA RID: 6314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018AA")]
		[Address(RVA = "0xE21650", Offset = "0xE21650", VA = "0xE21650")]
		public GameComponentCollectionEventArgs(IGameComponent gameComponent)
		{
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000267")]
		public IGameComponent GameComponent
		{
			[Token(Token = "0x60018AB")]
			[Address(RVA = "0xE216C0", Offset = "0xE216C0", VA = "0xE216C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002B63 RID: 11107
		[Token(Token = "0x4002B63")]
		[FieldOffset(Offset = "0x8")]
		private IGameComponent _gameComponent;
	}
}
