using System;
using Il2CppDummyDll;

namespace Terraria.Testing.Cloning
{
	// Token: 0x020005F0 RID: 1520
	[Token(Token = "0x20005F0")]
	public class ActiveCloneHelper<T> : BackupRestoreHelper<T> where T : class, new()
	{
		// Token: 0x06003C67 RID: 15463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C67")]
		public ActiveCloneHelper(Predicate<T> active, Action<T> setInactive)
		{
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C68")]
		public override T TryQuickBackup(T src, DeepCloneContext ctx)
		{
			return null;
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C69")]
		public override T TryQuickRestore(T backup, T current, DeepCloneContext ctx)
		{
			return null;
		}

		// Token: 0x040047BB RID: 18363
		[Token(Token = "0x40047BB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly T _dummy;

		// Token: 0x040047BC RID: 18364
		[Token(Token = "0x40047BC")]
		[FieldOffset(Offset = "0x0")]
		private readonly Predicate<T> Active;

		// Token: 0x040047BD RID: 18365
		[Token(Token = "0x40047BD")]
		[FieldOffset(Offset = "0x0")]
		private readonly Action<T> SetInactive;
	}
}
