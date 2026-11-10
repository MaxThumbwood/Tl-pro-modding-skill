using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace ReLogic.IO
{
	// Token: 0x02000DFD RID: 3581
	[Token(Token = "0x2000DFD")]
	public class ConsoleOutputMirror : FileAPI
	{
		// Token: 0x060068F2 RID: 26866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F2")]
		[Address(RVA = "0xB83710", Offset = "0xB83710", VA = "0xB83710")]
		public static void ToFile(string path)
		{
		}

		// Token: 0x060068F3 RID: 26867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F3")]
		[Address(RVA = "0xB83898", Offset = "0xB83898", VA = "0xB83898")]
		private ConsoleOutputMirror(string path)
		{
		}

		// Token: 0x060068F4 RID: 26868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F4")]
		[Address(RVA = "0xB83B40", Offset = "0xB83B40", VA = "0xB83B40", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060068F5 RID: 26869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F5")]
		[Address(RVA = "0xB83884", Offset = "0xB83884", VA = "0xB83884", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0400A6C4 RID: 42692
		[Token(Token = "0x400A6C4")]
		[FieldOffset(Offset = "0x0")]
		private static ConsoleOutputMirror _instance;

		// Token: 0x0400A6C5 RID: 42693
		[Token(Token = "0x400A6C5")]
		[FieldOffset(Offset = "0x8")]
		private FileStream _fileStream;

		// Token: 0x0400A6C6 RID: 42694
		[Token(Token = "0x400A6C6")]
		[FieldOffset(Offset = "0xC")]
		private StreamWriter _fileWriter;

		// Token: 0x0400A6C7 RID: 42695
		[Token(Token = "0x400A6C7")]
		[FieldOffset(Offset = "0x10")]
		private TextWriter _newConsoleOutput;

		// Token: 0x0400A6C8 RID: 42696
		[Token(Token = "0x400A6C8")]
		[FieldOffset(Offset = "0x14")]
		private readonly TextWriter _oldConsoleOutput;

		// Token: 0x0400A6C9 RID: 42697
		[Token(Token = "0x400A6C9")]
		[FieldOffset(Offset = "0x18")]
		private bool _disposedValue;

		// Token: 0x02000DFE RID: 3582
		[Token(Token = "0x2000DFE")]
		private class DoubleWriter : TextWriter
		{
			// Token: 0x060068F6 RID: 26870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60068F6")]
			[Address(RVA = "0xB83AC8", Offset = "0xB83AC8", VA = "0xB83AC8")]
			public DoubleWriter(TextWriter first, TextWriter second)
			{
			}

			// Token: 0x17000B3A RID: 2874
			// (get) Token: 0x060068F7 RID: 26871 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000B3A")]
			public override Encoding Encoding
			{
				[Token(Token = "0x60068F7")]
				[Address(RVA = "0xB83C38", Offset = "0xB83C38", VA = "0xB83C38", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x060068F8 RID: 26872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60068F8")]
			[Address(RVA = "0xB83C64", Offset = "0xB83C64", VA = "0xB83C64", Slot = "10")]
			public override void Flush()
			{
			}

			// Token: 0x060068F9 RID: 26873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60068F9")]
			[Address(RVA = "0xB83CB8", Offset = "0xB83CB8", VA = "0xB83CB8", Slot = "13")]
			public override void Write(char value)
			{
			}

			// Token: 0x0400A6CA RID: 42698
			[Token(Token = "0x400A6CA")]
			[FieldOffset(Offset = "0x18")]
			private readonly TextWriter _first;

			// Token: 0x0400A6CB RID: 42699
			[Token(Token = "0x400A6CB")]
			[FieldOffset(Offset = "0x1C")]
			private readonly TextWriter _second;
		}
	}
}
