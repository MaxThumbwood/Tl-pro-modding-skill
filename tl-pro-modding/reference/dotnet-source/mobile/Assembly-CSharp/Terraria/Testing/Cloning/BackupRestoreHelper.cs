using System;
using Il2CppDummyDll;

namespace Terraria.Testing.Cloning
{
	// Token: 0x020005F1 RID: 1521
	[Token(Token = "0x20005F1")]
	public abstract class BackupRestoreHelper<T> where T : class
	{
		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06003C6B RID: 15467 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003C6C RID: 15468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A0")]
		public static BackupRestoreHelper<T> Instance
		{
			[Token(Token = "0x6003C6B")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C6C")]
			private set
			{
			}
		}

		// Token: 0x06003C6D RID: 15469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C6D")]
		public static void Register(BackupRestoreHelper<T> helper)
		{
		}

		// Token: 0x06003C6E RID: 15470
		[Token(Token = "0x6003C6E")]
		public abstract T TryQuickBackup(T src, DeepCloneContext ctx);

		// Token: 0x06003C6F RID: 15471
		[Token(Token = "0x6003C6F")]
		public abstract T TryQuickRestore(T backup, T current, DeepCloneContext ctx);

		// Token: 0x06003C70 RID: 15472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C70")]
		protected BackupRestoreHelper()
		{
		}

		// Token: 0x040047BE RID: 18366
		[Token(Token = "0x40047BE")]
		[FieldOffset(Offset = "0x0")]
		private static BackupRestoreHelper<T> <Instance>k__BackingField;
	}
}
