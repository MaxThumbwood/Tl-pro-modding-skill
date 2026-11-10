using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000263 RID: 611
[Token(Token = "0x2000263")]
public class LayoutDefinition
{
	// Token: 0x06000E83 RID: 3715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E83")]
	[Address(RVA = "0xC9568C", Offset = "0xC9568C", VA = "0xC9568C")]
	private static void SerialiseAtPath(BinaryWriter writer, Transform root)
	{
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E84")]
	[Address(RVA = "0xC9597C", Offset = "0xC9597C", VA = "0xC9597C")]
	public static void LoadReleaseLayout()
	{
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x00007968 File Offset: 0x00005B68
	[Token(Token = "0x6000E85")]
	[Address(RVA = "0xC95CD0", Offset = "0xC95CD0", VA = "0xC95CD0")]
	public static bool LoadReleaseLayout(byte[] data)
	{
		return default(bool);
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E86")]
	[Address(RVA = "0xC95948", Offset = "0xC95948", VA = "0xC95948")]
	public void Save(BinaryWriter writer)
	{
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x00007980 File Offset: 0x00005B80
	[Token(Token = "0x6000E87")]
	[Address(RVA = "0xC97C0C", Offset = "0xC97C0C", VA = "0xC97C0C")]
	public static bool IsList(Type value)
	{
		return default(bool);
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E88")]
	[Address(RVA = "0xC96318", Offset = "0xC96318", VA = "0xC96318")]
	private void SaveFields(BinaryWriter writer, Type implementingType, object thisObject)
	{
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E89")]
	[Address(RVA = "0xC962E4", Offset = "0xC962E4", VA = "0xC962E4")]
	public void Load(BinaryReader reader)
	{
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8A")]
	[Address(RVA = "0xC97CEC", Offset = "0xC97CEC", VA = "0xC97CEC")]
	private void LoadFields(BinaryReader reader, Type implementingType, object thisObject)
	{
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x00007998 File Offset: 0x00005B98
	[Token(Token = "0x6000E8B")]
	[Address(RVA = "0xC95914", Offset = "0xC95914", VA = "0xC95914")]
	public bool RefreshStyles([Optional] string specificStyle)
	{
		return default(bool);
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x000079B0 File Offset: 0x00005BB0
	[Token(Token = "0x6000E8C")]
	[Address(RVA = "0xC990D4", Offset = "0xC990D4", VA = "0xC990D4")]
	private bool RefreshFields(Type implementingType, object thisObject, [Optional] string specificStyle)
	{
		return default(bool);
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8D")]
	[Address(RVA = "0xC89F7C", Offset = "0xC89F7C", VA = "0xC89F7C")]
	public LayoutDefinition()
	{
	}

	// Token: 0x04001D60 RID: 7520
	[Token(Token = "0x4001D60")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public string name;

	// Token: 0x04001D61 RID: 7521
	[Token(Token = "0x4001D61")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<LayoutDefinition> UIDefinitions;

	// Token: 0x04001D62 RID: 7522
	[Token(Token = "0x4001D62")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Dictionary<Type, bool> typesEncountered;

	// Token: 0x04001D63 RID: 7523
	[Token(Token = "0x4001D63")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static StringBuilder output;
}
