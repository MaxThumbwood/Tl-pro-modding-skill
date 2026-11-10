using System;
using Il2CppDummyDll;

namespace Terraria.Social.Base
{
	// Token: 0x0200063B RID: 1595
	[Token(Token = "0x200063B")]
	public abstract class UserJoinToServerRequest
	{
		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06003DF2 RID: 15858 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003DF3 RID: 15859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007AC")]
		internal string UserDisplayName
		{
			[Token(Token = "0x6003DF2")]
			[Address(RVA = "0x1E68810", Offset = "0x1E68810", VA = "0x1E68810")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DF3")]
			[Address(RVA = "0x1E68818", Offset = "0x1E68818", VA = "0x1E68818")]
			private set
			{
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06003DF4 RID: 15860 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003DF5 RID: 15861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007AD")]
		internal string UserFullIdentifier
		{
			[Token(Token = "0x6003DF4")]
			[Address(RVA = "0x1E68820", Offset = "0x1E68820", VA = "0x1E68820")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DF5")]
			[Address(RVA = "0x1E68828", Offset = "0x1E68828", VA = "0x1E68828")]
			private set
			{
			}
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06003DF6 RID: 15862 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003DF7 RID: 15863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000033")]
		public event Action OnAccepted
		{
			[Token(Token = "0x6003DF6")]
			[Address(RVA = "0x1E66D08", Offset = "0x1E66D08", VA = "0x1E66D08")]
			add
			{
			}
			[Token(Token = "0x6003DF7")]
			[Address(RVA = "0x1E68830", Offset = "0x1E68830", VA = "0x1E68830")]
			remove
			{
			}
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06003DF8 RID: 15864 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003DF9 RID: 15865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000034")]
		public event Action OnRejected
		{
			[Token(Token = "0x6003DF8")]
			[Address(RVA = "0x1E66DB8", Offset = "0x1E66DB8", VA = "0x1E66DB8")]
			add
			{
			}
			[Token(Token = "0x6003DF9")]
			[Address(RVA = "0x1E688E0", Offset = "0x1E688E0", VA = "0x1E688E0")]
			remove
			{
			}
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DFA")]
		[Address(RVA = "0x1E67584", Offset = "0x1E67584", VA = "0x1E67584")]
		public UserJoinToServerRequest(string userDisplayName, string fullIdentifier)
		{
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DFB")]
		[Address(RVA = "0x1E68990", Offset = "0x1E68990", VA = "0x1E68990")]
		public void Accept()
		{
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DFC")]
		[Address(RVA = "0x1E689AC", Offset = "0x1E689AC", VA = "0x1E689AC")]
		public void Reject()
		{
		}

		// Token: 0x06003DFD RID: 15869
		[Token(Token = "0x6003DFD")]
		public abstract bool IsValid();

		// Token: 0x06003DFE RID: 15870
		[Token(Token = "0x6003DFE")]
		public abstract string GetUserWrapperText();

		// Token: 0x04004880 RID: 18560
		[Token(Token = "0x4004880")]
		[FieldOffset(Offset = "0x8")]
		private string <UserDisplayName>k__BackingField;

		// Token: 0x04004881 RID: 18561
		[Token(Token = "0x4004881")]
		[FieldOffset(Offset = "0xC")]
		private string <UserFullIdentifier>k__BackingField;
	}
}
